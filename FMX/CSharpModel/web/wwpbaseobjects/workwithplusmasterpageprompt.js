/*!   GeneXus C# 16_0_2-131213 on 7/11/2019 12:29:27.90
*/
gx.evt.autoSkip = false;
gx.define('wwpbaseobjects.workwithplusmasterpageprompt', false, function () {
   this.ServerClass =  "wwpbaseobjects.workwithplusmasterpageprompt" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.IsMasterPage=true;
   this.hasEnterEvent = false;
   this.skipOnEnter = false;
   this.autoRefresh = true;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
   };
   this.e130k2_client=function()
   {
      return this.executeServerEvent("ENTER_MPAGE", true, null, false, false);
   };
   this.e140k2_client=function()
   {
      return this.executeServerEvent("CANCEL_MPAGE", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,13,14,16,17];
   this.GXLastCtrlId =17;
   this.UCMESSAGE_MPAGEContainer = gx.uc.getNew(this, 12, 0, "DVelop_DVMessage", "UCMESSAGE_MPAGEContainer", "Ucmessage", "UCMESSAGE_MPAGE");
   var UCMESSAGE_MPAGEContainer = this.UCMESSAGE_MPAGEContainer;
   UCMESSAGE_MPAGEContainer.setProp("Class", "Class", "", "char");
   UCMESSAGE_MPAGEContainer.setProp("Enabled", "Enabled", true, "boolean");
   UCMESSAGE_MPAGEContainer.setProp("Width", "Width", "300", "str");
   UCMESSAGE_MPAGEContainer.setProp("MinHeight", "Minheight", "16", "str");
   UCMESSAGE_MPAGEContainer.setProp("StylingType", "Stylingtype", "fontawesome", "str");
   UCMESSAGE_MPAGEContainer.setProp("DefaultMessageType", "Defaultmessagetype", "notice", "str");
   UCMESSAGE_MPAGEContainer.setProp("TitleEscape", "Titleescape", false, "bool");
   UCMESSAGE_MPAGEContainer.setProp("TextEscape", "Textescape", false, "bool");
   UCMESSAGE_MPAGEContainer.setProp("ChangeNewLinesToBRs", "Changenewlinestobrs", true, "bool");
   UCMESSAGE_MPAGEContainer.setProp("Hide", "Hide", true, "bool");
   UCMESSAGE_MPAGEContainer.setProp("DelayUntilHide", "Delayuntilhide", 8000, "num");
   UCMESSAGE_MPAGEContainer.setProp("MouseHideReset", "Mousehidereset", true, "bool");
   UCMESSAGE_MPAGEContainer.setProp("MessageAdditionalClasses", "Messageadditionalclasses", "", "str");
   UCMESSAGE_MPAGEContainer.setProp("MessageCornerClass", "Messagecornerclass", "", "str");
   UCMESSAGE_MPAGEContainer.setProp("Shadow", "Shadow", true, "bool");
   UCMESSAGE_MPAGEContainer.setProp("Opacity", "Opacity", "1", "str");
   UCMESSAGE_MPAGEContainer.setProp("StackVerticalFirstPos", "Stackverticalfirstpos", 15, "num");
   UCMESSAGE_MPAGEContainer.setProp("StackHorizontalFirstPos", "Stackhorizontalfirstpos", 15, "num");
   UCMESSAGE_MPAGEContainer.setProp("StackVerticalSpacing", "Stackverticalspacing", 15, "num");
   UCMESSAGE_MPAGEContainer.setProp("StackHorizontalSpacing", "Stackhorizontalspacing", 15, "num");
   UCMESSAGE_MPAGEContainer.setProp("EffectIn", "Effectin", "fade", "str");
   UCMESSAGE_MPAGEContainer.setProp("EffectOut", "Effectout", "fade", "str");
   UCMESSAGE_MPAGEContainer.setProp("AnimationSpeed", "Animationspeed", 600, "num");
   UCMESSAGE_MPAGEContainer.setProp("StartPosition", "Startposition", "TopRight", "str");
   UCMESSAGE_MPAGEContainer.setProp("NextMessagePosition", "Nextmessageposition", "down", "str");
   UCMESSAGE_MPAGEContainer.setProp("Closer", "Closer", true, "bool");
   UCMESSAGE_MPAGEContainer.setProp("CloserHover", "Closerhover", true, "bool");
   UCMESSAGE_MPAGEContainer.setProp("Sticker", "Sticker", false, "bool");
   UCMESSAGE_MPAGEContainer.setProp("StickerHover", "Stickerhover", true, "bool");
   UCMESSAGE_MPAGEContainer.setProp("LabelCloseButton", "Labelclosebutton", "Close", "str");
   UCMESSAGE_MPAGEContainer.setProp("LabelStickButton", "Labelstickbutton", "Stick", "str");
   UCMESSAGE_MPAGEContainer.setProp("showEvenOnNonblock", "Showevenonnonblock", false, "bool");
   UCMESSAGE_MPAGEContainer.setProp("NonBlock", "Nonblock", false, "bool");
   UCMESSAGE_MPAGEContainer.setProp("NonBlockOpacity", "Nonblockopacity", ".2", "str");
   UCMESSAGE_MPAGEContainer.setProp("EnableHistory", "Enablehistory", true, "bool");
   UCMESSAGE_MPAGEContainer.setProp("Menu", "Menu", false, "bool");
   UCMESSAGE_MPAGEContainer.setProp("FixedMenu", "Fixedmenu", true, "bool");
   UCMESSAGE_MPAGEContainer.setProp("MaxOnScreen", "Maxonscreen", "Infinity", "str");
   UCMESSAGE_MPAGEContainer.setProp("LabelRedisplay", "Labelredisplay", "Redisplay", "str");
   UCMESSAGE_MPAGEContainer.setProp("LabelAll", "Labelall", "All", "str");
   UCMESSAGE_MPAGEContainer.setProp("LabelLast", "Labellast", "Last", "str");
   UCMESSAGE_MPAGEContainer.setProp("Visible", "Visible", true, "bool");
   UCMESSAGE_MPAGEContainer.setProp("Gx Control Type", "Gxcontroltype", '', "int");
   UCMESSAGE_MPAGEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   this.setUserControl(UCMESSAGE_MPAGEContainer);
   this.UCTOOLTIP_MPAGEContainer = gx.uc.getNew(this, 15, 0, "BootstrapTooltip", "UCTOOLTIP_MPAGEContainer", "Uctooltip", "UCTOOLTIP_MPAGE");
   var UCTOOLTIP_MPAGEContainer = this.UCTOOLTIP_MPAGEContainer;
   UCTOOLTIP_MPAGEContainer.setProp("Class", "Class", "", "char");
   UCTOOLTIP_MPAGEContainer.setProp("Enabled", "Enabled", true, "boolean");
   UCTOOLTIP_MPAGEContainer.setProp("ClassSelector", "Classselector", "BootstrapTooltip", "str");
   UCTOOLTIP_MPAGEContainer.setProp("DefaultPosition", "Defaultposition", "bottom", "str");
   UCTOOLTIP_MPAGEContainer.setProp("LabelsShowDelay", "Labelsshowdelay", 300, "num");
   UCTOOLTIP_MPAGEContainer.setProp("ButtonsShowDelay", "Buttonsshowdelay", 300, "num");
   UCTOOLTIP_MPAGEContainer.setProp("InputsShowDelay", "Inputsshowdelay", 300, "num");
   UCTOOLTIP_MPAGEContainer.setProp("ImagesShowDelay", "Imagesshowdelay", 0, "num");
   UCTOOLTIP_MPAGEContainer.setProp("HideDelay", "Hidedelay", 0, "num");
   UCTOOLTIP_MPAGEContainer.setProp("Visible", "Visible", true, "bool");
   UCTOOLTIP_MPAGEContainer.setProp("Gx Control Type", "Gxcontroltype", '', "int");
   UCTOOLTIP_MPAGEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   this.setUserControl(UCTOOLTIP_MPAGEContainer);
   this.WWPUTILITIES_MPAGEContainer = gx.uc.getNew(this, 18, 0, "DVelop_WorkWithPlusUtilities", "WWPUTILITIES_MPAGEContainer", "Wwputilities", "WWPUTILITIES_MPAGE");
   var WWPUTILITIES_MPAGEContainer = this.WWPUTILITIES_MPAGEContainer;
   WWPUTILITIES_MPAGEContainer.setProp("Class", "Class", "", "char");
   WWPUTILITIES_MPAGEContainer.setProp("Enabled", "Enabled", true, "boolean");
   WWPUTILITIES_MPAGEContainer.setProp("EnableAutoUpdateFromDocumentTitle", "Enableautoupdatefromdocumenttitle", false, "bool");
   WWPUTILITIES_MPAGEContainer.setProp("EnableFixObjectFitCover", "Enablefixobjectfitcover", true, "bool");
   WWPUTILITIES_MPAGEContainer.setProp("EnableFloatingLabels", "Enablefloatinglabels", false, "bool");
   WWPUTILITIES_MPAGEContainer.setProp("EnableConvertComboToBootstrapSelect", "Enableconvertcombotobootstrapselect", true, "bool");
   WWPUTILITIES_MPAGEContainer.setProp("CurrentTab_ReturnUrl", "Currenttab_returnurl", "", "char");
   WWPUTILITIES_MPAGEContainer.setProp("Visible", "Visible", true, "bool");
   WWPUTILITIES_MPAGEContainer.setProp("Gx Control Type", "Gxcontroltype", '', "int");
   WWPUTILITIES_MPAGEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   this.setUserControl(WWPUTILITIES_MPAGEContainer);
   GXValidFnc[2]={ id: 2, fld:"",grid:0};
   GXValidFnc[3]={ id: 3, fld:"LAYOUTMAINTABLE",grid:0};
   GXValidFnc[4]={ id: 4, fld:"",grid:0};
   GXValidFnc[5]={ id: 5, fld:"",grid:0};
   GXValidFnc[6]={ id: 6, fld:"TABLEMAIN",grid:0};
   GXValidFnc[7]={ id: 7, fld:"",grid:0};
   GXValidFnc[8]={ id: 8, fld:"",grid:0};
   GXValidFnc[10]={ id: 10, fld:"",grid:0};
   GXValidFnc[11]={ id: 11, fld:"",grid:0};
   GXValidFnc[13]={ id: 13, fld:"",grid:0};
   GXValidFnc[14]={ id: 14, fld:"",grid:0};
   GXValidFnc[16]={ id: 16, fld:"",grid:0};
   GXValidFnc[17]={ id: 17, fld:"",grid:0};
   this.Events = {"e130k2_client": ["ENTER_MPAGE", true] ,"e140k2_client": ["CANCEL_MPAGE", true]};
   this.EvtParms["REFRESH_MPAGE"] = [[],[]];
   this.EvtParms["START_MPAGE"] = [[],[{av:'gx.fn.getCtrlProperty("LAYOUTMAINTABLE_MPAGE","Class")',ctrl:'LAYOUTMAINTABLE_MPAGE',prop:'Class'}]];
   this.Initialize( );
});
gx.wi( function() { gx.createMasterPage(wwpbaseobjects.workwithplusmasterpageprompt);});
