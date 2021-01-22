using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using QUANLYKHACHSAN.QLKS_DBDataModel;
using QUANLYKHACHSAN.Common;
using QUANLYKHACHSAN.Model;

namespace QUANLYKHACHSAN.ViewModels {

    /// <summary>
    /// Represents the CHI_TIET_HOA_DON collection view model.
    /// </summary>
    public partial class CHI_TIET_HOA_DONCollectionViewModel : CollectionViewModel<CHI_TIET_HOA_DON, Tuple<string, string, string>, IQLKS_DBUnitOfWork> {

        /// <summary>
        /// Creates a new instance of CHI_TIET_HOA_DONCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static CHI_TIET_HOA_DONCollectionViewModel Create(IUnitOfWorkFactory<IQLKS_DBUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new CHI_TIET_HOA_DONCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the CHI_TIET_HOA_DONCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the CHI_TIET_HOA_DONCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected CHI_TIET_HOA_DONCollectionViewModel(IUnitOfWorkFactory<IQLKS_DBUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.CHI_TIET_HOA_DON) {
        }
    }
}