using System;
using GeneXus.Builder;
using System.IO;
public class bldDevelopermenu : GxBaseBuilder
{
   string cs_path = "." ;
   public bldDevelopermenu( ) : base()
   {
   }

   public override int BeforeCompile( )
   {
      return 0 ;
   }

   public override int AfterCompile( )
   {
      int ErrCode ;
      ErrCode = 0;
      if ( ! File.Exists(@"bin\client.exe.config") || checkTime(@"bin\client.exe.config",cs_path + @"\client.exe.config") )
      {
         File.Copy( cs_path + @"\client.exe.config", @"bin\client.exe.config", true);
      }
      return ErrCode ;
   }

   static public int Main( string[] args )
   {
      bldDevelopermenu x = new bldDevelopermenu() ;
      x.SetMainSourceFile( "bldDevelopermenu.cs");
      x.LoadVariables( args);
      return x.CompileAll( );
   }

   public override ItemCollection GetSortedBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\GeneXus.Programs.Common.dll", cs_path + @"\genexus.programs.common.rsp");
      return sc ;
   }

   public override TargetCollection GetRuntimeBuildList( )
   {
      TargetCollection sc = new TargetCollection() ;
      sc.Add( @"pessoawwgetfilterdata", "dll");
      sc.Add( @"produtowwgetfilterdata", "dll");
      sc.Add( @"wp_gerenciarpedidogetfilterdata", "dll");
      sc.Add( @"pedidowwgetfilterdata", "dll");
      sc.Add( @"appmasterpage", "dll");
      sc.Add( @"recentlinks", "dll");
      sc.Add( @"promptmasterpage", "dll");
      sc.Add( @"rwdmasterpage", "dll");
      sc.Add( @"rwdrecentlinks", "dll");
      sc.Add( @"rwdpromptmasterpage", "dll");
      sc.Add( @"wwpbaseobjects\wizardstepsarrowwc", "dll");
      sc.Add( @"wwpbaseobjects\wizardstepsbulletwc", "dll");
      sc.Add( @"wwpbaseobjects\addressdisplay", "dll");
      sc.Add( @"wwpbaseobjects\exportoptions", "dll");
      sc.Add( @"wwpbaseobjects\exportoptions", "dll");
      sc.Add( @"wwpbaseobjects\home", "dll");
      sc.Add( @"wwpbaseobjects\home", "dll");
      sc.Add( @"wwpbaseobjects\managefilters", "dll");
      sc.Add( @"wwpbaseobjects\promptgeolocation", "dll");
      sc.Add( @"wwpbaseobjects\savefilteras", "dll");
      sc.Add( @"wwpbaseobjects\wwptabbedview", "dll");
      sc.Add( @"wwpbaseobjects\notauthorized", "dll");
      sc.Add( @"wwpbaseobjects\homeprogressbarcirclewc", "dll");
      sc.Add( @"wwpbaseobjects\homeprogressbarwc", "dll");
      sc.Add( @"wwpbaseobjects\masterpageframe", "dll");
      sc.Add( @"wwpbaseobjects\workwithplusmasterpageprompt", "dll");
      sc.Add( @"wwpbaseobjects\workwithplusmasterpage", "dll");
      sc.Add( @"pessoaww", "dll");
      sc.Add( @"pessoaprompt", "dll");
      sc.Add( @"pessoageneral", "dll");
      sc.Add( @"pessoaview", "dll");
      sc.Add( @"produtoview", "dll");
      sc.Add( @"produtoww", "dll");
      sc.Add( @"produtoprompt", "dll");
      sc.Add( @"produtogeneral", "dll");
      sc.Add( @"parametroview", "dll");
      sc.Add( @"parametroww", "dll");
      sc.Add( @"parametroprompt", "dll");
      sc.Add( @"parametrogeneral", "dll");
      sc.Add( @"pedidoview", "dll");
      sc.Add( @"pedidoww", "dll");
      sc.Add( @"pedidoprompt", "dll");
      sc.Add( @"pedidoitemprompt", "dll");
      sc.Add( @"pedidogeneral", "dll");
      sc.Add( @"pedidoitemwc", "dll");
      sc.Add( @"pessoa", "dll");
      sc.Add( @"produto", "dll");
      sc.Add( @"parametro", "dll");
      sc.Add( @"pedido", "dll");
      return sc ;
   }

   public override ItemCollection GetResBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\messages.por.dll", cs_path + @"\messages.por.txt");
      return sc ;
   }

   public override bool ToBuild( String obj )
   {
      if (checkTime(obj, cs_path + @"\bin\GxClasses.dll" ))
         return true;
      if ( obj == @"bin\GeneXus.Programs.Common.dll" )
      {
         if (checkTime(obj, cs_path + @"\GxWebStd.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\SoapParm.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxObjectCollection.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxFullTextSearchReindexer.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxModelInfoProvider.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\genexus.programs.sdt.rsp" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainsexo.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainwwpdomains.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainpage.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainexporttype.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wwpbaseobjects\gxdomainsplitscreen_action.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainhomesampledatastatus.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainwwpcardsmenusize.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wwpbaseobjects\gxdomainwwpcardsmenuoptiontype.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomaintipoparametro.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainprioritaria.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainstatuspedido.cs" ))
            return true;
      }
      if ( obj == @"bin\messages.por.dll" )
      {
         if (checkTime(obj, cs_path + @"\messages.por.txt" ))
            return true;
      }
      return false ;
   }

}

