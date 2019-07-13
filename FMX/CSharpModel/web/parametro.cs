/*
               File: Parametro
        Description: Parametro
             Author: GeneXus C# Generator version 16_0_2-131213
       Generated on: 7/12/2019 10:37:14.31
       Program type: Callable routine
          Main DBMS: SQL Server
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using System.Data;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class parametro : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
         entryPointCalled = false;
         gxfirstwebparm = GetNextPar( );
         gxfirstwebparm_bkp = gxfirstwebparm;
         gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm);
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            dyncall( GetNextPar( )) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel6"+"_"+"vERRO") == 0 )
         {
            A17ParametroPrioritaria = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17ParametroPrioritaria", A17ParametroPrioritaria);
            Gx_mode = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            A14ParametroDtVigenciaIni = context.localUtil.ParseDateParm( GetNextPar( ));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14ParametroDtVigenciaIni", context.localUtil.Format(A14ParametroDtVigenciaIni, "99/99/99"));
            A16ParametroTipo = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ParametroTipo", A16ParametroTipo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX6ASAERRO033( A17ParametroPrioritaria, Gx_mode, A14ParametroDtVigenciaIni, A16ParametroTipo) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
         {
            setAjaxEventMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = GetNextPar( );
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxfullajaxEvt") == 0 )
         {
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = GetNextPar( );
         }
         else
         {
            if ( ! IsValidAjaxCall( false) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = gxfirstwebparm_bkp;
         }
         if ( ! entryPointCalled && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
         {
            Gx_mode = gxfirstwebparm;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               AV7ParametroID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ParametroID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ParametroID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vPARAMETROID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7ParametroID), "ZZZ9"), context));
            }
         }
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
         }
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_web_controls( ) ;
         if ( toggleJsOutput )
         {
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_2-131213", 0) ;
            Form.Meta.addItem("description", "Parametro", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtParametroDtVigenciaIni_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public parametro( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public parametro( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_ParametroID )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7ParametroID = aP1_ParametroID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbParametroTipo = new GXCombobox();
         radParametroPrioritaria = new GXRadio();
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("wwpbaseobjects.workwithplusmasterpage", "GeneXus.Programs.wwpbaseobjects.workwithplusmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            ValidateSpaRequest();
            MasterPageObj.webExecute();
            if ( ( GxWebError == 0 ) && context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
               }
               if ( ! context.WillRedirect( ) )
               {
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               }
               else
               {
                  if ( context.isAjaxRequest( ) )
                  {
                     disableOutput();
                  }
                  RenderHtmlHeaders( ) ;
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      protected void fix_multi_value_controls( )
      {
         if ( cmbParametroTipo.ItemCount > 0 )
         {
            A16ParametroTipo = cmbParametroTipo.getValidValue(A16ParametroTipo);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ParametroTipo", A16ParametroTipo);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbParametroTipo.CurrentValue = StringUtil.RTrim( A16ParametroTipo);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbParametroTipo_Internalname, "Values", cmbParametroTipo.ToJavascriptSource(), true);
         }
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayoutmaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "TableMainTransaction", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablecontent_Internalname, 1, 0, "px", 0, "px", "TableContent", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-lg-6", "left", "top", "", "", "div");
            /* User Defined Control */
            ucDvpanel_tableattributes.SetProperty("Width", Dvpanel_tableattributes_Width);
            ucDvpanel_tableattributes.SetProperty("AutoWidth", Dvpanel_tableattributes_Autowidth);
            ucDvpanel_tableattributes.SetProperty("AutoHeight", Dvpanel_tableattributes_Autoheight);
            ucDvpanel_tableattributes.SetProperty("Cls", Dvpanel_tableattributes_Cls);
            ucDvpanel_tableattributes.SetProperty("Title", Dvpanel_tableattributes_Title);
            ucDvpanel_tableattributes.SetProperty("Collapsible", Dvpanel_tableattributes_Collapsible);
            ucDvpanel_tableattributes.SetProperty("Collapsed", Dvpanel_tableattributes_Collapsed);
            ucDvpanel_tableattributes.SetProperty("ShowCollapseIcon", Dvpanel_tableattributes_Showcollapseicon);
            ucDvpanel_tableattributes.SetProperty("IconPosition", Dvpanel_tableattributes_Iconposition);
            ucDvpanel_tableattributes.SetProperty("AutoScroll", Dvpanel_tableattributes_Autoscroll);
            ucDvpanel_tableattributes.Render(context, "dvelop.gxbootstrap.panel_al", Dvpanel_tableattributes_Internalname, "DVPANEL_TABLEATTRIBUTESContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_TABLEATTRIBUTESContainer"+"TableAttributes"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableattributes_Internalname, 1, 0, "px", 0, "px", "TableData", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtParametroID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtParametroID_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtParametroID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A13ParametroID), 4, 0, ",", "")), ((edtParametroID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A13ParametroID), "ZZZ9")) : context.localUtil.Format( (decimal)(A13ParametroID), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtParametroID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtParametroID_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Serial", "right", false, "HLP_Parametro.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtParametroDtVigenciaIni_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtParametroDtVigenciaIni_Internalname, "Vigência Inicial", "col-sm-3 AttributeDateLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtParametroDtVigenciaIni_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtParametroDtVigenciaIni_Internalname, context.localUtil.Format(A14ParametroDtVigenciaIni, "99/99/99"), context.localUtil.Format( A14ParametroDtVigenciaIni, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,27);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtParametroDtVigenciaIni_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtParametroDtVigenciaIni_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Parametro.htm");
            GxWebStd.gx_bitmap( context, edtParametroDtVigenciaIni_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtParametroDtVigenciaIni_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_Parametro.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtParametroDtVigenciaFim_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtParametroDtVigenciaFim_Internalname, "Vigência Final", "col-sm-3 AttributeDateLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 32,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtParametroDtVigenciaFim_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtParametroDtVigenciaFim_Internalname, context.localUtil.Format(A15ParametroDtVigenciaFim, "99/99/99"), context.localUtil.Format( A15ParametroDtVigenciaFim, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,32);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtParametroDtVigenciaFim_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtParametroDtVigenciaFim_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Parametro.htm");
            GxWebStd.gx_bitmap( context, edtParametroDtVigenciaFim_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtParametroDtVigenciaFim_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_Parametro.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbParametroTipo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbParametroTipo_Internalname, "Tipo", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbParametroTipo, cmbParametroTipo_Internalname, StringUtil.RTrim( A16ParametroTipo), 1, cmbParametroTipo_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbParametroTipo.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,37);\"", "", true, "HLP_Parametro.htm");
            cmbParametroTipo.CurrentValue = StringUtil.RTrim( A16ParametroTipo);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbParametroTipo_Internalname, "Values", (String)(cmbParametroTipo.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+radParametroPrioritaria_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, "", "Prioritaria", "col-sm-3 AttributeCheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Radio button */
            ClassString = "AttributeCheckBox";
            StyleString = "";
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"";
            GxWebStd.gx_radio_ctrl( context, radParametroPrioritaria, radParametroPrioritaria_Internalname, StringUtil.RTrim( A17ParametroPrioritaria), "", 1, radParametroPrioritaria.Enabled, 0, 0, StyleString, ClassString, "", "", 0, radParametroPrioritaria_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", TempTags+" onclick=\"gx.evt.onchange(this, event);\" ", "HLP_Parametro.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtParametroValor_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtParametroValor_Internalname, "Valor", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtParametroValor_Internalname, StringUtil.LTrim( StringUtil.NToC( A18ParametroValor, 14, 2, ",", "")), ((edtParametroValor_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A18ParametroValor, "ZZZ,ZZZ,ZZ9.99")) : context.localUtil.Format( A18ParametroValor, "ZZZ,ZZZ,ZZ9.99")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,47);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtParametroValor_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtParametroValor_Enabled, 0, "text", "", 14, "chr", 1, "row", 14, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Parametro.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtParametroPercentual_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtParametroPercentual_Internalname, "Percentual", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtParametroPercentual_Internalname, StringUtil.LTrim( StringUtil.NToC( A19ParametroPercentual, 6, 2, ",", "")), ((edtParametroPercentual_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A19ParametroPercentual, "ZZ9.99")) : context.localUtil.Format( A19ParametroPercentual, "ZZ9.99")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtParametroPercentual_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtParametroPercentual_Enabled, 0, "text", "", 6, "chr", 1, "row", 6, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Parametro.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group TrnActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_enter_Internalname, "", "Confirmar", bttBtntrn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtntrn_enter_Visible, bttBtntrn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Parametro.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_cancel_Internalname, "", "Fechar", bttBtntrn_cancel_Jsonclick, 1, "Fechar", "", StyleString, ClassString, bttBtntrn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Parametro.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_delete_Internalname, "", "Eliminar", bttBtntrn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtntrn_delete_Visible, bttBtntrn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Parametro.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void UserMainFullajax( )
      {
         INITENV( ) ;
         INITTRN( ) ;
         UserMain( ) ;
         Draw( ) ;
         SendCloseFormHiddens( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E11032 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A13ParametroID = (short)(context.localUtil.CToN( cgiGet( edtParametroID_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ParametroID", StringUtil.LTrim( StringUtil.Str( (decimal)(A13ParametroID), 4, 0)));
               if ( context.localUtil.VCDate( cgiGet( edtParametroDtVigenciaIni_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Data de Vigência Inicial"}), 1, "PARAMETRODTVIGENCIAINI");
                  AnyError = 1;
                  GX_FocusControl = edtParametroDtVigenciaIni_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A14ParametroDtVigenciaIni = DateTime.MinValue;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14ParametroDtVigenciaIni", context.localUtil.Format(A14ParametroDtVigenciaIni, "99/99/99"));
               }
               else
               {
                  A14ParametroDtVigenciaIni = context.localUtil.CToD( cgiGet( edtParametroDtVigenciaIni_Internalname), 2);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14ParametroDtVigenciaIni", context.localUtil.Format(A14ParametroDtVigenciaIni, "99/99/99"));
               }
               if ( context.localUtil.VCDate( cgiGet( edtParametroDtVigenciaFim_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Data de Vigência Final"}), 1, "PARAMETRODTVIGENCIAFIM");
                  AnyError = 1;
                  GX_FocusControl = edtParametroDtVigenciaFim_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A15ParametroDtVigenciaFim = DateTime.MinValue;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15ParametroDtVigenciaFim", context.localUtil.Format(A15ParametroDtVigenciaFim, "99/99/99"));
               }
               else
               {
                  A15ParametroDtVigenciaFim = context.localUtil.CToD( cgiGet( edtParametroDtVigenciaFim_Internalname), 2);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15ParametroDtVigenciaFim", context.localUtil.Format(A15ParametroDtVigenciaFim, "99/99/99"));
               }
               cmbParametroTipo.CurrentValue = cgiGet( cmbParametroTipo_Internalname);
               A16ParametroTipo = cgiGet( cmbParametroTipo_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ParametroTipo", A16ParametroTipo);
               A17ParametroPrioritaria = cgiGet( radParametroPrioritaria_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17ParametroPrioritaria", A17ParametroPrioritaria);
               if ( ( ( context.localUtil.CToN( cgiGet( edtParametroValor_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtParametroValor_Internalname), ",", ".") > 999999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PARAMETROVALOR");
                  AnyError = 1;
                  GX_FocusControl = edtParametroValor_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A18ParametroValor = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18ParametroValor", StringUtil.LTrim( StringUtil.Str( A18ParametroValor, 12, 2)));
               }
               else
               {
                  A18ParametroValor = context.localUtil.CToN( cgiGet( edtParametroValor_Internalname), ",", ".");
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18ParametroValor", StringUtil.LTrim( StringUtil.Str( A18ParametroValor, 12, 2)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtParametroPercentual_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtParametroPercentual_Internalname), ",", ".") > 999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PARAMETROPERCENTUAL");
                  AnyError = 1;
                  GX_FocusControl = edtParametroPercentual_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A19ParametroPercentual = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19ParametroPercentual", StringUtil.LTrim( StringUtil.Str( A19ParametroPercentual, 6, 2)));
               }
               else
               {
                  A19ParametroPercentual = context.localUtil.CToN( cgiGet( edtParametroPercentual_Internalname), ",", ".");
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19ParametroPercentual", StringUtil.LTrim( StringUtil.Str( A19ParametroPercentual, 6, 2)));
               }
               /* Read saved values. */
               Z13ParametroID = (short)(context.localUtil.CToN( cgiGet( "Z13ParametroID"), ",", "."));
               Z14ParametroDtVigenciaIni = context.localUtil.CToD( cgiGet( "Z14ParametroDtVigenciaIni"), 0);
               Z15ParametroDtVigenciaFim = context.localUtil.CToD( cgiGet( "Z15ParametroDtVigenciaFim"), 0);
               Z16ParametroTipo = cgiGet( "Z16ParametroTipo");
               Z17ParametroPrioritaria = cgiGet( "Z17ParametroPrioritaria");
               Z18ParametroValor = context.localUtil.CToN( cgiGet( "Z18ParametroValor"), ",", ".");
               Z19ParametroPercentual = context.localUtil.CToN( cgiGet( "Z19ParametroPercentual"), ",", ".");
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               AV7ParametroID = (short)(context.localUtil.CToN( cgiGet( "vPARAMETROID"), ",", "."));
               AV11erro = StringUtil.StrToBool( cgiGet( "vERRO"));
               Gx_mode = cgiGet( "vMODE");
               Dvpanel_tableattributes_Objectcall = cgiGet( "DVPANEL_TABLEATTRIBUTES_Objectcall");
               Dvpanel_tableattributes_Class = cgiGet( "DVPANEL_TABLEATTRIBUTES_Class");
               Dvpanel_tableattributes_Enabled = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Enabled"));
               Dvpanel_tableattributes_Width = cgiGet( "DVPANEL_TABLEATTRIBUTES_Width");
               Dvpanel_tableattributes_Height = cgiGet( "DVPANEL_TABLEATTRIBUTES_Height");
               Dvpanel_tableattributes_Cls = cgiGet( "DVPANEL_TABLEATTRIBUTES_Cls");
               Dvpanel_tableattributes_Title = cgiGet( "DVPANEL_TABLEATTRIBUTES_Title");
               Dvpanel_tableattributes_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Collapsible"));
               Dvpanel_tableattributes_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Collapsed"));
               Dvpanel_tableattributes_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autowidth"));
               Dvpanel_tableattributes_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autoheight"));
               Dvpanel_tableattributes_Showheader = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Showheader"));
               Dvpanel_tableattributes_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Showcollapseicon"));
               Dvpanel_tableattributes_Iconposition = cgiGet( "DVPANEL_TABLEATTRIBUTES_Iconposition");
               Dvpanel_tableattributes_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autoscroll"));
               Dvpanel_tableattributes_Visible = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Visible"));
               Dvpanel_tableattributes_Gxcontroltype = (int)(context.localUtil.CToN( cgiGet( "DVPANEL_TABLEATTRIBUTES_Gxcontroltype"), ",", "."));
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Parametro";
               A13ParametroID = (short)(context.localUtil.CToN( cgiGet( edtParametroID_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ParametroID", StringUtil.LTrim( StringUtil.Str( (decimal)(A13ParametroID), 4, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A13ParametroID), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A13ParametroID != Z13ParametroID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("parametro:[SecurityCheckFailed value for]"+"ParametroID:"+context.localUtil.Format( (decimal)(A13ParametroID), "ZZZ9"));
                  GXUtil.WriteLog("parametro:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GxWebError = 1;
                  context.HttpContext.Response.StatusDescription = 403.ToString();
                  context.HttpContext.Response.StatusCode = 403;
                  context.WriteHtmlText( "<title>403 Forbidden</title>") ;
                  context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
                  context.WriteHtmlText( "<p /><hr />") ;
                  GXUtil.WriteLog("send_http_error_code " + 403.ToString());
                  AnyError = 1;
                  return  ;
               }
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  A13ParametroID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ParametroID", StringUtil.LTrim( StringUtil.Str( (decimal)(A13ParametroID), 4, 0)));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  disable_std_buttons( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
                  {
                     sMode3 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode3;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound3 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_030( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtntrn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "PARAMETROID");
                        AnyError = 1;
                        GX_FocusControl = edtParametroID_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
            sEvt = cgiGet( "_EventName");
            EvtGridId = cgiGet( "_EventGridId");
            EvtRowId = cgiGet( "_EventRowId");
            if ( StringUtil.Len( sEvt) > 0 )
            {
               sEvtType = StringUtil.Left( sEvt, 1);
               sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1));
               if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
               {
                  if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                  {
                     sEvtType = StringUtil.Right( sEvt, 1);
                     if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                     {
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                        if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Start */
                           E11032 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12032 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1;
                           if ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 )
                           {
                              btn_enter( ) ;
                           }
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                     }
                     else
                     {
                     }
                  }
                  context.wbHandled = 1;
               }
            }
         }
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E12032 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll033( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      protected void disable_std_buttons( )
      {
         bttBtntrn_delete_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Visible), 5, 0)), true);
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            bttBtntrn_delete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Visible), 5, 0)), true);
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               bttBtntrn_enter_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_enter_Visible), 5, 0)), true);
            }
            DisableAttributes033( ) ;
         }
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete", ""), 0, "", true);
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm", ""), 0, "", true);
            }
         }
      }

      protected void CONFIRM_030( )
      {
         BeforeValidate033( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls033( ) ;
            }
            else
            {
               CheckExtendedTable033( ) ;
               CloseExtendedTableCursors033( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption030( )
      {
      }

      protected void E11032( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "WWPTransactionContext", "FMX");
      }

      protected void E12032( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("parametroww.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM033( short GX_JID )
      {
         if ( ( GX_JID == 12 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z14ParametroDtVigenciaIni = T00033_A14ParametroDtVigenciaIni[0];
               Z15ParametroDtVigenciaFim = T00033_A15ParametroDtVigenciaFim[0];
               Z16ParametroTipo = T00033_A16ParametroTipo[0];
               Z17ParametroPrioritaria = T00033_A17ParametroPrioritaria[0];
               Z18ParametroValor = T00033_A18ParametroValor[0];
               Z19ParametroPercentual = T00033_A19ParametroPercentual[0];
            }
            else
            {
               Z14ParametroDtVigenciaIni = A14ParametroDtVigenciaIni;
               Z15ParametroDtVigenciaFim = A15ParametroDtVigenciaFim;
               Z16ParametroTipo = A16ParametroTipo;
               Z17ParametroPrioritaria = A17ParametroPrioritaria;
               Z18ParametroValor = A18ParametroValor;
               Z19ParametroPercentual = A19ParametroPercentual;
            }
         }
         if ( GX_JID == -12 )
         {
            Z13ParametroID = A13ParametroID;
            Z14ParametroDtVigenciaIni = A14ParametroDtVigenciaIni;
            Z15ParametroDtVigenciaFim = A15ParametroDtVigenciaFim;
            Z16ParametroTipo = A16ParametroTipo;
            Z17ParametroPrioritaria = A17ParametroPrioritaria;
            Z18ParametroValor = A18ParametroValor;
            Z19ParametroPercentual = A19ParametroPercentual;
         }
      }

      protected void standaloneNotModal( )
      {
         edtParametroID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtParametroID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtParametroID_Enabled), 5, 0)), true);
         edtParametroID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtParametroID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtParametroID_Enabled), 5, 0)), true);
         bttBtntrn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7ParametroID) )
         {
            A13ParametroID = AV7ParametroID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ParametroID", StringUtil.LTrim( StringUtil.Str( (decimal)(A13ParametroID), 4, 0)));
         }
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtntrn_enter_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_enter_Enabled), 5, 0)), true);
         }
         else
         {
            bttBtntrn_enter_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_enter_Enabled), 5, 0)), true);
         }
      }

      protected void Load033( )
      {
         /* Using cursor T00034 */
         pr_default.execute(2, new Object[] {A13ParametroID});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound3 = 1;
            A14ParametroDtVigenciaIni = T00034_A14ParametroDtVigenciaIni[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14ParametroDtVigenciaIni", context.localUtil.Format(A14ParametroDtVigenciaIni, "99/99/99"));
            A15ParametroDtVigenciaFim = T00034_A15ParametroDtVigenciaFim[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15ParametroDtVigenciaFim", context.localUtil.Format(A15ParametroDtVigenciaFim, "99/99/99"));
            A16ParametroTipo = T00034_A16ParametroTipo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ParametroTipo", A16ParametroTipo);
            A17ParametroPrioritaria = T00034_A17ParametroPrioritaria[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17ParametroPrioritaria", A17ParametroPrioritaria);
            A18ParametroValor = T00034_A18ParametroValor[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18ParametroValor", StringUtil.LTrim( StringUtil.Str( A18ParametroValor, 12, 2)));
            A19ParametroPercentual = T00034_A19ParametroPercentual[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19ParametroPercentual", StringUtil.LTrim( StringUtil.Str( A19ParametroPercentual, 6, 2)));
            ZM033( -12) ;
         }
         pr_default.close(2);
         OnLoadActions033( ) ;
      }

      protected void OnLoadActions033( )
      {
      }

      protected void CheckExtendedTable033( )
      {
         nIsDirty_3 = 0;
         Gx_BScreen = 1;
         standaloneModal( ) ;
         if ( ! ( (DateTime.MinValue==A14ParametroDtVigenciaIni) || ( A14ParametroDtVigenciaIni >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Data de Vigência Inicial fora do intervalo", "OutOfRange", 1, "PARAMETRODTVIGENCIAINI");
            AnyError = 1;
            GX_FocusControl = edtParametroDtVigenciaIni_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( (DateTime.MinValue==A14ParametroDtVigenciaIni) )
         {
            GX_msglist.addItem("Data de Vigência Inicial é obrigatório.", 1, "PARAMETRODTVIGENCIAINI");
            AnyError = 1;
            GX_FocusControl = edtParametroDtVigenciaIni_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( (DateTime.MinValue==A15ParametroDtVigenciaFim) || ( A15ParametroDtVigenciaFim >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Data de Vigência Final fora do intervalo", "OutOfRange", 1, "PARAMETRODTVIGENCIAFIM");
            AnyError = 1;
            GX_FocusControl = edtParametroDtVigenciaFim_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( (DateTime.MinValue==A15ParametroDtVigenciaFim) )
         {
            GX_msglist.addItem("Data de Vigência Final é obrigatório.", 1, "PARAMETRODTVIGENCIAFIM");
            AnyError = 1;
            GX_FocusControl = edtParametroDtVigenciaFim_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( ( StringUtil.StrCmp(A16ParametroTipo, "D") == 0 ) || ( StringUtil.StrCmp(A16ParametroTipo, "F") == 0 ) ) )
         {
            GX_msglist.addItem("Campo Tipo fora do intervalo", "OutOfRange", 1, "PARAMETROTIPO");
            AnyError = 1;
            GX_FocusControl = cmbParametroTipo_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( (Convert.ToDecimal(0)==A18ParametroValor) )
         {
            GX_msglist.addItem("Valor é obrigatório.", 1, "PARAMETROVALOR");
            AnyError = 1;
            GX_FocusControl = edtParametroValor_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( (Convert.ToDecimal(0)==A19ParametroPercentual) )
         {
            GX_msglist.addItem("Percentual é obrigatório.", 1, "PARAMETROPERCENTUAL");
            AnyError = 1;
            GX_FocusControl = edtParametroPercentual_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors033( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey033( )
      {
         /* Using cursor T00035 */
         pr_default.execute(3, new Object[] {A13ParametroID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound3 = 1;
         }
         else
         {
            RcdFound3 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00033 */
         pr_default.execute(1, new Object[] {A13ParametroID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM033( 12) ;
            RcdFound3 = 1;
            A13ParametroID = T00033_A13ParametroID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ParametroID", StringUtil.LTrim( StringUtil.Str( (decimal)(A13ParametroID), 4, 0)));
            A14ParametroDtVigenciaIni = T00033_A14ParametroDtVigenciaIni[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14ParametroDtVigenciaIni", context.localUtil.Format(A14ParametroDtVigenciaIni, "99/99/99"));
            A15ParametroDtVigenciaFim = T00033_A15ParametroDtVigenciaFim[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15ParametroDtVigenciaFim", context.localUtil.Format(A15ParametroDtVigenciaFim, "99/99/99"));
            A16ParametroTipo = T00033_A16ParametroTipo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ParametroTipo", A16ParametroTipo);
            A17ParametroPrioritaria = T00033_A17ParametroPrioritaria[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17ParametroPrioritaria", A17ParametroPrioritaria);
            A18ParametroValor = T00033_A18ParametroValor[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18ParametroValor", StringUtil.LTrim( StringUtil.Str( A18ParametroValor, 12, 2)));
            A19ParametroPercentual = T00033_A19ParametroPercentual[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19ParametroPercentual", StringUtil.LTrim( StringUtil.Str( A19ParametroPercentual, 6, 2)));
            Z13ParametroID = A13ParametroID;
            sMode3 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load033( ) ;
            if ( AnyError == 1 )
            {
               RcdFound3 = 0;
               InitializeNonKey033( ) ;
            }
            Gx_mode = sMode3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound3 = 0;
            InitializeNonKey033( ) ;
            sMode3 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey033( ) ;
         if ( RcdFound3 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound3 = 0;
         /* Using cursor T00036 */
         pr_default.execute(4, new Object[] {A13ParametroID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T00036_A13ParametroID[0] < A13ParametroID ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T00036_A13ParametroID[0] > A13ParametroID ) ) )
            {
               A13ParametroID = T00036_A13ParametroID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ParametroID", StringUtil.LTrim( StringUtil.Str( (decimal)(A13ParametroID), 4, 0)));
               RcdFound3 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound3 = 0;
         /* Using cursor T00037 */
         pr_default.execute(5, new Object[] {A13ParametroID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T00037_A13ParametroID[0] > A13ParametroID ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T00037_A13ParametroID[0] < A13ParametroID ) ) )
            {
               A13ParametroID = T00037_A13ParametroID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ParametroID", StringUtil.LTrim( StringUtil.Str( (decimal)(A13ParametroID), 4, 0)));
               RcdFound3 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey033( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtParametroDtVigenciaIni_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert033( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound3 == 1 )
            {
               if ( A13ParametroID != Z13ParametroID )
               {
                  A13ParametroID = Z13ParametroID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ParametroID", StringUtil.LTrim( StringUtil.Str( (decimal)(A13ParametroID), 4, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "PARAMETROID");
                  AnyError = 1;
                  GX_FocusControl = edtParametroID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtParametroDtVigenciaIni_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update033( ) ;
                  GX_FocusControl = edtParametroDtVigenciaIni_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A13ParametroID != Z13ParametroID )
               {
                  /* Insert record */
                  GX_FocusControl = edtParametroDtVigenciaIni_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert033( ) ;
                  if ( AnyError == 1 )
                  {
                     GX_FocusControl = "";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "PARAMETROID");
                     AnyError = 1;
                     GX_FocusControl = edtParametroID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtParametroDtVigenciaIni_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert033( ) ;
                     if ( AnyError == 1 )
                     {
                        GX_FocusControl = "";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            if ( AnyError == 0 )
            {
               context.nUserReturn = 1;
            }
         }
      }

      protected void btn_delete( )
      {
         if ( A13ParametroID != Z13ParametroID )
         {
            A13ParametroID = Z13ParametroID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ParametroID", StringUtil.LTrim( StringUtil.Str( (decimal)(A13ParametroID), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "PARAMETROID");
            AnyError = 1;
            GX_FocusControl = edtParametroID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtParametroDtVigenciaIni_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency033( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00032 */
            pr_default.execute(0, new Object[] {A13ParametroID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Parametro"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( Z14ParametroDtVigenciaIni != T00032_A14ParametroDtVigenciaIni[0] ) || ( Z15ParametroDtVigenciaFim != T00032_A15ParametroDtVigenciaFim[0] ) || ( StringUtil.StrCmp(Z16ParametroTipo, T00032_A16ParametroTipo[0]) != 0 ) || ( StringUtil.StrCmp(Z17ParametroPrioritaria, T00032_A17ParametroPrioritaria[0]) != 0 ) || ( Z18ParametroValor != T00032_A18ParametroValor[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z19ParametroPercentual != T00032_A19ParametroPercentual[0] ) )
            {
               if ( Z14ParametroDtVigenciaIni != T00032_A14ParametroDtVigenciaIni[0] )
               {
                  GXUtil.WriteLog("parametro:[seudo value changed for attri]"+"ParametroDtVigenciaIni");
                  GXUtil.WriteLogRaw("Old: ",Z14ParametroDtVigenciaIni);
                  GXUtil.WriteLogRaw("Current: ",T00032_A14ParametroDtVigenciaIni[0]);
               }
               if ( Z15ParametroDtVigenciaFim != T00032_A15ParametroDtVigenciaFim[0] )
               {
                  GXUtil.WriteLog("parametro:[seudo value changed for attri]"+"ParametroDtVigenciaFim");
                  GXUtil.WriteLogRaw("Old: ",Z15ParametroDtVigenciaFim);
                  GXUtil.WriteLogRaw("Current: ",T00032_A15ParametroDtVigenciaFim[0]);
               }
               if ( StringUtil.StrCmp(Z16ParametroTipo, T00032_A16ParametroTipo[0]) != 0 )
               {
                  GXUtil.WriteLog("parametro:[seudo value changed for attri]"+"ParametroTipo");
                  GXUtil.WriteLogRaw("Old: ",Z16ParametroTipo);
                  GXUtil.WriteLogRaw("Current: ",T00032_A16ParametroTipo[0]);
               }
               if ( StringUtil.StrCmp(Z17ParametroPrioritaria, T00032_A17ParametroPrioritaria[0]) != 0 )
               {
                  GXUtil.WriteLog("parametro:[seudo value changed for attri]"+"ParametroPrioritaria");
                  GXUtil.WriteLogRaw("Old: ",Z17ParametroPrioritaria);
                  GXUtil.WriteLogRaw("Current: ",T00032_A17ParametroPrioritaria[0]);
               }
               if ( Z18ParametroValor != T00032_A18ParametroValor[0] )
               {
                  GXUtil.WriteLog("parametro:[seudo value changed for attri]"+"ParametroValor");
                  GXUtil.WriteLogRaw("Old: ",Z18ParametroValor);
                  GXUtil.WriteLogRaw("Current: ",T00032_A18ParametroValor[0]);
               }
               if ( Z19ParametroPercentual != T00032_A19ParametroPercentual[0] )
               {
                  GXUtil.WriteLog("parametro:[seudo value changed for attri]"+"ParametroPercentual");
                  GXUtil.WriteLogRaw("Old: ",Z19ParametroPercentual);
                  GXUtil.WriteLogRaw("Current: ",T00032_A19ParametroPercentual[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Parametro"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert033( )
      {
         BeforeValidate033( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable033( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM033( 0) ;
            CheckOptimisticConcurrency033( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm033( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert033( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00038 */
                     pr_default.execute(6, new Object[] {A14ParametroDtVigenciaIni, A15ParametroDtVigenciaFim, A16ParametroTipo, A17ParametroPrioritaria, A18ParametroValor, A19ParametroPercentual});
                     A13ParametroID = T00038_A13ParametroID[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ParametroID", StringUtil.LTrim( StringUtil.Str( (decimal)(A13ParametroID), 4, 0)));
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("Parametro") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption030( ) ;
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load033( ) ;
            }
            EndLevel033( ) ;
         }
         CloseExtendedTableCursors033( ) ;
      }

      protected void Update033( )
      {
         BeforeValidate033( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable033( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency033( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm033( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate033( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00039 */
                     pr_default.execute(7, new Object[] {A14ParametroDtVigenciaIni, A15ParametroDtVigenciaFim, A16ParametroTipo, A17ParametroPrioritaria, A18ParametroValor, A19ParametroPercentual, A13ParametroID});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("Parametro") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Parametro"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate033( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                           {
                              if ( AnyError == 0 )
                              {
                                 context.nUserReturn = 1;
                              }
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel033( ) ;
         }
         CloseExtendedTableCursors033( ) ;
      }

      protected void DeferredUpdate033( )
      {
      }

      protected void delete( )
      {
         BeforeValidate033( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency033( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls033( ) ;
            AfterConfirm033( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete033( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000310 */
                  pr_default.execute(8, new Object[] {A13ParametroID});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("Parametro") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                        {
                           if ( AnyError == 0 )
                           {
                              context.nUserReturn = 1;
                           }
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode3 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel033( ) ;
         Gx_mode = sMode3;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls033( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel033( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete033( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            context.CommitDataStores("parametro",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues030( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("parametro",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart033( )
      {
         /* Scan By routine */
         /* Using cursor T000311 */
         pr_default.execute(9);
         RcdFound3 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound3 = 1;
            A13ParametroID = T000311_A13ParametroID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ParametroID", StringUtil.LTrim( StringUtil.Str( (decimal)(A13ParametroID), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext033( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound3 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound3 = 1;
            A13ParametroID = T000311_A13ParametroID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ParametroID", StringUtil.LTrim( StringUtil.Str( (decimal)(A13ParametroID), 4, 0)));
         }
      }

      protected void ScanEnd033( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm033( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert033( )
      {
         /* Before Insert Rules */
         if ( ( StringUtil.StrCmp(A17ParametroPrioritaria, "S") == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            GXt_boolean1 = AV11erro;
            new prc_validaperiodo(context ).execute(  A14ParametroDtVigenciaIni,  A16ParametroTipo, out  GXt_boolean1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14ParametroDtVigenciaIni", context.localUtil.Format(A14ParametroDtVigenciaIni, "99/99/99"));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ParametroTipo", A16ParametroTipo);
            AV11erro = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11erro", AV11erro);
         }
         if ( AV11erro )
         {
            GX_msglist.addItem("Já possui um desconto vigente cadastrado para esse período.", 1, "");
            AnyError = 1;
         }
      }

      protected void BeforeUpdate033( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete033( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete033( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate033( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes033( )
      {
         edtParametroID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtParametroID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtParametroID_Enabled), 5, 0)), true);
         edtParametroDtVigenciaIni_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtParametroDtVigenciaIni_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtParametroDtVigenciaIni_Enabled), 5, 0)), true);
         edtParametroDtVigenciaFim_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtParametroDtVigenciaFim_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtParametroDtVigenciaFim_Enabled), 5, 0)), true);
         cmbParametroTipo.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbParametroTipo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbParametroTipo.Enabled), 5, 0)), true);
         radParametroPrioritaria.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, radParametroPrioritaria_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(radParametroPrioritaria.Enabled), 5, 0)), true);
         edtParametroValor_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtParametroValor_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtParametroValor_Enabled), 5, 0)), true);
         edtParametroPercentual_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtParametroPercentual_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtParametroPercentual_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes033( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues030( )
      {
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      public override void RenderHtmlOpenForm( )
      {
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( "<title>") ;
         context.SendWebValue( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         MasterPageObj.master_styles();
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 131213), false, true);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 131213), false, true);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 131213), false, true);
         context.AddJavascriptSource("gxcfg.js", "?201971210371531", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 131213), false, true);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 131213), false, true);
         context.AddJavascriptSource("calendar-pt.js", "?"+context.GetBuildNumber( 131213), false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false, true);
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("parametro.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7ParametroID)+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Class", "form-horizontal Form", true);
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         forbiddenHiddens = "hsh" + "Parametro";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A13ParametroID), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("parametro:[SendSecurityCheck value for]"+"ParametroID:"+context.localUtil.Format( (decimal)(A13ParametroID), "ZZZ9"));
         GXUtil.WriteLog("parametro:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z13ParametroID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z13ParametroID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z14ParametroDtVigenciaIni", context.localUtil.DToC( Z14ParametroDtVigenciaIni, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z15ParametroDtVigenciaFim", context.localUtil.DToC( Z15ParametroDtVigenciaFim, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z16ParametroTipo", StringUtil.RTrim( Z16ParametroTipo));
         GxWebStd.gx_hidden_field( context, "Z17ParametroPrioritaria", StringUtil.RTrim( Z17ParametroPrioritaria));
         GxWebStd.gx_hidden_field( context, "Z18ParametroValor", StringUtil.LTrim( StringUtil.NToC( Z18ParametroValor, 12, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z19ParametroPercentual", StringUtil.LTrim( StringUtil.NToC( Z19ParametroPercentual, 6, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV9TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vPARAMETROID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7ParametroID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vPARAMETROID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7ParametroID), "ZZZ9"), context));
         GxWebStd.gx_boolean_hidden_field( context, "vERRO", AV11erro);
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Objectcall", StringUtil.RTrim( Dvpanel_tableattributes_Objectcall));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Enabled", StringUtil.BoolToStr( Dvpanel_tableattributes_Enabled));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Width", StringUtil.RTrim( Dvpanel_tableattributes_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Cls", StringUtil.RTrim( Dvpanel_tableattributes_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Title", StringUtil.RTrim( Dvpanel_tableattributes_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Collapsible", StringUtil.BoolToStr( Dvpanel_tableattributes_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Collapsed", StringUtil.BoolToStr( Dvpanel_tableattributes_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Autowidth", StringUtil.BoolToStr( Dvpanel_tableattributes_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Autoheight", StringUtil.BoolToStr( Dvpanel_tableattributes_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_tableattributes_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Iconposition", StringUtil.RTrim( Dvpanel_tableattributes_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Autoscroll", StringUtil.BoolToStr( Dvpanel_tableattributes_Autoscroll));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken(sPrefix);
         SendComponentObjects();
         SendServerCommands();
         SendState();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         context.WriteHtmlTextNl( "</form>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         include_jscripts( ) ;
      }

      public override short ExecuteStartEvent( )
      {
         standaloneStartup( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         return gxajaxcallmode ;
      }

      public override void RenderHtmlContent( )
      {
         context.WriteHtmlText( "<div") ;
         GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
         context.WriteHtmlText( ">") ;
         Draw( ) ;
         context.WriteHtmlText( "</div>") ;
      }

      public override void DispatchEvents( )
      {
         Process( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("parametro.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7ParametroID) ;
      }

      public override String GetPgmname( )
      {
         return "Parametro" ;
      }

      public override String GetPgmdesc( )
      {
         return "Parametro" ;
      }

      protected void InitializeNonKey033( )
      {
         AV11erro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11erro", AV11erro);
         A14ParametroDtVigenciaIni = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14ParametroDtVigenciaIni", context.localUtil.Format(A14ParametroDtVigenciaIni, "99/99/99"));
         A15ParametroDtVigenciaFim = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15ParametroDtVigenciaFim", context.localUtil.Format(A15ParametroDtVigenciaFim, "99/99/99"));
         A16ParametroTipo = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ParametroTipo", A16ParametroTipo);
         A17ParametroPrioritaria = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17ParametroPrioritaria", A17ParametroPrioritaria);
         A18ParametroValor = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18ParametroValor", StringUtil.LTrim( StringUtil.Str( A18ParametroValor, 12, 2)));
         A19ParametroPercentual = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19ParametroPercentual", StringUtil.LTrim( StringUtil.Str( A19ParametroPercentual, 6, 2)));
         Z14ParametroDtVigenciaIni = DateTime.MinValue;
         Z15ParametroDtVigenciaFim = DateTime.MinValue;
         Z16ParametroTipo = "";
         Z17ParametroPrioritaria = "";
         Z18ParametroValor = 0;
         Z19ParametroPercentual = 0;
      }

      protected void InitAll033( )
      {
         A13ParametroID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ParametroID", StringUtil.LTrim( StringUtil.Str( (decimal)(A13ParametroID), 4, 0)));
         InitializeNonKey033( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201971210371547", true, true);
            idxLst = (int)(idxLst+1);
         }
         if ( ! outputEnabled )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.por.js", "?"+GetCacheInvalidationToken( ), false, true);
         context.AddJavascriptSource("parametro.js", "?201971210371548", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false, true);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         edtParametroID_Internalname = "PARAMETROID";
         edtParametroDtVigenciaIni_Internalname = "PARAMETRODTVIGENCIAINI";
         edtParametroDtVigenciaFim_Internalname = "PARAMETRODTVIGENCIAFIM";
         cmbParametroTipo_Internalname = "PARAMETROTIPO";
         radParametroPrioritaria_Internalname = "PARAMETROPRIORITARIA";
         edtParametroValor_Internalname = "PARAMETROVALOR";
         edtParametroPercentual_Internalname = "PARAMETROPERCENTUAL";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtntrn_enter_Internalname = "BTNTRN_ENTER";
         bttBtntrn_cancel_Internalname = "BTNTRN_CANCEL";
         bttBtntrn_delete_Internalname = "BTNTRN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         divLayoutmaintable_Internalname = "LAYOUTMAINTABLE";
         Form.Internalname = "FORM";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Parametro";
         bttBtntrn_delete_Enabled = 0;
         bttBtntrn_delete_Visible = 1;
         bttBtntrn_cancel_Visible = 1;
         bttBtntrn_enter_Enabled = 1;
         bttBtntrn_enter_Visible = 1;
         edtParametroPercentual_Jsonclick = "";
         edtParametroPercentual_Enabled = 1;
         edtParametroValor_Jsonclick = "";
         edtParametroValor_Enabled = 1;
         radParametroPrioritaria_Jsonclick = "";
         radParametroPrioritaria.Enabled = 1;
         cmbParametroTipo_Jsonclick = "";
         cmbParametroTipo.Enabled = 1;
         edtParametroDtVigenciaFim_Jsonclick = "";
         edtParametroDtVigenciaFim_Enabled = 1;
         edtParametroDtVigenciaIni_Jsonclick = "";
         edtParametroDtVigenciaIni_Enabled = 1;
         edtParametroID_Jsonclick = "";
         edtParametroID_Enabled = 0;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "Right";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "Informações Gerais";
         Dvpanel_tableattributes_Cls = "PanelCard_BaseColor";
         Dvpanel_tableattributes_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableattributes_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Width = "100%";
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GX6ASAERRO033( String A17ParametroPrioritaria ,
                                    String Gx_mode ,
                                    DateTime A14ParametroDtVigenciaIni ,
                                    String A16ParametroTipo )
      {
         if ( ( StringUtil.StrCmp(A17ParametroPrioritaria, "S") == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            GXt_boolean1 = AV11erro;
            new prc_validaperiodo(context ).execute(  A14ParametroDtVigenciaIni,  A16ParametroTipo, out  GXt_boolean1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14ParametroDtVigenciaIni", context.localUtil.Format(A14ParametroDtVigenciaIni, "99/99/99"));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ParametroTipo", A16ParametroTipo);
            AV11erro = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11erro", AV11erro);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.BoolToStr( AV11erro))+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void init_web_controls( )
      {
         cmbParametroTipo.Name = "PARAMETROTIPO";
         cmbParametroTipo.WebTags = "";
         cmbParametroTipo.addItem("D", "Desconto", 0);
         cmbParametroTipo.addItem("F", "Frete", 0);
         if ( cmbParametroTipo.ItemCount > 0 )
         {
            A16ParametroTipo = cmbParametroTipo.getValidValue(A16ParametroTipo);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16ParametroTipo", A16ParametroTipo);
         }
         radParametroPrioritaria.Name = "PARAMETROPRIORITARIA";
         radParametroPrioritaria.WebTags = "";
         radParametroPrioritaria.addItem("S", "Sim", 0);
         radParametroPrioritaria.addItem("N", "Não", 0);
         /* End function init_web_controls */
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7ParametroID',fld:'vPARAMETROID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7ParametroID',fld:'vPARAMETROID',pic:'ZZZ9',hsh:true},{av:'A13ParametroID',fld:'PARAMETROID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12032',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:''}]");
         setEventMetadata("AFTER TRN",",oparms:[]}");
         return  ;
      }

      public override void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
         pr_default.close(1);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z14ParametroDtVigenciaIni = DateTime.MinValue;
         Z15ParametroDtVigenciaFim = DateTime.MinValue;
         Z16ParametroTipo = "";
         Z17ParametroPrioritaria = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         A17ParametroPrioritaria = "";
         A14ParametroDtVigenciaIni = DateTime.MinValue;
         A16ParametroTipo = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         TempTags = "";
         A15ParametroDtVigenciaFim = DateTime.MinValue;
         bttBtntrn_enter_Jsonclick = "";
         bttBtntrn_cancel_Jsonclick = "";
         bttBtntrn_delete_Jsonclick = "";
         Dvpanel_tableattributes_Objectcall = "";
         Dvpanel_tableattributes_Class = "";
         Dvpanel_tableattributes_Height = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode3 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV8WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV10WebSession = context.GetSession();
         T00034_A13ParametroID = new short[1] ;
         T00034_A14ParametroDtVigenciaIni = new DateTime[] {DateTime.MinValue} ;
         T00034_A15ParametroDtVigenciaFim = new DateTime[] {DateTime.MinValue} ;
         T00034_A16ParametroTipo = new String[] {""} ;
         T00034_A17ParametroPrioritaria = new String[] {""} ;
         T00034_A18ParametroValor = new decimal[1] ;
         T00034_A19ParametroPercentual = new decimal[1] ;
         T00035_A13ParametroID = new short[1] ;
         T00033_A13ParametroID = new short[1] ;
         T00033_A14ParametroDtVigenciaIni = new DateTime[] {DateTime.MinValue} ;
         T00033_A15ParametroDtVigenciaFim = new DateTime[] {DateTime.MinValue} ;
         T00033_A16ParametroTipo = new String[] {""} ;
         T00033_A17ParametroPrioritaria = new String[] {""} ;
         T00033_A18ParametroValor = new decimal[1] ;
         T00033_A19ParametroPercentual = new decimal[1] ;
         T00036_A13ParametroID = new short[1] ;
         T00037_A13ParametroID = new short[1] ;
         T00032_A13ParametroID = new short[1] ;
         T00032_A14ParametroDtVigenciaIni = new DateTime[] {DateTime.MinValue} ;
         T00032_A15ParametroDtVigenciaFim = new DateTime[] {DateTime.MinValue} ;
         T00032_A16ParametroTipo = new String[] {""} ;
         T00032_A17ParametroPrioritaria = new String[] {""} ;
         T00032_A18ParametroValor = new decimal[1] ;
         T00032_A19ParametroPercentual = new decimal[1] ;
         T00038_A13ParametroID = new short[1] ;
         T000311_A13ParametroID = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.parametro__default(),
            new Object[][] {
                new Object[] {
               T00032_A13ParametroID, T00032_A14ParametroDtVigenciaIni, T00032_A15ParametroDtVigenciaFim, T00032_A16ParametroTipo, T00032_A17ParametroPrioritaria, T00032_A18ParametroValor, T00032_A19ParametroPercentual
               }
               , new Object[] {
               T00033_A13ParametroID, T00033_A14ParametroDtVigenciaIni, T00033_A15ParametroDtVigenciaFim, T00033_A16ParametroTipo, T00033_A17ParametroPrioritaria, T00033_A18ParametroValor, T00033_A19ParametroPercentual
               }
               , new Object[] {
               T00034_A13ParametroID, T00034_A14ParametroDtVigenciaIni, T00034_A15ParametroDtVigenciaFim, T00034_A16ParametroTipo, T00034_A17ParametroPrioritaria, T00034_A18ParametroValor, T00034_A19ParametroPercentual
               }
               , new Object[] {
               T00035_A13ParametroID
               }
               , new Object[] {
               T00036_A13ParametroID
               }
               , new Object[] {
               T00037_A13ParametroID
               }
               , new Object[] {
               T00038_A13ParametroID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000311_A13ParametroID
               }
            }
         );
      }

      private short wcpOAV7ParametroID ;
      private short Z13ParametroID ;
      private short GxWebError ;
      private short AV7ParametroID ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A13ParametroID ;
      private short RcdFound3 ;
      private short GX_JID ;
      private short nIsDirty_3 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int edtParametroID_Enabled ;
      private int edtParametroDtVigenciaIni_Enabled ;
      private int edtParametroDtVigenciaFim_Enabled ;
      private int edtParametroValor_Enabled ;
      private int edtParametroPercentual_Enabled ;
      private int bttBtntrn_enter_Visible ;
      private int bttBtntrn_enter_Enabled ;
      private int bttBtntrn_cancel_Visible ;
      private int bttBtntrn_delete_Visible ;
      private int bttBtntrn_delete_Enabled ;
      private int Dvpanel_tableattributes_Gxcontroltype ;
      private int idxLst ;
      private decimal Z18ParametroValor ;
      private decimal Z19ParametroPercentual ;
      private decimal A18ParametroValor ;
      private decimal A19ParametroPercentual ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String Z16ParametroTipo ;
      private String Z17ParametroPrioritaria ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String A17ParametroPrioritaria ;
      private String Gx_mode ;
      private String A16ParametroTipo ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtParametroDtVigenciaIni_Internalname ;
      private String cmbParametroTipo_Internalname ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divTablecontent_Internalname ;
      private String Dvpanel_tableattributes_Width ;
      private String Dvpanel_tableattributes_Cls ;
      private String Dvpanel_tableattributes_Title ;
      private String Dvpanel_tableattributes_Iconposition ;
      private String Dvpanel_tableattributes_Internalname ;
      private String divTableattributes_Internalname ;
      private String edtParametroID_Internalname ;
      private String edtParametroID_Jsonclick ;
      private String TempTags ;
      private String edtParametroDtVigenciaIni_Jsonclick ;
      private String edtParametroDtVigenciaFim_Internalname ;
      private String edtParametroDtVigenciaFim_Jsonclick ;
      private String cmbParametroTipo_Jsonclick ;
      private String radParametroPrioritaria_Internalname ;
      private String radParametroPrioritaria_Jsonclick ;
      private String edtParametroValor_Internalname ;
      private String edtParametroValor_Jsonclick ;
      private String edtParametroPercentual_Internalname ;
      private String edtParametroPercentual_Jsonclick ;
      private String bttBtntrn_enter_Internalname ;
      private String bttBtntrn_enter_Jsonclick ;
      private String bttBtntrn_cancel_Internalname ;
      private String bttBtntrn_cancel_Jsonclick ;
      private String bttBtntrn_delete_Internalname ;
      private String bttBtntrn_delete_Jsonclick ;
      private String Dvpanel_tableattributes_Objectcall ;
      private String Dvpanel_tableattributes_Class ;
      private String Dvpanel_tableattributes_Height ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode3 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private DateTime Z14ParametroDtVigenciaIni ;
      private DateTime Z15ParametroDtVigenciaFim ;
      private DateTime A14ParametroDtVigenciaIni ;
      private DateTime A15ParametroDtVigenciaFim ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool AV11erro ;
      private bool Dvpanel_tableattributes_Enabled ;
      private bool Dvpanel_tableattributes_Showheader ;
      private bool Dvpanel_tableattributes_Visible ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private bool GXt_boolean1 ;
      private IGxSession AV10WebSession ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbParametroTipo ;
      private GXRadio radParametroPrioritaria ;
      private IDataStoreProvider pr_default ;
      private short[] T00034_A13ParametroID ;
      private DateTime[] T00034_A14ParametroDtVigenciaIni ;
      private DateTime[] T00034_A15ParametroDtVigenciaFim ;
      private String[] T00034_A16ParametroTipo ;
      private String[] T00034_A17ParametroPrioritaria ;
      private decimal[] T00034_A18ParametroValor ;
      private decimal[] T00034_A19ParametroPercentual ;
      private short[] T00035_A13ParametroID ;
      private short[] T00033_A13ParametroID ;
      private DateTime[] T00033_A14ParametroDtVigenciaIni ;
      private DateTime[] T00033_A15ParametroDtVigenciaFim ;
      private String[] T00033_A16ParametroTipo ;
      private String[] T00033_A17ParametroPrioritaria ;
      private decimal[] T00033_A18ParametroValor ;
      private decimal[] T00033_A19ParametroPercentual ;
      private short[] T00036_A13ParametroID ;
      private short[] T00037_A13ParametroID ;
      private short[] T00032_A13ParametroID ;
      private DateTime[] T00032_A14ParametroDtVigenciaIni ;
      private DateTime[] T00032_A15ParametroDtVigenciaFim ;
      private String[] T00032_A16ParametroTipo ;
      private String[] T00032_A17ParametroPrioritaria ;
      private decimal[] T00032_A18ParametroValor ;
      private decimal[] T00032_A19ParametroPercentual ;
      private short[] T00038_A13ParametroID ;
      private short[] T000311_A13ParametroID ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
   }

   public class parametro__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new UpdateCursor(def[7])
         ,new UpdateCursor(def[8])
         ,new ForEachCursor(def[9])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00034 ;
          prmT00034 = new Object[] {
          new Object[] {"@ParametroID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00035 ;
          prmT00035 = new Object[] {
          new Object[] {"@ParametroID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00033 ;
          prmT00033 = new Object[] {
          new Object[] {"@ParametroID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00036 ;
          prmT00036 = new Object[] {
          new Object[] {"@ParametroID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00037 ;
          prmT00037 = new Object[] {
          new Object[] {"@ParametroID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00032 ;
          prmT00032 = new Object[] {
          new Object[] {"@ParametroID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00038 ;
          prmT00038 = new Object[] {
          new Object[] {"@ParametroDtVigenciaIni",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ParametroDtVigenciaFim",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ParametroTipo",SqlDbType.Char,1,0} ,
          new Object[] {"@ParametroPrioritaria",SqlDbType.Char,1,0} ,
          new Object[] {"@ParametroValor",SqlDbType.Decimal,12,2} ,
          new Object[] {"@ParametroPercentual",SqlDbType.Decimal,6,2}
          } ;
          Object[] prmT00039 ;
          prmT00039 = new Object[] {
          new Object[] {"@ParametroDtVigenciaIni",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ParametroDtVigenciaFim",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ParametroTipo",SqlDbType.Char,1,0} ,
          new Object[] {"@ParametroPrioritaria",SqlDbType.Char,1,0} ,
          new Object[] {"@ParametroValor",SqlDbType.Decimal,12,2} ,
          new Object[] {"@ParametroPercentual",SqlDbType.Decimal,6,2} ,
          new Object[] {"@ParametroID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000310 ;
          prmT000310 = new Object[] {
          new Object[] {"@ParametroID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000311 ;
          prmT000311 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T00032", "SELECT [ParametroID], [ParametroDtVigenciaIni], [ParametroDtVigenciaFim], [ParametroTipo], [ParametroPrioritaria], [ParametroValor], [ParametroPercentual] FROM [Parametro] WITH (UPDLOCK) WHERE [ParametroID] = @ParametroID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00032,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00033", "SELECT [ParametroID], [ParametroDtVigenciaIni], [ParametroDtVigenciaFim], [ParametroTipo], [ParametroPrioritaria], [ParametroValor], [ParametroPercentual] FROM [Parametro] WHERE [ParametroID] = @ParametroID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00033,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00034", "SELECT TM1.[ParametroID], TM1.[ParametroDtVigenciaIni], TM1.[ParametroDtVigenciaFim], TM1.[ParametroTipo], TM1.[ParametroPrioritaria], TM1.[ParametroValor], TM1.[ParametroPercentual] FROM [Parametro] TM1 WHERE TM1.[ParametroID] = @ParametroID ORDER BY TM1.[ParametroID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00034,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00035", "SELECT [ParametroID] FROM [Parametro] WHERE [ParametroID] = @ParametroID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00035,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00036", "SELECT TOP 1 [ParametroID] FROM [Parametro] WHERE ( [ParametroID] > @ParametroID) ORDER BY [ParametroID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00036,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T00037", "SELECT TOP 1 [ParametroID] FROM [Parametro] WHERE ( [ParametroID] < @ParametroID) ORDER BY [ParametroID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00037,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T00038", "INSERT INTO [Parametro]([ParametroDtVigenciaIni], [ParametroDtVigenciaFim], [ParametroTipo], [ParametroPrioritaria], [ParametroValor], [ParametroPercentual]) VALUES(@ParametroDtVigenciaIni, @ParametroDtVigenciaFim, @ParametroTipo, @ParametroPrioritaria, @ParametroValor, @ParametroPercentual); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT00038)
             ,new CursorDef("T00039", "UPDATE [Parametro] SET [ParametroDtVigenciaIni]=@ParametroDtVigenciaIni, [ParametroDtVigenciaFim]=@ParametroDtVigenciaFim, [ParametroTipo]=@ParametroTipo, [ParametroPrioritaria]=@ParametroPrioritaria, [ParametroValor]=@ParametroValor, [ParametroPercentual]=@ParametroPercentual  WHERE [ParametroID] = @ParametroID", GxErrorMask.GX_NOMASK,prmT00039)
             ,new CursorDef("T000310", "DELETE FROM [Parametro]  WHERE [ParametroID] = @ParametroID", GxErrorMask.GX_NOMASK,prmT000310)
             ,new CursorDef("T000311", "SELECT [ParametroID] FROM [Parametro] ORDER BY [ParametroID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000311,100, GxCacheFrequency.OFF ,true,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 1) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 1) ;
                ((decimal[]) buf[5])[0] = rslt.getDecimal(6) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 1) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 1) ;
                ((decimal[]) buf[5])[0] = rslt.getDecimal(6) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 1) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 1) ;
                ((decimal[]) buf[5])[0] = rslt.getDecimal(6) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                stmt.SetParameter(6, (decimal)parms[5]);
                return;
             case 7 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                stmt.SetParameter(6, (decimal)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
