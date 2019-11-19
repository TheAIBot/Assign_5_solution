using Assign_5_solution;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod01()
        {
            int[] numbers = new int[] { 7, 9, 14, 13, 42, 9 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(9, result.number);
            Assert.AreEqual(61, result.newNumber);
        }

        [TestMethod]
        public void TestMethod02()
        {
            int[] numbers = new int[] { 1, 1, 1 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1, result.number);
            Assert.AreEqual(3, result.newNumber);
        }

        [TestMethod]
        public void TestMethod03()
        {
            int[] numbers = new int[] { 1, 1, 1, 1 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1, result.number);
            Assert.AreEqual(4, result.newNumber);
        }

        [TestMethod]
        public void TestMethod04()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1, result.number);
            Assert.AreEqual(53, result.newNumber);
        }

        [TestMethod]
        public void TestMethod05()
        {
            int[] numbers = new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(10, result.number);
            Assert.AreEqual(1, result.newNumber);
        }

        [TestMethod]
        public void TestMethod06()
        {
            int[] numbers = new int[] { 10, 10, 10 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(10, result.number);
            Assert.AreEqual(1, result.newNumber);
        }

        [TestMethod]
        public void TestMethod07()
        {
            int[] numbers = new int[] { 1, 1, 2, 2, 3, 3, 4, 4 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1, result.number);
            Assert.AreEqual(20, result.newNumber);
        }

        [TestMethod]
        public void TestMethod08()
        {
            int[] numbers = new int[] { 1, 1, 2, 4, 8, 16, 32, 64, 128, 256 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1, result.number);
            Assert.AreEqual(512, result.newNumber);
        }

        [TestMethod]
        public void TestMethod09()
        {
            int[] numbers = new int[] { 11, 11, 11, 11, 11, 11, 11, 11, 11, 11 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(11, result.number);
            Assert.AreEqual(1, result.newNumber);
        }

        [TestMethod]
        public void TestMethod10()
        {
            int[] numbers = new int[] { 7, 2, 2, 6, 2, 3, 8, 6, 2, 8 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(2, result.number);
            Assert.AreEqual(43, result.newNumber);
        }

        [TestMethod]
        public void TestMethod11()
        {
            int[] numbers = new int[] { 24, 26, 51, 33, 39, 27, 52, 4, 82, 58 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(27, result.number);
            Assert.AreEqual(301, result.newNumber);
        }

        [TestMethod]
        public void TestMethod12()
        {
            int[] numbers = new int[] { 398, 153, 91, 706, 817, 540, 45, 712, 148, 907 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(706, result.number);
            Assert.AreEqual(261, result.newNumber);
        }

        [TestMethod]
        public void TestMethod13()
        {
            int[] numbers = new int[] { 6, 1, 5, 10, 12, 15 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(5, result.number);
            Assert.AreEqual(35, result.newNumber);
        }

        [TestMethod]
        public void TestMethod14()
        {
            int[] numbers = new int[] { 4, 3, 1, 1, 2 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1, result.number);
            Assert.AreEqual(11, result.newNumber);
        }

        [TestMethod]
        public void TestMethod15()
        {
            int[] numbers = new int[] { 584, 822, 4, 536, 806 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(4, result.number);
            Assert.AreEqual(1, result.newNumber);
        }

        [TestMethod]
        public void TestMethod16()
        {
            int[] numbers = new int[] { 8, 4, 2, 1, 1, 8, 7, 2, 3, 8 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1, result.number);
            Assert.AreEqual(44, result.newNumber);
        }

        [TestMethod]
        public void TestMethod17()
        {
            int[] numbers = new int[] { 3, 7, 2, 1, 7, 6, 1, 5, 8 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1, result.number);
            Assert.AreEqual(40, result.newNumber);
        }


        [TestMethod]
        public void TestMethod18()
        {
            int[] numbers = new int[] { 63, 22, 2, 37, 27, 7, 72, 8 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(8, result.number);
            Assert.AreEqual(146, result.newNumber);
        }

        [TestMethod]
        public void TestMethod19()
        {
            int[] numbers = new int[] { 465, 13, 798, 440, 514, 500, 9 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(9, result.number);
            Assert.AreEqual(3, result.newNumber);
        }

        [TestMethod]
        public void TestMethod20()
        {
            int[] numbers = new int[] { 1658, 26, 7, 128, 1309, 70, 1828, 1858, 923, 751 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(26, result.number);
            Assert.AreEqual(8, result.newNumber);
        }

        [TestMethod]
        public void TestMethod21()
        {
            int[] numbers = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1, result.number);
            Assert.AreEqual(100, result.newNumber);
        }

        [TestMethod]
        public void TestMethod22()
        {
            int[] numbers = new int[] { 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(101, result.number);
            Assert.AreEqual(1, result.newNumber);
        }

        [TestMethod]
        public void TestMethod23()
        {
            int[] numbers = new int[] { 669, 141, 126, 523, 169, 263, 725, 513, 174, 762, 235, 258, 506, 321, 381, 261, 518, 36, 815, 578, 398, 153, 91, 706, 817, 540, 45, 712, 148, 907, 693, 517, 187, 42, 309, 584, 822, 4, 536, 806, 749, 385, 150, 27, 52, 782, 627, 116, 250, 773 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(36, result.number);
            Assert.AreEqual(20739, result.newNumber);
        }

        [TestMethod]
        public void TestMethod24()
        {
            int[] numbers = new int[] { 29, 65, 15, 5, 61, 52, 6, 43, 71, 63, 22, 2, 37, 27, 7, 72, 8, 47, 2, 80, 44, 52, 50, 1, 83, 2, 1, 7, 66, 4, 92, 93, 47, 38, 62, 5, 38, 15, 44, 80, 54, 41, 30, 91, 59, 74, 2, 89, 96, 34, 72, 17, 11, 46, 34, 78, 15, 14, 22, 60, 52, 99, 77, 68, 72, 29, 56, 99, 66, 3, 35, 93, 3, 22, 27, 4, 22, 60, 43, 10, 100, 13, 11, 33, 33, 76, 83, 1, 5, 85, 90, 24, 93, 85, 28, 55, 64, 63, 20, 30, 19, 3, 24, 94, 99, 79, 14, 89, 19, 30, 56, 56, 72, 13, 60, 40, 89, 45, 35, 97, 47, 55, 95, 82, 13, 11, 1, 19, 95, 73, 41, 60, 41, 13, 92, 97, 90, 18, 34, 55, 62, 95, 83, 75, 29, 34, 53, 81, 25, 89 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1, result.number);
            Assert.AreEqual(7100, result.newNumber);
        }

        //[TestMethod]
        //public void TestMethod25()
        //{
        //    int[] numbers = new int[] { 6645, 1896, 2772, 2286, 8337, 6401, 819, 4206, 8052, 8801, 7788, 9534, 9431, 4667, 8908, 9692, 1562, 5876, 2113, 6343, 5010, 7083, 1111, 8061, 3479, 5213, 7207, 2005, 5299, 7887, 5818, 1986, 9348, 523, 557, 2145, 3137, 1716, 2914, 2707, 8821, 4701, 3675, 4538, 7635, 6626, 9994, 3558, 8566, 3114, 1836, 9381, 5931, 6129, 3871, 9562, 786, 4712, 8807, 3125, 9194, 8815, 8907, 166, 2984, 5803, 187, 8908, 4110, 6764, 6556, 9847, 2962, 9406, 7523, 309, 3409, 6573, 426, 6854, 5219, 3650, 3439, 2186, 6052, 6437, 6055, 3220, 6652, 996, 1360, 8426, 2909, 9790, 3514, 7, 5794, 3510, 1555, 1832, 6440, 1086, 9449, 1803, 6558, 1989, 6419, 6525, 8607, 3563, 6154, 4213, 4286, 1954, 7906, 5544, 5376, 6722, 4114, 6547, 9748, 6968, 2256, 3114, 5405, 8130, 6938, 3173, 5893, 7516, 4516, 9899, 5019, 8595, 414, 4134, 4202, 1637, 5628, 4063, 19, 9531, 4613, 3090, 4843, 7147, 4141, 956, 1885, 7970, 4632, 9072, 9397, 5008, 2085, 9473, 8830, 6335, 6399, 8429, 5051, 3246, 633, 1091, 9048, 6256, 9195, 5691, 1540, 3772, 1343, 3739, 1095, 51, 6529, 218, 2355, 9167, 8272, 8258, 3990, 5983, 1289, 7924, 2885, 5444, 502, 11, 6511, 942, 5304, 7868, 5239, 7199, 9013, 6773, 8899, 3523, 4043, 8588, 7952, 8450, 9416, 8113, 6627, 893, 7978, 9346, 8479, 1868, 7119, 9664, 8064, 8141, 4439, 9068, 1958, 2709, 8207, 3604, 5754, 9185, 9181, 599, 8468, 3476, 8501, 3896, 1039, 9757, 1319, 8832, 5124, 9684, 307, 5541, 6568, 3177, 1297, 1993, 7467, 1157, 1532, 4644, 3824, 5641, 9805, 7098, 2761, 9945, 4815, 6190, 5317, 439, 2834, 8768, 9269, 8817, 9645, 3152, 2392, 4082, 8308, 8723, 549, 8287, 4540, 8380, 7835, 8899, 2501, 8781, 1413, 6214, 6138, 4598, 7653, 4538, 6776, 2828, 3672, 1403, 1136, 1094, 4942, 5130, 3516, 4685, 6851, 1540, 6273, 7751, 3533, 8145, 9601, 3385, 2849, 2810, 4095, 5537 };

        //    var result = Program.Solve(numbers);
        //    Assert.AreEqual(19, result.number);
        //    Assert.AreEqual(1571551, result.newNumber);
        //}

        //[TestMethod]
        //public void TestMethod26()
        //{
        //    int[] numbers = new int[] { 2203, 2850, 18528, 7725, 14888, 12068, 9555, 18205, 8603, 16474, 2229, 9461, 4083, 13634, 18962, 1978, 5893, 14428, 7561, 10838, 9542, 19709, 3059, 12590, 5253, 9501, 10498, 6536, 13227, 5506, 3497, 9687, 886, 2478, 3452, 4493, 4279, 14546, 7301, 17817, 705, 8827, 768, 17227, 850, 3084, 11419, 13431, 17328, 17224, 877, 11271, 18058, 17353, 1532, 2494, 19792, 5938, 2473, 5387, 1571, 3019, 4978, 3097, 12978, 12542, 8575, 1605, 10183, 14470, 17700, 11348, 7127, 9745, 10133, 715, 18942, 5832, 11741, 2169, 18082, 17067, 9209, 16004, 4630, 12226, 11630, 3533, 946, 959, 4701, 18341, 12074, 1914, 16246, 17687, 3849, 17671, 4249, 8308, 14509, 9815, 3249, 2859, 19524, 9530, 4144, 8313, 7221, 817, 3553, 13960, 14198, 304, 7305, 4505, 13811, 8975, 18467, 753, 913, 5042, 659, 9225, 9770, 19360, 19274, 5214, 13500, 12446, 16867, 1271, 1584, 3433, 7661, 8268, 13818, 6351, 16480, 15101, 8082, 3317, 16313, 130, 17406, 10741, 4143, 11771, 14609, 11742, 3877, 14875, 19205, 3497, 7395, 9467, 9157, 14025, 13090, 165, 10256, 18931, 14814, 14775, 3951, 2282, 12377, 10766, 12644, 19038, 10687, 7461, 12495, 3366, 12671, 17597, 8730, 530, 11819, 19029, 15217, 7503, 10606, 1758, 8570, 1992, 2067, 18087, 16038, 18194, 19112, 19794, 13262, 16316, 4845, 9152, 8503, 1538, 16179, 15125, 18364, 13378, 19128, 15572, 1056, 16416, 2381, 15839, 10826, 9799, 737, 8627, 2207, 14061, 4948, 2754, 8326, 13056, 6206, 1960, 215, 14291, 14728, 14450, 19926, 10894, 14200, 16179, 18522, 3520, 9095, 7193, 4352, 16694, 665, 1840, 8376, 15035, 703, 12154, 19611, 6229, 7261, 6240, 17457, 10485, 17587, 19201, 11368, 2092, 827, 15447, 15333, 14219, 14910, 4074, 18650, 4679, 15646, 10162, 2217, 6202, 17318, 7307, 705, 13545, 4276, 5513, 13396, 3109, 14378, 13292, 12354, 14052, 2350, 13987, 7030, 8489, 16993, 9442, 13307, 14999, 4812, 16430, 2694, 13648, 11861, 10133, 1784, 16592, 3191, 3698, 19389, 10541, 9938, 13409, 8912, 19955, 5536, 3913, 6209, 12075, 5806, 8260, 7714, 7536, 3094, 1281, 11870, 924, 17045, 10161, 7686, 6204, 16856, 7219, 1391, 888, 4613, 7057, 1685, 14143, 3729, 16805, 19918, 10681, 13903, 1813, 4115, 8941, 5075, 7075, 2954, 13081, 3233, 1233, 9194, 16553, 8716, 15159, 10555, 10580, 18264, 861, 19548, 13030, 16012, 13186, 13686, 2719, 12019, 8024, 15343, 18479, 2229, 12066, 8346, 9002, 8342, 17034, 13633, 1281, 17167, 2929, 15850, 9970, 7208, 14606, 2971, 15623, 18026, 4839, 12173, 9455, 16502, 11105, 15880, 2869, 17258, 6889, 14670, 717, 8128, 1396, 16923, 17052, 11733, 4475, 10852, 11167, 12888, 193, 8211, 11683, 1526, 9274, 13414, 15336, 5012, 9578, 5823, 1407, 10215, 18063, 4694, 7181, 15852, 5889, 1978, 11125, 16187, 5477, 11745, 1454, 2365, 12916, 13154, 15771, 6007, 18798, 18238, 2733, 3755, 11805, 2736, 17834, 16628, 490, 7929, 7229, 17691, 544, 17858, 7680, 1066, 13263, 10503, 10065, 16703, 9742, 1200, 5845, 2498, 19728, 14980, 7411, 8449, 6758, 9319, 8610, 16121, 17643, 9329, 6214, 11340, 3090, 17653, 18411, 15327, 6861, 10554, 15362, 17960, 14750, 13434, 15643, 7620, 4065, 388, 9102, 2414, 3090, 19069, 16265, 17599, 12394, 236, 4027, 16825, 15326, 9385, 9870, 11172, 19319, 11108, 48, 11216, 11645, 16341, 17977, 15611, 12093, 14738, 9842, 19189, 5839, 7885, 7749, 6294, 19338 };

        //    var result = Program.Solve(numbers);
        //    Assert.AreEqual(165, result.number);
        //    Assert.AreEqual(4902484, result.newNumber);
        //}
    }
}
