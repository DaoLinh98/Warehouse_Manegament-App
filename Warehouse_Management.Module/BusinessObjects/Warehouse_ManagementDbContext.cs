using System;
using System.Data;
using System.Linq;
using System.Data.Entity;
using System.Data.Common;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.ComponentModel;
using DevExpress.ExpressApp.EF.Updating;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.ExpressApp.Design;
using DevExpress.ExpressApp.EF.DesignTime;
using DevExpress.Persistent.BaseImpl.EF.PermissionPolicy;

namespace Warehouse_Management.Module.BusinessObjects {
	public class Warehouse_ManagementContextInitializer : DbContextTypesInfoInitializerBase {
		protected override DbContext CreateDbContext() {
			DbContextInfo contextInfo = new DbContextInfo(typeof(Warehouse_ManagementDbContext), new DbProviderInfo(providerInvariantName: "System.Data.SqlClient", providerManifestToken: "2008"));
            return contextInfo.CreateInstance();
		}
	}
	[TypesInfoInitializer(typeof(Warehouse_ManagementContextInitializer))]
	public class Warehouse_ManagementDbContext : DbContext {
		public Warehouse_ManagementDbContext(String connectionString)
			: base(connectionString) {
		}
		public Warehouse_ManagementDbContext(DbConnection connection)
			: base(connection, false) {
		}
		public Warehouse_ManagementDbContext() {
		}
		public DbSet<ModuleInfo> ModulesInfo { get; set; }
		public DbSet<PermissionPolicyRole> Roles { get; set; }
		public DbSet<PermissionPolicyTypePermissionObject> TypePermissionObjects { get; set; }
		public DbSet<PermissionPolicyUser> Users { get; set; }
		public DbSet<ModelDifference> ModelDifferences { get; set; }
		public DbSet<ModelDifferenceAspect> ModelDifferenceAspects { get; set; }
		public DbSet<ListPartNumber> ListPartNumbers { get; set; }
		public DbSet<ListWarehouse> ListWarehouses {get; set; }
		public DbSet<ListSection> ListSections { get; set; }
		public DbSet<ListRack> ListRacks { get; set; }
		public DbSet<ListBin> ListBins { get; set; }
		public DbSet<Employee> Employees{get; set;}
		public DbSet<ManagePo> ManagePos {get; set; }
		public DbSet<TonDauKy> TonDauKy {get; set; }
		public DbSet<ManageSo> ManageSos { get; set; }
		public DbSet<Status> Status { get; set; }
		public DbSet<FormGoodsReceive> FormGoodsReceives { get; set; }
		public DbSet<DeliveryMaster> DeliveryMasters { get; set; }
		public DbSet<ListSupplier> ListSuppliers { get; set; }

	}
}