/*
				   File: type_SdtGxMap
			Description: GxMap
				 Author: Nemo 🐠 for C# version 16.0.2.131213
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
using GeneXus.Encryption;
using GeneXus.Http.Client;
using GeneXus.Http.Server;
using System.Reflection;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Web.Services.Protocols;


namespace GeneXus.Programs
{
	[XmlSerializerFormat]
	[XmlRoot(ElementName="GxMap")]
	[XmlType(TypeName="GxMap" , Namespace="FMX" )]
	[Serializable]
	public class SdtGxMap : GxUserType
	{
		public SdtGxMap( )
		{
			/* Constructor for serialization */
		}

		public SdtGxMap(IGxContext context)
		{
			this.context = context;
			initialize();
		}

		#region Json
		private static Hashtable mapper;
		public override String JsonMap(String value)
		{
			if (mapper == null)
			{
				mapper = new Hashtable();
			}
			return (String)mapper[value]; ;
		}

		public override void ToJSON()
		{
			ToJSON(true) ;
			return;
		}

		public override void ToJSON(bool includeState)
		{
			if (gxTv_SdtGxMap_Points != null)
			{
				AddObjectProperty("Points", gxTv_SdtGxMap_Points, false);  
			}
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="Points" )]
		[XmlArray(ElementName="Points"  )]
		[XmlArrayItemAttribute(ElementName="Point" , IsNullable=false )]
		public GXBaseCollection<SdtGxMap_Point> gxTpr_Points
		{
			get {
				if ( gxTv_SdtGxMap_Points == null )
				{
					gxTv_SdtGxMap_Points = new GXBaseCollection<SdtGxMap_Point>( context, "GxMap.Point", "");
				}
				return gxTv_SdtGxMap_Points;
			}
			set {
				if ( gxTv_SdtGxMap_Points == null )
				{
					gxTv_SdtGxMap_Points = new GXBaseCollection<SdtGxMap_Point>( context, "GxMap.Point", "");
				}
				gxTv_SdtGxMap_Points_N = 0;

				gxTv_SdtGxMap_Points = value;
				SetDirty("Points");
			}
		}

		public void gxTv_SdtGxMap_Points_SetNull()
		{
			gxTv_SdtGxMap_Points_N = 1;

			gxTv_SdtGxMap_Points = null;
			return  ;
		}

		public bool gxTv_SdtGxMap_Points_IsNull()
		{
			if (gxTv_SdtGxMap_Points == null)
			{
				return true ;
			}
			return false ;
		}

		public bool ShouldSerializegxTpr_Points_GxSimpleCollection_Json()
		{
				return gxTv_SdtGxMap_Points != null && gxTv_SdtGxMap_Points.Count > 0;

		}



		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtGxMap_Points_N = 1;

			return  ;
		}



		#endregion

		#region Declaration

		protected short gxTv_SdtGxMap_Points_N;
		protected GXBaseCollection<SdtGxMap_Point> gxTv_SdtGxMap_Points = null; 



		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"GxMap", Namespace="FMX")]
	public class SdtGxMap_RESTInterface : GxGenericCollectionItem<SdtGxMap>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtGxMap_RESTInterface( ) : base()
		{
		}

		public SdtGxMap_RESTInterface( SdtGxMap psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="Points", Order=0, EmitDefaultValue=false)]
		public GxGenericCollection<SdtGxMap_Point_RESTInterface> gxTpr_Points
		{
			get {
				if (sdt.ShouldSerializegxTpr_Points_GxSimpleCollection_Json())
					return new GxGenericCollection<SdtGxMap_Point_RESTInterface>(sdt.gxTpr_Points);
				else
					return null;

			}
			set {
				value.LoadCollection(sdt.gxTpr_Points);
			}
		}


		#endregion

		public SdtGxMap sdt
		{
			get { 
				return (SdtGxMap)Sdt;
			}
			set { 
				Sdt = value;
			}
		}

		[OnDeserializing]
		void checkSdt( StreamingContext ctx )
		{
			if ( sdt == null )
			{
				sdt = new SdtGxMap() ;
			}
		}
	}
	#endregion
}