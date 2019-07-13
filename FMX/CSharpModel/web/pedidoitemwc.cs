/*
               File: PedidoItemWC
        Description: Pedido Item WC
             Author: GeneXus C# Generator version 16_0_2-131213
       Generated on: 7/12/2019 17:59:28.80
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
   public class pedidoitemwc : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public pedidoitemwc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
            context.SetDefaultTheme("WorkWithPlusTheme");
         }
      }

      public pedidoitemwc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_PedidoId )
      {
         this.AV7PedidoId = aP0_PedidoId;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      public override void SetPrefix( String sPPrefix )
      {
         sPrefix = sPPrefix;
      }

      protected override void createObjects( )
      {
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "dyncomponent") == 0 )
               {
                  setAjaxEventMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  nDynComponent = 1;
                  sCompPrefix = GetNextPar( );
                  sSFPrefix = GetNextPar( );
                  AV7PedidoId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7PedidoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7PedidoId), 4, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(short)AV7PedidoId});
                  componentstart();
                  context.httpAjaxContext.ajax_rspStartCmp(sPrefix);
                  componentdraw();
                  context.httpAjaxContext.ajax_rspEndCmp();
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
                  nRC_GXsfl_15 = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  nGXsfl_15_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  sGXsfl_15_idx = GetNextPar( );
                  sPrefix = GetNextPar( );
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
                  AV7PedidoId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AV17ddo_ProdutoIdTitleControlIdToReplace = GetNextPar( );
                  AV19ddo_ProdutoNomeTitleControlIdToReplace = GetNextPar( );
                  AV21ddo_ProdutoValorTitleControlIdToReplace = GetNextPar( );
                  AV23ddo_PedidoItemQtdTitleControlIdToReplace = GetNextPar( );
                  AV31Pgmname = GetNextPar( );
                  sPrefix = GetNextPar( );
                  init_default_properties( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV7PedidoId, AV17ddo_ProdutoIdTitleControlIdToReplace, AV19ddo_ProdutoNomeTitleControlIdToReplace, AV21ddo_ProdutoValorTitleControlIdToReplace, AV23ddo_PedidoItemQtdTitleControlIdToReplace, AV31Pgmname, sPrefix) ;
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
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.IsLocalStorageSupported( ) )
            {
               context.PushCurrentUrl();
            }
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
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               ValidateSpaRequest();
            }
            PA172( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV31Pgmname = "PedidoItemWC";
               context.Gx_err = 0;
               WS172( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  if ( nDynComponent == 0 )
                  {
                     throw new System.Net.WebException("WebComponent is not allowed to run") ;
                  }
               }
            }
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

      protected void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      protected void RenderHtmlOpenForm( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
            context.WriteHtmlText( "<title>") ;
            context.SendWebValue( "Pedido Item WC") ;
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
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 131213), false, true);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 131213), false, true);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 131213), false, true);
         context.AddJavascriptSource("gxcfg.js", "?201971217592889", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
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
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.CloseHtmlHeader();
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
            FormProcess = " data-HasEnter=\"false\" data-Skiponenter=\"false\"";
            context.WriteHtmlText( "<body ") ;
            bodyStyle = "";
            if ( nGXWrapped == 0 )
            {
               bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
            }
            context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
            context.WriteHtmlText( FormProcess+">") ;
            context.skipLines(1);
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("pedidoitemwc.aspx") + "?" + UrlEncode("" +AV7PedidoId)+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
            context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, "FORM", "Class", "form-horizontal Form", true);
         }
         else
         {
            bool toggleHtmlOutput = isOutputEnabled( ) ;
            if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
            {
               if ( context.isSpaRequest( ) )
               {
                  disableOutput();
               }
            }
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gxwebcomponent-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            if ( toggleHtmlOutput )
            {
               if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
               {
                  if ( context.isSpaRequest( ) )
                  {
                     enableOutput();
                  }
               }
            }
            toggleJsOutput = isJsOutputEnabled( );
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vORDEREDDSC", StringUtil.BoolToStr( AV14OrderedDsc));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, sPrefix+"nRC_GXsfl_15", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_15), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV27GridCurrentPage), 10, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDPAGECOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV28GridPageCount), 10, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vDDO_TITLESETTINGSICONS", AV24DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vDDO_TITLESETTINGSICONS", AV24DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vPRODUTOIDTITLEFILTERDATA", AV16ProdutoIdTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vPRODUTOIDTITLEFILTERDATA", AV16ProdutoIdTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vPRODUTONOMETITLEFILTERDATA", AV18ProdutoNomeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vPRODUTONOMETITLEFILTERDATA", AV18ProdutoNomeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vPRODUTOVALORTITLEFILTERDATA", AV20ProdutoValorTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vPRODUTOVALORTITLEFILTERDATA", AV20ProdutoValorTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vPEDIDOITEMQTDTITLEFILTERDATA", AV22PedidoItemQtdTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vPEDIDOITEMQTDTITLEFILTERDATA", AV22PedidoItemQtdTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV7PedidoId", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOAV7PedidoId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vPGMNAME", StringUtil.RTrim( AV31Pgmname));
         GxWebStd.gx_hidden_field( context, sPrefix+"vPEDIDOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7PedidoId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Class", StringUtil.RTrim( Gridpaginationbar_Class));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Previous", StringUtil.RTrim( Gridpaginationbar_Previous));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Next", StringUtil.RTrim( Gridpaginationbar_Next));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Caption", StringUtil.RTrim( Gridpaginationbar_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Showfirst", StringUtil.BoolToStr( Gridpaginationbar_Showfirst));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Showprevious", StringUtil.BoolToStr( Gridpaginationbar_Showprevious));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Shownext", StringUtil.BoolToStr( Gridpaginationbar_Shownext));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Showlast", StringUtil.BoolToStr( Gridpaginationbar_Showlast));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Pagestoshow", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Pagestoshow), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Pagingbuttonsposition", StringUtil.RTrim( Gridpaginationbar_Pagingbuttonsposition));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Pagingcaptionposition", StringUtil.RTrim( Gridpaginationbar_Pagingcaptionposition));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Emptygridclass", StringUtil.RTrim( Gridpaginationbar_Emptygridclass));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselector", StringUtil.BoolToStr( Gridpaginationbar_Rowsperpageselector));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageoptions", StringUtil.RTrim( Gridpaginationbar_Rowsperpageoptions));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Emptygridcaption", StringUtil.RTrim( Gridpaginationbar_Emptygridcaption));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpagecaption", StringUtil.RTrim( Gridpaginationbar_Rowsperpagecaption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTOID_Caption", StringUtil.RTrim( Ddo_produtoid_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTOID_Tooltip", StringUtil.RTrim( Ddo_produtoid_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTOID_Cls", StringUtil.RTrim( Ddo_produtoid_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTOID_Dropdownoptionstype", StringUtil.RTrim( Ddo_produtoid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTOID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_produtoid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTOID_Includesortasc", StringUtil.BoolToStr( Ddo_produtoid_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTOID_Includesortdsc", StringUtil.BoolToStr( Ddo_produtoid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTOID_Sortedstatus", StringUtil.RTrim( Ddo_produtoid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTOID_Includefilter", StringUtil.BoolToStr( Ddo_produtoid_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTOID_Includedatalist", StringUtil.BoolToStr( Ddo_produtoid_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTOID_Sortasc", StringUtil.RTrim( Ddo_produtoid_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTOID_Sortdsc", StringUtil.RTrim( Ddo_produtoid_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTOID_Cleanfilter", StringUtil.RTrim( Ddo_produtoid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTOID_Searchbuttontext", StringUtil.RTrim( Ddo_produtoid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTONOME_Caption", StringUtil.RTrim( Ddo_produtonome_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTONOME_Tooltip", StringUtil.RTrim( Ddo_produtonome_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTONOME_Cls", StringUtil.RTrim( Ddo_produtonome_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTONOME_Dropdownoptionstype", StringUtil.RTrim( Ddo_produtonome_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTONOME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_produtonome_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTONOME_Includesortasc", StringUtil.BoolToStr( Ddo_produtonome_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTONOME_Includesortdsc", StringUtil.BoolToStr( Ddo_produtonome_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTONOME_Sortedstatus", StringUtil.RTrim( Ddo_produtonome_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTONOME_Includefilter", StringUtil.BoolToStr( Ddo_produtonome_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTONOME_Includedatalist", StringUtil.BoolToStr( Ddo_produtonome_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTONOME_Sortasc", StringUtil.RTrim( Ddo_produtonome_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTONOME_Sortdsc", StringUtil.RTrim( Ddo_produtonome_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTONOME_Cleanfilter", StringUtil.RTrim( Ddo_produtonome_Cleanfilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTONOME_Searchbuttontext", StringUtil.RTrim( Ddo_produtonome_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTOVALOR_Caption", StringUtil.RTrim( Ddo_produtovalor_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTOVALOR_Tooltip", StringUtil.RTrim( Ddo_produtovalor_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTOVALOR_Cls", StringUtil.RTrim( Ddo_produtovalor_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTOVALOR_Dropdownoptionstype", StringUtil.RTrim( Ddo_produtovalor_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTOVALOR_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_produtovalor_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTOVALOR_Includesortasc", StringUtil.BoolToStr( Ddo_produtovalor_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTOVALOR_Includesortdsc", StringUtil.BoolToStr( Ddo_produtovalor_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTOVALOR_Sortedstatus", StringUtil.RTrim( Ddo_produtovalor_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTOVALOR_Includefilter", StringUtil.BoolToStr( Ddo_produtovalor_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTOVALOR_Includedatalist", StringUtil.BoolToStr( Ddo_produtovalor_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTOVALOR_Sortasc", StringUtil.RTrim( Ddo_produtovalor_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTOVALOR_Sortdsc", StringUtil.RTrim( Ddo_produtovalor_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTOVALOR_Cleanfilter", StringUtil.RTrim( Ddo_produtovalor_Cleanfilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTOVALOR_Searchbuttontext", StringUtil.RTrim( Ddo_produtovalor_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PEDIDOITEMQTD_Caption", StringUtil.RTrim( Ddo_pedidoitemqtd_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PEDIDOITEMQTD_Tooltip", StringUtil.RTrim( Ddo_pedidoitemqtd_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PEDIDOITEMQTD_Cls", StringUtil.RTrim( Ddo_pedidoitemqtd_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PEDIDOITEMQTD_Dropdownoptionstype", StringUtil.RTrim( Ddo_pedidoitemqtd_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PEDIDOITEMQTD_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_pedidoitemqtd_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PEDIDOITEMQTD_Includesortasc", StringUtil.BoolToStr( Ddo_pedidoitemqtd_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PEDIDOITEMQTD_Includesortdsc", StringUtil.BoolToStr( Ddo_pedidoitemqtd_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PEDIDOITEMQTD_Sortedstatus", StringUtil.RTrim( Ddo_pedidoitemqtd_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PEDIDOITEMQTD_Includefilter", StringUtil.BoolToStr( Ddo_pedidoitemqtd_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PEDIDOITEMQTD_Includedatalist", StringUtil.BoolToStr( Ddo_pedidoitemqtd_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PEDIDOITEMQTD_Sortasc", StringUtil.RTrim( Ddo_pedidoitemqtd_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PEDIDOITEMQTD_Sortdsc", StringUtil.RTrim( Ddo_pedidoitemqtd_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PEDIDOITEMQTD_Cleanfilter", StringUtil.RTrim( Ddo_pedidoitemqtd_Cleanfilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PEDIDOITEMQTD_Searchbuttontext", StringUtil.RTrim( Ddo_pedidoitemqtd_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTOID_Activeeventkey", StringUtil.RTrim( Ddo_produtoid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTONOME_Activeeventkey", StringUtil.RTrim( Ddo_produtonome_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTOVALOR_Activeeventkey", StringUtil.RTrim( Ddo_produtovalor_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PEDIDOITEMQTD_Activeeventkey", StringUtil.RTrim( Ddo_pedidoitemqtd_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTOID_Activeeventkey", StringUtil.RTrim( Ddo_produtoid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTONOME_Activeeventkey", StringUtil.RTrim( Ddo_produtonome_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PRODUTOVALOR_Activeeventkey", StringUtil.RTrim( Ddo_produtovalor_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_PEDIDOITEMQTD_Activeeventkey", StringUtil.RTrim( Ddo_pedidoitemqtd_Activeeventkey));
      }

      protected void RenderHtmlCloseForm172( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("pedidoitemwc.js", "?201971217593037", false, true);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GX_FocusControl", GX_FocusControl);
         define_styles( ) ;
         SendSecurityToken(sPrefix);
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            SendAjaxEncryptionKey();
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
            context.WriteHtmlTextNl( "</body>") ;
            context.WriteHtmlTextNl( "</html>") ;
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
         }
         else
         {
            SendWebComponentState();
            context.WriteHtmlText( "</div>") ;
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
         }
      }

      public override String GetPgmname( )
      {
         return "PedidoItemWC" ;
      }

      public override String GetPgmdesc( )
      {
         return "Pedido Item WC" ;
      }

      protected void WB170( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               RenderHtmlHeaders( ) ;
            }
            RenderHtmlOpenForm( ) ;
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "pedidoitemwc.aspx");
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
            GxWebStd.gx_div_start( context, divTablegridheader_Internalname, 1, 0, "px", 0, "px", "Table100x100", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, sPrefix, "false");
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
               context.WriteHtmlText( "<div id=\""+sPrefix+"GridContainer"+"DivS\" data-gxgridid=\"15\">") ;
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
               if ( edtPedidoItemQtd_Titleformat == 0 )
               {
                  context.SendWebValue( edtPedidoItemQtd_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtPedidoItemQtd_Title) ;
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
               GridContainer.AddObjectProperty("CmpContext", sPrefix);
               GridContainer.AddObjectProperty("InMasterPage", "false");
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A8ProdutoId), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtProdutoId_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProdutoId_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A9ProdutoNome);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtProdutoNome_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProdutoNome_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtProdutoNome_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A11ProdutoValor, 12, 2, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtProdutoValor_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProdutoValor_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A38PedidoItemQtd), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtPedidoItemQtd_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPedidoItemQtd_Titleformat), 4, 0, ".", "")));
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
         if ( wbEnd == 15 )
         {
            wbEnd = 0;
            nRC_GXsfl_15 = (short)(nGXsfl_15_idx-1);
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+sPrefix+"GridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid(sPrefix+"_"+"Grid", GridContainer);
               if ( ! isAjaxCallMode( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData", GridContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData"+"V", GridContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+sPrefix+"GridContainerData"+"V"+"\" value='"+GridContainer.GridValuesHidden()+"'/>") ;
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV27GridCurrentPage);
            ucGridpaginationbar.SetProperty("PageCount", AV28GridPageCount);
            ucGridpaginationbar.Render(context, "dvelop.dvpaginationbar", Gridpaginationbar_Internalname, sPrefix+"GRIDPAGINATIONBARContainer");
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
            ucDdo_produtoid.SetProperty("DropDownOptionsTitleSettingsIcons", AV24DDO_TitleSettingsIcons);
            ucDdo_produtoid.SetProperty("DropDownOptionsData", AV16ProdutoIdTitleFilterData);
            ucDdo_produtoid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_produtoid_Internalname, sPrefix+"DDO_PRODUTOIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'" + sPrefix + "',false,'" + sGXsfl_15_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_produtoidtitlecontrolidtoreplace_Internalname, AV17ddo_ProdutoIdTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,27);\"", 0, edtavDdo_produtoidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_PedidoItemWC.htm");
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
            ucDdo_produtonome.SetProperty("DropDownOptionsTitleSettingsIcons", AV24DDO_TitleSettingsIcons);
            ucDdo_produtonome.SetProperty("DropDownOptionsData", AV18ProdutoNomeTitleFilterData);
            ucDdo_produtonome.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_produtonome_Internalname, sPrefix+"DDO_PRODUTONOMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'" + sPrefix + "',false,'" + sGXsfl_15_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_produtonometitlecontrolidtoreplace_Internalname, AV19ddo_ProdutoNomeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,29);\"", 0, edtavDdo_produtonometitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_PedidoItemWC.htm");
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
            ucDdo_produtovalor.SetProperty("DropDownOptionsTitleSettingsIcons", AV24DDO_TitleSettingsIcons);
            ucDdo_produtovalor.SetProperty("DropDownOptionsData", AV20ProdutoValorTitleFilterData);
            ucDdo_produtovalor.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_produtovalor_Internalname, sPrefix+"DDO_PRODUTOVALORContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 31,'" + sPrefix + "',false,'" + sGXsfl_15_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_produtovalortitlecontrolidtoreplace_Internalname, AV21ddo_ProdutoValorTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,31);\"", 0, edtavDdo_produtovalortitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_PedidoItemWC.htm");
            /* User Defined Control */
            ucDdo_pedidoitemqtd.SetProperty("Caption", Ddo_pedidoitemqtd_Caption);
            ucDdo_pedidoitemqtd.SetProperty("Tooltip", Ddo_pedidoitemqtd_Tooltip);
            ucDdo_pedidoitemqtd.SetProperty("Cls", Ddo_pedidoitemqtd_Cls);
            ucDdo_pedidoitemqtd.SetProperty("DropDownOptionsType", Ddo_pedidoitemqtd_Dropdownoptionstype);
            ucDdo_pedidoitemqtd.SetProperty("IncludeSortASC", Ddo_pedidoitemqtd_Includesortasc);
            ucDdo_pedidoitemqtd.SetProperty("IncludeSortDSC", Ddo_pedidoitemqtd_Includesortdsc);
            ucDdo_pedidoitemqtd.SetProperty("IncludeFilter", Ddo_pedidoitemqtd_Includefilter);
            ucDdo_pedidoitemqtd.SetProperty("IncludeDataList", Ddo_pedidoitemqtd_Includedatalist);
            ucDdo_pedidoitemqtd.SetProperty("SortASC", Ddo_pedidoitemqtd_Sortasc);
            ucDdo_pedidoitemqtd.SetProperty("SortDSC", Ddo_pedidoitemqtd_Sortdsc);
            ucDdo_pedidoitemqtd.SetProperty("CleanFilter", Ddo_pedidoitemqtd_Cleanfilter);
            ucDdo_pedidoitemqtd.SetProperty("SearchButtonText", Ddo_pedidoitemqtd_Searchbuttontext);
            ucDdo_pedidoitemqtd.SetProperty("DropDownOptionsTitleSettingsIcons", AV24DDO_TitleSettingsIcons);
            ucDdo_pedidoitemqtd.SetProperty("DropDownOptionsData", AV22PedidoItemQtdTitleFilterData);
            ucDdo_pedidoitemqtd.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_pedidoitemqtd_Internalname, sPrefix+"DDO_PEDIDOITEMQTDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'" + sPrefix + "',false,'" + sGXsfl_15_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_pedidoitemqtdtitlecontrolidtoreplace_Internalname, AV23ddo_PedidoItemQtdTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,33);\"", 0, edtavDdo_pedidoitemqtdtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_PedidoItemWC.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtPedidoId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A32PedidoId), 4, 0, ",", "")), context.localUtil.Format( (decimal)(A32PedidoId), "ZZZ9"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPedidoId_Jsonclick, 0, "Attribute", "", "", "", "", edtPedidoId_Visible, 0, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Serial", "right", false, "HLP_PedidoItemWC.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities_f5", Workwithplusutilities1_Internalname, sPrefix+"WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'" + sPrefix + "',false,'" + sGXsfl_15_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,36);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PedidoItemWC.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'" + sPrefix + "',false,'" + sGXsfl_15_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV14OrderedDsc), StringUtil.BoolToStr( AV14OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,37);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_PedidoItemWC.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 15 )
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
                  context.WriteHtmlText( "<div id=\""+sPrefix+"GridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
                  context.httpAjaxContext.ajax_rsp_assign_grid(sPrefix+"_"+"Grid", GridContainer);
                  if ( ! isAjaxCallMode( ) && ! context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData", GridContainer.ToJavascriptSource());
                  }
                  if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData"+"V", GridContainer.GridValuesHidden());
                  }
                  else
                  {
                     context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+sPrefix+"GridContainerData"+"V"+"\" value='"+GridContainer.GridValuesHidden()+"'/>") ;
                  }
               }
            }
         }
         wbLoad = true;
      }

      protected void START172( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_2-131213", 0) ;
               Form.Meta.addItem("description", "Pedido Item WC", 0) ;
            }
            context.wjLoc = "";
            context.nUserReturn = 0;
            context.wbHandled = 0;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               sXEvt = cgiGet( "_EventName");
               if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
               {
               }
            }
         }
         wbErr = false;
         if ( ( StringUtil.Len( sPrefix) == 0 ) || ( nDraw == 1 ) )
         {
            if ( nDoneStart == 0 )
            {
               STRUP170( ) ;
            }
         }
      }

      protected void WS172( )
      {
         START172( ) ;
         EVT172( ) ;
      }

      protected void EVT172( )
      {
         sXEvt = cgiGet( "_EventName");
         if ( ( ( ( StringUtil.Len( sPrefix) == 0 ) ) || ( StringUtil.StringSearch( sXEvt, sPrefix, 1) > 0 ) ) && ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               if ( context.wbHandled == 0 )
               {
                  if ( StringUtil.Len( sPrefix) == 0 )
                  {
                     sEvt = cgiGet( "_EventName");
                     EvtGridId = cgiGet( "_EventGridId");
                     EvtRowId = cgiGet( "_EventRowId");
                  }
                  if ( StringUtil.Len( sEvt) > 0 )
                  {
                     sEvtType = StringUtil.Left( sEvt, 1);
                     sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1));
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1);
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP170( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEPAGE") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP170( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E11172 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP170( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E12172 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PRODUTOID.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP170( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E13172 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PRODUTONOME.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP170( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E14172 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PRODUTOVALOR.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP170( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E15172 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PEDIDOITEMQTD.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP170( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E16172 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP170( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    GX_FocusControl = edtavDdo_produtoidtitlecontrolidtoreplace_Internalname;
                                    context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                 }
                              }
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP170( ) ;
                              }
                              nGXsfl_15_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_15_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_15_idx), 4, 0)), 4, "0");
                              SubsflControlProps_152( ) ;
                              A8ProdutoId = (short)(context.localUtil.CToN( cgiGet( edtProdutoId_Internalname), ",", "."));
                              A9ProdutoNome = cgiGet( edtProdutoNome_Internalname);
                              A11ProdutoValor = context.localUtil.CToN( cgiGet( edtProdutoValor_Internalname), ",", ".");
                              A38PedidoItemQtd = (short)(context.localUtil.CToN( cgiGet( edtPedidoItemQtd_Internalname), ",", "."));
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavDdo_produtoidtitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: Start */
                                          E17172 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavDdo_produtoidtitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: Refresh */
                                          E18172 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavDdo_produtoidtitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          E19172 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          if ( ! wbErr )
                                          {
                                             Rfr0gs = false;
                                             /* Set Refresh If Orderedby Changed */
                                             if ( ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vORDEREDBY"), ",", ".") != Convert.ToDecimal( AV13OrderedBy )) )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Ordereddsc Changed */
                                             if ( StringUtil.StrToBool( cgiGet( sPrefix+"GXH_vORDEREDDSC")) != AV14OrderedDsc )
                                             {
                                                Rfr0gs = true;
                                             }
                                             if ( ! Rfr0gs )
                                             {
                                             }
                                             dynload_actions( ) ;
                                          }
                                       }
                                    }
                                    /* No code required for Cancel button. It is implemented as the Reset button. */
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                                    {
                                       STRUP170( ) ;
                                    }
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavDdo_produtoidtitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                       }
                                    }
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

      protected void WE172( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm172( ) ;
            }
         }
      }

      protected void PA172( )
      {
         if ( nDonePA == 0 )
         {
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               initialize_properties( ) ;
            }
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
               {
                  gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
               }
            }
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            toggleJsOutput = isJsOutputEnabled( );
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( context.isSpaRequest( ) )
               {
                  disableJsOutput();
               }
            }
            init_web_controls( ) ;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( toggleJsOutput )
               {
                  if ( context.isSpaRequest( ) )
                  {
                     enableJsOutput();
                  }
               }
            }
            if ( ! context.isAjaxRequest( ) )
            {
               GX_FocusControl = edtavDdo_produtoidtitlecontrolidtoreplace_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
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
         SubsflControlProps_152( ) ;
         while ( nGXsfl_15_idx <= nRC_GXsfl_15 )
         {
            sendrow_152( ) ;
            nGXsfl_15_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_15_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_15_idx+1));
            sGXsfl_15_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_15_idx), 4, 0)), 4, "0");
            SubsflControlProps_152( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       short AV13OrderedBy ,
                                       bool AV14OrderedDsc ,
                                       short AV7PedidoId ,
                                       String AV17ddo_ProdutoIdTitleControlIdToReplace ,
                                       String AV19ddo_ProdutoNomeTitleControlIdToReplace ,
                                       String AV21ddo_ProdutoValorTitleControlIdToReplace ,
                                       String AV23ddo_PedidoItemQtdTitleControlIdToReplace ,
                                       String AV31Pgmname ,
                                       String sPrefix )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF172( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
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
         RF172( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV31Pgmname = "PedidoItemWC";
         context.Gx_err = 0;
      }

      protected void RF172( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 15;
         /* Execute user event: Refresh */
         E18172 ();
         nGXsfl_15_idx = 1;
         sGXsfl_15_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_15_idx), 4, 0)), 4, "0");
         SubsflControlProps_152( ) ;
         bGXsfl_15_Refreshing = true;
         GridContainer.AddObjectProperty("GridName", "Grid");
         GridContainer.AddObjectProperty("CmpContext", sPrefix);
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
            SubsflControlProps_152( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV13OrderedBy ,
                                                 AV14OrderedDsc ,
                                                 A32PedidoId ,
                                                 AV7PedidoId } ,
                                                 new int[]{
                                                 TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.SHORT
                                                 }
            } ) ;
            /* Using cursor H00172 */
            pr_default.execute(0, new Object[] {AV7PedidoId, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_15_idx = 1;
            sGXsfl_15_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_15_idx), 4, 0)), 4, "0");
            SubsflControlProps_152( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A32PedidoId = H00172_A32PedidoId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A32PedidoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A32PedidoId), 4, 0)));
               A38PedidoItemQtd = H00172_A38PedidoItemQtd[0];
               A11ProdutoValor = H00172_A11ProdutoValor[0];
               A9ProdutoNome = H00172_A9ProdutoNome[0];
               A8ProdutoId = H00172_A8ProdutoId[0];
               A11ProdutoValor = H00172_A11ProdutoValor[0];
               A9ProdutoNome = H00172_A9ProdutoNome[0];
               E19172 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 15;
            WB170( ) ;
         }
         bGXsfl_15_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes172( )
      {
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
                                              AV13OrderedBy ,
                                              AV14OrderedDsc ,
                                              A32PedidoId ,
                                              AV7PedidoId } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.SHORT
                                              }
         } ) ;
         /* Using cursor H00173 */
         pr_default.execute(1, new Object[] {AV7PedidoId});
         GRID_nRecordCount = H00173_AGRID_nRecordCount[0];
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
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV7PedidoId, AV17ddo_ProdutoIdTitleControlIdToReplace, AV19ddo_ProdutoNomeTitleControlIdToReplace, AV21ddo_ProdutoValorTitleControlIdToReplace, AV23ddo_PedidoItemQtdTitleControlIdToReplace, AV31Pgmname, sPrefix) ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GridContainer.AddObjectProperty("GRID_nFirstRecordOnPage", GRID_nFirstRecordOnPage);
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV7PedidoId, AV17ddo_ProdutoIdTitleControlIdToReplace, AV19ddo_ProdutoNomeTitleControlIdToReplace, AV21ddo_ProdutoValorTitleControlIdToReplace, AV23ddo_PedidoItemQtdTitleControlIdToReplace, AV31Pgmname, sPrefix) ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV7PedidoId, AV17ddo_ProdutoIdTitleControlIdToReplace, AV19ddo_ProdutoNomeTitleControlIdToReplace, AV21ddo_ProdutoValorTitleControlIdToReplace, AV23ddo_PedidoItemQtdTitleControlIdToReplace, AV31Pgmname, sPrefix) ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV7PedidoId, AV17ddo_ProdutoIdTitleControlIdToReplace, AV19ddo_ProdutoNomeTitleControlIdToReplace, AV21ddo_ProdutoValorTitleControlIdToReplace, AV23ddo_PedidoItemQtdTitleControlIdToReplace, AV31Pgmname, sPrefix) ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV7PedidoId, AV17ddo_ProdutoIdTitleControlIdToReplace, AV19ddo_ProdutoNomeTitleControlIdToReplace, AV21ddo_ProdutoValorTitleControlIdToReplace, AV23ddo_PedidoItemQtdTitleControlIdToReplace, AV31Pgmname, sPrefix) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP170( )
      {
         /* Before Start, stand alone formulas. */
         AV31Pgmname = "PedidoItemWC";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E17172 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vDDO_TITLESETTINGSICONS"), AV24DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vPRODUTOIDTITLEFILTERDATA"), AV16ProdutoIdTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vPRODUTONOMETITLEFILTERDATA"), AV18ProdutoNomeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vPRODUTOVALORTITLEFILTERDATA"), AV20ProdutoValorTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vPEDIDOITEMQTDTITLEFILTERDATA"), AV22PedidoItemQtdTitleFilterData);
            /* Read variables values. */
            AV17ddo_ProdutoIdTitleControlIdToReplace = cgiGet( edtavDdo_produtoidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV17ddo_ProdutoIdTitleControlIdToReplace", AV17ddo_ProdutoIdTitleControlIdToReplace);
            AV19ddo_ProdutoNomeTitleControlIdToReplace = cgiGet( edtavDdo_produtonometitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV19ddo_ProdutoNomeTitleControlIdToReplace", AV19ddo_ProdutoNomeTitleControlIdToReplace);
            AV21ddo_ProdutoValorTitleControlIdToReplace = cgiGet( edtavDdo_produtovalortitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV21ddo_ProdutoValorTitleControlIdToReplace", AV21ddo_ProdutoValorTitleControlIdToReplace);
            AV23ddo_PedidoItemQtdTitleControlIdToReplace = cgiGet( edtavDdo_pedidoitemqtdtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV23ddo_PedidoItemQtdTitleControlIdToReplace", AV23ddo_PedidoItemQtdTitleControlIdToReplace);
            A32PedidoId = (short)(context.localUtil.CToN( cgiGet( edtPedidoId_Internalname), ",", "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A32PedidoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A32PedidoId), 4, 0)));
            if ( ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vORDEREDBY");
               GX_FocusControl = edtavOrderedby_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV13OrderedBy = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            }
            else
            {
               AV13OrderedBy = (short)(context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            }
            AV14OrderedDsc = StringUtil.StrToBool( cgiGet( edtavOrdereddsc_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedDsc", AV14OrderedDsc);
            /* Read saved values. */
            nRC_GXsfl_15 = (short)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_GXsfl_15"), ",", "."));
            AV27GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDCURRENTPAGE"), ",", "."));
            AV28GridPageCount = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDPAGECOUNT"), ",", "."));
            wcpOAV7PedidoId = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV7PedidoId"), ",", "."));
            GRID_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_nFirstRecordOnPage"), ",", "."));
            GRID_nEOF = (short)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_nEOF"), ",", "."));
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_Rows"), ",", "."));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Class = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Class");
            Gridpaginationbar_Previous = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Previous");
            Gridpaginationbar_Next = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Next");
            Gridpaginationbar_Caption = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Caption");
            Gridpaginationbar_Showfirst = StringUtil.StrToBool( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Showfirst"));
            Gridpaginationbar_Showprevious = StringUtil.StrToBool( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Showprevious"));
            Gridpaginationbar_Shownext = StringUtil.StrToBool( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Shownext"));
            Gridpaginationbar_Showlast = StringUtil.StrToBool( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Showlast"));
            Gridpaginationbar_Pagestoshow = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Pagestoshow"), ",", "."));
            Gridpaginationbar_Pagingbuttonsposition = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Pagingbuttonsposition");
            Gridpaginationbar_Pagingcaptionposition = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Pagingcaptionposition");
            Gridpaginationbar_Emptygridclass = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Emptygridclass");
            Gridpaginationbar_Rowsperpageselector = StringUtil.StrToBool( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselector"));
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ",", "."));
            Gridpaginationbar_Rowsperpageoptions = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpageoptions");
            Gridpaginationbar_Emptygridcaption = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Emptygridcaption");
            Gridpaginationbar_Rowsperpagecaption = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpagecaption");
            Ddo_produtoid_Caption = cgiGet( sPrefix+"DDO_PRODUTOID_Caption");
            Ddo_produtoid_Tooltip = cgiGet( sPrefix+"DDO_PRODUTOID_Tooltip");
            Ddo_produtoid_Cls = cgiGet( sPrefix+"DDO_PRODUTOID_Cls");
            Ddo_produtoid_Dropdownoptionstype = cgiGet( sPrefix+"DDO_PRODUTOID_Dropdownoptionstype");
            Ddo_produtoid_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_PRODUTOID_Titlecontrolidtoreplace");
            Ddo_produtoid_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_PRODUTOID_Includesortasc"));
            Ddo_produtoid_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_PRODUTOID_Includesortdsc"));
            Ddo_produtoid_Sortedstatus = cgiGet( sPrefix+"DDO_PRODUTOID_Sortedstatus");
            Ddo_produtoid_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_PRODUTOID_Includefilter"));
            Ddo_produtoid_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_PRODUTOID_Includedatalist"));
            Ddo_produtoid_Sortasc = cgiGet( sPrefix+"DDO_PRODUTOID_Sortasc");
            Ddo_produtoid_Sortdsc = cgiGet( sPrefix+"DDO_PRODUTOID_Sortdsc");
            Ddo_produtoid_Cleanfilter = cgiGet( sPrefix+"DDO_PRODUTOID_Cleanfilter");
            Ddo_produtoid_Searchbuttontext = cgiGet( sPrefix+"DDO_PRODUTOID_Searchbuttontext");
            Ddo_produtonome_Caption = cgiGet( sPrefix+"DDO_PRODUTONOME_Caption");
            Ddo_produtonome_Tooltip = cgiGet( sPrefix+"DDO_PRODUTONOME_Tooltip");
            Ddo_produtonome_Cls = cgiGet( sPrefix+"DDO_PRODUTONOME_Cls");
            Ddo_produtonome_Dropdownoptionstype = cgiGet( sPrefix+"DDO_PRODUTONOME_Dropdownoptionstype");
            Ddo_produtonome_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_PRODUTONOME_Titlecontrolidtoreplace");
            Ddo_produtonome_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_PRODUTONOME_Includesortasc"));
            Ddo_produtonome_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_PRODUTONOME_Includesortdsc"));
            Ddo_produtonome_Sortedstatus = cgiGet( sPrefix+"DDO_PRODUTONOME_Sortedstatus");
            Ddo_produtonome_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_PRODUTONOME_Includefilter"));
            Ddo_produtonome_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_PRODUTONOME_Includedatalist"));
            Ddo_produtonome_Sortasc = cgiGet( sPrefix+"DDO_PRODUTONOME_Sortasc");
            Ddo_produtonome_Sortdsc = cgiGet( sPrefix+"DDO_PRODUTONOME_Sortdsc");
            Ddo_produtonome_Cleanfilter = cgiGet( sPrefix+"DDO_PRODUTONOME_Cleanfilter");
            Ddo_produtonome_Searchbuttontext = cgiGet( sPrefix+"DDO_PRODUTONOME_Searchbuttontext");
            Ddo_produtovalor_Caption = cgiGet( sPrefix+"DDO_PRODUTOVALOR_Caption");
            Ddo_produtovalor_Tooltip = cgiGet( sPrefix+"DDO_PRODUTOVALOR_Tooltip");
            Ddo_produtovalor_Cls = cgiGet( sPrefix+"DDO_PRODUTOVALOR_Cls");
            Ddo_produtovalor_Dropdownoptionstype = cgiGet( sPrefix+"DDO_PRODUTOVALOR_Dropdownoptionstype");
            Ddo_produtovalor_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_PRODUTOVALOR_Titlecontrolidtoreplace");
            Ddo_produtovalor_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_PRODUTOVALOR_Includesortasc"));
            Ddo_produtovalor_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_PRODUTOVALOR_Includesortdsc"));
            Ddo_produtovalor_Sortedstatus = cgiGet( sPrefix+"DDO_PRODUTOVALOR_Sortedstatus");
            Ddo_produtovalor_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_PRODUTOVALOR_Includefilter"));
            Ddo_produtovalor_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_PRODUTOVALOR_Includedatalist"));
            Ddo_produtovalor_Sortasc = cgiGet( sPrefix+"DDO_PRODUTOVALOR_Sortasc");
            Ddo_produtovalor_Sortdsc = cgiGet( sPrefix+"DDO_PRODUTOVALOR_Sortdsc");
            Ddo_produtovalor_Cleanfilter = cgiGet( sPrefix+"DDO_PRODUTOVALOR_Cleanfilter");
            Ddo_produtovalor_Searchbuttontext = cgiGet( sPrefix+"DDO_PRODUTOVALOR_Searchbuttontext");
            Ddo_pedidoitemqtd_Caption = cgiGet( sPrefix+"DDO_PEDIDOITEMQTD_Caption");
            Ddo_pedidoitemqtd_Tooltip = cgiGet( sPrefix+"DDO_PEDIDOITEMQTD_Tooltip");
            Ddo_pedidoitemqtd_Cls = cgiGet( sPrefix+"DDO_PEDIDOITEMQTD_Cls");
            Ddo_pedidoitemqtd_Dropdownoptionstype = cgiGet( sPrefix+"DDO_PEDIDOITEMQTD_Dropdownoptionstype");
            Ddo_pedidoitemqtd_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_PEDIDOITEMQTD_Titlecontrolidtoreplace");
            Ddo_pedidoitemqtd_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_PEDIDOITEMQTD_Includesortasc"));
            Ddo_pedidoitemqtd_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_PEDIDOITEMQTD_Includesortdsc"));
            Ddo_pedidoitemqtd_Sortedstatus = cgiGet( sPrefix+"DDO_PEDIDOITEMQTD_Sortedstatus");
            Ddo_pedidoitemqtd_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_PEDIDOITEMQTD_Includefilter"));
            Ddo_pedidoitemqtd_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_PEDIDOITEMQTD_Includedatalist"));
            Ddo_pedidoitemqtd_Sortasc = cgiGet( sPrefix+"DDO_PEDIDOITEMQTD_Sortasc");
            Ddo_pedidoitemqtd_Sortdsc = cgiGet( sPrefix+"DDO_PEDIDOITEMQTD_Sortdsc");
            Ddo_pedidoitemqtd_Cleanfilter = cgiGet( sPrefix+"DDO_PEDIDOITEMQTD_Cleanfilter");
            Ddo_pedidoitemqtd_Searchbuttontext = cgiGet( sPrefix+"DDO_PEDIDOITEMQTD_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_Rows"), ",", "."));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ",", "."));
            Ddo_produtoid_Activeeventkey = cgiGet( sPrefix+"DDO_PRODUTOID_Activeeventkey");
            Ddo_produtonome_Activeeventkey = cgiGet( sPrefix+"DDO_PRODUTONOME_Activeeventkey");
            Ddo_produtovalor_Activeeventkey = cgiGet( sPrefix+"DDO_PRODUTOVALOR_Activeeventkey");
            Ddo_pedidoitemqtd_Activeeventkey = cgiGet( sPrefix+"DDO_PEDIDOITEMQTD_Activeeventkey");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vORDEREDBY"), ",", ".") != Convert.ToDecimal( AV13OrderedBy )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( sPrefix+"GXH_vORDEREDDSC")) != AV14OrderedDsc )
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
         E17172 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E17172( )
      {
         /* Start Routine */
         subGrid_Rows = 10;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         Ddo_produtoid_Titlecontrolidtoreplace = subGrid_Internalname+"_ProdutoId";
         ucDdo_produtoid.SendProperty(context, sPrefix, false, Ddo_produtoid_Internalname, "TitleControlIdToReplace", Ddo_produtoid_Titlecontrolidtoreplace);
         AV17ddo_ProdutoIdTitleControlIdToReplace = Ddo_produtoid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV17ddo_ProdutoIdTitleControlIdToReplace", AV17ddo_ProdutoIdTitleControlIdToReplace);
         edtavDdo_produtoidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_produtoidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_produtoidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_produtonome_Titlecontrolidtoreplace = subGrid_Internalname+"_ProdutoNome";
         ucDdo_produtonome.SendProperty(context, sPrefix, false, Ddo_produtonome_Internalname, "TitleControlIdToReplace", Ddo_produtonome_Titlecontrolidtoreplace);
         AV19ddo_ProdutoNomeTitleControlIdToReplace = Ddo_produtonome_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV19ddo_ProdutoNomeTitleControlIdToReplace", AV19ddo_ProdutoNomeTitleControlIdToReplace);
         edtavDdo_produtonometitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_produtonometitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_produtonometitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_produtovalor_Titlecontrolidtoreplace = subGrid_Internalname+"_ProdutoValor";
         ucDdo_produtovalor.SendProperty(context, sPrefix, false, Ddo_produtovalor_Internalname, "TitleControlIdToReplace", Ddo_produtovalor_Titlecontrolidtoreplace);
         AV21ddo_ProdutoValorTitleControlIdToReplace = Ddo_produtovalor_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV21ddo_ProdutoValorTitleControlIdToReplace", AV21ddo_ProdutoValorTitleControlIdToReplace);
         edtavDdo_produtovalortitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_produtovalortitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_produtovalortitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_pedidoitemqtd_Titlecontrolidtoreplace = subGrid_Internalname+"_PedidoItemQtd";
         ucDdo_pedidoitemqtd.SendProperty(context, sPrefix, false, Ddo_pedidoitemqtd_Internalname, "TitleControlIdToReplace", Ddo_pedidoitemqtd_Titlecontrolidtoreplace);
         AV23ddo_PedidoItemQtdTitleControlIdToReplace = Ddo_pedidoitemqtd_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV23ddo_PedidoItemQtdTitleControlIdToReplace", AV23ddo_PedidoItemQtdTitleControlIdToReplace);
         edtavDdo_pedidoitemqtdtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_pedidoitemqtdtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_pedidoitemqtdtitlecontrolidtoreplace_Visible), 5, 0)), true);
         edtPedidoId_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtPedidoId_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPedidoId_Visible), 5, 0)), true);
         /* Execute user subroutine: 'PREPARETRANSACTION' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'LOADGRIDSTATE' */
         S122 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         edtavOrderedby_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavOrderedby_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrderedby_Visible), 5, 0)), true);
         if ( AV13OrderedBy < 1 )
         {
            AV13OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            /* Execute user subroutine: 'SETDDOSORTEDSTATUS' */
            S132 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
         edtavOrdereddsc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavOrdereddsc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrdereddsc_Visible), 5, 0)), true);
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV24DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV24DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, sPrefix, false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E18172( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV16ProdutoIdTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV18ProdutoNomeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20ProdutoValorTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV22PedidoItemQtdTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         /* Execute user subroutine: 'SAVEGRIDSTATE' */
         S142 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         edtProdutoId_Titleformat = 2;
         edtProdutoId_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Id", AV17ddo_ProdutoIdTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtProdutoId_Internalname, "Title", edtProdutoId_Title, !bGXsfl_15_Refreshing);
         edtProdutoNome_Titleformat = 2;
         edtProdutoNome_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Nome do Produto", AV19ddo_ProdutoNomeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtProdutoNome_Internalname, "Title", edtProdutoNome_Title, !bGXsfl_15_Refreshing);
         edtProdutoValor_Titleformat = 2;
         edtProdutoValor_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Valor do Produto", AV21ddo_ProdutoValorTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtProdutoValor_Internalname, "Title", edtProdutoValor_Title, !bGXsfl_15_Refreshing);
         edtPedidoItemQtd_Titleformat = 2;
         edtPedidoItemQtd_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Quantidade", AV23ddo_PedidoItemQtdTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtPedidoItemQtd_Internalname, "Title", edtPedidoItemQtd_Title, !bGXsfl_15_Refreshing);
         AV27GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV27GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV27GridCurrentPage), 10, 0)));
         AV28GridPageCount = subGrid_Pagecount( );
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV28GridPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV28GridPageCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV16ProdutoIdTitleFilterData", AV16ProdutoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV18ProdutoNomeTitleFilterData", AV18ProdutoNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV20ProdutoValorTitleFilterData", AV20ProdutoValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV22PedidoItemQtdTitleFilterData", AV22PedidoItemQtdTitleFilterData);
      }

      protected void E11172( )
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
            AV26PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV26PageToGo) ;
         }
      }

      protected void E12172( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E13172( )
      {
         /* Ddo_produtoid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_produtoid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_produtoid_Sortedstatus = "ASC";
            ucDdo_produtoid.SendProperty(context, sPrefix, false, Ddo_produtoid_Internalname, "SortedStatus", Ddo_produtoid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_produtoid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_produtoid_Sortedstatus = "DSC";
            ucDdo_produtoid.SendProperty(context, sPrefix, false, Ddo_produtoid_Internalname, "SortedStatus", Ddo_produtoid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV16ProdutoIdTitleFilterData", AV16ProdutoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV18ProdutoNomeTitleFilterData", AV18ProdutoNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV20ProdutoValorTitleFilterData", AV20ProdutoValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV22PedidoItemQtdTitleFilterData", AV22PedidoItemQtdTitleFilterData);
      }

      protected void E14172( )
      {
         /* Ddo_produtonome_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_produtonome_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_produtonome_Sortedstatus = "ASC";
            ucDdo_produtonome.SendProperty(context, sPrefix, false, Ddo_produtonome_Internalname, "SortedStatus", Ddo_produtonome_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_produtonome_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_produtonome_Sortedstatus = "DSC";
            ucDdo_produtonome.SendProperty(context, sPrefix, false, Ddo_produtonome_Internalname, "SortedStatus", Ddo_produtonome_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV16ProdutoIdTitleFilterData", AV16ProdutoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV18ProdutoNomeTitleFilterData", AV18ProdutoNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV20ProdutoValorTitleFilterData", AV20ProdutoValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV22PedidoItemQtdTitleFilterData", AV22PedidoItemQtdTitleFilterData);
      }

      protected void E15172( )
      {
         /* Ddo_produtovalor_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_produtovalor_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_produtovalor_Sortedstatus = "ASC";
            ucDdo_produtovalor.SendProperty(context, sPrefix, false, Ddo_produtovalor_Internalname, "SortedStatus", Ddo_produtovalor_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_produtovalor_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_produtovalor_Sortedstatus = "DSC";
            ucDdo_produtovalor.SendProperty(context, sPrefix, false, Ddo_produtovalor_Internalname, "SortedStatus", Ddo_produtovalor_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV16ProdutoIdTitleFilterData", AV16ProdutoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV18ProdutoNomeTitleFilterData", AV18ProdutoNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV20ProdutoValorTitleFilterData", AV20ProdutoValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV22PedidoItemQtdTitleFilterData", AV22PedidoItemQtdTitleFilterData);
      }

      protected void E16172( )
      {
         /* Ddo_pedidoitemqtd_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_pedidoitemqtd_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_pedidoitemqtd_Sortedstatus = "ASC";
            ucDdo_pedidoitemqtd.SendProperty(context, sPrefix, false, Ddo_pedidoitemqtd_Internalname, "SortedStatus", Ddo_pedidoitemqtd_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_pedidoitemqtd_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_pedidoitemqtd_Sortedstatus = "DSC";
            ucDdo_pedidoitemqtd.SendProperty(context, sPrefix, false, Ddo_pedidoitemqtd_Internalname, "SortedStatus", Ddo_pedidoitemqtd_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV16ProdutoIdTitleFilterData", AV16ProdutoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV18ProdutoNomeTitleFilterData", AV18ProdutoNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV20ProdutoValorTitleFilterData", AV20ProdutoValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV22PedidoItemQtdTitleFilterData", AV22PedidoItemQtdTitleFilterData);
      }

      private void E19172( )
      {
         /* Grid_Load Routine */
         edtProdutoNome_Link = formatLink("produtoview.aspx") + "?" + UrlEncode("" +A8ProdutoId) + "," + UrlEncode(StringUtil.RTrim(""));
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 15;
         }
         sendrow_152( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_15_Refreshing )
         {
            context.DoAjaxLoad(15, GridRow);
         }
         /*  Sending Event outputs  */
      }

      protected void S152( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_produtoid_Sortedstatus = "";
         ucDdo_produtoid.SendProperty(context, sPrefix, false, Ddo_produtoid_Internalname, "SortedStatus", Ddo_produtoid_Sortedstatus);
         Ddo_produtonome_Sortedstatus = "";
         ucDdo_produtonome.SendProperty(context, sPrefix, false, Ddo_produtonome_Internalname, "SortedStatus", Ddo_produtonome_Sortedstatus);
         Ddo_produtovalor_Sortedstatus = "";
         ucDdo_produtovalor.SendProperty(context, sPrefix, false, Ddo_produtovalor_Internalname, "SortedStatus", Ddo_produtovalor_Sortedstatus);
         Ddo_pedidoitemqtd_Sortedstatus = "";
         ucDdo_pedidoitemqtd.SendProperty(context, sPrefix, false, Ddo_pedidoitemqtd_Internalname, "SortedStatus", Ddo_pedidoitemqtd_Sortedstatus);
      }

      protected void S132( )
      {
         /* 'SETDDOSORTEDSTATUS' Routine */
         /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
         S152 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         if ( AV13OrderedBy == 1 )
         {
            Ddo_produtoid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_produtoid.SendProperty(context, sPrefix, false, Ddo_produtoid_Internalname, "SortedStatus", Ddo_produtoid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 2 )
         {
            Ddo_produtonome_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_produtonome.SendProperty(context, sPrefix, false, Ddo_produtonome_Internalname, "SortedStatus", Ddo_produtonome_Sortedstatus);
         }
         else if ( AV13OrderedBy == 3 )
         {
            Ddo_produtovalor_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_produtovalor.SendProperty(context, sPrefix, false, Ddo_produtovalor_Internalname, "SortedStatus", Ddo_produtovalor_Sortedstatus);
         }
         else if ( AV13OrderedBy == 4 )
         {
            Ddo_pedidoitemqtd_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_pedidoitemqtd.SendProperty(context, sPrefix, false, Ddo_pedidoitemqtd_Internalname, "SortedStatus", Ddo_pedidoitemqtd_Sortedstatus);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV15Session.Get(AV31Pgmname+"GridState"), "") == 0 )
         {
            AV11GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV31Pgmname+"GridState"), null, "WWPGridState", "FMX");
         }
         else
         {
            AV11GridState.FromXml(AV15Session.Get(AV31Pgmname+"GridState"), null, "WWPGridState", "FMX");
         }
         AV13OrderedBy = AV11GridState.gxTpr_Orderedby;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
         AV14OrderedDsc = AV11GridState.gxTpr_Ordereddsc;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedDsc", AV14OrderedDsc);
         /* Execute user subroutine: 'SETDDOSORTEDSTATUS' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( StringUtil.Trim( AV11GridState.gxTpr_Pagesize))) )
         {
            subGrid_Rows = (int)(NumberUtil.Val( AV11GridState.gxTpr_Pagesize, "."));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         }
      }

      protected void S142( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV11GridState.FromXml(AV15Session.Get(AV31Pgmname+"GridState"), null, "WWPGridState", "FMX");
         AV11GridState.gxTpr_Orderedby = AV13OrderedBy;
         AV11GridState.gxTpr_Ordereddsc = AV14OrderedDsc;
         AV11GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV31Pgmname+"GridState",  AV11GridState.ToXml(false, true, "WWPGridState", "FMX")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV31Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = true;
         AV9TrnContext.gxTpr_Callerurl = AV8HTTPRequest.ScriptName+"?"+AV8HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "Pedido";
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV10TrnContextAtt.gxTpr_Attributename = "PedidoId";
         AV10TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV7PedidoId), 4, 0);
         AV9TrnContext.gxTpr_Attributes.Add(AV10TrnContextAtt, 0);
         AV15Session.Set("TrnContext", AV9TrnContext.ToXml(false, true, "WWPTransactionContext", "FMX"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV7PedidoId = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7PedidoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7PedidoId), 4, 0)));
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
         PA172( ) ;
         WS172( ) ;
         WE172( ) ;
         this.cleanup();
         context.SetWrapped(false);
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      public override void componentbind( Object[] obj )
      {
         if ( IsUrlCreated( ) )
         {
            return  ;
         }
         sCtrlAV7PedidoId = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA172( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "pedidoitemwc", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA172( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            AV7PedidoId = Convert.ToInt16(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7PedidoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7PedidoId), 4, 0)));
         }
         wcpOAV7PedidoId = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV7PedidoId"), ",", "."));
         if ( ! GetJustCreated( ) && ( ( AV7PedidoId != wcpOAV7PedidoId ) ) )
         {
            setjustcreated();
         }
         wcpOAV7PedidoId = AV7PedidoId;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlAV7PedidoId = cgiGet( sPrefix+"AV7PedidoId_CTRL");
         if ( StringUtil.Len( sCtrlAV7PedidoId) > 0 )
         {
            AV7PedidoId = (short)(context.localUtil.CToN( cgiGet( sCtrlAV7PedidoId), ",", "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7PedidoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7PedidoId), 4, 0)));
         }
         else
         {
            AV7PedidoId = (short)(context.localUtil.CToN( cgiGet( sPrefix+"AV7PedidoId_PARM"), ",", "."));
         }
      }

      public override void componentprocess( String sPPrefix ,
                                             String sPSFPrefix ,
                                             String sCompEvt )
      {
         sCompPrefix = sPPrefix;
         sSFPrefix = sPSFPrefix;
         sPrefix = sCompPrefix + sSFPrefix;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         INITWEB( ) ;
         nDraw = 0;
         PA172( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS172( ) ;
         if ( isFullAjaxMode( ) )
         {
            componentdraw();
         }
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override void componentstart( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
      }

      protected void WCStart( )
      {
         nDraw = 1;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WS172( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"AV7PedidoId_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7PedidoId), 4, 0, ",", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV7PedidoId)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV7PedidoId_CTRL", StringUtil.RTrim( sCtrlAV7PedidoId));
         }
      }

      public override void componentdraw( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WCParametersSet( ) ;
         WE172( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override String getstring( String sGXControl )
      {
         String sCtrlName ;
         if ( StringUtil.StrCmp(StringUtil.Substring( sGXControl, 1, 1), "&") == 0 )
         {
            sCtrlName = StringUtil.Substring( sGXControl, 2, StringUtil.Len( sGXControl)-1);
         }
         else
         {
            sCtrlName = sGXControl;
         }
         return cgiGet( sPrefix+"v"+StringUtil.Upper( sCtrlName)) ;
      }

      public override void componentjscripts( )
      {
         include_jscripts( ) ;
      }

      public override void componentthemes( )
      {
         define_styles( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201971217593756", true, true);
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
         context.AddJavascriptSource("pedidoitemwc.js", "?201971217593756", false, true);
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
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_152( )
      {
         edtProdutoId_Internalname = sPrefix+"PRODUTOID_"+sGXsfl_15_idx;
         edtProdutoNome_Internalname = sPrefix+"PRODUTONOME_"+sGXsfl_15_idx;
         edtProdutoValor_Internalname = sPrefix+"PRODUTOVALOR_"+sGXsfl_15_idx;
         edtPedidoItemQtd_Internalname = sPrefix+"PEDIDOITEMQTD_"+sGXsfl_15_idx;
      }

      protected void SubsflControlProps_fel_152( )
      {
         edtProdutoId_Internalname = sPrefix+"PRODUTOID_"+sGXsfl_15_fel_idx;
         edtProdutoNome_Internalname = sPrefix+"PRODUTONOME_"+sGXsfl_15_fel_idx;
         edtProdutoValor_Internalname = sPrefix+"PRODUTOVALOR_"+sGXsfl_15_fel_idx;
         edtPedidoItemQtd_Internalname = sPrefix+"PEDIDOITEMQTD_"+sGXsfl_15_fel_idx;
      }

      protected void sendrow_152( )
      {
         SubsflControlProps_152( ) ;
         WB170( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_15_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_15_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_15_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtProdutoId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A8ProdutoId), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A8ProdutoId), "ZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtProdutoId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)15,(short)1,(short)-1,(short)0,(bool)true,(String)"Serial",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtProdutoNome_Internalname,(String)A9ProdutoNome,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)edtProdutoNome_Link,(String)"",(String)"",(String)"",(String)edtProdutoNome_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)15,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtProdutoValor_Internalname,StringUtil.LTrim( StringUtil.NToC( A11ProdutoValor, 12, 2, ",", "")),context.localUtil.Format( A11ProdutoValor, "R$ ZZ,ZZ9.99"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtProdutoValor_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)12,(short)0,(short)0,(short)15,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPedidoItemQtd_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A38PedidoItemQtd), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A38PedidoItemQtd), "ZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPedidoItemQtd_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)15,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            send_integrity_lvl_hashes172( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_15_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_15_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_15_idx+1));
            sGXsfl_15_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_15_idx), 4, 0)), 4, "0");
            SubsflControlProps_152( ) ;
         }
         /* End function sendrow_152 */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         edtProdutoId_Internalname = sPrefix+"PRODUTOID";
         edtProdutoNome_Internalname = sPrefix+"PRODUTONOME";
         edtProdutoValor_Internalname = sPrefix+"PRODUTOVALOR";
         edtPedidoItemQtd_Internalname = sPrefix+"PEDIDOITEMQTD";
         Gridpaginationbar_Internalname = sPrefix+"GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = sPrefix+"GRIDTABLEWITHPAGINATIONBAR";
         divTablegridheader_Internalname = sPrefix+"TABLEGRIDHEADER";
         Ddo_produtoid_Internalname = sPrefix+"DDO_PRODUTOID";
         edtavDdo_produtoidtitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE";
         Ddo_produtonome_Internalname = sPrefix+"DDO_PRODUTONOME";
         edtavDdo_produtonometitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE";
         Ddo_produtovalor_Internalname = sPrefix+"DDO_PRODUTOVALOR";
         edtavDdo_produtovalortitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE";
         Ddo_pedidoitemqtd_Internalname = sPrefix+"DDO_PEDIDOITEMQTD";
         edtavDdo_pedidoitemqtdtitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_PEDIDOITEMQTDTITLECONTROLIDTOREPLACE";
         edtPedidoId_Internalname = sPrefix+"PEDIDOID";
         Workwithplusutilities1_Internalname = sPrefix+"WORKWITHPLUSUTILITIES1";
         edtavOrderedby_Internalname = sPrefix+"vORDEREDBY";
         edtavOrdereddsc_Internalname = sPrefix+"vORDEREDDSC";
         divHtml_bottomauxiliarcontrols_Internalname = sPrefix+"HTML_BOTTOMAUXILIARCONTROLS";
         divLayoutmaintable_Internalname = sPrefix+"LAYOUTMAINTABLE";
         Form.Internalname = sPrefix+"FORM";
         subGrid_Internalname = sPrefix+"GRID";
      }

      public override void initialize_properties( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.SetDefaultTheme("WorkWithPlusTheme");
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         init_default_properties( ) ;
         edtPedidoItemQtd_Jsonclick = "";
         edtProdutoValor_Jsonclick = "";
         edtProdutoNome_Jsonclick = "";
         edtProdutoId_Jsonclick = "";
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtPedidoId_Jsonclick = "";
         edtPedidoId_Visible = 1;
         edtavDdo_pedidoitemqtdtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_produtovalortitlecontrolidtoreplace_Visible = 1;
         edtavDdo_produtonometitlecontrolidtoreplace_Visible = 1;
         edtavDdo_produtoidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtProdutoNome_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtPedidoItemQtd_Titleformat = 0;
         edtPedidoItemQtd_Title = "Quantidade";
         edtProdutoValor_Titleformat = 0;
         edtProdutoValor_Title = "Valor do Produto";
         edtProdutoNome_Titleformat = 0;
         edtProdutoNome_Title = "Nome do Produto";
         edtProdutoId_Titleformat = 0;
         edtProdutoId_Title = "Id";
         subGrid_Class = "GridWithPaginationBar GridNoBorder WorkWith";
         subGrid_Backcolorstyle = 0;
         Ddo_pedidoitemqtd_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_pedidoitemqtd_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_pedidoitemqtd_Sortdsc = "WWP_TSSortDSC";
         Ddo_pedidoitemqtd_Sortasc = "WWP_TSSortASC";
         Ddo_pedidoitemqtd_Includedatalist = Convert.ToBoolean( 0);
         Ddo_pedidoitemqtd_Includefilter = Convert.ToBoolean( 0);
         Ddo_pedidoitemqtd_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_pedidoitemqtd_Includesortasc = Convert.ToBoolean( -1);
         Ddo_pedidoitemqtd_Titlecontrolidtoreplace = "";
         Ddo_pedidoitemqtd_Dropdownoptionstype = "GridTitleSettings";
         Ddo_pedidoitemqtd_Cls = "ColumnSettings";
         Ddo_pedidoitemqtd_Tooltip = "WWP_TSColumnOptions";
         Ddo_pedidoitemqtd_Caption = "";
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
         subGrid_Rows = 0;
         context.GX_msglist.DisplayMode = 1;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV7PedidoId',fld:'vPEDIDOID',pic:'ZZZ9'},{av:'sPrefix'},{av:'AV17ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_PedidoItemQtdTitleControlIdToReplace',fld:'vDDO_PEDIDOITEMQTDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV16ProdutoIdTitleFilterData',fld:'vPRODUTOIDTITLEFILTERDATA',pic:''},{av:'AV18ProdutoNomeTitleFilterData',fld:'vPRODUTONOMETITLEFILTERDATA',pic:''},{av:'AV20ProdutoValorTitleFilterData',fld:'vPRODUTOVALORTITLEFILTERDATA',pic:''},{av:'AV22PedidoItemQtdTitleFilterData',fld:'vPEDIDOITEMQTDTITLEFILTERDATA',pic:''},{av:'edtProdutoId_Titleformat',ctrl:'PRODUTOID',prop:'Titleformat'},{av:'edtProdutoId_Title',ctrl:'PRODUTOID',prop:'Title'},{av:'edtProdutoNome_Titleformat',ctrl:'PRODUTONOME',prop:'Titleformat'},{av:'edtProdutoNome_Title',ctrl:'PRODUTONOME',prop:'Title'},{av:'edtProdutoValor_Titleformat',ctrl:'PRODUTOVALOR',prop:'Titleformat'},{av:'edtProdutoValor_Title',ctrl:'PRODUTOVALOR',prop:'Title'},{av:'edtPedidoItemQtd_Titleformat',ctrl:'PEDIDOITEMQTD',prop:'Titleformat'},{av:'edtPedidoItemQtd_Title',ctrl:'PEDIDOITEMQTD',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E11172',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV7PedidoId',fld:'vPEDIDOID',pic:'ZZZ9'},{av:'AV17ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_PedidoItemQtdTitleControlIdToReplace',fld:'vDDO_PEDIDOITEMQTDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31Pgmname',fld:'vPGMNAME',pic:''},{av:'sPrefix'},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E12172',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV7PedidoId',fld:'vPEDIDOID',pic:'ZZZ9'},{av:'AV17ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_PedidoItemQtdTitleControlIdToReplace',fld:'vDDO_PEDIDOITEMQTDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31Pgmname',fld:'vPGMNAME',pic:''},{av:'sPrefix'},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_PRODUTOID.ONOPTIONCLICKED","{handler:'E13172',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV7PedidoId',fld:'vPEDIDOID',pic:'ZZZ9'},{av:'AV17ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_PedidoItemQtdTitleControlIdToReplace',fld:'vDDO_PEDIDOITEMQTDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31Pgmname',fld:'vPGMNAME',pic:''},{av:'sPrefix'},{av:'Ddo_produtoid_Activeeventkey',ctrl:'DDO_PRODUTOID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_PRODUTOID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_produtoid_Sortedstatus',ctrl:'DDO_PRODUTOID',prop:'SortedStatus'},{av:'Ddo_produtonome_Sortedstatus',ctrl:'DDO_PRODUTONOME',prop:'SortedStatus'},{av:'Ddo_produtovalor_Sortedstatus',ctrl:'DDO_PRODUTOVALOR',prop:'SortedStatus'},{av:'Ddo_pedidoitemqtd_Sortedstatus',ctrl:'DDO_PEDIDOITEMQTD',prop:'SortedStatus'},{av:'AV16ProdutoIdTitleFilterData',fld:'vPRODUTOIDTITLEFILTERDATA',pic:''},{av:'AV18ProdutoNomeTitleFilterData',fld:'vPRODUTONOMETITLEFILTERDATA',pic:''},{av:'AV20ProdutoValorTitleFilterData',fld:'vPRODUTOVALORTITLEFILTERDATA',pic:''},{av:'AV22PedidoItemQtdTitleFilterData',fld:'vPEDIDOITEMQTDTITLEFILTERDATA',pic:''},{av:'edtProdutoId_Titleformat',ctrl:'PRODUTOID',prop:'Titleformat'},{av:'edtProdutoId_Title',ctrl:'PRODUTOID',prop:'Title'},{av:'edtProdutoNome_Titleformat',ctrl:'PRODUTONOME',prop:'Titleformat'},{av:'edtProdutoNome_Title',ctrl:'PRODUTONOME',prop:'Title'},{av:'edtProdutoValor_Titleformat',ctrl:'PRODUTOVALOR',prop:'Titleformat'},{av:'edtProdutoValor_Title',ctrl:'PRODUTOVALOR',prop:'Title'},{av:'edtPedidoItemQtd_Titleformat',ctrl:'PEDIDOITEMQTD',prop:'Titleformat'},{av:'edtPedidoItemQtd_Title',ctrl:'PEDIDOITEMQTD',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_PRODUTONOME.ONOPTIONCLICKED","{handler:'E14172',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV7PedidoId',fld:'vPEDIDOID',pic:'ZZZ9'},{av:'AV17ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_PedidoItemQtdTitleControlIdToReplace',fld:'vDDO_PEDIDOITEMQTDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31Pgmname',fld:'vPGMNAME',pic:''},{av:'sPrefix'},{av:'Ddo_produtonome_Activeeventkey',ctrl:'DDO_PRODUTONOME',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_PRODUTONOME.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_produtonome_Sortedstatus',ctrl:'DDO_PRODUTONOME',prop:'SortedStatus'},{av:'Ddo_produtoid_Sortedstatus',ctrl:'DDO_PRODUTOID',prop:'SortedStatus'},{av:'Ddo_produtovalor_Sortedstatus',ctrl:'DDO_PRODUTOVALOR',prop:'SortedStatus'},{av:'Ddo_pedidoitemqtd_Sortedstatus',ctrl:'DDO_PEDIDOITEMQTD',prop:'SortedStatus'},{av:'AV16ProdutoIdTitleFilterData',fld:'vPRODUTOIDTITLEFILTERDATA',pic:''},{av:'AV18ProdutoNomeTitleFilterData',fld:'vPRODUTONOMETITLEFILTERDATA',pic:''},{av:'AV20ProdutoValorTitleFilterData',fld:'vPRODUTOVALORTITLEFILTERDATA',pic:''},{av:'AV22PedidoItemQtdTitleFilterData',fld:'vPEDIDOITEMQTDTITLEFILTERDATA',pic:''},{av:'edtProdutoId_Titleformat',ctrl:'PRODUTOID',prop:'Titleformat'},{av:'edtProdutoId_Title',ctrl:'PRODUTOID',prop:'Title'},{av:'edtProdutoNome_Titleformat',ctrl:'PRODUTONOME',prop:'Titleformat'},{av:'edtProdutoNome_Title',ctrl:'PRODUTONOME',prop:'Title'},{av:'edtProdutoValor_Titleformat',ctrl:'PRODUTOVALOR',prop:'Titleformat'},{av:'edtProdutoValor_Title',ctrl:'PRODUTOVALOR',prop:'Title'},{av:'edtPedidoItemQtd_Titleformat',ctrl:'PEDIDOITEMQTD',prop:'Titleformat'},{av:'edtPedidoItemQtd_Title',ctrl:'PEDIDOITEMQTD',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_PRODUTOVALOR.ONOPTIONCLICKED","{handler:'E15172',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV7PedidoId',fld:'vPEDIDOID',pic:'ZZZ9'},{av:'AV17ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_PedidoItemQtdTitleControlIdToReplace',fld:'vDDO_PEDIDOITEMQTDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31Pgmname',fld:'vPGMNAME',pic:''},{av:'sPrefix'},{av:'Ddo_produtovalor_Activeeventkey',ctrl:'DDO_PRODUTOVALOR',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_PRODUTOVALOR.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_produtovalor_Sortedstatus',ctrl:'DDO_PRODUTOVALOR',prop:'SortedStatus'},{av:'Ddo_produtoid_Sortedstatus',ctrl:'DDO_PRODUTOID',prop:'SortedStatus'},{av:'Ddo_produtonome_Sortedstatus',ctrl:'DDO_PRODUTONOME',prop:'SortedStatus'},{av:'Ddo_pedidoitemqtd_Sortedstatus',ctrl:'DDO_PEDIDOITEMQTD',prop:'SortedStatus'},{av:'AV16ProdutoIdTitleFilterData',fld:'vPRODUTOIDTITLEFILTERDATA',pic:''},{av:'AV18ProdutoNomeTitleFilterData',fld:'vPRODUTONOMETITLEFILTERDATA',pic:''},{av:'AV20ProdutoValorTitleFilterData',fld:'vPRODUTOVALORTITLEFILTERDATA',pic:''},{av:'AV22PedidoItemQtdTitleFilterData',fld:'vPEDIDOITEMQTDTITLEFILTERDATA',pic:''},{av:'edtProdutoId_Titleformat',ctrl:'PRODUTOID',prop:'Titleformat'},{av:'edtProdutoId_Title',ctrl:'PRODUTOID',prop:'Title'},{av:'edtProdutoNome_Titleformat',ctrl:'PRODUTONOME',prop:'Titleformat'},{av:'edtProdutoNome_Title',ctrl:'PRODUTONOME',prop:'Title'},{av:'edtProdutoValor_Titleformat',ctrl:'PRODUTOVALOR',prop:'Titleformat'},{av:'edtProdutoValor_Title',ctrl:'PRODUTOVALOR',prop:'Title'},{av:'edtPedidoItemQtd_Titleformat',ctrl:'PEDIDOITEMQTD',prop:'Titleformat'},{av:'edtPedidoItemQtd_Title',ctrl:'PEDIDOITEMQTD',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_PEDIDOITEMQTD.ONOPTIONCLICKED","{handler:'E16172',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV7PedidoId',fld:'vPEDIDOID',pic:'ZZZ9'},{av:'AV17ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_PedidoItemQtdTitleControlIdToReplace',fld:'vDDO_PEDIDOITEMQTDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31Pgmname',fld:'vPGMNAME',pic:''},{av:'sPrefix'},{av:'Ddo_pedidoitemqtd_Activeeventkey',ctrl:'DDO_PEDIDOITEMQTD',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_PEDIDOITEMQTD.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_pedidoitemqtd_Sortedstatus',ctrl:'DDO_PEDIDOITEMQTD',prop:'SortedStatus'},{av:'Ddo_produtoid_Sortedstatus',ctrl:'DDO_PRODUTOID',prop:'SortedStatus'},{av:'Ddo_produtonome_Sortedstatus',ctrl:'DDO_PRODUTONOME',prop:'SortedStatus'},{av:'Ddo_produtovalor_Sortedstatus',ctrl:'DDO_PRODUTOVALOR',prop:'SortedStatus'},{av:'AV16ProdutoIdTitleFilterData',fld:'vPRODUTOIDTITLEFILTERDATA',pic:''},{av:'AV18ProdutoNomeTitleFilterData',fld:'vPRODUTONOMETITLEFILTERDATA',pic:''},{av:'AV20ProdutoValorTitleFilterData',fld:'vPRODUTOVALORTITLEFILTERDATA',pic:''},{av:'AV22PedidoItemQtdTitleFilterData',fld:'vPEDIDOITEMQTDTITLEFILTERDATA',pic:''},{av:'edtProdutoId_Titleformat',ctrl:'PRODUTOID',prop:'Titleformat'},{av:'edtProdutoId_Title',ctrl:'PRODUTOID',prop:'Title'},{av:'edtProdutoNome_Titleformat',ctrl:'PRODUTONOME',prop:'Titleformat'},{av:'edtProdutoNome_Title',ctrl:'PRODUTONOME',prop:'Title'},{av:'edtProdutoValor_Titleformat',ctrl:'PRODUTOVALOR',prop:'Titleformat'},{av:'edtProdutoValor_Title',ctrl:'PRODUTOVALOR',prop:'Title'},{av:'edtPedidoItemQtd_Titleformat',ctrl:'PEDIDOITEMQTD',prop:'Titleformat'},{av:'edtPedidoItemQtd_Title',ctrl:'PEDIDOITEMQTD',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E19172',iparms:[{av:'A8ProdutoId',fld:'PRODUTOID',pic:'ZZZ9'}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'edtProdutoNome_Link',ctrl:'PRODUTONOME',prop:'Link'}]}");
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
         Ddo_produtonome_Activeeventkey = "";
         Ddo_produtovalor_Activeeventkey = "";
         Ddo_pedidoitemqtd_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sPrefix = "";
         AV17ddo_ProdutoIdTitleControlIdToReplace = "";
         AV19ddo_ProdutoNomeTitleControlIdToReplace = "";
         AV21ddo_ProdutoValorTitleControlIdToReplace = "";
         AV23ddo_PedidoItemQtdTitleControlIdToReplace = "";
         AV31Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV24DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV16ProdutoIdTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV18ProdutoNomeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20ProdutoValorTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV22PedidoItemQtdTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_produtoid_Sortedstatus = "";
         Ddo_produtonome_Sortedstatus = "";
         Ddo_produtovalor_Sortedstatus = "";
         Ddo_pedidoitemqtd_Sortedstatus = "";
         GX_FocusControl = "";
         ClassString = "";
         StyleString = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         A9ProdutoNome = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_produtoid = new GXUserControl();
         TempTags = "";
         ucDdo_produtonome = new GXUserControl();
         ucDdo_produtovalor = new GXUserControl();
         ucDdo_pedidoitemqtd = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H00172_A32PedidoId = new short[1] ;
         H00172_A38PedidoItemQtd = new short[1] ;
         H00172_A11ProdutoValor = new decimal[1] ;
         H00172_A9ProdutoNome = new String[] {""} ;
         H00172_A8ProdutoId = new short[1] ;
         H00173_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         AV15Session = context.GetSession();
         AV11GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV8HTTPRequest = new GxHttpRequest( context);
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlAV7PedidoId = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pedidoitemwc__default(),
            new Object[][] {
                new Object[] {
               H00172_A32PedidoId, H00172_A38PedidoItemQtd, H00172_A11ProdutoValor, H00172_A9ProdutoNome, H00172_A8ProdutoId
               }
               , new Object[] {
               H00173_AGRID_nRecordCount
               }
            }
         );
         AV31Pgmname = "PedidoItemWC";
         /* GeneXus formulas. */
         AV31Pgmname = "PedidoItemWC";
         context.Gx_err = 0;
      }

      private short AV7PedidoId ;
      private short wcpOAV7PedidoId ;
      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short nRC_GXsfl_15 ;
      private short nGXsfl_15_idx=1 ;
      private short GRID_nEOF ;
      private short AV13OrderedBy ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtProdutoId_Titleformat ;
      private short edtProdutoNome_Titleformat ;
      private short edtProdutoValor_Titleformat ;
      private short edtPedidoItemQtd_Titleformat ;
      private short subGrid_Sortable ;
      private short A8ProdutoId ;
      private short A38PedidoItemQtd ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short A32PedidoId ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short subGrid_Backstyle ;
      private int subGrid_Rows ;
      private int Gridpaginationbar_Rowsperpageselectedvalue ;
      private int Gridpaginationbar_Pagestoshow ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_produtoidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_produtonometitlecontrolidtoreplace_Visible ;
      private int edtavDdo_produtovalortitlecontrolidtoreplace_Visible ;
      private int edtavDdo_pedidoitemqtdtitlecontrolidtoreplace_Visible ;
      private int edtPedidoId_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV26PageToGo ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long AV27GridCurrentPage ;
      private long AV28GridPageCount ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private decimal A11ProdutoValor ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_produtoid_Activeeventkey ;
      private String Ddo_produtonome_Activeeventkey ;
      private String Ddo_produtovalor_Activeeventkey ;
      private String Ddo_pedidoitemqtd_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String sGXsfl_15_idx="0001" ;
      private String AV31Pgmname ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
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
      private String Ddo_pedidoitemqtd_Caption ;
      private String Ddo_pedidoitemqtd_Tooltip ;
      private String Ddo_pedidoitemqtd_Cls ;
      private String Ddo_pedidoitemqtd_Dropdownoptionstype ;
      private String Ddo_pedidoitemqtd_Titlecontrolidtoreplace ;
      private String Ddo_pedidoitemqtd_Sortedstatus ;
      private String Ddo_pedidoitemqtd_Sortasc ;
      private String Ddo_pedidoitemqtd_Sortdsc ;
      private String Ddo_pedidoitemqtd_Cleanfilter ;
      private String Ddo_pedidoitemqtd_Searchbuttontext ;
      private String GX_FocusControl ;
      private String divLayoutmaintable_Internalname ;
      private String divTablegridheader_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtProdutoId_Title ;
      private String edtProdutoNome_Title ;
      private String edtProdutoValor_Title ;
      private String edtPedidoItemQtd_Title ;
      private String subGrid_Header ;
      private String edtProdutoNome_Link ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_produtoid_Internalname ;
      private String TempTags ;
      private String edtavDdo_produtoidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_produtonome_Internalname ;
      private String edtavDdo_produtonometitlecontrolidtoreplace_Internalname ;
      private String Ddo_produtovalor_Internalname ;
      private String edtavDdo_produtovalortitlecontrolidtoreplace_Internalname ;
      private String Ddo_pedidoitemqtd_Internalname ;
      private String edtavDdo_pedidoitemqtdtitlecontrolidtoreplace_Internalname ;
      private String edtPedidoId_Internalname ;
      private String edtPedidoId_Jsonclick ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtProdutoId_Internalname ;
      private String edtProdutoNome_Internalname ;
      private String edtProdutoValor_Internalname ;
      private String edtPedidoItemQtd_Internalname ;
      private String scmdbuf ;
      private String sCtrlAV7PedidoId ;
      private String sGXsfl_15_fel_idx="0001" ;
      private String ROClassString ;
      private String edtProdutoId_Jsonclick ;
      private String edtProdutoNome_Jsonclick ;
      private String edtProdutoValor_Jsonclick ;
      private String edtPedidoItemQtd_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV14OrderedDsc ;
      private bool toggleJsOutput ;
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
      private bool Ddo_produtovalor_Includesortasc ;
      private bool Ddo_produtovalor_Includesortdsc ;
      private bool Ddo_produtovalor_Includefilter ;
      private bool Ddo_produtovalor_Includedatalist ;
      private bool Ddo_pedidoitemqtd_Includesortasc ;
      private bool Ddo_pedidoitemqtd_Includesortdsc ;
      private bool Ddo_pedidoitemqtd_Includefilter ;
      private bool Ddo_pedidoitemqtd_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_15_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private String AV17ddo_ProdutoIdTitleControlIdToReplace ;
      private String AV19ddo_ProdutoNomeTitleControlIdToReplace ;
      private String AV21ddo_ProdutoValorTitleControlIdToReplace ;
      private String AV23ddo_PedidoItemQtdTitleControlIdToReplace ;
      private String A9ProdutoNome ;
      private IGxSession AV15Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_produtoid ;
      private GXUserControl ucDdo_produtonome ;
      private GXUserControl ucDdo_produtovalor ;
      private GXUserControl ucDdo_pedidoitemqtd ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] H00172_A32PedidoId ;
      private short[] H00172_A38PedidoItemQtd ;
      private decimal[] H00172_A11ProdutoValor ;
      private String[] H00172_A9ProdutoNome ;
      private short[] H00172_A8ProdutoId ;
      private long[] H00173_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV8HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV16ProdutoIdTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV18ProdutoNomeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV20ProdutoValorTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV22PedidoItemQtdTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV10TrnContextAtt ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV11GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV24DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class pedidoitemwc__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00172( IGxContext context ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc ,
                                             short A32PedidoId ,
                                             short AV7PedidoId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [4] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " T1.[PedidoId], T1.[PedidoItemQtd], T2.[ProdutoValor], T2.[ProdutoNome], T1.[ProdutoId]";
         sFromString = " FROM ([PedidoItem] T1 INNER JOIN [Produto] T2 ON T2.[ProdutoId] = T1.[ProdutoId])";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE (T1.[PedidoId] = @AV7PedidoId)";
         if ( ( AV13OrderedBy == 1 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[PedidoId], T1.[ProdutoId]";
         }
         else if ( ( AV13OrderedBy == 1 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[PedidoId] DESC, T1.[ProdutoId] DESC";
         }
         else if ( ( AV13OrderedBy == 2 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[PedidoId], T2.[ProdutoNome]";
         }
         else if ( ( AV13OrderedBy == 2 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[PedidoId] DESC, T2.[ProdutoNome] DESC";
         }
         else if ( ( AV13OrderedBy == 3 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[PedidoId], T2.[ProdutoValor]";
         }
         else if ( ( AV13OrderedBy == 3 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[PedidoId] DESC, T2.[ProdutoValor] DESC";
         }
         else if ( ( AV13OrderedBy == 4 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[PedidoId], T1.[PedidoItemQtd]";
         }
         else if ( ( AV13OrderedBy == 4 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[PedidoId] DESC, T1.[PedidoItemQtd] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY T1.[PedidoId], T1.[ProdutoId]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      protected Object[] conditional_H00173( IGxContext context ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc ,
                                             short A32PedidoId ,
                                             short AV7PedidoId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [1] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM ([PedidoItem] T1 INNER JOIN [Produto] T2 ON T2.[ProdutoId] = T1.[ProdutoId])";
         scmdbuf = scmdbuf + " WHERE (T1.[PedidoId] = @AV7PedidoId)";
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
                     return conditional_H00172(context, (short)dynConstraints[0] , (bool)dynConstraints[1] , (short)dynConstraints[2] , (short)dynConstraints[3] );
               case 1 :
                     return conditional_H00173(context, (short)dynConstraints[0] , (bool)dynConstraints[1] , (short)dynConstraints[2] , (short)dynConstraints[3] );
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
          Object[] prmH00172 ;
          prmH00172 = new Object[] {
          new Object[] {"@AV7PedidoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00173 ;
          prmH00173 = new Object[] {
          new Object[] {"@AV7PedidoId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00172", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00172,11, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("H00173", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00173,1, GxCacheFrequency.OFF ,true,false )
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
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
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
                   stmt.SetParameter(sIdx, (short)parms[4]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[5]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[6]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[7]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[1]);
                }
                return;
       }
    }

 }

}
