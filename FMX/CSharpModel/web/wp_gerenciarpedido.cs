/*
               File: WP_GerenciarPedido
        Description:  Pedido
             Author: GeneXus C# Generator version 16_0_2-131213
       Generated on: 7/12/2019 10:54:6.44
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
   public class wp_gerenciarpedido : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public wp_gerenciarpedido( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public wp_gerenciarpedido( IGxContext context )
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
         cmbavDynamicfiltersselector1 = new GXCombobox();
         cmbavDynamicfiltersoperator1 = new GXCombobox();
         cmbavDynamicfiltersselector2 = new GXCombobox();
         cmbavDynamicfiltersoperator2 = new GXCombobox();
         cmbavDynamicfiltersselector3 = new GXCombobox();
         cmbavDynamicfiltersoperator3 = new GXCombobox();
         cmbPedidoStatus = new GXCombobox();
         chkPedidoRetirada = new GXCheckbox();
         chkavDynamicfiltersenabled2 = new GXCheckbox();
         chkavDynamicfiltersenabled3 = new GXCheckbox();
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
               nRC_GXsfl_134 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_134_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_134_idx = GetNextPar( );
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
               AV16DynamicFiltersSelector1 = GetNextPar( );
               AV17DynamicFiltersOperator1 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV18PedidoDt1 = context.localUtil.ParseDateParm( GetNextPar( ));
               AV19PedidoDt_To1 = context.localUtil.ParseDateParm( GetNextPar( ));
               AV21DynamicFiltersSelector2 = GetNextPar( );
               AV22DynamicFiltersOperator2 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV23PedidoDt2 = context.localUtil.ParseDateParm( GetNextPar( ));
               AV24PedidoDt_To2 = context.localUtil.ParseDateParm( GetNextPar( ));
               AV26DynamicFiltersSelector3 = GetNextPar( );
               AV27DynamicFiltersOperator3 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV28PedidoDt3 = context.localUtil.ParseDateParm( GetNextPar( ));
               AV29PedidoDt_To3 = context.localUtil.ParseDateParm( GetNextPar( ));
               AV20DynamicFiltersEnabled2 = StringUtil.StrToBool( GetNextPar( ));
               AV25DynamicFiltersEnabled3 = StringUtil.StrToBool( GetNextPar( ));
               AV13OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV14OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV59TFPedidoId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV60TFPedidoId_To = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV63TFPessoaId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV64TFPessoaId_To = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV67TFPessoaNome = GetNextPar( );
               AV68TFPessoaNome_Sel = GetNextPar( );
               AV71TFPedidoDt = context.localUtil.ParseDateParm( GetNextPar( ));
               AV72TFPedidoDt_To = context.localUtil.ParseDateParm( GetNextPar( ));
               AV81TFPedidoDtEntrega = context.localUtil.ParseDateParm( GetNextPar( ));
               AV82TFPedidoDtEntrega_To = context.localUtil.ParseDateParm( GetNextPar( ));
               AV87TFPedidoRetirada_Sel = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV52ManageFiltersExecutionStep = (short)(NumberUtil.Val( GetNextPar( ), "."));
               ajax_req_read_hidden_sdt(GetNextPar( ), AV44ColumnsSelector);
               AV61ddo_PedidoIdTitleControlIdToReplace = GetNextPar( );
               AV65ddo_PessoaIdTitleControlIdToReplace = GetNextPar( );
               AV69ddo_PessoaNomeTitleControlIdToReplace = GetNextPar( );
               AV75ddo_PedidoDtTitleControlIdToReplace = GetNextPar( );
               AV79ddo_PedidoStatusTitleControlIdToReplace = GetNextPar( );
               AV85ddo_PedidoDtEntregaTitleControlIdToReplace = GetNextPar( );
               AV88ddo_PedidoRetiradaTitleControlIdToReplace = GetNextPar( );
               AV92ddo_PedidoTotalTitleControlIdToReplace = GetNextPar( );
               ajax_req_read_hidden_sdt(GetNextPar( ), AV78TFPedidoStatus_Sels);
               AV90TFPedidoTotal = NumberUtil.Val( GetNextPar( ), ".");
               AV91TFPedidoTotal_To = NumberUtil.Val( GetNextPar( ), ".");
               AV129Pgmname = GetNextPar( );
               ajax_req_read_hidden_sdt(GetNextPar( ), AV10GridState);
               AV31DynamicFiltersIgnoreFirst = StringUtil.StrToBool( GetNextPar( ));
               AV30DynamicFiltersRemoving = StringUtil.StrToBool( GetNextPar( ));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV16DynamicFiltersSelector1, AV17DynamicFiltersOperator1, AV18PedidoDt1, AV19PedidoDt_To1, AV21DynamicFiltersSelector2, AV22DynamicFiltersOperator2, AV23PedidoDt2, AV24PedidoDt_To2, AV26DynamicFiltersSelector3, AV27DynamicFiltersOperator3, AV28PedidoDt3, AV29PedidoDt_To3, AV20DynamicFiltersEnabled2, AV25DynamicFiltersEnabled3, AV13OrderedBy, AV14OrderedDsc, AV59TFPedidoId, AV60TFPedidoId_To, AV63TFPessoaId, AV64TFPessoaId_To, AV67TFPessoaNome, AV68TFPessoaNome_Sel, AV71TFPedidoDt, AV72TFPedidoDt_To, AV81TFPedidoDtEntrega, AV82TFPedidoDtEntrega_To, AV87TFPedidoRetirada_Sel, AV52ManageFiltersExecutionStep, AV44ColumnsSelector, AV61ddo_PedidoIdTitleControlIdToReplace, AV65ddo_PessoaIdTitleControlIdToReplace, AV69ddo_PessoaNomeTitleControlIdToReplace, AV75ddo_PedidoDtTitleControlIdToReplace, AV79ddo_PedidoStatusTitleControlIdToReplace, AV85ddo_PedidoDtEntregaTitleControlIdToReplace, AV88ddo_PedidoRetiradaTitleControlIdToReplace, AV92ddo_PedidoTotalTitleControlIdToReplace, AV78TFPedidoStatus_Sels, AV90TFPedidoTotal, AV91TFPedidoTotal_To, AV129Pgmname, AV10GridState, AV31DynamicFiltersIgnoreFirst, AV30DynamicFiltersRemoving) ;
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
         PA182( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START182( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20197121054719", false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("wp_gerenciarpedido.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSSELECTOR1", AV16DynamicFiltersSelector1);
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSOPERATOR1", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17DynamicFiltersOperator1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vPEDIDODT1", context.localUtil.Format(AV18PedidoDt1, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vPEDIDODT_TO1", context.localUtil.Format(AV19PedidoDt_To1, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSSELECTOR2", AV21DynamicFiltersSelector2);
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSOPERATOR2", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22DynamicFiltersOperator2), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vPEDIDODT2", context.localUtil.Format(AV23PedidoDt2, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vPEDIDODT_TO2", context.localUtil.Format(AV24PedidoDt_To2, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSSELECTOR3", AV26DynamicFiltersSelector3);
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSOPERATOR3", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV27DynamicFiltersOperator3), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vPEDIDODT3", context.localUtil.Format(AV28PedidoDt3, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vPEDIDODT_TO3", context.localUtil.Format(AV29PedidoDt_To3, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSENABLED2", StringUtil.BoolToStr( AV20DynamicFiltersEnabled2));
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSENABLED3", StringUtil.BoolToStr( AV25DynamicFiltersEnabled3));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV14OrderedDsc));
         GxWebStd.gx_hidden_field( context, "GXH_vTFPEDIDOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV59TFPedidoId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFPEDIDOID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV60TFPedidoId_To), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFPESSOAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV63TFPessoaId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFPESSOAID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV64TFPessoaId_To), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFPESSOANOME", AV67TFPessoaNome);
         GxWebStd.gx_hidden_field( context, "GXH_vTFPESSOANOME_SEL", AV68TFPessoaNome_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFPEDIDODT", context.localUtil.Format(AV71TFPedidoDt, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vTFPEDIDODT_TO", context.localUtil.Format(AV72TFPedidoDt_To, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vTFPEDIDODTENTREGA", context.localUtil.Format(AV81TFPedidoDtEntrega, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vTFPEDIDODTENTREGA_TO", context.localUtil.Format(AV82TFPedidoDtEntrega_To, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vTFPEDIDORETIRADA_SEL", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV87TFPedidoRetirada_Sel), 1, 0, ",", "")));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_134", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_134), 4, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vMANAGEFILTERSDATA", AV56ManageFiltersData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vMANAGEFILTERSDATA", AV56ManageFiltersData);
         }
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV95GridCurrentPage), 10, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGECOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV96GridPageCount), 10, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV93DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV93DDO_TitleSettingsIcons);
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPESSOAIDTITLEFILTERDATA", AV62PessoaIdTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPESSOAIDTITLEFILTERDATA", AV62PessoaIdTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPESSOANOMETITLEFILTERDATA", AV66PessoaNomeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPESSOANOMETITLEFILTERDATA", AV66PessoaNomeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPEDIDODTTITLEFILTERDATA", AV70PedidoDtTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPEDIDODTTITLEFILTERDATA", AV70PedidoDtTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPEDIDOSTATUSTITLEFILTERDATA", AV76PedidoStatusTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPEDIDOSTATUSTITLEFILTERDATA", AV76PedidoStatusTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPEDIDODTENTREGATITLEFILTERDATA", AV80PedidoDtEntregaTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPEDIDODTENTREGATITLEFILTERDATA", AV80PedidoDtEntregaTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPEDIDORETIRADATITLEFILTERDATA", AV86PedidoRetiradaTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPEDIDORETIRADATITLEFILTERDATA", AV86PedidoRetiradaTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPEDIDOTOTALTITLEFILTERDATA", AV89PedidoTotalTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPEDIDOTOTALTITLEFILTERDATA", AV89PedidoTotalTitleFilterData);
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTFPEDIDOSTATUS_SELS", AV78TFPedidoStatus_Sels);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTFPEDIDOSTATUS_SELS", AV78TFPedidoStatus_Sels);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV129Pgmname));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vGRIDSTATE", AV10GridState);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vGRIDSTATE", AV10GridState);
         }
         GxWebStd.gx_boolean_hidden_field( context, "vDYNAMICFILTERSIGNOREFIRST", AV31DynamicFiltersIgnoreFirst);
         GxWebStd.gx_boolean_hidden_field( context, "vDYNAMICFILTERSREMOVING", AV30DynamicFiltersRemoving);
         GxWebStd.gx_hidden_field( context, "vTODAY", context.localUtil.DToC( Gx_date, 0, "/"));
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
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Caption", StringUtil.RTrim( Ddo_pessoaid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Tooltip", StringUtil.RTrim( Ddo_pessoaid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Cls", StringUtil.RTrim( Ddo_pessoaid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Filteredtext_set", StringUtil.RTrim( Ddo_pessoaid_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Filteredtextto_set", StringUtil.RTrim( Ddo_pessoaid_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Dropdownoptionstype", StringUtil.RTrim( Ddo_pessoaid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_pessoaid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Includesortasc", StringUtil.BoolToStr( Ddo_pessoaid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Includesortdsc", StringUtil.BoolToStr( Ddo_pessoaid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Sortedstatus", StringUtil.RTrim( Ddo_pessoaid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Includefilter", StringUtil.BoolToStr( Ddo_pessoaid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Filtertype", StringUtil.RTrim( Ddo_pessoaid_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Filterisrange", StringUtil.BoolToStr( Ddo_pessoaid_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Includedatalist", StringUtil.BoolToStr( Ddo_pessoaid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Sortasc", StringUtil.RTrim( Ddo_pessoaid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Sortdsc", StringUtil.RTrim( Ddo_pessoaid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Cleanfilter", StringUtil.RTrim( Ddo_pessoaid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Rangefilterfrom", StringUtil.RTrim( Ddo_pessoaid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Rangefilterto", StringUtil.RTrim( Ddo_pessoaid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Searchbuttontext", StringUtil.RTrim( Ddo_pessoaid_Searchbuttontext));
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
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Includefilter", StringUtil.BoolToStr( Ddo_pedidototal_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Filtertype", StringUtil.RTrim( Ddo_pedidototal_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Filterisrange", StringUtil.BoolToStr( Ddo_pedidototal_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Includedatalist", StringUtil.BoolToStr( Ddo_pedidototal_Includedatalist));
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
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Activeeventkey", StringUtil.RTrim( Ddo_pessoaid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Filteredtext_get", StringUtil.RTrim( Ddo_pessoaid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Filteredtextto_get", StringUtil.RTrim( Ddo_pessoaid_Filteredtextto_get));
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
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Activeeventkey", StringUtil.RTrim( Ddo_pessoaid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Filteredtext_get", StringUtil.RTrim( Ddo_pessoaid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Filteredtextto_get", StringUtil.RTrim( Ddo_pessoaid_Filteredtextto_get));
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
            WE182( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT182( ) ;
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
         return formatLink("wp_gerenciarpedido.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "WP_GerenciarPedido" ;
      }

      public override String GetPgmdesc( )
      {
         return " Pedido" ;
      }

      protected void WB180( )
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
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(134), 3, 0)+","+"null"+");", "Inserir", bttBtninsert_Jsonclick, 5, "Inserir", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_WP_GerenciarPedido.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"";
            ClassString = "hidden-xs";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtneditcolumns_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(134), 3, 0)+","+"null"+");", "Seleciona colunas", bttBtneditcolumns_Jsonclick, 0, "Seleciona colunas", "", StyleString, ClassString, 1, 0, "standard", "'"+""+"'"+",false,"+"'"+""+"'", TempTags, "", context.GetButtonType( ), "HLP_WP_GerenciarPedido.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-xs col-sm-6 CellFloatRight CellWidthAuto", "left", "top", "", "", "div");
            wb_table1_23_182( true) ;
         }
         else
         {
            wb_table1_23_182( false) ;
         }
         return  ;
      }

      protected void wb_table1_23_182e( bool wbgen )
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
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"134\">") ;
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+((edtPessoaId_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               if ( edtPessoaId_Titleformat == 0 )
               {
                  context.SendWebValue( edtPessoaId_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtPessoaId_Title) ;
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
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( AV97Update));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUpdate_Enabled), 5, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( AV98Delete));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDelete_Enabled), 5, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A32PedidoId), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtPedidoId_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPedidoId_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPedidoId_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1PessoaId), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtPessoaId_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPessoaId_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPessoaId_Visible), 5, 0, ".", "")));
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
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A37PedidoTotal, 12, 2, ".", "")));
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
         if ( wbEnd == 134 )
         {
            wbEnd = 0;
            nRC_GXsfl_134 = (short)(nGXsfl_134_idx-1);
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV95GridCurrentPage);
            ucGridpaginationbar.SetProperty("PageCount", AV96GridPageCount);
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
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblJsdynamicfilters_Internalname, lblJsdynamicfilters_Caption, "", "", lblJsdynamicfilters_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "", 0, "", 1, 1, 1, "HLP_WP_GerenciarPedido.htm");
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
            ucDdo_pedidoid.SetProperty("DropDownOptionsTitleSettingsIcons", AV93DDO_TitleSettingsIcons);
            ucDdo_pedidoid.SetProperty("DropDownOptionsData", AV58PedidoIdTitleFilterData);
            ucDdo_pedidoid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_pedidoid_Internalname, "DDO_PEDIDOIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 153,'',false,'" + sGXsfl_134_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_pedidoidtitlecontrolidtoreplace_Internalname, AV61ddo_PedidoIdTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,153);\"", 0, edtavDdo_pedidoidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_WP_GerenciarPedido.htm");
            /* User Defined Control */
            ucDdo_pessoaid.SetProperty("Caption", Ddo_pessoaid_Caption);
            ucDdo_pessoaid.SetProperty("Tooltip", Ddo_pessoaid_Tooltip);
            ucDdo_pessoaid.SetProperty("Cls", Ddo_pessoaid_Cls);
            ucDdo_pessoaid.SetProperty("DropDownOptionsType", Ddo_pessoaid_Dropdownoptionstype);
            ucDdo_pessoaid.SetProperty("IncludeSortASC", Ddo_pessoaid_Includesortasc);
            ucDdo_pessoaid.SetProperty("IncludeSortDSC", Ddo_pessoaid_Includesortdsc);
            ucDdo_pessoaid.SetProperty("IncludeFilter", Ddo_pessoaid_Includefilter);
            ucDdo_pessoaid.SetProperty("FilterType", Ddo_pessoaid_Filtertype);
            ucDdo_pessoaid.SetProperty("FilterIsRange", Ddo_pessoaid_Filterisrange);
            ucDdo_pessoaid.SetProperty("IncludeDataList", Ddo_pessoaid_Includedatalist);
            ucDdo_pessoaid.SetProperty("SortASC", Ddo_pessoaid_Sortasc);
            ucDdo_pessoaid.SetProperty("SortDSC", Ddo_pessoaid_Sortdsc);
            ucDdo_pessoaid.SetProperty("CleanFilter", Ddo_pessoaid_Cleanfilter);
            ucDdo_pessoaid.SetProperty("RangeFilterFrom", Ddo_pessoaid_Rangefilterfrom);
            ucDdo_pessoaid.SetProperty("RangeFilterTo", Ddo_pessoaid_Rangefilterto);
            ucDdo_pessoaid.SetProperty("SearchButtonText", Ddo_pessoaid_Searchbuttontext);
            ucDdo_pessoaid.SetProperty("DropDownOptionsTitleSettingsIcons", AV93DDO_TitleSettingsIcons);
            ucDdo_pessoaid.SetProperty("DropDownOptionsData", AV62PessoaIdTitleFilterData);
            ucDdo_pessoaid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_pessoaid_Internalname, "DDO_PESSOAIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 155,'',false,'" + sGXsfl_134_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_pessoaidtitlecontrolidtoreplace_Internalname, AV65ddo_PessoaIdTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,155);\"", 0, edtavDdo_pessoaidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_WP_GerenciarPedido.htm");
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
            ucDdo_pessoanome.SetProperty("DropDownOptionsTitleSettingsIcons", AV93DDO_TitleSettingsIcons);
            ucDdo_pessoanome.SetProperty("DropDownOptionsData", AV66PessoaNomeTitleFilterData);
            ucDdo_pessoanome.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_pessoanome_Internalname, "DDO_PESSOANOMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 157,'',false,'" + sGXsfl_134_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_pessoanometitlecontrolidtoreplace_Internalname, AV69ddo_PessoaNomeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,157);\"", 0, edtavDdo_pessoanometitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_WP_GerenciarPedido.htm");
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
            ucDdo_pedidodt.SetProperty("DropDownOptionsTitleSettingsIcons", AV93DDO_TitleSettingsIcons);
            ucDdo_pedidodt.SetProperty("DropDownOptionsData", AV70PedidoDtTitleFilterData);
            ucDdo_pedidodt.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_pedidodt_Internalname, "DDO_PEDIDODTContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 159,'',false,'" + sGXsfl_134_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_pedidodttitlecontrolidtoreplace_Internalname, AV75ddo_PedidoDtTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,159);\"", 0, edtavDdo_pedidodttitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_WP_GerenciarPedido.htm");
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
            ucDdo_pedidostatus.SetProperty("DropDownOptionsTitleSettingsIcons", AV93DDO_TitleSettingsIcons);
            ucDdo_pedidostatus.SetProperty("DropDownOptionsData", AV76PedidoStatusTitleFilterData);
            ucDdo_pedidostatus.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_pedidostatus_Internalname, "DDO_PEDIDOSTATUSContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 161,'',false,'" + sGXsfl_134_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_pedidostatustitlecontrolidtoreplace_Internalname, AV79ddo_PedidoStatusTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,161);\"", 0, edtavDdo_pedidostatustitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_WP_GerenciarPedido.htm");
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
            ucDdo_pedidodtentrega.SetProperty("DropDownOptionsTitleSettingsIcons", AV93DDO_TitleSettingsIcons);
            ucDdo_pedidodtentrega.SetProperty("DropDownOptionsData", AV80PedidoDtEntregaTitleFilterData);
            ucDdo_pedidodtentrega.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_pedidodtentrega_Internalname, "DDO_PEDIDODTENTREGAContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 163,'',false,'" + sGXsfl_134_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_pedidodtentregatitlecontrolidtoreplace_Internalname, AV85ddo_PedidoDtEntregaTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,163);\"", 0, edtavDdo_pedidodtentregatitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_WP_GerenciarPedido.htm");
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
            ucDdo_pedidoretirada.SetProperty("DropDownOptionsTitleSettingsIcons", AV93DDO_TitleSettingsIcons);
            ucDdo_pedidoretirada.SetProperty("DropDownOptionsData", AV86PedidoRetiradaTitleFilterData);
            ucDdo_pedidoretirada.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_pedidoretirada_Internalname, "DDO_PEDIDORETIRADAContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 165,'',false,'" + sGXsfl_134_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_pedidoretiradatitlecontrolidtoreplace_Internalname, AV88ddo_PedidoRetiradaTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,165);\"", 0, edtavDdo_pedidoretiradatitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_WP_GerenciarPedido.htm");
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
            ucDdo_pedidototal.SetProperty("CleanFilter", Ddo_pedidototal_Cleanfilter);
            ucDdo_pedidototal.SetProperty("RangeFilterFrom", Ddo_pedidototal_Rangefilterfrom);
            ucDdo_pedidototal.SetProperty("RangeFilterTo", Ddo_pedidototal_Rangefilterto);
            ucDdo_pedidototal.SetProperty("SearchButtonText", Ddo_pedidototal_Searchbuttontext);
            ucDdo_pedidototal.SetProperty("DropDownOptionsTitleSettingsIcons", AV93DDO_TitleSettingsIcons);
            ucDdo_pedidototal.SetProperty("DropDownOptionsData", AV89PedidoTotalTitleFilterData);
            ucDdo_pedidototal.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_pedidototal_Internalname, "DDO_PEDIDOTOTALContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 167,'',false,'" + sGXsfl_134_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_pedidototaltitlecontrolidtoreplace_Internalname, AV92ddo_PedidoTotalTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,167);\"", 0, edtavDdo_pedidototaltitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_WP_GerenciarPedido.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities_f5", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* User Defined Control */
            ucDdo_gridcolumnsselector.SetProperty("Caption", Ddo_gridcolumnsselector_Caption);
            ucDdo_gridcolumnsselector.SetProperty("Tooltip", Ddo_gridcolumnsselector_Tooltip);
            ucDdo_gridcolumnsselector.SetProperty("Cls", Ddo_gridcolumnsselector_Cls);
            ucDdo_gridcolumnsselector.SetProperty("DropDownOptionsType", Ddo_gridcolumnsselector_Dropdownoptionstype);
            ucDdo_gridcolumnsselector.SetProperty("UpdateButtonText", Ddo_gridcolumnsselector_Updatebuttontext);
            ucDdo_gridcolumnsselector.SetProperty("DropDownOptionsTitleSettingsIcons", AV93DDO_TitleSettingsIcons);
            ucDdo_gridcolumnsselector.SetProperty("DropDownOptionsData", AV44ColumnsSelector);
            ucDdo_gridcolumnsselector.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_gridcolumnsselector_Internalname, "DDO_GRIDCOLUMNSSELECTORContainer");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 170,'',false,'" + sGXsfl_134_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavDynamicfiltersenabled2_Internalname, StringUtil.BoolToStr( AV20DynamicFiltersEnabled2), "", "", chkavDynamicfiltersenabled2.Visible, 1, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(170, this, 'true', 'false');gx.evt.onchange(this, event);\" ");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 171,'',false,'" + sGXsfl_134_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavDynamicfiltersenabled3_Internalname, StringUtil.BoolToStr( AV25DynamicFiltersEnabled3), "", "", chkavDynamicfiltersenabled3.Visible, 1, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(171, this, 'true', 'false');gx.evt.onchange(this, event);\" ");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 172,'',false,'" + sGXsfl_134_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,172);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WP_GerenciarPedido.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 173,'',false,'" + sGXsfl_134_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV14OrderedDsc), StringUtil.BoolToStr( AV14OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,173);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_WP_GerenciarPedido.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 174,'',false,'" + sGXsfl_134_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavManagefiltersexecutionstep_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV52ManageFiltersExecutionStep), 1, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV52ManageFiltersExecutionStep), "9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,174);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavManagefiltersexecutionstep_Jsonclick, 0, "Attribute", "", "", "", "", edtavManagefiltersexecutionstep_Visible, 1, 0, "number", "1", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WP_GerenciarPedido.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 175,'',false,'" + sGXsfl_134_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfpedidoid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV59TFPedidoId), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV59TFPedidoId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,175);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfpedidoid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfpedidoid_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WP_GerenciarPedido.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 176,'',false,'" + sGXsfl_134_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfpedidoid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV60TFPedidoId_To), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV60TFPedidoId_To), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,176);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfpedidoid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfpedidoid_to_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WP_GerenciarPedido.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 177,'',false,'" + sGXsfl_134_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfpessoaid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV63TFPessoaId), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV63TFPessoaId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,177);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfpessoaid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfpessoaid_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WP_GerenciarPedido.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 178,'',false,'" + sGXsfl_134_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfpessoaid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV64TFPessoaId_To), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV64TFPessoaId_To), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,178);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfpessoaid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfpessoaid_to_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WP_GerenciarPedido.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 179,'',false,'" + sGXsfl_134_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfpessoanome_Internalname, AV67TFPessoaNome, StringUtil.RTrim( context.localUtil.Format( AV67TFPessoaNome, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,179);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfpessoanome_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfpessoanome_Visible, 1, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WP_GerenciarPedido.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 180,'',false,'" + sGXsfl_134_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfpessoanome_sel_Internalname, AV68TFPessoaNome_Sel, StringUtil.RTrim( context.localUtil.Format( AV68TFPessoaNome_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,180);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfpessoanome_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfpessoanome_sel_Visible, 1, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WP_GerenciarPedido.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 181,'',false,'" + sGXsfl_134_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavTfpedidodt_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTfpedidodt_Internalname, context.localUtil.Format(AV71TFPedidoDt, "99/99/99"), context.localUtil.Format( AV71TFPedidoDt, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,181);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfpedidodt_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfpedidodt_Visible, 1, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WP_GerenciarPedido.htm");
            GxWebStd.gx_bitmap( context, edtavTfpedidodt_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavTfpedidodt_Visible==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_WP_GerenciarPedido.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 182,'',false,'" + sGXsfl_134_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavTfpedidodt_to_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTfpedidodt_to_Internalname, context.localUtil.Format(AV72TFPedidoDt_To, "99/99/99"), context.localUtil.Format( AV72TFPedidoDt_To, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,182);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfpedidodt_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfpedidodt_to_Visible, 1, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WP_GerenciarPedido.htm");
            GxWebStd.gx_bitmap( context, edtavTfpedidodt_to_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavTfpedidodt_to_Visible==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_WP_GerenciarPedido.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divDdo_pedidodtauxdates_Internalname, 1, 0, "px", 0, "px", "Invisible", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 184,'',false,'" + sGXsfl_134_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavDdo_pedidodtauxdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDdo_pedidodtauxdate_Internalname, context.localUtil.Format(AV73DDO_PedidoDtAuxDate, "99/99/99"), context.localUtil.Format( AV73DDO_PedidoDtAuxDate, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,184);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDdo_pedidodtauxdate_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WP_GerenciarPedido.htm");
            GxWebStd.gx_bitmap( context, edtavDdo_pedidodtauxdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_WP_GerenciarPedido.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 185,'',false,'" + sGXsfl_134_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavDdo_pedidodtauxdateto_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDdo_pedidodtauxdateto_Internalname, context.localUtil.Format(AV74DDO_PedidoDtAuxDateTo, "99/99/99"), context.localUtil.Format( AV74DDO_PedidoDtAuxDateTo, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,185);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDdo_pedidodtauxdateto_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WP_GerenciarPedido.htm");
            GxWebStd.gx_bitmap( context, edtavDdo_pedidodtauxdateto_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_WP_GerenciarPedido.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 186,'',false,'" + sGXsfl_134_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavTfpedidodtentrega_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTfpedidodtentrega_Internalname, context.localUtil.Format(AV81TFPedidoDtEntrega, "99/99/99"), context.localUtil.Format( AV81TFPedidoDtEntrega, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,186);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfpedidodtentrega_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfpedidodtentrega_Visible, 1, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WP_GerenciarPedido.htm");
            GxWebStd.gx_bitmap( context, edtavTfpedidodtentrega_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavTfpedidodtentrega_Visible==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_WP_GerenciarPedido.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 187,'',false,'" + sGXsfl_134_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavTfpedidodtentrega_to_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTfpedidodtentrega_to_Internalname, context.localUtil.Format(AV82TFPedidoDtEntrega_To, "99/99/99"), context.localUtil.Format( AV82TFPedidoDtEntrega_To, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,187);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfpedidodtentrega_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfpedidodtentrega_to_Visible, 1, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WP_GerenciarPedido.htm");
            GxWebStd.gx_bitmap( context, edtavTfpedidodtentrega_to_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavTfpedidodtentrega_to_Visible==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_WP_GerenciarPedido.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divDdo_pedidodtentregaauxdates_Internalname, 1, 0, "px", 0, "px", "Invisible", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 189,'',false,'" + sGXsfl_134_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavDdo_pedidodtentregaauxdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDdo_pedidodtentregaauxdate_Internalname, context.localUtil.Format(AV83DDO_PedidoDtEntregaAuxDate, "99/99/99"), context.localUtil.Format( AV83DDO_PedidoDtEntregaAuxDate, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,189);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDdo_pedidodtentregaauxdate_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WP_GerenciarPedido.htm");
            GxWebStd.gx_bitmap( context, edtavDdo_pedidodtentregaauxdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_WP_GerenciarPedido.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 190,'',false,'" + sGXsfl_134_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavDdo_pedidodtentregaauxdateto_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDdo_pedidodtentregaauxdateto_Internalname, context.localUtil.Format(AV84DDO_PedidoDtEntregaAuxDateTo, "99/99/99"), context.localUtil.Format( AV84DDO_PedidoDtEntregaAuxDateTo, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,190);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDdo_pedidodtentregaauxdateto_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WP_GerenciarPedido.htm");
            GxWebStd.gx_bitmap( context, edtavDdo_pedidodtentregaauxdateto_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_WP_GerenciarPedido.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 191,'',false,'" + sGXsfl_134_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfpedidoretirada_sel_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV87TFPedidoRetirada_Sel), 1, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV87TFPedidoRetirada_Sel), "9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,191);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfpedidoretirada_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfpedidoretirada_sel_Visible, 1, 0, "number", "1", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WP_GerenciarPedido.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 192,'',false,'" + sGXsfl_134_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfpedidototal_Internalname, StringUtil.LTrim( StringUtil.NToC( AV90TFPedidoTotal, 12, 2, ",", "")), StringUtil.LTrim( context.localUtil.Format( AV90TFPedidoTotal, "ZZZZZZZZ9.99")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,192);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfpedidototal_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfpedidototal_Visible, 1, 0, "text", "", 12, "chr", 1, "row", 12, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WP_GerenciarPedido.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 193,'',false,'" + sGXsfl_134_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfpedidototal_to_Internalname, StringUtil.LTrim( StringUtil.NToC( AV91TFPedidoTotal_To, 12, 2, ",", "")), StringUtil.LTrim( context.localUtil.Format( AV91TFPedidoTotal_To, "ZZZZZZZZ9.99")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,193);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfpedidototal_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfpedidototal_to_Visible, 1, 0, "text", "", 12, "chr", 1, "row", 12, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WP_GerenciarPedido.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 134 )
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

      protected void START182( )
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
         STRUP180( ) ;
      }

      protected void WS182( )
      {
         START182( ) ;
         EVT182( ) ;
      }

      protected void EVT182( )
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
                              E11182 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E12182 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E13182 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PEDIDOID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E14182 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PESSOAID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E15182 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PESSOANOME.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E16182 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PEDIDODT.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E17182 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PEDIDOSTATUS.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E18182 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PEDIDODTENTREGA.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E19182 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PEDIDORETIRADA.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E20182 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PEDIDOTOTAL.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E21182 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_GRIDCOLUMNSSELECTOR.ONCOLUMNSCHANGED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E22182 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'REMOVEDYNAMICFILTERS1'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'RemoveDynamicFilters1' */
                              E23182 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'REMOVEDYNAMICFILTERS2'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'RemoveDynamicFilters2' */
                              E24182 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'REMOVEDYNAMICFILTERS3'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'RemoveDynamicFilters3' */
                              E25182 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoInsert' */
                              E26182 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'ADDDYNAMICFILTERS1'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'AddDynamicFilters1' */
                              E27182 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VDYNAMICFILTERSSELECTOR1.CLICK") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E28182 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VDYNAMICFILTERSOPERATOR1.CLICK") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E29182 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'ADDDYNAMICFILTERS2'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'AddDynamicFilters2' */
                              E30182 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VDYNAMICFILTERSSELECTOR2.CLICK") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E31182 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VDYNAMICFILTERSOPERATOR2.CLICK") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E32182 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VDYNAMICFILTERSSELECTOR3.CLICK") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E33182 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VDYNAMICFILTERSOPERATOR3.CLICK") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E34182 ();
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_134_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_134_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_134_idx), 4, 0)), 4, "0");
                              SubsflControlProps_1342( ) ;
                              AV97Update = cgiGet( edtavUpdate_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUpdate_Internalname, AV97Update);
                              AV98Delete = cgiGet( edtavDelete_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDelete_Internalname, AV98Delete);
                              A32PedidoId = (short)(context.localUtil.CToN( cgiGet( edtPedidoId_Internalname), ",", "."));
                              A1PessoaId = (short)(context.localUtil.CToN( cgiGet( edtPessoaId_Internalname), ",", "."));
                              A2PessoaNome = cgiGet( edtPessoaNome_Internalname);
                              A33PedidoDt = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtPedidoDt_Internalname), 0));
                              cmbPedidoStatus.Name = cmbPedidoStatus_Internalname;
                              cmbPedidoStatus.CurrentValue = cgiGet( cmbPedidoStatus_Internalname);
                              A34PedidoStatus = cgiGet( cmbPedidoStatus_Internalname);
                              A35PedidoDtEntrega = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtPedidoDtEntrega_Internalname), 0));
                              A36PedidoRetirada = StringUtil.StrToBool( cgiGet( chkPedidoRetirada_Internalname));
                              A37PedidoTotal = context.localUtil.CToN( cgiGet( edtPedidoTotal_Internalname), ",", ".");
                              n37PedidoTotal = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E35182 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E36182 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E37182 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Dynamicfiltersselector1 Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vDYNAMICFILTERSSELECTOR1"), AV16DynamicFiltersSelector1) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Dynamicfiltersoperator1 Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vDYNAMICFILTERSOPERATOR1"), ",", ".") != Convert.ToDecimal( AV17DynamicFiltersOperator1 )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Pedidodt1 Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vPEDIDODT1"), 0) != AV18PedidoDt1 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Pedidodt_to1 Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vPEDIDODT_TO1"), 0) != AV19PedidoDt_To1 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Dynamicfiltersselector2 Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vDYNAMICFILTERSSELECTOR2"), AV21DynamicFiltersSelector2) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Dynamicfiltersoperator2 Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vDYNAMICFILTERSOPERATOR2"), ",", ".") != Convert.ToDecimal( AV22DynamicFiltersOperator2 )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Pedidodt2 Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vPEDIDODT2"), 0) != AV23PedidoDt2 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Pedidodt_to2 Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vPEDIDODT_TO2"), 0) != AV24PedidoDt_To2 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Dynamicfiltersselector3 Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vDYNAMICFILTERSSELECTOR3"), AV26DynamicFiltersSelector3) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Dynamicfiltersoperator3 Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vDYNAMICFILTERSOPERATOR3"), ",", ".") != Convert.ToDecimal( AV27DynamicFiltersOperator3 )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Pedidodt3 Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vPEDIDODT3"), 0) != AV28PedidoDt3 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Pedidodt_to3 Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vPEDIDODT_TO3"), 0) != AV29PedidoDt_To3 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Dynamicfiltersenabled2 Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vDYNAMICFILTERSENABLED2")) != AV20DynamicFiltersEnabled2 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Dynamicfiltersenabled3 Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vDYNAMICFILTERSENABLED3")) != AV25DynamicFiltersEnabled3 )
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
                                       /* Set Refresh If Tfpessoaid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFPESSOAID"), ",", ".") != Convert.ToDecimal( AV63TFPessoaId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfpessoaid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFPESSOAID_TO"), ",", ".") != Convert.ToDecimal( AV64TFPessoaId_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfpessoanome Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFPESSOANOME"), AV67TFPessoaNome) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfpessoanome_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFPESSOANOME_SEL"), AV68TFPessoaNome_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfpedidodt Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vTFPEDIDODT"), 0) != AV71TFPedidoDt )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfpedidodt_to Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vTFPEDIDODT_TO"), 0) != AV72TFPedidoDt_To )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfpedidodtentrega Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vTFPEDIDODTENTREGA"), 0) != AV81TFPedidoDtEntrega )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfpedidodtentrega_to Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vTFPEDIDODTENTREGA_TO"), 0) != AV82TFPedidoDtEntrega_To )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfpedidoretirada_sel Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFPEDIDORETIRADA_SEL"), ",", ".") != Convert.ToDecimal( AV87TFPedidoRetirada_Sel )) )
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

      protected void WE182( )
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

      protected void PA182( )
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
               GX_FocusControl = cmbavDynamicfiltersselector1_Internalname;
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
         SubsflControlProps_1342( ) ;
         while ( nGXsfl_134_idx <= nRC_GXsfl_134 )
         {
            sendrow_1342( ) ;
            nGXsfl_134_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_134_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_134_idx+1));
            sGXsfl_134_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_134_idx), 4, 0)), 4, "0");
            SubsflControlProps_1342( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       String AV16DynamicFiltersSelector1 ,
                                       short AV17DynamicFiltersOperator1 ,
                                       DateTime AV18PedidoDt1 ,
                                       DateTime AV19PedidoDt_To1 ,
                                       String AV21DynamicFiltersSelector2 ,
                                       short AV22DynamicFiltersOperator2 ,
                                       DateTime AV23PedidoDt2 ,
                                       DateTime AV24PedidoDt_To2 ,
                                       String AV26DynamicFiltersSelector3 ,
                                       short AV27DynamicFiltersOperator3 ,
                                       DateTime AV28PedidoDt3 ,
                                       DateTime AV29PedidoDt_To3 ,
                                       bool AV20DynamicFiltersEnabled2 ,
                                       bool AV25DynamicFiltersEnabled3 ,
                                       short AV13OrderedBy ,
                                       bool AV14OrderedDsc ,
                                       short AV59TFPedidoId ,
                                       short AV60TFPedidoId_To ,
                                       short AV63TFPessoaId ,
                                       short AV64TFPessoaId_To ,
                                       String AV67TFPessoaNome ,
                                       String AV68TFPessoaNome_Sel ,
                                       DateTime AV71TFPedidoDt ,
                                       DateTime AV72TFPedidoDt_To ,
                                       DateTime AV81TFPedidoDtEntrega ,
                                       DateTime AV82TFPedidoDtEntrega_To ,
                                       short AV87TFPedidoRetirada_Sel ,
                                       short AV52ManageFiltersExecutionStep ,
                                       GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector AV44ColumnsSelector ,
                                       String AV61ddo_PedidoIdTitleControlIdToReplace ,
                                       String AV65ddo_PessoaIdTitleControlIdToReplace ,
                                       String AV69ddo_PessoaNomeTitleControlIdToReplace ,
                                       String AV75ddo_PedidoDtTitleControlIdToReplace ,
                                       String AV79ddo_PedidoStatusTitleControlIdToReplace ,
                                       String AV85ddo_PedidoDtEntregaTitleControlIdToReplace ,
                                       String AV88ddo_PedidoRetiradaTitleControlIdToReplace ,
                                       String AV92ddo_PedidoTotalTitleControlIdToReplace ,
                                       GxSimpleCollection<String> AV78TFPedidoStatus_Sels ,
                                       decimal AV90TFPedidoTotal ,
                                       decimal AV91TFPedidoTotal_To ,
                                       String AV129Pgmname ,
                                       GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV10GridState ,
                                       bool AV31DynamicFiltersIgnoreFirst ,
                                       bool AV30DynamicFiltersRemoving )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF182( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_PEDIDOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A32PedidoId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "PEDIDOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A32PedidoId), 4, 0, ".", "")));
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
         if ( cmbavDynamicfiltersselector1.ItemCount > 0 )
         {
            AV16DynamicFiltersSelector1 = cmbavDynamicfiltersselector1.getValidValue(AV16DynamicFiltersSelector1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16DynamicFiltersSelector1", AV16DynamicFiltersSelector1);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavDynamicfiltersselector1.CurrentValue = StringUtil.RTrim( AV16DynamicFiltersSelector1);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector1_Internalname, "Values", cmbavDynamicfiltersselector1.ToJavascriptSource(), true);
         }
         if ( cmbavDynamicfiltersoperator1.ItemCount > 0 )
         {
            AV17DynamicFiltersOperator1 = (short)(NumberUtil.Val( cmbavDynamicfiltersoperator1.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV17DynamicFiltersOperator1), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17DynamicFiltersOperator1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17DynamicFiltersOperator1), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV17DynamicFiltersOperator1), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", cmbavDynamicfiltersoperator1.ToJavascriptSource(), true);
         }
         if ( cmbavDynamicfiltersselector2.ItemCount > 0 )
         {
            AV21DynamicFiltersSelector2 = cmbavDynamicfiltersselector2.getValidValue(AV21DynamicFiltersSelector2);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21DynamicFiltersSelector2", AV21DynamicFiltersSelector2);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavDynamicfiltersselector2.CurrentValue = StringUtil.RTrim( AV21DynamicFiltersSelector2);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector2_Internalname, "Values", cmbavDynamicfiltersselector2.ToJavascriptSource(), true);
         }
         if ( cmbavDynamicfiltersoperator2.ItemCount > 0 )
         {
            AV22DynamicFiltersOperator2 = (short)(NumberUtil.Val( cmbavDynamicfiltersoperator2.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV22DynamicFiltersOperator2), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22DynamicFiltersOperator2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22DynamicFiltersOperator2), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV22DynamicFiltersOperator2), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", cmbavDynamicfiltersoperator2.ToJavascriptSource(), true);
         }
         if ( cmbavDynamicfiltersselector3.ItemCount > 0 )
         {
            AV26DynamicFiltersSelector3 = cmbavDynamicfiltersselector3.getValidValue(AV26DynamicFiltersSelector3);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26DynamicFiltersSelector3", AV26DynamicFiltersSelector3);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavDynamicfiltersselector3.CurrentValue = StringUtil.RTrim( AV26DynamicFiltersSelector3);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector3_Internalname, "Values", cmbavDynamicfiltersselector3.ToJavascriptSource(), true);
         }
         if ( cmbavDynamicfiltersoperator3.ItemCount > 0 )
         {
            AV27DynamicFiltersOperator3 = (short)(NumberUtil.Val( cmbavDynamicfiltersoperator3.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV27DynamicFiltersOperator3), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27DynamicFiltersOperator3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV27DynamicFiltersOperator3), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV27DynamicFiltersOperator3), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", cmbavDynamicfiltersoperator3.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF182( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         Gx_date = DateTimeUtil.Today( context);
         AV129Pgmname = "WP_GerenciarPedido";
         context.Gx_err = 0;
         edtavUpdate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Enabled), 5, 0)), !bGXsfl_134_Refreshing);
         edtavDelete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Enabled), 5, 0)), !bGXsfl_134_Refreshing);
      }

      protected void RF182( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 134;
         /* Execute user event: Refresh */
         E36182 ();
         nGXsfl_134_idx = 1;
         sGXsfl_134_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_134_idx), 4, 0)), 4, "0");
         SubsflControlProps_1342( ) ;
         bGXsfl_134_Refreshing = true;
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
            SubsflControlProps_1342( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 A34PedidoStatus ,
                                                 AV123WP_GerenciarPedidoDS_23_Tfpedidostatus_sels ,
                                                 AV101WP_GerenciarPedidoDS_1_Dynamicfiltersselector1 ,
                                                 AV102WP_GerenciarPedidoDS_2_Dynamicfiltersoperator1 ,
                                                 AV103WP_GerenciarPedidoDS_3_Pedidodt1 ,
                                                 AV104WP_GerenciarPedidoDS_4_Pedidodt_to1 ,
                                                 AV105WP_GerenciarPedidoDS_5_Dynamicfiltersenabled2 ,
                                                 AV106WP_GerenciarPedidoDS_6_Dynamicfiltersselector2 ,
                                                 AV107WP_GerenciarPedidoDS_7_Dynamicfiltersoperator2 ,
                                                 AV108WP_GerenciarPedidoDS_8_Pedidodt2 ,
                                                 AV109WP_GerenciarPedidoDS_9_Pedidodt_to2 ,
                                                 AV110WP_GerenciarPedidoDS_10_Dynamicfiltersenabled3 ,
                                                 AV111WP_GerenciarPedidoDS_11_Dynamicfiltersselector3 ,
                                                 AV112WP_GerenciarPedidoDS_12_Dynamicfiltersoperator3 ,
                                                 AV113WP_GerenciarPedidoDS_13_Pedidodt3 ,
                                                 AV114WP_GerenciarPedidoDS_14_Pedidodt_to3 ,
                                                 AV115WP_GerenciarPedidoDS_15_Tfpedidoid ,
                                                 AV116WP_GerenciarPedidoDS_16_Tfpedidoid_to ,
                                                 AV117WP_GerenciarPedidoDS_17_Tfpessoaid ,
                                                 AV118WP_GerenciarPedidoDS_18_Tfpessoaid_to ,
                                                 AV120WP_GerenciarPedidoDS_20_Tfpessoanome_sel ,
                                                 AV119WP_GerenciarPedidoDS_19_Tfpessoanome ,
                                                 AV121WP_GerenciarPedidoDS_21_Tfpedidodt ,
                                                 AV122WP_GerenciarPedidoDS_22_Tfpedidodt_to ,
                                                 AV123WP_GerenciarPedidoDS_23_Tfpedidostatus_sels.Count ,
                                                 AV124WP_GerenciarPedidoDS_24_Tfpedidodtentrega ,
                                                 AV125WP_GerenciarPedidoDS_25_Tfpedidodtentrega_to ,
                                                 AV126WP_GerenciarPedidoDS_26_Tfpedidoretirada_sel ,
                                                 A33PedidoDt ,
                                                 A32PedidoId ,
                                                 A1PessoaId ,
                                                 A2PessoaNome ,
                                                 A35PedidoDtEntrega ,
                                                 A36PedidoRetirada ,
                                                 AV13OrderedBy ,
                                                 AV14OrderedDsc ,
                                                 AV127WP_GerenciarPedidoDS_27_Tfpedidototal ,
                                                 A37PedidoTotal ,
                                                 AV128WP_GerenciarPedidoDS_28_Tfpedidototal_to } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.DATE,
                                                 TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING,
                                                 TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.INT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.SHORT,
                                                 TypeConstants.STRING, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.DECIMAL
                                                 }
            } ) ;
            lV119WP_GerenciarPedidoDS_19_Tfpessoanome = StringUtil.Concat( StringUtil.RTrim( AV119WP_GerenciarPedidoDS_19_Tfpessoanome), "%", "");
            /* Using cursor H00184 */
            pr_default.execute(0, new Object[] {AV127WP_GerenciarPedidoDS_27_Tfpedidototal, AV127WP_GerenciarPedidoDS_27_Tfpedidototal, AV128WP_GerenciarPedidoDS_28_Tfpedidototal_to, AV128WP_GerenciarPedidoDS_28_Tfpedidototal_to, AV103WP_GerenciarPedidoDS_3_Pedidodt1, AV103WP_GerenciarPedidoDS_3_Pedidodt1, AV103WP_GerenciarPedidoDS_3_Pedidodt1, AV103WP_GerenciarPedidoDS_3_Pedidodt1, AV104WP_GerenciarPedidoDS_4_Pedidodt_to1, AV108WP_GerenciarPedidoDS_8_Pedidodt2, AV108WP_GerenciarPedidoDS_8_Pedidodt2, AV108WP_GerenciarPedidoDS_8_Pedidodt2, AV108WP_GerenciarPedidoDS_8_Pedidodt2, AV109WP_GerenciarPedidoDS_9_Pedidodt_to2, AV113WP_GerenciarPedidoDS_13_Pedidodt3, AV113WP_GerenciarPedidoDS_13_Pedidodt3, AV113WP_GerenciarPedidoDS_13_Pedidodt3, AV113WP_GerenciarPedidoDS_13_Pedidodt3, AV114WP_GerenciarPedidoDS_14_Pedidodt_to3, AV115WP_GerenciarPedidoDS_15_Tfpedidoid, AV116WP_GerenciarPedidoDS_16_Tfpedidoid_to, AV117WP_GerenciarPedidoDS_17_Tfpessoaid, AV118WP_GerenciarPedidoDS_18_Tfpessoaid_to, lV119WP_GerenciarPedidoDS_19_Tfpessoanome, AV120WP_GerenciarPedidoDS_20_Tfpessoanome_sel, AV121WP_GerenciarPedidoDS_21_Tfpedidodt, AV122WP_GerenciarPedidoDS_22_Tfpedidodt_to, AV124WP_GerenciarPedidoDS_24_Tfpedidodtentrega, AV125WP_GerenciarPedidoDS_25_Tfpedidodtentrega_to, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_134_idx = 1;
            sGXsfl_134_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_134_idx), 4, 0)), 4, "0");
            SubsflControlProps_1342( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A36PedidoRetirada = H00184_A36PedidoRetirada[0];
               A35PedidoDtEntrega = H00184_A35PedidoDtEntrega[0];
               A34PedidoStatus = H00184_A34PedidoStatus[0];
               A33PedidoDt = H00184_A33PedidoDt[0];
               A2PessoaNome = H00184_A2PessoaNome[0];
               A1PessoaId = H00184_A1PessoaId[0];
               A32PedidoId = H00184_A32PedidoId[0];
               A37PedidoTotal = H00184_A37PedidoTotal[0];
               n37PedidoTotal = H00184_n37PedidoTotal[0];
               A2PessoaNome = H00184_A2PessoaNome[0];
               A37PedidoTotal = H00184_A37PedidoTotal[0];
               n37PedidoTotal = H00184_n37PedidoTotal[0];
               E37182 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 134;
            WB180( ) ;
         }
         bGXsfl_134_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes182( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_PEDIDOID"+"_"+sGXsfl_134_idx, GetSecureSignedToken( sGXsfl_134_idx, context.localUtil.Format( (decimal)(A32PedidoId), "ZZZ9"), context));
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
         AV101WP_GerenciarPedidoDS_1_Dynamicfiltersselector1 = AV16DynamicFiltersSelector1;
         AV102WP_GerenciarPedidoDS_2_Dynamicfiltersoperator1 = AV17DynamicFiltersOperator1;
         AV103WP_GerenciarPedidoDS_3_Pedidodt1 = AV18PedidoDt1;
         AV104WP_GerenciarPedidoDS_4_Pedidodt_to1 = AV19PedidoDt_To1;
         AV105WP_GerenciarPedidoDS_5_Dynamicfiltersenabled2 = AV20DynamicFiltersEnabled2;
         AV106WP_GerenciarPedidoDS_6_Dynamicfiltersselector2 = AV21DynamicFiltersSelector2;
         AV107WP_GerenciarPedidoDS_7_Dynamicfiltersoperator2 = AV22DynamicFiltersOperator2;
         AV108WP_GerenciarPedidoDS_8_Pedidodt2 = AV23PedidoDt2;
         AV109WP_GerenciarPedidoDS_9_Pedidodt_to2 = AV24PedidoDt_To2;
         AV110WP_GerenciarPedidoDS_10_Dynamicfiltersenabled3 = AV25DynamicFiltersEnabled3;
         AV111WP_GerenciarPedidoDS_11_Dynamicfiltersselector3 = AV26DynamicFiltersSelector3;
         AV112WP_GerenciarPedidoDS_12_Dynamicfiltersoperator3 = AV27DynamicFiltersOperator3;
         AV113WP_GerenciarPedidoDS_13_Pedidodt3 = AV28PedidoDt3;
         AV114WP_GerenciarPedidoDS_14_Pedidodt_to3 = AV29PedidoDt_To3;
         AV115WP_GerenciarPedidoDS_15_Tfpedidoid = AV59TFPedidoId;
         AV116WP_GerenciarPedidoDS_16_Tfpedidoid_to = AV60TFPedidoId_To;
         AV117WP_GerenciarPedidoDS_17_Tfpessoaid = AV63TFPessoaId;
         AV118WP_GerenciarPedidoDS_18_Tfpessoaid_to = AV64TFPessoaId_To;
         AV119WP_GerenciarPedidoDS_19_Tfpessoanome = AV67TFPessoaNome;
         AV120WP_GerenciarPedidoDS_20_Tfpessoanome_sel = AV68TFPessoaNome_Sel;
         AV121WP_GerenciarPedidoDS_21_Tfpedidodt = AV71TFPedidoDt;
         AV122WP_GerenciarPedidoDS_22_Tfpedidodt_to = AV72TFPedidoDt_To;
         AV123WP_GerenciarPedidoDS_23_Tfpedidostatus_sels = AV78TFPedidoStatus_Sels;
         AV124WP_GerenciarPedidoDS_24_Tfpedidodtentrega = AV81TFPedidoDtEntrega;
         AV125WP_GerenciarPedidoDS_25_Tfpedidodtentrega_to = AV82TFPedidoDtEntrega_To;
         AV126WP_GerenciarPedidoDS_26_Tfpedidoretirada_sel = AV87TFPedidoRetirada_Sel;
         AV127WP_GerenciarPedidoDS_27_Tfpedidototal = AV90TFPedidoTotal;
         AV128WP_GerenciarPedidoDS_28_Tfpedidototal_to = AV91TFPedidoTotal_To;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              A34PedidoStatus ,
                                              AV123WP_GerenciarPedidoDS_23_Tfpedidostatus_sels ,
                                              AV101WP_GerenciarPedidoDS_1_Dynamicfiltersselector1 ,
                                              AV102WP_GerenciarPedidoDS_2_Dynamicfiltersoperator1 ,
                                              AV103WP_GerenciarPedidoDS_3_Pedidodt1 ,
                                              AV104WP_GerenciarPedidoDS_4_Pedidodt_to1 ,
                                              AV105WP_GerenciarPedidoDS_5_Dynamicfiltersenabled2 ,
                                              AV106WP_GerenciarPedidoDS_6_Dynamicfiltersselector2 ,
                                              AV107WP_GerenciarPedidoDS_7_Dynamicfiltersoperator2 ,
                                              AV108WP_GerenciarPedidoDS_8_Pedidodt2 ,
                                              AV109WP_GerenciarPedidoDS_9_Pedidodt_to2 ,
                                              AV110WP_GerenciarPedidoDS_10_Dynamicfiltersenabled3 ,
                                              AV111WP_GerenciarPedidoDS_11_Dynamicfiltersselector3 ,
                                              AV112WP_GerenciarPedidoDS_12_Dynamicfiltersoperator3 ,
                                              AV113WP_GerenciarPedidoDS_13_Pedidodt3 ,
                                              AV114WP_GerenciarPedidoDS_14_Pedidodt_to3 ,
                                              AV115WP_GerenciarPedidoDS_15_Tfpedidoid ,
                                              AV116WP_GerenciarPedidoDS_16_Tfpedidoid_to ,
                                              AV117WP_GerenciarPedidoDS_17_Tfpessoaid ,
                                              AV118WP_GerenciarPedidoDS_18_Tfpessoaid_to ,
                                              AV120WP_GerenciarPedidoDS_20_Tfpessoanome_sel ,
                                              AV119WP_GerenciarPedidoDS_19_Tfpessoanome ,
                                              AV121WP_GerenciarPedidoDS_21_Tfpedidodt ,
                                              AV122WP_GerenciarPedidoDS_22_Tfpedidodt_to ,
                                              AV123WP_GerenciarPedidoDS_23_Tfpedidostatus_sels.Count ,
                                              AV124WP_GerenciarPedidoDS_24_Tfpedidodtentrega ,
                                              AV125WP_GerenciarPedidoDS_25_Tfpedidodtentrega_to ,
                                              AV126WP_GerenciarPedidoDS_26_Tfpedidoretirada_sel ,
                                              A33PedidoDt ,
                                              A32PedidoId ,
                                              A1PessoaId ,
                                              A2PessoaNome ,
                                              A35PedidoDtEntrega ,
                                              A36PedidoRetirada ,
                                              AV13OrderedBy ,
                                              AV14OrderedDsc ,
                                              AV127WP_GerenciarPedidoDS_27_Tfpedidototal ,
                                              A37PedidoTotal ,
                                              AV128WP_GerenciarPedidoDS_28_Tfpedidototal_to } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.DATE,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.INT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.SHORT,
                                              TypeConstants.STRING, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.DECIMAL
                                              }
         } ) ;
         lV119WP_GerenciarPedidoDS_19_Tfpessoanome = StringUtil.Concat( StringUtil.RTrim( AV119WP_GerenciarPedidoDS_19_Tfpessoanome), "%", "");
         /* Using cursor H00187 */
         pr_default.execute(1, new Object[] {AV127WP_GerenciarPedidoDS_27_Tfpedidototal, AV127WP_GerenciarPedidoDS_27_Tfpedidototal, AV128WP_GerenciarPedidoDS_28_Tfpedidototal_to, AV128WP_GerenciarPedidoDS_28_Tfpedidototal_to, AV103WP_GerenciarPedidoDS_3_Pedidodt1, AV103WP_GerenciarPedidoDS_3_Pedidodt1, AV103WP_GerenciarPedidoDS_3_Pedidodt1, AV103WP_GerenciarPedidoDS_3_Pedidodt1, AV104WP_GerenciarPedidoDS_4_Pedidodt_to1, AV108WP_GerenciarPedidoDS_8_Pedidodt2, AV108WP_GerenciarPedidoDS_8_Pedidodt2, AV108WP_GerenciarPedidoDS_8_Pedidodt2, AV108WP_GerenciarPedidoDS_8_Pedidodt2, AV109WP_GerenciarPedidoDS_9_Pedidodt_to2, AV113WP_GerenciarPedidoDS_13_Pedidodt3, AV113WP_GerenciarPedidoDS_13_Pedidodt3, AV113WP_GerenciarPedidoDS_13_Pedidodt3, AV113WP_GerenciarPedidoDS_13_Pedidodt3, AV114WP_GerenciarPedidoDS_14_Pedidodt_to3, AV115WP_GerenciarPedidoDS_15_Tfpedidoid, AV116WP_GerenciarPedidoDS_16_Tfpedidoid_to, AV117WP_GerenciarPedidoDS_17_Tfpessoaid, AV118WP_GerenciarPedidoDS_18_Tfpessoaid_to, lV119WP_GerenciarPedidoDS_19_Tfpessoanome, AV120WP_GerenciarPedidoDS_20_Tfpessoanome_sel, AV121WP_GerenciarPedidoDS_21_Tfpedidodt, AV122WP_GerenciarPedidoDS_22_Tfpedidodt_to, AV124WP_GerenciarPedidoDS_24_Tfpedidodtentrega, AV125WP_GerenciarPedidoDS_25_Tfpedidodtentrega_to});
         GRID_nRecordCount = H00187_AGRID_nRecordCount[0];
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
         AV101WP_GerenciarPedidoDS_1_Dynamicfiltersselector1 = AV16DynamicFiltersSelector1;
         AV102WP_GerenciarPedidoDS_2_Dynamicfiltersoperator1 = AV17DynamicFiltersOperator1;
         AV103WP_GerenciarPedidoDS_3_Pedidodt1 = AV18PedidoDt1;
         AV104WP_GerenciarPedidoDS_4_Pedidodt_to1 = AV19PedidoDt_To1;
         AV105WP_GerenciarPedidoDS_5_Dynamicfiltersenabled2 = AV20DynamicFiltersEnabled2;
         AV106WP_GerenciarPedidoDS_6_Dynamicfiltersselector2 = AV21DynamicFiltersSelector2;
         AV107WP_GerenciarPedidoDS_7_Dynamicfiltersoperator2 = AV22DynamicFiltersOperator2;
         AV108WP_GerenciarPedidoDS_8_Pedidodt2 = AV23PedidoDt2;
         AV109WP_GerenciarPedidoDS_9_Pedidodt_to2 = AV24PedidoDt_To2;
         AV110WP_GerenciarPedidoDS_10_Dynamicfiltersenabled3 = AV25DynamicFiltersEnabled3;
         AV111WP_GerenciarPedidoDS_11_Dynamicfiltersselector3 = AV26DynamicFiltersSelector3;
         AV112WP_GerenciarPedidoDS_12_Dynamicfiltersoperator3 = AV27DynamicFiltersOperator3;
         AV113WP_GerenciarPedidoDS_13_Pedidodt3 = AV28PedidoDt3;
         AV114WP_GerenciarPedidoDS_14_Pedidodt_to3 = AV29PedidoDt_To3;
         AV115WP_GerenciarPedidoDS_15_Tfpedidoid = AV59TFPedidoId;
         AV116WP_GerenciarPedidoDS_16_Tfpedidoid_to = AV60TFPedidoId_To;
         AV117WP_GerenciarPedidoDS_17_Tfpessoaid = AV63TFPessoaId;
         AV118WP_GerenciarPedidoDS_18_Tfpessoaid_to = AV64TFPessoaId_To;
         AV119WP_GerenciarPedidoDS_19_Tfpessoanome = AV67TFPessoaNome;
         AV120WP_GerenciarPedidoDS_20_Tfpessoanome_sel = AV68TFPessoaNome_Sel;
         AV121WP_GerenciarPedidoDS_21_Tfpedidodt = AV71TFPedidoDt;
         AV122WP_GerenciarPedidoDS_22_Tfpedidodt_to = AV72TFPedidoDt_To;
         AV123WP_GerenciarPedidoDS_23_Tfpedidostatus_sels = AV78TFPedidoStatus_Sels;
         AV124WP_GerenciarPedidoDS_24_Tfpedidodtentrega = AV81TFPedidoDtEntrega;
         AV125WP_GerenciarPedidoDS_25_Tfpedidodtentrega_to = AV82TFPedidoDtEntrega_To;
         AV126WP_GerenciarPedidoDS_26_Tfpedidoretirada_sel = AV87TFPedidoRetirada_Sel;
         AV127WP_GerenciarPedidoDS_27_Tfpedidototal = AV90TFPedidoTotal;
         AV128WP_GerenciarPedidoDS_28_Tfpedidototal_to = AV91TFPedidoTotal_To;
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV16DynamicFiltersSelector1, AV17DynamicFiltersOperator1, AV18PedidoDt1, AV19PedidoDt_To1, AV21DynamicFiltersSelector2, AV22DynamicFiltersOperator2, AV23PedidoDt2, AV24PedidoDt_To2, AV26DynamicFiltersSelector3, AV27DynamicFiltersOperator3, AV28PedidoDt3, AV29PedidoDt_To3, AV20DynamicFiltersEnabled2, AV25DynamicFiltersEnabled3, AV13OrderedBy, AV14OrderedDsc, AV59TFPedidoId, AV60TFPedidoId_To, AV63TFPessoaId, AV64TFPessoaId_To, AV67TFPessoaNome, AV68TFPessoaNome_Sel, AV71TFPedidoDt, AV72TFPedidoDt_To, AV81TFPedidoDtEntrega, AV82TFPedidoDtEntrega_To, AV87TFPedidoRetirada_Sel, AV52ManageFiltersExecutionStep, AV44ColumnsSelector, AV61ddo_PedidoIdTitleControlIdToReplace, AV65ddo_PessoaIdTitleControlIdToReplace, AV69ddo_PessoaNomeTitleControlIdToReplace, AV75ddo_PedidoDtTitleControlIdToReplace, AV79ddo_PedidoStatusTitleControlIdToReplace, AV85ddo_PedidoDtEntregaTitleControlIdToReplace, AV88ddo_PedidoRetiradaTitleControlIdToReplace, AV92ddo_PedidoTotalTitleControlIdToReplace, AV78TFPedidoStatus_Sels, AV90TFPedidoTotal, AV91TFPedidoTotal_To, AV129Pgmname, AV10GridState, AV31DynamicFiltersIgnoreFirst, AV30DynamicFiltersRemoving) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV101WP_GerenciarPedidoDS_1_Dynamicfiltersselector1 = AV16DynamicFiltersSelector1;
         AV102WP_GerenciarPedidoDS_2_Dynamicfiltersoperator1 = AV17DynamicFiltersOperator1;
         AV103WP_GerenciarPedidoDS_3_Pedidodt1 = AV18PedidoDt1;
         AV104WP_GerenciarPedidoDS_4_Pedidodt_to1 = AV19PedidoDt_To1;
         AV105WP_GerenciarPedidoDS_5_Dynamicfiltersenabled2 = AV20DynamicFiltersEnabled2;
         AV106WP_GerenciarPedidoDS_6_Dynamicfiltersselector2 = AV21DynamicFiltersSelector2;
         AV107WP_GerenciarPedidoDS_7_Dynamicfiltersoperator2 = AV22DynamicFiltersOperator2;
         AV108WP_GerenciarPedidoDS_8_Pedidodt2 = AV23PedidoDt2;
         AV109WP_GerenciarPedidoDS_9_Pedidodt_to2 = AV24PedidoDt_To2;
         AV110WP_GerenciarPedidoDS_10_Dynamicfiltersenabled3 = AV25DynamicFiltersEnabled3;
         AV111WP_GerenciarPedidoDS_11_Dynamicfiltersselector3 = AV26DynamicFiltersSelector3;
         AV112WP_GerenciarPedidoDS_12_Dynamicfiltersoperator3 = AV27DynamicFiltersOperator3;
         AV113WP_GerenciarPedidoDS_13_Pedidodt3 = AV28PedidoDt3;
         AV114WP_GerenciarPedidoDS_14_Pedidodt_to3 = AV29PedidoDt_To3;
         AV115WP_GerenciarPedidoDS_15_Tfpedidoid = AV59TFPedidoId;
         AV116WP_GerenciarPedidoDS_16_Tfpedidoid_to = AV60TFPedidoId_To;
         AV117WP_GerenciarPedidoDS_17_Tfpessoaid = AV63TFPessoaId;
         AV118WP_GerenciarPedidoDS_18_Tfpessoaid_to = AV64TFPessoaId_To;
         AV119WP_GerenciarPedidoDS_19_Tfpessoanome = AV67TFPessoaNome;
         AV120WP_GerenciarPedidoDS_20_Tfpessoanome_sel = AV68TFPessoaNome_Sel;
         AV121WP_GerenciarPedidoDS_21_Tfpedidodt = AV71TFPedidoDt;
         AV122WP_GerenciarPedidoDS_22_Tfpedidodt_to = AV72TFPedidoDt_To;
         AV123WP_GerenciarPedidoDS_23_Tfpedidostatus_sels = AV78TFPedidoStatus_Sels;
         AV124WP_GerenciarPedidoDS_24_Tfpedidodtentrega = AV81TFPedidoDtEntrega;
         AV125WP_GerenciarPedidoDS_25_Tfpedidodtentrega_to = AV82TFPedidoDtEntrega_To;
         AV126WP_GerenciarPedidoDS_26_Tfpedidoretirada_sel = AV87TFPedidoRetirada_Sel;
         AV127WP_GerenciarPedidoDS_27_Tfpedidototal = AV90TFPedidoTotal;
         AV128WP_GerenciarPedidoDS_28_Tfpedidototal_to = AV91TFPedidoTotal_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV16DynamicFiltersSelector1, AV17DynamicFiltersOperator1, AV18PedidoDt1, AV19PedidoDt_To1, AV21DynamicFiltersSelector2, AV22DynamicFiltersOperator2, AV23PedidoDt2, AV24PedidoDt_To2, AV26DynamicFiltersSelector3, AV27DynamicFiltersOperator3, AV28PedidoDt3, AV29PedidoDt_To3, AV20DynamicFiltersEnabled2, AV25DynamicFiltersEnabled3, AV13OrderedBy, AV14OrderedDsc, AV59TFPedidoId, AV60TFPedidoId_To, AV63TFPessoaId, AV64TFPessoaId_To, AV67TFPessoaNome, AV68TFPessoaNome_Sel, AV71TFPedidoDt, AV72TFPedidoDt_To, AV81TFPedidoDtEntrega, AV82TFPedidoDtEntrega_To, AV87TFPedidoRetirada_Sel, AV52ManageFiltersExecutionStep, AV44ColumnsSelector, AV61ddo_PedidoIdTitleControlIdToReplace, AV65ddo_PessoaIdTitleControlIdToReplace, AV69ddo_PessoaNomeTitleControlIdToReplace, AV75ddo_PedidoDtTitleControlIdToReplace, AV79ddo_PedidoStatusTitleControlIdToReplace, AV85ddo_PedidoDtEntregaTitleControlIdToReplace, AV88ddo_PedidoRetiradaTitleControlIdToReplace, AV92ddo_PedidoTotalTitleControlIdToReplace, AV78TFPedidoStatus_Sels, AV90TFPedidoTotal, AV91TFPedidoTotal_To, AV129Pgmname, AV10GridState, AV31DynamicFiltersIgnoreFirst, AV30DynamicFiltersRemoving) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV101WP_GerenciarPedidoDS_1_Dynamicfiltersselector1 = AV16DynamicFiltersSelector1;
         AV102WP_GerenciarPedidoDS_2_Dynamicfiltersoperator1 = AV17DynamicFiltersOperator1;
         AV103WP_GerenciarPedidoDS_3_Pedidodt1 = AV18PedidoDt1;
         AV104WP_GerenciarPedidoDS_4_Pedidodt_to1 = AV19PedidoDt_To1;
         AV105WP_GerenciarPedidoDS_5_Dynamicfiltersenabled2 = AV20DynamicFiltersEnabled2;
         AV106WP_GerenciarPedidoDS_6_Dynamicfiltersselector2 = AV21DynamicFiltersSelector2;
         AV107WP_GerenciarPedidoDS_7_Dynamicfiltersoperator2 = AV22DynamicFiltersOperator2;
         AV108WP_GerenciarPedidoDS_8_Pedidodt2 = AV23PedidoDt2;
         AV109WP_GerenciarPedidoDS_9_Pedidodt_to2 = AV24PedidoDt_To2;
         AV110WP_GerenciarPedidoDS_10_Dynamicfiltersenabled3 = AV25DynamicFiltersEnabled3;
         AV111WP_GerenciarPedidoDS_11_Dynamicfiltersselector3 = AV26DynamicFiltersSelector3;
         AV112WP_GerenciarPedidoDS_12_Dynamicfiltersoperator3 = AV27DynamicFiltersOperator3;
         AV113WP_GerenciarPedidoDS_13_Pedidodt3 = AV28PedidoDt3;
         AV114WP_GerenciarPedidoDS_14_Pedidodt_to3 = AV29PedidoDt_To3;
         AV115WP_GerenciarPedidoDS_15_Tfpedidoid = AV59TFPedidoId;
         AV116WP_GerenciarPedidoDS_16_Tfpedidoid_to = AV60TFPedidoId_To;
         AV117WP_GerenciarPedidoDS_17_Tfpessoaid = AV63TFPessoaId;
         AV118WP_GerenciarPedidoDS_18_Tfpessoaid_to = AV64TFPessoaId_To;
         AV119WP_GerenciarPedidoDS_19_Tfpessoanome = AV67TFPessoaNome;
         AV120WP_GerenciarPedidoDS_20_Tfpessoanome_sel = AV68TFPessoaNome_Sel;
         AV121WP_GerenciarPedidoDS_21_Tfpedidodt = AV71TFPedidoDt;
         AV122WP_GerenciarPedidoDS_22_Tfpedidodt_to = AV72TFPedidoDt_To;
         AV123WP_GerenciarPedidoDS_23_Tfpedidostatus_sels = AV78TFPedidoStatus_Sels;
         AV124WP_GerenciarPedidoDS_24_Tfpedidodtentrega = AV81TFPedidoDtEntrega;
         AV125WP_GerenciarPedidoDS_25_Tfpedidodtentrega_to = AV82TFPedidoDtEntrega_To;
         AV126WP_GerenciarPedidoDS_26_Tfpedidoretirada_sel = AV87TFPedidoRetirada_Sel;
         AV127WP_GerenciarPedidoDS_27_Tfpedidototal = AV90TFPedidoTotal;
         AV128WP_GerenciarPedidoDS_28_Tfpedidototal_to = AV91TFPedidoTotal_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV16DynamicFiltersSelector1, AV17DynamicFiltersOperator1, AV18PedidoDt1, AV19PedidoDt_To1, AV21DynamicFiltersSelector2, AV22DynamicFiltersOperator2, AV23PedidoDt2, AV24PedidoDt_To2, AV26DynamicFiltersSelector3, AV27DynamicFiltersOperator3, AV28PedidoDt3, AV29PedidoDt_To3, AV20DynamicFiltersEnabled2, AV25DynamicFiltersEnabled3, AV13OrderedBy, AV14OrderedDsc, AV59TFPedidoId, AV60TFPedidoId_To, AV63TFPessoaId, AV64TFPessoaId_To, AV67TFPessoaNome, AV68TFPessoaNome_Sel, AV71TFPedidoDt, AV72TFPedidoDt_To, AV81TFPedidoDtEntrega, AV82TFPedidoDtEntrega_To, AV87TFPedidoRetirada_Sel, AV52ManageFiltersExecutionStep, AV44ColumnsSelector, AV61ddo_PedidoIdTitleControlIdToReplace, AV65ddo_PessoaIdTitleControlIdToReplace, AV69ddo_PessoaNomeTitleControlIdToReplace, AV75ddo_PedidoDtTitleControlIdToReplace, AV79ddo_PedidoStatusTitleControlIdToReplace, AV85ddo_PedidoDtEntregaTitleControlIdToReplace, AV88ddo_PedidoRetiradaTitleControlIdToReplace, AV92ddo_PedidoTotalTitleControlIdToReplace, AV78TFPedidoStatus_Sels, AV90TFPedidoTotal, AV91TFPedidoTotal_To, AV129Pgmname, AV10GridState, AV31DynamicFiltersIgnoreFirst, AV30DynamicFiltersRemoving) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV101WP_GerenciarPedidoDS_1_Dynamicfiltersselector1 = AV16DynamicFiltersSelector1;
         AV102WP_GerenciarPedidoDS_2_Dynamicfiltersoperator1 = AV17DynamicFiltersOperator1;
         AV103WP_GerenciarPedidoDS_3_Pedidodt1 = AV18PedidoDt1;
         AV104WP_GerenciarPedidoDS_4_Pedidodt_to1 = AV19PedidoDt_To1;
         AV105WP_GerenciarPedidoDS_5_Dynamicfiltersenabled2 = AV20DynamicFiltersEnabled2;
         AV106WP_GerenciarPedidoDS_6_Dynamicfiltersselector2 = AV21DynamicFiltersSelector2;
         AV107WP_GerenciarPedidoDS_7_Dynamicfiltersoperator2 = AV22DynamicFiltersOperator2;
         AV108WP_GerenciarPedidoDS_8_Pedidodt2 = AV23PedidoDt2;
         AV109WP_GerenciarPedidoDS_9_Pedidodt_to2 = AV24PedidoDt_To2;
         AV110WP_GerenciarPedidoDS_10_Dynamicfiltersenabled3 = AV25DynamicFiltersEnabled3;
         AV111WP_GerenciarPedidoDS_11_Dynamicfiltersselector3 = AV26DynamicFiltersSelector3;
         AV112WP_GerenciarPedidoDS_12_Dynamicfiltersoperator3 = AV27DynamicFiltersOperator3;
         AV113WP_GerenciarPedidoDS_13_Pedidodt3 = AV28PedidoDt3;
         AV114WP_GerenciarPedidoDS_14_Pedidodt_to3 = AV29PedidoDt_To3;
         AV115WP_GerenciarPedidoDS_15_Tfpedidoid = AV59TFPedidoId;
         AV116WP_GerenciarPedidoDS_16_Tfpedidoid_to = AV60TFPedidoId_To;
         AV117WP_GerenciarPedidoDS_17_Tfpessoaid = AV63TFPessoaId;
         AV118WP_GerenciarPedidoDS_18_Tfpessoaid_to = AV64TFPessoaId_To;
         AV119WP_GerenciarPedidoDS_19_Tfpessoanome = AV67TFPessoaNome;
         AV120WP_GerenciarPedidoDS_20_Tfpessoanome_sel = AV68TFPessoaNome_Sel;
         AV121WP_GerenciarPedidoDS_21_Tfpedidodt = AV71TFPedidoDt;
         AV122WP_GerenciarPedidoDS_22_Tfpedidodt_to = AV72TFPedidoDt_To;
         AV123WP_GerenciarPedidoDS_23_Tfpedidostatus_sels = AV78TFPedidoStatus_Sels;
         AV124WP_GerenciarPedidoDS_24_Tfpedidodtentrega = AV81TFPedidoDtEntrega;
         AV125WP_GerenciarPedidoDS_25_Tfpedidodtentrega_to = AV82TFPedidoDtEntrega_To;
         AV126WP_GerenciarPedidoDS_26_Tfpedidoretirada_sel = AV87TFPedidoRetirada_Sel;
         AV127WP_GerenciarPedidoDS_27_Tfpedidototal = AV90TFPedidoTotal;
         AV128WP_GerenciarPedidoDS_28_Tfpedidototal_to = AV91TFPedidoTotal_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV16DynamicFiltersSelector1, AV17DynamicFiltersOperator1, AV18PedidoDt1, AV19PedidoDt_To1, AV21DynamicFiltersSelector2, AV22DynamicFiltersOperator2, AV23PedidoDt2, AV24PedidoDt_To2, AV26DynamicFiltersSelector3, AV27DynamicFiltersOperator3, AV28PedidoDt3, AV29PedidoDt_To3, AV20DynamicFiltersEnabled2, AV25DynamicFiltersEnabled3, AV13OrderedBy, AV14OrderedDsc, AV59TFPedidoId, AV60TFPedidoId_To, AV63TFPessoaId, AV64TFPessoaId_To, AV67TFPessoaNome, AV68TFPessoaNome_Sel, AV71TFPedidoDt, AV72TFPedidoDt_To, AV81TFPedidoDtEntrega, AV82TFPedidoDtEntrega_To, AV87TFPedidoRetirada_Sel, AV52ManageFiltersExecutionStep, AV44ColumnsSelector, AV61ddo_PedidoIdTitleControlIdToReplace, AV65ddo_PessoaIdTitleControlIdToReplace, AV69ddo_PessoaNomeTitleControlIdToReplace, AV75ddo_PedidoDtTitleControlIdToReplace, AV79ddo_PedidoStatusTitleControlIdToReplace, AV85ddo_PedidoDtEntregaTitleControlIdToReplace, AV88ddo_PedidoRetiradaTitleControlIdToReplace, AV92ddo_PedidoTotalTitleControlIdToReplace, AV78TFPedidoStatus_Sels, AV90TFPedidoTotal, AV91TFPedidoTotal_To, AV129Pgmname, AV10GridState, AV31DynamicFiltersIgnoreFirst, AV30DynamicFiltersRemoving) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV101WP_GerenciarPedidoDS_1_Dynamicfiltersselector1 = AV16DynamicFiltersSelector1;
         AV102WP_GerenciarPedidoDS_2_Dynamicfiltersoperator1 = AV17DynamicFiltersOperator1;
         AV103WP_GerenciarPedidoDS_3_Pedidodt1 = AV18PedidoDt1;
         AV104WP_GerenciarPedidoDS_4_Pedidodt_to1 = AV19PedidoDt_To1;
         AV105WP_GerenciarPedidoDS_5_Dynamicfiltersenabled2 = AV20DynamicFiltersEnabled2;
         AV106WP_GerenciarPedidoDS_6_Dynamicfiltersselector2 = AV21DynamicFiltersSelector2;
         AV107WP_GerenciarPedidoDS_7_Dynamicfiltersoperator2 = AV22DynamicFiltersOperator2;
         AV108WP_GerenciarPedidoDS_8_Pedidodt2 = AV23PedidoDt2;
         AV109WP_GerenciarPedidoDS_9_Pedidodt_to2 = AV24PedidoDt_To2;
         AV110WP_GerenciarPedidoDS_10_Dynamicfiltersenabled3 = AV25DynamicFiltersEnabled3;
         AV111WP_GerenciarPedidoDS_11_Dynamicfiltersselector3 = AV26DynamicFiltersSelector3;
         AV112WP_GerenciarPedidoDS_12_Dynamicfiltersoperator3 = AV27DynamicFiltersOperator3;
         AV113WP_GerenciarPedidoDS_13_Pedidodt3 = AV28PedidoDt3;
         AV114WP_GerenciarPedidoDS_14_Pedidodt_to3 = AV29PedidoDt_To3;
         AV115WP_GerenciarPedidoDS_15_Tfpedidoid = AV59TFPedidoId;
         AV116WP_GerenciarPedidoDS_16_Tfpedidoid_to = AV60TFPedidoId_To;
         AV117WP_GerenciarPedidoDS_17_Tfpessoaid = AV63TFPessoaId;
         AV118WP_GerenciarPedidoDS_18_Tfpessoaid_to = AV64TFPessoaId_To;
         AV119WP_GerenciarPedidoDS_19_Tfpessoanome = AV67TFPessoaNome;
         AV120WP_GerenciarPedidoDS_20_Tfpessoanome_sel = AV68TFPessoaNome_Sel;
         AV121WP_GerenciarPedidoDS_21_Tfpedidodt = AV71TFPedidoDt;
         AV122WP_GerenciarPedidoDS_22_Tfpedidodt_to = AV72TFPedidoDt_To;
         AV123WP_GerenciarPedidoDS_23_Tfpedidostatus_sels = AV78TFPedidoStatus_Sels;
         AV124WP_GerenciarPedidoDS_24_Tfpedidodtentrega = AV81TFPedidoDtEntrega;
         AV125WP_GerenciarPedidoDS_25_Tfpedidodtentrega_to = AV82TFPedidoDtEntrega_To;
         AV126WP_GerenciarPedidoDS_26_Tfpedidoretirada_sel = AV87TFPedidoRetirada_Sel;
         AV127WP_GerenciarPedidoDS_27_Tfpedidototal = AV90TFPedidoTotal;
         AV128WP_GerenciarPedidoDS_28_Tfpedidototal_to = AV91TFPedidoTotal_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV16DynamicFiltersSelector1, AV17DynamicFiltersOperator1, AV18PedidoDt1, AV19PedidoDt_To1, AV21DynamicFiltersSelector2, AV22DynamicFiltersOperator2, AV23PedidoDt2, AV24PedidoDt_To2, AV26DynamicFiltersSelector3, AV27DynamicFiltersOperator3, AV28PedidoDt3, AV29PedidoDt_To3, AV20DynamicFiltersEnabled2, AV25DynamicFiltersEnabled3, AV13OrderedBy, AV14OrderedDsc, AV59TFPedidoId, AV60TFPedidoId_To, AV63TFPessoaId, AV64TFPessoaId_To, AV67TFPessoaNome, AV68TFPessoaNome_Sel, AV71TFPedidoDt, AV72TFPedidoDt_To, AV81TFPedidoDtEntrega, AV82TFPedidoDtEntrega_To, AV87TFPedidoRetirada_Sel, AV52ManageFiltersExecutionStep, AV44ColumnsSelector, AV61ddo_PedidoIdTitleControlIdToReplace, AV65ddo_PessoaIdTitleControlIdToReplace, AV69ddo_PessoaNomeTitleControlIdToReplace, AV75ddo_PedidoDtTitleControlIdToReplace, AV79ddo_PedidoStatusTitleControlIdToReplace, AV85ddo_PedidoDtEntregaTitleControlIdToReplace, AV88ddo_PedidoRetiradaTitleControlIdToReplace, AV92ddo_PedidoTotalTitleControlIdToReplace, AV78TFPedidoStatus_Sels, AV90TFPedidoTotal, AV91TFPedidoTotal_To, AV129Pgmname, AV10GridState, AV31DynamicFiltersIgnoreFirst, AV30DynamicFiltersRemoving) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP180( )
      {
         /* Before Start, stand alone formulas. */
         Gx_date = DateTimeUtil.Today( context);
         AV129Pgmname = "WP_GerenciarPedido";
         context.Gx_err = 0;
         edtavUpdate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Enabled), 5, 0)), !bGXsfl_134_Refreshing);
         edtavDelete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Enabled), 5, 0)), !bGXsfl_134_Refreshing);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E35182 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vMANAGEFILTERSDATA"), AV56ManageFiltersData);
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV93DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vPEDIDOIDTITLEFILTERDATA"), AV58PedidoIdTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPESSOAIDTITLEFILTERDATA"), AV62PessoaIdTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPESSOANOMETITLEFILTERDATA"), AV66PessoaNomeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPEDIDODTTITLEFILTERDATA"), AV70PedidoDtTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPEDIDOSTATUSTITLEFILTERDATA"), AV76PedidoStatusTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPEDIDODTENTREGATITLEFILTERDATA"), AV80PedidoDtEntregaTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPEDIDORETIRADATITLEFILTERDATA"), AV86PedidoRetiradaTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPEDIDOTOTALTITLEFILTERDATA"), AV89PedidoTotalTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vCOLUMNSSELECTOR"), AV44ColumnsSelector);
            /* Read variables values. */
            cmbavDynamicfiltersselector1.Name = cmbavDynamicfiltersselector1_Internalname;
            cmbavDynamicfiltersselector1.CurrentValue = cgiGet( cmbavDynamicfiltersselector1_Internalname);
            AV16DynamicFiltersSelector1 = cgiGet( cmbavDynamicfiltersselector1_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16DynamicFiltersSelector1", AV16DynamicFiltersSelector1);
            cmbavDynamicfiltersoperator1.Name = cmbavDynamicfiltersoperator1_Internalname;
            cmbavDynamicfiltersoperator1.CurrentValue = cgiGet( cmbavDynamicfiltersoperator1_Internalname);
            AV17DynamicFiltersOperator1 = (short)(NumberUtil.Val( cgiGet( cmbavDynamicfiltersoperator1_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17DynamicFiltersOperator1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17DynamicFiltersOperator1), 4, 0)));
            if ( context.localUtil.VCDate( cgiGet( edtavPedidodt1_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Pedido Dt1"}), 1, "vPEDIDODT1");
               GX_FocusControl = edtavPedidodt1_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV18PedidoDt1 = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18PedidoDt1", context.localUtil.Format(AV18PedidoDt1, "99/99/99"));
            }
            else
            {
               AV18PedidoDt1 = context.localUtil.CToD( cgiGet( edtavPedidodt1_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18PedidoDt1", context.localUtil.Format(AV18PedidoDt1, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavPedidodt_to1_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Pedido Dt_To1"}), 1, "vPEDIDODT_TO1");
               GX_FocusControl = edtavPedidodt_to1_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV19PedidoDt_To1 = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19PedidoDt_To1", context.localUtil.Format(AV19PedidoDt_To1, "99/99/99"));
            }
            else
            {
               AV19PedidoDt_To1 = context.localUtil.CToD( cgiGet( edtavPedidodt_to1_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19PedidoDt_To1", context.localUtil.Format(AV19PedidoDt_To1, "99/99/99"));
            }
            cmbavDynamicfiltersselector2.Name = cmbavDynamicfiltersselector2_Internalname;
            cmbavDynamicfiltersselector2.CurrentValue = cgiGet( cmbavDynamicfiltersselector2_Internalname);
            AV21DynamicFiltersSelector2 = cgiGet( cmbavDynamicfiltersselector2_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21DynamicFiltersSelector2", AV21DynamicFiltersSelector2);
            cmbavDynamicfiltersoperator2.Name = cmbavDynamicfiltersoperator2_Internalname;
            cmbavDynamicfiltersoperator2.CurrentValue = cgiGet( cmbavDynamicfiltersoperator2_Internalname);
            AV22DynamicFiltersOperator2 = (short)(NumberUtil.Val( cgiGet( cmbavDynamicfiltersoperator2_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22DynamicFiltersOperator2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22DynamicFiltersOperator2), 4, 0)));
            if ( context.localUtil.VCDate( cgiGet( edtavPedidodt2_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Pedido Dt2"}), 1, "vPEDIDODT2");
               GX_FocusControl = edtavPedidodt2_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV23PedidoDt2 = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23PedidoDt2", context.localUtil.Format(AV23PedidoDt2, "99/99/99"));
            }
            else
            {
               AV23PedidoDt2 = context.localUtil.CToD( cgiGet( edtavPedidodt2_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23PedidoDt2", context.localUtil.Format(AV23PedidoDt2, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavPedidodt_to2_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Pedido Dt_To2"}), 1, "vPEDIDODT_TO2");
               GX_FocusControl = edtavPedidodt_to2_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV24PedidoDt_To2 = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24PedidoDt_To2", context.localUtil.Format(AV24PedidoDt_To2, "99/99/99"));
            }
            else
            {
               AV24PedidoDt_To2 = context.localUtil.CToD( cgiGet( edtavPedidodt_to2_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24PedidoDt_To2", context.localUtil.Format(AV24PedidoDt_To2, "99/99/99"));
            }
            cmbavDynamicfiltersselector3.Name = cmbavDynamicfiltersselector3_Internalname;
            cmbavDynamicfiltersselector3.CurrentValue = cgiGet( cmbavDynamicfiltersselector3_Internalname);
            AV26DynamicFiltersSelector3 = cgiGet( cmbavDynamicfiltersselector3_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26DynamicFiltersSelector3", AV26DynamicFiltersSelector3);
            cmbavDynamicfiltersoperator3.Name = cmbavDynamicfiltersoperator3_Internalname;
            cmbavDynamicfiltersoperator3.CurrentValue = cgiGet( cmbavDynamicfiltersoperator3_Internalname);
            AV27DynamicFiltersOperator3 = (short)(NumberUtil.Val( cgiGet( cmbavDynamicfiltersoperator3_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27DynamicFiltersOperator3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV27DynamicFiltersOperator3), 4, 0)));
            if ( context.localUtil.VCDate( cgiGet( edtavPedidodt3_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Pedido Dt3"}), 1, "vPEDIDODT3");
               GX_FocusControl = edtavPedidodt3_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV28PedidoDt3 = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28PedidoDt3", context.localUtil.Format(AV28PedidoDt3, "99/99/99"));
            }
            else
            {
               AV28PedidoDt3 = context.localUtil.CToD( cgiGet( edtavPedidodt3_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28PedidoDt3", context.localUtil.Format(AV28PedidoDt3, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavPedidodt_to3_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Pedido Dt_To3"}), 1, "vPEDIDODT_TO3");
               GX_FocusControl = edtavPedidodt_to3_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV29PedidoDt_To3 = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29PedidoDt_To3", context.localUtil.Format(AV29PedidoDt_To3, "99/99/99"));
            }
            else
            {
               AV29PedidoDt_To3 = context.localUtil.CToD( cgiGet( edtavPedidodt_to3_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29PedidoDt_To3", context.localUtil.Format(AV29PedidoDt_To3, "99/99/99"));
            }
            AV61ddo_PedidoIdTitleControlIdToReplace = cgiGet( edtavDdo_pedidoidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV61ddo_PedidoIdTitleControlIdToReplace", AV61ddo_PedidoIdTitleControlIdToReplace);
            AV65ddo_PessoaIdTitleControlIdToReplace = cgiGet( edtavDdo_pessoaidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV65ddo_PessoaIdTitleControlIdToReplace", AV65ddo_PessoaIdTitleControlIdToReplace);
            AV69ddo_PessoaNomeTitleControlIdToReplace = cgiGet( edtavDdo_pessoanometitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV69ddo_PessoaNomeTitleControlIdToReplace", AV69ddo_PessoaNomeTitleControlIdToReplace);
            AV75ddo_PedidoDtTitleControlIdToReplace = cgiGet( edtavDdo_pedidodttitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV75ddo_PedidoDtTitleControlIdToReplace", AV75ddo_PedidoDtTitleControlIdToReplace);
            AV79ddo_PedidoStatusTitleControlIdToReplace = cgiGet( edtavDdo_pedidostatustitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV79ddo_PedidoStatusTitleControlIdToReplace", AV79ddo_PedidoStatusTitleControlIdToReplace);
            AV85ddo_PedidoDtEntregaTitleControlIdToReplace = cgiGet( edtavDdo_pedidodtentregatitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV85ddo_PedidoDtEntregaTitleControlIdToReplace", AV85ddo_PedidoDtEntregaTitleControlIdToReplace);
            AV88ddo_PedidoRetiradaTitleControlIdToReplace = cgiGet( edtavDdo_pedidoretiradatitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV88ddo_PedidoRetiradaTitleControlIdToReplace", AV88ddo_PedidoRetiradaTitleControlIdToReplace);
            AV92ddo_PedidoTotalTitleControlIdToReplace = cgiGet( edtavDdo_pedidototaltitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV92ddo_PedidoTotalTitleControlIdToReplace", AV92ddo_PedidoTotalTitleControlIdToReplace);
            AV20DynamicFiltersEnabled2 = StringUtil.StrToBool( cgiGet( chkavDynamicfiltersenabled2_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20DynamicFiltersEnabled2", AV20DynamicFiltersEnabled2);
            AV25DynamicFiltersEnabled3 = StringUtil.StrToBool( cgiGet( chkavDynamicfiltersenabled3_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25DynamicFiltersEnabled3", AV25DynamicFiltersEnabled3);
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
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfpessoaid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfpessoaid_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFPESSOAID");
               GX_FocusControl = edtavTfpessoaid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV63TFPessoaId = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV63TFPessoaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV63TFPessoaId), 4, 0)));
            }
            else
            {
               AV63TFPessoaId = (short)(context.localUtil.CToN( cgiGet( edtavTfpessoaid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV63TFPessoaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV63TFPessoaId), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfpessoaid_to_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfpessoaid_to_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFPESSOAID_TO");
               GX_FocusControl = edtavTfpessoaid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV64TFPessoaId_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV64TFPessoaId_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV64TFPessoaId_To), 4, 0)));
            }
            else
            {
               AV64TFPessoaId_To = (short)(context.localUtil.CToN( cgiGet( edtavTfpessoaid_to_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV64TFPessoaId_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV64TFPessoaId_To), 4, 0)));
            }
            AV67TFPessoaNome = cgiGet( edtavTfpessoanome_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV67TFPessoaNome", AV67TFPessoaNome);
            AV68TFPessoaNome_Sel = cgiGet( edtavTfpessoanome_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV68TFPessoaNome_Sel", AV68TFPessoaNome_Sel);
            if ( context.localUtil.VCDate( cgiGet( edtavTfpedidodt_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"TFPedido Dt"}), 1, "vTFPEDIDODT");
               GX_FocusControl = edtavTfpedidodt_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV71TFPedidoDt = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV71TFPedidoDt", context.localUtil.Format(AV71TFPedidoDt, "99/99/99"));
            }
            else
            {
               AV71TFPedidoDt = context.localUtil.CToD( cgiGet( edtavTfpedidodt_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV71TFPedidoDt", context.localUtil.Format(AV71TFPedidoDt, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavTfpedidodt_to_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"TFPedido Dt_To"}), 1, "vTFPEDIDODT_TO");
               GX_FocusControl = edtavTfpedidodt_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV72TFPedidoDt_To = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV72TFPedidoDt_To", context.localUtil.Format(AV72TFPedidoDt_To, "99/99/99"));
            }
            else
            {
               AV72TFPedidoDt_To = context.localUtil.CToD( cgiGet( edtavTfpedidodt_to_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV72TFPedidoDt_To", context.localUtil.Format(AV72TFPedidoDt_To, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavDdo_pedidodtauxdate_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"DDO_Pedido Dt Aux Date"}), 1, "vDDO_PEDIDODTAUXDATE");
               GX_FocusControl = edtavDdo_pedidodtauxdate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV73DDO_PedidoDtAuxDate = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV73DDO_PedidoDtAuxDate", context.localUtil.Format(AV73DDO_PedidoDtAuxDate, "99/99/99"));
            }
            else
            {
               AV73DDO_PedidoDtAuxDate = context.localUtil.CToD( cgiGet( edtavDdo_pedidodtauxdate_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV73DDO_PedidoDtAuxDate", context.localUtil.Format(AV73DDO_PedidoDtAuxDate, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavDdo_pedidodtauxdateto_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"DDO_Pedido Dt Aux Date To"}), 1, "vDDO_PEDIDODTAUXDATETO");
               GX_FocusControl = edtavDdo_pedidodtauxdateto_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV74DDO_PedidoDtAuxDateTo = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV74DDO_PedidoDtAuxDateTo", context.localUtil.Format(AV74DDO_PedidoDtAuxDateTo, "99/99/99"));
            }
            else
            {
               AV74DDO_PedidoDtAuxDateTo = context.localUtil.CToD( cgiGet( edtavDdo_pedidodtauxdateto_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV74DDO_PedidoDtAuxDateTo", context.localUtil.Format(AV74DDO_PedidoDtAuxDateTo, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavTfpedidodtentrega_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"TFPedido Dt Entrega"}), 1, "vTFPEDIDODTENTREGA");
               GX_FocusControl = edtavTfpedidodtentrega_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV81TFPedidoDtEntrega = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV81TFPedidoDtEntrega", context.localUtil.Format(AV81TFPedidoDtEntrega, "99/99/99"));
            }
            else
            {
               AV81TFPedidoDtEntrega = context.localUtil.CToD( cgiGet( edtavTfpedidodtentrega_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV81TFPedidoDtEntrega", context.localUtil.Format(AV81TFPedidoDtEntrega, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavTfpedidodtentrega_to_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"TFPedido Dt Entrega_To"}), 1, "vTFPEDIDODTENTREGA_TO");
               GX_FocusControl = edtavTfpedidodtentrega_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV82TFPedidoDtEntrega_To = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV82TFPedidoDtEntrega_To", context.localUtil.Format(AV82TFPedidoDtEntrega_To, "99/99/99"));
            }
            else
            {
               AV82TFPedidoDtEntrega_To = context.localUtil.CToD( cgiGet( edtavTfpedidodtentrega_to_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV82TFPedidoDtEntrega_To", context.localUtil.Format(AV82TFPedidoDtEntrega_To, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavDdo_pedidodtentregaauxdate_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"DDO_Pedido Dt Entrega Aux Date"}), 1, "vDDO_PEDIDODTENTREGAAUXDATE");
               GX_FocusControl = edtavDdo_pedidodtentregaauxdate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV83DDO_PedidoDtEntregaAuxDate = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV83DDO_PedidoDtEntregaAuxDate", context.localUtil.Format(AV83DDO_PedidoDtEntregaAuxDate, "99/99/99"));
            }
            else
            {
               AV83DDO_PedidoDtEntregaAuxDate = context.localUtil.CToD( cgiGet( edtavDdo_pedidodtentregaauxdate_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV83DDO_PedidoDtEntregaAuxDate", context.localUtil.Format(AV83DDO_PedidoDtEntregaAuxDate, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavDdo_pedidodtentregaauxdateto_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"DDO_Pedido Dt Entrega Aux Date To"}), 1, "vDDO_PEDIDODTENTREGAAUXDATETO");
               GX_FocusControl = edtavDdo_pedidodtentregaauxdateto_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV84DDO_PedidoDtEntregaAuxDateTo = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV84DDO_PedidoDtEntregaAuxDateTo", context.localUtil.Format(AV84DDO_PedidoDtEntregaAuxDateTo, "99/99/99"));
            }
            else
            {
               AV84DDO_PedidoDtEntregaAuxDateTo = context.localUtil.CToD( cgiGet( edtavDdo_pedidodtentregaauxdateto_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV84DDO_PedidoDtEntregaAuxDateTo", context.localUtil.Format(AV84DDO_PedidoDtEntregaAuxDateTo, "99/99/99"));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfpedidoretirada_sel_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfpedidoretirada_sel_Internalname), ",", ".") > Convert.ToDecimal( 9 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFPEDIDORETIRADA_SEL");
               GX_FocusControl = edtavTfpedidoretirada_sel_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV87TFPedidoRetirada_Sel = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV87TFPedidoRetirada_Sel", StringUtil.Str( (decimal)(AV87TFPedidoRetirada_Sel), 1, 0));
            }
            else
            {
               AV87TFPedidoRetirada_Sel = (short)(context.localUtil.CToN( cgiGet( edtavTfpedidoretirada_sel_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV87TFPedidoRetirada_Sel", StringUtil.Str( (decimal)(AV87TFPedidoRetirada_Sel), 1, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfpedidototal_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfpedidototal_Internalname), ",", ".") > 999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFPEDIDOTOTAL");
               GX_FocusControl = edtavTfpedidototal_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV90TFPedidoTotal = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV90TFPedidoTotal", StringUtil.LTrim( StringUtil.Str( AV90TFPedidoTotal, 12, 2)));
            }
            else
            {
               AV90TFPedidoTotal = context.localUtil.CToN( cgiGet( edtavTfpedidototal_Internalname), ",", ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV90TFPedidoTotal", StringUtil.LTrim( StringUtil.Str( AV90TFPedidoTotal, 12, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfpedidototal_to_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfpedidototal_to_Internalname), ",", ".") > 999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFPEDIDOTOTAL_TO");
               GX_FocusControl = edtavTfpedidototal_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV91TFPedidoTotal_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV91TFPedidoTotal_To", StringUtil.LTrim( StringUtil.Str( AV91TFPedidoTotal_To, 12, 2)));
            }
            else
            {
               AV91TFPedidoTotal_To = context.localUtil.CToN( cgiGet( edtavTfpedidototal_to_Internalname), ",", ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV91TFPedidoTotal_To", StringUtil.LTrim( StringUtil.Str( AV91TFPedidoTotal_To, 12, 2)));
            }
            /* Read saved values. */
            nRC_GXsfl_134 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_134"), ",", "."));
            AV95GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ",", "."));
            AV96GridPageCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGECOUNT"), ",", "."));
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
            Ddo_pessoaid_Caption = cgiGet( "DDO_PESSOAID_Caption");
            Ddo_pessoaid_Tooltip = cgiGet( "DDO_PESSOAID_Tooltip");
            Ddo_pessoaid_Cls = cgiGet( "DDO_PESSOAID_Cls");
            Ddo_pessoaid_Filteredtext_set = cgiGet( "DDO_PESSOAID_Filteredtext_set");
            Ddo_pessoaid_Filteredtextto_set = cgiGet( "DDO_PESSOAID_Filteredtextto_set");
            Ddo_pessoaid_Dropdownoptionstype = cgiGet( "DDO_PESSOAID_Dropdownoptionstype");
            Ddo_pessoaid_Titlecontrolidtoreplace = cgiGet( "DDO_PESSOAID_Titlecontrolidtoreplace");
            Ddo_pessoaid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PESSOAID_Includesortasc"));
            Ddo_pessoaid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PESSOAID_Includesortdsc"));
            Ddo_pessoaid_Sortedstatus = cgiGet( "DDO_PESSOAID_Sortedstatus");
            Ddo_pessoaid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PESSOAID_Includefilter"));
            Ddo_pessoaid_Filtertype = cgiGet( "DDO_PESSOAID_Filtertype");
            Ddo_pessoaid_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_PESSOAID_Filterisrange"));
            Ddo_pessoaid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PESSOAID_Includedatalist"));
            Ddo_pessoaid_Sortasc = cgiGet( "DDO_PESSOAID_Sortasc");
            Ddo_pessoaid_Sortdsc = cgiGet( "DDO_PESSOAID_Sortdsc");
            Ddo_pessoaid_Cleanfilter = cgiGet( "DDO_PESSOAID_Cleanfilter");
            Ddo_pessoaid_Rangefilterfrom = cgiGet( "DDO_PESSOAID_Rangefilterfrom");
            Ddo_pessoaid_Rangefilterto = cgiGet( "DDO_PESSOAID_Rangefilterto");
            Ddo_pessoaid_Searchbuttontext = cgiGet( "DDO_PESSOAID_Searchbuttontext");
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
            Ddo_pedidototal_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PEDIDOTOTAL_Includefilter"));
            Ddo_pedidototal_Filtertype = cgiGet( "DDO_PEDIDOTOTAL_Filtertype");
            Ddo_pedidototal_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_PEDIDOTOTAL_Filterisrange"));
            Ddo_pedidototal_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PEDIDOTOTAL_Includedatalist"));
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
            Ddo_pessoaid_Activeeventkey = cgiGet( "DDO_PESSOAID_Activeeventkey");
            Ddo_pessoaid_Filteredtext_get = cgiGet( "DDO_PESSOAID_Filteredtext_get");
            Ddo_pessoaid_Filteredtextto_get = cgiGet( "DDO_PESSOAID_Filteredtextto_get");
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
            if ( StringUtil.StrCmp(cgiGet( "GXH_vDYNAMICFILTERSSELECTOR1"), AV16DynamicFiltersSelector1) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vDYNAMICFILTERSOPERATOR1"), ",", ".") != Convert.ToDecimal( AV17DynamicFiltersOperator1 )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vPEDIDODT1"), 2) != AV18PedidoDt1 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vPEDIDODT_TO1"), 2) != AV19PedidoDt_To1 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vDYNAMICFILTERSSELECTOR2"), AV21DynamicFiltersSelector2) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vDYNAMICFILTERSOPERATOR2"), ",", ".") != Convert.ToDecimal( AV22DynamicFiltersOperator2 )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vPEDIDODT2"), 2) != AV23PedidoDt2 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vPEDIDODT_TO2"), 2) != AV24PedidoDt_To2 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vDYNAMICFILTERSSELECTOR3"), AV26DynamicFiltersSelector3) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vDYNAMICFILTERSOPERATOR3"), ",", ".") != Convert.ToDecimal( AV27DynamicFiltersOperator3 )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vPEDIDODT3"), 2) != AV28PedidoDt3 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vPEDIDODT_TO3"), 2) != AV29PedidoDt_To3 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vDYNAMICFILTERSENABLED2")) != AV20DynamicFiltersEnabled2 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vDYNAMICFILTERSENABLED3")) != AV25DynamicFiltersEnabled3 )
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
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFPESSOAID"), ",", ".") != Convert.ToDecimal( AV63TFPessoaId )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFPESSOAID_TO"), ",", ".") != Convert.ToDecimal( AV64TFPessoaId_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFPESSOANOME"), AV67TFPessoaNome) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFPESSOANOME_SEL"), AV68TFPessoaNome_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vTFPEDIDODT"), 2) != AV71TFPedidoDt )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vTFPEDIDODT_TO"), 2) != AV72TFPedidoDt_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vTFPEDIDODTENTREGA"), 2) != AV81TFPedidoDtEntrega )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vTFPEDIDODTENTREGA_TO"), 2) != AV82TFPedidoDtEntrega_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFPEDIDORETIRADA_SEL"), ",", ".") != Convert.ToDecimal( AV87TFPedidoRetirada_Sel )) )
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
         E35182 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E35182( )
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
         lblJsdynamicfilters_Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblJsdynamicfilters_Internalname, "Caption", lblJsdynamicfilters_Caption, true);
         chkavDynamicfiltersenabled2.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavDynamicfiltersenabled2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavDynamicfiltersenabled2.Visible), 5, 0)), true);
         chkavDynamicfiltersenabled3.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavDynamicfiltersenabled3_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavDynamicfiltersenabled3.Visible), 5, 0)), true);
         AV16DynamicFiltersSelector1 = "PEDIDODT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16DynamicFiltersSelector1", AV16DynamicFiltersSelector1);
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS1' */
         S122 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV21DynamicFiltersSelector2 = "PEDIDODT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21DynamicFiltersSelector2", AV21DynamicFiltersSelector2);
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS2' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV26DynamicFiltersSelector3 = "PEDIDODT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26DynamicFiltersSelector3", AV26DynamicFiltersSelector3);
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS3' */
         S142 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         imgAdddynamicfilters1_Jsonclick = StringUtil.Format( "WWPDynFilterShow_AL('%1', 2, 0)", tblTabledynamicfilters_Internalname, "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgAdddynamicfilters1_Internalname, "Jsonclick", imgAdddynamicfilters1_Jsonclick, true);
         imgRemovedynamicfilters1_Jsonclick = StringUtil.Format( "WWPDynFilterHideLast_AL('%1', 3, 0)", tblTabledynamicfilters_Internalname, "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgRemovedynamicfilters1_Internalname, "Jsonclick", imgRemovedynamicfilters1_Jsonclick, true);
         imgAdddynamicfilters2_Jsonclick = StringUtil.Format( "WWPDynFilterShow_AL('%1', 3, 0)", tblTabledynamicfilters_Internalname, "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgAdddynamicfilters2_Internalname, "Jsonclick", imgAdddynamicfilters2_Jsonclick, true);
         imgRemovedynamicfilters2_Jsonclick = StringUtil.Format( "WWPDynFilterHideLast_AL('%1', 3, 0)", tblTabledynamicfilters_Internalname, "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgRemovedynamicfilters2_Internalname, "Jsonclick", imgRemovedynamicfilters2_Jsonclick, true);
         imgRemovedynamicfilters3_Jsonclick = StringUtil.Format( "WWPDynFilterHideLast_AL('%1', 3, 0)", tblTabledynamicfilters_Internalname, "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgRemovedynamicfilters3_Internalname, "Jsonclick", imgRemovedynamicfilters3_Jsonclick, true);
         edtavTfpedidoid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfpedidoid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfpedidoid_Visible), 5, 0)), true);
         edtavTfpedidoid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfpedidoid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfpedidoid_to_Visible), 5, 0)), true);
         edtavTfpessoaid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfpessoaid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfpessoaid_Visible), 5, 0)), true);
         edtavTfpessoaid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfpessoaid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfpessoaid_to_Visible), 5, 0)), true);
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
         Ddo_pessoaid_Titlecontrolidtoreplace = subGrid_Internalname+"_PessoaId";
         ucDdo_pessoaid.SendProperty(context, "", false, Ddo_pessoaid_Internalname, "TitleControlIdToReplace", Ddo_pessoaid_Titlecontrolidtoreplace);
         AV65ddo_PessoaIdTitleControlIdToReplace = Ddo_pessoaid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV65ddo_PessoaIdTitleControlIdToReplace", AV65ddo_PessoaIdTitleControlIdToReplace);
         edtavDdo_pessoaidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_pessoaidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_pessoaidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_pessoanome_Titlecontrolidtoreplace = subGrid_Internalname+"_PessoaNome";
         ucDdo_pessoanome.SendProperty(context, "", false, Ddo_pessoanome_Internalname, "TitleControlIdToReplace", Ddo_pessoanome_Titlecontrolidtoreplace);
         AV69ddo_PessoaNomeTitleControlIdToReplace = Ddo_pessoanome_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV69ddo_PessoaNomeTitleControlIdToReplace", AV69ddo_PessoaNomeTitleControlIdToReplace);
         edtavDdo_pessoanometitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_pessoanometitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_pessoanometitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_pedidodt_Titlecontrolidtoreplace = subGrid_Internalname+"_PedidoDt";
         ucDdo_pedidodt.SendProperty(context, "", false, Ddo_pedidodt_Internalname, "TitleControlIdToReplace", Ddo_pedidodt_Titlecontrolidtoreplace);
         AV75ddo_PedidoDtTitleControlIdToReplace = Ddo_pedidodt_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV75ddo_PedidoDtTitleControlIdToReplace", AV75ddo_PedidoDtTitleControlIdToReplace);
         edtavDdo_pedidodttitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_pedidodttitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_pedidodttitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_pedidostatus_Titlecontrolidtoreplace = subGrid_Internalname+"_PedidoStatus";
         ucDdo_pedidostatus.SendProperty(context, "", false, Ddo_pedidostatus_Internalname, "TitleControlIdToReplace", Ddo_pedidostatus_Titlecontrolidtoreplace);
         AV79ddo_PedidoStatusTitleControlIdToReplace = Ddo_pedidostatus_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV79ddo_PedidoStatusTitleControlIdToReplace", AV79ddo_PedidoStatusTitleControlIdToReplace);
         edtavDdo_pedidostatustitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_pedidostatustitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_pedidostatustitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_pedidodtentrega_Titlecontrolidtoreplace = subGrid_Internalname+"_PedidoDtEntrega";
         ucDdo_pedidodtentrega.SendProperty(context, "", false, Ddo_pedidodtentrega_Internalname, "TitleControlIdToReplace", Ddo_pedidodtentrega_Titlecontrolidtoreplace);
         AV85ddo_PedidoDtEntregaTitleControlIdToReplace = Ddo_pedidodtentrega_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV85ddo_PedidoDtEntregaTitleControlIdToReplace", AV85ddo_PedidoDtEntregaTitleControlIdToReplace);
         edtavDdo_pedidodtentregatitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_pedidodtentregatitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_pedidodtentregatitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_pedidoretirada_Titlecontrolidtoreplace = subGrid_Internalname+"_PedidoRetirada";
         ucDdo_pedidoretirada.SendProperty(context, "", false, Ddo_pedidoretirada_Internalname, "TitleControlIdToReplace", Ddo_pedidoretirada_Titlecontrolidtoreplace);
         AV88ddo_PedidoRetiradaTitleControlIdToReplace = Ddo_pedidoretirada_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV88ddo_PedidoRetiradaTitleControlIdToReplace", AV88ddo_PedidoRetiradaTitleControlIdToReplace);
         edtavDdo_pedidoretiradatitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_pedidoretiradatitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_pedidoretiradatitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_pedidototal_Titlecontrolidtoreplace = subGrid_Internalname+"_PedidoTotal";
         ucDdo_pedidototal.SendProperty(context, "", false, Ddo_pedidototal_Internalname, "TitleControlIdToReplace", Ddo_pedidototal_Titlecontrolidtoreplace);
         AV92ddo_PedidoTotalTitleControlIdToReplace = Ddo_pedidototal_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV92ddo_PedidoTotalTitleControlIdToReplace", AV92ddo_PedidoTotalTitleControlIdToReplace);
         edtavDdo_pedidototaltitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_pedidototaltitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_pedidototaltitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = " Pedido";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         /* Execute user subroutine: 'PREPARETRANSACTION' */
         S152 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'LOADGRIDSTATE' */
         S162 ();
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
            S172 ();
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV93DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV93DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Ddo_gridcolumnsselector_Titlecontrolidtoreplace = bttBtneditcolumns_Internalname;
         ucDdo_gridcolumnsselector.SendProperty(context, "", false, Ddo_gridcolumnsselector_Internalname, "TitleControlIdToReplace", Ddo_gridcolumnsselector_Titlecontrolidtoreplace);
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E36182( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV58PedidoIdTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV62PessoaIdTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV66PessoaNomeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV70PedidoDtTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV76PedidoStatusTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV80PedidoDtEntregaTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV86PedidoRetiradaTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV89PedidoTotalTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
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
         S182 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         if ( StringUtil.StrCmp(AV51Session.Get("WP_GerenciarPedidoColumnsSelector"), "") != 0 )
         {
            AV32ColumnsSelectorXML = AV51Session.Get("WP_GerenciarPedidoColumnsSelector");
            AV44ColumnsSelector.FromXml(AV32ColumnsSelectorXML, null, "WWPColumnsSelector", "FMX");
         }
         else
         {
            /* Execute user subroutine: 'INITIALIZECOLUMNSSELECTOR' */
            S192 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
         edtPedidoId_Visible = (((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV44ColumnsSelector.gxTpr_Columns.Item(1)).gxTpr_Isvisible ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedidoId_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedidoId_Visible), 5, 0)), !bGXsfl_134_Refreshing);
         edtPessoaId_Visible = (((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV44ColumnsSelector.gxTpr_Columns.Item(2)).gxTpr_Isvisible ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPessoaId_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPessoaId_Visible), 5, 0)), !bGXsfl_134_Refreshing);
         edtPessoaNome_Visible = (((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV44ColumnsSelector.gxTpr_Columns.Item(3)).gxTpr_Isvisible ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPessoaNome_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPessoaNome_Visible), 5, 0)), !bGXsfl_134_Refreshing);
         edtPedidoDt_Visible = (((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV44ColumnsSelector.gxTpr_Columns.Item(4)).gxTpr_Isvisible ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedidoDt_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedidoDt_Visible), 5, 0)), !bGXsfl_134_Refreshing);
         cmbPedidoStatus.Visible = (((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV44ColumnsSelector.gxTpr_Columns.Item(5)).gxTpr_Isvisible ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPedidoStatus_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbPedidoStatus.Visible), 5, 0)), !bGXsfl_134_Refreshing);
         edtPedidoDtEntrega_Visible = (((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV44ColumnsSelector.gxTpr_Columns.Item(6)).gxTpr_Isvisible ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedidoDtEntrega_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedidoDtEntrega_Visible), 5, 0)), !bGXsfl_134_Refreshing);
         chkPedidoRetirada.Visible = (((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV44ColumnsSelector.gxTpr_Columns.Item(7)).gxTpr_Isvisible ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkPedidoRetirada_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(chkPedidoRetirada.Visible), 5, 0)), !bGXsfl_134_Refreshing);
         edtPedidoTotal_Visible = (((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV44ColumnsSelector.gxTpr_Columns.Item(8)).gxTpr_Isvisible ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedidoTotal_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedidoTotal_Visible), 5, 0)), !bGXsfl_134_Refreshing);
         edtPedidoId_Titleformat = 2;
         edtPedidoId_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Número do Pedido", AV61ddo_PedidoIdTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedidoId_Internalname, "Title", edtPedidoId_Title, !bGXsfl_134_Refreshing);
         edtPessoaId_Titleformat = 2;
         edtPessoaId_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Id", AV65ddo_PessoaIdTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPessoaId_Internalname, "Title", edtPessoaId_Title, !bGXsfl_134_Refreshing);
         edtPessoaNome_Titleformat = 2;
         edtPessoaNome_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Nome", AV69ddo_PessoaNomeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPessoaNome_Internalname, "Title", edtPessoaNome_Title, !bGXsfl_134_Refreshing);
         edtPedidoDt_Titleformat = 2;
         edtPedidoDt_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Data do Pedido", AV75ddo_PedidoDtTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedidoDt_Internalname, "Title", edtPedidoDt_Title, !bGXsfl_134_Refreshing);
         cmbPedidoStatus_Titleformat = 2;
         cmbPedidoStatus.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Status", AV79ddo_PedidoStatusTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPedidoStatus_Internalname, "Title", cmbPedidoStatus.Title.Text, !bGXsfl_134_Refreshing);
         edtPedidoDtEntrega_Titleformat = 2;
         edtPedidoDtEntrega_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Data de Entrega", AV85ddo_PedidoDtEntregaTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedidoDtEntrega_Internalname, "Title", edtPedidoDtEntrega_Title, !bGXsfl_134_Refreshing);
         chkPedidoRetirada_Titleformat = 2;
         chkPedidoRetirada.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Retirar no Local?", AV88ddo_PedidoRetiradaTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkPedidoRetirada_Internalname, "Title", chkPedidoRetirada.Title.Text, !bGXsfl_134_Refreshing);
         edtPedidoTotal_Titleformat = 2;
         edtPedidoTotal_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Total", AV92ddo_PedidoTotalTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedidoTotal_Internalname, "Title", edtPedidoTotal_Title, !bGXsfl_134_Refreshing);
         AV95GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV95GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV95GridCurrentPage), 10, 0)));
         AV96GridPageCount = subGrid_Pagecount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV96GridPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV96GridPageCount), 10, 0)));
         AV101WP_GerenciarPedidoDS_1_Dynamicfiltersselector1 = AV16DynamicFiltersSelector1;
         AV102WP_GerenciarPedidoDS_2_Dynamicfiltersoperator1 = AV17DynamicFiltersOperator1;
         AV103WP_GerenciarPedidoDS_3_Pedidodt1 = AV18PedidoDt1;
         AV104WP_GerenciarPedidoDS_4_Pedidodt_to1 = AV19PedidoDt_To1;
         AV105WP_GerenciarPedidoDS_5_Dynamicfiltersenabled2 = AV20DynamicFiltersEnabled2;
         AV106WP_GerenciarPedidoDS_6_Dynamicfiltersselector2 = AV21DynamicFiltersSelector2;
         AV107WP_GerenciarPedidoDS_7_Dynamicfiltersoperator2 = AV22DynamicFiltersOperator2;
         AV108WP_GerenciarPedidoDS_8_Pedidodt2 = AV23PedidoDt2;
         AV109WP_GerenciarPedidoDS_9_Pedidodt_to2 = AV24PedidoDt_To2;
         AV110WP_GerenciarPedidoDS_10_Dynamicfiltersenabled3 = AV25DynamicFiltersEnabled3;
         AV111WP_GerenciarPedidoDS_11_Dynamicfiltersselector3 = AV26DynamicFiltersSelector3;
         AV112WP_GerenciarPedidoDS_12_Dynamicfiltersoperator3 = AV27DynamicFiltersOperator3;
         AV113WP_GerenciarPedidoDS_13_Pedidodt3 = AV28PedidoDt3;
         AV114WP_GerenciarPedidoDS_14_Pedidodt_to3 = AV29PedidoDt_To3;
         AV115WP_GerenciarPedidoDS_15_Tfpedidoid = AV59TFPedidoId;
         AV116WP_GerenciarPedidoDS_16_Tfpedidoid_to = AV60TFPedidoId_To;
         AV117WP_GerenciarPedidoDS_17_Tfpessoaid = AV63TFPessoaId;
         AV118WP_GerenciarPedidoDS_18_Tfpessoaid_to = AV64TFPessoaId_To;
         AV119WP_GerenciarPedidoDS_19_Tfpessoanome = AV67TFPessoaNome;
         AV120WP_GerenciarPedidoDS_20_Tfpessoanome_sel = AV68TFPessoaNome_Sel;
         AV121WP_GerenciarPedidoDS_21_Tfpedidodt = AV71TFPedidoDt;
         AV122WP_GerenciarPedidoDS_22_Tfpedidodt_to = AV72TFPedidoDt_To;
         AV123WP_GerenciarPedidoDS_23_Tfpedidostatus_sels = AV78TFPedidoStatus_Sels;
         AV124WP_GerenciarPedidoDS_24_Tfpedidodtentrega = AV81TFPedidoDtEntrega;
         AV125WP_GerenciarPedidoDS_25_Tfpedidodtentrega_to = AV82TFPedidoDtEntrega_To;
         AV126WP_GerenciarPedidoDS_26_Tfpedidoretirada_sel = AV87TFPedidoRetirada_Sel;
         AV127WP_GerenciarPedidoDS_27_Tfpedidototal = AV90TFPedidoTotal;
         AV128WP_GerenciarPedidoDS_28_Tfpedidototal_to = AV91TFPedidoTotal_To;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58PedidoIdTitleFilterData", AV58PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62PessoaIdTitleFilterData", AV62PessoaIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66PessoaNomeTitleFilterData", AV66PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV70PedidoDtTitleFilterData", AV70PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV76PedidoStatusTitleFilterData", AV76PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV80PedidoDtEntregaTitleFilterData", AV80PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86PedidoRetiradaTitleFilterData", AV86PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV89PedidoTotalTitleFilterData", AV89PedidoTotalTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E12182( )
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
            AV94PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV94PageToGo) ;
         }
      }

      protected void E13182( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E14182( )
      {
         /* Ddo_pedidoid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_pedidoid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S202 ();
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
            S202 ();
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
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62PessoaIdTitleFilterData", AV62PessoaIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66PessoaNomeTitleFilterData", AV66PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV70PedidoDtTitleFilterData", AV70PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV76PedidoStatusTitleFilterData", AV76PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV80PedidoDtEntregaTitleFilterData", AV80PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86PedidoRetiradaTitleFilterData", AV86PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV89PedidoTotalTitleFilterData", AV89PedidoTotalTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E15182( )
      {
         /* Ddo_pessoaid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_pessoaid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S202 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_pessoaid_Sortedstatus = "ASC";
            ucDdo_pessoaid.SendProperty(context, "", false, Ddo_pessoaid_Internalname, "SortedStatus", Ddo_pessoaid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pessoaid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S202 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_pessoaid_Sortedstatus = "DSC";
            ucDdo_pessoaid.SendProperty(context, "", false, Ddo_pessoaid_Internalname, "SortedStatus", Ddo_pessoaid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pessoaid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV63TFPessoaId = (short)(NumberUtil.Val( Ddo_pessoaid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV63TFPessoaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV63TFPessoaId), 4, 0)));
            AV64TFPessoaId_To = (short)(NumberUtil.Val( Ddo_pessoaid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV64TFPessoaId_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV64TFPessoaId_To), 4, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58PedidoIdTitleFilterData", AV58PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62PessoaIdTitleFilterData", AV62PessoaIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66PessoaNomeTitleFilterData", AV66PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV70PedidoDtTitleFilterData", AV70PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV76PedidoStatusTitleFilterData", AV76PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV80PedidoDtEntregaTitleFilterData", AV80PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86PedidoRetiradaTitleFilterData", AV86PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV89PedidoTotalTitleFilterData", AV89PedidoTotalTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E16182( )
      {
         /* Ddo_pessoanome_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_pessoanome_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S202 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 4;
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
            S202 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 4;
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
            AV67TFPessoaNome = Ddo_pessoanome_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV67TFPessoaNome", AV67TFPessoaNome);
            AV68TFPessoaNome_Sel = Ddo_pessoanome_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV68TFPessoaNome_Sel", AV68TFPessoaNome_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58PedidoIdTitleFilterData", AV58PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62PessoaIdTitleFilterData", AV62PessoaIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66PessoaNomeTitleFilterData", AV66PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV70PedidoDtTitleFilterData", AV70PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV76PedidoStatusTitleFilterData", AV76PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV80PedidoDtEntregaTitleFilterData", AV80PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86PedidoRetiradaTitleFilterData", AV86PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV89PedidoTotalTitleFilterData", AV89PedidoTotalTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E17182( )
      {
         /* Ddo_pedidodt_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_pedidodt_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S202 ();
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
            S202 ();
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
            AV71TFPedidoDt = context.localUtil.CToD( Ddo_pedidodt_Filteredtext_get, 2);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV71TFPedidoDt", context.localUtil.Format(AV71TFPedidoDt, "99/99/99"));
            AV72TFPedidoDt_To = context.localUtil.CToD( Ddo_pedidodt_Filteredtextto_get, 2);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV72TFPedidoDt_To", context.localUtil.Format(AV72TFPedidoDt_To, "99/99/99"));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58PedidoIdTitleFilterData", AV58PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62PessoaIdTitleFilterData", AV62PessoaIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66PessoaNomeTitleFilterData", AV66PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV70PedidoDtTitleFilterData", AV70PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV76PedidoStatusTitleFilterData", AV76PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV80PedidoDtEntregaTitleFilterData", AV80PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86PedidoRetiradaTitleFilterData", AV86PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV89PedidoTotalTitleFilterData", AV89PedidoTotalTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E18182( )
      {
         /* Ddo_pedidostatus_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_pedidostatus_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S202 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 5;
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
            S202 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 5;
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
            AV77TFPedidoStatus_SelsJson = Ddo_pedidostatus_Selectedvalue_get;
            AV78TFPedidoStatus_Sels.FromJSonString(AV77TFPedidoStatus_SelsJson, null);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78TFPedidoStatus_Sels", AV78TFPedidoStatus_Sels);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58PedidoIdTitleFilterData", AV58PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62PessoaIdTitleFilterData", AV62PessoaIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66PessoaNomeTitleFilterData", AV66PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV70PedidoDtTitleFilterData", AV70PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV76PedidoStatusTitleFilterData", AV76PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV80PedidoDtEntregaTitleFilterData", AV80PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86PedidoRetiradaTitleFilterData", AV86PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV89PedidoTotalTitleFilterData", AV89PedidoTotalTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E19182( )
      {
         /* Ddo_pedidodtentrega_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_pedidodtentrega_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S202 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 6;
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
            S202 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 6;
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
            AV81TFPedidoDtEntrega = context.localUtil.CToD( Ddo_pedidodtentrega_Filteredtext_get, 2);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV81TFPedidoDtEntrega", context.localUtil.Format(AV81TFPedidoDtEntrega, "99/99/99"));
            AV82TFPedidoDtEntrega_To = context.localUtil.CToD( Ddo_pedidodtentrega_Filteredtextto_get, 2);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV82TFPedidoDtEntrega_To", context.localUtil.Format(AV82TFPedidoDtEntrega_To, "99/99/99"));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58PedidoIdTitleFilterData", AV58PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62PessoaIdTitleFilterData", AV62PessoaIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66PessoaNomeTitleFilterData", AV66PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV70PedidoDtTitleFilterData", AV70PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV76PedidoStatusTitleFilterData", AV76PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV80PedidoDtEntregaTitleFilterData", AV80PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86PedidoRetiradaTitleFilterData", AV86PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV89PedidoTotalTitleFilterData", AV89PedidoTotalTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E20182( )
      {
         /* Ddo_pedidoretirada_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_pedidoretirada_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S202 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 7;
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
            S202 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 7;
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
            AV87TFPedidoRetirada_Sel = (short)(NumberUtil.Val( Ddo_pedidoretirada_Selectedvalue_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV87TFPedidoRetirada_Sel", StringUtil.Str( (decimal)(AV87TFPedidoRetirada_Sel), 1, 0));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58PedidoIdTitleFilterData", AV58PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62PessoaIdTitleFilterData", AV62PessoaIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66PessoaNomeTitleFilterData", AV66PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV70PedidoDtTitleFilterData", AV70PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV76PedidoStatusTitleFilterData", AV76PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV80PedidoDtEntregaTitleFilterData", AV80PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86PedidoRetiradaTitleFilterData", AV86PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV89PedidoTotalTitleFilterData", AV89PedidoTotalTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E21182( )
      {
         /* Ddo_pedidototal_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_pedidototal_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV90TFPedidoTotal = NumberUtil.Val( Ddo_pedidototal_Filteredtext_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV90TFPedidoTotal", StringUtil.LTrim( StringUtil.Str( AV90TFPedidoTotal, 12, 2)));
            AV91TFPedidoTotal_To = NumberUtil.Val( Ddo_pedidototal_Filteredtextto_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV91TFPedidoTotal_To", StringUtil.LTrim( StringUtil.Str( AV91TFPedidoTotal_To, 12, 2)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
      }

      private void E37182( )
      {
         /* Grid_Load Routine */
         AV97Update = "<i class=\"fa fa-pen\"></i>";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUpdate_Internalname, AV97Update);
         edtavUpdate_Link = formatLink("pedido.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A32PedidoId);
         AV98Delete = "<i class=\"fa fa-times\"></i>";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDelete_Internalname, AV98Delete);
         edtavDelete_Link = formatLink("pedido.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A32PedidoId);
         edtPedidoDt_Link = formatLink("pedidoview.aspx") + "?" + UrlEncode("" +A32PedidoId) + "," + UrlEncode(StringUtil.RTrim(""));
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 134;
         }
         sendrow_1342( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_134_Refreshing )
         {
            context.DoAjaxLoad(134, GridRow);
         }
         /*  Sending Event outputs  */
      }

      protected void E22182( )
      {
         /* Ddo_gridcolumnsselector_Oncolumnschanged Routine */
         AV32ColumnsSelectorXML = Ddo_gridcolumnsselector_Columnsselectorvalues;
         AV44ColumnsSelector.FromJSonString(AV32ColumnsSelectorXML, null);
         new GeneXus.Programs.wwpbaseobjects.savecolumnsselectorstate(context ).execute(  "WP_GerenciarPedidoColumnsSelector",  AV44ColumnsSelector.ToXml(false, true, "WWPColumnsSelector", "FMX")) ;
         context.DoAjaxRefresh();
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58PedidoIdTitleFilterData", AV58PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62PessoaIdTitleFilterData", AV62PessoaIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66PessoaNomeTitleFilterData", AV66PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV70PedidoDtTitleFilterData", AV70PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV76PedidoStatusTitleFilterData", AV76PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV80PedidoDtEntregaTitleFilterData", AV80PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86PedidoRetiradaTitleFilterData", AV86PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV89PedidoTotalTitleFilterData", AV89PedidoTotalTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E27182( )
      {
         /* 'AddDynamicFilters1' Routine */
         AV20DynamicFiltersEnabled2 = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20DynamicFiltersEnabled2", AV20DynamicFiltersEnabled2);
         imgAdddynamicfilters1_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgAdddynamicfilters1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgAdddynamicfilters1_Visible), 5, 0)), true);
         imgRemovedynamicfilters1_Visible = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgRemovedynamicfilters1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgRemovedynamicfilters1_Visible), 5, 0)), true);
         /*  Sending Event outputs  */
      }

      protected void E23182( )
      {
         /* 'RemoveDynamicFilters1' Routine */
         AV30DynamicFiltersRemoving = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30DynamicFiltersRemoving", AV30DynamicFiltersRemoving);
         AV31DynamicFiltersIgnoreFirst = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31DynamicFiltersIgnoreFirst", AV31DynamicFiltersIgnoreFirst);
         /* Execute user subroutine: 'SAVEDYNFILTERSSTATE' */
         S212 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'RESETDYNFILTERS' */
         S222 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'LOADDYNFILTERSSTATE' */
         S232 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV30DynamicFiltersRemoving = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30DynamicFiltersRemoving", AV30DynamicFiltersRemoving);
         AV31DynamicFiltersIgnoreFirst = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31DynamicFiltersIgnoreFirst", AV31DynamicFiltersIgnoreFirst);
         gxgrGrid_refresh( subGrid_Rows, AV16DynamicFiltersSelector1, AV17DynamicFiltersOperator1, AV18PedidoDt1, AV19PedidoDt_To1, AV21DynamicFiltersSelector2, AV22DynamicFiltersOperator2, AV23PedidoDt2, AV24PedidoDt_To2, AV26DynamicFiltersSelector3, AV27DynamicFiltersOperator3, AV28PedidoDt3, AV29PedidoDt_To3, AV20DynamicFiltersEnabled2, AV25DynamicFiltersEnabled3, AV13OrderedBy, AV14OrderedDsc, AV59TFPedidoId, AV60TFPedidoId_To, AV63TFPessoaId, AV64TFPessoaId_To, AV67TFPessoaNome, AV68TFPessoaNome_Sel, AV71TFPedidoDt, AV72TFPedidoDt_To, AV81TFPedidoDtEntrega, AV82TFPedidoDtEntrega_To, AV87TFPedidoRetirada_Sel, AV52ManageFiltersExecutionStep, AV44ColumnsSelector, AV61ddo_PedidoIdTitleControlIdToReplace, AV65ddo_PessoaIdTitleControlIdToReplace, AV69ddo_PessoaNomeTitleControlIdToReplace, AV75ddo_PedidoDtTitleControlIdToReplace, AV79ddo_PedidoStatusTitleControlIdToReplace, AV85ddo_PedidoDtEntregaTitleControlIdToReplace, AV88ddo_PedidoRetiradaTitleControlIdToReplace, AV92ddo_PedidoTotalTitleControlIdToReplace, AV78TFPedidoStatus_Sels, AV90TFPedidoTotal, AV91TFPedidoTotal_To, AV129Pgmname, AV10GridState, AV31DynamicFiltersIgnoreFirst, AV30DynamicFiltersRemoving) ;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
         cmbavDynamicfiltersselector2.CurrentValue = StringUtil.RTrim( AV21DynamicFiltersSelector2);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector2_Internalname, "Values", cmbavDynamicfiltersselector2.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV22DynamicFiltersOperator2), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", cmbavDynamicfiltersoperator2.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector3.CurrentValue = StringUtil.RTrim( AV26DynamicFiltersSelector3);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector3_Internalname, "Values", cmbavDynamicfiltersselector3.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV27DynamicFiltersOperator3), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", cmbavDynamicfiltersoperator3.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector1.CurrentValue = StringUtil.RTrim( AV16DynamicFiltersSelector1);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector1_Internalname, "Values", cmbavDynamicfiltersselector1.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV17DynamicFiltersOperator1), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", cmbavDynamicfiltersoperator1.ToJavascriptSource(), true);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58PedidoIdTitleFilterData", AV58PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62PessoaIdTitleFilterData", AV62PessoaIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66PessoaNomeTitleFilterData", AV66PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV70PedidoDtTitleFilterData", AV70PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV76PedidoStatusTitleFilterData", AV76PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV80PedidoDtEntregaTitleFilterData", AV80PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86PedidoRetiradaTitleFilterData", AV86PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV89PedidoTotalTitleFilterData", AV89PedidoTotalTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
      }

      protected void E28182( )
      {
         /* Dynamicfiltersselector1_Click Routine */
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS1' */
         S122 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /*  Sending Event outputs  */
      }

      protected void E29182( )
      {
         /* Dynamicfiltersoperator1_Click Routine */
         if ( StringUtil.StrCmp(AV16DynamicFiltersSelector1, "PEDIDODT") == 0 )
         {
            AV18PedidoDt1 = DateTime.MinValue;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18PedidoDt1", context.localUtil.Format(AV18PedidoDt1, "99/99/99"));
            AV19PedidoDt_To1 = DateTime.MinValue;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19PedidoDt_To1", context.localUtil.Format(AV19PedidoDt_To1, "99/99/99"));
            /* Execute user subroutine: 'UPDATEPEDIDODT1OPERATORVALUES' */
            S242 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            gxgrGrid_refresh( subGrid_Rows, AV16DynamicFiltersSelector1, AV17DynamicFiltersOperator1, AV18PedidoDt1, AV19PedidoDt_To1, AV21DynamicFiltersSelector2, AV22DynamicFiltersOperator2, AV23PedidoDt2, AV24PedidoDt_To2, AV26DynamicFiltersSelector3, AV27DynamicFiltersOperator3, AV28PedidoDt3, AV29PedidoDt_To3, AV20DynamicFiltersEnabled2, AV25DynamicFiltersEnabled3, AV13OrderedBy, AV14OrderedDsc, AV59TFPedidoId, AV60TFPedidoId_To, AV63TFPessoaId, AV64TFPessoaId_To, AV67TFPessoaNome, AV68TFPessoaNome_Sel, AV71TFPedidoDt, AV72TFPedidoDt_To, AV81TFPedidoDtEntrega, AV82TFPedidoDtEntrega_To, AV87TFPedidoRetirada_Sel, AV52ManageFiltersExecutionStep, AV44ColumnsSelector, AV61ddo_PedidoIdTitleControlIdToReplace, AV65ddo_PessoaIdTitleControlIdToReplace, AV69ddo_PessoaNomeTitleControlIdToReplace, AV75ddo_PedidoDtTitleControlIdToReplace, AV79ddo_PedidoStatusTitleControlIdToReplace, AV85ddo_PedidoDtEntregaTitleControlIdToReplace, AV88ddo_PedidoRetiradaTitleControlIdToReplace, AV92ddo_PedidoTotalTitleControlIdToReplace, AV78TFPedidoStatus_Sels, AV90TFPedidoTotal, AV91TFPedidoTotal_To, AV129Pgmname, AV10GridState, AV31DynamicFiltersIgnoreFirst, AV30DynamicFiltersRemoving) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58PedidoIdTitleFilterData", AV58PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62PessoaIdTitleFilterData", AV62PessoaIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66PessoaNomeTitleFilterData", AV66PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV70PedidoDtTitleFilterData", AV70PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV76PedidoStatusTitleFilterData", AV76PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV80PedidoDtEntregaTitleFilterData", AV80PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86PedidoRetiradaTitleFilterData", AV86PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV89PedidoTotalTitleFilterData", AV89PedidoTotalTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E30182( )
      {
         /* 'AddDynamicFilters2' Routine */
         AV25DynamicFiltersEnabled3 = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25DynamicFiltersEnabled3", AV25DynamicFiltersEnabled3);
         imgAdddynamicfilters2_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgAdddynamicfilters2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgAdddynamicfilters2_Visible), 5, 0)), true);
         imgRemovedynamicfilters2_Visible = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgRemovedynamicfilters2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgRemovedynamicfilters2_Visible), 5, 0)), true);
         /*  Sending Event outputs  */
      }

      protected void E24182( )
      {
         /* 'RemoveDynamicFilters2' Routine */
         AV30DynamicFiltersRemoving = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30DynamicFiltersRemoving", AV30DynamicFiltersRemoving);
         AV20DynamicFiltersEnabled2 = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20DynamicFiltersEnabled2", AV20DynamicFiltersEnabled2);
         /* Execute user subroutine: 'SAVEDYNFILTERSSTATE' */
         S212 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'RESETDYNFILTERS' */
         S222 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'LOADDYNFILTERSSTATE' */
         S232 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV30DynamicFiltersRemoving = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30DynamicFiltersRemoving", AV30DynamicFiltersRemoving);
         gxgrGrid_refresh( subGrid_Rows, AV16DynamicFiltersSelector1, AV17DynamicFiltersOperator1, AV18PedidoDt1, AV19PedidoDt_To1, AV21DynamicFiltersSelector2, AV22DynamicFiltersOperator2, AV23PedidoDt2, AV24PedidoDt_To2, AV26DynamicFiltersSelector3, AV27DynamicFiltersOperator3, AV28PedidoDt3, AV29PedidoDt_To3, AV20DynamicFiltersEnabled2, AV25DynamicFiltersEnabled3, AV13OrderedBy, AV14OrderedDsc, AV59TFPedidoId, AV60TFPedidoId_To, AV63TFPessoaId, AV64TFPessoaId_To, AV67TFPessoaNome, AV68TFPessoaNome_Sel, AV71TFPedidoDt, AV72TFPedidoDt_To, AV81TFPedidoDtEntrega, AV82TFPedidoDtEntrega_To, AV87TFPedidoRetirada_Sel, AV52ManageFiltersExecutionStep, AV44ColumnsSelector, AV61ddo_PedidoIdTitleControlIdToReplace, AV65ddo_PessoaIdTitleControlIdToReplace, AV69ddo_PessoaNomeTitleControlIdToReplace, AV75ddo_PedidoDtTitleControlIdToReplace, AV79ddo_PedidoStatusTitleControlIdToReplace, AV85ddo_PedidoDtEntregaTitleControlIdToReplace, AV88ddo_PedidoRetiradaTitleControlIdToReplace, AV92ddo_PedidoTotalTitleControlIdToReplace, AV78TFPedidoStatus_Sels, AV90TFPedidoTotal, AV91TFPedidoTotal_To, AV129Pgmname, AV10GridState, AV31DynamicFiltersIgnoreFirst, AV30DynamicFiltersRemoving) ;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
         cmbavDynamicfiltersselector2.CurrentValue = StringUtil.RTrim( AV21DynamicFiltersSelector2);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector2_Internalname, "Values", cmbavDynamicfiltersselector2.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV22DynamicFiltersOperator2), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", cmbavDynamicfiltersoperator2.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector3.CurrentValue = StringUtil.RTrim( AV26DynamicFiltersSelector3);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector3_Internalname, "Values", cmbavDynamicfiltersselector3.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV27DynamicFiltersOperator3), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", cmbavDynamicfiltersoperator3.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector1.CurrentValue = StringUtil.RTrim( AV16DynamicFiltersSelector1);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector1_Internalname, "Values", cmbavDynamicfiltersselector1.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV17DynamicFiltersOperator1), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", cmbavDynamicfiltersoperator1.ToJavascriptSource(), true);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58PedidoIdTitleFilterData", AV58PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62PessoaIdTitleFilterData", AV62PessoaIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66PessoaNomeTitleFilterData", AV66PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV70PedidoDtTitleFilterData", AV70PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV76PedidoStatusTitleFilterData", AV76PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV80PedidoDtEntregaTitleFilterData", AV80PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86PedidoRetiradaTitleFilterData", AV86PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV89PedidoTotalTitleFilterData", AV89PedidoTotalTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
      }

      protected void E31182( )
      {
         /* Dynamicfiltersselector2_Click Routine */
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS2' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /*  Sending Event outputs  */
      }

      protected void E32182( )
      {
         /* Dynamicfiltersoperator2_Click Routine */
         if ( StringUtil.StrCmp(AV21DynamicFiltersSelector2, "PEDIDODT") == 0 )
         {
            AV23PedidoDt2 = DateTime.MinValue;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23PedidoDt2", context.localUtil.Format(AV23PedidoDt2, "99/99/99"));
            AV24PedidoDt_To2 = DateTime.MinValue;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24PedidoDt_To2", context.localUtil.Format(AV24PedidoDt_To2, "99/99/99"));
            /* Execute user subroutine: 'UPDATEPEDIDODT2OPERATORVALUES' */
            S252 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            gxgrGrid_refresh( subGrid_Rows, AV16DynamicFiltersSelector1, AV17DynamicFiltersOperator1, AV18PedidoDt1, AV19PedidoDt_To1, AV21DynamicFiltersSelector2, AV22DynamicFiltersOperator2, AV23PedidoDt2, AV24PedidoDt_To2, AV26DynamicFiltersSelector3, AV27DynamicFiltersOperator3, AV28PedidoDt3, AV29PedidoDt_To3, AV20DynamicFiltersEnabled2, AV25DynamicFiltersEnabled3, AV13OrderedBy, AV14OrderedDsc, AV59TFPedidoId, AV60TFPedidoId_To, AV63TFPessoaId, AV64TFPessoaId_To, AV67TFPessoaNome, AV68TFPessoaNome_Sel, AV71TFPedidoDt, AV72TFPedidoDt_To, AV81TFPedidoDtEntrega, AV82TFPedidoDtEntrega_To, AV87TFPedidoRetirada_Sel, AV52ManageFiltersExecutionStep, AV44ColumnsSelector, AV61ddo_PedidoIdTitleControlIdToReplace, AV65ddo_PessoaIdTitleControlIdToReplace, AV69ddo_PessoaNomeTitleControlIdToReplace, AV75ddo_PedidoDtTitleControlIdToReplace, AV79ddo_PedidoStatusTitleControlIdToReplace, AV85ddo_PedidoDtEntregaTitleControlIdToReplace, AV88ddo_PedidoRetiradaTitleControlIdToReplace, AV92ddo_PedidoTotalTitleControlIdToReplace, AV78TFPedidoStatus_Sels, AV90TFPedidoTotal, AV91TFPedidoTotal_To, AV129Pgmname, AV10GridState, AV31DynamicFiltersIgnoreFirst, AV30DynamicFiltersRemoving) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58PedidoIdTitleFilterData", AV58PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62PessoaIdTitleFilterData", AV62PessoaIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66PessoaNomeTitleFilterData", AV66PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV70PedidoDtTitleFilterData", AV70PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV76PedidoStatusTitleFilterData", AV76PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV80PedidoDtEntregaTitleFilterData", AV80PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86PedidoRetiradaTitleFilterData", AV86PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV89PedidoTotalTitleFilterData", AV89PedidoTotalTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E25182( )
      {
         /* 'RemoveDynamicFilters3' Routine */
         AV30DynamicFiltersRemoving = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30DynamicFiltersRemoving", AV30DynamicFiltersRemoving);
         AV25DynamicFiltersEnabled3 = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25DynamicFiltersEnabled3", AV25DynamicFiltersEnabled3);
         /* Execute user subroutine: 'SAVEDYNFILTERSSTATE' */
         S212 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'RESETDYNFILTERS' */
         S222 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'LOADDYNFILTERSSTATE' */
         S232 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV30DynamicFiltersRemoving = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30DynamicFiltersRemoving", AV30DynamicFiltersRemoving);
         gxgrGrid_refresh( subGrid_Rows, AV16DynamicFiltersSelector1, AV17DynamicFiltersOperator1, AV18PedidoDt1, AV19PedidoDt_To1, AV21DynamicFiltersSelector2, AV22DynamicFiltersOperator2, AV23PedidoDt2, AV24PedidoDt_To2, AV26DynamicFiltersSelector3, AV27DynamicFiltersOperator3, AV28PedidoDt3, AV29PedidoDt_To3, AV20DynamicFiltersEnabled2, AV25DynamicFiltersEnabled3, AV13OrderedBy, AV14OrderedDsc, AV59TFPedidoId, AV60TFPedidoId_To, AV63TFPessoaId, AV64TFPessoaId_To, AV67TFPessoaNome, AV68TFPessoaNome_Sel, AV71TFPedidoDt, AV72TFPedidoDt_To, AV81TFPedidoDtEntrega, AV82TFPedidoDtEntrega_To, AV87TFPedidoRetirada_Sel, AV52ManageFiltersExecutionStep, AV44ColumnsSelector, AV61ddo_PedidoIdTitleControlIdToReplace, AV65ddo_PessoaIdTitleControlIdToReplace, AV69ddo_PessoaNomeTitleControlIdToReplace, AV75ddo_PedidoDtTitleControlIdToReplace, AV79ddo_PedidoStatusTitleControlIdToReplace, AV85ddo_PedidoDtEntregaTitleControlIdToReplace, AV88ddo_PedidoRetiradaTitleControlIdToReplace, AV92ddo_PedidoTotalTitleControlIdToReplace, AV78TFPedidoStatus_Sels, AV90TFPedidoTotal, AV91TFPedidoTotal_To, AV129Pgmname, AV10GridState, AV31DynamicFiltersIgnoreFirst, AV30DynamicFiltersRemoving) ;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
         cmbavDynamicfiltersselector2.CurrentValue = StringUtil.RTrim( AV21DynamicFiltersSelector2);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector2_Internalname, "Values", cmbavDynamicfiltersselector2.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV22DynamicFiltersOperator2), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", cmbavDynamicfiltersoperator2.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector3.CurrentValue = StringUtil.RTrim( AV26DynamicFiltersSelector3);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector3_Internalname, "Values", cmbavDynamicfiltersselector3.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV27DynamicFiltersOperator3), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", cmbavDynamicfiltersoperator3.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector1.CurrentValue = StringUtil.RTrim( AV16DynamicFiltersSelector1);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector1_Internalname, "Values", cmbavDynamicfiltersselector1.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV17DynamicFiltersOperator1), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", cmbavDynamicfiltersoperator1.ToJavascriptSource(), true);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58PedidoIdTitleFilterData", AV58PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62PessoaIdTitleFilterData", AV62PessoaIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66PessoaNomeTitleFilterData", AV66PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV70PedidoDtTitleFilterData", AV70PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV76PedidoStatusTitleFilterData", AV76PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV80PedidoDtEntregaTitleFilterData", AV80PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86PedidoRetiradaTitleFilterData", AV86PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV89PedidoTotalTitleFilterData", AV89PedidoTotalTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
      }

      protected void E33182( )
      {
         /* Dynamicfiltersselector3_Click Routine */
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS3' */
         S142 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /*  Sending Event outputs  */
      }

      protected void E34182( )
      {
         /* Dynamicfiltersoperator3_Click Routine */
         if ( StringUtil.StrCmp(AV26DynamicFiltersSelector3, "PEDIDODT") == 0 )
         {
            AV28PedidoDt3 = DateTime.MinValue;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28PedidoDt3", context.localUtil.Format(AV28PedidoDt3, "99/99/99"));
            AV29PedidoDt_To3 = DateTime.MinValue;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29PedidoDt_To3", context.localUtil.Format(AV29PedidoDt_To3, "99/99/99"));
            /* Execute user subroutine: 'UPDATEPEDIDODT3OPERATORVALUES' */
            S262 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            gxgrGrid_refresh( subGrid_Rows, AV16DynamicFiltersSelector1, AV17DynamicFiltersOperator1, AV18PedidoDt1, AV19PedidoDt_To1, AV21DynamicFiltersSelector2, AV22DynamicFiltersOperator2, AV23PedidoDt2, AV24PedidoDt_To2, AV26DynamicFiltersSelector3, AV27DynamicFiltersOperator3, AV28PedidoDt3, AV29PedidoDt_To3, AV20DynamicFiltersEnabled2, AV25DynamicFiltersEnabled3, AV13OrderedBy, AV14OrderedDsc, AV59TFPedidoId, AV60TFPedidoId_To, AV63TFPessoaId, AV64TFPessoaId_To, AV67TFPessoaNome, AV68TFPessoaNome_Sel, AV71TFPedidoDt, AV72TFPedidoDt_To, AV81TFPedidoDtEntrega, AV82TFPedidoDtEntrega_To, AV87TFPedidoRetirada_Sel, AV52ManageFiltersExecutionStep, AV44ColumnsSelector, AV61ddo_PedidoIdTitleControlIdToReplace, AV65ddo_PessoaIdTitleControlIdToReplace, AV69ddo_PessoaNomeTitleControlIdToReplace, AV75ddo_PedidoDtTitleControlIdToReplace, AV79ddo_PedidoStatusTitleControlIdToReplace, AV85ddo_PedidoDtEntregaTitleControlIdToReplace, AV88ddo_PedidoRetiradaTitleControlIdToReplace, AV92ddo_PedidoTotalTitleControlIdToReplace, AV78TFPedidoStatus_Sels, AV90TFPedidoTotal, AV91TFPedidoTotal_To, AV129Pgmname, AV10GridState, AV31DynamicFiltersIgnoreFirst, AV30DynamicFiltersRemoving) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58PedidoIdTitleFilterData", AV58PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62PessoaIdTitleFilterData", AV62PessoaIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66PessoaNomeTitleFilterData", AV66PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV70PedidoDtTitleFilterData", AV70PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV76PedidoStatusTitleFilterData", AV76PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV80PedidoDtEntregaTitleFilterData", AV80PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86PedidoRetiradaTitleFilterData", AV86PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV89PedidoTotalTitleFilterData", AV89PedidoTotalTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E11182( )
      {
         /* Ddo_managefilters_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_managefilters_Activeeventkey, "<#Clean#>") == 0 )
         {
            /* Execute user subroutine: 'CLEANFILTERS' */
            S272 ();
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
            S182 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            context.PopUp(formatLink("wwpbaseobjects.savefilteras.aspx") + "?" + UrlEncode(StringUtil.RTrim("WP_GerenciarPedidoFilters")) + "," + UrlEncode(StringUtil.RTrim(AV129Pgmname+"GridState")), new Object[] {});
            AV52ManageFiltersExecutionStep = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV52ManageFiltersExecutionStep", StringUtil.Str( (decimal)(AV52ManageFiltersExecutionStep), 1, 0));
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_managefilters_Activeeventkey, "<#Manage#>") == 0 )
         {
            context.PopUp(formatLink("wwpbaseobjects.managefilters.aspx") + "?" + UrlEncode(StringUtil.RTrim("WP_GerenciarPedidoFilters")), new Object[] {});
            AV52ManageFiltersExecutionStep = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV52ManageFiltersExecutionStep", StringUtil.Str( (decimal)(AV52ManageFiltersExecutionStep), 1, 0));
            context.DoAjaxRefresh();
         }
         else
         {
            GXt_char2 = AV53ManageFiltersXml;
            new GeneXus.Programs.wwpbaseobjects.getfilterbyname(context ).execute(  "WP_GerenciarPedidoFilters",  Ddo_managefilters_Activeeventkey, out  GXt_char2) ;
            ucDdo_managefilters.SendProperty(context, "", false, Ddo_managefilters_Internalname, "ActiveEventKey", Ddo_managefilters_Activeeventkey);
            AV53ManageFiltersXml = GXt_char2;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( AV53ManageFiltersXml)) )
            {
               GX_msglist.addItem("O filtro selecionado não existe mais.");
            }
            else
            {
               /* Execute user subroutine: 'CLEANFILTERS' */
               S272 ();
               if ( returnInSub )
               {
                  returnInSub = true;
                  if (true) return;
               }
               new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV129Pgmname+"GridState",  AV53ManageFiltersXml) ;
               AV10GridState.FromXml(AV53ManageFiltersXml, null, "WWPGridState", "FMX");
               AV13OrderedBy = AV10GridState.gxTpr_Orderedby;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
               AV14OrderedDsc = AV10GridState.gxTpr_Ordereddsc;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
               /* Execute user subroutine: 'SETDDOSORTEDSTATUS' */
               S172 ();
               if ( returnInSub )
               {
                  returnInSub = true;
                  if (true) return;
               }
               /* Execute user subroutine: 'LOADREGFILTERSSTATE' */
               S282 ();
               if ( returnInSub )
               {
                  returnInSub = true;
                  if (true) return;
               }
               /* Execute user subroutine: 'LOADDYNFILTERSSTATE' */
               S232 ();
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
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78TFPedidoStatus_Sels", AV78TFPedidoStatus_Sels);
         cmbavDynamicfiltersselector1.CurrentValue = StringUtil.RTrim( AV16DynamicFiltersSelector1);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector1_Internalname, "Values", cmbavDynamicfiltersselector1.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV17DynamicFiltersOperator1), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", cmbavDynamicfiltersoperator1.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector2.CurrentValue = StringUtil.RTrim( AV21DynamicFiltersSelector2);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector2_Internalname, "Values", cmbavDynamicfiltersselector2.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV22DynamicFiltersOperator2), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", cmbavDynamicfiltersoperator2.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector3.CurrentValue = StringUtil.RTrim( AV26DynamicFiltersSelector3);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector3_Internalname, "Values", cmbavDynamicfiltersselector3.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV27DynamicFiltersOperator3), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", cmbavDynamicfiltersoperator3.ToJavascriptSource(), true);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58PedidoIdTitleFilterData", AV58PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62PessoaIdTitleFilterData", AV62PessoaIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66PessoaNomeTitleFilterData", AV66PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV70PedidoDtTitleFilterData", AV70PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV76PedidoStatusTitleFilterData", AV76PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV80PedidoDtEntregaTitleFilterData", AV80PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86PedidoRetiradaTitleFilterData", AV86PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV89PedidoTotalTitleFilterData", AV89PedidoTotalTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
      }

      protected void E26182( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("pedido.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
         context.wjLocDisableFrm = 1;
      }

      protected void S202( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_pedidoid_Sortedstatus = "";
         ucDdo_pedidoid.SendProperty(context, "", false, Ddo_pedidoid_Internalname, "SortedStatus", Ddo_pedidoid_Sortedstatus);
         Ddo_pessoaid_Sortedstatus = "";
         ucDdo_pessoaid.SendProperty(context, "", false, Ddo_pessoaid_Internalname, "SortedStatus", Ddo_pessoaid_Sortedstatus);
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
      }

      protected void S172( )
      {
         /* 'SETDDOSORTEDSTATUS' Routine */
         /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
         S202 ();
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
            Ddo_pessoaid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_pessoaid.SendProperty(context, "", false, Ddo_pessoaid_Internalname, "SortedStatus", Ddo_pessoaid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 4 )
         {
            Ddo_pessoanome_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_pessoanome.SendProperty(context, "", false, Ddo_pessoanome_Internalname, "SortedStatus", Ddo_pessoanome_Sortedstatus);
         }
         else if ( AV13OrderedBy == 1 )
         {
            Ddo_pedidodt_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_pedidodt.SendProperty(context, "", false, Ddo_pedidodt_Internalname, "SortedStatus", Ddo_pedidodt_Sortedstatus);
         }
         else if ( AV13OrderedBy == 5 )
         {
            Ddo_pedidostatus_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_pedidostatus.SendProperty(context, "", false, Ddo_pedidostatus_Internalname, "SortedStatus", Ddo_pedidostatus_Sortedstatus);
         }
         else if ( AV13OrderedBy == 6 )
         {
            Ddo_pedidodtentrega_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_pedidodtentrega.SendProperty(context, "", false, Ddo_pedidodtentrega_Internalname, "SortedStatus", Ddo_pedidodtentrega_Sortedstatus);
         }
         else if ( AV13OrderedBy == 7 )
         {
            Ddo_pedidoretirada_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_pedidoretirada.SendProperty(context, "", false, Ddo_pedidoretirada_Internalname, "SortedStatus", Ddo_pedidoretirada_Sortedstatus);
         }
      }

      protected void S192( )
      {
         /* 'INITIALIZECOLUMNSSELECTOR' Routine */
         AV44ColumnsSelector = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector(context);
         new GeneXus.Programs.wwpbaseobjects.wwp_columnsselector_add(context ).execute( ref  AV44ColumnsSelector,  "Número do Pedido",  true) ;
         new GeneXus.Programs.wwpbaseobjects.wwp_columnsselector_add(context ).execute( ref  AV44ColumnsSelector,  "Id",  true) ;
         new GeneXus.Programs.wwpbaseobjects.wwp_columnsselector_add(context ).execute( ref  AV44ColumnsSelector,  "Nome",  true) ;
         new GeneXus.Programs.wwpbaseobjects.wwp_columnsselector_add(context ).execute( ref  AV44ColumnsSelector,  "Data do Pedido",  true) ;
         new GeneXus.Programs.wwpbaseobjects.wwp_columnsselector_add(context ).execute( ref  AV44ColumnsSelector,  "Status",  true) ;
         new GeneXus.Programs.wwpbaseobjects.wwp_columnsselector_add(context ).execute( ref  AV44ColumnsSelector,  "Data de Entrega",  true) ;
         new GeneXus.Programs.wwpbaseobjects.wwp_columnsselector_add(context ).execute( ref  AV44ColumnsSelector,  "Retirar no Local?",  true) ;
         new GeneXus.Programs.wwpbaseobjects.wwp_columnsselector_add(context ).execute( ref  AV44ColumnsSelector,  "Total",  true) ;
         GXt_char2 = AV39UserCustomValue;
         new GeneXus.Programs.wwpbaseobjects.loadcolumnsselectorstate(context ).execute(  "WP_GerenciarPedidoColumnsSelector", out  GXt_char2) ;
         AV39UserCustomValue = GXt_char2;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( AV39UserCustomValue)) ) )
         {
            AV45ColumnsSelectorAux.FromXml(AV39UserCustomValue, null, "WWPColumnsSelector", "FMX");
            new GeneXus.Programs.wwpbaseobjects.wwp_columnselector_updatecolumns(context ).execute( ref  AV45ColumnsSelectorAux, ref  AV44ColumnsSelector) ;
         }
      }

      protected void S122( )
      {
         /* 'ENABLEDYNAMICFILTERS1' Routine */
         tblTablemergeddynamicfilterspedidodt1_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, tblTablemergeddynamicfilterspedidodt1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTablemergeddynamicfilterspedidodt1_Visible), 5, 0)), true);
         cmbavDynamicfiltersoperator1.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavDynamicfiltersoperator1.Visible), 5, 0)), true);
         if ( StringUtil.StrCmp(AV16DynamicFiltersSelector1, "PEDIDODT") == 0 )
         {
            tblTablemergeddynamicfilterspedidodt1_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, tblTablemergeddynamicfilterspedidodt1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTablemergeddynamicfilterspedidodt1_Visible), 5, 0)), true);
            cmbavDynamicfiltersoperator1.Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavDynamicfiltersoperator1.Visible), 5, 0)), true);
            /* Execute user subroutine: 'UPDATEPEDIDODT1OPERATORVALUES' */
            S242 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
      }

      protected void S242( )
      {
         /* 'UPDATEPEDIDODT1OPERATORVALUES' Routine */
         cellPedidodt_cell1_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellPedidodt_cell1_Internalname, "Class", cellPedidodt_cell1_Class, true);
         cellPedidodt_to_cell1_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellPedidodt_to_cell1_Internalname, "Class", cellPedidodt_to_cell1_Class, true);
         lblPedidodt_rangemiddletext_11_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblPedidodt_rangemiddletext_11_Internalname, "Class", lblPedidodt_rangemiddletext_11_Class, true);
         if ( AV17DynamicFiltersOperator1 == 0 )
         {
            AV18PedidoDt1 = Gx_date;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18PedidoDt1", context.localUtil.Format(AV18PedidoDt1, "99/99/99"));
         }
         else if ( AV17DynamicFiltersOperator1 == 1 )
         {
            AV18PedidoDt1 = Gx_date;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18PedidoDt1", context.localUtil.Format(AV18PedidoDt1, "99/99/99"));
         }
         else if ( AV17DynamicFiltersOperator1 == 2 )
         {
            AV18PedidoDt1 = Gx_date;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18PedidoDt1", context.localUtil.Format(AV18PedidoDt1, "99/99/99"));
         }
         else if ( AV17DynamicFiltersOperator1 == 3 )
         {
            cellPedidodt_cell1_Class = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellPedidodt_cell1_Internalname, "Class", cellPedidodt_cell1_Class, true);
            cellPedidodt_to_cell1_Class = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellPedidodt_to_cell1_Internalname, "Class", cellPedidodt_to_cell1_Class, true);
            lblPedidodt_rangemiddletext_11_Class = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblPedidodt_rangemiddletext_11_Internalname, "Class", lblPedidodt_rangemiddletext_11_Class, true);
         }
      }

      protected void S132( )
      {
         /* 'ENABLEDYNAMICFILTERS2' Routine */
         tblTablemergeddynamicfilterspedidodt2_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, tblTablemergeddynamicfilterspedidodt2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTablemergeddynamicfilterspedidodt2_Visible), 5, 0)), true);
         cmbavDynamicfiltersoperator2.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavDynamicfiltersoperator2.Visible), 5, 0)), true);
         if ( StringUtil.StrCmp(AV21DynamicFiltersSelector2, "PEDIDODT") == 0 )
         {
            tblTablemergeddynamicfilterspedidodt2_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, tblTablemergeddynamicfilterspedidodt2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTablemergeddynamicfilterspedidodt2_Visible), 5, 0)), true);
            cmbavDynamicfiltersoperator2.Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavDynamicfiltersoperator2.Visible), 5, 0)), true);
            /* Execute user subroutine: 'UPDATEPEDIDODT2OPERATORVALUES' */
            S252 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
      }

      protected void S252( )
      {
         /* 'UPDATEPEDIDODT2OPERATORVALUES' Routine */
         cellPedidodt_cell2_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellPedidodt_cell2_Internalname, "Class", cellPedidodt_cell2_Class, true);
         cellPedidodt_to_cell2_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellPedidodt_to_cell2_Internalname, "Class", cellPedidodt_to_cell2_Class, true);
         lblPedidodt_rangemiddletext_12_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblPedidodt_rangemiddletext_12_Internalname, "Class", lblPedidodt_rangemiddletext_12_Class, true);
         if ( AV22DynamicFiltersOperator2 == 0 )
         {
            AV23PedidoDt2 = Gx_date;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23PedidoDt2", context.localUtil.Format(AV23PedidoDt2, "99/99/99"));
         }
         else if ( AV22DynamicFiltersOperator2 == 1 )
         {
            AV23PedidoDt2 = Gx_date;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23PedidoDt2", context.localUtil.Format(AV23PedidoDt2, "99/99/99"));
         }
         else if ( AV22DynamicFiltersOperator2 == 2 )
         {
            AV23PedidoDt2 = Gx_date;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23PedidoDt2", context.localUtil.Format(AV23PedidoDt2, "99/99/99"));
         }
         else if ( AV22DynamicFiltersOperator2 == 3 )
         {
            cellPedidodt_cell2_Class = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellPedidodt_cell2_Internalname, "Class", cellPedidodt_cell2_Class, true);
            cellPedidodt_to_cell2_Class = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellPedidodt_to_cell2_Internalname, "Class", cellPedidodt_to_cell2_Class, true);
            lblPedidodt_rangemiddletext_12_Class = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblPedidodt_rangemiddletext_12_Internalname, "Class", lblPedidodt_rangemiddletext_12_Class, true);
         }
      }

      protected void S142( )
      {
         /* 'ENABLEDYNAMICFILTERS3' Routine */
         tblTablemergeddynamicfilterspedidodt3_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, tblTablemergeddynamicfilterspedidodt3_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTablemergeddynamicfilterspedidodt3_Visible), 5, 0)), true);
         cmbavDynamicfiltersoperator3.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavDynamicfiltersoperator3.Visible), 5, 0)), true);
         if ( StringUtil.StrCmp(AV26DynamicFiltersSelector3, "PEDIDODT") == 0 )
         {
            tblTablemergeddynamicfilterspedidodt3_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, tblTablemergeddynamicfilterspedidodt3_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTablemergeddynamicfilterspedidodt3_Visible), 5, 0)), true);
            cmbavDynamicfiltersoperator3.Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavDynamicfiltersoperator3.Visible), 5, 0)), true);
            /* Execute user subroutine: 'UPDATEPEDIDODT3OPERATORVALUES' */
            S262 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
      }

      protected void S262( )
      {
         /* 'UPDATEPEDIDODT3OPERATORVALUES' Routine */
         cellPedidodt_cell3_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellPedidodt_cell3_Internalname, "Class", cellPedidodt_cell3_Class, true);
         cellPedidodt_to_cell3_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellPedidodt_to_cell3_Internalname, "Class", cellPedidodt_to_cell3_Class, true);
         lblPedidodt_rangemiddletext_13_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblPedidodt_rangemiddletext_13_Internalname, "Class", lblPedidodt_rangemiddletext_13_Class, true);
         if ( AV27DynamicFiltersOperator3 == 0 )
         {
            AV28PedidoDt3 = Gx_date;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28PedidoDt3", context.localUtil.Format(AV28PedidoDt3, "99/99/99"));
         }
         else if ( AV27DynamicFiltersOperator3 == 1 )
         {
            AV28PedidoDt3 = Gx_date;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28PedidoDt3", context.localUtil.Format(AV28PedidoDt3, "99/99/99"));
         }
         else if ( AV27DynamicFiltersOperator3 == 2 )
         {
            AV28PedidoDt3 = Gx_date;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28PedidoDt3", context.localUtil.Format(AV28PedidoDt3, "99/99/99"));
         }
         else if ( AV27DynamicFiltersOperator3 == 3 )
         {
            cellPedidodt_cell3_Class = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellPedidodt_cell3_Internalname, "Class", cellPedidodt_cell3_Class, true);
            cellPedidodt_to_cell3_Class = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellPedidodt_to_cell3_Internalname, "Class", cellPedidodt_to_cell3_Class, true);
            lblPedidodt_rangemiddletext_13_Class = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblPedidodt_rangemiddletext_13_Internalname, "Class", lblPedidodt_rangemiddletext_13_Class, true);
         }
      }

      protected void S222( )
      {
         /* 'RESETDYNFILTERS' Routine */
         AV20DynamicFiltersEnabled2 = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20DynamicFiltersEnabled2", AV20DynamicFiltersEnabled2);
         AV21DynamicFiltersSelector2 = "PEDIDODT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21DynamicFiltersSelector2", AV21DynamicFiltersSelector2);
         AV22DynamicFiltersOperator2 = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22DynamicFiltersOperator2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22DynamicFiltersOperator2), 4, 0)));
         AV23PedidoDt2 = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23PedidoDt2", context.localUtil.Format(AV23PedidoDt2, "99/99/99"));
         AV24PedidoDt_To2 = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24PedidoDt_To2", context.localUtil.Format(AV24PedidoDt_To2, "99/99/99"));
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS2' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV25DynamicFiltersEnabled3 = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25DynamicFiltersEnabled3", AV25DynamicFiltersEnabled3);
         AV26DynamicFiltersSelector3 = "PEDIDODT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26DynamicFiltersSelector3", AV26DynamicFiltersSelector3);
         AV27DynamicFiltersOperator3 = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27DynamicFiltersOperator3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV27DynamicFiltersOperator3), 4, 0)));
         AV28PedidoDt3 = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28PedidoDt3", context.localUtil.Format(AV28PedidoDt3, "99/99/99"));
         AV29PedidoDt_To3 = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29PedidoDt_To3", context.localUtil.Format(AV29PedidoDt_To3, "99/99/99"));
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS3' */
         S142 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
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
         AV57ManageFiltersDataItem.gxTpr_Jsonclickevent = StringUtil.Format( "WWPDynFilterHideAll_AL('%1', 3, 0)", tblTabledynamicfilters_Internalname, "", "", "", "", "", "", "", "");
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
         AV54ManageFiltersItems.FromXml(new GeneXus.Programs.wwpbaseobjects.loadmanagefiltersstate(context).executeUdp(  "WP_GerenciarPedidoFilters"), null, "Items", "");
         AV131GXV1 = 1;
         while ( AV131GXV1 <= AV54ManageFiltersItems.Count )
         {
            AV55ManageFiltersItem = ((GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item)AV54ManageFiltersItems.Item(AV131GXV1));
            AV57ManageFiltersDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
            AV57ManageFiltersDataItem.gxTpr_Title = AV55ManageFiltersItem.gxTpr_Title;
            AV57ManageFiltersDataItem.gxTpr_Eventkey = AV55ManageFiltersItem.gxTpr_Title;
            AV57ManageFiltersDataItem.gxTpr_Isdivider = false;
            AV57ManageFiltersDataItem.gxTpr_Jsonclickevent = StringUtil.Format( "WWPDynFilterHideAll_AL('%1', 3, 0)", tblTabledynamicfilters_Internalname, "", "", "", "", "", "", "", "");
            AV56ManageFiltersData.Add(AV57ManageFiltersDataItem, 0);
            if ( AV56ManageFiltersData.Count == 13 )
            {
               if (true) break;
            }
            AV131GXV1 = (int)(AV131GXV1+1);
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

      protected void S272( )
      {
         /* 'CLEANFILTERS' Routine */
         AV59TFPedidoId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV59TFPedidoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV59TFPedidoId), 4, 0)));
         Ddo_pedidoid_Filteredtext_set = "";
         ucDdo_pedidoid.SendProperty(context, "", false, Ddo_pedidoid_Internalname, "FilteredText_set", Ddo_pedidoid_Filteredtext_set);
         AV60TFPedidoId_To = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60TFPedidoId_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV60TFPedidoId_To), 4, 0)));
         Ddo_pedidoid_Filteredtextto_set = "";
         ucDdo_pedidoid.SendProperty(context, "", false, Ddo_pedidoid_Internalname, "FilteredTextTo_set", Ddo_pedidoid_Filteredtextto_set);
         AV63TFPessoaId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV63TFPessoaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV63TFPessoaId), 4, 0)));
         Ddo_pessoaid_Filteredtext_set = "";
         ucDdo_pessoaid.SendProperty(context, "", false, Ddo_pessoaid_Internalname, "FilteredText_set", Ddo_pessoaid_Filteredtext_set);
         AV64TFPessoaId_To = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV64TFPessoaId_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV64TFPessoaId_To), 4, 0)));
         Ddo_pessoaid_Filteredtextto_set = "";
         ucDdo_pessoaid.SendProperty(context, "", false, Ddo_pessoaid_Internalname, "FilteredTextTo_set", Ddo_pessoaid_Filteredtextto_set);
         AV67TFPessoaNome = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV67TFPessoaNome", AV67TFPessoaNome);
         Ddo_pessoanome_Filteredtext_set = "";
         ucDdo_pessoanome.SendProperty(context, "", false, Ddo_pessoanome_Internalname, "FilteredText_set", Ddo_pessoanome_Filteredtext_set);
         AV68TFPessoaNome_Sel = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV68TFPessoaNome_Sel", AV68TFPessoaNome_Sel);
         Ddo_pessoanome_Selectedvalue_set = "";
         ucDdo_pessoanome.SendProperty(context, "", false, Ddo_pessoanome_Internalname, "SelectedValue_set", Ddo_pessoanome_Selectedvalue_set);
         AV71TFPedidoDt = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV71TFPedidoDt", context.localUtil.Format(AV71TFPedidoDt, "99/99/99"));
         Ddo_pedidodt_Filteredtext_set = "";
         ucDdo_pedidodt.SendProperty(context, "", false, Ddo_pedidodt_Internalname, "FilteredText_set", Ddo_pedidodt_Filteredtext_set);
         AV72TFPedidoDt_To = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV72TFPedidoDt_To", context.localUtil.Format(AV72TFPedidoDt_To, "99/99/99"));
         Ddo_pedidodt_Filteredtextto_set = "";
         ucDdo_pedidodt.SendProperty(context, "", false, Ddo_pedidodt_Internalname, "FilteredTextTo_set", Ddo_pedidodt_Filteredtextto_set);
         AV78TFPedidoStatus_Sels = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         Ddo_pedidostatus_Selectedvalue_set = "";
         ucDdo_pedidostatus.SendProperty(context, "", false, Ddo_pedidostatus_Internalname, "SelectedValue_set", Ddo_pedidostatus_Selectedvalue_set);
         AV81TFPedidoDtEntrega = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV81TFPedidoDtEntrega", context.localUtil.Format(AV81TFPedidoDtEntrega, "99/99/99"));
         Ddo_pedidodtentrega_Filteredtext_set = "";
         ucDdo_pedidodtentrega.SendProperty(context, "", false, Ddo_pedidodtentrega_Internalname, "FilteredText_set", Ddo_pedidodtentrega_Filteredtext_set);
         AV82TFPedidoDtEntrega_To = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV82TFPedidoDtEntrega_To", context.localUtil.Format(AV82TFPedidoDtEntrega_To, "99/99/99"));
         Ddo_pedidodtentrega_Filteredtextto_set = "";
         ucDdo_pedidodtentrega.SendProperty(context, "", false, Ddo_pedidodtentrega_Internalname, "FilteredTextTo_set", Ddo_pedidodtentrega_Filteredtextto_set);
         AV87TFPedidoRetirada_Sel = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV87TFPedidoRetirada_Sel", StringUtil.Str( (decimal)(AV87TFPedidoRetirada_Sel), 1, 0));
         Ddo_pedidoretirada_Selectedvalue_set = "";
         ucDdo_pedidoretirada.SendProperty(context, "", false, Ddo_pedidoretirada_Internalname, "SelectedValue_set", Ddo_pedidoretirada_Selectedvalue_set);
         AV90TFPedidoTotal = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV90TFPedidoTotal", StringUtil.LTrim( StringUtil.Str( AV90TFPedidoTotal, 12, 2)));
         Ddo_pedidototal_Filteredtext_set = "";
         ucDdo_pedidototal.SendProperty(context, "", false, Ddo_pedidototal_Internalname, "FilteredText_set", Ddo_pedidototal_Filteredtext_set);
         AV91TFPedidoTotal_To = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV91TFPedidoTotal_To", StringUtil.LTrim( StringUtil.Str( AV91TFPedidoTotal_To, 12, 2)));
         Ddo_pedidototal_Filteredtextto_set = "";
         ucDdo_pedidototal.SendProperty(context, "", false, Ddo_pedidototal_Internalname, "FilteredTextTo_set", Ddo_pedidototal_Filteredtextto_set);
         AV16DynamicFiltersSelector1 = "PEDIDODT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16DynamicFiltersSelector1", AV16DynamicFiltersSelector1);
         AV17DynamicFiltersOperator1 = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17DynamicFiltersOperator1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17DynamicFiltersOperator1), 4, 0)));
         AV18PedidoDt1 = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18PedidoDt1", context.localUtil.Format(AV18PedidoDt1, "99/99/99"));
         AV19PedidoDt_To1 = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19PedidoDt_To1", context.localUtil.Format(AV19PedidoDt_To1, "99/99/99"));
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS1' */
         S122 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'RESETDYNFILTERS' */
         S222 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV10GridState.gxTpr_Dynamicfilters.Clear();
         /* Execute user subroutine: 'LOADDYNFILTERSSTATE' */
         S232 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void S162( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV51Session.Get(AV129Pgmname+"GridState"), "") == 0 )
         {
            AV10GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV129Pgmname+"GridState"), null, "WWPGridState", "FMX");
         }
         else
         {
            AV10GridState.FromXml(AV51Session.Get(AV129Pgmname+"GridState"), null, "WWPGridState", "FMX");
         }
         AV13OrderedBy = AV10GridState.gxTpr_Orderedby;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
         AV14OrderedDsc = AV10GridState.gxTpr_Ordereddsc;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
         /* Execute user subroutine: 'SETDDOSORTEDSTATUS' */
         S172 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'LOADREGFILTERSSTATE' */
         S282 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'LOADDYNFILTERSSTATE' */
         S232 ();
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

      protected void S282( )
      {
         /* 'LOADREGFILTERSSTATE' Routine */
         AV132GXV2 = 1;
         while ( AV132GXV2 <= AV10GridState.gxTpr_Filtervalues.Count )
         {
            AV11GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV10GridState.gxTpr_Filtervalues.Item(AV132GXV2));
            if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFPEDIDOID") == 0 )
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
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFPESSOAID") == 0 )
            {
               AV63TFPessoaId = (short)(NumberUtil.Val( AV11GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV63TFPessoaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV63TFPessoaId), 4, 0)));
               AV64TFPessoaId_To = (short)(NumberUtil.Val( AV11GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV64TFPessoaId_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV64TFPessoaId_To), 4, 0)));
               if ( ! (0==AV63TFPessoaId) )
               {
                  Ddo_pessoaid_Filteredtext_set = StringUtil.Str( (decimal)(AV63TFPessoaId), 4, 0);
                  ucDdo_pessoaid.SendProperty(context, "", false, Ddo_pessoaid_Internalname, "FilteredText_set", Ddo_pessoaid_Filteredtext_set);
               }
               if ( ! (0==AV64TFPessoaId_To) )
               {
                  Ddo_pessoaid_Filteredtextto_set = StringUtil.Str( (decimal)(AV64TFPessoaId_To), 4, 0);
                  ucDdo_pessoaid.SendProperty(context, "", false, Ddo_pessoaid_Internalname, "FilteredTextTo_set", Ddo_pessoaid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFPESSOANOME") == 0 )
            {
               AV67TFPessoaNome = AV11GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV67TFPessoaNome", AV67TFPessoaNome);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV67TFPessoaNome)) )
               {
                  Ddo_pessoanome_Filteredtext_set = AV67TFPessoaNome;
                  ucDdo_pessoanome.SendProperty(context, "", false, Ddo_pessoanome_Internalname, "FilteredText_set", Ddo_pessoanome_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFPESSOANOME_SEL") == 0 )
            {
               AV68TFPessoaNome_Sel = AV11GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV68TFPessoaNome_Sel", AV68TFPessoaNome_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV68TFPessoaNome_Sel)) )
               {
                  Ddo_pessoanome_Selectedvalue_set = AV68TFPessoaNome_Sel;
                  ucDdo_pessoanome.SendProperty(context, "", false, Ddo_pessoanome_Internalname, "SelectedValue_set", Ddo_pessoanome_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFPEDIDODT") == 0 )
            {
               AV71TFPedidoDt = context.localUtil.CToD( AV11GridStateFilterValue.gxTpr_Value, 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV71TFPedidoDt", context.localUtil.Format(AV71TFPedidoDt, "99/99/99"));
               AV72TFPedidoDt_To = context.localUtil.CToD( AV11GridStateFilterValue.gxTpr_Valueto, 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV72TFPedidoDt_To", context.localUtil.Format(AV72TFPedidoDt_To, "99/99/99"));
               if ( ! (DateTime.MinValue==AV71TFPedidoDt) )
               {
                  Ddo_pedidodt_Filteredtext_set = context.localUtil.DToC( AV71TFPedidoDt, 2, "/");
                  ucDdo_pedidodt.SendProperty(context, "", false, Ddo_pedidodt_Internalname, "FilteredText_set", Ddo_pedidodt_Filteredtext_set);
               }
               if ( ! (DateTime.MinValue==AV72TFPedidoDt_To) )
               {
                  Ddo_pedidodt_Filteredtextto_set = context.localUtil.DToC( AV72TFPedidoDt_To, 2, "/");
                  ucDdo_pedidodt.SendProperty(context, "", false, Ddo_pedidodt_Internalname, "FilteredTextTo_set", Ddo_pedidodt_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFPEDIDOSTATUS_SEL") == 0 )
            {
               AV77TFPedidoStatus_SelsJson = AV11GridStateFilterValue.gxTpr_Value;
               AV78TFPedidoStatus_Sels.FromJSonString(AV77TFPedidoStatus_SelsJson, null);
               if ( ! ( AV78TFPedidoStatus_Sels.Count == 0 ) )
               {
                  Ddo_pedidostatus_Selectedvalue_set = AV77TFPedidoStatus_SelsJson;
                  ucDdo_pedidostatus.SendProperty(context, "", false, Ddo_pedidostatus_Internalname, "SelectedValue_set", Ddo_pedidostatus_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFPEDIDODTENTREGA") == 0 )
            {
               AV81TFPedidoDtEntrega = context.localUtil.CToD( AV11GridStateFilterValue.gxTpr_Value, 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV81TFPedidoDtEntrega", context.localUtil.Format(AV81TFPedidoDtEntrega, "99/99/99"));
               AV82TFPedidoDtEntrega_To = context.localUtil.CToD( AV11GridStateFilterValue.gxTpr_Valueto, 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV82TFPedidoDtEntrega_To", context.localUtil.Format(AV82TFPedidoDtEntrega_To, "99/99/99"));
               if ( ! (DateTime.MinValue==AV81TFPedidoDtEntrega) )
               {
                  Ddo_pedidodtentrega_Filteredtext_set = context.localUtil.DToC( AV81TFPedidoDtEntrega, 2, "/");
                  ucDdo_pedidodtentrega.SendProperty(context, "", false, Ddo_pedidodtentrega_Internalname, "FilteredText_set", Ddo_pedidodtentrega_Filteredtext_set);
               }
               if ( ! (DateTime.MinValue==AV82TFPedidoDtEntrega_To) )
               {
                  Ddo_pedidodtentrega_Filteredtextto_set = context.localUtil.DToC( AV82TFPedidoDtEntrega_To, 2, "/");
                  ucDdo_pedidodtentrega.SendProperty(context, "", false, Ddo_pedidodtentrega_Internalname, "FilteredTextTo_set", Ddo_pedidodtentrega_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFPEDIDORETIRADA_SEL") == 0 )
            {
               AV87TFPedidoRetirada_Sel = (short)(NumberUtil.Val( AV11GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV87TFPedidoRetirada_Sel", StringUtil.Str( (decimal)(AV87TFPedidoRetirada_Sel), 1, 0));
               if ( ! (0==AV87TFPedidoRetirada_Sel) )
               {
                  Ddo_pedidoretirada_Selectedvalue_set = StringUtil.Str( (decimal)(AV87TFPedidoRetirada_Sel), 1, 0);
                  ucDdo_pedidoretirada.SendProperty(context, "", false, Ddo_pedidoretirada_Internalname, "SelectedValue_set", Ddo_pedidoretirada_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFPEDIDOTOTAL") == 0 )
            {
               AV90TFPedidoTotal = NumberUtil.Val( AV11GridStateFilterValue.gxTpr_Value, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV90TFPedidoTotal", StringUtil.LTrim( StringUtil.Str( AV90TFPedidoTotal, 12, 2)));
               AV91TFPedidoTotal_To = NumberUtil.Val( AV11GridStateFilterValue.gxTpr_Valueto, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV91TFPedidoTotal_To", StringUtil.LTrim( StringUtil.Str( AV91TFPedidoTotal_To, 12, 2)));
               if ( ! (Convert.ToDecimal(0)==AV90TFPedidoTotal) )
               {
                  Ddo_pedidototal_Filteredtext_set = StringUtil.Str( AV90TFPedidoTotal, 12, 2);
                  ucDdo_pedidototal.SendProperty(context, "", false, Ddo_pedidototal_Internalname, "FilteredText_set", Ddo_pedidototal_Filteredtext_set);
               }
               if ( ! (Convert.ToDecimal(0)==AV91TFPedidoTotal_To) )
               {
                  Ddo_pedidototal_Filteredtextto_set = StringUtil.Str( AV91TFPedidoTotal_To, 12, 2);
                  ucDdo_pedidototal.SendProperty(context, "", false, Ddo_pedidototal_Internalname, "FilteredTextTo_set", Ddo_pedidototal_Filteredtextto_set);
               }
            }
            AV132GXV2 = (int)(AV132GXV2+1);
         }
      }

      protected void S232( )
      {
         /* 'LOADDYNFILTERSSTATE' Routine */
         imgAdddynamicfilters1_Visible = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgAdddynamicfilters1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgAdddynamicfilters1_Visible), 5, 0)), true);
         imgRemovedynamicfilters1_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgRemovedynamicfilters1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgRemovedynamicfilters1_Visible), 5, 0)), true);
         imgAdddynamicfilters2_Visible = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgAdddynamicfilters2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgAdddynamicfilters2_Visible), 5, 0)), true);
         imgRemovedynamicfilters2_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgRemovedynamicfilters2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgRemovedynamicfilters2_Visible), 5, 0)), true);
         if ( AV10GridState.gxTpr_Dynamicfilters.Count >= 1 )
         {
            AV12GridStateDynamicFilter = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter)AV10GridState.gxTpr_Dynamicfilters.Item(1));
            AV16DynamicFiltersSelector1 = AV12GridStateDynamicFilter.gxTpr_Selected;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16DynamicFiltersSelector1", AV16DynamicFiltersSelector1);
            if ( StringUtil.StrCmp(AV16DynamicFiltersSelector1, "PEDIDODT") == 0 )
            {
               AV17DynamicFiltersOperator1 = AV12GridStateDynamicFilter.gxTpr_Operator;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17DynamicFiltersOperator1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17DynamicFiltersOperator1), 4, 0)));
               AV18PedidoDt1 = context.localUtil.CToD( AV12GridStateDynamicFilter.gxTpr_Value, 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18PedidoDt1", context.localUtil.Format(AV18PedidoDt1, "99/99/99"));
               AV19PedidoDt_To1 = context.localUtil.CToD( AV12GridStateDynamicFilter.gxTpr_Valueto, 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19PedidoDt_To1", context.localUtil.Format(AV19PedidoDt_To1, "99/99/99"));
            }
            /* Execute user subroutine: 'ENABLEDYNAMICFILTERS1' */
            S122 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            if ( AV10GridState.gxTpr_Dynamicfilters.Count >= 2 )
            {
               lblJsdynamicfilters_Caption = "<script type=\"text/javascript\">";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblJsdynamicfilters_Internalname, "Caption", lblJsdynamicfilters_Caption, true);
               lblJsdynamicfilters_Caption = lblJsdynamicfilters_Caption+StringUtil.Format( "WWPDynFilterShow_AL('%1', 2, 0);", tblTabledynamicfilters_Internalname, "", "", "", "", "", "", "", "");
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblJsdynamicfilters_Internalname, "Caption", lblJsdynamicfilters_Caption, true);
               imgAdddynamicfilters1_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgAdddynamicfilters1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgAdddynamicfilters1_Visible), 5, 0)), true);
               imgRemovedynamicfilters1_Visible = 1;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgRemovedynamicfilters1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgRemovedynamicfilters1_Visible), 5, 0)), true);
               AV20DynamicFiltersEnabled2 = true;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20DynamicFiltersEnabled2", AV20DynamicFiltersEnabled2);
               AV12GridStateDynamicFilter = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter)AV10GridState.gxTpr_Dynamicfilters.Item(2));
               AV21DynamicFiltersSelector2 = AV12GridStateDynamicFilter.gxTpr_Selected;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21DynamicFiltersSelector2", AV21DynamicFiltersSelector2);
               if ( StringUtil.StrCmp(AV21DynamicFiltersSelector2, "PEDIDODT") == 0 )
               {
                  AV22DynamicFiltersOperator2 = AV12GridStateDynamicFilter.gxTpr_Operator;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22DynamicFiltersOperator2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22DynamicFiltersOperator2), 4, 0)));
                  AV23PedidoDt2 = context.localUtil.CToD( AV12GridStateDynamicFilter.gxTpr_Value, 2);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23PedidoDt2", context.localUtil.Format(AV23PedidoDt2, "99/99/99"));
                  AV24PedidoDt_To2 = context.localUtil.CToD( AV12GridStateDynamicFilter.gxTpr_Valueto, 2);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24PedidoDt_To2", context.localUtil.Format(AV24PedidoDt_To2, "99/99/99"));
               }
               /* Execute user subroutine: 'ENABLEDYNAMICFILTERS2' */
               S132 ();
               if ( returnInSub )
               {
                  returnInSub = true;
                  if (true) return;
               }
               if ( AV10GridState.gxTpr_Dynamicfilters.Count >= 3 )
               {
                  lblJsdynamicfilters_Caption = lblJsdynamicfilters_Caption+StringUtil.Format( "WWPDynFilterShow_AL('%1', 3, 0);", tblTabledynamicfilters_Internalname, "", "", "", "", "", "", "", "");
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblJsdynamicfilters_Internalname, "Caption", lblJsdynamicfilters_Caption, true);
                  imgAdddynamicfilters2_Visible = 0;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgAdddynamicfilters2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgAdddynamicfilters2_Visible), 5, 0)), true);
                  imgRemovedynamicfilters2_Visible = 1;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgRemovedynamicfilters2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgRemovedynamicfilters2_Visible), 5, 0)), true);
                  AV25DynamicFiltersEnabled3 = true;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25DynamicFiltersEnabled3", AV25DynamicFiltersEnabled3);
                  AV12GridStateDynamicFilter = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter)AV10GridState.gxTpr_Dynamicfilters.Item(3));
                  AV26DynamicFiltersSelector3 = AV12GridStateDynamicFilter.gxTpr_Selected;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26DynamicFiltersSelector3", AV26DynamicFiltersSelector3);
                  if ( StringUtil.StrCmp(AV26DynamicFiltersSelector3, "PEDIDODT") == 0 )
                  {
                     AV27DynamicFiltersOperator3 = AV12GridStateDynamicFilter.gxTpr_Operator;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27DynamicFiltersOperator3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV27DynamicFiltersOperator3), 4, 0)));
                     AV28PedidoDt3 = context.localUtil.CToD( AV12GridStateDynamicFilter.gxTpr_Value, 2);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28PedidoDt3", context.localUtil.Format(AV28PedidoDt3, "99/99/99"));
                     AV29PedidoDt_To3 = context.localUtil.CToD( AV12GridStateDynamicFilter.gxTpr_Valueto, 2);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29PedidoDt_To3", context.localUtil.Format(AV29PedidoDt_To3, "99/99/99"));
                  }
                  /* Execute user subroutine: 'ENABLEDYNAMICFILTERS3' */
                  S142 ();
                  if ( returnInSub )
                  {
                     returnInSub = true;
                     if (true) return;
                  }
               }
               lblJsdynamicfilters_Caption = lblJsdynamicfilters_Caption+"</script>";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblJsdynamicfilters_Internalname, "Caption", lblJsdynamicfilters_Caption, true);
            }
         }
         if ( AV30DynamicFiltersRemoving )
         {
            lblJsdynamicfilters_Caption = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblJsdynamicfilters_Internalname, "Caption", lblJsdynamicfilters_Caption, true);
         }
      }

      protected void S182( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV10GridState.FromXml(AV51Session.Get(AV129Pgmname+"GridState"), null, "WWPGridState", "FMX");
         AV10GridState.gxTpr_Orderedby = AV13OrderedBy;
         AV10GridState.gxTpr_Ordereddsc = AV14OrderedDsc;
         AV10GridState.gxTpr_Filtervalues.Clear();
         if ( ! ( (0==AV59TFPedidoId) && (0==AV60TFPedidoId_To) ) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFPEDIDOID";
            AV11GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV59TFPedidoId), 4, 0);
            AV11GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV60TFPedidoId_To), 4, 0);
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! ( (0==AV63TFPessoaId) && (0==AV64TFPessoaId_To) ) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFPESSOAID";
            AV11GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV63TFPessoaId), 4, 0);
            AV11GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV64TFPessoaId_To), 4, 0);
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV67TFPessoaNome)) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFPESSOANOME";
            AV11GridStateFilterValue.gxTpr_Value = AV67TFPessoaNome;
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV68TFPessoaNome_Sel)) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFPESSOANOME_SEL";
            AV11GridStateFilterValue.gxTpr_Value = AV68TFPessoaNome_Sel;
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! ( (DateTime.MinValue==AV71TFPedidoDt) && (DateTime.MinValue==AV72TFPedidoDt_To) ) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFPEDIDODT";
            AV11GridStateFilterValue.gxTpr_Value = context.localUtil.DToC( AV71TFPedidoDt, 2, "/");
            AV11GridStateFilterValue.gxTpr_Valueto = context.localUtil.DToC( AV72TFPedidoDt_To, 2, "/");
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! ( AV78TFPedidoStatus_Sels.Count == 0 ) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFPEDIDOSTATUS_SEL";
            AV11GridStateFilterValue.gxTpr_Value = AV78TFPedidoStatus_Sels.ToJSonString(false);
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! ( (DateTime.MinValue==AV81TFPedidoDtEntrega) && (DateTime.MinValue==AV82TFPedidoDtEntrega_To) ) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFPEDIDODTENTREGA";
            AV11GridStateFilterValue.gxTpr_Value = context.localUtil.DToC( AV81TFPedidoDtEntrega, 2, "/");
            AV11GridStateFilterValue.gxTpr_Valueto = context.localUtil.DToC( AV82TFPedidoDtEntrega_To, 2, "/");
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! (0==AV87TFPedidoRetirada_Sel) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFPEDIDORETIRADA_SEL";
            AV11GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV87TFPedidoRetirada_Sel), 1, 0);
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! ( (Convert.ToDecimal(0)==AV90TFPedidoTotal) && (Convert.ToDecimal(0)==AV91TFPedidoTotal_To) ) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFPEDIDOTOTAL";
            AV11GridStateFilterValue.gxTpr_Value = StringUtil.Str( AV90TFPedidoTotal, 12, 2);
            AV11GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( AV91TFPedidoTotal_To, 12, 2);
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         /* Execute user subroutine: 'SAVEDYNFILTERSSTATE' */
         S212 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV10GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV10GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV129Pgmname+"GridState",  AV10GridState.ToXml(false, true, "WWPGridState", "FMX")) ;
      }

      protected void S212( )
      {
         /* 'SAVEDYNFILTERSSTATE' Routine */
         AV10GridState.gxTpr_Dynamicfilters.Clear();
         if ( ! AV31DynamicFiltersIgnoreFirst )
         {
            AV12GridStateDynamicFilter = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter(context);
            AV12GridStateDynamicFilter.gxTpr_Selected = AV16DynamicFiltersSelector1;
            if ( ( StringUtil.StrCmp(AV16DynamicFiltersSelector1, "PEDIDODT") == 0 ) && ! ( (DateTime.MinValue==AV18PedidoDt1) && (DateTime.MinValue==AV19PedidoDt_To1) ) )
            {
               AV12GridStateDynamicFilter.gxTpr_Value = context.localUtil.DToC( AV18PedidoDt1, 2, "/");
               AV12GridStateDynamicFilter.gxTpr_Operator = AV17DynamicFiltersOperator1;
               AV12GridStateDynamicFilter.gxTpr_Valueto = context.localUtil.DToC( AV19PedidoDt_To1, 2, "/");
            }
            if ( AV30DynamicFiltersRemoving || ! String.IsNullOrEmpty(StringUtil.RTrim( AV12GridStateDynamicFilter.gxTpr_Value)) || ! String.IsNullOrEmpty(StringUtil.RTrim( AV12GridStateDynamicFilter.gxTpr_Valueto)) )
            {
               AV10GridState.gxTpr_Dynamicfilters.Add(AV12GridStateDynamicFilter, 0);
            }
         }
         if ( AV20DynamicFiltersEnabled2 )
         {
            AV12GridStateDynamicFilter = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter(context);
            AV12GridStateDynamicFilter.gxTpr_Selected = AV21DynamicFiltersSelector2;
            if ( ( StringUtil.StrCmp(AV21DynamicFiltersSelector2, "PEDIDODT") == 0 ) && ! ( (DateTime.MinValue==AV23PedidoDt2) && (DateTime.MinValue==AV24PedidoDt_To2) ) )
            {
               AV12GridStateDynamicFilter.gxTpr_Value = context.localUtil.DToC( AV23PedidoDt2, 2, "/");
               AV12GridStateDynamicFilter.gxTpr_Operator = AV22DynamicFiltersOperator2;
               AV12GridStateDynamicFilter.gxTpr_Valueto = context.localUtil.DToC( AV24PedidoDt_To2, 2, "/");
            }
            if ( AV30DynamicFiltersRemoving || ! String.IsNullOrEmpty(StringUtil.RTrim( AV12GridStateDynamicFilter.gxTpr_Value)) || ! String.IsNullOrEmpty(StringUtil.RTrim( AV12GridStateDynamicFilter.gxTpr_Valueto)) )
            {
               AV10GridState.gxTpr_Dynamicfilters.Add(AV12GridStateDynamicFilter, 0);
            }
         }
         if ( AV25DynamicFiltersEnabled3 )
         {
            AV12GridStateDynamicFilter = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter(context);
            AV12GridStateDynamicFilter.gxTpr_Selected = AV26DynamicFiltersSelector3;
            if ( ( StringUtil.StrCmp(AV26DynamicFiltersSelector3, "PEDIDODT") == 0 ) && ! ( (DateTime.MinValue==AV28PedidoDt3) && (DateTime.MinValue==AV29PedidoDt_To3) ) )
            {
               AV12GridStateDynamicFilter.gxTpr_Value = context.localUtil.DToC( AV28PedidoDt3, 2, "/");
               AV12GridStateDynamicFilter.gxTpr_Operator = AV27DynamicFiltersOperator3;
               AV12GridStateDynamicFilter.gxTpr_Valueto = context.localUtil.DToC( AV29PedidoDt_To3, 2, "/");
            }
            if ( AV30DynamicFiltersRemoving || ! String.IsNullOrEmpty(StringUtil.RTrim( AV12GridStateDynamicFilter.gxTpr_Value)) || ! String.IsNullOrEmpty(StringUtil.RTrim( AV12GridStateDynamicFilter.gxTpr_Valueto)) )
            {
               AV10GridState.gxTpr_Dynamicfilters.Add(AV12GridStateDynamicFilter, 0);
            }
         }
      }

      protected void S152( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV8TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV8TrnContext.gxTpr_Callerobject = AV129Pgmname;
         AV8TrnContext.gxTpr_Callerondelete = true;
         AV8TrnContext.gxTpr_Callerurl = AV7HTTPRequest.ScriptName+"?"+AV7HTTPRequest.QueryString;
         AV8TrnContext.gxTpr_Transactionname = "Pedido";
         AV51Session.Set("TrnContext", AV8TrnContext.ToXml(false, true, "WWPTransactionContext", "FMX"));
      }

      protected void wb_table1_23_182( bool wbgen )
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
            wb_table2_28_182( true) ;
         }
         else
         {
            wb_table2_28_182( false) ;
         }
         return  ;
      }

      protected void wb_table2_28_182e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_23_182e( true) ;
         }
         else
         {
            wb_table1_23_182e( false) ;
         }
      }

      protected void wb_table2_28_182( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablefilters_Internalname, tblTablefilters_Internalname, "", "", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table3_31_182( true) ;
         }
         else
         {
            wb_table3_31_182( false) ;
         }
         return  ;
      }

      protected void wb_table3_31_182e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_28_182e( true) ;
         }
         else
         {
            wb_table2_28_182e( false) ;
         }
      }

      protected void wb_table3_31_182( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTabledynamicfilters_Internalname, tblTabledynamicfilters_Internalname, "", "TableDynamicFilters", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersprefix1_Internalname, "Filtrar por", "", "", lblDynamicfiltersprefix1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescriptionPrefix", 0, "", 1, 1, 0, "HLP_WP_GerenciarPedido.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavDynamicfiltersselector1_Internalname, "Dynamic Filters Selector1", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'" + sGXsfl_134_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersselector1, cmbavDynamicfiltersselector1_Internalname, StringUtil.RTrim( AV16DynamicFiltersSelector1), 1, cmbavDynamicfiltersselector1_Jsonclick, 5, "'"+""+"'"+",false,"+"'"+"EVDYNAMICFILTERSSELECTOR1.CLICK."+"'", "svchar", "", 1, cmbavDynamicfiltersselector1.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,37);\"", "", true, "HLP_WP_GerenciarPedido.htm");
            cmbavDynamicfiltersselector1.CurrentValue = StringUtil.RTrim( AV16DynamicFiltersSelector1);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector1_Internalname, "Values", (String)(cmbavDynamicfiltersselector1.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersmiddle1_Internalname, "valor", "", "", lblDynamicfiltersmiddle1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescription", 0, "", 1, 1, 0, "HLP_WP_GerenciarPedido.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table4_41_182( true) ;
         }
         else
         {
            wb_table4_41_182( false) ;
         }
         return  ;
      }

      protected void wb_table4_41_182e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table5_58_182( true) ;
         }
         else
         {
            wb_table5_58_182( false) ;
         }
         return  ;
      }

      protected void wb_table5_58_182e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersprefix2_Internalname, "Filtrar por", "", "", lblDynamicfiltersprefix2_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescriptionPrefix", 0, "", 1, 1, 0, "HLP_WP_GerenciarPedido.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavDynamicfiltersselector2_Internalname, "Dynamic Filters Selector2", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'" + sGXsfl_134_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersselector2, cmbavDynamicfiltersselector2_Internalname, StringUtil.RTrim( AV21DynamicFiltersSelector2), 1, cmbavDynamicfiltersselector2_Jsonclick, 5, "'"+""+"'"+",false,"+"'"+"EVDYNAMICFILTERSSELECTOR2.CLICK."+"'", "svchar", "", 1, cmbavDynamicfiltersselector2.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,69);\"", "", true, "HLP_WP_GerenciarPedido.htm");
            cmbavDynamicfiltersselector2.CurrentValue = StringUtil.RTrim( AV21DynamicFiltersSelector2);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector2_Internalname, "Values", (String)(cmbavDynamicfiltersselector2.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersmiddle2_Internalname, "valor", "", "", lblDynamicfiltersmiddle2_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescription", 0, "", 1, 1, 0, "HLP_WP_GerenciarPedido.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            wb_table6_73_182( true) ;
         }
         else
         {
            wb_table6_73_182( false) ;
         }
         return  ;
      }

      protected void wb_table6_73_182e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            wb_table7_90_182( true) ;
         }
         else
         {
            wb_table7_90_182( false) ;
         }
         return  ;
      }

      protected void wb_table7_90_182e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersprefix3_Internalname, "Filtrar por", "", "", lblDynamicfiltersprefix3_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescriptionPrefix", 0, "", 1, 1, 0, "HLP_WP_GerenciarPedido.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavDynamicfiltersselector3_Internalname, "Dynamic Filters Selector3", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 101,'',false,'" + sGXsfl_134_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersselector3, cmbavDynamicfiltersselector3_Internalname, StringUtil.RTrim( AV26DynamicFiltersSelector3), 1, cmbavDynamicfiltersselector3_Jsonclick, 5, "'"+""+"'"+",false,"+"'"+"EVDYNAMICFILTERSSELECTOR3.CLICK."+"'", "svchar", "", 1, cmbavDynamicfiltersselector3.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,101);\"", "", true, "HLP_WP_GerenciarPedido.htm");
            cmbavDynamicfiltersselector3.CurrentValue = StringUtil.RTrim( AV26DynamicFiltersSelector3);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector3_Internalname, "Values", (String)(cmbavDynamicfiltersselector3.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersmiddle3_Internalname, "valor", "", "", lblDynamicfiltersmiddle3_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescription", 0, "", 1, 1, 0, "HLP_WP_GerenciarPedido.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            wb_table8_105_182( true) ;
         }
         else
         {
            wb_table8_105_182( false) ;
         }
         return  ;
      }

      protected void wb_table8_105_182e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            wb_table9_122_182( true) ;
         }
         else
         {
            wb_table9_122_182( false) ;
         }
         return  ;
      }

      protected void wb_table9_122_182e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_31_182e( true) ;
         }
         else
         {
            wb_table3_31_182e( false) ;
         }
      }

      protected void wb_table9_122_182( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblUnnamedtabledynamicfilters_3_Internalname, tblUnnamedtabledynamicfilters_3_Internalname, "", "Table", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\""+cellDynamicfilters_removefilter3_cell_Internalname+"\"  class=''>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 125,'',false,'',0)\"";
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "11a6ef14-1a5a-4077-91a2-f41ed9a3a662", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgRemovedynamicfilters3_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "Remover filtro", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgRemovedynamicfilters3_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'REMOVEDYNAMICFILTERS3\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_WP_GerenciarPedido.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table9_122_182e( true) ;
         }
         else
         {
            wb_table9_122_182e( false) ;
         }
      }

      protected void wb_table8_105_182( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergeddynamicfilters3_Internalname, tblTablemergeddynamicfilters3_Internalname, "", "Table", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavDynamicfiltersoperator3_Internalname, "Dynamic Filters Operator3", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 109,'',false,'" + sGXsfl_134_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersoperator3, cmbavDynamicfiltersoperator3_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV27DynamicFiltersOperator3), 4, 0)), 1, cmbavDynamicfiltersoperator3_Jsonclick, 5, "'"+""+"'"+",false,"+"'"+"EVDYNAMICFILTERSOPERATOR3.CLICK."+"'", "int", "", cmbavDynamicfiltersoperator3.Visible, cmbavDynamicfiltersoperator3.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,109);\"", "", true, "HLP_WP_GerenciarPedido.htm");
            cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV27DynamicFiltersOperator3), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", (String)(cmbavDynamicfiltersoperator3.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellFilter_pedidodt3_cell_Internalname+"\"  class=''>") ;
            wb_table10_111_182( true) ;
         }
         else
         {
            wb_table10_111_182( false) ;
         }
         return  ;
      }

      protected void wb_table10_111_182e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table8_105_182e( true) ;
         }
         else
         {
            wb_table8_105_182e( false) ;
         }
      }

      protected void wb_table10_111_182( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            if ( tblTablemergeddynamicfilterspedidodt3_Visible == 0 )
            {
               sStyleString = sStyleString + "display:none;";
            }
            GxWebStd.gx_table_start( context, tblTablemergeddynamicfilterspedidodt3_Internalname, tblTablemergeddynamicfilterspedidodt3_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\""+cellPedidodt_cell3_Internalname+"\"  class='"+cellPedidodt_cell3_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavPedidodt3_Internalname, "Pedido Dt3", "col-sm-3 AttributeDateLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 115,'',false,'" + sGXsfl_134_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavPedidodt3_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavPedidodt3_Internalname, context.localUtil.Format(AV28PedidoDt3, "99/99/99"), context.localUtil.Format( AV28PedidoDt3, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,115);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPedidodt3_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavPedidodt3_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WP_GerenciarPedido.htm");
            GxWebStd.gx_bitmap( context, edtavPedidodt3_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavPedidodt3_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_WP_GerenciarPedido.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellPedidodt_rangemiddletext_1_cell3_Internalname+"\"  class=''>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblPedidodt_rangemiddletext_13_Internalname, "até", "", "", lblPedidodt_rangemiddletext_13_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", lblPedidodt_rangemiddletext_13_Class, 0, "", 1, 1, 0, "HLP_WP_GerenciarPedido.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellPedidodt_to_cell3_Internalname+"\"  class='"+cellPedidodt_to_cell3_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavPedidodt_to3_Internalname, "Pedido Dt_To3", "col-sm-3 AttributeDateLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 120,'',false,'" + sGXsfl_134_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavPedidodt_to3_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavPedidodt_to3_Internalname, context.localUtil.Format(AV29PedidoDt_To3, "99/99/99"), context.localUtil.Format( AV29PedidoDt_To3, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,120);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPedidodt_to3_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavPedidodt_to3_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WP_GerenciarPedido.htm");
            GxWebStd.gx_bitmap( context, edtavPedidodt_to3_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavPedidodt_to3_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_WP_GerenciarPedido.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table10_111_182e( true) ;
         }
         else
         {
            wb_table10_111_182e( false) ;
         }
      }

      protected void wb_table7_90_182( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblUnnamedtabledynamicfilters_2_Internalname, tblUnnamedtabledynamicfilters_2_Internalname, "", "Table", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\""+cellDynamicfilters_addfilter2_cell_Internalname+"\"  class=''>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 93,'',false,'',0)\"";
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "27283ea5-332f-423b-b880-64b762622df3", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgAdddynamicfilters2_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgAdddynamicfilters2_Visible, 1, "", "Adicionar filtro", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgAdddynamicfilters2_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'ADDDYNAMICFILTERS2\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_WP_GerenciarPedido.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellDynamicfilters_removefilter2_cell_Internalname+"\"  class=''>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 95,'',false,'',0)\"";
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "11a6ef14-1a5a-4077-91a2-f41ed9a3a662", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgRemovedynamicfilters2_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgRemovedynamicfilters2_Visible, 1, "", "Remover filtro", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgRemovedynamicfilters2_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'REMOVEDYNAMICFILTERS2\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_WP_GerenciarPedido.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table7_90_182e( true) ;
         }
         else
         {
            wb_table7_90_182e( false) ;
         }
      }

      protected void wb_table6_73_182( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergeddynamicfilters2_Internalname, tblTablemergeddynamicfilters2_Internalname, "", "Table", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavDynamicfiltersoperator2_Internalname, "Dynamic Filters Operator2", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'" + sGXsfl_134_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersoperator2, cmbavDynamicfiltersoperator2_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV22DynamicFiltersOperator2), 4, 0)), 1, cmbavDynamicfiltersoperator2_Jsonclick, 5, "'"+""+"'"+",false,"+"'"+"EVDYNAMICFILTERSOPERATOR2.CLICK."+"'", "int", "", cmbavDynamicfiltersoperator2.Visible, cmbavDynamicfiltersoperator2.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,77);\"", "", true, "HLP_WP_GerenciarPedido.htm");
            cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV22DynamicFiltersOperator2), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", (String)(cmbavDynamicfiltersoperator2.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellFilter_pedidodt2_cell_Internalname+"\"  class=''>") ;
            wb_table11_79_182( true) ;
         }
         else
         {
            wb_table11_79_182( false) ;
         }
         return  ;
      }

      protected void wb_table11_79_182e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table6_73_182e( true) ;
         }
         else
         {
            wb_table6_73_182e( false) ;
         }
      }

      protected void wb_table11_79_182( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            if ( tblTablemergeddynamicfilterspedidodt2_Visible == 0 )
            {
               sStyleString = sStyleString + "display:none;";
            }
            GxWebStd.gx_table_start( context, tblTablemergeddynamicfilterspedidodt2_Internalname, tblTablemergeddynamicfilterspedidodt2_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\""+cellPedidodt_cell2_Internalname+"\"  class='"+cellPedidodt_cell2_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavPedidodt2_Internalname, "Pedido Dt2", "col-sm-3 AttributeDateLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'" + sGXsfl_134_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavPedidodt2_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavPedidodt2_Internalname, context.localUtil.Format(AV23PedidoDt2, "99/99/99"), context.localUtil.Format( AV23PedidoDt2, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,83);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPedidodt2_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavPedidodt2_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WP_GerenciarPedido.htm");
            GxWebStd.gx_bitmap( context, edtavPedidodt2_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavPedidodt2_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_WP_GerenciarPedido.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellPedidodt_rangemiddletext_1_cell2_Internalname+"\"  class=''>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblPedidodt_rangemiddletext_12_Internalname, "até", "", "", lblPedidodt_rangemiddletext_12_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", lblPedidodt_rangemiddletext_12_Class, 0, "", 1, 1, 0, "HLP_WP_GerenciarPedido.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellPedidodt_to_cell2_Internalname+"\"  class='"+cellPedidodt_to_cell2_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavPedidodt_to2_Internalname, "Pedido Dt_To2", "col-sm-3 AttributeDateLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 88,'',false,'" + sGXsfl_134_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavPedidodt_to2_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavPedidodt_to2_Internalname, context.localUtil.Format(AV24PedidoDt_To2, "99/99/99"), context.localUtil.Format( AV24PedidoDt_To2, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,88);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPedidodt_to2_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavPedidodt_to2_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WP_GerenciarPedido.htm");
            GxWebStd.gx_bitmap( context, edtavPedidodt_to2_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavPedidodt_to2_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_WP_GerenciarPedido.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table11_79_182e( true) ;
         }
         else
         {
            wb_table11_79_182e( false) ;
         }
      }

      protected void wb_table5_58_182( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblUnnamedtabledynamicfilters_1_Internalname, tblUnnamedtabledynamicfilters_1_Internalname, "", "Table", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\""+cellDynamicfilters_addfilter1_cell_Internalname+"\"  class=''>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'',0)\"";
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "27283ea5-332f-423b-b880-64b762622df3", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgAdddynamicfilters1_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgAdddynamicfilters1_Visible, 1, "", "Adicionar filtro", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgAdddynamicfilters1_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'ADDDYNAMICFILTERS1\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_WP_GerenciarPedido.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellDynamicfilters_removefilter1_cell_Internalname+"\"  class=''>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"";
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "11a6ef14-1a5a-4077-91a2-f41ed9a3a662", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgRemovedynamicfilters1_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgRemovedynamicfilters1_Visible, 1, "", "Remover filtro", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgRemovedynamicfilters1_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'REMOVEDYNAMICFILTERS1\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_WP_GerenciarPedido.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_58_182e( true) ;
         }
         else
         {
            wb_table5_58_182e( false) ;
         }
      }

      protected void wb_table4_41_182( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergeddynamicfilters1_Internalname, tblTablemergeddynamicfilters1_Internalname, "", "Table", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavDynamicfiltersoperator1_Internalname, "Dynamic Filters Operator1", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'" + sGXsfl_134_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersoperator1, cmbavDynamicfiltersoperator1_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV17DynamicFiltersOperator1), 4, 0)), 1, cmbavDynamicfiltersoperator1_Jsonclick, 5, "'"+""+"'"+",false,"+"'"+"EVDYNAMICFILTERSOPERATOR1.CLICK."+"'", "int", "", cmbavDynamicfiltersoperator1.Visible, cmbavDynamicfiltersoperator1.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,45);\"", "", true, "HLP_WP_GerenciarPedido.htm");
            cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV17DynamicFiltersOperator1), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", (String)(cmbavDynamicfiltersoperator1.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellFilter_pedidodt1_cell_Internalname+"\"  class=''>") ;
            wb_table12_47_182( true) ;
         }
         else
         {
            wb_table12_47_182( false) ;
         }
         return  ;
      }

      protected void wb_table12_47_182e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_41_182e( true) ;
         }
         else
         {
            wb_table4_41_182e( false) ;
         }
      }

      protected void wb_table12_47_182( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            if ( tblTablemergeddynamicfilterspedidodt1_Visible == 0 )
            {
               sStyleString = sStyleString + "display:none;";
            }
            GxWebStd.gx_table_start( context, tblTablemergeddynamicfilterspedidodt1_Internalname, tblTablemergeddynamicfilterspedidodt1_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\""+cellPedidodt_cell1_Internalname+"\"  class='"+cellPedidodt_cell1_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavPedidodt1_Internalname, "Pedido Dt1", "col-sm-3 AttributeDateLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'" + sGXsfl_134_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavPedidodt1_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavPedidodt1_Internalname, context.localUtil.Format(AV18PedidoDt1, "99/99/99"), context.localUtil.Format( AV18PedidoDt1, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,51);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPedidodt1_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavPedidodt1_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WP_GerenciarPedido.htm");
            GxWebStd.gx_bitmap( context, edtavPedidodt1_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavPedidodt1_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_WP_GerenciarPedido.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellPedidodt_rangemiddletext_1_cell1_Internalname+"\"  class=''>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblPedidodt_rangemiddletext_11_Internalname, "até", "", "", lblPedidodt_rangemiddletext_11_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", lblPedidodt_rangemiddletext_11_Class, 0, "", 1, 1, 0, "HLP_WP_GerenciarPedido.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellPedidodt_to_cell1_Internalname+"\"  class='"+cellPedidodt_to_cell1_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavPedidodt_to1_Internalname, "Pedido Dt_To1", "col-sm-3 AttributeDateLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_134_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavPedidodt_to1_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavPedidodt_to1_Internalname, context.localUtil.Format(AV19PedidoDt_To1, "99/99/99"), context.localUtil.Format( AV19PedidoDt_To1, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPedidodt_to1_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavPedidodt_to1_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WP_GerenciarPedido.htm");
            GxWebStd.gx_bitmap( context, edtavPedidodt_to1_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavPedidodt_to1_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_WP_GerenciarPedido.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table12_47_182e( true) ;
         }
         else
         {
            wb_table12_47_182e( false) ;
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
         PA182( ) ;
         WS182( ) ;
         WE182( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201971210543848", true, true);
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
         context.AddJavascriptSource("wp_gerenciarpedido.js", "?201971210543848", false, true);
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
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false, true);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_1342( )
      {
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_134_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_134_idx;
         edtPedidoId_Internalname = "PEDIDOID_"+sGXsfl_134_idx;
         edtPessoaId_Internalname = "PESSOAID_"+sGXsfl_134_idx;
         edtPessoaNome_Internalname = "PESSOANOME_"+sGXsfl_134_idx;
         edtPedidoDt_Internalname = "PEDIDODT_"+sGXsfl_134_idx;
         cmbPedidoStatus_Internalname = "PEDIDOSTATUS_"+sGXsfl_134_idx;
         edtPedidoDtEntrega_Internalname = "PEDIDODTENTREGA_"+sGXsfl_134_idx;
         chkPedidoRetirada_Internalname = "PEDIDORETIRADA_"+sGXsfl_134_idx;
         edtPedidoTotal_Internalname = "PEDIDOTOTAL_"+sGXsfl_134_idx;
      }

      protected void SubsflControlProps_fel_1342( )
      {
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_134_fel_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_134_fel_idx;
         edtPedidoId_Internalname = "PEDIDOID_"+sGXsfl_134_fel_idx;
         edtPessoaId_Internalname = "PESSOAID_"+sGXsfl_134_fel_idx;
         edtPessoaNome_Internalname = "PESSOANOME_"+sGXsfl_134_fel_idx;
         edtPedidoDt_Internalname = "PEDIDODT_"+sGXsfl_134_fel_idx;
         cmbPedidoStatus_Internalname = "PEDIDOSTATUS_"+sGXsfl_134_fel_idx;
         edtPedidoDtEntrega_Internalname = "PEDIDODTENTREGA_"+sGXsfl_134_fel_idx;
         chkPedidoRetirada_Internalname = "PEDIDORETIRADA_"+sGXsfl_134_fel_idx;
         edtPedidoTotal_Internalname = "PEDIDOTOTAL_"+sGXsfl_134_fel_idx;
      }

      protected void sendrow_1342( )
      {
         SubsflControlProps_1342( ) ;
         WB180( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_134_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_134_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_134_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,StringUtil.RTrim( AV97Update),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtavUpdate_Link,(String)"",(String)"Modifica",(String)"",(String)edtavUpdate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWIconActionColumn",(String)"",(short)-1,(int)edtavUpdate_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)1,(short)134,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,StringUtil.RTrim( AV98Delete),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtavDelete_Link,(String)"",(String)"Eliminar",(String)"",(String)edtavDelete_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWIconActionColumn",(String)"",(short)-1,(int)edtavDelete_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)1,(short)134,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((edtPedidoId_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPedidoId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A32PedidoId), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A32PedidoId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPedidoId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(int)edtPedidoId_Visible,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)134,(short)1,(short)-1,(short)0,(bool)true,(String)"Serial",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((edtPessoaId_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPessoaId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A1PessoaId), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A1PessoaId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPessoaId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(int)edtPessoaId_Visible,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)134,(short)1,(short)-1,(short)0,(bool)true,(String)"Serial",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((edtPessoaNome_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPessoaNome_Internalname,(String)A2PessoaNome,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPessoaNome_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(int)edtPessoaNome_Visible,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)60,(short)0,(short)0,(short)134,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((edtPedidoDt_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPedidoDt_Internalname,context.localUtil.Format(A33PedidoDt, "99/99/99"),context.localUtil.Format( A33PedidoDt, "99/99/99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtPedidoDt_Link,(String)"",(String)"",(String)"",(String)edtPedidoDt_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(int)edtPedidoDt_Visible,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)134,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((cmbPedidoStatus.Visible==0) ? "display:none;" : "")+"\">") ;
            }
            if ( ( cmbPedidoStatus.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "PEDIDOSTATUS_" + sGXsfl_134_idx;
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
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPedidoStatus_Internalname, "Values", (String)(cmbPedidoStatus.ToJavascriptSource()), !bGXsfl_134_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((edtPedidoDtEntrega_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPedidoDtEntrega_Internalname,context.localUtil.Format(A35PedidoDtEntrega, "99/99/99"),context.localUtil.Format( A35PedidoDtEntrega, "99/99/99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPedidoDtEntrega_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(int)edtPedidoDtEntrega_Visible,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)134,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
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
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPedidoTotal_Internalname,StringUtil.LTrim( StringUtil.NToC( A37PedidoTotal, 12, 2, ",", "")),context.localUtil.Format( A37PedidoTotal, "ZZZZZZZZ9.99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPedidoTotal_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(int)edtPedidoTotal_Visible,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)12,(short)0,(short)0,(short)134,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            send_integrity_lvl_hashes182( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_134_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_134_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_134_idx+1));
            sGXsfl_134_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_134_idx), 4, 0)), 4, "0");
            SubsflControlProps_1342( ) ;
         }
         /* End function sendrow_1342 */
      }

      protected void init_web_controls( )
      {
         cmbavDynamicfiltersselector1.Name = "vDYNAMICFILTERSSELECTOR1";
         cmbavDynamicfiltersselector1.WebTags = "";
         cmbavDynamicfiltersselector1.addItem("PEDIDODT", "Data do Pedido", 0);
         if ( cmbavDynamicfiltersselector1.ItemCount > 0 )
         {
            AV16DynamicFiltersSelector1 = cmbavDynamicfiltersselector1.getValidValue(AV16DynamicFiltersSelector1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16DynamicFiltersSelector1", AV16DynamicFiltersSelector1);
         }
         cmbavDynamicfiltersoperator1.Name = "vDYNAMICFILTERSOPERATOR1";
         cmbavDynamicfiltersoperator1.WebTags = "";
         cmbavDynamicfiltersoperator1.addItem("0", "Passado", 0);
         cmbavDynamicfiltersoperator1.addItem("1", "Hoje", 0);
         cmbavDynamicfiltersoperator1.addItem("2", "No futuro", 0);
         cmbavDynamicfiltersoperator1.addItem("3", "Período", 0);
         if ( cmbavDynamicfiltersoperator1.ItemCount > 0 )
         {
            AV17DynamicFiltersOperator1 = (short)(NumberUtil.Val( cmbavDynamicfiltersoperator1.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV17DynamicFiltersOperator1), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17DynamicFiltersOperator1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17DynamicFiltersOperator1), 4, 0)));
         }
         cmbavDynamicfiltersselector2.Name = "vDYNAMICFILTERSSELECTOR2";
         cmbavDynamicfiltersselector2.WebTags = "";
         cmbavDynamicfiltersselector2.addItem("PEDIDODT", "Data do Pedido", 0);
         if ( cmbavDynamicfiltersselector2.ItemCount > 0 )
         {
            AV21DynamicFiltersSelector2 = cmbavDynamicfiltersselector2.getValidValue(AV21DynamicFiltersSelector2);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21DynamicFiltersSelector2", AV21DynamicFiltersSelector2);
         }
         cmbavDynamicfiltersoperator2.Name = "vDYNAMICFILTERSOPERATOR2";
         cmbavDynamicfiltersoperator2.WebTags = "";
         cmbavDynamicfiltersoperator2.addItem("0", "Passado", 0);
         cmbavDynamicfiltersoperator2.addItem("1", "Hoje", 0);
         cmbavDynamicfiltersoperator2.addItem("2", "No futuro", 0);
         cmbavDynamicfiltersoperator2.addItem("3", "Período", 0);
         if ( cmbavDynamicfiltersoperator2.ItemCount > 0 )
         {
            AV22DynamicFiltersOperator2 = (short)(NumberUtil.Val( cmbavDynamicfiltersoperator2.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV22DynamicFiltersOperator2), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22DynamicFiltersOperator2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22DynamicFiltersOperator2), 4, 0)));
         }
         cmbavDynamicfiltersselector3.Name = "vDYNAMICFILTERSSELECTOR3";
         cmbavDynamicfiltersselector3.WebTags = "";
         cmbavDynamicfiltersselector3.addItem("PEDIDODT", "Data do Pedido", 0);
         if ( cmbavDynamicfiltersselector3.ItemCount > 0 )
         {
            AV26DynamicFiltersSelector3 = cmbavDynamicfiltersselector3.getValidValue(AV26DynamicFiltersSelector3);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26DynamicFiltersSelector3", AV26DynamicFiltersSelector3);
         }
         cmbavDynamicfiltersoperator3.Name = "vDYNAMICFILTERSOPERATOR3";
         cmbavDynamicfiltersoperator3.WebTags = "";
         cmbavDynamicfiltersoperator3.addItem("0", "Passado", 0);
         cmbavDynamicfiltersoperator3.addItem("1", "Hoje", 0);
         cmbavDynamicfiltersoperator3.addItem("2", "No futuro", 0);
         cmbavDynamicfiltersoperator3.addItem("3", "Período", 0);
         if ( cmbavDynamicfiltersoperator3.ItemCount > 0 )
         {
            AV27DynamicFiltersOperator3 = (short)(NumberUtil.Val( cmbavDynamicfiltersoperator3.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV27DynamicFiltersOperator3), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27DynamicFiltersOperator3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV27DynamicFiltersOperator3), 4, 0)));
         }
         GXCCtl = "PEDIDOSTATUS_" + sGXsfl_134_idx;
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
         GXCCtl = "PEDIDORETIRADA_" + sGXsfl_134_idx;
         chkPedidoRetirada.Name = GXCCtl;
         chkPedidoRetirada.WebTags = "";
         chkPedidoRetirada.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkPedidoRetirada_Internalname, "TitleCaption", chkPedidoRetirada.Caption, !bGXsfl_134_Refreshing);
         chkPedidoRetirada.CheckedValue = "false";
         chkavDynamicfiltersenabled2.Name = "vDYNAMICFILTERSENABLED2";
         chkavDynamicfiltersenabled2.WebTags = "";
         chkavDynamicfiltersenabled2.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavDynamicfiltersenabled2_Internalname, "TitleCaption", chkavDynamicfiltersenabled2.Caption, true);
         chkavDynamicfiltersenabled2.CheckedValue = "false";
         chkavDynamicfiltersenabled3.Name = "vDYNAMICFILTERSENABLED3";
         chkavDynamicfiltersenabled3.WebTags = "";
         chkavDynamicfiltersenabled3.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavDynamicfiltersenabled3_Internalname, "TitleCaption", chkavDynamicfiltersenabled3.Caption, true);
         chkavDynamicfiltersenabled3.CheckedValue = "false";
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttBtninsert_Internalname = "BTNINSERT";
         bttBtneditcolumns_Internalname = "BTNEDITCOLUMNS";
         divTableactions_Internalname = "TABLEACTIONS";
         Ddo_managefilters_Internalname = "DDO_MANAGEFILTERS";
         lblDynamicfiltersprefix1_Internalname = "DYNAMICFILTERSPREFIX1";
         cmbavDynamicfiltersselector1_Internalname = "vDYNAMICFILTERSSELECTOR1";
         lblDynamicfiltersmiddle1_Internalname = "DYNAMICFILTERSMIDDLE1";
         cmbavDynamicfiltersoperator1_Internalname = "vDYNAMICFILTERSOPERATOR1";
         edtavPedidodt1_Internalname = "vPEDIDODT1";
         cellPedidodt_cell1_Internalname = "PEDIDODT_CELL1";
         lblPedidodt_rangemiddletext_11_Internalname = "PEDIDODT_RANGEMIDDLETEXT_11";
         cellPedidodt_rangemiddletext_1_cell1_Internalname = "PEDIDODT_RANGEMIDDLETEXT_1_CELL1";
         edtavPedidodt_to1_Internalname = "vPEDIDODT_TO1";
         cellPedidodt_to_cell1_Internalname = "PEDIDODT_TO_CELL1";
         tblTablemergeddynamicfilterspedidodt1_Internalname = "TABLEMERGEDDYNAMICFILTERSPEDIDODT1";
         cellFilter_pedidodt1_cell_Internalname = "FILTER_PEDIDODT1_CELL";
         tblTablemergeddynamicfilters1_Internalname = "TABLEMERGEDDYNAMICFILTERS1";
         imgAdddynamicfilters1_Internalname = "ADDDYNAMICFILTERS1";
         cellDynamicfilters_addfilter1_cell_Internalname = "DYNAMICFILTERS_ADDFILTER1_CELL";
         imgRemovedynamicfilters1_Internalname = "REMOVEDYNAMICFILTERS1";
         cellDynamicfilters_removefilter1_cell_Internalname = "DYNAMICFILTERS_REMOVEFILTER1_CELL";
         tblUnnamedtabledynamicfilters_1_Internalname = "UNNAMEDTABLEDYNAMICFILTERS_1";
         lblDynamicfiltersprefix2_Internalname = "DYNAMICFILTERSPREFIX2";
         cmbavDynamicfiltersselector2_Internalname = "vDYNAMICFILTERSSELECTOR2";
         lblDynamicfiltersmiddle2_Internalname = "DYNAMICFILTERSMIDDLE2";
         cmbavDynamicfiltersoperator2_Internalname = "vDYNAMICFILTERSOPERATOR2";
         edtavPedidodt2_Internalname = "vPEDIDODT2";
         cellPedidodt_cell2_Internalname = "PEDIDODT_CELL2";
         lblPedidodt_rangemiddletext_12_Internalname = "PEDIDODT_RANGEMIDDLETEXT_12";
         cellPedidodt_rangemiddletext_1_cell2_Internalname = "PEDIDODT_RANGEMIDDLETEXT_1_CELL2";
         edtavPedidodt_to2_Internalname = "vPEDIDODT_TO2";
         cellPedidodt_to_cell2_Internalname = "PEDIDODT_TO_CELL2";
         tblTablemergeddynamicfilterspedidodt2_Internalname = "TABLEMERGEDDYNAMICFILTERSPEDIDODT2";
         cellFilter_pedidodt2_cell_Internalname = "FILTER_PEDIDODT2_CELL";
         tblTablemergeddynamicfilters2_Internalname = "TABLEMERGEDDYNAMICFILTERS2";
         imgAdddynamicfilters2_Internalname = "ADDDYNAMICFILTERS2";
         cellDynamicfilters_addfilter2_cell_Internalname = "DYNAMICFILTERS_ADDFILTER2_CELL";
         imgRemovedynamicfilters2_Internalname = "REMOVEDYNAMICFILTERS2";
         cellDynamicfilters_removefilter2_cell_Internalname = "DYNAMICFILTERS_REMOVEFILTER2_CELL";
         tblUnnamedtabledynamicfilters_2_Internalname = "UNNAMEDTABLEDYNAMICFILTERS_2";
         lblDynamicfiltersprefix3_Internalname = "DYNAMICFILTERSPREFIX3";
         cmbavDynamicfiltersselector3_Internalname = "vDYNAMICFILTERSSELECTOR3";
         lblDynamicfiltersmiddle3_Internalname = "DYNAMICFILTERSMIDDLE3";
         cmbavDynamicfiltersoperator3_Internalname = "vDYNAMICFILTERSOPERATOR3";
         edtavPedidodt3_Internalname = "vPEDIDODT3";
         cellPedidodt_cell3_Internalname = "PEDIDODT_CELL3";
         lblPedidodt_rangemiddletext_13_Internalname = "PEDIDODT_RANGEMIDDLETEXT_13";
         cellPedidodt_rangemiddletext_1_cell3_Internalname = "PEDIDODT_RANGEMIDDLETEXT_1_CELL3";
         edtavPedidodt_to3_Internalname = "vPEDIDODT_TO3";
         cellPedidodt_to_cell3_Internalname = "PEDIDODT_TO_CELL3";
         tblTablemergeddynamicfilterspedidodt3_Internalname = "TABLEMERGEDDYNAMICFILTERSPEDIDODT3";
         cellFilter_pedidodt3_cell_Internalname = "FILTER_PEDIDODT3_CELL";
         tblTablemergeddynamicfilters3_Internalname = "TABLEMERGEDDYNAMICFILTERS3";
         imgRemovedynamicfilters3_Internalname = "REMOVEDYNAMICFILTERS3";
         cellDynamicfilters_removefilter3_cell_Internalname = "DYNAMICFILTERS_REMOVEFILTER3_CELL";
         tblUnnamedtabledynamicfilters_3_Internalname = "UNNAMEDTABLEDYNAMICFILTERS_3";
         tblTabledynamicfilters_Internalname = "TABLEDYNAMICFILTERS";
         tblTablefilters_Internalname = "TABLEFILTERS";
         tblTablerightheader_Internalname = "TABLERIGHTHEADER";
         divTableheader_Internalname = "TABLEHEADER";
         Dvpanel_tableheader_Internalname = "DVPANEL_TABLEHEADER";
         edtavUpdate_Internalname = "vUPDATE";
         edtavDelete_Internalname = "vDELETE";
         edtPedidoId_Internalname = "PEDIDOID";
         edtPessoaId_Internalname = "PESSOAID";
         edtPessoaNome_Internalname = "PESSOANOME";
         edtPedidoDt_Internalname = "PEDIDODT";
         cmbPedidoStatus_Internalname = "PEDIDOSTATUS";
         edtPedidoDtEntrega_Internalname = "PEDIDODTENTREGA";
         chkPedidoRetirada_Internalname = "PEDIDORETIRADA";
         edtPedidoTotal_Internalname = "PEDIDOTOTAL";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         lblJsdynamicfilters_Internalname = "JSDYNAMICFILTERS";
         Ddo_pedidoid_Internalname = "DDO_PEDIDOID";
         edtavDdo_pedidoidtitlecontrolidtoreplace_Internalname = "vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE";
         Ddo_pessoaid_Internalname = "DDO_PESSOAID";
         edtavDdo_pessoaidtitlecontrolidtoreplace_Internalname = "vDDO_PESSOAIDTITLECONTROLIDTOREPLACE";
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
         chkavDynamicfiltersenabled2_Internalname = "vDYNAMICFILTERSENABLED2";
         chkavDynamicfiltersenabled3_Internalname = "vDYNAMICFILTERSENABLED3";
         edtavOrderedby_Internalname = "vORDEREDBY";
         edtavOrdereddsc_Internalname = "vORDEREDDSC";
         edtavManagefiltersexecutionstep_Internalname = "vMANAGEFILTERSEXECUTIONSTEP";
         edtavTfpedidoid_Internalname = "vTFPEDIDOID";
         edtavTfpedidoid_to_Internalname = "vTFPEDIDOID_TO";
         edtavTfpessoaid_Internalname = "vTFPESSOAID";
         edtavTfpessoaid_to_Internalname = "vTFPESSOAID_TO";
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
         chkavDynamicfiltersenabled3.Caption = "";
         chkavDynamicfiltersenabled2.Caption = "";
         chkPedidoRetirada.Caption = "";
         edtPedidoTotal_Jsonclick = "";
         edtPedidoDtEntrega_Jsonclick = "";
         cmbPedidoStatus_Jsonclick = "";
         edtPedidoDt_Jsonclick = "";
         edtPessoaNome_Jsonclick = "";
         edtPessoaId_Jsonclick = "";
         edtPedidoId_Jsonclick = "";
         edtavDelete_Jsonclick = "";
         edtavUpdate_Jsonclick = "";
         edtavPedidodt_to1_Jsonclick = "";
         edtavPedidodt_to1_Enabled = 1;
         cellPedidodt_to_cell1_Class = "";
         edtavPedidodt1_Jsonclick = "";
         edtavPedidodt1_Enabled = 1;
         cmbavDynamicfiltersoperator1_Jsonclick = "";
         cmbavDynamicfiltersoperator1.Enabled = 1;
         imgRemovedynamicfilters1_Visible = 1;
         imgAdddynamicfilters1_Visible = 1;
         edtavPedidodt_to2_Jsonclick = "";
         edtavPedidodt_to2_Enabled = 1;
         cellPedidodt_to_cell2_Class = "";
         edtavPedidodt2_Jsonclick = "";
         edtavPedidodt2_Enabled = 1;
         cmbavDynamicfiltersoperator2_Jsonclick = "";
         cmbavDynamicfiltersoperator2.Enabled = 1;
         imgRemovedynamicfilters2_Visible = 1;
         imgAdddynamicfilters2_Visible = 1;
         edtavPedidodt_to3_Jsonclick = "";
         edtavPedidodt_to3_Enabled = 1;
         cellPedidodt_to_cell3_Class = "";
         edtavPedidodt3_Jsonclick = "";
         edtavPedidodt3_Enabled = 1;
         cmbavDynamicfiltersoperator3_Jsonclick = "";
         cmbavDynamicfiltersoperator3.Enabled = 1;
         cmbavDynamicfiltersselector3_Jsonclick = "";
         cmbavDynamicfiltersselector3.Enabled = 1;
         cmbavDynamicfiltersselector2_Jsonclick = "";
         cmbavDynamicfiltersselector2.Enabled = 1;
         cmbavDynamicfiltersselector1_Jsonclick = "";
         cmbavDynamicfiltersselector1.Enabled = 1;
         lblPedidodt_rangemiddletext_13_Class = "DataFilterDescription";
         cellPedidodt_cell3_Class = "MergeDataCell";
         cmbavDynamicfiltersoperator3.Visible = 1;
         tblTablemergeddynamicfilterspedidodt3_Visible = 1;
         lblPedidodt_rangemiddletext_12_Class = "DataFilterDescription";
         cellPedidodt_cell2_Class = "MergeDataCell";
         cmbavDynamicfiltersoperator2.Visible = 1;
         tblTablemergeddynamicfilterspedidodt2_Visible = 1;
         lblPedidodt_rangemiddletext_11_Class = "DataFilterDescription";
         cellPedidodt_cell1_Class = "MergeDataCell";
         cmbavDynamicfiltersoperator1.Visible = 1;
         tblTablemergeddynamicfilterspedidodt1_Visible = 1;
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
         edtavTfpessoaid_to_Jsonclick = "";
         edtavTfpessoaid_to_Visible = 1;
         edtavTfpessoaid_Jsonclick = "";
         edtavTfpessoaid_Visible = 1;
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
         chkavDynamicfiltersenabled3.Visible = 1;
         chkavDynamicfiltersenabled2.Visible = 1;
         edtavDdo_pedidototaltitlecontrolidtoreplace_Visible = 1;
         edtavDdo_pedidoretiradatitlecontrolidtoreplace_Visible = 1;
         edtavDdo_pedidodtentregatitlecontrolidtoreplace_Visible = 1;
         edtavDdo_pedidostatustitlecontrolidtoreplace_Visible = 1;
         edtavDdo_pedidodttitlecontrolidtoreplace_Visible = 1;
         edtavDdo_pessoanometitlecontrolidtoreplace_Visible = 1;
         edtavDdo_pessoaidtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_pedidoidtitlecontrolidtoreplace_Visible = 1;
         lblJsdynamicfilters_Caption = "JSDynamicFilters";
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
         edtPessoaId_Titleformat = 0;
         edtPessoaId_Title = "Id";
         edtPessoaId_Visible = -1;
         edtPedidoId_Titleformat = 0;
         edtPedidoId_Title = "Número do Pedido";
         edtPedidoId_Visible = -1;
         edtavDelete_Enabled = 0;
         edtavUpdate_Enabled = 0;
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
         Ddo_pedidototal_Includedatalist = Convert.ToBoolean( 0);
         Ddo_pedidototal_Filterisrange = Convert.ToBoolean( -1);
         Ddo_pedidototal_Filtertype = "Numeric";
         Ddo_pedidototal_Includefilter = Convert.ToBoolean( -1);
         Ddo_pedidototal_Includesortdsc = Convert.ToBoolean( 0);
         Ddo_pedidototal_Includesortasc = Convert.ToBoolean( 0);
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
         Ddo_pessoanome_Datalistproc = "WP_GerenciarPedidoGetFilterData";
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
         Ddo_pessoaid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_pessoaid_Rangefilterto = "WWP_TSTo";
         Ddo_pessoaid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_pessoaid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_pessoaid_Sortdsc = "WWP_TSSortDSC";
         Ddo_pessoaid_Sortasc = "WWP_TSSortASC";
         Ddo_pessoaid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_pessoaid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_pessoaid_Filtertype = "Numeric";
         Ddo_pessoaid_Includefilter = Convert.ToBoolean( -1);
         Ddo_pessoaid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_pessoaid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_pessoaid_Titlecontrolidtoreplace = "";
         Ddo_pessoaid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_pessoaid_Cls = "ColumnSettings";
         Ddo_pessoaid_Tooltip = "WWP_TSColumnOptions";
         Ddo_pessoaid_Caption = "";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV61ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV79ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV88ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV92ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV19PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'AV20DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV21DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV22DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV23PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV24PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'AV25DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV26DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV27DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV28PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV29PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'AV63TFPessoaId',fld:'vTFPESSOAID',pic:'ZZZ9'},{av:'AV64TFPessoaId_To',fld:'vTFPESSOAID_TO',pic:'ZZZ9'},{av:'AV67TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV68TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV71TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'AV72TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'AV78TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'AV81TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'AV82TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'AV87TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'AV90TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'ZZZZZZZZ9.99'},{av:'AV91TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'ZZZZZZZZ9.99'},{av:'AV129Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV31DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV30DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV58PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV62PessoaIdTitleFilterData',fld:'vPESSOAIDTITLEFILTERDATA',pic:''},{av:'AV66PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV70PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV76PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV80PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV86PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV89PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtPedidoId_Visible',ctrl:'PEDIDOID',prop:'Visible'},{av:'edtPessoaId_Visible',ctrl:'PESSOAID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPedidoDt_Visible',ctrl:'PEDIDODT',prop:'Visible'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Visible',ctrl:'PEDIDODTENTREGA',prop:'Visible'},{av:'chkPedidoRetirada.Visible',ctrl:'PEDIDORETIRADA',prop:'Visible'},{av:'edtPedidoTotal_Visible',ctrl:'PEDIDOTOTAL',prop:'Visible'},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPessoaId_Titleformat',ctrl:'PESSOAID',prop:'Titleformat'},{av:'edtPessoaId_Title',ctrl:'PESSOAID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV95GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV96GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E12182',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV19PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV21DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV22DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV23PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV24PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV26DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV27DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV28PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV29PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'AV20DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV25DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'AV63TFPessoaId',fld:'vTFPESSOAID',pic:'ZZZ9'},{av:'AV64TFPessoaId_To',fld:'vTFPESSOAID_TO',pic:'ZZZ9'},{av:'AV67TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV68TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV71TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'AV72TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'AV81TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'AV82TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'AV87TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV61ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV79ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV88ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV92ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV78TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'AV90TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'ZZZZZZZZ9.99'},{av:'AV91TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'ZZZZZZZZ9.99'},{av:'AV129Pgmname',fld:'vPGMNAME',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV31DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV30DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E13182',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV19PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV21DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV22DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV23PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV24PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV26DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV27DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV28PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV29PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'AV20DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV25DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'AV63TFPessoaId',fld:'vTFPESSOAID',pic:'ZZZ9'},{av:'AV64TFPessoaId_To',fld:'vTFPESSOAID_TO',pic:'ZZZ9'},{av:'AV67TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV68TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV71TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'AV72TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'AV81TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'AV82TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'AV87TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV61ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV79ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV88ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV92ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV78TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'AV90TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'ZZZZZZZZ9.99'},{av:'AV91TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'ZZZZZZZZ9.99'},{av:'AV129Pgmname',fld:'vPGMNAME',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV31DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV30DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_PEDIDOID.ONOPTIONCLICKED","{handler:'E14182',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV19PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV21DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV22DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV23PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV24PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV26DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV27DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV28PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV29PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'AV20DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV25DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'AV63TFPessoaId',fld:'vTFPESSOAID',pic:'ZZZ9'},{av:'AV64TFPessoaId_To',fld:'vTFPESSOAID_TO',pic:'ZZZ9'},{av:'AV67TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV68TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV71TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'AV72TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'AV81TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'AV82TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'AV87TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV61ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV79ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV88ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV92ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV78TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'AV90TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'ZZZZZZZZ9.99'},{av:'AV91TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'ZZZZZZZZ9.99'},{av:'AV129Pgmname',fld:'vPGMNAME',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV31DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV30DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Ddo_pedidoid_Activeeventkey',ctrl:'DDO_PEDIDOID',prop:'ActiveEventKey'},{av:'Ddo_pedidoid_Filteredtext_get',ctrl:'DDO_PEDIDOID',prop:'FilteredText_get'},{av:'Ddo_pedidoid_Filteredtextto_get',ctrl:'DDO_PEDIDOID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_PEDIDOID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_pedidoid_Sortedstatus',ctrl:'DDO_PEDIDOID',prop:'SortedStatus'},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'Ddo_pessoaid_Sortedstatus',ctrl:'DDO_PESSOAID',prop:'SortedStatus'},{av:'Ddo_pessoanome_Sortedstatus',ctrl:'DDO_PESSOANOME',prop:'SortedStatus'},{av:'Ddo_pedidodt_Sortedstatus',ctrl:'DDO_PEDIDODT',prop:'SortedStatus'},{av:'Ddo_pedidostatus_Sortedstatus',ctrl:'DDO_PEDIDOSTATUS',prop:'SortedStatus'},{av:'Ddo_pedidodtentrega_Sortedstatus',ctrl:'DDO_PEDIDODTENTREGA',prop:'SortedStatus'},{av:'Ddo_pedidoretirada_Sortedstatus',ctrl:'DDO_PEDIDORETIRADA',prop:'SortedStatus'},{av:'AV58PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV62PessoaIdTitleFilterData',fld:'vPESSOAIDTITLEFILTERDATA',pic:''},{av:'AV66PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV70PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV76PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV80PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV86PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV89PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtPedidoId_Visible',ctrl:'PEDIDOID',prop:'Visible'},{av:'edtPessoaId_Visible',ctrl:'PESSOAID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPedidoDt_Visible',ctrl:'PEDIDODT',prop:'Visible'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Visible',ctrl:'PEDIDODTENTREGA',prop:'Visible'},{av:'chkPedidoRetirada.Visible',ctrl:'PEDIDORETIRADA',prop:'Visible'},{av:'edtPedidoTotal_Visible',ctrl:'PEDIDOTOTAL',prop:'Visible'},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPessoaId_Titleformat',ctrl:'PESSOAID',prop:'Titleformat'},{av:'edtPessoaId_Title',ctrl:'PESSOAID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV95GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV96GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("DDO_PESSOAID.ONOPTIONCLICKED","{handler:'E15182',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV19PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV21DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV22DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV23PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV24PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV26DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV27DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV28PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV29PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'AV20DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV25DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'AV63TFPessoaId',fld:'vTFPESSOAID',pic:'ZZZ9'},{av:'AV64TFPessoaId_To',fld:'vTFPESSOAID_TO',pic:'ZZZ9'},{av:'AV67TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV68TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV71TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'AV72TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'AV81TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'AV82TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'AV87TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV61ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV79ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV88ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV92ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV78TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'AV90TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'ZZZZZZZZ9.99'},{av:'AV91TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'ZZZZZZZZ9.99'},{av:'AV129Pgmname',fld:'vPGMNAME',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV31DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV30DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Ddo_pessoaid_Activeeventkey',ctrl:'DDO_PESSOAID',prop:'ActiveEventKey'},{av:'Ddo_pessoaid_Filteredtext_get',ctrl:'DDO_PESSOAID',prop:'FilteredText_get'},{av:'Ddo_pessoaid_Filteredtextto_get',ctrl:'DDO_PESSOAID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_PESSOAID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_pessoaid_Sortedstatus',ctrl:'DDO_PESSOAID',prop:'SortedStatus'},{av:'AV63TFPessoaId',fld:'vTFPESSOAID',pic:'ZZZ9'},{av:'AV64TFPessoaId_To',fld:'vTFPESSOAID_TO',pic:'ZZZ9'},{av:'Ddo_pedidoid_Sortedstatus',ctrl:'DDO_PEDIDOID',prop:'SortedStatus'},{av:'Ddo_pessoanome_Sortedstatus',ctrl:'DDO_PESSOANOME',prop:'SortedStatus'},{av:'Ddo_pedidodt_Sortedstatus',ctrl:'DDO_PEDIDODT',prop:'SortedStatus'},{av:'Ddo_pedidostatus_Sortedstatus',ctrl:'DDO_PEDIDOSTATUS',prop:'SortedStatus'},{av:'Ddo_pedidodtentrega_Sortedstatus',ctrl:'DDO_PEDIDODTENTREGA',prop:'SortedStatus'},{av:'Ddo_pedidoretirada_Sortedstatus',ctrl:'DDO_PEDIDORETIRADA',prop:'SortedStatus'},{av:'AV58PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV62PessoaIdTitleFilterData',fld:'vPESSOAIDTITLEFILTERDATA',pic:''},{av:'AV66PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV70PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV76PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV80PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV86PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV89PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtPedidoId_Visible',ctrl:'PEDIDOID',prop:'Visible'},{av:'edtPessoaId_Visible',ctrl:'PESSOAID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPedidoDt_Visible',ctrl:'PEDIDODT',prop:'Visible'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Visible',ctrl:'PEDIDODTENTREGA',prop:'Visible'},{av:'chkPedidoRetirada.Visible',ctrl:'PEDIDORETIRADA',prop:'Visible'},{av:'edtPedidoTotal_Visible',ctrl:'PEDIDOTOTAL',prop:'Visible'},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPessoaId_Titleformat',ctrl:'PESSOAID',prop:'Titleformat'},{av:'edtPessoaId_Title',ctrl:'PESSOAID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV95GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV96GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("DDO_PESSOANOME.ONOPTIONCLICKED","{handler:'E16182',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV19PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV21DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV22DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV23PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV24PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV26DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV27DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV28PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV29PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'AV20DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV25DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'AV63TFPessoaId',fld:'vTFPESSOAID',pic:'ZZZ9'},{av:'AV64TFPessoaId_To',fld:'vTFPESSOAID_TO',pic:'ZZZ9'},{av:'AV67TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV68TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV71TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'AV72TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'AV81TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'AV82TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'AV87TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV61ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV79ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV88ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV92ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV78TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'AV90TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'ZZZZZZZZ9.99'},{av:'AV91TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'ZZZZZZZZ9.99'},{av:'AV129Pgmname',fld:'vPGMNAME',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV31DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV30DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Ddo_pessoanome_Activeeventkey',ctrl:'DDO_PESSOANOME',prop:'ActiveEventKey'},{av:'Ddo_pessoanome_Filteredtext_get',ctrl:'DDO_PESSOANOME',prop:'FilteredText_get'},{av:'Ddo_pessoanome_Selectedvalue_get',ctrl:'DDO_PESSOANOME',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_PESSOANOME.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_pessoanome_Sortedstatus',ctrl:'DDO_PESSOANOME',prop:'SortedStatus'},{av:'AV67TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV68TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'Ddo_pedidoid_Sortedstatus',ctrl:'DDO_PEDIDOID',prop:'SortedStatus'},{av:'Ddo_pessoaid_Sortedstatus',ctrl:'DDO_PESSOAID',prop:'SortedStatus'},{av:'Ddo_pedidodt_Sortedstatus',ctrl:'DDO_PEDIDODT',prop:'SortedStatus'},{av:'Ddo_pedidostatus_Sortedstatus',ctrl:'DDO_PEDIDOSTATUS',prop:'SortedStatus'},{av:'Ddo_pedidodtentrega_Sortedstatus',ctrl:'DDO_PEDIDODTENTREGA',prop:'SortedStatus'},{av:'Ddo_pedidoretirada_Sortedstatus',ctrl:'DDO_PEDIDORETIRADA',prop:'SortedStatus'},{av:'AV58PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV62PessoaIdTitleFilterData',fld:'vPESSOAIDTITLEFILTERDATA',pic:''},{av:'AV66PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV70PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV76PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV80PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV86PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV89PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtPedidoId_Visible',ctrl:'PEDIDOID',prop:'Visible'},{av:'edtPessoaId_Visible',ctrl:'PESSOAID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPedidoDt_Visible',ctrl:'PEDIDODT',prop:'Visible'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Visible',ctrl:'PEDIDODTENTREGA',prop:'Visible'},{av:'chkPedidoRetirada.Visible',ctrl:'PEDIDORETIRADA',prop:'Visible'},{av:'edtPedidoTotal_Visible',ctrl:'PEDIDOTOTAL',prop:'Visible'},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPessoaId_Titleformat',ctrl:'PESSOAID',prop:'Titleformat'},{av:'edtPessoaId_Title',ctrl:'PESSOAID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV95GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV96GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("DDO_PEDIDODT.ONOPTIONCLICKED","{handler:'E17182',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV19PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV21DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV22DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV23PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV24PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV26DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV27DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV28PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV29PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'AV20DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV25DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'AV63TFPessoaId',fld:'vTFPESSOAID',pic:'ZZZ9'},{av:'AV64TFPessoaId_To',fld:'vTFPESSOAID_TO',pic:'ZZZ9'},{av:'AV67TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV68TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV71TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'AV72TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'AV81TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'AV82TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'AV87TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV61ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV79ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV88ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV92ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV78TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'AV90TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'ZZZZZZZZ9.99'},{av:'AV91TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'ZZZZZZZZ9.99'},{av:'AV129Pgmname',fld:'vPGMNAME',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV31DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV30DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Ddo_pedidodt_Activeeventkey',ctrl:'DDO_PEDIDODT',prop:'ActiveEventKey'},{av:'Ddo_pedidodt_Filteredtext_get',ctrl:'DDO_PEDIDODT',prop:'FilteredText_get'},{av:'Ddo_pedidodt_Filteredtextto_get',ctrl:'DDO_PEDIDODT',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_PEDIDODT.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_pedidodt_Sortedstatus',ctrl:'DDO_PEDIDODT',prop:'SortedStatus'},{av:'AV71TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'AV72TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'Ddo_pedidoid_Sortedstatus',ctrl:'DDO_PEDIDOID',prop:'SortedStatus'},{av:'Ddo_pessoaid_Sortedstatus',ctrl:'DDO_PESSOAID',prop:'SortedStatus'},{av:'Ddo_pessoanome_Sortedstatus',ctrl:'DDO_PESSOANOME',prop:'SortedStatus'},{av:'Ddo_pedidostatus_Sortedstatus',ctrl:'DDO_PEDIDOSTATUS',prop:'SortedStatus'},{av:'Ddo_pedidodtentrega_Sortedstatus',ctrl:'DDO_PEDIDODTENTREGA',prop:'SortedStatus'},{av:'Ddo_pedidoretirada_Sortedstatus',ctrl:'DDO_PEDIDORETIRADA',prop:'SortedStatus'},{av:'AV58PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV62PessoaIdTitleFilterData',fld:'vPESSOAIDTITLEFILTERDATA',pic:''},{av:'AV66PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV70PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV76PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV80PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV86PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV89PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtPedidoId_Visible',ctrl:'PEDIDOID',prop:'Visible'},{av:'edtPessoaId_Visible',ctrl:'PESSOAID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPedidoDt_Visible',ctrl:'PEDIDODT',prop:'Visible'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Visible',ctrl:'PEDIDODTENTREGA',prop:'Visible'},{av:'chkPedidoRetirada.Visible',ctrl:'PEDIDORETIRADA',prop:'Visible'},{av:'edtPedidoTotal_Visible',ctrl:'PEDIDOTOTAL',prop:'Visible'},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPessoaId_Titleformat',ctrl:'PESSOAID',prop:'Titleformat'},{av:'edtPessoaId_Title',ctrl:'PESSOAID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV95GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV96GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("DDO_PEDIDOSTATUS.ONOPTIONCLICKED","{handler:'E18182',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV19PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV21DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV22DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV23PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV24PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV26DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV27DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV28PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV29PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'AV20DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV25DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'AV63TFPessoaId',fld:'vTFPESSOAID',pic:'ZZZ9'},{av:'AV64TFPessoaId_To',fld:'vTFPESSOAID_TO',pic:'ZZZ9'},{av:'AV67TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV68TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV71TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'AV72TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'AV81TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'AV82TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'AV87TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV61ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV79ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV88ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV92ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV78TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'AV90TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'ZZZZZZZZ9.99'},{av:'AV91TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'ZZZZZZZZ9.99'},{av:'AV129Pgmname',fld:'vPGMNAME',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV31DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV30DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Ddo_pedidostatus_Activeeventkey',ctrl:'DDO_PEDIDOSTATUS',prop:'ActiveEventKey'},{av:'Ddo_pedidostatus_Selectedvalue_get',ctrl:'DDO_PEDIDOSTATUS',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_PEDIDOSTATUS.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_pedidostatus_Sortedstatus',ctrl:'DDO_PEDIDOSTATUS',prop:'SortedStatus'},{av:'AV78TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'Ddo_pedidoid_Sortedstatus',ctrl:'DDO_PEDIDOID',prop:'SortedStatus'},{av:'Ddo_pessoaid_Sortedstatus',ctrl:'DDO_PESSOAID',prop:'SortedStatus'},{av:'Ddo_pessoanome_Sortedstatus',ctrl:'DDO_PESSOANOME',prop:'SortedStatus'},{av:'Ddo_pedidodt_Sortedstatus',ctrl:'DDO_PEDIDODT',prop:'SortedStatus'},{av:'Ddo_pedidodtentrega_Sortedstatus',ctrl:'DDO_PEDIDODTENTREGA',prop:'SortedStatus'},{av:'Ddo_pedidoretirada_Sortedstatus',ctrl:'DDO_PEDIDORETIRADA',prop:'SortedStatus'},{av:'AV58PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV62PessoaIdTitleFilterData',fld:'vPESSOAIDTITLEFILTERDATA',pic:''},{av:'AV66PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV70PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV76PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV80PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV86PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV89PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtPedidoId_Visible',ctrl:'PEDIDOID',prop:'Visible'},{av:'edtPessoaId_Visible',ctrl:'PESSOAID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPedidoDt_Visible',ctrl:'PEDIDODT',prop:'Visible'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Visible',ctrl:'PEDIDODTENTREGA',prop:'Visible'},{av:'chkPedidoRetirada.Visible',ctrl:'PEDIDORETIRADA',prop:'Visible'},{av:'edtPedidoTotal_Visible',ctrl:'PEDIDOTOTAL',prop:'Visible'},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPessoaId_Titleformat',ctrl:'PESSOAID',prop:'Titleformat'},{av:'edtPessoaId_Title',ctrl:'PESSOAID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV95GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV96GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("DDO_PEDIDODTENTREGA.ONOPTIONCLICKED","{handler:'E19182',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV19PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV21DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV22DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV23PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV24PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV26DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV27DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV28PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV29PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'AV20DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV25DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'AV63TFPessoaId',fld:'vTFPESSOAID',pic:'ZZZ9'},{av:'AV64TFPessoaId_To',fld:'vTFPESSOAID_TO',pic:'ZZZ9'},{av:'AV67TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV68TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV71TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'AV72TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'AV81TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'AV82TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'AV87TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV61ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV79ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV88ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV92ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV78TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'AV90TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'ZZZZZZZZ9.99'},{av:'AV91TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'ZZZZZZZZ9.99'},{av:'AV129Pgmname',fld:'vPGMNAME',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV31DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV30DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Ddo_pedidodtentrega_Activeeventkey',ctrl:'DDO_PEDIDODTENTREGA',prop:'ActiveEventKey'},{av:'Ddo_pedidodtentrega_Filteredtext_get',ctrl:'DDO_PEDIDODTENTREGA',prop:'FilteredText_get'},{av:'Ddo_pedidodtentrega_Filteredtextto_get',ctrl:'DDO_PEDIDODTENTREGA',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_PEDIDODTENTREGA.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_pedidodtentrega_Sortedstatus',ctrl:'DDO_PEDIDODTENTREGA',prop:'SortedStatus'},{av:'AV81TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'AV82TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'Ddo_pedidoid_Sortedstatus',ctrl:'DDO_PEDIDOID',prop:'SortedStatus'},{av:'Ddo_pessoaid_Sortedstatus',ctrl:'DDO_PESSOAID',prop:'SortedStatus'},{av:'Ddo_pessoanome_Sortedstatus',ctrl:'DDO_PESSOANOME',prop:'SortedStatus'},{av:'Ddo_pedidodt_Sortedstatus',ctrl:'DDO_PEDIDODT',prop:'SortedStatus'},{av:'Ddo_pedidostatus_Sortedstatus',ctrl:'DDO_PEDIDOSTATUS',prop:'SortedStatus'},{av:'Ddo_pedidoretirada_Sortedstatus',ctrl:'DDO_PEDIDORETIRADA',prop:'SortedStatus'},{av:'AV58PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV62PessoaIdTitleFilterData',fld:'vPESSOAIDTITLEFILTERDATA',pic:''},{av:'AV66PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV70PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV76PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV80PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV86PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV89PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtPedidoId_Visible',ctrl:'PEDIDOID',prop:'Visible'},{av:'edtPessoaId_Visible',ctrl:'PESSOAID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPedidoDt_Visible',ctrl:'PEDIDODT',prop:'Visible'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Visible',ctrl:'PEDIDODTENTREGA',prop:'Visible'},{av:'chkPedidoRetirada.Visible',ctrl:'PEDIDORETIRADA',prop:'Visible'},{av:'edtPedidoTotal_Visible',ctrl:'PEDIDOTOTAL',prop:'Visible'},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPessoaId_Titleformat',ctrl:'PESSOAID',prop:'Titleformat'},{av:'edtPessoaId_Title',ctrl:'PESSOAID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV95GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV96GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("DDO_PEDIDORETIRADA.ONOPTIONCLICKED","{handler:'E20182',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV19PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV21DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV22DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV23PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV24PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV26DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV27DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV28PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV29PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'AV20DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV25DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'AV63TFPessoaId',fld:'vTFPESSOAID',pic:'ZZZ9'},{av:'AV64TFPessoaId_To',fld:'vTFPESSOAID_TO',pic:'ZZZ9'},{av:'AV67TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV68TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV71TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'AV72TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'AV81TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'AV82TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'AV87TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV61ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV79ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV88ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV92ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV78TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'AV90TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'ZZZZZZZZ9.99'},{av:'AV91TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'ZZZZZZZZ9.99'},{av:'AV129Pgmname',fld:'vPGMNAME',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV31DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV30DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Ddo_pedidoretirada_Activeeventkey',ctrl:'DDO_PEDIDORETIRADA',prop:'ActiveEventKey'},{av:'Ddo_pedidoretirada_Selectedvalue_get',ctrl:'DDO_PEDIDORETIRADA',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_PEDIDORETIRADA.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_pedidoretirada_Sortedstatus',ctrl:'DDO_PEDIDORETIRADA',prop:'SortedStatus'},{av:'AV87TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'Ddo_pedidoid_Sortedstatus',ctrl:'DDO_PEDIDOID',prop:'SortedStatus'},{av:'Ddo_pessoaid_Sortedstatus',ctrl:'DDO_PESSOAID',prop:'SortedStatus'},{av:'Ddo_pessoanome_Sortedstatus',ctrl:'DDO_PESSOANOME',prop:'SortedStatus'},{av:'Ddo_pedidodt_Sortedstatus',ctrl:'DDO_PEDIDODT',prop:'SortedStatus'},{av:'Ddo_pedidostatus_Sortedstatus',ctrl:'DDO_PEDIDOSTATUS',prop:'SortedStatus'},{av:'Ddo_pedidodtentrega_Sortedstatus',ctrl:'DDO_PEDIDODTENTREGA',prop:'SortedStatus'},{av:'AV58PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV62PessoaIdTitleFilterData',fld:'vPESSOAIDTITLEFILTERDATA',pic:''},{av:'AV66PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV70PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV76PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV80PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV86PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV89PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtPedidoId_Visible',ctrl:'PEDIDOID',prop:'Visible'},{av:'edtPessoaId_Visible',ctrl:'PESSOAID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPedidoDt_Visible',ctrl:'PEDIDODT',prop:'Visible'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Visible',ctrl:'PEDIDODTENTREGA',prop:'Visible'},{av:'chkPedidoRetirada.Visible',ctrl:'PEDIDORETIRADA',prop:'Visible'},{av:'edtPedidoTotal_Visible',ctrl:'PEDIDOTOTAL',prop:'Visible'},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPessoaId_Titleformat',ctrl:'PESSOAID',prop:'Titleformat'},{av:'edtPessoaId_Title',ctrl:'PESSOAID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV95GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV96GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("DDO_PEDIDOTOTAL.ONOPTIONCLICKED","{handler:'E21182',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV19PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV21DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV22DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV23PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV24PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV26DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV27DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV28PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV29PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'AV20DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV25DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'AV63TFPessoaId',fld:'vTFPESSOAID',pic:'ZZZ9'},{av:'AV64TFPessoaId_To',fld:'vTFPESSOAID_TO',pic:'ZZZ9'},{av:'AV67TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV68TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV71TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'AV72TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'AV81TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'AV82TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'AV87TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV61ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV79ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV88ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV92ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV78TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'AV90TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'ZZZZZZZZ9.99'},{av:'AV91TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'ZZZZZZZZ9.99'},{av:'AV129Pgmname',fld:'vPGMNAME',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV31DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV30DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Ddo_pedidototal_Activeeventkey',ctrl:'DDO_PEDIDOTOTAL',prop:'ActiveEventKey'},{av:'Ddo_pedidototal_Filteredtext_get',ctrl:'DDO_PEDIDOTOTAL',prop:'FilteredText_get'},{av:'Ddo_pedidototal_Filteredtextto_get',ctrl:'DDO_PEDIDOTOTAL',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_PEDIDOTOTAL.ONOPTIONCLICKED",",oparms:[{av:'AV90TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'ZZZZZZZZ9.99'},{av:'AV91TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'ZZZZZZZZ9.99'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E37182',iparms:[{av:'A32PedidoId',fld:'PEDIDOID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV97Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'AV98Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'},{av:'edtPedidoDt_Link',ctrl:'PEDIDODT',prop:'Link'}]}");
         setEventMetadata("DDO_GRIDCOLUMNSSELECTOR.ONCOLUMNSCHANGED","{handler:'E22182',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV19PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV21DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV22DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV23PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV24PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV26DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV27DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV28PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV29PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'AV20DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV25DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'AV63TFPessoaId',fld:'vTFPESSOAID',pic:'ZZZ9'},{av:'AV64TFPessoaId_To',fld:'vTFPESSOAID_TO',pic:'ZZZ9'},{av:'AV67TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV68TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV71TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'AV72TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'AV81TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'AV82TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'AV87TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV61ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV79ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV88ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV92ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV78TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'AV90TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'ZZZZZZZZ9.99'},{av:'AV91TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'ZZZZZZZZ9.99'},{av:'AV129Pgmname',fld:'vPGMNAME',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV31DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV30DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Ddo_gridcolumnsselector_Columnsselectorvalues',ctrl:'DDO_GRIDCOLUMNSSELECTOR',prop:'ColumnsSelectorValues'}]");
         setEventMetadata("DDO_GRIDCOLUMNSSELECTOR.ONCOLUMNSCHANGED",",oparms:[{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV58PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV62PessoaIdTitleFilterData',fld:'vPESSOAIDTITLEFILTERDATA',pic:''},{av:'AV66PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV70PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV76PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV80PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV86PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV89PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'edtPedidoId_Visible',ctrl:'PEDIDOID',prop:'Visible'},{av:'edtPessoaId_Visible',ctrl:'PESSOAID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPedidoDt_Visible',ctrl:'PEDIDODT',prop:'Visible'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Visible',ctrl:'PEDIDODTENTREGA',prop:'Visible'},{av:'chkPedidoRetirada.Visible',ctrl:'PEDIDORETIRADA',prop:'Visible'},{av:'edtPedidoTotal_Visible',ctrl:'PEDIDOTOTAL',prop:'Visible'},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPessoaId_Titleformat',ctrl:'PESSOAID',prop:'Titleformat'},{av:'edtPessoaId_Title',ctrl:'PESSOAID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV95GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV96GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("'ADDDYNAMICFILTERS1'","{handler:'E27182',iparms:[]");
         setEventMetadata("'ADDDYNAMICFILTERS1'",",oparms:[{av:'AV20DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'}]}");
         setEventMetadata("'REMOVEDYNAMICFILTERS1'","{handler:'E23182',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV19PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV21DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV22DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV23PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV24PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV26DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV27DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV28PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV29PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'AV20DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV25DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'AV63TFPessoaId',fld:'vTFPESSOAID',pic:'ZZZ9'},{av:'AV64TFPessoaId_To',fld:'vTFPESSOAID_TO',pic:'ZZZ9'},{av:'AV67TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV68TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV71TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'AV72TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'AV81TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'AV82TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'AV87TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV61ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV79ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV88ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV92ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV78TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'AV90TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'ZZZZZZZZ9.99'},{av:'AV91TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'ZZZZZZZZ9.99'},{av:'AV129Pgmname',fld:'vPGMNAME',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV31DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV30DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Gx_date',fld:'vTODAY',pic:''}]");
         setEventMetadata("'REMOVEDYNAMICFILTERS1'",",oparms:[{av:'AV30DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'AV31DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV20DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV21DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV22DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV23PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV24PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'AV25DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV26DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV27DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV28PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV29PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV19PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'lblJsdynamicfilters_Caption',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{av:'tblTablemergeddynamicfilterspedidodt2_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPEDIDODT2',prop:'Visible'},{av:'tblTablemergeddynamicfilterspedidodt3_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPEDIDODT3',prop:'Visible'},{av:'tblTablemergeddynamicfilterspedidodt1_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPEDIDODT1',prop:'Visible'},{av:'cellPedidodt_cell2_Class',ctrl:'PEDIDODT_CELL2',prop:'Class'},{av:'cellPedidodt_to_cell2_Class',ctrl:'PEDIDODT_TO_CELL2',prop:'Class'},{av:'lblPedidodt_rangemiddletext_12_Class',ctrl:'PEDIDODT_RANGEMIDDLETEXT_12',prop:'Class'},{av:'cellPedidodt_cell3_Class',ctrl:'PEDIDODT_CELL3',prop:'Class'},{av:'cellPedidodt_to_cell3_Class',ctrl:'PEDIDODT_TO_CELL3',prop:'Class'},{av:'lblPedidodt_rangemiddletext_13_Class',ctrl:'PEDIDODT_RANGEMIDDLETEXT_13',prop:'Class'},{av:'cellPedidodt_cell1_Class',ctrl:'PEDIDODT_CELL1',prop:'Class'},{av:'cellPedidodt_to_cell1_Class',ctrl:'PEDIDODT_TO_CELL1',prop:'Class'},{av:'lblPedidodt_rangemiddletext_11_Class',ctrl:'PEDIDODT_RANGEMIDDLETEXT_11',prop:'Class'},{av:'AV58PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV62PessoaIdTitleFilterData',fld:'vPESSOAIDTITLEFILTERDATA',pic:''},{av:'AV66PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV70PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV76PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV80PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV86PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV89PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtPedidoId_Visible',ctrl:'PEDIDOID',prop:'Visible'},{av:'edtPessoaId_Visible',ctrl:'PESSOAID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPedidoDt_Visible',ctrl:'PEDIDODT',prop:'Visible'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Visible',ctrl:'PEDIDODTENTREGA',prop:'Visible'},{av:'chkPedidoRetirada.Visible',ctrl:'PEDIDORETIRADA',prop:'Visible'},{av:'edtPedidoTotal_Visible',ctrl:'PEDIDOTOTAL',prop:'Visible'},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPessoaId_Titleformat',ctrl:'PESSOAID',prop:'Titleformat'},{av:'edtPessoaId_Title',ctrl:'PESSOAID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV95GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV96GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''}]}");
         setEventMetadata("VDYNAMICFILTERSSELECTOR1.CLICK","{handler:'E28182',iparms:[{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'Gx_date',fld:'vTODAY',pic:''}]");
         setEventMetadata("VDYNAMICFILTERSSELECTOR1.CLICK",",oparms:[{av:'tblTablemergeddynamicfilterspedidodt1_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPEDIDODT1',prop:'Visible'},{av:'cmbavDynamicfiltersoperator1'},{av:'cellPedidodt_cell1_Class',ctrl:'PEDIDODT_CELL1',prop:'Class'},{av:'cellPedidodt_to_cell1_Class',ctrl:'PEDIDODT_TO_CELL1',prop:'Class'},{av:'lblPedidodt_rangemiddletext_11_Class',ctrl:'PEDIDODT_RANGEMIDDLETEXT_11',prop:'Class'},{av:'AV18PedidoDt1',fld:'vPEDIDODT1',pic:''}]}");
         setEventMetadata("VDYNAMICFILTERSOPERATOR1.CLICK","{handler:'E29182',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV19PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV21DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV22DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV23PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV24PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV26DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV27DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV28PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV29PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'AV20DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV25DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'AV63TFPessoaId',fld:'vTFPESSOAID',pic:'ZZZ9'},{av:'AV64TFPessoaId_To',fld:'vTFPESSOAID_TO',pic:'ZZZ9'},{av:'AV67TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV68TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV71TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'AV72TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'AV81TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'AV82TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'AV87TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV61ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV79ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV88ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV92ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV78TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'AV90TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'ZZZZZZZZ9.99'},{av:'AV91TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'ZZZZZZZZ9.99'},{av:'AV129Pgmname',fld:'vPGMNAME',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV31DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV30DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Gx_date',fld:'vTODAY',pic:''}]");
         setEventMetadata("VDYNAMICFILTERSOPERATOR1.CLICK",",oparms:[{av:'AV18PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV19PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'cellPedidodt_cell1_Class',ctrl:'PEDIDODT_CELL1',prop:'Class'},{av:'cellPedidodt_to_cell1_Class',ctrl:'PEDIDODT_TO_CELL1',prop:'Class'},{av:'lblPedidodt_rangemiddletext_11_Class',ctrl:'PEDIDODT_RANGEMIDDLETEXT_11',prop:'Class'},{av:'AV58PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV62PessoaIdTitleFilterData',fld:'vPESSOAIDTITLEFILTERDATA',pic:''},{av:'AV66PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV70PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV76PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV80PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV86PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV89PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtPedidoId_Visible',ctrl:'PEDIDOID',prop:'Visible'},{av:'edtPessoaId_Visible',ctrl:'PESSOAID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPedidoDt_Visible',ctrl:'PEDIDODT',prop:'Visible'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Visible',ctrl:'PEDIDODTENTREGA',prop:'Visible'},{av:'chkPedidoRetirada.Visible',ctrl:'PEDIDORETIRADA',prop:'Visible'},{av:'edtPedidoTotal_Visible',ctrl:'PEDIDOTOTAL',prop:'Visible'},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPessoaId_Titleformat',ctrl:'PESSOAID',prop:'Titleformat'},{av:'edtPessoaId_Title',ctrl:'PESSOAID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV95GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV96GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("'ADDDYNAMICFILTERS2'","{handler:'E30182',iparms:[]");
         setEventMetadata("'ADDDYNAMICFILTERS2'",",oparms:[{av:'AV25DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'}]}");
         setEventMetadata("'REMOVEDYNAMICFILTERS2'","{handler:'E24182',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV19PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV21DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV22DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV23PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV24PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV26DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV27DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV28PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV29PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'AV20DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV25DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'AV63TFPessoaId',fld:'vTFPESSOAID',pic:'ZZZ9'},{av:'AV64TFPessoaId_To',fld:'vTFPESSOAID_TO',pic:'ZZZ9'},{av:'AV67TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV68TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV71TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'AV72TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'AV81TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'AV82TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'AV87TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV61ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV79ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV88ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV92ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV78TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'AV90TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'ZZZZZZZZ9.99'},{av:'AV91TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'ZZZZZZZZ9.99'},{av:'AV129Pgmname',fld:'vPGMNAME',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV31DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV30DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Gx_date',fld:'vTODAY',pic:''}]");
         setEventMetadata("'REMOVEDYNAMICFILTERS2'",",oparms:[{av:'AV30DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'AV20DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV21DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV22DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV23PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV24PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'AV25DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV26DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV27DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV28PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV29PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV19PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'lblJsdynamicfilters_Caption',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{av:'tblTablemergeddynamicfilterspedidodt2_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPEDIDODT2',prop:'Visible'},{av:'tblTablemergeddynamicfilterspedidodt3_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPEDIDODT3',prop:'Visible'},{av:'tblTablemergeddynamicfilterspedidodt1_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPEDIDODT1',prop:'Visible'},{av:'cellPedidodt_cell2_Class',ctrl:'PEDIDODT_CELL2',prop:'Class'},{av:'cellPedidodt_to_cell2_Class',ctrl:'PEDIDODT_TO_CELL2',prop:'Class'},{av:'lblPedidodt_rangemiddletext_12_Class',ctrl:'PEDIDODT_RANGEMIDDLETEXT_12',prop:'Class'},{av:'cellPedidodt_cell3_Class',ctrl:'PEDIDODT_CELL3',prop:'Class'},{av:'cellPedidodt_to_cell3_Class',ctrl:'PEDIDODT_TO_CELL3',prop:'Class'},{av:'lblPedidodt_rangemiddletext_13_Class',ctrl:'PEDIDODT_RANGEMIDDLETEXT_13',prop:'Class'},{av:'cellPedidodt_cell1_Class',ctrl:'PEDIDODT_CELL1',prop:'Class'},{av:'cellPedidodt_to_cell1_Class',ctrl:'PEDIDODT_TO_CELL1',prop:'Class'},{av:'lblPedidodt_rangemiddletext_11_Class',ctrl:'PEDIDODT_RANGEMIDDLETEXT_11',prop:'Class'},{av:'AV58PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV62PessoaIdTitleFilterData',fld:'vPESSOAIDTITLEFILTERDATA',pic:''},{av:'AV66PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV70PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV76PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV80PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV86PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV89PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtPedidoId_Visible',ctrl:'PEDIDOID',prop:'Visible'},{av:'edtPessoaId_Visible',ctrl:'PESSOAID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPedidoDt_Visible',ctrl:'PEDIDODT',prop:'Visible'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Visible',ctrl:'PEDIDODTENTREGA',prop:'Visible'},{av:'chkPedidoRetirada.Visible',ctrl:'PEDIDORETIRADA',prop:'Visible'},{av:'edtPedidoTotal_Visible',ctrl:'PEDIDOTOTAL',prop:'Visible'},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPessoaId_Titleformat',ctrl:'PESSOAID',prop:'Titleformat'},{av:'edtPessoaId_Title',ctrl:'PESSOAID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV95GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV96GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''}]}");
         setEventMetadata("VDYNAMICFILTERSSELECTOR2.CLICK","{handler:'E31182',iparms:[{av:'cmbavDynamicfiltersselector2'},{av:'AV21DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV22DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'Gx_date',fld:'vTODAY',pic:''}]");
         setEventMetadata("VDYNAMICFILTERSSELECTOR2.CLICK",",oparms:[{av:'tblTablemergeddynamicfilterspedidodt2_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPEDIDODT2',prop:'Visible'},{av:'cmbavDynamicfiltersoperator2'},{av:'cellPedidodt_cell2_Class',ctrl:'PEDIDODT_CELL2',prop:'Class'},{av:'cellPedidodt_to_cell2_Class',ctrl:'PEDIDODT_TO_CELL2',prop:'Class'},{av:'lblPedidodt_rangemiddletext_12_Class',ctrl:'PEDIDODT_RANGEMIDDLETEXT_12',prop:'Class'},{av:'AV23PedidoDt2',fld:'vPEDIDODT2',pic:''}]}");
         setEventMetadata("VDYNAMICFILTERSOPERATOR2.CLICK","{handler:'E32182',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV19PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV21DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV22DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV23PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV24PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV26DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV27DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV28PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV29PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'AV20DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV25DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'AV63TFPessoaId',fld:'vTFPESSOAID',pic:'ZZZ9'},{av:'AV64TFPessoaId_To',fld:'vTFPESSOAID_TO',pic:'ZZZ9'},{av:'AV67TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV68TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV71TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'AV72TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'AV81TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'AV82TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'AV87TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV61ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV79ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV88ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV92ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV78TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'AV90TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'ZZZZZZZZ9.99'},{av:'AV91TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'ZZZZZZZZ9.99'},{av:'AV129Pgmname',fld:'vPGMNAME',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV31DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV30DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Gx_date',fld:'vTODAY',pic:''}]");
         setEventMetadata("VDYNAMICFILTERSOPERATOR2.CLICK",",oparms:[{av:'AV23PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV24PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cellPedidodt_cell2_Class',ctrl:'PEDIDODT_CELL2',prop:'Class'},{av:'cellPedidodt_to_cell2_Class',ctrl:'PEDIDODT_TO_CELL2',prop:'Class'},{av:'lblPedidodt_rangemiddletext_12_Class',ctrl:'PEDIDODT_RANGEMIDDLETEXT_12',prop:'Class'},{av:'AV58PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV62PessoaIdTitleFilterData',fld:'vPESSOAIDTITLEFILTERDATA',pic:''},{av:'AV66PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV70PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV76PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV80PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV86PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV89PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtPedidoId_Visible',ctrl:'PEDIDOID',prop:'Visible'},{av:'edtPessoaId_Visible',ctrl:'PESSOAID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPedidoDt_Visible',ctrl:'PEDIDODT',prop:'Visible'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Visible',ctrl:'PEDIDODTENTREGA',prop:'Visible'},{av:'chkPedidoRetirada.Visible',ctrl:'PEDIDORETIRADA',prop:'Visible'},{av:'edtPedidoTotal_Visible',ctrl:'PEDIDOTOTAL',prop:'Visible'},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPessoaId_Titleformat',ctrl:'PESSOAID',prop:'Titleformat'},{av:'edtPessoaId_Title',ctrl:'PESSOAID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV95GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV96GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("'REMOVEDYNAMICFILTERS3'","{handler:'E25182',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV19PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV21DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV22DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV23PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV24PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV26DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV27DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV28PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV29PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'AV20DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV25DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'AV63TFPessoaId',fld:'vTFPESSOAID',pic:'ZZZ9'},{av:'AV64TFPessoaId_To',fld:'vTFPESSOAID_TO',pic:'ZZZ9'},{av:'AV67TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV68TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV71TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'AV72TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'AV81TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'AV82TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'AV87TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV61ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV79ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV88ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV92ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV78TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'AV90TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'ZZZZZZZZ9.99'},{av:'AV91TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'ZZZZZZZZ9.99'},{av:'AV129Pgmname',fld:'vPGMNAME',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV31DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV30DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Gx_date',fld:'vTODAY',pic:''}]");
         setEventMetadata("'REMOVEDYNAMICFILTERS3'",",oparms:[{av:'AV30DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'AV25DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV20DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV21DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV22DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV23PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV24PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV26DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV27DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV28PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV29PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV19PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'lblJsdynamicfilters_Caption',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{av:'tblTablemergeddynamicfilterspedidodt2_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPEDIDODT2',prop:'Visible'},{av:'tblTablemergeddynamicfilterspedidodt3_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPEDIDODT3',prop:'Visible'},{av:'tblTablemergeddynamicfilterspedidodt1_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPEDIDODT1',prop:'Visible'},{av:'cellPedidodt_cell2_Class',ctrl:'PEDIDODT_CELL2',prop:'Class'},{av:'cellPedidodt_to_cell2_Class',ctrl:'PEDIDODT_TO_CELL2',prop:'Class'},{av:'lblPedidodt_rangemiddletext_12_Class',ctrl:'PEDIDODT_RANGEMIDDLETEXT_12',prop:'Class'},{av:'cellPedidodt_cell3_Class',ctrl:'PEDIDODT_CELL3',prop:'Class'},{av:'cellPedidodt_to_cell3_Class',ctrl:'PEDIDODT_TO_CELL3',prop:'Class'},{av:'lblPedidodt_rangemiddletext_13_Class',ctrl:'PEDIDODT_RANGEMIDDLETEXT_13',prop:'Class'},{av:'cellPedidodt_cell1_Class',ctrl:'PEDIDODT_CELL1',prop:'Class'},{av:'cellPedidodt_to_cell1_Class',ctrl:'PEDIDODT_TO_CELL1',prop:'Class'},{av:'lblPedidodt_rangemiddletext_11_Class',ctrl:'PEDIDODT_RANGEMIDDLETEXT_11',prop:'Class'},{av:'AV58PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV62PessoaIdTitleFilterData',fld:'vPESSOAIDTITLEFILTERDATA',pic:''},{av:'AV66PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV70PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV76PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV80PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV86PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV89PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtPedidoId_Visible',ctrl:'PEDIDOID',prop:'Visible'},{av:'edtPessoaId_Visible',ctrl:'PESSOAID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPedidoDt_Visible',ctrl:'PEDIDODT',prop:'Visible'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Visible',ctrl:'PEDIDODTENTREGA',prop:'Visible'},{av:'chkPedidoRetirada.Visible',ctrl:'PEDIDORETIRADA',prop:'Visible'},{av:'edtPedidoTotal_Visible',ctrl:'PEDIDOTOTAL',prop:'Visible'},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPessoaId_Titleformat',ctrl:'PESSOAID',prop:'Titleformat'},{av:'edtPessoaId_Title',ctrl:'PESSOAID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV95GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV96GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''}]}");
         setEventMetadata("VDYNAMICFILTERSSELECTOR3.CLICK","{handler:'E33182',iparms:[{av:'cmbavDynamicfiltersselector3'},{av:'AV26DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV27DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'Gx_date',fld:'vTODAY',pic:''}]");
         setEventMetadata("VDYNAMICFILTERSSELECTOR3.CLICK",",oparms:[{av:'tblTablemergeddynamicfilterspedidodt3_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPEDIDODT3',prop:'Visible'},{av:'cmbavDynamicfiltersoperator3'},{av:'cellPedidodt_cell3_Class',ctrl:'PEDIDODT_CELL3',prop:'Class'},{av:'cellPedidodt_to_cell3_Class',ctrl:'PEDIDODT_TO_CELL3',prop:'Class'},{av:'lblPedidodt_rangemiddletext_13_Class',ctrl:'PEDIDODT_RANGEMIDDLETEXT_13',prop:'Class'},{av:'AV28PedidoDt3',fld:'vPEDIDODT3',pic:''}]}");
         setEventMetadata("VDYNAMICFILTERSOPERATOR3.CLICK","{handler:'E34182',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV19PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV21DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV22DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV23PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV24PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV26DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV27DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV28PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV29PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'AV20DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV25DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'AV63TFPessoaId',fld:'vTFPESSOAID',pic:'ZZZ9'},{av:'AV64TFPessoaId_To',fld:'vTFPESSOAID_TO',pic:'ZZZ9'},{av:'AV67TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV68TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV71TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'AV72TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'AV81TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'AV82TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'AV87TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV61ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV79ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV88ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV92ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV78TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'AV90TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'ZZZZZZZZ9.99'},{av:'AV91TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'ZZZZZZZZ9.99'},{av:'AV129Pgmname',fld:'vPGMNAME',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV31DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV30DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Gx_date',fld:'vTODAY',pic:''}]");
         setEventMetadata("VDYNAMICFILTERSOPERATOR3.CLICK",",oparms:[{av:'AV28PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV29PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'cellPedidodt_cell3_Class',ctrl:'PEDIDODT_CELL3',prop:'Class'},{av:'cellPedidodt_to_cell3_Class',ctrl:'PEDIDODT_TO_CELL3',prop:'Class'},{av:'lblPedidodt_rangemiddletext_13_Class',ctrl:'PEDIDODT_RANGEMIDDLETEXT_13',prop:'Class'},{av:'AV58PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV62PessoaIdTitleFilterData',fld:'vPESSOAIDTITLEFILTERDATA',pic:''},{av:'AV66PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV70PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV76PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV80PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV86PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV89PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtPedidoId_Visible',ctrl:'PEDIDOID',prop:'Visible'},{av:'edtPessoaId_Visible',ctrl:'PESSOAID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPedidoDt_Visible',ctrl:'PEDIDODT',prop:'Visible'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Visible',ctrl:'PEDIDODTENTREGA',prop:'Visible'},{av:'chkPedidoRetirada.Visible',ctrl:'PEDIDORETIRADA',prop:'Visible'},{av:'edtPedidoTotal_Visible',ctrl:'PEDIDOTOTAL',prop:'Visible'},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPessoaId_Titleformat',ctrl:'PESSOAID',prop:'Titleformat'},{av:'edtPessoaId_Title',ctrl:'PESSOAID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV95GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV96GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("DDO_MANAGEFILTERS.ONOPTIONCLICKED","{handler:'E11182',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV19PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV21DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV22DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV23PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV24PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV26DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV27DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV28PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV29PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'AV20DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV25DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'AV63TFPessoaId',fld:'vTFPESSOAID',pic:'ZZZ9'},{av:'AV64TFPessoaId_To',fld:'vTFPESSOAID_TO',pic:'ZZZ9'},{av:'AV67TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV68TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV71TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'AV72TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'AV81TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'AV82TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'AV87TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV61ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV79ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV88ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV92ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV78TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'AV90TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'ZZZZZZZZ9.99'},{av:'AV91TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'ZZZZZZZZ9.99'},{av:'AV129Pgmname',fld:'vPGMNAME',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV31DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV30DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Ddo_managefilters_Activeeventkey',ctrl:'DDO_MANAGEFILTERS',prop:'ActiveEventKey'},{av:'Gx_date',fld:'vTODAY',pic:''}]");
         setEventMetadata("DDO_MANAGEFILTERS.ONOPTIONCLICKED",",oparms:[{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV59TFPedidoId',fld:'vTFPEDIDOID',pic:'ZZZ9'},{av:'Ddo_pedidoid_Filteredtext_set',ctrl:'DDO_PEDIDOID',prop:'FilteredText_set'},{av:'AV60TFPedidoId_To',fld:'vTFPEDIDOID_TO',pic:'ZZZ9'},{av:'Ddo_pedidoid_Filteredtextto_set',ctrl:'DDO_PEDIDOID',prop:'FilteredTextTo_set'},{av:'AV63TFPessoaId',fld:'vTFPESSOAID',pic:'ZZZ9'},{av:'Ddo_pessoaid_Filteredtext_set',ctrl:'DDO_PESSOAID',prop:'FilteredText_set'},{av:'AV64TFPessoaId_To',fld:'vTFPESSOAID_TO',pic:'ZZZ9'},{av:'Ddo_pessoaid_Filteredtextto_set',ctrl:'DDO_PESSOAID',prop:'FilteredTextTo_set'},{av:'AV67TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'Ddo_pessoanome_Filteredtext_set',ctrl:'DDO_PESSOANOME',prop:'FilteredText_set'},{av:'AV68TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'Ddo_pessoanome_Selectedvalue_set',ctrl:'DDO_PESSOANOME',prop:'SelectedValue_set'},{av:'AV71TFPedidoDt',fld:'vTFPEDIDODT',pic:''},{av:'Ddo_pedidodt_Filteredtext_set',ctrl:'DDO_PEDIDODT',prop:'FilteredText_set'},{av:'AV72TFPedidoDt_To',fld:'vTFPEDIDODT_TO',pic:''},{av:'Ddo_pedidodt_Filteredtextto_set',ctrl:'DDO_PEDIDODT',prop:'FilteredTextTo_set'},{av:'AV78TFPedidoStatus_Sels',fld:'vTFPEDIDOSTATUS_SELS',pic:''},{av:'Ddo_pedidostatus_Selectedvalue_set',ctrl:'DDO_PEDIDOSTATUS',prop:'SelectedValue_set'},{av:'AV81TFPedidoDtEntrega',fld:'vTFPEDIDODTENTREGA',pic:''},{av:'Ddo_pedidodtentrega_Filteredtext_set',ctrl:'DDO_PEDIDODTENTREGA',prop:'FilteredText_set'},{av:'AV82TFPedidoDtEntrega_To',fld:'vTFPEDIDODTENTREGA_TO',pic:''},{av:'Ddo_pedidodtentrega_Filteredtextto_set',ctrl:'DDO_PEDIDODTENTREGA',prop:'FilteredTextTo_set'},{av:'AV87TFPedidoRetirada_Sel',fld:'vTFPEDIDORETIRADA_SEL',pic:'9'},{av:'Ddo_pedidoretirada_Selectedvalue_set',ctrl:'DDO_PEDIDORETIRADA',prop:'SelectedValue_set'},{av:'AV90TFPedidoTotal',fld:'vTFPEDIDOTOTAL',pic:'ZZZZZZZZ9.99'},{av:'Ddo_pedidototal_Filteredtext_set',ctrl:'DDO_PEDIDOTOTAL',prop:'FilteredText_set'},{av:'AV91TFPedidoTotal_To',fld:'vTFPEDIDOTOTAL_TO',pic:'ZZZZZZZZ9.99'},{av:'Ddo_pedidototal_Filteredtextto_set',ctrl:'DDO_PEDIDOTOTAL',prop:'FilteredTextTo_set'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV19PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'Ddo_pedidoretirada_Sortedstatus',ctrl:'DDO_PEDIDORETIRADA',prop:'SortedStatus'},{av:'Ddo_pedidodtentrega_Sortedstatus',ctrl:'DDO_PEDIDODTENTREGA',prop:'SortedStatus'},{av:'Ddo_pedidostatus_Sortedstatus',ctrl:'DDO_PEDIDOSTATUS',prop:'SortedStatus'},{av:'Ddo_pedidodt_Sortedstatus',ctrl:'DDO_PEDIDODT',prop:'SortedStatus'},{av:'Ddo_pessoanome_Sortedstatus',ctrl:'DDO_PESSOANOME',prop:'SortedStatus'},{av:'Ddo_pessoaid_Sortedstatus',ctrl:'DDO_PESSOAID',prop:'SortedStatus'},{av:'Ddo_pedidoid_Sortedstatus',ctrl:'DDO_PEDIDOID',prop:'SortedStatus'},{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'lblJsdynamicfilters_Caption',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{av:'AV20DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV21DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV22DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV23PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV24PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'AV25DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV26DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV27DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV28PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV29PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'tblTablemergeddynamicfilterspedidodt1_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPEDIDODT1',prop:'Visible'},{av:'tblTablemergeddynamicfilterspedidodt2_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPEDIDODT2',prop:'Visible'},{av:'tblTablemergeddynamicfilterspedidodt3_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPEDIDODT3',prop:'Visible'},{av:'cellPedidodt_cell1_Class',ctrl:'PEDIDODT_CELL1',prop:'Class'},{av:'cellPedidodt_to_cell1_Class',ctrl:'PEDIDODT_TO_CELL1',prop:'Class'},{av:'lblPedidodt_rangemiddletext_11_Class',ctrl:'PEDIDODT_RANGEMIDDLETEXT_11',prop:'Class'},{av:'cellPedidodt_cell2_Class',ctrl:'PEDIDODT_CELL2',prop:'Class'},{av:'cellPedidodt_to_cell2_Class',ctrl:'PEDIDODT_TO_CELL2',prop:'Class'},{av:'lblPedidodt_rangemiddletext_12_Class',ctrl:'PEDIDODT_RANGEMIDDLETEXT_12',prop:'Class'},{av:'cellPedidodt_cell3_Class',ctrl:'PEDIDODT_CELL3',prop:'Class'},{av:'cellPedidodt_to_cell3_Class',ctrl:'PEDIDODT_TO_CELL3',prop:'Class'},{av:'lblPedidodt_rangemiddletext_13_Class',ctrl:'PEDIDODT_RANGEMIDDLETEXT_13',prop:'Class'},{av:'AV58PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV62PessoaIdTitleFilterData',fld:'vPESSOAIDTITLEFILTERDATA',pic:''},{av:'AV66PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV70PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV76PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV80PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV86PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV89PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtPedidoId_Visible',ctrl:'PEDIDOID',prop:'Visible'},{av:'edtPessoaId_Visible',ctrl:'PESSOAID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPedidoDt_Visible',ctrl:'PEDIDODT',prop:'Visible'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Visible',ctrl:'PEDIDODTENTREGA',prop:'Visible'},{av:'chkPedidoRetirada.Visible',ctrl:'PEDIDORETIRADA',prop:'Visible'},{av:'edtPedidoTotal_Visible',ctrl:'PEDIDOTOTAL',prop:'Visible'},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPessoaId_Titleformat',ctrl:'PESSOAID',prop:'Titleformat'},{av:'edtPessoaId_Title',ctrl:'PESSOAID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV95GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV96GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''}]}");
         setEventMetadata("'DOINSERT'","{handler:'E26182',iparms:[{av:'A32PedidoId',fld:'PEDIDOID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("'DOINSERT'",",oparms:[]}");
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
         Ddo_pessoaid_Activeeventkey = "";
         Ddo_pessoaid_Filteredtext_get = "";
         Ddo_pessoaid_Filteredtextto_get = "";
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
         AV16DynamicFiltersSelector1 = "";
         AV18PedidoDt1 = DateTime.MinValue;
         AV19PedidoDt_To1 = DateTime.MinValue;
         AV21DynamicFiltersSelector2 = "";
         AV23PedidoDt2 = DateTime.MinValue;
         AV24PedidoDt_To2 = DateTime.MinValue;
         AV26DynamicFiltersSelector3 = "";
         AV28PedidoDt3 = DateTime.MinValue;
         AV29PedidoDt_To3 = DateTime.MinValue;
         AV67TFPessoaNome = "";
         AV68TFPessoaNome_Sel = "";
         AV71TFPedidoDt = DateTime.MinValue;
         AV72TFPedidoDt_To = DateTime.MinValue;
         AV81TFPedidoDtEntrega = DateTime.MinValue;
         AV82TFPedidoDtEntrega_To = DateTime.MinValue;
         AV44ColumnsSelector = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector(context);
         AV61ddo_PedidoIdTitleControlIdToReplace = "";
         AV65ddo_PessoaIdTitleControlIdToReplace = "";
         AV69ddo_PessoaNomeTitleControlIdToReplace = "";
         AV75ddo_PedidoDtTitleControlIdToReplace = "";
         AV79ddo_PedidoStatusTitleControlIdToReplace = "";
         AV85ddo_PedidoDtEntregaTitleControlIdToReplace = "";
         AV88ddo_PedidoRetiradaTitleControlIdToReplace = "";
         AV92ddo_PedidoTotalTitleControlIdToReplace = "";
         AV78TFPedidoStatus_Sels = new GxSimpleCollection<String>();
         AV129Pgmname = "";
         AV10GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV56ManageFiltersData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV93DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV58PedidoIdTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV62PessoaIdTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV66PessoaNomeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV70PedidoDtTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV76PedidoStatusTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV80PedidoDtEntregaTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV86PedidoRetiradaTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV89PedidoTotalTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Gx_date = DateTime.MinValue;
         Ddo_pedidoid_Filteredtext_set = "";
         Ddo_pedidoid_Filteredtextto_set = "";
         Ddo_pedidoid_Sortedstatus = "";
         Ddo_pessoaid_Filteredtext_set = "";
         Ddo_pessoaid_Filteredtextto_set = "";
         Ddo_pessoaid_Sortedstatus = "";
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
         AV97Update = "";
         AV98Delete = "";
         A2PessoaNome = "";
         A33PedidoDt = DateTime.MinValue;
         A34PedidoStatus = "";
         A35PedidoDtEntrega = DateTime.MinValue;
         ucGridpaginationbar = new GXUserControl();
         lblJsdynamicfilters_Jsonclick = "";
         ucDdo_pedidoid = new GXUserControl();
         ucDdo_pessoaid = new GXUserControl();
         ucDdo_pessoanome = new GXUserControl();
         ucDdo_pedidodt = new GXUserControl();
         ucDdo_pedidostatus = new GXUserControl();
         ucDdo_pedidodtentrega = new GXUserControl();
         ucDdo_pedidoretirada = new GXUserControl();
         ucDdo_pedidototal = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         ucDdo_gridcolumnsselector = new GXUserControl();
         AV73DDO_PedidoDtAuxDate = DateTime.MinValue;
         AV74DDO_PedidoDtAuxDateTo = DateTime.MinValue;
         AV83DDO_PedidoDtEntregaAuxDate = DateTime.MinValue;
         AV84DDO_PedidoDtEntregaAuxDateTo = DateTime.MinValue;
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV123WP_GerenciarPedidoDS_23_Tfpedidostatus_sels = new GxSimpleCollection<String>();
         scmdbuf = "";
         lV119WP_GerenciarPedidoDS_19_Tfpessoanome = "";
         AV101WP_GerenciarPedidoDS_1_Dynamicfiltersselector1 = "";
         AV103WP_GerenciarPedidoDS_3_Pedidodt1 = DateTime.MinValue;
         AV104WP_GerenciarPedidoDS_4_Pedidodt_to1 = DateTime.MinValue;
         AV106WP_GerenciarPedidoDS_6_Dynamicfiltersselector2 = "";
         AV108WP_GerenciarPedidoDS_8_Pedidodt2 = DateTime.MinValue;
         AV109WP_GerenciarPedidoDS_9_Pedidodt_to2 = DateTime.MinValue;
         AV111WP_GerenciarPedidoDS_11_Dynamicfiltersselector3 = "";
         AV113WP_GerenciarPedidoDS_13_Pedidodt3 = DateTime.MinValue;
         AV114WP_GerenciarPedidoDS_14_Pedidodt_to3 = DateTime.MinValue;
         AV120WP_GerenciarPedidoDS_20_Tfpessoanome_sel = "";
         AV119WP_GerenciarPedidoDS_19_Tfpessoanome = "";
         AV121WP_GerenciarPedidoDS_21_Tfpedidodt = DateTime.MinValue;
         AV122WP_GerenciarPedidoDS_22_Tfpedidodt_to = DateTime.MinValue;
         AV124WP_GerenciarPedidoDS_24_Tfpedidodtentrega = DateTime.MinValue;
         AV125WP_GerenciarPedidoDS_25_Tfpedidodtentrega_to = DateTime.MinValue;
         H00184_A36PedidoRetirada = new bool[] {false} ;
         H00184_A35PedidoDtEntrega = new DateTime[] {DateTime.MinValue} ;
         H00184_A34PedidoStatus = new String[] {""} ;
         H00184_A33PedidoDt = new DateTime[] {DateTime.MinValue} ;
         H00184_A2PessoaNome = new String[] {""} ;
         H00184_A1PessoaId = new short[1] ;
         H00184_A32PedidoId = new short[1] ;
         H00184_A37PedidoTotal = new decimal[1] ;
         H00184_n37PedidoTotal = new bool[] {false} ;
         H00187_AGRID_nRecordCount = new long[1] ;
         AV7HTTPRequest = new GxHttpRequest( context);
         imgAdddynamicfilters1_Jsonclick = "";
         imgRemovedynamicfilters1_Jsonclick = "";
         imgAdddynamicfilters2_Jsonclick = "";
         imgRemovedynamicfilters2_Jsonclick = "";
         imgRemovedynamicfilters3_Jsonclick = "";
         ucDdo_managefilters = new GXUserControl();
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV51Session = context.GetSession();
         AV32ColumnsSelectorXML = "";
         AV77TFPedidoStatus_SelsJson = "";
         GridRow = new GXWebRow();
         AV53ManageFiltersXml = "";
         AV39UserCustomValue = "";
         GXt_char2 = "";
         AV45ColumnsSelectorAux = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector(context);
         AV57ManageFiltersDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
         AV54ManageFiltersItems = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item>( context, "Item", "");
         AV55ManageFiltersItem = new GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item(context);
         AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV12GridStateDynamicFilter = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter(context);
         AV8TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         Ddo_managefilters_Caption = "";
         lblDynamicfiltersprefix1_Jsonclick = "";
         lblDynamicfiltersmiddle1_Jsonclick = "";
         lblDynamicfiltersprefix2_Jsonclick = "";
         lblDynamicfiltersmiddle2_Jsonclick = "";
         lblDynamicfiltersprefix3_Jsonclick = "";
         lblDynamicfiltersmiddle3_Jsonclick = "";
         sImgUrl = "";
         lblPedidodt_rangemiddletext_13_Jsonclick = "";
         lblPedidodt_rangemiddletext_12_Jsonclick = "";
         lblPedidodt_rangemiddletext_11_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wp_gerenciarpedido__default(),
            new Object[][] {
                new Object[] {
               H00184_A36PedidoRetirada, H00184_A35PedidoDtEntrega, H00184_A34PedidoStatus, H00184_A33PedidoDt, H00184_A2PessoaNome, H00184_A1PessoaId, H00184_A32PedidoId, H00184_A37PedidoTotal, H00184_n37PedidoTotal
               }
               , new Object[] {
               H00187_AGRID_nRecordCount
               }
            }
         );
         Gx_date = DateTimeUtil.Today( context);
         AV129Pgmname = "WP_GerenciarPedido";
         /* GeneXus formulas. */
         Gx_date = DateTimeUtil.Today( context);
         AV129Pgmname = "WP_GerenciarPedido";
         context.Gx_err = 0;
         edtavUpdate_Enabled = 0;
         edtavDelete_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_134 ;
      private short nGXsfl_134_idx=1 ;
      private short GRID_nEOF ;
      private short AV17DynamicFiltersOperator1 ;
      private short AV22DynamicFiltersOperator2 ;
      private short AV27DynamicFiltersOperator3 ;
      private short AV13OrderedBy ;
      private short AV59TFPedidoId ;
      private short AV60TFPedidoId_To ;
      private short AV63TFPessoaId ;
      private short AV64TFPessoaId_To ;
      private short AV87TFPedidoRetirada_Sel ;
      private short AV52ManageFiltersExecutionStep ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtPedidoId_Titleformat ;
      private short edtPessoaId_Titleformat ;
      private short edtPessoaNome_Titleformat ;
      private short edtPedidoDt_Titleformat ;
      private short cmbPedidoStatus_Titleformat ;
      private short edtPedidoDtEntrega_Titleformat ;
      private short chkPedidoRetirada_Titleformat ;
      private short edtPedidoTotal_Titleformat ;
      private short subGrid_Sortable ;
      private short A32PedidoId ;
      private short A1PessoaId ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV102WP_GerenciarPedidoDS_2_Dynamicfiltersoperator1 ;
      private short AV107WP_GerenciarPedidoDS_7_Dynamicfiltersoperator2 ;
      private short AV112WP_GerenciarPedidoDS_12_Dynamicfiltersoperator3 ;
      private short AV115WP_GerenciarPedidoDS_15_Tfpedidoid ;
      private short AV116WP_GerenciarPedidoDS_16_Tfpedidoid_to ;
      private short AV117WP_GerenciarPedidoDS_17_Tfpessoaid ;
      private short AV118WP_GerenciarPedidoDS_18_Tfpessoaid_to ;
      private short AV126WP_GerenciarPedidoDS_26_Tfpedidoretirada_sel ;
      private short nGXWrapped ;
      private short subGrid_Backstyle ;
      private int subGrid_Rows ;
      private int Gridpaginationbar_Rowsperpageselectedvalue ;
      private int Gridpaginationbar_Pagestoshow ;
      private int Ddo_pessoanome_Datalistupdateminimumcharacters ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtPedidoId_Visible ;
      private int edtPessoaId_Visible ;
      private int edtPessoaNome_Visible ;
      private int edtPedidoDt_Visible ;
      private int edtPedidoDtEntrega_Visible ;
      private int edtPedidoTotal_Visible ;
      private int edtavUpdate_Enabled ;
      private int edtavDelete_Enabled ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_pedidoidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_pessoaidtitlecontrolidtoreplace_Visible ;
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
      private int edtavTfpessoaid_Visible ;
      private int edtavTfpessoaid_to_Visible ;
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
      private int AV123WP_GerenciarPedidoDS_23_Tfpedidostatus_sels_Count ;
      private int AV94PageToGo ;
      private int imgAdddynamicfilters1_Visible ;
      private int imgRemovedynamicfilters1_Visible ;
      private int imgAdddynamicfilters2_Visible ;
      private int imgRemovedynamicfilters2_Visible ;
      private int tblTablemergeddynamicfilterspedidodt1_Visible ;
      private int tblTablemergeddynamicfilterspedidodt2_Visible ;
      private int tblTablemergeddynamicfilterspedidodt3_Visible ;
      private int AV131GXV1 ;
      private int AV132GXV2 ;
      private int edtavPedidodt3_Enabled ;
      private int edtavPedidodt_to3_Enabled ;
      private int edtavPedidodt2_Enabled ;
      private int edtavPedidodt_to2_Enabled ;
      private int edtavPedidodt1_Enabled ;
      private int edtavPedidodt_to1_Enabled ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long AV95GridCurrentPage ;
      private long AV96GridPageCount ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private decimal AV90TFPedidoTotal ;
      private decimal AV91TFPedidoTotal_To ;
      private decimal A37PedidoTotal ;
      private decimal AV127WP_GerenciarPedidoDS_27_Tfpedidototal ;
      private decimal AV128WP_GerenciarPedidoDS_28_Tfpedidototal_to ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_pedidoid_Activeeventkey ;
      private String Ddo_pedidoid_Filteredtext_get ;
      private String Ddo_pedidoid_Filteredtextto_get ;
      private String Ddo_pessoaid_Activeeventkey ;
      private String Ddo_pessoaid_Filteredtext_get ;
      private String Ddo_pessoaid_Filteredtextto_get ;
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
      private String sGXsfl_134_idx="0001" ;
      private String AV129Pgmname ;
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
      private String Ddo_pessoaid_Caption ;
      private String Ddo_pessoaid_Tooltip ;
      private String Ddo_pessoaid_Cls ;
      private String Ddo_pessoaid_Filteredtext_set ;
      private String Ddo_pessoaid_Filteredtextto_set ;
      private String Ddo_pessoaid_Dropdownoptionstype ;
      private String Ddo_pessoaid_Titlecontrolidtoreplace ;
      private String Ddo_pessoaid_Sortedstatus ;
      private String Ddo_pessoaid_Filtertype ;
      private String Ddo_pessoaid_Sortasc ;
      private String Ddo_pessoaid_Sortdsc ;
      private String Ddo_pessoaid_Cleanfilter ;
      private String Ddo_pessoaid_Rangefilterfrom ;
      private String Ddo_pessoaid_Rangefilterto ;
      private String Ddo_pessoaid_Searchbuttontext ;
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
      private String Ddo_pedidototal_Filtertype ;
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
      private String edtPessoaId_Title ;
      private String edtPessoaNome_Title ;
      private String edtPedidoDt_Title ;
      private String edtPedidoDtEntrega_Title ;
      private String edtPedidoTotal_Title ;
      private String subGrid_Header ;
      private String AV97Update ;
      private String edtavUpdate_Link ;
      private String AV98Delete ;
      private String edtavDelete_Link ;
      private String edtPedidoDt_Link ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String lblJsdynamicfilters_Internalname ;
      private String lblJsdynamicfilters_Caption ;
      private String lblJsdynamicfilters_Jsonclick ;
      private String Ddo_pedidoid_Internalname ;
      private String edtavDdo_pedidoidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_pessoaid_Internalname ;
      private String edtavDdo_pessoaidtitlecontrolidtoreplace_Internalname ;
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
      private String chkavDynamicfiltersenabled2_Internalname ;
      private String chkavDynamicfiltersenabled3_Internalname ;
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
      private String edtavTfpessoaid_Internalname ;
      private String edtavTfpessoaid_Jsonclick ;
      private String edtavTfpessoaid_to_Internalname ;
      private String edtavTfpessoaid_to_Jsonclick ;
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
      private String edtPedidoId_Internalname ;
      private String edtPessoaId_Internalname ;
      private String edtPessoaNome_Internalname ;
      private String edtPedidoDt_Internalname ;
      private String cmbPedidoStatus_Internalname ;
      private String edtPedidoDtEntrega_Internalname ;
      private String chkPedidoRetirada_Internalname ;
      private String edtPedidoTotal_Internalname ;
      private String cmbavDynamicfiltersselector1_Internalname ;
      private String cmbavDynamicfiltersoperator1_Internalname ;
      private String cmbavDynamicfiltersselector2_Internalname ;
      private String cmbavDynamicfiltersoperator2_Internalname ;
      private String cmbavDynamicfiltersselector3_Internalname ;
      private String cmbavDynamicfiltersoperator3_Internalname ;
      private String scmdbuf ;
      private String edtavPedidodt1_Internalname ;
      private String edtavPedidodt_to1_Internalname ;
      private String edtavPedidodt2_Internalname ;
      private String edtavPedidodt_to2_Internalname ;
      private String edtavPedidodt3_Internalname ;
      private String edtavPedidodt_to3_Internalname ;
      private String imgAdddynamicfilters1_Jsonclick ;
      private String tblTabledynamicfilters_Internalname ;
      private String imgAdddynamicfilters1_Internalname ;
      private String imgRemovedynamicfilters1_Jsonclick ;
      private String imgRemovedynamicfilters1_Internalname ;
      private String imgAdddynamicfilters2_Jsonclick ;
      private String imgAdddynamicfilters2_Internalname ;
      private String imgRemovedynamicfilters2_Jsonclick ;
      private String imgRemovedynamicfilters2_Internalname ;
      private String imgRemovedynamicfilters3_Jsonclick ;
      private String imgRemovedynamicfilters3_Internalname ;
      private String Ddo_managefilters_Internalname ;
      private String GXt_char2 ;
      private String tblTablemergeddynamicfilterspedidodt1_Internalname ;
      private String cellPedidodt_cell1_Class ;
      private String cellPedidodt_cell1_Internalname ;
      private String cellPedidodt_to_cell1_Class ;
      private String cellPedidodt_to_cell1_Internalname ;
      private String lblPedidodt_rangemiddletext_11_Class ;
      private String lblPedidodt_rangemiddletext_11_Internalname ;
      private String tblTablemergeddynamicfilterspedidodt2_Internalname ;
      private String cellPedidodt_cell2_Class ;
      private String cellPedidodt_cell2_Internalname ;
      private String cellPedidodt_to_cell2_Class ;
      private String cellPedidodt_to_cell2_Internalname ;
      private String lblPedidodt_rangemiddletext_12_Class ;
      private String lblPedidodt_rangemiddletext_12_Internalname ;
      private String tblTablemergeddynamicfilterspedidodt3_Internalname ;
      private String cellPedidodt_cell3_Class ;
      private String cellPedidodt_cell3_Internalname ;
      private String cellPedidodt_to_cell3_Class ;
      private String cellPedidodt_to_cell3_Internalname ;
      private String lblPedidodt_rangemiddletext_13_Class ;
      private String lblPedidodt_rangemiddletext_13_Internalname ;
      private String tblTablerightheader_Internalname ;
      private String Ddo_managefilters_Caption ;
      private String tblTablefilters_Internalname ;
      private String lblDynamicfiltersprefix1_Internalname ;
      private String lblDynamicfiltersprefix1_Jsonclick ;
      private String cmbavDynamicfiltersselector1_Jsonclick ;
      private String lblDynamicfiltersmiddle1_Internalname ;
      private String lblDynamicfiltersmiddle1_Jsonclick ;
      private String lblDynamicfiltersprefix2_Internalname ;
      private String lblDynamicfiltersprefix2_Jsonclick ;
      private String cmbavDynamicfiltersselector2_Jsonclick ;
      private String lblDynamicfiltersmiddle2_Internalname ;
      private String lblDynamicfiltersmiddle2_Jsonclick ;
      private String lblDynamicfiltersprefix3_Internalname ;
      private String lblDynamicfiltersprefix3_Jsonclick ;
      private String cmbavDynamicfiltersselector3_Jsonclick ;
      private String lblDynamicfiltersmiddle3_Internalname ;
      private String lblDynamicfiltersmiddle3_Jsonclick ;
      private String tblUnnamedtabledynamicfilters_3_Internalname ;
      private String cellDynamicfilters_removefilter3_cell_Internalname ;
      private String sImgUrl ;
      private String tblTablemergeddynamicfilters3_Internalname ;
      private String cmbavDynamicfiltersoperator3_Jsonclick ;
      private String cellFilter_pedidodt3_cell_Internalname ;
      private String edtavPedidodt3_Jsonclick ;
      private String cellPedidodt_rangemiddletext_1_cell3_Internalname ;
      private String lblPedidodt_rangemiddletext_13_Jsonclick ;
      private String edtavPedidodt_to3_Jsonclick ;
      private String tblUnnamedtabledynamicfilters_2_Internalname ;
      private String cellDynamicfilters_addfilter2_cell_Internalname ;
      private String cellDynamicfilters_removefilter2_cell_Internalname ;
      private String tblTablemergeddynamicfilters2_Internalname ;
      private String cmbavDynamicfiltersoperator2_Jsonclick ;
      private String cellFilter_pedidodt2_cell_Internalname ;
      private String edtavPedidodt2_Jsonclick ;
      private String cellPedidodt_rangemiddletext_1_cell2_Internalname ;
      private String lblPedidodt_rangemiddletext_12_Jsonclick ;
      private String edtavPedidodt_to2_Jsonclick ;
      private String tblUnnamedtabledynamicfilters_1_Internalname ;
      private String cellDynamicfilters_addfilter1_cell_Internalname ;
      private String cellDynamicfilters_removefilter1_cell_Internalname ;
      private String tblTablemergeddynamicfilters1_Internalname ;
      private String cmbavDynamicfiltersoperator1_Jsonclick ;
      private String cellFilter_pedidodt1_cell_Internalname ;
      private String edtavPedidodt1_Jsonclick ;
      private String cellPedidodt_rangemiddletext_1_cell1_Internalname ;
      private String lblPedidodt_rangemiddletext_11_Jsonclick ;
      private String edtavPedidodt_to1_Jsonclick ;
      private String sGXsfl_134_fel_idx="0001" ;
      private String ROClassString ;
      private String edtavUpdate_Jsonclick ;
      private String edtavDelete_Jsonclick ;
      private String edtPedidoId_Jsonclick ;
      private String edtPessoaId_Jsonclick ;
      private String edtPessoaNome_Jsonclick ;
      private String edtPedidoDt_Jsonclick ;
      private String GXCCtl ;
      private String cmbPedidoStatus_Jsonclick ;
      private String edtPedidoDtEntrega_Jsonclick ;
      private String edtPedidoTotal_Jsonclick ;
      private DateTime AV18PedidoDt1 ;
      private DateTime AV19PedidoDt_To1 ;
      private DateTime AV23PedidoDt2 ;
      private DateTime AV24PedidoDt_To2 ;
      private DateTime AV28PedidoDt3 ;
      private DateTime AV29PedidoDt_To3 ;
      private DateTime AV71TFPedidoDt ;
      private DateTime AV72TFPedidoDt_To ;
      private DateTime AV81TFPedidoDtEntrega ;
      private DateTime AV82TFPedidoDtEntrega_To ;
      private DateTime Gx_date ;
      private DateTime A33PedidoDt ;
      private DateTime A35PedidoDtEntrega ;
      private DateTime AV73DDO_PedidoDtAuxDate ;
      private DateTime AV74DDO_PedidoDtAuxDateTo ;
      private DateTime AV83DDO_PedidoDtEntregaAuxDate ;
      private DateTime AV84DDO_PedidoDtEntregaAuxDateTo ;
      private DateTime AV103WP_GerenciarPedidoDS_3_Pedidodt1 ;
      private DateTime AV104WP_GerenciarPedidoDS_4_Pedidodt_to1 ;
      private DateTime AV108WP_GerenciarPedidoDS_8_Pedidodt2 ;
      private DateTime AV109WP_GerenciarPedidoDS_9_Pedidodt_to2 ;
      private DateTime AV113WP_GerenciarPedidoDS_13_Pedidodt3 ;
      private DateTime AV114WP_GerenciarPedidoDS_14_Pedidodt_to3 ;
      private DateTime AV121WP_GerenciarPedidoDS_21_Tfpedidodt ;
      private DateTime AV122WP_GerenciarPedidoDS_22_Tfpedidodt_to ;
      private DateTime AV124WP_GerenciarPedidoDS_24_Tfpedidodtentrega ;
      private DateTime AV125WP_GerenciarPedidoDS_25_Tfpedidodtentrega_to ;
      private bool entryPointCalled ;
      private bool AV20DynamicFiltersEnabled2 ;
      private bool AV25DynamicFiltersEnabled3 ;
      private bool AV14OrderedDsc ;
      private bool AV31DynamicFiltersIgnoreFirst ;
      private bool AV30DynamicFiltersRemoving ;
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
      private bool Ddo_pessoaid_Includesortasc ;
      private bool Ddo_pessoaid_Includesortdsc ;
      private bool Ddo_pessoaid_Includefilter ;
      private bool Ddo_pessoaid_Filterisrange ;
      private bool Ddo_pessoaid_Includedatalist ;
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
      private bool n37PedidoTotal ;
      private bool bGXsfl_134_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool AV105WP_GerenciarPedidoDS_5_Dynamicfiltersenabled2 ;
      private bool AV110WP_GerenciarPedidoDS_10_Dynamicfiltersenabled3 ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private String AV32ColumnsSelectorXML ;
      private String AV77TFPedidoStatus_SelsJson ;
      private String AV53ManageFiltersXml ;
      private String AV39UserCustomValue ;
      private String AV16DynamicFiltersSelector1 ;
      private String AV21DynamicFiltersSelector2 ;
      private String AV26DynamicFiltersSelector3 ;
      private String AV67TFPessoaNome ;
      private String AV68TFPessoaNome_Sel ;
      private String AV61ddo_PedidoIdTitleControlIdToReplace ;
      private String AV65ddo_PessoaIdTitleControlIdToReplace ;
      private String AV69ddo_PessoaNomeTitleControlIdToReplace ;
      private String AV75ddo_PedidoDtTitleControlIdToReplace ;
      private String AV79ddo_PedidoStatusTitleControlIdToReplace ;
      private String AV85ddo_PedidoDtEntregaTitleControlIdToReplace ;
      private String AV88ddo_PedidoRetiradaTitleControlIdToReplace ;
      private String AV92ddo_PedidoTotalTitleControlIdToReplace ;
      private String A2PessoaNome ;
      private String A34PedidoStatus ;
      private String lV119WP_GerenciarPedidoDS_19_Tfpessoanome ;
      private String AV101WP_GerenciarPedidoDS_1_Dynamicfiltersselector1 ;
      private String AV106WP_GerenciarPedidoDS_6_Dynamicfiltersselector2 ;
      private String AV111WP_GerenciarPedidoDS_11_Dynamicfiltersselector3 ;
      private String AV120WP_GerenciarPedidoDS_20_Tfpessoanome_sel ;
      private String AV119WP_GerenciarPedidoDS_19_Tfpessoanome ;
      private IGxSession AV51Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_pedidoid ;
      private GXUserControl ucDdo_pessoaid ;
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
      private GXCombobox cmbavDynamicfiltersselector1 ;
      private GXCombobox cmbavDynamicfiltersoperator1 ;
      private GXCombobox cmbavDynamicfiltersselector2 ;
      private GXCombobox cmbavDynamicfiltersoperator2 ;
      private GXCombobox cmbavDynamicfiltersselector3 ;
      private GXCombobox cmbavDynamicfiltersoperator3 ;
      private GXCombobox cmbPedidoStatus ;
      private GXCheckbox chkPedidoRetirada ;
      private GXCheckbox chkavDynamicfiltersenabled2 ;
      private GXCheckbox chkavDynamicfiltersenabled3 ;
      private IDataStoreProvider pr_default ;
      private bool[] H00184_A36PedidoRetirada ;
      private DateTime[] H00184_A35PedidoDtEntrega ;
      private String[] H00184_A34PedidoStatus ;
      private DateTime[] H00184_A33PedidoDt ;
      private String[] H00184_A2PessoaNome ;
      private short[] H00184_A1PessoaId ;
      private short[] H00184_A32PedidoId ;
      private decimal[] H00184_A37PedidoTotal ;
      private bool[] H00184_n37PedidoTotal ;
      private long[] H00187_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV7HTTPRequest ;
      private GxSimpleCollection<String> AV78TFPedidoStatus_Sels ;
      private GxSimpleCollection<String> AV123WP_GerenciarPedidoDS_23_Tfpedidostatus_sels ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item> AV54ManageFiltersItems ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV56ManageFiltersData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV58PedidoIdTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV62PessoaIdTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV66PessoaNomeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV70PedidoDtTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV76PedidoStatusTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV80PedidoDtEntregaTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV86PedidoRetiradaTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV89PedidoTotalTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV8TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV10GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV11GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter AV12GridStateDynamicFilter ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector AV44ColumnsSelector ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector AV45ColumnsSelectorAux ;
      private GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item AV55ManageFiltersItem ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item AV57ManageFiltersDataItem ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV93DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class wp_gerenciarpedido__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00184( IGxContext context ,
                                             String A34PedidoStatus ,
                                             GxSimpleCollection<String> AV123WP_GerenciarPedidoDS_23_Tfpedidostatus_sels ,
                                             String AV101WP_GerenciarPedidoDS_1_Dynamicfiltersselector1 ,
                                             short AV102WP_GerenciarPedidoDS_2_Dynamicfiltersoperator1 ,
                                             DateTime AV103WP_GerenciarPedidoDS_3_Pedidodt1 ,
                                             DateTime AV104WP_GerenciarPedidoDS_4_Pedidodt_to1 ,
                                             bool AV105WP_GerenciarPedidoDS_5_Dynamicfiltersenabled2 ,
                                             String AV106WP_GerenciarPedidoDS_6_Dynamicfiltersselector2 ,
                                             short AV107WP_GerenciarPedidoDS_7_Dynamicfiltersoperator2 ,
                                             DateTime AV108WP_GerenciarPedidoDS_8_Pedidodt2 ,
                                             DateTime AV109WP_GerenciarPedidoDS_9_Pedidodt_to2 ,
                                             bool AV110WP_GerenciarPedidoDS_10_Dynamicfiltersenabled3 ,
                                             String AV111WP_GerenciarPedidoDS_11_Dynamicfiltersselector3 ,
                                             short AV112WP_GerenciarPedidoDS_12_Dynamicfiltersoperator3 ,
                                             DateTime AV113WP_GerenciarPedidoDS_13_Pedidodt3 ,
                                             DateTime AV114WP_GerenciarPedidoDS_14_Pedidodt_to3 ,
                                             short AV115WP_GerenciarPedidoDS_15_Tfpedidoid ,
                                             short AV116WP_GerenciarPedidoDS_16_Tfpedidoid_to ,
                                             short AV117WP_GerenciarPedidoDS_17_Tfpessoaid ,
                                             short AV118WP_GerenciarPedidoDS_18_Tfpessoaid_to ,
                                             String AV120WP_GerenciarPedidoDS_20_Tfpessoanome_sel ,
                                             String AV119WP_GerenciarPedidoDS_19_Tfpessoanome ,
                                             DateTime AV121WP_GerenciarPedidoDS_21_Tfpedidodt ,
                                             DateTime AV122WP_GerenciarPedidoDS_22_Tfpedidodt_to ,
                                             int AV123WP_GerenciarPedidoDS_23_Tfpedidostatus_sels_Count ,
                                             DateTime AV124WP_GerenciarPedidoDS_24_Tfpedidodtentrega ,
                                             DateTime AV125WP_GerenciarPedidoDS_25_Tfpedidodtentrega_to ,
                                             short AV126WP_GerenciarPedidoDS_26_Tfpedidoretirada_sel ,
                                             DateTime A33PedidoDt ,
                                             short A32PedidoId ,
                                             short A1PessoaId ,
                                             String A2PessoaNome ,
                                             DateTime A35PedidoDtEntrega ,
                                             bool A36PedidoRetirada ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc ,
                                             decimal AV127WP_GerenciarPedidoDS_27_Tfpedidototal ,
                                             decimal A37PedidoTotal ,
                                             decimal AV128WP_GerenciarPedidoDS_28_Tfpedidototal_to )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [32] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " T1.[PedidoRetirada], T1.[PedidoDtEntrega], T1.[PedidoStatus], T1.[PedidoDt], T2.[PessoaNome], T1.[PessoaId], T1.[PedidoId], COALESCE( T3.[PedidoTotal], 0) AS PedidoTotal";
         sFromString = " FROM (([Pedido] T1 INNER JOIN [Pessoa] T2 ON T2.[PessoaId] = T1.[PessoaId]) LEFT JOIN (SELECT COALESCE( T5.[GXC1], 0) AS PedidoTotal, T4.[PedidoId] FROM ([Pedido] T4 LEFT JOIN (SELECT SUM(T7.[ProdutoValor] * CAST(T6.[PedidoItemQtd] AS decimal( 22, 10))) AS GXC1, T6.[PedidoId] FROM ([PedidoItem] T6 INNER JOIN [Produto] T7 ON T7.[ProdutoId] = T6.[ProdutoId]) GROUP BY T6.[PedidoId] ) T5 ON T5.[PedidoId] = T4.[PedidoId]) ) T3 ON T3.[PedidoId] = T1.[PedidoId])";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ((@AV127WP_GerenciarPedidoDS_27_Tfpedidototal = convert(int, 0)) or ( COALESCE( T3.[PedidoTotal], 0) >= @AV127WP_GerenciarPedidoDS_27_Tfpedidototal))";
         sWhereString = sWhereString + " and ((@AV128WP_GerenciarPedidoDS_28_Tfpedidototal_to = convert(int, 0)) or ( COALESCE( T3.[PedidoTotal], 0) <= @AV128WP_GerenciarPedidoDS_28_Tfpedidototal_to))";
         if ( ( StringUtil.StrCmp(AV101WP_GerenciarPedidoDS_1_Dynamicfiltersselector1, "PEDIDODT") == 0 ) && ( AV102WP_GerenciarPedidoDS_2_Dynamicfiltersoperator1 == 0 ) && ( ! (DateTime.MinValue==AV103WP_GerenciarPedidoDS_3_Pedidodt1) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDt] < @AV103WP_GerenciarPedidoDS_3_Pedidodt1)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ( StringUtil.StrCmp(AV101WP_GerenciarPedidoDS_1_Dynamicfiltersselector1, "PEDIDODT") == 0 ) && ( AV102WP_GerenciarPedidoDS_2_Dynamicfiltersoperator1 == 1 ) && ( ! (DateTime.MinValue==AV103WP_GerenciarPedidoDS_3_Pedidodt1) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDt] = @AV103WP_GerenciarPedidoDS_3_Pedidodt1)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ( StringUtil.StrCmp(AV101WP_GerenciarPedidoDS_1_Dynamicfiltersselector1, "PEDIDODT") == 0 ) && ( AV102WP_GerenciarPedidoDS_2_Dynamicfiltersoperator1 == 2 ) && ( ! (DateTime.MinValue==AV103WP_GerenciarPedidoDS_3_Pedidodt1) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDt] > @AV103WP_GerenciarPedidoDS_3_Pedidodt1)";
         }
         else
         {
            GXv_int3[6] = 1;
         }
         if ( ( StringUtil.StrCmp(AV101WP_GerenciarPedidoDS_1_Dynamicfiltersselector1, "PEDIDODT") == 0 ) && ( AV102WP_GerenciarPedidoDS_2_Dynamicfiltersoperator1 == 3 ) && ( ! (DateTime.MinValue==AV103WP_GerenciarPedidoDS_3_Pedidodt1) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDt] >= @AV103WP_GerenciarPedidoDS_3_Pedidodt1)";
         }
         else
         {
            GXv_int3[7] = 1;
         }
         if ( ( StringUtil.StrCmp(AV101WP_GerenciarPedidoDS_1_Dynamicfiltersselector1, "PEDIDODT") == 0 ) && ( AV102WP_GerenciarPedidoDS_2_Dynamicfiltersoperator1 == 3 ) && ( ! (DateTime.MinValue==AV104WP_GerenciarPedidoDS_4_Pedidodt_to1) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDt] <= @AV104WP_GerenciarPedidoDS_4_Pedidodt_to1)";
         }
         else
         {
            GXv_int3[8] = 1;
         }
         if ( AV105WP_GerenciarPedidoDS_5_Dynamicfiltersenabled2 && ( StringUtil.StrCmp(AV106WP_GerenciarPedidoDS_6_Dynamicfiltersselector2, "PEDIDODT") == 0 ) && ( AV107WP_GerenciarPedidoDS_7_Dynamicfiltersoperator2 == 0 ) && ( ! (DateTime.MinValue==AV108WP_GerenciarPedidoDS_8_Pedidodt2) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDt] < @AV108WP_GerenciarPedidoDS_8_Pedidodt2)";
         }
         else
         {
            GXv_int3[9] = 1;
         }
         if ( AV105WP_GerenciarPedidoDS_5_Dynamicfiltersenabled2 && ( StringUtil.StrCmp(AV106WP_GerenciarPedidoDS_6_Dynamicfiltersselector2, "PEDIDODT") == 0 ) && ( AV107WP_GerenciarPedidoDS_7_Dynamicfiltersoperator2 == 1 ) && ( ! (DateTime.MinValue==AV108WP_GerenciarPedidoDS_8_Pedidodt2) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDt] = @AV108WP_GerenciarPedidoDS_8_Pedidodt2)";
         }
         else
         {
            GXv_int3[10] = 1;
         }
         if ( AV105WP_GerenciarPedidoDS_5_Dynamicfiltersenabled2 && ( StringUtil.StrCmp(AV106WP_GerenciarPedidoDS_6_Dynamicfiltersselector2, "PEDIDODT") == 0 ) && ( AV107WP_GerenciarPedidoDS_7_Dynamicfiltersoperator2 == 2 ) && ( ! (DateTime.MinValue==AV108WP_GerenciarPedidoDS_8_Pedidodt2) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDt] > @AV108WP_GerenciarPedidoDS_8_Pedidodt2)";
         }
         else
         {
            GXv_int3[11] = 1;
         }
         if ( AV105WP_GerenciarPedidoDS_5_Dynamicfiltersenabled2 && ( StringUtil.StrCmp(AV106WP_GerenciarPedidoDS_6_Dynamicfiltersselector2, "PEDIDODT") == 0 ) && ( AV107WP_GerenciarPedidoDS_7_Dynamicfiltersoperator2 == 3 ) && ( ! (DateTime.MinValue==AV108WP_GerenciarPedidoDS_8_Pedidodt2) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDt] >= @AV108WP_GerenciarPedidoDS_8_Pedidodt2)";
         }
         else
         {
            GXv_int3[12] = 1;
         }
         if ( AV105WP_GerenciarPedidoDS_5_Dynamicfiltersenabled2 && ( StringUtil.StrCmp(AV106WP_GerenciarPedidoDS_6_Dynamicfiltersselector2, "PEDIDODT") == 0 ) && ( AV107WP_GerenciarPedidoDS_7_Dynamicfiltersoperator2 == 3 ) && ( ! (DateTime.MinValue==AV109WP_GerenciarPedidoDS_9_Pedidodt_to2) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDt] <= @AV109WP_GerenciarPedidoDS_9_Pedidodt_to2)";
         }
         else
         {
            GXv_int3[13] = 1;
         }
         if ( AV110WP_GerenciarPedidoDS_10_Dynamicfiltersenabled3 && ( StringUtil.StrCmp(AV111WP_GerenciarPedidoDS_11_Dynamicfiltersselector3, "PEDIDODT") == 0 ) && ( AV112WP_GerenciarPedidoDS_12_Dynamicfiltersoperator3 == 0 ) && ( ! (DateTime.MinValue==AV113WP_GerenciarPedidoDS_13_Pedidodt3) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDt] < @AV113WP_GerenciarPedidoDS_13_Pedidodt3)";
         }
         else
         {
            GXv_int3[14] = 1;
         }
         if ( AV110WP_GerenciarPedidoDS_10_Dynamicfiltersenabled3 && ( StringUtil.StrCmp(AV111WP_GerenciarPedidoDS_11_Dynamicfiltersselector3, "PEDIDODT") == 0 ) && ( AV112WP_GerenciarPedidoDS_12_Dynamicfiltersoperator3 == 1 ) && ( ! (DateTime.MinValue==AV113WP_GerenciarPedidoDS_13_Pedidodt3) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDt] = @AV113WP_GerenciarPedidoDS_13_Pedidodt3)";
         }
         else
         {
            GXv_int3[15] = 1;
         }
         if ( AV110WP_GerenciarPedidoDS_10_Dynamicfiltersenabled3 && ( StringUtil.StrCmp(AV111WP_GerenciarPedidoDS_11_Dynamicfiltersselector3, "PEDIDODT") == 0 ) && ( AV112WP_GerenciarPedidoDS_12_Dynamicfiltersoperator3 == 2 ) && ( ! (DateTime.MinValue==AV113WP_GerenciarPedidoDS_13_Pedidodt3) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDt] > @AV113WP_GerenciarPedidoDS_13_Pedidodt3)";
         }
         else
         {
            GXv_int3[16] = 1;
         }
         if ( AV110WP_GerenciarPedidoDS_10_Dynamicfiltersenabled3 && ( StringUtil.StrCmp(AV111WP_GerenciarPedidoDS_11_Dynamicfiltersselector3, "PEDIDODT") == 0 ) && ( AV112WP_GerenciarPedidoDS_12_Dynamicfiltersoperator3 == 3 ) && ( ! (DateTime.MinValue==AV113WP_GerenciarPedidoDS_13_Pedidodt3) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDt] >= @AV113WP_GerenciarPedidoDS_13_Pedidodt3)";
         }
         else
         {
            GXv_int3[17] = 1;
         }
         if ( AV110WP_GerenciarPedidoDS_10_Dynamicfiltersenabled3 && ( StringUtil.StrCmp(AV111WP_GerenciarPedidoDS_11_Dynamicfiltersselector3, "PEDIDODT") == 0 ) && ( AV112WP_GerenciarPedidoDS_12_Dynamicfiltersoperator3 == 3 ) && ( ! (DateTime.MinValue==AV114WP_GerenciarPedidoDS_14_Pedidodt_to3) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDt] <= @AV114WP_GerenciarPedidoDS_14_Pedidodt_to3)";
         }
         else
         {
            GXv_int3[18] = 1;
         }
         if ( ! (0==AV115WP_GerenciarPedidoDS_15_Tfpedidoid) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoId] >= @AV115WP_GerenciarPedidoDS_15_Tfpedidoid)";
         }
         else
         {
            GXv_int3[19] = 1;
         }
         if ( ! (0==AV116WP_GerenciarPedidoDS_16_Tfpedidoid_to) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoId] <= @AV116WP_GerenciarPedidoDS_16_Tfpedidoid_to)";
         }
         else
         {
            GXv_int3[20] = 1;
         }
         if ( ! (0==AV117WP_GerenciarPedidoDS_17_Tfpessoaid) )
         {
            sWhereString = sWhereString + " and (T1.[PessoaId] >= @AV117WP_GerenciarPedidoDS_17_Tfpessoaid)";
         }
         else
         {
            GXv_int3[21] = 1;
         }
         if ( ! (0==AV118WP_GerenciarPedidoDS_18_Tfpessoaid_to) )
         {
            sWhereString = sWhereString + " and (T1.[PessoaId] <= @AV118WP_GerenciarPedidoDS_18_Tfpessoaid_to)";
         }
         else
         {
            GXv_int3[22] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV120WP_GerenciarPedidoDS_20_Tfpessoanome_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV119WP_GerenciarPedidoDS_19_Tfpessoanome)) ) )
         {
            sWhereString = sWhereString + " and (T2.[PessoaNome] like @lV119WP_GerenciarPedidoDS_19_Tfpessoanome)";
         }
         else
         {
            GXv_int3[23] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV120WP_GerenciarPedidoDS_20_Tfpessoanome_sel)) )
         {
            sWhereString = sWhereString + " and (T2.[PessoaNome] = @AV120WP_GerenciarPedidoDS_20_Tfpessoanome_sel)";
         }
         else
         {
            GXv_int3[24] = 1;
         }
         if ( ! (DateTime.MinValue==AV121WP_GerenciarPedidoDS_21_Tfpedidodt) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDt] >= @AV121WP_GerenciarPedidoDS_21_Tfpedidodt)";
         }
         else
         {
            GXv_int3[25] = 1;
         }
         if ( ! (DateTime.MinValue==AV122WP_GerenciarPedidoDS_22_Tfpedidodt_to) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDt] <= @AV122WP_GerenciarPedidoDS_22_Tfpedidodt_to)";
         }
         else
         {
            GXv_int3[26] = 1;
         }
         if ( AV123WP_GerenciarPedidoDS_23_Tfpedidostatus_sels_Count > 0 )
         {
            sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV123WP_GerenciarPedidoDS_23_Tfpedidostatus_sels, "T1.[PedidoStatus] IN (", ")") + ")";
         }
         if ( ! (DateTime.MinValue==AV124WP_GerenciarPedidoDS_24_Tfpedidodtentrega) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDtEntrega] >= @AV124WP_GerenciarPedidoDS_24_Tfpedidodtentrega)";
         }
         else
         {
            GXv_int3[27] = 1;
         }
         if ( ! (DateTime.MinValue==AV125WP_GerenciarPedidoDS_25_Tfpedidodtentrega_to) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDtEntrega] <= @AV125WP_GerenciarPedidoDS_25_Tfpedidodtentrega_to)";
         }
         else
         {
            GXv_int3[28] = 1;
         }
         if ( AV126WP_GerenciarPedidoDS_26_Tfpedidoretirada_sel == 1 )
         {
            sWhereString = sWhereString + " and (T1.[PedidoRetirada] = 1)";
         }
         if ( AV126WP_GerenciarPedidoDS_26_Tfpedidoretirada_sel == 2 )
         {
            sWhereString = sWhereString + " and (T1.[PedidoRetirada] = 0)";
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
            sOrderString = sOrderString + " ORDER BY T1.[PessoaId]";
         }
         else if ( ( AV13OrderedBy == 3 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[PessoaId] DESC";
         }
         else if ( ( AV13OrderedBy == 4 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T2.[PessoaNome]";
         }
         else if ( ( AV13OrderedBy == 4 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T2.[PessoaNome] DESC";
         }
         else if ( ( AV13OrderedBy == 5 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[PedidoStatus]";
         }
         else if ( ( AV13OrderedBy == 5 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[PedidoStatus] DESC";
         }
         else if ( ( AV13OrderedBy == 6 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[PedidoDtEntrega]";
         }
         else if ( ( AV13OrderedBy == 6 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[PedidoDtEntrega] DESC";
         }
         else if ( ( AV13OrderedBy == 7 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[PedidoRetirada]";
         }
         else if ( ( AV13OrderedBy == 7 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[PedidoRetirada] DESC";
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

      protected Object[] conditional_H00187( IGxContext context ,
                                             String A34PedidoStatus ,
                                             GxSimpleCollection<String> AV123WP_GerenciarPedidoDS_23_Tfpedidostatus_sels ,
                                             String AV101WP_GerenciarPedidoDS_1_Dynamicfiltersselector1 ,
                                             short AV102WP_GerenciarPedidoDS_2_Dynamicfiltersoperator1 ,
                                             DateTime AV103WP_GerenciarPedidoDS_3_Pedidodt1 ,
                                             DateTime AV104WP_GerenciarPedidoDS_4_Pedidodt_to1 ,
                                             bool AV105WP_GerenciarPedidoDS_5_Dynamicfiltersenabled2 ,
                                             String AV106WP_GerenciarPedidoDS_6_Dynamicfiltersselector2 ,
                                             short AV107WP_GerenciarPedidoDS_7_Dynamicfiltersoperator2 ,
                                             DateTime AV108WP_GerenciarPedidoDS_8_Pedidodt2 ,
                                             DateTime AV109WP_GerenciarPedidoDS_9_Pedidodt_to2 ,
                                             bool AV110WP_GerenciarPedidoDS_10_Dynamicfiltersenabled3 ,
                                             String AV111WP_GerenciarPedidoDS_11_Dynamicfiltersselector3 ,
                                             short AV112WP_GerenciarPedidoDS_12_Dynamicfiltersoperator3 ,
                                             DateTime AV113WP_GerenciarPedidoDS_13_Pedidodt3 ,
                                             DateTime AV114WP_GerenciarPedidoDS_14_Pedidodt_to3 ,
                                             short AV115WP_GerenciarPedidoDS_15_Tfpedidoid ,
                                             short AV116WP_GerenciarPedidoDS_16_Tfpedidoid_to ,
                                             short AV117WP_GerenciarPedidoDS_17_Tfpessoaid ,
                                             short AV118WP_GerenciarPedidoDS_18_Tfpessoaid_to ,
                                             String AV120WP_GerenciarPedidoDS_20_Tfpessoanome_sel ,
                                             String AV119WP_GerenciarPedidoDS_19_Tfpessoanome ,
                                             DateTime AV121WP_GerenciarPedidoDS_21_Tfpedidodt ,
                                             DateTime AV122WP_GerenciarPedidoDS_22_Tfpedidodt_to ,
                                             int AV123WP_GerenciarPedidoDS_23_Tfpedidostatus_sels_Count ,
                                             DateTime AV124WP_GerenciarPedidoDS_24_Tfpedidodtentrega ,
                                             DateTime AV125WP_GerenciarPedidoDS_25_Tfpedidodtentrega_to ,
                                             short AV126WP_GerenciarPedidoDS_26_Tfpedidoretirada_sel ,
                                             DateTime A33PedidoDt ,
                                             short A32PedidoId ,
                                             short A1PessoaId ,
                                             String A2PessoaNome ,
                                             DateTime A35PedidoDtEntrega ,
                                             bool A36PedidoRetirada ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc ,
                                             decimal AV127WP_GerenciarPedidoDS_27_Tfpedidototal ,
                                             decimal A37PedidoTotal ,
                                             decimal AV128WP_GerenciarPedidoDS_28_Tfpedidototal_to )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [29] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM (([Pedido] T1 INNER JOIN [Pessoa] T2 ON T2.[PessoaId] = T1.[PessoaId]) LEFT JOIN (SELECT COALESCE( T5.[GXC1], 0) AS PedidoTotal, T4.[PedidoId] FROM ([Pedido] T4 LEFT JOIN (SELECT SUM(T7.[ProdutoValor] * CAST(T6.[PedidoItemQtd] AS decimal( 22, 10))) AS GXC1, T6.[PedidoId] FROM ([PedidoItem] T6 INNER JOIN [Produto] T7 ON T7.[ProdutoId] = T6.[ProdutoId]) GROUP BY T6.[PedidoId] ) T5 ON T5.[PedidoId] = T4.[PedidoId]) ) T3 ON T3.[PedidoId] = T1.[PedidoId])";
         scmdbuf = scmdbuf + " WHERE ((@AV127WP_GerenciarPedidoDS_27_Tfpedidototal = convert(int, 0)) or ( COALESCE( T3.[PedidoTotal], 0) >= @AV127WP_GerenciarPedidoDS_27_Tfpedidototal))";
         scmdbuf = scmdbuf + " and ((@AV128WP_GerenciarPedidoDS_28_Tfpedidototal_to = convert(int, 0)) or ( COALESCE( T3.[PedidoTotal], 0) <= @AV128WP_GerenciarPedidoDS_28_Tfpedidototal_to))";
         if ( ( StringUtil.StrCmp(AV101WP_GerenciarPedidoDS_1_Dynamicfiltersselector1, "PEDIDODT") == 0 ) && ( AV102WP_GerenciarPedidoDS_2_Dynamicfiltersoperator1 == 0 ) && ( ! (DateTime.MinValue==AV103WP_GerenciarPedidoDS_3_Pedidodt1) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDt] < @AV103WP_GerenciarPedidoDS_3_Pedidodt1)";
         }
         else
         {
            GXv_int5[4] = 1;
         }
         if ( ( StringUtil.StrCmp(AV101WP_GerenciarPedidoDS_1_Dynamicfiltersselector1, "PEDIDODT") == 0 ) && ( AV102WP_GerenciarPedidoDS_2_Dynamicfiltersoperator1 == 1 ) && ( ! (DateTime.MinValue==AV103WP_GerenciarPedidoDS_3_Pedidodt1) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDt] = @AV103WP_GerenciarPedidoDS_3_Pedidodt1)";
         }
         else
         {
            GXv_int5[5] = 1;
         }
         if ( ( StringUtil.StrCmp(AV101WP_GerenciarPedidoDS_1_Dynamicfiltersselector1, "PEDIDODT") == 0 ) && ( AV102WP_GerenciarPedidoDS_2_Dynamicfiltersoperator1 == 2 ) && ( ! (DateTime.MinValue==AV103WP_GerenciarPedidoDS_3_Pedidodt1) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDt] > @AV103WP_GerenciarPedidoDS_3_Pedidodt1)";
         }
         else
         {
            GXv_int5[6] = 1;
         }
         if ( ( StringUtil.StrCmp(AV101WP_GerenciarPedidoDS_1_Dynamicfiltersselector1, "PEDIDODT") == 0 ) && ( AV102WP_GerenciarPedidoDS_2_Dynamicfiltersoperator1 == 3 ) && ( ! (DateTime.MinValue==AV103WP_GerenciarPedidoDS_3_Pedidodt1) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDt] >= @AV103WP_GerenciarPedidoDS_3_Pedidodt1)";
         }
         else
         {
            GXv_int5[7] = 1;
         }
         if ( ( StringUtil.StrCmp(AV101WP_GerenciarPedidoDS_1_Dynamicfiltersselector1, "PEDIDODT") == 0 ) && ( AV102WP_GerenciarPedidoDS_2_Dynamicfiltersoperator1 == 3 ) && ( ! (DateTime.MinValue==AV104WP_GerenciarPedidoDS_4_Pedidodt_to1) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDt] <= @AV104WP_GerenciarPedidoDS_4_Pedidodt_to1)";
         }
         else
         {
            GXv_int5[8] = 1;
         }
         if ( AV105WP_GerenciarPedidoDS_5_Dynamicfiltersenabled2 && ( StringUtil.StrCmp(AV106WP_GerenciarPedidoDS_6_Dynamicfiltersselector2, "PEDIDODT") == 0 ) && ( AV107WP_GerenciarPedidoDS_7_Dynamicfiltersoperator2 == 0 ) && ( ! (DateTime.MinValue==AV108WP_GerenciarPedidoDS_8_Pedidodt2) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDt] < @AV108WP_GerenciarPedidoDS_8_Pedidodt2)";
         }
         else
         {
            GXv_int5[9] = 1;
         }
         if ( AV105WP_GerenciarPedidoDS_5_Dynamicfiltersenabled2 && ( StringUtil.StrCmp(AV106WP_GerenciarPedidoDS_6_Dynamicfiltersselector2, "PEDIDODT") == 0 ) && ( AV107WP_GerenciarPedidoDS_7_Dynamicfiltersoperator2 == 1 ) && ( ! (DateTime.MinValue==AV108WP_GerenciarPedidoDS_8_Pedidodt2) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDt] = @AV108WP_GerenciarPedidoDS_8_Pedidodt2)";
         }
         else
         {
            GXv_int5[10] = 1;
         }
         if ( AV105WP_GerenciarPedidoDS_5_Dynamicfiltersenabled2 && ( StringUtil.StrCmp(AV106WP_GerenciarPedidoDS_6_Dynamicfiltersselector2, "PEDIDODT") == 0 ) && ( AV107WP_GerenciarPedidoDS_7_Dynamicfiltersoperator2 == 2 ) && ( ! (DateTime.MinValue==AV108WP_GerenciarPedidoDS_8_Pedidodt2) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDt] > @AV108WP_GerenciarPedidoDS_8_Pedidodt2)";
         }
         else
         {
            GXv_int5[11] = 1;
         }
         if ( AV105WP_GerenciarPedidoDS_5_Dynamicfiltersenabled2 && ( StringUtil.StrCmp(AV106WP_GerenciarPedidoDS_6_Dynamicfiltersselector2, "PEDIDODT") == 0 ) && ( AV107WP_GerenciarPedidoDS_7_Dynamicfiltersoperator2 == 3 ) && ( ! (DateTime.MinValue==AV108WP_GerenciarPedidoDS_8_Pedidodt2) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDt] >= @AV108WP_GerenciarPedidoDS_8_Pedidodt2)";
         }
         else
         {
            GXv_int5[12] = 1;
         }
         if ( AV105WP_GerenciarPedidoDS_5_Dynamicfiltersenabled2 && ( StringUtil.StrCmp(AV106WP_GerenciarPedidoDS_6_Dynamicfiltersselector2, "PEDIDODT") == 0 ) && ( AV107WP_GerenciarPedidoDS_7_Dynamicfiltersoperator2 == 3 ) && ( ! (DateTime.MinValue==AV109WP_GerenciarPedidoDS_9_Pedidodt_to2) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDt] <= @AV109WP_GerenciarPedidoDS_9_Pedidodt_to2)";
         }
         else
         {
            GXv_int5[13] = 1;
         }
         if ( AV110WP_GerenciarPedidoDS_10_Dynamicfiltersenabled3 && ( StringUtil.StrCmp(AV111WP_GerenciarPedidoDS_11_Dynamicfiltersselector3, "PEDIDODT") == 0 ) && ( AV112WP_GerenciarPedidoDS_12_Dynamicfiltersoperator3 == 0 ) && ( ! (DateTime.MinValue==AV113WP_GerenciarPedidoDS_13_Pedidodt3) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDt] < @AV113WP_GerenciarPedidoDS_13_Pedidodt3)";
         }
         else
         {
            GXv_int5[14] = 1;
         }
         if ( AV110WP_GerenciarPedidoDS_10_Dynamicfiltersenabled3 && ( StringUtil.StrCmp(AV111WP_GerenciarPedidoDS_11_Dynamicfiltersselector3, "PEDIDODT") == 0 ) && ( AV112WP_GerenciarPedidoDS_12_Dynamicfiltersoperator3 == 1 ) && ( ! (DateTime.MinValue==AV113WP_GerenciarPedidoDS_13_Pedidodt3) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDt] = @AV113WP_GerenciarPedidoDS_13_Pedidodt3)";
         }
         else
         {
            GXv_int5[15] = 1;
         }
         if ( AV110WP_GerenciarPedidoDS_10_Dynamicfiltersenabled3 && ( StringUtil.StrCmp(AV111WP_GerenciarPedidoDS_11_Dynamicfiltersselector3, "PEDIDODT") == 0 ) && ( AV112WP_GerenciarPedidoDS_12_Dynamicfiltersoperator3 == 2 ) && ( ! (DateTime.MinValue==AV113WP_GerenciarPedidoDS_13_Pedidodt3) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDt] > @AV113WP_GerenciarPedidoDS_13_Pedidodt3)";
         }
         else
         {
            GXv_int5[16] = 1;
         }
         if ( AV110WP_GerenciarPedidoDS_10_Dynamicfiltersenabled3 && ( StringUtil.StrCmp(AV111WP_GerenciarPedidoDS_11_Dynamicfiltersselector3, "PEDIDODT") == 0 ) && ( AV112WP_GerenciarPedidoDS_12_Dynamicfiltersoperator3 == 3 ) && ( ! (DateTime.MinValue==AV113WP_GerenciarPedidoDS_13_Pedidodt3) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDt] >= @AV113WP_GerenciarPedidoDS_13_Pedidodt3)";
         }
         else
         {
            GXv_int5[17] = 1;
         }
         if ( AV110WP_GerenciarPedidoDS_10_Dynamicfiltersenabled3 && ( StringUtil.StrCmp(AV111WP_GerenciarPedidoDS_11_Dynamicfiltersselector3, "PEDIDODT") == 0 ) && ( AV112WP_GerenciarPedidoDS_12_Dynamicfiltersoperator3 == 3 ) && ( ! (DateTime.MinValue==AV114WP_GerenciarPedidoDS_14_Pedidodt_to3) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDt] <= @AV114WP_GerenciarPedidoDS_14_Pedidodt_to3)";
         }
         else
         {
            GXv_int5[18] = 1;
         }
         if ( ! (0==AV115WP_GerenciarPedidoDS_15_Tfpedidoid) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoId] >= @AV115WP_GerenciarPedidoDS_15_Tfpedidoid)";
         }
         else
         {
            GXv_int5[19] = 1;
         }
         if ( ! (0==AV116WP_GerenciarPedidoDS_16_Tfpedidoid_to) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoId] <= @AV116WP_GerenciarPedidoDS_16_Tfpedidoid_to)";
         }
         else
         {
            GXv_int5[20] = 1;
         }
         if ( ! (0==AV117WP_GerenciarPedidoDS_17_Tfpessoaid) )
         {
            sWhereString = sWhereString + " and (T1.[PessoaId] >= @AV117WP_GerenciarPedidoDS_17_Tfpessoaid)";
         }
         else
         {
            GXv_int5[21] = 1;
         }
         if ( ! (0==AV118WP_GerenciarPedidoDS_18_Tfpessoaid_to) )
         {
            sWhereString = sWhereString + " and (T1.[PessoaId] <= @AV118WP_GerenciarPedidoDS_18_Tfpessoaid_to)";
         }
         else
         {
            GXv_int5[22] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV120WP_GerenciarPedidoDS_20_Tfpessoanome_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV119WP_GerenciarPedidoDS_19_Tfpessoanome)) ) )
         {
            sWhereString = sWhereString + " and (T2.[PessoaNome] like @lV119WP_GerenciarPedidoDS_19_Tfpessoanome)";
         }
         else
         {
            GXv_int5[23] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV120WP_GerenciarPedidoDS_20_Tfpessoanome_sel)) )
         {
            sWhereString = sWhereString + " and (T2.[PessoaNome] = @AV120WP_GerenciarPedidoDS_20_Tfpessoanome_sel)";
         }
         else
         {
            GXv_int5[24] = 1;
         }
         if ( ! (DateTime.MinValue==AV121WP_GerenciarPedidoDS_21_Tfpedidodt) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDt] >= @AV121WP_GerenciarPedidoDS_21_Tfpedidodt)";
         }
         else
         {
            GXv_int5[25] = 1;
         }
         if ( ! (DateTime.MinValue==AV122WP_GerenciarPedidoDS_22_Tfpedidodt_to) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDt] <= @AV122WP_GerenciarPedidoDS_22_Tfpedidodt_to)";
         }
         else
         {
            GXv_int5[26] = 1;
         }
         if ( AV123WP_GerenciarPedidoDS_23_Tfpedidostatus_sels_Count > 0 )
         {
            sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV123WP_GerenciarPedidoDS_23_Tfpedidostatus_sels, "T1.[PedidoStatus] IN (", ")") + ")";
         }
         if ( ! (DateTime.MinValue==AV124WP_GerenciarPedidoDS_24_Tfpedidodtentrega) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDtEntrega] >= @AV124WP_GerenciarPedidoDS_24_Tfpedidodtentrega)";
         }
         else
         {
            GXv_int5[27] = 1;
         }
         if ( ! (DateTime.MinValue==AV125WP_GerenciarPedidoDS_25_Tfpedidodtentrega_to) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoDtEntrega] <= @AV125WP_GerenciarPedidoDS_25_Tfpedidodtentrega_to)";
         }
         else
         {
            GXv_int5[28] = 1;
         }
         if ( AV126WP_GerenciarPedidoDS_26_Tfpedidoretirada_sel == 1 )
         {
            sWhereString = sWhereString + " and (T1.[PedidoRetirada] = 1)";
         }
         if ( AV126WP_GerenciarPedidoDS_26_Tfpedidoretirada_sel == 2 )
         {
            sWhereString = sWhereString + " and (T1.[PedidoRetirada] = 0)";
         }
         scmdbuf = scmdbuf + sWhereString;
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
                     return conditional_H00184(context, (String)dynConstraints[0] , (GxSimpleCollection<String>)dynConstraints[1] , (String)dynConstraints[2] , (short)dynConstraints[3] , (DateTime)dynConstraints[4] , (DateTime)dynConstraints[5] , (bool)dynConstraints[6] , (String)dynConstraints[7] , (short)dynConstraints[8] , (DateTime)dynConstraints[9] , (DateTime)dynConstraints[10] , (bool)dynConstraints[11] , (String)dynConstraints[12] , (short)dynConstraints[13] , (DateTime)dynConstraints[14] , (DateTime)dynConstraints[15] , (short)dynConstraints[16] , (short)dynConstraints[17] , (short)dynConstraints[18] , (short)dynConstraints[19] , (String)dynConstraints[20] , (String)dynConstraints[21] , (DateTime)dynConstraints[22] , (DateTime)dynConstraints[23] , (int)dynConstraints[24] , (DateTime)dynConstraints[25] , (DateTime)dynConstraints[26] , (short)dynConstraints[27] , (DateTime)dynConstraints[28] , (short)dynConstraints[29] , (short)dynConstraints[30] , (String)dynConstraints[31] , (DateTime)dynConstraints[32] , (bool)dynConstraints[33] , (short)dynConstraints[34] , (bool)dynConstraints[35] , (decimal)dynConstraints[36] , (decimal)dynConstraints[37] , (decimal)dynConstraints[38] );
               case 1 :
                     return conditional_H00187(context, (String)dynConstraints[0] , (GxSimpleCollection<String>)dynConstraints[1] , (String)dynConstraints[2] , (short)dynConstraints[3] , (DateTime)dynConstraints[4] , (DateTime)dynConstraints[5] , (bool)dynConstraints[6] , (String)dynConstraints[7] , (short)dynConstraints[8] , (DateTime)dynConstraints[9] , (DateTime)dynConstraints[10] , (bool)dynConstraints[11] , (String)dynConstraints[12] , (short)dynConstraints[13] , (DateTime)dynConstraints[14] , (DateTime)dynConstraints[15] , (short)dynConstraints[16] , (short)dynConstraints[17] , (short)dynConstraints[18] , (short)dynConstraints[19] , (String)dynConstraints[20] , (String)dynConstraints[21] , (DateTime)dynConstraints[22] , (DateTime)dynConstraints[23] , (int)dynConstraints[24] , (DateTime)dynConstraints[25] , (DateTime)dynConstraints[26] , (short)dynConstraints[27] , (DateTime)dynConstraints[28] , (short)dynConstraints[29] , (short)dynConstraints[30] , (String)dynConstraints[31] , (DateTime)dynConstraints[32] , (bool)dynConstraints[33] , (short)dynConstraints[34] , (bool)dynConstraints[35] , (decimal)dynConstraints[36] , (decimal)dynConstraints[37] , (decimal)dynConstraints[38] );
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
          Object[] prmH00184 ;
          prmH00184 = new Object[] {
          new Object[] {"@AV127WP_GerenciarPedidoDS_27_Tfpedidototal",SqlDbType.Decimal,12,2} ,
          new Object[] {"@AV127WP_GerenciarPedidoDS_27_Tfpedidototal",SqlDbType.Decimal,12,2} ,
          new Object[] {"@AV128WP_GerenciarPedidoDS_28_Tfpedidototal_to",SqlDbType.Decimal,12,2} ,
          new Object[] {"@AV128WP_GerenciarPedidoDS_28_Tfpedidototal_to",SqlDbType.Decimal,12,2} ,
          new Object[] {"@AV103WP_GerenciarPedidoDS_3_Pedidodt1",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV103WP_GerenciarPedidoDS_3_Pedidodt1",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV103WP_GerenciarPedidoDS_3_Pedidodt1",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV103WP_GerenciarPedidoDS_3_Pedidodt1",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV104WP_GerenciarPedidoDS_4_Pedidodt_to1",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV108WP_GerenciarPedidoDS_8_Pedidodt2",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV108WP_GerenciarPedidoDS_8_Pedidodt2",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV108WP_GerenciarPedidoDS_8_Pedidodt2",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV108WP_GerenciarPedidoDS_8_Pedidodt2",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV109WP_GerenciarPedidoDS_9_Pedidodt_to2",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV113WP_GerenciarPedidoDS_13_Pedidodt3",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV113WP_GerenciarPedidoDS_13_Pedidodt3",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV113WP_GerenciarPedidoDS_13_Pedidodt3",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV113WP_GerenciarPedidoDS_13_Pedidodt3",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV114WP_GerenciarPedidoDS_14_Pedidodt_to3",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV115WP_GerenciarPedidoDS_15_Tfpedidoid",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV116WP_GerenciarPedidoDS_16_Tfpedidoid_to",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV117WP_GerenciarPedidoDS_17_Tfpessoaid",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV118WP_GerenciarPedidoDS_18_Tfpessoaid_to",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV119WP_GerenciarPedidoDS_19_Tfpessoanome",SqlDbType.VarChar,60,0} ,
          new Object[] {"@AV120WP_GerenciarPedidoDS_20_Tfpessoanome_sel",SqlDbType.VarChar,60,0} ,
          new Object[] {"@AV121WP_GerenciarPedidoDS_21_Tfpedidodt",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV122WP_GerenciarPedidoDS_22_Tfpedidodt_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV124WP_GerenciarPedidoDS_24_Tfpedidodtentrega",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV125WP_GerenciarPedidoDS_25_Tfpedidodtentrega_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00187 ;
          prmH00187 = new Object[] {
          new Object[] {"@AV127WP_GerenciarPedidoDS_27_Tfpedidototal",SqlDbType.Decimal,12,2} ,
          new Object[] {"@AV127WP_GerenciarPedidoDS_27_Tfpedidototal",SqlDbType.Decimal,12,2} ,
          new Object[] {"@AV128WP_GerenciarPedidoDS_28_Tfpedidototal_to",SqlDbType.Decimal,12,2} ,
          new Object[] {"@AV128WP_GerenciarPedidoDS_28_Tfpedidototal_to",SqlDbType.Decimal,12,2} ,
          new Object[] {"@AV103WP_GerenciarPedidoDS_3_Pedidodt1",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV103WP_GerenciarPedidoDS_3_Pedidodt1",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV103WP_GerenciarPedidoDS_3_Pedidodt1",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV103WP_GerenciarPedidoDS_3_Pedidodt1",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV104WP_GerenciarPedidoDS_4_Pedidodt_to1",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV108WP_GerenciarPedidoDS_8_Pedidodt2",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV108WP_GerenciarPedidoDS_8_Pedidodt2",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV108WP_GerenciarPedidoDS_8_Pedidodt2",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV108WP_GerenciarPedidoDS_8_Pedidodt2",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV109WP_GerenciarPedidoDS_9_Pedidodt_to2",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV113WP_GerenciarPedidoDS_13_Pedidodt3",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV113WP_GerenciarPedidoDS_13_Pedidodt3",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV113WP_GerenciarPedidoDS_13_Pedidodt3",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV113WP_GerenciarPedidoDS_13_Pedidodt3",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV114WP_GerenciarPedidoDS_14_Pedidodt_to3",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV115WP_GerenciarPedidoDS_15_Tfpedidoid",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV116WP_GerenciarPedidoDS_16_Tfpedidoid_to",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV117WP_GerenciarPedidoDS_17_Tfpessoaid",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV118WP_GerenciarPedidoDS_18_Tfpessoaid_to",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV119WP_GerenciarPedidoDS_19_Tfpessoanome",SqlDbType.VarChar,60,0} ,
          new Object[] {"@AV120WP_GerenciarPedidoDS_20_Tfpessoanome_sel",SqlDbType.VarChar,60,0} ,
          new Object[] {"@AV121WP_GerenciarPedidoDS_21_Tfpedidodt",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV122WP_GerenciarPedidoDS_22_Tfpedidodt_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV124WP_GerenciarPedidoDS_24_Tfpedidodtentrega",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV125WP_GerenciarPedidoDS_25_Tfpedidodtentrega_to",SqlDbType.DateTime,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00184", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00184,11, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("H00187", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00187,1, GxCacheFrequency.OFF ,true,false )
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
                ((bool[]) buf[0])[0] = rslt.getBool(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((decimal[]) buf[7])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(8);
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
                   stmt.SetParameter(sIdx, (decimal)parms[32]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[33]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[34]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[35]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[36]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[37]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[38]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[39]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[40]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[41]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[42]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[43]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[44]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[45]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[46]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[47]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[48]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[49]);
                }
                if ( (short)parms[18] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[50]);
                }
                if ( (short)parms[19] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[51]);
                }
                if ( (short)parms[20] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[52]);
                }
                if ( (short)parms[21] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[53]);
                }
                if ( (short)parms[22] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[54]);
                }
                if ( (short)parms[23] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[55]);
                }
                if ( (short)parms[24] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[56]);
                }
                if ( (short)parms[25] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[57]);
                }
                if ( (short)parms[26] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[58]);
                }
                if ( (short)parms[27] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[59]);
                }
                if ( (short)parms[28] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[60]);
                }
                if ( (short)parms[29] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[61]);
                }
                if ( (short)parms[30] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[62]);
                }
                if ( (short)parms[31] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[63]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[29]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[30]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[31]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[32]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[33]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[34]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[35]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[36]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[37]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[38]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[39]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[40]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[41]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[42]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[43]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[44]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[45]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[46]);
                }
                if ( (short)parms[18] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[47]);
                }
                if ( (short)parms[19] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[48]);
                }
                if ( (short)parms[20] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[49]);
                }
                if ( (short)parms[21] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[50]);
                }
                if ( (short)parms[22] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[51]);
                }
                if ( (short)parms[23] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[52]);
                }
                if ( (short)parms[24] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[53]);
                }
                if ( (short)parms[25] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[54]);
                }
                if ( (short)parms[26] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[55]);
                }
                if ( (short)parms[27] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[56]);
                }
                if ( (short)parms[28] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[57]);
                }
                return;
       }
    }

 }

}
