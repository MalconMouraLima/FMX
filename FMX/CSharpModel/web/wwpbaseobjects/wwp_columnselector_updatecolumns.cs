/*
               File: WWPBaseObjects.WWP_ColumnSelector_UpdateColumns
        Description: Column Selector - Update Columns
             Author: GeneXus C# Generator version 16_0_2-131213
       Generated on: 7/11/2019 11:24:59.47
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
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs.wwpbaseobjects {
   public class wwp_columnselector_updatecolumns : GXProcedure
   {
      public wwp_columnselector_updatecolumns( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public wwp_columnselector_updatecolumns( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( ref GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector aP0_OldColumnsSelector ,
                           ref GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector aP1_ColumnsSelector )
      {
         this.AV13OldColumnsSelector = aP0_OldColumnsSelector;
         this.AV10ColumnsSelector = aP1_ColumnsSelector;
         initialize();
         executePrivate();
         aP0_OldColumnsSelector=this.AV13OldColumnsSelector;
         aP1_ColumnsSelector=this.AV10ColumnsSelector;
      }

      public GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector executeUdp( ref GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector aP0_OldColumnsSelector )
      {
         this.AV13OldColumnsSelector = aP0_OldColumnsSelector;
         this.AV10ColumnsSelector = aP1_ColumnsSelector;
         initialize();
         executePrivate();
         aP0_OldColumnsSelector=this.AV13OldColumnsSelector;
         aP1_ColumnsSelector=this.AV10ColumnsSelector;
         return AV10ColumnsSelector ;
      }

      public void executeSubmit( ref GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector aP0_OldColumnsSelector ,
                                 ref GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector aP1_ColumnsSelector )
      {
         wwp_columnselector_updatecolumns objwwp_columnselector_updatecolumns;
         objwwp_columnselector_updatecolumns = new wwp_columnselector_updatecolumns();
         objwwp_columnselector_updatecolumns.AV13OldColumnsSelector = aP0_OldColumnsSelector;
         objwwp_columnselector_updatecolumns.AV10ColumnsSelector = aP1_ColumnsSelector;
         objwwp_columnselector_updatecolumns.context.SetSubmitInitialConfig(context);
         objwwp_columnselector_updatecolumns.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objwwp_columnselector_updatecolumns);
         aP0_OldColumnsSelector=this.AV13OldColumnsSelector;
         aP1_ColumnsSelector=this.AV10ColumnsSelector;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((wwp_columnselector_updatecolumns)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         AV16GXV1 = 1;
         while ( AV16GXV1 <= AV10ColumnsSelector.gxTpr_Columns.Count )
         {
            AV8Column = ((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV10ColumnsSelector.gxTpr_Columns.Item(AV16GXV1));
            /* Execute user subroutine: 'ISCOLUMNVISIBLE' */
            S111 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
            if ( AV11Found )
            {
               AV8Column.gxTpr_Isvisible = AV12IsColumnVisible;
            }
            AV16GXV1 = (int)(AV16GXV1+1);
         }
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'ISCOLUMNVISIBLE' Routine */
         AV11Found = false;
         AV17GXV2 = 1;
         while ( AV17GXV2 <= AV13OldColumnsSelector.gxTpr_Columns.Count )
         {
            AV9ColumnAux = ((GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column)AV13OldColumnsSelector.gxTpr_Columns.Item(AV17GXV2));
            if ( StringUtil.StrCmp(AV8Column.gxTpr_Columnname, AV9ColumnAux.gxTpr_Columnname) == 0 )
            {
               AV12IsColumnVisible = AV9ColumnAux.gxTpr_Isvisible;
               AV11Found = true;
               if (true) break;
            }
            AV17GXV2 = (int)(AV17GXV2+1);
         }
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         AV8Column = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column(context);
         AV9ColumnAux = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column(context);
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV16GXV1 ;
      private int AV17GXV2 ;
      private bool returnInSub ;
      private bool AV11Found ;
      private bool AV12IsColumnVisible ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector aP0_OldColumnsSelector ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector aP1_ColumnsSelector ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector AV13OldColumnsSelector ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector AV10ColumnsSelector ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column AV8Column ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column AV9ColumnAux ;
   }

}
