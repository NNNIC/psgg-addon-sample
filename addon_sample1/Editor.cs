using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addon_sample1
{
    public class Editor
    {
        #region editor
        EditorForm m_editor_form;
        public bool open_editor(Control owner)
        {
            m_editor_form = new EditorForm();
            m_editor_form.DialogResult = DialogResult.None;
            m_editor_form.Show(owner);
            return true;
        }
        public bool isdone_editor()
        {
            return m_editor_form.DialogResult!= DialogResult.None;
        }
        public DialogResult getresult_editor()
        {
            return m_editor_form.DialogResult;
        }
        public void dispose_editor()
        {
            m_editor_form.Dispose();
            m_editor_form=null;
        }
        #endregion

        #region item editor
        ItemEditorForm m_itemeditor_form;
        public bool open_itemeditor(Control owner)
        {
            m_itemeditor_form = new ItemEditorForm();
            m_itemeditor_form.DialogResult = DialogResult.None;
            m_itemeditor_form.Show(owner);
            return true;
        }
        public bool isdone_itemeditor()
        {
            return m_itemeditor_form.DialogResult != DialogResult.None;
        }
        public DialogResult getresult_itemeditor()
        {
            return m_itemeditor_form.DialogResult;
        }
        public void dispose_itemeditor()
        {
            m_itemeditor_form.Dispose();
            m_itemeditor_form = null;
        }
        #endregion
    }
}
