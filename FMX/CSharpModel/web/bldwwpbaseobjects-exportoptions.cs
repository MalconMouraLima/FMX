using System;
using GeneXus.Builder;
using System.IO;
public class bldwwpbaseobjects_exportoptions : GxBaseBuilder
{
   string cs_path = "." ;
   public bldwwpbaseobjects_exportoptions( ) : base()
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
      return ErrCode ;
   }

   static public int Main( string[] args )
   {
      bldwwpbaseobjects_exportoptions x = new bldwwpbaseobjects_exportoptions() ;
      x.SetMainSourceFile( "wwpbaseobjects\\exportoptions.cs");
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
      sc.Add( @"wwpbaseobjects\exportoptions", "dll");
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

