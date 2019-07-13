/*
               File: ParametroWW
        Description:  Parametro
             Author: GeneXus C# Generator version 16_0_2-131213
       Generated on: 7/11/2019 21:38:39.98
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
   public class parametroww : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public parametroww( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public parametroww( IGxContext context )
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
         cmbParametroTipo = new GXCombobox();
         cmbParametroPrioritaria = new GXCombobox();
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
               nRC_GXsfl_36 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_36_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_36_idx = GetNextPar( );
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
               AV13OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV14OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV63TFParametroDtVigenciaIni = context.localUtil.ParseDateParm( GetNextPar( ));
               AV64TFParametroDtVigenciaIni_To = context.localUtil.ParseDateParm( GetNextPar( ));
               AV69TFParametroDtVigenciaFim = context.localUtil.ParseDateParm( GetNextPar( ));
               AV70TFParametroDtVigenciaFim_To = context.localUtil.ParseDateParm( GetNextPar( ));
               AV83TFParametroValor = NumberUtil.Val( GetNextPar( ), ".");
               AV84TFParametroValor_To = NumberUtil.Val( GetNextPar( ), ".");
               AV87TFParametroPercentual = NumberUtil.Val( GetNextPar( ), ".");
               AV88TFParametroPercentual_To = NumberUtil.Val( GetNextPar( ), ".");
               AV52ManageFiltersExecutionStep = (short)(NumberUtil.Val( GetNextPar( ), "."));
               ajax_req_read_hidden_sdt(GetNextPar( ), AV44ColumnsSelector);
               AV67ddo_ParametroDtVigenciaIniTitleControlIdToReplace = GetNextPar( );
               AV73ddo_ParametroDtVigenciaFimTitleControlIdToReplace = GetNextPar( );
               AV77ddo_ParametroTipoTitleControlIdToReplace = GetNextPar( );
               AV81ddo_ParametroPrioritariaTitleControlIdToReplace = GetNextPar( );
               AV85ddo_ParametroValorTitleControlIdToReplace = GetNextPar( );
               AV89ddo_ParametroPercentualTitleControlIdToReplace = GetNextPar( );
               ajax_req_read_hidden_sdt(GetNextPar( ), AV76TFParametroTipo_Sels);
               ajax_req_read_hidden_sdt(GetNextPar( ), AV80TFParametroPrioritaria_Sels);
               AV108Pgmname = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV63TFParametroDtVigenciaIni, AV64TFParametroDtVigenciaIni_To, AV69TFParametroDtVigenciaFim, AV70TFParametroDtVigenciaFim_To, AV83TFParametroValor, AV84TFParametroValor_To, AV87TFParametroPercentual, AV88TFParametroPercentual_To, AV52ManageFiltersExecutionStep, AV44ColumnsSelector, AV67ddo_ParametroDtVigenciaIniTitleControlIdToReplace, AV73ddo_ParametroDtVigenciaFimTitleControlIdToReplace, AV77ddo_ParametroTipoTitleControlIdToReplace, AV81ddo_ParametroPrioritariaTitleControlIdToReplace, AV85ddo_ParametroValorTitleControlIdToReplace, AV89ddo_ParametroPercentualTitleControlIdToReplace, AV76TFParametroTipo_Sels, AV80TFParametroPrioritaria_Sels, AV108Pgmname) ;
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
         PA0V2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0V2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?201971121384027", false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("parametroww.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV14OrderedDsc));
         GxWebStd.gx_hidden_field( context, "GXH_vTFPARAMETRODTVIGENCIAINI", context.localUtil.Format(AV63TFParametroDtVigenciaIni, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vTFPARAMETRODTVIGENCIAINI_TO", context.localUtil.Format(AV64TFParametroDtVigenciaIni_To, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vTFPARAMETRODTVIGENCIAFIM", context.localUtil.Format(AV69TFParametroDtVigenciaFim, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vTFPARAMETRODTVIGENCIAFIM_TO", context.localUtil.Format(AV70TFParametroDtVigenciaFim_To, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vTFPARAMETROVALOR", StringUtil.LTrim( StringUtil.NToC( AV83TFParametroValor, 12, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFPARAMETROVALOR_TO", StringUtil.LTrim( StringUtil.NToC( AV84TFParametroValor_To, 12, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFPARAMETROPERCENTUAL", StringUtil.LTrim( StringUtil.NToC( AV87TFParametroPercentual, 6, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFPARAMETROPERCENTUAL_TO", StringUtil.LTrim( StringUtil.NToC( AV88TFParametroPercentual_To, 6, 2, ",", "")));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_36", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_36), 4, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vMANAGEFILTERSDATA", AV56ManageFiltersData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vMANAGEFILTERSDATA", AV56ManageFiltersData);
         }
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV92GridCurrentPage), 10, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGECOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV93GridPageCount), 10, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV90DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV90DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPARAMETRODTVIGENCIAINITITLEFILTERDATA", AV62ParametroDtVigenciaIniTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPARAMETRODTVIGENCIAINITITLEFILTERDATA", AV62ParametroDtVigenciaIniTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPARAMETRODTVIGENCIAFIMTITLEFILTERDATA", AV68ParametroDtVigenciaFimTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPARAMETRODTVIGENCIAFIMTITLEFILTERDATA", AV68ParametroDtVigenciaFimTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPARAMETROTIPOTITLEFILTERDATA", AV74ParametroTipoTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPARAMETROTIPOTITLEFILTERDATA", AV74ParametroTipoTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPARAMETROPRIORITARIATITLEFILTERDATA", AV78ParametroPrioritariaTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPARAMETROPRIORITARIATITLEFILTERDATA", AV78ParametroPrioritariaTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPARAMETROVALORTITLEFILTERDATA", AV82ParametroValorTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPARAMETROVALORTITLEFILTERDATA", AV82ParametroValorTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPARAMETROPERCENTUALTITLEFILTERDATA", AV86ParametroPercentualTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPARAMETROPERCENTUALTITLEFILTERDATA", AV86ParametroPercentualTitleFilterData);
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTFPARAMETROTIPO_SELS", AV76TFParametroTipo_Sels);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTFPARAMETROTIPO_SELS", AV76TFParametroTipo_Sels);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTFPARAMETROPRIORITARIA_SELS", AV80TFParametroPrioritaria_Sels);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTFPARAMETROPRIORITARIA_SELS", AV80TFParametroPrioritaria_Sels);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV108Pgmname));
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
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Caption", StringUtil.RTrim( Ddo_parametrodtvigenciaini_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Tooltip", StringUtil.RTrim( Ddo_parametrodtvigenciaini_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Cls", StringUtil.RTrim( Ddo_parametrodtvigenciaini_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Filteredtext_set", StringUtil.RTrim( Ddo_parametrodtvigenciaini_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Filteredtextto_set", StringUtil.RTrim( Ddo_parametrodtvigenciaini_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Dropdownoptionstype", StringUtil.RTrim( Ddo_parametrodtvigenciaini_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_parametrodtvigenciaini_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Includesortasc", StringUtil.BoolToStr( Ddo_parametrodtvigenciaini_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Includesortdsc", StringUtil.BoolToStr( Ddo_parametrodtvigenciaini_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Sortedstatus", StringUtil.RTrim( Ddo_parametrodtvigenciaini_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Includefilter", StringUtil.BoolToStr( Ddo_parametrodtvigenciaini_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Filtertype", StringUtil.RTrim( Ddo_parametrodtvigenciaini_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Filterisrange", StringUtil.BoolToStr( Ddo_parametrodtvigenciaini_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Includedatalist", StringUtil.BoolToStr( Ddo_parametrodtvigenciaini_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Sortasc", StringUtil.RTrim( Ddo_parametrodtvigenciaini_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Sortdsc", StringUtil.RTrim( Ddo_parametrodtvigenciaini_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Cleanfilter", StringUtil.RTrim( Ddo_parametrodtvigenciaini_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Rangefilterfrom", StringUtil.RTrim( Ddo_parametrodtvigenciaini_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Rangefilterto", StringUtil.RTrim( Ddo_parametrodtvigenciaini_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Searchbuttontext", StringUtil.RTrim( Ddo_parametrodtvigenciaini_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Caption", StringUtil.RTrim( Ddo_parametrodtvigenciafim_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Tooltip", StringUtil.RTrim( Ddo_parametrodtvigenciafim_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Cls", StringUtil.RTrim( Ddo_parametrodtvigenciafim_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Filteredtext_set", StringUtil.RTrim( Ddo_parametrodtvigenciafim_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Filteredtextto_set", StringUtil.RTrim( Ddo_parametrodtvigenciafim_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Dropdownoptionstype", StringUtil.RTrim( Ddo_parametrodtvigenciafim_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_parametrodtvigenciafim_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Includesortasc", StringUtil.BoolToStr( Ddo_parametrodtvigenciafim_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Includesortdsc", StringUtil.BoolToStr( Ddo_parametrodtvigenciafim_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Sortedstatus", StringUtil.RTrim( Ddo_parametrodtvigenciafim_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Includefilter", StringUtil.BoolToStr( Ddo_parametrodtvigenciafim_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Filtertype", StringUtil.RTrim( Ddo_parametrodtvigenciafim_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Filterisrange", StringUtil.BoolToStr( Ddo_parametrodtvigenciafim_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Includedatalist", StringUtil.BoolToStr( Ddo_parametrodtvigenciafim_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Sortasc", StringUtil.RTrim( Ddo_parametrodtvigenciafim_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Sortdsc", StringUtil.RTrim( Ddo_parametrodtvigenciafim_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Cleanfilter", StringUtil.RTrim( Ddo_parametrodtvigenciafim_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Rangefilterfrom", StringUtil.RTrim( Ddo_parametrodtvigenciafim_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Rangefilterto", StringUtil.RTrim( Ddo_parametrodtvigenciafim_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Searchbuttontext", StringUtil.RTrim( Ddo_parametrodtvigenciafim_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Caption", StringUtil.RTrim( Ddo_parametrotipo_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Tooltip", StringUtil.RTrim( Ddo_parametrotipo_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Cls", StringUtil.RTrim( Ddo_parametrotipo_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Selectedvalue_set", StringUtil.RTrim( Ddo_parametrotipo_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Dropdownoptionstype", StringUtil.RTrim( Ddo_parametrotipo_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_parametrotipo_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Includesortasc", StringUtil.BoolToStr( Ddo_parametrotipo_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Includesortdsc", StringUtil.BoolToStr( Ddo_parametrotipo_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Sortedstatus", StringUtil.RTrim( Ddo_parametrotipo_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Includefilter", StringUtil.BoolToStr( Ddo_parametrotipo_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Includedatalist", StringUtil.BoolToStr( Ddo_parametrotipo_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Datalisttype", StringUtil.RTrim( Ddo_parametrotipo_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Allowmultipleselection", StringUtil.BoolToStr( Ddo_parametrotipo_Allowmultipleselection));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Datalistfixedvalues", StringUtil.RTrim( Ddo_parametrotipo_Datalistfixedvalues));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Sortasc", StringUtil.RTrim( Ddo_parametrotipo_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Sortdsc", StringUtil.RTrim( Ddo_parametrotipo_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Cleanfilter", StringUtil.RTrim( Ddo_parametrotipo_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Searchbuttontext", StringUtil.RTrim( Ddo_parametrotipo_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Caption", StringUtil.RTrim( Ddo_parametroprioritaria_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Tooltip", StringUtil.RTrim( Ddo_parametroprioritaria_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Cls", StringUtil.RTrim( Ddo_parametroprioritaria_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Selectedvalue_set", StringUtil.RTrim( Ddo_parametroprioritaria_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Dropdownoptionstype", StringUtil.RTrim( Ddo_parametroprioritaria_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_parametroprioritaria_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Includesortasc", StringUtil.BoolToStr( Ddo_parametroprioritaria_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Includesortdsc", StringUtil.BoolToStr( Ddo_parametroprioritaria_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Sortedstatus", StringUtil.RTrim( Ddo_parametroprioritaria_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Includefilter", StringUtil.BoolToStr( Ddo_parametroprioritaria_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Includedatalist", StringUtil.BoolToStr( Ddo_parametroprioritaria_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Datalisttype", StringUtil.RTrim( Ddo_parametroprioritaria_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Allowmultipleselection", StringUtil.BoolToStr( Ddo_parametroprioritaria_Allowmultipleselection));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Datalistfixedvalues", StringUtil.RTrim( Ddo_parametroprioritaria_Datalistfixedvalues));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Sortasc", StringUtil.RTrim( Ddo_parametroprioritaria_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Sortdsc", StringUtil.RTrim( Ddo_parametroprioritaria_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Cleanfilter", StringUtil.RTrim( Ddo_parametroprioritaria_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Searchbuttontext", StringUtil.RTrim( Ddo_parametroprioritaria_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Caption", StringUtil.RTrim( Ddo_parametrovalor_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Tooltip", StringUtil.RTrim( Ddo_parametrovalor_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Cls", StringUtil.RTrim( Ddo_parametrovalor_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Filteredtext_set", StringUtil.RTrim( Ddo_parametrovalor_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Filteredtextto_set", StringUtil.RTrim( Ddo_parametrovalor_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Dropdownoptionstype", StringUtil.RTrim( Ddo_parametrovalor_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_parametrovalor_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Includesortasc", StringUtil.BoolToStr( Ddo_parametrovalor_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Includesortdsc", StringUtil.BoolToStr( Ddo_parametrovalor_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Sortedstatus", StringUtil.RTrim( Ddo_parametrovalor_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Includefilter", StringUtil.BoolToStr( Ddo_parametrovalor_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Filtertype", StringUtil.RTrim( Ddo_parametrovalor_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Filterisrange", StringUtil.BoolToStr( Ddo_parametrovalor_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Includedatalist", StringUtil.BoolToStr( Ddo_parametrovalor_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Sortasc", StringUtil.RTrim( Ddo_parametrovalor_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Sortdsc", StringUtil.RTrim( Ddo_parametrovalor_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Cleanfilter", StringUtil.RTrim( Ddo_parametrovalor_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Rangefilterfrom", StringUtil.RTrim( Ddo_parametrovalor_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Rangefilterto", StringUtil.RTrim( Ddo_parametrovalor_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Searchbuttontext", StringUtil.RTrim( Ddo_parametrovalor_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Caption", StringUtil.RTrim( Ddo_parametropercentual_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Tooltip", StringUtil.RTrim( Ddo_parametropercentual_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Cls", StringUtil.RTrim( Ddo_parametropercentual_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Filteredtext_set", StringUtil.RTrim( Ddo_parametropercentual_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Filteredtextto_set", StringUtil.RTrim( Ddo_parametropercentual_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Dropdownoptionstype", StringUtil.RTrim( Ddo_parametropercentual_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_parametropercentual_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Includesortasc", StringUtil.BoolToStr( Ddo_parametropercentual_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Includesortdsc", StringUtil.BoolToStr( Ddo_parametropercentual_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Sortedstatus", StringUtil.RTrim( Ddo_parametropercentual_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Includefilter", StringUtil.BoolToStr( Ddo_parametropercentual_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Filtertype", StringUtil.RTrim( Ddo_parametropercentual_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Filterisrange", StringUtil.BoolToStr( Ddo_parametropercentual_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Includedatalist", StringUtil.BoolToStr( Ddo_parametropercentual_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Sortasc", StringUtil.RTrim( Ddo_parametropercentual_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Sortdsc", StringUtil.RTrim( Ddo_parametropercentual_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Cleanfilter", StringUtil.RTrim( Ddo_parametropercentual_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Rangefilterfrom", StringUtil.RTrim( Ddo_parametropercentual_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Rangefilterto", StringUtil.RTrim( Ddo_parametropercentual_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Searchbuttontext", StringUtil.RTrim( Ddo_parametropercentual_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Caption", StringUtil.RTrim( Ddo_gridcolumnsselector_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Tooltip", StringUtil.RTrim( Ddo_gridcolumnsselector_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Cls", StringUtil.RTrim( Ddo_gridcolumnsselector_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Dropdownoptionstype", StringUtil.RTrim( Ddo_gridcolumnsselector_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_gridcolumnsselector_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Updatebuttontext", StringUtil.RTrim( Ddo_gridcolumnsselector_Updatebuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Activeeventkey", StringUtil.RTrim( Ddo_parametrodtvigenciaini_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Filteredtext_get", StringUtil.RTrim( Ddo_parametrodtvigenciaini_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Filteredtextto_get", StringUtil.RTrim( Ddo_parametrodtvigenciaini_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Activeeventkey", StringUtil.RTrim( Ddo_parametrodtvigenciafim_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Filteredtext_get", StringUtil.RTrim( Ddo_parametrodtvigenciafim_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Filteredtextto_get", StringUtil.RTrim( Ddo_parametrodtvigenciafim_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Activeeventkey", StringUtil.RTrim( Ddo_parametrotipo_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Selectedvalue_get", StringUtil.RTrim( Ddo_parametrotipo_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Activeeventkey", StringUtil.RTrim( Ddo_parametroprioritaria_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Selectedvalue_get", StringUtil.RTrim( Ddo_parametroprioritaria_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Activeeventkey", StringUtil.RTrim( Ddo_parametrovalor_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Filteredtext_get", StringUtil.RTrim( Ddo_parametrovalor_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Filteredtextto_get", StringUtil.RTrim( Ddo_parametrovalor_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Activeeventkey", StringUtil.RTrim( Ddo_parametropercentual_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Filteredtext_get", StringUtil.RTrim( Ddo_parametropercentual_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Filteredtextto_get", StringUtil.RTrim( Ddo_parametropercentual_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Columnsselectorvalues", StringUtil.RTrim( Ddo_gridcolumnsselector_Columnsselectorvalues));
         GxWebStd.gx_hidden_field( context, "DDO_MANAGEFILTERS_Activeeventkey", StringUtil.RTrim( Ddo_managefilters_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Activeeventkey", StringUtil.RTrim( Ddo_parametrodtvigenciaini_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Filteredtext_get", StringUtil.RTrim( Ddo_parametrodtvigenciaini_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAINI_Filteredtextto_get", StringUtil.RTrim( Ddo_parametrodtvigenciaini_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Activeeventkey", StringUtil.RTrim( Ddo_parametrodtvigenciafim_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Filteredtext_get", StringUtil.RTrim( Ddo_parametrodtvigenciafim_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETRODTVIGENCIAFIM_Filteredtextto_get", StringUtil.RTrim( Ddo_parametrodtvigenciafim_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Activeeventkey", StringUtil.RTrim( Ddo_parametrotipo_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROTIPO_Selectedvalue_get", StringUtil.RTrim( Ddo_parametrotipo_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Activeeventkey", StringUtil.RTrim( Ddo_parametroprioritaria_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPRIORITARIA_Selectedvalue_get", StringUtil.RTrim( Ddo_parametroprioritaria_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Activeeventkey", StringUtil.RTrim( Ddo_parametrovalor_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Filteredtext_get", StringUtil.RTrim( Ddo_parametrovalor_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROVALOR_Filteredtextto_get", StringUtil.RTrim( Ddo_parametrovalor_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Activeeventkey", StringUtil.RTrim( Ddo_parametropercentual_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Filteredtext_get", StringUtil.RTrim( Ddo_parametropercentual_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_PARAMETROPERCENTUAL_Filteredtextto_get", StringUtil.RTrim( Ddo_parametropercentual_Filteredtextto_get));
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
            WE0V2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0V2( ) ;
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
         return formatLink("parametroww.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "ParametroWW" ;
      }

      public override String GetPgmdesc( )
      {
         return " Parametro" ;
      }

      protected void WB0V0( )
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
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(36), 2, 0)+","+"null"+");", "Inserir", bttBtninsert_Jsonclick, 5, "Inserir", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_ParametroWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"";
            ClassString = "hidden-xs";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtneditcolumns_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(36), 2, 0)+","+"null"+");", "Seleciona colunas", bttBtneditcolumns_Jsonclick, 0, "Seleciona colunas", "", StyleString, ClassString, 1, 0, "standard", "'"+""+"'"+",false,"+"'"+""+"'", TempTags, "", context.GetButtonType( ), "HLP_ParametroWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-xs col-sm-6 CellFloatRight CellWidthAuto", "left", "top", "", "", "div");
            wb_table1_23_0V2( true) ;
         }
         else
         {
            wb_table1_23_0V2( false) ;
         }
         return  ;
      }

      protected void wb_table1_23_0V2e( bool wbgen )
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
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"36\">") ;
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+((edtParametroDtVigenciaIni_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               if ( edtParametroDtVigenciaIni_Titleformat == 0 )
               {
                  context.SendWebValue( edtParametroDtVigenciaIni_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtParametroDtVigenciaIni_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+((edtParametroDtVigenciaFim_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               if ( edtParametroDtVigenciaFim_Titleformat == 0 )
               {
                  context.SendWebValue( edtParametroDtVigenciaFim_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtParametroDtVigenciaFim_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+((cmbParametroTipo.Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               if ( cmbParametroTipo_Titleformat == 0 )
               {
                  context.SendWebValue( cmbParametroTipo.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( cmbParametroTipo.Title.Text) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+((cmbParametroPrioritaria.Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               if ( cmbParametroPrioritaria_Titleformat == 0 )
               {
                  context.SendWebValue( cmbParametroPrioritaria.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( cmbParametroPrioritaria.Title.Text) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+((edtParametroValor_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               if ( edtParametroValor_Titleformat == 0 )
               {
                  context.SendWebValue( edtParametroValor_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtParametroValor_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+((edtParametroPercentual_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
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
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( AV94Update));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUpdate_Enabled), 5, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( AV95Delete));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDelete_Enabled), 5, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A13ParametroID), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A14ParametroDtVigenciaIni, "99/99/99"));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtParametroDtVigenciaIni_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtParametroDtVigenciaIni_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtParametroDtVigenciaIni_Link));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtParametroDtVigenciaIni_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A15ParametroDtVigenciaFim, "99/99/99"));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtParametroDtVigenciaFim_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtParametroDtVigenciaFim_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtParametroDtVigenciaFim_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A16ParametroTipo));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( cmbParametroTipo.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbParametroTipo_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbParametroTipo.Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A17ParametroPrioritaria));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( cmbParametroPrioritaria.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbParametroPrioritaria_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbParametroPrioritaria.Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A18ParametroValor, 14, 2, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtParametroValor_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtParametroValor_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtParametroValor_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A19ParametroPercentual, 6, 2, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtParametroPercentual_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtParametroPercentual_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtParametroPercentual_Visible), 5, 0, ".", "")));
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
         if ( wbEnd == 36 )
         {
            wbEnd = 0;
            nRC_GXsfl_36 = (short)(nGXsfl_36_idx-1);
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV92GridCurrentPage);
            ucGridpaginationbar.SetProperty("PageCount", AV93GridPageCount);
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
            ucDdo_parametrodtvigenciaini.SetProperty("Caption", Ddo_parametrodtvigenciaini_Caption);
            ucDdo_parametrodtvigenciaini.SetProperty("Tooltip", Ddo_parametrodtvigenciaini_Tooltip);
            ucDdo_parametrodtvigenciaini.SetProperty("Cls", Ddo_parametrodtvigenciaini_Cls);
            ucDdo_parametrodtvigenciaini.SetProperty("DropDownOptionsType", Ddo_parametrodtvigenciaini_Dropdownoptionstype);
            ucDdo_parametrodtvigenciaini.SetProperty("IncludeSortASC", Ddo_parametrodtvigenciaini_Includesortasc);
            ucDdo_parametrodtvigenciaini.SetProperty("IncludeSortDSC", Ddo_parametrodtvigenciaini_Includesortdsc);
            ucDdo_parametrodtvigenciaini.SetProperty("IncludeFilter", Ddo_parametrodtvigenciaini_Includefilter);
            ucDdo_parametrodtvigenciaini.SetProperty("FilterType", Ddo_parametrodtvigenciaini_Filtertype);
            ucDdo_parametrodtvigenciaini.SetProperty("FilterIsRange", Ddo_parametrodtvigenciaini_Filterisrange);
            ucDdo_parametrodtvigenciaini.SetProperty("IncludeDataList", Ddo_parametrodtvigenciaini_Includedatalist);
            ucDdo_parametrodtvigenciaini.SetProperty("SortASC", Ddo_parametrodtvigenciaini_Sortasc);
            ucDdo_parametrodtvigenciaini.SetProperty("SortDSC", Ddo_parametrodtvigenciaini_Sortdsc);
            ucDdo_parametrodtvigenciaini.SetProperty("CleanFilter", Ddo_parametrodtvigenciaini_Cleanfilter);
            ucDdo_parametrodtvigenciaini.SetProperty("RangeFilterFrom", Ddo_parametrodtvigenciaini_Rangefilterfrom);
            ucDdo_parametrodtvigenciaini.SetProperty("RangeFilterTo", Ddo_parametrodtvigenciaini_Rangefilterto);
            ucDdo_parametrodtvigenciaini.SetProperty("SearchButtonText", Ddo_parametrodtvigenciaini_Searchbuttontext);
            ucDdo_parametrodtvigenciaini.SetProperty("DropDownOptionsTitleSettingsIcons", AV90DDO_TitleSettingsIcons);
            ucDdo_parametrodtvigenciaini.SetProperty("DropDownOptionsData", AV62ParametroDtVigenciaIniTitleFilterData);
            ucDdo_parametrodtvigenciaini.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_parametrodtvigenciaini_Internalname, "DDO_PARAMETRODTVIGENCIAINIContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'" + sGXsfl_36_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_parametrodtvigenciainititlecontrolidtoreplace_Internalname, AV67ddo_ParametroDtVigenciaIniTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", 0, edtavDdo_parametrodtvigenciainititlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_ParametroWW.htm");
            /* User Defined Control */
            ucDdo_parametrodtvigenciafim.SetProperty("Caption", Ddo_parametrodtvigenciafim_Caption);
            ucDdo_parametrodtvigenciafim.SetProperty("Tooltip", Ddo_parametrodtvigenciafim_Tooltip);
            ucDdo_parametrodtvigenciafim.SetProperty("Cls", Ddo_parametrodtvigenciafim_Cls);
            ucDdo_parametrodtvigenciafim.SetProperty("DropDownOptionsType", Ddo_parametrodtvigenciafim_Dropdownoptionstype);
            ucDdo_parametrodtvigenciafim.SetProperty("IncludeSortASC", Ddo_parametrodtvigenciafim_Includesortasc);
            ucDdo_parametrodtvigenciafim.SetProperty("IncludeSortDSC", Ddo_parametrodtvigenciafim_Includesortdsc);
            ucDdo_parametrodtvigenciafim.SetProperty("IncludeFilter", Ddo_parametrodtvigenciafim_Includefilter);
            ucDdo_parametrodtvigenciafim.SetProperty("FilterType", Ddo_parametrodtvigenciafim_Filtertype);
            ucDdo_parametrodtvigenciafim.SetProperty("FilterIsRange", Ddo_parametrodtvigenciafim_Filterisrange);
            ucDdo_parametrodtvigenciafim.SetProperty("IncludeDataList", Ddo_parametrodtvigenciafim_Includedatalist);
            ucDdo_parametrodtvigenciafim.SetProperty("SortASC", Ddo_parametrodtvigenciafim_Sortasc);
            ucDdo_parametrodtvigenciafim.SetProperty("SortDSC", Ddo_parametrodtvigenciafim_Sortdsc);
            ucDdo_parametrodtvigenciafim.SetProperty("CleanFilter", Ddo_parametrodtvigenciafim_Cleanfilter);
            ucDdo_parametrodtvigenciafim.SetProperty("RangeFilterFrom", Ddo_parametrodtvigenciafim_Rangefilterfrom);
            ucDdo_parametrodtvigenciafim.SetProperty("RangeFilterTo", Ddo_parametrodtvigenciafim_Rangefilterto);
            ucDdo_parametrodtvigenciafim.SetProperty("SearchButtonText", Ddo_parametrodtvigenciafim_Searchbuttontext);
            ucDdo_parametrodtvigenciafim.SetProperty("DropDownOptionsTitleSettingsIcons", AV90DDO_TitleSettingsIcons);
            ucDdo_parametrodtvigenciafim.SetProperty("DropDownOptionsData", AV68ParametroDtVigenciaFimTitleFilterData);
            ucDdo_parametrodtvigenciafim.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_parametrodtvigenciafim_Internalname, "DDO_PARAMETRODTVIGENCIAFIMContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'" + sGXsfl_36_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_parametrodtvigenciafimtitlecontrolidtoreplace_Internalname, AV73ddo_ParametroDtVigenciaFimTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", 0, edtavDdo_parametrodtvigenciafimtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_ParametroWW.htm");
            /* User Defined Control */
            ucDdo_parametrotipo.SetProperty("Caption", Ddo_parametrotipo_Caption);
            ucDdo_parametrotipo.SetProperty("Tooltip", Ddo_parametrotipo_Tooltip);
            ucDdo_parametrotipo.SetProperty("Cls", Ddo_parametrotipo_Cls);
            ucDdo_parametrotipo.SetProperty("DropDownOptionsType", Ddo_parametrotipo_Dropdownoptionstype);
            ucDdo_parametrotipo.SetProperty("IncludeSortASC", Ddo_parametrotipo_Includesortasc);
            ucDdo_parametrotipo.SetProperty("IncludeSortDSC", Ddo_parametrotipo_Includesortdsc);
            ucDdo_parametrotipo.SetProperty("IncludeFilter", Ddo_parametrotipo_Includefilter);
            ucDdo_parametrotipo.SetProperty("IncludeDataList", Ddo_parametrotipo_Includedatalist);
            ucDdo_parametrotipo.SetProperty("DataListType", Ddo_parametrotipo_Datalisttype);
            ucDdo_parametrotipo.SetProperty("AllowMultipleSelection", Ddo_parametrotipo_Allowmultipleselection);
            ucDdo_parametrotipo.SetProperty("DataListFixedValues", Ddo_parametrotipo_Datalistfixedvalues);
            ucDdo_parametrotipo.SetProperty("SortASC", Ddo_parametrotipo_Sortasc);
            ucDdo_parametrotipo.SetProperty("SortDSC", Ddo_parametrotipo_Sortdsc);
            ucDdo_parametrotipo.SetProperty("CleanFilter", Ddo_parametrotipo_Cleanfilter);
            ucDdo_parametrotipo.SetProperty("SearchButtonText", Ddo_parametrotipo_Searchbuttontext);
            ucDdo_parametrotipo.SetProperty("DropDownOptionsTitleSettingsIcons", AV90DDO_TitleSettingsIcons);
            ucDdo_parametrotipo.SetProperty("DropDownOptionsData", AV74ParametroTipoTitleFilterData);
            ucDdo_parametrotipo.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_parametrotipo_Internalname, "DDO_PARAMETROTIPOContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'" + sGXsfl_36_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_parametrotipotitlecontrolidtoreplace_Internalname, AV77ddo_ParametroTipoTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,57);\"", 0, edtavDdo_parametrotipotitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_ParametroWW.htm");
            /* User Defined Control */
            ucDdo_parametroprioritaria.SetProperty("Caption", Ddo_parametroprioritaria_Caption);
            ucDdo_parametroprioritaria.SetProperty("Tooltip", Ddo_parametroprioritaria_Tooltip);
            ucDdo_parametroprioritaria.SetProperty("Cls", Ddo_parametroprioritaria_Cls);
            ucDdo_parametroprioritaria.SetProperty("DropDownOptionsType", Ddo_parametroprioritaria_Dropdownoptionstype);
            ucDdo_parametroprioritaria.SetProperty("IncludeSortASC", Ddo_parametroprioritaria_Includesortasc);
            ucDdo_parametroprioritaria.SetProperty("IncludeSortDSC", Ddo_parametroprioritaria_Includesortdsc);
            ucDdo_parametroprioritaria.SetProperty("IncludeFilter", Ddo_parametroprioritaria_Includefilter);
            ucDdo_parametroprioritaria.SetProperty("IncludeDataList", Ddo_parametroprioritaria_Includedatalist);
            ucDdo_parametroprioritaria.SetProperty("DataListType", Ddo_parametroprioritaria_Datalisttype);
            ucDdo_parametroprioritaria.SetProperty("AllowMultipleSelection", Ddo_parametroprioritaria_Allowmultipleselection);
            ucDdo_parametroprioritaria.SetProperty("DataListFixedValues", Ddo_parametroprioritaria_Datalistfixedvalues);
            ucDdo_parametroprioritaria.SetProperty("SortASC", Ddo_parametroprioritaria_Sortasc);
            ucDdo_parametroprioritaria.SetProperty("SortDSC", Ddo_parametroprioritaria_Sortdsc);
            ucDdo_parametroprioritaria.SetProperty("CleanFilter", Ddo_parametroprioritaria_Cleanfilter);
            ucDdo_parametroprioritaria.SetProperty("SearchButtonText", Ddo_parametroprioritaria_Searchbuttontext);
            ucDdo_parametroprioritaria.SetProperty("DropDownOptionsTitleSettingsIcons", AV90DDO_TitleSettingsIcons);
            ucDdo_parametroprioritaria.SetProperty("DropDownOptionsData", AV78ParametroPrioritariaTitleFilterData);
            ucDdo_parametroprioritaria.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_parametroprioritaria_Internalname, "DDO_PARAMETROPRIORITARIAContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'" + sGXsfl_36_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_parametroprioritariatitlecontrolidtoreplace_Internalname, AV81ddo_ParametroPrioritariaTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", 0, edtavDdo_parametroprioritariatitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_ParametroWW.htm");
            /* User Defined Control */
            ucDdo_parametrovalor.SetProperty("Caption", Ddo_parametrovalor_Caption);
            ucDdo_parametrovalor.SetProperty("Tooltip", Ddo_parametrovalor_Tooltip);
            ucDdo_parametrovalor.SetProperty("Cls", Ddo_parametrovalor_Cls);
            ucDdo_parametrovalor.SetProperty("DropDownOptionsType", Ddo_parametrovalor_Dropdownoptionstype);
            ucDdo_parametrovalor.SetProperty("IncludeSortASC", Ddo_parametrovalor_Includesortasc);
            ucDdo_parametrovalor.SetProperty("IncludeSortDSC", Ddo_parametrovalor_Includesortdsc);
            ucDdo_parametrovalor.SetProperty("IncludeFilter", Ddo_parametrovalor_Includefilter);
            ucDdo_parametrovalor.SetProperty("FilterType", Ddo_parametrovalor_Filtertype);
            ucDdo_parametrovalor.SetProperty("FilterIsRange", Ddo_parametrovalor_Filterisrange);
            ucDdo_parametrovalor.SetProperty("IncludeDataList", Ddo_parametrovalor_Includedatalist);
            ucDdo_parametrovalor.SetProperty("SortASC", Ddo_parametrovalor_Sortasc);
            ucDdo_parametrovalor.SetProperty("SortDSC", Ddo_parametrovalor_Sortdsc);
            ucDdo_parametrovalor.SetProperty("CleanFilter", Ddo_parametrovalor_Cleanfilter);
            ucDdo_parametrovalor.SetProperty("RangeFilterFrom", Ddo_parametrovalor_Rangefilterfrom);
            ucDdo_parametrovalor.SetProperty("RangeFilterTo", Ddo_parametrovalor_Rangefilterto);
            ucDdo_parametrovalor.SetProperty("SearchButtonText", Ddo_parametrovalor_Searchbuttontext);
            ucDdo_parametrovalor.SetProperty("DropDownOptionsTitleSettingsIcons", AV90DDO_TitleSettingsIcons);
            ucDdo_parametrovalor.SetProperty("DropDownOptionsData", AV82ParametroValorTitleFilterData);
            ucDdo_parametrovalor.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_parametrovalor_Internalname, "DDO_PARAMETROVALORContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'" + sGXsfl_36_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_parametrovalortitlecontrolidtoreplace_Internalname, AV85ddo_ParametroValorTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,61);\"", 0, edtavDdo_parametrovalortitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_ParametroWW.htm");
            /* User Defined Control */
            ucDdo_parametropercentual.SetProperty("Caption", Ddo_parametropercentual_Caption);
            ucDdo_parametropercentual.SetProperty("Tooltip", Ddo_parametropercentual_Tooltip);
            ucDdo_parametropercentual.SetProperty("Cls", Ddo_parametropercentual_Cls);
            ucDdo_parametropercentual.SetProperty("DropDownOptionsType", Ddo_parametropercentual_Dropdownoptionstype);
            ucDdo_parametropercentual.SetProperty("IncludeSortASC", Ddo_parametropercentual_Includesortasc);
            ucDdo_parametropercentual.SetProperty("IncludeSortDSC", Ddo_parametropercentual_Includesortdsc);
            ucDdo_parametropercentual.SetProperty("IncludeFilter", Ddo_parametropercentual_Includefilter);
            ucDdo_parametropercentual.SetProperty("FilterType", Ddo_parametropercentual_Filtertype);
            ucDdo_parametropercentual.SetProperty("FilterIsRange", Ddo_parametropercentual_Filterisrange);
            ucDdo_parametropercentual.SetProperty("IncludeDataList", Ddo_parametropercentual_Includedatalist);
            ucDdo_parametropercentual.SetProperty("SortASC", Ddo_parametropercentual_Sortasc);
            ucDdo_parametropercentual.SetProperty("SortDSC", Ddo_parametropercentual_Sortdsc);
            ucDdo_parametropercentual.SetProperty("CleanFilter", Ddo_parametropercentual_Cleanfilter);
            ucDdo_parametropercentual.SetProperty("RangeFilterFrom", Ddo_parametropercentual_Rangefilterfrom);
            ucDdo_parametropercentual.SetProperty("RangeFilterTo", Ddo_parametropercentual_Rangefilterto);
            ucDdo_parametropercentual.SetProperty("SearchButtonText", Ddo_parametropercentual_Searchbuttontext);
            ucDdo_parametropercentual.SetProperty("DropDownOptionsTitleSettingsIcons", AV90DDO_TitleSettingsIcons);
            ucDdo_parametropercentual.SetProperty("DropDownOptionsData", AV86ParametroPercentualTitleFilterData);
            ucDdo_parametropercentual.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_parametropercentual_Internalname, "DDO_PARAMETROPERCENTUALContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'" + sGXsfl_36_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_parametropercentualtitlecontrolidtoreplace_Internalname, AV89ddo_ParametroPercentualTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,63);\"", 0, edtavDdo_parametropercentualtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_ParametroWW.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities_f5", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* User Defined Control */
            ucDdo_gridcolumnsselector.SetProperty("Caption", Ddo_gridcolumnsselector_Caption);
            ucDdo_gridcolumnsselector.SetProperty("Tooltip", Ddo_gridcolumnsselector_Tooltip);
            ucDdo_gridcolumnsselector.SetProperty("Cls", Ddo_gridcolumnsselector_Cls);
            ucDdo_gridcolumnsselector.SetProperty("DropDownOptionsType", Ddo_gridcolumnsselector_Dropdownoptionstype);
            ucDdo_gridcolumnsselector.SetProperty("UpdateButtonText", Ddo_gridcolumnsselector_Updatebuttontext);
            ucDdo_gridcolumnsselector.SetProperty("DropDownOptionsTitleSettingsIcons", AV90DDO_TitleSettingsIcons);
            ucDdo_gridcolumnsselector.SetProperty("DropDownOptionsData", AV44ColumnsSelector);
            ucDdo_gridcolumnsselector.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_gridcolumnsselector_Internalname, "DDO_GRIDCOLUMNSSELECTORContainer");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_36_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ParametroWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'" + sGXsfl_36_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV14OrderedDsc), StringUtil.BoolToStr( AV14OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,67);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_ParametroWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'" + sGXsfl_36_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavManagefiltersexecutionstep_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV52ManageFiltersExecutionStep), 1, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV52ManageFiltersExecutionStep), "9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,68);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavManagefiltersexecutionstep_Jsonclick, 0, "Attribute", "", "", "", "", edtavManagefiltersexecutionstep_Visible, 1, 0, "number", "1", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ParametroWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'" + sGXsfl_36_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavTfparametrodtvigenciaini_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTfparametrodtvigenciaini_Internalname, context.localUtil.Format(AV63TFParametroDtVigenciaIni, "99/99/99"), context.localUtil.Format( AV63TFParametroDtVigenciaIni, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,69);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfparametrodtvigenciaini_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfparametrodtvigenciaini_Visible, 1, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ParametroWW.htm");
            GxWebStd.gx_bitmap( context, edtavTfparametrodtvigenciaini_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavTfparametrodtvigenciaini_Visible==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_ParametroWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 70,'',false,'" + sGXsfl_36_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavTfparametrodtvigenciaini_to_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTfparametrodtvigenciaini_to_Internalname, context.localUtil.Format(AV64TFParametroDtVigenciaIni_To, "99/99/99"), context.localUtil.Format( AV64TFParametroDtVigenciaIni_To, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,70);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfparametrodtvigenciaini_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfparametrodtvigenciaini_to_Visible, 1, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ParametroWW.htm");
            GxWebStd.gx_bitmap( context, edtavTfparametrodtvigenciaini_to_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavTfparametrodtvigenciaini_to_Visible==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_ParametroWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divDdo_parametrodtvigenciainiauxdates_Internalname, 1, 0, "px", 0, "px", "Invisible", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'" + sGXsfl_36_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavDdo_parametrodtvigenciainiauxdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDdo_parametrodtvigenciainiauxdate_Internalname, context.localUtil.Format(AV65DDO_ParametroDtVigenciaIniAuxDate, "99/99/99"), context.localUtil.Format( AV65DDO_ParametroDtVigenciaIniAuxDate, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,72);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDdo_parametrodtvigenciainiauxdate_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ParametroWW.htm");
            GxWebStd.gx_bitmap( context, edtavDdo_parametrodtvigenciainiauxdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_ParametroWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'" + sGXsfl_36_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavDdo_parametrodtvigenciainiauxdateto_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDdo_parametrodtvigenciainiauxdateto_Internalname, context.localUtil.Format(AV66DDO_ParametroDtVigenciaIniAuxDateTo, "99/99/99"), context.localUtil.Format( AV66DDO_ParametroDtVigenciaIniAuxDateTo, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,73);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDdo_parametrodtvigenciainiauxdateto_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ParametroWW.htm");
            GxWebStd.gx_bitmap( context, edtavDdo_parametrodtvigenciainiauxdateto_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_ParametroWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'" + sGXsfl_36_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavTfparametrodtvigenciafim_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTfparametrodtvigenciafim_Internalname, context.localUtil.Format(AV69TFParametroDtVigenciaFim, "99/99/99"), context.localUtil.Format( AV69TFParametroDtVigenciaFim, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,74);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfparametrodtvigenciafim_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfparametrodtvigenciafim_Visible, 1, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ParametroWW.htm");
            GxWebStd.gx_bitmap( context, edtavTfparametrodtvigenciafim_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavTfparametrodtvigenciafim_Visible==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_ParametroWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 75,'',false,'" + sGXsfl_36_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavTfparametrodtvigenciafim_to_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTfparametrodtvigenciafim_to_Internalname, context.localUtil.Format(AV70TFParametroDtVigenciaFim_To, "99/99/99"), context.localUtil.Format( AV70TFParametroDtVigenciaFim_To, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,75);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfparametrodtvigenciafim_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfparametrodtvigenciafim_to_Visible, 1, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ParametroWW.htm");
            GxWebStd.gx_bitmap( context, edtavTfparametrodtvigenciafim_to_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavTfparametrodtvigenciafim_to_Visible==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_ParametroWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divDdo_parametrodtvigenciafimauxdates_Internalname, 1, 0, "px", 0, "px", "Invisible", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'" + sGXsfl_36_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavDdo_parametrodtvigenciafimauxdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDdo_parametrodtvigenciafimauxdate_Internalname, context.localUtil.Format(AV71DDO_ParametroDtVigenciaFimAuxDate, "99/99/99"), context.localUtil.Format( AV71DDO_ParametroDtVigenciaFimAuxDate, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,77);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDdo_parametrodtvigenciafimauxdate_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ParametroWW.htm");
            GxWebStd.gx_bitmap( context, edtavDdo_parametrodtvigenciafimauxdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_ParametroWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'" + sGXsfl_36_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavDdo_parametrodtvigenciafimauxdateto_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDdo_parametrodtvigenciafimauxdateto_Internalname, context.localUtil.Format(AV72DDO_ParametroDtVigenciaFimAuxDateTo, "99/99/99"), context.localUtil.Format( AV72DDO_ParametroDtVigenciaFimAuxDateTo, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,78);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDdo_parametrodtvigenciafimauxdateto_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ParametroWW.htm");
            GxWebStd.gx_bitmap( context, edtavDdo_parametrodtvigenciafimauxdateto_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_ParametroWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 79,'',false,'" + sGXsfl_36_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfparametrovalor_Internalname, StringUtil.LTrim( StringUtil.NToC( AV83TFParametroValor, 14, 2, ",", "")), StringUtil.LTrim( context.localUtil.Format( AV83TFParametroValor, "ZZZ,ZZZ,ZZ9.99")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,79);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfparametrovalor_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfparametrovalor_Visible, 1, 0, "text", "", 14, "chr", 1, "row", 14, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ParametroWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 80,'',false,'" + sGXsfl_36_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfparametrovalor_to_Internalname, StringUtil.LTrim( StringUtil.NToC( AV84TFParametroValor_To, 14, 2, ",", "")), StringUtil.LTrim( context.localUtil.Format( AV84TFParametroValor_To, "ZZZ,ZZZ,ZZ9.99")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,80);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfparametrovalor_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfparametrovalor_to_Visible, 1, 0, "text", "", 14, "chr", 1, "row", 14, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ParametroWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'" + sGXsfl_36_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfparametropercentual_Internalname, StringUtil.LTrim( StringUtil.NToC( AV87TFParametroPercentual, 6, 2, ",", "")), StringUtil.LTrim( context.localUtil.Format( AV87TFParametroPercentual, "ZZ9.99")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,81);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfparametropercentual_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfparametropercentual_Visible, 1, 0, "text", "", 6, "chr", 1, "row", 6, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ParametroWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 82,'',false,'" + sGXsfl_36_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfparametropercentual_to_Internalname, StringUtil.LTrim( StringUtil.NToC( AV88TFParametroPercentual_To, 6, 2, ",", "")), StringUtil.LTrim( context.localUtil.Format( AV88TFParametroPercentual_To, "ZZ9.99")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,82);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfparametropercentual_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfparametropercentual_to_Visible, 1, 0, "text", "", 6, "chr", 1, "row", 6, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ParametroWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 36 )
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

      protected void START0V2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_2-131213", 0) ;
            Form.Meta.addItem("description", " Parametro", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP0V0( ) ;
      }

      protected void WS0V2( )
      {
         START0V2( ) ;
         EVT0V2( ) ;
      }

      protected void EVT0V2( )
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
                              E110V2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E120V2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E130V2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PARAMETRODTVIGENCIAINI.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E140V2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PARAMETRODTVIGENCIAFIM.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E150V2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PARAMETROTIPO.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E160V2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PARAMETROPRIORITARIA.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E170V2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PARAMETROVALOR.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E180V2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PARAMETROPERCENTUAL.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E190V2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_GRIDCOLUMNSSELECTOR.ONCOLUMNSCHANGED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E200V2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoInsert' */
                              E210V2 ();
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
                              nGXsfl_36_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0");
                              SubsflControlProps_362( ) ;
                              AV94Update = cgiGet( edtavUpdate_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUpdate_Internalname, AV94Update);
                              AV95Delete = cgiGet( edtavDelete_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDelete_Internalname, AV95Delete);
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
                                    E220V2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E230V2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E240V2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
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
                                       /* Set Refresh If Tfparametrodtvigenciaini Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vTFPARAMETRODTVIGENCIAINI"), 0) != AV63TFParametroDtVigenciaIni )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfparametrodtvigenciaini_to Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vTFPARAMETRODTVIGENCIAINI_TO"), 0) != AV64TFParametroDtVigenciaIni_To )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfparametrodtvigenciafim Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vTFPARAMETRODTVIGENCIAFIM"), 0) != AV69TFParametroDtVigenciaFim )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfparametrodtvigenciafim_to Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vTFPARAMETRODTVIGENCIAFIM_TO"), 0) != AV70TFParametroDtVigenciaFim_To )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfparametrovalor Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFPARAMETROVALOR"), ",", ".") != AV83TFParametroValor )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfparametrovalor_to Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFPARAMETROVALOR_TO"), ",", ".") != AV84TFParametroValor_To )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfparametropercentual Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFPARAMETROPERCENTUAL"), ",", ".") != AV87TFParametroPercentual )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfparametropercentual_to Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFPARAMETROPERCENTUAL_TO"), ",", ".") != AV88TFParametroPercentual_To )
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

      protected void WE0V2( )
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

      protected void PA0V2( )
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
               GX_FocusControl = edtavDdo_parametrodtvigenciainititlecontrolidtoreplace_Internalname;
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
         SubsflControlProps_362( ) ;
         while ( nGXsfl_36_idx <= nRC_GXsfl_36 )
         {
            sendrow_362( ) ;
            nGXsfl_36_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_36_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_36_idx+1));
            sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0");
            SubsflControlProps_362( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       short AV13OrderedBy ,
                                       bool AV14OrderedDsc ,
                                       DateTime AV63TFParametroDtVigenciaIni ,
                                       DateTime AV64TFParametroDtVigenciaIni_To ,
                                       DateTime AV69TFParametroDtVigenciaFim ,
                                       DateTime AV70TFParametroDtVigenciaFim_To ,
                                       decimal AV83TFParametroValor ,
                                       decimal AV84TFParametroValor_To ,
                                       decimal AV87TFParametroPercentual ,
                                       decimal AV88TFParametroPercentual_To ,
                                       short AV52ManageFiltersExecutionStep ,
                                       GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector AV44ColumnsSelector ,
                                       String AV67ddo_ParametroDtVigenciaIniTitleControlIdToReplace ,
                                       String AV73ddo_ParametroDtVigenciaFimTitleControlIdToReplace ,
                                       String AV77ddo_ParametroTipoTitleControlIdToReplace ,
                                       String AV81ddo_ParametroPrioritariaTitleControlIdToReplace ,
                                       String AV85ddo_ParametroValorTitleControlIdToReplace ,
                                       String AV89ddo_ParametroPercentualTitleControlIdToReplace ,
                                       GxSimpleCollection<String> AV76TFParametroTipo_Sels ,
                                       GxSimpleCollection<String> AV80TFParametroPrioritaria_Sels ,
                                       String AV108Pgmname )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF0V2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_PARAMETROID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A13ParametroID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "PARAMETROID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A13ParametroID), 4, 0, ".", "")));
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
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF0V2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV108Pgmname = "ParametroWW";
         context.Gx_err = 0;
         edtavUpdate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Enabled), 5, 0)), !bGXsfl_36_Refreshing);
         edtavDelete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Enabled), 5, 0)), !bGXsfl_36_Refreshing);
      }

      protected void RF0V2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 36;
         /* Execute user event: Refresh */
         E230V2 ();
         nGXsfl_36_idx = 1;
         sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0");
         SubsflControlProps_362( ) ;
         bGXsfl_36_Refreshing = true;
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
            SubsflControlProps_362( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 A16ParametroTipo ,
                                                 AV102ParametroWWDS_5_Tfparametrotipo_sels ,
                                                 A17ParametroPrioritaria ,
                                                 AV103ParametroWWDS_6_Tfparametroprioritaria_sels ,
                                                 AV98ParametroWWDS_1_Tfparametrodtvigenciaini ,
                                                 AV99ParametroWWDS_2_Tfparametrodtvigenciaini_to ,
                                                 AV100ParametroWWDS_3_Tfparametrodtvigenciafim ,
                                                 AV101ParametroWWDS_4_Tfparametrodtvigenciafim_to ,
                                                 AV102ParametroWWDS_5_Tfparametrotipo_sels.Count ,
                                                 AV103ParametroWWDS_6_Tfparametroprioritaria_sels.Count ,
                                                 AV104ParametroWWDS_7_Tfparametrovalor ,
                                                 AV105ParametroWWDS_8_Tfparametrovalor_to ,
                                                 AV106ParametroWWDS_9_Tfparametropercentual ,
                                                 AV107ParametroWWDS_10_Tfparametropercentual_to ,
                                                 A14ParametroDtVigenciaIni ,
                                                 A15ParametroDtVigenciaFim ,
                                                 A18ParametroValor ,
                                                 A19ParametroPercentual ,
                                                 AV13OrderedBy ,
                                                 AV14OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.INT, TypeConstants.INT, TypeConstants.DECIMAL, TypeConstants.DECIMAL,
                                                 TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            /* Using cursor H000V2 */
            pr_default.execute(0, new Object[] {AV98ParametroWWDS_1_Tfparametrodtvigenciaini, AV99ParametroWWDS_2_Tfparametrodtvigenciaini_to, AV100ParametroWWDS_3_Tfparametrodtvigenciafim, AV101ParametroWWDS_4_Tfparametrodtvigenciafim_to, AV104ParametroWWDS_7_Tfparametrovalor, AV105ParametroWWDS_8_Tfparametrovalor_to, AV106ParametroWWDS_9_Tfparametropercentual, AV107ParametroWWDS_10_Tfparametropercentual_to, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_36_idx = 1;
            sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0");
            SubsflControlProps_362( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A19ParametroPercentual = H000V2_A19ParametroPercentual[0];
               A18ParametroValor = H000V2_A18ParametroValor[0];
               A17ParametroPrioritaria = H000V2_A17ParametroPrioritaria[0];
               A16ParametroTipo = H000V2_A16ParametroTipo[0];
               A15ParametroDtVigenciaFim = H000V2_A15ParametroDtVigenciaFim[0];
               A14ParametroDtVigenciaIni = H000V2_A14ParametroDtVigenciaIni[0];
               A13ParametroID = H000V2_A13ParametroID[0];
               E240V2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 36;
            WB0V0( ) ;
         }
         bGXsfl_36_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes0V2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_PARAMETROID"+"_"+sGXsfl_36_idx, GetSecureSignedToken( sGXsfl_36_idx, context.localUtil.Format( (decimal)(A13ParametroID), "ZZZ9"), context));
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
         AV98ParametroWWDS_1_Tfparametrodtvigenciaini = AV63TFParametroDtVigenciaIni;
         AV99ParametroWWDS_2_Tfparametrodtvigenciaini_to = AV64TFParametroDtVigenciaIni_To;
         AV100ParametroWWDS_3_Tfparametrodtvigenciafim = AV69TFParametroDtVigenciaFim;
         AV101ParametroWWDS_4_Tfparametrodtvigenciafim_to = AV70TFParametroDtVigenciaFim_To;
         AV102ParametroWWDS_5_Tfparametrotipo_sels = AV76TFParametroTipo_Sels;
         AV103ParametroWWDS_6_Tfparametroprioritaria_sels = AV80TFParametroPrioritaria_Sels;
         AV104ParametroWWDS_7_Tfparametrovalor = AV83TFParametroValor;
         AV105ParametroWWDS_8_Tfparametrovalor_to = AV84TFParametroValor_To;
         AV106ParametroWWDS_9_Tfparametropercentual = AV87TFParametroPercentual;
         AV107ParametroWWDS_10_Tfparametropercentual_to = AV88TFParametroPercentual_To;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              A16ParametroTipo ,
                                              AV102ParametroWWDS_5_Tfparametrotipo_sels ,
                                              A17ParametroPrioritaria ,
                                              AV103ParametroWWDS_6_Tfparametroprioritaria_sels ,
                                              AV98ParametroWWDS_1_Tfparametrodtvigenciaini ,
                                              AV99ParametroWWDS_2_Tfparametrodtvigenciaini_to ,
                                              AV100ParametroWWDS_3_Tfparametrodtvigenciafim ,
                                              AV101ParametroWWDS_4_Tfparametrodtvigenciafim_to ,
                                              AV102ParametroWWDS_5_Tfparametrotipo_sels.Count ,
                                              AV103ParametroWWDS_6_Tfparametroprioritaria_sels.Count ,
                                              AV104ParametroWWDS_7_Tfparametrovalor ,
                                              AV105ParametroWWDS_8_Tfparametrovalor_to ,
                                              AV106ParametroWWDS_9_Tfparametropercentual ,
                                              AV107ParametroWWDS_10_Tfparametropercentual_to ,
                                              A14ParametroDtVigenciaIni ,
                                              A15ParametroDtVigenciaFim ,
                                              A18ParametroValor ,
                                              A19ParametroPercentual ,
                                              AV13OrderedBy ,
                                              AV14OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.INT, TypeConstants.INT, TypeConstants.DECIMAL, TypeConstants.DECIMAL,
                                              TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         /* Using cursor H000V3 */
         pr_default.execute(1, new Object[] {AV98ParametroWWDS_1_Tfparametrodtvigenciaini, AV99ParametroWWDS_2_Tfparametrodtvigenciaini_to, AV100ParametroWWDS_3_Tfparametrodtvigenciafim, AV101ParametroWWDS_4_Tfparametrodtvigenciafim_to, AV104ParametroWWDS_7_Tfparametrovalor, AV105ParametroWWDS_8_Tfparametrovalor_to, AV106ParametroWWDS_9_Tfparametropercentual, AV107ParametroWWDS_10_Tfparametropercentual_to});
         GRID_nRecordCount = H000V3_AGRID_nRecordCount[0];
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
         AV98ParametroWWDS_1_Tfparametrodtvigenciaini = AV63TFParametroDtVigenciaIni;
         AV99ParametroWWDS_2_Tfparametrodtvigenciaini_to = AV64TFParametroDtVigenciaIni_To;
         AV100ParametroWWDS_3_Tfparametrodtvigenciafim = AV69TFParametroDtVigenciaFim;
         AV101ParametroWWDS_4_Tfparametrodtvigenciafim_to = AV70TFParametroDtVigenciaFim_To;
         AV102ParametroWWDS_5_Tfparametrotipo_sels = AV76TFParametroTipo_Sels;
         AV103ParametroWWDS_6_Tfparametroprioritaria_sels = AV80TFParametroPrioritaria_Sels;
         AV104ParametroWWDS_7_Tfparametrovalor = AV83TFParametroValor;
         AV105ParametroWWDS_8_Tfparametrovalor_to = AV84TFParametroValor_To;
         AV106ParametroWWDS_9_Tfparametropercentual = AV87TFParametroPercentual;
         AV107ParametroWWDS_10_Tfparametropercentual_to = AV88TFParametroPercentual_To;
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV63TFParametroDtVigenciaIni, AV64TFParametroDtVigenciaIni_To, AV69TFParametroDtVigenciaFim, AV70TFParametroDtVigenciaFim_To, AV83TFParametroValor, AV84TFParametroValor_To, AV87TFParametroPercentual, AV88TFParametroPercentual_To, AV52ManageFiltersExecutionStep, AV44ColumnsSelector, AV67ddo_ParametroDtVigenciaIniTitleControlIdToReplace, AV73ddo_ParametroDtVigenciaFimTitleControlIdToReplace, AV77ddo_ParametroTipoTitleControlIdToReplace, AV81ddo_ParametroPrioritariaTitleControlIdToReplace, AV85ddo_ParametroValorTitleControlIdToReplace, AV89ddo_ParametroPercentualTitleControlIdToReplace, AV76TFParametroTipo_Sels, AV80TFParametroPrioritaria_Sels, AV108Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV98ParametroWWDS_1_Tfparametrodtvigenciaini = AV63TFParametroDtVigenciaIni;
         AV99ParametroWWDS_2_Tfparametrodtvigenciaini_to = AV64TFParametroDtVigenciaIni_To;
         AV100ParametroWWDS_3_Tfparametrodtvigenciafim = AV69TFParametroDtVigenciaFim;
         AV101ParametroWWDS_4_Tfparametrodtvigenciafim_to = AV70TFParametroDtVigenciaFim_To;
         AV102ParametroWWDS_5_Tfparametrotipo_sels = AV76TFParametroTipo_Sels;
         AV103ParametroWWDS_6_Tfparametroprioritaria_sels = AV80TFParametroPrioritaria_Sels;
         AV104ParametroWWDS_7_Tfparametrovalor = AV83TFParametroValor;
         AV105ParametroWWDS_8_Tfparametrovalor_to = AV84TFParametroValor_To;
         AV106ParametroWWDS_9_Tfparametropercentual = AV87TFParametroPercentual;
         AV107ParametroWWDS_10_Tfparametropercentual_to = AV88TFParametroPercentual_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV63TFParametroDtVigenciaIni, AV64TFParametroDtVigenciaIni_To, AV69TFParametroDtVigenciaFim, AV70TFParametroDtVigenciaFim_To, AV83TFParametroValor, AV84TFParametroValor_To, AV87TFParametroPercentual, AV88TFParametroPercentual_To, AV52ManageFiltersExecutionStep, AV44ColumnsSelector, AV67ddo_ParametroDtVigenciaIniTitleControlIdToReplace, AV73ddo_ParametroDtVigenciaFimTitleControlIdToReplace, AV77ddo_ParametroTipoTitleControlIdToReplace, AV81ddo_ParametroPrioritariaTitleControlIdToReplace, AV85ddo_ParametroValorTitleControlIdToReplace, AV89ddo_ParametroPercentualTitleControlIdToReplace, AV76TFParametroTipo_Sels, AV80TFParametroPrioritaria_Sels, AV108Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV98ParametroWWDS_1_Tfparametrodtvigenciaini = AV63TFParametroDtVigenciaIni;
         AV99ParametroWWDS_2_Tfparametrodtvigenciaini_to = AV64TFParametroDtVigenciaIni_To;
         AV100ParametroWWDS_3_Tfparametrodtvigenciafim = AV69TFParametroDtVigenciaFim;
         AV101ParametroWWDS_4_Tfparametrodtvigenciafim_to = AV70TFParametroDtVigenciaFim_To;
         AV102ParametroWWDS_5_Tfparametrotipo_sels = AV76TFParametroTipo_Sels;
         AV103ParametroWWDS_6_Tfparametroprioritaria_sels = AV80TFParametroPrioritaria_Sels;
         AV104ParametroWWDS_7_Tfparametrovalor = AV83TFParametroValor;
         AV105ParametroWWDS_8_Tfparametrovalor_to = AV84TFParametroValor_To;
         AV106ParametroWWDS_9_Tfparametropercentual = AV87TFParametroPercentual;
         AV107ParametroWWDS_10_Tfparametropercentual_to = AV88TFParametroPercentual_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV63TFParametroDtVigenciaIni, AV64TFParametroDtVigenciaIni_To, AV69TFParametroDtVigenciaFim, AV70TFParametroDtVigenciaFim_To, AV83TFParametroValor, AV84TFParametroValor_To, AV87TFParametroPercentual, AV88TFParametroPercentual_To, AV52ManageFiltersExecutionStep, AV44ColumnsSelector, AV67ddo_ParametroDtVigenciaIniTitleControlIdToReplace, AV73ddo_ParametroDtVigenciaFimTitleControlIdToReplace, AV77ddo_ParametroTipoTitleControlIdToReplace, AV81ddo_ParametroPrioritariaTitleControlIdToReplace, AV85ddo_ParametroValorTitleControlIdToReplace, AV89ddo_ParametroPercentualTitleControlIdToReplace, AV76TFParametroTipo_Sels, AV80TFParametroPrioritaria_Sels, AV108Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV98ParametroWWDS_1_Tfparametrodtvigenciaini = AV63TFParametroDtVigenciaIni;
         AV99ParametroWWDS_2_Tfparametrodtvigenciaini_to = AV64TFParametroDtVigenciaIni_To;
         AV100ParametroWWDS_3_Tfparametrodtvigenciafim = AV69TFParametroDtVigenciaFim;
         AV101ParametroWWDS_4_Tfparametrodtvigenciafim_to = AV70TFParametroDtVigenciaFim_To;
         AV102ParametroWWDS_5_Tfparametrotipo_sels = AV76TFParametroTipo_Sels;
         AV103ParametroWWDS_6_Tfparametroprioritaria_sels = AV80TFParametroPrioritaria_Sels;
         AV104ParametroWWDS_7_Tfparametrovalor = AV83TFParametroValor;
         AV105ParametroWWDS_8_Tfparametrovalor_to = AV84TFParametroValor_To;
         AV106ParametroWWDS_9_Tfparametropercentual = AV87TFParametroPercentual;
         AV107ParametroWWDS_10_Tfparametropercentual_to = AV88TFParametroPercentual_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV63TFParametroDtVigenciaIni, AV64TFParametroDtVigenciaIni_To, AV69TFParametroDtVigenciaFim, AV70TFParametroDtVigenciaFim_To, AV83TFParametroValor, AV84TFParametroValor_To, AV87TFParametroPercentual, AV88TFParametroPercentual_To, AV52ManageFiltersExecutionStep, AV44ColumnsSelector, AV67ddo_ParametroDtVigenciaIniTitleControlIdToReplace, AV73ddo_ParametroDtVigenciaFimTitleControlIdToReplace, AV77ddo_ParametroTipoTitleControlIdToReplace, AV81ddo_ParametroPrioritariaTitleControlIdToReplace, AV85ddo_ParametroValorTitleControlIdToReplace, AV89ddo_ParametroPercentualTitleControlIdToReplace, AV76TFParametroTipo_Sels, AV80TFParametroPrioritaria_Sels, AV108Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV98ParametroWWDS_1_Tfparametrodtvigenciaini = AV63TFParametroDtVigenciaIni;
         AV99ParametroWWDS_2_Tfparametrodtvigenciaini_to = AV64TFParametroDtVigenciaIni_To;
         AV100ParametroWWDS_3_Tfparametrodtvigenciafim = AV69TFParametroDtVigenciaFim;
         AV101ParametroWWDS_4_Tfparametrodtvigenciafim_to = AV70TFParametroDtVigenciaFim_To;
         AV102ParametroWWDS_5_Tfparametrotipo_sels = AV76TFParametroTipo_Sels;
         AV103ParametroWWDS_6_Tfparametroprioritaria_sels = AV80TFParametroPrioritaria_Sels;
         AV104ParametroWWDS_7_Tfparametrovalor = AV83TFParametroValor;
         AV105ParametroWWDS_8_Tfparametrovalor_to = AV84TFParametroValor_To;
         AV106ParametroWWDS_9_Tfparametropercentual = AV87TFParametroPercentual;
         AV107ParametroWWDS_10_Tfparametropercentual_to = AV88TFParametroPercentual_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV63TFParametroDtVigenciaIni, AV64TFParametroDtVigenciaIni_To, AV69TFParametroDtVigenciaFim, AV70TFParametroDtVigenciaFim_To, AV83TFParametroValor, AV84TFParametroValor_To, AV87TFParametroPercentual, AV88TFParametroPercentual_To, AV52ManageFiltersExecutionStep, AV44ColumnsSelector, AV67ddo_ParametroDtVigenciaIniTitleControlIdToReplace, AV73ddo_ParametroDtVigenciaFimTitleControlIdToReplace, AV77ddo_ParametroTipoTitleControlIdToReplace, AV81ddo_ParametroPrioritariaTitleControlIdToReplace, AV85ddo_ParametroValorTitleControlIdToReplace, AV89ddo_ParametroPercentualTitleControlIdToReplace, AV76TFParametroTipo_Sels, AV80TFParametroPrioritaria_Sels, AV108Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP0V0( )
      {
         /* Before Start, stand alone formulas. */
         AV108Pgmname = "ParametroWW";
         context.Gx_err = 0;
         edtavUpdate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Enabled), 5, 0)), !bGXsfl_36_Refreshing);
         edtavDelete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Enabled), 5, 0)), !bGXsfl_36_Refreshing);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E220V2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vMANAGEFILTERSDATA"), AV56ManageFiltersData);
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV90DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vPARAMETRODTVIGENCIAINITITLEFILTERDATA"), AV62ParametroDtVigenciaIniTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPARAMETRODTVIGENCIAFIMTITLEFILTERDATA"), AV68ParametroDtVigenciaFimTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPARAMETROTIPOTITLEFILTERDATA"), AV74ParametroTipoTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPARAMETROPRIORITARIATITLEFILTERDATA"), AV78ParametroPrioritariaTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPARAMETROVALORTITLEFILTERDATA"), AV82ParametroValorTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPARAMETROPERCENTUALTITLEFILTERDATA"), AV86ParametroPercentualTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vCOLUMNSSELECTOR"), AV44ColumnsSelector);
            /* Read variables values. */
            AV67ddo_ParametroDtVigenciaIniTitleControlIdToReplace = cgiGet( edtavDdo_parametrodtvigenciainititlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV67ddo_ParametroDtVigenciaIniTitleControlIdToReplace", AV67ddo_ParametroDtVigenciaIniTitleControlIdToReplace);
            AV73ddo_ParametroDtVigenciaFimTitleControlIdToReplace = cgiGet( edtavDdo_parametrodtvigenciafimtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV73ddo_ParametroDtVigenciaFimTitleControlIdToReplace", AV73ddo_ParametroDtVigenciaFimTitleControlIdToReplace);
            AV77ddo_ParametroTipoTitleControlIdToReplace = cgiGet( edtavDdo_parametrotipotitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV77ddo_ParametroTipoTitleControlIdToReplace", AV77ddo_ParametroTipoTitleControlIdToReplace);
            AV81ddo_ParametroPrioritariaTitleControlIdToReplace = cgiGet( edtavDdo_parametroprioritariatitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV81ddo_ParametroPrioritariaTitleControlIdToReplace", AV81ddo_ParametroPrioritariaTitleControlIdToReplace);
            AV85ddo_ParametroValorTitleControlIdToReplace = cgiGet( edtavDdo_parametrovalortitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV85ddo_ParametroValorTitleControlIdToReplace", AV85ddo_ParametroValorTitleControlIdToReplace);
            AV89ddo_ParametroPercentualTitleControlIdToReplace = cgiGet( edtavDdo_parametropercentualtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV89ddo_ParametroPercentualTitleControlIdToReplace", AV89ddo_ParametroPercentualTitleControlIdToReplace);
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
            if ( context.localUtil.VCDate( cgiGet( edtavTfparametrodtvigenciaini_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"TFParametro Dt Vigencia Ini"}), 1, "vTFPARAMETRODTVIGENCIAINI");
               GX_FocusControl = edtavTfparametrodtvigenciaini_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV63TFParametroDtVigenciaIni = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV63TFParametroDtVigenciaIni", context.localUtil.Format(AV63TFParametroDtVigenciaIni, "99/99/99"));
            }
            else
            {
               AV63TFParametroDtVigenciaIni = context.localUtil.CToD( cgiGet( edtavTfparametrodtvigenciaini_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV63TFParametroDtVigenciaIni", context.localUtil.Format(AV63TFParametroDtVigenciaIni, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavTfparametrodtvigenciaini_to_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"TFParametro Dt Vigencia Ini_To"}), 1, "vTFPARAMETRODTVIGENCIAINI_TO");
               GX_FocusControl = edtavTfparametrodtvigenciaini_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV64TFParametroDtVigenciaIni_To = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV64TFParametroDtVigenciaIni_To", context.localUtil.Format(AV64TFParametroDtVigenciaIni_To, "99/99/99"));
            }
            else
            {
               AV64TFParametroDtVigenciaIni_To = context.localUtil.CToD( cgiGet( edtavTfparametrodtvigenciaini_to_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV64TFParametroDtVigenciaIni_To", context.localUtil.Format(AV64TFParametroDtVigenciaIni_To, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavDdo_parametrodtvigenciainiauxdate_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"DDO_Parametro Dt Vigencia Ini Aux Date"}), 1, "vDDO_PARAMETRODTVIGENCIAINIAUXDATE");
               GX_FocusControl = edtavDdo_parametrodtvigenciainiauxdate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV65DDO_ParametroDtVigenciaIniAuxDate = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV65DDO_ParametroDtVigenciaIniAuxDate", context.localUtil.Format(AV65DDO_ParametroDtVigenciaIniAuxDate, "99/99/99"));
            }
            else
            {
               AV65DDO_ParametroDtVigenciaIniAuxDate = context.localUtil.CToD( cgiGet( edtavDdo_parametrodtvigenciainiauxdate_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV65DDO_ParametroDtVigenciaIniAuxDate", context.localUtil.Format(AV65DDO_ParametroDtVigenciaIniAuxDate, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavDdo_parametrodtvigenciainiauxdateto_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"DDO_Parametro Dt Vigencia Ini Aux Date To"}), 1, "vDDO_PARAMETRODTVIGENCIAINIAUXDATETO");
               GX_FocusControl = edtavDdo_parametrodtvigenciainiauxdateto_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV66DDO_ParametroDtVigenciaIniAuxDateTo = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV66DDO_ParametroDtVigenciaIniAuxDateTo", context.localUtil.Format(AV66DDO_ParametroDtVigenciaIniAuxDateTo, "99/99/99"));
            }
            else
            {
               AV66DDO_ParametroDtVigenciaIniAuxDateTo = context.localUtil.CToD( cgiGet( edtavDdo_parametrodtvigenciainiauxdateto_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV66DDO_ParametroDtVigenciaIniAuxDateTo", context.localUtil.Format(AV66DDO_ParametroDtVigenciaIniAuxDateTo, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavTfparametrodtvigenciafim_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"TFParametro Dt Vigencia Fim"}), 1, "vTFPARAMETRODTVIGENCIAFIM");
               GX_FocusControl = edtavTfparametrodtvigenciafim_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV69TFParametroDtVigenciaFim = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV69TFParametroDtVigenciaFim", context.localUtil.Format(AV69TFParametroDtVigenciaFim, "99/99/99"));
            }
            else
            {
               AV69TFParametroDtVigenciaFim = context.localUtil.CToD( cgiGet( edtavTfparametrodtvigenciafim_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV69TFParametroDtVigenciaFim", context.localUtil.Format(AV69TFParametroDtVigenciaFim, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavTfparametrodtvigenciafim_to_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"TFParametro Dt Vigencia Fim_To"}), 1, "vTFPARAMETRODTVIGENCIAFIM_TO");
               GX_FocusControl = edtavTfparametrodtvigenciafim_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV70TFParametroDtVigenciaFim_To = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV70TFParametroDtVigenciaFim_To", context.localUtil.Format(AV70TFParametroDtVigenciaFim_To, "99/99/99"));
            }
            else
            {
               AV70TFParametroDtVigenciaFim_To = context.localUtil.CToD( cgiGet( edtavTfparametrodtvigenciafim_to_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV70TFParametroDtVigenciaFim_To", context.localUtil.Format(AV70TFParametroDtVigenciaFim_To, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavDdo_parametrodtvigenciafimauxdate_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"DDO_Parametro Dt Vigencia Fim Aux Date"}), 1, "vDDO_PARAMETRODTVIGENCIAFIMAUXDATE");
               GX_FocusControl = edtavDdo_parametrodtvigenciafimauxdate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV71DDO_ParametroDtVigenciaFimAuxDate = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV71DDO_ParametroDtVigenciaFimAuxDate", context.localUtil.Format(AV71DDO_ParametroDtVigenciaFimAuxDate, "99/99/99"));
            }
            else
            {
               AV71DDO_ParametroDtVigenciaFimAuxDate = context.localUtil.CToD( cgiGet( edtavDdo_parametrodtvigenciafimauxdate_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV71DDO_ParametroDtVigenciaFimAuxDate", context.localUtil.Format(AV71DDO_ParametroDtVigenciaFimAuxDate, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavDdo_parametrodtvigenciafimauxdateto_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"DDO_Parametro Dt Vigencia Fim Aux Date To"}), 1, "vDDO_PARAMETRODTVIGENCIAFIMAUXDATETO");
               GX_FocusControl = edtavDdo_parametrodtvigenciafimauxdateto_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV72DDO_ParametroDtVigenciaFimAuxDateTo = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV72DDO_ParametroDtVigenciaFimAuxDateTo", context.localUtil.Format(AV72DDO_ParametroDtVigenciaFimAuxDateTo, "99/99/99"));
            }
            else
            {
               AV72DDO_ParametroDtVigenciaFimAuxDateTo = context.localUtil.CToD( cgiGet( edtavDdo_parametrodtvigenciafimauxdateto_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV72DDO_ParametroDtVigenciaFimAuxDateTo", context.localUtil.Format(AV72DDO_ParametroDtVigenciaFimAuxDateTo, "99/99/99"));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfparametrovalor_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfparametrovalor_Internalname), ",", ".") > 999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFPARAMETROVALOR");
               GX_FocusControl = edtavTfparametrovalor_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV83TFParametroValor = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV83TFParametroValor", StringUtil.LTrim( StringUtil.Str( AV83TFParametroValor, 12, 2)));
            }
            else
            {
               AV83TFParametroValor = context.localUtil.CToN( cgiGet( edtavTfparametrovalor_Internalname), ",", ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV83TFParametroValor", StringUtil.LTrim( StringUtil.Str( AV83TFParametroValor, 12, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfparametrovalor_to_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfparametrovalor_to_Internalname), ",", ".") > 999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFPARAMETROVALOR_TO");
               GX_FocusControl = edtavTfparametrovalor_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV84TFParametroValor_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV84TFParametroValor_To", StringUtil.LTrim( StringUtil.Str( AV84TFParametroValor_To, 12, 2)));
            }
            else
            {
               AV84TFParametroValor_To = context.localUtil.CToN( cgiGet( edtavTfparametrovalor_to_Internalname), ",", ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV84TFParametroValor_To", StringUtil.LTrim( StringUtil.Str( AV84TFParametroValor_To, 12, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfparametropercentual_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfparametropercentual_Internalname), ",", ".") > 999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFPARAMETROPERCENTUAL");
               GX_FocusControl = edtavTfparametropercentual_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV87TFParametroPercentual = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV87TFParametroPercentual", StringUtil.LTrim( StringUtil.Str( AV87TFParametroPercentual, 6, 2)));
            }
            else
            {
               AV87TFParametroPercentual = context.localUtil.CToN( cgiGet( edtavTfparametropercentual_Internalname), ",", ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV87TFParametroPercentual", StringUtil.LTrim( StringUtil.Str( AV87TFParametroPercentual, 6, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfparametropercentual_to_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfparametropercentual_to_Internalname), ",", ".") > 999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFPARAMETROPERCENTUAL_TO");
               GX_FocusControl = edtavTfparametropercentual_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV88TFParametroPercentual_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV88TFParametroPercentual_To", StringUtil.LTrim( StringUtil.Str( AV88TFParametroPercentual_To, 6, 2)));
            }
            else
            {
               AV88TFParametroPercentual_To = context.localUtil.CToN( cgiGet( edtavTfparametropercentual_to_Internalname), ",", ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV88TFParametroPercentual_To", StringUtil.LTrim( StringUtil.Str( AV88TFParametroPercentual_To, 6, 2)));
            }
            /* Read saved values. */
            nRC_GXsfl_36 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_36"), ",", "."));
            AV92GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ",", "."));
            AV93GridPageCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGECOUNT"), ",", "."));
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
            Ddo_parametrodtvigenciaini_Caption = cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Caption");
            Ddo_parametrodtvigenciaini_Tooltip = cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Tooltip");
            Ddo_parametrodtvigenciaini_Cls = cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Cls");
            Ddo_parametrodtvigenciaini_Filteredtext_set = cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Filteredtext_set");
            Ddo_parametrodtvigenciaini_Filteredtextto_set = cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Filteredtextto_set");
            Ddo_parametrodtvigenciaini_Dropdownoptionstype = cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Dropdownoptionstype");
            Ddo_parametrodtvigenciaini_Titlecontrolidtoreplace = cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Titlecontrolidtoreplace");
            Ddo_parametrodtvigenciaini_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Includesortasc"));
            Ddo_parametrodtvigenciaini_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Includesortdsc"));
            Ddo_parametrodtvigenciaini_Sortedstatus = cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Sortedstatus");
            Ddo_parametrodtvigenciaini_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Includefilter"));
            Ddo_parametrodtvigenciaini_Filtertype = cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Filtertype");
            Ddo_parametrodtvigenciaini_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Filterisrange"));
            Ddo_parametrodtvigenciaini_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Includedatalist"));
            Ddo_parametrodtvigenciaini_Sortasc = cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Sortasc");
            Ddo_parametrodtvigenciaini_Sortdsc = cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Sortdsc");
            Ddo_parametrodtvigenciaini_Cleanfilter = cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Cleanfilter");
            Ddo_parametrodtvigenciaini_Rangefilterfrom = cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Rangefilterfrom");
            Ddo_parametrodtvigenciaini_Rangefilterto = cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Rangefilterto");
            Ddo_parametrodtvigenciaini_Searchbuttontext = cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Searchbuttontext");
            Ddo_parametrodtvigenciafim_Caption = cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Caption");
            Ddo_parametrodtvigenciafim_Tooltip = cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Tooltip");
            Ddo_parametrodtvigenciafim_Cls = cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Cls");
            Ddo_parametrodtvigenciafim_Filteredtext_set = cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Filteredtext_set");
            Ddo_parametrodtvigenciafim_Filteredtextto_set = cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Filteredtextto_set");
            Ddo_parametrodtvigenciafim_Dropdownoptionstype = cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Dropdownoptionstype");
            Ddo_parametrodtvigenciafim_Titlecontrolidtoreplace = cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Titlecontrolidtoreplace");
            Ddo_parametrodtvigenciafim_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Includesortasc"));
            Ddo_parametrodtvigenciafim_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Includesortdsc"));
            Ddo_parametrodtvigenciafim_Sortedstatus = cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Sortedstatus");
            Ddo_parametrodtvigenciafim_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Includefilter"));
            Ddo_parametrodtvigenciafim_Filtertype = cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Filtertype");
            Ddo_parametrodtvigenciafim_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Filterisrange"));
            Ddo_parametrodtvigenciafim_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Includedatalist"));
            Ddo_parametrodtvigenciafim_Sortasc = cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Sortasc");
            Ddo_parametrodtvigenciafim_Sortdsc = cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Sortdsc");
            Ddo_parametrodtvigenciafim_Cleanfilter = cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Cleanfilter");
            Ddo_parametrodtvigenciafim_Rangefilterfrom = cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Rangefilterfrom");
            Ddo_parametrodtvigenciafim_Rangefilterto = cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Rangefilterto");
            Ddo_parametrodtvigenciafim_Searchbuttontext = cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Searchbuttontext");
            Ddo_parametrotipo_Caption = cgiGet( "DDO_PARAMETROTIPO_Caption");
            Ddo_parametrotipo_Tooltip = cgiGet( "DDO_PARAMETROTIPO_Tooltip");
            Ddo_parametrotipo_Cls = cgiGet( "DDO_PARAMETROTIPO_Cls");
            Ddo_parametrotipo_Selectedvalue_set = cgiGet( "DDO_PARAMETROTIPO_Selectedvalue_set");
            Ddo_parametrotipo_Dropdownoptionstype = cgiGet( "DDO_PARAMETROTIPO_Dropdownoptionstype");
            Ddo_parametrotipo_Titlecontrolidtoreplace = cgiGet( "DDO_PARAMETROTIPO_Titlecontrolidtoreplace");
            Ddo_parametrotipo_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROTIPO_Includesortasc"));
            Ddo_parametrotipo_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROTIPO_Includesortdsc"));
            Ddo_parametrotipo_Sortedstatus = cgiGet( "DDO_PARAMETROTIPO_Sortedstatus");
            Ddo_parametrotipo_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROTIPO_Includefilter"));
            Ddo_parametrotipo_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROTIPO_Includedatalist"));
            Ddo_parametrotipo_Datalisttype = cgiGet( "DDO_PARAMETROTIPO_Datalisttype");
            Ddo_parametrotipo_Allowmultipleselection = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROTIPO_Allowmultipleselection"));
            Ddo_parametrotipo_Datalistfixedvalues = cgiGet( "DDO_PARAMETROTIPO_Datalistfixedvalues");
            Ddo_parametrotipo_Sortasc = cgiGet( "DDO_PARAMETROTIPO_Sortasc");
            Ddo_parametrotipo_Sortdsc = cgiGet( "DDO_PARAMETROTIPO_Sortdsc");
            Ddo_parametrotipo_Cleanfilter = cgiGet( "DDO_PARAMETROTIPO_Cleanfilter");
            Ddo_parametrotipo_Searchbuttontext = cgiGet( "DDO_PARAMETROTIPO_Searchbuttontext");
            Ddo_parametroprioritaria_Caption = cgiGet( "DDO_PARAMETROPRIORITARIA_Caption");
            Ddo_parametroprioritaria_Tooltip = cgiGet( "DDO_PARAMETROPRIORITARIA_Tooltip");
            Ddo_parametroprioritaria_Cls = cgiGet( "DDO_PARAMETROPRIORITARIA_Cls");
            Ddo_parametroprioritaria_Selectedvalue_set = cgiGet( "DDO_PARAMETROPRIORITARIA_Selectedvalue_set");
            Ddo_parametroprioritaria_Dropdownoptionstype = cgiGet( "DDO_PARAMETROPRIORITARIA_Dropdownoptionstype");
            Ddo_parametroprioritaria_Titlecontrolidtoreplace = cgiGet( "DDO_PARAMETROPRIORITARIA_Titlecontrolidtoreplace");
            Ddo_parametroprioritaria_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROPRIORITARIA_Includesortasc"));
            Ddo_parametroprioritaria_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROPRIORITARIA_Includesortdsc"));
            Ddo_parametroprioritaria_Sortedstatus = cgiGet( "DDO_PARAMETROPRIORITARIA_Sortedstatus");
            Ddo_parametroprioritaria_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROPRIORITARIA_Includefilter"));
            Ddo_parametroprioritaria_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROPRIORITARIA_Includedatalist"));
            Ddo_parametroprioritaria_Datalisttype = cgiGet( "DDO_PARAMETROPRIORITARIA_Datalisttype");
            Ddo_parametroprioritaria_Allowmultipleselection = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROPRIORITARIA_Allowmultipleselection"));
            Ddo_parametroprioritaria_Datalistfixedvalues = cgiGet( "DDO_PARAMETROPRIORITARIA_Datalistfixedvalues");
            Ddo_parametroprioritaria_Sortasc = cgiGet( "DDO_PARAMETROPRIORITARIA_Sortasc");
            Ddo_parametroprioritaria_Sortdsc = cgiGet( "DDO_PARAMETROPRIORITARIA_Sortdsc");
            Ddo_parametroprioritaria_Cleanfilter = cgiGet( "DDO_PARAMETROPRIORITARIA_Cleanfilter");
            Ddo_parametroprioritaria_Searchbuttontext = cgiGet( "DDO_PARAMETROPRIORITARIA_Searchbuttontext");
            Ddo_parametrovalor_Caption = cgiGet( "DDO_PARAMETROVALOR_Caption");
            Ddo_parametrovalor_Tooltip = cgiGet( "DDO_PARAMETROVALOR_Tooltip");
            Ddo_parametrovalor_Cls = cgiGet( "DDO_PARAMETROVALOR_Cls");
            Ddo_parametrovalor_Filteredtext_set = cgiGet( "DDO_PARAMETROVALOR_Filteredtext_set");
            Ddo_parametrovalor_Filteredtextto_set = cgiGet( "DDO_PARAMETROVALOR_Filteredtextto_set");
            Ddo_parametrovalor_Dropdownoptionstype = cgiGet( "DDO_PARAMETROVALOR_Dropdownoptionstype");
            Ddo_parametrovalor_Titlecontrolidtoreplace = cgiGet( "DDO_PARAMETROVALOR_Titlecontrolidtoreplace");
            Ddo_parametrovalor_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROVALOR_Includesortasc"));
            Ddo_parametrovalor_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROVALOR_Includesortdsc"));
            Ddo_parametrovalor_Sortedstatus = cgiGet( "DDO_PARAMETROVALOR_Sortedstatus");
            Ddo_parametrovalor_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROVALOR_Includefilter"));
            Ddo_parametrovalor_Filtertype = cgiGet( "DDO_PARAMETROVALOR_Filtertype");
            Ddo_parametrovalor_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROVALOR_Filterisrange"));
            Ddo_parametrovalor_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROVALOR_Includedatalist"));
            Ddo_parametrovalor_Sortasc = cgiGet( "DDO_PARAMETROVALOR_Sortasc");
            Ddo_parametrovalor_Sortdsc = cgiGet( "DDO_PARAMETROVALOR_Sortdsc");
            Ddo_parametrovalor_Cleanfilter = cgiGet( "DDO_PARAMETROVALOR_Cleanfilter");
            Ddo_parametrovalor_Rangefilterfrom = cgiGet( "DDO_PARAMETROVALOR_Rangefilterfrom");
            Ddo_parametrovalor_Rangefilterto = cgiGet( "DDO_PARAMETROVALOR_Rangefilterto");
            Ddo_parametrovalor_Searchbuttontext = cgiGet( "DDO_PARAMETROVALOR_Searchbuttontext");
            Ddo_parametropercentual_Caption = cgiGet( "DDO_PARAMETROPERCENTUAL_Caption");
            Ddo_parametropercentual_Tooltip = cgiGet( "DDO_PARAMETROPERCENTUAL_Tooltip");
            Ddo_parametropercentual_Cls = cgiGet( "DDO_PARAMETROPERCENTUAL_Cls");
            Ddo_parametropercentual_Filteredtext_set = cgiGet( "DDO_PARAMETROPERCENTUAL_Filteredtext_set");
            Ddo_parametropercentual_Filteredtextto_set = cgiGet( "DDO_PARAMETROPERCENTUAL_Filteredtextto_set");
            Ddo_parametropercentual_Dropdownoptionstype = cgiGet( "DDO_PARAMETROPERCENTUAL_Dropdownoptionstype");
            Ddo_parametropercentual_Titlecontrolidtoreplace = cgiGet( "DDO_PARAMETROPERCENTUAL_Titlecontrolidtoreplace");
            Ddo_parametropercentual_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROPERCENTUAL_Includesortasc"));
            Ddo_parametropercentual_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROPERCENTUAL_Includesortdsc"));
            Ddo_parametropercentual_Sortedstatus = cgiGet( "DDO_PARAMETROPERCENTUAL_Sortedstatus");
            Ddo_parametropercentual_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROPERCENTUAL_Includefilter"));
            Ddo_parametropercentual_Filtertype = cgiGet( "DDO_PARAMETROPERCENTUAL_Filtertype");
            Ddo_parametropercentual_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROPERCENTUAL_Filterisrange"));
            Ddo_parametropercentual_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PARAMETROPERCENTUAL_Includedatalist"));
            Ddo_parametropercentual_Sortasc = cgiGet( "DDO_PARAMETROPERCENTUAL_Sortasc");
            Ddo_parametropercentual_Sortdsc = cgiGet( "DDO_PARAMETROPERCENTUAL_Sortdsc");
            Ddo_parametropercentual_Cleanfilter = cgiGet( "DDO_PARAMETROPERCENTUAL_Cleanfilter");
            Ddo_parametropercentual_Rangefilterfrom = cgiGet( "DDO_PARAMETROPERCENTUAL_Rangefilterfrom");
            Ddo_parametropercentual_Rangefilterto = cgiGet( "DDO_PARAMETROPERCENTUAL_Rangefilterto");
            Ddo_parametropercentual_Searchbuttontext = cgiGet( "DDO_PARAMETROPERCENTUAL_Searchbuttontext");
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
            Ddo_parametrodtvigenciaini_Activeeventkey = cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Activeeventkey");
            Ddo_parametrodtvigenciaini_Filteredtext_get = cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Filteredtext_get");
            Ddo_parametrodtvigenciaini_Filteredtextto_get = cgiGet( "DDO_PARAMETRODTVIGENCIAINI_Filteredtextto_get");
            Ddo_parametrodtvigenciafim_Activeeventkey = cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Activeeventkey");
            Ddo_parametrodtvigenciafim_Filteredtext_get = cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Filteredtext_get");
            Ddo_parametrodtvigenciafim_Filteredtextto_get = cgiGet( "DDO_PARAMETRODTVIGENCIAFIM_Filteredtextto_get");
            Ddo_parametrotipo_Activeeventkey = cgiGet( "DDO_PARAMETROTIPO_Activeeventkey");
            Ddo_parametrotipo_Selectedvalue_get = cgiGet( "DDO_PARAMETROTIPO_Selectedvalue_get");
            Ddo_parametroprioritaria_Activeeventkey = cgiGet( "DDO_PARAMETROPRIORITARIA_Activeeventkey");
            Ddo_parametroprioritaria_Selectedvalue_get = cgiGet( "DDO_PARAMETROPRIORITARIA_Selectedvalue_get");
            Ddo_parametrovalor_Activeeventkey = cgiGet( "DDO_PARAMETROVALOR_Activeeventkey");
            Ddo_parametrovalor_Filteredtext_get = cgiGet( "DDO_PARAMETROVALOR_Filteredtext_get");
            Ddo_parametrovalor_Filteredtextto_get = cgiGet( "DDO_PARAMETROVALOR_Filteredtextto_get");
            Ddo_parametropercentual_Activeeventkey = cgiGet( "DDO_PARAMETROPERCENTUAL_Activeeventkey");
            Ddo_parametropercentual_Filteredtext_get = cgiGet( "DDO_PARAMETROPERCENTUAL_Filteredtext_get");
            Ddo_parametropercentual_Filteredtextto_get = cgiGet( "DDO_PARAMETROPERCENTUAL_Filteredtextto_get");
            Ddo_gridcolumnsselector_Columnsselectorvalues = cgiGet( "DDO_GRIDCOLUMNSSELECTOR_Columnsselectorvalues");
            Ddo_managefilters_Activeeventkey = cgiGet( "DDO_MANAGEFILTERS_Activeeventkey");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ",", "."));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ",", ".") != Convert.ToDecimal( AV13OrderedBy )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV14OrderedDsc )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vTFPARAMETRODTVIGENCIAINI"), 2) != AV63TFParametroDtVigenciaIni )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vTFPARAMETRODTVIGENCIAINI_TO"), 2) != AV64TFParametroDtVigenciaIni_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vTFPARAMETRODTVIGENCIAFIM"), 2) != AV69TFParametroDtVigenciaFim )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vTFPARAMETRODTVIGENCIAFIM_TO"), 2) != AV70TFParametroDtVigenciaFim_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFPARAMETROVALOR"), ",", ".") != AV83TFParametroValor )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFPARAMETROVALOR_TO"), ",", ".") != AV84TFParametroValor_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFPARAMETROPERCENTUAL"), ",", ".") != AV87TFParametroPercentual )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFPARAMETROPERCENTUAL_TO"), ",", ".") != AV88TFParametroPercentual_To )
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
         E220V2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E220V2( )
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
         edtavTfparametrodtvigenciaini_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfparametrodtvigenciaini_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfparametrodtvigenciaini_Visible), 5, 0)), true);
         edtavTfparametrodtvigenciaini_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfparametrodtvigenciaini_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfparametrodtvigenciaini_to_Visible), 5, 0)), true);
         edtavTfparametrodtvigenciafim_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfparametrodtvigenciafim_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfparametrodtvigenciafim_Visible), 5, 0)), true);
         edtavTfparametrodtvigenciafim_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfparametrodtvigenciafim_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfparametrodtvigenciafim_to_Visible), 5, 0)), true);
         edtavTfparametrovalor_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfparametrovalor_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfparametrovalor_Visible), 5, 0)), true);
         edtavTfparametrovalor_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfparametrovalor_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfparametrovalor_to_Visible), 5, 0)), true);
         edtavTfparametropercentual_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfparametropercentual_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfparametropercentual_Visible), 5, 0)), true);
         edtavTfparametropercentual_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfparametropercentual_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfparametropercentual_to_Visible), 5, 0)), true);
         Ddo_parametrodtvigenciaini_Titlecontrolidtoreplace = subGrid_Internalname+"_ParametroDtVigenciaIni";
         ucDdo_parametrodtvigenciaini.SendProperty(context, "", false, Ddo_parametrodtvigenciaini_Internalname, "TitleControlIdToReplace", Ddo_parametrodtvigenciaini_Titlecontrolidtoreplace);
         AV67ddo_ParametroDtVigenciaIniTitleControlIdToReplace = Ddo_parametrodtvigenciaini_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV67ddo_ParametroDtVigenciaIniTitleControlIdToReplace", AV67ddo_ParametroDtVigenciaIniTitleControlIdToReplace);
         edtavDdo_parametrodtvigenciainititlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_parametrodtvigenciainititlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_parametrodtvigenciainititlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_parametrodtvigenciafim_Titlecontrolidtoreplace = subGrid_Internalname+"_ParametroDtVigenciaFim";
         ucDdo_parametrodtvigenciafim.SendProperty(context, "", false, Ddo_parametrodtvigenciafim_Internalname, "TitleControlIdToReplace", Ddo_parametrodtvigenciafim_Titlecontrolidtoreplace);
         AV73ddo_ParametroDtVigenciaFimTitleControlIdToReplace = Ddo_parametrodtvigenciafim_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV73ddo_ParametroDtVigenciaFimTitleControlIdToReplace", AV73ddo_ParametroDtVigenciaFimTitleControlIdToReplace);
         edtavDdo_parametrodtvigenciafimtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_parametrodtvigenciafimtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_parametrodtvigenciafimtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_parametrotipo_Titlecontrolidtoreplace = subGrid_Internalname+"_ParametroTipo";
         ucDdo_parametrotipo.SendProperty(context, "", false, Ddo_parametrotipo_Internalname, "TitleControlIdToReplace", Ddo_parametrotipo_Titlecontrolidtoreplace);
         AV77ddo_ParametroTipoTitleControlIdToReplace = Ddo_parametrotipo_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV77ddo_ParametroTipoTitleControlIdToReplace", AV77ddo_ParametroTipoTitleControlIdToReplace);
         edtavDdo_parametrotipotitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_parametrotipotitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_parametrotipotitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_parametroprioritaria_Titlecontrolidtoreplace = subGrid_Internalname+"_ParametroPrioritaria";
         ucDdo_parametroprioritaria.SendProperty(context, "", false, Ddo_parametroprioritaria_Internalname, "TitleControlIdToReplace", Ddo_parametroprioritaria_Titlecontrolidtoreplace);
         AV81ddo_ParametroPrioritariaTitleControlIdToReplace = Ddo_parametroprioritaria_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV81ddo_ParametroPrioritariaTitleControlIdToReplace", AV81ddo_ParametroPrioritariaTitleControlIdToReplace);
         edtavDdo_parametroprioritariatitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_parametroprioritariatitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_parametroprioritariatitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_parametrovalor_Titlecontrolidtoreplace = subGrid_Internalname+"_ParametroValor";
         ucDdo_parametrovalor.SendProperty(context, "", false, Ddo_parametrovalor_Internalname, "TitleControlIdToReplace", Ddo_parametrovalor_Titlecontrolidtoreplace);
         AV85ddo_ParametroValorTitleControlIdToReplace = Ddo_parametrovalor_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV85ddo_ParametroValorTitleControlIdToReplace", AV85ddo_ParametroValorTitleControlIdToReplace);
         edtavDdo_parametrovalortitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_parametrovalortitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_parametrovalortitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_parametropercentual_Titlecontrolidtoreplace = subGrid_Internalname+"_ParametroPercentual";
         ucDdo_parametropercentual.SendProperty(context, "", false, Ddo_parametropercentual_Internalname, "TitleControlIdToReplace", Ddo_parametropercentual_Titlecontrolidtoreplace);
         AV89ddo_ParametroPercentualTitleControlIdToReplace = Ddo_parametropercentual_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV89ddo_ParametroPercentualTitleControlIdToReplace", AV89ddo_ParametroPercentualTitleControlIdToReplace);
         edtavDdo_parametropercentualtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_parametropercentualtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_parametropercentualtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = " Parametro";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV90DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV90DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Ddo_gridcolumnsselector_Titlecontrolidtoreplace = bttBtneditcolumns_Internalname;
         ucDdo_gridcolumnsselector.SendProperty(context, "", false, Ddo_gridcolumnsselector_Internalname, "TitleControlIdToReplace", Ddo_gridcolumnsselector_Titlecontrolidtoreplace);
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E230V2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV62ParametroDtVigenciaIniTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV68ParametroDtVigenciaFimTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV74ParametroTipoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV78ParametroPrioritariaTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV82ParametroValorTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV86ParametroPercentualTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
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
         if ( StringUtil.StrCmp(AV51Session.Get("ParametroWWColumnsSelector"), "") != 0 )
         {
            AV32ColumnsSelectorXML = AV51Session.Get("ParametroWWColumnsSelector");
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
         edtParametroDtVigenciaIni_Visible = (((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV44ColumnsSelector.gxTpr_Columns.Item(1)).gxTpr_Isvisible ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtParametroDtVigenciaIni_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtParametroDtVigenciaIni_Visible), 5, 0)), !bGXsfl_36_Refreshing);
         edtParametroDtVigenciaFim_Visible = (((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV44ColumnsSelector.gxTpr_Columns.Item(2)).gxTpr_Isvisible ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtParametroDtVigenciaFim_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtParametroDtVigenciaFim_Visible), 5, 0)), !bGXsfl_36_Refreshing);
         cmbParametroTipo.Visible = (((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV44ColumnsSelector.gxTpr_Columns.Item(3)).gxTpr_Isvisible ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbParametroTipo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbParametroTipo.Visible), 5, 0)), !bGXsfl_36_Refreshing);
         cmbParametroPrioritaria.Visible = (((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV44ColumnsSelector.gxTpr_Columns.Item(4)).gxTpr_Isvisible ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbParametroPrioritaria_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbParametroPrioritaria.Visible), 5, 0)), !bGXsfl_36_Refreshing);
         edtParametroValor_Visible = (((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV44ColumnsSelector.gxTpr_Columns.Item(5)).gxTpr_Isvisible ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtParametroValor_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtParametroValor_Visible), 5, 0)), !bGXsfl_36_Refreshing);
         edtParametroPercentual_Visible = (((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV44ColumnsSelector.gxTpr_Columns.Item(6)).gxTpr_Isvisible ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtParametroPercentual_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtParametroPercentual_Visible), 5, 0)), !bGXsfl_36_Refreshing);
         edtParametroDtVigenciaIni_Titleformat = 2;
         edtParametroDtVigenciaIni_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Vigência Inicial", AV67ddo_ParametroDtVigenciaIniTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtParametroDtVigenciaIni_Internalname, "Title", edtParametroDtVigenciaIni_Title, !bGXsfl_36_Refreshing);
         edtParametroDtVigenciaFim_Titleformat = 2;
         edtParametroDtVigenciaFim_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Vigência Final", AV73ddo_ParametroDtVigenciaFimTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtParametroDtVigenciaFim_Internalname, "Title", edtParametroDtVigenciaFim_Title, !bGXsfl_36_Refreshing);
         cmbParametroTipo_Titleformat = 2;
         cmbParametroTipo.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Tipo", AV77ddo_ParametroTipoTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbParametroTipo_Internalname, "Title", cmbParametroTipo.Title.Text, !bGXsfl_36_Refreshing);
         cmbParametroPrioritaria_Titleformat = 2;
         cmbParametroPrioritaria.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Prioritaria", AV81ddo_ParametroPrioritariaTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbParametroPrioritaria_Internalname, "Title", cmbParametroPrioritaria.Title.Text, !bGXsfl_36_Refreshing);
         edtParametroValor_Titleformat = 2;
         edtParametroValor_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Valor", AV85ddo_ParametroValorTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtParametroValor_Internalname, "Title", edtParametroValor_Title, !bGXsfl_36_Refreshing);
         edtParametroPercentual_Titleformat = 2;
         edtParametroPercentual_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Percentual", AV89ddo_ParametroPercentualTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtParametroPercentual_Internalname, "Title", edtParametroPercentual_Title, !bGXsfl_36_Refreshing);
         AV92GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV92GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV92GridCurrentPage), 10, 0)));
         AV93GridPageCount = subGrid_Pagecount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV93GridPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV93GridPageCount), 10, 0)));
         AV98ParametroWWDS_1_Tfparametrodtvigenciaini = AV63TFParametroDtVigenciaIni;
         AV99ParametroWWDS_2_Tfparametrodtvigenciaini_to = AV64TFParametroDtVigenciaIni_To;
         AV100ParametroWWDS_3_Tfparametrodtvigenciafim = AV69TFParametroDtVigenciaFim;
         AV101ParametroWWDS_4_Tfparametrodtvigenciafim_to = AV70TFParametroDtVigenciaFim_To;
         AV102ParametroWWDS_5_Tfparametrotipo_sels = AV76TFParametroTipo_Sels;
         AV103ParametroWWDS_6_Tfparametroprioritaria_sels = AV80TFParametroPrioritaria_Sels;
         AV104ParametroWWDS_7_Tfparametrovalor = AV83TFParametroValor;
         AV105ParametroWWDS_8_Tfparametrovalor_to = AV84TFParametroValor_To;
         AV106ParametroWWDS_9_Tfparametropercentual = AV87TFParametroPercentual;
         AV107ParametroWWDS_10_Tfparametropercentual_to = AV88TFParametroPercentual_To;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62ParametroDtVigenciaIniTitleFilterData", AV62ParametroDtVigenciaIniTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68ParametroDtVigenciaFimTitleFilterData", AV68ParametroDtVigenciaFimTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV74ParametroTipoTitleFilterData", AV74ParametroTipoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78ParametroPrioritariaTitleFilterData", AV78ParametroPrioritariaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV82ParametroValorTitleFilterData", AV82ParametroValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86ParametroPercentualTitleFilterData", AV86ParametroPercentualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E120V2( )
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
            AV91PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV91PageToGo) ;
         }
      }

      protected void E130V2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E140V2( )
      {
         /* Ddo_parametrodtvigenciaini_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_parametrodtvigenciaini_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_parametrodtvigenciaini_Sortedstatus = "ASC";
            ucDdo_parametrodtvigenciaini.SendProperty(context, "", false, Ddo_parametrodtvigenciaini_Internalname, "SortedStatus", Ddo_parametrodtvigenciaini_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_parametrodtvigenciaini_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_parametrodtvigenciaini_Sortedstatus = "DSC";
            ucDdo_parametrodtvigenciaini.SendProperty(context, "", false, Ddo_parametrodtvigenciaini_Internalname, "SortedStatus", Ddo_parametrodtvigenciaini_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_parametrodtvigenciaini_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV63TFParametroDtVigenciaIni = context.localUtil.CToD( Ddo_parametrodtvigenciaini_Filteredtext_get, 2);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV63TFParametroDtVigenciaIni", context.localUtil.Format(AV63TFParametroDtVigenciaIni, "99/99/99"));
            AV64TFParametroDtVigenciaIni_To = context.localUtil.CToD( Ddo_parametrodtvigenciaini_Filteredtextto_get, 2);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV64TFParametroDtVigenciaIni_To", context.localUtil.Format(AV64TFParametroDtVigenciaIni_To, "99/99/99"));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62ParametroDtVigenciaIniTitleFilterData", AV62ParametroDtVigenciaIniTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68ParametroDtVigenciaFimTitleFilterData", AV68ParametroDtVigenciaFimTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV74ParametroTipoTitleFilterData", AV74ParametroTipoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78ParametroPrioritariaTitleFilterData", AV78ParametroPrioritariaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV82ParametroValorTitleFilterData", AV82ParametroValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86ParametroPercentualTitleFilterData", AV86ParametroPercentualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E150V2( )
      {
         /* Ddo_parametrodtvigenciafim_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_parametrodtvigenciafim_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_parametrodtvigenciafim_Sortedstatus = "ASC";
            ucDdo_parametrodtvigenciafim.SendProperty(context, "", false, Ddo_parametrodtvigenciafim_Internalname, "SortedStatus", Ddo_parametrodtvigenciafim_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_parametrodtvigenciafim_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_parametrodtvigenciafim_Sortedstatus = "DSC";
            ucDdo_parametrodtvigenciafim.SendProperty(context, "", false, Ddo_parametrodtvigenciafim_Internalname, "SortedStatus", Ddo_parametrodtvigenciafim_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_parametrodtvigenciafim_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV69TFParametroDtVigenciaFim = context.localUtil.CToD( Ddo_parametrodtvigenciafim_Filteredtext_get, 2);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV69TFParametroDtVigenciaFim", context.localUtil.Format(AV69TFParametroDtVigenciaFim, "99/99/99"));
            AV70TFParametroDtVigenciaFim_To = context.localUtil.CToD( Ddo_parametrodtvigenciafim_Filteredtextto_get, 2);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV70TFParametroDtVigenciaFim_To", context.localUtil.Format(AV70TFParametroDtVigenciaFim_To, "99/99/99"));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62ParametroDtVigenciaIniTitleFilterData", AV62ParametroDtVigenciaIniTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68ParametroDtVigenciaFimTitleFilterData", AV68ParametroDtVigenciaFimTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV74ParametroTipoTitleFilterData", AV74ParametroTipoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78ParametroPrioritariaTitleFilterData", AV78ParametroPrioritariaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV82ParametroValorTitleFilterData", AV82ParametroValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86ParametroPercentualTitleFilterData", AV86ParametroPercentualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E160V2( )
      {
         /* Ddo_parametrotipo_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_parametrotipo_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_parametrotipo_Sortedstatus = "ASC";
            ucDdo_parametrotipo.SendProperty(context, "", false, Ddo_parametrotipo_Internalname, "SortedStatus", Ddo_parametrotipo_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_parametrotipo_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_parametrotipo_Sortedstatus = "DSC";
            ucDdo_parametrotipo.SendProperty(context, "", false, Ddo_parametrotipo_Internalname, "SortedStatus", Ddo_parametrotipo_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_parametrotipo_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV75TFParametroTipo_SelsJson = Ddo_parametrotipo_Selectedvalue_get;
            AV76TFParametroTipo_Sels.FromJSonString(AV75TFParametroTipo_SelsJson, null);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV76TFParametroTipo_Sels", AV76TFParametroTipo_Sels);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62ParametroDtVigenciaIniTitleFilterData", AV62ParametroDtVigenciaIniTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68ParametroDtVigenciaFimTitleFilterData", AV68ParametroDtVigenciaFimTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV74ParametroTipoTitleFilterData", AV74ParametroTipoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78ParametroPrioritariaTitleFilterData", AV78ParametroPrioritariaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV82ParametroValorTitleFilterData", AV82ParametroValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86ParametroPercentualTitleFilterData", AV86ParametroPercentualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E170V2( )
      {
         /* Ddo_parametroprioritaria_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_parametroprioritaria_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_parametroprioritaria_Sortedstatus = "ASC";
            ucDdo_parametroprioritaria.SendProperty(context, "", false, Ddo_parametroprioritaria_Internalname, "SortedStatus", Ddo_parametroprioritaria_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_parametroprioritaria_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_parametroprioritaria_Sortedstatus = "DSC";
            ucDdo_parametroprioritaria.SendProperty(context, "", false, Ddo_parametroprioritaria_Internalname, "SortedStatus", Ddo_parametroprioritaria_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_parametroprioritaria_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV79TFParametroPrioritaria_SelsJson = Ddo_parametroprioritaria_Selectedvalue_get;
            AV80TFParametroPrioritaria_Sels.FromJSonString(AV79TFParametroPrioritaria_SelsJson, null);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV80TFParametroPrioritaria_Sels", AV80TFParametroPrioritaria_Sels);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62ParametroDtVigenciaIniTitleFilterData", AV62ParametroDtVigenciaIniTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68ParametroDtVigenciaFimTitleFilterData", AV68ParametroDtVigenciaFimTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV74ParametroTipoTitleFilterData", AV74ParametroTipoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78ParametroPrioritariaTitleFilterData", AV78ParametroPrioritariaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV82ParametroValorTitleFilterData", AV82ParametroValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86ParametroPercentualTitleFilterData", AV86ParametroPercentualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E180V2( )
      {
         /* Ddo_parametrovalor_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_parametrovalor_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_parametrovalor_Sortedstatus = "ASC";
            ucDdo_parametrovalor.SendProperty(context, "", false, Ddo_parametrovalor_Internalname, "SortedStatus", Ddo_parametrovalor_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_parametrovalor_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_parametrovalor_Sortedstatus = "DSC";
            ucDdo_parametrovalor.SendProperty(context, "", false, Ddo_parametrovalor_Internalname, "SortedStatus", Ddo_parametrovalor_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_parametrovalor_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV83TFParametroValor = NumberUtil.Val( Ddo_parametrovalor_Filteredtext_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV83TFParametroValor", StringUtil.LTrim( StringUtil.Str( AV83TFParametroValor, 12, 2)));
            AV84TFParametroValor_To = NumberUtil.Val( Ddo_parametrovalor_Filteredtextto_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV84TFParametroValor_To", StringUtil.LTrim( StringUtil.Str( AV84TFParametroValor_To, 12, 2)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62ParametroDtVigenciaIniTitleFilterData", AV62ParametroDtVigenciaIniTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68ParametroDtVigenciaFimTitleFilterData", AV68ParametroDtVigenciaFimTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV74ParametroTipoTitleFilterData", AV74ParametroTipoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78ParametroPrioritariaTitleFilterData", AV78ParametroPrioritariaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV82ParametroValorTitleFilterData", AV82ParametroValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86ParametroPercentualTitleFilterData", AV86ParametroPercentualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E190V2( )
      {
         /* Ddo_parametropercentual_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_parametropercentual_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_parametropercentual_Sortedstatus = "ASC";
            ucDdo_parametropercentual.SendProperty(context, "", false, Ddo_parametropercentual_Internalname, "SortedStatus", Ddo_parametropercentual_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_parametropercentual_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_parametropercentual_Sortedstatus = "DSC";
            ucDdo_parametropercentual.SendProperty(context, "", false, Ddo_parametropercentual_Internalname, "SortedStatus", Ddo_parametropercentual_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_parametropercentual_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV87TFParametroPercentual = NumberUtil.Val( Ddo_parametropercentual_Filteredtext_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV87TFParametroPercentual", StringUtil.LTrim( StringUtil.Str( AV87TFParametroPercentual, 6, 2)));
            AV88TFParametroPercentual_To = NumberUtil.Val( Ddo_parametropercentual_Filteredtextto_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV88TFParametroPercentual_To", StringUtil.LTrim( StringUtil.Str( AV88TFParametroPercentual_To, 6, 2)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62ParametroDtVigenciaIniTitleFilterData", AV62ParametroDtVigenciaIniTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68ParametroDtVigenciaFimTitleFilterData", AV68ParametroDtVigenciaFimTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV74ParametroTipoTitleFilterData", AV74ParametroTipoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78ParametroPrioritariaTitleFilterData", AV78ParametroPrioritariaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV82ParametroValorTitleFilterData", AV82ParametroValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86ParametroPercentualTitleFilterData", AV86ParametroPercentualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      private void E240V2( )
      {
         /* Grid_Load Routine */
         AV94Update = "<i class=\"fa fa-pen\"></i>";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUpdate_Internalname, AV94Update);
         edtavUpdate_Link = formatLink("parametro.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A13ParametroID);
         AV95Delete = "<i class=\"fa fa-times\"></i>";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDelete_Internalname, AV95Delete);
         edtavDelete_Link = formatLink("parametro.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A13ParametroID);
         edtParametroDtVigenciaIni_Link = formatLink("parametroview.aspx") + "?" + UrlEncode("" +A13ParametroID) + "," + UrlEncode(StringUtil.RTrim(""));
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 36;
         }
         sendrow_362( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_36_Refreshing )
         {
            context.DoAjaxLoad(36, GridRow);
         }
         /*  Sending Event outputs  */
      }

      protected void E200V2( )
      {
         /* Ddo_gridcolumnsselector_Oncolumnschanged Routine */
         AV32ColumnsSelectorXML = Ddo_gridcolumnsselector_Columnsselectorvalues;
         AV44ColumnsSelector.FromJSonString(AV32ColumnsSelectorXML, null);
         new GeneXus.Programs.wwpbaseobjects.savecolumnsselectorstate(context ).execute(  "ParametroWWColumnsSelector",  AV44ColumnsSelector.ToXml(false, true, "WWPColumnsSelector", "FMX")) ;
         context.DoAjaxRefresh();
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62ParametroDtVigenciaIniTitleFilterData", AV62ParametroDtVigenciaIniTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68ParametroDtVigenciaFimTitleFilterData", AV68ParametroDtVigenciaFimTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV74ParametroTipoTitleFilterData", AV74ParametroTipoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78ParametroPrioritariaTitleFilterData", AV78ParametroPrioritariaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV82ParametroValorTitleFilterData", AV82ParametroValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86ParametroPercentualTitleFilterData", AV86ParametroPercentualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E110V2( )
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
            context.PopUp(formatLink("wwpbaseobjects.savefilteras.aspx") + "?" + UrlEncode(StringUtil.RTrim("ParametroWWFilters")) + "," + UrlEncode(StringUtil.RTrim(AV108Pgmname+"GridState")), new Object[] {});
            AV52ManageFiltersExecutionStep = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV52ManageFiltersExecutionStep", StringUtil.Str( (decimal)(AV52ManageFiltersExecutionStep), 1, 0));
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_managefilters_Activeeventkey, "<#Manage#>") == 0 )
         {
            context.PopUp(formatLink("wwpbaseobjects.managefilters.aspx") + "?" + UrlEncode(StringUtil.RTrim("ParametroWWFilters")), new Object[] {});
            AV52ManageFiltersExecutionStep = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV52ManageFiltersExecutionStep", StringUtil.Str( (decimal)(AV52ManageFiltersExecutionStep), 1, 0));
            context.DoAjaxRefresh();
         }
         else
         {
            GXt_char2 = AV53ManageFiltersXml;
            new GeneXus.Programs.wwpbaseobjects.getfilterbyname(context ).execute(  "ParametroWWFilters",  Ddo_managefilters_Activeeventkey, out  GXt_char2) ;
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
               new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV108Pgmname+"GridState",  AV53ManageFiltersXml) ;
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
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV76TFParametroTipo_Sels", AV76TFParametroTipo_Sels);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV80TFParametroPrioritaria_Sels", AV80TFParametroPrioritaria_Sels);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62ParametroDtVigenciaIniTitleFilterData", AV62ParametroDtVigenciaIniTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68ParametroDtVigenciaFimTitleFilterData", AV68ParametroDtVigenciaFimTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV74ParametroTipoTitleFilterData", AV74ParametroTipoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78ParametroPrioritariaTitleFilterData", AV78ParametroPrioritariaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV82ParametroValorTitleFilterData", AV82ParametroValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86ParametroPercentualTitleFilterData", AV86ParametroPercentualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44ColumnsSelector", AV44ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56ManageFiltersData", AV56ManageFiltersData);
      }

      protected void E210V2( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("parametro.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
         context.wjLocDisableFrm = 1;
      }

      protected void S172( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
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
         if ( AV13OrderedBy == 1 )
         {
            Ddo_parametrodtvigenciaini_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_parametrodtvigenciaini.SendProperty(context, "", false, Ddo_parametrodtvigenciaini_Internalname, "SortedStatus", Ddo_parametrodtvigenciaini_Sortedstatus);
         }
         else if ( AV13OrderedBy == 2 )
         {
            Ddo_parametrodtvigenciafim_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_parametrodtvigenciafim.SendProperty(context, "", false, Ddo_parametrodtvigenciafim_Internalname, "SortedStatus", Ddo_parametrodtvigenciafim_Sortedstatus);
         }
         else if ( AV13OrderedBy == 3 )
         {
            Ddo_parametrotipo_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_parametrotipo.SendProperty(context, "", false, Ddo_parametrotipo_Internalname, "SortedStatus", Ddo_parametrotipo_Sortedstatus);
         }
         else if ( AV13OrderedBy == 4 )
         {
            Ddo_parametroprioritaria_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_parametroprioritaria.SendProperty(context, "", false, Ddo_parametroprioritaria_Internalname, "SortedStatus", Ddo_parametroprioritaria_Sortedstatus);
         }
         else if ( AV13OrderedBy == 5 )
         {
            Ddo_parametrovalor_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_parametrovalor.SendProperty(context, "", false, Ddo_parametrovalor_Internalname, "SortedStatus", Ddo_parametrovalor_Sortedstatus);
         }
         else if ( AV13OrderedBy == 6 )
         {
            Ddo_parametropercentual_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_parametropercentual.SendProperty(context, "", false, Ddo_parametropercentual_Internalname, "SortedStatus", Ddo_parametropercentual_Sortedstatus);
         }
      }

      protected void S162( )
      {
         /* 'INITIALIZECOLUMNSSELECTOR' Routine */
         AV44ColumnsSelector = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector(context);
         new GeneXus.Programs.wwpbaseobjects.wwp_columnsselector_add(context ).execute( ref  AV44ColumnsSelector,  "Vigência Inicial",  true) ;
         new GeneXus.Programs.wwpbaseobjects.wwp_columnsselector_add(context ).execute( ref  AV44ColumnsSelector,  "Vigência Final",  true) ;
         new GeneXus.Programs.wwpbaseobjects.wwp_columnsselector_add(context ).execute( ref  AV44ColumnsSelector,  "Tipo",  true) ;
         new GeneXus.Programs.wwpbaseobjects.wwp_columnsselector_add(context ).execute( ref  AV44ColumnsSelector,  "Prioritaria",  true) ;
         new GeneXus.Programs.wwpbaseobjects.wwp_columnsselector_add(context ).execute( ref  AV44ColumnsSelector,  "Valor",  true) ;
         new GeneXus.Programs.wwpbaseobjects.wwp_columnsselector_add(context ).execute( ref  AV44ColumnsSelector,  "Percentual",  true) ;
         GXt_char2 = AV39UserCustomValue;
         new GeneXus.Programs.wwpbaseobjects.loadcolumnsselectorstate(context ).execute(  "ParametroWWColumnsSelector", out  GXt_char2) ;
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
         AV54ManageFiltersItems.FromXml(new GeneXus.Programs.wwpbaseobjects.loadmanagefiltersstate(context).executeUdp(  "ParametroWWFilters"), null, "Items", "");
         AV109GXV1 = 1;
         while ( AV109GXV1 <= AV54ManageFiltersItems.Count )
         {
            AV55ManageFiltersItem = ((GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item)AV54ManageFiltersItems.Item(AV109GXV1));
            AV57ManageFiltersDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
            AV57ManageFiltersDataItem.gxTpr_Title = AV55ManageFiltersItem.gxTpr_Title;
            AV57ManageFiltersDataItem.gxTpr_Eventkey = AV55ManageFiltersItem.gxTpr_Title;
            AV57ManageFiltersDataItem.gxTpr_Isdivider = false;
            AV56ManageFiltersData.Add(AV57ManageFiltersDataItem, 0);
            if ( AV56ManageFiltersData.Count == 13 )
            {
               if (true) break;
            }
            AV109GXV1 = (int)(AV109GXV1+1);
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
         AV63TFParametroDtVigenciaIni = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV63TFParametroDtVigenciaIni", context.localUtil.Format(AV63TFParametroDtVigenciaIni, "99/99/99"));
         Ddo_parametrodtvigenciaini_Filteredtext_set = "";
         ucDdo_parametrodtvigenciaini.SendProperty(context, "", false, Ddo_parametrodtvigenciaini_Internalname, "FilteredText_set", Ddo_parametrodtvigenciaini_Filteredtext_set);
         AV64TFParametroDtVigenciaIni_To = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV64TFParametroDtVigenciaIni_To", context.localUtil.Format(AV64TFParametroDtVigenciaIni_To, "99/99/99"));
         Ddo_parametrodtvigenciaini_Filteredtextto_set = "";
         ucDdo_parametrodtvigenciaini.SendProperty(context, "", false, Ddo_parametrodtvigenciaini_Internalname, "FilteredTextTo_set", Ddo_parametrodtvigenciaini_Filteredtextto_set);
         AV69TFParametroDtVigenciaFim = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV69TFParametroDtVigenciaFim", context.localUtil.Format(AV69TFParametroDtVigenciaFim, "99/99/99"));
         Ddo_parametrodtvigenciafim_Filteredtext_set = "";
         ucDdo_parametrodtvigenciafim.SendProperty(context, "", false, Ddo_parametrodtvigenciafim_Internalname, "FilteredText_set", Ddo_parametrodtvigenciafim_Filteredtext_set);
         AV70TFParametroDtVigenciaFim_To = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV70TFParametroDtVigenciaFim_To", context.localUtil.Format(AV70TFParametroDtVigenciaFim_To, "99/99/99"));
         Ddo_parametrodtvigenciafim_Filteredtextto_set = "";
         ucDdo_parametrodtvigenciafim.SendProperty(context, "", false, Ddo_parametrodtvigenciafim_Internalname, "FilteredTextTo_set", Ddo_parametrodtvigenciafim_Filteredtextto_set);
         AV76TFParametroTipo_Sels = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         Ddo_parametrotipo_Selectedvalue_set = "";
         ucDdo_parametrotipo.SendProperty(context, "", false, Ddo_parametrotipo_Internalname, "SelectedValue_set", Ddo_parametrotipo_Selectedvalue_set);
         AV80TFParametroPrioritaria_Sels = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         Ddo_parametroprioritaria_Selectedvalue_set = "";
         ucDdo_parametroprioritaria.SendProperty(context, "", false, Ddo_parametroprioritaria_Internalname, "SelectedValue_set", Ddo_parametroprioritaria_Selectedvalue_set);
         AV83TFParametroValor = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV83TFParametroValor", StringUtil.LTrim( StringUtil.Str( AV83TFParametroValor, 12, 2)));
         Ddo_parametrovalor_Filteredtext_set = "";
         ucDdo_parametrovalor.SendProperty(context, "", false, Ddo_parametrovalor_Internalname, "FilteredText_set", Ddo_parametrovalor_Filteredtext_set);
         AV84TFParametroValor_To = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV84TFParametroValor_To", StringUtil.LTrim( StringUtil.Str( AV84TFParametroValor_To, 12, 2)));
         Ddo_parametrovalor_Filteredtextto_set = "";
         ucDdo_parametrovalor.SendProperty(context, "", false, Ddo_parametrovalor_Internalname, "FilteredTextTo_set", Ddo_parametrovalor_Filteredtextto_set);
         AV87TFParametroPercentual = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV87TFParametroPercentual", StringUtil.LTrim( StringUtil.Str( AV87TFParametroPercentual, 6, 2)));
         Ddo_parametropercentual_Filteredtext_set = "";
         ucDdo_parametropercentual.SendProperty(context, "", false, Ddo_parametropercentual_Internalname, "FilteredText_set", Ddo_parametropercentual_Filteredtext_set);
         AV88TFParametroPercentual_To = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV88TFParametroPercentual_To", StringUtil.LTrim( StringUtil.Str( AV88TFParametroPercentual_To, 6, 2)));
         Ddo_parametropercentual_Filteredtextto_set = "";
         ucDdo_parametropercentual.SendProperty(context, "", false, Ddo_parametropercentual_Internalname, "FilteredTextTo_set", Ddo_parametropercentual_Filteredtextto_set);
      }

      protected void S132( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV51Session.Get(AV108Pgmname+"GridState"), "") == 0 )
         {
            AV10GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV108Pgmname+"GridState"), null, "WWPGridState", "FMX");
         }
         else
         {
            AV10GridState.FromXml(AV51Session.Get(AV108Pgmname+"GridState"), null, "WWPGridState", "FMX");
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
         AV110GXV2 = 1;
         while ( AV110GXV2 <= AV10GridState.gxTpr_Filtervalues.Count )
         {
            AV11GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV10GridState.gxTpr_Filtervalues.Item(AV110GXV2));
            if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFPARAMETRODTVIGENCIAINI") == 0 )
            {
               AV63TFParametroDtVigenciaIni = context.localUtil.CToD( AV11GridStateFilterValue.gxTpr_Value, 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV63TFParametroDtVigenciaIni", context.localUtil.Format(AV63TFParametroDtVigenciaIni, "99/99/99"));
               AV64TFParametroDtVigenciaIni_To = context.localUtil.CToD( AV11GridStateFilterValue.gxTpr_Valueto, 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV64TFParametroDtVigenciaIni_To", context.localUtil.Format(AV64TFParametroDtVigenciaIni_To, "99/99/99"));
               if ( ! (DateTime.MinValue==AV63TFParametroDtVigenciaIni) )
               {
                  Ddo_parametrodtvigenciaini_Filteredtext_set = context.localUtil.DToC( AV63TFParametroDtVigenciaIni, 2, "/");
                  ucDdo_parametrodtvigenciaini.SendProperty(context, "", false, Ddo_parametrodtvigenciaini_Internalname, "FilteredText_set", Ddo_parametrodtvigenciaini_Filteredtext_set);
               }
               if ( ! (DateTime.MinValue==AV64TFParametroDtVigenciaIni_To) )
               {
                  Ddo_parametrodtvigenciaini_Filteredtextto_set = context.localUtil.DToC( AV64TFParametroDtVigenciaIni_To, 2, "/");
                  ucDdo_parametrodtvigenciaini.SendProperty(context, "", false, Ddo_parametrodtvigenciaini_Internalname, "FilteredTextTo_set", Ddo_parametrodtvigenciaini_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFPARAMETRODTVIGENCIAFIM") == 0 )
            {
               AV69TFParametroDtVigenciaFim = context.localUtil.CToD( AV11GridStateFilterValue.gxTpr_Value, 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV69TFParametroDtVigenciaFim", context.localUtil.Format(AV69TFParametroDtVigenciaFim, "99/99/99"));
               AV70TFParametroDtVigenciaFim_To = context.localUtil.CToD( AV11GridStateFilterValue.gxTpr_Valueto, 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV70TFParametroDtVigenciaFim_To", context.localUtil.Format(AV70TFParametroDtVigenciaFim_To, "99/99/99"));
               if ( ! (DateTime.MinValue==AV69TFParametroDtVigenciaFim) )
               {
                  Ddo_parametrodtvigenciafim_Filteredtext_set = context.localUtil.DToC( AV69TFParametroDtVigenciaFim, 2, "/");
                  ucDdo_parametrodtvigenciafim.SendProperty(context, "", false, Ddo_parametrodtvigenciafim_Internalname, "FilteredText_set", Ddo_parametrodtvigenciafim_Filteredtext_set);
               }
               if ( ! (DateTime.MinValue==AV70TFParametroDtVigenciaFim_To) )
               {
                  Ddo_parametrodtvigenciafim_Filteredtextto_set = context.localUtil.DToC( AV70TFParametroDtVigenciaFim_To, 2, "/");
                  ucDdo_parametrodtvigenciafim.SendProperty(context, "", false, Ddo_parametrodtvigenciafim_Internalname, "FilteredTextTo_set", Ddo_parametrodtvigenciafim_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFPARAMETROTIPO_SEL") == 0 )
            {
               AV75TFParametroTipo_SelsJson = AV11GridStateFilterValue.gxTpr_Value;
               AV76TFParametroTipo_Sels.FromJSonString(AV75TFParametroTipo_SelsJson, null);
               if ( ! ( AV76TFParametroTipo_Sels.Count == 0 ) )
               {
                  Ddo_parametrotipo_Selectedvalue_set = AV75TFParametroTipo_SelsJson;
                  ucDdo_parametrotipo.SendProperty(context, "", false, Ddo_parametrotipo_Internalname, "SelectedValue_set", Ddo_parametrotipo_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFPARAMETROPRIORITARIA_SEL") == 0 )
            {
               AV79TFParametroPrioritaria_SelsJson = AV11GridStateFilterValue.gxTpr_Value;
               AV80TFParametroPrioritaria_Sels.FromJSonString(AV79TFParametroPrioritaria_SelsJson, null);
               if ( ! ( AV80TFParametroPrioritaria_Sels.Count == 0 ) )
               {
                  Ddo_parametroprioritaria_Selectedvalue_set = AV79TFParametroPrioritaria_SelsJson;
                  ucDdo_parametroprioritaria.SendProperty(context, "", false, Ddo_parametroprioritaria_Internalname, "SelectedValue_set", Ddo_parametroprioritaria_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFPARAMETROVALOR") == 0 )
            {
               AV83TFParametroValor = NumberUtil.Val( AV11GridStateFilterValue.gxTpr_Value, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV83TFParametroValor", StringUtil.LTrim( StringUtil.Str( AV83TFParametroValor, 12, 2)));
               AV84TFParametroValor_To = NumberUtil.Val( AV11GridStateFilterValue.gxTpr_Valueto, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV84TFParametroValor_To", StringUtil.LTrim( StringUtil.Str( AV84TFParametroValor_To, 12, 2)));
               if ( ! (Convert.ToDecimal(0)==AV83TFParametroValor) )
               {
                  Ddo_parametrovalor_Filteredtext_set = StringUtil.Str( AV83TFParametroValor, 12, 2);
                  ucDdo_parametrovalor.SendProperty(context, "", false, Ddo_parametrovalor_Internalname, "FilteredText_set", Ddo_parametrovalor_Filteredtext_set);
               }
               if ( ! (Convert.ToDecimal(0)==AV84TFParametroValor_To) )
               {
                  Ddo_parametrovalor_Filteredtextto_set = StringUtil.Str( AV84TFParametroValor_To, 12, 2);
                  ucDdo_parametrovalor.SendProperty(context, "", false, Ddo_parametrovalor_Internalname, "FilteredTextTo_set", Ddo_parametrovalor_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFPARAMETROPERCENTUAL") == 0 )
            {
               AV87TFParametroPercentual = NumberUtil.Val( AV11GridStateFilterValue.gxTpr_Value, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV87TFParametroPercentual", StringUtil.LTrim( StringUtil.Str( AV87TFParametroPercentual, 6, 2)));
               AV88TFParametroPercentual_To = NumberUtil.Val( AV11GridStateFilterValue.gxTpr_Valueto, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV88TFParametroPercentual_To", StringUtil.LTrim( StringUtil.Str( AV88TFParametroPercentual_To, 6, 2)));
               if ( ! (Convert.ToDecimal(0)==AV87TFParametroPercentual) )
               {
                  Ddo_parametropercentual_Filteredtext_set = StringUtil.Str( AV87TFParametroPercentual, 6, 2);
                  ucDdo_parametropercentual.SendProperty(context, "", false, Ddo_parametropercentual_Internalname, "FilteredText_set", Ddo_parametropercentual_Filteredtext_set);
               }
               if ( ! (Convert.ToDecimal(0)==AV88TFParametroPercentual_To) )
               {
                  Ddo_parametropercentual_Filteredtextto_set = StringUtil.Str( AV88TFParametroPercentual_To, 6, 2);
                  ucDdo_parametropercentual.SendProperty(context, "", false, Ddo_parametropercentual_Internalname, "FilteredTextTo_set", Ddo_parametropercentual_Filteredtextto_set);
               }
            }
            AV110GXV2 = (int)(AV110GXV2+1);
         }
      }

      protected void S152( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV10GridState.FromXml(AV51Session.Get(AV108Pgmname+"GridState"), null, "WWPGridState", "FMX");
         AV10GridState.gxTpr_Orderedby = AV13OrderedBy;
         AV10GridState.gxTpr_Ordereddsc = AV14OrderedDsc;
         AV10GridState.gxTpr_Filtervalues.Clear();
         if ( ! ( (DateTime.MinValue==AV63TFParametroDtVigenciaIni) && (DateTime.MinValue==AV64TFParametroDtVigenciaIni_To) ) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFPARAMETRODTVIGENCIAINI";
            AV11GridStateFilterValue.gxTpr_Value = context.localUtil.DToC( AV63TFParametroDtVigenciaIni, 2, "/");
            AV11GridStateFilterValue.gxTpr_Valueto = context.localUtil.DToC( AV64TFParametroDtVigenciaIni_To, 2, "/");
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! ( (DateTime.MinValue==AV69TFParametroDtVigenciaFim) && (DateTime.MinValue==AV70TFParametroDtVigenciaFim_To) ) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFPARAMETRODTVIGENCIAFIM";
            AV11GridStateFilterValue.gxTpr_Value = context.localUtil.DToC( AV69TFParametroDtVigenciaFim, 2, "/");
            AV11GridStateFilterValue.gxTpr_Valueto = context.localUtil.DToC( AV70TFParametroDtVigenciaFim_To, 2, "/");
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! ( AV76TFParametroTipo_Sels.Count == 0 ) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFPARAMETROTIPO_SEL";
            AV11GridStateFilterValue.gxTpr_Value = AV76TFParametroTipo_Sels.ToJSonString(false);
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! ( AV80TFParametroPrioritaria_Sels.Count == 0 ) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFPARAMETROPRIORITARIA_SEL";
            AV11GridStateFilterValue.gxTpr_Value = AV80TFParametroPrioritaria_Sels.ToJSonString(false);
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! ( (Convert.ToDecimal(0)==AV83TFParametroValor) && (Convert.ToDecimal(0)==AV84TFParametroValor_To) ) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFPARAMETROVALOR";
            AV11GridStateFilterValue.gxTpr_Value = StringUtil.Str( AV83TFParametroValor, 12, 2);
            AV11GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( AV84TFParametroValor_To, 12, 2);
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! ( (Convert.ToDecimal(0)==AV87TFParametroPercentual) && (Convert.ToDecimal(0)==AV88TFParametroPercentual_To) ) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFPARAMETROPERCENTUAL";
            AV11GridStateFilterValue.gxTpr_Value = StringUtil.Str( AV87TFParametroPercentual, 6, 2);
            AV11GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( AV88TFParametroPercentual_To, 6, 2);
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         AV10GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV10GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV108Pgmname+"GridState",  AV10GridState.ToXml(false, true, "WWPGridState", "FMX")) ;
      }

      protected void S122( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV8TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV8TrnContext.gxTpr_Callerobject = AV108Pgmname;
         AV8TrnContext.gxTpr_Callerondelete = true;
         AV8TrnContext.gxTpr_Callerurl = AV7HTTPRequest.ScriptName+"?"+AV7HTTPRequest.QueryString;
         AV8TrnContext.gxTpr_Transactionname = "Parametro";
         AV51Session.Set("TrnContext", AV8TrnContext.ToXml(false, true, "WWPTransactionContext", "FMX"));
      }

      protected void wb_table1_23_0V2( bool wbgen )
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
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_23_0V2e( true) ;
         }
         else
         {
            wb_table1_23_0V2e( false) ;
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
         PA0V2( ) ;
         WS0V2( ) ;
         WE0V2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201971121385938", true, true);
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
         context.AddJavascriptSource("parametroww.js", "?201971121385938", false, true);
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
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false, true);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_362( )
      {
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_36_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_36_idx;
         edtParametroID_Internalname = "PARAMETROID_"+sGXsfl_36_idx;
         edtParametroDtVigenciaIni_Internalname = "PARAMETRODTVIGENCIAINI_"+sGXsfl_36_idx;
         edtParametroDtVigenciaFim_Internalname = "PARAMETRODTVIGENCIAFIM_"+sGXsfl_36_idx;
         cmbParametroTipo_Internalname = "PARAMETROTIPO_"+sGXsfl_36_idx;
         cmbParametroPrioritaria_Internalname = "PARAMETROPRIORITARIA_"+sGXsfl_36_idx;
         edtParametroValor_Internalname = "PARAMETROVALOR_"+sGXsfl_36_idx;
         edtParametroPercentual_Internalname = "PARAMETROPERCENTUAL_"+sGXsfl_36_idx;
      }

      protected void SubsflControlProps_fel_362( )
      {
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_36_fel_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_36_fel_idx;
         edtParametroID_Internalname = "PARAMETROID_"+sGXsfl_36_fel_idx;
         edtParametroDtVigenciaIni_Internalname = "PARAMETRODTVIGENCIAINI_"+sGXsfl_36_fel_idx;
         edtParametroDtVigenciaFim_Internalname = "PARAMETRODTVIGENCIAFIM_"+sGXsfl_36_fel_idx;
         cmbParametroTipo_Internalname = "PARAMETROTIPO_"+sGXsfl_36_fel_idx;
         cmbParametroPrioritaria_Internalname = "PARAMETROPRIORITARIA_"+sGXsfl_36_fel_idx;
         edtParametroValor_Internalname = "PARAMETROVALOR_"+sGXsfl_36_fel_idx;
         edtParametroPercentual_Internalname = "PARAMETROPERCENTUAL_"+sGXsfl_36_fel_idx;
      }

      protected void sendrow_362( )
      {
         SubsflControlProps_362( ) ;
         WB0V0( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_36_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_36_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_36_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,StringUtil.RTrim( AV94Update),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtavUpdate_Link,(String)"",(String)"Modifica",(String)"",(String)edtavUpdate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWIconActionColumn",(String)"",(short)-1,(int)edtavUpdate_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)1,(short)36,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,StringUtil.RTrim( AV95Delete),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtavDelete_Link,(String)"",(String)"Eliminar",(String)"",(String)edtavDelete_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWIconActionColumn",(String)"",(short)-1,(int)edtavDelete_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)1,(short)36,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtParametroID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A13ParametroID), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A13ParametroID), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtParametroID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)36,(short)1,(short)-1,(short)0,(bool)true,(String)"Serial",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((edtParametroDtVigenciaIni_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtParametroDtVigenciaIni_Internalname,context.localUtil.Format(A14ParametroDtVigenciaIni, "99/99/99"),context.localUtil.Format( A14ParametroDtVigenciaIni, "99/99/99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtParametroDtVigenciaIni_Link,(String)"",(String)"",(String)"",(String)edtParametroDtVigenciaIni_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(int)edtParametroDtVigenciaIni_Visible,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)36,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((edtParametroDtVigenciaFim_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtParametroDtVigenciaFim_Internalname,context.localUtil.Format(A15ParametroDtVigenciaFim, "99/99/99"),context.localUtil.Format( A15ParametroDtVigenciaFim, "99/99/99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtParametroDtVigenciaFim_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(int)edtParametroDtVigenciaFim_Visible,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)36,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((cmbParametroTipo.Visible==0) ? "display:none;" : "")+"\">") ;
            }
            if ( ( cmbParametroTipo.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "PARAMETROTIPO_" + sGXsfl_36_idx;
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
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbParametroTipo,(String)cmbParametroTipo_Internalname,StringUtil.RTrim( A16ParametroTipo),(short)1,(String)cmbParametroTipo_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"char",(String)"",cmbParametroTipo.Visible,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn hidden-xs",(String)"",(String)"",(String)"",(bool)true});
            cmbParametroTipo.CurrentValue = StringUtil.RTrim( A16ParametroTipo);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbParametroTipo_Internalname, "Values", (String)(cmbParametroTipo.ToJavascriptSource()), !bGXsfl_36_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((cmbParametroPrioritaria.Visible==0) ? "display:none;" : "")+"\">") ;
            }
            if ( ( cmbParametroPrioritaria.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "PARAMETROPRIORITARIA_" + sGXsfl_36_idx;
               cmbParametroPrioritaria.Name = GXCCtl;
               cmbParametroPrioritaria.WebTags = "";
               cmbParametroPrioritaria.addItem("S", "Sim", 0);
               cmbParametroPrioritaria.addItem("N", "Não", 0);
               if ( cmbParametroPrioritaria.ItemCount > 0 )
               {
                  A17ParametroPrioritaria = cmbParametroPrioritaria.getValidValue(A17ParametroPrioritaria);
               }
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbParametroPrioritaria,(String)cmbParametroPrioritaria_Internalname,StringUtil.RTrim( A17ParametroPrioritaria),(short)1,(String)cmbParametroPrioritaria_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"char",(String)"",cmbParametroPrioritaria.Visible,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn hidden-xs",(String)"",(String)"",(String)"",(bool)true});
            cmbParametroPrioritaria.CurrentValue = StringUtil.RTrim( A17ParametroPrioritaria);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbParametroPrioritaria_Internalname, "Values", (String)(cmbParametroPrioritaria.ToJavascriptSource()), !bGXsfl_36_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((edtParametroValor_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtParametroValor_Internalname,StringUtil.LTrim( StringUtil.NToC( A18ParametroValor, 14, 2, ",", "")),context.localUtil.Format( A18ParametroValor, "ZZZ,ZZZ,ZZ9.99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtParametroValor_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(int)edtParametroValor_Visible,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)14,(short)0,(short)0,(short)36,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((edtParametroPercentual_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtParametroPercentual_Internalname,StringUtil.LTrim( StringUtil.NToC( A19ParametroPercentual, 6, 2, ",", "")),context.localUtil.Format( A19ParametroPercentual, "ZZ9.99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtParametroPercentual_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(int)edtParametroPercentual_Visible,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)6,(short)0,(short)0,(short)36,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            send_integrity_lvl_hashes0V2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_36_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_36_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_36_idx+1));
            sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0");
            SubsflControlProps_362( ) ;
         }
         /* End function sendrow_362 */
      }

      protected void init_web_controls( )
      {
         GXCCtl = "PARAMETROTIPO_" + sGXsfl_36_idx;
         cmbParametroTipo.Name = GXCCtl;
         cmbParametroTipo.WebTags = "";
         cmbParametroTipo.addItem("D", "Desconto", 0);
         cmbParametroTipo.addItem("F", "Frete", 0);
         if ( cmbParametroTipo.ItemCount > 0 )
         {
            A16ParametroTipo = cmbParametroTipo.getValidValue(A16ParametroTipo);
         }
         GXCCtl = "PARAMETROPRIORITARIA_" + sGXsfl_36_idx;
         cmbParametroPrioritaria.Name = GXCCtl;
         cmbParametroPrioritaria.WebTags = "";
         cmbParametroPrioritaria.addItem("S", "Sim", 0);
         cmbParametroPrioritaria.addItem("N", "Não", 0);
         if ( cmbParametroPrioritaria.ItemCount > 0 )
         {
            A17ParametroPrioritaria = cmbParametroPrioritaria.getValidValue(A17ParametroPrioritaria);
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttBtninsert_Internalname = "BTNINSERT";
         bttBtneditcolumns_Internalname = "BTNEDITCOLUMNS";
         divTableactions_Internalname = "TABLEACTIONS";
         Ddo_managefilters_Internalname = "DDO_MANAGEFILTERS";
         tblTablerightheader_Internalname = "TABLERIGHTHEADER";
         divTableheader_Internalname = "TABLEHEADER";
         Dvpanel_tableheader_Internalname = "DVPANEL_TABLEHEADER";
         edtavUpdate_Internalname = "vUPDATE";
         edtavDelete_Internalname = "vDELETE";
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
         Ddo_gridcolumnsselector_Internalname = "DDO_GRIDCOLUMNSSELECTOR";
         edtavOrderedby_Internalname = "vORDEREDBY";
         edtavOrdereddsc_Internalname = "vORDEREDDSC";
         edtavManagefiltersexecutionstep_Internalname = "vMANAGEFILTERSEXECUTIONSTEP";
         edtavTfparametrodtvigenciaini_Internalname = "vTFPARAMETRODTVIGENCIAINI";
         edtavTfparametrodtvigenciaini_to_Internalname = "vTFPARAMETRODTVIGENCIAINI_TO";
         edtavDdo_parametrodtvigenciainiauxdate_Internalname = "vDDO_PARAMETRODTVIGENCIAINIAUXDATE";
         edtavDdo_parametrodtvigenciainiauxdateto_Internalname = "vDDO_PARAMETRODTVIGENCIAINIAUXDATETO";
         divDdo_parametrodtvigenciainiauxdates_Internalname = "DDO_PARAMETRODTVIGENCIAINIAUXDATES";
         edtavTfparametrodtvigenciafim_Internalname = "vTFPARAMETRODTVIGENCIAFIM";
         edtavTfparametrodtvigenciafim_to_Internalname = "vTFPARAMETRODTVIGENCIAFIM_TO";
         edtavDdo_parametrodtvigenciafimauxdate_Internalname = "vDDO_PARAMETRODTVIGENCIAFIMAUXDATE";
         edtavDdo_parametrodtvigenciafimauxdateto_Internalname = "vDDO_PARAMETRODTVIGENCIAFIMAUXDATETO";
         divDdo_parametrodtvigenciafimauxdates_Internalname = "DDO_PARAMETRODTVIGENCIAFIMAUXDATES";
         edtavTfparametrovalor_Internalname = "vTFPARAMETROVALOR";
         edtavTfparametrovalor_to_Internalname = "vTFPARAMETROVALOR_TO";
         edtavTfparametropercentual_Internalname = "vTFPARAMETROPERCENTUAL";
         edtavTfparametropercentual_to_Internalname = "vTFPARAMETROPERCENTUAL_TO";
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
         edtParametroPercentual_Jsonclick = "";
         edtParametroValor_Jsonclick = "";
         cmbParametroPrioritaria_Jsonclick = "";
         cmbParametroTipo_Jsonclick = "";
         edtParametroDtVigenciaFim_Jsonclick = "";
         edtParametroDtVigenciaIni_Jsonclick = "";
         edtParametroID_Jsonclick = "";
         edtavDelete_Jsonclick = "";
         edtavUpdate_Jsonclick = "";
         edtavTfparametropercentual_to_Jsonclick = "";
         edtavTfparametropercentual_to_Visible = 1;
         edtavTfparametropercentual_Jsonclick = "";
         edtavTfparametropercentual_Visible = 1;
         edtavTfparametrovalor_to_Jsonclick = "";
         edtavTfparametrovalor_to_Visible = 1;
         edtavTfparametrovalor_Jsonclick = "";
         edtavTfparametrovalor_Visible = 1;
         edtavDdo_parametrodtvigenciafimauxdateto_Jsonclick = "";
         edtavDdo_parametrodtvigenciafimauxdate_Jsonclick = "";
         edtavTfparametrodtvigenciafim_to_Jsonclick = "";
         edtavTfparametrodtvigenciafim_to_Visible = 1;
         edtavTfparametrodtvigenciafim_Jsonclick = "";
         edtavTfparametrodtvigenciafim_Visible = 1;
         edtavDdo_parametrodtvigenciainiauxdateto_Jsonclick = "";
         edtavDdo_parametrodtvigenciainiauxdate_Jsonclick = "";
         edtavTfparametrodtvigenciaini_to_Jsonclick = "";
         edtavTfparametrodtvigenciaini_to_Visible = 1;
         edtavTfparametrodtvigenciaini_Jsonclick = "";
         edtavTfparametrodtvigenciaini_Visible = 1;
         edtavManagefiltersexecutionstep_Jsonclick = "";
         edtavManagefiltersexecutionstep_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_parametropercentualtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_parametrovalortitlecontrolidtoreplace_Visible = 1;
         edtavDdo_parametroprioritariatitlecontrolidtoreplace_Visible = 1;
         edtavDdo_parametrotipotitlecontrolidtoreplace_Visible = 1;
         edtavDdo_parametrodtvigenciafimtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_parametrodtvigenciainititlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtParametroDtVigenciaIni_Link = "";
         edtavDelete_Link = "";
         edtavUpdate_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtParametroPercentual_Titleformat = 0;
         edtParametroPercentual_Title = "Percentual";
         edtParametroPercentual_Visible = -1;
         edtParametroValor_Titleformat = 0;
         edtParametroValor_Title = "Valor";
         edtParametroValor_Visible = -1;
         cmbParametroPrioritaria_Titleformat = 0;
         cmbParametroPrioritaria.Title.Text = "Prioritaria";
         cmbParametroPrioritaria.Visible = -1;
         cmbParametroTipo_Titleformat = 0;
         cmbParametroTipo.Title.Text = "Tipo";
         cmbParametroTipo.Visible = -1;
         edtParametroDtVigenciaFim_Titleformat = 0;
         edtParametroDtVigenciaFim_Title = "Vigência Final";
         edtParametroDtVigenciaFim_Visible = -1;
         edtParametroDtVigenciaIni_Titleformat = 0;
         edtParametroDtVigenciaIni_Title = "Vigência Inicial";
         edtParametroDtVigenciaIni_Visible = -1;
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
         Ddo_parametropercentual_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_parametropercentual_Rangefilterto = "WWP_TSTo";
         Ddo_parametropercentual_Rangefilterfrom = "WWP_TSFrom";
         Ddo_parametropercentual_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_parametropercentual_Sortdsc = "WWP_TSSortDSC";
         Ddo_parametropercentual_Sortasc = "WWP_TSSortASC";
         Ddo_parametropercentual_Includedatalist = Convert.ToBoolean( 0);
         Ddo_parametropercentual_Filterisrange = Convert.ToBoolean( -1);
         Ddo_parametropercentual_Filtertype = "Numeric";
         Ddo_parametropercentual_Includefilter = Convert.ToBoolean( -1);
         Ddo_parametropercentual_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_parametropercentual_Includesortasc = Convert.ToBoolean( -1);
         Ddo_parametropercentual_Titlecontrolidtoreplace = "";
         Ddo_parametropercentual_Dropdownoptionstype = "GridTitleSettings";
         Ddo_parametropercentual_Cls = "ColumnSettings";
         Ddo_parametropercentual_Tooltip = "WWP_TSColumnOptions";
         Ddo_parametropercentual_Caption = "";
         Ddo_parametrovalor_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_parametrovalor_Rangefilterto = "WWP_TSTo";
         Ddo_parametrovalor_Rangefilterfrom = "WWP_TSFrom";
         Ddo_parametrovalor_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_parametrovalor_Sortdsc = "WWP_TSSortDSC";
         Ddo_parametrovalor_Sortasc = "WWP_TSSortASC";
         Ddo_parametrovalor_Includedatalist = Convert.ToBoolean( 0);
         Ddo_parametrovalor_Filterisrange = Convert.ToBoolean( -1);
         Ddo_parametrovalor_Filtertype = "Numeric";
         Ddo_parametrovalor_Includefilter = Convert.ToBoolean( -1);
         Ddo_parametrovalor_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_parametrovalor_Includesortasc = Convert.ToBoolean( -1);
         Ddo_parametrovalor_Titlecontrolidtoreplace = "";
         Ddo_parametrovalor_Dropdownoptionstype = "GridTitleSettings";
         Ddo_parametrovalor_Cls = "ColumnSettings";
         Ddo_parametrovalor_Tooltip = "WWP_TSColumnOptions";
         Ddo_parametrovalor_Caption = "";
         Ddo_parametroprioritaria_Searchbuttontext = "WWP_FilterSelected";
         Ddo_parametroprioritaria_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_parametroprioritaria_Sortdsc = "WWP_TSSortDSC";
         Ddo_parametroprioritaria_Sortasc = "WWP_TSSortASC";
         Ddo_parametroprioritaria_Datalistfixedvalues = "S:Sim,N:Não";
         Ddo_parametroprioritaria_Allowmultipleselection = Convert.ToBoolean( -1);
         Ddo_parametroprioritaria_Datalisttype = "FixedValues";
         Ddo_parametroprioritaria_Includedatalist = Convert.ToBoolean( -1);
         Ddo_parametroprioritaria_Includefilter = Convert.ToBoolean( 0);
         Ddo_parametroprioritaria_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_parametroprioritaria_Includesortasc = Convert.ToBoolean( -1);
         Ddo_parametroprioritaria_Titlecontrolidtoreplace = "";
         Ddo_parametroprioritaria_Dropdownoptionstype = "GridTitleSettings";
         Ddo_parametroprioritaria_Cls = "ColumnSettings";
         Ddo_parametroprioritaria_Tooltip = "WWP_TSColumnOptions";
         Ddo_parametroprioritaria_Caption = "";
         Ddo_parametrotipo_Searchbuttontext = "WWP_FilterSelected";
         Ddo_parametrotipo_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_parametrotipo_Sortdsc = "WWP_TSSortDSC";
         Ddo_parametrotipo_Sortasc = "WWP_TSSortASC";
         Ddo_parametrotipo_Datalistfixedvalues = "D:Desconto,F:Frete";
         Ddo_parametrotipo_Allowmultipleselection = Convert.ToBoolean( -1);
         Ddo_parametrotipo_Datalisttype = "FixedValues";
         Ddo_parametrotipo_Includedatalist = Convert.ToBoolean( -1);
         Ddo_parametrotipo_Includefilter = Convert.ToBoolean( 0);
         Ddo_parametrotipo_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_parametrotipo_Includesortasc = Convert.ToBoolean( -1);
         Ddo_parametrotipo_Titlecontrolidtoreplace = "";
         Ddo_parametrotipo_Dropdownoptionstype = "GridTitleSettings";
         Ddo_parametrotipo_Cls = "ColumnSettings";
         Ddo_parametrotipo_Tooltip = "WWP_TSColumnOptions";
         Ddo_parametrotipo_Caption = "";
         Ddo_parametrodtvigenciafim_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_parametrodtvigenciafim_Rangefilterto = "WWP_TSTo";
         Ddo_parametrodtvigenciafim_Rangefilterfrom = "WWP_TSFrom";
         Ddo_parametrodtvigenciafim_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_parametrodtvigenciafim_Sortdsc = "WWP_TSSortDSC";
         Ddo_parametrodtvigenciafim_Sortasc = "WWP_TSSortASC";
         Ddo_parametrodtvigenciafim_Includedatalist = Convert.ToBoolean( 0);
         Ddo_parametrodtvigenciafim_Filterisrange = Convert.ToBoolean( -1);
         Ddo_parametrodtvigenciafim_Filtertype = "Date";
         Ddo_parametrodtvigenciafim_Includefilter = Convert.ToBoolean( -1);
         Ddo_parametrodtvigenciafim_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_parametrodtvigenciafim_Includesortasc = Convert.ToBoolean( -1);
         Ddo_parametrodtvigenciafim_Titlecontrolidtoreplace = "";
         Ddo_parametrodtvigenciafim_Dropdownoptionstype = "GridTitleSettings";
         Ddo_parametrodtvigenciafim_Cls = "ColumnSettings";
         Ddo_parametrodtvigenciafim_Tooltip = "WWP_TSColumnOptions";
         Ddo_parametrodtvigenciafim_Caption = "";
         Ddo_parametrodtvigenciaini_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_parametrodtvigenciaini_Rangefilterto = "WWP_TSTo";
         Ddo_parametrodtvigenciaini_Rangefilterfrom = "WWP_TSFrom";
         Ddo_parametrodtvigenciaini_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_parametrodtvigenciaini_Sortdsc = "WWP_TSSortDSC";
         Ddo_parametrodtvigenciaini_Sortasc = "WWP_TSSortASC";
         Ddo_parametrodtvigenciaini_Includedatalist = Convert.ToBoolean( 0);
         Ddo_parametrodtvigenciaini_Filterisrange = Convert.ToBoolean( -1);
         Ddo_parametrodtvigenciaini_Filtertype = "Date";
         Ddo_parametrodtvigenciaini_Includefilter = Convert.ToBoolean( -1);
         Ddo_parametrodtvigenciaini_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_parametrodtvigenciaini_Includesortasc = Convert.ToBoolean( -1);
         Ddo_parametrodtvigenciaini_Titlecontrolidtoreplace = "";
         Ddo_parametrodtvigenciaini_Dropdownoptionstype = "GridTitleSettings";
         Ddo_parametrodtvigenciaini_Cls = "ColumnSettings";
         Ddo_parametrodtvigenciaini_Tooltip = "WWP_TSColumnOptions";
         Ddo_parametrodtvigenciaini_Caption = "";
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
         Form.Caption = " Parametro";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV67ddo_ParametroDtVigenciaIniTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAINITITLECONTROLIDTOREPLACE',pic:''},{av:'AV73ddo_ParametroDtVigenciaFimTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAFIMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_ParametroTipoTitleControlIdToReplace',fld:'vDDO_PARAMETROTIPOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_ParametroPrioritariaTitleControlIdToReplace',fld:'vDDO_PARAMETROPRIORITARIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_ParametroValorTitleControlIdToReplace',fld:'vDDO_PARAMETROVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV89ddo_ParametroPercentualTitleControlIdToReplace',fld:'vDDO_PARAMETROPERCENTUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV63TFParametroDtVigenciaIni',fld:'vTFPARAMETRODTVIGENCIAINI',pic:''},{av:'AV64TFParametroDtVigenciaIni_To',fld:'vTFPARAMETRODTVIGENCIAINI_TO',pic:''},{av:'AV69TFParametroDtVigenciaFim',fld:'vTFPARAMETRODTVIGENCIAFIM',pic:''},{av:'AV70TFParametroDtVigenciaFim_To',fld:'vTFPARAMETRODTVIGENCIAFIM_TO',pic:''},{av:'AV76TFParametroTipo_Sels',fld:'vTFPARAMETROTIPO_SELS',pic:''},{av:'AV80TFParametroPrioritaria_Sels',fld:'vTFPARAMETROPRIORITARIA_SELS',pic:''},{av:'AV83TFParametroValor',fld:'vTFPARAMETROVALOR',pic:'ZZZ,ZZZ,ZZ9.99'},{av:'AV84TFParametroValor_To',fld:'vTFPARAMETROVALOR_TO',pic:'ZZZ,ZZZ,ZZ9.99'},{av:'AV87TFParametroPercentual',fld:'vTFPARAMETROPERCENTUAL',pic:'ZZ9.99'},{av:'AV88TFParametroPercentual_To',fld:'vTFPARAMETROPERCENTUAL_TO',pic:'ZZ9.99'},{av:'AV108Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV62ParametroDtVigenciaIniTitleFilterData',fld:'vPARAMETRODTVIGENCIAINITITLEFILTERDATA',pic:''},{av:'AV68ParametroDtVigenciaFimTitleFilterData',fld:'vPARAMETRODTVIGENCIAFIMTITLEFILTERDATA',pic:''},{av:'AV74ParametroTipoTitleFilterData',fld:'vPARAMETROTIPOTITLEFILTERDATA',pic:''},{av:'AV78ParametroPrioritariaTitleFilterData',fld:'vPARAMETROPRIORITARIATITLEFILTERDATA',pic:''},{av:'AV82ParametroValorTitleFilterData',fld:'vPARAMETROVALORTITLEFILTERDATA',pic:''},{av:'AV86ParametroPercentualTitleFilterData',fld:'vPARAMETROPERCENTUALTITLEFILTERDATA',pic:''},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtParametroDtVigenciaIni_Visible',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Visible'},{av:'edtParametroDtVigenciaFim_Visible',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Visible'},{av:'cmbParametroTipo'},{av:'cmbParametroPrioritaria'},{av:'edtParametroValor_Visible',ctrl:'PARAMETROVALOR',prop:'Visible'},{av:'edtParametroPercentual_Visible',ctrl:'PARAMETROPERCENTUAL',prop:'Visible'},{av:'edtParametroDtVigenciaIni_Titleformat',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Titleformat'},{av:'edtParametroDtVigenciaIni_Title',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Title'},{av:'edtParametroDtVigenciaFim_Titleformat',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Titleformat'},{av:'edtParametroDtVigenciaFim_Title',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Title'},{av:'edtParametroValor_Titleformat',ctrl:'PARAMETROVALOR',prop:'Titleformat'},{av:'edtParametroValor_Title',ctrl:'PARAMETROVALOR',prop:'Title'},{av:'edtParametroPercentual_Titleformat',ctrl:'PARAMETROPERCENTUAL',prop:'Titleformat'},{av:'edtParametroPercentual_Title',ctrl:'PARAMETROPERCENTUAL',prop:'Title'},{av:'AV92GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV93GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E120V2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV63TFParametroDtVigenciaIni',fld:'vTFPARAMETRODTVIGENCIAINI',pic:''},{av:'AV64TFParametroDtVigenciaIni_To',fld:'vTFPARAMETRODTVIGENCIAINI_TO',pic:''},{av:'AV69TFParametroDtVigenciaFim',fld:'vTFPARAMETRODTVIGENCIAFIM',pic:''},{av:'AV70TFParametroDtVigenciaFim_To',fld:'vTFPARAMETRODTVIGENCIAFIM_TO',pic:''},{av:'AV83TFParametroValor',fld:'vTFPARAMETROVALOR',pic:'ZZZ,ZZZ,ZZ9.99'},{av:'AV84TFParametroValor_To',fld:'vTFPARAMETROVALOR_TO',pic:'ZZZ,ZZZ,ZZ9.99'},{av:'AV87TFParametroPercentual',fld:'vTFPARAMETROPERCENTUAL',pic:'ZZ9.99'},{av:'AV88TFParametroPercentual_To',fld:'vTFPARAMETROPERCENTUAL_TO',pic:'ZZ9.99'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV67ddo_ParametroDtVigenciaIniTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAINITITLECONTROLIDTOREPLACE',pic:''},{av:'AV73ddo_ParametroDtVigenciaFimTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAFIMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_ParametroTipoTitleControlIdToReplace',fld:'vDDO_PARAMETROTIPOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_ParametroPrioritariaTitleControlIdToReplace',fld:'vDDO_PARAMETROPRIORITARIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_ParametroValorTitleControlIdToReplace',fld:'vDDO_PARAMETROVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV89ddo_ParametroPercentualTitleControlIdToReplace',fld:'vDDO_PARAMETROPERCENTUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76TFParametroTipo_Sels',fld:'vTFPARAMETROTIPO_SELS',pic:''},{av:'AV80TFParametroPrioritaria_Sels',fld:'vTFPARAMETROPRIORITARIA_SELS',pic:''},{av:'AV108Pgmname',fld:'vPGMNAME',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E130V2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV63TFParametroDtVigenciaIni',fld:'vTFPARAMETRODTVIGENCIAINI',pic:''},{av:'AV64TFParametroDtVigenciaIni_To',fld:'vTFPARAMETRODTVIGENCIAINI_TO',pic:''},{av:'AV69TFParametroDtVigenciaFim',fld:'vTFPARAMETRODTVIGENCIAFIM',pic:''},{av:'AV70TFParametroDtVigenciaFim_To',fld:'vTFPARAMETRODTVIGENCIAFIM_TO',pic:''},{av:'AV83TFParametroValor',fld:'vTFPARAMETROVALOR',pic:'ZZZ,ZZZ,ZZ9.99'},{av:'AV84TFParametroValor_To',fld:'vTFPARAMETROVALOR_TO',pic:'ZZZ,ZZZ,ZZ9.99'},{av:'AV87TFParametroPercentual',fld:'vTFPARAMETROPERCENTUAL',pic:'ZZ9.99'},{av:'AV88TFParametroPercentual_To',fld:'vTFPARAMETROPERCENTUAL_TO',pic:'ZZ9.99'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV67ddo_ParametroDtVigenciaIniTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAINITITLECONTROLIDTOREPLACE',pic:''},{av:'AV73ddo_ParametroDtVigenciaFimTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAFIMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_ParametroTipoTitleControlIdToReplace',fld:'vDDO_PARAMETROTIPOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_ParametroPrioritariaTitleControlIdToReplace',fld:'vDDO_PARAMETROPRIORITARIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_ParametroValorTitleControlIdToReplace',fld:'vDDO_PARAMETROVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV89ddo_ParametroPercentualTitleControlIdToReplace',fld:'vDDO_PARAMETROPERCENTUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76TFParametroTipo_Sels',fld:'vTFPARAMETROTIPO_SELS',pic:''},{av:'AV80TFParametroPrioritaria_Sels',fld:'vTFPARAMETROPRIORITARIA_SELS',pic:''},{av:'AV108Pgmname',fld:'vPGMNAME',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_PARAMETRODTVIGENCIAINI.ONOPTIONCLICKED","{handler:'E140V2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV63TFParametroDtVigenciaIni',fld:'vTFPARAMETRODTVIGENCIAINI',pic:''},{av:'AV64TFParametroDtVigenciaIni_To',fld:'vTFPARAMETRODTVIGENCIAINI_TO',pic:''},{av:'AV69TFParametroDtVigenciaFim',fld:'vTFPARAMETRODTVIGENCIAFIM',pic:''},{av:'AV70TFParametroDtVigenciaFim_To',fld:'vTFPARAMETRODTVIGENCIAFIM_TO',pic:''},{av:'AV83TFParametroValor',fld:'vTFPARAMETROVALOR',pic:'ZZZ,ZZZ,ZZ9.99'},{av:'AV84TFParametroValor_To',fld:'vTFPARAMETROVALOR_TO',pic:'ZZZ,ZZZ,ZZ9.99'},{av:'AV87TFParametroPercentual',fld:'vTFPARAMETROPERCENTUAL',pic:'ZZ9.99'},{av:'AV88TFParametroPercentual_To',fld:'vTFPARAMETROPERCENTUAL_TO',pic:'ZZ9.99'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV67ddo_ParametroDtVigenciaIniTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAINITITLECONTROLIDTOREPLACE',pic:''},{av:'AV73ddo_ParametroDtVigenciaFimTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAFIMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_ParametroTipoTitleControlIdToReplace',fld:'vDDO_PARAMETROTIPOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_ParametroPrioritariaTitleControlIdToReplace',fld:'vDDO_PARAMETROPRIORITARIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_ParametroValorTitleControlIdToReplace',fld:'vDDO_PARAMETROVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV89ddo_ParametroPercentualTitleControlIdToReplace',fld:'vDDO_PARAMETROPERCENTUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76TFParametroTipo_Sels',fld:'vTFPARAMETROTIPO_SELS',pic:''},{av:'AV80TFParametroPrioritaria_Sels',fld:'vTFPARAMETROPRIORITARIA_SELS',pic:''},{av:'AV108Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_parametrodtvigenciaini_Activeeventkey',ctrl:'DDO_PARAMETRODTVIGENCIAINI',prop:'ActiveEventKey'},{av:'Ddo_parametrodtvigenciaini_Filteredtext_get',ctrl:'DDO_PARAMETRODTVIGENCIAINI',prop:'FilteredText_get'},{av:'Ddo_parametrodtvigenciaini_Filteredtextto_get',ctrl:'DDO_PARAMETRODTVIGENCIAINI',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_PARAMETRODTVIGENCIAINI.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_parametrodtvigenciaini_Sortedstatus',ctrl:'DDO_PARAMETRODTVIGENCIAINI',prop:'SortedStatus'},{av:'AV63TFParametroDtVigenciaIni',fld:'vTFPARAMETRODTVIGENCIAINI',pic:''},{av:'AV64TFParametroDtVigenciaIni_To',fld:'vTFPARAMETRODTVIGENCIAINI_TO',pic:''},{av:'Ddo_parametrodtvigenciafim_Sortedstatus',ctrl:'DDO_PARAMETRODTVIGENCIAFIM',prop:'SortedStatus'},{av:'Ddo_parametrotipo_Sortedstatus',ctrl:'DDO_PARAMETROTIPO',prop:'SortedStatus'},{av:'Ddo_parametroprioritaria_Sortedstatus',ctrl:'DDO_PARAMETROPRIORITARIA',prop:'SortedStatus'},{av:'Ddo_parametrovalor_Sortedstatus',ctrl:'DDO_PARAMETROVALOR',prop:'SortedStatus'},{av:'Ddo_parametropercentual_Sortedstatus',ctrl:'DDO_PARAMETROPERCENTUAL',prop:'SortedStatus'},{av:'AV62ParametroDtVigenciaIniTitleFilterData',fld:'vPARAMETRODTVIGENCIAINITITLEFILTERDATA',pic:''},{av:'AV68ParametroDtVigenciaFimTitleFilterData',fld:'vPARAMETRODTVIGENCIAFIMTITLEFILTERDATA',pic:''},{av:'AV74ParametroTipoTitleFilterData',fld:'vPARAMETROTIPOTITLEFILTERDATA',pic:''},{av:'AV78ParametroPrioritariaTitleFilterData',fld:'vPARAMETROPRIORITARIATITLEFILTERDATA',pic:''},{av:'AV82ParametroValorTitleFilterData',fld:'vPARAMETROVALORTITLEFILTERDATA',pic:''},{av:'AV86ParametroPercentualTitleFilterData',fld:'vPARAMETROPERCENTUALTITLEFILTERDATA',pic:''},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtParametroDtVigenciaIni_Visible',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Visible'},{av:'edtParametroDtVigenciaFim_Visible',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Visible'},{av:'cmbParametroTipo'},{av:'cmbParametroPrioritaria'},{av:'edtParametroValor_Visible',ctrl:'PARAMETROVALOR',prop:'Visible'},{av:'edtParametroPercentual_Visible',ctrl:'PARAMETROPERCENTUAL',prop:'Visible'},{av:'edtParametroDtVigenciaIni_Titleformat',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Titleformat'},{av:'edtParametroDtVigenciaIni_Title',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Title'},{av:'edtParametroDtVigenciaFim_Titleformat',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Titleformat'},{av:'edtParametroDtVigenciaFim_Title',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Title'},{av:'edtParametroValor_Titleformat',ctrl:'PARAMETROVALOR',prop:'Titleformat'},{av:'edtParametroValor_Title',ctrl:'PARAMETROVALOR',prop:'Title'},{av:'edtParametroPercentual_Titleformat',ctrl:'PARAMETROPERCENTUAL',prop:'Titleformat'},{av:'edtParametroPercentual_Title',ctrl:'PARAMETROPERCENTUAL',prop:'Title'},{av:'AV92GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV93GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("DDO_PARAMETRODTVIGENCIAFIM.ONOPTIONCLICKED","{handler:'E150V2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV63TFParametroDtVigenciaIni',fld:'vTFPARAMETRODTVIGENCIAINI',pic:''},{av:'AV64TFParametroDtVigenciaIni_To',fld:'vTFPARAMETRODTVIGENCIAINI_TO',pic:''},{av:'AV69TFParametroDtVigenciaFim',fld:'vTFPARAMETRODTVIGENCIAFIM',pic:''},{av:'AV70TFParametroDtVigenciaFim_To',fld:'vTFPARAMETRODTVIGENCIAFIM_TO',pic:''},{av:'AV83TFParametroValor',fld:'vTFPARAMETROVALOR',pic:'ZZZ,ZZZ,ZZ9.99'},{av:'AV84TFParametroValor_To',fld:'vTFPARAMETROVALOR_TO',pic:'ZZZ,ZZZ,ZZ9.99'},{av:'AV87TFParametroPercentual',fld:'vTFPARAMETROPERCENTUAL',pic:'ZZ9.99'},{av:'AV88TFParametroPercentual_To',fld:'vTFPARAMETROPERCENTUAL_TO',pic:'ZZ9.99'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV67ddo_ParametroDtVigenciaIniTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAINITITLECONTROLIDTOREPLACE',pic:''},{av:'AV73ddo_ParametroDtVigenciaFimTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAFIMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_ParametroTipoTitleControlIdToReplace',fld:'vDDO_PARAMETROTIPOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_ParametroPrioritariaTitleControlIdToReplace',fld:'vDDO_PARAMETROPRIORITARIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_ParametroValorTitleControlIdToReplace',fld:'vDDO_PARAMETROVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV89ddo_ParametroPercentualTitleControlIdToReplace',fld:'vDDO_PARAMETROPERCENTUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76TFParametroTipo_Sels',fld:'vTFPARAMETROTIPO_SELS',pic:''},{av:'AV80TFParametroPrioritaria_Sels',fld:'vTFPARAMETROPRIORITARIA_SELS',pic:''},{av:'AV108Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_parametrodtvigenciafim_Activeeventkey',ctrl:'DDO_PARAMETRODTVIGENCIAFIM',prop:'ActiveEventKey'},{av:'Ddo_parametrodtvigenciafim_Filteredtext_get',ctrl:'DDO_PARAMETRODTVIGENCIAFIM',prop:'FilteredText_get'},{av:'Ddo_parametrodtvigenciafim_Filteredtextto_get',ctrl:'DDO_PARAMETRODTVIGENCIAFIM',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_PARAMETRODTVIGENCIAFIM.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_parametrodtvigenciafim_Sortedstatus',ctrl:'DDO_PARAMETRODTVIGENCIAFIM',prop:'SortedStatus'},{av:'AV69TFParametroDtVigenciaFim',fld:'vTFPARAMETRODTVIGENCIAFIM',pic:''},{av:'AV70TFParametroDtVigenciaFim_To',fld:'vTFPARAMETRODTVIGENCIAFIM_TO',pic:''},{av:'Ddo_parametrodtvigenciaini_Sortedstatus',ctrl:'DDO_PARAMETRODTVIGENCIAINI',prop:'SortedStatus'},{av:'Ddo_parametrotipo_Sortedstatus',ctrl:'DDO_PARAMETROTIPO',prop:'SortedStatus'},{av:'Ddo_parametroprioritaria_Sortedstatus',ctrl:'DDO_PARAMETROPRIORITARIA',prop:'SortedStatus'},{av:'Ddo_parametrovalor_Sortedstatus',ctrl:'DDO_PARAMETROVALOR',prop:'SortedStatus'},{av:'Ddo_parametropercentual_Sortedstatus',ctrl:'DDO_PARAMETROPERCENTUAL',prop:'SortedStatus'},{av:'AV62ParametroDtVigenciaIniTitleFilterData',fld:'vPARAMETRODTVIGENCIAINITITLEFILTERDATA',pic:''},{av:'AV68ParametroDtVigenciaFimTitleFilterData',fld:'vPARAMETRODTVIGENCIAFIMTITLEFILTERDATA',pic:''},{av:'AV74ParametroTipoTitleFilterData',fld:'vPARAMETROTIPOTITLEFILTERDATA',pic:''},{av:'AV78ParametroPrioritariaTitleFilterData',fld:'vPARAMETROPRIORITARIATITLEFILTERDATA',pic:''},{av:'AV82ParametroValorTitleFilterData',fld:'vPARAMETROVALORTITLEFILTERDATA',pic:''},{av:'AV86ParametroPercentualTitleFilterData',fld:'vPARAMETROPERCENTUALTITLEFILTERDATA',pic:''},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtParametroDtVigenciaIni_Visible',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Visible'},{av:'edtParametroDtVigenciaFim_Visible',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Visible'},{av:'cmbParametroTipo'},{av:'cmbParametroPrioritaria'},{av:'edtParametroValor_Visible',ctrl:'PARAMETROVALOR',prop:'Visible'},{av:'edtParametroPercentual_Visible',ctrl:'PARAMETROPERCENTUAL',prop:'Visible'},{av:'edtParametroDtVigenciaIni_Titleformat',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Titleformat'},{av:'edtParametroDtVigenciaIni_Title',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Title'},{av:'edtParametroDtVigenciaFim_Titleformat',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Titleformat'},{av:'edtParametroDtVigenciaFim_Title',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Title'},{av:'edtParametroValor_Titleformat',ctrl:'PARAMETROVALOR',prop:'Titleformat'},{av:'edtParametroValor_Title',ctrl:'PARAMETROVALOR',prop:'Title'},{av:'edtParametroPercentual_Titleformat',ctrl:'PARAMETROPERCENTUAL',prop:'Titleformat'},{av:'edtParametroPercentual_Title',ctrl:'PARAMETROPERCENTUAL',prop:'Title'},{av:'AV92GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV93GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("DDO_PARAMETROTIPO.ONOPTIONCLICKED","{handler:'E160V2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV63TFParametroDtVigenciaIni',fld:'vTFPARAMETRODTVIGENCIAINI',pic:''},{av:'AV64TFParametroDtVigenciaIni_To',fld:'vTFPARAMETRODTVIGENCIAINI_TO',pic:''},{av:'AV69TFParametroDtVigenciaFim',fld:'vTFPARAMETRODTVIGENCIAFIM',pic:''},{av:'AV70TFParametroDtVigenciaFim_To',fld:'vTFPARAMETRODTVIGENCIAFIM_TO',pic:''},{av:'AV83TFParametroValor',fld:'vTFPARAMETROVALOR',pic:'ZZZ,ZZZ,ZZ9.99'},{av:'AV84TFParametroValor_To',fld:'vTFPARAMETROVALOR_TO',pic:'ZZZ,ZZZ,ZZ9.99'},{av:'AV87TFParametroPercentual',fld:'vTFPARAMETROPERCENTUAL',pic:'ZZ9.99'},{av:'AV88TFParametroPercentual_To',fld:'vTFPARAMETROPERCENTUAL_TO',pic:'ZZ9.99'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV67ddo_ParametroDtVigenciaIniTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAINITITLECONTROLIDTOREPLACE',pic:''},{av:'AV73ddo_ParametroDtVigenciaFimTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAFIMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_ParametroTipoTitleControlIdToReplace',fld:'vDDO_PARAMETROTIPOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_ParametroPrioritariaTitleControlIdToReplace',fld:'vDDO_PARAMETROPRIORITARIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_ParametroValorTitleControlIdToReplace',fld:'vDDO_PARAMETROVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV89ddo_ParametroPercentualTitleControlIdToReplace',fld:'vDDO_PARAMETROPERCENTUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76TFParametroTipo_Sels',fld:'vTFPARAMETROTIPO_SELS',pic:''},{av:'AV80TFParametroPrioritaria_Sels',fld:'vTFPARAMETROPRIORITARIA_SELS',pic:''},{av:'AV108Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_parametrotipo_Activeeventkey',ctrl:'DDO_PARAMETROTIPO',prop:'ActiveEventKey'},{av:'Ddo_parametrotipo_Selectedvalue_get',ctrl:'DDO_PARAMETROTIPO',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_PARAMETROTIPO.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_parametrotipo_Sortedstatus',ctrl:'DDO_PARAMETROTIPO',prop:'SortedStatus'},{av:'AV76TFParametroTipo_Sels',fld:'vTFPARAMETROTIPO_SELS',pic:''},{av:'Ddo_parametrodtvigenciaini_Sortedstatus',ctrl:'DDO_PARAMETRODTVIGENCIAINI',prop:'SortedStatus'},{av:'Ddo_parametrodtvigenciafim_Sortedstatus',ctrl:'DDO_PARAMETRODTVIGENCIAFIM',prop:'SortedStatus'},{av:'Ddo_parametroprioritaria_Sortedstatus',ctrl:'DDO_PARAMETROPRIORITARIA',prop:'SortedStatus'},{av:'Ddo_parametrovalor_Sortedstatus',ctrl:'DDO_PARAMETROVALOR',prop:'SortedStatus'},{av:'Ddo_parametropercentual_Sortedstatus',ctrl:'DDO_PARAMETROPERCENTUAL',prop:'SortedStatus'},{av:'AV62ParametroDtVigenciaIniTitleFilterData',fld:'vPARAMETRODTVIGENCIAINITITLEFILTERDATA',pic:''},{av:'AV68ParametroDtVigenciaFimTitleFilterData',fld:'vPARAMETRODTVIGENCIAFIMTITLEFILTERDATA',pic:''},{av:'AV74ParametroTipoTitleFilterData',fld:'vPARAMETROTIPOTITLEFILTERDATA',pic:''},{av:'AV78ParametroPrioritariaTitleFilterData',fld:'vPARAMETROPRIORITARIATITLEFILTERDATA',pic:''},{av:'AV82ParametroValorTitleFilterData',fld:'vPARAMETROVALORTITLEFILTERDATA',pic:''},{av:'AV86ParametroPercentualTitleFilterData',fld:'vPARAMETROPERCENTUALTITLEFILTERDATA',pic:''},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtParametroDtVigenciaIni_Visible',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Visible'},{av:'edtParametroDtVigenciaFim_Visible',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Visible'},{av:'cmbParametroTipo'},{av:'cmbParametroPrioritaria'},{av:'edtParametroValor_Visible',ctrl:'PARAMETROVALOR',prop:'Visible'},{av:'edtParametroPercentual_Visible',ctrl:'PARAMETROPERCENTUAL',prop:'Visible'},{av:'edtParametroDtVigenciaIni_Titleformat',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Titleformat'},{av:'edtParametroDtVigenciaIni_Title',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Title'},{av:'edtParametroDtVigenciaFim_Titleformat',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Titleformat'},{av:'edtParametroDtVigenciaFim_Title',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Title'},{av:'edtParametroValor_Titleformat',ctrl:'PARAMETROVALOR',prop:'Titleformat'},{av:'edtParametroValor_Title',ctrl:'PARAMETROVALOR',prop:'Title'},{av:'edtParametroPercentual_Titleformat',ctrl:'PARAMETROPERCENTUAL',prop:'Titleformat'},{av:'edtParametroPercentual_Title',ctrl:'PARAMETROPERCENTUAL',prop:'Title'},{av:'AV92GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV93GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("DDO_PARAMETROPRIORITARIA.ONOPTIONCLICKED","{handler:'E170V2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV63TFParametroDtVigenciaIni',fld:'vTFPARAMETRODTVIGENCIAINI',pic:''},{av:'AV64TFParametroDtVigenciaIni_To',fld:'vTFPARAMETRODTVIGENCIAINI_TO',pic:''},{av:'AV69TFParametroDtVigenciaFim',fld:'vTFPARAMETRODTVIGENCIAFIM',pic:''},{av:'AV70TFParametroDtVigenciaFim_To',fld:'vTFPARAMETRODTVIGENCIAFIM_TO',pic:''},{av:'AV83TFParametroValor',fld:'vTFPARAMETROVALOR',pic:'ZZZ,ZZZ,ZZ9.99'},{av:'AV84TFParametroValor_To',fld:'vTFPARAMETROVALOR_TO',pic:'ZZZ,ZZZ,ZZ9.99'},{av:'AV87TFParametroPercentual',fld:'vTFPARAMETROPERCENTUAL',pic:'ZZ9.99'},{av:'AV88TFParametroPercentual_To',fld:'vTFPARAMETROPERCENTUAL_TO',pic:'ZZ9.99'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV67ddo_ParametroDtVigenciaIniTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAINITITLECONTROLIDTOREPLACE',pic:''},{av:'AV73ddo_ParametroDtVigenciaFimTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAFIMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_ParametroTipoTitleControlIdToReplace',fld:'vDDO_PARAMETROTIPOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_ParametroPrioritariaTitleControlIdToReplace',fld:'vDDO_PARAMETROPRIORITARIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_ParametroValorTitleControlIdToReplace',fld:'vDDO_PARAMETROVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV89ddo_ParametroPercentualTitleControlIdToReplace',fld:'vDDO_PARAMETROPERCENTUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76TFParametroTipo_Sels',fld:'vTFPARAMETROTIPO_SELS',pic:''},{av:'AV80TFParametroPrioritaria_Sels',fld:'vTFPARAMETROPRIORITARIA_SELS',pic:''},{av:'AV108Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_parametroprioritaria_Activeeventkey',ctrl:'DDO_PARAMETROPRIORITARIA',prop:'ActiveEventKey'},{av:'Ddo_parametroprioritaria_Selectedvalue_get',ctrl:'DDO_PARAMETROPRIORITARIA',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_PARAMETROPRIORITARIA.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_parametroprioritaria_Sortedstatus',ctrl:'DDO_PARAMETROPRIORITARIA',prop:'SortedStatus'},{av:'AV80TFParametroPrioritaria_Sels',fld:'vTFPARAMETROPRIORITARIA_SELS',pic:''},{av:'Ddo_parametrodtvigenciaini_Sortedstatus',ctrl:'DDO_PARAMETRODTVIGENCIAINI',prop:'SortedStatus'},{av:'Ddo_parametrodtvigenciafim_Sortedstatus',ctrl:'DDO_PARAMETRODTVIGENCIAFIM',prop:'SortedStatus'},{av:'Ddo_parametrotipo_Sortedstatus',ctrl:'DDO_PARAMETROTIPO',prop:'SortedStatus'},{av:'Ddo_parametrovalor_Sortedstatus',ctrl:'DDO_PARAMETROVALOR',prop:'SortedStatus'},{av:'Ddo_parametropercentual_Sortedstatus',ctrl:'DDO_PARAMETROPERCENTUAL',prop:'SortedStatus'},{av:'AV62ParametroDtVigenciaIniTitleFilterData',fld:'vPARAMETRODTVIGENCIAINITITLEFILTERDATA',pic:''},{av:'AV68ParametroDtVigenciaFimTitleFilterData',fld:'vPARAMETRODTVIGENCIAFIMTITLEFILTERDATA',pic:''},{av:'AV74ParametroTipoTitleFilterData',fld:'vPARAMETROTIPOTITLEFILTERDATA',pic:''},{av:'AV78ParametroPrioritariaTitleFilterData',fld:'vPARAMETROPRIORITARIATITLEFILTERDATA',pic:''},{av:'AV82ParametroValorTitleFilterData',fld:'vPARAMETROVALORTITLEFILTERDATA',pic:''},{av:'AV86ParametroPercentualTitleFilterData',fld:'vPARAMETROPERCENTUALTITLEFILTERDATA',pic:''},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtParametroDtVigenciaIni_Visible',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Visible'},{av:'edtParametroDtVigenciaFim_Visible',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Visible'},{av:'cmbParametroTipo'},{av:'cmbParametroPrioritaria'},{av:'edtParametroValor_Visible',ctrl:'PARAMETROVALOR',prop:'Visible'},{av:'edtParametroPercentual_Visible',ctrl:'PARAMETROPERCENTUAL',prop:'Visible'},{av:'edtParametroDtVigenciaIni_Titleformat',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Titleformat'},{av:'edtParametroDtVigenciaIni_Title',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Title'},{av:'edtParametroDtVigenciaFim_Titleformat',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Titleformat'},{av:'edtParametroDtVigenciaFim_Title',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Title'},{av:'edtParametroValor_Titleformat',ctrl:'PARAMETROVALOR',prop:'Titleformat'},{av:'edtParametroValor_Title',ctrl:'PARAMETROVALOR',prop:'Title'},{av:'edtParametroPercentual_Titleformat',ctrl:'PARAMETROPERCENTUAL',prop:'Titleformat'},{av:'edtParametroPercentual_Title',ctrl:'PARAMETROPERCENTUAL',prop:'Title'},{av:'AV92GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV93GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("DDO_PARAMETROVALOR.ONOPTIONCLICKED","{handler:'E180V2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV63TFParametroDtVigenciaIni',fld:'vTFPARAMETRODTVIGENCIAINI',pic:''},{av:'AV64TFParametroDtVigenciaIni_To',fld:'vTFPARAMETRODTVIGENCIAINI_TO',pic:''},{av:'AV69TFParametroDtVigenciaFim',fld:'vTFPARAMETRODTVIGENCIAFIM',pic:''},{av:'AV70TFParametroDtVigenciaFim_To',fld:'vTFPARAMETRODTVIGENCIAFIM_TO',pic:''},{av:'AV83TFParametroValor',fld:'vTFPARAMETROVALOR',pic:'ZZZ,ZZZ,ZZ9.99'},{av:'AV84TFParametroValor_To',fld:'vTFPARAMETROVALOR_TO',pic:'ZZZ,ZZZ,ZZ9.99'},{av:'AV87TFParametroPercentual',fld:'vTFPARAMETROPERCENTUAL',pic:'ZZ9.99'},{av:'AV88TFParametroPercentual_To',fld:'vTFPARAMETROPERCENTUAL_TO',pic:'ZZ9.99'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV67ddo_ParametroDtVigenciaIniTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAINITITLECONTROLIDTOREPLACE',pic:''},{av:'AV73ddo_ParametroDtVigenciaFimTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAFIMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_ParametroTipoTitleControlIdToReplace',fld:'vDDO_PARAMETROTIPOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_ParametroPrioritariaTitleControlIdToReplace',fld:'vDDO_PARAMETROPRIORITARIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_ParametroValorTitleControlIdToReplace',fld:'vDDO_PARAMETROVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV89ddo_ParametroPercentualTitleControlIdToReplace',fld:'vDDO_PARAMETROPERCENTUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76TFParametroTipo_Sels',fld:'vTFPARAMETROTIPO_SELS',pic:''},{av:'AV80TFParametroPrioritaria_Sels',fld:'vTFPARAMETROPRIORITARIA_SELS',pic:''},{av:'AV108Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_parametrovalor_Activeeventkey',ctrl:'DDO_PARAMETROVALOR',prop:'ActiveEventKey'},{av:'Ddo_parametrovalor_Filteredtext_get',ctrl:'DDO_PARAMETROVALOR',prop:'FilteredText_get'},{av:'Ddo_parametrovalor_Filteredtextto_get',ctrl:'DDO_PARAMETROVALOR',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_PARAMETROVALOR.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_parametrovalor_Sortedstatus',ctrl:'DDO_PARAMETROVALOR',prop:'SortedStatus'},{av:'AV83TFParametroValor',fld:'vTFPARAMETROVALOR',pic:'ZZZ,ZZZ,ZZ9.99'},{av:'AV84TFParametroValor_To',fld:'vTFPARAMETROVALOR_TO',pic:'ZZZ,ZZZ,ZZ9.99'},{av:'Ddo_parametrodtvigenciaini_Sortedstatus',ctrl:'DDO_PARAMETRODTVIGENCIAINI',prop:'SortedStatus'},{av:'Ddo_parametrodtvigenciafim_Sortedstatus',ctrl:'DDO_PARAMETRODTVIGENCIAFIM',prop:'SortedStatus'},{av:'Ddo_parametrotipo_Sortedstatus',ctrl:'DDO_PARAMETROTIPO',prop:'SortedStatus'},{av:'Ddo_parametroprioritaria_Sortedstatus',ctrl:'DDO_PARAMETROPRIORITARIA',prop:'SortedStatus'},{av:'Ddo_parametropercentual_Sortedstatus',ctrl:'DDO_PARAMETROPERCENTUAL',prop:'SortedStatus'},{av:'AV62ParametroDtVigenciaIniTitleFilterData',fld:'vPARAMETRODTVIGENCIAINITITLEFILTERDATA',pic:''},{av:'AV68ParametroDtVigenciaFimTitleFilterData',fld:'vPARAMETRODTVIGENCIAFIMTITLEFILTERDATA',pic:''},{av:'AV74ParametroTipoTitleFilterData',fld:'vPARAMETROTIPOTITLEFILTERDATA',pic:''},{av:'AV78ParametroPrioritariaTitleFilterData',fld:'vPARAMETROPRIORITARIATITLEFILTERDATA',pic:''},{av:'AV82ParametroValorTitleFilterData',fld:'vPARAMETROVALORTITLEFILTERDATA',pic:''},{av:'AV86ParametroPercentualTitleFilterData',fld:'vPARAMETROPERCENTUALTITLEFILTERDATA',pic:''},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtParametroDtVigenciaIni_Visible',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Visible'},{av:'edtParametroDtVigenciaFim_Visible',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Visible'},{av:'cmbParametroTipo'},{av:'cmbParametroPrioritaria'},{av:'edtParametroValor_Visible',ctrl:'PARAMETROVALOR',prop:'Visible'},{av:'edtParametroPercentual_Visible',ctrl:'PARAMETROPERCENTUAL',prop:'Visible'},{av:'edtParametroDtVigenciaIni_Titleformat',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Titleformat'},{av:'edtParametroDtVigenciaIni_Title',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Title'},{av:'edtParametroDtVigenciaFim_Titleformat',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Titleformat'},{av:'edtParametroDtVigenciaFim_Title',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Title'},{av:'edtParametroValor_Titleformat',ctrl:'PARAMETROVALOR',prop:'Titleformat'},{av:'edtParametroValor_Title',ctrl:'PARAMETROVALOR',prop:'Title'},{av:'edtParametroPercentual_Titleformat',ctrl:'PARAMETROPERCENTUAL',prop:'Titleformat'},{av:'edtParametroPercentual_Title',ctrl:'PARAMETROPERCENTUAL',prop:'Title'},{av:'AV92GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV93GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("DDO_PARAMETROPERCENTUAL.ONOPTIONCLICKED","{handler:'E190V2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV63TFParametroDtVigenciaIni',fld:'vTFPARAMETRODTVIGENCIAINI',pic:''},{av:'AV64TFParametroDtVigenciaIni_To',fld:'vTFPARAMETRODTVIGENCIAINI_TO',pic:''},{av:'AV69TFParametroDtVigenciaFim',fld:'vTFPARAMETRODTVIGENCIAFIM',pic:''},{av:'AV70TFParametroDtVigenciaFim_To',fld:'vTFPARAMETRODTVIGENCIAFIM_TO',pic:''},{av:'AV83TFParametroValor',fld:'vTFPARAMETROVALOR',pic:'ZZZ,ZZZ,ZZ9.99'},{av:'AV84TFParametroValor_To',fld:'vTFPARAMETROVALOR_TO',pic:'ZZZ,ZZZ,ZZ9.99'},{av:'AV87TFParametroPercentual',fld:'vTFPARAMETROPERCENTUAL',pic:'ZZ9.99'},{av:'AV88TFParametroPercentual_To',fld:'vTFPARAMETROPERCENTUAL_TO',pic:'ZZ9.99'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV67ddo_ParametroDtVigenciaIniTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAINITITLECONTROLIDTOREPLACE',pic:''},{av:'AV73ddo_ParametroDtVigenciaFimTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAFIMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_ParametroTipoTitleControlIdToReplace',fld:'vDDO_PARAMETROTIPOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_ParametroPrioritariaTitleControlIdToReplace',fld:'vDDO_PARAMETROPRIORITARIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_ParametroValorTitleControlIdToReplace',fld:'vDDO_PARAMETROVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV89ddo_ParametroPercentualTitleControlIdToReplace',fld:'vDDO_PARAMETROPERCENTUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76TFParametroTipo_Sels',fld:'vTFPARAMETROTIPO_SELS',pic:''},{av:'AV80TFParametroPrioritaria_Sels',fld:'vTFPARAMETROPRIORITARIA_SELS',pic:''},{av:'AV108Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_parametropercentual_Activeeventkey',ctrl:'DDO_PARAMETROPERCENTUAL',prop:'ActiveEventKey'},{av:'Ddo_parametropercentual_Filteredtext_get',ctrl:'DDO_PARAMETROPERCENTUAL',prop:'FilteredText_get'},{av:'Ddo_parametropercentual_Filteredtextto_get',ctrl:'DDO_PARAMETROPERCENTUAL',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_PARAMETROPERCENTUAL.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_parametropercentual_Sortedstatus',ctrl:'DDO_PARAMETROPERCENTUAL',prop:'SortedStatus'},{av:'AV87TFParametroPercentual',fld:'vTFPARAMETROPERCENTUAL',pic:'ZZ9.99'},{av:'AV88TFParametroPercentual_To',fld:'vTFPARAMETROPERCENTUAL_TO',pic:'ZZ9.99'},{av:'Ddo_parametrodtvigenciaini_Sortedstatus',ctrl:'DDO_PARAMETRODTVIGENCIAINI',prop:'SortedStatus'},{av:'Ddo_parametrodtvigenciafim_Sortedstatus',ctrl:'DDO_PARAMETRODTVIGENCIAFIM',prop:'SortedStatus'},{av:'Ddo_parametrotipo_Sortedstatus',ctrl:'DDO_PARAMETROTIPO',prop:'SortedStatus'},{av:'Ddo_parametroprioritaria_Sortedstatus',ctrl:'DDO_PARAMETROPRIORITARIA',prop:'SortedStatus'},{av:'Ddo_parametrovalor_Sortedstatus',ctrl:'DDO_PARAMETROVALOR',prop:'SortedStatus'},{av:'AV62ParametroDtVigenciaIniTitleFilterData',fld:'vPARAMETRODTVIGENCIAINITITLEFILTERDATA',pic:''},{av:'AV68ParametroDtVigenciaFimTitleFilterData',fld:'vPARAMETRODTVIGENCIAFIMTITLEFILTERDATA',pic:''},{av:'AV74ParametroTipoTitleFilterData',fld:'vPARAMETROTIPOTITLEFILTERDATA',pic:''},{av:'AV78ParametroPrioritariaTitleFilterData',fld:'vPARAMETROPRIORITARIATITLEFILTERDATA',pic:''},{av:'AV82ParametroValorTitleFilterData',fld:'vPARAMETROVALORTITLEFILTERDATA',pic:''},{av:'AV86ParametroPercentualTitleFilterData',fld:'vPARAMETROPERCENTUALTITLEFILTERDATA',pic:''},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtParametroDtVigenciaIni_Visible',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Visible'},{av:'edtParametroDtVigenciaFim_Visible',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Visible'},{av:'cmbParametroTipo'},{av:'cmbParametroPrioritaria'},{av:'edtParametroValor_Visible',ctrl:'PARAMETROVALOR',prop:'Visible'},{av:'edtParametroPercentual_Visible',ctrl:'PARAMETROPERCENTUAL',prop:'Visible'},{av:'edtParametroDtVigenciaIni_Titleformat',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Titleformat'},{av:'edtParametroDtVigenciaIni_Title',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Title'},{av:'edtParametroDtVigenciaFim_Titleformat',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Titleformat'},{av:'edtParametroDtVigenciaFim_Title',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Title'},{av:'edtParametroValor_Titleformat',ctrl:'PARAMETROVALOR',prop:'Titleformat'},{av:'edtParametroValor_Title',ctrl:'PARAMETROVALOR',prop:'Title'},{av:'edtParametroPercentual_Titleformat',ctrl:'PARAMETROPERCENTUAL',prop:'Titleformat'},{av:'edtParametroPercentual_Title',ctrl:'PARAMETROPERCENTUAL',prop:'Title'},{av:'AV92GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV93GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("GRID.LOAD","{handler:'E240V2',iparms:[{av:'A13ParametroID',fld:'PARAMETROID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV94Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'AV95Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'},{av:'edtParametroDtVigenciaIni_Link',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Link'}]}");
         setEventMetadata("DDO_GRIDCOLUMNSSELECTOR.ONCOLUMNSCHANGED","{handler:'E200V2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV63TFParametroDtVigenciaIni',fld:'vTFPARAMETRODTVIGENCIAINI',pic:''},{av:'AV64TFParametroDtVigenciaIni_To',fld:'vTFPARAMETRODTVIGENCIAINI_TO',pic:''},{av:'AV69TFParametroDtVigenciaFim',fld:'vTFPARAMETRODTVIGENCIAFIM',pic:''},{av:'AV70TFParametroDtVigenciaFim_To',fld:'vTFPARAMETRODTVIGENCIAFIM_TO',pic:''},{av:'AV83TFParametroValor',fld:'vTFPARAMETROVALOR',pic:'ZZZ,ZZZ,ZZ9.99'},{av:'AV84TFParametroValor_To',fld:'vTFPARAMETROVALOR_TO',pic:'ZZZ,ZZZ,ZZ9.99'},{av:'AV87TFParametroPercentual',fld:'vTFPARAMETROPERCENTUAL',pic:'ZZ9.99'},{av:'AV88TFParametroPercentual_To',fld:'vTFPARAMETROPERCENTUAL_TO',pic:'ZZ9.99'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV67ddo_ParametroDtVigenciaIniTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAINITITLECONTROLIDTOREPLACE',pic:''},{av:'AV73ddo_ParametroDtVigenciaFimTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAFIMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_ParametroTipoTitleControlIdToReplace',fld:'vDDO_PARAMETROTIPOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_ParametroPrioritariaTitleControlIdToReplace',fld:'vDDO_PARAMETROPRIORITARIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_ParametroValorTitleControlIdToReplace',fld:'vDDO_PARAMETROVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV89ddo_ParametroPercentualTitleControlIdToReplace',fld:'vDDO_PARAMETROPERCENTUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76TFParametroTipo_Sels',fld:'vTFPARAMETROTIPO_SELS',pic:''},{av:'AV80TFParametroPrioritaria_Sels',fld:'vTFPARAMETROPRIORITARIA_SELS',pic:''},{av:'AV108Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_gridcolumnsselector_Columnsselectorvalues',ctrl:'DDO_GRIDCOLUMNSSELECTOR',prop:'ColumnsSelectorValues'}]");
         setEventMetadata("DDO_GRIDCOLUMNSSELECTOR.ONCOLUMNSCHANGED",",oparms:[{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV62ParametroDtVigenciaIniTitleFilterData',fld:'vPARAMETRODTVIGENCIAINITITLEFILTERDATA',pic:''},{av:'AV68ParametroDtVigenciaFimTitleFilterData',fld:'vPARAMETRODTVIGENCIAFIMTITLEFILTERDATA',pic:''},{av:'AV74ParametroTipoTitleFilterData',fld:'vPARAMETROTIPOTITLEFILTERDATA',pic:''},{av:'AV78ParametroPrioritariaTitleFilterData',fld:'vPARAMETROPRIORITARIATITLEFILTERDATA',pic:''},{av:'AV82ParametroValorTitleFilterData',fld:'vPARAMETROVALORTITLEFILTERDATA',pic:''},{av:'AV86ParametroPercentualTitleFilterData',fld:'vPARAMETROPERCENTUALTITLEFILTERDATA',pic:''},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'edtParametroDtVigenciaIni_Visible',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Visible'},{av:'edtParametroDtVigenciaFim_Visible',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Visible'},{av:'cmbParametroTipo'},{av:'cmbParametroPrioritaria'},{av:'edtParametroValor_Visible',ctrl:'PARAMETROVALOR',prop:'Visible'},{av:'edtParametroPercentual_Visible',ctrl:'PARAMETROPERCENTUAL',prop:'Visible'},{av:'edtParametroDtVigenciaIni_Titleformat',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Titleformat'},{av:'edtParametroDtVigenciaIni_Title',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Title'},{av:'edtParametroDtVigenciaFim_Titleformat',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Titleformat'},{av:'edtParametroDtVigenciaFim_Title',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Title'},{av:'edtParametroValor_Titleformat',ctrl:'PARAMETROVALOR',prop:'Titleformat'},{av:'edtParametroValor_Title',ctrl:'PARAMETROVALOR',prop:'Title'},{av:'edtParametroPercentual_Titleformat',ctrl:'PARAMETROPERCENTUAL',prop:'Titleformat'},{av:'edtParametroPercentual_Title',ctrl:'PARAMETROPERCENTUAL',prop:'Title'},{av:'AV92GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV93GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("DDO_MANAGEFILTERS.ONOPTIONCLICKED","{handler:'E110V2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV63TFParametroDtVigenciaIni',fld:'vTFPARAMETRODTVIGENCIAINI',pic:''},{av:'AV64TFParametroDtVigenciaIni_To',fld:'vTFPARAMETRODTVIGENCIAINI_TO',pic:''},{av:'AV69TFParametroDtVigenciaFim',fld:'vTFPARAMETRODTVIGENCIAFIM',pic:''},{av:'AV70TFParametroDtVigenciaFim_To',fld:'vTFPARAMETRODTVIGENCIAFIM_TO',pic:''},{av:'AV83TFParametroValor',fld:'vTFPARAMETROVALOR',pic:'ZZZ,ZZZ,ZZ9.99'},{av:'AV84TFParametroValor_To',fld:'vTFPARAMETROVALOR_TO',pic:'ZZZ,ZZZ,ZZ9.99'},{av:'AV87TFParametroPercentual',fld:'vTFPARAMETROPERCENTUAL',pic:'ZZ9.99'},{av:'AV88TFParametroPercentual_To',fld:'vTFPARAMETROPERCENTUAL_TO',pic:'ZZ9.99'},{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV67ddo_ParametroDtVigenciaIniTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAINITITLECONTROLIDTOREPLACE',pic:''},{av:'AV73ddo_ParametroDtVigenciaFimTitleControlIdToReplace',fld:'vDDO_PARAMETRODTVIGENCIAFIMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_ParametroTipoTitleControlIdToReplace',fld:'vDDO_PARAMETROTIPOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_ParametroPrioritariaTitleControlIdToReplace',fld:'vDDO_PARAMETROPRIORITARIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_ParametroValorTitleControlIdToReplace',fld:'vDDO_PARAMETROVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV89ddo_ParametroPercentualTitleControlIdToReplace',fld:'vDDO_PARAMETROPERCENTUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76TFParametroTipo_Sels',fld:'vTFPARAMETROTIPO_SELS',pic:''},{av:'AV80TFParametroPrioritaria_Sels',fld:'vTFPARAMETROPRIORITARIA_SELS',pic:''},{av:'AV108Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_managefilters_Activeeventkey',ctrl:'DDO_MANAGEFILTERS',prop:'ActiveEventKey'},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]");
         setEventMetadata("DDO_MANAGEFILTERS.ONOPTIONCLICKED",",oparms:[{av:'AV52ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV63TFParametroDtVigenciaIni',fld:'vTFPARAMETRODTVIGENCIAINI',pic:''},{av:'Ddo_parametrodtvigenciaini_Filteredtext_set',ctrl:'DDO_PARAMETRODTVIGENCIAINI',prop:'FilteredText_set'},{av:'AV64TFParametroDtVigenciaIni_To',fld:'vTFPARAMETRODTVIGENCIAINI_TO',pic:''},{av:'Ddo_parametrodtvigenciaini_Filteredtextto_set',ctrl:'DDO_PARAMETRODTVIGENCIAINI',prop:'FilteredTextTo_set'},{av:'AV69TFParametroDtVigenciaFim',fld:'vTFPARAMETRODTVIGENCIAFIM',pic:''},{av:'Ddo_parametrodtvigenciafim_Filteredtext_set',ctrl:'DDO_PARAMETRODTVIGENCIAFIM',prop:'FilteredText_set'},{av:'AV70TFParametroDtVigenciaFim_To',fld:'vTFPARAMETRODTVIGENCIAFIM_TO',pic:''},{av:'Ddo_parametrodtvigenciafim_Filteredtextto_set',ctrl:'DDO_PARAMETRODTVIGENCIAFIM',prop:'FilteredTextTo_set'},{av:'AV76TFParametroTipo_Sels',fld:'vTFPARAMETROTIPO_SELS',pic:''},{av:'Ddo_parametrotipo_Selectedvalue_set',ctrl:'DDO_PARAMETROTIPO',prop:'SelectedValue_set'},{av:'AV80TFParametroPrioritaria_Sels',fld:'vTFPARAMETROPRIORITARIA_SELS',pic:''},{av:'Ddo_parametroprioritaria_Selectedvalue_set',ctrl:'DDO_PARAMETROPRIORITARIA',prop:'SelectedValue_set'},{av:'AV83TFParametroValor',fld:'vTFPARAMETROVALOR',pic:'ZZZ,ZZZ,ZZ9.99'},{av:'Ddo_parametrovalor_Filteredtext_set',ctrl:'DDO_PARAMETROVALOR',prop:'FilteredText_set'},{av:'AV84TFParametroValor_To',fld:'vTFPARAMETROVALOR_TO',pic:'ZZZ,ZZZ,ZZ9.99'},{av:'Ddo_parametrovalor_Filteredtextto_set',ctrl:'DDO_PARAMETROVALOR',prop:'FilteredTextTo_set'},{av:'AV87TFParametroPercentual',fld:'vTFPARAMETROPERCENTUAL',pic:'ZZ9.99'},{av:'Ddo_parametropercentual_Filteredtext_set',ctrl:'DDO_PARAMETROPERCENTUAL',prop:'FilteredText_set'},{av:'AV88TFParametroPercentual_To',fld:'vTFPARAMETROPERCENTUAL_TO',pic:'ZZ9.99'},{av:'Ddo_parametropercentual_Filteredtextto_set',ctrl:'DDO_PARAMETROPERCENTUAL',prop:'FilteredTextTo_set'},{av:'Ddo_parametropercentual_Sortedstatus',ctrl:'DDO_PARAMETROPERCENTUAL',prop:'SortedStatus'},{av:'Ddo_parametrovalor_Sortedstatus',ctrl:'DDO_PARAMETROVALOR',prop:'SortedStatus'},{av:'Ddo_parametroprioritaria_Sortedstatus',ctrl:'DDO_PARAMETROPRIORITARIA',prop:'SortedStatus'},{av:'Ddo_parametrotipo_Sortedstatus',ctrl:'DDO_PARAMETROTIPO',prop:'SortedStatus'},{av:'Ddo_parametrodtvigenciafim_Sortedstatus',ctrl:'DDO_PARAMETRODTVIGENCIAFIM',prop:'SortedStatus'},{av:'Ddo_parametrodtvigenciaini_Sortedstatus',ctrl:'DDO_PARAMETRODTVIGENCIAINI',prop:'SortedStatus'},{av:'AV62ParametroDtVigenciaIniTitleFilterData',fld:'vPARAMETRODTVIGENCIAINITITLEFILTERDATA',pic:''},{av:'AV68ParametroDtVigenciaFimTitleFilterData',fld:'vPARAMETRODTVIGENCIAFIMTITLEFILTERDATA',pic:''},{av:'AV74ParametroTipoTitleFilterData',fld:'vPARAMETROTIPOTITLEFILTERDATA',pic:''},{av:'AV78ParametroPrioritariaTitleFilterData',fld:'vPARAMETROPRIORITARIATITLEFILTERDATA',pic:''},{av:'AV82ParametroValorTitleFilterData',fld:'vPARAMETROVALORTITLEFILTERDATA',pic:''},{av:'AV86ParametroPercentualTitleFilterData',fld:'vPARAMETROPERCENTUALTITLEFILTERDATA',pic:''},{av:'AV44ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtParametroDtVigenciaIni_Visible',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Visible'},{av:'edtParametroDtVigenciaFim_Visible',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Visible'},{av:'cmbParametroTipo'},{av:'cmbParametroPrioritaria'},{av:'edtParametroValor_Visible',ctrl:'PARAMETROVALOR',prop:'Visible'},{av:'edtParametroPercentual_Visible',ctrl:'PARAMETROPERCENTUAL',prop:'Visible'},{av:'edtParametroDtVigenciaIni_Titleformat',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Titleformat'},{av:'edtParametroDtVigenciaIni_Title',ctrl:'PARAMETRODTVIGENCIAINI',prop:'Title'},{av:'edtParametroDtVigenciaFim_Titleformat',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Titleformat'},{av:'edtParametroDtVigenciaFim_Title',ctrl:'PARAMETRODTVIGENCIAFIM',prop:'Title'},{av:'edtParametroValor_Titleformat',ctrl:'PARAMETROVALOR',prop:'Titleformat'},{av:'edtParametroValor_Title',ctrl:'PARAMETROVALOR',prop:'Title'},{av:'edtParametroPercentual_Titleformat',ctrl:'PARAMETROPERCENTUAL',prop:'Titleformat'},{av:'edtParametroPercentual_Title',ctrl:'PARAMETROPERCENTUAL',prop:'Title'},{av:'AV92GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV93GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV56ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''}]}");
         setEventMetadata("'DOINSERT'","{handler:'E210V2',iparms:[{av:'A13ParametroID',fld:'PARAMETROID',pic:'ZZZ9',hsh:true}]");
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
         Ddo_parametrodtvigenciaini_Activeeventkey = "";
         Ddo_parametrodtvigenciaini_Filteredtext_get = "";
         Ddo_parametrodtvigenciaini_Filteredtextto_get = "";
         Ddo_parametrodtvigenciafim_Activeeventkey = "";
         Ddo_parametrodtvigenciafim_Filteredtext_get = "";
         Ddo_parametrodtvigenciafim_Filteredtextto_get = "";
         Ddo_parametrotipo_Activeeventkey = "";
         Ddo_parametrotipo_Selectedvalue_get = "";
         Ddo_parametroprioritaria_Activeeventkey = "";
         Ddo_parametroprioritaria_Selectedvalue_get = "";
         Ddo_parametrovalor_Activeeventkey = "";
         Ddo_parametrovalor_Filteredtext_get = "";
         Ddo_parametrovalor_Filteredtextto_get = "";
         Ddo_parametropercentual_Activeeventkey = "";
         Ddo_parametropercentual_Filteredtext_get = "";
         Ddo_parametropercentual_Filteredtextto_get = "";
         Ddo_gridcolumnsselector_Columnsselectorvalues = "";
         Ddo_managefilters_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV63TFParametroDtVigenciaIni = DateTime.MinValue;
         AV64TFParametroDtVigenciaIni_To = DateTime.MinValue;
         AV69TFParametroDtVigenciaFim = DateTime.MinValue;
         AV70TFParametroDtVigenciaFim_To = DateTime.MinValue;
         AV44ColumnsSelector = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector(context);
         AV67ddo_ParametroDtVigenciaIniTitleControlIdToReplace = "";
         AV73ddo_ParametroDtVigenciaFimTitleControlIdToReplace = "";
         AV77ddo_ParametroTipoTitleControlIdToReplace = "";
         AV81ddo_ParametroPrioritariaTitleControlIdToReplace = "";
         AV85ddo_ParametroValorTitleControlIdToReplace = "";
         AV89ddo_ParametroPercentualTitleControlIdToReplace = "";
         AV76TFParametroTipo_Sels = new GxSimpleCollection<String>();
         AV80TFParametroPrioritaria_Sels = new GxSimpleCollection<String>();
         AV108Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV56ManageFiltersData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV90DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV62ParametroDtVigenciaIniTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV68ParametroDtVigenciaFimTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV74ParametroTipoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV78ParametroPrioritariaTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV82ParametroValorTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV86ParametroPercentualTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV10GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         Ddo_parametrodtvigenciaini_Filteredtext_set = "";
         Ddo_parametrodtvigenciaini_Filteredtextto_set = "";
         Ddo_parametrodtvigenciaini_Sortedstatus = "";
         Ddo_parametrodtvigenciafim_Filteredtext_set = "";
         Ddo_parametrodtvigenciafim_Filteredtextto_set = "";
         Ddo_parametrodtvigenciafim_Sortedstatus = "";
         Ddo_parametrotipo_Selectedvalue_set = "";
         Ddo_parametrotipo_Sortedstatus = "";
         Ddo_parametroprioritaria_Selectedvalue_set = "";
         Ddo_parametroprioritaria_Sortedstatus = "";
         Ddo_parametrovalor_Filteredtext_set = "";
         Ddo_parametrovalor_Filteredtextto_set = "";
         Ddo_parametrovalor_Sortedstatus = "";
         Ddo_parametropercentual_Filteredtext_set = "";
         Ddo_parametropercentual_Filteredtextto_set = "";
         Ddo_parametropercentual_Sortedstatus = "";
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
         AV94Update = "";
         AV95Delete = "";
         A14ParametroDtVigenciaIni = DateTime.MinValue;
         A15ParametroDtVigenciaFim = DateTime.MinValue;
         A16ParametroTipo = "";
         A17ParametroPrioritaria = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_parametrodtvigenciaini = new GXUserControl();
         ucDdo_parametrodtvigenciafim = new GXUserControl();
         ucDdo_parametrotipo = new GXUserControl();
         ucDdo_parametroprioritaria = new GXUserControl();
         ucDdo_parametrovalor = new GXUserControl();
         ucDdo_parametropercentual = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         ucDdo_gridcolumnsselector = new GXUserControl();
         AV65DDO_ParametroDtVigenciaIniAuxDate = DateTime.MinValue;
         AV66DDO_ParametroDtVigenciaIniAuxDateTo = DateTime.MinValue;
         AV71DDO_ParametroDtVigenciaFimAuxDate = DateTime.MinValue;
         AV72DDO_ParametroDtVigenciaFimAuxDateTo = DateTime.MinValue;
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV102ParametroWWDS_5_Tfparametrotipo_sels = new GxSimpleCollection<String>();
         AV103ParametroWWDS_6_Tfparametroprioritaria_sels = new GxSimpleCollection<String>();
         scmdbuf = "";
         AV98ParametroWWDS_1_Tfparametrodtvigenciaini = DateTime.MinValue;
         AV99ParametroWWDS_2_Tfparametrodtvigenciaini_to = DateTime.MinValue;
         AV100ParametroWWDS_3_Tfparametrodtvigenciafim = DateTime.MinValue;
         AV101ParametroWWDS_4_Tfparametrodtvigenciafim_to = DateTime.MinValue;
         H000V2_A19ParametroPercentual = new decimal[1] ;
         H000V2_A18ParametroValor = new decimal[1] ;
         H000V2_A17ParametroPrioritaria = new String[] {""} ;
         H000V2_A16ParametroTipo = new String[] {""} ;
         H000V2_A15ParametroDtVigenciaFim = new DateTime[] {DateTime.MinValue} ;
         H000V2_A14ParametroDtVigenciaIni = new DateTime[] {DateTime.MinValue} ;
         H000V2_A13ParametroID = new short[1] ;
         H000V3_AGRID_nRecordCount = new long[1] ;
         AV7HTTPRequest = new GxHttpRequest( context);
         ucDdo_managefilters = new GXUserControl();
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV51Session = context.GetSession();
         AV32ColumnsSelectorXML = "";
         AV75TFParametroTipo_SelsJson = "";
         AV79TFParametroPrioritaria_SelsJson = "";
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
         Ddo_managefilters_Caption = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.parametroww__default(),
            new Object[][] {
                new Object[] {
               H000V2_A19ParametroPercentual, H000V2_A18ParametroValor, H000V2_A17ParametroPrioritaria, H000V2_A16ParametroTipo, H000V2_A15ParametroDtVigenciaFim, H000V2_A14ParametroDtVigenciaIni, H000V2_A13ParametroID
               }
               , new Object[] {
               H000V3_AGRID_nRecordCount
               }
            }
         );
         AV108Pgmname = "ParametroWW";
         /* GeneXus formulas. */
         AV108Pgmname = "ParametroWW";
         context.Gx_err = 0;
         edtavUpdate_Enabled = 0;
         edtavDelete_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_36 ;
      private short nGXsfl_36_idx=1 ;
      private short GRID_nEOF ;
      private short AV13OrderedBy ;
      private short AV52ManageFiltersExecutionStep ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
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
      private int subGrid_Rows ;
      private int Gridpaginationbar_Rowsperpageselectedvalue ;
      private int Gridpaginationbar_Pagestoshow ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtParametroDtVigenciaIni_Visible ;
      private int edtParametroDtVigenciaFim_Visible ;
      private int edtParametroValor_Visible ;
      private int edtParametroPercentual_Visible ;
      private int edtavUpdate_Enabled ;
      private int edtavDelete_Enabled ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_parametrodtvigenciainititlecontrolidtoreplace_Visible ;
      private int edtavDdo_parametrodtvigenciafimtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_parametrotipotitlecontrolidtoreplace_Visible ;
      private int edtavDdo_parametroprioritariatitlecontrolidtoreplace_Visible ;
      private int edtavDdo_parametrovalortitlecontrolidtoreplace_Visible ;
      private int edtavDdo_parametropercentualtitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int edtavManagefiltersexecutionstep_Visible ;
      private int edtavTfparametrodtvigenciaini_Visible ;
      private int edtavTfparametrodtvigenciaini_to_Visible ;
      private int edtavTfparametrodtvigenciafim_Visible ;
      private int edtavTfparametrodtvigenciafim_to_Visible ;
      private int edtavTfparametrovalor_Visible ;
      private int edtavTfparametrovalor_to_Visible ;
      private int edtavTfparametropercentual_Visible ;
      private int edtavTfparametropercentual_to_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV102ParametroWWDS_5_Tfparametrotipo_sels_Count ;
      private int AV103ParametroWWDS_6_Tfparametroprioritaria_sels_Count ;
      private int AV91PageToGo ;
      private int AV109GXV1 ;
      private int AV110GXV2 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long AV92GridCurrentPage ;
      private long AV93GridPageCount ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private decimal AV83TFParametroValor ;
      private decimal AV84TFParametroValor_To ;
      private decimal AV87TFParametroPercentual ;
      private decimal AV88TFParametroPercentual_To ;
      private decimal A18ParametroValor ;
      private decimal A19ParametroPercentual ;
      private decimal AV104ParametroWWDS_7_Tfparametrovalor ;
      private decimal AV105ParametroWWDS_8_Tfparametrovalor_to ;
      private decimal AV106ParametroWWDS_9_Tfparametropercentual ;
      private decimal AV107ParametroWWDS_10_Tfparametropercentual_to ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_parametrodtvigenciaini_Activeeventkey ;
      private String Ddo_parametrodtvigenciaini_Filteredtext_get ;
      private String Ddo_parametrodtvigenciaini_Filteredtextto_get ;
      private String Ddo_parametrodtvigenciafim_Activeeventkey ;
      private String Ddo_parametrodtvigenciafim_Filteredtext_get ;
      private String Ddo_parametrodtvigenciafim_Filteredtextto_get ;
      private String Ddo_parametrotipo_Activeeventkey ;
      private String Ddo_parametrotipo_Selectedvalue_get ;
      private String Ddo_parametroprioritaria_Activeeventkey ;
      private String Ddo_parametroprioritaria_Selectedvalue_get ;
      private String Ddo_parametrovalor_Activeeventkey ;
      private String Ddo_parametrovalor_Filteredtext_get ;
      private String Ddo_parametrovalor_Filteredtextto_get ;
      private String Ddo_parametropercentual_Activeeventkey ;
      private String Ddo_parametropercentual_Filteredtext_get ;
      private String Ddo_parametropercentual_Filteredtextto_get ;
      private String Ddo_gridcolumnsselector_Columnsselectorvalues ;
      private String Ddo_managefilters_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_36_idx="0001" ;
      private String AV108Pgmname ;
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
      private String Ddo_parametrodtvigenciaini_Caption ;
      private String Ddo_parametrodtvigenciaini_Tooltip ;
      private String Ddo_parametrodtvigenciaini_Cls ;
      private String Ddo_parametrodtvigenciaini_Filteredtext_set ;
      private String Ddo_parametrodtvigenciaini_Filteredtextto_set ;
      private String Ddo_parametrodtvigenciaini_Dropdownoptionstype ;
      private String Ddo_parametrodtvigenciaini_Titlecontrolidtoreplace ;
      private String Ddo_parametrodtvigenciaini_Sortedstatus ;
      private String Ddo_parametrodtvigenciaini_Filtertype ;
      private String Ddo_parametrodtvigenciaini_Sortasc ;
      private String Ddo_parametrodtvigenciaini_Sortdsc ;
      private String Ddo_parametrodtvigenciaini_Cleanfilter ;
      private String Ddo_parametrodtvigenciaini_Rangefilterfrom ;
      private String Ddo_parametrodtvigenciaini_Rangefilterto ;
      private String Ddo_parametrodtvigenciaini_Searchbuttontext ;
      private String Ddo_parametrodtvigenciafim_Caption ;
      private String Ddo_parametrodtvigenciafim_Tooltip ;
      private String Ddo_parametrodtvigenciafim_Cls ;
      private String Ddo_parametrodtvigenciafim_Filteredtext_set ;
      private String Ddo_parametrodtvigenciafim_Filteredtextto_set ;
      private String Ddo_parametrodtvigenciafim_Dropdownoptionstype ;
      private String Ddo_parametrodtvigenciafim_Titlecontrolidtoreplace ;
      private String Ddo_parametrodtvigenciafim_Sortedstatus ;
      private String Ddo_parametrodtvigenciafim_Filtertype ;
      private String Ddo_parametrodtvigenciafim_Sortasc ;
      private String Ddo_parametrodtvigenciafim_Sortdsc ;
      private String Ddo_parametrodtvigenciafim_Cleanfilter ;
      private String Ddo_parametrodtvigenciafim_Rangefilterfrom ;
      private String Ddo_parametrodtvigenciafim_Rangefilterto ;
      private String Ddo_parametrodtvigenciafim_Searchbuttontext ;
      private String Ddo_parametrotipo_Caption ;
      private String Ddo_parametrotipo_Tooltip ;
      private String Ddo_parametrotipo_Cls ;
      private String Ddo_parametrotipo_Selectedvalue_set ;
      private String Ddo_parametrotipo_Dropdownoptionstype ;
      private String Ddo_parametrotipo_Titlecontrolidtoreplace ;
      private String Ddo_parametrotipo_Sortedstatus ;
      private String Ddo_parametrotipo_Datalisttype ;
      private String Ddo_parametrotipo_Datalistfixedvalues ;
      private String Ddo_parametrotipo_Sortasc ;
      private String Ddo_parametrotipo_Sortdsc ;
      private String Ddo_parametrotipo_Cleanfilter ;
      private String Ddo_parametrotipo_Searchbuttontext ;
      private String Ddo_parametroprioritaria_Caption ;
      private String Ddo_parametroprioritaria_Tooltip ;
      private String Ddo_parametroprioritaria_Cls ;
      private String Ddo_parametroprioritaria_Selectedvalue_set ;
      private String Ddo_parametroprioritaria_Dropdownoptionstype ;
      private String Ddo_parametroprioritaria_Titlecontrolidtoreplace ;
      private String Ddo_parametroprioritaria_Sortedstatus ;
      private String Ddo_parametroprioritaria_Datalisttype ;
      private String Ddo_parametroprioritaria_Datalistfixedvalues ;
      private String Ddo_parametroprioritaria_Sortasc ;
      private String Ddo_parametroprioritaria_Sortdsc ;
      private String Ddo_parametroprioritaria_Cleanfilter ;
      private String Ddo_parametroprioritaria_Searchbuttontext ;
      private String Ddo_parametrovalor_Caption ;
      private String Ddo_parametrovalor_Tooltip ;
      private String Ddo_parametrovalor_Cls ;
      private String Ddo_parametrovalor_Filteredtext_set ;
      private String Ddo_parametrovalor_Filteredtextto_set ;
      private String Ddo_parametrovalor_Dropdownoptionstype ;
      private String Ddo_parametrovalor_Titlecontrolidtoreplace ;
      private String Ddo_parametrovalor_Sortedstatus ;
      private String Ddo_parametrovalor_Filtertype ;
      private String Ddo_parametrovalor_Sortasc ;
      private String Ddo_parametrovalor_Sortdsc ;
      private String Ddo_parametrovalor_Cleanfilter ;
      private String Ddo_parametrovalor_Rangefilterfrom ;
      private String Ddo_parametrovalor_Rangefilterto ;
      private String Ddo_parametrovalor_Searchbuttontext ;
      private String Ddo_parametropercentual_Caption ;
      private String Ddo_parametropercentual_Tooltip ;
      private String Ddo_parametropercentual_Cls ;
      private String Ddo_parametropercentual_Filteredtext_set ;
      private String Ddo_parametropercentual_Filteredtextto_set ;
      private String Ddo_parametropercentual_Dropdownoptionstype ;
      private String Ddo_parametropercentual_Titlecontrolidtoreplace ;
      private String Ddo_parametropercentual_Sortedstatus ;
      private String Ddo_parametropercentual_Filtertype ;
      private String Ddo_parametropercentual_Sortasc ;
      private String Ddo_parametropercentual_Sortdsc ;
      private String Ddo_parametropercentual_Cleanfilter ;
      private String Ddo_parametropercentual_Rangefilterfrom ;
      private String Ddo_parametropercentual_Rangefilterto ;
      private String Ddo_parametropercentual_Searchbuttontext ;
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
      private String edtParametroDtVigenciaIni_Title ;
      private String edtParametroDtVigenciaFim_Title ;
      private String edtParametroValor_Title ;
      private String edtParametroPercentual_Title ;
      private String subGrid_Header ;
      private String AV94Update ;
      private String edtavUpdate_Link ;
      private String AV95Delete ;
      private String edtavDelete_Link ;
      private String edtParametroDtVigenciaIni_Link ;
      private String A16ParametroTipo ;
      private String A17ParametroPrioritaria ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
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
      private String Ddo_gridcolumnsselector_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String edtavManagefiltersexecutionstep_Internalname ;
      private String edtavManagefiltersexecutionstep_Jsonclick ;
      private String edtavTfparametrodtvigenciaini_Internalname ;
      private String edtavTfparametrodtvigenciaini_Jsonclick ;
      private String edtavTfparametrodtvigenciaini_to_Internalname ;
      private String edtavTfparametrodtvigenciaini_to_Jsonclick ;
      private String divDdo_parametrodtvigenciainiauxdates_Internalname ;
      private String edtavDdo_parametrodtvigenciainiauxdate_Internalname ;
      private String edtavDdo_parametrodtvigenciainiauxdate_Jsonclick ;
      private String edtavDdo_parametrodtvigenciainiauxdateto_Internalname ;
      private String edtavDdo_parametrodtvigenciainiauxdateto_Jsonclick ;
      private String edtavTfparametrodtvigenciafim_Internalname ;
      private String edtavTfparametrodtvigenciafim_Jsonclick ;
      private String edtavTfparametrodtvigenciafim_to_Internalname ;
      private String edtavTfparametrodtvigenciafim_to_Jsonclick ;
      private String divDdo_parametrodtvigenciafimauxdates_Internalname ;
      private String edtavDdo_parametrodtvigenciafimauxdate_Internalname ;
      private String edtavDdo_parametrodtvigenciafimauxdate_Jsonclick ;
      private String edtavDdo_parametrodtvigenciafimauxdateto_Internalname ;
      private String edtavDdo_parametrodtvigenciafimauxdateto_Jsonclick ;
      private String edtavTfparametrovalor_Internalname ;
      private String edtavTfparametrovalor_Jsonclick ;
      private String edtavTfparametrovalor_to_Internalname ;
      private String edtavTfparametrovalor_to_Jsonclick ;
      private String edtavTfparametropercentual_Internalname ;
      private String edtavTfparametropercentual_Jsonclick ;
      private String edtavTfparametropercentual_to_Internalname ;
      private String edtavTfparametropercentual_to_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavUpdate_Internalname ;
      private String edtavDelete_Internalname ;
      private String edtParametroID_Internalname ;
      private String edtParametroDtVigenciaIni_Internalname ;
      private String edtParametroDtVigenciaFim_Internalname ;
      private String cmbParametroTipo_Internalname ;
      private String cmbParametroPrioritaria_Internalname ;
      private String edtParametroValor_Internalname ;
      private String edtParametroPercentual_Internalname ;
      private String scmdbuf ;
      private String Ddo_managefilters_Internalname ;
      private String GXt_char2 ;
      private String tblTablerightheader_Internalname ;
      private String Ddo_managefilters_Caption ;
      private String sGXsfl_36_fel_idx="0001" ;
      private String ROClassString ;
      private String edtavUpdate_Jsonclick ;
      private String edtavDelete_Jsonclick ;
      private String edtParametroID_Jsonclick ;
      private String edtParametroDtVigenciaIni_Jsonclick ;
      private String edtParametroDtVigenciaFim_Jsonclick ;
      private String GXCCtl ;
      private String cmbParametroTipo_Jsonclick ;
      private String cmbParametroPrioritaria_Jsonclick ;
      private String edtParametroValor_Jsonclick ;
      private String edtParametroPercentual_Jsonclick ;
      private DateTime AV63TFParametroDtVigenciaIni ;
      private DateTime AV64TFParametroDtVigenciaIni_To ;
      private DateTime AV69TFParametroDtVigenciaFim ;
      private DateTime AV70TFParametroDtVigenciaFim_To ;
      private DateTime A14ParametroDtVigenciaIni ;
      private DateTime A15ParametroDtVigenciaFim ;
      private DateTime AV65DDO_ParametroDtVigenciaIniAuxDate ;
      private DateTime AV66DDO_ParametroDtVigenciaIniAuxDateTo ;
      private DateTime AV71DDO_ParametroDtVigenciaFimAuxDate ;
      private DateTime AV72DDO_ParametroDtVigenciaFimAuxDateTo ;
      private DateTime AV98ParametroWWDS_1_Tfparametrodtvigenciaini ;
      private DateTime AV99ParametroWWDS_2_Tfparametrodtvigenciaini_to ;
      private DateTime AV100ParametroWWDS_3_Tfparametrodtvigenciafim ;
      private DateTime AV101ParametroWWDS_4_Tfparametrodtvigenciafim_to ;
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
      private bool Ddo_parametrodtvigenciaini_Includesortasc ;
      private bool Ddo_parametrodtvigenciaini_Includesortdsc ;
      private bool Ddo_parametrodtvigenciaini_Includefilter ;
      private bool Ddo_parametrodtvigenciaini_Filterisrange ;
      private bool Ddo_parametrodtvigenciaini_Includedatalist ;
      private bool Ddo_parametrodtvigenciafim_Includesortasc ;
      private bool Ddo_parametrodtvigenciafim_Includesortdsc ;
      private bool Ddo_parametrodtvigenciafim_Includefilter ;
      private bool Ddo_parametrodtvigenciafim_Filterisrange ;
      private bool Ddo_parametrodtvigenciafim_Includedatalist ;
      private bool Ddo_parametrotipo_Includesortasc ;
      private bool Ddo_parametrotipo_Includesortdsc ;
      private bool Ddo_parametrotipo_Includefilter ;
      private bool Ddo_parametrotipo_Includedatalist ;
      private bool Ddo_parametrotipo_Allowmultipleselection ;
      private bool Ddo_parametroprioritaria_Includesortasc ;
      private bool Ddo_parametroprioritaria_Includesortdsc ;
      private bool Ddo_parametroprioritaria_Includefilter ;
      private bool Ddo_parametroprioritaria_Includedatalist ;
      private bool Ddo_parametroprioritaria_Allowmultipleselection ;
      private bool Ddo_parametrovalor_Includesortasc ;
      private bool Ddo_parametrovalor_Includesortdsc ;
      private bool Ddo_parametrovalor_Includefilter ;
      private bool Ddo_parametrovalor_Filterisrange ;
      private bool Ddo_parametrovalor_Includedatalist ;
      private bool Ddo_parametropercentual_Includesortasc ;
      private bool Ddo_parametropercentual_Includesortdsc ;
      private bool Ddo_parametropercentual_Includefilter ;
      private bool Ddo_parametropercentual_Filterisrange ;
      private bool Ddo_parametropercentual_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_36_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private String AV32ColumnsSelectorXML ;
      private String AV75TFParametroTipo_SelsJson ;
      private String AV79TFParametroPrioritaria_SelsJson ;
      private String AV53ManageFiltersXml ;
      private String AV39UserCustomValue ;
      private String AV67ddo_ParametroDtVigenciaIniTitleControlIdToReplace ;
      private String AV73ddo_ParametroDtVigenciaFimTitleControlIdToReplace ;
      private String AV77ddo_ParametroTipoTitleControlIdToReplace ;
      private String AV81ddo_ParametroPrioritariaTitleControlIdToReplace ;
      private String AV85ddo_ParametroValorTitleControlIdToReplace ;
      private String AV89ddo_ParametroPercentualTitleControlIdToReplace ;
      private IGxSession AV51Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_parametrodtvigenciaini ;
      private GXUserControl ucDdo_parametrodtvigenciafim ;
      private GXUserControl ucDdo_parametrotipo ;
      private GXUserControl ucDdo_parametroprioritaria ;
      private GXUserControl ucDdo_parametrovalor ;
      private GXUserControl ucDdo_parametropercentual ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXUserControl ucDdo_gridcolumnsselector ;
      private GXUserControl ucDdo_managefilters ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbParametroTipo ;
      private GXCombobox cmbParametroPrioritaria ;
      private IDataStoreProvider pr_default ;
      private decimal[] H000V2_A19ParametroPercentual ;
      private decimal[] H000V2_A18ParametroValor ;
      private String[] H000V2_A17ParametroPrioritaria ;
      private String[] H000V2_A16ParametroTipo ;
      private DateTime[] H000V2_A15ParametroDtVigenciaFim ;
      private DateTime[] H000V2_A14ParametroDtVigenciaIni ;
      private short[] H000V2_A13ParametroID ;
      private long[] H000V3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV7HTTPRequest ;
      private GxSimpleCollection<String> AV76TFParametroTipo_Sels ;
      private GxSimpleCollection<String> AV80TFParametroPrioritaria_Sels ;
      private GxSimpleCollection<String> AV102ParametroWWDS_5_Tfparametrotipo_sels ;
      private GxSimpleCollection<String> AV103ParametroWWDS_6_Tfparametroprioritaria_sels ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item> AV54ManageFiltersItems ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV56ManageFiltersData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV62ParametroDtVigenciaIniTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV68ParametroDtVigenciaFimTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV74ParametroTipoTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV78ParametroPrioritariaTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV82ParametroValorTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV86ParametroPercentualTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV8TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV10GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV11GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector AV44ColumnsSelector ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector AV45ColumnsSelectorAux ;
      private GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item AV55ManageFiltersItem ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item AV57ManageFiltersDataItem ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV90DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class parametroww__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H000V2( IGxContext context ,
                                             String A16ParametroTipo ,
                                             GxSimpleCollection<String> AV102ParametroWWDS_5_Tfparametrotipo_sels ,
                                             String A17ParametroPrioritaria ,
                                             GxSimpleCollection<String> AV103ParametroWWDS_6_Tfparametroprioritaria_sels ,
                                             DateTime AV98ParametroWWDS_1_Tfparametrodtvigenciaini ,
                                             DateTime AV99ParametroWWDS_2_Tfparametrodtvigenciaini_to ,
                                             DateTime AV100ParametroWWDS_3_Tfparametrodtvigenciafim ,
                                             DateTime AV101ParametroWWDS_4_Tfparametrodtvigenciafim_to ,
                                             int AV102ParametroWWDS_5_Tfparametrotipo_sels_Count ,
                                             int AV103ParametroWWDS_6_Tfparametroprioritaria_sels_Count ,
                                             decimal AV104ParametroWWDS_7_Tfparametrovalor ,
                                             decimal AV105ParametroWWDS_8_Tfparametrovalor_to ,
                                             decimal AV106ParametroWWDS_9_Tfparametropercentual ,
                                             decimal AV107ParametroWWDS_10_Tfparametropercentual_to ,
                                             DateTime A14ParametroDtVigenciaIni ,
                                             DateTime A15ParametroDtVigenciaFim ,
                                             decimal A18ParametroValor ,
                                             decimal A19ParametroPercentual ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [11] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [ParametroPercentual], [ParametroValor], [ParametroPrioritaria], [ParametroTipo], [ParametroDtVigenciaFim], [ParametroDtVigenciaIni], [ParametroID]";
         sFromString = " FROM [Parametro]";
         sOrderString = "";
         if ( ! (DateTime.MinValue==AV98ParametroWWDS_1_Tfparametrodtvigenciaini) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaIni] >= @AV98ParametroWWDS_1_Tfparametrodtvigenciaini)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaIni] >= @AV98ParametroWWDS_1_Tfparametrodtvigenciaini)";
            }
         }
         else
         {
            GXv_int3[0] = 1;
         }
         if ( ! (DateTime.MinValue==AV99ParametroWWDS_2_Tfparametrodtvigenciaini_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaIni] <= @AV99ParametroWWDS_2_Tfparametrodtvigenciaini_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaIni] <= @AV99ParametroWWDS_2_Tfparametrodtvigenciaini_to)";
            }
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (DateTime.MinValue==AV100ParametroWWDS_3_Tfparametrodtvigenciafim) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaFim] >= @AV100ParametroWWDS_3_Tfparametrodtvigenciafim)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaFim] >= @AV100ParametroWWDS_3_Tfparametrodtvigenciafim)";
            }
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (DateTime.MinValue==AV101ParametroWWDS_4_Tfparametrodtvigenciafim_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaFim] <= @AV101ParametroWWDS_4_Tfparametrodtvigenciafim_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaFim] <= @AV101ParametroWWDS_4_Tfparametrodtvigenciafim_to)";
            }
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( AV102ParametroWWDS_5_Tfparametrotipo_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV102ParametroWWDS_5_Tfparametrotipo_sels, "[ParametroTipo] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV102ParametroWWDS_5_Tfparametrotipo_sels, "[ParametroTipo] IN (", ")") + ")";
            }
         }
         if ( AV103ParametroWWDS_6_Tfparametroprioritaria_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV103ParametroWWDS_6_Tfparametroprioritaria_sels, "[ParametroPrioritaria] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV103ParametroWWDS_6_Tfparametroprioritaria_sels, "[ParametroPrioritaria] IN (", ")") + ")";
            }
         }
         if ( ! (Convert.ToDecimal(0)==AV104ParametroWWDS_7_Tfparametrovalor) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroValor] >= @AV104ParametroWWDS_7_Tfparametrovalor)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroValor] >= @AV104ParametroWWDS_7_Tfparametrovalor)";
            }
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV105ParametroWWDS_8_Tfparametrovalor_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroValor] <= @AV105ParametroWWDS_8_Tfparametrovalor_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroValor] <= @AV105ParametroWWDS_8_Tfparametrovalor_to)";
            }
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV106ParametroWWDS_9_Tfparametropercentual) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroPercentual] >= @AV106ParametroWWDS_9_Tfparametropercentual)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroPercentual] >= @AV106ParametroWWDS_9_Tfparametropercentual)";
            }
         }
         else
         {
            GXv_int3[6] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV107ParametroWWDS_10_Tfparametropercentual_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroPercentual] <= @AV107ParametroWWDS_10_Tfparametropercentual_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroPercentual] <= @AV107ParametroWWDS_10_Tfparametropercentual_to)";
            }
         }
         else
         {
            GXv_int3[7] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         if ( ( AV13OrderedBy == 1 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [ParametroDtVigenciaIni]";
         }
         else if ( ( AV13OrderedBy == 1 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [ParametroDtVigenciaIni] DESC";
         }
         else if ( ( AV13OrderedBy == 2 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [ParametroDtVigenciaFim]";
         }
         else if ( ( AV13OrderedBy == 2 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [ParametroDtVigenciaFim] DESC";
         }
         else if ( ( AV13OrderedBy == 3 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [ParametroTipo]";
         }
         else if ( ( AV13OrderedBy == 3 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [ParametroTipo] DESC";
         }
         else if ( ( AV13OrderedBy == 4 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [ParametroPrioritaria]";
         }
         else if ( ( AV13OrderedBy == 4 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [ParametroPrioritaria] DESC";
         }
         else if ( ( AV13OrderedBy == 5 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [ParametroValor]";
         }
         else if ( ( AV13OrderedBy == 5 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [ParametroValor] DESC";
         }
         else if ( ( AV13OrderedBy == 6 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [ParametroPercentual]";
         }
         else if ( ( AV13OrderedBy == 6 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [ParametroPercentual] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [ParametroID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H000V3( IGxContext context ,
                                             String A16ParametroTipo ,
                                             GxSimpleCollection<String> AV102ParametroWWDS_5_Tfparametrotipo_sels ,
                                             String A17ParametroPrioritaria ,
                                             GxSimpleCollection<String> AV103ParametroWWDS_6_Tfparametroprioritaria_sels ,
                                             DateTime AV98ParametroWWDS_1_Tfparametrodtvigenciaini ,
                                             DateTime AV99ParametroWWDS_2_Tfparametrodtvigenciaini_to ,
                                             DateTime AV100ParametroWWDS_3_Tfparametrodtvigenciafim ,
                                             DateTime AV101ParametroWWDS_4_Tfparametrodtvigenciafim_to ,
                                             int AV102ParametroWWDS_5_Tfparametrotipo_sels_Count ,
                                             int AV103ParametroWWDS_6_Tfparametroprioritaria_sels_Count ,
                                             decimal AV104ParametroWWDS_7_Tfparametrovalor ,
                                             decimal AV105ParametroWWDS_8_Tfparametrovalor_to ,
                                             decimal AV106ParametroWWDS_9_Tfparametropercentual ,
                                             decimal AV107ParametroWWDS_10_Tfparametropercentual_to ,
                                             DateTime A14ParametroDtVigenciaIni ,
                                             DateTime A15ParametroDtVigenciaFim ,
                                             decimal A18ParametroValor ,
                                             decimal A19ParametroPercentual ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [8] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [Parametro]";
         if ( ! (DateTime.MinValue==AV98ParametroWWDS_1_Tfparametrodtvigenciaini) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaIni] >= @AV98ParametroWWDS_1_Tfparametrodtvigenciaini)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaIni] >= @AV98ParametroWWDS_1_Tfparametrodtvigenciaini)";
            }
         }
         else
         {
            GXv_int5[0] = 1;
         }
         if ( ! (DateTime.MinValue==AV99ParametroWWDS_2_Tfparametrodtvigenciaini_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaIni] <= @AV99ParametroWWDS_2_Tfparametrodtvigenciaini_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaIni] <= @AV99ParametroWWDS_2_Tfparametrodtvigenciaini_to)";
            }
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( ! (DateTime.MinValue==AV100ParametroWWDS_3_Tfparametrodtvigenciafim) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaFim] >= @AV100ParametroWWDS_3_Tfparametrodtvigenciafim)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaFim] >= @AV100ParametroWWDS_3_Tfparametrodtvigenciafim)";
            }
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( ! (DateTime.MinValue==AV101ParametroWWDS_4_Tfparametrodtvigenciafim_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroDtVigenciaFim] <= @AV101ParametroWWDS_4_Tfparametrodtvigenciafim_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroDtVigenciaFim] <= @AV101ParametroWWDS_4_Tfparametrodtvigenciafim_to)";
            }
         }
         else
         {
            GXv_int5[3] = 1;
         }
         if ( AV102ParametroWWDS_5_Tfparametrotipo_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV102ParametroWWDS_5_Tfparametrotipo_sels, "[ParametroTipo] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV102ParametroWWDS_5_Tfparametrotipo_sels, "[ParametroTipo] IN (", ")") + ")";
            }
         }
         if ( AV103ParametroWWDS_6_Tfparametroprioritaria_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV103ParametroWWDS_6_Tfparametroprioritaria_sels, "[ParametroPrioritaria] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV103ParametroWWDS_6_Tfparametroprioritaria_sels, "[ParametroPrioritaria] IN (", ")") + ")";
            }
         }
         if ( ! (Convert.ToDecimal(0)==AV104ParametroWWDS_7_Tfparametrovalor) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroValor] >= @AV104ParametroWWDS_7_Tfparametrovalor)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroValor] >= @AV104ParametroWWDS_7_Tfparametrovalor)";
            }
         }
         else
         {
            GXv_int5[4] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV105ParametroWWDS_8_Tfparametrovalor_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroValor] <= @AV105ParametroWWDS_8_Tfparametrovalor_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroValor] <= @AV105ParametroWWDS_8_Tfparametrovalor_to)";
            }
         }
         else
         {
            GXv_int5[5] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV106ParametroWWDS_9_Tfparametropercentual) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroPercentual] >= @AV106ParametroWWDS_9_Tfparametropercentual)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroPercentual] >= @AV106ParametroWWDS_9_Tfparametropercentual)";
            }
         }
         else
         {
            GXv_int5[6] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV107ParametroWWDS_10_Tfparametropercentual_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ParametroPercentual] <= @AV107ParametroWWDS_10_Tfparametropercentual_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([ParametroPercentual] <= @AV107ParametroWWDS_10_Tfparametropercentual_to)";
            }
         }
         else
         {
            GXv_int5[7] = 1;
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
                     return conditional_H000V2(context, (String)dynConstraints[0] , (GxSimpleCollection<String>)dynConstraints[1] , (String)dynConstraints[2] , (GxSimpleCollection<String>)dynConstraints[3] , (DateTime)dynConstraints[4] , (DateTime)dynConstraints[5] , (DateTime)dynConstraints[6] , (DateTime)dynConstraints[7] , (int)dynConstraints[8] , (int)dynConstraints[9] , (decimal)dynConstraints[10] , (decimal)dynConstraints[11] , (decimal)dynConstraints[12] , (decimal)dynConstraints[13] , (DateTime)dynConstraints[14] , (DateTime)dynConstraints[15] , (decimal)dynConstraints[16] , (decimal)dynConstraints[17] , (short)dynConstraints[18] , (bool)dynConstraints[19] );
               case 1 :
                     return conditional_H000V3(context, (String)dynConstraints[0] , (GxSimpleCollection<String>)dynConstraints[1] , (String)dynConstraints[2] , (GxSimpleCollection<String>)dynConstraints[3] , (DateTime)dynConstraints[4] , (DateTime)dynConstraints[5] , (DateTime)dynConstraints[6] , (DateTime)dynConstraints[7] , (int)dynConstraints[8] , (int)dynConstraints[9] , (decimal)dynConstraints[10] , (decimal)dynConstraints[11] , (decimal)dynConstraints[12] , (decimal)dynConstraints[13] , (DateTime)dynConstraints[14] , (DateTime)dynConstraints[15] , (decimal)dynConstraints[16] , (decimal)dynConstraints[17] , (short)dynConstraints[18] , (bool)dynConstraints[19] );
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
          Object[] prmH000V2 ;
          prmH000V2 = new Object[] {
          new Object[] {"@AV98ParametroWWDS_1_Tfparametrodtvigenciaini",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV99ParametroWWDS_2_Tfparametrodtvigenciaini_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV100ParametroWWDS_3_Tfparametrodtvigenciafim",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV101ParametroWWDS_4_Tfparametrodtvigenciafim_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV104ParametroWWDS_7_Tfparametrovalor",SqlDbType.Decimal,12,2} ,
          new Object[] {"@AV105ParametroWWDS_8_Tfparametrovalor_to",SqlDbType.Decimal,12,2} ,
          new Object[] {"@AV106ParametroWWDS_9_Tfparametropercentual",SqlDbType.Decimal,6,2} ,
          new Object[] {"@AV107ParametroWWDS_10_Tfparametropercentual_to",SqlDbType.Decimal,6,2} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH000V3 ;
          prmH000V3 = new Object[] {
          new Object[] {"@AV98ParametroWWDS_1_Tfparametrodtvigenciaini",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV99ParametroWWDS_2_Tfparametrodtvigenciaini_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV100ParametroWWDS_3_Tfparametrodtvigenciafim",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV101ParametroWWDS_4_Tfparametrodtvigenciafim_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV104ParametroWWDS_7_Tfparametrovalor",SqlDbType.Decimal,12,2} ,
          new Object[] {"@AV105ParametroWWDS_8_Tfparametrovalor_to",SqlDbType.Decimal,12,2} ,
          new Object[] {"@AV106ParametroWWDS_9_Tfparametropercentual",SqlDbType.Decimal,6,2} ,
          new Object[] {"@AV107ParametroWWDS_10_Tfparametropercentual_to",SqlDbType.Decimal,6,2}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000V2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000V2,11, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("H000V3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000V3,1, GxCacheFrequency.OFF ,true,false )
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
                   stmt.SetParameter(sIdx, (DateTime)parms[11]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[12]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[13]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[14]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[15]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[16]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[17]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[18]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[19]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[20]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[21]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[8]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[9]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[10]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[11]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[12]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[13]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[14]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[15]);
                }
                return;
       }
    }

 }

}
