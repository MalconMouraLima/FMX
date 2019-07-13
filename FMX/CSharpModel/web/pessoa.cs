/*
               File: Pessoa
        Description: Pessoa
             Author: GeneXus C# Generator version 16_0_2-131213
       Generated on: 7/12/2019 16:32:21.78
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
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class pessoa : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
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
            Gx_mode = gxfirstwebparm;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               AV7PessoaId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7PessoaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7PessoaId), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vPESSOAID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7PessoaId), "ZZZ9"), context));
            }
         }
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
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
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_2-131213", 0) ;
            Form.Meta.addItem("description", "Pessoa", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtPessoaNome_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public pessoa( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public pessoa( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_PessoaId )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7PessoaId = aP1_PessoaId;
         executePrivate();
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

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
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

      protected void fix_multi_value_controls( )
      {
         if ( cmbPessoaSexo.ItemCount > 0 )
         {
            A6PessoaSexo = cmbPessoaSexo.getValidValue(A6PessoaSexo);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6PessoaSexo", A6PessoaSexo);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbPessoaSexo.CurrentValue = StringUtil.RTrim( A6PessoaSexo);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPessoaSexo_Internalname, "Values", cmbPessoaSexo.ToJavascriptSource(), true);
         }
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayoutmaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "TableMainTransaction", "left", "top", "", "", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablecontent_Internalname, 1, 0, "px", 0, "px", "TableContent", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-lg-6", "left", "top", "", "", "div");
            /* User Defined Control */
            ucDvpanel_tableattributes.SetProperty("Width", Dvpanel_tableattributes_Width);
            ucDvpanel_tableattributes.SetProperty("AutoWidth", Dvpanel_tableattributes_Autowidth);
            ucDvpanel_tableattributes.SetProperty("AutoHeight", Dvpanel_tableattributes_Autoheight);
            ucDvpanel_tableattributes.SetProperty("Cls", Dvpanel_tableattributes_Cls);
            ucDvpanel_tableattributes.SetProperty("Title", Dvpanel_tableattributes_Title);
            ucDvpanel_tableattributes.SetProperty("Collapsible", Dvpanel_tableattributes_Collapsible);
            ucDvpanel_tableattributes.SetProperty("Collapsed", Dvpanel_tableattributes_Collapsed);
            ucDvpanel_tableattributes.SetProperty("ShowCollapseIcon", Dvpanel_tableattributes_Showcollapseicon);
            ucDvpanel_tableattributes.SetProperty("IconPosition", Dvpanel_tableattributes_Iconposition);
            ucDvpanel_tableattributes.SetProperty("AutoScroll", Dvpanel_tableattributes_Autoscroll);
            ucDvpanel_tableattributes.Render(context, "dvelop.gxbootstrap.panel_al", Dvpanel_tableattributes_Internalname, "DVPANEL_TABLEATTRIBUTESContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_TABLEATTRIBUTESContainer"+"TableAttributes"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableattributes_Internalname, 1, 0, "px", 0, "px", "TableData", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPessoaId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPessoaId_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtPessoaId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1PessoaId), 4, 0, ",", "")), ((edtPessoaId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A1PessoaId), "ZZZ9")) : context.localUtil.Format( (decimal)(A1PessoaId), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPessoaId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPessoaId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Serial", "right", false, "HLP_Pessoa.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPessoaNome_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPessoaNome_Internalname, "Nome", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtPessoaNome_Internalname, A2PessoaNome, StringUtil.RTrim( context.localUtil.Format( A2PessoaNome, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,27);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPessoaNome_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPessoaNome_Enabled, 0, "text", "", 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Pessoa.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPessoaEndereco_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPessoaEndereco_Internalname, "Endereço", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 32,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtPessoaEndereco_Internalname, A3PessoaEndereco, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,32);\"", 0, 1, edtPessoaEndereco_Enabled, 0, 80, "chr", 7, "row", StyleString, ClassString, "", "", "500", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_Pessoa.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPessoaTelefone_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPessoaTelefone_Internalname, "Telefone", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtPessoaTelefone_Internalname, A4PessoaTelefone, StringUtil.RTrim( context.localUtil.Format( A4PessoaTelefone, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,37);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPessoaTelefone_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPessoaTelefone_Enabled, 0, "text", "", 11, "chr", 1, "row", 11, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Pessoa.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPessoaEmail_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPessoaEmail_Internalname, "E-mail", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtPessoaEmail_Internalname, A5PessoaEmail, StringUtil.RTrim( context.localUtil.Format( A5PessoaEmail, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,42);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPessoaEmail_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPessoaEmail_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Pessoa.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbPessoaSexo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbPessoaSexo_Internalname, "Sexo", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbPessoaSexo, cmbPessoaSexo_Internalname, StringUtil.RTrim( A6PessoaSexo), 1, cmbPessoaSexo_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbPessoaSexo.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,47);\"", "", true, "HLP_Pessoa.htm");
            cmbPessoaSexo.CurrentValue = StringUtil.RTrim( A6PessoaSexo);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPessoaSexo_Internalname, "Values", (String)(cmbPessoaSexo.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedpessoasituacao_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockpessoasituacao_Internalname, "Situação", "", "", lblTextblockpessoasituacao_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label BootstrapTooltipTop", 0, "Ativo/Inativo", 1, 1, 0, "HLP_Pessoa.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table1_55_011( true) ;
         }
         return  ;
      }

      protected void wb_table1_55_011e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group TrnActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_enter_Internalname, "", "Confirmar", bttBtntrn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtntrn_enter_Visible, bttBtntrn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Pessoa.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_cancel_Internalname, "", "Fechar", bttBtntrn_cancel_Jsonclick, 1, "Fechar", "", StyleString, ClassString, bttBtntrn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Pessoa.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 70,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_delete_Internalname, "", "Eliminar", bttBtntrn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtntrn_delete_Visible, bttBtntrn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Pessoa.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_55_011( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedpessoasituacao_Internalname, tblTablemergedpessoasituacao_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkPessoaSituacao_Internalname, "Situação", "col-sm-3 AttributeCheckBoxLabel BootstrapTooltipRightLabel", 0, true);
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
            ClassString = "AttributeCheckBox BootstrapTooltipRight";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkPessoaSituacao_Internalname, StringUtil.BoolToStr( A7PessoaSituacao), chkPessoaSituacao.TooltipText, "Situação", 1, chkPessoaSituacao.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(59, this, 'true', 'false');gx.evt.onchange(this, event);\" ");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblPessoasituacao_righttext_Internalname, "Ativo/Inativo", "", "", lblPessoasituacao_righttext_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataDescription", 0, "", 1, 1, 0, "HLP_Pessoa.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_55_011e( true) ;
         }
         else
         {
            wb_table1_55_011e( false) ;
         }
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void UserMainFullajax( )
      {
         INITENV( ) ;
         INITTRN( ) ;
         UserMain( ) ;
         Draw( ) ;
         SendCloseFormHiddens( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E11012 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A1PessoaId = (short)(context.localUtil.CToN( cgiGet( edtPessoaId_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1PessoaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1PessoaId), 4, 0)));
               A2PessoaNome = cgiGet( edtPessoaNome_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2PessoaNome", A2PessoaNome);
               A3PessoaEndereco = cgiGet( edtPessoaEndereco_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3PessoaEndereco", A3PessoaEndereco);
               A4PessoaTelefone = cgiGet( edtPessoaTelefone_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4PessoaTelefone", A4PessoaTelefone);
               A5PessoaEmail = cgiGet( edtPessoaEmail_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5PessoaEmail", A5PessoaEmail);
               cmbPessoaSexo.CurrentValue = cgiGet( cmbPessoaSexo_Internalname);
               A6PessoaSexo = cgiGet( cmbPessoaSexo_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6PessoaSexo", A6PessoaSexo);
               A7PessoaSituacao = StringUtil.StrToBool( cgiGet( chkPessoaSituacao_Internalname));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7PessoaSituacao", A7PessoaSituacao);
               /* Read saved values. */
               Z1PessoaId = (short)(context.localUtil.CToN( cgiGet( "Z1PessoaId"), ",", "."));
               Z7PessoaSituacao = StringUtil.StrToBool( cgiGet( "Z7PessoaSituacao"));
               Z2PessoaNome = cgiGet( "Z2PessoaNome");
               Z3PessoaEndereco = cgiGet( "Z3PessoaEndereco");
               Z4PessoaTelefone = cgiGet( "Z4PessoaTelefone");
               Z5PessoaEmail = cgiGet( "Z5PessoaEmail");
               Z6PessoaSexo = cgiGet( "Z6PessoaSexo");
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               AV7PessoaId = (short)(context.localUtil.CToN( cgiGet( "vPESSOAID"), ",", "."));
               Gx_mode = cgiGet( "vMODE");
               Dvpanel_tableattributes_Objectcall = cgiGet( "DVPANEL_TABLEATTRIBUTES_Objectcall");
               Dvpanel_tableattributes_Class = cgiGet( "DVPANEL_TABLEATTRIBUTES_Class");
               Dvpanel_tableattributes_Enabled = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Enabled"));
               Dvpanel_tableattributes_Width = cgiGet( "DVPANEL_TABLEATTRIBUTES_Width");
               Dvpanel_tableattributes_Height = cgiGet( "DVPANEL_TABLEATTRIBUTES_Height");
               Dvpanel_tableattributes_Cls = cgiGet( "DVPANEL_TABLEATTRIBUTES_Cls");
               Dvpanel_tableattributes_Title = cgiGet( "DVPANEL_TABLEATTRIBUTES_Title");
               Dvpanel_tableattributes_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Collapsible"));
               Dvpanel_tableattributes_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Collapsed"));
               Dvpanel_tableattributes_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autowidth"));
               Dvpanel_tableattributes_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autoheight"));
               Dvpanel_tableattributes_Showheader = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Showheader"));
               Dvpanel_tableattributes_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Showcollapseicon"));
               Dvpanel_tableattributes_Iconposition = cgiGet( "DVPANEL_TABLEATTRIBUTES_Iconposition");
               Dvpanel_tableattributes_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autoscroll"));
               Dvpanel_tableattributes_Visible = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Visible"));
               Dvpanel_tableattributes_Gxcontroltype = (int)(context.localUtil.CToN( cgiGet( "DVPANEL_TABLEATTRIBUTES_Gxcontroltype"), ",", "."));
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Pessoa";
               A1PessoaId = (short)(context.localUtil.CToN( cgiGet( edtPessoaId_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1PessoaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1PessoaId), 4, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A1PessoaId), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A1PessoaId != Z1PessoaId ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("pessoa:[SecurityCheckFailed value for]"+"PessoaId:"+context.localUtil.Format( (decimal)(A1PessoaId), "ZZZ9"));
                  GXUtil.WriteLog("pessoa:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GxWebError = 1;
                  context.HttpContext.Response.StatusDescription = 403.ToString();
                  context.HttpContext.Response.StatusCode = 403;
                  context.WriteHtmlText( "<title>403 Forbidden</title>") ;
                  context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
                  context.WriteHtmlText( "<p /><hr />") ;
                  GXUtil.WriteLog("send_http_error_code " + 403.ToString());
                  AnyError = 1;
                  return  ;
               }
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  A1PessoaId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1PessoaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1PessoaId), 4, 0)));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  disable_std_buttons( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
                  {
                     sMode1 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode1;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound1 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_010( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtntrn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "PESSOAID");
                        AnyError = 1;
                        GX_FocusControl = edtPessoaId_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
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
                        if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Start */
                           E11012 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12012 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1;
                           if ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 )
                           {
                              btn_enter( ) ;
                           }
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                     }
                     else
                     {
                     }
                  }
                  context.wbHandled = 1;
               }
            }
         }
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E12012 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll011( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      protected void disable_std_buttons( )
      {
         bttBtntrn_delete_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Visible), 5, 0)), true);
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            bttBtntrn_delete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Visible), 5, 0)), true);
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               bttBtntrn_enter_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_enter_Visible), 5, 0)), true);
            }
            DisableAttributes011( ) ;
         }
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete", ""), 0, "", true);
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm", ""), 0, "", true);
            }
         }
      }

      protected void CONFIRM_010( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls011( ) ;
            }
            else
            {
               CheckExtendedTable011( ) ;
               CloseExtendedTableCursors011( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption010( )
      {
      }

      protected void E11012( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         chkPessoaSituacao.TooltipText = "Ativo/Inativo";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkPessoaSituacao_Internalname, "Tooltiptext", chkPessoaSituacao.TooltipText, true);
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "WWPTransactionContext", "FMX");
      }

      protected void E12012( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("pessoaww.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM011( short GX_JID )
      {
         if ( ( GX_JID == 7 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z7PessoaSituacao = T00013_A7PessoaSituacao[0];
               Z2PessoaNome = T00013_A2PessoaNome[0];
               Z3PessoaEndereco = T00013_A3PessoaEndereco[0];
               Z4PessoaTelefone = T00013_A4PessoaTelefone[0];
               Z5PessoaEmail = T00013_A5PessoaEmail[0];
               Z6PessoaSexo = T00013_A6PessoaSexo[0];
            }
            else
            {
               Z7PessoaSituacao = A7PessoaSituacao;
               Z2PessoaNome = A2PessoaNome;
               Z3PessoaEndereco = A3PessoaEndereco;
               Z4PessoaTelefone = A4PessoaTelefone;
               Z5PessoaEmail = A5PessoaEmail;
               Z6PessoaSexo = A6PessoaSexo;
            }
         }
         if ( GX_JID == -7 )
         {
            Z1PessoaId = A1PessoaId;
            Z7PessoaSituacao = A7PessoaSituacao;
            Z2PessoaNome = A2PessoaNome;
            Z3PessoaEndereco = A3PessoaEndereco;
            Z4PessoaTelefone = A4PessoaTelefone;
            Z5PessoaEmail = A5PessoaEmail;
            Z6PessoaSexo = A6PessoaSexo;
         }
      }

      protected void standaloneNotModal( )
      {
         edtPessoaId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPessoaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPessoaId_Enabled), 5, 0)), true);
         edtPessoaId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPessoaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPessoaId_Enabled), 5, 0)), true);
         bttBtntrn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7PessoaId) )
         {
            A1PessoaId = AV7PessoaId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1PessoaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1PessoaId), 4, 0)));
         }
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            A7PessoaSituacao = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7PessoaSituacao", A7PessoaSituacao);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtntrn_enter_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_enter_Enabled), 5, 0)), true);
         }
         else
         {
            bttBtntrn_enter_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_enter_Enabled), 5, 0)), true);
         }
      }

      protected void Load011( )
      {
         /* Using cursor T00014 */
         pr_default.execute(2, new Object[] {A1PessoaId});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound1 = 1;
            A7PessoaSituacao = T00014_A7PessoaSituacao[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7PessoaSituacao", A7PessoaSituacao);
            A2PessoaNome = T00014_A2PessoaNome[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2PessoaNome", A2PessoaNome);
            A3PessoaEndereco = T00014_A3PessoaEndereco[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3PessoaEndereco", A3PessoaEndereco);
            A4PessoaTelefone = T00014_A4PessoaTelefone[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4PessoaTelefone", A4PessoaTelefone);
            A5PessoaEmail = T00014_A5PessoaEmail[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5PessoaEmail", A5PessoaEmail);
            A6PessoaSexo = T00014_A6PessoaSexo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6PessoaSexo", A6PessoaSexo);
            ZM011( -7) ;
         }
         pr_default.close(2);
         OnLoadActions011( ) ;
      }

      protected void OnLoadActions011( )
      {
      }

      protected void CheckExtendedTable011( )
      {
         nIsDirty_1 = 0;
         Gx_BScreen = 1;
         standaloneModal( ) ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A2PessoaNome)) )
         {
            GX_msglist.addItem("Nome é obrigatório.", 1, "PESSOANOME");
            AnyError = 1;
            GX_FocusControl = edtPessoaNome_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A5PessoaEmail)) )
         {
            GX_msglist.addItem("E-mail é obrigatório.", 1, "PESSOAEMAIL");
            AnyError = 1;
            GX_FocusControl = edtPessoaEmail_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( ( StringUtil.StrCmp(A6PessoaSexo, "M") == 0 ) || ( StringUtil.StrCmp(A6PessoaSexo, "F") == 0 ) || ( StringUtil.StrCmp(A6PessoaSexo, "O") == 0 ) ) )
         {
            GX_msglist.addItem("Campo Sexo fora do intervalo", "OutOfRange", 1, "PESSOASEXO");
            AnyError = 1;
            GX_FocusControl = cmbPessoaSexo_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors011( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey011( )
      {
         /* Using cursor T00015 */
         pr_default.execute(3, new Object[] {A1PessoaId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound1 = 1;
         }
         else
         {
            RcdFound1 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00013 */
         pr_default.execute(1, new Object[] {A1PessoaId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM011( 7) ;
            RcdFound1 = 1;
            A1PessoaId = T00013_A1PessoaId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1PessoaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1PessoaId), 4, 0)));
            A7PessoaSituacao = T00013_A7PessoaSituacao[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7PessoaSituacao", A7PessoaSituacao);
            A2PessoaNome = T00013_A2PessoaNome[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2PessoaNome", A2PessoaNome);
            A3PessoaEndereco = T00013_A3PessoaEndereco[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3PessoaEndereco", A3PessoaEndereco);
            A4PessoaTelefone = T00013_A4PessoaTelefone[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4PessoaTelefone", A4PessoaTelefone);
            A5PessoaEmail = T00013_A5PessoaEmail[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5PessoaEmail", A5PessoaEmail);
            A6PessoaSexo = T00013_A6PessoaSexo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6PessoaSexo", A6PessoaSexo);
            Z1PessoaId = A1PessoaId;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load011( ) ;
            if ( AnyError == 1 )
            {
               RcdFound1 = 0;
               InitializeNonKey011( ) ;
            }
            Gx_mode = sMode1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound1 = 0;
            InitializeNonKey011( ) ;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey011( ) ;
         if ( RcdFound1 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound1 = 0;
         /* Using cursor T00016 */
         pr_default.execute(4, new Object[] {A1PessoaId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T00016_A1PessoaId[0] < A1PessoaId ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T00016_A1PessoaId[0] > A1PessoaId ) ) )
            {
               A1PessoaId = T00016_A1PessoaId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1PessoaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1PessoaId), 4, 0)));
               RcdFound1 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound1 = 0;
         /* Using cursor T00017 */
         pr_default.execute(5, new Object[] {A1PessoaId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T00017_A1PessoaId[0] > A1PessoaId ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T00017_A1PessoaId[0] < A1PessoaId ) ) )
            {
               A1PessoaId = T00017_A1PessoaId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1PessoaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1PessoaId), 4, 0)));
               RcdFound1 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey011( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtPessoaNome_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert011( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound1 == 1 )
            {
               if ( A1PessoaId != Z1PessoaId )
               {
                  A1PessoaId = Z1PessoaId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1PessoaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1PessoaId), 4, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "PESSOAID");
                  AnyError = 1;
                  GX_FocusControl = edtPessoaId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtPessoaNome_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update011( ) ;
                  GX_FocusControl = edtPessoaNome_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A1PessoaId != Z1PessoaId )
               {
                  /* Insert record */
                  GX_FocusControl = edtPessoaNome_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert011( ) ;
                  if ( AnyError == 1 )
                  {
                     GX_FocusControl = "";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "PESSOAID");
                     AnyError = 1;
                     GX_FocusControl = edtPessoaId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtPessoaNome_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert011( ) ;
                     if ( AnyError == 1 )
                     {
                        GX_FocusControl = "";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            if ( AnyError == 0 )
            {
               context.nUserReturn = 1;
            }
         }
      }

      protected void btn_delete( )
      {
         if ( A1PessoaId != Z1PessoaId )
         {
            A1PessoaId = Z1PessoaId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1PessoaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1PessoaId), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "PESSOAID");
            AnyError = 1;
            GX_FocusControl = edtPessoaId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtPessoaNome_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency011( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00012 */
            pr_default.execute(0, new Object[] {A1PessoaId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Pessoa"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( Z7PessoaSituacao != T00012_A7PessoaSituacao[0] ) || ( StringUtil.StrCmp(Z2PessoaNome, T00012_A2PessoaNome[0]) != 0 ) || ( StringUtil.StrCmp(Z3PessoaEndereco, T00012_A3PessoaEndereco[0]) != 0 ) || ( StringUtil.StrCmp(Z4PessoaTelefone, T00012_A4PessoaTelefone[0]) != 0 ) || ( StringUtil.StrCmp(Z5PessoaEmail, T00012_A5PessoaEmail[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z6PessoaSexo, T00012_A6PessoaSexo[0]) != 0 ) )
            {
               if ( Z7PessoaSituacao != T00012_A7PessoaSituacao[0] )
               {
                  GXUtil.WriteLog("pessoa:[seudo value changed for attri]"+"PessoaSituacao");
                  GXUtil.WriteLogRaw("Old: ",Z7PessoaSituacao);
                  GXUtil.WriteLogRaw("Current: ",T00012_A7PessoaSituacao[0]);
               }
               if ( StringUtil.StrCmp(Z2PessoaNome, T00012_A2PessoaNome[0]) != 0 )
               {
                  GXUtil.WriteLog("pessoa:[seudo value changed for attri]"+"PessoaNome");
                  GXUtil.WriteLogRaw("Old: ",Z2PessoaNome);
                  GXUtil.WriteLogRaw("Current: ",T00012_A2PessoaNome[0]);
               }
               if ( StringUtil.StrCmp(Z3PessoaEndereco, T00012_A3PessoaEndereco[0]) != 0 )
               {
                  GXUtil.WriteLog("pessoa:[seudo value changed for attri]"+"PessoaEndereco");
                  GXUtil.WriteLogRaw("Old: ",Z3PessoaEndereco);
                  GXUtil.WriteLogRaw("Current: ",T00012_A3PessoaEndereco[0]);
               }
               if ( StringUtil.StrCmp(Z4PessoaTelefone, T00012_A4PessoaTelefone[0]) != 0 )
               {
                  GXUtil.WriteLog("pessoa:[seudo value changed for attri]"+"PessoaTelefone");
                  GXUtil.WriteLogRaw("Old: ",Z4PessoaTelefone);
                  GXUtil.WriteLogRaw("Current: ",T00012_A4PessoaTelefone[0]);
               }
               if ( StringUtil.StrCmp(Z5PessoaEmail, T00012_A5PessoaEmail[0]) != 0 )
               {
                  GXUtil.WriteLog("pessoa:[seudo value changed for attri]"+"PessoaEmail");
                  GXUtil.WriteLogRaw("Old: ",Z5PessoaEmail);
                  GXUtil.WriteLogRaw("Current: ",T00012_A5PessoaEmail[0]);
               }
               if ( StringUtil.StrCmp(Z6PessoaSexo, T00012_A6PessoaSexo[0]) != 0 )
               {
                  GXUtil.WriteLog("pessoa:[seudo value changed for attri]"+"PessoaSexo");
                  GXUtil.WriteLogRaw("Old: ",Z6PessoaSexo);
                  GXUtil.WriteLogRaw("Current: ",T00012_A6PessoaSexo[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Pessoa"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert011( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable011( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM011( 0) ;
            CheckOptimisticConcurrency011( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm011( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert011( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00018 */
                     pr_default.execute(6, new Object[] {A7PessoaSituacao, A2PessoaNome, A3PessoaEndereco, A4PessoaTelefone, A5PessoaEmail, A6PessoaSexo});
                     A1PessoaId = T00018_A1PessoaId[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1PessoaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1PessoaId), 4, 0)));
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("Pessoa") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption010( ) ;
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load011( ) ;
            }
            EndLevel011( ) ;
         }
         CloseExtendedTableCursors011( ) ;
      }

      protected void Update011( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable011( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency011( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm011( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate011( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00019 */
                     pr_default.execute(7, new Object[] {A7PessoaSituacao, A2PessoaNome, A3PessoaEndereco, A4PessoaTelefone, A5PessoaEmail, A6PessoaSexo, A1PessoaId});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("Pessoa") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Pessoa"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate011( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                           {
                              if ( AnyError == 0 )
                              {
                                 context.nUserReturn = 1;
                              }
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel011( ) ;
         }
         CloseExtendedTableCursors011( ) ;
      }

      protected void DeferredUpdate011( )
      {
      }

      protected void delete( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency011( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls011( ) ;
            AfterConfirm011( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete011( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000110 */
                  pr_default.execute(8, new Object[] {A1PessoaId});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("Pessoa") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                        {
                           if ( AnyError == 0 )
                           {
                              context.nUserReturn = 1;
                           }
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode1 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel011( ) ;
         Gx_mode = sMode1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls011( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000111 */
            pr_default.execute(9, new Object[] {A1PessoaId});
            if ( (pr_default.getStatus(9) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Pedido"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(9);
         }
      }

      protected void EndLevel011( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete011( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            context.CommitDataStores("pessoa",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues010( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("pessoa",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart011( )
      {
         /* Scan By routine */
         /* Using cursor T000112 */
         pr_default.execute(10);
         RcdFound1 = 0;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound1 = 1;
            A1PessoaId = T000112_A1PessoaId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1PessoaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1PessoaId), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext011( )
      {
         /* Scan next routine */
         pr_default.readNext(10);
         RcdFound1 = 0;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound1 = 1;
            A1PessoaId = T000112_A1PessoaId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1PessoaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1PessoaId), 4, 0)));
         }
      }

      protected void ScanEnd011( )
      {
         pr_default.close(10);
      }

      protected void AfterConfirm011( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert011( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate011( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete011( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete011( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate011( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes011( )
      {
         edtPessoaId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPessoaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPessoaId_Enabled), 5, 0)), true);
         edtPessoaNome_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPessoaNome_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPessoaNome_Enabled), 5, 0)), true);
         edtPessoaEndereco_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPessoaEndereco_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPessoaEndereco_Enabled), 5, 0)), true);
         edtPessoaTelefone_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPessoaTelefone_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPessoaTelefone_Enabled), 5, 0)), true);
         edtPessoaEmail_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPessoaEmail_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPessoaEmail_Enabled), 5, 0)), true);
         cmbPessoaSexo.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPessoaSexo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbPessoaSexo.Enabled), 5, 0)), true);
         chkPessoaSituacao.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkPessoaSituacao_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkPessoaSituacao.Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes011( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues010( )
      {
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
         MasterPageObj.master_styles();
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 131213), false, true);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 131213), false, true);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 131213), false, true);
         context.AddJavascriptSource("gxcfg.js", "?201971216322287", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false, true);
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("pessoa.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7PessoaId)+"\">") ;
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
         forbiddenHiddens = "hsh" + "Pessoa";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A1PessoaId), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("pessoa:[SendSecurityCheck value for]"+"PessoaId:"+context.localUtil.Format( (decimal)(A1PessoaId), "ZZZ9"));
         GXUtil.WriteLog("pessoa:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z1PessoaId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1PessoaId), 4, 0, ",", "")));
         GxWebStd.gx_boolean_hidden_field( context, "Z7PessoaSituacao", Z7PessoaSituacao);
         GxWebStd.gx_hidden_field( context, "Z2PessoaNome", Z2PessoaNome);
         GxWebStd.gx_hidden_field( context, "Z3PessoaEndereco", Z3PessoaEndereco);
         GxWebStd.gx_hidden_field( context, "Z4PessoaTelefone", Z4PessoaTelefone);
         GxWebStd.gx_hidden_field( context, "Z5PessoaEmail", Z5PessoaEmail);
         GxWebStd.gx_hidden_field( context, "Z6PessoaSexo", StringUtil.RTrim( Z6PessoaSexo));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV9TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vPESSOAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7PessoaId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vPESSOAID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7PessoaId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Objectcall", StringUtil.RTrim( Dvpanel_tableattributes_Objectcall));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Enabled", StringUtil.BoolToStr( Dvpanel_tableattributes_Enabled));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Width", StringUtil.RTrim( Dvpanel_tableattributes_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Cls", StringUtil.RTrim( Dvpanel_tableattributes_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Title", StringUtil.RTrim( Dvpanel_tableattributes_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Collapsible", StringUtil.BoolToStr( Dvpanel_tableattributes_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Collapsed", StringUtil.BoolToStr( Dvpanel_tableattributes_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Autowidth", StringUtil.BoolToStr( Dvpanel_tableattributes_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Autoheight", StringUtil.BoolToStr( Dvpanel_tableattributes_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_tableattributes_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Iconposition", StringUtil.RTrim( Dvpanel_tableattributes_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Autoscroll", StringUtil.BoolToStr( Dvpanel_tableattributes_Autoscroll));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken(sPrefix);
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

      public override short ExecuteStartEvent( )
      {
         standaloneStartup( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         return gxajaxcallmode ;
      }

      public override void RenderHtmlContent( )
      {
         context.WriteHtmlText( "<div") ;
         GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
         context.WriteHtmlText( ">") ;
         Draw( ) ;
         context.WriteHtmlText( "</div>") ;
      }

      public override void DispatchEvents( )
      {
         Process( ) ;
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
         return formatLink("pessoa.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7PessoaId) ;
      }

      public override String GetPgmname( )
      {
         return "Pessoa" ;
      }

      public override String GetPgmdesc( )
      {
         return "Pessoa" ;
      }

      protected void InitializeNonKey011( )
      {
         A7PessoaSituacao = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7PessoaSituacao", A7PessoaSituacao);
         A2PessoaNome = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2PessoaNome", A2PessoaNome);
         A3PessoaEndereco = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3PessoaEndereco", A3PessoaEndereco);
         A4PessoaTelefone = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4PessoaTelefone", A4PessoaTelefone);
         A5PessoaEmail = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5PessoaEmail", A5PessoaEmail);
         A6PessoaSexo = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6PessoaSexo", A6PessoaSexo);
         Z7PessoaSituacao = false;
         Z2PessoaNome = "";
         Z3PessoaEndereco = "";
         Z4PessoaTelefone = "";
         Z5PessoaEmail = "";
         Z6PessoaSexo = "";
      }

      protected void InitAll011( )
      {
         A1PessoaId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1PessoaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1PessoaId), 4, 0)));
         InitializeNonKey011( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20197121632235", true, true);
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
         context.AddJavascriptSource("pessoa.js", "?20197121632235", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false, true);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false, true);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         edtPessoaId_Internalname = "PESSOAID";
         edtPessoaNome_Internalname = "PESSOANOME";
         edtPessoaEndereco_Internalname = "PESSOAENDERECO";
         edtPessoaTelefone_Internalname = "PESSOATELEFONE";
         edtPessoaEmail_Internalname = "PESSOAEMAIL";
         cmbPessoaSexo_Internalname = "PESSOASEXO";
         lblTextblockpessoasituacao_Internalname = "TEXTBLOCKPESSOASITUACAO";
         chkPessoaSituacao_Internalname = "PESSOASITUACAO";
         lblPessoasituacao_righttext_Internalname = "PESSOASITUACAO_RIGHTTEXT";
         tblTablemergedpessoasituacao_Internalname = "TABLEMERGEDPESSOASITUACAO";
         divTablesplittedpessoasituacao_Internalname = "TABLESPLITTEDPESSOASITUACAO";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtntrn_enter_Internalname = "BTNTRN_ENTER";
         bttBtntrn_cancel_Internalname = "BTNTRN_CANCEL";
         bttBtntrn_delete_Internalname = "BTNTRN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         divLayoutmaintable_Internalname = "LAYOUTMAINTABLE";
         Form.Internalname = "FORM";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Pessoa";
         chkPessoaSituacao.TooltipText = "";
         chkPessoaSituacao.Enabled = 1;
         bttBtntrn_delete_Enabled = 0;
         bttBtntrn_delete_Visible = 1;
         bttBtntrn_cancel_Visible = 1;
         bttBtntrn_enter_Enabled = 1;
         bttBtntrn_enter_Visible = 1;
         cmbPessoaSexo_Jsonclick = "";
         cmbPessoaSexo.Enabled = 1;
         edtPessoaEmail_Jsonclick = "";
         edtPessoaEmail_Enabled = 1;
         edtPessoaTelefone_Jsonclick = "";
         edtPessoaTelefone_Enabled = 1;
         edtPessoaEndereco_Enabled = 1;
         edtPessoaNome_Jsonclick = "";
         edtPessoaNome_Enabled = 1;
         edtPessoaId_Jsonclick = "";
         edtPessoaId_Enabled = 0;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "Right";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "Informações Gerais";
         Dvpanel_tableattributes_Cls = "PanelCard_BaseColor";
         Dvpanel_tableattributes_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableattributes_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Width = "100%";
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void init_web_controls( )
      {
         cmbPessoaSexo.Name = "PESSOASEXO";
         cmbPessoaSexo.WebTags = "";
         cmbPessoaSexo.addItem("M", "Masculino", 0);
         cmbPessoaSexo.addItem("F", "Feminino", 0);
         cmbPessoaSexo.addItem("O", "Outros", 0);
         if ( cmbPessoaSexo.ItemCount > 0 )
         {
            A6PessoaSexo = cmbPessoaSexo.getValidValue(A6PessoaSexo);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6PessoaSexo", A6PessoaSexo);
         }
         chkPessoaSituacao.Name = "PESSOASITUACAO";
         chkPessoaSituacao.WebTags = "";
         chkPessoaSituacao.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkPessoaSituacao_Internalname, "TitleCaption", chkPessoaSituacao.Caption, true);
         chkPessoaSituacao.CheckedValue = "false";
         /* End function init_web_controls */
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7PessoaId',fld:'vPESSOAID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7PessoaId',fld:'vPESSOAID',pic:'ZZZ9',hsh:true},{av:'A1PessoaId',fld:'PESSOAID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12012',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:''}]");
         setEventMetadata("AFTER TRN",",oparms:[]}");
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
         pr_default.close(1);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z2PessoaNome = "";
         Z3PessoaEndereco = "";
         Z4PessoaTelefone = "";
         Z5PessoaEmail = "";
         Z6PessoaSexo = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         A6PessoaSexo = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         TempTags = "";
         A2PessoaNome = "";
         A3PessoaEndereco = "";
         A4PessoaTelefone = "";
         A5PessoaEmail = "";
         lblTextblockpessoasituacao_Jsonclick = "";
         bttBtntrn_enter_Jsonclick = "";
         bttBtntrn_cancel_Jsonclick = "";
         bttBtntrn_delete_Jsonclick = "";
         sStyleString = "";
         lblPessoasituacao_righttext_Jsonclick = "";
         Dvpanel_tableattributes_Objectcall = "";
         Dvpanel_tableattributes_Class = "";
         Dvpanel_tableattributes_Height = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode1 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV8WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV10WebSession = context.GetSession();
         T00014_A1PessoaId = new short[1] ;
         T00014_A7PessoaSituacao = new bool[] {false} ;
         T00014_A2PessoaNome = new String[] {""} ;
         T00014_A3PessoaEndereco = new String[] {""} ;
         T00014_A4PessoaTelefone = new String[] {""} ;
         T00014_A5PessoaEmail = new String[] {""} ;
         T00014_A6PessoaSexo = new String[] {""} ;
         T00015_A1PessoaId = new short[1] ;
         T00013_A1PessoaId = new short[1] ;
         T00013_A7PessoaSituacao = new bool[] {false} ;
         T00013_A2PessoaNome = new String[] {""} ;
         T00013_A3PessoaEndereco = new String[] {""} ;
         T00013_A4PessoaTelefone = new String[] {""} ;
         T00013_A5PessoaEmail = new String[] {""} ;
         T00013_A6PessoaSexo = new String[] {""} ;
         T00016_A1PessoaId = new short[1] ;
         T00017_A1PessoaId = new short[1] ;
         T00012_A1PessoaId = new short[1] ;
         T00012_A7PessoaSituacao = new bool[] {false} ;
         T00012_A2PessoaNome = new String[] {""} ;
         T00012_A3PessoaEndereco = new String[] {""} ;
         T00012_A4PessoaTelefone = new String[] {""} ;
         T00012_A5PessoaEmail = new String[] {""} ;
         T00012_A6PessoaSexo = new String[] {""} ;
         T00018_A1PessoaId = new short[1] ;
         T000111_A32PedidoId = new short[1] ;
         T000112_A1PessoaId = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pessoa__default(),
            new Object[][] {
                new Object[] {
               T00012_A1PessoaId, T00012_A7PessoaSituacao, T00012_A2PessoaNome, T00012_A3PessoaEndereco, T00012_A4PessoaTelefone, T00012_A5PessoaEmail, T00012_A6PessoaSexo
               }
               , new Object[] {
               T00013_A1PessoaId, T00013_A7PessoaSituacao, T00013_A2PessoaNome, T00013_A3PessoaEndereco, T00013_A4PessoaTelefone, T00013_A5PessoaEmail, T00013_A6PessoaSexo
               }
               , new Object[] {
               T00014_A1PessoaId, T00014_A7PessoaSituacao, T00014_A2PessoaNome, T00014_A3PessoaEndereco, T00014_A4PessoaTelefone, T00014_A5PessoaEmail, T00014_A6PessoaSexo
               }
               , new Object[] {
               T00015_A1PessoaId
               }
               , new Object[] {
               T00016_A1PessoaId
               }
               , new Object[] {
               T00017_A1PessoaId
               }
               , new Object[] {
               T00018_A1PessoaId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000111_A32PedidoId
               }
               , new Object[] {
               T000112_A1PessoaId
               }
            }
         );
      }

      private short wcpOAV7PessoaId ;
      private short Z1PessoaId ;
      private short GxWebError ;
      private short AV7PessoaId ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A1PessoaId ;
      private short RcdFound1 ;
      private short GX_JID ;
      private short nIsDirty_1 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int edtPessoaId_Enabled ;
      private int edtPessoaNome_Enabled ;
      private int edtPessoaEndereco_Enabled ;
      private int edtPessoaTelefone_Enabled ;
      private int edtPessoaEmail_Enabled ;
      private int bttBtntrn_enter_Visible ;
      private int bttBtntrn_enter_Enabled ;
      private int bttBtntrn_cancel_Visible ;
      private int bttBtntrn_delete_Visible ;
      private int bttBtntrn_delete_Enabled ;
      private int Dvpanel_tableattributes_Gxcontroltype ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String Z6PessoaSexo ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtPessoaNome_Internalname ;
      private String A6PessoaSexo ;
      private String cmbPessoaSexo_Internalname ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divTablecontent_Internalname ;
      private String Dvpanel_tableattributes_Width ;
      private String Dvpanel_tableattributes_Cls ;
      private String Dvpanel_tableattributes_Title ;
      private String Dvpanel_tableattributes_Iconposition ;
      private String Dvpanel_tableattributes_Internalname ;
      private String divTableattributes_Internalname ;
      private String edtPessoaId_Internalname ;
      private String edtPessoaId_Jsonclick ;
      private String TempTags ;
      private String edtPessoaNome_Jsonclick ;
      private String edtPessoaEndereco_Internalname ;
      private String edtPessoaTelefone_Internalname ;
      private String edtPessoaTelefone_Jsonclick ;
      private String edtPessoaEmail_Internalname ;
      private String edtPessoaEmail_Jsonclick ;
      private String cmbPessoaSexo_Jsonclick ;
      private String divTablesplittedpessoasituacao_Internalname ;
      private String lblTextblockpessoasituacao_Internalname ;
      private String lblTextblockpessoasituacao_Jsonclick ;
      private String bttBtntrn_enter_Internalname ;
      private String bttBtntrn_enter_Jsonclick ;
      private String bttBtntrn_cancel_Internalname ;
      private String bttBtntrn_cancel_Jsonclick ;
      private String bttBtntrn_delete_Internalname ;
      private String bttBtntrn_delete_Jsonclick ;
      private String sStyleString ;
      private String tblTablemergedpessoasituacao_Internalname ;
      private String chkPessoaSituacao_Internalname ;
      private String lblPessoasituacao_righttext_Internalname ;
      private String lblPessoasituacao_righttext_Jsonclick ;
      private String Dvpanel_tableattributes_Objectcall ;
      private String Dvpanel_tableattributes_Class ;
      private String Dvpanel_tableattributes_Height ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode1 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private bool Z7PessoaSituacao ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool A7PessoaSituacao ;
      private bool Dvpanel_tableattributes_Enabled ;
      private bool Dvpanel_tableattributes_Showheader ;
      private bool Dvpanel_tableattributes_Visible ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private String Z2PessoaNome ;
      private String Z3PessoaEndereco ;
      private String Z4PessoaTelefone ;
      private String Z5PessoaEmail ;
      private String A2PessoaNome ;
      private String A3PessoaEndereco ;
      private String A4PessoaTelefone ;
      private String A5PessoaEmail ;
      private IGxSession AV10WebSession ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbPessoaSexo ;
      private GXCheckbox chkPessoaSituacao ;
      private IDataStoreProvider pr_default ;
      private short[] T00014_A1PessoaId ;
      private bool[] T00014_A7PessoaSituacao ;
      private String[] T00014_A2PessoaNome ;
      private String[] T00014_A3PessoaEndereco ;
      private String[] T00014_A4PessoaTelefone ;
      private String[] T00014_A5PessoaEmail ;
      private String[] T00014_A6PessoaSexo ;
      private short[] T00015_A1PessoaId ;
      private short[] T00013_A1PessoaId ;
      private bool[] T00013_A7PessoaSituacao ;
      private String[] T00013_A2PessoaNome ;
      private String[] T00013_A3PessoaEndereco ;
      private String[] T00013_A4PessoaTelefone ;
      private String[] T00013_A5PessoaEmail ;
      private String[] T00013_A6PessoaSexo ;
      private short[] T00016_A1PessoaId ;
      private short[] T00017_A1PessoaId ;
      private short[] T00012_A1PessoaId ;
      private bool[] T00012_A7PessoaSituacao ;
      private String[] T00012_A2PessoaNome ;
      private String[] T00012_A3PessoaEndereco ;
      private String[] T00012_A4PessoaTelefone ;
      private String[] T00012_A5PessoaEmail ;
      private String[] T00012_A6PessoaSexo ;
      private short[] T00018_A1PessoaId ;
      private short[] T000111_A32PedidoId ;
      private short[] T000112_A1PessoaId ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
   }

   public class pessoa__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new UpdateCursor(def[7])
         ,new UpdateCursor(def[8])
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00014 ;
          prmT00014 = new Object[] {
          new Object[] {"@PessoaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00015 ;
          prmT00015 = new Object[] {
          new Object[] {"@PessoaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00013 ;
          prmT00013 = new Object[] {
          new Object[] {"@PessoaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00016 ;
          prmT00016 = new Object[] {
          new Object[] {"@PessoaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00017 ;
          prmT00017 = new Object[] {
          new Object[] {"@PessoaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00012 ;
          prmT00012 = new Object[] {
          new Object[] {"@PessoaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00018 ;
          prmT00018 = new Object[] {
          new Object[] {"@PessoaSituacao",SqlDbType.Bit,4,0} ,
          new Object[] {"@PessoaNome",SqlDbType.VarChar,60,0} ,
          new Object[] {"@PessoaEndereco",SqlDbType.VarChar,500,0} ,
          new Object[] {"@PessoaTelefone",SqlDbType.VarChar,11,0} ,
          new Object[] {"@PessoaEmail",SqlDbType.VarChar,50,0} ,
          new Object[] {"@PessoaSexo",SqlDbType.Char,1,0}
          } ;
          Object[] prmT00019 ;
          prmT00019 = new Object[] {
          new Object[] {"@PessoaSituacao",SqlDbType.Bit,4,0} ,
          new Object[] {"@PessoaNome",SqlDbType.VarChar,60,0} ,
          new Object[] {"@PessoaEndereco",SqlDbType.VarChar,500,0} ,
          new Object[] {"@PessoaTelefone",SqlDbType.VarChar,11,0} ,
          new Object[] {"@PessoaEmail",SqlDbType.VarChar,50,0} ,
          new Object[] {"@PessoaSexo",SqlDbType.Char,1,0} ,
          new Object[] {"@PessoaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000110 ;
          prmT000110 = new Object[] {
          new Object[] {"@PessoaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000111 ;
          prmT000111 = new Object[] {
          new Object[] {"@PessoaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000112 ;
          prmT000112 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T00012", "SELECT [PessoaId], [PessoaSituacao], [PessoaNome], [PessoaEndereco], [PessoaTelefone], [PessoaEmail], [PessoaSexo] FROM [Pessoa] WITH (UPDLOCK) WHERE [PessoaId] = @PessoaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00012,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00013", "SELECT [PessoaId], [PessoaSituacao], [PessoaNome], [PessoaEndereco], [PessoaTelefone], [PessoaEmail], [PessoaSexo] FROM [Pessoa] WHERE [PessoaId] = @PessoaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00013,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00014", "SELECT TM1.[PessoaId], TM1.[PessoaSituacao], TM1.[PessoaNome], TM1.[PessoaEndereco], TM1.[PessoaTelefone], TM1.[PessoaEmail], TM1.[PessoaSexo] FROM [Pessoa] TM1 WHERE TM1.[PessoaId] = @PessoaId ORDER BY TM1.[PessoaId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00014,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00015", "SELECT [PessoaId] FROM [Pessoa] WHERE [PessoaId] = @PessoaId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00015,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00016", "SELECT TOP 1 [PessoaId] FROM [Pessoa] WHERE ( [PessoaId] > @PessoaId) ORDER BY [PessoaId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00016,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T00017", "SELECT TOP 1 [PessoaId] FROM [Pessoa] WHERE ( [PessoaId] < @PessoaId) ORDER BY [PessoaId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00017,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T00018", "INSERT INTO [Pessoa]([PessoaSituacao], [PessoaNome], [PessoaEndereco], [PessoaTelefone], [PessoaEmail], [PessoaSexo]) VALUES(@PessoaSituacao, @PessoaNome, @PessoaEndereco, @PessoaTelefone, @PessoaEmail, @PessoaSexo); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT00018)
             ,new CursorDef("T00019", "UPDATE [Pessoa] SET [PessoaSituacao]=@PessoaSituacao, [PessoaNome]=@PessoaNome, [PessoaEndereco]=@PessoaEndereco, [PessoaTelefone]=@PessoaTelefone, [PessoaEmail]=@PessoaEmail, [PessoaSexo]=@PessoaSexo  WHERE [PessoaId] = @PessoaId", GxErrorMask.GX_NOMASK,prmT00019)
             ,new CursorDef("T000110", "DELETE FROM [Pessoa]  WHERE [PessoaId] = @PessoaId", GxErrorMask.GX_NOMASK,prmT000110)
             ,new CursorDef("T000111", "SELECT TOP 1 [PedidoId] FROM [Pedido] WHERE [PessoaId] = @PessoaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000111,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000112", "SELECT [PessoaId] FROM [Pessoa] ORDER BY [PessoaId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000112,100, GxCacheFrequency.OFF ,true,false )
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
                ((bool[]) buf[1])[0] = rslt.getBool(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 1) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((bool[]) buf[1])[0] = rslt.getBool(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 1) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((bool[]) buf[1])[0] = rslt.getBool(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 1) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 10 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (bool)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                return;
             case 7 :
                stmt.SetParameter(1, (bool)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
