/*
               File: Pedido
        Description: Pedido
             Author: GeneXus C# Generator version 16_0_2-131213
       Generated on: 7/12/2019 17:59:33.70
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
   public class pedido : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel16"+"_"+"PEDIDODESCONTOFRETE") == 0 )
         {
            Gx_mode = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            A33PedidoDt = context.localUtil.ParseDateParm( GetNextPar( ));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33PedidoDt", context.localUtil.Format(A33PedidoDt, "99/99/99"));
            A40PedidoTotalFML = NumberUtil.Val( GetNextPar( ), ".");
            n40PedidoTotalFML = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40PedidoTotalFML", StringUtil.LTrim( StringUtil.Str( A40PedidoTotalFML, 12, 2)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX16ASAPEDIDODESCONTOFRETE067( Gx_mode, A33PedidoDt, A40PedidoTotalFML) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel24"+"_"+"PEDIDODESCONTOFRETE") == 0 )
         {
            Gx_mode = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            A33PedidoDt = context.localUtil.ParseDateParm( GetNextPar( ));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33PedidoDt", context.localUtil.Format(A33PedidoDt, "99/99/99"));
            A40PedidoTotalFML = NumberUtil.Val( GetNextPar( ), ".");
            n40PedidoTotalFML = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40PedidoTotalFML", StringUtil.LTrim( StringUtil.Str( A40PedidoTotalFML, 12, 2)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX24ASAPEDIDODESCONTOFRETE068( Gx_mode, A33PedidoDt, A40PedidoTotalFML) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_32") == 0 )
         {
            A32PedidoId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32PedidoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A32PedidoId), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_32( A32PedidoId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_33") == 0 )
         {
            A1PessoaId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1PessoaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1PessoaId), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_33( A1PessoaId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_35") == 0 )
         {
            A8ProdutoId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_35( A8ProdutoId) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridlevel_item") == 0 )
         {
            nRC_GXsfl_63 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_63_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_63_idx = GetNextPar( );
            A33PedidoDt = context.localUtil.ParseDateParm( GetNextPar( ));
            A40PedidoTotalFML = NumberUtil.Val( GetNextPar( ), ".");
            n40PedidoTotalFML = false;
            A39PedidoDescontoFrete = NumberUtil.Val( GetNextPar( ), ".");
            A36PedidoRetirada = StringUtil.StrToBool( GetNextPar( ));
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGridlevel_item_newrow( ) ;
            return  ;
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
               AV7PedidoId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7PedidoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7PedidoId), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vPEDIDOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7PedidoId), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "Pedido", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtPessoaId_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public pedido( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public pedido( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_PedidoId )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7PedidoId = aP1_PedidoId;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbPedidoStatus = new GXCombobox();
         chkPedidoRetirada = new GXCheckbox();
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
         if ( cmbPedidoStatus.ItemCount > 0 )
         {
            A34PedidoStatus = cmbPedidoStatus.getValidValue(A34PedidoStatus);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34PedidoStatus", A34PedidoStatus);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbPedidoStatus.CurrentValue = StringUtil.RTrim( A34PedidoStatus);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPedidoStatus_Internalname, "Values", cmbPedidoStatus.ToJavascriptSource(), true);
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
            GxWebStd.gx_div_start( context, "", edtPedidoId_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPedidoId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPedidoId_Internalname, "Número do Pedido", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtPedidoId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A32PedidoId), 4, 0, ",", "")), ((edtPedidoId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A32PedidoId), "ZZZ9")) : context.localUtil.Format( (decimal)(A32PedidoId), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPedidoId_Jsonclick, 0, "Attribute", "", "", "", "", edtPedidoId_Visible, edtPedidoId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Serial", "right", false, "HLP_Pedido.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Control Group */
            GxWebStd.gx_group_start( context, grpUnnamedgroup1_Internalname, "Cliente", 1, 0, "px", 0, "px", "Group", "", "HLP_Pedido.htm");
            wb_table1_26_067( true) ;
         }
         return  ;
      }

      protected void wb_table1_26_067e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Control Group */
            GxWebStd.gx_group_start( context, grpUnnamedgroup2_Internalname, "Prazos", 1, 0, "px", 0, "px", "Group", "", "HLP_Pedido.htm");
            wb_table2_38_067( true) ;
         }
         return  ;
      }

      protected void wb_table2_38_067e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbPedidoStatus_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbPedidoStatus_Internalname, "Status", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbPedidoStatus, cmbPedidoStatus_Internalname, StringUtil.RTrim( A34PedidoStatus), 1, cmbPedidoStatus_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbPedidoStatus.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", "", true, "HLP_Pedido.htm");
            cmbPedidoStatus.CurrentValue = StringUtil.RTrim( A34PedidoStatus);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPedidoStatus_Internalname, "Values", (String)(cmbPedidoStatus.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkPedidoRetirada_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkPedidoRetirada_Internalname, "Retirar no Local?", "col-sm-3 AttributeCheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkPedidoRetirada_Internalname, StringUtil.BoolToStr( A36PedidoRetirada), "", "Retirar no Local?", 1, chkPedidoRetirada.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(57, this, 'true', 'false');gx.evt.onchange(this, event);\" ");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-lg-6 CellMarginTop", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableleaflevel_item_Internalname, 1, 0, "px", 0, "px", "Table100x100", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 SectionGrid GridNoBorderCell EditableGridCell_LinedAtts", "left", "top", "", "", "div");
            gxdraw_Gridlevel_item( ) ;
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
            GxWebStd.gx_div_start( context, divTable_Internalname, 1, 0, "px", 0, "px", "TableContent", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            wb_table3_73_067( true) ;
         }
         return  ;
      }

      protected void wb_table3_73_067e( bool wbgen )
      {
         if ( wbgen )
         {
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 96,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_enter_Internalname, "", "Confirmar", bttBtntrn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtntrn_enter_Visible, bttBtntrn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Pedido.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 98,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_cancel_Internalname, "", "Fechar", bttBtntrn_cancel_Jsonclick, 1, "Fechar", "", StyleString, ClassString, bttBtntrn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Pedido.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 100,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_delete_Internalname, "", "Eliminar", bttBtntrn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtntrn_delete_Visible, bttBtntrn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Pedido.htm");
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

      protected void wb_table3_73_067( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTab_Internalname, tblTab_Internalname, "", "TableContent", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='DataContentCell DscTop'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablepedidodescontofrete_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockpedidodescontofrete_Internalname, "Desc./Frete", "", "", lblTextblockpedidodescontofrete_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_Pedido.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPedidoDescontoFrete_Internalname, "Desconto/Frete", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 82,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtPedidoDescontoFrete_Internalname, StringUtil.LTrim( StringUtil.NToC( A39PedidoDescontoFrete, 17, 2, ",", "")), StringUtil.LTrim( context.localUtil.Format( A39PedidoDescontoFrete, "R$ ZZZ,ZZZ,ZZ9.99")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,82);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPedidoDescontoFrete_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPedidoDescontoFrete_Enabled, 1, "text", "", 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Pedido.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='DataContentCell DscTop'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablepedidototal_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockpedidototal_Internalname, "Total", "", "", lblTextblockpedidototal_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_Pedido.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPedidoTotal_Internalname, "Total", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 91,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtPedidoTotal_Internalname, StringUtil.LTrim( StringUtil.NToC( A37PedidoTotal, 18, 2, ",", "")), StringUtil.LTrim( context.localUtil.Format( A37PedidoTotal, "R$ Z,ZZZ,ZZ,ZZ9.99")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,91);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPedidoTotal_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPedidoTotal_Enabled, 1, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Pedido.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_73_067e( true) ;
         }
         else
         {
            wb_table3_73_067e( false) ;
         }
      }

      protected void wb_table2_38_067( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblGp_prazo_Internalname, tblGp_prazo_Internalname, "", "", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='RequiredDataContentCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPedidoDt_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPedidoDt_Internalname, "Data do Pedido", "col-sm-3 AttributeDateLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtPedidoDt_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtPedidoDt_Internalname, context.localUtil.Format(A33PedidoDt, "99/99/99"), context.localUtil.Format( A33PedidoDt, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPedidoDt_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtPedidoDt_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Pedido.htm");
            GxWebStd.gx_bitmap( context, edtPedidoDt_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtPedidoDt_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_Pedido.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='RequiredDataContentCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPedidoDtEntrega_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPedidoDtEntrega_Internalname, "Data de Entrega", "col-sm-3 AttributeDateLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtPedidoDtEntrega_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtPedidoDtEntrega_Internalname, context.localUtil.Format(A35PedidoDtEntrega, "99/99/99"), context.localUtil.Format( A35PedidoDtEntrega, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,47);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPedidoDtEntrega_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtPedidoDtEntrega_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Pedido.htm");
            GxWebStd.gx_bitmap( context, edtPedidoDtEntrega_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtPedidoDtEntrega_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_Pedido.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_38_067e( true) ;
         }
         else
         {
            wb_table2_38_067e( false) ;
         }
      }

      protected void wb_table1_26_067( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblGp_pessoa_Internalname, tblGp_pessoa_Internalname, "", "", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='RequiredDataContentCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPessoaId_Internalname, "Id", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtPessoaId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1PessoaId), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A1PessoaId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPessoaId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPessoaId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Serial", "right", false, "HLP_Pedido.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_1_Internalname, sImgUrl, imgprompt_1_Link, "", "", context.GetTheme( ), imgprompt_1_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Pedido.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='DataContentCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPessoaNome_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPessoaNome_Internalname, "Nome", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtPessoaNome_Internalname, A2PessoaNome, StringUtil.RTrim( context.localUtil.Format( A2PessoaNome, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPessoaNome_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPessoaNome_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Pedido.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_26_067e( true) ;
         }
         else
         {
            wb_table1_26_067e( false) ;
         }
      }

      protected void gxdraw_Gridlevel_item( )
      {
         /*  Grid Control  */
         Gridlevel_itemContainer.AddObjectProperty("GridName", "Gridlevel_item");
         Gridlevel_itemContainer.AddObjectProperty("Header", subGridlevel_item_Header);
         Gridlevel_itemContainer.AddObjectProperty("Class", "GridNoBorder WorkWith");
         Gridlevel_itemContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Gridlevel_itemContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Gridlevel_itemContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridlevel_item_Backcolorstyle), 1, 0, ".", "")));
         Gridlevel_itemContainer.AddObjectProperty("CmpContext", "");
         Gridlevel_itemContainer.AddObjectProperty("InMasterPage", "false");
         Gridlevel_itemColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridlevel_itemColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A8ProdutoId), 4, 0, ".", "")));
         Gridlevel_itemColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProdutoId_Enabled), 5, 0, ".", "")));
         Gridlevel_itemContainer.AddColumnProperties(Gridlevel_itemColumn);
         Gridlevel_itemColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridlevel_itemContainer.AddColumnProperties(Gridlevel_itemColumn);
         Gridlevel_itemColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridlevel_itemColumn.AddObjectProperty("Value", A9ProdutoNome);
         Gridlevel_itemColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProdutoNome_Enabled), 5, 0, ".", "")));
         Gridlevel_itemContainer.AddColumnProperties(Gridlevel_itemColumn);
         Gridlevel_itemColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridlevel_itemColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A11ProdutoValor, 12, 2, ".", "")));
         Gridlevel_itemColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProdutoValor_Enabled), 5, 0, ".", "")));
         Gridlevel_itemContainer.AddColumnProperties(Gridlevel_itemColumn);
         Gridlevel_itemColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridlevel_itemColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A38PedidoItemQtd), 4, 0, ".", "")));
         Gridlevel_itemColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPedidoItemQtd_Enabled), 5, 0, ".", "")));
         Gridlevel_itemContainer.AddColumnProperties(Gridlevel_itemColumn);
         Gridlevel_itemContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridlevel_item_Selectedindex), 4, 0, ".", "")));
         Gridlevel_itemContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridlevel_item_Allowselection), 1, 0, ".", "")));
         Gridlevel_itemContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridlevel_item_Selectioncolor), 9, 0, ".", "")));
         Gridlevel_itemContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridlevel_item_Allowhovering), 1, 0, ".", "")));
         Gridlevel_itemContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridlevel_item_Hoveringcolor), 9, 0, ".", "")));
         Gridlevel_itemContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridlevel_item_Allowcollapsing), 1, 0, ".", "")));
         Gridlevel_itemContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridlevel_item_Collapsed), 1, 0, ".", "")));
         nGXsfl_63_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount8 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               /* Display confirmed (stored) records */
               nRcdExists_8 = 1;
               ScanStart068( ) ;
               while ( RcdFound8 != 0 )
               {
                  init_level_properties8( ) ;
                  getByPrimaryKey068( ) ;
                  AddRow068( ) ;
                  ScanNext068( ) ;
               }
               ScanEnd068( ) ;
               nBlankRcdCount8 = 1;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            standaloneNotModal068( ) ;
            standaloneModal068( ) ;
            sMode8 = Gx_mode;
            while ( nGXsfl_63_idx < nRC_GXsfl_63 )
            {
               bGXsfl_63_Refreshing = true;
               ReadRow068( ) ;
               edtProdutoId_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRODUTOID_"+sGXsfl_63_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProdutoId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProdutoId_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
               edtProdutoNome_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRODUTONOME_"+sGXsfl_63_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProdutoNome_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProdutoNome_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
               edtProdutoValor_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRODUTOVALOR_"+sGXsfl_63_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProdutoValor_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProdutoValor_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
               edtPedidoItemQtd_Enabled = (int)(context.localUtil.CToN( cgiGet( "PEDIDOITEMQTD_"+sGXsfl_63_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedidoItemQtd_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedidoItemQtd_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
               imgprompt_1_Link = cgiGet( "PROMPT_8_"+sGXsfl_63_idx+"Link");
               if ( ( nRcdExists_8 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  standaloneModal068( ) ;
               }
               SendRow068( ) ;
               bGXsfl_63_Refreshing = false;
            }
            Gx_mode = sMode8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount8 = 1;
            nRcdExists_8 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               ScanStart068( ) ;
               while ( RcdFound8 != 0 )
               {
                  sGXsfl_63_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_63_idx+1), 4, 0)), 4, "0");
                  SubsflControlProps_638( ) ;
                  init_level_properties8( ) ;
                  standaloneNotModal068( ) ;
                  getByPrimaryKey068( ) ;
                  standaloneModal068( ) ;
                  AddRow068( ) ;
                  ScanNext068( ) ;
               }
               ScanEnd068( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 ) && ( StringUtil.StrCmp(Gx_mode, "DLT") != 0 ) )
         {
            sMode8 = Gx_mode;
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            sGXsfl_63_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_63_idx+1), 4, 0)), 4, "0");
            SubsflControlProps_638( ) ;
            InitAll068( ) ;
            init_level_properties8( ) ;
            standaloneNotModal068( ) ;
            standaloneModal068( ) ;
            nRcdExists_8 = 0;
            nIsMod_8 = 0;
            nRcdDeleted_8 = 0;
            nBlankRcdCount8 = (short)(nBlankRcdUsr8+nBlankRcdCount8);
            fRowAdded = 0;
            while ( nBlankRcdCount8 > 0 )
            {
               AddRow068( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = edtProdutoId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount8 = (short)(nBlankRcdCount8-1);
            }
            Gx_mode = sMode8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Gridlevel_itemContainer"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridlevel_item", Gridlevel_itemContainer);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridlevel_itemContainerData", Gridlevel_itemContainer.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridlevel_itemContainerData"+"V", Gridlevel_itemContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridlevel_itemContainerData"+"V"+"\" value='"+Gridlevel_itemContainer.GridValuesHidden()+"'/>") ;
         }
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
         E11062 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A32PedidoId = (short)(context.localUtil.CToN( cgiGet( edtPedidoId_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32PedidoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A32PedidoId), 4, 0)));
               if ( ( ( context.localUtil.CToN( cgiGet( edtPessoaId_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtPessoaId_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PESSOAID");
                  AnyError = 1;
                  GX_FocusControl = edtPessoaId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A1PessoaId = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1PessoaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1PessoaId), 4, 0)));
               }
               else
               {
                  A1PessoaId = (short)(context.localUtil.CToN( cgiGet( edtPessoaId_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1PessoaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1PessoaId), 4, 0)));
               }
               A2PessoaNome = cgiGet( edtPessoaNome_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2PessoaNome", A2PessoaNome);
               if ( context.localUtil.VCDate( cgiGet( edtPedidoDt_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Data do Pedido"}), 1, "PEDIDODT");
                  AnyError = 1;
                  GX_FocusControl = edtPedidoDt_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A33PedidoDt = DateTime.MinValue;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33PedidoDt", context.localUtil.Format(A33PedidoDt, "99/99/99"));
               }
               else
               {
                  A33PedidoDt = context.localUtil.CToD( cgiGet( edtPedidoDt_Internalname), 2);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33PedidoDt", context.localUtil.Format(A33PedidoDt, "99/99/99"));
               }
               if ( context.localUtil.VCDate( cgiGet( edtPedidoDtEntrega_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Data de Entrega"}), 1, "PEDIDODTENTREGA");
                  AnyError = 1;
                  GX_FocusControl = edtPedidoDtEntrega_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A35PedidoDtEntrega = DateTime.MinValue;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35PedidoDtEntrega", context.localUtil.Format(A35PedidoDtEntrega, "99/99/99"));
               }
               else
               {
                  A35PedidoDtEntrega = context.localUtil.CToD( cgiGet( edtPedidoDtEntrega_Internalname), 2);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35PedidoDtEntrega", context.localUtil.Format(A35PedidoDtEntrega, "99/99/99"));
               }
               cmbPedidoStatus.Name = cmbPedidoStatus_Internalname;
               cmbPedidoStatus.CurrentValue = cgiGet( cmbPedidoStatus_Internalname);
               A34PedidoStatus = cgiGet( cmbPedidoStatus_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34PedidoStatus", A34PedidoStatus);
               A36PedidoRetirada = StringUtil.StrToBool( cgiGet( chkPedidoRetirada_Internalname));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36PedidoRetirada", A36PedidoRetirada);
               if ( ( ( context.localUtil.CToN( cgiGet( edtPedidoDescontoFrete_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtPedidoDescontoFrete_Internalname), ",", ".") > 999999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PEDIDODESCONTOFRETE");
                  AnyError = 1;
                  GX_FocusControl = edtPedidoDescontoFrete_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A39PedidoDescontoFrete = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39PedidoDescontoFrete", StringUtil.LTrim( StringUtil.Str( A39PedidoDescontoFrete, 12, 2)));
               }
               else
               {
                  A39PedidoDescontoFrete = context.localUtil.CToN( cgiGet( edtPedidoDescontoFrete_Internalname), ",", ".");
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39PedidoDescontoFrete", StringUtil.LTrim( StringUtil.Str( A39PedidoDescontoFrete, 12, 2)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtPedidoTotal_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtPedidoTotal_Internalname), ",", ".") > 999999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PEDIDOTOTAL");
                  AnyError = 1;
                  GX_FocusControl = edtPedidoTotal_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A37PedidoTotal = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PedidoTotal", StringUtil.LTrim( StringUtil.Str( A37PedidoTotal, 12, 2)));
               }
               else
               {
                  A37PedidoTotal = context.localUtil.CToN( cgiGet( edtPedidoTotal_Internalname), ",", ".");
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PedidoTotal", StringUtil.LTrim( StringUtil.Str( A37PedidoTotal, 12, 2)));
               }
               /* Read saved values. */
               Z32PedidoId = (short)(context.localUtil.CToN( cgiGet( "Z32PedidoId"), ",", "."));
               Z34PedidoStatus = cgiGet( "Z34PedidoStatus");
               Z39PedidoDescontoFrete = context.localUtil.CToN( cgiGet( "Z39PedidoDescontoFrete"), ",", ".");
               Z37PedidoTotal = context.localUtil.CToN( cgiGet( "Z37PedidoTotal"), ",", ".");
               Z33PedidoDt = context.localUtil.CToD( cgiGet( "Z33PedidoDt"), 0);
               Z35PedidoDtEntrega = context.localUtil.CToD( cgiGet( "Z35PedidoDtEntrega"), 0);
               Z36PedidoRetirada = StringUtil.StrToBool( cgiGet( "Z36PedidoRetirada"));
               Z1PessoaId = (short)(context.localUtil.CToN( cgiGet( "Z1PessoaId"), ",", "."));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               nRC_GXsfl_63 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_63"), ",", "."));
               N1PessoaId = (short)(context.localUtil.CToN( cgiGet( "N1PessoaId"), ",", "."));
               AV7PedidoId = (short)(context.localUtil.CToN( cgiGet( "vPEDIDOID"), ",", "."));
               AV11Insert_PessoaId = (short)(context.localUtil.CToN( cgiGet( "vINSERT_PESSOAID"), ",", "."));
               A40PedidoTotalFML = context.localUtil.CToN( cgiGet( "PEDIDOTOTALFML"), ",", ".");
               AV17PedidoDescontoFrete = context.localUtil.CToN( cgiGet( "vPEDIDODESCONTOFRETE"), ",", ".");
               AV18Pgmname = cgiGet( "vPGMNAME");
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
               forbiddenHiddens = "hsh" + "Pedido";
               A32PedidoId = (short)(context.localUtil.CToN( cgiGet( edtPedidoId_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32PedidoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A32PedidoId), 4, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A32PedidoId), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A32PedidoId != Z32PedidoId ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("pedido:[SecurityCheckFailed value for]"+"PedidoId:"+context.localUtil.Format( (decimal)(A32PedidoId), "ZZZ9"));
                  GXUtil.WriteLog("pedido:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
               /* Check if conditions changed and reset current page numbers */
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
                  A32PedidoId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32PedidoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A32PedidoId), 4, 0)));
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
                     sMode7 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode7;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound7 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_060( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtntrn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "PEDIDOID");
                        AnyError = 1;
                        GX_FocusControl = edtPedidoId_Internalname;
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
                           E11062 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12062 ();
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
                        sEvtType = StringUtil.Right( sEvt, 4);
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
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
            E12062 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll067( ) ;
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
            DisableAttributes067( ) ;
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

      protected void CONFIRM_060( )
      {
         BeforeValidate067( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls067( ) ;
            }
            else
            {
               CheckExtendedTable067( ) ;
               CloseExtendedTableCursors067( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            /* Save parent mode. */
            sMode7 = Gx_mode;
            CONFIRM_068( ) ;
            if ( AnyError == 0 )
            {
               /* Restore parent mode. */
               Gx_mode = sMode7;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
               IsConfirmed = 1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
            }
            /* Restore parent mode. */
            Gx_mode = sMode7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
      }

      protected void CONFIRM_068( )
      {
         sV17PedidoDescontoFrete = OV17PedidoDescontoFrete;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17PedidoDescontoFrete", StringUtil.LTrim( StringUtil.Str( AV17PedidoDescontoFrete, 12, 2)));
         nGXsfl_63_idx = 0;
         while ( nGXsfl_63_idx < nRC_GXsfl_63 )
         {
            ReadRow068( ) ;
            if ( ( nRcdExists_8 != 0 ) || ( nIsMod_8 != 0 ) )
            {
               GetKey068( ) ;
               if ( ( nRcdExists_8 == 0 ) && ( nRcdDeleted_8 == 0 ) )
               {
                  if ( RcdFound8 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     BeforeValidate068( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable068( ) ;
                        CloseExtendedTableCursors068( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                        }
                        OV17PedidoDescontoFrete = AV17PedidoDescontoFrete;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17PedidoDescontoFrete", StringUtil.LTrim( StringUtil.Str( AV17PedidoDescontoFrete, 12, 2)));
                     }
                  }
                  else
                  {
                     GXCCtl = "PRODUTOID_" + sGXsfl_63_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtProdutoId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound8 != 0 )
                  {
                     if ( nRcdDeleted_8 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        getByPrimaryKey068( ) ;
                        Load068( ) ;
                        BeforeValidate068( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls068( ) ;
                           OV17PedidoDescontoFrete = AV17PedidoDescontoFrete;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17PedidoDescontoFrete", StringUtil.LTrim( StringUtil.Str( AV17PedidoDescontoFrete, 12, 2)));
                        }
                     }
                     else
                     {
                        if ( nIsMod_8 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           BeforeValidate068( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable068( ) ;
                              CloseExtendedTableCursors068( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                              }
                              OV17PedidoDescontoFrete = AV17PedidoDescontoFrete;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17PedidoDescontoFrete", StringUtil.LTrim( StringUtil.Str( AV17PedidoDescontoFrete, 12, 2)));
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_8 == 0 )
                     {
                        GXCCtl = "PRODUTOID_" + sGXsfl_63_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtProdutoId_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtProdutoId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A8ProdutoId), 4, 0, ",", ""))) ;
            ChangePostValue( edtProdutoNome_Internalname, A9ProdutoNome) ;
            ChangePostValue( edtProdutoValor_Internalname, StringUtil.LTrim( StringUtil.NToC( A11ProdutoValor, 12, 2, ",", ""))) ;
            ChangePostValue( edtPedidoItemQtd_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A38PedidoItemQtd), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z8ProdutoId_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z8ProdutoId), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z38PedidoItemQtd_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z38PedidoItemQtd), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_8_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_8), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_8_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_8), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_8_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_8), 4, 0, ",", ""))) ;
            if ( nIsMod_8 != 0 )
            {
               ChangePostValue( "PRODUTOID_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProdutoId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRODUTONOME_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProdutoNome_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRODUTOVALOR_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProdutoValor_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PEDIDOITEMQTD_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPedidoItemQtd_Enabled), 5, 0, ".", ""))) ;
            }
         }
         OV17PedidoDescontoFrete = sV17PedidoDescontoFrete;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17PedidoDescontoFrete", StringUtil.LTrim( StringUtil.Str( AV17PedidoDescontoFrete, 12, 2)));
         /* Start of After( level) rules */
         /* Using cursor T00067 */
         pr_default.execute(3, new Object[] {A32PedidoId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            A40PedidoTotalFML = T00067_A40PedidoTotalFML[0];
            n40PedidoTotalFML = T00067_n40PedidoTotalFML[0];
         }
         else
         {
            A40PedidoTotalFML = 0;
            n40PedidoTotalFML = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40PedidoTotalFML", StringUtil.LTrim( StringUtil.Str( A40PedidoTotalFML, 12, 2)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            GXt_decimal1 = A39PedidoDescontoFrete;
            new prc_calculadescfrete(context ).execute(  A33PedidoDt,  A40PedidoTotalFML, out  GXt_decimal1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33PedidoDt", context.localUtil.Format(A33PedidoDt, "99/99/99"));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40PedidoTotalFML", StringUtil.LTrim( StringUtil.Str( A40PedidoTotalFML, 12, 2)));
            A39PedidoDescontoFrete = GXt_decimal1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39PedidoDescontoFrete", StringUtil.LTrim( StringUtil.Str( A39PedidoDescontoFrete, 12, 2)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && A36PedidoRetirada )
         {
            A37PedidoTotal = (decimal)(A40PedidoTotalFML-A39PedidoDescontoFrete);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PedidoTotal", StringUtil.LTrim( StringUtil.Str( A37PedidoTotal, 12, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && ! A36PedidoRetirada )
            {
               A37PedidoTotal = (decimal)(A40PedidoTotalFML+A39PedidoDescontoFrete);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PedidoTotal", StringUtil.LTrim( StringUtil.Str( A37PedidoTotal, 12, 2)));
            }
         }
         /* End of After( level) rules */
      }

      protected void ResetCaption060( )
      {
      }

      protected void E11062( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "WWPTransactionContext", "FMX");
         if ( ( StringUtil.StrCmp(AV9TrnContext.gxTpr_Transactionname, AV18Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV19GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19GXV1), 8, 0)));
            while ( AV19GXV1 <= AV9TrnContext.gxTpr_Attributes.Count )
            {
               AV12TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV9TrnContext.gxTpr_Attributes.Item(AV19GXV1));
               if ( StringUtil.StrCmp(AV12TrnContextAtt.gxTpr_Attributename, "PessoaId") == 0 )
               {
                  AV11Insert_PessoaId = (short)(NumberUtil.Val( AV12TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Insert_PessoaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11Insert_PessoaId), 4, 0)));
               }
               AV19GXV1 = (int)(AV19GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19GXV1), 8, 0)));
            }
         }
      }

      protected void E12062( )
      {
         /* After Trn Routine */
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            CallWebObject(formatLink("pedido.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A32PedidoId));
            context.wjLocDisableFrm = 1;
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("pedidoww.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM067( short GX_JID )
      {
         if ( ( GX_JID == 31 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z34PedidoStatus = T00069_A34PedidoStatus[0];
               Z39PedidoDescontoFrete = T00069_A39PedidoDescontoFrete[0];
               Z37PedidoTotal = T00069_A37PedidoTotal[0];
               Z33PedidoDt = T00069_A33PedidoDt[0];
               Z35PedidoDtEntrega = T00069_A35PedidoDtEntrega[0];
               Z36PedidoRetirada = T00069_A36PedidoRetirada[0];
               Z1PessoaId = T00069_A1PessoaId[0];
            }
            else
            {
               Z34PedidoStatus = A34PedidoStatus;
               Z39PedidoDescontoFrete = A39PedidoDescontoFrete;
               Z37PedidoTotal = A37PedidoTotal;
               Z33PedidoDt = A33PedidoDt;
               Z35PedidoDtEntrega = A35PedidoDtEntrega;
               Z36PedidoRetirada = A36PedidoRetirada;
               Z1PessoaId = A1PessoaId;
            }
         }
         if ( GX_JID == -31 )
         {
            Z32PedidoId = A32PedidoId;
            Z34PedidoStatus = A34PedidoStatus;
            Z39PedidoDescontoFrete = A39PedidoDescontoFrete;
            Z37PedidoTotal = A37PedidoTotal;
            Z33PedidoDt = A33PedidoDt;
            Z35PedidoDtEntrega = A35PedidoDtEntrega;
            Z36PedidoRetirada = A36PedidoRetirada;
            Z1PessoaId = A1PessoaId;
            Z2PessoaNome = A2PessoaNome;
         }
      }

      protected void standaloneNotModal( )
      {
         edtPedidoId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedidoId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedidoId_Enabled), 5, 0)), true);
         edtPedidoDescontoFrete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedidoDescontoFrete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedidoDescontoFrete_Enabled), 5, 0)), true);
         edtPedidoTotal_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedidoTotal_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedidoTotal_Enabled), 5, 0)), true);
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            edtPedidoId_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedidoId_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedidoId_Visible), 5, 0)), true);
         }
         cmbPedidoStatus.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPedidoStatus_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbPedidoStatus.Enabled), 5, 0)), true);
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            chkPedidoRetirada.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkPedidoRetirada_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkPedidoRetirada.Enabled), 5, 0)), true);
         }
         AV18Pgmname = "Pedido";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Pgmname", AV18Pgmname);
         imgprompt_1_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"pessoaprompt.aspx"+"',["+"{Ctrl:gx.dom.el('"+"PESSOAID"+"'), id:'"+"PESSOAID"+"'"+",IOType:'inout'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         edtPedidoId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedidoId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedidoId_Enabled), 5, 0)), true);
         bttBtntrn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7PedidoId) )
         {
            A32PedidoId = AV7PedidoId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32PedidoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A32PedidoId), 4, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV11Insert_PessoaId) )
         {
            edtPessoaId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPessoaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPessoaId_Enabled), 5, 0)), true);
         }
         else
         {
            edtPessoaId_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPessoaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPessoaId_Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            A34PedidoStatus = "AGD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34PedidoStatus", A34PedidoStatus);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV11Insert_PessoaId) )
         {
            A1PessoaId = AV11Insert_PessoaId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1PessoaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1PessoaId), 4, 0)));
         }
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
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            /* Using cursor T00067 */
            pr_default.execute(3, new Object[] {A32PedidoId});
            if ( (pr_default.getStatus(3) != 101) )
            {
               A40PedidoTotalFML = T00067_A40PedidoTotalFML[0];
               n40PedidoTotalFML = T00067_n40PedidoTotalFML[0];
            }
            else
            {
               A40PedidoTotalFML = 0;
               n40PedidoTotalFML = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40PedidoTotalFML", StringUtil.LTrim( StringUtil.Str( A40PedidoTotalFML, 12, 2)));
            }
            pr_default.close(3);
            /* Using cursor T000610 */
            pr_default.execute(6, new Object[] {A1PessoaId});
            A2PessoaNome = T000610_A2PessoaNome[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2PessoaNome", A2PessoaNome);
            pr_default.close(6);
         }
      }

      protected void Load067( )
      {
         /* Using cursor T000611 */
         pr_default.execute(7, new Object[] {A32PedidoId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound7 = 1;
            A34PedidoStatus = T000611_A34PedidoStatus[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34PedidoStatus", A34PedidoStatus);
            A39PedidoDescontoFrete = T000611_A39PedidoDescontoFrete[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39PedidoDescontoFrete", StringUtil.LTrim( StringUtil.Str( A39PedidoDescontoFrete, 12, 2)));
            A37PedidoTotal = T000611_A37PedidoTotal[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PedidoTotal", StringUtil.LTrim( StringUtil.Str( A37PedidoTotal, 12, 2)));
            A2PessoaNome = T000611_A2PessoaNome[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2PessoaNome", A2PessoaNome);
            A33PedidoDt = T000611_A33PedidoDt[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33PedidoDt", context.localUtil.Format(A33PedidoDt, "99/99/99"));
            A35PedidoDtEntrega = T000611_A35PedidoDtEntrega[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35PedidoDtEntrega", context.localUtil.Format(A35PedidoDtEntrega, "99/99/99"));
            A36PedidoRetirada = T000611_A36PedidoRetirada[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36PedidoRetirada", A36PedidoRetirada);
            A1PessoaId = T000611_A1PessoaId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1PessoaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1PessoaId), 4, 0)));
            ZM067( -31) ;
         }
         pr_default.close(7);
         OnLoadActions067( ) ;
      }

      protected void OnLoadActions067( )
      {
         /* Using cursor T00067 */
         pr_default.execute(3, new Object[] {A32PedidoId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            A40PedidoTotalFML = T00067_A40PedidoTotalFML[0];
            n40PedidoTotalFML = T00067_n40PedidoTotalFML[0];
         }
         else
         {
            A40PedidoTotalFML = 0;
            n40PedidoTotalFML = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40PedidoTotalFML", StringUtil.LTrim( StringUtil.Str( A40PedidoTotalFML, 12, 2)));
         }
         pr_default.close(3);
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            GXt_decimal1 = A39PedidoDescontoFrete;
            new prc_calculadescfrete(context ).execute(  A33PedidoDt,  A40PedidoTotalFML, out  GXt_decimal1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33PedidoDt", context.localUtil.Format(A33PedidoDt, "99/99/99"));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40PedidoTotalFML", StringUtil.LTrim( StringUtil.Str( A40PedidoTotalFML, 12, 2)));
            A39PedidoDescontoFrete = GXt_decimal1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39PedidoDescontoFrete", StringUtil.LTrim( StringUtil.Str( A39PedidoDescontoFrete, 12, 2)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && A36PedidoRetirada )
         {
            A37PedidoTotal = (decimal)(A40PedidoTotalFML-A39PedidoDescontoFrete);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PedidoTotal", StringUtil.LTrim( StringUtil.Str( A37PedidoTotal, 12, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && ! A36PedidoRetirada )
            {
               A37PedidoTotal = (decimal)(A40PedidoTotalFML+A39PedidoDescontoFrete);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PedidoTotal", StringUtil.LTrim( StringUtil.Str( A37PedidoTotal, 12, 2)));
            }
         }
         AV17PedidoDescontoFrete = A39PedidoDescontoFrete;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17PedidoDescontoFrete", StringUtil.LTrim( StringUtil.Str( AV17PedidoDescontoFrete, 12, 2)));
      }

      protected void CheckExtendedTable067( )
      {
         nIsDirty_7 = 0;
         Gx_BScreen = 1;
         standaloneModal( ) ;
         /* Using cursor T00067 */
         pr_default.execute(3, new Object[] {A32PedidoId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            A40PedidoTotalFML = T00067_A40PedidoTotalFML[0];
            n40PedidoTotalFML = T00067_n40PedidoTotalFML[0];
         }
         else
         {
            nIsDirty_7 = 1;
            A40PedidoTotalFML = 0;
            n40PedidoTotalFML = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40PedidoTotalFML", StringUtil.LTrim( StringUtil.Str( A40PedidoTotalFML, 12, 2)));
         }
         pr_default.close(3);
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            nIsDirty_7 = 1;
            GXt_decimal1 = A39PedidoDescontoFrete;
            new prc_calculadescfrete(context ).execute(  A33PedidoDt,  A40PedidoTotalFML, out  GXt_decimal1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33PedidoDt", context.localUtil.Format(A33PedidoDt, "99/99/99"));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40PedidoTotalFML", StringUtil.LTrim( StringUtil.Str( A40PedidoTotalFML, 12, 2)));
            A39PedidoDescontoFrete = GXt_decimal1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39PedidoDescontoFrete", StringUtil.LTrim( StringUtil.Str( A39PedidoDescontoFrete, 12, 2)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && A36PedidoRetirada )
         {
            nIsDirty_7 = 1;
            A37PedidoTotal = (decimal)(A40PedidoTotalFML-A39PedidoDescontoFrete);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PedidoTotal", StringUtil.LTrim( StringUtil.Str( A37PedidoTotal, 12, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && ! A36PedidoRetirada )
            {
               nIsDirty_7 = 1;
               A37PedidoTotal = (decimal)(A40PedidoTotalFML+A39PedidoDescontoFrete);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PedidoTotal", StringUtil.LTrim( StringUtil.Str( A37PedidoTotal, 12, 2)));
            }
         }
         /* Using cursor T000610 */
         pr_default.execute(6, new Object[] {A1PessoaId});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("Não existe 'Pessoa'.", "ForeignKeyNotFound", 1, "PESSOAID");
            AnyError = 1;
            GX_FocusControl = edtPessoaId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A2PessoaNome = T000610_A2PessoaNome[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2PessoaNome", A2PessoaNome);
         pr_default.close(6);
         if ( (0==A1PessoaId) )
         {
            GX_msglist.addItem("Id é obrigatório.", 1, "PESSOAID");
            AnyError = 1;
            GX_FocusControl = edtPessoaId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( (DateTime.MinValue==A33PedidoDt) || ( A33PedidoDt >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Data do Pedido fora do intervalo", "OutOfRange", 1, "PEDIDODT");
            AnyError = 1;
            GX_FocusControl = edtPedidoDt_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( (DateTime.MinValue==A33PedidoDt) )
         {
            GX_msglist.addItem("Data do Pedido é obrigatório.", 1, "PEDIDODT");
            AnyError = 1;
            GX_FocusControl = edtPedidoDt_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( A35PedidoDtEntrega < A33PedidoDt )
         {
            GX_msglist.addItem("A data de entrega não pode ser menor que a data do pedido.", 1, "PEDIDODT");
            AnyError = 1;
            GX_FocusControl = edtPedidoDt_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( ( StringUtil.StrCmp(A34PedidoStatus, "AGD") == 0 ) || ( StringUtil.StrCmp(A34PedidoStatus, "APR") == 0 ) || ( StringUtil.StrCmp(A34PedidoStatus, "REP") == 0 ) || ( StringUtil.StrCmp(A34PedidoStatus, "ENC") == 0 ) ) )
         {
            GX_msglist.addItem("Campo Status fora do intervalo", "OutOfRange", 1, "PEDIDOSTATUS");
            AnyError = 1;
            GX_FocusControl = cmbPedidoStatus_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( (DateTime.MinValue==A35PedidoDtEntrega) || ( A35PedidoDtEntrega >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Data de Entrega fora do intervalo", "OutOfRange", 1, "PEDIDODTENTREGA");
            AnyError = 1;
            GX_FocusControl = edtPedidoDtEntrega_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( (DateTime.MinValue==A35PedidoDtEntrega) )
         {
            GX_msglist.addItem("Data de Entrega é obrigatório.", 1, "PEDIDODTENTREGA");
            AnyError = 1;
            GX_FocusControl = edtPedidoDtEntrega_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         AV17PedidoDescontoFrete = A39PedidoDescontoFrete;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17PedidoDescontoFrete", StringUtil.LTrim( StringUtil.Str( AV17PedidoDescontoFrete, 12, 2)));
      }

      protected void CloseExtendedTableCursors067( )
      {
         pr_default.close(3);
         pr_default.close(6);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_32( short A32PedidoId )
      {
         /* Using cursor T000614 */
         pr_default.execute(8, new Object[] {A32PedidoId});
         if ( (pr_default.getStatus(8) != 101) )
         {
            A40PedidoTotalFML = T000614_A40PedidoTotalFML[0];
            n40PedidoTotalFML = T000614_n40PedidoTotalFML[0];
         }
         else
         {
            A40PedidoTotalFML = 0;
            n40PedidoTotalFML = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40PedidoTotalFML", StringUtil.LTrim( StringUtil.Str( A40PedidoTotalFML, 12, 2)));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( A40PedidoTotalFML, 12, 2, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(8) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(8);
      }

      protected void gxLoad_33( short A1PessoaId )
      {
         /* Using cursor T000615 */
         pr_default.execute(9, new Object[] {A1PessoaId});
         if ( (pr_default.getStatus(9) == 101) )
         {
            GX_msglist.addItem("Não existe 'Pessoa'.", "ForeignKeyNotFound", 1, "PESSOAID");
            AnyError = 1;
            GX_FocusControl = edtPessoaId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A2PessoaNome = T000615_A2PessoaNome[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2PessoaNome", A2PessoaNome);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A2PessoaNome)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(9) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(9);
      }

      protected void GetKey067( )
      {
         /* Using cursor T000616 */
         pr_default.execute(10, new Object[] {A32PedidoId});
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound7 = 1;
         }
         else
         {
            RcdFound7 = 0;
         }
         pr_default.close(10);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00069 */
         pr_default.execute(5, new Object[] {A32PedidoId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            ZM067( 31) ;
            RcdFound7 = 1;
            A32PedidoId = T00069_A32PedidoId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32PedidoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A32PedidoId), 4, 0)));
            A34PedidoStatus = T00069_A34PedidoStatus[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34PedidoStatus", A34PedidoStatus);
            A39PedidoDescontoFrete = T00069_A39PedidoDescontoFrete[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39PedidoDescontoFrete", StringUtil.LTrim( StringUtil.Str( A39PedidoDescontoFrete, 12, 2)));
            A37PedidoTotal = T00069_A37PedidoTotal[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PedidoTotal", StringUtil.LTrim( StringUtil.Str( A37PedidoTotal, 12, 2)));
            A33PedidoDt = T00069_A33PedidoDt[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33PedidoDt", context.localUtil.Format(A33PedidoDt, "99/99/99"));
            A35PedidoDtEntrega = T00069_A35PedidoDtEntrega[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35PedidoDtEntrega", context.localUtil.Format(A35PedidoDtEntrega, "99/99/99"));
            A36PedidoRetirada = T00069_A36PedidoRetirada[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36PedidoRetirada", A36PedidoRetirada);
            A1PessoaId = T00069_A1PessoaId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1PessoaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1PessoaId), 4, 0)));
            Z32PedidoId = A32PedidoId;
            sMode7 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load067( ) ;
            if ( AnyError == 1 )
            {
               RcdFound7 = 0;
               InitializeNonKey067( ) ;
            }
            Gx_mode = sMode7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound7 = 0;
            InitializeNonKey067( ) ;
            sMode7 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(5);
      }

      protected void getEqualNoModal( )
      {
         GetKey067( ) ;
         if ( RcdFound7 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound7 = 0;
         /* Using cursor T000617 */
         pr_default.execute(11, new Object[] {A32PedidoId});
         if ( (pr_default.getStatus(11) != 101) )
         {
            while ( (pr_default.getStatus(11) != 101) && ( ( T000617_A32PedidoId[0] < A32PedidoId ) ) )
            {
               pr_default.readNext(11);
            }
            if ( (pr_default.getStatus(11) != 101) && ( ( T000617_A32PedidoId[0] > A32PedidoId ) ) )
            {
               A32PedidoId = T000617_A32PedidoId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32PedidoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A32PedidoId), 4, 0)));
               RcdFound7 = 1;
            }
         }
         pr_default.close(11);
      }

      protected void move_previous( )
      {
         RcdFound7 = 0;
         /* Using cursor T000618 */
         pr_default.execute(12, new Object[] {A32PedidoId});
         if ( (pr_default.getStatus(12) != 101) )
         {
            while ( (pr_default.getStatus(12) != 101) && ( ( T000618_A32PedidoId[0] > A32PedidoId ) ) )
            {
               pr_default.readNext(12);
            }
            if ( (pr_default.getStatus(12) != 101) && ( ( T000618_A32PedidoId[0] < A32PedidoId ) ) )
            {
               A32PedidoId = T000618_A32PedidoId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32PedidoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A32PedidoId), 4, 0)));
               RcdFound7 = 1;
            }
         }
         pr_default.close(12);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey067( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            AV17PedidoDescontoFrete = OV17PedidoDescontoFrete;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17PedidoDescontoFrete", StringUtil.LTrim( StringUtil.Str( AV17PedidoDescontoFrete, 12, 2)));
            GX_FocusControl = edtPessoaId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert067( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound7 == 1 )
            {
               if ( A32PedidoId != Z32PedidoId )
               {
                  A32PedidoId = Z32PedidoId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32PedidoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A32PedidoId), 4, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "PEDIDOID");
                  AnyError = 1;
                  GX_FocusControl = edtPedidoId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  AV17PedidoDescontoFrete = OV17PedidoDescontoFrete;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17PedidoDescontoFrete", StringUtil.LTrim( StringUtil.Str( AV17PedidoDescontoFrete, 12, 2)));
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtPessoaId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  AV17PedidoDescontoFrete = OV17PedidoDescontoFrete;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17PedidoDescontoFrete", StringUtil.LTrim( StringUtil.Str( AV17PedidoDescontoFrete, 12, 2)));
                  Update067( ) ;
                  GX_FocusControl = edtPessoaId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A32PedidoId != Z32PedidoId )
               {
                  /* Insert record */
                  AV17PedidoDescontoFrete = OV17PedidoDescontoFrete;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17PedidoDescontoFrete", StringUtil.LTrim( StringUtil.Str( AV17PedidoDescontoFrete, 12, 2)));
                  GX_FocusControl = edtPessoaId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert067( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "PEDIDOID");
                     AnyError = 1;
                     GX_FocusControl = edtPedidoId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     AV17PedidoDescontoFrete = OV17PedidoDescontoFrete;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17PedidoDescontoFrete", StringUtil.LTrim( StringUtil.Str( AV17PedidoDescontoFrete, 12, 2)));
                     GX_FocusControl = edtPessoaId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert067( ) ;
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
         if ( A32PedidoId != Z32PedidoId )
         {
            A32PedidoId = Z32PedidoId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32PedidoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A32PedidoId), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "PEDIDOID");
            AnyError = 1;
            GX_FocusControl = edtPedidoId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            AV17PedidoDescontoFrete = OV17PedidoDescontoFrete;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17PedidoDescontoFrete", StringUtil.LTrim( StringUtil.Str( AV17PedidoDescontoFrete, 12, 2)));
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtPessoaId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency067( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00068 */
            pr_default.execute(4, new Object[] {A32PedidoId});
            if ( (pr_default.getStatus(4) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Pedido"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(4) == 101) || ( StringUtil.StrCmp(Z34PedidoStatus, T00068_A34PedidoStatus[0]) != 0 ) || ( Z39PedidoDescontoFrete != T00068_A39PedidoDescontoFrete[0] ) || ( Z37PedidoTotal != T00068_A37PedidoTotal[0] ) || ( Z33PedidoDt != T00068_A33PedidoDt[0] ) || ( Z35PedidoDtEntrega != T00068_A35PedidoDtEntrega[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z36PedidoRetirada != T00068_A36PedidoRetirada[0] ) || ( Z1PessoaId != T00068_A1PessoaId[0] ) )
            {
               if ( StringUtil.StrCmp(Z34PedidoStatus, T00068_A34PedidoStatus[0]) != 0 )
               {
                  GXUtil.WriteLog("pedido:[seudo value changed for attri]"+"PedidoStatus");
                  GXUtil.WriteLogRaw("Old: ",Z34PedidoStatus);
                  GXUtil.WriteLogRaw("Current: ",T00068_A34PedidoStatus[0]);
               }
               if ( Z39PedidoDescontoFrete != T00068_A39PedidoDescontoFrete[0] )
               {
                  GXUtil.WriteLog("pedido:[seudo value changed for attri]"+"PedidoDescontoFrete");
                  GXUtil.WriteLogRaw("Old: ",Z39PedidoDescontoFrete);
                  GXUtil.WriteLogRaw("Current: ",T00068_A39PedidoDescontoFrete[0]);
               }
               if ( Z37PedidoTotal != T00068_A37PedidoTotal[0] )
               {
                  GXUtil.WriteLog("pedido:[seudo value changed for attri]"+"PedidoTotal");
                  GXUtil.WriteLogRaw("Old: ",Z37PedidoTotal);
                  GXUtil.WriteLogRaw("Current: ",T00068_A37PedidoTotal[0]);
               }
               if ( Z33PedidoDt != T00068_A33PedidoDt[0] )
               {
                  GXUtil.WriteLog("pedido:[seudo value changed for attri]"+"PedidoDt");
                  GXUtil.WriteLogRaw("Old: ",Z33PedidoDt);
                  GXUtil.WriteLogRaw("Current: ",T00068_A33PedidoDt[0]);
               }
               if ( Z35PedidoDtEntrega != T00068_A35PedidoDtEntrega[0] )
               {
                  GXUtil.WriteLog("pedido:[seudo value changed for attri]"+"PedidoDtEntrega");
                  GXUtil.WriteLogRaw("Old: ",Z35PedidoDtEntrega);
                  GXUtil.WriteLogRaw("Current: ",T00068_A35PedidoDtEntrega[0]);
               }
               if ( Z36PedidoRetirada != T00068_A36PedidoRetirada[0] )
               {
                  GXUtil.WriteLog("pedido:[seudo value changed for attri]"+"PedidoRetirada");
                  GXUtil.WriteLogRaw("Old: ",Z36PedidoRetirada);
                  GXUtil.WriteLogRaw("Current: ",T00068_A36PedidoRetirada[0]);
               }
               if ( Z1PessoaId != T00068_A1PessoaId[0] )
               {
                  GXUtil.WriteLog("pedido:[seudo value changed for attri]"+"PessoaId");
                  GXUtil.WriteLogRaw("Old: ",Z1PessoaId);
                  GXUtil.WriteLogRaw("Current: ",T00068_A1PessoaId[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Pedido"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert067( )
      {
         BeforeValidate067( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable067( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM067( 0) ;
            CheckOptimisticConcurrency067( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm067( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert067( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000619 */
                     pr_default.execute(13, new Object[] {A34PedidoStatus, A39PedidoDescontoFrete, A37PedidoTotal, A33PedidoDt, A35PedidoDtEntrega, A36PedidoRetirada, A1PessoaId});
                     A32PedidoId = T000619_A32PedidoId[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32PedidoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A32PedidoId), 4, 0)));
                     pr_default.close(13);
                     dsDefault.SmartCacheProvider.SetUpdated("Pedido") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel067( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                              ResetCaption060( ) ;
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
            else
            {
               Load067( ) ;
            }
            EndLevel067( ) ;
         }
         CloseExtendedTableCursors067( ) ;
      }

      protected void Update067( )
      {
         BeforeValidate067( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable067( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency067( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm067( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate067( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000620 */
                     pr_default.execute(14, new Object[] {A34PedidoStatus, A39PedidoDescontoFrete, A37PedidoTotal, A33PedidoDt, A35PedidoDtEntrega, A36PedidoRetirada, A1PessoaId, A32PedidoId});
                     pr_default.close(14);
                     dsDefault.SmartCacheProvider.SetUpdated("Pedido") ;
                     if ( (pr_default.getStatus(14) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Pedido"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate067( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel067( ) ;
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
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel067( ) ;
         }
         CloseExtendedTableCursors067( ) ;
      }

      protected void DeferredUpdate067( )
      {
      }

      protected void delete( )
      {
         BeforeValidate067( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency067( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls067( ) ;
            AfterConfirm067( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete067( ) ;
               if ( AnyError == 0 )
               {
                  AV17PedidoDescontoFrete = OV17PedidoDescontoFrete;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17PedidoDescontoFrete", StringUtil.LTrim( StringUtil.Str( AV17PedidoDescontoFrete, 12, 2)));
                  ScanStart068( ) ;
                  while ( RcdFound8 != 0 )
                  {
                     getByPrimaryKey068( ) ;
                     Delete068( ) ;
                     ScanNext068( ) ;
                     OV17PedidoDescontoFrete = AV17PedidoDescontoFrete;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17PedidoDescontoFrete", StringUtil.LTrim( StringUtil.Str( AV17PedidoDescontoFrete, 12, 2)));
                  }
                  ScanEnd068( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000621 */
                     pr_default.execute(15, new Object[] {A32PedidoId});
                     pr_default.close(15);
                     dsDefault.SmartCacheProvider.SetUpdated("Pedido") ;
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
         }
         sMode7 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel067( ) ;
         Gx_mode = sMode7;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls067( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000624 */
            pr_default.execute(16, new Object[] {A32PedidoId});
            if ( (pr_default.getStatus(16) != 101) )
            {
               A40PedidoTotalFML = T000624_A40PedidoTotalFML[0];
               n40PedidoTotalFML = T000624_n40PedidoTotalFML[0];
            }
            else
            {
               A40PedidoTotalFML = 0;
               n40PedidoTotalFML = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40PedidoTotalFML", StringUtil.LTrim( StringUtil.Str( A40PedidoTotalFML, 12, 2)));
            }
            pr_default.close(16);
            /* Using cursor T000625 */
            pr_default.execute(17, new Object[] {A1PessoaId});
            A2PessoaNome = T000625_A2PessoaNome[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2PessoaNome", A2PessoaNome);
            pr_default.close(17);
            AV17PedidoDescontoFrete = A39PedidoDescontoFrete;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17PedidoDescontoFrete", StringUtil.LTrim( StringUtil.Str( AV17PedidoDescontoFrete, 12, 2)));
         }
      }

      protected void ProcessNestedLevel068( )
      {
         sV17PedidoDescontoFrete = OV17PedidoDescontoFrete;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17PedidoDescontoFrete", StringUtil.LTrim( StringUtil.Str( AV17PedidoDescontoFrete, 12, 2)));
         nGXsfl_63_idx = 0;
         while ( nGXsfl_63_idx < nRC_GXsfl_63 )
         {
            ReadRow068( ) ;
            if ( ( nRcdExists_8 != 0 ) || ( nIsMod_8 != 0 ) )
            {
               standaloneNotModal068( ) ;
               GetKey068( ) ;
               if ( ( nRcdExists_8 == 0 ) && ( nRcdDeleted_8 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  Insert068( ) ;
               }
               else
               {
                  if ( RcdFound8 != 0 )
                  {
                     if ( ( nRcdDeleted_8 != 0 ) && ( nRcdExists_8 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        Delete068( ) ;
                     }
                     else
                     {
                        if ( nRcdExists_8 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           Update068( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_8 == 0 )
                     {
                        GXCCtl = "PRODUTOID_" + sGXsfl_63_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtProdutoId_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
               OV17PedidoDescontoFrete = AV17PedidoDescontoFrete;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17PedidoDescontoFrete", StringUtil.LTrim( StringUtil.Str( AV17PedidoDescontoFrete, 12, 2)));
            }
            ChangePostValue( edtProdutoId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A8ProdutoId), 4, 0, ",", ""))) ;
            ChangePostValue( edtProdutoNome_Internalname, A9ProdutoNome) ;
            ChangePostValue( edtProdutoValor_Internalname, StringUtil.LTrim( StringUtil.NToC( A11ProdutoValor, 12, 2, ",", ""))) ;
            ChangePostValue( edtPedidoItemQtd_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A38PedidoItemQtd), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z8ProdutoId_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z8ProdutoId), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z38PedidoItemQtd_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z38PedidoItemQtd), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_8_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_8), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_8_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_8), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_8_"+sGXsfl_63_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_8), 4, 0, ",", ""))) ;
            if ( nIsMod_8 != 0 )
            {
               ChangePostValue( "PRODUTOID_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProdutoId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRODUTONOME_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProdutoNome_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRODUTOVALOR_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProdutoValor_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PEDIDOITEMQTD_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPedidoItemQtd_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* Using cursor T000624 */
         pr_default.execute(16, new Object[] {A32PedidoId});
         if ( (pr_default.getStatus(16) != 101) )
         {
            A40PedidoTotalFML = T000624_A40PedidoTotalFML[0];
            n40PedidoTotalFML = T000624_n40PedidoTotalFML[0];
         }
         else
         {
            A40PedidoTotalFML = 0;
            n40PedidoTotalFML = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40PedidoTotalFML", StringUtil.LTrim( StringUtil.Str( A40PedidoTotalFML, 12, 2)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            GXt_decimal1 = A39PedidoDescontoFrete;
            new prc_calculadescfrete(context ).execute(  A33PedidoDt,  A40PedidoTotalFML, out  GXt_decimal1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33PedidoDt", context.localUtil.Format(A33PedidoDt, "99/99/99"));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40PedidoTotalFML", StringUtil.LTrim( StringUtil.Str( A40PedidoTotalFML, 12, 2)));
            A39PedidoDescontoFrete = GXt_decimal1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39PedidoDescontoFrete", StringUtil.LTrim( StringUtil.Str( A39PedidoDescontoFrete, 12, 2)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && A36PedidoRetirada )
         {
            A37PedidoTotal = (decimal)(A40PedidoTotalFML-A39PedidoDescontoFrete);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PedidoTotal", StringUtil.LTrim( StringUtil.Str( A37PedidoTotal, 12, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && ! A36PedidoRetirada )
            {
               A37PedidoTotal = (decimal)(A40PedidoTotalFML+A39PedidoDescontoFrete);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PedidoTotal", StringUtil.LTrim( StringUtil.Str( A37PedidoTotal, 12, 2)));
            }
         }
         /* End of After( level) rules */
         InitAll068( ) ;
         if ( AnyError != 0 )
         {
            OV17PedidoDescontoFrete = sV17PedidoDescontoFrete;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17PedidoDescontoFrete", StringUtil.LTrim( StringUtil.Str( AV17PedidoDescontoFrete, 12, 2)));
         }
         nRcdExists_8 = 0;
         nIsMod_8 = 0;
         nRcdDeleted_8 = 0;
      }

      protected void ProcessLevel067( )
      {
         /* Save parent mode. */
         sMode7 = Gx_mode;
         ProcessNestedLevel068( ) ;
         if ( AnyError != 0 )
         {
            OV17PedidoDescontoFrete = sV17PedidoDescontoFrete;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17PedidoDescontoFrete", StringUtil.LTrim( StringUtil.Str( AV17PedidoDescontoFrete, 12, 2)));
         }
         /* Restore parent mode. */
         Gx_mode = sMode7;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         /* ' Update level parameters */
         /* Using cursor T000626 */
         pr_default.execute(18, new Object[] {A39PedidoDescontoFrete, A37PedidoTotal, A32PedidoId});
         pr_default.close(18);
         dsDefault.SmartCacheProvider.SetUpdated("Pedido") ;
      }

      protected void EndLevel067( )
      {
         pr_default.close(4);
         if ( AnyError == 0 )
         {
            BeforeComplete067( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(5);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(16);
            pr_default.close(17);
            pr_default.close(2);
            context.CommitDataStores("pedido",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues060( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(5);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(16);
            pr_default.close(17);
            pr_default.close(2);
            context.RollbackDataStores("pedido",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart067( )
      {
         /* Scan By routine */
         /* Using cursor T000627 */
         pr_default.execute(19);
         RcdFound7 = 0;
         if ( (pr_default.getStatus(19) != 101) )
         {
            RcdFound7 = 1;
            A32PedidoId = T000627_A32PedidoId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32PedidoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A32PedidoId), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext067( )
      {
         /* Scan next routine */
         pr_default.readNext(19);
         RcdFound7 = 0;
         if ( (pr_default.getStatus(19) != 101) )
         {
            RcdFound7 = 1;
            A32PedidoId = T000627_A32PedidoId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32PedidoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A32PedidoId), 4, 0)));
         }
      }

      protected void ScanEnd067( )
      {
         pr_default.close(19);
      }

      protected void AfterConfirm067( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert067( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate067( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete067( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete067( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate067( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes067( )
      {
         edtPedidoId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedidoId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedidoId_Enabled), 5, 0)), true);
         edtPessoaId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPessoaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPessoaId_Enabled), 5, 0)), true);
         edtPessoaNome_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPessoaNome_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPessoaNome_Enabled), 5, 0)), true);
         edtPedidoDt_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedidoDt_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedidoDt_Enabled), 5, 0)), true);
         edtPedidoDtEntrega_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedidoDtEntrega_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedidoDtEntrega_Enabled), 5, 0)), true);
         cmbPedidoStatus.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPedidoStatus_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbPedidoStatus.Enabled), 5, 0)), true);
         chkPedidoRetirada.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkPedidoRetirada_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkPedidoRetirada.Enabled), 5, 0)), true);
         edtPedidoDescontoFrete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedidoDescontoFrete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedidoDescontoFrete_Enabled), 5, 0)), true);
         edtPedidoTotal_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedidoTotal_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedidoTotal_Enabled), 5, 0)), true);
      }

      protected void ZM068( short GX_JID )
      {
         if ( ( GX_JID == 34 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z38PedidoItemQtd = T00063_A38PedidoItemQtd[0];
            }
            else
            {
               Z38PedidoItemQtd = A38PedidoItemQtd;
            }
         }
         if ( GX_JID == -34 )
         {
            Z32PedidoId = A32PedidoId;
            Z38PedidoItemQtd = A38PedidoItemQtd;
            Z8ProdutoId = A8ProdutoId;
            Z9ProdutoNome = A9ProdutoNome;
            Z11ProdutoValor = A11ProdutoValor;
         }
      }

      protected void standaloneNotModal068( )
      {
         edtPedidoDescontoFrete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedidoDescontoFrete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedidoDescontoFrete_Enabled), 5, 0)), true);
         edtPedidoTotal_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedidoTotal_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedidoTotal_Enabled), 5, 0)), true);
      }

      protected void standaloneModal068( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            GXt_decimal1 = A39PedidoDescontoFrete;
            new prc_calculadescfrete(context ).execute(  A33PedidoDt,  A40PedidoTotalFML, out  GXt_decimal1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33PedidoDt", context.localUtil.Format(A33PedidoDt, "99/99/99"));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40PedidoTotalFML", StringUtil.LTrim( StringUtil.Str( A40PedidoTotalFML, 12, 2)));
            A39PedidoDescontoFrete = GXt_decimal1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39PedidoDescontoFrete", StringUtil.LTrim( StringUtil.Str( A39PedidoDescontoFrete, 12, 2)));
         }
         AV17PedidoDescontoFrete = A39PedidoDescontoFrete;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17PedidoDescontoFrete", StringUtil.LTrim( StringUtil.Str( AV17PedidoDescontoFrete, 12, 2)));
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && A36PedidoRetirada )
         {
            A37PedidoTotal = (decimal)(A40PedidoTotalFML-A39PedidoDescontoFrete);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PedidoTotal", StringUtil.LTrim( StringUtil.Str( A37PedidoTotal, 12, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && ! A36PedidoRetirada )
            {
               A37PedidoTotal = (decimal)(A40PedidoTotalFML+A39PedidoDescontoFrete);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PedidoTotal", StringUtil.LTrim( StringUtil.Str( A37PedidoTotal, 12, 2)));
            }
         }
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtProdutoId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProdutoId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProdutoId_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
         }
         else
         {
            edtProdutoId_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProdutoId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProdutoId_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
         }
      }

      protected void Load068( )
      {
         /* Using cursor T000628 */
         pr_default.execute(20, new Object[] {A32PedidoId, A8ProdutoId});
         if ( (pr_default.getStatus(20) != 101) )
         {
            RcdFound8 = 1;
            A9ProdutoNome = T000628_A9ProdutoNome[0];
            A11ProdutoValor = T000628_A11ProdutoValor[0];
            A38PedidoItemQtd = T000628_A38PedidoItemQtd[0];
            ZM068( -34) ;
         }
         pr_default.close(20);
         OnLoadActions068( ) ;
      }

      protected void OnLoadActions068( )
      {
      }

      protected void CheckExtendedTable068( )
      {
         nIsDirty_8 = 0;
         Gx_BScreen = 1;
         standaloneModal068( ) ;
         /* Using cursor T00064 */
         pr_default.execute(2, new Object[] {A8ProdutoId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GXCCtl = "PRODUTOID_" + sGXsfl_63_idx;
            GX_msglist.addItem("Não existe 'Produto'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtProdutoId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A9ProdutoNome = T00064_A9ProdutoNome[0];
         A11ProdutoValor = T00064_A11ProdutoValor[0];
         pr_default.close(2);
         if ( (0==A8ProdutoId) )
         {
            GXCCtl = "PRODUTOID_" + sGXsfl_63_idx;
            GX_msglist.addItem("Id é obrigatório.", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtProdutoId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( (0==A38PedidoItemQtd) )
         {
            GXCCtl = "PEDIDOITEMQTD_" + sGXsfl_63_idx;
            GX_msglist.addItem("Quantidade é obrigatório.", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtPedidoItemQtd_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors068( )
      {
         pr_default.close(2);
      }

      protected void enableDisable068( )
      {
      }

      protected void gxLoad_35( short A8ProdutoId )
      {
         /* Using cursor T000629 */
         pr_default.execute(21, new Object[] {A8ProdutoId});
         if ( (pr_default.getStatus(21) == 101) )
         {
            GXCCtl = "PRODUTOID_" + sGXsfl_63_idx;
            GX_msglist.addItem("Não existe 'Produto'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtProdutoId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A9ProdutoNome = T000629_A9ProdutoNome[0];
         A11ProdutoValor = T000629_A11ProdutoValor[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A9ProdutoNome)+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( A11ProdutoValor, 12, 2, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(21) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(21);
      }

      protected void GetKey068( )
      {
         /* Using cursor T000630 */
         pr_default.execute(22, new Object[] {A32PedidoId, A8ProdutoId});
         if ( (pr_default.getStatus(22) != 101) )
         {
            RcdFound8 = 1;
         }
         else
         {
            RcdFound8 = 0;
         }
         pr_default.close(22);
      }

      protected void getByPrimaryKey068( )
      {
         /* Using cursor T00063 */
         pr_default.execute(1, new Object[] {A32PedidoId, A8ProdutoId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM068( 34) ;
            RcdFound8 = 1;
            InitializeNonKey068( ) ;
            A38PedidoItemQtd = T00063_A38PedidoItemQtd[0];
            A8ProdutoId = T00063_A8ProdutoId[0];
            Z32PedidoId = A32PedidoId;
            Z8ProdutoId = A8ProdutoId;
            sMode8 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load068( ) ;
            Gx_mode = sMode8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound8 = 0;
            InitializeNonKey068( ) ;
            sMode8 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal068( ) ;
            Gx_mode = sMode8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes068( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency068( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00062 */
            pr_default.execute(0, new Object[] {A32PedidoId, A8ProdutoId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"PedidoItem"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z38PedidoItemQtd != T00062_A38PedidoItemQtd[0] ) )
            {
               if ( Z38PedidoItemQtd != T00062_A38PedidoItemQtd[0] )
               {
                  GXUtil.WriteLog("pedido:[seudo value changed for attri]"+"PedidoItemQtd");
                  GXUtil.WriteLogRaw("Old: ",Z38PedidoItemQtd);
                  GXUtil.WriteLogRaw("Current: ",T00062_A38PedidoItemQtd[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"PedidoItem"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert068( )
      {
         BeforeValidate068( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable068( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM068( 0) ;
            CheckOptimisticConcurrency068( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm068( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert068( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000631 */
                     pr_default.execute(23, new Object[] {A32PedidoId, A38PedidoItemQtd, A8ProdutoId});
                     pr_default.close(23);
                     dsDefault.SmartCacheProvider.SetUpdated("PedidoItem") ;
                     if ( (pr_default.getStatus(23) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
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
               Load068( ) ;
            }
            EndLevel068( ) ;
         }
         CloseExtendedTableCursors068( ) ;
      }

      protected void Update068( )
      {
         BeforeValidate068( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable068( ) ;
         }
         if ( ( nIsMod_8 != 0 ) || ( nIsDirty_8 != 0 ) )
         {
            if ( AnyError == 0 )
            {
               CheckOptimisticConcurrency068( ) ;
               if ( AnyError == 0 )
               {
                  AfterConfirm068( ) ;
                  if ( AnyError == 0 )
                  {
                     BeforeUpdate068( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Using cursor T000632 */
                        pr_default.execute(24, new Object[] {A38PedidoItemQtd, A32PedidoId, A8ProdutoId});
                        pr_default.close(24);
                        dsDefault.SmartCacheProvider.SetUpdated("PedidoItem") ;
                        if ( (pr_default.getStatus(24) == 103) )
                        {
                           GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"PedidoItem"}), "RecordIsLocked", 1, "");
                           AnyError = 1;
                        }
                        DeferredUpdate068( ) ;
                        if ( AnyError == 0 )
                        {
                           /* Start of After( update) rules */
                           /* End of After( update) rules */
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey068( ) ;
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
               EndLevel068( ) ;
            }
         }
         CloseExtendedTableCursors068( ) ;
      }

      protected void DeferredUpdate068( )
      {
      }

      protected void Delete068( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         BeforeValidate068( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency068( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls068( ) ;
            AfterConfirm068( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete068( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000633 */
                  pr_default.execute(25, new Object[] {A32PedidoId, A8ProdutoId});
                  pr_default.close(25);
                  dsDefault.SmartCacheProvider.SetUpdated("PedidoItem") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode8 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel068( ) ;
         Gx_mode = sMode8;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls068( )
      {
         standaloneModal068( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000634 */
            pr_default.execute(26, new Object[] {A8ProdutoId});
            A9ProdutoNome = T000634_A9ProdutoNome[0];
            A11ProdutoValor = T000634_A11ProdutoValor[0];
            pr_default.close(26);
         }
      }

      protected void EndLevel068( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart068( )
      {
         /* Scan By routine */
         /* Using cursor T000635 */
         pr_default.execute(27, new Object[] {A32PedidoId});
         RcdFound8 = 0;
         if ( (pr_default.getStatus(27) != 101) )
         {
            RcdFound8 = 1;
            A8ProdutoId = T000635_A8ProdutoId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext068( )
      {
         /* Scan next routine */
         pr_default.readNext(27);
         RcdFound8 = 0;
         if ( (pr_default.getStatus(27) != 101) )
         {
            RcdFound8 = 1;
            A8ProdutoId = T000635_A8ProdutoId[0];
         }
      }

      protected void ScanEnd068( )
      {
         pr_default.close(27);
      }

      protected void AfterConfirm068( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert068( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate068( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete068( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete068( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate068( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes068( )
      {
         edtProdutoId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProdutoId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProdutoId_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
         edtProdutoNome_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProdutoNome_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProdutoNome_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
         edtProdutoValor_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProdutoValor_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProdutoValor_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
         edtPedidoItemQtd_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedidoItemQtd_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedidoItemQtd_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
      }

      protected void send_integrity_lvl_hashes068( )
      {
      }

      protected void send_integrity_lvl_hashes067( )
      {
      }

      protected void SubsflControlProps_638( )
      {
         edtProdutoId_Internalname = "PRODUTOID_"+sGXsfl_63_idx;
         imgprompt_8_Internalname = "PROMPT_8_"+sGXsfl_63_idx;
         edtProdutoNome_Internalname = "PRODUTONOME_"+sGXsfl_63_idx;
         edtProdutoValor_Internalname = "PRODUTOVALOR_"+sGXsfl_63_idx;
         edtPedidoItemQtd_Internalname = "PEDIDOITEMQTD_"+sGXsfl_63_idx;
      }

      protected void SubsflControlProps_fel_638( )
      {
         edtProdutoId_Internalname = "PRODUTOID_"+sGXsfl_63_fel_idx;
         imgprompt_8_Internalname = "PROMPT_8_"+sGXsfl_63_fel_idx;
         edtProdutoNome_Internalname = "PRODUTONOME_"+sGXsfl_63_fel_idx;
         edtProdutoValor_Internalname = "PRODUTOVALOR_"+sGXsfl_63_fel_idx;
         edtPedidoItemQtd_Internalname = "PEDIDOITEMQTD_"+sGXsfl_63_fel_idx;
      }

      protected void AddRow068( )
      {
         nGXsfl_63_idx = (short)(nGXsfl_63_idx+1);
         sGXsfl_63_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_63_idx), 4, 0)), 4, "0");
         SubsflControlProps_638( ) ;
         SendRow068( ) ;
      }

      protected void SendRow068( )
      {
         Gridlevel_itemRow = GXWebRow.GetNew(context);
         if ( subGridlevel_item_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridlevel_item_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridlevel_item_Class, "") != 0 )
            {
               subGridlevel_item_Linesclass = subGridlevel_item_Class+"Odd";
            }
         }
         else if ( subGridlevel_item_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridlevel_item_Backstyle = 0;
            subGridlevel_item_Backcolor = subGridlevel_item_Allbackcolor;
            if ( StringUtil.StrCmp(subGridlevel_item_Class, "") != 0 )
            {
               subGridlevel_item_Linesclass = subGridlevel_item_Class+"Uniform";
            }
         }
         else if ( subGridlevel_item_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridlevel_item_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridlevel_item_Class, "") != 0 )
            {
               subGridlevel_item_Linesclass = subGridlevel_item_Class+"Odd";
            }
            subGridlevel_item_Backcolor = (int)(0x0);
         }
         else if ( subGridlevel_item_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridlevel_item_Backstyle = 1;
            if ( ((int)(((nGXsfl_63_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGridlevel_item_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridlevel_item_Class, "") != 0 )
               {
                  subGridlevel_item_Linesclass = subGridlevel_item_Class+"Odd";
               }
            }
            else
            {
               subGridlevel_item_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridlevel_item_Class, "") != 0 )
               {
                  subGridlevel_item_Linesclass = subGridlevel_item_Class+"Even";
               }
            }
         }
         imgprompt_8_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"produtoprompt.aspx"+"',["+"{Ctrl:gx.dom.el('"+"PRODUTOID_"+sGXsfl_63_idx+"'), id:'"+"PRODUTOID_"+sGXsfl_63_idx+"'"+",IOType:'inout'}"+","+"{Ctrl:gx.dom.el('"+"PRODUTONOME_"+sGXsfl_63_idx+"'), id:'"+"PRODUTONOME_"+sGXsfl_63_idx+"'"+",IOType:'inout'}"+"],"+"gx.dom.form()."+"nIsMod_8_"+sGXsfl_63_idx+","+"'', false"+","+"false"+");");
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_8_" + sGXsfl_63_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 64,'',false,'" + sGXsfl_63_idx + "',63)\"";
         ROClassString = "Attribute";
         Gridlevel_itemRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtProdutoId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A8ProdutoId), 4, 0, ",", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A8ProdutoId), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtProdutoId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"TrnColumn",(String)"",(short)-1,(int)edtProdutoId_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)63,(short)1,(short)-1,(short)0,(bool)true,(String)"Serial",(String)"right",(bool)false});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         Gridlevel_itemRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_8_Internalname,(String)sImgUrl,(String)imgprompt_8_Link,(String)"",(String)"",context.GetTheme( ),(int)imgprompt_8_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)false,(bool)false,context.GetImageSrcSet( sImgUrl)});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridlevel_itemRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtProdutoNome_Internalname,(String)A9ProdutoNome,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtProdutoNome_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"TrnColumn",(String)"",(short)-1,(int)edtProdutoNome_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)63,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         Gridlevel_itemRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtProdutoValor_Internalname,StringUtil.LTrim( StringUtil.NToC( A11ProdutoValor, 12, 2, ",", "")),((edtProdutoValor_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A11ProdutoValor, "R$ ZZ,ZZ9.99")) : context.localUtil.Format( A11ProdutoValor, "R$ ZZ,ZZ9.99")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtProdutoValor_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"TrnColumn",(String)"",(short)-1,(int)edtProdutoValor_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)12,(short)0,(short)0,(short)63,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_8_" + sGXsfl_63_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 67,'',false,'" + sGXsfl_63_idx + "',63)\"";
         ROClassString = "Attribute";
         Gridlevel_itemRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPedidoItemQtd_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A38PedidoItemQtd), 4, 0, ",", "")),((edtPedidoItemQtd_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A38PedidoItemQtd), "ZZZ9")) : context.localUtil.Format( (decimal)(A38PedidoItemQtd), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,67);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPedidoItemQtd_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"TrnColumn",(String)"",(short)-1,(int)edtPedidoItemQtd_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)63,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         context.httpAjaxContext.ajax_sending_grid_row(Gridlevel_itemRow);
         send_integrity_lvl_hashes068( ) ;
         GXCCtl = "Z8ProdutoId_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z8ProdutoId), 4, 0, ",", "")));
         GXCCtl = "Z38PedidoItemQtd_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z38PedidoItemQtd), 4, 0, ",", "")));
         GXCCtl = "nRcdDeleted_8_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_8), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_8_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_8), 4, 0, ",", "")));
         GXCCtl = "nIsMod_8_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_8), 4, 0, ",", "")));
         GXCCtl = "vMODE_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GXCCtl = "vTRNCONTEXT_" + sGXsfl_63_idx;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, GXCCtl, AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(GXCCtl, AV9TrnContext);
         }
         GXCCtl = "vPEDIDOID_" + sGXsfl_63_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7PedidoId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "PRODUTOID_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProdutoId_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PRODUTONOME_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProdutoNome_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PRODUTOVALOR_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProdutoValor_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PEDIDOITEMQTD_"+sGXsfl_63_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPedidoItemQtd_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROMPT_8_"+sGXsfl_63_idx+"Link", StringUtil.RTrim( imgprompt_8_Link));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridlevel_itemContainer.AddRow(Gridlevel_itemRow);
      }

      protected void ReadRow068( )
      {
         nGXsfl_63_idx = (short)(nGXsfl_63_idx+1);
         sGXsfl_63_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_63_idx), 4, 0)), 4, "0");
         SubsflControlProps_638( ) ;
         edtProdutoId_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRODUTOID_"+sGXsfl_63_idx+"Enabled"), ",", "."));
         edtProdutoNome_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRODUTONOME_"+sGXsfl_63_idx+"Enabled"), ",", "."));
         edtProdutoValor_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRODUTOVALOR_"+sGXsfl_63_idx+"Enabled"), ",", "."));
         edtPedidoItemQtd_Enabled = (int)(context.localUtil.CToN( cgiGet( "PEDIDOITEMQTD_"+sGXsfl_63_idx+"Enabled"), ",", "."));
         imgprompt_1_Link = cgiGet( "PROMPT_8_"+sGXsfl_63_idx+"Link");
         if ( ( ( context.localUtil.CToN( cgiGet( edtProdutoId_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtProdutoId_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "PRODUTOID_" + sGXsfl_63_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtProdutoId_Internalname;
            wbErr = true;
            A8ProdutoId = 0;
         }
         else
         {
            A8ProdutoId = (short)(context.localUtil.CToN( cgiGet( edtProdutoId_Internalname), ",", "."));
         }
         A9ProdutoNome = cgiGet( edtProdutoNome_Internalname);
         A11ProdutoValor = context.localUtil.CToN( cgiGet( edtProdutoValor_Internalname), ",", ".");
         if ( ( ( context.localUtil.CToN( cgiGet( edtPedidoItemQtd_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtPedidoItemQtd_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "PEDIDOITEMQTD_" + sGXsfl_63_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtPedidoItemQtd_Internalname;
            wbErr = true;
            A38PedidoItemQtd = 0;
         }
         else
         {
            A38PedidoItemQtd = (short)(context.localUtil.CToN( cgiGet( edtPedidoItemQtd_Internalname), ",", "."));
         }
         GXCCtl = "Z8ProdutoId_" + sGXsfl_63_idx;
         Z8ProdutoId = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z38PedidoItemQtd_" + sGXsfl_63_idx;
         Z38PedidoItemQtd = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdDeleted_8_" + sGXsfl_63_idx;
         nRcdDeleted_8 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdExists_8_" + sGXsfl_63_idx;
         nRcdExists_8 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nIsMod_8_" + sGXsfl_63_idx;
         nIsMod_8 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
      }

      protected void assign_properties_default( )
      {
         defedtProdutoId_Enabled = edtProdutoId_Enabled;
      }

      protected void ConfirmValues060( )
      {
         nGXsfl_63_idx = 0;
         sGXsfl_63_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_63_idx), 4, 0)), 4, "0");
         SubsflControlProps_638( ) ;
         while ( nGXsfl_63_idx < nRC_GXsfl_63 )
         {
            nGXsfl_63_idx = (short)(nGXsfl_63_idx+1);
            sGXsfl_63_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_63_idx), 4, 0)), 4, "0");
            SubsflControlProps_638( ) ;
            ChangePostValue( "Z8ProdutoId_"+sGXsfl_63_idx, cgiGet( "ZT_"+"Z8ProdutoId_"+sGXsfl_63_idx)) ;
            DeletePostValue( "ZT_"+"Z8ProdutoId_"+sGXsfl_63_idx) ;
            ChangePostValue( "Z38PedidoItemQtd_"+sGXsfl_63_idx, cgiGet( "ZT_"+"Z38PedidoItemQtd_"+sGXsfl_63_idx)) ;
            DeletePostValue( "ZT_"+"Z38PedidoItemQtd_"+sGXsfl_63_idx) ;
         }
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
         context.AddJavascriptSource("gxcfg.js", "?20197121759363", false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("pedido.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7PedidoId)+"\">") ;
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
         forbiddenHiddens = "hsh" + "Pedido";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A32PedidoId), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("pedido:[SendSecurityCheck value for]"+"PedidoId:"+context.localUtil.Format( (decimal)(A32PedidoId), "ZZZ9"));
         GXUtil.WriteLog("pedido:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z32PedidoId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z32PedidoId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z34PedidoStatus", Z34PedidoStatus);
         GxWebStd.gx_hidden_field( context, "Z39PedidoDescontoFrete", StringUtil.LTrim( StringUtil.NToC( Z39PedidoDescontoFrete, 12, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z37PedidoTotal", StringUtil.LTrim( StringUtil.NToC( Z37PedidoTotal, 12, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z33PedidoDt", context.localUtil.DToC( Z33PedidoDt, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z35PedidoDtEntrega", context.localUtil.DToC( Z35PedidoDtEntrega, 0, "/"));
         GxWebStd.gx_boolean_hidden_field( context, "Z36PedidoRetirada", Z36PedidoRetirada);
         GxWebStd.gx_hidden_field( context, "Z1PessoaId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1PessoaId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_63", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_63_idx), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "N1PessoaId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1PessoaId), 4, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV9TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vPEDIDOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7PedidoId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vPEDIDOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7PedidoId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_PESSOAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11Insert_PessoaId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "PEDIDOTOTALFML", StringUtil.LTrim( StringUtil.NToC( A40PedidoTotalFML, 12, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPEDIDODESCONTOFRETE", StringUtil.LTrim( StringUtil.NToC( AV17PedidoDescontoFrete, 12, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV18Pgmname));
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
         return formatLink("pedido.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7PedidoId) ;
      }

      public override String GetPgmname( )
      {
         return "Pedido" ;
      }

      public override String GetPgmdesc( )
      {
         return "Pedido" ;
      }

      protected void InitializeNonKey067( )
      {
         A1PessoaId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1PessoaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1PessoaId), 4, 0)));
         A34PedidoStatus = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34PedidoStatus", A34PedidoStatus);
         A39PedidoDescontoFrete = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39PedidoDescontoFrete", StringUtil.LTrim( StringUtil.Str( A39PedidoDescontoFrete, 12, 2)));
         AV17PedidoDescontoFrete = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17PedidoDescontoFrete", StringUtil.LTrim( StringUtil.Str( AV17PedidoDescontoFrete, 12, 2)));
         A37PedidoTotal = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PedidoTotal", StringUtil.LTrim( StringUtil.Str( A37PedidoTotal, 12, 2)));
         A2PessoaNome = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2PessoaNome", A2PessoaNome);
         A33PedidoDt = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33PedidoDt", context.localUtil.Format(A33PedidoDt, "99/99/99"));
         A35PedidoDtEntrega = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35PedidoDtEntrega", context.localUtil.Format(A35PedidoDtEntrega, "99/99/99"));
         A36PedidoRetirada = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36PedidoRetirada", A36PedidoRetirada);
         A40PedidoTotalFML = 0;
         n40PedidoTotalFML = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40PedidoTotalFML", StringUtil.LTrim( StringUtil.Str( A40PedidoTotalFML, 12, 2)));
         Z34PedidoStatus = "";
         Z39PedidoDescontoFrete = 0;
         Z37PedidoTotal = 0;
         Z33PedidoDt = DateTime.MinValue;
         Z35PedidoDtEntrega = DateTime.MinValue;
         Z36PedidoRetirada = false;
         Z1PessoaId = 0;
      }

      protected void InitAll067( )
      {
         A32PedidoId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32PedidoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A32PedidoId), 4, 0)));
         InitializeNonKey067( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey068( )
      {
         A9ProdutoNome = "";
         A11ProdutoValor = 0;
         A38PedidoItemQtd = 0;
         Z38PedidoItemQtd = 0;
      }

      protected void InitAll068( )
      {
         A8ProdutoId = 0;
         InitializeNonKey068( ) ;
      }

      protected void StandaloneModalInsert068( )
      {
         A39PedidoDescontoFrete = i39PedidoDescontoFrete;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39PedidoDescontoFrete", StringUtil.LTrim( StringUtil.Str( A39PedidoDescontoFrete, 12, 2)));
         A37PedidoTotal = i37PedidoTotal;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37PedidoTotal", StringUtil.LTrim( StringUtil.Str( A37PedidoTotal, 12, 2)));
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201971217593624", true, true);
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
         context.AddJavascriptSource("gxdec.js", "?"+context.GetBuildNumber( 131213), false, true);
         context.AddJavascriptSource("pedido.js", "?201971217593624", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false, true);
         /* End function include_jscripts */
      }

      protected void init_level_properties8( )
      {
         edtProdutoId_Enabled = defedtProdutoId_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProdutoId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProdutoId_Enabled), 5, 0)), !bGXsfl_63_Refreshing);
      }

      protected void init_default_properties( )
      {
         edtPedidoId_Internalname = "PEDIDOID";
         edtPessoaId_Internalname = "PESSOAID";
         edtPessoaNome_Internalname = "PESSOANOME";
         tblGp_pessoa_Internalname = "GP_PESSOA";
         grpUnnamedgroup1_Internalname = "UNNAMEDGROUP1";
         edtPedidoDt_Internalname = "PEDIDODT";
         edtPedidoDtEntrega_Internalname = "PEDIDODTENTREGA";
         tblGp_prazo_Internalname = "GP_PRAZO";
         grpUnnamedgroup2_Internalname = "UNNAMEDGROUP2";
         cmbPedidoStatus_Internalname = "PEDIDOSTATUS";
         chkPedidoRetirada_Internalname = "PEDIDORETIRADA";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         edtProdutoId_Internalname = "PRODUTOID";
         edtProdutoNome_Internalname = "PRODUTONOME";
         edtProdutoValor_Internalname = "PRODUTOVALOR";
         edtPedidoItemQtd_Internalname = "PEDIDOITEMQTD";
         divTableleaflevel_item_Internalname = "TABLELEAFLEVEL_ITEM";
         lblTextblockpedidodescontofrete_Internalname = "TEXTBLOCKPEDIDODESCONTOFRETE";
         edtPedidoDescontoFrete_Internalname = "PEDIDODESCONTOFRETE";
         divUnnamedtablepedidodescontofrete_Internalname = "UNNAMEDTABLEPEDIDODESCONTOFRETE";
         lblTextblockpedidototal_Internalname = "TEXTBLOCKPEDIDOTOTAL";
         edtPedidoTotal_Internalname = "PEDIDOTOTAL";
         divUnnamedtablepedidototal_Internalname = "UNNAMEDTABLEPEDIDOTOTAL";
         tblTab_Internalname = "TAB";
         divTable_Internalname = "TABLE";
         bttBtntrn_enter_Internalname = "BTNTRN_ENTER";
         bttBtntrn_cancel_Internalname = "BTNTRN_CANCEL";
         bttBtntrn_delete_Internalname = "BTNTRN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         divLayoutmaintable_Internalname = "LAYOUTMAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_1_Internalname = "PROMPT_1";
         imgprompt_8_Internalname = "PROMPT_8";
         subGridlevel_item_Internalname = "GRIDLEVEL_ITEM";
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
         Form.Caption = "Pedido";
         edtPedidoItemQtd_Jsonclick = "";
         edtProdutoValor_Jsonclick = "";
         edtProdutoNome_Jsonclick = "";
         imgprompt_8_Visible = 1;
         imgprompt_8_Link = "";
         imgprompt_1_Visible = 1;
         edtProdutoId_Jsonclick = "";
         subGridlevel_item_Class = "GridNoBorder WorkWith";
         subGridlevel_item_Backcolorstyle = 0;
         subGridlevel_item_Allowcollapsing = 0;
         subGridlevel_item_Allowselection = 0;
         edtPedidoItemQtd_Enabled = 1;
         edtProdutoValor_Enabled = 0;
         edtProdutoNome_Enabled = 0;
         edtProdutoId_Enabled = 1;
         subGridlevel_item_Header = "";
         edtPessoaNome_Jsonclick = "";
         edtPessoaNome_Enabled = 0;
         imgprompt_1_Visible = 1;
         imgprompt_1_Link = "";
         edtPessoaId_Jsonclick = "";
         edtPessoaId_Enabled = 1;
         edtPedidoDtEntrega_Jsonclick = "";
         edtPedidoDtEntrega_Enabled = 1;
         edtPedidoDt_Jsonclick = "";
         edtPedidoDt_Enabled = 1;
         edtPedidoTotal_Jsonclick = "";
         edtPedidoTotal_Enabled = 1;
         edtPedidoDescontoFrete_Jsonclick = "";
         edtPedidoDescontoFrete_Enabled = 1;
         bttBtntrn_delete_Enabled = 0;
         bttBtntrn_delete_Visible = 1;
         bttBtntrn_cancel_Visible = 1;
         bttBtntrn_enter_Enabled = 1;
         bttBtntrn_enter_Visible = 1;
         chkPedidoRetirada.Enabled = 1;
         cmbPedidoStatus_Jsonclick = "";
         cmbPedidoStatus.Enabled = 1;
         edtPedidoId_Jsonclick = "";
         edtPedidoId_Enabled = 0;
         edtPedidoId_Visible = 1;
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

      protected void GX16ASAPEDIDODESCONTOFRETE067( String Gx_mode ,
                                                    DateTime A33PedidoDt ,
                                                    decimal A40PedidoTotalFML )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            GXt_decimal1 = A39PedidoDescontoFrete;
            new prc_calculadescfrete(context ).execute(  A33PedidoDt,  A40PedidoTotalFML, out  GXt_decimal1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33PedidoDt", context.localUtil.Format(A33PedidoDt, "99/99/99"));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40PedidoTotalFML", StringUtil.LTrim( StringUtil.Str( A40PedidoTotalFML, 12, 2)));
            A39PedidoDescontoFrete = GXt_decimal1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39PedidoDescontoFrete", StringUtil.LTrim( StringUtil.Str( A39PedidoDescontoFrete, 12, 2)));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( A39PedidoDescontoFrete, 12, 2, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX24ASAPEDIDODESCONTOFRETE068( String Gx_mode ,
                                                    DateTime A33PedidoDt ,
                                                    decimal A40PedidoTotalFML )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            GXt_decimal1 = A39PedidoDescontoFrete;
            new prc_calculadescfrete(context ).execute(  A33PedidoDt,  A40PedidoTotalFML, out  GXt_decimal1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33PedidoDt", context.localUtil.Format(A33PedidoDt, "99/99/99"));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40PedidoTotalFML", StringUtil.LTrim( StringUtil.Str( A40PedidoTotalFML, 12, 2)));
            A39PedidoDescontoFrete = GXt_decimal1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39PedidoDescontoFrete", StringUtil.LTrim( StringUtil.Str( A39PedidoDescontoFrete, 12, 2)));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( A39PedidoDescontoFrete, 12, 2, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void gxnrGridlevel_item_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         SubsflControlProps_638( ) ;
         while ( nGXsfl_63_idx <= nRC_GXsfl_63 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal068( ) ;
            standaloneModal068( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow068( ) ;
            nGXsfl_63_idx = (short)(nGXsfl_63_idx+1);
            sGXsfl_63_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_63_idx), 4, 0)), 4, "0");
            SubsflControlProps_638( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Gridlevel_itemContainer));
         /* End function gxnrGridlevel_item_newrow */
      }

      protected void init_web_controls( )
      {
         cmbPedidoStatus.Name = "PEDIDOSTATUS";
         cmbPedidoStatus.WebTags = "";
         cmbPedidoStatus.addItem("AGD", "Aguardando Aprovação", 0);
         cmbPedidoStatus.addItem("APR", "Aprovado", 0);
         cmbPedidoStatus.addItem("REP", "Reprovado", 0);
         cmbPedidoStatus.addItem("ENC", "Encerrado", 0);
         if ( cmbPedidoStatus.ItemCount > 0 )
         {
            A34PedidoStatus = cmbPedidoStatus.getValidValue(A34PedidoStatus);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34PedidoStatus", A34PedidoStatus);
         }
         chkPedidoRetirada.Name = "PEDIDORETIRADA";
         chkPedidoRetirada.WebTags = "";
         chkPedidoRetirada.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkPedidoRetirada_Internalname, "TitleCaption", chkPedidoRetirada.Caption, true);
         chkPedidoRetirada.CheckedValue = "false";
         /* End function init_web_controls */
      }

      public void Valid_Pedidoid( short GX_Parm1 ,
                                  decimal GX_Parm2 )
      {
         A32PedidoId = GX_Parm1;
         A40PedidoTotalFML = GX_Parm2;
         n40PedidoTotalFML = false;
         /* Using cursor T000624 */
         pr_default.execute(16, new Object[] {A32PedidoId});
         if ( (pr_default.getStatus(16) != 101) )
         {
            A40PedidoTotalFML = T000624_A40PedidoTotalFML[0];
            n40PedidoTotalFML = T000624_n40PedidoTotalFML[0];
         }
         else
         {
            A40PedidoTotalFML = 0;
            n40PedidoTotalFML = false;
         }
         pr_default.close(16);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A40PedidoTotalFML = 0;
            n40PedidoTotalFML = false;
         }
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A40PedidoTotalFML, 12, 2, ".", "")));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Pessoaid( short GX_Parm1 ,
                                  String GX_Parm2 )
      {
         A1PessoaId = GX_Parm1;
         A2PessoaNome = GX_Parm2;
         /* Using cursor T000625 */
         pr_default.execute(17, new Object[] {A1PessoaId});
         if ( (pr_default.getStatus(17) == 101) )
         {
            GX_msglist.addItem("Não existe 'Pessoa'.", "ForeignKeyNotFound", 1, "PESSOAID");
            AnyError = 1;
            GX_FocusControl = edtPessoaId_Internalname;
         }
         A2PessoaNome = T000625_A2PessoaNome[0];
         pr_default.close(17);
         if ( (0==A1PessoaId) )
         {
            GX_msglist.addItem("Id é obrigatório.", 1, "PESSOAID");
            AnyError = 1;
            GX_FocusControl = edtPessoaId_Internalname;
         }
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A2PessoaNome = "";
         }
         isValidOutput.Add(A2PessoaNome);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Pedidodt( String GX_Parm1 ,
                                  DateTime GX_Parm2 ,
                                  decimal GX_Parm3 ,
                                  decimal GX_Parm4 )
      {
         Gx_mode = GX_Parm1;
         A33PedidoDt = GX_Parm2;
         A40PedidoTotalFML = GX_Parm3;
         n40PedidoTotalFML = false;
         A39PedidoDescontoFrete = GX_Parm4;
         if ( ! ( (DateTime.MinValue==A33PedidoDt) || ( A33PedidoDt >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Data do Pedido fora do intervalo", "OutOfRange", 1, "PEDIDODT");
            AnyError = 1;
            GX_FocusControl = edtPedidoDt_Internalname;
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            GXt_decimal1 = A39PedidoDescontoFrete;
            new prc_calculadescfrete(context ).execute(  A33PedidoDt,  A40PedidoTotalFML, out  GXt_decimal1) ;
            A39PedidoDescontoFrete = GXt_decimal1;
         }
         if ( (DateTime.MinValue==A33PedidoDt) )
         {
            GX_msglist.addItem("Data do Pedido é obrigatório.", 1, "PEDIDODT");
            AnyError = 1;
            GX_FocusControl = edtPedidoDt_Internalname;
         }
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A39PedidoDescontoFrete, 12, 2, ".", "")));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Pedidodescontofrete( String GX_Parm1 ,
                                             decimal GX_Parm2 ,
                                             decimal GX_Parm3 ,
                                             bool GX_Parm4 ,
                                             decimal GX_Parm5 ,
                                             decimal GX_Parm6 )
      {
         Gx_mode = GX_Parm1;
         A39PedidoDescontoFrete = GX_Parm2;
         A40PedidoTotalFML = GX_Parm3;
         n40PedidoTotalFML = false;
         A36PedidoRetirada = GX_Parm4;
         AV17PedidoDescontoFrete = GX_Parm5;
         A37PedidoTotal = GX_Parm6;
         AV17PedidoDescontoFrete = A39PedidoDescontoFrete;
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && A36PedidoRetirada )
         {
            A37PedidoTotal = (decimal)(A40PedidoTotalFML-A39PedidoDescontoFrete);
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && ! A36PedidoRetirada )
            {
               A37PedidoTotal = (decimal)(A40PedidoTotalFML+A39PedidoDescontoFrete);
            }
         }
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( AV17PedidoDescontoFrete, 12, 2, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A37PedidoTotal, 12, 2, ".", "")));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Produtoid( short GX_Parm1 ,
                                   String GX_Parm2 ,
                                   decimal GX_Parm3 )
      {
         A8ProdutoId = GX_Parm1;
         A9ProdutoNome = GX_Parm2;
         A11ProdutoValor = GX_Parm3;
         /* Using cursor T000634 */
         pr_default.execute(26, new Object[] {A8ProdutoId});
         if ( (pr_default.getStatus(26) == 101) )
         {
            GX_msglist.addItem("Não existe 'Produto'.", "ForeignKeyNotFound", 1, "PRODUTOID");
            AnyError = 1;
            GX_FocusControl = edtProdutoId_Internalname;
         }
         A9ProdutoNome = T000634_A9ProdutoNome[0];
         A11ProdutoValor = T000634_A11ProdutoValor[0];
         pr_default.close(26);
         if ( (0==A8ProdutoId) )
         {
            GX_msglist.addItem("Id é obrigatório.", 1, "PRODUTOID");
            AnyError = 1;
            GX_FocusControl = edtProdutoId_Internalname;
         }
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A9ProdutoNome = "";
            A11ProdutoValor = 0;
         }
         isValidOutput.Add(A9ProdutoNome);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A11ProdutoValor, 12, 2, ".", "")));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7PedidoId',fld:'vPEDIDOID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7PedidoId',fld:'vPEDIDOID',pic:'ZZZ9',hsh:true},{av:'A32PedidoId',fld:'PEDIDOID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12062',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'A32PedidoId',fld:'PEDIDOID',pic:'ZZZ9'},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         pr_default.close(26);
         pr_default.close(5);
         pr_default.close(17);
         pr_default.close(16);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z34PedidoStatus = "";
         Z33PedidoDt = DateTime.MinValue;
         Z35PedidoDtEntrega = DateTime.MinValue;
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         A33PedidoDt = DateTime.MinValue;
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         A34PedidoStatus = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         TempTags = "";
         bttBtntrn_enter_Jsonclick = "";
         bttBtntrn_cancel_Jsonclick = "";
         bttBtntrn_delete_Jsonclick = "";
         sStyleString = "";
         lblTextblockpedidodescontofrete_Jsonclick = "";
         lblTextblockpedidototal_Jsonclick = "";
         A35PedidoDtEntrega = DateTime.MinValue;
         sImgUrl = "";
         A2PessoaNome = "";
         Gridlevel_itemContainer = new GXWebGrid( context);
         Gridlevel_itemColumn = new GXWebColumn();
         A9ProdutoNome = "";
         sMode8 = "";
         AV18Pgmname = "";
         Dvpanel_tableattributes_Objectcall = "";
         Dvpanel_tableattributes_Class = "";
         Dvpanel_tableattributes_Height = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode7 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         T00067_A40PedidoTotalFML = new decimal[1] ;
         T00067_n40PedidoTotalFML = new bool[] {false} ;
         AV8WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV10WebSession = context.GetSession();
         AV12TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         Z2PessoaNome = "";
         T000610_A2PessoaNome = new String[] {""} ;
         T000611_A32PedidoId = new short[1] ;
         T000611_A34PedidoStatus = new String[] {""} ;
         T000611_A39PedidoDescontoFrete = new decimal[1] ;
         T000611_A37PedidoTotal = new decimal[1] ;
         T000611_A2PessoaNome = new String[] {""} ;
         T000611_A33PedidoDt = new DateTime[] {DateTime.MinValue} ;
         T000611_A35PedidoDtEntrega = new DateTime[] {DateTime.MinValue} ;
         T000611_A36PedidoRetirada = new bool[] {false} ;
         T000611_A1PessoaId = new short[1] ;
         T000614_A40PedidoTotalFML = new decimal[1] ;
         T000614_n40PedidoTotalFML = new bool[] {false} ;
         T000615_A2PessoaNome = new String[] {""} ;
         T000616_A32PedidoId = new short[1] ;
         T00069_A32PedidoId = new short[1] ;
         T00069_A34PedidoStatus = new String[] {""} ;
         T00069_A39PedidoDescontoFrete = new decimal[1] ;
         T00069_A37PedidoTotal = new decimal[1] ;
         T00069_A33PedidoDt = new DateTime[] {DateTime.MinValue} ;
         T00069_A35PedidoDtEntrega = new DateTime[] {DateTime.MinValue} ;
         T00069_A36PedidoRetirada = new bool[] {false} ;
         T00069_A1PessoaId = new short[1] ;
         T000617_A32PedidoId = new short[1] ;
         T000618_A32PedidoId = new short[1] ;
         T00068_A32PedidoId = new short[1] ;
         T00068_A34PedidoStatus = new String[] {""} ;
         T00068_A39PedidoDescontoFrete = new decimal[1] ;
         T00068_A37PedidoTotal = new decimal[1] ;
         T00068_A33PedidoDt = new DateTime[] {DateTime.MinValue} ;
         T00068_A35PedidoDtEntrega = new DateTime[] {DateTime.MinValue} ;
         T00068_A36PedidoRetirada = new bool[] {false} ;
         T00068_A1PessoaId = new short[1] ;
         T000619_A32PedidoId = new short[1] ;
         T000624_A40PedidoTotalFML = new decimal[1] ;
         T000624_n40PedidoTotalFML = new bool[] {false} ;
         T000625_A2PessoaNome = new String[] {""} ;
         T000627_A32PedidoId = new short[1] ;
         Z9ProdutoNome = "";
         T000628_A32PedidoId = new short[1] ;
         T000628_A9ProdutoNome = new String[] {""} ;
         T000628_A11ProdutoValor = new decimal[1] ;
         T000628_A38PedidoItemQtd = new short[1] ;
         T000628_A8ProdutoId = new short[1] ;
         T00064_A9ProdutoNome = new String[] {""} ;
         T00064_A11ProdutoValor = new decimal[1] ;
         T000629_A9ProdutoNome = new String[] {""} ;
         T000629_A11ProdutoValor = new decimal[1] ;
         T000630_A32PedidoId = new short[1] ;
         T000630_A8ProdutoId = new short[1] ;
         T00063_A32PedidoId = new short[1] ;
         T00063_A38PedidoItemQtd = new short[1] ;
         T00063_A8ProdutoId = new short[1] ;
         T00062_A32PedidoId = new short[1] ;
         T00062_A38PedidoItemQtd = new short[1] ;
         T00062_A8ProdutoId = new short[1] ;
         T000634_A9ProdutoNome = new String[] {""} ;
         T000634_A11ProdutoValor = new decimal[1] ;
         T000635_A32PedidoId = new short[1] ;
         T000635_A8ProdutoId = new short[1] ;
         Gridlevel_itemRow = new GXWebRow();
         subGridlevel_item_Linesclass = "";
         ROClassString = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pedido__default(),
            new Object[][] {
                new Object[] {
               T00062_A32PedidoId, T00062_A38PedidoItemQtd, T00062_A8ProdutoId
               }
               , new Object[] {
               T00063_A32PedidoId, T00063_A38PedidoItemQtd, T00063_A8ProdutoId
               }
               , new Object[] {
               T00064_A9ProdutoNome, T00064_A11ProdutoValor
               }
               , new Object[] {
               T00067_A40PedidoTotalFML, T00067_n40PedidoTotalFML
               }
               , new Object[] {
               T00068_A32PedidoId, T00068_A34PedidoStatus, T00068_A39PedidoDescontoFrete, T00068_A37PedidoTotal, T00068_A33PedidoDt, T00068_A35PedidoDtEntrega, T00068_A36PedidoRetirada, T00068_A1PessoaId
               }
               , new Object[] {
               T00069_A32PedidoId, T00069_A34PedidoStatus, T00069_A39PedidoDescontoFrete, T00069_A37PedidoTotal, T00069_A33PedidoDt, T00069_A35PedidoDtEntrega, T00069_A36PedidoRetirada, T00069_A1PessoaId
               }
               , new Object[] {
               T000610_A2PessoaNome
               }
               , new Object[] {
               T000611_A32PedidoId, T000611_A34PedidoStatus, T000611_A39PedidoDescontoFrete, T000611_A37PedidoTotal, T000611_A2PessoaNome, T000611_A33PedidoDt, T000611_A35PedidoDtEntrega, T000611_A36PedidoRetirada, T000611_A1PessoaId
               }
               , new Object[] {
               T000614_A40PedidoTotalFML, T000614_n40PedidoTotalFML
               }
               , new Object[] {
               T000615_A2PessoaNome
               }
               , new Object[] {
               T000616_A32PedidoId
               }
               , new Object[] {
               T000617_A32PedidoId
               }
               , new Object[] {
               T000618_A32PedidoId
               }
               , new Object[] {
               T000619_A32PedidoId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000624_A40PedidoTotalFML, T000624_n40PedidoTotalFML
               }
               , new Object[] {
               T000625_A2PessoaNome
               }
               , new Object[] {
               }
               , new Object[] {
               T000627_A32PedidoId
               }
               , new Object[] {
               T000628_A32PedidoId, T000628_A9ProdutoNome, T000628_A11ProdutoValor, T000628_A38PedidoItemQtd, T000628_A8ProdutoId
               }
               , new Object[] {
               T000629_A9ProdutoNome, T000629_A11ProdutoValor
               }
               , new Object[] {
               T000630_A32PedidoId, T000630_A8ProdutoId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000634_A9ProdutoNome, T000634_A11ProdutoValor
               }
               , new Object[] {
               T000635_A32PedidoId, T000635_A8ProdutoId
               }
            }
         );
         AV18Pgmname = "Pedido";
      }

      private short nIsMod_8 ;
      private short wcpOAV7PedidoId ;
      private short Z32PedidoId ;
      private short Z1PessoaId ;
      private short nRC_GXsfl_63 ;
      private short nGXsfl_63_idx=1 ;
      private short N1PessoaId ;
      private short Z8ProdutoId ;
      private short Z38PedidoItemQtd ;
      private short nRcdDeleted_8 ;
      private short nRcdExists_8 ;
      private short GxWebError ;
      private short A32PedidoId ;
      private short A1PessoaId ;
      private short A8ProdutoId ;
      private short AV7PedidoId ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short subGridlevel_item_Backcolorstyle ;
      private short A38PedidoItemQtd ;
      private short subGridlevel_item_Allowselection ;
      private short subGridlevel_item_Allowhovering ;
      private short subGridlevel_item_Allowcollapsing ;
      private short subGridlevel_item_Collapsed ;
      private short nBlankRcdCount8 ;
      private short RcdFound8 ;
      private short nBlankRcdUsr8 ;
      private short AV11Insert_PessoaId ;
      private short RcdFound7 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short nIsDirty_7 ;
      private short nIsDirty_8 ;
      private short subGridlevel_item_Backstyle ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int edtPedidoId_Visible ;
      private int edtPedidoId_Enabled ;
      private int bttBtntrn_enter_Visible ;
      private int bttBtntrn_enter_Enabled ;
      private int bttBtntrn_cancel_Visible ;
      private int bttBtntrn_delete_Visible ;
      private int bttBtntrn_delete_Enabled ;
      private int edtPedidoDescontoFrete_Enabled ;
      private int edtPedidoTotal_Enabled ;
      private int edtPedidoDt_Enabled ;
      private int edtPedidoDtEntrega_Enabled ;
      private int edtPessoaId_Enabled ;
      private int imgprompt_1_Visible ;
      private int edtPessoaNome_Enabled ;
      private int edtProdutoId_Enabled ;
      private int edtProdutoNome_Enabled ;
      private int edtProdutoValor_Enabled ;
      private int edtPedidoItemQtd_Enabled ;
      private int subGridlevel_item_Selectedindex ;
      private int subGridlevel_item_Selectioncolor ;
      private int subGridlevel_item_Hoveringcolor ;
      private int fRowAdded ;
      private int Dvpanel_tableattributes_Gxcontroltype ;
      private int AV19GXV1 ;
      private int subGridlevel_item_Backcolor ;
      private int subGridlevel_item_Allbackcolor ;
      private int imgprompt_8_Visible ;
      private int defedtProdutoId_Enabled ;
      private int idxLst ;
      private long GRIDLEVEL_ITEM_nFirstRecordOnPage ;
      private decimal Z39PedidoDescontoFrete ;
      private decimal Z37PedidoTotal ;
      private decimal A40PedidoTotalFML ;
      private decimal A39PedidoDescontoFrete ;
      private decimal A37PedidoTotal ;
      private decimal A11ProdutoValor ;
      private decimal AV17PedidoDescontoFrete ;
      private decimal sV17PedidoDescontoFrete ;
      private decimal OV17PedidoDescontoFrete ;
      private decimal Z11ProdutoValor ;
      private decimal i39PedidoDescontoFrete ;
      private decimal i37PedidoTotal ;
      private decimal GXt_decimal1 ;
      private String sPrefix ;
      private String sGXsfl_63_idx="0001" ;
      private String wcpOGx_mode ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtPessoaId_Internalname ;
      private String cmbPedidoStatus_Internalname ;
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
      private String edtPedidoId_Internalname ;
      private String edtPedidoId_Jsonclick ;
      private String grpUnnamedgroup1_Internalname ;
      private String grpUnnamedgroup2_Internalname ;
      private String TempTags ;
      private String cmbPedidoStatus_Jsonclick ;
      private String chkPedidoRetirada_Internalname ;
      private String divTableleaflevel_item_Internalname ;
      private String divTable_Internalname ;
      private String bttBtntrn_enter_Internalname ;
      private String bttBtntrn_enter_Jsonclick ;
      private String bttBtntrn_cancel_Internalname ;
      private String bttBtntrn_cancel_Jsonclick ;
      private String bttBtntrn_delete_Internalname ;
      private String bttBtntrn_delete_Jsonclick ;
      private String sStyleString ;
      private String tblTab_Internalname ;
      private String divUnnamedtablepedidodescontofrete_Internalname ;
      private String lblTextblockpedidodescontofrete_Internalname ;
      private String lblTextblockpedidodescontofrete_Jsonclick ;
      private String edtPedidoDescontoFrete_Internalname ;
      private String edtPedidoDescontoFrete_Jsonclick ;
      private String divUnnamedtablepedidototal_Internalname ;
      private String lblTextblockpedidototal_Internalname ;
      private String lblTextblockpedidototal_Jsonclick ;
      private String edtPedidoTotal_Internalname ;
      private String edtPedidoTotal_Jsonclick ;
      private String tblGp_prazo_Internalname ;
      private String edtPedidoDt_Internalname ;
      private String edtPedidoDt_Jsonclick ;
      private String edtPedidoDtEntrega_Internalname ;
      private String edtPedidoDtEntrega_Jsonclick ;
      private String tblGp_pessoa_Internalname ;
      private String edtPessoaId_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_1_Internalname ;
      private String imgprompt_1_Link ;
      private String edtPessoaNome_Internalname ;
      private String edtPessoaNome_Jsonclick ;
      private String subGridlevel_item_Header ;
      private String sMode8 ;
      private String edtProdutoId_Internalname ;
      private String edtProdutoNome_Internalname ;
      private String edtProdutoValor_Internalname ;
      private String edtPedidoItemQtd_Internalname ;
      private String AV18Pgmname ;
      private String Dvpanel_tableattributes_Objectcall ;
      private String Dvpanel_tableattributes_Class ;
      private String Dvpanel_tableattributes_Height ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode7 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXCCtl ;
      private String imgprompt_8_Internalname ;
      private String sGXsfl_63_fel_idx="0001" ;
      private String subGridlevel_item_Class ;
      private String subGridlevel_item_Linesclass ;
      private String imgprompt_8_Link ;
      private String ROClassString ;
      private String edtProdutoId_Jsonclick ;
      private String edtProdutoNome_Jsonclick ;
      private String edtProdutoValor_Jsonclick ;
      private String edtPedidoItemQtd_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String subGridlevel_item_Internalname ;
      private DateTime Z33PedidoDt ;
      private DateTime Z35PedidoDtEntrega ;
      private DateTime A33PedidoDt ;
      private DateTime A35PedidoDtEntrega ;
      private bool Z36PedidoRetirada ;
      private bool entryPointCalled ;
      private bool n40PedidoTotalFML ;
      private bool A36PedidoRetirada ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool bGXsfl_63_Refreshing=false ;
      private bool Dvpanel_tableattributes_Enabled ;
      private bool Dvpanel_tableattributes_Showheader ;
      private bool Dvpanel_tableattributes_Visible ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private String Z34PedidoStatus ;
      private String A34PedidoStatus ;
      private String A2PessoaNome ;
      private String A9ProdutoNome ;
      private String Z2PessoaNome ;
      private String Z9ProdutoNome ;
      private IGxSession AV10WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebGrid Gridlevel_itemContainer ;
      private GXWebRow Gridlevel_itemRow ;
      private GXWebColumn Gridlevel_itemColumn ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbPedidoStatus ;
      private GXCheckbox chkPedidoRetirada ;
      private IDataStoreProvider pr_default ;
      private decimal[] T00067_A40PedidoTotalFML ;
      private bool[] T00067_n40PedidoTotalFML ;
      private String[] T000610_A2PessoaNome ;
      private short[] T000611_A32PedidoId ;
      private String[] T000611_A34PedidoStatus ;
      private decimal[] T000611_A39PedidoDescontoFrete ;
      private decimal[] T000611_A37PedidoTotal ;
      private String[] T000611_A2PessoaNome ;
      private DateTime[] T000611_A33PedidoDt ;
      private DateTime[] T000611_A35PedidoDtEntrega ;
      private bool[] T000611_A36PedidoRetirada ;
      private short[] T000611_A1PessoaId ;
      private decimal[] T000614_A40PedidoTotalFML ;
      private bool[] T000614_n40PedidoTotalFML ;
      private String[] T000615_A2PessoaNome ;
      private short[] T000616_A32PedidoId ;
      private short[] T00069_A32PedidoId ;
      private String[] T00069_A34PedidoStatus ;
      private decimal[] T00069_A39PedidoDescontoFrete ;
      private decimal[] T00069_A37PedidoTotal ;
      private DateTime[] T00069_A33PedidoDt ;
      private DateTime[] T00069_A35PedidoDtEntrega ;
      private bool[] T00069_A36PedidoRetirada ;
      private short[] T00069_A1PessoaId ;
      private short[] T000617_A32PedidoId ;
      private short[] T000618_A32PedidoId ;
      private short[] T00068_A32PedidoId ;
      private String[] T00068_A34PedidoStatus ;
      private decimal[] T00068_A39PedidoDescontoFrete ;
      private decimal[] T00068_A37PedidoTotal ;
      private DateTime[] T00068_A33PedidoDt ;
      private DateTime[] T00068_A35PedidoDtEntrega ;
      private bool[] T00068_A36PedidoRetirada ;
      private short[] T00068_A1PessoaId ;
      private short[] T000619_A32PedidoId ;
      private decimal[] T000624_A40PedidoTotalFML ;
      private bool[] T000624_n40PedidoTotalFML ;
      private String[] T000625_A2PessoaNome ;
      private short[] T000627_A32PedidoId ;
      private short[] T000628_A32PedidoId ;
      private String[] T000628_A9ProdutoNome ;
      private decimal[] T000628_A11ProdutoValor ;
      private short[] T000628_A38PedidoItemQtd ;
      private short[] T000628_A8ProdutoId ;
      private String[] T00064_A9ProdutoNome ;
      private decimal[] T00064_A11ProdutoValor ;
      private String[] T000629_A9ProdutoNome ;
      private decimal[] T000629_A11ProdutoValor ;
      private short[] T000630_A32PedidoId ;
      private short[] T000630_A8ProdutoId ;
      private short[] T00063_A32PedidoId ;
      private short[] T00063_A38PedidoItemQtd ;
      private short[] T00063_A8ProdutoId ;
      private short[] T00062_A32PedidoId ;
      private short[] T00062_A38PedidoItemQtd ;
      private short[] T00062_A8ProdutoId ;
      private String[] T000634_A9ProdutoNome ;
      private decimal[] T000634_A11ProdutoValor ;
      private short[] T000635_A32PedidoId ;
      private short[] T000635_A8ProdutoId ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV12TrnContextAtt ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
   }

   public class pedido__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new UpdateCursor(def[14])
         ,new UpdateCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new UpdateCursor(def[18])
         ,new ForEachCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
         ,new ForEachCursor(def[22])
         ,new UpdateCursor(def[23])
         ,new UpdateCursor(def[24])
         ,new UpdateCursor(def[25])
         ,new ForEachCursor(def[26])
         ,new ForEachCursor(def[27])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000611 ;
          prmT000611 = new Object[] {
          new Object[] {"@PedidoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00067 ;
          prmT00067 = new Object[] {
          new Object[] {"@PedidoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000610 ;
          prmT000610 = new Object[] {
          new Object[] {"@PessoaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000614 ;
          prmT000614 = new Object[] {
          new Object[] {"@PedidoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000615 ;
          prmT000615 = new Object[] {
          new Object[] {"@PessoaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000616 ;
          prmT000616 = new Object[] {
          new Object[] {"@PedidoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00069 ;
          prmT00069 = new Object[] {
          new Object[] {"@PedidoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000617 ;
          prmT000617 = new Object[] {
          new Object[] {"@PedidoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000618 ;
          prmT000618 = new Object[] {
          new Object[] {"@PedidoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00068 ;
          prmT00068 = new Object[] {
          new Object[] {"@PedidoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000619 ;
          prmT000619 = new Object[] {
          new Object[] {"@PedidoStatus",SqlDbType.VarChar,3,0} ,
          new Object[] {"@PedidoDescontoFrete",SqlDbType.Decimal,12,2} ,
          new Object[] {"@PedidoTotal",SqlDbType.Decimal,12,2} ,
          new Object[] {"@PedidoDt",SqlDbType.DateTime,8,0} ,
          new Object[] {"@PedidoDtEntrega",SqlDbType.DateTime,8,0} ,
          new Object[] {"@PedidoRetirada",SqlDbType.Bit,4,0} ,
          new Object[] {"@PessoaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000620 ;
          prmT000620 = new Object[] {
          new Object[] {"@PedidoStatus",SqlDbType.VarChar,3,0} ,
          new Object[] {"@PedidoDescontoFrete",SqlDbType.Decimal,12,2} ,
          new Object[] {"@PedidoTotal",SqlDbType.Decimal,12,2} ,
          new Object[] {"@PedidoDt",SqlDbType.DateTime,8,0} ,
          new Object[] {"@PedidoDtEntrega",SqlDbType.DateTime,8,0} ,
          new Object[] {"@PedidoRetirada",SqlDbType.Bit,4,0} ,
          new Object[] {"@PessoaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PedidoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000621 ;
          prmT000621 = new Object[] {
          new Object[] {"@PedidoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000626 ;
          prmT000626 = new Object[] {
          new Object[] {"@PedidoDescontoFrete",SqlDbType.Decimal,12,2} ,
          new Object[] {"@PedidoTotal",SqlDbType.Decimal,12,2} ,
          new Object[] {"@PedidoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000627 ;
          prmT000627 = new Object[] {
          } ;
          Object[] prmT000628 ;
          prmT000628 = new Object[] {
          new Object[] {"@PedidoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ProdutoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00064 ;
          prmT00064 = new Object[] {
          new Object[] {"@ProdutoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000629 ;
          prmT000629 = new Object[] {
          new Object[] {"@ProdutoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000630 ;
          prmT000630 = new Object[] {
          new Object[] {"@PedidoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ProdutoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00063 ;
          prmT00063 = new Object[] {
          new Object[] {"@PedidoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ProdutoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00062 ;
          prmT00062 = new Object[] {
          new Object[] {"@PedidoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ProdutoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000631 ;
          prmT000631 = new Object[] {
          new Object[] {"@PedidoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PedidoItemQtd",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ProdutoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000632 ;
          prmT000632 = new Object[] {
          new Object[] {"@PedidoItemQtd",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PedidoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ProdutoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000633 ;
          prmT000633 = new Object[] {
          new Object[] {"@PedidoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ProdutoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000635 ;
          prmT000635 = new Object[] {
          new Object[] {"@PedidoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000624 ;
          prmT000624 = new Object[] {
          new Object[] {"@PedidoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000625 ;
          prmT000625 = new Object[] {
          new Object[] {"@PessoaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000634 ;
          prmT000634 = new Object[] {
          new Object[] {"@ProdutoId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00062", "SELECT [PedidoId], [PedidoItemQtd], [ProdutoId] FROM [PedidoItem] WITH (UPDLOCK) WHERE [PedidoId] = @PedidoId AND [ProdutoId] = @ProdutoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00062,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00063", "SELECT [PedidoId], [PedidoItemQtd], [ProdutoId] FROM [PedidoItem] WHERE [PedidoId] = @PedidoId AND [ProdutoId] = @ProdutoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00063,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00064", "SELECT [ProdutoNome], [ProdutoValor] FROM [Produto] WHERE [ProdutoId] = @ProdutoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00064,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00067", "SELECT COALESCE( T1.[PedidoTotalFML], 0) AS PedidoTotalFML FROM (SELECT COALESCE( T2.[GXC1], 0) AS PedidoTotalFML FROM (SELECT SUM(T4.[ProdutoValor] * CAST(T3.[PedidoItemQtd] AS decimal( 22, 10))) AS GXC1, T3.[PedidoId] FROM ([PedidoItem] T3 WITH (UPDLOCK) INNER JOIN [Produto] T4 ON T4.[ProdutoId] = T3.[ProdutoId]) GROUP BY T3.[PedidoId] ) T2 WHERE T2.[PedidoId] = @PedidoId ) T1 ",true, GxErrorMask.GX_NOMASK, false, this,prmT00067,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00068", "SELECT [PedidoId], [PedidoStatus], [PedidoDescontoFrete], [PedidoTotal], [PedidoDt], [PedidoDtEntrega], [PedidoRetirada], [PessoaId] FROM [Pedido] WITH (UPDLOCK) WHERE [PedidoId] = @PedidoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00068,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00069", "SELECT [PedidoId], [PedidoStatus], [PedidoDescontoFrete], [PedidoTotal], [PedidoDt], [PedidoDtEntrega], [PedidoRetirada], [PessoaId] FROM [Pedido] WHERE [PedidoId] = @PedidoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00069,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000610", "SELECT [PessoaNome] FROM [Pessoa] WHERE [PessoaId] = @PessoaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000610,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000611", "SELECT TM1.[PedidoId], TM1.[PedidoStatus], TM1.[PedidoDescontoFrete], TM1.[PedidoTotal], T2.[PessoaNome], TM1.[PedidoDt], TM1.[PedidoDtEntrega], TM1.[PedidoRetirada], TM1.[PessoaId] FROM ([Pedido] TM1 INNER JOIN [Pessoa] T2 ON T2.[PessoaId] = TM1.[PessoaId]) WHERE TM1.[PedidoId] = @PedidoId ORDER BY TM1.[PedidoId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000611,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000614", "SELECT COALESCE( T1.[PedidoTotalFML], 0) AS PedidoTotalFML FROM (SELECT COALESCE( T2.[GXC1], 0) AS PedidoTotalFML FROM (SELECT SUM(T4.[ProdutoValor] * CAST(T3.[PedidoItemQtd] AS decimal( 22, 10))) AS GXC1, T3.[PedidoId] FROM ([PedidoItem] T3 WITH (UPDLOCK) INNER JOIN [Produto] T4 ON T4.[ProdutoId] = T3.[ProdutoId]) GROUP BY T3.[PedidoId] ) T2 WHERE T2.[PedidoId] = @PedidoId ) T1 ",true, GxErrorMask.GX_NOMASK, false, this,prmT000614,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000615", "SELECT [PessoaNome] FROM [Pessoa] WHERE [PessoaId] = @PessoaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000615,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000616", "SELECT [PedidoId] FROM [Pedido] WHERE [PedidoId] = @PedidoId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000616,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000617", "SELECT TOP 1 [PedidoId] FROM [Pedido] WHERE ( [PedidoId] > @PedidoId) ORDER BY [PedidoId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000617,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000618", "SELECT TOP 1 [PedidoId] FROM [Pedido] WHERE ( [PedidoId] < @PedidoId) ORDER BY [PedidoId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000618,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000619", "INSERT INTO [Pedido]([PedidoStatus], [PedidoDescontoFrete], [PedidoTotal], [PedidoDt], [PedidoDtEntrega], [PedidoRetirada], [PessoaId]) VALUES(@PedidoStatus, @PedidoDescontoFrete, @PedidoTotal, @PedidoDt, @PedidoDtEntrega, @PedidoRetirada, @PessoaId); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000619)
             ,new CursorDef("T000620", "UPDATE [Pedido] SET [PedidoStatus]=@PedidoStatus, [PedidoDescontoFrete]=@PedidoDescontoFrete, [PedidoTotal]=@PedidoTotal, [PedidoDt]=@PedidoDt, [PedidoDtEntrega]=@PedidoDtEntrega, [PedidoRetirada]=@PedidoRetirada, [PessoaId]=@PessoaId  WHERE [PedidoId] = @PedidoId", GxErrorMask.GX_NOMASK,prmT000620)
             ,new CursorDef("T000621", "DELETE FROM [Pedido]  WHERE [PedidoId] = @PedidoId", GxErrorMask.GX_NOMASK,prmT000621)
             ,new CursorDef("T000624", "SELECT COALESCE( T1.[PedidoTotalFML], 0) AS PedidoTotalFML FROM (SELECT COALESCE( T2.[GXC1], 0) AS PedidoTotalFML FROM (SELECT SUM(T4.[ProdutoValor] * CAST(T3.[PedidoItemQtd] AS decimal( 22, 10))) AS GXC1, T3.[PedidoId] FROM ([PedidoItem] T3 WITH (UPDLOCK) INNER JOIN [Produto] T4 ON T4.[ProdutoId] = T3.[ProdutoId]) GROUP BY T3.[PedidoId] ) T2 WHERE T2.[PedidoId] = @PedidoId ) T1 ",true, GxErrorMask.GX_NOMASK, false, this,prmT000624,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000625", "SELECT [PessoaNome] FROM [Pessoa] WHERE [PessoaId] = @PessoaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000625,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000626", "UPDATE [Pedido] SET [PedidoDescontoFrete]=@PedidoDescontoFrete, [PedidoTotal]=@PedidoTotal  WHERE [PedidoId] = @PedidoId", GxErrorMask.GX_NOMASK,prmT000626)
             ,new CursorDef("T000627", "SELECT [PedidoId] FROM [Pedido] ORDER BY [PedidoId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000627,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000628", "SELECT T1.[PedidoId], T2.[ProdutoNome], T2.[ProdutoValor], T1.[PedidoItemQtd], T1.[ProdutoId] FROM ([PedidoItem] T1 INNER JOIN [Produto] T2 ON T2.[ProdutoId] = T1.[ProdutoId]) WHERE T1.[PedidoId] = @PedidoId and T1.[ProdutoId] = @ProdutoId ORDER BY T1.[PedidoId], T1.[ProdutoId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000628,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000629", "SELECT [ProdutoNome], [ProdutoValor] FROM [Produto] WHERE [ProdutoId] = @ProdutoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000629,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000630", "SELECT [PedidoId], [ProdutoId] FROM [PedidoItem] WHERE [PedidoId] = @PedidoId AND [ProdutoId] = @ProdutoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000630,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000631", "INSERT INTO [PedidoItem]([PedidoId], [PedidoItemQtd], [ProdutoId]) VALUES(@PedidoId, @PedidoItemQtd, @ProdutoId)", GxErrorMask.GX_NOMASK,prmT000631)
             ,new CursorDef("T000632", "UPDATE [PedidoItem] SET [PedidoItemQtd]=@PedidoItemQtd  WHERE [PedidoId] = @PedidoId AND [ProdutoId] = @ProdutoId", GxErrorMask.GX_NOMASK,prmT000632)
             ,new CursorDef("T000633", "DELETE FROM [PedidoItem]  WHERE [PedidoId] = @PedidoId AND [ProdutoId] = @ProdutoId", GxErrorMask.GX_NOMASK,prmT000633)
             ,new CursorDef("T000634", "SELECT [ProdutoNome], [ProdutoValor] FROM [Produto] WHERE [ProdutoId] = @ProdutoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000634,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000635", "SELECT [PedidoId], [ProdutoId] FROM [PedidoItem] WHERE [PedidoId] = @PedidoId ORDER BY [PedidoId], [ProdutoId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000635,100, GxCacheFrequency.OFF ,true,false )
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                return;
             case 3 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(6) ;
                ((bool[]) buf[6])[0] = rslt.getBool(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(6) ;
                ((bool[]) buf[6])[0] = rslt.getBool(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                return;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(6) ;
                ((DateTime[]) buf[6])[0] = rslt.getGXDate(7) ;
                ((bool[]) buf[7])[0] = rslt.getBool(8) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                return;
             case 8 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 10 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 16 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 17 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 19 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 20 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 21 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                return;
             case 22 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 26 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                return;
             case 27 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
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
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
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
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 13 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (decimal)parms[1]);
                stmt.SetParameter(3, (decimal)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                stmt.SetParameter(5, (DateTime)parms[4]);
                stmt.SetParameter(6, (bool)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                return;
             case 14 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (decimal)parms[1]);
                stmt.SetParameter(3, (decimal)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                stmt.SetParameter(5, (DateTime)parms[4]);
                stmt.SetParameter(6, (bool)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                stmt.SetParameter(8, (short)parms[7]);
                return;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 16 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 17 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 18 :
                stmt.SetParameter(1, (decimal)parms[0]);
                stmt.SetParameter(2, (decimal)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 20 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 21 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 22 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 23 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 24 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 25 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 26 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 27 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
