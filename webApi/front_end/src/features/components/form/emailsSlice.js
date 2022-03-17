// @ts-nocheck
import { createSlice, createEntityAdapter, createAsyncThunk } from "@reduxjs/toolkit";

const emailAdapter = createEntityAdapter( {
    selectId: ( email ) => email.id,
    sortComparer: ( preEmail, nextEmail ) => preEmail.id.localeCompare( nextEmail.id )
} );

const initialState = {
    status: "idle",
    error: null,
    checked: false,
    selectedEmail: {},
    emails: {
        ids: [],
        entities: {}
    }
};

export const fetchEmails = createAsyncThunk( "emails/fetchEmails",
    async () =>
    {
        try
        {
            const response = await fetch( "/api/Email/getall" );
            return await response.json();
        } catch ( error )
        {
            return error;
        }
    } );

export const fetchEmailById = createAsyncThunk( "emails/fetchEmailById",
    async ( id ) =>
    {
        try
        {
            const response = await fetch( `/api/Email/getbyid${ id }` );
            return await response.json();
        } catch ( error )
        {
            return error;
        }
    } );

export const AddEmail = createAsyncThunk( "emails/addEmail",
    async ( email ) =>
    {
        try
        {
            const addedEmail = await fetch( "/api/Email/add",
                {
                    method: "POST",
                    body: JSON.stringify( email ),
                    headers: {
                        'Content-Type': "application/json"
                    }
                } ).then( response => response.json() );
            return addedEmail;
        } catch ( error )
        {
            return error;
        }
    } );

export const updateEmailPassword = createAsyncThunk( "emails/updateEmailPassword",
    async ( email ) =>
    {
        try
        {
            const updatedEmail = await fetch( `/api/Email/update${ email.id }`,
                {
                    method: "PUT",
                    body: JSON.stringify( email ),
                    headers: {
                        'Content-Type': "application/json"
                    }
                } ).then( response => response.json() );
            return updatedEmail;
        } catch ( error )
        {
            return error;
        }
    } );

export const deleteEmail = createAsyncThunk( "emails/deleteEmail",
    async ( id ) =>
    {
        try
        {
            const response = await fetch( `/api/Email/delete${ id }`,
                {
                    method: "DELETE"
                } ).then( response => response.json() );
            return response;
        } catch ( error )
        {
            return error;
        }
    } );

const sliceInvoker = () =>
{
    return {
        name: "emails",
        initialState,
        reducers: {
            setChecked: ( state, action ) =>
            {
                state.checked = action.payload;
            }, // setChecked
            setSelectedEmail: ( state, action ) =>
            {
                state.selectedEmail = action.payload;
            }, // setSelectedEmail
            setStatus: ( state, action ) =>
            {
                state.status = action.payload;
            }, // setStatus
        },
        extraReducers: {
            [ fetchEmails.pending ]: ( state, action ) =>
            {
                state.status = "loading";
            },
            [ fetchEmails.fulfilled ]: ( state, action ) =>
            {
                state.status = "succeeded";
                emailAdapter.setAll( state, action.payload );
            },
            [ fetchEmails.rejected ]: ( state, action ) =>
            {
                state.status = "failed";
                state.error = action.payload;
            },
            [ fetchEmailById.pending ]: ( state, action ) =>
            {
                state.status = "loading";
            },
            [ fetchEmailById.fulfilled ]: ( state, action ) =>
            {
                state.status = "succeeded";
                state.selectedEmail = action.payload;
            },
            [ fetchEmailById.rejected ]: ( state, action ) =>
            {
                state.status = "failed";
                state.error = action.payload;
            },
            [ AddEmail.pending ]: ( state, action ) =>
            {
                state.status = "loading";
            },
            [ AddEmail.fulfilled ]: ( state, action ) =>
            {
                state.status = "succeeded";
                emailAdapter.addOne( state, action.payload );
            },
            [ AddEmail.rejected ]: ( state, action ) =>
            {
                state.status = "failed";
                state.error = action.payload;
            },
            [ updateEmailPassword.pending ]: ( state, action ) =>
            {
                state.status = "loading";
            },
            [ updateEmailPassword.fulfilled ]: ( state, action ) =>
            {
                state.status = "succeeded";
                state.selectedEmail = action.payload;
            },
            [ updateEmailPassword.rejected ]: ( state, action ) =>
            {
                state.status = "failed";
                state.error = action.payload;
            },
            [ deleteEmail.pending ]: ( state, action ) =>
            {
                state.status = "loading";
            },
            [ deleteEmail.fulfilled ]: ( state, action ) =>
            {
                state.status = "succeeded";
                emailAdapter.removeOne( state, action.payload );
            },
            [ deleteEmail.rejected ]: ( state, action ) =>
            {
                state.status = "failed";
                state.error = action.payload;
            }

        }
    };
};

const emailsSlice = createSlice( sliceInvoker() );

export const {
    selectAll: selectAllEmails,
    selectById: selectEmailById,
    selectIds: selectAllEmailIds,
    selectEntities: selectAllEmailEntities,
    selectTotal: selectTotalEmails
} = emailAdapter.getSelectors( state => state.emails );

export const {
    setChecked,
    setSelectedEmail,
    setStatus
} = emailsSlice.actions;

export default emailsSlice.reducer;