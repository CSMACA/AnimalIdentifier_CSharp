using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using AnimalIdentifier_Base;

namespace AnimalIdentifier_GUI
{
    public partial class Form1 : Form
    {
        public string textBoxText;
        public Form1()
        {
            InitializeComponent();
        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            //Browse button action opens up file dialog
            DialogResult onClickAction = openFileDialog1.ShowDialog();
            //Selected path is entered into the text box
            string path;
            path = Path.GetFullPath(openFileDialog1.FileName);
            textBox1.Text = path;
        }

        private void search_button_Click(object sender, EventArgs e)
        {// Begins identification on button click.
            //Creates new image tagger object and inputs user path through the GetTags method
            ImageTagger animalImageTagger = new ImageTagger();
            List<Tag> tags = animalImageTagger.GetTagsForImage(textBoxText);

            //creates new tag filter and then runs the tag list through it
            TagFilter filter = new TagFilter();
            List<Tag> filteredTags = filter.Filter(tags);

            foreach (Tag tag in tags)
            {
                if (tag.name == "cat")
                {
                    checkBox2.Checked = true;
                }
                if (tag.name == "dog")
                {
                    checkBox1.Checked = true;
                }
                if (tag.name == "bird")
                {
                    checkBox3.Checked = true;
                }
            }


        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //Inputs given path into a string
            textBoxText = textBox1.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}
