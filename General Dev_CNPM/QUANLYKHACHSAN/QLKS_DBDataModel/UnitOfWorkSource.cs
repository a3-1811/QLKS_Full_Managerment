using DevExpress.Mvvm;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.DesignTime;
using DevExpress.Mvvm.DataModel.EF6;
using QUANLYKHACHSAN.Model;
using System;
using System.Collections;
using System.Linq;

namespace QUANLYKHACHSAN.QLKS_DBDataModel {

    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource {

		/// <summary>
        /// Returns the IUnitOfWorkFactory implementation.
        /// </summary>
        public static IUnitOfWorkFactory<IQLKS_DBUnitOfWork> GetUnitOfWorkFactory() {
            return new DbUnitOfWorkFactory<IQLKS_DBUnitOfWork>(() => new QLKS_DBUnitOfWork(() => new QLKS_DB()));
        }
    }
}