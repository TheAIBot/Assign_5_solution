using Assign_5_solution;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod001()
        {
            int[] numbers = new int[] { 7, 9, 14, 13, 42, 9 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(9, result.number);
            Assert.AreEqual(61, result.newNumber);
        }

        [TestMethod]
        public void TestMethod002()
        {
            int[] numbers = new int[] { 1, 1, 1 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1, result.number);
            Assert.AreEqual(3, result.newNumber);
        }

        [TestMethod]
        public void TestMethod003()
        {
            int[] numbers = new int[] { 1, 1, 1, 1 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1, result.number);
            Assert.AreEqual(4, result.newNumber);
        }

        [TestMethod]
        public void TestMethod004()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1, result.number);
            Assert.AreEqual(53, result.newNumber);
        }

        [TestMethod]
        public void TestMethod005()
        {
            int[] numbers = new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(10, result.number);
            Assert.AreEqual(1, result.newNumber);
        }

        [TestMethod]
        public void TestMethod006()
        {
            int[] numbers = new int[] { 10, 10, 10 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(10, result.number);
            Assert.AreEqual(1, result.newNumber);
        }

        [TestMethod]
        public void TestMethod007()
        {
            int[] numbers = new int[] { 1, 1, 2, 2, 3, 3, 4, 4 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1, result.number);
            Assert.AreEqual(20, result.newNumber);
        }

        [TestMethod]
        public void TestMethod008()
        {
            int[] numbers = new int[] { 1, 1, 2, 4, 8, 16, 32, 64, 128, 256 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1, result.number);
            Assert.AreEqual(512, result.newNumber);
        }

        [TestMethod]
        public void TestMethod009()
        {
            int[] numbers = new int[] { 11, 11, 11, 11, 11, 11, 11, 11, 11, 11 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(11, result.number);
            Assert.AreEqual(1, result.newNumber);
        }

        [TestMethod]
        public void TestMethod010()
        {
            int[] numbers = new int[] { 7, 2, 2, 6, 2, 3, 8, 6, 2, 8 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(2, result.number);
            Assert.AreEqual(43, result.newNumber);
        }

        [TestMethod]
        public void TestMethod011()
        {
            int[] numbers = new int[] { 24, 26, 51, 33, 39, 27, 52, 4, 82, 58 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(27, result.number);
            Assert.AreEqual(301, result.newNumber);
        }

        [TestMethod]
        public void TestMethod012()
        {
            int[] numbers = new int[] { 398, 153, 91, 706, 817, 540, 45, 712, 148, 907 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(706, result.number);
            Assert.AreEqual(261, result.newNumber);
        }

        [TestMethod]
        public void TestMethod013()
        {
            int[] numbers = new int[] { 6, 1, 5, 10, 12, 15 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(5, result.number);
            Assert.AreEqual(35, result.newNumber);
        }

        [TestMethod]
        public void TestMethod014()
        {
            int[] numbers = new int[] { 4, 3, 1, 1, 2 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1, result.number);
            Assert.AreEqual(11, result.newNumber);
        }

        [TestMethod]
        public void TestMethod015()
        {
            int[] numbers = new int[] { 584, 822, 4, 536, 806 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(4, result.number);
            Assert.AreEqual(1, result.newNumber);
        }

        [TestMethod]
        public void TestMethod016()
        {
            int[] numbers = new int[] { 8, 4, 2, 1, 1, 8, 7, 2, 3, 8 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1, result.number);
            Assert.AreEqual(44, result.newNumber);
        }

        [TestMethod]
        public void TestMethod017()
        {
            int[] numbers = new int[] { 3, 7, 2, 1, 7, 6, 1, 5, 8 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1, result.number);
            Assert.AreEqual(40, result.newNumber);
        }


        [TestMethod]
        public void TestMethod018()
        {
            int[] numbers = new int[] { 63, 22, 2, 37, 27, 7, 72, 8 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(8, result.number);
            Assert.AreEqual(146, result.newNumber);
        }

        [TestMethod]
        public void TestMethod019()
        {
            int[] numbers = new int[] { 465, 13, 798, 440, 514, 500, 9 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(9, result.number);
            Assert.AreEqual(3, result.newNumber);
        }

        [TestMethod]
        public void TestMethod020()
        {
            int[] numbers = new int[] { 1658, 26, 7, 128, 1309, 70, 1828, 1858, 923, 751 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(26, result.number);
            Assert.AreEqual(8, result.newNumber);
        }

        [TestMethod]
        public void TestMethod021()
        {
            int[] numbers = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1, result.number);
            Assert.AreEqual(100, result.newNumber);
        }

        [TestMethod]
        public void TestMethod022()
        {
            int[] numbers = new int[] { 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(101, result.number);
            Assert.AreEqual(1, result.newNumber);
        }

        [TestMethod]
        public void TestMethod023()
        {
            int[] numbers = new int[] { 669, 141, 126, 523, 169, 263, 725, 513, 174, 762, 235, 258, 506, 321, 381, 261, 518, 36, 815, 578, 398, 153, 91, 706, 817, 540, 45, 712, 148, 907, 693, 517, 187, 42, 309, 584, 822, 4, 536, 806, 749, 385, 150, 27, 52, 782, 627, 116, 250, 773 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(36, result.number);
            Assert.AreEqual(20739, result.newNumber);
        }

        [TestMethod]
        public void TestMethod024()
        {
            int[] numbers = new int[] { 29, 65, 15, 5, 61, 52, 6, 43, 71, 63, 22, 2, 37, 27, 7, 72, 8, 47, 2, 80, 44, 52, 50, 1, 83, 2, 1, 7, 66, 4, 92, 93, 47, 38, 62, 5, 38, 15, 44, 80, 54, 41, 30, 91, 59, 74, 2, 89, 96, 34, 72, 17, 11, 46, 34, 78, 15, 14, 22, 60, 52, 99, 77, 68, 72, 29, 56, 99, 66, 3, 35, 93, 3, 22, 27, 4, 22, 60, 43, 10, 100, 13, 11, 33, 33, 76, 83, 1, 5, 85, 90, 24, 93, 85, 28, 55, 64, 63, 20, 30, 19, 3, 24, 94, 99, 79, 14, 89, 19, 30, 56, 56, 72, 13, 60, 40, 89, 45, 35, 97, 47, 55, 95, 82, 13, 11, 1, 19, 95, 73, 41, 60, 41, 13, 92, 97, 90, 18, 34, 55, 62, 95, 83, 75, 29, 34, 53, 81, 25, 89 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1, result.number);
            Assert.AreEqual(7100, result.newNumber);
        }

        [TestMethod]
        public void TestMethod025()
        {
            int[] numbers = new int[] { 6645, 1896, 2772, 2286, 8337, 6401, 819, 4206, 8052, 8801, 7788, 9534, 9431, 4667, 8908, 9692, 1562, 5876, 2113, 6343, 5010, 7083, 1111, 8061, 3479, 5213, 7207, 2005, 5299, 7887, 5818, 1986, 9348, 523, 557, 2145, 3137, 1716, 2914, 2707, 8821, 4701, 3675, 4538, 7635, 6626, 9994, 3558, 8566, 3114, 1836, 9381, 5931, 6129, 3871, 9562, 786, 4712, 8807, 3125, 9194, 8815, 8907, 166, 2984, 5803, 187, 8908, 4110, 6764, 6556, 9847, 2962, 9406, 7523, 309, 3409, 6573, 426, 6854, 5219, 3650, 3439, 2186, 6052, 6437, 6055, 3220, 6652, 996, 1360, 8426, 2909, 9790, 3514, 7, 5794, 3510, 1555, 1832, 6440, 1086, 9449, 1803, 6558, 1989, 6419, 6525, 8607, 3563, 6154, 4213, 4286, 1954, 7906, 5544, 5376, 6722, 4114, 6547, 9748, 6968, 2256, 3114, 5405, 8130, 6938, 3173, 5893, 7516, 4516, 9899, 5019, 8595, 414, 4134, 4202, 1637, 5628, 4063, 19, 9531, 4613, 3090, 4843, 7147, 4141, 956, 1885, 7970, 4632, 9072, 9397, 5008, 2085, 9473, 8830, 6335, 6399, 8429, 5051, 3246, 633, 1091, 9048, 6256, 9195, 5691, 1540, 3772, 1343, 3739, 1095, 51, 6529, 218, 2355, 9167, 8272, 8258, 3990, 5983, 1289, 7924, 2885, 5444, 502, 11, 6511, 942, 5304, 7868, 5239, 7199, 9013, 6773, 8899, 3523, 4043, 8588, 7952, 8450, 9416, 8113, 6627, 893, 7978, 9346, 8479, 1868, 7119, 9664, 8064, 8141, 4439, 9068, 1958, 2709, 8207, 3604, 5754, 9185, 9181, 599, 8468, 3476, 8501, 3896, 1039, 9757, 1319, 8832, 5124, 9684, 307, 5541, 6568, 3177, 1297, 1993, 7467, 1157, 1532, 4644, 3824, 5641, 9805, 7098, 2761, 9945, 4815, 6190, 5317, 439, 2834, 8768, 9269, 8817, 9645, 3152, 2392, 4082, 8308, 8723, 549, 8287, 4540, 8380, 7835, 8899, 2501, 8781, 1413, 6214, 6138, 4598, 7653, 4538, 6776, 2828, 3672, 1403, 1136, 1094, 4942, 5130, 3516, 4685, 6851, 1540, 6273, 7751, 3533, 8145, 9601, 3385, 2849, 2810, 4095, 5537 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(19, result.number);
            Assert.AreEqual(1571551, result.newNumber);
        }

        [TestMethod]
        public void TestMethod026()
        {
            int[] numbers = new int[] { 2203, 2850, 18528, 7725, 14888, 12068, 9555, 18205, 8603, 16474, 2229, 9461, 4083, 13634, 18962, 1978, 5893, 14428, 7561, 10838, 9542, 19709, 3059, 12590, 5253, 9501, 10498, 6536, 13227, 5506, 3497, 9687, 886, 2478, 3452, 4493, 4279, 14546, 7301, 17817, 705, 8827, 768, 17227, 850, 3084, 11419, 13431, 17328, 17224, 877, 11271, 18058, 17353, 1532, 2494, 19792, 5938, 2473, 5387, 1571, 3019, 4978, 3097, 12978, 12542, 8575, 1605, 10183, 14470, 17700, 11348, 7127, 9745, 10133, 715, 18942, 5832, 11741, 2169, 18082, 17067, 9209, 16004, 4630, 12226, 11630, 3533, 946, 959, 4701, 18341, 12074, 1914, 16246, 17687, 3849, 17671, 4249, 8308, 14509, 9815, 3249, 2859, 19524, 9530, 4144, 8313, 7221, 817, 3553, 13960, 14198, 304, 7305, 4505, 13811, 8975, 18467, 753, 913, 5042, 659, 9225, 9770, 19360, 19274, 5214, 13500, 12446, 16867, 1271, 1584, 3433, 7661, 8268, 13818, 6351, 16480, 15101, 8082, 3317, 16313, 130, 17406, 10741, 4143, 11771, 14609, 11742, 3877, 14875, 19205, 3497, 7395, 9467, 9157, 14025, 13090, 165, 10256, 18931, 14814, 14775, 3951, 2282, 12377, 10766, 12644, 19038, 10687, 7461, 12495, 3366, 12671, 17597, 8730, 530, 11819, 19029, 15217, 7503, 10606, 1758, 8570, 1992, 2067, 18087, 16038, 18194, 19112, 19794, 13262, 16316, 4845, 9152, 8503, 1538, 16179, 15125, 18364, 13378, 19128, 15572, 1056, 16416, 2381, 15839, 10826, 9799, 737, 8627, 2207, 14061, 4948, 2754, 8326, 13056, 6206, 1960, 215, 14291, 14728, 14450, 19926, 10894, 14200, 16179, 18522, 3520, 9095, 7193, 4352, 16694, 665, 1840, 8376, 15035, 703, 12154, 19611, 6229, 7261, 6240, 17457, 10485, 17587, 19201, 11368, 2092, 827, 15447, 15333, 14219, 14910, 4074, 18650, 4679, 15646, 10162, 2217, 6202, 17318, 7307, 705, 13545, 4276, 5513, 13396, 3109, 14378, 13292, 12354, 14052, 2350, 13987, 7030, 8489, 16993, 9442, 13307, 14999, 4812, 16430, 2694, 13648, 11861, 10133, 1784, 16592, 3191, 3698, 19389, 10541, 9938, 13409, 8912, 19955, 5536, 3913, 6209, 12075, 5806, 8260, 7714, 7536, 3094, 1281, 11870, 924, 17045, 10161, 7686, 6204, 16856, 7219, 1391, 888, 4613, 7057, 1685, 14143, 3729, 16805, 19918, 10681, 13903, 1813, 4115, 8941, 5075, 7075, 2954, 13081, 3233, 1233, 9194, 16553, 8716, 15159, 10555, 10580, 18264, 861, 19548, 13030, 16012, 13186, 13686, 2719, 12019, 8024, 15343, 18479, 2229, 12066, 8346, 9002, 8342, 17034, 13633, 1281, 17167, 2929, 15850, 9970, 7208, 14606, 2971, 15623, 18026, 4839, 12173, 9455, 16502, 11105, 15880, 2869, 17258, 6889, 14670, 717, 8128, 1396, 16923, 17052, 11733, 4475, 10852, 11167, 12888, 193, 8211, 11683, 1526, 9274, 13414, 15336, 5012, 9578, 5823, 1407, 10215, 18063, 4694, 7181, 15852, 5889, 1978, 11125, 16187, 5477, 11745, 1454, 2365, 12916, 13154, 15771, 6007, 18798, 18238, 2733, 3755, 11805, 2736, 17834, 16628, 490, 7929, 7229, 17691, 544, 17858, 7680, 1066, 13263, 10503, 10065, 16703, 9742, 1200, 5845, 2498, 19728, 14980, 7411, 8449, 6758, 9319, 8610, 16121, 17643, 9329, 6214, 11340, 3090, 17653, 18411, 15327, 6861, 10554, 15362, 17960, 14750, 13434, 15643, 7620, 4065, 388, 9102, 2414, 3090, 19069, 16265, 17599, 12394, 236, 4027, 16825, 15326, 9385, 9870, 11172, 19319, 11108, 48, 11216, 11645, 16341, 17977, 15611, 12093, 14738, 9842, 19189, 5839, 7885, 7749, 6294, 19338 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(165, result.number);
            Assert.AreEqual(4902484, result.newNumber);
        }

        [TestMethod]
        public void TestMethod027()
        {
            int[] numbers = new int[] { 5, 11, 8, 2 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(2, result.number);
            Assert.AreEqual(1, result.newNumber);
        }

        [TestMethod]
        public void TestMethod028()
        {
            int[] numbers = new int[] { 3, 7, 4, 8 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(3, result.number);
            Assert.AreEqual(2, result.newNumber);
        }

        [TestMethod]
        public void TestMethod029()
        {
            int[] numbers = new int[] { 17, 3, 9, 6 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(3, result.number);
            Assert.AreEqual(1, result.newNumber);
        }

        [TestMethod]
        public void TestMethod030()
        {
            int[] numbers = new int[] { 16, 18, 4, 7 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(4, result.number);
            Assert.AreEqual(1, result.newNumber);
        }

        [TestMethod]
        public void TestMethod031()
        {
            int[] numbers = new int[] { 70, 72, 106, 134, 159, 220, 229, 315, 357, 509, 552, 581, 594, 622, 652, 662, 752, 856, 860, 877, 895, 931, 964, 985, 1027, 1053, 1064, 1112, 1409, 1418, 1529, 1973, 1983 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(70, result.number);
            Assert.AreEqual(24528, result.newNumber);
        }


        [TestMethod]
        public void TestMethod032()
        {
            int[] numbers = new int[] { 3, 12, 78, 90, 369, 432, 469, 477, 526, 531, 555, 567, 660, 723, 756, 791, 796, 806, 935, 1053, 1062, 1080, 1131, 1248, 1269, 1318, 1321, 1344, 1351, 1360, 1364, 1378, 1412, 1425, 1503, 1515, 1597, 1625, 1670, 1670, 1688, 1734, 1743, 1760, 1859, 1965 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(90, result.number);
            Assert.AreEqual(47714, result.newNumber);
        }


        [TestMethod]
        public void TestMethod033()
        {
            int[] numbers = new int[] { 48, 85, 92, 123, 297, 384, 392, 409, 466, 596, 698, 701, 733, 746, 794, 856, 883, 885, 942, 958, 1006, 1054, 1060, 1165, 1253, 1273, 1274, 1328, 1367, 1394, 1409, 1520, 1542, 1571, 1612, 1646, 1736, 1740, 1764, 1802, 1854, 1863, 1868, 1883, 1891, 1934 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(92, result.number);
            Assert.AreEqual(49586, result.newNumber);
        }


        [TestMethod]
        public void TestMethod034()
        {
            int[] numbers = new int[] { 85, 134, 208, 225, 343, 382, 394, 443, 449, 572, 610, 610, 688, 749, 798, 847, 922, 940, 996, 1004, 1066, 1071, 1151, 1180, 1219, 1242, 1303, 1328, 1354, 1378, 1449, 1548, 1614, 1637, 1652, 1693, 1704, 1728, 1734, 1768, 1845, 1906, 1933, 1955, 1962, 1997 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(85, result.number);
            Assert.AreEqual(50291, result.newNumber);
        }


        [TestMethod]
        public void TestMethod035()
        {
            int[] numbers = new int[] { 29, 255, 473, 532, 566, 636, 702, 798, 866, 931, 938, 1104, 1111, 1119, 1120, 1167, 1609, 1879, 1890, 1899, 1919, 1925 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(255, result.number);
            Assert.AreEqual(20263, result.newNumber);
        }


        [TestMethod]
        public void TestMethod036()
        {
            int[] numbers = new int[] { 54, 122, 123, 163, 279, 283, 409, 530, 630, 642, 738, 887, 907, 908, 967, 1035, 1147, 1167, 1179, 1274, 1277, 1281, 1368, 1375, 1448, 1457, 1490, 1516, 1552, 1649, 1744, 1885, 1907, 1957, 1984, 1990 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(122, result.number);
            Assert.AreEqual(37808, result.newNumber);
        }


        [TestMethod]
        public void TestMethod037()
        {
            int[] numbers = new int[] { 101, 235, 470, 515, 550, 580, 661, 673, 753, 979, 1071, 1076, 1108, 1161, 1211, 1249, 1282, 1437, 1448, 1592, 1666, 1674, 1727, 1831, 1869, 1900, 1904, 1934, 1934 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(101, result.number);
            Assert.AreEqual(31572, result.newNumber);
        }


        [TestMethod]
        public void TestMethod038()
        {
            int[] numbers = new int[] { 6, 63, 77, 154, 200, 261, 307, 348, 417, 558, 596, 685, 710, 718, 810, 929, 988, 1327, 1329, 1376, 1429, 1437, 1460, 1483, 1510, 1549, 1624, 1648, 1741, 1841 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(6, result.number);
            Assert.AreEqual(26290, result.newNumber);
        }


        [TestMethod]
        public void TestMethod039()
        {
            int[] numbers = new int[] { 12, 39, 80, 208, 353, 395, 401, 405, 441, 474, 654, 795, 997, 1090, 1225, 1226, 1313, 1334, 1368, 1766, 1884, 1894 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(80, result.number);
            Assert.AreEqual(17081, result.newNumber);
        }


        [TestMethod]
        public void TestMethod040()
        {
            int[] numbers = new int[] { 96, 117, 179, 212, 259, 277, 280, 340, 434, 677, 982, 1057, 1122, 1123, 1159, 1272, 1284, 1333, 1368, 1369, 1376, 1407, 1422, 1427, 1448, 1467, 1469, 1476, 1622, 1702, 1806, 1906, 1990 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(96, result.number);
            Assert.AreEqual(33904, result.newNumber);
        }


        [TestMethod]
        public void TestMethod041()
        {
            int[] numbers = new int[] { 40, 68, 142, 273, 278, 324, 349, 351, 359, 698, 728, 935, 1019, 1025, 1032, 1218, 1282, 1380, 1462, 1544, 1628, 1641, 1689, 1859, 1892, 1934, 1984 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(68, result.number);
            Assert.AreEqual(25571, result.newNumber);
        }


        [TestMethod]
        public void TestMethod042()
        {
            int[] numbers = new int[] { 75, 195, 363, 390, 439, 635, 721, 777, 998, 1041, 1130, 1196, 1198, 1208, 1231, 1280, 1301, 1328, 1554, 1660, 1826, 1953, 1963 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(75, result.number);
            Assert.AreEqual(21136, result.newNumber);
        }


        [TestMethod]
        public void TestMethod043()
        {
            int[] numbers = new int[] { 52, 207, 237, 327, 374, 378, 463, 664, 837, 920, 1076, 1195, 1224, 1500, 1541, 1663, 1702, 1738, 1805, 1834, 1964, 1965 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(374, result.number);
            Assert.AreEqual(21107, result.newNumber);
        }


        [TestMethod]
        public void TestMethod044()
        {
            int[] numbers = new int[] { 182, 231, 388, 409, 494, 584, 746, 923, 924, 1018, 1044, 1110, 1361, 1367, 1440, 1594, 1689, 1698, 1700, 1779, 1981, 1983, 1986 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(182, result.number);
            Assert.AreEqual(23568, result.newNumber);
        }


        [TestMethod]
        public void TestMethod045()
        {
            int[] numbers = new int[] { 37, 42, 54, 80, 163, 226, 226, 265, 296, 362, 382, 484, 606, 607, 692, 694, 725, 779, 833, 882, 894, 906, 947, 1012, 1132, 1154, 1209, 1289, 1363, 1403, 1503, 1507, 1553, 1711, 1719, 1721, 1747, 1784, 1884, 1902, 1950 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(226, result.number);
            Assert.AreEqual(37970, result.newNumber);
        }


        [TestMethod]
        public void TestMethod046()
        {
            int[] numbers = new int[] { 32, 204, 231, 410, 519, 536, 551, 585, 633, 637, 663, 693, 698, 738, 753, 889, 921, 946, 978, 992, 1004, 1039, 1082, 1098, 1114, 1210, 1227, 1258, 1299, 1311, 1500, 1531, 1534, 1690, 1976 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(32, result.number);
            Assert.AreEqual(30546, result.newNumber);
        }


        [TestMethod]
        public void TestMethod047()
        {
            int[] numbers = new int[] { 184, 248, 316, 364, 390, 496, 500, 508, 603, 631, 649, 804, 815, 1095, 1317, 1343, 1482, 1485, 1523, 1553, 1826 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(184, result.number);
            Assert.AreEqual(15723, result.newNumber);
        }


        [TestMethod]
        public void TestMethod048()
        {
            int[] numbers = new int[] { 51, 52, 78, 142, 184, 185, 257, 269, 282, 287, 329, 361, 401, 419, 642, 759, 820, 859, 869, 973, 1020, 1087, 1109, 1160, 1163, 1316, 1388, 1544, 1590, 1642, 1659, 1674, 1754, 1771, 1771, 1825, 1858, 1902, 1941 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(52, result.number);
            Assert.AreEqual(36657, result.newNumber);
        }


        [TestMethod]
        public void TestMethod049()
        {
            int[] numbers = new int[] { 30, 92, 99, 169, 192, 237, 446, 542, 594, 662, 673, 837, 895, 928, 1010, 1031, 1049, 1087, 1112, 1130, 1184, 1330, 1377, 1420, 1488, 1710, 1752, 1762, 1945 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(92, result.number);
            Assert.AreEqual(25411, result.newNumber);
        }


        [TestMethod]
        public void TestMethod050()
        {
            int[] numbers = new int[] { 38, 48, 117, 139, 140, 214, 289, 296, 301, 478, 483, 582, 586, 595, 598, 609, 619, 715, 728, 752, 756, 844, 857, 893, 895, 951, 975, 1011, 1093, 1098, 1136, 1150, 1153, 1292, 1390, 1405, 1420, 1433, 1506, 1549, 1657, 1722, 1732, 1807, 1824, 1838, 1872, 1896, 1908, 1951 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(38, result.number);
            Assert.AreEqual(48539, result.newNumber);
        }


        [TestMethod]
        public void TestMethod051()
        {
            int[] numbers = new int[] { 32, 36, 133, 142, 144, 158, 243, 256, 388, 439, 631, 691, 837, 1133, 1379, 1439, 1508, 1543, 1784, 1835, 1845, 1914, 1976, 1978 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(243, result.number);
            Assert.AreEqual(21550, result.newNumber);
        }


        [TestMethod]
        public void TestMethod052()
        {
            int[] numbers = new int[] { 81, 104, 187, 304, 324, 443, 470, 494, 494, 505, 512, 695, 705, 714, 725, 740, 764, 867, 880, 907, 972, 1089, 1141, 1150, 1283, 1387, 1410, 1482, 1485, 1518, 1592, 1609, 1612, 1632, 1682, 1958 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(104, result.number);
            Assert.AreEqual(32408, result.newNumber);
        }


        [TestMethod]
        public void TestMethod053()
        {
            int[] numbers = new int[] { 133, 139, 197, 299, 305, 345, 510, 513, 551, 603, 744, 809, 903, 1307, 1322, 1349, 1376, 1450, 1466, 1690, 1772, 1826, 1876 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(299, result.number);
            Assert.AreEqual(19605, result.newNumber);
        }


        [TestMethod]
        public void TestMethod054()
        {
            int[] numbers = new int[] { 9, 206, 212, 362, 390, 391, 428, 641, 745, 765, 782, 846, 870, 878, 1014, 1062, 1285, 1294, 1364, 1396, 1530, 1560, 1691, 1817, 1830, 1831, 1954, 1960 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(9, result.number);
            Assert.AreEqual(27073, result.newNumber);
        }


        [TestMethod]
        public void TestMethod055()
        {
            int[] numbers = new int[] { 48, 56, 126, 133, 141, 160, 232, 355, 408, 499, 525, 809, 826, 892, 979, 1006, 1013, 1073, 1086, 1294, 1298, 1313, 1459, 1481, 1498, 1551, 1635, 1669, 1711, 1745, 1834, 1889, 1890, 1891, 1939, 1987 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(141, result.number);
            Assert.AreEqual(37412, result.newNumber);
        }


        [TestMethod]
        public void TestMethod056()
        {
            int[] numbers = new int[] { 76, 183, 212, 267, 290, 299, 301, 568, 612, 687, 690, 714, 818, 839, 866, 881, 895, 902, 903, 930, 975, 1017, 1026, 1039, 1056, 1192, 1265, 1321, 1403, 1419, 1421, 1424, 1469, 1475, 1495, 1542, 1561, 1597, 1606, 1623, 1801, 1823, 1840 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(76, result.number);
            Assert.AreEqual(42731, result.newNumber);
        }


        [TestMethod]
        public void TestMethod057()
        {
            int[] numbers = new int[] { 24, 167, 178, 183, 204, 339, 363, 408, 442, 541, 651, 688, 820, 863, 983, 999, 1121, 1145, 1192, 1220, 1235, 1244, 1262, 1309, 1330, 1514, 1550, 1581, 1616, 1651, 1775, 1848, 1916, 1920, 1935 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(24, result.number);
            Assert.AreEqual(34694, result.newNumber);
        }


        [TestMethod]
        public void TestMethod058()
        {
            int[] numbers = new int[] { 162, 177, 216, 259, 322, 323, 456, 467, 494, 658, 752, 760, 824, 852, 950, 1061, 1063, 1093, 1096, 1156, 1158, 1251, 1367, 1396, 1448, 1449, 1693, 1711, 1748, 1749, 1838, 1900, 1918, 1946, 1980, 1990 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(259, result.number);
            Assert.AreEqual(37870, result.newNumber);
        }


        [TestMethod]
        public void TestMethod059()
        {
            int[] numbers = new int[] { 18, 18, 199, 231, 305, 393, 439, 446, 449, 459, 490, 534, 565, 576, 671, 685, 744, 745, 784, 788, 874, 916, 941, 995, 1045, 1073, 1093, 1121, 1137, 1173, 1255, 1259, 1274, 1349, 1380, 1417, 1451, 1472, 1624, 1727, 1796, 1801, 1963 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(18, result.number);
            Assert.AreEqual(38554, result.newNumber);
        }


        [TestMethod]
        public void TestMethod060()
        {
            int[] numbers = new int[] { 1, 129, 132, 225, 314, 385, 387, 409, 413, 473, 486, 510, 537, 627, 708, 816, 920, 1041, 1113, 1126, 1225, 1325, 1350, 1373, 1598, 1647, 1771, 1782 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1, result.number);
            Assert.AreEqual(21495, result.newNumber);
        }


        [TestMethod]
        public void TestMethod061()
        {
            int[] numbers = new int[] { 80, 106, 141, 148, 158, 236, 251, 256, 309, 334, 334, 375, 403, 422, 443, 448, 520, 628, 656, 678, 868, 965, 1121, 1175, 1227, 1332, 1366, 1391, 1411, 1427, 1474, 1631, 1876, 1962, 1976, 1979 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(80, result.number);
            Assert.AreEqual(29272, result.newNumber);
        }


        [TestMethod]
        public void TestMethod062()
        {
            int[] numbers = new int[] { 62, 111, 151, 230, 261, 265, 609, 619, 647, 688, 720, 745, 777, 992, 1033, 1157, 1345, 1388, 1463, 1604, 1608, 1652, 1805, 1882 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(111, result.number);
            Assert.AreEqual(19981, result.newNumber);
        }


        [TestMethod]
        public void TestMethod063()
        {
            int[] numbers = new int[] { 8, 30, 218, 263, 275, 294, 352, 373, 414, 446, 598, 613, 638, 704, 796, 805, 840, 856, 885, 945, 948, 1267, 1327, 1354, 1358, 1397, 1488, 1547, 1589, 1636, 1645, 1667, 1680, 1682, 1687, 1861, 1902, 1974, 1993 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(8, result.number);
            Assert.AreEqual(39185, result.newNumber);
        }


        [TestMethod]
        public void TestMethod064()
        {
            int[] numbers = new int[] { 22, 137, 159, 194, 211, 305, 383, 386, 400, 401, 404, 414, 577, 596, 606, 824, 967, 997, 998, 999, 1005, 1160, 1201, 1202, 1204, 1221, 1338, 1390, 1408, 1417, 1433, 1589, 1600, 1708, 1741, 1759, 1893, 1936, 1940, 1995 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(22, result.number);
            Assert.AreEqual(38999, result.newNumber);
        }


        [TestMethod]
        public void TestMethod065()
        {
            int[] numbers = new int[] { 7, 138, 143, 206, 398, 474, 533, 543, 720, 805, 984, 1057, 1102, 1168, 1192, 1359, 1395, 1597, 1614, 1646, 1673, 1683, 1862 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(7, result.number);
            Assert.AreEqual(20241, result.newNumber);
        }


        [TestMethod]
        public void TestMethod066()
        {
            int[] numbers = new int[] { 99, 145, 188, 349, 350, 360, 453, 548, 594, 715, 772, 795, 800, 804, 820, 875, 966, 1085, 1312, 1404, 1405, 1420, 1437, 1451, 1593, 1744, 1794, 1858, 1885 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(188, result.number);
            Assert.AreEqual(26202, result.newNumber);
        }


        [TestMethod]
        public void TestMethod067()
        {
            int[] numbers = new int[] { 17, 199, 264, 278, 286, 433, 578, 603, 606, 632, 645, 722, 803, 806, 826, 915, 945, 1020, 1052, 1062, 1095, 1098, 1102, 1124, 1174, 1202, 1206, 1207, 1211, 1308, 1338, 1347, 1384, 1424, 1508, 1529, 1537, 1652, 1657, 1722, 1741, 1792, 1850 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(17, result.number);
            Assert.AreEqual(43198, result.newNumber);
        }


        [TestMethod]
        public void TestMethod068()
        {
            int[] numbers = new int[] { 2, 37, 75, 119, 176, 201, 224, 262, 323, 340, 383, 397, 405, 420, 442, 456, 532, 639, 732, 785, 810, 824, 842, 851, 897, 903, 938, 942, 951, 991, 993, 997, 1071, 1266, 1361, 1398, 1530, 1538, 1626, 1663, 1704, 1757, 1789, 1816, 1846, 1856, 1935 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(119, result.number);
            Assert.AreEqual(41359, result.newNumber);
        }


        [TestMethod]
        public void TestMethod069()
        {
            int[] numbers = new int[] { 23, 210, 357, 386, 506, 533, 534, 712, 860, 866, 912, 955, 993, 995, 1021, 1025, 1032, 1105, 1136, 1277, 1282, 1459, 1597, 1796, 1834, 1860, 1938, 1964 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(357, result.number);
            Assert.AreEqual(26632, result.newNumber);
        }


        [TestMethod]
        public void TestMethod070()
        {
            int[] numbers = new int[] { 78, 318, 345, 346, 391, 514, 581, 665, 686, 861, 919, 1012, 1023, 1127, 1170, 1196, 1241, 1266, 1351, 1395, 1412, 1584, 1734, 1803, 1955 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(78, result.number);
            Assert.AreEqual(22570, result.newNumber);
        }


        [TestMethod]
        public void TestMethod071()
        {
            int[] numbers = new int[] { 189, 244, 283, 363, 422, 470, 470, 555, 555, 613, 677, 751, 765, 822, 945, 976, 1038, 1163, 1228, 1267, 1286, 1401, 1454, 1483, 1515, 1568, 1783, 1783, 1785, 1919 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(470, result.number);
            Assert.AreEqual(27392, result.newNumber);
        }


        [TestMethod]
        public void TestMethod072()
        {
            int[] numbers = new int[] { 111, 133, 173, 196, 371, 379, 432, 517, 577, 592, 690, 693, 730, 840, 845, 881, 908, 1051, 1084, 1104, 1107, 1171, 1179, 1229, 1376, 1390, 1396, 1444, 1536, 1605, 1616, 1627, 1715, 1756, 1805, 1808, 1827, 1867, 1896, 1924, 1981 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(173, result.number);
            Assert.AreEqual(43869, result.newNumber);
        }


        [TestMethod]
        public void TestMethod073()
        {
            int[] numbers = new int[] { 16, 70, 87, 89, 116, 137, 216, 223, 264, 304, 306, 362, 431, 456, 489, 529, 571, 607, 621, 710, 712, 825, 852, 866, 895, 975, 1063, 1131, 1132, 1217, 1240, 1375, 1378, 1384, 1408, 1464, 1501, 1505, 1547, 1562, 1563, 1590, 1626, 1801, 1979 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(89, result.number);
            Assert.AreEqual(38592, result.newNumber);
        }


        [TestMethod]
        public void TestMethod074()
        {
            int[] numbers = new int[] { 17, 33, 71, 91, 132, 149, 157, 186, 189, 208, 222, 373, 382, 385, 397, 489, 526, 531, 646, 647, 672, 714, 716, 876, 892, 951, 984, 1034, 1065, 1147, 1154, 1196, 1260, 1264, 1297, 1298, 1543, 1651, 1655, 1812, 1812, 1827, 1831, 1897, 1932, 1963, 1979, 1981 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(17, result.number);
            Assert.AreEqual(43694, result.newNumber);
        }


        [TestMethod]
        public void TestMethod075()
        {
            int[] numbers = new int[] { 40, 98, 119, 129, 140, 202, 258, 315, 336, 418, 451, 456, 461, 508, 546, 548, 613, 624, 661, 715, 734, 882, 994, 1020, 1059, 1090, 1108, 1112, 1125, 1256, 1336, 1383, 1400, 1611, 1676, 1758, 1772, 1783, 1796, 1835, 1839, 1897, 1948, 1958 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(119, result.number);
            Assert.AreEqual(41072, result.newNumber);
        }


        [TestMethod]
        public void TestMethod076()
        {
            int[] numbers = new int[] { 47, 221, 255, 389, 424, 476, 533, 648, 764, 775, 1061, 1148, 1436, 1500, 1583, 1778, 1817, 1832, 1834, 1854 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(255, result.number);
            Assert.AreEqual(17687, result.newNumber);
        }


        [TestMethod]
        public void TestMethod077()
        {
            int[] numbers = new int[] { 23, 93, 96, 238, 259, 279, 283, 296, 353, 400, 423, 482, 509, 561, 579, 692, 713, 724, 764, 783, 996, 1123, 1165, 1346, 1348, 1400, 1411, 1422, 1516, 1621, 1651, 1666, 1731, 1776, 1849, 1950, 1959, 1975, 1981 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(23, result.number);
            Assert.AreEqual(37344, result.newNumber);
        }


        [TestMethod]
        public void TestMethod078()
        {
            int[] numbers = new int[] { 187, 222, 255, 273, 319, 381, 493, 645, 647, 685, 860, 1041, 1078, 1198, 1249, 1370, 1376, 1527, 1574, 1598, 1666, 1866, 1866, 1917, 1968, 1990 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(187, result.number);
            Assert.AreEqual(25937, result.newNumber);
        }


        [TestMethod]
        public void TestMethod079()
        {
            int[] numbers = new int[] { 46, 68, 69, 105, 157, 252, 433, 440, 458, 469, 507, 584, 610, 616, 625, 652, 656, 691, 775, 919, 942, 1068, 1138, 1139, 1149, 1201, 1314, 1445, 1493, 1515, 1537, 1594, 1632, 1696, 1707, 1762, 1875 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(46, result.number);
            Assert.AreEqual(32325, result.newNumber);
        }


        [TestMethod]
        public void TestMethod080()
        {
            int[] numbers = new int[] { 36, 152, 154, 176, 281, 303, 401, 436, 470, 510, 604, 699, 728, 736, 741, 745, 973, 1069, 1089, 1093, 1191, 1310, 1415, 1452, 1500, 1517, 1558, 1606, 1711, 1728, 1775, 1849, 1898 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(176, result.number);
            Assert.AreEqual(30416, result.newNumber);
        }


        [TestMethod]
        public void TestMethod081()
        {
            int[] numbers = new int[] { 18, 29, 29, 106, 155, 262, 267, 301, 317, 413, 416, 422, 483, 505, 621, 647, 812, 890, 892, 997, 1024, 1053, 1072, 1099, 1228, 1237, 1298, 1327, 1350, 1363, 1388, 1424, 1425, 1520, 1665, 1671, 1717, 1718, 1877, 1883, 1887, 1921, 1946 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(29, result.number);
            Assert.AreEqual(41955, result.newNumber);
        }


        [TestMethod]
        public void TestMethod082()
        {
            int[] numbers = new int[] { 27, 147, 205, 216, 220, 289, 293, 304, 408, 466, 477, 484, 514, 564, 624, 680, 690, 732, 742, 764, 849, 903, 1010, 1062, 1073, 1102, 1120, 1131, 1152, 1162, 1204, 1227, 1269, 1305, 1333, 1349, 1393, 1463, 1485, 1551, 1552, 1577, 1610, 1788, 1824, 1859, 1886, 1893, 1963 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(147, result.number);
            Assert.AreEqual(47863, result.newNumber);
        }


        [TestMethod]
        public void TestMethod083()
        {
            int[] numbers = new int[] { 17, 22, 126, 144, 147, 247, 326, 351, 556, 600, 617, 652, 668, 669, 736, 762, 770, 832, 867, 912, 1002, 1084, 1100, 1136, 1180, 1189, 1282, 1320, 1456, 1471, 1572, 1675, 1698, 1704, 1797, 1890 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(17, result.number);
            Assert.AreEqual(31515, result.newNumber);
        }


        [TestMethod]
        public void TestMethod084()
        {
            int[] numbers = new int[] { 2, 18, 27, 172, 184, 219, 221, 225, 276, 318, 340, 385, 419, 454, 517, 627, 663, 829, 900, 915, 940, 957, 1098, 1117, 1149, 1153, 1173, 1198, 1256, 1294, 1314, 1376, 1392, 1449, 1479, 1575, 1588, 1602, 1667, 1695, 1708, 1880, 1916 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(2, result.number);
            Assert.AreEqual(39087, result.newNumber);
        }


        [TestMethod]
        public void TestMethod085()
        {
            int[] numbers = new int[] { 49, 59, 102, 115, 124, 124, 193, 222, 234, 242, 304, 501, 579, 620, 643, 649, 687, 781, 860, 862, 872, 888, 895, 933, 997, 1044, 1075, 1077, 1084, 1104, 1171, 1310, 1429, 1436, 1514, 1585, 1658, 1747, 1776, 1835, 1902, 1908, 1958, 1959 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(124, result.number);
            Assert.AreEqual(40369, result.newNumber);
        }


        [TestMethod]
        public void TestMethod086()
        {
            int[] numbers = new int[] { 14, 89, 218, 456, 481, 563, 631, 742, 790, 974, 1002, 1002, 1079, 1197, 1355, 1490, 1503, 1527, 1656, 1725, 1751, 1806, 1822, 1977 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(14, result.number);
            Assert.AreEqual(23360, result.newNumber);
        }


        [TestMethod]
        public void TestMethod087()
        {
            int[] numbers = new int[] { 45, 48, 111, 146, 153, 216, 225, 252, 482, 501, 608, 731, 751, 791, 838, 869, 954, 984, 989, 1014, 1015, 1022, 1075, 1119, 1130, 1136, 1177, 1239, 1332, 1341, 1446, 1466, 1534, 1571, 1576, 1650, 1857, 1892 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(153, result.number);
            Assert.AreEqual(34370, result.newNumber);
        }


        [TestMethod]
        public void TestMethod088()
        {
            int[] numbers = new int[] { 51, 115, 124, 167, 223, 224, 241, 360, 390, 394, 408, 547, 587, 622, 634, 706, 736, 740, 805, 822, 897, 937, 969, 992, 1032, 1078, 1107, 1175, 1175, 1223, 1225, 1289, 1334, 1385, 1409, 1412, 1424, 1511, 1621, 1643, 1746, 1770, 1803, 1816, 1824, 1868, 1879, 1911, 1989, 1997 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(167, result.number);
            Assert.AreEqual(51286, result.newNumber);
        }


        [TestMethod]
        public void TestMethod089()
        {
            int[] numbers = new int[] { 139, 186, 303, 327, 368, 434, 491, 806, 816, 835, 952, 1002, 1019, 1034, 1150, 1162, 1300, 1426, 1531, 1721, 1743 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(186, result.number);
            Assert.AreEqual(16058, result.newNumber);
        }


        [TestMethod]
        public void TestMethod090()
        {
            int[] numbers = new int[] { 46, 62, 127, 160, 217, 434, 540, 590, 635, 685, 790, 849, 900, 981, 987, 997, 1010, 1072, 1077, 1077, 1101, 1166, 1545, 1587, 1637, 1663, 1676 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(62, result.number);
            Assert.AreEqual(22067, result.newNumber);
        }


        [TestMethod]
        public void TestMethod091()
        {
            int[] numbers = new int[] { 52, 76, 84, 132, 134, 141, 179, 191, 362, 390, 445, 576, 601, 607, 643, 684, 761, 837, 839, 952, 995, 1062, 1113, 1140, 1265, 1290, 1305, 1315, 1315, 1339, 1453, 1476, 1485, 1556, 1595, 1617, 1641, 1733, 1787, 1853, 1904 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(134, result.number);
            Assert.AreEqual(38219, result.newNumber);
        }


        [TestMethod]
        public void TestMethod092()
        {
            int[] numbers = new int[] { 49, 51, 113, 115, 119, 170, 177, 182, 257, 263, 340, 346, 497, 576, 585, 646, 699, 827, 850, 856, 932, 996, 1042, 1129, 1212, 1248, 1262, 1307, 1320, 1322, 1343, 1447, 1463, 1539, 1542, 1564, 1655, 1664, 1666, 1675, 1719, 1845, 1876, 1882, 1927 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(51, result.number);
            Assert.AreEqual(43639, result.newNumber);
        }


        [TestMethod]
        public void TestMethod093()
        {
            int[] numbers = new int[] { 68, 103, 117, 193, 348, 351, 353, 363, 385, 397, 407, 431, 434, 447, 530, 545, 548, 679, 708, 808, 814, 832, 864, 900, 910, 949, 949, 1067, 1150, 1166, 1231, 1270, 1297, 1303, 1321, 1325, 1367, 1416, 1495, 1504, 1588, 1774, 1819, 1939, 1993 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(68, result.number);
            Assert.AreEqual(39355, result.newNumber);
        }


        [TestMethod]
        public void TestMethod094()
        {
            int[] numbers = new int[] { 38, 83, 84, 253, 267, 305, 350, 351, 370, 515, 553, 585, 599, 619, 696, 723, 725, 946, 968, 1000, 1017, 1066, 1072, 1092, 1100, 1119, 1143, 1244, 1250, 1267, 1303, 1315, 1375, 1402, 1508, 1601, 1706, 1747, 1837, 1856, 1914, 1982 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(84, result.number);
            Assert.AreEqual(39600, result.newNumber);
        }


        [TestMethod]
        public void TestMethod095()
        {
            int[] numbers = new int[] { 151, 357, 358, 407, 524, 714, 748, 764, 774, 780, 822, 934, 941, 945, 946, 965, 1025, 1052, 1102, 1109, 1131, 1137, 1163, 1194, 1202, 1211, 1315, 1422, 1457, 1480, 1505, 1524, 1538, 1551, 1563, 1614, 1765, 1880, 1906, 1934 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(357, result.number);
            Assert.AreEqual(42353, result.newNumber);
        }


        [TestMethod]
        public void TestMethod096()
        {
            int[] numbers = new int[] { 60, 139, 166, 229, 343, 350, 355, 360, 416, 478, 565, 619, 626, 687, 690, 716, 785, 870, 942, 1038, 1225, 1301, 1322, 1332, 1413, 1499, 1540, 1764, 1796, 1866, 1893, 1941, 1949 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(60, result.number);
            Assert.AreEqual(29969, result.newNumber);
        }


        [TestMethod]
        public void TestMethod097()
        {
            int[] numbers = new int[] { 58, 125, 156, 179, 183, 250, 430, 505, 580, 597, 749, 848, 1049, 1076, 1202, 1244, 1281, 1284, 1551, 1676, 1984 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(125, result.number);
            Assert.AreEqual(15487, result.newNumber);
        }


        [TestMethod]
        public void TestMethod098()
        {
            int[] numbers = new int[] { 297, 308, 370, 384, 410, 553, 661, 714, 720, 817, 861, 938, 958, 1004, 1059, 1063, 1068, 1168, 1191, 1197, 1276, 1321, 1428, 1485, 1490, 1501, 1596, 1667, 1670, 1711, 1847, 1889, 1897, 1938, 1979 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(308, result.number);
            Assert.AreEqual(37760, result.newNumber);
        }


        [TestMethod]
        public void TestMethod099()
        {
            int[] numbers = new int[] { 6, 90, 188, 200, 222, 340, 383, 410, 454, 552, 566, 640, 738, 762, 770, 782, 1178, 1186, 1268, 1411, 1505, 1533, 1539, 1615, 1621, 1646, 1690, 1816, 1848, 1887, 1899 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(188, result.number);
            Assert.AreEqual(29160, result.newNumber);
        }


        [TestMethod]
        public void TestMethod100()
        {
            int[] numbers = new int[] { 78, 113, 134, 155, 177, 220, 277, 346, 349, 400, 533, 563, 571, 616, 685, 811, 837, 908, 934, 950, 980, 983, 991, 1000, 1020, 1036, 1122, 1219, 1257, 1437, 1470, 1479, 1515, 1646, 1681, 1722, 1764, 1769, 1779, 1786, 1799, 1813, 1876, 1989 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(113, result.number);
            Assert.AreEqual(43742, result.newNumber);
        }


        [TestMethod]
        public void TestMethod101()
        {
            int[] numbers = new int[] { 11, 22, 42, 171, 196, 315, 360, 418, 555, 582, 741, 796, 962, 974, 1062, 1125, 1229, 1431, 1541, 1859 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(196, result.number);
            Assert.AreEqual(13216, result.newNumber);
        }


        [TestMethod]
        public void TestMethod102()
        {
            int[] numbers = new int[] { 20, 100, 142, 177, 492, 660, 803, 899, 981, 1138, 1260, 1303, 1374, 1487, 1659, 1822, 1873, 1913, 1925, 1930 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(177, result.number);
            Assert.AreEqual(19062, result.newNumber);
        }


        [TestMethod]
        public void TestMethod103()
        {
            int[] numbers = new int[] { 21, 150, 198, 276, 373, 435, 455, 496, 512, 560, 570, 574, 777, 827, 828, 904, 952, 1012, 1066, 1088, 1110, 1219, 1459, 1501, 1551, 1579, 1598, 1683, 1683, 1714, 1750, 1822, 1855, 1894, 1910 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(198, result.number);
            Assert.AreEqual(34768, result.newNumber);
        }


        [TestMethod]
        public void TestMethod104()
        {
            int[] numbers = new int[] { 51, 62, 91, 140, 217, 226, 228, 342, 374, 391, 561, 617, 652, 675, 763, 772, 801, 832, 878, 899, 979, 1009, 1062, 1070, 1087, 1130, 1148, 1368, 1423, 1459, 1654, 1668, 1670, 1685, 1711, 1714, 1724, 1776, 1884, 1888, 1895 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(62, result.number);
            Assert.AreEqual(39642, result.newNumber);
        }


        [TestMethod]
        public void TestMethod105()
        {
            int[] numbers = new int[] { 3, 10, 19, 39, 84, 99, 234, 307, 324, 392, 496, 565, 614, 688, 730, 772, 786, 802, 805, 1054, 1131, 1464, 1480, 1490, 1505, 1522, 1661, 1679, 1708, 1769, 1804, 1846, 1862, 1869 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(3, result.number);
            Assert.AreEqual(31034, result.newNumber);
        }


        [TestMethod]
        public void TestMethod106()
        {
            int[] numbers = new int[] { 3, 60, 77, 137, 190, 204, 216, 224, 226, 555, 569, 681, 709, 712, 745, 776, 841, 936, 979, 987, 1183, 1389, 1407, 1409, 1474, 1502, 1543, 1654, 1662, 1738, 1777, 1881, 1923, 1941, 1966 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(77, result.number);
            Assert.AreEqual(33476, result.newNumber);
        }


        [TestMethod]
        public void TestMethod107()
        {
            int[] numbers = new int[] { 1, 120, 128, 158, 200, 203, 226, 253, 380, 448, 593, 609, 784, 832, 876, 917, 941, 972, 1022, 1023, 1031, 1192, 1297, 1395, 1447, 1454, 1481, 1561, 1645, 1939, 1972 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(128, result.number);
            Assert.AreEqual(26235, result.newNumber);
        }


        [TestMethod]
        public void TestMethod108()
        {
            int[] numbers = new int[] { 15, 27, 191, 198, 203, 218, 243, 303, 387, 471, 506, 604, 637, 641, 645, 737, 742, 824, 849, 901, 977, 983, 1070, 1151, 1257, 1290, 1321, 1414, 1417, 1431, 1460, 1502, 1559, 1619, 1622, 1689, 1697, 1735, 1740, 1742, 1802, 1850, 1901, 1934, 1959, 1959, 1992 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(15, result.number);
            Assert.AreEqual(50397, result.newNumber);
        }


        [TestMethod]
        public void TestMethod109()
        {
            int[] numbers = new int[] { 126, 170, 183, 198, 264, 271, 276, 450, 525, 540, 565, 607, 637, 975, 998, 1052, 1092, 1322, 1523, 1546, 1627, 1644, 1683, 1743, 1761, 1819 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(198, result.number);
            Assert.AreEqual(22107, result.newNumber);
        }


        [TestMethod]
        public void TestMethod110()
        {
            int[] numbers = new int[] { 21, 59, 72, 167, 341, 411, 442, 485, 554, 648, 774, 784, 803, 853, 876, 920, 945, 1110, 1302, 1310, 1377, 1386, 1423, 1562, 1630, 1646, 1945, 1949 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(21, result.number);
            Assert.AreEqual(24432, result.newNumber);
        }


        [TestMethod]
        public void TestMethod111()
        {
            int[] numbers = new int[] { 6, 15, 15, 54, 65, 99, 100, 116, 185, 185, 196, 222, 321, 392, 639, 712, 799, 853, 1021, 1038, 1073, 1156, 1226, 1262, 1288, 1294, 1301, 1343, 1406, 1558, 1663, 1676, 1760, 1773, 1902, 1921, 1955 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(15, result.number);
            Assert.AreEqual(32397, result.newNumber);
        }


        [TestMethod]
        public void TestMethod112()
        {
            int[] numbers = new int[] { 23, 214, 233, 241, 501, 662, 810, 873, 905, 934, 942, 1020, 1024, 1100, 1212, 1241, 1260, 1264, 1272, 1368, 1373, 1433, 1450, 1565, 1578, 1590, 1627, 1639, 1658, 1723, 1755, 1761, 1764, 1804, 1821, 1862, 1880, 1888, 1943, 1956, 1971 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(23, result.number);
            Assert.AreEqual(50803, result.newNumber);
        }


        [TestMethod]
        public void TestMethod113()
        {
            int[] numbers = new int[] { 15, 19, 65, 109, 188, 213, 331, 402, 405, 461, 723, 830, 1018, 1064, 1212, 1367, 1454, 1512, 1615, 1645, 1673, 1678, 1684, 1728, 1809, 1835 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(15, result.number);
            Assert.AreEqual(23820, result.newNumber);
        }


        [TestMethod]
        public void TestMethod114()
        {
            int[] numbers = new int[] { 16, 65, 74, 198, 254, 311, 350, 357, 474, 482, 509, 524, 576, 595, 599, 603, 609, 614, 615, 622, 643, 748, 764, 786, 859, 859, 860, 909, 910, 951, 1091, 1211, 1279, 1302, 1346, 1390, 1405, 1424, 1439, 1450, 1462, 1612, 1667, 1761, 1770, 1790, 1866, 1961 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(198, result.number);
            Assert.AreEqual(43066, result.newNumber);
        }


        [TestMethod]
        public void TestMethod115()
        {
            int[] numbers = new int[] { 43, 396, 670, 675, 821, 1042, 1241, 1247, 1249, 1273, 1341, 1378, 1470, 1507, 1635, 1704, 1780, 1830, 1876, 1927 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(396, result.number);
            Assert.AreEqual(20710, result.newNumber);
        }


        [TestMethod]
        public void TestMethod116()
        {
            int[] numbers = new int[] { 68, 68, 138, 175, 239, 245, 252, 254, 277, 300, 392, 421, 493, 526, 548, 637, 743, 747, 833, 978, 983, 1004, 1049, 1101, 1173, 1225, 1261, 1385, 1398, 1402, 1432, 1451, 1470, 1572, 1661, 1678, 1704, 1707, 1713, 1832, 1868, 1887 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(68, result.number);
            Assert.AreEqual(39290, result.newNumber);
        }


        [TestMethod]
        public void TestMethod117()
        {
            int[] numbers = new int[] { 98, 124, 200, 216, 225, 229, 240, 275, 312, 332, 413, 429, 458, 461, 469, 548, 593, 650, 658, 673, 718, 753, 767, 787, 807, 875, 878, 890, 923, 977, 1246, 1248, 1272, 1335, 1415, 1471, 1474, 1571, 1596, 1633, 1643, 1663, 1676, 1765, 1790, 1836, 1846, 1866, 1927 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(229, result.number);
            Assert.AreEqual(45203, result.newNumber);
        }


        [TestMethod]
        public void TestMethod118()
        {
            int[] numbers = new int[] { 200, 224, 367, 439, 519, 656, 737, 784, 787, 927, 961, 1129, 1162, 1246, 1285, 1301, 1359, 1407, 1473, 1558, 1583, 1625, 1650, 1672, 1701, 1728, 1749, 1768, 1784 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(224, result.number);
            Assert.AreEqual(30804, result.newNumber);
        }


        [TestMethod]
        public void TestMethod119()
        {
            int[] numbers = new int[] { 39, 83, 140, 196, 327, 363, 455, 582, 599, 816, 834, 1151, 1172, 1209, 1332, 1405, 1428, 1431, 1438, 1590, 1656, 1662, 1742, 1825, 1852, 1862, 1898, 1900, 1971 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(39, result.number);
            Assert.AreEqual(31221, result.newNumber);
        }


        [TestMethod]
        public void TestMethod120()
        {
            int[] numbers = new int[] { 76, 198, 234, 282, 337, 479, 493, 694, 765, 920, 1015, 1100, 1231, 1274, 1455, 1506, 1573, 1610, 1664, 1776, 1827, 1993 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(76, result.number);
            Assert.AreEqual(20161, result.newNumber);
        }


        [TestMethod]
        public void TestMethod121()
        {
            int[] numbers = new int[] { 49, 189, 372, 398, 401, 442, 458, 479, 486, 490, 508, 553, 641, 642, 738, 764, 790, 840, 845, 971, 1084, 1124, 1144, 1152, 1298, 1307, 1394, 1443, 1487, 1504, 1519, 1551, 1561, 1590, 1638, 1669, 1689, 1717, 1738, 1740, 1744, 1793, 1879, 1909, 1924, 1950, 1977, 1987 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(49, result.number);
            Assert.AreEqual(53876, result.newNumber);
        }


        [TestMethod]
        public void TestMethod122()
        {
            int[] numbers = new int[] { 77, 130, 301, 310, 344, 439, 447, 485, 491, 515, 643, 645, 712, 773, 782, 787, 901, 980, 1047, 1228, 1241, 1285, 1315, 1335, 1536, 1570, 1593, 1663, 1682, 1816, 1816, 1931, 1937, 1969, 1980 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(130, result.number);
            Assert.AreEqual(34905, result.newNumber);
        }


        [TestMethod]
        public void TestMethod123()
        {
            int[] numbers = new int[] { 24, 27, 63, 66, 68, 105, 220, 224, 289, 455, 506, 558, 599, 627, 636, 714, 742, 799, 835, 921, 955, 985, 1074, 1076, 1096, 1128, 1146, 1192, 1277, 1559, 1559, 1577, 1654, 1686, 1705, 1726, 1802, 1879, 1910 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(27, result.number);
            Assert.AreEqual(34936, result.newNumber);
        }


        [TestMethod]
        public void TestMethod124()
        {
            int[] numbers = new int[] { 10, 27, 36, 59, 95, 208, 247, 417, 426, 443, 575, 634, 686, 755, 1042, 1052, 1081, 1123, 1228, 1242, 1360, 1389, 1423, 1466, 1478, 1514, 1525, 1540, 1573, 1619, 1725, 1743, 1777, 1803, 1810, 1839, 1921, 1979, 1992 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(36, result.number);
            Assert.AreEqual(42005, result.newNumber);
        }


        [TestMethod]
        public void TestMethod125()
        {
            int[] numbers = new int[] { 27, 91, 161, 232, 271, 309, 310, 619, 644, 644, 654, 698, 764, 805, 870, 938, 988, 1016, 1041, 1085, 1168, 1200, 1332, 1352, 1359, 1393, 1478, 1516, 1524, 1530, 1552, 1617, 1780, 1803, 1852 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(27, result.number);
            Assert.AreEqual(33045, result.newNumber);
        }


        [TestMethod]
        public void TestMethod126()
        {
            int[] numbers = new int[] { 117, 188, 212, 254, 278, 374, 392, 423, 460, 480, 571, 613, 769, 895, 993, 994, 1081, 1141, 1190, 1227, 1395, 1643, 1690, 1690, 1922 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(254, result.number);
            Assert.AreEqual(19405, result.newNumber);
        }


        [TestMethod]
        public void TestMethod127()
        {
            int[] numbers = new int[] { 63, 107, 173, 195, 197, 198, 313, 348, 372, 391, 427, 433, 523, 589, 620, 640, 684, 731, 908, 909, 921, 1079, 1182, 1235, 1278, 1293, 1307, 1321, 1388, 1413, 1421, 1592, 1738, 1826, 1848, 1909, 1910, 1958, 1973, 1973 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(63, result.number);
            Assert.AreEqual(38179, result.newNumber);
        }


        [TestMethod]
        public void TestMethod128()
        {
            int[] numbers = new int[] { 26, 34, 64, 148, 285, 476, 587, 660, 661, 682, 688, 704, 782, 809, 1095, 1118, 1167, 1191, 1493, 1530, 1630, 1659, 1670, 1672, 1765, 1820, 1906, 1920, 1938 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(148, result.number);
            Assert.AreEqual(28719, result.newNumber);
        }


        [TestMethod]
        public void TestMethod129()
        {
            int[] numbers = new int[] { 4, 81, 140, 142, 177, 222, 251, 418, 574, 584, 612, 918, 919, 933, 983, 1077, 1158, 1298, 1355, 1386, 1512, 1696, 1715, 1732, 1837, 1927 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(81, result.number);
            Assert.AreEqual(22431, result.newNumber);
        }


        [TestMethod]
        public void TestMethod130()
        {
            int[] numbers = new int[] { 8, 293, 319, 379, 512, 701, 850, 850, 1131, 1152, 1272, 1305, 1536, 1607, 1687, 1699, 1729, 1786, 1864, 1905, 1980 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(850, result.number);
            Assert.AreEqual(20926, result.newNumber);
        }
    }
}
