/*
               File: PedidoItemPrompt
        Description: Consulta de Item
             Author: GeneXus C# Generator version 16_0_2-131213
       Generated on: 7/12/2019 18:0:5.64
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
   public class pedidoitemprompt : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public pedidoitemprompt( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public pedidoitemprompt( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_InPedidoId ,
                           ref short aP1_InOutProdutoId ,
                           ref short aP2_InOutPedidoItemQtd )
      {
         this.AV43InPedidoId = aP0_InPedidoId;
         this.AV44InOutProdutoId = aP1_InOutProdutoId;
         this.AV45InOutPedidoItemQtd = aP2_InOutPedidoItemQtd;
         executePrivate();
         aP1_InOutProdutoId=this.AV44InOutProdutoId;
         aP2_InOutPedidoItemQtd=this.AV45InOutPedidoItemQtd;
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
               nRC_GXsfl_104 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_104_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_104_idx = GetNextPar( );
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
               AV15PedidoItemQtd1 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV16ProdutoNome1 = GetNextPar( );
               AV18DynamicFiltersSelector2 = GetNextPar( );
               AV19DynamicFiltersOperator2 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV20PedidoItemQtd2 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV21ProdutoNome2 = GetNextPar( );
               AV23DynamicFiltersSelector3 = GetNextPar( );
               AV24DynamicFiltersOperator3 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV25PedidoItemQtd3 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV26ProdutoNome3 = GetNextPar( );
               AV17DynamicFiltersEnabled2 = StringUtil.StrToBool( GetNextPar( ));
               AV22DynamicFiltersEnabled3 = StringUtil.StrToBool( GetNextPar( ));
               AV11OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV12OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV43InPedidoId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV31ddo_ProdutoIdTitleControlIdToReplace = GetNextPar( );
               AV33ddo_ProdutoNomeTitleControlIdToReplace = GetNextPar( );
               AV35ddo_ProdutoValorTitleControlIdToReplace = GetNextPar( );
               AV37ddo_PedidoItemQtdTitleControlIdToReplace = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15PedidoItemQtd1, AV16ProdutoNome1, AV18DynamicFiltersSelector2, AV19DynamicFiltersOperator2, AV20PedidoItemQtd2, AV21ProdutoNome2, AV23DynamicFiltersSelector3, AV24DynamicFiltersOperator3, AV25PedidoItemQtd3, AV26ProdutoNome3, AV17DynamicFiltersEnabled2, AV22DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV43InPedidoId, AV31ddo_ProdutoIdTitleControlIdToReplace, AV33ddo_ProdutoNomeTitleControlIdToReplace, AV35ddo_ProdutoValorTitleControlIdToReplace, AV37ddo_PedidoItemQtdTitleControlIdToReplace) ;
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
               AV43InPedidoId = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43InPedidoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV43InPedidoId), 4, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV44InOutProdutoId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44InOutProdutoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV44InOutProdutoId), 4, 0)));
                  AV45InOutPedidoItemQtd = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45InOutPedidoItemQtd", StringUtil.LTrim( StringUtil.Str( (decimal)(AV45InOutPedidoItemQtd), 4, 0)));
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
         PA152( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START152( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2019712180586", false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal FormNoBackgroundColor\" data-gx-class=\"form-horizontal FormNoBackgroundColor\" novalidate action=\""+formatLink("pedidoitemprompt.aspx") + "?" + UrlEncode("" +AV43InPedidoId) + "," + UrlEncode("" +AV44InOutProdutoId) + "," + UrlEncode("" +AV45InOutPedidoItemQtd)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vPEDIDOITEMQTD1", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15PedidoItemQtd1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vPRODUTONOME1", AV16ProdutoNome1);
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSSELECTOR2", AV18DynamicFiltersSelector2);
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSOPERATOR2", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV19DynamicFiltersOperator2), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vPEDIDOITEMQTD2", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV20PedidoItemQtd2), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vPRODUTONOME2", AV21ProdutoNome2);
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSSELECTOR3", AV23DynamicFiltersSelector3);
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSOPERATOR3", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV24DynamicFiltersOperator3), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vPEDIDOITEMQTD3", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV25PedidoItemQtd3), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vPRODUTONOME3", AV26ProdutoNome3);
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSENABLED2", StringUtil.BoolToStr( AV17DynamicFiltersEnabled2));
         GxWebStd.gx_hidden_field( context, "GXH_vDYNAMICFILTERSENABLED3", StringUtil.BoolToStr( AV22DynamicFiltersEnabled3));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11OrderedBy), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV12OrderedDsc));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_104", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_104), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV40GridCurrentPage), 10, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGECOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV41GridPageCount), 10, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV38DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV38DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPRODUTOIDTITLEFILTERDATA", AV30ProdutoIdTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPRODUTOIDTITLEFILTERDATA", AV30ProdutoIdTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPRODUTONOMETITLEFILTERDATA", AV32ProdutoNomeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPRODUTONOMETITLEFILTERDATA", AV32ProdutoNomeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPRODUTOVALORTITLEFILTERDATA", AV34ProdutoValorTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPRODUTOVALORTITLEFILTERDATA", AV34ProdutoValorTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vPEDIDOITEMQTDTITLEFILTERDATA", AV36PedidoItemQtdTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vPEDIDOITEMQTDTITLEFILTERDATA", AV36PedidoItemQtdTitleFilterData);
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
         GxWebStd.gx_hidden_field( context, "vINPEDIDOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV43InPedidoId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vINOUTPRODUTOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV44InOutProdutoId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vINOUTPEDIDOITEMQTD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV45InOutPedidoItemQtd), 4, 0, ",", "")));
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
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOITEMQTD_Caption", StringUtil.RTrim( Ddo_pedidoitemqtd_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOITEMQTD_Tooltip", StringUtil.RTrim( Ddo_pedidoitemqtd_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOITEMQTD_Cls", StringUtil.RTrim( Ddo_pedidoitemqtd_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOITEMQTD_Dropdownoptionstype", StringUtil.RTrim( Ddo_pedidoitemqtd_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOITEMQTD_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_pedidoitemqtd_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOITEMQTD_Includesortasc", StringUtil.BoolToStr( Ddo_pedidoitemqtd_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOITEMQTD_Includesortdsc", StringUtil.BoolToStr( Ddo_pedidoitemqtd_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOITEMQTD_Sortedstatus", StringUtil.RTrim( Ddo_pedidoitemqtd_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOITEMQTD_Includefilter", StringUtil.BoolToStr( Ddo_pedidoitemqtd_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOITEMQTD_Includedatalist", StringUtil.BoolToStr( Ddo_pedidoitemqtd_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOITEMQTD_Sortasc", StringUtil.RTrim( Ddo_pedidoitemqtd_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOITEMQTD_Sortdsc", StringUtil.RTrim( Ddo_pedidoitemqtd_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOITEMQTD_Cleanfilter", StringUtil.RTrim( Ddo_pedidoitemqtd_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOITEMQTD_Searchbuttontext", StringUtil.RTrim( Ddo_pedidoitemqtd_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Activeeventkey", StringUtil.RTrim( Ddo_produtoid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Activeeventkey", StringUtil.RTrim( Ddo_produtonome_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Activeeventkey", StringUtil.RTrim( Ddo_produtovalor_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOITEMQTD_Activeeventkey", StringUtil.RTrim( Ddo_pedidoitemqtd_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOID_Activeeventkey", StringUtil.RTrim( Ddo_produtoid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTONOME_Activeeventkey", StringUtil.RTrim( Ddo_produtonome_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PRODUTOVALOR_Activeeventkey", StringUtil.RTrim( Ddo_produtovalor_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_PEDIDOITEMQTD_Activeeventkey", StringUtil.RTrim( Ddo_pedidoitemqtd_Activeeventkey));
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
            WE152( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT152( ) ;
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
         return formatLink("pedidoitemprompt.aspx") + "?" + UrlEncode("" +AV43InPedidoId) + "," + UrlEncode("" +AV44InOutProdutoId) + "," + UrlEncode("" +AV45InOutPedidoItemQtd) ;
      }

      public override String GetPgmname( )
      {
         return "PedidoItemPrompt" ;
      }

      public override String GetPgmdesc( )
      {
         return "Consulta de Item" ;
      }

      protected void WB150( )
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
            wb_table1_14_152( true) ;
         }
         else
         {
            wb_table1_14_152( false) ;
         }
         return  ;
      }

      protected void wb_table1_14_152e( bool wbgen )
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
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"104\">") ;
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
               GridContainer.AddObjectProperty("CmpContext", "");
               GridContainer.AddObjectProperty("InMasterPage", "false");
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV42Select));
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
         if ( wbEnd == 104 )
         {
            wbEnd = 0;
            nRC_GXsfl_104 = (short)(nGXsfl_104_idx-1);
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV40GridCurrentPage);
            ucGridpaginationbar.SetProperty("PageCount", AV41GridPageCount);
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
            GxWebStd.gx_label_ctrl( context, lblJsdynamicfilters_Internalname, lblJsdynamicfilters_Caption, "", "", lblJsdynamicfilters_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "", 0, "", 1, 1, 1, "HLP_PedidoItemPrompt.htm");
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
            ucDdo_produtoid.SetProperty("DropDownOptionsTitleSettingsIcons", AV38DDO_TitleSettingsIcons);
            ucDdo_produtoid.SetProperty("DropDownOptionsData", AV30ProdutoIdTitleFilterData);
            ucDdo_produtoid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_produtoid_Internalname, "DDO_PRODUTOIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 118,'',false,'" + sGXsfl_104_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_produtoidtitlecontrolidtoreplace_Internalname, AV31ddo_ProdutoIdTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,118);\"", 0, edtavDdo_produtoidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_PedidoItemPrompt.htm");
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
            ucDdo_produtonome.SetProperty("DropDownOptionsTitleSettingsIcons", AV38DDO_TitleSettingsIcons);
            ucDdo_produtonome.SetProperty("DropDownOptionsData", AV32ProdutoNomeTitleFilterData);
            ucDdo_produtonome.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_produtonome_Internalname, "DDO_PRODUTONOMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 120,'',false,'" + sGXsfl_104_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_produtonometitlecontrolidtoreplace_Internalname, AV33ddo_ProdutoNomeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,120);\"", 0, edtavDdo_produtonometitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_PedidoItemPrompt.htm");
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
            ucDdo_produtovalor.SetProperty("DropDownOptionsTitleSettingsIcons", AV38DDO_TitleSettingsIcons);
            ucDdo_produtovalor.SetProperty("DropDownOptionsData", AV34ProdutoValorTitleFilterData);
            ucDdo_produtovalor.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_produtovalor_Internalname, "DDO_PRODUTOVALORContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 122,'',false,'" + sGXsfl_104_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_produtovalortitlecontrolidtoreplace_Internalname, AV35ddo_ProdutoValorTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,122);\"", 0, edtavDdo_produtovalortitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_PedidoItemPrompt.htm");
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
            ucDdo_pedidoitemqtd.SetProperty("DropDownOptionsTitleSettingsIcons", AV38DDO_TitleSettingsIcons);
            ucDdo_pedidoitemqtd.SetProperty("DropDownOptionsData", AV36PedidoItemQtdTitleFilterData);
            ucDdo_pedidoitemqtd.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_pedidoitemqtd_Internalname, "DDO_PEDIDOITEMQTDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 124,'',false,'" + sGXsfl_104_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_pedidoitemqtdtitlecontrolidtoreplace_Internalname, AV37ddo_PedidoItemQtdTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,124);\"", 0, edtavDdo_pedidoitemqtdtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_PedidoItemPrompt.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities_f5", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 126,'',false,'" + sGXsfl_104_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavDynamicfiltersenabled2_Internalname, StringUtil.BoolToStr( AV17DynamicFiltersEnabled2), "", "", chkavDynamicfiltersenabled2.Visible, 1, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(126, this, 'true', 'false');gx.evt.onchange(this, event);\" ");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 127,'',false,'" + sGXsfl_104_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavDynamicfiltersenabled3_Internalname, StringUtil.BoolToStr( AV22DynamicFiltersEnabled3), "", "", chkavDynamicfiltersenabled3.Visible, 1, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(127, this, 'true', 'false');gx.evt.onchange(this, event);\" ");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 128,'',false,'" + sGXsfl_104_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11OrderedBy), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,128);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PedidoItemPrompt.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 129,'',false,'" + sGXsfl_104_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV12OrderedDsc), StringUtil.BoolToStr( AV12OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,129);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_PedidoItemPrompt.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 104 )
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

      protected void START152( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_2-131213", 0) ;
            Form.Meta.addItem("description", "Consulta de Item", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP150( ) ;
      }

      protected void WS152( )
      {
         START152( ) ;
         EVT152( ) ;
      }

      protected void EVT152( )
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
                              E11152 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E12152 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PRODUTOID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E13152 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PRODUTONOME.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E14152 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PRODUTOVALOR.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E15152 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_PEDIDOITEMQTD.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E16152 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'REMOVEDYNAMICFILTERS1'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'RemoveDynamicFilters1' */
                              E17152 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'REMOVEDYNAMICFILTERS2'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'RemoveDynamicFilters2' */
                              E18152 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'REMOVEDYNAMICFILTERS3'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'RemoveDynamicFilters3' */
                              E19152 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOCLEANFILTERS'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoCleanFilters' */
                              E20152 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'ADDDYNAMICFILTERS1'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'AddDynamicFilters1' */
                              E21152 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VDYNAMICFILTERSSELECTOR1.CLICK") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E22152 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'ADDDYNAMICFILTERS2'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'AddDynamicFilters2' */
                              E23152 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VDYNAMICFILTERSSELECTOR2.CLICK") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E24152 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VDYNAMICFILTERSSELECTOR3.CLICK") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E25152 ();
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
                              nGXsfl_104_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_104_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_104_idx), 4, 0)), 4, "0");
                              SubsflControlProps_1042( ) ;
                              AV42Select = cgiGet( edtavSelect_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV42Select)) ? AV48Select_GXI : context.convertURL( context.PathToRelativeUrl( AV42Select))), !bGXsfl_104_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "SrcSet", context.GetImageSrcSet( AV42Select), true);
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
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E26152 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E27152 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E28152 ();
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
                                       /* Set Refresh If Pedidoitemqtd1 Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vPEDIDOITEMQTD1"), ",", ".") != Convert.ToDecimal( AV15PedidoItemQtd1 )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Produtonome1 Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vPRODUTONOME1"), AV16ProdutoNome1) != 0 )
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
                                       /* Set Refresh If Pedidoitemqtd2 Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vPEDIDOITEMQTD2"), ",", ".") != Convert.ToDecimal( AV20PedidoItemQtd2 )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Produtonome2 Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vPRODUTONOME2"), AV21ProdutoNome2) != 0 )
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
                                       /* Set Refresh If Pedidoitemqtd3 Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vPEDIDOITEMQTD3"), ",", ".") != Convert.ToDecimal( AV25PedidoItemQtd3 )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Produtonome3 Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vPRODUTONOME3"), AV26ProdutoNome3) != 0 )
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
                                          E29152 ();
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

      protected void WE152( )
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

      protected void PA152( )
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
         SubsflControlProps_1042( ) ;
         while ( nGXsfl_104_idx <= nRC_GXsfl_104 )
         {
            sendrow_1042( ) ;
            nGXsfl_104_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_104_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_104_idx+1));
            sGXsfl_104_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_104_idx), 4, 0)), 4, "0");
            SubsflControlProps_1042( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       String AV13DynamicFiltersSelector1 ,
                                       short AV14DynamicFiltersOperator1 ,
                                       short AV15PedidoItemQtd1 ,
                                       String AV16ProdutoNome1 ,
                                       String AV18DynamicFiltersSelector2 ,
                                       short AV19DynamicFiltersOperator2 ,
                                       short AV20PedidoItemQtd2 ,
                                       String AV21ProdutoNome2 ,
                                       String AV23DynamicFiltersSelector3 ,
                                       short AV24DynamicFiltersOperator3 ,
                                       short AV25PedidoItemQtd3 ,
                                       String AV26ProdutoNome3 ,
                                       bool AV17DynamicFiltersEnabled2 ,
                                       bool AV22DynamicFiltersEnabled3 ,
                                       short AV11OrderedBy ,
                                       bool AV12OrderedDsc ,
                                       short AV43InPedidoId ,
                                       String AV31ddo_ProdutoIdTitleControlIdToReplace ,
                                       String AV33ddo_ProdutoNomeTitleControlIdToReplace ,
                                       String AV35ddo_ProdutoValorTitleControlIdToReplace ,
                                       String AV37ddo_PedidoItemQtdTitleControlIdToReplace )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF152( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_PRODUTOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A8ProdutoId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "PRODUTOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A8ProdutoId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_PEDIDOITEMQTD", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A38PedidoItemQtd), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "PEDIDOITEMQTD", StringUtil.LTrim( StringUtil.NToC( (decimal)(A38PedidoItemQtd), 4, 0, ".", "")));
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
         RF152( ) ;
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

      protected void RF152( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 104;
         /* Execute user event: Refresh */
         E27152 ();
         nGXsfl_104_idx = 1;
         sGXsfl_104_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_104_idx), 4, 0)), 4, "0");
         SubsflControlProps_1042( ) ;
         bGXsfl_104_Refreshing = true;
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
            SubsflControlProps_1042( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV13DynamicFiltersSelector1 ,
                                                 AV14DynamicFiltersOperator1 ,
                                                 AV15PedidoItemQtd1 ,
                                                 AV16ProdutoNome1 ,
                                                 AV17DynamicFiltersEnabled2 ,
                                                 AV18DynamicFiltersSelector2 ,
                                                 AV19DynamicFiltersOperator2 ,
                                                 AV20PedidoItemQtd2 ,
                                                 AV21ProdutoNome2 ,
                                                 AV22DynamicFiltersEnabled3 ,
                                                 AV23DynamicFiltersSelector3 ,
                                                 AV24DynamicFiltersOperator3 ,
                                                 AV25PedidoItemQtd3 ,
                                                 AV26ProdutoNome3 ,
                                                 A38PedidoItemQtd ,
                                                 A9ProdutoNome ,
                                                 AV11OrderedBy ,
                                                 AV12OrderedDsc ,
                                                 A32PedidoId ,
                                                 AV43InPedidoId } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                                 TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.SHORT
                                                 }
            } ) ;
            lV16ProdutoNome1 = StringUtil.Concat( StringUtil.RTrim( AV16ProdutoNome1), "%", "");
            lV16ProdutoNome1 = StringUtil.Concat( StringUtil.RTrim( AV16ProdutoNome1), "%", "");
            lV21ProdutoNome2 = StringUtil.Concat( StringUtil.RTrim( AV21ProdutoNome2), "%", "");
            lV21ProdutoNome2 = StringUtil.Concat( StringUtil.RTrim( AV21ProdutoNome2), "%", "");
            lV26ProdutoNome3 = StringUtil.Concat( StringUtil.RTrim( AV26ProdutoNome3), "%", "");
            lV26ProdutoNome3 = StringUtil.Concat( StringUtil.RTrim( AV26ProdutoNome3), "%", "");
            /* Using cursor H00152 */
            pr_default.execute(0, new Object[] {AV43InPedidoId, AV15PedidoItemQtd1, AV15PedidoItemQtd1, AV15PedidoItemQtd1, lV16ProdutoNome1, lV16ProdutoNome1, AV20PedidoItemQtd2, AV20PedidoItemQtd2, AV20PedidoItemQtd2, lV21ProdutoNome2, lV21ProdutoNome2, AV25PedidoItemQtd3, AV25PedidoItemQtd3, AV25PedidoItemQtd3, lV26ProdutoNome3, lV26ProdutoNome3, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_104_idx = 1;
            sGXsfl_104_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_104_idx), 4, 0)), 4, "0");
            SubsflControlProps_1042( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A32PedidoId = H00152_A32PedidoId[0];
               A33PedidoDt = H00152_A33PedidoDt[0];
               A38PedidoItemQtd = H00152_A38PedidoItemQtd[0];
               A11ProdutoValor = H00152_A11ProdutoValor[0];
               A9ProdutoNome = H00152_A9ProdutoNome[0];
               A8ProdutoId = H00152_A8ProdutoId[0];
               A33PedidoDt = H00152_A33PedidoDt[0];
               A11ProdutoValor = H00152_A11ProdutoValor[0];
               A9ProdutoNome = H00152_A9ProdutoNome[0];
               E28152 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 104;
            WB150( ) ;
         }
         bGXsfl_104_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes152( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_PRODUTOID"+"_"+sGXsfl_104_idx, GetSecureSignedToken( sGXsfl_104_idx, context.localUtil.Format( (decimal)(A8ProdutoId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_PEDIDOITEMQTD"+"_"+sGXsfl_104_idx, GetSecureSignedToken( sGXsfl_104_idx, context.localUtil.Format( (decimal)(A38PedidoItemQtd), "ZZZ9"), context));
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
                                              AV15PedidoItemQtd1 ,
                                              AV16ProdutoNome1 ,
                                              AV17DynamicFiltersEnabled2 ,
                                              AV18DynamicFiltersSelector2 ,
                                              AV19DynamicFiltersOperator2 ,
                                              AV20PedidoItemQtd2 ,
                                              AV21ProdutoNome2 ,
                                              AV22DynamicFiltersEnabled3 ,
                                              AV23DynamicFiltersSelector3 ,
                                              AV24DynamicFiltersOperator3 ,
                                              AV25PedidoItemQtd3 ,
                                              AV26ProdutoNome3 ,
                                              A38PedidoItemQtd ,
                                              A9ProdutoNome ,
                                              AV11OrderedBy ,
                                              AV12OrderedDsc ,
                                              A32PedidoId ,
                                              AV43InPedidoId } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.SHORT
                                              }
         } ) ;
         lV16ProdutoNome1 = StringUtil.Concat( StringUtil.RTrim( AV16ProdutoNome1), "%", "");
         lV16ProdutoNome1 = StringUtil.Concat( StringUtil.RTrim( AV16ProdutoNome1), "%", "");
         lV21ProdutoNome2 = StringUtil.Concat( StringUtil.RTrim( AV21ProdutoNome2), "%", "");
         lV21ProdutoNome2 = StringUtil.Concat( StringUtil.RTrim( AV21ProdutoNome2), "%", "");
         lV26ProdutoNome3 = StringUtil.Concat( StringUtil.RTrim( AV26ProdutoNome3), "%", "");
         lV26ProdutoNome3 = StringUtil.Concat( StringUtil.RTrim( AV26ProdutoNome3), "%", "");
         /* Using cursor H00153 */
         pr_default.execute(1, new Object[] {AV43InPedidoId, AV15PedidoItemQtd1, AV15PedidoItemQtd1, AV15PedidoItemQtd1, lV16ProdutoNome1, lV16ProdutoNome1, AV20PedidoItemQtd2, AV20PedidoItemQtd2, AV20PedidoItemQtd2, lV21ProdutoNome2, lV21ProdutoNome2, AV25PedidoItemQtd3, AV25PedidoItemQtd3, AV25PedidoItemQtd3, lV26ProdutoNome3, lV26ProdutoNome3});
         GRID_nRecordCount = H00153_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15PedidoItemQtd1, AV16ProdutoNome1, AV18DynamicFiltersSelector2, AV19DynamicFiltersOperator2, AV20PedidoItemQtd2, AV21ProdutoNome2, AV23DynamicFiltersSelector3, AV24DynamicFiltersOperator3, AV25PedidoItemQtd3, AV26ProdutoNome3, AV17DynamicFiltersEnabled2, AV22DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV43InPedidoId, AV31ddo_ProdutoIdTitleControlIdToReplace, AV33ddo_ProdutoNomeTitleControlIdToReplace, AV35ddo_ProdutoValorTitleControlIdToReplace, AV37ddo_PedidoItemQtdTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15PedidoItemQtd1, AV16ProdutoNome1, AV18DynamicFiltersSelector2, AV19DynamicFiltersOperator2, AV20PedidoItemQtd2, AV21ProdutoNome2, AV23DynamicFiltersSelector3, AV24DynamicFiltersOperator3, AV25PedidoItemQtd3, AV26ProdutoNome3, AV17DynamicFiltersEnabled2, AV22DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV43InPedidoId, AV31ddo_ProdutoIdTitleControlIdToReplace, AV33ddo_ProdutoNomeTitleControlIdToReplace, AV35ddo_ProdutoValorTitleControlIdToReplace, AV37ddo_PedidoItemQtdTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15PedidoItemQtd1, AV16ProdutoNome1, AV18DynamicFiltersSelector2, AV19DynamicFiltersOperator2, AV20PedidoItemQtd2, AV21ProdutoNome2, AV23DynamicFiltersSelector3, AV24DynamicFiltersOperator3, AV25PedidoItemQtd3, AV26ProdutoNome3, AV17DynamicFiltersEnabled2, AV22DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV43InPedidoId, AV31ddo_ProdutoIdTitleControlIdToReplace, AV33ddo_ProdutoNomeTitleControlIdToReplace, AV35ddo_ProdutoValorTitleControlIdToReplace, AV37ddo_PedidoItemQtdTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15PedidoItemQtd1, AV16ProdutoNome1, AV18DynamicFiltersSelector2, AV19DynamicFiltersOperator2, AV20PedidoItemQtd2, AV21ProdutoNome2, AV23DynamicFiltersSelector3, AV24DynamicFiltersOperator3, AV25PedidoItemQtd3, AV26ProdutoNome3, AV17DynamicFiltersEnabled2, AV22DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV43InPedidoId, AV31ddo_ProdutoIdTitleControlIdToReplace, AV33ddo_ProdutoNomeTitleControlIdToReplace, AV35ddo_ProdutoValorTitleControlIdToReplace, AV37ddo_PedidoItemQtdTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15PedidoItemQtd1, AV16ProdutoNome1, AV18DynamicFiltersSelector2, AV19DynamicFiltersOperator2, AV20PedidoItemQtd2, AV21ProdutoNome2, AV23DynamicFiltersSelector3, AV24DynamicFiltersOperator3, AV25PedidoItemQtd3, AV26ProdutoNome3, AV17DynamicFiltersEnabled2, AV22DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV43InPedidoId, AV31ddo_ProdutoIdTitleControlIdToReplace, AV33ddo_ProdutoNomeTitleControlIdToReplace, AV35ddo_ProdutoValorTitleControlIdToReplace, AV37ddo_PedidoItemQtdTitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP150( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E26152 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV38DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vPRODUTOIDTITLEFILTERDATA"), AV30ProdutoIdTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPRODUTONOMETITLEFILTERDATA"), AV32ProdutoNomeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPRODUTOVALORTITLEFILTERDATA"), AV34ProdutoValorTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vPEDIDOITEMQTDTITLEFILTERDATA"), AV36PedidoItemQtdTitleFilterData);
            /* Read variables values. */
            cmbavDynamicfiltersselector1.Name = cmbavDynamicfiltersselector1_Internalname;
            cmbavDynamicfiltersselector1.CurrentValue = cgiGet( cmbavDynamicfiltersselector1_Internalname);
            AV13DynamicFiltersSelector1 = cgiGet( cmbavDynamicfiltersselector1_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13DynamicFiltersSelector1", AV13DynamicFiltersSelector1);
            cmbavDynamicfiltersoperator1.Name = cmbavDynamicfiltersoperator1_Internalname;
            cmbavDynamicfiltersoperator1.CurrentValue = cgiGet( cmbavDynamicfiltersoperator1_Internalname);
            AV14DynamicFiltersOperator1 = (short)(NumberUtil.Val( cgiGet( cmbavDynamicfiltersoperator1_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14DynamicFiltersOperator1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0)));
            if ( ( ( context.localUtil.CToN( cgiGet( edtavPedidoitemqtd1_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavPedidoitemqtd1_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vPEDIDOITEMQTD1");
               GX_FocusControl = edtavPedidoitemqtd1_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV15PedidoItemQtd1 = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15PedidoItemQtd1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15PedidoItemQtd1), 4, 0)));
            }
            else
            {
               AV15PedidoItemQtd1 = (short)(context.localUtil.CToN( cgiGet( edtavPedidoitemqtd1_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15PedidoItemQtd1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15PedidoItemQtd1), 4, 0)));
            }
            AV16ProdutoNome1 = cgiGet( edtavProdutonome1_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ProdutoNome1", AV16ProdutoNome1);
            cmbavDynamicfiltersselector2.Name = cmbavDynamicfiltersselector2_Internalname;
            cmbavDynamicfiltersselector2.CurrentValue = cgiGet( cmbavDynamicfiltersselector2_Internalname);
            AV18DynamicFiltersSelector2 = cgiGet( cmbavDynamicfiltersselector2_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18DynamicFiltersSelector2", AV18DynamicFiltersSelector2);
            cmbavDynamicfiltersoperator2.Name = cmbavDynamicfiltersoperator2_Internalname;
            cmbavDynamicfiltersoperator2.CurrentValue = cgiGet( cmbavDynamicfiltersoperator2_Internalname);
            AV19DynamicFiltersOperator2 = (short)(NumberUtil.Val( cgiGet( cmbavDynamicfiltersoperator2_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19DynamicFiltersOperator2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0)));
            if ( ( ( context.localUtil.CToN( cgiGet( edtavPedidoitemqtd2_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavPedidoitemqtd2_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vPEDIDOITEMQTD2");
               GX_FocusControl = edtavPedidoitemqtd2_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV20PedidoItemQtd2 = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20PedidoItemQtd2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20PedidoItemQtd2), 4, 0)));
            }
            else
            {
               AV20PedidoItemQtd2 = (short)(context.localUtil.CToN( cgiGet( edtavPedidoitemqtd2_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20PedidoItemQtd2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20PedidoItemQtd2), 4, 0)));
            }
            AV21ProdutoNome2 = cgiGet( edtavProdutonome2_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21ProdutoNome2", AV21ProdutoNome2);
            cmbavDynamicfiltersselector3.Name = cmbavDynamicfiltersselector3_Internalname;
            cmbavDynamicfiltersselector3.CurrentValue = cgiGet( cmbavDynamicfiltersselector3_Internalname);
            AV23DynamicFiltersSelector3 = cgiGet( cmbavDynamicfiltersselector3_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23DynamicFiltersSelector3", AV23DynamicFiltersSelector3);
            cmbavDynamicfiltersoperator3.Name = cmbavDynamicfiltersoperator3_Internalname;
            cmbavDynamicfiltersoperator3.CurrentValue = cgiGet( cmbavDynamicfiltersoperator3_Internalname);
            AV24DynamicFiltersOperator3 = (short)(NumberUtil.Val( cgiGet( cmbavDynamicfiltersoperator3_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24DynamicFiltersOperator3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0)));
            if ( ( ( context.localUtil.CToN( cgiGet( edtavPedidoitemqtd3_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavPedidoitemqtd3_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vPEDIDOITEMQTD3");
               GX_FocusControl = edtavPedidoitemqtd3_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV25PedidoItemQtd3 = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25PedidoItemQtd3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25PedidoItemQtd3), 4, 0)));
            }
            else
            {
               AV25PedidoItemQtd3 = (short)(context.localUtil.CToN( cgiGet( edtavPedidoitemqtd3_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25PedidoItemQtd3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25PedidoItemQtd3), 4, 0)));
            }
            AV26ProdutoNome3 = cgiGet( edtavProdutonome3_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26ProdutoNome3", AV26ProdutoNome3);
            AV31ddo_ProdutoIdTitleControlIdToReplace = cgiGet( edtavDdo_produtoidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_ProdutoIdTitleControlIdToReplace", AV31ddo_ProdutoIdTitleControlIdToReplace);
            AV33ddo_ProdutoNomeTitleControlIdToReplace = cgiGet( edtavDdo_produtonometitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33ddo_ProdutoNomeTitleControlIdToReplace", AV33ddo_ProdutoNomeTitleControlIdToReplace);
            AV35ddo_ProdutoValorTitleControlIdToReplace = cgiGet( edtavDdo_produtovalortitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ddo_ProdutoValorTitleControlIdToReplace", AV35ddo_ProdutoValorTitleControlIdToReplace);
            AV37ddo_PedidoItemQtdTitleControlIdToReplace = cgiGet( edtavDdo_pedidoitemqtdtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37ddo_PedidoItemQtdTitleControlIdToReplace", AV37ddo_PedidoItemQtdTitleControlIdToReplace);
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
            nRC_GXsfl_104 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_104"), ",", "."));
            AV40GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ",", "."));
            AV41GridPageCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGECOUNT"), ",", "."));
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
            Ddo_pedidoitemqtd_Caption = cgiGet( "DDO_PEDIDOITEMQTD_Caption");
            Ddo_pedidoitemqtd_Tooltip = cgiGet( "DDO_PEDIDOITEMQTD_Tooltip");
            Ddo_pedidoitemqtd_Cls = cgiGet( "DDO_PEDIDOITEMQTD_Cls");
            Ddo_pedidoitemqtd_Dropdownoptionstype = cgiGet( "DDO_PEDIDOITEMQTD_Dropdownoptionstype");
            Ddo_pedidoitemqtd_Titlecontrolidtoreplace = cgiGet( "DDO_PEDIDOITEMQTD_Titlecontrolidtoreplace");
            Ddo_pedidoitemqtd_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_PEDIDOITEMQTD_Includesortasc"));
            Ddo_pedidoitemqtd_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_PEDIDOITEMQTD_Includesortdsc"));
            Ddo_pedidoitemqtd_Sortedstatus = cgiGet( "DDO_PEDIDOITEMQTD_Sortedstatus");
            Ddo_pedidoitemqtd_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_PEDIDOITEMQTD_Includefilter"));
            Ddo_pedidoitemqtd_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_PEDIDOITEMQTD_Includedatalist"));
            Ddo_pedidoitemqtd_Sortasc = cgiGet( "DDO_PEDIDOITEMQTD_Sortasc");
            Ddo_pedidoitemqtd_Sortdsc = cgiGet( "DDO_PEDIDOITEMQTD_Sortdsc");
            Ddo_pedidoitemqtd_Cleanfilter = cgiGet( "DDO_PEDIDOITEMQTD_Cleanfilter");
            Ddo_pedidoitemqtd_Searchbuttontext = cgiGet( "DDO_PEDIDOITEMQTD_Searchbuttontext");
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ",", "."));
            Ddo_produtoid_Activeeventkey = cgiGet( "DDO_PRODUTOID_Activeeventkey");
            Ddo_produtonome_Activeeventkey = cgiGet( "DDO_PRODUTONOME_Activeeventkey");
            Ddo_produtovalor_Activeeventkey = cgiGet( "DDO_PRODUTOVALOR_Activeeventkey");
            Ddo_pedidoitemqtd_Activeeventkey = cgiGet( "DDO_PEDIDOITEMQTD_Activeeventkey");
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
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vPEDIDOITEMQTD1"), ",", ".") != Convert.ToDecimal( AV15PedidoItemQtd1 )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vPRODUTONOME1"), AV16ProdutoNome1) != 0 )
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
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vPEDIDOITEMQTD2"), ",", ".") != Convert.ToDecimal( AV20PedidoItemQtd2 )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vPRODUTONOME2"), AV21ProdutoNome2) != 0 )
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
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vPEDIDOITEMQTD3"), ",", ".") != Convert.ToDecimal( AV25PedidoItemQtd3 )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vPRODUTONOME3"), AV26ProdutoNome3) != 0 )
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
         E26152 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E26152( )
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
         AV13DynamicFiltersSelector1 = "PEDIDOITEMQTD";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13DynamicFiltersSelector1", AV13DynamicFiltersSelector1);
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS1' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV18DynamicFiltersSelector2 = "PEDIDOITEMQTD";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18DynamicFiltersSelector2", AV18DynamicFiltersSelector2);
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS2' */
         S122 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV23DynamicFiltersSelector3 = "PEDIDOITEMQTD";
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
         Ddo_produtoid_Titlecontrolidtoreplace = subGrid_Internalname+"_ProdutoId";
         ucDdo_produtoid.SendProperty(context, "", false, Ddo_produtoid_Internalname, "TitleControlIdToReplace", Ddo_produtoid_Titlecontrolidtoreplace);
         AV31ddo_ProdutoIdTitleControlIdToReplace = Ddo_produtoid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_ProdutoIdTitleControlIdToReplace", AV31ddo_ProdutoIdTitleControlIdToReplace);
         edtavDdo_produtoidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_produtoidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_produtoidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_produtonome_Titlecontrolidtoreplace = subGrid_Internalname+"_ProdutoNome";
         ucDdo_produtonome.SendProperty(context, "", false, Ddo_produtonome_Internalname, "TitleControlIdToReplace", Ddo_produtonome_Titlecontrolidtoreplace);
         AV33ddo_ProdutoNomeTitleControlIdToReplace = Ddo_produtonome_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33ddo_ProdutoNomeTitleControlIdToReplace", AV33ddo_ProdutoNomeTitleControlIdToReplace);
         edtavDdo_produtonometitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_produtonometitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_produtonometitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_produtovalor_Titlecontrolidtoreplace = subGrid_Internalname+"_ProdutoValor";
         ucDdo_produtovalor.SendProperty(context, "", false, Ddo_produtovalor_Internalname, "TitleControlIdToReplace", Ddo_produtovalor_Titlecontrolidtoreplace);
         AV35ddo_ProdutoValorTitleControlIdToReplace = Ddo_produtovalor_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ddo_ProdutoValorTitleControlIdToReplace", AV35ddo_ProdutoValorTitleControlIdToReplace);
         edtavDdo_produtovalortitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_produtovalortitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_produtovalortitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_pedidoitemqtd_Titlecontrolidtoreplace = subGrid_Internalname+"_PedidoItemQtd";
         ucDdo_pedidoitemqtd.SendProperty(context, "", false, Ddo_pedidoitemqtd_Internalname, "TitleControlIdToReplace", Ddo_pedidoitemqtd_Titlecontrolidtoreplace);
         AV37ddo_PedidoItemQtdTitleControlIdToReplace = Ddo_pedidoitemqtd_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37ddo_PedidoItemQtdTitleControlIdToReplace", AV37ddo_PedidoItemQtdTitleControlIdToReplace);
         edtavDdo_pedidoitemqtdtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_pedidoitemqtdtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_pedidoitemqtdtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = "Consulta de Item";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV38DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV38DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E27152( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV30ProdutoIdTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV32ProdutoNomeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV34ProdutoValorTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV36PedidoItemQtdTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         cmbavDynamicfiltersoperator1.removeAllItems();
         if ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PEDIDOITEMQTD") == 0 )
         {
            cmbavDynamicfiltersoperator1.addItem("0", "<", 0);
            cmbavDynamicfiltersoperator1.addItem("1", "=", 0);
            cmbavDynamicfiltersoperator1.addItem("2", ">", 0);
         }
         else if ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PRODUTONOME") == 0 )
         {
            cmbavDynamicfiltersoperator1.addItem("0", "Começa com", 0);
            cmbavDynamicfiltersoperator1.addItem("1", "Contém", 0);
         }
         if ( AV17DynamicFiltersEnabled2 )
         {
            cmbavDynamicfiltersoperator2.removeAllItems();
            if ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PEDIDOITEMQTD") == 0 )
            {
               cmbavDynamicfiltersoperator2.addItem("0", "<", 0);
               cmbavDynamicfiltersoperator2.addItem("1", "=", 0);
               cmbavDynamicfiltersoperator2.addItem("2", ">", 0);
            }
            else if ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PRODUTONOME") == 0 )
            {
               cmbavDynamicfiltersoperator2.addItem("0", "Começa com", 0);
               cmbavDynamicfiltersoperator2.addItem("1", "Contém", 0);
            }
            if ( AV22DynamicFiltersEnabled3 )
            {
               cmbavDynamicfiltersoperator3.removeAllItems();
               if ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PEDIDOITEMQTD") == 0 )
               {
                  cmbavDynamicfiltersoperator3.addItem("0", "<", 0);
                  cmbavDynamicfiltersoperator3.addItem("1", "=", 0);
                  cmbavDynamicfiltersoperator3.addItem("2", ">", 0);
               }
               else if ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PRODUTONOME") == 0 )
               {
                  cmbavDynamicfiltersoperator3.addItem("0", "Começa com", 0);
                  cmbavDynamicfiltersoperator3.addItem("1", "Contém", 0);
               }
            }
         }
         edtProdutoId_Titleformat = 2;
         edtProdutoId_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Id", AV31ddo_ProdutoIdTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProdutoId_Internalname, "Title", edtProdutoId_Title, !bGXsfl_104_Refreshing);
         edtProdutoNome_Titleformat = 2;
         edtProdutoNome_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Nome do Produto", AV33ddo_ProdutoNomeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProdutoNome_Internalname, "Title", edtProdutoNome_Title, !bGXsfl_104_Refreshing);
         edtProdutoValor_Titleformat = 2;
         edtProdutoValor_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Valor do Produto", AV35ddo_ProdutoValorTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProdutoValor_Internalname, "Title", edtProdutoValor_Title, !bGXsfl_104_Refreshing);
         edtPedidoItemQtd_Titleformat = 2;
         edtPedidoItemQtd_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Quantidade", AV37ddo_PedidoItemQtdTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPedidoItemQtd_Internalname, "Title", edtPedidoItemQtd_Title, !bGXsfl_104_Refreshing);
         AV40GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV40GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV40GridCurrentPage), 10, 0)));
         AV41GridPageCount = subGrid_Pagecount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41GridPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV41GridPageCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30ProdutoIdTitleFilterData", AV30ProdutoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32ProdutoNomeTitleFilterData", AV32ProdutoNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34ProdutoValorTitleFilterData", AV34ProdutoValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36PedidoItemQtdTitleFilterData", AV36PedidoItemQtdTitleFilterData);
         cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", cmbavDynamicfiltersoperator1.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", cmbavDynamicfiltersoperator2.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", cmbavDynamicfiltersoperator3.ToJavascriptSource(), true);
      }

      protected void E11152( )
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
            AV39PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV39PageToGo) ;
         }
      }

      protected void E12152( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E13152( )
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
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30ProdutoIdTitleFilterData", AV30ProdutoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32ProdutoNomeTitleFilterData", AV32ProdutoNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34ProdutoValorTitleFilterData", AV34ProdutoValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36PedidoItemQtdTitleFilterData", AV36PedidoItemQtdTitleFilterData);
         cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", cmbavDynamicfiltersoperator1.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", cmbavDynamicfiltersoperator2.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", cmbavDynamicfiltersoperator3.ToJavascriptSource(), true);
      }

      protected void E14152( )
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
            AV11OrderedBy = 3;
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
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_produtonome_Sortedstatus = "DSC";
            ucDdo_produtonome.SendProperty(context, "", false, Ddo_produtonome_Internalname, "SortedStatus", Ddo_produtonome_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30ProdutoIdTitleFilterData", AV30ProdutoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32ProdutoNomeTitleFilterData", AV32ProdutoNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34ProdutoValorTitleFilterData", AV34ProdutoValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36PedidoItemQtdTitleFilterData", AV36PedidoItemQtdTitleFilterData);
         cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", cmbavDynamicfiltersoperator1.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", cmbavDynamicfiltersoperator2.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", cmbavDynamicfiltersoperator3.ToJavascriptSource(), true);
      }

      protected void E15152( )
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
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30ProdutoIdTitleFilterData", AV30ProdutoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32ProdutoNomeTitleFilterData", AV32ProdutoNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34ProdutoValorTitleFilterData", AV34ProdutoValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36PedidoItemQtdTitleFilterData", AV36PedidoItemQtdTitleFilterData);
         cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", cmbavDynamicfiltersoperator1.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", cmbavDynamicfiltersoperator2.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", cmbavDynamicfiltersoperator3.ToJavascriptSource(), true);
      }

      protected void E16152( )
      {
         /* Ddo_pedidoitemqtd_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_pedidoitemqtd_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_pedidoitemqtd_Sortedstatus = "ASC";
            ucDdo_pedidoitemqtd.SendProperty(context, "", false, Ddo_pedidoitemqtd_Internalname, "SortedStatus", Ddo_pedidoitemqtd_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_pedidoitemqtd_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_pedidoitemqtd_Sortedstatus = "DSC";
            ucDdo_pedidoitemqtd.SendProperty(context, "", false, Ddo_pedidoitemqtd_Internalname, "SortedStatus", Ddo_pedidoitemqtd_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30ProdutoIdTitleFilterData", AV30ProdutoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32ProdutoNomeTitleFilterData", AV32ProdutoNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34ProdutoValorTitleFilterData", AV34ProdutoValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36PedidoItemQtdTitleFilterData", AV36PedidoItemQtdTitleFilterData);
         cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", cmbavDynamicfiltersoperator1.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", cmbavDynamicfiltersoperator2.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", cmbavDynamicfiltersoperator3.ToJavascriptSource(), true);
      }

      private void E28152( )
      {
         /* Grid_Load Routine */
         AV42Select = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavSelect_Internalname, AV42Select);
         AV48Select_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         edtavSelect_Tooltiptext = "Selecionar";
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 104;
         }
         sendrow_1042( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_104_Refreshing )
         {
            context.DoAjaxLoad(104, GridRow);
         }
         /*  Sending Event outputs  */
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E29152 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E29152( )
      {
         /* Enter Routine */
         AV44InOutProdutoId = A8ProdutoId;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44InOutProdutoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV44InOutProdutoId), 4, 0)));
         AV45InOutPedidoItemQtd = A38PedidoItemQtd;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45InOutPedidoItemQtd", StringUtil.LTrim( StringUtil.Str( (decimal)(AV45InOutPedidoItemQtd), 4, 0)));
         context.setWebReturnParms(new Object[] {(short)AV44InOutProdutoId,(short)AV45InOutPedidoItemQtd});
         context.setWebReturnParmsMetadata(new Object[] {"AV44InOutProdutoId","AV45InOutPedidoItemQtd"});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
         /*  Sending Event outputs  */
      }

      protected void E21152( )
      {
         /* 'AddDynamicFilters1' Routine */
         AV17DynamicFiltersEnabled2 = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17DynamicFiltersEnabled2", AV17DynamicFiltersEnabled2);
         imgAdddynamicfilters1_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgAdddynamicfilters1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgAdddynamicfilters1_Visible), 5, 0)), true);
         imgRemovedynamicfilters1_Visible = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgRemovedynamicfilters1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgRemovedynamicfilters1_Visible), 5, 0)), true);
         gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15PedidoItemQtd1, AV16ProdutoNome1, AV18DynamicFiltersSelector2, AV19DynamicFiltersOperator2, AV20PedidoItemQtd2, AV21ProdutoNome2, AV23DynamicFiltersSelector3, AV24DynamicFiltersOperator3, AV25PedidoItemQtd3, AV26ProdutoNome3, AV17DynamicFiltersEnabled2, AV22DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV43InPedidoId, AV31ddo_ProdutoIdTitleControlIdToReplace, AV33ddo_ProdutoNomeTitleControlIdToReplace, AV35ddo_ProdutoValorTitleControlIdToReplace, AV37ddo_PedidoItemQtdTitleControlIdToReplace) ;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30ProdutoIdTitleFilterData", AV30ProdutoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32ProdutoNomeTitleFilterData", AV32ProdutoNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34ProdutoValorTitleFilterData", AV34ProdutoValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36PedidoItemQtdTitleFilterData", AV36PedidoItemQtdTitleFilterData);
         cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", cmbavDynamicfiltersoperator1.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", cmbavDynamicfiltersoperator2.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", cmbavDynamicfiltersoperator3.ToJavascriptSource(), true);
      }

      protected void E17152( )
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
         gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15PedidoItemQtd1, AV16ProdutoNome1, AV18DynamicFiltersSelector2, AV19DynamicFiltersOperator2, AV20PedidoItemQtd2, AV21ProdutoNome2, AV23DynamicFiltersSelector3, AV24DynamicFiltersOperator3, AV25PedidoItemQtd3, AV26ProdutoNome3, AV17DynamicFiltersEnabled2, AV22DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV43InPedidoId, AV31ddo_ProdutoIdTitleControlIdToReplace, AV33ddo_ProdutoNomeTitleControlIdToReplace, AV35ddo_ProdutoValorTitleControlIdToReplace, AV37ddo_PedidoItemQtdTitleControlIdToReplace) ;
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
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30ProdutoIdTitleFilterData", AV30ProdutoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32ProdutoNomeTitleFilterData", AV32ProdutoNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34ProdutoValorTitleFilterData", AV34ProdutoValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36PedidoItemQtdTitleFilterData", AV36PedidoItemQtdTitleFilterData);
      }

      protected void E22152( )
      {
         /* Dynamicfiltersselector1_Click Routine */
         AV14DynamicFiltersOperator1 = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14DynamicFiltersOperator1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0)));
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS1' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /*  Sending Event outputs  */
         cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", cmbavDynamicfiltersoperator1.ToJavascriptSource(), true);
      }

      protected void E23152( )
      {
         /* 'AddDynamicFilters2' Routine */
         AV22DynamicFiltersEnabled3 = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22DynamicFiltersEnabled3", AV22DynamicFiltersEnabled3);
         imgAdddynamicfilters2_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgAdddynamicfilters2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgAdddynamicfilters2_Visible), 5, 0)), true);
         imgRemovedynamicfilters2_Visible = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgRemovedynamicfilters2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgRemovedynamicfilters2_Visible), 5, 0)), true);
         gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15PedidoItemQtd1, AV16ProdutoNome1, AV18DynamicFiltersSelector2, AV19DynamicFiltersOperator2, AV20PedidoItemQtd2, AV21ProdutoNome2, AV23DynamicFiltersSelector3, AV24DynamicFiltersOperator3, AV25PedidoItemQtd3, AV26ProdutoNome3, AV17DynamicFiltersEnabled2, AV22DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV43InPedidoId, AV31ddo_ProdutoIdTitleControlIdToReplace, AV33ddo_ProdutoNomeTitleControlIdToReplace, AV35ddo_ProdutoValorTitleControlIdToReplace, AV37ddo_PedidoItemQtdTitleControlIdToReplace) ;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30ProdutoIdTitleFilterData", AV30ProdutoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32ProdutoNomeTitleFilterData", AV32ProdutoNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34ProdutoValorTitleFilterData", AV34ProdutoValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36PedidoItemQtdTitleFilterData", AV36PedidoItemQtdTitleFilterData);
         cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", cmbavDynamicfiltersoperator1.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", cmbavDynamicfiltersoperator2.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", cmbavDynamicfiltersoperator3.ToJavascriptSource(), true);
      }

      protected void E18152( )
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
         gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15PedidoItemQtd1, AV16ProdutoNome1, AV18DynamicFiltersSelector2, AV19DynamicFiltersOperator2, AV20PedidoItemQtd2, AV21ProdutoNome2, AV23DynamicFiltersSelector3, AV24DynamicFiltersOperator3, AV25PedidoItemQtd3, AV26ProdutoNome3, AV17DynamicFiltersEnabled2, AV22DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV43InPedidoId, AV31ddo_ProdutoIdTitleControlIdToReplace, AV33ddo_ProdutoNomeTitleControlIdToReplace, AV35ddo_ProdutoValorTitleControlIdToReplace, AV37ddo_PedidoItemQtdTitleControlIdToReplace) ;
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
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30ProdutoIdTitleFilterData", AV30ProdutoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32ProdutoNomeTitleFilterData", AV32ProdutoNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34ProdutoValorTitleFilterData", AV34ProdutoValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36PedidoItemQtdTitleFilterData", AV36PedidoItemQtdTitleFilterData);
      }

      protected void E24152( )
      {
         /* Dynamicfiltersselector2_Click Routine */
         AV19DynamicFiltersOperator2 = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19DynamicFiltersOperator2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0)));
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS2' */
         S122 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /*  Sending Event outputs  */
         cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", cmbavDynamicfiltersoperator2.ToJavascriptSource(), true);
      }

      protected void E19152( )
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
         gxgrGrid_refresh( subGrid_Rows, AV13DynamicFiltersSelector1, AV14DynamicFiltersOperator1, AV15PedidoItemQtd1, AV16ProdutoNome1, AV18DynamicFiltersSelector2, AV19DynamicFiltersOperator2, AV20PedidoItemQtd2, AV21ProdutoNome2, AV23DynamicFiltersSelector3, AV24DynamicFiltersOperator3, AV25PedidoItemQtd3, AV26ProdutoNome3, AV17DynamicFiltersEnabled2, AV22DynamicFiltersEnabled3, AV11OrderedBy, AV12OrderedDsc, AV43InPedidoId, AV31ddo_ProdutoIdTitleControlIdToReplace, AV33ddo_ProdutoNomeTitleControlIdToReplace, AV35ddo_ProdutoValorTitleControlIdToReplace, AV37ddo_PedidoItemQtdTitleControlIdToReplace) ;
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
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30ProdutoIdTitleFilterData", AV30ProdutoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32ProdutoNomeTitleFilterData", AV32ProdutoNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34ProdutoValorTitleFilterData", AV34ProdutoValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36PedidoItemQtdTitleFilterData", AV36PedidoItemQtdTitleFilterData);
      }

      protected void E25152( )
      {
         /* Dynamicfiltersselector3_Click Routine */
         AV24DynamicFiltersOperator3 = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24DynamicFiltersOperator3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0)));
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS3' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /*  Sending Event outputs  */
         cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", cmbavDynamicfiltersoperator3.ToJavascriptSource(), true);
      }

      protected void E20152( )
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
         cmbavDynamicfiltersselector2.CurrentValue = StringUtil.RTrim( AV18DynamicFiltersSelector2);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector2_Internalname, "Values", cmbavDynamicfiltersselector2.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", cmbavDynamicfiltersoperator2.ToJavascriptSource(), true);
         cmbavDynamicfiltersselector3.CurrentValue = StringUtil.RTrim( AV23DynamicFiltersSelector3);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector3_Internalname, "Values", cmbavDynamicfiltersselector3.ToJavascriptSource(), true);
         cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", cmbavDynamicfiltersoperator3.ToJavascriptSource(), true);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30ProdutoIdTitleFilterData", AV30ProdutoIdTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32ProdutoNomeTitleFilterData", AV32ProdutoNomeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34ProdutoValorTitleFilterData", AV34ProdutoValorTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36PedidoItemQtdTitleFilterData", AV36PedidoItemQtdTitleFilterData);
      }

      protected void S162( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_produtoid_Sortedstatus = "";
         ucDdo_produtoid.SendProperty(context, "", false, Ddo_produtoid_Internalname, "SortedStatus", Ddo_produtoid_Sortedstatus);
         Ddo_produtonome_Sortedstatus = "";
         ucDdo_produtonome.SendProperty(context, "", false, Ddo_produtonome_Internalname, "SortedStatus", Ddo_produtonome_Sortedstatus);
         Ddo_produtovalor_Sortedstatus = "";
         ucDdo_produtovalor.SendProperty(context, "", false, Ddo_produtovalor_Internalname, "SortedStatus", Ddo_produtovalor_Sortedstatus);
         Ddo_pedidoitemqtd_Sortedstatus = "";
         ucDdo_pedidoitemqtd.SendProperty(context, "", false, Ddo_pedidoitemqtd_Internalname, "SortedStatus", Ddo_pedidoitemqtd_Sortedstatus);
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
         else if ( AV11OrderedBy == 3 )
         {
            Ddo_produtonome_Sortedstatus = (AV12OrderedDsc ? "DSC" : "ASC");
            ucDdo_produtonome.SendProperty(context, "", false, Ddo_produtonome_Internalname, "SortedStatus", Ddo_produtonome_Sortedstatus);
         }
         else if ( AV11OrderedBy == 4 )
         {
            Ddo_produtovalor_Sortedstatus = (AV12OrderedDsc ? "DSC" : "ASC");
            ucDdo_produtovalor.SendProperty(context, "", false, Ddo_produtovalor_Internalname, "SortedStatus", Ddo_produtovalor_Sortedstatus);
         }
         else if ( AV11OrderedBy == 5 )
         {
            Ddo_pedidoitemqtd_Sortedstatus = (AV12OrderedDsc ? "DSC" : "ASC");
            ucDdo_pedidoitemqtd.SendProperty(context, "", false, Ddo_pedidoitemqtd_Internalname, "SortedStatus", Ddo_pedidoitemqtd_Sortedstatus);
         }
      }

      protected void S112( )
      {
         /* 'ENABLEDYNAMICFILTERS1' Routine */
         edtavPedidoitemqtd1_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPedidoitemqtd1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPedidoitemqtd1_Visible), 5, 0)), true);
         edtavProdutonome1_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavProdutonome1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavProdutonome1_Visible), 5, 0)), true);
         cmbavDynamicfiltersoperator1.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavDynamicfiltersoperator1.Visible), 5, 0)), true);
         if ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PEDIDOITEMQTD") == 0 )
         {
            edtavPedidoitemqtd1_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPedidoitemqtd1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPedidoitemqtd1_Visible), 5, 0)), true);
            cmbavDynamicfiltersoperator1.Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavDynamicfiltersoperator1.Visible), 5, 0)), true);
         }
         else if ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PRODUTONOME") == 0 )
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
         edtavPedidoitemqtd2_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPedidoitemqtd2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPedidoitemqtd2_Visible), 5, 0)), true);
         edtavProdutonome2_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavProdutonome2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavProdutonome2_Visible), 5, 0)), true);
         cmbavDynamicfiltersoperator2.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavDynamicfiltersoperator2.Visible), 5, 0)), true);
         if ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PEDIDOITEMQTD") == 0 )
         {
            edtavPedidoitemqtd2_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPedidoitemqtd2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPedidoitemqtd2_Visible), 5, 0)), true);
            cmbavDynamicfiltersoperator2.Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavDynamicfiltersoperator2.Visible), 5, 0)), true);
         }
         else if ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PRODUTONOME") == 0 )
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
         edtavPedidoitemqtd3_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPedidoitemqtd3_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPedidoitemqtd3_Visible), 5, 0)), true);
         edtavProdutonome3_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavProdutonome3_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavProdutonome3_Visible), 5, 0)), true);
         cmbavDynamicfiltersoperator3.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavDynamicfiltersoperator3.Visible), 5, 0)), true);
         if ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PEDIDOITEMQTD") == 0 )
         {
            edtavPedidoitemqtd3_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPedidoitemqtd3_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPedidoitemqtd3_Visible), 5, 0)), true);
            cmbavDynamicfiltersoperator3.Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavDynamicfiltersoperator3.Visible), 5, 0)), true);
         }
         else if ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PRODUTONOME") == 0 )
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
         AV17DynamicFiltersEnabled2 = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17DynamicFiltersEnabled2", AV17DynamicFiltersEnabled2);
         AV18DynamicFiltersSelector2 = "PEDIDOITEMQTD";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18DynamicFiltersSelector2", AV18DynamicFiltersSelector2);
         AV19DynamicFiltersOperator2 = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19DynamicFiltersOperator2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0)));
         AV20PedidoItemQtd2 = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20PedidoItemQtd2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20PedidoItemQtd2), 4, 0)));
         /* Execute user subroutine: 'ENABLEDYNAMICFILTERS2' */
         S122 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV22DynamicFiltersEnabled3 = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22DynamicFiltersEnabled3", AV22DynamicFiltersEnabled3);
         AV23DynamicFiltersSelector3 = "PEDIDOITEMQTD";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23DynamicFiltersSelector3", AV23DynamicFiltersSelector3);
         AV24DynamicFiltersOperator3 = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24DynamicFiltersOperator3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0)));
         AV25PedidoItemQtd3 = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25PedidoItemQtd3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25PedidoItemQtd3), 4, 0)));
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
         AV13DynamicFiltersSelector1 = "PEDIDOITEMQTD";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13DynamicFiltersSelector1", AV13DynamicFiltersSelector1);
         AV14DynamicFiltersOperator1 = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14DynamicFiltersOperator1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0)));
         AV15PedidoItemQtd1 = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15PedidoItemQtd1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15PedidoItemQtd1), 4, 0)));
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
            if ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PEDIDOITEMQTD") == 0 )
            {
               AV14DynamicFiltersOperator1 = AV10GridStateDynamicFilter.gxTpr_Operator;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14DynamicFiltersOperator1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0)));
               AV15PedidoItemQtd1 = (short)(NumberUtil.Val( AV10GridStateDynamicFilter.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15PedidoItemQtd1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15PedidoItemQtd1), 4, 0)));
            }
            else if ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PRODUTONOME") == 0 )
            {
               AV14DynamicFiltersOperator1 = AV10GridStateDynamicFilter.gxTpr_Operator;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14DynamicFiltersOperator1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0)));
               AV16ProdutoNome1 = AV10GridStateDynamicFilter.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ProdutoNome1", AV16ProdutoNome1);
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
               if ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PEDIDOITEMQTD") == 0 )
               {
                  AV19DynamicFiltersOperator2 = AV10GridStateDynamicFilter.gxTpr_Operator;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19DynamicFiltersOperator2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0)));
                  AV20PedidoItemQtd2 = (short)(NumberUtil.Val( AV10GridStateDynamicFilter.gxTpr_Value, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20PedidoItemQtd2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20PedidoItemQtd2), 4, 0)));
               }
               else if ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PRODUTONOME") == 0 )
               {
                  AV19DynamicFiltersOperator2 = AV10GridStateDynamicFilter.gxTpr_Operator;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19DynamicFiltersOperator2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0)));
                  AV21ProdutoNome2 = AV10GridStateDynamicFilter.gxTpr_Value;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21ProdutoNome2", AV21ProdutoNome2);
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
                  if ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PEDIDOITEMQTD") == 0 )
                  {
                     AV24DynamicFiltersOperator3 = AV10GridStateDynamicFilter.gxTpr_Operator;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24DynamicFiltersOperator3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0)));
                     AV25PedidoItemQtd3 = (short)(NumberUtil.Val( AV10GridStateDynamicFilter.gxTpr_Value, "."));
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25PedidoItemQtd3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25PedidoItemQtd3), 4, 0)));
                  }
                  else if ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PRODUTONOME") == 0 )
                  {
                     AV24DynamicFiltersOperator3 = AV10GridStateDynamicFilter.gxTpr_Operator;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24DynamicFiltersOperator3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0)));
                     AV26ProdutoNome3 = AV10GridStateDynamicFilter.gxTpr_Value;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26ProdutoNome3", AV26ProdutoNome3);
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
            if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PEDIDOITEMQTD") == 0 ) && ! (0==AV15PedidoItemQtd1) )
            {
               AV10GridStateDynamicFilter.gxTpr_Value = StringUtil.Str( (decimal)(AV15PedidoItemQtd1), 4, 0);
               AV10GridStateDynamicFilter.gxTpr_Operator = AV14DynamicFiltersOperator1;
            }
            else if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PRODUTONOME") == 0 ) && ! String.IsNullOrEmpty(StringUtil.RTrim( AV16ProdutoNome1)) )
            {
               AV10GridStateDynamicFilter.gxTpr_Value = AV16ProdutoNome1;
               AV10GridStateDynamicFilter.gxTpr_Operator = AV14DynamicFiltersOperator1;
            }
            if ( AV27DynamicFiltersRemoving || ! String.IsNullOrEmpty(StringUtil.RTrim( AV10GridStateDynamicFilter.gxTpr_Value)) )
            {
               AV8GridState.gxTpr_Dynamicfilters.Add(AV10GridStateDynamicFilter, 0);
            }
         }
         if ( AV17DynamicFiltersEnabled2 )
         {
            AV10GridStateDynamicFilter = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter(context);
            AV10GridStateDynamicFilter.gxTpr_Selected = AV18DynamicFiltersSelector2;
            if ( ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PEDIDOITEMQTD") == 0 ) && ! (0==AV20PedidoItemQtd2) )
            {
               AV10GridStateDynamicFilter.gxTpr_Value = StringUtil.Str( (decimal)(AV20PedidoItemQtd2), 4, 0);
               AV10GridStateDynamicFilter.gxTpr_Operator = AV19DynamicFiltersOperator2;
            }
            else if ( ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PRODUTONOME") == 0 ) && ! String.IsNullOrEmpty(StringUtil.RTrim( AV21ProdutoNome2)) )
            {
               AV10GridStateDynamicFilter.gxTpr_Value = AV21ProdutoNome2;
               AV10GridStateDynamicFilter.gxTpr_Operator = AV19DynamicFiltersOperator2;
            }
            if ( AV27DynamicFiltersRemoving || ! String.IsNullOrEmpty(StringUtil.RTrim( AV10GridStateDynamicFilter.gxTpr_Value)) )
            {
               AV8GridState.gxTpr_Dynamicfilters.Add(AV10GridStateDynamicFilter, 0);
            }
         }
         if ( AV22DynamicFiltersEnabled3 )
         {
            AV10GridStateDynamicFilter = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter(context);
            AV10GridStateDynamicFilter.gxTpr_Selected = AV23DynamicFiltersSelector3;
            if ( ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PEDIDOITEMQTD") == 0 ) && ! (0==AV25PedidoItemQtd3) )
            {
               AV10GridStateDynamicFilter.gxTpr_Value = StringUtil.Str( (decimal)(AV25PedidoItemQtd3), 4, 0);
               AV10GridStateDynamicFilter.gxTpr_Operator = AV24DynamicFiltersOperator3;
            }
            else if ( ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PRODUTONOME") == 0 ) && ! String.IsNullOrEmpty(StringUtil.RTrim( AV26ProdutoNome3)) )
            {
               AV10GridStateDynamicFilter.gxTpr_Value = AV26ProdutoNome3;
               AV10GridStateDynamicFilter.gxTpr_Operator = AV24DynamicFiltersOperator3;
            }
            if ( AV27DynamicFiltersRemoving || ! String.IsNullOrEmpty(StringUtil.RTrim( AV10GridStateDynamicFilter.gxTpr_Value)) )
            {
               AV8GridState.gxTpr_Dynamicfilters.Add(AV10GridStateDynamicFilter, 0);
            }
         }
      }

      protected void wb_table1_14_152( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgCleanfilters_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "Limpar filtros", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgCleanfilters_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'DOCLEANFILTERS\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_PedidoItemPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_19_152( true) ;
         }
         else
         {
            wb_table2_19_152( false) ;
         }
         return  ;
      }

      protected void wb_table2_19_152e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_14_152e( true) ;
         }
         else
         {
            wb_table1_14_152e( false) ;
         }
      }

      protected void wb_table2_19_152( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTabledynamicfilters_Internalname, tblTabledynamicfilters_Internalname, "", "TableDynamicFilters", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersprefix1_Internalname, "Filtrar por", "", "", lblDynamicfiltersprefix1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescriptionPrefix", 0, "", 1, 1, 0, "HLP_PedidoItemPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavDynamicfiltersselector1_Internalname, "Dynamic Filters Selector1", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'" + sGXsfl_104_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersselector1, cmbavDynamicfiltersselector1_Internalname, StringUtil.RTrim( AV13DynamicFiltersSelector1), 1, cmbavDynamicfiltersselector1_Jsonclick, 5, "'"+""+"'"+",false,"+"'"+"EVDYNAMICFILTERSSELECTOR1.CLICK."+"'", "svchar", "", 1, cmbavDynamicfiltersselector1.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,25);\"", "", true, "HLP_PedidoItemPrompt.htm");
            cmbavDynamicfiltersselector1.CurrentValue = StringUtil.RTrim( AV13DynamicFiltersSelector1);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector1_Internalname, "Values", (String)(cmbavDynamicfiltersselector1.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersmiddle1_Internalname, "valor", "", "", lblDynamicfiltersmiddle1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescription", 0, "", 1, 1, 0, "HLP_PedidoItemPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table3_29_152( true) ;
         }
         else
         {
            wb_table3_29_152( false) ;
         }
         return  ;
      }

      protected void wb_table3_29_152e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table4_41_152( true) ;
         }
         else
         {
            wb_table4_41_152( false) ;
         }
         return  ;
      }

      protected void wb_table4_41_152e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersprefix2_Internalname, "Filtrar por", "", "", lblDynamicfiltersprefix2_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescriptionPrefix", 0, "", 1, 1, 0, "HLP_PedidoItemPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavDynamicfiltersselector2_Internalname, "Dynamic Filters Selector2", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'" + sGXsfl_104_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersselector2, cmbavDynamicfiltersselector2_Internalname, StringUtil.RTrim( AV18DynamicFiltersSelector2), 1, cmbavDynamicfiltersselector2_Jsonclick, 5, "'"+""+"'"+",false,"+"'"+"EVDYNAMICFILTERSSELECTOR2.CLICK."+"'", "svchar", "", 1, cmbavDynamicfiltersselector2.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", "", true, "HLP_PedidoItemPrompt.htm");
            cmbavDynamicfiltersselector2.CurrentValue = StringUtil.RTrim( AV18DynamicFiltersSelector2);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector2_Internalname, "Values", (String)(cmbavDynamicfiltersselector2.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersmiddle2_Internalname, "valor", "", "", lblDynamicfiltersmiddle2_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescription", 0, "", 1, 1, 0, "HLP_PedidoItemPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            wb_table5_56_152( true) ;
         }
         else
         {
            wb_table5_56_152( false) ;
         }
         return  ;
      }

      protected void wb_table5_56_152e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            wb_table6_68_152( true) ;
         }
         else
         {
            wb_table6_68_152( false) ;
         }
         return  ;
      }

      protected void wb_table6_68_152e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersprefix3_Internalname, "Filtrar por", "", "", lblDynamicfiltersprefix3_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescriptionPrefix", 0, "", 1, 1, 0, "HLP_PedidoItemPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavDynamicfiltersselector3_Internalname, "Dynamic Filters Selector3", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 79,'',false,'" + sGXsfl_104_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersselector3, cmbavDynamicfiltersselector3_Internalname, StringUtil.RTrim( AV23DynamicFiltersSelector3), 1, cmbavDynamicfiltersselector3_Jsonclick, 5, "'"+""+"'"+",false,"+"'"+"EVDYNAMICFILTERSSELECTOR3.CLICK."+"'", "svchar", "", 1, cmbavDynamicfiltersselector3.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,79);\"", "", true, "HLP_PedidoItemPrompt.htm");
            cmbavDynamicfiltersselector3.CurrentValue = StringUtil.RTrim( AV23DynamicFiltersSelector3);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersselector3_Internalname, "Values", (String)(cmbavDynamicfiltersselector3.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblDynamicfiltersmiddle3_Internalname, "valor", "", "", lblDynamicfiltersmiddle3_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescription", 0, "", 1, 1, 0, "HLP_PedidoItemPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            wb_table7_83_152( true) ;
         }
         else
         {
            wb_table7_83_152( false) ;
         }
         return  ;
      }

      protected void wb_table7_83_152e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='Invisible'>") ;
            wb_table8_95_152( true) ;
         }
         else
         {
            wb_table8_95_152( false) ;
         }
         return  ;
      }

      protected void wb_table8_95_152e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_19_152e( true) ;
         }
         else
         {
            wb_table2_19_152e( false) ;
         }
      }

      protected void wb_table8_95_152( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblUnnamedtabledynamicfilters_3_Internalname, tblUnnamedtabledynamicfilters_3_Internalname, "", "Table", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\""+cellDynamicfilters_removefilter3_cell_Internalname+"\"  class=''>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 98,'',false,'',0)\"";
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "11a6ef14-1a5a-4077-91a2-f41ed9a3a662", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgRemovedynamicfilters3_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, 1, "", "Remover filtro", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgRemovedynamicfilters3_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'REMOVEDYNAMICFILTERS3\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_PedidoItemPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table8_95_152e( true) ;
         }
         else
         {
            wb_table8_95_152e( false) ;
         }
      }

      protected void wb_table7_83_152( bool wbgen )
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 87,'',false,'" + sGXsfl_104_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersoperator3, cmbavDynamicfiltersoperator3_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0)), 1, cmbavDynamicfiltersoperator3_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", cmbavDynamicfiltersoperator3.Visible, cmbavDynamicfiltersoperator3.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,87);\"", "", true, "HLP_PedidoItemPrompt.htm");
            cmbavDynamicfiltersoperator3.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator3_Internalname, "Values", (String)(cmbavDynamicfiltersoperator3.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellFilter_pedidoitemqtd3_cell_Internalname+"\"  class=''>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavPedidoitemqtd3_Internalname, "Pedido Item Qtd3", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 90,'',false,'" + sGXsfl_104_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavPedidoitemqtd3_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV25PedidoItemQtd3), 4, 0, ",", "")), ((edtavPedidoitemqtd3_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV25PedidoItemQtd3), "ZZZ9")) : context.localUtil.Format( (decimal)(AV25PedidoItemQtd3), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,90);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPedidoitemqtd3_Jsonclick, 0, "Attribute", "", "", "", "", edtavPedidoitemqtd3_Visible, edtavPedidoitemqtd3_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PedidoItemPrompt.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellFilter_produtonome3_cell_Internalname+"\"  class=''>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavProdutonome3_Internalname, "Produto Nome3", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 93,'',false,'" + sGXsfl_104_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavProdutonome3_Internalname, AV26ProdutoNome3, StringUtil.RTrim( context.localUtil.Format( AV26ProdutoNome3, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,93);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavProdutonome3_Jsonclick, 0, "Attribute", "", "", "", "", edtavProdutonome3_Visible, edtavProdutonome3_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_PedidoItemPrompt.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table7_83_152e( true) ;
         }
         else
         {
            wb_table7_83_152e( false) ;
         }
      }

      protected void wb_table6_68_152( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblUnnamedtabledynamicfilters_2_Internalname, tblUnnamedtabledynamicfilters_2_Internalname, "", "Table", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\""+cellDynamicfilters_addfilter2_cell_Internalname+"\"  class=''>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"";
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "27283ea5-332f-423b-b880-64b762622df3", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgAdddynamicfilters2_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgAdddynamicfilters2_Visible, 1, "", "Adicionar filtro", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgAdddynamicfilters2_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'ADDDYNAMICFILTERS2\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_PedidoItemPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellDynamicfilters_removefilter2_cell_Internalname+"\"  class=''>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"";
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "11a6ef14-1a5a-4077-91a2-f41ed9a3a662", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgRemovedynamicfilters2_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgRemovedynamicfilters2_Visible, 1, "", "Remover filtro", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgRemovedynamicfilters2_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'REMOVEDYNAMICFILTERS2\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_PedidoItemPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table6_68_152e( true) ;
         }
         else
         {
            wb_table6_68_152e( false) ;
         }
      }

      protected void wb_table5_56_152( bool wbgen )
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'" + sGXsfl_104_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersoperator2, cmbavDynamicfiltersoperator2_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0)), 1, cmbavDynamicfiltersoperator2_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", cmbavDynamicfiltersoperator2.Visible, cmbavDynamicfiltersoperator2.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,60);\"", "", true, "HLP_PedidoItemPrompt.htm");
            cmbavDynamicfiltersoperator2.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator2_Internalname, "Values", (String)(cmbavDynamicfiltersoperator2.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellFilter_pedidoitemqtd2_cell_Internalname+"\"  class=''>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavPedidoitemqtd2_Internalname, "Pedido Item Qtd2", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'" + sGXsfl_104_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavPedidoitemqtd2_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV20PedidoItemQtd2), 4, 0, ",", "")), ((edtavPedidoitemqtd2_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV20PedidoItemQtd2), "ZZZ9")) : context.localUtil.Format( (decimal)(AV20PedidoItemQtd2), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,63);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPedidoitemqtd2_Jsonclick, 0, "Attribute", "", "", "", "", edtavPedidoitemqtd2_Visible, edtavPedidoitemqtd2_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PedidoItemPrompt.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellFilter_produtonome2_cell_Internalname+"\"  class=''>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavProdutonome2_Internalname, "Produto Nome2", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_104_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavProdutonome2_Internalname, AV21ProdutoNome2, StringUtil.RTrim( context.localUtil.Format( AV21ProdutoNome2, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavProdutonome2_Jsonclick, 0, "Attribute", "", "", "", "", edtavProdutonome2_Visible, edtavProdutonome2_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_PedidoItemPrompt.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_56_152e( true) ;
         }
         else
         {
            wb_table5_56_152e( false) ;
         }
      }

      protected void wb_table4_41_152( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblUnnamedtabledynamicfilters_1_Internalname, tblUnnamedtabledynamicfilters_1_Internalname, "", "Table", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\""+cellDynamicfilters_addfilter1_cell_Internalname+"\"  class=''>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "27283ea5-332f-423b-b880-64b762622df3", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgAdddynamicfilters1_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgAdddynamicfilters1_Visible, 1, "", "Adicionar filtro", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgAdddynamicfilters1_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'ADDDYNAMICFILTERS1\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_PedidoItemPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellDynamicfilters_removefilter1_cell_Internalname+"\"  class=''>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"";
            ClassString = "Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "11a6ef14-1a5a-4077-91a2-f41ed9a3a662", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgRemovedynamicfilters1_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgRemovedynamicfilters1_Visible, 1, "", "Remover filtro", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgRemovedynamicfilters1_Jsonclick, "'"+""+"'"+",false,"+"'"+"E\\'REMOVEDYNAMICFILTERS1\\'."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_PedidoItemPrompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_41_152e( true) ;
         }
         else
         {
            wb_table4_41_152e( false) ;
         }
      }

      protected void wb_table3_29_152( bool wbgen )
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'" + sGXsfl_104_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavDynamicfiltersoperator1, cmbavDynamicfiltersoperator1_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0)), 1, cmbavDynamicfiltersoperator1_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", cmbavDynamicfiltersoperator1.Visible, cmbavDynamicfiltersoperator1.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,33);\"", "", true, "HLP_PedidoItemPrompt.htm");
            cmbavDynamicfiltersoperator1.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavDynamicfiltersoperator1_Internalname, "Values", (String)(cmbavDynamicfiltersoperator1.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellFilter_pedidoitemqtd1_cell_Internalname+"\"  class=''>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavPedidoitemqtd1_Internalname, "Pedido Item Qtd1", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_104_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavPedidoitemqtd1_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15PedidoItemQtd1), 4, 0, ",", "")), ((edtavPedidoitemqtd1_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV15PedidoItemQtd1), "ZZZ9")) : context.localUtil.Format( (decimal)(AV15PedidoItemQtd1), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPedidoitemqtd1_Jsonclick, 0, "Attribute", "", "", "", "", edtavPedidoitemqtd1_Visible, edtavPedidoitemqtd1_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_PedidoItemPrompt.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellFilter_produtonome1_cell_Internalname+"\"  class=''>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavProdutonome1_Internalname, "Produto Nome1", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_104_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavProdutonome1_Internalname, AV16ProdutoNome1, StringUtil.RTrim( context.localUtil.Format( AV16ProdutoNome1, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavProdutonome1_Jsonclick, 0, "Attribute", "", "", "", "", edtavProdutonome1_Visible, edtavProdutonome1_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_PedidoItemPrompt.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_29_152e( true) ;
         }
         else
         {
            wb_table3_29_152e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV43InPedidoId = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43InPedidoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV43InPedidoId), 4, 0)));
         AV44InOutProdutoId = Convert.ToInt16(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44InOutProdutoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV44InOutProdutoId), 4, 0)));
         AV45InOutPedidoItemQtd = Convert.ToInt16(getParm(obj,2));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45InOutPedidoItemQtd", StringUtil.LTrim( StringUtil.Str( (decimal)(AV45InOutPedidoItemQtd), 4, 0)));
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
         PA152( ) ;
         WS152( ) ;
         WE152( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20197121801690", true, true);
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
         context.AddJavascriptSource("pedidoitemprompt.js", "?20197121801690", false, true);
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
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false, true);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_1042( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_104_idx;
         edtProdutoId_Internalname = "PRODUTOID_"+sGXsfl_104_idx;
         edtProdutoNome_Internalname = "PRODUTONOME_"+sGXsfl_104_idx;
         edtProdutoValor_Internalname = "PRODUTOVALOR_"+sGXsfl_104_idx;
         edtPedidoItemQtd_Internalname = "PEDIDOITEMQTD_"+sGXsfl_104_idx;
      }

      protected void SubsflControlProps_fel_1042( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_104_fel_idx;
         edtProdutoId_Internalname = "PRODUTOID_"+sGXsfl_104_fel_idx;
         edtProdutoNome_Internalname = "PRODUTONOME_"+sGXsfl_104_fel_idx;
         edtProdutoValor_Internalname = "PRODUTOVALOR_"+sGXsfl_104_fel_idx;
         edtPedidoItemQtd_Internalname = "PEDIDOITEMQTD_"+sGXsfl_104_fel_idx;
      }

      protected void sendrow_1042( )
      {
         SubsflControlProps_1042( ) ;
         WB150( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_104_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_104_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_104_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavSelect_Enabled!=0)&&(edtavSelect_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 105,'',false,'',104)\"" : " ");
            ClassString = "SelectAttribute ActionBaseColorAttribute";
            StyleString = "";
            AV42Select_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV42Select))&&String.IsNullOrEmpty(StringUtil.RTrim( AV48Select_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV42Select)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV42Select)) ? AV48Select_GXI : context.PathToRelativeUrl( AV42Select));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavSelect_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavSelect_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavSelect_Jsonclick,"'"+""+"'"+",false,"+"'"+"EENTER."+sGXsfl_104_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV42Select_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtProdutoId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A8ProdutoId), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A8ProdutoId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtProdutoId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)104,(short)1,(short)-1,(short)0,(bool)true,(String)"Serial",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtProdutoNome_Internalname,(String)A9ProdutoNome,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtProdutoNome_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)104,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtProdutoValor_Internalname,StringUtil.LTrim( StringUtil.NToC( A11ProdutoValor, 12, 2, ",", "")),context.localUtil.Format( A11ProdutoValor, "R$ ZZ,ZZ9.99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtProdutoValor_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)12,(short)0,(short)0,(short)104,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPedidoItemQtd_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A38PedidoItemQtd), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A38PedidoItemQtd), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPedidoItemQtd_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)104,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            send_integrity_lvl_hashes152( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_104_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_104_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_104_idx+1));
            sGXsfl_104_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_104_idx), 4, 0)), 4, "0");
            SubsflControlProps_1042( ) ;
         }
         /* End function sendrow_1042 */
      }

      protected void init_web_controls( )
      {
         cmbavDynamicfiltersselector1.Name = "vDYNAMICFILTERSSELECTOR1";
         cmbavDynamicfiltersselector1.WebTags = "";
         cmbavDynamicfiltersselector1.addItem("PEDIDOITEMQTD", "Quantidade", 0);
         cmbavDynamicfiltersselector1.addItem("PRODUTONOME", "Nome do Produto", 0);
         if ( cmbavDynamicfiltersselector1.ItemCount > 0 )
         {
            AV13DynamicFiltersSelector1 = cmbavDynamicfiltersselector1.getValidValue(AV13DynamicFiltersSelector1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13DynamicFiltersSelector1", AV13DynamicFiltersSelector1);
         }
         cmbavDynamicfiltersoperator1.Name = "vDYNAMICFILTERSOPERATOR1";
         cmbavDynamicfiltersoperator1.WebTags = "";
         cmbavDynamicfiltersoperator1.addItem("0", "<", 0);
         cmbavDynamicfiltersoperator1.addItem("1", "=", 0);
         cmbavDynamicfiltersoperator1.addItem("2", ">", 0);
         if ( cmbavDynamicfiltersoperator1.ItemCount > 0 )
         {
            AV14DynamicFiltersOperator1 = (short)(NumberUtil.Val( cmbavDynamicfiltersoperator1.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14DynamicFiltersOperator1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14DynamicFiltersOperator1), 4, 0)));
         }
         cmbavDynamicfiltersselector2.Name = "vDYNAMICFILTERSSELECTOR2";
         cmbavDynamicfiltersselector2.WebTags = "";
         cmbavDynamicfiltersselector2.addItem("PEDIDOITEMQTD", "Quantidade", 0);
         cmbavDynamicfiltersselector2.addItem("PRODUTONOME", "Nome do Produto", 0);
         if ( cmbavDynamicfiltersselector2.ItemCount > 0 )
         {
            AV18DynamicFiltersSelector2 = cmbavDynamicfiltersselector2.getValidValue(AV18DynamicFiltersSelector2);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18DynamicFiltersSelector2", AV18DynamicFiltersSelector2);
         }
         cmbavDynamicfiltersoperator2.Name = "vDYNAMICFILTERSOPERATOR2";
         cmbavDynamicfiltersoperator2.WebTags = "";
         cmbavDynamicfiltersoperator2.addItem("0", "<", 0);
         cmbavDynamicfiltersoperator2.addItem("1", "=", 0);
         cmbavDynamicfiltersoperator2.addItem("2", ">", 0);
         if ( cmbavDynamicfiltersoperator2.ItemCount > 0 )
         {
            AV19DynamicFiltersOperator2 = (short)(NumberUtil.Val( cmbavDynamicfiltersoperator2.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19DynamicFiltersOperator2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19DynamicFiltersOperator2), 4, 0)));
         }
         cmbavDynamicfiltersselector3.Name = "vDYNAMICFILTERSSELECTOR3";
         cmbavDynamicfiltersselector3.WebTags = "";
         cmbavDynamicfiltersselector3.addItem("PEDIDOITEMQTD", "Quantidade", 0);
         cmbavDynamicfiltersselector3.addItem("PRODUTONOME", "Nome do Produto", 0);
         if ( cmbavDynamicfiltersselector3.ItemCount > 0 )
         {
            AV23DynamicFiltersSelector3 = cmbavDynamicfiltersselector3.getValidValue(AV23DynamicFiltersSelector3);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23DynamicFiltersSelector3", AV23DynamicFiltersSelector3);
         }
         cmbavDynamicfiltersoperator3.Name = "vDYNAMICFILTERSOPERATOR3";
         cmbavDynamicfiltersoperator3.WebTags = "";
         cmbavDynamicfiltersoperator3.addItem("0", "<", 0);
         cmbavDynamicfiltersoperator3.addItem("1", "=", 0);
         cmbavDynamicfiltersoperator3.addItem("2", ">", 0);
         if ( cmbavDynamicfiltersoperator3.ItemCount > 0 )
         {
            AV24DynamicFiltersOperator3 = (short)(NumberUtil.Val( cmbavDynamicfiltersoperator3.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24DynamicFiltersOperator3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24DynamicFiltersOperator3), 4, 0)));
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
         edtavPedidoitemqtd1_Internalname = "vPEDIDOITEMQTD1";
         cellFilter_pedidoitemqtd1_cell_Internalname = "FILTER_PEDIDOITEMQTD1_CELL";
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
         edtavPedidoitemqtd2_Internalname = "vPEDIDOITEMQTD2";
         cellFilter_pedidoitemqtd2_cell_Internalname = "FILTER_PEDIDOITEMQTD2_CELL";
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
         edtavPedidoitemqtd3_Internalname = "vPEDIDOITEMQTD3";
         cellFilter_pedidoitemqtd3_cell_Internalname = "FILTER_PEDIDOITEMQTD3_CELL";
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
         edtProdutoValor_Internalname = "PRODUTOVALOR";
         edtPedidoItemQtd_Internalname = "PEDIDOITEMQTD";
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
         Ddo_pedidoitemqtd_Internalname = "DDO_PEDIDOITEMQTD";
         edtavDdo_pedidoitemqtdtitlecontrolidtoreplace_Internalname = "vDDO_PEDIDOITEMQTDTITLECONTROLIDTOREPLACE";
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
         edtPedidoItemQtd_Jsonclick = "";
         edtProdutoValor_Jsonclick = "";
         edtProdutoNome_Jsonclick = "";
         edtProdutoId_Jsonclick = "";
         edtavSelect_Jsonclick = "";
         edtavSelect_Visible = -1;
         edtavSelect_Enabled = 1;
         edtavProdutonome1_Jsonclick = "";
         edtavProdutonome1_Enabled = 1;
         edtavPedidoitemqtd1_Jsonclick = "";
         edtavPedidoitemqtd1_Enabled = 1;
         cmbavDynamicfiltersoperator1_Jsonclick = "";
         cmbavDynamicfiltersoperator1.Enabled = 1;
         imgRemovedynamicfilters1_Visible = 1;
         imgAdddynamicfilters1_Visible = 1;
         edtavProdutonome2_Jsonclick = "";
         edtavProdutonome2_Enabled = 1;
         edtavPedidoitemqtd2_Jsonclick = "";
         edtavPedidoitemqtd2_Enabled = 1;
         cmbavDynamicfiltersoperator2_Jsonclick = "";
         cmbavDynamicfiltersoperator2.Enabled = 1;
         imgRemovedynamicfilters2_Visible = 1;
         imgAdddynamicfilters2_Visible = 1;
         edtavProdutonome3_Jsonclick = "";
         edtavProdutonome3_Enabled = 1;
         edtavPedidoitemqtd3_Jsonclick = "";
         edtavPedidoitemqtd3_Enabled = 1;
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
         edtavPedidoitemqtd3_Visible = 1;
         cmbavDynamicfiltersoperator2.Visible = 1;
         edtavProdutonome2_Visible = 1;
         edtavPedidoitemqtd2_Visible = 1;
         cmbavDynamicfiltersoperator1.Visible = 1;
         edtavProdutonome1_Visible = 1;
         edtavPedidoitemqtd1_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         chkavDynamicfiltersenabled3.Visible = 1;
         chkavDynamicfiltersenabled2.Visible = 1;
         edtavDdo_pedidoitemqtdtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_produtovalortitlecontrolidtoreplace_Visible = 1;
         edtavDdo_produtonometitlecontrolidtoreplace_Visible = 1;
         edtavDdo_produtoidtitlecontrolidtoreplace_Visible = 1;
         lblJsdynamicfilters_Caption = "JSDynamicFilters";
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavSelect_Tooltiptext = "Selecionar";
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
         Form.Caption = "Consulta de Item";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoItemQtd1',fld:'vPEDIDOITEMQTD1',pic:'ZZZ9'},{av:'AV16ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoItemQtd2',fld:'vPEDIDOITEMQTD2',pic:'ZZZ9'},{av:'AV21ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoItemQtd3',fld:'vPEDIDOITEMQTD3',pic:'ZZZ9'},{av:'AV26ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV43InPedidoId',fld:'vINPEDIDOID',pic:'ZZZ9'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'AV31ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_PedidoItemQtdTitleControlIdToReplace',fld:'vDDO_PEDIDOITEMQTDTITLECONTROLIDTOREPLACE',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV30ProdutoIdTitleFilterData',fld:'vPRODUTOIDTITLEFILTERDATA',pic:''},{av:'AV32ProdutoNomeTitleFilterData',fld:'vPRODUTONOMETITLEFILTERDATA',pic:''},{av:'AV34ProdutoValorTitleFilterData',fld:'vPRODUTOVALORTITLEFILTERDATA',pic:''},{av:'AV36PedidoItemQtdTitleFilterData',fld:'vPEDIDOITEMQTDTITLEFILTERDATA',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'edtProdutoId_Titleformat',ctrl:'PRODUTOID',prop:'Titleformat'},{av:'edtProdutoId_Title',ctrl:'PRODUTOID',prop:'Title'},{av:'edtProdutoNome_Titleformat',ctrl:'PRODUTONOME',prop:'Titleformat'},{av:'edtProdutoNome_Title',ctrl:'PRODUTONOME',prop:'Title'},{av:'edtProdutoValor_Titleformat',ctrl:'PRODUTOVALOR',prop:'Titleformat'},{av:'edtProdutoValor_Title',ctrl:'PRODUTOVALOR',prop:'Title'},{av:'edtPedidoItemQtd_Titleformat',ctrl:'PEDIDOITEMQTD',prop:'Titleformat'},{av:'edtPedidoItemQtd_Title',ctrl:'PEDIDOITEMQTD',prop:'Title'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV41GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E11152',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoItemQtd1',fld:'vPEDIDOITEMQTD1',pic:'ZZZ9'},{av:'AV16ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoItemQtd2',fld:'vPEDIDOITEMQTD2',pic:'ZZZ9'},{av:'AV21ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoItemQtd3',fld:'vPEDIDOITEMQTD3',pic:'ZZZ9'},{av:'AV26ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV43InPedidoId',fld:'vINPEDIDOID',pic:'ZZZ9'},{av:'AV31ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_PedidoItemQtdTitleControlIdToReplace',fld:'vDDO_PEDIDOITEMQTDTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E12152',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoItemQtd1',fld:'vPEDIDOITEMQTD1',pic:'ZZZ9'},{av:'AV16ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoItemQtd2',fld:'vPEDIDOITEMQTD2',pic:'ZZZ9'},{av:'AV21ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoItemQtd3',fld:'vPEDIDOITEMQTD3',pic:'ZZZ9'},{av:'AV26ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV43InPedidoId',fld:'vINPEDIDOID',pic:'ZZZ9'},{av:'AV31ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_PedidoItemQtdTitleControlIdToReplace',fld:'vDDO_PEDIDOITEMQTDTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_PRODUTOID.ONOPTIONCLICKED","{handler:'E13152',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoItemQtd1',fld:'vPEDIDOITEMQTD1',pic:'ZZZ9'},{av:'AV16ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoItemQtd2',fld:'vPEDIDOITEMQTD2',pic:'ZZZ9'},{av:'AV21ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoItemQtd3',fld:'vPEDIDOITEMQTD3',pic:'ZZZ9'},{av:'AV26ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV43InPedidoId',fld:'vINPEDIDOID',pic:'ZZZ9'},{av:'AV31ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_PedidoItemQtdTitleControlIdToReplace',fld:'vDDO_PEDIDOITEMQTDTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_produtoid_Activeeventkey',ctrl:'DDO_PRODUTOID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_PRODUTOID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_produtoid_Sortedstatus',ctrl:'DDO_PRODUTOID',prop:'SortedStatus'},{av:'Ddo_produtonome_Sortedstatus',ctrl:'DDO_PRODUTONOME',prop:'SortedStatus'},{av:'Ddo_produtovalor_Sortedstatus',ctrl:'DDO_PRODUTOVALOR',prop:'SortedStatus'},{av:'Ddo_pedidoitemqtd_Sortedstatus',ctrl:'DDO_PEDIDOITEMQTD',prop:'SortedStatus'},{av:'AV30ProdutoIdTitleFilterData',fld:'vPRODUTOIDTITLEFILTERDATA',pic:''},{av:'AV32ProdutoNomeTitleFilterData',fld:'vPRODUTONOMETITLEFILTERDATA',pic:''},{av:'AV34ProdutoValorTitleFilterData',fld:'vPRODUTOVALORTITLEFILTERDATA',pic:''},{av:'AV36PedidoItemQtdTitleFilterData',fld:'vPEDIDOITEMQTDTITLEFILTERDATA',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'edtProdutoId_Titleformat',ctrl:'PRODUTOID',prop:'Titleformat'},{av:'edtProdutoId_Title',ctrl:'PRODUTOID',prop:'Title'},{av:'edtProdutoNome_Titleformat',ctrl:'PRODUTONOME',prop:'Titleformat'},{av:'edtProdutoNome_Title',ctrl:'PRODUTONOME',prop:'Title'},{av:'edtProdutoValor_Titleformat',ctrl:'PRODUTOVALOR',prop:'Titleformat'},{av:'edtProdutoValor_Title',ctrl:'PRODUTOVALOR',prop:'Title'},{av:'edtPedidoItemQtd_Titleformat',ctrl:'PEDIDOITEMQTD',prop:'Titleformat'},{av:'edtPedidoItemQtd_Title',ctrl:'PEDIDOITEMQTD',prop:'Title'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV41GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_PRODUTONOME.ONOPTIONCLICKED","{handler:'E14152',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoItemQtd1',fld:'vPEDIDOITEMQTD1',pic:'ZZZ9'},{av:'AV16ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoItemQtd2',fld:'vPEDIDOITEMQTD2',pic:'ZZZ9'},{av:'AV21ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoItemQtd3',fld:'vPEDIDOITEMQTD3',pic:'ZZZ9'},{av:'AV26ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV43InPedidoId',fld:'vINPEDIDOID',pic:'ZZZ9'},{av:'AV31ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_PedidoItemQtdTitleControlIdToReplace',fld:'vDDO_PEDIDOITEMQTDTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_produtonome_Activeeventkey',ctrl:'DDO_PRODUTONOME',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_PRODUTONOME.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_produtonome_Sortedstatus',ctrl:'DDO_PRODUTONOME',prop:'SortedStatus'},{av:'Ddo_produtoid_Sortedstatus',ctrl:'DDO_PRODUTOID',prop:'SortedStatus'},{av:'Ddo_produtovalor_Sortedstatus',ctrl:'DDO_PRODUTOVALOR',prop:'SortedStatus'},{av:'Ddo_pedidoitemqtd_Sortedstatus',ctrl:'DDO_PEDIDOITEMQTD',prop:'SortedStatus'},{av:'AV30ProdutoIdTitleFilterData',fld:'vPRODUTOIDTITLEFILTERDATA',pic:''},{av:'AV32ProdutoNomeTitleFilterData',fld:'vPRODUTONOMETITLEFILTERDATA',pic:''},{av:'AV34ProdutoValorTitleFilterData',fld:'vPRODUTOVALORTITLEFILTERDATA',pic:''},{av:'AV36PedidoItemQtdTitleFilterData',fld:'vPEDIDOITEMQTDTITLEFILTERDATA',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'edtProdutoId_Titleformat',ctrl:'PRODUTOID',prop:'Titleformat'},{av:'edtProdutoId_Title',ctrl:'PRODUTOID',prop:'Title'},{av:'edtProdutoNome_Titleformat',ctrl:'PRODUTONOME',prop:'Titleformat'},{av:'edtProdutoNome_Title',ctrl:'PRODUTONOME',prop:'Title'},{av:'edtProdutoValor_Titleformat',ctrl:'PRODUTOVALOR',prop:'Titleformat'},{av:'edtProdutoValor_Title',ctrl:'PRODUTOVALOR',prop:'Title'},{av:'edtPedidoItemQtd_Titleformat',ctrl:'PEDIDOITEMQTD',prop:'Titleformat'},{av:'edtPedidoItemQtd_Title',ctrl:'PEDIDOITEMQTD',prop:'Title'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV41GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_PRODUTOVALOR.ONOPTIONCLICKED","{handler:'E15152',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoItemQtd1',fld:'vPEDIDOITEMQTD1',pic:'ZZZ9'},{av:'AV16ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoItemQtd2',fld:'vPEDIDOITEMQTD2',pic:'ZZZ9'},{av:'AV21ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoItemQtd3',fld:'vPEDIDOITEMQTD3',pic:'ZZZ9'},{av:'AV26ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV43InPedidoId',fld:'vINPEDIDOID',pic:'ZZZ9'},{av:'AV31ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_PedidoItemQtdTitleControlIdToReplace',fld:'vDDO_PEDIDOITEMQTDTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_produtovalor_Activeeventkey',ctrl:'DDO_PRODUTOVALOR',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_PRODUTOVALOR.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_produtovalor_Sortedstatus',ctrl:'DDO_PRODUTOVALOR',prop:'SortedStatus'},{av:'Ddo_produtoid_Sortedstatus',ctrl:'DDO_PRODUTOID',prop:'SortedStatus'},{av:'Ddo_produtonome_Sortedstatus',ctrl:'DDO_PRODUTONOME',prop:'SortedStatus'},{av:'Ddo_pedidoitemqtd_Sortedstatus',ctrl:'DDO_PEDIDOITEMQTD',prop:'SortedStatus'},{av:'AV30ProdutoIdTitleFilterData',fld:'vPRODUTOIDTITLEFILTERDATA',pic:''},{av:'AV32ProdutoNomeTitleFilterData',fld:'vPRODUTONOMETITLEFILTERDATA',pic:''},{av:'AV34ProdutoValorTitleFilterData',fld:'vPRODUTOVALORTITLEFILTERDATA',pic:''},{av:'AV36PedidoItemQtdTitleFilterData',fld:'vPEDIDOITEMQTDTITLEFILTERDATA',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'edtProdutoId_Titleformat',ctrl:'PRODUTOID',prop:'Titleformat'},{av:'edtProdutoId_Title',ctrl:'PRODUTOID',prop:'Title'},{av:'edtProdutoNome_Titleformat',ctrl:'PRODUTONOME',prop:'Titleformat'},{av:'edtProdutoNome_Title',ctrl:'PRODUTONOME',prop:'Title'},{av:'edtProdutoValor_Titleformat',ctrl:'PRODUTOVALOR',prop:'Titleformat'},{av:'edtProdutoValor_Title',ctrl:'PRODUTOVALOR',prop:'Title'},{av:'edtPedidoItemQtd_Titleformat',ctrl:'PEDIDOITEMQTD',prop:'Titleformat'},{av:'edtPedidoItemQtd_Title',ctrl:'PEDIDOITEMQTD',prop:'Title'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV41GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_PEDIDOITEMQTD.ONOPTIONCLICKED","{handler:'E16152',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoItemQtd1',fld:'vPEDIDOITEMQTD1',pic:'ZZZ9'},{av:'AV16ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoItemQtd2',fld:'vPEDIDOITEMQTD2',pic:'ZZZ9'},{av:'AV21ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoItemQtd3',fld:'vPEDIDOITEMQTD3',pic:'ZZZ9'},{av:'AV26ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV43InPedidoId',fld:'vINPEDIDOID',pic:'ZZZ9'},{av:'AV31ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_PedidoItemQtdTitleControlIdToReplace',fld:'vDDO_PEDIDOITEMQTDTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_pedidoitemqtd_Activeeventkey',ctrl:'DDO_PEDIDOITEMQTD',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_PEDIDOITEMQTD.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_pedidoitemqtd_Sortedstatus',ctrl:'DDO_PEDIDOITEMQTD',prop:'SortedStatus'},{av:'Ddo_produtoid_Sortedstatus',ctrl:'DDO_PRODUTOID',prop:'SortedStatus'},{av:'Ddo_produtonome_Sortedstatus',ctrl:'DDO_PRODUTONOME',prop:'SortedStatus'},{av:'Ddo_produtovalor_Sortedstatus',ctrl:'DDO_PRODUTOVALOR',prop:'SortedStatus'},{av:'AV30ProdutoIdTitleFilterData',fld:'vPRODUTOIDTITLEFILTERDATA',pic:''},{av:'AV32ProdutoNomeTitleFilterData',fld:'vPRODUTONOMETITLEFILTERDATA',pic:''},{av:'AV34ProdutoValorTitleFilterData',fld:'vPRODUTOVALORTITLEFILTERDATA',pic:''},{av:'AV36PedidoItemQtdTitleFilterData',fld:'vPEDIDOITEMQTDTITLEFILTERDATA',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'edtProdutoId_Titleformat',ctrl:'PRODUTOID',prop:'Titleformat'},{av:'edtProdutoId_Title',ctrl:'PRODUTOID',prop:'Title'},{av:'edtProdutoNome_Titleformat',ctrl:'PRODUTONOME',prop:'Titleformat'},{av:'edtProdutoNome_Title',ctrl:'PRODUTONOME',prop:'Title'},{av:'edtProdutoValor_Titleformat',ctrl:'PRODUTOVALOR',prop:'Titleformat'},{av:'edtProdutoValor_Title',ctrl:'PRODUTOVALOR',prop:'Title'},{av:'edtPedidoItemQtd_Titleformat',ctrl:'PEDIDOITEMQTD',prop:'Titleformat'},{av:'edtPedidoItemQtd_Title',ctrl:'PEDIDOITEMQTD',prop:'Title'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV41GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E28152',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV42Select',fld:'vSELECT',pic:''},{av:'edtavSelect_Tooltiptext',ctrl:'vSELECT',prop:'Tooltiptext'}]}");
         setEventMetadata("ENTER","{handler:'E29152',iparms:[{av:'A8ProdutoId',fld:'PRODUTOID',pic:'ZZZ9',hsh:true},{av:'A38PedidoItemQtd',fld:'PEDIDOITEMQTD',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV44InOutProdutoId',fld:'vINOUTPRODUTOID',pic:'ZZZ9'},{av:'AV45InOutPedidoItemQtd',fld:'vINOUTPEDIDOITEMQTD',pic:'ZZZ9'}]}");
         setEventMetadata("'ADDDYNAMICFILTERS1'","{handler:'E21152',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoItemQtd1',fld:'vPEDIDOITEMQTD1',pic:'ZZZ9'},{av:'AV16ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoItemQtd2',fld:'vPEDIDOITEMQTD2',pic:'ZZZ9'},{av:'AV21ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoItemQtd3',fld:'vPEDIDOITEMQTD3',pic:'ZZZ9'},{av:'AV26ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV43InPedidoId',fld:'vINPEDIDOID',pic:'ZZZ9'},{av:'AV31ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_PedidoItemQtdTitleControlIdToReplace',fld:'vDDO_PEDIDOITEMQTDTITLECONTROLIDTOREPLACE',pic:''}]");
         setEventMetadata("'ADDDYNAMICFILTERS1'",",oparms:[{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'AV30ProdutoIdTitleFilterData',fld:'vPRODUTOIDTITLEFILTERDATA',pic:''},{av:'AV32ProdutoNomeTitleFilterData',fld:'vPRODUTONOMETITLEFILTERDATA',pic:''},{av:'AV34ProdutoValorTitleFilterData',fld:'vPRODUTOVALORTITLEFILTERDATA',pic:''},{av:'AV36PedidoItemQtdTitleFilterData',fld:'vPEDIDOITEMQTDTITLEFILTERDATA',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'edtProdutoId_Titleformat',ctrl:'PRODUTOID',prop:'Titleformat'},{av:'edtProdutoId_Title',ctrl:'PRODUTOID',prop:'Title'},{av:'edtProdutoNome_Titleformat',ctrl:'PRODUTONOME',prop:'Titleformat'},{av:'edtProdutoNome_Title',ctrl:'PRODUTONOME',prop:'Title'},{av:'edtProdutoValor_Titleformat',ctrl:'PRODUTOVALOR',prop:'Titleformat'},{av:'edtProdutoValor_Title',ctrl:'PRODUTOVALOR',prop:'Title'},{av:'edtPedidoItemQtd_Titleformat',ctrl:'PEDIDOITEMQTD',prop:'Titleformat'},{av:'edtPedidoItemQtd_Title',ctrl:'PEDIDOITEMQTD',prop:'Title'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV41GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("'REMOVEDYNAMICFILTERS1'","{handler:'E17152',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoItemQtd1',fld:'vPEDIDOITEMQTD1',pic:'ZZZ9'},{av:'AV16ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoItemQtd2',fld:'vPEDIDOITEMQTD2',pic:'ZZZ9'},{av:'AV21ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoItemQtd3',fld:'vPEDIDOITEMQTD3',pic:'ZZZ9'},{av:'AV26ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV43InPedidoId',fld:'vINPEDIDOID',pic:'ZZZ9'},{av:'AV31ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_PedidoItemQtdTitleControlIdToReplace',fld:'vDDO_PEDIDOITEMQTDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV8GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''}]");
         setEventMetadata("'REMOVEDYNAMICFILTERS1'",",oparms:[{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV8GridState',fld:'vGRIDSTATE',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoItemQtd2',fld:'vPEDIDOITEMQTD2',pic:'ZZZ9'},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoItemQtd3',fld:'vPEDIDOITEMQTD3',pic:'ZZZ9'},{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoItemQtd1',fld:'vPEDIDOITEMQTD1',pic:'ZZZ9'},{av:'AV16ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'lblJsdynamicfilters_Caption',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{av:'AV21ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'AV26ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'edtavPedidoitemqtd2_Visible',ctrl:'vPEDIDOITEMQTD2',prop:'Visible'},{av:'edtavProdutonome2_Visible',ctrl:'vPRODUTONOME2',prop:'Visible'},{av:'edtavPedidoitemqtd3_Visible',ctrl:'vPEDIDOITEMQTD3',prop:'Visible'},{av:'edtavProdutonome3_Visible',ctrl:'vPRODUTONOME3',prop:'Visible'},{av:'edtavPedidoitemqtd1_Visible',ctrl:'vPEDIDOITEMQTD1',prop:'Visible'},{av:'edtavProdutonome1_Visible',ctrl:'vPRODUTONOME1',prop:'Visible'},{av:'AV30ProdutoIdTitleFilterData',fld:'vPRODUTOIDTITLEFILTERDATA',pic:''},{av:'AV32ProdutoNomeTitleFilterData',fld:'vPRODUTONOMETITLEFILTERDATA',pic:''},{av:'AV34ProdutoValorTitleFilterData',fld:'vPRODUTOVALORTITLEFILTERDATA',pic:''},{av:'AV36PedidoItemQtdTitleFilterData',fld:'vPEDIDOITEMQTDTITLEFILTERDATA',pic:''},{av:'edtProdutoId_Titleformat',ctrl:'PRODUTOID',prop:'Titleformat'},{av:'edtProdutoId_Title',ctrl:'PRODUTOID',prop:'Title'},{av:'edtProdutoNome_Titleformat',ctrl:'PRODUTONOME',prop:'Titleformat'},{av:'edtProdutoNome_Title',ctrl:'PRODUTONOME',prop:'Title'},{av:'edtProdutoValor_Titleformat',ctrl:'PRODUTOVALOR',prop:'Titleformat'},{av:'edtProdutoValor_Title',ctrl:'PRODUTOVALOR',prop:'Title'},{av:'edtPedidoItemQtd_Titleformat',ctrl:'PEDIDOITEMQTD',prop:'Titleformat'},{av:'edtPedidoItemQtd_Title',ctrl:'PEDIDOITEMQTD',prop:'Title'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV41GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("VDYNAMICFILTERSSELECTOR1.CLICK","{handler:'E22152',iparms:[{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''}]");
         setEventMetadata("VDYNAMICFILTERSSELECTOR1.CLICK",",oparms:[{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'edtavPedidoitemqtd1_Visible',ctrl:'vPEDIDOITEMQTD1',prop:'Visible'},{av:'edtavProdutonome1_Visible',ctrl:'vPRODUTONOME1',prop:'Visible'}]}");
         setEventMetadata("'ADDDYNAMICFILTERS2'","{handler:'E23152',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoItemQtd1',fld:'vPEDIDOITEMQTD1',pic:'ZZZ9'},{av:'AV16ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoItemQtd2',fld:'vPEDIDOITEMQTD2',pic:'ZZZ9'},{av:'AV21ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoItemQtd3',fld:'vPEDIDOITEMQTD3',pic:'ZZZ9'},{av:'AV26ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV43InPedidoId',fld:'vINPEDIDOID',pic:'ZZZ9'},{av:'AV31ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_PedidoItemQtdTitleControlIdToReplace',fld:'vDDO_PEDIDOITEMQTDTITLECONTROLIDTOREPLACE',pic:''}]");
         setEventMetadata("'ADDDYNAMICFILTERS2'",",oparms:[{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'AV30ProdutoIdTitleFilterData',fld:'vPRODUTOIDTITLEFILTERDATA',pic:''},{av:'AV32ProdutoNomeTitleFilterData',fld:'vPRODUTONOMETITLEFILTERDATA',pic:''},{av:'AV34ProdutoValorTitleFilterData',fld:'vPRODUTOVALORTITLEFILTERDATA',pic:''},{av:'AV36PedidoItemQtdTitleFilterData',fld:'vPEDIDOITEMQTDTITLEFILTERDATA',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'edtProdutoId_Titleformat',ctrl:'PRODUTOID',prop:'Titleformat'},{av:'edtProdutoId_Title',ctrl:'PRODUTOID',prop:'Title'},{av:'edtProdutoNome_Titleformat',ctrl:'PRODUTONOME',prop:'Titleformat'},{av:'edtProdutoNome_Title',ctrl:'PRODUTONOME',prop:'Title'},{av:'edtProdutoValor_Titleformat',ctrl:'PRODUTOVALOR',prop:'Titleformat'},{av:'edtProdutoValor_Title',ctrl:'PRODUTOVALOR',prop:'Title'},{av:'edtPedidoItemQtd_Titleformat',ctrl:'PEDIDOITEMQTD',prop:'Titleformat'},{av:'edtPedidoItemQtd_Title',ctrl:'PEDIDOITEMQTD',prop:'Title'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV41GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("'REMOVEDYNAMICFILTERS2'","{handler:'E18152',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoItemQtd1',fld:'vPEDIDOITEMQTD1',pic:'ZZZ9'},{av:'AV16ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoItemQtd2',fld:'vPEDIDOITEMQTD2',pic:'ZZZ9'},{av:'AV21ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoItemQtd3',fld:'vPEDIDOITEMQTD3',pic:'ZZZ9'},{av:'AV26ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV43InPedidoId',fld:'vINPEDIDOID',pic:'ZZZ9'},{av:'AV31ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_PedidoItemQtdTitleControlIdToReplace',fld:'vDDO_PEDIDOITEMQTDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV8GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''}]");
         setEventMetadata("'REMOVEDYNAMICFILTERS2'",",oparms:[{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV8GridState',fld:'vGRIDSTATE',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoItemQtd2',fld:'vPEDIDOITEMQTD2',pic:'ZZZ9'},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoItemQtd3',fld:'vPEDIDOITEMQTD3',pic:'ZZZ9'},{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoItemQtd1',fld:'vPEDIDOITEMQTD1',pic:'ZZZ9'},{av:'AV16ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'lblJsdynamicfilters_Caption',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{av:'AV21ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'AV26ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'edtavPedidoitemqtd2_Visible',ctrl:'vPEDIDOITEMQTD2',prop:'Visible'},{av:'edtavProdutonome2_Visible',ctrl:'vPRODUTONOME2',prop:'Visible'},{av:'edtavPedidoitemqtd3_Visible',ctrl:'vPEDIDOITEMQTD3',prop:'Visible'},{av:'edtavProdutonome3_Visible',ctrl:'vPRODUTONOME3',prop:'Visible'},{av:'edtavPedidoitemqtd1_Visible',ctrl:'vPEDIDOITEMQTD1',prop:'Visible'},{av:'edtavProdutonome1_Visible',ctrl:'vPRODUTONOME1',prop:'Visible'},{av:'AV30ProdutoIdTitleFilterData',fld:'vPRODUTOIDTITLEFILTERDATA',pic:''},{av:'AV32ProdutoNomeTitleFilterData',fld:'vPRODUTONOMETITLEFILTERDATA',pic:''},{av:'AV34ProdutoValorTitleFilterData',fld:'vPRODUTOVALORTITLEFILTERDATA',pic:''},{av:'AV36PedidoItemQtdTitleFilterData',fld:'vPEDIDOITEMQTDTITLEFILTERDATA',pic:''},{av:'edtProdutoId_Titleformat',ctrl:'PRODUTOID',prop:'Titleformat'},{av:'edtProdutoId_Title',ctrl:'PRODUTOID',prop:'Title'},{av:'edtProdutoNome_Titleformat',ctrl:'PRODUTONOME',prop:'Titleformat'},{av:'edtProdutoNome_Title',ctrl:'PRODUTONOME',prop:'Title'},{av:'edtProdutoValor_Titleformat',ctrl:'PRODUTOVALOR',prop:'Titleformat'},{av:'edtProdutoValor_Title',ctrl:'PRODUTOVALOR',prop:'Title'},{av:'edtPedidoItemQtd_Titleformat',ctrl:'PEDIDOITEMQTD',prop:'Titleformat'},{av:'edtPedidoItemQtd_Title',ctrl:'PEDIDOITEMQTD',prop:'Title'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV41GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("VDYNAMICFILTERSSELECTOR2.CLICK","{handler:'E24152',iparms:[{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''}]");
         setEventMetadata("VDYNAMICFILTERSSELECTOR2.CLICK",",oparms:[{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'edtavPedidoitemqtd2_Visible',ctrl:'vPEDIDOITEMQTD2',prop:'Visible'},{av:'edtavProdutonome2_Visible',ctrl:'vPRODUTONOME2',prop:'Visible'}]}");
         setEventMetadata("'REMOVEDYNAMICFILTERS3'","{handler:'E19152',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoItemQtd1',fld:'vPEDIDOITEMQTD1',pic:'ZZZ9'},{av:'AV16ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoItemQtd2',fld:'vPEDIDOITEMQTD2',pic:'ZZZ9'},{av:'AV21ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoItemQtd3',fld:'vPEDIDOITEMQTD3',pic:'ZZZ9'},{av:'AV26ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV43InPedidoId',fld:'vINPEDIDOID',pic:'ZZZ9'},{av:'AV31ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_PedidoItemQtdTitleControlIdToReplace',fld:'vDDO_PEDIDOITEMQTDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV8GridState',fld:'vGRIDSTATE',pic:''},{av:'AV28DynamicFiltersIgnoreFirst',fld:'vDYNAMICFILTERSIGNOREFIRST',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''}]");
         setEventMetadata("'REMOVEDYNAMICFILTERS3'",",oparms:[{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV8GridState',fld:'vGRIDSTATE',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoItemQtd2',fld:'vPEDIDOITEMQTD2',pic:'ZZZ9'},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoItemQtd3',fld:'vPEDIDOITEMQTD3',pic:'ZZZ9'},{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoItemQtd1',fld:'vPEDIDOITEMQTD1',pic:'ZZZ9'},{av:'AV16ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'lblJsdynamicfilters_Caption',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{av:'AV21ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'AV26ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'edtavPedidoitemqtd2_Visible',ctrl:'vPEDIDOITEMQTD2',prop:'Visible'},{av:'edtavProdutonome2_Visible',ctrl:'vPRODUTONOME2',prop:'Visible'},{av:'edtavPedidoitemqtd3_Visible',ctrl:'vPEDIDOITEMQTD3',prop:'Visible'},{av:'edtavProdutonome3_Visible',ctrl:'vPRODUTONOME3',prop:'Visible'},{av:'edtavPedidoitemqtd1_Visible',ctrl:'vPEDIDOITEMQTD1',prop:'Visible'},{av:'edtavProdutonome1_Visible',ctrl:'vPRODUTONOME1',prop:'Visible'},{av:'AV30ProdutoIdTitleFilterData',fld:'vPRODUTOIDTITLEFILTERDATA',pic:''},{av:'AV32ProdutoNomeTitleFilterData',fld:'vPRODUTONOMETITLEFILTERDATA',pic:''},{av:'AV34ProdutoValorTitleFilterData',fld:'vPRODUTOVALORTITLEFILTERDATA',pic:''},{av:'AV36PedidoItemQtdTitleFilterData',fld:'vPEDIDOITEMQTDTITLEFILTERDATA',pic:''},{av:'edtProdutoId_Titleformat',ctrl:'PRODUTOID',prop:'Titleformat'},{av:'edtProdutoId_Title',ctrl:'PRODUTOID',prop:'Title'},{av:'edtProdutoNome_Titleformat',ctrl:'PRODUTONOME',prop:'Titleformat'},{av:'edtProdutoNome_Title',ctrl:'PRODUTONOME',prop:'Title'},{av:'edtProdutoValor_Titleformat',ctrl:'PRODUTOVALOR',prop:'Titleformat'},{av:'edtProdutoValor_Title',ctrl:'PRODUTOVALOR',prop:'Title'},{av:'edtPedidoItemQtd_Titleformat',ctrl:'PEDIDOITEMQTD',prop:'Titleformat'},{av:'edtPedidoItemQtd_Title',ctrl:'PEDIDOITEMQTD',prop:'Title'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV41GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("VDYNAMICFILTERSSELECTOR3.CLICK","{handler:'E25152',iparms:[{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''}]");
         setEventMetadata("VDYNAMICFILTERSSELECTOR3.CLICK",",oparms:[{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'edtavPedidoitemqtd3_Visible',ctrl:'vPEDIDOITEMQTD3',prop:'Visible'},{av:'edtavProdutonome3_Visible',ctrl:'vPRODUTONOME3',prop:'Visible'}]}");
         setEventMetadata("'DOCLEANFILTERS'","{handler:'E20152',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoItemQtd1',fld:'vPEDIDOITEMQTD1',pic:'ZZZ9'},{av:'AV16ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoItemQtd2',fld:'vPEDIDOITEMQTD2',pic:'ZZZ9'},{av:'AV21ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoItemQtd3',fld:'vPEDIDOITEMQTD3',pic:'ZZZ9'},{av:'AV26ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV43InPedidoId',fld:'vINPEDIDOID',pic:'ZZZ9'},{av:'AV31ddo_ProdutoIdTitleControlIdToReplace',fld:'vDDO_PRODUTOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_ProdutoNomeTitleControlIdToReplace',fld:'vDDO_PRODUTONOMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_ProdutoValorTitleControlIdToReplace',fld:'vDDO_PRODUTOVALORTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_PedidoItemQtdTitleControlIdToReplace',fld:'vDDO_PEDIDOITEMQTDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV8GridState',fld:'vGRIDSTATE',pic:''},{av:'AV27DynamicFiltersRemoving',fld:'vDYNAMICFILTERSREMOVING',pic:''}]");
         setEventMetadata("'DOCLEANFILTERS'",",oparms:[{av:'cmbavDynamicfiltersselector1'},{av:'AV13DynamicFiltersSelector1',fld:'vDYNAMICFILTERSSELECTOR1',pic:''},{av:'cmbavDynamicfiltersoperator1'},{av:'AV14DynamicFiltersOperator1',fld:'vDYNAMICFILTERSOPERATOR1',pic:'ZZZ9'},{av:'AV15PedidoItemQtd1',fld:'vPEDIDOITEMQTD1',pic:'ZZZ9'},{av:'AV8GridState',fld:'vGRIDSTATE',pic:''},{av:'edtavPedidoitemqtd1_Visible',ctrl:'vPEDIDOITEMQTD1',prop:'Visible'},{av:'edtavProdutonome1_Visible',ctrl:'vPRODUTONOME1',prop:'Visible'},{av:'AV17DynamicFiltersEnabled2',fld:'vDYNAMICFILTERSENABLED2',pic:''},{av:'cmbavDynamicfiltersselector2'},{av:'AV18DynamicFiltersSelector2',fld:'vDYNAMICFILTERSSELECTOR2',pic:''},{av:'cmbavDynamicfiltersoperator2'},{av:'AV19DynamicFiltersOperator2',fld:'vDYNAMICFILTERSOPERATOR2',pic:'ZZZ9'},{av:'AV20PedidoItemQtd2',fld:'vPEDIDOITEMQTD2',pic:'ZZZ9'},{av:'AV22DynamicFiltersEnabled3',fld:'vDYNAMICFILTERSENABLED3',pic:''},{av:'cmbavDynamicfiltersselector3'},{av:'AV23DynamicFiltersSelector3',fld:'vDYNAMICFILTERSSELECTOR3',pic:''},{av:'cmbavDynamicfiltersoperator3'},{av:'AV24DynamicFiltersOperator3',fld:'vDYNAMICFILTERSOPERATOR3',pic:'ZZZ9'},{av:'AV25PedidoItemQtd3',fld:'vPEDIDOITEMQTD3',pic:'ZZZ9'},{av:'imgAdddynamicfilters1_Visible',ctrl:'ADDDYNAMICFILTERS1',prop:'Visible'},{av:'imgRemovedynamicfilters1_Visible',ctrl:'REMOVEDYNAMICFILTERS1',prop:'Visible'},{av:'imgAdddynamicfilters2_Visible',ctrl:'ADDDYNAMICFILTERS2',prop:'Visible'},{av:'imgRemovedynamicfilters2_Visible',ctrl:'REMOVEDYNAMICFILTERS2',prop:'Visible'},{av:'AV16ProdutoNome1',fld:'vPRODUTONOME1',pic:''},{av:'lblJsdynamicfilters_Caption',ctrl:'JSDYNAMICFILTERS',prop:'Caption'},{av:'AV21ProdutoNome2',fld:'vPRODUTONOME2',pic:''},{av:'AV26ProdutoNome3',fld:'vPRODUTONOME3',pic:''},{av:'edtavPedidoitemqtd2_Visible',ctrl:'vPEDIDOITEMQTD2',prop:'Visible'},{av:'edtavProdutonome2_Visible',ctrl:'vPRODUTONOME2',prop:'Visible'},{av:'edtavPedidoitemqtd3_Visible',ctrl:'vPEDIDOITEMQTD3',prop:'Visible'},{av:'edtavProdutonome3_Visible',ctrl:'vPRODUTONOME3',prop:'Visible'},{av:'AV30ProdutoIdTitleFilterData',fld:'vPRODUTOIDTITLEFILTERDATA',pic:''},{av:'AV32ProdutoNomeTitleFilterData',fld:'vPRODUTONOMETITLEFILTERDATA',pic:''},{av:'AV34ProdutoValorTitleFilterData',fld:'vPRODUTOVALORTITLEFILTERDATA',pic:''},{av:'AV36PedidoItemQtdTitleFilterData',fld:'vPEDIDOITEMQTDTITLEFILTERDATA',pic:''},{av:'edtProdutoId_Titleformat',ctrl:'PRODUTOID',prop:'Titleformat'},{av:'edtProdutoId_Title',ctrl:'PRODUTOID',prop:'Title'},{av:'edtProdutoNome_Titleformat',ctrl:'PRODUTONOME',prop:'Titleformat'},{av:'edtProdutoNome_Title',ctrl:'PRODUTONOME',prop:'Title'},{av:'edtProdutoValor_Titleformat',ctrl:'PRODUTOVALOR',prop:'Titleformat'},{av:'edtProdutoValor_Title',ctrl:'PRODUTOVALOR',prop:'Title'},{av:'edtPedidoItemQtd_Titleformat',ctrl:'PEDIDOITEMQTD',prop:'Titleformat'},{av:'edtPedidoItemQtd_Title',ctrl:'PEDIDOITEMQTD',prop:'Title'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV41GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'}]}");
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
         AV13DynamicFiltersSelector1 = "";
         AV16ProdutoNome1 = "";
         AV18DynamicFiltersSelector2 = "";
         AV21ProdutoNome2 = "";
         AV23DynamicFiltersSelector3 = "";
         AV26ProdutoNome3 = "";
         AV31ddo_ProdutoIdTitleControlIdToReplace = "";
         AV33ddo_ProdutoNomeTitleControlIdToReplace = "";
         AV35ddo_ProdutoValorTitleControlIdToReplace = "";
         AV37ddo_PedidoItemQtdTitleControlIdToReplace = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV38DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV30ProdutoIdTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV32ProdutoNomeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV34ProdutoValorTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV36PedidoItemQtdTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV8GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         Ddo_produtoid_Sortedstatus = "";
         Ddo_produtonome_Sortedstatus = "";
         Ddo_produtovalor_Sortedstatus = "";
         Ddo_pedidoitemqtd_Sortedstatus = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ucDvpanel_tableheader = new GXUserControl();
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV42Select = "";
         A9ProdutoNome = "";
         ucGridpaginationbar = new GXUserControl();
         lblJsdynamicfilters_Jsonclick = "";
         ucDdo_produtoid = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         ucDdo_produtonome = new GXUserControl();
         ucDdo_produtovalor = new GXUserControl();
         ucDdo_pedidoitemqtd = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV48Select_GXI = "";
         scmdbuf = "";
         lV16ProdutoNome1 = "";
         lV21ProdutoNome2 = "";
         lV26ProdutoNome3 = "";
         H00152_A32PedidoId = new short[1] ;
         H00152_A33PedidoDt = new DateTime[] {DateTime.MinValue} ;
         H00152_A38PedidoItemQtd = new short[1] ;
         H00152_A11ProdutoValor = new decimal[1] ;
         H00152_A9ProdutoNome = new String[] {""} ;
         H00152_A8ProdutoId = new short[1] ;
         A33PedidoDt = DateTime.MinValue;
         H00153_AGRID_nRecordCount = new long[1] ;
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pedidoitemprompt__default(),
            new Object[][] {
                new Object[] {
               H00152_A32PedidoId, H00152_A33PedidoDt, H00152_A38PedidoItemQtd, H00152_A11ProdutoValor, H00152_A9ProdutoNome, H00152_A8ProdutoId
               }
               , new Object[] {
               H00153_AGRID_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV43InPedidoId ;
      private short AV44InOutProdutoId ;
      private short AV45InOutPedidoItemQtd ;
      private short wcpOAV43InPedidoId ;
      private short wcpOAV44InOutProdutoId ;
      private short wcpOAV45InOutPedidoItemQtd ;
      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_104 ;
      private short nGXsfl_104_idx=1 ;
      private short GRID_nEOF ;
      private short AV14DynamicFiltersOperator1 ;
      private short AV15PedidoItemQtd1 ;
      private short AV19DynamicFiltersOperator2 ;
      private short AV20PedidoItemQtd2 ;
      private short AV24DynamicFiltersOperator3 ;
      private short AV25PedidoItemQtd3 ;
      private short AV11OrderedBy ;
      private short initialized ;
      private short gxajaxcallmode ;
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
      private short nDonePA ;
      private short gxcookieaux ;
      private short A32PedidoId ;
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
      private int edtavDdo_produtovalortitlecontrolidtoreplace_Visible ;
      private int edtavDdo_pedidoitemqtdtitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV39PageToGo ;
      private int imgAdddynamicfilters1_Visible ;
      private int imgRemovedynamicfilters1_Visible ;
      private int imgAdddynamicfilters2_Visible ;
      private int imgRemovedynamicfilters2_Visible ;
      private int edtavPedidoitemqtd1_Visible ;
      private int edtavProdutonome1_Visible ;
      private int edtavPedidoitemqtd2_Visible ;
      private int edtavProdutonome2_Visible ;
      private int edtavPedidoitemqtd3_Visible ;
      private int edtavProdutonome3_Visible ;
      private int edtavPedidoitemqtd3_Enabled ;
      private int edtavProdutonome3_Enabled ;
      private int edtavPedidoitemqtd2_Enabled ;
      private int edtavProdutonome2_Enabled ;
      private int edtavPedidoitemqtd1_Enabled ;
      private int edtavProdutonome1_Enabled ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavSelect_Enabled ;
      private int edtavSelect_Visible ;
      private long GRID_nFirstRecordOnPage ;
      private long AV40GridCurrentPage ;
      private long AV41GridPageCount ;
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
      private String sGXsfl_104_idx="0001" ;
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
      private String edtProdutoValor_Title ;
      private String edtPedidoItemQtd_Title ;
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
      private String Ddo_produtovalor_Internalname ;
      private String edtavDdo_produtovalortitlecontrolidtoreplace_Internalname ;
      private String Ddo_pedidoitemqtd_Internalname ;
      private String edtavDdo_pedidoitemqtdtitlecontrolidtoreplace_Internalname ;
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
      private String edtProdutoValor_Internalname ;
      private String edtPedidoItemQtd_Internalname ;
      private String cmbavDynamicfiltersselector1_Internalname ;
      private String cmbavDynamicfiltersoperator1_Internalname ;
      private String cmbavDynamicfiltersselector2_Internalname ;
      private String cmbavDynamicfiltersoperator2_Internalname ;
      private String cmbavDynamicfiltersselector3_Internalname ;
      private String cmbavDynamicfiltersoperator3_Internalname ;
      private String scmdbuf ;
      private String edtavPedidoitemqtd1_Internalname ;
      private String edtavProdutonome1_Internalname ;
      private String edtavPedidoitemqtd2_Internalname ;
      private String edtavProdutonome2_Internalname ;
      private String edtavPedidoitemqtd3_Internalname ;
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
      private String cellFilter_pedidoitemqtd3_cell_Internalname ;
      private String edtavPedidoitemqtd3_Jsonclick ;
      private String cellFilter_produtonome3_cell_Internalname ;
      private String edtavProdutonome3_Jsonclick ;
      private String tblUnnamedtabledynamicfilters_2_Internalname ;
      private String cellDynamicfilters_addfilter2_cell_Internalname ;
      private String cellDynamicfilters_removefilter2_cell_Internalname ;
      private String tblTablemergeddynamicfilters2_Internalname ;
      private String cmbavDynamicfiltersoperator2_Jsonclick ;
      private String cellFilter_pedidoitemqtd2_cell_Internalname ;
      private String edtavPedidoitemqtd2_Jsonclick ;
      private String cellFilter_produtonome2_cell_Internalname ;
      private String edtavProdutonome2_Jsonclick ;
      private String tblUnnamedtabledynamicfilters_1_Internalname ;
      private String cellDynamicfilters_addfilter1_cell_Internalname ;
      private String cellDynamicfilters_removefilter1_cell_Internalname ;
      private String tblTablemergeddynamicfilters1_Internalname ;
      private String cmbavDynamicfiltersoperator1_Jsonclick ;
      private String cellFilter_pedidoitemqtd1_cell_Internalname ;
      private String edtavPedidoitemqtd1_Jsonclick ;
      private String cellFilter_produtonome1_cell_Internalname ;
      private String edtavProdutonome1_Jsonclick ;
      private String sGXsfl_104_fel_idx="0001" ;
      private String edtavSelect_Jsonclick ;
      private String ROClassString ;
      private String edtProdutoId_Jsonclick ;
      private String edtProdutoNome_Jsonclick ;
      private String edtProdutoValor_Jsonclick ;
      private String edtPedidoItemQtd_Jsonclick ;
      private DateTime A33PedidoDt ;
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
      private bool bGXsfl_104_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV42Select_IsBlob ;
      private String AV13DynamicFiltersSelector1 ;
      private String AV16ProdutoNome1 ;
      private String AV18DynamicFiltersSelector2 ;
      private String AV21ProdutoNome2 ;
      private String AV23DynamicFiltersSelector3 ;
      private String AV26ProdutoNome3 ;
      private String AV31ddo_ProdutoIdTitleControlIdToReplace ;
      private String AV33ddo_ProdutoNomeTitleControlIdToReplace ;
      private String AV35ddo_ProdutoValorTitleControlIdToReplace ;
      private String AV37ddo_PedidoItemQtdTitleControlIdToReplace ;
      private String A9ProdutoNome ;
      private String AV48Select_GXI ;
      private String lV16ProdutoNome1 ;
      private String lV21ProdutoNome2 ;
      private String lV26ProdutoNome3 ;
      private String AV42Select ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_produtoid ;
      private GXUserControl ucDdo_produtonome ;
      private GXUserControl ucDdo_produtovalor ;
      private GXUserControl ucDdo_pedidoitemqtd ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private IGxDataStore dsDefault ;
      private short aP1_InOutProdutoId ;
      private short aP2_InOutPedidoItemQtd ;
      private GXCombobox cmbavDynamicfiltersselector1 ;
      private GXCombobox cmbavDynamicfiltersoperator1 ;
      private GXCombobox cmbavDynamicfiltersselector2 ;
      private GXCombobox cmbavDynamicfiltersoperator2 ;
      private GXCombobox cmbavDynamicfiltersselector3 ;
      private GXCombobox cmbavDynamicfiltersoperator3 ;
      private GXCheckbox chkavDynamicfiltersenabled2 ;
      private GXCheckbox chkavDynamicfiltersenabled3 ;
      private IDataStoreProvider pr_default ;
      private short[] H00152_A32PedidoId ;
      private DateTime[] H00152_A33PedidoDt ;
      private short[] H00152_A38PedidoItemQtd ;
      private decimal[] H00152_A11ProdutoValor ;
      private String[] H00152_A9ProdutoNome ;
      private short[] H00152_A8ProdutoId ;
      private long[] H00153_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV30ProdutoIdTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV32ProdutoNomeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV34ProdutoValorTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV36PedidoItemQtdTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV8GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_DynamicFilter AV10GridStateDynamicFilter ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV38DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class pedidoitemprompt__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00152( IGxContext context ,
                                             String AV13DynamicFiltersSelector1 ,
                                             short AV14DynamicFiltersOperator1 ,
                                             short AV15PedidoItemQtd1 ,
                                             String AV16ProdutoNome1 ,
                                             bool AV17DynamicFiltersEnabled2 ,
                                             String AV18DynamicFiltersSelector2 ,
                                             short AV19DynamicFiltersOperator2 ,
                                             short AV20PedidoItemQtd2 ,
                                             String AV21ProdutoNome2 ,
                                             bool AV22DynamicFiltersEnabled3 ,
                                             String AV23DynamicFiltersSelector3 ,
                                             short AV24DynamicFiltersOperator3 ,
                                             short AV25PedidoItemQtd3 ,
                                             String AV26ProdutoNome3 ,
                                             short A38PedidoItemQtd ,
                                             String A9ProdutoNome ,
                                             short AV11OrderedBy ,
                                             bool AV12OrderedDsc ,
                                             short A32PedidoId ,
                                             short AV43InPedidoId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [19] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " T1.[PedidoId], T2.[PedidoDt], T1.[PedidoItemQtd], T3.[ProdutoValor], T3.[ProdutoNome], T1.[ProdutoId]";
         sFromString = " FROM (([PedidoItem] T1 INNER JOIN [Pedido] T2 ON T2.[PedidoId] = T1.[PedidoId]) INNER JOIN [Produto] T3 ON T3.[ProdutoId] = T1.[ProdutoId])";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE (T1.[PedidoId] = @AV43InPedidoId)";
         if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PEDIDOITEMQTD") == 0 ) && ( AV14DynamicFiltersOperator1 == 0 ) && ( ! (0==AV15PedidoItemQtd1) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoItemQtd] < @AV15PedidoItemQtd1)";
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PEDIDOITEMQTD") == 0 ) && ( AV14DynamicFiltersOperator1 == 1 ) && ( ! (0==AV15PedidoItemQtd1) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoItemQtd] = @AV15PedidoItemQtd1)";
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PEDIDOITEMQTD") == 0 ) && ( AV14DynamicFiltersOperator1 == 2 ) && ( ! (0==AV15PedidoItemQtd1) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoItemQtd] > @AV15PedidoItemQtd1)";
         }
         else
         {
            GXv_int2[3] = 1;
         }
         if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PRODUTONOME") == 0 ) && ( AV14DynamicFiltersOperator1 == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV16ProdutoNome1)) ) )
         {
            sWhereString = sWhereString + " and (T3.[ProdutoNome] like @lV16ProdutoNome1)";
         }
         else
         {
            GXv_int2[4] = 1;
         }
         if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PRODUTONOME") == 0 ) && ( AV14DynamicFiltersOperator1 == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV16ProdutoNome1)) ) )
         {
            sWhereString = sWhereString + " and (T3.[ProdutoNome] like '%' + @lV16ProdutoNome1)";
         }
         else
         {
            GXv_int2[5] = 1;
         }
         if ( AV17DynamicFiltersEnabled2 && ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PEDIDOITEMQTD") == 0 ) && ( AV19DynamicFiltersOperator2 == 0 ) && ( ! (0==AV20PedidoItemQtd2) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoItemQtd] < @AV20PedidoItemQtd2)";
         }
         else
         {
            GXv_int2[6] = 1;
         }
         if ( AV17DynamicFiltersEnabled2 && ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PEDIDOITEMQTD") == 0 ) && ( AV19DynamicFiltersOperator2 == 1 ) && ( ! (0==AV20PedidoItemQtd2) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoItemQtd] = @AV20PedidoItemQtd2)";
         }
         else
         {
            GXv_int2[7] = 1;
         }
         if ( AV17DynamicFiltersEnabled2 && ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PEDIDOITEMQTD") == 0 ) && ( AV19DynamicFiltersOperator2 == 2 ) && ( ! (0==AV20PedidoItemQtd2) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoItemQtd] > @AV20PedidoItemQtd2)";
         }
         else
         {
            GXv_int2[8] = 1;
         }
         if ( AV17DynamicFiltersEnabled2 && ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PRODUTONOME") == 0 ) && ( AV19DynamicFiltersOperator2 == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV21ProdutoNome2)) ) )
         {
            sWhereString = sWhereString + " and (T3.[ProdutoNome] like @lV21ProdutoNome2)";
         }
         else
         {
            GXv_int2[9] = 1;
         }
         if ( AV17DynamicFiltersEnabled2 && ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PRODUTONOME") == 0 ) && ( AV19DynamicFiltersOperator2 == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV21ProdutoNome2)) ) )
         {
            sWhereString = sWhereString + " and (T3.[ProdutoNome] like '%' + @lV21ProdutoNome2)";
         }
         else
         {
            GXv_int2[10] = 1;
         }
         if ( AV22DynamicFiltersEnabled3 && ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PEDIDOITEMQTD") == 0 ) && ( AV24DynamicFiltersOperator3 == 0 ) && ( ! (0==AV25PedidoItemQtd3) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoItemQtd] < @AV25PedidoItemQtd3)";
         }
         else
         {
            GXv_int2[11] = 1;
         }
         if ( AV22DynamicFiltersEnabled3 && ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PEDIDOITEMQTD") == 0 ) && ( AV24DynamicFiltersOperator3 == 1 ) && ( ! (0==AV25PedidoItemQtd3) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoItemQtd] = @AV25PedidoItemQtd3)";
         }
         else
         {
            GXv_int2[12] = 1;
         }
         if ( AV22DynamicFiltersEnabled3 && ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PEDIDOITEMQTD") == 0 ) && ( AV24DynamicFiltersOperator3 == 2 ) && ( ! (0==AV25PedidoItemQtd3) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoItemQtd] > @AV25PedidoItemQtd3)";
         }
         else
         {
            GXv_int2[13] = 1;
         }
         if ( AV22DynamicFiltersEnabled3 && ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PRODUTONOME") == 0 ) && ( AV24DynamicFiltersOperator3 == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV26ProdutoNome3)) ) )
         {
            sWhereString = sWhereString + " and (T3.[ProdutoNome] like @lV26ProdutoNome3)";
         }
         else
         {
            GXv_int2[14] = 1;
         }
         if ( AV22DynamicFiltersEnabled3 && ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PRODUTONOME") == 0 ) && ( AV24DynamicFiltersOperator3 == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV26ProdutoNome3)) ) )
         {
            sWhereString = sWhereString + " and (T3.[ProdutoNome] like '%' + @lV26ProdutoNome3)";
         }
         else
         {
            GXv_int2[15] = 1;
         }
         if ( AV11OrderedBy == 1 )
         {
            sOrderString = sOrderString + " ORDER BY T2.[PedidoDt]";
         }
         else if ( ( AV11OrderedBy == 2 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[ProdutoId]";
         }
         else if ( ( AV11OrderedBy == 2 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[ProdutoId] DESC";
         }
         else if ( ( AV11OrderedBy == 3 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T3.[ProdutoNome]";
         }
         else if ( ( AV11OrderedBy == 3 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T3.[ProdutoNome] DESC";
         }
         else if ( ( AV11OrderedBy == 4 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T3.[ProdutoValor]";
         }
         else if ( ( AV11OrderedBy == 4 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T3.[ProdutoValor] DESC";
         }
         else if ( ( AV11OrderedBy == 5 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[PedidoItemQtd]";
         }
         else if ( ( AV11OrderedBy == 5 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[PedidoItemQtd] DESC";
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

      protected Object[] conditional_H00153( IGxContext context ,
                                             String AV13DynamicFiltersSelector1 ,
                                             short AV14DynamicFiltersOperator1 ,
                                             short AV15PedidoItemQtd1 ,
                                             String AV16ProdutoNome1 ,
                                             bool AV17DynamicFiltersEnabled2 ,
                                             String AV18DynamicFiltersSelector2 ,
                                             short AV19DynamicFiltersOperator2 ,
                                             short AV20PedidoItemQtd2 ,
                                             String AV21ProdutoNome2 ,
                                             bool AV22DynamicFiltersEnabled3 ,
                                             String AV23DynamicFiltersSelector3 ,
                                             short AV24DynamicFiltersOperator3 ,
                                             short AV25PedidoItemQtd3 ,
                                             String AV26ProdutoNome3 ,
                                             short A38PedidoItemQtd ,
                                             String A9ProdutoNome ,
                                             short AV11OrderedBy ,
                                             bool AV12OrderedDsc ,
                                             short A32PedidoId ,
                                             short AV43InPedidoId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [16] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM (([PedidoItem] T1 INNER JOIN [Pedido] T2 ON T2.[PedidoId] = T1.[PedidoId]) INNER JOIN [Produto] T3 ON T3.[ProdutoId] = T1.[ProdutoId])";
         scmdbuf = scmdbuf + " WHERE (T1.[PedidoId] = @AV43InPedidoId)";
         if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PEDIDOITEMQTD") == 0 ) && ( AV14DynamicFiltersOperator1 == 0 ) && ( ! (0==AV15PedidoItemQtd1) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoItemQtd] < @AV15PedidoItemQtd1)";
         }
         else
         {
            GXv_int4[1] = 1;
         }
         if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PEDIDOITEMQTD") == 0 ) && ( AV14DynamicFiltersOperator1 == 1 ) && ( ! (0==AV15PedidoItemQtd1) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoItemQtd] = @AV15PedidoItemQtd1)";
         }
         else
         {
            GXv_int4[2] = 1;
         }
         if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PEDIDOITEMQTD") == 0 ) && ( AV14DynamicFiltersOperator1 == 2 ) && ( ! (0==AV15PedidoItemQtd1) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoItemQtd] > @AV15PedidoItemQtd1)";
         }
         else
         {
            GXv_int4[3] = 1;
         }
         if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PRODUTONOME") == 0 ) && ( AV14DynamicFiltersOperator1 == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV16ProdutoNome1)) ) )
         {
            sWhereString = sWhereString + " and (T3.[ProdutoNome] like @lV16ProdutoNome1)";
         }
         else
         {
            GXv_int4[4] = 1;
         }
         if ( ( StringUtil.StrCmp(AV13DynamicFiltersSelector1, "PRODUTONOME") == 0 ) && ( AV14DynamicFiltersOperator1 == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV16ProdutoNome1)) ) )
         {
            sWhereString = sWhereString + " and (T3.[ProdutoNome] like '%' + @lV16ProdutoNome1)";
         }
         else
         {
            GXv_int4[5] = 1;
         }
         if ( AV17DynamicFiltersEnabled2 && ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PEDIDOITEMQTD") == 0 ) && ( AV19DynamicFiltersOperator2 == 0 ) && ( ! (0==AV20PedidoItemQtd2) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoItemQtd] < @AV20PedidoItemQtd2)";
         }
         else
         {
            GXv_int4[6] = 1;
         }
         if ( AV17DynamicFiltersEnabled2 && ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PEDIDOITEMQTD") == 0 ) && ( AV19DynamicFiltersOperator2 == 1 ) && ( ! (0==AV20PedidoItemQtd2) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoItemQtd] = @AV20PedidoItemQtd2)";
         }
         else
         {
            GXv_int4[7] = 1;
         }
         if ( AV17DynamicFiltersEnabled2 && ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PEDIDOITEMQTD") == 0 ) && ( AV19DynamicFiltersOperator2 == 2 ) && ( ! (0==AV20PedidoItemQtd2) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoItemQtd] > @AV20PedidoItemQtd2)";
         }
         else
         {
            GXv_int4[8] = 1;
         }
         if ( AV17DynamicFiltersEnabled2 && ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PRODUTONOME") == 0 ) && ( AV19DynamicFiltersOperator2 == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV21ProdutoNome2)) ) )
         {
            sWhereString = sWhereString + " and (T3.[ProdutoNome] like @lV21ProdutoNome2)";
         }
         else
         {
            GXv_int4[9] = 1;
         }
         if ( AV17DynamicFiltersEnabled2 && ( StringUtil.StrCmp(AV18DynamicFiltersSelector2, "PRODUTONOME") == 0 ) && ( AV19DynamicFiltersOperator2 == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV21ProdutoNome2)) ) )
         {
            sWhereString = sWhereString + " and (T3.[ProdutoNome] like '%' + @lV21ProdutoNome2)";
         }
         else
         {
            GXv_int4[10] = 1;
         }
         if ( AV22DynamicFiltersEnabled3 && ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PEDIDOITEMQTD") == 0 ) && ( AV24DynamicFiltersOperator3 == 0 ) && ( ! (0==AV25PedidoItemQtd3) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoItemQtd] < @AV25PedidoItemQtd3)";
         }
         else
         {
            GXv_int4[11] = 1;
         }
         if ( AV22DynamicFiltersEnabled3 && ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PEDIDOITEMQTD") == 0 ) && ( AV24DynamicFiltersOperator3 == 1 ) && ( ! (0==AV25PedidoItemQtd3) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoItemQtd] = @AV25PedidoItemQtd3)";
         }
         else
         {
            GXv_int4[12] = 1;
         }
         if ( AV22DynamicFiltersEnabled3 && ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PEDIDOITEMQTD") == 0 ) && ( AV24DynamicFiltersOperator3 == 2 ) && ( ! (0==AV25PedidoItemQtd3) ) )
         {
            sWhereString = sWhereString + " and (T1.[PedidoItemQtd] > @AV25PedidoItemQtd3)";
         }
         else
         {
            GXv_int4[13] = 1;
         }
         if ( AV22DynamicFiltersEnabled3 && ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PRODUTONOME") == 0 ) && ( AV24DynamicFiltersOperator3 == 0 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV26ProdutoNome3)) ) )
         {
            sWhereString = sWhereString + " and (T3.[ProdutoNome] like @lV26ProdutoNome3)";
         }
         else
         {
            GXv_int4[14] = 1;
         }
         if ( AV22DynamicFiltersEnabled3 && ( StringUtil.StrCmp(AV23DynamicFiltersSelector3, "PRODUTONOME") == 0 ) && ( AV24DynamicFiltersOperator3 == 1 ) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV26ProdutoNome3)) ) )
         {
            sWhereString = sWhereString + " and (T3.[ProdutoNome] like '%' + @lV26ProdutoNome3)";
         }
         else
         {
            GXv_int4[15] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         if ( AV11OrderedBy == 1 )
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
                     return conditional_H00152(context, (String)dynConstraints[0] , (short)dynConstraints[1] , (short)dynConstraints[2] , (String)dynConstraints[3] , (bool)dynConstraints[4] , (String)dynConstraints[5] , (short)dynConstraints[6] , (short)dynConstraints[7] , (String)dynConstraints[8] , (bool)dynConstraints[9] , (String)dynConstraints[10] , (short)dynConstraints[11] , (short)dynConstraints[12] , (String)dynConstraints[13] , (short)dynConstraints[14] , (String)dynConstraints[15] , (short)dynConstraints[16] , (bool)dynConstraints[17] , (short)dynConstraints[18] , (short)dynConstraints[19] );
               case 1 :
                     return conditional_H00153(context, (String)dynConstraints[0] , (short)dynConstraints[1] , (short)dynConstraints[2] , (String)dynConstraints[3] , (bool)dynConstraints[4] , (String)dynConstraints[5] , (short)dynConstraints[6] , (short)dynConstraints[7] , (String)dynConstraints[8] , (bool)dynConstraints[9] , (String)dynConstraints[10] , (short)dynConstraints[11] , (short)dynConstraints[12] , (String)dynConstraints[13] , (short)dynConstraints[14] , (String)dynConstraints[15] , (short)dynConstraints[16] , (bool)dynConstraints[17] , (short)dynConstraints[18] , (short)dynConstraints[19] );
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
          Object[] prmH00152 ;
          prmH00152 = new Object[] {
          new Object[] {"@AV43InPedidoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV15PedidoItemQtd1",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV15PedidoItemQtd1",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV15PedidoItemQtd1",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV16ProdutoNome1",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV16ProdutoNome1",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV20PedidoItemQtd2",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV20PedidoItemQtd2",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV20PedidoItemQtd2",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV21ProdutoNome2",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV21ProdutoNome2",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV25PedidoItemQtd3",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV25PedidoItemQtd3",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV25PedidoItemQtd3",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV26ProdutoNome3",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV26ProdutoNome3",SqlDbType.VarChar,50,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00153 ;
          prmH00153 = new Object[] {
          new Object[] {"@AV43InPedidoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV15PedidoItemQtd1",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV15PedidoItemQtd1",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV15PedidoItemQtd1",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV16ProdutoNome1",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV16ProdutoNome1",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV20PedidoItemQtd2",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV20PedidoItemQtd2",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV20PedidoItemQtd2",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV21ProdutoNome2",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV21ProdutoNome2",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV25PedidoItemQtd3",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV25PedidoItemQtd3",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV25PedidoItemQtd3",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV26ProdutoNome3",SqlDbType.VarChar,50,0} ,
          new Object[] {"@lV26ProdutoNome3",SqlDbType.VarChar,50,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00152", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00152,11, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("H00153", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00153,1, GxCacheFrequency.OFF ,true,false )
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
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
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
                   stmt.SetParameter(sIdx, (short)parms[19]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[20]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[21]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[22]);
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
                   stmt.SetParameter(sIdx, (short)parms[27]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[28]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[29]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[30]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[31]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[32]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[33]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[34]);
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
                   stmt.SetParameter(sIdx, (short)parms[16]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[17]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[18]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[19]);
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
                   stmt.SetParameter(sIdx, (short)parms[24]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[25]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[26]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[27]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[28]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[29]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[30]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[31]);
                }
                return;
       }
    }

 }

}
