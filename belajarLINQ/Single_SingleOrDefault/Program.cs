using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace belajarLINQ.Single_SingleOrDefault
{
    class Program
    {
        static void Main()
        {
            /* Single(), mengembalikan satu-satunya elemen dari koleksi, atau satu-satunya elemen yang memenuhi kondisi yang ditentukan. 
             * Jika koleksi yang diberikan tidak menyertakan elemen atau lebih dari satu elemen maka Single () melempar InvalidOperationException.
             * SingleOrDefault(), satu-satunya perbedaan adalah bahwa ia mengembalikan nilai default dari tipe data koleksi jika koleksi kosong, termasuk lebih dari satu elemen atau tidak menemukan elemen atau lebih dari satu elemen untuk kondisi yang ditentukan.
             */

            IList<int> oneElementList = new List<int>() { 7 };
            IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
            IList<string> emptyList = new List<string>();

            Console.WriteLine("Single element di oneElementList = {0}", oneElementList.Single());

            Console.WriteLine("Single element di oneElementList = {0}", oneElementList.SingleOrDefault());

            Console.WriteLine("Element di emptyList = {0}", emptyList.SingleOrDefault());

            Console.WriteLine("Single element di instList yang lebih kecil dari 10 = {0}",
                intList.Single(x => x < 10));

            // Single() dan SingleOrDefault() juga akan melempar exception jika element yang
            // memenuhi kondisi lebih dari satu elemen
            //Console.WriteLine("Element kurang dari 100 di intList: {0}", intList.Single(i => i < 100));
        }
    }
}
