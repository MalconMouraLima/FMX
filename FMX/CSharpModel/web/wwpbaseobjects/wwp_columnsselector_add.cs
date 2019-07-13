/*
               File: WWPBaseObjects.WWP_ColumnsSelector_Add
        Description: Columns Selector - Add Columns
             Author: GeneXus C# Generator version 16_0_2-131213
       Generated on: 7/11/2019 11:24:59.35
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
   public class wwp_columnsselector_add : GXProcedure
   {
      public wwp_columnsselector_add( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public wwp_columnsselector_add( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( ref GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector aP0_ColumnsSelector ,
                           String aP1_ColumnName ,
                           bool aP2_IsVisible )
      {
         this.AV8ColumnsSelector = aP0_ColumnsSelector;
         this.AV9ColumnName = aP1_ColumnName;
         this.AV10IsVisible = aP2_IsVisible;
         initialize();
         executePrivate();
         aP0_ColumnsSelector=this.AV8ColumnsSelector;
      }

      public void executeSubmit( ref GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector aP0_ColumnsSelector ,
                                 String aP1_ColumnName ,
                                 bool aP2_IsVisible )
      {
         wwp_columnsselector_add objwwp_columnsselector_add;
         objwwp_columnsselector_add = new wwp_columnsselector_add();
         objwwp_columnsselector_add.AV8ColumnsSelector = aP0_ColumnsSelector;
         objwwp_columnsselector_add.AV9ColumnName = aP1_ColumnName;
         objwwp_columnsselector_add.AV10IsVisible = aP2_IsVisible;
         objwwp_columnsselector_add.context.SetSubmitInitialConfig(context);
         objwwp_columnsselector_add.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objwwp_columnsselector_add);
         aP0_ColumnsSelector=this.AV8ColumnsSelector;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((wwp_columnsselector_add)stateInfo).executePrivate();
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
         AV11Column = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column(context);
         AV11Column.gxTpr_Columnname = AV9ColumnName;
         AV11Column.gxTpr_Isvisible = AV10IsVisible;
         AV8ColumnsSelector.gxTpr_Columns.Add(AV11Column, 0);
         this.cleanup();
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
         AV11Column = new GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column(context);
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private bool AV10IsVisible ;
      private String AV9ColumnName ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector aP0_ColumnsSelector ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector AV8ColumnsSelector ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPColumnsSelector_Column AV11Column ;
   }

}
