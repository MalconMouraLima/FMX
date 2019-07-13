/*
               File: PessoaPrompt
        Description: Consulta de Pessoa
             Author: GeneXus C# Generator version 16_0_2-131213
       Generated on: 7/11/2019 12:29:29.69
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
   public class pessoaprompt : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public pessoaprompt( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public pessoaprompt( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( ref short aP0_InOutPessoaId )
      {
         this.AV29InOutPessoaId = aP0_InOutPessoaId;
         executePrivate();
         aP0_InOutPessoaId=this.AV29InOutPessoaId;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
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
               nRC_GXsfl_23 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_23_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_23_idx = GetNextPar( );
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
               AV8OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV9OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV11ddo_PessoaIdTitleControlIdToReplace = GetNextPar( );
               AV13ddo_PessoaNomeTitleControlIdToReplace = GetNextPar( );
               AV15ddo_PessoaEnderecoTitleControlIdToReplace = GetNextPar( );
               AV17ddo_PessoaTelefoneTitleControlIdToReplace = GetNextPar( );
               AV19ddo_PessoaEmailTitleControlIdToReplace = GetNextPar( );
               AV21ddo_PessoaSexoTitleControlIdToReplace = GetNextPar( );
               AV23ddo_PessoaSituacaoTitleControlIdToReplace = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV8OrderedBy, AV9OrderedDsc, AV11ddo_PessoaIdTitleControlIdToReplace, AV13ddo_PessoaNomeTitleControlIdToReplace, AV15ddo_PessoaEnderecoTitleControlIdToReplace, AV17ddo_PessoaTelefoneTitleControlIdToReplace, AV19ddo_PessoaEmailTitleControlIdToReplace, AV21ddo_PessoaSexoTitleControlIdToReplace, AV23ddo_PessoaSituacaoTitleControlIdToReplace) ;
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
               AV29InOutPessoaId = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29InOutPessoaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29InOutPessoaId), 4, 0)));
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
         PA0N2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0N2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?201971112292980", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal FormNoBackgroundColor\" data-gx-class=\"form-horizontal FormNoBackgroundColor\" novalidate action=\""+formatLink("pessoaprompt.aspx") + "?" + UrlEncode("" +AV29InOutPessoaId)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8OrderedBy), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV9OrderedDsc));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_23", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_23), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV26GridCurrentPage), 10, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGECOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV27GridPageCount), 10, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV24DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV24DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPESSOAIDTITLEFILTERDATA", AV10PessoaIdTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPESSOAIDTITLEFILTERDATA", AV10PessoaIdTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPESSOANOMETITLEFILTERDATA", AV12PessoaNomeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPESSOANOMETITLEFILTERDATA", AV12PessoaNomeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPESSOAENDERECOTITLEFILTERDATA", AV14PessoaEnderecoTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPESSOAENDERECOTITLEFILTERDATA", AV14PessoaEnderecoTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPESSOATELEFONETITLEFILTERDATA", AV16PessoaTelefoneTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPESSOATELEFONETITLEFILTERDATA", AV16PessoaTelefoneTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPESSOAEMAILTITLEFILTERDATA", AV18PessoaEmailTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPESSOAEMAILTITLEFILTERDATA", AV18PessoaEmailTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPESSOASEXOTITLEFILTERDATA", AV20PessoaSexoTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPESSOASEXOTITLEFILTERDATA", AV20PessoaSexoTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPESSOASITUACAOTITLEFILTERDATA", AV22PessoaSituacaoTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPESSOASITUACAOTITLEFILTERDATA", AV22PessoaSituacaoTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vINOUTPESSOAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV29InOutPessoaId), 4, 0, ",", "")));
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
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Caption", StringUtil.RTrim( Ddo_pessoaid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Tooltip", StringUtil.RTrim( Ddo_pessoaid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Cls", StringUtil.RTrim( Ddo_pessoaid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Dropdownoptionstype", StringUtil.RTrim( Ddo_pessoaid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_pessoaid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Includesortasc", StringUtil.BoolToStr( Ddo_pessoaid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Includesortdsc", StringUtil.BoolToStr( Ddo_pessoaid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Sortedstatus", StringUtil.RTrim( Ddo_pessoaid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Includefilter", StringUtil.BoolToStr( Ddo_pessoaid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Includedatalist", StringUtil.BoolToStr( Ddo_pessoaid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Sortasc", StringUtil.RTrim( Ddo_pessoaid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Sortdsc", StringUtil.RTrim( Ddo_pessoaid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Cleanfilter", StringUtil.RTrim( Ddo_pessoaid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Searchbuttontext", StringUtil.RTrim( Ddo_pessoaid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Caption", StringUtil.RTrim( Ddo_pessoanome_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Tooltip", StringUtil.RTrim( Ddo_pessoanome_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Cls", StringUtil.RTrim( Ddo_pessoanome_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Dropdownoptionstype", StringUtil.RTrim( Ddo_pessoanome_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_pessoanome_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Includesortasc", StringUtil.BoolToStr( Ddo_pessoanome_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Includesortdsc", StringUtil.BoolToStr( Ddo_pessoanome_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Sortedstatus", StringUtil.RTrim( Ddo_pessoanome_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Includefilter", StringUtil.BoolToStr( Ddo_pessoanome_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Includedatalist", StringUtil.BoolToStr( Ddo_pessoanome_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Sortasc", StringUtil.RTrim( Ddo_pessoanome_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Sortdsc", StringUtil.RTrim( Ddo_pessoanome_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Cleanfilter", StringUtil.RTrim( Ddo_pessoanome_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Searchbuttontext", StringUtil.RTrim( Ddo_pessoanome_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAENDERECO_Caption", StringUtil.RTrim( Ddo_pessoaendereco_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAENDERECO_Tooltip", StringUtil.RTrim( Ddo_pessoaendereco_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAENDERECO_Cls", StringUtil.RTrim( Ddo_pessoaendereco_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAENDERECO_Dropdownoptionstype", StringUtil.RTrim( Ddo_pessoaendereco_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAENDERECO_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_pessoaendereco_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAENDERECO_Includesortasc", StringUtil.BoolToStr( Ddo_pessoaendereco_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAENDERECO_Includesortdsc", StringUtil.BoolToStr( Ddo_pessoaendereco_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAENDERECO_Sortedstatus", StringUtil.RTrim( Ddo_pessoaendereco_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAENDERECO_Includefilter", StringUtil.BoolToStr( Ddo_pessoaendereco_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAENDERECO_Includedatalist", StringUtil.BoolToStr( Ddo_pessoaendereco_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAENDERECO_Sortasc", StringUtil.RTrim( Ddo_pessoaendereco_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAENDERECO_Sortdsc", StringUtil.RTrim( Ddo_pessoaendereco_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAENDERECO_Cleanfilter", StringUtil.RTrim( Ddo_pessoaendereco_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAENDERECO_Searchbuttontext", StringUtil.RTrim( Ddo_pessoaendereco_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Caption", StringUtil.RTrim( Ddo_pessoatelefone_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Tooltip", StringUtil.RTrim( Ddo_pessoatelefone_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Cls", StringUtil.RTrim( Ddo_pessoatelefone_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Dropdownoptionstype", StringUtil.RTrim( Ddo_pessoatelefone_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_pessoatelefone_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Includesortasc", StringUtil.BoolToStr( Ddo_pessoatelefone_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Includesortdsc", StringUtil.BoolToStr( Ddo_pessoatelefone_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Sortedstatus", StringUtil.RTrim( Ddo_pessoatelefone_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Includefilter", StringUtil.BoolToStr( Ddo_pessoatelefone_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Includedatalist", StringUtil.BoolToStr( Ddo_pessoatelefone_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Sortasc", StringUtil.RTrim( Ddo_pessoatelefone_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Sortdsc", StringUtil.RTrim( Ddo_pessoatelefone_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Cleanfilter", StringUtil.RTrim( Ddo_pessoatelefone_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Searchbuttontext", StringUtil.RTrim( Ddo_pessoatelefone_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Caption", StringUtil.RTrim( Ddo_pessoaemail_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Tooltip", StringUtil.RTrim( Ddo_pessoaemail_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Cls", StringUtil.RTrim( Ddo_pessoaemail_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Dropdownoptionstype", StringUtil.RTrim( Ddo_pessoaemail_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_pessoaemail_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Includesortasc", StringUtil.BoolToStr( Ddo_pessoaemail_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Includesortdsc", StringUtil.BoolToStr( Ddo_pessoaemail_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Sortedstatus", StringUtil.RTrim( Ddo_pessoaemail_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Includefilter", StringUtil.BoolToStr( Ddo_pessoaemail_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Includedatalist", StringUtil.BoolToStr( Ddo_pessoaemail_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Sortasc", StringUtil.RTrim( Ddo_pessoaemail_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Sortdsc", StringUtil.RTrim( Ddo_pessoaemail_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Cleanfilter", StringUtil.RTrim( Ddo_pessoaemail_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Searchbuttontext", StringUtil.RTrim( Ddo_pessoaemail_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASEXO_Caption", StringUtil.RTrim( Ddo_pessoasexo_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASEXO_Tooltip", StringUtil.RTrim( Ddo_pessoasexo_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASEXO_Cls", StringUtil.RTrim( Ddo_pessoasexo_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASEXO_Dropdownoptionstype", StringUtil.RTrim( Ddo_pessoasexo_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASEXO_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_pessoasexo_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASEXO_Includesortasc", StringUtil.BoolToStr( Ddo_pessoasexo_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASEXO_Includesortdsc", StringUtil.BoolToStr( Ddo_pessoasexo_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASEXO_Sortedstatus", StringUtil.RTrim( Ddo_pessoasexo_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASEXO_Includefilter", StringUtil.BoolToStr( Ddo_pessoasexo_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASEXO_Includedatalist", StringUtil.BoolToStr( Ddo_pessoasexo_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASEXO_Sortasc", StringUtil.RTrim( Ddo_pessoasexo_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASEXO_Sortdsc", StringUtil.RTrim( Ddo_pessoasexo_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASEXO_Cleanfilter", StringUtil.RTrim( Ddo_pessoasexo_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASEXO_Searchbuttontext", StringUtil.RTrim( Ddo_pessoasexo_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Caption", StringUtil.RTrim( Ddo_pessoasituacao_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Tooltip", StringUtil.RTrim( Ddo_pessoasituacao_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Cls", StringUtil.RTrim( Ddo_pessoasituacao_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Dropdownoptionstype", StringUtil.RTrim( Ddo_pessoasituacao_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_pessoasituacao_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Includesortasc", StringUtil.BoolToStr( Ddo_pessoasituacao_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Includesortdsc", StringUtil.BoolToStr( Ddo_pessoasituacao_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Sortedstatus", StringUtil.RTrim( Ddo_pessoasituacao_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Includefilter", StringUtil.BoolToStr( Ddo_pessoasituacao_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Includedatalist", StringUtil.BoolToStr( Ddo_pessoasituacao_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Sortasc", StringUtil.RTrim( Ddo_pessoasituacao_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Sortdsc", StringUtil.RTrim( Ddo_pessoasituacao_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Cleanfilter", StringUtil.RTrim( Ddo_pessoasituacao_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Searchbuttontext", StringUtil.RTrim( Ddo_pessoasituacao_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Activeeventkey", StringUtil.RTrim( Ddo_pessoaid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Activeeventkey", StringUtil.RTrim( Ddo_pessoanome_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAENDERECO_Activeeventkey", StringUtil.RTrim( Ddo_pessoaendereco_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Activeeventkey", StringUtil.RTrim( Ddo_pessoatelefone_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Activeeventkey", StringUtil.RTrim( Ddo_pessoaemail_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASEXO_Activeeventkey", StringUtil.RTrim( Ddo_pessoasexo_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Activeeventkey", StringUtil.RTrim( Ddo_pessoasituacao_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAID_Activeeventkey", StringUtil.RTrim( Ddo_pessoaid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOANOME_Activeeventkey", StringUtil.RTrim( Ddo_pessoanome_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAENDERECO_Activeeventkey", StringUtil.RTrim( Ddo_pessoaendereco_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOATELEFONE_Activeeventkey", StringUtil.RTrim( Ddo_pessoatelefone_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOAEMAIL_Activeeventkey", StringUtil.RTrim( Ddo_pessoaemail_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASEXO_Activeeventkey", StringUtil.RTrim( Ddo_pessoasexo_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PESSOASITUACAO_Activeeventkey", StringUtil.RTrim( Ddo_pessoasituacao_Activeeventkey));
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
            WE0N2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0N2( ) ;
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
         return formatLink("pessoaprompt.aspx") + "?" + UrlEncode("" +AV29InOutPessoaId) ;
      }

      public override String GetPgmname( )
      {
         return "PessoaPrompt" ;
      }

      public override String GetPgmdesc( )
      {
         return "Consulta de Pessoa" ;
      }

      protected void WB0N0( )
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
            wb_table1_14_0N2( true) ;
         }
         else
         {
            wb_table1_14_0N2( false) ;
         }
         return  ;
      }

      protected void wb_table1_14_0N2e( bool wbgen )
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
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"23\">") ;
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
               if ( edtPessoaId_Titleformat == 0 )
               {
                  context.SendWebValue( edtPessoaId_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtPessoaId_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtPessoaNome_Titleformat == 0 )
               {
                  context.SendWebValue( edtPessoaNome_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtPessoaNome_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtPessoaEndereco_Titleformat == 0 )
               {
                  context.SendWebValue( edtPessoaEndereco_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtPessoaEndereco_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtPessoaTelefone_Titleformat == 0 )
               {
                  context.SendWebValue( edtPessoaTelefone_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtPessoaTelefone_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtPessoaEmail_Titleformat == 0 )
               {
                  context.SendWebValue( edtPessoaEmail_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtPessoaEmail_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( cmbPessoaSexo_Titleformat == 0 )
               {
                  context.SendWebValue( cmbPessoaSexo.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( cmbPessoaSexo.Title.Text) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"AttributeCheckBox"+"\" "+" style=\""+""+""+"\" "+">") ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV28Select));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavSelect_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1PessoaId), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtPessoaId_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPessoaId_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A2PessoaNome);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtPessoaNome_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPessoaNome_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A3PessoaEndereco);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtPessoaEndereco_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPessoaEndereco_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A4PessoaTelefone);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtPessoaTelefone_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPessoaTelefone_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A5PessoaEmail);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtPessoaEmail_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPessoaEmail_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A6PessoaSexo));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( cmbPessoaSexo.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbPessoaSexo_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.BoolToStr( A7PessoaSituacao));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( chkPessoaSituacao.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkPessoaSituacao_Titleformat), 4, 0, ".", "")));
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
         if ( wbEnd == 23 )
         {
            wbEnd = 0;
            nRC_GXsfl_23 = (short)(nGXsfl_23_idx-1);
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV26GridCurrentPage);
            ucGridpaginationbar.SetProperty("PageCount", AV27GridPageCount);
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
            ucDdo_pessoaid.SetProperty("IncludeDataList", Ddo_pessoaid_Includedatalist);
            ucDdo_pessoaid.SetProperty("SortASC", Ddo_pessoaid_Sortasc);
            ucDdo_pessoaid.SetProperty("SortDSC", Ddo_pessoaid_Sortdsc);
            ucDdo_pessoaid.SetProperty("CleanFilter", Ddo_pessoaid_Cleanfilter);
            ucDdo_pessoaid.SetProperty("SearchButtonText", Ddo_pessoaid_Searchbuttontext);
            ucDdo_pessoaid.SetProperty("DropDownOptionsTitleSettingsIcons", AV24DDO_TitleSettingsIcons);
            ucDdo_pessoaid.SetProperty("DropDownOptionsData", AV10PessoaIdTitleFilterData);
            ucDdo_pessoaid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_pessoaid_Internalname, "DDO_PESSOAIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_23_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_pessoaidtitlecontrolidtoreplace_Internalname, AV11ddo_PessoaIdTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", 0, edtavDdo_pessoaidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_PessoaPrompt.htm");
            /* User Defined Control */
            ucDdo_pessoanome.SetProperty("Caption", Ddo_pessoanome_Caption);
            ucDdo_pessoanome.SetProperty("Tooltip", Ddo_pessoanome_Tooltip);
            ucDdo_pessoanome.SetProperty("Cls", Ddo_pessoanome_Cls);
            ucDdo_pessoanome.SetProperty("DropDownOptionsType", Ddo_pessoanome_Dropdownoptionstype);
            ucDdo_pessoanome.SetProperty("IncludeSortASC", Ddo_pessoanome_Includesortasc);
            ucDdo_pessoanome.SetProperty("IncludeSortDSC", Ddo_pessoanome_Includesortdsc);
            ucDdo_pessoanome.SetProperty("IncludeFilter", Ddo_pessoanome_Includefilter);
            ucDdo_pessoanome.SetProperty("IncludeDataList", Ddo_pessoanome_Includedatalist);
            ucDdo_pessoanome.SetProperty("SortASC", Ddo_pessoanome_Sortasc);
            ucDdo_pessoanome.SetProperty("SortDSC", Ddo_pessoanome_Sortdsc);
            ucDdo_pessoanome.SetProperty("CleanFilter", Ddo_pessoanome_Cleanfilter);
            ucDdo_pessoanome.SetProperty("SearchButtonText", Ddo_pessoanome_Searchbuttontext);
            ucDdo_pessoanome.SetProperty("DropDownOptionsTitleSettingsIcons", AV24DDO_TitleSettingsIcons);
            ucDdo_pessoanome.SetProperty("DropDownOptionsData", AV12PessoaNomeTitleFilterData);
            ucDdo_pessoanome.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_pessoanome_Internalname, "DDO_PESSOANOMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'',false,'" + sGXsfl_23_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_pessoanometitlecontrolidtoreplace_Internalname, AV13ddo_PessoaNomeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,41);\"", 0, edtavDdo_pessoanometitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_PessoaPrompt.htm");
            /* User Defined Control */
            ucDdo_pessoaendereco.SetProperty("Caption", Ddo_pessoaendereco_Caption);
            ucDdo_pessoaendereco.SetProperty("Tooltip", Ddo_pessoaendereco_Tooltip);
            ucDdo_pessoaendereco.SetProperty("Cls", Ddo_pessoaendereco_Cls);
            ucDdo_pessoaendereco.SetProperty("DropDownOptionsType", Ddo_pessoaendereco_Dropdownoptionstype);
            ucDdo_pessoaendereco.SetProperty("IncludeSortASC", Ddo_pessoaendereco_Includesortasc);
            ucDdo_pessoaendereco.SetProperty("IncludeSortDSC", Ddo_pessoaendereco_Includesortdsc);
            ucDdo_pessoaendereco.SetProperty("IncludeFilter", Ddo_pessoaendereco_Includefilter);
            ucDdo_pessoaendereco.SetProperty("IncludeDataList", Ddo_pessoaendereco_Includedatalist);
            ucDdo_pessoaendereco.SetProperty("SortASC", Ddo_pessoaendereco_Sortasc);
            ucDdo_pessoaendereco.SetProperty("SortDSC", Ddo_pessoaendereco_Sortdsc);
            ucDdo_pessoaendereco.SetProperty("CleanFilter", Ddo_pessoaendereco_Cleanfilter);
            ucDdo_pessoaendereco.SetProperty("SearchButtonText", Ddo_pessoaendereco_Searchbuttontext);
            ucDdo_pessoaendereco.SetProperty("DropDownOptionsTitleSettingsIcons", AV24DDO_TitleSettingsIcons);
            ucDdo_pessoaendereco.SetProperty("DropDownOptionsData", AV14PessoaEnderecoTitleFilterData);
            ucDdo_pessoaendereco.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_pessoaendereco_Internalname, "DDO_PESSOAENDERECOContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'" + sGXsfl_23_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_pessoaenderecotitlecontrolidtoreplace_Internalname, AV15ddo_PessoaEnderecoTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", 0, edtavDdo_pessoaenderecotitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_PessoaPrompt.htm");
            /* User Defined Control */
            ucDdo_pessoatelefone.SetProperty("Caption", Ddo_pessoatelefone_Caption);
            ucDdo_pessoatelefone.SetProperty("Tooltip", Ddo_pessoatelefone_Tooltip);
            ucDdo_pessoatelefone.SetProperty("Cls", Ddo_pessoatelefone_Cls);
            ucDdo_pessoatelefone.SetProperty("DropDownOptionsType", Ddo_pessoatelefone_Dropdownoptionstype);
            ucDdo_pessoatelefone.SetProperty("IncludeSortASC", Ddo_pessoatelefone_Includesortasc);
            ucDdo_pessoatelefone.SetProperty("IncludeSortDSC", Ddo_pessoatelefone_Includesortdsc);
            ucDdo_pessoatelefone.SetProperty("IncludeFilter", Ddo_pessoatelefone_Includefilter);
            ucDdo_pessoatelefone.SetProperty("IncludeDataList", Ddo_pessoatelefone_Includedatalist);
            ucDdo_pessoatelefone.SetProperty("SortASC", Ddo_pessoatelefone_Sortasc);
            ucDdo_pessoatelefone.SetProperty("SortDSC", Ddo_pessoatelefone_Sortdsc);
            ucDdo_pessoatelefone.SetProperty("CleanFilter", Ddo_pessoatelefone_Cleanfilter);
            ucDdo_pessoatelefone.SetProperty("SearchButtonText", Ddo_pessoatelefone_Searchbuttontext);
            ucDdo_pessoatelefone.SetProperty("DropDownOptionsTitleSettingsIcons", AV24DDO_TitleSettingsIcons);
            ucDdo_pessoatelefone.SetProperty("DropDownOptionsData", AV16PessoaTelefoneTitleFilterData);
            ucDdo_pessoatelefone.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_pessoatelefone_Internalname, "DDO_PESSOATELEFONEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'" + sGXsfl_23_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_pessoatelefonetitlecontrolidtoreplace_Internalname, AV17ddo_PessoaTelefoneTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,45);\"", 0, edtavDdo_pessoatelefonetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_PessoaPrompt.htm");
            /* User Defined Control */
            ucDdo_pessoaemail.SetProperty("Caption", Ddo_pessoaemail_Caption);
            ucDdo_pessoaemail.SetProperty("Tooltip", Ddo_pessoaemail_Tooltip);
            ucDdo_pessoaemail.SetProperty("Cls", Ddo_pessoaemail_Cls);
            ucDdo_pessoaemail.SetProperty("DropDownOptionsType", Ddo_pessoaemail_Dropdownoptionstype);
            ucDdo_pessoaemail.SetProperty("IncludeSortASC", Ddo_pessoaemail_Includesortasc);
            ucDdo_pessoaemail.SetProperty("IncludeSortDSC", Ddo_pessoaemail_Includesortdsc);
            ucDdo_pessoaemail.SetProperty("IncludeFilter", Ddo_pessoaemail_Includefilter);
            ucDdo_pessoaemail.SetProperty("IncludeDataList", Ddo_pessoaemail_Includedatalist);
            ucDdo_pessoaemail.SetProperty("SortASC", Ddo_pessoaemail_Sortasc);
            ucDdo_pessoaemail.SetProperty("SortDSC", Ddo_pessoaemail_Sortdsc);
            ucDdo_pessoaemail.SetProperty("CleanFilter", Ddo_pessoaemail_Cleanfilter);
            ucDdo_pessoaemail.SetProperty("SearchButtonText", Ddo_pessoaemail_Searchbuttontext);
            ucDdo_pessoaemail.SetProperty("DropDownOptionsTitleSettingsIcons", AV24DDO_TitleSettingsIcons);
            ucDdo_pessoaemail.SetProperty("DropDownOptionsData", AV18PessoaEmailTitleFilterData);
            ucDdo_pessoaemail.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_pessoaemail_Internalname, "DDO_PESSOAEMAILContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'" + sGXsfl_23_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_pessoaemailtitlecontrolidtoreplace_Internalname, AV19ddo_PessoaEmailTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,47);\"", 0, edtavDdo_pessoaemailtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_PessoaPrompt.htm");
            /* User Defined Control */
            ucDdo_pessoasexo.SetProperty("Caption", Ddo_pessoasexo_Caption);
            ucDdo_pessoasexo.SetProperty("Tooltip", Ddo_pessoasexo_Tooltip);
            ucDdo_pessoasexo.SetProperty("Cls", Ddo_pessoasexo_Cls);
            ucDdo_pessoasexo.SetProperty("DropDownOptionsType", Ddo_pessoasexo_Dropdownoptionstype);
            ucDdo_pessoasexo.SetProperty("IncludeSortASC", Ddo_pessoasexo_Includesortasc);
            ucDdo_pessoasexo.SetProperty("IncludeSortDSC", Ddo_pessoasexo_Includesortdsc);
            ucDdo_pessoasexo.SetProperty("IncludeFilter", Ddo_pessoasexo_Includefilter);
            ucDdo_pessoasexo.SetProperty("IncludeDataList", Ddo_pessoasexo_Includedatalist);
            ucDdo_pessoasexo.SetProperty("SortASC", Ddo_pessoasexo_Sortasc);
            ucDdo_pessoasexo.SetProperty("SortDSC", Ddo_pessoasexo_Sortdsc);
            ucDdo_pessoasexo.SetProperty("CleanFilter", Ddo_pessoasexo_Cleanfilter);
            ucDdo_pessoasexo.SetProperty("SearchButtonText", Ddo_pessoasexo_Searchbuttontext);
            ucDdo_pessoasexo.SetProperty("DropDownOptionsTitleSettingsIcons", AV24DDO_TitleSettingsIcons);
            ucDdo_pessoasexo.SetProperty("DropDownOptionsData", AV20PessoaSexoTitleFilterData);
            ucDdo_pessoasexo.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_pessoasexo_Internalname, "DDO_PESSOASEXOContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'" + sGXsfl_23_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_pessoasexotitlecontrolidtoreplace_Internalname, AV21ddo_PessoaSexoTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", 0, edtavDdo_pessoasexotitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_PessoaPrompt.htm");
            /* User Defined Control */
            ucDdo_pessoasituacao.SetProperty("Caption", Ddo_pessoasituacao_Caption);
            ucDdo_pessoasituacao.SetProperty("Tooltip", Ddo_pessoasituacao_Tooltip);
            ucDdo_pessoasituacao.SetProperty("Cls", Ddo_pessoasituacao_Cls);
            ucDdo_pessoasituacao.SetProperty("DropDownOptionsType", Ddo_pessoasituacao_Dropdownoptionstype);
            ucDdo_pessoasituacao.SetProperty("IncludeSortASC", Ddo_pessoasituacao_Includesortasc);
            ucDdo_pessoasituacao.SetProperty("IncludeSortDSC", Ddo_pessoasituacao_Includesortdsc);
            ucDdo_pessoasituacao.SetProperty("IncludeFilter", Ddo_pessoasituacao_Includefilter);
            ucDdo_pessoasituacao.SetProperty("IncludeDataList", Ddo_pessoasituacao_Includedatalist);
            ucDdo_pessoasituacao.SetProperty("SortASC", Ddo_pessoasituacao_Sortasc);
            ucDdo_pessoasituacao.SetProperty("SortDSC", Ddo_pessoasituacao_Sortdsc);
            ucDdo_pessoasituacao.SetProperty("CleanFilter", Ddo_pessoasituacao_Cleanfilter);
            ucDdo_pessoasituacao.SetProperty("SearchButtonText", Ddo_pessoasituacao_Searchbuttontext);
            ucDdo_pessoasituacao.SetProperty("DropDownOptionsTitleSettingsIcons", AV24DDO_TitleSettingsIcons);
            ucDdo_pessoasituacao.SetProperty("DropDownOptionsData", AV22PessoaSituacaoTitleFilterData);
            ucDdo_pessoasituacao.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_pessoasituacao_Internalname, "DDO_PESSOASITUACAOContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'" + sGXsfl_23_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_pessoasituacaotitlecontrolidtoreplace_Internalname, AV23ddo_PessoaSituacaoTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,51);\"", 0, edtavDdo_pessoasituacaotitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_PessoaPrompt.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities_f5", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'" + sGXsfl_23_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8OrderedBy), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV8OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PessoaPrompt.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'" + sGXsfl_23_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV9OrderedDsc), StringUtil.BoolToStr( AV9OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_PessoaPrompt.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 23 )
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

      protected void START0N2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_2-131213", 0) ;
            Form.Meta.addItem("description", "Consulta de Pessoa", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP0N0( ) ;
      }

      protected void WS0N2( )
      {
         START0N2( ) ;
         EVT0N2( ) ;
      }

      protected void EVT0N2( )
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
                              E110N2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E120N2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PESSOAID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E130N2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PESSOANOME.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E140N2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PESSOAENDERECO.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E150N2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PESSOATELEFONE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E160N2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PESSOAEMAIL.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E170N2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PESSOASEXO.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E180N2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PESSOASITUACAO.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E190N2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOCLEANFILTERS'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoCleanFilters' */
                              E200N2 ();
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
                              nGXsfl_23_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_23_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_23_idx), 4, 0)), 4, "0");
                              SubsflControlProps_232( ) ;
                              AV28Select = cgiGet( edtavSelect_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV28Select)) ? AV32Select_GXI : context.convertURL( context.PathToRelativeUrl( AV28Select))), !bGXsfl_23_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "SrcSet", context.GetImageSrcSet( AV28Select), true);
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
                                    E210N2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E220N2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E230N2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Orderedby Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ",", ".") != Convert.ToDecimal( AV8OrderedBy )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ordereddsc Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV9OrderedDsc )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: Enter */
                                          E240N2 ();
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

      protected void WE0N2( )
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

      protected void PA0N2( )
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
               GX_FocusControl = edtavDdo_pessoaidtitlecontrolidtoreplace_Internalname;
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
         SubsflControlProps_232( ) ;
         while ( nGXsfl_23_idx <= nRC_GXsfl_23 )
         {
            sendrow_232( ) ;
            nGXsfl_23_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_23_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_23_idx+1));
            sGXsfl_23_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_23_idx), 4, 0)), 4, "0");
            SubsflControlProps_232( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       short AV8OrderedBy ,
                                       bool AV9OrderedDsc ,
                                       String AV11ddo_PessoaIdTitleControlIdToReplace ,
                                       String AV13ddo_PessoaNomeTitleControlIdToReplace ,
                                       String AV15ddo_PessoaEnderecoTitleControlIdToReplace ,
                                       String AV17ddo_PessoaTelefoneTitleControlIdToReplace ,
                                       String AV19ddo_PessoaEmailTitleControlIdToReplace ,
                                       String AV21ddo_PessoaSexoTitleControlIdToReplace ,
                                       String AV23ddo_PessoaSituacaoTitleControlIdToReplace )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF0N2( ) ;
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
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF0N2( ) ;
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

      protected void RF0N2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 23;
         /* Execute user event: Refresh */
         E220N2 ();
         nGXsfl_23_idx = 1;
         sGXsfl_23_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_23_idx), 4, 0)), 4, "0");
         SubsflControlProps_232( ) ;
         bGXsfl_23_Refreshing = true;
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
            SubsflControlProps_232( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV8OrderedBy ,
                                                 AV9OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            /* Using cursor H000N2 */
            pr_default.execute(0, new Object[] {GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_23_idx = 1;
            sGXsfl_23_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_23_idx), 4, 0)), 4, "0");
            SubsflControlProps_232( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A7PessoaSituacao = H000N2_A7PessoaSituacao[0];
               A6PessoaSexo = H000N2_A6PessoaSexo[0];
               A5PessoaEmail = H000N2_A5PessoaEmail[0];
               A4PessoaTelefone = H000N2_A4PessoaTelefone[0];
               A3PessoaEndereco = H000N2_A3PessoaEndereco[0];
               A2PessoaNome = H000N2_A2PessoaNome[0];
               A1PessoaId = H000N2_A1PessoaId[0];
               E230N2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 23;
            WB0N0( ) ;
         }
         bGXsfl_23_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes0N2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_PESSOAID"+"_"+sGXsfl_23_idx, GetSecureSignedToken( sGXsfl_23_idx, context.localUtil.Format( (decimal)(A1PessoaId), "ZZZ9"), context));
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
                                              AV8OrderedBy ,
                                              AV9OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         /* Using cursor H000N3 */
         pr_default.execute(1);
         GRID_nRecordCount = H000N3_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV8OrderedBy, AV9OrderedDsc, AV11ddo_PessoaIdTitleControlIdToReplace, AV13ddo_PessoaNomeTitleControlIdToReplace, AV15ddo_PessoaEnderecoTitleControlIdToReplace, AV17ddo_PessoaTelefoneTitleControlIdToReplace, AV19ddo_PessoaEmailTitleControlIdToReplace, AV21ddo_PessoaSexoTitleControlIdToReplace, AV23ddo_PessoaSituacaoTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV8OrderedBy, AV9OrderedDsc, AV11ddo_PessoaIdTitleControlIdToReplace, AV13ddo_PessoaNomeTitleControlIdToReplace, AV15ddo_PessoaEnderecoTitleControlIdToReplace, AV17ddo_PessoaTelefoneTitleControlIdToReplace, AV19ddo_PessoaEmailTitleControlIdToReplace, AV21ddo_PessoaSexoTitleControlIdToReplace, AV23ddo_PessoaSituacaoTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV8OrderedBy, AV9OrderedDsc, AV11ddo_PessoaIdTitleControlIdToReplace, AV13ddo_PessoaNomeTitleControlIdToReplace, AV15ddo_PessoaEnderecoTitleControlIdToReplace, AV17ddo_PessoaTelefoneTitleControlIdToReplace, AV19ddo_PessoaEmailTitleControlIdToReplace, AV21ddo_PessoaSexoTitleControlIdToReplace, AV23ddo_PessoaSituacaoTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV8OrderedBy, AV9OrderedDsc, AV11ddo_PessoaIdTitleControlIdToReplace, AV13ddo_PessoaNomeTitleControlIdToReplace, AV15ddo_PessoaEnderecoTitleControlIdToReplace, AV17ddo_PessoaTelefoneTitleControlIdToReplace, AV19ddo_PessoaEmailTitleControlIdToReplace, AV21ddo_PessoaSexoTitleControlIdToReplace, AV23ddo_PessoaSituacaoTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV8OrderedBy, AV9OrderedDsc, AV11ddo_PessoaIdTitleControlIdToReplace, AV13ddo_PessoaNomeTitleControlIdToReplace, AV15ddo_PessoaEnderecoTitleControlIdToReplace, AV17ddo_PessoaTelefoneTitleControlIdToReplace, AV19ddo_PessoaEmailTitleControlIdToReplace, AV21ddo_PessoaSexoTitleControlIdToReplace, AV23ddo_PessoaSituacaoTitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP0N0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E210N2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV24DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vPESSOAIDTITLEFILTERDATA"), AV10PessoaIdTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPESSOANOMETITLEFILTERDATA"), AV12PessoaNomeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPESSOAENDERECOTITLEFILTERDATA"), AV14PessoaEnderecoTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPESSOATELEFONETITLEFILTERDATA"), AV16PessoaTelefoneTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPESSOAEMAILTITLEFILTERDATA"), AV18PessoaEmailTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPESSOASEXOTITLEFILTERDATA"), AV20PessoaSexoTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPESSOASITUACAOTITLEFILTERDATA"), AV22PessoaSituacaoTitleFilterData);
            /* Read variables values. */
            AV11ddo_PessoaIdTitleControlIdToReplace = cgiGet( edtavDdo_pessoaidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11ddo_PessoaIdTitleControlIdToReplace", AV11ddo_PessoaIdTitleControlIdToReplace);
            AV13ddo_PessoaNomeTitleControlIdToReplace = cgiGet( edtavDdo_pessoanometitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13ddo_PessoaNomeTitleControlIdToReplace", AV13ddo_PessoaNomeTitleControlIdToReplace);
            AV15ddo_PessoaEnderecoTitleControlIdToReplace = cgiGet( edtavDdo_pessoaenderecotitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15ddo_PessoaEnderecoTitleControlIdToReplace", AV15ddo_PessoaEnderecoTitleControlIdToReplace);
            AV17ddo_PessoaTelefoneTitleControlIdToReplace = cgiGet( edtavDdo_pessoatelefonetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17ddo_PessoaTelefoneTitleControlIdToReplace", AV17ddo_PessoaTelefoneTitleControlIdToReplace);
            AV19ddo_PessoaEmailTitleControlIdToReplace = cgiGet( edtavDdo_pessoaemailtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_PessoaEmailTitleControlIdToReplace", AV19ddo_PessoaEmailTitleControlIdToReplace);
            AV21ddo_PessoaSexoTitleControlIdToReplace = cgiGet( edtavDdo_pessoasexotitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21ddo_PessoaSexoTitleControlIdToReplace", AV21ddo_PessoaSexoTitleControlIdToReplace);
            AV23ddo_PessoaSituacaoTitleControlIdToReplace = cgiGet( edtavDdo_pessoasituacaotitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_PessoaSituacaoTitleControlIdToReplace", AV23ddo_PessoaSituacaoTitleControlIdToReplace);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vORDEREDBY");
               GX_FocusControl = edtavOrderedby_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV8OrderedBy = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8OrderedBy), 4, 0)));
            }
            else
            {
               AV8OrderedBy = (short)(context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8OrderedBy), 4, 0)));
            }
            AV9OrderedDsc = StringUtil.StrToBool( cgiGet( edtavOrdereddsc_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9OrderedDsc", AV9OrderedDsc);
            /* Read saved values. */
            nRC_GXsfl_23 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_23"), ",", "."));
            AV26GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ",", "."));
            AV27GridPageCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGECOUNT"), ",", "."));
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
            Ddo_pessoaid_Caption = cgiGet( "DDO_PESSOAID_Caption");
            Ddo_pessoaid_Tooltip = cgiGet( "DDO_PESSOAID_Tooltip");
            Ddo_pessoaid_Cls = cgiGet( "DDO_PESSOAID_Cls");
            Ddo_pessoaid_Dropdownoptionstype = cgiGet( "DDO_PESSOAID_Dropdownoptionstype");
            Ddo_pessoaid_Titlecontrolidtoreplace = cgiGet( "DDO_PESSOAID_Titlecontrolidtoreplace");
            Ddo_pessoaid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PESSOAID_Includesortasc"));
            Ddo_pessoaid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PESSOAID_Includesortdsc"));
            Ddo_pessoaid_Sortedstatus = cgiGet( "DDO_PESSOAID_Sortedstatus");
            Ddo_pessoaid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PESSOAID_Includefilter"));
            Ddo_pessoaid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PESSOAID_Includedatalist"));
            Ddo_pessoaid_Sortasc = cgiGet( "DDO_PESSOAID_Sortasc");
            Ddo_pessoaid_Sortdsc = cgiGet( "DDO_PESSOAID_Sortdsc");
            Ddo_pessoaid_Cleanfilter = cgiGet( "DDO_PESSOAID_Cleanfilter");
            Ddo_pessoaid_Searchbuttontext = cgiGet( "DDO_PESSOAID_Searchbuttontext");
            Ddo_pessoanome_Caption = cgiGet( "DDO_PESSOANOME_Caption");
            Ddo_pessoanome_Tooltip = cgiGet( "DDO_PESSOANOME_Tooltip");
            Ddo_pessoanome_Cls = cgiGet( "DDO_PESSOANOME_Cls");
            Ddo_pessoanome_Dropdownoptionstype = cgiGet( "DDO_PESSOANOME_Dropdownoptionstype");
            Ddo_pessoanome_Titlecontrolidtoreplace = cgiGet( "DDO_PESSOANOME_Titlecontrolidtoreplace");
            Ddo_pessoanome_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PESSOANOME_Includesortasc"));
            Ddo_pessoanome_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PESSOANOME_Includesortdsc"));
            Ddo_pessoanome_Sortedstatus = cgiGet( "DDO_PESSOANOME_Sortedstatus");
            Ddo_pessoanome_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PESSOANOME_Includefilter"));
            Ddo_pessoanome_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PESSOANOME_Includedatalist"));
            Ddo_pessoanome_Sortasc = cgiGet( "DDO_PESSOANOME_Sortasc");
            Ddo_pessoanome_Sortdsc = cgiGet( "DDO_PESSOANOME_Sortdsc");
            Ddo_pessoanome_Cleanfilter = cgiGet( "DDO_PESSOANOME_Cleanfilter");
            Ddo_pessoanome_Searchbuttontext = cgiGet( "DDO_PESSOANOME_Searchbuttontext");
            Ddo_pessoaendereco_Caption = cgiGet( "DDO_PESSOAENDERECO_Caption");
            Ddo_pessoaendereco_Tooltip = cgiGet( "DDO_PESSOAENDERECO_Tooltip");
            Ddo_pessoaendereco_Cls = cgiGet( "DDO_PESSOAENDERECO_Cls");
            Ddo_pessoaendereco_Dropdownoptionstype = cgiGet( "DDO_PESSOAENDERECO_Dropdownoptionstype");
            Ddo_pessoaendereco_Titlecontrolidtoreplace = cgiGet( "DDO_PESSOAENDERECO_Titlecontrolidtoreplace");
            Ddo_pessoaendereco_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PESSOAENDERECO_Includesortasc"));
            Ddo_pessoaendereco_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PESSOAENDERECO_Includesortdsc"));
            Ddo_pessoaendereco_Sortedstatus = cgiGet( "DDO_PESSOAENDERECO_Sortedstatus");
            Ddo_pessoaendereco_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PESSOAENDERECO_Includefilter"));
            Ddo_pessoaendereco_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PESSOAENDERECO_Includedatalist"));
            Ddo_pessoaendereco_Sortasc = cgiGet( "DDO_PESSOAENDERECO_Sortasc");
            Ddo_pessoaendereco_Sortdsc = cgiGet( "DDO_PESSOAENDERECO_Sortdsc");
            Ddo_pessoaendereco_Cleanfilter = cgiGet( "DDO_PESSOAENDERECO_Cleanfilter");
            Ddo_pessoaendereco_Searchbuttontext = cgiGet( "DDO_PESSOAENDERECO_Searchbuttontext");
            Ddo_pessoatelefone_Caption = cgiGet( "DDO_PESSOATELEFONE_Caption");
            Ddo_pessoatelefone_Tooltip = cgiGet( "DDO_PESSOATELEFONE_Tooltip");
            Ddo_pessoatelefone_Cls = cgiGet( "DDO_PESSOATELEFONE_Cls");
            Ddo_pessoatelefone_Dropdownoptionstype = cgiGet( "DDO_PESSOATELEFONE_Dropdownoptionstype");
            Ddo_pessoatelefone_Titlecontrolidtoreplace = cgiGet( "DDO_PESSOATELEFONE_Titlecontrolidtoreplace");
            Ddo_pessoatelefone_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PESSOATELEFONE_Includesortasc"));
            Ddo_pessoatelefone_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PESSOATELEFONE_Includesortdsc"));
            Ddo_pessoatelefone_Sortedstatus = cgiGet( "DDO_PESSOATELEFONE_Sortedstatus");
            Ddo_pessoatelefone_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PESSOATELEFONE_Includefilter"));
            Ddo_pessoatelefone_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PESSOATELEFONE_Includedatalist"));
            Ddo_pessoatelefone_Sortasc = cgiGet( "DDO_PESSOATELEFONE_Sortasc");
            Ddo_pessoatelefone_Sortdsc = cgiGet( "DDO_PESSOATELEFONE_Sortdsc");
            Ddo_pessoatelefone_Cleanfilter = cgiGet( "DDO_PESSOATELEFONE_Cleanfilter");
            Ddo_pessoatelefone_Searchbuttontext = cgiGet( "DDO_PESSOATELEFONE_Searchbuttontext");
            Ddo_pessoaemail_Caption = cgiGet( "DDO_PESSOAEMAIL_Caption");
            Ddo_pessoaemail_Tooltip = cgiGet( "DDO_PESSOAEMAIL_Tooltip");
            Ddo_pessoaemail_Cls = cgiGet( "DDO_PESSOAEMAIL_Cls");
            Ddo_pessoaemail_Dropdownoptionstype = cgiGet( "DDO_PESSOAEMAIL_Dropdownoptionstype");
            Ddo_pessoaemail_Titlecontrolidtoreplace = cgiGet( "DDO_PESSOAEMAIL_Titlecontrolidtoreplace");
            Ddo_pessoaemail_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PESSOAEMAIL_Includesortasc"));
            Ddo_pessoaemail_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PESSOAEMAIL_Includesortdsc"));
            Ddo_pessoaemail_Sortedstatus = cgiGet( "DDO_PESSOAEMAIL_Sortedstatus");
            Ddo_pessoaemail_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PESSOAEMAIL_Includefilter"));
            Ddo_pessoaemail_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PESSOAEMAIL_Includedatalist"));
            Ddo_pessoaemail_Sortasc = cgiGet( "DDO_PESSOAEMAIL_Sortasc");
            Ddo_pessoaemail_Sortdsc = cgiGet( "DDO_PESSOAEMAIL_Sortdsc");
            Ddo_pessoaemail_Cleanfilter = cgiGet( "DDO_PESSOAEMAIL_Cleanfilter");
            Ddo_pessoaemail_Searchbuttontext = cgiGet( "DDO_PESSOAEMAIL_Searchbuttontext");
            Ddo_pessoasexo_Caption = cgiGet( "DDO_PESSOASEXO_Caption");
            Ddo_pessoasexo_Tooltip = cgiGet( "DDO_PESSOASEXO_Tooltip");
            Ddo_pessoasexo_Cls = cgiGet( "DDO_PESSOASEXO_Cls");
            Ddo_pessoasexo_Dropdownoptionstype = cgiGet( "DDO_PESSOASEXO_Dropdownoptionstype");
            Ddo_pessoasexo_Titlecontrolidtoreplace = cgiGet( "DDO_PESSOASEXO_Titlecontrolidtoreplace");
            Ddo_pessoasexo_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PESSOASEXO_Includesortasc"));
            Ddo_pessoasexo_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PESSOASEXO_Includesortdsc"));
            Ddo_pessoasexo_Sortedstatus = cgiGet( "DDO_PESSOASEXO_Sortedstatus");
            Ddo_pessoasexo_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PESSOASEXO_Includefilter"));
            Ddo_pessoasexo_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PESSOASEXO_Includedatalist"));
            Ddo_pessoasexo_Sortasc = cgiGet( "DDO_PESSOASEXO_Sortasc");
            Ddo_pessoasexo_Sortdsc = cgiGet( "DDO_PESSOASEXO_Sortdsc");
            Ddo_pessoasexo_Cleanfilter = cgiGet( "DDO_PESSOASEXO_Cleanfilter");
            Ddo_pessoasexo_Searchbuttontext = cgiGet( "DDO_PESSOASEXO_Searchbuttontext");
            Ddo_pessoasituacao_Caption = cgiGet( "DDO_PESSOASITUACAO_Caption");
            Ddo_pessoasituacao_Tooltip = cgiGet( "DDO_PESSOASITUACAO_Tooltip");
            Ddo_pessoasituacao_Cls = cgiGet( "DDO_PESSOASITUACAO_Cls");
            Ddo_pessoasituacao_Dropdownoptionstype = cgiGet( "DDO_PESSOASITUACAO_Dropdownoptionstype");
            Ddo_pessoasituacao_Titlecontrolidtoreplace = cgiGet( "DDO_PESSOASITUACAO_Titlecontrolidtoreplace");
            Ddo_pessoasituacao_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PESSOASITUACAO_Includesortasc"));
            Ddo_pessoasituacao_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PESSOASITUACAO_Includesortdsc"));
            Ddo_pessoasituacao_Sortedstatus = cgiGet( "DDO_PESSOASITUACAO_Sortedstatus");
            Ddo_pessoasituacao_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PESSOASITUACAO_Includefilter"));
            Ddo_pessoasituacao_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PESSOASITUACAO_Includedatalist"));
            Ddo_pessoasituacao_Sortasc = cgiGet( "DDO_PESSOASITUACAO_Sortasc");
            Ddo_pessoasituacao_Sortdsc = cgiGet( "DDO_PESSOASITUACAO_Sortdsc");
            Ddo_pessoasituacao_Cleanfilter = cgiGet( "DDO_PESSOASITUACAO_Cleanfilter");
            Ddo_pessoasituacao_Searchbuttontext = cgiGet( "DDO_PESSOASITUACAO_Searchbuttontext");
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ",", "."));
            Ddo_pessoaid_Activeeventkey = cgiGet( "DDO_PESSOAID_Activeeventkey");
            Ddo_pessoanome_Activeeventkey = cgiGet( "DDO_PESSOANOME_Activeeventkey");
            Ddo_pessoaendereco_Activeeventkey = cgiGet( "DDO_PESSOAENDERECO_Activeeventkey");
            Ddo_pessoatelefone_Activeeventkey = cgiGet( "DDO_PESSOATELEFONE_Activeeventkey");
            Ddo_pessoaemail_Activeeventkey = cgiGet( "DDO_PESSOAEMAIL_Activeeventkey");
            Ddo_pessoasexo_Activeeventkey = cgiGet( "DDO_PESSOASEXO_Activeeventkey");
            Ddo_pessoasituacao_Activeeventkey = cgiGet( "DDO_PESSOASITUACAO_Activeeventkey");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ",", ".") != Convert.ToDecimal( AV8OrderedBy )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV9OrderedDsc )
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
         E210N2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E210N2( )
      {
         /* Start Routine */
         subGrid_Rows = 10;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         Ddo_pessoaid_Titlecontrolidtoreplace = subGrid_Internalname+"_PessoaId";
         ucDdo_pessoaid.SendProperty(context, "", false, Ddo_pessoaid_Internalname, "TitleControlIdToReplace", Ddo_pessoaid_Titlecontrolidtoreplace);
         AV11ddo_PessoaIdTitleControlIdToReplace = Ddo_pessoaid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11ddo_PessoaIdTitleControlIdToReplace", AV11ddo_PessoaIdTitleControlIdToReplace);
         edtavDdo_pessoaidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_pessoaidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_pessoaidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_pessoanome_Titlecontrolidtoreplace = subGrid_Internalname+"_PessoaNome";
         ucDdo_pessoanome.SendProperty(context, "", false, Ddo_pessoanome_Internalname, "TitleControlIdToReplace", Ddo_pessoanome_Titlecontrolidtoreplace);
         AV13ddo_PessoaNomeTitleControlIdToReplace = Ddo_pessoanome_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13ddo_PessoaNomeTitleControlIdToReplace", AV13ddo_PessoaNomeTitleControlIdToReplace);
         edtavDdo_pessoanometitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_pessoanometitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_pessoanometitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_pessoaendereco_Titlecontrolidtoreplace = subGrid_Internalname+"_PessoaEndereco";
         ucDdo_pessoaendereco.SendProperty(context, "", false, Ddo_pessoaendereco_Internalname, "TitleControlIdToReplace", Ddo_pessoaendereco_Titlecontrolidtoreplace);
         AV15ddo_PessoaEnderecoTitleControlIdToReplace = Ddo_pessoaendereco_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15ddo_PessoaEnderecoTitleControlIdToReplace", AV15ddo_PessoaEnderecoTitleControlIdToReplace);
         edtavDdo_pessoaenderecotitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_pessoaenderecotitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_pessoaenderecotitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_pessoatelefone_Titlecontrolidtoreplace = subGrid_Internalname+"_PessoaTelefone";
         ucDdo_pessoatelefone.SendProperty(context, "", false, Ddo_pessoatelefone_Internalname, "TitleControlIdToReplace", Ddo_pessoatelefone_Titlecontrolidtoreplace);
         AV17ddo_PessoaTelefoneTitleControlIdToReplace = Ddo_pessoatelefone_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17ddo_PessoaTelefoneTitleControlIdToReplace", AV17ddo_PessoaTelefoneTitleControlIdToReplace);
         edtavDdo_pessoatelefonetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_pessoatelefonetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_pessoatelefonetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_pessoaemail_Titlecontrolidtoreplace = subGrid_Internalname+"_PessoaEmail";
         ucDdo_pessoaemail.SendProperty(context, "", false, Ddo_pessoaemail_Internalname, "TitleControlIdToReplace", Ddo_pessoaemail_Titlecontrolidtoreplace);
         AV19ddo_PessoaEmailTitleControlIdToReplace = Ddo_pessoaemail_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_PessoaEmailTitleControlIdToReplace", AV19ddo_PessoaEmailTitleControlIdToReplace);
         edtavDdo_pessoaemailtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_pessoaemailtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_pessoaemailtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_pessoasexo_Titlecontrolidtoreplace = subGrid_Internalname+"_PessoaSexo";
         ucDdo_pessoasexo.SendProperty(context, "", false, Ddo_pessoasexo_Internalname, "TitleControlIdToReplace", Ddo_pessoasexo_Titlecontrolidtoreplace);
         AV21ddo_PessoaSexoTitleControlIdToReplace = Ddo_pessoasexo_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21ddo_PessoaSexoTitleControlIdToReplace", AV21ddo_PessoaSexoTitleControlIdToReplace);
         edtavDdo_pessoasexotitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_pessoasexotitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_pessoasexotitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_pessoasituacao_Titlecontrolidtoreplace = subGrid_Internalname+"_PessoaSituacao";
         ucDdo_pessoasituacao.SendProperty(context, "", false, Ddo_pessoasituacao_Internalname, "TitleControlIdToReplace", Ddo_pessoasituacao_Titlecontrolidtoreplace);
         AV23ddo_PessoaSituacaoTitleControlIdToReplace = Ddo_pessoasituacao_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_PessoaSituacaoTitleControlIdToReplace", AV23ddo_PessoaSituacaoTitleControlIdToReplace);
         edtavDdo_pessoasituacaotitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_pessoasituacaotitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_pessoasituacaotitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = "Consulta de Pessoa";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         edtavOrderedby_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOrderedby_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrderedby_Visible), 5, 0)), true);
         if ( AV8OrderedBy < 1 )
         {
            AV8OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8OrderedBy), 4, 0)));
            /* Execute user subroutine: 'SETDDOSORTEDSTATUS' */
            S112 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
         edtavOrdereddsc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOrdereddsc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrdereddsc_Visible), 5, 0)), true);
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV24DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV24DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E220N2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV10PessoaIdTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV12PessoaNomeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV14PessoaEnderecoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV16PessoaTelefoneTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV18PessoaEmailTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20PessoaSexoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV22PessoaSituacaoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         edtPessoaId_Titleformat = 2;
         edtPessoaId_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Id", AV11ddo_PessoaIdTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPessoaId_Internalname, "Title", edtPessoaId_Title, !bGXsfl_23_Refreshing);
         edtPessoaNome_Titleformat = 2;
         edtPessoaNome_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Nome", AV13ddo_PessoaNomeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPessoaNome_Internalname, "Title", edtPessoaNome_Title, !bGXsfl_23_Refreshing);
         edtPessoaEndereco_Titleformat = 2;
         edtPessoaEndereco_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Endereço", AV15ddo_PessoaEnderecoTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPessoaEndereco_Internalname, "Title", edtPessoaEndereco_Title, !bGXsfl_23_Refreshing);
         edtPessoaTelefone_Titleformat = 2;
         edtPessoaTelefone_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Telefone", AV17ddo_PessoaTelefoneTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPessoaTelefone_Internalname, "Title", edtPessoaTelefone_Title, !bGXsfl_23_Refreshing);
         edtPessoaEmail_Titleformat = 2;
         edtPessoaEmail_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "E-mail", AV19ddo_PessoaEmailTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPessoaEmail_Internalname, "Title", edtPessoaEmail_Title, !bGXsfl_23_Refreshing);
         cmbPessoaSexo_Titleformat = 2;
         cmbPessoaSexo.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Sexo", AV21ddo_PessoaSexoTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPessoaSexo_Internalname, "Title", cmbPessoaSexo.Title.Text, !bGXsfl_23_Refreshing);
         chkPessoaSituacao_Titleformat = 2;
         chkPessoaSituacao.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Situação", AV23ddo_PessoaSituacaoTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkPessoaSituacao_Internalname, "Title", chkPessoaSituacao.Title.Text, !bGXsfl_23_Refreshing);
         AV26GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26GridCurrentPage), 10, 0)));
         AV27GridPageCount = subGrid_Pagecount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27GridPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV27GridPageCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10PessoaIdTitleFilterData", AV10PessoaIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12PessoaNomeTitleFilterData", AV12PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14PessoaEnderecoTitleFilterData", AV14PessoaEnderecoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16PessoaTelefoneTitleFilterData", AV16PessoaTelefoneTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18PessoaEmailTitleFilterData", AV18PessoaEmailTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20PessoaSexoTitleFilterData", AV20PessoaSexoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22PessoaSituacaoTitleFilterData", AV22PessoaSituacaoTitleFilterData);
      }

      protected void E110N2( )
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
            AV25PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV25PageToGo) ;
         }
      }

      protected void E120N2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E130N2( )
      {
         /* Ddo_pessoaid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_pessoaid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S122 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV8OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8OrderedBy), 4, 0)));
            AV9OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9OrderedDsc", AV9OrderedDsc);
            Ddo_pessoaid_Sortedstatus = "ASC";
            ucDdo_pessoaid.SendProperty(context, "", false, Ddo_pessoaid_Internalname, "SortedStatus", Ddo_pessoaid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pessoaid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S122 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV8OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8OrderedBy), 4, 0)));
            AV9OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9OrderedDsc", AV9OrderedDsc);
            Ddo_pessoaid_Sortedstatus = "DSC";
            ucDdo_pessoaid.SendProperty(context, "", false, Ddo_pessoaid_Internalname, "SortedStatus", Ddo_pessoaid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10PessoaIdTitleFilterData", AV10PessoaIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12PessoaNomeTitleFilterData", AV12PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14PessoaEnderecoTitleFilterData", AV14PessoaEnderecoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16PessoaTelefoneTitleFilterData", AV16PessoaTelefoneTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18PessoaEmailTitleFilterData", AV18PessoaEmailTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20PessoaSexoTitleFilterData", AV20PessoaSexoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22PessoaSituacaoTitleFilterData", AV22PessoaSituacaoTitleFilterData);
      }

      protected void E140N2( )
      {
         /* Ddo_pessoanome_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_pessoanome_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S122 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV8OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8OrderedBy), 4, 0)));
            AV9OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9OrderedDsc", AV9OrderedDsc);
            Ddo_pessoanome_Sortedstatus = "ASC";
            ucDdo_pessoanome.SendProperty(context, "", false, Ddo_pessoanome_Internalname, "SortedStatus", Ddo_pessoanome_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pessoanome_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S122 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV8OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8OrderedBy), 4, 0)));
            AV9OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9OrderedDsc", AV9OrderedDsc);
            Ddo_pessoanome_Sortedstatus = "DSC";
            ucDdo_pessoanome.SendProperty(context, "", false, Ddo_pessoanome_Internalname, "SortedStatus", Ddo_pessoanome_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10PessoaIdTitleFilterData", AV10PessoaIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12PessoaNomeTitleFilterData", AV12PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14PessoaEnderecoTitleFilterData", AV14PessoaEnderecoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16PessoaTelefoneTitleFilterData", AV16PessoaTelefoneTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18PessoaEmailTitleFilterData", AV18PessoaEmailTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20PessoaSexoTitleFilterData", AV20PessoaSexoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22PessoaSituacaoTitleFilterData", AV22PessoaSituacaoTitleFilterData);
      }

      protected void E150N2( )
      {
         /* Ddo_pessoaendereco_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_pessoaendereco_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S122 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV8OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8OrderedBy), 4, 0)));
            AV9OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9OrderedDsc", AV9OrderedDsc);
            Ddo_pessoaendereco_Sortedstatus = "ASC";
            ucDdo_pessoaendereco.SendProperty(context, "", false, Ddo_pessoaendereco_Internalname, "SortedStatus", Ddo_pessoaendereco_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pessoaendereco_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S122 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV8OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8OrderedBy), 4, 0)));
            AV9OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9OrderedDsc", AV9OrderedDsc);
            Ddo_pessoaendereco_Sortedstatus = "DSC";
            ucDdo_pessoaendereco.SendProperty(context, "", false, Ddo_pessoaendereco_Internalname, "SortedStatus", Ddo_pessoaendereco_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10PessoaIdTitleFilterData", AV10PessoaIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12PessoaNomeTitleFilterData", AV12PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14PessoaEnderecoTitleFilterData", AV14PessoaEnderecoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16PessoaTelefoneTitleFilterData", AV16PessoaTelefoneTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18PessoaEmailTitleFilterData", AV18PessoaEmailTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20PessoaSexoTitleFilterData", AV20PessoaSexoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22PessoaSituacaoTitleFilterData", AV22PessoaSituacaoTitleFilterData);
      }

      protected void E160N2( )
      {
         /* Ddo_pessoatelefone_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_pessoatelefone_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S122 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV8OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8OrderedBy), 4, 0)));
            AV9OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9OrderedDsc", AV9OrderedDsc);
            Ddo_pessoatelefone_Sortedstatus = "ASC";
            ucDdo_pessoatelefone.SendProperty(context, "", false, Ddo_pessoatelefone_Internalname, "SortedStatus", Ddo_pessoatelefone_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pessoatelefone_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S122 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV8OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8OrderedBy), 4, 0)));
            AV9OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9OrderedDsc", AV9OrderedDsc);
            Ddo_pessoatelefone_Sortedstatus = "DSC";
            ucDdo_pessoatelefone.SendProperty(context, "", false, Ddo_pessoatelefone_Internalname, "SortedStatus", Ddo_pessoatelefone_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10PessoaIdTitleFilterData", AV10PessoaIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12PessoaNomeTitleFilterData", AV12PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14PessoaEnderecoTitleFilterData", AV14PessoaEnderecoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16PessoaTelefoneTitleFilterData", AV16PessoaTelefoneTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18PessoaEmailTitleFilterData", AV18PessoaEmailTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20PessoaSexoTitleFilterData", AV20PessoaSexoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22PessoaSituacaoTitleFilterData", AV22PessoaSituacaoTitleFilterData);
      }

      protected void E170N2( )
      {
         /* Ddo_pessoaemail_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_pessoaemail_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S122 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV8OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8OrderedBy), 4, 0)));
            AV9OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9OrderedDsc", AV9OrderedDsc);
            Ddo_pessoaemail_Sortedstatus = "ASC";
            ucDdo_pessoaemail.SendProperty(context, "", false, Ddo_pessoaemail_Internalname, "SortedStatus", Ddo_pessoaemail_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pessoaemail_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S122 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV8OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8OrderedBy), 4, 0)));
            AV9OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9OrderedDsc", AV9OrderedDsc);
            Ddo_pessoaemail_Sortedstatus = "DSC";
            ucDdo_pessoaemail.SendProperty(context, "", false, Ddo_pessoaemail_Internalname, "SortedStatus", Ddo_pessoaemail_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10PessoaIdTitleFilterData", AV10PessoaIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12PessoaNomeTitleFilterData", AV12PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14PessoaEnderecoTitleFilterData", AV14PessoaEnderecoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16PessoaTelefoneTitleFilterData", AV16PessoaTelefoneTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18PessoaEmailTitleFilterData", AV18PessoaEmailTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20PessoaSexoTitleFilterData", AV20PessoaSexoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22PessoaSituacaoTitleFilterData", AV22PessoaSituacaoTitleFilterData);
      }

      protected void E180N2( )
      {
         /* Ddo_pessoasexo_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_pessoasexo_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S122 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV8OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8OrderedBy), 4, 0)));
            AV9OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9OrderedDsc", AV9OrderedDsc);
            Ddo_pessoasexo_Sortedstatus = "ASC";
            ucDdo_pessoasexo.SendProperty(context, "", false, Ddo_pessoasexo_Internalname, "SortedStatus", Ddo_pessoasexo_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pessoasexo_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S122 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV8OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8OrderedBy), 4, 0)));
            AV9OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9OrderedDsc", AV9OrderedDsc);
            Ddo_pessoasexo_Sortedstatus = "DSC";
            ucDdo_pessoasexo.SendProperty(context, "", false, Ddo_pessoasexo_Internalname, "SortedStatus", Ddo_pessoasexo_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10PessoaIdTitleFilterData", AV10PessoaIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12PessoaNomeTitleFilterData", AV12PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14PessoaEnderecoTitleFilterData", AV14PessoaEnderecoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16PessoaTelefoneTitleFilterData", AV16PessoaTelefoneTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18PessoaEmailTitleFilterData", AV18PessoaEmailTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20PessoaSexoTitleFilterData", AV20PessoaSexoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22PessoaSituacaoTitleFilterData", AV22PessoaSituacaoTitleFilterData);
      }

      protected void E190N2( )
      {
         /* Ddo_pessoasituacao_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_pessoasituacao_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S122 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV8OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8OrderedBy), 4, 0)));
            AV9OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9OrderedDsc", AV9OrderedDsc);
            Ddo_pessoasituacao_Sortedstatus = "ASC";
            ucDdo_pessoasituacao.SendProperty(context, "", false, Ddo_pessoasituacao_Internalname, "SortedStatus", Ddo_pessoasituacao_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pessoasituacao_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S122 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV8OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8OrderedBy), 4, 0)));
            AV9OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9OrderedDsc", AV9OrderedDsc);
            Ddo_pessoasituacao_Sortedstatus = "DSC";
            ucDdo_pessoasituacao.SendProperty(context, "", false, Ddo_pessoasituacao_Internalname, "SortedStatus", Ddo_pessoasituacao_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10PessoaIdTitleFilterData", AV10PessoaIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12PessoaNomeTitleFilterData", AV12PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14PessoaEnderecoTitleFilterData", AV14PessoaEnderecoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16PessoaTelefoneTitleFilterData", AV16PessoaTelefoneTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18PessoaEmailTitleFilterData", AV18PessoaEmailTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20PessoaSexoTitleFilterData", AV20PessoaSexoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22PessoaSituacaoTitleFilterData", AV22PessoaSituacaoTitleFilterData);
      }

      private void E230N2( )
      {
         /* Grid_Load Routine */
         AV28Select = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavSelect_Internalname, AV28Select);
         AV32Select_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         edtavSelect_Tooltiptext = "Selecionar";
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 23;
         }
         sendrow_232( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_23_Refreshing )
         {
            context.DoAjaxLoad(23, GridRow);
         }
         /*  Sending Event outputs  */
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E240N2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E240N2( )
      {
         /* Enter Routine */
         AV29InOutPessoaId = A1PessoaId;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29InOutPessoaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29InOutPessoaId), 4, 0)));
         context.setWebReturnParms(new Object[] {(short)AV29InOutPessoaId});
         context.setWebReturnParmsMetadata(new Object[] {"AV29InOutPessoaId"});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
         /*  Sending Event outputs  */
      }

      protected void E200N2( )
      {
         /* 'DoCleanFilters' Routine */
         /* Execute user subroutine: 'CLEANFILTERS' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         subgrid_firstpage( ) ;
         context.DoAjaxRefresh();
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10PessoaIdTitleFilterData", AV10PessoaIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12PessoaNomeTitleFilterData", AV12PessoaNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14PessoaEnderecoTitleFilterData", AV14PessoaEnderecoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16PessoaTelefoneTitleFilterData", AV16PessoaTelefoneTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18PessoaEmailTitleFilterData", AV18PessoaEmailTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20PessoaSexoTitleFilterData", AV20PessoaSexoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22PessoaSituacaoTitleFilterData", AV22PessoaSituacaoTitleFilterData);
      }

      protected void S122( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_pessoaid_Sortedstatus = "";
         ucDdo_pessoaid.SendProperty(context, "", false, Ddo_pessoaid_Internalname, "SortedStatus", Ddo_pessoaid_Sortedstatus);
         Ddo_pessoanome_Sortedstatus = "";
         ucDdo_pessoanome.SendProperty(context, "", false, Ddo_pessoanome_Internalname, "SortedStatus", Ddo_pessoanome_Sortedstatus);
         Ddo_pessoaendereco_Sortedstatus = "";
         ucDdo_pessoaendereco.SendProperty(context, "", false, Ddo_pessoaendereco_Internalname, "SortedStatus", Ddo_pessoaendereco_Sortedstatus);
         Ddo_pessoatelefone_Sortedstatus = "";
         ucDdo_pessoatelefone.SendProperty(context, "", false, Ddo_pessoatelefone_Internalname, "SortedStatus", Ddo_pessoatelefone_Sortedstatus);
         Ddo_pessoaemail_Sortedstatus = "";
         ucDdo_pessoaemail.SendProperty(context, "", false, Ddo_pessoaemail_Internalname, "SortedStatus", Ddo_pessoaemail_Sortedstatus);
         Ddo_pessoasexo_Sortedstatus = "";
         ucDdo_pessoasexo.SendProperty(context, "", false, Ddo_pessoasexo_Internalname, "SortedStatus", Ddo_pessoasexo_Sortedstatus);
         Ddo_pessoasituacao_Sortedstatus = "";
         ucDdo_pessoasituacao.SendProperty(context, "", false, Ddo_pessoasituacao_Internalname, "SortedStatus", Ddo_pessoasituacao_Sortedstatus);
      }

      protected void S112( )
      {
         /* 'SETDDOSORTEDSTATUS' Routine */
         /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
         S122 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         if ( AV8OrderedBy == 1 )
         {
            Ddo_pessoaid_Sortedstatus = (AV9OrderedDsc ? "DSC" : "ASC");
            ucDdo_pessoaid.SendProperty(context, "", false, Ddo_pessoaid_Internalname, "SortedStatus", Ddo_pessoaid_Sortedstatus);
         }
         else if ( AV8OrderedBy == 2 )
         {
            Ddo_pessoanome_Sortedstatus = (AV9OrderedDsc ? "DSC" : "ASC");
            ucDdo_pessoanome.SendProperty(context, "", false, Ddo_pessoanome_Internalname, "SortedStatus", Ddo_pessoanome_Sortedstatus);
         }
         else if ( AV8OrderedBy == 3 )
         {
            Ddo_pessoaendereco_Sortedstatus = (AV9OrderedDsc ? "DSC" : "ASC");
            ucDdo_pessoaendereco.SendProperty(context, "", false, Ddo_pessoaendereco_Internalname, "SortedStatus", Ddo_pessoaendereco_Sortedstatus);
         }
         else if ( AV8OrderedBy == 4 )
         {
            Ddo_pessoatelefone_Sortedstatus = (AV9OrderedDsc ? "DSC" : "ASC");
            ucDdo_pessoatelefone.SendProperty(context, "", false, Ddo_pessoatelefone_Internalname, "SortedStatus", Ddo_pessoatelefone_Sortedstatus);
         }
         else if ( AV8OrderedBy == 5 )
         {
            Ddo_pessoaemail_Sortedstatus = (AV9OrderedDsc ? "DSC" : "ASC");
            ucDdo_pessoaemail.SendProperty(context, "", false, Ddo_pessoaemail_Internalname, "SortedStatus", Ddo_pessoaemail_Sortedstatus);
         }
         else if ( AV8OrderedBy == 6 )
         {
            Ddo_pessoasexo_Sortedstatus = (AV9OrderedDsc ? "DSC" : "ASC");
            ucDdo_pessoasexo.SendProperty(context, "", false, Ddo_pessoasexo_Internalname, "SortedStatus", Ddo_pessoasexo_Sortedstatus);
         }
         else if ( AV8OrderedBy == 7 )
         {
            Ddo_pessoasituacao_Sortedstatus = (AV9OrderedDsc ? "DSC" : "ASC");
            ucDdo_pessoasituacao.SendProperty(context, "", false, Ddo_pessoasituacao_Internalname, "SortedStatus", Ddo_pessoasituacao_Sortedstatus);
         }
      }

      protected void S132( )
      {
         /* 'CLEANFILTERS' Routine */
      }

      protected void wb_table1_14_0N2( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgCleanfilters_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "Limpar filtros", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgCleanfilters_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'DOCLEANFILTERS\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_PessoaPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_14_0N2e( true) ;
         }
         else
         {
            wb_table1_14_0N2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV29InOutPessoaId = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29InOutPessoaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29InOutPessoaId), 4, 0)));
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
         PA0N2( ) ;
         WS0N2( ) ;
         WE0N2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20197111229443", true, true);
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
         context.AddJavascriptSource("pessoaprompt.js", "?20197111229443", false, true);
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

      protected void SubsflControlProps_232( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_23_idx;
         edtPessoaId_Internalname = "PESSOAID_"+sGXsfl_23_idx;
         edtPessoaNome_Internalname = "PESSOANOME_"+sGXsfl_23_idx;
         edtPessoaEndereco_Internalname = "PESSOAENDERECO_"+sGXsfl_23_idx;
         edtPessoaTelefone_Internalname = "PESSOATELEFONE_"+sGXsfl_23_idx;
         edtPessoaEmail_Internalname = "PESSOAEMAIL_"+sGXsfl_23_idx;
         cmbPessoaSexo_Internalname = "PESSOASEXO_"+sGXsfl_23_idx;
         chkPessoaSituacao_Internalname = "PESSOASITUACAO_"+sGXsfl_23_idx;
      }

      protected void SubsflControlProps_fel_232( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_23_fel_idx;
         edtPessoaId_Internalname = "PESSOAID_"+sGXsfl_23_fel_idx;
         edtPessoaNome_Internalname = "PESSOANOME_"+sGXsfl_23_fel_idx;
         edtPessoaEndereco_Internalname = "PESSOAENDERECO_"+sGXsfl_23_fel_idx;
         edtPessoaTelefone_Internalname = "PESSOATELEFONE_"+sGXsfl_23_fel_idx;
         edtPessoaEmail_Internalname = "PESSOAEMAIL_"+sGXsfl_23_fel_idx;
         cmbPessoaSexo_Internalname = "PESSOASEXO_"+sGXsfl_23_fel_idx;
         chkPessoaSituacao_Internalname = "PESSOASITUACAO_"+sGXsfl_23_fel_idx;
      }

      protected void sendrow_232( )
      {
         SubsflControlProps_232( ) ;
         WB0N0( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_23_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_23_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_23_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavSelect_Enabled!=0)&&(edtavSelect_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 24,'',false,'',23)\"" : " ");
            ClassString = "SelectAttribute ActionBaseColorAttribute";
            StyleString = "";
            AV28Select_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV28Select))&&String.IsNullOrEmpty(StringUtil.RTrim( AV32Select_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV28Select)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV28Select)) ? AV32Select_GXI : context.PathToRelativeUrl( AV28Select));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavSelect_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavSelect_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavSelect_Jsonclick,"'"+""+"'"+",false,"+"'"+"EENTER."+sGXsfl_23_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV28Select_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPessoaId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A1PessoaId), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A1PessoaId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPessoaId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)23,(short)1,(short)-1,(short)0,(bool)true,(String)"Serial",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPessoaNome_Internalname,(String)A2PessoaNome,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPessoaNome_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)60,(short)0,(short)0,(short)23,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPessoaEndereco_Internalname,(String)A3PessoaEndereco,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPessoaEndereco_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)500,(short)0,(short)0,(short)23,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPessoaTelefone_Internalname,(String)A4PessoaTelefone,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPessoaTelefone_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)11,(short)0,(short)0,(short)23,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPessoaEmail_Internalname,(String)A5PessoaEmail,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPessoaEmail_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)23,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbPessoaSexo.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "PESSOASEXO_" + sGXsfl_23_idx;
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
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbPessoaSexo,(String)cmbPessoaSexo_Internalname,StringUtil.RTrim( A6PessoaSexo),(short)1,(String)cmbPessoaSexo_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"char",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn hidden-xs",(String)"",(String)"",(String)"",(bool)true});
            cmbPessoaSexo.CurrentValue = StringUtil.RTrim( A6PessoaSexo);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPessoaSexo_Internalname, "Values", (String)(cmbPessoaSexo.ToJavascriptSource()), !bGXsfl_23_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Check box */
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GridRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkPessoaSituacao_Internalname,StringUtil.BoolToStr( A7PessoaSituacao),(String)"",(String)"",(short)-1,(short)0,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn hidden-xs",(String)"",(String)""});
            send_integrity_lvl_hashes0N2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_23_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_23_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_23_idx+1));
            sGXsfl_23_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_23_idx), 4, 0)), 4, "0");
            SubsflControlProps_232( ) ;
         }
         /* End function sendrow_232 */
      }

      protected void init_web_controls( )
      {
         GXCCtl = "PESSOASEXO_" + sGXsfl_23_idx;
         cmbPessoaSexo.Name = GXCCtl;
         cmbPessoaSexo.WebTags = "";
         cmbPessoaSexo.addItem("M", "Masculino", 0);
         cmbPessoaSexo.addItem("F", "Feminino", 0);
         cmbPessoaSexo.addItem("O", "Outros", 0);
         if ( cmbPessoaSexo.ItemCount > 0 )
         {
            A6PessoaSexo = cmbPessoaSexo.getValidValue(A6PessoaSexo);
         }
         GXCCtl = "PESSOASITUACAO_" + sGXsfl_23_idx;
         chkPessoaSituacao.Name = GXCCtl;
         chkPessoaSituacao.WebTags = "";
         chkPessoaSituacao.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkPessoaSituacao_Internalname, "TitleCaption", chkPessoaSituacao.Caption, !bGXsfl_23_Refreshing);
         chkPessoaSituacao.CheckedValue = "false";
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         imgCleanfilters_Internalname = "CLEANFILTERS";
         tblTablefilters_Internalname = "TABLEFILTERS";
         divTableheader_Internalname = "TABLEHEADER";
         Dvpanel_tableheader_Internalname = "DVPANEL_TABLEHEADER";
         edtavSelect_Internalname = "vSELECT";
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
         Ddo_pessoaendereco_Internalname = "DDO_PESSOAENDERECO";
         edtavDdo_pessoaenderecotitlecontrolidtoreplace_Internalname = "vDDO_PESSOAENDERECOTITLECONTROLIDTOREPLACE";
         Ddo_pessoatelefone_Internalname = "DDO_PESSOATELEFONE";
         edtavDdo_pessoatelefonetitlecontrolidtoreplace_Internalname = "vDDO_PESSOATELEFONETITLECONTROLIDTOREPLACE";
         Ddo_pessoaemail_Internalname = "DDO_PESSOAEMAIL";
         edtavDdo_pessoaemailtitlecontrolidtoreplace_Internalname = "vDDO_PESSOAEMAILTITLECONTROLIDTOREPLACE";
         Ddo_pessoasexo_Internalname = "DDO_PESSOASEXO";
         edtavDdo_pessoasexotitlecontrolidtoreplace_Internalname = "vDDO_PESSOASEXOTITLECONTROLIDTOREPLACE";
         Ddo_pessoasituacao_Internalname = "DDO_PESSOASITUACAO";
         edtavDdo_pessoasituacaotitlecontrolidtoreplace_Internalname = "vDDO_PESSOASITUACAOTITLECONTROLIDTOREPLACE";
         Workwithplusutilities1_Internalname = "WORKWITHPLUSUTILITIES1";
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
         chkPessoaSituacao.Caption = "";
         cmbPessoaSexo_Jsonclick = "";
         edtPessoaEmail_Jsonclick = "";
         edtPessoaTelefone_Jsonclick = "";
         edtPessoaEndereco_Jsonclick = "";
         edtPessoaNome_Jsonclick = "";
         edtPessoaId_Jsonclick = "";
         edtavSelect_Jsonclick = "";
         edtavSelect_Visible = -1;
         edtavSelect_Enabled = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_pessoasituacaotitlecontrolidtoreplace_Visible = 1;
         edtavDdo_pessoasexotitlecontrolidtoreplace_Visible = 1;
         edtavDdo_pessoaemailtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_pessoatelefonetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_pessoaenderecotitlecontrolidtoreplace_Visible = 1;
         edtavDdo_pessoanometitlecontrolidtoreplace_Visible = 1;
         edtavDdo_pessoaidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavSelect_Tooltiptext = "Selecionar";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         chkPessoaSituacao_Titleformat = 0;
         chkPessoaSituacao.Title.Text = "Situação";
         cmbPessoaSexo_Titleformat = 0;
         cmbPessoaSexo.Title.Text = "Sexo";
         edtPessoaEmail_Titleformat = 0;
         edtPessoaEmail_Title = "E-mail";
         edtPessoaTelefone_Titleformat = 0;
         edtPessoaTelefone_Title = "Telefone";
         edtPessoaEndereco_Titleformat = 0;
         edtPessoaEndereco_Title = "Endereço";
         edtPessoaNome_Titleformat = 0;
         edtPessoaNome_Title = "Nome";
         edtPessoaId_Titleformat = 0;
         edtPessoaId_Title = "Id";
         subGrid_Class = "GridWithPaginationBar GridNoBorder WorkWith";
         subGrid_Backcolorstyle = 0;
         Ddo_pessoasituacao_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_pessoasituacao_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_pessoasituacao_Sortdsc = "WWP_TSSortDSC";
         Ddo_pessoasituacao_Sortasc = "WWP_TSSortASC";
         Ddo_pessoasituacao_Includedatalist = Convert.ToBoolean( 0);
         Ddo_pessoasituacao_Includefilter = Convert.ToBoolean( 0);
         Ddo_pessoasituacao_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_pessoasituacao_Includesortasc = Convert.ToBoolean( -1);
         Ddo_pessoasituacao_Titlecontrolidtoreplace = "";
         Ddo_pessoasituacao_Dropdownoptionstype = "GridTitleSettings";
         Ddo_pessoasituacao_Cls = "ColumnSettings";
         Ddo_pessoasituacao_Tooltip = "WWP_TSColumnOptions";
         Ddo_pessoasituacao_Caption = "";
         Ddo_pessoasexo_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_pessoasexo_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_pessoasexo_Sortdsc = "WWP_TSSortDSC";
         Ddo_pessoasexo_Sortasc = "WWP_TSSortASC";
         Ddo_pessoasexo_Includedatalist = Convert.ToBoolean( 0);
         Ddo_pessoasexo_Includefilter = Convert.ToBoolean( 0);
         Ddo_pessoasexo_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_pessoasexo_Includesortasc = Convert.ToBoolean( -1);
         Ddo_pessoasexo_Titlecontrolidtoreplace = "";
         Ddo_pessoasexo_Dropdownoptionstype = "GridTitleSettings";
         Ddo_pessoasexo_Cls = "ColumnSettings";
         Ddo_pessoasexo_Tooltip = "WWP_TSColumnOptions";
         Ddo_pessoasexo_Caption = "";
         Ddo_pessoaemail_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_pessoaemail_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_pessoaemail_Sortdsc = "WWP_TSSortDSC";
         Ddo_pessoaemail_Sortasc = "WWP_TSSortASC";
         Ddo_pessoaemail_Includedatalist = Convert.ToBoolean( 0);
         Ddo_pessoaemail_Includefilter = Convert.ToBoolean( 0);
         Ddo_pessoaemail_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_pessoaemail_Includesortasc = Convert.ToBoolean( -1);
         Ddo_pessoaemail_Titlecontrolidtoreplace = "";
         Ddo_pessoaemail_Dropdownoptionstype = "GridTitleSettings";
         Ddo_pessoaemail_Cls = "ColumnSettings";
         Ddo_pessoaemail_Tooltip = "WWP_TSColumnOptions";
         Ddo_pessoaemail_Caption = "";
         Ddo_pessoatelefone_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_pessoatelefone_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_pessoatelefone_Sortdsc = "WWP_TSSortDSC";
         Ddo_pessoatelefone_Sortasc = "WWP_TSSortASC";
         Ddo_pessoatelefone_Includedatalist = Convert.ToBoolean( 0);
         Ddo_pessoatelefone_Includefilter = Convert.ToBoolean( 0);
         Ddo_pessoatelefone_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_pessoatelefone_Includesortasc = Convert.ToBoolean( -1);
         Ddo_pessoatelefone_Titlecontrolidtoreplace = "";
         Ddo_pessoatelefone_Dropdownoptionstype = "GridTitleSettings";
         Ddo_pessoatelefone_Cls = "ColumnSettings";
         Ddo_pessoatelefone_Tooltip = "WWP_TSColumnOptions";
         Ddo_pessoatelefone_Caption = "";
         Ddo_pessoaendereco_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_pessoaendereco_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_pessoaendereco_Sortdsc = "WWP_TSSortDSC";
         Ddo_pessoaendereco_Sortasc = "WWP_TSSortASC";
         Ddo_pessoaendereco_Includedatalist = Convert.ToBoolean( 0);
         Ddo_pessoaendereco_Includefilter = Convert.ToBoolean( 0);
         Ddo_pessoaendereco_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_pessoaendereco_Includesortasc = Convert.ToBoolean( -1);
         Ddo_pessoaendereco_Titlecontrolidtoreplace = "";
         Ddo_pessoaendereco_Dropdownoptionstype = "GridTitleSettings";
         Ddo_pessoaendereco_Cls = "ColumnSettings";
         Ddo_pessoaendereco_Tooltip = "WWP_TSColumnOptions";
         Ddo_pessoaendereco_Caption = "";
         Ddo_pessoanome_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_pessoanome_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_pessoanome_Sortdsc = "WWP_TSSortDSC";
         Ddo_pessoanome_Sortasc = "WWP_TSSortASC";
         Ddo_pessoanome_Includedatalist = Convert.ToBoolean( 0);
         Ddo_pessoanome_Includefilter = Convert.ToBoolean( 0);
         Ddo_pessoanome_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_pessoanome_Includesortasc = Convert.ToBoolean( -1);
         Ddo_pessoanome_Titlecontrolidtoreplace = "";
         Ddo_pessoanome_Dropdownoptionstype = "GridTitleSettings";
         Ddo_pessoanome_Cls = "ColumnSettings";
         Ddo_pessoanome_Tooltip = "WWP_TSColumnOptions";
         Ddo_pessoanome_Caption = "";
         Ddo_pessoaid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_pessoaid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_pessoaid_Sortdsc = "WWP_TSSortDSC";
         Ddo_pessoaid_Sortasc = "WWP_TSSortASC";
         Ddo_pessoaid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_pessoaid_Includefilter = Convert.ToBoolean( 0);
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
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Consulta de Pessoa";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV8OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV9OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV11ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV13ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_PessoaEnderecoTitleControlIdToReplace',fld:'vDDO_PESSOAENDERECOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_PessoaTelefoneTitleControlIdToReplace',fld:'vDDO_PESSOATELEFONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_PessoaEmailTitleControlIdToReplace',fld:'vDDO_PESSOAEMAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_PessoaSexoTitleControlIdToReplace',fld:'vDDO_PESSOASEXOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_PessoaSituacaoTitleControlIdToReplace',fld:'vDDO_PESSOASITUACAOTITLECONTROLIDTOREPLACE',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV10PessoaIdTitleFilterData',fld:'vPESSOAIDTITLEFILTERDATA',pic:''},{av:'AV12PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV14PessoaEnderecoTitleFilterData',fld:'vPESSOAENDERECOTITLEFILTERDATA',pic:''},{av:'AV16PessoaTelefoneTitleFilterData',fld:'vPESSOATELEFONETITLEFILTERDATA',pic:''},{av:'AV18PessoaEmailTitleFilterData',fld:'vPESSOAEMAILTITLEFILTERDATA',pic:''},{av:'AV20PessoaSexoTitleFilterData',fld:'vPESSOASEXOTITLEFILTERDATA',pic:''},{av:'AV22PessoaSituacaoTitleFilterData',fld:'vPESSOASITUACAOTITLEFILTERDATA',pic:''},{av:'edtPessoaId_Titleformat',ctrl:'PESSOAID',prop:'Titleformat'},{av:'edtPessoaId_Title',ctrl:'PESSOAID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPessoaEndereco_Titleformat',ctrl:'PESSOAENDERECO',prop:'Titleformat'},{av:'edtPessoaEndereco_Title',ctrl:'PESSOAENDERECO',prop:'Title'},{av:'edtPessoaTelefone_Titleformat',ctrl:'PESSOATELEFONE',prop:'Titleformat'},{av:'edtPessoaTelefone_Title',ctrl:'PESSOATELEFONE',prop:'Title'},{av:'edtPessoaEmail_Titleformat',ctrl:'PESSOAEMAIL',prop:'Titleformat'},{av:'edtPessoaEmail_Title',ctrl:'PESSOAEMAIL',prop:'Title'},{av:'cmbPessoaSexo'},{av:'chkPessoaSituacao_Titleformat',ctrl:'PESSOASITUACAO',prop:'Titleformat'},{av:'chkPessoaSituacao.Title.Text',ctrl:'PESSOASITUACAO',prop:'Title'},{av:'AV26GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV27GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E110N2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV8OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV9OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV11ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV13ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_PessoaEnderecoTitleControlIdToReplace',fld:'vDDO_PESSOAENDERECOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_PessoaTelefoneTitleControlIdToReplace',fld:'vDDO_PESSOATELEFONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_PessoaEmailTitleControlIdToReplace',fld:'vDDO_PESSOAEMAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_PessoaSexoTitleControlIdToReplace',fld:'vDDO_PESSOASEXOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_PessoaSituacaoTitleControlIdToReplace',fld:'vDDO_PESSOASITUACAOTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E120N2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV8OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV9OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV11ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV13ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_PessoaEnderecoTitleControlIdToReplace',fld:'vDDO_PESSOAENDERECOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_PessoaTelefoneTitleControlIdToReplace',fld:'vDDO_PESSOATELEFONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_PessoaEmailTitleControlIdToReplace',fld:'vDDO_PESSOAEMAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_PessoaSexoTitleControlIdToReplace',fld:'vDDO_PESSOASEXOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_PessoaSituacaoTitleControlIdToReplace',fld:'vDDO_PESSOASITUACAOTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_PESSOAID.ONOPTIONCLICKED","{handler:'E130N2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV8OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV9OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV11ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV13ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_PessoaEnderecoTitleControlIdToReplace',fld:'vDDO_PESSOAENDERECOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_PessoaTelefoneTitleControlIdToReplace',fld:'vDDO_PESSOATELEFONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_PessoaEmailTitleControlIdToReplace',fld:'vDDO_PESSOAEMAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_PessoaSexoTitleControlIdToReplace',fld:'vDDO_PESSOASEXOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_PessoaSituacaoTitleControlIdToReplace',fld:'vDDO_PESSOASITUACAOTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_pessoaid_Activeeventkey',ctrl:'DDO_PESSOAID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_PESSOAID.ONOPTIONCLICKED",",oparms:[{av:'AV8OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV9OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_pessoaid_Sortedstatus',ctrl:'DDO_PESSOAID',prop:'SortedStatus'},{av:'Ddo_pessoanome_Sortedstatus',ctrl:'DDO_PESSOANOME',prop:'SortedStatus'},{av:'Ddo_pessoaendereco_Sortedstatus',ctrl:'DDO_PESSOAENDERECO',prop:'SortedStatus'},{av:'Ddo_pessoatelefone_Sortedstatus',ctrl:'DDO_PESSOATELEFONE',prop:'SortedStatus'},{av:'Ddo_pessoaemail_Sortedstatus',ctrl:'DDO_PESSOAEMAIL',prop:'SortedStatus'},{av:'Ddo_pessoasexo_Sortedstatus',ctrl:'DDO_PESSOASEXO',prop:'SortedStatus'},{av:'Ddo_pessoasituacao_Sortedstatus',ctrl:'DDO_PESSOASITUACAO',prop:'SortedStatus'},{av:'AV10PessoaIdTitleFilterData',fld:'vPESSOAIDTITLEFILTERDATA',pic:''},{av:'AV12PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV14PessoaEnderecoTitleFilterData',fld:'vPESSOAENDERECOTITLEFILTERDATA',pic:''},{av:'AV16PessoaTelefoneTitleFilterData',fld:'vPESSOATELEFONETITLEFILTERDATA',pic:''},{av:'AV18PessoaEmailTitleFilterData',fld:'vPESSOAEMAILTITLEFILTERDATA',pic:''},{av:'AV20PessoaSexoTitleFilterData',fld:'vPESSOASEXOTITLEFILTERDATA',pic:''},{av:'AV22PessoaSituacaoTitleFilterData',fld:'vPESSOASITUACAOTITLEFILTERDATA',pic:''},{av:'edtPessoaId_Titleformat',ctrl:'PESSOAID',prop:'Titleformat'},{av:'edtPessoaId_Title',ctrl:'PESSOAID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPessoaEndereco_Titleformat',ctrl:'PESSOAENDERECO',prop:'Titleformat'},{av:'edtPessoaEndereco_Title',ctrl:'PESSOAENDERECO',prop:'Title'},{av:'edtPessoaTelefone_Titleformat',ctrl:'PESSOATELEFONE',prop:'Titleformat'},{av:'edtPessoaTelefone_Title',ctrl:'PESSOATELEFONE',prop:'Title'},{av:'edtPessoaEmail_Titleformat',ctrl:'PESSOAEMAIL',prop:'Titleformat'},{av:'edtPessoaEmail_Title',ctrl:'PESSOAEMAIL',prop:'Title'},{av:'cmbPessoaSexo'},{av:'chkPessoaSituacao_Titleformat',ctrl:'PESSOASITUACAO',prop:'Titleformat'},{av:'chkPessoaSituacao.Title.Text',ctrl:'PESSOASITUACAO',prop:'Title'},{av:'AV26GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV27GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_PESSOANOME.ONOPTIONCLICKED","{handler:'E140N2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV8OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV9OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV11ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV13ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_PessoaEnderecoTitleControlIdToReplace',fld:'vDDO_PESSOAENDERECOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_PessoaTelefoneTitleControlIdToReplace',fld:'vDDO_PESSOATELEFONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_PessoaEmailTitleControlIdToReplace',fld:'vDDO_PESSOAEMAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_PessoaSexoTitleControlIdToReplace',fld:'vDDO_PESSOASEXOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_PessoaSituacaoTitleControlIdToReplace',fld:'vDDO_PESSOASITUACAOTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_pessoanome_Activeeventkey',ctrl:'DDO_PESSOANOME',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_PESSOANOME.ONOPTIONCLICKED",",oparms:[{av:'AV8OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV9OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_pessoanome_Sortedstatus',ctrl:'DDO_PESSOANOME',prop:'SortedStatus'},{av:'Ddo_pessoaid_Sortedstatus',ctrl:'DDO_PESSOAID',prop:'SortedStatus'},{av:'Ddo_pessoaendereco_Sortedstatus',ctrl:'DDO_PESSOAENDERECO',prop:'SortedStatus'},{av:'Ddo_pessoatelefone_Sortedstatus',ctrl:'DDO_PESSOATELEFONE',prop:'SortedStatus'},{av:'Ddo_pessoaemail_Sortedstatus',ctrl:'DDO_PESSOAEMAIL',prop:'SortedStatus'},{av:'Ddo_pessoasexo_Sortedstatus',ctrl:'DDO_PESSOASEXO',prop:'SortedStatus'},{av:'Ddo_pessoasituacao_Sortedstatus',ctrl:'DDO_PESSOASITUACAO',prop:'SortedStatus'},{av:'AV10PessoaIdTitleFilterData',fld:'vPESSOAIDTITLEFILTERDATA',pic:''},{av:'AV12PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV14PessoaEnderecoTitleFilterData',fld:'vPESSOAENDERECOTITLEFILTERDATA',pic:''},{av:'AV16PessoaTelefoneTitleFilterData',fld:'vPESSOATELEFONETITLEFILTERDATA',pic:''},{av:'AV18PessoaEmailTitleFilterData',fld:'vPESSOAEMAILTITLEFILTERDATA',pic:''},{av:'AV20PessoaSexoTitleFilterData',fld:'vPESSOASEXOTITLEFILTERDATA',pic:''},{av:'AV22PessoaSituacaoTitleFilterData',fld:'vPESSOASITUACAOTITLEFILTERDATA',pic:''},{av:'edtPessoaId_Titleformat',ctrl:'PESSOAID',prop:'Titleformat'},{av:'edtPessoaId_Title',ctrl:'PESSOAID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPessoaEndereco_Titleformat',ctrl:'PESSOAENDERECO',prop:'Titleformat'},{av:'edtPessoaEndereco_Title',ctrl:'PESSOAENDERECO',prop:'Title'},{av:'edtPessoaTelefone_Titleformat',ctrl:'PESSOATELEFONE',prop:'Titleformat'},{av:'edtPessoaTelefone_Title',ctrl:'PESSOATELEFONE',prop:'Title'},{av:'edtPessoaEmail_Titleformat',ctrl:'PESSOAEMAIL',prop:'Titleformat'},{av:'edtPessoaEmail_Title',ctrl:'PESSOAEMAIL',prop:'Title'},{av:'cmbPessoaSexo'},{av:'chkPessoaSituacao_Titleformat',ctrl:'PESSOASITUACAO',prop:'Titleformat'},{av:'chkPessoaSituacao.Title.Text',ctrl:'PESSOASITUACAO',prop:'Title'},{av:'AV26GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV27GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_PESSOAENDERECO.ONOPTIONCLICKED","{handler:'E150N2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV8OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV9OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV11ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV13ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_PessoaEnderecoTitleControlIdToReplace',fld:'vDDO_PESSOAENDERECOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_PessoaTelefoneTitleControlIdToReplace',fld:'vDDO_PESSOATELEFONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_PessoaEmailTitleControlIdToReplace',fld:'vDDO_PESSOAEMAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_PessoaSexoTitleControlIdToReplace',fld:'vDDO_PESSOASEXOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_PessoaSituacaoTitleControlIdToReplace',fld:'vDDO_PESSOASITUACAOTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_pessoaendereco_Activeeventkey',ctrl:'DDO_PESSOAENDERECO',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_PESSOAENDERECO.ONOPTIONCLICKED",",oparms:[{av:'AV8OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV9OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_pessoaendereco_Sortedstatus',ctrl:'DDO_PESSOAENDERECO',prop:'SortedStatus'},{av:'Ddo_pessoaid_Sortedstatus',ctrl:'DDO_PESSOAID',prop:'SortedStatus'},{av:'Ddo_pessoanome_Sortedstatus',ctrl:'DDO_PESSOANOME',prop:'SortedStatus'},{av:'Ddo_pessoatelefone_Sortedstatus',ctrl:'DDO_PESSOATELEFONE',prop:'SortedStatus'},{av:'Ddo_pessoaemail_Sortedstatus',ctrl:'DDO_PESSOAEMAIL',prop:'SortedStatus'},{av:'Ddo_pessoasexo_Sortedstatus',ctrl:'DDO_PESSOASEXO',prop:'SortedStatus'},{av:'Ddo_pessoasituacao_Sortedstatus',ctrl:'DDO_PESSOASITUACAO',prop:'SortedStatus'},{av:'AV10PessoaIdTitleFilterData',fld:'vPESSOAIDTITLEFILTERDATA',pic:''},{av:'AV12PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV14PessoaEnderecoTitleFilterData',fld:'vPESSOAENDERECOTITLEFILTERDATA',pic:''},{av:'AV16PessoaTelefoneTitleFilterData',fld:'vPESSOATELEFONETITLEFILTERDATA',pic:''},{av:'AV18PessoaEmailTitleFilterData',fld:'vPESSOAEMAILTITLEFILTERDATA',pic:''},{av:'AV20PessoaSexoTitleFilterData',fld:'vPESSOASEXOTITLEFILTERDATA',pic:''},{av:'AV22PessoaSituacaoTitleFilterData',fld:'vPESSOASITUACAOTITLEFILTERDATA',pic:''},{av:'edtPessoaId_Titleformat',ctrl:'PESSOAID',prop:'Titleformat'},{av:'edtPessoaId_Title',ctrl:'PESSOAID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPessoaEndereco_Titleformat',ctrl:'PESSOAENDERECO',prop:'Titleformat'},{av:'edtPessoaEndereco_Title',ctrl:'PESSOAENDERECO',prop:'Title'},{av:'edtPessoaTelefone_Titleformat',ctrl:'PESSOATELEFONE',prop:'Titleformat'},{av:'edtPessoaTelefone_Title',ctrl:'PESSOATELEFONE',prop:'Title'},{av:'edtPessoaEmail_Titleformat',ctrl:'PESSOAEMAIL',prop:'Titleformat'},{av:'edtPessoaEmail_Title',ctrl:'PESSOAEMAIL',prop:'Title'},{av:'cmbPessoaSexo'},{av:'chkPessoaSituacao_Titleformat',ctrl:'PESSOASITUACAO',prop:'Titleformat'},{av:'chkPessoaSituacao.Title.Text',ctrl:'PESSOASITUACAO',prop:'Title'},{av:'AV26GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV27GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_PESSOATELEFONE.ONOPTIONCLICKED","{handler:'E160N2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV8OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV9OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV11ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV13ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_PessoaEnderecoTitleControlIdToReplace',fld:'vDDO_PESSOAENDERECOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_PessoaTelefoneTitleControlIdToReplace',fld:'vDDO_PESSOATELEFONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_PessoaEmailTitleControlIdToReplace',fld:'vDDO_PESSOAEMAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_PessoaSexoTitleControlIdToReplace',fld:'vDDO_PESSOASEXOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_PessoaSituacaoTitleControlIdToReplace',fld:'vDDO_PESSOASITUACAOTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_pessoatelefone_Activeeventkey',ctrl:'DDO_PESSOATELEFONE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_PESSOATELEFONE.ONOPTIONCLICKED",",oparms:[{av:'AV8OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV9OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_pessoatelefone_Sortedstatus',ctrl:'DDO_PESSOATELEFONE',prop:'SortedStatus'},{av:'Ddo_pessoaid_Sortedstatus',ctrl:'DDO_PESSOAID',prop:'SortedStatus'},{av:'Ddo_pessoanome_Sortedstatus',ctrl:'DDO_PESSOANOME',prop:'SortedStatus'},{av:'Ddo_pessoaendereco_Sortedstatus',ctrl:'DDO_PESSOAENDERECO',prop:'SortedStatus'},{av:'Ddo_pessoaemail_Sortedstatus',ctrl:'DDO_PESSOAEMAIL',prop:'SortedStatus'},{av:'Ddo_pessoasexo_Sortedstatus',ctrl:'DDO_PESSOASEXO',prop:'SortedStatus'},{av:'Ddo_pessoasituacao_Sortedstatus',ctrl:'DDO_PESSOASITUACAO',prop:'SortedStatus'},{av:'AV10PessoaIdTitleFilterData',fld:'vPESSOAIDTITLEFILTERDATA',pic:''},{av:'AV12PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV14PessoaEnderecoTitleFilterData',fld:'vPESSOAENDERECOTITLEFILTERDATA',pic:''},{av:'AV16PessoaTelefoneTitleFilterData',fld:'vPESSOATELEFONETITLEFILTERDATA',pic:''},{av:'AV18PessoaEmailTitleFilterData',fld:'vPESSOAEMAILTITLEFILTERDATA',pic:''},{av:'AV20PessoaSexoTitleFilterData',fld:'vPESSOASEXOTITLEFILTERDATA',pic:''},{av:'AV22PessoaSituacaoTitleFilterData',fld:'vPESSOASITUACAOTITLEFILTERDATA',pic:''},{av:'edtPessoaId_Titleformat',ctrl:'PESSOAID',prop:'Titleformat'},{av:'edtPessoaId_Title',ctrl:'PESSOAID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPessoaEndereco_Titleformat',ctrl:'PESSOAENDERECO',prop:'Titleformat'},{av:'edtPessoaEndereco_Title',ctrl:'PESSOAENDERECO',prop:'Title'},{av:'edtPessoaTelefone_Titleformat',ctrl:'PESSOATELEFONE',prop:'Titleformat'},{av:'edtPessoaTelefone_Title',ctrl:'PESSOATELEFONE',prop:'Title'},{av:'edtPessoaEmail_Titleformat',ctrl:'PESSOAEMAIL',prop:'Titleformat'},{av:'edtPessoaEmail_Title',ctrl:'PESSOAEMAIL',prop:'Title'},{av:'cmbPessoaSexo'},{av:'chkPessoaSituacao_Titleformat',ctrl:'PESSOASITUACAO',prop:'Titleformat'},{av:'chkPessoaSituacao.Title.Text',ctrl:'PESSOASITUACAO',prop:'Title'},{av:'AV26GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV27GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_PESSOAEMAIL.ONOPTIONCLICKED","{handler:'E170N2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV8OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV9OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV11ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV13ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_PessoaEnderecoTitleControlIdToReplace',fld:'vDDO_PESSOAENDERECOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_PessoaTelefoneTitleControlIdToReplace',fld:'vDDO_PESSOATELEFONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_PessoaEmailTitleControlIdToReplace',fld:'vDDO_PESSOAEMAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_PessoaSexoTitleControlIdToReplace',fld:'vDDO_PESSOASEXOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_PessoaSituacaoTitleControlIdToReplace',fld:'vDDO_PESSOASITUACAOTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_pessoaemail_Activeeventkey',ctrl:'DDO_PESSOAEMAIL',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_PESSOAEMAIL.ONOPTIONCLICKED",",oparms:[{av:'AV8OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV9OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_pessoaemail_Sortedstatus',ctrl:'DDO_PESSOAEMAIL',prop:'SortedStatus'},{av:'Ddo_pessoaid_Sortedstatus',ctrl:'DDO_PESSOAID',prop:'SortedStatus'},{av:'Ddo_pessoanome_Sortedstatus',ctrl:'DDO_PESSOANOME',prop:'SortedStatus'},{av:'Ddo_pessoaendereco_Sortedstatus',ctrl:'DDO_PESSOAENDERECO',prop:'SortedStatus'},{av:'Ddo_pessoatelefone_Sortedstatus',ctrl:'DDO_PESSOATELEFONE',prop:'SortedStatus'},{av:'Ddo_pessoasexo_Sortedstatus',ctrl:'DDO_PESSOASEXO',prop:'SortedStatus'},{av:'Ddo_pessoasituacao_Sortedstatus',ctrl:'DDO_PESSOASITUACAO',prop:'SortedStatus'},{av:'AV10PessoaIdTitleFilterData',fld:'vPESSOAIDTITLEFILTERDATA',pic:''},{av:'AV12PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV14PessoaEnderecoTitleFilterData',fld:'vPESSOAENDERECOTITLEFILTERDATA',pic:''},{av:'AV16PessoaTelefoneTitleFilterData',fld:'vPESSOATELEFONETITLEFILTERDATA',pic:''},{av:'AV18PessoaEmailTitleFilterData',fld:'vPESSOAEMAILTITLEFILTERDATA',pic:''},{av:'AV20PessoaSexoTitleFilterData',fld:'vPESSOASEXOTITLEFILTERDATA',pic:''},{av:'AV22PessoaSituacaoTitleFilterData',fld:'vPESSOASITUACAOTITLEFILTERDATA',pic:''},{av:'edtPessoaId_Titleformat',ctrl:'PESSOAID',prop:'Titleformat'},{av:'edtPessoaId_Title',ctrl:'PESSOAID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPessoaEndereco_Titleformat',ctrl:'PESSOAENDERECO',prop:'Titleformat'},{av:'edtPessoaEndereco_Title',ctrl:'PESSOAENDERECO',prop:'Title'},{av:'edtPessoaTelefone_Titleformat',ctrl:'PESSOATELEFONE',prop:'Titleformat'},{av:'edtPessoaTelefone_Title',ctrl:'PESSOATELEFONE',prop:'Title'},{av:'edtPessoaEmail_Titleformat',ctrl:'PESSOAEMAIL',prop:'Titleformat'},{av:'edtPessoaEmail_Title',ctrl:'PESSOAEMAIL',prop:'Title'},{av:'cmbPessoaSexo'},{av:'chkPessoaSituacao_Titleformat',ctrl:'PESSOASITUACAO',prop:'Titleformat'},{av:'chkPessoaSituacao.Title.Text',ctrl:'PESSOASITUACAO',prop:'Title'},{av:'AV26GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV27GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_PESSOASEXO.ONOPTIONCLICKED","{handler:'E180N2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV8OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV9OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV11ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV13ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_PessoaEnderecoTitleControlIdToReplace',fld:'vDDO_PESSOAENDERECOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_PessoaTelefoneTitleControlIdToReplace',fld:'vDDO_PESSOATELEFONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_PessoaEmailTitleControlIdToReplace',fld:'vDDO_PESSOAEMAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_PessoaSexoTitleControlIdToReplace',fld:'vDDO_PESSOASEXOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_PessoaSituacaoTitleControlIdToReplace',fld:'vDDO_PESSOASITUACAOTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_pessoasexo_Activeeventkey',ctrl:'DDO_PESSOASEXO',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_PESSOASEXO.ONOPTIONCLICKED",",oparms:[{av:'AV8OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV9OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_pessoasexo_Sortedstatus',ctrl:'DDO_PESSOASEXO',prop:'SortedStatus'},{av:'Ddo_pessoaid_Sortedstatus',ctrl:'DDO_PESSOAID',prop:'SortedStatus'},{av:'Ddo_pessoanome_Sortedstatus',ctrl:'DDO_PESSOANOME',prop:'SortedStatus'},{av:'Ddo_pessoaendereco_Sortedstatus',ctrl:'DDO_PESSOAENDERECO',prop:'SortedStatus'},{av:'Ddo_pessoatelefone_Sortedstatus',ctrl:'DDO_PESSOATELEFONE',prop:'SortedStatus'},{av:'Ddo_pessoaemail_Sortedstatus',ctrl:'DDO_PESSOAEMAIL',prop:'SortedStatus'},{av:'Ddo_pessoasituacao_Sortedstatus',ctrl:'DDO_PESSOASITUACAO',prop:'SortedStatus'},{av:'AV10PessoaIdTitleFilterData',fld:'vPESSOAIDTITLEFILTERDATA',pic:''},{av:'AV12PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV14PessoaEnderecoTitleFilterData',fld:'vPESSOAENDERECOTITLEFILTERDATA',pic:''},{av:'AV16PessoaTelefoneTitleFilterData',fld:'vPESSOATELEFONETITLEFILTERDATA',pic:''},{av:'AV18PessoaEmailTitleFilterData',fld:'vPESSOAEMAILTITLEFILTERDATA',pic:''},{av:'AV20PessoaSexoTitleFilterData',fld:'vPESSOASEXOTITLEFILTERDATA',pic:''},{av:'AV22PessoaSituacaoTitleFilterData',fld:'vPESSOASITUACAOTITLEFILTERDATA',pic:''},{av:'edtPessoaId_Titleformat',ctrl:'PESSOAID',prop:'Titleformat'},{av:'edtPessoaId_Title',ctrl:'PESSOAID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPessoaEndereco_Titleformat',ctrl:'PESSOAENDERECO',prop:'Titleformat'},{av:'edtPessoaEndereco_Title',ctrl:'PESSOAENDERECO',prop:'Title'},{av:'edtPessoaTelefone_Titleformat',ctrl:'PESSOATELEFONE',prop:'Titleformat'},{av:'edtPessoaTelefone_Title',ctrl:'PESSOATELEFONE',prop:'Title'},{av:'edtPessoaEmail_Titleformat',ctrl:'PESSOAEMAIL',prop:'Titleformat'},{av:'edtPessoaEmail_Title',ctrl:'PESSOAEMAIL',prop:'Title'},{av:'cmbPessoaSexo'},{av:'chkPessoaSituacao_Titleformat',ctrl:'PESSOASITUACAO',prop:'Titleformat'},{av:'chkPessoaSituacao.Title.Text',ctrl:'PESSOASITUACAO',prop:'Title'},{av:'AV26GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV27GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_PESSOASITUACAO.ONOPTIONCLICKED","{handler:'E190N2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV8OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV9OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV11ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV13ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_PessoaEnderecoTitleControlIdToReplace',fld:'vDDO_PESSOAENDERECOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_PessoaTelefoneTitleControlIdToReplace',fld:'vDDO_PESSOATELEFONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_PessoaEmailTitleControlIdToReplace',fld:'vDDO_PESSOAEMAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_PessoaSexoTitleControlIdToReplace',fld:'vDDO_PESSOASEXOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_PessoaSituacaoTitleControlIdToReplace',fld:'vDDO_PESSOASITUACAOTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_pessoasituacao_Activeeventkey',ctrl:'DDO_PESSOASITUACAO',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_PESSOASITUACAO.ONOPTIONCLICKED",",oparms:[{av:'AV8OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV9OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_pessoasituacao_Sortedstatus',ctrl:'DDO_PESSOASITUACAO',prop:'SortedStatus'},{av:'Ddo_pessoaid_Sortedstatus',ctrl:'DDO_PESSOAID',prop:'SortedStatus'},{av:'Ddo_pessoanome_Sortedstatus',ctrl:'DDO_PESSOANOME',prop:'SortedStatus'},{av:'Ddo_pessoaendereco_Sortedstatus',ctrl:'DDO_PESSOAENDERECO',prop:'SortedStatus'},{av:'Ddo_pessoatelefone_Sortedstatus',ctrl:'DDO_PESSOATELEFONE',prop:'SortedStatus'},{av:'Ddo_pessoaemail_Sortedstatus',ctrl:'DDO_PESSOAEMAIL',prop:'SortedStatus'},{av:'Ddo_pessoasexo_Sortedstatus',ctrl:'DDO_PESSOASEXO',prop:'SortedStatus'},{av:'AV10PessoaIdTitleFilterData',fld:'vPESSOAIDTITLEFILTERDATA',pic:''},{av:'AV12PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV14PessoaEnderecoTitleFilterData',fld:'vPESSOAENDERECOTITLEFILTERDATA',pic:''},{av:'AV16PessoaTelefoneTitleFilterData',fld:'vPESSOATELEFONETITLEFILTERDATA',pic:''},{av:'AV18PessoaEmailTitleFilterData',fld:'vPESSOAEMAILTITLEFILTERDATA',pic:''},{av:'AV20PessoaSexoTitleFilterData',fld:'vPESSOASEXOTITLEFILTERDATA',pic:''},{av:'AV22PessoaSituacaoTitleFilterData',fld:'vPESSOASITUACAOTITLEFILTERDATA',pic:''},{av:'edtPessoaId_Titleformat',ctrl:'PESSOAID',prop:'Titleformat'},{av:'edtPessoaId_Title',ctrl:'PESSOAID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPessoaEndereco_Titleformat',ctrl:'PESSOAENDERECO',prop:'Titleformat'},{av:'edtPessoaEndereco_Title',ctrl:'PESSOAENDERECO',prop:'Title'},{av:'edtPessoaTelefone_Titleformat',ctrl:'PESSOATELEFONE',prop:'Titleformat'},{av:'edtPessoaTelefone_Title',ctrl:'PESSOATELEFONE',prop:'Title'},{av:'edtPessoaEmail_Titleformat',ctrl:'PESSOAEMAIL',prop:'Titleformat'},{av:'edtPessoaEmail_Title',ctrl:'PESSOAEMAIL',prop:'Title'},{av:'cmbPessoaSexo'},{av:'chkPessoaSituacao_Titleformat',ctrl:'PESSOASITUACAO',prop:'Titleformat'},{av:'chkPessoaSituacao.Title.Text',ctrl:'PESSOASITUACAO',prop:'Title'},{av:'AV26GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV27GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E230N2',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV28Select',fld:'vSELECT',pic:''},{av:'edtavSelect_Tooltiptext',ctrl:'vSELECT',prop:'Tooltiptext'}]}");
         setEventMetadata("ENTER","{handler:'E240N2',iparms:[{av:'A1PessoaId',fld:'PESSOAID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV29InOutPessoaId',fld:'vINOUTPESSOAID',pic:'ZZZ9'}]}");
         setEventMetadata("'DOCLEANFILTERS'","{handler:'E200N2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV8OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV9OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV11ddo_PessoaIdTitleControlIdToReplace',fld:'vDDO_PESSOAIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV13ddo_PessoaNomeTitleControlIdToReplace',fld:'vDDO_PESSOANOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_PessoaEnderecoTitleControlIdToReplace',fld:'vDDO_PESSOAENDERECOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_PessoaTelefoneTitleControlIdToReplace',fld:'vDDO_PESSOATELEFONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_PessoaEmailTitleControlIdToReplace',fld:'vDDO_PESSOAEMAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_PessoaSexoTitleControlIdToReplace',fld:'vDDO_PESSOASEXOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_PessoaSituacaoTitleControlIdToReplace',fld:'vDDO_PESSOASITUACAOTITLECONTROLIDTOREPLACE',pic:''}]");
         setEventMetadata("'DOCLEANFILTERS'",",oparms:[{av:'AV10PessoaIdTitleFilterData',fld:'vPESSOAIDTITLEFILTERDATA',pic:''},{av:'AV12PessoaNomeTitleFilterData',fld:'vPESSOANOMETITLEFILTERDATA',pic:''},{av:'AV14PessoaEnderecoTitleFilterData',fld:'vPESSOAENDERECOTITLEFILTERDATA',pic:''},{av:'AV16PessoaTelefoneTitleFilterData',fld:'vPESSOATELEFONETITLEFILTERDATA',pic:''},{av:'AV18PessoaEmailTitleFilterData',fld:'vPESSOAEMAILTITLEFILTERDATA',pic:''},{av:'AV20PessoaSexoTitleFilterData',fld:'vPESSOASEXOTITLEFILTERDATA',pic:''},{av:'AV22PessoaSituacaoTitleFilterData',fld:'vPESSOASITUACAOTITLEFILTERDATA',pic:''},{av:'edtPessoaId_Titleformat',ctrl:'PESSOAID',prop:'Titleformat'},{av:'edtPessoaId_Title',ctrl:'PESSOAID',prop:'Title'},{av:'edtPessoaNome_Titleformat',ctrl:'PESSOANOME',prop:'Titleformat'},{av:'edtPessoaNome_Title',ctrl:'PESSOANOME',prop:'Title'},{av:'edtPessoaEndereco_Titleformat',ctrl:'PESSOAENDERECO',prop:'Titleformat'},{av:'edtPessoaEndereco_Title',ctrl:'PESSOAENDERECO',prop:'Title'},{av:'edtPessoaTelefone_Titleformat',ctrl:'PESSOATELEFONE',prop:'Titleformat'},{av:'edtPessoaTelefone_Title',ctrl:'PESSOATELEFONE',prop:'Title'},{av:'edtPessoaEmail_Titleformat',ctrl:'PESSOAEMAIL',prop:'Titleformat'},{av:'edtPessoaEmail_Title',ctrl:'PESSOAEMAIL',prop:'Title'},{av:'cmbPessoaSexo'},{av:'chkPessoaSituacao_Titleformat',ctrl:'PESSOASITUACAO',prop:'Titleformat'},{av:'chkPessoaSituacao.Title.Text',ctrl:'PESSOASITUACAO',prop:'Title'},{av:'AV26GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV27GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
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
         Ddo_pessoanome_Activeeventkey = "";
         Ddo_pessoaendereco_Activeeventkey = "";
         Ddo_pessoatelefone_Activeeventkey = "";
         Ddo_pessoaemail_Activeeventkey = "";
         Ddo_pessoasexo_Activeeventkey = "";
         Ddo_pessoasituacao_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV11ddo_PessoaIdTitleControlIdToReplace = "";
         AV13ddo_PessoaNomeTitleControlIdToReplace = "";
         AV15ddo_PessoaEnderecoTitleControlIdToReplace = "";
         AV17ddo_PessoaTelefoneTitleControlIdToReplace = "";
         AV19ddo_PessoaEmailTitleControlIdToReplace = "";
         AV21ddo_PessoaSexoTitleControlIdToReplace = "";
         AV23ddo_PessoaSituacaoTitleControlIdToReplace = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV24DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV10PessoaIdTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV12PessoaNomeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV14PessoaEnderecoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV16PessoaTelefoneTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV18PessoaEmailTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20PessoaSexoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV22PessoaSituacaoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_pessoaid_Sortedstatus = "";
         Ddo_pessoanome_Sortedstatus = "";
         Ddo_pessoaendereco_Sortedstatus = "";
         Ddo_pessoatelefone_Sortedstatus = "";
         Ddo_pessoaemail_Sortedstatus = "";
         Ddo_pessoasexo_Sortedstatus = "";
         Ddo_pessoasituacao_Sortedstatus = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ucDvpanel_tableheader = new GXUserControl();
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV28Select = "";
         A2PessoaNome = "";
         A3PessoaEndereco = "";
         A4PessoaTelefone = "";
         A5PessoaEmail = "";
         A6PessoaSexo = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_pessoaid = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         ucDdo_pessoanome = new GXUserControl();
         ucDdo_pessoaendereco = new GXUserControl();
         ucDdo_pessoatelefone = new GXUserControl();
         ucDdo_pessoaemail = new GXUserControl();
         ucDdo_pessoasexo = new GXUserControl();
         ucDdo_pessoasituacao = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV32Select_GXI = "";
         scmdbuf = "";
         H000N2_A7PessoaSituacao = new bool[] {false} ;
         H000N2_A6PessoaSexo = new String[] {""} ;
         H000N2_A5PessoaEmail = new String[] {""} ;
         H000N2_A4PessoaTelefone = new String[] {""} ;
         H000N2_A3PessoaEndereco = new String[] {""} ;
         H000N2_A2PessoaNome = new String[] {""} ;
         H000N2_A1PessoaId = new short[1] ;
         H000N3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         sImgUrl = "";
         imgCleanfilters_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pessoaprompt__default(),
            new Object[][] {
                new Object[] {
               H000N2_A7PessoaSituacao, H000N2_A6PessoaSexo, H000N2_A5PessoaEmail, H000N2_A4PessoaTelefone, H000N2_A3PessoaEndereco, H000N2_A2PessoaNome, H000N2_A1PessoaId
               }
               , new Object[] {
               H000N3_AGRID_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV29InOutPessoaId ;
      private short wcpOAV29InOutPessoaId ;
      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_23 ;
      private short nGXsfl_23_idx=1 ;
      private short GRID_nEOF ;
      private short AV8OrderedBy ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtPessoaId_Titleformat ;
      private short edtPessoaNome_Titleformat ;
      private short edtPessoaEndereco_Titleformat ;
      private short edtPessoaTelefone_Titleformat ;
      private short edtPessoaEmail_Titleformat ;
      private short cmbPessoaSexo_Titleformat ;
      private short chkPessoaSituacao_Titleformat ;
      private short subGrid_Sortable ;
      private short A1PessoaId ;
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
      private int edtavDdo_pessoaidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_pessoanometitlecontrolidtoreplace_Visible ;
      private int edtavDdo_pessoaenderecotitlecontrolidtoreplace_Visible ;
      private int edtavDdo_pessoatelefonetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_pessoaemailtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_pessoasexotitlecontrolidtoreplace_Visible ;
      private int edtavDdo_pessoasituacaotitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV25PageToGo ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavSelect_Enabled ;
      private int edtavSelect_Visible ;
      private long GRID_nFirstRecordOnPage ;
      private long AV26GridCurrentPage ;
      private long AV27GridPageCount ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_pessoaid_Activeeventkey ;
      private String Ddo_pessoanome_Activeeventkey ;
      private String Ddo_pessoaendereco_Activeeventkey ;
      private String Ddo_pessoatelefone_Activeeventkey ;
      private String Ddo_pessoaemail_Activeeventkey ;
      private String Ddo_pessoasexo_Activeeventkey ;
      private String Ddo_pessoasituacao_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_23_idx="0001" ;
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
      private String Ddo_pessoaid_Caption ;
      private String Ddo_pessoaid_Tooltip ;
      private String Ddo_pessoaid_Cls ;
      private String Ddo_pessoaid_Dropdownoptionstype ;
      private String Ddo_pessoaid_Titlecontrolidtoreplace ;
      private String Ddo_pessoaid_Sortedstatus ;
      private String Ddo_pessoaid_Sortasc ;
      private String Ddo_pessoaid_Sortdsc ;
      private String Ddo_pessoaid_Cleanfilter ;
      private String Ddo_pessoaid_Searchbuttontext ;
      private String Ddo_pessoanome_Caption ;
      private String Ddo_pessoanome_Tooltip ;
      private String Ddo_pessoanome_Cls ;
      private String Ddo_pessoanome_Dropdownoptionstype ;
      private String Ddo_pessoanome_Titlecontrolidtoreplace ;
      private String Ddo_pessoanome_Sortedstatus ;
      private String Ddo_pessoanome_Sortasc ;
      private String Ddo_pessoanome_Sortdsc ;
      private String Ddo_pessoanome_Cleanfilter ;
      private String Ddo_pessoanome_Searchbuttontext ;
      private String Ddo_pessoaendereco_Caption ;
      private String Ddo_pessoaendereco_Tooltip ;
      private String Ddo_pessoaendereco_Cls ;
      private String Ddo_pessoaendereco_Dropdownoptionstype ;
      private String Ddo_pessoaendereco_Titlecontrolidtoreplace ;
      private String Ddo_pessoaendereco_Sortedstatus ;
      private String Ddo_pessoaendereco_Sortasc ;
      private String Ddo_pessoaendereco_Sortdsc ;
      private String Ddo_pessoaendereco_Cleanfilter ;
      private String Ddo_pessoaendereco_Searchbuttontext ;
      private String Ddo_pessoatelefone_Caption ;
      private String Ddo_pessoatelefone_Tooltip ;
      private String Ddo_pessoatelefone_Cls ;
      private String Ddo_pessoatelefone_Dropdownoptionstype ;
      private String Ddo_pessoatelefone_Titlecontrolidtoreplace ;
      private String Ddo_pessoatelefone_Sortedstatus ;
      private String Ddo_pessoatelefone_Sortasc ;
      private String Ddo_pessoatelefone_Sortdsc ;
      private String Ddo_pessoatelefone_Cleanfilter ;
      private String Ddo_pessoatelefone_Searchbuttontext ;
      private String Ddo_pessoaemail_Caption ;
      private String Ddo_pessoaemail_Tooltip ;
      private String Ddo_pessoaemail_Cls ;
      private String Ddo_pessoaemail_Dropdownoptionstype ;
      private String Ddo_pessoaemail_Titlecontrolidtoreplace ;
      private String Ddo_pessoaemail_Sortedstatus ;
      private String Ddo_pessoaemail_Sortasc ;
      private String Ddo_pessoaemail_Sortdsc ;
      private String Ddo_pessoaemail_Cleanfilter ;
      private String Ddo_pessoaemail_Searchbuttontext ;
      private String Ddo_pessoasexo_Caption ;
      private String Ddo_pessoasexo_Tooltip ;
      private String Ddo_pessoasexo_Cls ;
      private String Ddo_pessoasexo_Dropdownoptionstype ;
      private String Ddo_pessoasexo_Titlecontrolidtoreplace ;
      private String Ddo_pessoasexo_Sortedstatus ;
      private String Ddo_pessoasexo_Sortasc ;
      private String Ddo_pessoasexo_Sortdsc ;
      private String Ddo_pessoasexo_Cleanfilter ;
      private String Ddo_pessoasexo_Searchbuttontext ;
      private String Ddo_pessoasituacao_Caption ;
      private String Ddo_pessoasituacao_Tooltip ;
      private String Ddo_pessoasituacao_Cls ;
      private String Ddo_pessoasituacao_Dropdownoptionstype ;
      private String Ddo_pessoasituacao_Titlecontrolidtoreplace ;
      private String Ddo_pessoasituacao_Sortedstatus ;
      private String Ddo_pessoasituacao_Sortasc ;
      private String Ddo_pessoasituacao_Sortdsc ;
      private String Ddo_pessoasituacao_Cleanfilter ;
      private String Ddo_pessoasituacao_Searchbuttontext ;
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
      private String edtPessoaId_Title ;
      private String edtPessoaNome_Title ;
      private String edtPessoaEndereco_Title ;
      private String edtPessoaTelefone_Title ;
      private String edtPessoaEmail_Title ;
      private String subGrid_Header ;
      private String edtavSelect_Tooltiptext ;
      private String A6PessoaSexo ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_pessoaid_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String edtavDdo_pessoaidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_pessoanome_Internalname ;
      private String edtavDdo_pessoanometitlecontrolidtoreplace_Internalname ;
      private String Ddo_pessoaendereco_Internalname ;
      private String edtavDdo_pessoaenderecotitlecontrolidtoreplace_Internalname ;
      private String Ddo_pessoatelefone_Internalname ;
      private String edtavDdo_pessoatelefonetitlecontrolidtoreplace_Internalname ;
      private String Ddo_pessoaemail_Internalname ;
      private String edtavDdo_pessoaemailtitlecontrolidtoreplace_Internalname ;
      private String Ddo_pessoasexo_Internalname ;
      private String edtavDdo_pessoasexotitlecontrolidtoreplace_Internalname ;
      private String Ddo_pessoasituacao_Internalname ;
      private String edtavDdo_pessoasituacaotitlecontrolidtoreplace_Internalname ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavSelect_Internalname ;
      private String edtPessoaId_Internalname ;
      private String edtPessoaNome_Internalname ;
      private String edtPessoaEndereco_Internalname ;
      private String edtPessoaTelefone_Internalname ;
      private String edtPessoaEmail_Internalname ;
      private String cmbPessoaSexo_Internalname ;
      private String chkPessoaSituacao_Internalname ;
      private String scmdbuf ;
      private String tblTablefilters_Internalname ;
      private String sImgUrl ;
      private String imgCleanfilters_Internalname ;
      private String imgCleanfilters_Jsonclick ;
      private String sGXsfl_23_fel_idx="0001" ;
      private String edtavSelect_Jsonclick ;
      private String ROClassString ;
      private String edtPessoaId_Jsonclick ;
      private String edtPessoaNome_Jsonclick ;
      private String edtPessoaEndereco_Jsonclick ;
      private String edtPessoaTelefone_Jsonclick ;
      private String edtPessoaEmail_Jsonclick ;
      private String GXCCtl ;
      private String cmbPessoaSexo_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV9OrderedDsc ;
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
      private bool Ddo_pessoaid_Includedatalist ;
      private bool Ddo_pessoanome_Includesortasc ;
      private bool Ddo_pessoanome_Includesortdsc ;
      private bool Ddo_pessoanome_Includefilter ;
      private bool Ddo_pessoanome_Includedatalist ;
      private bool Ddo_pessoaendereco_Includesortasc ;
      private bool Ddo_pessoaendereco_Includesortdsc ;
      private bool Ddo_pessoaendereco_Includefilter ;
      private bool Ddo_pessoaendereco_Includedatalist ;
      private bool Ddo_pessoatelefone_Includesortasc ;
      private bool Ddo_pessoatelefone_Includesortdsc ;
      private bool Ddo_pessoatelefone_Includefilter ;
      private bool Ddo_pessoatelefone_Includedatalist ;
      private bool Ddo_pessoaemail_Includesortasc ;
      private bool Ddo_pessoaemail_Includesortdsc ;
      private bool Ddo_pessoaemail_Includefilter ;
      private bool Ddo_pessoaemail_Includedatalist ;
      private bool Ddo_pessoasexo_Includesortasc ;
      private bool Ddo_pessoasexo_Includesortdsc ;
      private bool Ddo_pessoasexo_Includefilter ;
      private bool Ddo_pessoasexo_Includedatalist ;
      private bool Ddo_pessoasituacao_Includesortasc ;
      private bool Ddo_pessoasituacao_Includesortdsc ;
      private bool Ddo_pessoasituacao_Includefilter ;
      private bool Ddo_pessoasituacao_Includedatalist ;
      private bool wbLoad ;
      private bool A7PessoaSituacao ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_23_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV28Select_IsBlob ;
      private String AV11ddo_PessoaIdTitleControlIdToReplace ;
      private String AV13ddo_PessoaNomeTitleControlIdToReplace ;
      private String AV15ddo_PessoaEnderecoTitleControlIdToReplace ;
      private String AV17ddo_PessoaTelefoneTitleControlIdToReplace ;
      private String AV19ddo_PessoaEmailTitleControlIdToReplace ;
      private String AV21ddo_PessoaSexoTitleControlIdToReplace ;
      private String AV23ddo_PessoaSituacaoTitleControlIdToReplace ;
      private String A2PessoaNome ;
      private String A3PessoaEndereco ;
      private String A4PessoaTelefone ;
      private String A5PessoaEmail ;
      private String AV32Select_GXI ;
      private String AV28Select ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_pessoaid ;
      private GXUserControl ucDdo_pessoanome ;
      private GXUserControl ucDdo_pessoaendereco ;
      private GXUserControl ucDdo_pessoatelefone ;
      private GXUserControl ucDdo_pessoaemail ;
      private GXUserControl ucDdo_pessoasexo ;
      private GXUserControl ucDdo_pessoasituacao ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private IGxDataStore dsDefault ;
      private short aP0_InOutPessoaId ;
      private GXCombobox cmbPessoaSexo ;
      private GXCheckbox chkPessoaSituacao ;
      private IDataStoreProvider pr_default ;
      private bool[] H000N2_A7PessoaSituacao ;
      private String[] H000N2_A6PessoaSexo ;
      private String[] H000N2_A5PessoaEmail ;
      private String[] H000N2_A4PessoaTelefone ;
      private String[] H000N2_A3PessoaEndereco ;
      private String[] H000N2_A2PessoaNome ;
      private short[] H000N2_A1PessoaId ;
      private long[] H000N3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV10PessoaIdTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV12PessoaNomeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV14PessoaEnderecoTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV16PessoaTelefoneTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV18PessoaEmailTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV20PessoaSexoTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV22PessoaSituacaoTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV24DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class pessoaprompt__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H000N2( IGxContext context ,
                                             short AV8OrderedBy ,
                                             bool AV9OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [3] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [PessoaSituacao], [PessoaSexo], [PessoaEmail], [PessoaTelefone], [PessoaEndereco], [PessoaNome], [PessoaId]";
         sFromString = " FROM [Pessoa]";
         sOrderString = "";
         if ( ( AV8OrderedBy == 1 ) && ! AV9OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [PessoaId]";
         }
         else if ( ( AV8OrderedBy == 1 ) && ( AV9OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [PessoaId] DESC";
         }
         else if ( ( AV8OrderedBy == 2 ) && ! AV9OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [PessoaNome]";
         }
         else if ( ( AV8OrderedBy == 2 ) && ( AV9OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [PessoaNome] DESC";
         }
         else if ( ( AV8OrderedBy == 3 ) && ! AV9OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [PessoaEndereco]";
         }
         else if ( ( AV8OrderedBy == 3 ) && ( AV9OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [PessoaEndereco] DESC";
         }
         else if ( ( AV8OrderedBy == 4 ) && ! AV9OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [PessoaTelefone]";
         }
         else if ( ( AV8OrderedBy == 4 ) && ( AV9OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [PessoaTelefone] DESC";
         }
         else if ( ( AV8OrderedBy == 5 ) && ! AV9OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [PessoaEmail]";
         }
         else if ( ( AV8OrderedBy == 5 ) && ( AV9OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [PessoaEmail] DESC";
         }
         else if ( ( AV8OrderedBy == 6 ) && ! AV9OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [PessoaSexo]";
         }
         else if ( ( AV8OrderedBy == 6 ) && ( AV9OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [PessoaSexo] DESC";
         }
         else if ( ( AV8OrderedBy == 7 ) && ! AV9OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [PessoaSituacao]";
         }
         else if ( ( AV8OrderedBy == 7 ) && ( AV9OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [PessoaSituacao] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [PessoaId]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      protected Object[] conditional_H000N3( IGxContext context ,
                                             short AV8OrderedBy ,
                                             bool AV9OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [Pessoa]";
         if ( ( AV8OrderedBy == 1 ) && ! AV9OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV8OrderedBy == 1 ) && ( AV9OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV8OrderedBy == 2 ) && ! AV9OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV8OrderedBy == 2 ) && ( AV9OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV8OrderedBy == 3 ) && ! AV9OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV8OrderedBy == 3 ) && ( AV9OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV8OrderedBy == 4 ) && ! AV9OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV8OrderedBy == 4 ) && ( AV9OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV8OrderedBy == 5 ) && ! AV9OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV8OrderedBy == 5 ) && ( AV9OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV8OrderedBy == 6 ) && ! AV9OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV8OrderedBy == 6 ) && ( AV9OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV8OrderedBy == 7 ) && ! AV9OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV8OrderedBy == 7 ) && ( AV9OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( true )
         {
            scmdbuf = scmdbuf + "";
         }
         GXv_Object4[0] = scmdbuf;
         return GXv_Object4 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H000N2(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
               case 1 :
                     return conditional_H000N3(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
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
          Object[] prmH000N2 ;
          prmH000N2 = new Object[] {
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH000N3 ;
          prmH000N3 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H000N2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000N2,11, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("H000N3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000N3,1, GxCacheFrequency.OFF ,true,false )
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
                   stmt.SetParameter(sIdx, (int)parms[3]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[4]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[5]);
                }
                return;
       }
    }

 }

}
