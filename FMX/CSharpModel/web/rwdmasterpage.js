/*!   GeneXus C# 16_0_2-131213 on 7/11/2019 12:29:29.34
*/
gx.evt.autoSkip=!1;gx.define("rwdmasterpage",!1,function(){this.ServerClass="rwdmasterpage";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.IsMasterPage=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.e14042_client=function(){return this.executeServerEvent("ENTER_MPAGE",!0,null,!1,!1)};this.e15042_client=function(){return this.executeServerEvent("CANCEL_MPAGE",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,18,19,20,21,22];this.GXLastCtrlId=22;n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"HEADER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"APPLICATIONHEADER",format:0,grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"IMAGE1",grid:0};n[12]={id:12,fld:"",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"RECENT",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"CONTENT",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"",grid:0};this.Events={e14042_client:["ENTER_MPAGE",!0],e15042_client:["CANCEL_MPAGE",!0]};this.EvtParms.REFRESH_MPAGE=[[{ctrl:"FORM_MPAGE",prop:"Caption"}],[{ctrl:"WCRECENTLINKS_MPAGE"}]];this.EvtParms.START_MPAGE=[[],[]];this.Initialize();this.setComponent({id:"WCRECENTLINKS",GXClass:null,Prefix:"MPW0017",lvl:1})});gx.wi(function(){gx.createMasterPage(rwdmasterpage)})