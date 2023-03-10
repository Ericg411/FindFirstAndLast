using findfirstandlast;

namespace FindFirstAndLast.Tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;
    public UnitTest1()
    {
        _test = new Class1();
    }

    [TestMethod]
    public void TestMethod1()
    {
        int[] nums = { 5, 7, 7, 8, 8, 10 };
        int target = 8;
        int[] result = _test.SearchRange(nums, target);
        int[] answer = { 3, 4 };
        bool IsEqualto = true;
        for (int i = 0; i < answer.Length; i++)
        {
            if (result[i] != answer[i])
            {
                IsEqualto = false; break;
            }
        }

        Assert.IsTrue(IsEqualto);

        
    }
    
    [TestMethod]
    public void TestMethod2()
    {
        int[] nums = { 5, 7, 7, 8, 8, 10 };
        int target = 6;
        int[] result = _test.SearchRange(nums, target);
        int[] answer = { -1, -1 };
        bool IsEqualto = true;
        for (int i = 0; i < answer.Length; i++)
        {
            if (result[i] != answer[i])
            {
                IsEqualto = false; break;
            }
        }

        Assert.IsTrue(IsEqualto);

        
    }
    [TestMethod]
    public void TestMethod3()
    {
        int[] nums = { };
        int target = 0;
        int[] result = _test.SearchRange(nums, target);
        int[] answer = { -1, -1 };
        bool IsEqualto = true;
        for (int i = 0; i < answer.Length; i++)
        {
            if (result[i] != answer[i])
            {
                IsEqualto = false; break;
            }
        }

        Assert.IsTrue(IsEqualto);

        
    }
}