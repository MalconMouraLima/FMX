/*!   GeneXus C# 16_0_2-131213 on 7/12/2019 16:32:35.43
*/
gx.evt.autoSkip=!1;gx.define("pedidogeneral",!0,function(n){this.ServerClass="pedidogeneral";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.Valid_Pedidoid=function(){try{var n=gx.util.balloon.getNew("PEDIDOID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Pessoaid=function(){try{var n=gx.util.balloon.getNew("PESSOAID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e11161_client=function(){return this.clearMessages(),this.call("pedido.aspx",["UPD",this.A32PedidoId]),this.refreshOutputs([]),gx.$.Deferred().resolve()};this.e12161_client=function(){return this.clearMessages(),this.call("pedido.aspx",["DLT",this.A32PedidoId]),this.refreshOutputs([]),gx.$.Deferred().resolve()};this.e15162_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e16162_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,21,22,24,25,26,27,28,29,30,33,34,35,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56];this.GXLastCtrlId=56;t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"TABLE",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"",grid:0};t[9]={id:9,fld:"TRANSACTIONDETAIL_TABLEATTRIBUTES",grid:0};t[10]={id:10,fld:"",grid:0};t[11]={id:11,fld:"",grid:0};t[12]={id:12,fld:"",grid:0};t[13]={id:13,fld:"",grid:0};t[14]={id:14,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Pedidoid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PEDIDOID",gxz:"Z32PedidoId",gxold:"O32PedidoId",gxvar:"A32PedidoId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A32PedidoId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z32PedidoId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("PEDIDOID",gx.O.A32PedidoId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A32PedidoId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("PEDIDOID",".")},nac:gx.falseFn};this.declareDomainHdlr(14,function(){});t[15]={id:15,fld:"",grid:0};t[16]={id:16,fld:"",grid:0};t[17]={id:17,fld:"UNNAMEDGROUP1",grid:0};t[18]={id:18,fld:"TRANSACTIONDETAIL_GP_PESSOA",grid:0};t[21]={id:21,fld:"",grid:0};t[22]={id:22,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Pessoaid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PESSOAID",gxz:"Z1PessoaId",gxold:"O1PessoaId",gxvar:"A1PessoaId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A1PessoaId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1PessoaId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("PESSOAID",gx.O.A1PessoaId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A1PessoaId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("PESSOAID",".")},nac:gx.falseFn};this.declareDomainHdlr(22,function(){});t[24]={id:24,fld:"",grid:0};t[25]={id:25,fld:"",grid:0};t[26]={id:26,lvl:0,type:"svchar",len:60,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PESSOANOME",gxz:"Z2PessoaNome",gxold:"O2PessoaNome",gxvar:"A2PessoaNome",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A2PessoaNome=n)},v2z:function(n){n!==undefined&&(gx.O.Z2PessoaNome=n)},v2c:function(){gx.fn.setControlValue("PESSOANOME",gx.O.A2PessoaNome,0)},c2v:function(){this.val()!==undefined&&(gx.O.A2PessoaNome=this.val())},val:function(){return gx.fn.getControlValue("PESSOANOME")},nac:gx.falseFn};t[27]={id:27,fld:"",grid:0};t[28]={id:28,fld:"",grid:0};t[29]={id:29,fld:"UNNAMEDGROUP2",grid:0};t[30]={id:30,fld:"TRANSACTIONDETAIL_GP_PRAZO",grid:0};t[33]={id:33,fld:"",grid:0};t[34]={id:34,fld:"",grid:0};t[35]={id:35,lvl:0,type:"date",len:8,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PEDIDODT",gxz:"Z33PedidoDt",gxold:"O33PedidoDt",gxvar:"A33PedidoDt",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A33PedidoDt=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z33PedidoDt=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("PEDIDODT",gx.O.A33PedidoDt,0)},c2v:function(){this.val()!==undefined&&(gx.O.A33PedidoDt=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getControlValue("PEDIDODT")},nac:gx.falseFn};t[37]={id:37,fld:"",grid:0};t[38]={id:38,fld:"",grid:0};t[39]={id:39,lvl:0,type:"date",len:8,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PEDIDODTENTREGA",gxz:"Z35PedidoDtEntrega",gxold:"O35PedidoDtEntrega",gxvar:"A35PedidoDtEntrega",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A35PedidoDtEntrega=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z35PedidoDtEntrega=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("PEDIDODTENTREGA",gx.O.A35PedidoDtEntrega,0)},c2v:function(){this.val()!==undefined&&(gx.O.A35PedidoDtEntrega=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getControlValue("PEDIDODTENTREGA")},nac:gx.falseFn};t[40]={id:40,fld:"",grid:0};t[41]={id:41,fld:"",grid:0};t[42]={id:42,fld:"",grid:0};t[43]={id:43,fld:"",grid:0};t[44]={id:44,lvl:0,type:"svchar",len:3,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PEDIDOSTATUS",gxz:"Z34PedidoStatus",gxold:"O34PedidoStatus",gxvar:"A34PedidoStatus",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(n){n!==undefined&&(gx.O.A34PedidoStatus=n)},v2z:function(n){n!==undefined&&(gx.O.Z34PedidoStatus=n)},v2c:function(){gx.fn.setComboBoxValue("PEDIDOSTATUS",gx.O.A34PedidoStatus);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A34PedidoStatus=this.val())},val:function(){return gx.fn.getControlValue("PEDIDOSTATUS")},nac:gx.falseFn};this.declareDomainHdlr(44,function(){});t[45]={id:45,fld:"",grid:0};t[46]={id:46,fld:"",grid:0};t[47]={id:47,fld:"",grid:0};t[48]={id:48,fld:"",grid:0};t[49]={id:49,lvl:0,type:"boolean",len:4,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PEDIDORETIRADA",gxz:"Z36PedidoRetirada",gxold:"O36PedidoRetirada",gxvar:"A36PedidoRetirada",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",v2v:function(n){n!==undefined&&(gx.O.A36PedidoRetirada=gx.lang.booleanValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z36PedidoRetirada=gx.lang.booleanValue(n))},v2c:function(){gx.fn.setCheckBoxValue("PEDIDORETIRADA",gx.O.A36PedidoRetirada,!0)},c2v:function(){this.val()!==undefined&&(gx.O.A36PedidoRetirada=gx.lang.booleanValue(this.val()))},val:function(){return gx.fn.getControlValue("PEDIDORETIRADA")},nac:gx.falseFn,values:["true","false"]};t[50]={id:50,fld:"",grid:0};t[51]={id:51,fld:"",grid:0};t[52]={id:52,fld:"",grid:0};t[53]={id:53,fld:"",grid:0};t[54]={id:54,fld:"BTNUPDATE",grid:0};t[55]={id:55,fld:"",grid:0};t[56]={id:56,fld:"BTNDELETE",grid:0};this.A32PedidoId=0;this.Z32PedidoId=0;this.O32PedidoId=0;this.A1PessoaId=0;this.Z1PessoaId=0;this.O1PessoaId=0;this.A2PessoaNome="";this.Z2PessoaNome="";this.O2PessoaNome="";this.A33PedidoDt=gx.date.nullDate();this.Z33PedidoDt=gx.date.nullDate();this.O33PedidoDt=gx.date.nullDate();this.A35PedidoDtEntrega=gx.date.nullDate();this.Z35PedidoDtEntrega=gx.date.nullDate();this.O35PedidoDtEntrega=gx.date.nullDate();this.A34PedidoStatus="";this.Z34PedidoStatus="";this.O34PedidoStatus="";this.A36PedidoRetirada=!1;this.Z36PedidoRetirada=!1;this.O36PedidoRetirada=!1;this.A32PedidoId=0;this.A1PessoaId=0;this.A2PessoaNome="";this.A33PedidoDt=gx.date.nullDate();this.A35PedidoDtEntrega=gx.date.nullDate();this.A34PedidoStatus="";this.A36PedidoRetirada=!1;this.Events={e15162_client:["ENTER",!0],e16162_client:["CANCEL",!0],e11161_client:["'DOUPDATE'",!1],e12161_client:["'DODELETE'",!1]};this.EvtParms.REFRESH=[[],[]];this.EvtParms.START=[[{av:"AV14Pgmname",fld:"vPGMNAME",pic:""},{av:"AV7PedidoId",fld:"vPEDIDOID",pic:"ZZZ9"}],[]];this.EvtParms.LOAD=[[],[]];this.EvtParms["'DOUPDATE'"]=[[{av:"A32PedidoId",fld:"PEDIDOID",pic:"ZZZ9"}],[]];this.EvtParms["'DODELETE'"]=[[{av:"A32PedidoId",fld:"PEDIDOID",pic:"ZZZ9"}],[]];this.Initialize()})