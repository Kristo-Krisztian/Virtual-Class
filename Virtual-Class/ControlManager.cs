using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Virtual_Class
{
    /// <summary>
    /// Provide an easier way to place controls,edit them,copy their properties
    /// </summary>

    // TODO: Add Remove and place function
    class ControlManager
    {
        List<Button> _button=new List<Button>();
        List<PictureBox> _pBox = new List<PictureBox>();
        List<Label> _label=new List<Label>();
        List<TextBox> _txtBox = new List<TextBox>();

        // function overloading here....
        public void Add(Button button)
        {
            _button.Add(button);
        }

        public void Add(PictureBox pBox)
        {
            _pBox.Add(pBox);
        }

        public void Add(Label label)
        {
            _label.Add(label);
        }

        public void Add(TextBox txtBox)
        {
            _txtBox.Add(txtBox);
        }
        
        public Button GetControlByIndex(int index)
        {
            return _button[index];
        }

        public Label GetControlByIndex(int index)
        {
            return _label[index];
        }

        public TextBox GetControlByIndex(int index)
        {
            return _txtBox[index];
        }

        public PictureBox GetControlByIndex(int index)
        {
            return _pBox[index];
        }
    }
}
