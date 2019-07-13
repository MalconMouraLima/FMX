/*
               File: ProdutoPrompt
        Description: Consulta de Produto
             Author: GeneXus C# Generator version 16_0_2-131213
       Generated on: 7/12/2019 17:59:38.20
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
   public class produtoprompt : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public produtoprompt( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public produtoprompt( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( ref short aP0_InOutProdutoId ,
                           ref String aP1_InOutProdutoNome )
      {
         this.AV42InOutProdutoId = aP0_InOutProdutoId;
         this.AV43InOutProdutoNome = aP1_InOutProdutoNome;
         executePrivate();
         aP0_InOutProdutoId=this.AV42InOutProdutoId;
         aP1_InOutProdutoNome=this.AV43InOutProdutoNome;
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
               nRC_GXsfl_95 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_95_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_95_idx = GetNextPar( );
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
               AV15ProdutoNome1 = GetNextPar( );
               AV17DynamicFiltersSelector2 = GetNextPar( );
               AV18DynamicFiltersOperator2 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV19ProdutoNome2 = GetNextPar( );
               AV21DynamicFiltersSelector3 = GetNextPar( );
               AV22DynamicFiltersOperator3 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV23ProdutoNome3 = GetNextPar( );
               AV16DynamicFiltersEnabled2 = StringUtil.StrToBool( GetNextPar( ));
               AV20DynamicFiltersEnabled3 = StringUtil.StrToBool( GetNextPar( ));
               AV11OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV12OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV28ddo_ProdutoIdTitleControlIdToReplace = GetNextPar( );
               AV30ddo_ProdutoNomeTitleControlIdToReplace = GetNextPar( );
               AV32ddo_ProdutoDescricaoTitleControlIdToReplace = GetNextPar( );
               AV34ddo_ProdutoValorTitleControlIdToReplace = GetNextPar( );
               AV36ddo_ProdutoDtValidadeTitleControlIdToReplace = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15ProdutoNome1, AV17DynamicFiltersSelector2, AV18DynamicFiltersOperator2, AV19ProdutoNome2, AV21DynamicFiltersSelector3, AV22DynamicFiltersOperator3, AV23ProdutoNome3, AV16DynamicFiltersEnabled2, AV20DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV28ddo_ProdutoIdTitleControlIdToReplace, AV30ddo_ProdutoNomeTitleControlIdToReplace, AV32ddo_ProdutoDescricaoTitleControlIdToReplace, AV34ddo_ProdutoValorTitleControlIdToReplace, AV36ddo_ProdutoDtValidadeTitleControlIdToReplace) ;
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
               AV42InOutProdutoId = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42InOutProdutoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV42InOutProdutoId), 4, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV43InOutProdutoNome = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43InOutProdutoNome", AV43InOutProdutoNome);
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
         PA0S2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0S2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?201971217593840", false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal FormNoBackgroundColor\" data-gx-class=\"form-horizontal FormNoBackgroundColor\" novalidate action=\""+formatLink("produtoprompt.aspx") + "?" + UrlEncode("" +AV42InOutProdutoId) + "," + UrlEncode(StringUtil.RTrim(AV43InOutProdutoNome))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vPRODUTONOME1", AV15ProdutoNome1);
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSSELECTOR2", AV17DynamicFiltersSelector2);
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSOPERATOR2", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18DynamicFiltersOperator2), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vPRODUTONOME2", AV19ProdutoNome2);
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSSELECTOR3", AV21DynamicFiltersSelector3);
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSOPERATOR3", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22DynamicFiltersOperator3), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vPRODUTONOME3", AV23ProdutoNome3);
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSENABLED2", StringUtil.BoolToStr( AV16DynamicFiltersEnabled2));
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSENABLED3", StringUtil.BoolToStr( AV20DynamicFiltersEnabled3));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11OrderedBy), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV12OrderedDsc));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_95", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_95), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV39GridCurrentPage), 10, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGECOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV40GridPageCount), 10, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV37DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV37DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPRODUTOIDTITLEFILTERDATA", AV27ProdutoIdTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPRODUTOIDTITLEFILTERDATA", AV27ProdutoIdTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPRODUTONOMETITLEFILTERDATA", AV29ProdutoNomeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPRODUTONOMETITLEFILTERDATA", AV29ProdutoNomeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPRODUTODESCRICAOTITLEFILTERDATA", AV31ProdutoDescricaoTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPRODUTODESCRICAOTITLEFILTERDATA", AV31ProdutoDescricaoTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPRODUTOVALORTITLEFILTERDATA", AV33ProdutoValorTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPRODUTOVALORTITLEFILTERDATA", AV33ProdutoValorTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPRODUTODTVALIDADETITLEFILTERDATA", AV35ProdutoDtValidadeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPRODUTODTVALIDADETITLEFILTERDATA", AV35ProdutoDtValidadeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vGRIDSTATE", AV8GridState);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vGRIDSTATE", AV8GridState);
         }
         GxWebStd.gx_boolean_hidden_field( context, "vDYNAMICFILTERSIGNOREFIRST", AV25DynamicFiltersIgnoreFirst);
         GxWebStd.gx_boolean_hidden_field( context, "vDYNAMICFILTERSREMOVING", AV24DynamicFiltersRemoving);
         GxWebStd.gx_hidden_field( context, "vINOUTPRODUTOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV42InOutProdutoId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vINOUTPRODUTONOME", AV43InOutProdutoNome);
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
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Caption", StringUtil.RTrim( Ddo_produtoid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Tooltip", StringUtil.RTrim( Ddo_produtoid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Cls", StringUtil.RTrim( Ddo_produtoid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Dropdownoptionstype", StringUtil.RTrim( Ddo_produtoid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_produtoid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Includesortasc", StringUtil.BoolToStr( Ddo_produtoid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Includesortdsc", StringUtil.BoolToStr( Ddo_produtoid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Sortedstatus", StringUtil.RTrim( Ddo_produtoid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Includefilter", StringUtil.BoolToStr( Ddo_produtoid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Includedatalist", StringUtil.BoolToStr( Ddo_produtoid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Sortasc", StringUtil.RTrim( Ddo_produtoid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Sortdsc", StringUtil.RTrim( Ddo_produtoid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Cleanfilter", StringUtil.RTrim( Ddo_produtoid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Searchbuttontext", StringUtil.RTrim( Ddo_produtoid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Caption", StringUtil.RTrim( Ddo_produtonome_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Tooltip", StringUtil.RTrim( Ddo_produtonome_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Cls", StringUtil.RTrim( Ddo_produtonome_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Dropdownoptionstype", StringUtil.RTrim( Ddo_produtonome_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_produtonome_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Includesortasc", StringUtil.BoolToStr( Ddo_produtonome_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Includesortdsc", StringUtil.BoolToStr( Ddo_produtonome_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Sortedstatus", StringUtil.RTrim( Ddo_produtonome_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Includefilter", StringUtil.BoolToStr( Ddo_produtonome_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Includedatalist", StringUtil.BoolToStr( Ddo_produtonome_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Sortasc", StringUtil.RTrim( Ddo_produtonome_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Sortdsc", StringUtil.RTrim( Ddo_produtonome_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Cleanfilter", StringUtil.RTrim( Ddo_produtonome_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Searchbuttontext", StringUtil.RTrim( Ddo_produtonome_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODESCRICAO_Caption", StringUtil.RTrim( Ddo_produtodescricao_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODESCRICAO_Tooltip", StringUtil.RTrim( Ddo_produtodescricao_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODESCRICAO_Cls", StringUtil.RTrim( Ddo_produtodescricao_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODESCRICAO_Dropdownoptionstype", StringUtil.RTrim( Ddo_produtodescricao_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODESCRICAO_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_produtodescricao_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODESCRICAO_Includesortasc", StringUtil.BoolToStr( Ddo_produtodescricao_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODESCRICAO_Includesortdsc", StringUtil.BoolToStr( Ddo_produtodescricao_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODESCRICAO_Sortedstatus", StringUtil.RTrim( Ddo_produtodescricao_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODESCRICAO_Includefilter", StringUtil.BoolToStr( Ddo_produtodescricao_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODESCRICAO_Includedatalist", StringUtil.BoolToStr( Ddo_produtodescricao_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODESCRICAO_Sortasc", StringUtil.RTrim( Ddo_produtodescricao_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODESCRICAO_Sortdsc", StringUtil.RTrim( Ddo_produtodescricao_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODESCRICAO_Cleanfilter", StringUtil.RTrim( Ddo_produtodescricao_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODESCRICAO_Searchbuttontext", StringUtil.RTrim( Ddo_produtodescricao_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Caption", StringUtil.RTrim( Ddo_produtovalor_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Tooltip", StringUtil.RTrim( Ddo_produtovalor_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Cls", StringUtil.RTrim( Ddo_produtovalor_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Dropdownoptionstype", StringUtil.RTrim( Ddo_produtovalor_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_produtovalor_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Includesortasc", StringUtil.BoolToStr( Ddo_produtovalor_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Includesortdsc", StringUtil.BoolToStr( Ddo_produtovalor_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Sortedstatus", StringUtil.RTrim( Ddo_produtovalor_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Includefilter", StringUtil.BoolToStr( Ddo_produtovalor_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Includedatalist", StringUtil.BoolToStr( Ddo_produtovalor_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Sortasc", StringUtil.RTrim( Ddo_produtovalor_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Sortdsc", StringUtil.RTrim( Ddo_produtovalor_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Cleanfilter", StringUtil.RTrim( Ddo_produtovalor_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Searchbuttontext", StringUtil.RTrim( Ddo_produtovalor_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Caption", StringUtil.RTrim( Ddo_produtodtvalidade_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Tooltip", StringUtil.RTrim( Ddo_produtodtvalidade_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Cls", StringUtil.RTrim( Ddo_produtodtvalidade_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Dropdownoptionstype", StringUtil.RTrim( Ddo_produtodtvalidade_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_produtodtvalidade_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Includesortasc", StringUtil.BoolToStr( Ddo_produtodtvalidade_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Includesortdsc", StringUtil.BoolToStr( Ddo_produtodtvalidade_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Sortedstatus", StringUtil.RTrim( Ddo_produtodtvalidade_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Includefilter", StringUtil.BoolToStr( Ddo_produtodtvalidade_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Includedatalist", StringUtil.BoolToStr( Ddo_produtodtvalidade_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Sortasc", StringUtil.RTrim( Ddo_produtodtvalidade_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Sortdsc", StringUtil.RTrim( Ddo_produtodtvalidade_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Cleanfilter", StringUtil.RTrim( Ddo_produtodtvalidade_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Searchbuttontext", StringUtil.RTrim( Ddo_produtodtvalidade_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Activeeventkey", StringUtil.RTrim( Ddo_produtoid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Activeeventkey", StringUtil.RTrim( Ddo_produtonome_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODESCRICAO_Activeeventkey", StringUtil.RTrim( Ddo_produtodescricao_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Activeeventkey", StringUtil.RTrim( Ddo_produtovalor_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Activeeventkey", StringUtil.RTrim( Ddo_produtodtvalidade_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Activeeventkey", StringUtil.RTrim( Ddo_produtoid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Activeeventkey", StringUtil.RTrim( Ddo_produtonome_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODESCRICAO_Activeeventkey", StringUtil.RTrim( Ddo_produtodescricao_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Activeeventkey", StringUtil.RTrim( Ddo_produtovalor_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTODTVALIDADE_Activeeventkey", StringUtil.RTrim( Ddo_produtodtvalidade_Activeeventkey));
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
            WE0S2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0S2( ) ;
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
         return formatLink("produtoprompt.aspx") + "?" + UrlEncode("" +AV42InOutProdutoId) + "," + UrlEncode(StringUtil.RTrim(AV43InOutProdutoNome)) ;
      }

      public override String GetPgmname( )
      {
         return "ProdutoPrompt" ;
      }

      public override String GetPgmdesc( )
      {
         return "Consulta de Produto" ;
      }

      protected void WB0S0( )
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
            wb_table1_14_0S2( true) ;
         }
         else
         {
            wb_table1_14_0S2( false) ;
         }
         return  ;
      }

      protected void wb_table1_14_0S2e( bool wbgen )
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
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"95\">") ;
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
               if ( edtProdutoId_Titleformat == 0 )
               {
                  context.SendWebValue( edtProdutoId_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtProdutoId_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtProdutoNome_Titleformat == 0 )
               {
                  context.SendWebValue( edtProdutoNome_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtProdutoNome_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtProdutoDescricao_Titleformat == 0 )
               {
                  context.SendWebValue( edtProdutoDescricao_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtProdutoDescricao_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtProdutoValor_Titleformat == 0 )
               {
                  context.SendWebValue( edtProdutoValor_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtProdutoValor_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV41Select));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavSelect_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A8ProdutoId), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtProdutoId_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProdutoId_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A9ProdutoNome);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtProdutoNome_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProdutoNome_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A10ProdutoDescricao);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtProdutoDescricao_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProdutoDescricao_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A11ProdutoValor, 12, 2, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtProdutoValor_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProdutoValor_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A12ProdutoDtValidade, "99/99/99"));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtProdutoDtValidade_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProdutoDtValidade_Titleformat), 4, 0, ".", "")));
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
         if ( wbEnd == 95 )
         {
            wbEnd = 0;
            nRC_GXsfl_95 = (short)(nGXsfl_95_idx-1);
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV39GridCurrentPage);
            ucGridpaginationbar.SetProperty("PageCount", AV40GridPageCount);
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
            GxWebStd.gx_label_ctrl( context, lblJsdynamicfilters_Internalname, lblJsdynamicfilters_Caption, "", "", lblJsdynamicfilters_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "", 0, "", 1, 1, 1, "HLP_ProdutoPrompt.htm");
            /* User Defined Control */
            ucDdo_produtoid.SetProperty("Caption", Ddo_produtoid_Caption);
            ucDdo_produtoid.SetProperty("Tooltip", Ddo_produtoid_Tooltip);
            ucDdo_produtoid.SetProperty("Cls", Ddo_produtoid_Cls);
            ucDdo_produtoid.SetProperty("DropDownOptionsType", Ddo_produtoid_Dropdownoptionstype);
            ucDdo_produtoid.SetProperty("IncludeSortASC", Ddo_produtoid_Includesortasc);
            ucDdo_produtoid.SetProperty("IncludeSortDSC", Ddo_produtoid_Includesortdsc);
            ucDdo_produtoid.SetProperty("IncludeFilter", Ddo_produtoid_Includefilter);
            ucDdo_produtoid.SetProperty("IncludeDataList", Ddo_produtoid_Includedatalist);
            ucDdo_produtoid.SetProperty("SortASC", Ddo_produtoid_Sortasc);
            ucDdo_produtoid.SetProperty("SortDSC", Ddo_produtoid_Sortdsc);
            ucDdo_produtoid.SetProperty("CleanFilter", Ddo_produtoid_Cleanfilter);
            ucDdo_produtoid.SetProperty("SearchButtonText", Ddo_produtoid_Searchbuttontext);
            ucDdo_produtoid.SetProperty("DropDownOptionsTitleSettingsIcons", AV37DDO_TitleSettingsIcons);
            ucDdo_produtoid.SetProperty("DropDownOptionsData", AV27ProdutoIdTitleFilterData);
            ucDdo_produtoid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_produtoid_Internalname, "DDO_PRODUTOIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 110,'',false,'" + sGXsfl_95_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_produtoidtitlecontrolidtoreplace_Internalname, AV28ddo_ProdutoIdTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,110);\"", 0, edtavDdo_produtoidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_ProdutoPrompt.htm");
            /* User Defined Control */
            ucDdo_produtonome.SetProperty("Caption", Ddo_produtonome_Caption);
            ucDdo_produtonome.SetProperty("Tooltip", Ddo_produtonome_Tooltip);
            ucDdo_produtonome.SetProperty("Cls", Ddo_produtonome_Cls);
            ucDdo_produtonome.SetProperty("DropDownOptionsType", Ddo_produtonome_Dropdownoptionstype);
            ucDdo_produtonome.SetProperty("IncludeSortASC", Ddo_produtonome_Includesortasc);
            ucDdo_produtonome.SetProperty("IncludeSortDSC", Ddo_produtonome_Includesortdsc);
            ucDdo_produtonome.SetProperty("IncludeFilter", Ddo_produtonome_Includefilter);
            ucDdo_produtonome.SetProperty("IncludeDataList", Ddo_produtonome_Includedatalist);
            ucDdo_produtonome.SetProperty("SortASC", Ddo_produtonome_Sortasc);
            ucDdo_produtonome.SetProperty("SortDSC", Ddo_produtonome_Sortdsc);
            ucDdo_produtonome.SetProperty("CleanFilter", Ddo_produtonome_Cleanfilter);
            ucDdo_produtonome.SetProperty("SearchButtonText", Ddo_produtonome_Searchbuttontext);
            ucDdo_produtonome.SetProperty("DropDownOptionsTitleSettingsIcons", AV37DDO_TitleSettingsIcons);
            ucDdo_produtonome.SetProperty("DropDownOptionsData", AV29ProdutoNomeTitleFilterData);
            ucDdo_produtonome.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_produtonome_Internalname, "DDO_PRODUTONOMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 112,'',false,'" + sGXsfl_95_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_produtonometitlecontrolidtoreplace_Internalname, AV30ddo_ProdutoNomeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,112);\"", 0, edtavDdo_produtonometitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_ProdutoPrompt.htm");
            /* User Defined Control */
            ucDdo_produtodescricao.SetProperty("Caption", Ddo_produtodescricao_Caption);
            ucDdo_produtodescricao.SetProperty("Tooltip", Ddo_produtodescricao_Tooltip);
            ucDdo_produtodescricao.SetProperty("Cls", Ddo_produtodescricao_Cls);
            ucDdo_produtodescricao.SetProperty("DropDownOptionsType", Ddo_produtodescricao_Dropdownoptionstype);
            ucDdo_produtodescricao.SetProperty("IncludeSortASC", Ddo_produtodescricao_Includesortasc);
            ucDdo_produtodescricao.SetProperty("IncludeSortDSC", Ddo_produtodescricao_Includesortdsc);
            ucDdo_produtodescricao.SetProperty("IncludeFilter", Ddo_produtodescricao_Includefilter);
            ucDdo_produtodescricao.SetProperty("IncludeDataList", Ddo_produtodescricao_Includedatalist);
            ucDdo_produtodescricao.SetProperty("SortASC", Ddo_produtodescricao_Sortasc);
            ucDdo_produtodescricao.SetProperty("SortDSC", Ddo_produtodescricao_Sortdsc);
            ucDdo_produtodescricao.SetProperty("CleanFilter", Ddo_produtodescricao_Cleanfilter);
            ucDdo_produtodescricao.SetProperty("SearchButtonText", Ddo_produtodescricao_Searchbuttontext);
            ucDdo_produtodescricao.SetProperty("DropDownOptionsTitleSettingsIcons", AV37DDO_TitleSettingsIcons);
            ucDdo_produtodescricao.SetProperty("DropDownOptionsData", AV31ProdutoDescricaoTitleFilterData);
            ucDdo_produtodescricao.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_produtodescricao_Internalname, "DDO_PRODUTODESCRICAOContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 114,'',false,'" + sGXsfl_95_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_produtodescricaotitlecontrolidtoreplace_Internalname, AV32ddo_ProdutoDescricaoTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,114);\"", 0, edtavDdo_produtodescricaotitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_ProdutoPrompt.htm");
            /* User Defined Control */
            ucDdo_produtovalor.SetProperty("Caption", Ddo_produtovalor_Caption);
            ucDdo_produtovalor.SetProperty("Tooltip", Ddo_produtovalor_Tooltip);
            ucDdo_produtovalor.SetProperty("Cls", Ddo_produtovalor_Cls);
            ucDdo_produtovalor.SetProperty("DropDownOptionsType", Ddo_produtovalor_Dropdownoptionstype);
            ucDdo_produtovalor.SetProperty("IncludeSortASC", Ddo_produtovalor_Includesortasc);
            ucDdo_produtovalor.SetProperty("IncludeSortDSC", Ddo_produtovalor_Includesortdsc);
            ucDdo_produtovalor.SetProperty("IncludeFilter", Ddo_produtovalor_Includefilter);
            ucDdo_produtovalor.SetProperty("IncludeDataList", Ddo_produtovalor_Includedatalist);
            ucDdo_produtovalor.SetProperty("SortASC", Ddo_produtovalor_Sortasc);
            ucDdo_produtovalor.SetProperty("SortDSC", Ddo_produtovalor_Sortdsc);
            ucDdo_produtovalor.SetProperty("CleanFilter", Ddo_produtovalor_Cleanfilter);
            ucDdo_produtovalor.SetProperty("SearchButtonText", Ddo_produtovalor_Searchbuttontext);
            ucDdo_produtovalor.SetProperty("DropDownOptionsTitleSettingsIcons", AV37DDO_TitleSettingsIcons);
            ucDdo_produtovalor.SetProperty("DropDownOptionsData", AV33ProdutoValorTitleFilterData);
            ucDdo_produtovalor.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_produtovalor_Internalname, "DDO_PRODUTOVALORContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 116,'',false,'" + sGXsfl_95_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_produtovalortitlecontrolidtoreplace_Internalname, AV34ddo_ProdutoValorTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,116);\"", 0, edtavDdo_produtovalortitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_ProdutoPrompt.htm");
            /* User Defined Control */
            ucDdo_produtodtvalidade.SetProperty("Caption", Ddo_produtodtvalidade_Caption);
            ucDdo_produtodtvalidade.SetProperty("Tooltip", Ddo_produtodtvalidade_Tooltip);
            ucDdo_produtodtvalidade.SetProperty("Cls", Ddo_produtodtvalidade_Cls);
            ucDdo_produtodtvalidade.SetProperty("DropDownOptionsType", Ddo_produtodtvalidade_Dropdownoptionstype);
            ucDdo_produtodtvalidade.SetProperty("IncludeSortASC", Ddo_produtodtvalidade_Includesortasc);
            ucDdo_produtodtvalidade.SetProperty("IncludeSortDSC", Ddo_produtodtvalidade_Includesortdsc);
            ucDdo_produtodtvalidade.SetProperty("IncludeFilter", Ddo_produtodtvalidade_Includefilter);
            ucDdo_produtodtvalidade.SetProperty("IncludeDataList", Ddo_produtodtvalidade_Includedatalist);
            ucDdo_produtodtvalidade.SetProperty("SortASC", Ddo_produtodtvalidade_Sortasc);
            ucDdo_produtodtvalidade.SetProperty("SortDSC", Ddo_produtodtvalidade_Sortdsc);
            ucDdo_produtodtvalidade.SetProperty("CleanFilter", Ddo_produtodtvalidade_Cleanfilter);
            ucDdo_produtodtvalidade.SetProperty("SearchButtonText", Ddo_produtodtvalidade_Searchbuttontext);
            ucDdo_produtodtvalidade.SetProperty("DropDownOptionsTitleSettingsIcons", AV37DDO_TitleSettingsIcons);
            ucDdo_produtodtvalidade.SetProperty("DropDownOptionsData", AV35ProdutoDtValidadeTitleFilterData);
            ucDdo_produtodtvalidade.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_produtodtvalidade_Internalname, "DDO_PRODUTODTVALIDADEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 118,'',false,'" + sGXsfl_95_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_produtodtvalidadetitlecontrolidtoreplace_Internalname, AV36ddo_ProdutoDtValidadeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,118);\"", 0, edtavDdo_produtodtvalidadetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_ProdutoPrompt.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities_f5", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 120,'',false,'" + sGXsfl_95_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavDynamicfiltersenabled2_Internalname, StringUtil.BoolToStr( AV16DynamicFiltersEnabled2), "", "", chkavDynamicfiltersenabled2.Visible, 1, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(120, this, 'true', 'false');gx.evt.onchange(this, event);\" ");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 121,'',false,'" + sGXsfl_95_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavDynamicfiltersenabled3_Internalname, StringUtil.BoolToStr( AV20DynamicFiltersEnabled3), "", "", chkavDynamicfiltersenabled3.Visible, 1, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(121, this, 'true', 'false');gx.evt.onchange(this, event);\" ");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 122,'',false,'" + sGXsfl_95_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11OrderedBy), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,122);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_ProdutoPrompt.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 123,'',false,'" + sGXsfl_95_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV12OrderedDsc), StringUtil.BoolToStr( AV12OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,123);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_ProdutoPrompt.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 95 )
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

      protected void START0S2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_2-131213", 0) ;
            Form.Meta.addItem("description", "Consulta de Produto", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP0S0( ) ;
      }

      protected void WS0S2( )
      {
         START0S2( ) ;
         EVT0S2( ) ;
      }

      protected void EVT0S2( )
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
                              E110S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E120S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PRODUTOID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E130S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PRODUTONOME.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E140S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PRODUTODESCRICAO.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E150S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PRODUTOVALOR.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E160S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PRODUTODTVALIDADE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E170S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'REMOVEDYNAMICFILTERS1'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'RemoveDynamicFilters1' */
                              E180S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'REMOVEDYNAMICFILTERS2'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'RemoveDynamicFilters2' */
                              E190S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'REMOVEDYNAMICFILTERS3'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'RemoveDynamicFilters3' */
                              E200S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOCLEANFILTERS'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoCleanFilters' */
                              E210S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'ADDDYNAMICFILTERS1'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'AddDynamicFilters1' */
                              E220S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'ADDDYNAMICFILTERS2'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'AddDynamicFilters2' */
                              E230S2 ();
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
                              nGXsfl_95_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_95_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_95_idx), 4, 0)), 4, "0");
                              SubsflControlProps_952( ) ;
                              AV41Select = cgiGet( edtavSelect_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV41Select)) ? AV46Select_GXI : context.convertURL( context.PathToRelativeUrl( AV41Select))), !bGXsfl_95_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "SrcSet", context.GetImageSrcSet( AV41Select), true);
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
                                    E240S2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E250S2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E260S2 ();
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
                                       /* Set Refresh If Produtonome1 Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vPRODUTONOME1"), AV15ProdutoNome1) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Dynamicfiltersselector2 Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vDYNAMICFILTERSSELECTOR2"), AV17DynamicFiltersSelector2) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Dynamicfiltersoperator2 Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vDYNAMICFILTERSOPERATOR2"), ",", ".") != Convert.ToDecimal( AV18DynamicFiltersOperator2 )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Produtonome2 Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vPRODUTONOME2"), AV19ProdutoNome2) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Dynamicfiltersselector3 Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vDYNAMICFILTERSSELECTOR3"), AV21DynamicFiltersSelector3) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Dynamicfiltersoperator3 Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vDYNAMICFILTERSOPERATOR3"), ",", ".") != Convert.ToDecimal( AV22DynamicFiltersOperator3 )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Produtonome3 Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vPRODUTONOME3"), AV23ProdutoNome3) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Dynamicfiltersenabled2 Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vDYNAMICFILTERSENABLED2")) != AV16DynamicFiltersEnabled2 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Dynamicfiltersenabled3 Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vDYNAMICFILTERSENABLED3")) != AV20DynamicFiltersEnabled3 )
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
                                          E270S2 ();
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

      protected void WE0S2( )
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

      protected void PA0S2( )
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
         SubsflControlProps_952( ) ;
         while ( nGXsfl_95_idx <= nRC_GXsfl_95 )
         {
            sendrow_952( ) ;
            nGXsfl_95_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_95_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_95_idx+1));
            sGXsfl_95_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_95_idx), 4, 0)), 4, "0");
            SubsflControlProps_952( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       String AV13DynamicFiltersSelector1 ,
                                       short AV14DynamicFiltersOperator1 ,
                                       String AV15ProdutoNome1 ,
                                       String AV17DynamicFiltersSelector2 ,
                                       short AV18DynamicFiltersOperator2 ,
                                       String AV19ProdutoNome2 ,
                                       String AV21DynamicFiltersSelector3 ,
                                       short AV22DynamicFiltersOperator3 ,
                                       String AV23ProdutoNome3 ,
                                       bool AV16DynamicFiltersEnabled2 ,
                                       bool AV20DynamicFiltersEnabled3 ,
                                       short AV11OrderedBy ,
                                       bool AV12OrderedDsc ,
                                       String AV28ddo_ProdutoIdTitleControlIdToReplace ,
                                       String AV30ddo_ProdutoNomeTitleControlIdToReplace ,
                                       String AV32ddo_ProdutoDescricaoTitleControlIdToReplace ,
                                       String AV34ddo_ProdutoValorTitleControlIdToReplace ,
                                       String AV36ddo_ProdutoDtValidadeTitleControlIdToReplace )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF0S2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_PRODUTOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A8ProdutoId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "PRODUTOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A8ProdutoId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_PRODUTONOME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A9ProdutoNome, "")), context));
         GxWebStd.gx_hidden_field( context, "PRODUTONOME", A9ProdutoNome);
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
            AV17DynamicFiltersSelector2 = cmbavDynamicfiltersselector2.getValidValue(AV17DynamicFiltersSelector2);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17DynamicFiltersSelector2", AV17DynamicFiltersSelector2);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavDynamicfiltersselector2.CurrentValue = StringUtil.RTrim( AV17DynamicFiltersSelector2);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector2_Internalname, "Values", cmbavDynamicfiltersselector2.ToJavascriptSource(), true);
         }
         if ( cmbavDynamicfiltersoperator2.ItemCount > 0 )
         {
            AV18DynamicFiltersOperator2 = (short)(NumberUtil.Val( cmbavDynamicfiltersoperator2.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV18DynamicFiltersOperator2), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18DynamicFiltersOperator2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18DynamicFiltersOperator2), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV18DynamicFiltersOperator2), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", cmbavDynamicfiltersoperator2.ToJavascriptSource(), true);
         }
         if ( cmbavDynamicfiltersselector3.ItemCount > 0 )
         {
            AV21DynamicFiltersSelector3 = cmbavDynamicfiltersselector3.getValidValue(AV21DynamicFiltersSelector3);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21DynamicFiltersSelector3", AV21DynamicFiltersSelector3);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavDynamicfiltersselector3.CurrentValue = StringUtil.RTrim( AV21DynamicFiltersSelector3);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector3_Internalname, "Values", cmbavDynamicfiltersselector3.ToJavascriptSource(), true);
         }
         if ( cmbavDynamicfiltersoperator3.ItemCount > 0 )
         {
            AV22DynamicFiltersOperator3 = (short)(NumberUtil.Val( cmbavDynamicfiltersoperator3.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV22DynamicFiltersOperator3), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22DynamicFiltersOperator3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22DynamicFiltersOperator3), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV22DynamicFiltersOperator3), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", cmbavDynamicfiltersoperator3.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF0S2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF0S2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 95;
         /* Execute user event: Refresh */
         E250S2 ();
         nGXsfl_95_idx = 1;
         sGXsfl_95_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_95_idx), 4, 0)), 4, "0");
         SubsflControlProps_952( ) ;
         bGXsfl_95_Refreshing = true;
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
            SubsflControlProps_952( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV13DynamicFiltersSelector1 ,
                                                 AV14DynamicFiltersOperator1 ,
                                                 AV15ProdutoNome1 ,
                                                 AV16DynamicFiltersEnabled2 ,
                                                 AV17DynamicFiltersSelector2 ,
                                                 AV18DynamicFiltersOperator2 ,
                                                 AV19ProdutoNome2 ,
                                                 AV20DynamicFiltersEnabled3 ,
                                                 AV21DynamicFiltersSelector3 ,
                                                 AV22DynamicFiltersOperator3 ,
                                                 AV23ProdutoNome3 ,
                                                 A9ProdutoNome ,
                                                 AV11OrderedBy ,
                                                 AV12OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.SHORT,
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV15ProdutoNome1 = StringUtil.Concat( StringUtil.RTrim( AV15ProdutoNome1), "%", "");
            lV15ProdutoNome1 = StringUtil.Concat( StringUtil.RTrim( AV15ProdutoNome1), "%", "");
            lV19ProdutoNome2 = StringUtil.Concat( StringUtil.RTrim( AV19ProdutoNome2), "%", "");
            lV19ProdutoNome2 = StringUtil.Concat( StringUtil.RTrim( AV19ProdutoNome2), "%", "");
            lV23ProdutoNome3 = StringUtil.Concat( StringUtil.RTrim( AV23ProdutoNome3), "%", "");
            lV23ProdutoNome3 = StringUtil.Concat( StringUtil.RTrim( AV23ProdutoNome3), "%", "");
            /* Using cursor H000S2 */
            pr_default.execute(0, new Object[] {lV15ProdutoNome1, lV15ProdutoNome1, lV19ProdutoNome2, lV19ProdutoNome2, lV23ProdutoNome3, lV23ProdutoNome3, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_95_idx = 1;
            sGXsfl_95_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_95_idx), 4, 0)), 4, "0");
            SubsflControlProps_952( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A12ProdutoDtValidade = H000S2_A12ProdutoDtValidade[0];
               A11ProdutoValor = H000S2_A11ProdutoValor[0];
               A10ProdutoDescricao = H000S2_A10ProdutoDescricao[0];
               A9ProdutoNome = H000S2_A9ProdutoNome[0];
               A8ProdutoId = H000S2_A8ProdutoId[0];
               E260S2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 95;
            WB0S0( ) ;
         }
         bGXsfl_95_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes0S2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_PRODUTOID"+"_"+sGXsfl_95_idx, GetSecureSignedToken( sGXsfl_95_idx, context.localUtil.Format( (decimal)(A8ProdutoId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_PRODUTONOME"+"_"+sGXsfl_95_idx, GetSecureSignedToken( sGXsfl_95_idx, StringUtil.RTrim( context.localUtil.Format( A9ProdutoNome, "")), context));
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
                                              AV15ProdutoNome1 ,
                                              AV16DynamicFiltersEnabled2 ,
                                              AV17DynamicFiltersSelector2 ,
                                              AV18DynamicFiltersOperator2 ,
                                              AV19ProdutoNome2 ,
                                              AV20DynamicFiltersEnabled3 ,
                                              AV21DynamicFiltersSelector3 ,
                                              AV22DynamicFiltersOperator3 ,
                                              AV23ProdutoNome3 ,
                                              A9ProdutoNome ,
                                              AV11OrderedBy ,
                                              AV12OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.SHORT,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV15ProdutoNome1 = StringUtil.Concat( StringUtil.RTrim( AV15ProdutoNome1), "%", "");
         lV15ProdutoNome1 = StringUtil.Concat( StringUtil.RTrim( AV15ProdutoNome1), "%", "");
         lV19ProdutoNome2 = StringUtil.Concat( StringUtil.RTrim( AV19ProdutoNome2), "%", "");
         lV19ProdutoNome2 = StringUtil.Concat( StringUtil.RTrim( AV19ProdutoNome2), "%", "");
         lV23ProdutoNome3 = StringUtil.Concat( StringUtil.RTrim( AV23ProdutoNome3), "%", "");
         lV23ProdutoNome3 = StringUtil.Concat( StringUtil.RTrim( AV23ProdutoNome3), "%", "");
         /* Using cursor H000S3 */
         pr_default.execute(1, new Object[] {lV15ProdutoNome1, lV15ProdutoNome1, lV19ProdutoNome2, lV19ProdutoNome2, lV23ProdutoNome3, lV23ProdutoNome3});
         GRID_nRecordCount = H000S3_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15ProdutoNome1, AV17DynamicFiltersSelector2, AV18DynamicFiltersOperator2, AV19ProdutoNome2, AV21DynamicFiltersSelector3, AV22DynamicFiltersOperator3, AV23ProdutoNome3, AV16DynamicFiltersEnabled2, AV20DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV28ddo_ProdutoIdTitleControlIdToReplace, AV30ddo_ProdutoNomeTitleControlIdToReplace, AV32ddo_ProdutoDescricaoTitleControlIdToReplace, AV34ddo_ProdutoValorTitleControlIdToReplace, AV36ddo_ProdutoDtValidadeTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15ProdutoNome1, AV17DynamicFiltersSelector2, AV18DynamicFiltersOperator2, AV19ProdutoNome2, AV21DynamicFiltersSelector3, AV22DynamicFiltersOperator3, AV23ProdutoNome3, AV16DynamicFiltersEnabled2, AV20DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV28ddo_ProdutoIdTitleControlIdToReplace, AV30ddo_ProdutoNomeTitleControlIdToReplace, AV32ddo_ProdutoDescricaoTitleControlIdToReplace, AV34ddo_ProdutoValorTitleControlIdToReplace, AV36ddo_ProdutoDtValidadeTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15ProdutoNome1, AV17DynamicFiltersSelector2, AV18DynamicFiltersOperator2, AV19ProdutoNome2, AV21DynamicFiltersSelector3, AV22DynamicFiltersOperator3, AV23ProdutoNome3, AV16DynamicFiltersEnabled2, AV20DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV28ddo_ProdutoIdTitleControlIdToReplace, AV30ddo_ProdutoNomeTitleControlIdToReplace, AV32ddo_ProdutoDescricaoTitleControlIdToReplace, AV34ddo_ProdutoValorTitleControlIdToReplace, AV36ddo_ProdutoDtValidadeTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15ProdutoNome1, AV17DynamicFiltersSelector2, AV18DynamicFiltersOperator2, AV19ProdutoNome2, AV21DynamicFiltersSelector3, AV22DynamicFiltersOperator3, AV23ProdutoNome3, AV16DynamicFiltersEnabled2, AV20DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV28ddo_ProdutoIdTitleControlIdToReplace, AV30ddo_ProdutoNomeTitleControlIdToReplace, AV32ddo_ProdutoDescricaoTitleControlIdToReplace, AV34ddo_ProdutoValorTitleControlIdToReplace, AV36ddo_ProdutoDtValidadeTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15ProdutoNome1, AV17DynamicFiltersSelector2, AV18DynamicFiltersOperator2, AV19ProdutoNome2, AV21DynamicFiltersSelector3, AV22DynamicFiltersOperator3, AV23ProdutoNome3, AV16DynamicFiltersEnabled2, AV20DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV28ddo_ProdutoIdTitleControlIdToReplace, AV30ddo_ProdutoNomeTitleControlIdToReplace, AV32ddo_ProdutoDescricaoTitleControlIdToReplace, AV34ddo_ProdutoValorTitleControlIdToReplace, AV36ddo_ProdutoDtValidadeTitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP0S0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E240S2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV37DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vPRODUTOIDTITLEFILTERDATA"), AV27ProdutoIdTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPRODUTONOMETITLEFILTERDATA"), AV29ProdutoNomeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPRODUTODESCRICAOTITLEFILTERDATA"), AV31ProdutoDescricaoTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPRODUTOVALORTITLEFILTERDATA"), AV33ProdutoValorTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPRODUTODTVALIDADETITLEFILTERDATA"), AV35ProdutoDtValidadeTitleFilterData);
            /* Read variables values. */
            cmbavDynamicfiltersselector1.Name = cmbavDynamicfiltersselector1_Internalname;
            cmbavDynamicfiltersselector1.CurrentValue = cgiGet( cmbavDynamicfiltersselector1_Internalname);
            AV13DynamicFiltersSelector1 = cgiGet( cmbavDynamicfiltersselector1_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13DynamicFiltersSelector1", AV13DynamicFiltersSelector1);
            cmbavDynamicfiltersoperator1.Name = cmbavDynamicfiltersoperator1_Internalname;
            cmbavDynamicfiltersoperator1.CurrentValue = cgiGet( cmbavDynamicfiltersoperator1_Internalname);
            AV14DynamicFiltersOperator1 = (short)(NumberUtil.Val( cgiGet( cmbavDynamicfiltersoperator1_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14DynamicFiltersOperator1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0)));
            AV15ProdutoNome1 = cgiGet( edtavProdutonome1_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15ProdutoNome1", AV15ProdutoNome1);
            cmbavDynamicfiltersselector2.Name = cmbavDynamicfiltersselector2_Internalname;
            cmbavDynamicfiltersselector2.CurrentValue = cgiGet( cmbavDynamicfiltersselector2_Internalname);
            AV17DynamicFiltersSelector2 = cgiGet( cmbavDynamicfiltersselector2_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17DynamicFiltersSelector2", AV17DynamicFiltersSelector2);
            cmbavDynamicfiltersoperator2.Name = cmbavDynamicfiltersoperator2_Internalname;
            cmbavDynamicfiltersoperator2.CurrentValue = cgiGet( cmbavDynamicfiltersoperator2_Internalname);
            AV18DynamicFiltersOperator2 = (short)(NumberUtil.Val( cgiGet( cmbavDynamicfiltersoperator2_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18DynamicFiltersOperator2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18DynamicFiltersOperator2), 4, 0)));
            AV19ProdutoNome2 = cgiGet( edtavProdutonome2_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ProdutoNome2", AV19ProdutoNome2);
            cmbavDynamicfiltersselector3.Name = cmbavDynamicfiltersselector3_Internalname;
            cmbavDynamicfiltersselector3.CurrentValue = cgiGet( cmbavDynamicfiltersselector3_Internalname);
            AV21DynamicFiltersSelector3 = cgiGet( cmbavDynamicfiltersselector3_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21DynamicFiltersSelector3", AV21DynamicFiltersSelector3);
            cmbavDynamicfiltersoperator3.Name = cmbavDynamicfiltersoperator3_Internalname;
            cmbavDynamicfiltersoperator3.CurrentValue = cgiGet( cmbavDynamicfiltersoperator3_Internalname);
            AV22DynamicFiltersOperator3 = (short)(NumberUtil.Val( cgiGet( cmbavDynamicfiltersoperator3_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22DynamicFiltersOperator3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22DynamicFiltersOperator3), 4, 0)));
            AV23ProdutoNome3 = cgiGet( edtavProdutonome3_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ProdutoNome3", AV23ProdutoNome3);
            AV28ddo_ProdutoIdTitleControlIdToReplace = cgiGet( edtavDdo_produtoidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28ddo_ProdutoIdTitleControlIdToReplace", AV28ddo_ProdutoIdTitleControlIdToReplace);
            AV30ddo_ProdutoNomeTitleControlIdToReplace = cgiGet( edtavDdo_produtonometitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30ddo_ProdutoNomeTitleControlIdToReplace", AV30ddo_ProdutoNomeTitleControlIdToReplace);
            AV32ddo_ProdutoDescricaoTitleControlIdToReplace = cgiGet( edtavDdo_produtodescricaotitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32ddo_ProdutoDescricaoTitleControlIdToReplace", AV32ddo_ProdutoDescricaoTitleControlIdToReplace);
            AV34ddo_ProdutoValorTitleControlIdToReplace = cgiGet( edtavDdo_produtovalortitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34ddo_ProdutoValorTitleControlIdToReplace", AV34ddo_ProdutoValorTitleControlIdToReplace);
            AV36ddo_ProdutoDtValidadeTitleControlIdToReplace = cgiGet( edtavDdo_produtodtvalidadetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36ddo_ProdutoDtValidadeTitleControlIdToReplace", AV36ddo_ProdutoDtValidadeTitleControlIdToReplace);
            AV16DynamicFiltersEnabled2 = StringUtil.StrToBool( cgiGet( chkavDynamicfiltersenabled2_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16DynamicFiltersEnabled2", AV16DynamicFiltersEnabled2);
            AV20DynamicFiltersEnabled3 = StringUtil.StrToBool( cgiGet( chkavDynamicfiltersenabled3_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20DynamicFiltersEnabled3", AV20DynamicFiltersEnabled3);
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
            nRC_GXsfl_95 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_95"), ",", "."));
            AV39GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ",", "."));
            AV40GridPageCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGECOUNT"), ",", "."));
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
            Ddo_produtoid_Caption = cgiGet( "DDO_PRODUTOID_Caption");
            Ddo_produtoid_Tooltip = cgiGet( "DDO_PRODUTOID_Tooltip");
            Ddo_produtoid_Cls = cgiGet( "DDO_PRODUTOID_Cls");
            Ddo_produtoid_Dropdownoptionstype = cgiGet( "DDO_PRODUTOID_Dropdownoptionstype");
            Ddo_produtoid_Titlecontrolidtoreplace = cgiGet( "DDO_PRODUTOID_Titlecontrolidtoreplace");
            Ddo_produtoid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PRODUTOID_Includesortasc"));
            Ddo_produtoid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PRODUTOID_Includesortdsc"));
            Ddo_produtoid_Sortedstatus = cgiGet( "DDO_PRODUTOID_Sortedstatus");
            Ddo_produtoid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PRODUTOID_Includefilter"));
            Ddo_produtoid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PRODUTOID_Includedatalist"));
            Ddo_produtoid_Sortasc = cgiGet( "DDO_PRODUTOID_Sortasc");
            Ddo_produtoid_Sortdsc = cgiGet( "DDO_PRODUTOID_Sortdsc");
            Ddo_produtoid_Cleanfilter = cgiGet( "DDO_PRODUTOID_Cleanfilter");
            Ddo_produtoid_Searchbuttontext = cgiGet( "DDO_PRODUTOID_Searchbuttontext");
            Ddo_produtonome_Caption = cgiGet( "DDO_PRODUTONOME_Caption");
            Ddo_produtonome_Tooltip = cgiGet( "DDO_PRODUTONOME_Tooltip");
            Ddo_produtonome_Cls = cgiGet( "DDO_PRODUTONOME_Cls");
            Ddo_produtonome_Dropdownoptionstype = cgiGet( "DDO_PRODUTONOME_Dropdownoptionstype");
            Ddo_produtonome_Titlecontrolidtoreplace = cgiGet( "DDO_PRODUTONOME_Titlecontrolidtoreplace");
            Ddo_produtonome_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PRODUTONOME_Includesortasc"));
            Ddo_produtonome_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PRODUTONOME_Includesortdsc"));
            Ddo_produtonome_Sortedstatus = cgiGet( "DDO_PRODUTONOME_Sortedstatus");
            Ddo_produtonome_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PRODUTONOME_Includefilter"));
            Ddo_produtonome_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PRODUTONOME_Includedatalist"));
            Ddo_produtonome_Sortasc = cgiGet( "DDO_PRODUTONOME_Sortasc");
            Ddo_produtonome_Sortdsc = cgiGet( "DDO_PRODUTONOME_Sortdsc");
            Ddo_produtonome_Cleanfilter = cgiGet( "DDO_PRODUTONOME_Cleanfilter");
            Ddo_produtonome_Searchbuttontext = cgiGet( "DDO_PRODUTONOME_Searchbuttontext");
            Ddo_produtodescricao_Caption = cgiGet( "DDO_PRODUTODESCRICAO_Caption");
            Ddo_produtodescricao_Tooltip = cgiGet( "DDO_PRODUTODESCRICAO_Tooltip");
            Ddo_produtodescricao_Cls = cgiGet( "DDO_PRODUTODESCRICAO_Cls");
            Ddo_produtodescricao_Dropdownoptionstype = cgiGet( "DDO_PRODUTODESCRICAO_Dropdownoptionstype");
            Ddo_produtodescricao_Titlecontrolidtoreplace = cgiGet( "DDO_PRODUTODESCRICAO_Titlecontrolidtoreplace");
            Ddo_produtodescricao_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PRODUTODESCRICAO_Includesortasc"));
            Ddo_produtodescricao_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PRODUTODESCRICAO_Includesortdsc"));
            Ddo_produtodescricao_Sortedstatus = cgiGet( "DDO_PRODUTODESCRICAO_Sortedstatus");
            Ddo_produtodescricao_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PRODUTODESCRICAO_Includefilter"));
            Ddo_produtodescricao_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PRODUTODESCRICAO_Includedatalist"));
            Ddo_produtodescricao_Sortasc = cgiGet( "DDO_PRODUTODESCRICAO_Sortasc");
            Ddo_produtodescricao_Sortdsc = cgiGet( "DDO_PRODUTODESCRICAO_Sortdsc");
            Ddo_produtodescricao_Cleanfilter = cgiGet( "DDO_PRODUTODESCRICAO_Cleanfilter");
            Ddo_produtodescricao_Searchbuttontext = cgiGet( "DDO_PRODUTODESCRICAO_Searchbuttontext");
            Ddo_produtovalor_Caption = cgiGet( "DDO_PRODUTOVALOR_Caption");
            Ddo_produtovalor_Tooltip = cgiGet( "DDO_PRODUTOVALOR_Tooltip");
            Ddo_produtovalor_Cls = cgiGet( "DDO_PRODUTOVALOR_Cls");
            Ddo_produtovalor_Dropdownoptionstype = cgiGet( "DDO_PRODUTOVALOR_Dropdownoptionstype");
            Ddo_produtovalor_Titlecontrolidtoreplace = cgiGet( "DDO_PRODUTOVALOR_Titlecontrolidtoreplace");
            Ddo_produtovalor_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PRODUTOVALOR_Includesortasc"));
            Ddo_produtovalor_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PRODUTOVALOR_Includesortdsc"));
            Ddo_produtovalor_Sortedstatus = cgiGet( "DDO_PRODUTOVALOR_Sortedstatus");
            Ddo_produtovalor_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PRODUTOVALOR_Includefilter"));
            Ddo_produtovalor_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PRODUTOVALOR_Includedatalist"));
            Ddo_produtovalor_Sortasc = cgiGet( "DDO_PRODUTOVALOR_Sortasc");
            Ddo_produtovalor_Sortdsc = cgiGet( "DDO_PRODUTOVALOR_Sortdsc");
            Ddo_produtovalor_Cleanfilter = cgiGet( "DDO_PRODUTOVALOR_Cleanfilter");
            Ddo_produtovalor_Searchbuttontext = cgiGet( "DDO_PRODUTOVALOR_Searchbuttontext");
            Ddo_produtodtvalidade_Caption = cgiGet( "DDO_PRODUTODTVALIDADE_Caption");
            Ddo_produtodtvalidade_Tooltip = cgiGet( "DDO_PRODUTODTVALIDADE_Tooltip");
            Ddo_produtodtvalidade_Cls = cgiGet( "DDO_PRODUTODTVALIDADE_Cls");
            Ddo_produtodtvalidade_Dropdownoptionstype = cgiGet( "DDO_PRODUTODTVALIDADE_Dropdownoptionstype");
            Ddo_produtodtvalidade_Titlecontrolidtoreplace = cgiGet( "DDO_PRODUTODTVALIDADE_Titlecontrolidtoreplace");
            Ddo_produtodtvalidade_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PRODUTODTVALIDADE_Includesortasc"));
            Ddo_produtodtvalidade_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PRODUTODTVALIDADE_Includesortdsc"));
            Ddo_produtodtvalidade_Sortedstatus = cgiGet( "DDO_PRODUTODTVALIDADE_Sortedstatus");
            Ddo_produtodtvalidade_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PRODUTODTVALIDADE_Includefilter"));
            Ddo_produtodtvalidade_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PRODUTODTVALIDADE_Includedatalist"));
            Ddo_produtodtvalidade_Sortasc = cgiGet( "DDO_PRODUTODTVALIDADE_Sortasc");
            Ddo_produtodtvalidade_Sortdsc = cgiGet( "DDO_PRODUTODTVALIDADE_Sortdsc");
            Ddo_produtodtvalidade_Cleanfilter = cgiGet( "DDO_PRODUTODTVALIDADE_Cleanfilter");
            Ddo_produtodtvalidade_Searchbuttontext = cgiGet( "DDO_PRODUTODTVALIDADE_Searchbuttontext");
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ",", "."));
            Ddo_produtoid_Activeeventkey = cgiGet( "DDO_PRODUTOID_Activeeventkey");
            Ddo_produtonome_Activeeventkey = cgiGet( "DDO_PRODUTONOME_Activeeventkey");
            Ddo_produtodescricao_Activeeventkey = cgiGet( "DDO_PRODUTODESCRICAO_Activeeventkey");
            Ddo_produtovalor_Activeeventkey = cgiGet( "DDO_PRODUTOVALOR_Activeeventkey");
            Ddo_produtodtvalidade_Activeeventkey = cgiGet( "DDO_PRODUTODTVALIDADE_Activeeventkey");
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
            if ( StringUtil.StrCmp(cgiGet( "GXH_vPRODUTONOME1"), AV15ProdutoNome1) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vDYNAMICFILTERSSELECTOR2"), AV17DynamicFiltersSelector2) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vDYNAMICFILTERSOPERATOR2"), ",", ".") != Convert.ToDecimal( AV18DynamicFiltersOperator2 )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vPRODUTONOME2"), AV19ProdutoNome2) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vDYNAMICFILTERSSELECTOR3"), AV21DynamicFiltersSelector3) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vDYNAMICFILTERSOPERATOR3"), ",", ".") != Convert.ToDecimal( AV22DynamicFiltersOperator3 )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vPRODUTONOME3"), AV23ProdutoNome3) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vDYNAMICFILTERSENABLED2")) != AV16DynamicFiltersEnabled2 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vDYNAMICFILTERSENABLED3")) != AV20DynamicFiltersEnabled3 )
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
         E240S2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E240S2( )
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
         AV13DynamicFiltersSelector1 = "PRODUTONOME";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13DynamicFiltersSelector1", AV13DynamicFiltersSelector1);
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS1' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV17DynamicFiltersSelector2 = "PRODUTONOME";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17DynamicFiltersSelector2", AV17DynamicFiltersSelector2);
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS2' */
         S122 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV21DynamicFiltersSelector3 = "PRODUTONOME";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21DynamicFiltersSelector3", AV21DynamicFiltersSelector3);
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
         Ddo_produtoid_Titlecontrolidtoreplace = subGrid_Internalname+"_ProdutoId";
         ucDdo_produtoid.SendProperty(context, "", false, Ddo_produtoid_Internalname, "TitleControlIdToReplace", Ddo_produtoid_Titlecontrolidtoreplace);
         AV28ddo_ProdutoIdTitleControlIdToReplace = Ddo_produtoid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28ddo_ProdutoIdTitleControlIdToReplace", AV28ddo_ProdutoIdTitleControlIdToReplace);
         edtavDdo_produtoidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_produtoidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_produtoidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_produtonome_Titlecontrolidtoreplace = subGrid_Internalname+"_ProdutoNome";
         ucDdo_produtonome.SendProperty(context, "", false, Ddo_produtonome_Internalname, "TitleControlIdToReplace", Ddo_produtonome_Titlecontrolidtoreplace);
         AV30ddo_ProdutoNomeTitleControlIdToReplace = Ddo_produtonome_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30ddo_ProdutoNomeTitleControlIdToReplace", AV30ddo_ProdutoNomeTitleControlIdToReplace);
         edtavDdo_produtonometitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_produtonometitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_produtonometitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_produtodescricao_Titlecontrolidtoreplace = subGrid_Internalname+"_ProdutoDescricao";
         ucDdo_produtodescricao.SendProperty(context, "", false, Ddo_produtodescricao_Internalname, "TitleControlIdToReplace", Ddo_produtodescricao_Titlecontrolidtoreplace);
         AV32ddo_ProdutoDescricaoTitleControlIdToReplace = Ddo_produtodescricao_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32ddo_ProdutoDescricaoTitleControlIdToReplace", AV32ddo_ProdutoDescricaoTitleControlIdToReplace);
         edtavDdo_produtodescricaotitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_produtodescricaotitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_produtodescricaotitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_produtovalor_Titlecontrolidtoreplace = subGrid_Internalname+"_ProdutoValor";
         ucDdo_produtovalor.SendProperty(context, "", false, Ddo_produtovalor_Internalname, "TitleControlIdToReplace", Ddo_produtovalor_Titlecontrolidtoreplace);
         AV34ddo_ProdutoValorTitleControlIdToReplace = Ddo_produtovalor_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34ddo_ProdutoValorTitleControlIdToReplace", AV34ddo_ProdutoValorTitleControlIdToReplace);
         edtavDdo_produtovalortitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_produtovalortitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_produtovalortitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_produtodtvalidade_Titlecontrolidtoreplace = subGrid_Internalname+"_ProdutoDtValidade";
         ucDdo_produtodtvalidade.SendProperty(context, "", false, Ddo_produtodtvalidade_Internalname, "TitleControlIdToReplace", Ddo_produtodtvalidade_Titlecontrolidtoreplace);
         AV36ddo_ProdutoDtValidadeTitleControlIdToReplace = Ddo_produtodtvalidade_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36ddo_ProdutoDtValidadeTitleControlIdToReplace", AV36ddo_ProdutoDtValidadeTitleControlIdToReplace);
         edtavDdo_produtodtvalidadetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_produtodtvalidadetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_produtodtvalidadetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = "Consulta de Produto";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV37DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV37DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E250S2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV27ProdutoIdTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV29ProdutoNomeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV31ProdutoDescricaoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV33ProdutoValorTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV35ProdutoDtValidadeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         edtProdutoId_Titleformat = 2;
         edtProdutoId_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Id", AV28ddo_ProdutoIdTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProdutoId_Internalname, "Title", edtProdutoId_Title, !bGXsfl_95_Refreshing);
         edtProdutoNome_Titleformat = 2;
         edtProdutoNome_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "do Produto", AV30ddo_ProdutoNomeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProdutoNome_Internalname, "Title", edtProdutoNome_Title, !bGXsfl_95_Refreshing);
         edtProdutoDescricao_Titleformat = 2;
         edtProdutoDescricao_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "do Produto", AV32ddo_ProdutoDescricaoTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProdutoDescricao_Internalname, "Title", edtProdutoDescricao_Title, !bGXsfl_95_Refreshing);
         edtProdutoValor_Titleformat = 2;
         edtProdutoValor_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "do Produto", AV34ddo_ProdutoValorTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProdutoValor_Internalname, "Title", edtProdutoValor_Title, !bGXsfl_95_Refreshing);
         edtProdutoDtValidade_Titleformat = 2;
         edtProdutoDtValidade_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "de Validade", AV36ddo_ProdutoDtValidadeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProdutoDtValidade_Internalname, "Title", edtProdutoDtValidade_Title, !bGXsfl_95_Refreshing);
         AV39GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV39GridCurrentPage), 10, 0)));
         AV40GridPageCount = subGrid_Pagecount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV40GridPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV40GridPageCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27ProdutoIdTitleFilterData", AV27ProdutoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29ProdutoNomeTitleFilterData", AV29ProdutoNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31ProdutoDescricaoTitleFilterData", AV31ProdutoDescricaoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33ProdutoValorTitleFilterData", AV33ProdutoValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35ProdutoDtValidadeTitleFilterData", AV35ProdutoDtValidadeTitleFilterData);
      }

      protected void E110S2( )
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
            AV38PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV38PageToGo) ;
         }
      }

      protected void E120S2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E130S2( )
      {
         /* Ddo_produtoid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_produtoid_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_produtoid_Sortedstatus = "ASC";
            ucDdo_produtoid.SendProperty(context, "", false, Ddo_produtoid_Internalname, "SortedStatus", Ddo_produtoid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_produtoid_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_produtoid_Sortedstatus = "DSC";
            ucDdo_produtoid.SendProperty(context, "", false, Ddo_produtoid_Internalname, "SortedStatus", Ddo_produtoid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27ProdutoIdTitleFilterData", AV27ProdutoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29ProdutoNomeTitleFilterData", AV29ProdutoNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31ProdutoDescricaoTitleFilterData", AV31ProdutoDescricaoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33ProdutoValorTitleFilterData", AV33ProdutoValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35ProdutoDtValidadeTitleFilterData", AV35ProdutoDtValidadeTitleFilterData);
      }

      protected void E140S2( )
      {
         /* Ddo_produtonome_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_produtonome_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_produtonome_Sortedstatus = "ASC";
            ucDdo_produtonome.SendProperty(context, "", false, Ddo_produtonome_Internalname, "SortedStatus", Ddo_produtonome_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_produtonome_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_produtonome_Sortedstatus = "DSC";
            ucDdo_produtonome.SendProperty(context, "", false, Ddo_produtonome_Internalname, "SortedStatus", Ddo_produtonome_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27ProdutoIdTitleFilterData", AV27ProdutoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29ProdutoNomeTitleFilterData", AV29ProdutoNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31ProdutoDescricaoTitleFilterData", AV31ProdutoDescricaoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33ProdutoValorTitleFilterData", AV33ProdutoValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35ProdutoDtValidadeTitleFilterData", AV35ProdutoDtValidadeTitleFilterData);
      }

      protected void E150S2( )
      {
         /* Ddo_produtodescricao_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_produtodescricao_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_produtodescricao_Sortedstatus = "ASC";
            ucDdo_produtodescricao.SendProperty(context, "", false, Ddo_produtodescricao_Internalname, "SortedStatus", Ddo_produtodescricao_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_produtodescricao_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_produtodescricao_Sortedstatus = "DSC";
            ucDdo_produtodescricao.SendProperty(context, "", false, Ddo_produtodescricao_Internalname, "SortedStatus", Ddo_produtodescricao_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27ProdutoIdTitleFilterData", AV27ProdutoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29ProdutoNomeTitleFilterData", AV29ProdutoNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31ProdutoDescricaoTitleFilterData", AV31ProdutoDescricaoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33ProdutoValorTitleFilterData", AV33ProdutoValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35ProdutoDtValidadeTitleFilterData", AV35ProdutoDtValidadeTitleFilterData);
      }

      protected void E160S2( )
      {
         /* Ddo_produtovalor_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_produtovalor_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_produtovalor_Sortedstatus = "ASC";
            ucDdo_produtovalor.SendProperty(context, "", false, Ddo_produtovalor_Internalname, "SortedStatus", Ddo_produtovalor_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_produtovalor_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_produtovalor_Sortedstatus = "DSC";
            ucDdo_produtovalor.SendProperty(context, "", false, Ddo_produtovalor_Internalname, "SortedStatus", Ddo_produtovalor_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27ProdutoIdTitleFilterData", AV27ProdutoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29ProdutoNomeTitleFilterData", AV29ProdutoNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31ProdutoDescricaoTitleFilterData", AV31ProdutoDescricaoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33ProdutoValorTitleFilterData", AV33ProdutoValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35ProdutoDtValidadeTitleFilterData", AV35ProdutoDtValidadeTitleFilterData);
      }

      protected void E170S2( )
      {
         /* Ddo_produtodtvalidade_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_produtodtvalidade_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_produtodtvalidade_Sortedstatus = "ASC";
            ucDdo_produtodtvalidade.SendProperty(context, "", false, Ddo_produtodtvalidade_Internalname, "SortedStatus", Ddo_produtodtvalidade_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_produtodtvalidade_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_produtodtvalidade_Sortedstatus = "DSC";
            ucDdo_produtodtvalidade.SendProperty(context, "", false, Ddo_produtodtvalidade_Internalname, "SortedStatus", Ddo_produtodtvalidade_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27ProdutoIdTitleFilterData", AV27ProdutoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29ProdutoNomeTitleFilterData", AV29ProdutoNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31ProdutoDescricaoTitleFilterData", AV31ProdutoDescricaoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33ProdutoValorTitleFilterData", AV33ProdutoValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35ProdutoDtValidadeTitleFilterData", AV35ProdutoDtValidadeTitleFilterData);
      }

      private void E260S2( )
      {
         /* Grid_Load Routine */
         AV41Select = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavSelect_Internalname, AV41Select);
         AV46Select_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         edtavSelect_Tooltiptext = "Selecionar";
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 95;
         }
         sendrow_952( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_95_Refreshing )
         {
            context.DoAjaxLoad(95, GridRow);
         }
         /*  Sending Event outputs  */
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E270S2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E270S2( )
      {
         /* Enter Routine */
         AV42InOutProdutoId = A8ProdutoId;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42InOutProdutoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV42InOutProdutoId), 4, 0)));
         AV43InOutProdutoNome = A9ProdutoNome;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43InOutProdutoNome", AV43InOutProdutoNome);
         context.setWebReturnParms(new Object[] {(short)AV42InOutProdutoId,(String)AV43InOutProdutoNome});
         context.setWebReturnParmsMetadata(new Object[] {"AV42InOutProdutoId","AV43InOutProdutoNome"});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
         /*  Sending Event outputs  */
      }

      protected void E220S2( )
      {
         /* 'AddDynamicFilters1' Routine */
         AV16DynamicFiltersEnabled2 = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16DynamicFiltersEnabled2", AV16DynamicFiltersEnabled2);
         imgAdddynamicfilters1_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgAdddynamicfilters1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgAdddynamicfilters1_Visible), 5, 0)), true);
         imgRemovedynamicfilters1_Visible = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgRemovedynamicfilters1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgRemovedynamicfilters1_Visible), 5, 0)), true);
         /*  Sending Event outputs  */
      }

      protected void E180S2( )
      {
         /* 'RemoveDynamicFilters1' Routine */
         AV24DynamicFiltersRemoving = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24DynamicFiltersRemoving", AV24DynamicFiltersRemoving);
         AV25DynamicFiltersIgnoreFirst = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25DynamicFiltersIgnoreFirst", AV25DynamicFiltersIgnoreFirst);
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
         AV24DynamicFiltersRemoving = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24DynamicFiltersRemoving", AV24DynamicFiltersRemoving);
         AV25DynamicFiltersIgnoreFirst = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25DynamicFiltersIgnoreFirst", AV25DynamicFiltersIgnoreFirst);
         gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15ProdutoNome1, AV17DynamicFiltersSelector2, AV18DynamicFiltersOperator2, AV19ProdutoNome2, AV21DynamicFiltersSelector3, AV22DynamicFiltersOperator3, AV23ProdutoNome3, AV16DynamicFiltersEnabled2, AV20DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV28ddo_ProdutoIdTitleControlIdToReplace, AV30ddo_ProdutoNomeTitleControlIdToReplace, AV32ddo_ProdutoDescricaoTitleControlIdToReplace, AV34ddo_ProdutoValorTitleControlIdToReplace, AV36ddo_ProdutoDtValidadeTitleControlIdToReplace) ;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV8GridState", AV8GridState);
         cmbavDynamicfiltersselector2.CurrentValue = StringUtil.RTrim( AV17DynamicFiltersSelector2);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector2_Internalname, "Values", cmbavDynamicfiltersselector2.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV18DynamicFiltersOperator2), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", cmbavDynamicfiltersoperator2.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector3.CurrentValue = StringUtil.RTrim( AV21DynamicFiltersSelector3);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector3_Internalname, "Values", cmbavDynamicfiltersselector3.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV22DynamicFiltersOperator3), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", cmbavDynamicfiltersoperator3.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector1.CurrentValue = StringUtil.RTrim( AV13DynamicFiltersSelector1);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector1_Internalname, "Values", cmbavDynamicfiltersselector1.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", cmbavDynamicfiltersoperator1.ToJavascriptSource(), true);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27ProdutoIdTitleFilterData", AV27ProdutoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29ProdutoNomeTitleFilterData", AV29ProdutoNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31ProdutoDescricaoTitleFilterData", AV31ProdutoDescricaoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33ProdutoValorTitleFilterData", AV33ProdutoValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35ProdutoDtValidadeTitleFilterData", AV35ProdutoDtValidadeTitleFilterData);
      }

      protected void E230S2( )
      {
         /* 'AddDynamicFilters2' Routine */
         AV20DynamicFiltersEnabled3 = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20DynamicFiltersEnabled3", AV20DynamicFiltersEnabled3);
         imgAdddynamicfilters2_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgAdddynamicfilters2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgAdddynamicfilters2_Visible), 5, 0)), true);
         imgRemovedynamicfilters2_Visible = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgRemovedynamicfilters2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgRemovedynamicfilters2_Visible), 5, 0)), true);
         /*  Sending Event outputs  */
      }

      protected void E190S2( )
      {
         /* 'RemoveDynamicFilters2' Routine */
         AV24DynamicFiltersRemoving = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24DynamicFiltersRemoving", AV24DynamicFiltersRemoving);
         AV16DynamicFiltersEnabled2 = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16DynamicFiltersEnabled2", AV16DynamicFiltersEnabled2);
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
         AV24DynamicFiltersRemoving = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24DynamicFiltersRemoving", AV24DynamicFiltersRemoving);
         gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15ProdutoNome1, AV17DynamicFiltersSelector2, AV18DynamicFiltersOperator2, AV19ProdutoNome2, AV21DynamicFiltersSelector3, AV22DynamicFiltersOperator3, AV23ProdutoNome3, AV16DynamicFiltersEnabled2, AV20DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV28ddo_ProdutoIdTitleControlIdToReplace, AV30ddo_ProdutoNomeTitleControlIdToReplace, AV32ddo_ProdutoDescricaoTitleControlIdToReplace, AV34ddo_ProdutoValorTitleControlIdToReplace, AV36ddo_ProdutoDtValidadeTitleControlIdToReplace) ;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV8GridState", AV8GridState);
         cmbavDynamicfiltersselector2.CurrentValue = StringUtil.RTrim( AV17DynamicFiltersSelector2);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector2_Internalname, "Values", cmbavDynamicfiltersselector2.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV18DynamicFiltersOperator2), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", cmbavDynamicfiltersoperator2.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector3.CurrentValue = StringUtil.RTrim( AV21DynamicFiltersSelector3);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector3_Internalname, "Values", cmbavDynamicfiltersselector3.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV22DynamicFiltersOperator3), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", cmbavDynamicfiltersoperator3.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector1.CurrentValue = StringUtil.RTrim( AV13DynamicFiltersSelector1);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector1_Internalname, "Values", cmbavDynamicfiltersselector1.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", cmbavDynamicfiltersoperator1.ToJavascriptSource(), true);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27ProdutoIdTitleFilterData", AV27ProdutoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29ProdutoNomeTitleFilterData", AV29ProdutoNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31ProdutoDescricaoTitleFilterData", AV31ProdutoDescricaoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33ProdutoValorTitleFilterData", AV33ProdutoValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35ProdutoDtValidadeTitleFilterData", AV35ProdutoDtValidadeTitleFilterData);
      }

      protected void E200S2( )
      {
         /* 'RemoveDynamicFilters3' Routine */
         AV24DynamicFiltersRemoving = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24DynamicFiltersRemoving", AV24DynamicFiltersRemoving);
         AV20DynamicFiltersEnabled3 = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20DynamicFiltersEnabled3", AV20DynamicFiltersEnabled3);
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
         AV24DynamicFiltersRemoving = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24DynamicFiltersRemoving", AV24DynamicFiltersRemoving);
         gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15ProdutoNome1, AV17DynamicFiltersSelector2, AV18DynamicFiltersOperator2, AV19ProdutoNome2, AV21DynamicFiltersSelector3, AV22DynamicFiltersOperator3, AV23ProdutoNome3, AV16DynamicFiltersEnabled2, AV20DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV28ddo_ProdutoIdTitleControlIdToReplace, AV30ddo_ProdutoNomeTitleControlIdToReplace, AV32ddo_ProdutoDescricaoTitleControlIdToReplace, AV34ddo_ProdutoValorTitleControlIdToReplace, AV36ddo_ProdutoDtValidadeTitleControlIdToReplace) ;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV8GridState", AV8GridState);
         cmbavDynamicfiltersselector2.CurrentValue = StringUtil.RTrim( AV17DynamicFiltersSelector2);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector2_Internalname, "Values", cmbavDynamicfiltersselector2.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV18DynamicFiltersOperator2), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", cmbavDynamicfiltersoperator2.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector3.CurrentValue = StringUtil.RTrim( AV21DynamicFiltersSelector3);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector3_Internalname, "Values", cmbavDynamicfiltersselector3.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV22DynamicFiltersOperator3), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", cmbavDynamicfiltersoperator3.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector1.CurrentValue = StringUtil.RTrim( AV13DynamicFiltersSelector1);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector1_Internalname, "Values", cmbavDynamicfiltersselector1.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", cmbavDynamicfiltersoperator1.ToJavascriptSource(), true);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27ProdutoIdTitleFilterData", AV27ProdutoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29ProdutoNomeTitleFilterData", AV29ProdutoNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31ProdutoDescricaoTitleFilterData", AV31ProdutoDescricaoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33ProdutoValorTitleFilterData", AV33ProdutoValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35ProdutoDtValidadeTitleFilterData", AV35ProdutoDtValidadeTitleFilterData);
      }

      protected void E210S2( )
      {
         /* 'DoCleanFilters' Routine */
         /* Execute user subroutine: 'CLEANFILTERS' */
         S192 ();
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
         cmbavDynamicfiltersselector2.CurrentValue = StringUtil.RTrim( AV17DynamicFiltersSelector2);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector2_Internalname, "Values", cmbavDynamicfiltersselector2.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV18DynamicFiltersOperator2), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", cmbavDynamicfiltersoperator2.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector3.CurrentValue = StringUtil.RTrim( AV21DynamicFiltersSelector3);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector3_Internalname, "Values", cmbavDynamicfiltersselector3.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV22DynamicFiltersOperator3), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", cmbavDynamicfiltersoperator3.ToJavascriptSource(), true);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27ProdutoIdTitleFilterData", AV27ProdutoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29ProdutoNomeTitleFilterData", AV29ProdutoNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31ProdutoDescricaoTitleFilterData", AV31ProdutoDescricaoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33ProdutoValorTitleFilterData", AV33ProdutoValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35ProdutoDtValidadeTitleFilterData", AV35ProdutoDtValidadeTitleFilterData);
      }

      protected void S162( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_produtoid_Sortedstatus = "";
         ucDdo_produtoid.SendProperty(context, "", false, Ddo_produtoid_Internalname, "SortedStatus", Ddo_produtoid_Sortedstatus);
         Ddo_produtonome_Sortedstatus = "";
         ucDdo_produtonome.SendProperty(context, "", false, Ddo_produtonome_Internalname, "SortedStatus", Ddo_produtonome_Sortedstatus);
         Ddo_produtodescricao_Sortedstatus = "";
         ucDdo_produtodescricao.SendProperty(context, "", false, Ddo_produtodescricao_Internalname, "SortedStatus", Ddo_produtodescricao_Sortedstatus);
         Ddo_produtovalor_Sortedstatus = "";
         ucDdo_produtovalor.SendProperty(context, "", false, Ddo_produtovalor_Internalname, "SortedStatus", Ddo_produtovalor_Sortedstatus);
         Ddo_produtodtvalidade_Sortedstatus = "";
         ucDdo_produtodtvalidade.SendProperty(context, "", false, Ddo_produtodtvalidade_Internalname, "SortedStatus", Ddo_produtodtvalidade_Sortedstatus);
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
            Ddo_produtoid_Sortedstatus = (AV12OrderedDsc ? "DSC" : "ASC");
            ucDdo_produtoid.SendProperty(context, "", false, Ddo_produtoid_Internalname, "SortedStatus", Ddo_produtoid_Sortedstatus);
         }
         else if ( AV11OrderedBy == 1 )
         {
            Ddo_produtonome_Sortedstatus = (AV12OrderedDsc ? "DSC" : "ASC");
            ucDdo_produtonome.SendProperty(context, "", false, Ddo_produtonome_Internalname, "SortedStatus", Ddo_produtonome_Sortedstatus);
         }
         else if ( AV11OrderedBy == 3 )
         {
            Ddo_produtodescricao_Sortedstatus = (AV12OrderedDsc ? "DSC" : "ASC");
            ucDdo_produtodescricao.SendProperty(context, "", false, Ddo_produtodescricao_Internalname, "SortedStatus", Ddo_produtodescricao_Sortedstatus);
         }
         else if ( AV11OrderedBy == 4 )
         {
            Ddo_produtovalor_Sortedstatus = (AV12OrderedDsc ? "DSC" : "ASC");
            ucDdo_produtovalor.SendProperty(context, "", false, Ddo_produtovalor_Internalname, "SortedStatus", Ddo_produtovalor_Sortedstatus);
         }
         else if ( AV11OrderedBy == 5 )
         {
            Ddo_produtodtvalidade_Sortedstatus = (AV12OrderedDsc ? "DSC" : "ASC");
            ucDdo_produtodtvalidade.SendProperty(context, "", false, Ddo_produtodtvalidade_Internalname, "SortedStatus", Ddo_produtodtvalidade_Sortedstatus);
         }
      }

      protected void S112( )
      {
         /* 'ENABLEDYNAMICFILTERS1' Routine */
         edtavProdutonome1_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavProdutonome1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavProdutonome1_Visible), 5, 0)), true);
         cmbavDynamicfiltersoperator1.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavDynamicfiltersoperator1.Visible), 5, 0)), true);
         if ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PRODUTONOME") == 0 )
         {
            edtavProdutonome1_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavProdutonome1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavProdutonome1_Visible), 5, 0)), true);
            cmbavDynamicfiltersoperator1.Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavDynamicfiltersoperator1.Visible), 5, 0)), true);
         }
      }

      protected void S122( )
      {
         /* 'ENABLEDYNAMICFILTERS2' Routine */
         edtavProdutonome2_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavProdutonome2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavProdutonome2_Visible), 5, 0)), true);
         cmbavDynamicfiltersoperator2.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavDynamicfiltersoperator2.Visible), 5, 0)), true);
         if ( StringUtil.StrCmp(AV17DynamicFiltersSelector2, "PRODUTONOME") == 0 )
         {
            edtavProdutonome2_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavProdutonome2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavProdutonome2_Visible), 5, 0)), true);
            cmbavDynamicfiltersoperator2.Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavDynamicfiltersoperator2.Visible), 5, 0)), true);
         }
      }

      protected void S132( )
      {
         /* 'ENABLEDYNAMICFILTERS3' Routine */
         edtavProdutonome3_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavProdutonome3_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavProdutonome3_Visible), 5, 0)), true);
         cmbavDynamicfiltersoperator3.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavDynamicfiltersoperator3.Visible), 5, 0)), true);
         if ( StringUtil.StrCmp(AV21DynamicFiltersSelector3, "PRODUTONOME") == 0 )
         {
            edtavProdutonome3_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavProdutonome3_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavProdutonome3_Visible), 5, 0)), true);
            cmbavDynamicfiltersoperator3.Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavDynamicfiltersoperator3.Visible), 5, 0)), true);
         }
      }

      protected void S182( )
      {
         /* 'RESETDYNFILTERS' Routine */
         AV16DynamicFiltersEnabled2 = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16DynamicFiltersEnabled2", AV16DynamicFiltersEnabled2);
         AV17DynamicFiltersSelector2 = "PRODUTONOME";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17DynamicFiltersSelector2", AV17DynamicFiltersSelector2);
         AV18DynamicFiltersOperator2 = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18DynamicFiltersOperator2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18DynamicFiltersOperator2), 4, 0)));
         AV19ProdutoNome2 = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ProdutoNome2", AV19ProdutoNome2);
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS2' */
         S122 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV20DynamicFiltersEnabled3 = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20DynamicFiltersEnabled3", AV20DynamicFiltersEnabled3);
         AV21DynamicFiltersSelector3 = "PRODUTONOME";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21DynamicFiltersSelector3", AV21DynamicFiltersSelector3);
         AV22DynamicFiltersOperator3 = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22DynamicFiltersOperator3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22DynamicFiltersOperator3), 4, 0)));
         AV23ProdutoNome3 = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ProdutoNome3", AV23ProdutoNome3);
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS3' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void S192( )
      {
         /* 'CLEANFILTERS' Routine */
         AV13DynamicFiltersSelector1 = "PRODUTONOME";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13DynamicFiltersSelector1", AV13DynamicFiltersSelector1);
         AV14DynamicFiltersOperator1 = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14DynamicFiltersOperator1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0)));
         AV15ProdutoNome1 = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15ProdutoNome1", AV15ProdutoNome1);
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
            if ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PRODUTONOME") == 0 )
            {
               AV14DynamicFiltersOperator1 = AV10GridStateDynamicFilter.gxTpr_Operator;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14DynamicFiltersOperator1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0)));
               AV15ProdutoNome1 = AV10GridStateDynamicFilter.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15ProdutoNome1", AV15ProdutoNome1);
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
               AV16DynamicFiltersEnabled2 = true;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16DynamicFiltersEnabled2", AV16DynamicFiltersEnabled2);
               AV10GridStateDynamicFilter = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter)AV8GridState.gxTpr_Dynamicfilters.Item(2));
               AV17DynamicFiltersSelector2 = AV10GridStateDynamicFilter.gxTpr_Selected;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17DynamicFiltersSelector2", AV17DynamicFiltersSelector2);
               if ( StringUtil.StrCmp(AV17DynamicFiltersSelector2, "PRODUTONOME") == 0 )
               {
                  AV18DynamicFiltersOperator2 = AV10GridStateDynamicFilter.gxTpr_Operator;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18DynamicFiltersOperator2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18DynamicFiltersOperator2), 4, 0)));
                  AV19ProdutoNome2 = AV10GridStateDynamicFilter.gxTpr_Value;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ProdutoNome2", AV19ProdutoNome2);
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
                  AV20DynamicFiltersEnabled3 = true;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20DynamicFiltersEnabled3", AV20DynamicFiltersEnabled3);
                  AV10GridStateDynamicFilter = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter)AV8GridState.gxTpr_Dynamicfilters.Item(3));
                  AV21DynamicFiltersSelector3 = AV10GridStateDynamicFilter.gxTpr_Selected;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21DynamicFiltersSelector3", AV21DynamicFiltersSelector3);
                  if ( StringUtil.StrCmp(AV21DynamicFiltersSelector3, "PRODUTONOME") == 0 )
                  {
                     AV22DynamicFiltersOperator3 = AV10GridStateDynamicFilter.gxTpr_Operator;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22DynamicFiltersOperator3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22DynamicFiltersOperator3), 4, 0)));
                     AV23ProdutoNome3 = AV10GridStateDynamicFilter.gxTpr_Value;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ProdutoNome3", AV23ProdutoNome3);
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
         if ( AV24DynamicFiltersRemoving )
         {
            lblJsdynamicfilters_Caption = "";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblJsdynamicfilters_Internalname, "Caption", lblJsdynamicfilters_Caption, true);
         }
      }

      protected void S172( )
      {
         /* 'SAVEDYNFILTERSSTATE' Routine */
         AV8GridState.gxTpr_Dynamicfilters.Clear();
         if ( ! AV25DynamicFiltersIgnoreFirst )
         {
            AV10GridStateDynamicFilter = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter(context);
            AV10GridStateDynamicFilter.gxTpr_Selected = AV13DynamicFiltersSelector1;
            if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PRODUTONOME") == 0 ) && ! String.IsNullOrEmpty(StringUtil.RTrim( AV15ProdutoNome1)) )
            {
               AV10GridStateDynamicFilter.gxTpr_Value = AV15ProdutoNome1;
               AV10GridStateDynamicFilter.gxTpr_Operator = AV14DynamicFiltersOperator1;
            }
            if ( AV24DynamicFiltersRemoving || ! String.IsNullOrEmpty(StringUtil.RTrim( AV10GridStateDynamicFilter.gxTpr_Value)) )
            {
               AV8GridState.gxTpr_Dynamicfilters.Add(AV10GridStateDynamicFilter, 0);
            }
         }
         if ( AV16DynamicFiltersEnabled2 )
         {
            AV10GridStateDynamicFilter = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter(context);
            AV10GridStateDynamicFilter.gxTpr_Selected = AV17DynamicFiltersSelector2;
            if ( ( StringUtil.StrCmp(AV17DynamicFiltersSelector2, "PRODUTONOME") == 0 ) && ! String.IsNullOrEmpty(StringUtil.RTrim( AV19ProdutoNome2)) )
            {
               AV10GridStateDynamicFilter.gxTpr_Value = AV19ProdutoNome2;
               AV10GridStateDynamicFilter.gxTpr_Operator = AV18DynamicFiltersOperator2;
            }
            if ( AV24DynamicFiltersRemoving || ! String.IsNullOrEmpty(StringUtil.RTrim( AV10GridStateDynamicFilter.gxTpr_Value)) )
            {
               AV8GridState.gxTpr_Dynamicfilters.Add(AV10GridStateDynamicFilter, 0);
            }
         }
         if ( AV20DynamicFiltersEnabled3 )
         {
            AV10GridStateDynamicFilter = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter(context);
            AV10GridStateDynamicFilter.gxTpr_Selected = AV21DynamicFiltersSelector3;
            if ( ( StringUtil.StrCmp(AV21DynamicFiltersSelector3, "PRODUTONOME") == 0 ) && ! String.IsNullOrEmpty(StringUtil.RTrim( AV23ProdutoNome3)) )
            {
               AV10GridStateDynamicFilter.gxTpr_Value = AV23ProdutoNome3;
               AV10GridStateDynamicFilter.gxTpr_Operator = AV22DynamicFiltersOperator3;
            }
            if ( AV24DynamicFiltersRemoving || ! String.IsNullOrEmpty(StringUtil.RTrim( AV10GridStateDynamicFilter.gxTpr_Value)) )
            {
               AV8GridState.gxTpr_Dynamicfilters.Add(AV10GridStateDynamicFilter, 0);
            }
         }
      }

      protected void wb_table1_14_0S2( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgCleanfilters_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "Limpar filtros", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgCleanfilters_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'DOCLEANFILTERS\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_ProdutoPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_19_0S2( true) ;
         }
         else
         {
            wb_table2_19_0S2( false) ;
         }
         return  ;
      }

      protected void wb_table2_19_0S2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_14_0S2e( true) ;
         }
         else
         {
            wb_table1_14_0S2e( false) ;
         }
      }

      protected void wb_table2_19_0S2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTabledynamicfilters_Internalname, tblTabledynamicfilters_Internalname, "", "TableDynamicFilters", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersprefix1_Internalname, "Filtrar por", "", "", lblDynamicfiltersprefix1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescriptionPrefix", 0, "", 1, 1, 0, "HLP_ProdutoPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavDynamicfiltersselector1_Internalname, "Dynamic Filters Selector1", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'" + sGXsfl_95_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersselector1, cmbavDynamicfiltersselector1_Internalname, StringUtil.RTrim( AV13DynamicFiltersSelector1), 1, cmbavDynamicfiltersselector1_Jsonclick, 7, "'"+""+"'"+",false,"+"'"+"e280s1_client"+"'", "svchar", "", 1, cmbavDynamicfiltersselector1.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,25);\"", "", true, "HLP_ProdutoPrompt.htm");
            cmbavDynamicfiltersselector1.CurrentValue = StringUtil.RTrim( AV13DynamicFiltersSelector1);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector1_Internalname, "Values", (String)(cmbavDynamicfiltersselector1.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersmiddle1_Internalname, "valor", "", "", lblDynamicfiltersmiddle1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescription", 0, "", 1, 1, 0, "HLP_ProdutoPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table3_29_0S2( true) ;
         }
         else
         {
            wb_table3_29_0S2( false) ;
         }
         return  ;
      }

      protected void wb_table3_29_0S2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table4_38_0S2( true) ;
         }
         else
         {
            wb_table4_38_0S2( false) ;
         }
         return  ;
      }

      protected void wb_table4_38_0S2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersprefix2_Internalname, "Filtrar por", "", "", lblDynamicfiltersprefix2_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescriptionPrefix", 0, "", 1, 1, 0, "HLP_ProdutoPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavDynamicfiltersselector2_Internalname, "Dynamic Filters Selector2", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'" + sGXsfl_95_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersselector2, cmbavDynamicfiltersselector2_Internalname, StringUtil.RTrim( AV17DynamicFiltersSelector2), 1, cmbavDynamicfiltersselector2_Jsonclick, 7, "'"+""+"'"+",false,"+"'"+"e290s1_client"+"'", "svchar", "", 1, cmbavDynamicfiltersselector2.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "", true, "HLP_ProdutoPrompt.htm");
            cmbavDynamicfiltersselector2.CurrentValue = StringUtil.RTrim( AV17DynamicFiltersSelector2);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector2_Internalname, "Values", (String)(cmbavDynamicfiltersselector2.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersmiddle2_Internalname, "valor", "", "", lblDynamicfiltersmiddle2_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescription", 0, "", 1, 1, 0, "HLP_ProdutoPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            wb_table5_53_0S2( true) ;
         }
         else
         {
            wb_table5_53_0S2( false) ;
         }
         return  ;
      }

      protected void wb_table5_53_0S2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            wb_table6_62_0S2( true) ;
         }
         else
         {
            wb_table6_62_0S2( false) ;
         }
         return  ;
      }

      protected void wb_table6_62_0S2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersprefix3_Internalname, "Filtrar por", "", "", lblDynamicfiltersprefix3_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescriptionPrefix", 0, "", 1, 1, 0, "HLP_ProdutoPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavDynamicfiltersselector3_Internalname, "Dynamic Filters Selector3", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'" + sGXsfl_95_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersselector3, cmbavDynamicfiltersselector3_Internalname, StringUtil.RTrim( AV21DynamicFiltersSelector3), 1, cmbavDynamicfiltersselector3_Jsonclick, 7, "'"+""+"'"+",false,"+"'"+"e300s1_client"+"'", "svchar", "", 1, cmbavDynamicfiltersselector3.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,73);\"", "", true, "HLP_ProdutoPrompt.htm");
            cmbavDynamicfiltersselector3.CurrentValue = StringUtil.RTrim( AV21DynamicFiltersSelector3);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector3_Internalname, "Values", (String)(cmbavDynamicfiltersselector3.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersmiddle3_Internalname, "valor", "", "", lblDynamicfiltersmiddle3_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescription", 0, "", 1, 1, 0, "HLP_ProdutoPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            wb_table7_77_0S2( true) ;
         }
         else
         {
            wb_table7_77_0S2( false) ;
         }
         return  ;
      }

      protected void wb_table7_77_0S2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            wb_table8_86_0S2( true) ;
         }
         else
         {
            wb_table8_86_0S2( false) ;
         }
         return  ;
      }

      protected void wb_table8_86_0S2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_19_0S2e( true) ;
         }
         else
         {
            wb_table2_19_0S2e( false) ;
         }
      }

      protected void wb_table8_86_0S2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblUnnamedtabledynamicfilters_3_Internalname, tblUnnamedtabledynamicfilters_3_Internalname, "", "Table", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\""+cellDynamicfilters_removefilter3_cell_Internalname+"\"  class=''>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 89,'',false,'',0)\"";
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "11a6ef14-1a5a-4077-91a2-f41ed9a3a662", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgRemovedynamicfilters3_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "Remover filtro", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgRemovedynamicfilters3_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'REMOVEDYNAMICFILTERS3\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_ProdutoPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table8_86_0S2e( true) ;
         }
         else
         {
            wb_table8_86_0S2e( false) ;
         }
      }

      protected void wb_table7_77_0S2( bool wbgen )
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'" + sGXsfl_95_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersoperator3, cmbavDynamicfiltersoperator3_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV22DynamicFiltersOperator3), 4, 0)), 1, cmbavDynamicfiltersoperator3_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", cmbavDynamicfiltersoperator3.Visible, cmbavDynamicfiltersoperator3.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,81);\"", "", true, "HLP_ProdutoPrompt.htm");
            cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV22DynamicFiltersOperator3), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", (String)(cmbavDynamicfiltersoperator3.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellFilter_produtonome3_cell_Internalname+"\"  class=''>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavProdutonome3_Internalname, "Produto Nome3", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 84,'',false,'" + sGXsfl_95_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavProdutonome3_Internalname, AV23ProdutoNome3, StringUtil.RTrim( context.localUtil.Format( AV23ProdutoNome3, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,84);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavProdutonome3_Jsonclick, 0, "Attribute", "", "", "", "", edtavProdutonome3_Visible, edtavProdutonome3_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_ProdutoPrompt.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table7_77_0S2e( true) ;
         }
         else
         {
            wb_table7_77_0S2e( false) ;
         }
      }

      protected void wb_table6_62_0S2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblUnnamedtabledynamicfilters_2_Internalname, tblUnnamedtabledynamicfilters_2_Internalname, "", "Table", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\""+cellDynamicfilters_addfilter2_cell_Internalname+"\"  class=''>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'',0)\"";
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "27283ea5-332f-423b-b880-64b762622df3", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgAdddynamicfilters2_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgAdddynamicfilters2_Visible, 1, "", "Adicionar filtro", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgAdddynamicfilters2_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'ADDDYNAMICFILTERS2\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_ProdutoPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellDynamicfilters_removefilter2_cell_Internalname+"\"  class=''>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'',0)\"";
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "11a6ef14-1a5a-4077-91a2-f41ed9a3a662", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgRemovedynamicfilters2_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgRemovedynamicfilters2_Visible, 1, "", "Remover filtro", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgRemovedynamicfilters2_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'REMOVEDYNAMICFILTERS2\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_ProdutoPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table6_62_0S2e( true) ;
         }
         else
         {
            wb_table6_62_0S2e( false) ;
         }
      }

      protected void wb_table5_53_0S2( bool wbgen )
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'" + sGXsfl_95_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersoperator2, cmbavDynamicfiltersoperator2_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV18DynamicFiltersOperator2), 4, 0)), 1, cmbavDynamicfiltersoperator2_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", cmbavDynamicfiltersoperator2.Visible, cmbavDynamicfiltersoperator2.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,57);\"", "", true, "HLP_ProdutoPrompt.htm");
            cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV18DynamicFiltersOperator2), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", (String)(cmbavDynamicfiltersoperator2.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellFilter_produtonome2_cell_Internalname+"\"  class=''>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavProdutonome2_Internalname, "Produto Nome2", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'" + sGXsfl_95_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavProdutonome2_Internalname, AV19ProdutoNome2, StringUtil.RTrim( context.localUtil.Format( AV19ProdutoNome2, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,60);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavProdutonome2_Jsonclick, 0, "Attribute", "", "", "", "", edtavProdutonome2_Visible, edtavProdutonome2_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_ProdutoPrompt.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_53_0S2e( true) ;
         }
         else
         {
            wb_table5_53_0S2e( false) ;
         }
      }

      protected void wb_table4_38_0S2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblUnnamedtabledynamicfilters_1_Internalname, tblUnnamedtabledynamicfilters_1_Internalname, "", "Table", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\""+cellDynamicfilters_addfilter1_cell_Internalname+"\"  class=''>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'',false,'',0)\"";
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "27283ea5-332f-423b-b880-64b762622df3", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgAdddynamicfilters1_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgAdddynamicfilters1_Visible, 1, "", "Adicionar filtro", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgAdddynamicfilters1_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'ADDDYNAMICFILTERS1\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_ProdutoPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellDynamicfilters_removefilter1_cell_Internalname+"\"  class=''>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "11a6ef14-1a5a-4077-91a2-f41ed9a3a662", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgRemovedynamicfilters1_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgRemovedynamicfilters1_Visible, 1, "", "Remover filtro", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgRemovedynamicfilters1_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'REMOVEDYNAMICFILTERS1\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_ProdutoPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_38_0S2e( true) ;
         }
         else
         {
            wb_table4_38_0S2e( false) ;
         }
      }

      protected void wb_table3_29_0S2( bool wbgen )
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'" + sGXsfl_95_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersoperator1, cmbavDynamicfiltersoperator1_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0)), 1, cmbavDynamicfiltersoperator1_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", cmbavDynamicfiltersoperator1.Visible, cmbavDynamicfiltersoperator1.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,33);\"", "", true, "HLP_ProdutoPrompt.htm");
            cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", (String)(cmbavDynamicfiltersoperator1.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellFilter_produtonome1_cell_Internalname+"\"  class=''>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavProdutonome1_Internalname, "Produto Nome1", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_95_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavProdutonome1_Internalname, AV15ProdutoNome1, StringUtil.RTrim( context.localUtil.Format( AV15ProdutoNome1, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavProdutonome1_Jsonclick, 0, "Attribute", "", "", "", "", edtavProdutonome1_Visible, edtavProdutonome1_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_ProdutoPrompt.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_29_0S2e( true) ;
         }
         else
         {
            wb_table3_29_0S2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV42InOutProdutoId = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42InOutProdutoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV42InOutProdutoId), 4, 0)));
         AV43InOutProdutoNome = (String)getParm(obj,1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43InOutProdutoNome", AV43InOutProdutoNome);
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
         PA0S2( ) ;
         WS0S2( ) ;
         WE0S2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20197121759511", true, true);
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
         context.AddJavascriptSource("produtoprompt.js", "?20197121759512", false, true);
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
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false, true);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_952( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_95_idx;
         edtProdutoId_Internalname = "PRODUTOID_"+sGXsfl_95_idx;
         edtProdutoNome_Internalname = "PRODUTONOME_"+sGXsfl_95_idx;
         edtProdutoDescricao_Internalname = "PRODUTODESCRICAO_"+sGXsfl_95_idx;
         edtProdutoValor_Internalname = "PRODUTOVALOR_"+sGXsfl_95_idx;
         edtProdutoDtValidade_Internalname = "PRODUTODTVALIDADE_"+sGXsfl_95_idx;
      }

      protected void SubsflControlProps_fel_952( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_95_fel_idx;
         edtProdutoId_Internalname = "PRODUTOID_"+sGXsfl_95_fel_idx;
         edtProdutoNome_Internalname = "PRODUTONOME_"+sGXsfl_95_fel_idx;
         edtProdutoDescricao_Internalname = "PRODUTODESCRICAO_"+sGXsfl_95_fel_idx;
         edtProdutoValor_Internalname = "PRODUTOVALOR_"+sGXsfl_95_fel_idx;
         edtProdutoDtValidade_Internalname = "PRODUTODTVALIDADE_"+sGXsfl_95_fel_idx;
      }

      protected void sendrow_952( )
      {
         SubsflControlProps_952( ) ;
         WB0S0( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_95_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_95_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_95_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavSelect_Enabled!=0)&&(edtavSelect_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 96,'',false,'',95)\"" : " ");
            ClassString = "SelectAttribute ActionBaseColorAttribute";
            StyleString = "";
            AV41Select_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV41Select))&&String.IsNullOrEmpty(StringUtil.RTrim( AV46Select_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV41Select)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV41Select)) ? AV46Select_GXI : context.PathToRelativeUrl( AV41Select));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavSelect_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavSelect_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavSelect_Jsonclick,"'"+""+"'"+",false,"+"'"+"EENTER."+sGXsfl_95_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV41Select_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtProdutoId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A8ProdutoId), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A8ProdutoId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtProdutoId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)95,(short)1,(short)-1,(short)0,(bool)true,(String)"Serial",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtProdutoNome_Internalname,(String)A9ProdutoNome,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtProdutoNome_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)95,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtProdutoDescricao_Internalname,(String)A10ProdutoDescricao,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtProdutoDescricao_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)500,(short)0,(short)0,(short)95,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtProdutoValor_Internalname,StringUtil.LTrim( StringUtil.NToC( A11ProdutoValor, 12, 2, ",", "")),context.localUtil.Format( A11ProdutoValor, "R$ ZZ,ZZ9.99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtProdutoValor_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)12,(short)0,(short)0,(short)95,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtProdutoDtValidade_Internalname,context.localUtil.Format(A12ProdutoDtValidade, "99/99/99"),context.localUtil.Format( A12ProdutoDtValidade, "99/99/99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtProdutoDtValidade_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)95,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            send_integrity_lvl_hashes0S2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_95_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_95_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_95_idx+1));
            sGXsfl_95_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_95_idx), 4, 0)), 4, "0");
            SubsflControlProps_952( ) ;
         }
         /* End function sendrow_952 */
      }

      protected void init_web_controls( )
      {
         cmbavDynamicfiltersselector1.Name = "vDYNAMICFILTERSSELECTOR1";
         cmbavDynamicfiltersselector1.WebTags = "";
         cmbavDynamicfiltersselector1.addItem("PRODUTONOME", "do Produto", 0);
         if ( cmbavDynamicfiltersselector1.ItemCount > 0 )
         {
            AV13DynamicFiltersSelector1 = cmbavDynamicfiltersselector1.getValidValue(AV13DynamicFiltersSelector1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13DynamicFiltersSelector1", AV13DynamicFiltersSelector1);
         }
         cmbavDynamicfiltersoperator1.Name = "vDYNAMICFILTERSOPERATOR1";
         cmbavDynamicfiltersoperator1.WebTags = "";
         cmbavDynamicfiltersoperator1.addItem("0", "Começa com", 0);
         cmbavDynamicfiltersoperator1.addItem("1", "Contém", 0);
         if ( cmbavDynamicfiltersoperator1.ItemCount > 0 )
         {
            AV14DynamicFiltersOperator1 = (short)(NumberUtil.Val( cmbavDynamicfiltersoperator1.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14DynamicFiltersOperator1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0)));
         }
         cmbavDynamicfiltersselector2.Name = "vDYNAMICFILTERSSELECTOR2";
         cmbavDynamicfiltersselector2.WebTags = "";
         cmbavDynamicfiltersselector2.addItem("PRODUTONOME", "do Produto", 0);
         if ( cmbavDynamicfiltersselector2.ItemCount > 0 )
         {
            AV17DynamicFiltersSelector2 = cmbavDynamicfiltersselector2.getValidValue(AV17DynamicFiltersSelector2);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17DynamicFiltersSelector2", AV17DynamicFiltersSelector2);
         }
         cmbavDynamicfiltersoperator2.Name = "vDYNAMICFILTERSOPERATOR2";
         cmbavDynamicfiltersoperator2.WebTags = "";
         cmbavDynamicfiltersoperator2.addItem("0", "Começa com", 0);
         cmbavDynamicfiltersoperator2.addItem("1", "Contém", 0);
         if ( cmbavDynamicfiltersoperator2.ItemCount > 0 )
         {
            AV18DynamicFiltersOperator2 = (short)(NumberUtil.Val( cmbavDynamicfiltersoperator2.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV18DynamicFiltersOperator2), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18DynamicFiltersOperator2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18DynamicFiltersOperator2), 4, 0)));
         }
         cmbavDynamicfiltersselector3.Name = "vDYNAMICFILTERSSELECTOR3";
         cmbavDynamicfiltersselector3.WebTags = "";
         cmbavDynamicfiltersselector3.addItem("PRODUTONOME", "do Produto", 0);
         if ( cmbavDynamicfiltersselector3.ItemCount > 0 )
         {
            AV21DynamicFiltersSelector3 = cmbavDynamicfiltersselector3.getValidValue(AV21DynamicFiltersSelector3);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21DynamicFiltersSelector3", AV21DynamicFiltersSelector3);
         }
         cmbavDynamicfiltersoperator3.Name = "vDYNAMICFILTERSOPERATOR3";
         cmbavDynamicfiltersoperator3.WebTags = "";
         cmbavDynamicfiltersoperator3.addItem("0", "Começa com", 0);
         cmbavDynamicfiltersoperator3.addItem("1", "Contém", 0);
         if ( cmbavDynamicfiltersoperator3.ItemCount > 0 )
         {
            AV22DynamicFiltersOperator3 = (short)(NumberUtil.Val( cmbavDynamicfiltersoperator3.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV22DynamicFiltersOperator3), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22DynamicFiltersOperator3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22DynamicFiltersOperator3), 4, 0)));
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
         tblTablefilters_Internalname = "TABLEFILTERS";
         divTableheader_Internalname = "TABLEHEADER";
         Dvpanel_tableheader_Internalname = "DVPANEL_TABLEHEADER";
         edtavSelect_Internalname = "vSELECT";
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
         Ddo_produtodescricao_Internalname = "DDO_PRODUTODESCRICAO";
         edtavDdo_produtodescricaotitlecontrolidtoreplace_Internalname = "vDDO_PRODUTODESCRICAOTITLECONTROLIDTOREPLACE";
         Ddo_produtovalor_Internalname = "DDO_PRODUTOVALOR";
         edtavDdo_produtovalortitlecontrolidtoreplace_Internalname = "vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE";
         Ddo_produtodtvalidade_Internalname = "DDO_PRODUTODTVALIDADE";
         edtavDdo_produtodtvalidadetitlecontrolidtoreplace_Internalname = "vDDO_PRODUTODTVALIDADETITLECONTROLIDTOREPLACE";
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
         edtProdutoDtValidade_Jsonclick = "";
         edtProdutoValor_Jsonclick = "";
         edtProdutoDescricao_Jsonclick = "";
         edtProdutoNome_Jsonclick = "";
         edtProdutoId_Jsonclick = "";
         edtavSelect_Jsonclick = "";
         edtavSelect_Visible = -1;
         edtavSelect_Enabled = 1;
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
         cmbavDynamicfiltersoperator3.Visible = 1;
         edtavProdutonome3_Visible = 1;
         cmbavDynamicfiltersoperator2.Visible = 1;
         edtavProdutonome2_Visible = 1;
         cmbavDynamicfiltersoperator1.Visible = 1;
         edtavProdutonome1_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         chkavDynamicfiltersenabled3.Visible = 1;
         chkavDynamicfiltersenabled2.Visible = 1;
         edtavDdo_produtodtvalidadetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_produtovalortitlecontrolidtoreplace_Visible = 1;
         edtavDdo_produtodescricaotitlecontrolidtoreplace_Visible = 1;
         edtavDdo_produtonometitlecontrolidtoreplace_Visible = 1;
         edtavDdo_produtoidtitlecontrolidtoreplace_Visible = 1;
         lblJsdynamicfilters_Caption = "JSDynamicFilters";
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavSelect_Tooltiptext = "Selecionar";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtProdutoDtValidade_Titleformat = 0;
         edtProdutoDtValidade_Title = "de Validade";
         edtProdutoValor_Titleformat = 0;
         edtProdutoValor_Title = "do Produto";
         edtProdutoDescricao_Titleformat = 0;
         edtProdutoDescricao_Title = "do Produto";
         edtProdutoNome_Titleformat = 0;
         edtProdutoNome_Title = "do Produto";
         edtProdutoId_Titleformat = 0;
         edtProdutoId_Title = "Id";
         subGrid_Class = "GridWithPaginationBar GridNoBorder WorkWith";
         subGrid_Backcolorstyle = 0;
         Ddo_produtodtvalidade_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_produtodtvalidade_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_produtodtvalidade_Sortdsc = "WWP_TSSortDSC";
         Ddo_produtodtvalidade_Sortasc = "WWP_TSSortASC";
         Ddo_produtodtvalidade_Includedatalist = Convert.ToBoolean( 0);
         Ddo_produtodtvalidade_Includefilter = Convert.ToBoolean( 0);
         Ddo_produtodtvalidade_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_produtodtvalidade_Includesortasc = Convert.ToBoolean( -1);
         Ddo_produtodtvalidade_Titlecontrolidtoreplace = "";
         Ddo_produtodtvalidade_Dropdownoptionstype = "GridTitleSettings";
         Ddo_produtodtvalidade_Cls = "ColumnSettings";
         Ddo_produtodtvalidade_Tooltip = "WWP_TSColumnOptions";
         Ddo_produtodtvalidade_Caption = "";
         Ddo_produtovalor_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_produtovalor_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_produtovalor_Sortdsc = "WWP_TSSortDSC";
         Ddo_produtovalor_Sortasc = "WWP_TSSortASC";
         Ddo_produtovalor_Includedatalist = Convert.ToBoolean( 0);
         Ddo_produtovalor_Includefilter = Convert.ToBoolean( 0);
         Ddo_produtovalor_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_produtovalor_Includesortasc = Convert.ToBoolean( -1);
         Ddo_produtovalor_Titlecontrolidtoreplace = "";
         Ddo_produtovalor_Dropdownoptionstype = "GridTitleSettings";
         Ddo_produtovalor_Cls = "ColumnSettings";
         Ddo_produtovalor_Tooltip = "WWP_TSColumnOptions";
         Ddo_produtovalor_Caption = "";
         Ddo_produtodescricao_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_produtodescricao_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_produtodescricao_Sortdsc = "WWP_TSSortDSC";
         Ddo_produtodescricao_Sortasc = "WWP_TSSortASC";
         Ddo_produtodescricao_Includedatalist = Convert.ToBoolean( 0);
         Ddo_produtodescricao_Includefilter = Convert.ToBoolean( 0);
         Ddo_produtodescricao_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_produtodescricao_Includesortasc = Convert.ToBoolean( -1);
         Ddo_produtodescricao_Titlecontrolidtoreplace = "";
         Ddo_produtodescricao_Dropdownoptionstype = "GridTitleSettings";
         Ddo_produtodescricao_Cls = "ColumnSettings";
         Ddo_produtodescricao_Tooltip = "WWP_TSColumnOptions";
         Ddo_produtodescricao_Caption = "";
         Ddo_produtonome_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_produtonome_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_produtonome_Sortdsc = "WWP_TSSortDSC";
         Ddo_produtonome_Sortasc = "WWP_TSSortASC";
         Ddo_produtonome_Includedatalist = Convert.ToBoolean( 0);
         Ddo_produtonome_Includefilter = Convert.ToBoolean( 0);
         Ddo_produtonome_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_produtonome_Includesortasc = Convert.ToBoolean( -1);
         Ddo_produtonome_Titlecontrolidtoreplace = "";
         Ddo_produtonome_Dropdownoptionstype = "GridTitleSettings";
         Ddo_produtonome_Cls = "ColumnSettings";
         Ddo_produtonome_Tooltip = "WWP_TSColumnOptions";
         Ddo_produtonome_Caption = "";
         Ddo_produtoid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_produtoid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_produtoid_Sortdsc = "WWP_TSSortDSC";
         Ddo_produtoid_Sortasc = "WWP_TSSortASC";
         Ddo_produtoid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_produtoid_Includefilter = Convert.ToBoolean( 0);
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
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Consulta de Produto";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV17DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV18DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV19ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV21DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV22DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV23ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV16DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV20DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV28ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_ProdutoDescricaoTitleControlIdToReplace',fld:'vDDO_PRODUTODESCRICAOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_ProdutoDtValidadeTitleControlIdToReplace',fld:'vDDO_PRODUTODTVALIDADETITLECONTROLIDTOREPLACE',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV27ProdutoIdTitleFilterData',fld:'vPRODUTOIDTITLEFILTERDATA',pic:''},{av:'AV29ProdutoNomeTitleFilterData',fld:'vPRODUTONOMETITLEFILTERDATA',pic:''},{av:'AV31ProdutoDescricaoTitleFilterData',fld:'vPRODUTODESCRICAOTITLEFILTERDATA',pic:''},{av:'AV33ProdutoValorTitleFilterData',fld:'vPRODUTOVALORTITLEFILTERDATA',pic:''},{av:'AV35ProdutoDtValidadeTitleFilterData',fld:'vPRODUTODTVALIDADETITLEFILTERDATA',pic:''},{av:'edtProdutoId_Titleformat',ctrl:'PRODUTOID',prop:'Titleformat'},{av:'edtProdutoId_Title',ctrl:'PRODUTOID',prop:'Title'},{av:'edtProdutoNome_Titleformat',ctrl:'PRODUTONOME',prop:'Titleformat'},{av:'edtProdutoNome_Title',ctrl:'PRODUTONOME',prop:'Title'},{av:'edtProdutoDescricao_Titleformat',ctrl:'PRODUTODESCRICAO',prop:'Titleformat'},{av:'edtProdutoDescricao_Title',ctrl:'PRODUTODESCRICAO',prop:'Title'},{av:'edtProdutoValor_Titleformat',ctrl:'PRODUTOVALOR',prop:'Titleformat'},{av:'edtProdutoValor_Title',ctrl:'PRODUTOVALOR',prop:'Title'},{av:'edtProdutoDtValidade_Titleformat',ctrl:'PRODUTODTVALIDADE',prop:'Titleformat'},{av:'edtProdutoDtValidade_Title',ctrl:'PRODUTODTVALIDADE',prop:'Title'},{av:'AV39GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV40GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E110S2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV17DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV18DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV19ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV21DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV22DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV23ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV16DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV20DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV28ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_ProdutoDescricaoTitleControlIdToReplace',fld:'vDDO_PRODUTODESCRICAOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_ProdutoDtValidadeTitleControlIdToReplace',fld:'vDDO_PRODUTODTVALIDADETITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E120S2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV17DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV18DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV19ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV21DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV22DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV23ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV16DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV20DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV28ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_ProdutoDescricaoTitleControlIdToReplace',fld:'vDDO_PRODUTODESCRICAOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_ProdutoDtValidadeTitleControlIdToReplace',fld:'vDDO_PRODUTODTVALIDADETITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_PRODUTOID.ONOPTIONCLICKED","{handler:'E130S2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV17DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV18DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV19ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV21DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV22DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV23ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV16DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV20DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV28ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_ProdutoDescricaoTitleControlIdToReplace',fld:'vDDO_PRODUTODESCRICAOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_ProdutoDtValidadeTitleControlIdToReplace',fld:'vDDO_PRODUTODTVALIDADETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_produtoid_Activeeventkey',ctrl:'DDO_PRODUTOID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_PRODUTOID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_produtoid_Sortedstatus',ctrl:'DDO_PRODUTOID',prop:'SortedStatus'},{av:'Ddo_produtonome_Sortedstatus',ctrl:'DDO_PRODUTONOME',prop:'SortedStatus'},{av:'Ddo_produtodescricao_Sortedstatus',ctrl:'DDO_PRODUTODESCRICAO',prop:'SortedStatus'},{av:'Ddo_produtovalor_Sortedstatus',ctrl:'DDO_PRODUTOVALOR',prop:'SortedStatus'},{av:'Ddo_produtodtvalidade_Sortedstatus',ctrl:'DDO_PRODUTODTVALIDADE',prop:'SortedStatus'},{av:'AV27ProdutoIdTitleFilterData',fld:'vPRODUTOIDTITLEFILTERDATA',pic:''},{av:'AV29ProdutoNomeTitleFilterData',fld:'vPRODUTONOMETITLEFILTERDATA',pic:''},{av:'AV31ProdutoDescricaoTitleFilterData',fld:'vPRODUTODESCRICAOTITLEFILTERDATA',pic:''},{av:'AV33ProdutoValorTitleFilterData',fld:'vPRODUTOVALORTITLEFILTERDATA',pic:''},{av:'AV35ProdutoDtValidadeTitleFilterData',fld:'vPRODUTODTVALIDADETITLEFILTERDATA',pic:''},{av:'edtProdutoId_Titleformat',ctrl:'PRODUTOID',prop:'Titleformat'},{av:'edtProdutoId_Title',ctrl:'PRODUTOID',prop:'Title'},{av:'edtProdutoNome_Titleformat',ctrl:'PRODUTONOME',prop:'Titleformat'},{av:'edtProdutoNome_Title',ctrl:'PRODUTONOME',prop:'Title'},{av:'edtProdutoDescricao_Titleformat',ctrl:'PRODUTODESCRICAO',prop:'Titleformat'},{av:'edtProdutoDescricao_Title',ctrl:'PRODUTODESCRICAO',prop:'Title'},{av:'edtProdutoValor_Titleformat',ctrl:'PRODUTOVALOR',prop:'Titleformat'},{av:'edtProdutoValor_Title',ctrl:'PRODUTOVALOR',prop:'Title'},{av:'edtProdutoDtValidade_Titleformat',ctrl:'PRODUTODTVALIDADE',prop:'Titleformat'},{av:'edtProdutoDtValidade_Title',ctrl:'PRODUTODTVALIDADE',prop:'Title'},{av:'AV39GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV40GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_PRODUTONOME.ONOPTIONCLICKED","{handler:'E140S2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV17DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV18DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV19ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV21DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV22DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV23ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV16DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV20DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV28ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_ProdutoDescricaoTitleControlIdToReplace',fld:'vDDO_PRODUTODESCRICAOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_ProdutoDtValidadeTitleControlIdToReplace',fld:'vDDO_PRODUTODTVALIDADETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_produtonome_Activeeventkey',ctrl:'DDO_PRODUTONOME',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_PRODUTONOME.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_produtonome_Sortedstatus',ctrl:'DDO_PRODUTONOME',prop:'SortedStatus'},{av:'Ddo_produtoid_Sortedstatus',ctrl:'DDO_PRODUTOID',prop:'SortedStatus'},{av:'Ddo_produtodescricao_Sortedstatus',ctrl:'DDO_PRODUTODESCRICAO',prop:'SortedStatus'},{av:'Ddo_produtovalor_Sortedstatus',ctrl:'DDO_PRODUTOVALOR',prop:'SortedStatus'},{av:'Ddo_produtodtvalidade_Sortedstatus',ctrl:'DDO_PRODUTODTVALIDADE',prop:'SortedStatus'},{av:'AV27ProdutoIdTitleFilterData',fld:'vPRODUTOIDTITLEFILTERDATA',pic:''},{av:'AV29ProdutoNomeTitleFilterData',fld:'vPRODUTONOMETITLEFILTERDATA',pic:''},{av:'AV31ProdutoDescricaoTitleFilterData',fld:'vPRODUTODESCRICAOTITLEFILTERDATA',pic:''},{av:'AV33ProdutoValorTitleFilterData',fld:'vPRODUTOVALORTITLEFILTERDATA',pic:''},{av:'AV35ProdutoDtValidadeTitleFilterData',fld:'vPRODUTODTVALIDADETITLEFILTERDATA',pic:''},{av:'edtProdutoId_Titleformat',ctrl:'PRODUTOID',prop:'Titleformat'},{av:'edtProdutoId_Title',ctrl:'PRODUTOID',prop:'Title'},{av:'edtProdutoNome_Titleformat',ctrl:'PRODUTONOME',prop:'Titleformat'},{av:'edtProdutoNome_Title',ctrl:'PRODUTONOME',prop:'Title'},{av:'edtProdutoDescricao_Titleformat',ctrl:'PRODUTODESCRICAO',prop:'Titleformat'},{av:'edtProdutoDescricao_Title',ctrl:'PRODUTODESCRICAO',prop:'Title'},{av:'edtProdutoValor_Titleformat',ctrl:'PRODUTOVALOR',prop:'Titleformat'},{av:'edtProdutoValor_Title',ctrl:'PRODUTOVALOR',prop:'Title'},{av:'edtProdutoDtValidade_Titleformat',ctrl:'PRODUTODTVALIDADE',prop:'Titleformat'},{av:'edtProdutoDtValidade_Title',ctrl:'PRODUTODTVALIDADE',prop:'Title'},{av:'AV39GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV40GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_PRODUTODESCRICAO.ONOPTIONCLICKED","{handler:'E150S2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV17DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV18DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV19ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV21DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV22DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV23ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV16DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV20DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV28ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_ProdutoDescricaoTitleControlIdToReplace',fld:'vDDO_PRODUTODESCRICAOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_ProdutoDtValidadeTitleControlIdToReplace',fld:'vDDO_PRODUTODTVALIDADETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_produtodescricao_Activeeventkey',ctrl:'DDO_PRODUTODESCRICAO',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_PRODUTODESCRICAO.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_produtodescricao_Sortedstatus',ctrl:'DDO_PRODUTODESCRICAO',prop:'SortedStatus'},{av:'Ddo_produtoid_Sortedstatus',ctrl:'DDO_PRODUTOID',prop:'SortedStatus'},{av:'Ddo_produtonome_Sortedstatus',ctrl:'DDO_PRODUTONOME',prop:'SortedStatus'},{av:'Ddo_produtovalor_Sortedstatus',ctrl:'DDO_PRODUTOVALOR',prop:'SortedStatus'},{av:'Ddo_produtodtvalidade_Sortedstatus',ctrl:'DDO_PRODUTODTVALIDADE',prop:'SortedStatus'},{av:'AV27ProdutoIdTitleFilterData',fld:'vPRODUTOIDTITLEFILTERDATA',pic:''},{av:'AV29ProdutoNomeTitleFilterData',fld:'vPRODUTONOMETITLEFILTERDATA',pic:''},{av:'AV31ProdutoDescricaoTitleFilterData',fld:'vPRODUTODESCRICAOTITLEFILTERDATA',pic:''},{av:'AV33ProdutoValorTitleFilterData',fld:'vPRODUTOVALORTITLEFILTERDATA',pic:''},{av:'AV35ProdutoDtValidadeTitleFilterData',fld:'vPRODUTODTVALIDADETITLEFILTERDATA',pic:''},{av:'edtProdutoId_Titleformat',ctrl:'PRODUTOID',prop:'Titleformat'},{av:'edtProdutoId_Title',ctrl:'PRODUTOID',prop:'Title'},{av:'edtProdutoNome_Titleformat',ctrl:'PRODUTONOME',prop:'Titleformat'},{av:'edtProdutoNome_Title',ctrl:'PRODUTONOME',prop:'Title'},{av:'edtProdutoDescricao_Titleformat',ctrl:'PRODUTODESCRICAO',prop:'Titleformat'},{av:'edtProdutoDescricao_Title',ctrl:'PRODUTODESCRICAO',prop:'Title'},{av:'edtProdutoValor_Titleformat',ctrl:'PRODUTOVALOR',prop:'Titleformat'},{av:'edtProdutoValor_Title',ctrl:'PRODUTOVALOR',prop:'Title'},{av:'edtProdutoDtValidade_Titleformat',ctrl:'PRODUTODTVALIDADE',prop:'Titleformat'},{av:'edtProdutoDtValidade_Title',ctrl:'PRODUTODTVALIDADE',prop:'Title'},{av:'AV39GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV40GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_PRODUTOVALOR.ONOPTIONCLICKED","{handler:'E160S2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV17DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV18DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV19ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV21DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV22DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV23ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV16DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV20DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV28ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_ProdutoDescricaoTitleControlIdToReplace',fld:'vDDO_PRODUTODESCRICAOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_ProdutoDtValidadeTitleControlIdToReplace',fld:'vDDO_PRODUTODTVALIDADETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_produtovalor_Activeeventkey',ctrl:'DDO_PRODUTOVALOR',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_PRODUTOVALOR.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_produtovalor_Sortedstatus',ctrl:'DDO_PRODUTOVALOR',prop:'SortedStatus'},{av:'Ddo_produtoid_Sortedstatus',ctrl:'DDO_PRODUTOID',prop:'SortedStatus'},{av:'Ddo_produtonome_Sortedstatus',ctrl:'DDO_PRODUTONOME',prop:'SortedStatus'},{av:'Ddo_produtodescricao_Sortedstatus',ctrl:'DDO_PRODUTODESCRICAO',prop:'SortedStatus'},{av:'Ddo_produtodtvalidade_Sortedstatus',ctrl:'DDO_PRODUTODTVALIDADE',prop:'SortedStatus'},{av:'AV27ProdutoIdTitleFilterData',fld:'vPRODUTOIDTITLEFILTERDATA',pic:''},{av:'AV29ProdutoNomeTitleFilterData',fld:'vPRODUTONOMETITLEFILTERDATA',pic:''},{av:'AV31ProdutoDescricaoTitleFilterData',fld:'vPRODUTODESCRICAOTITLEFILTERDATA',pic:''},{av:'AV33ProdutoValorTitleFilterData',fld:'vPRODUTOVALORTITLEFILTERDATA',pic:''},{av:'AV35ProdutoDtValidadeTitleFilterData',fld:'vPRODUTODTVALIDADETITLEFILTERDATA',pic:''},{av:'edtProdutoId_Titleformat',ctrl:'PRODUTOID',prop:'Titleformat'},{av:'edtProdutoId_Title',ctrl:'PRODUTOID',prop:'Title'},{av:'edtProdutoNome_Titleformat',ctrl:'PRODUTONOME',prop:'Titleformat'},{av:'edtProdutoNome_Title',ctrl:'PRODUTONOME',prop:'Title'},{av:'edtProdutoDescricao_Titleformat',ctrl:'PRODUTODESCRICAO',prop:'Titleformat'},{av:'edtProdutoDescricao_Title',ctrl:'PRODUTODESCRICAO',prop:'Title'},{av:'edtProdutoValor_Titleformat',ctrl:'PRODUTOVALOR',prop:'Titleformat'},{av:'edtProdutoValor_Title',ctrl:'PRODUTOVALOR',prop:'Title'},{av:'edtProdutoDtValidade_Titleformat',ctrl:'PRODUTODTVALIDADE',prop:'Titleformat'},{av:'edtProdutoDtValidade_Title',ctrl:'PRODUTODTVALIDADE',prop:'Title'},{av:'AV39GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV40GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_PRODUTODTVALIDADE.ONOPTIONCLICKED","{handler:'E170S2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV17DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV18DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV19ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV21DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV22DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV23ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV16DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV20DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV28ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_ProdutoDescricaoTitleControlIdToReplace',fld:'vDDO_PRODUTODESCRICAOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_ProdutoDtValidadeTitleControlIdToReplace',fld:'vDDO_PRODUTODTVALIDADETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_produtodtvalidade_Activeeventkey',ctrl:'DDO_PRODUTODTVALIDADE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_PRODUTODTVALIDADE.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_produtodtvalidade_Sortedstatus',ctrl:'DDO_PRODUTODTVALIDADE',prop:'SortedStatus'},{av:'Ddo_produtoid_Sortedstatus',ctrl:'DDO_PRODUTOID',prop:'SortedStatus'},{av:'Ddo_produtonome_Sortedstatus',ctrl:'DDO_PRODUTONOME',prop:'SortedStatus'},{av:'Ddo_produtodescricao_Sortedstatus',ctrl:'DDO_PRODUTODESCRICAO',prop:'SortedStatus'},{av:'Ddo_produtovalor_Sortedstatus',ctrl:'DDO_PRODUTOVALOR',prop:'SortedStatus'},{av:'AV27ProdutoIdTitleFilterData',fld:'vPRODUTOIDTITLEFILTERDATA',pic:''},{av:'AV29ProdutoNomeTitleFilterData',fld:'vPRODUTONOMETITLEFILTERDATA',pic:''},{av:'AV31ProdutoDescricaoTitleFilterData',fld:'vPRODUTODESCRICAOTITLEFILTERDATA',pic:''},{av:'AV33ProdutoValorTitleFilterData',fld:'vPRODUTOVALORTITLEFILTERDATA',pic:''},{av:'AV35ProdutoDtValidadeTitleFilterData',fld:'vPRODUTODTVALIDADETITLEFILTERDATA',pic:''},{av:'edtProdutoId_Titleformat',ctrl:'PRODUTOID',prop:'Titleformat'},{av:'edtProdutoId_Title',ctrl:'PRODUTOID',prop:'Title'},{av:'edtProdutoNome_Titleformat',ctrl:'PRODUTONOME',prop:'Titleformat'},{av:'edtProdutoNome_Title',ctrl:'PRODUTONOME',prop:'Title'},{av:'edtProdutoDescricao_Titleformat',ctrl:'PRODUTODESCRICAO',prop:'Titleformat'},{av:'edtProdutoDescricao_Title',ctrl:'PRODUTODESCRICAO',prop:'Title'},{av:'edtProdutoValor_Titleformat',ctrl:'PRODUTOVALOR',prop:'Titleformat'},{av:'edtProdutoValor_Title',ctrl:'PRODUTOVALOR',prop:'Title'},{av:'edtProdutoDtValidade_Titleformat',ctrl:'PRODUTODTVALIDADE',prop:'Titleformat'},{av:'edtProdutoDtValidade_Title',ctrl:'PRODUTODTVALIDADE',prop:'Title'},{av:'AV39GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV40GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E260S2',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV41Select',fld:'vSELECT',pic:''},{av:'edtavSelect_Tooltiptext',ctrl:'vSELECT',prop:'Tooltiptext'}]}");
         setEventMetadata("ENTER","{handler:'E270S2',iparms:[{av:'A8ProdutoId',fld:'PRODUTOID',pic:'ZZZ9',hsh:true},{av:'A9ProdutoNome',fld:'PRODUTONOME',pic:'',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV42InOutProdutoId',fld:'vINOUTPRODUTOID',pic:'ZZZ9'},{av:'AV43InOutProdutoNome',fld:'vINOUTPRODUTONOME',pic:''}]}");
         setEventMetadata("'ADDDYNAMICFILTERS1'","{handler:'E220S2',iparms:[]");
         setEventMetadata("'ADDDYNAMICFILTERS1'",",oparms:[{av:'AV16DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'}]}");
         setEventMetadata("'REMOVEDYNAMICFILTERS1'","{handler:'E180S2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV17DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV18DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV19ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV21DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV22DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV23ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV16DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV20DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV28ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_ProdutoDescricaoTitleControlIdToReplace',fld:'vDDO_PRODUTODESCRICAOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_ProdutoDtValidadeTitleControlIdToReplace',fld:'vDDO_PRODUTODTVALIDADETITLECONTROLIDTOREPLACE',pic:''},{av:'AV8GridState',fld:'vGRIDSTATE',pic:''},{av:'AV25DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV24DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''}]");
         setEventMetadata("'REMOVEDYNAMICFILTERS1'",",oparms:[{av:'AV24DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'AV25DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV8GridState',fld:'vGRIDSTATE',pic:''},{av:'AV16DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV17DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV18DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV19ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'AV20DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV21DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV22DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV23ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'lblJsdynamicfilters_Caption',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{av:'edtavProdutonome2_Visible',ctrl:'vPRODUTONOME2',prop:'Visible'},{av:'edtavProdutonome3_Visible',ctrl:'vPRODUTONOME3',prop:'Visible'},{av:'edtavProdutonome1_Visible',ctrl:'vPRODUTONOME1',prop:'Visible'},{av:'AV27ProdutoIdTitleFilterData',fld:'vPRODUTOIDTITLEFILTERDATA',pic:''},{av:'AV29ProdutoNomeTitleFilterData',fld:'vPRODUTONOMETITLEFILTERDATA',pic:''},{av:'AV31ProdutoDescricaoTitleFilterData',fld:'vPRODUTODESCRICAOTITLEFILTERDATA',pic:''},{av:'AV33ProdutoValorTitleFilterData',fld:'vPRODUTOVALORTITLEFILTERDATA',pic:''},{av:'AV35ProdutoDtValidadeTitleFilterData',fld:'vPRODUTODTVALIDADETITLEFILTERDATA',pic:''},{av:'edtProdutoId_Titleformat',ctrl:'PRODUTOID',prop:'Titleformat'},{av:'edtProdutoId_Title',ctrl:'PRODUTOID',prop:'Title'},{av:'edtProdutoNome_Titleformat',ctrl:'PRODUTONOME',prop:'Titleformat'},{av:'edtProdutoNome_Title',ctrl:'PRODUTONOME',prop:'Title'},{av:'edtProdutoDescricao_Titleformat',ctrl:'PRODUTODESCRICAO',prop:'Titleformat'},{av:'edtProdutoDescricao_Title',ctrl:'PRODUTODESCRICAO',prop:'Title'},{av:'edtProdutoValor_Titleformat',ctrl:'PRODUTOVALOR',prop:'Titleformat'},{av:'edtProdutoValor_Title',ctrl:'PRODUTOVALOR',prop:'Title'},{av:'edtProdutoDtValidade_Titleformat',ctrl:'PRODUTODTVALIDADE',prop:'Titleformat'},{av:'edtProdutoDtValidade_Title',ctrl:'PRODUTODTVALIDADE',prop:'Title'},{av:'AV39GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV40GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("VDYNAMICFILTERSSELECTOR1.CLICK","{handler:'E280S1',iparms:[{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''}]");
         setEventMetadata("VDYNAMICFILTERSSELECTOR1.CLICK",",oparms:[{av:'edtavProdutonome1_Visible',ctrl:'vPRODUTONOME1',prop:'Visible'},{av:'cmbavDynamicfiltersoperator1'}]}");
         setEventMetadata("'ADDDYNAMICFILTERS2'","{handler:'E230S2',iparms:[]");
         setEventMetadata("'ADDDYNAMICFILTERS2'",",oparms:[{av:'AV20DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'}]}");
         setEventMetadata("'REMOVEDYNAMICFILTERS2'","{handler:'E190S2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV17DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV18DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV19ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV21DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV22DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV23ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV16DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV20DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV28ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_ProdutoDescricaoTitleControlIdToReplace',fld:'vDDO_PRODUTODESCRICAOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_ProdutoDtValidadeTitleControlIdToReplace',fld:'vDDO_PRODUTODTVALIDADETITLECONTROLIDTOREPLACE',pic:''},{av:'AV8GridState',fld:'vGRIDSTATE',pic:''},{av:'AV25DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV24DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''}]");
         setEventMetadata("'REMOVEDYNAMICFILTERS2'",",oparms:[{av:'AV24DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'AV16DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV8GridState',fld:'vGRIDSTATE',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV17DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV18DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV19ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'AV20DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV21DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV22DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV23ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'lblJsdynamicfilters_Caption',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{av:'edtavProdutonome2_Visible',ctrl:'vPRODUTONOME2',prop:'Visible'},{av:'edtavProdutonome3_Visible',ctrl:'vPRODUTONOME3',prop:'Visible'},{av:'edtavProdutonome1_Visible',ctrl:'vPRODUTONOME1',prop:'Visible'},{av:'AV27ProdutoIdTitleFilterData',fld:'vPRODUTOIDTITLEFILTERDATA',pic:''},{av:'AV29ProdutoNomeTitleFilterData',fld:'vPRODUTONOMETITLEFILTERDATA',pic:''},{av:'AV31ProdutoDescricaoTitleFilterData',fld:'vPRODUTODESCRICAOTITLEFILTERDATA',pic:''},{av:'AV33ProdutoValorTitleFilterData',fld:'vPRODUTOVALORTITLEFILTERDATA',pic:''},{av:'AV35ProdutoDtValidadeTitleFilterData',fld:'vPRODUTODTVALIDADETITLEFILTERDATA',pic:''},{av:'edtProdutoId_Titleformat',ctrl:'PRODUTOID',prop:'Titleformat'},{av:'edtProdutoId_Title',ctrl:'PRODUTOID',prop:'Title'},{av:'edtProdutoNome_Titleformat',ctrl:'PRODUTONOME',prop:'Titleformat'},{av:'edtProdutoNome_Title',ctrl:'PRODUTONOME',prop:'Title'},{av:'edtProdutoDescricao_Titleformat',ctrl:'PRODUTODESCRICAO',prop:'Titleformat'},{av:'edtProdutoDescricao_Title',ctrl:'PRODUTODESCRICAO',prop:'Title'},{av:'edtProdutoValor_Titleformat',ctrl:'PRODUTOVALOR',prop:'Titleformat'},{av:'edtProdutoValor_Title',ctrl:'PRODUTOVALOR',prop:'Title'},{av:'edtProdutoDtValidade_Titleformat',ctrl:'PRODUTODTVALIDADE',prop:'Titleformat'},{av:'edtProdutoDtValidade_Title',ctrl:'PRODUTODTVALIDADE',prop:'Title'},{av:'AV39GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV40GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("VDYNAMICFILTERSSELECTOR2.CLICK","{handler:'E290S1',iparms:[{av:'cmbavDynamicfiltersselector2'},{av:'AV17DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''}]");
         setEventMetadata("VDYNAMICFILTERSSELECTOR2.CLICK",",oparms:[{av:'edtavProdutonome2_Visible',ctrl:'vPRODUTONOME2',prop:'Visible'},{av:'cmbavDynamicfiltersoperator2'}]}");
         setEventMetadata("'REMOVEDYNAMICFILTERS3'","{handler:'E200S2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV17DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV18DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV19ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV21DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV22DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV23ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV16DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV20DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV28ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_ProdutoDescricaoTitleControlIdToReplace',fld:'vDDO_PRODUTODESCRICAOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_ProdutoDtValidadeTitleControlIdToReplace',fld:'vDDO_PRODUTODTVALIDADETITLECONTROLIDTOREPLACE',pic:''},{av:'AV8GridState',fld:'vGRIDSTATE',pic:''},{av:'AV25DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV24DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''}]");
         setEventMetadata("'REMOVEDYNAMICFILTERS3'",",oparms:[{av:'AV24DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'AV20DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV8GridState',fld:'vGRIDSTATE',pic:''},{av:'AV16DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV17DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV18DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV19ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV21DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV22DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV23ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'lblJsdynamicfilters_Caption',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{av:'edtavProdutonome2_Visible',ctrl:'vPRODUTONOME2',prop:'Visible'},{av:'edtavProdutonome3_Visible',ctrl:'vPRODUTONOME3',prop:'Visible'},{av:'edtavProdutonome1_Visible',ctrl:'vPRODUTONOME1',prop:'Visible'},{av:'AV27ProdutoIdTitleFilterData',fld:'vPRODUTOIDTITLEFILTERDATA',pic:''},{av:'AV29ProdutoNomeTitleFilterData',fld:'vPRODUTONOMETITLEFILTERDATA',pic:''},{av:'AV31ProdutoDescricaoTitleFilterData',fld:'vPRODUTODESCRICAOTITLEFILTERDATA',pic:''},{av:'AV33ProdutoValorTitleFilterData',fld:'vPRODUTOVALORTITLEFILTERDATA',pic:''},{av:'AV35ProdutoDtValidadeTitleFilterData',fld:'vPRODUTODTVALIDADETITLEFILTERDATA',pic:''},{av:'edtProdutoId_Titleformat',ctrl:'PRODUTOID',prop:'Titleformat'},{av:'edtProdutoId_Title',ctrl:'PRODUTOID',prop:'Title'},{av:'edtProdutoNome_Titleformat',ctrl:'PRODUTONOME',prop:'Titleformat'},{av:'edtProdutoNome_Title',ctrl:'PRODUTONOME',prop:'Title'},{av:'edtProdutoDescricao_Titleformat',ctrl:'PRODUTODESCRICAO',prop:'Titleformat'},{av:'edtProdutoDescricao_Title',ctrl:'PRODUTODESCRICAO',prop:'Title'},{av:'edtProdutoValor_Titleformat',ctrl:'PRODUTOVALOR',prop:'Titleformat'},{av:'edtProdutoValor_Title',ctrl:'PRODUTOVALOR',prop:'Title'},{av:'edtProdutoDtValidade_Titleformat',ctrl:'PRODUTODTVALIDADE',prop:'Titleformat'},{av:'edtProdutoDtValidade_Title',ctrl:'PRODUTODTVALIDADE',prop:'Title'},{av:'AV39GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV40GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("VDYNAMICFILTERSSELECTOR3.CLICK","{handler:'E300S1',iparms:[{av:'cmbavDynamicfiltersselector3'},{av:'AV21DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''}]");
         setEventMetadata("VDYNAMICFILTERSSELECTOR3.CLICK",",oparms:[{av:'edtavProdutonome3_Visible',ctrl:'vPRODUTONOME3',prop:'Visible'},{av:'cmbavDynamicfiltersoperator3'}]}");
         setEventMetadata("'DOCLEANFILTERS'","{handler:'E210S2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV17DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV18DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV19ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV21DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV22DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV23ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV16DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV20DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV28ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_ProdutoDescricaoTitleControlIdToReplace',fld:'vDDO_PRODUTODESCRICAOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_ProdutoDtValidadeTitleControlIdToReplace',fld:'vDDO_PRODUTODTVALIDADETITLECONTROLIDTOREPLACE',pic:''},{av:'AV8GridState',fld:'vGRIDSTATE',pic:''},{av:'AV24DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''}]");
         setEventMetadata("'DOCLEANFILTERS'",",oparms:[{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'AV8GridState',fld:'vGRIDSTATE',pic:''},{av:'edtavProdutonome1_Visible',ctrl:'vPRODUTONOME1',prop:'Visible'},{av:'AV16DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV17DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV18DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV19ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'AV20DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV21DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV22DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV23ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'lblJsdynamicfilters_Caption',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{av:'edtavProdutonome2_Visible',ctrl:'vPRODUTONOME2',prop:'Visible'},{av:'edtavProdutonome3_Visible',ctrl:'vPRODUTONOME3',prop:'Visible'},{av:'AV27ProdutoIdTitleFilterData',fld:'vPRODUTOIDTITLEFILTERDATA',pic:''},{av:'AV29ProdutoNomeTitleFilterData',fld:'vPRODUTONOMETITLEFILTERDATA',pic:''},{av:'AV31ProdutoDescricaoTitleFilterData',fld:'vPRODUTODESCRICAOTITLEFILTERDATA',pic:''},{av:'AV33ProdutoValorTitleFilterData',fld:'vPRODUTOVALORTITLEFILTERDATA',pic:''},{av:'AV35ProdutoDtValidadeTitleFilterData',fld:'vPRODUTODTVALIDADETITLEFILTERDATA',pic:''},{av:'edtProdutoId_Titleformat',ctrl:'PRODUTOID',prop:'Titleformat'},{av:'edtProdutoId_Title',ctrl:'PRODUTOID',prop:'Title'},{av:'edtProdutoNome_Titleformat',ctrl:'PRODUTONOME',prop:'Titleformat'},{av:'edtProdutoNome_Title',ctrl:'PRODUTONOME',prop:'Title'},{av:'edtProdutoDescricao_Titleformat',ctrl:'PRODUTODESCRICAO',prop:'Titleformat'},{av:'edtProdutoDescricao_Title',ctrl:'PRODUTODESCRICAO',prop:'Title'},{av:'edtProdutoValor_Titleformat',ctrl:'PRODUTOVALOR',prop:'Titleformat'},{av:'edtProdutoValor_Title',ctrl:'PRODUTOVALOR',prop:'Title'},{av:'edtProdutoDtValidade_Titleformat',ctrl:'PRODUTODTVALIDADE',prop:'Titleformat'},{av:'edtProdutoDtValidade_Title',ctrl:'PRODUTODTVALIDADE',prop:'Title'},{av:'AV39GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV40GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
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
         wcpOAV43InOutProdutoNome = "";
         Gridpaginationbar_Selectedpage = "";
         Ddo_produtoid_Activeeventkey = "";
         Ddo_produtonome_Activeeventkey = "";
         Ddo_produtodescricao_Activeeventkey = "";
         Ddo_produtovalor_Activeeventkey = "";
         Ddo_produtodtvalidade_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV13DynamicFiltersSelector1 = "";
         AV15ProdutoNome1 = "";
         AV17DynamicFiltersSelector2 = "";
         AV19ProdutoNome2 = "";
         AV21DynamicFiltersSelector3 = "";
         AV23ProdutoNome3 = "";
         AV28ddo_ProdutoIdTitleControlIdToReplace = "";
         AV30ddo_ProdutoNomeTitleControlIdToReplace = "";
         AV32ddo_ProdutoDescricaoTitleControlIdToReplace = "";
         AV34ddo_ProdutoValorTitleControlIdToReplace = "";
         AV36ddo_ProdutoDtValidadeTitleControlIdToReplace = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV37DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV27ProdutoIdTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV29ProdutoNomeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV31ProdutoDescricaoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV33ProdutoValorTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV35ProdutoDtValidadeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV8GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         Ddo_produtoid_Sortedstatus = "";
         Ddo_produtonome_Sortedstatus = "";
         Ddo_produtodescricao_Sortedstatus = "";
         Ddo_produtovalor_Sortedstatus = "";
         Ddo_produtodtvalidade_Sortedstatus = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ucDvpanel_tableheader = new GXUserControl();
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV41Select = "";
         A9ProdutoNome = "";
         A10ProdutoDescricao = "";
         A12ProdutoDtValidade = DateTime.MinValue;
         ucGridpaginationbar = new GXUserControl();
         lblJsdynamicfilters_Jsonclick = "";
         ucDdo_produtoid = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         ucDdo_produtonome = new GXUserControl();
         ucDdo_produtodescricao = new GXUserControl();
         ucDdo_produtovalor = new GXUserControl();
         ucDdo_produtodtvalidade = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV46Select_GXI = "";
         scmdbuf = "";
         lV15ProdutoNome1 = "";
         lV19ProdutoNome2 = "";
         lV23ProdutoNome3 = "";
         H000S2_A12ProdutoDtValidade = new DateTime[] {DateTime.MinValue} ;
         H000S2_A11ProdutoValor = new decimal[1] ;
         H000S2_A10ProdutoDescricao = new String[] {""} ;
         H000S2_A9ProdutoNome = new String[] {""} ;
         H000S2_A8ProdutoId = new short[1] ;
         H000S3_AGRID_nRecordCount = new long[1] ;
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
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.produtoprompt__default(),
            new Object[][] {
                new Object[] {
               H000S2_A12ProdutoDtValidade, H000S2_A11ProdutoValor, H000S2_A10ProdutoDescricao, H000S2_A9ProdutoNome, H000S2_A8ProdutoId
               }
               , new Object[] {
               H000S3_AGRID_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV42InOutProdutoId ;
      private short wcpOAV42InOutProdutoId ;
      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_95 ;
      private short nGXsfl_95_idx=1 ;
      private short GRID_nEOF ;
      private short AV14DynamicFiltersOperator1 ;
      private short AV18DynamicFiltersOperator2 ;
      private short AV22DynamicFiltersOperator3 ;
      private short AV11OrderedBy ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtProdutoId_Titleformat ;
      private short edtProdutoNome_Titleformat ;
      private short edtProdutoDescricao_Titleformat ;
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
      private int edtavDdo_produtoidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_produtonometitlecontrolidtoreplace_Visible ;
      private int edtavDdo_produtodescricaotitlecontrolidtoreplace_Visible ;
      private int edtavDdo_produtovalortitlecontrolidtoreplace_Visible ;
      private int edtavDdo_produtodtvalidadetitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV38PageToGo ;
      private int imgAdddynamicfilters1_Visible ;
      private int imgRemovedynamicfilters1_Visible ;
      private int imgAdddynamicfilters2_Visible ;
      private int imgRemovedynamicfilters2_Visible ;
      private int edtavProdutonome1_Visible ;
      private int edtavProdutonome2_Visible ;
      private int edtavProdutonome3_Visible ;
      private int edtavProdutonome3_Enabled ;
      private int edtavProdutonome2_Enabled ;
      private int edtavProdutonome1_Enabled ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavSelect_Enabled ;
      private int edtavSelect_Visible ;
      private long GRID_nFirstRecordOnPage ;
      private long AV39GridCurrentPage ;
      private long AV40GridPageCount ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private decimal A11ProdutoValor ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_produtoid_Activeeventkey ;
      private String Ddo_produtonome_Activeeventkey ;
      private String Ddo_produtodescricao_Activeeventkey ;
      private String Ddo_produtovalor_Activeeventkey ;
      private String Ddo_produtodtvalidade_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_95_idx="0001" ;
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
      private String Ddo_produtoid_Caption ;
      private String Ddo_produtoid_Tooltip ;
      private String Ddo_produtoid_Cls ;
      private String Ddo_produtoid_Dropdownoptionstype ;
      private String Ddo_produtoid_Titlecontrolidtoreplace ;
      private String Ddo_produtoid_Sortedstatus ;
      private String Ddo_produtoid_Sortasc ;
      private String Ddo_produtoid_Sortdsc ;
      private String Ddo_produtoid_Cleanfilter ;
      private String Ddo_produtoid_Searchbuttontext ;
      private String Ddo_produtonome_Caption ;
      private String Ddo_produtonome_Tooltip ;
      private String Ddo_produtonome_Cls ;
      private String Ddo_produtonome_Dropdownoptionstype ;
      private String Ddo_produtonome_Titlecontrolidtoreplace ;
      private String Ddo_produtonome_Sortedstatus ;
      private String Ddo_produtonome_Sortasc ;
      private String Ddo_produtonome_Sortdsc ;
      private String Ddo_produtonome_Cleanfilter ;
      private String Ddo_produtonome_Searchbuttontext ;
      private String Ddo_produtodescricao_Caption ;
      private String Ddo_produtodescricao_Tooltip ;
      private String Ddo_produtodescricao_Cls ;
      private String Ddo_produtodescricao_Dropdownoptionstype ;
      private String Ddo_produtodescricao_Titlecontrolidtoreplace ;
      private String Ddo_produtodescricao_Sortedstatus ;
      private String Ddo_produtodescricao_Sortasc ;
      private String Ddo_produtodescricao_Sortdsc ;
      private String Ddo_produtodescricao_Cleanfilter ;
      private String Ddo_produtodescricao_Searchbuttontext ;
      private String Ddo_produtovalor_Caption ;
      private String Ddo_produtovalor_Tooltip ;
      private String Ddo_produtovalor_Cls ;
      private String Ddo_produtovalor_Dropdownoptionstype ;
      private String Ddo_produtovalor_Titlecontrolidtoreplace ;
      private String Ddo_produtovalor_Sortedstatus ;
      private String Ddo_produtovalor_Sortasc ;
      private String Ddo_produtovalor_Sortdsc ;
      private String Ddo_produtovalor_Cleanfilter ;
      private String Ddo_produtovalor_Searchbuttontext ;
      private String Ddo_produtodtvalidade_Caption ;
      private String Ddo_produtodtvalidade_Tooltip ;
      private String Ddo_produtodtvalidade_Cls ;
      private String Ddo_produtodtvalidade_Dropdownoptionstype ;
      private String Ddo_produtodtvalidade_Titlecontrolidtoreplace ;
      private String Ddo_produtodtvalidade_Sortedstatus ;
      private String Ddo_produtodtvalidade_Sortasc ;
      private String Ddo_produtodtvalidade_Sortdsc ;
      private String Ddo_produtodtvalidade_Cleanfilter ;
      private String Ddo_produtodtvalidade_Searchbuttontext ;
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
      private String edtProdutoId_Title ;
      private String edtProdutoNome_Title ;
      private String edtProdutoDescricao_Title ;
      private String edtProdutoValor_Title ;
      private String edtProdutoDtValidade_Title ;
      private String subGrid_Header ;
      private String edtavSelect_Tooltiptext ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String lblJsdynamicfilters_Internalname ;
      private String lblJsdynamicfilters_Caption ;
      private String lblJsdynamicfilters_Jsonclick ;
      private String Ddo_produtoid_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String edtavDdo_produtoidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_produtonome_Internalname ;
      private String edtavDdo_produtonometitlecontrolidtoreplace_Internalname ;
      private String Ddo_produtodescricao_Internalname ;
      private String edtavDdo_produtodescricaotitlecontrolidtoreplace_Internalname ;
      private String Ddo_produtovalor_Internalname ;
      private String edtavDdo_produtovalortitlecontrolidtoreplace_Internalname ;
      private String Ddo_produtodtvalidade_Internalname ;
      private String edtavDdo_produtodtvalidadetitlecontrolidtoreplace_Internalname ;
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
      private String sGXsfl_95_fel_idx="0001" ;
      private String edtavSelect_Jsonclick ;
      private String ROClassString ;
      private String edtProdutoId_Jsonclick ;
      private String edtProdutoNome_Jsonclick ;
      private String edtProdutoDescricao_Jsonclick ;
      private String edtProdutoValor_Jsonclick ;
      private String edtProdutoDtValidade_Jsonclick ;
      private DateTime A12ProdutoDtValidade ;
      private bool entryPointCalled ;
      private bool AV16DynamicFiltersEnabled2 ;
      private bool AV20DynamicFiltersEnabled3 ;
      private bool AV12OrderedDsc ;
      private bool toggleJsOutput ;
      private bool AV25DynamicFiltersIgnoreFirst ;
      private bool AV24DynamicFiltersRemoving ;
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
      private bool Ddo_produtoid_Includedatalist ;
      private bool Ddo_produtonome_Includesortasc ;
      private bool Ddo_produtonome_Includesortdsc ;
      private bool Ddo_produtonome_Includefilter ;
      private bool Ddo_produtonome_Includedatalist ;
      private bool Ddo_produtodescricao_Includesortasc ;
      private bool Ddo_produtodescricao_Includesortdsc ;
      private bool Ddo_produtodescricao_Includefilter ;
      private bool Ddo_produtodescricao_Includedatalist ;
      private bool Ddo_produtovalor_Includesortasc ;
      private bool Ddo_produtovalor_Includesortdsc ;
      private bool Ddo_produtovalor_Includefilter ;
      private bool Ddo_produtovalor_Includedatalist ;
      private bool Ddo_produtodtvalidade_Includesortasc ;
      private bool Ddo_produtodtvalidade_Includesortdsc ;
      private bool Ddo_produtodtvalidade_Includefilter ;
      private bool Ddo_produtodtvalidade_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_95_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV41Select_IsBlob ;
      private String AV43InOutProdutoNome ;
      private String wcpOAV43InOutProdutoNome ;
      private String AV13DynamicFiltersSelector1 ;
      private String AV15ProdutoNome1 ;
      private String AV17DynamicFiltersSelector2 ;
      private String AV19ProdutoNome2 ;
      private String AV21DynamicFiltersSelector3 ;
      private String AV23ProdutoNome3 ;
      private String AV28ddo_ProdutoIdTitleControlIdToReplace ;
      private String AV30ddo_ProdutoNomeTitleControlIdToReplace ;
      private String AV32ddo_ProdutoDescricaoTitleControlIdToReplace ;
      private String AV34ddo_ProdutoValorTitleControlIdToReplace ;
      private String AV36ddo_ProdutoDtValidadeTitleControlIdToReplace ;
      private String A9ProdutoNome ;
      private String A10ProdutoDescricao ;
      private String AV46Select_GXI ;
      private String lV15ProdutoNome1 ;
      private String lV19ProdutoNome2 ;
      private String lV23ProdutoNome3 ;
      private String AV41Select ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_produtoid ;
      private GXUserControl ucDdo_produtonome ;
      private GXUserControl ucDdo_produtodescricao ;
      private GXUserControl ucDdo_produtovalor ;
      private GXUserControl ucDdo_produtodtvalidade ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private IGxDataStore dsDefault ;
      private short aP0_InOutProdutoId ;
      private String aP1_InOutProdutoNome ;
      private GXCombobox cmbavDynamicfiltersselector1 ;
      private GXCombobox cmbavDynamicfiltersoperator1 ;
      private GXCombobox cmbavDynamicfiltersselector2 ;
      private GXCombobox cmbavDynamicfiltersoperator2 ;
      private GXCombobox cmbavDynamicfiltersselector3 ;
      private GXCombobox cmbavDynamicfiltersoperator3 ;
      private GXCheckbox chkavDynamicfiltersenabled2 ;
      private GXCheckbox chkavDynamicfiltersenabled3 ;
      private IDataStoreProvider pr_default ;
      private DateTime[] H000S2_A12ProdutoDtValidade ;
      private decimal[] H000S2_A11ProdutoValor ;
      private String[] H000S2_A10ProdutoDescricao ;
      private String[] H000S2_A9ProdutoNome ;
      private short[] H000S2_A8ProdutoId ;
      private long[] H000S3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV27ProdutoIdTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV29ProdutoNomeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV31ProdutoDescricaoTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV33ProdutoValorTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV35ProdutoDtValidadeTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV8GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter AV10GridStateDynamicFilter ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV37DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class produtoprompt__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H000S2( IGxContext context ,
                                             String AV13DynamicFiltersSelector1 ,
                                             short AV14DynamicFiltersOperator1 ,
                                             String AV15ProdutoNome1 ,
                                             bool AV16DynamicFiltersEnabled2 ,
                                             String AV17DynamicFiltersSelector2 ,
                                             short AV18DynamicFiltersOperator2 ,
                                             String AV19ProdutoNome2 ,
                                             bool AV20DynamicFiltersEnabled3 ,
                                             String AV21DynamicFiltersSelector3 ,
                                             short AV22DynamicFiltersOperator3 ,
                                             String AV23ProdutoNome3 ,
                                             String A9ProdutoNome ,
                                             short AV11OrderedBy ,
                                             bool AV12OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [9] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [ProdutoDtValidade], [ProdutoValor], [ProdutoDescricao], [ProdutoNome], [ProdutoId]";
         sFromString = " FROM [Produto]";
         sOrderString = "";
         if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PRODUTONOME") == 0 ) && ( AV14DynamicFiltersOperator1 == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV15ProdutoNome1)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoNome] like @lV15ProdutoNome1)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoNome] like @lV15ProdutoNome1)";
            }
         }
         else
         {
            GXv_int2[0] = 1;
         }
         if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PRODUTONOME") == 0 ) && ( AV14DynamicFiltersOperator1 == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV15ProdutoNome1)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoNome] like '%' + @lV15ProdutoNome1)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoNome] like '%' + @lV15ProdutoNome1)";
            }
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( AV16DynamicFiltersEnabled2 && ( StringUtil.StrCmp(AV17DynamicFiltersSelector2, "PRODUTONOME") == 0 ) && ( AV18DynamicFiltersOperator2 == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV19ProdutoNome2)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoNome] like @lV19ProdutoNome2)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoNome] like @lV19ProdutoNome2)";
            }
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( AV16DynamicFiltersEnabled2 && ( StringUtil.StrCmp(AV17DynamicFiltersSelector2, "PRODUTONOME") == 0 ) && ( AV18DynamicFiltersOperator2 == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV19ProdutoNome2)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoNome] like '%' + @lV19ProdutoNome2)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoNome] like '%' + @lV19ProdutoNome2)";
            }
         }
         else
         {
            GXv_int2[3] = 1;
         }
         if ( AV20DynamicFiltersEnabled3 && ( StringUtil.StrCmp(AV21DynamicFiltersSelector3, "PRODUTONOME") == 0 ) && ( AV22DynamicFiltersOperator3 == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV23ProdutoNome3)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoNome] like @lV23ProdutoNome3)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoNome] like @lV23ProdutoNome3)";
            }
         }
         else
         {
            GXv_int2[4] = 1;
         }
         if ( AV20DynamicFiltersEnabled3 && ( StringUtil.StrCmp(AV21DynamicFiltersSelector3, "PRODUTONOME") == 0 ) && ( AV22DynamicFiltersOperator3 == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV23ProdutoNome3)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoNome] like '%' + @lV23ProdutoNome3)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoNome] like '%' + @lV23ProdutoNome3)";
            }
         }
         else
         {
            GXv_int2[5] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         if ( ( AV11OrderedBy == 1 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [ProdutoNome]";
         }
         else if ( ( AV11OrderedBy == 1 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [ProdutoNome] DESC";
         }
         else if ( ( AV11OrderedBy == 2 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [ProdutoId]";
         }
         else if ( ( AV11OrderedBy == 2 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [ProdutoId] DESC";
         }
         else if ( ( AV11OrderedBy == 3 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [ProdutoDescricao]";
         }
         else if ( ( AV11OrderedBy == 3 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [ProdutoDescricao] DESC";
         }
         else if ( ( AV11OrderedBy == 4 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [ProdutoValor]";
         }
         else if ( ( AV11OrderedBy == 4 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [ProdutoValor] DESC";
         }
         else if ( ( AV11OrderedBy == 5 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [ProdutoDtValidade]";
         }
         else if ( ( AV11OrderedBy == 5 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [ProdutoDtValidade] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [ProdutoId]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      protected Object[] conditional_H000S3( IGxContext context ,
                                             String AV13DynamicFiltersSelector1 ,
                                             short AV14DynamicFiltersOperator1 ,
                                             String AV15ProdutoNome1 ,
                                             bool AV16DynamicFiltersEnabled2 ,
                                             String AV17DynamicFiltersSelector2 ,
                                             short AV18DynamicFiltersOperator2 ,
                                             String AV19ProdutoNome2 ,
                                             bool AV20DynamicFiltersEnabled3 ,
                                             String AV21DynamicFiltersSelector3 ,
                                             short AV22DynamicFiltersOperator3 ,
                                             String AV23ProdutoNome3 ,
                                             String A9ProdutoNome ,
                                             short AV11OrderedBy ,
                                             bool AV12OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [6] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [Produto]";
         if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PRODUTONOME") == 0 ) && ( AV14DynamicFiltersOperator1 == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV15ProdutoNome1)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoNome] like @lV15ProdutoNome1)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoNome] like @lV15ProdutoNome1)";
            }
         }
         else
         {
            GXv_int4[0] = 1;
         }
         if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PRODUTONOME") == 0 ) && ( AV14DynamicFiltersOperator1 == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV15ProdutoNome1)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoNome] like '%' + @lV15ProdutoNome1)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoNome] like '%' + @lV15ProdutoNome1)";
            }
         }
         else
         {
            GXv_int4[1] = 1;
         }
         if ( AV16DynamicFiltersEnabled2 && ( StringUtil.StrCmp(AV17DynamicFiltersSelector2, "PRODUTONOME") == 0 ) && ( AV18DynamicFiltersOperator2 == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV19ProdutoNome2)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoNome] like @lV19ProdutoNome2)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoNome] like @lV19ProdutoNome2)";
            }
         }
         else
         {
            GXv_int4[2] = 1;
         }
         if ( AV16DynamicFiltersEnabled2 && ( StringUtil.StrCmp(AV17DynamicFiltersSelector2, "PRODUTONOME") == 0 ) && ( AV18DynamicFiltersOperator2 == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV19ProdutoNome2)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoNome] like '%' + @lV19ProdutoNome2)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoNome] like '%' + @lV19ProdutoNome2)";
            }
         }
         else
         {
            GXv_int4[3] = 1;
         }
         if ( AV20DynamicFiltersEnabled3 && ( StringUtil.StrCmp(AV21DynamicFiltersSelector3, "PRODUTONOME") == 0 ) && ( AV22DynamicFiltersOperator3 == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV23ProdutoNome3)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoNome] like @lV23ProdutoNome3)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoNome] like @lV23ProdutoNome3)";
            }
         }
         else
         {
            GXv_int4[4] = 1;
         }
         if ( AV20DynamicFiltersEnabled3 && ( StringUtil.StrCmp(AV21DynamicFiltersSelector3, "PRODUTONOME") == 0 ) && ( AV22DynamicFiltersOperator3 == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV23ProdutoNome3)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ProdutoNome] like '%' + @lV23ProdutoNome3)";
            }
            else
            {
               sWhereString = sWhereString + " ([ProdutoNome] like '%' + @lV23ProdutoNome3)";
            }
         }
         else
         {
            GXv_int4[5] = 1;
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
                     return conditional_H000S2(context, (String)dynConstraints[0] , (short)dynConstraints[1] , (String)dynConstraints[2] , (bool)dynConstraints[3] , (String)dynConstraints[4] , (short)dynConstraints[5] , (String)dynConstraints[6] , (bool)dynConstraints[7] , (String)dynConstraints[8] , (short)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (short)dynConstraints[12] , (bool)dynConstraints[13] );
               case 1 :
                     return conditional_H000S3(context, (String)dynConstraints[0] , (short)dynConstraints[1] , (String)dynConstraints[2] , (bool)dynConstraints[3] , (String)dynConstraints[4] , (short)dynConstraints[5] , (String)dynConstraints[6] , (bool)dynConstraints[7] , (String)dynConstraints[8] , (short)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (short)dynConstraints[12] , (bool)dynConstraints[13] );
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
          Object[] prmH000S2 ;
          prmH000S2 = new Object[] {
          new Object[] {"@lV15ProdutoNome1",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV15ProdutoNome1",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV19ProdutoNome2",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV19ProdutoNome2",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV23ProdutoNome3",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV23ProdutoNome3",SqlDbType.VarChar,50,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH000S3 ;
          prmH000S3 = new Object[] {
          new Object[] {"@lV15ProdutoNome1",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV15ProdutoNome1",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV19ProdutoNome2",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV19ProdutoNome2",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV23ProdutoNome3",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV23ProdutoNome3",SqlDbType.VarChar,50,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000S2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000S2,11, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("H000S3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000S3,1, GxCacheFrequency.OFF ,true,false )
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
                   stmt.SetParameter(sIdx, (String)parms[9]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[15]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[16]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[17]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[6]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[7]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[8]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[9]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                return;
       }
    }

 }

}
