/*
               File: ProdutoWW
        Description:  Produto
             Author: GeneXus C# Generator version 16_0_2-131213
       Generated on: 7/12/2019 17:59:57.4
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
   public class produtoww : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public produtoww( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public produtoww( IGxContext context )
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
               nRC_GXsfl_127 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_127_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_127_idx = GetNextPar( );
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
               AV18ProdutoNome1 = GetNextPar( );
               AV20DynamicFiltersSelector2 = GetNextPar( );
               AV21DynamicFiltersOperator2 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV22ProdutoNome2 = GetNextPar( );
               AV24DynamicFiltersSelector3 = GetNextPar( );
               AV25DynamicFiltersOperator3 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV26ProdutoNome3 = GetNextPar( );
               AV83ProdutoDtValidade = context.localUtil.ParseDateParm( GetNextPar( ));
               AV84ProdutoDtValidade_To = context.localUtil.ParseDateParm( GetNextPar( ));
               AV19DynamicFiltersEnabled2 = StringUtil.StrToBool( GetNextPar( ));
               AV23DynamicFiltersEnabled3 = StringUtil.StrToBool( GetNextPar( ));
               AV13OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV14OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV56TFProdutoId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV57TFProdutoId_To = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV60TFProdutoNome = GetNextPar( );
               AV61TFProdutoNome_Sel = GetNextPar( );
               AV68TFProdutoValor = NumberUtil.Val( GetNextPar( ), ".");
               AV69TFProdutoValor_To = NumberUtil.Val( GetNextPar( ), ".");
               AV72TFProdutoDtValidade = context.localUtil.ParseDateParm( GetNextPar( ));
               AV73TFProdutoDtValidade_To = context.localUtil.ParseDateParm( GetNextPar( ));
               AV49ManageFiltersExecutionStep = (short)(NumberUtil.Val( GetNextPar( ), "."));
               ajax_req_read_hidden_sdt(GetNextPar( ), AV41ColumnsSelector);
               AV58ddo_ProdutoIdTitleControlIdToReplace = GetNextPar( );
               AV62ddo_ProdutoNomeTitleControlIdToReplace = GetNextPar( );
               AV70ddo_ProdutoValorTitleControlIdToReplace = GetNextPar( );
               AV76ddo_ProdutoDtValidadeTitleControlIdToReplace = GetNextPar( );
               AV108Pgmname = GetNextPar( );
               ajax_req_read_hidden_sdt(GetNextPar( ), AV10GridState);
               AV28DynamicFiltersIgnoreFirst = StringUtil.StrToBool( GetNextPar( ));
               AV27DynamicFiltersRemoving = StringUtil.StrToBool( GetNextPar( ));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV16DynamicFiltersSelector1, AV17DynamicFiltersOperator1, AV18ProdutoNome1, AV20DynamicFiltersSelector2, AV21DynamicFiltersOperator2, AV22ProdutoNome2, AV24DynamicFiltersSelector3, AV25DynamicFiltersOperator3, AV26ProdutoNome3, AV83ProdutoDtValidade, AV84ProdutoDtValidade_To, AV19DynamicFiltersEnabled2, AV23DynamicFiltersEnabled3, AV13OrderedBy, AV14OrderedDsc, AV56TFProdutoId, AV57TFProdutoId_To, AV60TFProdutoNome, AV61TFProdutoNome_Sel, AV68TFProdutoValor, AV69TFProdutoValor_To, AV72TFProdutoDtValidade, AV73TFProdutoDtValidade_To, AV49ManageFiltersExecutionStep, AV41ColumnsSelector, AV58ddo_ProdutoIdTitleControlIdToReplace, AV62ddo_ProdutoNomeTitleControlIdToReplace, AV70ddo_ProdutoValorTitleControlIdToReplace, AV76ddo_ProdutoDtValidadeTitleControlIdToReplace, AV108Pgmname, AV10GridState, AV28DynamicFiltersIgnoreFirst, AV27DynamicFiltersRemoving) ;
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
         PA0R2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0R2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?201971217595748", false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("produtoww.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vPRODUTONOME1", AV18ProdutoNome1);
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSSELECTOR2", AV20DynamicFiltersSelector2);
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSOPERATOR2", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21DynamicFiltersOperator2), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vPRODUTONOME2", AV22ProdutoNome2);
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSSELECTOR3", AV24DynamicFiltersSelector3);
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSOPERATOR3", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV25DynamicFiltersOperator3), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vPRODUTONOME3", AV26ProdutoNome3);
         GxWebStd.gx_hidden_field( context, "GXH_vPRODUTODTVALIDADE", context.localUtil.Format(AV83ProdutoDtValidade, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vPRODUTODTVALIDADE_TO", context.localUtil.Format(AV84ProdutoDtValidade_To, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSENABLED2", StringUtil.BoolToStr( AV19DynamicFiltersEnabled2));
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSENABLED3", StringUtil.BoolToStr( AV23DynamicFiltersEnabled3));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV14OrderedDsc));
         GxWebStd.gx_hidden_field( context, "GXH_vTFPRODUTOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV56TFProdutoId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFPRODUTOID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV57TFProdutoId_To), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFPRODUTONOME", AV60TFProdutoNome);
         GxWebStd.gx_hidden_field( context, "GXH_vTFPRODUTONOME_SEL", AV61TFProdutoNome_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFPRODUTOVALOR", StringUtil.LTrim( StringUtil.NToC( AV68TFProdutoValor, 12, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFPRODUTOVALOR_TO", StringUtil.LTrim( StringUtil.NToC( AV69TFProdutoValor_To, 12, 2, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFPRODUTODTVALIDADE", context.localUtil.Format(AV72TFProdutoDtValidade, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vTFPRODUTODTVALIDADE_TO", context.localUtil.Format(AV73TFProdutoDtValidade_To, "99/99/99"));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_127", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_127), 4, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vMANAGEFILTERSDATA", AV53ManageFiltersData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vMANAGEFILTERSDATA", AV53ManageFiltersData);
         }
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV79GridCurrentPage), 10, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGECOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV80GridPageCount), 10, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV77DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV77DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPRODUTOIDTITLEFILTERDATA", AV55ProdutoIdTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPRODUTOIDTITLEFILTERDATA", AV55ProdutoIdTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPRODUTONOMETITLEFILTERDATA", AV59ProdutoNomeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPRODUTONOMETITLEFILTERDATA", AV59ProdutoNomeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPRODUTOVALORTITLEFILTERDATA", AV67ProdutoValorTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPRODUTOVALORTITLEFILTERDATA", AV67ProdutoValorTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPRODUTODTVALIDADETITLEFILTERDATA", AV71ProdutoDtValidadeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPRODUTODTVALIDADETITLEFILTERDATA", AV71ProdutoDtValidadeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vCOLUMNSSELECTOR", AV41ColumnsSelector);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vCOLUMNSSELECTOR", AV41ColumnsSelector);
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
         GxWebStd.gx_boolean_hidden_field( context, "vDYNAMICFILTERSIGNOREFIRST", AV28DynamicFiltersIgnoreFirst);
         GxWebStd.gx_boolean_hidden_field( context, "vDYNAMICFILTERSREMOVING", AV27DynamicFiltersRemoving);
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
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Caption", StringUtil.RTrim( Ddo_produtoid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Tooltip", StringUtil.RTrim( Ddo_produtoid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Cls", StringUtil.RTrim( Ddo_produtoid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Filteredtext_set", StringUtil.RTrim( Ddo_produtoid_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Filteredtextto_set", StringUtil.RTrim( Ddo_produtoid_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Dropdownoptionstype", StringUtil.RTrim( Ddo_produtoid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_produtoid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Includesortasc", StringUtil.BoolToStr( Ddo_produtoid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Includesortdsc", StringUtil.BoolToStr( Ddo_produtoid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Sortedstatus", StringUtil.RTrim( Ddo_produtoid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Includefilter", StringUtil.BoolToStr( Ddo_produtoid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Filtertype", StringUtil.RTrim( Ddo_produtoid_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Filterisrange", StringUtil.BoolToStr( Ddo_produtoid_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Includedatalist", StringUtil.BoolToStr( Ddo_produtoid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Sortasc", StringUtil.RTrim( Ddo_produtoid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Sortdsc", StringUtil.RTrim( Ddo_produtoid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Cleanfilter", StringUtil.RTrim( Ddo_produtoid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Rangefilterfrom", StringUtil.RTrim( Ddo_produtoid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Rangefilterto", StringUtil.RTrim( Ddo_produtoid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Searchbuttontext", StringUtil.RTrim( Ddo_produtoid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Caption", StringUtil.RTrim( Ddo_produtonome_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Tooltip", StringUtil.RTrim( Ddo_produtonome_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Cls", StringUtil.RTrim( Ddo_produtonome_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Filteredtext_set", StringUtil.RTrim( Ddo_produtonome_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Selectedvalue_set", StringUtil.RTrim( Ddo_produtonome_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Dropdownoptionstype", StringUtil.RTrim( Ddo_produtonome_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_produtonome_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Includesortasc", StringUtil.BoolToStr( Ddo_produtonome_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Includesortdsc", StringUtil.BoolToStr( Ddo_produtonome_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Sortedstatus", StringUtil.RTrim( Ddo_produtonome_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Includefilter", StringUtil.BoolToStr( Ddo_produtonome_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Filtertype", StringUtil.RTrim( Ddo_produtonome_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Filterisrange", StringUtil.BoolToStr( Ddo_produtonome_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Includedatalist", StringUtil.BoolToStr( Ddo_produtonome_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Datalisttype", StringUtil.RTrim( Ddo_produtonome_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Datalistproc", StringUtil.RTrim( Ddo_produtonome_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_produtonome_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Sortasc", StringUtil.RTrim( Ddo_produtonome_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Sortdsc", StringUtil.RTrim( Ddo_produtonome_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Loadingdata", StringUtil.RTrim( Ddo_produtonome_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Cleanfilter", StringUtil.RTrim( Ddo_produtonome_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Noresultsfound", StringUtil.RTrim( Ddo_produtonome_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Searchbuttontext", StringUtil.RTrim( Ddo_produtonome_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Caption", StringUtil.RTrim( Ddo_produtovalor_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Tooltip", StringUtil.RTrim( Ddo_produtovalor_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Cls", StringUtil.RTrim( Ddo_produtovalor_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Filteredtext_set", StringUtil.RTrim( Ddo_produtovalor_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Filteredtextto_set", StringUtil.RTrim( Ddo_produtovalor_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Dropdownoptionstype", StringUtil.RTrim( Ddo_produtovalor_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_produtovalor_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Includesortasc", StringUtil.BoolToStr( Ddo_produtovalor_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Includesortdsc", StringUtil.BoolToStr( Ddo_produtovalor_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Sortedstatus", StringUtil.RTrim( Ddo_produtovalor_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Includefilter", StringUtil.BoolToStr( Ddo_produtovalor_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Filtertype", StringUtil.RTrim( Ddo_produtovalor_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Filterisrange", StringUtil.BoolToStr( Ddo_produtovalor_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Includedatalist", StringUtil.BoolToStr( Ddo_produtovalor_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Sortasc", StringUtil.RTrim( Ddo_produtovalor_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Sortdsc", StringUtil.RTrim( Ddo_produtovalor_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Cleanfilter", StringUtil.RTrim( Ddo_produtovalor_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Rangefilterfrom", StringUtil.RTrim( Ddo_produtovalor_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Rangefilterto", StringUtil.RTrim( Ddo_produtovalor_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Searchbuttontext", StringUtil.RTrim( Ddo_produtovalor_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Caption", StringUtil.RTrim( Ddo_produtodtvalidade_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Tooltip", StringUtil.RTrim( Ddo_produtodtvalidade_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Cls", StringUtil.RTrim( Ddo_produtodtvalidade_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Filteredtext_set", StringUtil.RTrim( Ddo_produtodtvalidade_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Filteredtextto_set", StringUtil.RTrim( Ddo_produtodtvalidade_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Dropdownoptionstype", StringUtil.RTrim( Ddo_produtodtvalidade_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_produtodtvalidade_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Includesortasc", StringUtil.BoolToStr( Ddo_produtodtvalidade_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Includesortdsc", StringUtil.BoolToStr( Ddo_produtodtvalidade_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Sortedstatus", StringUtil.RTrim( Ddo_produtodtvalidade_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Includefilter", StringUtil.BoolToStr( Ddo_produtodtvalidade_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Filtertype", StringUtil.RTrim( Ddo_produtodtvalidade_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Filterisrange", StringUtil.BoolToStr( Ddo_produtodtvalidade_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Includedatalist", StringUtil.BoolToStr( Ddo_produtodtvalidade_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Sortasc", StringUtil.RTrim( Ddo_produtodtvalidade_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Sortdsc", StringUtil.RTrim( Ddo_produtodtvalidade_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Cleanfilter", StringUtil.RTrim( Ddo_produtodtvalidade_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Rangefilterfrom", StringUtil.RTrim( Ddo_produtodtvalidade_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Rangefilterto", StringUtil.RTrim( Ddo_produtodtvalidade_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Searchbuttontext", StringUtil.RTrim( Ddo_produtodtvalidade_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Caption", StringUtil.RTrim( Ddo_gridcolumnsselector_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Tooltip", StringUtil.RTrim( Ddo_gridcolumnsselector_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Cls", StringUtil.RTrim( Ddo_gridcolumnsselector_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Dropdownoptionstype", StringUtil.RTrim( Ddo_gridcolumnsselector_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_gridcolumnsselector_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Updatebuttontext", StringUtil.RTrim( Ddo_gridcolumnsselector_Updatebuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Activeeventkey", StringUtil.RTrim( Ddo_produtoid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Filteredtext_get", StringUtil.RTrim( Ddo_produtoid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Filteredtextto_get", StringUtil.RTrim( Ddo_produtoid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Activeeventkey", StringUtil.RTrim( Ddo_produtonome_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Filteredtext_get", StringUtil.RTrim( Ddo_produtonome_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Selectedvalue_get", StringUtil.RTrim( Ddo_produtonome_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Activeeventkey", StringUtil.RTrim( Ddo_produtovalor_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Filteredtext_get", StringUtil.RTrim( Ddo_produtovalor_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Filteredtextto_get", StringUtil.RTrim( Ddo_produtovalor_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Activeeventkey", StringUtil.RTrim( Ddo_produtodtvalidade_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Filteredtext_get", StringUtil.RTrim( Ddo_produtodtvalidade_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Filteredtextto_get", StringUtil.RTrim( Ddo_produtodtvalidade_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Columnsselectorvalues", StringUtil.RTrim( Ddo_gridcolumnsselector_Columnsselectorvalues));
         GxWebStd.gx_hidden_field( context, "DDO_MANAGEFILTERS_Activeeventkey", StringUtil.RTrim( Ddo_managefilters_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Activeeventkey", StringUtil.RTrim( Ddo_produtoid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Filteredtext_get", StringUtil.RTrim( Ddo_produtoid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Filteredtextto_get", StringUtil.RTrim( Ddo_produtoid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Activeeventkey", StringUtil.RTrim( Ddo_produtonome_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Filteredtext_get", StringUtil.RTrim( Ddo_produtonome_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Selectedvalue_get", StringUtil.RTrim( Ddo_produtonome_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Activeeventkey", StringUtil.RTrim( Ddo_produtovalor_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Filteredtext_get", StringUtil.RTrim( Ddo_produtovalor_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Filteredtextto_get", StringUtil.RTrim( Ddo_produtovalor_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Activeeventkey", StringUtil.RTrim( Ddo_produtodtvalidade_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Filteredtext_get", StringUtil.RTrim( Ddo_produtodtvalidade_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Filteredtextto_get", StringUtil.RTrim( Ddo_produtodtvalidade_Filteredtextto_get));
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
            WE0R2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0R2( ) ;
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
         return formatLink("produtoww.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "ProdutoWW" ;
      }

      public override String GetPgmdesc( )
      {
         return " Produto" ;
      }

      protected void WB0R0( )
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
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(127), 3, 0)+","+"null"+");", "Inserir", bttBtninsert_Jsonclick, 5, "Inserir", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_ProdutoWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"";
            ClassString = "hidden-xs";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtneditcolumns_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(127), 3, 0)+","+"null"+");", "Seleciona colunas", bttBtneditcolumns_Jsonclick, 0, "Seleciona colunas", "", StyleString, ClassString, 1, 0, "standard", "'"+""+"'"+",false,"+"'"+""+"'", TempTags, "", context.GetButtonType( ), "HLP_ProdutoWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-xs col-sm-6 CellFloatRight CellWidthAuto", "left", "top", "", "", "div");
            wb_table1_23_0R2( true) ;
         }
         else
         {
            wb_table1_23_0R2( false) ;
         }
         return  ;
      }

      protected void wb_table1_23_0R2e( bool wbgen )
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
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"127\">") ;
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+((edtProdutoId_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               if ( edtProdutoId_Titleformat == 0 )
               {
                  context.SendWebValue( edtProdutoId_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtProdutoId_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+((edtProdutoNome_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               if ( edtProdutoNome_Titleformat == 0 )
               {
                  context.SendWebValue( edtProdutoNome_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtProdutoNome_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "do Produto") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+((edtProdutoValor_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               if ( edtProdutoValor_Titleformat == 0 )
               {
                  context.SendWebValue( edtProdutoValor_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtProdutoValor_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+((edtProdutoDtValidade_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               if ( edtProdutoDtValidade_Titleformat == 0 )
               {
                  context.SendWebValue( edtProdutoDtValidade_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtProdutoDtValidade_Title) ;
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
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( AV81Update));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUpdate_Enabled), 5, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( AV82Delete));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDelete_Enabled), 5, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A8ProdutoId), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtProdutoId_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProdutoId_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProdutoId_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A9ProdutoNome);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtProdutoNome_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProdutoNome_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtProdutoNome_Link));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProdutoNome_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A10ProdutoDescricao);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A11ProdutoValor, 12, 2, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtProdutoValor_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProdutoValor_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProdutoValor_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A12ProdutoDtValidade, "99/99/99"));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtProdutoDtValidade_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProdutoDtValidade_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProdutoDtValidade_Visible), 5, 0, ".", "")));
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
         if ( wbEnd == 127 )
         {
            wbEnd = 0;
            nRC_GXsfl_127 = (short)(nGXsfl_127_idx-1);
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV79GridCurrentPage);
            ucGridpaginationbar.SetProperty("PageCount", AV80GridPageCount);
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
            GxWebStd.gx_label_ctrl( context, lblJsdynamicfilters_Internalname, lblJsdynamicfilters_Caption, "", "", lblJsdynamicfilters_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "", 0, "", 1, 1, 1, "HLP_ProdutoWW.htm");
            /* User Defined Control */
            ucDdo_produtoid.SetProperty("Caption", Ddo_produtoid_Caption);
            ucDdo_produtoid.SetProperty("Tooltip", Ddo_produtoid_Tooltip);
            ucDdo_produtoid.SetProperty("Cls", Ddo_produtoid_Cls);
            ucDdo_produtoid.SetProperty("DropDownOptionsType", Ddo_produtoid_Dropdownoptionstype);
            ucDdo_produtoid.SetProperty("IncludeSortASC", Ddo_produtoid_Includesortasc);
            ucDdo_produtoid.SetProperty("IncludeSortDSC", Ddo_produtoid_Includesortdsc);
            ucDdo_produtoid.SetProperty("IncludeFilter", Ddo_produtoid_Includefilter);
            ucDdo_produtoid.SetProperty("FilterType", Ddo_produtoid_Filtertype);
            ucDdo_produtoid.SetProperty("FilterIsRange", Ddo_produtoid_Filterisrange);
            ucDdo_produtoid.SetProperty("IncludeDataList", Ddo_produtoid_Includedatalist);
            ucDdo_produtoid.SetProperty("SortASC", Ddo_produtoid_Sortasc);
            ucDdo_produtoid.SetProperty("SortDSC", Ddo_produtoid_Sortdsc);
            ucDdo_produtoid.SetProperty("CleanFilter", Ddo_produtoid_Cleanfilter);
            ucDdo_produtoid.SetProperty("RangeFilterFrom", Ddo_produtoid_Rangefilterfrom);
            ucDdo_produtoid.SetProperty("RangeFilterTo", Ddo_produtoid_Rangefilterto);
            ucDdo_produtoid.SetProperty("SearchButtonText", Ddo_produtoid_Searchbuttontext);
            ucDdo_produtoid.SetProperty("DropDownOptionsTitleSettingsIcons", AV77DDO_TitleSettingsIcons);
            ucDdo_produtoid.SetProperty("DropDownOptionsData", AV55ProdutoIdTitleFilterData);
            ucDdo_produtoid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_produtoid_Internalname, "DDO_PRODUTOIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 143,'',false,'" + sGXsfl_127_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_produtoidtitlecontrolidtoreplace_Internalname, AV58ddo_ProdutoIdTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,143);\"", 0, edtavDdo_produtoidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_ProdutoWW.htm");
            /* User Defined Control */
            ucDdo_produtonome.SetProperty("Caption", Ddo_produtonome_Caption);
            ucDdo_produtonome.SetProperty("Tooltip", Ddo_produtonome_Tooltip);
            ucDdo_produtonome.SetProperty("Cls", Ddo_produtonome_Cls);
            ucDdo_produtonome.SetProperty("DropDownOptionsType", Ddo_produtonome_Dropdownoptionstype);
            ucDdo_produtonome.SetProperty("IncludeSortASC", Ddo_produtonome_Includesortasc);
            ucDdo_produtonome.SetProperty("IncludeSortDSC", Ddo_produtonome_Includesortdsc);
            ucDdo_produtonome.SetProperty("IncludeFilter", Ddo_produtonome_Includefilter);
            ucDdo_produtonome.SetProperty("FilterType", Ddo_produtonome_Filtertype);
            ucDdo_produtonome.SetProperty("FilterIsRange", Ddo_produtonome_Filterisrange);
            ucDdo_produtonome.SetProperty("IncludeDataList", Ddo_produtonome_Includedatalist);
            ucDdo_produtonome.SetProperty("DataListType", Ddo_produtonome_Datalisttype);
            ucDdo_produtonome.SetProperty("DataListProc", Ddo_produtonome_Datalistproc);
            ucDdo_produtonome.SetProperty("DataListUpdateMinimumCharacters", Ddo_produtonome_Datalistupdateminimumcharacters);
            ucDdo_produtonome.SetProperty("SortASC", Ddo_produtonome_Sortasc);
            ucDdo_produtonome.SetProperty("SortDSC", Ddo_produtonome_Sortdsc);
            ucDdo_produtonome.SetProperty("LoadingData", Ddo_produtonome_Loadingdata);
            ucDdo_produtonome.SetProperty("CleanFilter", Ddo_produtonome_Cleanfilter);
            ucDdo_produtonome.SetProperty("NoResultsFound", Ddo_produtonome_Noresultsfound);
            ucDdo_produtonome.SetProperty("SearchButtonText", Ddo_produtonome_Searchbuttontext);
            ucDdo_produtonome.SetProperty("DropDownOptionsTitleSettingsIcons", AV77DDO_TitleSettingsIcons);
            ucDdo_produtonome.SetProperty("DropDownOptionsData", AV59ProdutoNomeTitleFilterData);
            ucDdo_produtonome.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_produtonome_Internalname, "DDO_PRODUTONOMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 145,'',false,'" + sGXsfl_127_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_produtonometitlecontrolidtoreplace_Internalname, AV62ddo_ProdutoNomeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,145);\"", 0, edtavDdo_produtonometitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_ProdutoWW.htm");
            /* User Defined Control */
            ucDdo_produtovalor.SetProperty("Caption", Ddo_produtovalor_Caption);
            ucDdo_produtovalor.SetProperty("Tooltip", Ddo_produtovalor_Tooltip);
            ucDdo_produtovalor.SetProperty("Cls", Ddo_produtovalor_Cls);
            ucDdo_produtovalor.SetProperty("DropDownOptionsType", Ddo_produtovalor_Dropdownoptionstype);
            ucDdo_produtovalor.SetProperty("IncludeSortASC", Ddo_produtovalor_Includesortasc);
            ucDdo_produtovalor.SetProperty("IncludeSortDSC", Ddo_produtovalor_Includesortdsc);
            ucDdo_produtovalor.SetProperty("IncludeFilter", Ddo_produtovalor_Includefilter);
            ucDdo_produtovalor.SetProperty("FilterType", Ddo_produtovalor_Filtertype);
            ucDdo_produtovalor.SetProperty("FilterIsRange", Ddo_produtovalor_Filterisrange);
            ucDdo_produtovalor.SetProperty("IncludeDataList", Ddo_produtovalor_Includedatalist);
            ucDdo_produtovalor.SetProperty("SortASC", Ddo_produtovalor_Sortasc);
            ucDdo_produtovalor.SetProperty("SortDSC", Ddo_produtovalor_Sortdsc);
            ucDdo_produtovalor.SetProperty("CleanFilter", Ddo_produtovalor_Cleanfilter);
            ucDdo_produtovalor.SetProperty("RangeFilterFrom", Ddo_produtovalor_Rangefilterfrom);
            ucDdo_produtovalor.SetProperty("RangeFilterTo", Ddo_produtovalor_Rangefilterto);
            ucDdo_produtovalor.SetProperty("SearchButtonText", Ddo_produtovalor_Searchbuttontext);
            ucDdo_produtovalor.SetProperty("DropDownOptionsTitleSettingsIcons", AV77DDO_TitleSettingsIcons);
            ucDdo_produtovalor.SetProperty("DropDownOptionsData", AV67ProdutoValorTitleFilterData);
            ucDdo_produtovalor.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_produtovalor_Internalname, "DDO_PRODUTOVALORContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 147,'',false,'" + sGXsfl_127_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_produtovalortitlecontrolidtoreplace_Internalname, AV70ddo_ProdutoValorTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,147);\"", 0, edtavDdo_produtovalortitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_ProdutoWW.htm");
            /* User Defined Control */
            ucDdo_produtodtvalidade.SetProperty("Caption", Ddo_produtodtvalidade_Caption);
            ucDdo_produtodtvalidade.SetProperty("Tooltip", Ddo_produtodtvalidade_Tooltip);
            ucDdo_produtodtvalidade.SetProperty("Cls", Ddo_produtodtvalidade_Cls);
            ucDdo_produtodtvalidade.SetProperty("DropDownOptionsType", Ddo_produtodtvalidade_Dropdownoptionstype);
            ucDdo_produtodtvalidade.SetProperty("IncludeSortASC", Ddo_produtodtvalidade_Includesortasc);
            ucDdo_produtodtvalidade.SetProperty("IncludeSortDSC", Ddo_produtodtvalidade_Includesortdsc);
            ucDdo_produtodtvalidade.SetProperty("IncludeFilter", Ddo_produtodtvalidade_Includefilter);
            ucDdo_produtodtvalidade.SetProperty("FilterType", Ddo_produtodtvalidade_Filtertype);
            ucDdo_produtodtvalidade.SetProperty("FilterIsRange", Ddo_produtodtvalidade_Filterisrange);
            ucDdo_produtodtvalidade.SetProperty("IncludeDataList", Ddo_produtodtvalidade_Includedatalist);
            ucDdo_produtodtvalidade.SetProperty("SortASC", Ddo_produtodtvalidade_Sortasc);
            ucDdo_produtodtvalidade.SetProperty("SortDSC", Ddo_produtodtvalidade_Sortdsc);
            ucDdo_produtodtvalidade.SetProperty("CleanFilter", Ddo_produtodtvalidade_Cleanfilter);
            ucDdo_produtodtvalidade.SetProperty("RangeFilterFrom", Ddo_produtodtvalidade_Rangefilterfrom);
            ucDdo_produtodtvalidade.SetProperty("RangeFilterTo", Ddo_produtodtvalidade_Rangefilterto);
            ucDdo_produtodtvalidade.SetProperty("SearchButtonText", Ddo_produtodtvalidade_Searchbuttontext);
            ucDdo_produtodtvalidade.SetProperty("DropDownOptionsTitleSettingsIcons", AV77DDO_TitleSettingsIcons);
            ucDdo_produtodtvalidade.SetProperty("DropDownOptionsData", AV71ProdutoDtValidadeTitleFilterData);
            ucDdo_produtodtvalidade.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_produtodtvalidade_Internalname, "DDO_PRODUTODTVALIDADEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 149,'',false,'" + sGXsfl_127_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_produtodtvalidadetitlecontrolidtoreplace_Internalname, AV76ddo_ProdutoDtValidadeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,149);\"", 0, edtavDdo_produtodtvalidadetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_ProdutoWW.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities_f5", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* User Defined Control */
            ucDdo_gridcolumnsselector.SetProperty("Caption", Ddo_gridcolumnsselector_Caption);
            ucDdo_gridcolumnsselector.SetProperty("Tooltip", Ddo_gridcolumnsselector_Tooltip);
            ucDdo_gridcolumnsselector.SetProperty("Cls", Ddo_gridcolumnsselector_Cls);
            ucDdo_gridcolumnsselector.SetProperty("DropDownOptionsType", Ddo_gridcolumnsselector_Dropdownoptionstype);
            ucDdo_gridcolumnsselector.SetProperty("UpdateButtonText", Ddo_gridcolumnsselector_Updatebuttontext);
            ucDdo_gridcolumnsselector.SetProperty("DropDownOptionsTitleSettingsIcons", AV77DDO_TitleSettingsIcons);
            ucDdo_gridcolumnsselector.SetProperty("DropDownOptionsData", AV41ColumnsSelector);
            ucDdo_gridcolumnsselector.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_gridcolumnsselector_Internalname, "DDO_GRIDCOLUMNSSELECTORContainer");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 152,'',false,'" + sGXsfl_127_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavDynamicfiltersenabled2_Internalname, StringUtil.BoolToStr( AV19DynamicFiltersEnabled2), "", "", chkavDynamicfiltersenabled2.Visible, 1, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(152, this, 'true', 'false');gx.evt.onchange(this, event);\" ");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 153,'',false,'" + sGXsfl_127_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavDynamicfiltersenabled3_Internalname, StringUtil.BoolToStr( AV23DynamicFiltersEnabled3), "", "", chkavDynamicfiltersenabled3.Visible, 1, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(153, this, 'true', 'false');gx.evt.onchange(this, event);\" ");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 154,'',false,'" + sGXsfl_127_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,154);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ProdutoWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 155,'',false,'" + sGXsfl_127_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV14OrderedDsc), StringUtil.BoolToStr( AV14OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,155);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_ProdutoWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 156,'',false,'" + sGXsfl_127_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavManagefiltersexecutionstep_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV49ManageFiltersExecutionStep), 1, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV49ManageFiltersExecutionStep), "9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,156);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavManagefiltersexecutionstep_Jsonclick, 0, "Attribute", "", "", "", "", edtavManagefiltersexecutionstep_Visible, 1, 0, "number", "1", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ProdutoWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 157,'',false,'" + sGXsfl_127_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfprodutoid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV56TFProdutoId), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV56TFProdutoId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,157);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfprodutoid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfprodutoid_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ProdutoWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 158,'',false,'" + sGXsfl_127_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfprodutoid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV57TFProdutoId_To), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV57TFProdutoId_To), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,158);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfprodutoid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfprodutoid_to_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ProdutoWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 159,'',false,'" + sGXsfl_127_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfprodutonome_Internalname, AV60TFProdutoNome, StringUtil.RTrim( context.localUtil.Format( AV60TFProdutoNome, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,159);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfprodutonome_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfprodutonome_Visible, 1, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_ProdutoWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 160,'',false,'" + sGXsfl_127_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfprodutonome_sel_Internalname, AV61TFProdutoNome_Sel, StringUtil.RTrim( context.localUtil.Format( AV61TFProdutoNome_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,160);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfprodutonome_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfprodutonome_sel_Visible, 1, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_ProdutoWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 161,'',false,'" + sGXsfl_127_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfprodutovalor_Internalname, StringUtil.LTrim( StringUtil.NToC( AV68TFProdutoValor, 12, 2, ",", "")), StringUtil.LTrim( context.localUtil.Format( AV68TFProdutoValor, "R$ ZZ,ZZ9.99")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,161);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfprodutovalor_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfprodutovalor_Visible, 1, 0, "text", "", 12, "chr", 1, "row", 12, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ProdutoWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 162,'',false,'" + sGXsfl_127_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfprodutovalor_to_Internalname, StringUtil.LTrim( StringUtil.NToC( AV69TFProdutoValor_To, 12, 2, ",", "")), StringUtil.LTrim( context.localUtil.Format( AV69TFProdutoValor_To, "R$ ZZ,ZZ9.99")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,162);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfprodutovalor_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfprodutovalor_to_Visible, 1, 0, "text", "", 12, "chr", 1, "row", 12, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ProdutoWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 163,'',false,'" + sGXsfl_127_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavTfprodutodtvalidade_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTfprodutodtvalidade_Internalname, context.localUtil.Format(AV72TFProdutoDtValidade, "99/99/99"), context.localUtil.Format( AV72TFProdutoDtValidade, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,163);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfprodutodtvalidade_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfprodutodtvalidade_Visible, 1, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ProdutoWW.htm");
            GxWebStd.gx_bitmap( context, edtavTfprodutodtvalidade_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavTfprodutodtvalidade_Visible==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_ProdutoWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 164,'',false,'" + sGXsfl_127_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavTfprodutodtvalidade_to_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTfprodutodtvalidade_to_Internalname, context.localUtil.Format(AV73TFProdutoDtValidade_To, "99/99/99"), context.localUtil.Format( AV73TFProdutoDtValidade_To, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,164);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfprodutodtvalidade_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfprodutodtvalidade_to_Visible, 1, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ProdutoWW.htm");
            GxWebStd.gx_bitmap( context, edtavTfprodutodtvalidade_to_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavTfprodutodtvalidade_to_Visible==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_ProdutoWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divDdo_produtodtvalidadeauxdates_Internalname, 1, 0, "px", 0, "px", "Invisible", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 166,'',false,'" + sGXsfl_127_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavDdo_produtodtvalidadeauxdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDdo_produtodtvalidadeauxdate_Internalname, context.localUtil.Format(AV74DDO_ProdutoDtValidadeAuxDate, "99/99/99"), context.localUtil.Format( AV74DDO_ProdutoDtValidadeAuxDate, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,166);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDdo_produtodtvalidadeauxdate_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ProdutoWW.htm");
            GxWebStd.gx_bitmap( context, edtavDdo_produtodtvalidadeauxdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_ProdutoWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 167,'',false,'" + sGXsfl_127_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavDdo_produtodtvalidadeauxdateto_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDdo_produtodtvalidadeauxdateto_Internalname, context.localUtil.Format(AV75DDO_ProdutoDtValidadeAuxDateTo, "99/99/99"), context.localUtil.Format( AV75DDO_ProdutoDtValidadeAuxDateTo, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,167);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDdo_produtodtvalidadeauxdateto_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ProdutoWW.htm");
            GxWebStd.gx_bitmap( context, edtavDdo_produtodtvalidadeauxdateto_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_ProdutoWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 127 )
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

      protected void START0R2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_2-131213", 0) ;
            Form.Meta.addItem("description", " Produto", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP0R0( ) ;
      }

      protected void WS0R2( )
      {
         START0R2( ) ;
         EVT0R2( ) ;
      }

      protected void EVT0R2( )
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
                              E110R2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E120R2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E130R2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PRODUTOID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E140R2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PRODUTONOME.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E150R2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PRODUTOVALOR.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E160R2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PRODUTODTVALIDADE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E170R2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_GRIDCOLUMNSSELECTOR.ONCOLUMNSCHANGED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E180R2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'REMOVEDYNAMICFILTERS1'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'RemoveDynamicFilters1' */
                              E190R2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'REMOVEDYNAMICFILTERS2'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'RemoveDynamicFilters2' */
                              E200R2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'REMOVEDYNAMICFILTERS3'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'RemoveDynamicFilters3' */
                              E210R2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoInsert' */
                              E220R2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'ADDDYNAMICFILTERS1'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'AddDynamicFilters1' */
                              E230R2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VDYNAMICFILTERSSELECTOR1.CLICK") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E240R2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'ADDDYNAMICFILTERS2'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'AddDynamicFilters2' */
                              E250R2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VDYNAMICFILTERSSELECTOR2.CLICK") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E260R2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VDYNAMICFILTERSSELECTOR3.CLICK") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E270R2 ();
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
                              nGXsfl_127_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_127_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_127_idx), 4, 0)), 4, "0");
                              SubsflControlProps_1272( ) ;
                              AV81Update = cgiGet( edtavUpdate_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUpdate_Internalname, AV81Update);
                              AV82Delete = cgiGet( edtavDelete_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDelete_Internalname, AV82Delete);
                              A8ProdutoId = (short)(context.localUtil.CToN( cgiGet( edtProdutoId_Internalname), ",", "."));
                              A9ProdutoNome = cgiGet( edtProdutoNome_Internalname);
                              A10ProdutoDescricao = cgiGet( edtProdutoDescricao_Internalname);
                              A11ProdutoValor = context.localUtil.CToN( cgiGet( edtProdutoValor_Internalname), ",", ".");
                              A12ProdutoDtValidade = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtProdutoDtValidade_Internalname), 0));
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E280R2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E290R2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E300R2 ();
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
                                       /* Set Refresh If Produtonome1 Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vPRODUTONOME1"), AV18ProdutoNome1) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Dynamicfiltersselector2 Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vDYNAMICFILTERSSELECTOR2"), AV20DynamicFiltersSelector2) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Dynamicfiltersoperator2 Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vDYNAMICFILTERSOPERATOR2"), ",", ".") != Convert.ToDecimal( AV21DynamicFiltersOperator2 )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Produtonome2 Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vPRODUTONOME2"), AV22ProdutoNome2) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Dynamicfiltersselector3 Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vDYNAMICFILTERSSELECTOR3"), AV24DynamicFiltersSelector3) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Dynamicfiltersoperator3 Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vDYNAMICFILTERSOPERATOR3"), ",", ".") != Convert.ToDecimal( AV25DynamicFiltersOperator3 )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Produtonome3 Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vPRODUTONOME3"), AV26ProdutoNome3) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Produtodtvalidade Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vPRODUTODTVALIDADE"), 0) != AV83ProdutoDtValidade )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Produtodtvalidade_to Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vPRODUTODTVALIDADE_TO"), 0) != AV84ProdutoDtValidade_To )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Dynamicfiltersenabled2 Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vDYNAMICFILTERSENABLED2")) != AV19DynamicFiltersEnabled2 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Dynamicfiltersenabled3 Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vDYNAMICFILTERSENABLED3")) != AV23DynamicFiltersEnabled3 )
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
                                       /* Set Refresh If Tfprodutoid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFPRODUTOID"), ",", ".") != Convert.ToDecimal( AV56TFProdutoId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfprodutoid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFPRODUTOID_TO"), ",", ".") != Convert.ToDecimal( AV57TFProdutoId_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfprodutonome Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFPRODUTONOME"), AV60TFProdutoNome) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfprodutonome_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFPRODUTONOME_SEL"), AV61TFProdutoNome_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfprodutovalor Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFPRODUTOVALOR"), ",", ".") != AV68TFProdutoValor )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfprodutovalor_to Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFPRODUTOVALOR_TO"), ",", ".") != AV69TFProdutoValor_To )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfprodutodtvalidade Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vTFPRODUTODTVALIDADE"), 0) != AV72TFProdutoDtValidade )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfprodutodtvalidade_to Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vTFPRODUTODTVALIDADE_TO"), 0) != AV73TFProdutoDtValidade_To )
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

      protected void WE0R2( )
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

      protected void PA0R2( )
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
         SubsflControlProps_1272( ) ;
         while ( nGXsfl_127_idx <= nRC_GXsfl_127 )
         {
            sendrow_1272( ) ;
            nGXsfl_127_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_127_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_127_idx+1));
            sGXsfl_127_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_127_idx), 4, 0)), 4, "0");
            SubsflControlProps_1272( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       String AV16DynamicFiltersSelector1 ,
                                       short AV17DynamicFiltersOperator1 ,
                                       String AV18ProdutoNome1 ,
                                       String AV20DynamicFiltersSelector2 ,
                                       short AV21DynamicFiltersOperator2 ,
                                       String AV22ProdutoNome2 ,
                                       String AV24DynamicFiltersSelector3 ,
                                       short AV25DynamicFiltersOperator3 ,
                                       String AV26ProdutoNome3 ,
                                       DateTime AV83ProdutoDtValidade ,
                                       DateTime AV84ProdutoDtValidade_To ,
                                       bool AV19DynamicFiltersEnabled2 ,
                                       bool AV23DynamicFiltersEnabled3 ,
                                       short AV13OrderedBy ,
                                       bool AV14OrderedDsc ,
                                       short AV56TFProdutoId ,
                                       short AV57TFProdutoId_To ,
                                       String AV60TFProdutoNome ,
                                       String AV61TFProdutoNome_Sel ,
                                       decimal AV68TFProdutoValor ,
                                       decimal AV69TFProdutoValor_To ,
                                       DateTime AV72TFProdutoDtValidade ,
                                       DateTime AV73TFProdutoDtValidade_To ,
                                       short AV49ManageFiltersExecutionStep ,
                                       GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector AV41ColumnsSelector ,
                                       String AV58ddo_ProdutoIdTitleControlIdToReplace ,
                                       String AV62ddo_ProdutoNomeTitleControlIdToReplace ,
                                       String AV70ddo_ProdutoValorTitleControlIdToReplace ,
                                       String AV76ddo_ProdutoDtValidadeTitleControlIdToReplace ,
                                       String AV108Pgmname ,
                                       GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV10GridState ,
                                       bool AV28DynamicFiltersIgnoreFirst ,
                                       bool AV27DynamicFiltersRemoving )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF0R2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_PRODUTOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A8ProdutoId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "PRODUTOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A8ProdutoId), 4, 0, ".", "")));
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
            AV20DynamicFiltersSelector2 = cmbavDynamicfiltersselector2.getValidValue(AV20DynamicFiltersSelector2);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20DynamicFiltersSelector2", AV20DynamicFiltersSelector2);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavDynamicfiltersselector2.CurrentValue = StringUtil.RTrim( AV20DynamicFiltersSelector2);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector2_Internalname, "Values", cmbavDynamicfiltersselector2.ToJavascriptSource(), true);
         }
         if ( cmbavDynamicfiltersoperator2.ItemCount > 0 )
         {
            AV21DynamicFiltersOperator2 = (short)(NumberUtil.Val( cmbavDynamicfiltersoperator2.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV21DynamicFiltersOperator2), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21DynamicFiltersOperator2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21DynamicFiltersOperator2), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV21DynamicFiltersOperator2), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", cmbavDynamicfiltersoperator2.ToJavascriptSource(), true);
         }
         if ( cmbavDynamicfiltersselector3.ItemCount > 0 )
         {
            AV24DynamicFiltersSelector3 = cmbavDynamicfiltersselector3.getValidValue(AV24DynamicFiltersSelector3);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24DynamicFiltersSelector3", AV24DynamicFiltersSelector3);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavDynamicfiltersselector3.CurrentValue = StringUtil.RTrim( AV24DynamicFiltersSelector3);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector3_Internalname, "Values", cmbavDynamicfiltersselector3.ToJavascriptSource(), true);
         }
         if ( cmbavDynamicfiltersoperator3.ItemCount > 0 )
         {
            AV25DynamicFiltersOperator3 = (short)(NumberUtil.Val( cmbavDynamicfiltersoperator3.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV25DynamicFiltersOperator3), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25DynamicFiltersOperator3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25DynamicFiltersOperator3), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV25DynamicFiltersOperator3), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", cmbavDynamicfiltersoperator3.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF0R2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV108Pgmname = "ProdutoWW";
         context.Gx_err = 0;
         edtavUpdate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Enabled), 5, 0)), !bGXsfl_127_Refreshing);
         edtavDelete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Enabled), 5, 0)), !bGXsfl_127_Refreshing);
      }

      protected void RF0R2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 127;
         /* Execute user event: Refresh */
         E290R2 ();
         nGXsfl_127_idx = 1;
         sGXsfl_127_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_127_idx), 4, 0)), 4, "0");
         SubsflControlProps_1272( ) ;
         bGXsfl_127_Refreshing = true;
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
            SubsflControlProps_1272( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV87ProdutoWWDS_1_Produtodtvalidade ,
                                                 AV88ProdutoWWDS_2_Produtodtvalidade_to ,
                                                 AV89ProdutoWWDS_3_Dynamicfiltersselector1 ,
                                                 AV90ProdutoWWDS_4_Dynamicfiltersoperator1 ,
                                                 AV91ProdutoWWDS_5_Produtonome1 ,
                                                 AV92ProdutoWWDS_6_Dynamicfiltersenabled2 ,
                                                 AV93ProdutoWWDS_7_Dynamicfiltersselector2 ,
                                                 AV94ProdutoWWDS_8_Dynamicfiltersoperator2 ,
                                                 AV95ProdutoWWDS_9_Produtonome2 ,
                                                 AV96ProdutoWWDS_10_Dynamicfiltersenabled3 ,
                                                 AV97ProdutoWWDS_11_Dynamicfiltersselector3 ,
                                                 AV98ProdutoWWDS_12_Dynamicfiltersoperator3 ,
                                                 AV99ProdutoWWDS_13_Produtonome3 ,
                                                 AV100ProdutoWWDS_14_Tfprodutoid ,
                                                 AV101ProdutoWWDS_15_Tfprodutoid_to ,
                                                 AV103ProdutoWWDS_17_Tfprodutonome_sel ,
                                                 AV102ProdutoWWDS_16_Tfprodutonome ,
                                                 AV104ProdutoWWDS_18_Tfprodutovalor ,
                                                 AV105ProdutoWWDS_19_Tfprodutovalor_to ,
                                                 AV106ProdutoWWDS_20_Tfprodutodtvalidade ,
                                                 AV107ProdutoWWDS_21_Tfprodutodtvalidade_to ,
                                                 A12ProdutoDtValidade ,
                                                 A9ProdutoNome ,
                                                 A8ProdutoId ,
                                                 A11ProdutoValor ,
                                                 AV13OrderedBy ,
                                                 AV14OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                                 TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DATE,
                                                 TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DECIMAL, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV91ProdutoWWDS_5_Produtonome1 = StringUtil.Concat( StringUtil.RTrim( AV91ProdutoWWDS_5_Produtonome1), "%", "");
            lV91ProdutoWWDS_5_Produtonome1 = StringUtil.Concat( StringUtil.RTrim( AV91ProdutoWWDS_5_Produtonome1), "%", "");
            lV95ProdutoWWDS_9_Produtonome2 = StringUtil.Concat( StringUtil.RTrim( AV95ProdutoWWDS_9_Produtonome2), "%", "");
            lV95ProdutoWWDS_9_Produtonome2 = StringUtil.Concat( StringUtil.RTrim( AV95ProdutoWWDS_9_Produtonome2), "%", "");
            lV99ProdutoWWDS_13_Produtonome3 = StringUtil.Concat( StringUtil.RTrim( AV99ProdutoWWDS_13_Produtonome3), "%", "");
            lV99ProdutoWWDS_13_Produtonome3 = StringUtil.Concat( StringUtil.RTrim( AV99ProdutoWWDS_13_Produtonome3), "%", "");
            lV102ProdutoWWDS_16_Tfprodutonome = StringUtil.Concat( StringUtil.RTrim( AV102ProdutoWWDS_16_Tfprodutonome), "%", "");
            /* Using cursor H000R2 */
            pr_default.execute(0, new Object[] {AV87ProdutoWWDS_1_Produtodtvalidade, AV88ProdutoWWDS_2_Produtodtvalidade_to, lV91ProdutoWWDS_5_Produtonome1, lV91ProdutoWWDS_5_Produtonome1, lV95ProdutoWWDS_9_Produtonome2, lV95ProdutoWWDS_9_Produtonome2, lV99ProdutoWWDS_13_Produtonome3, lV99ProdutoWWDS_13_Produtonome3, AV100ProdutoWWDS_14_Tfprodutoid, AV101ProdutoWWDS_15_Tfprodutoid_to, lV102ProdutoWWDS_16_Tfprodutonome, AV103ProdutoWWDS_17_Tfprodutonome_sel, AV104ProdutoWWDS_18_Tfprodutovalor, AV105ProdutoWWDS_19_Tfprodutovalor_to, AV106ProdutoWWDS_20_Tfprodutodtvalidade, AV107ProdutoWWDS_21_Tfprodutodtvalidade_to, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_127_idx = 1;
            sGXsfl_127_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_127_idx), 4, 0)), 4, "0");
            SubsflControlProps_1272( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A12ProdutoDtValidade = H000R2_A12ProdutoDtValidade[0];
               A11ProdutoValor = H000R2_A11ProdutoValor[0];
               A10ProdutoDescricao = H000R2_A10ProdutoDescricao[0];
               A9ProdutoNome = H000R2_A9ProdutoNome[0];
               A8ProdutoId = H000R2_A8ProdutoId[0];
               E300R2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 127;
            WB0R0( ) ;
         }
         bGXsfl_127_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes0R2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_PRODUTOID"+"_"+sGXsfl_127_idx, GetSecureSignedToken( sGXsfl_127_idx, context.localUtil.Format( (decimal)(A8ProdutoId), "ZZZ9"), context));
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
         AV87ProdutoWWDS_1_Produtodtvalidade = AV83ProdutoDtValidade;
         AV88ProdutoWWDS_2_Produtodtvalidade_to = AV84ProdutoDtValidade_To;
         AV89ProdutoWWDS_3_Dynamicfiltersselector1 = AV16DynamicFiltersSelector1;
         AV90ProdutoWWDS_4_Dynamicfiltersoperator1 = AV17DynamicFiltersOperator1;
         AV91ProdutoWWDS_5_Produtonome1 = AV18ProdutoNome1;
         AV92ProdutoWWDS_6_Dynamicfiltersenabled2 = AV19DynamicFiltersEnabled2;
         AV93ProdutoWWDS_7_Dynamicfiltersselector2 = AV20DynamicFiltersSelector2;
         AV94ProdutoWWDS_8_Dynamicfiltersoperator2 = AV21DynamicFiltersOperator2;
         AV95ProdutoWWDS_9_Produtonome2 = AV22ProdutoNome2;
         AV96ProdutoWWDS_10_Dynamicfiltersenabled3 = AV23DynamicFiltersEnabled3;
         AV97ProdutoWWDS_11_Dynamicfiltersselector3 = AV24DynamicFiltersSelector3;
         AV98ProdutoWWDS_12_Dynamicfiltersoperator3 = AV25DynamicFiltersOperator3;
         AV99ProdutoWWDS_13_Produtonome3 = AV26ProdutoNome3;
         AV100ProdutoWWDS_14_Tfprodutoid = AV56TFProdutoId;
         AV101ProdutoWWDS_15_Tfprodutoid_to = AV57TFProdutoId_To;
         AV102ProdutoWWDS_16_Tfprodutonome = AV60TFProdutoNome;
         AV103ProdutoWWDS_17_Tfprodutonome_sel = AV61TFProdutoNome_Sel;
         AV104ProdutoWWDS_18_Tfprodutovalor = AV68TFProdutoValor;
         AV105ProdutoWWDS_19_Tfprodutovalor_to = AV69TFProdutoValor_To;
         AV106ProdutoWWDS_20_Tfprodutodtvalidade = AV72TFProdutoDtValidade;
         AV107ProdutoWWDS_21_Tfprodutodtvalidade_to = AV73TFProdutoDtValidade_To;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV87ProdutoWWDS_1_Produtodtvalidade ,
                                              AV88ProdutoWWDS_2_Produtodtvalidade_to ,
                                              AV89ProdutoWWDS_3_Dynamicfiltersselector1 ,
                                              AV90ProdutoWWDS_4_Dynamicfiltersoperator1 ,
                                              AV91ProdutoWWDS_5_Produtonome1 ,
                                              AV92ProdutoWWDS_6_Dynamicfiltersenabled2 ,
                                              AV93ProdutoWWDS_7_Dynamicfiltersselector2 ,
                                              AV94ProdutoWWDS_8_Dynamicfiltersoperator2 ,
                                              AV95ProdutoWWDS_9_Produtonome2 ,
                                              AV96ProdutoWWDS_10_Dynamicfiltersenabled3 ,
                                              AV97ProdutoWWDS_11_Dynamicfiltersselector3 ,
                                              AV98ProdutoWWDS_12_Dynamicfiltersoperator3 ,
                                              AV99ProdutoWWDS_13_Produtonome3 ,
                                              AV100ProdutoWWDS_14_Tfprodutoid ,
                                              AV101ProdutoWWDS_15_Tfprodutoid_to ,
                                              AV103ProdutoWWDS_17_Tfprodutonome_sel ,
                                              AV102ProdutoWWDS_16_Tfprodutonome ,
                                              AV104ProdutoWWDS_18_Tfprodutovalor ,
                                              AV105ProdutoWWDS_19_Tfprodutovalor_to ,
                                              AV106ProdutoWWDS_20_Tfprodutodtvalidade ,
                                              AV107ProdutoWWDS_21_Tfprodutodtvalidade_to ,
                                              A12ProdutoDtValidade ,
                                              A9ProdutoNome ,
                                              A8ProdutoId ,
                                              A11ProdutoValor ,
                                              AV13OrderedBy ,
                                              AV14OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DATE,
                                              TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DECIMAL, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV91ProdutoWWDS_5_Produtonome1 = StringUtil.Concat( StringUtil.RTrim( AV91ProdutoWWDS_5_Produtonome1), "%", "");
         lV91ProdutoWWDS_5_Produtonome1 = StringUtil.Concat( StringUtil.RTrim( AV91ProdutoWWDS_5_Produtonome1), "%", "");
         lV95ProdutoWWDS_9_Produtonome2 = StringUtil.Concat( StringUtil.RTrim( AV95ProdutoWWDS_9_Produtonome2), "%", "");
         lV95ProdutoWWDS_9_Produtonome2 = StringUtil.Concat( StringUtil.RTrim( AV95ProdutoWWDS_9_Produtonome2), "%", "");
         lV99ProdutoWWDS_13_Produtonome3 = StringUtil.Concat( StringUtil.RTrim( AV99ProdutoWWDS_13_Produtonome3), "%", "");
         lV99ProdutoWWDS_13_Produtonome3 = StringUtil.Concat( StringUtil.RTrim( AV99ProdutoWWDS_13_Produtonome3), "%", "");
         lV102ProdutoWWDS_16_Tfprodutonome = StringUtil.Concat( StringUtil.RTrim( AV102ProdutoWWDS_16_Tfprodutonome), "%", "");
         /* Using cursor H000R3 */
         pr_default.execute(1, new Object[] {AV87ProdutoWWDS_1_Produtodtvalidade, AV88ProdutoWWDS_2_Produtodtvalidade_to, lV91ProdutoWWDS_5_Produtonome1, lV91ProdutoWWDS_5_Produtonome1, lV95ProdutoWWDS_9_Produtonome2, lV95ProdutoWWDS_9_Produtonome2, lV99ProdutoWWDS_13_Produtonome3, lV99ProdutoWWDS_13_Produtonome3, AV100ProdutoWWDS_14_Tfprodutoid, AV101ProdutoWWDS_15_Tfprodutoid_to, lV102ProdutoWWDS_16_Tfprodutonome, AV103ProdutoWWDS_17_Tfprodutonome_sel, AV104ProdutoWWDS_18_Tfprodutovalor, AV105ProdutoWWDS_19_Tfprodutovalor_to, AV106ProdutoWWDS_20_Tfprodutodtvalidade, AV107ProdutoWWDS_21_Tfprodutodtvalidade_to});
         GRID_nRecordCount = H000R3_AGRID_nRecordCount[0];
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
         AV87ProdutoWWDS_1_Produtodtvalidade = AV83ProdutoDtValidade;
         AV88ProdutoWWDS_2_Produtodtvalidade_to = AV84ProdutoDtValidade_To;
         AV89ProdutoWWDS_3_Dynamicfiltersselector1 = AV16DynamicFiltersSelector1;
         AV90ProdutoWWDS_4_Dynamicfiltersoperator1 = AV17DynamicFiltersOperator1;
         AV91ProdutoWWDS_5_Produtonome1 = AV18ProdutoNome1;
         AV92ProdutoWWDS_6_Dynamicfiltersenabled2 = AV19DynamicFiltersEnabled2;
         AV93ProdutoWWDS_7_Dynamicfiltersselector2 = AV20DynamicFiltersSelector2;
         AV94ProdutoWWDS_8_Dynamicfiltersoperator2 = AV21DynamicFiltersOperator2;
         AV95ProdutoWWDS_9_Produtonome2 = AV22ProdutoNome2;
         AV96ProdutoWWDS_10_Dynamicfiltersenabled3 = AV23DynamicFiltersEnabled3;
         AV97ProdutoWWDS_11_Dynamicfiltersselector3 = AV24DynamicFiltersSelector3;
         AV98ProdutoWWDS_12_Dynamicfiltersoperator3 = AV25DynamicFiltersOperator3;
         AV99ProdutoWWDS_13_Produtonome3 = AV26ProdutoNome3;
         AV100ProdutoWWDS_14_Tfprodutoid = AV56TFProdutoId;
         AV101ProdutoWWDS_15_Tfprodutoid_to = AV57TFProdutoId_To;
         AV102ProdutoWWDS_16_Tfprodutonome = AV60TFProdutoNome;
         AV103ProdutoWWDS_17_Tfprodutonome_sel = AV61TFProdutoNome_Sel;
         AV104ProdutoWWDS_18_Tfprodutovalor = AV68TFProdutoValor;
         AV105ProdutoWWDS_19_Tfprodutovalor_to = AV69TFProdutoValor_To;
         AV106ProdutoWWDS_20_Tfprodutodtvalidade = AV72TFProdutoDtValidade;
         AV107ProdutoWWDS_21_Tfprodutodtvalidade_to = AV73TFProdutoDtValidade_To;
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV16DynamicFiltersSelector1, AV17DynamicFiltersOperator1, AV18ProdutoNome1, AV20DynamicFiltersSelector2, AV21DynamicFiltersOperator2, AV22ProdutoNome2, AV24DynamicFiltersSelector3, AV25DynamicFiltersOperator3, AV26ProdutoNome3, AV83ProdutoDtValidade, AV84ProdutoDtValidade_To, AV19DynamicFiltersEnabled2, AV23DynamicFiltersEnabled3, AV13OrderedBy, AV14OrderedDsc, AV56TFProdutoId, AV57TFProdutoId_To, AV60TFProdutoNome, AV61TFProdutoNome_Sel, AV68TFProdutoValor, AV69TFProdutoValor_To, AV72TFProdutoDtValidade, AV73TFProdutoDtValidade_To, AV49ManageFiltersExecutionStep, AV41ColumnsSelector, AV58ddo_ProdutoIdTitleControlIdToReplace, AV62ddo_ProdutoNomeTitleControlIdToReplace, AV70ddo_ProdutoValorTitleControlIdToReplace, AV76ddo_ProdutoDtValidadeTitleControlIdToReplace, AV108Pgmname, AV10GridState, AV28DynamicFiltersIgnoreFirst, AV27DynamicFiltersRemoving) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV87ProdutoWWDS_1_Produtodtvalidade = AV83ProdutoDtValidade;
         AV88ProdutoWWDS_2_Produtodtvalidade_to = AV84ProdutoDtValidade_To;
         AV89ProdutoWWDS_3_Dynamicfiltersselector1 = AV16DynamicFiltersSelector1;
         AV90ProdutoWWDS_4_Dynamicfiltersoperator1 = AV17DynamicFiltersOperator1;
         AV91ProdutoWWDS_5_Produtonome1 = AV18ProdutoNome1;
         AV92ProdutoWWDS_6_Dynamicfiltersenabled2 = AV19DynamicFiltersEnabled2;
         AV93ProdutoWWDS_7_Dynamicfiltersselector2 = AV20DynamicFiltersSelector2;
         AV94ProdutoWWDS_8_Dynamicfiltersoperator2 = AV21DynamicFiltersOperator2;
         AV95ProdutoWWDS_9_Produtonome2 = AV22ProdutoNome2;
         AV96ProdutoWWDS_10_Dynamicfiltersenabled3 = AV23DynamicFiltersEnabled3;
         AV97ProdutoWWDS_11_Dynamicfiltersselector3 = AV24DynamicFiltersSelector3;
         AV98ProdutoWWDS_12_Dynamicfiltersoperator3 = AV25DynamicFiltersOperator3;
         AV99ProdutoWWDS_13_Produtonome3 = AV26ProdutoNome3;
         AV100ProdutoWWDS_14_Tfprodutoid = AV56TFProdutoId;
         AV101ProdutoWWDS_15_Tfprodutoid_to = AV57TFProdutoId_To;
         AV102ProdutoWWDS_16_Tfprodutonome = AV60TFProdutoNome;
         AV103ProdutoWWDS_17_Tfprodutonome_sel = AV61TFProdutoNome_Sel;
         AV104ProdutoWWDS_18_Tfprodutovalor = AV68TFProdutoValor;
         AV105ProdutoWWDS_19_Tfprodutovalor_to = AV69TFProdutoValor_To;
         AV106ProdutoWWDS_20_Tfprodutodtvalidade = AV72TFProdutoDtValidade;
         AV107ProdutoWWDS_21_Tfprodutodtvalidade_to = AV73TFProdutoDtValidade_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV16DynamicFiltersSelector1, AV17DynamicFiltersOperator1, AV18ProdutoNome1, AV20DynamicFiltersSelector2, AV21DynamicFiltersOperator2, AV22ProdutoNome2, AV24DynamicFiltersSelector3, AV25DynamicFiltersOperator3, AV26ProdutoNome3, AV83ProdutoDtValidade, AV84ProdutoDtValidade_To, AV19DynamicFiltersEnabled2, AV23DynamicFiltersEnabled3, AV13OrderedBy, AV14OrderedDsc, AV56TFProdutoId, AV57TFProdutoId_To, AV60TFProdutoNome, AV61TFProdutoNome_Sel, AV68TFProdutoValor, AV69TFProdutoValor_To, AV72TFProdutoDtValidade, AV73TFProdutoDtValidade_To, AV49ManageFiltersExecutionStep, AV41ColumnsSelector, AV58ddo_ProdutoIdTitleControlIdToReplace, AV62ddo_ProdutoNomeTitleControlIdToReplace, AV70ddo_ProdutoValorTitleControlIdToReplace, AV76ddo_ProdutoDtValidadeTitleControlIdToReplace, AV108Pgmname, AV10GridState, AV28DynamicFiltersIgnoreFirst, AV27DynamicFiltersRemoving) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV87ProdutoWWDS_1_Produtodtvalidade = AV83ProdutoDtValidade;
         AV88ProdutoWWDS_2_Produtodtvalidade_to = AV84ProdutoDtValidade_To;
         AV89ProdutoWWDS_3_Dynamicfiltersselector1 = AV16DynamicFiltersSelector1;
         AV90ProdutoWWDS_4_Dynamicfiltersoperator1 = AV17DynamicFiltersOperator1;
         AV91ProdutoWWDS_5_Produtonome1 = AV18ProdutoNome1;
         AV92ProdutoWWDS_6_Dynamicfiltersenabled2 = AV19DynamicFiltersEnabled2;
         AV93ProdutoWWDS_7_Dynamicfiltersselector2 = AV20DynamicFiltersSelector2;
         AV94ProdutoWWDS_8_Dynamicfiltersoperator2 = AV21DynamicFiltersOperator2;
         AV95ProdutoWWDS_9_Produtonome2 = AV22ProdutoNome2;
         AV96ProdutoWWDS_10_Dynamicfiltersenabled3 = AV23DynamicFiltersEnabled3;
         AV97ProdutoWWDS_11_Dynamicfiltersselector3 = AV24DynamicFiltersSelector3;
         AV98ProdutoWWDS_12_Dynamicfiltersoperator3 = AV25DynamicFiltersOperator3;
         AV99ProdutoWWDS_13_Produtonome3 = AV26ProdutoNome3;
         AV100ProdutoWWDS_14_Tfprodutoid = AV56TFProdutoId;
         AV101ProdutoWWDS_15_Tfprodutoid_to = AV57TFProdutoId_To;
         AV102ProdutoWWDS_16_Tfprodutonome = AV60TFProdutoNome;
         AV103ProdutoWWDS_17_Tfprodutonome_sel = AV61TFProdutoNome_Sel;
         AV104ProdutoWWDS_18_Tfprodutovalor = AV68TFProdutoValor;
         AV105ProdutoWWDS_19_Tfprodutovalor_to = AV69TFProdutoValor_To;
         AV106ProdutoWWDS_20_Tfprodutodtvalidade = AV72TFProdutoDtValidade;
         AV107ProdutoWWDS_21_Tfprodutodtvalidade_to = AV73TFProdutoDtValidade_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV16DynamicFiltersSelector1, AV17DynamicFiltersOperator1, AV18ProdutoNome1, AV20DynamicFiltersSelector2, AV21DynamicFiltersOperator2, AV22ProdutoNome2, AV24DynamicFiltersSelector3, AV25DynamicFiltersOperator3, AV26ProdutoNome3, AV83ProdutoDtValidade, AV84ProdutoDtValidade_To, AV19DynamicFiltersEnabled2, AV23DynamicFiltersEnabled3, AV13OrderedBy, AV14OrderedDsc, AV56TFProdutoId, AV57TFProdutoId_To, AV60TFProdutoNome, AV61TFProdutoNome_Sel, AV68TFProdutoValor, AV69TFProdutoValor_To, AV72TFProdutoDtValidade, AV73TFProdutoDtValidade_To, AV49ManageFiltersExecutionStep, AV41ColumnsSelector, AV58ddo_ProdutoIdTitleControlIdToReplace, AV62ddo_ProdutoNomeTitleControlIdToReplace, AV70ddo_ProdutoValorTitleControlIdToReplace, AV76ddo_ProdutoDtValidadeTitleControlIdToReplace, AV108Pgmname, AV10GridState, AV28DynamicFiltersIgnoreFirst, AV27DynamicFiltersRemoving) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV87ProdutoWWDS_1_Produtodtvalidade = AV83ProdutoDtValidade;
         AV88ProdutoWWDS_2_Produtodtvalidade_to = AV84ProdutoDtValidade_To;
         AV89ProdutoWWDS_3_Dynamicfiltersselector1 = AV16DynamicFiltersSelector1;
         AV90ProdutoWWDS_4_Dynamicfiltersoperator1 = AV17DynamicFiltersOperator1;
         AV91ProdutoWWDS_5_Produtonome1 = AV18ProdutoNome1;
         AV92ProdutoWWDS_6_Dynamicfiltersenabled2 = AV19DynamicFiltersEnabled2;
         AV93ProdutoWWDS_7_Dynamicfiltersselector2 = AV20DynamicFiltersSelector2;
         AV94ProdutoWWDS_8_Dynamicfiltersoperator2 = AV21DynamicFiltersOperator2;
         AV95ProdutoWWDS_9_Produtonome2 = AV22ProdutoNome2;
         AV96ProdutoWWDS_10_Dynamicfiltersenabled3 = AV23DynamicFiltersEnabled3;
         AV97ProdutoWWDS_11_Dynamicfiltersselector3 = AV24DynamicFiltersSelector3;
         AV98ProdutoWWDS_12_Dynamicfiltersoperator3 = AV25DynamicFiltersOperator3;
         AV99ProdutoWWDS_13_Produtonome3 = AV26ProdutoNome3;
         AV100ProdutoWWDS_14_Tfprodutoid = AV56TFProdutoId;
         AV101ProdutoWWDS_15_Tfprodutoid_to = AV57TFProdutoId_To;
         AV102ProdutoWWDS_16_Tfprodutonome = AV60TFProdutoNome;
         AV103ProdutoWWDS_17_Tfprodutonome_sel = AV61TFProdutoNome_Sel;
         AV104ProdutoWWDS_18_Tfprodutovalor = AV68TFProdutoValor;
         AV105ProdutoWWDS_19_Tfprodutovalor_to = AV69TFProdutoValor_To;
         AV106ProdutoWWDS_20_Tfprodutodtvalidade = AV72TFProdutoDtValidade;
         AV107ProdutoWWDS_21_Tfprodutodtvalidade_to = AV73TFProdutoDtValidade_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV16DynamicFiltersSelector1, AV17DynamicFiltersOperator1, AV18ProdutoNome1, AV20DynamicFiltersSelector2, AV21DynamicFiltersOperator2, AV22ProdutoNome2, AV24DynamicFiltersSelector3, AV25DynamicFiltersOperator3, AV26ProdutoNome3, AV83ProdutoDtValidade, AV84ProdutoDtValidade_To, AV19DynamicFiltersEnabled2, AV23DynamicFiltersEnabled3, AV13OrderedBy, AV14OrderedDsc, AV56TFProdutoId, AV57TFProdutoId_To, AV60TFProdutoNome, AV61TFProdutoNome_Sel, AV68TFProdutoValor, AV69TFProdutoValor_To, AV72TFProdutoDtValidade, AV73TFProdutoDtValidade_To, AV49ManageFiltersExecutionStep, AV41ColumnsSelector, AV58ddo_ProdutoIdTitleControlIdToReplace, AV62ddo_ProdutoNomeTitleControlIdToReplace, AV70ddo_ProdutoValorTitleControlIdToReplace, AV76ddo_ProdutoDtValidadeTitleControlIdToReplace, AV108Pgmname, AV10GridState, AV28DynamicFiltersIgnoreFirst, AV27DynamicFiltersRemoving) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV87ProdutoWWDS_1_Produtodtvalidade = AV83ProdutoDtValidade;
         AV88ProdutoWWDS_2_Produtodtvalidade_to = AV84ProdutoDtValidade_To;
         AV89ProdutoWWDS_3_Dynamicfiltersselector1 = AV16DynamicFiltersSelector1;
         AV90ProdutoWWDS_4_Dynamicfiltersoperator1 = AV17DynamicFiltersOperator1;
         AV91ProdutoWWDS_5_Produtonome1 = AV18ProdutoNome1;
         AV92ProdutoWWDS_6_Dynamicfiltersenabled2 = AV19DynamicFiltersEnabled2;
         AV93ProdutoWWDS_7_Dynamicfiltersselector2 = AV20DynamicFiltersSelector2;
         AV94ProdutoWWDS_8_Dynamicfiltersoperator2 = AV21DynamicFiltersOperator2;
         AV95ProdutoWWDS_9_Produtonome2 = AV22ProdutoNome2;
         AV96ProdutoWWDS_10_Dynamicfiltersenabled3 = AV23DynamicFiltersEnabled3;
         AV97ProdutoWWDS_11_Dynamicfiltersselector3 = AV24DynamicFiltersSelector3;
         AV98ProdutoWWDS_12_Dynamicfiltersoperator3 = AV25DynamicFiltersOperator3;
         AV99ProdutoWWDS_13_Produtonome3 = AV26ProdutoNome3;
         AV100ProdutoWWDS_14_Tfprodutoid = AV56TFProdutoId;
         AV101ProdutoWWDS_15_Tfprodutoid_to = AV57TFProdutoId_To;
         AV102ProdutoWWDS_16_Tfprodutonome = AV60TFProdutoNome;
         AV103ProdutoWWDS_17_Tfprodutonome_sel = AV61TFProdutoNome_Sel;
         AV104ProdutoWWDS_18_Tfprodutovalor = AV68TFProdutoValor;
         AV105ProdutoWWDS_19_Tfprodutovalor_to = AV69TFProdutoValor_To;
         AV106ProdutoWWDS_20_Tfprodutodtvalidade = AV72TFProdutoDtValidade;
         AV107ProdutoWWDS_21_Tfprodutodtvalidade_to = AV73TFProdutoDtValidade_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV16DynamicFiltersSelector1, AV17DynamicFiltersOperator1, AV18ProdutoNome1, AV20DynamicFiltersSelector2, AV21DynamicFiltersOperator2, AV22ProdutoNome2, AV24DynamicFiltersSelector3, AV25DynamicFiltersOperator3, AV26ProdutoNome3, AV83ProdutoDtValidade, AV84ProdutoDtValidade_To, AV19DynamicFiltersEnabled2, AV23DynamicFiltersEnabled3, AV13OrderedBy, AV14OrderedDsc, AV56TFProdutoId, AV57TFProdutoId_To, AV60TFProdutoNome, AV61TFProdutoNome_Sel, AV68TFProdutoValor, AV69TFProdutoValor_To, AV72TFProdutoDtValidade, AV73TFProdutoDtValidade_To, AV49ManageFiltersExecutionStep, AV41ColumnsSelector, AV58ddo_ProdutoIdTitleControlIdToReplace, AV62ddo_ProdutoNomeTitleControlIdToReplace, AV70ddo_ProdutoValorTitleControlIdToReplace, AV76ddo_ProdutoDtValidadeTitleControlIdToReplace, AV108Pgmname, AV10GridState, AV28DynamicFiltersIgnoreFirst, AV27DynamicFiltersRemoving) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP0R0( )
      {
         /* Before Start, stand alone formulas. */
         AV108Pgmname = "ProdutoWW";
         context.Gx_err = 0;
         edtavUpdate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Enabled), 5, 0)), !bGXsfl_127_Refreshing);
         edtavDelete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Enabled), 5, 0)), !bGXsfl_127_Refreshing);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E280R2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vMANAGEFILTERSDATA"), AV53ManageFiltersData);
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV77DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vPRODUTOIDTITLEFILTERDATA"), AV55ProdutoIdTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPRODUTONOMETITLEFILTERDATA"), AV59ProdutoNomeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPRODUTOVALORTITLEFILTERDATA"), AV67ProdutoValorTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPRODUTODTVALIDADETITLEFILTERDATA"), AV71ProdutoDtValidadeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vCOLUMNSSELECTOR"), AV41ColumnsSelector);
            /* Read variables values. */
            cmbavDynamicfiltersselector1.Name = cmbavDynamicfiltersselector1_Internalname;
            cmbavDynamicfiltersselector1.CurrentValue = cgiGet( cmbavDynamicfiltersselector1_Internalname);
            AV16DynamicFiltersSelector1 = cgiGet( cmbavDynamicfiltersselector1_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16DynamicFiltersSelector1", AV16DynamicFiltersSelector1);
            cmbavDynamicfiltersoperator1.Name = cmbavDynamicfiltersoperator1_Internalname;
            cmbavDynamicfiltersoperator1.CurrentValue = cgiGet( cmbavDynamicfiltersoperator1_Internalname);
            AV17DynamicFiltersOperator1 = (short)(NumberUtil.Val( cgiGet( cmbavDynamicfiltersoperator1_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17DynamicFiltersOperator1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17DynamicFiltersOperator1), 4, 0)));
            AV18ProdutoNome1 = cgiGet( edtavProdutonome1_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ProdutoNome1", AV18ProdutoNome1);
            cmbavDynamicfiltersselector2.Name = cmbavDynamicfiltersselector2_Internalname;
            cmbavDynamicfiltersselector2.CurrentValue = cgiGet( cmbavDynamicfiltersselector2_Internalname);
            AV20DynamicFiltersSelector2 = cgiGet( cmbavDynamicfiltersselector2_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20DynamicFiltersSelector2", AV20DynamicFiltersSelector2);
            cmbavDynamicfiltersoperator2.Name = cmbavDynamicfiltersoperator2_Internalname;
            cmbavDynamicfiltersoperator2.CurrentValue = cgiGet( cmbavDynamicfiltersoperator2_Internalname);
            AV21DynamicFiltersOperator2 = (short)(NumberUtil.Val( cgiGet( cmbavDynamicfiltersoperator2_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21DynamicFiltersOperator2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21DynamicFiltersOperator2), 4, 0)));
            AV22ProdutoNome2 = cgiGet( edtavProdutonome2_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ProdutoNome2", AV22ProdutoNome2);
            cmbavDynamicfiltersselector3.Name = cmbavDynamicfiltersselector3_Internalname;
            cmbavDynamicfiltersselector3.CurrentValue = cgiGet( cmbavDynamicfiltersselector3_Internalname);
            AV24DynamicFiltersSelector3 = cgiGet( cmbavDynamicfiltersselector3_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24DynamicFiltersSelector3", AV24DynamicFiltersSelector3);
            cmbavDynamicfiltersoperator3.Name = cmbavDynamicfiltersoperator3_Internalname;
            cmbavDynamicfiltersoperator3.CurrentValue = cgiGet( cmbavDynamicfiltersoperator3_Internalname);
            AV25DynamicFiltersOperator3 = (short)(NumberUtil.Val( cgiGet( cmbavDynamicfiltersoperator3_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25DynamicFiltersOperator3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25DynamicFiltersOperator3), 4, 0)));
            AV26ProdutoNome3 = cgiGet( edtavProdutonome3_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26ProdutoNome3", AV26ProdutoNome3);
            if ( context.localUtil.VCDate( cgiGet( edtavProdutodtvalidade_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Produto Dt Validade"}), 1, "vPRODUTODTVALIDADE");
               GX_FocusControl = edtavProdutodtvalidade_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV83ProdutoDtValidade = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV83ProdutoDtValidade", context.localUtil.Format(AV83ProdutoDtValidade, "99/99/99"));
            }
            else
            {
               AV83ProdutoDtValidade = context.localUtil.CToD( cgiGet( edtavProdutodtvalidade_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV83ProdutoDtValidade", context.localUtil.Format(AV83ProdutoDtValidade, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavProdutodtvalidade_to_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Produto Dt Validade_To"}), 1, "vPRODUTODTVALIDADE_TO");
               GX_FocusControl = edtavProdutodtvalidade_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV84ProdutoDtValidade_To = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV84ProdutoDtValidade_To", context.localUtil.Format(AV84ProdutoDtValidade_To, "99/99/99"));
            }
            else
            {
               AV84ProdutoDtValidade_To = context.localUtil.CToD( cgiGet( edtavProdutodtvalidade_to_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV84ProdutoDtValidade_To", context.localUtil.Format(AV84ProdutoDtValidade_To, "99/99/99"));
            }
            AV58ddo_ProdutoIdTitleControlIdToReplace = cgiGet( edtavDdo_produtoidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV58ddo_ProdutoIdTitleControlIdToReplace", AV58ddo_ProdutoIdTitleControlIdToReplace);
            AV62ddo_ProdutoNomeTitleControlIdToReplace = cgiGet( edtavDdo_produtonometitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV62ddo_ProdutoNomeTitleControlIdToReplace", AV62ddo_ProdutoNomeTitleControlIdToReplace);
            AV70ddo_ProdutoValorTitleControlIdToReplace = cgiGet( edtavDdo_produtovalortitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV70ddo_ProdutoValorTitleControlIdToReplace", AV70ddo_ProdutoValorTitleControlIdToReplace);
            AV76ddo_ProdutoDtValidadeTitleControlIdToReplace = cgiGet( edtavDdo_produtodtvalidadetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV76ddo_ProdutoDtValidadeTitleControlIdToReplace", AV76ddo_ProdutoDtValidadeTitleControlIdToReplace);
            AV19DynamicFiltersEnabled2 = StringUtil.StrToBool( cgiGet( chkavDynamicfiltersenabled2_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19DynamicFiltersEnabled2", AV19DynamicFiltersEnabled2);
            AV23DynamicFiltersEnabled3 = StringUtil.StrToBool( cgiGet( chkavDynamicfiltersenabled3_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23DynamicFiltersEnabled3", AV23DynamicFiltersEnabled3);
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
               AV49ManageFiltersExecutionStep = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49ManageFiltersExecutionStep", StringUtil.Str( (decimal)(AV49ManageFiltersExecutionStep), 1, 0));
            }
            else
            {
               AV49ManageFiltersExecutionStep = (short)(context.localUtil.CToN( cgiGet( edtavManagefiltersexecutionstep_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49ManageFiltersExecutionStep", StringUtil.Str( (decimal)(AV49ManageFiltersExecutionStep), 1, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfprodutoid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfprodutoid_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFPRODUTOID");
               GX_FocusControl = edtavTfprodutoid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV56TFProdutoId = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56TFProdutoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV56TFProdutoId), 4, 0)));
            }
            else
            {
               AV56TFProdutoId = (short)(context.localUtil.CToN( cgiGet( edtavTfprodutoid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56TFProdutoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV56TFProdutoId), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfprodutoid_to_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfprodutoid_to_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFPRODUTOID_TO");
               GX_FocusControl = edtavTfprodutoid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV57TFProdutoId_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV57TFProdutoId_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV57TFProdutoId_To), 4, 0)));
            }
            else
            {
               AV57TFProdutoId_To = (short)(context.localUtil.CToN( cgiGet( edtavTfprodutoid_to_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV57TFProdutoId_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV57TFProdutoId_To), 4, 0)));
            }
            AV60TFProdutoNome = cgiGet( edtavTfprodutonome_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60TFProdutoNome", AV60TFProdutoNome);
            AV61TFProdutoNome_Sel = cgiGet( edtavTfprodutonome_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV61TFProdutoNome_Sel", AV61TFProdutoNome_Sel);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfprodutovalor_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfprodutovalor_Internalname), ",", ".") > 999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFPRODUTOVALOR");
               GX_FocusControl = edtavTfprodutovalor_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV68TFProdutoValor = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV68TFProdutoValor", StringUtil.LTrim( StringUtil.Str( AV68TFProdutoValor, 12, 2)));
            }
            else
            {
               AV68TFProdutoValor = context.localUtil.CToN( cgiGet( edtavTfprodutovalor_Internalname), ",", ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV68TFProdutoValor", StringUtil.LTrim( StringUtil.Str( AV68TFProdutoValor, 12, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfprodutovalor_to_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfprodutovalor_to_Internalname), ",", ".") > 999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFPRODUTOVALOR_TO");
               GX_FocusControl = edtavTfprodutovalor_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV69TFProdutoValor_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV69TFProdutoValor_To", StringUtil.LTrim( StringUtil.Str( AV69TFProdutoValor_To, 12, 2)));
            }
            else
            {
               AV69TFProdutoValor_To = context.localUtil.CToN( cgiGet( edtavTfprodutovalor_to_Internalname), ",", ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV69TFProdutoValor_To", StringUtil.LTrim( StringUtil.Str( AV69TFProdutoValor_To, 12, 2)));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavTfprodutodtvalidade_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"TFProduto Dt Validade"}), 1, "vTFPRODUTODTVALIDADE");
               GX_FocusControl = edtavTfprodutodtvalidade_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV72TFProdutoDtValidade = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV72TFProdutoDtValidade", context.localUtil.Format(AV72TFProdutoDtValidade, "99/99/99"));
            }
            else
            {
               AV72TFProdutoDtValidade = context.localUtil.CToD( cgiGet( edtavTfprodutodtvalidade_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV72TFProdutoDtValidade", context.localUtil.Format(AV72TFProdutoDtValidade, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavTfprodutodtvalidade_to_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"TFProduto Dt Validade_To"}), 1, "vTFPRODUTODTVALIDADE_TO");
               GX_FocusControl = edtavTfprodutodtvalidade_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV73TFProdutoDtValidade_To = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV73TFProdutoDtValidade_To", context.localUtil.Format(AV73TFProdutoDtValidade_To, "99/99/99"));
            }
            else
            {
               AV73TFProdutoDtValidade_To = context.localUtil.CToD( cgiGet( edtavTfprodutodtvalidade_to_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV73TFProdutoDtValidade_To", context.localUtil.Format(AV73TFProdutoDtValidade_To, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavDdo_produtodtvalidadeauxdate_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"DDO_Produto Dt Validade Aux Date"}), 1, "vDDO_PRODUTODTVALIDADEAUXDATE");
               GX_FocusControl = edtavDdo_produtodtvalidadeauxdate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV74DDO_ProdutoDtValidadeAuxDate = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV74DDO_ProdutoDtValidadeAuxDate", context.localUtil.Format(AV74DDO_ProdutoDtValidadeAuxDate, "99/99/99"));
            }
            else
            {
               AV74DDO_ProdutoDtValidadeAuxDate = context.localUtil.CToD( cgiGet( edtavDdo_produtodtvalidadeauxdate_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV74DDO_ProdutoDtValidadeAuxDate", context.localUtil.Format(AV74DDO_ProdutoDtValidadeAuxDate, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavDdo_produtodtvalidadeauxdateto_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"DDO_Produto Dt Validade Aux Date To"}), 1, "vDDO_PRODUTODTVALIDADEAUXDATETO");
               GX_FocusControl = edtavDdo_produtodtvalidadeauxdateto_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV75DDO_ProdutoDtValidadeAuxDateTo = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV75DDO_ProdutoDtValidadeAuxDateTo", context.localUtil.Format(AV75DDO_ProdutoDtValidadeAuxDateTo, "99/99/99"));
            }
            else
            {
               AV75DDO_ProdutoDtValidadeAuxDateTo = context.localUtil.CToD( cgiGet( edtavDdo_produtodtvalidadeauxdateto_Internalname), 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV75DDO_ProdutoDtValidadeAuxDateTo", context.localUtil.Format(AV75DDO_ProdutoDtValidadeAuxDateTo, "99/99/99"));
            }
            /* Read saved values. */
            nRC_GXsfl_127 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_127"), ",", "."));
            AV79GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ",", "."));
            AV80GridPageCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGECOUNT"), ",", "."));
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
            Ddo_produtoid_Caption = cgiGet( "DDO_PRODUTOID_Caption");
            Ddo_produtoid_Tooltip = cgiGet( "DDO_PRODUTOID_Tooltip");
            Ddo_produtoid_Cls = cgiGet( "DDO_PRODUTOID_Cls");
            Ddo_produtoid_Filteredtext_set = cgiGet( "DDO_PRODUTOID_Filteredtext_set");
            Ddo_produtoid_Filteredtextto_set = cgiGet( "DDO_PRODUTOID_Filteredtextto_set");
            Ddo_produtoid_Dropdownoptionstype = cgiGet( "DDO_PRODUTOID_Dropdownoptionstype");
            Ddo_produtoid_Titlecontrolidtoreplace = cgiGet( "DDO_PRODUTOID_Titlecontrolidtoreplace");
            Ddo_produtoid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PRODUTOID_Includesortasc"));
            Ddo_produtoid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PRODUTOID_Includesortdsc"));
            Ddo_produtoid_Sortedstatus = cgiGet( "DDO_PRODUTOID_Sortedstatus");
            Ddo_produtoid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PRODUTOID_Includefilter"));
            Ddo_produtoid_Filtertype = cgiGet( "DDO_PRODUTOID_Filtertype");
            Ddo_produtoid_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_PRODUTOID_Filterisrange"));
            Ddo_produtoid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PRODUTOID_Includedatalist"));
            Ddo_produtoid_Sortasc = cgiGet( "DDO_PRODUTOID_Sortasc");
            Ddo_produtoid_Sortdsc = cgiGet( "DDO_PRODUTOID_Sortdsc");
            Ddo_produtoid_Cleanfilter = cgiGet( "DDO_PRODUTOID_Cleanfilter");
            Ddo_produtoid_Rangefilterfrom = cgiGet( "DDO_PRODUTOID_Rangefilterfrom");
            Ddo_produtoid_Rangefilterto = cgiGet( "DDO_PRODUTOID_Rangefilterto");
            Ddo_produtoid_Searchbuttontext = cgiGet( "DDO_PRODUTOID_Searchbuttontext");
            Ddo_produtonome_Caption = cgiGet( "DDO_PRODUTONOME_Caption");
            Ddo_produtonome_Tooltip = cgiGet( "DDO_PRODUTONOME_Tooltip");
            Ddo_produtonome_Cls = cgiGet( "DDO_PRODUTONOME_Cls");
            Ddo_produtonome_Filteredtext_set = cgiGet( "DDO_PRODUTONOME_Filteredtext_set");
            Ddo_produtonome_Selectedvalue_set = cgiGet( "DDO_PRODUTONOME_Selectedvalue_set");
            Ddo_produtonome_Dropdownoptionstype = cgiGet( "DDO_PRODUTONOME_Dropdownoptionstype");
            Ddo_produtonome_Titlecontrolidtoreplace = cgiGet( "DDO_PRODUTONOME_Titlecontrolidtoreplace");
            Ddo_produtonome_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PRODUTONOME_Includesortasc"));
            Ddo_produtonome_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PRODUTONOME_Includesortdsc"));
            Ddo_produtonome_Sortedstatus = cgiGet( "DDO_PRODUTONOME_Sortedstatus");
            Ddo_produtonome_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PRODUTONOME_Includefilter"));
            Ddo_produtonome_Filtertype = cgiGet( "DDO_PRODUTONOME_Filtertype");
            Ddo_produtonome_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_PRODUTONOME_Filterisrange"));
            Ddo_produtonome_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PRODUTONOME_Includedatalist"));
            Ddo_produtonome_Datalisttype = cgiGet( "DDO_PRODUTONOME_Datalisttype");
            Ddo_produtonome_Datalistproc = cgiGet( "DDO_PRODUTONOME_Datalistproc");
            Ddo_produtonome_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_PRODUTONOME_Datalistupdateminimumcharacters"), ",", "."));
            Ddo_produtonome_Sortasc = cgiGet( "DDO_PRODUTONOME_Sortasc");
            Ddo_produtonome_Sortdsc = cgiGet( "DDO_PRODUTONOME_Sortdsc");
            Ddo_produtonome_Loadingdata = cgiGet( "DDO_PRODUTONOME_Loadingdata");
            Ddo_produtonome_Cleanfilter = cgiGet( "DDO_PRODUTONOME_Cleanfilter");
            Ddo_produtonome_Noresultsfound = cgiGet( "DDO_PRODUTONOME_Noresultsfound");
            Ddo_produtonome_Searchbuttontext = cgiGet( "DDO_PRODUTONOME_Searchbuttontext");
            Ddo_produtovalor_Caption = cgiGet( "DDO_PRODUTOVALOR_Caption");
            Ddo_produtovalor_Tooltip = cgiGet( "DDO_PRODUTOVALOR_Tooltip");
            Ddo_produtovalor_Cls = cgiGet( "DDO_PRODUTOVALOR_Cls");
            Ddo_produtovalor_Filteredtext_set = cgiGet( "DDO_PRODUTOVALOR_Filteredtext_set");
            Ddo_produtovalor_Filteredtextto_set = cgiGet( "DDO_PRODUTOVALOR_Filteredtextto_set");
            Ddo_produtovalor_Dropdownoptionstype = cgiGet( "DDO_PRODUTOVALOR_Dropdownoptionstype");
            Ddo_produtovalor_Titlecontrolidtoreplace = cgiGet( "DDO_PRODUTOVALOR_Titlecontrolidtoreplace");
            Ddo_produtovalor_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PRODUTOVALOR_Includesortasc"));
            Ddo_produtovalor_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PRODUTOVALOR_Includesortdsc"));
            Ddo_produtovalor_Sortedstatus = cgiGet( "DDO_PRODUTOVALOR_Sortedstatus");
            Ddo_produtovalor_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PRODUTOVALOR_Includefilter"));
            Ddo_produtovalor_Filtertype = cgiGet( "DDO_PRODUTOVALOR_Filtertype");
            Ddo_produtovalor_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_PRODUTOVALOR_Filterisrange"));
            Ddo_produtovalor_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PRODUTOVALOR_Includedatalist"));
            Ddo_produtovalor_Sortasc = cgiGet( "DDO_PRODUTOVALOR_Sortasc");
            Ddo_produtovalor_Sortdsc = cgiGet( "DDO_PRODUTOVALOR_Sortdsc");
            Ddo_produtovalor_Cleanfilter = cgiGet( "DDO_PRODUTOVALOR_Cleanfilter");
            Ddo_produtovalor_Rangefilterfrom = cgiGet( "DDO_PRODUTOVALOR_Rangefilterfrom");
            Ddo_produtovalor_Rangefilterto = cgiGet( "DDO_PRODUTOVALOR_Rangefilterto");
            Ddo_produtovalor_Searchbuttontext = cgiGet( "DDO_PRODUTOVALOR_Searchbuttontext");
            Ddo_produtodtvalidade_Caption = cgiGet( "DDO_PRODUTODTVALIDADE_Caption");
            Ddo_produtodtvalidade_Tooltip = cgiGet( "DDO_PRODUTODTVALIDADE_Tooltip");
            Ddo_produtodtvalidade_Cls = cgiGet( "DDO_PRODUTODTVALIDADE_Cls");
            Ddo_produtodtvalidade_Filteredtext_set = cgiGet( "DDO_PRODUTODTVALIDADE_Filteredtext_set");
            Ddo_produtodtvalidade_Filteredtextto_set = cgiGet( "DDO_PRODUTODTVALIDADE_Filteredtextto_set");
            Ddo_produtodtvalidade_Dropdownoptionstype = cgiGet( "DDO_PRODUTODTVALIDADE_Dropdownoptionstype");
            Ddo_produtodtvalidade_Titlecontrolidtoreplace = cgiGet( "DDO_PRODUTODTVALIDADE_Titlecontrolidtoreplace");
            Ddo_produtodtvalidade_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PRODUTODTVALIDADE_Includesortasc"));
            Ddo_produtodtvalidade_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PRODUTODTVALIDADE_Includesortdsc"));
            Ddo_produtodtvalidade_Sortedstatus = cgiGet( "DDO_PRODUTODTVALIDADE_Sortedstatus");
            Ddo_produtodtvalidade_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PRODUTODTVALIDADE_Includefilter"));
            Ddo_produtodtvalidade_Filtertype = cgiGet( "DDO_PRODUTODTVALIDADE_Filtertype");
            Ddo_produtodtvalidade_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_PRODUTODTVALIDADE_Filterisrange"));
            Ddo_produtodtvalidade_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PRODUTODTVALIDADE_Includedatalist"));
            Ddo_produtodtvalidade_Sortasc = cgiGet( "DDO_PRODUTODTVALIDADE_Sortasc");
            Ddo_produtodtvalidade_Sortdsc = cgiGet( "DDO_PRODUTODTVALIDADE_Sortdsc");
            Ddo_produtodtvalidade_Cleanfilter = cgiGet( "DDO_PRODUTODTVALIDADE_Cleanfilter");
            Ddo_produtodtvalidade_Rangefilterfrom = cgiGet( "DDO_PRODUTODTVALIDADE_Rangefilterfrom");
            Ddo_produtodtvalidade_Rangefilterto = cgiGet( "DDO_PRODUTODTVALIDADE_Rangefilterto");
            Ddo_produtodtvalidade_Searchbuttontext = cgiGet( "DDO_PRODUTODTVALIDADE_Searchbuttontext");
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
            Ddo_produtoid_Activeeventkey = cgiGet( "DDO_PRODUTOID_Activeeventkey");
            Ddo_produtoid_Filteredtext_get = cgiGet( "DDO_PRODUTOID_Filteredtext_get");
            Ddo_produtoid_Filteredtextto_get = cgiGet( "DDO_PRODUTOID_Filteredtextto_get");
            Ddo_produtonome_Activeeventkey = cgiGet( "DDO_PRODUTONOME_Activeeventkey");
            Ddo_produtonome_Filteredtext_get = cgiGet( "DDO_PRODUTONOME_Filteredtext_get");
            Ddo_produtonome_Selectedvalue_get = cgiGet( "DDO_PRODUTONOME_Selectedvalue_get");
            Ddo_produtovalor_Activeeventkey = cgiGet( "DDO_PRODUTOVALOR_Activeeventkey");
            Ddo_produtovalor_Filteredtext_get = cgiGet( "DDO_PRODUTOVALOR_Filteredtext_get");
            Ddo_produtovalor_Filteredtextto_get = cgiGet( "DDO_PRODUTOVALOR_Filteredtextto_get");
            Ddo_produtodtvalidade_Activeeventkey = cgiGet( "DDO_PRODUTODTVALIDADE_Activeeventkey");
            Ddo_produtodtvalidade_Filteredtext_get = cgiGet( "DDO_PRODUTODTVALIDADE_Filteredtext_get");
            Ddo_produtodtvalidade_Filteredtextto_get = cgiGet( "DDO_PRODUTODTVALIDADE_Filteredtextto_get");
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
            if ( StringUtil.StrCmp(cgiGet( "GXH_vPRODUTONOME1"), AV18ProdutoNome1) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vDYNAMICFILTERSSELECTOR2"), AV20DynamicFiltersSelector2) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vDYNAMICFILTERSOPERATOR2"), ",", ".") != Convert.ToDecimal( AV21DynamicFiltersOperator2 )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vPRODUTONOME2"), AV22ProdutoNome2) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vDYNAMICFILTERSSELECTOR3"), AV24DynamicFiltersSelector3) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vDYNAMICFILTERSOPERATOR3"), ",", ".") != Convert.ToDecimal( AV25DynamicFiltersOperator3 )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vPRODUTONOME3"), AV26ProdutoNome3) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vPRODUTODTVALIDADE"), 2) != AV83ProdutoDtValidade )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vPRODUTODTVALIDADE_TO"), 2) != AV84ProdutoDtValidade_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vDYNAMICFILTERSENABLED2")) != AV19DynamicFiltersEnabled2 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vDYNAMICFILTERSENABLED3")) != AV23DynamicFiltersEnabled3 )
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
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFPRODUTOID"), ",", ".") != Convert.ToDecimal( AV56TFProdutoId )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFPRODUTOID_TO"), ",", ".") != Convert.ToDecimal( AV57TFProdutoId_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFPRODUTONOME"), AV60TFProdutoNome) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFPRODUTONOME_SEL"), AV61TFProdutoNome_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFPRODUTOVALOR"), ",", ".") != AV68TFProdutoValor )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFPRODUTOVALOR_TO"), ",", ".") != AV69TFProdutoValor_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vTFPRODUTODTVALIDADE"), 2) != AV72TFProdutoDtValidade )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vTFPRODUTODTVALIDADE_TO"), 2) != AV73TFProdutoDtValidade_To )
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
         E280R2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E280R2( )
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
         AV16DynamicFiltersSelector1 = "PRODUTONOME";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16DynamicFiltersSelector1", AV16DynamicFiltersSelector1);
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS1' */
         S122 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV20DynamicFiltersSelector2 = "PRODUTONOME";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20DynamicFiltersSelector2", AV20DynamicFiltersSelector2);
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS2' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV24DynamicFiltersSelector3 = "PRODUTONOME";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24DynamicFiltersSelector3", AV24DynamicFiltersSelector3);
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
         edtavTfprodutoid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfprodutoid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfprodutoid_Visible), 5, 0)), true);
         edtavTfprodutoid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfprodutoid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfprodutoid_to_Visible), 5, 0)), true);
         edtavTfprodutonome_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfprodutonome_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfprodutonome_Visible), 5, 0)), true);
         edtavTfprodutonome_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfprodutonome_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfprodutonome_sel_Visible), 5, 0)), true);
         edtavTfprodutovalor_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfprodutovalor_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfprodutovalor_Visible), 5, 0)), true);
         edtavTfprodutovalor_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfprodutovalor_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfprodutovalor_to_Visible), 5, 0)), true);
         edtavTfprodutodtvalidade_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfprodutodtvalidade_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfprodutodtvalidade_Visible), 5, 0)), true);
         edtavTfprodutodtvalidade_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfprodutodtvalidade_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfprodutodtvalidade_to_Visible), 5, 0)), true);
         Ddo_produtoid_Titlecontrolidtoreplace = subGrid_Internalname+"_ProdutoId";
         ucDdo_produtoid.SendProperty(context, "", false, Ddo_produtoid_Internalname, "TitleControlIdToReplace", Ddo_produtoid_Titlecontrolidtoreplace);
         AV58ddo_ProdutoIdTitleControlIdToReplace = Ddo_produtoid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV58ddo_ProdutoIdTitleControlIdToReplace", AV58ddo_ProdutoIdTitleControlIdToReplace);
         edtavDdo_produtoidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_produtoidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_produtoidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_produtonome_Titlecontrolidtoreplace = subGrid_Internalname+"_ProdutoNome";
         ucDdo_produtonome.SendProperty(context, "", false, Ddo_produtonome_Internalname, "TitleControlIdToReplace", Ddo_produtonome_Titlecontrolidtoreplace);
         AV62ddo_ProdutoNomeTitleControlIdToReplace = Ddo_produtonome_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV62ddo_ProdutoNomeTitleControlIdToReplace", AV62ddo_ProdutoNomeTitleControlIdToReplace);
         edtavDdo_produtonometitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_produtonometitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_produtonometitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_produtovalor_Titlecontrolidtoreplace = subGrid_Internalname+"_ProdutoValor";
         ucDdo_produtovalor.SendProperty(context, "", false, Ddo_produtovalor_Internalname, "TitleControlIdToReplace", Ddo_produtovalor_Titlecontrolidtoreplace);
         AV70ddo_ProdutoValorTitleControlIdToReplace = Ddo_produtovalor_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV70ddo_ProdutoValorTitleControlIdToReplace", AV70ddo_ProdutoValorTitleControlIdToReplace);
         edtavDdo_produtovalortitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_produtovalortitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_produtovalortitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_produtodtvalidade_Titlecontrolidtoreplace = subGrid_Internalname+"_ProdutoDtValidade";
         ucDdo_produtodtvalidade.SendProperty(context, "", false, Ddo_produtodtvalidade_Internalname, "TitleControlIdToReplace", Ddo_produtodtvalidade_Titlecontrolidtoreplace);
         AV76ddo_ProdutoDtValidadeTitleControlIdToReplace = Ddo_produtodtvalidade_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV76ddo_ProdutoDtValidadeTitleControlIdToReplace", AV76ddo_ProdutoDtValidadeTitleControlIdToReplace);
         edtavDdo_produtodtvalidadetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_produtodtvalidadetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_produtodtvalidadetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = " Produto";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV77DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV77DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Ddo_gridcolumnsselector_Titlecontrolidtoreplace = bttBtneditcolumns_Internalname;
         ucDdo_gridcolumnsselector.SendProperty(context, "", false, Ddo_gridcolumnsselector_Internalname, "TitleControlIdToReplace", Ddo_gridcolumnsselector_Titlecontrolidtoreplace);
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E290R2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV55ProdutoIdTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV59ProdutoNomeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV67ProdutoValorTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV71ProdutoDtValidadeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         if ( AV49ManageFiltersExecutionStep == 1 )
         {
            AV49ManageFiltersExecutionStep = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49ManageFiltersExecutionStep", StringUtil.Str( (decimal)(AV49ManageFiltersExecutionStep), 1, 0));
         }
         else if ( AV49ManageFiltersExecutionStep == 2 )
         {
            AV49ManageFiltersExecutionStep = 0;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49ManageFiltersExecutionStep", StringUtil.Str( (decimal)(AV49ManageFiltersExecutionStep), 1, 0));
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
         if ( StringUtil.StrCmp(AV48Session.Get("ProdutoWWColumnsSelector"), "") != 0 )
         {
            AV29ColumnsSelectorXML = AV48Session.Get("ProdutoWWColumnsSelector");
            AV41ColumnsSelector.FromXml(AV29ColumnsSelectorXML, null, "WWPColumnsSelector", "FMX");
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
         edtProdutoId_Visible = (((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV41ColumnsSelector.gxTpr_Columns.Item(1)).gxTpr_Isvisible ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProdutoId_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProdutoId_Visible), 5, 0)), !bGXsfl_127_Refreshing);
         edtProdutoNome_Visible = (((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV41ColumnsSelector.gxTpr_Columns.Item(2)).gxTpr_Isvisible ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProdutoNome_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProdutoNome_Visible), 5, 0)), !bGXsfl_127_Refreshing);
         edtProdutoValor_Visible = (((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV41ColumnsSelector.gxTpr_Columns.Item(3)).gxTpr_Isvisible ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProdutoValor_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProdutoValor_Visible), 5, 0)), !bGXsfl_127_Refreshing);
         edtProdutoDtValidade_Visible = (((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV41ColumnsSelector.gxTpr_Columns.Item(4)).gxTpr_Isvisible ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProdutoDtValidade_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProdutoDtValidade_Visible), 5, 0)), !bGXsfl_127_Refreshing);
         edtProdutoId_Titleformat = 2;
         edtProdutoId_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Id", AV58ddo_ProdutoIdTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProdutoId_Internalname, "Title", edtProdutoId_Title, !bGXsfl_127_Refreshing);
         edtProdutoNome_Titleformat = 2;
         edtProdutoNome_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Nome", AV62ddo_ProdutoNomeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProdutoNome_Internalname, "Title", edtProdutoNome_Title, !bGXsfl_127_Refreshing);
         edtProdutoValor_Titleformat = 2;
         edtProdutoValor_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Valor", AV70ddo_ProdutoValorTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProdutoValor_Internalname, "Title", edtProdutoValor_Title, !bGXsfl_127_Refreshing);
         edtProdutoDtValidade_Titleformat = 2;
         edtProdutoDtValidade_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Data de Validade", AV76ddo_ProdutoDtValidadeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProdutoDtValidade_Internalname, "Title", edtProdutoDtValidade_Title, !bGXsfl_127_Refreshing);
         AV79GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV79GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV79GridCurrentPage), 10, 0)));
         AV80GridPageCount = subGrid_Pagecount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV80GridPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV80GridPageCount), 10, 0)));
         AV87ProdutoWWDS_1_Produtodtvalidade = AV83ProdutoDtValidade;
         AV88ProdutoWWDS_2_Produtodtvalidade_to = AV84ProdutoDtValidade_To;
         AV89ProdutoWWDS_3_Dynamicfiltersselector1 = AV16DynamicFiltersSelector1;
         AV90ProdutoWWDS_4_Dynamicfiltersoperator1 = AV17DynamicFiltersOperator1;
         AV91ProdutoWWDS_5_Produtonome1 = AV18ProdutoNome1;
         AV92ProdutoWWDS_6_Dynamicfiltersenabled2 = AV19DynamicFiltersEnabled2;
         AV93ProdutoWWDS_7_Dynamicfiltersselector2 = AV20DynamicFiltersSelector2;
         AV94ProdutoWWDS_8_Dynamicfiltersoperator2 = AV21DynamicFiltersOperator2;
         AV95ProdutoWWDS_9_Produtonome2 = AV22ProdutoNome2;
         AV96ProdutoWWDS_10_Dynamicfiltersenabled3 = AV23DynamicFiltersEnabled3;
         AV97ProdutoWWDS_11_Dynamicfiltersselector3 = AV24DynamicFiltersSelector3;
         AV98ProdutoWWDS_12_Dynamicfiltersoperator3 = AV25DynamicFiltersOperator3;
         AV99ProdutoWWDS_13_Produtonome3 = AV26ProdutoNome3;
         AV100ProdutoWWDS_14_Tfprodutoid = AV56TFProdutoId;
         AV101ProdutoWWDS_15_Tfprodutoid_to = AV57TFProdutoId_To;
         AV102ProdutoWWDS_16_Tfprodutonome = AV60TFProdutoNome;
         AV103ProdutoWWDS_17_Tfprodutonome_sel = AV61TFProdutoNome_Sel;
         AV104ProdutoWWDS_18_Tfprodutovalor = AV68TFProdutoValor;
         AV105ProdutoWWDS_19_Tfprodutovalor_to = AV69TFProdutoValor_To;
         AV106ProdutoWWDS_20_Tfprodutodtvalidade = AV72TFProdutoDtValidade;
         AV107ProdutoWWDS_21_Tfprodutodtvalidade_to = AV73TFProdutoDtValidade_To;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV55ProdutoIdTitleFilterData", AV55ProdutoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV59ProdutoNomeTitleFilterData", AV59ProdutoNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV67ProdutoValorTitleFilterData", AV67ProdutoValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV71ProdutoDtValidadeTitleFilterData", AV71ProdutoDtValidadeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41ColumnsSelector", AV41ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53ManageFiltersData", AV53ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E120R2( )
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
            AV78PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV78PageToGo) ;
         }
      }

      protected void E130R2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E140R2( )
      {
         /* Ddo_produtoid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_produtoid_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_produtoid_Sortedstatus = "ASC";
            ucDdo_produtoid.SendProperty(context, "", false, Ddo_produtoid_Internalname, "SortedStatus", Ddo_produtoid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_produtoid_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_produtoid_Sortedstatus = "DSC";
            ucDdo_produtoid.SendProperty(context, "", false, Ddo_produtoid_Internalname, "SortedStatus", Ddo_produtoid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_produtoid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV56TFProdutoId = (short)(NumberUtil.Val( Ddo_produtoid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56TFProdutoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV56TFProdutoId), 4, 0)));
            AV57TFProdutoId_To = (short)(NumberUtil.Val( Ddo_produtoid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV57TFProdutoId_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV57TFProdutoId_To), 4, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV55ProdutoIdTitleFilterData", AV55ProdutoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV59ProdutoNomeTitleFilterData", AV59ProdutoNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV67ProdutoValorTitleFilterData", AV67ProdutoValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV71ProdutoDtValidadeTitleFilterData", AV71ProdutoDtValidadeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41ColumnsSelector", AV41ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53ManageFiltersData", AV53ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E150R2( )
      {
         /* Ddo_produtonome_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_produtonome_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_produtonome_Sortedstatus = "ASC";
            ucDdo_produtonome.SendProperty(context, "", false, Ddo_produtonome_Internalname, "SortedStatus", Ddo_produtonome_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_produtonome_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_produtonome_Sortedstatus = "DSC";
            ucDdo_produtonome.SendProperty(context, "", false, Ddo_produtonome_Internalname, "SortedStatus", Ddo_produtonome_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_produtonome_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV60TFProdutoNome = Ddo_produtonome_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60TFProdutoNome", AV60TFProdutoNome);
            AV61TFProdutoNome_Sel = Ddo_produtonome_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV61TFProdutoNome_Sel", AV61TFProdutoNome_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV55ProdutoIdTitleFilterData", AV55ProdutoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV59ProdutoNomeTitleFilterData", AV59ProdutoNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV67ProdutoValorTitleFilterData", AV67ProdutoValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV71ProdutoDtValidadeTitleFilterData", AV71ProdutoDtValidadeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41ColumnsSelector", AV41ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53ManageFiltersData", AV53ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E160R2( )
      {
         /* Ddo_produtovalor_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_produtovalor_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_produtovalor_Sortedstatus = "ASC";
            ucDdo_produtovalor.SendProperty(context, "", false, Ddo_produtovalor_Internalname, "SortedStatus", Ddo_produtovalor_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_produtovalor_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_produtovalor_Sortedstatus = "DSC";
            ucDdo_produtovalor.SendProperty(context, "", false, Ddo_produtovalor_Internalname, "SortedStatus", Ddo_produtovalor_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_produtovalor_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV68TFProdutoValor = NumberUtil.Val( Ddo_produtovalor_Filteredtext_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV68TFProdutoValor", StringUtil.LTrim( StringUtil.Str( AV68TFProdutoValor, 12, 2)));
            AV69TFProdutoValor_To = NumberUtil.Val( Ddo_produtovalor_Filteredtextto_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV69TFProdutoValor_To", StringUtil.LTrim( StringUtil.Str( AV69TFProdutoValor_To, 12, 2)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV55ProdutoIdTitleFilterData", AV55ProdutoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV59ProdutoNomeTitleFilterData", AV59ProdutoNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV67ProdutoValorTitleFilterData", AV67ProdutoValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV71ProdutoDtValidadeTitleFilterData", AV71ProdutoDtValidadeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41ColumnsSelector", AV41ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53ManageFiltersData", AV53ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E170R2( )
      {
         /* Ddo_produtodtvalidade_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_produtodtvalidade_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_produtodtvalidade_Sortedstatus = "ASC";
            ucDdo_produtodtvalidade.SendProperty(context, "", false, Ddo_produtodtvalidade_Internalname, "SortedStatus", Ddo_produtodtvalidade_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_produtodtvalidade_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_produtodtvalidade_Sortedstatus = "DSC";
            ucDdo_produtodtvalidade.SendProperty(context, "", false, Ddo_produtodtvalidade_Internalname, "SortedStatus", Ddo_produtodtvalidade_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_produtodtvalidade_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV72TFProdutoDtValidade = context.localUtil.CToD( Ddo_produtodtvalidade_Filteredtext_get, 2);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV72TFProdutoDtValidade", context.localUtil.Format(AV72TFProdutoDtValidade, "99/99/99"));
            AV73TFProdutoDtValidade_To = context.localUtil.CToD( Ddo_produtodtvalidade_Filteredtextto_get, 2);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV73TFProdutoDtValidade_To", context.localUtil.Format(AV73TFProdutoDtValidade_To, "99/99/99"));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV55ProdutoIdTitleFilterData", AV55ProdutoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV59ProdutoNomeTitleFilterData", AV59ProdutoNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV67ProdutoValorTitleFilterData", AV67ProdutoValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV71ProdutoDtValidadeTitleFilterData", AV71ProdutoDtValidadeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41ColumnsSelector", AV41ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53ManageFiltersData", AV53ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      private void E300R2( )
      {
         /* Grid_Load Routine */
         AV81Update = "<i class=\"fa fa-pen\"></i>";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUpdate_Internalname, AV81Update);
         edtavUpdate_Link = formatLink("produto.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A8ProdutoId);
         AV82Delete = "<i class=\"fa fa-times\"></i>";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDelete_Internalname, AV82Delete);
         edtavDelete_Link = formatLink("produto.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A8ProdutoId);
         edtProdutoNome_Link = formatLink("produtoview.aspx") + "?" + UrlEncode("" +A8ProdutoId) + "," + UrlEncode(StringUtil.RTrim(""));
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 127;
         }
         sendrow_1272( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_127_Refreshing )
         {
            context.DoAjaxLoad(127, GridRow);
         }
         /*  Sending Event outputs  */
      }

      protected void E180R2( )
      {
         /* Ddo_gridcolumnsselector_Oncolumnschanged Routine */
         AV29ColumnsSelectorXML = Ddo_gridcolumnsselector_Columnsselectorvalues;
         AV41ColumnsSelector.FromJSonString(AV29ColumnsSelectorXML, null);
         new GeneXus.Programs.wwpbaseobjects.savecolumnsselectorstate(context ).execute(  "ProdutoWWColumnsSelector",  AV41ColumnsSelector.ToXml(false, true, "WWPColumnsSelector", "FMX")) ;
         context.DoAjaxRefresh();
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41ColumnsSelector", AV41ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV55ProdutoIdTitleFilterData", AV55ProdutoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV59ProdutoNomeTitleFilterData", AV59ProdutoNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV67ProdutoValorTitleFilterData", AV67ProdutoValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV71ProdutoDtValidadeTitleFilterData", AV71ProdutoDtValidadeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53ManageFiltersData", AV53ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E230R2( )
      {
         /* 'AddDynamicFilters1' Routine */
         AV19DynamicFiltersEnabled2 = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19DynamicFiltersEnabled2", AV19DynamicFiltersEnabled2);
         imgAdddynamicfilters1_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgAdddynamicfilters1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgAdddynamicfilters1_Visible), 5, 0)), true);
         imgRemovedynamicfilters1_Visible = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgRemovedynamicfilters1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgRemovedynamicfilters1_Visible), 5, 0)), true);
         /*  Sending Event outputs  */
      }

      protected void E190R2( )
      {
         /* 'RemoveDynamicFilters1' Routine */
         AV27DynamicFiltersRemoving = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27DynamicFiltersRemoving", AV27DynamicFiltersRemoving);
         AV28DynamicFiltersIgnoreFirst = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28DynamicFiltersIgnoreFirst", AV28DynamicFiltersIgnoreFirst);
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
         AV27DynamicFiltersRemoving = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27DynamicFiltersRemoving", AV27DynamicFiltersRemoving);
         AV28DynamicFiltersIgnoreFirst = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28DynamicFiltersIgnoreFirst", AV28DynamicFiltersIgnoreFirst);
         gxgrGrid_refresh( subGrid_Rows, AV16DynamicFiltersSelector1, AV17DynamicFiltersOperator1, AV18ProdutoNome1, AV20DynamicFiltersSelector2, AV21DynamicFiltersOperator2, AV22ProdutoNome2, AV24DynamicFiltersSelector3, AV25DynamicFiltersOperator3, AV26ProdutoNome3, AV83ProdutoDtValidade, AV84ProdutoDtValidade_To, AV19DynamicFiltersEnabled2, AV23DynamicFiltersEnabled3, AV13OrderedBy, AV14OrderedDsc, AV56TFProdutoId, AV57TFProdutoId_To, AV60TFProdutoNome, AV61TFProdutoNome_Sel, AV68TFProdutoValor, AV69TFProdutoValor_To, AV72TFProdutoDtValidade, AV73TFProdutoDtValidade_To, AV49ManageFiltersExecutionStep, AV41ColumnsSelector, AV58ddo_ProdutoIdTitleControlIdToReplace, AV62ddo_ProdutoNomeTitleControlIdToReplace, AV70ddo_ProdutoValorTitleControlIdToReplace, AV76ddo_ProdutoDtValidadeTitleControlIdToReplace, AV108Pgmname, AV10GridState, AV28DynamicFiltersIgnoreFirst, AV27DynamicFiltersRemoving) ;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
         cmbavDynamicfiltersselector2.CurrentValue = StringUtil.RTrim( AV20DynamicFiltersSelector2);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector2_Internalname, "Values", cmbavDynamicfiltersselector2.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV21DynamicFiltersOperator2), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", cmbavDynamicfiltersoperator2.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector3.CurrentValue = StringUtil.RTrim( AV24DynamicFiltersSelector3);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector3_Internalname, "Values", cmbavDynamicfiltersselector3.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV25DynamicFiltersOperator3), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", cmbavDynamicfiltersoperator3.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector1.CurrentValue = StringUtil.RTrim( AV16DynamicFiltersSelector1);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector1_Internalname, "Values", cmbavDynamicfiltersselector1.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV17DynamicFiltersOperator1), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", cmbavDynamicfiltersoperator1.ToJavascriptSource(), true);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV55ProdutoIdTitleFilterData", AV55ProdutoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV59ProdutoNomeTitleFilterData", AV59ProdutoNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV67ProdutoValorTitleFilterData", AV67ProdutoValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV71ProdutoDtValidadeTitleFilterData", AV71ProdutoDtValidadeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41ColumnsSelector", AV41ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53ManageFiltersData", AV53ManageFiltersData);
      }

      protected void E240R2( )
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

      protected void E250R2( )
      {
         /* 'AddDynamicFilters2' Routine */
         AV23DynamicFiltersEnabled3 = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23DynamicFiltersEnabled3", AV23DynamicFiltersEnabled3);
         imgAdddynamicfilters2_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgAdddynamicfilters2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgAdddynamicfilters2_Visible), 5, 0)), true);
         imgRemovedynamicfilters2_Visible = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgRemovedynamicfilters2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgRemovedynamicfilters2_Visible), 5, 0)), true);
         /*  Sending Event outputs  */
      }

      protected void E200R2( )
      {
         /* 'RemoveDynamicFilters2' Routine */
         AV27DynamicFiltersRemoving = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27DynamicFiltersRemoving", AV27DynamicFiltersRemoving);
         AV19DynamicFiltersEnabled2 = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19DynamicFiltersEnabled2", AV19DynamicFiltersEnabled2);
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
         AV27DynamicFiltersRemoving = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27DynamicFiltersRemoving", AV27DynamicFiltersRemoving);
         gxgrGrid_refresh( subGrid_Rows, AV16DynamicFiltersSelector1, AV17DynamicFiltersOperator1, AV18ProdutoNome1, AV20DynamicFiltersSelector2, AV21DynamicFiltersOperator2, AV22ProdutoNome2, AV24DynamicFiltersSelector3, AV25DynamicFiltersOperator3, AV26ProdutoNome3, AV83ProdutoDtValidade, AV84ProdutoDtValidade_To, AV19DynamicFiltersEnabled2, AV23DynamicFiltersEnabled3, AV13OrderedBy, AV14OrderedDsc, AV56TFProdutoId, AV57TFProdutoId_To, AV60TFProdutoNome, AV61TFProdutoNome_Sel, AV68TFProdutoValor, AV69TFProdutoValor_To, AV72TFProdutoDtValidade, AV73TFProdutoDtValidade_To, AV49ManageFiltersExecutionStep, AV41ColumnsSelector, AV58ddo_ProdutoIdTitleControlIdToReplace, AV62ddo_ProdutoNomeTitleControlIdToReplace, AV70ddo_ProdutoValorTitleControlIdToReplace, AV76ddo_ProdutoDtValidadeTitleControlIdToReplace, AV108Pgmname, AV10GridState, AV28DynamicFiltersIgnoreFirst, AV27DynamicFiltersRemoving) ;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
         cmbavDynamicfiltersselector2.CurrentValue = StringUtil.RTrim( AV20DynamicFiltersSelector2);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector2_Internalname, "Values", cmbavDynamicfiltersselector2.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV21DynamicFiltersOperator2), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", cmbavDynamicfiltersoperator2.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector3.CurrentValue = StringUtil.RTrim( AV24DynamicFiltersSelector3);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector3_Internalname, "Values", cmbavDynamicfiltersselector3.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV25DynamicFiltersOperator3), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", cmbavDynamicfiltersoperator3.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector1.CurrentValue = StringUtil.RTrim( AV16DynamicFiltersSelector1);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector1_Internalname, "Values", cmbavDynamicfiltersselector1.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV17DynamicFiltersOperator1), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", cmbavDynamicfiltersoperator1.ToJavascriptSource(), true);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV55ProdutoIdTitleFilterData", AV55ProdutoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV59ProdutoNomeTitleFilterData", AV59ProdutoNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV67ProdutoValorTitleFilterData", AV67ProdutoValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV71ProdutoDtValidadeTitleFilterData", AV71ProdutoDtValidadeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41ColumnsSelector", AV41ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53ManageFiltersData", AV53ManageFiltersData);
      }

      protected void E260R2( )
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

      protected void E210R2( )
      {
         /* 'RemoveDynamicFilters3' Routine */
         AV27DynamicFiltersRemoving = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27DynamicFiltersRemoving", AV27DynamicFiltersRemoving);
         AV23DynamicFiltersEnabled3 = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23DynamicFiltersEnabled3", AV23DynamicFiltersEnabled3);
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
         AV27DynamicFiltersRemoving = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27DynamicFiltersRemoving", AV27DynamicFiltersRemoving);
         gxgrGrid_refresh( subGrid_Rows, AV16DynamicFiltersSelector1, AV17DynamicFiltersOperator1, AV18ProdutoNome1, AV20DynamicFiltersSelector2, AV21DynamicFiltersOperator2, AV22ProdutoNome2, AV24DynamicFiltersSelector3, AV25DynamicFiltersOperator3, AV26ProdutoNome3, AV83ProdutoDtValidade, AV84ProdutoDtValidade_To, AV19DynamicFiltersEnabled2, AV23DynamicFiltersEnabled3, AV13OrderedBy, AV14OrderedDsc, AV56TFProdutoId, AV57TFProdutoId_To, AV60TFProdutoNome, AV61TFProdutoNome_Sel, AV68TFProdutoValor, AV69TFProdutoValor_To, AV72TFProdutoDtValidade, AV73TFProdutoDtValidade_To, AV49ManageFiltersExecutionStep, AV41ColumnsSelector, AV58ddo_ProdutoIdTitleControlIdToReplace, AV62ddo_ProdutoNomeTitleControlIdToReplace, AV70ddo_ProdutoValorTitleControlIdToReplace, AV76ddo_ProdutoDtValidadeTitleControlIdToReplace, AV108Pgmname, AV10GridState, AV28DynamicFiltersIgnoreFirst, AV27DynamicFiltersRemoving) ;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
         cmbavDynamicfiltersselector2.CurrentValue = StringUtil.RTrim( AV20DynamicFiltersSelector2);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector2_Internalname, "Values", cmbavDynamicfiltersselector2.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV21DynamicFiltersOperator2), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", cmbavDynamicfiltersoperator2.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector3.CurrentValue = StringUtil.RTrim( AV24DynamicFiltersSelector3);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector3_Internalname, "Values", cmbavDynamicfiltersselector3.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV25DynamicFiltersOperator3), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", cmbavDynamicfiltersoperator3.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector1.CurrentValue = StringUtil.RTrim( AV16DynamicFiltersSelector1);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector1_Internalname, "Values", cmbavDynamicfiltersselector1.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV17DynamicFiltersOperator1), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", cmbavDynamicfiltersoperator1.ToJavascriptSource(), true);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV55ProdutoIdTitleFilterData", AV55ProdutoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV59ProdutoNomeTitleFilterData", AV59ProdutoNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV67ProdutoValorTitleFilterData", AV67ProdutoValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV71ProdutoDtValidadeTitleFilterData", AV71ProdutoDtValidadeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41ColumnsSelector", AV41ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53ManageFiltersData", AV53ManageFiltersData);
      }

      protected void E270R2( )
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

      protected void E110R2( )
      {
         /* Ddo_managefilters_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_managefilters_Activeeventkey, "<#Clean#>") == 0 )
         {
            /* Execute user subroutine: 'CLEANFILTERS' */
            S242 ();
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
            context.PopUp(formatLink("wwpbaseobjects.savefilteras.aspx") + "?" + UrlEncode(StringUtil.RTrim("ProdutoWWFilters")) + "," + UrlEncode(StringUtil.RTrim(AV108Pgmname+"GridState")), new Object[] {});
            AV49ManageFiltersExecutionStep = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49ManageFiltersExecutionStep", StringUtil.Str( (decimal)(AV49ManageFiltersExecutionStep), 1, 0));
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_managefilters_Activeeventkey, "<#Manage#>") == 0 )
         {
            context.PopUp(formatLink("wwpbaseobjects.managefilters.aspx") + "?" + UrlEncode(StringUtil.RTrim("ProdutoWWFilters")), new Object[] {});
            AV49ManageFiltersExecutionStep = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49ManageFiltersExecutionStep", StringUtil.Str( (decimal)(AV49ManageFiltersExecutionStep), 1, 0));
            context.DoAjaxRefresh();
         }
         else
         {
            GXt_char2 = AV50ManageFiltersXml;
            new GeneXus.Programs.wwpbaseobjects.getfilterbyname(context ).execute(  "ProdutoWWFilters",  Ddo_managefilters_Activeeventkey, out  GXt_char2) ;
            ucDdo_managefilters.SendProperty(context, "", false, Ddo_managefilters_Internalname, "ActiveEventKey", Ddo_managefilters_Activeeventkey);
            AV50ManageFiltersXml = GXt_char2;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( AV50ManageFiltersXml)) )
            {
               GX_msglist.addItem("O filtro selecionado não existe mais.");
            }
            else
            {
               /* Execute user subroutine: 'CLEANFILTERS' */
               S242 ();
               if ( returnInSub )
               {
                  returnInSub = true;
                  if (true) return;
               }
               new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV108Pgmname+"GridState",  AV50ManageFiltersXml) ;
               AV10GridState.FromXml(AV50ManageFiltersXml, null, "WWPGridState", "FMX");
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
               S252 ();
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
         cmbavDynamicfiltersselector1.CurrentValue = StringUtil.RTrim( AV16DynamicFiltersSelector1);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector1_Internalname, "Values", cmbavDynamicfiltersselector1.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV17DynamicFiltersOperator1), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", cmbavDynamicfiltersoperator1.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector2.CurrentValue = StringUtil.RTrim( AV20DynamicFiltersSelector2);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector2_Internalname, "Values", cmbavDynamicfiltersselector2.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV21DynamicFiltersOperator2), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", cmbavDynamicfiltersoperator2.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector3.CurrentValue = StringUtil.RTrim( AV24DynamicFiltersSelector3);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector3_Internalname, "Values", cmbavDynamicfiltersselector3.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV25DynamicFiltersOperator3), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", cmbavDynamicfiltersoperator3.ToJavascriptSource(), true);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV55ProdutoIdTitleFilterData", AV55ProdutoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV59ProdutoNomeTitleFilterData", AV59ProdutoNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV67ProdutoValorTitleFilterData", AV67ProdutoValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV71ProdutoDtValidadeTitleFilterData", AV71ProdutoDtValidadeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41ColumnsSelector", AV41ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53ManageFiltersData", AV53ManageFiltersData);
      }

      protected void E220R2( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("produto.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
         context.wjLocDisableFrm = 1;
      }

      protected void S202( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_produtoid_Sortedstatus = "";
         ucDdo_produtoid.SendProperty(context, "", false, Ddo_produtoid_Internalname, "SortedStatus", Ddo_produtoid_Sortedstatus);
         Ddo_produtonome_Sortedstatus = "";
         ucDdo_produtonome.SendProperty(context, "", false, Ddo_produtonome_Internalname, "SortedStatus", Ddo_produtonome_Sortedstatus);
         Ddo_produtovalor_Sortedstatus = "";
         ucDdo_produtovalor.SendProperty(context, "", false, Ddo_produtovalor_Internalname, "SortedStatus", Ddo_produtovalor_Sortedstatus);
         Ddo_produtodtvalidade_Sortedstatus = "";
         ucDdo_produtodtvalidade.SendProperty(context, "", false, Ddo_produtodtvalidade_Internalname, "SortedStatus", Ddo_produtodtvalidade_Sortedstatus);
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
            Ddo_produtoid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_produtoid.SendProperty(context, "", false, Ddo_produtoid_Internalname, "SortedStatus", Ddo_produtoid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 1 )
         {
            Ddo_produtonome_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_produtonome.SendProperty(context, "", false, Ddo_produtonome_Internalname, "SortedStatus", Ddo_produtonome_Sortedstatus);
         }
         else if ( AV13OrderedBy == 3 )
         {
            Ddo_produtovalor_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_produtovalor.SendProperty(context, "", false, Ddo_produtovalor_Internalname, "SortedStatus", Ddo_produtovalor_Sortedstatus);
         }
         else if ( AV13OrderedBy == 4 )
         {
            Ddo_produtodtvalidade_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_produtodtvalidade.SendProperty(context, "", false, Ddo_produtodtvalidade_Internalname, "SortedStatus", Ddo_produtodtvalidade_Sortedstatus);
         }
      }

      protected void S192( )
      {
         /* 'INITIALIZECOLUMNSSELECTOR' Routine */
         AV41ColumnsSelector = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector(context);
         new GeneXus.Programs.wwpbaseobjects.wwp_columnsselector_add(context ).execute( ref  AV41ColumnsSelector,  "Id",  true) ;
         new GeneXus.Programs.wwpbaseobjects.wwp_columnsselector_add(context ).execute( ref  AV41ColumnsSelector,  "Nome",  true) ;
         new GeneXus.Programs.wwpbaseobjects.wwp_columnsselector_add(context ).execute( ref  AV41ColumnsSelector,  "Valor",  true) ;
         new GeneXus.Programs.wwpbaseobjects.wwp_columnsselector_add(context ).execute( ref  AV41ColumnsSelector,  "Data de Validade",  true) ;
         GXt_char2 = AV36UserCustomValue;
         new GeneXus.Programs.wwpbaseobjects.loadcolumnsselectorstate(context ).execute(  "ProdutoWWColumnsSelector", out  GXt_char2) ;
         AV36UserCustomValue = GXt_char2;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( AV36UserCustomValue)) ) )
         {
            AV42ColumnsSelectorAux.FromXml(AV36UserCustomValue, null, "WWPColumnsSelector", "FMX");
            new GeneXus.Programs.wwpbaseobjects.wwp_columnselector_updatecolumns(context ).execute( ref  AV42ColumnsSelectorAux, ref  AV41ColumnsSelector) ;
         }
      }

      protected void S122( )
      {
         /* 'ENABLEDYNAMICFILTERS1' Routine */
         edtavProdutonome1_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavProdutonome1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavProdutonome1_Visible), 5, 0)), true);
         cmbavDynamicfiltersoperator1.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavDynamicfiltersoperator1.Visible), 5, 0)), true);
         if ( StringUtil.StrCmp(AV16DynamicFiltersSelector1, "PRODUTONOME") == 0 )
         {
            edtavProdutonome1_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavProdutonome1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavProdutonome1_Visible), 5, 0)), true);
            cmbavDynamicfiltersoperator1.Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavDynamicfiltersoperator1.Visible), 5, 0)), true);
         }
      }

      protected void S132( )
      {
         /* 'ENABLEDYNAMICFILTERS2' Routine */
         edtavProdutonome2_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavProdutonome2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavProdutonome2_Visible), 5, 0)), true);
         cmbavDynamicfiltersoperator2.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavDynamicfiltersoperator2.Visible), 5, 0)), true);
         if ( StringUtil.StrCmp(AV20DynamicFiltersSelector2, "PRODUTONOME") == 0 )
         {
            edtavProdutonome2_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavProdutonome2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavProdutonome2_Visible), 5, 0)), true);
            cmbavDynamicfiltersoperator2.Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavDynamicfiltersoperator2.Visible), 5, 0)), true);
         }
      }

      protected void S142( )
      {
         /* 'ENABLEDYNAMICFILTERS3' Routine */
         edtavProdutonome3_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavProdutonome3_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavProdutonome3_Visible), 5, 0)), true);
         cmbavDynamicfiltersoperator3.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavDynamicfiltersoperator3.Visible), 5, 0)), true);
         if ( StringUtil.StrCmp(AV24DynamicFiltersSelector3, "PRODUTONOME") == 0 )
         {
            edtavProdutonome3_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavProdutonome3_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavProdutonome3_Visible), 5, 0)), true);
            cmbavDynamicfiltersoperator3.Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavDynamicfiltersoperator3.Visible), 5, 0)), true);
         }
      }

      protected void S222( )
      {
         /* 'RESETDYNFILTERS' Routine */
         AV19DynamicFiltersEnabled2 = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19DynamicFiltersEnabled2", AV19DynamicFiltersEnabled2);
         AV20DynamicFiltersSelector2 = "PRODUTONOME";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20DynamicFiltersSelector2", AV20DynamicFiltersSelector2);
         AV21DynamicFiltersOperator2 = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21DynamicFiltersOperator2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21DynamicFiltersOperator2), 4, 0)));
         AV22ProdutoNome2 = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ProdutoNome2", AV22ProdutoNome2);
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS2' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV23DynamicFiltersEnabled3 = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23DynamicFiltersEnabled3", AV23DynamicFiltersEnabled3);
         AV24DynamicFiltersSelector3 = "PRODUTONOME";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24DynamicFiltersSelector3", AV24DynamicFiltersSelector3);
         AV25DynamicFiltersOperator3 = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25DynamicFiltersOperator3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25DynamicFiltersOperator3), 4, 0)));
         AV26ProdutoNome3 = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26ProdutoNome3", AV26ProdutoNome3);
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
         AV53ManageFiltersData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV54ManageFiltersDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
         AV54ManageFiltersDataItem.gxTpr_Title = "Limpar filtros";
         AV54ManageFiltersDataItem.gxTpr_Eventkey = "<#Clean#>";
         AV54ManageFiltersDataItem.gxTpr_Isdivider = false;
         AV54ManageFiltersDataItem.gxTpr_Icon = context.convertURL( (String)(context.GetImagePath( "63d2ae92-4e43-4a70-af61-0943e39ea422", "", context.GetTheme( ))));
         AV54ManageFiltersDataItem.gxTpr_Jsonclickevent = StringUtil.Format( "WWPDynFilterHideAll_AL('%1', 3, 0)", tblTabledynamicfilters_Internalname, "", "", "", "", "", "", "", "");
         AV53ManageFiltersData.Add(AV54ManageFiltersDataItem, 0);
         AV54ManageFiltersDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
         AV54ManageFiltersDataItem.gxTpr_Title = "Salvar filtro como...";
         AV54ManageFiltersDataItem.gxTpr_Eventkey = "<#Save#>";
         AV54ManageFiltersDataItem.gxTpr_Isdivider = false;
         AV54ManageFiltersDataItem.gxTpr_Icon = context.convertURL( (String)(context.GetImagePath( "6eee63e8-73c7-4738-beee-f98e3a8d2841", "", context.GetTheme( ))));
         AV53ManageFiltersData.Add(AV54ManageFiltersDataItem, 0);
         AV54ManageFiltersDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
         AV54ManageFiltersDataItem.gxTpr_Isdivider = true;
         AV53ManageFiltersData.Add(AV54ManageFiltersDataItem, 0);
         AV51ManageFiltersItems.FromXml(new GeneXus.Programs.wwpbaseobjects.loadmanagefiltersstate(context).executeUdp(  "ProdutoWWFilters"), null, "Items", "");
         AV109GXV1 = 1;
         while ( AV109GXV1 <= AV51ManageFiltersItems.Count )
         {
            AV52ManageFiltersItem = ((GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item)AV51ManageFiltersItems.Item(AV109GXV1));
            AV54ManageFiltersDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
            AV54ManageFiltersDataItem.gxTpr_Title = AV52ManageFiltersItem.gxTpr_Title;
            AV54ManageFiltersDataItem.gxTpr_Eventkey = AV52ManageFiltersItem.gxTpr_Title;
            AV54ManageFiltersDataItem.gxTpr_Isdivider = false;
            AV54ManageFiltersDataItem.gxTpr_Jsonclickevent = StringUtil.Format( "WWPDynFilterHideAll_AL('%1', 3, 0)", tblTabledynamicfilters_Internalname, "", "", "", "", "", "", "", "");
            AV53ManageFiltersData.Add(AV54ManageFiltersDataItem, 0);
            if ( AV53ManageFiltersData.Count == 13 )
            {
               if (true) break;
            }
            AV109GXV1 = (int)(AV109GXV1+1);
         }
         if ( AV53ManageFiltersData.Count > 3 )
         {
            AV54ManageFiltersDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
            AV54ManageFiltersDataItem.gxTpr_Isdivider = true;
            AV53ManageFiltersData.Add(AV54ManageFiltersDataItem, 0);
            AV54ManageFiltersDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
            AV54ManageFiltersDataItem.gxTpr_Title = "Gerenciar filtros";
            AV54ManageFiltersDataItem.gxTpr_Eventkey = "<#Manage#>";
            AV54ManageFiltersDataItem.gxTpr_Isdivider = false;
            AV54ManageFiltersDataItem.gxTpr_Icon = context.convertURL( (String)(context.GetImagePath( "653f6166-5d82-407a-af84-19e0dde65efd", "", context.GetTheme( ))));
            AV54ManageFiltersDataItem.gxTpr_Jsonclickevent = "";
            AV53ManageFiltersData.Add(AV54ManageFiltersDataItem, 0);
         }
      }

      protected void S242( )
      {
         /* 'CLEANFILTERS' Routine */
         AV83ProdutoDtValidade = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV83ProdutoDtValidade", context.localUtil.Format(AV83ProdutoDtValidade, "99/99/99"));
         AV84ProdutoDtValidade_To = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV84ProdutoDtValidade_To", context.localUtil.Format(AV84ProdutoDtValidade_To, "99/99/99"));
         AV56TFProdutoId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56TFProdutoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV56TFProdutoId), 4, 0)));
         Ddo_produtoid_Filteredtext_set = "";
         ucDdo_produtoid.SendProperty(context, "", false, Ddo_produtoid_Internalname, "FilteredText_set", Ddo_produtoid_Filteredtext_set);
         AV57TFProdutoId_To = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV57TFProdutoId_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV57TFProdutoId_To), 4, 0)));
         Ddo_produtoid_Filteredtextto_set = "";
         ucDdo_produtoid.SendProperty(context, "", false, Ddo_produtoid_Internalname, "FilteredTextTo_set", Ddo_produtoid_Filteredtextto_set);
         AV60TFProdutoNome = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60TFProdutoNome", AV60TFProdutoNome);
         Ddo_produtonome_Filteredtext_set = "";
         ucDdo_produtonome.SendProperty(context, "", false, Ddo_produtonome_Internalname, "FilteredText_set", Ddo_produtonome_Filteredtext_set);
         AV61TFProdutoNome_Sel = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV61TFProdutoNome_Sel", AV61TFProdutoNome_Sel);
         Ddo_produtonome_Selectedvalue_set = "";
         ucDdo_produtonome.SendProperty(context, "", false, Ddo_produtonome_Internalname, "SelectedValue_set", Ddo_produtonome_Selectedvalue_set);
         AV68TFProdutoValor = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV68TFProdutoValor", StringUtil.LTrim( StringUtil.Str( AV68TFProdutoValor, 12, 2)));
         Ddo_produtovalor_Filteredtext_set = "";
         ucDdo_produtovalor.SendProperty(context, "", false, Ddo_produtovalor_Internalname, "FilteredText_set", Ddo_produtovalor_Filteredtext_set);
         AV69TFProdutoValor_To = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV69TFProdutoValor_To", StringUtil.LTrim( StringUtil.Str( AV69TFProdutoValor_To, 12, 2)));
         Ddo_produtovalor_Filteredtextto_set = "";
         ucDdo_produtovalor.SendProperty(context, "", false, Ddo_produtovalor_Internalname, "FilteredTextTo_set", Ddo_produtovalor_Filteredtextto_set);
         AV72TFProdutoDtValidade = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV72TFProdutoDtValidade", context.localUtil.Format(AV72TFProdutoDtValidade, "99/99/99"));
         Ddo_produtodtvalidade_Filteredtext_set = "";
         ucDdo_produtodtvalidade.SendProperty(context, "", false, Ddo_produtodtvalidade_Internalname, "FilteredText_set", Ddo_produtodtvalidade_Filteredtext_set);
         AV73TFProdutoDtValidade_To = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV73TFProdutoDtValidade_To", context.localUtil.Format(AV73TFProdutoDtValidade_To, "99/99/99"));
         Ddo_produtodtvalidade_Filteredtextto_set = "";
         ucDdo_produtodtvalidade.SendProperty(context, "", false, Ddo_produtodtvalidade_Internalname, "FilteredTextTo_set", Ddo_produtodtvalidade_Filteredtextto_set);
         AV16DynamicFiltersSelector1 = "PRODUTONOME";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16DynamicFiltersSelector1", AV16DynamicFiltersSelector1);
         AV17DynamicFiltersOperator1 = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17DynamicFiltersOperator1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17DynamicFiltersOperator1), 4, 0)));
         AV18ProdutoNome1 = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ProdutoNome1", AV18ProdutoNome1);
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
         if ( StringUtil.StrCmp(AV48Session.Get(AV108Pgmname+"GridState"), "") == 0 )
         {
            AV10GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV108Pgmname+"GridState"), null, "WWPGridState", "FMX");
         }
         else
         {
            AV10GridState.FromXml(AV48Session.Get(AV108Pgmname+"GridState"), null, "WWPGridState", "FMX");
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
         S252 ();
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

      protected void S252( )
      {
         /* 'LOADREGFILTERSSTATE' Routine */
         AV110GXV2 = 1;
         while ( AV110GXV2 <= AV10GridState.gxTpr_Filtervalues.Count )
         {
            AV11GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV10GridState.gxTpr_Filtervalues.Item(AV110GXV2));
            if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "PRODUTODTVALIDADE") == 0 )
            {
               AV83ProdutoDtValidade = context.localUtil.CToD( AV11GridStateFilterValue.gxTpr_Value, 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV83ProdutoDtValidade", context.localUtil.Format(AV83ProdutoDtValidade, "99/99/99"));
               AV84ProdutoDtValidade_To = context.localUtil.CToD( AV11GridStateFilterValue.gxTpr_Valueto, 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV84ProdutoDtValidade_To", context.localUtil.Format(AV84ProdutoDtValidade_To, "99/99/99"));
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFPRODUTOID") == 0 )
            {
               AV56TFProdutoId = (short)(NumberUtil.Val( AV11GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56TFProdutoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV56TFProdutoId), 4, 0)));
               AV57TFProdutoId_To = (short)(NumberUtil.Val( AV11GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV57TFProdutoId_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV57TFProdutoId_To), 4, 0)));
               if ( ! (0==AV56TFProdutoId) )
               {
                  Ddo_produtoid_Filteredtext_set = StringUtil.Str( (decimal)(AV56TFProdutoId), 4, 0);
                  ucDdo_produtoid.SendProperty(context, "", false, Ddo_produtoid_Internalname, "FilteredText_set", Ddo_produtoid_Filteredtext_set);
               }
               if ( ! (0==AV57TFProdutoId_To) )
               {
                  Ddo_produtoid_Filteredtextto_set = StringUtil.Str( (decimal)(AV57TFProdutoId_To), 4, 0);
                  ucDdo_produtoid.SendProperty(context, "", false, Ddo_produtoid_Internalname, "FilteredTextTo_set", Ddo_produtoid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFPRODUTONOME") == 0 )
            {
               AV60TFProdutoNome = AV11GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60TFProdutoNome", AV60TFProdutoNome);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV60TFProdutoNome)) )
               {
                  Ddo_produtonome_Filteredtext_set = AV60TFProdutoNome;
                  ucDdo_produtonome.SendProperty(context, "", false, Ddo_produtonome_Internalname, "FilteredText_set", Ddo_produtonome_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFPRODUTONOME_SEL") == 0 )
            {
               AV61TFProdutoNome_Sel = AV11GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV61TFProdutoNome_Sel", AV61TFProdutoNome_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV61TFProdutoNome_Sel)) )
               {
                  Ddo_produtonome_Selectedvalue_set = AV61TFProdutoNome_Sel;
                  ucDdo_produtonome.SendProperty(context, "", false, Ddo_produtonome_Internalname, "SelectedValue_set", Ddo_produtonome_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFPRODUTOVALOR") == 0 )
            {
               AV68TFProdutoValor = NumberUtil.Val( AV11GridStateFilterValue.gxTpr_Value, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV68TFProdutoValor", StringUtil.LTrim( StringUtil.Str( AV68TFProdutoValor, 12, 2)));
               AV69TFProdutoValor_To = NumberUtil.Val( AV11GridStateFilterValue.gxTpr_Valueto, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV69TFProdutoValor_To", StringUtil.LTrim( StringUtil.Str( AV69TFProdutoValor_To, 12, 2)));
               if ( ! (Convert.ToDecimal(0)==AV68TFProdutoValor) )
               {
                  Ddo_produtovalor_Filteredtext_set = StringUtil.Str( AV68TFProdutoValor, 12, 2);
                  ucDdo_produtovalor.SendProperty(context, "", false, Ddo_produtovalor_Internalname, "FilteredText_set", Ddo_produtovalor_Filteredtext_set);
               }
               if ( ! (Convert.ToDecimal(0)==AV69TFProdutoValor_To) )
               {
                  Ddo_produtovalor_Filteredtextto_set = StringUtil.Str( AV69TFProdutoValor_To, 12, 2);
                  ucDdo_produtovalor.SendProperty(context, "", false, Ddo_produtovalor_Internalname, "FilteredTextTo_set", Ddo_produtovalor_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFPRODUTODTVALIDADE") == 0 )
            {
               AV72TFProdutoDtValidade = context.localUtil.CToD( AV11GridStateFilterValue.gxTpr_Value, 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV72TFProdutoDtValidade", context.localUtil.Format(AV72TFProdutoDtValidade, "99/99/99"));
               AV73TFProdutoDtValidade_To = context.localUtil.CToD( AV11GridStateFilterValue.gxTpr_Valueto, 2);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV73TFProdutoDtValidade_To", context.localUtil.Format(AV73TFProdutoDtValidade_To, "99/99/99"));
               if ( ! (DateTime.MinValue==AV72TFProdutoDtValidade) )
               {
                  Ddo_produtodtvalidade_Filteredtext_set = context.localUtil.DToC( AV72TFProdutoDtValidade, 2, "/");
                  ucDdo_produtodtvalidade.SendProperty(context, "", false, Ddo_produtodtvalidade_Internalname, "FilteredText_set", Ddo_produtodtvalidade_Filteredtext_set);
               }
               if ( ! (DateTime.MinValue==AV73TFProdutoDtValidade_To) )
               {
                  Ddo_produtodtvalidade_Filteredtextto_set = context.localUtil.DToC( AV73TFProdutoDtValidade_To, 2, "/");
                  ucDdo_produtodtvalidade.SendProperty(context, "", false, Ddo_produtodtvalidade_Internalname, "FilteredTextTo_set", Ddo_produtodtvalidade_Filteredtextto_set);
               }
            }
            AV110GXV2 = (int)(AV110GXV2+1);
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
            if ( StringUtil.StrCmp(AV16DynamicFiltersSelector1, "PRODUTONOME") == 0 )
            {
               AV17DynamicFiltersOperator1 = AV12GridStateDynamicFilter.gxTpr_Operator;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17DynamicFiltersOperator1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17DynamicFiltersOperator1), 4, 0)));
               AV18ProdutoNome1 = AV12GridStateDynamicFilter.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ProdutoNome1", AV18ProdutoNome1);
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
               AV19DynamicFiltersEnabled2 = true;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19DynamicFiltersEnabled2", AV19DynamicFiltersEnabled2);
               AV12GridStateDynamicFilter = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter)AV10GridState.gxTpr_Dynamicfilters.Item(2));
               AV20DynamicFiltersSelector2 = AV12GridStateDynamicFilter.gxTpr_Selected;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20DynamicFiltersSelector2", AV20DynamicFiltersSelector2);
               if ( StringUtil.StrCmp(AV20DynamicFiltersSelector2, "PRODUTONOME") == 0 )
               {
                  AV21DynamicFiltersOperator2 = AV12GridStateDynamicFilter.gxTpr_Operator;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21DynamicFiltersOperator2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21DynamicFiltersOperator2), 4, 0)));
                  AV22ProdutoNome2 = AV12GridStateDynamicFilter.gxTpr_Value;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ProdutoNome2", AV22ProdutoNome2);
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
                  AV23DynamicFiltersEnabled3 = true;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23DynamicFiltersEnabled3", AV23DynamicFiltersEnabled3);
                  AV12GridStateDynamicFilter = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter)AV10GridState.gxTpr_Dynamicfilters.Item(3));
                  AV24DynamicFiltersSelector3 = AV12GridStateDynamicFilter.gxTpr_Selected;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24DynamicFiltersSelector3", AV24DynamicFiltersSelector3);
                  if ( StringUtil.StrCmp(AV24DynamicFiltersSelector3, "PRODUTONOME") == 0 )
                  {
                     AV25DynamicFiltersOperator3 = AV12GridStateDynamicFilter.gxTpr_Operator;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25DynamicFiltersOperator3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25DynamicFiltersOperator3), 4, 0)));
                     AV26ProdutoNome3 = AV12GridStateDynamicFilter.gxTpr_Value;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26ProdutoNome3", AV26ProdutoNome3);
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
         if ( AV27DynamicFiltersRemoving )
         {
            lblJsdynamicfilters_Caption = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblJsdynamicfilters_Internalname, "Caption", lblJsdynamicfilters_Caption, true);
         }
      }

      protected void S182( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV10GridState.FromXml(AV48Session.Get(AV108Pgmname+"GridState"), null, "WWPGridState", "FMX");
         AV10GridState.gxTpr_Orderedby = AV13OrderedBy;
         AV10GridState.gxTpr_Ordereddsc = AV14OrderedDsc;
         AV10GridState.gxTpr_Filtervalues.Clear();
         if ( ! ( (DateTime.MinValue==AV83ProdutoDtValidade) && (DateTime.MinValue==AV84ProdutoDtValidade_To) ) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "PRODUTODTVALIDADE";
            AV11GridStateFilterValue.gxTpr_Value = context.localUtil.DToC( AV83ProdutoDtValidade, 2, "/");
            AV11GridStateFilterValue.gxTpr_Valueto = context.localUtil.DToC( AV84ProdutoDtValidade_To, 2, "/");
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! ( (0==AV56TFProdutoId) && (0==AV57TFProdutoId_To) ) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFPRODUTOID";
            AV11GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV56TFProdutoId), 4, 0);
            AV11GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV57TFProdutoId_To), 4, 0);
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV60TFProdutoNome)) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFPRODUTONOME";
            AV11GridStateFilterValue.gxTpr_Value = AV60TFProdutoNome;
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV61TFProdutoNome_Sel)) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFPRODUTONOME_SEL";
            AV11GridStateFilterValue.gxTpr_Value = AV61TFProdutoNome_Sel;
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! ( (Convert.ToDecimal(0)==AV68TFProdutoValor) && (Convert.ToDecimal(0)==AV69TFProdutoValor_To) ) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFPRODUTOVALOR";
            AV11GridStateFilterValue.gxTpr_Value = StringUtil.Str( AV68TFProdutoValor, 12, 2);
            AV11GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( AV69TFProdutoValor_To, 12, 2);
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! ( (DateTime.MinValue==AV72TFProdutoDtValidade) && (DateTime.MinValue==AV73TFProdutoDtValidade_To) ) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFPRODUTODTVALIDADE";
            AV11GridStateFilterValue.gxTpr_Value = context.localUtil.DToC( AV72TFProdutoDtValidade, 2, "/");
            AV11GridStateFilterValue.gxTpr_Valueto = context.localUtil.DToC( AV73TFProdutoDtValidade_To, 2, "/");
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
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV108Pgmname+"GridState",  AV10GridState.ToXml(false, true, "WWPGridState", "FMX")) ;
      }

      protected void S212( )
      {
         /* 'SAVEDYNFILTERSSTATE' Routine */
         AV10GridState.gxTpr_Dynamicfilters.Clear();
         if ( ! AV28DynamicFiltersIgnoreFirst )
         {
            AV12GridStateDynamicFilter = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter(context);
            AV12GridStateDynamicFilter.gxTpr_Selected = AV16DynamicFiltersSelector1;
            if ( ( StringUtil.StrCmp(AV16DynamicFiltersSelector1, "PRODUTONOME") == 0 ) && ! String.IsNullOrEmpty(StringUtil.RTrim( AV18ProdutoNome1)) )
            {
               AV12GridStateDynamicFilter.gxTpr_Value = AV18ProdutoNome1;
               AV12GridStateDynamicFilter.gxTpr_Operator = AV17DynamicFiltersOperator1;
            }
            if ( AV27DynamicFiltersRemoving || ! String.IsNullOrEmpty(StringUtil.RTrim( AV12GridStateDynamicFilter.gxTpr_Value)) )
            {
               AV10GridState.gxTpr_Dynamicfilters.Add(AV12GridStateDynamicFilter, 0);
            }
         }
         if ( AV19DynamicFiltersEnabled2 )
         {
            AV12GridStateDynamicFilter = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter(context);
            AV12GridStateDynamicFilter.gxTpr_Selected = AV20DynamicFiltersSelector2;
            if ( ( StringUtil.StrCmp(AV20DynamicFiltersSelector2, "PRODUTONOME") == 0 ) && ! String.IsNullOrEmpty(StringUtil.RTrim( AV22ProdutoNome2)) )
            {
               AV12GridStateDynamicFilter.gxTpr_Value = AV22ProdutoNome2;
               AV12GridStateDynamicFilter.gxTpr_Operator = AV21DynamicFiltersOperator2;
            }
            if ( AV27DynamicFiltersRemoving || ! String.IsNullOrEmpty(StringUtil.RTrim( AV12GridStateDynamicFilter.gxTpr_Value)) )
            {
               AV10GridState.gxTpr_Dynamicfilters.Add(AV12GridStateDynamicFilter, 0);
            }
         }
         if ( AV23DynamicFiltersEnabled3 )
         {
            AV12GridStateDynamicFilter = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter(context);
            AV12GridStateDynamicFilter.gxTpr_Selected = AV24DynamicFiltersSelector3;
            if ( ( StringUtil.StrCmp(AV24DynamicFiltersSelector3, "PRODUTONOME") == 0 ) && ! String.IsNullOrEmpty(StringUtil.RTrim( AV26ProdutoNome3)) )
            {
               AV12GridStateDynamicFilter.gxTpr_Value = AV26ProdutoNome3;
               AV12GridStateDynamicFilter.gxTpr_Operator = AV25DynamicFiltersOperator3;
            }
            if ( AV27DynamicFiltersRemoving || ! String.IsNullOrEmpty(StringUtil.RTrim( AV12GridStateDynamicFilter.gxTpr_Value)) )
            {
               AV10GridState.gxTpr_Dynamicfilters.Add(AV12GridStateDynamicFilter, 0);
            }
         }
      }

      protected void S152( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV8TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV8TrnContext.gxTpr_Callerobject = AV108Pgmname;
         AV8TrnContext.gxTpr_Callerondelete = true;
         AV8TrnContext.gxTpr_Callerurl = AV7HTTPRequest.ScriptName+"?"+AV7HTTPRequest.QueryString;
         AV8TrnContext.gxTpr_Transactionname = "Produto";
         AV48Session.Set("TrnContext", AV8TrnContext.ToXml(false, true, "WWPTransactionContext", "FMX"));
      }

      protected void wb_table1_23_0R2( bool wbgen )
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
            ucDdo_managefilters.SetProperty("DropDownOptionsData", AV53ManageFiltersData);
            ucDdo_managefilters.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_managefilters_Internalname, "DDO_MANAGEFILTERSContainer");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_28_0R2( true) ;
         }
         else
         {
            wb_table2_28_0R2( false) ;
         }
         return  ;
      }

      protected void wb_table2_28_0R2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_23_0R2e( true) ;
         }
         else
         {
            wb_table1_23_0R2e( false) ;
         }
      }

      protected void wb_table2_28_0R2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablefilters_Internalname, tblTablefilters_Internalname, "", "", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table3_31_0R2( true) ;
         }
         else
         {
            wb_table3_31_0R2( false) ;
         }
         return  ;
      }

      protected void wb_table3_31_0R2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedfiltertextprodutodtvalidade_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblFiltertextprodutodtvalidade_Internalname, "Data de Validade", "", "", lblFiltertextprodutodtvalidade_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescription", 0, "", 1, 1, 0, "HLP_ProdutoWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table4_109_0R2( true) ;
         }
         else
         {
            wb_table4_109_0R2( false) ;
         }
         return  ;
      }

      protected void wb_table4_109_0R2e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_28_0R2e( true) ;
         }
         else
         {
            wb_table2_28_0R2e( false) ;
         }
      }

      protected void wb_table4_109_0R2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedprodutodtvalidade_Internalname, tblTablemergedprodutodtvalidade_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavProdutodtvalidade_Internalname, "Produto Dt Validade", "col-sm-3 AttributeDateLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 113,'',false,'" + sGXsfl_127_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavProdutodtvalidade_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavProdutodtvalidade_Internalname, context.localUtil.Format(AV83ProdutoDtValidade, "99/99/99"), context.localUtil.Format( AV83ProdutoDtValidade, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,113);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavProdutodtvalidade_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavProdutodtvalidade_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ProdutoWW.htm");
            GxWebStd.gx_bitmap( context, edtavProdutodtvalidade_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavProdutodtvalidade_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_ProdutoWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblProdutodtvalidade_rangemiddletext_Internalname, "até", "", "", lblProdutodtvalidade_rangemiddletext_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescription", 0, "", 1, 1, 0, "HLP_ProdutoWW.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavProdutodtvalidade_to_Internalname, "Produto Dt Validade_To", "col-sm-3 AttributeDateLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 118,'',false,'" + sGXsfl_127_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavProdutodtvalidade_to_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavProdutodtvalidade_to_Internalname, context.localUtil.Format(AV84ProdutoDtValidade_To, "99/99/99"), context.localUtil.Format( AV84ProdutoDtValidade_To, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'por',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,118);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavProdutodtvalidade_to_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavProdutodtvalidade_to_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ProdutoWW.htm");
            GxWebStd.gx_bitmap( context, edtavProdutodtvalidade_to_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavProdutodtvalidade_to_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_ProdutoWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_109_0R2e( true) ;
         }
         else
         {
            wb_table4_109_0R2e( false) ;
         }
      }

      protected void wb_table3_31_0R2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTabledynamicfilters_Internalname, tblTabledynamicfilters_Internalname, "", "TableDynamicFilters", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersprefix1_Internalname, "Filtrar por", "", "", lblDynamicfiltersprefix1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescriptionPrefix", 0, "", 1, 1, 0, "HLP_ProdutoWW.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavDynamicfiltersselector1_Internalname, "Dynamic Filters Selector1", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'" + sGXsfl_127_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersselector1, cmbavDynamicfiltersselector1_Internalname, StringUtil.RTrim( AV16DynamicFiltersSelector1), 1, cmbavDynamicfiltersselector1_Jsonclick, 5, "'"+""+"'"+",false,"+"'"+"EVDYNAMICFILTERSSELECTOR1.CLICK."+"'", "svchar", "", 1, cmbavDynamicfiltersselector1.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,37);\"", "", true, "HLP_ProdutoWW.htm");
            cmbavDynamicfiltersselector1.CurrentValue = StringUtil.RTrim( AV16DynamicFiltersSelector1);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector1_Internalname, "Values", (String)(cmbavDynamicfiltersselector1.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersmiddle1_Internalname, "valor", "", "", lblDynamicfiltersmiddle1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescription", 0, "", 1, 1, 0, "HLP_ProdutoWW.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table5_41_0R2( true) ;
         }
         else
         {
            wb_table5_41_0R2( false) ;
         }
         return  ;
      }

      protected void wb_table5_41_0R2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table6_50_0R2( true) ;
         }
         else
         {
            wb_table6_50_0R2( false) ;
         }
         return  ;
      }

      protected void wb_table6_50_0R2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersprefix2_Internalname, "Filtrar por", "", "", lblDynamicfiltersprefix2_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescriptionPrefix", 0, "", 1, 1, 0, "HLP_ProdutoWW.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavDynamicfiltersselector2_Internalname, "Dynamic Filters Selector2", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'" + sGXsfl_127_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersselector2, cmbavDynamicfiltersselector2_Internalname, StringUtil.RTrim( AV20DynamicFiltersSelector2), 1, cmbavDynamicfiltersselector2_Jsonclick, 5, "'"+""+"'"+",false,"+"'"+"EVDYNAMICFILTERSSELECTOR2.CLICK."+"'", "svchar", "", 1, cmbavDynamicfiltersselector2.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,61);\"", "", true, "HLP_ProdutoWW.htm");
            cmbavDynamicfiltersselector2.CurrentValue = StringUtil.RTrim( AV20DynamicFiltersSelector2);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector2_Internalname, "Values", (String)(cmbavDynamicfiltersselector2.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersmiddle2_Internalname, "valor", "", "", lblDynamicfiltersmiddle2_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescription", 0, "", 1, 1, 0, "HLP_ProdutoWW.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            wb_table7_65_0R2( true) ;
         }
         else
         {
            wb_table7_65_0R2( false) ;
         }
         return  ;
      }

      protected void wb_table7_65_0R2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            wb_table8_74_0R2( true) ;
         }
         else
         {
            wb_table8_74_0R2( false) ;
         }
         return  ;
      }

      protected void wb_table8_74_0R2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersprefix3_Internalname, "Filtrar por", "", "", lblDynamicfiltersprefix3_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescriptionPrefix", 0, "", 1, 1, 0, "HLP_ProdutoWW.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavDynamicfiltersselector3_Internalname, "Dynamic Filters Selector3", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 85,'',false,'" + sGXsfl_127_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersselector3, cmbavDynamicfiltersselector3_Internalname, StringUtil.RTrim( AV24DynamicFiltersSelector3), 1, cmbavDynamicfiltersselector3_Jsonclick, 5, "'"+""+"'"+",false,"+"'"+"EVDYNAMICFILTERSSELECTOR3.CLICK."+"'", "svchar", "", 1, cmbavDynamicfiltersselector3.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,85);\"", "", true, "HLP_ProdutoWW.htm");
            cmbavDynamicfiltersselector3.CurrentValue = StringUtil.RTrim( AV24DynamicFiltersSelector3);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector3_Internalname, "Values", (String)(cmbavDynamicfiltersselector3.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersmiddle3_Internalname, "valor", "", "", lblDynamicfiltersmiddle3_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescription", 0, "", 1, 1, 0, "HLP_ProdutoWW.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            wb_table9_89_0R2( true) ;
         }
         else
         {
            wb_table9_89_0R2( false) ;
         }
         return  ;
      }

      protected void wb_table9_89_0R2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            wb_table10_98_0R2( true) ;
         }
         else
         {
            wb_table10_98_0R2( false) ;
         }
         return  ;
      }

      protected void wb_table10_98_0R2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_31_0R2e( true) ;
         }
         else
         {
            wb_table3_31_0R2e( false) ;
         }
      }

      protected void wb_table10_98_0R2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblUnnamedtabledynamicfilters_3_Internalname, tblUnnamedtabledynamicfilters_3_Internalname, "", "Table", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\""+cellDynamicfilters_removefilter3_cell_Internalname+"\"  class=''>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 101,'',false,'',0)\"";
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "11a6ef14-1a5a-4077-91a2-f41ed9a3a662", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgRemovedynamicfilters3_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "Remover filtro", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgRemovedynamicfilters3_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'REMOVEDYNAMICFILTERS3\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_ProdutoWW.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table10_98_0R2e( true) ;
         }
         else
         {
            wb_table10_98_0R2e( false) ;
         }
      }

      protected void wb_table9_89_0R2( bool wbgen )
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 93,'',false,'" + sGXsfl_127_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersoperator3, cmbavDynamicfiltersoperator3_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV25DynamicFiltersOperator3), 4, 0)), 1, cmbavDynamicfiltersoperator3_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", cmbavDynamicfiltersoperator3.Visible, cmbavDynamicfiltersoperator3.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,93);\"", "", true, "HLP_ProdutoWW.htm");
            cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV25DynamicFiltersOperator3), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", (String)(cmbavDynamicfiltersoperator3.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellFilter_produtonome3_cell_Internalname+"\"  class=''>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavProdutonome3_Internalname, "Produto Nome3", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 96,'',false,'" + sGXsfl_127_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavProdutonome3_Internalname, AV26ProdutoNome3, StringUtil.RTrim( context.localUtil.Format( AV26ProdutoNome3, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,96);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavProdutonome3_Jsonclick, 0, "Attribute", "", "", "", "", edtavProdutonome3_Visible, edtavProdutonome3_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_ProdutoWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table9_89_0R2e( true) ;
         }
         else
         {
            wb_table9_89_0R2e( false) ;
         }
      }

      protected void wb_table8_74_0R2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblUnnamedtabledynamicfilters_2_Internalname, tblUnnamedtabledynamicfilters_2_Internalname, "", "Table", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\""+cellDynamicfilters_addfilter2_cell_Internalname+"\"  class=''>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'',0)\"";
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "27283ea5-332f-423b-b880-64b762622df3", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgAdddynamicfilters2_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgAdddynamicfilters2_Visible, 1, "", "Adicionar filtro", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgAdddynamicfilters2_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'ADDDYNAMICFILTERS2\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_ProdutoWW.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellDynamicfilters_removefilter2_cell_Internalname+"\"  class=''>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 79,'',false,'',0)\"";
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "11a6ef14-1a5a-4077-91a2-f41ed9a3a662", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgRemovedynamicfilters2_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgRemovedynamicfilters2_Visible, 1, "", "Remover filtro", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgRemovedynamicfilters2_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'REMOVEDYNAMICFILTERS2\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_ProdutoWW.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table8_74_0R2e( true) ;
         }
         else
         {
            wb_table8_74_0R2e( false) ;
         }
      }

      protected void wb_table7_65_0R2( bool wbgen )
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'" + sGXsfl_127_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersoperator2, cmbavDynamicfiltersoperator2_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV21DynamicFiltersOperator2), 4, 0)), 1, cmbavDynamicfiltersoperator2_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", cmbavDynamicfiltersoperator2.Visible, cmbavDynamicfiltersoperator2.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,69);\"", "", true, "HLP_ProdutoWW.htm");
            cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV21DynamicFiltersOperator2), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", (String)(cmbavDynamicfiltersoperator2.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellFilter_produtonome2_cell_Internalname+"\"  class=''>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavProdutonome2_Internalname, "Produto Nome2", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'" + sGXsfl_127_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavProdutonome2_Internalname, AV22ProdutoNome2, StringUtil.RTrim( context.localUtil.Format( AV22ProdutoNome2, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,72);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavProdutonome2_Jsonclick, 0, "Attribute", "", "", "", "", edtavProdutonome2_Visible, edtavProdutonome2_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_ProdutoWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table7_65_0R2e( true) ;
         }
         else
         {
            wb_table7_65_0R2e( false) ;
         }
      }

      protected void wb_table6_50_0R2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblUnnamedtabledynamicfilters_1_Internalname, tblUnnamedtabledynamicfilters_1_Internalname, "", "Table", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\""+cellDynamicfilters_addfilter1_cell_Internalname+"\"  class=''>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"";
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "27283ea5-332f-423b-b880-64b762622df3", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgAdddynamicfilters1_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgAdddynamicfilters1_Visible, 1, "", "Adicionar filtro", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgAdddynamicfilters1_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'ADDDYNAMICFILTERS1\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_ProdutoWW.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellDynamicfilters_removefilter1_cell_Internalname+"\"  class=''>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'',0)\"";
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "11a6ef14-1a5a-4077-91a2-f41ed9a3a662", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgRemovedynamicfilters1_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgRemovedynamicfilters1_Visible, 1, "", "Remover filtro", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgRemovedynamicfilters1_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'REMOVEDYNAMICFILTERS1\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_ProdutoWW.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table6_50_0R2e( true) ;
         }
         else
         {
            wb_table6_50_0R2e( false) ;
         }
      }

      protected void wb_table5_41_0R2( bool wbgen )
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'" + sGXsfl_127_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersoperator1, cmbavDynamicfiltersoperator1_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV17DynamicFiltersOperator1), 4, 0)), 1, cmbavDynamicfiltersoperator1_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", cmbavDynamicfiltersoperator1.Visible, cmbavDynamicfiltersoperator1.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,45);\"", "", true, "HLP_ProdutoWW.htm");
            cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV17DynamicFiltersOperator1), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", (String)(cmbavDynamicfiltersoperator1.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellFilter_produtonome1_cell_Internalname+"\"  class=''>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavProdutonome1_Internalname, "Produto Nome1", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'" + sGXsfl_127_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavProdutonome1_Internalname, AV18ProdutoNome1, StringUtil.RTrim( context.localUtil.Format( AV18ProdutoNome1, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,48);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavProdutonome1_Jsonclick, 0, "Attribute", "", "", "", "", edtavProdutonome1_Visible, edtavProdutonome1_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_ProdutoWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_41_0R2e( true) ;
         }
         else
         {
            wb_table5_41_0R2e( false) ;
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
         PA0R2( ) ;
         WS0R2( ) ;
         WE0R2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20197121801576", true, true);
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
         context.AddJavascriptSource("produtoww.js", "?20197121801576", false, true);
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
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false, true);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_1272( )
      {
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_127_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_127_idx;
         edtProdutoId_Internalname = "PRODUTOID_"+sGXsfl_127_idx;
         edtProdutoNome_Internalname = "PRODUTONOME_"+sGXsfl_127_idx;
         edtProdutoDescricao_Internalname = "PRODUTODESCRICAO_"+sGXsfl_127_idx;
         edtProdutoValor_Internalname = "PRODUTOVALOR_"+sGXsfl_127_idx;
         edtProdutoDtValidade_Internalname = "PRODUTODTVALIDADE_"+sGXsfl_127_idx;
      }

      protected void SubsflControlProps_fel_1272( )
      {
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_127_fel_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_127_fel_idx;
         edtProdutoId_Internalname = "PRODUTOID_"+sGXsfl_127_fel_idx;
         edtProdutoNome_Internalname = "PRODUTONOME_"+sGXsfl_127_fel_idx;
         edtProdutoDescricao_Internalname = "PRODUTODESCRICAO_"+sGXsfl_127_fel_idx;
         edtProdutoValor_Internalname = "PRODUTOVALOR_"+sGXsfl_127_fel_idx;
         edtProdutoDtValidade_Internalname = "PRODUTODTVALIDADE_"+sGXsfl_127_fel_idx;
      }

      protected void sendrow_1272( )
      {
         SubsflControlProps_1272( ) ;
         WB0R0( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_127_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_127_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_127_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,StringUtil.RTrim( AV81Update),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtavUpdate_Link,(String)"",(String)"Modifica",(String)"",(String)edtavUpdate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWIconActionColumn",(String)"",(short)-1,(int)edtavUpdate_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)1,(short)127,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,StringUtil.RTrim( AV82Delete),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtavDelete_Link,(String)"",(String)"Eliminar",(String)"",(String)edtavDelete_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWIconActionColumn",(String)"",(short)-1,(int)edtavDelete_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)1,(short)127,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((edtProdutoId_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtProdutoId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A8ProdutoId), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A8ProdutoId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtProdutoId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(int)edtProdutoId_Visible,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)127,(short)1,(short)-1,(short)0,(bool)true,(String)"Serial",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((edtProdutoNome_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtProdutoNome_Internalname,(String)A9ProdutoNome,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtProdutoNome_Link,(String)"",(String)"",(String)"",(String)edtProdutoNome_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(int)edtProdutoNome_Visible,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)127,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtProdutoDescricao_Internalname,(String)A10ProdutoDescricao,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtProdutoDescricao_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)500,(short)0,(short)0,(short)127,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((edtProdutoValor_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtProdutoValor_Internalname,StringUtil.LTrim( StringUtil.NToC( A11ProdutoValor, 12, 2, ",", "")),context.localUtil.Format( A11ProdutoValor, "R$ ZZ,ZZ9.99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtProdutoValor_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(int)edtProdutoValor_Visible,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)12,(short)0,(short)0,(short)127,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((edtProdutoDtValidade_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtProdutoDtValidade_Internalname,context.localUtil.Format(A12ProdutoDtValidade, "99/99/99"),context.localUtil.Format( A12ProdutoDtValidade, "99/99/99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtProdutoDtValidade_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(int)edtProdutoDtValidade_Visible,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)127,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            send_integrity_lvl_hashes0R2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_127_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_127_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_127_idx+1));
            sGXsfl_127_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_127_idx), 4, 0)), 4, "0");
            SubsflControlProps_1272( ) ;
         }
         /* End function sendrow_1272 */
      }

      protected void init_web_controls( )
      {
         cmbavDynamicfiltersselector1.Name = "vDYNAMICFILTERSSELECTOR1";
         cmbavDynamicfiltersselector1.WebTags = "";
         cmbavDynamicfiltersselector1.addItem("PRODUTONOME", "Nome", 0);
         if ( cmbavDynamicfiltersselector1.ItemCount > 0 )
         {
            AV16DynamicFiltersSelector1 = cmbavDynamicfiltersselector1.getValidValue(AV16DynamicFiltersSelector1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16DynamicFiltersSelector1", AV16DynamicFiltersSelector1);
         }
         cmbavDynamicfiltersoperator1.Name = "vDYNAMICFILTERSOPERATOR1";
         cmbavDynamicfiltersoperator1.WebTags = "";
         cmbavDynamicfiltersoperator1.addItem("0", "Começa com", 0);
         cmbavDynamicfiltersoperator1.addItem("1", "Contém", 0);
         if ( cmbavDynamicfiltersoperator1.ItemCount > 0 )
         {
            AV17DynamicFiltersOperator1 = (short)(NumberUtil.Val( cmbavDynamicfiltersoperator1.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV17DynamicFiltersOperator1), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17DynamicFiltersOperator1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17DynamicFiltersOperator1), 4, 0)));
         }
         cmbavDynamicfiltersselector2.Name = "vDYNAMICFILTERSSELECTOR2";
         cmbavDynamicfiltersselector2.WebTags = "";
         cmbavDynamicfiltersselector2.addItem("PRODUTONOME", "Nome", 0);
         if ( cmbavDynamicfiltersselector2.ItemCount > 0 )
         {
            AV20DynamicFiltersSelector2 = cmbavDynamicfiltersselector2.getValidValue(AV20DynamicFiltersSelector2);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20DynamicFiltersSelector2", AV20DynamicFiltersSelector2);
         }
         cmbavDynamicfiltersoperator2.Name = "vDYNAMICFILTERSOPERATOR2";
         cmbavDynamicfiltersoperator2.WebTags = "";
         cmbavDynamicfiltersoperator2.addItem("0", "Começa com", 0);
         cmbavDynamicfiltersoperator2.addItem("1", "Contém", 0);
         if ( cmbavDynamicfiltersoperator2.ItemCount > 0 )
         {
            AV21DynamicFiltersOperator2 = (short)(NumberUtil.Val( cmbavDynamicfiltersoperator2.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV21DynamicFiltersOperator2), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21DynamicFiltersOperator2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21DynamicFiltersOperator2), 4, 0)));
         }
         cmbavDynamicfiltersselector3.Name = "vDYNAMICFILTERSSELECTOR3";
         cmbavDynamicfiltersselector3.WebTags = "";
         cmbavDynamicfiltersselector3.addItem("PRODUTONOME", "Nome", 0);
         if ( cmbavDynamicfiltersselector3.ItemCount > 0 )
         {
            AV24DynamicFiltersSelector3 = cmbavDynamicfiltersselector3.getValidValue(AV24DynamicFiltersSelector3);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24DynamicFiltersSelector3", AV24DynamicFiltersSelector3);
         }
         cmbavDynamicfiltersoperator3.Name = "vDYNAMICFILTERSOPERATOR3";
         cmbavDynamicfiltersoperator3.WebTags = "";
         cmbavDynamicfiltersoperator3.addItem("0", "Começa com", 0);
         cmbavDynamicfiltersoperator3.addItem("1", "Contém", 0);
         if ( cmbavDynamicfiltersoperator3.ItemCount > 0 )
         {
            AV25DynamicFiltersOperator3 = (short)(NumberUtil.Val( cmbavDynamicfiltersoperator3.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV25DynamicFiltersOperator3), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25DynamicFiltersOperator3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25DynamicFiltersOperator3), 4, 0)));
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
         bttBtninsert_Internalname = "BTNINSERT";
         bttBtneditcolumns_Internalname = "BTNEDITCOLUMNS";
         divTableactions_Internalname = "TABLEACTIONS";
         Ddo_managefilters_Internalname = "DDO_MANAGEFILTERS";
         lblDynamicfiltersprefix1_Internalname = "DYNAMICFILTERSPREFIX1";
         cmbavDynamicfiltersselector1_Internalname = "vDYNAMICFILTERSSELECTOR1";
         lblDynamicfiltersmiddle1_Internalname = "DYNAMICFILTERSMIDDLE1";
         cmbavDynamicfiltersoperator1_Internalname = "vDYNAMICFILTERSOPERATOR1";
         edtavProdutonome1_Internalname = "vPRODUTONOME1";
         cellFilter_produtonome1_cell_Internalname = "FILTER_PRODUTONOME1_CELL";
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
         edtavProdutonome2_Internalname = "vPRODUTONOME2";
         cellFilter_produtonome2_cell_Internalname = "FILTER_PRODUTONOME2_CELL";
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
         edtavProdutonome3_Internalname = "vPRODUTONOME3";
         cellFilter_produtonome3_cell_Internalname = "FILTER_PRODUTONOME3_CELL";
         tblTablemergeddynamicfilters3_Internalname = "TABLEMERGEDDYNAMICFILTERS3";
         imgRemovedynamicfilters3_Internalname = "REMOVEDYNAMICFILTERS3";
         cellDynamicfilters_removefilter3_cell_Internalname = "DYNAMICFILTERS_REMOVEFILTER3_CELL";
         tblUnnamedtabledynamicfilters_3_Internalname = "UNNAMEDTABLEDYNAMICFILTERS_3";
         tblTabledynamicfilters_Internalname = "TABLEDYNAMICFILTERS";
         lblFiltertextprodutodtvalidade_Internalname = "FILTERTEXTPRODUTODTVALIDADE";
         edtavProdutodtvalidade_Internalname = "vPRODUTODTVALIDADE";
         lblProdutodtvalidade_rangemiddletext_Internalname = "PRODUTODTVALIDADE_RANGEMIDDLETEXT";
         edtavProdutodtvalidade_to_Internalname = "vPRODUTODTVALIDADE_TO";
         tblTablemergedprodutodtvalidade_Internalname = "TABLEMERGEDPRODUTODTVALIDADE";
         divTablesplittedfiltertextprodutodtvalidade_Internalname = "TABLESPLITTEDFILTERTEXTPRODUTODTVALIDADE";
         tblTablefilters_Internalname = "TABLEFILTERS";
         tblTablerightheader_Internalname = "TABLERIGHTHEADER";
         divTableheader_Internalname = "TABLEHEADER";
         Dvpanel_tableheader_Internalname = "DVPANEL_TABLEHEADER";
         edtavUpdate_Internalname = "vUPDATE";
         edtavDelete_Internalname = "vDELETE";
         edtProdutoId_Internalname = "PRODUTOID";
         edtProdutoNome_Internalname = "PRODUTONOME";
         edtProdutoDescricao_Internalname = "PRODUTODESCRICAO";
         edtProdutoValor_Internalname = "PRODUTOVALOR";
         edtProdutoDtValidade_Internalname = "PRODUTODTVALIDADE";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         lblJsdynamicfilters_Internalname = "JSDYNAMICFILTERS";
         Ddo_produtoid_Internalname = "DDO_PRODUTOID";
         edtavDdo_produtoidtitlecontrolidtoreplace_Internalname = "vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE";
         Ddo_produtonome_Internalname = "DDO_PRODUTONOME";
         edtavDdo_produtonometitlecontrolidtoreplace_Internalname = "vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE";
         Ddo_produtovalor_Internalname = "DDO_PRODUTOVALOR";
         edtavDdo_produtovalortitlecontrolidtoreplace_Internalname = "vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE";
         Ddo_produtodtvalidade_Internalname = "DDO_PRODUTODTVALIDADE";
         edtavDdo_produtodtvalidadetitlecontrolidtoreplace_Internalname = "vDDO_PRODUTODTVALIDADETITLECONTROLIDTOREPLACE";
         Workwithplusutilities1_Internalname = "WORKWITHPLUSUTILITIES1";
         Ddo_gridcolumnsselector_Internalname = "DDO_GRIDCOLUMNSSELECTOR";
         chkavDynamicfiltersenabled2_Internalname = "vDYNAMICFILTERSENABLED2";
         chkavDynamicfiltersenabled3_Internalname = "vDYNAMICFILTERSENABLED3";
         edtavOrderedby_Internalname = "vORDEREDBY";
         edtavOrdereddsc_Internalname = "vORDEREDDSC";
         edtavManagefiltersexecutionstep_Internalname = "vMANAGEFILTERSEXECUTIONSTEP";
         edtavTfprodutoid_Internalname = "vTFPRODUTOID";
         edtavTfprodutoid_to_Internalname = "vTFPRODUTOID_TO";
         edtavTfprodutonome_Internalname = "vTFPRODUTONOME";
         edtavTfprodutonome_sel_Internalname = "vTFPRODUTONOME_SEL";
         edtavTfprodutovalor_Internalname = "vTFPRODUTOVALOR";
         edtavTfprodutovalor_to_Internalname = "vTFPRODUTOVALOR_TO";
         edtavTfprodutodtvalidade_Internalname = "vTFPRODUTODTVALIDADE";
         edtavTfprodutodtvalidade_to_Internalname = "vTFPRODUTODTVALIDADE_TO";
         edtavDdo_produtodtvalidadeauxdate_Internalname = "vDDO_PRODUTODTVALIDADEAUXDATE";
         edtavDdo_produtodtvalidadeauxdateto_Internalname = "vDDO_PRODUTODTVALIDADEAUXDATETO";
         divDdo_produtodtvalidadeauxdates_Internalname = "DDO_PRODUTODTVALIDADEAUXDATES";
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
         edtProdutoDtValidade_Jsonclick = "";
         edtProdutoValor_Jsonclick = "";
         edtProdutoDescricao_Jsonclick = "";
         edtProdutoNome_Jsonclick = "";
         edtProdutoId_Jsonclick = "";
         edtavDelete_Jsonclick = "";
         edtavUpdate_Jsonclick = "";
         edtavProdutonome1_Jsonclick = "";
         edtavProdutonome1_Enabled = 1;
         cmbavDynamicfiltersoperator1_Jsonclick = "";
         cmbavDynamicfiltersoperator1.Enabled = 1;
         imgRemovedynamicfilters1_Visible = 1;
         imgAdddynamicfilters1_Visible = 1;
         edtavProdutonome2_Jsonclick = "";
         edtavProdutonome2_Enabled = 1;
         cmbavDynamicfiltersoperator2_Jsonclick = "";
         cmbavDynamicfiltersoperator2.Enabled = 1;
         imgRemovedynamicfilters2_Visible = 1;
         imgAdddynamicfilters2_Visible = 1;
         edtavProdutonome3_Jsonclick = "";
         edtavProdutonome3_Enabled = 1;
         cmbavDynamicfiltersoperator3_Jsonclick = "";
         cmbavDynamicfiltersoperator3.Enabled = 1;
         cmbavDynamicfiltersselector3_Jsonclick = "";
         cmbavDynamicfiltersselector3.Enabled = 1;
         cmbavDynamicfiltersselector2_Jsonclick = "";
         cmbavDynamicfiltersselector2.Enabled = 1;
         cmbavDynamicfiltersselector1_Jsonclick = "";
         cmbavDynamicfiltersselector1.Enabled = 1;
         edtavProdutodtvalidade_to_Jsonclick = "";
         edtavProdutodtvalidade_to_Enabled = 1;
         edtavProdutodtvalidade_Jsonclick = "";
         edtavProdutodtvalidade_Enabled = 1;
         cmbavDynamicfiltersoperator3.Visible = 1;
         edtavProdutonome3_Visible = 1;
         cmbavDynamicfiltersoperator2.Visible = 1;
         edtavProdutonome2_Visible = 1;
         cmbavDynamicfiltersoperator1.Visible = 1;
         edtavProdutonome1_Visible = 1;
         edtavDdo_produtodtvalidadeauxdateto_Jsonclick = "";
         edtavDdo_produtodtvalidadeauxdate_Jsonclick = "";
         edtavTfprodutodtvalidade_to_Jsonclick = "";
         edtavTfprodutodtvalidade_to_Visible = 1;
         edtavTfprodutodtvalidade_Jsonclick = "";
         edtavTfprodutodtvalidade_Visible = 1;
         edtavTfprodutovalor_to_Jsonclick = "";
         edtavTfprodutovalor_to_Visible = 1;
         edtavTfprodutovalor_Jsonclick = "";
         edtavTfprodutovalor_Visible = 1;
         edtavTfprodutonome_sel_Jsonclick = "";
         edtavTfprodutonome_sel_Visible = 1;
         edtavTfprodutonome_Jsonclick = "";
         edtavTfprodutonome_Visible = 1;
         edtavTfprodutoid_to_Jsonclick = "";
         edtavTfprodutoid_to_Visible = 1;
         edtavTfprodutoid_Jsonclick = "";
         edtavTfprodutoid_Visible = 1;
         edtavManagefiltersexecutionstep_Jsonclick = "";
         edtavManagefiltersexecutionstep_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         chkavDynamicfiltersenabled3.Visible = 1;
         chkavDynamicfiltersenabled2.Visible = 1;
         edtavDdo_produtodtvalidadetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_produtovalortitlecontrolidtoreplace_Visible = 1;
         edtavDdo_produtonometitlecontrolidtoreplace_Visible = 1;
         edtavDdo_produtoidtitlecontrolidtoreplace_Visible = 1;
         lblJsdynamicfilters_Caption = "JSDynamicFilters";
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtProdutoNome_Link = "";
         edtavDelete_Link = "";
         edtavUpdate_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtProdutoDtValidade_Titleformat = 0;
         edtProdutoDtValidade_Title = "Data de Validade";
         edtProdutoDtValidade_Visible = -1;
         edtProdutoValor_Titleformat = 0;
         edtProdutoValor_Title = "Valor";
         edtProdutoValor_Visible = -1;
         edtProdutoNome_Titleformat = 0;
         edtProdutoNome_Title = "Nome";
         edtProdutoNome_Visible = -1;
         edtProdutoId_Titleformat = 0;
         edtProdutoId_Title = "Id";
         edtProdutoId_Visible = -1;
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
         Ddo_produtodtvalidade_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_produtodtvalidade_Rangefilterto = "WWP_TSTo";
         Ddo_produtodtvalidade_Rangefilterfrom = "WWP_TSFrom";
         Ddo_produtodtvalidade_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_produtodtvalidade_Sortdsc = "WWP_TSSortDSC";
         Ddo_produtodtvalidade_Sortasc = "WWP_TSSortASC";
         Ddo_produtodtvalidade_Includedatalist = Convert.ToBoolean( 0);
         Ddo_produtodtvalidade_Filterisrange = Convert.ToBoolean( -1);
         Ddo_produtodtvalidade_Filtertype = "Date";
         Ddo_produtodtvalidade_Includefilter = Convert.ToBoolean( -1);
         Ddo_produtodtvalidade_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_produtodtvalidade_Includesortasc = Convert.ToBoolean( -1);
         Ddo_produtodtvalidade_Titlecontrolidtoreplace = "";
         Ddo_produtodtvalidade_Dropdownoptionstype = "GridTitleSettings";
         Ddo_produtodtvalidade_Cls = "ColumnSettings";
         Ddo_produtodtvalidade_Tooltip = "WWP_TSColumnOptions";
         Ddo_produtodtvalidade_Caption = "";
         Ddo_produtovalor_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_produtovalor_Rangefilterto = "WWP_TSTo";
         Ddo_produtovalor_Rangefilterfrom = "WWP_TSFrom";
         Ddo_produtovalor_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_produtovalor_Sortdsc = "WWP_TSSortDSC";
         Ddo_produtovalor_Sortasc = "WWP_TSSortASC";
         Ddo_produtovalor_Includedatalist = Convert.ToBoolean( 0);
         Ddo_produtovalor_Filterisrange = Convert.ToBoolean( -1);
         Ddo_produtovalor_Filtertype = "Numeric";
         Ddo_produtovalor_Includefilter = Convert.ToBoolean( -1);
         Ddo_produtovalor_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_produtovalor_Includesortasc = Convert.ToBoolean( -1);
         Ddo_produtovalor_Titlecontrolidtoreplace = "";
         Ddo_produtovalor_Dropdownoptionstype = "GridTitleSettings";
         Ddo_produtovalor_Cls = "ColumnSettings";
         Ddo_produtovalor_Tooltip = "WWP_TSColumnOptions";
         Ddo_produtovalor_Caption = "";
         Ddo_produtonome_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_produtonome_Noresultsfound = "WWP_TSNoResults";
         Ddo_produtonome_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_produtonome_Loadingdata = "WWP_TSLoading";
         Ddo_produtonome_Sortdsc = "WWP_TSSortDSC";
         Ddo_produtonome_Sortasc = "WWP_TSSortASC";
         Ddo_produtonome_Datalistupdateminimumcharacters = 0;
         Ddo_produtonome_Datalistproc = "ProdutoWWGetFilterData";
         Ddo_produtonome_Datalisttype = "Dynamic";
         Ddo_produtonome_Includedatalist = Convert.ToBoolean( -1);
         Ddo_produtonome_Filterisrange = Convert.ToBoolean( 0);
         Ddo_produtonome_Filtertype = "Character";
         Ddo_produtonome_Includefilter = Convert.ToBoolean( -1);
         Ddo_produtonome_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_produtonome_Includesortasc = Convert.ToBoolean( -1);
         Ddo_produtonome_Titlecontrolidtoreplace = "";
         Ddo_produtonome_Dropdownoptionstype = "GridTitleSettings";
         Ddo_produtonome_Cls = "ColumnSettings";
         Ddo_produtonome_Tooltip = "WWP_TSColumnOptions";
         Ddo_produtonome_Caption = "";
         Ddo_produtoid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_produtoid_Rangefilterto = "WWP_TSTo";
         Ddo_produtoid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_produtoid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_produtoid_Sortdsc = "WWP_TSSortDSC";
         Ddo_produtoid_Sortasc = "WWP_TSSortASC";
         Ddo_produtoid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_produtoid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_produtoid_Filtertype = "Numeric";
         Ddo_produtoid_Includefilter = Convert.ToBoolean( -1);
         Ddo_produtoid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_produtoid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_produtoid_Titlecontrolidtoreplace = "";
         Ddo_produtoid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_produtoid_Cls = "ColumnSettings";
         Ddo_produtoid_Tooltip = "WWP_TSColumnOptions";
         Ddo_produtoid_Caption = "";
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
         Form.Caption = " Produto";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV49ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV41ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV58ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV62ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76ddo_ProdutoDtValidadeTitleControlIdToReplace',fld:'vDDO_PRODUTODTVALIDADETITLECONTROLIDTOREPLACE',pic:''},{av:'AV83ProdutoDtValidade',fld:'vPRODUTODTVALIDADE',pic:''},{av:'AV84ProdutoDtValidade_To',fld:'vPRODUTODTVALIDADE_TO',pic:''},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV56TFProdutoId',fld:'vTFPRODUTOID',pic:'ZZZ9'},{av:'AV57TFProdutoId_To',fld:'vTFPRODUTOID_TO',pic:'ZZZ9'},{av:'AV60TFProdutoNome',fld:'vTFPRODUTONOME',pic:''},{av:'AV61TFProdutoNome_Sel',fld:'vTFPRODUTONOME_SEL',pic:''},{av:'AV68TFProdutoValor',fld:'vTFPRODUTOVALOR',pic:'R$ ZZ,ZZ9.99'},{av:'AV69TFProdutoValor_To',fld:'vTFPRODUTOVALOR_TO',pic:'R$ ZZ,ZZ9.99'},{av:'AV72TFProdutoDtValidade',fld:'vTFPRODUTODTVALIDADE',pic:''},{av:'AV73TFProdutoDtValidade_To',fld:'vTFPRODUTODTVALIDADE_TO',pic:''},{av:'AV108Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV55ProdutoIdTitleFilterData',fld:'vPRODUTOIDTITLEFILTERDATA',pic:''},{av:'AV59ProdutoNomeTitleFilterData',fld:'vPRODUTONOMETITLEFILTERDATA',pic:''},{av:'AV67ProdutoValorTitleFilterData',fld:'vPRODUTOVALORTITLEFILTERDATA',pic:''},{av:'AV71ProdutoDtValidadeTitleFilterData',fld:'vPRODUTODTVALIDADETITLEFILTERDATA',pic:''},{av:'AV49ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV41ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtProdutoId_Visible',ctrl:'PRODUTOID',prop:'Visible'},{av:'edtProdutoNome_Visible',ctrl:'PRODUTONOME',prop:'Visible'},{av:'edtProdutoValor_Visible',ctrl:'PRODUTOVALOR',prop:'Visible'},{av:'edtProdutoDtValidade_Visible',ctrl:'PRODUTODTVALIDADE',prop:'Visible'},{av:'edtProdutoId_Titleformat',ctrl:'PRODUTOID',prop:'Titleformat'},{av:'edtProdutoId_Title',ctrl:'PRODUTOID',prop:'Title'},{av:'edtProdutoNome_Titleformat',ctrl:'PRODUTONOME',prop:'Titleformat'},{av:'edtProdutoNome_Title',ctrl:'PRODUTONOME',prop:'Title'},{av:'edtProdutoValor_Titleformat',ctrl:'PRODUTOVALOR',prop:'Titleformat'},{av:'edtProdutoValor_Title',ctrl:'PRODUTOVALOR',prop:'Title'},{av:'edtProdutoDtValidade_Titleformat',ctrl:'PRODUTODTVALIDADE',prop:'Titleformat'},{av:'edtProdutoDtValidade_Title',ctrl:'PRODUTODTVALIDADE',prop:'Title'},{av:'AV79GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV80GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV53ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E120R2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV83ProdutoDtValidade',fld:'vPRODUTODTVALIDADE',pic:''},{av:'AV84ProdutoDtValidade_To',fld:'vPRODUTODTVALIDADE_TO',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV56TFProdutoId',fld:'vTFPRODUTOID',pic:'ZZZ9'},{av:'AV57TFProdutoId_To',fld:'vTFPRODUTOID_TO',pic:'ZZZ9'},{av:'AV60TFProdutoNome',fld:'vTFPRODUTONOME',pic:''},{av:'AV61TFProdutoNome_Sel',fld:'vTFPRODUTONOME_SEL',pic:''},{av:'AV68TFProdutoValor',fld:'vTFPRODUTOVALOR',pic:'R$ ZZ,ZZ9.99'},{av:'AV69TFProdutoValor_To',fld:'vTFPRODUTOVALOR_TO',pic:'R$ ZZ,ZZ9.99'},{av:'AV72TFProdutoDtValidade',fld:'vTFPRODUTODTVALIDADE',pic:''},{av:'AV73TFProdutoDtValidade_To',fld:'vTFPRODUTODTVALIDADE_TO',pic:''},{av:'AV49ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV41ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV58ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV62ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76ddo_ProdutoDtValidadeTitleControlIdToReplace',fld:'vDDO_PRODUTODTVALIDADETITLECONTROLIDTOREPLACE',pic:''},{av:'AV108Pgmname',fld:'vPGMNAME',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E130R2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV83ProdutoDtValidade',fld:'vPRODUTODTVALIDADE',pic:''},{av:'AV84ProdutoDtValidade_To',fld:'vPRODUTODTVALIDADE_TO',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV56TFProdutoId',fld:'vTFPRODUTOID',pic:'ZZZ9'},{av:'AV57TFProdutoId_To',fld:'vTFPRODUTOID_TO',pic:'ZZZ9'},{av:'AV60TFProdutoNome',fld:'vTFPRODUTONOME',pic:''},{av:'AV61TFProdutoNome_Sel',fld:'vTFPRODUTONOME_SEL',pic:''},{av:'AV68TFProdutoValor',fld:'vTFPRODUTOVALOR',pic:'R$ ZZ,ZZ9.99'},{av:'AV69TFProdutoValor_To',fld:'vTFPRODUTOVALOR_TO',pic:'R$ ZZ,ZZ9.99'},{av:'AV72TFProdutoDtValidade',fld:'vTFPRODUTODTVALIDADE',pic:''},{av:'AV73TFProdutoDtValidade_To',fld:'vTFPRODUTODTVALIDADE_TO',pic:''},{av:'AV49ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV41ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV58ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV62ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76ddo_ProdutoDtValidadeTitleControlIdToReplace',fld:'vDDO_PRODUTODTVALIDADETITLECONTROLIDTOREPLACE',pic:''},{av:'AV108Pgmname',fld:'vPGMNAME',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_PRODUTOID.ONOPTIONCLICKED","{handler:'E140R2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV83ProdutoDtValidade',fld:'vPRODUTODTVALIDADE',pic:''},{av:'AV84ProdutoDtValidade_To',fld:'vPRODUTODTVALIDADE_TO',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV56TFProdutoId',fld:'vTFPRODUTOID',pic:'ZZZ9'},{av:'AV57TFProdutoId_To',fld:'vTFPRODUTOID_TO',pic:'ZZZ9'},{av:'AV60TFProdutoNome',fld:'vTFPRODUTONOME',pic:''},{av:'AV61TFProdutoNome_Sel',fld:'vTFPRODUTONOME_SEL',pic:''},{av:'AV68TFProdutoValor',fld:'vTFPRODUTOVALOR',pic:'R$ ZZ,ZZ9.99'},{av:'AV69TFProdutoValor_To',fld:'vTFPRODUTOVALOR_TO',pic:'R$ ZZ,ZZ9.99'},{av:'AV72TFProdutoDtValidade',fld:'vTFPRODUTODTVALIDADE',pic:''},{av:'AV73TFProdutoDtValidade_To',fld:'vTFPRODUTODTVALIDADE_TO',pic:''},{av:'AV49ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV41ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV58ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV62ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76ddo_ProdutoDtValidadeTitleControlIdToReplace',fld:'vDDO_PRODUTODTVALIDADETITLECONTROLIDTOREPLACE',pic:''},{av:'AV108Pgmname',fld:'vPGMNAME',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Ddo_produtoid_Activeeventkey',ctrl:'DDO_PRODUTOID',prop:'ActiveEventKey'},{av:'Ddo_produtoid_Filteredtext_get',ctrl:'DDO_PRODUTOID',prop:'FilteredText_get'},{av:'Ddo_produtoid_Filteredtextto_get',ctrl:'DDO_PRODUTOID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_PRODUTOID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_produtoid_Sortedstatus',ctrl:'DDO_PRODUTOID',prop:'SortedStatus'},{av:'AV56TFProdutoId',fld:'vTFPRODUTOID',pic:'ZZZ9'},{av:'AV57TFProdutoId_To',fld:'vTFPRODUTOID_TO',pic:'ZZZ9'},{av:'Ddo_produtonome_Sortedstatus',ctrl:'DDO_PRODUTONOME',prop:'SortedStatus'},{av:'Ddo_produtovalor_Sortedstatus',ctrl:'DDO_PRODUTOVALOR',prop:'SortedStatus'},{av:'Ddo_produtodtvalidade_Sortedstatus',ctrl:'DDO_PRODUTODTVALIDADE',prop:'SortedStatus'},{av:'AV55ProdutoIdTitleFilterData',fld:'vPRODUTOIDTITLEFILTERDATA',pic:''},{av:'AV59ProdutoNomeTitleFilterData',fld:'vPRODUTONOMETITLEFILTERDATA',pic:''},{av:'AV67ProdutoValorTitleFilterData',fld:'vPRODUTOVALORTITLEFILTERDATA',pic:''},{av:'AV71ProdutoDtValidadeTitleFilterData',fld:'vPRODUTODTVALIDADETITLEFILTERDATA',pic:''},{av:'AV49ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV41ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtProdutoId_Visible',ctrl:'PRODUTOID',prop:'Visible'},{av:'edtProdutoNome_Visible',ctrl:'PRODUTONOME',prop:'Visible'},{av:'edtProdutoValor_Visible',ctrl:'PRODUTOVALOR',prop:'Visible'},{av:'edtProdutoDtValidade_Visible',ctrl:'PRODUTODTVALIDADE',prop:'Visible'},{av:'edtProdutoId_Titleformat',ctrl:'PRODUTOID',prop:'Titleformat'},{av:'edtProdutoId_Title',ctrl:'PRODUTOID',prop:'Title'},{av:'edtProdutoNome_Titleformat',ctrl:'PRODUTONOME',prop:'Titleformat'},{av:'edtProdutoNome_Title',ctrl:'PRODUTONOME',prop:'Title'},{av:'edtProdutoValor_Titleformat',ctrl:'PRODUTOVALOR',prop:'Titleformat'},{av:'edtProdutoValor_Title',ctrl:'PRODUTOVALOR',prop:'Title'},{av:'edtProdutoDtValidade_Titleformat',ctrl:'PRODUTODTVALIDADE',prop:'Titleformat'},{av:'edtProdutoDtValidade_Title',ctrl:'PRODUTODTVALIDADE',prop:'Title'},{av:'AV79GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV80GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV53ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("DDO_PRODUTONOME.ONOPTIONCLICKED","{handler:'E150R2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV83ProdutoDtValidade',fld:'vPRODUTODTVALIDADE',pic:''},{av:'AV84ProdutoDtValidade_To',fld:'vPRODUTODTVALIDADE_TO',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV56TFProdutoId',fld:'vTFPRODUTOID',pic:'ZZZ9'},{av:'AV57TFProdutoId_To',fld:'vTFPRODUTOID_TO',pic:'ZZZ9'},{av:'AV60TFProdutoNome',fld:'vTFPRODUTONOME',pic:''},{av:'AV61TFProdutoNome_Sel',fld:'vTFPRODUTONOME_SEL',pic:''},{av:'AV68TFProdutoValor',fld:'vTFPRODUTOVALOR',pic:'R$ ZZ,ZZ9.99'},{av:'AV69TFProdutoValor_To',fld:'vTFPRODUTOVALOR_TO',pic:'R$ ZZ,ZZ9.99'},{av:'AV72TFProdutoDtValidade',fld:'vTFPRODUTODTVALIDADE',pic:''},{av:'AV73TFProdutoDtValidade_To',fld:'vTFPRODUTODTVALIDADE_TO',pic:''},{av:'AV49ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV41ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV58ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV62ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76ddo_ProdutoDtValidadeTitleControlIdToReplace',fld:'vDDO_PRODUTODTVALIDADETITLECONTROLIDTOREPLACE',pic:''},{av:'AV108Pgmname',fld:'vPGMNAME',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Ddo_produtonome_Activeeventkey',ctrl:'DDO_PRODUTONOME',prop:'ActiveEventKey'},{av:'Ddo_produtonome_Filteredtext_get',ctrl:'DDO_PRODUTONOME',prop:'FilteredText_get'},{av:'Ddo_produtonome_Selectedvalue_get',ctrl:'DDO_PRODUTONOME',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_PRODUTONOME.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_produtonome_Sortedstatus',ctrl:'DDO_PRODUTONOME',prop:'SortedStatus'},{av:'AV60TFProdutoNome',fld:'vTFPRODUTONOME',pic:''},{av:'AV61TFProdutoNome_Sel',fld:'vTFPRODUTONOME_SEL',pic:''},{av:'Ddo_produtoid_Sortedstatus',ctrl:'DDO_PRODUTOID',prop:'SortedStatus'},{av:'Ddo_produtovalor_Sortedstatus',ctrl:'DDO_PRODUTOVALOR',prop:'SortedStatus'},{av:'Ddo_produtodtvalidade_Sortedstatus',ctrl:'DDO_PRODUTODTVALIDADE',prop:'SortedStatus'},{av:'AV55ProdutoIdTitleFilterData',fld:'vPRODUTOIDTITLEFILTERDATA',pic:''},{av:'AV59ProdutoNomeTitleFilterData',fld:'vPRODUTONOMETITLEFILTERDATA',pic:''},{av:'AV67ProdutoValorTitleFilterData',fld:'vPRODUTOVALORTITLEFILTERDATA',pic:''},{av:'AV71ProdutoDtValidadeTitleFilterData',fld:'vPRODUTODTVALIDADETITLEFILTERDATA',pic:''},{av:'AV49ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV41ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtProdutoId_Visible',ctrl:'PRODUTOID',prop:'Visible'},{av:'edtProdutoNome_Visible',ctrl:'PRODUTONOME',prop:'Visible'},{av:'edtProdutoValor_Visible',ctrl:'PRODUTOVALOR',prop:'Visible'},{av:'edtProdutoDtValidade_Visible',ctrl:'PRODUTODTVALIDADE',prop:'Visible'},{av:'edtProdutoId_Titleformat',ctrl:'PRODUTOID',prop:'Titleformat'},{av:'edtProdutoId_Title',ctrl:'PRODUTOID',prop:'Title'},{av:'edtProdutoNome_Titleformat',ctrl:'PRODUTONOME',prop:'Titleformat'},{av:'edtProdutoNome_Title',ctrl:'PRODUTONOME',prop:'Title'},{av:'edtProdutoValor_Titleformat',ctrl:'PRODUTOVALOR',prop:'Titleformat'},{av:'edtProdutoValor_Title',ctrl:'PRODUTOVALOR',prop:'Title'},{av:'edtProdutoDtValidade_Titleformat',ctrl:'PRODUTODTVALIDADE',prop:'Titleformat'},{av:'edtProdutoDtValidade_Title',ctrl:'PRODUTODTVALIDADE',prop:'Title'},{av:'AV79GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV80GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV53ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("DDO_PRODUTOVALOR.ONOPTIONCLICKED","{handler:'E160R2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV83ProdutoDtValidade',fld:'vPRODUTODTVALIDADE',pic:''},{av:'AV84ProdutoDtValidade_To',fld:'vPRODUTODTVALIDADE_TO',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV56TFProdutoId',fld:'vTFPRODUTOID',pic:'ZZZ9'},{av:'AV57TFProdutoId_To',fld:'vTFPRODUTOID_TO',pic:'ZZZ9'},{av:'AV60TFProdutoNome',fld:'vTFPRODUTONOME',pic:''},{av:'AV61TFProdutoNome_Sel',fld:'vTFPRODUTONOME_SEL',pic:''},{av:'AV68TFProdutoValor',fld:'vTFPRODUTOVALOR',pic:'R$ ZZ,ZZ9.99'},{av:'AV69TFProdutoValor_To',fld:'vTFPRODUTOVALOR_TO',pic:'R$ ZZ,ZZ9.99'},{av:'AV72TFProdutoDtValidade',fld:'vTFPRODUTODTVALIDADE',pic:''},{av:'AV73TFProdutoDtValidade_To',fld:'vTFPRODUTODTVALIDADE_TO',pic:''},{av:'AV49ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV41ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV58ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV62ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76ddo_ProdutoDtValidadeTitleControlIdToReplace',fld:'vDDO_PRODUTODTVALIDADETITLECONTROLIDTOREPLACE',pic:''},{av:'AV108Pgmname',fld:'vPGMNAME',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Ddo_produtovalor_Activeeventkey',ctrl:'DDO_PRODUTOVALOR',prop:'ActiveEventKey'},{av:'Ddo_produtovalor_Filteredtext_get',ctrl:'DDO_PRODUTOVALOR',prop:'FilteredText_get'},{av:'Ddo_produtovalor_Filteredtextto_get',ctrl:'DDO_PRODUTOVALOR',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_PRODUTOVALOR.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_produtovalor_Sortedstatus',ctrl:'DDO_PRODUTOVALOR',prop:'SortedStatus'},{av:'AV68TFProdutoValor',fld:'vTFPRODUTOVALOR',pic:'R$ ZZ,ZZ9.99'},{av:'AV69TFProdutoValor_To',fld:'vTFPRODUTOVALOR_TO',pic:'R$ ZZ,ZZ9.99'},{av:'Ddo_produtoid_Sortedstatus',ctrl:'DDO_PRODUTOID',prop:'SortedStatus'},{av:'Ddo_produtonome_Sortedstatus',ctrl:'DDO_PRODUTONOME',prop:'SortedStatus'},{av:'Ddo_produtodtvalidade_Sortedstatus',ctrl:'DDO_PRODUTODTVALIDADE',prop:'SortedStatus'},{av:'AV55ProdutoIdTitleFilterData',fld:'vPRODUTOIDTITLEFILTERDATA',pic:''},{av:'AV59ProdutoNomeTitleFilterData',fld:'vPRODUTONOMETITLEFILTERDATA',pic:''},{av:'AV67ProdutoValorTitleFilterData',fld:'vPRODUTOVALORTITLEFILTERDATA',pic:''},{av:'AV71ProdutoDtValidadeTitleFilterData',fld:'vPRODUTODTVALIDADETITLEFILTERDATA',pic:''},{av:'AV49ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV41ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtProdutoId_Visible',ctrl:'PRODUTOID',prop:'Visible'},{av:'edtProdutoNome_Visible',ctrl:'PRODUTONOME',prop:'Visible'},{av:'edtProdutoValor_Visible',ctrl:'PRODUTOVALOR',prop:'Visible'},{av:'edtProdutoDtValidade_Visible',ctrl:'PRODUTODTVALIDADE',prop:'Visible'},{av:'edtProdutoId_Titleformat',ctrl:'PRODUTOID',prop:'Titleformat'},{av:'edtProdutoId_Title',ctrl:'PRODUTOID',prop:'Title'},{av:'edtProdutoNome_Titleformat',ctrl:'PRODUTONOME',prop:'Titleformat'},{av:'edtProdutoNome_Title',ctrl:'PRODUTONOME',prop:'Title'},{av:'edtProdutoValor_Titleformat',ctrl:'PRODUTOVALOR',prop:'Titleformat'},{av:'edtProdutoValor_Title',ctrl:'PRODUTOVALOR',prop:'Title'},{av:'edtProdutoDtValidade_Titleformat',ctrl:'PRODUTODTVALIDADE',prop:'Titleformat'},{av:'edtProdutoDtValidade_Title',ctrl:'PRODUTODTVALIDADE',prop:'Title'},{av:'AV79GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV80GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV53ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("DDO_PRODUTODTVALIDADE.ONOPTIONCLICKED","{handler:'E170R2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV83ProdutoDtValidade',fld:'vPRODUTODTVALIDADE',pic:''},{av:'AV84ProdutoDtValidade_To',fld:'vPRODUTODTVALIDADE_TO',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV56TFProdutoId',fld:'vTFPRODUTOID',pic:'ZZZ9'},{av:'AV57TFProdutoId_To',fld:'vTFPRODUTOID_TO',pic:'ZZZ9'},{av:'AV60TFProdutoNome',fld:'vTFPRODUTONOME',pic:''},{av:'AV61TFProdutoNome_Sel',fld:'vTFPRODUTONOME_SEL',pic:''},{av:'AV68TFProdutoValor',fld:'vTFPRODUTOVALOR',pic:'R$ ZZ,ZZ9.99'},{av:'AV69TFProdutoValor_To',fld:'vTFPRODUTOVALOR_TO',pic:'R$ ZZ,ZZ9.99'},{av:'AV72TFProdutoDtValidade',fld:'vTFPRODUTODTVALIDADE',pic:''},{av:'AV73TFProdutoDtValidade_To',fld:'vTFPRODUTODTVALIDADE_TO',pic:''},{av:'AV49ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV41ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV58ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV62ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76ddo_ProdutoDtValidadeTitleControlIdToReplace',fld:'vDDO_PRODUTODTVALIDADETITLECONTROLIDTOREPLACE',pic:''},{av:'AV108Pgmname',fld:'vPGMNAME',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Ddo_produtodtvalidade_Activeeventkey',ctrl:'DDO_PRODUTODTVALIDADE',prop:'ActiveEventKey'},{av:'Ddo_produtodtvalidade_Filteredtext_get',ctrl:'DDO_PRODUTODTVALIDADE',prop:'FilteredText_get'},{av:'Ddo_produtodtvalidade_Filteredtextto_get',ctrl:'DDO_PRODUTODTVALIDADE',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_PRODUTODTVALIDADE.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_produtodtvalidade_Sortedstatus',ctrl:'DDO_PRODUTODTVALIDADE',prop:'SortedStatus'},{av:'AV72TFProdutoDtValidade',fld:'vTFPRODUTODTVALIDADE',pic:''},{av:'AV73TFProdutoDtValidade_To',fld:'vTFPRODUTODTVALIDADE_TO',pic:''},{av:'Ddo_produtoid_Sortedstatus',ctrl:'DDO_PRODUTOID',prop:'SortedStatus'},{av:'Ddo_produtonome_Sortedstatus',ctrl:'DDO_PRODUTONOME',prop:'SortedStatus'},{av:'Ddo_produtovalor_Sortedstatus',ctrl:'DDO_PRODUTOVALOR',prop:'SortedStatus'},{av:'AV55ProdutoIdTitleFilterData',fld:'vPRODUTOIDTITLEFILTERDATA',pic:''},{av:'AV59ProdutoNomeTitleFilterData',fld:'vPRODUTONOMETITLEFILTERDATA',pic:''},{av:'AV67ProdutoValorTitleFilterData',fld:'vPRODUTOVALORTITLEFILTERDATA',pic:''},{av:'AV71ProdutoDtValidadeTitleFilterData',fld:'vPRODUTODTVALIDADETITLEFILTERDATA',pic:''},{av:'AV49ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV41ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtProdutoId_Visible',ctrl:'PRODUTOID',prop:'Visible'},{av:'edtProdutoNome_Visible',ctrl:'PRODUTONOME',prop:'Visible'},{av:'edtProdutoValor_Visible',ctrl:'PRODUTOVALOR',prop:'Visible'},{av:'edtProdutoDtValidade_Visible',ctrl:'PRODUTODTVALIDADE',prop:'Visible'},{av:'edtProdutoId_Titleformat',ctrl:'PRODUTOID',prop:'Titleformat'},{av:'edtProdutoId_Title',ctrl:'PRODUTOID',prop:'Title'},{av:'edtProdutoNome_Titleformat',ctrl:'PRODUTONOME',prop:'Titleformat'},{av:'edtProdutoNome_Title',ctrl:'PRODUTONOME',prop:'Title'},{av:'edtProdutoValor_Titleformat',ctrl:'PRODUTOVALOR',prop:'Titleformat'},{av:'edtProdutoValor_Title',ctrl:'PRODUTOVALOR',prop:'Title'},{av:'edtProdutoDtValidade_Titleformat',ctrl:'PRODUTODTVALIDADE',prop:'Titleformat'},{av:'edtProdutoDtValidade_Title',ctrl:'PRODUTODTVALIDADE',prop:'Title'},{av:'AV79GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV80GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV53ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("GRID.LOAD","{handler:'E300R2',iparms:[{av:'A8ProdutoId',fld:'PRODUTOID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV81Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'AV82Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'},{av:'edtProdutoNome_Link',ctrl:'PRODUTONOME',prop:'Link'}]}");
         setEventMetadata("DDO_GRIDCOLUMNSSELECTOR.ONCOLUMNSCHANGED","{handler:'E180R2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV83ProdutoDtValidade',fld:'vPRODUTODTVALIDADE',pic:''},{av:'AV84ProdutoDtValidade_To',fld:'vPRODUTODTVALIDADE_TO',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV56TFProdutoId',fld:'vTFPRODUTOID',pic:'ZZZ9'},{av:'AV57TFProdutoId_To',fld:'vTFPRODUTOID_TO',pic:'ZZZ9'},{av:'AV60TFProdutoNome',fld:'vTFPRODUTONOME',pic:''},{av:'AV61TFProdutoNome_Sel',fld:'vTFPRODUTONOME_SEL',pic:''},{av:'AV68TFProdutoValor',fld:'vTFPRODUTOVALOR',pic:'R$ ZZ,ZZ9.99'},{av:'AV69TFProdutoValor_To',fld:'vTFPRODUTOVALOR_TO',pic:'R$ ZZ,ZZ9.99'},{av:'AV72TFProdutoDtValidade',fld:'vTFPRODUTODTVALIDADE',pic:''},{av:'AV73TFProdutoDtValidade_To',fld:'vTFPRODUTODTVALIDADE_TO',pic:''},{av:'AV49ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV41ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV58ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV62ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76ddo_ProdutoDtValidadeTitleControlIdToReplace',fld:'vDDO_PRODUTODTVALIDADETITLECONTROLIDTOREPLACE',pic:''},{av:'AV108Pgmname',fld:'vPGMNAME',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Ddo_gridcolumnsselector_Columnsselectorvalues',ctrl:'DDO_GRIDCOLUMNSSELECTOR',prop:'ColumnsSelectorValues'}]");
         setEventMetadata("DDO_GRIDCOLUMNSSELECTOR.ONCOLUMNSCHANGED",",oparms:[{av:'AV41ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV55ProdutoIdTitleFilterData',fld:'vPRODUTOIDTITLEFILTERDATA',pic:''},{av:'AV59ProdutoNomeTitleFilterData',fld:'vPRODUTONOMETITLEFILTERDATA',pic:''},{av:'AV67ProdutoValorTitleFilterData',fld:'vPRODUTOVALORTITLEFILTERDATA',pic:''},{av:'AV71ProdutoDtValidadeTitleFilterData',fld:'vPRODUTODTVALIDADETITLEFILTERDATA',pic:''},{av:'AV49ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'edtProdutoId_Visible',ctrl:'PRODUTOID',prop:'Visible'},{av:'edtProdutoNome_Visible',ctrl:'PRODUTONOME',prop:'Visible'},{av:'edtProdutoValor_Visible',ctrl:'PRODUTOVALOR',prop:'Visible'},{av:'edtProdutoDtValidade_Visible',ctrl:'PRODUTODTVALIDADE',prop:'Visible'},{av:'edtProdutoId_Titleformat',ctrl:'PRODUTOID',prop:'Titleformat'},{av:'edtProdutoId_Title',ctrl:'PRODUTOID',prop:'Title'},{av:'edtProdutoNome_Titleformat',ctrl:'PRODUTONOME',prop:'Titleformat'},{av:'edtProdutoNome_Title',ctrl:'PRODUTONOME',prop:'Title'},{av:'edtProdutoValor_Titleformat',ctrl:'PRODUTOVALOR',prop:'Titleformat'},{av:'edtProdutoValor_Title',ctrl:'PRODUTOVALOR',prop:'Title'},{av:'edtProdutoDtValidade_Titleformat',ctrl:'PRODUTODTVALIDADE',prop:'Titleformat'},{av:'edtProdutoDtValidade_Title',ctrl:'PRODUTODTVALIDADE',prop:'Title'},{av:'AV79GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV80GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV53ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("'ADDDYNAMICFILTERS1'","{handler:'E230R2',iparms:[]");
         setEventMetadata("'ADDDYNAMICFILTERS1'",",oparms:[{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'}]}");
         setEventMetadata("'REMOVEDYNAMICFILTERS1'","{handler:'E190R2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV83ProdutoDtValidade',fld:'vPRODUTODTVALIDADE',pic:''},{av:'AV84ProdutoDtValidade_To',fld:'vPRODUTODTVALIDADE_TO',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV56TFProdutoId',fld:'vTFPRODUTOID',pic:'ZZZ9'},{av:'AV57TFProdutoId_To',fld:'vTFPRODUTOID_TO',pic:'ZZZ9'},{av:'AV60TFProdutoNome',fld:'vTFPRODUTONOME',pic:''},{av:'AV61TFProdutoNome_Sel',fld:'vTFPRODUTONOME_SEL',pic:''},{av:'AV68TFProdutoValor',fld:'vTFPRODUTOVALOR',pic:'R$ ZZ,ZZ9.99'},{av:'AV69TFProdutoValor_To',fld:'vTFPRODUTOVALOR_TO',pic:'R$ ZZ,ZZ9.99'},{av:'AV72TFProdutoDtValidade',fld:'vTFPRODUTODTVALIDADE',pic:''},{av:'AV73TFProdutoDtValidade_To',fld:'vTFPRODUTODTVALIDADE_TO',pic:''},{av:'AV49ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV41ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV58ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV62ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76ddo_ProdutoDtValidadeTitleControlIdToReplace',fld:'vDDO_PRODUTODTVALIDADETITLECONTROLIDTOREPLACE',pic:''},{av:'AV108Pgmname',fld:'vPGMNAME',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''}]");
         setEventMetadata("'REMOVEDYNAMICFILTERS1'",",oparms:[{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'lblJsdynamicfilters_Caption',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{av:'edtavProdutonome2_Visible',ctrl:'vPRODUTONOME2',prop:'Visible'},{av:'edtavProdutonome3_Visible',ctrl:'vPRODUTONOME3',prop:'Visible'},{av:'edtavProdutonome1_Visible',ctrl:'vPRODUTONOME1',prop:'Visible'},{av:'AV55ProdutoIdTitleFilterData',fld:'vPRODUTOIDTITLEFILTERDATA',pic:''},{av:'AV59ProdutoNomeTitleFilterData',fld:'vPRODUTONOMETITLEFILTERDATA',pic:''},{av:'AV67ProdutoValorTitleFilterData',fld:'vPRODUTOVALORTITLEFILTERDATA',pic:''},{av:'AV71ProdutoDtValidadeTitleFilterData',fld:'vPRODUTODTVALIDADETITLEFILTERDATA',pic:''},{av:'AV49ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV41ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtProdutoId_Visible',ctrl:'PRODUTOID',prop:'Visible'},{av:'edtProdutoNome_Visible',ctrl:'PRODUTONOME',prop:'Visible'},{av:'edtProdutoValor_Visible',ctrl:'PRODUTOVALOR',prop:'Visible'},{av:'edtProdutoDtValidade_Visible',ctrl:'PRODUTODTVALIDADE',prop:'Visible'},{av:'edtProdutoId_Titleformat',ctrl:'PRODUTOID',prop:'Titleformat'},{av:'edtProdutoId_Title',ctrl:'PRODUTOID',prop:'Title'},{av:'edtProdutoNome_Titleformat',ctrl:'PRODUTONOME',prop:'Titleformat'},{av:'edtProdutoNome_Title',ctrl:'PRODUTONOME',prop:'Title'},{av:'edtProdutoValor_Titleformat',ctrl:'PRODUTOVALOR',prop:'Titleformat'},{av:'edtProdutoValor_Title',ctrl:'PRODUTOVALOR',prop:'Title'},{av:'edtProdutoDtValidade_Titleformat',ctrl:'PRODUTODTVALIDADE',prop:'Titleformat'},{av:'edtProdutoDtValidade_Title',ctrl:'PRODUTODTVALIDADE',prop:'Title'},{av:'AV79GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV80GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV53ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''}]}");
         setEventMetadata("VDYNAMICFILTERSSELECTOR1.CLICK","{handler:'E240R2',iparms:[{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''}]");
         setEventMetadata("VDYNAMICFILTERSSELECTOR1.CLICK",",oparms:[{av:'edtavProdutonome1_Visible',ctrl:'vPRODUTONOME1',prop:'Visible'},{av:'cmbavDynamicfiltersoperator1'}]}");
         setEventMetadata("'ADDDYNAMICFILTERS2'","{handler:'E250R2',iparms:[]");
         setEventMetadata("'ADDDYNAMICFILTERS2'",",oparms:[{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'}]}");
         setEventMetadata("'REMOVEDYNAMICFILTERS2'","{handler:'E200R2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV83ProdutoDtValidade',fld:'vPRODUTODTVALIDADE',pic:''},{av:'AV84ProdutoDtValidade_To',fld:'vPRODUTODTVALIDADE_TO',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV56TFProdutoId',fld:'vTFPRODUTOID',pic:'ZZZ9'},{av:'AV57TFProdutoId_To',fld:'vTFPRODUTOID_TO',pic:'ZZZ9'},{av:'AV60TFProdutoNome',fld:'vTFPRODUTONOME',pic:''},{av:'AV61TFProdutoNome_Sel',fld:'vTFPRODUTONOME_SEL',pic:''},{av:'AV68TFProdutoValor',fld:'vTFPRODUTOVALOR',pic:'R$ ZZ,ZZ9.99'},{av:'AV69TFProdutoValor_To',fld:'vTFPRODUTOVALOR_TO',pic:'R$ ZZ,ZZ9.99'},{av:'AV72TFProdutoDtValidade',fld:'vTFPRODUTODTVALIDADE',pic:''},{av:'AV73TFProdutoDtValidade_To',fld:'vTFPRODUTODTVALIDADE_TO',pic:''},{av:'AV49ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV41ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV58ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV62ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76ddo_ProdutoDtValidadeTitleControlIdToReplace',fld:'vDDO_PRODUTODTVALIDADETITLECONTROLIDTOREPLACE',pic:''},{av:'AV108Pgmname',fld:'vPGMNAME',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''}]");
         setEventMetadata("'REMOVEDYNAMICFILTERS2'",",oparms:[{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'lblJsdynamicfilters_Caption',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{av:'edtavProdutonome2_Visible',ctrl:'vPRODUTONOME2',prop:'Visible'},{av:'edtavProdutonome3_Visible',ctrl:'vPRODUTONOME3',prop:'Visible'},{av:'edtavProdutonome1_Visible',ctrl:'vPRODUTONOME1',prop:'Visible'},{av:'AV55ProdutoIdTitleFilterData',fld:'vPRODUTOIDTITLEFILTERDATA',pic:''},{av:'AV59ProdutoNomeTitleFilterData',fld:'vPRODUTONOMETITLEFILTERDATA',pic:''},{av:'AV67ProdutoValorTitleFilterData',fld:'vPRODUTOVALORTITLEFILTERDATA',pic:''},{av:'AV71ProdutoDtValidadeTitleFilterData',fld:'vPRODUTODTVALIDADETITLEFILTERDATA',pic:''},{av:'AV49ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV41ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtProdutoId_Visible',ctrl:'PRODUTOID',prop:'Visible'},{av:'edtProdutoNome_Visible',ctrl:'PRODUTONOME',prop:'Visible'},{av:'edtProdutoValor_Visible',ctrl:'PRODUTOVALOR',prop:'Visible'},{av:'edtProdutoDtValidade_Visible',ctrl:'PRODUTODTVALIDADE',prop:'Visible'},{av:'edtProdutoId_Titleformat',ctrl:'PRODUTOID',prop:'Titleformat'},{av:'edtProdutoId_Title',ctrl:'PRODUTOID',prop:'Title'},{av:'edtProdutoNome_Titleformat',ctrl:'PRODUTONOME',prop:'Titleformat'},{av:'edtProdutoNome_Title',ctrl:'PRODUTONOME',prop:'Title'},{av:'edtProdutoValor_Titleformat',ctrl:'PRODUTOVALOR',prop:'Titleformat'},{av:'edtProdutoValor_Title',ctrl:'PRODUTOVALOR',prop:'Title'},{av:'edtProdutoDtValidade_Titleformat',ctrl:'PRODUTODTVALIDADE',prop:'Titleformat'},{av:'edtProdutoDtValidade_Title',ctrl:'PRODUTODTVALIDADE',prop:'Title'},{av:'AV79GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV80GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV53ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''}]}");
         setEventMetadata("VDYNAMICFILTERSSELECTOR2.CLICK","{handler:'E260R2',iparms:[{av:'cmbavDynamicfiltersselector2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''}]");
         setEventMetadata("VDYNAMICFILTERSSELECTOR2.CLICK",",oparms:[{av:'edtavProdutonome2_Visible',ctrl:'vPRODUTONOME2',prop:'Visible'},{av:'cmbavDynamicfiltersoperator2'}]}");
         setEventMetadata("'REMOVEDYNAMICFILTERS3'","{handler:'E210R2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV83ProdutoDtValidade',fld:'vPRODUTODTVALIDADE',pic:''},{av:'AV84ProdutoDtValidade_To',fld:'vPRODUTODTVALIDADE_TO',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV56TFProdutoId',fld:'vTFPRODUTOID',pic:'ZZZ9'},{av:'AV57TFProdutoId_To',fld:'vTFPRODUTOID_TO',pic:'ZZZ9'},{av:'AV60TFProdutoNome',fld:'vTFPRODUTONOME',pic:''},{av:'AV61TFProdutoNome_Sel',fld:'vTFPRODUTONOME_SEL',pic:''},{av:'AV68TFProdutoValor',fld:'vTFPRODUTOVALOR',pic:'R$ ZZ,ZZ9.99'},{av:'AV69TFProdutoValor_To',fld:'vTFPRODUTOVALOR_TO',pic:'R$ ZZ,ZZ9.99'},{av:'AV72TFProdutoDtValidade',fld:'vTFPRODUTODTVALIDADE',pic:''},{av:'AV73TFProdutoDtValidade_To',fld:'vTFPRODUTODTVALIDADE_TO',pic:''},{av:'AV49ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV41ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV58ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV62ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76ddo_ProdutoDtValidadeTitleControlIdToReplace',fld:'vDDO_PRODUTODTVALIDADETITLECONTROLIDTOREPLACE',pic:''},{av:'AV108Pgmname',fld:'vPGMNAME',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''}]");
         setEventMetadata("'REMOVEDYNAMICFILTERS3'",",oparms:[{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'lblJsdynamicfilters_Caption',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{av:'edtavProdutonome2_Visible',ctrl:'vPRODUTONOME2',prop:'Visible'},{av:'edtavProdutonome3_Visible',ctrl:'vPRODUTONOME3',prop:'Visible'},{av:'edtavProdutonome1_Visible',ctrl:'vPRODUTONOME1',prop:'Visible'},{av:'AV55ProdutoIdTitleFilterData',fld:'vPRODUTOIDTITLEFILTERDATA',pic:''},{av:'AV59ProdutoNomeTitleFilterData',fld:'vPRODUTONOMETITLEFILTERDATA',pic:''},{av:'AV67ProdutoValorTitleFilterData',fld:'vPRODUTOVALORTITLEFILTERDATA',pic:''},{av:'AV71ProdutoDtValidadeTitleFilterData',fld:'vPRODUTODTVALIDADETITLEFILTERDATA',pic:''},{av:'AV49ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV41ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtProdutoId_Visible',ctrl:'PRODUTOID',prop:'Visible'},{av:'edtProdutoNome_Visible',ctrl:'PRODUTONOME',prop:'Visible'},{av:'edtProdutoValor_Visible',ctrl:'PRODUTOVALOR',prop:'Visible'},{av:'edtProdutoDtValidade_Visible',ctrl:'PRODUTODTVALIDADE',prop:'Visible'},{av:'edtProdutoId_Titleformat',ctrl:'PRODUTOID',prop:'Titleformat'},{av:'edtProdutoId_Title',ctrl:'PRODUTOID',prop:'Title'},{av:'edtProdutoNome_Titleformat',ctrl:'PRODUTONOME',prop:'Titleformat'},{av:'edtProdutoNome_Title',ctrl:'PRODUTONOME',prop:'Title'},{av:'edtProdutoValor_Titleformat',ctrl:'PRODUTOVALOR',prop:'Titleformat'},{av:'edtProdutoValor_Title',ctrl:'PRODUTOVALOR',prop:'Title'},{av:'edtProdutoDtValidade_Titleformat',ctrl:'PRODUTODTVALIDADE',prop:'Titleformat'},{av:'edtProdutoDtValidade_Title',ctrl:'PRODUTODTVALIDADE',prop:'Title'},{av:'AV79GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV80GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV53ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''}]}");
         setEventMetadata("VDYNAMICFILTERSSELECTOR3.CLICK","{handler:'E270R2',iparms:[{av:'cmbavDynamicfiltersselector3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''}]");
         setEventMetadata("VDYNAMICFILTERSSELECTOR3.CLICK",",oparms:[{av:'edtavProdutonome3_Visible',ctrl:'vPRODUTONOME3',prop:'Visible'},{av:'cmbavDynamicfiltersoperator3'}]}");
         setEventMetadata("DDO_MANAGEFILTERS.ONOPTIONCLICKED","{handler:'E110R2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV83ProdutoDtValidade',fld:'vPRODUTODTVALIDADE',pic:''},{av:'AV84ProdutoDtValidade_To',fld:'vPRODUTODTVALIDADE_TO',pic:''},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV56TFProdutoId',fld:'vTFPRODUTOID',pic:'ZZZ9'},{av:'AV57TFProdutoId_To',fld:'vTFPRODUTOID_TO',pic:'ZZZ9'},{av:'AV60TFProdutoNome',fld:'vTFPRODUTONOME',pic:''},{av:'AV61TFProdutoNome_Sel',fld:'vTFPRODUTONOME_SEL',pic:''},{av:'AV68TFProdutoValor',fld:'vTFPRODUTOVALOR',pic:'R$ ZZ,ZZ9.99'},{av:'AV69TFProdutoValor_To',fld:'vTFPRODUTOVALOR_TO',pic:'R$ ZZ,ZZ9.99'},{av:'AV72TFProdutoDtValidade',fld:'vTFPRODUTODTVALIDADE',pic:''},{av:'AV73TFProdutoDtValidade_To',fld:'vTFPRODUTODTVALIDADE_TO',pic:''},{av:'AV49ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV41ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV58ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV62ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV76ddo_ProdutoDtValidadeTitleControlIdToReplace',fld:'vDDO_PRODUTODTVALIDADETITLECONTROLIDTOREPLACE',pic:''},{av:'AV108Pgmname',fld:'vPGMNAME',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'Ddo_managefilters_Activeeventkey',ctrl:'DDO_MANAGEFILTERS',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_MANAGEFILTERS.ONOPTIONCLICKED",",oparms:[{av:'AV49ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV83ProdutoDtValidade',fld:'vPRODUTODTVALIDADE',pic:''},{av:'AV84ProdutoDtValidade_To',fld:'vPRODUTODTVALIDADE_TO',pic:''},{av:'AV56TFProdutoId',fld:'vTFPRODUTOID',pic:'ZZZ9'},{av:'Ddo_produtoid_Filteredtext_set',ctrl:'DDO_PRODUTOID',prop:'FilteredText_set'},{av:'AV57TFProdutoId_To',fld:'vTFPRODUTOID_TO',pic:'ZZZ9'},{av:'Ddo_produtoid_Filteredtextto_set',ctrl:'DDO_PRODUTOID',prop:'FilteredTextTo_set'},{av:'AV60TFProdutoNome',fld:'vTFPRODUTONOME',pic:''},{av:'Ddo_produtonome_Filteredtext_set',ctrl:'DDO_PRODUTONOME',prop:'FilteredText_set'},{av:'AV61TFProdutoNome_Sel',fld:'vTFPRODUTONOME_SEL',pic:''},{av:'Ddo_produtonome_Selectedvalue_set',ctrl:'DDO_PRODUTONOME',prop:'SelectedValue_set'},{av:'AV68TFProdutoValor',fld:'vTFPRODUTOVALOR',pic:'R$ ZZ,ZZ9.99'},{av:'Ddo_produtovalor_Filteredtext_set',ctrl:'DDO_PRODUTOVALOR',prop:'FilteredText_set'},{av:'AV69TFProdutoValor_To',fld:'vTFPRODUTOVALOR_TO',pic:'R$ ZZ,ZZ9.99'},{av:'Ddo_produtovalor_Filteredtextto_set',ctrl:'DDO_PRODUTOVALOR',prop:'FilteredTextTo_set'},{av:'AV72TFProdutoDtValidade',fld:'vTFPRODUTODTVALIDADE',pic:''},{av:'Ddo_produtodtvalidade_Filteredtext_set',ctrl:'DDO_PRODUTODTVALIDADE',prop:'FilteredText_set'},{av:'AV73TFProdutoDtValidade_To',fld:'vTFPRODUTODTVALIDADE_TO',pic:''},{av:'Ddo_produtodtvalidade_Filteredtextto_set',ctrl:'DDO_PRODUTODTVALIDADE',prop:'FilteredTextTo_set'},{av:'cmbavDynamicfiltersselector1'},{av:'AV16DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV17DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV18ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'Ddo_produtoid_Sortedstatus',ctrl:'DDO_PRODUTOID',prop:'SortedStatus'},{av:'Ddo_produtonome_Sortedstatus',ctrl:'DDO_PRODUTONOME',prop:'SortedStatus'},{av:'Ddo_produtovalor_Sortedstatus',ctrl:'DDO_PRODUTOVALOR',prop:'SortedStatus'},{av:'Ddo_produtodtvalidade_Sortedstatus',ctrl:'DDO_PRODUTODTVALIDADE',prop:'SortedStatus'},{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'lblJsdynamicfilters_Caption',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{av:'AV19DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV20DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV21DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV22ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'AV23DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV24DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV25DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV26ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'edtavProdutonome1_Visible',ctrl:'vPRODUTONOME1',prop:'Visible'},{av:'edtavProdutonome2_Visible',ctrl:'vPRODUTONOME2',prop:'Visible'},{av:'edtavProdutonome3_Visible',ctrl:'vPRODUTONOME3',prop:'Visible'},{av:'AV55ProdutoIdTitleFilterData',fld:'vPRODUTOIDTITLEFILTERDATA',pic:''},{av:'AV59ProdutoNomeTitleFilterData',fld:'vPRODUTONOMETITLEFILTERDATA',pic:''},{av:'AV67ProdutoValorTitleFilterData',fld:'vPRODUTOVALORTITLEFILTERDATA',pic:''},{av:'AV71ProdutoDtValidadeTitleFilterData',fld:'vPRODUTODTVALIDADETITLEFILTERDATA',pic:''},{av:'AV41ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtProdutoId_Visible',ctrl:'PRODUTOID',prop:'Visible'},{av:'edtProdutoNome_Visible',ctrl:'PRODUTONOME',prop:'Visible'},{av:'edtProdutoValor_Visible',ctrl:'PRODUTOVALOR',prop:'Visible'},{av:'edtProdutoDtValidade_Visible',ctrl:'PRODUTODTVALIDADE',prop:'Visible'},{av:'edtProdutoId_Titleformat',ctrl:'PRODUTOID',prop:'Titleformat'},{av:'edtProdutoId_Title',ctrl:'PRODUTOID',prop:'Title'},{av:'edtProdutoNome_Titleformat',ctrl:'PRODUTONOME',prop:'Titleformat'},{av:'edtProdutoNome_Title',ctrl:'PRODUTONOME',prop:'Title'},{av:'edtProdutoValor_Titleformat',ctrl:'PRODUTOVALOR',prop:'Titleformat'},{av:'edtProdutoValor_Title',ctrl:'PRODUTOVALOR',prop:'Title'},{av:'edtProdutoDtValidade_Titleformat',ctrl:'PRODUTODTVALIDADE',prop:'Titleformat'},{av:'edtProdutoDtValidade_Title',ctrl:'PRODUTODTVALIDADE',prop:'Title'},{av:'AV79GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV80GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV53ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''}]}");
         setEventMetadata("'DOINSERT'","{handler:'E220R2',iparms:[{av:'A8ProdutoId',fld:'PRODUTOID',pic:'ZZZ9',hsh:true}]");
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
         Ddo_produtoid_Activeeventkey = "";
         Ddo_produtoid_Filteredtext_get = "";
         Ddo_produtoid_Filteredtextto_get = "";
         Ddo_produtonome_Activeeventkey = "";
         Ddo_produtonome_Filteredtext_get = "";
         Ddo_produtonome_Selectedvalue_get = "";
         Ddo_produtovalor_Activeeventkey = "";
         Ddo_produtovalor_Filteredtext_get = "";
         Ddo_produtovalor_Filteredtextto_get = "";
         Ddo_produtodtvalidade_Activeeventkey = "";
         Ddo_produtodtvalidade_Filteredtext_get = "";
         Ddo_produtodtvalidade_Filteredtextto_get = "";
         Ddo_gridcolumnsselector_Columnsselectorvalues = "";
         Ddo_managefilters_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV16DynamicFiltersSelector1 = "";
         AV18ProdutoNome1 = "";
         AV20DynamicFiltersSelector2 = "";
         AV22ProdutoNome2 = "";
         AV24DynamicFiltersSelector3 = "";
         AV26ProdutoNome3 = "";
         AV83ProdutoDtValidade = DateTime.MinValue;
         AV84ProdutoDtValidade_To = DateTime.MinValue;
         AV60TFProdutoNome = "";
         AV61TFProdutoNome_Sel = "";
         AV72TFProdutoDtValidade = DateTime.MinValue;
         AV73TFProdutoDtValidade_To = DateTime.MinValue;
         AV41ColumnsSelector = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector(context);
         AV58ddo_ProdutoIdTitleControlIdToReplace = "";
         AV62ddo_ProdutoNomeTitleControlIdToReplace = "";
         AV70ddo_ProdutoValorTitleControlIdToReplace = "";
         AV76ddo_ProdutoDtValidadeTitleControlIdToReplace = "";
         AV108Pgmname = "";
         AV10GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV53ManageFiltersData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV77DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV55ProdutoIdTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV59ProdutoNomeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV67ProdutoValorTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV71ProdutoDtValidadeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_produtoid_Filteredtext_set = "";
         Ddo_produtoid_Filteredtextto_set = "";
         Ddo_produtoid_Sortedstatus = "";
         Ddo_produtonome_Filteredtext_set = "";
         Ddo_produtonome_Selectedvalue_set = "";
         Ddo_produtonome_Sortedstatus = "";
         Ddo_produtovalor_Filteredtext_set = "";
         Ddo_produtovalor_Filteredtextto_set = "";
         Ddo_produtovalor_Sortedstatus = "";
         Ddo_produtodtvalidade_Filteredtext_set = "";
         Ddo_produtodtvalidade_Filteredtextto_set = "";
         Ddo_produtodtvalidade_Sortedstatus = "";
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
         AV81Update = "";
         AV82Delete = "";
         A9ProdutoNome = "";
         A10ProdutoDescricao = "";
         A12ProdutoDtValidade = DateTime.MinValue;
         ucGridpaginationbar = new GXUserControl();
         lblJsdynamicfilters_Jsonclick = "";
         ucDdo_produtoid = new GXUserControl();
         ucDdo_produtonome = new GXUserControl();
         ucDdo_produtovalor = new GXUserControl();
         ucDdo_produtodtvalidade = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         ucDdo_gridcolumnsselector = new GXUserControl();
         AV74DDO_ProdutoDtValidadeAuxDate = DateTime.MinValue;
         AV75DDO_ProdutoDtValidadeAuxDateTo = DateTime.MinValue;
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         lV91ProdutoWWDS_5_Produtonome1 = "";
         lV95ProdutoWWDS_9_Produtonome2 = "";
         lV99ProdutoWWDS_13_Produtonome3 = "";
         lV102ProdutoWWDS_16_Tfprodutonome = "";
         AV87ProdutoWWDS_1_Produtodtvalidade = DateTime.MinValue;
         AV88ProdutoWWDS_2_Produtodtvalidade_to = DateTime.MinValue;
         AV89ProdutoWWDS_3_Dynamicfiltersselector1 = "";
         AV91ProdutoWWDS_5_Produtonome1 = "";
         AV93ProdutoWWDS_7_Dynamicfiltersselector2 = "";
         AV95ProdutoWWDS_9_Produtonome2 = "";
         AV97ProdutoWWDS_11_Dynamicfiltersselector3 = "";
         AV99ProdutoWWDS_13_Produtonome3 = "";
         AV103ProdutoWWDS_17_Tfprodutonome_sel = "";
         AV102ProdutoWWDS_16_Tfprodutonome = "";
         AV106ProdutoWWDS_20_Tfprodutodtvalidade = DateTime.MinValue;
         AV107ProdutoWWDS_21_Tfprodutodtvalidade_to = DateTime.MinValue;
         H000R2_A12ProdutoDtValidade = new DateTime[] {DateTime.MinValue} ;
         H000R2_A11ProdutoValor = new decimal[1] ;
         H000R2_A10ProdutoDescricao = new String[] {""} ;
         H000R2_A9ProdutoNome = new String[] {""} ;
         H000R2_A8ProdutoId = new short[1] ;
         H000R3_AGRID_nRecordCount = new long[1] ;
         AV7HTTPRequest = new GxHttpRequest( context);
         imgAdddynamicfilters1_Jsonclick = "";
         imgRemovedynamicfilters1_Jsonclick = "";
         imgAdddynamicfilters2_Jsonclick = "";
         imgRemovedynamicfilters2_Jsonclick = "";
         imgRemovedynamicfilters3_Jsonclick = "";
         ucDdo_managefilters = new GXUserControl();
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV48Session = context.GetSession();
         AV29ColumnsSelectorXML = "";
         GridRow = new GXWebRow();
         AV50ManageFiltersXml = "";
         AV36UserCustomValue = "";
         GXt_char2 = "";
         AV42ColumnsSelectorAux = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector(context);
         AV54ManageFiltersDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
         AV51ManageFiltersItems = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item>( context, "Item", "");
         AV52ManageFiltersItem = new GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item(context);
         AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV12GridStateDynamicFilter = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter(context);
         AV8TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         Ddo_managefilters_Caption = "";
         lblFiltertextprodutodtvalidade_Jsonclick = "";
         lblProdutodtvalidade_rangemiddletext_Jsonclick = "";
         lblDynamicfiltersprefix1_Jsonclick = "";
         lblDynamicfiltersmiddle1_Jsonclick = "";
         lblDynamicfiltersprefix2_Jsonclick = "";
         lblDynamicfiltersmiddle2_Jsonclick = "";
         lblDynamicfiltersprefix3_Jsonclick = "";
         lblDynamicfiltersmiddle3_Jsonclick = "";
         sImgUrl = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.produtoww__default(),
            new Object[][] {
                new Object[] {
               H000R2_A12ProdutoDtValidade, H000R2_A11ProdutoValor, H000R2_A10ProdutoDescricao, H000R2_A9ProdutoNome, H000R2_A8ProdutoId
               }
               , new Object[] {
               H000R3_AGRID_nRecordCount
               }
            }
         );
         AV108Pgmname = "ProdutoWW";
         /* GeneXus formulas. */
         AV108Pgmname = "ProdutoWW";
         context.Gx_err = 0;
         edtavUpdate_Enabled = 0;
         edtavDelete_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_127 ;
      private short nGXsfl_127_idx=1 ;
      private short GRID_nEOF ;
      private short AV17DynamicFiltersOperator1 ;
      private short AV21DynamicFiltersOperator2 ;
      private short AV25DynamicFiltersOperator3 ;
      private short AV13OrderedBy ;
      private short AV56TFProdutoId ;
      private short AV57TFProdutoId_To ;
      private short AV49ManageFiltersExecutionStep ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtProdutoId_Titleformat ;
      private short edtProdutoNome_Titleformat ;
      private short edtProdutoValor_Titleformat ;
      private short edtProdutoDtValidade_Titleformat ;
      private short subGrid_Sortable ;
      private short A8ProdutoId ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV90ProdutoWWDS_4_Dynamicfiltersoperator1 ;
      private short AV94ProdutoWWDS_8_Dynamicfiltersoperator2 ;
      private short AV98ProdutoWWDS_12_Dynamicfiltersoperator3 ;
      private short AV100ProdutoWWDS_14_Tfprodutoid ;
      private short AV101ProdutoWWDS_15_Tfprodutoid_to ;
      private short nGXWrapped ;
      private short subGrid_Backstyle ;
      private int subGrid_Rows ;
      private int Gridpaginationbar_Rowsperpageselectedvalue ;
      private int Gridpaginationbar_Pagestoshow ;
      private int Ddo_produtonome_Datalistupdateminimumcharacters ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtProdutoId_Visible ;
      private int edtProdutoNome_Visible ;
      private int edtProdutoValor_Visible ;
      private int edtProdutoDtValidade_Visible ;
      private int edtavUpdate_Enabled ;
      private int edtavDelete_Enabled ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_produtoidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_produtonometitlecontrolidtoreplace_Visible ;
      private int edtavDdo_produtovalortitlecontrolidtoreplace_Visible ;
      private int edtavDdo_produtodtvalidadetitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int edtavManagefiltersexecutionstep_Visible ;
      private int edtavTfprodutoid_Visible ;
      private int edtavTfprodutoid_to_Visible ;
      private int edtavTfprodutonome_Visible ;
      private int edtavTfprodutonome_sel_Visible ;
      private int edtavTfprodutovalor_Visible ;
      private int edtavTfprodutovalor_to_Visible ;
      private int edtavTfprodutodtvalidade_Visible ;
      private int edtavTfprodutodtvalidade_to_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV78PageToGo ;
      private int imgAdddynamicfilters1_Visible ;
      private int imgRemovedynamicfilters1_Visible ;
      private int imgAdddynamicfilters2_Visible ;
      private int imgRemovedynamicfilters2_Visible ;
      private int edtavProdutonome1_Visible ;
      private int edtavProdutonome2_Visible ;
      private int edtavProdutonome3_Visible ;
      private int AV109GXV1 ;
      private int AV110GXV2 ;
      private int edtavProdutodtvalidade_Enabled ;
      private int edtavProdutodtvalidade_to_Enabled ;
      private int edtavProdutonome3_Enabled ;
      private int edtavProdutonome2_Enabled ;
      private int edtavProdutonome1_Enabled ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long AV79GridCurrentPage ;
      private long AV80GridPageCount ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private decimal AV68TFProdutoValor ;
      private decimal AV69TFProdutoValor_To ;
      private decimal A11ProdutoValor ;
      private decimal AV104ProdutoWWDS_18_Tfprodutovalor ;
      private decimal AV105ProdutoWWDS_19_Tfprodutovalor_to ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_produtoid_Activeeventkey ;
      private String Ddo_produtoid_Filteredtext_get ;
      private String Ddo_produtoid_Filteredtextto_get ;
      private String Ddo_produtonome_Activeeventkey ;
      private String Ddo_produtonome_Filteredtext_get ;
      private String Ddo_produtonome_Selectedvalue_get ;
      private String Ddo_produtovalor_Activeeventkey ;
      private String Ddo_produtovalor_Filteredtext_get ;
      private String Ddo_produtovalor_Filteredtextto_get ;
      private String Ddo_produtodtvalidade_Activeeventkey ;
      private String Ddo_produtodtvalidade_Filteredtext_get ;
      private String Ddo_produtodtvalidade_Filteredtextto_get ;
      private String Ddo_gridcolumnsselector_Columnsselectorvalues ;
      private String Ddo_managefilters_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_127_idx="0001" ;
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
      private String Ddo_produtoid_Caption ;
      private String Ddo_produtoid_Tooltip ;
      private String Ddo_produtoid_Cls ;
      private String Ddo_produtoid_Filteredtext_set ;
      private String Ddo_produtoid_Filteredtextto_set ;
      private String Ddo_produtoid_Dropdownoptionstype ;
      private String Ddo_produtoid_Titlecontrolidtoreplace ;
      private String Ddo_produtoid_Sortedstatus ;
      private String Ddo_produtoid_Filtertype ;
      private String Ddo_produtoid_Sortasc ;
      private String Ddo_produtoid_Sortdsc ;
      private String Ddo_produtoid_Cleanfilter ;
      private String Ddo_produtoid_Rangefilterfrom ;
      private String Ddo_produtoid_Rangefilterto ;
      private String Ddo_produtoid_Searchbuttontext ;
      private String Ddo_produtonome_Caption ;
      private String Ddo_produtonome_Tooltip ;
      private String Ddo_produtonome_Cls ;
      private String Ddo_produtonome_Filteredtext_set ;
      private String Ddo_produtonome_Selectedvalue_set ;
      private String Ddo_produtonome_Dropdownoptionstype ;
      private String Ddo_produtonome_Titlecontrolidtoreplace ;
      private String Ddo_produtonome_Sortedstatus ;
      private String Ddo_produtonome_Filtertype ;
      private String Ddo_produtonome_Datalisttype ;
      private String Ddo_produtonome_Datalistproc ;
      private String Ddo_produtonome_Sortasc ;
      private String Ddo_produtonome_Sortdsc ;
      private String Ddo_produtonome_Loadingdata ;
      private String Ddo_produtonome_Cleanfilter ;
      private String Ddo_produtonome_Noresultsfound ;
      private String Ddo_produtonome_Searchbuttontext ;
      private String Ddo_produtovalor_Caption ;
      private String Ddo_produtovalor_Tooltip ;
      private String Ddo_produtovalor_Cls ;
      private String Ddo_produtovalor_Filteredtext_set ;
      private String Ddo_produtovalor_Filteredtextto_set ;
      private String Ddo_produtovalor_Dropdownoptionstype ;
      private String Ddo_produtovalor_Titlecontrolidtoreplace ;
      private String Ddo_produtovalor_Sortedstatus ;
      private String Ddo_produtovalor_Filtertype ;
      private String Ddo_produtovalor_Sortasc ;
      private String Ddo_produtovalor_Sortdsc ;
      private String Ddo_produtovalor_Cleanfilter ;
      private String Ddo_produtovalor_Rangefilterfrom ;
      private String Ddo_produtovalor_Rangefilterto ;
      private String Ddo_produtovalor_Searchbuttontext ;
      private String Ddo_produtodtvalidade_Caption ;
      private String Ddo_produtodtvalidade_Tooltip ;
      private String Ddo_produtodtvalidade_Cls ;
      private String Ddo_produtodtvalidade_Filteredtext_set ;
      private String Ddo_produtodtvalidade_Filteredtextto_set ;
      private String Ddo_produtodtvalidade_Dropdownoptionstype ;
      private String Ddo_produtodtvalidade_Titlecontrolidtoreplace ;
      private String Ddo_produtodtvalidade_Sortedstatus ;
      private String Ddo_produtodtvalidade_Filtertype ;
      private String Ddo_produtodtvalidade_Sortasc ;
      private String Ddo_produtodtvalidade_Sortdsc ;
      private String Ddo_produtodtvalidade_Cleanfilter ;
      private String Ddo_produtodtvalidade_Rangefilterfrom ;
      private String Ddo_produtodtvalidade_Rangefilterto ;
      private String Ddo_produtodtvalidade_Searchbuttontext ;
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
      private String edtProdutoId_Title ;
      private String edtProdutoNome_Title ;
      private String edtProdutoValor_Title ;
      private String edtProdutoDtValidade_Title ;
      private String subGrid_Header ;
      private String AV81Update ;
      private String edtavUpdate_Link ;
      private String AV82Delete ;
      private String edtavDelete_Link ;
      private String edtProdutoNome_Link ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String lblJsdynamicfilters_Internalname ;
      private String lblJsdynamicfilters_Caption ;
      private String lblJsdynamicfilters_Jsonclick ;
      private String Ddo_produtoid_Internalname ;
      private String edtavDdo_produtoidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_produtonome_Internalname ;
      private String edtavDdo_produtonometitlecontrolidtoreplace_Internalname ;
      private String Ddo_produtovalor_Internalname ;
      private String edtavDdo_produtovalortitlecontrolidtoreplace_Internalname ;
      private String Ddo_produtodtvalidade_Internalname ;
      private String edtavDdo_produtodtvalidadetitlecontrolidtoreplace_Internalname ;
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
      private String edtavTfprodutoid_Internalname ;
      private String edtavTfprodutoid_Jsonclick ;
      private String edtavTfprodutoid_to_Internalname ;
      private String edtavTfprodutoid_to_Jsonclick ;
      private String edtavTfprodutonome_Internalname ;
      private String edtavTfprodutonome_Jsonclick ;
      private String edtavTfprodutonome_sel_Internalname ;
      private String edtavTfprodutonome_sel_Jsonclick ;
      private String edtavTfprodutovalor_Internalname ;
      private String edtavTfprodutovalor_Jsonclick ;
      private String edtavTfprodutovalor_to_Internalname ;
      private String edtavTfprodutovalor_to_Jsonclick ;
      private String edtavTfprodutodtvalidade_Internalname ;
      private String edtavTfprodutodtvalidade_Jsonclick ;
      private String edtavTfprodutodtvalidade_to_Internalname ;
      private String edtavTfprodutodtvalidade_to_Jsonclick ;
      private String divDdo_produtodtvalidadeauxdates_Internalname ;
      private String edtavDdo_produtodtvalidadeauxdate_Internalname ;
      private String edtavDdo_produtodtvalidadeauxdate_Jsonclick ;
      private String edtavDdo_produtodtvalidadeauxdateto_Internalname ;
      private String edtavDdo_produtodtvalidadeauxdateto_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavUpdate_Internalname ;
      private String edtavDelete_Internalname ;
      private String edtProdutoId_Internalname ;
      private String edtProdutoNome_Internalname ;
      private String edtProdutoDescricao_Internalname ;
      private String edtProdutoValor_Internalname ;
      private String edtProdutoDtValidade_Internalname ;
      private String cmbavDynamicfiltersselector1_Internalname ;
      private String cmbavDynamicfiltersoperator1_Internalname ;
      private String cmbavDynamicfiltersselector2_Internalname ;
      private String cmbavDynamicfiltersoperator2_Internalname ;
      private String cmbavDynamicfiltersselector3_Internalname ;
      private String cmbavDynamicfiltersoperator3_Internalname ;
      private String scmdbuf ;
      private String edtavProdutonome1_Internalname ;
      private String edtavProdutonome2_Internalname ;
      private String edtavProdutonome3_Internalname ;
      private String edtavProdutodtvalidade_Internalname ;
      private String edtavProdutodtvalidade_to_Internalname ;
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
      private String tblTablerightheader_Internalname ;
      private String Ddo_managefilters_Caption ;
      private String tblTablefilters_Internalname ;
      private String divTablesplittedfiltertextprodutodtvalidade_Internalname ;
      private String lblFiltertextprodutodtvalidade_Internalname ;
      private String lblFiltertextprodutodtvalidade_Jsonclick ;
      private String tblTablemergedprodutodtvalidade_Internalname ;
      private String edtavProdutodtvalidade_Jsonclick ;
      private String lblProdutodtvalidade_rangemiddletext_Internalname ;
      private String lblProdutodtvalidade_rangemiddletext_Jsonclick ;
      private String edtavProdutodtvalidade_to_Jsonclick ;
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
      private String cellFilter_produtonome3_cell_Internalname ;
      private String edtavProdutonome3_Jsonclick ;
      private String tblUnnamedtabledynamicfilters_2_Internalname ;
      private String cellDynamicfilters_addfilter2_cell_Internalname ;
      private String cellDynamicfilters_removefilter2_cell_Internalname ;
      private String tblTablemergeddynamicfilters2_Internalname ;
      private String cmbavDynamicfiltersoperator2_Jsonclick ;
      private String cellFilter_produtonome2_cell_Internalname ;
      private String edtavProdutonome2_Jsonclick ;
      private String tblUnnamedtabledynamicfilters_1_Internalname ;
      private String cellDynamicfilters_addfilter1_cell_Internalname ;
      private String cellDynamicfilters_removefilter1_cell_Internalname ;
      private String tblTablemergeddynamicfilters1_Internalname ;
      private String cmbavDynamicfiltersoperator1_Jsonclick ;
      private String cellFilter_produtonome1_cell_Internalname ;
      private String edtavProdutonome1_Jsonclick ;
      private String sGXsfl_127_fel_idx="0001" ;
      private String ROClassString ;
      private String edtavUpdate_Jsonclick ;
      private String edtavDelete_Jsonclick ;
      private String edtProdutoId_Jsonclick ;
      private String edtProdutoNome_Jsonclick ;
      private String edtProdutoDescricao_Jsonclick ;
      private String edtProdutoValor_Jsonclick ;
      private String edtProdutoDtValidade_Jsonclick ;
      private DateTime AV83ProdutoDtValidade ;
      private DateTime AV84ProdutoDtValidade_To ;
      private DateTime AV72TFProdutoDtValidade ;
      private DateTime AV73TFProdutoDtValidade_To ;
      private DateTime A12ProdutoDtValidade ;
      private DateTime AV74DDO_ProdutoDtValidadeAuxDate ;
      private DateTime AV75DDO_ProdutoDtValidadeAuxDateTo ;
      private DateTime AV87ProdutoWWDS_1_Produtodtvalidade ;
      private DateTime AV88ProdutoWWDS_2_Produtodtvalidade_to ;
      private DateTime AV106ProdutoWWDS_20_Tfprodutodtvalidade ;
      private DateTime AV107ProdutoWWDS_21_Tfprodutodtvalidade_to ;
      private bool entryPointCalled ;
      private bool AV19DynamicFiltersEnabled2 ;
      private bool AV23DynamicFiltersEnabled3 ;
      private bool AV14OrderedDsc ;
      private bool AV28DynamicFiltersIgnoreFirst ;
      private bool AV27DynamicFiltersRemoving ;
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
      private bool Ddo_produtoid_Includesortasc ;
      private bool Ddo_produtoid_Includesortdsc ;
      private bool Ddo_produtoid_Includefilter ;
      private bool Ddo_produtoid_Filterisrange ;
      private bool Ddo_produtoid_Includedatalist ;
      private bool Ddo_produtonome_Includesortasc ;
      private bool Ddo_produtonome_Includesortdsc ;
      private bool Ddo_produtonome_Includefilter ;
      private bool Ddo_produtonome_Filterisrange ;
      private bool Ddo_produtonome_Includedatalist ;
      private bool Ddo_produtovalor_Includesortasc ;
      private bool Ddo_produtovalor_Includesortdsc ;
      private bool Ddo_produtovalor_Includefilter ;
      private bool Ddo_produtovalor_Filterisrange ;
      private bool Ddo_produtovalor_Includedatalist ;
      private bool Ddo_produtodtvalidade_Includesortasc ;
      private bool Ddo_produtodtvalidade_Includesortdsc ;
      private bool Ddo_produtodtvalidade_Includefilter ;
      private bool Ddo_produtodtvalidade_Filterisrange ;
      private bool Ddo_produtodtvalidade_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_127_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool AV92ProdutoWWDS_6_Dynamicfiltersenabled2 ;
      private bool AV96ProdutoWWDS_10_Dynamicfiltersenabled3 ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private String AV29ColumnsSelectorXML ;
      private String AV50ManageFiltersXml ;
      private String AV36UserCustomValue ;
      private String AV16DynamicFiltersSelector1 ;
      private String AV18ProdutoNome1 ;
      private String AV20DynamicFiltersSelector2 ;
      private String AV22ProdutoNome2 ;
      private String AV24DynamicFiltersSelector3 ;
      private String AV26ProdutoNome3 ;
      private String AV60TFProdutoNome ;
      private String AV61TFProdutoNome_Sel ;
      private String AV58ddo_ProdutoIdTitleControlIdToReplace ;
      private String AV62ddo_ProdutoNomeTitleControlIdToReplace ;
      private String AV70ddo_ProdutoValorTitleControlIdToReplace ;
      private String AV76ddo_ProdutoDtValidadeTitleControlIdToReplace ;
      private String A9ProdutoNome ;
      private String A10ProdutoDescricao ;
      private String lV91ProdutoWWDS_5_Produtonome1 ;
      private String lV95ProdutoWWDS_9_Produtonome2 ;
      private String lV99ProdutoWWDS_13_Produtonome3 ;
      private String lV102ProdutoWWDS_16_Tfprodutonome ;
      private String AV89ProdutoWWDS_3_Dynamicfiltersselector1 ;
      private String AV91ProdutoWWDS_5_Produtonome1 ;
      private String AV93ProdutoWWDS_7_Dynamicfiltersselector2 ;
      private String AV95ProdutoWWDS_9_Produtonome2 ;
      private String AV97ProdutoWWDS_11_Dynamicfiltersselector3 ;
      private String AV99ProdutoWWDS_13_Produtonome3 ;
      private String AV103ProdutoWWDS_17_Tfprodutonome_sel ;
      private String AV102ProdutoWWDS_16_Tfprodutonome ;
      private IGxSession AV48Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_produtoid ;
      private GXUserControl ucDdo_produtonome ;
      private GXUserControl ucDdo_produtovalor ;
      private GXUserControl ucDdo_produtodtvalidade ;
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
      private GXCheckbox chkavDynamicfiltersenabled2 ;
      private GXCheckbox chkavDynamicfiltersenabled3 ;
      private IDataStoreProvider pr_default ;
      private DateTime[] H000R2_A12ProdutoDtValidade ;
      private decimal[] H000R2_A11ProdutoValor ;
      private String[] H000R2_A10ProdutoDescricao ;
      private String[] H000R2_A9ProdutoNome ;
      private short[] H000R2_A8ProdutoId ;
      private long[] H000R3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV7HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item> AV51ManageFiltersItems ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV53ManageFiltersData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV55ProdutoIdTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV59ProdutoNomeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV67ProdutoValorTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV71ProdutoDtValidadeTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV8TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV10GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV11GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter AV12GridStateDynamicFilter ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector AV41ColumnsSelector ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector AV42ColumnsSelectorAux ;
      private GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item AV52ManageFiltersItem ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item AV54ManageFiltersDataItem ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV77DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class produtoww__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H000R2( IGxContext context ,
                                             DateTime AV87ProdutoWWDS_1_Produtodtvalidade ,
                                             DateTime AV88ProdutoWWDS_2_Produtodtvalidade_to ,
                                             String AV89ProdutoWWDS_3_Dynamicfiltersselector1 ,
                                             short AV90ProdutoWWDS_4_Dynamicfiltersoperator1 ,
                                             String AV91ProdutoWWDS_5_Produtonome1 ,
                                             bool AV92ProdutoWWDS_6_Dynamicfiltersenabled2 ,
                                             String AV93ProdutoWWDS_7_Dynamicfiltersselector2 ,
                                             short AV94ProdutoWWDS_8_Dynamicfiltersoperator2 ,
                                             String AV95ProdutoWWDS_9_Produtonome2 ,
                                             bool AV96ProdutoWWDS_10_Dynamicfiltersenabled3 ,
                                             String AV97ProdutoWWDS_11_Dynamicfiltersselector3 ,
                                             short AV98ProdutoWWDS_12_Dynamicfiltersoperator3 ,
                                             String AV99ProdutoWWDS_13_Produtonome3 ,
                                             short AV100ProdutoWWDS_14_Tfprodutoid ,
                                             short AV101ProdutoWWDS_15_Tfprodutoid_to ,
                                             String AV103ProdutoWWDS_17_Tfprodutonome_sel ,
                                             String AV102ProdutoWWDS_16_Tfprodutonome ,
                                             decimal AV104ProdutoWWDS_18_Tfprodutovalor ,
                                             decimal AV105ProdutoWWDS_19_Tfprodutovalor_to ,
                                             DateTime AV106ProdutoWWDS_20_Tfprodutodtvalidade ,
                                             DateTime AV107ProdutoWWDS_21_Tfprodutodtvalidade_to ,
                                             DateTime A12ProdutoDtValidade ,
                                             String A9ProdutoNome ,
                                             short A8ProdutoId ,
                                             decimal A11ProdutoValor ,
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
         sSelectString = " [ProdutoDtValidade], [ProdutoValor], [ProdutoDescricao], [ProdutoNome], [ProdutoId]";
         sFromString = " FROM [Produto]";
         sOrderString = "";
         if ( ! (DateTime.MinValue==AV87ProdutoWWDS_1_Produtodtvalidade) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoDtValidade] >= @AV87ProdutoWWDS_1_Produtodtvalidade)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoDtValidade] >= @AV87ProdutoWWDS_1_Produtodtvalidade)";
            }
         }
         else
         {
            GXv_int3[0] = 1;
         }
         if ( ! (DateTime.MinValue==AV88ProdutoWWDS_2_Produtodtvalidade_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoDtValidade] <= @AV88ProdutoWWDS_2_Produtodtvalidade_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoDtValidade] <= @AV88ProdutoWWDS_2_Produtodtvalidade_to)";
            }
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ( StringUtil.StrCmp(AV89ProdutoWWDS_3_Dynamicfiltersselector1, "PRODUTONOME") == 0 ) && ( AV90ProdutoWWDS_4_Dynamicfiltersoperator1 == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV91ProdutoWWDS_5_Produtonome1)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoNome] like @lV91ProdutoWWDS_5_Produtonome1)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoNome] like @lV91ProdutoWWDS_5_Produtonome1)";
            }
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ( StringUtil.StrCmp(AV89ProdutoWWDS_3_Dynamicfiltersselector1, "PRODUTONOME") == 0 ) && ( AV90ProdutoWWDS_4_Dynamicfiltersoperator1 == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV91ProdutoWWDS_5_Produtonome1)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoNome] like '%' + @lV91ProdutoWWDS_5_Produtonome1)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoNome] like '%' + @lV91ProdutoWWDS_5_Produtonome1)";
            }
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( AV92ProdutoWWDS_6_Dynamicfiltersenabled2 && ( StringUtil.StrCmp(AV93ProdutoWWDS_7_Dynamicfiltersselector2, "PRODUTONOME") == 0 ) && ( AV94ProdutoWWDS_8_Dynamicfiltersoperator2 == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV95ProdutoWWDS_9_Produtonome2)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoNome] like @lV95ProdutoWWDS_9_Produtonome2)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoNome] like @lV95ProdutoWWDS_9_Produtonome2)";
            }
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( AV92ProdutoWWDS_6_Dynamicfiltersenabled2 && ( StringUtil.StrCmp(AV93ProdutoWWDS_7_Dynamicfiltersselector2, "PRODUTONOME") == 0 ) && ( AV94ProdutoWWDS_8_Dynamicfiltersoperator2 == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV95ProdutoWWDS_9_Produtonome2)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoNome] like '%' + @lV95ProdutoWWDS_9_Produtonome2)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoNome] like '%' + @lV95ProdutoWWDS_9_Produtonome2)";
            }
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( AV96ProdutoWWDS_10_Dynamicfiltersenabled3 && ( StringUtil.StrCmp(AV97ProdutoWWDS_11_Dynamicfiltersselector3, "PRODUTONOME") == 0 ) && ( AV98ProdutoWWDS_12_Dynamicfiltersoperator3 == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV99ProdutoWWDS_13_Produtonome3)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoNome] like @lV99ProdutoWWDS_13_Produtonome3)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoNome] like @lV99ProdutoWWDS_13_Produtonome3)";
            }
         }
         else
         {
            GXv_int3[6] = 1;
         }
         if ( AV96ProdutoWWDS_10_Dynamicfiltersenabled3 && ( StringUtil.StrCmp(AV97ProdutoWWDS_11_Dynamicfiltersselector3, "PRODUTONOME") == 0 ) && ( AV98ProdutoWWDS_12_Dynamicfiltersoperator3 == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV99ProdutoWWDS_13_Produtonome3)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoNome] like '%' + @lV99ProdutoWWDS_13_Produtonome3)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoNome] like '%' + @lV99ProdutoWWDS_13_Produtonome3)";
            }
         }
         else
         {
            GXv_int3[7] = 1;
         }
         if ( ! (0==AV100ProdutoWWDS_14_Tfprodutoid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoId] >= @AV100ProdutoWWDS_14_Tfprodutoid)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoId] >= @AV100ProdutoWWDS_14_Tfprodutoid)";
            }
         }
         else
         {
            GXv_int3[8] = 1;
         }
         if ( ! (0==AV101ProdutoWWDS_15_Tfprodutoid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoId] <= @AV101ProdutoWWDS_15_Tfprodutoid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoId] <= @AV101ProdutoWWDS_15_Tfprodutoid_to)";
            }
         }
         else
         {
            GXv_int3[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV103ProdutoWWDS_17_Tfprodutonome_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV102ProdutoWWDS_16_Tfprodutonome)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoNome] like @lV102ProdutoWWDS_16_Tfprodutonome)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoNome] like @lV102ProdutoWWDS_16_Tfprodutonome)";
            }
         }
         else
         {
            GXv_int3[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV103ProdutoWWDS_17_Tfprodutonome_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoNome] = @AV103ProdutoWWDS_17_Tfprodutonome_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoNome] = @AV103ProdutoWWDS_17_Tfprodutonome_sel)";
            }
         }
         else
         {
            GXv_int3[11] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV104ProdutoWWDS_18_Tfprodutovalor) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoValor] >= @AV104ProdutoWWDS_18_Tfprodutovalor)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoValor] >= @AV104ProdutoWWDS_18_Tfprodutovalor)";
            }
         }
         else
         {
            GXv_int3[12] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV105ProdutoWWDS_19_Tfprodutovalor_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoValor] <= @AV105ProdutoWWDS_19_Tfprodutovalor_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoValor] <= @AV105ProdutoWWDS_19_Tfprodutovalor_to)";
            }
         }
         else
         {
            GXv_int3[13] = 1;
         }
         if ( ! (DateTime.MinValue==AV106ProdutoWWDS_20_Tfprodutodtvalidade) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoDtValidade] >= @AV106ProdutoWWDS_20_Tfprodutodtvalidade)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoDtValidade] >= @AV106ProdutoWWDS_20_Tfprodutodtvalidade)";
            }
         }
         else
         {
            GXv_int3[14] = 1;
         }
         if ( ! (DateTime.MinValue==AV107ProdutoWWDS_21_Tfprodutodtvalidade_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoDtValidade] <= @AV107ProdutoWWDS_21_Tfprodutodtvalidade_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoDtValidade] <= @AV107ProdutoWWDS_21_Tfprodutodtvalidade_to)";
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
            sOrderString = sOrderString + " ORDER BY [ProdutoNome]";
         }
         else if ( ( AV13OrderedBy == 1 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [ProdutoNome] DESC";
         }
         else if ( ( AV13OrderedBy == 2 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [ProdutoId]";
         }
         else if ( ( AV13OrderedBy == 2 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [ProdutoId] DESC";
         }
         else if ( ( AV13OrderedBy == 3 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [ProdutoValor]";
         }
         else if ( ( AV13OrderedBy == 3 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [ProdutoValor] DESC";
         }
         else if ( ( AV13OrderedBy == 4 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [ProdutoDtValidade]";
         }
         else if ( ( AV13OrderedBy == 4 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [ProdutoDtValidade] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [ProdutoId]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H000R3( IGxContext context ,
                                             DateTime AV87ProdutoWWDS_1_Produtodtvalidade ,
                                             DateTime AV88ProdutoWWDS_2_Produtodtvalidade_to ,
                                             String AV89ProdutoWWDS_3_Dynamicfiltersselector1 ,
                                             short AV90ProdutoWWDS_4_Dynamicfiltersoperator1 ,
                                             String AV91ProdutoWWDS_5_Produtonome1 ,
                                             bool AV92ProdutoWWDS_6_Dynamicfiltersenabled2 ,
                                             String AV93ProdutoWWDS_7_Dynamicfiltersselector2 ,
                                             short AV94ProdutoWWDS_8_Dynamicfiltersoperator2 ,
                                             String AV95ProdutoWWDS_9_Produtonome2 ,
                                             bool AV96ProdutoWWDS_10_Dynamicfiltersenabled3 ,
                                             String AV97ProdutoWWDS_11_Dynamicfiltersselector3 ,
                                             short AV98ProdutoWWDS_12_Dynamicfiltersoperator3 ,
                                             String AV99ProdutoWWDS_13_Produtonome3 ,
                                             short AV100ProdutoWWDS_14_Tfprodutoid ,
                                             short AV101ProdutoWWDS_15_Tfprodutoid_to ,
                                             String AV103ProdutoWWDS_17_Tfprodutonome_sel ,
                                             String AV102ProdutoWWDS_16_Tfprodutonome ,
                                             decimal AV104ProdutoWWDS_18_Tfprodutovalor ,
                                             decimal AV105ProdutoWWDS_19_Tfprodutovalor_to ,
                                             DateTime AV106ProdutoWWDS_20_Tfprodutodtvalidade ,
                                             DateTime AV107ProdutoWWDS_21_Tfprodutodtvalidade_to ,
                                             DateTime A12ProdutoDtValidade ,
                                             String A9ProdutoNome ,
                                             short A8ProdutoId ,
                                             decimal A11ProdutoValor ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [16] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [Produto]";
         if ( ! (DateTime.MinValue==AV87ProdutoWWDS_1_Produtodtvalidade) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoDtValidade] >= @AV87ProdutoWWDS_1_Produtodtvalidade)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoDtValidade] >= @AV87ProdutoWWDS_1_Produtodtvalidade)";
            }
         }
         else
         {
            GXv_int5[0] = 1;
         }
         if ( ! (DateTime.MinValue==AV88ProdutoWWDS_2_Produtodtvalidade_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoDtValidade] <= @AV88ProdutoWWDS_2_Produtodtvalidade_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoDtValidade] <= @AV88ProdutoWWDS_2_Produtodtvalidade_to)";
            }
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( ( StringUtil.StrCmp(AV89ProdutoWWDS_3_Dynamicfiltersselector1, "PRODUTONOME") == 0 ) && ( AV90ProdutoWWDS_4_Dynamicfiltersoperator1 == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV91ProdutoWWDS_5_Produtonome1)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoNome] like @lV91ProdutoWWDS_5_Produtonome1)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoNome] like @lV91ProdutoWWDS_5_Produtonome1)";
            }
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( ( StringUtil.StrCmp(AV89ProdutoWWDS_3_Dynamicfiltersselector1, "PRODUTONOME") == 0 ) && ( AV90ProdutoWWDS_4_Dynamicfiltersoperator1 == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV91ProdutoWWDS_5_Produtonome1)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoNome] like '%' + @lV91ProdutoWWDS_5_Produtonome1)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoNome] like '%' + @lV91ProdutoWWDS_5_Produtonome1)";
            }
         }
         else
         {
            GXv_int5[3] = 1;
         }
         if ( AV92ProdutoWWDS_6_Dynamicfiltersenabled2 && ( StringUtil.StrCmp(AV93ProdutoWWDS_7_Dynamicfiltersselector2, "PRODUTONOME") == 0 ) && ( AV94ProdutoWWDS_8_Dynamicfiltersoperator2 == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV95ProdutoWWDS_9_Produtonome2)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoNome] like @lV95ProdutoWWDS_9_Produtonome2)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoNome] like @lV95ProdutoWWDS_9_Produtonome2)";
            }
         }
         else
         {
            GXv_int5[4] = 1;
         }
         if ( AV92ProdutoWWDS_6_Dynamicfiltersenabled2 && ( StringUtil.StrCmp(AV93ProdutoWWDS_7_Dynamicfiltersselector2, "PRODUTONOME") == 0 ) && ( AV94ProdutoWWDS_8_Dynamicfiltersoperator2 == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV95ProdutoWWDS_9_Produtonome2)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoNome] like '%' + @lV95ProdutoWWDS_9_Produtonome2)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoNome] like '%' + @lV95ProdutoWWDS_9_Produtonome2)";
            }
         }
         else
         {
            GXv_int5[5] = 1;
         }
         if ( AV96ProdutoWWDS_10_Dynamicfiltersenabled3 && ( StringUtil.StrCmp(AV97ProdutoWWDS_11_Dynamicfiltersselector3, "PRODUTONOME") == 0 ) && ( AV98ProdutoWWDS_12_Dynamicfiltersoperator3 == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV99ProdutoWWDS_13_Produtonome3)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoNome] like @lV99ProdutoWWDS_13_Produtonome3)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoNome] like @lV99ProdutoWWDS_13_Produtonome3)";
            }
         }
         else
         {
            GXv_int5[6] = 1;
         }
         if ( AV96ProdutoWWDS_10_Dynamicfiltersenabled3 && ( StringUtil.StrCmp(AV97ProdutoWWDS_11_Dynamicfiltersselector3, "PRODUTONOME") == 0 ) && ( AV98ProdutoWWDS_12_Dynamicfiltersoperator3 == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV99ProdutoWWDS_13_Produtonome3)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoNome] like '%' + @lV99ProdutoWWDS_13_Produtonome3)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoNome] like '%' + @lV99ProdutoWWDS_13_Produtonome3)";
            }
         }
         else
         {
            GXv_int5[7] = 1;
         }
         if ( ! (0==AV100ProdutoWWDS_14_Tfprodutoid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoId] >= @AV100ProdutoWWDS_14_Tfprodutoid)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoId] >= @AV100ProdutoWWDS_14_Tfprodutoid)";
            }
         }
         else
         {
            GXv_int5[8] = 1;
         }
         if ( ! (0==AV101ProdutoWWDS_15_Tfprodutoid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoId] <= @AV101ProdutoWWDS_15_Tfprodutoid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoId] <= @AV101ProdutoWWDS_15_Tfprodutoid_to)";
            }
         }
         else
         {
            GXv_int5[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV103ProdutoWWDS_17_Tfprodutonome_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV102ProdutoWWDS_16_Tfprodutonome)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoNome] like @lV102ProdutoWWDS_16_Tfprodutonome)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoNome] like @lV102ProdutoWWDS_16_Tfprodutonome)";
            }
         }
         else
         {
            GXv_int5[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV103ProdutoWWDS_17_Tfprodutonome_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoNome] = @AV103ProdutoWWDS_17_Tfprodutonome_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoNome] = @AV103ProdutoWWDS_17_Tfprodutonome_sel)";
            }
         }
         else
         {
            GXv_int5[11] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV104ProdutoWWDS_18_Tfprodutovalor) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoValor] >= @AV104ProdutoWWDS_18_Tfprodutovalor)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoValor] >= @AV104ProdutoWWDS_18_Tfprodutovalor)";
            }
         }
         else
         {
            GXv_int5[12] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV105ProdutoWWDS_19_Tfprodutovalor_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoValor] <= @AV105ProdutoWWDS_19_Tfprodutovalor_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoValor] <= @AV105ProdutoWWDS_19_Tfprodutovalor_to)";
            }
         }
         else
         {
            GXv_int5[13] = 1;
         }
         if ( ! (DateTime.MinValue==AV106ProdutoWWDS_20_Tfprodutodtvalidade) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoDtValidade] >= @AV106ProdutoWWDS_20_Tfprodutodtvalidade)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoDtValidade] >= @AV106ProdutoWWDS_20_Tfprodutodtvalidade)";
            }
         }
         else
         {
            GXv_int5[14] = 1;
         }
         if ( ! (DateTime.MinValue==AV107ProdutoWWDS_21_Tfprodutodtvalidade_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoDtValidade] <= @AV107ProdutoWWDS_21_Tfprodutodtvalidade_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoDtValidade] <= @AV107ProdutoWWDS_21_Tfprodutodtvalidade_to)";
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
                     return conditional_H000R2(context, (DateTime)dynConstraints[0] , (DateTime)dynConstraints[1] , (String)dynConstraints[2] , (short)dynConstraints[3] , (String)dynConstraints[4] , (bool)dynConstraints[5] , (String)dynConstraints[6] , (short)dynConstraints[7] , (String)dynConstraints[8] , (bool)dynConstraints[9] , (String)dynConstraints[10] , (short)dynConstraints[11] , (String)dynConstraints[12] , (short)dynConstraints[13] , (short)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (decimal)dynConstraints[17] , (decimal)dynConstraints[18] , (DateTime)dynConstraints[19] , (DateTime)dynConstraints[20] , (DateTime)dynConstraints[21] , (String)dynConstraints[22] , (short)dynConstraints[23] , (decimal)dynConstraints[24] , (short)dynConstraints[25] , (bool)dynConstraints[26] );
               case 1 :
                     return conditional_H000R3(context, (DateTime)dynConstraints[0] , (DateTime)dynConstraints[1] , (String)dynConstraints[2] , (short)dynConstraints[3] , (String)dynConstraints[4] , (bool)dynConstraints[5] , (String)dynConstraints[6] , (short)dynConstraints[7] , (String)dynConstraints[8] , (bool)dynConstraints[9] , (String)dynConstraints[10] , (short)dynConstraints[11] , (String)dynConstraints[12] , (short)dynConstraints[13] , (short)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (decimal)dynConstraints[17] , (decimal)dynConstraints[18] , (DateTime)dynConstraints[19] , (DateTime)dynConstraints[20] , (DateTime)dynConstraints[21] , (String)dynConstraints[22] , (short)dynConstraints[23] , (decimal)dynConstraints[24] , (short)dynConstraints[25] , (bool)dynConstraints[26] );
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
          Object[] prmH000R2 ;
          prmH000R2 = new Object[] {
          new Object[] {"@AV87ProdutoWWDS_1_Produtodtvalidade",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV88ProdutoWWDS_2_Produtodtvalidade_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@lV91ProdutoWWDS_5_Produtonome1",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV91ProdutoWWDS_5_Produtonome1",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV95ProdutoWWDS_9_Produtonome2",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV95ProdutoWWDS_9_Produtonome2",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV99ProdutoWWDS_13_Produtonome3",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV99ProdutoWWDS_13_Produtonome3",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV100ProdutoWWDS_14_Tfprodutoid",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV101ProdutoWWDS_15_Tfprodutoid_to",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV102ProdutoWWDS_16_Tfprodutonome",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV103ProdutoWWDS_17_Tfprodutonome_sel",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV104ProdutoWWDS_18_Tfprodutovalor",SqlDbType.Decimal,12,2} ,
          new Object[] {"@AV105ProdutoWWDS_19_Tfprodutovalor_to",SqlDbType.Decimal,12,2} ,
          new Object[] {"@AV106ProdutoWWDS_20_Tfprodutodtvalidade",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV107ProdutoWWDS_21_Tfprodutodtvalidade_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH000R3 ;
          prmH000R3 = new Object[] {
          new Object[] {"@AV87ProdutoWWDS_1_Produtodtvalidade",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV88ProdutoWWDS_2_Produtodtvalidade_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@lV91ProdutoWWDS_5_Produtonome1",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV91ProdutoWWDS_5_Produtonome1",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV95ProdutoWWDS_9_Produtonome2",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV95ProdutoWWDS_9_Produtonome2",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV99ProdutoWWDS_13_Produtonome3",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV99ProdutoWWDS_13_Produtonome3",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV100ProdutoWWDS_14_Tfprodutoid",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV101ProdutoWWDS_15_Tfprodutoid_to",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV102ProdutoWWDS_16_Tfprodutonome",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV103ProdutoWWDS_17_Tfprodutonome_sel",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV104ProdutoWWDS_18_Tfprodutovalor",SqlDbType.Decimal,12,2} ,
          new Object[] {"@AV105ProdutoWWDS_19_Tfprodutovalor_to",SqlDbType.Decimal,12,2} ,
          new Object[] {"@AV106ProdutoWWDS_20_Tfprodutodtvalidade",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV107ProdutoWWDS_21_Tfprodutodtvalidade_to",SqlDbType.DateTime,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000R2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000R2,11, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("H000R3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000R3,1, GxCacheFrequency.OFF ,true,false )
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
                ((DateTime[]) buf[0])[0] = rslt.getGXDate(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
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
                   stmt.SetParameter(sIdx, (DateTime)parms[19]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[20]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[23]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[24]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[25]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[26]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[27]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[28]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[29]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[30]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[31]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[32]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[33]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[34]);
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
                   stmt.SetParameter(sIdx, (DateTime)parms[16]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[17]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[20]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[23]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[24]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[25]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[26]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[27]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[28]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[29]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[30]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[31]);
                }
                return;
       }
    }

 }

}
