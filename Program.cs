using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AoA_project
{
               // class Node 
    public unsafe class Node
    {
        public char character { get; set; }
        public int frequency { get; set; }
        public Node left;
        public Node right;

    }
                // Class BST
    public unsafe class BST
    {
        public Node root;
        public BST()
        {
            root = null;
            root.left = null;
            root.right = null;
        }
    }
    class Program
    {
                    //Huffman Tree, this functions builds tree and then genrates coded scheme file
        public static void Huffman_Tree(int[] freq, char[] ch, int length)
        {

            int sum = 0;
            Node s, tptr, pptr;
            Node head = new Node();
            head.left = null; head.right = null;
            pptr = s = head;
            head.frequency = sum;
            head.character = '\0';

            for (int j = 0; j < length; j++)
            {
                Node new_node = new Node();
                new_node.left = null; new_node.right = null;
                tptr = new_node;
                tptr.frequency = freq[j];
                tptr.character = ch[j];
                sum = sum + freq[j];
                if (s.left == null || s.right == null)
                {
                    if (tptr.frequency > s.frequency && s.right == null)
                    {
                        s.frequency = sum;
                        s.right = tptr;
                        head = s;
                    }
                    else if (s.left == null)
                    {
                        s.frequency = sum;
                        s.left = tptr;
                        head = s;
                    }

                }
                else
                {
                    Node new_node_2 = new Node();
                    new_node_2.right = null; new_node_2.left = null;
                    new_node_2.frequency = sum; new_node_2.character = '\0';
                    s = new_node_2;
                    if (pptr.frequency < s.frequency)
                    {
                        s.left = tptr;
                        s.right = pptr;
                        pptr = s;
                        head = s;
                    }
                    else
                    {
                        s.right = tptr;
                        // head = s;
                    }
                }
            }
            //Huffman_Code_Genrator , this part of function is for getting code for charaacters from tree 
            //this part of code is to traverse left side of tree from head
            int i = 0;

            int[] array = new int[length];
            for (int m = 0; m < length; m++)
            {
                array[m] = -1;
            }
            Node t, p;
            if (head == null || (head.left == null && head.right == null))
            {
                Console.WriteLine("Tree is empty");
            }
            else
            {
                t = head;
                if (t.left != null)
                {
                    t = t.left;
                    array[i] = 0;
                    while (t.left != null && t.right != null)
                    {
                        if (t.left != null)
                        {
                            i++;
                            t = t.left;
                            array[i] = 0;
                        }
                        else
                        {
                            i++;
                            t = t.right;
                            array[i] = 1;
                        }

                    }
                    //write code to file
                    int k = 0;
                    string a = "";
                    while (array[k] != -1)
                    {
                        a += Convert.ToString(array[k]);
                        k++;
                    }
                    a += t.character + "\n";

                    // this part of code is to traverse right side of tree from head
                    i = 0; t = head;
                    if (t.right != null)
                    {
                        t = t.right;
                        array[i] = 1;
                        while (t.left != null && t.right != null)
                        {
                            if (t.left.left == null && t.left.right == null)
                            {
                                p = t;
                                p = p.left;
                                i++;
                                array[i] = 0;
                                   //copy character, freq, array to file
                                k = 0;
                                while (array[k] != -1)
                                {
                                    a += Convert.ToString(array[k]);
                                    k++;
                                }
                                a += p.character + "\n";

                                t = t.right;
                            }
                            else if (t.right.left == null && t.right.right == null)
                            {
                                i++;
                                array[i] = 0;
                                //copy code character and frequency to file
                                k = 0;

                                while (array[k] != -1)
                                {
                                    a += Convert.ToString(array[k]);
                                    k++;
                                }
                                a += t.character + "\n";

                                t = t.left;
                            }
                        }
                        if (t.left != null)
                        {
                            p = t;
                            t = t.right;
                            i++;
                            array[i] = 1;
                               // code character and frequency to file
                            k = 0;
                            while (array[k] != -1)
                            {
                                a += Convert.ToString(array[k]);
                                k++;
                            }
                            a += p.character + '\n';

                        }
                        File.WriteAllText("coded_scheme_file.txt", a);
                        Convert_to_compressed();

                        /*else
                        {
                            //t = t.left;
                            i++;
                            array[i] = 0;
                            //code character frequency to file
                            k = 0;
                            while (array[k] != -1)
                            {
                                my_file.Write(array[k]);
                                k++;
                            }
                        }*/
                    }
                }
            }

        }
        //this function is to convert text file to compressed file using coded scheme file
        public static void Convert_to_compressed()
        {
            string text = "";
            string lines1 = File.ReadAllText("any_file.txt");
            string abc = File.ReadAllText("coded_scheme_file.txt");
            string[] lines = File.ReadAllLines("coded_scheme_file.txt");
            int n = lines.Length;
            foreach (char ch in lines1)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (lines[i].Length == 1)
                    {
                        if (Char.Equals(lines[i], ch) == true)
                        {
                            for (int j = 0; j < lines[i].Length; j++)
                            {
                                text += lines[i];
                            }
                        }



                    }
                    else if (lines[i].Length == 0)
                        continue;
                    else if (Char.Equals(lines[i][lines[i].Length - 1], ch) == true)
                    {
                        for (int j = 0; j < lines[i].Length - 1; j++)
                        {
                            text += lines[i][j];
                        }
                    }

                }
            }
            File.WriteAllText("Compressed_text_file.txt", text);
        }
            //this function sorts the frequency array in increasing order and character array as well with frequency array
        public static void sort(int[] arr, char[] arr2, int n)
        {

            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                char c = arr2[i];
                int j = i - 1;

                // Move elements of arr[0..i-1], 
                // that are greater than key, 
                // to one position ahead of 
                // their current position 
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    arr2[j + 1] = arr2[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
                arr2[j + 1] = c;
            }
        }
                            //Main fumction 
        static void Main(string[] args)
        {
            /*char[] ch = {'a', 'b', 'c', ' ', 'd' };
            int[] freq = { 3, 2, 6, 5, 4 };
            Huffman_Tree(freq, ch);*/
            int n = 256;
            int[] freq = new int[n];
            char[] ch = new char[n];
            string line;

            int ind = 0;

            line = File.ReadAllText("any_file.txt");
            int index = -1;
            foreach (char c in line)
            {
                index = -1;
                for (int i = 0; i < 256; i++)
                {
                    if (c == ch[i])
                        index = i;

                }
                if (index > 0)
                {
                    freq[index] = freq[index] + 1;
                    ch[index] = c;

                }
                else
                {
                    freq[ind] = 1;
                    ch[ind] = c;
                    ind++;
                }

            }

            sort(freq, ch, ind);   //calling to sort array


            Huffman_Tree(freq, ch, ind); //calling huffman to buid tree and generate code.

            Console.WriteLine("done");
            FileInfo f1 = new FileInfo("any_file.txt");
            FileInfo f2 = new FileInfo("compressed_text_file.txt");
            long size1 = f1.Length;
            Console.WriteLine("Text file: ", size1);
            long size2 = f2.Length;
            Console.WriteLine("Compressed file: ", size2);
            Console.Read();
        }

    }
}