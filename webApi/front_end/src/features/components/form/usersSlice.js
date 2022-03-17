// @ts-nocheck
import { createSlice, createEntityAdapter, createAsyncThunk } from '@reduxjs/toolkit';

const usersAdapter = createEntityAdapter({
    selectId: (user) => user.id,
    sortComparer: (preUser, nextUser) => preUser.id.localeCompare(nextUser.id)
});

const initialState = {
    error: null,
    status: 'idle',
    checked: false,
    currentUser: {},
    users: {
        ids: [],
        entities: {
            id1: {}
        }
    }
};

export const fetchUsers = createAsyncThunk('users/fetchUsers', async () => {
    try {
        const response = await fetch('/api/getallusers');
        return await response.json();
    } catch (error) {
        return error;
    }
})

export const getUserById = createAsyncThunk('users/getUserById', async (userId) => {
    try {
        const response = await fetch('/api/getuserbyid/' + userId);
        return await response.json();
    } catch (error) {
        return error;
    }
})

export const addUsers = createAsyncThunk('users/addUsers', async (user) => {
    try {
        const addedUsers = await fetch('/api/addusers', {
            method: 'POST',
            body: JSON.stringify(user),
            headers: {
                'Content-Type': 'application/json'
            }
        })
        return await addedUsers.json()
    }
    catch (error) {
        return error;
    }
})

export const updatePassword = createAsyncThunk('users/updatePassword', async (user) => {
    try {
        const response = await fetch('/api/users/updatepassword', {
            method: 'PUT',
            body: JSON.stringify(user),
            headers: {
                'Content-Type': 'application/json'
            }
        })
        return await response.json()
    }
    catch (error) {
        return error
    }
})

export const deleteUsers = createAsyncThunk('users/deleteUsers', async (userId) => {
    try {
        const response = await fetch(`/api/deleteusers/${userId}`, {
            method: 'DELETE'
        })
        return await response.json()
    } catch (error) {
        return error
    }
})

const usersSlice = createSlice(sliceInvoker());

function sliceInvoker() {
    return {
        name: 'users',
        initialState,
        reducers: {
            setCurrentUser: (state, action) => {
                state.currentUser = action.payload;
            },
            setUsers: (state, action) => {
                usersAdapter.setAll(state, action.payload);
            },
            setChecked: (state, action) => {
                state.checked = action.payload;
            }
        },
        extraReducers: {
            [fetchUsers.pending]: (state, action) => {
                state.status = 'loading';
            },
            [fetchUsers.fulfilled]: (state, action) => {
                state.status = 'succeeded';
                usersAdapter.setAll(state, action.payload);
            },
            [fetchUsers.rejected]: (state, action) => {
                state.status = 'failed';
                state.error = action.error.message;
            },
            [getUserById.pending]: (state, action) => {
                state.status = 'loading';
            },
            [getUserById.fulfilled]: (state, action) => {
                state.status = 'succeeded';
                state.currentUser = action.payload;
            },
            [getUserById.rejected]: (state, action) => {
                state.status = 'failed';
                state.error = action.error.message;
            },
            [addUsers.pending]: (state, action) => {
                state.status = 'loading';
            },
            [addUsers.fulfilled]: (state, action) => {
                state.status = 'succeeded';
                state.users = usersAdapter.addOne(state, action.payload);
            },
            [addUsers.rejected]: (state, action) => {
                state.status = 'failed';
                state.error = action.error.message;
            },
            [updatePassword.pending]: (state, action) => {
                state.status = 'loading';
            }
            ,
            [updatePassword.fulfilled]: (state, action) => {
                state.status = 'succeeded';
                usersAdapter.updateOne(state, { id: action.payload.id, changes: action.payload });
            },
            [updatePassword.rejected]: (state, action) => {
                state.status = 'failed';
                state.error = action.error.message;
            },
            [deleteUsers.pending]: (state, action) => {
                state.status = 'loading';
            },
            [deleteUsers.fulfilled]: (state, action) => {
                state.status = 'succeeded';
                usersAdapter.removeOne(state, action.payload)
            },
            [deleteUsers.rejected]: (state, action) => {
                state.status = 'failed';
                state.error = action.error.message;
            }
        }
    }
}

export const {
    selectAll: selectAllUsers,
    selectById: selectUserById,
    selectIds: selectAllUserIds
} = usersAdapter.getSelectors((state) => state.users.users);

export const { setUsers, setCurrentUser, setChecked } = usersSlice.actions;

export default usersSlice.reducer;