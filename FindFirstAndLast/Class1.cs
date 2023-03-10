namespace findfirstandlast;
public class Class1
{
    public int[] SearchRange(int[] nums, int target)
    {

        int i = 0;
        int a = 0;
        int n = nums.Length;
        bool b = false;
        List<int> arrList = new List<int>();

        for (i = 0; i < n; i++)
        {
            if (nums[i] == target)
            {
                if (arrList.Count == 2)
                {
                    a = i;
                    arrList.RemoveAt(1);
                    arrList.Insert(1, a);
                }
                else
                {
                    b = true;
                    a = i;
                    arrList.Add(a);
                }
            }
        }
        a = 0;
        if (b == true)
        {
            if (arrList.Count == 1)
            {
                a = arrList[0];
                arrList.Add(a);
                int[] arr = arrList.ToArray();
                return arr;
            }
            else
            {
                int[] arr1 = arrList.ToArray();
                return arr1;
            }
        }

        else
        {
            int[] arr2 = { -1, -1 };
            return arr2;
        }

    }
}
