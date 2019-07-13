/*
               File: PessoaWW
        Description:  Pessoa
             Author: GeneXus C# Generator version 16_0_2-131213
       Generated on: 7/12/2019 18:14:40.2
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
   public class pessoaww : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public pessoaww( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public pessoaww( IGxContext context )
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
         cmbavPessoaemailoperator = new GXCombobox();
         cmbPessoaSexo = new GXCombobox();
         chkPessoaSituacao = new GXCheckbox();
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
               nRC_GXsfl_67 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_67_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_67_idx = GetNextPar( );
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
               AV74PessoaNomeOperator = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV75PessoaNome = GetNextPar( );
               AV76PessoaEmailOperator = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV77PessoaEmail = GetNextPar( );
               AV12OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV13OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV42TFPessoaId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV43TFPessoaId_To = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV46TFPessoaNome = GetNextPar( );
               AV47TFPessoaNome_Sel = GetNextPar( );
               AV54TFPessoaTelefone = GetNextPar( );
               AV55TFPessoaTelefone_Sel = GetNextPar( );
               AV58TFPessoaEmail = GetNextPar( );
               AV59TFPessoaEmail_Sel = GetNextPar( );
               AV66TFPessoaSituacao_Sel = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV35ManageFiltersExecutionStep = (short)(NumberUtil.Val( GetNextPar( ), "."));
               ajax_req_read_hidden_sdt(GetNextPar( ), AV27ColumnsSelector);
               AV44ddo_PessoaIdTitleControlIdToReplace = GetNextPar( );
               AV48ddo_PessoaNomeTitleControlIdToReplace = GetNextPar( );
               AV56ddo_PessoaTelefoneTitleControlIdToReplace = GetNextPar( );
               AV60ddo_PessoaEmailTitleControlIdToReplace = GetNextPar( );
               AV67ddo_PessoaSituacaoTitleControlIdToReplace = GetNextPar( );
               AV92Pgmname = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV74PessoaNomeOperator, AV75PessoaNome, AV76PessoaEmailOperator, AV77PessoaEmail, AV12OrderedBy, AV13OrderedDsc, AV42TFPessoaId, AV43TFPessoaId_To, AV46TFPessoaNome, AV47TFPessoaNome_Sel, AV54TFPessoaTelefone, AV55TFPessoaTelefone_Sel, AV58TFPessoaEmail, AV59TFPessoaEmail_Sel, AV66TFPessoaSituacao_Sel, AV35ManageFiltersExecutionStep, AV27ColumnsSelector, AV44ddo_PessoaIdTitleControlIdToReplace, AV48ddo_PessoaNomeTitleControlIdToReplace, AV56ddo_PessoaTelefoneTitleControlIdToReplace, AV60ddo_PessoaEmailTitleControlIdToReplace, AV67ddo_PessoaSituacaoTitleControlIdToReplace, AV92Pgmname) ;
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
         PA0M2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0M2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?201971218144033", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("pessoaww.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vPESSOANOMEOPERATOR", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV74PessoaNomeOperator), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vPESSOANOME", AV75PessoaNome);
         GxWebStd.gx_hidden_field( context, "GXH_vPESSOAEMAILOPERATOR", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV76PessoaEmailOperator), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vPESSOAEMAIL", AV77PessoaEmail);
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12OrderedBy), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV13OrderedDsc));
         GxWebStd.gx_hidden_field( context, "GXH_vTFPESSOAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV42TFPessoaId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFPESSOAID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV43TFPessoaId_To), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFPESSOANOME", AV46TFPessoaNome);
         GxWebStd.gx_hidden_field( context, "GXH_vTFPESSOANOME_SEL", AV47TFPessoaNome_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFPESSOATELEFONE", AV54TFPessoaTelefone);
         GxWebStd.gx_hidden_field( context, "GXH_vTFPESSOATELEFONE_SEL", AV55TFPessoaTelefone_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFPESSOAEMAIL", AV58TFPessoaEmail);
         GxWebStd.gx_hidden_field( context, "GXH_vTFPESSOAEMAIL_SEL", AV59TFPessoaEmail_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFPESSOASITUACAO_SEL", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV66TFPessoaSituacao_Sel), 1, 0, ",", "")));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_67", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_67), 4, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vMANAGEFILTERSDATA", AV39ManageFiltersData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vMANAGEFILTERSDATA", AV39ManageFiltersData);
         }
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV70GridCurrentPage), 10, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGECOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV71GridPageCount), 10, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV68DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV68DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPESSOAIDTITLEFILTERDATA", AV41PessoaIdTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPESSOAIDTITLEFILTERDATA", AV41PessoaIdTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPESSOANOMETITLEFILTERDATA", AV45PessoaNomeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPESSOANOMETITLEFILTERDATA", AV45PessoaNomeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPESSOATELEFONETITLEFILTERDATA", AV53PessoaTelefoneTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPESSOATELEFONETITLEFILTERDATA", AV53PessoaTelefoneTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPESSOAEMAILTITLEFILTERDATA", AV57PessoaEmailTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPESSOAEMAILTITLEFILTERDATA", AV57PessoaEmailTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPESSOASITUACAOTITLEFILTERDATA", AV65PessoaSituacaoTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPESSOASITUACAOTITLEFILTERDATA", AV65PessoaSituacaoTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vCOLUMNSSELECTOR", AV27ColumnsSelector);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vCOLUMNSSELECTOR", AV27ColumnsSelector);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV92Pgmname));
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
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Caption", StringUtil.RTrim( Ddo_pessoatelefone_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Tooltip", StringUtil.RTrim( Ddo_pessoatelefone_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Cls", StringUtil.RTrim( Ddo_pessoatelefone_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Filteredtext_set", StringUtil.RTrim( Ddo_pessoatelefone_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Selectedvalue_set", StringUtil.RTrim( Ddo_pessoatelefone_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Dropdownoptionstype", StringUtil.RTrim( Ddo_pessoatelefone_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_pessoatelefone_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Includesortasc", StringUtil.BoolToStr( Ddo_pessoatelefone_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Includesortdsc", StringUtil.BoolToStr( Ddo_pessoatelefone_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Sortedstatus", StringUtil.RTrim( Ddo_pessoatelefone_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Includefilter", StringUtil.BoolToStr( Ddo_pessoatelefone_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Filtertype", StringUtil.RTrim( Ddo_pessoatelefone_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Filterisrange", StringUtil.BoolToStr( Ddo_pessoatelefone_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Includedatalist", StringUtil.BoolToStr( Ddo_pessoatelefone_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Datalisttype", StringUtil.RTrim( Ddo_pessoatelefone_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Datalistproc", StringUtil.RTrim( Ddo_pessoatelefone_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_pessoatelefone_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Sortasc", StringUtil.RTrim( Ddo_pessoatelefone_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Sortdsc", StringUtil.RTrim( Ddo_pessoatelefone_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Loadingdata", StringUtil.RTrim( Ddo_pessoatelefone_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Cleanfilter", StringUtil.RTrim( Ddo_pessoatelefone_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Noresultsfound", StringUtil.RTrim( Ddo_pessoatelefone_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Searchbuttontext", StringUtil.RTrim( Ddo_pessoatelefone_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Caption", StringUtil.RTrim( Ddo_pessoaemail_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Tooltip", StringUtil.RTrim( Ddo_pessoaemail_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Cls", StringUtil.RTrim( Ddo_pessoaemail_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Filteredtext_set", StringUtil.RTrim( Ddo_pessoaemail_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Selectedvalue_set", StringUtil.RTrim( Ddo_pessoaemail_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Dropdownoptionstype", StringUtil.RTrim( Ddo_pessoaemail_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_pessoaemail_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Includesortasc", StringUtil.BoolToStr( Ddo_pessoaemail_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Includesortdsc", StringUtil.BoolToStr( Ddo_pessoaemail_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Sortedstatus", StringUtil.RTrim( Ddo_pessoaemail_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Includefilter", StringUtil.BoolToStr( Ddo_pessoaemail_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Filtertype", StringUtil.RTrim( Ddo_pessoaemail_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Filterisrange", StringUtil.BoolToStr( Ddo_pessoaemail_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Includedatalist", StringUtil.BoolToStr( Ddo_pessoaemail_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Datalisttype", StringUtil.RTrim( Ddo_pessoaemail_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Datalistproc", StringUtil.RTrim( Ddo_pessoaemail_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_pessoaemail_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Sortasc", StringUtil.RTrim( Ddo_pessoaemail_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Sortdsc", StringUtil.RTrim( Ddo_pessoaemail_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Loadingdata", StringUtil.RTrim( Ddo_pessoaemail_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Cleanfilter", StringUtil.RTrim( Ddo_pessoaemail_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Noresultsfound", StringUtil.RTrim( Ddo_pessoaemail_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Searchbuttontext", StringUtil.RTrim( Ddo_pessoaemail_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Caption", StringUtil.RTrim( Ddo_pessoasituacao_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Tooltip", StringUtil.RTrim( Ddo_pessoasituacao_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Cls", StringUtil.RTrim( Ddo_pessoasituacao_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Selectedvalue_set", StringUtil.RTrim( Ddo_pessoasituacao_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Dropdownoptionstype", StringUtil.RTrim( Ddo_pessoasituacao_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_pessoasituacao_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Includesortasc", StringUtil.BoolToStr( Ddo_pessoasituacao_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Includesortdsc", StringUtil.BoolToStr( Ddo_pessoasituacao_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Sortedstatus", StringUtil.RTrim( Ddo_pessoasituacao_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Includefilter", StringUtil.BoolToStr( Ddo_pessoasituacao_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Includedatalist", StringUtil.BoolToStr( Ddo_pessoasituacao_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Datalisttype", StringUtil.RTrim( Ddo_pessoasituacao_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Datalistfixedvalues", StringUtil.RTrim( Ddo_pessoasituacao_Datalistfixedvalues));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Sortasc", StringUtil.RTrim( Ddo_pessoasituacao_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Sortdsc", StringUtil.RTrim( Ddo_pessoasituacao_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Cleanfilter", StringUtil.RTrim( Ddo_pessoasituacao_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Searchbuttontext", StringUtil.RTrim( Ddo_pessoasituacao_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Caption", StringUtil.RTrim( Ddo_gridcolumnsselector_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Tooltip", StringUtil.RTrim( Ddo_gridcolumnsselector_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Cls", StringUtil.RTrim( Ddo_gridcolumnsselector_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Dropdownoptionstype", StringUtil.RTrim( Ddo_gridcolumnsselector_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_gridcolumnsselector_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Updatebuttontext", StringUtil.RTrim( Ddo_gridcolumnsselector_Updatebuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Activeeventkey", StringUtil.RTrim( Ddo_pessoaid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Filteredtext_get", StringUtil.RTrim( Ddo_pessoaid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Filteredtextto_get", StringUtil.RTrim( Ddo_pessoaid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Activeeventkey", StringUtil.RTrim( Ddo_pessoanome_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Filteredtext_get", StringUtil.RTrim( Ddo_pessoanome_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Selectedvalue_get", StringUtil.RTrim( Ddo_pessoanome_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Activeeventkey", StringUtil.RTrim( Ddo_pessoatelefone_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Filteredtext_get", StringUtil.RTrim( Ddo_pessoatelefone_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Selectedvalue_get", StringUtil.RTrim( Ddo_pessoatelefone_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Activeeventkey", StringUtil.RTrim( Ddo_pessoaemail_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Filteredtext_get", StringUtil.RTrim( Ddo_pessoaemail_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Selectedvalue_get", StringUtil.RTrim( Ddo_pessoaemail_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Activeeventkey", StringUtil.RTrim( Ddo_pessoasituacao_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Selectedvalue_get", StringUtil.RTrim( Ddo_pessoasituacao_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_GRIDCOLUMNSSELECTOR_Columnsselectorvalues", StringUtil.RTrim( Ddo_gridcolumnsselector_Columnsselectorvalues));
         GxWebStd.gx_hidden_field( context, "DDO_MANAGEFILTERS_Activeeventkey", StringUtil.RTrim( Ddo_managefilters_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Activeeventkey", StringUtil.RTrim( Ddo_pessoaid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Filteredtext_get", StringUtil.RTrim( Ddo_pessoaid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Filteredtextto_get", StringUtil.RTrim( Ddo_pessoaid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Activeeventkey", StringUtil.RTrim( Ddo_pessoanome_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Filteredtext_get", StringUtil.RTrim( Ddo_pessoanome_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Selectedvalue_get", StringUtil.RTrim( Ddo_pessoanome_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Activeeventkey", StringUtil.RTrim( Ddo_pessoatelefone_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Filteredtext_get", StringUtil.RTrim( Ddo_pessoatelefone_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Selectedvalue_get", StringUtil.RTrim( Ddo_pessoatelefone_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Activeeventkey", StringUtil.RTrim( Ddo_pessoaemail_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Filteredtext_get", StringUtil.RTrim( Ddo_pessoaemail_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Selectedvalue_get", StringUtil.RTrim( Ddo_pessoaemail_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Activeeventkey", StringUtil.RTrim( Ddo_pessoasituacao_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Selectedvalue_get", StringUtil.RTrim( Ddo_pessoasituacao_Selectedvalue_get));
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
            WE0M2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0M2( ) ;
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
         return formatLink("pessoaww.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "PessoaWW" ;
      }

      public override String GetPgmdesc( )
      {
         return " Pessoa" ;
      }

      protected void WB0M0( )
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
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(67), 2, 0)+","+"null"+");", "Inserir", bttBtninsert_Jsonclick, 5, "Inserir", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_PessoaWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"";
            ClassString = "hidden-xs";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtneditcolumns_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(67), 2, 0)+","+"null"+");", "Seleciona colunas", bttBtneditcolumns_Jsonclick, 0, "Seleciona colunas", "", StyleString, ClassString, 1, 0, "standard", "'"+""+"'"+",false,"+"'"+""+"'", TempTags, "", context.GetButtonType( ), "HLP_PessoaWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-xs col-sm-6 CellFloatRight CellWidthAuto", "left", "top", "", "", "div");
            wb_table1_23_0M2( true) ;
         }
         else
         {
            wb_table1_23_0M2( false) ;
         }
         return  ;
      }

      protected void wb_table1_23_0M2e( bool wbgen )
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
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"67\">") ;
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Endereço") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+((edtPessoaTelefone_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               if ( edtPessoaTelefone_Titleformat == 0 )
               {
                  context.SendWebValue( edtPessoaTelefone_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtPessoaTelefone_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+((edtPessoaEmail_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               if ( edtPessoaEmail_Titleformat == 0 )
               {
                  context.SendWebValue( edtPessoaEmail_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtPessoaEmail_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Sexo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"AttributeCheckBox"+"\" "+" style=\""+((chkPessoaSituacao.Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               if ( chkPessoaSituacao_Titleformat == 0 )
               {
                  context.SendWebValue( chkPessoaSituacao.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( chkPessoaSituacao.Title.Text) ;
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
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( AV72Update));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUpdate_Enabled), 5, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( AV73Delete));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDelete_Enabled), 5, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
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
               GridColumn.AddObjectProperty("Value", A3PessoaEndereco);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A4PessoaTelefone);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtPessoaTelefone_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPessoaTelefone_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPessoaTelefone_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A5PessoaEmail);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtPessoaEmail_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPessoaEmail_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPessoaEmail_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A6PessoaSexo));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.BoolToStr( A7PessoaSituacao));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( chkPessoaSituacao.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkPessoaSituacao_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkPessoaSituacao.Visible), 5, 0, ".", "")));
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
         if ( wbEnd == 67 )
         {
            wbEnd = 0;
            nRC_GXsfl_67 = (short)(nGXsfl_67_idx-1);
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV70GridCurrentPage);
            ucGridpaginationbar.SetProperty("PageCount", AV71GridPageCount);
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
            ucDdo_pessoaid.SetProperty("DropDownOptionsTitleSettingsIcons", AV68DDO_TitleSettingsIcons);
            ucDdo_pessoaid.SetProperty("DropDownOptionsData", AV41PessoaIdTitleFilterData);
            ucDdo_pessoaid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_pessoaid_Internalname, "DDO_PESSOAIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 84,'',false,'" + sGXsfl_67_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_pessoaidtitlecontrolidtoreplace_Internalname, AV44ddo_PessoaIdTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,84);\"", 0, edtavDdo_pessoaidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_PessoaWW.htm");
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
            ucDdo_pessoanome.SetProperty("DropDownOptionsTitleSettingsIcons", AV68DDO_TitleSettingsIcons);
            ucDdo_pessoanome.SetProperty("DropDownOptionsData", AV45PessoaNomeTitleFilterData);
            ucDdo_pessoanome.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_pessoanome_Internalname, "DDO_PESSOANOMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 86,'',false,'" + sGXsfl_67_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_pessoanometitlecontrolidtoreplace_Internalname, AV48ddo_PessoaNomeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,86);\"", 0, edtavDdo_pessoanometitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_PessoaWW.htm");
            /* User Defined Control */
            ucDdo_pessoatelefone.SetProperty("Caption", Ddo_pessoatelefone_Caption);
            ucDdo_pessoatelefone.SetProperty("Tooltip", Ddo_pessoatelefone_Tooltip);
            ucDdo_pessoatelefone.SetProperty("Cls", Ddo_pessoatelefone_Cls);
            ucDdo_pessoatelefone.SetProperty("DropDownOptionsType", Ddo_pessoatelefone_Dropdownoptionstype);
            ucDdo_pessoatelefone.SetProperty("IncludeSortASC", Ddo_pessoatelefone_Includesortasc);
            ucDdo_pessoatelefone.SetProperty("IncludeSortDSC", Ddo_pessoatelefone_Includesortdsc);
            ucDdo_pessoatelefone.SetProperty("IncludeFilter", Ddo_pessoatelefone_Includefilter);
            ucDdo_pessoatelefone.SetProperty("FilterType", Ddo_pessoatelefone_Filtertype);
            ucDdo_pessoatelefone.SetProperty("FilterIsRange", Ddo_pessoatelefone_Filterisrange);
            ucDdo_pessoatelefone.SetProperty("IncludeDataList", Ddo_pessoatelefone_Includedatalist);
            ucDdo_pessoatelefone.SetProperty("DataListType", Ddo_pessoatelefone_Datalisttype);
            ucDdo_pessoatelefone.SetProperty("DataListProc", Ddo_pessoatelefone_Datalistproc);
            ucDdo_pessoatelefone.SetProperty("DataListUpdateMinimumCharacters", Ddo_pessoatelefone_Datalistupdateminimumcharacters);
            ucDdo_pessoatelefone.SetProperty("SortASC", Ddo_pessoatelefone_Sortasc);
            ucDdo_pessoatelefone.SetProperty("SortDSC", Ddo_pessoatelefone_Sortdsc);
            ucDdo_pessoatelefone.SetProperty("LoadingData", Ddo_pessoatelefone_Loadingdata);
            ucDdo_pessoatelefone.SetProperty("CleanFilter", Ddo_pessoatelefone_Cleanfilter);
            ucDdo_pessoatelefone.SetProperty("NoResultsFound", Ddo_pessoatelefone_Noresultsfound);
            ucDdo_pessoatelefone.SetProperty("SearchButtonText", Ddo_pessoatelefone_Searchbuttontext);
            ucDdo_pessoatelefone.SetProperty("DropDownOptionsTitleSettingsIcons", AV68DDO_TitleSettingsIcons);
            ucDdo_pessoatelefone.SetProperty("DropDownOptionsData", AV53PessoaTelefoneTitleFilterData);
            ucDdo_pessoatelefone.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_pessoatelefone_Internalname, "DDO_PESSOATELEFONEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 88,'',false,'" + sGXsfl_67_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_pessoatelefonetitlecontrolidtoreplace_Internalname, AV56ddo_PessoaTelefoneTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,88);\"", 0, edtavDdo_pessoatelefonetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_PessoaWW.htm");
            /* User Defined Control */
            ucDdo_pessoaemail.SetProperty("Caption", Ddo_pessoaemail_Caption);
            ucDdo_pessoaemail.SetProperty("Tooltip", Ddo_pessoaemail_Tooltip);
            ucDdo_pessoaemail.SetProperty("Cls", Ddo_pessoaemail_Cls);
            ucDdo_pessoaemail.SetProperty("DropDownOptionsType", Ddo_pessoaemail_Dropdownoptionstype);
            ucDdo_pessoaemail.SetProperty("IncludeSortASC", Ddo_pessoaemail_Includesortasc);
            ucDdo_pessoaemail.SetProperty("IncludeSortDSC", Ddo_pessoaemail_Includesortdsc);
            ucDdo_pessoaemail.SetProperty("IncludeFilter", Ddo_pessoaemail_Includefilter);
            ucDdo_pessoaemail.SetProperty("FilterType", Ddo_pessoaemail_Filtertype);
            ucDdo_pessoaemail.SetProperty("FilterIsRange", Ddo_pessoaemail_Filterisrange);
            ucDdo_pessoaemail.SetProperty("IncludeDataList", Ddo_pessoaemail_Includedatalist);
            ucDdo_pessoaemail.SetProperty("DataListType", Ddo_pessoaemail_Datalisttype);
            ucDdo_pessoaemail.SetProperty("DataListProc", Ddo_pessoaemail_Datalistproc);
            ucDdo_pessoaemail.SetProperty("DataListUpdateMinimumCharacters", Ddo_pessoaemail_Datalistupdateminimumcharacters);
            ucDdo_pessoaemail.SetProperty("SortASC", Ddo_pessoaemail_Sortasc);
            ucDdo_pessoaemail.SetProperty("SortDSC", Ddo_pessoaemail_Sortdsc);
            ucDdo_pessoaemail.SetProperty("LoadingData", Ddo_pessoaemail_Loadingdata);
            ucDdo_pessoaemail.SetProperty("CleanFilter", Ddo_pessoaemail_Cleanfilter);
            ucDdo_pessoaemail.SetProperty("NoResultsFound", Ddo_pessoaemail_Noresultsfound);
            ucDdo_pessoaemail.SetProperty("SearchButtonText", Ddo_pessoaemail_Searchbuttontext);
            ucDdo_pessoaemail.SetProperty("DropDownOptionsTitleSettingsIcons", AV68DDO_TitleSettingsIcons);
            ucDdo_pessoaemail.SetProperty("DropDownOptionsData", AV57PessoaEmailTitleFilterData);
            ucDdo_pessoaemail.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_pessoaemail_Internalname, "DDO_PESSOAEMAILContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 90,'',false,'" + sGXsfl_67_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_pessoaemailtitlecontrolidtoreplace_Internalname, AV60ddo_PessoaEmailTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,90);\"", 0, edtavDdo_pessoaemailtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_PessoaWW.htm");
            /* User Defined Control */
            ucDdo_pessoasituacao.SetProperty("Caption", Ddo_pessoasituacao_Caption);
            ucDdo_pessoasituacao.SetProperty("Tooltip", Ddo_pessoasituacao_Tooltip);
            ucDdo_pessoasituacao.SetProperty("Cls", Ddo_pessoasituacao_Cls);
            ucDdo_pessoasituacao.SetProperty("DropDownOptionsType", Ddo_pessoasituacao_Dropdownoptionstype);
            ucDdo_pessoasituacao.SetProperty("IncludeSortASC", Ddo_pessoasituacao_Includesortasc);
            ucDdo_pessoasituacao.SetProperty("IncludeSortDSC", Ddo_pessoasituacao_Includesortdsc);
            ucDdo_pessoasituacao.SetProperty("IncludeFilter", Ddo_pessoasituacao_Includefilter);
            ucDdo_pessoasituacao.SetProperty("IncludeDataList", Ddo_pessoasituacao_Includedatalist);
            ucDdo_pessoasituacao.SetProperty("DataListType", Ddo_pessoasituacao_Datalisttype);
            ucDdo_pessoasituacao.SetProperty("DataListFixedValues", Ddo_pessoasituacao_Datalistfixedvalues);
            ucDdo_pessoasituacao.SetProperty("SortASC", Ddo_pessoasituacao_Sortasc);
            ucDdo_pessoasituacao.SetProperty("SortDSC", Ddo_pessoasituacao_Sortdsc);
            ucDdo_pessoasituacao.SetProperty("CleanFilter", Ddo_pessoasituacao_Cleanfilter);
            ucDdo_pessoasituacao.SetProperty("SearchButtonText", Ddo_pessoasituacao_Searchbuttontext);
            ucDdo_pessoasituacao.SetProperty("DropDownOptionsTitleSettingsIcons", AV68DDO_TitleSettingsIcons);
            ucDdo_pessoasituacao.SetProperty("DropDownOptionsData", AV65PessoaSituacaoTitleFilterData);
            ucDdo_pessoasituacao.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_pessoasituacao_Internalname, "DDO_PESSOASITUACAOContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 92,'',false,'" + sGXsfl_67_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_pessoasituacaotitlecontrolidtoreplace_Internalname, AV67ddo_PessoaSituacaoTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,92);\"", 0, edtavDdo_pessoasituacaotitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_PessoaWW.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities_f5", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* User Defined Control */
            ucDdo_gridcolumnsselector.SetProperty("Caption", Ddo_gridcolumnsselector_Caption);
            ucDdo_gridcolumnsselector.SetProperty("Tooltip", Ddo_gridcolumnsselector_Tooltip);
            ucDdo_gridcolumnsselector.SetProperty("Cls", Ddo_gridcolumnsselector_Cls);
            ucDdo_gridcolumnsselector.SetProperty("DropDownOptionsType", Ddo_gridcolumnsselector_Dropdownoptionstype);
            ucDdo_gridcolumnsselector.SetProperty("UpdateButtonText", Ddo_gridcolumnsselector_Updatebuttontext);
            ucDdo_gridcolumnsselector.SetProperty("DropDownOptionsTitleSettingsIcons", AV68DDO_TitleSettingsIcons);
            ucDdo_gridcolumnsselector.SetProperty("DropDownOptionsData", AV27ColumnsSelector);
            ucDdo_gridcolumnsselector.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_gridcolumnsselector_Internalname, "DDO_GRIDCOLUMNSSELECTORContainer");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 95,'',false,'" + sGXsfl_67_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12OrderedBy), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV12OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,95);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PessoaWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 96,'',false,'" + sGXsfl_67_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV13OrderedDsc), StringUtil.BoolToStr( AV13OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,96);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_PessoaWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 97,'',false,'" + sGXsfl_67_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavManagefiltersexecutionstep_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV35ManageFiltersExecutionStep), 1, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV35ManageFiltersExecutionStep), "9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,97);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavManagefiltersexecutionstep_Jsonclick, 0, "Attribute", "", "", "", "", edtavManagefiltersexecutionstep_Visible, 1, 0, "number", "1", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PessoaWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 98,'',false,'" + sGXsfl_67_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfpessoaid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV42TFPessoaId), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV42TFPessoaId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,98);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfpessoaid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfpessoaid_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PessoaWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 99,'',false,'" + sGXsfl_67_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfpessoaid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV43TFPessoaId_To), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV43TFPessoaId_To), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,99);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfpessoaid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfpessoaid_to_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PessoaWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 100,'',false,'" + sGXsfl_67_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfpessoanome_Internalname, AV46TFPessoaNome, StringUtil.RTrim( context.localUtil.Format( AV46TFPessoaNome, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,100);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfpessoanome_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfpessoanome_Visible, 1, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_PessoaWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 101,'',false,'" + sGXsfl_67_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfpessoanome_sel_Internalname, AV47TFPessoaNome_Sel, StringUtil.RTrim( context.localUtil.Format( AV47TFPessoaNome_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,101);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfpessoanome_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfpessoanome_sel_Visible, 1, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_PessoaWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 102,'',false,'" + sGXsfl_67_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfpessoatelefone_Internalname, AV54TFPessoaTelefone, StringUtil.RTrim( context.localUtil.Format( AV54TFPessoaTelefone, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,102);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfpessoatelefone_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfpessoatelefone_Visible, 1, 0, "text", "", 11, "chr", 1, "row", 11, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_PessoaWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 103,'',false,'" + sGXsfl_67_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfpessoatelefone_sel_Internalname, AV55TFPessoaTelefone_Sel, StringUtil.RTrim( context.localUtil.Format( AV55TFPessoaTelefone_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,103);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfpessoatelefone_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfpessoatelefone_sel_Visible, 1, 0, "text", "", 11, "chr", 1, "row", 11, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_PessoaWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 104,'',false,'" + sGXsfl_67_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfpessoaemail_Internalname, AV58TFPessoaEmail, StringUtil.RTrim( context.localUtil.Format( AV58TFPessoaEmail, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,104);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfpessoaemail_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfpessoaemail_Visible, 1, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_PessoaWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 105,'',false,'" + sGXsfl_67_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfpessoaemail_sel_Internalname, AV59TFPessoaEmail_Sel, StringUtil.RTrim( context.localUtil.Format( AV59TFPessoaEmail_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,105);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfpessoaemail_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfpessoaemail_sel_Visible, 1, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_PessoaWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 106,'',false,'" + sGXsfl_67_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfpessoasituacao_sel_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV66TFPessoaSituacao_Sel), 1, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV66TFPessoaSituacao_Sel), "9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,106);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfpessoasituacao_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfpessoasituacao_sel_Visible, 1, 0, "number", "1", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PessoaWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 67 )
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

      protected void START0M2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_2-131213", 0) ;
            Form.Meta.addItem("description", " Pessoa", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP0M0( ) ;
      }

      protected void WS0M2( )
      {
         START0M2( ) ;
         EVT0M2( ) ;
      }

      protected void EVT0M2( )
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
                              E110M2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E120M2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E130M2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PESSOAID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E140M2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PESSOANOME.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E150M2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PESSOATELEFONE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E160M2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PESSOAEMAIL.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E170M2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PESSOASITUACAO.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E180M2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_GRIDCOLUMNSSELECTOR.ONCOLUMNSCHANGED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E190M2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoInsert' */
                              E200M2 ();
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
                              nGXsfl_67_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_67_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_67_idx), 4, 0)), 4, "0");
                              SubsflControlProps_672( ) ;
                              AV72Update = cgiGet( edtavUpdate_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUpdate_Internalname, AV72Update);
                              AV73Delete = cgiGet( edtavDelete_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDelete_Internalname, AV73Delete);
                              A1PessoaId = (short)(context.localUtil.CToN( cgiGet( edtPessoaId_Internalname), ",", "."));
                              A2PessoaNome = cgiGet( edtPessoaNome_Internalname);
                              A3PessoaEndereco = cgiGet( edtPessoaEndereco_Internalname);
                              A4PessoaTelefone = cgiGet( edtPessoaTelefone_Internalname);
                              A5PessoaEmail = cgiGet( edtPessoaEmail_Internalname);
                              cmbPessoaSexo.Name = cmbPessoaSexo_Internalname;
                              cmbPessoaSexo.CurrentValue = cgiGet( cmbPessoaSexo_Internalname);
                              A6PessoaSexo = cgiGet( cmbPessoaSexo_Internalname);
                              A7PessoaSituacao = StringUtil.StrToBool( cgiGet( chkPessoaSituacao_Internalname));
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E210M2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E220M2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E230M2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Pessoanomeoperator Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vPESSOANOMEOPERATOR"), ",", ".") != Convert.ToDecimal( AV74PessoaNomeOperator )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Pessoanome Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vPESSOANOME"), AV75PessoaNome) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Pessoaemailoperator Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vPESSOAEMAILOPERATOR"), ",", ".") != Convert.ToDecimal( AV76PessoaEmailOperator )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Pessoaemail Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vPESSOAEMAIL"), AV77PessoaEmail) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Orderedby Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ",", ".") != Convert.ToDecimal( AV12OrderedBy )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ordereddsc Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV13OrderedDsc )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfpessoaid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFPESSOAID"), ",", ".") != Convert.ToDecimal( AV42TFPessoaId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfpessoaid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFPESSOAID_TO"), ",", ".") != Convert.ToDecimal( AV43TFPessoaId_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfpessoanome Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFPESSOANOME"), AV46TFPessoaNome) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfpessoanome_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFPESSOANOME_SEL"), AV47TFPessoaNome_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfpessoatelefone Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFPESSOATELEFONE"), AV54TFPessoaTelefone) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfpessoatelefone_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFPESSOATELEFONE_SEL"), AV55TFPessoaTelefone_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfpessoaemail Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFPESSOAEMAIL"), AV58TFPessoaEmail) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfpessoaemail_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFPESSOAEMAIL_SEL"), AV59TFPessoaEmail_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfpessoasituacao_sel Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFPESSOASITUACAO_SEL"), ",", ".") != Convert.ToDecimal( AV66TFPessoaSituacao_Sel )) )
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

      protected void WE0M2( )
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

      protected void PA0M2( )
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
         SubsflControlProps_672( ) ;
         while ( nGXsfl_67_idx <= nRC_GXsfl_67 )
         {
            sendrow_672( ) ;
            nGXsfl_67_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_67_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_67_idx+1));
            sGXsfl_67_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_67_idx), 4, 0)), 4, "0");
            SubsflControlProps_672( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       short AV74PessoaNomeOperator ,
                                       String AV75PessoaNome ,
                                       short AV76PessoaEmailOperator ,
                                       String AV77PessoaEmail ,
                                       short AV12OrderedBy ,
                                       bool AV13OrderedDsc ,
                                       short AV42TFPessoaId ,
                                       short AV43TFPessoaId_To ,
                                       String AV46TFPessoaNome ,
                                       String AV47TFPessoaNome_Sel ,
                                       String AV54TFPessoaTelefone ,
                                       String AV55TFPessoaTelefone_Sel ,
                                       String AV58TFPessoaEmail ,
                                       String AV59TFPessoaEmail_Sel ,
                                       short AV66TFPessoaSituacao_Sel ,
                                       short AV35ManageFiltersExecutionStep ,
                                       GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector AV27ColumnsSelector ,
                                       String AV44ddo_PessoaIdTitleControlIdToReplace ,
                                       String AV48ddo_PessoaNomeTitleControlIdToReplace ,
                                       String AV56ddo_PessoaTelefoneTitleControlIdToReplace ,
                                       String AV60ddo_PessoaEmailTitleControlIdToReplace ,
                                       String AV67ddo_PessoaSituacaoTitleControlIdToReplace ,
                                       String AV92Pgmname )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF0M2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_PESSOAID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A1PessoaId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "PESSOAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1PessoaId), 4, 0, ".", "")));
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
            AV74PessoaNomeOperator = (short)(NumberUtil.Val( cmbavPessoanomeoperator.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV74PessoaNomeOperator), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV74PessoaNomeOperator", StringUtil.LTrim( StringUtil.Str( (decimal)(AV74PessoaNomeOperator), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavPessoanomeoperator.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV74PessoaNomeOperator), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavPessoanomeoperator_Internalname, "Values", cmbavPessoanomeoperator.ToJavascriptSource(), true);
         }
         if ( cmbavPessoaemailoperator.ItemCount > 0 )
         {
            AV76PessoaEmailOperator = (short)(NumberUtil.Val( cmbavPessoaemailoperator.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV76PessoaEmailOperator), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV76PessoaEmailOperator", StringUtil.LTrim( StringUtil.Str( (decimal)(AV76PessoaEmailOperator), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavPessoaemailoperator.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV76PessoaEmailOperator), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavPessoaemailoperator_Internalname, "Values", cmbavPessoaemailoperator.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF0M2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV92Pgmname = "PessoaWW";
         context.Gx_err = 0;
         edtavUpdate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Enabled), 5, 0)), !bGXsfl_67_Refreshing);
         edtavDelete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Enabled), 5, 0)), !bGXsfl_67_Refreshing);
      }

      protected void RF0M2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 67;
         /* Execute user event: Refresh */
         E220M2 ();
         nGXsfl_67_idx = 1;
         sGXsfl_67_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_67_idx), 4, 0)), 4, "0");
         SubsflControlProps_672( ) ;
         bGXsfl_67_Refreshing = true;
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
            SubsflControlProps_672( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV74PessoaNomeOperator ,
                                                 AV81PessoaWWDS_1_Pessoanome ,
                                                 AV76PessoaEmailOperator ,
                                                 AV82PessoaWWDS_2_Pessoaemail ,
                                                 AV83PessoaWWDS_3_Tfpessoaid ,
                                                 AV84PessoaWWDS_4_Tfpessoaid_to ,
                                                 AV86PessoaWWDS_6_Tfpessoanome_sel ,
                                                 AV85PessoaWWDS_5_Tfpessoanome ,
                                                 AV88PessoaWWDS_8_Tfpessoatelefone_sel ,
                                                 AV87PessoaWWDS_7_Tfpessoatelefone ,
                                                 AV90PessoaWWDS_10_Tfpessoaemail_sel ,
                                                 AV89PessoaWWDS_9_Tfpessoaemail ,
                                                 AV91PessoaWWDS_11_Tfpessoasituacao_sel ,
                                                 A2PessoaNome ,
                                                 A5PessoaEmail ,
                                                 A1PessoaId ,
                                                 A4PessoaTelefone ,
                                                 A7PessoaSituacao ,
                                                 AV12OrderedBy ,
                                                 AV13OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV81PessoaWWDS_1_Pessoanome = StringUtil.Concat( StringUtil.RTrim( AV81PessoaWWDS_1_Pessoanome), "%", "");
            lV82PessoaWWDS_2_Pessoaemail = StringUtil.Concat( StringUtil.RTrim( AV82PessoaWWDS_2_Pessoaemail), "%", "");
            lV82PessoaWWDS_2_Pessoaemail = StringUtil.Concat( StringUtil.RTrim( AV82PessoaWWDS_2_Pessoaemail), "%", "");
            lV85PessoaWWDS_5_Tfpessoanome = StringUtil.Concat( StringUtil.RTrim( AV85PessoaWWDS_5_Tfpessoanome), "%", "");
            lV87PessoaWWDS_7_Tfpessoatelefone = StringUtil.Concat( StringUtil.RTrim( AV87PessoaWWDS_7_Tfpessoatelefone), "%", "");
            lV89PessoaWWDS_9_Tfpessoaemail = StringUtil.Concat( StringUtil.RTrim( AV89PessoaWWDS_9_Tfpessoaemail), "%", "");
            /* Using cursor H000M2 */
            pr_default.execute(0, new Object[] {lV81PessoaWWDS_1_Pessoanome, lV82PessoaWWDS_2_Pessoaemail, lV82PessoaWWDS_2_Pessoaemail, AV83PessoaWWDS_3_Tfpessoaid, AV84PessoaWWDS_4_Tfpessoaid_to, lV85PessoaWWDS_5_Tfpessoanome, AV86PessoaWWDS_6_Tfpessoanome_sel, lV87PessoaWWDS_7_Tfpessoatelefone, AV88PessoaWWDS_8_Tfpessoatelefone_sel, lV89PessoaWWDS_9_Tfpessoaemail, AV90PessoaWWDS_10_Tfpessoaemail_sel, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_67_idx = 1;
            sGXsfl_67_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_67_idx), 4, 0)), 4, "0");
            SubsflControlProps_672( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A7PessoaSituacao = H000M2_A7PessoaSituacao[0];
               A6PessoaSexo = H000M2_A6PessoaSexo[0];
               A5PessoaEmail = H000M2_A5PessoaEmail[0];
               A4PessoaTelefone = H000M2_A4PessoaTelefone[0];
               A3PessoaEndereco = H000M2_A3PessoaEndereco[0];
               A2PessoaNome = H000M2_A2PessoaNome[0];
               A1PessoaId = H000M2_A1PessoaId[0];
               E230M2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 67;
            WB0M0( ) ;
         }
         bGXsfl_67_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes0M2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_PESSOAID"+"_"+sGXsfl_67_idx, GetSecureSignedToken( sGXsfl_67_idx, context.localUtil.Format( (decimal)(A1PessoaId), "ZZZ9"), context));
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
         AV81PessoaWWDS_1_Pessoanome = AV75PessoaNome;
         AV82PessoaWWDS_2_Pessoaemail = AV77PessoaEmail;
         AV83PessoaWWDS_3_Tfpessoaid = AV42TFPessoaId;
         AV84PessoaWWDS_4_Tfpessoaid_to = AV43TFPessoaId_To;
         AV85PessoaWWDS_5_Tfpessoanome = AV46TFPessoaNome;
         AV86PessoaWWDS_6_Tfpessoanome_sel = AV47TFPessoaNome_Sel;
         AV87PessoaWWDS_7_Tfpessoatelefone = AV54TFPessoaTelefone;
         AV88PessoaWWDS_8_Tfpessoatelefone_sel = AV55TFPessoaTelefone_Sel;
         AV89PessoaWWDS_9_Tfpessoaemail = AV58TFPessoaEmail;
         AV90PessoaWWDS_10_Tfpessoaemail_sel = AV59TFPessoaEmail_Sel;
         AV91PessoaWWDS_11_Tfpessoasituacao_sel = AV66TFPessoaSituacao_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV74PessoaNomeOperator ,
                                              AV81PessoaWWDS_1_Pessoanome ,
                                              AV76PessoaEmailOperator ,
                                              AV82PessoaWWDS_2_Pessoaemail ,
                                              AV83PessoaWWDS_3_Tfpessoaid ,
                                              AV84PessoaWWDS_4_Tfpessoaid_to ,
                                              AV86PessoaWWDS_6_Tfpessoanome_sel ,
                                              AV85PessoaWWDS_5_Tfpessoanome ,
                                              AV88PessoaWWDS_8_Tfpessoatelefone_sel ,
                                              AV87PessoaWWDS_7_Tfpessoatelefone ,
                                              AV90PessoaWWDS_10_Tfpessoaemail_sel ,
                                              AV89PessoaWWDS_9_Tfpessoaemail ,
                                              AV91PessoaWWDS_11_Tfpessoasituacao_sel ,
                                              A2PessoaNome ,
                                              A5PessoaEmail ,
                                              A1PessoaId ,
                                              A4PessoaTelefone ,
                                              A7PessoaSituacao ,
                                              AV12OrderedBy ,
                                              AV13OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV81PessoaWWDS_1_Pessoanome = StringUtil.Concat( StringUtil.RTrim( AV81PessoaWWDS_1_Pessoanome), "%", "");
         lV82PessoaWWDS_2_Pessoaemail = StringUtil.Concat( StringUtil.RTrim( AV82PessoaWWDS_2_Pessoaemail), "%", "");
         lV82PessoaWWDS_2_Pessoaemail = StringUtil.Concat( StringUtil.RTrim( AV82PessoaWWDS_2_Pessoaemail), "%", "");
         lV85PessoaWWDS_5_Tfpessoanome = StringUtil.Concat( StringUtil.RTrim( AV85PessoaWWDS_5_Tfpessoanome), "%", "");
         lV87PessoaWWDS_7_Tfpessoatelefone = StringUtil.Concat( StringUtil.RTrim( AV87PessoaWWDS_7_Tfpessoatelefone), "%", "");
         lV89PessoaWWDS_9_Tfpessoaemail = StringUtil.Concat( StringUtil.RTrim( AV89PessoaWWDS_9_Tfpessoaemail), "%", "");
         /* Using cursor H000M3 */
         pr_default.execute(1, new Object[] {lV81PessoaWWDS_1_Pessoanome, lV82PessoaWWDS_2_Pessoaemail, lV82PessoaWWDS_2_Pessoaemail, AV83PessoaWWDS_3_Tfpessoaid, AV84PessoaWWDS_4_Tfpessoaid_to, lV85PessoaWWDS_5_Tfpessoanome, AV86PessoaWWDS_6_Tfpessoanome_sel, lV87PessoaWWDS_7_Tfpessoatelefone, AV88PessoaWWDS_8_Tfpessoatelefone_sel, lV89PessoaWWDS_9_Tfpessoaemail, AV90PessoaWWDS_10_Tfpessoaemail_sel});
         GRID_nRecordCount = H000M3_AGRID_nRecordCount[0];
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
         AV81PessoaWWDS_1_Pessoanome = AV75PessoaNome;
         AV82PessoaWWDS_2_Pessoaemail = AV77PessoaEmail;
         AV83PessoaWWDS_3_Tfpessoaid = AV42TFPessoaId;
         AV84PessoaWWDS_4_Tfpessoaid_to = AV43TFPessoaId_To;
         AV85PessoaWWDS_5_Tfpessoanome = AV46TFPessoaNome;
         AV86PessoaWWDS_6_Tfpessoanome_sel = AV47TFPessoaNome_Sel;
         AV87PessoaWWDS_7_Tfpessoatelefone = AV54TFPessoaTelefone;
         AV88PessoaWWDS_8_Tfpessoatelefone_sel = AV55TFPessoaTelefone_Sel;
         AV89PessoaWWDS_9_Tfpessoaemail = AV58TFPessoaEmail;
         AV90PessoaWWDS_10_Tfpessoaemail_sel = AV59TFPessoaEmail_Sel;
         AV91PessoaWWDS_11_Tfpessoasituacao_sel = AV66TFPessoaSituacao_Sel;
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV74PessoaNomeOperator, AV75PessoaNome, AV76PessoaEmailOperator, AV77PessoaEmail, AV12OrderedBy, AV13OrderedDsc, AV42TFPessoaId, AV43TFPessoaId_To, AV46TFPessoaNome, AV47TFPessoaNome_Sel, AV54TFPessoaTelefone, AV55TFPessoaTelefone_Sel, AV58TFPessoaEmail, AV59TFPessoaEmail_Sel, AV66TFPessoaSituacao_Sel, AV35ManageFiltersExecutionStep, AV27ColumnsSelector, AV44ddo_PessoaIdTitleControlIdToReplace, AV48ddo_PessoaNomeTitleControlIdToReplace, AV56ddo_PessoaTelefoneTitleControlIdToReplace, AV60ddo_PessoaEmailTitleControlIdToReplace, AV67ddo_PessoaSituacaoTitleControlIdToReplace, AV92Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV81PessoaWWDS_1_Pessoanome = AV75PessoaNome;
         AV82PessoaWWDS_2_Pessoaemail = AV77PessoaEmail;
         AV83PessoaWWDS_3_Tfpessoaid = AV42TFPessoaId;
         AV84PessoaWWDS_4_Tfpessoaid_to = AV43TFPessoaId_To;
         AV85PessoaWWDS_5_Tfpessoanome = AV46TFPessoaNome;
         AV86PessoaWWDS_6_Tfpessoanome_sel = AV47TFPessoaNome_Sel;
         AV87PessoaWWDS_7_Tfpessoatelefone = AV54TFPessoaTelefone;
         AV88PessoaWWDS_8_Tfpessoatelefone_sel = AV55TFPessoaTelefone_Sel;
         AV89PessoaWWDS_9_Tfpessoaemail = AV58TFPessoaEmail;
         AV90PessoaWWDS_10_Tfpessoaemail_sel = AV59TFPessoaEmail_Sel;
         AV91PessoaWWDS_11_Tfpessoasituacao_sel = AV66TFPessoaSituacao_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV74PessoaNomeOperator, AV75PessoaNome, AV76PessoaEmailOperator, AV77PessoaEmail, AV12OrderedBy, AV13OrderedDsc, AV42TFPessoaId, AV43TFPessoaId_To, AV46TFPessoaNome, AV47TFPessoaNome_Sel, AV54TFPessoaTelefone, AV55TFPessoaTelefone_Sel, AV58TFPessoaEmail, AV59TFPessoaEmail_Sel, AV66TFPessoaSituacao_Sel, AV35ManageFiltersExecutionStep, AV27ColumnsSelector, AV44ddo_PessoaIdTitleControlIdToReplace, AV48ddo_PessoaNomeTitleControlIdToReplace, AV56ddo_PessoaTelefoneTitleControlIdToReplace, AV60ddo_PessoaEmailTitleControlIdToReplace, AV67ddo_PessoaSituacaoTitleControlIdToReplace, AV92Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV81PessoaWWDS_1_Pessoanome = AV75PessoaNome;
         AV82PessoaWWDS_2_Pessoaemail = AV77PessoaEmail;
         AV83PessoaWWDS_3_Tfpessoaid = AV42TFPessoaId;
         AV84PessoaWWDS_4_Tfpessoaid_to = AV43TFPessoaId_To;
         AV85PessoaWWDS_5_Tfpessoanome = AV46TFPessoaNome;
         AV86PessoaWWDS_6_Tfpessoanome_sel = AV47TFPessoaNome_Sel;
         AV87PessoaWWDS_7_Tfpessoatelefone = AV54TFPessoaTelefone;
         AV88PessoaWWDS_8_Tfpessoatelefone_sel = AV55TFPessoaTelefone_Sel;
         AV89PessoaWWDS_9_Tfpessoaemail = AV58TFPessoaEmail;
         AV90PessoaWWDS_10_Tfpessoaemail_sel = AV59TFPessoaEmail_Sel;
         AV91PessoaWWDS_11_Tfpessoasituacao_sel = AV66TFPessoaSituacao_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV74PessoaNomeOperator, AV75PessoaNome, AV76PessoaEmailOperator, AV77PessoaEmail, AV12OrderedBy, AV13OrderedDsc, AV42TFPessoaId, AV43TFPessoaId_To, AV46TFPessoaNome, AV47TFPessoaNome_Sel, AV54TFPessoaTelefone, AV55TFPessoaTelefone_Sel, AV58TFPessoaEmail, AV59TFPessoaEmail_Sel, AV66TFPessoaSituacao_Sel, AV35ManageFiltersExecutionStep, AV27ColumnsSelector, AV44ddo_PessoaIdTitleControlIdToReplace, AV48ddo_PessoaNomeTitleControlIdToReplace, AV56ddo_PessoaTelefoneTitleControlIdToReplace, AV60ddo_PessoaEmailTitleControlIdToReplace, AV67ddo_PessoaSituacaoTitleControlIdToReplace, AV92Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV81PessoaWWDS_1_Pessoanome = AV75PessoaNome;
         AV82PessoaWWDS_2_Pessoaemail = AV77PessoaEmail;
         AV83PessoaWWDS_3_Tfpessoaid = AV42TFPessoaId;
         AV84PessoaWWDS_4_Tfpessoaid_to = AV43TFPessoaId_To;
         AV85PessoaWWDS_5_Tfpessoanome = AV46TFPessoaNome;
         AV86PessoaWWDS_6_Tfpessoanome_sel = AV47TFPessoaNome_Sel;
         AV87PessoaWWDS_7_Tfpessoatelefone = AV54TFPessoaTelefone;
         AV88PessoaWWDS_8_Tfpessoatelefone_sel = AV55TFPessoaTelefone_Sel;
         AV89PessoaWWDS_9_Tfpessoaemail = AV58TFPessoaEmail;
         AV90PessoaWWDS_10_Tfpessoaemail_sel = AV59TFPessoaEmail_Sel;
         AV91PessoaWWDS_11_Tfpessoasituacao_sel = AV66TFPessoaSituacao_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV74PessoaNomeOperator, AV75PessoaNome, AV76PessoaEmailOperator, AV77PessoaEmail, AV12OrderedBy, AV13OrderedDsc, AV42TFPessoaId, AV43TFPessoaId_To, AV46TFPessoaNome, AV47TFPessoaNome_Sel, AV54TFPessoaTelefone, AV55TFPessoaTelefone_Sel, AV58TFPessoaEmail, AV59TFPessoaEmail_Sel, AV66TFPessoaSituacao_Sel, AV35ManageFiltersExecutionStep, AV27ColumnsSelector, AV44ddo_PessoaIdTitleControlIdToReplace, AV48ddo_PessoaNomeTitleControlIdToReplace, AV56ddo_PessoaTelefoneTitleControlIdToReplace, AV60ddo_PessoaEmailTitleControlIdToReplace, AV67ddo_PessoaSituacaoTitleControlIdToReplace, AV92Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV81PessoaWWDS_1_Pessoanome = AV75PessoaNome;
         AV82PessoaWWDS_2_Pessoaemail = AV77PessoaEmail;
         AV83PessoaWWDS_3_Tfpessoaid = AV42TFPessoaId;
         AV84PessoaWWDS_4_Tfpessoaid_to = AV43TFPessoaId_To;
         AV85PessoaWWDS_5_Tfpessoanome = AV46TFPessoaNome;
         AV86PessoaWWDS_6_Tfpessoanome_sel = AV47TFPessoaNome_Sel;
         AV87PessoaWWDS_7_Tfpessoatelefone = AV54TFPessoaTelefone;
         AV88PessoaWWDS_8_Tfpessoatelefone_sel = AV55TFPessoaTelefone_Sel;
         AV89PessoaWWDS_9_Tfpessoaemail = AV58TFPessoaEmail;
         AV90PessoaWWDS_10_Tfpessoaemail_sel = AV59TFPessoaEmail_Sel;
         AV91PessoaWWDS_11_Tfpessoasituacao_sel = AV66TFPessoaSituacao_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV74PessoaNomeOperator, AV75PessoaNome, AV76PessoaEmailOperator, AV77PessoaEmail, AV12OrderedBy, AV13OrderedDsc, AV42TFPessoaId, AV43TFPessoaId_To, AV46TFPessoaNome, AV47TFPessoaNome_Sel, AV54TFPessoaTelefone, AV55TFPessoaTelefone_Sel, AV58TFPessoaEmail, AV59TFPessoaEmail_Sel, AV66TFPessoaSituacao_Sel, AV35ManageFiltersExecutionStep, AV27ColumnsSelector, AV44ddo_PessoaIdTitleControlIdToReplace, AV48ddo_PessoaNomeTitleControlIdToReplace, AV56ddo_PessoaTelefoneTitleControlIdToReplace, AV60ddo_PessoaEmailTitleControlIdToReplace, AV67ddo_PessoaSituacaoTitleControlIdToReplace, AV92Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP0M0( )
      {
         /* Before Start, stand alone formulas. */
         AV92Pgmname = "PessoaWW";
         context.Gx_err = 0;
         edtavUpdate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Enabled), 5, 0)), !bGXsfl_67_Refreshing);
         edtavDelete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Enabled), 5, 0)), !bGXsfl_67_Refreshing);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E210M2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vMANAGEFILTERSDATA"), AV39ManageFiltersData);
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV68DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vPESSOAIDTITLEFILTERDATA"), AV41PessoaIdTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPESSOANOMETITLEFILTERDATA"), AV45PessoaNomeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPESSOATELEFONETITLEFILTERDATA"), AV53PessoaTelefoneTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPESSOAEMAILTITLEFILTERDATA"), AV57PessoaEmailTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPESSOASITUACAOTITLEFILTERDATA"), AV65PessoaSituacaoTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vCOLUMNSSELECTOR"), AV27ColumnsSelector);
            /* Read variables values. */
            cmbavPessoanomeoperator.Name = cmbavPessoanomeoperator_Internalname;
            cmbavPessoanomeoperator.CurrentValue = cgiGet( cmbavPessoanomeoperator_Internalname);
            AV74PessoaNomeOperator = (short)(NumberUtil.Val( cgiGet( cmbavPessoanomeoperator_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV74PessoaNomeOperator", StringUtil.LTrim( StringUtil.Str( (decimal)(AV74PessoaNomeOperator), 4, 0)));
            AV75PessoaNome = cgiGet( edtavPessoanome_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV75PessoaNome", AV75PessoaNome);
            cmbavPessoaemailoperator.Name = cmbavPessoaemailoperator_Internalname;
            cmbavPessoaemailoperator.CurrentValue = cgiGet( cmbavPessoaemailoperator_Internalname);
            AV76PessoaEmailOperator = (short)(NumberUtil.Val( cgiGet( cmbavPessoaemailoperator_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV76PessoaEmailOperator", StringUtil.LTrim( StringUtil.Str( (decimal)(AV76PessoaEmailOperator), 4, 0)));
            AV77PessoaEmail = cgiGet( edtavPessoaemail_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV77PessoaEmail", AV77PessoaEmail);
            AV44ddo_PessoaIdTitleControlIdToReplace = cgiGet( edtavDdo_pessoaidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44ddo_PessoaIdTitleControlIdToReplace", AV44ddo_PessoaIdTitleControlIdToReplace);
            AV48ddo_PessoaNomeTitleControlIdToReplace = cgiGet( edtavDdo_pessoanometitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV48ddo_PessoaNomeTitleControlIdToReplace", AV48ddo_PessoaNomeTitleControlIdToReplace);
            AV56ddo_PessoaTelefoneTitleControlIdToReplace = cgiGet( edtavDdo_pessoatelefonetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56ddo_PessoaTelefoneTitleControlIdToReplace", AV56ddo_PessoaTelefoneTitleControlIdToReplace);
            AV60ddo_PessoaEmailTitleControlIdToReplace = cgiGet( edtavDdo_pessoaemailtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60ddo_PessoaEmailTitleControlIdToReplace", AV60ddo_PessoaEmailTitleControlIdToReplace);
            AV67ddo_PessoaSituacaoTitleControlIdToReplace = cgiGet( edtavDdo_pessoasituacaotitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV67ddo_PessoaSituacaoTitleControlIdToReplace", AV67ddo_PessoaSituacaoTitleControlIdToReplace);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vORDEREDBY");
               GX_FocusControl = edtavOrderedby_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV12OrderedBy = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12OrderedBy), 4, 0)));
            }
            else
            {
               AV12OrderedBy = (short)(context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12OrderedBy), 4, 0)));
            }
            AV13OrderedDsc = StringUtil.StrToBool( cgiGet( edtavOrdereddsc_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedDsc", AV13OrderedDsc);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavManagefiltersexecutionstep_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavManagefiltersexecutionstep_Internalname), ",", ".") > Convert.ToDecimal( 9 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vMANAGEFILTERSEXECUTIONSTEP");
               GX_FocusControl = edtavManagefiltersexecutionstep_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV35ManageFiltersExecutionStep = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ManageFiltersExecutionStep", StringUtil.Str( (decimal)(AV35ManageFiltersExecutionStep), 1, 0));
            }
            else
            {
               AV35ManageFiltersExecutionStep = (short)(context.localUtil.CToN( cgiGet( edtavManagefiltersexecutionstep_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ManageFiltersExecutionStep", StringUtil.Str( (decimal)(AV35ManageFiltersExecutionStep), 1, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfpessoaid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfpessoaid_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFPESSOAID");
               GX_FocusControl = edtavTfpessoaid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV42TFPessoaId = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42TFPessoaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV42TFPessoaId), 4, 0)));
            }
            else
            {
               AV42TFPessoaId = (short)(context.localUtil.CToN( cgiGet( edtavTfpessoaid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42TFPessoaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV42TFPessoaId), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfpessoaid_to_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfpessoaid_to_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFPESSOAID_TO");
               GX_FocusControl = edtavTfpessoaid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV43TFPessoaId_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43TFPessoaId_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV43TFPessoaId_To), 4, 0)));
            }
            else
            {
               AV43TFPessoaId_To = (short)(context.localUtil.CToN( cgiGet( edtavTfpessoaid_to_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43TFPessoaId_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV43TFPessoaId_To), 4, 0)));
            }
            AV46TFPessoaNome = cgiGet( edtavTfpessoanome_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46TFPessoaNome", AV46TFPessoaNome);
            AV47TFPessoaNome_Sel = cgiGet( edtavTfpessoanome_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47TFPessoaNome_Sel", AV47TFPessoaNome_Sel);
            AV54TFPessoaTelefone = cgiGet( edtavTfpessoatelefone_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV54TFPessoaTelefone", AV54TFPessoaTelefone);
            AV55TFPessoaTelefone_Sel = cgiGet( edtavTfpessoatelefone_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV55TFPessoaTelefone_Sel", AV55TFPessoaTelefone_Sel);
            AV58TFPessoaEmail = cgiGet( edtavTfpessoaemail_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV58TFPessoaEmail", AV58TFPessoaEmail);
            AV59TFPessoaEmail_Sel = cgiGet( edtavTfpessoaemail_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV59TFPessoaEmail_Sel", AV59TFPessoaEmail_Sel);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfpessoasituacao_sel_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfpessoasituacao_sel_Internalname), ",", ".") > Convert.ToDecimal( 9 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFPESSOASITUACAO_SEL");
               GX_FocusControl = edtavTfpessoasituacao_sel_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV66TFPessoaSituacao_Sel = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV66TFPessoaSituacao_Sel", StringUtil.Str( (decimal)(AV66TFPessoaSituacao_Sel), 1, 0));
            }
            else
            {
               AV66TFPessoaSituacao_Sel = (short)(context.localUtil.CToN( cgiGet( edtavTfpessoasituacao_sel_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV66TFPessoaSituacao_Sel", StringUtil.Str( (decimal)(AV66TFPessoaSituacao_Sel), 1, 0));
            }
            /* Read saved values. */
            nRC_GXsfl_67 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_67"), ",", "."));
            AV70GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ",", "."));
            AV71GridPageCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGECOUNT"), ",", "."));
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
            Ddo_pessoatelefone_Caption = cgiGet( "DDO_PESSOATELEFONE_Caption");
            Ddo_pessoatelefone_Tooltip = cgiGet( "DDO_PESSOATELEFONE_Tooltip");
            Ddo_pessoatelefone_Cls = cgiGet( "DDO_PESSOATELEFONE_Cls");
            Ddo_pessoatelefone_Filteredtext_set = cgiGet( "DDO_PESSOATELEFONE_Filteredtext_set");
            Ddo_pessoatelefone_Selectedvalue_set = cgiGet( "DDO_PESSOATELEFONE_Selectedvalue_set");
            Ddo_pessoatelefone_Dropdownoptionstype = cgiGet( "DDO_PESSOATELEFONE_Dropdownoptionstype");
            Ddo_pessoatelefone_Titlecontrolidtoreplace = cgiGet( "DDO_PESSOATELEFONE_Titlecontrolidtoreplace");
            Ddo_pessoatelefone_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PESSOATELEFONE_Includesortasc"));
            Ddo_pessoatelefone_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PESSOATELEFONE_Includesortdsc"));
            Ddo_pessoatelefone_Sortedstatus = cgiGet( "DDO_PESSOATELEFONE_Sortedstatus");
            Ddo_pessoatelefone_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PESSOATELEFONE_Includefilter"));
            Ddo_pessoatelefone_Filtertype = cgiGet( "DDO_PESSOATELEFONE_Filtertype");
            Ddo_pessoatelefone_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_PESSOATELEFONE_Filterisrange"));
            Ddo_pessoatelefone_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PESSOATELEFONE_Includedatalist"));
            Ddo_pessoatelefone_Datalisttype = cgiGet( "DDO_PESSOATELEFONE_Datalisttype");
            Ddo_pessoatelefone_Datalistproc = cgiGet( "DDO_PESSOATELEFONE_Datalistproc");
            Ddo_pessoatelefone_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_PESSOATELEFONE_Datalistupdateminimumcharacters"), ",", "."));
            Ddo_pessoatelefone_Sortasc = cgiGet( "DDO_PESSOATELEFONE_Sortasc");
            Ddo_pessoatelefone_Sortdsc = cgiGet( "DDO_PESSOATELEFONE_Sortdsc");
            Ddo_pessoatelefone_Loadingdata = cgiGet( "DDO_PESSOATELEFONE_Loadingdata");
            Ddo_pessoatelefone_Cleanfilter = cgiGet( "DDO_PESSOATELEFONE_Cleanfilter");
            Ddo_pessoatelefone_Noresultsfound = cgiGet( "DDO_PESSOATELEFONE_Noresultsfound");
            Ddo_pessoatelefone_Searchbuttontext = cgiGet( "DDO_PESSOATELEFONE_Searchbuttontext");
            Ddo_pessoaemail_Caption = cgiGet( "DDO_PESSOAEMAIL_Caption");
            Ddo_pessoaemail_Tooltip = cgiGet( "DDO_PESSOAEMAIL_Tooltip");
            Ddo_pessoaemail_Cls = cgiGet( "DDO_PESSOAEMAIL_Cls");
            Ddo_pessoaemail_Filteredtext_set = cgiGet( "DDO_PESSOAEMAIL_Filteredtext_set");
            Ddo_pessoaemail_Selectedvalue_set = cgiGet( "DDO_PESSOAEMAIL_Selectedvalue_set");
            Ddo_pessoaemail_Dropdownoptionstype = cgiGet( "DDO_PESSOAEMAIL_Dropdownoptionstype");
            Ddo_pessoaemail_Titlecontrolidtoreplace = cgiGet( "DDO_PESSOAEMAIL_Titlecontrolidtoreplace");
            Ddo_pessoaemail_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PESSOAEMAIL_Includesortasc"));
            Ddo_pessoaemail_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PESSOAEMAIL_Includesortdsc"));
            Ddo_pessoaemail_Sortedstatus = cgiGet( "DDO_PESSOAEMAIL_Sortedstatus");
            Ddo_pessoaemail_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PESSOAEMAIL_Includefilter"));
            Ddo_pessoaemail_Filtertype = cgiGet( "DDO_PESSOAEMAIL_Filtertype");
            Ddo_pessoaemail_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_PESSOAEMAIL_Filterisrange"));
            Ddo_pessoaemail_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PESSOAEMAIL_Includedatalist"));
            Ddo_pessoaemail_Datalisttype = cgiGet( "DDO_PESSOAEMAIL_Datalisttype");
            Ddo_pessoaemail_Datalistproc = cgiGet( "DDO_PESSOAEMAIL_Datalistproc");
            Ddo_pessoaemail_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_PESSOAEMAIL_Datalistupdateminimumcharacters"), ",", "."));
            Ddo_pessoaemail_Sortasc = cgiGet( "DDO_PESSOAEMAIL_Sortasc");
            Ddo_pessoaemail_Sortdsc = cgiGet( "DDO_PESSOAEMAIL_Sortdsc");
            Ddo_pessoaemail_Loadingdata = cgiGet( "DDO_PESSOAEMAIL_Loadingdata");
            Ddo_pessoaemail_Cleanfilter = cgiGet( "DDO_PESSOAEMAIL_Cleanfilter");
            Ddo_pessoaemail_Noresultsfound = cgiGet( "DDO_PESSOAEMAIL_Noresultsfound");
            Ddo_pessoaemail_Searchbuttontext = cgiGet( "DDO_PESSOAEMAIL_Searchbuttontext");
            Ddo_pessoasituacao_Caption = cgiGet( "DDO_PESSOASITUACAO_Caption");
            Ddo_pessoasituacao_Tooltip = cgiGet( "DDO_PESSOASITUACAO_Tooltip");
            Ddo_pessoasituacao_Cls = cgiGet( "DDO_PESSOASITUACAO_Cls");
            Ddo_pessoasituacao_Selectedvalue_set = cgiGet( "DDO_PESSOASITUACAO_Selectedvalue_set");
            Ddo_pessoasituacao_Dropdownoptionstype = cgiGet( "DDO_PESSOASITUACAO_Dropdownoptionstype");
            Ddo_pessoasituacao_Titlecontrolidtoreplace = cgiGet( "DDO_PESSOASITUACAO_Titlecontrolidtoreplace");
            Ddo_pessoasituacao_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PESSOASITUACAO_Includesortasc"));
            Ddo_pessoasituacao_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PESSOASITUACAO_Includesortdsc"));
            Ddo_pessoasituacao_Sortedstatus = cgiGet( "DDO_PESSOASITUACAO_Sortedstatus");
            Ddo_pessoasituacao_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PESSOASITUACAO_Includefilter"));
            Ddo_pessoasituacao_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PESSOASITUACAO_Includedatalist"));
            Ddo_pessoasituacao_Datalisttype = cgiGet( "DDO_PESSOASITUACAO_Datalisttype");
            Ddo_pessoasituacao_Datalistfixedvalues = cgiGet( "DDO_PESSOASITUACAO_Datalistfixedvalues");
            Ddo_pessoasituacao_Sortasc = cgiGet( "DDO_PESSOASITUACAO_Sortasc");
            Ddo_pessoasituacao_Sortdsc = cgiGet( "DDO_PESSOASITUACAO_Sortdsc");
            Ddo_pessoasituacao_Cleanfilter = cgiGet( "DDO_PESSOASITUACAO_Cleanfilter");
            Ddo_pessoasituacao_Searchbuttontext = cgiGet( "DDO_PESSOASITUACAO_Searchbuttontext");
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
            Ddo_pessoaid_Activeeventkey = cgiGet( "DDO_PESSOAID_Activeeventkey");
            Ddo_pessoaid_Filteredtext_get = cgiGet( "DDO_PESSOAID_Filteredtext_get");
            Ddo_pessoaid_Filteredtextto_get = cgiGet( "DDO_PESSOAID_Filteredtextto_get");
            Ddo_pessoanome_Activeeventkey = cgiGet( "DDO_PESSOANOME_Activeeventkey");
            Ddo_pessoanome_Filteredtext_get = cgiGet( "DDO_PESSOANOME_Filteredtext_get");
            Ddo_pessoanome_Selectedvalue_get = cgiGet( "DDO_PESSOANOME_Selectedvalue_get");
            Ddo_pessoatelefone_Activeeventkey = cgiGet( "DDO_PESSOATELEFONE_Activeeventkey");
            Ddo_pessoatelefone_Filteredtext_get = cgiGet( "DDO_PESSOATELEFONE_Filteredtext_get");
            Ddo_pessoatelefone_Selectedvalue_get = cgiGet( "DDO_PESSOATELEFONE_Selectedvalue_get");
            Ddo_pessoaemail_Activeeventkey = cgiGet( "DDO_PESSOAEMAIL_Activeeventkey");
            Ddo_pessoaemail_Filteredtext_get = cgiGet( "DDO_PESSOAEMAIL_Filteredtext_get");
            Ddo_pessoaemail_Selectedvalue_get = cgiGet( "DDO_PESSOAEMAIL_Selectedvalue_get");
            Ddo_pessoasituacao_Activeeventkey = cgiGet( "DDO_PESSOASITUACAO_Activeeventkey");
            Ddo_pessoasituacao_Selectedvalue_get = cgiGet( "DDO_PESSOASITUACAO_Selectedvalue_get");
            Ddo_gridcolumnsselector_Columnsselectorvalues = cgiGet( "DDO_GRIDCOLUMNSSELECTOR_Columnsselectorvalues");
            Ddo_managefilters_Activeeventkey = cgiGet( "DDO_MANAGEFILTERS_Activeeventkey");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ",", "."));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vPESSOANOMEOPERATOR"), ",", ".") != Convert.ToDecimal( AV74PessoaNomeOperator )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vPESSOANOME"), AV75PessoaNome) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vPESSOAEMAILOPERATOR"), ",", ".") != Convert.ToDecimal( AV76PessoaEmailOperator )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vPESSOAEMAIL"), AV77PessoaEmail) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ",", ".") != Convert.ToDecimal( AV12OrderedBy )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV13OrderedDsc )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFPESSOAID"), ",", ".") != Convert.ToDecimal( AV42TFPessoaId )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFPESSOAID_TO"), ",", ".") != Convert.ToDecimal( AV43TFPessoaId_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFPESSOANOME"), AV46TFPessoaNome) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFPESSOANOME_SEL"), AV47TFPessoaNome_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFPESSOATELEFONE"), AV54TFPessoaTelefone) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFPESSOATELEFONE_SEL"), AV55TFPessoaTelefone_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFPESSOAEMAIL"), AV58TFPessoaEmail) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFPESSOAEMAIL_SEL"), AV59TFPessoaEmail_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFPESSOASITUACAO_SEL"), ",", ".") != Convert.ToDecimal( AV66TFPessoaSituacao_Sel )) )
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
         E210M2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E210M2( )
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
         edtavTfpessoaid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfpessoaid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfpessoaid_Visible), 5, 0)), true);
         edtavTfpessoaid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfpessoaid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfpessoaid_to_Visible), 5, 0)), true);
         edtavTfpessoanome_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfpessoanome_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfpessoanome_Visible), 5, 0)), true);
         edtavTfpessoanome_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfpessoanome_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfpessoanome_sel_Visible), 5, 0)), true);
         edtavTfpessoatelefone_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfpessoatelefone_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfpessoatelefone_Visible), 5, 0)), true);
         edtavTfpessoatelefone_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfpessoatelefone_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfpessoatelefone_sel_Visible), 5, 0)), true);
         edtavTfpessoaemail_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfpessoaemail_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfpessoaemail_Visible), 5, 0)), true);
         edtavTfpessoaemail_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfpessoaemail_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfpessoaemail_sel_Visible), 5, 0)), true);
         edtavTfpessoasituacao_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfpessoasituacao_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfpessoasituacao_sel_Visible), 5, 0)), true);
         Ddo_pessoaid_Titlecontrolidtoreplace = subGrid_Internalname+"_PessoaId";
         ucDdo_pessoaid.SendProperty(context, "", false, Ddo_pessoaid_Internalname, "TitleControlIdToReplace", Ddo_pessoaid_Titlecontrolidtoreplace);
         AV44ddo_PessoaIdTitleControlIdToReplace = Ddo_pessoaid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44ddo_PessoaIdTitleControlIdToReplace", AV44ddo_PessoaIdTitleControlIdToReplace);
         edtavDdo_pessoaidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_pessoaidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_pessoaidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_pessoanome_Titlecontrolidtoreplace = subGrid_Internalname+"_PessoaNome";
         ucDdo_pessoanome.SendProperty(context, "", false, Ddo_pessoanome_Internalname, "TitleControlIdToReplace", Ddo_pessoanome_Titlecontrolidtoreplace);
         AV48ddo_PessoaNomeTitleControlIdToReplace = Ddo_pessoanome_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV48ddo_PessoaNomeTitleControlIdToReplace", AV48ddo_PessoaNomeTitleControlIdToReplace);
         edtavDdo_pessoanometitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_pessoanometitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_pessoanometitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_pessoatelefone_Titlecontrolidtoreplace = subGrid_Internalname+"_PessoaTelefone";
         ucDdo_pessoatelefone.SendProperty(context, "", false, Ddo_pessoatelefone_Internalname, "TitleControlIdToReplace", Ddo_pessoatelefone_Titlecontrolidtoreplace);
         AV56ddo_PessoaTelefoneTitleControlIdToReplace = Ddo_pessoatelefone_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56ddo_PessoaTelefoneTitleControlIdToReplace", AV56ddo_PessoaTelefoneTitleControlIdToReplace);
         edtavDdo_pessoatelefonetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_pessoatelefonetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_pessoatelefonetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_pessoaemail_Titlecontrolidtoreplace = subGrid_Internalname+"_PessoaEmail";
         ucDdo_pessoaemail.SendProperty(context, "", false, Ddo_pessoaemail_Internalname, "TitleControlIdToReplace", Ddo_pessoaemail_Titlecontrolidtoreplace);
         AV60ddo_PessoaEmailTitleControlIdToReplace = Ddo_pessoaemail_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60ddo_PessoaEmailTitleControlIdToReplace", AV60ddo_PessoaEmailTitleControlIdToReplace);
         edtavDdo_pessoaemailtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_pessoaemailtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_pessoaemailtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_pessoasituacao_Titlecontrolidtoreplace = subGrid_Internalname+"_PessoaSituacao";
         ucDdo_pessoasituacao.SendProperty(context, "", false, Ddo_pessoasituacao_Internalname, "TitleControlIdToReplace", Ddo_pessoasituacao_Titlecontrolidtoreplace);
         AV67ddo_PessoaSituacaoTitleControlIdToReplace = Ddo_pessoasituacao_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV67ddo_PessoaSituacaoTitleControlIdToReplace", AV67ddo_PessoaSituacaoTitleControlIdToReplace);
         edtavDdo_pessoasituacaotitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_pessoasituacaotitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_pessoasituacaotitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = " Pessoa";
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
         if ( AV12OrderedBy < 1 )
         {
            AV12OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12OrderedBy), 4, 0)));
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV68DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV68DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Ddo_gridcolumnsselector_Titlecontrolidtoreplace = bttBtneditcolumns_Internalname;
         ucDdo_gridcolumnsselector.SendProperty(context, "", false, Ddo_gridcolumnsselector_Internalname, "TitleControlIdToReplace", Ddo_gridcolumnsselector_Titlecontrolidtoreplace);
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E220M2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV41PessoaIdTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV45PessoaNomeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV53PessoaTelefoneTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV57PessoaEmailTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV65PessoaSituacaoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         if ( AV35ManageFiltersExecutionStep == 1 )
         {
            AV35ManageFiltersExecutionStep = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ManageFiltersExecutionStep", StringUtil.Str( (decimal)(AV35ManageFiltersExecutionStep), 1, 0));
         }
         else if ( AV35ManageFiltersExecutionStep == 2 )
         {
            AV35ManageFiltersExecutionStep = 0;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ManageFiltersExecutionStep", StringUtil.Str( (decimal)(AV35ManageFiltersExecutionStep), 1, 0));
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
         if ( StringUtil.StrCmp(AV34Session.Get("PessoaWWColumnsSelector"), "") != 0 )
         {
            AV15ColumnsSelectorXML = AV34Session.Get("PessoaWWColumnsSelector");
            AV27ColumnsSelector.FromXml(AV15ColumnsSelectorXML, null, "WWPColumnsSelector", "FMX");
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
         edtPessoaId_Visible = (((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV27ColumnsSelector.gxTpr_Columns.Item(1)).gxTpr_Isvisible ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPessoaId_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPessoaId_Visible), 5, 0)), !bGXsfl_67_Refreshing);
         edtPessoaNome_Visible = (((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV27ColumnsSelector.gxTpr_Columns.Item(2)).gxTpr_Isvisible ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPessoaNome_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPessoaNome_Visible), 5, 0)), !bGXsfl_67_Refreshing);
         edtPessoaTelefone_Visible = (((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV27ColumnsSelector.gxTpr_Columns.Item(3)).gxTpr_Isvisible ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPessoaTelefone_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPessoaTelefone_Visible), 5, 0)), !bGXsfl_67_Refreshing);
         edtPessoaEmail_Visible = (((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV27ColumnsSelector.gxTpr_Columns.Item(4)).gxTpr_Isvisible ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPessoaEmail_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPessoaEmail_Visible), 5, 0)), !bGXsfl_67_Refreshing);
         chkPessoaSituacao.Visible = (((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV27ColumnsSelector.gxTpr_Columns.Item(5)).gxTpr_Isvisible ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkPessoaSituacao_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(chkPessoaSituacao.Visible), 5, 0)), !bGXsfl_67_Refreshing);
         edtPessoaId_Titleformat = 2;
         edtPessoaId_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Id", AV44ddo_PessoaIdTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPessoaId_Internalname, "Title", edtPessoaId_Title, !bGXsfl_67_Refreshing);
         edtPessoaNome_Titleformat = 2;
         edtPessoaNome_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Nome", AV48ddo_PessoaNomeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPessoaNome_Internalname, "Title", edtPessoaNome_Title, !bGXsfl_67_Refreshing);
         edtPessoaTelefone_Titleformat = 2;
         edtPessoaTelefone_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Telefone", AV56ddo_PessoaTelefoneTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPessoaTelefone_Internalname, "Title", edtPessoaTelefone_Title, !bGXsfl_67_Refreshing);
         edtPessoaEmail_Titleformat = 2;
         edtPessoaEmail_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "E-mail", AV60ddo_PessoaEmailTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPessoaEmail_Internalname, "Title", edtPessoaEmail_Title, !bGXsfl_67_Refreshing);
         chkPessoaSituacao_Titleformat = 2;
         chkPessoaSituacao.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Situação", AV67ddo_PessoaSituacaoTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkPessoaSituacao_Internalname, "Title", chkPessoaSituacao.Title.Text, !bGXsfl_67_Refreshing);
         AV70GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV70GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV70GridCurrentPage), 10, 0)));
         AV71GridPageCount = subGrid_Pagecount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV71GridPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV71GridPageCount), 10, 0)));
         AV81PessoaWWDS_1_Pessoanome = AV75PessoaNome;
         AV82PessoaWWDS_2_Pessoaemail = AV77PessoaEmail;
         AV83PessoaWWDS_3_Tfpessoaid = AV42TFPessoaId;
         AV84PessoaWWDS_4_Tfpessoaid_to = AV43TFPessoaId_To;
         AV85PessoaWWDS_5_Tfpessoanome = AV46TFPessoaNome;
         AV86PessoaWWDS_6_Tfpessoanome_sel = AV47TFPessoaNome_Sel;
         AV87PessoaWWDS_7_Tfpessoatelefone = AV54TFPessoaTelefone;
         AV88PessoaWWDS_8_Tfpessoatelefone_sel = AV55TFPessoaTelefone_Sel;
         AV89PessoaWWDS_9_Tfpessoaemail = AV58TFPessoaEmail;
         AV90PessoaWWDS_10_Tfpessoaemail_sel = AV59TFPessoaEmail_Sel;
         AV91PessoaWWDS_11_Tfpessoasituacao_sel = AV66TFPessoaSituacao_Sel;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41PessoaIdTitleFilterData", AV41PessoaIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45PessoaNomeTitleFilterData", AV45PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53PessoaTelefoneTitleFilterData", AV53PessoaTelefoneTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV57PessoaEmailTitleFilterData", AV57PessoaEmailTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV65PessoaSituacaoTitleFilterData", AV65PessoaSituacaoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27ColumnsSelector", AV27ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39ManageFiltersData", AV39ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E120M2( )
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
            AV69PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV69PageToGo) ;
         }
      }

      protected void E130M2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E140M2( )
      {
         /* Ddo_pessoaid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_pessoaid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S172 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV12OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12OrderedBy), 4, 0)));
            AV13OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedDsc", AV13OrderedDsc);
            Ddo_pessoaid_Sortedstatus = "ASC";
            ucDdo_pessoaid.SendProperty(context, "", false, Ddo_pessoaid_Internalname, "SortedStatus", Ddo_pessoaid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pessoaid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S172 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV12OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12OrderedBy), 4, 0)));
            AV13OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedDsc", AV13OrderedDsc);
            Ddo_pessoaid_Sortedstatus = "DSC";
            ucDdo_pessoaid.SendProperty(context, "", false, Ddo_pessoaid_Internalname, "SortedStatus", Ddo_pessoaid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pessoaid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV42TFPessoaId = (short)(NumberUtil.Val( Ddo_pessoaid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42TFPessoaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV42TFPessoaId), 4, 0)));
            AV43TFPessoaId_To = (short)(NumberUtil.Val( Ddo_pessoaid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43TFPessoaId_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV43TFPessoaId_To), 4, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41PessoaIdTitleFilterData", AV41PessoaIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45PessoaNomeTitleFilterData", AV45PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53PessoaTelefoneTitleFilterData", AV53PessoaTelefoneTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV57PessoaEmailTitleFilterData", AV57PessoaEmailTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV65PessoaSituacaoTitleFilterData", AV65PessoaSituacaoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27ColumnsSelector", AV27ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39ManageFiltersData", AV39ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E150M2( )
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
            AV12OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12OrderedBy), 4, 0)));
            AV13OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedDsc", AV13OrderedDsc);
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
            AV12OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12OrderedBy), 4, 0)));
            AV13OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedDsc", AV13OrderedDsc);
            Ddo_pessoanome_Sortedstatus = "DSC";
            ucDdo_pessoanome.SendProperty(context, "", false, Ddo_pessoanome_Internalname, "SortedStatus", Ddo_pessoanome_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pessoanome_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV46TFPessoaNome = Ddo_pessoanome_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46TFPessoaNome", AV46TFPessoaNome);
            AV47TFPessoaNome_Sel = Ddo_pessoanome_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47TFPessoaNome_Sel", AV47TFPessoaNome_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41PessoaIdTitleFilterData", AV41PessoaIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45PessoaNomeTitleFilterData", AV45PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53PessoaTelefoneTitleFilterData", AV53PessoaTelefoneTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV57PessoaEmailTitleFilterData", AV57PessoaEmailTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV65PessoaSituacaoTitleFilterData", AV65PessoaSituacaoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27ColumnsSelector", AV27ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39ManageFiltersData", AV39ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E160M2( )
      {
         /* Ddo_pessoatelefone_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_pessoatelefone_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S172 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV12OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12OrderedBy), 4, 0)));
            AV13OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedDsc", AV13OrderedDsc);
            Ddo_pessoatelefone_Sortedstatus = "ASC";
            ucDdo_pessoatelefone.SendProperty(context, "", false, Ddo_pessoatelefone_Internalname, "SortedStatus", Ddo_pessoatelefone_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pessoatelefone_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S172 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV12OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12OrderedBy), 4, 0)));
            AV13OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedDsc", AV13OrderedDsc);
            Ddo_pessoatelefone_Sortedstatus = "DSC";
            ucDdo_pessoatelefone.SendProperty(context, "", false, Ddo_pessoatelefone_Internalname, "SortedStatus", Ddo_pessoatelefone_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pessoatelefone_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV54TFPessoaTelefone = Ddo_pessoatelefone_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV54TFPessoaTelefone", AV54TFPessoaTelefone);
            AV55TFPessoaTelefone_Sel = Ddo_pessoatelefone_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV55TFPessoaTelefone_Sel", AV55TFPessoaTelefone_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41PessoaIdTitleFilterData", AV41PessoaIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45PessoaNomeTitleFilterData", AV45PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53PessoaTelefoneTitleFilterData", AV53PessoaTelefoneTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV57PessoaEmailTitleFilterData", AV57PessoaEmailTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV65PessoaSituacaoTitleFilterData", AV65PessoaSituacaoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27ColumnsSelector", AV27ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39ManageFiltersData", AV39ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E170M2( )
      {
         /* Ddo_pessoaemail_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_pessoaemail_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S172 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV12OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12OrderedBy), 4, 0)));
            AV13OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedDsc", AV13OrderedDsc);
            Ddo_pessoaemail_Sortedstatus = "ASC";
            ucDdo_pessoaemail.SendProperty(context, "", false, Ddo_pessoaemail_Internalname, "SortedStatus", Ddo_pessoaemail_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pessoaemail_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S172 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV12OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12OrderedBy), 4, 0)));
            AV13OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedDsc", AV13OrderedDsc);
            Ddo_pessoaemail_Sortedstatus = "DSC";
            ucDdo_pessoaemail.SendProperty(context, "", false, Ddo_pessoaemail_Internalname, "SortedStatus", Ddo_pessoaemail_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pessoaemail_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV58TFPessoaEmail = Ddo_pessoaemail_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV58TFPessoaEmail", AV58TFPessoaEmail);
            AV59TFPessoaEmail_Sel = Ddo_pessoaemail_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV59TFPessoaEmail_Sel", AV59TFPessoaEmail_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41PessoaIdTitleFilterData", AV41PessoaIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45PessoaNomeTitleFilterData", AV45PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53PessoaTelefoneTitleFilterData", AV53PessoaTelefoneTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV57PessoaEmailTitleFilterData", AV57PessoaEmailTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV65PessoaSituacaoTitleFilterData", AV65PessoaSituacaoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27ColumnsSelector", AV27ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39ManageFiltersData", AV39ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E180M2( )
      {
         /* Ddo_pessoasituacao_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_pessoasituacao_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S172 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV12OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12OrderedBy), 4, 0)));
            AV13OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedDsc", AV13OrderedDsc);
            Ddo_pessoasituacao_Sortedstatus = "ASC";
            ucDdo_pessoasituacao.SendProperty(context, "", false, Ddo_pessoasituacao_Internalname, "SortedStatus", Ddo_pessoasituacao_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pessoasituacao_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S172 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV12OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12OrderedBy), 4, 0)));
            AV13OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedDsc", AV13OrderedDsc);
            Ddo_pessoasituacao_Sortedstatus = "DSC";
            ucDdo_pessoasituacao.SendProperty(context, "", false, Ddo_pessoasituacao_Internalname, "SortedStatus", Ddo_pessoasituacao_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pessoasituacao_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV66TFPessoaSituacao_Sel = (short)(NumberUtil.Val( Ddo_pessoasituacao_Selectedvalue_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV66TFPessoaSituacao_Sel", StringUtil.Str( (decimal)(AV66TFPessoaSituacao_Sel), 1, 0));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41PessoaIdTitleFilterData", AV41PessoaIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45PessoaNomeTitleFilterData", AV45PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53PessoaTelefoneTitleFilterData", AV53PessoaTelefoneTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV57PessoaEmailTitleFilterData", AV57PessoaEmailTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV65PessoaSituacaoTitleFilterData", AV65PessoaSituacaoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27ColumnsSelector", AV27ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39ManageFiltersData", AV39ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      private void E230M2( )
      {
         /* Grid_Load Routine */
         AV72Update = "<i class=\"fa fa-pen\"></i>";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUpdate_Internalname, AV72Update);
         edtavUpdate_Link = formatLink("pessoa.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A1PessoaId);
         AV73Delete = "<i class=\"fa fa-times\"></i>";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDelete_Internalname, AV73Delete);
         edtavDelete_Link = formatLink("pessoa.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A1PessoaId);
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 67;
         }
         sendrow_672( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_67_Refreshing )
         {
            context.DoAjaxLoad(67, GridRow);
         }
         /*  Sending Event outputs  */
      }

      protected void E190M2( )
      {
         /* Ddo_gridcolumnsselector_Oncolumnschanged Routine */
         AV15ColumnsSelectorXML = Ddo_gridcolumnsselector_Columnsselectorvalues;
         AV27ColumnsSelector.FromJSonString(AV15ColumnsSelectorXML, null);
         new GeneXus.Programs.wwpbaseobjects.savecolumnsselectorstate(context ).execute(  "PessoaWWColumnsSelector",  AV27ColumnsSelector.ToXml(false, true, "WWPColumnsSelector", "FMX")) ;
         context.DoAjaxRefresh();
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27ColumnsSelector", AV27ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41PessoaIdTitleFilterData", AV41PessoaIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45PessoaNomeTitleFilterData", AV45PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53PessoaTelefoneTitleFilterData", AV53PessoaTelefoneTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV57PessoaEmailTitleFilterData", AV57PessoaEmailTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV65PessoaSituacaoTitleFilterData", AV65PessoaSituacaoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39ManageFiltersData", AV39ManageFiltersData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10GridState", AV10GridState);
      }

      protected void E110M2( )
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
            context.PopUp(formatLink("wwpbaseobjects.savefilteras.aspx") + "?" + UrlEncode(StringUtil.RTrim("PessoaWWFilters")) + "," + UrlEncode(StringUtil.RTrim(AV92Pgmname+"GridState")), new Object[] {});
            AV35ManageFiltersExecutionStep = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ManageFiltersExecutionStep", StringUtil.Str( (decimal)(AV35ManageFiltersExecutionStep), 1, 0));
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_managefilters_Activeeventkey, "<#Manage#>") == 0 )
         {
            context.PopUp(formatLink("wwpbaseobjects.managefilters.aspx") + "?" + UrlEncode(StringUtil.RTrim("PessoaWWFilters")), new Object[] {});
            AV35ManageFiltersExecutionStep = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ManageFiltersExecutionStep", StringUtil.Str( (decimal)(AV35ManageFiltersExecutionStep), 1, 0));
            context.DoAjaxRefresh();
         }
         else
         {
            GXt_char2 = AV36ManageFiltersXml;
            new GeneXus.Programs.wwpbaseobjects.getfilterbyname(context ).execute(  "PessoaWWFilters",  Ddo_managefilters_Activeeventkey, out  GXt_char2) ;
            ucDdo_managefilters.SendProperty(context, "", false, Ddo_managefilters_Internalname, "ActiveEventKey", Ddo_managefilters_Activeeventkey);
            AV36ManageFiltersXml = GXt_char2;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( AV36ManageFiltersXml)) )
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
               new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV92Pgmname+"GridState",  AV36ManageFiltersXml) ;
               AV10GridState.FromXml(AV36ManageFiltersXml, null, "WWPGridState", "FMX");
               AV12OrderedBy = AV10GridState.gxTpr_Orderedby;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12OrderedBy), 4, 0)));
               AV13OrderedDsc = AV10GridState.gxTpr_Ordereddsc;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedDsc", AV13OrderedDsc);
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
         cmbavPessoanomeoperator.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV74PessoaNomeOperator), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavPessoanomeoperator_Internalname, "Values", cmbavPessoanomeoperator.ToJavascriptSource(), true);
         cmbavPessoaemailoperator.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV76PessoaEmailOperator), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavPessoaemailoperator_Internalname, "Values", cmbavPessoaemailoperator.ToJavascriptSource(), true);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41PessoaIdTitleFilterData", AV41PessoaIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45PessoaNomeTitleFilterData", AV45PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53PessoaTelefoneTitleFilterData", AV53PessoaTelefoneTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV57PessoaEmailTitleFilterData", AV57PessoaEmailTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV65PessoaSituacaoTitleFilterData", AV65PessoaSituacaoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27ColumnsSelector", AV27ColumnsSelector);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39ManageFiltersData", AV39ManageFiltersData);
      }

      protected void E200M2( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("pessoa.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
         context.wjLocDisableFrm = 1;
      }

      protected void S172( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_pessoaid_Sortedstatus = "";
         ucDdo_pessoaid.SendProperty(context, "", false, Ddo_pessoaid_Internalname, "SortedStatus", Ddo_pessoaid_Sortedstatus);
         Ddo_pessoanome_Sortedstatus = "";
         ucDdo_pessoanome.SendProperty(context, "", false, Ddo_pessoanome_Internalname, "SortedStatus", Ddo_pessoanome_Sortedstatus);
         Ddo_pessoatelefone_Sortedstatus = "";
         ucDdo_pessoatelefone.SendProperty(context, "", false, Ddo_pessoatelefone_Internalname, "SortedStatus", Ddo_pessoatelefone_Sortedstatus);
         Ddo_pessoaemail_Sortedstatus = "";
         ucDdo_pessoaemail.SendProperty(context, "", false, Ddo_pessoaemail_Internalname, "SortedStatus", Ddo_pessoaemail_Sortedstatus);
         Ddo_pessoasituacao_Sortedstatus = "";
         ucDdo_pessoasituacao.SendProperty(context, "", false, Ddo_pessoasituacao_Internalname, "SortedStatus", Ddo_pessoasituacao_Sortedstatus);
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
         if ( AV12OrderedBy == 1 )
         {
            Ddo_pessoaid_Sortedstatus = (AV13OrderedDsc ? "DSC" : "ASC");
            ucDdo_pessoaid.SendProperty(context, "", false, Ddo_pessoaid_Internalname, "SortedStatus", Ddo_pessoaid_Sortedstatus);
         }
         else if ( AV12OrderedBy == 2 )
         {
            Ddo_pessoanome_Sortedstatus = (AV13OrderedDsc ? "DSC" : "ASC");
            ucDdo_pessoanome.SendProperty(context, "", false, Ddo_pessoanome_Internalname, "SortedStatus", Ddo_pessoanome_Sortedstatus);
         }
         else if ( AV12OrderedBy == 3 )
         {
            Ddo_pessoatelefone_Sortedstatus = (AV13OrderedDsc ? "DSC" : "ASC");
            ucDdo_pessoatelefone.SendProperty(context, "", false, Ddo_pessoatelefone_Internalname, "SortedStatus", Ddo_pessoatelefone_Sortedstatus);
         }
         else if ( AV12OrderedBy == 4 )
         {
            Ddo_pessoaemail_Sortedstatus = (AV13OrderedDsc ? "DSC" : "ASC");
            ucDdo_pessoaemail.SendProperty(context, "", false, Ddo_pessoaemail_Internalname, "SortedStatus", Ddo_pessoaemail_Sortedstatus);
         }
         else if ( AV12OrderedBy == 5 )
         {
            Ddo_pessoasituacao_Sortedstatus = (AV13OrderedDsc ? "DSC" : "ASC");
            ucDdo_pessoasituacao.SendProperty(context, "", false, Ddo_pessoasituacao_Internalname, "SortedStatus", Ddo_pessoasituacao_Sortedstatus);
         }
      }

      protected void S162( )
      {
         /* 'INITIALIZECOLUMNSSELECTOR' Routine */
         AV27ColumnsSelector = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector(context);
         new GeneXus.Programs.wwpbaseobjects.wwp_columnsselector_add(context ).execute( ref  AV27ColumnsSelector,  "Id",  true) ;
         new GeneXus.Programs.wwpbaseobjects.wwp_columnsselector_add(context ).execute( ref  AV27ColumnsSelector,  "Nome",  true) ;
         new GeneXus.Programs.wwpbaseobjects.wwp_columnsselector_add(context ).execute( ref  AV27ColumnsSelector,  "Telefone",  true) ;
         new GeneXus.Programs.wwpbaseobjects.wwp_columnsselector_add(context ).execute( ref  AV27ColumnsSelector,  "E-mail",  true) ;
         new GeneXus.Programs.wwpbaseobjects.wwp_columnsselector_add(context ).execute( ref  AV27ColumnsSelector,  "Situação",  true) ;
         GXt_char2 = AV22UserCustomValue;
         new GeneXus.Programs.wwpbaseobjects.loadcolumnsselectorstate(context ).execute(  "PessoaWWColumnsSelector", out  GXt_char2) ;
         AV22UserCustomValue = GXt_char2;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( AV22UserCustomValue)) ) )
         {
            AV28ColumnsSelectorAux.FromXml(AV22UserCustomValue, null, "WWPColumnsSelector", "FMX");
            new GeneXus.Programs.wwpbaseobjects.wwp_columnselector_updatecolumns(context ).execute( ref  AV28ColumnsSelectorAux, ref  AV27ColumnsSelector) ;
         }
      }

      protected void S112( )
      {
         /* 'LOADSAVEDFILTERS' Routine */
         AV39ManageFiltersData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV40ManageFiltersDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
         AV40ManageFiltersDataItem.gxTpr_Title = "Limpar filtros";
         AV40ManageFiltersDataItem.gxTpr_Eventkey = "<#Clean#>";
         AV40ManageFiltersDataItem.gxTpr_Isdivider = false;
         AV40ManageFiltersDataItem.gxTpr_Icon = context.convertURL( (String)(context.GetImagePath( "63d2ae92-4e43-4a70-af61-0943e39ea422", "", context.GetTheme( ))));
         AV39ManageFiltersData.Add(AV40ManageFiltersDataItem, 0);
         AV40ManageFiltersDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
         AV40ManageFiltersDataItem.gxTpr_Title = "Salvar filtro como...";
         AV40ManageFiltersDataItem.gxTpr_Eventkey = "<#Save#>";
         AV40ManageFiltersDataItem.gxTpr_Isdivider = false;
         AV40ManageFiltersDataItem.gxTpr_Icon = context.convertURL( (String)(context.GetImagePath( "6eee63e8-73c7-4738-beee-f98e3a8d2841", "", context.GetTheme( ))));
         AV39ManageFiltersData.Add(AV40ManageFiltersDataItem, 0);
         AV40ManageFiltersDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
         AV40ManageFiltersDataItem.gxTpr_Isdivider = true;
         AV39ManageFiltersData.Add(AV40ManageFiltersDataItem, 0);
         AV37ManageFiltersItems.FromXml(new GeneXus.Programs.wwpbaseobjects.loadmanagefiltersstate(context).executeUdp(  "PessoaWWFilters"), null, "Items", "");
         AV93GXV1 = 1;
         while ( AV93GXV1 <= AV37ManageFiltersItems.Count )
         {
            AV38ManageFiltersItem = ((GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item)AV37ManageFiltersItems.Item(AV93GXV1));
            AV40ManageFiltersDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
            AV40ManageFiltersDataItem.gxTpr_Title = AV38ManageFiltersItem.gxTpr_Title;
            AV40ManageFiltersDataItem.gxTpr_Eventkey = AV38ManageFiltersItem.gxTpr_Title;
            AV40ManageFiltersDataItem.gxTpr_Isdivider = false;
            AV39ManageFiltersData.Add(AV40ManageFiltersDataItem, 0);
            if ( AV39ManageFiltersData.Count == 13 )
            {
               if (true) break;
            }
            AV93GXV1 = (int)(AV93GXV1+1);
         }
         if ( AV39ManageFiltersData.Count > 3 )
         {
            AV40ManageFiltersDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
            AV40ManageFiltersDataItem.gxTpr_Isdivider = true;
            AV39ManageFiltersData.Add(AV40ManageFiltersDataItem, 0);
            AV40ManageFiltersDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
            AV40ManageFiltersDataItem.gxTpr_Title = "Gerenciar filtros";
            AV40ManageFiltersDataItem.gxTpr_Eventkey = "<#Manage#>";
            AV40ManageFiltersDataItem.gxTpr_Isdivider = false;
            AV40ManageFiltersDataItem.gxTpr_Icon = context.convertURL( (String)(context.GetImagePath( "653f6166-5d82-407a-af84-19e0dde65efd", "", context.GetTheme( ))));
            AV40ManageFiltersDataItem.gxTpr_Jsonclickevent = "";
            AV39ManageFiltersData.Add(AV40ManageFiltersDataItem, 0);
         }
      }

      protected void S182( )
      {
         /* 'CLEANFILTERS' Routine */
         AV74PessoaNomeOperator = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV74PessoaNomeOperator", StringUtil.LTrim( StringUtil.Str( (decimal)(AV74PessoaNomeOperator), 4, 0)));
         AV75PessoaNome = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV75PessoaNome", AV75PessoaNome);
         AV76PessoaEmailOperator = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV76PessoaEmailOperator", StringUtil.LTrim( StringUtil.Str( (decimal)(AV76PessoaEmailOperator), 4, 0)));
         AV77PessoaEmail = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV77PessoaEmail", AV77PessoaEmail);
         AV42TFPessoaId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42TFPessoaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV42TFPessoaId), 4, 0)));
         Ddo_pessoaid_Filteredtext_set = "";
         ucDdo_pessoaid.SendProperty(context, "", false, Ddo_pessoaid_Internalname, "FilteredText_set", Ddo_pessoaid_Filteredtext_set);
         AV43TFPessoaId_To = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43TFPessoaId_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV43TFPessoaId_To), 4, 0)));
         Ddo_pessoaid_Filteredtextto_set = "";
         ucDdo_pessoaid.SendProperty(context, "", false, Ddo_pessoaid_Internalname, "FilteredTextTo_set", Ddo_pessoaid_Filteredtextto_set);
         AV46TFPessoaNome = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46TFPessoaNome", AV46TFPessoaNome);
         Ddo_pessoanome_Filteredtext_set = "";
         ucDdo_pessoanome.SendProperty(context, "", false, Ddo_pessoanome_Internalname, "FilteredText_set", Ddo_pessoanome_Filteredtext_set);
         AV47TFPessoaNome_Sel = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47TFPessoaNome_Sel", AV47TFPessoaNome_Sel);
         Ddo_pessoanome_Selectedvalue_set = "";
         ucDdo_pessoanome.SendProperty(context, "", false, Ddo_pessoanome_Internalname, "SelectedValue_set", Ddo_pessoanome_Selectedvalue_set);
         AV54TFPessoaTelefone = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV54TFPessoaTelefone", AV54TFPessoaTelefone);
         Ddo_pessoatelefone_Filteredtext_set = "";
         ucDdo_pessoatelefone.SendProperty(context, "", false, Ddo_pessoatelefone_Internalname, "FilteredText_set", Ddo_pessoatelefone_Filteredtext_set);
         AV55TFPessoaTelefone_Sel = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV55TFPessoaTelefone_Sel", AV55TFPessoaTelefone_Sel);
         Ddo_pessoatelefone_Selectedvalue_set = "";
         ucDdo_pessoatelefone.SendProperty(context, "", false, Ddo_pessoatelefone_Internalname, "SelectedValue_set", Ddo_pessoatelefone_Selectedvalue_set);
         AV58TFPessoaEmail = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV58TFPessoaEmail", AV58TFPessoaEmail);
         Ddo_pessoaemail_Filteredtext_set = "";
         ucDdo_pessoaemail.SendProperty(context, "", false, Ddo_pessoaemail_Internalname, "FilteredText_set", Ddo_pessoaemail_Filteredtext_set);
         AV59TFPessoaEmail_Sel = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV59TFPessoaEmail_Sel", AV59TFPessoaEmail_Sel);
         Ddo_pessoaemail_Selectedvalue_set = "";
         ucDdo_pessoaemail.SendProperty(context, "", false, Ddo_pessoaemail_Internalname, "SelectedValue_set", Ddo_pessoaemail_Selectedvalue_set);
         AV66TFPessoaSituacao_Sel = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV66TFPessoaSituacao_Sel", StringUtil.Str( (decimal)(AV66TFPessoaSituacao_Sel), 1, 0));
         Ddo_pessoasituacao_Selectedvalue_set = "";
         ucDdo_pessoasituacao.SendProperty(context, "", false, Ddo_pessoasituacao_Internalname, "SelectedValue_set", Ddo_pessoasituacao_Selectedvalue_set);
      }

      protected void S132( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV34Session.Get(AV92Pgmname+"GridState"), "") == 0 )
         {
            AV10GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV92Pgmname+"GridState"), null, "WWPGridState", "FMX");
         }
         else
         {
            AV10GridState.FromXml(AV34Session.Get(AV92Pgmname+"GridState"), null, "WWPGridState", "FMX");
         }
         AV12OrderedBy = AV10GridState.gxTpr_Orderedby;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12OrderedBy), 4, 0)));
         AV13OrderedDsc = AV10GridState.gxTpr_Ordereddsc;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedDsc", AV13OrderedDsc);
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
         AV94GXV2 = 1;
         while ( AV94GXV2 <= AV10GridState.gxTpr_Filtervalues.Count )
         {
            AV11GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV10GridState.gxTpr_Filtervalues.Item(AV94GXV2));
            if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "PESSOANOME") == 0 )
            {
               AV75PessoaNome = AV11GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV75PessoaNome", AV75PessoaNome);
               AV74PessoaNomeOperator = AV11GridStateFilterValue.gxTpr_Operator;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV74PessoaNomeOperator", StringUtil.LTrim( StringUtil.Str( (decimal)(AV74PessoaNomeOperator), 4, 0)));
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "PESSOAEMAIL") == 0 )
            {
               AV77PessoaEmail = AV11GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV77PessoaEmail", AV77PessoaEmail);
               AV76PessoaEmailOperator = AV11GridStateFilterValue.gxTpr_Operator;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV76PessoaEmailOperator", StringUtil.LTrim( StringUtil.Str( (decimal)(AV76PessoaEmailOperator), 4, 0)));
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFPESSOAID") == 0 )
            {
               AV42TFPessoaId = (short)(NumberUtil.Val( AV11GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42TFPessoaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV42TFPessoaId), 4, 0)));
               AV43TFPessoaId_To = (short)(NumberUtil.Val( AV11GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43TFPessoaId_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV43TFPessoaId_To), 4, 0)));
               if ( ! (0==AV42TFPessoaId) )
               {
                  Ddo_pessoaid_Filteredtext_set = StringUtil.Str( (decimal)(AV42TFPessoaId), 4, 0);
                  ucDdo_pessoaid.SendProperty(context, "", false, Ddo_pessoaid_Internalname, "FilteredText_set", Ddo_pessoaid_Filteredtext_set);
               }
               if ( ! (0==AV43TFPessoaId_To) )
               {
                  Ddo_pessoaid_Filteredtextto_set = StringUtil.Str( (decimal)(AV43TFPessoaId_To), 4, 0);
                  ucDdo_pessoaid.SendProperty(context, "", false, Ddo_pessoaid_Internalname, "FilteredTextTo_set", Ddo_pessoaid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFPESSOANOME") == 0 )
            {
               AV46TFPessoaNome = AV11GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46TFPessoaNome", AV46TFPessoaNome);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV46TFPessoaNome)) )
               {
                  Ddo_pessoanome_Filteredtext_set = AV46TFPessoaNome;
                  ucDdo_pessoanome.SendProperty(context, "", false, Ddo_pessoanome_Internalname, "FilteredText_set", Ddo_pessoanome_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFPESSOANOME_SEL") == 0 )
            {
               AV47TFPessoaNome_Sel = AV11GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47TFPessoaNome_Sel", AV47TFPessoaNome_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV47TFPessoaNome_Sel)) )
               {
                  Ddo_pessoanome_Selectedvalue_set = AV47TFPessoaNome_Sel;
                  ucDdo_pessoanome.SendProperty(context, "", false, Ddo_pessoanome_Internalname, "SelectedValue_set", Ddo_pessoanome_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFPESSOATELEFONE") == 0 )
            {
               AV54TFPessoaTelefone = AV11GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV54TFPessoaTelefone", AV54TFPessoaTelefone);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV54TFPessoaTelefone)) )
               {
                  Ddo_pessoatelefone_Filteredtext_set = AV54TFPessoaTelefone;
                  ucDdo_pessoatelefone.SendProperty(context, "", false, Ddo_pessoatelefone_Internalname, "FilteredText_set", Ddo_pessoatelefone_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFPESSOATELEFONE_SEL") == 0 )
            {
               AV55TFPessoaTelefone_Sel = AV11GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV55TFPessoaTelefone_Sel", AV55TFPessoaTelefone_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55TFPessoaTelefone_Sel)) )
               {
                  Ddo_pessoatelefone_Selectedvalue_set = AV55TFPessoaTelefone_Sel;
                  ucDdo_pessoatelefone.SendProperty(context, "", false, Ddo_pessoatelefone_Internalname, "SelectedValue_set", Ddo_pessoatelefone_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFPESSOAEMAIL") == 0 )
            {
               AV58TFPessoaEmail = AV11GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV58TFPessoaEmail", AV58TFPessoaEmail);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV58TFPessoaEmail)) )
               {
                  Ddo_pessoaemail_Filteredtext_set = AV58TFPessoaEmail;
                  ucDdo_pessoaemail.SendProperty(context, "", false, Ddo_pessoaemail_Internalname, "FilteredText_set", Ddo_pessoaemail_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFPESSOAEMAIL_SEL") == 0 )
            {
               AV59TFPessoaEmail_Sel = AV11GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV59TFPessoaEmail_Sel", AV59TFPessoaEmail_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV59TFPessoaEmail_Sel)) )
               {
                  Ddo_pessoaemail_Selectedvalue_set = AV59TFPessoaEmail_Sel;
                  ucDdo_pessoaemail.SendProperty(context, "", false, Ddo_pessoaemail_Internalname, "SelectedValue_set", Ddo_pessoaemail_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV11GridStateFilterValue.gxTpr_Name, "TFPESSOASITUACAO_SEL") == 0 )
            {
               AV66TFPessoaSituacao_Sel = (short)(NumberUtil.Val( AV11GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV66TFPessoaSituacao_Sel", StringUtil.Str( (decimal)(AV66TFPessoaSituacao_Sel), 1, 0));
               if ( ! (0==AV66TFPessoaSituacao_Sel) )
               {
                  Ddo_pessoasituacao_Selectedvalue_set = StringUtil.Str( (decimal)(AV66TFPessoaSituacao_Sel), 1, 0);
                  ucDdo_pessoasituacao.SendProperty(context, "", false, Ddo_pessoasituacao_Internalname, "SelectedValue_set", Ddo_pessoasituacao_Selectedvalue_set);
               }
            }
            AV94GXV2 = (int)(AV94GXV2+1);
         }
      }

      protected void S152( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV10GridState.FromXml(AV34Session.Get(AV92Pgmname+"GridState"), null, "WWPGridState", "FMX");
         AV10GridState.gxTpr_Orderedby = AV12OrderedBy;
         AV10GridState.gxTpr_Ordereddsc = AV13OrderedDsc;
         AV10GridState.gxTpr_Filtervalues.Clear();
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV75PessoaNome)) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "PESSOANOME";
            AV11GridStateFilterValue.gxTpr_Value = AV75PessoaNome;
            AV11GridStateFilterValue.gxTpr_Operator = AV74PessoaNomeOperator;
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV77PessoaEmail)) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "PESSOAEMAIL";
            AV11GridStateFilterValue.gxTpr_Value = AV77PessoaEmail;
            AV11GridStateFilterValue.gxTpr_Operator = AV76PessoaEmailOperator;
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! ( (0==AV42TFPessoaId) && (0==AV43TFPessoaId_To) ) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFPESSOAID";
            AV11GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV42TFPessoaId), 4, 0);
            AV11GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV43TFPessoaId_To), 4, 0);
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV46TFPessoaNome)) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFPESSOANOME";
            AV11GridStateFilterValue.gxTpr_Value = AV46TFPessoaNome;
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV47TFPessoaNome_Sel)) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFPESSOANOME_SEL";
            AV11GridStateFilterValue.gxTpr_Value = AV47TFPessoaNome_Sel;
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV54TFPessoaTelefone)) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFPESSOATELEFONE";
            AV11GridStateFilterValue.gxTpr_Value = AV54TFPessoaTelefone;
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55TFPessoaTelefone_Sel)) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFPESSOATELEFONE_SEL";
            AV11GridStateFilterValue.gxTpr_Value = AV55TFPessoaTelefone_Sel;
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV58TFPessoaEmail)) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFPESSOAEMAIL";
            AV11GridStateFilterValue.gxTpr_Value = AV58TFPessoaEmail;
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV59TFPessoaEmail_Sel)) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFPESSOAEMAIL_SEL";
            AV11GridStateFilterValue.gxTpr_Value = AV59TFPessoaEmail_Sel;
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         if ( ! (0==AV66TFPessoaSituacao_Sel) )
         {
            AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV11GridStateFilterValue.gxTpr_Name = "TFPESSOASITUACAO_SEL";
            AV11GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV66TFPessoaSituacao_Sel), 1, 0);
            AV10GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0);
         }
         AV10GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV10GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV92Pgmname+"GridState",  AV10GridState.ToXml(false, true, "WWPGridState", "FMX")) ;
      }

      protected void S122( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV8TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV8TrnContext.gxTpr_Callerobject = AV92Pgmname;
         AV8TrnContext.gxTpr_Callerondelete = true;
         AV8TrnContext.gxTpr_Callerurl = AV7HTTPRequest.ScriptName+"?"+AV7HTTPRequest.QueryString;
         AV8TrnContext.gxTpr_Transactionname = "Pessoa";
         AV34Session.Set("TrnContext", AV8TrnContext.ToXml(false, true, "WWPTransactionContext", "FMX"));
      }

      protected void wb_table1_23_0M2( bool wbgen )
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
            ucDdo_managefilters.SetProperty("DropDownOptionsData", AV39ManageFiltersData);
            ucDdo_managefilters.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_managefilters_Internalname, "DDO_MANAGEFILTERSContainer");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_28_0M2( true) ;
         }
         else
         {
            wb_table2_28_0M2( false) ;
         }
         return  ;
      }

      protected void wb_table2_28_0M2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_23_0M2e( true) ;
         }
         else
         {
            wb_table1_23_0M2e( false) ;
         }
      }

      protected void wb_table2_28_0M2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblFiltertextpessoanome_Internalname, "Nome", "", "", lblFiltertextpessoanome_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescription", 0, "", 1, 1, 0, "HLP_PessoaWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table3_36_0M2( true) ;
         }
         else
         {
            wb_table3_36_0M2( false) ;
         }
         return  ;
      }

      protected void wb_table3_36_0M2e( bool wbgen )
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
            GxWebStd.gx_div_start( context, divTablesplittedfiltertextpessoaemail_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblFiltertextpessoaemail_Internalname, "E-mail", "", "", lblFiltertextpessoaemail_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescription", 0, "", 1, 1, 0, "HLP_PessoaWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table4_51_0M2( true) ;
         }
         else
         {
            wb_table4_51_0M2( false) ;
         }
         return  ;
      }

      protected void wb_table4_51_0M2e( bool wbgen )
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
            wb_table2_28_0M2e( true) ;
         }
         else
         {
            wb_table2_28_0M2e( false) ;
         }
      }

      protected void wb_table4_51_0M2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedpessoaemail_Internalname, tblTablemergedpessoaemail_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavPessoaemailoperator_Internalname, "Pessoa Email Operator", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'" + sGXsfl_67_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavPessoaemailoperator, cmbavPessoaemailoperator_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV76PessoaEmailOperator), 4, 0)), 1, cmbavPessoaemailoperator_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbavPessoaemailoperator.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", "", true, "HLP_PessoaWW.htm");
            cmbavPessoaemailoperator.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV76PessoaEmailOperator), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavPessoaemailoperator_Internalname, "Values", (String)(cmbavPessoaemailoperator.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavPessoaemail_Internalname, "Pessoa Email", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'" + sGXsfl_67_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavPessoaemail_Internalname, AV77PessoaEmail, StringUtil.RTrim( context.localUtil.Format( AV77PessoaEmail, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,58);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPessoaemail_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavPessoaemail_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_PessoaWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_51_0M2e( true) ;
         }
         else
         {
            wb_table4_51_0M2e( false) ;
         }
      }

      protected void wb_table3_36_0M2( bool wbgen )
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'" + sGXsfl_67_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavPessoanomeoperator, cmbavPessoanomeoperator_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV74PessoaNomeOperator), 4, 0)), 1, cmbavPessoanomeoperator_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbavPessoanomeoperator.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,40);\"", "", true, "HLP_PessoaWW.htm");
            cmbavPessoanomeoperator.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV74PessoaNomeOperator), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavPessoanomeoperator_Internalname, "Values", (String)(cmbavPessoanomeoperator.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavPessoanome_Internalname, "Pessoa Nome", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'" + sGXsfl_67_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavPessoanome_Internalname, AV75PessoaNome, StringUtil.RTrim( context.localUtil.Format( AV75PessoaNome, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPessoanome_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavPessoanome_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_PessoaWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_36_0M2e( true) ;
         }
         else
         {
            wb_table3_36_0M2e( false) ;
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
         PA0M2( ) ;
         WS0M2( ) ;
         WE0M2( ) ;
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
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201971218145764", true, true);
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
         context.AddJavascriptSource("pessoaww.js", "?201971218145764", false, true);
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
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false, true);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_672( )
      {
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_67_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_67_idx;
         edtPessoaId_Internalname = "PESSOAID_"+sGXsfl_67_idx;
         edtPessoaNome_Internalname = "PESSOANOME_"+sGXsfl_67_idx;
         edtPessoaEndereco_Internalname = "PESSOAENDERECO_"+sGXsfl_67_idx;
         edtPessoaTelefone_Internalname = "PESSOATELEFONE_"+sGXsfl_67_idx;
         edtPessoaEmail_Internalname = "PESSOAEMAIL_"+sGXsfl_67_idx;
         cmbPessoaSexo_Internalname = "PESSOASEXO_"+sGXsfl_67_idx;
         chkPessoaSituacao_Internalname = "PESSOASITUACAO_"+sGXsfl_67_idx;
      }

      protected void SubsflControlProps_fel_672( )
      {
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_67_fel_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_67_fel_idx;
         edtPessoaId_Internalname = "PESSOAID_"+sGXsfl_67_fel_idx;
         edtPessoaNome_Internalname = "PESSOANOME_"+sGXsfl_67_fel_idx;
         edtPessoaEndereco_Internalname = "PESSOAENDERECO_"+sGXsfl_67_fel_idx;
         edtPessoaTelefone_Internalname = "PESSOATELEFONE_"+sGXsfl_67_fel_idx;
         edtPessoaEmail_Internalname = "PESSOAEMAIL_"+sGXsfl_67_fel_idx;
         cmbPessoaSexo_Internalname = "PESSOASEXO_"+sGXsfl_67_fel_idx;
         chkPessoaSituacao_Internalname = "PESSOASITUACAO_"+sGXsfl_67_fel_idx;
      }

      protected void sendrow_672( )
      {
         SubsflControlProps_672( ) ;
         WB0M0( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_67_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_67_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_67_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,StringUtil.RTrim( AV72Update),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtavUpdate_Link,(String)"",(String)"Modifica",(String)"",(String)edtavUpdate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWIconActionColumn",(String)"",(short)-1,(int)edtavUpdate_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)1,(short)67,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,StringUtil.RTrim( AV73Delete),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtavDelete_Link,(String)"",(String)"Eliminar",(String)"",(String)edtavDelete_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWIconActionColumn",(String)"",(short)-1,(int)edtavDelete_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)1,(short)67,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((edtPessoaId_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPessoaId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A1PessoaId), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A1PessoaId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPessoaId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(int)edtPessoaId_Visible,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)67,(short)1,(short)-1,(short)0,(bool)true,(String)"Serial",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((edtPessoaNome_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPessoaNome_Internalname,(String)A2PessoaNome,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPessoaNome_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(int)edtPessoaNome_Visible,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)60,(short)0,(short)0,(short)67,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPessoaEndereco_Internalname,(String)A3PessoaEndereco,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPessoaEndereco_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)500,(short)0,(short)0,(short)67,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((edtPessoaTelefone_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPessoaTelefone_Internalname,(String)A4PessoaTelefone,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPessoaTelefone_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(int)edtPessoaTelefone_Visible,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)11,(short)0,(short)0,(short)67,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((edtPessoaEmail_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPessoaEmail_Internalname,(String)A5PessoaEmail,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPessoaEmail_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(int)edtPessoaEmail_Visible,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)67,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            if ( ( cmbPessoaSexo.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "PESSOASEXO_" + sGXsfl_67_idx;
               cmbPessoaSexo.Name = GXCCtl;
               cmbPessoaSexo.WebTags = "";
               cmbPessoaSexo.addItem("M", "Masculino", 0);
               cmbPessoaSexo.addItem("F", "Feminino", 0);
               cmbPessoaSexo.addItem("O", "Outros", 0);
               if ( cmbPessoaSexo.ItemCount > 0 )
               {
                  A6PessoaSexo = cmbPessoaSexo.getValidValue(A6PessoaSexo);
               }
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbPessoaSexo,(String)cmbPessoaSexo_Internalname,StringUtil.RTrim( A6PessoaSexo),(short)1,(String)cmbPessoaSexo_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"char",(String)"",(short)0,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn hidden-xs",(String)"",(String)"",(String)"",(bool)true});
            cmbPessoaSexo.CurrentValue = StringUtil.RTrim( A6PessoaSexo);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPessoaSexo_Internalname, "Values", (String)(cmbPessoaSexo.ToJavascriptSource()), !bGXsfl_67_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((chkPessoaSituacao.Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Check box */
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GridRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkPessoaSituacao_Internalname,StringUtil.BoolToStr( A7PessoaSituacao),(String)"",(String)"",chkPessoaSituacao.Visible,(short)0,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn hidden-xs",(String)"",(String)""});
            send_integrity_lvl_hashes0M2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_67_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_67_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_67_idx+1));
            sGXsfl_67_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_67_idx), 4, 0)), 4, "0");
            SubsflControlProps_672( ) ;
         }
         /* End function sendrow_672 */
      }

      protected void init_web_controls( )
      {
         cmbavPessoanomeoperator.Name = "vPESSOANOMEOPERATOR";
         cmbavPessoanomeoperator.WebTags = "";
         cmbavPessoanomeoperator.addItem("0", "Contém", 0);
         if ( cmbavPessoanomeoperator.ItemCount > 0 )
         {
            AV74PessoaNomeOperator = (short)(NumberUtil.Val( cmbavPessoanomeoperator.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV74PessoaNomeOperator), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV74PessoaNomeOperator", StringUtil.LTrim( StringUtil.Str( (decimal)(AV74PessoaNomeOperator), 4, 0)));
         }
         cmbavPessoaemailoperator.Name = "vPESSOAEMAILOPERATOR";
         cmbavPessoaemailoperator.WebTags = "";
         cmbavPessoaemailoperator.addItem("0", "Começa com", 0);
         cmbavPessoaemailoperator.addItem("1", "Contém", 0);
         if ( cmbavPessoaemailoperator.ItemCount > 0 )
         {
            AV76PessoaEmailOperator = (short)(NumberUtil.Val( cmbavPessoaemailoperator.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV76PessoaEmailOperator), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV76PessoaEmailOperator", StringUtil.LTrim( StringUtil.Str( (decimal)(AV76PessoaEmailOperator), 4, 0)));
         }
         GXCCtl = "PESSOASEXO_" + sGXsfl_67_idx;
         cmbPessoaSexo.Name = GXCCtl;
         cmbPessoaSexo.WebTags = "";
         cmbPessoaSexo.addItem("M", "Masculino", 0);
         cmbPessoaSexo.addItem("F", "Feminino", 0);
         cmbPessoaSexo.addItem("O", "Outros", 0);
         if ( cmbPessoaSexo.ItemCount > 0 )
         {
            A6PessoaSexo = cmbPessoaSexo.getValidValue(A6PessoaSexo);
         }
         GXCCtl = "PESSOASITUACAO_" + sGXsfl_67_idx;
         chkPessoaSituacao.Name = GXCCtl;
         chkPessoaSituacao.WebTags = "";
         chkPessoaSituacao.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkPessoaSituacao_Internalname, "TitleCaption", chkPessoaSituacao.Caption, !bGXsfl_67_Refreshing);
         chkPessoaSituacao.CheckedValue = "false";
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
         lblFiltertextpessoaemail_Internalname = "FILTERTEXTPESSOAEMAIL";
         cmbavPessoaemailoperator_Internalname = "vPESSOAEMAILOPERATOR";
         edtavPessoaemail_Internalname = "vPESSOAEMAIL";
         tblTablemergedpessoaemail_Internalname = "TABLEMERGEDPESSOAEMAIL";
         divTablesplittedfiltertextpessoaemail_Internalname = "TABLESPLITTEDFILTERTEXTPESSOAEMAIL";
         tblTablefilters_Internalname = "TABLEFILTERS";
         tblTablerightheader_Internalname = "TABLERIGHTHEADER";
         divTableheader_Internalname = "TABLEHEADER";
         Dvpanel_tableheader_Internalname = "DVPANEL_TABLEHEADER";
         edtavUpdate_Internalname = "vUPDATE";
         edtavDelete_Internalname = "vDELETE";
         edtPessoaId_Internalname = "PESSOAID";
         edtPessoaNome_Internalname = "PESSOANOME";
         edtPessoaEndereco_Internalname = "PESSOAENDERECO";
         edtPessoaTelefone_Internalname = "PESSOATELEFONE";
         edtPessoaEmail_Internalname = "PESSOAEMAIL";
         cmbPessoaSexo_Internalname = "PESSOASEXO";
         chkPessoaSituacao_Internalname = "PESSOASITUACAO";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_pessoaid_Internalname = "DDO_PESSOAID";
         edtavDdo_pessoaidtitlecontrolidtoreplace_Internalname = "vDDO_PESSOAIDTITLECONTROLIDTOREPLACE";
         Ddo_pessoanome_Internalname = "DDO_PESSOANOME";
         edtavDdo_pessoanometitlecontrolidtoreplace_Internalname = "vDDO_PESSOANOMETITLECONTROLIDTOREPLACE";
         Ddo_pessoatelefone_Internalname = "DDO_PESSOATELEFONE";
         edtavDdo_pessoatelefonetitlecontrolidtoreplace_Internalname = "vDDO_PESSOATELEFONETITLECONTROLIDTOREPLACE";
         Ddo_pessoaemail_Internalname = "DDO_PESSOAEMAIL";
         edtavDdo_pessoaemailtitlecontrolidtoreplace_Internalname = "vDDO_PESSOAEMAILTITLECONTROLIDTOREPLACE";
         Ddo_pessoasituacao_Internalname = "DDO_PESSOASITUACAO";
         edtavDdo_pessoasituacaotitlecontrolidtoreplace_Internalname = "vDDO_PESSOASITUACAOTITLECONTROLIDTOREPLACE";
         Workwithplusutilities1_Internalname = "WORKWITHPLUSUTILITIES1";
         Ddo_gridcolumnsselector_Internalname = "DDO_GRIDCOLUMNSSELECTOR";
         edtavOrderedby_Internalname = "vORDEREDBY";
         edtavOrdereddsc_Internalname = "vORDEREDDSC";
         edtavManagefiltersexecutionstep_Internalname = "vMANAGEFILTERSEXECUTIONSTEP";
         edtavTfpessoaid_Internalname = "vTFPESSOAID";
         edtavTfpessoaid_to_Internalname = "vTFPESSOAID_TO";
         edtavTfpessoanome_Internalname = "vTFPESSOANOME";
         edtavTfpessoanome_sel_Internalname = "vTFPESSOANOME_SEL";
         edtavTfpessoatelefone_Internalname = "vTFPESSOATELEFONE";
         edtavTfpessoatelefone_sel_Internalname = "vTFPESSOATELEFONE_SEL";
         edtavTfpessoaemail_Internalname = "vTFPESSOAEMAIL";
         edtavTfpessoaemail_sel_Internalname = "vTFPESSOAEMAIL_SEL";
         edtavTfpessoasituacao_sel_Internalname = "vTFPESSOASITUACAO_SEL";
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
         chkPessoaSituacao.Caption = "";
         cmbPessoaSexo_Jsonclick = "";
         edtPessoaEmail_Jsonclick = "";
         edtPessoaTelefone_Jsonclick = "";
         edtPessoaEndereco_Jsonclick = "";
         edtPessoaNome_Jsonclick = "";
         edtPessoaId_Jsonclick = "";
         edtavDelete_Jsonclick = "";
         edtavUpdate_Jsonclick = "";
         edtavPessoanome_Jsonclick = "";
         edtavPessoanome_Enabled = 1;
         cmbavPessoanomeoperator_Jsonclick = "";
         cmbavPessoanomeoperator.Enabled = 1;
         edtavPessoaemail_Jsonclick = "";
         edtavPessoaemail_Enabled = 1;
         cmbavPessoaemailoperator_Jsonclick = "";
         cmbavPessoaemailoperator.Enabled = 1;
         edtavTfpessoasituacao_sel_Jsonclick = "";
         edtavTfpessoasituacao_sel_Visible = 1;
         edtavTfpessoaemail_sel_Jsonclick = "";
         edtavTfpessoaemail_sel_Visible = 1;
         edtavTfpessoaemail_Jsonclick = "";
         edtavTfpessoaemail_Visible = 1;
         edtavTfpessoatelefone_sel_Jsonclick = "";
         edtavTfpessoatelefone_sel_Visible = 1;
         edtavTfpessoatelefone_Jsonclick = "";
         edtavTfpessoatelefone_Visible = 1;
         edtavTfpessoanome_sel_Jsonclick = "";
         edtavTfpessoanome_sel_Visible = 1;
         edtavTfpessoanome_Jsonclick = "";
         edtavTfpessoanome_Visible = 1;
         edtavTfpessoaid_to_Jsonclick = "";
         edtavTfpessoaid_to_Visible = 1;
         edtavTfpessoaid_Jsonclick = "";
         edtavTfpessoaid_Visible = 1;
         edtavManagefiltersexecutionstep_Jsonclick = "";
         edtavManagefiltersexecutionstep_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_pessoasituacaotitlecontrolidtoreplace_Visible = 1;
         edtavDdo_pessoaemailtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_pessoatelefonetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_pessoanometitlecontrolidtoreplace_Visible = 1;
         edtavDdo_pessoaidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavDelete_Link = "";
         edtavUpdate_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         chkPessoaSituacao_Titleformat = 0;
         chkPessoaSituacao.Title.Text = "Situação";
         chkPessoaSituacao.Visible = -1;
         edtPessoaEmail_Titleformat = 0;
         edtPessoaEmail_Title = "E-mail";
         edtPessoaEmail_Visible = -1;
         edtPessoaTelefone_Titleformat = 0;
         edtPessoaTelefone_Title = "Telefone";
         edtPessoaTelefone_Visible = -1;
         edtPessoaNome_Titleformat = 0;
         edtPessoaNome_Title = "Nome";
         edtPessoaNome_Visible = -1;
         edtPessoaId_Titleformat = 0;
         edtPessoaId_Title = "Id";
         edtPessoaId_Visible = -1;
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
         Ddo_pessoasituacao_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_pessoasituacao_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_pessoasituacao_Sortdsc = "WWP_TSSortDSC";
         Ddo_pessoasituacao_Sortasc = "WWP_TSSortASC";
         Ddo_pessoasituacao_Datalistfixedvalues = "1:WWP_TSChecked,2:WWP_TSUnChecked";
         Ddo_pessoasituacao_Datalisttype = "FixedValues";
         Ddo_pessoasituacao_Includedatalist = Convert.ToBoolean( -1);
         Ddo_pessoasituacao_Includefilter = Convert.ToBoolean( 0);
         Ddo_pessoasituacao_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_pessoasituacao_Includesortasc = Convert.ToBoolean( -1);
         Ddo_pessoasituacao_Titlecontrolidtoreplace = "";
         Ddo_pessoasituacao_Dropdownoptionstype = "GridTitleSettings";
         Ddo_pessoasituacao_Cls = "ColumnSettings";
         Ddo_pessoasituacao_Tooltip = "WWP_TSColumnOptions";
         Ddo_pessoasituacao_Caption = "";
         Ddo_pessoaemail_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_pessoaemail_Noresultsfound = "WWP_TSNoResults";
         Ddo_pessoaemail_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_pessoaemail_Loadingdata = "WWP_TSLoading";
         Ddo_pessoaemail_Sortdsc = "WWP_TSSortDSC";
         Ddo_pessoaemail_Sortasc = "WWP_TSSortASC";
         Ddo_pessoaemail_Datalistupdateminimumcharacters = 0;
         Ddo_pessoaemail_Datalistproc = "PessoaWWGetFilterData";
         Ddo_pessoaemail_Datalisttype = "Dynamic";
         Ddo_pessoaemail_Includedatalist = Convert.ToBoolean( -1);
         Ddo_pessoaemail_Filterisrange = Convert.ToBoolean( 0);
         Ddo_pessoaemail_Filtertype = "Character";
         Ddo_pessoaemail_Includefilter = Convert.ToBoolean( -1);
         Ddo_pessoaemail_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_pessoaemail_Includesortasc = Convert.ToBoolean( -1);
         Ddo_pessoaemail_Titlecontrolidtoreplace = "";
         Ddo_pessoaemail_Dropdownoptionstype = "GridTitleSettings";
         Ddo_pessoaemail_Cls = "ColumnSettings";
         Ddo_pessoaemail_Tooltip = "WWP_TSColumnOptions";
         Ddo_pessoaemail_Caption = "";
         Ddo_pessoatelefone_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_pessoatelefone_Noresultsfound = "WWP_TSNoResults";
         Ddo_pessoatelefone_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_pessoatelefone_Loadingdata = "WWP_TSLoading";
         Ddo_pessoatelefone_Sortdsc = "WWP_TSSortDSC";
         Ddo_pessoatelefone_Sortasc = "WWP_TSSortASC";
         Ddo_pessoatelefone_Datalistupdateminimumcharacters = 0;
         Ddo_pessoatelefone_Datalistproc = "PessoaWWGetFilterData";
         Ddo_pessoatelefone_Datalisttype = "Dynamic";
         Ddo_pessoatelefone_Includedatalist = Convert.ToBoolean( -1);
         Ddo_pessoatelefone_Filterisrange = Convert.ToBoolean( 0);
         Ddo_pessoatelefone_Filtertype = "Character";
         Ddo_pessoatelefone_Includefilter = Convert.ToBoolean( -1);
         Ddo_pessoatelefone_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_pessoatelefone_Includesortasc = Convert.ToBoolean( -1);
         Ddo_pessoatelefone_Titlecontrolidtoreplace = "";
         Ddo_pessoatelefone_Dropdownoptionstype = "GridTitleSettings";
         Ddo_pessoatelefone_Cls = "ColumnSettings";
         Ddo_pessoatelefone_Tooltip = "WWP_TSColumnOptions";
         Ddo_pessoatelefone_Caption = "";
         Ddo_pessoanome_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_pessoanome_Noresultsfound = "WWP_TSNoResults";
         Ddo_pessoanome_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_pessoanome_Loadingdata = "WWP_TSLoading";
         Ddo_pessoanome_Sortdsc = "WWP_TSSortDSC";
         Ddo_pessoanome_Sortasc = "WWP_TSSortASC";
         Ddo_pessoanome_Datalistupdateminimumcharacters = 0;
         Ddo_pessoanome_Datalistproc = "PessoaWWGetFilterData";
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
         Form.Caption = " Pessoa";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV35ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV27ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV44ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_PessoaTelefoneTitleControlIdToReplace',fld:'vDDO_PESSOATELEFONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_PessoaEmailTitleControlIdToReplace',fld:'vDDO_PESSOAEMAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_PessoaSituacaoTitleControlIdToReplace',fld:'vDDO_PESSOASITUACAOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV75PessoaNome',fld:'vPESSOANOME',pic:''},{av:'AV77PessoaEmail',fld:'vPESSOAEMAIL',pic:''},{av:'AV42TFPessoaId',fld:'vTFPESSOAID',pic:'ZZZ9'},{av:'AV43TFPessoaId_To',fld:'vTFPESSOAID_TO',pic:'ZZZ9'},{av:'AV46TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV47TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV54TFPessoaTelefone',fld:'vTFPESSOATELEFONE',pic:''},{av:'AV55TFPessoaTelefone_Sel',fld:'vTFPESSOATELEFONE_SEL',pic:''},{av:'AV58TFPessoaEmail',fld:'vTFPESSOAEMAIL',pic:''},{av:'AV59TFPessoaEmail_Sel',fld:'vTFPESSOAEMAIL_SEL',pic:''},{av:'AV66TFPessoaSituacao_Sel',fld:'vTFPESSOASITUACAO_SEL',pic:'9'},{av:'AV92Pgmname',fld:'vPGMNAME',pic:''},{av:'AV12OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV13OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'cmbavPessoanomeoperator'},{av:'AV74PessoaNomeOperator',fld:'vPESSOANOMEOPERATOR',pic:'ZZZ9'},{av:'cmbavPessoaemailoperator'},{av:'AV76PessoaEmailOperator',fld:'vPESSOAEMAILOPERATOR',pic:'ZZZ9'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV41PessoaIdTitleFilterData',fld:'vPESSOAIDTITLEFILTERDATA',pic:''},{av:'AV45PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV53PessoaTelefoneTitleFilterData',fld:'vPESSOATELEFONETITLEFILTERDATA',pic:''},{av:'AV57PessoaEmailTitleFilterData',fld:'vPESSOAEMAILTITLEFILTERDATA',pic:''},{av:'AV65PessoaSituacaoTitleFilterData',fld:'vPESSOASITUACAOTITLEFILTERDATA',pic:''},{av:'AV35ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV27ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtPessoaId_Visible',ctrl:'PESSOAID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPessoaTelefone_Visible',ctrl:'PESSOATELEFONE',prop:'Visible'},{av:'edtPessoaEmail_Visible',ctrl:'PESSOAEMAIL',prop:'Visible'},{av:'chkPessoaSituacao.Visible',ctrl:'PESSOASITUACAO',prop:'Visible'},{av:'edtPessoaId_Titleformat',ctrl:'PESSOAID',prop:'Titleformat'},{av:'edtPessoaId_Title',ctrl:'PESSOAID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPessoaTelefone_Titleformat',ctrl:'PESSOATELEFONE',prop:'Titleformat'},{av:'edtPessoaTelefone_Title',ctrl:'PESSOATELEFONE',prop:'Title'},{av:'edtPessoaEmail_Titleformat',ctrl:'PESSOAEMAIL',prop:'Titleformat'},{av:'edtPessoaEmail_Title',ctrl:'PESSOAEMAIL',prop:'Title'},{av:'chkPessoaSituacao_Titleformat',ctrl:'PESSOASITUACAO',prop:'Titleformat'},{av:'chkPessoaSituacao.Title.Text',ctrl:'PESSOASITUACAO',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E120M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavPessoanomeoperator'},{av:'AV74PessoaNomeOperator',fld:'vPESSOANOMEOPERATOR',pic:'ZZZ9'},{av:'AV75PessoaNome',fld:'vPESSOANOME',pic:''},{av:'cmbavPessoaemailoperator'},{av:'AV76PessoaEmailOperator',fld:'vPESSOAEMAILOPERATOR',pic:'ZZZ9'},{av:'AV77PessoaEmail',fld:'vPESSOAEMAIL',pic:''},{av:'AV12OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV13OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV42TFPessoaId',fld:'vTFPESSOAID',pic:'ZZZ9'},{av:'AV43TFPessoaId_To',fld:'vTFPESSOAID_TO',pic:'ZZZ9'},{av:'AV46TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV47TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV54TFPessoaTelefone',fld:'vTFPESSOATELEFONE',pic:''},{av:'AV55TFPessoaTelefone_Sel',fld:'vTFPESSOATELEFONE_SEL',pic:''},{av:'AV58TFPessoaEmail',fld:'vTFPESSOAEMAIL',pic:''},{av:'AV59TFPessoaEmail_Sel',fld:'vTFPESSOAEMAIL_SEL',pic:''},{av:'AV66TFPessoaSituacao_Sel',fld:'vTFPESSOASITUACAO_SEL',pic:'9'},{av:'AV35ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV27ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV44ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_PessoaTelefoneTitleControlIdToReplace',fld:'vDDO_PESSOATELEFONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_PessoaEmailTitleControlIdToReplace',fld:'vDDO_PESSOAEMAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_PessoaSituacaoTitleControlIdToReplace',fld:'vDDO_PESSOASITUACAOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV92Pgmname',fld:'vPGMNAME',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E130M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavPessoanomeoperator'},{av:'AV74PessoaNomeOperator',fld:'vPESSOANOMEOPERATOR',pic:'ZZZ9'},{av:'AV75PessoaNome',fld:'vPESSOANOME',pic:''},{av:'cmbavPessoaemailoperator'},{av:'AV76PessoaEmailOperator',fld:'vPESSOAEMAILOPERATOR',pic:'ZZZ9'},{av:'AV77PessoaEmail',fld:'vPESSOAEMAIL',pic:''},{av:'AV12OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV13OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV42TFPessoaId',fld:'vTFPESSOAID',pic:'ZZZ9'},{av:'AV43TFPessoaId_To',fld:'vTFPESSOAID_TO',pic:'ZZZ9'},{av:'AV46TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV47TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV54TFPessoaTelefone',fld:'vTFPESSOATELEFONE',pic:''},{av:'AV55TFPessoaTelefone_Sel',fld:'vTFPESSOATELEFONE_SEL',pic:''},{av:'AV58TFPessoaEmail',fld:'vTFPESSOAEMAIL',pic:''},{av:'AV59TFPessoaEmail_Sel',fld:'vTFPESSOAEMAIL_SEL',pic:''},{av:'AV66TFPessoaSituacao_Sel',fld:'vTFPESSOASITUACAO_SEL',pic:'9'},{av:'AV35ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV27ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV44ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_PessoaTelefoneTitleControlIdToReplace',fld:'vDDO_PESSOATELEFONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_PessoaEmailTitleControlIdToReplace',fld:'vDDO_PESSOAEMAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_PessoaSituacaoTitleControlIdToReplace',fld:'vDDO_PESSOASITUACAOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV92Pgmname',fld:'vPGMNAME',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_PESSOAID.ONOPTIONCLICKED","{handler:'E140M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavPessoanomeoperator'},{av:'AV74PessoaNomeOperator',fld:'vPESSOANOMEOPERATOR',pic:'ZZZ9'},{av:'AV75PessoaNome',fld:'vPESSOANOME',pic:''},{av:'cmbavPessoaemailoperator'},{av:'AV76PessoaEmailOperator',fld:'vPESSOAEMAILOPERATOR',pic:'ZZZ9'},{av:'AV77PessoaEmail',fld:'vPESSOAEMAIL',pic:''},{av:'AV12OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV13OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV42TFPessoaId',fld:'vTFPESSOAID',pic:'ZZZ9'},{av:'AV43TFPessoaId_To',fld:'vTFPESSOAID_TO',pic:'ZZZ9'},{av:'AV46TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV47TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV54TFPessoaTelefone',fld:'vTFPESSOATELEFONE',pic:''},{av:'AV55TFPessoaTelefone_Sel',fld:'vTFPESSOATELEFONE_SEL',pic:''},{av:'AV58TFPessoaEmail',fld:'vTFPESSOAEMAIL',pic:''},{av:'AV59TFPessoaEmail_Sel',fld:'vTFPESSOAEMAIL_SEL',pic:''},{av:'AV66TFPessoaSituacao_Sel',fld:'vTFPESSOASITUACAO_SEL',pic:'9'},{av:'AV35ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV27ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV44ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_PessoaTelefoneTitleControlIdToReplace',fld:'vDDO_PESSOATELEFONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_PessoaEmailTitleControlIdToReplace',fld:'vDDO_PESSOAEMAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_PessoaSituacaoTitleControlIdToReplace',fld:'vDDO_PESSOASITUACAOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV92Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_pessoaid_Activeeventkey',ctrl:'DDO_PESSOAID',prop:'ActiveEventKey'},{av:'Ddo_pessoaid_Filteredtext_get',ctrl:'DDO_PESSOAID',prop:'FilteredText_get'},{av:'Ddo_pessoaid_Filteredtextto_get',ctrl:'DDO_PESSOAID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_PESSOAID.ONOPTIONCLICKED",",oparms:[{av:'AV12OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV13OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_pessoaid_Sortedstatus',ctrl:'DDO_PESSOAID',prop:'SortedStatus'},{av:'AV42TFPessoaId',fld:'vTFPESSOAID',pic:'ZZZ9'},{av:'AV43TFPessoaId_To',fld:'vTFPESSOAID_TO',pic:'ZZZ9'},{av:'Ddo_pessoanome_Sortedstatus',ctrl:'DDO_PESSOANOME',prop:'SortedStatus'},{av:'Ddo_pessoatelefone_Sortedstatus',ctrl:'DDO_PESSOATELEFONE',prop:'SortedStatus'},{av:'Ddo_pessoaemail_Sortedstatus',ctrl:'DDO_PESSOAEMAIL',prop:'SortedStatus'},{av:'Ddo_pessoasituacao_Sortedstatus',ctrl:'DDO_PESSOASITUACAO',prop:'SortedStatus'},{av:'AV41PessoaIdTitleFilterData',fld:'vPESSOAIDTITLEFILTERDATA',pic:''},{av:'AV45PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV53PessoaTelefoneTitleFilterData',fld:'vPESSOATELEFONETITLEFILTERDATA',pic:''},{av:'AV57PessoaEmailTitleFilterData',fld:'vPESSOAEMAILTITLEFILTERDATA',pic:''},{av:'AV65PessoaSituacaoTitleFilterData',fld:'vPESSOASITUACAOTITLEFILTERDATA',pic:''},{av:'AV35ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV27ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtPessoaId_Visible',ctrl:'PESSOAID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPessoaTelefone_Visible',ctrl:'PESSOATELEFONE',prop:'Visible'},{av:'edtPessoaEmail_Visible',ctrl:'PESSOAEMAIL',prop:'Visible'},{av:'chkPessoaSituacao.Visible',ctrl:'PESSOASITUACAO',prop:'Visible'},{av:'edtPessoaId_Titleformat',ctrl:'PESSOAID',prop:'Titleformat'},{av:'edtPessoaId_Title',ctrl:'PESSOAID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPessoaTelefone_Titleformat',ctrl:'PESSOATELEFONE',prop:'Titleformat'},{av:'edtPessoaTelefone_Title',ctrl:'PESSOATELEFONE',prop:'Title'},{av:'edtPessoaEmail_Titleformat',ctrl:'PESSOAEMAIL',prop:'Titleformat'},{av:'edtPessoaEmail_Title',ctrl:'PESSOAEMAIL',prop:'Title'},{av:'chkPessoaSituacao_Titleformat',ctrl:'PESSOASITUACAO',prop:'Titleformat'},{av:'chkPessoaSituacao.Title.Text',ctrl:'PESSOASITUACAO',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("DDO_PESSOANOME.ONOPTIONCLICKED","{handler:'E150M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavPessoanomeoperator'},{av:'AV74PessoaNomeOperator',fld:'vPESSOANOMEOPERATOR',pic:'ZZZ9'},{av:'AV75PessoaNome',fld:'vPESSOANOME',pic:''},{av:'cmbavPessoaemailoperator'},{av:'AV76PessoaEmailOperator',fld:'vPESSOAEMAILOPERATOR',pic:'ZZZ9'},{av:'AV77PessoaEmail',fld:'vPESSOAEMAIL',pic:''},{av:'AV12OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV13OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV42TFPessoaId',fld:'vTFPESSOAID',pic:'ZZZ9'},{av:'AV43TFPessoaId_To',fld:'vTFPESSOAID_TO',pic:'ZZZ9'},{av:'AV46TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV47TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV54TFPessoaTelefone',fld:'vTFPESSOATELEFONE',pic:''},{av:'AV55TFPessoaTelefone_Sel',fld:'vTFPESSOATELEFONE_SEL',pic:''},{av:'AV58TFPessoaEmail',fld:'vTFPESSOAEMAIL',pic:''},{av:'AV59TFPessoaEmail_Sel',fld:'vTFPESSOAEMAIL_SEL',pic:''},{av:'AV66TFPessoaSituacao_Sel',fld:'vTFPESSOASITUACAO_SEL',pic:'9'},{av:'AV35ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV27ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV44ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_PessoaTelefoneTitleControlIdToReplace',fld:'vDDO_PESSOATELEFONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_PessoaEmailTitleControlIdToReplace',fld:'vDDO_PESSOAEMAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_PessoaSituacaoTitleControlIdToReplace',fld:'vDDO_PESSOASITUACAOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV92Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_pessoanome_Activeeventkey',ctrl:'DDO_PESSOANOME',prop:'ActiveEventKey'},{av:'Ddo_pessoanome_Filteredtext_get',ctrl:'DDO_PESSOANOME',prop:'FilteredText_get'},{av:'Ddo_pessoanome_Selectedvalue_get',ctrl:'DDO_PESSOANOME',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_PESSOANOME.ONOPTIONCLICKED",",oparms:[{av:'AV12OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV13OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_pessoanome_Sortedstatus',ctrl:'DDO_PESSOANOME',prop:'SortedStatus'},{av:'AV46TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV47TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'Ddo_pessoaid_Sortedstatus',ctrl:'DDO_PESSOAID',prop:'SortedStatus'},{av:'Ddo_pessoatelefone_Sortedstatus',ctrl:'DDO_PESSOATELEFONE',prop:'SortedStatus'},{av:'Ddo_pessoaemail_Sortedstatus',ctrl:'DDO_PESSOAEMAIL',prop:'SortedStatus'},{av:'Ddo_pessoasituacao_Sortedstatus',ctrl:'DDO_PESSOASITUACAO',prop:'SortedStatus'},{av:'AV41PessoaIdTitleFilterData',fld:'vPESSOAIDTITLEFILTERDATA',pic:''},{av:'AV45PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV53PessoaTelefoneTitleFilterData',fld:'vPESSOATELEFONETITLEFILTERDATA',pic:''},{av:'AV57PessoaEmailTitleFilterData',fld:'vPESSOAEMAILTITLEFILTERDATA',pic:''},{av:'AV65PessoaSituacaoTitleFilterData',fld:'vPESSOASITUACAOTITLEFILTERDATA',pic:''},{av:'AV35ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV27ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtPessoaId_Visible',ctrl:'PESSOAID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPessoaTelefone_Visible',ctrl:'PESSOATELEFONE',prop:'Visible'},{av:'edtPessoaEmail_Visible',ctrl:'PESSOAEMAIL',prop:'Visible'},{av:'chkPessoaSituacao.Visible',ctrl:'PESSOASITUACAO',prop:'Visible'},{av:'edtPessoaId_Titleformat',ctrl:'PESSOAID',prop:'Titleformat'},{av:'edtPessoaId_Title',ctrl:'PESSOAID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPessoaTelefone_Titleformat',ctrl:'PESSOATELEFONE',prop:'Titleformat'},{av:'edtPessoaTelefone_Title',ctrl:'PESSOATELEFONE',prop:'Title'},{av:'edtPessoaEmail_Titleformat',ctrl:'PESSOAEMAIL',prop:'Titleformat'},{av:'edtPessoaEmail_Title',ctrl:'PESSOAEMAIL',prop:'Title'},{av:'chkPessoaSituacao_Titleformat',ctrl:'PESSOASITUACAO',prop:'Titleformat'},{av:'chkPessoaSituacao.Title.Text',ctrl:'PESSOASITUACAO',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("DDO_PESSOATELEFONE.ONOPTIONCLICKED","{handler:'E160M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavPessoanomeoperator'},{av:'AV74PessoaNomeOperator',fld:'vPESSOANOMEOPERATOR',pic:'ZZZ9'},{av:'AV75PessoaNome',fld:'vPESSOANOME',pic:''},{av:'cmbavPessoaemailoperator'},{av:'AV76PessoaEmailOperator',fld:'vPESSOAEMAILOPERATOR',pic:'ZZZ9'},{av:'AV77PessoaEmail',fld:'vPESSOAEMAIL',pic:''},{av:'AV12OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV13OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV42TFPessoaId',fld:'vTFPESSOAID',pic:'ZZZ9'},{av:'AV43TFPessoaId_To',fld:'vTFPESSOAID_TO',pic:'ZZZ9'},{av:'AV46TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV47TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV54TFPessoaTelefone',fld:'vTFPESSOATELEFONE',pic:''},{av:'AV55TFPessoaTelefone_Sel',fld:'vTFPESSOATELEFONE_SEL',pic:''},{av:'AV58TFPessoaEmail',fld:'vTFPESSOAEMAIL',pic:''},{av:'AV59TFPessoaEmail_Sel',fld:'vTFPESSOAEMAIL_SEL',pic:''},{av:'AV66TFPessoaSituacao_Sel',fld:'vTFPESSOASITUACAO_SEL',pic:'9'},{av:'AV35ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV27ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV44ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_PessoaTelefoneTitleControlIdToReplace',fld:'vDDO_PESSOATELEFONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_PessoaEmailTitleControlIdToReplace',fld:'vDDO_PESSOAEMAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_PessoaSituacaoTitleControlIdToReplace',fld:'vDDO_PESSOASITUACAOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV92Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_pessoatelefone_Activeeventkey',ctrl:'DDO_PESSOATELEFONE',prop:'ActiveEventKey'},{av:'Ddo_pessoatelefone_Filteredtext_get',ctrl:'DDO_PESSOATELEFONE',prop:'FilteredText_get'},{av:'Ddo_pessoatelefone_Selectedvalue_get',ctrl:'DDO_PESSOATELEFONE',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_PESSOATELEFONE.ONOPTIONCLICKED",",oparms:[{av:'AV12OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV13OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_pessoatelefone_Sortedstatus',ctrl:'DDO_PESSOATELEFONE',prop:'SortedStatus'},{av:'AV54TFPessoaTelefone',fld:'vTFPESSOATELEFONE',pic:''},{av:'AV55TFPessoaTelefone_Sel',fld:'vTFPESSOATELEFONE_SEL',pic:''},{av:'Ddo_pessoaid_Sortedstatus',ctrl:'DDO_PESSOAID',prop:'SortedStatus'},{av:'Ddo_pessoanome_Sortedstatus',ctrl:'DDO_PESSOANOME',prop:'SortedStatus'},{av:'Ddo_pessoaemail_Sortedstatus',ctrl:'DDO_PESSOAEMAIL',prop:'SortedStatus'},{av:'Ddo_pessoasituacao_Sortedstatus',ctrl:'DDO_PESSOASITUACAO',prop:'SortedStatus'},{av:'AV41PessoaIdTitleFilterData',fld:'vPESSOAIDTITLEFILTERDATA',pic:''},{av:'AV45PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV53PessoaTelefoneTitleFilterData',fld:'vPESSOATELEFONETITLEFILTERDATA',pic:''},{av:'AV57PessoaEmailTitleFilterData',fld:'vPESSOAEMAILTITLEFILTERDATA',pic:''},{av:'AV65PessoaSituacaoTitleFilterData',fld:'vPESSOASITUACAOTITLEFILTERDATA',pic:''},{av:'AV35ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV27ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtPessoaId_Visible',ctrl:'PESSOAID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPessoaTelefone_Visible',ctrl:'PESSOATELEFONE',prop:'Visible'},{av:'edtPessoaEmail_Visible',ctrl:'PESSOAEMAIL',prop:'Visible'},{av:'chkPessoaSituacao.Visible',ctrl:'PESSOASITUACAO',prop:'Visible'},{av:'edtPessoaId_Titleformat',ctrl:'PESSOAID',prop:'Titleformat'},{av:'edtPessoaId_Title',ctrl:'PESSOAID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPessoaTelefone_Titleformat',ctrl:'PESSOATELEFONE',prop:'Titleformat'},{av:'edtPessoaTelefone_Title',ctrl:'PESSOATELEFONE',prop:'Title'},{av:'edtPessoaEmail_Titleformat',ctrl:'PESSOAEMAIL',prop:'Titleformat'},{av:'edtPessoaEmail_Title',ctrl:'PESSOAEMAIL',prop:'Title'},{av:'chkPessoaSituacao_Titleformat',ctrl:'PESSOASITUACAO',prop:'Titleformat'},{av:'chkPessoaSituacao.Title.Text',ctrl:'PESSOASITUACAO',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("DDO_PESSOAEMAIL.ONOPTIONCLICKED","{handler:'E170M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavPessoanomeoperator'},{av:'AV74PessoaNomeOperator',fld:'vPESSOANOMEOPERATOR',pic:'ZZZ9'},{av:'AV75PessoaNome',fld:'vPESSOANOME',pic:''},{av:'cmbavPessoaemailoperator'},{av:'AV76PessoaEmailOperator',fld:'vPESSOAEMAILOPERATOR',pic:'ZZZ9'},{av:'AV77PessoaEmail',fld:'vPESSOAEMAIL',pic:''},{av:'AV12OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV13OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV42TFPessoaId',fld:'vTFPESSOAID',pic:'ZZZ9'},{av:'AV43TFPessoaId_To',fld:'vTFPESSOAID_TO',pic:'ZZZ9'},{av:'AV46TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV47TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV54TFPessoaTelefone',fld:'vTFPESSOATELEFONE',pic:''},{av:'AV55TFPessoaTelefone_Sel',fld:'vTFPESSOATELEFONE_SEL',pic:''},{av:'AV58TFPessoaEmail',fld:'vTFPESSOAEMAIL',pic:''},{av:'AV59TFPessoaEmail_Sel',fld:'vTFPESSOAEMAIL_SEL',pic:''},{av:'AV66TFPessoaSituacao_Sel',fld:'vTFPESSOASITUACAO_SEL',pic:'9'},{av:'AV35ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV27ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV44ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_PessoaTelefoneTitleControlIdToReplace',fld:'vDDO_PESSOATELEFONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_PessoaEmailTitleControlIdToReplace',fld:'vDDO_PESSOAEMAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_PessoaSituacaoTitleControlIdToReplace',fld:'vDDO_PESSOASITUACAOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV92Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_pessoaemail_Activeeventkey',ctrl:'DDO_PESSOAEMAIL',prop:'ActiveEventKey'},{av:'Ddo_pessoaemail_Filteredtext_get',ctrl:'DDO_PESSOAEMAIL',prop:'FilteredText_get'},{av:'Ddo_pessoaemail_Selectedvalue_get',ctrl:'DDO_PESSOAEMAIL',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_PESSOAEMAIL.ONOPTIONCLICKED",",oparms:[{av:'AV12OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV13OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_pessoaemail_Sortedstatus',ctrl:'DDO_PESSOAEMAIL',prop:'SortedStatus'},{av:'AV58TFPessoaEmail',fld:'vTFPESSOAEMAIL',pic:''},{av:'AV59TFPessoaEmail_Sel',fld:'vTFPESSOAEMAIL_SEL',pic:''},{av:'Ddo_pessoaid_Sortedstatus',ctrl:'DDO_PESSOAID',prop:'SortedStatus'},{av:'Ddo_pessoanome_Sortedstatus',ctrl:'DDO_PESSOANOME',prop:'SortedStatus'},{av:'Ddo_pessoatelefone_Sortedstatus',ctrl:'DDO_PESSOATELEFONE',prop:'SortedStatus'},{av:'Ddo_pessoasituacao_Sortedstatus',ctrl:'DDO_PESSOASITUACAO',prop:'SortedStatus'},{av:'AV41PessoaIdTitleFilterData',fld:'vPESSOAIDTITLEFILTERDATA',pic:''},{av:'AV45PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV53PessoaTelefoneTitleFilterData',fld:'vPESSOATELEFONETITLEFILTERDATA',pic:''},{av:'AV57PessoaEmailTitleFilterData',fld:'vPESSOAEMAILTITLEFILTERDATA',pic:''},{av:'AV65PessoaSituacaoTitleFilterData',fld:'vPESSOASITUACAOTITLEFILTERDATA',pic:''},{av:'AV35ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV27ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtPessoaId_Visible',ctrl:'PESSOAID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPessoaTelefone_Visible',ctrl:'PESSOATELEFONE',prop:'Visible'},{av:'edtPessoaEmail_Visible',ctrl:'PESSOAEMAIL',prop:'Visible'},{av:'chkPessoaSituacao.Visible',ctrl:'PESSOASITUACAO',prop:'Visible'},{av:'edtPessoaId_Titleformat',ctrl:'PESSOAID',prop:'Titleformat'},{av:'edtPessoaId_Title',ctrl:'PESSOAID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPessoaTelefone_Titleformat',ctrl:'PESSOATELEFONE',prop:'Titleformat'},{av:'edtPessoaTelefone_Title',ctrl:'PESSOATELEFONE',prop:'Title'},{av:'edtPessoaEmail_Titleformat',ctrl:'PESSOAEMAIL',prop:'Titleformat'},{av:'edtPessoaEmail_Title',ctrl:'PESSOAEMAIL',prop:'Title'},{av:'chkPessoaSituacao_Titleformat',ctrl:'PESSOASITUACAO',prop:'Titleformat'},{av:'chkPessoaSituacao.Title.Text',ctrl:'PESSOASITUACAO',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("DDO_PESSOASITUACAO.ONOPTIONCLICKED","{handler:'E180M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavPessoanomeoperator'},{av:'AV74PessoaNomeOperator',fld:'vPESSOANOMEOPERATOR',pic:'ZZZ9'},{av:'AV75PessoaNome',fld:'vPESSOANOME',pic:''},{av:'cmbavPessoaemailoperator'},{av:'AV76PessoaEmailOperator',fld:'vPESSOAEMAILOPERATOR',pic:'ZZZ9'},{av:'AV77PessoaEmail',fld:'vPESSOAEMAIL',pic:''},{av:'AV12OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV13OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV42TFPessoaId',fld:'vTFPESSOAID',pic:'ZZZ9'},{av:'AV43TFPessoaId_To',fld:'vTFPESSOAID_TO',pic:'ZZZ9'},{av:'AV46TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV47TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV54TFPessoaTelefone',fld:'vTFPESSOATELEFONE',pic:''},{av:'AV55TFPessoaTelefone_Sel',fld:'vTFPESSOATELEFONE_SEL',pic:''},{av:'AV58TFPessoaEmail',fld:'vTFPESSOAEMAIL',pic:''},{av:'AV59TFPessoaEmail_Sel',fld:'vTFPESSOAEMAIL_SEL',pic:''},{av:'AV66TFPessoaSituacao_Sel',fld:'vTFPESSOASITUACAO_SEL',pic:'9'},{av:'AV35ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV27ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV44ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_PessoaTelefoneTitleControlIdToReplace',fld:'vDDO_PESSOATELEFONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_PessoaEmailTitleControlIdToReplace',fld:'vDDO_PESSOAEMAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_PessoaSituacaoTitleControlIdToReplace',fld:'vDDO_PESSOASITUACAOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV92Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_pessoasituacao_Activeeventkey',ctrl:'DDO_PESSOASITUACAO',prop:'ActiveEventKey'},{av:'Ddo_pessoasituacao_Selectedvalue_get',ctrl:'DDO_PESSOASITUACAO',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_PESSOASITUACAO.ONOPTIONCLICKED",",oparms:[{av:'AV12OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV13OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_pessoasituacao_Sortedstatus',ctrl:'DDO_PESSOASITUACAO',prop:'SortedStatus'},{av:'AV66TFPessoaSituacao_Sel',fld:'vTFPESSOASITUACAO_SEL',pic:'9'},{av:'Ddo_pessoaid_Sortedstatus',ctrl:'DDO_PESSOAID',prop:'SortedStatus'},{av:'Ddo_pessoanome_Sortedstatus',ctrl:'DDO_PESSOANOME',prop:'SortedStatus'},{av:'Ddo_pessoatelefone_Sortedstatus',ctrl:'DDO_PESSOATELEFONE',prop:'SortedStatus'},{av:'Ddo_pessoaemail_Sortedstatus',ctrl:'DDO_PESSOAEMAIL',prop:'SortedStatus'},{av:'AV41PessoaIdTitleFilterData',fld:'vPESSOAIDTITLEFILTERDATA',pic:''},{av:'AV45PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV53PessoaTelefoneTitleFilterData',fld:'vPESSOATELEFONETITLEFILTERDATA',pic:''},{av:'AV57PessoaEmailTitleFilterData',fld:'vPESSOAEMAILTITLEFILTERDATA',pic:''},{av:'AV65PessoaSituacaoTitleFilterData',fld:'vPESSOASITUACAOTITLEFILTERDATA',pic:''},{av:'AV35ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV27ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtPessoaId_Visible',ctrl:'PESSOAID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPessoaTelefone_Visible',ctrl:'PESSOATELEFONE',prop:'Visible'},{av:'edtPessoaEmail_Visible',ctrl:'PESSOAEMAIL',prop:'Visible'},{av:'chkPessoaSituacao.Visible',ctrl:'PESSOASITUACAO',prop:'Visible'},{av:'edtPessoaId_Titleformat',ctrl:'PESSOAID',prop:'Titleformat'},{av:'edtPessoaId_Title',ctrl:'PESSOAID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPessoaTelefone_Titleformat',ctrl:'PESSOATELEFONE',prop:'Titleformat'},{av:'edtPessoaTelefone_Title',ctrl:'PESSOATELEFONE',prop:'Title'},{av:'edtPessoaEmail_Titleformat',ctrl:'PESSOAEMAIL',prop:'Titleformat'},{av:'edtPessoaEmail_Title',ctrl:'PESSOAEMAIL',prop:'Title'},{av:'chkPessoaSituacao_Titleformat',ctrl:'PESSOASITUACAO',prop:'Titleformat'},{av:'chkPessoaSituacao.Title.Text',ctrl:'PESSOASITUACAO',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("GRID.LOAD","{handler:'E230M2',iparms:[{av:'A1PessoaId',fld:'PESSOAID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV72Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'AV73Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'}]}");
         setEventMetadata("DDO_GRIDCOLUMNSSELECTOR.ONCOLUMNSCHANGED","{handler:'E190M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavPessoanomeoperator'},{av:'AV74PessoaNomeOperator',fld:'vPESSOANOMEOPERATOR',pic:'ZZZ9'},{av:'AV75PessoaNome',fld:'vPESSOANOME',pic:''},{av:'cmbavPessoaemailoperator'},{av:'AV76PessoaEmailOperator',fld:'vPESSOAEMAILOPERATOR',pic:'ZZZ9'},{av:'AV77PessoaEmail',fld:'vPESSOAEMAIL',pic:''},{av:'AV12OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV13OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV42TFPessoaId',fld:'vTFPESSOAID',pic:'ZZZ9'},{av:'AV43TFPessoaId_To',fld:'vTFPESSOAID_TO',pic:'ZZZ9'},{av:'AV46TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV47TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV54TFPessoaTelefone',fld:'vTFPESSOATELEFONE',pic:''},{av:'AV55TFPessoaTelefone_Sel',fld:'vTFPESSOATELEFONE_SEL',pic:''},{av:'AV58TFPessoaEmail',fld:'vTFPESSOAEMAIL',pic:''},{av:'AV59TFPessoaEmail_Sel',fld:'vTFPESSOAEMAIL_SEL',pic:''},{av:'AV66TFPessoaSituacao_Sel',fld:'vTFPESSOASITUACAO_SEL',pic:'9'},{av:'AV35ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV27ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV44ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_PessoaTelefoneTitleControlIdToReplace',fld:'vDDO_PESSOATELEFONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_PessoaEmailTitleControlIdToReplace',fld:'vDDO_PESSOAEMAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_PessoaSituacaoTitleControlIdToReplace',fld:'vDDO_PESSOASITUACAOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV92Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_gridcolumnsselector_Columnsselectorvalues',ctrl:'DDO_GRIDCOLUMNSSELECTOR',prop:'ColumnsSelectorValues'}]");
         setEventMetadata("DDO_GRIDCOLUMNSSELECTOR.ONCOLUMNSCHANGED",",oparms:[{av:'AV27ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV41PessoaIdTitleFilterData',fld:'vPESSOAIDTITLEFILTERDATA',pic:''},{av:'AV45PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV53PessoaTelefoneTitleFilterData',fld:'vPESSOATELEFONETITLEFILTERDATA',pic:''},{av:'AV57PessoaEmailTitleFilterData',fld:'vPESSOAEMAILTITLEFILTERDATA',pic:''},{av:'AV65PessoaSituacaoTitleFilterData',fld:'vPESSOASITUACAOTITLEFILTERDATA',pic:''},{av:'AV35ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'edtPessoaId_Visible',ctrl:'PESSOAID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPessoaTelefone_Visible',ctrl:'PESSOATELEFONE',prop:'Visible'},{av:'edtPessoaEmail_Visible',ctrl:'PESSOAEMAIL',prop:'Visible'},{av:'chkPessoaSituacao.Visible',ctrl:'PESSOASITUACAO',prop:'Visible'},{av:'edtPessoaId_Titleformat',ctrl:'PESSOAID',prop:'Titleformat'},{av:'edtPessoaId_Title',ctrl:'PESSOAID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPessoaTelefone_Titleformat',ctrl:'PESSOATELEFONE',prop:'Titleformat'},{av:'edtPessoaTelefone_Title',ctrl:'PESSOATELEFONE',prop:'Title'},{av:'edtPessoaEmail_Titleformat',ctrl:'PESSOAEMAIL',prop:'Titleformat'},{av:'edtPessoaEmail_Title',ctrl:'PESSOAEMAIL',prop:'Title'},{av:'chkPessoaSituacao_Titleformat',ctrl:'PESSOASITUACAO',prop:'Titleformat'},{av:'chkPessoaSituacao.Title.Text',ctrl:'PESSOASITUACAO',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]}");
         setEventMetadata("DDO_MANAGEFILTERS.ONOPTIONCLICKED","{handler:'E110M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavPessoanomeoperator'},{av:'AV74PessoaNomeOperator',fld:'vPESSOANOMEOPERATOR',pic:'ZZZ9'},{av:'AV75PessoaNome',fld:'vPESSOANOME',pic:''},{av:'cmbavPessoaemailoperator'},{av:'AV76PessoaEmailOperator',fld:'vPESSOAEMAILOPERATOR',pic:'ZZZ9'},{av:'AV77PessoaEmail',fld:'vPESSOAEMAIL',pic:''},{av:'AV12OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV13OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV42TFPessoaId',fld:'vTFPESSOAID',pic:'ZZZ9'},{av:'AV43TFPessoaId_To',fld:'vTFPESSOAID_TO',pic:'ZZZ9'},{av:'AV46TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'AV47TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'AV54TFPessoaTelefone',fld:'vTFPESSOATELEFONE',pic:''},{av:'AV55TFPessoaTelefone_Sel',fld:'vTFPESSOATELEFONE_SEL',pic:''},{av:'AV58TFPessoaEmail',fld:'vTFPESSOAEMAIL',pic:''},{av:'AV59TFPessoaEmail_Sel',fld:'vTFPESSOAEMAIL_SEL',pic:''},{av:'AV66TFPessoaSituacao_Sel',fld:'vTFPESSOASITUACAO_SEL',pic:'9'},{av:'AV35ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV27ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'AV44ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_PessoaTelefoneTitleControlIdToReplace',fld:'vDDO_PESSOATELEFONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_PessoaEmailTitleControlIdToReplace',fld:'vDDO_PESSOAEMAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_PessoaSituacaoTitleControlIdToReplace',fld:'vDDO_PESSOASITUACAOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV92Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_managefilters_Activeeventkey',ctrl:'DDO_MANAGEFILTERS',prop:'ActiveEventKey'},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''}]");
         setEventMetadata("DDO_MANAGEFILTERS.ONOPTIONCLICKED",",oparms:[{av:'AV35ManageFiltersExecutionStep',fld:'vMANAGEFILTERSEXECUTIONSTEP',pic:'9'},{av:'AV10GridState',fld:'vGRIDSTATE',pic:''},{av:'AV12OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV13OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'cmbavPessoanomeoperator'},{av:'AV74PessoaNomeOperator',fld:'vPESSOANOMEOPERATOR',pic:'ZZZ9'},{av:'AV75PessoaNome',fld:'vPESSOANOME',pic:''},{av:'cmbavPessoaemailoperator'},{av:'AV76PessoaEmailOperator',fld:'vPESSOAEMAILOPERATOR',pic:'ZZZ9'},{av:'AV77PessoaEmail',fld:'vPESSOAEMAIL',pic:''},{av:'AV42TFPessoaId',fld:'vTFPESSOAID',pic:'ZZZ9'},{av:'Ddo_pessoaid_Filteredtext_set',ctrl:'DDO_PESSOAID',prop:'FilteredText_set'},{av:'AV43TFPessoaId_To',fld:'vTFPESSOAID_TO',pic:'ZZZ9'},{av:'Ddo_pessoaid_Filteredtextto_set',ctrl:'DDO_PESSOAID',prop:'FilteredTextTo_set'},{av:'AV46TFPessoaNome',fld:'vTFPESSOANOME',pic:''},{av:'Ddo_pessoanome_Filteredtext_set',ctrl:'DDO_PESSOANOME',prop:'FilteredText_set'},{av:'AV47TFPessoaNome_Sel',fld:'vTFPESSOANOME_SEL',pic:''},{av:'Ddo_pessoanome_Selectedvalue_set',ctrl:'DDO_PESSOANOME',prop:'SelectedValue_set'},{av:'AV54TFPessoaTelefone',fld:'vTFPESSOATELEFONE',pic:''},{av:'Ddo_pessoatelefone_Filteredtext_set',ctrl:'DDO_PESSOATELEFONE',prop:'FilteredText_set'},{av:'AV55TFPessoaTelefone_Sel',fld:'vTFPESSOATELEFONE_SEL',pic:''},{av:'Ddo_pessoatelefone_Selectedvalue_set',ctrl:'DDO_PESSOATELEFONE',prop:'SelectedValue_set'},{av:'AV58TFPessoaEmail',fld:'vTFPESSOAEMAIL',pic:''},{av:'Ddo_pessoaemail_Filteredtext_set',ctrl:'DDO_PESSOAEMAIL',prop:'FilteredText_set'},{av:'AV59TFPessoaEmail_Sel',fld:'vTFPESSOAEMAIL_SEL',pic:''},{av:'Ddo_pessoaemail_Selectedvalue_set',ctrl:'DDO_PESSOAEMAIL',prop:'SelectedValue_set'},{av:'AV66TFPessoaSituacao_Sel',fld:'vTFPESSOASITUACAO_SEL',pic:'9'},{av:'Ddo_pessoasituacao_Selectedvalue_set',ctrl:'DDO_PESSOASITUACAO',prop:'SelectedValue_set'},{av:'Ddo_pessoaid_Sortedstatus',ctrl:'DDO_PESSOAID',prop:'SortedStatus'},{av:'Ddo_pessoanome_Sortedstatus',ctrl:'DDO_PESSOANOME',prop:'SortedStatus'},{av:'Ddo_pessoatelefone_Sortedstatus',ctrl:'DDO_PESSOATELEFONE',prop:'SortedStatus'},{av:'Ddo_pessoaemail_Sortedstatus',ctrl:'DDO_PESSOAEMAIL',prop:'SortedStatus'},{av:'Ddo_pessoasituacao_Sortedstatus',ctrl:'DDO_PESSOASITUACAO',prop:'SortedStatus'},{av:'AV41PessoaIdTitleFilterData',fld:'vPESSOAIDTITLEFILTERDATA',pic:''},{av:'AV45PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV53PessoaTelefoneTitleFilterData',fld:'vPESSOATELEFONETITLEFILTERDATA',pic:''},{av:'AV57PessoaEmailTitleFilterData',fld:'vPESSOAEMAILTITLEFILTERDATA',pic:''},{av:'AV65PessoaSituacaoTitleFilterData',fld:'vPESSOASITUACAOTITLEFILTERDATA',pic:''},{av:'AV27ColumnsSelector',fld:'vCOLUMNSSELECTOR',pic:''},{av:'edtPessoaId_Visible',ctrl:'PESSOAID',prop:'Visible'},{av:'edtPessoaNome_Visible',ctrl:'PESSOANOME',prop:'Visible'},{av:'edtPessoaTelefone_Visible',ctrl:'PESSOATELEFONE',prop:'Visible'},{av:'edtPessoaEmail_Visible',ctrl:'PESSOAEMAIL',prop:'Visible'},{av:'chkPessoaSituacao.Visible',ctrl:'PESSOASITUACAO',prop:'Visible'},{av:'edtPessoaId_Titleformat',ctrl:'PESSOAID',prop:'Titleformat'},{av:'edtPessoaId_Title',ctrl:'PESSOAID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPessoaTelefone_Titleformat',ctrl:'PESSOATELEFONE',prop:'Titleformat'},{av:'edtPessoaTelefone_Title',ctrl:'PESSOATELEFONE',prop:'Title'},{av:'edtPessoaEmail_Titleformat',ctrl:'PESSOAEMAIL',prop:'Titleformat'},{av:'edtPessoaEmail_Title',ctrl:'PESSOAEMAIL',prop:'Title'},{av:'chkPessoaSituacao_Titleformat',ctrl:'PESSOASITUACAO',prop:'Titleformat'},{av:'chkPessoaSituacao.Title.Text',ctrl:'PESSOASITUACAO',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39ManageFiltersData',fld:'vMANAGEFILTERSDATA',pic:''}]}");
         setEventMetadata("'DOINSERT'","{handler:'E200M2',iparms:[{av:'A1PessoaId',fld:'PESSOAID',pic:'ZZZ9',hsh:true}]");
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
         Ddo_pessoaid_Activeeventkey = "";
         Ddo_pessoaid_Filteredtext_get = "";
         Ddo_pessoaid_Filteredtextto_get = "";
         Ddo_pessoanome_Activeeventkey = "";
         Ddo_pessoanome_Filteredtext_get = "";
         Ddo_pessoanome_Selectedvalue_get = "";
         Ddo_pessoatelefone_Activeeventkey = "";
         Ddo_pessoatelefone_Filteredtext_get = "";
         Ddo_pessoatelefone_Selectedvalue_get = "";
         Ddo_pessoaemail_Activeeventkey = "";
         Ddo_pessoaemail_Filteredtext_get = "";
         Ddo_pessoaemail_Selectedvalue_get = "";
         Ddo_pessoasituacao_Activeeventkey = "";
         Ddo_pessoasituacao_Selectedvalue_get = "";
         Ddo_gridcolumnsselector_Columnsselectorvalues = "";
         Ddo_managefilters_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV75PessoaNome = "";
         AV77PessoaEmail = "";
         AV46TFPessoaNome = "";
         AV47TFPessoaNome_Sel = "";
         AV54TFPessoaTelefone = "";
         AV55TFPessoaTelefone_Sel = "";
         AV58TFPessoaEmail = "";
         AV59TFPessoaEmail_Sel = "";
         AV27ColumnsSelector = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector(context);
         AV44ddo_PessoaIdTitleControlIdToReplace = "";
         AV48ddo_PessoaNomeTitleControlIdToReplace = "";
         AV56ddo_PessoaTelefoneTitleControlIdToReplace = "";
         AV60ddo_PessoaEmailTitleControlIdToReplace = "";
         AV67ddo_PessoaSituacaoTitleControlIdToReplace = "";
         AV92Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV39ManageFiltersData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV68DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV41PessoaIdTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV45PessoaNomeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV53PessoaTelefoneTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV57PessoaEmailTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV65PessoaSituacaoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV10GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         Ddo_pessoaid_Filteredtext_set = "";
         Ddo_pessoaid_Filteredtextto_set = "";
         Ddo_pessoaid_Sortedstatus = "";
         Ddo_pessoanome_Filteredtext_set = "";
         Ddo_pessoanome_Selectedvalue_set = "";
         Ddo_pessoanome_Sortedstatus = "";
         Ddo_pessoatelefone_Filteredtext_set = "";
         Ddo_pessoatelefone_Selectedvalue_set = "";
         Ddo_pessoatelefone_Sortedstatus = "";
         Ddo_pessoaemail_Filteredtext_set = "";
         Ddo_pessoaemail_Selectedvalue_set = "";
         Ddo_pessoaemail_Sortedstatus = "";
         Ddo_pessoasituacao_Selectedvalue_set = "";
         Ddo_pessoasituacao_Sortedstatus = "";
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
         AV72Update = "";
         AV73Delete = "";
         A2PessoaNome = "";
         A3PessoaEndereco = "";
         A4PessoaTelefone = "";
         A5PessoaEmail = "";
         A6PessoaSexo = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_pessoaid = new GXUserControl();
         ucDdo_pessoanome = new GXUserControl();
         ucDdo_pessoatelefone = new GXUserControl();
         ucDdo_pessoaemail = new GXUserControl();
         ucDdo_pessoasituacao = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         ucDdo_gridcolumnsselector = new GXUserControl();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         lV81PessoaWWDS_1_Pessoanome = "";
         lV82PessoaWWDS_2_Pessoaemail = "";
         lV85PessoaWWDS_5_Tfpessoanome = "";
         lV87PessoaWWDS_7_Tfpessoatelefone = "";
         lV89PessoaWWDS_9_Tfpessoaemail = "";
         AV81PessoaWWDS_1_Pessoanome = "";
         AV82PessoaWWDS_2_Pessoaemail = "";
         AV86PessoaWWDS_6_Tfpessoanome_sel = "";
         AV85PessoaWWDS_5_Tfpessoanome = "";
         AV88PessoaWWDS_8_Tfpessoatelefone_sel = "";
         AV87PessoaWWDS_7_Tfpessoatelefone = "";
         AV90PessoaWWDS_10_Tfpessoaemail_sel = "";
         AV89PessoaWWDS_9_Tfpessoaemail = "";
         H000M2_A7PessoaSituacao = new bool[] {false} ;
         H000M2_A6PessoaSexo = new String[] {""} ;
         H000M2_A5PessoaEmail = new String[] {""} ;
         H000M2_A4PessoaTelefone = new String[] {""} ;
         H000M2_A3PessoaEndereco = new String[] {""} ;
         H000M2_A2PessoaNome = new String[] {""} ;
         H000M2_A1PessoaId = new short[1] ;
         H000M3_AGRID_nRecordCount = new long[1] ;
         AV7HTTPRequest = new GxHttpRequest( context);
         ucDdo_managefilters = new GXUserControl();
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV34Session = context.GetSession();
         AV15ColumnsSelectorXML = "";
         GridRow = new GXWebRow();
         AV36ManageFiltersXml = "";
         AV22UserCustomValue = "";
         GXt_char2 = "";
         AV28ColumnsSelectorAux = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector(context);
         AV40ManageFiltersDataItem = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item(context);
         AV37ManageFiltersItems = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item>( context, "Item", "");
         AV38ManageFiltersItem = new GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item(context);
         AV11GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV8TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         Ddo_managefilters_Caption = "";
         lblFiltertextpessoanome_Jsonclick = "";
         lblFiltertextpessoaemail_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pessoaww__default(),
            new Object[][] {
                new Object[] {
               H000M2_A7PessoaSituacao, H000M2_A6PessoaSexo, H000M2_A5PessoaEmail, H000M2_A4PessoaTelefone, H000M2_A3PessoaEndereco, H000M2_A2PessoaNome, H000M2_A1PessoaId
               }
               , new Object[] {
               H000M3_AGRID_nRecordCount
               }
            }
         );
         AV92Pgmname = "PessoaWW";
         /* GeneXus formulas. */
         AV92Pgmname = "PessoaWW";
         context.Gx_err = 0;
         edtavUpdate_Enabled = 0;
         edtavDelete_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_67 ;
      private short nGXsfl_67_idx=1 ;
      private short GRID_nEOF ;
      private short AV74PessoaNomeOperator ;
      private short AV76PessoaEmailOperator ;
      private short AV12OrderedBy ;
      private short AV42TFPessoaId ;
      private short AV43TFPessoaId_To ;
      private short AV66TFPessoaSituacao_Sel ;
      private short AV35ManageFiltersExecutionStep ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtPessoaId_Titleformat ;
      private short edtPessoaNome_Titleformat ;
      private short edtPessoaTelefone_Titleformat ;
      private short edtPessoaEmail_Titleformat ;
      private short chkPessoaSituacao_Titleformat ;
      private short subGrid_Sortable ;
      private short A1PessoaId ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV83PessoaWWDS_3_Tfpessoaid ;
      private short AV84PessoaWWDS_4_Tfpessoaid_to ;
      private short AV91PessoaWWDS_11_Tfpessoasituacao_sel ;
      private short nGXWrapped ;
      private short subGrid_Backstyle ;
      private int subGrid_Rows ;
      private int Gridpaginationbar_Rowsperpageselectedvalue ;
      private int Gridpaginationbar_Pagestoshow ;
      private int Ddo_pessoanome_Datalistupdateminimumcharacters ;
      private int Ddo_pessoatelefone_Datalistupdateminimumcharacters ;
      private int Ddo_pessoaemail_Datalistupdateminimumcharacters ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtPessoaId_Visible ;
      private int edtPessoaNome_Visible ;
      private int edtPessoaTelefone_Visible ;
      private int edtPessoaEmail_Visible ;
      private int edtavUpdate_Enabled ;
      private int edtavDelete_Enabled ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_pessoaidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_pessoanometitlecontrolidtoreplace_Visible ;
      private int edtavDdo_pessoatelefonetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_pessoaemailtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_pessoasituacaotitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int edtavManagefiltersexecutionstep_Visible ;
      private int edtavTfpessoaid_Visible ;
      private int edtavTfpessoaid_to_Visible ;
      private int edtavTfpessoanome_Visible ;
      private int edtavTfpessoanome_sel_Visible ;
      private int edtavTfpessoatelefone_Visible ;
      private int edtavTfpessoatelefone_sel_Visible ;
      private int edtavTfpessoaemail_Visible ;
      private int edtavTfpessoaemail_sel_Visible ;
      private int edtavTfpessoasituacao_sel_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV69PageToGo ;
      private int AV93GXV1 ;
      private int AV94GXV2 ;
      private int edtavPessoaemail_Enabled ;
      private int edtavPessoanome_Enabled ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long AV70GridCurrentPage ;
      private long AV71GridPageCount ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_pessoaid_Activeeventkey ;
      private String Ddo_pessoaid_Filteredtext_get ;
      private String Ddo_pessoaid_Filteredtextto_get ;
      private String Ddo_pessoanome_Activeeventkey ;
      private String Ddo_pessoanome_Filteredtext_get ;
      private String Ddo_pessoanome_Selectedvalue_get ;
      private String Ddo_pessoatelefone_Activeeventkey ;
      private String Ddo_pessoatelefone_Filteredtext_get ;
      private String Ddo_pessoatelefone_Selectedvalue_get ;
      private String Ddo_pessoaemail_Activeeventkey ;
      private String Ddo_pessoaemail_Filteredtext_get ;
      private String Ddo_pessoaemail_Selectedvalue_get ;
      private String Ddo_pessoasituacao_Activeeventkey ;
      private String Ddo_pessoasituacao_Selectedvalue_get ;
      private String Ddo_gridcolumnsselector_Columnsselectorvalues ;
      private String Ddo_managefilters_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_67_idx="0001" ;
      private String AV92Pgmname ;
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
      private String Ddo_pessoatelefone_Caption ;
      private String Ddo_pessoatelefone_Tooltip ;
      private String Ddo_pessoatelefone_Cls ;
      private String Ddo_pessoatelefone_Filteredtext_set ;
      private String Ddo_pessoatelefone_Selectedvalue_set ;
      private String Ddo_pessoatelefone_Dropdownoptionstype ;
      private String Ddo_pessoatelefone_Titlecontrolidtoreplace ;
      private String Ddo_pessoatelefone_Sortedstatus ;
      private String Ddo_pessoatelefone_Filtertype ;
      private String Ddo_pessoatelefone_Datalisttype ;
      private String Ddo_pessoatelefone_Datalistproc ;
      private String Ddo_pessoatelefone_Sortasc ;
      private String Ddo_pessoatelefone_Sortdsc ;
      private String Ddo_pessoatelefone_Loadingdata ;
      private String Ddo_pessoatelefone_Cleanfilter ;
      private String Ddo_pessoatelefone_Noresultsfound ;
      private String Ddo_pessoatelefone_Searchbuttontext ;
      private String Ddo_pessoaemail_Caption ;
      private String Ddo_pessoaemail_Tooltip ;
      private String Ddo_pessoaemail_Cls ;
      private String Ddo_pessoaemail_Filteredtext_set ;
      private String Ddo_pessoaemail_Selectedvalue_set ;
      private String Ddo_pessoaemail_Dropdownoptionstype ;
      private String Ddo_pessoaemail_Titlecontrolidtoreplace ;
      private String Ddo_pessoaemail_Sortedstatus ;
      private String Ddo_pessoaemail_Filtertype ;
      private String Ddo_pessoaemail_Datalisttype ;
      private String Ddo_pessoaemail_Datalistproc ;
      private String Ddo_pessoaemail_Sortasc ;
      private String Ddo_pessoaemail_Sortdsc ;
      private String Ddo_pessoaemail_Loadingdata ;
      private String Ddo_pessoaemail_Cleanfilter ;
      private String Ddo_pessoaemail_Noresultsfound ;
      private String Ddo_pessoaemail_Searchbuttontext ;
      private String Ddo_pessoasituacao_Caption ;
      private String Ddo_pessoasituacao_Tooltip ;
      private String Ddo_pessoasituacao_Cls ;
      private String Ddo_pessoasituacao_Selectedvalue_set ;
      private String Ddo_pessoasituacao_Dropdownoptionstype ;
      private String Ddo_pessoasituacao_Titlecontrolidtoreplace ;
      private String Ddo_pessoasituacao_Sortedstatus ;
      private String Ddo_pessoasituacao_Datalisttype ;
      private String Ddo_pessoasituacao_Datalistfixedvalues ;
      private String Ddo_pessoasituacao_Sortasc ;
      private String Ddo_pessoasituacao_Sortdsc ;
      private String Ddo_pessoasituacao_Cleanfilter ;
      private String Ddo_pessoasituacao_Searchbuttontext ;
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
      private String edtPessoaId_Title ;
      private String edtPessoaNome_Title ;
      private String edtPessoaTelefone_Title ;
      private String edtPessoaEmail_Title ;
      private String subGrid_Header ;
      private String AV72Update ;
      private String edtavUpdate_Link ;
      private String AV73Delete ;
      private String edtavDelete_Link ;
      private String A6PessoaSexo ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_pessoaid_Internalname ;
      private String edtavDdo_pessoaidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_pessoanome_Internalname ;
      private String edtavDdo_pessoanometitlecontrolidtoreplace_Internalname ;
      private String Ddo_pessoatelefone_Internalname ;
      private String edtavDdo_pessoatelefonetitlecontrolidtoreplace_Internalname ;
      private String Ddo_pessoaemail_Internalname ;
      private String edtavDdo_pessoaemailtitlecontrolidtoreplace_Internalname ;
      private String Ddo_pessoasituacao_Internalname ;
      private String edtavDdo_pessoasituacaotitlecontrolidtoreplace_Internalname ;
      private String Workwithplusutilities1_Internalname ;
      private String Ddo_gridcolumnsselector_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String edtavManagefiltersexecutionstep_Internalname ;
      private String edtavManagefiltersexecutionstep_Jsonclick ;
      private String edtavTfpessoaid_Internalname ;
      private String edtavTfpessoaid_Jsonclick ;
      private String edtavTfpessoaid_to_Internalname ;
      private String edtavTfpessoaid_to_Jsonclick ;
      private String edtavTfpessoanome_Internalname ;
      private String edtavTfpessoanome_Jsonclick ;
      private String edtavTfpessoanome_sel_Internalname ;
      private String edtavTfpessoanome_sel_Jsonclick ;
      private String edtavTfpessoatelefone_Internalname ;
      private String edtavTfpessoatelefone_Jsonclick ;
      private String edtavTfpessoatelefone_sel_Internalname ;
      private String edtavTfpessoatelefone_sel_Jsonclick ;
      private String edtavTfpessoaemail_Internalname ;
      private String edtavTfpessoaemail_Jsonclick ;
      private String edtavTfpessoaemail_sel_Internalname ;
      private String edtavTfpessoaemail_sel_Jsonclick ;
      private String edtavTfpessoasituacao_sel_Internalname ;
      private String edtavTfpessoasituacao_sel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavUpdate_Internalname ;
      private String edtavDelete_Internalname ;
      private String edtPessoaId_Internalname ;
      private String edtPessoaNome_Internalname ;
      private String edtPessoaEndereco_Internalname ;
      private String edtPessoaTelefone_Internalname ;
      private String edtPessoaEmail_Internalname ;
      private String cmbPessoaSexo_Internalname ;
      private String chkPessoaSituacao_Internalname ;
      private String cmbavPessoanomeoperator_Internalname ;
      private String cmbavPessoaemailoperator_Internalname ;
      private String scmdbuf ;
      private String edtavPessoanome_Internalname ;
      private String edtavPessoaemail_Internalname ;
      private String Ddo_managefilters_Internalname ;
      private String GXt_char2 ;
      private String tblTablerightheader_Internalname ;
      private String Ddo_managefilters_Caption ;
      private String tblTablefilters_Internalname ;
      private String divTablesplittedfiltertextpessoanome_Internalname ;
      private String lblFiltertextpessoanome_Internalname ;
      private String lblFiltertextpessoanome_Jsonclick ;
      private String divTablesplittedfiltertextpessoaemail_Internalname ;
      private String lblFiltertextpessoaemail_Internalname ;
      private String lblFiltertextpessoaemail_Jsonclick ;
      private String tblTablemergedpessoaemail_Internalname ;
      private String cmbavPessoaemailoperator_Jsonclick ;
      private String edtavPessoaemail_Jsonclick ;
      private String tblTablemergedpessoanome_Internalname ;
      private String cmbavPessoanomeoperator_Jsonclick ;
      private String edtavPessoanome_Jsonclick ;
      private String sGXsfl_67_fel_idx="0001" ;
      private String ROClassString ;
      private String edtavUpdate_Jsonclick ;
      private String edtavDelete_Jsonclick ;
      private String edtPessoaId_Jsonclick ;
      private String edtPessoaNome_Jsonclick ;
      private String edtPessoaEndereco_Jsonclick ;
      private String edtPessoaTelefone_Jsonclick ;
      private String edtPessoaEmail_Jsonclick ;
      private String GXCCtl ;
      private String cmbPessoaSexo_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV13OrderedDsc ;
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
      private bool Ddo_pessoatelefone_Includesortasc ;
      private bool Ddo_pessoatelefone_Includesortdsc ;
      private bool Ddo_pessoatelefone_Includefilter ;
      private bool Ddo_pessoatelefone_Filterisrange ;
      private bool Ddo_pessoatelefone_Includedatalist ;
      private bool Ddo_pessoaemail_Includesortasc ;
      private bool Ddo_pessoaemail_Includesortdsc ;
      private bool Ddo_pessoaemail_Includefilter ;
      private bool Ddo_pessoaemail_Filterisrange ;
      private bool Ddo_pessoaemail_Includedatalist ;
      private bool Ddo_pessoasituacao_Includesortasc ;
      private bool Ddo_pessoasituacao_Includesortdsc ;
      private bool Ddo_pessoasituacao_Includefilter ;
      private bool Ddo_pessoasituacao_Includedatalist ;
      private bool wbLoad ;
      private bool A7PessoaSituacao ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_67_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private String AV15ColumnsSelectorXML ;
      private String AV36ManageFiltersXml ;
      private String AV22UserCustomValue ;
      private String AV75PessoaNome ;
      private String AV77PessoaEmail ;
      private String AV46TFPessoaNome ;
      private String AV47TFPessoaNome_Sel ;
      private String AV54TFPessoaTelefone ;
      private String AV55TFPessoaTelefone_Sel ;
      private String AV58TFPessoaEmail ;
      private String AV59TFPessoaEmail_Sel ;
      private String AV44ddo_PessoaIdTitleControlIdToReplace ;
      private String AV48ddo_PessoaNomeTitleControlIdToReplace ;
      private String AV56ddo_PessoaTelefoneTitleControlIdToReplace ;
      private String AV60ddo_PessoaEmailTitleControlIdToReplace ;
      private String AV67ddo_PessoaSituacaoTitleControlIdToReplace ;
      private String A2PessoaNome ;
      private String A3PessoaEndereco ;
      private String A4PessoaTelefone ;
      private String A5PessoaEmail ;
      private String lV81PessoaWWDS_1_Pessoanome ;
      private String lV82PessoaWWDS_2_Pessoaemail ;
      private String lV85PessoaWWDS_5_Tfpessoanome ;
      private String lV87PessoaWWDS_7_Tfpessoatelefone ;
      private String lV89PessoaWWDS_9_Tfpessoaemail ;
      private String AV81PessoaWWDS_1_Pessoanome ;
      private String AV82PessoaWWDS_2_Pessoaemail ;
      private String AV86PessoaWWDS_6_Tfpessoanome_sel ;
      private String AV85PessoaWWDS_5_Tfpessoanome ;
      private String AV88PessoaWWDS_8_Tfpessoatelefone_sel ;
      private String AV87PessoaWWDS_7_Tfpessoatelefone ;
      private String AV90PessoaWWDS_10_Tfpessoaemail_sel ;
      private String AV89PessoaWWDS_9_Tfpessoaemail ;
      private IGxSession AV34Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_pessoaid ;
      private GXUserControl ucDdo_pessoanome ;
      private GXUserControl ucDdo_pessoatelefone ;
      private GXUserControl ucDdo_pessoaemail ;
      private GXUserControl ucDdo_pessoasituacao ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXUserControl ucDdo_gridcolumnsselector ;
      private GXUserControl ucDdo_managefilters ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavPessoanomeoperator ;
      private GXCombobox cmbavPessoaemailoperator ;
      private GXCombobox cmbPessoaSexo ;
      private GXCheckbox chkPessoaSituacao ;
      private IDataStoreProvider pr_default ;
      private bool[] H000M2_A7PessoaSituacao ;
      private String[] H000M2_A6PessoaSexo ;
      private String[] H000M2_A5PessoaEmail ;
      private String[] H000M2_A4PessoaTelefone ;
      private String[] H000M2_A3PessoaEndereco ;
      private String[] H000M2_A2PessoaNome ;
      private short[] H000M2_A1PessoaId ;
      private long[] H000M3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV7HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item> AV37ManageFiltersItems ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV39ManageFiltersData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV41PessoaIdTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV45PessoaNomeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV53PessoaTelefoneTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV57PessoaEmailTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV65PessoaSituacaoTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV8TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV10GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV11GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector AV27ColumnsSelector ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector AV28ColumnsSelectorAux ;
      private GeneXus.Programs.wwpbaseobjects.SdtGridStateCollection_Item AV38ManageFiltersItem ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item AV40ManageFiltersDataItem ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV68DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class pessoaww__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H000M2( IGxContext context ,
                                             short AV74PessoaNomeOperator ,
                                             String AV81PessoaWWDS_1_Pessoanome ,
                                             short AV76PessoaEmailOperator ,
                                             String AV82PessoaWWDS_2_Pessoaemail ,
                                             short AV83PessoaWWDS_3_Tfpessoaid ,
                                             short AV84PessoaWWDS_4_Tfpessoaid_to ,
                                             String AV86PessoaWWDS_6_Tfpessoanome_sel ,
                                             String AV85PessoaWWDS_5_Tfpessoanome ,
                                             String AV88PessoaWWDS_8_Tfpessoatelefone_sel ,
                                             String AV87PessoaWWDS_7_Tfpessoatelefone ,
                                             String AV90PessoaWWDS_10_Tfpessoaemail_sel ,
                                             String AV89PessoaWWDS_9_Tfpessoaemail ,
                                             short AV91PessoaWWDS_11_Tfpessoasituacao_sel ,
                                             String A2PessoaNome ,
                                             String A5PessoaEmail ,
                                             short A1PessoaId ,
                                             String A4PessoaTelefone ,
                                             bool A7PessoaSituacao ,
                                             short AV12OrderedBy ,
                                             bool AV13OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [14] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [PessoaSituacao], [PessoaSexo], [PessoaEmail], [PessoaTelefone], [PessoaEndereco], [PessoaNome], [PessoaId]";
         sFromString = " FROM [Pessoa]";
         sOrderString = "";
         if ( ( AV74PessoaNomeOperator == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81PessoaWWDS_1_Pessoanome)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaNome] like '%' + @lV81PessoaWWDS_1_Pessoanome)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaNome] like '%' + @lV81PessoaWWDS_1_Pessoanome)";
            }
         }
         else
         {
            GXv_int3[0] = 1;
         }
         if ( ( AV76PessoaEmailOperator == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82PessoaWWDS_2_Pessoaemail)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaEmail] like @lV82PessoaWWDS_2_Pessoaemail)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaEmail] like @lV82PessoaWWDS_2_Pessoaemail)";
            }
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ( AV76PessoaEmailOperator == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82PessoaWWDS_2_Pessoaemail)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaEmail] like '%' + @lV82PessoaWWDS_2_Pessoaemail)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaEmail] like '%' + @lV82PessoaWWDS_2_Pessoaemail)";
            }
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (0==AV83PessoaWWDS_3_Tfpessoaid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaId] >= @AV83PessoaWWDS_3_Tfpessoaid)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaId] >= @AV83PessoaWWDS_3_Tfpessoaid)";
            }
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! (0==AV84PessoaWWDS_4_Tfpessoaid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaId] <= @AV84PessoaWWDS_4_Tfpessoaid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaId] <= @AV84PessoaWWDS_4_Tfpessoaid_to)";
            }
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV86PessoaWWDS_6_Tfpessoanome_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV85PessoaWWDS_5_Tfpessoanome)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaNome] like @lV85PessoaWWDS_5_Tfpessoanome)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaNome] like @lV85PessoaWWDS_5_Tfpessoanome)";
            }
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV86PessoaWWDS_6_Tfpessoanome_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaNome] = @AV86PessoaWWDS_6_Tfpessoanome_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaNome] = @AV86PessoaWWDS_6_Tfpessoanome_sel)";
            }
         }
         else
         {
            GXv_int3[6] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV88PessoaWWDS_8_Tfpessoatelefone_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV87PessoaWWDS_7_Tfpessoatelefone)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaTelefone] like @lV87PessoaWWDS_7_Tfpessoatelefone)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaTelefone] like @lV87PessoaWWDS_7_Tfpessoatelefone)";
            }
         }
         else
         {
            GXv_int3[7] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV88PessoaWWDS_8_Tfpessoatelefone_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaTelefone] = @AV88PessoaWWDS_8_Tfpessoatelefone_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaTelefone] = @AV88PessoaWWDS_8_Tfpessoatelefone_sel)";
            }
         }
         else
         {
            GXv_int3[8] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV90PessoaWWDS_10_Tfpessoaemail_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV89PessoaWWDS_9_Tfpessoaemail)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaEmail] like @lV89PessoaWWDS_9_Tfpessoaemail)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaEmail] like @lV89PessoaWWDS_9_Tfpessoaemail)";
            }
         }
         else
         {
            GXv_int3[9] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV90PessoaWWDS_10_Tfpessoaemail_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaEmail] = @AV90PessoaWWDS_10_Tfpessoaemail_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaEmail] = @AV90PessoaWWDS_10_Tfpessoaemail_sel)";
            }
         }
         else
         {
            GXv_int3[10] = 1;
         }
         if ( AV91PessoaWWDS_11_Tfpessoasituacao_sel == 1 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaSituacao] = 1)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaSituacao] = 1)";
            }
         }
         if ( AV91PessoaWWDS_11_Tfpessoasituacao_sel == 2 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaSituacao] = 0)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaSituacao] = 0)";
            }
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         if ( ( AV12OrderedBy == 1 ) && ! AV13OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [PessoaId]";
         }
         else if ( ( AV12OrderedBy == 1 ) && ( AV13OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [PessoaId] DESC";
         }
         else if ( ( AV12OrderedBy == 2 ) && ! AV13OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [PessoaNome]";
         }
         else if ( ( AV12OrderedBy == 2 ) && ( AV13OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [PessoaNome] DESC";
         }
         else if ( ( AV12OrderedBy == 3 ) && ! AV13OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [PessoaTelefone]";
         }
         else if ( ( AV12OrderedBy == 3 ) && ( AV13OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [PessoaTelefone] DESC";
         }
         else if ( ( AV12OrderedBy == 4 ) && ! AV13OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [PessoaEmail]";
         }
         else if ( ( AV12OrderedBy == 4 ) && ( AV13OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [PessoaEmail] DESC";
         }
         else if ( ( AV12OrderedBy == 5 ) && ! AV13OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [PessoaSituacao]";
         }
         else if ( ( AV12OrderedBy == 5 ) && ( AV13OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [PessoaSituacao] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [PessoaId]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H000M3( IGxContext context ,
                                             short AV74PessoaNomeOperator ,
                                             String AV81PessoaWWDS_1_Pessoanome ,
                                             short AV76PessoaEmailOperator ,
                                             String AV82PessoaWWDS_2_Pessoaemail ,
                                             short AV83PessoaWWDS_3_Tfpessoaid ,
                                             short AV84PessoaWWDS_4_Tfpessoaid_to ,
                                             String AV86PessoaWWDS_6_Tfpessoanome_sel ,
                                             String AV85PessoaWWDS_5_Tfpessoanome ,
                                             String AV88PessoaWWDS_8_Tfpessoatelefone_sel ,
                                             String AV87PessoaWWDS_7_Tfpessoatelefone ,
                                             String AV90PessoaWWDS_10_Tfpessoaemail_sel ,
                                             String AV89PessoaWWDS_9_Tfpessoaemail ,
                                             short AV91PessoaWWDS_11_Tfpessoasituacao_sel ,
                                             String A2PessoaNome ,
                                             String A5PessoaEmail ,
                                             short A1PessoaId ,
                                             String A4PessoaTelefone ,
                                             bool A7PessoaSituacao ,
                                             short AV12OrderedBy ,
                                             bool AV13OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [11] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [Pessoa]";
         if ( ( AV74PessoaNomeOperator == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81PessoaWWDS_1_Pessoanome)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaNome] like '%' + @lV81PessoaWWDS_1_Pessoanome)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaNome] like '%' + @lV81PessoaWWDS_1_Pessoanome)";
            }
         }
         else
         {
            GXv_int5[0] = 1;
         }
         if ( ( AV76PessoaEmailOperator == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82PessoaWWDS_2_Pessoaemail)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaEmail] like @lV82PessoaWWDS_2_Pessoaemail)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaEmail] like @lV82PessoaWWDS_2_Pessoaemail)";
            }
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( ( AV76PessoaEmailOperator == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82PessoaWWDS_2_Pessoaemail)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaEmail] like '%' + @lV82PessoaWWDS_2_Pessoaemail)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaEmail] like '%' + @lV82PessoaWWDS_2_Pessoaemail)";
            }
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( ! (0==AV83PessoaWWDS_3_Tfpessoaid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaId] >= @AV83PessoaWWDS_3_Tfpessoaid)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaId] >= @AV83PessoaWWDS_3_Tfpessoaid)";
            }
         }
         else
         {
            GXv_int5[3] = 1;
         }
         if ( ! (0==AV84PessoaWWDS_4_Tfpessoaid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaId] <= @AV84PessoaWWDS_4_Tfpessoaid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaId] <= @AV84PessoaWWDS_4_Tfpessoaid_to)";
            }
         }
         else
         {
            GXv_int5[4] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV86PessoaWWDS_6_Tfpessoanome_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV85PessoaWWDS_5_Tfpessoanome)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaNome] like @lV85PessoaWWDS_5_Tfpessoanome)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaNome] like @lV85PessoaWWDS_5_Tfpessoanome)";
            }
         }
         else
         {
            GXv_int5[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV86PessoaWWDS_6_Tfpessoanome_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaNome] = @AV86PessoaWWDS_6_Tfpessoanome_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaNome] = @AV86PessoaWWDS_6_Tfpessoanome_sel)";
            }
         }
         else
         {
            GXv_int5[6] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV88PessoaWWDS_8_Tfpessoatelefone_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV87PessoaWWDS_7_Tfpessoatelefone)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaTelefone] like @lV87PessoaWWDS_7_Tfpessoatelefone)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaTelefone] like @lV87PessoaWWDS_7_Tfpessoatelefone)";
            }
         }
         else
         {
            GXv_int5[7] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV88PessoaWWDS_8_Tfpessoatelefone_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaTelefone] = @AV88PessoaWWDS_8_Tfpessoatelefone_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaTelefone] = @AV88PessoaWWDS_8_Tfpessoatelefone_sel)";
            }
         }
         else
         {
            GXv_int5[8] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV90PessoaWWDS_10_Tfpessoaemail_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV89PessoaWWDS_9_Tfpessoaemail)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaEmail] like @lV89PessoaWWDS_9_Tfpessoaemail)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaEmail] like @lV89PessoaWWDS_9_Tfpessoaemail)";
            }
         }
         else
         {
            GXv_int5[9] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV90PessoaWWDS_10_Tfpessoaemail_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaEmail] = @AV90PessoaWWDS_10_Tfpessoaemail_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaEmail] = @AV90PessoaWWDS_10_Tfpessoaemail_sel)";
            }
         }
         else
         {
            GXv_int5[10] = 1;
         }
         if ( AV91PessoaWWDS_11_Tfpessoasituacao_sel == 1 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaSituacao] = 1)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaSituacao] = 1)";
            }
         }
         if ( AV91PessoaWWDS_11_Tfpessoasituacao_sel == 2 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PessoaSituacao] = 0)";
            }
            else
            {
               sWhereString = sWhereString + " ([PessoaSituacao] = 0)";
            }
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         if ( ( AV12OrderedBy == 1 ) && ! AV13OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV12OrderedBy == 1 ) && ( AV13OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV12OrderedBy == 2 ) && ! AV13OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV12OrderedBy == 2 ) && ( AV13OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV12OrderedBy == 3 ) && ! AV13OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV12OrderedBy == 3 ) && ( AV13OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV12OrderedBy == 4 ) && ! AV13OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV12OrderedBy == 4 ) && ( AV13OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV12OrderedBy == 5 ) && ! AV13OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV12OrderedBy == 5 ) && ( AV13OrderedDsc ) )
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
                     return conditional_H000M2(context, (short)dynConstraints[0] , (String)dynConstraints[1] , (short)dynConstraints[2] , (String)dynConstraints[3] , (short)dynConstraints[4] , (short)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (short)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (short)dynConstraints[15] , (String)dynConstraints[16] , (bool)dynConstraints[17] , (short)dynConstraints[18] , (bool)dynConstraints[19] );
               case 1 :
                     return conditional_H000M3(context, (short)dynConstraints[0] , (String)dynConstraints[1] , (short)dynConstraints[2] , (String)dynConstraints[3] , (short)dynConstraints[4] , (short)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (short)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (short)dynConstraints[15] , (String)dynConstraints[16] , (bool)dynConstraints[17] , (short)dynConstraints[18] , (bool)dynConstraints[19] );
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
          Object[] prmH000M2 ;
          prmH000M2 = new Object[] {
          new Object[] {"@lV81PessoaWWDS_1_Pessoanome",SqlDbType.VarChar,60,0} ,
          new Object[] {"@lV82PessoaWWDS_2_Pessoaemail",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV82PessoaWWDS_2_Pessoaemail",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV83PessoaWWDS_3_Tfpessoaid",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV84PessoaWWDS_4_Tfpessoaid_to",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV85PessoaWWDS_5_Tfpessoanome",SqlDbType.VarChar,60,0} ,
          new Object[] {"@AV86PessoaWWDS_6_Tfpessoanome_sel",SqlDbType.VarChar,60,0} ,
          new Object[] {"@lV87PessoaWWDS_7_Tfpessoatelefone",SqlDbType.VarChar,11,0} ,
          new Object[] {"@AV88PessoaWWDS_8_Tfpessoatelefone_sel",SqlDbType.VarChar,11,0} ,
          new Object[] {"@lV89PessoaWWDS_9_Tfpessoaemail",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV90PessoaWWDS_10_Tfpessoaemail_sel",SqlDbType.VarChar,50,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH000M3 ;
          prmH000M3 = new Object[] {
          new Object[] {"@lV81PessoaWWDS_1_Pessoanome",SqlDbType.VarChar,60,0} ,
          new Object[] {"@lV82PessoaWWDS_2_Pessoaemail",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV82PessoaWWDS_2_Pessoaemail",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV83PessoaWWDS_3_Tfpessoaid",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV84PessoaWWDS_4_Tfpessoaid_to",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV85PessoaWWDS_5_Tfpessoanome",SqlDbType.VarChar,60,0} ,
          new Object[] {"@AV86PessoaWWDS_6_Tfpessoanome_sel",SqlDbType.VarChar,60,0} ,
          new Object[] {"@lV87PessoaWWDS_7_Tfpessoatelefone",SqlDbType.VarChar,11,0} ,
          new Object[] {"@AV88PessoaWWDS_8_Tfpessoatelefone_sel",SqlDbType.VarChar,11,0} ,
          new Object[] {"@lV89PessoaWWDS_9_Tfpessoaemail",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV90PessoaWWDS_10_Tfpessoaemail_sel",SqlDbType.VarChar,50,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000M2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000M2,11, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("H000M3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000M3,1, GxCacheFrequency.OFF ,true,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 1) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
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
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[17]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[18]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[20]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[23]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[24]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[25]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[26]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[27]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[14]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[15]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[20]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                return;
       }
    }

 }

}
