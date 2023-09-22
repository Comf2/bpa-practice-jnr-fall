using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bpa_practice
{
    internal class ListManiplulation
    {
        // --- Creating Lists and Maniplulating Them --- ///
        List<int> myList = new List<int>();
        List<int> otherList = new List<int>() { 6, 7, 8, 9, 25 };
        public void maniplulateList()
        {
            //adds the int '1' to the list 
            myList.Add(1);
            //Adds the whole list onto this list
            myList.AddRange(otherList);

            //Formats it to a string ex. "1, 2, 3"
            Debug.WriteLine(string.Join(", ", myList.ToArray()));

            //Removes the first occurence of a specific item
            //returns false if item not found, or removal unsuccessful
            myList.Remove(6); // true
            myList.Remove(-55); // false
            Debug.WriteLine(string.Join(", ", myList.ToArray()));

            //Removes element at a specified index
            myList.RemoveAt(0); // Removes the first element
            myList.RemoveAt(2); // Removes the third element
            Debug.WriteLine(string.Join(", ", myList.ToArray()));

            //Removes all elements that fit a certain condition 
            myList.RemoveAll(x => x % 2 == 0); // Removes all even numbers
            myList.RemoveAll(x => x == 3); // Removes every number 3 
            Debug.WriteLine(string.Join(", ", myList.ToArray()));

            //Add more elements to list - ignore
            myList.AddRange(otherList);

            //Removes all elements within a specified range
            //Params: Starting index, how many to remove
            myList.RemoveRange(0, 3); //Range starting from the first element to the third
            Debug.WriteLine(string.Join(", ", myList.ToArray()));

            //Removes all items of a List
            myList.Clear();
            Debug.WriteLine(string.Join(", ", myList.ToArray()));

            //Adding items - ignore
            myList.AddRange(otherList);
            myList.AddRange(otherList);
            myList.Add(1); // 1 is used for future examples

            //bool, true if List contains specific element
            bool hasOne = myList.Contains(1);
            Debug.WriteLine(hasOne);

            //bool, true if list contains element that fit condition
            bool hasEven = myList.Exists(x => x % 2 == 0);
            Debug.WriteLine(hasEven);
            
            // Searches for an element that matches conditions, returns first occurence
            int firstEven = myList.Find(x => x % 2 == 0);
            Debug.WriteLine(firstEven);

            //returns all elements that match a certain condition as a list
            List<int> allEvens = new List<int>(myList.FindAll(x => x % 2 ==0));
            Debug.WriteLine(string.Join(", ", allEvens.ToArray()));

            //Returns the index of the first occurance of a value
            int oneIndex = myList.IndexOf(1);
            int oneIndexFromFive = myList.IndexOf(1, 5); // Starts at 5
            Debug.WriteLine($"No Range:{oneIndex} : Starts from five: {oneIndexFromFive}");

            //Returns the index of the last occurance of a specified element
            //returns -1 if character is not found
            int lastOneIndex = myList.LastIndexOf(1);
            Debug.WriteLine(lastOneIndex);

            // Loops through each element of a list
            // The iteration variable (listEle) is a copy of the actual element in myList,
            // so modifying listEle won't affect the original elements in myList.
            foreach (int listEle in myList)
            {
                Debug.Write(listEle); // Doing Write instead of write line to not clutter terminal
            }
            Debug.WriteLine(""); // Create a new line

            // Copies the elements of a list to a new array
            int[] intArr = myList.ToArray();
            Debug.WriteLine(string.Join(", ", intArr.ToArray()));
            
            //Sets the capacity of the list to the actual amount of elements
            List<int> trimExcessEx = new List<int>(100); // Has a capacity of 100
            trimExcessEx.AddRange(myList); // not filling all 100 spaces
            trimExcessEx.TrimExcess(); // now capacity equals myList length
            Debug.WriteLine(trimExcessEx.Capacity);

            //Returns a ReadOnlycollection wrapper for the current list 
            List<int> ReadOnlyEx = new List<int>(myList);
            ReadOnlyEx.AsReadOnly(); // List can not be changed anymore, only read

            //Sorts all elements in the list using the default comparer
            //For numbers, the default comparer sorts in an ascending order
            myList.Sort();
            Debug.WriteLine(string.Join(", ", myList.ToArray()));

            //Sorts all elements in the list using the comparer specified
            // Can create your own comparer class and use that
            //can also use lambda expressions etc.\
            myList.Sort((x, y) => x % 2 == 0 ? -1 : 1);
            Debug.WriteLine(string.Join(", ", myList.ToArray()));

            //Reverses the order of a List 
            //can also specify a range in the parameters
            myList.Reverse();
            Debug.WriteLine(string.Join(", ", myList.ToArray()));

            //Copies a List to an array
            //Can also put a range into the parameters
            List<int> copyToListEx = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            int[] myListArr = new int[7];
            copyToListEx.CopyTo(myListArr);
            Debug.WriteLine($"Array:{string.Join(", ", myListArr)}");

            // Concatenates two lists and returns a new Ienurable, but can be changed back to list by doing .ToList();
            List<int> IenumConcatEx = myList.Concat(otherList).ToList();
            Debug.WriteLine($"Concat: {string.Join(", ", IenumConcatEx.ToArray())}");

            // Sorts the elements of a sequence in ascending order.
            myList.OrderBy(x => x);
            Debug.WriteLine($"asending:{IenumConcatEx.ToArray()}");

            // Sorts the elements of a sequence in descending order.
            myList.OrderByDescending(x => x);
            Debug.WriteLine($"desending:{IenumConcatEx.ToArray()}");
        }
    }
}
