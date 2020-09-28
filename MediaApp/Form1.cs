using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyMediaLibraryModel;


namespace MediaApp
{
	public partial class Form1 : Form
	{
		
		public Form1()
		{
			InitializeComponent();
		}

		private void countItems_Click(object sender, EventArgs e)
		{
			MediaLibrary medlib = new MediaLibrary();
			MediaItem meditem = new MediaItem();
			meditem.setTitle("Pingu's Panama Papers: The end of off-shore tax havens and the Conservative Party");
			meditem.setAgeRating(3);
			medlib.addToLibrary(meditem);

			int tot = medlib.mediaLibCount();
			MessageBox.Show($"There are {tot} items in the media library: ", "Media Library" );

		}
	}
}
