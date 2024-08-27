using PlakDükkanı.Entities;
using PlakDükkanı.VMS;

namespace PlakDükkanı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AlbumleriGetir();
            BilgileriTemizle();
        }
        Guid GuncellenecekAlbumId;
        private void AlbumleriGetir()
        {
            dgw_Albüm.DataSource = null;

            var albums = UnitOfWork.Instance.Albums.GetAll();
            List<AlbumVM> list = new List<AlbumVM>();
            foreach (var album in albums)
            {
                AlbumVM albumVM = new AlbumVM()
                {
                    Id = album.Id,
                    AlbumName = album.AlbumName,
                    Artist = album.Artist,
                    ReleseadDate = album.ReleseadDate,
                    Price = album.Price,
                    IsDiscountinued = album.IsDiscountinued,
                    Discount = album.Discount,
                };
                list.Add(albumVM);
            }
            dgw_Albüm.DataSource = list;
            dgw_Albüm.Columns["Id"].Visible = false;
            BilgileriTemizle();





        }

        private void BilgileriTemizle()
        {
            txt_AlbumAdi.Text = string.Empty;
            txt_Artist.Text = string.Empty;
            nud_Fiyatı.Value = 0;
            nud_Indirim.Value = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {

            Album album1 = new Album()
            {

                AlbumName = txt_AlbumAdi.Text,
                Artist = txt_Artist.Text,
                ReleseadDate = dtp_CikisTarihi.Value,
                Price = (int)nud_Fiyatı.Value,
                IsDiscountinued = chk_SatistaMi.Checked ? true : false,
                Discount = (double)nud_Indirim.Value,


            };

            UnitOfWork.Instance.Albums.Add(album1);
            AlbumleriGetir();
        }
        private Guid AlbumIdSec()
        {
            return (Guid)dgw_Albüm.SelectedRows[0].Cells["Id"].Value;

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnitOfWork.Instance.Albums.Remove(AlbumIdSec());
            AlbumleriGetir();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuncellenecekAlbumId= AlbumIdSec();
            var guncellenecekAlbum = UnitOfWork.Instance.Albums.GetById(GuncellenecekAlbumId);
            txt_AlbumAdi.Text=guncellenecekAlbum.AlbumName;
            txt_Artist.Text = guncellenecekAlbum.Artist;
            dtp_CikisTarihi.Value=guncellenecekAlbum.ReleseadDate;
            nud_Fiyatı.Value = guncellenecekAlbum.Price;

        }

    }

}
