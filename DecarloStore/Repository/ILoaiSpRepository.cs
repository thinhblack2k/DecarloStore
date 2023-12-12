using DecarloStore.Models;
namespace DecarloStore.Repository
{
    public interface ILoaiSpRepository
    {
        TLoaiSp Add(TLoaiSp loaiSp);

        TLoaiSp Update(TLoaiSp loaiSp);

        TLoaiSp Delete(String maLoaiSp);

        TLoaiSp GetLoaiSp(String loaiSp);

        IEnumerable<TLoaiSp> GetAllLoaiSp();
    }
}
