//
//////////////////////////////////////////////////////////////////////////////
//
//  
//
//  
//  
//  
//
//////////////////////////////////////////////////////////////////////////////

using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.ApplicationServices;
using System.Reflection;

using System.IO;
using System.Collections;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.GraphicsInterface;

[assembly: Autodesk.AutoCAD.Runtime.ExtensionApplication(typeof(mleader_remove_style_override.Mleader_remove_style_overrideApp))]
[assembly: Autodesk.AutoCAD.Runtime.CommandClass(typeof(mleader_remove_style_override.Mleader_remove_style_overrideCommands))]


//This application implements a command called ellipsejig. It will help you 
//create an ellipse from scratch by doing a jig. The user is first asked to
//enter the ellipse major axis followed by ellipse minor axis. 

//To use mleader_remove_style_override.dll:
//1. Start AutoCAD and open a new drawing.
//2. Type netload and select mleader_remove_style_override.dll.
//3. Execute the ellipsejig command, defined by mleader_remove_style_override.dll.

//Please add the References acdbmgd.dll,acmgd.dll,
//Autodesk.AutoCAD.Interop.dll and Autodesk.AutoCAD.Interop.Common.dll
//before trying to build this project.

namespace mleader_remove_style_override
{


    public class Mleader_remove_style_overrideApp : Autodesk.AutoCAD.Runtime.IExtensionApplication
    {
        public Mleader_remove_style_overrideApp()
        {


        }

        public void Initialize()
        {
            Mleader_remove_style_overrideCommands.Foo();

        }

        public void Terminate()
        {


        }

    }

    public class Mleader_remove_style_overrideCommands
    {

        // The c++ function is declared as:
        //  Acad::ErrorStatus AcDbMLeader::setOverride(
        //      PropertyOverrideType propertyType,
        //      bool isOverride = true
        //  );

        //      Dump of file acdb23.dll
        //Section contains the following exports for acdb23.dll
        //    18607 48A0 00A3EE04? setOverride@AcDbDimensionObjectContextData@@UEAA? AW4ErrorStatus@Acad@@W4Code @AcDm@@_N @Z
        //    18608 48A1 00A8EDBC? setOverride@AcDbFormattedTableData@@UEAA? AW4ErrorStatus@Acad@@HHHW4CellProperty @AcDb@@@Z
        //    18609 48A2 00A8EDD0? setOverride@AcDbFormattedTableData@@UEAA? AW4ErrorStatus@Acad@@HHW4GridLineType @AcDb@@W4GridProperty@5@@Z
        //    18610 48A3 00A88A30? setOverride@AcDbMLeader@@QEAA? AW4ErrorStatus@Acad@@W4PropertyOverrideType@1@_N @Z
        //    18611 48A4 00A70928? setOverride@AcDbTable@@QEAA? AW4ErrorStatus@Acad@@HHHW4CellProperty @AcDb@@@Z
        //    18612 48A5 00A70970? setOverride@AcDbTable@@QEAA? AW4ErrorStatus@Acad@@HHW4GridLineType @AcDb@@W4GridProperty@5@@Z
        //    18613 48A6 00AA638C? setOverrideCenter@AcDbRadialDimensionLarge@@QEAA? AW4ErrorStatus@Acad@@AEBVAcGePoint3d@@@Z
        //    18614 48A7 00A84A60? setOverrideCenter@AcDbRadialDimensionLargeObjectContextData@@QEAA? AW4ErrorStatus@Acad@@AEBVAcGePoint3d@@@Z
        //    18615 48A8 00AA6664? setOverrideCenterPP@AcDbRadialDimensionLarge@@QEAA? AW4ErrorStatus@Acad@@AEBVAcGePoint3d@@@Z
        //    18616 48A9 00A50720? setOverridenItems@AcDbAssocArrayModifyActionBody@@QEAA? AW4ErrorStatus@Acad@@AEBV?$AcArray @VAcDbItemLocator@@V?$AcArrayObjectCopyReallocator @VAcDbItemLocator@@@@@@@Z



        // 18610 48A3 00A88A30? setOverride@AcDbMLeader@@QEAA? AW4ErrorStatus@Acad@@W4PropertyOverrideType@1@_N @Z

        /*
         * 
         * 
               enum AcDbMLeader::PropertyOverrideType {
                   kLeaderLineType = 0,
                   kLeaderLineColor = 1,
                   kLeaderLineTypeId = 2,
                   kLeaderLineWeight = 3,
                   kEnableLanding = 4,
                   kLandingGap = 5,
                   kEnableDogleg = 6,
                   kDoglegLength = 7,
                   kArrowSymbolId = 8,
                   kArrowSize = 9,
                   kContentType = 10,
                   kTextStyleId = 11,
                   kTextLeftAttachmentType = 12,
                   kTextAngleType = 13,
                   kTextAlignmentType = 14,
                   kTextColor = 15,
                   kTextHeight = 16,
                   kEnableFrameText = 17,
                   kDefaultMText = 18,
                   kBlockId = 19,
                   kBlockColor = 20,
                   kBlockScale = 21,
                   kBlockRotation = 22,
                   kBlockConnectionType = 23,
                   kScale = 24,
                   kTextRightAttachmentType = 25,
                   kTextSwitchAlignmentType = 26,
                   kTextAttachmentDirection = 27,
                   kTextTopAttachmentType = 28,
                   kTextBottomAttachmentType = 29,
                   kExtendLeaderToText = 30,
                   kSize = kExtendLeaderToText+1
             };
         * 
         * 
         * 
         */

        /*
         * 
            Dump of file acdb23.dll
            Section contains the following exports for acdb23.dll
              12927 3272 00A88374 ?isOverride@AcDbMLeader@@QEBA_NW4PropertyOverrideType@1@@Z
         * */


        //[DllImport("acdb23.dll", CallingConvention = CallingConvention.ThisCall, EntryPoint = "?setOverride@AcDbMLeader@@QEAA", CharSet = CharSet.Auto)]
        [DllImport("acdb23.dll", CallingConvention = CallingConvention.ThisCall, EntryPoint = "?isOverride@AcDbMLeader@@QEBA_NW4PropertyOverrideType@1@@Z", CharSet = CharSet.Auto)]

        //public static extern ErrorStatus setOverride( IntPtr target , [MarshalAs(UnmanagedType.SysUInt)] int propertyType, [MarshalAs(UnmanagedType.Bool)] bool isOverride);
        public static extern bool isOverride(IntPtr target, [MarshalAs(UnmanagedType.SysUInt)] int propertyType);

        static public void Foo()
        {
            Document document = Application.DocumentManager.MdiActiveDocument;
            Database database = document.Database;
            Autodesk.AutoCAD.DatabaseServices.TransactionManager transactionManager = database.TransactionManager;
            using (Transaction transaction = transactionManager.StartTransaction())
            {
                document.Editor.WriteMessage("HOORAY\n");
                BlockTable blockTable = (BlockTable)transactionManager.GetObject(database.BlockTableId, OpenMode.ForRead, openErased: false);
                BlockTableRecord blockTableRecord = (BlockTableRecord)transactionManager.GetObject(blockTable[BlockTableRecord.ModelSpace], OpenMode.ForWrite, false);
                foreach (Autodesk.AutoCAD.DatabaseServices.ObjectId objectId in blockTableRecord)
                {
                    DBObject dbObject = objectId.GetObject(OpenMode.ForRead);
                    document.Editor.WriteMessage("type: " + dbObject.GetType() + "\n");
                    if(dbObject.GetType() == typeof(MLeader))
                    {
                        document.Editor.WriteMessage("We found a multileader.\n");
                        MLeader mLeader = (MLeader)dbObject;

                        // damn: the .net api does not expose the functions related to mleader style overrides.
                        //mLeader.isoverride(MLeader.PropertyOverrideType.kLeaderLineType);
                        //MLeader.setOverride(MLeader.PropertyOverrideType.kLeaderLineType, false);
                        //kLeaderLineType

                        //ErrorStatus result = setOverride(mLeader.UnmanagedObject, 16, false);

                        bool result = isOverride(mLeader.UnmanagedObject, 16);
                        document.Editor.WriteMessage("result: " + result + "\n");
                    }

                    
                }
            }

        }

        class EllipseJig : EntityJig	
		{
			Point3d mCenterPt,mAxisPt,acquiredPoint;
			Vector3d mNormal,mMajorAxis;
			double mRadiusRatio;
			
			int mPromptCounter;
			
			DynamicDimensionDataCollection m_dims;

			public EllipseJig(Point3d center,Vector3d vec):base(new Ellipse())
			{
				mCenterPt = center;
				mNormal = vec;
				mRadiusRatio = 0.00001;
				mPromptCounter = 0;

				m_dims = new DynamicDimensionDataCollection();
				Dimension dim1 = new AlignedDimension();
				dim1.SetDatabaseDefaults();
				m_dims.Add(new DynamicDimensionData(dim1,true,true));
                dim1.DynamicDimension = true;
				Dimension dim2 = new AlignedDimension();
				dim2.SetDatabaseDefaults();
				m_dims.Add(new DynamicDimensionData(dim2,true,true));
                dim2.DynamicDimension = true;
			
			}
	
			protected  override SamplerStatus Sampler(JigPrompts prompts)
			{
				JigPromptPointOptions jigOpts = new JigPromptPointOptions();
				jigOpts.UserInputControls = (UserInputControls.Accept3dCoordinates | UserInputControls.NoZeroResponseAccepted | UserInputControls.NoNegativeResponseAccepted);
			
				if(mPromptCounter == 0)
				{
					jigOpts.Message = "\nEllipse Major axis:";
					PromptPointResult dres = prompts.AcquirePoint(jigOpts);
					
					Point3d axisPointTemp = dres.Value;
					if(axisPointTemp != mAxisPt)
					{
						mAxisPt = axisPointTemp;
					}
					else
						return SamplerStatus.NoChange;

					if(dres.Status == PromptStatus.Cancel)
						return SamplerStatus.Cancel;
					else
						return SamplerStatus.OK;
					
					
				}
				else if (mPromptCounter == 1) 
				{
					jigOpts.BasePoint = mCenterPt;
					jigOpts.UseBasePoint = true;
					jigOpts.Message = "\nEllipse Minor axis:";
					double radiusRatioTemp = -1;
					PromptPointResult res = prompts.AcquirePoint(jigOpts);
					acquiredPoint = res.Value;
					radiusRatioTemp = mCenterPt.DistanceTo(acquiredPoint);

                    // Ensure the radiusRatio is kept within the expected range.
                    if (radiusRatioTemp > 1.0)
                        radiusRatioTemp = 1.0;
				
					if (radiusRatioTemp != mRadiusRatio)
						mRadiusRatio = radiusRatioTemp;
					else 
						return SamplerStatus.NoChange;

					if(res.Status == PromptStatus.Cancel)
						return SamplerStatus.Cancel;
					else
						return SamplerStatus.OK;
			
				}
				else
				{
					return SamplerStatus.NoChange;
				}
				
				
			}
			protected override bool Update()
			{
				double radiusRatio = 1.0;
				switch (mPromptCounter) 
				{
					case 0:
						// At this time, mAxis contains the value of one
						// endpoint of the desired major axis.  The
						// AcDbEllipse class stores the major axis as the
						// vector from the center point to where the axis
						// intersects the ellipse path (such as half of the true
						// major axis), so we already have what we need.
						//
						mMajorAxis = mAxisPt - mCenterPt;
						break;
					case 1:
						// Calculate the radius ratio.  mRadiusRatio
						// currently contains the distance from the ellipse
						// center to the current pointer position.  This is
						// half of the actual minor axis length.  Since
						// AcDbEllipse stores the major axis vector as the
						// vector from the center point to the ellipse curve
						// (half the major axis), to get the radius ratio we
						// simply divide the value currently in mRadiusRatio
						// by the length of the stored major axis vector.
						//
						
						radiusRatio = mRadiusRatio / mMajorAxis.Length;
						break;
				}
				
				try
				{
					((Ellipse)Entity).Set(mCenterPt,new Vector3d(0,0,1),mMajorAxis,radiusRatio,0.0,6.28318530717958647692);
					UpdateDimensions();
					
				}
				catch(System.Exception)
				{
					return false;  
				}
				
				return true;  

			}
			protected override DynamicDimensionDataCollection GetDynamicDimensionData(double dimScale)
			{
				return m_dims;
			}
			protected override void OnDimensionValueChanged(Autodesk.AutoCAD.DatabaseServices.DynamicDimensionChangedEventArgs e)
			{
				
			}
			void UpdateDimensions()
			{
				if(mPromptCounter == 0)
				{
					Ellipse myellipse = (Ellipse)Entity;
					AlignedDimension dim = (AlignedDimension)m_dims[0].Dimension;
					dim.XLine1Point = myellipse.Center;
					dim.XLine2Point = mAxisPt;
					dim.DimLinePoint = myellipse.Center;
				}
				else
				{
					Ellipse myellipse = (Ellipse)Entity;
					AlignedDimension dim2 = (AlignedDimension)m_dims[1].Dimension;
					dim2.XLine1Point = myellipse.Center;
					dim2.XLine2Point = acquiredPoint;
					dim2.DimLinePoint = myellipse.Center;
				}

			}
			public void setPromptCounter(int i)
			{
				mPromptCounter = i;
			}
			public Entity GetEntity()
			{
				return Entity;
			}

		}
		[CommandMethod("ellipsejig")]
		static public void DoIt()
		{
            Foo();
			//Editor ed = Application.DocumentManager.MdiActiveDocument.Editor;   
			//PromptPointOptions opts = new PromptPointOptions("\nEnter Ellipse Center Point:");
			//PromptPointResult res = ed.GetPoint(opts);

			//Vector3d x = Application.DocumentManager.MdiActiveDocument.Database.Ucsxdir;
			//Vector3d y = Application.DocumentManager.MdiActiveDocument.Database.Ucsydir;
			//Vector3d NormalVec = x.CrossProduct(y);
		

			//Database db = Application.DocumentManager.MdiActiveDocument.Database;
			//Autodesk.AutoCAD.DatabaseServices.TransactionManager tm = db.TransactionManager;
		
			////Create Ellipsejig
			//EllipseJig jig = new EllipseJig(res.Value,NormalVec.GetNormal());
			////first call drag to get the major axis
			//jig.setPromptCounter(0);
			//Application.DocumentManager.MdiActiveDocument.Editor.Drag(jig);
			//// Again call drag to get minor axis					
			//jig.setPromptCounter(1);
			//Application.DocumentManager.MdiActiveDocument.Editor.Drag(jig);

			////Append entity.
			//using (Transaction myT = tm.StartTransaction())
			//{              
			//	BlockTable bt = (BlockTable)tm.GetObject(db.BlockTableId,OpenMode.ForRead,false);
			//	BlockTableRecord btr = (BlockTableRecord)tm.GetObject(bt[BlockTableRecord.ModelSpace],OpenMode.ForWrite,false);
			//	btr.AppendEntity(jig.GetEntity());
			//	tm.AddNewlyCreatedDBObject(jig.GetEntity(),true);
			//	myT.Commit();
			//}

				
		}
	}
	
}
