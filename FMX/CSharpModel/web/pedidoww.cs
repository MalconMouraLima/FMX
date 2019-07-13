/*
               File: PedidoWW
        Description:  Pedido
             Author: GeneXus C# Generator version 16_0_2-131213
       Generated on: 7/12/2019 18:0:22.39
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
using GeneXus.Http.Server;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class pedidoww : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public pedidoww( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public pedidoww( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( )
      {
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavPessoanomeoperator = new GXCombobox();
         cmbavPedidostatus = new GXCombobox();
         cmbPedidoStatus = new GXCombobox();
         chkPedidoRetirada = new GXCheckbox();
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( nGotPars == 0 )
         {
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid") == 0 )
            {
               nRC_GXsfl_91 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_91_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_91_idx = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrGrid_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid") == 0 )
            {
               subGrid_Rows = (int)(NumberUtil.Val( GetNextPar( ), "."));
               AV93PessoaNomeOperator = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV94PessoaNome = GetNextPar( );
               AV99PedidoDt = context.localUtil.ParseDateParm( GetNextPar( ));
               AV100PedidoDt_To = context.localUtil.ParseDateParm( GetNextPar( ));
               AV101PedidoDtEntrega = context.localUtil.ParseDateParm( GetNextPar( ));
               AV102PedidoDtEntrega_To = context.localUtil.ParseDateParm( GetNextPar( ));
               AV103PedidoStatus = GetNextPar( );
               AV13OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV14OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV59TFPedidoId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV60TFPedidoId_To = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV96TFPessoaNome = GetNextPar( );
               AV97TFPessoaNome_Sel = GetNextPar( );
               AV63TFPedidoDt = context.localUtil.ParseDateParm( GetNextPar( ));
               AV64TFPedidoDt_To = context.localUtil.ParseDateParm( GetNextPar( ));
               AV73TFPedidoDtEntrega = context.localUtil.ParseDateParm( GetNextPar( ));
               AV74TFPedidoDtEntrega_To = context.localUtil.ParseDateParm( GetNextPar( ));
               AV79TFPedidoRetirada_Sel = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV82TFPedidoTotal = NumberUtil.Val( GetNextPar( ), ".");
               AV83TFPedidoTotal_To = NumberUtil.Val( GetNextPar( ), ".");
               AV52ManageFiltersExecutionStep = (short)(NumberUtil.Val( GetNextPar( ), "."));
               ajax_req_read_hidden_sdt(GetNextPar( ), AV44ColumnsSelector);
               AV61ddo_PedidoIdTitleControlIdToReplace = GetNextPar( );
               AV98ddo_PessoaNomeTitleControlIdToReplace = GetNextPar( );
               AV67ddo_PedidoDtTitleControlIdToReplace = GetNextPar( );
               AV71ddo_PedidoStatusTitleControlIdToReplace = GetNextPar( );
               AV77ddo_PedidoDtEntregaTitleControlIdToReplace = GetNextPar( );
               AV80ddo_PedidoRetiradaTitleControlIdToReplace = GetNextPar( );
               AV84ddo_PedidoTotalTitleControlIdToReplace = GetNextPar( );
               ajax_req_read_hidden_sdt(GetNextPar( ), AV70TFPedidoStatus_Sels);
               AV131Pgmname = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV93PessoaNomeOperator, AV94PessoaNome, AV99PedidoDt, AV100PedidoDt_To, AV101PedidoDtEntrega, AV102PedidoDtEntrega_To, AV103PedidoStatus, AV13OrderedBy, AV14OrderedDsc, AV59TFPedidoId, AV60TFPedidoId_To, AV96TFPessoaNome, AV97TFPessoaNome_Sel, AV63TFPedidoDt, AV64TFPedidoDt_To, AV73TFPedidoDtEntrega, AV74TFPedidoDtEntrega_To, AV79TFPedidoRetirada_Sel, AV82TFPedidoTotal, AV83TFPedidoTotal_To, AV52ManageFiltersExecutionStep, AV44ColumnsSelector, AV61ddo_PedidoIdTitleControlIdToReplace, AV98ddo_PessoaNomeTitleControlIdToReplace, AV67ddo_PedidoDtTitleControlIdToReplace, AV71ddo_PedidoStatusTitleControlIdToReplace, AV77ddo_PedidoDtEntregaTitleControlIdToReplace, AV80ddo_PedidoRetiradaTitleControlIdToReplace, AV84ddo_PedidoTotalTitleControlIdToReplace, AV70TFPedidoStatus_Sels, AV131Pgmname) ;
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
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
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
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

      public override short ExecuteStartEvent( )
      {
         PA132( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START132( ) ;
         }
         return gxajaxcallmode ;
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
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 131213), false, true);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 131213), false, true);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 131213), false, true);
         context.AddJavascriptSource("gxcfg.js", "?20197121802284", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 131213), false, true);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 131213), false, true);
         context.AddJavascriptSource("calendar-pt.js", "?"+context.GetBuildNumber( 131213), false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/DVPaginationBar/DVPaginationBarRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false, true);
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"false\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         if ( nGXWrapped == 0 )
         {
            bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         }
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("pedidoww.aspx") +"\">") ;
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
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vPESSOANOMEOPERATOR", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV93PessoaNomeOperator), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vPESSOANOME", AV94PessoaNome);
         GxWebStd.gx_hidden_field( context, "GXH_vPEDIDODT", context.localUtil.Format(AV99PedidoDt, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vPEDIDODT_TO", context.localUtil.Format(AV100PedidoDt_To, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vPEDIDODTENTREGA", context.localUtil.Format(AV101PedidoDtEntrega, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vPEDIDODTENTREGA_TO", context.localUtil.Format(AV102PedidoDtEntrega_To, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vPEDIDOSTATUS", AV103PedidoStatus);
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV14OrderedDsc));
         GxWebStd.gx_hidden_field( context, "GXH_vTFPEDIDOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV59TFPedidoId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFPEDIDOID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV60TFPedidoId_To), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFPESSOANOME", AV96TFPessoaNome);
         GxWebStd.gx_hidden_field( context, "GXH_vTFPESSOANOME_SEL", AV97TFPessoaNome_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFPEDIDODT", context.localUtil.Format(AV63TFPedidoDt, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vTFPEDIDODT_TO", context.localUtil.Format(AV64TFPedidoDt_To, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vTFPEDIDODTENTREGA", context.localUtil.Format(AV73TFPedidoDtEntrega, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vTFPEDIDODTENTREGA_TO", context.localUtil.Format(AV74TFPedidoDtEntrega_To, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vTFPEDIDORETIRADA_SEL", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV79TFPedidoRetirada_Sel), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFPEDIDOTOTAL", StringUtil.LTrim( StringUtil.NToC( AV82TFPedidoTotal, 12, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFPEDIDOTOTAL_TO", StringUtil.LTrim( StringUtil.NToC( AV83TFPedidoTotal_To, 12, 2, ",", "")));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_91", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_91), 4, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vMANAGEFILTERSDATA", AV56ManageFiltersData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vMANAGEFILTERSDATA", AV56ManageFiltersData);
         }
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV87GridCurrentPage), 10, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGECOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV88GridPageCount), 10, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV85DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV85DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPEDIDOIDTITLEFILTERDATA", AV58PedidoIdTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPEDIDOIDTITLEFILTERDATA", AV58PedidoIdTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPESSOANOMETITLEFILTERDATA", AV95PessoaNomeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPESSOANOMETITLEFILTERDATA", AV95PessoaNomeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPEDIDODTTITLEFILTERDATA", AV62PedidoDtTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPEDIDODTTITLEFILTERDATA", AV62PedidoDtTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPEDIDOSTATUSTITLEFILTERDATA", AV68PedidoStatusTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPEDIDOSTATUSTITLEFILTERDATA", AV68PedidoStatusTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPEDIDODTENTREGATITLEFILTERDATA", AV72PedidoDtEntregaTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPEDIDODTENTREGATITLEFILTERDATA", AV72PedidoDtEntregaTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPEDIDORETIRADATITLEFILTERDATA", AV78PedidoRetiradaTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPEDIDORETIRADATITLEFILTERDATA", AV78PedidoRetiradaTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPEDIDOTOTALTITLEFILTERDATA", AV81PedidoTotalTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPEDIDOTOTALTITLEFILTERDATA", AV81PedidoTotalTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vCOLUMNSSELECTOR", AV44ColumnsSelector);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vCOLUMNSSELECTOR", AV44ColumnsSelector);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTFPEDIDOSTATUS_SELS", AV70TFPedidoStatus_Sels);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTFPEDIDOSTATUS_SELS", AV70TFPedidoStatus_Sels);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV131Pgmname));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vGRIDSTATE", AV10GridState);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vGRIDSTATE", AV10GridState);
         }
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_MANAGEFILTERS_Icon", StringUtil.RTrim( Ddo_managefilters_Icon));
         GxWebStd.gx_hidden_field( context, "DDO_MANAGEFILTERS_Tooltip", StringUtil.RTrim( Ddo_managefilters_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_MANAGEFILTERS_Cls", StringUtil.RTrim( Ddo_managefilters_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Width", StringUtil.RTrim( Dvpanel_tableheader_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Cls", StringUtil.RTrim( Dvpanel_tableheader_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Title", StringUtil.RTrim( Dvpanel_tableheader_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Collapsible", StringUtil.BoolToStr( Dvpanel_tableheader_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Collapsed", StringUtil.BoolToStr( Dvpanel_tableheader_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Autowidth", StringUtil.BoolToStr( Dvpanel_tableheader_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Autoheight", StringUtil.BoolToStr( Dvpanel_tableheader_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_tableheader_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Iconposition", StringUtil.RTrim( Dvpanel_tableheader_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Autoscroll", StringUtil.BoolToStr( Dvpanel_tableheader_Autoscroll));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Class", StringUtil.RTrim( Gridpaginationbar_Class));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Previous", StringUtil.RTrim( Gridpaginationbar_Previous));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Next", StringUtil.RTrim( Gridpaginationbar_Next));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Caption", StringUtil.RTrim( Gridpaginationbar_Caption));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Showfirst", StringUtil.BoolToStr( Gridpaginationbar_Showfirst));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Showprevious", StringUtil.BoolToStr( Gridpaginationbar_Showprevious));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Shownext", StringUtil.BoolToStr( Gridpaginationbar_Shownext));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Showlast", StringUtil.BoolToStr( Gridpaginationbar_Showlast));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Pagestoshow", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Pagestoshow), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Pagingbuttonsposition", StringUtil.RTrim( Gridpaginationbar_Pagingbuttonsposition));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Pagingcaptionposition", StringUtil.RTrim( Gridpaginationbar_Pagingcaptionposition));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Emptygridclass", StringUtil.RTrim( Gridpaginationbar_Emptygridclass));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselector", StringUtil.BoolToStr( Gridpaginationbar_Rowsperpageselector));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageoptions", StringUtil.RTrim( Gridpaginationbar_Rowsperpageoptions));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Emptygridcaption", StringUtil.RTrim( Gridpaginationbar_Emptygridcaption));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpagecaption", StringUtil.RTrim( Gridpaginationbar_Rowsperpagecaption));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Caption", StringUtil.RTrim( Ddo_pedidoid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Tooltip", StringUtil.RTrim( Ddo_pedidoid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Cls", StringUtil.RTrim( Ddo_pedidoid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Filteredtext_set", StringUtil.RTrim( Ddo_pedidoid_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Filteredtextto_set", StringUtil.RTrim( Ddo_pedidoid_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Dropdownoptionstype", StringUtil.RTrim( Ddo_pedidoid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_pedidoid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Includesortasc", StringUtil.BoolToStr( Ddo_pedidoid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Includesortdsc", StringUtil.BoolToStr( Ddo_pedidoid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Sortedstatus", StringUtil.RTrim( Ddo_pedidoid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Includefilter", StringUtil.BoolToStr( Ddo_pedidoid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Filtertype", StringUtil.RTrim( Ddo_pedidoid_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Filterisrange", StringUtil.BoolToStr( Ddo_pedidoid_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Includedatalist", StringUtil.BoolToStr( Ddo_pedidoid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Sortasc", StringUtil.RTrim( Ddo_pedidoid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Sortdsc", StringUtil.RTrim( Ddo_pedidoid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Cleanfilter", StringUtil.RTrim( Ddo_pedidoid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Rangefilterfrom", StringUtil.RTrim( Ddo_pedidoid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Rangefilterto", StringUtil.RTrim( Ddo_pedidoid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Searchbuttontext", StringUtil.RTrim( Ddo_pedidoid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Caption", StringUtil.RTrim( Ddo_pessoanome_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Tooltip", StringUtil.RTrim( Ddo_pessoanome_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Cls", StringUtil.RTrim( Ddo_pessoanome_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Filteredtext_set", StringUtil.RTrim( Ddo_pessoanome_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Selectedvalue_set", StringUtil.RTrim( Ddo_pessoanome_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Dropdownoptionstype", StringUtil.RTrim( Ddo_pessoanome_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_pessoanome_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Includesortasc", StringUtil.BoolToStr( Ddo_pessoanome_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Includesortdsc", StringUtil.BoolToStr( Ddo_pessoanome_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Sortedstatus", StringUtil.RTrim( Ddo_pessoanome_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Includefilter", StringUtil.BoolToStr( Ddo_pessoanome_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Filtertype", StringUtil.RTrim( Ddo_pessoanome_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Filterisrange", StringUtil.BoolToStr( Ddo_pessoanome_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Includedatalist", StringUtil.BoolToStr( Ddo_pessoanome_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Datalisttype", StringUtil.RTrim( Ddo_pessoanome_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Datalistproc", StringUtil.RTrim( Ddo_pessoanome_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_pessoanome_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Sortasc", StringUtil.RTrim( Ddo_pessoanome_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Sortdsc", StringUtil.RTrim( Ddo_pessoanome_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Loadingdata", StringUtil.RTrim( Ddo_pessoanome_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Cleanfilter", StringUtil.RTrim( Ddo_pessoanome_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Noresultsfound", StringUtil.RTrim( Ddo_pessoanome_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Searchbuttontext", StringUtil.RTrim( Ddo_pessoanome_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Caption", StringUtil.RTrim( Ddo_pedidodt_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Tooltip", StringUtil.RTrim( Ddo_pedidodt_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Cls", StringUtil.RTrim( Ddo_pedidodt_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Filteredtext_set", StringUtil.RTrim( Ddo_pedidodt_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Filteredtextto_set", StringUtil.RTrim( Ddo_pedidodt_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Dropdownoptionstype", StringUtil.RTrim( Ddo_pedidodt_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_pedidodt_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Includesortasc", StringUtil.BoolToStr( Ddo_pedidodt_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Includesortdsc", StringUtil.BoolToStr( Ddo_pedidodt_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Sortedstatus", StringUtil.RTrim( Ddo_pedidodt_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Includefilter", StringUtil.BoolToStr( Ddo_pedidodt_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Filtertype", StringUtil.RTrim( Ddo_pedidodt_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Filterisrange", StringUtil.BoolToStr( Ddo_pedidodt_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Includedatalist", StringUtil.BoolToStr( Ddo_pedidodt_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Sortasc", StringUtil.RTrim( Ddo_pedidodt_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Sortdsc", StringUtil.RTrim( Ddo_pedidodt_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Cleanfilter", StringUtil.RTrim( Ddo_pedidodt_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Rangefilterfrom", StringUtil.RTrim( Ddo_pedidodt_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Rangefilterto", StringUtil.RTrim( Ddo_pedidodt_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Searchbuttontext", StringUtil.RTrim( Ddo_pedidodt_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Caption", StringUtil.RTrim( Ddo_pedidostatus_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Tooltip", StringUtil.RTrim( Ddo_pedidostatus_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Cls", StringUtil.RTrim( Ddo_pedidostatus_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Selectedvalue_set", StringUtil.RTrim( Ddo_pedidostatus_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Dropdownoptionstype", StringUtil.RTrim( Ddo_pedidostatus_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_pedidostatus_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Includesortasc", StringUtil.BoolToStr( Ddo_pedidostatus_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Includesortdsc", StringUtil.BoolToStr( Ddo_pedidostatus_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Sortedstatus", StringUtil.RTrim( Ddo_pedidostatus_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Includefilter", StringUtil.BoolToStr( Ddo_pedidostatus_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Includedatalist", StringUtil.BoolToStr( Ddo_pedidostatus_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Datalisttype", StringUtil.RTrim( Ddo_pedidostatus_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Allowmultipleselection", StringUtil.BoolToStr( Ddo_pedidostatus_Allowmultipleselection));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Datalistfixedvalues", StringUtil.RTrim( Ddo_pedidostatus_Datalistfixedvalues));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Sortasc", StringUtil.RTrim( Ddo_pedidostatus_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Sortdsc", StringUtil.RTrim( Ddo_pedidostatus_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Cleanfilter", StringUtil.RTrim( Ddo_pedidostatus_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Searchbuttontext", StringUtil.RTrim( Ddo_pedidostatus_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Caption", StringUtil.RTrim( Ddo_pedidodtentrega_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Tooltip", StringUtil.RTrim( Ddo_pedidodtentrega_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Cls", StringUtil.RTrim( Ddo_pedidodtentrega_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Filteredtext_set", StringUtil.RTrim( Ddo_pedidodtentrega_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Filteredtextto_set", StringUtil.RTrim( Ddo_pedidodtentrega_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Dropdownoptionstype", StringUtil.RTrim( Ddo_pedidodtentrega_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_pedidodtentrega_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Includesortasc", StringUtil.BoolToStr( Ddo_pedidodtentrega_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Includesortdsc", StringUtil.BoolToStr( Ddo_pedidodtentrega_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Sortedstatus", StringUtil.RTrim( Ddo_pedidodtentrega_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Includefilter", StringUtil.BoolToStr( Ddo_pedidodtentrega_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Filtertype", StringUtil.RTrim( Ddo_pedidodtentrega_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Filterisrange", StringUtil.BoolToStr( Ddo_pedidodtentrega_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Includedatalist", StringUtil.BoolToStr( Ddo_pedidodtentrega_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Sortasc", StringUtil.RTrim( Ddo_pedidodtentrega_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Sortdsc", StringUtil.RTrim( Ddo_pedidodtentrega_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Cleanfilter", StringUtil.RTrim( Ddo_pedidodtentrega_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Rangefilterfrom", StringUtil.RTrim( Ddo_pedidodtentrega_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Rangefilterto", StringUtil.RTrim( Ddo_pedidodtentrega_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Searchbuttontext", StringUtil.RTrim( Ddo_pedidodtentrega_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Caption", StringUtil.RTrim( Ddo_pedidoretirada_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Tooltip", StringUtil.RTrim( Ddo_pedidoretirada_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Cls", StringUtil.RTrim( Ddo_pedidoretirada_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Selectedvalue_set", StringUtil.RTrim( Ddo_pedidoretirada_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Dropdownoptionstype", StringUtil.RTrim( Ddo_pedidoretirada_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_pedidoretirada_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Includesortasc", StringUtil.BoolToStr( Ddo_pedidoretirada_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Includesortdsc", StringUtil.BoolToStr( Ddo_pedidoretirada_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Sortedstatus", StringUtil.RTrim( Ddo_pedidoretirada_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Includefilter", StringUtil.BoolToStr( Ddo_pedidoretirada_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Includedatalist", StringUtil.BoolToStr( Ddo_pedidoretirada_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Datalisttype", StringUtil.RTrim( Ddo_pedidoretirada_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Datalistfixedvalues", StringUtil.RTrim( Ddo_pedidoretirada_Datalistfixedvalues));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Sortasc", StringUtil.RTrim( Ddo_pedidoretirada_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Sortdsc", StringUtil.RTrim( Ddo_pedidoretirada_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Cleanfilter", StringUtil.RTrim( Ddo_pedidoretirada_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Searchbuttontext", StringUtil.RTrim( Ddo_pedidoretirada_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Caption", StringUtil.RTrim( Ddo_pedidototal_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Tooltip", StringUtil.RTrim( Ddo_pedidototal_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Cls", StringUtil.RTrim( Ddo_pedidototal_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Filteredtext_set", StringUtil.RTrim( Ddo_pedidototal_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Filteredtextto_set", StringUtil.RTrim( Ddo_pedidototal_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Dropdownoptionstype", StringUtil.RTrim( Ddo_pedidototal_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_pedidototal_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Includesortasc", StringUtil.BoolToStr( Ddo_pedidototal_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Includesortdsc", StringUtil.BoolToStr( Ddo_pedidototal_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Sortedstatus", StringUtil.RTrim( Ddo_pedidototal_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Includefilter", StringUtil.BoolToStr( Ddo_pedidototal_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Filtertype", StringUtil.RTrim( Ddo_pedidototal_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Filterisrange", StringUtil.BoolToStr( Ddo_pedidototal_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Includedatalist", StringUtil.BoolToStr( Ddo_pedidototal_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Sortasc", StringUtil.RTrim( Ddo_pedidototal_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Sortdsc", StringUtil.RTrim( Ddo_pedidototal_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Cleanfilter", StringUtil.RTrim( Ddo_pedidototal_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Rangefilterfrom", StringUtil.RTrim( Ddo_pedidototal_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Rangefilterto", StringUtil.RTrim( Ddo_pedidototal_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Searchbuttontext", StringUtil.RTrim( Ddo_pedidototal_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Caption", StringUtil.RTrim( Ddo_gridcolumnsselector_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Tooltip", StringUtil.RTrim( Ddo_gridcolumnsselector_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Cls", StringUtil.RTrim( Ddo_gridcolumnsselector_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Dropdownoptionstype", StringUtil.RTrim( Ddo_gridcolumnsselector_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_gridcolumnsselector_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Updatebuttontext", StringUtil.RTrim( Ddo_gridcolumnsselector_Updatebuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Activeeventkey", StringUtil.RTrim( Ddo_pedidoid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Filteredtext_get", StringUtil.RTrim( Ddo_pedidoid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Filteredtextto_get", StringUtil.RTrim( Ddo_pedidoid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Activeeventkey", StringUtil.RTrim( Ddo_pessoanome_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Filteredtext_get", StringUtil.RTrim( Ddo_pessoanome_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Selectedvalue_get", StringUtil.RTrim( Ddo_pessoanome_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Activeeventkey", StringUtil.RTrim( Ddo_pedidodt_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Filteredtext_get", StringUtil.RTrim( Ddo_pedidodt_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Filteredtextto_get", StringUtil.RTrim( Ddo_pedidodt_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Activeeventkey", StringUtil.RTrim( Ddo_pedidostatus_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Selectedvalue_get", StringUtil.RTrim( Ddo_pedidostatus_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Activeeventkey", StringUtil.RTrim( Ddo_pedidodtentrega_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Filteredtext_get", StringUtil.RTrim( Ddo_pedidodtentrega_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Filteredtextto_get", StringUtil.RTrim( Ddo_pedidodtentrega_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Activeeventkey", StringUtil.RTrim( Ddo_pedidoretirada_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Selectedvalue_get", StringUtil.RTrim( Ddo_pedidoretirada_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Activeeventkey", StringUtil.RTrim( Ddo_pedidototal_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Filteredtext_get", StringUtil.RTrim( Ddo_pedidototal_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Filteredtextto_get", StringUtil.RTrim( Ddo_pedidototal_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Columnsselectorvalues", StringUtil.RTrim( Ddo_gridcolumnsselector_Columnsselectorvalues));
         GxWebStd.gx_hidden_field( context, "DDO_MANAGEFILTERS_Activeeventkey", StringUtil.RTrim( Ddo_managefilters_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Activeeventkey", StringUtil.RTrim( Ddo_pedidoid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Filteredtext_get", StringUtil.RTrim( Ddo_pedidoid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Filteredtextto_get", StringUtil.RTrim( Ddo_pedidoid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Activeeventkey", StringUtil.RTrim( Ddo_pessoanome_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Filteredtext_get", StringUtil.RTrim( Ddo_pessoanome_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Selectedvalue_get", StringUtil.RTrim( Ddo_pessoanome_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Activeeventkey", StringUtil.RTrim( Ddo_pedidodt_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Filteredtext_get", StringUtil.RTrim( Ddo_pedidodt_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Filteredtextto_get", StringUtil.RTrim( Ddo_pedidodt_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Activeeventkey", StringUtil.RTrim( Ddo_pedidostatus_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Selectedvalue_get", StringUtil.RTrim( Ddo_pedidostatus_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Activeeventkey", StringUtil.RTrim( Ddo_pedidodtentrega_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Filteredtext_get", StringUtil.RTrim( Ddo_pedidodtentrega_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Filteredtextto_get", StringUtil.RTrim( Ddo_pedidodtentrega_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Activeeventkey", StringUtil.RTrim( Ddo_pedidoretirada_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Selectedvalue_get", StringUtil.RTrim( Ddo_pedidoretirada_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Activeeventkey", StringUtil.RTrim( Ddo_pedidototal_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Filteredtext_get", StringUtil.RTrim( Ddo_pedidototal_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Filteredtextto_get", StringUtil.RTrim( Ddo_pedidototal_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Columnsselectorvalues", StringUtil.RTrim( Ddo_gridcolumnsselector_Columnsselectorvalues));
         GxWebStd.gx_hidden_field( context, "DDO_MANAGEFILTERS_Activeeventkey", StringUtil.RTrim( Ddo_managefilters_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken((String)(sPrefix));
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

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE132( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT132( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("pedidoww.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "PedidoWW" ;
      }

      public override String GetPgmdesc( )
      {
         return " Pedido" ;
      }

      protected void WB130( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayoutmaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "TableMain", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* User Defined Control */
            ucDvpanel_tableheader.SetProperty("Width", Dvpanel_tableheader_Width);
            ucDvpanel_tableheader.SetProperty("AutoWidth", Dvpanel_tableheader_Autowidth);
            ucDvpanel_tableheader.SetProperty("AutoHeight", Dvpanel_tableheader_Autoheight);
            ucDvpanel_tableheader.SetProperty("Cls", Dvpanel_tableheader_Cls);
            ucDvpanel_tableheader.SetProperty("Title", Dvpanel_tableheader_Title);
            ucDvpanel_tableheader.SetProperty("Collapsible", Dvpanel_tableheader_Collapsible);
            ucDvpanel_tableheader.SetProperty("Collapsed", Dvpanel_tableheader_Collapsed);
            ucDvpanel_tableheader.SetProperty("ShowCollapseIcon", Dvpanel_tableheader_Showcollapseicon);
            ucDvpanel_tableheader.SetProperty("IconPosition", Dvpanel_tableheader_Iconposition);
            ucDvpanel_tableheader.SetProperty("AutoScroll", Dvpanel_tableheader_Autoscroll);
            ucDvpanel_tableheader.Render(context, "dvelop.gxbootstrap.panel_al", Dvpanel_tableheader_Internalname, "DVPANEL_TABLEHEADERContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_TABLEHEADERContainer"+"TableHeader"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableheader_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 CellWidthAuto", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableactions_Internalname, 1, 0, "px", 0, "px", "TableCellsWidthAuto", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroupGrouped", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(91), 2, 0)+","+"null"+");", "Inserir", bttBtninsert_Jsonclick, 5, "Inserir", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_PedidoWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"";
            ClassString = "hidden-xs";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtneditcolumns_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(91), 2, 0)+","+"null"+");", "Seleciona colunas", bttBtneditcolumns_Jsonclick, 0, "Seleciona colunas", "", StyleString, ClassString, 1, 0, "standard", "'"+""+"'"+",false,"+"'"+""+"'", TempTags, "", context.GetButtonType( ), "HLP_PedidoWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-xs col-sm-6 CellFloatRight CellWidthAuto", "left", "top", "", "", "div");
            wb_table1_23_132( true) ;
         }
         else
         {
            wb_table1_23_132( false) ;
         }
         return  ;
      }

      protected void wb_table1_23_132e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 SectionGrid GridNoBorderCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGridtablewithpaginationbar_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /*  Grid Control  */
            GridContainer.SetWrapped(nGXWrapped);
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"91\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGrid_Internalname, subGrid_Internalname, "", "GridWithPaginationBar GridNoBorder WorkWith", 0, "", "", 1, 2, sStyleString, "", "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid_Backcolorstyle == 0 )
               {
                  subGrid_Titlebackstyle = 0;
                  if ( StringUtil.Len( subGrid_Class) > 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Title";
                  }
               }
               else
               {
                  subGrid_Titlebackstyle = 1;
                  if ( subGrid_Backcolorstyle == 1 )
                  {
                     subGrid_Titlebackcolor = subGrid_Allbackcolor;
                     if ( StringUtil.Len( subGrid_Class) > 0 )
                     {
                        subGrid_Linesclass = subGrid_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid_Class) > 0 )
                     {
                        subGrid_Linesclass = subGrid_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+((edtPedidoId_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               if ( edtPedidoId_Titleformat == 0 )
               {
                  context.SendWebValue( edtPedidoId_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtPedidoId_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+((edtPessoaNome_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               if ( edtPessoaNome_Titleformat == 0 )
               {
                  context.SendWebValue( edtPessoaNome_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtPessoaNome_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+((edtPedidoDt_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               if ( edtPedidoDt_Titleformat == 0 )
               {
                  context.SendWebValue( edtPedidoDt_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtPedidoDt_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+((cmbPedidoStatus.Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               if ( cmbPedidoStatus_Titleformat == 0 )
               {
                  context.SendWebValue( cmbPedidoStatus.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( cmbPedidoStatus.Title.Text) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+((edtPedidoDtEntrega_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               if ( edtPedidoDtEntrega_Titleformat == 0 )
               {
                  context.SendWebValue( edtPedidoDtEntrega_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtPedidoDtEntrega_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"AttributeCheckBox"+"\" "+" style=\""+((chkPedidoRetirada.Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               if ( chkPedidoRetirada_Titleformat == 0 )
               {
                  context.SendWebValue( chkPedidoRetirada.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( chkPedidoRetirada.Title.Text) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+((edtPedidoTotal_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               if ( edtPedidoTotal_Titleformat == 0 )
               {
                  context.SendWebValue( edtPedidoTotal_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtPedidoTotal_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               GridContainer.AddObjectProperty("GridName", "Grid");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  GridContainer = new GXWebGrid( context);
               }
               else
               {
                  GridContainer.Clear();
               }
               GridContainer.SetWrapped(nGXWrapped);
               GridContainer.AddObjectProperty("GridName", "Grid");
               GridContainer.AddObjectProperty("Header", subGrid_Header);
               GridContainer.AddObjectProperty("Class", "GridWithPaginationBar GridNoBorder WorkWith");
               GridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Backcolorstyle), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Sortable", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Sortable), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("CmpContext", "");
               GridContainer.AddObjectProperty("InMasterPage", "false");
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( AV89Update));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUpdate_Enabled), 5, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( AV90Delete));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDelete_Enabled), 5, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( AV92Encerrar));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavEncerrar_Enabled), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( AV106Aprovar));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavAprovar_Enabled), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( AV107Reprovar));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavReprovar_Enabled), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A32PedidoId), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtPedidoId_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPedidoId_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPedidoId_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A2PessoaNome);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtPessoaNome_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPessoaNome_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPessoaNome_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A33PedidoDt, "99/99/99"));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtPedidoDt_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPedidoDt_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtPedidoDt_Link));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPedidoDt_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A34PedidoStatus);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( cmbPedidoStatus.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbPedidoStatus_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbPedidoStatus.Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A35PedidoDtEntrega, "99/99/99"));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtPedidoDtEntrega_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPedidoDtEntrega_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPedidoDtEntrega_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.BoolToStr( A36PedidoRetirada));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( chkPedidoRetirada.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkPedidoRetirada_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkPedidoRetirada.Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A37PedidoTotal, 18, 2, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtPedidoTotal_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPedidoTotal_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPedidoTotal_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Selectedindex), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Allowselection), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Selectioncolor), 9, 0, ".", "")));
               GridContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Allowhovering), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Hoveringcolor), 9, 0, ".", "")));
               GridContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Allowcollapsing), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 91 )
         {
            wbEnd = 0;
            nRC_GXsfl_91 = (short)(nGXsfl_91_idx-1);
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid", GridContainer);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "GridContainerData", GridContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "GridContainerData"+"V", GridContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"GridContainerData"+"V"+"\" value='"+GridContainer.GridValuesHidden()+"'/>") ;
               }
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* User Defined Control */
            ucGridpaginationbar.SetProperty("Class", Gridpaginationbar_Class);
            ucGridpaginationbar.SetProperty("ShowFirst", Gridpaginationbar_Showfirst);
            ucGridpaginationbar.SetProperty("ShowPrevious", Gridpaginationbar_Showprevious);
            ucGridpaginationbar.SetProperty("ShowNext", Gridpaginationbar_Shownext);
            ucGridpaginationbar.SetProperty("ShowLast", Gridpaginationbar_Showlast);
            ucGridpaginationbar.SetProperty("PagesToShow", Gridpaginationbar_Pagestoshow);
            ucGridpaginationbar.SetProperty("PagingButtonsPosition", Gridpaginationbar_Pagingbuttonsposition);
            ucGridpaginationbar.SetProperty("PagingCaptionPosition", Gridpaginationbar_Pagingcaptionposition);
            ucGridpaginationbar.SetProperty("EmptyGridClass", Gridpaginationbar_Emptygridclass);
            ucGridpaginationbar.SetProperty("RowsPerPageSelector", Gridpaginationbar_Rowsperpageselector);
            ucGridpaginationbar.SetProperty("RowsPerPageOptions", Gridpaginationbar_Rowsperpageoptions);
            ucGridpaginationbar.SetProperty("Previous", Gridpaginationbar_Previous);
            ucGridpaginationbar.SetProperty("Next", Gridpaginationbar_Next);
            ucGridpaginationbar.SetProperty("Caption", Gridpaginationbar_Caption);
            ucGridpaginationbar.SetProperty("EmptyGridCaption", Gridpaginationbar_Emptygridcaption);
            ucGridpaginationbar.SetProperty("RowsPerPageCaption", Gridpaginationbar_Rowsperpagecaption);
            ucGridpaginationbar.SetProperty("CurrentPage", AV87GridCurrentPage);
            ucGridpaginationbar.SetProperty("PageCount", AV88GridPageCount);
            ucGridpaginationbar.Render(context, "dvelop.dvpaginationbar", Gridpaginationbar_Internalname, "GRIDPAGINATIONBARContainer");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            GxWebStd.gx_div_start( context, divHtml_bottomauxiliarcontrols_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            ucDdo_pedidoid.SetProperty("Caption", Ddo_pedidoid_Caption);
            ucDdo_pedidoid.SetProperty("Tooltip", Ddo_pedidoid_Tooltip);
            ucDdo_pedidoid.SetProperty("Cls", Ddo_pedidoid_Cls);
            ucDdo_pedidoid.SetProperty("DropDownOptionsType", Ddo_pedidoid_Dropdownoptionstype);
            ucDdo_pedidoid.SetProperty("IncludeSortASC", Ddo_pedidoid_Includesortasc);
            ucDdo_pedidoid.SetProperty("IncludeSortDSC", Ddo_pedidoid_Includesortdsc);
            ucDdo_pedidoid.SetProperty("IncludeFilter", Ddo_pedidoid_Includefilter);
            ucDdo_pedidoid.SetProperty("FilterType", Ddo_pedidoid_Filtertype);
            ucDdo_pedidoid.SetProperty("FilterIsRange", Ddo_pedidoid_Filterisrange);
            ucDdo_pedidoid.SetProperty("IncludeDataList", Ddo_pedidoid_Includedatalist);
            ucDdo_pedidoid.SetProperty("SortASC", Ddo_pedidoid_Sortasc);
            ucDdo_pedidoid.SetProperty("SortDSC", Ddo_pedidoid_Sortdsc);
            ucDdo_pedidoid.SetProperty("CleanFilter", Ddo_pedidoid_Cleanfilter);
            ucDdo_pedidoid.SetProperty("RangeFilterFrom", Ddo_pedidoid_Rangefilterfrom);
            ucDdo_pedidoid.SetProperty("RangeFilterTo", Ddo_pedidoid_Rangefilterto);
            ucDdo_pedidoid.SetProperty("SearchButtonText", Ddo_pedidoid_Searchbuttontext);
            ucDdo_pedidoid.SetProperty("DropDownOptionsTitleSettingsIcons", AV85DDO_TitleSettingsIcons);
            ucDdo_pedidoid.SetProperty("DropDownOptionsData", AV58PedidoIdTitleFilterData);
            ucDdo_pedidoid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_pedidoid_Internalname, "DDO_PEDIDOIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 111,'',false,'" + sGXsfl_91_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_pedidoidtitlecontrolidtoreplace_Internalname, AV61ddo_PedidoIdTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,111);\"", 0, edtavDdo_pedidoidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_PedidoWW.htm");
            /* User Defined Control */
            ucDdo_pessoanome.SetProperty("Caption", Ddo_pessoanome_Caption);
            ucDdo_pessoanome.SetProperty("Tooltip", Ddo_pessoanome_Tooltip);
            ucDdo_pessoanome.SetProperty("Cls", Ddo_pessoanome_Cls);
            ucDdo_pessoanome.SetProperty("DropDownOptionsType", Ddo_pessoanome_Dropdownoptionstype);
            ucDdo_pessoanome.SetProperty("IncludeSortASC", Ddo_pessoanome_Includesortasc);
            ucDdo_pessoanome.SetProperty("IncludeSortDSC", Ddo_pessoanome_Includesortdsc);
            ucDdo_pessoanome.SetProperty("IncludeFilter", Ddo_pessoanome_Includefilter);
            ucDdo_pessoanome.SetProperty("FilterType", Ddo_pessoanome_Filtertype);
            ucDdo_pessoanome.SetProperty("FilterIsRange", Ddo_pessoanome_Filterisrange);
            ucDdo_pessoanome.SetProperty("IncludeDataList", Ddo_pessoanome_Includedatalist);
            ucDdo_pessoanome.SetProperty("DataListType", Ddo_pessoanome_Datalisttype);
            ucDdo_pessoanome.SetProperty("DataListProc", Ddo_pessoanome_Datalistproc);
            ucDdo_pessoanome.SetProperty("DataListUpdateMinimumCharacters", Ddo_pessoanome_Datalistupdateminimumcharacters);
            ucDdo_pessoanome.SetProperty("SortASC", Ddo_pessoanome_Sortasc);
            ucDdo_pessoanome.SetProperty("SortDSC", Ddo_pessoanome_Sortdsc);
            ucDdo_pessoanome.SetProperty("LoadingData", Ddo_pessoanome_Loadingdata);
            ucDdo_pessoanome.SetProperty("CleanFilter", Ddo_pessoanome_Cleanfilter);
            ucDdo_pessoanome.SetProperty("NoResultsFound", Ddo_pessoanome_Noresultsfound);
            ucDdo_pessoanome.SetProperty("SearchButtonText", Ddo_pessoanome_Searchbuttontext);
            ucDdo_pessoanome.SetProperty("DropDownOptionsTitleSettingsIcons", AV85DDO_TitleSettingsIcons);
            ucDdo_pessoanome.SetProperty("DropDownOptionsData", AV95PessoaNomeTitleFilterData);
            ucDdo_pessoanome.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_pessoanome_Internalname, "DDO_PESSOANOMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 113,'',false,'" + sGXsfl_91_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_pessoanometitlecontrolidtoreplace_Internalname, AV98ddo_PessoaNomeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,113);\"", 0, edtavDdo_pessoanometitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_PedidoWW.htm");
            /* User Defined Control */
            ucDdo_pedidodt.SetProperty("Caption", Ddo_pedidodt_Caption);
            ucDdo_pedidodt.SetProperty("Tooltip", Ddo_pedidodt_Tooltip);
            ucDdo_pedidodt.SetProperty("Cls", Ddo_pedidodt_Cls);
            ucDdo_pedidodt.SetProperty("DropDownOptionsType", Ddo_pedidodt_Dropdownoptionstype);
            ucDdo_pedidodt.SetProperty("IncludeSortASC", Ddo_pedidodt_Includesortasc);
            ucDdo_pedidodt.SetProperty("IncludeSortDSC", Ddo_pedidodt_Includesortdsc);
            ucDdo_pedidodt.SetProperty("IncludeFilter", Ddo_pedidodt_Includefilter);
            ucDdo_pedidodt.SetProperty("FilterType", Ddo_pedidodt_Filtertype);
            ucDdo_pedidodt.SetProperty("FilterIsRange", Ddo_pedidodt_Filterisrange);
            ucDdo_pedidodt.SetProperty("IncludeDataList", Ddo_pedidodt_Includedatalist);
            ucDdo_pedidodt.SetProperty("SortASC", Ddo_pedidodt_Sortasc);
            ucDdo_pedidodt.SetProperty("SortDSC", Ddo_pedidodt_Sortdsc);
            ucDdo_pedidodt.SetProperty("CleanFilter", Ddo_pedidodt_Cleanfilter);
            ucDdo_pedidodt.SetProperty("RangeFilterFrom", Ddo_pedidodt_Rangefilterfrom);
            ucDdo_pedidodt.SetProperty("RangeFilterTo", Ddo_pedidodt_Rangefilterto);
            ucDdo_pedidodt.SetProperty("SearchButtonText", Ddo_pedidodt_Searchbuttontext);
            ucDdo_pedidodt.SetProperty("DropDownOptionsTitleSettingsIcons", AV85DDO_TitleSettingsIcons);
            ucDdo_pedidodt.SetProperty("DropDownOptionsData", AV62PedidoDtTitleFilterData);
            ucDdo_pedidodt.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_pedidodt_Internalname, "DDO_PEDIDODTContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 115,'',false,'" + sGXsfl_91_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_pedidodttitlecontrolidtoreplace_Internalname, AV67ddo_PedidoDtTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,115);\"", 0, edtavDdo_pedidodttitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_PedidoWW.htm");
            /* User Defined Control */
            ucDdo_pedidostatus.SetProperty("Caption", Ddo_pedidostatus_Caption);
            ucDdo_pedidostatus.SetProperty("Tooltip", Ddo_pedidostatus_Tooltip);
            ucDdo_pedidostatus.SetProperty("Cls", Ddo_pedidostatus_Cls);
            ucDdo_pedidostatus.SetProperty("DropDownOptionsType", Ddo_pedidostatus_Dropdownoptionstype);
            ucDdo_pedidostatus.SetProperty("IncludeSortASC", Ddo_pedidostatus_Includesortasc);
            ucDdo_pedidostatus.SetProperty("IncludeSortDSC", Ddo_pedidostatus_Includesortdsc);
            ucDdo_pedidostatus.SetProperty("IncludeFilter", Ddo_pedidostatus_Includefilter);
            ucDdo_pedidostatus.SetProperty("IncludeDataList", Ddo_pedidostatus_Includedatalist);
            ucDdo_pedidostatus.SetProperty("DataListType", Ddo_pedidostatus_Datalisttype);
            ucDdo_pedidostatus.SetProperty("AllowMultipleSelection", Ddo_pedidostatus_Allowmultipleselection);
            ucDdo_pedidostatus.SetProperty("DataListFixedValues", Ddo_pedidostatus_Datalistfixedvalues);
            ucDdo_pedidostatus.SetProperty("SortASC", Ddo_pedidostatus_Sortasc);
            ucDdo_pedidostatus.SetProperty("SortDSC", Ddo_pedidostatus_Sortdsc);
            ucDdo_pedidostatus.SetProperty("CleanFilter", Ddo_pedidostatus_Cleanfilter);
            ucDdo_pedidostatus.SetProperty("SearchButtonText", Ddo_pedidostatus_Searchbuttontext);
            ucDdo_pedidostatus.SetProperty("DropDownOptionsTitleSettingsIcons", AV85DDO_TitleSettingsIcons);
            ucDdo_pedidostatus.SetProperty("DropDownOptionsData", AV68PedidoStatusTitleFilterData);
            ucDdo_pedidostatus.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_pedidostatus_Internalname, "DDO_PEDIDOSTATUSContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 117,'',false,'" + sGXsfl_91_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_pedidostatustitlecontrolidtoreplace_Internalname, AV71ddo_PedidoStatusTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,117);\"", 0, edtavDdo_pedidostatustitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_PedidoWW.htm");
            /* User Defined Control */
            ucDdo_pedidodtentrega.SetProperty("Caption", Ddo_pedidodtentrega_Caption);
            ucDdo_pedidodtentrega.SetProperty("Tooltip", Ddo_pedidodtentrega_Tooltip);
            ucDdo_pedidodtentrega.SetProperty("Cls", Ddo_pedidodtentrega_Cls);
            ucDdo_pedidodtentrega.SetProperty("DropDownOptionsType", Ddo_pedidodtentrega_Dropdownoptionstype);
            ucDdo_pedidodtentrega.SetProperty("IncludeSortASC", Ddo_pedidodtentrega_Includesortasc);
            ucDdo_pedidodtentrega.SetProperty("IncludeSortDSC", Ddo_pedidodtentrega_Includesortdsc);
            ucDdo_pedidodtentrega.SetProperty("IncludeFilter", Ddo_pedidodtentrega_Includefilter);
            ucDdo_pedidodtentrega.SetProperty("FilterType", Ddo_pedidodtentrega_Filtertype);
            ucDdo_pedidodtentrega.SetProperty("FilterIsRange", Ddo_pedidodtentrega_Filterisrange);
            ucDdo_pedidodtentrega.SetProperty("IncludeDataList", Ddo_pedidodtentrega_Includedatalist);
            ucDdo_pedidodtentrega.SetProperty("SortASC", Ddo_pedidodtentrega_Sortasc);
            ucDdo_pedidodtentrega.SetProperty("SortDSC", Ddo_pedidodtentrega_Sortdsc);
            ucDdo_pedidodtentrega.SetProperty("CleanFilter", Ddo_pedidodtentrega_Cleanfilter);
            ucDdo_pedidodtentrega.SetProperty("RangeFilterFrom", Ddo_pedidodtentrega_Rangefilterfrom);
            ucDdo_pedidodtentrega.SetProperty("RangeFilterTo", Ddo_pedidodtentrega_Rangefilterto);
            ucDdo_pedidodtentrega.SetProperty("SearchButtonText", Ddo_pedidodtentrega_Searchbuttontext);
            ucDdo_pedidodtentrega.SetProperty("DropDownOptionsTitleSettingsIcons", AV85DDO_TitleSettingsIcons);
            ucDdo_pedidodtentrega.SetProperty("DropDownOptionsData", AV72PedidoDtEntregaTitleFilterData);
            ucDdo_pedidodtentrega.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_pedidodtentrega_Internalname, "DDO_PEDIDODTENTREGAContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 119,'',false,'" + sGXsfl_91_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_pedidodtentregatitlecontrolidtoreplace_Internalname, AV77ddo_PedidoDtEntregaTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,119);\"", 0, edtavDdo_pedidodtentregatitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_PedidoWW.htm");
            /* User Defined Control */
            ucDdo_pedidoretirada.SetProperty("Caption", Ddo_pedidoretirada_Caption);
            ucDdo_pedidoretirada.SetProperty("Tooltip", Ddo_pedidoretirada_Tooltip);
            ucDdo_pedidoretirada.SetProperty("Cls", Ddo_pedidoretirada_Cls);
            ucDdo_pedidoretirada.SetProperty("DropDownOptionsType", Ddo_pedidoretirada_Dropdownoptionstype);
            ucDdo_pedidoretirada.SetProperty("IncludeSortASC", Ddo_pedidoretirada_Includesortasc);
            ucDdo_pedidoretirada.SetProperty("IncludeSortDSC", Ddo_pedidoretirada_Includesortdsc);
            ucDdo_pedidoretirada.SetProperty("IncludeFilter", Ddo_pedidoretirada_Includefilter);
            ucDdo_pedidoretirada.SetProperty("IncludeDataList", Ddo_pedidoretirada_Includedatalist);
            ucDdo_pedidoretirada.SetProperty("DataListType", Ddo_pedidoretirada_Datalisttype);
            ucDdo_pedidoretirada.SetProperty("DataListFixedValues", Ddo_pedidoretirada_Datalistfixedvalues);
            ucDdo_pedidoretirada.SetProperty("SortASC", Ddo_pedidoretirada_Sortasc);
            ucDdo_pedidoretirada.SetProperty("SortDSC", Ddo_pedidoretirada_Sortdsc);
            ucDdo_pedidoretirada.SetProperty("CleanFilter", Ddo_pedidoretirada_Cleanfilter);
            ucDdo_pedidoretirada.SetProperty("SearchButtonText", Ddo_pedidoretirada_Searchbuttontext);
            ucDdo_pedidoretirada.SetProperty("DropDownOptionsTitleSettingsIcons", AV85DDO_TitleSettingsIcons);
            ucDdo_pedidoretirada.SetProperty("DropDownOptionsData", AV78PedidoRetiradaTitleFilterData);
            ucDdo_pedidoretirada.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_pedidoretirada_Internalname, "DDO_PEDIDORETIRADAContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 121,'',false,'" + sGXsfl_91_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_pedidoretiradatitlecontrolidtoreplace_Internalname, AV80ddo_PedidoRetiradaTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,121);\"", 0, edtavDdo_pedidoretiradatitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_PedidoWW.htm");
            /* User Defined Control */
            ucDdo_pedidototal.SetProperty("Caption", Ddo_pedidototal_Caption);
            ucDdo_pedidototal.SetProperty("Tooltip", Ddo_pedidototal_Tooltip);
            ucDdo_pedidototal.SetProperty("Cls", Ddo_pedidototal_Cls);
            ucDdo_pedidototal.SetProperty("DropDownOptionsType", Ddo_pedidototal_Dropdownoptionstype);
            ucDdo_pedidototal.SetProperty("IncludeSortASC", Ddo_pedidototal_Includesortasc);
            ucDdo_pedidototal.SetProperty("IncludeSortDSC", Ddo_pedidototal_Includesortdsc);
            ucDdo_pedidototal.SetProperty("IncludeFilter", Ddo_pedidototal_Includefilter);
            ucDdo_pedidototal.SetProperty("FilterType", Ddo_pedidototal_Filtertype);
            ucDdo_pedidototal.SetProperty("FilterIsRange", Ddo_pedidototal_Filterisrange);
            ucDdo_pedidototal.SetProperty("IncludeDataList", Ddo_pedidototal_Includedatalist);
            ucDdo_pedidototal.SetProperty("SortASC", Ddo_pedidototal_Sortasc);
            ucDdo_pedidototal.SetProperty("SortDSC", Ddo_pedidototal_Sortdsc);
            ucDdo_pedidototal.SetProperty("CleanFilter", Ddo_pedidototal_Cleanfilter);
            ucDdo_pedidototal.SetProperty("RangeFilterFrom", Ddo_pedidototal_Rangefilterfrom);
            ucDdo_pedidototal.SetProperty("RangeFilterTo", Ddo_pedidototal_Rangefilterto);
            ucDdo_pedidototal.SetProperty("SearchButtonText", Ddo_pedidototal_Searchbuttontext);
            ucDdo_pedidototal.SetProperty("DropDownOptionsTitleSettingsIcons", AV85DDO_TitleSettingsIcons);
            ucDdo_pedidototal.SetProperty("DropDownOptionsData", AV81PedidoTotalTitleFilterData);
            ucDdo_pedidototal.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_pedidototal_Internalname, "DDO_PEDIDOTOTALContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 123,'',false,'" + sGXsfl_91_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_pedidototaltitlecontrolidtoreplace_Internalname, AV84ddo_PedidoTotalTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,123);\"", 0, edtavDdo_pedidototaltitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_PedidoWW.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities_f5", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* User Defined Control */
            ucDdo_gridcolumnsselector.SetProperty("Caption", Ddo_gridcolumnsselector_Caption);
            ucDdo_gridcolumnsselector.SetProperty("Tooltip", Ddo_gridcolumnsselector_Tooltip);
            ucDdo_gridcolumnsselector.SetProperty("Cls", Ddo_gridcolumnsselector_Cls);
            ucDdo_gridcolumnsselector.SetProperty("DropDownOptionsType", Ddo_gridcolumnsselector_Dropdownoptionstype);
            ucDdo_gridcolumnsselector.SetProperty("UpdateButtonText", Ddo_gridcolumnsselector_Updatebuttontext);
            ucDdo_gridcolumnsselector.SetProperty("DropDownOptionsTitleSettingsIcons", AV85DDO_TitleSettingsIcons);
            ucDdo_gridcolumnsselector.SetProperty("DropDownOptionsData", AV44ColumnsSelector);
            ucDdo_gridcolumnsselector.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_gridcolumnsselector_Internalname, "DDO_GRIDCOLUMNSSELECTORContainer");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 126,'',false,'" + sGXsfl_91_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,126);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PedidoWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 127,'',false,'" + sGXsfl_91_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV14OrderedDsc), StringUtil.BoolToStr( AV14OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,127);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_PedidoWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 128,'',false,'" + sGXsfl_91_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavManagefiltersexecutionstep_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV52ManageFiltersExecutionStep), 1, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV52ManageFiltersExecutionStep), "9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,128);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavManagefiltersexecutionstep_Jsonclick, 0, "Attribute", "", "", "", "", edtavManagefiltersexecutionstep_Visible, 1, 0, "number", "1", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PedidoWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 129,'',false,'" + sGXsfl_91_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfpedidoid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV59TFPedidoId), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV59TFPedidoId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,129);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfpedidoid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfpedidoid_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PedidoWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 130,'',false,'" + sGXsfl_91_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfpedidoid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV60TFPedidoId_To), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV60TFPedidoId_To), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,130);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfpedidoid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfpedidoid_to_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PedidoWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 131,'',false,'" + sGXsfl_91_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfpessoanome_Internalname, AV96TFPessoaNome, StringUtil.RTrim( context.localUtil.Format( AV96TFPessoaNome, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,131);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfpessoanome_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfpessoanome_Visible, 1, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_PedidoWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 132,'',false,'" + sGXsfl_91_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfpessoanome_sel_Internalname, AV97TFPessoaNome_Sel, StringUtil.RTrim( context.localUtil.Format( AV97TFPessoaNome_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,132);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfpessoanome_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfpessoanome_sel_Visible, 1, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_PedidoWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 133,'',false,'" + sGXsfl_91_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavTfpedidodt_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTfpedidodt_Internalname, context.localUtil.Format(AV63TFPedidoDt, "99/99/99"), context.localUtil.Format( AV63TFPedidoDt, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,133);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfpedidodt_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfpedidodt_Visible, 1, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PedidoWW.htm");
            GxWebStd.gx_bitmap( context, edtavTfpedidodt_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavTfpedidodt_Visible==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_PedidoWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 134,'',false,'" + sGXsfl_91_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavTfpedidodt_to_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTfpedidodt_to_Internalname, context.localUtil.Format(AV64TFPedidoDt_To, "99/99/99"), context.localUtil.Format( AV64TFPedidoDt_To, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,134);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfpedidodt_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfpedidodt_to_Visible, 1, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PedidoWW.htm");
            GxWebStd.gx_bitmap( context, edtavTfpedidodt_to_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavTfpedidodt_to_Visible==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_PedidoWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divDdo_pedidodtauxdates_Internalname, 1, 0, "px", 0, "px", "Invisible", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 136,'',false,'" + sGXsfl_91_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavDdo_pedidodtauxdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDdo_pedidodtauxdate_Internalname, context.localUtil.Format(AV65DDO_PedidoDtAuxDate, "99/99/99"), context.localUtil.Format( AV65DDO_PedidoDtAuxDate, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,136);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDdo_pedidodtauxdate_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PedidoWW.htm");
            GxWebStd.gx_bitmap( context, edtavDdo_pedidodtauxdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_PedidoWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 137,'',false,'" + sGXsfl_91_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavDdo_pedidodtauxdateto_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDdo_pedidodtauxdateto_Internalname, context.localUtil.Format(AV66DDO_PedidoDtAuxDateTo, "99/99/99"), context.localUtil.Format( AV66DDO_PedidoDtAuxDateTo, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,137);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDdo_pedidodtauxdateto_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PedidoWW.htm");
            GxWebStd.gx_bitmap( context, edtavDdo_pedidodtauxdateto_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_PedidoWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 138,'',false,'" + sGXsfl_91_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavTfpedidodtentrega_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTfpedidodtentrega_Internalname, context.localUtil.Format(AV73TFPedidoDtEntrega, "99/99/99"), context.localUtil.Format( AV73TFPedidoDtEntrega, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,138);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfpedidodtentrega_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfpedidodtentrega_Visible, 1, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PedidoWW.htm");
            GxWebStd.gx_bitmap( context, edtavTfpedidodtentrega_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavTfpedidodtentrega_Visible==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_PedidoWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 139,'',false,'" + sGXsfl_91_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavTfpedidodtentrega_to_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTfpedidodtentrega_to_Internalname, context.localUtil.Format(AV74TFPedidoDtEntrega_To, "99/99/99"), context.localUtil.Format( AV74TFPedidoDtEntrega_To, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,139);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfpedidodtentrega_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfpedidodtentrega_to_Visible, 1, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PedidoWW.htm");
            GxWebStd.gx_bitmap( context, edtavTfpedidodtentrega_to_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavTfpedidodtentrega_to_Visible==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_PedidoWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divDdo_pedidodtentregaauxdates_Internalname, 1, 0, "px", 0, "px", "Invisible", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 141,'',false,'" + sGXsfl_91_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavDdo_pedidodtentregaauxdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDdo_pedidodtentregaauxdate_Internalname, context.localUtil.Format(AV75DDO_PedidoDtEntregaAuxDate, "99/99/99"), context.localUtil.Format( AV75DDO_PedidoDtEntregaAuxDate, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,141);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDdo_pedidodtentregaauxdate_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PedidoWW.htm");
            GxWebStd.gx_bitmap( context, edtavDdo_pedidodtentregaauxdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_PedidoWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 142,'',false,'" + sGXsfl_91_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavDdo_pedidodtentregaauxdateto_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDdo_pedidodtentregaauxdateto_Internalname, context.localUtil.Format(AV76DDO_PedidoDtEntregaAuxDateTo, "99/99/99"), context.localUtil.Format( AV76DDO_PedidoDtEntregaAuxDateTo, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,142);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDdo_pedidodtentregaauxdateto_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PedidoWW.htm");
            GxWebStd.gx_bitmap( context, edtavDdo_pedidodtentregaauxdateto_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_PedidoWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 143,'',false,'" + sGXsfl_91_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfpedidoretirada_sel_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV79TFPedidoRetirada_Sel), 1, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV79TFPedidoRetirada_Sel), "9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,143);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfpedidoretirada_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfpedidoretirada_sel_Visible, 1, 0, "number", "1", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PedidoWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 144,'',false,'" + sGXsfl_91_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfpedidototal_Internalname, StringUtil.LTrim( StringUtil.NToC( AV82TFPedidoTotal, 18, 2, ",", "")), StringUtil.LTrim( context.localUtil.Format( AV82TFPedidoTotal, "R$ Z,ZZZ,ZZ,ZZ9.99")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,144);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfpedidototal_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfpedidototal_Visible, 1, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PedidoWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 145,'',false,'" + sGXsfl_91_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfpedidototal_to_Internalname, StringUtil.LTrim( StringUtil.NToC( AV83TFPedidoTotal_To, 18, 2, ",", "")), StringUtil.LTrim( context.localUtil.Format( AV83TFPedidoTotal_To, "R$ Z,ZZZ,ZZ,ZZ9.99")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,145);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfpedidototal_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfpedidototal_to_Visible, 1, 0, "text", "", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PedidoWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 91 )
         {
            wbEnd = 0;
            if ( isFullAjaxMode( ) )
            {
               if ( GridContainer.GetWrapped() == 1 )
               {
                  context.WriteHtmlText( "</table>") ;
                  context.WriteHtmlText( "</div>") ;
               }
               else
               {
                  sStyleString = "";
                  context.WriteHtmlText( "<div id=\""+"GridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
                  context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid", GridContainer);
                  if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "GridContainerData", GridContainer.ToJavascriptSource());
                  }
                  if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "GridContainerData"+"V", GridContainer.GridValuesHidden());
                  }
                  else
                  {
                     context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"GridContainerData"+"V"+"\" value='"+GridContainer.GridValuesHidden()+"'/>") ;
                  }
               }
            }
         }
         wbLoad = true;
      }

      protected void START132( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_2-131213", 0) ;
            Form.Meta.addItem("description", " Pedido", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP130( ) ;
      }

      protected void WS132( )
      {
         START132( ) ;
         EVT132( ) ;
      }

      protected void EVT132( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
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
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_MANAGEFILTERS.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E11132 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E12132 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E13132 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PEDIDOID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E14132 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PESSOANOME.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E15132 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PEDIDODT.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E16132 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PEDIDOSTATUS.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E17132 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PEDIDODTENTREGA.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E18132 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PEDIDORETIRADA.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E19132 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PEDIDOTOTAL.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E20132 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_GRIDCOLUMNSSELECTOR.ONCOLUMNSCHANGED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E21132 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoInsert' */
                              E22132 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 14), "VAPROVAR.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 15), "VENCERRAR.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 15), "VREPROVAR.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 15), "VENCERRAR.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 14), "VAPROVAR.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 15), "VREPROVAR.CLICK") == 0 ) )
                           {
                              nGXsfl_91_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_91_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_91_idx), 4, 0)), 4, "0");
                              SubsflControlProps_912( ) ;
                              AV89Update = cgiGet( edtavUpdate_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUpdate_Internalname, AV89Update);
                              AV90Delete = cgiGet( edtavDelete_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDelete_Internalname, AV90Delete);
                              AV92Encerrar = cgiGet( edtavEncerrar_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavEncerrar_Internalname, AV92Encerrar);
                              AV106Aprovar = cgiGet( edtavAprovar_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavAprovar_Internalname, AV106Aprovar);
                              AV107Reprovar = cgiGet( edtavReprovar_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavReprovar_Internalname, AV107Reprovar);
                              A32PedidoId = (short)(context.localUtil.CToN( cgiGet( edtPedidoId_Internalname), ",", "."));
                              A2PessoaNome = cgiGet( edtPessoaNome_Internalname);
                              A33PedidoDt = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtPedidoDt_Internalname), 0));
                              cmbPedidoStatus.Name = cmbPedidoStatus_Internalname;
                              cmbPedidoStatus.CurrentValue = cgiGet( cmbPedidoStatus_Internalname);
                              A34PedidoStatus = cgiGet( cmbPedidoStatus_Internalname);
                              A35PedidoDtEntrega = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtPedidoDtEntrega_Internalname), 0));
                              A36PedidoRetirada = StringUtil.StrToBool( cgiGet( chkPedidoRetirada_Internalname));
                              A37PedidoTotal = context.localUtil.CToN( cgiGet( edtPedidoTotal_Internalname), ",", ".");
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E23132 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E24132 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E25132 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "VAPROVAR.CLICK") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E26132 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "VENCERRAR.CLICK") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E27132 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "VREPROVAR.CLICK") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E28132 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Pessoanomeoperator Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vPESSOANOMEOPERATOR"), ",", ".") != Convert.ToDecimal( AV93PessoaNomeOperator )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Pessoanome Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vPESSOANOME"), AV94PessoaNome) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Pedidodt Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vPEDIDODT"), 0) != AV99PedidoDt )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Pedidodt_to Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vPEDIDODT_TO"), 0) != AV100PedidoDt_To )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Pedidodtentrega Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vPEDIDODTENTREGA"), 0) != AV101PedidoDtEntrega )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Pedidodtentrega_to Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vPEDIDODTENTREGA_TO"), 0) != AV102PedidoDtEntrega_To )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Pedidostatus Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vPEDIDOSTATUS"), AV103PedidoStatus) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Orderedby Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ",", ".") != Convert.ToDecimal( AV13OrderedBy )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ordereddsc Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV14OrderedDsc )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfpedidoid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFPEDIDOID"), ",", ".") != Convert.ToDecimal( AV59TFPedidoId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfpedidoid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFPEDIDOID_TO"), ",", ".") != Convert.ToDecimal( AV60TFPedidoId_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfpessoanome Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFPESSOANOME"), AV96TFPessoaNome) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfpessoanome_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFPESSOANOME_SEL"), AV97TFPessoaNome_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfpedidodt Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vTFPEDIDODT"), 0) != AV63TFPedidoDt )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfpedidodt_to Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vTFPEDIDODT_TO"), 0) != AV64TFPedidoDt_To )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfpedidodtentrega Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vTFPEDIDODTENTREGA"), 0) != AV73TFPedidoDtEntrega )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfpedidodtentrega_to Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vTFPEDIDODTENTREGA_TO"), 0) != AV74TFPedidoDtEntrega_To )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfpedidoretirada_sel Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFPEDIDORETIRADA_SEL"), ",", ".") != Convert.ToDecimal( AV79TFPedidoRetirada_Sel )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfpedidototal Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFPEDIDOTOTAL"), ",", ".") != AV82TFPedidoTotal )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfpedidototal_to Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFPEDIDOTOTAL_TO"), ",", ".") != AV83TFPedidoTotal_To )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                       }
                                       dynload_actions( ) ;
                                    }
                                    /* No code required for Cancel button. It is implemented as the Reset button. */
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                 }
                              }
                              else
                              {
                              }
                           }
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE132( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA132( )
      {
         if ( nDonePA == 0 )
         {
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
            if ( ! context.isAjaxRequest( ) )
            {
               GX_FocusControl = cmbavPessoanomeoperator_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_912( ) ;
         while ( nGXsfl_91_idx <= nRC_GXsfl_91 )
         {
            sendrow_912( ) ;
            nGXsfl_91_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_91_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_91_idx+1));
            sGXsfl_91_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_91_idx), 4, 0)), 4, "0");
            SubsflControlProps_912( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       short AV93PessoaNomeOperator ,
                                       String AV94PessoaNome ,
                                       DateTime AV99PedidoDt ,
                                       DateTime AV100PedidoDt_To ,
                                       DateTime AV101PedidoDtEntrega ,
                                       DateTime AV102PedidoDtEntrega_To ,
                                       String AV103PedidoStatus ,
                                       short AV13OrderedBy ,
                                       bool AV14OrderedDsc ,
                                       short AV59TFPedidoId ,
                                       short AV60TFPedidoId_To ,
                                       String AV96TFPessoaNome ,
                                       String AV97TFPessoaNome_Sel ,
                                       DateTime AV63TFPedidoDt ,
                                       DateTime AV64TFPedidoDt_To ,
                                       DateTime AV73TFPedidoDtEntrega ,
                                       DateTime AV74TFPedidoDtEntrega_To ,
                                       short AV79TFPedidoRetirada_Sel ,
                                       decimal AV82TFPedidoTotal ,
                                       decimal AV83TFPedidoTotal_To ,
                                       short AV52ManageFiltersExecutionStep ,
                                       GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector AV44ColumnsSelector ,
                                       String AV61ddo_PedidoIdTitleControlIdToReplace ,
                                       String AV98ddo_PessoaNomeTitleControlIdToReplace ,
                                       String AV67ddo_PedidoDtTitleControlIdToReplace ,
                                       String AV71ddo_PedidoStatusTitleControlIdToReplace ,
                                       String AV77ddo_PedidoDtEntregaTitleControlIdToReplace ,
                                       String AV80ddo_PedidoRetiradaTitleControlIdToReplace ,
                                       String AV84ddo_PedidoTotalTitleControlIdToReplace ,
                                       GxSimpleCollection<String> AV70TFPedidoStatus_Sels ,
                                       String AV131Pgmname )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF132( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_PEDIDOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A32PedidoId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "PEDIDOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A32PedidoId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_PEDIDOSTATUS", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A34PedidoStatus, "")), context));
         GxWebStd.gx_hidden_field( context, "PEDIDOSTATUS", A34PedidoStatus);
      }

      protected void clear_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
            dynload_actions( ) ;
         }
      }

      protected void fix_multi_value_controls( )
      {
         if ( cmbavPessoanomeoperator.ItemCount > 0 )
         {
            AV93PessoaNomeOperator = (short)(NumberUtil.Val( cmbavPessoanomeoperator.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV93PessoaNomeOperator), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV93PessoaNomeOperator", StringUtil.LTrim( StringUtil.Str( (decimal)(AV93PessoaNomeOperator), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavPessoanomeoperator.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV93PessoaNomeOperator), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavPessoanomeoperator_Internalname, "Values", cmbavPessoanomeoperator.ToJavascriptSource(), true);
         }
         if ( cmbavPedidostatus.ItemCount > 0 )
         {
            AV103PedidoStatus = cmbavPedidostatus.getValidValue(AV103PedidoStatus);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV103PedidoStatus", AV103PedidoStatus);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavPedidostatus.CurrentValue = StringUtil.RTrim( AV103PedidoStatus);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavPedidostatus_Internalname, "Values", cmbavPedidostatus.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF132( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV131Pgmname = "PedidoWW";
         context.Gx_err = 0;
         edtavUpdate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Enabled), 5, 0)), !bGXsfl_91_Refreshing);
         edtavDelete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Enabled), 5, 0)), !bGXsfl_91_Refreshing);
         edtavEncerrar_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEncerrar_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavEncerrar_Enabled), 5, 0)), !bGXsfl_91_Refreshing);
         edtavAprovar_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavAprovar_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAprovar_Enabled), 5, 0)), !bGXsfl_91_Refreshing);
         edtavReprovar_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavReprovar_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavReprovar_Enabled), 5, 0)), !bGXsfl_91_Refreshing);
      }

      protected void RF132( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 91;
         /* Execute user event: Refresh */
         E24132 ();
         nGXsfl_91_idx = 1;
         sGXsfl_91_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_91_idx), 4, 0)), 4, "0");
         SubsflControlProps_912( ) ;
         bGXsfl_91_Refreshing = true;
         GridContainer.AddObjectProperty("GridName", "Grid");
         GridContainer.AddObjectProperty("CmpContext", "");
         GridContainer.AddObjectProperty("InMasterPage", "false");
         GridContainer.AddObjectProperty("Class", "GridWithPaginationBar GridNoBorder WorkWith");
         GridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         GridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         GridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Backcolorstyle), 1, 0, ".", "")));
         GridContainer.AddObjectProperty("Sortable", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Sortable), 1, 0, ".", "")));
         GridContainer.PageSize = subGrid_Recordsperpage( );
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_912( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 A34PedidoStatus ,
                                                 AV125PedidoWWDS_13_Tfpedidostatus_sels ,
                                                 AV93PessoaNomeOperator ,
                                                 AV113PedidoWWDS_1_Pessoanome ,
                                                 AV114PedidoWWDS_2_Pedidodt ,
                                                 AV115PedidoWWDS_3_Pedidodt_to ,
                                                 AV116PedidoWWDS_4_Pedidodtentrega ,
                                                 AV117PedidoWWDS_5_Pedidodtentrega_to ,
                                                 AV118PedidoWWDS_6_Pedidostatus ,
                                                 AV119PedidoWWDS_7_Tfpedidoid ,
                                                 AV120PedidoWWDS_8_Tfpedidoid_to ,
                                                 AV122PedidoWWDS_10_Tfpessoanome_sel ,
                                                 AV121PedidoWWDS_9_Tfpessoanome ,
                                                 AV123PedidoWWDS_11_Tfpedidodt ,
                                                 AV124PedidoWWDS_12_Tfpedidodt_to ,
                                                 AV125PedidoWWDS_13_Tfpedidostatus_sels.Count ,
                                                 AV126PedidoWWDS_14_Tfpedidodtentrega ,
                                                 AV127PedidoWWDS_15_Tfpedidodtentrega_to ,
                                                 AV128PedidoWWDS_16_Tfpedidoretirada_sel ,
                                                 AV129PedidoWWDS_17_Tfpedidototal ,
                                                 AV130PedidoWWDS_18_Tfpedidototal_to ,
                                                 A2PessoaNome ,
                                                 A33PedidoDt ,
                                                 A35PedidoDtEntrega ,
                                                 A32PedidoId ,
                                                 A36PedidoRetirada ,
                                                 A37PedidoTotal ,
                                                 AV13OrderedBy ,
                                                 AV14OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT,
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.INT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.DECIMAL, TypeConstants.DECIMAL,
                                                 TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV113PedidoWWDS_1_Pessoanome = StringUtil.Concat( StringUtil.RTrim( AV113PedidoWWDS_1_Pessoanome), "%", "");
            lV121PedidoWWDS_9_Tfpessoanome = StringUtil.Concat( StringUtil.RTrim( AV121PedidoWWDS_9_Tfpessoanome), "%", "");
            /* Using cursor H00132 */
            pr_default.execute(0, new Object[] {lV113PedidoWWDS_1_Pessoanome, AV114PedidoWWDS_2_Pedidodt, AV115PedidoWWDS_3_Pedidodt_to, AV116PedidoWWDS_4_Pedidodtentrega, AV117PedidoWWDS_5_Pedidodtentrega_to, AV118PedidoWWDS_6_Pedidostatus, AV119PedidoWWDS_7_Tfpedidoid, AV120PedidoWWDS_8_Tfpedidoid_to, lV121PedidoWWDS_9_Tfpessoanome, AV122PedidoWWDS_10_Tfpessoanome_sel, AV123PedidoWWDS_11_Tfpedidodt, AV124PedidoWWDS_12_Tfpedidodt_to, AV126PedidoWWDS_14_Tfpedidodtentrega, AV127PedidoWWDS_15_Tfpedidodtentrega_to, AV129PedidoWWDS_17_Tfpedidototal, AV130PedidoWWDS_18_Tfpedidototal_to, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_91_idx = 1;
            sGXsfl_91_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_91_idx), 4, 0)), 4, "0");
            SubsflControlProps_912( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A1PessoaId = H00132_A1PessoaId[0];
               A37PedidoTotal = H00132_A37PedidoTotal[0];
               A36PedidoRetirada = H00132_A36PedidoRetirada[0];
               A35PedidoDtEntrega = H00132_A35PedidoDtEntrega[0];
               A34PedidoStatus = H00132_A34PedidoStatus[0];
               A33PedidoDt = H00132_A33PedidoDt[0];
               A2PessoaNome = H00132_A2PessoaNome[0];
               A32PedidoId = H00132_A32PedidoId[0];
               A2PessoaNome = H00132_A2PessoaNome[0];
               E25132 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 91;
            WB130( ) ;
         }
         bGXsfl_91_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes132( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_PEDIDOID"+"_"+sGXsfl_91_idx, GetSecureSignedToken( sGXsfl_91_idx, context.localUtil.Format( (decimal)(A32PedidoId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_PEDIDOSTATUS"+"_"+sGXsfl_91_idx, GetSecureSignedToken( sGXsfl_91_idx, StringUtil.RTrim( context.localUtil.Format( A34PedidoStatus, "")), context));
      }

      protected int subGrid_Pagecount( )
      {
         GRID_nRecordCount = subGrid_Recordcount( );
         if ( ((int)((GRID_nRecordCount) % (subGrid_Recordsperpage( )))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID_nRecordCount/ (decimal)(subGrid_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID_nRecordCount/ (decimal)(subGrid_Recordsperpage( ))))+1) ;
      }

      protected int subGrid_Recordcount( )
      {
         AV113PedidoWWDS_1_Pessoanome = AV94PessoaNome;
         AV114PedidoWWDS_2_Pedidodt = AV99PedidoDt;
         AV115PedidoWWDS_3_Pedidodt_to = AV100PedidoDt_To;
         AV116PedidoWWDS_4_Pedidodtentrega = AV101PedidoDtEntrega;
         AV117PedidoWWDS_5_Pedidodtentrega_to = AV102PedidoDtEntrega_To;
         AV118PedidoWWDS_6_Pedidostatus = AV103PedidoStatus;
         AV119PedidoWWDS_7_Tfpedidoid = AV59TFPedidoId;
         AV120PedidoWWDS_8_Tfpedidoid_to = AV60TFPedidoId_To;
         AV121PedidoWWDS_9_Tfpessoanome = AV96TFPessoaNome;
         AV122PedidoWWDS_10_Tfpessoanome_sel = AV97TFPessoaNome_Sel;
         AV123PedidoWWDS_11_Tfpedidodt = AV63TFPedidoDt;
         AV124PedidoWWDS_12_Tfpedidodt_to = AV64TFPedidoDt_To;
         AV125PedidoWWDS_13_Tfpedidostatus_sels = AV70TFPedidoStatus_Sels;
         AV126PedidoWWDS_14_Tfpedidodtentrega = AV73TFPedidoDtEntrega;
         AV127PedidoWWDS_15_Tfpedidodtentrega_to = AV74TFPedidoDtEntrega_To;
         AV128PedidoWWDS_16_Tfpedidoretirada_sel = AV79TFPedidoRetirada_Sel;
         AV129PedidoWWDS_17_Tfpedidototal = AV82TFPedidoTotal;
         AV130PedidoWWDS_18_Tfpedidototal_to = AV83TFPedidoTotal_To;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              A34PedidoStatus ,
                                              AV125PedidoWWDS_13_Tfpedidostatus_sels ,
                                              AV93PessoaNomeOperator ,
                                              AV113PedidoWWDS_1_Pessoanome ,
                                              AV114PedidoWWDS_2_Pedidodt ,
                                              AV115PedidoWWDS_3_Pedidodt_to ,
                                              AV116PedidoWWDS_4_Pedidodtentrega ,
                                              AV117PedidoWWDS_5_Pedidodtentrega_to ,
                                              AV118PedidoWWDS_6_Pedidostatus ,
                                              AV119PedidoWWDS_7_Tfpedidoid ,
                                              AV120PedidoWWDS_8_Tfpedidoid_to ,
                                              AV122PedidoWWDS_10_Tfpessoanome_sel ,
                                              AV121PedidoWWDS_9_Tfpessoanome ,
                                              AV123PedidoWWDS_11_Tfpedidodt ,
                                              AV124PedidoWWDS_12_Tfpedidodt_to ,
                                              AV125PedidoWWDS_13_Tfpedidostatus_sels.Count ,
                                              AV126PedidoWWDS_14_Tfpedidodtentrega ,
                                              AV127PedidoWWDS_15_Tfpedidodtentrega_to ,
                                              AV128PedidoWWDS_16_Tfpedidoretirada_sel ,
                                              AV129PedidoWWDS_17_Tfpedidototal ,
                                              AV130PedidoWWDS_18_Tfpedidototal_to ,
                                              A2PessoaNome ,
                                              A33PedidoDt ,
                                              A35PedidoDtEntrega ,
                                              A32PedidoId ,
                                              A36PedidoRetirada ,
                                              A37PedidoTotal ,
                                              AV13OrderedBy ,
                                              AV14OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.INT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.DECIMAL, TypeConstants.DECIMAL,
                                              TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV113PedidoWWDS_1_Pessoanome = StringUtil.Concat( StringUtil.RTrim( AV113PedidoWWDS_1_Pessoanome), "%", "");
         lV121PedidoWWDS_9_Tfpessoanome = StringUtil.Concat( StringUtil.RTrim( AV121PedidoWWDS_9_Tfpessoanome), "%", "");
         /* Using cursor H00133 */
         pr_default.execute(1, new Object[] {lV113PedidoWWDS_1_Pessoanome, AV114PedidoWWDS_2_Pedidodt, AV115PedidoWWDS_3_Pedidodt_to, AV116PedidoWWDS_4_Pedidodtentrega, AV117PedidoWWDS_5_Pedidodtentrega_to, AV118PedidoWWDS_6_Pedidostatus, AV119PedidoWWDS_7_Tfpedidoid, AV120PedidoWWDS_8_Tfpedidoid_to, lV121PedidoWWDS_9_Tfpessoanome, AV122PedidoWWDS_10_Tfpessoanome_sel, AV123PedidoWWDS_11_Tfpedidodt, AV124PedidoWWDS_12_Tfpedidodt_to, AV126PedidoWWDS_14_Tfpedidodtentrega, AV127PedidoWWDS_15_Tfpedidodtentrega_to, AV129PedidoWWDS_17_Tfpedidototal, AV130PedidoWWDS_18_Tfpedidototal_to});
         GRID_nRecordCount = H00133_AGRID_nRecordCount[0];
         pr_default.close(1);
         return (int)(GRID_nRecordCount) ;
      }

      protected int subGrid_Recordsperpage( )
      {
         if ( subGrid_Rows > 0 )
         {
            return subGrid_Rows*1 ;
         }
         else
         {
            return (int)(-1) ;
         }
      }

      protected int subGrid_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRID_nFirstRecordOnPage/ (decimal)(subGrid_Recordsperpage( ))))+1) ;
      }

      protected short subgrid_firstpage( )
      {
         AV113PedidoWWDS_1_Pessoanome = AV94PessoaNome;
         AV114PedidoWWDS_2_Pedidodt = AV99PedidoDt;
         AV115PedidoWWDS_3_Pedidodt_to = AV100PedidoDt_To;
         AV116PedidoWWDS_4_Pedidodtentrega = AV101PedidoDtEntrega;
         AV117PedidoWWDS_5_Pedidodtentrega_to = AV102PedidoDtEntrega_To;
         AV118PedidoWWDS_6_Pedidostatus = AV103PedidoStatus;
         AV119PedidoWWDS_7_Tfpedidoid = AV59TFPedidoId;
         AV120PedidoWWDS_8_Tfpedidoid_to = AV60TFPedidoId_To;
         AV121PedidoWWDS_9_Tfpessoanome = AV96TFPessoaNome;
         AV122PedidoWWDS_10_Tfpessoanome_sel = AV97TFPessoaNome_Sel;
         AV123PedidoWWDS_11_Tfpedidodt = AV63TFPedidoDt;
         AV124PedidoWWDS_12_Tfpedidodt_to = AV64TFPedidoDt_To;
         AV125PedidoWWDS_13_Tfpedidostatus_sels = AV70TFPedidoStatus_Sels;
         AV126PedidoWWDS_14_Tfpedidodtentrega = AV73TFPedidoDtEntrega;
         AV127PedidoWWDS_15_Tfpedidodtentrega_to = AV74TFPedidoDtEntrega_To;
         AV128PedidoWWDS_16_Tfpedidoretirada_sel = AV79TFPedidoRetirada_Sel;
         AV129PedidoWWDS_17_Tfpedidototal = AV82TFPedidoTotal;
         AV130PedidoWWDS_18_Tfpedidototal_to = AV83TFPedidoTotal_To;
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV93PessoaNomeOperator, AV94PessoaNome, AV99PedidoDt, AV100PedidoDt_To, AV101PedidoDtEntrega, AV102PedidoDtEntrega_To, AV103PedidoStatus, AV13OrderedBy, AV14OrderedDsc, AV59TFPedidoId, AV60TFPedidoId_To, AV96TFPessoaNome, AV97TFPessoaNome_Sel, AV63TFPedidoDt, AV64TFPedidoDt_To, AV73TFPedidoDtEntrega, AV74TFPedidoDtEntrega_To, AV79TFPedidoRetirada_Sel, AV82TFPedidoTotal, AV83TFPedidoTotal_To, AV52ManageFiltersExecutionStep, AV44ColumnsSelector, AV61ddo_PedidoIdTitleControlIdToReplace, AV98ddo_PessoaNomeTitleControlIdToReplace, AV67ddo_PedidoDtTitleControlIdToReplace, AV71ddo_PedidoStatusTitleControlIdToReplace, AV77ddo_PedidoDtEntregaTitleControlIdToReplace, AV80ddo_PedidoRetiradaTitleControlIdToReplace, AV84ddo_PedidoTotalTitleControlIdToReplace, AV70TFPedidoStatus_Sels, AV131Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV113PedidoWWDS_1_Pessoanome = AV94PessoaNome;
         AV114PedidoWWDS_2_Pedidodt = AV99PedidoDt;
         AV115PedidoWWDS_3_Pedidodt_to = AV100PedidoDt_To;
         AV116PedidoWWDS_4_Pedidodtentrega = AV101PedidoDtEntrega;
         AV117PedidoWWDS_5_Pedidodtentrega_to = AV102PedidoDtEntrega_To;
         AV118PedidoWWDS_6_Pedidostatus = AV103PedidoStatus;
         AV119PedidoWWDS_7_Tfpedidoid = AV59TFPedidoId;
         AV120PedidoWWDS_8_Tfpedidoid_to = AV60TFPedidoId_To;
         AV121PedidoWWDS_9_Tfpessoanome = AV96TFPessoaNome;
         AV122PedidoWWDS_10_Tfpessoanome_sel = AV97TFPessoaNome_Sel;
         AV123PedidoWWDS_11_Tfpedidodt = AV63TFPedidoDt;
         AV124PedidoWWDS_12_Tfpedidodt_to = AV64TFPedidoDt_To;
         AV125PedidoWWDS_13_Tfpedidostatus_sels = AV70TFPedidoStatus_Sels;
         AV126PedidoWWDS_14_Tfpedidodtentrega = AV73TFPedidoDtEntrega;
         AV127PedidoWWDS_15_Tfpedidodtentrega_to = AV74TFPedidoDtEntrega_To;
         AV128PedidoWWDS_16_Tfpedidoretirada_sel = AV79TFPedidoRetirada_Sel;
         AV129PedidoWWDS_17_Tfpedidototal = AV82TFPedidoTotal;
         AV130PedidoWWDS_18_Tfpedidototal_to = AV83TFPedidoTotal_To;
         GRID_nRecordCount = subGrid_Recordcount( );
         if ( ( GRID_nRecordCount >= subGrid_Recordsperpage( ) ) && ( GRID_nEOF == 0 ) )
         {
            GRID_nFirstRecordOnPage = (long)(GRID_nFirstRecordOnPage+subGrid_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GridContainer.AddObjectProperty("GRID_nFirstRecordOnPage", GRID_nFirstRecordOnPage);
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV93PessoaNomeOperator, AV94PessoaNome, AV99PedidoDt, AV100PedidoDt_To, AV101PedidoDtEntrega, AV102PedidoDtEntrega_To, AV103PedidoStatus, AV13OrderedBy, AV14OrderedDsc, AV59TFPedidoId, AV60TFPedidoId_To, AV96TFPessoaNome, AV97TFPessoaNome_Sel, AV63TFPedidoDt, AV64TFPedidoDt_To, AV73TFPedidoDtEntrega, AV74TFPedidoDtEntrega_To, AV79TFPedidoRetirada_Sel, AV82TFPedidoTotal, AV83TFPedidoTotal_To, AV52ManageFiltersExecutionStep, AV44ColumnsSelector, AV61ddo_PedidoIdTitleControlIdToReplace, AV98ddo_PessoaNomeTitleControlIdToReplace, AV67ddo_PedidoDtTitleControlIdToReplace, AV71ddo_PedidoStatusTitleControlIdToReplace, AV77ddo_PedidoDtEntregaTitleControlIdToReplace, AV80ddo_PedidoRetiradaTitleControlIdToReplace, AV84ddo_PedidoTotalTitleControlIdToReplace, AV70TFPedidoStatus_Sels, AV131Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV113PedidoWWDS_1_Pessoanome = AV94PessoaNome;
         AV114PedidoWWDS_2_Pedidodt = AV99PedidoDt;
         AV115PedidoWWDS_3_Pedidodt_to = AV100PedidoDt_To;
         AV116PedidoWWDS_4_Pedidodtentrega = AV101PedidoDtEntrega;
         AV117PedidoWWDS_5_Pedidodtentrega_to = AV102PedidoDtEntrega_To;
         AV118PedidoWWDS_6_Pedidostatus = AV103PedidoStatus;
         AV119PedidoWWDS_7_Tfpedidoid = AV59TFPedidoId;
         AV120PedidoWWDS_8_Tfpedidoid_to = AV60TFPedidoId_To;
         AV121PedidoWWDS_9_Tfpessoanome = AV96TFPessoaNome;
         AV122PedidoWWDS_10_Tfpessoanome_sel = AV97TFPessoaNome_Sel;
         AV123PedidoWWDS_11_Tfpedidodt = AV63TFPedidoDt;
         AV124PedidoWWDS_12_Tfpedidodt_to = AV64TFPedidoDt_To;
         AV125PedidoWWDS_13_Tfpedidostatus_sels = AV70TFPedidoStatus_Sels;
         AV126PedidoWWDS_14_Tfpedidodtentrega = AV73TFPedidoDtEntrega;
         AV127PedidoWWDS_15_Tfpedidodtentrega_to = AV74TFPedidoDtEntrega_To;
         AV128PedidoWWDS_16_Tfpedidoretirada_sel = AV79TFPedidoRetirada_Sel;
         AV129PedidoWWDS_17_Tfpedidototal = AV82TFPedidoTotal;
         AV130PedidoWWDS_18_Tfpedidototal_to = AV83TFPedidoTotal_To;
         if ( GRID_nFirstRecordOnPage >= subGrid_Recordsperpage( ) )
         {
            GRID_nFirstRecordOnPage = (long)(GRID_nFirstRecordOnPage-subGrid_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV93PessoaNomeOperator, AV94PessoaNome, AV99PedidoDt, AV100PedidoDt_To, AV101PedidoDtEntrega, AV102PedidoDtEntrega_To, AV103PedidoStatus, AV13OrderedBy, AV14OrderedDsc, AV59TFPedidoId, AV60TFPedidoId_To, AV96TFPessoaNome, AV97TFPessoaNome_Sel, AV63TFPedidoDt, AV64TFPedidoDt_To, AV73TFPedidoDtEntrega, AV74TFPedidoDtEntrega_To, AV79TFPedidoRetirada_Sel, AV82TFPedidoTotal, AV83TFPedidoTotal_To, AV52ManageFiltersExecutionStep, AV44ColumnsSelector, AV61ddo_PedidoIdTitleControlIdToReplace, AV98ddo_PessoaNomeTitleControlIdToReplace, AV67ddo_PedidoDtTitleControlIdToReplace, AV71ddo_PedidoStatusTitleControlIdToReplace, AV77ddo_PedidoDtEntregaTitleControlIdToReplace, AV80ddo_PedidoRetiradaTitleControlIdToReplace, AV84ddo_PedidoTotalTitleControlIdToReplace, AV70TFPedidoStatus_Sels, AV131Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV113PedidoWWDS_1_Pessoanome = AV94PessoaNome;
         AV114PedidoWWDS_2_Pedidodt = AV99PedidoDt;
         AV115PedidoWWDS_3_Pedidodt_to = AV100PedidoDt_To;
         AV116PedidoWWDS_4_Pedidodtentrega = AV101PedidoDtEntrega;
         AV117PedidoWWDS_5_Pedidodtentrega_to = AV102PedidoDtEntrega_To;
         AV118PedidoWWDS_6_Pedidostatus = AV103PedidoStatus;
         AV119PedidoWWDS_7_Tfpedidoid = AV59TFPedidoId;
         AV120PedidoWWDS_8_Tfpedidoid_to = AV60TFPedidoId_To;
         AV121PedidoWWDS_9_Tfpessoanome = AV96TFPessoaNome;
         AV122PedidoWWDS_10_Tfpessoanome_sel = AV97TFPessoaNome_Sel;
         AV123PedidoWWDS_11_Tfpedidodt = AV63TFPedidoDt;
         AV124PedidoWWDS_12_Tfpedidodt_to = AV64TFPedidoDt_To;
         AV125PedidoWWDS_13_Tfpedidostatus_sels = AV70TFPedidoStatus_Sels;
         AV126PedidoWWDS_14_Tfpedidodtentrega = AV73TFPedidoDtEntrega;
         AV127PedidoWWDS_15_Tfpedidodtentrega_to = AV74TFPedidoDtEntrega_To;
         AV128PedidoWWDS_16_Tfpedidoretirada_sel = AV79TFPedidoRetirada_Sel;
         AV129PedidoWWDS_17_Tfpedidototal = AV82TFPedidoTotal;
         AV130PedidoWWDS_18_Tfpedidototal_to = AV83TFPedidoTotal_To;
         GRID_nRecordCount = subGrid_Recordcount( );
         if ( GRID_nRecordCount > subGrid_Recordsperpage( ) )
         {
            if ( ((int)((GRID_nRecordCount) % (subGrid_Recordsperpage( )))) == 0 )
            {
               GRID_nFirstRecordOnPage = (long)(GRID_nRecordCount-subGrid_Recordsperpage( ));
            }
            else
            {
               GRID_nFirstRecordOnPage = (long)(GRID_nRecordCount-((int)((GRID_nRecordCount) % (subGrid_Recordsperpage( )))));
            }
         }
         else
         {
            GRID_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV93PessoaNomeOperator, AV94PessoaNome, AV99PedidoDt, AV100PedidoDt_To, AV101PedidoDtEntrega, AV102PedidoDtEntrega_To, AV103PedidoStatus, AV13OrderedBy, AV14OrderedDsc, AV59TFPedidoId, AV60TFPedidoId_To, AV96TFPessoaNome, AV97TFPessoaNome_Sel, AV63TFPedidoDt, AV64TFPedidoDt_To, AV73TFPedidoDtEntrega, AV74TFPedidoDtEntrega_To, AV79TFPedidoRetirada_Sel, AV82TFPedidoTotal, AV83TFPedidoTotal_To, AV52ManageFiltersExecutionStep, AV44ColumnsSelector, AV61ddo_PedidoIdTitleControlIdToReplace, AV98ddo_PessoaNomeTitleControlIdToReplace, AV67ddo_PedidoDtTitleControlIdToReplace, AV71ddo_PedidoStatusTitleControlIdToReplace, AV77ddo_PedidoDtEntregaTitleControlIdToReplace, AV80ddo_PedidoRetiradaTitleControlIdToReplace, AV84ddo_PedidoTotalTitleControlIdToReplace, AV70TFPedidoStatus_Sels, AV131Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV113PedidoWWDS_1_Pessoanome = AV94PessoaNome;
         AV114PedidoWWDS_2_Pedidodt = AV99PedidoDt;
         AV115PedidoWWDS_3_Pedidodt_to = AV100PedidoDt_To;
         AV116PedidoWWDS_4_Pedidodtentrega = AV101PedidoDtEntrega;
         AV117PedidoWWDS_5_Pedidodtentrega_to = AV102PedidoDtEntrega_To;
         AV118PedidoWWDS_6_Pedidostatus = AV103PedidoStatus;
         AV119PedidoWWDS_7_Tfpedidoid = AV59TFPedidoId;
         AV120PedidoWWDS_8_Tfpedidoid_to = AV60TFPedidoId_To;
         AV121PedidoWWDS_9_Tfpessoanome = AV96TFPessoaNome;
         AV122PedidoWWDS_10_Tfpessoanome_sel = AV97TFPessoaNome_Sel;
         AV123PedidoWWDS_11_Tfpedidodt = AV63TFPedidoDt;
         AV124PedidoWWDS_12_Tfpedidodt_to = AV64TFPedidoDt_To;
         AV125PedidoWWDS_13_Tfpedidostatus_sels = AV70TFPedidoStatus_Sels;
         AV126PedidoWWDS_14_Tfpedidodtentrega = AV73TFPedidoDtEntrega;
         AV127PedidoWWDS_15_Tfpedidodtentrega_to = AV74TFPedidoDtEntrega_To;
         AV128PedidoWWDS_16_Tfpedidoretirada_sel = AV79TFPedidoRetirada_Sel;
         AV129PedidoWWDS_17_Tfpedidototal = AV82TFPedidoTotal;
         AV130PedidoWWDS_18_Tfpedidototal_to = AV83TFPedidoTotal_To;
         if ( nPageNo > 0 )
         {
            GRID_nFirstRecordOnPage = (long)(subGrid_Recordsperpage( )*(nPageNo-1));
         }
         else
         {
            GRID_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV93PessoaNomeOperator, AV94PessoaNome, AV99PedidoDt, AV100PedidoDt_To, AV101PedidoDtEntrega, AV102PedidoDtEntrega_To, AV103PedidoStatus, AV13OrderedBy, AV14OrderedDsc, AV59TFPedidoId, AV60TFPedidoId_To, AV96TFPessoaNome, AV97TFPessoaNome_Sel, AV63TFPedidoDt, AV64TFPedidoDt_To, AV73TFPedidoDtEntrega, AV74TFPedidoDtEntrega_To, AV79TFPedidoRetirada_Sel, AV82TFPedidoTotal, AV83TFPedidoTotal_To, AV52ManageFiltersExecutionStep, AV44ColumnsSelector, AV61ddo_PedidoIdTitleControlIdToReplace, AV98ddo_PessoaNomeTitleControlIdToReplace, AV67ddo_PedidoDtTitleControlIdToReplace, AV71ddo_PedidoStatusTitleControlIdToReplace, AV77ddo_PedidoDtEntregaTitleControlIdToReplace, AV80ddo_PedidoRetiradaTitleControlIdToReplace, AV84ddo_PedidoTotalTitleControlIdToReplace, AV70TFPedidoStatus_Sels, AV131Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP130( )
      {
         /* Before Start, stand alone formulas. */
         AV131Pgmname = "PedidoWW";
         context.Gx_err = 0;
         edtavUpdate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Enabled), 5, 0)), !bGXsfl_91_Refreshing);
         edtavDelete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Enabled), 5, 0)), !bGXsfl_91_Refreshing);
         edtavEncerrar_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEncerrar_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavEncerrar_Enabled), 5, 0)), !bGXsfl_91_Refreshing);
         edtavAprovar_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavAprovar_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAprovar_Enabled), 5, 0)), !bGXsfl_91_Refreshing);
         edtavReprovar_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavReprovar_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavReprovar_Enabled), 5, 0)), !bGXsfl_91_Refreshing);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E23132 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vMANAGEFILTERSDATA"), AV56ManageFiltersData);
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV85DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vPEDIDOIDTITLEFILTERDATA"), AV58PedidoIdTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPESSOANOMETITLEFILTERDATA"), AV95PessoaNomeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPEDIDODTTITLEFILTERDATA"), AV62PedidoDtTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPEDIDOSTATUSTITLEFILTERDATA"), AV68PedidoStatusTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPEDIDODTENTREGATITLEFILTERDATA"), AV72PedidoDtEntregaTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPEDIDORETIRADATITLEFILTERDATA"), AV78PedidoRetiradaTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPEDIDOTOTALTITLEFILTERDATA"), AV81PedidoTotalTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vCOLUMNSSELECTOR"), AV44ColumnsSelector);
            /* Read variables values. */
            cmbavPessoanomeoperator.Name = cmbavPessoanomeoperator_Internalname;
            cmbavPessoanomeoperator.CurrentValue = cgiGet( cmbavPessoanomeoperator_Internalname);
            AV93PessoaNomeOperator = (short)(NumberUtil.Val( cgiGet( cmbavPessoanomeoperator_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV93PessoaNomeOperator", StringUtil.LTrim( StringUtil.Str( (decimal)(AV93PessoaNomeOperator), 4, 0)));
            AV94PessoaNome = cgiGet( edtavPessoanome_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV94PessoaNome", AV94PessoaNome);
            if ( context.localUtil.VCDate( cgiGet( edtavPedidodt_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Pedido Dt"}), 1, "vPEDIDODT");
               GX_FocusControl = edtavPedidodt_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV99PedidoDt = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV99PedidoDt", context.localUtil.Format(AV99PedidoDt, "99/99/99"));
            }
            else
            {
               AV99PedidoDt = context.localUtil.CToD( cgiGet( edtavPedidodt_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV99PedidoDt", context.localUtil.Format(AV99PedidoDt, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavPedidodt_to_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Pedido Dt_To"}), 1, "vPEDIDODT_TO");
               GX_FocusControl = edtavPedidodt_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV100PedidoDt_To = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV100PedidoDt_To", context.localUtil.Format(AV100PedidoDt_To, "99/99/99"));
            }
            else
            {
               AV100PedidoDt_To = context.localUtil.CToD( cgiGet( edtavPedidodt_to_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV100PedidoDt_To", context.localUtil.Format(AV100PedidoDt_To, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavPedidodtentrega_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Pedido Dt Entrega"}), 1, "vPEDIDODTENTREGA");
               GX_FocusControl = edtavPedidodtentrega_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV101PedidoDtEntrega = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV101PedidoDtEntrega", context.localUtil.Format(AV101PedidoDtEntrega, "99/99/99"));
            }
            else
            {
               AV101PedidoDtEntrega = context.localUtil.CToD( cgiGet( edtavPedidodtentrega_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV101PedidoDtEntrega", context.localUtil.Format(AV101PedidoDtEntrega, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavPedidodtentrega_to_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Pedido Dt Entrega_To"}), 1, "vPEDIDODTENTREGA_TO");
               GX_FocusControl = edtavPedidodtentrega_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV102PedidoDtEntrega_To = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV102PedidoDtEntrega_To", context.localUtil.Format(AV102PedidoDtEntrega_To, "99/99/99"));
            }
            else
            {
               AV102PedidoDtEntrega_To = context.localUtil.CToD( cgiGet( edtavPedidodtentrega_to_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV102PedidoDtEntrega_To", context.localUtil.Format(AV102PedidoDtEntrega_To, "99/99/99"));
            }
            cmbavPedidostatus.Name = cmbavPedidostatus_Internalname;
            cmbavPedidostatus.CurrentValue = cgiGet( cmbavPedidostatus_Internalname);
            AV103PedidoStatus = cgiGet( cmbavPedidostatus_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV103PedidoStatus", AV103PedidoStatus);
            AV61ddo_PedidoIdTitleControlIdToReplace = cgiGet( edtavDdo_pedidoidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV61ddo_PedidoIdTitleControlIdToReplace", AV61ddo_PedidoIdTitleControlIdToReplace);
            AV98ddo_PessoaNomeTitleControlIdToReplace = cgiGet( edtavDdo_pessoanometitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV98ddo_PessoaNomeTitleControlIdToReplace", AV98ddo_PessoaNomeTitleControlIdToReplace);
            AV67ddo_PedidoDtTitleControlIdToReplace = cgiGet( edtavDdo_pedidodttitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV67ddo_PedidoDtTitleControlIdToReplace", AV67ddo_PedidoDtTitleControlIdToReplace);
            AV71ddo_PedidoStatusTitleControlIdToReplace = cgiGet( edtavDdo_pedidostatustitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV71ddo_PedidoStatusTitleControlIdToReplace", AV71ddo_PedidoStatusTitleControlIdToReplace);
            AV77ddo_PedidoDtEntregaTitleControlIdToReplace = cgiGet( edtavDdo_pedidodtentregatitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV77ddo_PedidoDtEntregaTitleControlIdToReplace", AV77ddo_PedidoDtEntregaTitleControlIdToReplace);
            AV80ddo_PedidoRetiradaTitleControlIdToReplace = cgiGet( edtavDdo_pedidoretiradatitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV80ddo_PedidoRetiradaTitleControlIdToReplace", AV80ddo_PedidoRetiradaTitleControlIdToReplace);
            AV84ddo_PedidoTotalTitleControlIdToReplace = cgiGet( edtavDdo_pedidototaltitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV84ddo_PedidoTotalTitleControlIdToReplace", AV84ddo_PedidoTotalTitleControlIdToReplace);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vORDEREDBY");
               GX_FocusControl = edtavOrderedby_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV13OrderedBy = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            }
            else
            {
               AV13OrderedBy = (short)(context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            }
            AV14OrderedDsc = StringUtil.StrToBool( cgiGet( edtavOrdereddsc_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavManagefiltersexecutionstep_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavManagefiltersexecutionstep_Internalname), ",", ".") > Convert.ToDecimal( 9 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vMANAGEFILTERSEXECUTIONSTEP");
               GX_FocusControl = edtavManagefiltersexecutionstep_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV52ManageFiltersExecutionStep = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV52ManageFiltersExecutionStep", StringUtil.Str( (decimal)(AV52ManageFiltersExecutionStep), 1, 0));
            }
            else
            {
               AV52ManageFiltersExecutionStep = (short)(context.localUtil.CToN( cgiGet( edtavManagefiltersexecutionstep_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV52ManageFiltersExecutionStep", StringUtil.Str( (decimal)(AV52ManageFiltersExecutionStep), 1, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfpedidoid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfpedidoid_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFPEDIDOID");
               GX_FocusControl = edtavTfpedidoid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV59TFPedidoId = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV59TFPedidoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV59TFPedidoId), 4, 0)));
            }
            else
            {
               AV59TFPedidoId = (short)(context.localUtil.CToN( cgiGet( edtavTfpedidoid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV59TFPedidoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV59TFPedidoId), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfpedidoid_to_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfpedidoid_to_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFPEDIDOID_TO");
               GX_FocusControl = edtavTfpedidoid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV60TFPedidoId_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60TFPedidoId_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV60TFPedidoId_To), 4, 0)));
            }
            else
            {
               AV60TFPedidoId_To = (short)(context.localUtil.CToN( cgiGet( edtavTfpedidoid_to_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60TFPedidoId_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV60TFPedidoId_To), 4, 0)));
            }
            AV96TFPessoaNome = cgiGet( edtavTfpessoanome_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV96TFPessoaNome", AV96TFPessoaNome);
            AV97TFPessoaNome_Sel = cgiGet( edtavTfpessoanome_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV97TFPessoaNome_Sel", AV97TFPessoaNome_Sel);
            if ( context.localUtil.VCDate( cgiGet( edtavTfpedidodt_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"TFPedido Dt"}), 1, "vTFPEDIDODT");
               GX_FocusControl = edtavTfpedidodt_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV63TFPedidoDt = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV63TFPedidoDt", context.localUtil.Format(AV63TFPedidoDt, "99/99/99"));
            }
            else
            {
               AV63TFPedidoDt = context.localUtil.CToD( cgiGet( edtavTfpedidodt_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV63TFPedidoDt", context.localUtil.Format(AV63TFPedidoDt, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavTfpedidodt_to_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"TFPedido Dt_To"}), 1, "vTFPEDIDODT_TO");
               GX_FocusControl = edtavTfpedidodt_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV64TFPedidoDt_To = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV64TFPedidoDt_To", context.localUtil.Format(AV64TFPedidoDt_To, "99/99/99"));
            }
            else
            {
               AV64TFPedidoDt_To = context.localUtil.CToD( cgiGet( edtavTfpedidodt_to_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV64TFPedidoDt_To", context.localUtil.Format(AV64TFPedidoDt_To, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavDdo_pedidodtauxdate_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"DDO_Pedido Dt Aux Date"}), 1, "vDDO_PEDIDODTAUXDATE");
               GX_FocusControl = edtavDdo_pedidodtauxdate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV65DDO_PedidoDtAuxDate = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV65DDO_PedidoDtAuxDate", context.localUtil.Format(AV65DDO_PedidoDtAuxDate, "99/99/99"));
            }
            else
            {
               AV65DDO_PedidoDtAuxDate = context.localUtil.CToD( cgiGet( edtavDdo_pedidodtauxdate_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV65DDO_PedidoDtAuxDate", context.localUtil.Format(AV65DDO_PedidoDtAuxDate, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavDdo_pedidodtauxdateto_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"DDO_Pedido Dt Aux Date To"}), 1, "vDDO_PEDIDODTAUXDATETO");
               GX_FocusControl = edtavDdo_pedidodtauxdateto_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV66DDO_PedidoDtAuxDateTo = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV66DDO_PedidoDtAuxDateTo", context.localUtil.Format(AV66DDO_PedidoDtAuxDateTo, "99/99/99"));
            }
            else
            {
               AV66DDO_PedidoDtAuxDateTo = context.localUtil.CToD( cgiGet( edtavDdo_pedidodtauxdateto_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV66DDO_PedidoDtAuxDateTo", context.localUtil.Format(AV66DDO_PedidoDtAuxDateTo, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavTfpedidodtentrega_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"TFPedido Dt Entrega"}), 1, "vTFPEDIDODTENTREGA");
               GX_FocusControl = edtavTfpedidodtentrega_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV73TFPedidoDtEntrega = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV73TFPedidoDtEntrega", context.localUtil.Format(AV73TFPedidoDtEntrega, "99/99/99"));
            }
            else
            {
               AV73TFPedidoDtEntrega = context.localUtil.CToD( cgiGet( edtavTfpedidodtentrega_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV73TFPedidoDtEntrega", context.localUtil.Format(AV73TFPedidoDtEntrega, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavTfpedidodtentrega_to_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"TFPedido Dt Entrega_To"}), 1, "vTFPEDIDODTENTREGA_TO");
               GX_FocusControl = edtavTfpedidodtentrega_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV74TFPedidoDtEntrega_To = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV74TFPedidoDtEntrega_To", context.localUtil.Format(AV74TFPedidoDtEntrega_To, "99/99/99"));
            }
            else
            {
               AV74TFPedidoDtEntrega_To = context.localUtil.CToD( cgiGet( edtavTfpedidodtentrega_to_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV74TFPedidoDtEntrega_To", context.localUtil.Format(AV74TFPedidoDtEntrega_To, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavDdo_pedidodtentregaauxdate_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"DDO_Pedido Dt Entrega Aux Date"}), 1, "vDDO_PEDIDODTENTREGAAUXDATE");
               GX_FocusControl = edtavDdo_pedidodtentregaauxdate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV75DDO_PedidoDtEntregaAuxDate = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV75DDO_PedidoDtEntregaAuxDate", context.localUtil.Format(AV75DDO_PedidoDtEntregaAuxDate, "99/99/99"));
            }
            else
            {
               AV75DDO_PedidoDtEntregaAuxDate = context.localUtil.CToD( cgiGet( edtavDdo_pedidodtentregaauxdate_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV75DDO_PedidoDtEntregaAuxDate", context.localUtil.Format(AV75DDO_PedidoDtEntregaAuxDate, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavDdo_pedidodtentregaauxdateto_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"DDO_Pedido Dt Entrega Aux Date To"}), 1, "vDDO_PEDIDODTENTREGAAUXDATETO");
               GX_FocusControl = edtavDdo_pedidodtentregaauxdateto_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV76DDO_PedidoDtEntregaAuxDateTo = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV76DDO_PedidoDtEntregaAuxDateTo", context.localUtil.Format(AV76DDO_PedidoDtEntregaAuxDateTo, "99/99/99"));
            }
            else
            {
               AV76DDO_PedidoDtEntregaAuxDateTo = context.localUtil.CToD( cgiGet( edtavDdo_pedidodtentregaauxdateto_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV76DDO_PedidoDtEntregaAuxDateTo", context.localUtil.Format(AV76DDO_PedidoDtEntregaAuxDateTo, "99/99/99"));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfpedidoretirada_sel_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfpedidoretirada_sel_Internalname), ",", ".") > Convert.ToDecimal( 9 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFPEDIDORETIRADA_SEL");
               GX_FocusControl = edtavTfpedidoretirada_sel_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV79TFPedidoRetirada_Sel = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV79TFPedidoRetirada_Sel", StringUtil.Str( (decimal)(AV79TFPedidoRetirada_Sel), 1, 0));
            }
            else
            {
               AV79TFPedidoRetirada_Sel = (short)(context.localUtil.CToN( cgiGet( edtavTfpedidoretirada_sel_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV79TFPedidoRetirada_Sel", StringUtil.Str( (decimal)(AV79TFPedidoRetirada_Sel), 1, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfpedidototal_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfpedidototal_Internalname), ",", ".") > 999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFPEDIDOTOTAL");
               GX_FocusControl = edtavTfpedidototal_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV82TFPedidoTotal = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV82TFPedidoTotal", StringUtil.LTrim( StringUtil.Str( AV82TFPedidoTotal, 12, 2)));
            }
            else
            {
               AV82TFPedidoTotal = context.localUtil.CToN( cgiGet( edtavTfpedidototal_Internalname), ",", ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV82TFPedidoTotal", StringUtil.LTrim( StringUtil.Str( AV82TFPedidoTotal, 12, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfpedidototal_to_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfpedidototal_to_Internalname), ",", ".") > 999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFPEDIDOTOTAL_TO");
               GX_FocusControl = edtavTfpedidototal_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV83TFPedidoTotal_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV83TFPedidoTotal_To", StringUtil.LTrim( StringUtil.Str( AV83TFPedidoTotal_To, 12, 2)));
            }
            else
            {
               AV83TFPedidoTotal_To = context.localUtil.CToN( cgiGet( edtavTfpedidototal_to_Internalname), ",", ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV83TFPedidoTotal_To", StringUtil.LTrim( StringUtil.Str( AV83TFPedidoTotal_To, 12, 2)));
            }
            /* Read saved values. */
            nRC_GXsfl_91 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_91"), ",", "."));
            AV87GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ",", "."));
            AV88GridPageCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGECOUNT"), ",", "."));
            GRID_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID_nFirstRecordOnPage"), ",", "."));
            GRID_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID_nEOF"), ",", "."));
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ",", "."));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Ddo_managefilters_Icon = cgiGet( "DDO_MANAGEFILTERS_Icon");
            Ddo_managefilters_Tooltip = cgiGet( "DDO_MANAGEFILTERS_Tooltip");
            Ddo_managefilters_Cls = cgiGet( "DDO_MANAGEFILTERS_Cls");
            Dvpanel_tableheader_Width = cgiGet( "DVPANEL_TABLEHEADER_Width");
            Dvpanel_tableheader_Cls = cgiGet( "DVPANEL_TABLEHEADER_Cls");
            Dvpanel_tableheader_Title = cgiGet( "DVPANEL_TABLEHEADER_Title");
            Dvpanel_tableheader_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Collapsible"));
            Dvpanel_tableheader_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Collapsed"));
            Dvpanel_tableheader_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Autowidth"));
            Dvpanel_tableheader_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Autoheight"));
            Dvpanel_tableheader_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Showcollapseicon"));
            Dvpanel_tableheader_Iconposition = cgiGet( "DVPANEL_TABLEHEADER_Iconposition");
            Dvpanel_tableheader_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Autoscroll"));
            Gridpaginationbar_Class = cgiGet( "GRIDPAGINATIONBAR_Class");
            Gridpaginationbar_Previous = cgiGet( "GRIDPAGINATIONBAR_Previous");
            Gridpaginationbar_Next = cgiGet( "GRIDPAGINATIONBAR_Next");
            Gridpaginationbar_Caption = cgiGet( "GRIDPAGINATIONBAR_Caption");
            Gridpaginationbar_Showfirst = StringUtil.StrToBool( cgiGet( "GRIDPAGINATIONBAR_Showfirst"));
            Gridpaginationbar_Showprevious = StringUtil.StrToBool( cgiGet( "GRIDPAGINATIONBAR_Showprevious"));
            Gridpaginationbar_Shownext = StringUtil.StrToBool( cgiGet( "GRIDPAGINATIONBAR_Shownext"));
            Gridpaginationbar_Showlast = StringUtil.StrToBool( cgiGet( "GRIDPAGINATIONBAR_Showlast"));
            Gridpaginationbar_Pagestoshow = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Pagestoshow"), ",", "."));
            Gridpaginationbar_Pagingbuttonsposition = cgiGet( "GRIDPAGINATIONBAR_Pagingbuttonsposition");
            Gridpaginationbar_Pagingcaptionposition = cgiGet( "GRIDPAGINATIONBAR_Pagingcaptionposition");
            Gridpaginationbar_Emptygridclass = cgiGet( "GRIDPAGINATIONBAR_Emptygridclass");
            Gridpaginationbar_Rowsperpageselector = StringUtil.StrToBool( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselector"));
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ",", "."));
            Gridpaginationbar_Rowsperpageoptions = cgiGet( "GRIDPAGINATIONBAR_Rowsperpageoptions");
            Gridpaginationbar_Emptygridcaption = cgiGet( "GRIDPAGINATIONBAR_Emptygridcaption");
            Gridpaginationbar_Rowsperpagecaption = cgiGet( "GRIDPAGINATIONBAR_Rowsperpagecaption");
            Ddo_pedidoid_Caption = cgiGet( "DDO_PEDIDOID_Caption");
            Ddo_pedidoid_Tooltip = cgiGet( "DDO_PEDIDOID_Tooltip");
            Ddo_pedidoid_Cls = cgiGet( "DDO_PEDIDOID_Cls");
            Ddo_pedidoid_Filteredtext_set = cgiGet( "DDO_PEDIDOID_Filteredtext_set");
            Ddo_pedidoid_Filteredtextto_set = cgiGet( "DDO_PEDIDOID_Filteredtextto_set");
            Ddo_pedidoid_Dropdownoptionstype = cgiGet( "DDO_PEDIDOID_Dropdownoptionstype");
            Ddo_pedidoid_Titlecontrolidtoreplace = cgiGet( "DDO_PEDIDOID_Titlecontrolidtoreplace");
            Ddo_pedidoid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PEDIDOID_Includesortasc"));
            Ddo_pedidoid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PEDIDOID_Includesortdsc"));
            Ddo_pedidoid_Sortedstatus = cgiGet( "DDO_PEDIDOID_Sortedstatus");
            Ddo_pedidoid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PEDIDOID_Includefilter"));
            Ddo_pedidoid_Filtertype = cgiGet( "DDO_PEDIDOID_Filtertype");
            Ddo_pedidoid_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_PEDIDOID_Filterisrange"));
            Ddo_pedidoid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PEDIDOID_Includedatalist"));
            Ddo_pedidoid_Sortasc = cgiGet( "DDO_PEDIDOID_Sortasc");
            Ddo_pedidoid_Sortdsc = cgiGet( "DDO_PEDIDOID_Sortdsc");
            Ddo_pedidoid_Cleanfilter = cgiGet( "DDO_PEDIDOID_Cleanfilter");
            Ddo_pedidoid_Rangefilterfrom = cgiGet( "DDO_PEDIDOID_Rangefilterfrom");
            Ddo_pedidoid_Rangefilterto = cgiGet( "DDO_PEDIDOID_Rangefilterto");
            Ddo_pedidoid_Searchbuttontext = cgiGet( "DDO_PEDIDOID_Searchbuttontext");
            Ddo_pessoanome_Caption = cgiGet( "DDO_PESSOANOME_Caption");
            Ddo_pessoanome_Tooltip = cgiGet( "DDO_PESSOANOME_Tooltip");
            Ddo_pessoanome_Cls = cgiGet( "DDO_PESSOANOME_Cls");
            Ddo_pessoanome_Filteredtext_set = cgiGet( "DDO_PESSOANOME_Filteredtext_set");
            Ddo_pessoanome_Selectedvalue_set = cgiGet( "DDO_PESSOANOME_Selectedvalue_set");
            Ddo_pessoanome_Dropdownoptionstype = cgiGet( "DDO_PESSOANOME_Dropdownoptionstype");
            Ddo_pessoanome_Titlecontrolidtoreplace = cgiGet( "DDO_PESSOANOME_Titlecontrolidtoreplace");
            Ddo_pessoanome_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PESSOANOME_Includesortasc"));
            Ddo_pessoanome_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PESSOANOME_Includesortdsc"));
            Ddo_pessoanome_Sortedstatus = cgiGet( "DDO_PESSOANOME_Sortedstatus");
            Ddo_pessoanome_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PESSOANOME_Includefilter"));
            Ddo_pessoanome_Filtertype = cgiGet( "DDO_PESSOANOME_Filtertype");
            Ddo_pessoanome_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_PESSOANOME_Filterisrange"));
            Ddo_pessoanome_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PESSOANOME_Includedatalist"));
            Ddo_pessoanome_Datalisttype = cgiGet( "DDO_PESSOANOME_Datalisttype");
            Ddo_pessoanome_Datalistproc = cgiGet( "DDO_PESSOANOME_Datalistproc");
            Ddo_pessoanome_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_PESSOANOME_Datalistupdateminimumcharacters"), ",", "."));
            Ddo_pessoanome_Sortasc = cgiGet( "DDO_PESSOANOME_Sortasc");
            Ddo_pessoanome_Sortdsc = cgiGet( "DDO_PESSOANOME_Sortdsc");
            Ddo_pessoanome_Loadingdata = cgiGet( "DDO_PESSOANOME_Loadingdata");
            Ddo_pessoanome_Cleanfilter = cgiGet( "DDO_PESSOANOME_Cleanfilter");
            Ddo_pessoanome_Noresultsfound = cgiGet( "DDO_PESSOANOME_Noresultsfound");
            Ddo_pessoanome_Searchbuttontext = cgiGet( "DDO_PESSOANOME_Searchbuttontext");
            Ddo_pedidodt_Caption = cgiGet( "DDO_PEDIDODT_Caption");
            Ddo_pedidodt_Tooltip = cgiGet( "DDO_PEDIDODT_Tooltip");
            Ddo_pedidodt_Cls = cgiGet( "DDO_PEDIDODT_Cls");
            Ddo_pedidodt_Filteredtext_set = cgiGet( "DDO_PEDIDODT_Filteredtext_set");
            Ddo_pedidodt_Filteredtextto_set = cgiGet( "DDO_PEDIDODT_Filteredtextto_set");
            Ddo_pedidodt_Dropdownoptionstype = cgiGet( "DDO_PEDIDODT_Dropdownoptionstype");
            Ddo_pedidodt_Titlecontrolidtoreplace = cgiGet( "DDO_PEDIDODT_Titlecontrolidtoreplace");
            Ddo_pedidodt_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PEDIDODT_Includesortasc"));
            Ddo_pedidodt_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PEDIDODT_Includesortdsc"));
            Ddo_pedidodt_Sortedstatus = cgiGet( "DDO_PEDIDODT_Sortedstatus");
            Ddo_pedidodt_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PEDIDODT_Includefilter"));
            Ddo_pedidodt_Filtertype = cgiGet( "DDO_PEDIDODT_Filtertype");
            Ddo_pedidodt_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_PEDIDODT_Filterisrange"));
            Ddo_pedidodt_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PEDIDODT_Includedatalist"));
            Ddo_pedidodt_Sortasc = cgiGet( "DDO_PEDIDODT_Sortasc");
            Ddo_pedidodt_Sortdsc = cgiGet( "DDO_PEDIDODT_Sortdsc");
            Ddo_pedidodt_Cleanfilter = cgiGet( "DDO_PEDIDODT_Cleanfilter");
            Ddo_pedidodt_Rangefilterfrom = cgiGet( "DDO_PEDIDODT_Rangefilterfrom");
            Ddo_pedidodt_Rangefilterto = cgiGet( "DDO_PEDIDODT_Rangefilterto");
            Ddo_pedidodt_Searchbuttontext = cgiGet( "DDO_PEDIDODT_Searchbuttontext");
            Ddo_pedidostatus_Caption = cgiGet( "DDO_PEDIDOSTATUS_Caption");
            Ddo_pedidostatus_Tooltip = cgiGet( "DDO_PEDIDOSTATUS_Tooltip");
            Ddo_pedidostatus_Cls = cgiGet( "DDO_PEDIDOSTATUS_Cls");
            Ddo_pedidostatus_Selectedvalue_set = cgiGet( "DDO_PEDIDOSTATUS_Selectedvalue_set");
            Ddo_pedidostatus_Dropdownoptionstype = cgiGet( "DDO_PEDIDOSTATUS_Dropdownoptionstype");
            Ddo_pedidostatus_Titlecontrolidtoreplace = cgiGet( "DDO_PEDIDOSTATUS_Titlecontrolidtoreplace");
            Ddo_pedidostatus_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PEDIDOSTATUS_Includesortasc"));
            Ddo_pedidostatus_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PEDIDOSTATUS_Includesortdsc"));
            Ddo_pedidostatus_Sortedstatus = cgiGet( "DDO_PEDIDOSTATUS_Sortedstatus");
            Ddo_pedidostatus_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PEDIDOSTATUS_Includefilter"));
            Ddo_pedidostatus_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PEDIDOSTATUS_Includedatalist"));
            Ddo_pedidostatus_Datalisttype = cgiGet( "DDO_PEDIDOSTATUS_Datalisttype");
            Ddo_pedidostatus_Allowmultipleselection = StringUtil.StrToBool( cgiGet( "DDO_PEDIDOSTATUS_Allowmultipleselection"));
            Ddo_pedidostatus_Datalistfixedvalues = cgiGet( "DDO_PEDIDOSTATUS_Datalistfixedvalues");
            Ddo_pedidostatus_Sortasc = cgiGet( "DDO_PEDIDOSTATUS_Sortasc");
            Ddo_pedidostatus_Sortdsc = cgiGet( "DDO_PEDIDOSTATUS_Sortdsc");
            Ddo_pedidostatus_Cleanfilter = cgiGet( "DDO_PEDIDOSTATUS_Cleanfilter");
            Ddo_pedidostatus_Searchbuttontext = cgiGet( "DDO_PEDIDOSTATUS_Searchbuttontext");
            Ddo_pedidodtentrega_Caption = cgiGet( "DDO_PEDIDODTENTREGA_Caption");
            Ddo_pedidodtentrega_Tooltip = cgiGet( "DDO_PEDIDODTENTREGA_Tooltip");
            Ddo_pedidodtentrega_Cls = cgiGet( "DDO_PEDIDODTENTREGA_Cls");
            Ddo_pedidodtentrega_Filteredtext_set = cgiGet( "DDO_PEDIDODTENTREGA_Filteredtext_set");
            Ddo_pedidodtentrega_Filteredtextto_set = cgiGet( "DDO_PEDIDODTENTREGA_Filteredtextto_set");
            Ddo_pedidodtentrega_Dropdownoptionstype = cgiGet( "DDO_PEDIDODTENTREGA_Dropdownoptionstype");
            Ddo_pedidodtentrega_Titlecontrolidtoreplace = cgiGet( "DDO_PEDIDODTENTREGA_Titlecontrolidtoreplace");
            Ddo_pedidodtentrega_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PEDIDODTENTREGA_Includesortasc"));
            Ddo_pedidodtentrega_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PEDIDODTENTREGA_Includesortdsc"));
            Ddo_pedidodtentrega_Sortedstatus = cgiGet( "DDO_PEDIDODTENTREGA_Sortedstatus");
            Ddo_pedidodtentrega_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PEDIDODTENTREGA_Includefilter"));
            Ddo_pedidodtentrega_Filtertype = cgiGet( "DDO_PEDIDODTENTREGA_Filtertype");
            Ddo_pedidodtentrega_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_PEDIDODTENTREGA_Filterisrange"));
            Ddo_pedidodtentrega_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PEDIDODTENTREGA_Includedatalist"));
            Ddo_pedidodtentrega_Sortasc = cgiGet( "DDO_PEDIDODTENTREGA_Sortasc");
            Ddo_pedidodtentrega_Sortdsc = cgiGet( "DDO_PEDIDODTENTREGA_Sortdsc");
            Ddo_pedidodtentrega_Cleanfilter = cgiGet( "DDO_PEDIDODTENTREGA_Cleanfilter");
            Ddo_pedidodtentrega_Rangefilterfrom = cgiGet( "DDO_PEDIDODTENTREGA_Rangefilterfrom");
            Ddo_pedidodtentrega_Rangefilterto = cgiGet( "DDO_PEDIDODTENTREGA_Rangefilterto");
            Ddo_pedidodtentrega_Searchbuttontext = cgiGet( "DDO_PEDIDODTENTREGA_Searchbuttontext");
            Ddo_pedidoretirada_Caption = cgiGet( "DDO_PEDIDORETIRADA_Caption");
            Ddo_pedidoretirada_Tooltip = cgiGet( "DDO_PEDIDORETIRADA_Tooltip");
            Ddo_pedidoretirada_Cls = cgiGet( "DDO_PEDIDORETIRADA_Cls");
            Ddo_pedidoretirada_Selectedvalue_set = cgiGet( "DDO_PEDIDORETIRADA_Selectedvalue_set");
            Ddo_pedidoretirada_Dropdownoptionstype = cgiGet( "DDO_PEDIDORETIRADA_Dropdownoptionstype");
            Ddo_pedidoretirada_Titlecontrolidtoreplace = cgiGet( "DDO_PEDIDORETIRADA_Titlecontrolidtoreplace");
            Ddo_pedidoretirada_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PEDIDORETIRADA_Includesortasc"));
            Ddo_pedidoretirada_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PEDIDORETIRADA_Includesortdsc"));
            Ddo_pedidoretirada_Sortedstatus = cgiGet( "DDO_PEDIDORETIRADA_Sortedstatus");
            Ddo_pedidoretirada_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PEDIDORETIRADA_Includefilter"));
            Ddo_pedidoretirada_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PEDIDORETIRADA_Includedatalist"));
            Ddo_pedidoretirada_Datalisttype = cgiGet( "DDO_PEDIDORETIRADA_Datalisttype");
            Ddo_pedidoretirada_Datalistfixedvalues = cgiGet( "DDO_PEDIDORETIRADA_Datalistfixedvalues");
            Ddo_pedidoretirada_Sortasc = cgiGet( "DDO_PEDIDORETIRADA_Sortasc");
            Ddo_pedidoretirada_Sortdsc = cgiGet( "DDO_PEDIDORETIRADA_Sortdsc");
            Ddo_pedidoretirada_Cleanfilter = cgiGet( "DDO_PEDIDORETIRADA_Cleanfilter");
            Ddo_pedidoretirada_Searchbuttontext = cgiGet( "DDO_PEDIDORETIRADA_Searchbuttontext");
            Ddo_pedidototal_Caption = cgiGet( "DDO_PEDIDOTOTAL_Caption");
            Ddo_pedidototal_Tooltip = cgiGet( "DDO_PEDIDOTOTAL_Tooltip");
            Ddo_pedidototal_Cls = cgiGet( "DDO_PEDIDOTOTAL_Cls");
            Ddo_pedidototal_Filteredtext_set = cgiGet( "DDO_PEDIDOTOTAL_Filteredtext_set");
            Ddo_pedidototal_Filteredtextto_set = cgiGet( "DDO_PEDIDOTOTAL_Filteredtextto_set");
            Ddo_pedidototal_Dropdownoptionstype = cgiGet( "DDO_PEDIDOTOTAL_Dropdownoptionstype");
            Ddo_pedidototal_Titlecontrolidtoreplace = cgiGet( "DDO_PEDIDOTOTAL_Titlecontrolidtoreplace");
            Ddo_pedidototal_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PEDIDOTOTAL_Includesortasc"));
            Ddo_pedidototal_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PEDIDOTOTAL_Includesortdsc"));
            Ddo_pedidototal_Sortedstatus = cgiGet( "DDO_PEDIDOTOTAL_Sortedstatus");
            Ddo_pedidototal_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PEDIDOTOTAL_Includefilter"));
            Ddo_pedidototal_Filtertype = cgiGet( "DDO_PEDIDOTOTAL_Filtertype");
            Ddo_pedidototal_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_PEDIDOTOTAL_Filterisrange"));
            Ddo_pedidototal_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PEDIDOTOTAL_Includedatalist"));
            Ddo_pedidototal_Sortasc = cgiGet( "DDO_PEDIDOTOTAL_Sortasc");
            Ddo_pedidototal_Sortdsc = cgiGet( "DDO_PEDIDOTOTAL_Sortdsc");
            Ddo_pedidototal_Cleanfilter = cgiGet( "DDO_PEDIDOTOTAL_Cleanfilter");
            Ddo_pedidototal_Rangefilterfrom = cgiGet( "DDO_PEDIDOTOTAL_Rangefilterfrom");
            Ddo_pedidototal_Rangefilterto = cgiGet( "DDO_PEDIDOTOTAL_Rangefilterto");
            Ddo_pedidototal_Searchbuttontext = cgiGet( "DDO_PEDIDOTOTAL_Searchbuttontext");
            Ddo_gridcolumnsselector_Caption = cgiGet( "DDO_GRIDCOLUMNSSELECTOR_Caption");
            Ddo_gridcolumnsselector_Tooltip = cgiGet( "DDO_GRIDCOLUMNSSELECTOR_Tooltip");
            Ddo_gridcolumnsselector_Cls = cgiGet( "DDO_GRIDCOLUMNSSELECTOR_Cls");
            Ddo_gridcolumnsselector_Dropdownoptionstype = cgiGet( "DDO_GRIDCOLUMNSSELECTOR_Dropdownoptionstype");
            Ddo_gridcolumnsselector_Titlecontrolidtoreplace = cgiGet( "DDO_GRIDCOLUMNSSELECTOR_Titlecontrolidtoreplace");
            Ddo_gridcolumnsselector_Updatebuttontext = cgiGet( "DDO_GRIDCOLUMNSSELECTOR_Updatebuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ",", "."));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ",", "."));
            Ddo_pedidoid_Activeeventkey = cgiGet( "DDO_PEDIDOID_Activeeventkey");
            Ddo_pedidoid_Filteredtext_get = cgiGet( "DDO_PEDIDOID_Filteredtext_get");
            Ddo_pedidoid_Filteredtextto_get = cgiGet( "DDO_PEDIDOID_Filteredtextto_get");
            Ddo_pessoanome_Activeeventkey = cgiGet( "DDO_PESSOANOME_Activeeventkey");
            Ddo_pessoanome_Filteredtext_get = cgiGet( "DDO_PESSOANOME_Filteredtext_get");
            Ddo_pessoanome_Selectedvalue_get = cgiGet( "DDO_PESSOANOME_Selectedvalue_get");
            Ddo_pedidodt_Activeeventkey = cgiGet( "DDO_PEDIDODT_Activeeventkey");
            Ddo_pedidodt_Filteredtext_get = cgiGet( "DDO_PEDIDODT_Filteredtext_get");
            Ddo_pedidodt_Filteredtextto_get = cgiGet( "DDO_PEDIDODT_Filteredtextto_get");
            Ddo_pedidostatus_Activeeventkey = cgiGet( "DDO_PEDIDOSTATUS_Activeeventkey");
            Ddo_pedidostatus_Selectedvalue_get = cgiGet( "DDO_PEDIDOSTATUS_Selectedvalue_get");
            Ddo_pedidodtentrega_Activeeventkey = cgiGet( "DDO_PEDIDODTENTREGA_Activeeventkey");
            Ddo_pedidodtentrega_Filteredtext_get = cgiGet( "DDO_PEDIDODTENTREGA_Filteredtext_get");
            Ddo_pedidodtentrega_Filteredtextto_get = cgiGet( "DDO_PEDIDODTENTREGA_Filteredtextto_get");
            Ddo_pedidoretirada_Activeeventkey = cgiGet( "DDO_PEDIDORETIRADA_Activeeventkey");
            Ddo_pedidoretirada_Selectedvalue_get = cgiGet( "DDO_PEDIDORETIRADA_Selectedvalue_get");
            Ddo_pedidototal_Activeeventkey = cgiGet( "DDO_PEDIDOTOTAL_Activeeventkey");
            Ddo_pedidototal_Filteredtext_get = cgiGet( "DDO_PEDIDOTOTAL_Filteredtext_get");
            Ddo_pedidototal_Filteredtextto_get = cgiGet( "DDO_PEDIDOTOTAL_Filteredtextto_get");
            Ddo_gridcolumnsselector_Columnsselectorvalues = cgiGet( "DDO_GRIDCOLUMNSSELECTOR_Columnsselectorvalues");
            Ddo_managefilters_Activeeventkey = cgiGet( "DDO_MANAGEFILTERS_Activeeventkey");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ",", "."));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vPESSOANOMEOPERATOR"), ",", ".") != Convert.ToDecimal( AV93PessoaNomeOperator )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vPESSOANOME"), AV94PessoaNome) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vPEDIDODT"), 2) != AV99PedidoDt )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vPEDIDODT_TO"), 2) != AV100PedidoDt_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vPEDIDODTENTREGA"), 2) != AV101PedidoDtEntrega )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vPEDIDODTENTREGA_TO"), 2) != AV102PedidoDtEntrega_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vPEDIDOSTATUS"), AV103PedidoStatus) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ",", ".") != Convert.ToDecimal( AV13OrderedBy )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV14OrderedDsc )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFPEDIDOID"), ",", ".") != Convert.ToDecimal( AV59TFPedidoId )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFPEDIDOID_TO"), ",", ".") != Convert.ToDecimal( AV60TFPedidoId_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFPESSOANOME"), AV96TFPessoaNome) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFPESSOANOME_SEL"), AV97TFPessoaNome_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vTFPEDIDODT"), 2) != AV63TFPedidoDt )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vTFPEDIDODT_TO"), 2) != AV64TFPedidoDt_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vTFPEDIDODTENTREGA"), 2) != AV73TFPedidoDtEntrega )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vTFPEDIDODTENTREGA_TO"), 2) != AV74TFPedidoDtEntrega_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFPEDIDORETIRADA_SEL"), ",", ".") != Convert.ToDecimal( AV79TFPedidoRetirada_Sel )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFPEDIDOTOTAL"), ",", ".") != AV82TFPedidoTotal )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFPEDIDOTOTAL_TO"), ",", ".") != AV83TFPedidoTotal_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E23132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E23132( )
      {
         /* Start Routine */
         subGrid_Rows = 10;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         if ( StringUtil.StrCmp(AV7HTTPRequest.Method, "GET") == 0 )
         {
            /* Execute user subroutine: 'LOADSAVEDFILTERS' */
            S112 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            edtavManagefiltersexecutionstep_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavManagefiltersexecutionstep_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavManagefiltersexecutionstep_Visible), 5, 0)), true);
         }
         AV103PedidoStatus = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV103PedidoStatus", AV103PedidoStatus);
         edtavTfpedidoid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfpedidoid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfpedidoid_Visible), 5, 0)), true);
         edtavTfpedidoid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfpedidoid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfpedidoid_to_Visible), 5, 0)), true);
         edtavTfpessoanome_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfpessoanome_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfpessoanome_Visible), 5, 0)), true);
         edtavTfpessoanome_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfpessoanome_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfpessoanome_sel_Visible), 5, 0)), true);
         edtavTfpedidodt_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfpedidodt_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfpedidodt_Visible), 5, 0)), true);
         edtavTfpedidodt_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfpedidodt_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfpedidodt_to_Visible), 5, 0)), true);
         edtavTfpedidodtentrega_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfpedidodtentrega_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfpedidodtentrega_Visible), 5, 0)), true);
         edtavTfpedidodtentrega_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfpedidodtentrega_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfpedidodtentrega_to_Visible), 5, 0)), true);
         edtavTfpedidoretirada_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfpedidoretirada_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfpedidoretirada_sel_Visible), 5, 0)), true);
         edtavTfpedidototal_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfpedidototal_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfpedidototal_Visible), 5, 0)), true);
         edtavTfpedidototal_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfpedidototal_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfpedidototal_to_Visible), 5, 0)), true);
         Ddo_pedidoid_Titlecontrolidtoreplace = subGrid_Internalname+"_PedidoId";
         ucDdo_pedidoid.SendProperty(context, "", false, Ddo_pedidoid_Internalname, "TitleControlIdToReplace", Ddo_pedidoid_Titlecontrolidtoreplace);
         AV61ddo_PedidoIdTitleControlIdToReplace = Ddo_pedidoid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV61ddo_PedidoIdTitleControlIdToReplace", AV61ddo_PedidoIdTitleControlIdToReplace);
         edtavDdo_pedidoidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_pedidoidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_pedidoidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_pessoanome_Titlecontrolidtoreplace = subGrid_Internalname+"_PessoaNome";
         ucDdo_pessoanome.SendProperty(context, "", false, Ddo_pessoanome_Internalname, "TitleControlIdToReplace", Ddo_pessoanome_Titlecontrolidtoreplace);
         AV98ddo_PessoaNomeTitleControlIdToReplace = Ddo_pessoanome_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV98ddo_PessoaNomeTitleControlIdToReplace", AV98ddo_PessoaNomeTitleControlIdToReplace);
         edtavDdo_pessoanometitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_pessoanometitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_pessoanometitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_pedidodt_Titlecontrolidtoreplace = subGrid_Internalname+"_PedidoDt";
         ucDdo_pedidodt.SendProperty(context, "", false, Ddo_pedidodt_Internalname, "TitleControlIdToReplace", Ddo_pedidodt_Titlecontrolidtoreplace);
         AV67ddo_PedidoDtTitleControlIdToReplace = Ddo_pedidodt_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV67ddo_PedidoDtTitleControlIdToReplace", AV67ddo_PedidoDtTitleControlIdToReplace);
         edtavDdo_pedidodttitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_pedidodttitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_pedidodttitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_pedidostatus_Titlecontrolidtoreplace = subGrid_Internalname+"_PedidoStatus";
         ucDdo_pedidostatus.SendProperty(context, "", false, Ddo_pedidostatus_Internalname, "TitleControlIdToReplace", Ddo_pedidostatus_Titlecontrolidtoreplace);
         AV71ddo_PedidoStatusTitleControlIdToReplace = Ddo_pedidostatus_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV71ddo_PedidoStatusTitleControlIdToReplace", AV71ddo_PedidoStatusTitleControlIdToReplace);
         edtavDdo_pedidostatustitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_pedidostatustitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_pedidostatustitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_pedidodtentrega_Titlecontrolidtoreplace = subGrid_Internalname+"_PedidoDtEntrega";
         ucDdo_pedidodtentrega.SendProperty(context, "", false, Ddo_pedidodtentrega_Internalname, "TitleControlIdToReplace", Ddo_pedidodtentrega_Titlecontrolidtoreplace);
         AV77ddo_PedidoDtEntregaTitleControlIdToReplace = Ddo_pedidodtentrega_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV77ddo_PedidoDtEntregaTitleControlIdToReplace", AV77ddo_PedidoDtEntregaTitleControlIdToReplace);
         edtavDdo_pedidodtentregatitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_pedidodtentregatitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_pedidodtentregatitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_pedidoretirada_Titlecontrolidtoreplace = subGrid_Internalname+"_PedidoRetirada";
         ucDdo_pedidoretirada.SendProperty(context, "", false, Ddo_pedidoretirada_Internalname, "TitleControlIdToReplace", Ddo_pedidoretirada_Titlecontrolidtoreplace);
         AV80ddo_PedidoRetiradaTitleControlIdToReplace = Ddo_pedidoretirada_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV80ddo_PedidoRetiradaTitleControlIdToReplace", AV80ddo_PedidoRetiradaTitleControlIdToReplace);
         edtavDdo_pedidoretiradatitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_pedidoretiradatitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_pedidoretiradatitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_pedidototal_Titlecontrolidtoreplace = subGrid_Internalname+"_PedidoTotal";
         ucDdo_pedidototal.SendProperty(context, "", false, Ddo_pedidototal_Internalname, "TitleControlIdToReplace", Ddo_pedidototal_Titlecontrolidtoreplace);
         AV84ddo_PedidoTotalTitleControlIdToReplace = Ddo_pedidototal_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV84ddo_PedidoTotalTitleControlIdToReplace", AV84ddo_PedidoTotalTitleControlIdToReplace);
         edtavDdo_pedidototaltitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_pedidototaltitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_pedidototaltitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = " Pedido";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         /* Execute user subroutine: 'PREPARETRANSACTION' */
         S122 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'LOADGRIDSTATE' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         edtavOrderedby_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOrderedby_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrderedby_Visible), 5, 0)), true);
         if ( AV13OrderedBy < 1 )
         {
            AV13OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            /* Execute user subroutine: 'SETDDOSORTEDSTATUS' */
            S142 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
         edtavOrdereddsc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOrdereddsc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrdereddsc_Visible), 5, 0)), true);
         Ddo_managefilters_Icon = context.convertURL( (String)(context.GetImagePath( "5efb9e2b-46db-43f4-8f74-dd3f5818d30e", "", context.GetTheme( ))));
         ucDdo_managefilters.SendProperty(context, "", false, Ddo_managefilters_Internalname, "Icon", Ddo_managefilters_Icon);
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV85DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV85DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Ddo_gridcolumnsselector_Titlecontrolidtoreplace = bttBtneditcolumns_Internalname;
         ucDdo_gridcolumnsselector.SendProperty(context, "", false, Ddo_gridcolumnsselector_Internalname, "TitleControlIdToReplace", Ddo_gridcolumnsselector_Titlecontrolidtoreplace);
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E24132( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV58PedidoIdTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV95PessoaNomeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV62PedidoDtTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV68PedidoStatusTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV72PedidoDtEntregaTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV78PedidoRetiradaTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV81PedidoTotalTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         if ( AV52ManageFiltersExecutionStep == 1 )
         {
            AV52ManageFiltersExecutionStep = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV52ManageFiltersExecutionStep", StringUtil.Str( (decimal)(AV52ManageFiltersExecutionStep), 1, 0));
         }
         else if ( AV52ManageFiltersExecutionStep == 2 )
         {
            AV52ManageFiltersExecutionStep = 0;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV52ManageFiltersExecutionStep", StringUtil.Str( (decimal)(AV52ManageFiltersExecutionStep), 1, 0));
            /* Execute user subroutine: 'LOADSAVEDFILTERS' */
            S112 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
         /* Execute user subroutine: 'SAVEGRIDSTATE' */
         S152 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         if ( StringUtil.StrCmp(AV51Session.Get("PedidoWWColumnsSelector"), "") != 0 )
         {
            AV32ColumnsSelectorXML = AV51Session.Get("PedidoWWColumnsSelector");
            AV44ColumnsSelector.FromXml(AV32ColumnsSelectorXML, null, "WWPColumnsSelector", "FMX");
         }
         else
         {
            /* Execute user subroutine: 'INITIALIZECOLUMNSSELECTOR' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
         edtPedidoId_Visible = (((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV44ColumnsSelector.gxTpr_Columns.Item(1)).gxTpr_Isvisible ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedidoId_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedidoId_Visible), 5, 0)), !bGXsfl_91_Refreshing);
         edtPessoaNome_Visible = (((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV44ColumnsSelector.gxTpr_Columns.Item(2)).gxTpr_Isvisible ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPessoaNome_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPessoaNome_Visible), 5, 0)), !bGXsfl_91_Refreshing);
         edtPedidoDt_Visible = (((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV44ColumnsSelector.gxTpr_Columns.Item(3)).gxTpr_Isvisible ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedidoDt_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedidoDt_Visible), 5, 0)), !bGXsfl_91_Refreshing);
         cmbPedidoStatus.Visible = (((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV44ColumnsSelector.gxTpr_Columns.Item(4)).gxTpr_Isvisible ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPedidoStatus_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbPedidoStatus.Visible), 5, 0)), !bGXsfl_91_Refreshing);
         edtPedidoDtEntrega_Visible = (((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV44ColumnsSelector.gxTpr_Columns.Item(5)).gxTpr_Isvisible ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedidoDtEntrega_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedidoDtEntrega_Visible), 5, 0)), !bGXsfl_91_Refreshing);
         chkPedidoRetirada.Visible = (((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV44ColumnsSelector.gxTpr_Columns.Item(6)).gxTpr_Isvisible ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkPedidoRetirada_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(chkPedidoRetirada.Visible), 5, 0)), !bGXsfl_91_Refreshing);
         edtPedidoTotal_Visible = (((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV44ColumnsSelector.gxTpr_Columns.Item(7)).gxTpr_Isvisible ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedidoTotal_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedidoTotal_Visible), 5, 0)), !bGXsfl_91_Refreshing);
         edtPedidoId_Titleformat = 2;
         edtPedidoId_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Número do Pedido", AV61ddo_PedidoIdTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedidoId_Internalname, "Title", edtPedidoId_Title, !bGXsfl_91_Refreshing);
         edtPessoaNome_Titleformat = 2;
         edtPessoaNome_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Nome", AV98ddo_PessoaNomeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPessoaNome_Internalname, "Title", edtPessoaNome_Title, !bGXsfl_91_Refreshing);
         edtPedidoDt_Titleformat = 2;
         edtPedidoDt_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Data do Pedido", AV67ddo_PedidoDtTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedidoDt_Internalname, "Title", edtPedidoDt_Title, !bGXsfl_91_Refreshing);
         cmbPedidoStatus_Titleformat = 2;
         cmbPedidoStatus.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Status", AV71ddo_PedidoStatusTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPedidoStatus_Internalname, "Title", cmbPedidoStatus.Title.Text, !bGXsfl_91_Refreshing);
         edtPedidoDtEntrega_Titleformat = 2;
         edtPedidoDtEntrega_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Data de Entrega", AV77ddo_PedidoDtEntregaTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedidoDtEntrega_Internalname, "Title", edtPedidoDtEntrega_Title, !bGXsfl_91_Refreshing);
         chkPedidoRetirada_Titleformat = 2;
         chkPedidoRetirada.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Retirar no Local?", AV80ddo_PedidoRetiradaTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkPedidoRetirada_Internalname, "Title", chkPedidoRetirada.Title.Text, !bGXsfl_91_Refreshing);
         edtPedidoTotal_Titleformat = 2;
         edtPedidoTotal_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Total", AV84ddo_PedidoTotalTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedidoTotal_Internalname, "Title", edtPedidoTotal_Title, !bGXsfl_91_Refreshing);
         AV87GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV87GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV87GridCurrentPage), 10, 0)));
         AV88GridPageCount = subGrid_Pagecount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV88GridPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV88GridPageCount), 10, 0)));
         AV113PedidoWWDS_1_Pessoanome = AV94PessoaNome;
         AV114PedidoWWDS_2_Pedidodt = AV99PedidoDt;
         AV115PedidoWWDS_3_Pedidodt_to = AV100PedidoDt_To;
         AV116PedidoWWDS_4_Pedidodtentrega = AV101PedidoDtEntrega;
         AV117PedidoWWDS_5_Pedidodtentrega_to = AV102PedidoDtEntrega_To;
         AV118PedidoWWDS_6_Pedidostatus = AV103PedidoStatus;
         AV119PedidoWWDS_7_Tfpedidoid = AV59TFPedidoId;
         AV120PedidoWWDS_8_Tfpedidoid_to = AV60TFPedidoId_To;
         AV121PedidoWWDS_9_Tfpessoanome = AV96TFPessoaNome;
         AV122PedidoWWDS_10_Tfpessoanome_sel = AV97TFPessoaNome_Sel;
         AV123PedidoWWDS_11_Tfpedidodt = AV63TFPedidoDt;
         AV124PedidoWWDS_12_Tfpedidodt_to = AV64TFPedidoDt_To;
         AV125PedidoWWDS_13_Tfpedidostatus_sels = AV70TFPedidoStatus_Sels;
         AV126PedidoWWDS_14_Tfpedidodtentrega = AV73TFPedidoDtEntrega;
         AV127PedidoWWDS_15_Tfpedidodtentrega_to = AV74TFPedidoDtEntrega_To;
         AV128PedidoWWDS_16_Tfpedidoretirada_sel = AV79TFPedidoRetirada_Sel;
         AV129PedidoWWDS_17_Tfpedidototal = AV82TFPedidoTotal;
         AV130PedidoWWDS_18_Tfpedidototal_to = AV83TFPedidoTotal_To;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58PedidoIdTitleFilterData", AV58PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV95PessoaNomeTitleFilterData", AV95PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62PedidoDtTitleFilterData", AV62PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68PedidoStatusTitleFilterData", AV68PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV72PedidoDtEntregaTitleFilterData", AV72PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78PedidoRetiradaTitleFilterData", AV78PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV81PedidoTotalTitleFilterData", AV81PedidoTotalTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E12132( )
      {
         /* Gridpaginationbar_Changepage Routine */
         if ( StringUtil.StrCmp(Gridpaginationbar_Selectedpage, "Previous") == 0 )
         {
            subgrid_previouspage( ) ;
         }
         else if ( StringUtil.StrCmp(Gridpaginationbar_Selectedpage, "Next") == 0 )
         {
            subgrid_nextpage( ) ;
         }
         else
         {
            AV86PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV86PageToGo) ;
         }
      }

      protected void E13132( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E14132( )
      {
         /* Ddo_pedidoid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_pedidoid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S172 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_pedidoid_Sortedstatus = "ASC";
            ucDdo_pedidoid.SendProperty(context, "", false, Ddo_pedidoid_Internalname, "SortedStatus", Ddo_pedidoid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pedidoid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S172 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_pedidoid_Sortedstatus = "DSC";
            ucDdo_pedidoid.SendProperty(context, "", false, Ddo_pedidoid_Internalname, "SortedStatus", Ddo_pedidoid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pedidoid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV59TFPedidoId = (short)(NumberUtil.Val( Ddo_pedidoid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV59TFPedidoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV59TFPedidoId), 4, 0)));
            AV60TFPedidoId_To = (short)(NumberUtil.Val( Ddo_pedidoid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60TFPedidoId_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV60TFPedidoId_To), 4, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58PedidoIdTitleFilterData", AV58PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV95PessoaNomeTitleFilterData", AV95PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62PedidoDtTitleFilterData", AV62PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68PedidoStatusTitleFilterData", AV68PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV72PedidoDtEntregaTitleFilterData", AV72PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78PedidoRetiradaTitleFilterData", AV78PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV81PedidoTotalTitleFilterData", AV81PedidoTotalTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E15132( )
      {
         /* Ddo_pessoanome_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_pessoanome_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S172 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_pessoanome_Sortedstatus = "ASC";
            ucDdo_pessoanome.SendProperty(context, "", false, Ddo_pessoanome_Internalname, "SortedStatus", Ddo_pessoanome_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pessoanome_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S172 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_pessoanome_Sortedstatus = "DSC";
            ucDdo_pessoanome.SendProperty(context, "", false, Ddo_pessoanome_Internalname, "SortedStatus", Ddo_pessoanome_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pessoanome_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV96TFPessoaNome = Ddo_pessoanome_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV96TFPessoaNome", AV96TFPessoaNome);
            AV97TFPessoaNome_Sel = Ddo_pessoanome_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV97TFPessoaNome_Sel", AV97TFPessoaNome_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58PedidoIdTitleFilterData", AV58PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV95PessoaNomeTitleFilterData", AV95PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62PedidoDtTitleFilterData", AV62PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68PedidoStatusTitleFilterData", AV68PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV72PedidoDtEntregaTitleFilterData", AV72PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78PedidoRetiradaTitleFilterData", AV78PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV81PedidoTotalTitleFilterData", AV81PedidoTotalTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E16132( )
      {
         /* Ddo_pedidodt_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_pedidodt_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S172 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_pedidodt_Sortedstatus = "ASC";
            ucDdo_pedidodt.SendProperty(context, "", false, Ddo_pedidodt_Internalname, "SortedStatus", Ddo_pedidodt_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pedidodt_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S172 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_pedidodt_Sortedstatus = "DSC";
            ucDdo_pedidodt.SendProperty(context, "", false, Ddo_pedidodt_Internalname, "SortedStatus", Ddo_pedidodt_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pedidodt_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV63TFPedidoDt = context.localUtil.CToD( Ddo_pedidodt_Filteredtext_get, 2);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV63TFPedidoDt", context.localUtil.Format(AV63TFPedidoDt, "99/99/99"));
            AV64TFPedidoDt_To = context.localUtil.CToD( Ddo_pedidodt_Filteredtextto_get, 2);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV64TFPedidoDt_To", context.localUtil.Format(AV64TFPedidoDt_To, "99/99/99"));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58PedidoIdTitleFilterData", AV58PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV95PessoaNomeTitleFilterData", AV95PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62PedidoDtTitleFilterData", AV62PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68PedidoStatusTitleFilterData", AV68PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV72PedidoDtEntregaTitleFilterData", AV72PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78PedidoRetiradaTitleFilterData", AV78PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV81PedidoTotalTitleFilterData", AV81PedidoTotalTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E17132( )
      {
         /* Ddo_pedidostatus_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_pedidostatus_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S172 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_pedidostatus_Sortedstatus = "ASC";
            ucDdo_pedidostatus.SendProperty(context, "", false, Ddo_pedidostatus_Internalname, "SortedStatus", Ddo_pedidostatus_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pedidostatus_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S172 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_pedidostatus_Sortedstatus = "DSC";
            ucDdo_pedidostatus.SendProperty(context, "", false, Ddo_pedidostatus_Internalname, "SortedStatus", Ddo_pedidostatus_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pedidostatus_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV69TFPedidoStatus_SelsJson = Ddo_pedidostatus_Selectedvalue_get;
            AV70TFPedidoStatus_Sels.FromJSonString(AV69TFPedidoStatus_SelsJson, null);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV70TFPedidoStatus_Sels", AV70TFPedidoStatus_Sels);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58PedidoIdTitleFilterData", AV58PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV95PessoaNomeTitleFilterData", AV95PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62PedidoDtTitleFilterData", AV62PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68PedidoStatusTitleFilterData", AV68PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV72PedidoDtEntregaTitleFilterData", AV72PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78PedidoRetiradaTitleFilterData", AV78PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV81PedidoTotalTitleFilterData", AV81PedidoTotalTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E18132( )
      {
         /* Ddo_pedidodtentrega_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_pedidodtentrega_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S172 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_pedidodtentrega_Sortedstatus = "ASC";
            ucDdo_pedidodtentrega.SendProperty(context, "", false, Ddo_pedidodtentrega_Internalname, "SortedStatus", Ddo_pedidodtentrega_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pedidodtentrega_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S172 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_pedidodtentrega_Sortedstatus = "DSC";
            ucDdo_pedidodtentrega.SendProperty(context, "", false, Ddo_pedidodtentrega_Internalname, "SortedStatus", Ddo_pedidodtentrega_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pedidodtentrega_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV73TFPedidoDtEntrega = context.localUtil.CToD( Ddo_pedidodtentrega_Filteredtext_get, 2);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV73TFPedidoDtEntrega", context.localUtil.Format(AV73TFPedidoDtEntrega, "99/99/99"));
            AV74TFPedidoDtEntrega_To = context.localUtil.CToD( Ddo_pedidodtentrega_Filteredtextto_get, 2);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV74TFPedidoDtEntrega_To", context.localUtil.Format(AV74TFPedidoDtEntrega_To, "99/99/99"));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58PedidoIdTitleFilterData", AV58PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV95PessoaNomeTitleFilterData", AV95PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62PedidoDtTitleFilterData", AV62PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68PedidoStatusTitleFilterData", AV68PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV72PedidoDtEntregaTitleFilterData", AV72PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78PedidoRetiradaTitleFilterData", AV78PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV81PedidoTotalTitleFilterData", AV81PedidoTotalTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E19132( )
      {
         /* Ddo_pedidoretirada_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_pedidoretirada_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S172 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_pedidoretirada_Sortedstatus = "ASC";
            ucDdo_pedidoretirada.SendProperty(context, "", false, Ddo_pedidoretirada_Internalname, "SortedStatus", Ddo_pedidoretirada_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pedidoretirada_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S172 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_pedidoretirada_Sortedstatus = "DSC";
            ucDdo_pedidoretirada.SendProperty(context, "", false, Ddo_pedidoretirada_Internalname, "SortedStatus", Ddo_pedidoretirada_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pedidoretirada_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV79TFPedidoRetirada_Sel = (short)(NumberUtil.Val( Ddo_pedidoretirada_Selectedvalue_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV79TFPedidoRetirada_Sel", StringUtil.Str( (decimal)(AV79TFPedidoRetirada_Sel), 1, 0));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58PedidoIdTitleFilterData", AV58PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV95PessoaNomeTitleFilterData", AV95PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62PedidoDtTitleFilterData", AV62PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68PedidoStatusTitleFilterData", AV68PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV72PedidoDtEntregaTitleFilterData", AV72PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78PedidoRetiradaTitleFilterData", AV78PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV81PedidoTotalTitleFilterData", AV81PedidoTotalTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E20132( )
      {
         /* Ddo_pedidototal_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_pedidototal_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S172 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_pedidototal_Sortedstatus = "ASC";
            ucDdo_pedidototal.SendProperty(context, "", false, Ddo_pedidototal_Internalname, "SortedStatus", Ddo_pedidototal_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pedidototal_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S172 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_pedidototal_Sortedstatus = "DSC";
            ucDdo_pedidototal.SendProperty(context, "", false, Ddo_pedidototal_Internalname, "SortedStatus", Ddo_pedidototal_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pedidototal_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV82TFPedidoTotal = NumberUtil.Val( Ddo_pedidototal_Filteredtext_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV82TFPedidoTotal", StringUtil.LTrim( StringUtil.Str( AV82TFPedidoTotal, 12, 2)));
            AV83TFPedidoTotal_To = NumberUtil.Val( Ddo_pedidototal_Filteredtextto_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV83TFPedidoTotal_To", StringUtil.LTrim( StringUtil.Str( AV83TFPedidoTotal_To, 12, 2)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58PedidoIdTitleFilterData", AV58PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV95PessoaNomeTitleFilterData", AV95PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62PedidoDtTitleFilterData", AV62PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68PedidoStatusTitleFilterData", AV68PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV72PedidoDtEntregaTitleFilterData", AV72PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78PedidoRetiradaTitleFilterData", AV78PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV81PedidoTotalTitleFilterData", AV81PedidoTotalTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      private void E25132( )
      {
         /* Grid_Load Routine */
         AV89Update = "<i class=\"fa fa-pen\"></i>";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUpdate_Internalname, AV89Update);
         edtavUpdate_Link = formatLink("pedido.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A32PedidoId);
         AV90Delete = "<i class=\"fa fa-times\"></i>";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDelete_Internalname, AV90Delete);
         edtavDelete_Link = formatLink("pedido.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A32PedidoId);
         AV92Encerrar = "Encerrar";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavEncerrar_Internalname, AV92Encerrar);
         AV106Aprovar = "Aprovar";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavAprovar_Internalname, AV106Aprovar);
         AV107Reprovar = "Reprovar";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavReprovar_Internalname, AV107Reprovar);
         edtPedidoDt_Link = formatLink("pedidoview.aspx") + "?" + UrlEncode("" +A32PedidoId) + "," + UrlEncode(StringUtil.RTrim(""));
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 91;
         }
         sendrow_912( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_91_Refreshing )
         {
            context.DoAjaxLoad(91, GridRow);
         }
         /*  Sending Event outputs  */
      }

      protected void E21132( )
      {
         /* Ddo_gridcolumnsselector_Oncolumnschanged Routine */
         AV32ColumnsSelectorXML = Ddo_gridcolumnsselector_Columnsselectorvalues;
         AV44ColumnsSelector.FromJSonString(AV32ColumnsSelectorXML, null);
         new GeneXus.Programs.wwpbaseobjects.savecolumnsselectorstate(context ).execute(  "PedidoWWColumnsSelector",  AV44ColumnsSelector.ToXml(false, true, "WWPColumnsSelector", "FMX")) ;
         context.DoAjaxRefresh();
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58PedidoIdTitleFilterData", AV58PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV95PessoaNomeTitleFilterData", AV95PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62PedidoDtTitleFilterData", AV62PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68PedidoStatusTitleFilterData", AV68PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV72PedidoDtEntregaTitleFilterData", AV72PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78PedidoRetiradaTitleFilterData", AV78PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV81PedidoTotalTitleFilterData", AV81PedidoTotalTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E11132( )
      {
         /* Ddo_managefilters_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_managefilters_Activeeventkey, "<#Clean#>") == 0 )
         {
            /* Execute user subroutine: 'CLEANFILTERS' */
            S182 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_managefilters_Activeeventkey, "<#Save#>") == 0 )
         {
            /* Execute user subroutine: 'SAVEGRIDSTATE' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            context.PopUp(formatLink("wwpbaseobjects.savefilteras.aspx") + "?" + UrlEncode(StringUtil.RTrim("PedidoWWFilters")) + "," + UrlEncode(StringUtil.RTrim(AV131Pgmname+"GridState")), new Object[] {});
            AV52ManageFiltersExecutionStep = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV52ManageFiltersExecutionStep", StringUtil.Str( (decimal)(AV52ManageFiltersExecutionStep), 1, 0));
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_managefilters_Activeeventkey, "<#Manage#>") == 0 )
         {
            context.PopUp(formatLink("wwpbaseobjects.managefilters.aspx") + "?" + UrlEncode(StringUtil.RTrim("PedidoWWFilters")), new Object[] {});
            AV52ManageFiltersExecutionStep = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV52ManageFiltersExecutionStep", StringUtil.Str( (decimal)(AV52ManageFiltersExecutionStep), 1, 0));
            context.DoAjaxRefresh();
         }
         else
         {
            GXt_char2 = AV53ManageFiltersXml;
            new GeneXus.Programs.wwpbaseobjects.getfilterbyname(context ).execute(  "PedidoWWFilters",  Ddo_managefilters_Activeeventkey, out  GXt_char2) ;
            ucDdo_managefilters.SendProperty(context, "", false, Ddo_managefilters_Internalname, "ActiveEventKey", Ddo_managefilters_Activeeventkey);
            AV53ManageFiltersXml = GXt_char2;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( AV53ManageFiltersXml)) )
            {
               GX_msglist.addItem("O filtro selecionado não existe mais.");
            }
            else
            {
               /* Execute user subroutine: 'CLEANFILTERS' */
               S182 ();
               if ( returnInSub )
               {
                  returnInSub = true;
                  if (true) return;
               }
               new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV131Pgmname+"GridState",  AV53ManageFiltersXml) ;
               AV10GridState.FromXml(AV53ManageFiltersXml, null, "WWPGridState", "FMX");
               AV13OrderedBy = AV10GridState.gxTpr_Orderedby;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
               AV14OrderedDsc = AV10GridState.gxTpr_Ordereddsc;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
               /* Execute user subroutine: 'SETDDOSORTEDSTATUS' */
               S142 ();
               if ( returnInSub )
               {
                  returnInSub = true;
                  if (true) return;
               }
               /* Execute user subroutine: 'LOADREGFILTERSSTATE' */
               S192 ();
               if ( returnInSub )
               {
                  returnInSub = true;
                  if (true) return;
               }
               subgrid_firstpage( ) ;
               context.DoAjaxRefresh();
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
         cmbavPessoanomeoperator.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV93PessoaNomeOperator), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavPessoanomeoperator_Internalname, "Values", cmbavPessoanomeoperator.ToJavascriptSource(), true);
         cmbavPedidostatus.CurrentValue = StringUtil.RTrim( AV103PedidoStatus);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavPedidostatus_Internalname, "Values", cmbavPedidostatus.ToJavascriptSource(), true);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV70TFPedidoStatus_Sels", AV70TFPedidoStatus_Sels);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58PedidoIdTitleFilterData", AV58PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV95PessoaNomeTitleFilterData", AV95PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62PedidoDtTitleFilterData", AV62PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68PedidoStatusTitleFilterData", AV68PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV72PedidoDtEntregaTitleFilterData", AV72PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78PedidoRetiradaTitleFilterData", AV78PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV81PedidoTotalTitleFilterData", AV81PedidoTotalTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
      }

      protected void E22132( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("pedido.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
         context.wjLocDisableFrm = 1;
      }

      protected void S172( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_pedidoid_Sortedstatus = "";
         ucDdo_pedidoid.SendProperty(context, "", false, Ddo_pedidoid_Internalname, "SortedStatus", Ddo_pedidoid_Sortedstatus);
         Ddo_pessoanome_Sortedstatus = "";
         ucDdo_pessoanome.SendProperty(context, "", false, Ddo_pessoanome_Internalname, "SortedStatus", Ddo_pessoanome_Sortedstatus);
         Ddo_pedidodt_Sortedstatus = "";
         ucDdo_pedidodt.SendProperty(context, "", false, Ddo_pedidodt_Internalname, "SortedStatus", Ddo_pedidodt_Sortedstatus);
         Ddo_pedidostatus_Sortedstatus = "";
         ucDdo_pedidostatus.SendProperty(context, "", false, Ddo_pedidostatus_Internalname, "SortedStatus", Ddo_pedidostatus_Sortedstatus);
         Ddo_pedidodtentrega_Sortedstatus = "";
         ucDdo_pedidodtentrega.SendProperty(context, "", false, Ddo_pedidodtentrega_Internalname, "SortedStatus", Ddo_pedidodtentrega_Sortedstatus);
         Ddo_pedidoretirada_Sortedstatus = "";
         ucDdo_pedidoretirada.SendProperty(context, "", false, Ddo_pedidoretirada_Internalname, "SortedStatus", Ddo_pedidoretirada_Sortedstatus);
         Ddo_pedidototal_Sortedstatus = "";
         ucDdo_pedidototal.SendProperty(context, "", false, Ddo_pedidototal_Internalname, "SortedStatus", Ddo_pedidototal_Sortedstatus);
      }

      protected void S142( )
      {
         /* 'SETDDOSORTEDSTATUS' Routine */
         /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
         S172 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         if ( AV13OrderedBy == 2 )
         {
            Ddo_pedidoid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_pedidoid.SendProperty(context, "", false, Ddo_pedidoid_Internalname, "SortedStatus", Ddo_pedidoid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 3 )
         {
            Ddo_pessoanome_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_pessoanome.SendProperty(context, "", false, Ddo_pessoanome_Internalname, "SortedStatus", Ddo_pessoanome_Sortedstatus);
         }
         else if ( AV13OrderedBy == 1 )
         {
            Ddo_pedidodt_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_pedidodt.SendProperty(context, "", false, Ddo_pedidodt_Internalname, "SortedStatus", Ddo_pedidodt_Sortedstatus);
         }
         else if ( AV13OrderedBy == 4 )
         {
            Ddo_pedidostatus_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_pedidostatus.SendProperty(context, "", false, Ddo_pedidostatus_Internalname, "SortedStatus", Ddo_pedidostatus_Sortedstatus);
         }
         else if ( AV13OrderedBy == 5 )
         {
            Ddo_pedidodtentrega_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_pedidodtentrega.SendProperty(context, "", false, Ddo_pedidodtentrega_Internalname, "SortedStatus", Ddo_pedidodtentrega_Sortedstatus);
         }
         else if ( AV13OrderedBy == 6 )
         {
            Ddo_pedidoretirada_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_pedidoretirada.SendProperty(context, "", false, Ddo_pedidoretirada_Internalname, "SortedStatus", Ddo_pedidoretirada_Sortedstatus);
         }
         else if ( AV13OrderedBy == 7 )
         {
            Ddo_pedidototal_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_pedidototal.SendProperty(context, "", false, Ddo_pedidototal_Internalname, "SortedStatus", Ddo_pedidototal_Sortedstatus);
         }
      }

      protected void S162( )
      {
         /* 'INITIALIZECOLUMNSSELECTOR' Routine */
         AV44ColumnsSelector = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector(context);
         new GeneXus.Programs.wwpbaseobjects.wwp_columnsselector_add(context ).execute( ref  AV44ColumnsSelector,  "Número do Pedido",  true) ;
         new GeneXus.Programs.wwpbaseobjects.wwp_columnsselector_add(context ).execute( ref  AV44ColumnsSelector,  "Nome",  true) ;
         new GeneXus.Programs.wwpbaseobjects.wwp_columnsselector_add(context ).execute( ref  AV44ColumnsSelector,  "Data do Pedido",  true) ;
         new GeneXus.Programs.wwpbaseobjects.wwp_columnsselector_add(context ).execute( ref  AV44ColumnsSelector,  "Status",  true) ;
         new GeneXus.Programs.wwpbaseobjects.wwp_columnsselector_add(context ).execute( ref  AV44ColumnsSelector,  "Data de Entrega",  true) ;
         new GeneXus.Programs.wwpbaseobjects.wwp_columnsselector_add(context ).execute( ref  AV44ColumnsSelector,  "Retirar no Local?",  true) ;
         new GeneXus.Programs.wwpbaseobjects.wwp_columnsselector_add(context ).execute( ref  AV44ColumnsSelector,  "Total",  true) ;
         GXt_char2 = AV39UserCustomValue;
         new GeneXus.Programs.wwpbaseobjects.loadcolumnsselectorstate(context ).execute(  "PedidoWWColumnsSelector", out  GXt_char2) ;
         AV39UserCustomValue = GXt_char2;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( AV39UserCustomValue)) ) )
         {
            AV45ColumnsSelectorAux.FromXml(AV39UserCustomValue, null, "WWPColumnsSelector", "FMX");
            new GeneXus.Programs.wwpbaseobjects.wwp_columnselector_updatecolumns(context ).execute( ref  AV45ColumnsSelectorAux, ref  AV44ColumnsSelector) ;
         }
      }

      protected void S112( )
      {
         /* 'LOADSAVEDFILTERS' Routine */
         AV56ManageFiltersData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV57ManageFiltersDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
         AV57ManageFiltersDataItem.gxTpr_Title = "Limpar filtros";
         AV57ManageFiltersDataItem.gxTpr_Eventkey = "<#Clean#>";
         AV57ManageFiltersDataItem.gxTpr_Isdivider = false;
         AV57ManageFiltersDataItem.gxTpr_Icon = context.convertURL( (String)(context.GetImagePath( "63d2ae92-4e43-4a70-af61-0943e39ea422", "", context.GetTheme( ))));
         AV56ManageFiltersData.Add(AV57ManageFiltersDataItem, 0);
         AV57ManageFiltersDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
         AV57ManageFiltersDataItem.gxTpr_Title = "Salvar filtro como...";
         AV57ManageFiltersDataItem.gxTpr_Eventkey = "<#Save#>";
         AV57ManageFiltersDataItem.gxTpr_Isdivider = false;
         AV57ManageFiltersDataItem.gxTpr_Icon = context.convertURL( (String)(context.GetImagePath( "6eee63e8-73c7-4738-beee-f98e3a8d2841", "", context.GetTheme( ))));
         AV56ManageFiltersData.Add(AV57ManageFiltersDataItem, 0);
         AV57ManageFiltersDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
         AV57ManageFiltersDataItem.gxTpr_Isdivider = true;
         AV56ManageFiltersData.Add(AV57ManageFiltersDataItem, 0);
         AV54ManageFiltersItems.FromXml(new GeneXus.Programs.wwpbaseobjects.loadmanagefiltersstate(context).executeUdp(  "PedidoWWFilters"), null, "Items", "");
         AV132GXV1 = 1;
         while ( AV132GXV1 <= AV54ManageFiltersItems.Count )
         {
            AV55ManageFiltersItem = ((GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item)AV54ManageFiltersItems.Item(AV132GXV1));
            AV57ManageFiltersDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
            AV57ManageFiltersDataItem.gxTpr_Title = AV55ManageFiltersItem.gxTpr_Title;
            AV57ManageFiltersDataItem.gxTpr_Eventkey = AV55ManageFiltersItem.gxTpr_Title;
            AV57ManageFiltersDataItem.gxTpr_Isdivider = false;
            AV56ManageFiltersData.Add(AV57ManageFiltersDataItem, 0);
            if ( AV56ManageFiltersData.Count == 13 )
            {
               if (true) break;
            }
            AV132GXV1 = (int)(AV132GXV1+1);
         }
         if ( AV56ManageFiltersData.Count > 3 )
         {
            AV57ManageFiltersDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
            AV57ManageFiltersDataItem.gxTpr_Isdivider = true;
            AV56ManageFiltersData.Add(AV57ManageFiltersDataItem, 0);
            AV57ManageFiltersDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
            AV57ManageFiltersDataItem.gxTpr_Title = "Gerenciar filtros";
            AV57ManageFiltersDataItem.gxTpr_Eventkey = "<#Manage#>";
            AV57ManageFiltersDataItem.gxTpr_Isdivider = false;
            AV57ManageFiltersDataItem.gxTpr_Icon = context.convertURL( (String)(context.GetImagePath( "653f6166-5d82-407a-af84-19e0dde65efd", "", context.GetTheme( ))));
            AV57ManageFiltersDataItem.gxTpr_Jsonclickevent = "";
            AV56ManageFiltersData.Add(AV57ManageFiltersDataItem, 0);
         }
      }

      protected void S182( )
      {
         /* 'CLEANFILTERS' Routine */
         AV93PessoaNomeOperator = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV93PessoaNomeOperator", StringUtil.LTrim( StringUtil.Str( (decimal)(AV93PessoaNomeOperator), 4, 0)));
         AV94PessoaNome = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV94PessoaNome", AV94PessoaNome);
         AV99PedidoDt = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV99PedidoDt", context.localUtil.Format(AV99PedidoDt, "99/99/99"));
         AV100PedidoDt_To = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV100PedidoDt_To", context.localUtil.Format(AV100PedidoDt_To, "99/99/99"));
         AV101PedidoDtEntrega = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV101PedidoDtEntrega", context.localUtil.Format(AV101PedidoDtEntrega, "99/99/99"));
         AV102PedidoDtEntrega_To = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV102PedidoDtEntrega_To", context.localUtil.Format(AV102PedidoDtEntrega_To, "99/99/99"));
         AV103PedidoStatus = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV103PedidoStatus", AV103PedidoStatus);
         AV59TFPedidoId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV59TFPedidoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV59TFPedidoId), 4, 0)));
         Ddo_pedidoid_Filteredtext_set = "";
         ucDdo_pedidoid.SendProperty(context, "", false, Ddo_pedidoid_Internalname, "FilteredText_set", Ddo_pedidoid_Filteredtext_set);
         AV60TFPedidoId_To = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60TFPedidoId_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV60TFPedidoId_To), 4, 0)));
         Ddo_pedidoid_Filteredtextto_set = "";
         ucDdo_pedidoid.SendProperty(context, "", false, Ddo_pedidoid_Internalname, "FilteredTextTo_set", Ddo_pedidoid_Filteredtextto_set);
         AV96TFPessoaNome = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV96TFPessoaNome", AV96TFPessoaNome);
         Ddo_pessoanome_Filteredtext_set = "";
         ucDdo_pessoanome.SendProperty(context, "", false, Ddo_pessoanome_Internalname, "FilteredText_set", Ddo_pessoanome_Filteredtext_set);
         AV97TFPessoaNome_Sel = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV97TFPessoaNome_Sel", AV97TFPessoaNome_Sel);
         Ddo_pessoanome_Selectedvalue_set = "";
         ucDdo_pessoanome.SendProperty(context, "", false, Ddo_pessoanome_Internalname, "SelectedValue_set", Ddo_pessoanome_Selectedvalue_set);
         AV63TFPedidoDt = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV63TFPedidoDt", context.localUtil.Format(AV63TFPedidoDt, "99/99/99"));
         Ddo_pedidodt_Filteredtext_set = "";
         ucDdo_pedidodt.SendProperty(context, "", false, Ddo_pedidodt_Internalname, "FilteredText_set", Ddo_pedidodt_Filteredtext_set);
         AV64TFPedidoDt_To = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV64TFPedidoDt_To", context.localUtil.Format(AV64TFPedidoDt_To, "99/99/99"));
         Ddo_pedidodt_Filteredtextto_set = "";
         ucDdo_pedidodt.SendProperty(context, "", false, Ddo_pedidodt_Internalname, "FilteredTextTo_set", Ddo_pedidodt_Filteredtextto_set);
         AV70TFPedidoStatus_Sels = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         Ddo_pedidostatus_Selectedvalue_set = "";
         ucDdo_pedidostatus.SendProperty(context, "", false, Ddo_pedidostatus_Internalname, "SelectedValue_set", Ddo_pedidostatus_Selectedvalue_set);
         AV73TFPedidoDtEntrega = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV73TFPedidoDtEntrega", context.localUtil.Format(AV73TFPedidoDtEntrega, "99/99/99"));
         Ddo_pedidodtentrega_Filteredtext_set = "";
         ucDdo_pedidodtentrega.SendProperty(context, "", false, Ddo_pedidodtentrega_Internalname, "FilteredText_set", Ddo_pedidodtentrega_Filteredtext_set);
         AV74TFPedidoDtEntrega_To = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV74TFPedidoDtEntrega_To", context.localUtil.Format(AV74TFPedidoDtEntrega_To, "99/99/99"));
         Ddo_pedidodtentrega_Filteredtextto_set = "";
         ucDdo_pedidodtentrega.SendProperty(context, "", false, Ddo_pedidodtentrega_Internalname, "FilteredTextTo_set", Ddo_pedidodtentrega_Filteredtextto_set);
         AV79TFPedidoRetirada_Sel = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV79TFPedidoRetirada_Sel", StringUtil.Str( (decimal)(AV79TFPedidoRetirada_Sel), 1, 0));
         Ddo_pedidoretirada_Selectedvalue_set = "";
         ucDdo_pedidoretirada.SendProperty(context, "", false, Ddo_pedidoretirada_Internalname, "SelectedValue_set", Ddo_pedidoretirada_Selectedvalue_set);
         AV82TFPedidoTotal = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV82TFPedidoTotal", StringUtil.LTrim( StringUtil.Str( AV82TFPedidoTotal, 12, 2)));
         Ddo_pedidototal_Filteredtext_set = "";
         ucDdo_pedidototal.SendProperty(context, "", false, Ddo_pedidototal_Internalname, "FilteredText_set", Ddo_pedidototal_Filteredtext_set);
         AV83TFPedidoTotal_To = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV83TFPedidoTotal_To", StringUtil.LTrim( StringUtil.Str( AV83TFPedidoTotal_To, 12, 2)));
         Ddo_pedidototal_Filteredtextto_set = "";
         ucDdo_pedidototal.SendProperty(context, "", false, Ddo_pedidototal_Internalname, "FilteredTextTo_set", Ddo_pedidototal_Filteredtextto_set);
      }

      protected void S132( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV51Session.Get(AV131Pgmname+"GridState"), "") == 0 )
         {
            AV10GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV131Pgmname+"GridState"), null, "WWPGridState", "FMX");
         }
         else
         {
            AV10GridState.FromXml(AV51Session.Get(AV131Pgmname+"GridState"), null, "WWPGridState", "FMX");
         }
         AV13OrderedBy = AV10GridState.gxTpr_Orderedby;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
         AV14OrderedDsc = AV10GridState.gxTpr_Ordereddsc;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
         /* Execute user subroutine: 'SETDDOSORTEDSTATUS' */
         S142 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'LOADREGFILTERSSTATE' */
         S192 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( StringUtil.Trim( AV10GridState.gxTpr_Pagesize))) )
         {
            subGrid_Rows = (int)(NumberUtil.Val( AV10GridState.gxTpr_Pagesize, "."));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         }
         subgrid_gotopage( AV10GridState.gxTpr_Currentpage) ;
      }

      protected void S192( )
      {
         /* 'LOADREGFILTERSSTATE' Routine */
         AV133GXV2 = 1;
         while ( AV133GXV2 <= AV10GridState.gxTpr_Filtervalues.Count )
         {
            AV11GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV10GridState.gxTpr_Filtervalues.Item(AV133GXV2));
            if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "PESSOANOME") == 0 )
            {
               AV94PessoaNome = AV11GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV94PessoaNome", AV94PessoaNome);
               AV93PessoaNomeOperator = AV11GridStateFilterValue.gxTpr_Operator;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV93PessoaNomeOperator", StringUtil.LTrim( StringUtil.Str( (decimal)(AV93PessoaNomeOperator), 4, 0)));
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "PEDIDODT") == 0 )
            {
               AV99PedidoDt = context.localUtil.CToD( AV11GridStateFilterValue.gxTpr_Value, 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV99PedidoDt", context.localUtil.Format(AV99PedidoDt, "99/99/99"));
               AV100PedidoDt_To = context.localUtil.CToD( AV11GridStateFilterValue.gxTpr_Valueto, 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV100PedidoDt_To", context.localUtil.Format(AV100PedidoDt_To, "99/99/99"));
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "PEDIDODTENTREGA") == 0 )
            {
               AV101PedidoDtEntrega = context.localUtil.CToD( AV11GridStateFilterValue.gxTpr_Value, 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV101PedidoDtEntrega", context.localUtil.Format(AV101PedidoDtEntrega, "99/99/99"));
               AV102PedidoDtEntrega_To = context.localUtil.CToD( AV11GridStateFilterValue.gxTpr_Valueto, 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV102PedidoDtEntrega_To", context.localUtil.Format(AV102PedidoDtEntrega_To, "99/99/99"));
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "PEDIDOSTATUS") == 0 )
            {
               AV103PedidoStatus = AV11GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV103PedidoStatus", AV103PedidoStatus);
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFPEDIDOID") == 0 )
            {
               AV59TFPedidoId = (short)(NumberUtil.Val( AV11GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV59TFPedidoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV59TFPedidoId), 4, 0)));
               AV60TFPedidoId_To = (short)(NumberUtil.Val( AV11GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60TFPedidoId_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV60TFPedidoId_To), 4, 0)));
               if ( ! (0==AV59TFPedidoId) )
               {
                  Ddo_pedidoid_Filteredtext_set = StringUtil.Str( (decimal)(AV59TFPedidoId), 4, 0);
                  ucDdo_pedidoid.SendProperty(context, "", false, Ddo_pedidoid_Internalname, "FilteredText_set", Ddo_pedidoid_Filteredtext_set);
               }
               if ( ! (0==AV60TFPedidoId_To) )
               {
                  Ddo_pedidoid_Filteredtextto_set = StringUtil.Str( (decimal)(AV60TFPedidoId_To), 4, 0);
                  ucDdo_pedidoid.SendProperty(context, "", false, Ddo_pedidoid_Internalname, "FilteredTextTo_set", Ddo_pedidoid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFPESSOANOME") == 0 )
            {
               AV96TFPessoaNome = AV11GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV96TFPessoaNome", AV96TFPessoaNome);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV96TFPessoaNome)) )
               {
                  Ddo_pessoanome_Filteredtext_set = AV96TFPessoaNome;
                  ucDdo_pessoanome.SendProperty(context, "", false, Ddo_pessoanome_Internalname, "FilteredText_set", Ddo_pessoanome_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFPESSOANOME_SEL") == 0 )
            {
               AV97TFPessoaNome_Sel = AV11GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV97TFPessoaNome_Sel", AV97TFPessoaNome_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV97TFPessoaNome_Sel)) )
               {
                  Ddo_pessoanome_Selectedvalue_set = AV97TFPessoaNome_Sel;
                  ucDdo_pessoanome.SendProperty(context, "", false, Ddo_pessoanome_Internalname, "SelectedValue_set", Ddo_pessoanome_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFPEDIDODT") == 0 )
            {
               AV63TFPedidoDt = context.localUtil.CToD( AV11GridStateFilterValue.gxTpr_Value, 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV63TFPedidoDt", context.localUtil.Format(AV63TFPedidoDt, "99/99/99"));
               AV64TFPedidoDt_To = context.localUtil.CToD( AV11GridStateFilterValue.gxTpr_Valueto, 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV64TFPedidoDt_To", context.localUtil.Format(AV64TFPedidoDt_To, "99/99/99"));
               if ( ! (DateTime.MinValue==AV63TFPedidoDt) )
               {
                  Ddo_pedidodt_Filteredtext_set = context.localUtil.DToC( AV63TFPedidoDt, 2, "/");
                  ucDdo_pedidodt.SendProperty(context, "", false, Ddo_pedidodt_Internalname, "FilteredText_set", Ddo_pedidodt_Filteredtext_set);
               }
               if ( ! (DateTime.MinValue==AV64TFPedidoDt_To) )
               {
                  Ddo_pedidodt_Filteredtextto_set = context.localUtil.DToC( AV64TFPedidoDt_To, 2, "/");
                  ucDdo_pedidodt.SendProperty(context, "", false, Ddo_pedidodt_Internalname, "FilteredTextTo_set", Ddo_pedidodt_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFPEDIDOSTATUS_SEL") == 0 )
            {
               AV69TFPedidoStatus_SelsJson = AV11GridStateFilterValue.gxTpr_Value;
               AV70TFPedidoStatus_Sels.FromJSonString(AV69TFPedidoStatus_SelsJson, null);
               if ( ! ( AV70TFPedidoStatus_Sels.Count == 0 ) )
               {
                  Ddo_pedidostatus_Selectedvalue_set = AV69TFPedidoStatus_SelsJson;
                  ucDdo_pedidostatus.SendProperty(context, "", false, Ddo_pedidostatus_Internalname, "SelectedValue_set", Ddo_pedidostatus_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFPEDIDODTENTREGA") == 0 )
            {
               AV73TFPedidoDtEntrega = context.localUtil.CToD( AV11GridStateFilterValue.gxTpr_Value, 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV73TFPedidoDtEntrega", context.localUtil.Format(AV73TFPedidoDtEntrega, "99/99/99"));
               AV74TFPedidoDtEntrega_To = context.localUtil.CToD( AV11GridStateFilterValue.gxTpr_Valueto, 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV74TFPedidoDtEntrega_To", context.localUtil.Format(AV74TFPedidoDtEntrega_To, "99/99/99"));
               if ( ! (DateTime.MinValue==AV73TFPedidoDtEntrega) )
               {
                  Ddo_pedidodtentrega_Filteredtext_set = context.localUtil.DToC( AV73TFPedidoDtEntrega, 2, "/");
                  ucDdo_pedidodtentrega.SendProperty(context, "", false, Ddo_pedidodtentrega_Internalname, "FilteredText_set", Ddo_pedidodtentrega_Filteredtext_set);
               }
               if ( ! (DateTime.MinValue==AV74TFPedidoDtEntrega_To) )
               {
                  Ddo_pedidodtentrega_Filteredtextto_set = context.localUtil.DToC( AV74TFPedidoDtEntrega_To, 2, "/");
                  ucDdo_pedidodtentrega.SendProperty(context, "", false, Ddo_pedidodtentrega_Internalname, "FilteredTextTo_set", Ddo_pedidodtentrega_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFPEDIDORETIRADA_SEL") == 0 )
            {
               AV79TFPedidoRetirada_Sel = (short)(NumberUtil.Val( AV11GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV79TFPedidoRetirada_Sel", StringUtil.Str( (decimal)(AV79TFPedidoRetirada_Sel), 1, 0));
               if ( ! (0==AV79TFPedidoRetirada_Sel) )
               {
                  Ddo_pedidoretirada_Selectedvalue_set = StringUtil.Str( (decimal)(AV79TFPedidoRetirada_Sel), 1, 0);
                  ucDdo_pedidoretirada.SendProperty(context, "", false, Ddo_pedidoretirada_Internalname, "SelectedValue_set", Ddo_pedidoretirada_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFPEDIDOTOTAL") == 0 )
            {
               AV82TFPedidoTotal = NumberUtil.Val( AV11GridStateFilterValue.gxTpr_Value, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV82TFPedidoTotal", StringUtil.LTrim( StringUtil.Str( AV82TFPedidoTotal, 12, 2)));
               AV83TFPedidoTotal_To = NumberUtil.Val( AV11GridStateFilterValue.gxTpr_Valueto, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV83TFPedidoTotal_To", StringUtil.LTrim( StringUtil.Str( AV83TFPedidoTotal_To, 12, 2)));
               if ( ! (Convert.ToDecimal(0)==AV82TFPedidoTotal) )
               {
                  Ddo_pedidototal_Filteredtext_set = StringUtil.Str( AV82TFPedidoTotal, 12, 2);
                  ucDdo_pedidototal.SendProperty(context, "", false, Ddo_pedidototal_Internalname, "FilteredText_set", Ddo_pedidototal_Filteredtext_set);
               }
               if ( ! (Convert.ToDecimal(0)==AV83TFPedidoTotal_To) )
               {
                  Ddo_pedidototal_Filteredtextto_set = StringUtil.Str( AV83TFPedidoTotal_To, 12, 2);
                  ucDdo_pedidototal.SendProperty(context, "", false, Ddo_pedidototal_Internalname, "FilteredTextTo_set", Ddo_pedidototal_Filteredtextto_set);
               }
            }
            AV133GXV2 = (int)(AV133GXV2+1);
         }
      }

      protected void S152( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV10GridState.FromXml(AV51Session.Get(AV131Pgmname+"GridState"), null, "WWPGridState", "FMX");
         AV10GridState.gxTpr_Orderedby = AV13OrderedBy;
         AV10GridState.gxTpr_Ordereddsc = AV14OrderedDsc;
         AV10GridState.gxTpr_Filtervalues.Clear();
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV94PessoaNome)) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "PESSOANOME";
            AV11GridStateFilterValue.gxTpr_Value = AV94PessoaNome;
            AV11GridStateFilterValue.gxTpr_Operator = AV93PessoaNomeOperator;
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! ( (DateTime.MinValue==AV99PedidoDt) && (DateTime.MinValue==AV100PedidoDt_To) ) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "PEDIDODT";
            AV11GridStateFilterValue.gxTpr_Value = context.localUtil.DToC( AV99PedidoDt, 2, "/");
            AV11GridStateFilterValue.gxTpr_Valueto = context.localUtil.DToC( AV100PedidoDt_To, 2, "/");
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! ( (DateTime.MinValue==AV101PedidoDtEntrega) && (DateTime.MinValue==AV102PedidoDtEntrega_To) ) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "PEDIDODTENTREGA";
            AV11GridStateFilterValue.gxTpr_Value = context.localUtil.DToC( AV101PedidoDtEntrega, 2, "/");
            AV11GridStateFilterValue.gxTpr_Valueto = context.localUtil.DToC( AV102PedidoDtEntrega_To, 2, "/");
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV103PedidoStatus)) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "PEDIDOSTATUS";
            AV11GridStateFilterValue.gxTpr_Value = AV103PedidoStatus;
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! ( (0==AV59TFPedidoId) && (0==AV60TFPedidoId_To) ) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFPEDIDOID";
            AV11GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV59TFPedidoId), 4, 0);
            AV11GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV60TFPedidoId_To), 4, 0);
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV96TFPessoaNome)) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFPESSOANOME";
            AV11GridStateFilterValue.gxTpr_Value = AV96TFPessoaNome;
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV97TFPessoaNome_Sel)) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFPESSOANOME_SEL";
            AV11GridStateFilterValue.gxTpr_Value = AV97TFPessoaNome_Sel;
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! ( (DateTime.MinValue==AV63TFPedidoDt) && (DateTime.MinValue==AV64TFPedidoDt_To) ) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFPEDIDODT";
            AV11GridStateFilterValue.gxTpr_Value = context.localUtil.DToC( AV63TFPedidoDt, 2, "/");
            AV11GridStateFilterValue.gxTpr_Valueto = context.localUtil.DToC( AV64TFPedidoDt_To, 2, "/");
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! ( AV70TFPedidoStatus_Sels.Count == 0 ) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFPEDIDOSTATUS_SEL";
            AV11GridStateFilterValue.gxTpr_Value = AV70TFPedidoStatus_Sels.ToJSonString(false);
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! ( (DateTime.MinValue==AV73TFPedidoDtEntrega) && (DateTime.MinValue==AV74TFPedidoDtEntrega_To) ) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFPEDIDODTENTREGA";
            AV11GridStateFilterValue.gxTpr_Value = context.localUtil.DToC( AV73TFPedidoDtEntrega, 2, "/");
            AV11GridStateFilterValue.gxTpr_Valueto = context.localUtil.DToC( AV74TFPedidoDtEntrega_To, 2, "/");
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! (0==AV79TFPedidoRetirada_Sel) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFPEDIDORETIRADA_SEL";
            AV11GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV79TFPedidoRetirada_Sel), 1, 0);
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! ( (Convert.ToDecimal(0)==AV82TFPedidoTotal) && (Convert.ToDecimal(0)==AV83TFPedidoTotal_To) ) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFPEDIDOTOTAL";
            AV11GridStateFilterValue.gxTpr_Value = StringUtil.Str( AV82TFPedidoTotal, 12, 2);
            AV11GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( AV83TFPedidoTotal_To, 12, 2);
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         AV10GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV10GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV131Pgmname+"GridState",  AV10GridState.ToXml(false, true, "WWPGridState", "FMX")) ;
      }

      protected void S122( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV8TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV8TrnContext.gxTpr_Callerobject = AV131Pgmname;
         AV8TrnContext.gxTpr_Callerondelete = true;
         AV8TrnContext.gxTpr_Callerurl = AV7HTTPRequest.ScriptName+"?"+AV7HTTPRequest.QueryString;
         AV8TrnContext.gxTpr_Transactionname = "Pedido";
         AV51Session.Set("TrnContext", AV8TrnContext.ToXml(false, true, "WWPTransactionContext", "FMX"));
      }

      protected void E26132( )
      {
         /* Aprovar_Click Routine */
         if ( StringUtil.StrCmp(A34PedidoStatus, "AGD") == 0 )
         {
            AV108Status = "APR";
            new prc_alterarstatus(context ).execute(  A32PedidoId,  AV108Status) ;
            gxgrGrid_refresh( subGrid_Rows, AV93PessoaNomeOperator, AV94PessoaNome, AV99PedidoDt, AV100PedidoDt_To, AV101PedidoDtEntrega, AV102PedidoDtEntrega_To, AV103PedidoStatus, AV13OrderedBy, AV14OrderedDsc, AV59TFPedidoId, AV60TFPedidoId_To, AV96TFPessoaNome, AV97TFPessoaNome_Sel, AV63TFPedidoDt, AV64TFPedidoDt_To, AV73TFPedidoDtEntrega, AV74TFPedidoDtEntrega_To, AV79TFPedidoRetirada_Sel, AV82TFPedidoTotal, AV83TFPedidoTotal_To, AV52ManageFiltersExecutionStep, AV44ColumnsSelector, AV61ddo_PedidoIdTitleControlIdToReplace, AV98ddo_PessoaNomeTitleControlIdToReplace, AV67ddo_PedidoDtTitleControlIdToReplace, AV71ddo_PedidoStatusTitleControlIdToReplace, AV77ddo_PedidoDtEntregaTitleControlIdToReplace, AV80ddo_PedidoRetiradaTitleControlIdToReplace, AV84ddo_PedidoTotalTitleControlIdToReplace, AV70TFPedidoStatus_Sels, AV131Pgmname) ;
         }
         else
         {
            GX_msglist.addItem("O pedido já esta "+gxdomainstatuspedido.getDescription(context,A34PedidoStatus));
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58PedidoIdTitleFilterData", AV58PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV95PessoaNomeTitleFilterData", AV95PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62PedidoDtTitleFilterData", AV62PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68PedidoStatusTitleFilterData", AV68PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV72PedidoDtEntregaTitleFilterData", AV72PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78PedidoRetiradaTitleFilterData", AV78PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV81PedidoTotalTitleFilterData", AV81PedidoTotalTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E27132( )
      {
         /* Encerrar_Click Routine */
         if ( ( StringUtil.StrCmp(A34PedidoStatus, "APR") == 0 ) || ( StringUtil.StrCmp(A34PedidoStatus, "REP") == 0 ) )
         {
            AV108Status = "ENC";
            new prc_alterarstatus(context ).execute(  A32PedidoId,  AV108Status) ;
            gxgrGrid_refresh( subGrid_Rows, AV93PessoaNomeOperator, AV94PessoaNome, AV99PedidoDt, AV100PedidoDt_To, AV101PedidoDtEntrega, AV102PedidoDtEntrega_To, AV103PedidoStatus, AV13OrderedBy, AV14OrderedDsc, AV59TFPedidoId, AV60TFPedidoId_To, AV96TFPessoaNome, AV97TFPessoaNome_Sel, AV63TFPedidoDt, AV64TFPedidoDt_To, AV73TFPedidoDtEntrega, AV74TFPedidoDtEntrega_To, AV79TFPedidoRetirada_Sel, AV82TFPedidoTotal, AV83TFPedidoTotal_To, AV52ManageFiltersExecutionStep, AV44ColumnsSelector, AV61ddo_PedidoIdTitleControlIdToReplace, AV98ddo_PessoaNomeTitleControlIdToReplace, AV67ddo_PedidoDtTitleControlIdToReplace, AV71ddo_PedidoStatusTitleControlIdToReplace, AV77ddo_PedidoDtEntregaTitleControlIdToReplace, AV80ddo_PedidoRetiradaTitleControlIdToReplace, AV84ddo_PedidoTotalTitleControlIdToReplace, AV70TFPedidoStatus_Sels, AV131Pgmname) ;
         }
         else
         {
            if ( StringUtil.StrCmp(A34PedidoStatus, "AGD") == 0 )
            {
               GX_msglist.addItem("É necessario aprovar ou reprovar o pedido primeiro");
            }
            else
            {
               GX_msglist.addItem("O pedido já esta "+gxdomainstatuspedido.getDescription(context,A34PedidoStatus));
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58PedidoIdTitleFilterData", AV58PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV95PessoaNomeTitleFilterData", AV95PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62PedidoDtTitleFilterData", AV62PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68PedidoStatusTitleFilterData", AV68PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV72PedidoDtEntregaTitleFilterData", AV72PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78PedidoRetiradaTitleFilterData", AV78PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV81PedidoTotalTitleFilterData", AV81PedidoTotalTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E28132( )
      {
         /* Reprovar_Click Routine */
         if ( StringUtil.StrCmp(A34PedidoStatus, "AGD") == 0 )
         {
            AV108Status = "REP";
            new prc_alterarstatus(context ).execute(  A32PedidoId,  AV108Status) ;
            gxgrGrid_refresh( subGrid_Rows, AV93PessoaNomeOperator, AV94PessoaNome, AV99PedidoDt, AV100PedidoDt_To, AV101PedidoDtEntrega, AV102PedidoDtEntrega_To, AV103PedidoStatus, AV13OrderedBy, AV14OrderedDsc, AV59TFPedidoId, AV60TFPedidoId_To, AV96TFPessoaNome, AV97TFPessoaNome_Sel, AV63TFPedidoDt, AV64TFPedidoDt_To, AV73TFPedidoDtEntrega, AV74TFPedidoDtEntrega_To, AV79TFPedidoRetirada_Sel, AV82TFPedidoTotal, AV83TFPedidoTotal_To, AV52ManageFiltersExecutionStep, AV44ColumnsSelector, AV61ddo_PedidoIdTitleControlIdToReplace, AV98ddo_PessoaNomeTitleControlIdToReplace, AV67ddo_PedidoDtTitleControlIdToReplace, AV71ddo_PedidoStatusTitleControlIdToReplace, AV77ddo_PedidoDtEntregaTitleControlIdToReplace, AV80ddo_PedidoRetiradaTitleControlIdToReplace, AV84ddo_PedidoTotalTitleControlIdToReplace, AV70TFPedidoStatus_Sels, AV131Pgmname) ;
         }
         else
         {
            GX_msglist.addItem("O pedido já esta "+gxdomainstatuspedido.getDescription(context,A34PedidoStatus));
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58PedidoIdTitleFilterData", AV58PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV95PessoaNomeTitleFilterData", AV95PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62PedidoDtTitleFilterData", AV62PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68PedidoStatusTitleFilterData", AV68PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV72PedidoDtEntregaTitleFilterData", AV72PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78PedidoRetiradaTitleFilterData", AV78PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV81PedidoTotalTitleFilterData", AV81PedidoTotalTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void wb_table1_23_132( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablerightheader_Internalname, tblTablerightheader_Internalname, "", "", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='CellAlignTopPaddingTop2'>") ;
            /* User Defined Control */
            ucDdo_managefilters.SetProperty("Caption", Ddo_managefilters_Caption);
            ucDdo_managefilters.SetProperty("Tooltip", Ddo_managefilters_Tooltip);
            ucDdo_managefilters.SetProperty("Cls", Ddo_managefilters_Cls);
            ucDdo_managefilters.SetProperty("DropDownOptionsData", AV56ManageFiltersData);
            ucDdo_managefilters.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_managefilters_Internalname, "DDO_MANAGEFILTERSContainer");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_28_132( true) ;
         }
         else
         {
            wb_table2_28_132( false) ;
         }
         return  ;
      }

      protected void wb_table2_28_132e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_23_132e( true) ;
         }
         else
         {
            wb_table1_23_132e( false) ;
         }
      }

      protected void wb_table2_28_132( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablefilters_Internalname, tblTablefilters_Internalname, "", "", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedfiltertextpessoanome_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblFiltertextpessoanome_Internalname, "Nome", "", "", lblFiltertextpessoanome_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescription", 0, "", 1, 1, 0, "HLP_PedidoWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table3_36_132( true) ;
         }
         else
         {
            wb_table3_36_132( false) ;
         }
         return  ;
      }

      protected void wb_table3_36_132e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedfiltertextpedidodt_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblFiltertextpedidodt_Internalname, "Data do Pedido", "", "", lblFiltertextpedidodt_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescription", 0, "", 1, 1, 0, "HLP_PedidoWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table4_51_132( true) ;
         }
         else
         {
            wb_table4_51_132( false) ;
         }
         return  ;
      }

      protected void wb_table4_51_132e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedfiltertextpedidodtentrega_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblFiltertextpedidodtentrega_Internalname, "Data de Entrega", "", "", lblFiltertextpedidodtentrega_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescription", 0, "", 1, 1, 0, "HLP_PedidoWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table5_68_132( true) ;
         }
         else
         {
            wb_table5_68_132( false) ;
         }
         return  ;
      }

      protected void wb_table5_68_132e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavPedidostatus_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavPedidostatus_Internalname, "Status", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 82,'',false,'" + sGXsfl_91_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavPedidostatus, cmbavPedidostatus_Internalname, StringUtil.RTrim( AV103PedidoStatus), 1, cmbavPedidostatus_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbavPedidostatus.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,82);\"", "", true, "HLP_PedidoWW.htm");
            cmbavPedidostatus.CurrentValue = StringUtil.RTrim( AV103PedidoStatus);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavPedidostatus_Internalname, "Values", (String)(cmbavPedidostatus.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_28_132e( true) ;
         }
         else
         {
            wb_table2_28_132e( false) ;
         }
      }

      protected void wb_table5_68_132( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedpedidodtentrega_Internalname, tblTablemergedpedidodtentrega_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavPedidodtentrega_Internalname, "Pedido Dt Entrega", "col-sm-3 AttributeDateLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'" + sGXsfl_91_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavPedidodtentrega_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavPedidodtentrega_Internalname, context.localUtil.Format(AV101PedidoDtEntrega, "99/99/99"), context.localUtil.Format( AV101PedidoDtEntrega, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,72);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPedidodtentrega_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavPedidodtentrega_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PedidoWW.htm");
            GxWebStd.gx_bitmap( context, edtavPedidodtentrega_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavPedidodtentrega_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_PedidoWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblPedidodtentrega_rangemiddletext_Internalname, "até", "", "", lblPedidodtentrega_rangemiddletext_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescription", 0, "", 1, 1, 0, "HLP_PedidoWW.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavPedidodtentrega_to_Internalname, "Pedido Dt Entrega_To", "col-sm-3 AttributeDateLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'" + sGXsfl_91_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavPedidodtentrega_to_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavPedidodtentrega_to_Internalname, context.localUtil.Format(AV102PedidoDtEntrega_To, "99/99/99"), context.localUtil.Format( AV102PedidoDtEntrega_To, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,77);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPedidodtentrega_to_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavPedidodtentrega_to_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PedidoWW.htm");
            GxWebStd.gx_bitmap( context, edtavPedidodtentrega_to_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavPedidodtentrega_to_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_PedidoWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_68_132e( true) ;
         }
         else
         {
            wb_table5_68_132e( false) ;
         }
      }

      protected void wb_table4_51_132( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedpedidodt_Internalname, tblTablemergedpedidodt_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavPedidodt_Internalname, "Pedido Dt", "col-sm-3 AttributeDateLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'" + sGXsfl_91_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavPedidodt_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavPedidodt_Internalname, context.localUtil.Format(AV99PedidoDt, "99/99/99"), context.localUtil.Format( AV99PedidoDt, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPedidodt_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavPedidodt_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PedidoWW.htm");
            GxWebStd.gx_bitmap( context, edtavPedidodt_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavPedidodt_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_PedidoWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblPedidodt_rangemiddletext_Internalname, "até", "", "", lblPedidodt_rangemiddletext_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescription", 0, "", 1, 1, 0, "HLP_PedidoWW.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavPedidodt_to_Internalname, "Pedido Dt_To", "col-sm-3 AttributeDateLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'" + sGXsfl_91_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavPedidodt_to_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavPedidodt_to_Internalname, context.localUtil.Format(AV100PedidoDt_To, "99/99/99"), context.localUtil.Format( AV100PedidoDt_To, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,60);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPedidodt_to_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavPedidodt_to_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PedidoWW.htm");
            GxWebStd.gx_bitmap( context, edtavPedidodt_to_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavPedidodt_to_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_PedidoWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_51_132e( true) ;
         }
         else
         {
            wb_table4_51_132e( false) ;
         }
      }

      protected void wb_table3_36_132( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedpessoanome_Internalname, tblTablemergedpessoanome_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavPessoanomeoperator_Internalname, "Pessoa Nome Operator", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'" + sGXsfl_91_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavPessoanomeoperator, cmbavPessoanomeoperator_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV93PessoaNomeOperator), 4, 0)), 1, cmbavPessoanomeoperator_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbavPessoanomeoperator.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,40);\"", "", true, "HLP_PedidoWW.htm");
            cmbavPessoanomeoperator.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV93PessoaNomeOperator), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavPessoanomeoperator_Internalname, "Values", (String)(cmbavPessoanomeoperator.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavPessoanome_Internalname, "Pessoa Nome", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'" + sGXsfl_91_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavPessoanome_Internalname, AV94PessoaNome, StringUtil.RTrim( context.localUtil.Format( AV94PessoaNome, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPessoanome_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavPessoanome_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_PedidoWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_36_132e( true) ;
         }
         else
         {
            wb_table3_36_132e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
      }

      public override String getresponse( String sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         sDynURL = sGXDynURL;
         nGotPars = (short)(1);
         nGXWrapped = (short)(1);
         context.SetWrapped(true);
         PA132( ) ;
         WS132( ) ;
         WE132( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("DVelop/DVPaginationBar/DVPaginationBar.css", "");
         AddStyleSheetFile("DVelop/Bootstrap/Shared/fontawesome_v5/css/font-awesome.min.css", "");
         AddStyleSheetFile("DVelop/Bootstrap/Shared/DVelopBootstrap.css", "");
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20197121804750", true, true);
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
         context.AddJavascriptSource("pedidoww.js", "?20197121804751", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/DVPaginationBar/DVPaginationBarRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false, true);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_912( )
      {
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_91_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_91_idx;
         edtavEncerrar_Internalname = "vENCERRAR_"+sGXsfl_91_idx;
         edtavAprovar_Internalname = "vAPROVAR_"+sGXsfl_91_idx;
         edtavReprovar_Internalname = "vREPROVAR_"+sGXsfl_91_idx;
         edtPedidoId_Internalname = "PEDIDOID_"+sGXsfl_91_idx;
         edtPessoaNome_Internalname = "PESSOANOME_"+sGXsfl_91_idx;
         edtPedidoDt_Internalname = "PEDIDODT_"+sGXsfl_91_idx;
         cmbPedidoStatus_Internalname = "PEDIDOSTATUS_"+sGXsfl_91_idx;
         edtPedidoDtEntrega_Internalname = "PEDIDODTENTREGA_"+sGXsfl_91_idx;
         chkPedidoRetirada_Internalname = "PEDIDORETIRADA_"+sGXsfl_91_idx;
         edtPedidoTotal_Internalname = "PEDIDOTOTAL_"+sGXsfl_91_idx;
      }

      protected void SubsflControlProps_fel_912( )
      {
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_91_fel_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_91_fel_idx;
         edtavEncerrar_Internalname = "vENCERRAR_"+sGXsfl_91_fel_idx;
         edtavAprovar_Internalname = "vAPROVAR_"+sGXsfl_91_fel_idx;
         edtavReprovar_Internalname = "vREPROVAR_"+sGXsfl_91_fel_idx;
         edtPedidoId_Internalname = "PEDIDOID_"+sGXsfl_91_fel_idx;
         edtPessoaNome_Internalname = "PESSOANOME_"+sGXsfl_91_fel_idx;
         edtPedidoDt_Internalname = "PEDIDODT_"+sGXsfl_91_fel_idx;
         cmbPedidoStatus_Internalname = "PEDIDOSTATUS_"+sGXsfl_91_fel_idx;
         edtPedidoDtEntrega_Internalname = "PEDIDODTENTREGA_"+sGXsfl_91_fel_idx;
         chkPedidoRetirada_Internalname = "PEDIDORETIRADA_"+sGXsfl_91_fel_idx;
         edtPedidoTotal_Internalname = "PEDIDOTOTAL_"+sGXsfl_91_fel_idx;
      }

      protected void sendrow_912( )
      {
         SubsflControlProps_912( ) ;
         WB130( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_91_idx <= subGrid_Recordsperpage( ) * 1 ) )
         {
            GridRow = GXWebRow.GetNew(context,GridContainer);
            if ( subGrid_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGrid_Backstyle = 0;
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Odd";
               }
            }
            else if ( subGrid_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGrid_Backstyle = 0;
               subGrid_Backcolor = subGrid_Allbackcolor;
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Uniform";
               }
            }
            else if ( subGrid_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGrid_Backstyle = 1;
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Odd";
               }
               subGrid_Backcolor = (int)(0x0);
            }
            else if ( subGrid_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid_Backstyle = 1;
               if ( ((int)(((nGXsfl_91_idx-1)/ (decimal)(1)) % (2))) == 0 )
               {
                  subGrid_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Odd";
                  }
               }
               else
               {
                  subGrid_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Even";
                  }
               }
            }
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+"GridWithPaginationBar GridNoBorder WorkWith"+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( " gxrow=\""+sGXsfl_91_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavUpdate_Enabled!=0)&&(edtavUpdate_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 92,'',false,'"+sGXsfl_91_idx+"',91)\"" : " ");
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,StringUtil.RTrim( AV89Update),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+((edtavUpdate_Enabled!=0)&&(edtavUpdate_Visible!=0) ? " onblur=\""+";gx.evt.onblur(this,92);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtavUpdate_Link,(String)"",(String)"Modifica",(String)"",(String)edtavUpdate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWIconActionColumn",(String)"",(short)-1,(int)edtavUpdate_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)1,(short)91,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavDelete_Enabled!=0)&&(edtavDelete_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 93,'',false,'"+sGXsfl_91_idx+"',91)\"" : " ");
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,StringUtil.RTrim( AV90Delete),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+((edtavDelete_Enabled!=0)&&(edtavDelete_Visible!=0) ? " onblur=\""+";gx.evt.onblur(this,93);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtavDelete_Link,(String)"",(String)"Eliminar",(String)"",(String)edtavDelete_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWIconActionColumn",(String)"",(short)-1,(int)edtavDelete_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)1,(short)91,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavEncerrar_Enabled!=0)&&(edtavEncerrar_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 94,'',false,'"+sGXsfl_91_idx+"',91)\"" : " ");
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavEncerrar_Internalname,StringUtil.RTrim( AV92Encerrar),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+((edtavEncerrar_Enabled!=0)&&(edtavEncerrar_Visible!=0) ? " onblur=\""+";gx.evt.onblur(this,94);\"" : " "),"'"+""+"'"+",false,"+"'"+"EVENCERRAR.CLICK."+sGXsfl_91_idx+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavEncerrar_Jsonclick,(short)5,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWActionColumn",(String)"",(short)-1,(int)edtavEncerrar_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)91,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavAprovar_Enabled!=0)&&(edtavAprovar_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 95,'',false,'"+sGXsfl_91_idx+"',91)\"" : " ");
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavAprovar_Internalname,StringUtil.RTrim( AV106Aprovar),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+((edtavAprovar_Enabled!=0)&&(edtavAprovar_Visible!=0) ? " onblur=\""+";gx.evt.onblur(this,95);\"" : " "),"'"+""+"'"+",false,"+"'"+"EVAPROVAR.CLICK."+sGXsfl_91_idx+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavAprovar_Jsonclick,(short)5,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWActionColumn",(String)"",(short)-1,(int)edtavAprovar_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)91,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavReprovar_Enabled!=0)&&(edtavReprovar_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 96,'',false,'"+sGXsfl_91_idx+"',91)\"" : " ");
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavReprovar_Internalname,StringUtil.RTrim( AV107Reprovar),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+((edtavReprovar_Enabled!=0)&&(edtavReprovar_Visible!=0) ? " onblur=\""+";gx.evt.onblur(this,96);\"" : " "),"'"+""+"'"+",false,"+"'"+"EVREPROVAR.CLICK."+sGXsfl_91_idx+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavReprovar_Jsonclick,(short)5,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWActionColumn",(String)"",(short)-1,(int)edtavReprovar_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)91,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((edtPedidoId_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPedidoId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A32PedidoId), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A32PedidoId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPedidoId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(int)edtPedidoId_Visible,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)91,(short)1,(short)-1,(short)0,(bool)true,(String)"Serial",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((edtPessoaNome_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPessoaNome_Internalname,(String)A2PessoaNome,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPessoaNome_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(int)edtPessoaNome_Visible,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)60,(short)0,(short)0,(short)91,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((edtPedidoDt_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPedidoDt_Internalname,context.localUtil.Format(A33PedidoDt, "99/99/99"),context.localUtil.Format( A33PedidoDt, "99/99/99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtPedidoDt_Link,(String)"",(String)"",(String)"",(String)edtPedidoDt_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(int)edtPedidoDt_Visible,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)91,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((cmbPedidoStatus.Visible==0) ? "display:none;" : "")+"\">") ;
            }
            if ( ( cmbPedidoStatus.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "PEDIDOSTATUS_" + sGXsfl_91_idx;
               cmbPedidoStatus.Name = GXCCtl;
               cmbPedidoStatus.WebTags = "";
               cmbPedidoStatus.addItem("AGD", "Aguardando Aprovação", 0);
               cmbPedidoStatus.addItem("APR", "Aprovado", 0);
               cmbPedidoStatus.addItem("REP", "Reprovado", 0);
               cmbPedidoStatus.addItem("ENC", "Encerrado", 0);
               if ( cmbPedidoStatus.ItemCount > 0 )
               {
                  A34PedidoStatus = cmbPedidoStatus.getValidValue(A34PedidoStatus);
               }
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbPedidoStatus,(String)cmbPedidoStatus_Internalname,StringUtil.RTrim( A34PedidoStatus),(short)1,(String)cmbPedidoStatus_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"svchar",(String)"",cmbPedidoStatus.Visible,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn hidden-xs",(String)"",(String)"",(String)"",(bool)true});
            cmbPedidoStatus.CurrentValue = StringUtil.RTrim( A34PedidoStatus);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPedidoStatus_Internalname, "Values", (String)(cmbPedidoStatus.ToJavascriptSource()), !bGXsfl_91_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((edtPedidoDtEntrega_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPedidoDtEntrega_Internalname,context.localUtil.Format(A35PedidoDtEntrega, "99/99/99"),context.localUtil.Format( A35PedidoDtEntrega, "99/99/99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPedidoDtEntrega_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(int)edtPedidoDtEntrega_Visible,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)91,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((chkPedidoRetirada.Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Check box */
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GridRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkPedidoRetirada_Internalname,StringUtil.BoolToStr( A36PedidoRetirada),(String)"",(String)"",chkPedidoRetirada.Visible,(short)0,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn hidden-xs",(String)"",(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((edtPedidoTotal_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPedidoTotal_Internalname,StringUtil.LTrim( StringUtil.NToC( A37PedidoTotal, 18, 2, ",", "")),context.localUtil.Format( A37PedidoTotal, "R$ Z,ZZZ,ZZ,ZZ9.99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPedidoTotal_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(int)edtPedidoTotal_Visible,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)91,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            send_integrity_lvl_hashes132( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_91_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_91_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_91_idx+1));
            sGXsfl_91_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_91_idx), 4, 0)), 4, "0");
            SubsflControlProps_912( ) ;
         }
         /* End function sendrow_912 */
      }

      protected void init_web_controls( )
      {
         cmbavPessoanomeoperator.Name = "vPESSOANOMEOPERATOR";
         cmbavPessoanomeoperator.WebTags = "";
         cmbavPessoanomeoperator.addItem("0", "Contém", 0);
         if ( cmbavPessoanomeoperator.ItemCount > 0 )
         {
            AV93PessoaNomeOperator = (short)(NumberUtil.Val( cmbavPessoanomeoperator.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV93PessoaNomeOperator), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV93PessoaNomeOperator", StringUtil.LTrim( StringUtil.Str( (decimal)(AV93PessoaNomeOperator), 4, 0)));
         }
         cmbavPedidostatus.Name = "vPEDIDOSTATUS";
         cmbavPedidostatus.WebTags = "";
         cmbavPedidostatus.addItem("", "Todos", 0);
         cmbavPedidostatus.addItem("AGD", "Aguardando Aprovação", 0);
         cmbavPedidostatus.addItem("APR", "Aprovado", 0);
         cmbavPedidostatus.addItem("REP", "Reprovado", 0);
         cmbavPedidostatus.addItem("ENC", "Encerrado", 0);
         if ( cmbavPedidostatus.ItemCount > 0 )
         {
            AV103PedidoStatus = cmbavPedidostatus.getValidValue(AV103PedidoStatus);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV103PedidoStatus", AV103PedidoStatus);
         }
         GXCCtl = "PEDIDOSTATUS_" + sGXsfl_91_idx;
         cmbPedidoStatus.Name = GXCCtl;
         cmbPedidoStatus.WebTags = "";
         cmbPedidoStatus.addItem("AGD", "Aguardando Aprovação", 0);
         cmbPedidoStatus.addItem("APR", "Aprovado", 0);
         cmbPedidoStatus.addItem("REP", "Reprovado", 0);
         cmbPedidoStatus.addItem("ENC", "Encerrado", 0);
         if ( cmbPedidoStatus.ItemCount > 0 )
         {
            A34PedidoStatus = cmbPedidoStatus.getValidValue(A34PedidoStatus);
         }
         GXCCtl = "PEDIDORETIRADA_" + sGXsfl_91_idx;
         chkPedidoRetirada.Name = GXCCtl;
         chkPedidoRetirada.WebTags = "";
         chkPedidoRetirada.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkPedidoRetirada_Internalname, "TitleCaption", chkPedidoRetirada.Caption, !bGXsfl_91_Refreshing);
         chkPedidoRetirada.CheckedValue = "false";
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttBtninsert_Internalname = "BTNINSERT";
         bttBtneditcolumns_Internalname = "BTNEDITCOLUMNS";
         divTableactions_Internalname = "TABLEACTIONS";
         Ddo_managefilters_Internalname = "DDO_MANAGEFILTERS";
         lblFiltertextpessoanome_Internalname = "FILTERTEXTPESSOANOME";
         cmbavPessoanomeoperator_Internalname = "vPESSOANOMEOPERATOR";
         edtavPessoanome_Internalname = "vPESSOANOME";
         tblTablemergedpessoanome_Internalname = "TABLEMERGEDPESSOANOME";
         divTablesplittedfiltertextpessoanome_Internalname = "TABLESPLITTEDFILTERTEXTPESSOANOME";
         lblFiltertextpedidodt_Internalname = "FILTERTEXTPEDIDODT";
         edtavPedidodt_Internalname = "vPEDIDODT";
         lblPedidodt_rangemiddletext_Internalname = "PEDIDODT_RANGEMIDDLETEXT";
         edtavPedidodt_to_Internalname = "vPEDIDODT_TO";
         tblTablemergedpedidodt_Internalname = "TABLEMERGEDPEDIDODT";
         divTablesplittedfiltertextpedidodt_Internalname = "TABLESPLITTEDFILTERTEXTPEDIDODT";
         lblFiltertextpedidodtentrega_Internalname = "FILTERTEXTPEDIDODTENTREGA";
         edtavPedidodtentrega_Internalname = "vPEDIDODTENTREGA";
         lblPedidodtentrega_rangemiddletext_Internalname = "PEDIDODTENTREGA_RANGEMIDDLETEXT";
         edtavPedidodtentrega_to_Internalname = "vPEDIDODTENTREGA_TO";
         tblTablemergedpedidodtentrega_Internalname = "TABLEMERGEDPEDIDODTENTREGA";
         divTablesplittedfiltertextpedidodtentrega_Internalname = "TABLESPLITTEDFILTERTEXTPEDIDODTENTREGA";
         cmbavPedidostatus_Internalname = "vPEDIDOSTATUS";
         tblTablefilters_Internalname = "TABLEFILTERS";
         tblTablerightheader_Internalname = "TABLERIGHTHEADER";
         divTableheader_Internalname = "TABLEHEADER";
         Dvpanel_tableheader_Internalname = "DVPANEL_TABLEHEADER";
         edtavUpdate_Internalname = "vUPDATE";
         edtavDelete_Internalname = "vDELETE";
         edtavEncerrar_Internalname = "vENCERRAR";
         edtavAprovar_Internalname = "vAPROVAR";
         edtavReprovar_Internalname = "vREPROVAR";
         edtPedidoId_Internalname = "PEDIDOID";
         edtPessoaNome_Internalname = "PESSOANOME";
         edtPedidoDt_Internalname = "PEDIDODT";
         cmbPedidoStatus_Internalname = "PEDIDOSTATUS";
         edtPedidoDtEntrega_Internalname = "PEDIDODTENTREGA";
         chkPedidoRetirada_Internalname = "PEDIDORETIRADA";
         edtPedidoTotal_Internalname = "PEDIDOTOTAL";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_pedidoid_Internalname = "DDO_PEDIDOID";
         edtavDdo_pedidoidtitlecontrolidtoreplace_Internalname = "vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE";
         Ddo_pessoanome_Internalname = "DDO_PESSOANOME";
         edtavDdo_pessoanometitlecontrolidtoreplace_Internalname = "vDDO_PESSOANOMETITLECONTROLIDTOREPLACE";
         Ddo_pedidodt_Internalname = "DDO_PEDIDODT";
         edtavDdo_pedidodttitlecontrolidtoreplace_Internalname = "vDDO_PEDIDODTTITLECONTROLIDTOREPLACE";
         Ddo_pedidostatus_Internalname = "DDO_PEDIDOSTATUS";
         edtavDdo_pedidostatustitlecontrolidtoreplace_Internalname = "vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE";
         Ddo_pedidodtentrega_Internalname = "DDO_PEDIDODTENTREGA";
         edtavDdo_pedidodtentregatitlecontrolidtoreplace_Internalname = "vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE";
         Ddo_pedidoretirada_Internalname = "DDO_PEDIDORETIRADA";
         edtavDdo_pedidoretiradatitlecontrolidtoreplace_Internalname = "vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE";
         Ddo_pedidototal_Internalname = "DDO_PEDIDOTOTAL";
         edtavDdo_pedidototaltitlecontrolidtoreplace_Internalname = "vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE";
         Workwithplusutilities1_Internalname = "WORKWITHPLUSUTILITIES1";
         Ddo_gridcolumnsselector_Internalname = "DDO_GRIDCOLUMNSSELECTOR";
         edtavOrderedby_Internalname = "vORDEREDBY";
         edtavOrdereddsc_Internalname = "vORDEREDDSC";
         edtavManagefiltersexecutionstep_Internalname = "vMANAGEFILTERSEXECUTIONSTEP";
         edtavTfpedidoid_Internalname = "vTFPEDIDOID";
         edtavTfpedidoid_to_Internalname = "vTFPEDIDOID_TO";
         edtavTfpessoanome_Internalname = "vTFPESSOANOME";
         edtavTfpessoanome_sel_Internalname = "vTFPESSOANOME_SEL";
         edtavTfpedidodt_Internalname = "vTFPEDIDODT";
         edtavTfpedidodt_to_Internalname = "vTFPEDIDODT_TO";
         edtavDdo_pedidodtauxdate_Internalname = "vDDO_PEDIDODTAUXDATE";
         edtavDdo_pedidodtauxdateto_Internalname = "vDDO_PEDIDODTAUXDATETO";
         divDdo_pedidodtauxdates_Internalname = "DDO_PEDIDODTAUXDATES";
         edtavTfpedidodtentrega_Internalname = "vTFPEDIDODTENTREGA";
         edtavTfpedidodtentrega_to_Internalname = "vTFPEDIDODTENTREGA_TO";
         edtavDdo_pedidodtentregaauxdate_Internalname = "vDDO_PEDIDODTENTREGAAUXDATE";
         edtavDdo_pedidodtentregaauxdateto_Internalname = "vDDO_PEDIDODTENTREGAAUXDATETO";
         divDdo_pedidodtentregaauxdates_Internalname = "DDO_PEDIDODTENTREGAAUXDATES";
         edtavTfpedidoretirada_sel_Internalname = "vTFPEDIDORETIRADA_SEL";
         edtavTfpedidototal_Internalname = "vTFPEDIDOTOTAL";
         edtavTfpedidototal_to_Internalname = "vTFPEDIDOTOTAL_TO";
         divHtml_bottomauxiliarcontrols_Internalname = "HTML_BOTTOMAUXILIARCONTROLS";
         divLayoutmaintable_Internalname = "LAYOUTMAINTABLE";
         Form.Internalname = "FORM";
         subGrid_Internalname = "GRID";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         chkPedidoRetirada.Caption = "";
         edtPedidoTotal_Jsonclick = "";
         edtPedidoDtEntrega_Jsonclick = "";
         cmbPedidoStatus_Jsonclick = "";
         edtPedidoDt_Jsonclick = "";
         edtPessoaNome_Jsonclick = "";
         edtPedidoId_Jsonclick = "";
         edtavReprovar_Jsonclick = "";
         edtavReprovar_Visible = -1;
         edtavAprovar_Jsonclick = "";
         edtavAprovar_Visible = -1;
         edtavEncerrar_Jsonclick = "";
         edtavEncerrar_Visible = -1;
         edtavDelete_Jsonclick = "";
         edtavDelete_Visible = -1;
         edtavUpdate_Jsonclick = "";
         edtavUpdate_Visible = -1;
         edtavPessoanome_Jsonclick = "";
         edtavPessoanome_Enabled = 1;
         cmbavPessoanomeoperator_Jsonclick = "";
         cmbavPessoanomeoperator.Enabled = 1;
         edtavPedidodt_to_Jsonclick = "";
         edtavPedidodt_to_Enabled = 1;
         edtavPedidodt_Jsonclick = "";
         edtavPedidodt_Enabled = 1;
         edtavPedidodtentrega_to_Jsonclick = "";
         edtavPedidodtentrega_to_Enabled = 1;
         edtavPedidodtentrega_Jsonclick = "";
         edtavPedidodtentrega_Enabled = 1;
         cmbavPedidostatus_Jsonclick = "";
         cmbavPedidostatus.Enabled = 1;
         edtavTfpedidototal_to_Jsonclick = "";
         edtavTfpedidototal_to_Visible = 1;
         edtavTfpedidototal_Jsonclick = "";
         edtavTfpedidototal_Visible = 1;
         edtavTfpedidoretirada_sel_Jsonclick = "";
         edtavTfpedidoretirada_sel_Visible = 1;
         edtavDdo_pedidodtentregaauxdateto_Jsonclick = "";
         edtavDdo_pedidodtentregaauxdate_Jsonclick = "";
         edtavTfpedidodtentrega_to_Jsonclick = "";
         edtavTfpedidodtentrega_to_Visible = 1;
         edtavTfpedidodtentrega_Jsonclick = "";
         edtavTfpedidodtentrega_Visible = 1;
         edtavDdo_pedidodtauxdateto_Jsonclick = "";
         edtavDdo_pedidodtauxdate_Jsonclick = "";
         edtavTfpedidodt_to_Jsonclick = "";
         edtavTfpedidodt_to_Visible = 1;
         edtavTfpedidodt_Jsonclick = "";
         edtavTfpedidodt_Visible = 1;
         edtavTfpessoanome_sel_Jsonclick = "";
         edtavTfpessoanome_sel_Visible = 1;
         edtavTfpessoanome_Jsonclick = "";
         edtavTfpessoanome_Visible = 1;
         edtavTfpedidoid_to_Jsonclick = "";
         edtavTfpedidoid_to_Visible = 1;
         edtavTfpedidoid_Jsonclick = "";
         edtavTfpedidoid_Visible = 1;
         edtavManagefiltersexecutionstep_Jsonclick = "";
         edtavManagefiltersexecutionstep_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_pedidototaltitlecontrolidtoreplace_Visible = 1;
         edtavDdo_pedidoretiradatitlecontrolidtoreplace_Visible = 1;
         edtavDdo_pedidodtentregatitlecontrolidtoreplace_Visible = 1;
         edtavDdo_pedidostatustitlecontrolidtoreplace_Visible = 1;
         edtavDdo_pedidodttitlecontrolidtoreplace_Visible = 1;
         edtavDdo_pessoanometitlecontrolidtoreplace_Visible = 1;
         edtavDdo_pedidoidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtPedidoDt_Link = "";
         edtavDelete_Link = "";
         edtavUpdate_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtPedidoTotal_Titleformat = 0;
         edtPedidoTotal_Title = "Total";
         edtPedidoTotal_Visible = -1;
         chkPedidoRetirada_Titleformat = 0;
         chkPedidoRetirada.Title.Text = "Retirar no Local?";
         chkPedidoRetirada.Visible = -1;
         edtPedidoDtEntrega_Titleformat = 0;
         edtPedidoDtEntrega_Title = "Data de Entrega";
         edtPedidoDtEntrega_Visible = -1;
         cmbPedidoStatus_Titleformat = 0;
         cmbPedidoStatus.Title.Text = "Status";
         cmbPedidoStatus.Visible = -1;
         edtPedidoDt_Titleformat = 0;
         edtPedidoDt_Title = "Data do Pedido";
         edtPedidoDt_Visible = -1;
         edtPessoaNome_Titleformat = 0;
         edtPessoaNome_Title = "Nome";
         edtPessoaNome_Visible = -1;
         edtPedidoId_Titleformat = 0;
         edtPedidoId_Title = "Número do Pedido";
         edtPedidoId_Visible = -1;
         edtavReprovar_Enabled = 1;
         edtavAprovar_Enabled = 1;
         edtavEncerrar_Enabled = 1;
         edtavDelete_Enabled = 1;
         edtavUpdate_Enabled = 1;
         subGrid_Class = "GridWithPaginationBar GridNoBorder WorkWith";
         subGrid_Backcolorstyle = 0;
         Ddo_gridcolumnsselector_Updatebuttontext = "WWP_ColumnsSelectorButton";
         Ddo_gridcolumnsselector_Titlecontrolidtoreplace = "";
         Ddo_gridcolumnsselector_Dropdownoptionstype = "GridColumnsSelector";
         Ddo_gridcolumnsselector_Cls = "ColumnsSelector hidden-xs";
         Ddo_gridcolumnsselector_Tooltip = "WWP_EditColumnsTooltip";
         Ddo_gridcolumnsselector_Caption = "Seleciona colunas";
         Ddo_pedidototal_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_pedidototal_Rangefilterto = "WWP_TSTo";
         Ddo_pedidototal_Rangefilterfrom = "WWP_TSFrom";
         Ddo_pedidototal_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_pedidototal_Sortdsc = "WWP_TSSortDSC";
         Ddo_pedidototal_Sortasc = "WWP_TSSortASC";
         Ddo_pedidototal_Includedatalist = Convert.ToBoolean( 0);
         Ddo_pedidototal_Filterisrange = Convert.ToBoolean( -1);
         Ddo_pedidototal_Filtertype = "Numeric";
         Ddo_pedidototal_Includefilter = Convert.ToBoolean( -1);
         Ddo_pedidototal_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_pedidototal_Includesortasc = Convert.ToBoolean( -1);
         Ddo_pedidototal_Titlecontrolidtoreplace = "";
         Ddo_pedidototal_Dropdownoptionstype = "GridTitleSettings";
         Ddo_pedidototal_Cls = "ColumnSettings";
         Ddo_pedidototal_Tooltip = "WWP_TSColumnOptions";
         Ddo_pedidototal_Caption = "";
         Ddo_pedidoretirada_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_pedidoretirada_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_pedidoretirada_Sortdsc = "WWP_TSSortDSC";
         Ddo_pedidoretirada_Sortasc = "WWP_TSSortASC";
         Ddo_pedidoretirada_Datalistfixedvalues = "1:WWP_TSChecked,2:WWP_TSUnChecked";
         Ddo_pedidoretirada_Datalisttype = "FixedValues";
         Ddo_pedidoretirada_Includedatalist = Convert.ToBoolean( -1);
         Ddo_pedidoretirada_Includefilter = Convert.ToBoolean( 0);
         Ddo_pedidoretirada_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_pedidoretirada_Includesortasc = Convert.ToBoolean( -1);
         Ddo_pedidoretirada_Titlecontrolidtoreplace = "";
         Ddo_pedidoretirada_Dropdownoptionstype = "GridTitleSettings";
         Ddo_pedidoretirada_Cls = "ColumnSettings";
         Ddo_pedidoretirada_Tooltip = "WWP_TSColumnOptions";
         Ddo_pedidoretirada_Caption = "";
         Ddo_pedidodtentrega_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_pedidodtentrega_Rangefilterto = "WWP_TSTo";
         Ddo_pedidodtentrega_Rangefilterfrom = "WWP_TSFrom";
         Ddo_pedidodtentrega_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_pedidodtentrega_Sortdsc = "WWP_TSSortDSC";
         Ddo_pedidodtentrega_Sortasc = "WWP_TSSortASC";
         Ddo_pedidodtentrega_Includedatalist = Convert.ToBoolean( 0);
         Ddo_pedidodtentrega_Filterisrange = Convert.ToBoolean( -1);
         Ddo_pedidodtentrega_Filtertype = "Date";
         Ddo_pedidodtentrega_Includefilter = Convert.ToBoolean( -1);
         Ddo_pedidodtentrega_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_pedidodtentrega_Includesortasc = Convert.ToBoolean( -1);
         Ddo_pedidodtentrega_Titlecontrolidtoreplace = "";
         Ddo_pedidodtentrega_Dropdownoptionstype = "GridTitleSettings";
         Ddo_pedidodtentrega_Cls = "ColumnSettings";
         Ddo_pedidodtentrega_Tooltip = "WWP_TSColumnOptions";
         Ddo_pedidodtentrega_Caption = "";
         Ddo_pedidostatus_Searchbuttontext = "WWP_FilterSelected";
         Ddo_pedidostatus_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_pedidostatus_Sortdsc = "WWP_TSSortDSC";
         Ddo_pedidostatus_Sortasc = "WWP_TSSortASC";
         Ddo_pedidostatus_Datalistfixedvalues = "AGD:Aguardando Aprovação,APR:Aprovado,REP:Reprovado,ENC:Encerrado";
         Ddo_pedidostatus_Allowmultipleselection = Convert.ToBoolean( -1);
         Ddo_pedidostatus_Datalisttype = "FixedValues";
         Ddo_pedidostatus_Includedatalist = Convert.ToBoolean( -1);
         Ddo_pedidostatus_Includefilter = Convert.ToBoolean( 0);
         Ddo_pedidostatus_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_pedidostatus_Includesortasc = Convert.ToBoolean( -1);
         Ddo_pedidostatus_Titlecontrolidtoreplace = "";
         Ddo_pedidostatus_Dropdownoptionstype = "GridTitleSettings";
         Ddo_pedidostatus_Cls = "ColumnSettings";
         Ddo_pedidostatus_Tooltip = "WWP_TSColumnOptions";
         Ddo_pedidostatus_Caption = "";
         Ddo_pedidodt_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_pedidodt_Rangefilterto = "WWP_TSTo";
         Ddo_pedidodt_Rangefilterfrom = "WWP_TSFrom";
         Ddo_pedidodt_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_pedidodt_Sortdsc = "WWP_TSSortDSC";
         Ddo_pedidodt_Sortasc = "WWP_TSSortASC";
         Ddo_pedidodt_Includedatalist = Convert.ToBoolean( 0);
         Ddo_pedidodt_Filterisrange = Convert.ToBoolean( -1);
         Ddo_pedidodt_Filtertype = "Date";
         Ddo_pedidodt_Includefilter = Convert.ToBoolean( -1);
         Ddo_pedidodt_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_pedidodt_Includesortasc = Convert.ToBoolean( -1);
         Ddo_pedidodt_Titlecontrolidtoreplace = "";
         Ddo_pedidodt_Dropdownoptionstype = "GridTitleSettings";
         Ddo_pedidodt_Cls = "ColumnSettings";
         Ddo_pedidodt_Tooltip = "WWP_TSColumnOptions";
         Ddo_pedidodt_Caption = "";
         Ddo_pessoanome_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_pessoanome_Noresultsfound = "WWP_TSNoResults";
         Ddo_pessoanome_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_pessoanome_Loadingdata = "WWP_TSLoading";
         Ddo_pessoanome_Sortdsc = "WWP_TSSortDSC";
         Ddo_pessoanome_Sortasc = "WWP_TSSortASC";
         Ddo_pessoanome_Datalistupdateminimumcharacters = 0;
         Ddo_pessoanome_Datalistproc = "PedidoWWGetFilterData";
         Ddo_pessoanome_Datalisttype = "Dynamic";
         Ddo_pessoanome_Includedatalist = Convert.ToBoolean( -1);
         Ddo_pessoanome_Filterisrange = Convert.ToBoolean( 0);
         Ddo_pessoanome_Filtertype = "Character";
         Ddo_pessoanome_Includefilter = Convert.ToBoolean( -1);
         Ddo_pessoanome_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_pessoanome_Includesortasc = Convert.ToBoolean( -1);
         Ddo_pessoanome_Titlecontrolidtoreplace = "";
         Ddo_pessoanome_Dropdownoptionstype = "GridTitleSettings";
         Ddo_pessoanome_Cls = "ColumnSettings";
         Ddo_pessoanome_Tooltip = "WWP_TSColumnOptions";
         Ddo_pessoanome_Caption = "";
         Ddo_pedidoid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_pedidoid_Rangefilterto = "WWP_TSTo";
         Ddo_pedidoid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_pedidoid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_pedidoid_Sortdsc = "WWP_TSSortDSC";
         Ddo_pedidoid_Sortasc = "WWP_TSSortASC";
         Ddo_pedidoid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_pedidoid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_pedidoid_Filtertype = "Numeric";
         Ddo_pedidoid_Includefilter = Convert.ToBoolean( -1);
         Ddo_pedidoid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_pedidoid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_pedidoid_Titlecontrolidtoreplace = "";
         Ddo_pedidoid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_pedidoid_Cls = "ColumnSettings";
         Ddo_pedidoid_Tooltip = "WWP_TSColumnOptions";
         Ddo_pedidoid_Caption = "";
         Gridpaginationbar_Rowsperpagecaption = "WWP_PagingRowsPerPage";
         Gridpaginationbar_Emptygridcaption = "WWP_PagingEmptyGridCaption";
         Gridpaginationbar_Rowsperpageoptions = "5:WWP_Rows5,10:WWP_Rows10,20:WWP_Rows20,50:WWP_Rows50";
         Gridpaginationbar_Rowsperpageselectedvalue = 10;
         Gridpaginationbar_Rowsperpageselector = Convert.ToBoolean( -1);
         Gridpaginationbar_Emptygridclass = "PaginationBarEmptyGrid";
         Gridpaginationbar_Pagingcaptionposition = "Left";
         Gridpaginationbar_Pagingbuttonsposition = "Right";
         Gridpaginationbar_Pagestoshow = 5;
         Gridpaginationbar_Showlast = Convert.ToBoolean( 0);
         Gridpaginationbar_Shownext = Convert.ToBoolean( -1);
         Gridpaginationbar_Showprevious = Convert.ToBoolean( -1);
         Gridpaginationbar_Showfirst = Convert.ToBoolean( 0);
         Gridpaginationbar_Caption = "Página <CURRENT_PAGE> de <TOTAL_PAGES>";
         Gridpaginationbar_Next = "WWP_PagingNextCaption";
         Gridpaginationbar_Previous = "WWP_PagingPreviousCaption";
         Gridpaginationbar_Class = "PaginationBar";
         Dvpanel_tableheader_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableheader_Iconposition = "Right";
         Dvpanel_tableheader_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableheader_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableheader_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableheader_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableheader_Collapsible = Convert.ToBoolean( -1);
         Dvpanel_tableheader_Title = "Opções";
         Dvpanel_tableheader_Cls = "PanelNoHeader";
         Dvpanel_tableheader_Width = "100%";
         Ddo_managefilters_Cls = "ManageFilters";
         Ddo_managefilters_Tooltip = "WWP_ManageFiltersTooltip";
         Ddo_managefilters_Icon = "";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = " Pedido";
         subGrid_Rows = 0;
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV61ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV98ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV71ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV80ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV84ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV94PessoaNome',fld:'vPESSOANOME',pic:''},{av:'AV99PedidoDt',fld:'vPEDIDODT',pic:''},{av:'AV100PedidoDt_To',fld:'vPEDIDODT_TO',pic:''},{av:'AV101PedidoDtEntrega',fld:'vPEDIDODTENTREGA',pic:''},{av:'AV102PedidoDtEntrega_To',fld:'vPEDIDODTENTREGA_TO',pic:''},{av:'cmbavPedidostatus'},{av:'AV103PedidoStatus',fld:'vPEDIDOSTATUS',pic:''},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'AV96TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV97TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV63TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'AV64TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'AV70TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'AV73TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'AV74TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'AV79TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'AV82TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'R$ Z,ZZZ,ZZ,ZZ9.99'},{av:'AV83TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'R$ Z,ZZZ,ZZ,ZZ9.99'},{av:'AV131Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'cmbavPessoanomeoperator'},{av:'AV93PessoaNomeOperator',fld:'vPESSOANOMEOPERATOR',pic:'ZZZ9'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV58PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV95PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV62PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV68PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV72PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV78PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV81PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtPedidoId_Visible',ctrl:'PEDIDOID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPedidoDt_Visible',ctrl:'PEDIDODT',prop:'Visible'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Visible',ctrl:'PEDIDODTENTREGA',prop:'Visible'},{av:'chkPedidoRetirada.Visible',ctrl:'PEDIDORETIRADA',prop:'Visible'},{av:'edtPedidoTotal_Visible',ctrl:'PEDIDOTOTAL',prop:'Visible'},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV87GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV88GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E12132',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavPessoanomeoperator'},{av:'AV93PessoaNomeOperator',fld:'vPESSOANOMEOPERATOR',pic:'ZZZ9'},{av:'AV94PessoaNome',fld:'vPESSOANOME',pic:''},{av:'AV99PedidoDt',fld:'vPEDIDODT',pic:''},{av:'AV100PedidoDt_To',fld:'vPEDIDODT_TO',pic:''},{av:'AV101PedidoDtEntrega',fld:'vPEDIDODTENTREGA',pic:''},{av:'AV102PedidoDtEntrega_To',fld:'vPEDIDODTENTREGA_TO',pic:''},{av:'cmbavPedidostatus'},{av:'AV103PedidoStatus',fld:'vPEDIDOSTATUS',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'AV96TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV97TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV63TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'AV64TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'AV73TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'AV74TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'AV79TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'AV82TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'R$ Z,ZZZ,ZZ,ZZ9.99'},{av:'AV83TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'R$ Z,ZZZ,ZZ,ZZ9.99'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV61ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV98ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV71ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV80ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV84ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV70TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'AV131Pgmname',fld:'vPGMNAME',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E13132',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavPessoanomeoperator'},{av:'AV93PessoaNomeOperator',fld:'vPESSOANOMEOPERATOR',pic:'ZZZ9'},{av:'AV94PessoaNome',fld:'vPESSOANOME',pic:''},{av:'AV99PedidoDt',fld:'vPEDIDODT',pic:''},{av:'AV100PedidoDt_To',fld:'vPEDIDODT_TO',pic:''},{av:'AV101PedidoDtEntrega',fld:'vPEDIDODTENTREGA',pic:''},{av:'AV102PedidoDtEntrega_To',fld:'vPEDIDODTENTREGA_TO',pic:''},{av:'cmbavPedidostatus'},{av:'AV103PedidoStatus',fld:'vPEDIDOSTATUS',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'AV96TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV97TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV63TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'AV64TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'AV73TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'AV74TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'AV79TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'AV82TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'R$ Z,ZZZ,ZZ,ZZ9.99'},{av:'AV83TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'R$ Z,ZZZ,ZZ,ZZ9.99'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV61ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV98ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV71ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV80ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV84ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV70TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'AV131Pgmname',fld:'vPGMNAME',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_PEDIDOID.ONOPTIONCLICKED","{handler:'E14132',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavPessoanomeoperator'},{av:'AV93PessoaNomeOperator',fld:'vPESSOANOMEOPERATOR',pic:'ZZZ9'},{av:'AV94PessoaNome',fld:'vPESSOANOME',pic:''},{av:'AV99PedidoDt',fld:'vPEDIDODT',pic:''},{av:'AV100PedidoDt_To',fld:'vPEDIDODT_TO',pic:''},{av:'AV101PedidoDtEntrega',fld:'vPEDIDODTENTREGA',pic:''},{av:'AV102PedidoDtEntrega_To',fld:'vPEDIDODTENTREGA_TO',pic:''},{av:'cmbavPedidostatus'},{av:'AV103PedidoStatus',fld:'vPEDIDOSTATUS',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'AV96TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV97TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV63TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'AV64TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'AV73TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'AV74TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'AV79TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'AV82TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'R$ Z,ZZZ,ZZ,ZZ9.99'},{av:'AV83TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'R$ Z,ZZZ,ZZ,ZZ9.99'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV61ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV98ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV71ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV80ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV84ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV70TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'AV131Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_pedidoid_Activeeventkey',ctrl:'DDO_PEDIDOID',prop:'ActiveEventKey'},{av:'Ddo_pedidoid_Filteredtext_get',ctrl:'DDO_PEDIDOID',prop:'FilteredText_get'},{av:'Ddo_pedidoid_Filteredtextto_get',ctrl:'DDO_PEDIDOID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_PEDIDOID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_pedidoid_Sortedstatus',ctrl:'DDO_PEDIDOID',prop:'SortedStatus'},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'Ddo_pessoanome_Sortedstatus',ctrl:'DDO_PESSOANOME',prop:'SortedStatus'},{av:'Ddo_pedidodt_Sortedstatus',ctrl:'DDO_PEDIDODT',prop:'SortedStatus'},{av:'Ddo_pedidostatus_Sortedstatus',ctrl:'DDO_PEDIDOSTATUS',prop:'SortedStatus'},{av:'Ddo_pedidodtentrega_Sortedstatus',ctrl:'DDO_PEDIDODTENTREGA',prop:'SortedStatus'},{av:'Ddo_pedidoretirada_Sortedstatus',ctrl:'DDO_PEDIDORETIRADA',prop:'SortedStatus'},{av:'Ddo_pedidototal_Sortedstatus',ctrl:'DDO_PEDIDOTOTAL',prop:'SortedStatus'},{av:'AV58PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV95PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV62PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV68PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV72PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV78PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV81PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtPedidoId_Visible',ctrl:'PEDIDOID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPedidoDt_Visible',ctrl:'PEDIDODT',prop:'Visible'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Visible',ctrl:'PEDIDODTENTREGA',prop:'Visible'},{av:'chkPedidoRetirada.Visible',ctrl:'PEDIDORETIRADA',prop:'Visible'},{av:'edtPedidoTotal_Visible',ctrl:'PEDIDOTOTAL',prop:'Visible'},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV87GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV88GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("DDO_PESSOANOME.ONOPTIONCLICKED","{handler:'E15132',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavPessoanomeoperator'},{av:'AV93PessoaNomeOperator',fld:'vPESSOANOMEOPERATOR',pic:'ZZZ9'},{av:'AV94PessoaNome',fld:'vPESSOANOME',pic:''},{av:'AV99PedidoDt',fld:'vPEDIDODT',pic:''},{av:'AV100PedidoDt_To',fld:'vPEDIDODT_TO',pic:''},{av:'AV101PedidoDtEntrega',fld:'vPEDIDODTENTREGA',pic:''},{av:'AV102PedidoDtEntrega_To',fld:'vPEDIDODTENTREGA_TO',pic:''},{av:'cmbavPedidostatus'},{av:'AV103PedidoStatus',fld:'vPEDIDOSTATUS',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'AV96TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV97TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV63TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'AV64TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'AV73TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'AV74TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'AV79TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'AV82TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'R$ Z,ZZZ,ZZ,ZZ9.99'},{av:'AV83TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'R$ Z,ZZZ,ZZ,ZZ9.99'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV61ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV98ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV71ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV80ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV84ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV70TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'AV131Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_pessoanome_Activeeventkey',ctrl:'DDO_PESSOANOME',prop:'ActiveEventKey'},{av:'Ddo_pessoanome_Filteredtext_get',ctrl:'DDO_PESSOANOME',prop:'FilteredText_get'},{av:'Ddo_pessoanome_Selectedvalue_get',ctrl:'DDO_PESSOANOME',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_PESSOANOME.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_pessoanome_Sortedstatus',ctrl:'DDO_PESSOANOME',prop:'SortedStatus'},{av:'AV96TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV97TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'Ddo_pedidoid_Sortedstatus',ctrl:'DDO_PEDIDOID',prop:'SortedStatus'},{av:'Ddo_pedidodt_Sortedstatus',ctrl:'DDO_PEDIDODT',prop:'SortedStatus'},{av:'Ddo_pedidostatus_Sortedstatus',ctrl:'DDO_PEDIDOSTATUS',prop:'SortedStatus'},{av:'Ddo_pedidodtentrega_Sortedstatus',ctrl:'DDO_PEDIDODTENTREGA',prop:'SortedStatus'},{av:'Ddo_pedidoretirada_Sortedstatus',ctrl:'DDO_PEDIDORETIRADA',prop:'SortedStatus'},{av:'Ddo_pedidototal_Sortedstatus',ctrl:'DDO_PEDIDOTOTAL',prop:'SortedStatus'},{av:'AV58PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV95PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV62PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV68PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV72PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV78PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV81PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtPedidoId_Visible',ctrl:'PEDIDOID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPedidoDt_Visible',ctrl:'PEDIDODT',prop:'Visible'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Visible',ctrl:'PEDIDODTENTREGA',prop:'Visible'},{av:'chkPedidoRetirada.Visible',ctrl:'PEDIDORETIRADA',prop:'Visible'},{av:'edtPedidoTotal_Visible',ctrl:'PEDIDOTOTAL',prop:'Visible'},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV87GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV88GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("DDO_PEDIDODT.ONOPTIONCLICKED","{handler:'E16132',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavPessoanomeoperator'},{av:'AV93PessoaNomeOperator',fld:'vPESSOANOMEOPERATOR',pic:'ZZZ9'},{av:'AV94PessoaNome',fld:'vPESSOANOME',pic:''},{av:'AV99PedidoDt',fld:'vPEDIDODT',pic:''},{av:'AV100PedidoDt_To',fld:'vPEDIDODT_TO',pic:''},{av:'AV101PedidoDtEntrega',fld:'vPEDIDODTENTREGA',pic:''},{av:'AV102PedidoDtEntrega_To',fld:'vPEDIDODTENTREGA_TO',pic:''},{av:'cmbavPedidostatus'},{av:'AV103PedidoStatus',fld:'vPEDIDOSTATUS',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'AV96TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV97TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV63TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'AV64TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'AV73TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'AV74TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'AV79TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'AV82TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'R$ Z,ZZZ,ZZ,ZZ9.99'},{av:'AV83TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'R$ Z,ZZZ,ZZ,ZZ9.99'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV61ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV98ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV71ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV80ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV84ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV70TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'AV131Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_pedidodt_Activeeventkey',ctrl:'DDO_PEDIDODT',prop:'ActiveEventKey'},{av:'Ddo_pedidodt_Filteredtext_get',ctrl:'DDO_PEDIDODT',prop:'FilteredText_get'},{av:'Ddo_pedidodt_Filteredtextto_get',ctrl:'DDO_PEDIDODT',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_PEDIDODT.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_pedidodt_Sortedstatus',ctrl:'DDO_PEDIDODT',prop:'SortedStatus'},{av:'AV63TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'AV64TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'Ddo_pedidoid_Sortedstatus',ctrl:'DDO_PEDIDOID',prop:'SortedStatus'},{av:'Ddo_pessoanome_Sortedstatus',ctrl:'DDO_PESSOANOME',prop:'SortedStatus'},{av:'Ddo_pedidostatus_Sortedstatus',ctrl:'DDO_PEDIDOSTATUS',prop:'SortedStatus'},{av:'Ddo_pedidodtentrega_Sortedstatus',ctrl:'DDO_PEDIDODTENTREGA',prop:'SortedStatus'},{av:'Ddo_pedidoretirada_Sortedstatus',ctrl:'DDO_PEDIDORETIRADA',prop:'SortedStatus'},{av:'Ddo_pedidototal_Sortedstatus',ctrl:'DDO_PEDIDOTOTAL',prop:'SortedStatus'},{av:'AV58PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV95PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV62PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV68PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV72PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV78PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV81PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtPedidoId_Visible',ctrl:'PEDIDOID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPedidoDt_Visible',ctrl:'PEDIDODT',prop:'Visible'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Visible',ctrl:'PEDIDODTENTREGA',prop:'Visible'},{av:'chkPedidoRetirada.Visible',ctrl:'PEDIDORETIRADA',prop:'Visible'},{av:'edtPedidoTotal_Visible',ctrl:'PEDIDOTOTAL',prop:'Visible'},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV87GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV88GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("DDO_PEDIDOSTATUS.ONOPTIONCLICKED","{handler:'E17132',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavPessoanomeoperator'},{av:'AV93PessoaNomeOperator',fld:'vPESSOANOMEOPERATOR',pic:'ZZZ9'},{av:'AV94PessoaNome',fld:'vPESSOANOME',pic:''},{av:'AV99PedidoDt',fld:'vPEDIDODT',pic:''},{av:'AV100PedidoDt_To',fld:'vPEDIDODT_TO',pic:''},{av:'AV101PedidoDtEntrega',fld:'vPEDIDODTENTREGA',pic:''},{av:'AV102PedidoDtEntrega_To',fld:'vPEDIDODTENTREGA_TO',pic:''},{av:'cmbavPedidostatus'},{av:'AV103PedidoStatus',fld:'vPEDIDOSTATUS',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'AV96TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV97TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV63TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'AV64TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'AV73TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'AV74TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'AV79TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'AV82TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'R$ Z,ZZZ,ZZ,ZZ9.99'},{av:'AV83TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'R$ Z,ZZZ,ZZ,ZZ9.99'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV61ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV98ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV71ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV80ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV84ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV70TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'AV131Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_pedidostatus_Activeeventkey',ctrl:'DDO_PEDIDOSTATUS',prop:'ActiveEventKey'},{av:'Ddo_pedidostatus_Selectedvalue_get',ctrl:'DDO_PEDIDOSTATUS',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_PEDIDOSTATUS.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_pedidostatus_Sortedstatus',ctrl:'DDO_PEDIDOSTATUS',prop:'SortedStatus'},{av:'AV70TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'Ddo_pedidoid_Sortedstatus',ctrl:'DDO_PEDIDOID',prop:'SortedStatus'},{av:'Ddo_pessoanome_Sortedstatus',ctrl:'DDO_PESSOANOME',prop:'SortedStatus'},{av:'Ddo_pedidodt_Sortedstatus',ctrl:'DDO_PEDIDODT',prop:'SortedStatus'},{av:'Ddo_pedidodtentrega_Sortedstatus',ctrl:'DDO_PEDIDODTENTREGA',prop:'SortedStatus'},{av:'Ddo_pedidoretirada_Sortedstatus',ctrl:'DDO_PEDIDORETIRADA',prop:'SortedStatus'},{av:'Ddo_pedidototal_Sortedstatus',ctrl:'DDO_PEDIDOTOTAL',prop:'SortedStatus'},{av:'AV58PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV95PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV62PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV68PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV72PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV78PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV81PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtPedidoId_Visible',ctrl:'PEDIDOID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPedidoDt_Visible',ctrl:'PEDIDODT',prop:'Visible'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Visible',ctrl:'PEDIDODTENTREGA',prop:'Visible'},{av:'chkPedidoRetirada.Visible',ctrl:'PEDIDORETIRADA',prop:'Visible'},{av:'edtPedidoTotal_Visible',ctrl:'PEDIDOTOTAL',prop:'Visible'},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV87GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV88GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("DDO_PEDIDODTENTREGA.ONOPTIONCLICKED","{handler:'E18132',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavPessoanomeoperator'},{av:'AV93PessoaNomeOperator',fld:'vPESSOANOMEOPERATOR',pic:'ZZZ9'},{av:'AV94PessoaNome',fld:'vPESSOANOME',pic:''},{av:'AV99PedidoDt',fld:'vPEDIDODT',pic:''},{av:'AV100PedidoDt_To',fld:'vPEDIDODT_TO',pic:''},{av:'AV101PedidoDtEntrega',fld:'vPEDIDODTENTREGA',pic:''},{av:'AV102PedidoDtEntrega_To',fld:'vPEDIDODTENTREGA_TO',pic:''},{av:'cmbavPedidostatus'},{av:'AV103PedidoStatus',fld:'vPEDIDOSTATUS',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'AV96TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV97TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV63TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'AV64TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'AV73TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'AV74TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'AV79TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'AV82TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'R$ Z,ZZZ,ZZ,ZZ9.99'},{av:'AV83TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'R$ Z,ZZZ,ZZ,ZZ9.99'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV61ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV98ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV71ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV80ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV84ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV70TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'AV131Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_pedidodtentrega_Activeeventkey',ctrl:'DDO_PEDIDODTENTREGA',prop:'ActiveEventKey'},{av:'Ddo_pedidodtentrega_Filteredtext_get',ctrl:'DDO_PEDIDODTENTREGA',prop:'FilteredText_get'},{av:'Ddo_pedidodtentrega_Filteredtextto_get',ctrl:'DDO_PEDIDODTENTREGA',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_PEDIDODTENTREGA.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_pedidodtentrega_Sortedstatus',ctrl:'DDO_PEDIDODTENTREGA',prop:'SortedStatus'},{av:'AV73TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'AV74TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'Ddo_pedidoid_Sortedstatus',ctrl:'DDO_PEDIDOID',prop:'SortedStatus'},{av:'Ddo_pessoanome_Sortedstatus',ctrl:'DDO_PESSOANOME',prop:'SortedStatus'},{av:'Ddo_pedidodt_Sortedstatus',ctrl:'DDO_PEDIDODT',prop:'SortedStatus'},{av:'Ddo_pedidostatus_Sortedstatus',ctrl:'DDO_PEDIDOSTATUS',prop:'SortedStatus'},{av:'Ddo_pedidoretirada_Sortedstatus',ctrl:'DDO_PEDIDORETIRADA',prop:'SortedStatus'},{av:'Ddo_pedidototal_Sortedstatus',ctrl:'DDO_PEDIDOTOTAL',prop:'SortedStatus'},{av:'AV58PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV95PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV62PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV68PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV72PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV78PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV81PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtPedidoId_Visible',ctrl:'PEDIDOID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPedidoDt_Visible',ctrl:'PEDIDODT',prop:'Visible'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Visible',ctrl:'PEDIDODTENTREGA',prop:'Visible'},{av:'chkPedidoRetirada.Visible',ctrl:'PEDIDORETIRADA',prop:'Visible'},{av:'edtPedidoTotal_Visible',ctrl:'PEDIDOTOTAL',prop:'Visible'},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV87GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV88GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("DDO_PEDIDORETIRADA.ONOPTIONCLICKED","{handler:'E19132',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavPessoanomeoperator'},{av:'AV93PessoaNomeOperator',fld:'vPESSOANOMEOPERATOR',pic:'ZZZ9'},{av:'AV94PessoaNome',fld:'vPESSOANOME',pic:''},{av:'AV99PedidoDt',fld:'vPEDIDODT',pic:''},{av:'AV100PedidoDt_To',fld:'vPEDIDODT_TO',pic:''},{av:'AV101PedidoDtEntrega',fld:'vPEDIDODTENTREGA',pic:''},{av:'AV102PedidoDtEntrega_To',fld:'vPEDIDODTENTREGA_TO',pic:''},{av:'cmbavPedidostatus'},{av:'AV103PedidoStatus',fld:'vPEDIDOSTATUS',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'AV96TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV97TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV63TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'AV64TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'AV73TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'AV74TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'AV79TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'AV82TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'R$ Z,ZZZ,ZZ,ZZ9.99'},{av:'AV83TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'R$ Z,ZZZ,ZZ,ZZ9.99'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV61ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV98ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV71ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV80ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV84ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV70TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'AV131Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_pedidoretirada_Activeeventkey',ctrl:'DDO_PEDIDORETIRADA',prop:'ActiveEventKey'},{av:'Ddo_pedidoretirada_Selectedvalue_get',ctrl:'DDO_PEDIDORETIRADA',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_PEDIDORETIRADA.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_pedidoretirada_Sortedstatus',ctrl:'DDO_PEDIDORETIRADA',prop:'SortedStatus'},{av:'AV79TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'Ddo_pedidoid_Sortedstatus',ctrl:'DDO_PEDIDOID',prop:'SortedStatus'},{av:'Ddo_pessoanome_Sortedstatus',ctrl:'DDO_PESSOANOME',prop:'SortedStatus'},{av:'Ddo_pedidodt_Sortedstatus',ctrl:'DDO_PEDIDODT',prop:'SortedStatus'},{av:'Ddo_pedidostatus_Sortedstatus',ctrl:'DDO_PEDIDOSTATUS',prop:'SortedStatus'},{av:'Ddo_pedidodtentrega_Sortedstatus',ctrl:'DDO_PEDIDODTENTREGA',prop:'SortedStatus'},{av:'Ddo_pedidototal_Sortedstatus',ctrl:'DDO_PEDIDOTOTAL',prop:'SortedStatus'},{av:'AV58PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV95PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV62PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV68PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV72PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV78PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV81PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtPedidoId_Visible',ctrl:'PEDIDOID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPedidoDt_Visible',ctrl:'PEDIDODT',prop:'Visible'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Visible',ctrl:'PEDIDODTENTREGA',prop:'Visible'},{av:'chkPedidoRetirada.Visible',ctrl:'PEDIDORETIRADA',prop:'Visible'},{av:'edtPedidoTotal_Visible',ctrl:'PEDIDOTOTAL',prop:'Visible'},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV87GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV88GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("DDO_PEDIDOTOTAL.ONOPTIONCLICKED","{handler:'E20132',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavPessoanomeoperator'},{av:'AV93PessoaNomeOperator',fld:'vPESSOANOMEOPERATOR',pic:'ZZZ9'},{av:'AV94PessoaNome',fld:'vPESSOANOME',pic:''},{av:'AV99PedidoDt',fld:'vPEDIDODT',pic:''},{av:'AV100PedidoDt_To',fld:'vPEDIDODT_TO',pic:''},{av:'AV101PedidoDtEntrega',fld:'vPEDIDODTENTREGA',pic:''},{av:'AV102PedidoDtEntrega_To',fld:'vPEDIDODTENTREGA_TO',pic:''},{av:'cmbavPedidostatus'},{av:'AV103PedidoStatus',fld:'vPEDIDOSTATUS',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'AV96TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV97TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV63TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'AV64TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'AV73TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'AV74TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'AV79TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'AV82TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'R$ Z,ZZZ,ZZ,ZZ9.99'},{av:'AV83TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'R$ Z,ZZZ,ZZ,ZZ9.99'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV61ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV98ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV71ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV80ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV84ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV70TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'AV131Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_pedidototal_Activeeventkey',ctrl:'DDO_PEDIDOTOTAL',prop:'ActiveEventKey'},{av:'Ddo_pedidototal_Filteredtext_get',ctrl:'DDO_PEDIDOTOTAL',prop:'FilteredText_get'},{av:'Ddo_pedidototal_Filteredtextto_get',ctrl:'DDO_PEDIDOTOTAL',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_PEDIDOTOTAL.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_pedidototal_Sortedstatus',ctrl:'DDO_PEDIDOTOTAL',prop:'SortedStatus'},{av:'AV82TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'R$ Z,ZZZ,ZZ,ZZ9.99'},{av:'AV83TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'R$ Z,ZZZ,ZZ,ZZ9.99'},{av:'Ddo_pedidoid_Sortedstatus',ctrl:'DDO_PEDIDOID',prop:'SortedStatus'},{av:'Ddo_pessoanome_Sortedstatus',ctrl:'DDO_PESSOANOME',prop:'SortedStatus'},{av:'Ddo_pedidodt_Sortedstatus',ctrl:'DDO_PEDIDODT',prop:'SortedStatus'},{av:'Ddo_pedidostatus_Sortedstatus',ctrl:'DDO_PEDIDOSTATUS',prop:'SortedStatus'},{av:'Ddo_pedidodtentrega_Sortedstatus',ctrl:'DDO_PEDIDODTENTREGA',prop:'SortedStatus'},{av:'Ddo_pedidoretirada_Sortedstatus',ctrl:'DDO_PEDIDORETIRADA',prop:'SortedStatus'},{av:'AV58PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV95PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV62PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV68PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV72PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV78PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV81PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtPedidoId_Visible',ctrl:'PEDIDOID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPedidoDt_Visible',ctrl:'PEDIDODT',prop:'Visible'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Visible',ctrl:'PEDIDODTENTREGA',prop:'Visible'},{av:'chkPedidoRetirada.Visible',ctrl:'PEDIDORETIRADA',prop:'Visible'},{av:'edtPedidoTotal_Visible',ctrl:'PEDIDOTOTAL',prop:'Visible'},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV87GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV88GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("GRID.LOAD","{handler:'E25132',iparms:[{av:'A32PedidoId',fld:'PEDIDOID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV89Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'AV90Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'},{av:'AV92Encerrar',fld:'vENCERRAR',pic:''},{av:'AV106Aprovar',fld:'vAPROVAR',pic:''},{av:'AV107Reprovar',fld:'vREPROVAR',pic:''},{av:'edtPedidoDt_Link',ctrl:'PEDIDODT',prop:'Link'}]}");
         setEventMetadata("DDO_GRIDCOLUMNSSELECTOR.ONCOLUMNSCHANGED","{handler:'E21132',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavPessoanomeoperator'},{av:'AV93PessoaNomeOperator',fld:'vPESSOANOMEOPERATOR',pic:'ZZZ9'},{av:'AV94PessoaNome',fld:'vPESSOANOME',pic:''},{av:'AV99PedidoDt',fld:'vPEDIDODT',pic:''},{av:'AV100PedidoDt_To',fld:'vPEDIDODT_TO',pic:''},{av:'AV101PedidoDtEntrega',fld:'vPEDIDODTENTREGA',pic:''},{av:'AV102PedidoDtEntrega_To',fld:'vPEDIDODTENTREGA_TO',pic:''},{av:'cmbavPedidostatus'},{av:'AV103PedidoStatus',fld:'vPEDIDOSTATUS',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'AV96TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV97TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV63TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'AV64TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'AV73TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'AV74TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'AV79TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'AV82TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'R$ Z,ZZZ,ZZ,ZZ9.99'},{av:'AV83TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'R$ Z,ZZZ,ZZ,ZZ9.99'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV61ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV98ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV71ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV80ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV84ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV70TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'AV131Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_gridcolumnsselector_Columnsselectorvalues',ctrl:'DDO_GRIDCOLUMNSSELECTOR',prop:'ColumnsSelectorValues'}]");
         setEventMetadata("DDO_GRIDCOLUMNSSELECTOR.ONCOLUMNSCHANGED",",oparms:[{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV58PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV95PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV62PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV68PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV72PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV78PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV81PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'edtPedidoId_Visible',ctrl:'PEDIDOID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPedidoDt_Visible',ctrl:'PEDIDODT',prop:'Visible'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Visible',ctrl:'PEDIDODTENTREGA',prop:'Visible'},{av:'chkPedidoRetirada.Visible',ctrl:'PEDIDORETIRADA',prop:'Visible'},{av:'edtPedidoTotal_Visible',ctrl:'PEDIDOTOTAL',prop:'Visible'},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV87GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV88GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("DDO_MANAGEFILTERS.ONOPTIONCLICKED","{handler:'E11132',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavPessoanomeoperator'},{av:'AV93PessoaNomeOperator',fld:'vPESSOANOMEOPERATOR',pic:'ZZZ9'},{av:'AV94PessoaNome',fld:'vPESSOANOME',pic:''},{av:'AV99PedidoDt',fld:'vPEDIDODT',pic:''},{av:'AV100PedidoDt_To',fld:'vPEDIDODT_TO',pic:''},{av:'AV101PedidoDtEntrega',fld:'vPEDIDODTENTREGA',pic:''},{av:'AV102PedidoDtEntrega_To',fld:'vPEDIDODTENTREGA_TO',pic:''},{av:'cmbavPedidostatus'},{av:'AV103PedidoStatus',fld:'vPEDIDOSTATUS',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'AV96TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV97TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV63TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'AV64TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'AV73TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'AV74TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'AV79TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'AV82TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'R$ Z,ZZZ,ZZ,ZZ9.99'},{av:'AV83TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'R$ Z,ZZZ,ZZ,ZZ9.99'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV61ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV98ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV71ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV80ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV84ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV70TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'AV131Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_managefilters_Activeeventkey',ctrl:'DDO_MANAGEFILTERS',prop:'ActiveEventKey'},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]");
         setEventMetadata("DDO_MANAGEFILTERS.ONOPTIONCLICKED",",oparms:[{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'cmbavPessoanomeoperator'},{av:'AV93PessoaNomeOperator',fld:'vPESSOANOMEOPERATOR',pic:'ZZZ9'},{av:'AV94PessoaNome',fld:'vPESSOANOME',pic:''},{av:'AV99PedidoDt',fld:'vPEDIDODT',pic:''},{av:'AV100PedidoDt_To',fld:'vPEDIDODT_TO',pic:''},{av:'AV101PedidoDtEntrega',fld:'vPEDIDODTENTREGA',pic:''},{av:'AV102PedidoDtEntrega_To',fld:'vPEDIDODTENTREGA_TO',pic:''},{av:'cmbavPedidostatus'},{av:'AV103PedidoStatus',fld:'vPEDIDOSTATUS',pic:''},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'Ddo_pedidoid_Filteredtext_set',ctrl:'DDO_PEDIDOID',prop:'FilteredText_set'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'Ddo_pedidoid_Filteredtextto_set',ctrl:'DDO_PEDIDOID',prop:'FilteredTextTo_set'},{av:'AV96TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'Ddo_pessoanome_Filteredtext_set',ctrl:'DDO_PESSOANOME',prop:'FilteredText_set'},{av:'AV97TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'Ddo_pessoanome_Selectedvalue_set',ctrl:'DDO_PESSOANOME',prop:'SelectedValue_set'},{av:'AV63TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'Ddo_pedidodt_Filteredtext_set',ctrl:'DDO_PEDIDODT',prop:'FilteredText_set'},{av:'AV64TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'Ddo_pedidodt_Filteredtextto_set',ctrl:'DDO_PEDIDODT',prop:'FilteredTextTo_set'},{av:'AV70TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'Ddo_pedidostatus_Selectedvalue_set',ctrl:'DDO_PEDIDOSTATUS',prop:'SelectedValue_set'},{av:'AV73TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'Ddo_pedidodtentrega_Filteredtext_set',ctrl:'DDO_PEDIDODTENTREGA',prop:'FilteredText_set'},{av:'AV74TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'Ddo_pedidodtentrega_Filteredtextto_set',ctrl:'DDO_PEDIDODTENTREGA',prop:'FilteredTextTo_set'},{av:'AV79TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'Ddo_pedidoretirada_Selectedvalue_set',ctrl:'DDO_PEDIDORETIRADA',prop:'SelectedValue_set'},{av:'AV82TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'R$ Z,ZZZ,ZZ,ZZ9.99'},{av:'Ddo_pedidototal_Filteredtext_set',ctrl:'DDO_PEDIDOTOTAL',prop:'FilteredText_set'},{av:'AV83TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'R$ Z,ZZZ,ZZ,ZZ9.99'},{av:'Ddo_pedidototal_Filteredtextto_set',ctrl:'DDO_PEDIDOTOTAL',prop:'FilteredTextTo_set'},{av:'Ddo_pedidototal_Sortedstatus',ctrl:'DDO_PEDIDOTOTAL',prop:'SortedStatus'},{av:'Ddo_pedidoretirada_Sortedstatus',ctrl:'DDO_PEDIDORETIRADA',prop:'SortedStatus'},{av:'Ddo_pedidodtentrega_Sortedstatus',ctrl:'DDO_PEDIDODTENTREGA',prop:'SortedStatus'},{av:'Ddo_pedidostatus_Sortedstatus',ctrl:'DDO_PEDIDOSTATUS',prop:'SortedStatus'},{av:'Ddo_pedidodt_Sortedstatus',ctrl:'DDO_PEDIDODT',prop:'SortedStatus'},{av:'Ddo_pessoanome_Sortedstatus',ctrl:'DDO_PESSOANOME',prop:'SortedStatus'},{av:'Ddo_pedidoid_Sortedstatus',ctrl:'DDO_PEDIDOID',prop:'SortedStatus'},{av:'AV58PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV95PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV62PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV68PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV72PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV78PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV81PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtPedidoId_Visible',ctrl:'PEDIDOID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPedidoDt_Visible',ctrl:'PEDIDODT',prop:'Visible'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Visible',ctrl:'PEDIDODTENTREGA',prop:'Visible'},{av:'chkPedidoRetirada.Visible',ctrl:'PEDIDORETIRADA',prop:'Visible'},{av:'edtPedidoTotal_Visible',ctrl:'PEDIDOTOTAL',prop:'Visible'},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV87GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV88GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''}]}");
         setEventMetadata("'DOINSERT'","{handler:'E22132',iparms:[{av:'A32PedidoId',fld:'PEDIDOID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("'DOINSERT'",",oparms:[]}");
         setEventMetadata("VAPROVAR.CLICK","{handler:'E26132',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavPessoanomeoperator'},{av:'AV93PessoaNomeOperator',fld:'vPESSOANOMEOPERATOR',pic:'ZZZ9'},{av:'AV94PessoaNome',fld:'vPESSOANOME',pic:''},{av:'AV99PedidoDt',fld:'vPEDIDODT',pic:''},{av:'AV100PedidoDt_To',fld:'vPEDIDODT_TO',pic:''},{av:'AV101PedidoDtEntrega',fld:'vPEDIDODTENTREGA',pic:''},{av:'AV102PedidoDtEntrega_To',fld:'vPEDIDODTENTREGA_TO',pic:''},{av:'cmbavPedidostatus'},{av:'AV103PedidoStatus',fld:'vPEDIDOSTATUS',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'AV96TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV97TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV63TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'AV64TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'AV73TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'AV74TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'AV79TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'AV82TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'R$ Z,ZZZ,ZZ,ZZ9.99'},{av:'AV83TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'R$ Z,ZZZ,ZZ,ZZ9.99'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV61ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV98ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV71ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV80ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV84ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV70TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'AV131Pgmname',fld:'vPGMNAME',pic:''},{av:'cmbPedidoStatus'},{av:'A34PedidoStatus',fld:'PEDIDOSTATUS',pic:'',hsh:true},{av:'A32PedidoId',fld:'PEDIDOID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("VAPROVAR.CLICK",",oparms:[{av:'AV58PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV95PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV62PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV68PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV72PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV78PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV81PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtPedidoId_Visible',ctrl:'PEDIDOID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPedidoDt_Visible',ctrl:'PEDIDODT',prop:'Visible'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Visible',ctrl:'PEDIDODTENTREGA',prop:'Visible'},{av:'chkPedidoRetirada.Visible',ctrl:'PEDIDORETIRADA',prop:'Visible'},{av:'edtPedidoTotal_Visible',ctrl:'PEDIDOTOTAL',prop:'Visible'},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV87GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV88GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("VENCERRAR.CLICK","{handler:'E27132',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavPessoanomeoperator'},{av:'AV93PessoaNomeOperator',fld:'vPESSOANOMEOPERATOR',pic:'ZZZ9'},{av:'AV94PessoaNome',fld:'vPESSOANOME',pic:''},{av:'AV99PedidoDt',fld:'vPEDIDODT',pic:''},{av:'AV100PedidoDt_To',fld:'vPEDIDODT_TO',pic:''},{av:'AV101PedidoDtEntrega',fld:'vPEDIDODTENTREGA',pic:''},{av:'AV102PedidoDtEntrega_To',fld:'vPEDIDODTENTREGA_TO',pic:''},{av:'cmbavPedidostatus'},{av:'AV103PedidoStatus',fld:'vPEDIDOSTATUS',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'AV96TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV97TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV63TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'AV64TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'AV73TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'AV74TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'AV79TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'AV82TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'R$ Z,ZZZ,ZZ,ZZ9.99'},{av:'AV83TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'R$ Z,ZZZ,ZZ,ZZ9.99'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV61ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV98ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV71ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV80ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV84ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV70TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'AV131Pgmname',fld:'vPGMNAME',pic:''},{av:'cmbPedidoStatus'},{av:'A34PedidoStatus',fld:'PEDIDOSTATUS',pic:'',hsh:true},{av:'A32PedidoId',fld:'PEDIDOID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("VENCERRAR.CLICK",",oparms:[{av:'AV58PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV95PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV62PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV68PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV72PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV78PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV81PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtPedidoId_Visible',ctrl:'PEDIDOID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPedidoDt_Visible',ctrl:'PEDIDODT',prop:'Visible'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Visible',ctrl:'PEDIDODTENTREGA',prop:'Visible'},{av:'chkPedidoRetirada.Visible',ctrl:'PEDIDORETIRADA',prop:'Visible'},{av:'edtPedidoTotal_Visible',ctrl:'PEDIDOTOTAL',prop:'Visible'},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV87GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV88GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("VREPROVAR.CLICK","{handler:'E28132',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavPessoanomeoperator'},{av:'AV93PessoaNomeOperator',fld:'vPESSOANOMEOPERATOR',pic:'ZZZ9'},{av:'AV94PessoaNome',fld:'vPESSOANOME',pic:''},{av:'AV99PedidoDt',fld:'vPEDIDODT',pic:''},{av:'AV100PedidoDt_To',fld:'vPEDIDODT_TO',pic:''},{av:'AV101PedidoDtEntrega',fld:'vPEDIDODTENTREGA',pic:''},{av:'AV102PedidoDtEntrega_To',fld:'vPEDIDODTENTREGA_TO',pic:''},{av:'cmbavPedidostatus'},{av:'AV103PedidoStatus',fld:'vPEDIDOSTATUS',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'AV96TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV97TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV63TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'AV64TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'AV73TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'AV74TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'AV79TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'AV82TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'R$ Z,ZZZ,ZZ,ZZ9.99'},{av:'AV83TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'R$ Z,ZZZ,ZZ,ZZ9.99'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV61ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV98ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV71ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV80ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV84ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV70TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'AV131Pgmname',fld:'vPGMNAME',pic:''},{av:'cmbPedidoStatus'},{av:'A34PedidoStatus',fld:'PEDIDOSTATUS',pic:'',hsh:true},{av:'A32PedidoId',fld:'PEDIDOID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("VREPROVAR.CLICK",",oparms:[{av:'AV58PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV95PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV62PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV68PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV72PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV78PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV81PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtPedidoId_Visible',ctrl:'PEDIDOID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPedidoDt_Visible',ctrl:'PEDIDODT',prop:'Visible'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Visible',ctrl:'PEDIDODTENTREGA',prop:'Visible'},{av:'chkPedidoRetirada.Visible',ctrl:'PEDIDORETIRADA',prop:'Visible'},{av:'edtPedidoTotal_Visible',ctrl:'PEDIDOTOTAL',prop:'Visible'},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV87GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV88GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
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
      }

      public override void initialize( )
      {
         Gridpaginationbar_Selectedpage = "";
         Ddo_pedidoid_Activeeventkey = "";
         Ddo_pedidoid_Filteredtext_get = "";
         Ddo_pedidoid_Filteredtextto_get = "";
         Ddo_pessoanome_Activeeventkey = "";
         Ddo_pessoanome_Filteredtext_get = "";
         Ddo_pessoanome_Selectedvalue_get = "";
         Ddo_pedidodt_Activeeventkey = "";
         Ddo_pedidodt_Filteredtext_get = "";
         Ddo_pedidodt_Filteredtextto_get = "";
         Ddo_pedidostatus_Activeeventkey = "";
         Ddo_pedidostatus_Selectedvalue_get = "";
         Ddo_pedidodtentrega_Activeeventkey = "";
         Ddo_pedidodtentrega_Filteredtext_get = "";
         Ddo_pedidodtentrega_Filteredtextto_get = "";
         Ddo_pedidoretirada_Activeeventkey = "";
         Ddo_pedidoretirada_Selectedvalue_get = "";
         Ddo_pedidototal_Activeeventkey = "";
         Ddo_pedidototal_Filteredtext_get = "";
         Ddo_pedidototal_Filteredtextto_get = "";
         Ddo_gridcolumnsselector_Columnsselectorvalues = "";
         Ddo_managefilters_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV94PessoaNome = "";
         AV99PedidoDt = DateTime.MinValue;
         AV100PedidoDt_To = DateTime.MinValue;
         AV101PedidoDtEntrega = DateTime.MinValue;
         AV102PedidoDtEntrega_To = DateTime.MinValue;
         AV103PedidoStatus = "";
         AV96TFPessoaNome = "";
         AV97TFPessoaNome_Sel = "";
         AV63TFPedidoDt = DateTime.MinValue;
         AV64TFPedidoDt_To = DateTime.MinValue;
         AV73TFPedidoDtEntrega = DateTime.MinValue;
         AV74TFPedidoDtEntrega_To = DateTime.MinValue;
         AV44ColumnsSelector = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector(context);
         AV61ddo_PedidoIdTitleControlIdToReplace = "";
         AV98ddo_PessoaNomeTitleControlIdToReplace = "";
         AV67ddo_PedidoDtTitleControlIdToReplace = "";
         AV71ddo_PedidoStatusTitleControlIdToReplace = "";
         AV77ddo_PedidoDtEntregaTitleControlIdToReplace = "";
         AV80ddo_PedidoRetiradaTitleControlIdToReplace = "";
         AV84ddo_PedidoTotalTitleControlIdToReplace = "";
         AV70TFPedidoStatus_Sels = new GxSimpleCollection<String>();
         AV131Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV56ManageFiltersData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV85DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV58PedidoIdTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV95PessoaNomeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV62PedidoDtTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV68PedidoStatusTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV72PedidoDtEntregaTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV78PedidoRetiradaTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV81PedidoTotalTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV10GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         Ddo_pedidoid_Filteredtext_set = "";
         Ddo_pedidoid_Filteredtextto_set = "";
         Ddo_pedidoid_Sortedstatus = "";
         Ddo_pessoanome_Filteredtext_set = "";
         Ddo_pessoanome_Selectedvalue_set = "";
         Ddo_pessoanome_Sortedstatus = "";
         Ddo_pedidodt_Filteredtext_set = "";
         Ddo_pedidodt_Filteredtextto_set = "";
         Ddo_pedidodt_Sortedstatus = "";
         Ddo_pedidostatus_Selectedvalue_set = "";
         Ddo_pedidostatus_Sortedstatus = "";
         Ddo_pedidodtentrega_Filteredtext_set = "";
         Ddo_pedidodtentrega_Filteredtextto_set = "";
         Ddo_pedidodtentrega_Sortedstatus = "";
         Ddo_pedidoretirada_Selectedvalue_set = "";
         Ddo_pedidoretirada_Sortedstatus = "";
         Ddo_pedidototal_Filteredtext_set = "";
         Ddo_pedidototal_Filteredtextto_set = "";
         Ddo_pedidototal_Sortedstatus = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ucDvpanel_tableheader = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtninsert_Jsonclick = "";
         bttBtneditcolumns_Jsonclick = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV89Update = "";
         AV90Delete = "";
         AV92Encerrar = "";
         AV106Aprovar = "";
         AV107Reprovar = "";
         A2PessoaNome = "";
         A33PedidoDt = DateTime.MinValue;
         A34PedidoStatus = "";
         A35PedidoDtEntrega = DateTime.MinValue;
         ucGridpaginationbar = new GXUserControl();
         ucDdo_pedidoid = new GXUserControl();
         ucDdo_pessoanome = new GXUserControl();
         ucDdo_pedidodt = new GXUserControl();
         ucDdo_pedidostatus = new GXUserControl();
         ucDdo_pedidodtentrega = new GXUserControl();
         ucDdo_pedidoretirada = new GXUserControl();
         ucDdo_pedidototal = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         ucDdo_gridcolumnsselector = new GXUserControl();
         AV65DDO_PedidoDtAuxDate = DateTime.MinValue;
         AV66DDO_PedidoDtAuxDateTo = DateTime.MinValue;
         AV75DDO_PedidoDtEntregaAuxDate = DateTime.MinValue;
         AV76DDO_PedidoDtEntregaAuxDateTo = DateTime.MinValue;
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV125PedidoWWDS_13_Tfpedidostatus_sels = new GxSimpleCollection<String>();
         scmdbuf = "";
         lV113PedidoWWDS_1_Pessoanome = "";
         lV121PedidoWWDS_9_Tfpessoanome = "";
         AV113PedidoWWDS_1_Pessoanome = "";
         AV114PedidoWWDS_2_Pedidodt = DateTime.MinValue;
         AV115PedidoWWDS_3_Pedidodt_to = DateTime.MinValue;
         AV116PedidoWWDS_4_Pedidodtentrega = DateTime.MinValue;
         AV117PedidoWWDS_5_Pedidodtentrega_to = DateTime.MinValue;
         AV118PedidoWWDS_6_Pedidostatus = "";
         AV122PedidoWWDS_10_Tfpessoanome_sel = "";
         AV121PedidoWWDS_9_Tfpessoanome = "";
         AV123PedidoWWDS_11_Tfpedidodt = DateTime.MinValue;
         AV124PedidoWWDS_12_Tfpedidodt_to = DateTime.MinValue;
         AV126PedidoWWDS_14_Tfpedidodtentrega = DateTime.MinValue;
         AV127PedidoWWDS_15_Tfpedidodtentrega_to = DateTime.MinValue;
         H00132_A1PessoaId = new short[1] ;
         H00132_A37PedidoTotal = new decimal[1] ;
         H00132_A36PedidoRetirada = new bool[] {false} ;
         H00132_A35PedidoDtEntrega = new DateTime[] {DateTime.MinValue} ;
         H00132_A34PedidoStatus = new String[] {""} ;
         H00132_A33PedidoDt = new DateTime[] {DateTime.MinValue} ;
         H00132_A2PessoaNome = new String[] {""} ;
         H00132_A32PedidoId = new short[1] ;
         H00133_AGRID_nRecordCount = new long[1] ;
         AV7HTTPRequest = new GxHttpRequest( context);
         ucDdo_managefilters = new GXUserControl();
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV51Session = context.GetSession();
         AV32ColumnsSelectorXML = "";
         AV69TFPedidoStatus_SelsJson = "";
         GridRow = new GXWebRow();
         AV53ManageFiltersXml = "";
         AV39UserCustomValue = "";
         GXt_char2 = "";
         AV45ColumnsSelectorAux = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector(context);
         AV57ManageFiltersDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
         AV54ManageFiltersItems = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item>( context, "Item", "");
         AV55ManageFiltersItem = new GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item(context);
         AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV8TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV108Status = "";
         Ddo_managefilters_Caption = "";
         lblFiltertextpessoanome_Jsonclick = "";
         lblFiltertextpedidodt_Jsonclick = "";
         lblFiltertextpedidodtentrega_Jsonclick = "";
         lblPedidodtentrega_rangemiddletext_Jsonclick = "";
         lblPedidodt_rangemiddletext_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pedidoww__default(),
            new Object[][] {
                new Object[] {
               H00132_A1PessoaId, H00132_A37PedidoTotal, H00132_A36PedidoRetirada, H00132_A35PedidoDtEntrega, H00132_A34PedidoStatus, H00132_A33PedidoDt, H00132_A2PessoaNome, H00132_A32PedidoId
               }
               , new Object[] {
               H00133_AGRID_nRecordCount
               }
            }
         );
         AV131Pgmname = "PedidoWW";
         /* GeneXus formulas. */
         AV131Pgmname = "PedidoWW";
         context.Gx_err = 0;
         edtavUpdate_Enabled = 0;
         edtavDelete_Enabled = 0;
         edtavEncerrar_Enabled = 0;
         edtavAprovar_Enabled = 0;
         edtavReprovar_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_91 ;
      private short nGXsfl_91_idx=1 ;
      private short GRID_nEOF ;
      private short AV93PessoaNomeOperator ;
      private short AV13OrderedBy ;
      private short AV59TFPedidoId ;
      private short AV60TFPedidoId_To ;
      private short AV79TFPedidoRetirada_Sel ;
      private short AV52ManageFiltersExecutionStep ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtPedidoId_Titleformat ;
      private short edtPessoaNome_Titleformat ;
      private short edtPedidoDt_Titleformat ;
      private short cmbPedidoStatus_Titleformat ;
      private short edtPedidoDtEntrega_Titleformat ;
      private short chkPedidoRetirada_Titleformat ;
      private short edtPedidoTotal_Titleformat ;
      private short subGrid_Sortable ;
      private short A32PedidoId ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV119PedidoWWDS_7_Tfpedidoid ;
      private short AV120PedidoWWDS_8_Tfpedidoid_to ;
      private short AV128PedidoWWDS_16_Tfpedidoretirada_sel ;
      private short A1PessoaId ;
      private short nGXWrapped ;
      private short subGrid_Backstyle ;
      private int subGrid_Rows ;
      private int Gridpaginationbar_Rowsperpageselectedvalue ;
      private int Gridpaginationbar_Pagestoshow ;
      private int Ddo_pessoanome_Datalistupdateminimumcharacters ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtPedidoId_Visible ;
      private int edtPessoaNome_Visible ;
      private int edtPedidoDt_Visible ;
      private int edtPedidoDtEntrega_Visible ;
      private int edtPedidoTotal_Visible ;
      private int edtavUpdate_Enabled ;
      private int edtavDelete_Enabled ;
      private int edtavEncerrar_Enabled ;
      private int edtavAprovar_Enabled ;
      private int edtavReprovar_Enabled ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_pedidoidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_pessoanometitlecontrolidtoreplace_Visible ;
      private int edtavDdo_pedidodttitlecontrolidtoreplace_Visible ;
      private int edtavDdo_pedidostatustitlecontrolidtoreplace_Visible ;
      private int edtavDdo_pedidodtentregatitlecontrolidtoreplace_Visible ;
      private int edtavDdo_pedidoretiradatitlecontrolidtoreplace_Visible ;
      private int edtavDdo_pedidototaltitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int edtavManagefiltersexecutionstep_Visible ;
      private int edtavTfpedidoid_Visible ;
      private int edtavTfpedidoid_to_Visible ;
      private int edtavTfpessoanome_Visible ;
      private int edtavTfpessoanome_sel_Visible ;
      private int edtavTfpedidodt_Visible ;
      private int edtavTfpedidodt_to_Visible ;
      private int edtavTfpedidodtentrega_Visible ;
      private int edtavTfpedidodtentrega_to_Visible ;
      private int edtavTfpedidoretirada_sel_Visible ;
      private int edtavTfpedidototal_Visible ;
      private int edtavTfpedidototal_to_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV125PedidoWWDS_13_Tfpedidostatus_sels_Count ;
      private int AV86PageToGo ;
      private int AV132GXV1 ;
      private int AV133GXV2 ;
      private int edtavPedidodtentrega_Enabled ;
      private int edtavPedidodtentrega_to_Enabled ;
      private int edtavPedidodt_Enabled ;
      private int edtavPedidodt_to_Enabled ;
      private int edtavPessoanome_Enabled ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavUpdate_Visible ;
      private int edtavDelete_Visible ;
      private int edtavEncerrar_Visible ;
      private int edtavAprovar_Visible ;
      private int edtavReprovar_Visible ;
      private long GRID_nFirstRecordOnPage ;
      private long AV87GridCurrentPage ;
      private long AV88GridPageCount ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private decimal AV82TFPedidoTotal ;
      private decimal AV83TFPedidoTotal_To ;
      private decimal A37PedidoTotal ;
      private decimal AV129PedidoWWDS_17_Tfpedidototal ;
      private decimal AV130PedidoWWDS_18_Tfpedidototal_to ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_pedidoid_Activeeventkey ;
      private String Ddo_pedidoid_Filteredtext_get ;
      private String Ddo_pedidoid_Filteredtextto_get ;
      private String Ddo_pessoanome_Activeeventkey ;
      private String Ddo_pessoanome_Filteredtext_get ;
      private String Ddo_pessoanome_Selectedvalue_get ;
      private String Ddo_pedidodt_Activeeventkey ;
      private String Ddo_pedidodt_Filteredtext_get ;
      private String Ddo_pedidodt_Filteredtextto_get ;
      private String Ddo_pedidostatus_Activeeventkey ;
      private String Ddo_pedidostatus_Selectedvalue_get ;
      private String Ddo_pedidodtentrega_Activeeventkey ;
      private String Ddo_pedidodtentrega_Filteredtext_get ;
      private String Ddo_pedidodtentrega_Filteredtextto_get ;
      private String Ddo_pedidoretirada_Activeeventkey ;
      private String Ddo_pedidoretirada_Selectedvalue_get ;
      private String Ddo_pedidototal_Activeeventkey ;
      private String Ddo_pedidototal_Filteredtext_get ;
      private String Ddo_pedidototal_Filteredtextto_get ;
      private String Ddo_gridcolumnsselector_Columnsselectorvalues ;
      private String Ddo_managefilters_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_91_idx="0001" ;
      private String AV131Pgmname ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String Ddo_managefilters_Icon ;
      private String Ddo_managefilters_Tooltip ;
      private String Ddo_managefilters_Cls ;
      private String Dvpanel_tableheader_Width ;
      private String Dvpanel_tableheader_Cls ;
      private String Dvpanel_tableheader_Title ;
      private String Dvpanel_tableheader_Iconposition ;
      private String Gridpaginationbar_Class ;
      private String Gridpaginationbar_Previous ;
      private String Gridpaginationbar_Next ;
      private String Gridpaginationbar_Caption ;
      private String Gridpaginationbar_Pagingbuttonsposition ;
      private String Gridpaginationbar_Pagingcaptionposition ;
      private String Gridpaginationbar_Emptygridclass ;
      private String Gridpaginationbar_Rowsperpageoptions ;
      private String Gridpaginationbar_Emptygridcaption ;
      private String Gridpaginationbar_Rowsperpagecaption ;
      private String Ddo_pedidoid_Caption ;
      private String Ddo_pedidoid_Tooltip ;
      private String Ddo_pedidoid_Cls ;
      private String Ddo_pedidoid_Filteredtext_set ;
      private String Ddo_pedidoid_Filteredtextto_set ;
      private String Ddo_pedidoid_Dropdownoptionstype ;
      private String Ddo_pedidoid_Titlecontrolidtoreplace ;
      private String Ddo_pedidoid_Sortedstatus ;
      private String Ddo_pedidoid_Filtertype ;
      private String Ddo_pedidoid_Sortasc ;
      private String Ddo_pedidoid_Sortdsc ;
      private String Ddo_pedidoid_Cleanfilter ;
      private String Ddo_pedidoid_Rangefilterfrom ;
      private String Ddo_pedidoid_Rangefilterto ;
      private String Ddo_pedidoid_Searchbuttontext ;
      private String Ddo_pessoanome_Caption ;
      private String Ddo_pessoanome_Tooltip ;
      private String Ddo_pessoanome_Cls ;
      private String Ddo_pessoanome_Filteredtext_set ;
      private String Ddo_pessoanome_Selectedvalue_set ;
      private String Ddo_pessoanome_Dropdownoptionstype ;
      private String Ddo_pessoanome_Titlecontrolidtoreplace ;
      private String Ddo_pessoanome_Sortedstatus ;
      private String Ddo_pessoanome_Filtertype ;
      private String Ddo_pessoanome_Datalisttype ;
      private String Ddo_pessoanome_Datalistproc ;
      private String Ddo_pessoanome_Sortasc ;
      private String Ddo_pessoanome_Sortdsc ;
      private String Ddo_pessoanome_Loadingdata ;
      private String Ddo_pessoanome_Cleanfilter ;
      private String Ddo_pessoanome_Noresultsfound ;
      private String Ddo_pessoanome_Searchbuttontext ;
      private String Ddo_pedidodt_Caption ;
      private String Ddo_pedidodt_Tooltip ;
      private String Ddo_pedidodt_Cls ;
      private String Ddo_pedidodt_Filteredtext_set ;
      private String Ddo_pedidodt_Filteredtextto_set ;
      private String Ddo_pedidodt_Dropdownoptionstype ;
      private String Ddo_pedidodt_Titlecontrolidtoreplace ;
      private String Ddo_pedidodt_Sortedstatus ;
      private String Ddo_pedidodt_Filtertype ;
      private String Ddo_pedidodt_Sortasc ;
      private String Ddo_pedidodt_Sortdsc ;
      private String Ddo_pedidodt_Cleanfilter ;
      private String Ddo_pedidodt_Rangefilterfrom ;
      private String Ddo_pedidodt_Rangefilterto ;
      private String Ddo_pedidodt_Searchbuttontext ;
      private String Ddo_pedidostatus_Caption ;
      private String Ddo_pedidostatus_Tooltip ;
      private String Ddo_pedidostatus_Cls ;
      private String Ddo_pedidostatus_Selectedvalue_set ;
      private String Ddo_pedidostatus_Dropdownoptionstype ;
      private String Ddo_pedidostatus_Titlecontrolidtoreplace ;
      private String Ddo_pedidostatus_Sortedstatus ;
      private String Ddo_pedidostatus_Datalisttype ;
      private String Ddo_pedidostatus_Datalistfixedvalues ;
      private String Ddo_pedidostatus_Sortasc ;
      private String Ddo_pedidostatus_Sortdsc ;
      private String Ddo_pedidostatus_Cleanfilter ;
      private String Ddo_pedidostatus_Searchbuttontext ;
      private String Ddo_pedidodtentrega_Caption ;
      private String Ddo_pedidodtentrega_Tooltip ;
      private String Ddo_pedidodtentrega_Cls ;
      private String Ddo_pedidodtentrega_Filteredtext_set ;
      private String Ddo_pedidodtentrega_Filteredtextto_set ;
      private String Ddo_pedidodtentrega_Dropdownoptionstype ;
      private String Ddo_pedidodtentrega_Titlecontrolidtoreplace ;
      private String Ddo_pedidodtentrega_Sortedstatus ;
      private String Ddo_pedidodtentrega_Filtertype ;
      private String Ddo_pedidodtentrega_Sortasc ;
      private String Ddo_pedidodtentrega_Sortdsc ;
      private String Ddo_pedidodtentrega_Cleanfilter ;
      private String Ddo_pedidodtentrega_Rangefilterfrom ;
      private String Ddo_pedidodtentrega_Rangefilterto ;
      private String Ddo_pedidodtentrega_Searchbuttontext ;
      private String Ddo_pedidoretirada_Caption ;
      private String Ddo_pedidoretirada_Tooltip ;
      private String Ddo_pedidoretirada_Cls ;
      private String Ddo_pedidoretirada_Selectedvalue_set ;
      private String Ddo_pedidoretirada_Dropdownoptionstype ;
      private String Ddo_pedidoretirada_Titlecontrolidtoreplace ;
      private String Ddo_pedidoretirada_Sortedstatus ;
      private String Ddo_pedidoretirada_Datalisttype ;
      private String Ddo_pedidoretirada_Datalistfixedvalues ;
      private String Ddo_pedidoretirada_Sortasc ;
      private String Ddo_pedidoretirada_Sortdsc ;
      private String Ddo_pedidoretirada_Cleanfilter ;
      private String Ddo_pedidoretirada_Searchbuttontext ;
      private String Ddo_pedidototal_Caption ;
      private String Ddo_pedidototal_Tooltip ;
      private String Ddo_pedidototal_Cls ;
      private String Ddo_pedidototal_Filteredtext_set ;
      private String Ddo_pedidototal_Filteredtextto_set ;
      private String Ddo_pedidototal_Dropdownoptionstype ;
      private String Ddo_pedidototal_Titlecontrolidtoreplace ;
      private String Ddo_pedidototal_Sortedstatus ;
      private String Ddo_pedidototal_Filtertype ;
      private String Ddo_pedidototal_Sortasc ;
      private String Ddo_pedidototal_Sortdsc ;
      private String Ddo_pedidototal_Cleanfilter ;
      private String Ddo_pedidototal_Rangefilterfrom ;
      private String Ddo_pedidototal_Rangefilterto ;
      private String Ddo_pedidototal_Searchbuttontext ;
      private String Ddo_gridcolumnsselector_Caption ;
      private String Ddo_gridcolumnsselector_Tooltip ;
      private String Ddo_gridcolumnsselector_Cls ;
      private String Ddo_gridcolumnsselector_Dropdownoptionstype ;
      private String Ddo_gridcolumnsselector_Titlecontrolidtoreplace ;
      private String Ddo_gridcolumnsselector_Updatebuttontext ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String Dvpanel_tableheader_Internalname ;
      private String divTableheader_Internalname ;
      private String divTableactions_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtninsert_Internalname ;
      private String bttBtninsert_Jsonclick ;
      private String bttBtneditcolumns_Internalname ;
      private String bttBtneditcolumns_Jsonclick ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtPedidoId_Title ;
      private String edtPessoaNome_Title ;
      private String edtPedidoDt_Title ;
      private String edtPedidoDtEntrega_Title ;
      private String edtPedidoTotal_Title ;
      private String subGrid_Header ;
      private String AV89Update ;
      private String edtavUpdate_Link ;
      private String AV90Delete ;
      private String edtavDelete_Link ;
      private String AV92Encerrar ;
      private String AV106Aprovar ;
      private String AV107Reprovar ;
      private String edtPedidoDt_Link ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_pedidoid_Internalname ;
      private String edtavDdo_pedidoidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_pessoanome_Internalname ;
      private String edtavDdo_pessoanometitlecontrolidtoreplace_Internalname ;
      private String Ddo_pedidodt_Internalname ;
      private String edtavDdo_pedidodttitlecontrolidtoreplace_Internalname ;
      private String Ddo_pedidostatus_Internalname ;
      private String edtavDdo_pedidostatustitlecontrolidtoreplace_Internalname ;
      private String Ddo_pedidodtentrega_Internalname ;
      private String edtavDdo_pedidodtentregatitlecontrolidtoreplace_Internalname ;
      private String Ddo_pedidoretirada_Internalname ;
      private String edtavDdo_pedidoretiradatitlecontrolidtoreplace_Internalname ;
      private String Ddo_pedidototal_Internalname ;
      private String edtavDdo_pedidototaltitlecontrolidtoreplace_Internalname ;
      private String Workwithplusutilities1_Internalname ;
      private String Ddo_gridcolumnsselector_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String edtavManagefiltersexecutionstep_Internalname ;
      private String edtavManagefiltersexecutionstep_Jsonclick ;
      private String edtavTfpedidoid_Internalname ;
      private String edtavTfpedidoid_Jsonclick ;
      private String edtavTfpedidoid_to_Internalname ;
      private String edtavTfpedidoid_to_Jsonclick ;
      private String edtavTfpessoanome_Internalname ;
      private String edtavTfpessoanome_Jsonclick ;
      private String edtavTfpessoanome_sel_Internalname ;
      private String edtavTfpessoanome_sel_Jsonclick ;
      private String edtavTfpedidodt_Internalname ;
      private String edtavTfpedidodt_Jsonclick ;
      private String edtavTfpedidodt_to_Internalname ;
      private String edtavTfpedidodt_to_Jsonclick ;
      private String divDdo_pedidodtauxdates_Internalname ;
      private String edtavDdo_pedidodtauxdate_Internalname ;
      private String edtavDdo_pedidodtauxdate_Jsonclick ;
      private String edtavDdo_pedidodtauxdateto_Internalname ;
      private String edtavDdo_pedidodtauxdateto_Jsonclick ;
      private String edtavTfpedidodtentrega_Internalname ;
      private String edtavTfpedidodtentrega_Jsonclick ;
      private String edtavTfpedidodtentrega_to_Internalname ;
      private String edtavTfpedidodtentrega_to_Jsonclick ;
      private String divDdo_pedidodtentregaauxdates_Internalname ;
      private String edtavDdo_pedidodtentregaauxdate_Internalname ;
      private String edtavDdo_pedidodtentregaauxdate_Jsonclick ;
      private String edtavDdo_pedidodtentregaauxdateto_Internalname ;
      private String edtavDdo_pedidodtentregaauxdateto_Jsonclick ;
      private String edtavTfpedidoretirada_sel_Internalname ;
      private String edtavTfpedidoretirada_sel_Jsonclick ;
      private String edtavTfpedidototal_Internalname ;
      private String edtavTfpedidototal_Jsonclick ;
      private String edtavTfpedidototal_to_Internalname ;
      private String edtavTfpedidototal_to_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavUpdate_Internalname ;
      private String edtavDelete_Internalname ;
      private String edtavEncerrar_Internalname ;
      private String edtavAprovar_Internalname ;
      private String edtavReprovar_Internalname ;
      private String edtPedidoId_Internalname ;
      private String edtPessoaNome_Internalname ;
      private String edtPedidoDt_Internalname ;
      private String cmbPedidoStatus_Internalname ;
      private String edtPedidoDtEntrega_Internalname ;
      private String chkPedidoRetirada_Internalname ;
      private String edtPedidoTotal_Internalname ;
      private String cmbavPessoanomeoperator_Internalname ;
      private String cmbavPedidostatus_Internalname ;
      private String scmdbuf ;
      private String edtavPessoanome_Internalname ;
      private String edtavPedidodt_Internalname ;
      private String edtavPedidodt_to_Internalname ;
      private String edtavPedidodtentrega_Internalname ;
      private String edtavPedidodtentrega_to_Internalname ;
      private String Ddo_managefilters_Internalname ;
      private String GXt_char2 ;
      private String tblTablerightheader_Internalname ;
      private String Ddo_managefilters_Caption ;
      private String tblTablefilters_Internalname ;
      private String divTablesplittedfiltertextpessoanome_Internalname ;
      private String lblFiltertextpessoanome_Internalname ;
      private String lblFiltertextpessoanome_Jsonclick ;
      private String divTablesplittedfiltertextpedidodt_Internalname ;
      private String lblFiltertextpedidodt_Internalname ;
      private String lblFiltertextpedidodt_Jsonclick ;
      private String divTablesplittedfiltertextpedidodtentrega_Internalname ;
      private String lblFiltertextpedidodtentrega_Internalname ;
      private String lblFiltertextpedidodtentrega_Jsonclick ;
      private String cmbavPedidostatus_Jsonclick ;
      private String tblTablemergedpedidodtentrega_Internalname ;
      private String edtavPedidodtentrega_Jsonclick ;
      private String lblPedidodtentrega_rangemiddletext_Internalname ;
      private String lblPedidodtentrega_rangemiddletext_Jsonclick ;
      private String edtavPedidodtentrega_to_Jsonclick ;
      private String tblTablemergedpedidodt_Internalname ;
      private String edtavPedidodt_Jsonclick ;
      private String lblPedidodt_rangemiddletext_Internalname ;
      private String lblPedidodt_rangemiddletext_Jsonclick ;
      private String edtavPedidodt_to_Jsonclick ;
      private String tblTablemergedpessoanome_Internalname ;
      private String cmbavPessoanomeoperator_Jsonclick ;
      private String edtavPessoanome_Jsonclick ;
      private String sGXsfl_91_fel_idx="0001" ;
      private String ROClassString ;
      private String edtavUpdate_Jsonclick ;
      private String edtavDelete_Jsonclick ;
      private String edtavEncerrar_Jsonclick ;
      private String edtavAprovar_Jsonclick ;
      private String edtavReprovar_Jsonclick ;
      private String edtPedidoId_Jsonclick ;
      private String edtPessoaNome_Jsonclick ;
      private String edtPedidoDt_Jsonclick ;
      private String GXCCtl ;
      private String cmbPedidoStatus_Jsonclick ;
      private String edtPedidoDtEntrega_Jsonclick ;
      private String edtPedidoTotal_Jsonclick ;
      private DateTime AV99PedidoDt ;
      private DateTime AV100PedidoDt_To ;
      private DateTime AV101PedidoDtEntrega ;
      private DateTime AV102PedidoDtEntrega_To ;
      private DateTime AV63TFPedidoDt ;
      private DateTime AV64TFPedidoDt_To ;
      private DateTime AV73TFPedidoDtEntrega ;
      private DateTime AV74TFPedidoDtEntrega_To ;
      private DateTime A33PedidoDt ;
      private DateTime A35PedidoDtEntrega ;
      private DateTime AV65DDO_PedidoDtAuxDate ;
      private DateTime AV66DDO_PedidoDtAuxDateTo ;
      private DateTime AV75DDO_PedidoDtEntregaAuxDate ;
      private DateTime AV76DDO_PedidoDtEntregaAuxDateTo ;
      private DateTime AV114PedidoWWDS_2_Pedidodt ;
      private DateTime AV115PedidoWWDS_3_Pedidodt_to ;
      private DateTime AV116PedidoWWDS_4_Pedidodtentrega ;
      private DateTime AV117PedidoWWDS_5_Pedidodtentrega_to ;
      private DateTime AV123PedidoWWDS_11_Tfpedidodt ;
      private DateTime AV124PedidoWWDS_12_Tfpedidodt_to ;
      private DateTime AV126PedidoWWDS_14_Tfpedidodtentrega ;
      private DateTime AV127PedidoWWDS_15_Tfpedidodtentrega_to ;
      private bool entryPointCalled ;
      private bool AV14OrderedDsc ;
      private bool toggleJsOutput ;
      private bool Dvpanel_tableheader_Collapsible ;
      private bool Dvpanel_tableheader_Collapsed ;
      private bool Dvpanel_tableheader_Autowidth ;
      private bool Dvpanel_tableheader_Autoheight ;
      private bool Dvpanel_tableheader_Showcollapseicon ;
      private bool Dvpanel_tableheader_Autoscroll ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_pedidoid_Includesortasc ;
      private bool Ddo_pedidoid_Includesortdsc ;
      private bool Ddo_pedidoid_Includefilter ;
      private bool Ddo_pedidoid_Filterisrange ;
      private bool Ddo_pedidoid_Includedatalist ;
      private bool Ddo_pessoanome_Includesortasc ;
      private bool Ddo_pessoanome_Includesortdsc ;
      private bool Ddo_pessoanome_Includefilter ;
      private bool Ddo_pessoanome_Filterisrange ;
      private bool Ddo_pessoanome_Includedatalist ;
      private bool Ddo_pedidodt_Includesortasc ;
      private bool Ddo_pedidodt_Includesortdsc ;
      private bool Ddo_pedidodt_Includefilter ;
      private bool Ddo_pedidodt_Filterisrange ;
      private bool Ddo_pedidodt_Includedatalist ;
      private bool Ddo_pedidostatus_Includesortasc ;
      private bool Ddo_pedidostatus_Includesortdsc ;
      private bool Ddo_pedidostatus_Includefilter ;
      private bool Ddo_pedidostatus_Includedatalist ;
      private bool Ddo_pedidostatus_Allowmultipleselection ;
      private bool Ddo_pedidodtentrega_Includesortasc ;
      private bool Ddo_pedidodtentrega_Includesortdsc ;
      private bool Ddo_pedidodtentrega_Includefilter ;
      private bool Ddo_pedidodtentrega_Filterisrange ;
      private bool Ddo_pedidodtentrega_Includedatalist ;
      private bool Ddo_pedidoretirada_Includesortasc ;
      private bool Ddo_pedidoretirada_Includesortdsc ;
      private bool Ddo_pedidoretirada_Includefilter ;
      private bool Ddo_pedidoretirada_Includedatalist ;
      private bool Ddo_pedidototal_Includesortasc ;
      private bool Ddo_pedidototal_Includesortdsc ;
      private bool Ddo_pedidototal_Includefilter ;
      private bool Ddo_pedidototal_Filterisrange ;
      private bool Ddo_pedidototal_Includedatalist ;
      private bool wbLoad ;
      private bool A36PedidoRetirada ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_91_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private String AV32ColumnsSelectorXML ;
      private String AV69TFPedidoStatus_SelsJson ;
      private String AV53ManageFiltersXml ;
      private String AV39UserCustomValue ;
      private String AV94PessoaNome ;
      private String AV103PedidoStatus ;
      private String AV96TFPessoaNome ;
      private String AV97TFPessoaNome_Sel ;
      private String AV61ddo_PedidoIdTitleControlIdToReplace ;
      private String AV98ddo_PessoaNomeTitleControlIdToReplace ;
      private String AV67ddo_PedidoDtTitleControlIdToReplace ;
      private String AV71ddo_PedidoStatusTitleControlIdToReplace ;
      private String AV77ddo_PedidoDtEntregaTitleControlIdToReplace ;
      private String AV80ddo_PedidoRetiradaTitleControlIdToReplace ;
      private String AV84ddo_PedidoTotalTitleControlIdToReplace ;
      private String A2PessoaNome ;
      private String A34PedidoStatus ;
      private String lV113PedidoWWDS_1_Pessoanome ;
      private String lV121PedidoWWDS_9_Tfpessoanome ;
      private String AV113PedidoWWDS_1_Pessoanome ;
      private String AV118PedidoWWDS_6_Pedidostatus ;
      private String AV122PedidoWWDS_10_Tfpessoanome_sel ;
      private String AV121PedidoWWDS_9_Tfpessoanome ;
      private String AV108Status ;
      private IGxSession AV51Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_pedidoid ;
      private GXUserControl ucDdo_pessoanome ;
      private GXUserControl ucDdo_pedidodt ;
      private GXUserControl ucDdo_pedidostatus ;
      private GXUserControl ucDdo_pedidodtentrega ;
      private GXUserControl ucDdo_pedidoretirada ;
      private GXUserControl ucDdo_pedidototal ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXUserControl ucDdo_gridcolumnsselector ;
      private GXUserControl ucDdo_managefilters ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavPessoanomeoperator ;
      private GXCombobox cmbavPedidostatus ;
      private GXCombobox cmbPedidoStatus ;
      private GXCheckbox chkPedidoRetirada ;
      private IDataStoreProvider pr_default ;
      private short[] H00132_A1PessoaId ;
      private decimal[] H00132_A37PedidoTotal ;
      private bool[] H00132_A36PedidoRetirada ;
      private DateTime[] H00132_A35PedidoDtEntrega ;
      private String[] H00132_A34PedidoStatus ;
      private DateTime[] H00132_A33PedidoDt ;
      private String[] H00132_A2PessoaNome ;
      private short[] H00132_A32PedidoId ;
      private long[] H00133_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV7HTTPRequest ;
      private GxSimpleCollection<String> AV70TFPedidoStatus_Sels ;
      private GxSimpleCollection<String> AV125PedidoWWDS_13_Tfpedidostatus_sels ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item> AV54ManageFiltersItems ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV56ManageFiltersData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV58PedidoIdTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV95PessoaNomeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV62PedidoDtTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV68PedidoStatusTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV72PedidoDtEntregaTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV78PedidoRetiradaTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV81PedidoTotalTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV8TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV10GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV11GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector AV44ColumnsSelector ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector AV45ColumnsSelectorAux ;
      private GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item AV55ManageFiltersItem ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item AV57ManageFiltersDataItem ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV85DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class pedidoww__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00132( IGxContext context ,
                                             String A34PedidoStatus ,
                                             GxSimpleCollection<String> AV125PedidoWWDS_13_Tfpedidostatus_sels ,
                                             short AV93PessoaNomeOperator ,
                                             String AV113PedidoWWDS_1_Pessoanome ,
                                             DateTime AV114PedidoWWDS_2_Pedidodt ,
                                             DateTime AV115PedidoWWDS_3_Pedidodt_to ,
                                             DateTime AV116PedidoWWDS_4_Pedidodtentrega ,
                                             DateTime AV117PedidoWWDS_5_Pedidodtentrega_to ,
                                             String AV118PedidoWWDS_6_Pedidostatus ,
                                             short AV119PedidoWWDS_7_Tfpedidoid ,
                                             short AV120PedidoWWDS_8_Tfpedidoid_to ,
                                             String AV122PedidoWWDS_10_Tfpessoanome_sel ,
                                             String AV121PedidoWWDS_9_Tfpessoanome ,
                                             DateTime AV123PedidoWWDS_11_Tfpedidodt ,
                                             DateTime AV124PedidoWWDS_12_Tfpedidodt_to ,
                                             int AV125PedidoWWDS_13_Tfpedidostatus_sels_Count ,
                                             DateTime AV126PedidoWWDS_14_Tfpedidodtentrega ,
                                             DateTime AV127PedidoWWDS_15_Tfpedidodtentrega_to ,
                                             short AV128PedidoWWDS_16_Tfpedidoretirada_sel ,
                                             decimal AV129PedidoWWDS_17_Tfpedidototal ,
                                             decimal AV130PedidoWWDS_18_Tfpedidototal_to ,
                                             String A2PessoaNome ,
                                             DateTime A33PedidoDt ,
                                             DateTime A35PedidoDtEntrega ,
                                             short A32PedidoId ,
                                             bool A36PedidoRetirada ,
                                             decimal A37PedidoTotal ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [19] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " T1.[PessoaId], T1.[PedidoTotal], T1.[PedidoRetirada], T1.[PedidoDtEntrega], T1.[PedidoStatus], T1.[PedidoDt], T2.[PessoaNome], T1.[PedidoId]";
         sFromString = " FROM ([Pedido] T1 INNER JOIN [Pessoa] T2 ON T2.[PessoaId] = T1.[PessoaId])";
         sOrderString = "";
         if ( ( AV93PessoaNomeOperator == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV113PedidoWWDS_1_Pessoanome)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[PessoaNome] like '%' + @lV113PedidoWWDS_1_Pessoanome)";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[PessoaNome] like '%' + @lV113PedidoWWDS_1_Pessoanome)";
            }
         }
         else
         {
            GXv_int3[0] = 1;
         }
         if ( ! (DateTime.MinValue==AV114PedidoWWDS_2_Pedidodt) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDt] >= @AV114PedidoWWDS_2_Pedidodt)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDt] >= @AV114PedidoWWDS_2_Pedidodt)";
            }
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (DateTime.MinValue==AV115PedidoWWDS_3_Pedidodt_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDt] <= @AV115PedidoWWDS_3_Pedidodt_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDt] <= @AV115PedidoWWDS_3_Pedidodt_to)";
            }
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (DateTime.MinValue==AV116PedidoWWDS_4_Pedidodtentrega) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDtEntrega] >= @AV116PedidoWWDS_4_Pedidodtentrega)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDtEntrega] >= @AV116PedidoWWDS_4_Pedidodtentrega)";
            }
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! (DateTime.MinValue==AV117PedidoWWDS_5_Pedidodtentrega_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDtEntrega] <= @AV117PedidoWWDS_5_Pedidodtentrega_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDtEntrega] <= @AV117PedidoWWDS_5_Pedidodtentrega_to)";
            }
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV118PedidoWWDS_6_Pedidostatus)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoStatus] = @AV118PedidoWWDS_6_Pedidostatus)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoStatus] = @AV118PedidoWWDS_6_Pedidostatus)";
            }
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! (0==AV119PedidoWWDS_7_Tfpedidoid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoId] >= @AV119PedidoWWDS_7_Tfpedidoid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoId] >= @AV119PedidoWWDS_7_Tfpedidoid)";
            }
         }
         else
         {
            GXv_int3[6] = 1;
         }
         if ( ! (0==AV120PedidoWWDS_8_Tfpedidoid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoId] <= @AV120PedidoWWDS_8_Tfpedidoid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoId] <= @AV120PedidoWWDS_8_Tfpedidoid_to)";
            }
         }
         else
         {
            GXv_int3[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV122PedidoWWDS_10_Tfpessoanome_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV121PedidoWWDS_9_Tfpessoanome)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[PessoaNome] like @lV121PedidoWWDS_9_Tfpessoanome)";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[PessoaNome] like @lV121PedidoWWDS_9_Tfpessoanome)";
            }
         }
         else
         {
            GXv_int3[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV122PedidoWWDS_10_Tfpessoanome_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[PessoaNome] = @AV122PedidoWWDS_10_Tfpessoanome_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[PessoaNome] = @AV122PedidoWWDS_10_Tfpessoanome_sel)";
            }
         }
         else
         {
            GXv_int3[9] = 1;
         }
         if ( ! (DateTime.MinValue==AV123PedidoWWDS_11_Tfpedidodt) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDt] >= @AV123PedidoWWDS_11_Tfpedidodt)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDt] >= @AV123PedidoWWDS_11_Tfpedidodt)";
            }
         }
         else
         {
            GXv_int3[10] = 1;
         }
         if ( ! (DateTime.MinValue==AV124PedidoWWDS_12_Tfpedidodt_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDt] <= @AV124PedidoWWDS_12_Tfpedidodt_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDt] <= @AV124PedidoWWDS_12_Tfpedidodt_to)";
            }
         }
         else
         {
            GXv_int3[11] = 1;
         }
         if ( AV125PedidoWWDS_13_Tfpedidostatus_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV125PedidoWWDS_13_Tfpedidostatus_sels, "T1.[PedidoStatus] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV125PedidoWWDS_13_Tfpedidostatus_sels, "T1.[PedidoStatus] IN (", ")") + ")";
            }
         }
         if ( ! (DateTime.MinValue==AV126PedidoWWDS_14_Tfpedidodtentrega) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDtEntrega] >= @AV126PedidoWWDS_14_Tfpedidodtentrega)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDtEntrega] >= @AV126PedidoWWDS_14_Tfpedidodtentrega)";
            }
         }
         else
         {
            GXv_int3[12] = 1;
         }
         if ( ! (DateTime.MinValue==AV127PedidoWWDS_15_Tfpedidodtentrega_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDtEntrega] <= @AV127PedidoWWDS_15_Tfpedidodtentrega_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDtEntrega] <= @AV127PedidoWWDS_15_Tfpedidodtentrega_to)";
            }
         }
         else
         {
            GXv_int3[13] = 1;
         }
         if ( AV128PedidoWWDS_16_Tfpedidoretirada_sel == 1 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoRetirada] = 1)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoRetirada] = 1)";
            }
         }
         if ( AV128PedidoWWDS_16_Tfpedidoretirada_sel == 2 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoRetirada] = 0)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoRetirada] = 0)";
            }
         }
         if ( ! (Convert.ToDecimal(0)==AV129PedidoWWDS_17_Tfpedidototal) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoTotal] >= @AV129PedidoWWDS_17_Tfpedidototal)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoTotal] >= @AV129PedidoWWDS_17_Tfpedidototal)";
            }
         }
         else
         {
            GXv_int3[14] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV130PedidoWWDS_18_Tfpedidototal_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoTotal] <= @AV130PedidoWWDS_18_Tfpedidototal_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoTotal] <= @AV130PedidoWWDS_18_Tfpedidototal_to)";
            }
         }
         else
         {
            GXv_int3[15] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         if ( ( AV13OrderedBy == 1 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[PedidoDt]";
         }
         else if ( ( AV13OrderedBy == 1 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[PedidoDt] DESC";
         }
         else if ( ( AV13OrderedBy == 2 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[PedidoId]";
         }
         else if ( ( AV13OrderedBy == 2 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[PedidoId] DESC";
         }
         else if ( ( AV13OrderedBy == 3 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T2.[PessoaNome]";
         }
         else if ( ( AV13OrderedBy == 3 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T2.[PessoaNome] DESC";
         }
         else if ( ( AV13OrderedBy == 4 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[PedidoStatus]";
         }
         else if ( ( AV13OrderedBy == 4 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[PedidoStatus] DESC";
         }
         else if ( ( AV13OrderedBy == 5 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[PedidoDtEntrega]";
         }
         else if ( ( AV13OrderedBy == 5 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[PedidoDtEntrega] DESC";
         }
         else if ( ( AV13OrderedBy == 6 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[PedidoRetirada]";
         }
         else if ( ( AV13OrderedBy == 6 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[PedidoRetirada] DESC";
         }
         else if ( ( AV13OrderedBy == 7 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[PedidoTotal]";
         }
         else if ( ( AV13OrderedBy == 7 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[PedidoTotal] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY T1.[PedidoId]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H00133( IGxContext context ,
                                             String A34PedidoStatus ,
                                             GxSimpleCollection<String> AV125PedidoWWDS_13_Tfpedidostatus_sels ,
                                             short AV93PessoaNomeOperator ,
                                             String AV113PedidoWWDS_1_Pessoanome ,
                                             DateTime AV114PedidoWWDS_2_Pedidodt ,
                                             DateTime AV115PedidoWWDS_3_Pedidodt_to ,
                                             DateTime AV116PedidoWWDS_4_Pedidodtentrega ,
                                             DateTime AV117PedidoWWDS_5_Pedidodtentrega_to ,
                                             String AV118PedidoWWDS_6_Pedidostatus ,
                                             short AV119PedidoWWDS_7_Tfpedidoid ,
                                             short AV120PedidoWWDS_8_Tfpedidoid_to ,
                                             String AV122PedidoWWDS_10_Tfpessoanome_sel ,
                                             String AV121PedidoWWDS_9_Tfpessoanome ,
                                             DateTime AV123PedidoWWDS_11_Tfpedidodt ,
                                             DateTime AV124PedidoWWDS_12_Tfpedidodt_to ,
                                             int AV125PedidoWWDS_13_Tfpedidostatus_sels_Count ,
                                             DateTime AV126PedidoWWDS_14_Tfpedidodtentrega ,
                                             DateTime AV127PedidoWWDS_15_Tfpedidodtentrega_to ,
                                             short AV128PedidoWWDS_16_Tfpedidoretirada_sel ,
                                             decimal AV129PedidoWWDS_17_Tfpedidototal ,
                                             decimal AV130PedidoWWDS_18_Tfpedidototal_to ,
                                             String A2PessoaNome ,
                                             DateTime A33PedidoDt ,
                                             DateTime A35PedidoDtEntrega ,
                                             short A32PedidoId ,
                                             bool A36PedidoRetirada ,
                                             decimal A37PedidoTotal ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [16] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM ([Pedido] T1 INNER JOIN [Pessoa] T2 ON T2.[PessoaId] = T1.[PessoaId])";
         if ( ( AV93PessoaNomeOperator == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV113PedidoWWDS_1_Pessoanome)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[PessoaNome] like '%' + @lV113PedidoWWDS_1_Pessoanome)";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[PessoaNome] like '%' + @lV113PedidoWWDS_1_Pessoanome)";
            }
         }
         else
         {
            GXv_int5[0] = 1;
         }
         if ( ! (DateTime.MinValue==AV114PedidoWWDS_2_Pedidodt) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDt] >= @AV114PedidoWWDS_2_Pedidodt)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDt] >= @AV114PedidoWWDS_2_Pedidodt)";
            }
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( ! (DateTime.MinValue==AV115PedidoWWDS_3_Pedidodt_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDt] <= @AV115PedidoWWDS_3_Pedidodt_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDt] <= @AV115PedidoWWDS_3_Pedidodt_to)";
            }
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( ! (DateTime.MinValue==AV116PedidoWWDS_4_Pedidodtentrega) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDtEntrega] >= @AV116PedidoWWDS_4_Pedidodtentrega)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDtEntrega] >= @AV116PedidoWWDS_4_Pedidodtentrega)";
            }
         }
         else
         {
            GXv_int5[3] = 1;
         }
         if ( ! (DateTime.MinValue==AV117PedidoWWDS_5_Pedidodtentrega_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDtEntrega] <= @AV117PedidoWWDS_5_Pedidodtentrega_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDtEntrega] <= @AV117PedidoWWDS_5_Pedidodtentrega_to)";
            }
         }
         else
         {
            GXv_int5[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV118PedidoWWDS_6_Pedidostatus)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoStatus] = @AV118PedidoWWDS_6_Pedidostatus)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoStatus] = @AV118PedidoWWDS_6_Pedidostatus)";
            }
         }
         else
         {
            GXv_int5[5] = 1;
         }
         if ( ! (0==AV119PedidoWWDS_7_Tfpedidoid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoId] >= @AV119PedidoWWDS_7_Tfpedidoid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoId] >= @AV119PedidoWWDS_7_Tfpedidoid)";
            }
         }
         else
         {
            GXv_int5[6] = 1;
         }
         if ( ! (0==AV120PedidoWWDS_8_Tfpedidoid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoId] <= @AV120PedidoWWDS_8_Tfpedidoid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoId] <= @AV120PedidoWWDS_8_Tfpedidoid_to)";
            }
         }
         else
         {
            GXv_int5[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV122PedidoWWDS_10_Tfpessoanome_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV121PedidoWWDS_9_Tfpessoanome)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[PessoaNome] like @lV121PedidoWWDS_9_Tfpessoanome)";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[PessoaNome] like @lV121PedidoWWDS_9_Tfpessoanome)";
            }
         }
         else
         {
            GXv_int5[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV122PedidoWWDS_10_Tfpessoanome_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[PessoaNome] = @AV122PedidoWWDS_10_Tfpessoanome_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[PessoaNome] = @AV122PedidoWWDS_10_Tfpessoanome_sel)";
            }
         }
         else
         {
            GXv_int5[9] = 1;
         }
         if ( ! (DateTime.MinValue==AV123PedidoWWDS_11_Tfpedidodt) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDt] >= @AV123PedidoWWDS_11_Tfpedidodt)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDt] >= @AV123PedidoWWDS_11_Tfpedidodt)";
            }
         }
         else
         {
            GXv_int5[10] = 1;
         }
         if ( ! (DateTime.MinValue==AV124PedidoWWDS_12_Tfpedidodt_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDt] <= @AV124PedidoWWDS_12_Tfpedidodt_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDt] <= @AV124PedidoWWDS_12_Tfpedidodt_to)";
            }
         }
         else
         {
            GXv_int5[11] = 1;
         }
         if ( AV125PedidoWWDS_13_Tfpedidostatus_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV125PedidoWWDS_13_Tfpedidostatus_sels, "T1.[PedidoStatus] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV125PedidoWWDS_13_Tfpedidostatus_sels, "T1.[PedidoStatus] IN (", ")") + ")";
            }
         }
         if ( ! (DateTime.MinValue==AV126PedidoWWDS_14_Tfpedidodtentrega) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDtEntrega] >= @AV126PedidoWWDS_14_Tfpedidodtentrega)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDtEntrega] >= @AV126PedidoWWDS_14_Tfpedidodtentrega)";
            }
         }
         else
         {
            GXv_int5[12] = 1;
         }
         if ( ! (DateTime.MinValue==AV127PedidoWWDS_15_Tfpedidodtentrega_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoDtEntrega] <= @AV127PedidoWWDS_15_Tfpedidodtentrega_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoDtEntrega] <= @AV127PedidoWWDS_15_Tfpedidodtentrega_to)";
            }
         }
         else
         {
            GXv_int5[13] = 1;
         }
         if ( AV128PedidoWWDS_16_Tfpedidoretirada_sel == 1 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoRetirada] = 1)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoRetirada] = 1)";
            }
         }
         if ( AV128PedidoWWDS_16_Tfpedidoretirada_sel == 2 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoRetirada] = 0)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoRetirada] = 0)";
            }
         }
         if ( ! (Convert.ToDecimal(0)==AV129PedidoWWDS_17_Tfpedidototal) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoTotal] >= @AV129PedidoWWDS_17_Tfpedidototal)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoTotal] >= @AV129PedidoWWDS_17_Tfpedidototal)";
            }
         }
         else
         {
            GXv_int5[14] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV130PedidoWWDS_18_Tfpedidototal_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[PedidoTotal] <= @AV130PedidoWWDS_18_Tfpedidototal_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[PedidoTotal] <= @AV130PedidoWWDS_18_Tfpedidototal_to)";
            }
         }
         else
         {
            GXv_int5[15] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         if ( ( AV13OrderedBy == 1 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 1 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 2 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 2 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 3 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 3 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 4 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 4 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 5 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 5 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 6 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 6 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 7 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 7 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( true )
         {
            scmdbuf = scmdbuf + "";
         }
         GXv_Object6[0] = scmdbuf;
         GXv_Object6[1] = GXv_int5;
         return GXv_Object6 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H00132(context, (String)dynConstraints[0] , (GxSimpleCollection<String>)dynConstraints[1] , (short)dynConstraints[2] , (String)dynConstraints[3] , (DateTime)dynConstraints[4] , (DateTime)dynConstraints[5] , (DateTime)dynConstraints[6] , (DateTime)dynConstraints[7] , (String)dynConstraints[8] , (short)dynConstraints[9] , (short)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (DateTime)dynConstraints[13] , (DateTime)dynConstraints[14] , (int)dynConstraints[15] , (DateTime)dynConstraints[16] , (DateTime)dynConstraints[17] , (short)dynConstraints[18] , (decimal)dynConstraints[19] , (decimal)dynConstraints[20] , (String)dynConstraints[21] , (DateTime)dynConstraints[22] , (DateTime)dynConstraints[23] , (short)dynConstraints[24] , (bool)dynConstraints[25] , (decimal)dynConstraints[26] , (short)dynConstraints[27] , (bool)dynConstraints[28] );
               case 1 :
                     return conditional_H00133(context, (String)dynConstraints[0] , (GxSimpleCollection<String>)dynConstraints[1] , (short)dynConstraints[2] , (String)dynConstraints[3] , (DateTime)dynConstraints[4] , (DateTime)dynConstraints[5] , (DateTime)dynConstraints[6] , (DateTime)dynConstraints[7] , (String)dynConstraints[8] , (short)dynConstraints[9] , (short)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (DateTime)dynConstraints[13] , (DateTime)dynConstraints[14] , (int)dynConstraints[15] , (DateTime)dynConstraints[16] , (DateTime)dynConstraints[17] , (short)dynConstraints[18] , (decimal)dynConstraints[19] , (decimal)dynConstraints[20] , (String)dynConstraints[21] , (DateTime)dynConstraints[22] , (DateTime)dynConstraints[23] , (short)dynConstraints[24] , (bool)dynConstraints[25] , (decimal)dynConstraints[26] , (short)dynConstraints[27] , (bool)dynConstraints[28] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH00132 ;
          prmH00132 = new Object[] {
          new Object[] {"@lV113PedidoWWDS_1_Pessoanome",SqlDbType.VarChar,60,0} ,
          new Object[] {"@AV114PedidoWWDS_2_Pedidodt",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV115PedidoWWDS_3_Pedidodt_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV116PedidoWWDS_4_Pedidodtentrega",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV117PedidoWWDS_5_Pedidodtentrega_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV118PedidoWWDS_6_Pedidostatus",SqlDbType.VarChar,3,0} ,
          new Object[] {"@AV119PedidoWWDS_7_Tfpedidoid",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV120PedidoWWDS_8_Tfpedidoid_to",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV121PedidoWWDS_9_Tfpessoanome",SqlDbType.VarChar,60,0} ,
          new Object[] {"@AV122PedidoWWDS_10_Tfpessoanome_sel",SqlDbType.VarChar,60,0} ,
          new Object[] {"@AV123PedidoWWDS_11_Tfpedidodt",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV124PedidoWWDS_12_Tfpedidodt_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV126PedidoWWDS_14_Tfpedidodtentrega",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV127PedidoWWDS_15_Tfpedidodtentrega_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV129PedidoWWDS_17_Tfpedidototal",SqlDbType.Decimal,12,2} ,
          new Object[] {"@AV130PedidoWWDS_18_Tfpedidototal_to",SqlDbType.Decimal,12,2} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00133 ;
          prmH00133 = new Object[] {
          new Object[] {"@lV113PedidoWWDS_1_Pessoanome",SqlDbType.VarChar,60,0} ,
          new Object[] {"@AV114PedidoWWDS_2_Pedidodt",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV115PedidoWWDS_3_Pedidodt_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV116PedidoWWDS_4_Pedidodtentrega",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV117PedidoWWDS_5_Pedidodtentrega_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV118PedidoWWDS_6_Pedidostatus",SqlDbType.VarChar,3,0} ,
          new Object[] {"@AV119PedidoWWDS_7_Tfpedidoid",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV120PedidoWWDS_8_Tfpedidoid_to",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV121PedidoWWDS_9_Tfpessoanome",SqlDbType.VarChar,60,0} ,
          new Object[] {"@AV122PedidoWWDS_10_Tfpessoanome_sel",SqlDbType.VarChar,60,0} ,
          new Object[] {"@AV123PedidoWWDS_11_Tfpedidodt",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV124PedidoWWDS_12_Tfpedidodt_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV126PedidoWWDS_14_Tfpedidodtentrega",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV127PedidoWWDS_15_Tfpedidodtentrega_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV129PedidoWWDS_17_Tfpedidototal",SqlDbType.Decimal,12,2} ,
          new Object[] {"@AV130PedidoWWDS_18_Tfpedidototal_to",SqlDbType.Decimal,12,2}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00132", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00132,11, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("H00133", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00133,1, GxCacheFrequency.OFF ,true,false )
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
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((bool[]) buf[2])[0] = rslt.getBool(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       short sIdx ;
       switch ( cursor )
       {
             case 0 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[20]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[21]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[22]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[23]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[24]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[25]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[26]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[27]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[28]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[29]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[30]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[31]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[32]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[33]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[34]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[35]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[36]);
                }
                if ( (short)parms[18] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[37]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[17]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[18]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[19]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[20]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[22]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[23]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[24]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[25]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[26]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[27]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[28]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[29]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[30]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[31]);
                }
                return;
       }
    }

 }

}
