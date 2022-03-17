import { createSlice, createEntityAdapter, createAsyncThunk } from '@reduxjs/toolkit';

const adapterCreator = () =>
{
    return {
        selectId: ( article ) => article.id,
        sortComparer: ( preArticle, nextArticle ) => preArticle.id.localeCompare( nextArticle.id )
    };
};

export const fetchArticles = createAsyncThunk( 'articles/fetchArticles', async () =>
{
    try
    {
        let request = await fetch( 'api/getarticles' )
        return await request.json()
    }
    catch ( error )
    {
        return error
    }
} )

export const fetchArticleById = createAsyncThunk( 'articles/fetchArticleById', async ( articleID ) =>
{
    try
    {
        let request = await fetch( `/api/getarticle${ articleID }` )
        return await request.json()
    } catch ( error )
    {
        return error
    }
} )

const articlesAdapter = createEntityAdapter( adapterCreator() );

const initialState = {
    error: null,
    status: 'idle',
    selectedArticle: {},
    articles: {
        ids: [ 'ids1', 'ids2', 'ids3', 'ids4', 'ids5' ],
        entities: {
            ids1: {
                id: 'ids1',
                name: 'NETFLIX',
                description: 'Netflix biznes modelini necə dəyişdi',
                date: new Date( 2021, 9, 8 ).toISOString(),
                author: 'Anar İsmayılov',
            },
            ids2: {
                id: 'ids2',
                name: 'LOGISTIKA',
                description: 'Logistika',
                date: new Date( 2021, 11, 23 ).toISOString(),
                author: 'Çingiz Novruzzadə',
            },
            ids3: {
                id: 'ids3',
                name: 'ALKOQOL',
                description: 'Böyüyən qlobal industriya satışları istehlak dalğası üzərində deyil',
                date: new Date( 2021, 9, 14 ).toISOString(),
                author: 'Anar İsmayılov',
            },
            ids4: {
                id: 'ids4',
                name: 'STARTAP',
                description: 'Azərbaycanın startap ekosisteminin çətinliyi hansılardır?',
                date: new Date( 2021, 8, 7 ).toISOString(),
                author: 'Anar İsmayılov',
            },
            ids5: {
                id: 'ids5',
                name: 'MALIYYƏ',
                description: 'Söhbət şirkətlərin özlərini maliyyələşdirməsindən gedirsə, cavab sadəcə faiz dərəcələrindən asılı deyil',
                date: new Date( 2022, 0, 18 ).toISOString(),
                author: 'Anar İsmayılov',
            }
        }
    }
};

const sliceInvoker = () =>
{
    return {
        name: 'articles',
        initialState,
        reducers: {},
        extraReducers: {}
    };
};

const articlesSlice = createSlice( sliceInvoker() );

export const {
    selectAll: selectAllArticles,
    selectById: selectArticleById,
    selectIds: selectAllArticlesIds
} = articlesAdapter.getSelectors( ( state ) => state.articles.articles );

export default articlesSlice.reducer;