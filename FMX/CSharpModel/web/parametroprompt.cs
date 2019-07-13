/*
               File: ParametroPrompt
        Description: Consulta de Parametro
             Author: GeneXus C# Generator version 16_0_2-131213
       Generated on: 7/11/2019 20:45:32.93
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
   public class parametroprompt : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public parametroprompt( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public parametroprompt( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( ref short aP0_InOutParametroID ,
                           ref DateTime aP1_InOutParametroDtVigenciaIni )
      {
         this.AV49InOutParametroID = aP0_InOutParametroID;
         this.AV50InOutParametroDtVigenciaIni = aP1_InOutParametroDtVigenciaIni;
         executePrivate();
         aP0_InOutParametroID=this.AV49InOutParametroID;
         aP1_InOutParametroDtVigenciaIni=this.AV50InOutParametroDtVigenciaIni;
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
         cmbParametroTipo = new GXCombobox();
         cmbParametroPrioritaria = new GXCombobox();
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
               AV15ParametroDtVigenciaIni1 = context.localUtil.ParseDateParm( GetNextPar( ));
               AV16ParametroDtVigenciaIni_To1 = context.localUtil.ParseDateParm( GetNextPar( ));
               AV18DynamicFiltersSelector2 = GetNextPar( );
               AV19DynamicFiltersOperator2 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV20ParametroDtVigenciaIni2 = context.localUtil.ParseDateParm( GetNextPar( ));
               AV21ParametroDtVigenciaIni_To2 = context.localUtil.ParseDateParm( GetNextPar( ));
               AV23DynamicFiltersSelector3 = GetNextPar( );
               AV24DynamicFiltersOperator3 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV25ParametroDtVigenciaIni3 = context.localUtil.ParseDateParm( GetNextPar( ));
               AV26ParametroDtVigenciaIni_To3 = context.localUtil.ParseDateParm( GetNextPar( ));
               AV17DynamicFiltersEnabled2 = StringUtil.StrToBool( GetNextPar( ));
               AV22DynamicFiltersEnabled3 = StringUtil.StrToBool( GetNextPar( ));
               AV11OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV12OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV31ddo_ParametroIDTitleControlIdToReplace = GetNextPar( );
               AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace = GetNextPar( );
               AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace = GetNextPar( );
               AV37ddo_ParametroTipoTitleControlIdToReplace = GetNextPar( );
               AV39ddo_ParametroPrioritariaTitleControlIdToReplace = GetNextPar( );
               AV41ddo_ParametroValorTitleControlIdToReplace = GetNextPar( );
               AV43ddo_ParametroPercentualTitleControlIdToReplace = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15ParametroDtVigenciaIni1, AV16ParametroDtVigenciaIni_To1, AV18DynamicFiltersSelector2, AV19DynamicFiltersOperator2, AV20ParametroDtVigenciaIni2, AV21ParametroDtVigenciaIni_To2, AV23DynamicFiltersSelector3, AV24DynamicFiltersOperator3, AV25ParametroDtVigenciaIni3, AV26ParametroDtVigenciaIni_To3, AV17DynamicFiltersEnabled2, AV22DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV31ddo_ParametroIDTitleControlIdToReplace, AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace, AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace, AV37ddo_ParametroTipoTitleControlIdToReplace, AV39ddo_ParametroPrioritariaTitleControlIdToReplace, AV41ddo_ParametroValorTitleControlIdToReplace, AV43ddo_ParametroPercentualTitleControlIdToReplace) ;
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
               AV49InOutParametroID = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49InOutParametroID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV49InOutParametroID), 4, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV50InOutParametroDtVigenciaIni = context.localUtil.ParseDateParm( GetNextPar( ));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV50InOutParametroDtVigenciaIni", context.localUtil.Format(AV50InOutParametroDtVigenciaIni, "99/99/99"));
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
         PA0W2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0W2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?201971120453327", false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal FormNoBackgroundColor\" data-gx-class=\"form-horizontal FormNoBackgroundColor\" novalidate action=\""+formatLink("parametroprompt.aspx") + "?" + UrlEncode("" +AV49InOutParametroID) + "," + UrlEncode(DateTimeUtil.FormatDateParm(AV50InOutParametroDtVigenciaIni))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vPARAMETRODTVIGENCIAINI1", context.localUtil.Format(AV15ParametroDtVigenciaIni1, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vPARAMETRODTVIGENCIAINI_TO1", context.localUtil.Format(AV16ParametroDtVigenciaIni_To1, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSSELECTOR2", AV18DynamicFiltersSelector2);
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSOPERATOR2", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV19DynamicFiltersOperator2), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vPARAMETRODTVIGENCIAINI2", context.localUtil.Format(AV20ParametroDtVigenciaIni2, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vPARAMETRODTVIGENCIAINI_TO2", context.localUtil.Format(AV21ParametroDtVigenciaIni_To2, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSSELECTOR3", AV23DynamicFiltersSelector3);
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSOPERATOR3", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV24DynamicFiltersOperator3), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vPARAMETRODTVIGENCIAINI3", context.localUtil.Format(AV25ParametroDtVigenciaIni3, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vPARAMETRODTVIGENCIAINI_TO3", context.localUtil.Format(AV26ParametroDtVigenciaIni_To3, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSENABLED2", StringUtil.BoolToStr( AV17DynamicFiltersEnabled2));
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSENABLED3", StringUtil.BoolToStr( AV22DynamicFiltersEnabled3));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11OrderedBy), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV12OrderedDsc));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_119", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_119), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV46GridCurrentPage), 10, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGECOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV47GridPageCount), 10, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV44DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV44DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPARAMETROIDTITLEFILTERDATA", AV30ParametroIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPARAMETROIDTITLEFILTERDATA", AV30ParametroIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPARAMETRODTVIGENCIAINITITLEFILTERDATA", AV32ParametroDtVigenciaIniTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPARAMETRODTVIGENCIAINITITLEFILTERDATA", AV32ParametroDtVigenciaIniTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPARAMETRODTVIGENCIAFIMTITLEFILTERDATA", AV34ParametroDtVigenciaFimTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPARAMETRODTVIGENCIAFIMTITLEFILTERDATA", AV34ParametroDtVigenciaFimTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPARAMETROTIPOTITLEFILTERDATA", AV36ParametroTipoTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPARAMETROTIPOTITLEFILTERDATA", AV36ParametroTipoTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPARAMETROPRIORITARIATITLEFILTERDATA", AV38ParametroPrioritariaTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPARAMETROPRIORITARIATITLEFILTERDATA", AV38ParametroPrioritariaTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPARAMETROVALORTITLEFILTERDATA", AV40ParametroValorTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPARAMETROVALORTITLEFILTERDATA", AV40ParametroValorTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPARAMETROPERCENTUALTITLEFILTERDATA", AV42ParametroPercentualTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPARAMETROPERCENTUALTITLEFILTERDATA", AV42ParametroPercentualTitleFilterData);
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
         GxWebStd.gx_hidden_field( context, "vINOUTPARAMETROID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV49InOutParametroID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vINOUTPARAMETRODTVIGENCIAINI", context.localUtil.DToC( AV50InOutParametroDtVigenciaIni, 0, "/"));
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
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROID_Caption", StringUtil.RTrim( Ddo_parametroid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROID_Tooltip", StringUtil.RTrim( Ddo_parametroid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROID_Cls", StringUtil.RTrim( Ddo_parametroid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROID_Dropdownoptionstype", StringUtil.RTrim( Ddo_parametroid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_parametroid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROID_Includesortasc", StringUtil.BoolToStr( Ddo_parametroid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROID_Includesortdsc", StringUtil.BoolToStr( Ddo_parametroid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROID_Sortedstatus", StringUtil.RTrim( Ddo_parametroid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROID_Includefilter", StringUtil.BoolToStr( Ddo_parametroid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROID_Includedatalist", StringUtil.BoolToStr( Ddo_parametroid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROID_Sortasc", StringUtil.RTrim( Ddo_parametroid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROID_Sortdsc", StringUtil.RTrim( Ddo_parametroid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROID_Cleanfilter", StringUtil.RTrim( Ddo_parametroid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROID_Searchbuttontext", StringUtil.RTrim( Ddo_parametroid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Caption", StringUtil.RTrim( Ddo_parametrodtvigenciaini_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Tooltip", StringUtil.RTrim( Ddo_parametrodtvigenciaini_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Cls", StringUtil.RTrim( Ddo_parametrodtvigenciaini_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Dropdownoptionstype", StringUtil.RTrim( Ddo_parametrodtvigenciaini_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_parametrodtvigenciaini_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Includesortasc", StringUtil.BoolToStr( Ddo_parametrodtvigenciaini_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Includesortdsc", StringUtil.BoolToStr( Ddo_parametrodtvigenciaini_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Sortedstatus", StringUtil.RTrim( Ddo_parametrodtvigenciaini_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Includefilter", StringUtil.BoolToStr( Ddo_parametrodtvigenciaini_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Includedatalist", StringUtil.BoolToStr( Ddo_parametrodtvigenciaini_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Sortasc", StringUtil.RTrim( Ddo_parametrodtvigenciaini_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Sortdsc", StringUtil.RTrim( Ddo_parametrodtvigenciaini_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Cleanfilter", StringUtil.RTrim( Ddo_parametrodtvigenciaini_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Searchbuttontext", StringUtil.RTrim( Ddo_parametrodtvigenciaini_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Caption", StringUtil.RTrim( Ddo_parametrodtvigenciafim_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Tooltip", StringUtil.RTrim( Ddo_parametrodtvigenciafim_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Cls", StringUtil.RTrim( Ddo_parametrodtvigenciafim_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Dropdownoptionstype", StringUtil.RTrim( Ddo_parametrodtvigenciafim_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_parametrodtvigenciafim_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Includesortasc", StringUtil.BoolToStr( Ddo_parametrodtvigenciafim_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Includesortdsc", StringUtil.BoolToStr( Ddo_parametrodtvigenciafim_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Sortedstatus", StringUtil.RTrim( Ddo_parametrodtvigenciafim_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Includefilter", StringUtil.BoolToStr( Ddo_parametrodtvigenciafim_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Includedatalist", StringUtil.BoolToStr( Ddo_parametrodtvigenciafim_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Sortasc", StringUtil.RTrim( Ddo_parametrodtvigenciafim_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Sortdsc", StringUtil.RTrim( Ddo_parametrodtvigenciafim_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Cleanfilter", StringUtil.RTrim( Ddo_parametrodtvigenciafim_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Searchbuttontext", StringUtil.RTrim( Ddo_parametrodtvigenciafim_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Caption", StringUtil.RTrim( Ddo_parametrotipo_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Tooltip", StringUtil.RTrim( Ddo_parametrotipo_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Cls", StringUtil.RTrim( Ddo_parametrotipo_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Dropdownoptionstype", StringUtil.RTrim( Ddo_parametrotipo_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_parametrotipo_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Includesortasc", StringUtil.BoolToStr( Ddo_parametrotipo_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Includesortdsc", StringUtil.BoolToStr( Ddo_parametrotipo_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Sortedstatus", StringUtil.RTrim( Ddo_parametrotipo_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Includefilter", StringUtil.BoolToStr( Ddo_parametrotipo_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Includedatalist", StringUtil.BoolToStr( Ddo_parametrotipo_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Sortasc", StringUtil.RTrim( Ddo_parametrotipo_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Sortdsc", StringUtil.RTrim( Ddo_parametrotipo_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Cleanfilter", StringUtil.RTrim( Ddo_parametrotipo_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Searchbuttontext", StringUtil.RTrim( Ddo_parametrotipo_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Caption", StringUtil.RTrim( Ddo_parametroprioritaria_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Tooltip", StringUtil.RTrim( Ddo_parametroprioritaria_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Cls", StringUtil.RTrim( Ddo_parametroprioritaria_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Dropdownoptionstype", StringUtil.RTrim( Ddo_parametroprioritaria_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_parametroprioritaria_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Includesortasc", StringUtil.BoolToStr( Ddo_parametroprioritaria_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Includesortdsc", StringUtil.BoolToStr( Ddo_parametroprioritaria_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Sortedstatus", StringUtil.RTrim( Ddo_parametroprioritaria_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Includefilter", StringUtil.BoolToStr( Ddo_parametroprioritaria_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Includedatalist", StringUtil.BoolToStr( Ddo_parametroprioritaria_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Sortasc", StringUtil.RTrim( Ddo_parametroprioritaria_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Sortdsc", StringUtil.RTrim( Ddo_parametroprioritaria_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Cleanfilter", StringUtil.RTrim( Ddo_parametroprioritaria_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Searchbuttontext", StringUtil.RTrim( Ddo_parametroprioritaria_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Caption", StringUtil.RTrim( Ddo_parametrovalor_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Tooltip", StringUtil.RTrim( Ddo_parametrovalor_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Cls", StringUtil.RTrim( Ddo_parametrovalor_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Dropdownoptionstype", StringUtil.RTrim( Ddo_parametrovalor_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_parametrovalor_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Includesortasc", StringUtil.BoolToStr( Ddo_parametrovalor_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Includesortdsc", StringUtil.BoolToStr( Ddo_parametrovalor_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Sortedstatus", StringUtil.RTrim( Ddo_parametrovalor_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Includefilter", StringUtil.BoolToStr( Ddo_parametrovalor_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Includedatalist", StringUtil.BoolToStr( Ddo_parametrovalor_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Sortasc", StringUtil.RTrim( Ddo_parametrovalor_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Sortdsc", StringUtil.RTrim( Ddo_parametrovalor_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Cleanfilter", StringUtil.RTrim( Ddo_parametrovalor_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Searchbuttontext", StringUtil.RTrim( Ddo_parametrovalor_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Caption", StringUtil.RTrim( Ddo_parametropercentual_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Tooltip", StringUtil.RTrim( Ddo_parametropercentual_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Cls", StringUtil.RTrim( Ddo_parametropercentual_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Dropdownoptionstype", StringUtil.RTrim( Ddo_parametropercentual_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_parametropercentual_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Includesortasc", StringUtil.BoolToStr( Ddo_parametropercentual_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Includesortdsc", StringUtil.BoolToStr( Ddo_parametropercentual_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Sortedstatus", StringUtil.RTrim( Ddo_parametropercentual_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Includefilter", StringUtil.BoolToStr( Ddo_parametropercentual_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Includedatalist", StringUtil.BoolToStr( Ddo_parametropercentual_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Sortasc", StringUtil.RTrim( Ddo_parametropercentual_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Sortdsc", StringUtil.RTrim( Ddo_parametropercentual_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Cleanfilter", StringUtil.RTrim( Ddo_parametropercentual_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Searchbuttontext", StringUtil.RTrim( Ddo_parametropercentual_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROID_Activeeventkey", StringUtil.RTrim( Ddo_parametroid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Activeeventkey", StringUtil.RTrim( Ddo_parametrodtvigenciaini_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Activeeventkey", StringUtil.RTrim( Ddo_parametrodtvigenciafim_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Activeeventkey", StringUtil.RTrim( Ddo_parametrotipo_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Activeeventkey", StringUtil.RTrim( Ddo_parametroprioritaria_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Activeeventkey", StringUtil.RTrim( Ddo_parametrovalor_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Activeeventkey", StringUtil.RTrim( Ddo_parametropercentual_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROID_Activeeventkey", StringUtil.RTrim( Ddo_parametroid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Activeeventkey", StringUtil.RTrim( Ddo_parametrodtvigenciaini_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Activeeventkey", StringUtil.RTrim( Ddo_parametrodtvigenciafim_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Activeeventkey", StringUtil.RTrim( Ddo_parametrotipo_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Activeeventkey", StringUtil.RTrim( Ddo_parametroprioritaria_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Activeeventkey", StringUtil.RTrim( Ddo_parametrovalor_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Activeeventkey", StringUtil.RTrim( Ddo_parametropercentual_Activeeventkey));
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
            WE0W2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0W2( ) ;
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
         return formatLink("parametroprompt.aspx") + "?" + UrlEncode("" +AV49InOutParametroID) + "," + UrlEncode(DateTimeUtil.FormatDateParm(AV50InOutParametroDtVigenciaIni)) ;
      }

      public override String GetPgmname( )
      {
         return "ParametroPrompt" ;
      }

      public override String GetPgmdesc( )
      {
         return "Consulta de Parametro" ;
      }

      protected void WB0W0( )
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
            wb_table1_14_0W2( true) ;
         }
         else
         {
            wb_table1_14_0W2( false) ;
         }
         return  ;
      }

      protected void wb_table1_14_0W2e( bool wbgen )
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
               if ( edtParametroID_Titleformat == 0 )
               {
                  context.SendWebValue( edtParametroID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtParametroID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtParametroDtVigenciaIni_Titleformat == 0 )
               {
                  context.SendWebValue( edtParametroDtVigenciaIni_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtParametroDtVigenciaIni_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtParametroDtVigenciaFim_Titleformat == 0 )
               {
                  context.SendWebValue( edtParametroDtVigenciaFim_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtParametroDtVigenciaFim_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( cmbParametroTipo_Titleformat == 0 )
               {
                  context.SendWebValue( cmbParametroTipo.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( cmbParametroTipo.Title.Text) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( cmbParametroPrioritaria_Titleformat == 0 )
               {
                  context.SendWebValue( cmbParametroPrioritaria.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( cmbParametroPrioritaria.Title.Text) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtParametroValor_Titleformat == 0 )
               {
                  context.SendWebValue( edtParametroValor_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtParametroValor_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtParametroPercentual_Titleformat == 0 )
               {
                  context.SendWebValue( edtParametroPercentual_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtParametroPercentual_Title) ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV48Select));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavSelect_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A13ParametroID), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtParametroID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtParametroID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A14ParametroDtVigenciaIni, "99/99/99"));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtParametroDtVigenciaIni_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtParametroDtVigenciaIni_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A15ParametroDtVigenciaFim, "99/99/99"));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtParametroDtVigenciaFim_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtParametroDtVigenciaFim_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A16ParametroTipo));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( cmbParametroTipo.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbParametroTipo_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A17ParametroPrioritaria));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( cmbParametroPrioritaria.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbParametroPrioritaria_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A18ParametroValor, 14, 2, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtParametroValor_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtParametroValor_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A19ParametroPercentual, 6, 2, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtParametroPercentual_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtParametroPercentual_Titleformat), 4, 0, ".", "")));
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV46GridCurrentPage);
            ucGridpaginationbar.SetProperty("PageCount", AV47GridPageCount);
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
            GxWebStd.gx_label_ctrl( context, lblJsdynamicfilters_Internalname, lblJsdynamicfilters_Caption, "", "", lblJsdynamicfilters_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "", 0, "", 1, 1, 1, "HLP_ParametroPrompt.htm");
            /* User Defined Control */
            ucDdo_parametroid.SetProperty("Caption", Ddo_parametroid_Caption);
            ucDdo_parametroid.SetProperty("Tooltip", Ddo_parametroid_Tooltip);
            ucDdo_parametroid.SetProperty("Cls", Ddo_parametroid_Cls);
            ucDdo_parametroid.SetProperty("DropDownOptionsType", Ddo_parametroid_Dropdownoptionstype);
            ucDdo_parametroid.SetProperty("IncludeSortASC", Ddo_parametroid_Includesortasc);
            ucDdo_parametroid.SetProperty("IncludeSortDSC", Ddo_parametroid_Includesortdsc);
            ucDdo_parametroid.SetProperty("IncludeFilter", Ddo_parametroid_Includefilter);
            ucDdo_parametroid.SetProperty("IncludeDataList", Ddo_parametroid_Includedatalist);
            ucDdo_parametroid.SetProperty("SortASC", Ddo_parametroid_Sortasc);
            ucDdo_parametroid.SetProperty("SortDSC", Ddo_parametroid_Sortdsc);
            ucDdo_parametroid.SetProperty("CleanFilter", Ddo_parametroid_Cleanfilter);
            ucDdo_parametroid.SetProperty("SearchButtonText", Ddo_parametroid_Searchbuttontext);
            ucDdo_parametroid.SetProperty("DropDownOptionsTitleSettingsIcons", AV44DDO_TitleSettingsIcons);
            ucDdo_parametroid.SetProperty("DropDownOptionsData", AV30ParametroIDTitleFilterData);
            ucDdo_parametroid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_parametroid_Internalname, "DDO_PARAMETROIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 136,'',false,'" + sGXsfl_119_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_parametroidtitlecontrolidtoreplace_Internalname, AV31ddo_ParametroIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,136);\"", 0, edtavDdo_parametroidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_ParametroPrompt.htm");
            /* User Defined Control */
            ucDdo_parametrodtvigenciaini.SetProperty("Caption", Ddo_parametrodtvigenciaini_Caption);
            ucDdo_parametrodtvigenciaini.SetProperty("Tooltip", Ddo_parametrodtvigenciaini_Tooltip);
            ucDdo_parametrodtvigenciaini.SetProperty("Cls", Ddo_parametrodtvigenciaini_Cls);
            ucDdo_parametrodtvigenciaini.SetProperty("DropDownOptionsType", Ddo_parametrodtvigenciaini_Dropdownoptionstype);
            ucDdo_parametrodtvigenciaini.SetProperty("IncludeSortASC", Ddo_parametrodtvigenciaini_Includesortasc);
            ucDdo_parametrodtvigenciaini.SetProperty("IncludeSortDSC", Ddo_parametrodtvigenciaini_Includesortdsc);
            ucDdo_parametrodtvigenciaini.SetProperty("IncludeFilter", Ddo_parametrodtvigenciaini_Includefilter);
            ucDdo_parametrodtvigenciaini.SetProperty("IncludeDataList", Ddo_parametrodtvigenciaini_Includedatalist);
            ucDdo_parametrodtvigenciaini.SetProperty("SortASC", Ddo_parametrodtvigenciaini_Sortasc);
            ucDdo_parametrodtvigenciaini.SetProperty("SortDSC", Ddo_parametrodtvigenciaini_Sortdsc);
            ucDdo_parametrodtvigenciaini.SetProperty("CleanFilter", Ddo_parametrodtvigenciaini_Cleanfilter);
            ucDdo_parametrodtvigenciaini.SetProperty("SearchButtonText", Ddo_parametrodtvigenciaini_Searchbuttontext);
            ucDdo_parametrodtvigenciaini.SetProperty("DropDownOptionsTitleSettingsIcons", AV44DDO_TitleSettingsIcons);
            ucDdo_parametrodtvigenciaini.SetProperty("DropDownOptionsData", AV32ParametroDtVigenciaIniTitleFilterData);
            ucDdo_parametrodtvigenciaini.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_parametrodtvigenciaini_Internalname, "DDO_PARAMETRODTVIGENCIAINIContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 138,'',false,'" + sGXsfl_119_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_parametrodtvigenciainititlecontrolidtoreplace_Internalname, AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,138);\"", 0, edtavDdo_parametrodtvigenciainititlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_ParametroPrompt.htm");
            /* User Defined Control */
            ucDdo_parametrodtvigenciafim.SetProperty("Caption", Ddo_parametrodtvigenciafim_Caption);
            ucDdo_parametrodtvigenciafim.SetProperty("Tooltip", Ddo_parametrodtvigenciafim_Tooltip);
            ucDdo_parametrodtvigenciafim.SetProperty("Cls", Ddo_parametrodtvigenciafim_Cls);
            ucDdo_parametrodtvigenciafim.SetProperty("DropDownOptionsType", Ddo_parametrodtvigenciafim_Dropdownoptionstype);
            ucDdo_parametrodtvigenciafim.SetProperty("IncludeSortASC", Ddo_parametrodtvigenciafim_Includesortasc);
            ucDdo_parametrodtvigenciafim.SetProperty("IncludeSortDSC", Ddo_parametrodtvigenciafim_Includesortdsc);
            ucDdo_parametrodtvigenciafim.SetProperty("IncludeFilter", Ddo_parametrodtvigenciafim_Includefilter);
            ucDdo_parametrodtvigenciafim.SetProperty("IncludeDataList", Ddo_parametrodtvigenciafim_Includedatalist);
            ucDdo_parametrodtvigenciafim.SetProperty("SortASC", Ddo_parametrodtvigenciafim_Sortasc);
            ucDdo_parametrodtvigenciafim.SetProperty("SortDSC", Ddo_parametrodtvigenciafim_Sortdsc);
            ucDdo_parametrodtvigenciafim.SetProperty("CleanFilter", Ddo_parametrodtvigenciafim_Cleanfilter);
            ucDdo_parametrodtvigenciafim.SetProperty("SearchButtonText", Ddo_parametrodtvigenciafim_Searchbuttontext);
            ucDdo_parametrodtvigenciafim.SetProperty("DropDownOptionsTitleSettingsIcons", AV44DDO_TitleSettingsIcons);
            ucDdo_parametrodtvigenciafim.SetProperty("DropDownOptionsData", AV34ParametroDtVigenciaFimTitleFilterData);
            ucDdo_parametrodtvigenciafim.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_parametrodtvigenciafim_Internalname, "DDO_PARAMETRODTVIGENCIAFIMContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 140,'',false,'" + sGXsfl_119_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_parametrodtvigenciafimtitlecontrolidtoreplace_Internalname, AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,140);\"", 0, edtavDdo_parametrodtvigenciafimtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_ParametroPrompt.htm");
            /* User Defined Control */
            ucDdo_parametrotipo.SetProperty("Caption", Ddo_parametrotipo_Caption);
            ucDdo_parametrotipo.SetProperty("Tooltip", Ddo_parametrotipo_Tooltip);
            ucDdo_parametrotipo.SetProperty("Cls", Ddo_parametrotipo_Cls);
            ucDdo_parametrotipo.SetProperty("DropDownOptionsType", Ddo_parametrotipo_Dropdownoptionstype);
            ucDdo_parametrotipo.SetProperty("IncludeSortASC", Ddo_parametrotipo_Includesortasc);
            ucDdo_parametrotipo.SetProperty("IncludeSortDSC", Ddo_parametrotipo_Includesortdsc);
            ucDdo_parametrotipo.SetProperty("IncludeFilter", Ddo_parametrotipo_Includefilter);
            ucDdo_parametrotipo.SetProperty("IncludeDataList", Ddo_parametrotipo_Includedatalist);
            ucDdo_parametrotipo.SetProperty("SortASC", Ddo_parametrotipo_Sortasc);
            ucDdo_parametrotipo.SetProperty("SortDSC", Ddo_parametrotipo_Sortdsc);
            ucDdo_parametrotipo.SetProperty("CleanFilter", Ddo_parametrotipo_Cleanfilter);
            ucDdo_parametrotipo.SetProperty("SearchButtonText", Ddo_parametrotipo_Searchbuttontext);
            ucDdo_parametrotipo.SetProperty("DropDownOptionsTitleSettingsIcons", AV44DDO_TitleSettingsIcons);
            ucDdo_parametrotipo.SetProperty("DropDownOptionsData", AV36ParametroTipoTitleFilterData);
            ucDdo_parametrotipo.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_parametrotipo_Internalname, "DDO_PARAMETROTIPOContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 142,'',false,'" + sGXsfl_119_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_parametrotipotitlecontrolidtoreplace_Internalname, AV37ddo_ParametroTipoTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,142);\"", 0, edtavDdo_parametrotipotitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_ParametroPrompt.htm");
            /* User Defined Control */
            ucDdo_parametroprioritaria.SetProperty("Caption", Ddo_parametroprioritaria_Caption);
            ucDdo_parametroprioritaria.SetProperty("Tooltip", Ddo_parametroprioritaria_Tooltip);
            ucDdo_parametroprioritaria.SetProperty("Cls", Ddo_parametroprioritaria_Cls);
            ucDdo_parametroprioritaria.SetProperty("DropDownOptionsType", Ddo_parametroprioritaria_Dropdownoptionstype);
            ucDdo_parametroprioritaria.SetProperty("IncludeSortASC", Ddo_parametroprioritaria_Includesortasc);
            ucDdo_parametroprioritaria.SetProperty("IncludeSortDSC", Ddo_parametroprioritaria_Includesortdsc);
            ucDdo_parametroprioritaria.SetProperty("IncludeFilter", Ddo_parametroprioritaria_Includefilter);
            ucDdo_parametroprioritaria.SetProperty("IncludeDataList", Ddo_parametroprioritaria_Includedatalist);
            ucDdo_parametroprioritaria.SetProperty("SortASC", Ddo_parametroprioritaria_Sortasc);
            ucDdo_parametroprioritaria.SetProperty("SortDSC", Ddo_parametroprioritaria_Sortdsc);
            ucDdo_parametroprioritaria.SetProperty("CleanFilter", Ddo_parametroprioritaria_Cleanfilter);
            ucDdo_parametroprioritaria.SetProperty("SearchButtonText", Ddo_parametroprioritaria_Searchbuttontext);
            ucDdo_parametroprioritaria.SetProperty("DropDownOptionsTitleSettingsIcons", AV44DDO_TitleSettingsIcons);
            ucDdo_parametroprioritaria.SetProperty("DropDownOptionsData", AV38ParametroPrioritariaTitleFilterData);
            ucDdo_parametroprioritaria.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_parametroprioritaria_Internalname, "DDO_PARAMETROPRIORITARIAContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 144,'',false,'" + sGXsfl_119_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_parametroprioritariatitlecontrolidtoreplace_Internalname, AV39ddo_ParametroPrioritariaTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,144);\"", 0, edtavDdo_parametroprioritariatitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_ParametroPrompt.htm");
            /* User Defined Control */
            ucDdo_parametrovalor.SetProperty("Caption", Ddo_parametrovalor_Caption);
            ucDdo_parametrovalor.SetProperty("Tooltip", Ddo_parametrovalor_Tooltip);
            ucDdo_parametrovalor.SetProperty("Cls", Ddo_parametrovalor_Cls);
            ucDdo_parametrovalor.SetProperty("DropDownOptionsType", Ddo_parametrovalor_Dropdownoptionstype);
            ucDdo_parametrovalor.SetProperty("IncludeSortASC", Ddo_parametrovalor_Includesortasc);
            ucDdo_parametrovalor.SetProperty("IncludeSortDSC", Ddo_parametrovalor_Includesortdsc);
            ucDdo_parametrovalor.SetProperty("IncludeFilter", Ddo_parametrovalor_Includefilter);
            ucDdo_parametrovalor.SetProperty("IncludeDataList", Ddo_parametrovalor_Includedatalist);
            ucDdo_parametrovalor.SetProperty("SortASC", Ddo_parametrovalor_Sortasc);
            ucDdo_parametrovalor.SetProperty("SortDSC", Ddo_parametrovalor_Sortdsc);
            ucDdo_parametrovalor.SetProperty("CleanFilter", Ddo_parametrovalor_Cleanfilter);
            ucDdo_parametrovalor.SetProperty("SearchButtonText", Ddo_parametrovalor_Searchbuttontext);
            ucDdo_parametrovalor.SetProperty("DropDownOptionsTitleSettingsIcons", AV44DDO_TitleSettingsIcons);
            ucDdo_parametrovalor.SetProperty("DropDownOptionsData", AV40ParametroValorTitleFilterData);
            ucDdo_parametrovalor.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_parametrovalor_Internalname, "DDO_PARAMETROVALORContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 146,'',false,'" + sGXsfl_119_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_parametrovalortitlecontrolidtoreplace_Internalname, AV41ddo_ParametroValorTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,146);\"", 0, edtavDdo_parametrovalortitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_ParametroPrompt.htm");
            /* User Defined Control */
            ucDdo_parametropercentual.SetProperty("Caption", Ddo_parametropercentual_Caption);
            ucDdo_parametropercentual.SetProperty("Tooltip", Ddo_parametropercentual_Tooltip);
            ucDdo_parametropercentual.SetProperty("Cls", Ddo_parametropercentual_Cls);
            ucDdo_parametropercentual.SetProperty("DropDownOptionsType", Ddo_parametropercentual_Dropdownoptionstype);
            ucDdo_parametropercentual.SetProperty("IncludeSortASC", Ddo_parametropercentual_Includesortasc);
            ucDdo_parametropercentual.SetProperty("IncludeSortDSC", Ddo_parametropercentual_Includesortdsc);
            ucDdo_parametropercentual.SetProperty("IncludeFilter", Ddo_parametropercentual_Includefilter);
            ucDdo_parametropercentual.SetProperty("IncludeDataList", Ddo_parametropercentual_Includedatalist);
            ucDdo_parametropercentual.SetProperty("SortASC", Ddo_parametropercentual_Sortasc);
            ucDdo_parametropercentual.SetProperty("SortDSC", Ddo_parametropercentual_Sortdsc);
            ucDdo_parametropercentual.SetProperty("CleanFilter", Ddo_parametropercentual_Cleanfilter);
            ucDdo_parametropercentual.SetProperty("SearchButtonText", Ddo_parametropercentual_Searchbuttontext);
            ucDdo_parametropercentual.SetProperty("DropDownOptionsTitleSettingsIcons", AV44DDO_TitleSettingsIcons);
            ucDdo_parametropercentual.SetProperty("DropDownOptionsData", AV42ParametroPercentualTitleFilterData);
            ucDdo_parametropercentual.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_parametropercentual_Internalname, "DDO_PARAMETROPERCENTUALContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 148,'',false,'" + sGXsfl_119_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_parametropercentualtitlecontrolidtoreplace_Internalname, AV43ddo_ParametroPercentualTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,148);\"", 0, edtavDdo_parametropercentualtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_ParametroPrompt.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities_f5", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 150,'',false,'" + sGXsfl_119_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavDynamicfiltersenabled2_Internalname, StringUtil.BoolToStr( AV17DynamicFiltersEnabled2), "", "", chkavDynamicfiltersenabled2.Visible, 1, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(150, this, 'true', 'false');gx.evt.onchange(this, event);\" ");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 151,'',false,'" + sGXsfl_119_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavDynamicfiltersenabled3_Internalname, StringUtil.BoolToStr( AV22DynamicFiltersEnabled3), "", "", chkavDynamicfiltersenabled3.Visible, 1, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(151, this, 'true', 'false');gx.evt.onchange(this, event);\" ");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 152,'',false,'" + sGXsfl_119_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11OrderedBy), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,152);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ParametroPrompt.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 153,'',false,'" + sGXsfl_119_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV12OrderedDsc), StringUtil.BoolToStr( AV12OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,153);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_ParametroPrompt.htm");
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

      protected void START0W2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_2-131213", 0) ;
            Form.Meta.addItem("description", "Consulta de Parametro", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP0W0( ) ;
      }

      protected void WS0W2( )
      {
         START0W2( ) ;
         EVT0W2( ) ;
      }

      protected void EVT0W2( )
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
                              E110W2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E120W2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PARAMETROID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E130W2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PARAMETRODTVIGENCIAINI.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E140W2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PARAMETRODTVIGENCIAFIM.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E150W2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PARAMETROTIPO.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E160W2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PARAMETROPRIORITARIA.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E170W2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PARAMETROVALOR.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E180W2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PARAMETROPERCENTUAL.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E190W2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'REMOVEDYNAMICFILTERS1'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'RemoveDynamicFilters1' */
                              E200W2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'REMOVEDYNAMICFILTERS2'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'RemoveDynamicFilters2' */
                              E210W2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'REMOVEDYNAMICFILTERS3'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'RemoveDynamicFilters3' */
                              E220W2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOCLEANFILTERS'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoCleanFilters' */
                              E230W2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'ADDDYNAMICFILTERS1'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'AddDynamicFilters1' */
                              E240W2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VDYNAMICFILTERSSELECTOR1.CLICK") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E250W2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VDYNAMICFILTERSOPERATOR1.CLICK") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E260W2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'ADDDYNAMICFILTERS2'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'AddDynamicFilters2' */
                              E270W2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VDYNAMICFILTERSSELECTOR2.CLICK") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E280W2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VDYNAMICFILTERSOPERATOR2.CLICK") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E290W2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VDYNAMICFILTERSSELECTOR3.CLICK") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E300W2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VDYNAMICFILTERSOPERATOR3.CLICK") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E310W2 ();
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
                              AV48Select = cgiGet( edtavSelect_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV48Select)) ? AV53Select_GXI : context.convertURL( context.PathToRelativeUrl( AV48Select))), !bGXsfl_119_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "SrcSet", context.GetImageSrcSet( AV48Select), true);
                              A13ParametroID = (short)(context.localUtil.CToN( cgiGet( edtParametroID_Internalname), ",", "."));
                              A14ParametroDtVigenciaIni = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtParametroDtVigenciaIni_Internalname), 0));
                              A15ParametroDtVigenciaFim = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtParametroDtVigenciaFim_Internalname), 0));
                              cmbParametroTipo.Name = cmbParametroTipo_Internalname;
                              cmbParametroTipo.CurrentValue = cgiGet( cmbParametroTipo_Internalname);
                              A16ParametroTipo = cgiGet( cmbParametroTipo_Internalname);
                              cmbParametroPrioritaria.Name = cmbParametroPrioritaria_Internalname;
                              cmbParametroPrioritaria.CurrentValue = cgiGet( cmbParametroPrioritaria_Internalname);
                              A17ParametroPrioritaria = cgiGet( cmbParametroPrioritaria_Internalname);
                              A18ParametroValor = context.localUtil.CToN( cgiGet( edtParametroValor_Internalname), ",", ".");
                              A19ParametroPercentual = context.localUtil.CToN( cgiGet( edtParametroPercentual_Internalname), ",", ".");
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E320W2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E330W2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E340W2 ();
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
                                       /* Set Refresh If Parametrodtvigenciaini1 Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vPARAMETRODTVIGENCIAINI1"), 0) != AV15ParametroDtVigenciaIni1 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Parametrodtvigenciaini_to1 Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vPARAMETRODTVIGENCIAINI_TO1"), 0) != AV16ParametroDtVigenciaIni_To1 )
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
                                       /* Set Refresh If Parametrodtvigenciaini2 Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vPARAMETRODTVIGENCIAINI2"), 0) != AV20ParametroDtVigenciaIni2 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Parametrodtvigenciaini_to2 Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vPARAMETRODTVIGENCIAINI_TO2"), 0) != AV21ParametroDtVigenciaIni_To2 )
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
                                       /* Set Refresh If Parametrodtvigenciaini3 Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vPARAMETRODTVIGENCIAINI3"), 0) != AV25ParametroDtVigenciaIni3 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Parametrodtvigenciaini_to3 Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vPARAMETRODTVIGENCIAINI_TO3"), 0) != AV26ParametroDtVigenciaIni_To3 )
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
                                          E350W2 ();
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

      protected void WE0W2( )
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

      protected void PA0W2( )
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
                                       DateTime AV15ParametroDtVigenciaIni1 ,
                                       DateTime AV16ParametroDtVigenciaIni_To1 ,
                                       String AV18DynamicFiltersSelector2 ,
                                       short AV19DynamicFiltersOperator2 ,
                                       DateTime AV20ParametroDtVigenciaIni2 ,
                                       DateTime AV21ParametroDtVigenciaIni_To2 ,
                                       String AV23DynamicFiltersSelector3 ,
                                       short AV24DynamicFiltersOperator3 ,
                                       DateTime AV25ParametroDtVigenciaIni3 ,
                                       DateTime AV26ParametroDtVigenciaIni_To3 ,
                                       bool AV17DynamicFiltersEnabled2 ,
                                       bool AV22DynamicFiltersEnabled3 ,
                                       short AV11OrderedBy ,
                                       bool AV12OrderedDsc ,
                                       String AV31ddo_ParametroIDTitleControlIdToReplace ,
                                       String AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace ,
                                       String AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace ,
                                       String AV37ddo_ParametroTipoTitleControlIdToReplace ,
                                       String AV39ddo_ParametroPrioritariaTitleControlIdToReplace ,
                                       String AV41ddo_ParametroValorTitleControlIdToReplace ,
                                       String AV43ddo_ParametroPercentualTitleControlIdToReplace )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF0W2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_PARAMETROID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A13ParametroID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "PARAMETROID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A13ParametroID), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_PARAMETRODTVIGENCIAINI", GetSecureSignedToken( "", A14ParametroDtVigenciaIni, context));
         GxWebStd.gx_hidden_field( context, "PARAMETRODTVIGENCIAINI", context.localUtil.Format(A14ParametroDtVigenciaIni, "99/99/99"));
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
         RF0W2( ) ;
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

      protected void RF0W2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 119;
         /* Execute user event: Refresh */
         E330W2 ();
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
                                                 AV15ParametroDtVigenciaIni1 ,
                                                 AV16ParametroDtVigenciaIni_To1 ,
                                                 AV17DynamicFiltersEnabled2 ,
                                                 AV18DynamicFiltersSelector2 ,
                                                 AV19DynamicFiltersOperator2 ,
                                                 AV20ParametroDtVigenciaIni2 ,
                                                 AV21ParametroDtVigenciaIni_To2 ,
                                                 AV22DynamicFiltersEnabled3 ,
                                                 AV23DynamicFiltersSelector3 ,
                                                 AV24DynamicFiltersOperator3 ,
                                                 AV25ParametroDtVigenciaIni3 ,
                                                 AV26ParametroDtVigenciaIni_To3 ,
                                                 A14ParametroDtVigenciaIni ,
                                                 AV11OrderedBy ,
                                                 AV12OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.BOOLEAN,
                                                 TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            /* Using cursor H000W2 */
            pr_default.execute(0, new Object[] {AV15ParametroDtVigenciaIni1, AV15ParametroDtVigenciaIni1, AV15ParametroDtVigenciaIni1, AV15ParametroDtVigenciaIni1, AV16ParametroDtVigenciaIni_To1, AV20ParametroDtVigenciaIni2, AV20ParametroDtVigenciaIni2, AV20ParametroDtVigenciaIni2, AV20ParametroDtVigenciaIni2, AV21ParametroDtVigenciaIni_To2, AV25ParametroDtVigenciaIni3, AV25ParametroDtVigenciaIni3, AV25ParametroDtVigenciaIni3, AV25ParametroDtVigenciaIni3, AV26ParametroDtVigenciaIni_To3, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_119_idx = 1;
            sGXsfl_119_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_119_idx), 4, 0)), 4, "0");
            SubsflControlProps_1192( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A19ParametroPercentual = H000W2_A19ParametroPercentual[0];
               A18ParametroValor = H000W2_A18ParametroValor[0];
               A17ParametroPrioritaria = H000W2_A17ParametroPrioritaria[0];
               A16ParametroTipo = H000W2_A16ParametroTipo[0];
               A15ParametroDtVigenciaFim = H000W2_A15ParametroDtVigenciaFim[0];
               A14ParametroDtVigenciaIni = H000W2_A14ParametroDtVigenciaIni[0];
               A13ParametroID = H000W2_A13ParametroID[0];
               E340W2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 119;
            WB0W0( ) ;
         }
         bGXsfl_119_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes0W2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_PARAMETROID"+"_"+sGXsfl_119_idx, GetSecureSignedToken( sGXsfl_119_idx, context.localUtil.Format( (decimal)(A13ParametroID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_PARAMETRODTVIGENCIAINI"+"_"+sGXsfl_119_idx, GetSecureSignedToken( sGXsfl_119_idx, A14ParametroDtVigenciaIni, context));
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
                                              AV15ParametroDtVigenciaIni1 ,
                                              AV16ParametroDtVigenciaIni_To1 ,
                                              AV17DynamicFiltersEnabled2 ,
                                              AV18DynamicFiltersSelector2 ,
                                              AV19DynamicFiltersOperator2 ,
                                              AV20ParametroDtVigenciaIni2 ,
                                              AV21ParametroDtVigenciaIni_To2 ,
                                              AV22DynamicFiltersEnabled3 ,
                                              AV23DynamicFiltersSelector3 ,
                                              AV24DynamicFiltersOperator3 ,
                                              AV25ParametroDtVigenciaIni3 ,
                                              AV26ParametroDtVigenciaIni_To3 ,
                                              A14ParametroDtVigenciaIni ,
                                              AV11OrderedBy ,
                                              AV12OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         /* Using cursor H000W3 */
         pr_default.execute(1, new Object[] {AV15ParametroDtVigenciaIni1, AV15ParametroDtVigenciaIni1, AV15ParametroDtVigenciaIni1, AV15ParametroDtVigenciaIni1, AV16ParametroDtVigenciaIni_To1, AV20ParametroDtVigenciaIni2, AV20ParametroDtVigenciaIni2, AV20ParametroDtVigenciaIni2, AV20ParametroDtVigenciaIni2, AV21ParametroDtVigenciaIni_To2, AV25ParametroDtVigenciaIni3, AV25ParametroDtVigenciaIni3, AV25ParametroDtVigenciaIni3, AV25ParametroDtVigenciaIni3, AV26ParametroDtVigenciaIni_To3});
         GRID_nRecordCount = H000W3_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15ParametroDtVigenciaIni1, AV16ParametroDtVigenciaIni_To1, AV18DynamicFiltersSelector2, AV19DynamicFiltersOperator2, AV20ParametroDtVigenciaIni2, AV21ParametroDtVigenciaIni_To2, AV23DynamicFiltersSelector3, AV24DynamicFiltersOperator3, AV25ParametroDtVigenciaIni3, AV26ParametroDtVigenciaIni_To3, AV17DynamicFiltersEnabled2, AV22DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV31ddo_ParametroIDTitleControlIdToReplace, AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace, AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace, AV37ddo_ParametroTipoTitleControlIdToReplace, AV39ddo_ParametroPrioritariaTitleControlIdToReplace, AV41ddo_ParametroValorTitleControlIdToReplace, AV43ddo_ParametroPercentualTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15ParametroDtVigenciaIni1, AV16ParametroDtVigenciaIni_To1, AV18DynamicFiltersSelector2, AV19DynamicFiltersOperator2, AV20ParametroDtVigenciaIni2, AV21ParametroDtVigenciaIni_To2, AV23DynamicFiltersSelector3, AV24DynamicFiltersOperator3, AV25ParametroDtVigenciaIni3, AV26ParametroDtVigenciaIni_To3, AV17DynamicFiltersEnabled2, AV22DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV31ddo_ParametroIDTitleControlIdToReplace, AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace, AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace, AV37ddo_ParametroTipoTitleControlIdToReplace, AV39ddo_ParametroPrioritariaTitleControlIdToReplace, AV41ddo_ParametroValorTitleControlIdToReplace, AV43ddo_ParametroPercentualTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15ParametroDtVigenciaIni1, AV16ParametroDtVigenciaIni_To1, AV18DynamicFiltersSelector2, AV19DynamicFiltersOperator2, AV20ParametroDtVigenciaIni2, AV21ParametroDtVigenciaIni_To2, AV23DynamicFiltersSelector3, AV24DynamicFiltersOperator3, AV25ParametroDtVigenciaIni3, AV26ParametroDtVigenciaIni_To3, AV17DynamicFiltersEnabled2, AV22DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV31ddo_ParametroIDTitleControlIdToReplace, AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace, AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace, AV37ddo_ParametroTipoTitleControlIdToReplace, AV39ddo_ParametroPrioritariaTitleControlIdToReplace, AV41ddo_ParametroValorTitleControlIdToReplace, AV43ddo_ParametroPercentualTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15ParametroDtVigenciaIni1, AV16ParametroDtVigenciaIni_To1, AV18DynamicFiltersSelector2, AV19DynamicFiltersOperator2, AV20ParametroDtVigenciaIni2, AV21ParametroDtVigenciaIni_To2, AV23DynamicFiltersSelector3, AV24DynamicFiltersOperator3, AV25ParametroDtVigenciaIni3, AV26ParametroDtVigenciaIni_To3, AV17DynamicFiltersEnabled2, AV22DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV31ddo_ParametroIDTitleControlIdToReplace, AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace, AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace, AV37ddo_ParametroTipoTitleControlIdToReplace, AV39ddo_ParametroPrioritariaTitleControlIdToReplace, AV41ddo_ParametroValorTitleControlIdToReplace, AV43ddo_ParametroPercentualTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15ParametroDtVigenciaIni1, AV16ParametroDtVigenciaIni_To1, AV18DynamicFiltersSelector2, AV19DynamicFiltersOperator2, AV20ParametroDtVigenciaIni2, AV21ParametroDtVigenciaIni_To2, AV23DynamicFiltersSelector3, AV24DynamicFiltersOperator3, AV25ParametroDtVigenciaIni3, AV26ParametroDtVigenciaIni_To3, AV17DynamicFiltersEnabled2, AV22DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV31ddo_ParametroIDTitleControlIdToReplace, AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace, AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace, AV37ddo_ParametroTipoTitleControlIdToReplace, AV39ddo_ParametroPrioritariaTitleControlIdToReplace, AV41ddo_ParametroValorTitleControlIdToReplace, AV43ddo_ParametroPercentualTitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP0W0( )
      {
         /* Before Start, stand alone formulas. */
         Gx_date = DateTimeUtil.Today( context);
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E320W2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV44DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vPARAMETROIDTITLEFILTERDATA"), AV30ParametroIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPARAMETRODTVIGENCIAINITITLEFILTERDATA"), AV32ParametroDtVigenciaIniTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPARAMETRODTVIGENCIAFIMTITLEFILTERDATA"), AV34ParametroDtVigenciaFimTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPARAMETROTIPOTITLEFILTERDATA"), AV36ParametroTipoTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPARAMETROPRIORITARIATITLEFILTERDATA"), AV38ParametroPrioritariaTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPARAMETROVALORTITLEFILTERDATA"), AV40ParametroValorTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPARAMETROPERCENTUALTITLEFILTERDATA"), AV42ParametroPercentualTitleFilterData);
            /* Read variables values. */
            cmbavDynamicfiltersselector1.Name = cmbavDynamicfiltersselector1_Internalname;
            cmbavDynamicfiltersselector1.CurrentValue = cgiGet( cmbavDynamicfiltersselector1_Internalname);
            AV13DynamicFiltersSelector1 = cgiGet( cmbavDynamicfiltersselector1_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13DynamicFiltersSelector1", AV13DynamicFiltersSelector1);
            cmbavDynamicfiltersoperator1.Name = cmbavDynamicfiltersoperator1_Internalname;
            cmbavDynamicfiltersoperator1.CurrentValue = cgiGet( cmbavDynamicfiltersoperator1_Internalname);
            AV14DynamicFiltersOperator1 = (short)(NumberUtil.Val( cgiGet( cmbavDynamicfiltersoperator1_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14DynamicFiltersOperator1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0)));
            if ( context.localUtil.VCDate( cgiGet( edtavParametrodtvigenciaini1_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Parametro Dt Vigencia Ini1"}), 1, "vPARAMETRODTVIGENCIAINI1");
               GX_FocusControl = edtavParametrodtvigenciaini1_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV15ParametroDtVigenciaIni1 = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15ParametroDtVigenciaIni1", context.localUtil.Format(AV15ParametroDtVigenciaIni1, "99/99/99"));
            }
            else
            {
               AV15ParametroDtVigenciaIni1 = context.localUtil.CToD( cgiGet( edtavParametrodtvigenciaini1_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15ParametroDtVigenciaIni1", context.localUtil.Format(AV15ParametroDtVigenciaIni1, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavParametrodtvigenciaini_to1_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Parametro Dt Vigencia Ini_To1"}), 1, "vPARAMETRODTVIGENCIAINI_TO1");
               GX_FocusControl = edtavParametrodtvigenciaini_to1_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV16ParametroDtVigenciaIni_To1 = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ParametroDtVigenciaIni_To1", context.localUtil.Format(AV16ParametroDtVigenciaIni_To1, "99/99/99"));
            }
            else
            {
               AV16ParametroDtVigenciaIni_To1 = context.localUtil.CToD( cgiGet( edtavParametrodtvigenciaini_to1_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ParametroDtVigenciaIni_To1", context.localUtil.Format(AV16ParametroDtVigenciaIni_To1, "99/99/99"));
            }
            cmbavDynamicfiltersselector2.Name = cmbavDynamicfiltersselector2_Internalname;
            cmbavDynamicfiltersselector2.CurrentValue = cgiGet( cmbavDynamicfiltersselector2_Internalname);
            AV18DynamicFiltersSelector2 = cgiGet( cmbavDynamicfiltersselector2_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18DynamicFiltersSelector2", AV18DynamicFiltersSelector2);
            cmbavDynamicfiltersoperator2.Name = cmbavDynamicfiltersoperator2_Internalname;
            cmbavDynamicfiltersoperator2.CurrentValue = cgiGet( cmbavDynamicfiltersoperator2_Internalname);
            AV19DynamicFiltersOperator2 = (short)(NumberUtil.Val( cgiGet( cmbavDynamicfiltersoperator2_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19DynamicFiltersOperator2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0)));
            if ( context.localUtil.VCDate( cgiGet( edtavParametrodtvigenciaini2_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Parametro Dt Vigencia Ini2"}), 1, "vPARAMETRODTVIGENCIAINI2");
               GX_FocusControl = edtavParametrodtvigenciaini2_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV20ParametroDtVigenciaIni2 = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ParametroDtVigenciaIni2", context.localUtil.Format(AV20ParametroDtVigenciaIni2, "99/99/99"));
            }
            else
            {
               AV20ParametroDtVigenciaIni2 = context.localUtil.CToD( cgiGet( edtavParametrodtvigenciaini2_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ParametroDtVigenciaIni2", context.localUtil.Format(AV20ParametroDtVigenciaIni2, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavParametrodtvigenciaini_to2_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Parametro Dt Vigencia Ini_To2"}), 1, "vPARAMETRODTVIGENCIAINI_TO2");
               GX_FocusControl = edtavParametrodtvigenciaini_to2_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV21ParametroDtVigenciaIni_To2 = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21ParametroDtVigenciaIni_To2", context.localUtil.Format(AV21ParametroDtVigenciaIni_To2, "99/99/99"));
            }
            else
            {
               AV21ParametroDtVigenciaIni_To2 = context.localUtil.CToD( cgiGet( edtavParametrodtvigenciaini_to2_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21ParametroDtVigenciaIni_To2", context.localUtil.Format(AV21ParametroDtVigenciaIni_To2, "99/99/99"));
            }
            cmbavDynamicfiltersselector3.Name = cmbavDynamicfiltersselector3_Internalname;
            cmbavDynamicfiltersselector3.CurrentValue = cgiGet( cmbavDynamicfiltersselector3_Internalname);
            AV23DynamicFiltersSelector3 = cgiGet( cmbavDynamicfiltersselector3_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23DynamicFiltersSelector3", AV23DynamicFiltersSelector3);
            cmbavDynamicfiltersoperator3.Name = cmbavDynamicfiltersoperator3_Internalname;
            cmbavDynamicfiltersoperator3.CurrentValue = cgiGet( cmbavDynamicfiltersoperator3_Internalname);
            AV24DynamicFiltersOperator3 = (short)(NumberUtil.Val( cgiGet( cmbavDynamicfiltersoperator3_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24DynamicFiltersOperator3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0)));
            if ( context.localUtil.VCDate( cgiGet( edtavParametrodtvigenciaini3_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Parametro Dt Vigencia Ini3"}), 1, "vPARAMETRODTVIGENCIAINI3");
               GX_FocusControl = edtavParametrodtvigenciaini3_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV25ParametroDtVigenciaIni3 = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25ParametroDtVigenciaIni3", context.localUtil.Format(AV25ParametroDtVigenciaIni3, "99/99/99"));
            }
            else
            {
               AV25ParametroDtVigenciaIni3 = context.localUtil.CToD( cgiGet( edtavParametrodtvigenciaini3_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25ParametroDtVigenciaIni3", context.localUtil.Format(AV25ParametroDtVigenciaIni3, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavParametrodtvigenciaini_to3_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Parametro Dt Vigencia Ini_To3"}), 1, "vPARAMETRODTVIGENCIAINI_TO3");
               GX_FocusControl = edtavParametrodtvigenciaini_to3_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV26ParametroDtVigenciaIni_To3 = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26ParametroDtVigenciaIni_To3", context.localUtil.Format(AV26ParametroDtVigenciaIni_To3, "99/99/99"));
            }
            else
            {
               AV26ParametroDtVigenciaIni_To3 = context.localUtil.CToD( cgiGet( edtavParametrodtvigenciaini_to3_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26ParametroDtVigenciaIni_To3", context.localUtil.Format(AV26ParametroDtVigenciaIni_To3, "99/99/99"));
            }
            AV31ddo_ParametroIDTitleControlIdToReplace = cgiGet( edtavDdo_parametroidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_ParametroIDTitleControlIdToReplace", AV31ddo_ParametroIDTitleControlIdToReplace);
            AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace = cgiGet( edtavDdo_parametrodtvigenciainititlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace", AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace);
            AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace = cgiGet( edtavDdo_parametrodtvigenciafimtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace", AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace);
            AV37ddo_ParametroTipoTitleControlIdToReplace = cgiGet( edtavDdo_parametrotipotitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37ddo_ParametroTipoTitleControlIdToReplace", AV37ddo_ParametroTipoTitleControlIdToReplace);
            AV39ddo_ParametroPrioritariaTitleControlIdToReplace = cgiGet( edtavDdo_parametroprioritariatitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39ddo_ParametroPrioritariaTitleControlIdToReplace", AV39ddo_ParametroPrioritariaTitleControlIdToReplace);
            AV41ddo_ParametroValorTitleControlIdToReplace = cgiGet( edtavDdo_parametrovalortitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41ddo_ParametroValorTitleControlIdToReplace", AV41ddo_ParametroValorTitleControlIdToReplace);
            AV43ddo_ParametroPercentualTitleControlIdToReplace = cgiGet( edtavDdo_parametropercentualtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43ddo_ParametroPercentualTitleControlIdToReplace", AV43ddo_ParametroPercentualTitleControlIdToReplace);
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
            AV46GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ",", "."));
            AV47GridPageCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGECOUNT"), ",", "."));
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
            Ddo_parametroid_Caption = cgiGet( "DDO_PARAMETROID_Caption");
            Ddo_parametroid_Tooltip = cgiGet( "DDO_PARAMETROID_Tooltip");
            Ddo_parametroid_Cls = cgiGet( "DDO_PARAMETROID_Cls");
            Ddo_parametroid_Dropdownoptionstype = cgiGet( "DDO_PARAMETROID_Dropdownoptionstype");
            Ddo_parametroid_Titlecontrolidtoreplace = cgiGet( "DDO_PARAMETROID_Titlecontrolidtoreplace");
            Ddo_parametroid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROID_Includesortasc"));
            Ddo_parametroid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROID_Includesortdsc"));
            Ddo_parametroid_Sortedstatus = cgiGet( "DDO_PARAMETROID_Sortedstatus");
            Ddo_parametroid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROID_Includefilter"));
            Ddo_parametroid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROID_Includedatalist"));
            Ddo_parametroid_Sortasc = cgiGet( "DDO_PARAMETROID_Sortasc");
            Ddo_parametroid_Sortdsc = cgiGet( "DDO_PARAMETROID_Sortdsc");
            Ddo_parametroid_Cleanfilter = cgiGet( "DDO_PARAMETROID_Cleanfilter");
            Ddo_parametroid_Searchbuttontext = cgiGet( "DDO_PARAMETROID_Searchbuttontext");
            Ddo_parametrodtvigenciaini_Caption = cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Caption");
            Ddo_parametrodtvigenciaini_Tooltip = cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Tooltip");
            Ddo_parametrodtvigenciaini_Cls = cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Cls");
            Ddo_parametrodtvigenciaini_Dropdownoptionstype = cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Dropdownoptionstype");
            Ddo_parametrodtvigenciaini_Titlecontrolidtoreplace = cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Titlecontrolidtoreplace");
            Ddo_parametrodtvigenciaini_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Includesortasc"));
            Ddo_parametrodtvigenciaini_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Includesortdsc"));
            Ddo_parametrodtvigenciaini_Sortedstatus = cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Sortedstatus");
            Ddo_parametrodtvigenciaini_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Includefilter"));
            Ddo_parametrodtvigenciaini_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Includedatalist"));
            Ddo_parametrodtvigenciaini_Sortasc = cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Sortasc");
            Ddo_parametrodtvigenciaini_Sortdsc = cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Sortdsc");
            Ddo_parametrodtvigenciaini_Cleanfilter = cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Cleanfilter");
            Ddo_parametrodtvigenciaini_Searchbuttontext = cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Searchbuttontext");
            Ddo_parametrodtvigenciafim_Caption = cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Caption");
            Ddo_parametrodtvigenciafim_Tooltip = cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Tooltip");
            Ddo_parametrodtvigenciafim_Cls = cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Cls");
            Ddo_parametrodtvigenciafim_Dropdownoptionstype = cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Dropdownoptionstype");
            Ddo_parametrodtvigenciafim_Titlecontrolidtoreplace = cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Titlecontrolidtoreplace");
            Ddo_parametrodtvigenciafim_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Includesortasc"));
            Ddo_parametrodtvigenciafim_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Includesortdsc"));
            Ddo_parametrodtvigenciafim_Sortedstatus = cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Sortedstatus");
            Ddo_parametrodtvigenciafim_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Includefilter"));
            Ddo_parametrodtvigenciafim_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Includedatalist"));
            Ddo_parametrodtvigenciafim_Sortasc = cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Sortasc");
            Ddo_parametrodtvigenciafim_Sortdsc = cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Sortdsc");
            Ddo_parametrodtvigenciafim_Cleanfilter = cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Cleanfilter");
            Ddo_parametrodtvigenciafim_Searchbuttontext = cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Searchbuttontext");
            Ddo_parametrotipo_Caption = cgiGet( "DDO_PARAMETROTIPO_Caption");
            Ddo_parametrotipo_Tooltip = cgiGet( "DDO_PARAMETROTIPO_Tooltip");
            Ddo_parametrotipo_Cls = cgiGet( "DDO_PARAMETROTIPO_Cls");
            Ddo_parametrotipo_Dropdownoptionstype = cgiGet( "DDO_PARAMETROTIPO_Dropdownoptionstype");
            Ddo_parametrotipo_Titlecontrolidtoreplace = cgiGet( "DDO_PARAMETROTIPO_Titlecontrolidtoreplace");
            Ddo_parametrotipo_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROTIPO_Includesortasc"));
            Ddo_parametrotipo_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROTIPO_Includesortdsc"));
            Ddo_parametrotipo_Sortedstatus = cgiGet( "DDO_PARAMETROTIPO_Sortedstatus");
            Ddo_parametrotipo_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROTIPO_Includefilter"));
            Ddo_parametrotipo_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROTIPO_Includedatalist"));
            Ddo_parametrotipo_Sortasc = cgiGet( "DDO_PARAMETROTIPO_Sortasc");
            Ddo_parametrotipo_Sortdsc = cgiGet( "DDO_PARAMETROTIPO_Sortdsc");
            Ddo_parametrotipo_Cleanfilter = cgiGet( "DDO_PARAMETROTIPO_Cleanfilter");
            Ddo_parametrotipo_Searchbuttontext = cgiGet( "DDO_PARAMETROTIPO_Searchbuttontext");
            Ddo_parametroprioritaria_Caption = cgiGet( "DDO_PARAMETROPRIORITARIA_Caption");
            Ddo_parametroprioritaria_Tooltip = cgiGet( "DDO_PARAMETROPRIORITARIA_Tooltip");
            Ddo_parametroprioritaria_Cls = cgiGet( "DDO_PARAMETROPRIORITARIA_Cls");
            Ddo_parametroprioritaria_Dropdownoptionstype = cgiGet( "DDO_PARAMETROPRIORITARIA_Dropdownoptionstype");
            Ddo_parametroprioritaria_Titlecontrolidtoreplace = cgiGet( "DDO_PARAMETROPRIORITARIA_Titlecontrolidtoreplace");
            Ddo_parametroprioritaria_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROPRIORITARIA_Includesortasc"));
            Ddo_parametroprioritaria_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROPRIORITARIA_Includesortdsc"));
            Ddo_parametroprioritaria_Sortedstatus = cgiGet( "DDO_PARAMETROPRIORITARIA_Sortedstatus");
            Ddo_parametroprioritaria_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROPRIORITARIA_Includefilter"));
            Ddo_parametroprioritaria_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROPRIORITARIA_Includedatalist"));
            Ddo_parametroprioritaria_Sortasc = cgiGet( "DDO_PARAMETROPRIORITARIA_Sortasc");
            Ddo_parametroprioritaria_Sortdsc = cgiGet( "DDO_PARAMETROPRIORITARIA_Sortdsc");
            Ddo_parametroprioritaria_Cleanfilter = cgiGet( "DDO_PARAMETROPRIORITARIA_Cleanfilter");
            Ddo_parametroprioritaria_Searchbuttontext = cgiGet( "DDO_PARAMETROPRIORITARIA_Searchbuttontext");
            Ddo_parametrovalor_Caption = cgiGet( "DDO_PARAMETROVALOR_Caption");
            Ddo_parametrovalor_Tooltip = cgiGet( "DDO_PARAMETROVALOR_Tooltip");
            Ddo_parametrovalor_Cls = cgiGet( "DDO_PARAMETROVALOR_Cls");
            Ddo_parametrovalor_Dropdownoptionstype = cgiGet( "DDO_PARAMETROVALOR_Dropdownoptionstype");
            Ddo_parametrovalor_Titlecontrolidtoreplace = cgiGet( "DDO_PARAMETROVALOR_Titlecontrolidtoreplace");
            Ddo_parametrovalor_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROVALOR_Includesortasc"));
            Ddo_parametrovalor_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROVALOR_Includesortdsc"));
            Ddo_parametrovalor_Sortedstatus = cgiGet( "DDO_PARAMETROVALOR_Sortedstatus");
            Ddo_parametrovalor_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROVALOR_Includefilter"));
            Ddo_parametrovalor_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROVALOR_Includedatalist"));
            Ddo_parametrovalor_Sortasc = cgiGet( "DDO_PARAMETROVALOR_Sortasc");
            Ddo_parametrovalor_Sortdsc = cgiGet( "DDO_PARAMETROVALOR_Sortdsc");
            Ddo_parametrovalor_Cleanfilter = cgiGet( "DDO_PARAMETROVALOR_Cleanfilter");
            Ddo_parametrovalor_Searchbuttontext = cgiGet( "DDO_PARAMETROVALOR_Searchbuttontext");
            Ddo_parametropercentual_Caption = cgiGet( "DDO_PARAMETROPERCENTUAL_Caption");
            Ddo_parametropercentual_Tooltip = cgiGet( "DDO_PARAMETROPERCENTUAL_Tooltip");
            Ddo_parametropercentual_Cls = cgiGet( "DDO_PARAMETROPERCENTUAL_Cls");
            Ddo_parametropercentual_Dropdownoptionstype = cgiGet( "DDO_PARAMETROPERCENTUAL_Dropdownoptionstype");
            Ddo_parametropercentual_Titlecontrolidtoreplace = cgiGet( "DDO_PARAMETROPERCENTUAL_Titlecontrolidtoreplace");
            Ddo_parametropercentual_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROPERCENTUAL_Includesortasc"));
            Ddo_parametropercentual_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROPERCENTUAL_Includesortdsc"));
            Ddo_parametropercentual_Sortedstatus = cgiGet( "DDO_PARAMETROPERCENTUAL_Sortedstatus");
            Ddo_parametropercentual_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROPERCENTUAL_Includefilter"));
            Ddo_parametropercentual_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROPERCENTUAL_Includedatalist"));
            Ddo_parametropercentual_Sortasc = cgiGet( "DDO_PARAMETROPERCENTUAL_Sortasc");
            Ddo_parametropercentual_Sortdsc = cgiGet( "DDO_PARAMETROPERCENTUAL_Sortdsc");
            Ddo_parametropercentual_Cleanfilter = cgiGet( "DDO_PARAMETROPERCENTUAL_Cleanfilter");
            Ddo_parametropercentual_Searchbuttontext = cgiGet( "DDO_PARAMETROPERCENTUAL_Searchbuttontext");
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ",", "."));
            Ddo_parametroid_Activeeventkey = cgiGet( "DDO_PARAMETROID_Activeeventkey");
            Ddo_parametrodtvigenciaini_Activeeventkey = cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Activeeventkey");
            Ddo_parametrodtvigenciafim_Activeeventkey = cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Activeeventkey");
            Ddo_parametrotipo_Activeeventkey = cgiGet( "DDO_PARAMETROTIPO_Activeeventkey");
            Ddo_parametroprioritaria_Activeeventkey = cgiGet( "DDO_PARAMETROPRIORITARIA_Activeeventkey");
            Ddo_parametrovalor_Activeeventkey = cgiGet( "DDO_PARAMETROVALOR_Activeeventkey");
            Ddo_parametropercentual_Activeeventkey = cgiGet( "DDO_PARAMETROPERCENTUAL_Activeeventkey");
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
            if ( context.localUtil.CToD( cgiGet( "GXH_vPARAMETRODTVIGENCIAINI1"), 2) != AV15ParametroDtVigenciaIni1 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vPARAMETRODTVIGENCIAINI_TO1"), 2) != AV16ParametroDtVigenciaIni_To1 )
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
            if ( context.localUtil.CToD( cgiGet( "GXH_vPARAMETRODTVIGENCIAINI2"), 2) != AV20ParametroDtVigenciaIni2 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vPARAMETRODTVIGENCIAINI_TO2"), 2) != AV21ParametroDtVigenciaIni_To2 )
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
            if ( context.localUtil.CToD( cgiGet( "GXH_vPARAMETRODTVIGENCIAINI3"), 2) != AV25ParametroDtVigenciaIni3 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vPARAMETRODTVIGENCIAINI_TO3"), 2) != AV26ParametroDtVigenciaIni_To3 )
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
         E320W2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E320W2( )
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
         AV13DynamicFiltersSelector1 = "PARAMETRODTVIGENCIAINI";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13DynamicFiltersSelector1", AV13DynamicFiltersSelector1);
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS1' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV18DynamicFiltersSelector2 = "PARAMETRODTVIGENCIAINI";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18DynamicFiltersSelector2", AV18DynamicFiltersSelector2);
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS2' */
         S122 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV23DynamicFiltersSelector3 = "PARAMETRODTVIGENCIAINI";
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
         Ddo_parametroid_Titlecontrolidtoreplace = subGrid_Internalname+"_ParametroID";
         ucDdo_parametroid.SendProperty(context, "", false, Ddo_parametroid_Internalname, "TitleControlIdToReplace", Ddo_parametroid_Titlecontrolidtoreplace);
         AV31ddo_ParametroIDTitleControlIdToReplace = Ddo_parametroid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_ParametroIDTitleControlIdToReplace", AV31ddo_ParametroIDTitleControlIdToReplace);
         edtavDdo_parametroidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_parametroidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_parametroidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_parametrodtvigenciaini_Titlecontrolidtoreplace = subGrid_Internalname+"_ParametroDtVigenciaIni";
         ucDdo_parametrodtvigenciaini.SendProperty(context, "", false, Ddo_parametrodtvigenciaini_Internalname, "TitleControlIdToReplace", Ddo_parametrodtvigenciaini_Titlecontrolidtoreplace);
         AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace = Ddo_parametrodtvigenciaini_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace", AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace);
         edtavDdo_parametrodtvigenciainititlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_parametrodtvigenciainititlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_parametrodtvigenciainititlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_parametrodtvigenciafim_Titlecontrolidtoreplace = subGrid_Internalname+"_ParametroDtVigenciaFim";
         ucDdo_parametrodtvigenciafim.SendProperty(context, "", false, Ddo_parametrodtvigenciafim_Internalname, "TitleControlIdToReplace", Ddo_parametrodtvigenciafim_Titlecontrolidtoreplace);
         AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace = Ddo_parametrodtvigenciafim_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace", AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace);
         edtavDdo_parametrodtvigenciafimtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_parametrodtvigenciafimtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_parametrodtvigenciafimtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_parametrotipo_Titlecontrolidtoreplace = subGrid_Internalname+"_ParametroTipo";
         ucDdo_parametrotipo.SendProperty(context, "", false, Ddo_parametrotipo_Internalname, "TitleControlIdToReplace", Ddo_parametrotipo_Titlecontrolidtoreplace);
         AV37ddo_ParametroTipoTitleControlIdToReplace = Ddo_parametrotipo_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37ddo_ParametroTipoTitleControlIdToReplace", AV37ddo_ParametroTipoTitleControlIdToReplace);
         edtavDdo_parametrotipotitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_parametrotipotitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_parametrotipotitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_parametroprioritaria_Titlecontrolidtoreplace = subGrid_Internalname+"_ParametroPrioritaria";
         ucDdo_parametroprioritaria.SendProperty(context, "", false, Ddo_parametroprioritaria_Internalname, "TitleControlIdToReplace", Ddo_parametroprioritaria_Titlecontrolidtoreplace);
         AV39ddo_ParametroPrioritariaTitleControlIdToReplace = Ddo_parametroprioritaria_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39ddo_ParametroPrioritariaTitleControlIdToReplace", AV39ddo_ParametroPrioritariaTitleControlIdToReplace);
         edtavDdo_parametroprioritariatitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_parametroprioritariatitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_parametroprioritariatitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_parametrovalor_Titlecontrolidtoreplace = subGrid_Internalname+"_ParametroValor";
         ucDdo_parametrovalor.SendProperty(context, "", false, Ddo_parametrovalor_Internalname, "TitleControlIdToReplace", Ddo_parametrovalor_Titlecontrolidtoreplace);
         AV41ddo_ParametroValorTitleControlIdToReplace = Ddo_parametrovalor_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41ddo_ParametroValorTitleControlIdToReplace", AV41ddo_ParametroValorTitleControlIdToReplace);
         edtavDdo_parametrovalortitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_parametrovalortitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_parametrovalortitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_parametropercentual_Titlecontrolidtoreplace = subGrid_Internalname+"_ParametroPercentual";
         ucDdo_parametropercentual.SendProperty(context, "", false, Ddo_parametropercentual_Internalname, "TitleControlIdToReplace", Ddo_parametropercentual_Titlecontrolidtoreplace);
         AV43ddo_ParametroPercentualTitleControlIdToReplace = Ddo_parametropercentual_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43ddo_ParametroPercentualTitleControlIdToReplace", AV43ddo_ParametroPercentualTitleControlIdToReplace);
         edtavDdo_parametropercentualtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_parametropercentualtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_parametropercentualtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = "Consulta de Parametro";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV44DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV44DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E330W2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV30ParametroIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV32ParametroDtVigenciaIniTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV34ParametroDtVigenciaFimTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV36ParametroTipoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV38ParametroPrioritariaTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV40ParametroValorTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV42ParametroPercentualTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         edtParametroID_Titleformat = 2;
         edtParametroID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Id", AV31ddo_ParametroIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtParametroID_Internalname, "Title", edtParametroID_Title, !bGXsfl_119_Refreshing);
         edtParametroDtVigenciaIni_Titleformat = 2;
         edtParametroDtVigenciaIni_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Vigência Inicial", AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtParametroDtVigenciaIni_Internalname, "Title", edtParametroDtVigenciaIni_Title, !bGXsfl_119_Refreshing);
         edtParametroDtVigenciaFim_Titleformat = 2;
         edtParametroDtVigenciaFim_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Vigência Final", AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtParametroDtVigenciaFim_Internalname, "Title", edtParametroDtVigenciaFim_Title, !bGXsfl_119_Refreshing);
         cmbParametroTipo_Titleformat = 2;
         cmbParametroTipo.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Tipo", AV37ddo_ParametroTipoTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbParametroTipo_Internalname, "Title", cmbParametroTipo.Title.Text, !bGXsfl_119_Refreshing);
         cmbParametroPrioritaria_Titleformat = 2;
         cmbParametroPrioritaria.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Prioritaria", AV39ddo_ParametroPrioritariaTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbParametroPrioritaria_Internalname, "Title", cmbParametroPrioritaria.Title.Text, !bGXsfl_119_Refreshing);
         edtParametroValor_Titleformat = 2;
         edtParametroValor_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Valor", AV41ddo_ParametroValorTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtParametroValor_Internalname, "Title", edtParametroValor_Title, !bGXsfl_119_Refreshing);
         edtParametroPercentual_Titleformat = 2;
         edtParametroPercentual_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Percentual", AV43ddo_ParametroPercentualTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtParametroPercentual_Internalname, "Title", edtParametroPercentual_Title, !bGXsfl_119_Refreshing);
         AV46GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV46GridCurrentPage), 10, 0)));
         AV47GridPageCount = subGrid_Pagecount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47GridPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV47GridPageCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30ParametroIDTitleFilterData", AV30ParametroIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32ParametroDtVigenciaIniTitleFilterData", AV32ParametroDtVigenciaIniTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34ParametroDtVigenciaFimTitleFilterData", AV34ParametroDtVigenciaFimTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36ParametroTipoTitleFilterData", AV36ParametroTipoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38ParametroPrioritariaTitleFilterData", AV38ParametroPrioritariaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40ParametroValorTitleFilterData", AV40ParametroValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42ParametroPercentualTitleFilterData", AV42ParametroPercentualTitleFilterData);
      }

      protected void E110W2( )
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
            AV45PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV45PageToGo) ;
         }
      }

      protected void E120W2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E130W2( )
      {
         /* Ddo_parametroid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_parametroid_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_parametroid_Sortedstatus = "ASC";
            ucDdo_parametroid.SendProperty(context, "", false, Ddo_parametroid_Internalname, "SortedStatus", Ddo_parametroid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_parametroid_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_parametroid_Sortedstatus = "DSC";
            ucDdo_parametroid.SendProperty(context, "", false, Ddo_parametroid_Internalname, "SortedStatus", Ddo_parametroid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30ParametroIDTitleFilterData", AV30ParametroIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32ParametroDtVigenciaIniTitleFilterData", AV32ParametroDtVigenciaIniTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34ParametroDtVigenciaFimTitleFilterData", AV34ParametroDtVigenciaFimTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36ParametroTipoTitleFilterData", AV36ParametroTipoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38ParametroPrioritariaTitleFilterData", AV38ParametroPrioritariaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40ParametroValorTitleFilterData", AV40ParametroValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42ParametroPercentualTitleFilterData", AV42ParametroPercentualTitleFilterData);
      }

      protected void E140W2( )
      {
         /* Ddo_parametrodtvigenciaini_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_parametrodtvigenciaini_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_parametrodtvigenciaini_Sortedstatus = "ASC";
            ucDdo_parametrodtvigenciaini.SendProperty(context, "", false, Ddo_parametrodtvigenciaini_Internalname, "SortedStatus", Ddo_parametrodtvigenciaini_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_parametrodtvigenciaini_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_parametrodtvigenciaini_Sortedstatus = "DSC";
            ucDdo_parametrodtvigenciaini.SendProperty(context, "", false, Ddo_parametrodtvigenciaini_Internalname, "SortedStatus", Ddo_parametrodtvigenciaini_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30ParametroIDTitleFilterData", AV30ParametroIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32ParametroDtVigenciaIniTitleFilterData", AV32ParametroDtVigenciaIniTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34ParametroDtVigenciaFimTitleFilterData", AV34ParametroDtVigenciaFimTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36ParametroTipoTitleFilterData", AV36ParametroTipoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38ParametroPrioritariaTitleFilterData", AV38ParametroPrioritariaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40ParametroValorTitleFilterData", AV40ParametroValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42ParametroPercentualTitleFilterData", AV42ParametroPercentualTitleFilterData);
      }

      protected void E150W2( )
      {
         /* Ddo_parametrodtvigenciafim_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_parametrodtvigenciafim_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_parametrodtvigenciafim_Sortedstatus = "ASC";
            ucDdo_parametrodtvigenciafim.SendProperty(context, "", false, Ddo_parametrodtvigenciafim_Internalname, "SortedStatus", Ddo_parametrodtvigenciafim_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_parametrodtvigenciafim_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_parametrodtvigenciafim_Sortedstatus = "DSC";
            ucDdo_parametrodtvigenciafim.SendProperty(context, "", false, Ddo_parametrodtvigenciafim_Internalname, "SortedStatus", Ddo_parametrodtvigenciafim_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30ParametroIDTitleFilterData", AV30ParametroIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32ParametroDtVigenciaIniTitleFilterData", AV32ParametroDtVigenciaIniTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34ParametroDtVigenciaFimTitleFilterData", AV34ParametroDtVigenciaFimTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36ParametroTipoTitleFilterData", AV36ParametroTipoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38ParametroPrioritariaTitleFilterData", AV38ParametroPrioritariaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40ParametroValorTitleFilterData", AV40ParametroValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42ParametroPercentualTitleFilterData", AV42ParametroPercentualTitleFilterData);
      }

      protected void E160W2( )
      {
         /* Ddo_parametrotipo_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_parametrotipo_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_parametrotipo_Sortedstatus = "ASC";
            ucDdo_parametrotipo.SendProperty(context, "", false, Ddo_parametrotipo_Internalname, "SortedStatus", Ddo_parametrotipo_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_parametrotipo_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_parametrotipo_Sortedstatus = "DSC";
            ucDdo_parametrotipo.SendProperty(context, "", false, Ddo_parametrotipo_Internalname, "SortedStatus", Ddo_parametrotipo_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30ParametroIDTitleFilterData", AV30ParametroIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32ParametroDtVigenciaIniTitleFilterData", AV32ParametroDtVigenciaIniTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34ParametroDtVigenciaFimTitleFilterData", AV34ParametroDtVigenciaFimTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36ParametroTipoTitleFilterData", AV36ParametroTipoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38ParametroPrioritariaTitleFilterData", AV38ParametroPrioritariaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40ParametroValorTitleFilterData", AV40ParametroValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42ParametroPercentualTitleFilterData", AV42ParametroPercentualTitleFilterData);
      }

      protected void E170W2( )
      {
         /* Ddo_parametroprioritaria_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_parametroprioritaria_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_parametroprioritaria_Sortedstatus = "ASC";
            ucDdo_parametroprioritaria.SendProperty(context, "", false, Ddo_parametroprioritaria_Internalname, "SortedStatus", Ddo_parametroprioritaria_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_parametroprioritaria_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_parametroprioritaria_Sortedstatus = "DSC";
            ucDdo_parametroprioritaria.SendProperty(context, "", false, Ddo_parametroprioritaria_Internalname, "SortedStatus", Ddo_parametroprioritaria_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30ParametroIDTitleFilterData", AV30ParametroIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32ParametroDtVigenciaIniTitleFilterData", AV32ParametroDtVigenciaIniTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34ParametroDtVigenciaFimTitleFilterData", AV34ParametroDtVigenciaFimTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36ParametroTipoTitleFilterData", AV36ParametroTipoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38ParametroPrioritariaTitleFilterData", AV38ParametroPrioritariaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40ParametroValorTitleFilterData", AV40ParametroValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42ParametroPercentualTitleFilterData", AV42ParametroPercentualTitleFilterData);
      }

      protected void E180W2( )
      {
         /* Ddo_parametrovalor_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_parametrovalor_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_parametrovalor_Sortedstatus = "ASC";
            ucDdo_parametrovalor.SendProperty(context, "", false, Ddo_parametrovalor_Internalname, "SortedStatus", Ddo_parametrovalor_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_parametrovalor_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_parametrovalor_Sortedstatus = "DSC";
            ucDdo_parametrovalor.SendProperty(context, "", false, Ddo_parametrovalor_Internalname, "SortedStatus", Ddo_parametrovalor_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30ParametroIDTitleFilterData", AV30ParametroIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32ParametroDtVigenciaIniTitleFilterData", AV32ParametroDtVigenciaIniTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34ParametroDtVigenciaFimTitleFilterData", AV34ParametroDtVigenciaFimTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36ParametroTipoTitleFilterData", AV36ParametroTipoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38ParametroPrioritariaTitleFilterData", AV38ParametroPrioritariaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40ParametroValorTitleFilterData", AV40ParametroValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42ParametroPercentualTitleFilterData", AV42ParametroPercentualTitleFilterData);
      }

      protected void E190W2( )
      {
         /* Ddo_parametropercentual_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_parametropercentual_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV11OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_parametropercentual_Sortedstatus = "ASC";
            ucDdo_parametropercentual.SendProperty(context, "", false, Ddo_parametropercentual_Internalname, "SortedStatus", Ddo_parametropercentual_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_parametropercentual_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV11OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_parametropercentual_Sortedstatus = "DSC";
            ucDdo_parametropercentual.SendProperty(context, "", false, Ddo_parametropercentual_Internalname, "SortedStatus", Ddo_parametropercentual_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30ParametroIDTitleFilterData", AV30ParametroIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32ParametroDtVigenciaIniTitleFilterData", AV32ParametroDtVigenciaIniTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34ParametroDtVigenciaFimTitleFilterData", AV34ParametroDtVigenciaFimTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36ParametroTipoTitleFilterData", AV36ParametroTipoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38ParametroPrioritariaTitleFilterData", AV38ParametroPrioritariaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40ParametroValorTitleFilterData", AV40ParametroValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42ParametroPercentualTitleFilterData", AV42ParametroPercentualTitleFilterData);
      }

      private void E340W2( )
      {
         /* Grid_Load Routine */
         AV48Select = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavSelect_Internalname, AV48Select);
         AV53Select_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
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
         E350W2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E350W2( )
      {
         /* Enter Routine */
         AV49InOutParametroID = A13ParametroID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49InOutParametroID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV49InOutParametroID), 4, 0)));
         AV50InOutParametroDtVigenciaIni = A14ParametroDtVigenciaIni;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV50InOutParametroDtVigenciaIni", context.localUtil.Format(AV50InOutParametroDtVigenciaIni, "99/99/99"));
         context.setWebReturnParms(new Object[] {(short)AV49InOutParametroID,context.localUtil.Format( AV50InOutParametroDtVigenciaIni, "99/99/99")});
         context.setWebReturnParmsMetadata(new Object[] {"AV49InOutParametroID","AV50InOutParametroDtVigenciaIni"});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
         /*  Sending Event outputs  */
      }

      protected void E240W2( )
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

      protected void E200W2( )
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
         gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15ParametroDtVigenciaIni1, AV16ParametroDtVigenciaIni_To1, AV18DynamicFiltersSelector2, AV19DynamicFiltersOperator2, AV20ParametroDtVigenciaIni2, AV21ParametroDtVigenciaIni_To2, AV23DynamicFiltersSelector3, AV24DynamicFiltersOperator3, AV25ParametroDtVigenciaIni3, AV26ParametroDtVigenciaIni_To3, AV17DynamicFiltersEnabled2, AV22DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV31ddo_ParametroIDTitleControlIdToReplace, AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace, AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace, AV37ddo_ParametroTipoTitleControlIdToReplace, AV39ddo_ParametroPrioritariaTitleControlIdToReplace, AV41ddo_ParametroValorTitleControlIdToReplace, AV43ddo_ParametroPercentualTitleControlIdToReplace) ;
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
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30ParametroIDTitleFilterData", AV30ParametroIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32ParametroDtVigenciaIniTitleFilterData", AV32ParametroDtVigenciaIniTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34ParametroDtVigenciaFimTitleFilterData", AV34ParametroDtVigenciaFimTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36ParametroTipoTitleFilterData", AV36ParametroTipoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38ParametroPrioritariaTitleFilterData", AV38ParametroPrioritariaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40ParametroValorTitleFilterData", AV40ParametroValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42ParametroPercentualTitleFilterData", AV42ParametroPercentualTitleFilterData);
      }

      protected void E250W2( )
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

      protected void E260W2( )
      {
         /* Dynamicfiltersoperator1_Click Routine */
         if ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PARAMETRODTVIGENCIAINI") == 0 )
         {
            AV15ParametroDtVigenciaIni1 = DateTime.MinValue;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15ParametroDtVigenciaIni1", context.localUtil.Format(AV15ParametroDtVigenciaIni1, "99/99/99"));
            AV16ParametroDtVigenciaIni_To1 = DateTime.MinValue;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ParametroDtVigenciaIni_To1", context.localUtil.Format(AV16ParametroDtVigenciaIni_To1, "99/99/99"));
            /* Execute user subroutine: 'UPDATEPARAMETRODTVIGENCIAINI1OPERATORVALUES' */
            S192 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15ParametroDtVigenciaIni1, AV16ParametroDtVigenciaIni_To1, AV18DynamicFiltersSelector2, AV19DynamicFiltersOperator2, AV20ParametroDtVigenciaIni2, AV21ParametroDtVigenciaIni_To2, AV23DynamicFiltersSelector3, AV24DynamicFiltersOperator3, AV25ParametroDtVigenciaIni3, AV26ParametroDtVigenciaIni_To3, AV17DynamicFiltersEnabled2, AV22DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV31ddo_ParametroIDTitleControlIdToReplace, AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace, AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace, AV37ddo_ParametroTipoTitleControlIdToReplace, AV39ddo_ParametroPrioritariaTitleControlIdToReplace, AV41ddo_ParametroValorTitleControlIdToReplace, AV43ddo_ParametroPercentualTitleControlIdToReplace) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30ParametroIDTitleFilterData", AV30ParametroIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32ParametroDtVigenciaIniTitleFilterData", AV32ParametroDtVigenciaIniTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34ParametroDtVigenciaFimTitleFilterData", AV34ParametroDtVigenciaFimTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36ParametroTipoTitleFilterData", AV36ParametroTipoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38ParametroPrioritariaTitleFilterData", AV38ParametroPrioritariaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40ParametroValorTitleFilterData", AV40ParametroValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42ParametroPercentualTitleFilterData", AV42ParametroPercentualTitleFilterData);
      }

      protected void E270W2( )
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

      protected void E210W2( )
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
         gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15ParametroDtVigenciaIni1, AV16ParametroDtVigenciaIni_To1, AV18DynamicFiltersSelector2, AV19DynamicFiltersOperator2, AV20ParametroDtVigenciaIni2, AV21ParametroDtVigenciaIni_To2, AV23DynamicFiltersSelector3, AV24DynamicFiltersOperator3, AV25ParametroDtVigenciaIni3, AV26ParametroDtVigenciaIni_To3, AV17DynamicFiltersEnabled2, AV22DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV31ddo_ParametroIDTitleControlIdToReplace, AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace, AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace, AV37ddo_ParametroTipoTitleControlIdToReplace, AV39ddo_ParametroPrioritariaTitleControlIdToReplace, AV41ddo_ParametroValorTitleControlIdToReplace, AV43ddo_ParametroPercentualTitleControlIdToReplace) ;
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
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30ParametroIDTitleFilterData", AV30ParametroIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32ParametroDtVigenciaIniTitleFilterData", AV32ParametroDtVigenciaIniTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34ParametroDtVigenciaFimTitleFilterData", AV34ParametroDtVigenciaFimTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36ParametroTipoTitleFilterData", AV36ParametroTipoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38ParametroPrioritariaTitleFilterData", AV38ParametroPrioritariaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40ParametroValorTitleFilterData", AV40ParametroValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42ParametroPercentualTitleFilterData", AV42ParametroPercentualTitleFilterData);
      }

      protected void E280W2( )
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

      protected void E290W2( )
      {
         /* Dynamicfiltersoperator2_Click Routine */
         if ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PARAMETRODTVIGENCIAINI") == 0 )
         {
            AV20ParametroDtVigenciaIni2 = DateTime.MinValue;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ParametroDtVigenciaIni2", context.localUtil.Format(AV20ParametroDtVigenciaIni2, "99/99/99"));
            AV21ParametroDtVigenciaIni_To2 = DateTime.MinValue;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21ParametroDtVigenciaIni_To2", context.localUtil.Format(AV21ParametroDtVigenciaIni_To2, "99/99/99"));
            /* Execute user subroutine: 'UPDATEPARAMETRODTVIGENCIAINI2OPERATORVALUES' */
            S202 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15ParametroDtVigenciaIni1, AV16ParametroDtVigenciaIni_To1, AV18DynamicFiltersSelector2, AV19DynamicFiltersOperator2, AV20ParametroDtVigenciaIni2, AV21ParametroDtVigenciaIni_To2, AV23DynamicFiltersSelector3, AV24DynamicFiltersOperator3, AV25ParametroDtVigenciaIni3, AV26ParametroDtVigenciaIni_To3, AV17DynamicFiltersEnabled2, AV22DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV31ddo_ParametroIDTitleControlIdToReplace, AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace, AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace, AV37ddo_ParametroTipoTitleControlIdToReplace, AV39ddo_ParametroPrioritariaTitleControlIdToReplace, AV41ddo_ParametroValorTitleControlIdToReplace, AV43ddo_ParametroPercentualTitleControlIdToReplace) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30ParametroIDTitleFilterData", AV30ParametroIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32ParametroDtVigenciaIniTitleFilterData", AV32ParametroDtVigenciaIniTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34ParametroDtVigenciaFimTitleFilterData", AV34ParametroDtVigenciaFimTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36ParametroTipoTitleFilterData", AV36ParametroTipoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38ParametroPrioritariaTitleFilterData", AV38ParametroPrioritariaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40ParametroValorTitleFilterData", AV40ParametroValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42ParametroPercentualTitleFilterData", AV42ParametroPercentualTitleFilterData);
      }

      protected void E220W2( )
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
         gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15ParametroDtVigenciaIni1, AV16ParametroDtVigenciaIni_To1, AV18DynamicFiltersSelector2, AV19DynamicFiltersOperator2, AV20ParametroDtVigenciaIni2, AV21ParametroDtVigenciaIni_To2, AV23DynamicFiltersSelector3, AV24DynamicFiltersOperator3, AV25ParametroDtVigenciaIni3, AV26ParametroDtVigenciaIni_To3, AV17DynamicFiltersEnabled2, AV22DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV31ddo_ParametroIDTitleControlIdToReplace, AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace, AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace, AV37ddo_ParametroTipoTitleControlIdToReplace, AV39ddo_ParametroPrioritariaTitleControlIdToReplace, AV41ddo_ParametroValorTitleControlIdToReplace, AV43ddo_ParametroPercentualTitleControlIdToReplace) ;
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
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30ParametroIDTitleFilterData", AV30ParametroIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32ParametroDtVigenciaIniTitleFilterData", AV32ParametroDtVigenciaIniTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34ParametroDtVigenciaFimTitleFilterData", AV34ParametroDtVigenciaFimTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36ParametroTipoTitleFilterData", AV36ParametroTipoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38ParametroPrioritariaTitleFilterData", AV38ParametroPrioritariaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40ParametroValorTitleFilterData", AV40ParametroValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42ParametroPercentualTitleFilterData", AV42ParametroPercentualTitleFilterData);
      }

      protected void E300W2( )
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

      protected void E310W2( )
      {
         /* Dynamicfiltersoperator3_Click Routine */
         if ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PARAMETRODTVIGENCIAINI") == 0 )
         {
            AV25ParametroDtVigenciaIni3 = DateTime.MinValue;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25ParametroDtVigenciaIni3", context.localUtil.Format(AV25ParametroDtVigenciaIni3, "99/99/99"));
            AV26ParametroDtVigenciaIni_To3 = DateTime.MinValue;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26ParametroDtVigenciaIni_To3", context.localUtil.Format(AV26ParametroDtVigenciaIni_To3, "99/99/99"));
            /* Execute user subroutine: 'UPDATEPARAMETRODTVIGENCIAINI3OPERATORVALUES' */
            S212 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15ParametroDtVigenciaIni1, AV16ParametroDtVigenciaIni_To1, AV18DynamicFiltersSelector2, AV19DynamicFiltersOperator2, AV20ParametroDtVigenciaIni2, AV21ParametroDtVigenciaIni_To2, AV23DynamicFiltersSelector3, AV24DynamicFiltersOperator3, AV25ParametroDtVigenciaIni3, AV26ParametroDtVigenciaIni_To3, AV17DynamicFiltersEnabled2, AV22DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV31ddo_ParametroIDTitleControlIdToReplace, AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace, AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace, AV37ddo_ParametroTipoTitleControlIdToReplace, AV39ddo_ParametroPrioritariaTitleControlIdToReplace, AV41ddo_ParametroValorTitleControlIdToReplace, AV43ddo_ParametroPercentualTitleControlIdToReplace) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30ParametroIDTitleFilterData", AV30ParametroIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32ParametroDtVigenciaIniTitleFilterData", AV32ParametroDtVigenciaIniTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34ParametroDtVigenciaFimTitleFilterData", AV34ParametroDtVigenciaFimTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36ParametroTipoTitleFilterData", AV36ParametroTipoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38ParametroPrioritariaTitleFilterData", AV38ParametroPrioritariaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40ParametroValorTitleFilterData", AV40ParametroValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42ParametroPercentualTitleFilterData", AV42ParametroPercentualTitleFilterData);
      }

      protected void E230W2( )
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
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30ParametroIDTitleFilterData", AV30ParametroIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32ParametroDtVigenciaIniTitleFilterData", AV32ParametroDtVigenciaIniTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34ParametroDtVigenciaFimTitleFilterData", AV34ParametroDtVigenciaFimTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36ParametroTipoTitleFilterData", AV36ParametroTipoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38ParametroPrioritariaTitleFilterData", AV38ParametroPrioritariaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40ParametroValorTitleFilterData", AV40ParametroValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42ParametroPercentualTitleFilterData", AV42ParametroPercentualTitleFilterData);
      }

      protected void S162( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_parametroid_Sortedstatus = "";
         ucDdo_parametroid.SendProperty(context, "", false, Ddo_parametroid_Internalname, "SortedStatus", Ddo_parametroid_Sortedstatus);
         Ddo_parametrodtvigenciaini_Sortedstatus = "";
         ucDdo_parametrodtvigenciaini.SendProperty(context, "", false, Ddo_parametrodtvigenciaini_Internalname, "SortedStatus", Ddo_parametrodtvigenciaini_Sortedstatus);
         Ddo_parametrodtvigenciafim_Sortedstatus = "";
         ucDdo_parametrodtvigenciafim.SendProperty(context, "", false, Ddo_parametrodtvigenciafim_Internalname, "SortedStatus", Ddo_parametrodtvigenciafim_Sortedstatus);
         Ddo_parametrotipo_Sortedstatus = "";
         ucDdo_parametrotipo.SendProperty(context, "", false, Ddo_parametrotipo_Internalname, "SortedStatus", Ddo_parametrotipo_Sortedstatus);
         Ddo_parametroprioritaria_Sortedstatus = "";
         ucDdo_parametroprioritaria.SendProperty(context, "", false, Ddo_parametroprioritaria_Internalname, "SortedStatus", Ddo_parametroprioritaria_Sortedstatus);
         Ddo_parametrovalor_Sortedstatus = "";
         ucDdo_parametrovalor.SendProperty(context, "", false, Ddo_parametrovalor_Internalname, "SortedStatus", Ddo_parametrovalor_Sortedstatus);
         Ddo_parametropercentual_Sortedstatus = "";
         ucDdo_parametropercentual.SendProperty(context, "", false, Ddo_parametropercentual_Internalname, "SortedStatus", Ddo_parametropercentual_Sortedstatus);
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
            Ddo_parametroid_Sortedstatus = (AV12OrderedDsc ? "DSC" : "ASC");
            ucDdo_parametroid.SendProperty(context, "", false, Ddo_parametroid_Internalname, "SortedStatus", Ddo_parametroid_Sortedstatus);
         }
         else if ( AV11OrderedBy == 1 )
         {
            Ddo_parametrodtvigenciaini_Sortedstatus = (AV12OrderedDsc ? "DSC" : "ASC");
            ucDdo_parametrodtvigenciaini.SendProperty(context, "", false, Ddo_parametrodtvigenciaini_Internalname, "SortedStatus", Ddo_parametrodtvigenciaini_Sortedstatus);
         }
         else if ( AV11OrderedBy == 3 )
         {
            Ddo_parametrodtvigenciafim_Sortedstatus = (AV12OrderedDsc ? "DSC" : "ASC");
            ucDdo_parametrodtvigenciafim.SendProperty(context, "", false, Ddo_parametrodtvigenciafim_Internalname, "SortedStatus", Ddo_parametrodtvigenciafim_Sortedstatus);
         }
         else if ( AV11OrderedBy == 4 )
         {
            Ddo_parametrotipo_Sortedstatus = (AV12OrderedDsc ? "DSC" : "ASC");
            ucDdo_parametrotipo.SendProperty(context, "", false, Ddo_parametrotipo_Internalname, "SortedStatus", Ddo_parametrotipo_Sortedstatus);
         }
         else if ( AV11OrderedBy == 5 )
         {
            Ddo_parametroprioritaria_Sortedstatus = (AV12OrderedDsc ? "DSC" : "ASC");
            ucDdo_parametroprioritaria.SendProperty(context, "", false, Ddo_parametroprioritaria_Internalname, "SortedStatus", Ddo_parametroprioritaria_Sortedstatus);
         }
         else if ( AV11OrderedBy == 6 )
         {
            Ddo_parametrovalor_Sortedstatus = (AV12OrderedDsc ? "DSC" : "ASC");
            ucDdo_parametrovalor.SendProperty(context, "", false, Ddo_parametrovalor_Internalname, "SortedStatus", Ddo_parametrovalor_Sortedstatus);
         }
         else if ( AV11OrderedBy == 7 )
         {
            Ddo_parametropercentual_Sortedstatus = (AV12OrderedDsc ? "DSC" : "ASC");
            ucDdo_parametropercentual.SendProperty(context, "", false, Ddo_parametropercentual_Internalname, "SortedStatus", Ddo_parametropercentual_Sortedstatus);
         }
      }

      protected void S112( )
      {
         /* 'ENABLEDYNAMICFILTERS1' Routine */
         tblTablemergeddynamicfiltersparametrodtvigenciaini1_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, tblTablemergeddynamicfiltersparametrodtvigenciaini1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTablemergeddynamicfiltersparametrodtvigenciaini1_Visible), 5, 0)), true);
         cmbavDynamicfiltersoperator1.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavDynamicfiltersoperator1.Visible), 5, 0)), true);
         if ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PARAMETRODTVIGENCIAINI") == 0 )
         {
            tblTablemergeddynamicfiltersparametrodtvigenciaini1_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, tblTablemergeddynamicfiltersparametrodtvigenciaini1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTablemergeddynamicfiltersparametrodtvigenciaini1_Visible), 5, 0)), true);
            cmbavDynamicfiltersoperator1.Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavDynamicfiltersoperator1.Visible), 5, 0)), true);
            /* Execute user subroutine: 'UPDATEPARAMETRODTVIGENCIAINI1OPERATORVALUES' */
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
         /* 'UPDATEPARAMETRODTVIGENCIAINI1OPERATORVALUES' Routine */
         cellParametrodtvigenciaini_cell1_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellParametrodtvigenciaini_cell1_Internalname, "Class", cellParametrodtvigenciaini_cell1_Class, true);
         cellParametrodtvigenciaini_to_cell1_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellParametrodtvigenciaini_to_cell1_Internalname, "Class", cellParametrodtvigenciaini_to_cell1_Class, true);
         lblParametrodtvigenciaini_rangemiddletext_11_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblParametrodtvigenciaini_rangemiddletext_11_Internalname, "Class", lblParametrodtvigenciaini_rangemiddletext_11_Class, true);
         if ( AV14DynamicFiltersOperator1 == 0 )
         {
            AV15ParametroDtVigenciaIni1 = Gx_date;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15ParametroDtVigenciaIni1", context.localUtil.Format(AV15ParametroDtVigenciaIni1, "99/99/99"));
         }
         else if ( AV14DynamicFiltersOperator1 == 1 )
         {
            AV15ParametroDtVigenciaIni1 = Gx_date;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15ParametroDtVigenciaIni1", context.localUtil.Format(AV15ParametroDtVigenciaIni1, "99/99/99"));
         }
         else if ( AV14DynamicFiltersOperator1 == 2 )
         {
            AV15ParametroDtVigenciaIni1 = Gx_date;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15ParametroDtVigenciaIni1", context.localUtil.Format(AV15ParametroDtVigenciaIni1, "99/99/99"));
         }
         else if ( AV14DynamicFiltersOperator1 == 3 )
         {
            cellParametrodtvigenciaini_cell1_Class = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellParametrodtvigenciaini_cell1_Internalname, "Class", cellParametrodtvigenciaini_cell1_Class, true);
            cellParametrodtvigenciaini_to_cell1_Class = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellParametrodtvigenciaini_to_cell1_Internalname, "Class", cellParametrodtvigenciaini_to_cell1_Class, true);
            lblParametrodtvigenciaini_rangemiddletext_11_Class = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblParametrodtvigenciaini_rangemiddletext_11_Internalname, "Class", lblParametrodtvigenciaini_rangemiddletext_11_Class, true);
         }
      }

      protected void S122( )
      {
         /* 'ENABLEDYNAMICFILTERS2' Routine */
         tblTablemergeddynamicfiltersparametrodtvigenciaini2_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, tblTablemergeddynamicfiltersparametrodtvigenciaini2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTablemergeddynamicfiltersparametrodtvigenciaini2_Visible), 5, 0)), true);
         cmbavDynamicfiltersoperator2.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavDynamicfiltersoperator2.Visible), 5, 0)), true);
         if ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PARAMETRODTVIGENCIAINI") == 0 )
         {
            tblTablemergeddynamicfiltersparametrodtvigenciaini2_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, tblTablemergeddynamicfiltersparametrodtvigenciaini2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTablemergeddynamicfiltersparametrodtvigenciaini2_Visible), 5, 0)), true);
            cmbavDynamicfiltersoperator2.Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavDynamicfiltersoperator2.Visible), 5, 0)), true);
            /* Execute user subroutine: 'UPDATEPARAMETRODTVIGENCIAINI2OPERATORVALUES' */
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
         /* 'UPDATEPARAMETRODTVIGENCIAINI2OPERATORVALUES' Routine */
         cellParametrodtvigenciaini_cell2_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellParametrodtvigenciaini_cell2_Internalname, "Class", cellParametrodtvigenciaini_cell2_Class, true);
         cellParametrodtvigenciaini_to_cell2_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellParametrodtvigenciaini_to_cell2_Internalname, "Class", cellParametrodtvigenciaini_to_cell2_Class, true);
         lblParametrodtvigenciaini_rangemiddletext_12_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblParametrodtvigenciaini_rangemiddletext_12_Internalname, "Class", lblParametrodtvigenciaini_rangemiddletext_12_Class, true);
         if ( AV19DynamicFiltersOperator2 == 0 )
         {
            AV20ParametroDtVigenciaIni2 = Gx_date;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ParametroDtVigenciaIni2", context.localUtil.Format(AV20ParametroDtVigenciaIni2, "99/99/99"));
         }
         else if ( AV19DynamicFiltersOperator2 == 1 )
         {
            AV20ParametroDtVigenciaIni2 = Gx_date;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ParametroDtVigenciaIni2", context.localUtil.Format(AV20ParametroDtVigenciaIni2, "99/99/99"));
         }
         else if ( AV19DynamicFiltersOperator2 == 2 )
         {
            AV20ParametroDtVigenciaIni2 = Gx_date;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ParametroDtVigenciaIni2", context.localUtil.Format(AV20ParametroDtVigenciaIni2, "99/99/99"));
         }
         else if ( AV19DynamicFiltersOperator2 == 3 )
         {
            cellParametrodtvigenciaini_cell2_Class = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellParametrodtvigenciaini_cell2_Internalname, "Class", cellParametrodtvigenciaini_cell2_Class, true);
            cellParametrodtvigenciaini_to_cell2_Class = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellParametrodtvigenciaini_to_cell2_Internalname, "Class", cellParametrodtvigenciaini_to_cell2_Class, true);
            lblParametrodtvigenciaini_rangemiddletext_12_Class = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblParametrodtvigenciaini_rangemiddletext_12_Internalname, "Class", lblParametrodtvigenciaini_rangemiddletext_12_Class, true);
         }
      }

      protected void S132( )
      {
         /* 'ENABLEDYNAMICFILTERS3' Routine */
         tblTablemergeddynamicfiltersparametrodtvigenciaini3_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, tblTablemergeddynamicfiltersparametrodtvigenciaini3_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTablemergeddynamicfiltersparametrodtvigenciaini3_Visible), 5, 0)), true);
         cmbavDynamicfiltersoperator3.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavDynamicfiltersoperator3.Visible), 5, 0)), true);
         if ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PARAMETRODTVIGENCIAINI") == 0 )
         {
            tblTablemergeddynamicfiltersparametrodtvigenciaini3_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, tblTablemergeddynamicfiltersparametrodtvigenciaini3_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTablemergeddynamicfiltersparametrodtvigenciaini3_Visible), 5, 0)), true);
            cmbavDynamicfiltersoperator3.Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavDynamicfiltersoperator3.Visible), 5, 0)), true);
            /* Execute user subroutine: 'UPDATEPARAMETRODTVIGENCIAINI3OPERATORVALUES' */
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
         /* 'UPDATEPARAMETRODTVIGENCIAINI3OPERATORVALUES' Routine */
         cellParametrodtvigenciaini_cell3_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellParametrodtvigenciaini_cell3_Internalname, "Class", cellParametrodtvigenciaini_cell3_Class, true);
         cellParametrodtvigenciaini_to_cell3_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellParametrodtvigenciaini_to_cell3_Internalname, "Class", cellParametrodtvigenciaini_to_cell3_Class, true);
         lblParametrodtvigenciaini_rangemiddletext_13_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblParametrodtvigenciaini_rangemiddletext_13_Internalname, "Class", lblParametrodtvigenciaini_rangemiddletext_13_Class, true);
         if ( AV24DynamicFiltersOperator3 == 0 )
         {
            AV25ParametroDtVigenciaIni3 = Gx_date;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25ParametroDtVigenciaIni3", context.localUtil.Format(AV25ParametroDtVigenciaIni3, "99/99/99"));
         }
         else if ( AV24DynamicFiltersOperator3 == 1 )
         {
            AV25ParametroDtVigenciaIni3 = Gx_date;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25ParametroDtVigenciaIni3", context.localUtil.Format(AV25ParametroDtVigenciaIni3, "99/99/99"));
         }
         else if ( AV24DynamicFiltersOperator3 == 2 )
         {
            AV25ParametroDtVigenciaIni3 = Gx_date;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25ParametroDtVigenciaIni3", context.localUtil.Format(AV25ParametroDtVigenciaIni3, "99/99/99"));
         }
         else if ( AV24DynamicFiltersOperator3 == 3 )
         {
            cellParametrodtvigenciaini_cell3_Class = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellParametrodtvigenciaini_cell3_Internalname, "Class", cellParametrodtvigenciaini_cell3_Class, true);
            cellParametrodtvigenciaini_to_cell3_Class = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellParametrodtvigenciaini_to_cell3_Internalname, "Class", cellParametrodtvigenciaini_to_cell3_Class, true);
            lblParametrodtvigenciaini_rangemiddletext_13_Class = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblParametrodtvigenciaini_rangemiddletext_13_Internalname, "Class", lblParametrodtvigenciaini_rangemiddletext_13_Class, true);
         }
      }

      protected void S182( )
      {
         /* 'RESETDYNFILTERS' Routine */
         AV17DynamicFiltersEnabled2 = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17DynamicFiltersEnabled2", AV17DynamicFiltersEnabled2);
         AV18DynamicFiltersSelector2 = "PARAMETRODTVIGENCIAINI";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18DynamicFiltersSelector2", AV18DynamicFiltersSelector2);
         AV19DynamicFiltersOperator2 = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19DynamicFiltersOperator2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0)));
         AV20ParametroDtVigenciaIni2 = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ParametroDtVigenciaIni2", context.localUtil.Format(AV20ParametroDtVigenciaIni2, "99/99/99"));
         AV21ParametroDtVigenciaIni_To2 = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21ParametroDtVigenciaIni_To2", context.localUtil.Format(AV21ParametroDtVigenciaIni_To2, "99/99/99"));
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS2' */
         S122 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV22DynamicFiltersEnabled3 = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22DynamicFiltersEnabled3", AV22DynamicFiltersEnabled3);
         AV23DynamicFiltersSelector3 = "PARAMETRODTVIGENCIAINI";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23DynamicFiltersSelector3", AV23DynamicFiltersSelector3);
         AV24DynamicFiltersOperator3 = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24DynamicFiltersOperator3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0)));
         AV25ParametroDtVigenciaIni3 = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25ParametroDtVigenciaIni3", context.localUtil.Format(AV25ParametroDtVigenciaIni3, "99/99/99"));
         AV26ParametroDtVigenciaIni_To3 = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26ParametroDtVigenciaIni_To3", context.localUtil.Format(AV26ParametroDtVigenciaIni_To3, "99/99/99"));
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
         AV13DynamicFiltersSelector1 = "PARAMETRODTVIGENCIAINI";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13DynamicFiltersSelector1", AV13DynamicFiltersSelector1);
         AV14DynamicFiltersOperator1 = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14DynamicFiltersOperator1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0)));
         AV15ParametroDtVigenciaIni1 = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15ParametroDtVigenciaIni1", context.localUtil.Format(AV15ParametroDtVigenciaIni1, "99/99/99"));
         AV16ParametroDtVigenciaIni_To1 = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ParametroDtVigenciaIni_To1", context.localUtil.Format(AV16ParametroDtVigenciaIni_To1, "99/99/99"));
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
            if ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PARAMETRODTVIGENCIAINI") == 0 )
            {
               AV14DynamicFiltersOperator1 = AV10GridStateDynamicFilter.gxTpr_Operator;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14DynamicFiltersOperator1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0)));
               AV15ParametroDtVigenciaIni1 = context.localUtil.CToD( AV10GridStateDynamicFilter.gxTpr_Value, 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15ParametroDtVigenciaIni1", context.localUtil.Format(AV15ParametroDtVigenciaIni1, "99/99/99"));
               AV16ParametroDtVigenciaIni_To1 = context.localUtil.CToD( AV10GridStateDynamicFilter.gxTpr_Valueto, 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ParametroDtVigenciaIni_To1", context.localUtil.Format(AV16ParametroDtVigenciaIni_To1, "99/99/99"));
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
               if ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PARAMETRODTVIGENCIAINI") == 0 )
               {
                  AV19DynamicFiltersOperator2 = AV10GridStateDynamicFilter.gxTpr_Operator;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19DynamicFiltersOperator2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0)));
                  AV20ParametroDtVigenciaIni2 = context.localUtil.CToD( AV10GridStateDynamicFilter.gxTpr_Value, 2);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ParametroDtVigenciaIni2", context.localUtil.Format(AV20ParametroDtVigenciaIni2, "99/99/99"));
                  AV21ParametroDtVigenciaIni_To2 = context.localUtil.CToD( AV10GridStateDynamicFilter.gxTpr_Valueto, 2);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21ParametroDtVigenciaIni_To2", context.localUtil.Format(AV21ParametroDtVigenciaIni_To2, "99/99/99"));
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
                  if ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PARAMETRODTVIGENCIAINI") == 0 )
                  {
                     AV24DynamicFiltersOperator3 = AV10GridStateDynamicFilter.gxTpr_Operator;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24DynamicFiltersOperator3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0)));
                     AV25ParametroDtVigenciaIni3 = context.localUtil.CToD( AV10GridStateDynamicFilter.gxTpr_Value, 2);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25ParametroDtVigenciaIni3", context.localUtil.Format(AV25ParametroDtVigenciaIni3, "99/99/99"));
                     AV26ParametroDtVigenciaIni_To3 = context.localUtil.CToD( AV10GridStateDynamicFilter.gxTpr_Valueto, 2);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26ParametroDtVigenciaIni_To3", context.localUtil.Format(AV26ParametroDtVigenciaIni_To3, "99/99/99"));
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
            if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PARAMETRODTVIGENCIAINI") == 0 ) && ! ( (DateTime.MinValue==AV15ParametroDtVigenciaIni1) && (DateTime.MinValue==AV16ParametroDtVigenciaIni_To1) ) )
            {
               AV10GridStateDynamicFilter.gxTpr_Value = context.localUtil.DToC( AV15ParametroDtVigenciaIni1, 2, "/");
               AV10GridStateDynamicFilter.gxTpr_Operator = AV14DynamicFiltersOperator1;
               AV10GridStateDynamicFilter.gxTpr_Valueto = context.localUtil.DToC( AV16ParametroDtVigenciaIni_To1, 2, "/");
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
            if ( ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PARAMETRODTVIGENCIAINI") == 0 ) && ! ( (DateTime.MinValue==AV20ParametroDtVigenciaIni2) && (DateTime.MinValue==AV21ParametroDtVigenciaIni_To2) ) )
            {
               AV10GridStateDynamicFilter.gxTpr_Value = context.localUtil.DToC( AV20ParametroDtVigenciaIni2, 2, "/");
               AV10GridStateDynamicFilter.gxTpr_Operator = AV19DynamicFiltersOperator2;
               AV10GridStateDynamicFilter.gxTpr_Valueto = context.localUtil.DToC( AV21ParametroDtVigenciaIni_To2, 2, "/");
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
            if ( ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PARAMETRODTVIGENCIAINI") == 0 ) && ! ( (DateTime.MinValue==AV25ParametroDtVigenciaIni3) && (DateTime.MinValue==AV26ParametroDtVigenciaIni_To3) ) )
            {
               AV10GridStateDynamicFilter.gxTpr_Value = context.localUtil.DToC( AV25ParametroDtVigenciaIni3, 2, "/");
               AV10GridStateDynamicFilter.gxTpr_Operator = AV24DynamicFiltersOperator3;
               AV10GridStateDynamicFilter.gxTpr_Valueto = context.localUtil.DToC( AV26ParametroDtVigenciaIni_To3, 2, "/");
            }
            if ( AV27DynamicFiltersRemoving || ! String.IsNullOrEmpty(StringUtil.RTrim( AV10GridStateDynamicFilter.gxTpr_Value)) || ! String.IsNullOrEmpty(StringUtil.RTrim( AV10GridStateDynamicFilter.gxTpr_Valueto)) )
            {
               AV8GridState.gxTpr_Dynamicfilters.Add(AV10GridStateDynamicFilter, 0);
            }
         }
      }

      protected void wb_table1_14_0W2( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgCleanfilters_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "Limpar filtros", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgCleanfilters_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'DOCLEANFILTERS\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_ParametroPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_19_0W2( true) ;
         }
         else
         {
            wb_table2_19_0W2( false) ;
         }
         return  ;
      }

      protected void wb_table2_19_0W2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_14_0W2e( true) ;
         }
         else
         {
            wb_table1_14_0W2e( false) ;
         }
      }

      protected void wb_table2_19_0W2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTabledynamicfilters_Internalname, tblTabledynamicfilters_Internalname, "", "TableDynamicFilters", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersprefix1_Internalname, "Filtrar por", "", "", lblDynamicfiltersprefix1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescriptionPrefix", 0, "", 1, 1, 0, "HLP_ParametroPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavDynamicfiltersselector1_Internalname, "Dynamic Filters Selector1", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'" + sGXsfl_119_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersselector1, cmbavDynamicfiltersselector1_Internalname, StringUtil.RTrim( AV13DynamicFiltersSelector1), 1, cmbavDynamicfiltersselector1_Jsonclick, 5, "'"+""+"'"+",false,"+"'"+"EVDYNAMICFILTERSSELECTOR1.CLICK."+"'", "svchar", "", 1, cmbavDynamicfiltersselector1.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,25);\"", "", true, "HLP_ParametroPrompt.htm");
            cmbavDynamicfiltersselector1.CurrentValue = StringUtil.RTrim( AV13DynamicFiltersSelector1);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector1_Internalname, "Values", (String)(cmbavDynamicfiltersselector1.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersmiddle1_Internalname, "valor", "", "", lblDynamicfiltersmiddle1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescription", 0, "", 1, 1, 0, "HLP_ParametroPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table3_29_0W2( true) ;
         }
         else
         {
            wb_table3_29_0W2( false) ;
         }
         return  ;
      }

      protected void wb_table3_29_0W2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table4_46_0W2( true) ;
         }
         else
         {
            wb_table4_46_0W2( false) ;
         }
         return  ;
      }

      protected void wb_table4_46_0W2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersprefix2_Internalname, "Filtrar por", "", "", lblDynamicfiltersprefix2_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescriptionPrefix", 0, "", 1, 1, 0, "HLP_ParametroPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavDynamicfiltersselector2_Internalname, "Dynamic Filters Selector2", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'" + sGXsfl_119_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersselector2, cmbavDynamicfiltersselector2_Internalname, StringUtil.RTrim( AV18DynamicFiltersSelector2), 1, cmbavDynamicfiltersselector2_Jsonclick, 5, "'"+""+"'"+",false,"+"'"+"EVDYNAMICFILTERSSELECTOR2.CLICK."+"'", "svchar", "", 1, cmbavDynamicfiltersselector2.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,57);\"", "", true, "HLP_ParametroPrompt.htm");
            cmbavDynamicfiltersselector2.CurrentValue = StringUtil.RTrim( AV18DynamicFiltersSelector2);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector2_Internalname, "Values", (String)(cmbavDynamicfiltersselector2.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersmiddle2_Internalname, "valor", "", "", lblDynamicfiltersmiddle2_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescription", 0, "", 1, 1, 0, "HLP_ParametroPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            wb_table5_61_0W2( true) ;
         }
         else
         {
            wb_table5_61_0W2( false) ;
         }
         return  ;
      }

      protected void wb_table5_61_0W2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            wb_table6_78_0W2( true) ;
         }
         else
         {
            wb_table6_78_0W2( false) ;
         }
         return  ;
      }

      protected void wb_table6_78_0W2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersprefix3_Internalname, "Filtrar por", "", "", lblDynamicfiltersprefix3_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescriptionPrefix", 0, "", 1, 1, 0, "HLP_ParametroPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavDynamicfiltersselector3_Internalname, "Dynamic Filters Selector3", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 89,'',false,'" + sGXsfl_119_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersselector3, cmbavDynamicfiltersselector3_Internalname, StringUtil.RTrim( AV23DynamicFiltersSelector3), 1, cmbavDynamicfiltersselector3_Jsonclick, 5, "'"+""+"'"+",false,"+"'"+"EVDYNAMICFILTERSSELECTOR3.CLICK."+"'", "svchar", "", 1, cmbavDynamicfiltersselector3.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,89);\"", "", true, "HLP_ParametroPrompt.htm");
            cmbavDynamicfiltersselector3.CurrentValue = StringUtil.RTrim( AV23DynamicFiltersSelector3);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector3_Internalname, "Values", (String)(cmbavDynamicfiltersselector3.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersmiddle3_Internalname, "valor", "", "", lblDynamicfiltersmiddle3_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescription", 0, "", 1, 1, 0, "HLP_ParametroPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            wb_table7_93_0W2( true) ;
         }
         else
         {
            wb_table7_93_0W2( false) ;
         }
         return  ;
      }

      protected void wb_table7_93_0W2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            wb_table8_110_0W2( true) ;
         }
         else
         {
            wb_table8_110_0W2( false) ;
         }
         return  ;
      }

      protected void wb_table8_110_0W2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_19_0W2e( true) ;
         }
         else
         {
            wb_table2_19_0W2e( false) ;
         }
      }

      protected void wb_table8_110_0W2( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgRemovedynamicfilters3_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "Remover filtro", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgRemovedynamicfilters3_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'REMOVEDYNAMICFILTERS3\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_ParametroPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table8_110_0W2e( true) ;
         }
         else
         {
            wb_table8_110_0W2e( false) ;
         }
      }

      protected void wb_table7_93_0W2( bool wbgen )
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
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersoperator3, cmbavDynamicfiltersoperator3_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0)), 1, cmbavDynamicfiltersoperator3_Jsonclick, 5, "'"+""+"'"+",false,"+"'"+"EVDYNAMICFILTERSOPERATOR3.CLICK."+"'", "int", "", cmbavDynamicfiltersoperator3.Visible, cmbavDynamicfiltersoperator3.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,97);\"", "", true, "HLP_ParametroPrompt.htm");
            cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", (String)(cmbavDynamicfiltersoperator3.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellFilter_parametrodtvigenciaini3_cell_Internalname+"\"  class=''>") ;
            wb_table9_99_0W2( true) ;
         }
         else
         {
            wb_table9_99_0W2( false) ;
         }
         return  ;
      }

      protected void wb_table9_99_0W2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table7_93_0W2e( true) ;
         }
         else
         {
            wb_table7_93_0W2e( false) ;
         }
      }

      protected void wb_table9_99_0W2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            if ( tblTablemergeddynamicfiltersparametrodtvigenciaini3_Visible == 0 )
            {
               sStyleString = sStyleString + "display:none;";
            }
            GxWebStd.gx_table_start( context, tblTablemergeddynamicfiltersparametrodtvigenciaini3_Internalname, tblTablemergeddynamicfiltersparametrodtvigenciaini3_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\""+cellParametrodtvigenciaini_cell3_Internalname+"\"  class='"+cellParametrodtvigenciaini_cell3_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavParametrodtvigenciaini3_Internalname, "Parametro Dt Vigencia Ini3", "col-sm-3 AttributeDateLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 103,'',false,'" + sGXsfl_119_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavParametrodtvigenciaini3_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavParametrodtvigenciaini3_Internalname, context.localUtil.Format(AV25ParametroDtVigenciaIni3, "99/99/99"), context.localUtil.Format( AV25ParametroDtVigenciaIni3, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,103);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavParametrodtvigenciaini3_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavParametrodtvigenciaini3_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ParametroPrompt.htm");
            GxWebStd.gx_bitmap( context, edtavParametrodtvigenciaini3_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavParametrodtvigenciaini3_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_ParametroPrompt.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellParametrodtvigenciaini_rangemiddletext_1_cell3_Internalname+"\"  class=''>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblParametrodtvigenciaini_rangemiddletext_13_Internalname, "até", "", "", lblParametrodtvigenciaini_rangemiddletext_13_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", lblParametrodtvigenciaini_rangemiddletext_13_Class, 0, "", 1, 1, 0, "HLP_ParametroPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellParametrodtvigenciaini_to_cell3_Internalname+"\"  class='"+cellParametrodtvigenciaini_to_cell3_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavParametrodtvigenciaini_to3_Internalname, "Parametro Dt Vigencia Ini_To3", "col-sm-3 AttributeDateLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 108,'',false,'" + sGXsfl_119_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavParametrodtvigenciaini_to3_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavParametrodtvigenciaini_to3_Internalname, context.localUtil.Format(AV26ParametroDtVigenciaIni_To3, "99/99/99"), context.localUtil.Format( AV26ParametroDtVigenciaIni_To3, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,108);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavParametrodtvigenciaini_to3_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavParametrodtvigenciaini_to3_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ParametroPrompt.htm");
            GxWebStd.gx_bitmap( context, edtavParametrodtvigenciaini_to3_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavParametrodtvigenciaini_to3_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_ParametroPrompt.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table9_99_0W2e( true) ;
         }
         else
         {
            wb_table9_99_0W2e( false) ;
         }
      }

      protected void wb_table6_78_0W2( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgAdddynamicfilters2_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgAdddynamicfilters2_Visible, 1, "", "Adicionar filtro", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgAdddynamicfilters2_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'ADDDYNAMICFILTERS2\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_ParametroPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellDynamicfilters_removefilter2_cell_Internalname+"\"  class=''>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'',0)\"";
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "11a6ef14-1a5a-4077-91a2-f41ed9a3a662", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgRemovedynamicfilters2_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgRemovedynamicfilters2_Visible, 1, "", "Remover filtro", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgRemovedynamicfilters2_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'REMOVEDYNAMICFILTERS2\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_ParametroPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table6_78_0W2e( true) ;
         }
         else
         {
            wb_table6_78_0W2e( false) ;
         }
      }

      protected void wb_table5_61_0W2( bool wbgen )
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
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersoperator2, cmbavDynamicfiltersoperator2_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0)), 1, cmbavDynamicfiltersoperator2_Jsonclick, 5, "'"+""+"'"+",false,"+"'"+"EVDYNAMICFILTERSOPERATOR2.CLICK."+"'", "int", "", cmbavDynamicfiltersoperator2.Visible, cmbavDynamicfiltersoperator2.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,65);\"", "", true, "HLP_ParametroPrompt.htm");
            cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", (String)(cmbavDynamicfiltersoperator2.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellFilter_parametrodtvigenciaini2_cell_Internalname+"\"  class=''>") ;
            wb_table10_67_0W2( true) ;
         }
         else
         {
            wb_table10_67_0W2( false) ;
         }
         return  ;
      }

      protected void wb_table10_67_0W2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_61_0W2e( true) ;
         }
         else
         {
            wb_table5_61_0W2e( false) ;
         }
      }

      protected void wb_table10_67_0W2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            if ( tblTablemergeddynamicfiltersparametrodtvigenciaini2_Visible == 0 )
            {
               sStyleString = sStyleString + "display:none;";
            }
            GxWebStd.gx_table_start( context, tblTablemergeddynamicfiltersparametrodtvigenciaini2_Internalname, tblTablemergeddynamicfiltersparametrodtvigenciaini2_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\""+cellParametrodtvigenciaini_cell2_Internalname+"\"  class='"+cellParametrodtvigenciaini_cell2_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavParametrodtvigenciaini2_Internalname, "Parametro Dt Vigencia Ini2", "col-sm-3 AttributeDateLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'" + sGXsfl_119_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavParametrodtvigenciaini2_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavParametrodtvigenciaini2_Internalname, context.localUtil.Format(AV20ParametroDtVigenciaIni2, "99/99/99"), context.localUtil.Format( AV20ParametroDtVigenciaIni2, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,71);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavParametrodtvigenciaini2_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavParametrodtvigenciaini2_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ParametroPrompt.htm");
            GxWebStd.gx_bitmap( context, edtavParametrodtvigenciaini2_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavParametrodtvigenciaini2_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_ParametroPrompt.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellParametrodtvigenciaini_rangemiddletext_1_cell2_Internalname+"\"  class=''>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblParametrodtvigenciaini_rangemiddletext_12_Internalname, "até", "", "", lblParametrodtvigenciaini_rangemiddletext_12_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", lblParametrodtvigenciaini_rangemiddletext_12_Class, 0, "", 1, 1, 0, "HLP_ParametroPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellParametrodtvigenciaini_to_cell2_Internalname+"\"  class='"+cellParametrodtvigenciaini_to_cell2_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavParametrodtvigenciaini_to2_Internalname, "Parametro Dt Vigencia Ini_To2", "col-sm-3 AttributeDateLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_119_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavParametrodtvigenciaini_to2_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavParametrodtvigenciaini_to2_Internalname, context.localUtil.Format(AV21ParametroDtVigenciaIni_To2, "99/99/99"), context.localUtil.Format( AV21ParametroDtVigenciaIni_To2, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavParametrodtvigenciaini_to2_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavParametrodtvigenciaini_to2_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ParametroPrompt.htm");
            GxWebStd.gx_bitmap( context, edtavParametrodtvigenciaini_to2_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavParametrodtvigenciaini_to2_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_ParametroPrompt.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table10_67_0W2e( true) ;
         }
         else
         {
            wb_table10_67_0W2e( false) ;
         }
      }

      protected void wb_table4_46_0W2( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgAdddynamicfilters1_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgAdddynamicfilters1_Visible, 1, "", "Adicionar filtro", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgAdddynamicfilters1_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'ADDDYNAMICFILTERS1\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_ParametroPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellDynamicfilters_removefilter1_cell_Internalname+"\"  class=''>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'',0)\"";
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "11a6ef14-1a5a-4077-91a2-f41ed9a3a662", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgRemovedynamicfilters1_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgRemovedynamicfilters1_Visible, 1, "", "Remover filtro", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgRemovedynamicfilters1_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'REMOVEDYNAMICFILTERS1\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_ParametroPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_46_0W2e( true) ;
         }
         else
         {
            wb_table4_46_0W2e( false) ;
         }
      }

      protected void wb_table3_29_0W2( bool wbgen )
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
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersoperator1, cmbavDynamicfiltersoperator1_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0)), 1, cmbavDynamicfiltersoperator1_Jsonclick, 5, "'"+""+"'"+",false,"+"'"+"EVDYNAMICFILTERSOPERATOR1.CLICK."+"'", "int", "", cmbavDynamicfiltersoperator1.Visible, cmbavDynamicfiltersoperator1.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,33);\"", "", true, "HLP_ParametroPrompt.htm");
            cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", (String)(cmbavDynamicfiltersoperator1.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellFilter_parametrodtvigenciaini1_cell_Internalname+"\"  class=''>") ;
            wb_table11_35_0W2( true) ;
         }
         else
         {
            wb_table11_35_0W2( false) ;
         }
         return  ;
      }

      protected void wb_table11_35_0W2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_29_0W2e( true) ;
         }
         else
         {
            wb_table3_29_0W2e( false) ;
         }
      }

      protected void wb_table11_35_0W2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            if ( tblTablemergeddynamicfiltersparametrodtvigenciaini1_Visible == 0 )
            {
               sStyleString = sStyleString + "display:none;";
            }
            GxWebStd.gx_table_start( context, tblTablemergeddynamicfiltersparametrodtvigenciaini1_Internalname, tblTablemergeddynamicfiltersparametrodtvigenciaini1_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\""+cellParametrodtvigenciaini_cell1_Internalname+"\"  class='"+cellParametrodtvigenciaini_cell1_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavParametrodtvigenciaini1_Internalname, "Parametro Dt Vigencia Ini1", "col-sm-3 AttributeDateLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_119_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavParametrodtvigenciaini1_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavParametrodtvigenciaini1_Internalname, context.localUtil.Format(AV15ParametroDtVigenciaIni1, "99/99/99"), context.localUtil.Format( AV15ParametroDtVigenciaIni1, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavParametrodtvigenciaini1_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavParametrodtvigenciaini1_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ParametroPrompt.htm");
            GxWebStd.gx_bitmap( context, edtavParametrodtvigenciaini1_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavParametrodtvigenciaini1_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_ParametroPrompt.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellParametrodtvigenciaini_rangemiddletext_1_cell1_Internalname+"\"  class=''>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblParametrodtvigenciaini_rangemiddletext_11_Internalname, "até", "", "", lblParametrodtvigenciaini_rangemiddletext_11_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", lblParametrodtvigenciaini_rangemiddletext_11_Class, 0, "", 1, 1, 0, "HLP_ParametroPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellParametrodtvigenciaini_to_cell1_Internalname+"\"  class='"+cellParametrodtvigenciaini_to_cell1_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavParametrodtvigenciaini_to1_Internalname, "Parametro Dt Vigencia Ini_To1", "col-sm-3 AttributeDateLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'" + sGXsfl_119_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavParametrodtvigenciaini_to1_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavParametrodtvigenciaini_to1_Internalname, context.localUtil.Format(AV16ParametroDtVigenciaIni_To1, "99/99/99"), context.localUtil.Format( AV16ParametroDtVigenciaIni_To1, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavParametrodtvigenciaini_to1_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavParametrodtvigenciaini_to1_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ParametroPrompt.htm");
            GxWebStd.gx_bitmap( context, edtavParametrodtvigenciaini_to1_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavParametrodtvigenciaini_to1_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_ParametroPrompt.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table11_35_0W2e( true) ;
         }
         else
         {
            wb_table11_35_0W2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV49InOutParametroID = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49InOutParametroID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV49InOutParametroID), 4, 0)));
         AV50InOutParametroDtVigenciaIni = (DateTime)getParm(obj,1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV50InOutParametroDtVigenciaIni", context.localUtil.Format(AV50InOutParametroDtVigenciaIni, "99/99/99"));
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
         PA0W2( ) ;
         WS0W2( ) ;
         WE0W2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201971120455224", true, true);
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
         context.AddJavascriptSource("parametroprompt.js", "?201971120455225", false, true);
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
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false, true);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_1192( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_119_idx;
         edtParametroID_Internalname = "PARAMETROID_"+sGXsfl_119_idx;
         edtParametroDtVigenciaIni_Internalname = "PARAMETRODTVIGENCIAINI_"+sGXsfl_119_idx;
         edtParametroDtVigenciaFim_Internalname = "PARAMETRODTVIGENCIAFIM_"+sGXsfl_119_idx;
         cmbParametroTipo_Internalname = "PARAMETROTIPO_"+sGXsfl_119_idx;
         cmbParametroPrioritaria_Internalname = "PARAMETROPRIORITARIA_"+sGXsfl_119_idx;
         edtParametroValor_Internalname = "PARAMETROVALOR_"+sGXsfl_119_idx;
         edtParametroPercentual_Internalname = "PARAMETROPERCENTUAL_"+sGXsfl_119_idx;
      }

      protected void SubsflControlProps_fel_1192( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_119_fel_idx;
         edtParametroID_Internalname = "PARAMETROID_"+sGXsfl_119_fel_idx;
         edtParametroDtVigenciaIni_Internalname = "PARAMETRODTVIGENCIAINI_"+sGXsfl_119_fel_idx;
         edtParametroDtVigenciaFim_Internalname = "PARAMETRODTVIGENCIAFIM_"+sGXsfl_119_fel_idx;
         cmbParametroTipo_Internalname = "PARAMETROTIPO_"+sGXsfl_119_fel_idx;
         cmbParametroPrioritaria_Internalname = "PARAMETROPRIORITARIA_"+sGXsfl_119_fel_idx;
         edtParametroValor_Internalname = "PARAMETROVALOR_"+sGXsfl_119_fel_idx;
         edtParametroPercentual_Internalname = "PARAMETROPERCENTUAL_"+sGXsfl_119_fel_idx;
      }

      protected void sendrow_1192( )
      {
         SubsflControlProps_1192( ) ;
         WB0W0( ) ;
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
            AV48Select_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV48Select))&&String.IsNullOrEmpty(StringUtil.RTrim( AV53Select_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV48Select)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV48Select)) ? AV53Select_GXI : context.PathToRelativeUrl( AV48Select));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavSelect_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavSelect_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavSelect_Jsonclick,"'"+""+"'"+",false,"+"'"+"EENTER."+sGXsfl_119_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV48Select_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtParametroID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A13ParametroID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A13ParametroID), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtParametroID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)119,(short)1,(short)-1,(short)0,(bool)true,(String)"Serial",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtParametroDtVigenciaIni_Internalname,context.localUtil.Format(A14ParametroDtVigenciaIni, "99/99/99"),context.localUtil.Format( A14ParametroDtVigenciaIni, "99/99/99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtParametroDtVigenciaIni_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)119,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtParametroDtVigenciaFim_Internalname,context.localUtil.Format(A15ParametroDtVigenciaFim, "99/99/99"),context.localUtil.Format( A15ParametroDtVigenciaFim, "99/99/99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtParametroDtVigenciaFim_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)119,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbParametroTipo.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "PARAMETROTIPO_" + sGXsfl_119_idx;
               cmbParametroTipo.Name = GXCCtl;
               cmbParametroTipo.WebTags = "";
               cmbParametroTipo.addItem("D", "Desconto", 0);
               cmbParametroTipo.addItem("F", "Frete", 0);
               if ( cmbParametroTipo.ItemCount > 0 )
               {
                  A16ParametroTipo = cmbParametroTipo.getValidValue(A16ParametroTipo);
               }
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbParametroTipo,(String)cmbParametroTipo_Internalname,StringUtil.RTrim( A16ParametroTipo),(short)1,(String)cmbParametroTipo_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"char",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn hidden-xs",(String)"",(String)"",(String)"",(bool)true});
            cmbParametroTipo.CurrentValue = StringUtil.RTrim( A16ParametroTipo);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbParametroTipo_Internalname, "Values", (String)(cmbParametroTipo.ToJavascriptSource()), !bGXsfl_119_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbParametroPrioritaria.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "PARAMETROPRIORITARIA_" + sGXsfl_119_idx;
               cmbParametroPrioritaria.Name = GXCCtl;
               cmbParametroPrioritaria.WebTags = "";
               if ( cmbParametroPrioritaria.ItemCount > 0 )
               {
                  A17ParametroPrioritaria = cmbParametroPrioritaria.getValidValue(A17ParametroPrioritaria);
               }
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbParametroPrioritaria,(String)cmbParametroPrioritaria_Internalname,StringUtil.RTrim( A17ParametroPrioritaria),(short)1,(String)cmbParametroPrioritaria_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"char",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn hidden-xs",(String)"",(String)"",(String)"",(bool)true});
            cmbParametroPrioritaria.CurrentValue = StringUtil.RTrim( A17ParametroPrioritaria);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbParametroPrioritaria_Internalname, "Values", (String)(cmbParametroPrioritaria.ToJavascriptSource()), !bGXsfl_119_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtParametroValor_Internalname,StringUtil.LTrim( StringUtil.NToC( A18ParametroValor, 14, 2, ",", "")),context.localUtil.Format( A18ParametroValor, "ZZZ,ZZZ,ZZ9.99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtParametroValor_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)14,(short)0,(short)0,(short)119,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtParametroPercentual_Internalname,StringUtil.LTrim( StringUtil.NToC( A19ParametroPercentual, 6, 2, ",", "")),context.localUtil.Format( A19ParametroPercentual, "ZZ9.99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtParametroPercentual_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)6,(short)0,(short)0,(short)119,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            send_integrity_lvl_hashes0W2( ) ;
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
         cmbavDynamicfiltersselector1.addItem("PARAMETRODTVIGENCIAINI", "Vigência Inicial", 0);
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
         cmbavDynamicfiltersselector2.addItem("PARAMETRODTVIGENCIAINI", "Vigência Inicial", 0);
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
         cmbavDynamicfiltersselector3.addItem("PARAMETRODTVIGENCIAINI", "Vigência Inicial", 0);
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
         GXCCtl = "PARAMETROTIPO_" + sGXsfl_119_idx;
         cmbParametroTipo.Name = GXCCtl;
         cmbParametroTipo.WebTags = "";
         cmbParametroTipo.addItem("D", "Desconto", 0);
         cmbParametroTipo.addItem("F", "Frete", 0);
         if ( cmbParametroTipo.ItemCount > 0 )
         {
            A16ParametroTipo = cmbParametroTipo.getValidValue(A16ParametroTipo);
         }
         GXCCtl = "PARAMETROPRIORITARIA_" + sGXsfl_119_idx;
         cmbParametroPrioritaria.Name = GXCCtl;
         cmbParametroPrioritaria.WebTags = "";
         if ( cmbParametroPrioritaria.ItemCount > 0 )
         {
            A17ParametroPrioritaria = cmbParametroPrioritaria.getValidValue(A17ParametroPrioritaria);
         }
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
         edtavParametrodtvigenciaini1_Internalname = "vPARAMETRODTVIGENCIAINI1";
         cellParametrodtvigenciaini_cell1_Internalname = "PARAMETRODTVIGENCIAINI_CELL1";
         lblParametrodtvigenciaini_rangemiddletext_11_Internalname = "PARAMETRODTVIGENCIAINI_RANGEMIDDLETEXT_11";
         cellParametrodtvigenciaini_rangemiddletext_1_cell1_Internalname = "PARAMETRODTVIGENCIAINI_RANGEMIDDLETEXT_1_CELL1";
         edtavParametrodtvigenciaini_to1_Internalname = "vPARAMETRODTVIGENCIAINI_TO1";
         cellParametrodtvigenciaini_to_cell1_Internalname = "PARAMETRODTVIGENCIAINI_TO_CELL1";
         tblTablemergeddynamicfiltersparametrodtvigenciaini1_Internalname = "TABLEMERGEDDYNAMICFILTERSPARAMETRODTVIGENCIAINI1";
         cellFilter_parametrodtvigenciaini1_cell_Internalname = "FILTER_PARAMETRODTVIGENCIAINI1_CELL";
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
         edtavParametrodtvigenciaini2_Internalname = "vPARAMETRODTVIGENCIAINI2";
         cellParametrodtvigenciaini_cell2_Internalname = "PARAMETRODTVIGENCIAINI_CELL2";
         lblParametrodtvigenciaini_rangemiddletext_12_Internalname = "PARAMETRODTVIGENCIAINI_RANGEMIDDLETEXT_12";
         cellParametrodtvigenciaini_rangemiddletext_1_cell2_Internalname = "PARAMETRODTVIGENCIAINI_RANGEMIDDLETEXT_1_CELL2";
         edtavParametrodtvigenciaini_to2_Internalname = "vPARAMETRODTVIGENCIAINI_TO2";
         cellParametrodtvigenciaini_to_cell2_Internalname = "PARAMETRODTVIGENCIAINI_TO_CELL2";
         tblTablemergeddynamicfiltersparametrodtvigenciaini2_Internalname = "TABLEMERGEDDYNAMICFILTERSPARAMETRODTVIGENCIAINI2";
         cellFilter_parametrodtvigenciaini2_cell_Internalname = "FILTER_PARAMETRODTVIGENCIAINI2_CELL";
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
         edtavParametrodtvigenciaini3_Internalname = "vPARAMETRODTVIGENCIAINI3";
         cellParametrodtvigenciaini_cell3_Internalname = "PARAMETRODTVIGENCIAINI_CELL3";
         lblParametrodtvigenciaini_rangemiddletext_13_Internalname = "PARAMETRODTVIGENCIAINI_RANGEMIDDLETEXT_13";
         cellParametrodtvigenciaini_rangemiddletext_1_cell3_Internalname = "PARAMETRODTVIGENCIAINI_RANGEMIDDLETEXT_1_CELL3";
         edtavParametrodtvigenciaini_to3_Internalname = "vPARAMETRODTVIGENCIAINI_TO3";
         cellParametrodtvigenciaini_to_cell3_Internalname = "PARAMETRODTVIGENCIAINI_TO_CELL3";
         tblTablemergeddynamicfiltersparametrodtvigenciaini3_Internalname = "TABLEMERGEDDYNAMICFILTERSPARAMETRODTVIGENCIAINI3";
         cellFilter_parametrodtvigenciaini3_cell_Internalname = "FILTER_PARAMETRODTVIGENCIAINI3_CELL";
         tblTablemergeddynamicfilters3_Internalname = "TABLEMERGEDDYNAMICFILTERS3";
         imgRemovedynamicfilters3_Internalname = "REMOVEDYNAMICFILTERS3";
         cellDynamicfilters_removefilter3_cell_Internalname = "DYNAMICFILTERS_REMOVEFILTER3_CELL";
         tblUnnamedtabledynamicfilters_3_Internalname = "UNNAMEDTABLEDYNAMICFILTERS_3";
         tblTabledynamicfilters_Internalname = "TABLEDYNAMICFILTERS";
         tblTablefilters_Internalname = "TABLEFILTERS";
         divTableheader_Internalname = "TABLEHEADER";
         Dvpanel_tableheader_Internalname = "DVPANEL_TABLEHEADER";
         edtavSelect_Internalname = "vSELECT";
         edtParametroID_Internalname = "PARAMETROID";
         edtParametroDtVigenciaIni_Internalname = "PARAMETRODTVIGENCIAINI";
         edtParametroDtVigenciaFim_Internalname = "PARAMETRODTVIGENCIAFIM";
         cmbParametroTipo_Internalname = "PARAMETROTIPO";
         cmbParametroPrioritaria_Internalname = "PARAMETROPRIORITARIA";
         edtParametroValor_Internalname = "PARAMETROVALOR";
         edtParametroPercentual_Internalname = "PARAMETROPERCENTUAL";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         lblJsdynamicfilters_Internalname = "JSDYNAMICFILTERS";
         Ddo_parametroid_Internalname = "DDO_PARAMETROID";
         edtavDdo_parametroidtitlecontrolidtoreplace_Internalname = "vDDO_PARAMETROIDTITLECONTROLIDTOREPLACE";
         Ddo_parametrodtvigenciaini_Internalname = "DDO_PARAMETRODTVIGENCIAINI";
         edtavDdo_parametrodtvigenciainititlecontrolidtoreplace_Internalname = "vDDO_PARAMETRODTVIGENCIAINITITLECONTROLIDTOREPLACE";
         Ddo_parametrodtvigenciafim_Internalname = "DDO_PARAMETRODTVIGENCIAFIM";
         edtavDdo_parametrodtvigenciafimtitlecontrolidtoreplace_Internalname = "vDDO_PARAMETRODTVIGENCIAFIMTITLECONTROLIDTOREPLACE";
         Ddo_parametrotipo_Internalname = "DDO_PARAMETROTIPO";
         edtavDdo_parametrotipotitlecontrolidtoreplace_Internalname = "vDDO_PARAMETROTIPOTITLECONTROLIDTOREPLACE";
         Ddo_parametroprioritaria_Internalname = "DDO_PARAMETROPRIORITARIA";
         edtavDdo_parametroprioritariatitlecontrolidtoreplace_Internalname = "vDDO_PARAMETROPRIORITARIATITLECONTROLIDTOREPLACE";
         Ddo_parametrovalor_Internalname = "DDO_PARAMETROVALOR";
         edtavDdo_parametrovalortitlecontrolidtoreplace_Internalname = "vDDO_PARAMETROVALORTITLECONTROLIDTOREPLACE";
         Ddo_parametropercentual_Internalname = "DDO_PARAMETROPERCENTUAL";
         edtavDdo_parametropercentualtitlecontrolidtoreplace_Internalname = "vDDO_PARAMETROPERCENTUALTITLECONTROLIDTOREPLACE";
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
         edtParametroPercentual_Jsonclick = "";
         edtParametroValor_Jsonclick = "";
         cmbParametroPrioritaria_Jsonclick = "";
         cmbParametroTipo_Jsonclick = "";
         edtParametroDtVigenciaFim_Jsonclick = "";
         edtParametroDtVigenciaIni_Jsonclick = "";
         edtParametroID_Jsonclick = "";
         edtavSelect_Jsonclick = "";
         edtavSelect_Visible = -1;
         edtavSelect_Enabled = 1;
         edtavParametrodtvigenciaini_to1_Jsonclick = "";
         edtavParametrodtvigenciaini_to1_Enabled = 1;
         cellParametrodtvigenciaini_to_cell1_Class = "";
         edtavParametrodtvigenciaini1_Jsonclick = "";
         edtavParametrodtvigenciaini1_Enabled = 1;
         cmbavDynamicfiltersoperator1_Jsonclick = "";
         cmbavDynamicfiltersoperator1.Enabled = 1;
         imgRemovedynamicfilters1_Visible = 1;
         imgAdddynamicfilters1_Visible = 1;
         edtavParametrodtvigenciaini_to2_Jsonclick = "";
         edtavParametrodtvigenciaini_to2_Enabled = 1;
         cellParametrodtvigenciaini_to_cell2_Class = "";
         edtavParametrodtvigenciaini2_Jsonclick = "";
         edtavParametrodtvigenciaini2_Enabled = 1;
         cmbavDynamicfiltersoperator2_Jsonclick = "";
         cmbavDynamicfiltersoperator2.Enabled = 1;
         imgRemovedynamicfilters2_Visible = 1;
         imgAdddynamicfilters2_Visible = 1;
         edtavParametrodtvigenciaini_to3_Jsonclick = "";
         edtavParametrodtvigenciaini_to3_Enabled = 1;
         cellParametrodtvigenciaini_to_cell3_Class = "";
         edtavParametrodtvigenciaini3_Jsonclick = "";
         edtavParametrodtvigenciaini3_Enabled = 1;
         cmbavDynamicfiltersoperator3_Jsonclick = "";
         cmbavDynamicfiltersoperator3.Enabled = 1;
         cmbavDynamicfiltersselector3_Jsonclick = "";
         cmbavDynamicfiltersselector3.Enabled = 1;
         cmbavDynamicfiltersselector2_Jsonclick = "";
         cmbavDynamicfiltersselector2.Enabled = 1;
         cmbavDynamicfiltersselector1_Jsonclick = "";
         cmbavDynamicfiltersselector1.Enabled = 1;
         lblParametrodtvigenciaini_rangemiddletext_13_Class = "DataFilterDescription";
         cellParametrodtvigenciaini_cell3_Class = "MergeDataCell";
         cmbavDynamicfiltersoperator3.Visible = 1;
         tblTablemergeddynamicfiltersparametrodtvigenciaini3_Visible = 1;
         lblParametrodtvigenciaini_rangemiddletext_12_Class = "DataFilterDescription";
         cellParametrodtvigenciaini_cell2_Class = "MergeDataCell";
         cmbavDynamicfiltersoperator2.Visible = 1;
         tblTablemergeddynamicfiltersparametrodtvigenciaini2_Visible = 1;
         lblParametrodtvigenciaini_rangemiddletext_11_Class = "DataFilterDescription";
         cellParametrodtvigenciaini_cell1_Class = "MergeDataCell";
         cmbavDynamicfiltersoperator1.Visible = 1;
         tblTablemergeddynamicfiltersparametrodtvigenciaini1_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         chkavDynamicfiltersenabled3.Visible = 1;
         chkavDynamicfiltersenabled2.Visible = 1;
         edtavDdo_parametropercentualtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_parametrovalortitlecontrolidtoreplace_Visible = 1;
         edtavDdo_parametroprioritariatitlecontrolidtoreplace_Visible = 1;
         edtavDdo_parametrotipotitlecontrolidtoreplace_Visible = 1;
         edtavDdo_parametrodtvigenciafimtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_parametrodtvigenciainititlecontrolidtoreplace_Visible = 1;
         edtavDdo_parametroidtitlecontrolidtoreplace_Visible = 1;
         lblJsdynamicfilters_Caption = "JSDynamicFilters";
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavSelect_Tooltiptext = "Selecionar";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtParametroPercentual_Titleformat = 0;
         edtParametroPercentual_Title = "Percentual";
         edtParametroValor_Titleformat = 0;
         edtParametroValor_Title = "Valor";
         cmbParametroPrioritaria_Titleformat = 0;
         cmbParametroPrioritaria.Title.Text = "Prioritaria";
         cmbParametroTipo_Titleformat = 0;
         cmbParametroTipo.Title.Text = "Tipo";
         edtParametroDtVigenciaFim_Titleformat = 0;
         edtParametroDtVigenciaFim_Title = "Vigência Final";
         edtParametroDtVigenciaIni_Titleformat = 0;
         edtParametroDtVigenciaIni_Title = "Vigência Inicial";
         edtParametroID_Titleformat = 0;
         edtParametroID_Title = "Id";
         subGrid_Class = "GridWithPaginationBar GridNoBorder WorkWith";
         subGrid_Backcolorstyle = 0;
         Ddo_parametropercentual_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_parametropercentual_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_parametropercentual_Sortdsc = "WWP_TSSortDSC";
         Ddo_parametropercentual_Sortasc = "WWP_TSSortASC";
         Ddo_parametropercentual_Includedatalist = Convert.ToBoolean( 0);
         Ddo_parametropercentual_Includefilter = Convert.ToBoolean( 0);
         Ddo_parametropercentual_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_parametropercentual_Includesortasc = Convert.ToBoolean( -1);
         Ddo_parametropercentual_Titlecontrolidtoreplace = "";
         Ddo_parametropercentual_Dropdownoptionstype = "GridTitleSettings";
         Ddo_parametropercentual_Cls = "ColumnSettings";
         Ddo_parametropercentual_Tooltip = "WWP_TSColumnOptions";
         Ddo_parametropercentual_Caption = "";
         Ddo_parametrovalor_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_parametrovalor_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_parametrovalor_Sortdsc = "WWP_TSSortDSC";
         Ddo_parametrovalor_Sortasc = "WWP_TSSortASC";
         Ddo_parametrovalor_Includedatalist = Convert.ToBoolean( 0);
         Ddo_parametrovalor_Includefilter = Convert.ToBoolean( 0);
         Ddo_parametrovalor_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_parametrovalor_Includesortasc = Convert.ToBoolean( -1);
         Ddo_parametrovalor_Titlecontrolidtoreplace = "";
         Ddo_parametrovalor_Dropdownoptionstype = "GridTitleSettings";
         Ddo_parametrovalor_Cls = "ColumnSettings";
         Ddo_parametrovalor_Tooltip = "WWP_TSColumnOptions";
         Ddo_parametrovalor_Caption = "";
         Ddo_parametroprioritaria_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_parametroprioritaria_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_parametroprioritaria_Sortdsc = "WWP_TSSortDSC";
         Ddo_parametroprioritaria_Sortasc = "WWP_TSSortASC";
         Ddo_parametroprioritaria_Includedatalist = Convert.ToBoolean( 0);
         Ddo_parametroprioritaria_Includefilter = Convert.ToBoolean( 0);
         Ddo_parametroprioritaria_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_parametroprioritaria_Includesortasc = Convert.ToBoolean( -1);
         Ddo_parametroprioritaria_Titlecontrolidtoreplace = "";
         Ddo_parametroprioritaria_Dropdownoptionstype = "GridTitleSettings";
         Ddo_parametroprioritaria_Cls = "ColumnSettings";
         Ddo_parametroprioritaria_Tooltip = "WWP_TSColumnOptions";
         Ddo_parametroprioritaria_Caption = "";
         Ddo_parametrotipo_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_parametrotipo_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_parametrotipo_Sortdsc = "WWP_TSSortDSC";
         Ddo_parametrotipo_Sortasc = "WWP_TSSortASC";
         Ddo_parametrotipo_Includedatalist = Convert.ToBoolean( 0);
         Ddo_parametrotipo_Includefilter = Convert.ToBoolean( 0);
         Ddo_parametrotipo_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_parametrotipo_Includesortasc = Convert.ToBoolean( -1);
         Ddo_parametrotipo_Titlecontrolidtoreplace = "";
         Ddo_parametrotipo_Dropdownoptionstype = "GridTitleSettings";
         Ddo_parametrotipo_Cls = "ColumnSettings";
         Ddo_parametrotipo_Tooltip = "WWP_TSColumnOptions";
         Ddo_parametrotipo_Caption = "";
         Ddo_parametrodtvigenciafim_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_parametrodtvigenciafim_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_parametrodtvigenciafim_Sortdsc = "WWP_TSSortDSC";
         Ddo_parametrodtvigenciafim_Sortasc = "WWP_TSSortASC";
         Ddo_parametrodtvigenciafim_Includedatalist = Convert.ToBoolean( 0);
         Ddo_parametrodtvigenciafim_Includefilter = Convert.ToBoolean( 0);
         Ddo_parametrodtvigenciafim_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_parametrodtvigenciafim_Includesortasc = Convert.ToBoolean( -1);
         Ddo_parametrodtvigenciafim_Titlecontrolidtoreplace = "";
         Ddo_parametrodtvigenciafim_Dropdownoptionstype = "GridTitleSettings";
         Ddo_parametrodtvigenciafim_Cls = "ColumnSettings";
         Ddo_parametrodtvigenciafim_Tooltip = "WWP_TSColumnOptions";
         Ddo_parametrodtvigenciafim_Caption = "";
         Ddo_parametrodtvigenciaini_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_parametrodtvigenciaini_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_parametrodtvigenciaini_Sortdsc = "WWP_TSSortDSC";
         Ddo_parametrodtvigenciaini_Sortasc = "WWP_TSSortASC";
         Ddo_parametrodtvigenciaini_Includedatalist = Convert.ToBoolean( 0);
         Ddo_parametrodtvigenciaini_Includefilter = Convert.ToBoolean( 0);
         Ddo_parametrodtvigenciaini_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_parametrodtvigenciaini_Includesortasc = Convert.ToBoolean( -1);
         Ddo_parametrodtvigenciaini_Titlecontrolidtoreplace = "";
         Ddo_parametrodtvigenciaini_Dropdownoptionstype = "GridTitleSettings";
         Ddo_parametrodtvigenciaini_Cls = "ColumnSettings";
         Ddo_parametrodtvigenciaini_Tooltip = "WWP_TSColumnOptions";
         Ddo_parametrodtvigenciaini_Caption = "";
         Ddo_parametroid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_parametroid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_parametroid_Sortdsc = "WWP_TSSortDSC";
         Ddo_parametroid_Sortasc = "WWP_TSSortASC";
         Ddo_parametroid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_parametroid_Includefilter = Convert.ToBoolean( 0);
         Ddo_parametroid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_parametroid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_parametroid_Titlecontrolidtoreplace = "";
         Ddo_parametroid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_parametroid_Cls = "ColumnSettings";
         Ddo_parametroid_Tooltip = "WWP_TSColumnOptions";
         Ddo_parametroid_Caption = "";
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
         Form.Caption = "Consulta de Parametro";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ParametroDtVigenciaIni1',fld:'vPARAMETRODTVIGENCIAINI1',pic:''},{av:'AV16ParametroDtVigenciaIni_To1',fld:'vPARAMETRODTVIGENCIAINI_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20ParametroDtVigenciaIni2',fld:'vPARAMETRODTVIGENCIAINI2',pic:''},{av:'AV21ParametroDtVigenciaIni_To2',fld:'vPARAMETRODTVIGENCIAINI_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25ParametroDtVigenciaIni3',fld:'vPARAMETRODTVIGENCIAINI3',pic:''},{av:'AV26ParametroDtVigenciaIni_To3',fld:'vPARAMETRODTVIGENCIAINI_TO3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31ddo_ParametroIDTitleControlIdToReplace',fld:'vDDO_PARAMETROIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAINITITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAFIMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_ParametroTipoTitleControlIdToReplace',fld:'vDDO_PARAMETROTIPOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_ParametroPrioritariaTitleControlIdToReplace',fld:'vDDO_PARAMETROPRIORITARIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_ParametroValorTitleControlIdToReplace',fld:'vDDO_PARAMETROVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_ParametroPercentualTitleControlIdToReplace',fld:'vDDO_PARAMETROPERCENTUALTITLECONTROLIDTOREPLACE',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV30ParametroIDTitleFilterData',fld:'vPARAMETROIDTITLEFILTERDATA',pic:''},{av:'AV32ParametroDtVigenciaIniTitleFilterData',fld:'vPARAMETRODTVIGENCIAINITITLEFILTERDATA',pic:''},{av:'AV34ParametroDtVigenciaFimTitleFilterData',fld:'vPARAMETRODTVIGENCIAFIMTITLEFILTERDATA',pic:''},{av:'AV36ParametroTipoTitleFilterData',fld:'vPARAMETROTIPOTITLEFILTERDATA',pic:''},{av:'AV38ParametroPrioritariaTitleFilterData',fld:'vPARAMETROPRIORITARIATITLEFILTERDATA',pic:''},{av:'AV40ParametroValorTitleFilterData',fld:'vPARAMETROVALORTITLEFILTERDATA',pic:''},{av:'AV42ParametroPercentualTitleFilterData',fld:'vPARAMETROPERCENTUALTITLEFILTERDATA',pic:''},{av:'edtParametroID_Titleformat',ctrl:'PARAMETROID',prop:'Titleformat'},{av:'edtParametroID_Title',ctrl:'PARAMETROID',prop:'Title'},{av:'edtParametroDtVigenciaIni_Titleformat',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Titleformat'},{av:'edtParametroDtVigenciaIni_Title',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Title'},{av:'edtParametroDtVigenciaFim_Titleformat',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Titleformat'},{av:'edtParametroDtVigenciaFim_Title',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Title'},{av:'cmbParametroTipo'},{av:'cmbParametroPrioritaria'},{av:'edtParametroValor_Titleformat',ctrl:'PARAMETROVALOR',prop:'Titleformat'},{av:'edtParametroValor_Title',ctrl:'PARAMETROVALOR',prop:'Title'},{av:'edtParametroPercentual_Titleformat',ctrl:'PARAMETROPERCENTUAL',prop:'Titleformat'},{av:'edtParametroPercentual_Title',ctrl:'PARAMETROPERCENTUAL',prop:'Title'},{av:'AV46GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV47GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E110W2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ParametroDtVigenciaIni1',fld:'vPARAMETRODTVIGENCIAINI1',pic:''},{av:'AV16ParametroDtVigenciaIni_To1',fld:'vPARAMETRODTVIGENCIAINI_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20ParametroDtVigenciaIni2',fld:'vPARAMETRODTVIGENCIAINI2',pic:''},{av:'AV21ParametroDtVigenciaIni_To2',fld:'vPARAMETRODTVIGENCIAINI_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25ParametroDtVigenciaIni3',fld:'vPARAMETRODTVIGENCIAINI3',pic:''},{av:'AV26ParametroDtVigenciaIni_To3',fld:'vPARAMETRODTVIGENCIAINI_TO3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31ddo_ParametroIDTitleControlIdToReplace',fld:'vDDO_PARAMETROIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAINITITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAFIMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_ParametroTipoTitleControlIdToReplace',fld:'vDDO_PARAMETROTIPOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_ParametroPrioritariaTitleControlIdToReplace',fld:'vDDO_PARAMETROPRIORITARIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_ParametroValorTitleControlIdToReplace',fld:'vDDO_PARAMETROVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_ParametroPercentualTitleControlIdToReplace',fld:'vDDO_PARAMETROPERCENTUALTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E120W2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ParametroDtVigenciaIni1',fld:'vPARAMETRODTVIGENCIAINI1',pic:''},{av:'AV16ParametroDtVigenciaIni_To1',fld:'vPARAMETRODTVIGENCIAINI_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20ParametroDtVigenciaIni2',fld:'vPARAMETRODTVIGENCIAINI2',pic:''},{av:'AV21ParametroDtVigenciaIni_To2',fld:'vPARAMETRODTVIGENCIAINI_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25ParametroDtVigenciaIni3',fld:'vPARAMETRODTVIGENCIAINI3',pic:''},{av:'AV26ParametroDtVigenciaIni_To3',fld:'vPARAMETRODTVIGENCIAINI_TO3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31ddo_ParametroIDTitleControlIdToReplace',fld:'vDDO_PARAMETROIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAINITITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAFIMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_ParametroTipoTitleControlIdToReplace',fld:'vDDO_PARAMETROTIPOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_ParametroPrioritariaTitleControlIdToReplace',fld:'vDDO_PARAMETROPRIORITARIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_ParametroValorTitleControlIdToReplace',fld:'vDDO_PARAMETROVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_ParametroPercentualTitleControlIdToReplace',fld:'vDDO_PARAMETROPERCENTUALTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_PARAMETROID.ONOPTIONCLICKED","{handler:'E130W2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ParametroDtVigenciaIni1',fld:'vPARAMETRODTVIGENCIAINI1',pic:''},{av:'AV16ParametroDtVigenciaIni_To1',fld:'vPARAMETRODTVIGENCIAINI_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20ParametroDtVigenciaIni2',fld:'vPARAMETRODTVIGENCIAINI2',pic:''},{av:'AV21ParametroDtVigenciaIni_To2',fld:'vPARAMETRODTVIGENCIAINI_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25ParametroDtVigenciaIni3',fld:'vPARAMETRODTVIGENCIAINI3',pic:''},{av:'AV26ParametroDtVigenciaIni_To3',fld:'vPARAMETRODTVIGENCIAINI_TO3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31ddo_ParametroIDTitleControlIdToReplace',fld:'vDDO_PARAMETROIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAINITITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAFIMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_ParametroTipoTitleControlIdToReplace',fld:'vDDO_PARAMETROTIPOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_ParametroPrioritariaTitleControlIdToReplace',fld:'vDDO_PARAMETROPRIORITARIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_ParametroValorTitleControlIdToReplace',fld:'vDDO_PARAMETROVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_ParametroPercentualTitleControlIdToReplace',fld:'vDDO_PARAMETROPERCENTUALTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_parametroid_Activeeventkey',ctrl:'DDO_PARAMETROID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_PARAMETROID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_parametroid_Sortedstatus',ctrl:'DDO_PARAMETROID',prop:'SortedStatus'},{av:'Ddo_parametrodtvigenciaini_Sortedstatus',ctrl:'DDO_PARAMETRODTVIGENCIAINI',prop:'SortedStatus'},{av:'Ddo_parametrodtvigenciafim_Sortedstatus',ctrl:'DDO_PARAMETRODTVIGENCIAFIM',prop:'SortedStatus'},{av:'Ddo_parametrotipo_Sortedstatus',ctrl:'DDO_PARAMETROTIPO',prop:'SortedStatus'},{av:'Ddo_parametroprioritaria_Sortedstatus',ctrl:'DDO_PARAMETROPRIORITARIA',prop:'SortedStatus'},{av:'Ddo_parametrovalor_Sortedstatus',ctrl:'DDO_PARAMETROVALOR',prop:'SortedStatus'},{av:'Ddo_parametropercentual_Sortedstatus',ctrl:'DDO_PARAMETROPERCENTUAL',prop:'SortedStatus'},{av:'AV30ParametroIDTitleFilterData',fld:'vPARAMETROIDTITLEFILTERDATA',pic:''},{av:'AV32ParametroDtVigenciaIniTitleFilterData',fld:'vPARAMETRODTVIGENCIAINITITLEFILTERDATA',pic:''},{av:'AV34ParametroDtVigenciaFimTitleFilterData',fld:'vPARAMETRODTVIGENCIAFIMTITLEFILTERDATA',pic:''},{av:'AV36ParametroTipoTitleFilterData',fld:'vPARAMETROTIPOTITLEFILTERDATA',pic:''},{av:'AV38ParametroPrioritariaTitleFilterData',fld:'vPARAMETROPRIORITARIATITLEFILTERDATA',pic:''},{av:'AV40ParametroValorTitleFilterData',fld:'vPARAMETROVALORTITLEFILTERDATA',pic:''},{av:'AV42ParametroPercentualTitleFilterData',fld:'vPARAMETROPERCENTUALTITLEFILTERDATA',pic:''},{av:'edtParametroID_Titleformat',ctrl:'PARAMETROID',prop:'Titleformat'},{av:'edtParametroID_Title',ctrl:'PARAMETROID',prop:'Title'},{av:'edtParametroDtVigenciaIni_Titleformat',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Titleformat'},{av:'edtParametroDtVigenciaIni_Title',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Title'},{av:'edtParametroDtVigenciaFim_Titleformat',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Titleformat'},{av:'edtParametroDtVigenciaFim_Title',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Title'},{av:'cmbParametroTipo'},{av:'cmbParametroPrioritaria'},{av:'edtParametroValor_Titleformat',ctrl:'PARAMETROVALOR',prop:'Titleformat'},{av:'edtParametroValor_Title',ctrl:'PARAMETROVALOR',prop:'Title'},{av:'edtParametroPercentual_Titleformat',ctrl:'PARAMETROPERCENTUAL',prop:'Titleformat'},{av:'edtParametroPercentual_Title',ctrl:'PARAMETROPERCENTUAL',prop:'Title'},{av:'AV46GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV47GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_PARAMETRODTVIGENCIAINI.ONOPTIONCLICKED","{handler:'E140W2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ParametroDtVigenciaIni1',fld:'vPARAMETRODTVIGENCIAINI1',pic:''},{av:'AV16ParametroDtVigenciaIni_To1',fld:'vPARAMETRODTVIGENCIAINI_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20ParametroDtVigenciaIni2',fld:'vPARAMETRODTVIGENCIAINI2',pic:''},{av:'AV21ParametroDtVigenciaIni_To2',fld:'vPARAMETRODTVIGENCIAINI_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25ParametroDtVigenciaIni3',fld:'vPARAMETRODTVIGENCIAINI3',pic:''},{av:'AV26ParametroDtVigenciaIni_To3',fld:'vPARAMETRODTVIGENCIAINI_TO3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31ddo_ParametroIDTitleControlIdToReplace',fld:'vDDO_PARAMETROIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAINITITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAFIMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_ParametroTipoTitleControlIdToReplace',fld:'vDDO_PARAMETROTIPOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_ParametroPrioritariaTitleControlIdToReplace',fld:'vDDO_PARAMETROPRIORITARIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_ParametroValorTitleControlIdToReplace',fld:'vDDO_PARAMETROVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_ParametroPercentualTitleControlIdToReplace',fld:'vDDO_PARAMETROPERCENTUALTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_parametrodtvigenciaini_Activeeventkey',ctrl:'DDO_PARAMETRODTVIGENCIAINI',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_PARAMETRODTVIGENCIAINI.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_parametrodtvigenciaini_Sortedstatus',ctrl:'DDO_PARAMETRODTVIGENCIAINI',prop:'SortedStatus'},{av:'Ddo_parametroid_Sortedstatus',ctrl:'DDO_PARAMETROID',prop:'SortedStatus'},{av:'Ddo_parametrodtvigenciafim_Sortedstatus',ctrl:'DDO_PARAMETRODTVIGENCIAFIM',prop:'SortedStatus'},{av:'Ddo_parametrotipo_Sortedstatus',ctrl:'DDO_PARAMETROTIPO',prop:'SortedStatus'},{av:'Ddo_parametroprioritaria_Sortedstatus',ctrl:'DDO_PARAMETROPRIORITARIA',prop:'SortedStatus'},{av:'Ddo_parametrovalor_Sortedstatus',ctrl:'DDO_PARAMETROVALOR',prop:'SortedStatus'},{av:'Ddo_parametropercentual_Sortedstatus',ctrl:'DDO_PARAMETROPERCENTUAL',prop:'SortedStatus'},{av:'AV30ParametroIDTitleFilterData',fld:'vPARAMETROIDTITLEFILTERDATA',pic:''},{av:'AV32ParametroDtVigenciaIniTitleFilterData',fld:'vPARAMETRODTVIGENCIAINITITLEFILTERDATA',pic:''},{av:'AV34ParametroDtVigenciaFimTitleFilterData',fld:'vPARAMETRODTVIGENCIAFIMTITLEFILTERDATA',pic:''},{av:'AV36ParametroTipoTitleFilterData',fld:'vPARAMETROTIPOTITLEFILTERDATA',pic:''},{av:'AV38ParametroPrioritariaTitleFilterData',fld:'vPARAMETROPRIORITARIATITLEFILTERDATA',pic:''},{av:'AV40ParametroValorTitleFilterData',fld:'vPARAMETROVALORTITLEFILTERDATA',pic:''},{av:'AV42ParametroPercentualTitleFilterData',fld:'vPARAMETROPERCENTUALTITLEFILTERDATA',pic:''},{av:'edtParametroID_Titleformat',ctrl:'PARAMETROID',prop:'Titleformat'},{av:'edtParametroID_Title',ctrl:'PARAMETROID',prop:'Title'},{av:'edtParametroDtVigenciaIni_Titleformat',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Titleformat'},{av:'edtParametroDtVigenciaIni_Title',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Title'},{av:'edtParametroDtVigenciaFim_Titleformat',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Titleformat'},{av:'edtParametroDtVigenciaFim_Title',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Title'},{av:'cmbParametroTipo'},{av:'cmbParametroPrioritaria'},{av:'edtParametroValor_Titleformat',ctrl:'PARAMETROVALOR',prop:'Titleformat'},{av:'edtParametroValor_Title',ctrl:'PARAMETROVALOR',prop:'Title'},{av:'edtParametroPercentual_Titleformat',ctrl:'PARAMETROPERCENTUAL',prop:'Titleformat'},{av:'edtParametroPercentual_Title',ctrl:'PARAMETROPERCENTUAL',prop:'Title'},{av:'AV46GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV47GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_PARAMETRODTVIGENCIAFIM.ONOPTIONCLICKED","{handler:'E150W2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ParametroDtVigenciaIni1',fld:'vPARAMETRODTVIGENCIAINI1',pic:''},{av:'AV16ParametroDtVigenciaIni_To1',fld:'vPARAMETRODTVIGENCIAINI_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20ParametroDtVigenciaIni2',fld:'vPARAMETRODTVIGENCIAINI2',pic:''},{av:'AV21ParametroDtVigenciaIni_To2',fld:'vPARAMETRODTVIGENCIAINI_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25ParametroDtVigenciaIni3',fld:'vPARAMETRODTVIGENCIAINI3',pic:''},{av:'AV26ParametroDtVigenciaIni_To3',fld:'vPARAMETRODTVIGENCIAINI_TO3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31ddo_ParametroIDTitleControlIdToReplace',fld:'vDDO_PARAMETROIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAINITITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAFIMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_ParametroTipoTitleControlIdToReplace',fld:'vDDO_PARAMETROTIPOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_ParametroPrioritariaTitleControlIdToReplace',fld:'vDDO_PARAMETROPRIORITARIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_ParametroValorTitleControlIdToReplace',fld:'vDDO_PARAMETROVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_ParametroPercentualTitleControlIdToReplace',fld:'vDDO_PARAMETROPERCENTUALTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_parametrodtvigenciafim_Activeeventkey',ctrl:'DDO_PARAMETRODTVIGENCIAFIM',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_PARAMETRODTVIGENCIAFIM.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_parametrodtvigenciafim_Sortedstatus',ctrl:'DDO_PARAMETRODTVIGENCIAFIM',prop:'SortedStatus'},{av:'Ddo_parametroid_Sortedstatus',ctrl:'DDO_PARAMETROID',prop:'SortedStatus'},{av:'Ddo_parametrodtvigenciaini_Sortedstatus',ctrl:'DDO_PARAMETRODTVIGENCIAINI',prop:'SortedStatus'},{av:'Ddo_parametrotipo_Sortedstatus',ctrl:'DDO_PARAMETROTIPO',prop:'SortedStatus'},{av:'Ddo_parametroprioritaria_Sortedstatus',ctrl:'DDO_PARAMETROPRIORITARIA',prop:'SortedStatus'},{av:'Ddo_parametrovalor_Sortedstatus',ctrl:'DDO_PARAMETROVALOR',prop:'SortedStatus'},{av:'Ddo_parametropercentual_Sortedstatus',ctrl:'DDO_PARAMETROPERCENTUAL',prop:'SortedStatus'},{av:'AV30ParametroIDTitleFilterData',fld:'vPARAMETROIDTITLEFILTERDATA',pic:''},{av:'AV32ParametroDtVigenciaIniTitleFilterData',fld:'vPARAMETRODTVIGENCIAINITITLEFILTERDATA',pic:''},{av:'AV34ParametroDtVigenciaFimTitleFilterData',fld:'vPARAMETRODTVIGENCIAFIMTITLEFILTERDATA',pic:''},{av:'AV36ParametroTipoTitleFilterData',fld:'vPARAMETROTIPOTITLEFILTERDATA',pic:''},{av:'AV38ParametroPrioritariaTitleFilterData',fld:'vPARAMETROPRIORITARIATITLEFILTERDATA',pic:''},{av:'AV40ParametroValorTitleFilterData',fld:'vPARAMETROVALORTITLEFILTERDATA',pic:''},{av:'AV42ParametroPercentualTitleFilterData',fld:'vPARAMETROPERCENTUALTITLEFILTERDATA',pic:''},{av:'edtParametroID_Titleformat',ctrl:'PARAMETROID',prop:'Titleformat'},{av:'edtParametroID_Title',ctrl:'PARAMETROID',prop:'Title'},{av:'edtParametroDtVigenciaIni_Titleformat',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Titleformat'},{av:'edtParametroDtVigenciaIni_Title',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Title'},{av:'edtParametroDtVigenciaFim_Titleformat',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Titleformat'},{av:'edtParametroDtVigenciaFim_Title',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Title'},{av:'cmbParametroTipo'},{av:'cmbParametroPrioritaria'},{av:'edtParametroValor_Titleformat',ctrl:'PARAMETROVALOR',prop:'Titleformat'},{av:'edtParametroValor_Title',ctrl:'PARAMETROVALOR',prop:'Title'},{av:'edtParametroPercentual_Titleformat',ctrl:'PARAMETROPERCENTUAL',prop:'Titleformat'},{av:'edtParametroPercentual_Title',ctrl:'PARAMETROPERCENTUAL',prop:'Title'},{av:'AV46GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV47GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_PARAMETROTIPO.ONOPTIONCLICKED","{handler:'E160W2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ParametroDtVigenciaIni1',fld:'vPARAMETRODTVIGENCIAINI1',pic:''},{av:'AV16ParametroDtVigenciaIni_To1',fld:'vPARAMETRODTVIGENCIAINI_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20ParametroDtVigenciaIni2',fld:'vPARAMETRODTVIGENCIAINI2',pic:''},{av:'AV21ParametroDtVigenciaIni_To2',fld:'vPARAMETRODTVIGENCIAINI_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25ParametroDtVigenciaIni3',fld:'vPARAMETRODTVIGENCIAINI3',pic:''},{av:'AV26ParametroDtVigenciaIni_To3',fld:'vPARAMETRODTVIGENCIAINI_TO3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31ddo_ParametroIDTitleControlIdToReplace',fld:'vDDO_PARAMETROIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAINITITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAFIMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_ParametroTipoTitleControlIdToReplace',fld:'vDDO_PARAMETROTIPOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_ParametroPrioritariaTitleControlIdToReplace',fld:'vDDO_PARAMETROPRIORITARIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_ParametroValorTitleControlIdToReplace',fld:'vDDO_PARAMETROVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_ParametroPercentualTitleControlIdToReplace',fld:'vDDO_PARAMETROPERCENTUALTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_parametrotipo_Activeeventkey',ctrl:'DDO_PARAMETROTIPO',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_PARAMETROTIPO.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_parametrotipo_Sortedstatus',ctrl:'DDO_PARAMETROTIPO',prop:'SortedStatus'},{av:'Ddo_parametroid_Sortedstatus',ctrl:'DDO_PARAMETROID',prop:'SortedStatus'},{av:'Ddo_parametrodtvigenciaini_Sortedstatus',ctrl:'DDO_PARAMETRODTVIGENCIAINI',prop:'SortedStatus'},{av:'Ddo_parametrodtvigenciafim_Sortedstatus',ctrl:'DDO_PARAMETRODTVIGENCIAFIM',prop:'SortedStatus'},{av:'Ddo_parametroprioritaria_Sortedstatus',ctrl:'DDO_PARAMETROPRIORITARIA',prop:'SortedStatus'},{av:'Ddo_parametrovalor_Sortedstatus',ctrl:'DDO_PARAMETROVALOR',prop:'SortedStatus'},{av:'Ddo_parametropercentual_Sortedstatus',ctrl:'DDO_PARAMETROPERCENTUAL',prop:'SortedStatus'},{av:'AV30ParametroIDTitleFilterData',fld:'vPARAMETROIDTITLEFILTERDATA',pic:''},{av:'AV32ParametroDtVigenciaIniTitleFilterData',fld:'vPARAMETRODTVIGENCIAINITITLEFILTERDATA',pic:''},{av:'AV34ParametroDtVigenciaFimTitleFilterData',fld:'vPARAMETRODTVIGENCIAFIMTITLEFILTERDATA',pic:''},{av:'AV36ParametroTipoTitleFilterData',fld:'vPARAMETROTIPOTITLEFILTERDATA',pic:''},{av:'AV38ParametroPrioritariaTitleFilterData',fld:'vPARAMETROPRIORITARIATITLEFILTERDATA',pic:''},{av:'AV40ParametroValorTitleFilterData',fld:'vPARAMETROVALORTITLEFILTERDATA',pic:''},{av:'AV42ParametroPercentualTitleFilterData',fld:'vPARAMETROPERCENTUALTITLEFILTERDATA',pic:''},{av:'edtParametroID_Titleformat',ctrl:'PARAMETROID',prop:'Titleformat'},{av:'edtParametroID_Title',ctrl:'PARAMETROID',prop:'Title'},{av:'edtParametroDtVigenciaIni_Titleformat',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Titleformat'},{av:'edtParametroDtVigenciaIni_Title',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Title'},{av:'edtParametroDtVigenciaFim_Titleformat',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Titleformat'},{av:'edtParametroDtVigenciaFim_Title',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Title'},{av:'cmbParametroTipo'},{av:'cmbParametroPrioritaria'},{av:'edtParametroValor_Titleformat',ctrl:'PARAMETROVALOR',prop:'Titleformat'},{av:'edtParametroValor_Title',ctrl:'PARAMETROVALOR',prop:'Title'},{av:'edtParametroPercentual_Titleformat',ctrl:'PARAMETROPERCENTUAL',prop:'Titleformat'},{av:'edtParametroPercentual_Title',ctrl:'PARAMETROPERCENTUAL',prop:'Title'},{av:'AV46GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV47GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_PARAMETROPRIORITARIA.ONOPTIONCLICKED","{handler:'E170W2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ParametroDtVigenciaIni1',fld:'vPARAMETRODTVIGENCIAINI1',pic:''},{av:'AV16ParametroDtVigenciaIni_To1',fld:'vPARAMETRODTVIGENCIAINI_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20ParametroDtVigenciaIni2',fld:'vPARAMETRODTVIGENCIAINI2',pic:''},{av:'AV21ParametroDtVigenciaIni_To2',fld:'vPARAMETRODTVIGENCIAINI_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25ParametroDtVigenciaIni3',fld:'vPARAMETRODTVIGENCIAINI3',pic:''},{av:'AV26ParametroDtVigenciaIni_To3',fld:'vPARAMETRODTVIGENCIAINI_TO3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31ddo_ParametroIDTitleControlIdToReplace',fld:'vDDO_PARAMETROIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAINITITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAFIMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_ParametroTipoTitleControlIdToReplace',fld:'vDDO_PARAMETROTIPOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_ParametroPrioritariaTitleControlIdToReplace',fld:'vDDO_PARAMETROPRIORITARIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_ParametroValorTitleControlIdToReplace',fld:'vDDO_PARAMETROVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_ParametroPercentualTitleControlIdToReplace',fld:'vDDO_PARAMETROPERCENTUALTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_parametroprioritaria_Activeeventkey',ctrl:'DDO_PARAMETROPRIORITARIA',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_PARAMETROPRIORITARIA.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_parametroprioritaria_Sortedstatus',ctrl:'DDO_PARAMETROPRIORITARIA',prop:'SortedStatus'},{av:'Ddo_parametroid_Sortedstatus',ctrl:'DDO_PARAMETROID',prop:'SortedStatus'},{av:'Ddo_parametrodtvigenciaini_Sortedstatus',ctrl:'DDO_PARAMETRODTVIGENCIAINI',prop:'SortedStatus'},{av:'Ddo_parametrodtvigenciafim_Sortedstatus',ctrl:'DDO_PARAMETRODTVIGENCIAFIM',prop:'SortedStatus'},{av:'Ddo_parametrotipo_Sortedstatus',ctrl:'DDO_PARAMETROTIPO',prop:'SortedStatus'},{av:'Ddo_parametrovalor_Sortedstatus',ctrl:'DDO_PARAMETROVALOR',prop:'SortedStatus'},{av:'Ddo_parametropercentual_Sortedstatus',ctrl:'DDO_PARAMETROPERCENTUAL',prop:'SortedStatus'},{av:'AV30ParametroIDTitleFilterData',fld:'vPARAMETROIDTITLEFILTERDATA',pic:''},{av:'AV32ParametroDtVigenciaIniTitleFilterData',fld:'vPARAMETRODTVIGENCIAINITITLEFILTERDATA',pic:''},{av:'AV34ParametroDtVigenciaFimTitleFilterData',fld:'vPARAMETRODTVIGENCIAFIMTITLEFILTERDATA',pic:''},{av:'AV36ParametroTipoTitleFilterData',fld:'vPARAMETROTIPOTITLEFILTERDATA',pic:''},{av:'AV38ParametroPrioritariaTitleFilterData',fld:'vPARAMETROPRIORITARIATITLEFILTERDATA',pic:''},{av:'AV40ParametroValorTitleFilterData',fld:'vPARAMETROVALORTITLEFILTERDATA',pic:''},{av:'AV42ParametroPercentualTitleFilterData',fld:'vPARAMETROPERCENTUALTITLEFILTERDATA',pic:''},{av:'edtParametroID_Titleformat',ctrl:'PARAMETROID',prop:'Titleformat'},{av:'edtParametroID_Title',ctrl:'PARAMETROID',prop:'Title'},{av:'edtParametroDtVigenciaIni_Titleformat',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Titleformat'},{av:'edtParametroDtVigenciaIni_Title',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Title'},{av:'edtParametroDtVigenciaFim_Titleformat',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Titleformat'},{av:'edtParametroDtVigenciaFim_Title',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Title'},{av:'cmbParametroTipo'},{av:'cmbParametroPrioritaria'},{av:'edtParametroValor_Titleformat',ctrl:'PARAMETROVALOR',prop:'Titleformat'},{av:'edtParametroValor_Title',ctrl:'PARAMETROVALOR',prop:'Title'},{av:'edtParametroPercentual_Titleformat',ctrl:'PARAMETROPERCENTUAL',prop:'Titleformat'},{av:'edtParametroPercentual_Title',ctrl:'PARAMETROPERCENTUAL',prop:'Title'},{av:'AV46GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV47GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_PARAMETROVALOR.ONOPTIONCLICKED","{handler:'E180W2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ParametroDtVigenciaIni1',fld:'vPARAMETRODTVIGENCIAINI1',pic:''},{av:'AV16ParametroDtVigenciaIni_To1',fld:'vPARAMETRODTVIGENCIAINI_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20ParametroDtVigenciaIni2',fld:'vPARAMETRODTVIGENCIAINI2',pic:''},{av:'AV21ParametroDtVigenciaIni_To2',fld:'vPARAMETRODTVIGENCIAINI_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25ParametroDtVigenciaIni3',fld:'vPARAMETRODTVIGENCIAINI3',pic:''},{av:'AV26ParametroDtVigenciaIni_To3',fld:'vPARAMETRODTVIGENCIAINI_TO3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31ddo_ParametroIDTitleControlIdToReplace',fld:'vDDO_PARAMETROIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAINITITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAFIMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_ParametroTipoTitleControlIdToReplace',fld:'vDDO_PARAMETROTIPOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_ParametroPrioritariaTitleControlIdToReplace',fld:'vDDO_PARAMETROPRIORITARIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_ParametroValorTitleControlIdToReplace',fld:'vDDO_PARAMETROVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_ParametroPercentualTitleControlIdToReplace',fld:'vDDO_PARAMETROPERCENTUALTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_parametrovalor_Activeeventkey',ctrl:'DDO_PARAMETROVALOR',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_PARAMETROVALOR.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_parametrovalor_Sortedstatus',ctrl:'DDO_PARAMETROVALOR',prop:'SortedStatus'},{av:'Ddo_parametroid_Sortedstatus',ctrl:'DDO_PARAMETROID',prop:'SortedStatus'},{av:'Ddo_parametrodtvigenciaini_Sortedstatus',ctrl:'DDO_PARAMETRODTVIGENCIAINI',prop:'SortedStatus'},{av:'Ddo_parametrodtvigenciafim_Sortedstatus',ctrl:'DDO_PARAMETRODTVIGENCIAFIM',prop:'SortedStatus'},{av:'Ddo_parametrotipo_Sortedstatus',ctrl:'DDO_PARAMETROTIPO',prop:'SortedStatus'},{av:'Ddo_parametroprioritaria_Sortedstatus',ctrl:'DDO_PARAMETROPRIORITARIA',prop:'SortedStatus'},{av:'Ddo_parametropercentual_Sortedstatus',ctrl:'DDO_PARAMETROPERCENTUAL',prop:'SortedStatus'},{av:'AV30ParametroIDTitleFilterData',fld:'vPARAMETROIDTITLEFILTERDATA',pic:''},{av:'AV32ParametroDtVigenciaIniTitleFilterData',fld:'vPARAMETRODTVIGENCIAINITITLEFILTERDATA',pic:''},{av:'AV34ParametroDtVigenciaFimTitleFilterData',fld:'vPARAMETRODTVIGENCIAFIMTITLEFILTERDATA',pic:''},{av:'AV36ParametroTipoTitleFilterData',fld:'vPARAMETROTIPOTITLEFILTERDATA',pic:''},{av:'AV38ParametroPrioritariaTitleFilterData',fld:'vPARAMETROPRIORITARIATITLEFILTERDATA',pic:''},{av:'AV40ParametroValorTitleFilterData',fld:'vPARAMETROVALORTITLEFILTERDATA',pic:''},{av:'AV42ParametroPercentualTitleFilterData',fld:'vPARAMETROPERCENTUALTITLEFILTERDATA',pic:''},{av:'edtParametroID_Titleformat',ctrl:'PARAMETROID',prop:'Titleformat'},{av:'edtParametroID_Title',ctrl:'PARAMETROID',prop:'Title'},{av:'edtParametroDtVigenciaIni_Titleformat',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Titleformat'},{av:'edtParametroDtVigenciaIni_Title',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Title'},{av:'edtParametroDtVigenciaFim_Titleformat',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Titleformat'},{av:'edtParametroDtVigenciaFim_Title',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Title'},{av:'cmbParametroTipo'},{av:'cmbParametroPrioritaria'},{av:'edtParametroValor_Titleformat',ctrl:'PARAMETROVALOR',prop:'Titleformat'},{av:'edtParametroValor_Title',ctrl:'PARAMETROVALOR',prop:'Title'},{av:'edtParametroPercentual_Titleformat',ctrl:'PARAMETROPERCENTUAL',prop:'Titleformat'},{av:'edtParametroPercentual_Title',ctrl:'PARAMETROPERCENTUAL',prop:'Title'},{av:'AV46GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV47GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_PARAMETROPERCENTUAL.ONOPTIONCLICKED","{handler:'E190W2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ParametroDtVigenciaIni1',fld:'vPARAMETRODTVIGENCIAINI1',pic:''},{av:'AV16ParametroDtVigenciaIni_To1',fld:'vPARAMETRODTVIGENCIAINI_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20ParametroDtVigenciaIni2',fld:'vPARAMETRODTVIGENCIAINI2',pic:''},{av:'AV21ParametroDtVigenciaIni_To2',fld:'vPARAMETRODTVIGENCIAINI_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25ParametroDtVigenciaIni3',fld:'vPARAMETRODTVIGENCIAINI3',pic:''},{av:'AV26ParametroDtVigenciaIni_To3',fld:'vPARAMETRODTVIGENCIAINI_TO3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31ddo_ParametroIDTitleControlIdToReplace',fld:'vDDO_PARAMETROIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAINITITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAFIMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_ParametroTipoTitleControlIdToReplace',fld:'vDDO_PARAMETROTIPOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_ParametroPrioritariaTitleControlIdToReplace',fld:'vDDO_PARAMETROPRIORITARIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_ParametroValorTitleControlIdToReplace',fld:'vDDO_PARAMETROVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_ParametroPercentualTitleControlIdToReplace',fld:'vDDO_PARAMETROPERCENTUALTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_parametropercentual_Activeeventkey',ctrl:'DDO_PARAMETROPERCENTUAL',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_PARAMETROPERCENTUAL.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_parametropercentual_Sortedstatus',ctrl:'DDO_PARAMETROPERCENTUAL',prop:'SortedStatus'},{av:'Ddo_parametroid_Sortedstatus',ctrl:'DDO_PARAMETROID',prop:'SortedStatus'},{av:'Ddo_parametrodtvigenciaini_Sortedstatus',ctrl:'DDO_PARAMETRODTVIGENCIAINI',prop:'SortedStatus'},{av:'Ddo_parametrodtvigenciafim_Sortedstatus',ctrl:'DDO_PARAMETRODTVIGENCIAFIM',prop:'SortedStatus'},{av:'Ddo_parametrotipo_Sortedstatus',ctrl:'DDO_PARAMETROTIPO',prop:'SortedStatus'},{av:'Ddo_parametroprioritaria_Sortedstatus',ctrl:'DDO_PARAMETROPRIORITARIA',prop:'SortedStatus'},{av:'Ddo_parametrovalor_Sortedstatus',ctrl:'DDO_PARAMETROVALOR',prop:'SortedStatus'},{av:'AV30ParametroIDTitleFilterData',fld:'vPARAMETROIDTITLEFILTERDATA',pic:''},{av:'AV32ParametroDtVigenciaIniTitleFilterData',fld:'vPARAMETRODTVIGENCIAINITITLEFILTERDATA',pic:''},{av:'AV34ParametroDtVigenciaFimTitleFilterData',fld:'vPARAMETRODTVIGENCIAFIMTITLEFILTERDATA',pic:''},{av:'AV36ParametroTipoTitleFilterData',fld:'vPARAMETROTIPOTITLEFILTERDATA',pic:''},{av:'AV38ParametroPrioritariaTitleFilterData',fld:'vPARAMETROPRIORITARIATITLEFILTERDATA',pic:''},{av:'AV40ParametroValorTitleFilterData',fld:'vPARAMETROVALORTITLEFILTERDATA',pic:''},{av:'AV42ParametroPercentualTitleFilterData',fld:'vPARAMETROPERCENTUALTITLEFILTERDATA',pic:''},{av:'edtParametroID_Titleformat',ctrl:'PARAMETROID',prop:'Titleformat'},{av:'edtParametroID_Title',ctrl:'PARAMETROID',prop:'Title'},{av:'edtParametroDtVigenciaIni_Titleformat',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Titleformat'},{av:'edtParametroDtVigenciaIni_Title',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Title'},{av:'edtParametroDtVigenciaFim_Titleformat',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Titleformat'},{av:'edtParametroDtVigenciaFim_Title',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Title'},{av:'cmbParametroTipo'},{av:'cmbParametroPrioritaria'},{av:'edtParametroValor_Titleformat',ctrl:'PARAMETROVALOR',prop:'Titleformat'},{av:'edtParametroValor_Title',ctrl:'PARAMETROVALOR',prop:'Title'},{av:'edtParametroPercentual_Titleformat',ctrl:'PARAMETROPERCENTUAL',prop:'Titleformat'},{av:'edtParametroPercentual_Title',ctrl:'PARAMETROPERCENTUAL',prop:'Title'},{av:'AV46GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV47GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E340W2',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV48Select',fld:'vSELECT',pic:''},{av:'edtavSelect_Tooltiptext',ctrl:'vSELECT',prop:'Tooltiptext'}]}");
         setEventMetadata("ENTER","{handler:'E350W2',iparms:[{av:'A13ParametroID',fld:'PARAMETROID',pic:'ZZZ9',hsh:true},{av:'A14ParametroDtVigenciaIni',fld:'PARAMETRODTVIGENCIAINI',pic:'',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV49InOutParametroID',fld:'vINOUTPARAMETROID',pic:'ZZZ9'},{av:'AV50InOutParametroDtVigenciaIni',fld:'vINOUTPARAMETRODTVIGENCIAINI',pic:''}]}");
         setEventMetadata("'ADDDYNAMICFILTERS1'","{handler:'E240W2',iparms:[]");
         setEventMetadata("'ADDDYNAMICFILTERS1'",",oparms:[{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'}]}");
         setEventMetadata("'REMOVEDYNAMICFILTERS1'","{handler:'E200W2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ParametroDtVigenciaIni1',fld:'vPARAMETRODTVIGENCIAINI1',pic:''},{av:'AV16ParametroDtVigenciaIni_To1',fld:'vPARAMETRODTVIGENCIAINI_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20ParametroDtVigenciaIni2',fld:'vPARAMETRODTVIGENCIAINI2',pic:''},{av:'AV21ParametroDtVigenciaIni_To2',fld:'vPARAMETRODTVIGENCIAINI_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25ParametroDtVigenciaIni3',fld:'vPARAMETRODTVIGENCIAINI3',pic:''},{av:'AV26ParametroDtVigenciaIni_To3',fld:'vPARAMETRODTVIGENCIAINI_TO3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31ddo_ParametroIDTitleControlIdToReplace',fld:'vDDO_PARAMETROIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAINITITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAFIMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_ParametroTipoTitleControlIdToReplace',fld:'vDDO_PARAMETROTIPOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_ParametroPrioritariaTitleControlIdToReplace',fld:'vDDO_PARAMETROPRIORITARIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_ParametroValorTitleControlIdToReplace',fld:'vDDO_PARAMETROVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_ParametroPercentualTitleControlIdToReplace',fld:'vDDO_PARAMETROPERCENTUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV8GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Gx_date',fld:'vTODAY',pic:''}]");
         setEventMetadata("'REMOVEDYNAMICFILTERS1'",",oparms:[{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV8GridState',fld:'vGRIDSTATE',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20ParametroDtVigenciaIni2',fld:'vPARAMETRODTVIGENCIAINI2',pic:''},{av:'AV21ParametroDtVigenciaIni_To2',fld:'vPARAMETRODTVIGENCIAINI_TO2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25ParametroDtVigenciaIni3',fld:'vPARAMETRODTVIGENCIAINI3',pic:''},{av:'AV26ParametroDtVigenciaIni_To3',fld:'vPARAMETRODTVIGENCIAINI_TO3',pic:''},{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ParametroDtVigenciaIni1',fld:'vPARAMETRODTVIGENCIAINI1',pic:''},{av:'AV16ParametroDtVigenciaIni_To1',fld:'vPARAMETRODTVIGENCIAINI_TO1',pic:''},{av:'lblJsdynamicfilters_Caption',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{av:'tblTablemergeddynamicfiltersparametrodtvigenciaini2_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPARAMETRODTVIGENCIAINI2',prop:'Visible'},{av:'tblTablemergeddynamicfiltersparametrodtvigenciaini3_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPARAMETRODTVIGENCIAINI3',prop:'Visible'},{av:'tblTablemergeddynamicfiltersparametrodtvigenciaini1_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPARAMETRODTVIGENCIAINI1',prop:'Visible'},{av:'cellParametrodtvigenciaini_cell2_Class',ctrl:'PARAMETRODTVIGENCIAINI_CELL2',prop:'Class'},{av:'cellParametrodtvigenciaini_to_cell2_Class',ctrl:'PARAMETRODTVIGENCIAINI_TO_CELL2',prop:'Class'},{av:'lblParametrodtvigenciaini_rangemiddletext_12_Class',ctrl:'PARAMETRODTVIGENCIAINI_RANGEMIDDLETEXT_12',prop:'Class'},{av:'cellParametrodtvigenciaini_cell3_Class',ctrl:'PARAMETRODTVIGENCIAINI_CELL3',prop:'Class'},{av:'cellParametrodtvigenciaini_to_cell3_Class',ctrl:'PARAMETRODTVIGENCIAINI_TO_CELL3',prop:'Class'},{av:'lblParametrodtvigenciaini_rangemiddletext_13_Class',ctrl:'PARAMETRODTVIGENCIAINI_RANGEMIDDLETEXT_13',prop:'Class'},{av:'cellParametrodtvigenciaini_cell1_Class',ctrl:'PARAMETRODTVIGENCIAINI_CELL1',prop:'Class'},{av:'cellParametrodtvigenciaini_to_cell1_Class',ctrl:'PARAMETRODTVIGENCIAINI_TO_CELL1',prop:'Class'},{av:'lblParametrodtvigenciaini_rangemiddletext_11_Class',ctrl:'PARAMETRODTVIGENCIAINI_RANGEMIDDLETEXT_11',prop:'Class'},{av:'AV30ParametroIDTitleFilterData',fld:'vPARAMETROIDTITLEFILTERDATA',pic:''},{av:'AV32ParametroDtVigenciaIniTitleFilterData',fld:'vPARAMETRODTVIGENCIAINITITLEFILTERDATA',pic:''},{av:'AV34ParametroDtVigenciaFimTitleFilterData',fld:'vPARAMETRODTVIGENCIAFIMTITLEFILTERDATA',pic:''},{av:'AV36ParametroTipoTitleFilterData',fld:'vPARAMETROTIPOTITLEFILTERDATA',pic:''},{av:'AV38ParametroPrioritariaTitleFilterData',fld:'vPARAMETROPRIORITARIATITLEFILTERDATA',pic:''},{av:'AV40ParametroValorTitleFilterData',fld:'vPARAMETROVALORTITLEFILTERDATA',pic:''},{av:'AV42ParametroPercentualTitleFilterData',fld:'vPARAMETROPERCENTUALTITLEFILTERDATA',pic:''},{av:'edtParametroID_Titleformat',ctrl:'PARAMETROID',prop:'Titleformat'},{av:'edtParametroID_Title',ctrl:'PARAMETROID',prop:'Title'},{av:'edtParametroDtVigenciaIni_Titleformat',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Titleformat'},{av:'edtParametroDtVigenciaIni_Title',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Title'},{av:'edtParametroDtVigenciaFim_Titleformat',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Titleformat'},{av:'edtParametroDtVigenciaFim_Title',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Title'},{av:'cmbParametroTipo'},{av:'cmbParametroPrioritaria'},{av:'edtParametroValor_Titleformat',ctrl:'PARAMETROVALOR',prop:'Titleformat'},{av:'edtParametroValor_Title',ctrl:'PARAMETROVALOR',prop:'Title'},{av:'edtParametroPercentual_Titleformat',ctrl:'PARAMETROPERCENTUAL',prop:'Titleformat'},{av:'edtParametroPercentual_Title',ctrl:'PARAMETROPERCENTUAL',prop:'Title'},{av:'AV46GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV47GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("VDYNAMICFILTERSSELECTOR1.CLICK","{handler:'E250W2',iparms:[{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'Gx_date',fld:'vTODAY',pic:''}]");
         setEventMetadata("VDYNAMICFILTERSSELECTOR1.CLICK",",oparms:[{av:'tblTablemergeddynamicfiltersparametrodtvigenciaini1_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPARAMETRODTVIGENCIAINI1',prop:'Visible'},{av:'cmbavDynamicfiltersoperator1'},{av:'cellParametrodtvigenciaini_cell1_Class',ctrl:'PARAMETRODTVIGENCIAINI_CELL1',prop:'Class'},{av:'cellParametrodtvigenciaini_to_cell1_Class',ctrl:'PARAMETRODTVIGENCIAINI_TO_CELL1',prop:'Class'},{av:'lblParametrodtvigenciaini_rangemiddletext_11_Class',ctrl:'PARAMETRODTVIGENCIAINI_RANGEMIDDLETEXT_11',prop:'Class'},{av:'AV15ParametroDtVigenciaIni1',fld:'vPARAMETRODTVIGENCIAINI1',pic:''}]}");
         setEventMetadata("VDYNAMICFILTERSOPERATOR1.CLICK","{handler:'E260W2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ParametroDtVigenciaIni1',fld:'vPARAMETRODTVIGENCIAINI1',pic:''},{av:'AV16ParametroDtVigenciaIni_To1',fld:'vPARAMETRODTVIGENCIAINI_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20ParametroDtVigenciaIni2',fld:'vPARAMETRODTVIGENCIAINI2',pic:''},{av:'AV21ParametroDtVigenciaIni_To2',fld:'vPARAMETRODTVIGENCIAINI_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25ParametroDtVigenciaIni3',fld:'vPARAMETRODTVIGENCIAINI3',pic:''},{av:'AV26ParametroDtVigenciaIni_To3',fld:'vPARAMETRODTVIGENCIAINI_TO3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31ddo_ParametroIDTitleControlIdToReplace',fld:'vDDO_PARAMETROIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAINITITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAFIMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_ParametroTipoTitleControlIdToReplace',fld:'vDDO_PARAMETROTIPOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_ParametroPrioritariaTitleControlIdToReplace',fld:'vDDO_PARAMETROPRIORITARIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_ParametroValorTitleControlIdToReplace',fld:'vDDO_PARAMETROVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_ParametroPercentualTitleControlIdToReplace',fld:'vDDO_PARAMETROPERCENTUALTITLECONTROLIDTOREPLACE',pic:''},{av:'Gx_date',fld:'vTODAY',pic:''}]");
         setEventMetadata("VDYNAMICFILTERSOPERATOR1.CLICK",",oparms:[{av:'AV15ParametroDtVigenciaIni1',fld:'vPARAMETRODTVIGENCIAINI1',pic:''},{av:'AV16ParametroDtVigenciaIni_To1',fld:'vPARAMETRODTVIGENCIAINI_TO1',pic:''},{av:'cellParametrodtvigenciaini_cell1_Class',ctrl:'PARAMETRODTVIGENCIAINI_CELL1',prop:'Class'},{av:'cellParametrodtvigenciaini_to_cell1_Class',ctrl:'PARAMETRODTVIGENCIAINI_TO_CELL1',prop:'Class'},{av:'lblParametrodtvigenciaini_rangemiddletext_11_Class',ctrl:'PARAMETRODTVIGENCIAINI_RANGEMIDDLETEXT_11',prop:'Class'},{av:'AV30ParametroIDTitleFilterData',fld:'vPARAMETROIDTITLEFILTERDATA',pic:''},{av:'AV32ParametroDtVigenciaIniTitleFilterData',fld:'vPARAMETRODTVIGENCIAINITITLEFILTERDATA',pic:''},{av:'AV34ParametroDtVigenciaFimTitleFilterData',fld:'vPARAMETRODTVIGENCIAFIMTITLEFILTERDATA',pic:''},{av:'AV36ParametroTipoTitleFilterData',fld:'vPARAMETROTIPOTITLEFILTERDATA',pic:''},{av:'AV38ParametroPrioritariaTitleFilterData',fld:'vPARAMETROPRIORITARIATITLEFILTERDATA',pic:''},{av:'AV40ParametroValorTitleFilterData',fld:'vPARAMETROVALORTITLEFILTERDATA',pic:''},{av:'AV42ParametroPercentualTitleFilterData',fld:'vPARAMETROPERCENTUALTITLEFILTERDATA',pic:''},{av:'edtParametroID_Titleformat',ctrl:'PARAMETROID',prop:'Titleformat'},{av:'edtParametroID_Title',ctrl:'PARAMETROID',prop:'Title'},{av:'edtParametroDtVigenciaIni_Titleformat',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Titleformat'},{av:'edtParametroDtVigenciaIni_Title',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Title'},{av:'edtParametroDtVigenciaFim_Titleformat',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Titleformat'},{av:'edtParametroDtVigenciaFim_Title',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Title'},{av:'cmbParametroTipo'},{av:'cmbParametroPrioritaria'},{av:'edtParametroValor_Titleformat',ctrl:'PARAMETROVALOR',prop:'Titleformat'},{av:'edtParametroValor_Title',ctrl:'PARAMETROVALOR',prop:'Title'},{av:'edtParametroPercentual_Titleformat',ctrl:'PARAMETROPERCENTUAL',prop:'Titleformat'},{av:'edtParametroPercentual_Title',ctrl:'PARAMETROPERCENTUAL',prop:'Title'},{av:'AV46GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV47GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("'ADDDYNAMICFILTERS2'","{handler:'E270W2',iparms:[]");
         setEventMetadata("'ADDDYNAMICFILTERS2'",",oparms:[{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'}]}");
         setEventMetadata("'REMOVEDYNAMICFILTERS2'","{handler:'E210W2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ParametroDtVigenciaIni1',fld:'vPARAMETRODTVIGENCIAINI1',pic:''},{av:'AV16ParametroDtVigenciaIni_To1',fld:'vPARAMETRODTVIGENCIAINI_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20ParametroDtVigenciaIni2',fld:'vPARAMETRODTVIGENCIAINI2',pic:''},{av:'AV21ParametroDtVigenciaIni_To2',fld:'vPARAMETRODTVIGENCIAINI_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25ParametroDtVigenciaIni3',fld:'vPARAMETRODTVIGENCIAINI3',pic:''},{av:'AV26ParametroDtVigenciaIni_To3',fld:'vPARAMETRODTVIGENCIAINI_TO3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31ddo_ParametroIDTitleControlIdToReplace',fld:'vDDO_PARAMETROIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAINITITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAFIMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_ParametroTipoTitleControlIdToReplace',fld:'vDDO_PARAMETROTIPOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_ParametroPrioritariaTitleControlIdToReplace',fld:'vDDO_PARAMETROPRIORITARIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_ParametroValorTitleControlIdToReplace',fld:'vDDO_PARAMETROVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_ParametroPercentualTitleControlIdToReplace',fld:'vDDO_PARAMETROPERCENTUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV8GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Gx_date',fld:'vTODAY',pic:''}]");
         setEventMetadata("'REMOVEDYNAMICFILTERS2'",",oparms:[{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV8GridState',fld:'vGRIDSTATE',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20ParametroDtVigenciaIni2',fld:'vPARAMETRODTVIGENCIAINI2',pic:''},{av:'AV21ParametroDtVigenciaIni_To2',fld:'vPARAMETRODTVIGENCIAINI_TO2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25ParametroDtVigenciaIni3',fld:'vPARAMETRODTVIGENCIAINI3',pic:''},{av:'AV26ParametroDtVigenciaIni_To3',fld:'vPARAMETRODTVIGENCIAINI_TO3',pic:''},{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ParametroDtVigenciaIni1',fld:'vPARAMETRODTVIGENCIAINI1',pic:''},{av:'AV16ParametroDtVigenciaIni_To1',fld:'vPARAMETRODTVIGENCIAINI_TO1',pic:''},{av:'lblJsdynamicfilters_Caption',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{av:'tblTablemergeddynamicfiltersparametrodtvigenciaini2_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPARAMETRODTVIGENCIAINI2',prop:'Visible'},{av:'tblTablemergeddynamicfiltersparametrodtvigenciaini3_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPARAMETRODTVIGENCIAINI3',prop:'Visible'},{av:'tblTablemergeddynamicfiltersparametrodtvigenciaini1_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPARAMETRODTVIGENCIAINI1',prop:'Visible'},{av:'cellParametrodtvigenciaini_cell2_Class',ctrl:'PARAMETRODTVIGENCIAINI_CELL2',prop:'Class'},{av:'cellParametrodtvigenciaini_to_cell2_Class',ctrl:'PARAMETRODTVIGENCIAINI_TO_CELL2',prop:'Class'},{av:'lblParametrodtvigenciaini_rangemiddletext_12_Class',ctrl:'PARAMETRODTVIGENCIAINI_RANGEMIDDLETEXT_12',prop:'Class'},{av:'cellParametrodtvigenciaini_cell3_Class',ctrl:'PARAMETRODTVIGENCIAINI_CELL3',prop:'Class'},{av:'cellParametrodtvigenciaini_to_cell3_Class',ctrl:'PARAMETRODTVIGENCIAINI_TO_CELL3',prop:'Class'},{av:'lblParametrodtvigenciaini_rangemiddletext_13_Class',ctrl:'PARAMETRODTVIGENCIAINI_RANGEMIDDLETEXT_13',prop:'Class'},{av:'cellParametrodtvigenciaini_cell1_Class',ctrl:'PARAMETRODTVIGENCIAINI_CELL1',prop:'Class'},{av:'cellParametrodtvigenciaini_to_cell1_Class',ctrl:'PARAMETRODTVIGENCIAINI_TO_CELL1',prop:'Class'},{av:'lblParametrodtvigenciaini_rangemiddletext_11_Class',ctrl:'PARAMETRODTVIGENCIAINI_RANGEMIDDLETEXT_11',prop:'Class'},{av:'AV30ParametroIDTitleFilterData',fld:'vPARAMETROIDTITLEFILTERDATA',pic:''},{av:'AV32ParametroDtVigenciaIniTitleFilterData',fld:'vPARAMETRODTVIGENCIAINITITLEFILTERDATA',pic:''},{av:'AV34ParametroDtVigenciaFimTitleFilterData',fld:'vPARAMETRODTVIGENCIAFIMTITLEFILTERDATA',pic:''},{av:'AV36ParametroTipoTitleFilterData',fld:'vPARAMETROTIPOTITLEFILTERDATA',pic:''},{av:'AV38ParametroPrioritariaTitleFilterData',fld:'vPARAMETROPRIORITARIATITLEFILTERDATA',pic:''},{av:'AV40ParametroValorTitleFilterData',fld:'vPARAMETROVALORTITLEFILTERDATA',pic:''},{av:'AV42ParametroPercentualTitleFilterData',fld:'vPARAMETROPERCENTUALTITLEFILTERDATA',pic:''},{av:'edtParametroID_Titleformat',ctrl:'PARAMETROID',prop:'Titleformat'},{av:'edtParametroID_Title',ctrl:'PARAMETROID',prop:'Title'},{av:'edtParametroDtVigenciaIni_Titleformat',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Titleformat'},{av:'edtParametroDtVigenciaIni_Title',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Title'},{av:'edtParametroDtVigenciaFim_Titleformat',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Titleformat'},{av:'edtParametroDtVigenciaFim_Title',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Title'},{av:'cmbParametroTipo'},{av:'cmbParametroPrioritaria'},{av:'edtParametroValor_Titleformat',ctrl:'PARAMETROVALOR',prop:'Titleformat'},{av:'edtParametroValor_Title',ctrl:'PARAMETROVALOR',prop:'Title'},{av:'edtParametroPercentual_Titleformat',ctrl:'PARAMETROPERCENTUAL',prop:'Titleformat'},{av:'edtParametroPercentual_Title',ctrl:'PARAMETROPERCENTUAL',prop:'Title'},{av:'AV46GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV47GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("VDYNAMICFILTERSSELECTOR2.CLICK","{handler:'E280W2',iparms:[{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'Gx_date',fld:'vTODAY',pic:''}]");
         setEventMetadata("VDYNAMICFILTERSSELECTOR2.CLICK",",oparms:[{av:'tblTablemergeddynamicfiltersparametrodtvigenciaini2_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPARAMETRODTVIGENCIAINI2',prop:'Visible'},{av:'cmbavDynamicfiltersoperator2'},{av:'cellParametrodtvigenciaini_cell2_Class',ctrl:'PARAMETRODTVIGENCIAINI_CELL2',prop:'Class'},{av:'cellParametrodtvigenciaini_to_cell2_Class',ctrl:'PARAMETRODTVIGENCIAINI_TO_CELL2',prop:'Class'},{av:'lblParametrodtvigenciaini_rangemiddletext_12_Class',ctrl:'PARAMETRODTVIGENCIAINI_RANGEMIDDLETEXT_12',prop:'Class'},{av:'AV20ParametroDtVigenciaIni2',fld:'vPARAMETRODTVIGENCIAINI2',pic:''}]}");
         setEventMetadata("VDYNAMICFILTERSOPERATOR2.CLICK","{handler:'E290W2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ParametroDtVigenciaIni1',fld:'vPARAMETRODTVIGENCIAINI1',pic:''},{av:'AV16ParametroDtVigenciaIni_To1',fld:'vPARAMETRODTVIGENCIAINI_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20ParametroDtVigenciaIni2',fld:'vPARAMETRODTVIGENCIAINI2',pic:''},{av:'AV21ParametroDtVigenciaIni_To2',fld:'vPARAMETRODTVIGENCIAINI_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25ParametroDtVigenciaIni3',fld:'vPARAMETRODTVIGENCIAINI3',pic:''},{av:'AV26ParametroDtVigenciaIni_To3',fld:'vPARAMETRODTVIGENCIAINI_TO3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31ddo_ParametroIDTitleControlIdToReplace',fld:'vDDO_PARAMETROIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAINITITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAFIMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_ParametroTipoTitleControlIdToReplace',fld:'vDDO_PARAMETROTIPOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_ParametroPrioritariaTitleControlIdToReplace',fld:'vDDO_PARAMETROPRIORITARIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_ParametroValorTitleControlIdToReplace',fld:'vDDO_PARAMETROVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_ParametroPercentualTitleControlIdToReplace',fld:'vDDO_PARAMETROPERCENTUALTITLECONTROLIDTOREPLACE',pic:''},{av:'Gx_date',fld:'vTODAY',pic:''}]");
         setEventMetadata("VDYNAMICFILTERSOPERATOR2.CLICK",",oparms:[{av:'AV20ParametroDtVigenciaIni2',fld:'vPARAMETRODTVIGENCIAINI2',pic:''},{av:'AV21ParametroDtVigenciaIni_To2',fld:'vPARAMETRODTVIGENCIAINI_TO2',pic:''},{av:'cellParametrodtvigenciaini_cell2_Class',ctrl:'PARAMETRODTVIGENCIAINI_CELL2',prop:'Class'},{av:'cellParametrodtvigenciaini_to_cell2_Class',ctrl:'PARAMETRODTVIGENCIAINI_TO_CELL2',prop:'Class'},{av:'lblParametrodtvigenciaini_rangemiddletext_12_Class',ctrl:'PARAMETRODTVIGENCIAINI_RANGEMIDDLETEXT_12',prop:'Class'},{av:'AV30ParametroIDTitleFilterData',fld:'vPARAMETROIDTITLEFILTERDATA',pic:''},{av:'AV32ParametroDtVigenciaIniTitleFilterData',fld:'vPARAMETRODTVIGENCIAINITITLEFILTERDATA',pic:''},{av:'AV34ParametroDtVigenciaFimTitleFilterData',fld:'vPARAMETRODTVIGENCIAFIMTITLEFILTERDATA',pic:''},{av:'AV36ParametroTipoTitleFilterData',fld:'vPARAMETROTIPOTITLEFILTERDATA',pic:''},{av:'AV38ParametroPrioritariaTitleFilterData',fld:'vPARAMETROPRIORITARIATITLEFILTERDATA',pic:''},{av:'AV40ParametroValorTitleFilterData',fld:'vPARAMETROVALORTITLEFILTERDATA',pic:''},{av:'AV42ParametroPercentualTitleFilterData',fld:'vPARAMETROPERCENTUALTITLEFILTERDATA',pic:''},{av:'edtParametroID_Titleformat',ctrl:'PARAMETROID',prop:'Titleformat'},{av:'edtParametroID_Title',ctrl:'PARAMETROID',prop:'Title'},{av:'edtParametroDtVigenciaIni_Titleformat',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Titleformat'},{av:'edtParametroDtVigenciaIni_Title',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Title'},{av:'edtParametroDtVigenciaFim_Titleformat',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Titleformat'},{av:'edtParametroDtVigenciaFim_Title',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Title'},{av:'cmbParametroTipo'},{av:'cmbParametroPrioritaria'},{av:'edtParametroValor_Titleformat',ctrl:'PARAMETROVALOR',prop:'Titleformat'},{av:'edtParametroValor_Title',ctrl:'PARAMETROVALOR',prop:'Title'},{av:'edtParametroPercentual_Titleformat',ctrl:'PARAMETROPERCENTUAL',prop:'Titleformat'},{av:'edtParametroPercentual_Title',ctrl:'PARAMETROPERCENTUAL',prop:'Title'},{av:'AV46GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV47GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("'REMOVEDYNAMICFILTERS3'","{handler:'E220W2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ParametroDtVigenciaIni1',fld:'vPARAMETRODTVIGENCIAINI1',pic:''},{av:'AV16ParametroDtVigenciaIni_To1',fld:'vPARAMETRODTVIGENCIAINI_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20ParametroDtVigenciaIni2',fld:'vPARAMETRODTVIGENCIAINI2',pic:''},{av:'AV21ParametroDtVigenciaIni_To2',fld:'vPARAMETRODTVIGENCIAINI_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25ParametroDtVigenciaIni3',fld:'vPARAMETRODTVIGENCIAINI3',pic:''},{av:'AV26ParametroDtVigenciaIni_To3',fld:'vPARAMETRODTVIGENCIAINI_TO3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31ddo_ParametroIDTitleControlIdToReplace',fld:'vDDO_PARAMETROIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAINITITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAFIMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_ParametroTipoTitleControlIdToReplace',fld:'vDDO_PARAMETROTIPOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_ParametroPrioritariaTitleControlIdToReplace',fld:'vDDO_PARAMETROPRIORITARIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_ParametroValorTitleControlIdToReplace',fld:'vDDO_PARAMETROVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_ParametroPercentualTitleControlIdToReplace',fld:'vDDO_PARAMETROPERCENTUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV8GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Gx_date',fld:'vTODAY',pic:''}]");
         setEventMetadata("'REMOVEDYNAMICFILTERS3'",",oparms:[{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV8GridState',fld:'vGRIDSTATE',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20ParametroDtVigenciaIni2',fld:'vPARAMETRODTVIGENCIAINI2',pic:''},{av:'AV21ParametroDtVigenciaIni_To2',fld:'vPARAMETRODTVIGENCIAINI_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25ParametroDtVigenciaIni3',fld:'vPARAMETRODTVIGENCIAINI3',pic:''},{av:'AV26ParametroDtVigenciaIni_To3',fld:'vPARAMETRODTVIGENCIAINI_TO3',pic:''},{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ParametroDtVigenciaIni1',fld:'vPARAMETRODTVIGENCIAINI1',pic:''},{av:'AV16ParametroDtVigenciaIni_To1',fld:'vPARAMETRODTVIGENCIAINI_TO1',pic:''},{av:'lblJsdynamicfilters_Caption',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{av:'tblTablemergeddynamicfiltersparametrodtvigenciaini2_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPARAMETRODTVIGENCIAINI2',prop:'Visible'},{av:'tblTablemergeddynamicfiltersparametrodtvigenciaini3_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPARAMETRODTVIGENCIAINI3',prop:'Visible'},{av:'tblTablemergeddynamicfiltersparametrodtvigenciaini1_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPARAMETRODTVIGENCIAINI1',prop:'Visible'},{av:'cellParametrodtvigenciaini_cell2_Class',ctrl:'PARAMETRODTVIGENCIAINI_CELL2',prop:'Class'},{av:'cellParametrodtvigenciaini_to_cell2_Class',ctrl:'PARAMETRODTVIGENCIAINI_TO_CELL2',prop:'Class'},{av:'lblParametrodtvigenciaini_rangemiddletext_12_Class',ctrl:'PARAMETRODTVIGENCIAINI_RANGEMIDDLETEXT_12',prop:'Class'},{av:'cellParametrodtvigenciaini_cell3_Class',ctrl:'PARAMETRODTVIGENCIAINI_CELL3',prop:'Class'},{av:'cellParametrodtvigenciaini_to_cell3_Class',ctrl:'PARAMETRODTVIGENCIAINI_TO_CELL3',prop:'Class'},{av:'lblParametrodtvigenciaini_rangemiddletext_13_Class',ctrl:'PARAMETRODTVIGENCIAINI_RANGEMIDDLETEXT_13',prop:'Class'},{av:'cellParametrodtvigenciaini_cell1_Class',ctrl:'PARAMETRODTVIGENCIAINI_CELL1',prop:'Class'},{av:'cellParametrodtvigenciaini_to_cell1_Class',ctrl:'PARAMETRODTVIGENCIAINI_TO_CELL1',prop:'Class'},{av:'lblParametrodtvigenciaini_rangemiddletext_11_Class',ctrl:'PARAMETRODTVIGENCIAINI_RANGEMIDDLETEXT_11',prop:'Class'},{av:'AV30ParametroIDTitleFilterData',fld:'vPARAMETROIDTITLEFILTERDATA',pic:''},{av:'AV32ParametroDtVigenciaIniTitleFilterData',fld:'vPARAMETRODTVIGENCIAINITITLEFILTERDATA',pic:''},{av:'AV34ParametroDtVigenciaFimTitleFilterData',fld:'vPARAMETRODTVIGENCIAFIMTITLEFILTERDATA',pic:''},{av:'AV36ParametroTipoTitleFilterData',fld:'vPARAMETROTIPOTITLEFILTERDATA',pic:''},{av:'AV38ParametroPrioritariaTitleFilterData',fld:'vPARAMETROPRIORITARIATITLEFILTERDATA',pic:''},{av:'AV40ParametroValorTitleFilterData',fld:'vPARAMETROVALORTITLEFILTERDATA',pic:''},{av:'AV42ParametroPercentualTitleFilterData',fld:'vPARAMETROPERCENTUALTITLEFILTERDATA',pic:''},{av:'edtParametroID_Titleformat',ctrl:'PARAMETROID',prop:'Titleformat'},{av:'edtParametroID_Title',ctrl:'PARAMETROID',prop:'Title'},{av:'edtParametroDtVigenciaIni_Titleformat',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Titleformat'},{av:'edtParametroDtVigenciaIni_Title',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Title'},{av:'edtParametroDtVigenciaFim_Titleformat',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Titleformat'},{av:'edtParametroDtVigenciaFim_Title',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Title'},{av:'cmbParametroTipo'},{av:'cmbParametroPrioritaria'},{av:'edtParametroValor_Titleformat',ctrl:'PARAMETROVALOR',prop:'Titleformat'},{av:'edtParametroValor_Title',ctrl:'PARAMETROVALOR',prop:'Title'},{av:'edtParametroPercentual_Titleformat',ctrl:'PARAMETROPERCENTUAL',prop:'Titleformat'},{av:'edtParametroPercentual_Title',ctrl:'PARAMETROPERCENTUAL',prop:'Title'},{av:'AV46GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV47GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("VDYNAMICFILTERSSELECTOR3.CLICK","{handler:'E300W2',iparms:[{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'Gx_date',fld:'vTODAY',pic:''}]");
         setEventMetadata("VDYNAMICFILTERSSELECTOR3.CLICK",",oparms:[{av:'tblTablemergeddynamicfiltersparametrodtvigenciaini3_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPARAMETRODTVIGENCIAINI3',prop:'Visible'},{av:'cmbavDynamicfiltersoperator3'},{av:'cellParametrodtvigenciaini_cell3_Class',ctrl:'PARAMETRODTVIGENCIAINI_CELL3',prop:'Class'},{av:'cellParametrodtvigenciaini_to_cell3_Class',ctrl:'PARAMETRODTVIGENCIAINI_TO_CELL3',prop:'Class'},{av:'lblParametrodtvigenciaini_rangemiddletext_13_Class',ctrl:'PARAMETRODTVIGENCIAINI_RANGEMIDDLETEXT_13',prop:'Class'},{av:'AV25ParametroDtVigenciaIni3',fld:'vPARAMETRODTVIGENCIAINI3',pic:''}]}");
         setEventMetadata("VDYNAMICFILTERSOPERATOR3.CLICK","{handler:'E310W2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ParametroDtVigenciaIni1',fld:'vPARAMETRODTVIGENCIAINI1',pic:''},{av:'AV16ParametroDtVigenciaIni_To1',fld:'vPARAMETRODTVIGENCIAINI_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20ParametroDtVigenciaIni2',fld:'vPARAMETRODTVIGENCIAINI2',pic:''},{av:'AV21ParametroDtVigenciaIni_To2',fld:'vPARAMETRODTVIGENCIAINI_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25ParametroDtVigenciaIni3',fld:'vPARAMETRODTVIGENCIAINI3',pic:''},{av:'AV26ParametroDtVigenciaIni_To3',fld:'vPARAMETRODTVIGENCIAINI_TO3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31ddo_ParametroIDTitleControlIdToReplace',fld:'vDDO_PARAMETROIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAINITITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAFIMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_ParametroTipoTitleControlIdToReplace',fld:'vDDO_PARAMETROTIPOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_ParametroPrioritariaTitleControlIdToReplace',fld:'vDDO_PARAMETROPRIORITARIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_ParametroValorTitleControlIdToReplace',fld:'vDDO_PARAMETROVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_ParametroPercentualTitleControlIdToReplace',fld:'vDDO_PARAMETROPERCENTUALTITLECONTROLIDTOREPLACE',pic:''},{av:'Gx_date',fld:'vTODAY',pic:''}]");
         setEventMetadata("VDYNAMICFILTERSOPERATOR3.CLICK",",oparms:[{av:'AV25ParametroDtVigenciaIni3',fld:'vPARAMETRODTVIGENCIAINI3',pic:''},{av:'AV26ParametroDtVigenciaIni_To3',fld:'vPARAMETRODTVIGENCIAINI_TO3',pic:''},{av:'cellParametrodtvigenciaini_cell3_Class',ctrl:'PARAMETRODTVIGENCIAINI_CELL3',prop:'Class'},{av:'cellParametrodtvigenciaini_to_cell3_Class',ctrl:'PARAMETRODTVIGENCIAINI_TO_CELL3',prop:'Class'},{av:'lblParametrodtvigenciaini_rangemiddletext_13_Class',ctrl:'PARAMETRODTVIGENCIAINI_RANGEMIDDLETEXT_13',prop:'Class'},{av:'AV30ParametroIDTitleFilterData',fld:'vPARAMETROIDTITLEFILTERDATA',pic:''},{av:'AV32ParametroDtVigenciaIniTitleFilterData',fld:'vPARAMETRODTVIGENCIAINITITLEFILTERDATA',pic:''},{av:'AV34ParametroDtVigenciaFimTitleFilterData',fld:'vPARAMETRODTVIGENCIAFIMTITLEFILTERDATA',pic:''},{av:'AV36ParametroTipoTitleFilterData',fld:'vPARAMETROTIPOTITLEFILTERDATA',pic:''},{av:'AV38ParametroPrioritariaTitleFilterData',fld:'vPARAMETROPRIORITARIATITLEFILTERDATA',pic:''},{av:'AV40ParametroValorTitleFilterData',fld:'vPARAMETROVALORTITLEFILTERDATA',pic:''},{av:'AV42ParametroPercentualTitleFilterData',fld:'vPARAMETROPERCENTUALTITLEFILTERDATA',pic:''},{av:'edtParametroID_Titleformat',ctrl:'PARAMETROID',prop:'Titleformat'},{av:'edtParametroID_Title',ctrl:'PARAMETROID',prop:'Title'},{av:'edtParametroDtVigenciaIni_Titleformat',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Titleformat'},{av:'edtParametroDtVigenciaIni_Title',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Title'},{av:'edtParametroDtVigenciaFim_Titleformat',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Titleformat'},{av:'edtParametroDtVigenciaFim_Title',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Title'},{av:'cmbParametroTipo'},{av:'cmbParametroPrioritaria'},{av:'edtParametroValor_Titleformat',ctrl:'PARAMETROVALOR',prop:'Titleformat'},{av:'edtParametroValor_Title',ctrl:'PARAMETROVALOR',prop:'Title'},{av:'edtParametroPercentual_Titleformat',ctrl:'PARAMETROPERCENTUAL',prop:'Titleformat'},{av:'edtParametroPercentual_Title',ctrl:'PARAMETROPERCENTUAL',prop:'Title'},{av:'AV46GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV47GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("'DOCLEANFILTERS'","{handler:'E230W2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ParametroDtVigenciaIni1',fld:'vPARAMETRODTVIGENCIAINI1',pic:''},{av:'AV16ParametroDtVigenciaIni_To1',fld:'vPARAMETRODTVIGENCIAINI_TO1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20ParametroDtVigenciaIni2',fld:'vPARAMETRODTVIGENCIAINI2',pic:''},{av:'AV21ParametroDtVigenciaIni_To2',fld:'vPARAMETRODTVIGENCIAINI_TO2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25ParametroDtVigenciaIni3',fld:'vPARAMETRODTVIGENCIAINI3',pic:''},{av:'AV26ParametroDtVigenciaIni_To3',fld:'vPARAMETRODTVIGENCIAINI_TO3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31ddo_ParametroIDTitleControlIdToReplace',fld:'vDDO_PARAMETROIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAINITITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAFIMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_ParametroTipoTitleControlIdToReplace',fld:'vDDO_PARAMETROTIPOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_ParametroPrioritariaTitleControlIdToReplace',fld:'vDDO_PARAMETROPRIORITARIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_ParametroValorTitleControlIdToReplace',fld:'vDDO_PARAMETROVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_ParametroPercentualTitleControlIdToReplace',fld:'vDDO_PARAMETROPERCENTUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV8GridState',fld:'vGRIDSTATE',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Gx_date',fld:'vTODAY',pic:''}]");
         setEventMetadata("'DOCLEANFILTERS'",",oparms:[{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ParametroDtVigenciaIni1',fld:'vPARAMETRODTVIGENCIAINI1',pic:''},{av:'AV16ParametroDtVigenciaIni_To1',fld:'vPARAMETRODTVIGENCIAINI_TO1',pic:''},{av:'AV8GridState',fld:'vGRIDSTATE',pic:''},{av:'tblTablemergeddynamicfiltersparametrodtvigenciaini1_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPARAMETRODTVIGENCIAINI1',prop:'Visible'},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20ParametroDtVigenciaIni2',fld:'vPARAMETRODTVIGENCIAINI2',pic:''},{av:'AV21ParametroDtVigenciaIni_To2',fld:'vPARAMETRODTVIGENCIAINI_TO2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25ParametroDtVigenciaIni3',fld:'vPARAMETRODTVIGENCIAINI3',pic:''},{av:'AV26ParametroDtVigenciaIni_To3',fld:'vPARAMETRODTVIGENCIAINI_TO3',pic:''},{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'lblJsdynamicfilters_Caption',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{av:'cellParametrodtvigenciaini_cell1_Class',ctrl:'PARAMETRODTVIGENCIAINI_CELL1',prop:'Class'},{av:'cellParametrodtvigenciaini_to_cell1_Class',ctrl:'PARAMETRODTVIGENCIAINI_TO_CELL1',prop:'Class'},{av:'lblParametrodtvigenciaini_rangemiddletext_11_Class',ctrl:'PARAMETRODTVIGENCIAINI_RANGEMIDDLETEXT_11',prop:'Class'},{av:'tblTablemergeddynamicfiltersparametrodtvigenciaini2_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPARAMETRODTVIGENCIAINI2',prop:'Visible'},{av:'tblTablemergeddynamicfiltersparametrodtvigenciaini3_Visible',ctrl:'TABLEMERGEDDYNAMICFILTERSPARAMETRODTVIGENCIAINI3',prop:'Visible'},{av:'cellParametrodtvigenciaini_cell2_Class',ctrl:'PARAMETRODTVIGENCIAINI_CELL2',prop:'Class'},{av:'cellParametrodtvigenciaini_to_cell2_Class',ctrl:'PARAMETRODTVIGENCIAINI_TO_CELL2',prop:'Class'},{av:'lblParametrodtvigenciaini_rangemiddletext_12_Class',ctrl:'PARAMETRODTVIGENCIAINI_RANGEMIDDLETEXT_12',prop:'Class'},{av:'cellParametrodtvigenciaini_cell3_Class',ctrl:'PARAMETRODTVIGENCIAINI_CELL3',prop:'Class'},{av:'cellParametrodtvigenciaini_to_cell3_Class',ctrl:'PARAMETRODTVIGENCIAINI_TO_CELL3',prop:'Class'},{av:'lblParametrodtvigenciaini_rangemiddletext_13_Class',ctrl:'PARAMETRODTVIGENCIAINI_RANGEMIDDLETEXT_13',prop:'Class'},{av:'AV30ParametroIDTitleFilterData',fld:'vPARAMETROIDTITLEFILTERDATA',pic:''},{av:'AV32ParametroDtVigenciaIniTitleFilterData',fld:'vPARAMETRODTVIGENCIAINITITLEFILTERDATA',pic:''},{av:'AV34ParametroDtVigenciaFimTitleFilterData',fld:'vPARAMETRODTVIGENCIAFIMTITLEFILTERDATA',pic:''},{av:'AV36ParametroTipoTitleFilterData',fld:'vPARAMETROTIPOTITLEFILTERDATA',pic:''},{av:'AV38ParametroPrioritariaTitleFilterData',fld:'vPARAMETROPRIORITARIATITLEFILTERDATA',pic:''},{av:'AV40ParametroValorTitleFilterData',fld:'vPARAMETROVALORTITLEFILTERDATA',pic:''},{av:'AV42ParametroPercentualTitleFilterData',fld:'vPARAMETROPERCENTUALTITLEFILTERDATA',pic:''},{av:'edtParametroID_Titleformat',ctrl:'PARAMETROID',prop:'Titleformat'},{av:'edtParametroID_Title',ctrl:'PARAMETROID',prop:'Title'},{av:'edtParametroDtVigenciaIni_Titleformat',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Titleformat'},{av:'edtParametroDtVigenciaIni_Title',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Title'},{av:'edtParametroDtVigenciaFim_Titleformat',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Titleformat'},{av:'edtParametroDtVigenciaFim_Title',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Title'},{av:'cmbParametroTipo'},{av:'cmbParametroPrioritaria'},{av:'edtParametroValor_Titleformat',ctrl:'PARAMETROVALOR',prop:'Titleformat'},{av:'edtParametroValor_Title',ctrl:'PARAMETROVALOR',prop:'Title'},{av:'edtParametroPercentual_Titleformat',ctrl:'PARAMETROPERCENTUAL',prop:'Titleformat'},{av:'edtParametroPercentual_Title',ctrl:'PARAMETROPERCENTUAL',prop:'Title'},{av:'AV46GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV47GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
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
         wcpOAV50InOutParametroDtVigenciaIni = DateTime.MinValue;
         Gridpaginationbar_Selectedpage = "";
         Ddo_parametroid_Activeeventkey = "";
         Ddo_parametrodtvigenciaini_Activeeventkey = "";
         Ddo_parametrodtvigenciafim_Activeeventkey = "";
         Ddo_parametrotipo_Activeeventkey = "";
         Ddo_parametroprioritaria_Activeeventkey = "";
         Ddo_parametrovalor_Activeeventkey = "";
         Ddo_parametropercentual_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV13DynamicFiltersSelector1 = "";
         AV15ParametroDtVigenciaIni1 = DateTime.MinValue;
         AV16ParametroDtVigenciaIni_To1 = DateTime.MinValue;
         AV18DynamicFiltersSelector2 = "";
         AV20ParametroDtVigenciaIni2 = DateTime.MinValue;
         AV21ParametroDtVigenciaIni_To2 = DateTime.MinValue;
         AV23DynamicFiltersSelector3 = "";
         AV25ParametroDtVigenciaIni3 = DateTime.MinValue;
         AV26ParametroDtVigenciaIni_To3 = DateTime.MinValue;
         AV31ddo_ParametroIDTitleControlIdToReplace = "";
         AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace = "";
         AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace = "";
         AV37ddo_ParametroTipoTitleControlIdToReplace = "";
         AV39ddo_ParametroPrioritariaTitleControlIdToReplace = "";
         AV41ddo_ParametroValorTitleControlIdToReplace = "";
         AV43ddo_ParametroPercentualTitleControlIdToReplace = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV44DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV30ParametroIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV32ParametroDtVigenciaIniTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV34ParametroDtVigenciaFimTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV36ParametroTipoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV38ParametroPrioritariaTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV40ParametroValorTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV42ParametroPercentualTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV8GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         Gx_date = DateTime.MinValue;
         Ddo_parametroid_Sortedstatus = "";
         Ddo_parametrodtvigenciaini_Sortedstatus = "";
         Ddo_parametrodtvigenciafim_Sortedstatus = "";
         Ddo_parametrotipo_Sortedstatus = "";
         Ddo_parametroprioritaria_Sortedstatus = "";
         Ddo_parametrovalor_Sortedstatus = "";
         Ddo_parametropercentual_Sortedstatus = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ucDvpanel_tableheader = new GXUserControl();
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV48Select = "";
         A14ParametroDtVigenciaIni = DateTime.MinValue;
         A15ParametroDtVigenciaFim = DateTime.MinValue;
         A16ParametroTipo = "";
         A17ParametroPrioritaria = "";
         ucGridpaginationbar = new GXUserControl();
         lblJsdynamicfilters_Jsonclick = "";
         ucDdo_parametroid = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         ucDdo_parametrodtvigenciaini = new GXUserControl();
         ucDdo_parametrodtvigenciafim = new GXUserControl();
         ucDdo_parametrotipo = new GXUserControl();
         ucDdo_parametroprioritaria = new GXUserControl();
         ucDdo_parametrovalor = new GXUserControl();
         ucDdo_parametropercentual = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV53Select_GXI = "";
         scmdbuf = "";
         H000W2_A19ParametroPercentual = new decimal[1] ;
         H000W2_A18ParametroValor = new decimal[1] ;
         H000W2_A17ParametroPrioritaria = new String[] {""} ;
         H000W2_A16ParametroTipo = new String[] {""} ;
         H000W2_A15ParametroDtVigenciaFim = new DateTime[] {DateTime.MinValue} ;
         H000W2_A14ParametroDtVigenciaIni = new DateTime[] {DateTime.MinValue} ;
         H000W2_A13ParametroID = new short[1] ;
         H000W3_AGRID_nRecordCount = new long[1] ;
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
         lblParametrodtvigenciaini_rangemiddletext_13_Jsonclick = "";
         lblParametrodtvigenciaini_rangemiddletext_12_Jsonclick = "";
         lblParametrodtvigenciaini_rangemiddletext_11_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.parametroprompt__default(),
            new Object[][] {
                new Object[] {
               H000W2_A19ParametroPercentual, H000W2_A18ParametroValor, H000W2_A17ParametroPrioritaria, H000W2_A16ParametroTipo, H000W2_A15ParametroDtVigenciaFim, H000W2_A14ParametroDtVigenciaIni, H000W2_A13ParametroID
               }
               , new Object[] {
               H000W3_AGRID_nRecordCount
               }
            }
         );
         Gx_date = DateTimeUtil.Today( context);
         /* GeneXus formulas. */
         Gx_date = DateTimeUtil.Today( context);
         context.Gx_err = 0;
      }

      private short AV49InOutParametroID ;
      private short wcpOAV49InOutParametroID ;
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
      private short edtParametroID_Titleformat ;
      private short edtParametroDtVigenciaIni_Titleformat ;
      private short edtParametroDtVigenciaFim_Titleformat ;
      private short cmbParametroTipo_Titleformat ;
      private short cmbParametroPrioritaria_Titleformat ;
      private short edtParametroValor_Titleformat ;
      private short edtParametroPercentual_Titleformat ;
      private short subGrid_Sortable ;
      private short A13ParametroID ;
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
      private int edtavDdo_parametroidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_parametrodtvigenciainititlecontrolidtoreplace_Visible ;
      private int edtavDdo_parametrodtvigenciafimtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_parametrotipotitlecontrolidtoreplace_Visible ;
      private int edtavDdo_parametroprioritariatitlecontrolidtoreplace_Visible ;
      private int edtavDdo_parametrovalortitlecontrolidtoreplace_Visible ;
      private int edtavDdo_parametropercentualtitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV45PageToGo ;
      private int imgAdddynamicfilters1_Visible ;
      private int imgRemovedynamicfilters1_Visible ;
      private int imgAdddynamicfilters2_Visible ;
      private int imgRemovedynamicfilters2_Visible ;
      private int tblTablemergeddynamicfiltersparametrodtvigenciaini1_Visible ;
      private int tblTablemergeddynamicfiltersparametrodtvigenciaini2_Visible ;
      private int tblTablemergeddynamicfiltersparametrodtvigenciaini3_Visible ;
      private int edtavParametrodtvigenciaini3_Enabled ;
      private int edtavParametrodtvigenciaini_to3_Enabled ;
      private int edtavParametrodtvigenciaini2_Enabled ;
      private int edtavParametrodtvigenciaini_to2_Enabled ;
      private int edtavParametrodtvigenciaini1_Enabled ;
      private int edtavParametrodtvigenciaini_to1_Enabled ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavSelect_Enabled ;
      private int edtavSelect_Visible ;
      private long GRID_nFirstRecordOnPage ;
      private long AV46GridCurrentPage ;
      private long AV47GridPageCount ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private decimal A18ParametroValor ;
      private decimal A19ParametroPercentual ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_parametroid_Activeeventkey ;
      private String Ddo_parametrodtvigenciaini_Activeeventkey ;
      private String Ddo_parametrodtvigenciafim_Activeeventkey ;
      private String Ddo_parametrotipo_Activeeventkey ;
      private String Ddo_parametroprioritaria_Activeeventkey ;
      private String Ddo_parametrovalor_Activeeventkey ;
      private String Ddo_parametropercentual_Activeeventkey ;
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
      private String Ddo_parametroid_Caption ;
      private String Ddo_parametroid_Tooltip ;
      private String Ddo_parametroid_Cls ;
      private String Ddo_parametroid_Dropdownoptionstype ;
      private String Ddo_parametroid_Titlecontrolidtoreplace ;
      private String Ddo_parametroid_Sortedstatus ;
      private String Ddo_parametroid_Sortasc ;
      private String Ddo_parametroid_Sortdsc ;
      private String Ddo_parametroid_Cleanfilter ;
      private String Ddo_parametroid_Searchbuttontext ;
      private String Ddo_parametrodtvigenciaini_Caption ;
      private String Ddo_parametrodtvigenciaini_Tooltip ;
      private String Ddo_parametrodtvigenciaini_Cls ;
      private String Ddo_parametrodtvigenciaini_Dropdownoptionstype ;
      private String Ddo_parametrodtvigenciaini_Titlecontrolidtoreplace ;
      private String Ddo_parametrodtvigenciaini_Sortedstatus ;
      private String Ddo_parametrodtvigenciaini_Sortasc ;
      private String Ddo_parametrodtvigenciaini_Sortdsc ;
      private String Ddo_parametrodtvigenciaini_Cleanfilter ;
      private String Ddo_parametrodtvigenciaini_Searchbuttontext ;
      private String Ddo_parametrodtvigenciafim_Caption ;
      private String Ddo_parametrodtvigenciafim_Tooltip ;
      private String Ddo_parametrodtvigenciafim_Cls ;
      private String Ddo_parametrodtvigenciafim_Dropdownoptionstype ;
      private String Ddo_parametrodtvigenciafim_Titlecontrolidtoreplace ;
      private String Ddo_parametrodtvigenciafim_Sortedstatus ;
      private String Ddo_parametrodtvigenciafim_Sortasc ;
      private String Ddo_parametrodtvigenciafim_Sortdsc ;
      private String Ddo_parametrodtvigenciafim_Cleanfilter ;
      private String Ddo_parametrodtvigenciafim_Searchbuttontext ;
      private String Ddo_parametrotipo_Caption ;
      private String Ddo_parametrotipo_Tooltip ;
      private String Ddo_parametrotipo_Cls ;
      private String Ddo_parametrotipo_Dropdownoptionstype ;
      private String Ddo_parametrotipo_Titlecontrolidtoreplace ;
      private String Ddo_parametrotipo_Sortedstatus ;
      private String Ddo_parametrotipo_Sortasc ;
      private String Ddo_parametrotipo_Sortdsc ;
      private String Ddo_parametrotipo_Cleanfilter ;
      private String Ddo_parametrotipo_Searchbuttontext ;
      private String Ddo_parametroprioritaria_Caption ;
      private String Ddo_parametroprioritaria_Tooltip ;
      private String Ddo_parametroprioritaria_Cls ;
      private String Ddo_parametroprioritaria_Dropdownoptionstype ;
      private String Ddo_parametroprioritaria_Titlecontrolidtoreplace ;
      private String Ddo_parametroprioritaria_Sortedstatus ;
      private String Ddo_parametroprioritaria_Sortasc ;
      private String Ddo_parametroprioritaria_Sortdsc ;
      private String Ddo_parametroprioritaria_Cleanfilter ;
      private String Ddo_parametroprioritaria_Searchbuttontext ;
      private String Ddo_parametrovalor_Caption ;
      private String Ddo_parametrovalor_Tooltip ;
      private String Ddo_parametrovalor_Cls ;
      private String Ddo_parametrovalor_Dropdownoptionstype ;
      private String Ddo_parametrovalor_Titlecontrolidtoreplace ;
      private String Ddo_parametrovalor_Sortedstatus ;
      private String Ddo_parametrovalor_Sortasc ;
      private String Ddo_parametrovalor_Sortdsc ;
      private String Ddo_parametrovalor_Cleanfilter ;
      private String Ddo_parametrovalor_Searchbuttontext ;
      private String Ddo_parametropercentual_Caption ;
      private String Ddo_parametropercentual_Tooltip ;
      private String Ddo_parametropercentual_Cls ;
      private String Ddo_parametropercentual_Dropdownoptionstype ;
      private String Ddo_parametropercentual_Titlecontrolidtoreplace ;
      private String Ddo_parametropercentual_Sortedstatus ;
      private String Ddo_parametropercentual_Sortasc ;
      private String Ddo_parametropercentual_Sortdsc ;
      private String Ddo_parametropercentual_Cleanfilter ;
      private String Ddo_parametropercentual_Searchbuttontext ;
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
      private String edtParametroID_Title ;
      private String edtParametroDtVigenciaIni_Title ;
      private String edtParametroDtVigenciaFim_Title ;
      private String edtParametroValor_Title ;
      private String edtParametroPercentual_Title ;
      private String subGrid_Header ;
      private String edtavSelect_Tooltiptext ;
      private String A16ParametroTipo ;
      private String A17ParametroPrioritaria ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String lblJsdynamicfilters_Internalname ;
      private String lblJsdynamicfilters_Caption ;
      private String lblJsdynamicfilters_Jsonclick ;
      private String Ddo_parametroid_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String edtavDdo_parametroidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_parametrodtvigenciaini_Internalname ;
      private String edtavDdo_parametrodtvigenciainititlecontrolidtoreplace_Internalname ;
      private String Ddo_parametrodtvigenciafim_Internalname ;
      private String edtavDdo_parametrodtvigenciafimtitlecontrolidtoreplace_Internalname ;
      private String Ddo_parametrotipo_Internalname ;
      private String edtavDdo_parametrotipotitlecontrolidtoreplace_Internalname ;
      private String Ddo_parametroprioritaria_Internalname ;
      private String edtavDdo_parametroprioritariatitlecontrolidtoreplace_Internalname ;
      private String Ddo_parametrovalor_Internalname ;
      private String edtavDdo_parametrovalortitlecontrolidtoreplace_Internalname ;
      private String Ddo_parametropercentual_Internalname ;
      private String edtavDdo_parametropercentualtitlecontrolidtoreplace_Internalname ;
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
      private String edtParametroID_Internalname ;
      private String edtParametroDtVigenciaIni_Internalname ;
      private String edtParametroDtVigenciaFim_Internalname ;
      private String cmbParametroTipo_Internalname ;
      private String cmbParametroPrioritaria_Internalname ;
      private String edtParametroValor_Internalname ;
      private String edtParametroPercentual_Internalname ;
      private String cmbavDynamicfiltersselector1_Internalname ;
      private String cmbavDynamicfiltersoperator1_Internalname ;
      private String cmbavDynamicfiltersselector2_Internalname ;
      private String cmbavDynamicfiltersoperator2_Internalname ;
      private String cmbavDynamicfiltersselector3_Internalname ;
      private String cmbavDynamicfiltersoperator3_Internalname ;
      private String scmdbuf ;
      private String edtavParametrodtvigenciaini1_Internalname ;
      private String edtavParametrodtvigenciaini_to1_Internalname ;
      private String edtavParametrodtvigenciaini2_Internalname ;
      private String edtavParametrodtvigenciaini_to2_Internalname ;
      private String edtavParametrodtvigenciaini3_Internalname ;
      private String edtavParametrodtvigenciaini_to3_Internalname ;
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
      private String tblTablemergeddynamicfiltersparametrodtvigenciaini1_Internalname ;
      private String cellParametrodtvigenciaini_cell1_Class ;
      private String cellParametrodtvigenciaini_cell1_Internalname ;
      private String cellParametrodtvigenciaini_to_cell1_Class ;
      private String cellParametrodtvigenciaini_to_cell1_Internalname ;
      private String lblParametrodtvigenciaini_rangemiddletext_11_Class ;
      private String lblParametrodtvigenciaini_rangemiddletext_11_Internalname ;
      private String tblTablemergeddynamicfiltersparametrodtvigenciaini2_Internalname ;
      private String cellParametrodtvigenciaini_cell2_Class ;
      private String cellParametrodtvigenciaini_cell2_Internalname ;
      private String cellParametrodtvigenciaini_to_cell2_Class ;
      private String cellParametrodtvigenciaini_to_cell2_Internalname ;
      private String lblParametrodtvigenciaini_rangemiddletext_12_Class ;
      private String lblParametrodtvigenciaini_rangemiddletext_12_Internalname ;
      private String tblTablemergeddynamicfiltersparametrodtvigenciaini3_Internalname ;
      private String cellParametrodtvigenciaini_cell3_Class ;
      private String cellParametrodtvigenciaini_cell3_Internalname ;
      private String cellParametrodtvigenciaini_to_cell3_Class ;
      private String cellParametrodtvigenciaini_to_cell3_Internalname ;
      private String lblParametrodtvigenciaini_rangemiddletext_13_Class ;
      private String lblParametrodtvigenciaini_rangemiddletext_13_Internalname ;
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
      private String cellFilter_parametrodtvigenciaini3_cell_Internalname ;
      private String edtavParametrodtvigenciaini3_Jsonclick ;
      private String cellParametrodtvigenciaini_rangemiddletext_1_cell3_Internalname ;
      private String lblParametrodtvigenciaini_rangemiddletext_13_Jsonclick ;
      private String edtavParametrodtvigenciaini_to3_Jsonclick ;
      private String tblUnnamedtabledynamicfilters_2_Internalname ;
      private String cellDynamicfilters_addfilter2_cell_Internalname ;
      private String cellDynamicfilters_removefilter2_cell_Internalname ;
      private String tblTablemergeddynamicfilters2_Internalname ;
      private String cmbavDynamicfiltersoperator2_Jsonclick ;
      private String cellFilter_parametrodtvigenciaini2_cell_Internalname ;
      private String edtavParametrodtvigenciaini2_Jsonclick ;
      private String cellParametrodtvigenciaini_rangemiddletext_1_cell2_Internalname ;
      private String lblParametrodtvigenciaini_rangemiddletext_12_Jsonclick ;
      private String edtavParametrodtvigenciaini_to2_Jsonclick ;
      private String tblUnnamedtabledynamicfilters_1_Internalname ;
      private String cellDynamicfilters_addfilter1_cell_Internalname ;
      private String cellDynamicfilters_removefilter1_cell_Internalname ;
      private String tblTablemergeddynamicfilters1_Internalname ;
      private String cmbavDynamicfiltersoperator1_Jsonclick ;
      private String cellFilter_parametrodtvigenciaini1_cell_Internalname ;
      private String edtavParametrodtvigenciaini1_Jsonclick ;
      private String cellParametrodtvigenciaini_rangemiddletext_1_cell1_Internalname ;
      private String lblParametrodtvigenciaini_rangemiddletext_11_Jsonclick ;
      private String edtavParametrodtvigenciaini_to1_Jsonclick ;
      private String sGXsfl_119_fel_idx="0001" ;
      private String edtavSelect_Jsonclick ;
      private String ROClassString ;
      private String edtParametroID_Jsonclick ;
      private String edtParametroDtVigenciaIni_Jsonclick ;
      private String edtParametroDtVigenciaFim_Jsonclick ;
      private String GXCCtl ;
      private String cmbParametroTipo_Jsonclick ;
      private String cmbParametroPrioritaria_Jsonclick ;
      private String edtParametroValor_Jsonclick ;
      private String edtParametroPercentual_Jsonclick ;
      private DateTime AV50InOutParametroDtVigenciaIni ;
      private DateTime wcpOAV50InOutParametroDtVigenciaIni ;
      private DateTime AV15ParametroDtVigenciaIni1 ;
      private DateTime AV16ParametroDtVigenciaIni_To1 ;
      private DateTime AV20ParametroDtVigenciaIni2 ;
      private DateTime AV21ParametroDtVigenciaIni_To2 ;
      private DateTime AV25ParametroDtVigenciaIni3 ;
      private DateTime AV26ParametroDtVigenciaIni_To3 ;
      private DateTime Gx_date ;
      private DateTime A14ParametroDtVigenciaIni ;
      private DateTime A15ParametroDtVigenciaFim ;
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
      private bool Ddo_parametroid_Includesortasc ;
      private bool Ddo_parametroid_Includesortdsc ;
      private bool Ddo_parametroid_Includefilter ;
      private bool Ddo_parametroid_Includedatalist ;
      private bool Ddo_parametrodtvigenciaini_Includesortasc ;
      private bool Ddo_parametrodtvigenciaini_Includesortdsc ;
      private bool Ddo_parametrodtvigenciaini_Includefilter ;
      private bool Ddo_parametrodtvigenciaini_Includedatalist ;
      private bool Ddo_parametrodtvigenciafim_Includesortasc ;
      private bool Ddo_parametrodtvigenciafim_Includesortdsc ;
      private bool Ddo_parametrodtvigenciafim_Includefilter ;
      private bool Ddo_parametrodtvigenciafim_Includedatalist ;
      private bool Ddo_parametrotipo_Includesortasc ;
      private bool Ddo_parametrotipo_Includesortdsc ;
      private bool Ddo_parametrotipo_Includefilter ;
      private bool Ddo_parametrotipo_Includedatalist ;
      private bool Ddo_parametroprioritaria_Includesortasc ;
      private bool Ddo_parametroprioritaria_Includesortdsc ;
      private bool Ddo_parametroprioritaria_Includefilter ;
      private bool Ddo_parametroprioritaria_Includedatalist ;
      private bool Ddo_parametrovalor_Includesortasc ;
      private bool Ddo_parametrovalor_Includesortdsc ;
      private bool Ddo_parametrovalor_Includefilter ;
      private bool Ddo_parametrovalor_Includedatalist ;
      private bool Ddo_parametropercentual_Includesortasc ;
      private bool Ddo_parametropercentual_Includesortdsc ;
      private bool Ddo_parametropercentual_Includefilter ;
      private bool Ddo_parametropercentual_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_119_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV48Select_IsBlob ;
      private String AV13DynamicFiltersSelector1 ;
      private String AV18DynamicFiltersSelector2 ;
      private String AV23DynamicFiltersSelector3 ;
      private String AV31ddo_ParametroIDTitleControlIdToReplace ;
      private String AV33ddo_ParametroDtVigenciaIniTitleControlIdToReplace ;
      private String AV35ddo_ParametroDtVigenciaFimTitleControlIdToReplace ;
      private String AV37ddo_ParametroTipoTitleControlIdToReplace ;
      private String AV39ddo_ParametroPrioritariaTitleControlIdToReplace ;
      private String AV41ddo_ParametroValorTitleControlIdToReplace ;
      private String AV43ddo_ParametroPercentualTitleControlIdToReplace ;
      private String AV53Select_GXI ;
      private String AV48Select ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_parametroid ;
      private GXUserControl ucDdo_parametrodtvigenciaini ;
      private GXUserControl ucDdo_parametrodtvigenciafim ;
      private GXUserControl ucDdo_parametrotipo ;
      private GXUserControl ucDdo_parametroprioritaria ;
      private GXUserControl ucDdo_parametrovalor ;
      private GXUserControl ucDdo_parametropercentual ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private IGxDataStore dsDefault ;
      private short aP0_InOutParametroID ;
      private DateTime aP1_InOutParametroDtVigenciaIni ;
      private GXCombobox cmbavDynamicfiltersselector1 ;
      private GXCombobox cmbavDynamicfiltersoperator1 ;
      private GXCombobox cmbavDynamicfiltersselector2 ;
      private GXCombobox cmbavDynamicfiltersoperator2 ;
      private GXCombobox cmbavDynamicfiltersselector3 ;
      private GXCombobox cmbavDynamicfiltersoperator3 ;
      private GXCombobox cmbParametroTipo ;
      private GXCombobox cmbParametroPrioritaria ;
      private GXCheckbox chkavDynamicfiltersenabled2 ;
      private GXCheckbox chkavDynamicfiltersenabled3 ;
      private IDataStoreProvider pr_default ;
      private decimal[] H000W2_A19ParametroPercentual ;
      private decimal[] H000W2_A18ParametroValor ;
      private String[] H000W2_A17ParametroPrioritaria ;
      private String[] H000W2_A16ParametroTipo ;
      private DateTime[] H000W2_A15ParametroDtVigenciaFim ;
      private DateTime[] H000W2_A14ParametroDtVigenciaIni ;
      private short[] H000W2_A13ParametroID ;
      private long[] H000W3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV30ParametroIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV32ParametroDtVigenciaIniTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV34ParametroDtVigenciaFimTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV36ParametroTipoTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV38ParametroPrioritariaTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV40ParametroValorTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV42ParametroPercentualTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV8GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter AV10GridStateDynamicFilter ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV44DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class parametroprompt__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H000W2( IGxContext context ,
                                             String AV13DynamicFiltersSelector1 ,
                                             short AV14DynamicFiltersOperator1 ,
                                             DateTime AV15ParametroDtVigenciaIni1 ,
                                             DateTime AV16ParametroDtVigenciaIni_To1 ,
                                             bool AV17DynamicFiltersEnabled2 ,
                                             String AV18DynamicFiltersSelector2 ,
                                             short AV19DynamicFiltersOperator2 ,
                                             DateTime AV20ParametroDtVigenciaIni2 ,
                                             DateTime AV21ParametroDtVigenciaIni_To2 ,
                                             bool AV22DynamicFiltersEnabled3 ,
                                             String AV23DynamicFiltersSelector3 ,
                                             short AV24DynamicFiltersOperator3 ,
                                             DateTime AV25ParametroDtVigenciaIni3 ,
                                             DateTime AV26ParametroDtVigenciaIni_To3 ,
                                             DateTime A14ParametroDtVigenciaIni ,
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
         sSelectString = " [ParametroPercentual], [ParametroValor], [ParametroPrioritaria], [ParametroTipo], [ParametroDtVigenciaFim], [ParametroDtVigenciaIni], [ParametroID]";
         sFromString = " FROM [Parametro]";
         sOrderString = "";
         if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PARAMETRODTVIGENCIAINI") == 0 ) && ( AV14DynamicFiltersOperator1 == 0 ) && ( ! (DateTime.MinValue==AV15ParametroDtVigenciaIni1) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaIni] < @AV15ParametroDtVigenciaIni1)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaIni] < @AV15ParametroDtVigenciaIni1)";
            }
         }
         else
         {
            GXv_int2[0] = 1;
         }
         if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PARAMETRODTVIGENCIAINI") == 0 ) && ( AV14DynamicFiltersOperator1 == 1 ) && ( ! (DateTime.MinValue==AV15ParametroDtVigenciaIni1) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaIni] = @AV15ParametroDtVigenciaIni1)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaIni] = @AV15ParametroDtVigenciaIni1)";
            }
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PARAMETRODTVIGENCIAINI") == 0 ) && ( AV14DynamicFiltersOperator1 == 2 ) && ( ! (DateTime.MinValue==AV15ParametroDtVigenciaIni1) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaIni] > @AV15ParametroDtVigenciaIni1)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaIni] > @AV15ParametroDtVigenciaIni1)";
            }
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PARAMETRODTVIGENCIAINI") == 0 ) && ( AV14DynamicFiltersOperator1 == 3 ) && ( ! (DateTime.MinValue==AV15ParametroDtVigenciaIni1) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaIni] >= @AV15ParametroDtVigenciaIni1)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaIni] >= @AV15ParametroDtVigenciaIni1)";
            }
         }
         else
         {
            GXv_int2[3] = 1;
         }
         if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PARAMETRODTVIGENCIAINI") == 0 ) && ( AV14DynamicFiltersOperator1 == 3 ) && ( ! (DateTime.MinValue==AV16ParametroDtVigenciaIni_To1) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaIni] <= @AV16ParametroDtVigenciaIni_To1)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaIni] <= @AV16ParametroDtVigenciaIni_To1)";
            }
         }
         else
         {
            GXv_int2[4] = 1;
         }
         if ( AV17DynamicFiltersEnabled2 && ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PARAMETRODTVIGENCIAINI") == 0 ) && ( AV19DynamicFiltersOperator2 == 0 ) && ( ! (DateTime.MinValue==AV20ParametroDtVigenciaIni2) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaIni] < @AV20ParametroDtVigenciaIni2)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaIni] < @AV20ParametroDtVigenciaIni2)";
            }
         }
         else
         {
            GXv_int2[5] = 1;
         }
         if ( AV17DynamicFiltersEnabled2 && ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PARAMETRODTVIGENCIAINI") == 0 ) && ( AV19DynamicFiltersOperator2 == 1 ) && ( ! (DateTime.MinValue==AV20ParametroDtVigenciaIni2) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaIni] = @AV20ParametroDtVigenciaIni2)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaIni] = @AV20ParametroDtVigenciaIni2)";
            }
         }
         else
         {
            GXv_int2[6] = 1;
         }
         if ( AV17DynamicFiltersEnabled2 && ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PARAMETRODTVIGENCIAINI") == 0 ) && ( AV19DynamicFiltersOperator2 == 2 ) && ( ! (DateTime.MinValue==AV20ParametroDtVigenciaIni2) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaIni] > @AV20ParametroDtVigenciaIni2)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaIni] > @AV20ParametroDtVigenciaIni2)";
            }
         }
         else
         {
            GXv_int2[7] = 1;
         }
         if ( AV17DynamicFiltersEnabled2 && ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PARAMETRODTVIGENCIAINI") == 0 ) && ( AV19DynamicFiltersOperator2 == 3 ) && ( ! (DateTime.MinValue==AV20ParametroDtVigenciaIni2) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaIni] >= @AV20ParametroDtVigenciaIni2)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaIni] >= @AV20ParametroDtVigenciaIni2)";
            }
         }
         else
         {
            GXv_int2[8] = 1;
         }
         if ( AV17DynamicFiltersEnabled2 && ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PARAMETRODTVIGENCIAINI") == 0 ) && ( AV19DynamicFiltersOperator2 == 3 ) && ( ! (DateTime.MinValue==AV21ParametroDtVigenciaIni_To2) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaIni] <= @AV21ParametroDtVigenciaIni_To2)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaIni] <= @AV21ParametroDtVigenciaIni_To2)";
            }
         }
         else
         {
            GXv_int2[9] = 1;
         }
         if ( AV22DynamicFiltersEnabled3 && ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PARAMETRODTVIGENCIAINI") == 0 ) && ( AV24DynamicFiltersOperator3 == 0 ) && ( ! (DateTime.MinValue==AV25ParametroDtVigenciaIni3) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaIni] < @AV25ParametroDtVigenciaIni3)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaIni] < @AV25ParametroDtVigenciaIni3)";
            }
         }
         else
         {
            GXv_int2[10] = 1;
         }
         if ( AV22DynamicFiltersEnabled3 && ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PARAMETRODTVIGENCIAINI") == 0 ) && ( AV24DynamicFiltersOperator3 == 1 ) && ( ! (DateTime.MinValue==AV25ParametroDtVigenciaIni3) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaIni] = @AV25ParametroDtVigenciaIni3)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaIni] = @AV25ParametroDtVigenciaIni3)";
            }
         }
         else
         {
            GXv_int2[11] = 1;
         }
         if ( AV22DynamicFiltersEnabled3 && ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PARAMETRODTVIGENCIAINI") == 0 ) && ( AV24DynamicFiltersOperator3 == 2 ) && ( ! (DateTime.MinValue==AV25ParametroDtVigenciaIni3) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaIni] > @AV25ParametroDtVigenciaIni3)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaIni] > @AV25ParametroDtVigenciaIni3)";
            }
         }
         else
         {
            GXv_int2[12] = 1;
         }
         if ( AV22DynamicFiltersEnabled3 && ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PARAMETRODTVIGENCIAINI") == 0 ) && ( AV24DynamicFiltersOperator3 == 3 ) && ( ! (DateTime.MinValue==AV25ParametroDtVigenciaIni3) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaIni] >= @AV25ParametroDtVigenciaIni3)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaIni] >= @AV25ParametroDtVigenciaIni3)";
            }
         }
         else
         {
            GXv_int2[13] = 1;
         }
         if ( AV22DynamicFiltersEnabled3 && ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PARAMETRODTVIGENCIAINI") == 0 ) && ( AV24DynamicFiltersOperator3 == 3 ) && ( ! (DateTime.MinValue==AV26ParametroDtVigenciaIni_To3) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaIni] <= @AV26ParametroDtVigenciaIni_To3)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaIni] <= @AV26ParametroDtVigenciaIni_To3)";
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
            sOrderString = sOrderString + " ORDER BY [ParametroDtVigenciaIni]";
         }
         else if ( ( AV11OrderedBy == 1 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [ParametroDtVigenciaIni] DESC";
         }
         else if ( ( AV11OrderedBy == 2 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [ParametroID]";
         }
         else if ( ( AV11OrderedBy == 2 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [ParametroID] DESC";
         }
         else if ( ( AV11OrderedBy == 3 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [ParametroDtVigenciaFim]";
         }
         else if ( ( AV11OrderedBy == 3 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [ParametroDtVigenciaFim] DESC";
         }
         else if ( ( AV11OrderedBy == 4 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [ParametroTipo]";
         }
         else if ( ( AV11OrderedBy == 4 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [ParametroTipo] DESC";
         }
         else if ( ( AV11OrderedBy == 5 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [ParametroPrioritaria]";
         }
         else if ( ( AV11OrderedBy == 5 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [ParametroPrioritaria] DESC";
         }
         else if ( ( AV11OrderedBy == 6 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [ParametroValor]";
         }
         else if ( ( AV11OrderedBy == 6 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [ParametroValor] DESC";
         }
         else if ( ( AV11OrderedBy == 7 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [ParametroPercentual]";
         }
         else if ( ( AV11OrderedBy == 7 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [ParametroPercentual] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [ParametroID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      protected Object[] conditional_H000W3( IGxContext context ,
                                             String AV13DynamicFiltersSelector1 ,
                                             short AV14DynamicFiltersOperator1 ,
                                             DateTime AV15ParametroDtVigenciaIni1 ,
                                             DateTime AV16ParametroDtVigenciaIni_To1 ,
                                             bool AV17DynamicFiltersEnabled2 ,
                                             String AV18DynamicFiltersSelector2 ,
                                             short AV19DynamicFiltersOperator2 ,
                                             DateTime AV20ParametroDtVigenciaIni2 ,
                                             DateTime AV21ParametroDtVigenciaIni_To2 ,
                                             bool AV22DynamicFiltersEnabled3 ,
                                             String AV23DynamicFiltersSelector3 ,
                                             short AV24DynamicFiltersOperator3 ,
                                             DateTime AV25ParametroDtVigenciaIni3 ,
                                             DateTime AV26ParametroDtVigenciaIni_To3 ,
                                             DateTime A14ParametroDtVigenciaIni ,
                                             short AV11OrderedBy ,
                                             bool AV12OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [15] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [Parametro]";
         if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PARAMETRODTVIGENCIAINI") == 0 ) && ( AV14DynamicFiltersOperator1 == 0 ) && ( ! (DateTime.MinValue==AV15ParametroDtVigenciaIni1) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaIni] < @AV15ParametroDtVigenciaIni1)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaIni] < @AV15ParametroDtVigenciaIni1)";
            }
         }
         else
         {
            GXv_int4[0] = 1;
         }
         if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PARAMETRODTVIGENCIAINI") == 0 ) && ( AV14DynamicFiltersOperator1 == 1 ) && ( ! (DateTime.MinValue==AV15ParametroDtVigenciaIni1) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaIni] = @AV15ParametroDtVigenciaIni1)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaIni] = @AV15ParametroDtVigenciaIni1)";
            }
         }
         else
         {
            GXv_int4[1] = 1;
         }
         if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PARAMETRODTVIGENCIAINI") == 0 ) && ( AV14DynamicFiltersOperator1 == 2 ) && ( ! (DateTime.MinValue==AV15ParametroDtVigenciaIni1) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaIni] > @AV15ParametroDtVigenciaIni1)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaIni] > @AV15ParametroDtVigenciaIni1)";
            }
         }
         else
         {
            GXv_int4[2] = 1;
         }
         if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PARAMETRODTVIGENCIAINI") == 0 ) && ( AV14DynamicFiltersOperator1 == 3 ) && ( ! (DateTime.MinValue==AV15ParametroDtVigenciaIni1) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaIni] >= @AV15ParametroDtVigenciaIni1)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaIni] >= @AV15ParametroDtVigenciaIni1)";
            }
         }
         else
         {
            GXv_int4[3] = 1;
         }
         if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PARAMETRODTVIGENCIAINI") == 0 ) && ( AV14DynamicFiltersOperator1 == 3 ) && ( ! (DateTime.MinValue==AV16ParametroDtVigenciaIni_To1) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaIni] <= @AV16ParametroDtVigenciaIni_To1)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaIni] <= @AV16ParametroDtVigenciaIni_To1)";
            }
         }
         else
         {
            GXv_int4[4] = 1;
         }
         if ( AV17DynamicFiltersEnabled2 && ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PARAMETRODTVIGENCIAINI") == 0 ) && ( AV19DynamicFiltersOperator2 == 0 ) && ( ! (DateTime.MinValue==AV20ParametroDtVigenciaIni2) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaIni] < @AV20ParametroDtVigenciaIni2)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaIni] < @AV20ParametroDtVigenciaIni2)";
            }
         }
         else
         {
            GXv_int4[5] = 1;
         }
         if ( AV17DynamicFiltersEnabled2 && ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PARAMETRODTVIGENCIAINI") == 0 ) && ( AV19DynamicFiltersOperator2 == 1 ) && ( ! (DateTime.MinValue==AV20ParametroDtVigenciaIni2) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaIni] = @AV20ParametroDtVigenciaIni2)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaIni] = @AV20ParametroDtVigenciaIni2)";
            }
         }
         else
         {
            GXv_int4[6] = 1;
         }
         if ( AV17DynamicFiltersEnabled2 && ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PARAMETRODTVIGENCIAINI") == 0 ) && ( AV19DynamicFiltersOperator2 == 2 ) && ( ! (DateTime.MinValue==AV20ParametroDtVigenciaIni2) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaIni] > @AV20ParametroDtVigenciaIni2)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaIni] > @AV20ParametroDtVigenciaIni2)";
            }
         }
         else
         {
            GXv_int4[7] = 1;
         }
         if ( AV17DynamicFiltersEnabled2 && ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PARAMETRODTVIGENCIAINI") == 0 ) && ( AV19DynamicFiltersOperator2 == 3 ) && ( ! (DateTime.MinValue==AV20ParametroDtVigenciaIni2) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaIni] >= @AV20ParametroDtVigenciaIni2)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaIni] >= @AV20ParametroDtVigenciaIni2)";
            }
         }
         else
         {
            GXv_int4[8] = 1;
         }
         if ( AV17DynamicFiltersEnabled2 && ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PARAMETRODTVIGENCIAINI") == 0 ) && ( AV19DynamicFiltersOperator2 == 3 ) && ( ! (DateTime.MinValue==AV21ParametroDtVigenciaIni_To2) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaIni] <= @AV21ParametroDtVigenciaIni_To2)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaIni] <= @AV21ParametroDtVigenciaIni_To2)";
            }
         }
         else
         {
            GXv_int4[9] = 1;
         }
         if ( AV22DynamicFiltersEnabled3 && ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PARAMETRODTVIGENCIAINI") == 0 ) && ( AV24DynamicFiltersOperator3 == 0 ) && ( ! (DateTime.MinValue==AV25ParametroDtVigenciaIni3) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaIni] < @AV25ParametroDtVigenciaIni3)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaIni] < @AV25ParametroDtVigenciaIni3)";
            }
         }
         else
         {
            GXv_int4[10] = 1;
         }
         if ( AV22DynamicFiltersEnabled3 && ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PARAMETRODTVIGENCIAINI") == 0 ) && ( AV24DynamicFiltersOperator3 == 1 ) && ( ! (DateTime.MinValue==AV25ParametroDtVigenciaIni3) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaIni] = @AV25ParametroDtVigenciaIni3)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaIni] = @AV25ParametroDtVigenciaIni3)";
            }
         }
         else
         {
            GXv_int4[11] = 1;
         }
         if ( AV22DynamicFiltersEnabled3 && ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PARAMETRODTVIGENCIAINI") == 0 ) && ( AV24DynamicFiltersOperator3 == 2 ) && ( ! (DateTime.MinValue==AV25ParametroDtVigenciaIni3) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaIni] > @AV25ParametroDtVigenciaIni3)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaIni] > @AV25ParametroDtVigenciaIni3)";
            }
         }
         else
         {
            GXv_int4[12] = 1;
         }
         if ( AV22DynamicFiltersEnabled3 && ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PARAMETRODTVIGENCIAINI") == 0 ) && ( AV24DynamicFiltersOperator3 == 3 ) && ( ! (DateTime.MinValue==AV25ParametroDtVigenciaIni3) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaIni] >= @AV25ParametroDtVigenciaIni3)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaIni] >= @AV25ParametroDtVigenciaIni3)";
            }
         }
         else
         {
            GXv_int4[13] = 1;
         }
         if ( AV22DynamicFiltersEnabled3 && ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PARAMETRODTVIGENCIAINI") == 0 ) && ( AV24DynamicFiltersOperator3 == 3 ) && ( ! (DateTime.MinValue==AV26ParametroDtVigenciaIni_To3) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaIni] <= @AV26ParametroDtVigenciaIni_To3)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaIni] <= @AV26ParametroDtVigenciaIni_To3)";
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
         else if ( ( AV11OrderedBy == 7 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 7 ) && ( AV12OrderedDsc ) )
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
                     return conditional_H000W2(context, (String)dynConstraints[0] , (short)dynConstraints[1] , (DateTime)dynConstraints[2] , (DateTime)dynConstraints[3] , (bool)dynConstraints[4] , (String)dynConstraints[5] , (short)dynConstraints[6] , (DateTime)dynConstraints[7] , (DateTime)dynConstraints[8] , (bool)dynConstraints[9] , (String)dynConstraints[10] , (short)dynConstraints[11] , (DateTime)dynConstraints[12] , (DateTime)dynConstraints[13] , (DateTime)dynConstraints[14] , (short)dynConstraints[15] , (bool)dynConstraints[16] );
               case 1 :
                     return conditional_H000W3(context, (String)dynConstraints[0] , (short)dynConstraints[1] , (DateTime)dynConstraints[2] , (DateTime)dynConstraints[3] , (bool)dynConstraints[4] , (String)dynConstraints[5] , (short)dynConstraints[6] , (DateTime)dynConstraints[7] , (DateTime)dynConstraints[8] , (bool)dynConstraints[9] , (String)dynConstraints[10] , (short)dynConstraints[11] , (DateTime)dynConstraints[12] , (DateTime)dynConstraints[13] , (DateTime)dynConstraints[14] , (short)dynConstraints[15] , (bool)dynConstraints[16] );
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
          Object[] prmH000W2 ;
          prmH000W2 = new Object[] {
          new Object[] {"@AV15ParametroDtVigenciaIni1",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV15ParametroDtVigenciaIni1",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV15ParametroDtVigenciaIni1",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV15ParametroDtVigenciaIni1",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV16ParametroDtVigenciaIni_To1",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV20ParametroDtVigenciaIni2",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV20ParametroDtVigenciaIni2",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV20ParametroDtVigenciaIni2",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV20ParametroDtVigenciaIni2",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV21ParametroDtVigenciaIni_To2",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV25ParametroDtVigenciaIni3",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV25ParametroDtVigenciaIni3",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV25ParametroDtVigenciaIni3",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV25ParametroDtVigenciaIni3",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV26ParametroDtVigenciaIni_To3",SqlDbType.DateTime,8,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH000W3 ;
          prmH000W3 = new Object[] {
          new Object[] {"@AV15ParametroDtVigenciaIni1",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV15ParametroDtVigenciaIni1",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV15ParametroDtVigenciaIni1",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV15ParametroDtVigenciaIni1",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV16ParametroDtVigenciaIni_To1",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV20ParametroDtVigenciaIni2",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV20ParametroDtVigenciaIni2",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV20ParametroDtVigenciaIni2",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV20ParametroDtVigenciaIni2",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV21ParametroDtVigenciaIni_To2",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV25ParametroDtVigenciaIni3",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV25ParametroDtVigenciaIni3",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV25ParametroDtVigenciaIni3",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV25ParametroDtVigenciaIni3",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV26ParametroDtVigenciaIni_To3",SqlDbType.DateTime,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000W2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000W2,11, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("H000W3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000W3,1, GxCacheFrequency.OFF ,true,false )
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
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 1) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 1) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
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
