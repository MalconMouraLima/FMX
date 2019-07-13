/*
               File: PedidoPrompt
        Description: Consulta de Pedido
             Author: GeneXus C# Generator version 16_0_2-131213
       Generated on: 7/12/2019 17:59:41.1
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
   public class pedidoprompt : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public pedidoprompt( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public pedidoprompt( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( ref short aP0_InOutPedidoId ,
                           ref DateTime aP1_InOutPedidoDt )
      {
         this.AV45InOutPedidoId = aP0_InOutPedidoId;
         this.AV46InOutPedidoDt = aP1_InOutPedidoDt;
         executePrivate();
         aP0_InOutPedidoId=this.AV45InOutPedidoId;
         aP1_InOutPedidoDt=this.AV46InOutPedidoDt;
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
               nRC_GXsfl_119 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_119_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_119_idx = GetNextPar( );
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
               AV13DynamicFiltersSelector1 = GetNextPar( );
               AV14DynamicFiltersOperator1 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV15PedidoDt1 = context.localUtil.ParseDateParm( GetNextPar( ));
               AV16PedidoDt_To1 = context.localUtil.ParseDateParm( GetNextPar( ));
               AV18DynamicFiltersSelector2 = GetNextPar( );
               AV19DynamicFiltersOperator2 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV20PedidoDt2 = context.localUtil.ParseDateParm( GetNextPar( ));
               AV21PedidoDt_To2 = context.localUtil.ParseDateParm( GetNextPar( ));
               AV23DynamicFiltersSelector3 = GetNextPar( );
               AV24DynamicFiltersOperator3 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV25PedidoDt3 = context.localUtil.ParseDateParm( GetNextPar( ));
               AV26PedidoDt_To3 = context.localUtil.ParseDateParm( GetNextPar( ));
               AV17DynamicFiltersEnabled2 = StringUtil.StrToBool( GetNextPar( ));
               AV22DynamicFiltersEnabled3 = StringUtil.StrToBool( GetNextPar( ));
               AV11OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV12OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV31ddo_PedidoIdTitleControlIdToReplace = GetNextPar( );
               AV33ddo_PedidoDtTitleControlIdToReplace = GetNextPar( );
               AV35ddo_PedidoStatusTitleControlIdToReplace = GetNextPar( );
               AV37ddo_PedidoDtEntregaTitleControlIdToReplace = GetNextPar( );
               AV39ddo_PedidoRetiradaTitleControlIdToReplace = GetNextPar( );
               AV48ddo_PedidoTotalTitleControlIdToReplace = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15PedidoDt1, AV16PedidoDt_To1, AV18DynamicFiltersSelector2, AV19DynamicFiltersOperator2, AV20PedidoDt2, AV21PedidoDt_To2, AV23DynamicFiltersSelector3, AV24DynamicFiltersOperator3, AV25PedidoDt3, AV26PedidoDt_To3, AV17DynamicFiltersEnabled2, AV22DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV31ddo_PedidoIdTitleControlIdToReplace, AV33ddo_PedidoDtTitleControlIdToReplace, AV35ddo_PedidoStatusTitleControlIdToReplace, AV37ddo_PedidoDtEntregaTitleControlIdToReplace, AV39ddo_PedidoRetiradaTitleControlIdToReplace, AV48ddo_PedidoTotalTitleControlIdToReplace) ;
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
            if ( ! entryPointCalled && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
            {
               AV45InOutPedidoId = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45InOutPedidoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV45InOutPedidoId), 4, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV46InOutPedidoDt = context.localUtil.ParseDateParm( GetNextPar( ));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46InOutPedidoDt", context.localUtil.Format(AV46InOutPedidoDt, "99/99/99"));
               }
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("wwpbaseobjects.workwithplusmasterpageprompt", "GeneXus.Programs.wwpbaseobjects.workwithplusmasterpageprompt", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,true);
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
         PA142( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START142( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?201971217594131", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 131213), false, true);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 131213), false, true);
         context.AddJavascriptSource("calendar-pt.js", "?"+context.GetBuildNumber( 131213), false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false, true);
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
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false, true);
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
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
         context.WriteHtmlText( " "+"class=\"form-horizontal FormNoBackgroundColor\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal FormNoBackgroundColor\" data-gx-class=\"form-horizontal FormNoBackgroundColor\" novalidate action=\""+formatLink("pedidoprompt.aspx") + "?" + UrlEncode("" +AV45InOutPedidoId) + "," + UrlEncode(DateTimeUtil.FormatDateParm(AV46InOutPedidoDt))+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Class", "form-horizontal FormNoBackgroundColor", true);
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
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSSELECTOR1", AV13DynamicFiltersSelector1);
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSOPERATOR1", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14DynamicFiltersOperator1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vPEDIDODT1", context.localUtil.Format(AV15PedidoDt1, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vPEDIDODT_TO1", context.localUtil.Format(AV16PedidoDt_To1, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSSELECTOR2", AV18DynamicFiltersSelector2);
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSOPERATOR2", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV19DynamicFiltersOperator2), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vPEDIDODT2", context.localUtil.Format(AV20PedidoDt2, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vPEDIDODT_TO2", context.localUtil.Format(AV21PedidoDt_To2, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSSELECTOR3", AV23DynamicFiltersSelector3);
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSOPERATOR3", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV24DynamicFiltersOperator3), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vPEDIDODT3", context.localUtil.Format(AV25PedidoDt3, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vPEDIDODT_TO3", context.localUtil.Format(AV26PedidoDt_To3, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSENABLED2", StringUtil.BoolToStr( AV17DynamicFiltersEnabled2));
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSENABLED3", StringUtil.BoolToStr( AV22DynamicFiltersEnabled3));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11OrderedBy), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV12OrderedDsc));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_119", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_119), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV42GridCurrentPage), 10, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGECOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV43GridPageCount), 10, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV40DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV40DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPEDIDOIDTITLEFILTERDATA", AV30PedidoIdTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPEDIDOIDTITLEFILTERDATA", AV30PedidoIdTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPEDIDODTTITLEFILTERDATA", AV32PedidoDtTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPEDIDODTTITLEFILTERDATA", AV32PedidoDtTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPEDIDOSTATUSTITLEFILTERDATA", AV34PedidoStatusTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPEDIDOSTATUSTITLEFILTERDATA", AV34PedidoStatusTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPEDIDODTENTREGATITLEFILTERDATA", AV36PedidoDtEntregaTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPEDIDODTENTREGATITLEFILTERDATA", AV36PedidoDtEntregaTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPEDIDORETIRADATITLEFILTERDATA", AV38PedidoRetiradaTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPEDIDORETIRADATITLEFILTERDATA", AV38PedidoRetiradaTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPEDIDOTOTALTITLEFILTERDATA", AV47PedidoTotalTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPEDIDOTOTALTITLEFILTERDATA", AV47PedidoTotalTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vGRIDSTATE", AV8GridState);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vGRIDSTATE", AV8GridState);
         }
         GxWebStd.gx_boolean_hidden_field( context, "vDYNAMICFILTERSIGNOREFIRST", AV28DynamicFiltersIgnoreFirst);
         GxWebStd.gx_boolean_hidden_field( context, "vDYNAMICFILTERSREMOVING", AV27DynamicFiltersRemoving);
         GxWebStd.gx_hidden_field( context, "vTODAY", context.localUtil.DToC( Gx_date, 0, "/"));
         GxWebStd.gx_hidden_field( context, "vINOUTPEDIDOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV45InOutPedidoId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vINOUTPEDIDODT", context.localUtil.DToC( AV46InOutPedidoDt, 0, "/"));
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
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
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Dropdownoptionstype", StringUtil.RTrim( Ddo_pedidoid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_pedidoid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Includesortasc", StringUtil.BoolToStr( Ddo_pedidoid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Includesortdsc", StringUtil.BoolToStr( Ddo_pedidoid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Sortedstatus", StringUtil.RTrim( Ddo_pedidoid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Includefilter", StringUtil.BoolToStr( Ddo_pedidoid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Includedatalist", StringUtil.BoolToStr( Ddo_pedidoid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Sortasc", StringUtil.RTrim( Ddo_pedidoid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Sortdsc", StringUtil.RTrim( Ddo_pedidoid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Cleanfilter", StringUtil.RTrim( Ddo_pedidoid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Searchbuttontext", StringUtil.RTrim( Ddo_pedidoid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Caption", StringUtil.RTrim( Ddo_pedidodt_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Tooltip", StringUtil.RTrim( Ddo_pedidodt_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Cls", StringUtil.RTrim( Ddo_pedidodt_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Dropdownoptionstype", StringUtil.RTrim( Ddo_pedidodt_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_pedidodt_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Includesortasc", StringUtil.BoolToStr( Ddo_pedidodt_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Includesortdsc", StringUtil.BoolToStr( Ddo_pedidodt_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Sortedstatus", StringUtil.RTrim( Ddo_pedidodt_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Includefilter", StringUtil.BoolToStr( Ddo_pedidodt_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Includedatalist", StringUtil.BoolToStr( Ddo_pedidodt_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Sortasc", StringUtil.RTrim( Ddo_pedidodt_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Sortdsc", StringUtil.RTrim( Ddo_pedidodt_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Cleanfilter", StringUtil.RTrim( Ddo_pedidodt_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Searchbuttontext", StringUtil.RTrim( Ddo_pedidodt_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Caption", StringUtil.RTrim( Ddo_pedidostatus_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Tooltip", StringUtil.RTrim( Ddo_pedidostatus_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Cls", StringUtil.RTrim( Ddo_pedidostatus_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Dropdownoptionstype", StringUtil.RTrim( Ddo_pedidostatus_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_pedidostatus_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Includesortasc", StringUtil.BoolToStr( Ddo_pedidostatus_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Includesortdsc", StringUtil.BoolToStr( Ddo_pedidostatus_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Sortedstatus", StringUtil.RTrim( Ddo_pedidostatus_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Includefilter", StringUtil.BoolToStr( Ddo_pedidostatus_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Includedatalist", StringUtil.BoolToStr( Ddo_pedidostatus_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Sortasc", StringUtil.RTrim( Ddo_pedidostatus_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Sortdsc", StringUtil.RTrim( Ddo_pedidostatus_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Cleanfilter", StringUtil.RTrim( Ddo_pedidostatus_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Searchbuttontext", StringUtil.RTrim( Ddo_pedidostatus_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Caption", StringUtil.RTrim( Ddo_pedidodtentrega_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Tooltip", StringUtil.RTrim( Ddo_pedidodtentrega_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Cls", StringUtil.RTrim( Ddo_pedidodtentrega_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Dropdownoptionstype", StringUtil.RTrim( Ddo_pedidodtentrega_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_pedidodtentrega_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Includesortasc", StringUtil.BoolToStr( Ddo_pedidodtentrega_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Includesortdsc", StringUtil.BoolToStr( Ddo_pedidodtentrega_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Sortedstatus", StringUtil.RTrim( Ddo_pedidodtentrega_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Includefilter", StringUtil.BoolToStr( Ddo_pedidodtentrega_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Includedatalist", StringUtil.BoolToStr( Ddo_pedidodtentrega_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Sortasc", StringUtil.RTrim( Ddo_pedidodtentrega_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Sortdsc", StringUtil.RTrim( Ddo_pedidodtentrega_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Cleanfilter", StringUtil.RTrim( Ddo_pedidodtentrega_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Searchbuttontext", StringUtil.RTrim( Ddo_pedidodtentrega_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Caption", StringUtil.RTrim( Ddo_pedidoretirada_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Tooltip", StringUtil.RTrim( Ddo_pedidoretirada_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Cls", StringUtil.RTrim( Ddo_pedidoretirada_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Dropdownoptionstype", StringUtil.RTrim( Ddo_pedidoretirada_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_pedidoretirada_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Includesortasc", StringUtil.BoolToStr( Ddo_pedidoretirada_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Includesortdsc", StringUtil.BoolToStr( Ddo_pedidoretirada_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Sortedstatus", StringUtil.RTrim( Ddo_pedidoretirada_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Includefilter", StringUtil.BoolToStr( Ddo_pedidoretirada_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Includedatalist", StringUtil.BoolToStr( Ddo_pedidoretirada_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Sortasc", StringUtil.RTrim( Ddo_pedidoretirada_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Sortdsc", StringUtil.RTrim( Ddo_pedidoretirada_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Cleanfilter", StringUtil.RTrim( Ddo_pedidoretirada_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Searchbuttontext", StringUtil.RTrim( Ddo_pedidoretirada_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Caption", StringUtil.RTrim( Ddo_pedidototal_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Tooltip", StringUtil.RTrim( Ddo_pedidototal_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Cls", StringUtil.RTrim( Ddo_pedidototal_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Dropdownoptionstype", StringUtil.RTrim( Ddo_pedidototal_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_pedidototal_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Includesortasc", StringUtil.BoolToStr( Ddo_pedidototal_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Includesortdsc", StringUtil.BoolToStr( Ddo_pedidototal_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Sortedstatus", StringUtil.RTrim( Ddo_pedidototal_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Includefilter", StringUtil.BoolToStr( Ddo_pedidototal_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Includedatalist", StringUtil.BoolToStr( Ddo_pedidototal_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Sortasc", StringUtil.RTrim( Ddo_pedidototal_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Sortdsc", StringUtil.RTrim( Ddo_pedidototal_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Cleanfilter", StringUtil.RTrim( Ddo_pedidototal_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Searchbuttontext", StringUtil.RTrim( Ddo_pedidototal_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Activeeventkey", StringUtil.RTrim( Ddo_pedidoid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Activeeventkey", StringUtil.RTrim( Ddo_pedidodt_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Activeeventkey", StringUtil.RTrim( Ddo_pedidostatus_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Activeeventkey", StringUtil.RTrim( Ddo_pedidodtentrega_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Activeeventkey", StringUtil.RTrim( Ddo_pedidoretirada_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Activeeventkey", StringUtil.RTrim( Ddo_pedidototal_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOID_Activeeventkey", StringUtil.RTrim( Ddo_pedidoid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODT_Activeeventkey", StringUtil.RTrim( Ddo_pedidodt_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOSTATUS_Activeeventkey", StringUtil.RTrim( Ddo_pedidostatus_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDODTENTREGA_Activeeventkey", StringUtil.RTrim( Ddo_pedidodtentrega_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDORETIRADA_Activeeventkey", StringUtil.RTrim( Ddo_pedidoretirada_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOTOTAL_Activeeventkey", StringUtil.RTrim( Ddo_pedidototal_Activeeventkey));
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
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal FormNoBackgroundColor" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE142( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT142( ) ;
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
         return formatLink("pedidoprompt.aspx") + "?" + UrlEncode("" +AV45InOutPedidoId) + "," + UrlEncode(DateTimeUtil.FormatDateParm(AV46InOutPedidoDt)) ;
      }

      public override String GetPgmname( )
      {
         return "PedidoPrompt" ;
      }

      public override String GetPgmdesc( )
      {
         return "Consulta de Pedido" ;
      }

      protected void WB140( )
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
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", "", "false");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 CellMarginPrompt", "left", "top", "", "", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-xs", "left", "top", "", "", "div");
            wb_table1_14_142( true) ;
         }
         else
         {
            wb_table1_14_142( false) ;
         }
         return  ;
      }

      protected void wb_table1_14_142e( bool wbgen )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 CellMarginPrompt GridNoBorderCell", "left", "top", "", "", "div");
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
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"119\">") ;
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"SelectAttribute ActionBaseColorAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtPedidoId_Titleformat == 0 )
               {
                  context.SendWebValue( edtPedidoId_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtPedidoId_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtPedidoDt_Titleformat == 0 )
               {
                  context.SendWebValue( edtPedidoDt_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtPedidoDt_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( cmbPedidoStatus_Titleformat == 0 )
               {
                  context.SendWebValue( cmbPedidoStatus.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( cmbPedidoStatus.Title.Text) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtPedidoDtEntrega_Titleformat == 0 )
               {
                  context.SendWebValue( edtPedidoDtEntrega_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtPedidoDtEntrega_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"AttributeCheckBox"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( chkPedidoRetirada_Titleformat == 0 )
               {
                  context.SendWebValue( chkPedidoRetirada.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( chkPedidoRetirada.Title.Text) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV44Select));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavSelect_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A32PedidoId), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtPedidoId_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPedidoId_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A33PedidoDt, "99/99/99"));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtPedidoDt_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPedidoDt_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A34PedidoStatus);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( cmbPedidoStatus.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbPedidoStatus_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A35PedidoDtEntrega, "99/99/99"));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtPedidoDtEntrega_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPedidoDtEntrega_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.BoolToStr( A36PedidoRetirada));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( chkPedidoRetirada.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkPedidoRetirada_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A37PedidoTotal, 18, 2, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtPedidoTotal_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPedidoTotal_Titleformat), 4, 0, ".", "")));
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
         if ( wbEnd == 119 )
         {
            wbEnd = 0;
            nRC_GXsfl_119 = (short)(nGXsfl_119_idx-1);
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV42GridCurrentPage);
            ucGridpaginationbar.SetProperty("PageCount", AV43GridPageCount);
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
            GxWebStd.gx_label_ctrl( context, lblJsdynamicfilters_Internalname, lblJsdynamicfilters_Caption, "", "", lblJsdynamicfilters_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "", 0, "", 1, 1, 1, "HLP_PedidoPrompt.htm");
            /* User Defined Control */
            ucDdo_pedidoid.SetProperty("Caption", Ddo_pedidoid_Caption);
            ucDdo_pedidoid.SetProperty("Tooltip", Ddo_pedidoid_Tooltip);
            ucDdo_pedidoid.SetProperty("Cls", Ddo_pedidoid_Cls);
            ucDdo_pedidoid.SetProperty("DropDownOptionsType", Ddo_pedidoid_Dropdownoptionstype);
            ucDdo_pedidoid.SetProperty("IncludeSortASC", Ddo_pedidoid_Includesortasc);
            ucDdo_pedidoid.SetProperty("IncludeSortDSC", Ddo_pedidoid_Includesortdsc);
            ucDdo_pedidoid.SetProperty("IncludeFilter", Ddo_pedidoid_Includefilter);
            ucDdo_pedidoid.SetProperty("IncludeDataList", Ddo_pedidoid_Includedatalist);
            ucDdo_pedidoid.SetProperty("SortASC", Ddo_pedidoid_Sortasc);
            ucDdo_pedidoid.SetProperty("SortDSC", Ddo_pedidoid_Sortdsc);
            ucDdo_pedidoid.SetProperty("CleanFilter", Ddo_pedidoid_Cleanfilter);
            ucDdo_pedidoid.SetProperty("SearchButtonText", Ddo_pedidoid_Searchbuttontext);
            ucDdo_pedidoid.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_pedidoid.SetProperty("DropDownOptionsData", AV30PedidoIdTitleFilterData);
            ucDdo_pedidoid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_pedidoid_Internalname, "DDO_PEDIDOIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 135,'',false,'" + sGXsfl_119_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_pedidoidtitlecontrolidtoreplace_Internalname, AV31ddo_PedidoIdTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,135);\"", 0, edtavDdo_pedidoidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_PedidoPrompt.htm");
            /* User Defined Control */
            ucDdo_pedidodt.SetProperty("Caption", Ddo_pedidodt_Caption);
            ucDdo_pedidodt.SetProperty("Tooltip", Ddo_pedidodt_Tooltip);
            ucDdo_pedidodt.SetProperty("Cls", Ddo_pedidodt_Cls);
            ucDdo_pedidodt.SetProperty("DropDownOptionsType", Ddo_pedidodt_Dropdownoptionstype);
            ucDdo_pedidodt.SetProperty("IncludeSortASC", Ddo_pedidodt_Includesortasc);
            ucDdo_pedidodt.SetProperty("IncludeSortDSC", Ddo_pedidodt_Includesortdsc);
            ucDdo_pedidodt.SetProperty("IncludeFilter", Ddo_pedidodt_Includefilter);
            ucDdo_pedidodt.SetProperty("IncludeDataList", Ddo_pedidodt_Includedatalist);
            ucDdo_pedidodt.SetProperty("SortASC", Ddo_pedidodt_Sortasc);
            ucDdo_pedidodt.SetProperty("SortDSC", Ddo_pedidodt_Sortdsc);
            ucDdo_pedidodt.SetProperty("CleanFilter", Ddo_pedidodt_Cleanfilter);
            ucDdo_pedidodt.SetProperty("SearchButtonText", Ddo_pedidodt_Searchbuttontext);
            ucDdo_pedidodt.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_pedidodt.SetProperty("DropDownOptionsData", AV32PedidoDtTitleFilterData);
            ucDdo_pedidodt.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_pedidodt_Internalname, "DDO_PEDIDODTContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 137,'',false,'" + sGXsfl_119_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_pedidodttitlecontrolidtoreplace_Internalname, AV33ddo_PedidoDtTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,137);\"", 0, edtavDdo_pedidodttitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_PedidoPrompt.htm");
            /* User Defined Control */
            ucDdo_pedidostatus.SetProperty("Caption", Ddo_pedidostatus_Caption);
            ucDdo_pedidostatus.SetProperty("Tooltip", Ddo_pedidostatus_Tooltip);
            ucDdo_pedidostatus.SetProperty("Cls", Ddo_pedidostatus_Cls);
            ucDdo_pedidostatus.SetProperty("DropDownOptionsType", Ddo_pedidostatus_Dropdownoptionstype);
            ucDdo_pedidostatus.SetProperty("IncludeSortASC", Ddo_pedidostatus_Includesortasc);
            ucDdo_pedidostatus.SetProperty("IncludeSortDSC", Ddo_pedidostatus_Includesortdsc);
            ucDdo_pedidostatus.SetProperty("IncludeFilter", Ddo_pedidostatus_Includefilter);
            ucDdo_pedidostatus.SetProperty("IncludeDataList", Ddo_pedidostatus_Includedatalist);
            ucDdo_pedidostatus.SetProperty("SortASC", Ddo_pedidostatus_Sortasc);
            ucDdo_pedidostatus.SetProperty("SortDSC", Ddo_pedidostatus_Sortdsc);
            ucDdo_pedidostatus.SetProperty("CleanFilter", Ddo_pedidostatus_Cleanfilter);
            ucDdo_pedidostatus.SetProperty("SearchButtonText", Ddo_pedidostatus_Searchbuttontext);
            ucDdo_pedidostatus.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_pedidostatus.SetProperty("DropDownOptionsData", AV34PedidoStatusTitleFilterData);
            ucDdo_pedidostatus.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_pedidostatus_Internalname, "DDO_PEDIDOSTATUSContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 139,'',false,'" + sGXsfl_119_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_pedidostatustitlecontrolidtoreplace_Internalname, AV35ddo_PedidoStatusTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,139);\"", 0, edtavDdo_pedidostatustitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_PedidoPrompt.htm");
            /* User Defined Control */
            ucDdo_pedidodtentrega.SetProperty("Caption", Ddo_pedidodtentrega_Caption);
            ucDdo_pedidodtentrega.SetProperty("Tooltip", Ddo_pedidodtentrega_Tooltip);
            ucDdo_pedidodtentrega.SetProperty("Cls", Ddo_pedidodtentrega_Cls);
            ucDdo_pedidodtentrega.SetProperty("DropDownOptionsType", Ddo_pedidodtentrega_Dropdownoptionstype);
            ucDdo_pedidodtentrega.SetProperty("IncludeSortASC", Ddo_pedidodtentrega_Includesortasc);
            ucDdo_pedidodtentrega.SetProperty("IncludeSortDSC", Ddo_pedidodtentrega_Includesortdsc);
            ucDdo_pedidodtentrega.SetProperty("IncludeFilter", Ddo_pedidodtentrega_Includefilter);
            ucDdo_pedidodtentrega.SetProperty("IncludeDataList", Ddo_pedidodtentrega_Includedatalist);
            ucDdo_pedidodtentrega.SetProperty("SortASC", Ddo_pedidodtentrega_Sortasc);
            ucDdo_pedidodtentrega.SetProperty("SortDSC", Ddo_pedidodtentrega_Sortdsc);
            ucDdo_pedidodtentrega.SetProperty("CleanFilter", Ddo_pedidodtentrega_Cleanfilter);
            ucDdo_pedidodtentrega.SetProperty("SearchButtonText", Ddo_pedidodtentrega_Searchbuttontext);
            ucDdo_pedidodtentrega.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_pedidodtentrega.SetProperty("DropDownOptionsData", AV36PedidoDtEntregaTitleFilterData);
            ucDdo_pedidodtentrega.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_pedidodtentrega_Internalname, "DDO_PEDIDODTENTREGAContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 141,'',false,'" + sGXsfl_119_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_pedidodtentregatitlecontrolidtoreplace_Internalname, AV37ddo_PedidoDtEntregaTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,141);\"", 0, edtavDdo_pedidodtentregatitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_PedidoPrompt.htm");
            /* User Defined Control */
            ucDdo_pedidoretirada.SetProperty("Caption", Ddo_pedidoretirada_Caption);
            ucDdo_pedidoretirada.SetProperty("Tooltip", Ddo_pedidoretirada_Tooltip);
            ucDdo_pedidoretirada.SetProperty("Cls", Ddo_pedidoretirada_Cls);
            ucDdo_pedidoretirada.SetProperty("DropDownOptionsType", Ddo_pedidoretirada_Dropdownoptionstype);
            ucDdo_pedidoretirada.SetProperty("IncludeSortASC", Ddo_pedidoretirada_Includesortasc);
            ucDdo_pedidoretirada.SetProperty("IncludeSortDSC", Ddo_pedidoretirada_Includesortdsc);
            ucDdo_pedidoretirada.SetProperty("IncludeFilter", Ddo_pedidoretirada_Includefilter);
            ucDdo_pedidoretirada.SetProperty("IncludeDataList", Ddo_pedidoretirada_Includedatalist);
            ucDdo_pedidoretirada.SetProperty("SortASC", Ddo_pedidoretirada_Sortasc);
            ucDdo_pedidoretirada.SetProperty("SortDSC", Ddo_pedidoretirada_Sortdsc);
            ucDdo_pedidoretirada.SetProperty("CleanFilter", Ddo_pedidoretirada_Cleanfilter);
            ucDdo_pedidoretirada.SetProperty("SearchButtonText", Ddo_pedidoretirada_Searchbuttontext);
            ucDdo_pedidoretirada.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_pedidoretirada.SetProperty("DropDownOptionsData", AV38PedidoRetiradaTitleFilterData);
            ucDdo_pedidoretirada.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_pedidoretirada_Internalname, "DDO_PEDIDORETIRADAContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 143,'',false,'" + sGXsfl_119_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_pedidoretiradatitlecontrolidtoreplace_Internalname, AV39ddo_PedidoRetiradaTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,143);\"", 0, edtavDdo_pedidoretiradatitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_PedidoPrompt.htm");
            /* User Defined Control */
            ucDdo_pedidototal.SetProperty("Caption", Ddo_pedidototal_Caption);
            ucDdo_pedidototal.SetProperty("Tooltip", Ddo_pedidototal_Tooltip);
            ucDdo_pedidototal.SetProperty("Cls", Ddo_pedidototal_Cls);
            ucDdo_pedidototal.SetProperty("DropDownOptionsType", Ddo_pedidototal_Dropdownoptionstype);
            ucDdo_pedidototal.SetProperty("IncludeSortASC", Ddo_pedidototal_Includesortasc);
            ucDdo_pedidototal.SetProperty("IncludeSortDSC", Ddo_pedidototal_Includesortdsc);
            ucDdo_pedidototal.SetProperty("IncludeFilter", Ddo_pedidototal_Includefilter);
            ucDdo_pedidototal.SetProperty("IncludeDataList", Ddo_pedidototal_Includedatalist);
            ucDdo_pedidototal.SetProperty("SortASC", Ddo_pedidototal_Sortasc);
            ucDdo_pedidototal.SetProperty("SortDSC", Ddo_pedidototal_Sortdsc);
            ucDdo_pedidototal.SetProperty("CleanFilter", Ddo_pedidototal_Cleanfilter);
            ucDdo_pedidototal.SetProperty("SearchButtonText", Ddo_pedidototal_Searchbuttontext);
            ucDdo_pedidototal.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_pedidototal.SetProperty("DropDownOptionsData", AV47PedidoTotalTitleFilterData);
            ucDdo_pedidototal.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_pedidototal_Internalname, "DDO_PEDIDOTOTALContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 145,'',false,'" + sGXsfl_119_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_pedidototaltitlecontrolidtoreplace_Internalname, AV48ddo_PedidoTotalTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,145);\"", 0, edtavDdo_pedidototaltitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_PedidoPrompt.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities_f5", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 147,'',false,'" + sGXsfl_119_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavDynamicfiltersenabled2_Internalname, StringUtil.BoolToStr( AV17DynamicFiltersEnabled2), "", "", chkavDynamicfiltersenabled2.Visible, 1, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(147, this, 'true', 'false');gx.evt.onchange(this, event);\" ");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 148,'',false,'" + sGXsfl_119_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavDynamicfiltersenabled3_Internalname, StringUtil.BoolToStr( AV22DynamicFiltersEnabled3), "", "", chkavDynamicfiltersenabled3.Visible, 1, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(148, this, 'true', 'false');gx.evt.onchange(this, event);\" ");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 149,'',false,'" + sGXsfl_119_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11OrderedBy), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,149);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PedidoPrompt.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 150,'',false,'" + sGXsfl_119_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV12OrderedDsc), StringUtil.BoolToStr( AV12OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,150);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_PedidoPrompt.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 119 )
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

      protected void START142( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_2-131213", 0) ;
            Form.Meta.addItem("description", "Consulta de Pedido", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP140( ) ;
      }

      protected void WS142( )
      {
         START142( ) ;
         EVT142( ) ;
      }

      protected void EVT142( )
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
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E11142 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E12142 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PEDIDOID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E13142 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PEDIDODT.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E14142 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PEDIDOSTATUS.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E15142 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PEDIDODTENTREGA.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E16142 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PEDIDORETIRADA.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E17142 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PEDIDOTOTAL.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E18142 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'REMOVEDYNAMICFILTERS1'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'RemoveDynamicFilters1' */
                              E19142 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'REMOVEDYNAMICFILTERS2'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'RemoveDynamicFilters2' */
                              E20142 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'REMOVEDYNAMICFILTERS3'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'RemoveDynamicFilters3' */
                              E21142 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOCLEANFILTERS'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoCleanFilters' */
                              E22142 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'ADDDYNAMICFILTERS1'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'AddDynamicFilters1' */
                              E23142 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VDYNAMICFILTERSSELECTOR1.CLICK") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E24142 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VDYNAMICFILTERSOPERATOR1.CLICK") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E25142 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'ADDDYNAMICFILTERS2'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'AddDynamicFilters2' */
                              E26142 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VDYNAMICFILTERSSELECTOR2.CLICK") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E27142 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VDYNAMICFILTERSOPERATOR2.CLICK") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E28142 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VDYNAMICFILTERSSELECTOR3.CLICK") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E29142 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VDYNAMICFILTERSOPERATOR3.CLICK") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E30142 ();
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) )
                           {
                              nGXsfl_119_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_119_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_119_idx), 4, 0)), 4, "0");
                              SubsflControlProps_1192( ) ;
                              AV44Select = cgiGet( edtavSelect_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV44Select)) ? AV51Select_GXI : context.convertURL( context.PathToRelativeUrl( AV44Select))), !bGXsfl_119_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "SrcSet", context.GetImageSrcSet( AV44Select), true);
                              A32PedidoId = (short)(context.localUtil.CToN( cgiGet( edtPedidoId_Internalname), ",", "."));
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
                                    E31142 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E32142 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E33142 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Dynamicfiltersselector1 Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vDYNAMICFILTERSSELECTOR1"), AV13DynamicFiltersSelector1) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Dynamicfiltersoperator1 Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vDYNAMICFILTERSOPERATOR1"), ",", ".") != Convert.ToDecimal( AV14DynamicFiltersOperator1 )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Pedidodt1 Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vPEDIDODT1"), 0) != AV15PedidoDt1 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Pedidodt_to1 Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vPEDIDODT_TO1"), 0) != AV16PedidoDt_To1 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Dynamicfiltersselector2 Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vDYNAMICFILTERSSELECTOR2"), AV18DynamicFiltersSelector2) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Dynamicfiltersoperator2 Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vDYNAMICFILTERSOPERATOR2"), ",", ".") != Convert.ToDecimal( AV19DynamicFiltersOperator2 )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Pedidodt2 Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vPEDIDODT2"), 0) != AV20PedidoDt2 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Pedidodt_to2 Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vPEDIDODT_TO2"), 0) != AV21PedidoDt_To2 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Dynamicfiltersselector3 Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vDYNAMICFILTERSSELECTOR3"), AV23DynamicFiltersSelector3) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Dynamicfiltersoperator3 Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vDYNAMICFILTERSOPERATOR3"), ",", ".") != Convert.ToDecimal( AV24DynamicFiltersOperator3 )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Pedidodt3 Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vPEDIDODT3"), 0) != AV25PedidoDt3 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Pedidodt_to3 Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vPEDIDODT_TO3"), 0) != AV26PedidoDt_To3 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Dynamicfiltersenabled2 Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vDYNAMICFILTERSENABLED2")) != AV17DynamicFiltersEnabled2 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Dynamicfiltersenabled3 Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vDYNAMICFILTERSENABLED3")) != AV22DynamicFiltersEnabled3 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Orderedby Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ",", ".") != Convert.ToDecimal( AV11OrderedBy )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ordereddsc Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV12OrderedDsc )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: Enter */
                                          E34142 ();
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

      protected void WE142( )
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

      protected void PA142( )
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
         SubsflControlProps_1192( ) ;
         while ( nGXsfl_119_idx <= nRC_GXsfl_119 )
         {
            sendrow_1192( ) ;
            nGXsfl_119_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_119_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_119_idx+1));
            sGXsfl_119_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_119_idx), 4, 0)), 4, "0");
            SubsflControlProps_1192( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       String AV13DynamicFiltersSelector1 ,
                                       short AV14DynamicFiltersOperator1 ,
                                       DateTime AV15PedidoDt1 ,
                                       DateTime AV16PedidoDt_To1 ,
                                       String AV18DynamicFiltersSelector2 ,
                                       short AV19DynamicFiltersOperator2 ,
                                       DateTime AV20PedidoDt2 ,
                                       DateTime AV21PedidoDt_To2 ,
                                       String AV23DynamicFiltersSelector3 ,
                                       short AV24DynamicFiltersOperator3 ,
                                       DateTime AV25PedidoDt3 ,
                                       DateTime AV26PedidoDt_To3 ,
                                       bool AV17DynamicFiltersEnabled2 ,
                                       bool AV22DynamicFiltersEnabled3 ,
                                       short AV11OrderedBy ,
                                       bool AV12OrderedDsc ,
                                       String AV31ddo_PedidoIdTitleControlIdToReplace ,
                                       String AV33ddo_PedidoDtTitleControlIdToReplace ,
                                       String AV35ddo_PedidoStatusTitleControlIdToReplace ,
                                       String AV37ddo_PedidoDtEntregaTitleControlIdToReplace ,
                                       String AV39ddo_PedidoRetiradaTitleControlIdToReplace ,
                                       String AV48ddo_PedidoTotalTitleControlIdToReplace )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF142( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_PEDIDOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A32PedidoId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "PEDIDOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A32PedidoId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_PEDIDODT", GetSecureSignedToken( "", A33PedidoDt, context));
         GxWebStd.gx_hidden_field( context, "PEDIDODT", context.localUtil.Format(A33PedidoDt, "99/99/99"));
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
            AV13DynamicFiltersSelector1 = cmbavDynamicfiltersselector1.getValidValue(AV13DynamicFiltersSelector1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13DynamicFiltersSelector1", AV13DynamicFiltersSelector1);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavDynamicfiltersselector1.CurrentValue = StringUtil.RTrim( AV13DynamicFiltersSelector1);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector1_Internalname, "Values", cmbavDynamicfiltersselector1.ToJavascriptSource(), true);
         }
         if ( cmbavDynamicfiltersoperator1.ItemCount > 0 )
         {
            AV14DynamicFiltersOperator1 = (short)(NumberUtil.Val( cmbavDynamicfiltersoperator1.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14DynamicFiltersOperator1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", cmbavDynamicfiltersoperator1.ToJavascriptSource(), true);
         }
         if ( cmbavDynamicfiltersselector2.ItemCount > 0 )
         {
            AV18DynamicFiltersSelector2 = cmbavDynamicfiltersselector2.getValidValue(AV18DynamicFiltersSelector2);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18DynamicFiltersSelector2", AV18DynamicFiltersSelector2);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavDynamicfiltersselector2.CurrentValue = StringUtil.RTrim( AV18DynamicFiltersSelector2);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector2_Internalname, "Values", cmbavDynamicfiltersselector2.ToJavascriptSource(), true);
         }
         if ( cmbavDynamicfiltersoperator2.ItemCount > 0 )
         {
            AV19DynamicFiltersOperator2 = (short)(NumberUtil.Val( cmbavDynamicfiltersoperator2.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19DynamicFiltersOperator2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", cmbavDynamicfiltersoperator2.ToJavascriptSource(), true);
         }
         if ( cmbavDynamicfiltersselector3.ItemCount > 0 )
         {
            AV23DynamicFiltersSelector3 = cmbavDynamicfiltersselector3.getValidValue(AV23DynamicFiltersSelector3);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23DynamicFiltersSelector3", AV23DynamicFiltersSelector3);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavDynamicfiltersselector3.CurrentValue = StringUtil.RTrim( AV23DynamicFiltersSelector3);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector3_Internalname, "Values", cmbavDynamicfiltersselector3.ToJavascriptSource(), true);
         }
         if ( cmbavDynamicfiltersoperator3.ItemCount > 0 )
         {
            AV24DynamicFiltersOperator3 = (short)(NumberUtil.Val( cmbavDynamicfiltersoperator3.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24DynamicFiltersOperator3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", cmbavDynamicfiltersoperator3.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF142( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         Gx_date = DateTimeUtil.Today( context);
         context.Gx_err = 0;
      }

      protected void RF142( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 119;
         /* Execute user event: Refresh */
         E32142 ();
         nGXsfl_119_idx = 1;
         sGXsfl_119_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_119_idx), 4, 0)), 4, "0");
         SubsflControlProps_1192( ) ;
         bGXsfl_119_Refreshing = true;
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
            SubsflControlProps_1192( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV13DynamicFiltersSelector1 ,
                                                 AV14DynamicFiltersOperator1 ,
                                                 AV15PedidoDt1 ,
                                                 AV16PedidoDt_To1 ,
                                                 AV17DynamicFiltersEnabled2 ,
                                                 AV18DynamicFiltersSelector2 ,
                                                 AV19DynamicFiltersOperator2 ,
                                                 AV20PedidoDt2 ,
                                                 AV21PedidoDt_To2 ,
                                                 AV22DynamicFiltersEnabled3 ,
                                                 AV23DynamicFiltersSelector3 ,
                                                 AV24DynamicFiltersOperator3 ,
                                                 AV25PedidoDt3 ,
                                                 AV26PedidoDt_To3 ,
                                                 A33PedidoDt ,
                                                 AV11OrderedBy ,
                                                 AV12OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.BOOLEAN,
                                                 TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            /* Using cursor H00142 */
            pr_default.execute(0, new Object[] {AV15PedidoDt1, AV15PedidoDt1, AV15PedidoDt1, AV15PedidoDt1, AV16PedidoDt_To1, AV20PedidoDt2, AV20PedidoDt2, AV20PedidoDt2, AV20PedidoDt2, AV21PedidoDt_To2, AV25PedidoDt3, AV25PedidoDt3, AV25PedidoDt3, AV25PedidoDt3, AV26PedidoDt_To3, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_119_idx = 1;
            sGXsfl_119_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_119_idx), 4, 0)), 4, "0");
            SubsflControlProps_1192( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A37PedidoTotal = H00142_A37PedidoTotal[0];
               A36PedidoRetirada = H00142_A36PedidoRetirada[0];
               A35PedidoDtEntrega = H00142_A35PedidoDtEntrega[0];
               A34PedidoStatus = H00142_A34PedidoStatus[0];
               A33PedidoDt = H00142_A33PedidoDt[0];
               A32PedidoId = H00142_A32PedidoId[0];
               E33142 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 119;
            WB140( ) ;
         }
         bGXsfl_119_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes142( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_PEDIDOID"+"_"+sGXsfl_119_idx, GetSecureSignedToken( sGXsfl_119_idx, context.localUtil.Format( (decimal)(A32PedidoId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_PEDIDODT"+"_"+sGXsfl_119_idx, GetSecureSignedToken( sGXsfl_119_idx, A33PedidoDt, context));
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
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV13DynamicFiltersSelector1 ,
                                              AV14DynamicFiltersOperator1 ,
                                              AV15PedidoDt1 ,
                                              AV16PedidoDt_To1 ,
                                              AV17DynamicFiltersEnabled2 ,
                                              AV18DynamicFiltersSelector2 ,
                                              AV19DynamicFiltersOperator2 ,
                                              AV20PedidoDt2 ,
                                              AV21PedidoDt_To2 ,
                                              AV22DynamicFiltersEnabled3 ,
                                              AV23DynamicFiltersSelector3 ,
                                              AV24DynamicFiltersOperator3 ,
                                              AV25PedidoDt3 ,
                                              AV26PedidoDt_To3 ,
                                              A33PedidoDt ,
                                              AV11OrderedBy ,
                                              AV12OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         /* Using cursor H00143 */
         pr_default.execute(1, new Object[] {AV15PedidoDt1, AV15PedidoDt1, AV15PedidoDt1, AV15PedidoDt1, AV16PedidoDt_To1, AV20PedidoDt2, AV20PedidoDt2, AV20PedidoDt2, AV20PedidoDt2, AV21PedidoDt_To2, AV25PedidoDt3, AV25PedidoDt3, AV25PedidoDt3, AV25PedidoDt3, AV26PedidoDt_To3});
         GRID_nRecordCount = H00143_AGRID_nRecordCount[0];
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
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15PedidoDt1, AV16PedidoDt_To1, AV18DynamicFiltersSelector2, AV19DynamicFiltersOperator2, AV20PedidoDt2, AV21PedidoDt_To2, AV23DynamicFiltersSelector3, AV24DynamicFiltersOperator3, AV25PedidoDt3, AV26PedidoDt_To3, AV17DynamicFiltersEnabled2, AV22DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV31ddo_PedidoIdTitleControlIdToReplace, AV33ddo_PedidoDtTitleControlIdToReplace, AV35ddo_PedidoStatusTitleControlIdToReplace, AV37ddo_PedidoDtEntregaTitleControlIdToReplace, AV39ddo_PedidoRetiradaTitleControlIdToReplace, AV48ddo_PedidoTotalTitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
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
            gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15PedidoDt1, AV16PedidoDt_To1, AV18DynamicFiltersSelector2, AV19DynamicFiltersOperator2, AV20PedidoDt2, AV21PedidoDt_To2, AV23DynamicFiltersSelector3, AV24DynamicFiltersOperator3, AV25PedidoDt3, AV26PedidoDt_To3, AV17DynamicFiltersEnabled2, AV22DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV31ddo_PedidoIdTitleControlIdToReplace, AV33ddo_PedidoDtTitleControlIdToReplace, AV35ddo_PedidoStatusTitleControlIdToReplace, AV37ddo_PedidoDtEntregaTitleControlIdToReplace, AV39ddo_PedidoRetiradaTitleControlIdToReplace, AV48ddo_PedidoTotalTitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
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
            gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15PedidoDt1, AV16PedidoDt_To1, AV18DynamicFiltersSelector2, AV19DynamicFiltersOperator2, AV20PedidoDt2, AV21PedidoDt_To2, AV23DynamicFiltersSelector3, AV24DynamicFiltersOperator3, AV25PedidoDt3, AV26PedidoDt_To3, AV17DynamicFiltersEnabled2, AV22DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV31ddo_PedidoIdTitleControlIdToReplace, AV33ddo_PedidoDtTitleControlIdToReplace, AV35ddo_PedidoStatusTitleControlIdToReplace, AV37ddo_PedidoDtEntregaTitleControlIdToReplace, AV39ddo_PedidoRetiradaTitleControlIdToReplace, AV48ddo_PedidoTotalTitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
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
            gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15PedidoDt1, AV16PedidoDt_To1, AV18DynamicFiltersSelector2, AV19DynamicFiltersOperator2, AV20PedidoDt2, AV21PedidoDt_To2, AV23DynamicFiltersSelector3, AV24DynamicFiltersOperator3, AV25PedidoDt3, AV26PedidoDt_To3, AV17DynamicFiltersEnabled2, AV22DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV31ddo_PedidoIdTitleControlIdToReplace, AV33ddo_PedidoDtTitleControlIdToReplace, AV35ddo_PedidoStatusTitleControlIdToReplace, AV37ddo_PedidoDtEntregaTitleControlIdToReplace, AV39ddo_PedidoRetiradaTitleControlIdToReplace, AV48ddo_PedidoTotalTitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
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
            gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15PedidoDt1, AV16PedidoDt_To1, AV18DynamicFiltersSelector2, AV19DynamicFiltersOperator2, AV20PedidoDt2, AV21PedidoDt_To2, AV23DynamicFiltersSelector3, AV24DynamicFiltersOperator3, AV25PedidoDt3, AV26PedidoDt_To3, AV17DynamicFiltersEnabled2, AV22DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV31ddo_PedidoIdTitleControlIdToReplace, AV33ddo_PedidoDtTitleControlIdToReplace, AV35ddo_PedidoStatusTitleControlIdToReplace, AV37ddo_PedidoDtEntregaTitleControlIdToReplace, AV39ddo_PedidoRetiradaTitleControlIdToReplace, AV48ddo_PedidoTotalTitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP140( )
      {
         /* Before Start, stand alone formulas. */
         Gx_date = DateTimeUtil.Today( context);
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E31142 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV40DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vPEDIDOIDTITLEFILTERDATA"), AV30PedidoIdTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPEDIDODTTITLEFILTERDATA"), AV32PedidoDtTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPEDIDOSTATUSTITLEFILTERDATA"), AV34PedidoStatusTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPEDIDODTENTREGATITLEFILTERDATA"), AV36PedidoDtEntregaTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPEDIDORETIRADATITLEFILTERDATA"), AV38PedidoRetiradaTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPEDIDOTOTALTITLEFILTERDATA"), AV47PedidoTotalTitleFilterData);
            /* Read variables values. */
            cmbavDynamicfiltersselector1.Name = cmbavDynamicfiltersselector1_Internalname;
            cmbavDynamicfiltersselector1.CurrentValue = cgiGet( cmbavDynamicfiltersselector1_Internalname);
            AV13DynamicFiltersSelector1 = cgiGet( cmbavDynamicfiltersselector1_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13DynamicFiltersSelector1", AV13DynamicFiltersSelector1);
            cmbavDynamicfiltersoperator1.Name = cmbavDynamicfiltersoperator1_Internalname;
            cmbavDynamicfiltersoperator1.CurrentValue = cgiGet( cmbavDynamicfiltersoperator1_Internalname);
            AV14DynamicFiltersOperator1 = (short)(NumberUtil.Val( cgiGet( cmbavDynamicfiltersoperator1_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14DynamicFiltersOperator1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0)));
            if ( context.localUtil.VCDate( cgiGet( edtavPedidodt1_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Pedido Dt1"}), 1, "vPEDIDODT1");
               GX_FocusControl = edtavPedidodt1_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV15PedidoDt1 = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15PedidoDt1", context.localUtil.Format(AV15PedidoDt1, "99/99/99"));
            }
            else
            {
               AV15PedidoDt1 = context.localUtil.CToD( cgiGet( edtavPedidodt1_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15PedidoDt1", context.localUtil.Format(AV15PedidoDt1, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavPedidodt_to1_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Pedido Dt_To1"}), 1, "vPEDIDODT_TO1");
               GX_FocusControl = edtavPedidodt_to1_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV16PedidoDt_To1 = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16PedidoDt_To1", context.localUtil.Format(AV16PedidoDt_To1, "99/99/99"));
            }
            else
            {
               AV16PedidoDt_To1 = context.localUtil.CToD( cgiGet( edtavPedidodt_to1_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16PedidoDt_To1", context.localUtil.Format(AV16PedidoDt_To1, "99/99/99"));
            }
            cmbavDynamicfiltersselector2.Name = cmbavDynamicfiltersselector2_Internalname;
            cmbavDynamicfiltersselector2.CurrentValue = cgiGet( cmbavDynamicfiltersselector2_Internalname);
            AV18DynamicFiltersSelector2 = cgiGet( cmbavDynamicfiltersselector2_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18DynamicFiltersSelector2", AV18DynamicFiltersSelector2);
            cmbavDynamicfiltersoperator2.Name = cmbavDynamicfiltersoperator2_Internalname;
            cmbavDynamicfiltersoperator2.CurrentValue = cgiGet( cmbavDynamicfiltersoperator2_Internalname);
            AV19DynamicFiltersOperator2 = (short)(NumberUtil.Val( cgiGet( cmbavDynamicfiltersoperator2_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19DynamicFiltersOperator2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0)));
            if ( context.localUtil.VCDate( cgiGet( edtavPedidodt2_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Pedido Dt2"}), 1, "vPEDIDODT2");
               GX_FocusControl = edtavPedidodt2_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV20PedidoDt2 = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20PedidoDt2", context.localUtil.Format(AV20PedidoDt2, "99/99/99"));
            }
            else
            {
               AV20PedidoDt2 = context.localUtil.CToD( cgiGet( edtavPedidodt2_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20PedidoDt2", context.localUtil.Format(AV20PedidoDt2, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavPedidodt_to2_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Pedido Dt_To2"}), 1, "vPEDIDODT_TO2");
               GX_FocusControl = edtavPedidodt_to2_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV21PedidoDt_To2 = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21PedidoDt_To2", context.localUtil.Format(AV21PedidoDt_To2, "99/99/99"));
            }
            else
            {
               AV21PedidoDt_To2 = context.localUtil.CToD( cgiGet( edtavPedidodt_to2_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21PedidoDt_To2", context.localUtil.Format(AV21PedidoDt_To2, "99/99/99"));
            }
            cmbavDynamicfiltersselector3.Name = cmbavDynamicfiltersselector3_Internalname;
            cmbavDynamicfiltersselector3.CurrentValue = cgiGet( cmbavDynamicfiltersselector3_Internalname);
            AV23DynamicFiltersSelector3 = cgiGet( cmbavDynamicfiltersselector3_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23DynamicFiltersSelector3", AV23DynamicFiltersSelector3);
            cmbavDynamicfiltersoperator3.Name = cmbavDynamicfiltersoperator3_Internalname;
            cmbavDynamicfiltersoperator3.CurrentValue = cgiGet( cmbavDynamicfiltersoperator3_Internalname);
            AV24DynamicFiltersOperator3 = (short)(NumberUtil.Val( cgiGet( cmbavDynamicfiltersoperator3_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24DynamicFiltersOperator3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0)));
            if ( context.localUtil.VCDate( cgiGet( edtavPedidodt3_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Pedido Dt3"}), 1, "vPEDIDODT3");
               GX_FocusControl = edtavPedidodt3_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV25PedidoDt3 = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25PedidoDt3", context.localUtil.Format(AV25PedidoDt3, "99/99/99"));
            }
            else
            {
               AV25PedidoDt3 = context.localUtil.CToD( cgiGet( edtavPedidodt3_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25PedidoDt3", context.localUtil.Format(AV25PedidoDt3, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavPedidodt_to3_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Pedido Dt_To3"}), 1, "vPEDIDODT_TO3");
               GX_FocusControl = edtavPedidodt_to3_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV26PedidoDt_To3 = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26PedidoDt_To3", context.localUtil.Format(AV26PedidoDt_To3, "99/99/99"));
            }
            else
            {
               AV26PedidoDt_To3 = context.localUtil.CToD( cgiGet( edtavPedidodt_to3_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26PedidoDt_To3", context.localUtil.Format(AV26PedidoDt_To3, "99/99/99"));
            }
            AV31ddo_PedidoIdTitleControlIdToReplace = cgiGet( edtavDdo_pedidoidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_PedidoIdTitleControlIdToReplace", AV31ddo_PedidoIdTitleControlIdToReplace);
            AV33ddo_PedidoDtTitleControlIdToReplace = cgiGet( edtavDdo_pedidodttitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33ddo_PedidoDtTitleControlIdToReplace", AV33ddo_PedidoDtTitleControlIdToReplace);
            AV35ddo_PedidoStatusTitleControlIdToReplace = cgiGet( edtavDdo_pedidostatustitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ddo_PedidoStatusTitleControlIdToReplace", AV35ddo_PedidoStatusTitleControlIdToReplace);
            AV37ddo_PedidoDtEntregaTitleControlIdToReplace = cgiGet( edtavDdo_pedidodtentregatitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37ddo_PedidoDtEntregaTitleControlIdToReplace", AV37ddo_PedidoDtEntregaTitleControlIdToReplace);
            AV39ddo_PedidoRetiradaTitleControlIdToReplace = cgiGet( edtavDdo_pedidoretiradatitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39ddo_PedidoRetiradaTitleControlIdToReplace", AV39ddo_PedidoRetiradaTitleControlIdToReplace);
            AV48ddo_PedidoTotalTitleControlIdToReplace = cgiGet( edtavDdo_pedidototaltitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV48ddo_PedidoTotalTitleControlIdToReplace", AV48ddo_PedidoTotalTitleControlIdToReplace);
            AV17DynamicFiltersEnabled2 = StringUtil.StrToBool( cgiGet( chkavDynamicfiltersenabled2_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17DynamicFiltersEnabled2", AV17DynamicFiltersEnabled2);
            AV22DynamicFiltersEnabled3 = StringUtil.StrToBool( cgiGet( chkavDynamicfiltersenabled3_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22DynamicFiltersEnabled3", AV22DynamicFiltersEnabled3);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vORDEREDBY");
               GX_FocusControl = edtavOrderedby_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV11OrderedBy = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            }
            else
            {
               AV11OrderedBy = (short)(context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            }
            AV12OrderedDsc = StringUtil.StrToBool( cgiGet( edtavOrdereddsc_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            /* Read saved values. */
            nRC_GXsfl_119 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_119"), ",", "."));
            AV42GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ",", "."));
            AV43GridPageCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGECOUNT"), ",", "."));
            GRID_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID_nFirstRecordOnPage"), ",", "."));
            GRID_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID_nEOF"), ",", "."));
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ",", "."));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
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
            Ddo_pedidoid_Dropdownoptionstype = cgiGet( "DDO_PEDIDOID_Dropdownoptionstype");
            Ddo_pedidoid_Titlecontrolidtoreplace = cgiGet( "DDO_PEDIDOID_Titlecontrolidtoreplace");
            Ddo_pedidoid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PEDIDOID_Includesortasc"));
            Ddo_pedidoid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PEDIDOID_Includesortdsc"));
            Ddo_pedidoid_Sortedstatus = cgiGet( "DDO_PEDIDOID_Sortedstatus");
            Ddo_pedidoid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PEDIDOID_Includefilter"));
            Ddo_pedidoid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PEDIDOID_Includedatalist"));
            Ddo_pedidoid_Sortasc = cgiGet( "DDO_PEDIDOID_Sortasc");
            Ddo_pedidoid_Sortdsc = cgiGet( "DDO_PEDIDOID_Sortdsc");
            Ddo_pedidoid_Cleanfilter = cgiGet( "DDO_PEDIDOID_Cleanfilter");
            Ddo_pedidoid_Searchbuttontext = cgiGet( "DDO_PEDIDOID_Searchbuttontext");
            Ddo_pedidodt_Caption = cgiGet( "DDO_PEDIDODT_Caption");
            Ddo_pedidodt_Tooltip = cgiGet( "DDO_PEDIDODT_Tooltip");
            Ddo_pedidodt_Cls = cgiGet( "DDO_PEDIDODT_Cls");
            Ddo_pedidodt_Dropdownoptionstype = cgiGet( "DDO_PEDIDODT_Dropdownoptionstype");
            Ddo_pedidodt_Titlecontrolidtoreplace = cgiGet( "DDO_PEDIDODT_Titlecontrolidtoreplace");
            Ddo_pedidodt_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PEDIDODT_Includesortasc"));
            Ddo_pedidodt_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PEDIDODT_Includesortdsc"));
            Ddo_pedidodt_Sortedstatus = cgiGet( "DDO_PEDIDODT_Sortedstatus");
            Ddo_pedidodt_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PEDIDODT_Includefilter"));
            Ddo_pedidodt_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PEDIDODT_Includedatalist"));
            Ddo_pedidodt_Sortasc = cgiGet( "DDO_PEDIDODT_Sortasc");
            Ddo_pedidodt_Sortdsc = cgiGet( "DDO_PEDIDODT_Sortdsc");
            Ddo_pedidodt_Cleanfilter = cgiGet( "DDO_PEDIDODT_Cleanfilter");
            Ddo_pedidodt_Searchbuttontext = cgiGet( "DDO_PEDIDODT_Searchbuttontext");
            Ddo_pedidostatus_Caption = cgiGet( "DDO_PEDIDOSTATUS_Caption");
            Ddo_pedidostatus_Tooltip = cgiGet( "DDO_PEDIDOSTATUS_Tooltip");
            Ddo_pedidostatus_Cls = cgiGet( "DDO_PEDIDOSTATUS_Cls");
            Ddo_pedidostatus_Dropdownoptionstype = cgiGet( "DDO_PEDIDOSTATUS_Dropdownoptionstype");
            Ddo_pedidostatus_Titlecontrolidtoreplace = cgiGet( "DDO_PEDIDOSTATUS_Titlecontrolidtoreplace");
            Ddo_pedidostatus_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PEDIDOSTATUS_Includesortasc"));
            Ddo_pedidostatus_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PEDIDOSTATUS_Includesortdsc"));
            Ddo_pedidostatus_Sortedstatus = cgiGet( "DDO_PEDIDOSTATUS_Sortedstatus");
            Ddo_pedidostatus_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PEDIDOSTATUS_Includefilter"));
            Ddo_pedidostatus_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PEDIDOSTATUS_Includedatalist"));
            Ddo_pedidostatus_Sortasc = cgiGet( "DDO_PEDIDOSTATUS_Sortasc");
            Ddo_pedidostatus_Sortdsc = cgiGet( "DDO_PEDIDOSTATUS_Sortdsc");
            Ddo_pedidostatus_Cleanfilter = cgiGet( "DDO_PEDIDOSTATUS_Cleanfilter");
            Ddo_pedidostatus_Searchbuttontext = cgiGet( "DDO_PEDIDOSTATUS_Searchbuttontext");
            Ddo_pedidodtentrega_Caption = cgiGet( "DDO_PEDIDODTENTREGA_Caption");
            Ddo_pedidodtentrega_Tooltip = cgiGet( "DDO_PEDIDODTENTREGA_Tooltip");
            Ddo_pedidodtentrega_Cls = cgiGet( "DDO_PEDIDODTENTREGA_Cls");
            Ddo_pedidodtentrega_Dropdownoptionstype = cgiGet( "DDO_PEDIDODTENTREGA_Dropdownoptionstype");
            Ddo_pedidodtentrega_Titlecontrolidtoreplace = cgiGet( "DDO_PEDIDODTENTREGA_Titlecontrolidtoreplace");
            Ddo_pedidodtentrega_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PEDIDODTENTREGA_Includesortasc"));
            Ddo_pedidodtentrega_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PEDIDODTENTREGA_Includesortdsc"));
            Ddo_pedidodtentrega_Sortedstatus = cgiGet( "DDO_PEDIDODTENTREGA_Sortedstatus");
            Ddo_pedidodtentrega_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PEDIDODTENTREGA_Includefilter"));
            Ddo_pedidodtentrega_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PEDIDODTENTREGA_Includedatalist"));
            Ddo_pedidodtentrega_Sortasc = cgiGet( "DDO_PEDIDODTENTREGA_Sortasc");
            Ddo_pedidodtentrega_Sortdsc = cgiGet( "DDO_PEDIDODTENTREGA_Sortdsc");
            Ddo_pedidodtentrega_Cleanfilter = cgiGet( "DDO_PEDIDODTENTREGA_Cleanfilter");
            Ddo_pedidodtentrega_Searchbuttontext = cgiGet( "DDO_PEDIDODTENTREGA_Searchbuttontext");
            Ddo_pedidoretirada_Caption = cgiGet( "DDO_PEDIDORETIRADA_Caption");
            Ddo_pedidoretirada_Tooltip = cgiGet( "DDO_PEDIDORETIRADA_Tooltip");
            Ddo_pedidoretirada_Cls = cgiGet( "DDO_PEDIDORETIRADA_Cls");
            Ddo_pedidoretirada_Dropdownoptionstype = cgiGet( "DDO_PEDIDORETIRADA_Dropdownoptionstype");
            Ddo_pedidoretirada_Titlecontrolidtoreplace = cgiGet( "DDO_PEDIDORETIRADA_Titlecontrolidtoreplace");
            Ddo_pedidoretirada_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PEDIDORETIRADA_Includesortasc"));
            Ddo_pedidoretirada_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PEDIDORETIRADA_Includesortdsc"));
            Ddo_pedidoretirada_Sortedstatus = cgiGet( "DDO_PEDIDORETIRADA_Sortedstatus");
            Ddo_pedidoretirada_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PEDIDORETIRADA_Includefilter"));
            Ddo_pedidoretirada_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PEDIDORETIRADA_Includedatalist"));
            Ddo_pedidoretirada_Sortasc = cgiGet( "DDO_PEDIDORETIRADA_Sortasc");
            Ddo_pedidoretirada_Sortdsc = cgiGet( "DDO_PEDIDORETIRADA_Sortdsc");
            Ddo_pedidoretirada_Cleanfilter = cgiGet( "DDO_PEDIDORETIRADA_Cleanfilter");
            Ddo_pedidoretirada_Searchbuttontext = cgiGet( "DDO_PEDIDORETIRADA_Searchbuttontext");
            Ddo_pedidototal_Caption = cgiGet( "DDO_PEDIDOTOTAL_Caption");
            Ddo_pedidototal_Tooltip = cgiGet( "DDO_PEDIDOTOTAL_Tooltip");
            Ddo_pedidototal_Cls = cgiGet( "DDO_PEDIDOTOTAL_Cls");
            Ddo_pedidototal_Dropdownoptionstype = cgiGet( "DDO_PEDIDOTOTAL_Dropdownoptionstype");
            Ddo_pedidototal_Titlecontrolidtoreplace = cgiGet( "DDO_PEDIDOTOTAL_Titlecontrolidtoreplace");
            Ddo_pedidototal_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PEDIDOTOTAL_Includesortasc"));
            Ddo_pedidototal_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PEDIDOTOTAL_Includesortdsc"));
            Ddo_pedidototal_Sortedstatus = cgiGet( "DDO_PEDIDOTOTAL_Sortedstatus");
            Ddo_pedidototal_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PEDIDOTOTAL_Includefilter"));
            Ddo_pedidototal_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PEDIDOTOTAL_Includedatalist"));
            Ddo_pedidototal_Sortasc = cgiGet( "DDO_PEDIDOTOTAL_Sortasc");
            Ddo_pedidototal_Sortdsc = cgiGet( "DDO_PEDIDOTOTAL_Sortdsc");
            Ddo_pedidototal_Cleanfilter = cgiGet( "DDO_PEDIDOTOTAL_Cleanfilter");
            Ddo_pedidototal_Searchbuttontext = cgiGet( "DDO_PEDIDOTOTAL_Searchbuttontext");
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ",", "."));
            Ddo_pedidoid_Activeeventkey = cgiGet( "DDO_PEDIDOID_Activeeventkey");
            Ddo_pedidodt_Activeeventkey = cgiGet( "DDO_PEDIDODT_Activeeventkey");
            Ddo_pedidostatus_Activeeventkey = cgiGet( "DDO_PEDIDOSTATUS_Activeeventkey");
            Ddo_pedidodtentrega_Activeeventkey = cgiGet( "DDO_PEDIDODTENTREGA_Activeeventkey");
            Ddo_pedidoretirada_Activeeventkey = cgiGet( "DDO_PEDIDORETIRADA_Activeeventkey");
            Ddo_pedidototal_Activeeventkey = cgiGet( "DDO_PEDIDOTOTAL_Activeeventkey");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( StringUtil.StrCmp(cgiGet( "GXH_vDYNAMICFILTERSSELECTOR1"), AV13DynamicFiltersSelector1) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vDYNAMICFILTERSOPERATOR1"), ",", ".") != Convert.ToDecimal( AV14DynamicFiltersOperator1 )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vPEDIDODT1"), 2) != AV15PedidoDt1 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vPEDIDODT_TO1"), 2) != AV16PedidoDt_To1 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vDYNAMICFILTERSSELECTOR2"), AV18DynamicFiltersSelector2) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vDYNAMICFILTERSOPERATOR2"), ",", ".") != Convert.ToDecimal( AV19DynamicFiltersOperator2 )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vPEDIDODT2"), 2) != AV20PedidoDt2 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vPEDIDODT_TO2"), 2) != AV21PedidoDt_To2 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vDYNAMICFILTERSSELECTOR3"), AV23DynamicFiltersSelector3) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vDYNAMICFILTERSOPERATOR3"), ",", ".") != Convert.ToDecimal( AV24DynamicFiltersOperator3 )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vPEDIDODT3"), 2) != AV25PedidoDt3 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vPEDIDODT_TO3"), 2) != AV26PedidoDt_To3 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vDYNAMICFILTERSENABLED2")) != AV17DynamicFiltersEnabled2 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vDYNAMICFILTERSENABLED3")) != AV22DynamicFiltersEnabled3 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ",", ".") != Convert.ToDecimal( AV11OrderedBy )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV12OrderedDsc )
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
         E31142 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E31142( )
      {
         /* Start Routine */
         subGrid_Rows = 10;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         lblJsdynamicfilters_Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblJsdynamicfilters_Internalname, "Caption", lblJsdynamicfilters_Caption, true);
         chkavDynamicfiltersenabled2.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavDynamicfiltersenabled2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavDynamicfiltersenabled2.Visible), 5, 0)), true);
         chkavDynamicfiltersenabled3.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavDynamicfiltersenabled3_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavDynamicfiltersenabled3.Visible), 5, 0)), true);
         AV13DynamicFiltersSelector1 = "PEDIDODT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13DynamicFiltersSelector1", AV13DynamicFiltersSelector1);
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS1' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV18DynamicFiltersSelector2 = "PEDIDODT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18DynamicFiltersSelector2", AV18DynamicFiltersSelector2);
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS2' */
         S122 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV23DynamicFiltersSelector3 = "PEDIDODT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23DynamicFiltersSelector3", AV23DynamicFiltersSelector3);
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS3' */
         S132 ();
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
         Ddo_pedidoid_Titlecontrolidtoreplace = subGrid_Internalname+"_PedidoId";
         ucDdo_pedidoid.SendProperty(context, "", false, Ddo_pedidoid_Internalname, "TitleControlIdToReplace", Ddo_pedidoid_Titlecontrolidtoreplace);
         AV31ddo_PedidoIdTitleControlIdToReplace = Ddo_pedidoid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_PedidoIdTitleControlIdToReplace", AV31ddo_PedidoIdTitleControlIdToReplace);
         edtavDdo_pedidoidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_pedidoidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_pedidoidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_pedidodt_Titlecontrolidtoreplace = subGrid_Internalname+"_PedidoDt";
         ucDdo_pedidodt.SendProperty(context, "", false, Ddo_pedidodt_Internalname, "TitleControlIdToReplace", Ddo_pedidodt_Titlecontrolidtoreplace);
         AV33ddo_PedidoDtTitleControlIdToReplace = Ddo_pedidodt_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33ddo_PedidoDtTitleControlIdToReplace", AV33ddo_PedidoDtTitleControlIdToReplace);
         edtavDdo_pedidodttitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_pedidodttitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_pedidodttitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_pedidostatus_Titlecontrolidtoreplace = subGrid_Internalname+"_PedidoStatus";
         ucDdo_pedidostatus.SendProperty(context, "", false, Ddo_pedidostatus_Internalname, "TitleControlIdToReplace", Ddo_pedidostatus_Titlecontrolidtoreplace);
         AV35ddo_PedidoStatusTitleControlIdToReplace = Ddo_pedidostatus_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ddo_PedidoStatusTitleControlIdToReplace", AV35ddo_PedidoStatusTitleControlIdToReplace);
         edtavDdo_pedidostatustitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_pedidostatustitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_pedidostatustitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_pedidodtentrega_Titlecontrolidtoreplace = subGrid_Internalname+"_PedidoDtEntrega";
         ucDdo_pedidodtentrega.SendProperty(context, "", false, Ddo_pedidodtentrega_Internalname, "TitleControlIdToReplace", Ddo_pedidodtentrega_Titlecontrolidtoreplace);
         AV37ddo_PedidoDtEntregaTitleControlIdToReplace = Ddo_pedidodtentrega_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37ddo_PedidoDtEntregaTitleControlIdToReplace", AV37ddo_PedidoDtEntregaTitleControlIdToReplace);
         edtavDdo_pedidodtentregatitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_pedidodtentregatitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_pedidodtentregatitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_pedidoretirada_Titlecontrolidtoreplace = subGrid_Internalname+"_PedidoRetirada";
         ucDdo_pedidoretirada.SendProperty(context, "", false, Ddo_pedidoretirada_Internalname, "TitleControlIdToReplace", Ddo_pedidoretirada_Titlecontrolidtoreplace);
         AV39ddo_PedidoRetiradaTitleControlIdToReplace = Ddo_pedidoretirada_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39ddo_PedidoRetiradaTitleControlIdToReplace", AV39ddo_PedidoRetiradaTitleControlIdToReplace);
         edtavDdo_pedidoretiradatitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_pedidoretiradatitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_pedidoretiradatitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_pedidototal_Titlecontrolidtoreplace = subGrid_Internalname+"_PedidoTotal";
         ucDdo_pedidototal.SendProperty(context, "", false, Ddo_pedidototal_Internalname, "TitleControlIdToReplace", Ddo_pedidototal_Titlecontrolidtoreplace);
         AV48ddo_PedidoTotalTitleControlIdToReplace = Ddo_pedidototal_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV48ddo_PedidoTotalTitleControlIdToReplace", AV48ddo_PedidoTotalTitleControlIdToReplace);
         edtavDdo_pedidototaltitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_pedidototaltitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_pedidototaltitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = "Consulta de Pedido";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         /* Execute user subroutine: 'LOADDYNFILTERSSTATE' */
         S142 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         edtavOrderedby_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOrderedby_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrderedby_Visible), 5, 0)), true);
         if ( AV11OrderedBy < 1 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            /* Execute user subroutine: 'SETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
         edtavOrdereddsc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOrdereddsc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrdereddsc_Visible), 5, 0)), true);
         imgCleanfilters_Jsonclick = StringUtil.Format( "WWPDynFilterHideAll_AL('%1', 3, 0)", tblTabledynamicfilters_Internalname, "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgCleanfilters_Internalname, "Jsonclick", imgCleanfilters_Jsonclick, true);
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV40DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV40DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E32142( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV30PedidoIdTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV32PedidoDtTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV34PedidoStatusTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV36PedidoDtEntregaTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV38PedidoRetiradaTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV47PedidoTotalTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         edtPedidoId_Titleformat = 2;
         edtPedidoId_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Número do Pedido", AV31ddo_PedidoIdTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedidoId_Internalname, "Title", edtPedidoId_Title, !bGXsfl_119_Refreshing);
         edtPedidoDt_Titleformat = 2;
         edtPedidoDt_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Data do Pedido", AV33ddo_PedidoDtTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedidoDt_Internalname, "Title", edtPedidoDt_Title, !bGXsfl_119_Refreshing);
         cmbPedidoStatus_Titleformat = 2;
         cmbPedidoStatus.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Status", AV35ddo_PedidoStatusTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPedidoStatus_Internalname, "Title", cmbPedidoStatus.Title.Text, !bGXsfl_119_Refreshing);
         edtPedidoDtEntrega_Titleformat = 2;
         edtPedidoDtEntrega_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Data de Entrega", AV37ddo_PedidoDtEntregaTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedidoDtEntrega_Internalname, "Title", edtPedidoDtEntrega_Title, !bGXsfl_119_Refreshing);
         chkPedidoRetirada_Titleformat = 2;
         chkPedidoRetirada.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Retirar no Local?", AV39ddo_PedidoRetiradaTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkPedidoRetirada_Internalname, "Title", chkPedidoRetirada.Title.Text, !bGXsfl_119_Refreshing);
         edtPedidoTotal_Titleformat = 2;
         edtPedidoTotal_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Total", AV48ddo_PedidoTotalTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedidoTotal_Internalname, "Title", edtPedidoTotal_Title, !bGXsfl_119_Refreshing);
         AV42GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV42GridCurrentPage), 10, 0)));
         AV43GridPageCount = subGrid_Pagecount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43GridPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV43GridPageCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30PedidoIdTitleFilterData", AV30PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32PedidoDtTitleFilterData", AV32PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34PedidoStatusTitleFilterData", AV34PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36PedidoDtEntregaTitleFilterData", AV36PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38PedidoRetiradaTitleFilterData", AV38PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47PedidoTotalTitleFilterData", AV47PedidoTotalTitleFilterData);
      }

      protected void E11142( )
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
            AV41PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV41PageToGo) ;
         }
      }

      protected void E12142( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E13142( )
      {
         /* Ddo_pedidoid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_pedidoid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV11OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_pedidoid_Sortedstatus = "ASC";
            ucDdo_pedidoid.SendProperty(context, "", false, Ddo_pedidoid_Internalname, "SortedStatus", Ddo_pedidoid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pedidoid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV11OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_pedidoid_Sortedstatus = "DSC";
            ucDdo_pedidoid.SendProperty(context, "", false, Ddo_pedidoid_Internalname, "SortedStatus", Ddo_pedidoid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30PedidoIdTitleFilterData", AV30PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32PedidoDtTitleFilterData", AV32PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34PedidoStatusTitleFilterData", AV34PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36PedidoDtEntregaTitleFilterData", AV36PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38PedidoRetiradaTitleFilterData", AV38PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47PedidoTotalTitleFilterData", AV47PedidoTotalTitleFilterData);
      }

      protected void E14142( )
      {
         /* Ddo_pedidodt_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_pedidodt_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_pedidodt_Sortedstatus = "ASC";
            ucDdo_pedidodt.SendProperty(context, "", false, Ddo_pedidodt_Internalname, "SortedStatus", Ddo_pedidodt_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pedidodt_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_pedidodt_Sortedstatus = "DSC";
            ucDdo_pedidodt.SendProperty(context, "", false, Ddo_pedidodt_Internalname, "SortedStatus", Ddo_pedidodt_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30PedidoIdTitleFilterData", AV30PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32PedidoDtTitleFilterData", AV32PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34PedidoStatusTitleFilterData", AV34PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36PedidoDtEntregaTitleFilterData", AV36PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38PedidoRetiradaTitleFilterData", AV38PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47PedidoTotalTitleFilterData", AV47PedidoTotalTitleFilterData);
      }

      protected void E15142( )
      {
         /* Ddo_pedidostatus_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_pedidostatus_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_pedidostatus_Sortedstatus = "ASC";
            ucDdo_pedidostatus.SendProperty(context, "", false, Ddo_pedidostatus_Internalname, "SortedStatus", Ddo_pedidostatus_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pedidostatus_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_pedidostatus_Sortedstatus = "DSC";
            ucDdo_pedidostatus.SendProperty(context, "", false, Ddo_pedidostatus_Internalname, "SortedStatus", Ddo_pedidostatus_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30PedidoIdTitleFilterData", AV30PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32PedidoDtTitleFilterData", AV32PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34PedidoStatusTitleFilterData", AV34PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36PedidoDtEntregaTitleFilterData", AV36PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38PedidoRetiradaTitleFilterData", AV38PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47PedidoTotalTitleFilterData", AV47PedidoTotalTitleFilterData);
      }

      protected void E16142( )
      {
         /* Ddo_pedidodtentrega_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_pedidodtentrega_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV11OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_pedidodtentrega_Sortedstatus = "ASC";
            ucDdo_pedidodtentrega.SendProperty(context, "", false, Ddo_pedidodtentrega_Internalname, "SortedStatus", Ddo_pedidodtentrega_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pedidodtentrega_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV11OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_pedidodtentrega_Sortedstatus = "DSC";
            ucDdo_pedidodtentrega.SendProperty(context, "", false, Ddo_pedidodtentrega_Internalname, "SortedStatus", Ddo_pedidodtentrega_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30PedidoIdTitleFilterData", AV30PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32PedidoDtTitleFilterData", AV32PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34PedidoStatusTitleFilterData", AV34PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36PedidoDtEntregaTitleFilterData", AV36PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38PedidoRetiradaTitleFilterData", AV38PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47PedidoTotalTitleFilterData", AV47PedidoTotalTitleFilterData);
      }

      protected void E17142( )
      {
         /* Ddo_pedidoretirada_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_pedidoretirada_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV11OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_pedidoretirada_Sortedstatus = "ASC";
            ucDdo_pedidoretirada.SendProperty(context, "", false, Ddo_pedidoretirada_Internalname, "SortedStatus", Ddo_pedidoretirada_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pedidoretirada_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV11OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_pedidoretirada_Sortedstatus = "DSC";
            ucDdo_pedidoretirada.SendProperty(context, "", false, Ddo_pedidoretirada_Internalname, "SortedStatus", Ddo_pedidoretirada_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30PedidoIdTitleFilterData", AV30PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32PedidoDtTitleFilterData", AV32PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34PedidoStatusTitleFilterData", AV34PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36PedidoDtEntregaTitleFilterData", AV36PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38PedidoRetiradaTitleFilterData", AV38PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47PedidoTotalTitleFilterData", AV47PedidoTotalTitleFilterData);
      }

      protected void E18142( )
      {
         /* Ddo_pedidototal_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_pedidototal_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV11OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_pedidototal_Sortedstatus = "ASC";
            ucDdo_pedidototal.SendProperty(context, "", false, Ddo_pedidototal_Internalname, "SortedStatus", Ddo_pedidototal_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pedidototal_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV11OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_pedidototal_Sortedstatus = "DSC";
            ucDdo_pedidototal.SendProperty(context, "", false, Ddo_pedidototal_Internalname, "SortedStatus", Ddo_pedidototal_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30PedidoIdTitleFilterData", AV30PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32PedidoDtTitleFilterData", AV32PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34PedidoStatusTitleFilterData", AV34PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36PedidoDtEntregaTitleFilterData", AV36PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38PedidoRetiradaTitleFilterData", AV38PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47PedidoTotalTitleFilterData", AV47PedidoTotalTitleFilterData);
      }

      private void E33142( )
      {
         /* Grid_Load Routine */
         AV44Select = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavSelect_Internalname, AV44Select);
         AV51Select_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         edtavSelect_Tooltiptext = "Selecionar";
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 119;
         }
         sendrow_1192( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_119_Refreshing )
         {
            context.DoAjaxLoad(119, GridRow);
         }
         /*  Sending Event outputs  */
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E34142 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E34142( )
      {
         /* Enter Routine */
         AV45InOutPedidoId = A32PedidoId;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45InOutPedidoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV45InOutPedidoId), 4, 0)));
         AV46InOutPedidoDt = A33PedidoDt;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46InOutPedidoDt", context.localUtil.Format(AV46InOutPedidoDt, "99/99/99"));
         context.setWebReturnParms(new Object[] {(short)AV45InOutPedidoId,context.localUtil.Format( AV46InOutPedidoDt, "99/99/99")});
         context.setWebReturnParmsMetadata(new Object[] {"AV45InOutPedidoId","AV46InOutPedidoDt"});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
         /*  Sending Event outputs  */
      }

      protected void E23142( )
      {
         /* 'AddDynamicFilters1' Routine */
         AV17DynamicFiltersEnabled2 = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17DynamicFiltersEnabled2", AV17DynamicFiltersEnabled2);
         imgAdddynamicfilters1_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgAdddynamicfilters1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgAdddynamicfilters1_Visible), 5, 0)), true);
         imgRemovedynamicfilters1_Visible = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgRemovedynamicfilters1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgRemovedynamicfilters1_Visible), 5, 0)), true);
         /*  Sending Event outputs  */
      }

      protected void E19142( )
      {
         /* 'RemoveDynamicFilters1' Routine */
         AV27DynamicFiltersRemoving = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27DynamicFiltersRemoving", AV27DynamicFiltersRemoving);
         AV28DynamicFiltersIgnoreFirst = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28DynamicFiltersIgnoreFirst", AV28DynamicFiltersIgnoreFirst);
         /* Execute user subroutine: 'SAVEDYNFILTERSSTATE' */
         S172 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'RESETDYNFILTERS' */
         S182 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'LOADDYNFILTERSSTATE' */
         S142 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV27DynamicFiltersRemoving = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27DynamicFiltersRemoving", AV27DynamicFiltersRemoving);
         AV28DynamicFiltersIgnoreFirst = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28DynamicFiltersIgnoreFirst", AV28DynamicFiltersIgnoreFirst);
         gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15PedidoDt1, AV16PedidoDt_To1, AV18DynamicFiltersSelector2, AV19DynamicFiltersOperator2, AV20PedidoDt2, AV21PedidoDt_To2, AV23DynamicFiltersSelector3, AV24DynamicFiltersOperator3, AV25PedidoDt3, AV26PedidoDt_To3, AV17DynamicFiltersEnabled2, AV22DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV31ddo_PedidoIdTitleControlIdToReplace, AV33ddo_PedidoDtTitleControlIdToReplace, AV35ddo_PedidoStatusTitleControlIdToReplace, AV37ddo_PedidoDtEntregaTitleControlIdToReplace, AV39ddo_PedidoRetiradaTitleControlIdToReplace, AV48ddo_PedidoTotalTitleControlIdToReplace) ;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV8GridState", AV8GridState);
         cmbavDynamicfiltersselector2.CurrentValue = StringUtil.RTrim( AV18DynamicFiltersSelector2);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector2_Internalname, "Values", cmbavDynamicfiltersselector2.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", cmbavDynamicfiltersoperator2.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector3.CurrentValue = StringUtil.RTrim( AV23DynamicFiltersSelector3);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector3_Internalname, "Values", cmbavDynamicfiltersselector3.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", cmbavDynamicfiltersoperator3.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector1.CurrentValue = StringUtil.RTrim( AV13DynamicFiltersSelector1);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector1_Internalname, "Values", cmbavDynamicfiltersselector1.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", cmbavDynamicfiltersoperator1.ToJavascriptSource(), true);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30PedidoIdTitleFilterData", AV30PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32PedidoDtTitleFilterData", AV32PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34PedidoStatusTitleFilterData", AV34PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36PedidoDtEntregaTitleFilterData", AV36PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38PedidoRetiradaTitleFilterData", AV38PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47PedidoTotalTitleFilterData", AV47PedidoTotalTitleFilterData);
      }

      protected void E24142( )
      {
         /* Dynamicfiltersselector1_Click Routine */
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS1' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /*  Sending Event outputs  */
      }

      protected void E25142( )
      {
         /* Dynamicfiltersoperator1_Click Routine */
         if ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PEDIDODT") == 0 )
         {
            AV15PedidoDt1 = DateTime.MinValue;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15PedidoDt1", context.localUtil.Format(AV15PedidoDt1, "99/99/99"));
            AV16PedidoDt_To1 = DateTime.MinValue;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16PedidoDt_To1", context.localUtil.Format(AV16PedidoDt_To1, "99/99/99"));
            /* Execute user subroutine: 'UPDATEPEDIDODT1OPERATORVALUES' */
            S192 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15PedidoDt1, AV16PedidoDt_To1, AV18DynamicFiltersSelector2, AV19DynamicFiltersOperator2, AV20PedidoDt2, AV21PedidoDt_To2, AV23DynamicFiltersSelector3, AV24DynamicFiltersOperator3, AV25PedidoDt3, AV26PedidoDt_To3, AV17DynamicFiltersEnabled2, AV22DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV31ddo_PedidoIdTitleControlIdToReplace, AV33ddo_PedidoDtTitleControlIdToReplace, AV35ddo_PedidoStatusTitleControlIdToReplace, AV37ddo_PedidoDtEntregaTitleControlIdToReplace, AV39ddo_PedidoRetiradaTitleControlIdToReplace, AV48ddo_PedidoTotalTitleControlIdToReplace) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30PedidoIdTitleFilterData", AV30PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32PedidoDtTitleFilterData", AV32PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34PedidoStatusTitleFilterData", AV34PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36PedidoDtEntregaTitleFilterData", AV36PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38PedidoRetiradaTitleFilterData", AV38PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47PedidoTotalTitleFilterData", AV47PedidoTotalTitleFilterData);
      }

      protected void E26142( )
      {
         /* 'AddDynamicFilters2' Routine */
         AV22DynamicFiltersEnabled3 = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22DynamicFiltersEnabled3", AV22DynamicFiltersEnabled3);
         imgAdddynamicfilters2_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgAdddynamicfilters2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgAdddynamicfilters2_Visible), 5, 0)), true);
         imgRemovedynamicfilters2_Visible = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgRemovedynamicfilters2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgRemovedynamicfilters2_Visible), 5, 0)), true);
         /*  Sending Event outputs  */
      }

      protected void E20142( )
      {
         /* 'RemoveDynamicFilters2' Routine */
         AV27DynamicFiltersRemoving = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27DynamicFiltersRemoving", AV27DynamicFiltersRemoving);
         AV17DynamicFiltersEnabled2 = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17DynamicFiltersEnabled2", AV17DynamicFiltersEnabled2);
         /* Execute user subroutine: 'SAVEDYNFILTERSSTATE' */
         S172 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'RESETDYNFILTERS' */
         S182 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'LOADDYNFILTERSSTATE' */
         S142 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV27DynamicFiltersRemoving = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27DynamicFiltersRemoving", AV27DynamicFiltersRemoving);
         gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15PedidoDt1, AV16PedidoDt_To1, AV18DynamicFiltersSelector2, AV19DynamicFiltersOperator2, AV20PedidoDt2, AV21PedidoDt_To2, AV23DynamicFiltersSelector3, AV24DynamicFiltersOperator3, AV25PedidoDt3, AV26PedidoDt_To3, AV17DynamicFiltersEnabled2, AV22DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV31ddo_PedidoIdTitleControlIdToReplace, AV33ddo_PedidoDtTitleControlIdToReplace, AV35ddo_PedidoStatusTitleControlIdToReplace, AV37ddo_PedidoDtEntregaTitleControlIdToReplace, AV39ddo_PedidoRetiradaTitleControlIdToReplace, AV48ddo_PedidoTotalTitleControlIdToReplace) ;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV8GridState", AV8GridState);
         cmbavDynamicfiltersselector2.CurrentValue = StringUtil.RTrim( AV18DynamicFiltersSelector2);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector2_Internalname, "Values", cmbavDynamicfiltersselector2.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", cmbavDynamicfiltersoperator2.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector3.CurrentValue = StringUtil.RTrim( AV23DynamicFiltersSelector3);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector3_Internalname, "Values", cmbavDynamicfiltersselector3.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", cmbavDynamicfiltersoperator3.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector1.CurrentValue = StringUtil.RTrim( AV13DynamicFiltersSelector1);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector1_Internalname, "Values", cmbavDynamicfiltersselector1.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", cmbavDynamicfiltersoperator1.ToJavascriptSource(), true);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30PedidoIdTitleFilterData", AV30PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32PedidoDtTitleFilterData", AV32PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34PedidoStatusTitleFilterData", AV34PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36PedidoDtEntregaTitleFilterData", AV36PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38PedidoRetiradaTitleFilterData", AV38PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47PedidoTotalTitleFilterData", AV47PedidoTotalTitleFilterData);
      }

      protected void E27142( )
      {
         /* Dynamicfiltersselector2_Click Routine */
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS2' */
         S122 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /*  Sending Event outputs  */
      }

      protected void E28142( )
      {
         /* Dynamicfiltersoperator2_Click Routine */
         if ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PEDIDODT") == 0 )
         {
            AV20PedidoDt2 = DateTime.MinValue;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20PedidoDt2", context.localUtil.Format(AV20PedidoDt2, "99/99/99"));
            AV21PedidoDt_To2 = DateTime.MinValue;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21PedidoDt_To2", context.localUtil.Format(AV21PedidoDt_To2, "99/99/99"));
            /* Execute user subroutine: 'UPDATEPEDIDODT2OPERATORVALUES' */
            S202 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15PedidoDt1, AV16PedidoDt_To1, AV18DynamicFiltersSelector2, AV19DynamicFiltersOperator2, AV20PedidoDt2, AV21PedidoDt_To2, AV23DynamicFiltersSelector3, AV24DynamicFiltersOperator3, AV25PedidoDt3, AV26PedidoDt_To3, AV17DynamicFiltersEnabled2, AV22DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV31ddo_PedidoIdTitleControlIdToReplace, AV33ddo_PedidoDtTitleControlIdToReplace, AV35ddo_PedidoStatusTitleControlIdToReplace, AV37ddo_PedidoDtEntregaTitleControlIdToReplace, AV39ddo_PedidoRetiradaTitleControlIdToReplace, AV48ddo_PedidoTotalTitleControlIdToReplace) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30PedidoIdTitleFilterData", AV30PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32PedidoDtTitleFilterData", AV32PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34PedidoStatusTitleFilterData", AV34PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36PedidoDtEntregaTitleFilterData", AV36PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38PedidoRetiradaTitleFilterData", AV38PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47PedidoTotalTitleFilterData", AV47PedidoTotalTitleFilterData);
      }

      protected void E21142( )
      {
         /* 'RemoveDynamicFilters3' Routine */
         AV27DynamicFiltersRemoving = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27DynamicFiltersRemoving", AV27DynamicFiltersRemoving);
         AV22DynamicFiltersEnabled3 = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22DynamicFiltersEnabled3", AV22DynamicFiltersEnabled3);
         /* Execute user subroutine: 'SAVEDYNFILTERSSTATE' */
         S172 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'RESETDYNFILTERS' */
         S182 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'LOADDYNFILTERSSTATE' */
         S142 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV27DynamicFiltersRemoving = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27DynamicFiltersRemoving", AV27DynamicFiltersRemoving);
         gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15PedidoDt1, AV16PedidoDt_To1, AV18DynamicFiltersSelector2, AV19DynamicFiltersOperator2, AV20PedidoDt2, AV21PedidoDt_To2, AV23DynamicFiltersSelector3, AV24DynamicFiltersOperator3, AV25PedidoDt3, AV26PedidoDt_To3, AV17DynamicFiltersEnabled2, AV22DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV31ddo_PedidoIdTitleControlIdToReplace, AV33ddo_PedidoDtTitleControlIdToReplace, AV35ddo_PedidoStatusTitleControlIdToReplace, AV37ddo_PedidoDtEntregaTitleControlIdToReplace, AV39ddo_PedidoRetiradaTitleControlIdToReplace, AV48ddo_PedidoTotalTitleControlIdToReplace) ;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV8GridState", AV8GridState);
         cmbavDynamicfiltersselector2.CurrentValue = StringUtil.RTrim( AV18DynamicFiltersSelector2);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector2_Internalname, "Values", cmbavDynamicfiltersselector2.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", cmbavDynamicfiltersoperator2.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector3.CurrentValue = StringUtil.RTrim( AV23DynamicFiltersSelector3);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector3_Internalname, "Values", cmbavDynamicfiltersselector3.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", cmbavDynamicfiltersoperator3.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector1.CurrentValue = StringUtil.RTrim( AV13DynamicFiltersSelector1);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector1_Internalname, "Values", cmbavDynamicfiltersselector1.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", cmbavDynamicfiltersoperator1.ToJavascriptSource(), true);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30PedidoIdTitleFilterData", AV30PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32PedidoDtTitleFilterData", AV32PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34PedidoStatusTitleFilterData", AV34PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36PedidoDtEntregaTitleFilterData", AV36PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38PedidoRetiradaTitleFilterData", AV38PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47PedidoTotalTitleFilterData", AV47PedidoTotalTitleFilterData);
      }

      protected void E29142( )
      {
         /* Dynamicfiltersselector3_Click Routine */
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS3' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /*  Sending Event outputs  */
      }

      protected void E30142( )
      {
         /* Dynamicfiltersoperator3_Click Routine */
         if ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PEDIDODT") == 0 )
         {
            AV25PedidoDt3 = DateTime.MinValue;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25PedidoDt3", context.localUtil.Format(AV25PedidoDt3, "99/99/99"));
            AV26PedidoDt_To3 = DateTime.MinValue;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26PedidoDt_To3", context.localUtil.Format(AV26PedidoDt_To3, "99/99/99"));
            /* Execute user subroutine: 'UPDATEPEDIDODT3OPERATORVALUES' */
            S212 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15PedidoDt1, AV16PedidoDt_To1, AV18DynamicFiltersSelector2, AV19DynamicFiltersOperator2, AV20PedidoDt2, AV21PedidoDt_To2, AV23DynamicFiltersSelector3, AV24DynamicFiltersOperator3, AV25PedidoDt3, AV26PedidoDt_To3, AV17DynamicFiltersEnabled2, AV22DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV31ddo_PedidoIdTitleControlIdToReplace, AV33ddo_PedidoDtTitleControlIdToReplace, AV35ddo_PedidoStatusTitleControlIdToReplace, AV37ddo_PedidoDtEntregaTitleControlIdToReplace, AV39ddo_PedidoRetiradaTitleControlIdToReplace, AV48ddo_PedidoTotalTitleControlIdToReplace) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30PedidoIdTitleFilterData", AV30PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32PedidoDtTitleFilterData", AV32PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34PedidoStatusTitleFilterData", AV34PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36PedidoDtEntregaTitleFilterData", AV36PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38PedidoRetiradaTitleFilterData", AV38PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47PedidoTotalTitleFilterData", AV47PedidoTotalTitleFilterData);
      }

      protected void E22142( )
      {
         /* 'DoCleanFilters' Routine */
         /* Execute user subroutine: 'CLEANFILTERS' */
         S222 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         subgrid_firstpage( ) ;
         context.DoAjaxRefresh();
         /*  Sending Event outputs  */
         cmbavDynamicfiltersselector1.CurrentValue = StringUtil.RTrim( AV13DynamicFiltersSelector1);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector1_Internalname, "Values", cmbavDynamicfiltersselector1.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", cmbavDynamicfiltersoperator1.ToJavascriptSource(), true);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV8GridState", AV8GridState);
         cmbavDynamicfiltersselector2.CurrentValue = StringUtil.RTrim( AV18DynamicFiltersSelector2);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector2_Internalname, "Values", cmbavDynamicfiltersselector2.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", cmbavDynamicfiltersoperator2.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector3.CurrentValue = StringUtil.RTrim( AV23DynamicFiltersSelector3);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector3_Internalname, "Values", cmbavDynamicfiltersselector3.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", cmbavDynamicfiltersoperator3.ToJavascriptSource(), true);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30PedidoIdTitleFilterData", AV30PedidoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32PedidoDtTitleFilterData", AV32PedidoDtTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34PedidoStatusTitleFilterData", AV34PedidoStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36PedidoDtEntregaTitleFilterData", AV36PedidoDtEntregaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38PedidoRetiradaTitleFilterData", AV38PedidoRetiradaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47PedidoTotalTitleFilterData", AV47PedidoTotalTitleFilterData);
      }

      protected void S162( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_pedidoid_Sortedstatus = "";
         ucDdo_pedidoid.SendProperty(context, "", false, Ddo_pedidoid_Internalname, "SortedStatus", Ddo_pedidoid_Sortedstatus);
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

      protected void S152( )
      {
         /* 'SETDDOSORTEDSTATUS' Routine */
         /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
         S162 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         if ( AV11OrderedBy == 2 )
         {
            Ddo_pedidoid_Sortedstatus = (AV12OrderedDsc ? "DSC" : "ASC");
            ucDdo_pedidoid.SendProperty(context, "", false, Ddo_pedidoid_Internalname, "SortedStatus", Ddo_pedidoid_Sortedstatus);
         }
         else if ( AV11OrderedBy == 1 )
         {
            Ddo_pedidodt_Sortedstatus = (AV12OrderedDsc ? "DSC" : "ASC");
            ucDdo_pedidodt.SendProperty(context, "", false, Ddo_pedidodt_Internalname, "SortedStatus", Ddo_pedidodt_Sortedstatus);
         }
         else if ( AV11OrderedBy == 3 )
         {
            Ddo_pedidostatus_Sortedstatus = (AV12OrderedDsc ? "DSC" : "ASC");
            ucDdo_pedidostatus.SendProperty(context, "", false, Ddo_pedidostatus_Internalname, "SortedStatus", Ddo_pedidostatus_Sortedstatus);
         }
         else if ( AV11OrderedBy == 4 )
         {
            Ddo_pedidodtentrega_Sortedstatus = (AV12OrderedDsc ? "DSC" : "ASC");
            ucDdo_pedidodtentrega.SendProperty(context, "", false, Ddo_pedidodtentrega_Internalname, "SortedStatus", Ddo_pedidodtentrega_Sortedstatus);
         }
         else if ( AV11OrderedBy == 5 )
         {
            Ddo_pedidoretirada_Sortedstatus = (AV12OrderedDsc ? "DSC" : "ASC");
            ucDdo_pedidoretirada.SendProperty(context, "", false, Ddo_pedidoretirada_Internalname, "SortedStatus", Ddo_pedidoretirada_Sortedstatus);
         }
         else if ( AV11OrderedBy == 6 )
         {
            Ddo_pedidototal_Sortedstatus = (AV12OrderedDsc ? "DSC" : "ASC");
            ucDdo_pedidototal.SendProperty(context, "", false, Ddo_pedidototal_Internalname, "SortedStatus", Ddo_pedidototal_Sortedstatus);
         }
      }

      protected void S112( )
      {
         /* 'ENABLEDYNAMICFILTERS1' Routine */
         tblTablemergeddynamicfilterspedidodt1_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, tblTablemergeddynamicfilterspedidodt1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTablemergeddynamicfilterspedidodt1_Visible), 5, 0)), true);
         cmbavDynamicfiltersoperator1.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavDynamicfiltersoperator1.Visible), 5, 0)), true);
         if ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PEDIDODT") == 0 )
         {
            tblTablemergeddynamicfilterspedidodt1_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, tblTablemergeddynamicfilterspedidodt1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTablemergeddynamicfilterspedidodt1_Visible), 5, 0)), true);
            cmbavDynamicfiltersoperator1.Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavDynamicfiltersoperator1.Visible), 5, 0)), true);
            /* Execute user subroutine: 'UPDATEPEDIDODT1OPERATORVALUES' */
            S192 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
      }

      protected void S192( )
      {
         /* 'UPDATEPEDIDODT1OPERATORVALUES' Routine */
         cellPedidodt_cell1_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellPedidodt_cell1_Internalname, "Class", cellPedidodt_cell1_Class, true);
         cellPedidodt_to_cell1_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellPedidodt_to_cell1_Internalname, "Class", cellPedidodt_to_cell1_Class, true);
         lblPedidodt_rangemiddletext_11_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblPedidodt_rangemiddletext_11_Internalname, "Class", lblPedidodt_rangemiddletext_11_Class, true);
         if ( AV14DynamicFiltersOperator1 == 0 )
         {
            AV15PedidoDt1 = Gx_date;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15PedidoDt1", context.localUtil.Format(AV15PedidoDt1, "99/99/99"));
         }
         else if ( AV14DynamicFiltersOperator1 == 1 )
         {
            AV15PedidoDt1 = Gx_date;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15PedidoDt1", context.localUtil.Format(AV15PedidoDt1, "99/99/99"));
         }
         else if ( AV14DynamicFiltersOperator1 == 2 )
         {
            AV15PedidoDt1 = Gx_date;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15PedidoDt1", context.localUtil.Format(AV15PedidoDt1, "99/99/99"));
         }
         else if ( AV14DynamicFiltersOperator1 == 3 )
         {
            cellPedidodt_cell1_Class = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellPedidodt_cell1_Internalname, "Class", cellPedidodt_cell1_Class, true);
            cellPedidodt_to_cell1_Class = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellPedidodt_to_cell1_Internalname, "Class", cellPedidodt_to_cell1_Class, true);
            lblPedidodt_rangemiddletext_11_Class = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblPedidodt_rangemiddletext_11_Internalname, "Class", lblPedidodt_rangemiddletext_11_Class, true);
         }
      }

      protected void S122( )
      {
         /* 'ENABLEDYNAMICFILTERS2' Routine */
         tblTablemergeddynamicfilterspedidodt2_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, tblTablemergeddynamicfilterspedidodt2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTablemergeddynamicfilterspedidodt2_Visible), 5, 0)), true);
         cmbavDynamicfiltersoperator2.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavDynamicfiltersoperator2.Visible), 5, 0)), true);
         if ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PEDIDODT") == 0 )
         {
            tblTablemergeddynamicfilterspedidodt2_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, tblTablemergeddynamicfilterspedidodt2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTablemergeddynamicfilterspedidodt2_Visible), 5, 0)), true);
            cmbavDynamicfiltersoperator2.Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavDynamicfiltersoperator2.Visible), 5, 0)), true);
            /* Execute user subroutine: 'UPDATEPEDIDODT2OPERATORVALUES' */
            S202 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
      }

      protected void S202( )
      {
         /* 'UPDATEPEDIDODT2OPERATORVALUES' Routine */
         cellPedidodt_cell2_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellPedidodt_cell2_Internalname, "Class", cellPedidodt_cell2_Class, true);
         cellPedidodt_to_cell2_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellPedidodt_to_cell2_Internalname, "Class", cellPedidodt_to_cell2_Class, true);
         lblPedidodt_rangemiddletext_12_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblPedidodt_rangemiddletext_12_Internalname, "Class", lblPedidodt_rangemiddletext_12_Class, true);
         if ( AV19DynamicFiltersOperator2 == 0 )
         {
            AV20PedidoDt2 = Gx_date;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20PedidoDt2", context.localUtil.Format(AV20PedidoDt2, "99/99/99"));
         }
         else if ( AV19DynamicFiltersOperator2 == 1 )
         {
            AV20PedidoDt2 = Gx_date;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20PedidoDt2", context.localUtil.Format(AV20PedidoDt2, "99/99/99"));
         }
         else if ( AV19DynamicFiltersOperator2 == 2 )
         {
            AV20PedidoDt2 = Gx_date;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20PedidoDt2", context.localUtil.Format(AV20PedidoDt2, "99/99/99"));
         }
         else if ( AV19DynamicFiltersOperator2 == 3 )
         {
            cellPedidodt_cell2_Class = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellPedidodt_cell2_Internalname, "Class", cellPedidodt_cell2_Class, true);
            cellPedidodt_to_cell2_Class = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellPedidodt_to_cell2_Internalname, "Class", cellPedidodt_to_cell2_Class, true);
            lblPedidodt_rangemiddletext_12_Class = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblPedidodt_rangemiddletext_12_Internalname, "Class", lblPedidodt_rangemiddletext_12_Class, true);
         }
      }

      protected void S132( )
      {
         /* 'ENABLEDYNAMICFILTERS3' Routine */
         tblTablemergeddynamicfilterspedidodt3_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, tblTablemergeddynamicfilterspedidodt3_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTablemergeddynamicfilterspedidodt3_Visible), 5, 0)), true);
         cmbavDynamicfiltersoperator3.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavDynamicfiltersoperator3.Visible), 5, 0)), true);
         if ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PEDIDODT") == 0 )
         {
            tblTablemergeddynamicfilterspedidodt3_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, tblTablemergeddynamicfilterspedidodt3_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTablemergeddynamicfilterspedidodt3_Visible), 5, 0)), true);
            cmbavDynamicfiltersoperator3.Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavDynamicfiltersoperator3.Visible), 5, 0)), true);
            /* Execute user subroutine: 'UPDATEPEDIDODT3OPERATORVALUES' */
            S212 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
      }

      protected void S212( )
      {
         /* 'UPDATEPEDIDODT3OPERATORVALUES' Routine */
         cellPedidodt_cell3_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellPedidodt_cell3_Internalname, "Class", cellPedidodt_cell3_Class, true);
         cellPedidodt_to_cell3_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellPedidodt_to_cell3_Internalname, "Class", cellPedidodt_to_cell3_Class, true);
         lblPedidodt_rangemiddletext_13_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblPedidodt_rangemiddletext_13_Internalname, "Class", lblPedidodt_rangemiddletext_13_Class, true);
         if ( AV24DynamicFiltersOperator3 == 0 )
         {
            AV25PedidoDt3 = Gx_date;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25PedidoDt3", context.localUtil.Format(AV25PedidoDt3, "99/99/99"));
         }
         else if ( AV24DynamicFiltersOperator3 == 1 )
         {
            AV25PedidoDt3 = Gx_date;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25PedidoDt3", context.localUtil.Format(AV25PedidoDt3, "99/99/99"));
         }
         else if ( AV24DynamicFiltersOperator3 == 2 )
         {
            AV25PedidoDt3 = Gx_date;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25PedidoDt3", context.localUtil.Format(AV25PedidoDt3, "99/99/99"));
         }
         else if ( AV24DynamicFiltersOperator3 == 3 )
         {
            cellPedidodt_cell3_Class = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellPedidodt_cell3_Internalname, "Class", cellPedidodt_cell3_Class, true);
            cellPedidodt_to_cell3_Class = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellPedidodt_to_cell3_Internalname, "Class", cellPedidodt_to_cell3_Class, true);
            lblPedidodt_rangemiddletext_13_Class = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblPedidodt_rangemiddletext_13_Internalname, "Class", lblPedidodt_rangemiddletext_13_Class, true);
         }
      }

      protected void S182( )
      {
         /* 'RESETDYNFILTERS' Routine */
         AV17DynamicFiltersEnabled2 = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17DynamicFiltersEnabled2", AV17DynamicFiltersEnabled2);
         AV18DynamicFiltersSelector2 = "PEDIDODT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18DynamicFiltersSelector2", AV18DynamicFiltersSelector2);
         AV19DynamicFiltersOperator2 = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19DynamicFiltersOperator2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0)));
         AV20PedidoDt2 = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20PedidoDt2", context.localUtil.Format(AV20PedidoDt2, "99/99/99"));
         AV21PedidoDt_To2 = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21PedidoDt_To2", context.localUtil.Format(AV21PedidoDt_To2, "99/99/99"));
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS2' */
         S122 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV22DynamicFiltersEnabled3 = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22DynamicFiltersEnabled3", AV22DynamicFiltersEnabled3);
         AV23DynamicFiltersSelector3 = "PEDIDODT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23DynamicFiltersSelector3", AV23DynamicFiltersSelector3);
         AV24DynamicFiltersOperator3 = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24DynamicFiltersOperator3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0)));
         AV25PedidoDt3 = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25PedidoDt3", context.localUtil.Format(AV25PedidoDt3, "99/99/99"));
         AV26PedidoDt_To3 = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26PedidoDt_To3", context.localUtil.Format(AV26PedidoDt_To3, "99/99/99"));
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS3' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void S222( )
      {
         /* 'CLEANFILTERS' Routine */
         AV13DynamicFiltersSelector1 = "PEDIDODT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13DynamicFiltersSelector1", AV13DynamicFiltersSelector1);
         AV14DynamicFiltersOperator1 = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14DynamicFiltersOperator1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0)));
         AV15PedidoDt1 = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15PedidoDt1", context.localUtil.Format(AV15PedidoDt1, "99/99/99"));
         AV16PedidoDt_To1 = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16PedidoDt_To1", context.localUtil.Format(AV16PedidoDt_To1, "99/99/99"));
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS1' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'RESETDYNFILTERS' */
         S182 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV8GridState.gxTpr_Dynamicfilters.Clear();
         /* Execute user subroutine: 'LOADDYNFILTERSSTATE' */
         S142 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void S142( )
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
         if ( AV8GridState.gxTpr_Dynamicfilters.Count >= 1 )
         {
            AV10GridStateDynamicFilter = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter)AV8GridState.gxTpr_Dynamicfilters.Item(1));
            AV13DynamicFiltersSelector1 = AV10GridStateDynamicFilter.gxTpr_Selected;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13DynamicFiltersSelector1", AV13DynamicFiltersSelector1);
            if ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PEDIDODT") == 0 )
            {
               AV14DynamicFiltersOperator1 = AV10GridStateDynamicFilter.gxTpr_Operator;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14DynamicFiltersOperator1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0)));
               AV15PedidoDt1 = context.localUtil.CToD( AV10GridStateDynamicFilter.gxTpr_Value, 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15PedidoDt1", context.localUtil.Format(AV15PedidoDt1, "99/99/99"));
               AV16PedidoDt_To1 = context.localUtil.CToD( AV10GridStateDynamicFilter.gxTpr_Valueto, 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16PedidoDt_To1", context.localUtil.Format(AV16PedidoDt_To1, "99/99/99"));
            }
            /* Execute user subroutine: 'ENABLEDYNAMICFILTERS1' */
            S112 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            if ( AV8GridState.gxTpr_Dynamicfilters.Count >= 2 )
            {
               lblJsdynamicfilters_Caption = "<script type=\"text/javascript\">";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblJsdynamicfilters_Internalname, "Caption", lblJsdynamicfilters_Caption, true);
               lblJsdynamicfilters_Caption = lblJsdynamicfilters_Caption+StringUtil.Format( "WWPDynFilterShow_AL('%1', 2, 0);", tblTabledynamicfilters_Internalname, "", "", "", "", "", "", "", "");
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblJsdynamicfilters_Internalname, "Caption", lblJsdynamicfilters_Caption, true);
               imgAdddynamicfilters1_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgAdddynamicfilters1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgAdddynamicfilters1_Visible), 5, 0)), true);
               imgRemovedynamicfilters1_Visible = 1;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgRemovedynamicfilters1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgRemovedynamicfilters1_Visible), 5, 0)), true);
               AV17DynamicFiltersEnabled2 = true;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17DynamicFiltersEnabled2", AV17DynamicFiltersEnabled2);
               AV10GridStateDynamicFilter = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter)AV8GridState.gxTpr_Dynamicfilters.Item(2));
               AV18DynamicFiltersSelector2 = AV10GridStateDynamicFilter.gxTpr_Selected;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18DynamicFiltersSelector2", AV18DynamicFiltersSelector2);
               if ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PEDIDODT") == 0 )
               {
                  AV19DynamicFiltersOperator2 = AV10GridStateDynamicFilter.gxTpr_Operator;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19DynamicFiltersOperator2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0)));
                  AV20PedidoDt2 = context.localUtil.CToD( AV10GridStateDynamicFilter.gxTpr_Value, 2);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20PedidoDt2", context.localUtil.Format(AV20PedidoDt2, "99/99/99"));
                  AV21PedidoDt_To2 = context.localUtil.CToD( AV10GridStateDynamicFilter.gxTpr_Valueto, 2);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21PedidoDt_To2", context.localUtil.Format(AV21PedidoDt_To2, "99/99/99"));
               }
               /* Execute user subroutine: 'ENABLEDYNAMICFILTERS2' */
               S122 ();
               if ( returnInSub )
               {
                  returnInSub = true;
                  if (true) return;
               }
               if ( AV8GridState.gxTpr_Dynamicfilters.Count >= 3 )
               {
                  lblJsdynamicfilters_Caption = lblJsdynamicfilters_Caption+StringUtil.Format( "WWPDynFilterShow_AL('%1', 3, 0);", tblTabledynamicfilters_Internalname, "", "", "", "", "", "", "", "");
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblJsdynamicfilters_Internalname, "Caption", lblJsdynamicfilters_Caption, true);
                  imgAdddynamicfilters2_Visible = 0;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgAdddynamicfilters2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgAdddynamicfilters2_Visible), 5, 0)), true);
                  imgRemovedynamicfilters2_Visible = 1;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgRemovedynamicfilters2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgRemovedynamicfilters2_Visible), 5, 0)), true);
                  AV22DynamicFiltersEnabled3 = true;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22DynamicFiltersEnabled3", AV22DynamicFiltersEnabled3);
                  AV10GridStateDynamicFilter = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter)AV8GridState.gxTpr_Dynamicfilters.Item(3));
                  AV23DynamicFiltersSelector3 = AV10GridStateDynamicFilter.gxTpr_Selected;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23DynamicFiltersSelector3", AV23DynamicFiltersSelector3);
                  if ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PEDIDODT") == 0 )
                  {
                     AV24DynamicFiltersOperator3 = AV10GridStateDynamicFilter.gxTpr_Operator;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24DynamicFiltersOperator3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0)));
                     AV25PedidoDt3 = context.localUtil.CToD( AV10GridStateDynamicFilter.gxTpr_Value, 2);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25PedidoDt3", context.localUtil.Format(AV25PedidoDt3, "99/99/99"));
                     AV26PedidoDt_To3 = context.localUtil.CToD( AV10GridStateDynamicFilter.gxTpr_Valueto, 2);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26PedidoDt_To3", context.localUtil.Format(AV26PedidoDt_To3, "99/99/99"));
                  }
                  /* Execute user subroutine: 'ENABLEDYNAMICFILTERS3' */
                  S132 ();
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
         if ( AV27DynamicFiltersRemoving )
         {
            lblJsdynamicfilters_Caption = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblJsdynamicfilters_Internalname, "Caption", lblJsdynamicfilters_Caption, true);
         }
      }

      protected void S172( )
      {
         /* 'SAVEDYNFILTERSSTATE' Routine */
         AV8GridState.gxTpr_Dynamicfilters.Clear();
         if ( ! AV28DynamicFiltersIgnoreFirst )
         {
            AV10GridStateDynamicFilter = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter(context);
            AV10GridStateDynamicFilter.gxTpr_Selected = AV13DynamicFiltersSelector1;
            if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PEDIDODT") == 0 ) && ! ( (DateTime.MinValue==AV15PedidoDt1) && (DateTime.MinValue==AV16PedidoDt_To1) ) )
            {
               AV10GridStateDynamicFilter.gxTpr_Value = context.localUtil.DToC( AV15PedidoDt1, 2, "/");
               AV10GridStateDynamicFilter.gxTpr_Operator = AV14DynamicFiltersOperator1;
               AV10GridStateDynamicFilter.gxTpr_Valueto = context.localUtil.DToC( AV16PedidoDt_To1, 2, "/");
            }
            if ( AV27DynamicFiltersRemoving || ! String.IsNullOrEmpty(StringUtil.RTrim( AV10GridStateDynamicFilter.gxTpr_Value)) || ! String.IsNullOrEmpty(StringUtil.RTrim( AV10GridStateDynamicFilter.gxTpr_Valueto)) )
            {
               AV8GridState.gxTpr_Dynamicfilters.Add(AV10GridStateDynamicFilter, 0);
            }
         }
         if ( AV17DynamicFiltersEnabled2 )
         {
            AV10GridStateDynamicFilter = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter(context);
            AV10GridStateDynamicFilter.gxTpr_Selected = AV18DynamicFiltersSelector2;
            if ( ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PEDIDODT") == 0 ) && ! ( (DateTime.MinValue==AV20PedidoDt2) && (DateTime.MinValue==AV21PedidoDt_To2) ) )
            {
               AV10GridStateDynamicFilter.gxTpr_Value = context.localUtil.DToC( AV20PedidoDt2, 2, "/");
               AV10GridStateDynamicFilter.gxTpr_Operator = AV19DynamicFiltersOperator2;
               AV10GridStateDynamicFilter.gxTpr_Valueto = context.localUtil.DToC( AV21PedidoDt_To2, 2, "/");
            }
            if ( AV27DynamicFiltersRemoving || ! String.IsNullOrEmpty(StringUtil.RTrim( AV10GridStateDynamicFilter.gxTpr_Value)) || ! String.IsNullOrEmpty(StringUtil.RTrim( AV10GridStateDynamicFilter.gxTpr_Valueto)) )
            {
               AV8GridState.gxTpr_Dynamicfilters.Add(AV10GridStateDynamicFilter, 0);
            }
         }
         if ( AV22DynamicFiltersEnabled3 )
         {
            AV10GridStateDynamicFilter = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter(context);
            AV10GridStateDynamicFilter.gxTpr_Selected = AV23DynamicFiltersSelector3;
            if ( ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PEDIDODT") == 0 ) && ! ( (DateTime.MinValue==AV25PedidoDt3) && (DateTime.MinValue==AV26PedidoDt_To3) ) )
            {
               AV10GridStateDynamicFilter.gxTpr_Value = context.localUtil.DToC( AV25PedidoDt3, 2, "/");
               AV10GridStateDynamicFilter.gxTpr_Operator = AV24DynamicFiltersOperator3;
               AV10GridStateDynamicFilter.gxTpr_Valueto = context.localUtil.DToC( AV26PedidoDt_To3, 2, "/");
            }
            if ( AV27DynamicFiltersRemoving || ! String.IsNullOrEmpty(StringUtil.RTrim( AV10GridStateDynamicFilter.gxTpr_Value)) || ! String.IsNullOrEmpty(StringUtil.RTrim( AV10GridStateDynamicFilter.gxTpr_Valueto)) )
            {
               AV8GridState.gxTpr_Dynamicfilters.Add(AV10GridStateDynamicFilter, 0);
            }
         }
      }

      protected void wb_table1_14_142( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablefilters_Internalname, tblTablefilters_Internalname, "", "", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='CellAlignTopPaddingTop10'>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"";
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "effedd9a-25cf-4497-952f-5a5ac032b8be", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgCleanfilters_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "Limpar filtros", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgCleanfilters_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'DOCLEANFILTERS\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_PedidoPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_19_142( true) ;
         }
         else
         {
            wb_table2_19_142( false) ;
         }
         return  ;
      }

      protected void wb_table2_19_142e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_14_142e( true) ;
         }
         else
         {
            wb_table1_14_142e( false) ;
         }
      }

      protected void wb_table2_19_142( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTabledynamicfilters_Internalname, tblTabledynamicfilters_Internalname, "", "TableDynamicFilters", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersprefix1_Internalname, "Filtrar por", "", "", lblDynamicfiltersprefix1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescriptionPrefix", 0, "", 1, 1, 0, "HLP_PedidoPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavDynamicfiltersselector1_Internalname, "Dynamic Filters Selector1", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'" + sGXsfl_119_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersselector1, cmbavDynamicfiltersselector1_Internalname, StringUtil.RTrim( AV13DynamicFiltersSelector1), 1, cmbavDynamicfiltersselector1_Jsonclick, 5, "'"+""+"'"+",false,"+"'"+"EVDYNAMICFILTERSSELECTOR1.CLICK."+"'", "svchar", "", 1, cmbavDynamicfiltersselector1.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,25);\"", "", true, "HLP_PedidoPrompt.htm");
            cmbavDynamicfiltersselector1.CurrentValue = StringUtil.RTrim( AV13DynamicFiltersSelector1);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector1_Internalname, "Values", (String)(cmbavDynamicfiltersselector1.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersmiddle1_Internalname, "valor", "", "", lblDynamicfiltersmiddle1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescription", 0, "", 1, 1, 0, "HLP_PedidoPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table3_29_142( true) ;
         }
         else
         {
            wb_table3_29_142( false) ;
         }
         return  ;
      }

      protected void wb_table3_29_142e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table4_46_142( true) ;
         }
         else
         {
            wb_table4_46_142( false) ;
         }
         return  ;
      }

      protected void wb_table4_46_142e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersprefix2_Internalname, "Filtrar por", "", "", lblDynamicfiltersprefix2_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescriptionPrefix", 0, "", 1, 1, 0, "HLP_PedidoPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavDynamicfiltersselector2_Internalname, "Dynamic Filters Selector2", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'" + sGXsfl_119_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersselector2, cmbavDynamicfiltersselector2_Internalname, StringUtil.RTrim( AV18DynamicFiltersSelector2), 1, cmbavDynamicfiltersselector2_Jsonclick, 5, "'"+""+"'"+",false,"+"'"+"EVDYNAMICFILTERSSELECTOR2.CLICK."+"'", "svchar", "", 1, cmbavDynamicfiltersselector2.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,57);\"", "", true, "HLP_PedidoPrompt.htm");
            cmbavDynamicfiltersselector2.CurrentValue = StringUtil.RTrim( AV18DynamicFiltersSelector2);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector2_Internalname, "Values", (String)(cmbavDynamicfiltersselector2.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersmiddle2_Internalname, "valor", "", "", lblDynamicfiltersmiddle2_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescription", 0, "", 1, 1, 0, "HLP_PedidoPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            wb_table5_61_142( true) ;
         }
         else
         {
            wb_table5_61_142( false) ;
         }
         return  ;
      }

      protected void wb_table5_61_142e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            wb_table6_78_142( true) ;
         }
         else
         {
            wb_table6_78_142( false) ;
         }
         return  ;
      }

      protected void wb_table6_78_142e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersprefix3_Internalname, "Filtrar por", "", "", lblDynamicfiltersprefix3_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescriptionPrefix", 0, "", 1, 1, 0, "HLP_PedidoPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavDynamicfiltersselector3_Internalname, "Dynamic Filters Selector3", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 89,'',false,'" + sGXsfl_119_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersselector3, cmbavDynamicfiltersselector3_Internalname, StringUtil.RTrim( AV23DynamicFiltersSelector3), 1, cmbavDynamicfiltersselector3_Jsonclick, 5, "'"+""+"'"+",false,"+"'"+"EVDYNAMICFILTERSSELECTOR3.CLICK."+"'", "svchar", "", 1, cmbavDynamicfiltersselector3.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,89);\"", "", true, "HLP_PedidoPrompt.htm");
            cmbavDynamicfiltersselector3.CurrentValue = StringUtil.RTrim( AV23DynamicFiltersSelector3);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector3_Internalname, "Values", (String)(cmbavDynamicfiltersselector3.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersmiddle3_Internalname, "valor", "", "", lblDynamicfiltersmiddle3_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescription", 0, "", 1, 1, 0, "HLP_PedidoPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            wb_table7_93_142( true) ;
         }
         else
         {
            wb_table7_93_142( false) ;
         }
         return  ;
      }

      protected void wb_table7_93_142e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            wb_table8_110_142( true) ;
         }
         else
         {
            wb_table8_110_142( false) ;
         }
         return  ;
      }

      protected void wb_table8_110_142e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_19_142e( true) ;
         }
         else
         {
            wb_table2_19_142e( false) ;
         }
      }

      protected void wb_table8_110_142( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblUnnamedtabledynamicfilters_3_Internalname, tblUnnamedtabledynamicfilters_3_Internalname, "", "Table", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\""+cellDynamicfilters_removefilter3_cell_Internalname+"\"  class=''>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 113,'',false,'',0)\"";
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "11a6ef14-1a5a-4077-91a2-f41ed9a3a662", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgRemovedynamicfilters3_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "Remover filtro", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgRemovedynamicfilters3_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'REMOVEDYNAMICFILTERS3\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_PedidoPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table8_110_142e( true) ;
         }
         else
         {
            wb_table8_110_142e( false) ;
         }
      }

      protected void wb_table7_93_142( bool wbgen )
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 97,'',false,'" + sGXsfl_119_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersoperator3, cmbavDynamicfiltersoperator3_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0)), 1, cmbavDynamicfiltersoperator3_Jsonclick, 5, "'"+""+"'"+",false,"+"'"+"EVDYNAMICFILTERSOPERATOR3.CLICK."+"'", "int", "", cmbavDynamicfiltersoperator3.Visible, cmbavDynamicfiltersoperator3.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,97);\"", "", true, "HLP_PedidoPrompt.htm");
            cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", (String)(cmbavDynamicfiltersoperator3.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellFilter_pedidodt3_cell_Internalname+"\"  class=''>") ;
            wb_table9_99_142( true) ;
         }
         else
         {
            wb_table9_99_142( false) ;
         }
         return  ;
      }

      protected void wb_table9_99_142e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table7_93_142e( true) ;
         }
         else
         {
            wb_table7_93_142e( false) ;
         }
      }

      protected void wb_table9_99_142( bool wbgen )
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 103,'',false,'" + sGXsfl_119_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavPedidodt3_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavPedidodt3_Internalname, context.localUtil.Format(AV25PedidoDt3, "99/99/99"), context.localUtil.Format( AV25PedidoDt3, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,103);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPedidodt3_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavPedidodt3_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PedidoPrompt.htm");
            GxWebStd.gx_bitmap( context, edtavPedidodt3_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavPedidodt3_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_PedidoPrompt.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellPedidodt_rangemiddletext_1_cell3_Internalname+"\"  class=''>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblPedidodt_rangemiddletext_13_Internalname, "até", "", "", lblPedidodt_rangemiddletext_13_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", lblPedidodt_rangemiddletext_13_Class, 0, "", 1, 1, 0, "HLP_PedidoPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellPedidodt_to_cell3_Internalname+"\"  class='"+cellPedidodt_to_cell3_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavPedidodt_to3_Internalname, "Pedido Dt_To3", "col-sm-3 AttributeDateLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 108,'',false,'" + sGXsfl_119_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavPedidodt_to3_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavPedidodt_to3_Internalname, context.localUtil.Format(AV26PedidoDt_To3, "99/99/99"), context.localUtil.Format( AV26PedidoDt_To3, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,108);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPedidodt_to3_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavPedidodt_to3_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PedidoPrompt.htm");
            GxWebStd.gx_bitmap( context, edtavPedidodt_to3_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavPedidodt_to3_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_PedidoPrompt.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table9_99_142e( true) ;
         }
         else
         {
            wb_table9_99_142e( false) ;
         }
      }

      protected void wb_table6_78_142( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblUnnamedtabledynamicfilters_2_Internalname, tblUnnamedtabledynamicfilters_2_Internalname, "", "Table", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\""+cellDynamicfilters_addfilter2_cell_Internalname+"\"  class=''>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'',0)\"";
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "27283ea5-332f-423b-b880-64b762622df3", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgAdddynamicfilters2_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgAdddynamicfilters2_Visible, 1, "", "Adicionar filtro", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgAdddynamicfilters2_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'ADDDYNAMICFILTERS2\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_PedidoPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellDynamicfilters_removefilter2_cell_Internalname+"\"  class=''>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'',0)\"";
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "11a6ef14-1a5a-4077-91a2-f41ed9a3a662", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgRemovedynamicfilters2_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgRemovedynamicfilters2_Visible, 1, "", "Remover filtro", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgRemovedynamicfilters2_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'REMOVEDYNAMICFILTERS2\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_PedidoPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table6_78_142e( true) ;
         }
         else
         {
            wb_table6_78_142e( false) ;
         }
      }

      protected void wb_table5_61_142( bool wbgen )
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'" + sGXsfl_119_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersoperator2, cmbavDynamicfiltersoperator2_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0)), 1, cmbavDynamicfiltersoperator2_Jsonclick, 5, "'"+""+"'"+",false,"+"'"+"EVDYNAMICFILTERSOPERATOR2.CLICK."+"'", "int", "", cmbavDynamicfiltersoperator2.Visible, cmbavDynamicfiltersoperator2.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,65);\"", "", true, "HLP_PedidoPrompt.htm");
            cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", (String)(cmbavDynamicfiltersoperator2.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellFilter_pedidodt2_cell_Internalname+"\"  class=''>") ;
            wb_table10_67_142( true) ;
         }
         else
         {
            wb_table10_67_142( false) ;
         }
         return  ;
      }

      protected void wb_table10_67_142e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_61_142e( true) ;
         }
         else
         {
            wb_table5_61_142e( false) ;
         }
      }

      protected void wb_table10_67_142( bool wbgen )
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'" + sGXsfl_119_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavPedidodt2_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavPedidodt2_Internalname, context.localUtil.Format(AV20PedidoDt2, "99/99/99"), context.localUtil.Format( AV20PedidoDt2, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,71);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPedidodt2_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavPedidodt2_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PedidoPrompt.htm");
            GxWebStd.gx_bitmap( context, edtavPedidodt2_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavPedidodt2_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_PedidoPrompt.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellPedidodt_rangemiddletext_1_cell2_Internalname+"\"  class=''>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblPedidodt_rangemiddletext_12_Internalname, "até", "", "", lblPedidodt_rangemiddletext_12_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", lblPedidodt_rangemiddletext_12_Class, 0, "", 1, 1, 0, "HLP_PedidoPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellPedidodt_to_cell2_Internalname+"\"  class='"+cellPedidodt_to_cell2_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavPedidodt_to2_Internalname, "Pedido Dt_To2", "col-sm-3 AttributeDateLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_119_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavPedidodt_to2_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavPedidodt_to2_Internalname, context.localUtil.Format(AV21PedidoDt_To2, "99/99/99"), context.localUtil.Format( AV21PedidoDt_To2, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPedidodt_to2_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavPedidodt_to2_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PedidoPrompt.htm");
            GxWebStd.gx_bitmap( context, edtavPedidodt_to2_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavPedidodt_to2_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_PedidoPrompt.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table10_67_142e( true) ;
         }
         else
         {
            wb_table10_67_142e( false) ;
         }
      }

      protected void wb_table4_46_142( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblUnnamedtabledynamicfilters_1_Internalname, tblUnnamedtabledynamicfilters_1_Internalname, "", "Table", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\""+cellDynamicfilters_addfilter1_cell_Internalname+"\"  class=''>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "27283ea5-332f-423b-b880-64b762622df3", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgAdddynamicfilters1_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgAdddynamicfilters1_Visible, 1, "", "Adicionar filtro", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgAdddynamicfilters1_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'ADDDYNAMICFILTERS1\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_PedidoPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellDynamicfilters_removefilter1_cell_Internalname+"\"  class=''>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'',0)\"";
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "11a6ef14-1a5a-4077-91a2-f41ed9a3a662", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgRemovedynamicfilters1_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgRemovedynamicfilters1_Visible, 1, "", "Remover filtro", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgRemovedynamicfilters1_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'REMOVEDYNAMICFILTERS1\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_PedidoPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_46_142e( true) ;
         }
         else
         {
            wb_table4_46_142e( false) ;
         }
      }

      protected void wb_table3_29_142( bool wbgen )
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'" + sGXsfl_119_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersoperator1, cmbavDynamicfiltersoperator1_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0)), 1, cmbavDynamicfiltersoperator1_Jsonclick, 5, "'"+""+"'"+",false,"+"'"+"EVDYNAMICFILTERSOPERATOR1.CLICK."+"'", "int", "", cmbavDynamicfiltersoperator1.Visible, cmbavDynamicfiltersoperator1.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,33);\"", "", true, "HLP_PedidoPrompt.htm");
            cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", (String)(cmbavDynamicfiltersoperator1.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellFilter_pedidodt1_cell_Internalname+"\"  class=''>") ;
            wb_table11_35_142( true) ;
         }
         else
         {
            wb_table11_35_142( false) ;
         }
         return  ;
      }

      protected void wb_table11_35_142e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_29_142e( true) ;
         }
         else
         {
            wb_table3_29_142e( false) ;
         }
      }

      protected void wb_table11_35_142( bool wbgen )
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_119_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavPedidodt1_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavPedidodt1_Internalname, context.localUtil.Format(AV15PedidoDt1, "99/99/99"), context.localUtil.Format( AV15PedidoDt1, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPedidodt1_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavPedidodt1_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PedidoPrompt.htm");
            GxWebStd.gx_bitmap( context, edtavPedidodt1_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavPedidodt1_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_PedidoPrompt.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellPedidodt_rangemiddletext_1_cell1_Internalname+"\"  class=''>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblPedidodt_rangemiddletext_11_Internalname, "até", "", "", lblPedidodt_rangemiddletext_11_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", lblPedidodt_rangemiddletext_11_Class, 0, "", 1, 1, 0, "HLP_PedidoPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellPedidodt_to_cell1_Internalname+"\"  class='"+cellPedidodt_to_cell1_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavPedidodt_to1_Internalname, "Pedido Dt_To1", "col-sm-3 AttributeDateLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'" + sGXsfl_119_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavPedidodt_to1_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavPedidodt_to1_Internalname, context.localUtil.Format(AV16PedidoDt_To1, "99/99/99"), context.localUtil.Format( AV16PedidoDt_To1, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPedidodt_to1_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavPedidodt_to1_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PedidoPrompt.htm");
            GxWebStd.gx_bitmap( context, edtavPedidodt_to1_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavPedidodt_to1_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_PedidoPrompt.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table11_35_142e( true) ;
         }
         else
         {
            wb_table11_35_142e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV45InOutPedidoId = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45InOutPedidoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV45InOutPedidoId), 4, 0)));
         AV46InOutPedidoDt = (DateTime)getParm(obj,1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46InOutPedidoDt", context.localUtil.Format(AV46InOutPedidoDt, "99/99/99"));
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
         PA142( ) ;
         WS142( ) ;
         WE142( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201971217595723", true, true);
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
         context.AddJavascriptSource("pedidoprompt.js", "?201971217595723", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false, true);
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
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false, true);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_1192( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_119_idx;
         edtPedidoId_Internalname = "PEDIDOID_"+sGXsfl_119_idx;
         edtPedidoDt_Internalname = "PEDIDODT_"+sGXsfl_119_idx;
         cmbPedidoStatus_Internalname = "PEDIDOSTATUS_"+sGXsfl_119_idx;
         edtPedidoDtEntrega_Internalname = "PEDIDODTENTREGA_"+sGXsfl_119_idx;
         chkPedidoRetirada_Internalname = "PEDIDORETIRADA_"+sGXsfl_119_idx;
         edtPedidoTotal_Internalname = "PEDIDOTOTAL_"+sGXsfl_119_idx;
      }

      protected void SubsflControlProps_fel_1192( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_119_fel_idx;
         edtPedidoId_Internalname = "PEDIDOID_"+sGXsfl_119_fel_idx;
         edtPedidoDt_Internalname = "PEDIDODT_"+sGXsfl_119_fel_idx;
         cmbPedidoStatus_Internalname = "PEDIDOSTATUS_"+sGXsfl_119_fel_idx;
         edtPedidoDtEntrega_Internalname = "PEDIDODTENTREGA_"+sGXsfl_119_fel_idx;
         chkPedidoRetirada_Internalname = "PEDIDORETIRADA_"+sGXsfl_119_fel_idx;
         edtPedidoTotal_Internalname = "PEDIDOTOTAL_"+sGXsfl_119_fel_idx;
      }

      protected void sendrow_1192( )
      {
         SubsflControlProps_1192( ) ;
         WB140( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_119_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_119_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_119_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavSelect_Enabled!=0)&&(edtavSelect_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 120,'',false,'',119)\"" : " ");
            ClassString = "SelectAttribute ActionBaseColorAttribute";
            StyleString = "";
            AV44Select_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV44Select))&&String.IsNullOrEmpty(StringUtil.RTrim( AV51Select_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV44Select)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV44Select)) ? AV51Select_GXI : context.PathToRelativeUrl( AV44Select));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavSelect_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavSelect_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavSelect_Jsonclick,"'"+""+"'"+",false,"+"'"+"EENTER."+sGXsfl_119_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV44Select_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPedidoId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A32PedidoId), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A32PedidoId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPedidoId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)119,(short)1,(short)-1,(short)0,(bool)true,(String)"Serial",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPedidoDt_Internalname,context.localUtil.Format(A33PedidoDt, "99/99/99"),context.localUtil.Format( A33PedidoDt, "99/99/99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPedidoDt_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)119,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbPedidoStatus.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "PEDIDOSTATUS_" + sGXsfl_119_idx;
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
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbPedidoStatus,(String)cmbPedidoStatus_Internalname,StringUtil.RTrim( A34PedidoStatus),(short)1,(String)cmbPedidoStatus_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"svchar",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn hidden-xs",(String)"",(String)"",(String)"",(bool)true});
            cmbPedidoStatus.CurrentValue = StringUtil.RTrim( A34PedidoStatus);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPedidoStatus_Internalname, "Values", (String)(cmbPedidoStatus.ToJavascriptSource()), !bGXsfl_119_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPedidoDtEntrega_Internalname,context.localUtil.Format(A35PedidoDtEntrega, "99/99/99"),context.localUtil.Format( A35PedidoDtEntrega, "99/99/99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPedidoDtEntrega_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)119,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Check box */
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GridRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkPedidoRetirada_Internalname,StringUtil.BoolToStr( A36PedidoRetirada),(String)"",(String)"",(short)-1,(short)0,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn hidden-xs",(String)"",(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPedidoTotal_Internalname,StringUtil.LTrim( StringUtil.NToC( A37PedidoTotal, 18, 2, ",", "")),context.localUtil.Format( A37PedidoTotal, "R$ Z,ZZZ,ZZ,ZZ9.99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPedidoTotal_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)119,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            send_integrity_lvl_hashes142( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_119_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_119_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_119_idx+1));
            sGXsfl_119_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_119_idx), 4, 0)), 4, "0");
            SubsflControlProps_1192( ) ;
         }
         /* End function sendrow_1192 */
      }

      protected void init_web_controls( )
      {
         cmbavDynamicfiltersselector1.Name = "vDYNAMICFILTERSSELECTOR1";
         cmbavDynamicfiltersselector1.WebTags = "";
         cmbavDynamicfiltersselector1.addItem("PEDIDODT", "Data do Pedido", 0);
         if ( cmbavDynamicfiltersselector1.ItemCount > 0 )
         {
            AV13DynamicFiltersSelector1 = cmbavDynamicfiltersselector1.getValidValue(AV13DynamicFiltersSelector1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13DynamicFiltersSelector1", AV13DynamicFiltersSelector1);
         }
         cmbavDynamicfiltersoperator1.Name = "vDYNAMICFILTERSOPERATOR1";
         cmbavDynamicfiltersoperator1.WebTags = "";
         cmbavDynamicfiltersoperator1.addItem("0", "Passado", 0);
         cmbavDynamicfiltersoperator1.addItem("1", "Hoje", 0);
         cmbavDynamicfiltersoperator1.addItem("2", "No futuro", 0);
         cmbavDynamicfiltersoperator1.addItem("3", "Período", 0);
         if ( cmbavDynamicfiltersoperator1.ItemCount > 0 )
         {
            AV14DynamicFiltersOperator1 = (short)(NumberUtil.Val( cmbavDynamicfiltersoperator1.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14DynamicFiltersOperator1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0)));
         }
         cmbavDynamicfiltersselector2.Name = "vDYNAMICFILTERSSELECTOR2";
         cmbavDynamicfiltersselector2.WebTags = "";
         cmbavDynamicfiltersselector2.addItem("PEDIDODT", "Data do Pedido", 0);
         if ( cmbavDynamicfiltersselector2.ItemCount > 0 )
         {
            AV18DynamicFiltersSelector2 = cmbavDynamicfiltersselector2.getValidValue(AV18DynamicFiltersSelector2);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18DynamicFiltersSelector2", AV18DynamicFiltersSelector2);
         }
         cmbavDynamicfiltersoperator2.Name = "vDYNAMICFILTERSOPERATOR2";
         cmbavDynamicfiltersoperator2.WebTags = "";
         cmbavDynamicfiltersoperator2.addItem("0", "Passado", 0);
         cmbavDynamicfiltersoperator2.addItem("1", "Hoje", 0);
         cmbavDynamicfiltersoperator2.addItem("2", "No futuro", 0);
         cmbavDynamicfiltersoperator2.addItem("3", "Período", 0);
         if ( cmbavDynamicfiltersoperator2.ItemCount > 0 )
         {
            AV19DynamicFiltersOperator2 = (short)(NumberUtil.Val( cmbavDynamicfiltersoperator2.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19DynamicFiltersOperator2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0)));
         }
         cmbavDynamicfiltersselector3.Name = "vDYNAMICFILTERSSELECTOR3";
         cmbavDynamicfiltersselector3.WebTags = "";
         cmbavDynamicfiltersselector3.addItem("PEDIDODT", "Data do Pedido", 0);
         if ( cmbavDynamicfiltersselector3.ItemCount > 0 )
         {
            AV23DynamicFiltersSelector3 = cmbavDynamicfiltersselector3.getValidValue(AV23DynamicFiltersSelector3);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23DynamicFiltersSelector3", AV23DynamicFiltersSelector3);
         }
         cmbavDynamicfiltersoperator3.Name = "vDYNAMICFILTERSOPERATOR3";
         cmbavDynamicfiltersoperator3.WebTags = "";
         cmbavDynamicfiltersoperator3.addItem("0", "Passado", 0);
         cmbavDynamicfiltersoperator3.addItem("1", "Hoje", 0);
         cmbavDynamicfiltersoperator3.addItem("2", "No futuro", 0);
         cmbavDynamicfiltersoperator3.addItem("3", "Período", 0);
         if ( cmbavDynamicfiltersoperator3.ItemCount > 0 )
         {
            AV24DynamicFiltersOperator3 = (short)(NumberUtil.Val( cmbavDynamicfiltersoperator3.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24DynamicFiltersOperator3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0)));
         }
         GXCCtl = "PEDIDOSTATUS_" + sGXsfl_119_idx;
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
         GXCCtl = "PEDIDORETIRADA_" + sGXsfl_119_idx;
         chkPedidoRetirada.Name = GXCCtl;
         chkPedidoRetirada.WebTags = "";
         chkPedidoRetirada.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkPedidoRetirada_Internalname, "TitleCaption", chkPedidoRetirada.Caption, !bGXsfl_119_Refreshing);
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
         imgCleanfilters_Internalname = "CLEANFILTERS";
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
         divTableheader_Internalname = "TABLEHEADER";
         Dvpanel_tableheader_Internalname = "DVPANEL_TABLEHEADER";
         edtavSelect_Internalname = "vSELECT";
         edtPedidoId_Internalname = "PEDIDOID";
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
         chkavDynamicfiltersenabled2_Internalname = "vDYNAMICFILTERSENABLED2";
         chkavDynamicfiltersenabled3_Internalname = "vDYNAMICFILTERSENABLED3";
         edtavOrderedby_Internalname = "vORDEREDBY";
         edtavOrdereddsc_Internalname = "vORDEREDDSC";
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
         edtPedidoId_Jsonclick = "";
         edtavSelect_Jsonclick = "";
         edtavSelect_Visible = -1;
         edtavSelect_Enabled = 1;
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
         edtavDdo_pedidoidtitlecontrolidtoreplace_Visible = 1;
         lblJsdynamicfilters_Caption = "JSDynamicFilters";
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavSelect_Tooltiptext = "Selecionar";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtPedidoTotal_Titleformat = 0;
         edtPedidoTotal_Title = "Total";
         chkPedidoRetirada_Titleformat = 0;
         chkPedidoRetirada.Title.Text = "Retirar no Local?";
         edtPedidoDtEntrega_Titleformat = 0;
         edtPedidoDtEntrega_Title = "Data de Entrega";
         cmbPedidoStatus_Titleformat = 0;
         cmbPedidoStatus.Title.Text = "Status";
         edtPedidoDt_Titleformat = 0;
         edtPedidoDt_Title = "Data do Pedido";
         edtPedidoId_Titleformat = 0;
         edtPedidoId_Title = "Número do Pedido";
         subGrid_Class = "GridWithPaginationBar GridNoBorder WorkWith";
         subGrid_Backcolorstyle = 0;
         Ddo_pedidototal_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_pedidototal_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_pedidototal_Sortdsc = "WWP_TSSortDSC";
         Ddo_pedidototal_Sortasc = "WWP_TSSortASC";
         Ddo_pedidototal_Includedatalist = Convert.ToBoolean( 0);
         Ddo_pedidototal_Includefilter = Convert.ToBoolean( 0);
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
         Ddo_pedidoretirada_Includedatalist = Convert.ToBoolean( 0);
         Ddo_pedidoretirada_Includefilter = Convert.ToBoolean( 0);
         Ddo_pedidoretirada_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_pedidoretirada_Includesortasc = Convert.ToBoolean( -1);
         Ddo_pedidoretirada_Titlecontrolidtoreplace = "";
         Ddo_pedidoretirada_Dropdownoptionstype = "GridTitleSettings";
         Ddo_pedidoretirada_Cls = "ColumnSettings";
         Ddo_pedidoretirada_Tooltip = "WWP_TSColumnOptions";
         Ddo_pedidoretirada_Caption = "";
         Ddo_pedidodtentrega_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_pedidodtentrega_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_pedidodtentrega_Sortdsc = "WWP_TSSortDSC";
         Ddo_pedidodtentrega_Sortasc = "WWP_TSSortASC";
         Ddo_pedidodtentrega_Includedatalist = Convert.ToBoolean( 0);
         Ddo_pedidodtentrega_Includefilter = Convert.ToBoolean( 0);
         Ddo_pedidodtentrega_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_pedidodtentrega_Includesortasc = Convert.ToBoolean( -1);
         Ddo_pedidodtentrega_Titlecontrolidtoreplace = "";
         Ddo_pedidodtentrega_Dropdownoptionstype = "GridTitleSettings";
         Ddo_pedidodtentrega_Cls = "ColumnSettings";
         Ddo_pedidodtentrega_Tooltip = "WWP_TSColumnOptions";
         Ddo_pedidodtentrega_Caption = "";
         Ddo_pedidostatus_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_pedidostatus_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_pedidostatus_Sortdsc = "WWP_TSSortDSC";
         Ddo_pedidostatus_Sortasc = "WWP_TSSortASC";
         Ddo_pedidostatus_Includedatalist = Convert.ToBoolean( 0);
         Ddo_pedidostatus_Includefilter = Convert.ToBoolean( 0);
         Ddo_pedidostatus_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_pedidostatus_Includesortasc = Convert.ToBoolean( -1);
         Ddo_pedidostatus_Titlecontrolidtoreplace = "";
         Ddo_pedidostatus_Dropdownoptionstype = "GridTitleSettings";
         Ddo_pedidostatus_Cls = "ColumnSettings";
         Ddo_pedidostatus_Tooltip = "WWP_TSColumnOptions";
         Ddo_pedidostatus_Caption = "";
         Ddo_pedidodt_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_pedidodt_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_pedidodt_Sortdsc = "WWP_TSSortDSC";
         Ddo_pedidodt_Sortasc = "WWP_TSSortASC";
         Ddo_pedidodt_Includedatalist = Convert.ToBoolean( 0);
         Ddo_pedidodt_Includefilter = Convert.ToBoolean( 0);
         Ddo_pedidodt_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_pedidodt_Includesortasc = Convert.ToBoolean( -1);
         Ddo_pedidodt_Titlecontrolidtoreplace = "";
         Ddo_pedidodt_Dropdownoptionstype = "GridTitleSettings";
         Ddo_pedidodt_Cls = "ColumnSettings";
         Ddo_pedidodt_Tooltip = "WWP_TSColumnOptions";
         Ddo_pedidodt_Caption = "";
         Ddo_pedidoid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_pedidoid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_pedidoid_Sortdsc = "WWP_TSSortDSC";
         Ddo_pedidoid_Sortasc = "WWP_TSSortASC";
         Ddo_pedidoid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_pedidoid_Includefilter = Convert.ToBoolean( 0);
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
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Consulta de Pedido";
         subGrid_Rows = 0;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV16PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV21PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV26PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV30PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV32PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV34PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV36PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV38PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV47PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E11142',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV16PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV21PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV26PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E12142',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV16PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV21PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV26PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_PEDIDOID.ONOPTIONCLICKED","{handler:'E13142',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV16PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV21PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV26PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_pedidoid_Activeeventkey',ctrl:'DDO_PEDIDOID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_PEDIDOID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_pedidoid_Sortedstatus',ctrl:'DDO_PEDIDOID',prop:'SortedStatus'},{av:'Ddo_pedidodt_Sortedstatus',ctrl:'DDO_PEDIDODT',prop:'SortedStatus'},{av:'Ddo_pedidostatus_Sortedstatus',ctrl:'DDO_PEDIDOSTATUS',prop:'SortedStatus'},{av:'Ddo_pedidodtentrega_Sortedstatus',ctrl:'DDO_PEDIDODTENTREGA',prop:'SortedStatus'},{av:'Ddo_pedidoretirada_Sortedstatus',ctrl:'DDO_PEDIDORETIRADA',prop:'SortedStatus'},{av:'Ddo_pedidototal_Sortedstatus',ctrl:'DDO_PEDIDOTOTAL',prop:'SortedStatus'},{av:'AV30PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV32PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV34PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV36PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV38PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV47PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_PEDIDODT.ONOPTIONCLICKED","{handler:'E14142',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV16PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV21PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV26PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_pedidodt_Activeeventkey',ctrl:'DDO_PEDIDODT',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_PEDIDODT.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_pedidodt_Sortedstatus',ctrl:'DDO_PEDIDODT',prop:'SortedStatus'},{av:'Ddo_pedidoid_Sortedstatus',ctrl:'DDO_PEDIDOID',prop:'SortedStatus'},{av:'Ddo_pedidostatus_Sortedstatus',ctrl:'DDO_PEDIDOSTATUS',prop:'SortedStatus'},{av:'Ddo_pedidodtentrega_Sortedstatus',ctrl:'DDO_PEDIDODTENTREGA',prop:'SortedStatus'},{av:'Ddo_pedidoretirada_Sortedstatus',ctrl:'DDO_PEDIDORETIRADA',prop:'SortedStatus'},{av:'Ddo_pedidototal_Sortedstatus',ctrl:'DDO_PEDIDOTOTAL',prop:'SortedStatus'},{av:'AV30PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV32PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV34PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV36PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV38PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV47PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_PEDIDOSTATUS.ONOPTIONCLICKED","{handler:'E15142',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV16PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV21PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV26PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_pedidostatus_Activeeventkey',ctrl:'DDO_PEDIDOSTATUS',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_PEDIDOSTATUS.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_pedidostatus_Sortedstatus',ctrl:'DDO_PEDIDOSTATUS',prop:'SortedStatus'},{av:'Ddo_pedidoid_Sortedstatus',ctrl:'DDO_PEDIDOID',prop:'SortedStatus'},{av:'Ddo_pedidodt_Sortedstatus',ctrl:'DDO_PEDIDODT',prop:'SortedStatus'},{av:'Ddo_pedidodtentrega_Sortedstatus',ctrl:'DDO_PEDIDODTENTREGA',prop:'SortedStatus'},{av:'Ddo_pedidoretirada_Sortedstatus',ctrl:'DDO_PEDIDORETIRADA',prop:'SortedStatus'},{av:'Ddo_pedidototal_Sortedstatus',ctrl:'DDO_PEDIDOTOTAL',prop:'SortedStatus'},{av:'AV30PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV32PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV34PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV36PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV38PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV47PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_PEDIDODTENTREGA.ONOPTIONCLICKED","{handler:'E16142',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV16PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV21PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV26PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_pedidodtentrega_Activeeventkey',ctrl:'DDO_PEDIDODTENTREGA',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_PEDIDODTENTREGA.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_pedidodtentrega_Sortedstatus',ctrl:'DDO_PEDIDODTENTREGA',prop:'SortedStatus'},{av:'Ddo_pedidoid_Sortedstatus',ctrl:'DDO_PEDIDOID',prop:'SortedStatus'},{av:'Ddo_pedidodt_Sortedstatus',ctrl:'DDO_PEDIDODT',prop:'SortedStatus'},{av:'Ddo_pedidostatus_Sortedstatus',ctrl:'DDO_PEDIDOSTATUS',prop:'SortedStatus'},{av:'Ddo_pedidoretirada_Sortedstatus',ctrl:'DDO_PEDIDORETIRADA',prop:'SortedStatus'},{av:'Ddo_pedidototal_Sortedstatus',ctrl:'DDO_PEDIDOTOTAL',prop:'SortedStatus'},{av:'AV30PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV32PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV34PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV36PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV38PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV47PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_PEDIDORETIRADA.ONOPTIONCLICKED","{handler:'E17142',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV16PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV21PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV26PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_pedidoretirada_Activeeventkey',ctrl:'DDO_PEDIDORETIRADA',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_PEDIDORETIRADA.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_pedidoretirada_Sortedstatus',ctrl:'DDO_PEDIDORETIRADA',prop:'SortedStatus'},{av:'Ddo_pedidoid_Sortedstatus',ctrl:'DDO_PEDIDOID',prop:'SortedStatus'},{av:'Ddo_pedidodt_Sortedstatus',ctrl:'DDO_PEDIDODT',prop:'SortedStatus'},{av:'Ddo_pedidostatus_Sortedstatus',ctrl:'DDO_PEDIDOSTATUS',prop:'SortedStatus'},{av:'Ddo_pedidodtentrega_Sortedstatus',ctrl:'DDO_PEDIDODTENTREGA',prop:'SortedStatus'},{av:'Ddo_pedidototal_Sortedstatus',ctrl:'DDO_PEDIDOTOTAL',prop:'SortedStatus'},{av:'AV30PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV32PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV34PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV36PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV38PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV47PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_PEDIDOTOTAL.ONOPTIONCLICKED","{handler:'E18142',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV16PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV21PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV26PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_pedidototal_Activeeventkey',ctrl:'DDO_PEDIDOTOTAL',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_PEDIDOTOTAL.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_pedidototal_Sortedstatus',ctrl:'DDO_PEDIDOTOTAL',prop:'SortedStatus'},{av:'Ddo_pedidoid_Sortedstatus',ctrl:'DDO_PEDIDOID',prop:'SortedStatus'},{av:'Ddo_pedidodt_Sortedstatus',ctrl:'DDO_PEDIDODT',prop:'SortedStatus'},{av:'Ddo_pedidostatus_Sortedstatus',ctrl:'DDO_PEDIDOSTATUS',prop:'SortedStatus'},{av:'Ddo_pedidodtentrega_Sortedstatus',ctrl:'DDO_PEDIDODTENTREGA',prop:'SortedStatus'},{av:'Ddo_pedidoretirada_Sortedstatus',ctrl:'DDO_PEDIDORETIRADA',prop:'SortedStatus'},{av:'AV30PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV32PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV34PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV36PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV38PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV47PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E33142',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV44Select',fld:'vSELECT',pic:''},{av:'edtavSelect_Tooltiptext',ctrl:'vSELECT',prop:'Tooltiptext'}]}");
         setEventMetadata("ENTER","{handler:'E34142',iparms:[{av:'A32PedidoId',fld:'PEDIDOID',pic:'ZZZ9',hsh:true},{av:'A33PedidoDt',fld:'PEDIDODT',pic:'',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV45InOutPedidoId',fld:'vINOUTPEDIDOID',pic:'ZZZ9'},{av:'AV46InOutPedidoDt',fld:'vINOUTPEDIDODT',pic:''}]}");
         setEventMetadata("'ADDDYNAMICFILTERS1'","{handler:'E23142',iparms:[]");
         setEventMetadata("'ADDDYNAMICFILTERS1'",",oparms:[{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'}]}");
         setEventMetadata("'REMOVEDYNAMICFILTERS1'","{handler:'E19142',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV16PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV21PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV26PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV8GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Gx_date',fld:'vTODAY',pic:''}]");
         setEventMetadata("'REMOVEDYNAMICFILTERS1'",",oparms:[{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV8GridState',fld:'vGRIDSTATE',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV21PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV26PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV16PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'lblJsdynamicfilters_Caption',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{av:'tblTablemergeddynamicfilterspedidodt2_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPEDIDODT2',prop:'Visible'},{av:'tblTablemergeddynamicfilterspedidodt3_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPEDIDODT3',prop:'Visible'},{av:'tblTablemergeddynamicfilterspedidodt1_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPEDIDODT1',prop:'Visible'},{av:'cellPedidodt_cell2_Class',ctrl:'PEDIDODT_CELL2',prop:'Class'},{av:'cellPedidodt_to_cell2_Class',ctrl:'PEDIDODT_TO_CELL2',prop:'Class'},{av:'lblPedidodt_rangemiddletext_12_Class',ctrl:'PEDIDODT_RANGEMIDDLETEXT_12',prop:'Class'},{av:'cellPedidodt_cell3_Class',ctrl:'PEDIDODT_CELL3',prop:'Class'},{av:'cellPedidodt_to_cell3_Class',ctrl:'PEDIDODT_TO_CELL3',prop:'Class'},{av:'lblPedidodt_rangemiddletext_13_Class',ctrl:'PEDIDODT_RANGEMIDDLETEXT_13',prop:'Class'},{av:'cellPedidodt_cell1_Class',ctrl:'PEDIDODT_CELL1',prop:'Class'},{av:'cellPedidodt_to_cell1_Class',ctrl:'PEDIDODT_TO_CELL1',prop:'Class'},{av:'lblPedidodt_rangemiddletext_11_Class',ctrl:'PEDIDODT_RANGEMIDDLETEXT_11',prop:'Class'},{av:'AV30PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV32PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV34PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV36PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV38PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV47PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("VDYNAMICFILTERSSELECTOR1.CLICK","{handler:'E24142',iparms:[{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'Gx_date',fld:'vTODAY',pic:''}]");
         setEventMetadata("VDYNAMICFILTERSSELECTOR1.CLICK",",oparms:[{av:'tblTablemergeddynamicfilterspedidodt1_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPEDIDODT1',prop:'Visible'},{av:'cmbavDynamicfiltersoperator1'},{av:'cellPedidodt_cell1_Class',ctrl:'PEDIDODT_CELL1',prop:'Class'},{av:'cellPedidodt_to_cell1_Class',ctrl:'PEDIDODT_TO_CELL1',prop:'Class'},{av:'lblPedidodt_rangemiddletext_11_Class',ctrl:'PEDIDODT_RANGEMIDDLETEXT_11',prop:'Class'},{av:'AV15PedidoDt1',fld:'vPEDIDODT1',pic:''}]}");
         setEventMetadata("VDYNAMICFILTERSOPERATOR1.CLICK","{handler:'E25142',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV16PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV21PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV26PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'Gx_date',fld:'vTODAY',pic:''}]");
         setEventMetadata("VDYNAMICFILTERSOPERATOR1.CLICK",",oparms:[{av:'AV15PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV16PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'cellPedidodt_cell1_Class',ctrl:'PEDIDODT_CELL1',prop:'Class'},{av:'cellPedidodt_to_cell1_Class',ctrl:'PEDIDODT_TO_CELL1',prop:'Class'},{av:'lblPedidodt_rangemiddletext_11_Class',ctrl:'PEDIDODT_RANGEMIDDLETEXT_11',prop:'Class'},{av:'AV30PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV32PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV34PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV36PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV38PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV47PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("'ADDDYNAMICFILTERS2'","{handler:'E26142',iparms:[]");
         setEventMetadata("'ADDDYNAMICFILTERS2'",",oparms:[{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'}]}");
         setEventMetadata("'REMOVEDYNAMICFILTERS2'","{handler:'E20142',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV16PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV21PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV26PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV8GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Gx_date',fld:'vTODAY',pic:''}]");
         setEventMetadata("'REMOVEDYNAMICFILTERS2'",",oparms:[{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV8GridState',fld:'vGRIDSTATE',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV21PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV26PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV16PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'lblJsdynamicfilters_Caption',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{av:'tblTablemergeddynamicfilterspedidodt2_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPEDIDODT2',prop:'Visible'},{av:'tblTablemergeddynamicfilterspedidodt3_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPEDIDODT3',prop:'Visible'},{av:'tblTablemergeddynamicfilterspedidodt1_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPEDIDODT1',prop:'Visible'},{av:'cellPedidodt_cell2_Class',ctrl:'PEDIDODT_CELL2',prop:'Class'},{av:'cellPedidodt_to_cell2_Class',ctrl:'PEDIDODT_TO_CELL2',prop:'Class'},{av:'lblPedidodt_rangemiddletext_12_Class',ctrl:'PEDIDODT_RANGEMIDDLETEXT_12',prop:'Class'},{av:'cellPedidodt_cell3_Class',ctrl:'PEDIDODT_CELL3',prop:'Class'},{av:'cellPedidodt_to_cell3_Class',ctrl:'PEDIDODT_TO_CELL3',prop:'Class'},{av:'lblPedidodt_rangemiddletext_13_Class',ctrl:'PEDIDODT_RANGEMIDDLETEXT_13',prop:'Class'},{av:'cellPedidodt_cell1_Class',ctrl:'PEDIDODT_CELL1',prop:'Class'},{av:'cellPedidodt_to_cell1_Class',ctrl:'PEDIDODT_TO_CELL1',prop:'Class'},{av:'lblPedidodt_rangemiddletext_11_Class',ctrl:'PEDIDODT_RANGEMIDDLETEXT_11',prop:'Class'},{av:'AV30PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV32PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV34PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV36PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV38PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV47PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("VDYNAMICFILTERSSELECTOR2.CLICK","{handler:'E27142',iparms:[{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'Gx_date',fld:'vTODAY',pic:''}]");
         setEventMetadata("VDYNAMICFILTERSSELECTOR2.CLICK",",oparms:[{av:'tblTablemergeddynamicfilterspedidodt2_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPEDIDODT2',prop:'Visible'},{av:'cmbavDynamicfiltersoperator2'},{av:'cellPedidodt_cell2_Class',ctrl:'PEDIDODT_CELL2',prop:'Class'},{av:'cellPedidodt_to_cell2_Class',ctrl:'PEDIDODT_TO_CELL2',prop:'Class'},{av:'lblPedidodt_rangemiddletext_12_Class',ctrl:'PEDIDODT_RANGEMIDDLETEXT_12',prop:'Class'},{av:'AV20PedidoDt2',fld:'vPEDIDODT2',pic:''}]}");
         setEventMetadata("VDYNAMICFILTERSOPERATOR2.CLICK","{handler:'E28142',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV16PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV21PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV26PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'Gx_date',fld:'vTODAY',pic:''}]");
         setEventMetadata("VDYNAMICFILTERSOPERATOR2.CLICK",",oparms:[{av:'AV20PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV21PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cellPedidodt_cell2_Class',ctrl:'PEDIDODT_CELL2',prop:'Class'},{av:'cellPedidodt_to_cell2_Class',ctrl:'PEDIDODT_TO_CELL2',prop:'Class'},{av:'lblPedidodt_rangemiddletext_12_Class',ctrl:'PEDIDODT_RANGEMIDDLETEXT_12',prop:'Class'},{av:'AV30PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV32PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV34PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV36PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV38PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV47PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("'REMOVEDYNAMICFILTERS3'","{handler:'E21142',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV16PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV21PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV26PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV8GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Gx_date',fld:'vTODAY',pic:''}]");
         setEventMetadata("'REMOVEDYNAMICFILTERS3'",",oparms:[{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV8GridState',fld:'vGRIDSTATE',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV21PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV26PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV16PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'lblJsdynamicfilters_Caption',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{av:'tblTablemergeddynamicfilterspedidodt2_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPEDIDODT2',prop:'Visible'},{av:'tblTablemergeddynamicfilterspedidodt3_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPEDIDODT3',prop:'Visible'},{av:'tblTablemergeddynamicfilterspedidodt1_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPEDIDODT1',prop:'Visible'},{av:'cellPedidodt_cell2_Class',ctrl:'PEDIDODT_CELL2',prop:'Class'},{av:'cellPedidodt_to_cell2_Class',ctrl:'PEDIDODT_TO_CELL2',prop:'Class'},{av:'lblPedidodt_rangemiddletext_12_Class',ctrl:'PEDIDODT_RANGEMIDDLETEXT_12',prop:'Class'},{av:'cellPedidodt_cell3_Class',ctrl:'PEDIDODT_CELL3',prop:'Class'},{av:'cellPedidodt_to_cell3_Class',ctrl:'PEDIDODT_TO_CELL3',prop:'Class'},{av:'lblPedidodt_rangemiddletext_13_Class',ctrl:'PEDIDODT_RANGEMIDDLETEXT_13',prop:'Class'},{av:'cellPedidodt_cell1_Class',ctrl:'PEDIDODT_CELL1',prop:'Class'},{av:'cellPedidodt_to_cell1_Class',ctrl:'PEDIDODT_TO_CELL1',prop:'Class'},{av:'lblPedidodt_rangemiddletext_11_Class',ctrl:'PEDIDODT_RANGEMIDDLETEXT_11',prop:'Class'},{av:'AV30PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV32PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV34PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV36PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV38PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV47PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("VDYNAMICFILTERSSELECTOR3.CLICK","{handler:'E29142',iparms:[{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'Gx_date',fld:'vTODAY',pic:''}]");
         setEventMetadata("VDYNAMICFILTERSSELECTOR3.CLICK",",oparms:[{av:'tblTablemergeddynamicfilterspedidodt3_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPEDIDODT3',prop:'Visible'},{av:'cmbavDynamicfiltersoperator3'},{av:'cellPedidodt_cell3_Class',ctrl:'PEDIDODT_CELL3',prop:'Class'},{av:'cellPedidodt_to_cell3_Class',ctrl:'PEDIDODT_TO_CELL3',prop:'Class'},{av:'lblPedidodt_rangemiddletext_13_Class',ctrl:'PEDIDODT_RANGEMIDDLETEXT_13',prop:'Class'},{av:'AV25PedidoDt3',fld:'vPEDIDODT3',pic:''}]}");
         setEventMetadata("VDYNAMICFILTERSOPERATOR3.CLICK","{handler:'E30142',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV16PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV21PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV26PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'Gx_date',fld:'vTODAY',pic:''}]");
         setEventMetadata("VDYNAMICFILTERSOPERATOR3.CLICK",",oparms:[{av:'AV25PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV26PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'cellPedidodt_cell3_Class',ctrl:'PEDIDODT_CELL3',prop:'Class'},{av:'cellPedidodt_to_cell3_Class',ctrl:'PEDIDODT_TO_CELL3',prop:'Class'},{av:'lblPedidodt_rangemiddletext_13_Class',ctrl:'PEDIDODT_RANGEMIDDLETEXT_13',prop:'Class'},{av:'AV30PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV32PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV34PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV36PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV38PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV47PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("'DOCLEANFILTERS'","{handler:'E22142',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV16PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV21PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV26PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31ddo_PedidoIdTitleControlIdToReplace',fld:'vDDO_PEDIDOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_PedidoDtTitleControlIdToReplace',fld:'vDDO_PEDIDODTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_PedidoStatusTitleControlIdToReplace',fld:'vDDO_PEDIDOSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_PedidoDtEntregaTitleControlIdToReplace',fld:'vDDO_PEDIDODTENTREGATITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_PedidoRetiradaTitleControlIdToReplace',fld:'vDDO_PEDIDORETIRADATITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_PedidoTotalTitleControlIdToReplace',fld:'vDDO_PEDIDOTOTALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV8GridState',fld:'vGRIDSTATE',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Gx_date',fld:'vTODAY',pic:''}]");
         setEventMetadata("'DOCLEANFILTERS'",",oparms:[{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoDt1',fld:'vPEDIDODT1',pic:''},{av:'AV16PedidoDt_To1',fld:'vPEDIDODT_TO1',pic:''},{av:'AV8GridState',fld:'vGRIDSTATE',pic:''},{av:'tblTablemergeddynamicfilterspedidodt1_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPEDIDODT1',prop:'Visible'},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoDt2',fld:'vPEDIDODT2',pic:''},{av:'AV21PedidoDt_To2',fld:'vPEDIDODT_TO2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoDt3',fld:'vPEDIDODT3',pic:''},{av:'AV26PedidoDt_To3',fld:'vPEDIDODT_TO3',pic:''},{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'lblJsdynamicfilters_Caption',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{av:'cellPedidodt_cell1_Class',ctrl:'PEDIDODT_CELL1',prop:'Class'},{av:'cellPedidodt_to_cell1_Class',ctrl:'PEDIDODT_TO_CELL1',prop:'Class'},{av:'lblPedidodt_rangemiddletext_11_Class',ctrl:'PEDIDODT_RANGEMIDDLETEXT_11',prop:'Class'},{av:'tblTablemergeddynamicfilterspedidodt2_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPEDIDODT2',prop:'Visible'},{av:'tblTablemergeddynamicfilterspedidodt3_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPEDIDODT3',prop:'Visible'},{av:'cellPedidodt_cell2_Class',ctrl:'PEDIDODT_CELL2',prop:'Class'},{av:'cellPedidodt_to_cell2_Class',ctrl:'PEDIDODT_TO_CELL2',prop:'Class'},{av:'lblPedidodt_rangemiddletext_12_Class',ctrl:'PEDIDODT_RANGEMIDDLETEXT_12',prop:'Class'},{av:'cellPedidodt_cell3_Class',ctrl:'PEDIDODT_CELL3',prop:'Class'},{av:'cellPedidodt_to_cell3_Class',ctrl:'PEDIDODT_TO_CELL3',prop:'Class'},{av:'lblPedidodt_rangemiddletext_13_Class',ctrl:'PEDIDODT_RANGEMIDDLETEXT_13',prop:'Class'},{av:'AV30PedidoIdTitleFilterData',fld:'vPEDIDOIDTITLEFILTERDATA',pic:''},{av:'AV32PedidoDtTitleFilterData',fld:'vPEDIDODTTITLEFILTERDATA',pic:''},{av:'AV34PedidoStatusTitleFilterData',fld:'vPEDIDOSTATUSTITLEFILTERDATA',pic:''},{av:'AV36PedidoDtEntregaTitleFilterData',fld:'vPEDIDODTENTREGATITLEFILTERDATA',pic:''},{av:'AV38PedidoRetiradaTitleFilterData',fld:'vPEDIDORETIRADATITLEFILTERDATA',pic:''},{av:'AV47PedidoTotalTitleFilterData',fld:'vPEDIDOTOTALTITLEFILTERDATA',pic:''},{av:'edtPedidoId_Titleformat',ctrl:'PEDIDOID',prop:'Titleformat'},{av:'edtPedidoId_Title',ctrl:'PEDIDOID',prop:'Title'},{av:'edtPedidoDt_Titleformat',ctrl:'PEDIDODT',prop:'Titleformat'},{av:'edtPedidoDt_Title',ctrl:'PEDIDODT',prop:'Title'},{av:'cmbPedidoStatus'},{av:'edtPedidoDtEntrega_Titleformat',ctrl:'PEDIDODTENTREGA',prop:'Titleformat'},{av:'edtPedidoDtEntrega_Title',ctrl:'PEDIDODTENTREGA',prop:'Title'},{av:'chkPedidoRetirada_Titleformat',ctrl:'PEDIDORETIRADA',prop:'Titleformat'},{av:'chkPedidoRetirada.Title.Text',ctrl:'PEDIDORETIRADA',prop:'Title'},{av:'edtPedidoTotal_Titleformat',ctrl:'PEDIDOTOTAL',prop:'Titleformat'},{av:'edtPedidoTotal_Title',ctrl:'PEDIDOTOTAL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
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
         wcpOAV46InOutPedidoDt = DateTime.MinValue;
         Gridpaginationbar_Selectedpage = "";
         Ddo_pedidoid_Activeeventkey = "";
         Ddo_pedidodt_Activeeventkey = "";
         Ddo_pedidostatus_Activeeventkey = "";
         Ddo_pedidodtentrega_Activeeventkey = "";
         Ddo_pedidoretirada_Activeeventkey = "";
         Ddo_pedidototal_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV13DynamicFiltersSelector1 = "";
         AV15PedidoDt1 = DateTime.MinValue;
         AV16PedidoDt_To1 = DateTime.MinValue;
         AV18DynamicFiltersSelector2 = "";
         AV20PedidoDt2 = DateTime.MinValue;
         AV21PedidoDt_To2 = DateTime.MinValue;
         AV23DynamicFiltersSelector3 = "";
         AV25PedidoDt3 = DateTime.MinValue;
         AV26PedidoDt_To3 = DateTime.MinValue;
         AV31ddo_PedidoIdTitleControlIdToReplace = "";
         AV33ddo_PedidoDtTitleControlIdToReplace = "";
         AV35ddo_PedidoStatusTitleControlIdToReplace = "";
         AV37ddo_PedidoDtEntregaTitleControlIdToReplace = "";
         AV39ddo_PedidoRetiradaTitleControlIdToReplace = "";
         AV48ddo_PedidoTotalTitleControlIdToReplace = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV40DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV30PedidoIdTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV32PedidoDtTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV34PedidoStatusTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV36PedidoDtEntregaTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV38PedidoRetiradaTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV47PedidoTotalTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV8GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         Gx_date = DateTime.MinValue;
         Ddo_pedidoid_Sortedstatus = "";
         Ddo_pedidodt_Sortedstatus = "";
         Ddo_pedidostatus_Sortedstatus = "";
         Ddo_pedidodtentrega_Sortedstatus = "";
         Ddo_pedidoretirada_Sortedstatus = "";
         Ddo_pedidototal_Sortedstatus = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ucDvpanel_tableheader = new GXUserControl();
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV44Select = "";
         A33PedidoDt = DateTime.MinValue;
         A34PedidoStatus = "";
         A35PedidoDtEntrega = DateTime.MinValue;
         ucGridpaginationbar = new GXUserControl();
         lblJsdynamicfilters_Jsonclick = "";
         ucDdo_pedidoid = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         ucDdo_pedidodt = new GXUserControl();
         ucDdo_pedidostatus = new GXUserControl();
         ucDdo_pedidodtentrega = new GXUserControl();
         ucDdo_pedidoretirada = new GXUserControl();
         ucDdo_pedidototal = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV51Select_GXI = "";
         scmdbuf = "";
         H00142_A37PedidoTotal = new decimal[1] ;
         H00142_A36PedidoRetirada = new bool[] {false} ;
         H00142_A35PedidoDtEntrega = new DateTime[] {DateTime.MinValue} ;
         H00142_A34PedidoStatus = new String[] {""} ;
         H00142_A33PedidoDt = new DateTime[] {DateTime.MinValue} ;
         H00142_A32PedidoId = new short[1] ;
         H00143_AGRID_nRecordCount = new long[1] ;
         imgAdddynamicfilters1_Jsonclick = "";
         imgRemovedynamicfilters1_Jsonclick = "";
         imgAdddynamicfilters2_Jsonclick = "";
         imgRemovedynamicfilters2_Jsonclick = "";
         imgRemovedynamicfilters3_Jsonclick = "";
         imgCleanfilters_Jsonclick = "";
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         AV10GridStateDynamicFilter = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter(context);
         sImgUrl = "";
         lblDynamicfiltersprefix1_Jsonclick = "";
         lblDynamicfiltersmiddle1_Jsonclick = "";
         lblDynamicfiltersprefix2_Jsonclick = "";
         lblDynamicfiltersmiddle2_Jsonclick = "";
         lblDynamicfiltersprefix3_Jsonclick = "";
         lblDynamicfiltersmiddle3_Jsonclick = "";
         lblPedidodt_rangemiddletext_13_Jsonclick = "";
         lblPedidodt_rangemiddletext_12_Jsonclick = "";
         lblPedidodt_rangemiddletext_11_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pedidoprompt__default(),
            new Object[][] {
                new Object[] {
               H00142_A37PedidoTotal, H00142_A36PedidoRetirada, H00142_A35PedidoDtEntrega, H00142_A34PedidoStatus, H00142_A33PedidoDt, H00142_A32PedidoId
               }
               , new Object[] {
               H00143_AGRID_nRecordCount
               }
            }
         );
         Gx_date = DateTimeUtil.Today( context);
         /* GeneXus formulas. */
         Gx_date = DateTimeUtil.Today( context);
         context.Gx_err = 0;
      }

      private short AV45InOutPedidoId ;
      private short wcpOAV45InOutPedidoId ;
      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_119 ;
      private short nGXsfl_119_idx=1 ;
      private short GRID_nEOF ;
      private short AV14DynamicFiltersOperator1 ;
      private short AV19DynamicFiltersOperator2 ;
      private short AV24DynamicFiltersOperator3 ;
      private short AV11OrderedBy ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtPedidoId_Titleformat ;
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
      private short nGXWrapped ;
      private short subGrid_Backstyle ;
      private int Gridpaginationbar_Rowsperpageselectedvalue ;
      private int subGrid_Rows ;
      private int Gridpaginationbar_Pagestoshow ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_pedidoidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_pedidodttitlecontrolidtoreplace_Visible ;
      private int edtavDdo_pedidostatustitlecontrolidtoreplace_Visible ;
      private int edtavDdo_pedidodtentregatitlecontrolidtoreplace_Visible ;
      private int edtavDdo_pedidoretiradatitlecontrolidtoreplace_Visible ;
      private int edtavDdo_pedidototaltitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV41PageToGo ;
      private int imgAdddynamicfilters1_Visible ;
      private int imgRemovedynamicfilters1_Visible ;
      private int imgAdddynamicfilters2_Visible ;
      private int imgRemovedynamicfilters2_Visible ;
      private int tblTablemergeddynamicfilterspedidodt1_Visible ;
      private int tblTablemergeddynamicfilterspedidodt2_Visible ;
      private int tblTablemergeddynamicfilterspedidodt3_Visible ;
      private int edtavPedidodt3_Enabled ;
      private int edtavPedidodt_to3_Enabled ;
      private int edtavPedidodt2_Enabled ;
      private int edtavPedidodt_to2_Enabled ;
      private int edtavPedidodt1_Enabled ;
      private int edtavPedidodt_to1_Enabled ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavSelect_Enabled ;
      private int edtavSelect_Visible ;
      private long GRID_nFirstRecordOnPage ;
      private long AV42GridCurrentPage ;
      private long AV43GridPageCount ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private decimal A37PedidoTotal ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_pedidoid_Activeeventkey ;
      private String Ddo_pedidodt_Activeeventkey ;
      private String Ddo_pedidostatus_Activeeventkey ;
      private String Ddo_pedidodtentrega_Activeeventkey ;
      private String Ddo_pedidoretirada_Activeeventkey ;
      private String Ddo_pedidototal_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_119_idx="0001" ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
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
      private String Ddo_pedidoid_Dropdownoptionstype ;
      private String Ddo_pedidoid_Titlecontrolidtoreplace ;
      private String Ddo_pedidoid_Sortedstatus ;
      private String Ddo_pedidoid_Sortasc ;
      private String Ddo_pedidoid_Sortdsc ;
      private String Ddo_pedidoid_Cleanfilter ;
      private String Ddo_pedidoid_Searchbuttontext ;
      private String Ddo_pedidodt_Caption ;
      private String Ddo_pedidodt_Tooltip ;
      private String Ddo_pedidodt_Cls ;
      private String Ddo_pedidodt_Dropdownoptionstype ;
      private String Ddo_pedidodt_Titlecontrolidtoreplace ;
      private String Ddo_pedidodt_Sortedstatus ;
      private String Ddo_pedidodt_Sortasc ;
      private String Ddo_pedidodt_Sortdsc ;
      private String Ddo_pedidodt_Cleanfilter ;
      private String Ddo_pedidodt_Searchbuttontext ;
      private String Ddo_pedidostatus_Caption ;
      private String Ddo_pedidostatus_Tooltip ;
      private String Ddo_pedidostatus_Cls ;
      private String Ddo_pedidostatus_Dropdownoptionstype ;
      private String Ddo_pedidostatus_Titlecontrolidtoreplace ;
      private String Ddo_pedidostatus_Sortedstatus ;
      private String Ddo_pedidostatus_Sortasc ;
      private String Ddo_pedidostatus_Sortdsc ;
      private String Ddo_pedidostatus_Cleanfilter ;
      private String Ddo_pedidostatus_Searchbuttontext ;
      private String Ddo_pedidodtentrega_Caption ;
      private String Ddo_pedidodtentrega_Tooltip ;
      private String Ddo_pedidodtentrega_Cls ;
      private String Ddo_pedidodtentrega_Dropdownoptionstype ;
      private String Ddo_pedidodtentrega_Titlecontrolidtoreplace ;
      private String Ddo_pedidodtentrega_Sortedstatus ;
      private String Ddo_pedidodtentrega_Sortasc ;
      private String Ddo_pedidodtentrega_Sortdsc ;
      private String Ddo_pedidodtentrega_Cleanfilter ;
      private String Ddo_pedidodtentrega_Searchbuttontext ;
      private String Ddo_pedidoretirada_Caption ;
      private String Ddo_pedidoretirada_Tooltip ;
      private String Ddo_pedidoretirada_Cls ;
      private String Ddo_pedidoretirada_Dropdownoptionstype ;
      private String Ddo_pedidoretirada_Titlecontrolidtoreplace ;
      private String Ddo_pedidoretirada_Sortedstatus ;
      private String Ddo_pedidoretirada_Sortasc ;
      private String Ddo_pedidoretirada_Sortdsc ;
      private String Ddo_pedidoretirada_Cleanfilter ;
      private String Ddo_pedidoretirada_Searchbuttontext ;
      private String Ddo_pedidototal_Caption ;
      private String Ddo_pedidototal_Tooltip ;
      private String Ddo_pedidototal_Cls ;
      private String Ddo_pedidototal_Dropdownoptionstype ;
      private String Ddo_pedidototal_Titlecontrolidtoreplace ;
      private String Ddo_pedidototal_Sortedstatus ;
      private String Ddo_pedidototal_Sortasc ;
      private String Ddo_pedidototal_Sortdsc ;
      private String Ddo_pedidototal_Cleanfilter ;
      private String Ddo_pedidototal_Searchbuttontext ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String Dvpanel_tableheader_Internalname ;
      private String divTableheader_Internalname ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtPedidoId_Title ;
      private String edtPedidoDt_Title ;
      private String edtPedidoDtEntrega_Title ;
      private String edtPedidoTotal_Title ;
      private String subGrid_Header ;
      private String edtavSelect_Tooltiptext ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String lblJsdynamicfilters_Internalname ;
      private String lblJsdynamicfilters_Caption ;
      private String lblJsdynamicfilters_Jsonclick ;
      private String Ddo_pedidoid_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String edtavDdo_pedidoidtitlecontrolidtoreplace_Internalname ;
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
      private String chkavDynamicfiltersenabled2_Internalname ;
      private String chkavDynamicfiltersenabled3_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavSelect_Internalname ;
      private String edtPedidoId_Internalname ;
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
      private String imgCleanfilters_Jsonclick ;
      private String imgCleanfilters_Internalname ;
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
      private String tblTablefilters_Internalname ;
      private String sImgUrl ;
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
      private String sGXsfl_119_fel_idx="0001" ;
      private String edtavSelect_Jsonclick ;
      private String ROClassString ;
      private String edtPedidoId_Jsonclick ;
      private String edtPedidoDt_Jsonclick ;
      private String GXCCtl ;
      private String cmbPedidoStatus_Jsonclick ;
      private String edtPedidoDtEntrega_Jsonclick ;
      private String edtPedidoTotal_Jsonclick ;
      private DateTime AV46InOutPedidoDt ;
      private DateTime wcpOAV46InOutPedidoDt ;
      private DateTime AV15PedidoDt1 ;
      private DateTime AV16PedidoDt_To1 ;
      private DateTime AV20PedidoDt2 ;
      private DateTime AV21PedidoDt_To2 ;
      private DateTime AV25PedidoDt3 ;
      private DateTime AV26PedidoDt_To3 ;
      private DateTime Gx_date ;
      private DateTime A33PedidoDt ;
      private DateTime A35PedidoDtEntrega ;
      private bool entryPointCalled ;
      private bool AV17DynamicFiltersEnabled2 ;
      private bool AV22DynamicFiltersEnabled3 ;
      private bool AV12OrderedDsc ;
      private bool toggleJsOutput ;
      private bool AV28DynamicFiltersIgnoreFirst ;
      private bool AV27DynamicFiltersRemoving ;
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
      private bool Ddo_pedidoid_Includedatalist ;
      private bool Ddo_pedidodt_Includesortasc ;
      private bool Ddo_pedidodt_Includesortdsc ;
      private bool Ddo_pedidodt_Includefilter ;
      private bool Ddo_pedidodt_Includedatalist ;
      private bool Ddo_pedidostatus_Includesortasc ;
      private bool Ddo_pedidostatus_Includesortdsc ;
      private bool Ddo_pedidostatus_Includefilter ;
      private bool Ddo_pedidostatus_Includedatalist ;
      private bool Ddo_pedidodtentrega_Includesortasc ;
      private bool Ddo_pedidodtentrega_Includesortdsc ;
      private bool Ddo_pedidodtentrega_Includefilter ;
      private bool Ddo_pedidodtentrega_Includedatalist ;
      private bool Ddo_pedidoretirada_Includesortasc ;
      private bool Ddo_pedidoretirada_Includesortdsc ;
      private bool Ddo_pedidoretirada_Includefilter ;
      private bool Ddo_pedidoretirada_Includedatalist ;
      private bool Ddo_pedidototal_Includesortasc ;
      private bool Ddo_pedidototal_Includesortdsc ;
      private bool Ddo_pedidototal_Includefilter ;
      private bool Ddo_pedidototal_Includedatalist ;
      private bool wbLoad ;
      private bool A36PedidoRetirada ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_119_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV44Select_IsBlob ;
      private String AV13DynamicFiltersSelector1 ;
      private String AV18DynamicFiltersSelector2 ;
      private String AV23DynamicFiltersSelector3 ;
      private String AV31ddo_PedidoIdTitleControlIdToReplace ;
      private String AV33ddo_PedidoDtTitleControlIdToReplace ;
      private String AV35ddo_PedidoStatusTitleControlIdToReplace ;
      private String AV37ddo_PedidoDtEntregaTitleControlIdToReplace ;
      private String AV39ddo_PedidoRetiradaTitleControlIdToReplace ;
      private String AV48ddo_PedidoTotalTitleControlIdToReplace ;
      private String A34PedidoStatus ;
      private String AV51Select_GXI ;
      private String AV44Select ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_pedidoid ;
      private GXUserControl ucDdo_pedidodt ;
      private GXUserControl ucDdo_pedidostatus ;
      private GXUserControl ucDdo_pedidodtentrega ;
      private GXUserControl ucDdo_pedidoretirada ;
      private GXUserControl ucDdo_pedidototal ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private IGxDataStore dsDefault ;
      private short aP0_InOutPedidoId ;
      private DateTime aP1_InOutPedidoDt ;
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
      private decimal[] H00142_A37PedidoTotal ;
      private bool[] H00142_A36PedidoRetirada ;
      private DateTime[] H00142_A35PedidoDtEntrega ;
      private String[] H00142_A34PedidoStatus ;
      private DateTime[] H00142_A33PedidoDt ;
      private short[] H00142_A32PedidoId ;
      private long[] H00143_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV30PedidoIdTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV32PedidoDtTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV34PedidoStatusTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV36PedidoDtEntregaTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV38PedidoRetiradaTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV47PedidoTotalTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV8GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter AV10GridStateDynamicFilter ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV40DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class pedidoprompt__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00142( IGxContext context ,
                                             String AV13DynamicFiltersSelector1 ,
                                             short AV14DynamicFiltersOperator1 ,
                                             DateTime AV15PedidoDt1 ,
                                             DateTime AV16PedidoDt_To1 ,
                                             bool AV17DynamicFiltersEnabled2 ,
                                             String AV18DynamicFiltersSelector2 ,
                                             short AV19DynamicFiltersOperator2 ,
                                             DateTime AV20PedidoDt2 ,
                                             DateTime AV21PedidoDt_To2 ,
                                             bool AV22DynamicFiltersEnabled3 ,
                                             String AV23DynamicFiltersSelector3 ,
                                             short AV24DynamicFiltersOperator3 ,
                                             DateTime AV25PedidoDt3 ,
                                             DateTime AV26PedidoDt_To3 ,
                                             DateTime A33PedidoDt ,
                                             short AV11OrderedBy ,
                                             bool AV12OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [18] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [PedidoTotal], [PedidoRetirada], [PedidoDtEntrega], [PedidoStatus], [PedidoDt], [PedidoId]";
         sFromString = " FROM [Pedido]";
         sOrderString = "";
         if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PEDIDODT") == 0 ) && ( AV14DynamicFiltersOperator1 == 0 ) && ( ! (DateTime.MinValue==AV15PedidoDt1) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PedidoDt] < @AV15PedidoDt1)";
            }
            else
            {
               sWhereString = sWhereString + " ([PedidoDt] < @AV15PedidoDt1)";
            }
         }
         else
         {
            GXv_int2[0] = 1;
         }
         if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PEDIDODT") == 0 ) && ( AV14DynamicFiltersOperator1 == 1 ) && ( ! (DateTime.MinValue==AV15PedidoDt1) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PedidoDt] = @AV15PedidoDt1)";
            }
            else
            {
               sWhereString = sWhereString + " ([PedidoDt] = @AV15PedidoDt1)";
            }
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PEDIDODT") == 0 ) && ( AV14DynamicFiltersOperator1 == 2 ) && ( ! (DateTime.MinValue==AV15PedidoDt1) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PedidoDt] > @AV15PedidoDt1)";
            }
            else
            {
               sWhereString = sWhereString + " ([PedidoDt] > @AV15PedidoDt1)";
            }
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PEDIDODT") == 0 ) && ( AV14DynamicFiltersOperator1 == 3 ) && ( ! (DateTime.MinValue==AV15PedidoDt1) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PedidoDt] >= @AV15PedidoDt1)";
            }
            else
            {
               sWhereString = sWhereString + " ([PedidoDt] >= @AV15PedidoDt1)";
            }
         }
         else
         {
            GXv_int2[3] = 1;
         }
         if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PEDIDODT") == 0 ) && ( AV14DynamicFiltersOperator1 == 3 ) && ( ! (DateTime.MinValue==AV16PedidoDt_To1) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PedidoDt] <= @AV16PedidoDt_To1)";
            }
            else
            {
               sWhereString = sWhereString + " ([PedidoDt] <= @AV16PedidoDt_To1)";
            }
         }
         else
         {
            GXv_int2[4] = 1;
         }
         if ( AV17DynamicFiltersEnabled2 && ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PEDIDODT") == 0 ) && ( AV19DynamicFiltersOperator2 == 0 ) && ( ! (DateTime.MinValue==AV20PedidoDt2) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PedidoDt] < @AV20PedidoDt2)";
            }
            else
            {
               sWhereString = sWhereString + " ([PedidoDt] < @AV20PedidoDt2)";
            }
         }
         else
         {
            GXv_int2[5] = 1;
         }
         if ( AV17DynamicFiltersEnabled2 && ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PEDIDODT") == 0 ) && ( AV19DynamicFiltersOperator2 == 1 ) && ( ! (DateTime.MinValue==AV20PedidoDt2) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PedidoDt] = @AV20PedidoDt2)";
            }
            else
            {
               sWhereString = sWhereString + " ([PedidoDt] = @AV20PedidoDt2)";
            }
         }
         else
         {
            GXv_int2[6] = 1;
         }
         if ( AV17DynamicFiltersEnabled2 && ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PEDIDODT") == 0 ) && ( AV19DynamicFiltersOperator2 == 2 ) && ( ! (DateTime.MinValue==AV20PedidoDt2) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PedidoDt] > @AV20PedidoDt2)";
            }
            else
            {
               sWhereString = sWhereString + " ([PedidoDt] > @AV20PedidoDt2)";
            }
         }
         else
         {
            GXv_int2[7] = 1;
         }
         if ( AV17DynamicFiltersEnabled2 && ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PEDIDODT") == 0 ) && ( AV19DynamicFiltersOperator2 == 3 ) && ( ! (DateTime.MinValue==AV20PedidoDt2) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PedidoDt] >= @AV20PedidoDt2)";
            }
            else
            {
               sWhereString = sWhereString + " ([PedidoDt] >= @AV20PedidoDt2)";
            }
         }
         else
         {
            GXv_int2[8] = 1;
         }
         if ( AV17DynamicFiltersEnabled2 && ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PEDIDODT") == 0 ) && ( AV19DynamicFiltersOperator2 == 3 ) && ( ! (DateTime.MinValue==AV21PedidoDt_To2) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PedidoDt] <= @AV21PedidoDt_To2)";
            }
            else
            {
               sWhereString = sWhereString + " ([PedidoDt] <= @AV21PedidoDt_To2)";
            }
         }
         else
         {
            GXv_int2[9] = 1;
         }
         if ( AV22DynamicFiltersEnabled3 && ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PEDIDODT") == 0 ) && ( AV24DynamicFiltersOperator3 == 0 ) && ( ! (DateTime.MinValue==AV25PedidoDt3) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PedidoDt] < @AV25PedidoDt3)";
            }
            else
            {
               sWhereString = sWhereString + " ([PedidoDt] < @AV25PedidoDt3)";
            }
         }
         else
         {
            GXv_int2[10] = 1;
         }
         if ( AV22DynamicFiltersEnabled3 && ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PEDIDODT") == 0 ) && ( AV24DynamicFiltersOperator3 == 1 ) && ( ! (DateTime.MinValue==AV25PedidoDt3) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PedidoDt] = @AV25PedidoDt3)";
            }
            else
            {
               sWhereString = sWhereString + " ([PedidoDt] = @AV25PedidoDt3)";
            }
         }
         else
         {
            GXv_int2[11] = 1;
         }
         if ( AV22DynamicFiltersEnabled3 && ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PEDIDODT") == 0 ) && ( AV24DynamicFiltersOperator3 == 2 ) && ( ! (DateTime.MinValue==AV25PedidoDt3) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PedidoDt] > @AV25PedidoDt3)";
            }
            else
            {
               sWhereString = sWhereString + " ([PedidoDt] > @AV25PedidoDt3)";
            }
         }
         else
         {
            GXv_int2[12] = 1;
         }
         if ( AV22DynamicFiltersEnabled3 && ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PEDIDODT") == 0 ) && ( AV24DynamicFiltersOperator3 == 3 ) && ( ! (DateTime.MinValue==AV25PedidoDt3) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PedidoDt] >= @AV25PedidoDt3)";
            }
            else
            {
               sWhereString = sWhereString + " ([PedidoDt] >= @AV25PedidoDt3)";
            }
         }
         else
         {
            GXv_int2[13] = 1;
         }
         if ( AV22DynamicFiltersEnabled3 && ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PEDIDODT") == 0 ) && ( AV24DynamicFiltersOperator3 == 3 ) && ( ! (DateTime.MinValue==AV26PedidoDt_To3) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PedidoDt] <= @AV26PedidoDt_To3)";
            }
            else
            {
               sWhereString = sWhereString + " ([PedidoDt] <= @AV26PedidoDt_To3)";
            }
         }
         else
         {
            GXv_int2[14] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         if ( ( AV11OrderedBy == 1 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [PedidoDt]";
         }
         else if ( ( AV11OrderedBy == 1 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [PedidoDt] DESC";
         }
         else if ( ( AV11OrderedBy == 2 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [PedidoId]";
         }
         else if ( ( AV11OrderedBy == 2 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [PedidoId] DESC";
         }
         else if ( ( AV11OrderedBy == 3 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [PedidoStatus]";
         }
         else if ( ( AV11OrderedBy == 3 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [PedidoStatus] DESC";
         }
         else if ( ( AV11OrderedBy == 4 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [PedidoDtEntrega]";
         }
         else if ( ( AV11OrderedBy == 4 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [PedidoDtEntrega] DESC";
         }
         else if ( ( AV11OrderedBy == 5 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [PedidoRetirada]";
         }
         else if ( ( AV11OrderedBy == 5 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [PedidoRetirada] DESC";
         }
         else if ( ( AV11OrderedBy == 6 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [PedidoTotal]";
         }
         else if ( ( AV11OrderedBy == 6 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [PedidoTotal] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [PedidoId]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      protected Object[] conditional_H00143( IGxContext context ,
                                             String AV13DynamicFiltersSelector1 ,
                                             short AV14DynamicFiltersOperator1 ,
                                             DateTime AV15PedidoDt1 ,
                                             DateTime AV16PedidoDt_To1 ,
                                             bool AV17DynamicFiltersEnabled2 ,
                                             String AV18DynamicFiltersSelector2 ,
                                             short AV19DynamicFiltersOperator2 ,
                                             DateTime AV20PedidoDt2 ,
                                             DateTime AV21PedidoDt_To2 ,
                                             bool AV22DynamicFiltersEnabled3 ,
                                             String AV23DynamicFiltersSelector3 ,
                                             short AV24DynamicFiltersOperator3 ,
                                             DateTime AV25PedidoDt3 ,
                                             DateTime AV26PedidoDt_To3 ,
                                             DateTime A33PedidoDt ,
                                             short AV11OrderedBy ,
                                             bool AV12OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [15] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [Pedido]";
         if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PEDIDODT") == 0 ) && ( AV14DynamicFiltersOperator1 == 0 ) && ( ! (DateTime.MinValue==AV15PedidoDt1) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PedidoDt] < @AV15PedidoDt1)";
            }
            else
            {
               sWhereString = sWhereString + " ([PedidoDt] < @AV15PedidoDt1)";
            }
         }
         else
         {
            GXv_int4[0] = 1;
         }
         if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PEDIDODT") == 0 ) && ( AV14DynamicFiltersOperator1 == 1 ) && ( ! (DateTime.MinValue==AV15PedidoDt1) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PedidoDt] = @AV15PedidoDt1)";
            }
            else
            {
               sWhereString = sWhereString + " ([PedidoDt] = @AV15PedidoDt1)";
            }
         }
         else
         {
            GXv_int4[1] = 1;
         }
         if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PEDIDODT") == 0 ) && ( AV14DynamicFiltersOperator1 == 2 ) && ( ! (DateTime.MinValue==AV15PedidoDt1) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PedidoDt] > @AV15PedidoDt1)";
            }
            else
            {
               sWhereString = sWhereString + " ([PedidoDt] > @AV15PedidoDt1)";
            }
         }
         else
         {
            GXv_int4[2] = 1;
         }
         if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PEDIDODT") == 0 ) && ( AV14DynamicFiltersOperator1 == 3 ) && ( ! (DateTime.MinValue==AV15PedidoDt1) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PedidoDt] >= @AV15PedidoDt1)";
            }
            else
            {
               sWhereString = sWhereString + " ([PedidoDt] >= @AV15PedidoDt1)";
            }
         }
         else
         {
            GXv_int4[3] = 1;
         }
         if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PEDIDODT") == 0 ) && ( AV14DynamicFiltersOperator1 == 3 ) && ( ! (DateTime.MinValue==AV16PedidoDt_To1) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PedidoDt] <= @AV16PedidoDt_To1)";
            }
            else
            {
               sWhereString = sWhereString + " ([PedidoDt] <= @AV16PedidoDt_To1)";
            }
         }
         else
         {
            GXv_int4[4] = 1;
         }
         if ( AV17DynamicFiltersEnabled2 && ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PEDIDODT") == 0 ) && ( AV19DynamicFiltersOperator2 == 0 ) && ( ! (DateTime.MinValue==AV20PedidoDt2) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PedidoDt] < @AV20PedidoDt2)";
            }
            else
            {
               sWhereString = sWhereString + " ([PedidoDt] < @AV20PedidoDt2)";
            }
         }
         else
         {
            GXv_int4[5] = 1;
         }
         if ( AV17DynamicFiltersEnabled2 && ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PEDIDODT") == 0 ) && ( AV19DynamicFiltersOperator2 == 1 ) && ( ! (DateTime.MinValue==AV20PedidoDt2) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PedidoDt] = @AV20PedidoDt2)";
            }
            else
            {
               sWhereString = sWhereString + " ([PedidoDt] = @AV20PedidoDt2)";
            }
         }
         else
         {
            GXv_int4[6] = 1;
         }
         if ( AV17DynamicFiltersEnabled2 && ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PEDIDODT") == 0 ) && ( AV19DynamicFiltersOperator2 == 2 ) && ( ! (DateTime.MinValue==AV20PedidoDt2) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PedidoDt] > @AV20PedidoDt2)";
            }
            else
            {
               sWhereString = sWhereString + " ([PedidoDt] > @AV20PedidoDt2)";
            }
         }
         else
         {
            GXv_int4[7] = 1;
         }
         if ( AV17DynamicFiltersEnabled2 && ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PEDIDODT") == 0 ) && ( AV19DynamicFiltersOperator2 == 3 ) && ( ! (DateTime.MinValue==AV20PedidoDt2) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PedidoDt] >= @AV20PedidoDt2)";
            }
            else
            {
               sWhereString = sWhereString + " ([PedidoDt] >= @AV20PedidoDt2)";
            }
         }
         else
         {
            GXv_int4[8] = 1;
         }
         if ( AV17DynamicFiltersEnabled2 && ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PEDIDODT") == 0 ) && ( AV19DynamicFiltersOperator2 == 3 ) && ( ! (DateTime.MinValue==AV21PedidoDt_To2) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PedidoDt] <= @AV21PedidoDt_To2)";
            }
            else
            {
               sWhereString = sWhereString + " ([PedidoDt] <= @AV21PedidoDt_To2)";
            }
         }
         else
         {
            GXv_int4[9] = 1;
         }
         if ( AV22DynamicFiltersEnabled3 && ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PEDIDODT") == 0 ) && ( AV24DynamicFiltersOperator3 == 0 ) && ( ! (DateTime.MinValue==AV25PedidoDt3) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PedidoDt] < @AV25PedidoDt3)";
            }
            else
            {
               sWhereString = sWhereString + " ([PedidoDt] < @AV25PedidoDt3)";
            }
         }
         else
         {
            GXv_int4[10] = 1;
         }
         if ( AV22DynamicFiltersEnabled3 && ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PEDIDODT") == 0 ) && ( AV24DynamicFiltersOperator3 == 1 ) && ( ! (DateTime.MinValue==AV25PedidoDt3) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PedidoDt] = @AV25PedidoDt3)";
            }
            else
            {
               sWhereString = sWhereString + " ([PedidoDt] = @AV25PedidoDt3)";
            }
         }
         else
         {
            GXv_int4[11] = 1;
         }
         if ( AV22DynamicFiltersEnabled3 && ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PEDIDODT") == 0 ) && ( AV24DynamicFiltersOperator3 == 2 ) && ( ! (DateTime.MinValue==AV25PedidoDt3) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PedidoDt] > @AV25PedidoDt3)";
            }
            else
            {
               sWhereString = sWhereString + " ([PedidoDt] > @AV25PedidoDt3)";
            }
         }
         else
         {
            GXv_int4[12] = 1;
         }
         if ( AV22DynamicFiltersEnabled3 && ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PEDIDODT") == 0 ) && ( AV24DynamicFiltersOperator3 == 3 ) && ( ! (DateTime.MinValue==AV25PedidoDt3) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PedidoDt] >= @AV25PedidoDt3)";
            }
            else
            {
               sWhereString = sWhereString + " ([PedidoDt] >= @AV25PedidoDt3)";
            }
         }
         else
         {
            GXv_int4[13] = 1;
         }
         if ( AV22DynamicFiltersEnabled3 && ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PEDIDODT") == 0 ) && ( AV24DynamicFiltersOperator3 == 3 ) && ( ! (DateTime.MinValue==AV26PedidoDt_To3) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PedidoDt] <= @AV26PedidoDt_To3)";
            }
            else
            {
               sWhereString = sWhereString + " ([PedidoDt] <= @AV26PedidoDt_To3)";
            }
         }
         else
         {
            GXv_int4[14] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         if ( ( AV11OrderedBy == 1 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 1 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 2 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 2 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 3 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 3 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 4 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 4 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 5 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 5 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 6 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 6 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( true )
         {
            scmdbuf = scmdbuf + "";
         }
         GXv_Object5[0] = scmdbuf;
         GXv_Object5[1] = GXv_int4;
         return GXv_Object5 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H00142(context, (String)dynConstraints[0] , (short)dynConstraints[1] , (DateTime)dynConstraints[2] , (DateTime)dynConstraints[3] , (bool)dynConstraints[4] , (String)dynConstraints[5] , (short)dynConstraints[6] , (DateTime)dynConstraints[7] , (DateTime)dynConstraints[8] , (bool)dynConstraints[9] , (String)dynConstraints[10] , (short)dynConstraints[11] , (DateTime)dynConstraints[12] , (DateTime)dynConstraints[13] , (DateTime)dynConstraints[14] , (short)dynConstraints[15] , (bool)dynConstraints[16] );
               case 1 :
                     return conditional_H00143(context, (String)dynConstraints[0] , (short)dynConstraints[1] , (DateTime)dynConstraints[2] , (DateTime)dynConstraints[3] , (bool)dynConstraints[4] , (String)dynConstraints[5] , (short)dynConstraints[6] , (DateTime)dynConstraints[7] , (DateTime)dynConstraints[8] , (bool)dynConstraints[9] , (String)dynConstraints[10] , (short)dynConstraints[11] , (DateTime)dynConstraints[12] , (DateTime)dynConstraints[13] , (DateTime)dynConstraints[14] , (short)dynConstraints[15] , (bool)dynConstraints[16] );
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
          Object[] prmH00142 ;
          prmH00142 = new Object[] {
          new Object[] {"@AV15PedidoDt1",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV15PedidoDt1",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV15PedidoDt1",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV15PedidoDt1",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV16PedidoDt_To1",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV20PedidoDt2",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV20PedidoDt2",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV20PedidoDt2",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV20PedidoDt2",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV21PedidoDt_To2",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV25PedidoDt3",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV25PedidoDt3",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV25PedidoDt3",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV25PedidoDt3",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV26PedidoDt_To3",SqlDbType.DateTime,8,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00143 ;
          prmH00143 = new Object[] {
          new Object[] {"@AV15PedidoDt1",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV15PedidoDt1",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV15PedidoDt1",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV15PedidoDt1",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV16PedidoDt_To1",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV20PedidoDt2",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV20PedidoDt2",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV20PedidoDt2",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV20PedidoDt2",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV21PedidoDt_To2",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV25PedidoDt3",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV25PedidoDt3",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV25PedidoDt3",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV25PedidoDt3",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV26PedidoDt_To3",SqlDbType.DateTime,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00142", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00142,11, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("H00143", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00143,1, GxCacheFrequency.OFF ,true,false )
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
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.getBool(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
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
                   stmt.SetParameter(sIdx, (DateTime)parms[18]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[19]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[20]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[21]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[22]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[23]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[24]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[25]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[26]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[27]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[28]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[29]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[30]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[31]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[32]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[33]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[34]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[35]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[15]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[16]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[17]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[18]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[19]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[20]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[21]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[22]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[23]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[24]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[25]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[26]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[27]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[28]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[29]);
                }
                return;
       }
    }

 }

}
