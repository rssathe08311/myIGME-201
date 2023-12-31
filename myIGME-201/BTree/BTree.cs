﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BinaryTreeVisualizer;

namespace BTree
{
    public partial class BTreeForm : Form
    {
        public BTreeForm()
        {
            try
            {
                // Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.2; WOW64; Trident / 7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729; wbx 1.0.0)
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 11001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {
            }

            InitializeComponent();

            this.randomButton.Click += new EventHandler(RandomButton__Click);
            this.unbalancedButton.Click += new EventHandler(UnbalancedButton__Click);
            this.primedButton.Click += new EventHandler(PrimedButton__Click);
            this.button1.Click += new EventHandler(Exercise1__Click);
            this.button2.Click += new EventHandler(Exercise2__Click);
            this.button3.Click += new EventHandler(Exercise3__Click);
            this.button4.Click += new EventHandler(Exercise4__Click);
            this.button5.Click += new EventHandler(Exercise5__Click);
            this.button6.Click += new EventHandler(Exercise6__Click);
            this.button7.Click += new EventHandler(Exercise7__Click);
            this.exitButton.Click += new EventHandler(ExitButton__Click);

            // give the BTree class objects access to Form1
            BTree.bTreeForm = this;
        }

        private void ExitButton__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RandomButton__Click(object sender, EventArgs e)
        {
            // load a tree with random numbers
            BTree root = null;
            BTree node;
            Random random = new Random();

            this.richTextBox.Clear();

            for (int i = 0; i < 10; ++i)
            {
                node = new BTree(random.Next(100), root);

                if (i == 0)
                {
                    root = node;
                }
            }

            this.richTextBox.Text += "\nAscending order:";
            BTree.TraverseAscending(root);

            this.richTextBox.Text += "\nDescending order:";
            BTree.TraverseDescending(root);


            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private void UnbalancedButton__Click(object sender, EventArgs e)
        {
            // load a tree in data-ascending order, 
            // which will cause it to be unbalanced and poor-performing
            BTree root = null;
            BTree node;

            this.richTextBox.Clear();

            for (int i = 0; i < 10; ++i)
            {
                node = new BTree(i, root);

                if (i == 0)
                {
                    root = node;
                }
            }

            this.richTextBox.Text += "\n";
            BTree.TraverseAscending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private void PrimedButton__Click(object sender, EventArgs e)
        {
            // Prime a tree to hold alphabetical information

            this.richTextBox.Clear();

            BTree node = null;
            BTree root = null;
            
            node = new BTree("M", null);
            root = node;

            node = new BTree("F", root);
            node = new BTree("C", root);
            node = new BTree("B", root);
            node = new BTree("A", root);
            node = new BTree("E", root);
            node = new BTree("D", root);

            node = new BTree("J", root);
            node = new BTree("I", root);
            node = new BTree("H", root);
            node = new BTree("G", root);
            node = new BTree("L", root);
            node = new BTree("K", root);

            node = new BTree("P", root);
            node = new BTree("O", root);
            node = new BTree("N", root);
            node = new BTree("T", root);
            node = new BTree("S", root);
            node = new BTree("R", root);
            node = new BTree("Q", root);

            node = new BTree("W", root);
            node = new BTree("V", root);
            node = new BTree("U", root);
            node = new BTree("X", root);
            node = new BTree("Y", root);
            node = new BTree("Z", root);

            this.richTextBox.Text += "\n";            
            BTree.TraverseAscending(root);

            this.richTextBox.Text += "\n";
            BTree.TraverseDescending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private void Exercise1__Click(object sender, EventArgs e)
        {
            // Exercise #1
            // insert 30 random numbers between 1 and 51

            BTree root = null;
            BTree node;
            Random random = new Random();

            this.richTextBox.Clear();

            // Your code here
            for(int i = 1; i <= 30; i++)
            {
                node = new BTree(random.Next(1, 52), root);

                if(i == 1)
                {
                    root = node;
                }
            }

            this.richTextBox.Text += "\n";

            BTree.TraverseAscending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private void Exercise2__Click(object sender, EventArgs e)
        {
            // Exercise #2
            // prime the tree for numbers between 1 and 51
            // with 7 optimally distributed data points (setting isData = false) 
            // then insert 30 random numbers between 1 and 51

            BTree root = null;
            BTree node;
            Random random = new Random();

            this.richTextBox.Clear();


            // Your code here
            int[] vals = { 7, 15, 23, 31, 39, 47, 51 };
            for (int val = 1; val < vals.Length; val++)
            {
                node = new BTree(vals[val], root);

                if (val == 1)
                {
                    root = node;
                }
            }


            for (int i = 0; i < 30; ++i)
            {
                node = new BTree(random.Next(1, 52), root);
            }

            this.richTextBox.Text += "\n";

            BTree.TraverseAscending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private void Exercise3__Click(object sender, EventArgs e)
        {
            // Exercise #3
            // insert 15 random uppercase strings

            BTree root = null;
            BTree node;
            Random random = new Random();

            this.richTextBox.Clear();

            // Your code here
            for (int i = 1; i <= 15; ++i)
            {
                int num = random.Next(65, 91);
                char character = (char)num;
                string str = character.ToString() + "UG";
                node = new BTree(str, root);

                if(i == 1)
                {
                    root = node;
                }
            }

            this.richTextBox.Text += "\n";

            BTree.TraverseAscending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private void Exercise4__Click(object sender, EventArgs e)
        {
            // Exercise #4
            // prime the tree using the code in Button3_Click()
            // then insert the 15 random uppercase strings from Exercise #3

            this.richTextBox.Clear();

            BTree node = null;
            BTree root = null;
            Random random = new Random();

            // Your code here
            for (int i = 1; i <= 15; ++i)
            {
                int num = random.Next(65, 91);
                char character = (char)num;
                string str = character.ToString() + "UG";
                node = new BTree(str, root);

                if (i == 1)
                {
                    root = node;
                }
            }

            for (int i = 1; i <= 15; ++i)
            {
                int num = random.Next(65, 91);
                char character = (char)num;
                string str = character.ToString();
                node = new BTree(str, root);
            }


            this.richTextBox.Text += "\n";
            BTree.TraverseAscending(root);

            this.richTextBox.Text += "\n";
            BTree.TraverseDescending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private void Exercise5__Click(object sender, EventArgs e)
        {
            // Exercise #5
            // use the code in Button3_Click to add the 26 letters to the tree
            // then remove nodes "C", "I" and "A" 
            // using this code to remove each node:
            //     // create new freestanding node for "C"
            //     nodeToDelete = new BTree("C", null);
            //     BTree.DeleteNode(nodeToDelete, root);
            // add the newline and call BTree.TraverseAscending() after each delete

            this.richTextBox.Clear();

            BTree node = null;
            BTree nodeToDelete = null;
            BTree root = null;

            // Your code here
            for (int i = 1; i <= 26; ++i)
            {
                char character = (char)(64 + i);
                string str = character.ToString();
                node = new BTree(str, root);


                if (str.Equals("C"))
                {
                    nodeToDelete = new BTree("C", null);
                    BTree.DeleteNode(nodeToDelete, root);
                }
                if (str.Equals("I"))
                {
                    nodeToDelete = new BTree("I", null);
                    BTree.DeleteNode(nodeToDelete, root);
                }
                if (str.Equals("A"))
                {
                    nodeToDelete = new BTree("A", null);
                    BTree.DeleteNode(nodeToDelete, root);
                }

                if (i == 2)
                {
                    root = node;
                }
            }

            this.richTextBox.Text += "\n";
            BTree.TraverseAscending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private void Exercise6__Click(object sender, EventArgs e)
        {
            // Exercise #6
            // there are operator overloads to compare 2 BTree objects for BTree.data being string or int
            // enhance the overloads to support the Person object and compare using Person.age using:                
            //     if (a.data.GetType() == typeof(Person))


            // create at least 15 new Person objects which correspond to members of your family
            // insert them into the tree starting with yourself
            this.richTextBox.Clear();

            BTree node = null;
            BTree root = null;

            // the Person class is defined below
            Person person1 = new Person("Reva", 19);
            Person person2 = new Person("Swapna", 51);
            Person person3 = new Person("Jay", 51);
            Person person4 = new Person("Ruhi", 16);
            Person person5 = new Person("Korra", 3);
            Person person6 = new Person("Happy", 7);
            Person person7 = new Person("Nova", 7);
            Person person8 = new Person("Grandma", 81);
            Person person9 = new Person("Grandpa", 80);
            Person person10 = new Person("Dylan", 19);
            Person person11 = new Person("Josie", 20);
            Person person12 = new Person("Jack", 19);
            Person person13 = new Person("Matt", 20);
            Person person14 = new Person("Miles", 20);
            Person person15 = new Person("Jackson", 20);

            Person[] people = { person1, person2, person3, person4, person5, person6, person7, person8, person9, person10, person11, person12, person13, person14, person15 };

            // Your code here
            for (int i = 0; i < 15; ++i)
            {;
                node = new BTree(people[i], root);

                if (i == 0)
                {
                    root = node;
                }
            }


            this.richTextBox.Text += "\n";
            BTree.TraverseAscending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private void Exercise7__Click(object sender, EventArgs e)
        {
            // Exercise #7
            // given the age range of people in Exercise #6, 
            // prime the tree with nodes containing Person objects (set isData = false for the seed nodes)
            // containing the optimal ages to balance the tree
            this.richTextBox.Clear();

            BTree node = null;
            BTree root = null;
            Random random = new Random();

            int[] ages = { 33, 18, 58, 13, 28, 48, 68, 8, 23, 38, 53, 73, 3, 43, 63, 78, 81 };

            // Your code here
            for (int i = 0; i < 15; ++i)
            {
                Person person = new Person("name", ages[i]);
                node = new BTree(person.age, root);

                if (i == 0)
                {
                    root = node;
                }
            }

            this.richTextBox.Text += "\n";
            BTree.TraverseAscending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }
    }
}
