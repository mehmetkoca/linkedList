using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            LinkedList ll = new LinkedList();
            ll.InsertFirst(4);
            ll.InsertLast(5);
            MessageBox.Show(ll.DisplayElements());
            ll.InsertFirst(1);
            ll.InsertFirst(2);
            ll.InsertFirst(8);
            MessageBox.Show(ll.DisplayElements());
            ll.DeleteFirst();
            MessageBox.Show(ll.DisplayElements());
            ll.DeleteLast();
            MessageBox.Show(ll.DisplayElements());
            ll.DeleteLast();
            ll.DeleteLast();
            MessageBox.Show(ll.DisplayElements());
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        public void Uygulama2(Node test)
        {
            if (test == null)
                return;

            MessageBox.Show(test.Data.ToString());

            if (test.Next != null)
                Uygulama2(test.Next.Next);

            MessageBox.Show(test.Data.ToString());
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
           
        }

        public Node Uygulama3Reverse(Node head)
        {
		    Node currNode = head;
		    Node nextNode = null;
		    Node prevNode = null;

		    while(currNode!=null)
            {
			    nextNode = currNode.Next;
			    currNode.Next = prevNode;
			    prevNode = currNode;
			    currNode = nextNode;
		    }
		    return prevNode;
        }

    }
}
