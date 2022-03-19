// @ts-nocheck
import { createEntityAdapter, createSlice } from '@reduxjs/toolkit';
import bazararasdirmasi from './../about/assets/img/about-us/market-research.png';
import biznesplan from './../about/assets/img/about-us/business-plan.png';
import kapitallasma from './../about/assets/img/about-us/capitallismus.png';
import satisvemarketing from './../about/assets/img/about-us/sales-marketing.png';
import strategyandfinance from './../about/assets/img/about-us/strategy-finance.png';
import teskilati from './../about/assets/img/about-us/organizational.png';

const servicesAdapter = createEntityAdapter({
  selectId: (service) => service.id,
  sortComparer: (previousService, nextService) => previousService.id.localeComparer(nextService.id)
});

const initialState = {
  status: 'idle',
  error: null,
  selectedService: {},
  services: {
    ids: ['id1', 'id2', 'id3', 'id4', 'id5', 'id6'],
    entities: {
      id1: { id: 'id1', name: 'Bazar Araşdırması', img: bazararasdirmasi, to: '/services/marketresearch' },
      id2: { id: 'id2', name: 'Biznes Plan və TİƏ ', img: biznesplan, to: '/services/businessplan' },
      id3: { id: 'id3', name: 'Kapitallaşma', img: kapitallasma, to: '/services/investmentable' },
      id4: { id: 'id4', name: 'Satış və Marketinq', img: satisvemarketing, to: '/services/marketing' },
      id5: { id: 'id5', name: 'Strategiya və Maliyyə', img: strategyandfinance, to: '/services/finance' },
      id6: { id: 'id6', name: 'Təşkilati', img: teskilati, to: '/services/companyable' }
    }
  }
};

export const fetchServices = createAsyncThunk('services/fetchServices', async () => {
  try {
    const response = await fetch('/api/Service/getall');
    return await response.json();
  } catch (error) {
    return error;
  }
});

export const fetchServiceById = createAsyncThunk('services/fetchServiceById', async (id) => {
  try {
    const response = await fetch(`/api/Service/getbyid/${id}`);
    return await response.json();
  } catch (error) {
    return error;
  }
});

export const addService = createAsyncThunk('services/addService', async (service) => {
  try {
    const addedService = await fetch('/api/Service/add', {
      method: 'POST',
      body: JSON.stringify(service),
      headers: {
        'Content-Type': 'application/json'
      }
    }).then((response) => response.json());
    return addedService;
  } catch (error) {
    return error;
  }
});

export const deleteService = createAsyncThunk('services/deleteService', async (id) => {
  try {
    const response = await fetch(`/api/Service/delete/${id}`, {
      method: 'DELETE'
    }).then((response) => response.json());
    return response;
  } catch (error) {
    return error;
  }
});

const sliceInvoker = () => {
  return {
    name: 'slices',
    initialState,
    reducers: {
      setChecked: (state, action) => {
        state.checked = action.payload;
      }, // setChecked
      setSelectedService: (state, action) => {
        state.selectedService = action.payload;
      }, // setSelectedService
      setStatus: (state, action) => {
        state.status = action.payload;
      } // setStatus
    },
    extraReducers: {
      [fetchServices.pending]: (state, action) => {
        state.status = 'loading';
      },
      [fetchServices.fulfilled]: (state, action) => {
        state.status = 'succeeded';
        servicesAdapter.setAll(state, action.payload);
      },
      [fetchServices.rejected]: (state, action) => {
        state.status = 'failed';
        state.error = action.payload;
      },
      [fetchServiceById.pending]: (state, action) => {
        state.status = 'loading';
      },
      [fetchServiceById.fulfilled]: (state, action) => {
        state.status = 'succeeded';
        state.selectedEmail = action.payload;
      },
      [fetchServiceById.rejected]: (state, action) => {
        state.status = 'failed';
        state.error = action.payload;
      },
      [addService.pending]: (state, action) => {
        state.status = 'loading';
      },
      [addService.fulfilled]: (state, action) => {
        state.status = 'succeeded';
        servicesAdapter.addOne(state, action.payload);
      },
      [addService.rejected]: (state, action) => {
        state.status = 'failed';
        state.error = action.payload;
      },
      [deleteService.pending]: (state, action) => {
        state.status = 'loading';
      },
      [deleteService.fulfilled]: (state, action) => {
        state.status = 'succeeded';
        servicesAdapter.removeOne(state, action.payload);
      },
      [deleteService.rejected]: (state, action) => {
        state.status = 'failed';
        state.error = action.payload;
      }
    }
  };
};

const servicesSlice = createSlice(sliceInvoker());

export const {
  selectAll: selectAllServices,
  selectById: selectServiceById,
  selectIds: selectAllServicesIds,
  selectEntities: selectAllServiceEntities,
  selectTotal: selectTotalServices
} = servicesAdapter.getSelectors((state) => state.services);

export const { setChecked, setSelectedEmail, setStatus } = emailsSlice.actions;

export default servicesSlice.reducer;
