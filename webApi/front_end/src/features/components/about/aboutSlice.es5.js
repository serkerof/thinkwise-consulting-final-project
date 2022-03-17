// @ts-nocheck
'use strict';

Object.defineProperty(exports, '__esModule', {
    value: true
});

var _this = this;

function _interopRequireDefault(obj) { return obj && obj.__esModule ? obj : { 'default': obj }; }

function _defineProperty(obj, key, value) { if (key in obj) { Object.defineProperty(obj, key, { value: value, enumerable: true, configurable: true, writable: true }); } else { obj[key] = value; } return obj; }

var _reduxjsToolkit = require("@reduxjs/toolkit");

var _homeAssetsImgTeamAynurPng = require('./../home/assets/img/team-aynur.png');

var _homeAssetsImgTeamAynurPng2 = _interopRequireDefault(_homeAssetsImgTeamAynurPng);

var _homeAssetsImgTeamChingizPng = require('./../home/assets/img/team-chingiz.png');

var _homeAssetsImgTeamChingizPng2 = _interopRequireDefault(_homeAssetsImgTeamChingizPng);

var _homeAssetsImgTeamRamazanPng = require('./../home/assets/img/team-ramazan.png');

var _homeAssetsImgTeamRamazanPng2 = _interopRequireDefault(_homeAssetsImgTeamRamazanPng);

var _homeAssetsImgTeamAynurePng = require('./../home/assets/img/team-aynure.png');

var _homeAssetsImgTeamAynurePng2 = _interopRequireDefault(_homeAssetsImgTeamAynurePng);

var _homeAssetsImgTeamQuestionPng = require('./../home/assets/img/team-question.png');

var _homeAssetsImgTeamQuestionPng2 = _interopRequireDefault(_homeAssetsImgTeamQuestionPng);

var _homeAssetsImgTeamMehemmedPng = require('./../home/assets/img/team-mehemmed.png');

var _homeAssetsImgTeamMehemmedPng2 = _interopRequireDefault(_homeAssetsImgTeamMehemmedPng);

var aboutAdapter = (0, _reduxjsToolkit.createEntityAdapter)({
    selectId: function selectId(teamMember) {
        return teamMember.id;
    },
    sortComparer: function sortComparer(preMember, nextMember) {
        return preMember.id.localeComparer(nextMember.id);
    }
});

var initialState = {
    error: null,
    status: 'idle',
    selectedMember: {},
    members: {
        ids: ["id1", "id2", "id3", "id4", "id5", "id6"],
        entities: {
            id1: {
                id: "id1",
                name: "Aynur Nizamova",
                position: "Biznes Konsultant",
                education: "Azərbaycan Dövlət İqtisad Universiteti, Dünya İqtisadiyyatı",
                img: _homeAssetsImgTeamAynurPng2['default']
            },
            id2: {
                id: "id2",
                name: "Çingiz Novruzzadə",
                position: "Təsisçi və Direktor",
                education: "İUBH International Management və Univeristy of East Anglia Investment and Financial Management",
                img: _homeAssetsImgTeamChingizPng2['default']
            },
            id3: {
                id: "id3",
                name: "Ramazan Əliquliyev",
                position: "Satış və Marketinq",
                education: "Saint Petersburg, Polytechnic University, Digital Marketing and E-Commerce",
                img: _homeAssetsImgTeamRamazanPng2['default']
            },
            id4: {
                id: "id4",
                name: "Rahilə Kosayeva",
                position: "Layihə Meneceri",
                education: "Azərbaycan Dillər Universiteti, İngilis dili və Shawnee State University, Beynəlxalq Əlaqələr",
                img: _homeAssetsImgTeamAynurePng2['default']
            },
            id5: {
                id: "id5",
                name: "Elnur Şabanov",
                position: "Aparıcı Biznes Konsultant",
                education: "Azərbaycan Dövlət İqtisad Universiteti, Beynəlxalq Ticarət və Kommersiya",
                img: _homeAssetsImgTeamQuestionPng2['default']
            },
            id6: {
                id: "id6",
                name: "Məhəmməd Şıxıyev",
                position: "Aparıcı Data Analitik",
                education: " French-Azerbaijani University, BS Geoscience",
                img: _homeAssetsImgTeamMehemmedPng2['default']
            }
        }
    }
};

var fetchMembers = (0, _reduxjsToolkit.createAsyncThunk)('about/fetchMembers', function callee$0$0() {
    var request;
    return regeneratorRuntime.async(function callee$0$0$(context$1$0) {
        while (1) switch (context$1$0.prev = context$1$0.next) {
            case 0:
                context$1$0.prev = 0;
                context$1$0.next = 3;
                return regeneratorRuntime.awrap(fetch('/api/employeesgetall'));

            case 3:
                request = context$1$0.sent;
                context$1$0.next = 6;
                return regeneratorRuntime.awrap(request.json());

            case 6:
                return context$1$0.abrupt('return', context$1$0.sent);

            case 9:
                context$1$0.prev = 9;
                context$1$0.t0 = context$1$0['catch'](0);
                return context$1$0.abrupt('return', context$1$0.t0);

            case 12:
            case 'end':
                return context$1$0.stop();
        }
    }, null, _this, [[0, 9]]);
});

exports.fetchMembers = fetchMembers;
var fetchMemberById = (0, _reduxjsToolkit.createAsyncThunk)('about/fetchMemberById', function callee$0$0(id) {
    var request;
    return regeneratorRuntime.async(function callee$0$0$(context$1$0) {
        while (1) switch (context$1$0.prev = context$1$0.next) {
            case 0:
                context$1$0.prev = 0;
                context$1$0.next = 3;
                return regeneratorRuntime.awrap(fetch('/api/employeesgetone?id=' + id));

            case 3:
                request = context$1$0.sent;
                context$1$0.next = 6;
                return regeneratorRuntime.awrap(request.json());

            case 6:
                return context$1$0.abrupt('return', context$1$0.sent);

            case 9:
                context$1$0.prev = 9;
                context$1$0.t0 = context$1$0['catch'](0);
                return context$1$0.abrupt('return', context$1$0.t0);

            case 12:
            case 'end':
                return context$1$0.stop();
        }
    }, null, _this, [[0, 9]]);
});

exports.fetchMemberById = fetchMemberById;
var addMember = (0, _reduxjsToolkit.createAsyncThunk)('about/addMember', function callee$0$0(member) {
    var request;
    return regeneratorRuntime.async(function callee$0$0$(context$1$0) {
        while (1) switch (context$1$0.prev = context$1$0.next) {
            case 0:
                context$1$0.prev = 0;
                context$1$0.next = 3;
                return regeneratorRuntime.awrap(fetch('/api/employeesadd', {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify(member)
                }));

            case 3:
                request = context$1$0.sent;
                context$1$0.next = 6;
                return regeneratorRuntime.awrap(request.json());

            case 6:
                return context$1$0.abrupt('return', context$1$0.sent);

            case 9:
                context$1$0.prev = 9;
                context$1$0.t0 = context$1$0['catch'](0);
                return context$1$0.abrupt('return', context$1$0.t0);

            case 12:
            case 'end':
                return context$1$0.stop();
        }
    }, null, _this, [[0, 9]]);
});

exports.addMember = addMember;
var updateMember = (0, _reduxjsToolkit.createAsyncThunk)('about/updateMember', function callee$0$0(member) {
    var request;
    return regeneratorRuntime.async(function callee$0$0$(context$1$0) {
        while (1) switch (context$1$0.prev = context$1$0.next) {
            case 0:
                context$1$0.prev = 0;
                context$1$0.next = 3;
                return regeneratorRuntime.awrap(fetch('/api/employeesupdate' + ('/' + member.id), {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify(member)
                }));

            case 3:
                request = context$1$0.sent;
                context$1$0.next = 6;
                return regeneratorRuntime.awrap(request.json());

            case 6:
                return context$1$0.abrupt('return', context$1$0.sent);

            case 9:
                context$1$0.prev = 9;
                context$1$0.t0 = context$1$0['catch'](0);
                return context$1$0.abrupt('return', context$1$0.t0);

            case 12:
            case 'end':
                return context$1$0.stop();
        }
    }, null, _this, [[0, 9]]);
});

exports.updateMember = updateMember;
var deleteMember = (0, _reduxjsToolkit.createAsyncThunk)('about/deleteMember', function callee$0$0(id) {
    var request;
    return regeneratorRuntime.async(function callee$0$0$(context$1$0) {
        while (1) switch (context$1$0.prev = context$1$0.next) {
            case 0:
                context$1$0.prev = 0;
                context$1$0.next = 3;
                return regeneratorRuntime.awrap(fetch('/api/employeesdelete' + ('/' + id)));

            case 3:
                request = context$1$0.sent;
                context$1$0.next = 6;
                return regeneratorRuntime.awrap(request.json());

            case 6:
                return context$1$0.abrupt('return', context$1$0.sent);

            case 9:
                context$1$0.prev = 9;
                context$1$0.t0 = context$1$0['catch'](0);
                return context$1$0.abrupt('return', context$1$0.t0);

            case 12:
            case 'end':
                return context$1$0.stop();
        }
    }, null, _this, [[0, 9]]);
});

exports.deleteMember = deleteMember;
var sliceInvoker = function sliceInvoker() {
    var _extraReducers;

    return {
        name: 'about',
        initialState: initialState,
        reducers: {},
        extraReducers: (_extraReducers = {}, _defineProperty(_extraReducers, fetchMembers.fulfilled, function (state, action) {
            state.status = 'succeeded';
            aboutAdapter.setAll(state, action.payload);
        }), _defineProperty(_extraReducers, fetchMembers.rejected, function (state, action) {
            state.error = action.payload.error.message;
            state.status = 'failed';
        }), _defineProperty(_extraReducers, fetchMembers.pending, function (state, action) {
            state.status = 'loading';
        }), _defineProperty(_extraReducers, fetchMemberById.fulfilled, function (state, action) {
            state.status = 'succeeded';
            state.selectedMember = action.payload;
        }), _defineProperty(_extraReducers, addMember.fulfilled, function (state, action) {
            state.status = 'succeeded';
            aboutAdapter.addOne(state, action.payload);
        }), _defineProperty(_extraReducers, addMember.rejected, function (state, action) {
            state.status = 'failed';
            state.error = action.payload.error.message;
        }), _defineProperty(_extraReducers, addMember.pending, function (state, action) {
            state.status = 'loading';
        }), _extraReducers)
    };
};

var aboutSlice = (0, _reduxjsToolkit.createSlice)(sliceInvoker());

var _aboutAdapter$getSelectors = aboutAdapter.getSelectors(function (state) {
    return state.about.members;
});

var selectAllMembers = _aboutAdapter$getSelectors.selectAll;
var selectMemberById = _aboutAdapter$getSelectors.selectById;
var selectMemberIds = _aboutAdapter$getSelectors.selectIds;
var selectMemberEntities = _aboutAdapter$getSelectors.selectEntities;
var selectMemberTotal = _aboutAdapter$getSelectors.selectTotal;
exports.selectAllMembers = selectAllMembers;
exports.selectMemberById = selectMemberById;
exports.selectMemberIds = selectMemberIds;
exports.selectMemberEntities = selectMemberEntities;
exports.selectMemberTotal = selectMemberTotal;
exports['default'] = aboutSlice.reducer;

