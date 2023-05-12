namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyEventsSchema

	/// <exclude/>
	public class UsrRealtyEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyEventsSchema(UsrRealtyEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("20acc388-eeef-40a2-9fd8-7e9ae76ee1a0");
			Name = "UsrRealtyEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d22024ef-3d9e-49bf-8969-21c0530f7f15");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,112,244,112,84,4,0,175,105,139,86,5,0,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("26ed4481-f6ac-2940-bca1-f152a3eab798"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("d22024ef-3d9e-49bf-8969-21c0530f7f15"),
				CreatedInSchemaUId = new Guid("20acc388-eeef-40a2-9fd8-7e9ae76ee1a0"),
				ModifiedInSchemaUId = new Guid("20acc388-eeef-40a2-9fd8-7e9ae76ee1a0")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("20acc388-eeef-40a2-9fd8-7e9ae76ee1a0"));
		}

		#endregion

	}

	#endregion

}

