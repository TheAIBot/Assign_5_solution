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


        [TestMethod]
        public void TestMethod131()
        {
            int[] numbers = new int[] { 130, 264, 320, 345, 384, 393, 400, 435, 448, 479, 569, 685, 696, 720, 804, 837, 892, 993, 1048, 1116, 1144, 1168, 1222, 1337, 1458, 1481, 1559, 1611, 1649, 1701, 1710, 1936, 2015, 2034, 2059, 2099, 2180, 2228, 2260, 2373, 2448, 2494, 2529, 2559, 2566, 2792, 2871, 3031, 3107, 3112, 3130, 3224, 3253, 3332, 3348, 3416, 3518, 3600, 3689, 3702, 3734, 3840, 3903, 4070, 4231, 4253, 4278, 4303, 4317, 4350, 4388, 4406, 4551, 4832, 4933, 5170, 5253, 5268, 5319, 5405, 5422, 5431, 5729, 5789, 5889, 5894, 5943, 6002, 6156, 6257, 6268, 6328, 6474, 6499, 6616, 6914, 6964, 6979, 7128, 7157, 7172, 7173, 7206, 7370, 7455, 7509, 7565, 7590, 7591, 7626, 7682, 7699, 7938, 7983, 8054, 8054, 8075, 8112, 8222, 8276, 8393, 8418, 8442, 8572, 8622, 8639, 8675, 8689, 8792, 8803, 8825, 8944, 9004, 9023, 9240, 9265, 9347, 9367, 9386, 9585, 9594, 9620, 9665, 9691, 9705, 9707, 9708, 9839, 9976, 10159, 10217, 10243, 10246, 10398, 10424, 10542, 10661, 10675, 10710, 10756, 10837, 10973, 10981, 11049, 11112, 11171, 11184, 11376, 11411, 11432, 11439, 11481, 11505, 11516, 11609, 11639, 11706, 11753, 11759, 11894, 11949, 12009, 12051, 12157, 12202, 12231, 12266, 12378, 12391, 12394, 12833, 12909, 12917, 12960, 12969, 12973, 13069, 13127, 13165, 13170, 13217, 13526, 13590, 13695, 13712, 13839, 13890, 13919, 13997, 14034, 14041, 14303, 14316, 14389, 14406, 14427, 14489, 14548, 14679, 14685, 14755, 14845, 14846, 15175, 15248, 15351, 15381, 15627, 15763, 15788, 15801, 15812, 15831, 15933, 16193, 16389, 16413, 16487, 16524, 16582, 16602, 16635, 16640, 16685, 16725, 16759, 16799, 16854, 16879, 16902, 16913, 17007, 17014, 17063, 17085, 17243, 17259, 17293, 17313, 17319, 17379, 17408, 17483, 17771, 17786, 17814, 17899, 18016, 18096, 18176, 18182, 18223, 18291, 18347, 18368, 18471, 18589, 18677, 18784, 18835, 18950, 19009, 19011, 19331, 19345, 19490, 19617, 19736, 19793 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(130, result.number);
            Assert.AreEqual(2810875, result.newNumber);
        }


        [TestMethod]
        public void TestMethod132()
        {
            int[] numbers = new int[] { 180, 213, 384, 436, 602, 615, 685, 712, 785, 817, 878, 886, 1036, 1216, 1259, 1297, 1356, 1427, 1513, 1518, 1768, 2079, 2233, 2262, 2291, 2304, 2332, 2500, 2716, 2815, 2868, 2893, 2961, 2965, 3191, 3345, 3348, 3356, 3563, 3566, 3675, 3730, 3748, 3845, 3859, 3943, 3950, 4675, 4722, 4969, 4981, 5004, 5089, 5109, 5247, 5352, 5393, 5523, 5627, 5650, 5713, 5829, 5945, 5986, 6316, 6399, 6673, 6710, 6930, 6997, 7073, 7212, 7270, 7285, 7402, 7921, 8103, 8223, 8387, 8490, 8497, 8574, 8725, 8747, 8776, 8867, 9018, 9053, 9087, 9137, 9205, 9319, 9523, 9576, 9586, 9702, 9722, 9724, 9797, 9806, 9858, 9879, 9999, 10092, 10107, 10191, 10202, 10316, 10430, 10439, 10570, 10581, 10804, 10833, 10855, 10883, 10931, 10998, 11088, 11089, 11313, 11316, 11441, 11545, 11657, 11671, 11750, 11821, 11851, 11965, 11977, 12030, 12125, 12160, 12279, 12300, 12433, 12435, 12569, 12660, 12740, 12775, 12806, 12828, 12847, 12870, 12909, 12942, 13017, 13116, 13145, 13147, 13164, 13881, 14258, 14260, 14298, 14316, 14324, 14396, 14480, 14650, 14794, 15052, 15111, 15175, 15205, 15301, 15304, 15368, 15459, 15499, 15621, 15654, 15657, 15834, 15837, 15954, 16083, 16183, 16245, 16280, 16318, 16401, 16404, 16480, 16506, 16666, 16686, 16997, 17027, 17069, 17316, 17370, 17465, 17542, 17607, 17664, 17882, 18007, 18071, 18148, 18435, 18634, 18824, 18867, 19285, 19287, 19432, 19461, 19669, 19718, 19748, 19907 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(180, result.number);
            Assert.AreEqual(2122918, result.newNumber);
        }


        [TestMethod]
        public void TestMethod133()
        {
            int[] numbers = new int[] { 485, 875, 904, 965, 1032, 1297, 2005, 2184, 2489, 2815, 2885, 3438, 4592, 5120, 5842, 6583, 6888, 7236, 9215, 9525, 10605, 10676, 10777, 10920, 11075, 11098, 11244, 11887, 12526, 13412, 13466, 14863, 14961, 14981, 15279, 15296, 16038, 16784, 16951, 17139, 18353, 18407, 18626 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1297, result.number);
            Assert.AreEqual(389461, result.newNumber);
        }


        [TestMethod]
        public void TestMethod134()
        {
            int[] numbers = new int[] { 91, 264, 565, 624, 733, 783, 908, 1134, 1391, 1854, 1912, 2035, 2132, 2337, 3065, 3179, 3361, 3760, 4472, 4574, 4629, 4693, 4788, 4878, 5145, 5214, 5252, 5297, 5417, 5639, 5707, 5710, 5797, 6299, 6421, 6620, 6884, 7471, 7549, 7732, 8151, 8443, 8883, 8914, 9041, 9295, 9744, 9918, 10045, 10045, 10111, 10202, 10496, 10510, 10797, 10974, 11378, 11978, 12096, 12440, 12791, 13517, 13605, 13841, 14323, 14665, 14922, 14922, 15373, 15457, 15753, 15914, 15931, 16177, 16673, 17011, 17174, 18052, 18244, 18923, 18952, 19026, 19093, 19170, 19185, 19250, 19963 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(264, result.number);
            Assert.AreEqual(802454, result.newNumber);
        }


        [TestMethod]
        public void TestMethod135()
        {
            int[] numbers = new int[] { 171, 192, 591, 738, 1055, 1105, 1145, 1541, 1658, 1761, 1765, 1913, 2056, 2118, 2154, 2212, 2465, 2573, 2646, 2718, 2892, 2924, 2934, 2945, 2946, 2986, 3285, 3346, 3456, 3481, 3503, 3562, 4204, 4514, 4560, 4621, 4810, 4819, 4825, 5051, 5290, 5428, 5548, 5568, 5586, 5683, 5923, 6159, 6313, 6393, 6713, 6856, 6929, 7107, 7243, 7309, 7341, 7440, 7680, 7904, 7911, 8069, 8158, 8213, 8430, 8439, 8695, 8956, 9025, 9328, 9461, 9625, 9704, 9806, 9876, 10045, 10406, 10425, 10596, 10676, 11062, 11087, 11092, 11162, 11258, 11263, 11412, 11480, 11544, 11605, 12030, 12080, 12086, 12105, 12122, 12150, 12337, 12389, 12485, 12731, 12734, 12873, 12940, 13150, 13249, 13323, 13479, 13489, 13499, 13616, 13622, 13761, 13823, 13878, 13985, 14043, 14514, 14558, 15159, 15268, 15393, 15638, 15667, 15817, 15878, 16078, 16171, 16226, 16229, 16235, 16633, 16662, 16701, 16725, 16920, 17156, 17205, 17503, 17563, 18323, 18356, 18403, 18636, 18643, 18677, 18698, 19383, 19641, 19690, 19698, 19954 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(192, result.number);
            Assert.AreEqual(1469873, result.newNumber);
        }


        [TestMethod]
        public void TestMethod136()
        {
            int[] numbers = new int[] { 76, 313, 466, 598, 766, 882, 888, 1329, 1517, 1544, 1571, 1579, 1780, 1834, 2001, 2049, 2054, 2060, 2117, 2389, 2461, 2821, 2848, 2903, 2907, 3079, 3217, 3259, 3415, 3600, 3717, 3872, 3980, 4078, 4194, 4194, 4339, 4506, 4555, 4719, 4826, 4915, 4918, 4960, 4980, 4989, 4999, 5037, 5242, 5264, 5273, 5524, 5651, 5737, 6285, 6335, 6462, 6604, 6815, 6891, 7065, 7169, 7521, 7594, 7940, 7978, 8284, 8336, 8356, 8522, 8680, 8706, 8858, 9026, 9068, 9298, 9501, 9618, 9623, 9988, 10084, 10163, 10312, 10382, 10400, 10478, 10789, 10837, 10971, 10974, 11130, 11143, 11176, 11260, 11351, 11374, 11414, 11671, 12049, 12093, 12432, 12448, 12467, 12487, 12842, 12874, 12923, 12986, 13009, 13053, 13472, 13547, 13594, 13637, 13695, 13757, 14255, 14301, 14469, 14575, 14688, 14933, 14960, 14984, 15226, 15245, 15309, 15323, 15449, 15520, 15614, 15663, 15893, 16103, 16107, 16350, 16499, 16609, 16631, 16805, 16916, 16944, 16965, 17091, 17180, 17302, 17407, 17461, 17629, 17729, 17730, 17803, 18044, 18194, 18226, 18313, 18329, 18364, 18368, 18377, 18633, 18926, 19039, 19214, 19258, 19438, 19508, 19521, 19616, 19625, 19647, 19707, 19779, 19786, 19804 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(313, result.number);
            Assert.AreEqual(1825474, result.newNumber);
        }


        [TestMethod]
        public void TestMethod137()
        {
            int[] numbers = new int[] { 999, 1870, 2857, 4330, 4891, 5955, 6688, 7941, 8083, 8301, 13136, 13307, 13597, 13822, 13916, 14715, 14838, 15441, 16106, 16666, 17981, 19236, 19363 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1870, result.number);
            Assert.AreEqual(206280, result.newNumber);
        }


        [TestMethod]
        public void TestMethod138()
        {
            int[] numbers = new int[] { 742, 861, 1241, 1696, 1992, 2082, 2338, 3150, 3331, 3853, 4206, 4384, 4715, 5238, 6066, 6472, 6652, 7349, 7445, 7445, 7493, 8649, 9003, 9102, 9352, 9540, 9797, 9840, 11166, 11589, 11810, 11901, 12192, 12566, 12973, 13130, 13741, 14125, 14270, 14313, 14510, 14651, 14810, 15891, 16284, 17155, 17430, 17445, 17663, 17863, 18243, 18472, 18865, 18948, 19001, 19303, 19312 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1696, result.number);
            Assert.AreEqual(587295, result.newNumber);
        }


        [TestMethod]
        public void TestMethod139()
        {
            int[] numbers = new int[] { 276, 838, 1026, 1192, 2180, 2234, 2325, 2353, 2388, 2513, 2661, 3496, 3997, 4426, 4452, 4798, 4876, 4972, 5047, 5169, 6209, 6366, 6392, 6414, 6969, 7141, 7605, 7768, 8104, 8159, 8493, 8661, 9108, 9172, 9172, 9409, 9433, 9539, 9620, 9630, 9734, 9782, 9945, 9979, 10129, 10571, 10636, 10884, 10894, 10902, 10989, 11388, 11403, 11438, 11853, 12408, 12617, 12662, 12729, 13035, 13317, 13323, 13538, 13627, 13697, 13730, 13791, 13906, 14072, 14747, 14842, 14865, 15341, 15849, 15873, 16670, 16804, 17079, 17132, 17276, 18020, 18841, 18866, 19210, 19337, 19406, 19545, 19839, 19904 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1026, result.number);
            Assert.AreEqual(909181, result.newNumber);
        }


        [TestMethod]
        public void TestMethod140()
        {
            int[] numbers = new int[] { 655, 955, 1420, 1442, 1561, 1936, 2165, 2268, 2651, 2669, 2688, 2939, 2989, 3115, 3170, 3537, 3643, 3923, 4089, 4192, 4431, 4475, 4624, 4747, 5335, 5429, 5677, 5834, 6091, 6142, 6169, 6681, 7338, 7510, 7666, 7934, 7988, 8419, 8430, 8876, 9070, 9086, 9145, 9323, 9338, 9477, 9705, 9952, 9991, 10179, 10651, 11000, 11103, 11356, 11412, 11433, 11654, 12006, 12109, 12629, 12837, 12898, 13078, 13144, 13426, 13567, 14063, 15360, 15980, 16056, 16207, 16352, 16687, 16913, 17020, 17674, 17739, 18135, 18534, 18994, 19141, 19247, 19370, 19518, 19551, 19656, 19790, 19967 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(655, result.number);
            Assert.AreEqual(852109, result.newNumber);
        }


        [TestMethod]
        public void TestMethod141()
        {
            int[] numbers = new int[] { 103, 307, 384, 762, 1633, 1979, 3767, 4841, 5824, 6623, 6741, 7638, 7918, 8247, 8267, 8669, 9354, 10427, 10781, 11609, 12490, 13151, 15107, 15324, 16203, 16960, 18241, 18946, 19393, 19717, 19747 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(762, result.number);
            Assert.AreEqual(279990, result.newNumber);
        }


        [TestMethod]
        public void TestMethod142()
        {
            int[] numbers = new int[] { 43, 61, 398, 903, 1011, 2566, 2795, 3006, 3191, 3211, 3589, 3742, 4343, 4345, 4479, 4757, 4763, 4927, 5133, 6487, 6563, 6627, 6656, 7204, 7471, 7582, 8146, 8398, 8930, 9312, 10044, 11011, 11336, 11450, 11518, 11830, 12913, 13505, 13692, 14275, 14574, 15137, 15300, 15643, 15675, 16286, 16857, 17290, 17500, 17512, 18043, 18988, 19211, 19222, 19704, 19724 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(398, result.number);
            Assert.AreEqual(528218, result.newNumber);
        }


        [TestMethod]
        public void TestMethod143()
        {
            int[] numbers = new int[] { 285, 401, 419, 420, 433, 510, 647, 708, 735, 785, 820, 823, 910, 1016, 1022, 1100, 1219, 1369, 1384, 1465, 1729, 2052, 2073, 2204, 2289, 2448, 2501, 2574, 2811, 2903, 2984, 3013, 3170, 3195, 3203, 3243, 3347, 3360, 3385, 3460, 3482, 3508, 3601, 3793, 3795, 3870, 3963, 4018, 4169, 4194, 4235, 4401, 4410, 4487, 4505, 4509, 4596, 4693, 4929, 4995, 5016, 5023, 5053, 5092, 5395, 5514, 5653, 5654, 5658, 5671, 5699, 5729, 5854, 6050, 6255, 6334, 6347, 6422, 6435, 6438, 6445, 6526, 6530, 6613, 6613, 6673, 6936, 7041, 7156, 7244, 7260, 7333, 7446, 7486, 7705, 7861, 7890, 7900, 8026, 8035, 8047, 8213, 8308, 8407, 8471, 8665, 8731, 8797, 8883, 8895, 9127, 9150, 9200, 9289, 9425, 9448, 9652, 9662, 9709, 9743, 9783, 9801, 9941, 9949, 10232, 10266, 10314, 10528, 10838, 10856, 10861, 10898, 10910, 10918, 10944, 10966, 11216, 11231, 11272, 11324, 11461, 11513, 11647, 11778, 11785, 11877, 11938, 11979, 12000, 12092, 12137, 12213, 12233, 12253, 12350, 12372, 12404, 12472, 12484, 12649, 12739, 12807, 12817, 12841, 12930, 12996, 13188, 13278, 13368, 13869, 14004, 14204, 14289, 14298, 14392, 14394, 14476, 14502, 14584, 14633, 14637, 14681, 14814, 15159, 15162, 15166, 15261, 15269, 15371, 15387, 15599, 15676, 15873, 15913, 15959, 16022, 16117, 16216, 16442, 16444, 16587, 16594, 16602, 16748, 16772, 17020, 17152, 17189, 17309, 17335, 17587, 17718, 17758, 17772, 17830, 17832, 17957, 18138, 18164, 18204, 18234, 18448, 18464, 18616, 18703, 19225, 19265, 19405, 19434, 19456, 19732, 19742, 19910, 19943, 19976 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(401, result.number);
            Assert.AreEqual(2270895, result.newNumber);
        }


        [TestMethod]
        public void TestMethod144()
        {
            int[] numbers = new int[] { 99, 194, 250, 362, 363, 418, 437, 447, 462, 594, 596, 602, 705, 718, 739, 881, 1241, 1276, 1298, 1374, 1410, 1533, 1725, 1771, 1800, 1866, 2450, 2540, 2541, 2899, 2902, 2902, 2956, 3043, 3071, 3136, 3147, 3228, 3337, 3349, 3371, 3372, 3477, 3478, 3500, 3573, 3611, 3621, 3749, 3938, 3999, 4341, 4422, 4423, 4642, 4753, 4893, 4934, 4973, 5106, 5117, 5124, 5128, 5170, 5187, 5209, 5319, 5459, 5519, 5790, 5836, 5844, 5863, 5875, 6018, 6037, 6060, 6067, 6107, 6113, 6113, 6141, 6166, 6212, 6370, 6825, 7172, 7321, 7338, 7374, 7515, 7560, 7572, 7620, 7631, 7738, 8018, 8100, 8148, 8291, 8357, 8436, 8547, 8731, 8808, 8886, 9072, 9129, 9485, 9490, 9501, 9533, 9571, 9591, 9740, 9915, 9997, 10032, 10097, 10144, 10232, 10330, 10453, 10624, 10670, 10723, 10857, 10886, 11001, 11038, 11333, 11439, 11641, 11688, 11832, 12025, 12038, 12167, 12185, 12229, 12392, 12395, 12474, 12485, 12518, 12545, 12571, 12632, 12678, 12717, 12816, 12862, 12951, 13099, 13313, 13434, 13463, 13487, 13502, 13565, 13644, 13808, 13817, 13847, 13929, 13955, 14203, 14403, 14530, 14748, 15047, 15089, 15176, 15297, 15344, 15348, 15425, 15510, 15521, 15536, 15592, 15653, 15701, 15703, 15851, 15944, 15951, 15988, 16137, 16156, 16165, 16173, 16245, 16299, 16316, 16331, 16387, 16572, 16690, 16700, 16751, 16772, 16928, 16999, 17015, 17211, 17221, 17364, 17418, 17476, 17775, 17807, 18052, 18203, 18253, 18269, 18503, 18552, 18592, 18853, 19141, 19156, 19459, 19504, 19511, 19522, 19581, 19601, 19668, 19808, 19872, 19921, 19942, 19954 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(99, result.number);
            Assert.AreEqual(2318896, result.newNumber);
        }


        [TestMethod]
        public void TestMethod145()
        {
            int[] numbers = new int[] { 1280, 1532, 1585, 2603, 8864, 10629, 11922, 12472, 15112, 18367, 18832 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1280, result.number);
            Assert.AreEqual(1, result.newNumber);
        }


        [TestMethod]
        public void TestMethod146()
        {
            int[] numbers = new int[] { 73, 93, 400, 560, 702, 708, 716, 767, 1014, 1016, 1207, 1267, 1303, 1312, 1440, 1440, 1491, 1510, 1524, 1539, 1560, 1611, 1867, 1869, 2314, 2357, 2554, 2699, 2722, 2945, 3041, 3061, 3121, 3174, 3895, 3947, 3987, 4251, 4412, 4475, 4549, 4587, 4676, 4686, 4887, 4910, 4924, 4989, 5093, 5123, 5136, 5152, 5295, 5406, 5422, 5550, 5568, 5592, 5640, 5676, 5691, 5748, 5803, 5907, 5966, 5989, 6125, 6391, 6469, 6676, 6786, 6787, 6791, 6905, 6914, 6943, 6982, 7148, 7208, 7253, 7352, 7405, 7407, 7439, 7494, 7516, 7542, 7635, 7653, 7655, 7690, 7742, 7761, 8061, 8131, 8142, 8195, 8316, 8373, 8689, 8842, 8865, 8884, 8943, 9090, 9092, 9165, 9322, 9404, 9508, 9791, 9844, 9944, 10023, 10108, 10218, 10227, 10248, 10253, 10491, 10542, 10670, 10802, 10822, 10872, 10885, 11046, 11088, 11155, 11298, 11376, 11463, 11497, 11535, 11587, 11928, 11945, 12008, 12118, 12131, 12132, 12135, 12208, 12282, 12418, 12453, 12524, 12694, 12775, 12789, 12838, 12866, 12932, 13073, 13120, 13144, 13167, 13168, 13178, 13258, 13264, 13566, 13590, 13618, 13640, 13709, 13721, 13765, 13866, 14052, 14156, 14186, 14395, 14433, 14545, 14651, 14733, 14735, 14783, 14903, 14940, 15169, 15198, 15217, 15455, 15492, 15524, 15534, 15671, 15794, 15798, 15849, 15863, 15924, 15971, 16026, 16113, 16186, 16207, 16207, 16263, 16354, 16780, 16799, 17001, 17036, 17144, 17154, 17262, 17323, 17375, 17379, 17390, 17605, 17622, 17765, 17978, 18064, 18196, 18321, 18337, 18347, 18369, 18388, 18391, 18443, 18564, 18597, 18677, 18821, 18858, 18922, 19093, 19143, 19182, 19209, 19209, 19225, 19588, 19737, 19836, 19860, 19904, 19957, 19976 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(73, result.number);
            Assert.AreEqual(2560392, result.newNumber);
        }


        [TestMethod]
        public void TestMethod147()
        {
            int[] numbers = new int[] { 80, 132, 271, 627, 700, 851, 896, 1121, 1162, 1541, 1730, 2000, 2074, 2474, 2719, 2725, 2775, 2880, 2957, 3088, 3258, 3469, 3501, 3804, 4014, 4544, 4624, 4991, 5036, 5084, 5632, 5660, 5967, 6010, 6253, 6640, 6662, 6926, 7494, 7769, 8469, 8745, 8950, 9625, 9754, 9968, 10084, 10557, 10581, 10746, 10786, 11183, 11300, 11402, 11509, 11541, 11558, 11650, 12103, 12276, 13061, 13373, 13736, 14056, 14073, 14211, 14326, 14518, 14536, 14595, 14709, 14999, 15152, 15185, 15446, 15467, 15508, 15508, 15714, 15956, 16290, 16445, 17142, 17583, 17635, 17924, 18047, 18393, 18466, 18575, 18733, 18772, 19471, 19842 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(132, result.number);
            Assert.AreEqual(895613, result.newNumber);
        }


        [TestMethod]
        public void TestMethod148()
        {
            int[] numbers = new int[] { 6, 19, 23, 39, 89, 138, 443, 454, 540, 685, 745, 836, 933, 957, 1262, 1498, 1875, 1883, 2102, 2162, 2364, 2441, 2515, 2548, 2555, 2567, 2572, 2583, 2601, 2639, 2675, 2737, 2756, 2850, 2857, 2982, 3062, 3096, 3168, 3220, 3292, 3364, 3383, 3412, 3415, 3416, 3424, 3454, 3493, 3515, 3598, 3771, 3847, 3917, 3952, 4017, 4077, 4474, 4525, 4609, 4620, 4621, 4707, 4905, 4967, 4981, 4995, 5142, 5197, 5203, 5303, 5321, 5440, 5448, 5604, 5638, 5709, 5817, 5890, 5927, 5994, 6017, 6148, 6156, 6228, 6266, 6283, 6316, 6344, 6436, 6544, 6784, 6914, 6946, 7036, 7254, 7489, 7543, 7551, 7553, 7638, 7638, 7726, 7781, 7886, 7895, 7947, 8034, 8046, 8057, 8123, 8127, 8205, 8287, 8299, 8317, 8490, 8512, 8530, 8647, 8668, 8747, 8774, 8863, 8962, 9050, 9095, 9310, 9407, 9422, 9461, 9482, 9669, 9759, 10132, 10352, 10443, 10591, 10700, 10706, 10795, 10853, 10964, 11163, 11252, 11307, 11480, 11509, 11900, 11911, 12053, 12121, 12155, 12158, 12364, 12365, 12389, 12464, 12523, 12546, 12564, 12725, 12850, 13062, 13073, 13109, 13299, 13362, 13451, 13551, 13617, 13703, 13755, 13759, 13999, 14058, 14121, 14304, 14332, 14338, 14409, 14420, 14490, 14595, 14676, 14694, 14818, 14877, 14944, 15106, 15265, 15270, 15379, 15403, 15435, 15499, 15530, 15532, 15681, 15900, 16125, 16140, 16191, 16489, 16532, 16676, 16682, 16814, 16884, 16909, 16991, 17234, 17346, 17460, 17471, 17536, 17705, 17716, 17770, 17921, 17945, 18115, 18191, 18201, 18216, 18312, 18417, 18430, 18466, 18488, 18518, 18536, 18664, 18679, 18740, 18942, 18977, 19067, 19068, 19085, 19173, 19177, 19262, 19352, 19424, 19473, 19607, 19765, 19795, 19799 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(89, result.number);
            Assert.AreEqual(2454185, result.newNumber);
        }


        [TestMethod]
        public void TestMethod149()
        {
            int[] numbers = new int[] { 744, 1460, 1650, 2103, 2364, 2419, 3091, 3703, 4867, 5726, 6235, 6542, 6950, 10036, 10202, 10563, 10925, 12497, 12752, 13312, 15268, 16450, 16526, 16694, 16705, 16875, 17609, 18084, 18709, 19486, 19507 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(744, result.number);
            Assert.AreEqual(296114, result.newNumber);
        }


        [TestMethod]
        public void TestMethod150()
        {
            int[] numbers = new int[] { 353, 419, 581, 1227, 1368, 1483, 1493, 1606, 2162, 2218, 2243, 2617, 2912, 3138, 3556, 3790, 3905, 3946, 4411, 4454, 4514, 5055, 5273, 5417, 5528, 5770, 6226, 7734, 7831, 7874, 8963, 9063, 9281, 9564, 10649, 10708, 10878, 10878, 10932, 11225, 11493, 11704, 12085, 12139, 12181, 12267, 12619, 14197, 14403, 14753, 14772, 14970, 15456, 15561, 15689, 15867, 15932, 15946, 15961, 15962, 16172, 16216, 16383, 16945, 17166, 17350, 17383, 17493, 17775, 18310, 18459, 19183, 19347, 19534, 19631 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(353, result.number);
            Assert.AreEqual(753739, result.newNumber);
        }


        [TestMethod]
        public void TestMethod151()
        {
            int[] numbers = new int[] { 40, 144, 548, 597, 616, 776, 927, 985, 1588, 1815, 1913, 2155, 2486, 2561, 2841, 3530, 3563, 3688, 3839, 4064, 4067, 4232, 4440, 4518, 4580, 4612, 4661, 4661, 4691, 4692, 4959, 4996, 5235, 5295, 5459, 5676, 5857, 5874, 6310, 6506, 6669, 6798, 6944, 7045, 7175, 7256, 7305, 7345, 7350, 7468, 7551, 7663, 7688, 7976, 8176, 8200, 8281, 8387, 8532, 8566, 9272, 9442, 9514, 9678, 9906, 10111, 10907, 11017, 11151, 11265, 11343, 11706, 11800, 11895, 11920, 12253, 12288, 12427, 12496, 12695, 12995, 13243, 13315, 13399, 14229, 14325, 14480, 14947, 15267, 15891, 15908, 16126, 16198, 16257, 16277, 16486, 16681, 16719, 16854, 16911, 16912, 16944, 17258, 17295, 17367, 17570, 17747, 17781, 17905, 18048, 18922, 19068, 19116, 19420, 19465, 19904, 19976 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(616, result.number);
            Assert.AreEqual(1127042, result.newNumber);
        }


        [TestMethod]
        public void TestMethod152()
        {
            int[] numbers = new int[] { 113, 579, 871, 1965, 2518, 2982, 3553, 3878, 4468, 5283, 5326, 5764, 5765, 6436, 6613, 6731, 7410, 7888, 8726, 9199, 10173, 10342, 10626, 11108, 12529, 12713, 13152, 13245, 14040, 14398, 15835, 16028, 16679, 17049, 17741, 18979, 19023, 19165, 19772, 19792 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(871, result.number);
            Assert.AreEqual(380192, result.newNumber);
        }


        [TestMethod]
        public void TestMethod153()
        {
            int[] numbers = new int[] { 2, 67, 184, 281, 283, 884, 890, 915, 1016, 1039, 1039, 1344, 1374, 1402, 1485, 1521, 1627, 1907, 1911, 1983, 2060, 2127, 2264, 2281, 2332, 2458, 2612, 2747, 2824, 2850, 2932, 3003, 3032, 3095, 3120, 3281, 3501, 3563, 3569, 3625, 3649, 3799, 3824, 3907, 3990, 4015, 4050, 4272, 4326, 4473, 4649, 4680, 4747, 4800, 4820, 5026, 5121, 5155, 5182, 5185, 5390, 5434, 5485, 5554, 5629, 5637, 5714, 5715, 5765, 5784, 5786, 5918, 5927, 5997, 6209, 6636, 6762, 6852, 6876, 6877, 6905, 7021, 7198, 7441, 7447, 7755, 7768, 7909, 7916, 8047, 8100, 8467, 8542, 8833, 8847, 9015, 9531, 9594, 9599, 9965, 10189, 10252, 10253, 10527, 10528, 10555, 10924, 10965, 11032, 11050, 11067, 11109, 11134, 11315, 11428, 11469, 11508, 11533, 11566, 11606, 11931, 12105, 12126, 12146, 12181, 12340, 12366, 12575, 12594, 12625, 12626, 12627, 12687, 12909, 12911, 12957, 12961, 12989, 13096, 13253, 13260, 13364, 13398, 13405, 13667, 13887, 14028, 14095, 14111, 14257, 14336, 14486, 14619, 14629, 15025, 15031, 15138, 15156, 15253, 15296, 15524, 15572, 15664, 15734, 15843, 15967, 16175, 16182, 16192, 16194, 16218, 16273, 16334, 16485, 16505, 16536, 17129, 17183, 17336, 17555, 17620, 17815, 18013, 18102, 18160, 18438, 18441, 18458, 18906, 18908, 19204, 19409, 19517, 19573, 19645 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(283, result.number);
            Assert.AreEqual(1816426, result.newNumber);
        }


        [TestMethod]
        public void TestMethod154()
        {
            int[] numbers = new int[] { 53, 723, 1310, 1405, 1545, 1937, 2192, 2565, 2632, 2977, 3097, 3127, 3193, 3481, 3503, 3592, 4295, 4410, 4470, 4765, 4824, 4902, 5272, 5394, 5467, 6156, 6175, 6422, 6425, 6429, 7073, 7121, 7125, 8137, 8564, 8654, 8665, 8860, 8860, 8950, 9408, 9544, 9561, 9735, 9759, 9762, 10210, 10225, 10243, 10498, 10556, 10732, 10833, 10857, 10915, 11008, 11902, 12013, 12462, 12521, 12858, 12870, 13489, 13565, 13705, 13738, 13860, 13913, 13966, 14415, 14809, 14942, 15254, 15548, 15757, 15855, 15903, 15934, 15963, 16066, 16402, 16545, 16590, 16670, 16859, 17080, 17190, 17348, 17580, 17855, 18211, 18561, 18711, 18740, 18843, 18867, 19291, 19305, 19492, 19687, 19722, 19731, 19939 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(723, result.number);
            Assert.AreEqual(1108459, result.newNumber);
        }


        [TestMethod]
        public void TestMethod155()
        {
            int[] numbers = new int[] { 62, 434, 528, 775, 812, 1025, 1063, 1111, 1198, 1442, 1671, 1743, 1779, 1848, 2222, 2229, 2240, 2337, 2553, 2629, 2744, 2783, 3134, 3157, 3596, 3806, 3837, 3898, 3940, 4032, 4085, 4179, 4260, 4587, 4676, 4794, 4813, 4882, 5292, 5569, 5801, 6157, 6400, 6429, 6435, 6442, 6492, 6552, 6596, 6613, 6663, 6830, 6917, 6920, 7031, 7047, 7096, 7214, 7407, 7423, 7658, 7686, 7741, 7950, 8082, 8214, 8447, 8470, 8516, 8854, 9078, 9207, 9280, 9328, 9628, 9740, 9996, 10188, 10270, 10287, 10374, 10401, 10844, 10897, 11022, 11175, 11179, 11217, 11408, 12154, 12190, 12286, 12857, 12876, 12933, 12957, 13043, 13146, 13156, 13159, 13239, 13641, 13684, 13882, 14105, 14411, 14471, 14560, 14617, 14999, 15003, 15070, 15145, 15171, 15260, 15464, 15804, 16111, 16228, 16250, 16428, 16770, 17167, 17207, 17345, 17392, 17604, 17619, 17709, 17774, 17842, 17911, 17939, 18155, 18439, 18586, 18878, 19295, 19773, 19829, 19928, 19971, 19989 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(528, result.number);
            Assert.AreEqual(1375380, result.newNumber);
        }


        [TestMethod]
        public void TestMethod156()
        {
            int[] numbers = new int[] { 133, 260, 393, 513, 868, 877, 1100, 1142, 1182, 1526, 1592, 1915, 2594, 2613, 3057, 3064, 3250, 3372, 3463, 3788, 3856, 3990, 3996, 4150, 4439, 4784, 4979, 5285, 5381, 5926, 6380, 6824, 6880, 6895, 7097, 7318, 8630, 8767, 8846, 8959, 9159, 9172, 9577, 9851, 9873, 9887, 10154, 10341, 10683, 10702, 10729, 10901, 11354, 11598, 11935, 12002, 12083, 12252, 12552, 12746, 12979, 13759, 13856, 14271, 14456, 14502, 14810, 14834, 14859, 14943, 15204, 15791, 15868, 16230, 16333, 16660, 17602, 17861, 17919, 18098, 18176, 18255, 18469, 18598, 18973, 19019, 19548, 19612, 19719, 19767 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(393, result.number);
            Assert.AreEqual(872636, result.newNumber);
        }


        [TestMethod]
        public void TestMethod157()
        {
            int[] numbers = new int[] { 300, 3403, 10169, 11182, 13773, 15469 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(300, result.number);
            Assert.AreEqual(1, result.newNumber);
        }


        [TestMethod]
        public void TestMethod158()
        {
            int[] numbers = new int[] { 65, 1180, 1523, 2099, 2214, 2217, 2221, 3765, 4163, 4342, 4877, 5057, 5330, 5377, 5789, 5853, 6951, 7152, 7594, 7602, 7752, 7896, 8171, 8718, 9000, 9321, 9544, 9718, 10000, 10223, 11298, 11314, 12593, 12622, 12978, 13255, 13652, 14066, 14187, 14531, 14603, 14989, 15070, 15240, 15566, 16268, 16394, 16532, 16661, 17474, 17613, 17648, 17991, 18034, 18142, 18423, 18559, 18776, 18859, 19200 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1180, result.number);
            Assert.AreEqual(630484, result.newNumber);
        }


        [TestMethod]
        public void TestMethod159()
        {
            int[] numbers = new int[] { 21, 45, 141, 212, 320, 391, 436, 524, 540, 601, 669, 697, 713, 724, 745, 809, 1151, 1325, 1568, 1667, 1870, 1882, 2070, 2098, 2125, 2131, 2157, 2363, 2814, 2835, 2853, 2978, 3077, 3494, 3536, 3632, 3645, 3652, 3926, 4152, 4647, 4726, 4813, 5160, 5188, 5213, 5214, 5248, 5299, 5380, 5437, 5518, 5568, 5706, 5724, 5845, 5984, 6046, 6055, 6091, 6353, 6400, 6573, 6630, 6694, 6895, 7001, 7373, 7706, 7784, 7843, 7852, 7994, 8042, 8046, 8067, 8203, 8290, 8302, 8329, 8345, 8414, 8415, 8540, 8555, 8565, 8607, 8642, 8905, 8970, 9023, 9247, 9343, 9373, 9419, 9713, 9904, 10179, 10187, 10193, 10215, 10276, 10391, 10519, 10719, 10735, 10761, 10839, 10935, 11013, 11151, 11196, 11272, 11285, 11389, 11441, 11557, 11594, 11735, 11748, 11911, 12046, 12148, 12169, 12197, 12211, 12251, 12265, 12289, 12318, 12324, 12460, 12521, 12523, 12601, 12791, 12869, 12890, 12919, 12963, 12965, 12965, 13077, 13184, 13191, 13274, 13369, 13517, 13542, 13574, 13689, 13769, 13828, 13833, 13990, 14021, 14096, 14170, 14295, 14367, 14513, 14604, 14627, 14656, 14916, 15005, 15008, 15144, 15224, 15304, 15332, 15339, 15382, 15387, 15428, 15695, 15931, 15939, 16039, 16048, 16125, 16130, 16146, 16171, 16195, 16249, 16253, 16356, 16357, 16368, 16493, 16562, 16606, 16646, 16716, 16735, 16890, 16980, 16995, 17025, 17169, 17174, 17334, 17470, 17480, 17607, 17653, 17732, 18073, 18173, 18183, 18221, 18245, 18378, 18489, 18516, 18564, 18564, 18615, 18683, 18691, 18732, 18769, 18855, 18959, 18983, 19025, 19341, 19377, 19730, 19756, 19860 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(45, result.number);
            Assert.AreEqual(2478910, result.newNumber);
        }


        [TestMethod]
        public void TestMethod160()
        {
            int[] numbers = new int[] { 206, 310, 396, 463, 646, 862, 893, 913, 1245, 1386, 1709, 1734, 1738, 1828, 2051, 2171, 2224, 2278, 2316, 2381, 2388, 2665, 2698, 2997, 3097, 3327, 3577, 3659, 3683, 3727, 3964, 4820, 4881, 5197, 5202, 5211, 5309, 5578, 5598, 5857, 5973, 6340, 6866, 7431, 7436, 7480, 7590, 8067, 8245, 8273, 8298, 8478, 8641, 8752, 8774, 8841, 8921, 9564, 9577, 9977, 10000, 10056, 10536, 10607, 11031, 11555, 11606, 12028, 12098, 12387, 12449, 13090, 13456, 13542, 13628, 14063, 14092, 14514, 14976, 15155, 15252, 15260, 15368, 15385, 15448, 15487, 15824, 16179, 16250, 16287, 16351, 16473, 16918, 17147, 17165, 17326, 17356, 17505, 17589, 17634, 17706, 17765, 17975, 17987, 18020, 18102, 18157, 18248, 18316, 18546, 18879, 18961, 19447, 19555, 19614, 19821, 19929, 19970 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(396, result.number);
            Assert.AreEqual(1186120, result.newNumber);
        }


        [TestMethod]
        public void TestMethod161()
        {
            int[] numbers = new int[] { 12, 95, 279, 290, 363, 465, 487, 842, 974, 1061, 1316, 1361, 1416, 1460, 1553, 1656, 1727, 1805, 1811, 1910, 2061, 2082, 2100, 2104, 2105, 2170, 2268, 2396, 2501, 2587, 2657, 2956, 3047, 3065, 3124, 3316, 3520, 3595, 3595, 3799, 3812, 3886, 4068, 4088, 4366, 4408, 4412, 4479, 4617, 4676, 4696, 4886, 5094, 5094, 5193, 5270, 5308, 5364, 5364, 5507, 5842, 6035, 6054, 6224, 6338, 6475, 6616, 6622, 6640, 6678, 6724, 6785, 7229, 7242, 7459, 7500, 7572, 7574, 7773, 7882, 7949, 8055, 8277, 8432, 8631, 8723, 8842, 8956, 9113, 9115, 9155, 9321, 9335, 9420, 9435, 9436, 9470, 9509, 9594, 9671, 9903, 9921, 9932, 9965, 10047, 10127, 10200, 10205, 10285, 10426, 10488, 10545, 10707, 10774, 10799, 10920, 10921, 10968, 11055, 11092, 11185, 11300, 11330, 11402, 11442, 11521, 11691, 11734, 11811, 11930, 12012, 12025, 12187, 12534, 12592, 12612, 12709, 12830, 12890, 13083, 13108, 13307, 13450, 13470, 13473, 13537, 13647, 13744, 13861, 13901, 13909, 13934, 13998, 14011, 14032, 14271, 14321, 14439, 14535, 14546, 14688, 14735, 14740, 14772, 14880, 14962, 15222, 15293, 15546, 15548, 15585, 15666, 15813, 15857, 15938, 15947, 15965, 16125, 16195, 16486, 16496, 16521, 16528, 16772, 16883, 16955, 16970, 17282, 17288, 17338, 17369, 17404, 17446, 17493, 17518, 17563, 17592, 17880, 18067, 18086, 18098, 18235, 18242, 18278, 18285, 18409, 18575, 18591, 18788, 18886, 19173, 19304, 19332, 19387, 19505, 19566, 19765 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(279, result.number);
            Assert.AreEqual(2188927, result.newNumber);
        }


        [TestMethod]
        public void TestMethod162()
        {
            int[] numbers = new int[] { 11, 187, 303, 471, 475, 512, 515, 601, 916, 933, 1124, 1289, 1328, 1345, 1390, 1483, 1573, 1622, 1957, 1963, 2055, 2132, 2211, 2355, 2401, 2462, 2482, 2496, 2497, 2507, 2534, 2563, 2718, 2724, 2750, 2752, 2770, 2809, 2850, 2988, 3062, 3098, 3270, 3325, 3428, 3438, 3444, 3507, 3535, 3592, 3726, 3785, 3954, 3987, 4109, 4143, 4256, 4261, 4447, 4453, 4711, 4945, 4950, 4963, 5027, 5063, 5236, 5303, 5474, 5603, 5697, 5737, 5742, 5777, 5777, 5866, 5911, 5994, 6024, 6190, 6202, 6214, 6255, 6466, 6472, 6514, 6654, 6665, 6825, 6849, 6875, 6987, 7076, 7368, 7394, 7472, 7541, 7546, 7554, 7797, 7882, 7968, 8479, 8602, 8708, 8729, 8750, 8758, 8802, 8873, 8912, 8975, 9058, 9080, 9158, 9236, 9249, 9525, 9526, 9574, 9628, 9645, 9685, 9695, 9783, 9788, 9858, 9946, 10066, 10106, 10259, 10289, 10408, 10410, 10433, 10557, 10765, 10811, 10833, 11153, 11210, 11219, 11246, 11271, 11287, 11360, 11434, 11563, 11584, 11768, 11826, 12074, 12108, 12146, 12147, 12178, 12394, 12410, 12588, 12633, 12645, 12652, 12661, 12799, 12818, 12888, 12916, 13007, 13081, 13083, 13123, 13498, 13502, 13613, 13634, 13743, 13748, 13895, 13919, 14188, 14300, 14308, 14319, 14659, 14680, 14891, 14957, 15021, 15102, 15102, 15143, 15158, 15255, 15414, 15454, 15502, 15552, 15560, 15768, 15801, 15969, 16159, 16215, 16236, 16288, 16324, 16490, 16524, 16530, 16551, 16569, 16587, 16613, 16707, 16940, 17173, 17390, 17512, 17529, 17706, 17711, 17883, 17951, 18087, 18255, 18398, 18440, 18481, 18481, 18594, 18758, 18764, 18823, 18851, 18992, 19162, 19193, 19700, 19804, 19955, 19964 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(11, result.number);
            Assert.AreEqual(2305748, result.newNumber);
        }


        [TestMethod]
        public void TestMethod163()
        {
            int[] numbers = new int[] { 127, 261, 361, 450, 774, 958, 1214, 1722, 1754, 2009, 2122, 2122, 2201, 2407, 2797, 2801, 3115, 3721, 3982, 4103, 4394, 4495, 4750, 5463, 5880, 6097, 6330, 6358, 7453, 7497, 7772, 8073, 8304, 8651, 8895, 9159, 9178, 9694, 9802, 9864, 10142, 10313, 10334, 10393, 11286, 11292, 11570, 11627, 11734, 11788, 12060, 12259, 12343, 12737, 12943, 13009, 14462, 14643, 14778, 15064, 15278, 15363, 15661, 16009, 16177, 16229, 16370, 16796, 17242, 17372, 19497 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(361, result.number);
            Assert.AreEqual(607539, result.newNumber);
        }


        [TestMethod]
        public void TestMethod164()
        {
            int[] numbers = new int[] { 6897, 7699, 9147, 9919, 10057, 11454, 12127, 12163, 12764, 13906, 14715, 15041, 16622, 17065, 19529 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(9919, result.number);
            Assert.AreEqual(79062, result.newNumber);
        }


        [TestMethod]
        public void TestMethod165()
        {
            int[] numbers = new int[] { 13, 20, 73, 322, 399, 426, 545, 559, 651, 695, 781, 911, 970, 1017, 1302, 1320, 1579, 1584, 1831, 1967, 1992, 2049, 2160, 2182, 2199, 2224, 2256, 2290, 2310, 2318, 2423, 2594, 2641, 2829, 2992, 3066, 3074, 3314, 3392, 3504, 3519, 3759, 4036, 4077, 4148, 4336, 4633, 4706, 4858, 4931, 4932, 5014, 5163, 5276, 5301, 5314, 5320, 6019, 6287, 6785, 7175, 7357, 7730, 7833, 8051, 8087, 8171, 8381, 8678, 8934, 8984, 9061, 9068, 9378, 9520, 9768, 9833, 9839, 9863, 9882, 9977, 10049, 10171, 10297, 10361, 10549, 10559, 10700, 10757, 10812, 10957, 11117, 11341, 11385, 11423, 11636, 11726, 11772, 11792, 11870, 11943, 12051, 12233, 12305, 12336, 12451, 12584, 12592, 12642, 12803, 12882, 13195, 13583, 13590, 13954, 13962, 13973, 14039, 14057, 14381, 14473, 14503, 14519, 14552, 14830, 15346, 15444, 15541, 15611, 15712, 15762, 15806, 15823, 15843, 16206, 16262, 16283, 16563, 16624, 16703, 16918, 17002, 17021, 17105, 17384, 17480, 17588, 17730, 17919, 18054, 18127, 18202, 18207, 18228, 18279, 18437, 18453, 18461, 18560, 18596, 18939, 18949, 19175, 19198, 19612, 19617, 19661, 19770, 19836, 19849, 19968 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(73, result.number);
            Assert.AreEqual(1706313, result.newNumber);
        }


        [TestMethod]
        public void TestMethod166()
        {
            int[] numbers = new int[] { 115, 435, 702, 750, 981, 1065, 1981, 2230, 2576, 2603, 2816, 2896, 3106, 3236, 3556, 3659, 3765, 3774, 3989, 4093, 4164, 4308, 4537, 5514, 5621, 5621, 5853, 5863, 5910, 6418, 6452, 6496, 6807, 7114, 7867, 8048, 8121, 8147, 8167, 8525, 8798, 9332, 9486, 9753, 9851, 10212, 10705, 10863, 10949, 11138, 11467, 11625, 11733, 11785, 11820, 11968, 12167, 12370, 12520, 12571, 12712, 12765, 12954, 13580, 13742, 13766, 13854, 13947, 14159, 14388, 14597, 15012, 15313, 15559, 16319, 16874, 16962, 16972, 17182, 17215, 17252, 17353, 17367, 17383, 17399, 17452, 17500, 17743, 18535, 18584, 18666, 18830, 19203, 19595, 19659, 19757 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(115, result.number);
            Assert.AreEqual(980798, result.newNumber);
        }


        [TestMethod]
        public void TestMethod167()
        {
            int[] numbers = new int[] { 50, 102, 151, 170, 379, 401, 423, 446, 752, 786, 933, 946, 1028, 1040, 1102, 1124, 1182, 1219, 1357, 1372, 1552, 1623, 1638, 1779, 1880, 2027, 2149, 2254, 2277, 2335, 2366, 2440, 2490, 2570, 2718, 2778, 2840, 2858, 2898, 2971, 3000, 3022, 3024, 3045, 3061, 3327, 3364, 3653, 3761, 3772, 3826, 3894, 3929, 3949, 4016, 4038, 4162, 4287, 4606, 4740, 5108, 5153, 5216, 5305, 5870, 6001, 6078, 6107, 6157, 6250, 6435, 6566, 6705, 6809, 6858, 6878, 6929, 6956, 7041, 7129, 7219, 7230, 7268, 7298, 7331, 7356, 7362, 7403, 7458, 7490, 7526, 7705, 7743, 7937, 7947, 8045, 8113, 8160, 8196, 8203, 8323, 8430, 8681, 8782, 8800, 8984, 9065, 9133, 9249, 9263, 9319, 9351, 9383, 9435, 9484, 9498, 9552, 9606, 9611, 9733, 9736, 9831, 9900, 9983, 10116, 10122, 10213, 10216, 10254, 10298, 10311, 10498, 10519, 10532, 10579, 10713, 10894, 10945, 11140, 11146, 11154, 11157, 11180, 11224, 11250, 11280, 11294, 11357, 11403, 11491, 11781, 11809, 11936, 11959, 12063, 12067, 12072, 12160, 12184, 12237, 12271, 12491, 12807, 12813, 12969, 12996, 13063, 13078, 13177, 13194, 13201, 13241, 13514, 13624, 13661, 13740, 13814, 14093, 14201, 14244, 14277, 14313, 14441, 14499, 14564, 14587, 14606, 14609, 14699, 14938, 14962, 14974, 15115, 15183, 15227, 15238, 15474, 15570, 15591, 15713, 15968, 15987, 15991, 16097, 16130, 16339, 16509, 16647, 16684, 16739, 16975, 17007, 17181, 17188, 17247, 17372, 17376, 17492, 17495, 17511, 17576, 17687, 17841, 17963, 18021, 18069, 18124, 18198, 18206, 18225, 18280, 18330, 18370, 18372, 18405, 18493, 18631, 18649, 18670, 18810, 18880, 18963, 19039, 19073, 19152, 19198, 19217, 19238, 19300, 19349, 19399, 19498, 19589, 19632, 19740, 19835, 19929, 19996 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(102, result.number);
            Assert.AreEqual(2651932, result.newNumber);
        }


        [TestMethod]
        public void TestMethod168()
        {
            int[] numbers = new int[] { 165, 276, 329, 389, 520, 924, 1038, 1080, 1218, 1439, 1763, 1848, 1931, 1937, 2003, 2159, 2286, 2324, 2459, 2467, 2525, 2585, 2684, 2806, 2930, 2987, 3154, 3493, 3571, 3673, 3782, 3903, 3944, 4189, 4271, 4573, 4816, 4859, 5009, 5111, 5120, 5284, 5437, 5527, 5725, 5764, 5834, 5947, 6006, 6038, 6053, 6106, 6114, 6251, 6321, 6344, 6410, 6461, 6462, 6480, 6744, 6770, 7268, 7360, 7384, 7387, 7393, 7482, 7600, 7681, 7780, 7781, 7973, 7980, 8077, 8140, 8201, 8350, 8867, 8905, 8968, 9106, 9129, 9138, 9239, 9430, 9435, 9700, 9757, 9759, 9827, 9921, 9927, 10078, 10347, 10406, 10601, 10760, 10772, 10897, 10933, 11170, 11253, 11656, 11662, 11818, 11858, 11909, 12052, 12107, 12332, 12774, 12796, 13102, 13250, 13295, 13516, 13807, 13894, 13981, 14150, 14223, 14254, 14468, 14529, 14643, 14715, 14753, 14759, 14835, 14865, 14972, 15083, 15470, 16238, 16366, 16403, 16490, 16727, 16878, 16955, 17090, 17135, 17193, 17522, 18029, 18213, 18667, 18680, 18794, 18934, 18938, 18939, 19074, 19128, 19283, 19456, 19521, 19670, 19976, 19994 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(520, result.number);
            Assert.AreEqual(1516256, result.newNumber);
        }


        [TestMethod]
        public void TestMethod169()
        {
            int[] numbers = new int[] { 33, 95, 110, 114, 121, 198, 350, 520, 663, 669, 780, 814, 887, 969, 990, 1017, 1107, 1139, 1218, 1249, 1293, 1475, 1555, 1592, 1605, 1653, 2085, 2133, 2138, 2179, 2181, 2263, 2354, 2445, 2460, 2477, 2534, 2547, 2560, 2597, 2687, 2720, 2745, 2783, 2873, 2998, 3021, 3202, 3244, 3378, 3417, 3459, 3491, 3586, 3611, 3658, 3733, 3794, 4261, 4282, 4309, 4322, 4322, 4387, 4419, 4478, 4757, 4878, 4878, 4924, 4927, 4995, 5060, 5322, 5347, 5442, 5444, 5667, 5725, 5726, 5729, 5767, 5796, 5826, 5873, 6029, 6056, 6115, 6116, 6118, 6231, 6329, 6419, 6508, 6555, 6643, 6712, 6889, 6902, 6962, 7009, 7051, 7059, 7059, 7063, 7134, 7165, 7215, 7408, 7451, 7460, 7518, 7594, 7676, 7747, 7906, 7946, 7991, 8044, 8064, 8137, 8212, 8216, 8306, 8426, 8489, 8535, 8658, 8666, 8800, 8829, 8881, 8933, 9053, 9088, 9232, 9359, 9439, 9492, 9537, 9556, 9657, 9914, 9986, 10011, 10014, 10058, 10109, 10128, 10173, 10212, 10260, 10378, 10450, 10535, 10629, 10746, 10764, 10777, 10837, 10837, 10922, 10966, 10990, 11178, 11188, 11229, 11277, 11350, 11421, 11429, 11510, 11549, 11611, 11635, 12044, 12062, 12080, 12142, 12220, 12242, 12511, 12968, 13002, 13056, 13095, 13110, 13135, 13143, 13179, 13209, 13237, 13395, 13480, 13483, 13493, 13931, 14020, 14115, 14117, 14123, 14160, 14183, 14214, 14246, 14316, 14401, 14665, 14676, 14858, 14869, 14897, 14961, 15048, 15107, 15233, 15322, 15322, 15392, 15521, 15620, 15658, 15676, 15764, 15817, 15863, 15865, 15906, 16001, 16032, 16179, 16247, 16303, 16342, 16552, 16570, 16679, 16685, 16791, 16913, 16923, 16958, 16991, 17040, 17056, 17096, 17109, 17262, 17345, 17406, 17483, 17689, 17767, 17809, 17831, 18070, 18094, 18320, 18430, 18560, 18661, 18757, 18900, 18934, 18957, 19031, 19062, 19277, 19287, 19419, 19436, 19440, 19550, 19612, 19613, 19648, 19681, 19751, 19901, 19942 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(110, result.number);
            Assert.AreEqual(2729504, result.newNumber);
        }


        [TestMethod]
        public void TestMethod170()
        {
            int[] numbers = new int[] { 73, 146, 161, 176, 194, 195, 226, 236, 647, 682, 757, 959, 1061, 1106, 1137, 1180, 1459, 1512, 1524, 1556, 1649, 1707, 1899, 1980, 1991, 2000, 2062, 2097, 2123, 2398, 2471, 2608, 2674, 2697, 2756, 2912, 3142, 3266, 3402, 3476, 3499, 3509, 3559, 3616, 3709, 3714, 3772, 3775, 3984, 4009, 4042, 4080, 4109, 4154, 4182, 4220, 4328, 4564, 4716, 4783, 4891, 4974, 5036, 5139, 5264, 5275, 5288, 5356, 5377, 5384, 5525, 5531, 5544, 5630, 5887, 5976, 6037, 6128, 6199, 6436, 6449, 6556, 6569, 6641, 6738, 6750, 6801, 6835, 6867, 6999, 7013, 7086, 7155, 7243, 7423, 7442, 7471, 7515, 7541, 7550, 7625, 7642, 7663, 7686, 7830, 7898, 7920, 7987, 8088, 8228, 8264, 8402, 8427, 8477, 8522, 8626, 8630, 8788, 8801, 8814, 8862, 9164, 9302, 9359, 9399, 9407, 9434, 9461, 9563, 9642, 9666, 9727, 9796, 9825, 10022, 10047, 10051, 10063, 10159, 10384, 10422, 10486, 10529, 10558, 10599, 10645, 10652, 10788, 10901, 10938, 10953, 11101, 11136, 11138, 11196, 11210, 11216, 11240, 11306, 11361, 11363, 11401, 11420, 11471, 11551, 11562, 11568, 11665, 11808, 12057, 12157, 12205, 12345, 12597, 12764, 12802, 12868, 12978, 13062, 13074, 13175, 13293, 13305, 13354, 13363, 13502, 13574, 13609, 13749, 13761, 13770, 13782, 13887, 13956, 13962, 14087, 14211, 14327, 14446, 14675, 14694, 14720, 14810, 14835, 14961, 15067, 15139, 15196, 15212, 15227, 15253, 15277, 15353, 15672, 15712, 15732, 15842, 15913, 16132, 16583, 16846, 16865, 16976, 17048, 17095, 17289, 17385, 17596, 17629, 17645, 17652, 17784, 17835, 17838, 18033, 18200, 18228, 18286, 18414, 18416, 18487, 18518, 18754, 18902, 18925, 18995, 19014, 19022, 19052, 19153, 19347, 19402, 19476, 19492, 19686, 19702, 19742, 19951, 19951 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(236, result.number);
            Assert.AreEqual(2515087, result.newNumber);
        }


        [TestMethod]
        public void TestMethod171()
        {
            int[] numbers = new int[] { 139, 325, 399, 486, 1079, 1110, 1539, 1566, 1692, 1784, 1985, 2027, 2304, 2439, 2470, 2743, 2760, 3098, 3332, 3361, 3408, 3467, 3501, 3502, 3734, 3754, 3774, 3961, 4033, 4047, 4140, 4277, 4311, 4554, 4635, 4827, 4945, 5142, 5171, 5291, 5444, 5729, 6597, 6731, 6808, 6938, 7149, 7161, 7238, 7249, 7638, 7800, 8369, 8600, 8806, 9293, 9393, 9588, 9684, 9712, 9764, 9863, 10123, 10135, 10292, 10323, 10432, 10523, 11068, 11518, 11769, 11927, 12183, 12255, 12579, 12592, 13256, 13292, 13527, 13549, 13601, 13638, 13684, 13791, 13802, 13877, 13959, 14800, 14847, 14991, 15554, 15778, 15938, 16244, 16262, 16541, 16551, 16584, 16620, 16912, 17088, 17096, 17452, 17510, 17683, 18318, 18512, 18635, 18913, 19120, 19137, 19255, 19374, 19444, 19577 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(139, result.number);
            Assert.AreEqual(1083635, result.newNumber);
        }


        [TestMethod]
        public void TestMethod172()
        {
            int[] numbers = new int[] { 38, 161, 428, 437, 818, 1238, 1600, 1749, 2801, 3227, 3558, 4108, 4198, 4326, 4399, 4472, 4717, 4914, 5365, 6028, 6350, 6791, 6961, 6990, 7561, 7809, 7857, 8143, 8240, 8251, 9075, 9286, 9374, 10285, 10486, 11236, 11260, 12479, 13055, 13164, 13308, 13371, 14105, 14578, 14642, 15091, 15112, 15703, 15754, 15816, 16083, 16137, 16425, 16508, 16865, 17822, 18463, 18946, 19269, 19296, 19701, 19720, 19838, 19878, 19920 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(161, result.number);
            Assert.AreEqual(656608, result.newNumber);
        }


        [TestMethod]
        public void TestMethod173()
        {
            int[] numbers = new int[] { 254, 394, 498, 513, 892, 946, 1010, 1071, 1078, 1307, 1323, 1547, 1973, 2259, 2360, 2533, 2854, 3116, 3160, 3305, 3449, 3580, 3611, 3653, 3880, 4030, 4063, 4079, 4083, 4369, 4520, 4902, 5015, 5228, 5344, 5533, 5892, 6211, 6488, 6605, 6636, 7057, 7133, 7601, 7839, 8273, 8290, 8676, 8732, 8801, 9407, 9859, 10022, 10102, 10177, 10180, 10216, 10294, 10575, 10684, 10766, 10954, 10961, 11003, 11406, 11448, 11724, 11831, 12103, 12431, 12596, 12644, 12656, 12807, 12850, 12933, 12942, 12943, 13477, 13606, 13747, 13791, 13927, 13955, 14359, 14403, 14676, 14799, 14934, 15246, 15521, 15523, 15867, 16229, 16455, 16523, 16593, 16628, 16696, 17260, 17473, 17661, 18191, 18297, 18551, 18894, 19160, 19307, 19565, 19601, 19623, 19811, 19965 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(394, result.number);
            Assert.AreEqual(1099505, result.newNumber);
        }


        [TestMethod]
        public void TestMethod174()
        {
            int[] numbers = new int[] { 29, 79, 282, 320, 439, 743, 776, 828, 834, 883, 966, 1058, 1210, 1320, 1325, 1413, 1467, 1656, 1765, 1778, 1797, 1977, 2000, 2076, 2124, 2389, 2450, 2467, 2528, 2721, 2741, 2833, 2929, 3109, 3114, 3177, 3234, 3287, 3287, 3416, 3497, 3550, 3618, 3761, 3848, 3922, 4042, 4199, 4204, 4250, 4412, 4432, 4451, 4641, 4799, 4906, 4937, 5249, 5357, 5384, 5612, 5648, 5735, 5878, 5929, 6031, 6132, 6132, 6219, 6252, 6467, 6566, 6584, 6896, 6984, 7054, 7085, 7190, 7313, 7432, 7524, 7602, 7818, 7820, 8030, 8122, 8125, 8150, 8254, 8295, 8474, 8480, 8562, 9087, 9165, 9324, 9406, 9434, 9521, 9824, 10099, 10281, 10370, 10411, 10420, 10462, 10477, 10608, 10815, 11017, 11089, 11098, 11200, 11343, 11486, 11596, 11704, 11722, 11900, 11947, 11989, 12059, 12084, 12269, 12276, 12278, 12354, 12550, 12565, 12975, 13109, 13146, 13170, 13254, 13282, 13304, 13530, 13586, 13637, 13678, 13723, 13827, 13890, 13937, 14030, 14187, 14266, 14317, 14351, 14630, 14773, 14844, 14845, 14860, 15033, 15227, 15347, 15386, 15614, 15653, 15742, 15773, 15918, 15945, 16080, 16359, 16390, 16470, 16620, 16706, 16738, 17184, 17252, 17449, 17486, 17528, 17733, 17945, 18301, 18302, 18311, 18492, 18516, 18697, 18797, 18798, 19016, 19024, 19071, 19147, 19153, 19210, 19325, 19413, 19475, 19607, 19805 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(282, result.number);
            Assert.AreEqual(1889480, result.newNumber);
        }


        [TestMethod]
        public void TestMethod175()
        {
            int[] numbers = new int[] { 33, 85, 258, 270, 353, 485, 636, 829, 1109, 1143, 1165, 1376, 1648, 1769, 1776, 1888, 2229, 2411, 2514, 2520, 2523, 2558, 2590, 2610, 2619, 2712, 2713, 2753, 2803, 2834, 2935, 2947, 2949, 3164, 3403, 3458, 3589, 3613, 3644, 3648, 3749, 3760, 3787, 3798, 3862, 4065, 4176, 4220, 4236, 4321, 4329, 4349, 4369, 4458, 4607, 4810, 4895, 4974, 5056, 5075, 5143, 5235, 5326, 5346, 5358, 5420, 5573, 5783, 5843, 5951, 5977, 6221, 6386, 6390, 6564, 6619, 6848, 6951, 7003, 7081, 7154, 7200, 7237, 7279, 7330, 7418, 7533, 7658, 7752, 7811, 7816, 7820, 7931, 8078, 8448, 8582, 8584, 8805, 8974, 9049, 9095, 9182, 9238, 9329, 9381, 9599, 9883, 9968, 10111, 10207, 10286, 10454, 10458, 10609, 10699, 10790, 10813, 10903, 11117, 11187, 11191, 11414, 11475, 11514, 11673, 11703, 11732, 11988, 12075, 12214, 12246, 12300, 12435, 12455, 12526, 12763, 12835, 13128, 13243, 13368, 13678, 13734, 13835, 13950, 14071, 14074, 14130, 14149, 14234, 14305, 14416, 14455, 14507, 14544, 14573, 14583, 14595, 14664, 14824, 14834, 14892, 14964, 15115, 15138, 15165, 15300, 15750, 15904, 16027, 16067, 16192, 16446, 16472, 16541, 16560, 16633, 16903, 17100, 17154, 17184, 17357, 17534, 17534, 17762, 17781, 17835, 17839, 17909, 17969, 18119, 18141, 18393, 18396, 18493, 18603, 18732, 18841, 18888, 19128, 19149, 19206, 19251, 19284, 19381, 19473, 19488, 19732, 19741, 19746, 19776 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(85, result.number);
            Assert.AreEqual(2062591, result.newNumber);
        }


        [TestMethod]
        public void TestMethod176()
        {
            int[] numbers = new int[] { 157, 446, 551, 668, 801, 863, 1156, 1318, 1387, 1579, 1809, 2124, 2131, 2387, 2403, 2642, 2724, 2739, 2813, 2860, 3082, 3296, 3366, 3372, 3406, 3550, 3653, 3660, 3666, 3788, 4094, 4108, 4312, 4424, 4513, 4945, 5017, 5060, 5293, 5299, 5302, 5397, 5677, 5917, 5931, 5943, 6064, 6076, 6223, 6373, 6488, 6578, 6625, 6753, 6801, 6806, 6936, 7001, 7148, 7372, 7486, 7642, 7703, 7713, 7778, 7780, 7929, 8008, 8065, 8187, 8230, 8504, 8585, 8603, 8864, 8969, 8974, 9343, 9385, 9497, 9561, 9605, 9611, 9635, 9660, 9892, 10172, 10188, 10222, 10231, 10273, 10515, 10633, 10665, 10911, 10939, 11098, 11251, 11254, 11350, 11443, 11774, 11796, 11909, 11939, 12070, 12126, 12429, 12474, 12481, 12517, 12519, 12633, 12786, 13045, 13185, 13264, 13265, 13274, 13310, 13470, 13578, 13748, 13857, 13891, 13919, 14003, 14031, 14172, 14187, 14338, 14417, 14486, 14563, 14581, 14695, 14731, 14746, 15013, 15015, 15321, 15344, 15558, 15589, 15641, 15795, 15795, 15891, 15923, 15967, 16013, 16040, 16147, 16270, 16277, 16369, 16561, 16870, 17006, 17067, 17106, 17198, 17219, 17488, 17689, 17706, 17707, 17772, 17870, 18001, 18061, 18096, 18294, 18359, 18360, 18369, 18397, 18543, 18569, 18595, 18637, 18670, 18842, 18892, 18994, 19052, 19089, 19156, 19196, 19218, 19218, 19282, 19318, 19334, 19371, 19386, 19548, 19645, 19821, 19827, 19838 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(446, result.number);
            Assert.AreEqual(2233234, result.newNumber);
        }


        [TestMethod]
        public void TestMethod177()
        {
            int[] numbers = new int[] { 128, 457, 769, 828, 922, 1073, 1151, 1387, 1482, 1485, 1700, 1916, 1941, 2092, 2495, 2787, 2807, 2903, 2945, 3143, 3376, 3450, 3534, 3671, 3675, 3866, 3910, 3970, 4129, 4264, 4465, 4757, 4996, 5255, 5452, 5475, 5638, 5907, 6309, 6488, 6911, 6915, 6962, 6979, 7679, 7775, 7908, 8021, 8203, 9110, 9217, 9644, 9821, 9876, 9919, 10044, 10084, 10188, 10315, 10493, 10591, 10968, 11505, 11615, 11654, 12001, 12314, 12430, 12545, 13645, 13746, 13915, 13990, 14237, 14317, 14344, 14408, 14417, 14454, 14557, 14664, 15565, 16486, 16594, 16640, 16735, 16792, 16951, 17204, 17451, 18032, 18265, 18448, 18490, 18918, 18977, 19526, 19584, 19768 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(128, result.number);
            Assert.AreEqual(893656, result.newNumber);
        }


        [TestMethod]
        public void TestMethod178()
        {
            int[] numbers = new int[] { 83, 115, 143, 198, 370, 755, 767, 1120, 1325, 1355, 1737, 1750, 1863, 1893, 1897, 2236, 2273, 2422, 2503, 2724, 2737, 2902, 3012, 3035, 3091, 3251, 3262, 3276, 3277, 3291, 3390, 3658, 3699, 3713, 3805, 4055, 4070, 4111, 4174, 4226, 4400, 4422, 4590, 4637, 4694, 4752, 5189, 5232, 5361, 5378, 5507, 5555, 5657, 5832, 5841, 5892, 6077, 6149, 6221, 6387, 6442, 6526, 6573, 6749, 6876, 6922, 7185, 7326, 7395, 7424, 7624, 7631, 7687, 7738, 7868, 7971, 8062, 8182, 8405, 8418, 8475, 8476, 8639, 8640, 8837, 9094, 9105, 9544, 9919, 9956, 10005, 10095, 10149, 10226, 10228, 10291, 10302, 10502, 10763, 11142, 11211, 11396, 11437, 11443, 11586, 11819, 11841, 12025, 12336, 12407, 12438, 12561, 12580, 12616, 12828, 13026, 13133, 13203, 13336, 13486, 13653, 13654, 13692, 13756, 13797, 14017, 14054, 14191, 14540, 14764, 14859, 14973, 14991, 15014, 15104, 15115, 15159, 15339, 15456, 15603, 15743, 15745, 15924, 16079, 16224, 16650, 16685, 16864, 16967, 17088, 17278, 17313, 17402, 17572, 17733, 17816, 17824, 17947, 18078, 18149, 18180, 18312, 18380, 18563, 18932, 19147, 19209, 19299, 19360, 19767, 19820 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(198, result.number);
            Assert.AreEqual(1633598, result.newNumber);
        }


        [TestMethod]
        public void TestMethod179()
        {
            int[] numbers = new int[] { 912, 1592, 1608, 1740, 1805, 4426, 4616, 6111, 7110, 7519, 8532, 9627, 10601, 11065, 11671, 12415, 12480, 12655, 15783, 16708 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1805, result.number);
            Assert.AreEqual(124846, result.newNumber);
        }


        [TestMethod]
        public void TestMethod180()
        {
            int[] numbers = new int[] { 29, 77, 432, 694, 859, 989, 1450, 1484, 1580, 1596, 1806, 1807, 2007, 2042, 2275, 2365, 2368, 2571, 2703, 2747, 2932, 2990, 3030, 3424, 3447, 3614, 3716, 3854, 3881, 4073, 4081, 4154, 4183, 4207, 4498, 5044, 5131, 5444, 5537, 5857, 5986, 6633, 7166, 7169, 7401, 7591, 7654, 7820, 7885, 7962, 8158, 8459, 8557, 8826, 9038, 9411, 9540, 9541, 9756, 9892, 9951, 10357, 10487, 10491, 10821, 10902, 10951, 11028, 11339, 11383, 11434, 11444, 11444, 11529, 11582, 11684, 11731, 11904, 11951, 12038, 12191, 12212, 12254, 12628, 12649, 12654, 12741, 12789, 12919, 12979, 13015, 13031, 13091, 13176, 13218, 13250, 13487, 13554, 13798, 13942, 13946, 14018, 14180, 14206, 14269, 14339, 14403, 14413, 14665, 14744, 14883, 15546, 15606, 15612, 15614, 15850, 16015, 16058, 16138, 16445, 16504, 16613, 16672, 17097, 17118, 17195, 17202, 17325, 17490, 17597, 17859, 17952, 18457, 18686, 18775, 18850, 19006, 19132, 19160, 19399, 19405, 19438, 19491, 19699, 19887 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(432, result.number);
            Assert.AreEqual(1515121, result.newNumber);
        }


        [TestMethod]
        public void TestMethod181()
        {
            int[] numbers = new int[] { 97, 109, 137, 262, 275, 359, 371, 377, 457, 512, 656, 658, 742, 776, 792, 830, 961, 966, 1057, 1141, 1216, 1303, 1314, 1316, 1339, 1484, 1564, 1656, 1690, 1751, 1756, 1798, 1870, 1893, 1907, 1917, 1966, 2055, 2056, 2105, 2110, 2114, 2178, 2196, 2206, 2255, 2411, 2421, 2563, 2619, 2828, 2839, 3069, 3141, 3262, 3265, 3362, 3372, 3379, 3440, 3450, 3508, 3521, 3621, 3627, 3682, 4076, 4197, 4279, 4311, 4459, 4487, 4606, 4686, 4778, 4824, 4836, 4910, 4974, 5032, 5036, 5083, 5337, 5371, 5409, 5429, 5452, 5472, 5524, 5552, 5713, 5762, 5793, 5859, 5904, 5969, 6038, 6044, 6093, 6176, 6274, 6330, 6452, 6572, 6572, 6689, 6735, 6740, 6767, 6812, 6842, 6925, 6951, 6993, 7289, 7511, 7541, 7588, 7621, 7647, 7651, 7659, 7722, 7891, 7914, 7918, 7937, 8170, 8364, 8392, 8532, 8986, 9179, 9195, 9310, 9341, 9354, 9388, 9401, 9412, 9416, 9419, 9424, 9477, 9501, 9549, 9641, 10028, 10099, 10139, 10283, 10493, 10515, 10585, 10600, 10629, 10638, 10716, 11005, 11340, 11410, 11476, 11607, 11732, 11800, 11932, 12016, 12233, 12243, 12261, 12269, 12375, 12381, 12471, 12480, 12489, 12556, 12618, 12619, 12657, 12765, 12771, 12820, 12975, 13002, 13026, 13183, 13203, 13319, 13414, 13617, 13663, 13730, 13905, 14036, 14059, 14101, 14201, 14391, 14427, 14433, 14475, 14565, 14591, 14696, 14698, 14747, 14824, 14852, 14864, 14873, 14975, 14982, 15001, 15057, 15096, 15137, 15175, 15298, 15604, 15681, 15811, 15874, 15903, 15921, 16044, 16124, 16169, 16213, 16229, 16254, 16472, 16508, 16536, 16545, 16660, 16731, 16752, 16761, 16790, 16917, 16922, 17044, 17049, 17064, 17095, 17097, 17152, 17215, 17238, 17315, 17442, 17481, 17521, 17657, 17663, 17792, 17872, 17872, 17888, 17894, 17898, 18047, 18137, 18153, 18243, 18420, 18699, 18752, 18755, 18789, 18856, 18872, 18961, 18967, 19030, 19034, 19096, 19152, 19164, 19257, 19304, 19460, 19472, 19557, 19583, 19690, 19790, 19802, 19895, 19906 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(109, result.number);
            Assert.AreEqual(2885845, result.newNumber);
        }


        [TestMethod]
        public void TestMethod182()
        {
            int[] numbers = new int[] { 32, 55, 189, 192, 354, 433, 618, 626, 770, 865, 1076, 1078, 1118, 1183, 1196, 1237, 1244, 1318, 1332, 1387, 1451, 1570, 1613, 1626, 1702, 1781, 1871, 2194, 2200, 2281, 2310, 2323, 2334, 2397, 2399, 2529, 2609, 2689, 2719, 2767, 2833, 3047, 3198, 3237, 3265, 3328, 3378, 3472, 3650, 3675, 3774, 3970, 4132, 4384, 4407, 4576, 4605, 4765, 5016, 5227, 5245, 5254, 5264, 5315, 5582, 5637, 5815, 5852, 5872, 5902, 5904, 5908, 6040, 6048, 6068, 6093, 6093, 6437, 6470, 6509, 6782, 6811, 6886, 6887, 7042, 7317, 7384, 7539, 7613, 7840, 7870, 7882, 7898, 7906, 7952, 8014, 8310, 8338, 8400, 8920, 8935, 8948, 8984, 9063, 9235, 9303, 9307, 9323, 9433, 9446, 9511, 9583, 9583, 9890, 10015, 10072, 10179, 10322, 10511, 10513, 10566, 10654, 10737, 10778, 10867, 10896, 10940, 11059, 11113, 11147, 11169, 11315, 11587, 11608, 11621, 12055, 12078, 12247, 12326, 12507, 12892, 12980, 13131, 13162, 13176, 13189, 13279, 13294, 13344, 13353, 13401, 13428, 13543, 13565, 13618, 13657, 13697, 13753, 13776, 13981, 14188, 14249, 14304, 14326, 14396, 14440, 14507, 14549, 14586, 14590, 14647, 14727, 14778, 14816, 14891, 14964, 14993, 15121, 15211, 15225, 15225, 15365, 15496, 15632, 15691, 15731, 15766, 15797, 15850, 15946, 16005, 16198, 16301, 16314, 16328, 16451, 16748, 16788, 16830, 16949, 17082, 17090, 17181, 17205, 17212, 17215, 17357, 17378, 17392, 17431, 17443, 17924, 17945, 18007, 18190, 18295, 18357, 18388, 18435, 18557, 18576, 18626, 18650, 18684, 18741, 18806, 18852, 18859, 18862, 19006, 19009, 19015, 19164, 19345, 19427, 19481, 19501, 19502, 19550, 19559, 19618, 19781, 19788, 19866, 19979 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(55, result.number);
            Assert.AreEqual(2543318, result.newNumber);
        }


        [TestMethod]
        public void TestMethod183()
        {
            int[] numbers = new int[] { 320, 581, 615, 630, 630, 631, 703, 710, 1245, 1319, 1613, 1762, 1769, 1821, 1855, 1882, 1985, 2106, 2188, 2707, 2760, 3132, 3239, 3408, 3571, 3750, 3761, 3762, 3775, 3852, 3879, 3891, 4110, 4226, 4232, 4357, 4392, 4482, 4605, 5000, 5278, 5474, 5501, 5597, 5726, 5820, 5992, 5996, 6111, 6569, 6733, 6980, 6999, 7057, 7107, 7280, 7387, 7704, 7734, 7785, 7820, 7885, 7901, 7923, 8005, 8016, 8038, 8059, 8100, 8188, 8218, 8225, 8226, 8229, 8249, 8436, 8566, 8577, 8615, 8635, 8727, 8869, 8873, 8931, 9152, 9286, 9545, 9577, 9936, 9962, 10265, 10287, 10644, 10896, 10958, 11003, 11020, 11037, 11094, 11142, 11162, 11386, 11434, 11443, 11467, 11550, 11901, 12096, 12377, 12396, 12505, 12529, 12550, 12751, 12754, 12903, 12923, 13023, 13025, 13164, 13177, 13203, 13220, 13230, 13615, 13713, 13724, 13736, 13808, 13812, 13876, 13988, 14044, 14064, 14127, 14147, 14150, 14214, 14610, 14690, 14830, 14958, 15005, 15031, 15050, 15140, 15287, 15298, 15310, 15432, 15572, 15618, 15643, 15661, 15773, 15849, 15948, 15977, 16060, 16142, 16149, 16218, 16220, 16322, 16346, 16379, 16794, 16867, 16886, 17055, 17133, 17162, 17385, 17463, 17577, 17646, 17697, 18038, 18289, 18436, 18440, 18446, 18668, 18692, 18704, 18737, 18754, 18775, 19046, 19149, 19155, 19288, 19481, 19484, 19713, 19827, 19860, 19917 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(630, result.number);
            Assert.AreEqual(2114798, result.newNumber);
        }


        [TestMethod]
        public void TestMethod184()
        {
            int[] numbers = new int[] { 835, 1225, 1546, 1603, 1933, 2076, 2137, 2489, 2681, 2704, 2705, 3009, 3521, 3682, 3791, 4116, 4154, 4157, 4447, 4748, 4831, 5094, 5122, 5747, 5813, 6038, 6321, 6495, 6673, 6813, 6978, 7006, 7339, 7397, 7778, 7856, 7965, 8230, 8242, 8480, 8514, 8645, 8661, 8718, 8886, 9681, 9751, 9903, 10018, 10084, 10088, 10405, 10424, 10454, 10725, 11259, 11283, 11411, 12008, 12760, 12882, 12895, 13053, 13399, 13400, 13574, 14529, 14796, 14851, 14904, 15206, 15222, 15363, 15475, 15519, 15613, 15808, 15949, 16008, 16382, 16476, 16558, 16838, 17095, 17653, 17783, 18146, 18229, 18490, 18679, 19125, 19256, 19917, 19987 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(835, result.number);
            Assert.AreEqual(934781, result.newNumber);
        }


        [TestMethod]
        public void TestMethod185()
        {
            int[] numbers = new int[] { 2414, 2947, 3582, 3676, 5794, 5927, 5941, 5989, 6391, 6562, 11198, 11778, 14457, 15605, 15995, 17013, 17660, 18295, 19587 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(2947, result.number);
            Assert.AreEqual(140173, result.newNumber);
        }


        [TestMethod]
        public void TestMethod186()
        {
            int[] numbers = new int[] { 1166, 1502, 1622, 2409, 6067, 6083, 7819, 8162, 8464, 8938, 9631, 10134, 10595, 10866, 11665, 11989, 12592, 13439, 13818, 14161, 15040, 16446, 17277, 17316, 18174, 18722 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1622, result.number);
            Assert.AreEqual(232983, result.newNumber);
        }


        [TestMethod]
        public void TestMethod187()
        {
            int[] numbers = new int[] { 194, 194, 229, 265, 328, 382, 462, 548, 566, 567, 661, 709, 800, 800, 894, 910, 948, 975, 1009, 1149, 1372, 1666, 1670, 1945, 2045, 2152, 2173, 2340, 2354, 2496, 2564, 2840, 2900, 2946, 2960, 3206, 3666, 4045, 4119, 4221, 4366, 4465, 4492, 4565, 4711, 4993, 5024, 5026, 5121, 5162, 5253, 5327, 5374, 5379, 5423, 5508, 5511, 5695, 6022, 6035, 6053, 6259, 6286, 6302, 6354, 6398, 6521, 6631, 6658, 6704, 6875, 6947, 6977, 7221, 7239, 7276, 7325, 7350, 7360, 7367, 7469, 7893, 7909, 8013, 8176, 8333, 8527, 8596, 8694, 8748, 8750, 8789, 8820, 8974, 8991, 9023, 9074, 9289, 9394, 9562, 9686, 9700, 9756, 9822, 10089, 10392, 10411, 10457, 10656, 10763, 11109, 11119, 11206, 11322, 11441, 11482, 11591, 11672, 11731, 11792, 11858, 11860, 11872, 12074, 12077, 12122, 12214, 12216, 12219, 12401, 12590, 12729, 12819, 12835, 12869, 12874, 12905, 12944, 13185, 13295, 13316, 13354, 13385, 13422, 13588, 13836, 13990, 14054, 14363, 14387, 14453, 14502, 14871, 15072, 15123, 15148, 15230, 15531, 15570, 15638, 15659, 15726, 15903, 15947, 16101, 16244, 16330, 16408, 16464, 16541, 16673, 16712, 16791, 17104, 17237, 17370, 17412, 17499, 17552, 17607, 17704, 17765, 17780, 17873, 17900, 17923, 17976, 18085, 18138, 18209, 18256, 18305, 18519, 18564, 18613, 18781, 18862, 18970, 19159, 19245, 19261, 19337, 19380, 19388, 19414, 19433, 19457, 19985 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(194, result.number);
            Assert.AreEqual(2087388, result.newNumber);
        }


        [TestMethod]
        public void TestMethod188()
        {
            int[] numbers = new int[] { 22, 77, 196, 346, 625, 636, 682, 794, 802, 864, 1018, 1331, 1345, 1434, 1548, 1652, 1682, 1705, 1842, 1970, 2006, 2097, 2247, 2323, 2444, 2447, 2476, 2907, 2964, 2982, 3454, 3645, 3774, 3783, 4113, 4125, 4318, 4352, 4481, 4721, 4934, 4997, 5066, 5401, 5817, 5915, 6067, 6159, 6179, 6626, 6656, 6751, 6936, 6998, 7160, 7354, 7398, 7455, 7629, 7655, 7715, 8032, 8090, 8340, 8355, 8507, 8833, 8863, 9052, 9171, 9239, 9275, 9298, 9455, 9632, 9852, 9964, 9980, 10219, 10278, 10409, 10623, 10654, 10690, 10804, 10973, 11027, 11223, 11394, 11417, 11481, 11502, 11727, 11757, 11862, 11869, 12377, 12624, 12641, 12663, 12753, 12758, 13036, 13126, 13235, 13269, 13379, 13404, 13450, 13507, 13516, 13711, 13827, 13901, 13907, 13982, 14177, 14289, 14315, 14399, 14439, 14628, 14635, 14678, 14682, 14841, 14911, 15039, 15083, 15112, 15369, 15459, 15565, 15601, 15716, 15737, 15918, 15960, 15988, 15993, 16050, 16528, 16584, 16804, 17221, 17410, 17419, 17570, 17574, 17802, 17888, 17991, 18082, 18180, 18250, 18338, 18411, 18499, 18596, 18621, 18795, 18860, 18931, 19007, 19191, 19218, 19302, 19643, 19723, 19735, 19749, 19813, 19909 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(22, result.number);
            Assert.AreEqual(1807436, result.newNumber);
        }


        [TestMethod]
        public void TestMethod189()
        {
            int[] numbers = new int[] { 29, 132, 331, 335, 394, 398, 437, 638, 730, 819, 900, 925, 1026, 1052, 1091, 1157, 1258, 1562, 1573, 1769, 1777, 1803, 1960, 2180, 2235, 2241, 2290, 2409, 2473, 2579, 2622, 2650, 2852, 2862, 2965, 2972, 3034, 3196, 3231, 3346, 3383, 3499, 3515, 3548, 3690, 3700, 3769, 3830, 3859, 3862, 3899, 3904, 3954, 3972, 3983, 4014, 4031, 4050, 4141, 4160, 4169, 4191, 4268, 4288, 4305, 4398, 4420, 4466, 4602, 4657, 4678, 4733, 4769, 4778, 4925, 4926, 5000, 5171, 5212, 5214, 5346, 5424, 5659, 5661, 5683, 5690, 5703, 5742, 5743, 5749, 5756, 5852, 5943, 6039, 6064, 6150, 6154, 6172, 6228, 6348, 6464, 6503, 6587, 6702, 6727, 6745, 6822, 6847, 6952, 7185, 7207, 7215, 7254, 7363, 7422, 7553, 7571, 7580, 7601, 7680, 7690, 7732, 7739, 7753, 7861, 7873, 8001, 8040, 8450, 8465, 8487, 8662, 8684, 8686, 8693, 8806, 8911, 8913, 8926, 8940, 9213, 9283, 9547, 9609, 9619, 9636, 9666, 9681, 9710, 9759, 9816, 9881, 9882, 10017, 10082, 10097, 10250, 10292, 10467, 10621, 10687, 10797, 10928, 10929, 11005, 11009, 11034, 11160, 11165, 11401, 11616, 11748, 11786, 11800, 11832, 11851, 11865, 11933, 12013, 12199, 12206, 12252, 12265, 12291, 12311, 12649, 12677, 12992, 13041, 13082, 13084, 13145, 13280, 13303, 13319, 13435, 13630, 13841, 13874, 13941, 14360, 14460, 14580, 14595, 14606, 14615, 14680, 14721, 14776, 14791, 14847, 14863, 14868, 14888, 14929, 14953, 15018, 15056, 15067, 15206, 15309, 15379, 15392, 15450, 15464, 15566, 15642, 15670, 15704, 15779, 15953, 16022, 16029, 16085, 16106, 16140, 16175, 16229, 16303, 16451, 16462, 16557, 16633, 16682, 16820, 16895, 17022, 17324, 17413, 17489, 17579, 17789, 17971, 18039, 18050, 18153, 18169, 18219, 18240, 18258, 18259, 18292, 18374, 18422, 18429, 18573, 18636, 18641, 18661, 18719, 18756, 18920, 19116, 19206, 19254, 19256, 19339, 19362, 19367, 19396, 19528, 19585, 19633, 19722, 19756, 19770, 19814, 19862, 19884, 19910, 19915 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(132, result.number);
            Assert.AreEqual(2905681, result.newNumber);
        }


        [TestMethod]
        public void TestMethod190()
        {
            int[] numbers = new int[] { 14, 340, 419, 479, 698, 892, 893, 1105, 1185, 1301, 1323, 1413, 1482, 1583, 1583, 1593, 1612, 1810, 1873, 1913, 1992, 2058, 2094, 2244, 2361, 2435, 2470, 2502, 2571, 2712, 2752, 2772, 2809, 2846, 3098, 3252, 3511, 3622, 3743, 3876, 3940, 4024, 4030, 4115, 4209, 4295, 4665, 4902, 5331, 5400, 5524, 5565, 5569, 5674, 5936, 6250, 6395, 6457, 6494, 6573, 6636, 6780, 6883, 7087, 7136, 7375, 7387, 7761, 7762, 7827, 7930, 8193, 8317, 8588, 8655, 8702, 9053, 9075, 9084, 9150, 9211, 9513, 9561, 9647, 9690, 9818, 9881, 10085, 10255, 10370, 10383, 10542, 10592, 10636, 10730, 10884, 11083, 11371, 11444, 11481, 11572, 11586, 11850, 11935, 11961, 12457, 12694, 12908, 12996, 13051, 13542, 13882, 14361, 14675, 14702, 14824, 14930, 14987, 15111, 15154, 15203, 15694, 15962, 16138, 16388, 16867, 17030, 17033, 17285, 17794, 17882, 17938, 18299, 18311, 18320, 18368, 18392, 18421, 18455, 18616, 18840, 18931, 19116, 19130, 19149, 19307, 19712, 19809, 19951 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(14, result.number);
            Assert.AreEqual(1338803, result.newNumber);
        }


        [TestMethod]
        public void TestMethod191()
        {
            int[] numbers = new int[] { 167, 221, 227, 271, 272, 313, 464, 473, 547, 585, 715, 784, 821, 994, 1005, 1008, 1010, 1042, 1233, 1306, 1313, 1471, 1483, 1527, 1554, 1648, 1822, 1834, 1843, 2003, 2008, 2056, 2284, 2637, 2655, 2979, 3049, 3174, 3237, 3557, 3740, 4126, 4163, 4183, 4336, 4506, 4542, 4592, 4658, 4685, 4787, 4814, 5047, 5223, 5272, 5275, 5432, 5583, 5665, 5891, 5904, 5996, 6185, 6257, 6337, 6359, 6517, 6625, 6652, 6869, 6932, 6941, 6994, 7112, 7377, 7432, 7771, 7812, 8219, 8225, 8434, 8977, 8985, 9064, 9124, 9314, 9471, 9506, 9540, 9564, 9567, 9686, 9742, 9834, 9840, 9858, 9884, 9888, 9898, 9958, 9965, 9981, 10157, 10414, 10980, 11167, 11328, 11398, 11532, 11647, 11886, 11898, 11929, 12216, 12245, 12327, 12400, 12403, 12542, 12583, 12585, 12716, 12897, 13117, 13458, 13481, 13854, 14105, 14186, 14278, 14303, 14594, 14608, 14644, 14701, 14737, 14760, 14869, 14952, 14973, 15011, 15293, 15474, 15535, 15979, 16007, 16098, 16570, 16681, 16790, 16796, 17141, 17342, 17408, 17564, 17671, 17725, 18035, 18135, 18260, 18290, 18392, 18426, 18689, 18829, 19166, 19263, 19331, 19402, 19616, 19683, 19690, 19708, 19723, 19828, 19835, 19909 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(272, result.number);
            Assert.AreEqual(1657085, result.newNumber);
        }


        [TestMethod]
        public void TestMethod192()
        {
            int[] numbers = new int[] { 189, 225, 323, 378, 708, 724, 940, 1015, 1331, 1421, 1440, 1505, 1588, 1674, 1749, 1817, 1937, 2009, 2413, 2481, 2498, 2501, 2512, 2520, 2552, 2684, 2687, 2725, 2772, 2811, 3187, 3197, 3588, 3655, 3790, 3968, 4120, 4133, 4553, 4614, 4707, 4745, 4866, 4896, 5001, 5226, 5279, 5323, 5462, 5624, 5744, 5760, 5779, 5815, 5892, 6008, 6061, 6089, 6301, 6334, 6344, 6539, 6546, 6737, 6754, 6785, 6821, 6872, 6967, 7016, 7101, 7332, 7366, 7561, 7680, 7760, 7772, 7834, 7951, 8075, 8087, 8103, 8120, 8194, 8301, 8424, 8497, 8558, 9062, 9066, 9107, 9166, 9262, 9268, 9305, 9377, 9626, 9692, 9727, 9774, 9924, 10050, 10128, 10164, 10237, 10399, 10588, 10600, 10898, 10921, 11139, 11214, 11356, 11358, 11419, 11730, 11924, 12034, 12040, 12108, 12130, 12554, 12563, 12628, 12777, 12935, 13059, 13155, 13337, 13402, 13403, 13489, 13635, 13692, 13922, 14170, 14186, 14303, 14471, 14616, 15018, 15064, 15091, 15091, 15326, 15342, 15399, 15455, 15466, 15484, 15563, 15815, 15907, 15918, 16033, 16123, 16249, 16267, 16373, 16383, 16415, 16626, 16755, 16905, 16963, 17068, 17246, 17380, 17447, 17499, 17511, 17666, 17823, 17823, 18018, 18055, 18176, 18518, 18680, 18818, 18887, 18930, 18967, 19021, 19150, 19229, 19290, 19331, 19371, 19434, 19481, 19530, 19541, 19570, 19577, 19598, 19771, 19870, 19942, 19959 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(189, result.number);
            Assert.AreEqual(2062462, result.newNumber);
        }


        [TestMethod]
        public void TestMethod193()
        {
            int[] numbers = new int[] { 1920, 2942, 3157, 3994, 4078, 4855, 5268, 6848, 7184, 8803, 8875, 9673, 11460, 13398, 13997, 14182, 14228, 14440, 15563, 16069, 16574, 17547, 17644, 17773, 17911, 17930, 18428, 19200, 19335, 19406, 19516 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(2942, result.number);
            Assert.AreEqual(341566, result.newNumber);
        }


        [TestMethod]
        public void TestMethod194()
        {
            int[] numbers = new int[] { 533, 558, 739, 1346, 1759, 1879, 1950, 2023, 2059, 2550, 2950, 2989, 3568, 4376, 4658, 4877, 4983, 5108, 5161, 5242, 5304, 5441, 7077, 7305, 7350, 7379, 7530, 7892, 8064, 8074, 8291, 8672, 9005, 9064, 10322, 10339, 10857, 11004, 11188, 12169, 12330, 12907, 12912, 13227, 13351, 13502, 13941, 14151, 14680, 15151, 15298, 15594, 16152, 16160, 16181, 16392, 16508, 16857, 17167, 17250, 17605, 18001, 18280, 18485, 18803, 18909, 18969, 19324, 19673, 19843 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(533, result.number);
            Assert.AreEqual(708207, result.newNumber);
        }


        [TestMethod]
        public void TestMethod195()
        {
            int[] numbers = new int[] { 271, 279, 738, 778, 924, 925, 1143, 1202, 1437, 1775, 2051, 2189, 2248, 2311, 2407, 2639, 2814, 2973, 3043, 3148, 3448, 3614, 3844, 3954, 4197, 4264, 4316, 4407, 4439, 4545, 4595, 4719, 4793, 4908, 5050, 5121, 5307, 5576, 5587, 5620, 5748, 5832, 5855, 6025, 6206, 6526, 7182, 7453, 7555, 7627, 8382, 8515, 8840, 8908, 8911, 8982, 8986, 9070, 9196, 9541, 9841, 10091, 10158, 10278, 10282, 10352, 10397, 10530, 10546, 10820, 10953, 11809, 11810, 11882, 12053, 12075, 12176, 12209, 12327, 12469, 12644, 12776, 12976, 13055, 13251, 13431, 13559, 13919, 14029, 14496, 14633, 14809, 15170, 15456, 15613, 15817, 15890, 15927, 15960, 16030, 16093, 16122, 16151, 16366, 16391, 16665, 16717, 16764, 17014, 17056, 17488, 17623, 17825, 17950, 17983, 18200, 18230, 18513, 18633, 18677, 18760, 18767, 19091, 19267, 19529, 19601, 19865, 19926, 19929 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(271, result.number);
            Assert.AreEqual(1310714, result.newNumber);
        }


        [TestMethod]
        public void TestMethod196()
        {
            int[] numbers = new int[] { 108, 463, 469, 483, 639, 1034, 1038, 1160, 1187, 1192, 1257, 1283, 1344, 1460, 1545, 1717, 1759, 1777, 2008, 2119, 2322, 2389, 2424, 2596, 2604, 2655, 2757, 2767, 3151, 3193, 3268, 3285, 3448, 3475, 3536, 3603, 3699, 3770, 4201, 4238, 4508, 4701, 4712, 4761, 4783, 4836, 4970, 5325, 5402, 5426, 5463, 5545, 5818, 5834, 5888, 5934, 5941, 6003, 6053, 6110, 6278, 6381, 6387, 6555, 6633, 6840, 6906, 7058, 7099, 7207, 7308, 7357, 7467, 7504, 7608, 7653, 7879, 8137, 8341, 8346, 8400, 8419, 8562, 8579, 8628, 8724, 8797, 8825, 8862, 8886, 9023, 9162, 9170, 9326, 9435, 9443, 9536, 9540, 9729, 9868, 9918, 9933, 10259, 10290, 10446, 10606, 10722, 10731, 11003, 11274, 11584, 11926, 12098, 12210, 12268, 12307, 12433, 12458, 12465, 12618, 12739, 12859, 12933, 13252, 13337, 13598, 13660, 13666, 13733, 13767, 13989, 14014, 14538, 14560, 14614, 14789, 14860, 14894, 15029, 15116, 15172, 15247, 15456, 15474, 15617, 15702, 15863, 15935, 15937, 15985, 16021, 16023, 16132, 16186, 16214, 16297, 16336, 16378, 16628, 16652, 16787, 16787, 16812, 16884, 16934, 16949, 17051, 17066, 17472, 17641, 17909, 18093, 18111, 18141, 18151, 18343, 18477, 18556, 18994, 19006, 19015, 19149, 19477, 19483, 19577, 19701, 19754, 19778, 19843, 19876 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(108, result.number);
            Assert.AreEqual(1893826, result.newNumber);
        }


        [TestMethod]
        public void TestMethod197()
        {
            int[] numbers = new int[] { 68, 209, 220, 234, 293, 367, 402, 499, 505, 758, 804, 1037, 1105, 1105, 1232, 1234, 1308, 1528, 1613, 1936, 2041, 2114, 2133, 2884, 3203, 3411, 3433, 3444, 3550, 3802, 3839, 3852, 3871, 4109, 4278, 4279, 4335, 4376, 4533, 4608, 4634, 4777, 4784, 4924, 5075, 5096, 5252, 5270, 5336, 5532, 5697, 5791, 5862, 5902, 5985, 5989, 6012, 6063, 6140, 6363, 6386, 6464, 6660, 6701, 6896, 7024, 7033, 7044, 7073, 7094, 7167, 7277, 7292, 7528, 7576, 7627, 7809, 7840, 7994, 8131, 8168, 8313, 8348, 8349, 8608, 8747, 8750, 8774, 8795, 8817, 8846, 8950, 8992, 9072, 9089, 9214, 9264, 9313, 9441, 9557, 9634, 9658, 9779, 10137, 10329, 10736, 10908, 11085, 11138, 11170, 11321, 11349, 11378, 11413, 11424, 11490, 11570, 11658, 11772, 11834, 11863, 12054, 12119, 12177, 12254, 12271, 12274, 12311, 12396, 12592, 12621, 12744, 12918, 12928, 13224, 13230, 13353, 13426, 13450, 13590, 13618, 13802, 13812, 14164, 14169, 14179, 14184, 14243, 14394, 14586, 14663, 14742, 14879, 15095, 15219, 15288, 15296, 15520, 15671, 15775, 15824, 15867, 15946, 16113, 16469, 16533, 16646, 16902, 16923, 17030, 17115, 17245, 17249, 17384, 17474, 17525, 17529, 17612, 17687, 17723, 17840, 17934, 17968, 18038, 18178, 18180, 18193, 18277, 18560, 18595, 18741, 19070, 19073, 19089, 19236, 19313, 19509, 19651, 19753, 19762, 19772, 19926 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(68, result.number);
            Assert.AreEqual(2039251, result.newNumber);
        }


        [TestMethod]
        public void TestMethod198()
        {
            int[] numbers = new int[] { 274, 366, 818, 860, 1207, 1311, 1363, 1364, 1367, 1562, 1609, 1676, 1735, 1921, 2023, 2067, 2175, 2594, 2782, 2788, 2909, 3150, 3160, 3271, 3631, 3977, 3984, 4267, 4414, 4442, 4550, 4592, 4960, 5027, 5038, 5335, 5437, 5764, 5864, 5938, 5944, 6327, 6545, 6603, 6808, 6826, 6881, 7504, 7865, 7969, 8051, 8415, 8468, 8576, 8619, 8858, 8904, 8966, 8982, 9244, 9288, 9420, 9531, 10086, 10210, 10315, 10432, 10619, 10920, 11389, 11462, 11662, 11697, 11812, 11876, 11889, 12174, 12241, 12276, 12571, 12751, 13389, 13442, 13453, 13511, 13870, 13983, 14401, 14791, 14994, 15317, 15391, 15514, 15584, 15791, 15850, 15865, 16124, 16171, 16471, 16718, 16894, 17013, 17470, 17511, 17732, 18178, 18356, 18377, 18742, 18769, 18856, 19032, 19038, 19758, 19899, 19926 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(860, result.number);
            Assert.AreEqual(1103027, result.newNumber);
        }


        [TestMethod]
        public void TestMethod199()
        {
            int[] numbers = new int[] { 796, 1374, 1971, 2281, 2464, 2469, 2613, 2813, 3313, 3431, 3647, 3655, 3759, 4067, 4230, 4314, 4624, 5226, 5232, 5419, 6459, 6576, 6919, 6936, 7294, 7361, 7756, 7833, 7850, 8186, 8305, 8428, 8879, 8898, 9444, 9453, 9472, 9523, 10187, 10249, 10341, 10913, 10914, 11565, 11624, 11642, 11743, 11770, 12363, 12510, 12512, 12588, 12881, 12942, 13059, 13421, 13510, 14263, 14497, 14533, 14697, 14728, 14794, 14837, 14955, 15362, 16139, 16621, 16726, 16727, 16804, 17193, 17306, 17490, 17702, 17780, 18002, 18550, 18609, 18800, 19053, 19166, 19753, 19991 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1374, result.number);
            Assert.AreEqual(879060, result.newNumber);
        }


        [TestMethod]
        public void TestMethod200()
        {
            int[] numbers = new int[] { 493, 1274, 1578, 1779, 2028, 3025, 3672, 3741, 4264, 4409, 4670, 5130, 5728, 7361, 7438, 8111, 9230, 9725, 10412, 10568, 10874, 10917, 11673, 12570, 12770, 12863, 13524, 13582, 14066, 14791, 16018, 16848, 17147, 18221, 18716, 18979, 19002 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(493, result.number);
            Assert.AreEqual(336199, result.newNumber);
        }


        [TestMethod]
        public void TestMethod201()
        {
            int[] numbers = new int[] { 53, 58, 89, 102, 131, 191, 421, 679, 690, 717, 757, 783, 858, 916, 1137, 1280, 1390, 1406, 1480, 1573, 1638, 1772, 1798, 1928, 2034, 2100, 2206, 2231, 2295, 2374, 2382, 2485, 2616, 2711, 2718, 2807, 2852, 2898, 2953, 3027, 3183, 3189, 3213, 3606, 3651, 3668, 3690, 3755, 3957, 4239, 4266, 4285, 4473, 4534, 4751, 4991, 4997, 5179, 5212, 5223, 5249, 5266, 5409, 5451, 5467, 5493, 5638, 5647, 5892, 5970, 6312, 6346, 6572, 6612, 6628, 6779, 6908, 6909, 7003, 7024, 7079, 7224, 7386, 7542, 7629, 7692, 7726, 7738, 7825, 7860, 7963, 8483, 8505, 8516, 8618, 8626, 8645, 8662, 8730, 8751, 8794, 8928, 9018, 9470, 9477, 9723, 9785, 9860, 9890, 9945, 10025, 10187, 10302, 10391, 10486, 10611, 10624, 10688, 10727, 10809, 10861, 10891, 10905, 11062, 11192, 11241, 11469, 11510, 11594, 11716, 11870, 11957, 11990, 12014, 12116, 12140, 12306, 12420, 12764, 12949, 13026, 13055, 13150, 13263, 13303, 13328, 13365, 13574, 13848, 13964, 13987, 14191, 14453, 14497, 14522, 14522, 14666, 14728, 15006, 15181, 15289, 15291, 15362, 15393, 15420, 15518, 15619, 15764, 15947, 16017, 16110, 16176, 16202, 16364, 16384, 16478, 16524, 16577, 16646, 16723, 16773, 16789, 16875, 16918, 16981, 17155, 17176, 17347, 17349, 17364, 17572, 17681, 17926, 18019, 18042, 18082, 18146, 18586, 18616, 18838, 18985, 19041, 19800, 19890, 19930, 19937, 19953, 19978 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(89, result.number);
            Assert.AreEqual(1972998, result.newNumber);
        }


        [TestMethod]
        public void TestMethod202()
        {
            int[] numbers = new int[] { 115, 464, 658, 955, 1204, 1309, 1463, 1568, 1669, 1718, 1752, 2122, 2172, 2218, 2268, 2527, 2557, 2587, 2694, 2727, 2773, 2781, 3101, 3114, 3191, 3600, 3770, 3880, 3894, 4079, 4281, 4445, 4561, 4616, 4664, 4676, 4809, 4953, 4982, 5009, 5025, 5049, 5053, 5087, 5140, 5273, 5412, 5884, 5945, 6056, 6193, 6259, 6395, 6497, 6949, 7131, 7135, 7186, 7505, 7649, 7821, 8035, 8273, 8455, 8550, 8646, 8657, 8822, 8846, 8887, 9008, 9134, 9282, 9722, 9733, 9858, 9963, 10218, 10257, 10395, 10408, 10423, 10480, 10500, 10566, 10638, 10868, 11037, 11605, 11613, 11681, 11770, 11873, 12067, 12223, 12338, 12386, 12405, 12436, 12487, 12849, 12879, 13283, 13321, 13488, 13527, 13632, 14106, 14115, 14187, 14191, 14306, 14333, 15013, 15061, 15078, 15226, 15311, 15406, 15630, 15700, 15739, 15777, 15977, 15992, 16016, 16066, 16265, 16322, 16363, 16371, 16450, 16566, 16638, 16774, 16778, 16868, 16886, 16892, 16920, 16921, 17032, 17246, 17544, 17544, 18292, 18378, 18413, 18613, 19203, 19227, 19286, 19381, 19579, 19582, 19746, 19761 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(464, result.number);
            Assert.AreEqual(1572761, result.newNumber);
        }


        [TestMethod]
        public void TestMethod203()
        {
            int[] numbers = new int[] { 78, 110, 1238, 1317, 1454, 1633, 2078, 2094, 3114, 3181, 3950, 4325, 5453, 5923, 5939, 6944, 7367, 7414, 7514, 7827, 8253, 9025, 9079, 9331, 10199, 10265, 10952, 11119, 11690, 11780, 12221, 12438, 12724, 13400, 13622, 13650, 13806, 14828, 14948, 14951, 14983, 15585, 15993, 17262, 17533, 18077, 18515, 18614, 18637, 19504, 19846, 19903 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(110, result.number);
            Assert.AreEqual(518399, result.newNumber);
        }


        [TestMethod]
        public void TestMethod204()
        {
            int[] numbers = new int[] { 5, 21, 110, 162, 502, 813, 816, 894, 1021, 1124, 1396, 1416, 1518, 1664, 2185, 2314, 2412, 2700, 2708, 2723, 2792, 2928, 2995, 3066, 3107, 3252, 3287, 3294, 3838, 4060, 4104, 4171, 4195, 4208, 4317, 4342, 4360, 4971, 5091, 5294, 5337, 5338, 5485, 5501, 5827, 5911, 5988, 6713, 6841, 6894, 6915, 7169, 7251, 7271, 7327, 7343, 7348, 7594, 7761, 7788, 7862, 7979, 8008, 8219, 8331, 8380, 8615, 8899, 9073, 9163, 9258, 9658, 9853, 10262, 10361, 10588, 10890, 10964, 11305, 11336, 11401, 11445, 11496, 11582, 11713, 11895, 12057, 12105, 12173, 12197, 12462, 12637, 12663, 12675, 12810, 12999, 13002, 13301, 13434, 13526, 13598, 13672, 13902, 14198, 14510, 14846, 14849, 14965, 15410, 15579, 15968, 16089, 16089, 16370, 16663, 16812, 17109, 17453, 17990, 18135, 18405, 18502, 18652, 18746, 19025, 19348, 19514, 19688, 19818, 19837, 19984 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(502, result.number);
            Assert.AreEqual(1196956, result.newNumber);
        }


        [TestMethod]
        public void TestMethod205()
        {
            int[] numbers = new int[] { 161, 637, 3822, 4519, 5308, 5773, 6220, 7678, 10246, 11162, 11245, 11535, 11974, 12039, 13037, 13106, 13182, 13595, 14061, 14084, 15163, 16753, 17320, 18412, 19079, 19187, 19459 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(161, result.number);
            Assert.AreEqual(266210, result.newNumber);
        }


        [TestMethod]
        public void TestMethod206()
        {
            int[] numbers = new int[] { 22, 268, 334, 366, 518, 557, 560, 581, 603, 645, 757, 839, 1023, 1028, 1132, 1622, 1658, 1736, 1901, 1994, 2025, 2044, 2119, 2136, 2141, 2286, 2433, 2440, 2490, 2559, 2666, 2716, 2724, 2744, 2969, 2985, 2991, 3236, 3279, 3353, 3390, 3455, 3549, 3564, 3627, 3674, 3706, 3755, 3789, 3859, 3910, 4054, 4075, 4125, 4176, 4220, 4250, 4255, 4260, 4318, 4337, 4388, 4612, 4630, 4856, 4874, 4878, 4917, 4995, 5087, 5124, 5129, 5176, 5224, 5281, 5428, 5485, 5490, 5515, 5534, 5650, 5704, 5854, 5860, 5914, 5939, 6239, 6356, 6430, 6521, 6526, 6566, 6572, 6651, 6666, 6775, 6842, 6854, 6913, 7063, 7126, 7200, 7228, 7305, 7353, 7512, 7608, 7616, 7689, 7758, 7773, 7833, 7907, 7922, 7947, 7964, 7983, 8189, 8198, 8300, 8412, 8479, 8564, 8691, 8725, 8788, 8792, 8802, 8904, 8913, 9085, 9199, 9329, 9347, 9507, 9553, 9609, 9640, 9645, 9850, 9858, 9971, 9993, 10103, 10215, 10288, 10398, 10627, 10715, 10786, 10854, 10998, 11160, 11170, 11234, 11234, 11301, 11395, 11546, 11558, 11787, 11801, 11968, 12088, 12223, 12297, 12354, 12461, 12558, 12728, 12730, 12849, 13021, 13045, 13079, 13143, 13218, 13261, 13266, 13287, 13331, 13340, 13480, 13695, 13785, 14214, 14492, 14554, 14582, 14583, 14769, 14917, 15037, 15230, 15270, 15363, 15416, 15447, 15459, 15590, 15755, 16010, 16312, 16490, 16516, 16559, 16579, 16626, 16761, 16823, 16856, 17010, 17057, 17133, 17203, 17384, 17504, 17516, 17549, 17655, 17720, 17729, 17766, 17814, 17845, 18001, 18001, 18111, 18261, 18311, 18431, 18583, 18714, 18744, 18751, 18898, 18933, 18949, 19106, 19333, 19530, 19619, 19718, 19746 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(22, result.number);
            Assert.AreEqual(2256146, result.newNumber);
        }


        [TestMethod]
        public void TestMethod207()
        {
            int[] numbers = new int[] { 164, 217, 325, 492, 843, 926, 1108, 1294, 1941, 1960, 2279, 2714, 2821, 3199, 3203, 3456, 3640, 3746, 3884, 4117, 4478, 4482, 4673, 4810, 5032, 5032, 5078, 5136, 5600, 5967, 5972, 6297, 6496, 7107, 7294, 7351, 7685, 7890, 8276, 8488, 8578, 8694, 8735, 8871, 9257, 9421, 9513, 9638, 9963, 10142, 10413, 10534, 10575, 10736, 11017, 11533, 11564, 11803, 12026, 12148, 12358, 12587, 12732, 12883, 12957, 13056, 13094, 13266, 13270, 13402, 13764, 13921, 14350, 14460, 14544, 14584, 15612, 15640, 15819, 16205, 16216, 16311, 16401, 17289, 17307, 17520, 17548, 17642, 17843, 18116, 18128, 18738, 18817, 18822, 18834, 18878, 19063, 19238, 19306, 19474, 19674, 19676, 19691, 19795, 19942 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(325, result.number);
            Assert.AreEqual(1103296, result.newNumber);
        }


        [TestMethod]
        public void TestMethod208()
        {
            int[] numbers = new int[] { 12, 44, 250, 293, 330, 457, 473, 576, 577, 761, 766, 878, 941, 985, 1039, 1222, 1257, 1275, 1365, 1408, 1487, 1496, 1529, 1542, 1581, 1956, 1994, 1994, 1997, 2158, 2513, 2517, 2991, 3117, 3138, 3139, 3274, 3408, 3484, 3526, 3667, 3711, 3781, 3792, 3814, 3842, 3930, 3989, 3990, 4047, 4139, 4226, 4275, 4405, 4784, 4803, 4821, 4869, 4911, 4936, 4984, 4987, 5170, 5275, 5342, 5376, 5380, 5399, 5478, 5661, 5662, 5707, 5983, 6025, 6103, 6238, 6243, 6351, 6354, 6537, 6637, 6648, 6689, 6701, 6814, 6834, 6897, 7069, 7101, 7184, 7211, 7235, 7306, 7338, 7363, 7389, 7541, 7576, 7637, 7656, 7713, 7745, 7756, 7808, 7966, 8137, 8348, 8360, 8516, 8546, 8630, 8670, 8770, 8805, 8983, 9122, 9127, 9132, 9226, 9262, 9291, 9539, 9628, 9732, 9761, 9834, 10019, 10117, 10147, 10160, 10269, 10271, 10377, 10388, 10415, 10469, 10714, 10767, 10770, 10821, 10845, 10933, 10943, 10959, 11123, 11151, 11163, 11322, 11347, 11470, 11617, 11894, 11908, 11928, 12153, 12274, 12298, 12350, 12410, 12577, 12619, 12662, 12713, 12735, 12783, 12866, 13151, 13216, 13277, 13277, 13791, 13867, 14064, 14107, 14252, 14276, 14319, 14350, 14416, 14547, 14554, 14633, 14734, 14750, 14816, 14894, 14903, 14914, 14939, 14946, 15025, 15071, 15238, 15329, 15346, 15638, 15723, 15790, 15815, 15965, 16023, 16051, 16121, 16136, 16166, 16187, 16268, 16402, 16521, 16594, 16712, 16743, 16755, 16783, 16981, 17282, 17423, 17490, 17577, 17612, 17666, 17699, 17721, 17739, 17808, 17810, 17948, 18018, 18031, 18031, 18103, 18155, 18308, 18360, 18366, 18430, 18445, 18487, 18530, 18627, 18695, 18712, 18820, 18841, 18861, 18974, 19142, 19199, 19292, 19322, 19334, 19396, 19444, 19529, 19612, 19632, 19664, 19824, 19901 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(293, result.number);
            Assert.AreEqual(2647155, result.newNumber);
        }


        [TestMethod]
        public void TestMethod209()
        {
            int[] numbers = new int[] { 23, 37, 79, 95, 99, 212, 249, 467, 488, 645, 853, 911, 1043, 1124, 1282, 1419, 1419, 1450, 1573, 1774, 1796, 1830, 1853, 1897, 2083, 2105, 2283, 2361, 2368, 2386, 2426, 2520, 2551, 2648, 2670, 2685, 2756, 2937, 2946, 2968, 3201, 3214, 3226, 3349, 3413, 3419, 3446, 3535, 3560, 3859, 3897, 3942, 4135, 4232, 4258, 4592, 4597, 4695, 4712, 5336, 5364, 5731, 5737, 5742, 5769, 5786, 5861, 5871, 6055, 6144, 6362, 6374, 6566, 6676, 6742, 6786, 6877, 6975, 7019, 7022, 7030, 7137, 7150, 7258, 7281, 7382, 7665, 7738, 7877, 7942, 7965, 8000, 8004, 8005, 8038, 8131, 8137, 8185, 8200, 8272, 8304, 8316, 8392, 8456, 8579, 8588, 8603, 8610, 8671, 8683, 8737, 8765, 8770, 8792, 8883, 8899, 8961, 8967, 9061, 9095, 9111, 9235, 9281, 9452, 9591, 9711, 9727, 9728, 9763, 9792, 9816, 9858, 9865, 10052, 10127, 10150, 10451, 10463, 10572, 10602, 10627, 10631, 10643, 10698, 10708, 10820, 10955, 11056, 11153, 11154, 11205, 11241, 11244, 11307, 11445, 11499, 11564, 11569, 11586, 11587, 11614, 11648, 11812, 11846, 11851, 12075, 12232, 12247, 12250, 12393, 12463, 12469, 12476, 12504, 12599, 12694, 12717, 12815, 12894, 12915, 12929, 12931, 12981, 13048, 13229, 13299, 13521, 13536, 13625, 13656, 13664, 13992, 14149, 14157, 14186, 14234, 14341, 14350, 14573, 14643, 14703, 14778, 14790, 15183, 15198, 15258, 15481, 15487, 15528, 15599, 15618, 15895, 15954, 16050, 16200, 16274, 16278, 16309, 16614, 16685, 16685, 16844, 16921, 16987, 17048, 17082, 17086, 17199, 17432, 17470, 17552, 17719, 17720, 17736, 17927, 18077, 18127, 18175, 18211, 18238, 18287, 18290, 18498, 18569, 18639, 18742, 18771, 18790, 18806, 18865, 18882, 18996, 19069, 19155, 19205, 19281, 19367, 19369, 19390, 19490, 19575, 19599, 19626, 19700, 19764, 19774, 19828, 19876, 19926 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(37, result.number);
            Assert.AreEqual(2757625, result.newNumber);
        }


        [TestMethod]
        public void TestMethod210()
        {
            int[] numbers = new int[] { 104, 302, 369, 678, 757, 833, 869, 1397, 2128, 2129, 3168, 3310, 3378, 4371, 4482, 4720, 5093, 5255, 5358, 5915, 5954, 6197, 6630, 6784, 7021, 7066, 7567, 7577, 7583, 7741, 7824, 7995, 8502, 9104, 9470, 9924, 9939, 10307, 10640, 10673, 10790, 11734, 12244, 12446, 12454, 12583, 12746, 12848, 12985, 13526, 13536, 13617, 13849, 13966, 14105, 14458, 15333, 15913, 15983, 16067, 16288, 16369, 16616, 16776, 17101, 17237, 17464, 17530, 17552, 18660, 18705, 19003, 19604, 19978 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(302, result.number);
            Assert.AreEqual(731645, result.newNumber);
        }


        [TestMethod]
        public void TestMethod211()
        {
            int[] numbers = new int[] { 341, 862, 975, 1437, 1451, 1791, 2306, 2571, 2631, 2704, 2803, 2831, 3097, 3205, 3454, 3556, 3827, 4086, 4227, 4338, 4647, 4706, 5184, 5361, 5369, 6252, 6403, 6550, 6584, 6628, 6794, 6842, 6944, 7118, 7415, 7487, 7951, 8460, 8601, 8950, 9120, 9173, 9571, 9670, 10007, 10144, 10149, 10327, 10355, 10557, 10627, 10945, 11807, 11837, 12003, 12130, 12172, 12262, 12374, 12847, 13028, 13082, 13349, 13702, 14270, 14420, 14605, 14853, 15214, 15492, 15875, 16266, 16577, 16618, 16637, 16641, 16693, 16939, 17058, 17113, 17224, 17289, 17350, 17629, 17868, 18683, 18739, 18837, 18849, 18874, 19116, 19208, 19815, 19822 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(341, result.number);
            Assert.AreEqual(962004, result.newNumber);
        }


        [TestMethod]
        public void TestMethod212()
        {
            int[] numbers = new int[] { 37, 105, 122, 404, 732, 767, 809, 868, 868, 1010, 1014, 1321, 1325, 1455, 1723, 1729, 1806, 1812, 1852, 2308, 2537, 2613, 2762, 2903, 2915, 2916, 2983, 3009, 3159, 3221, 3238, 3249, 3467, 3516, 3517, 3616, 3628, 3770, 3786, 3891, 3937, 4006, 4041, 4115, 4302, 4311, 4354, 4394, 4521, 4635, 4679, 4713, 4754, 4845, 4866, 4953, 5071, 5080, 5086, 5109, 5351, 5358, 5378, 5389, 5556, 5754, 5875, 6190, 6367, 6458, 6814, 6857, 7097, 7107, 7114, 7223, 7238, 7278, 7529, 7752, 7836, 7976, 7992, 8009, 8148, 8232, 8244, 8440, 8510, 8563, 8571, 8583, 8599, 8782, 8824, 8879, 8946, 8984, 9014, 9022, 9071, 9109, 9253, 9472, 9705, 9889, 9977, 10043, 10090, 10093, 10245, 10266, 10676, 10739, 10789, 10999, 11157, 11261, 11328, 11340, 11434, 11698, 11746, 11813, 11870, 11917, 12202, 12207, 12226, 12328, 12640, 12769, 12806, 12821, 12823, 12886, 12918, 13027, 13040, 13062, 13093, 13099, 13152, 13156, 13451, 13589, 13819, 13827, 14078, 14304, 14320, 14345, 14358, 14419, 14423, 14635, 14719, 14825, 14852, 14897, 15108, 15116, 15160, 15210, 15280, 15360, 15443, 15479, 15492, 15668, 15679, 15748, 15847, 15875, 15958, 16123, 16300, 16656, 16667, 16908, 17073, 17272, 17352, 17358, 17393, 17400, 17475, 17485, 17492, 17656, 17761, 17763, 17764, 17808, 18273, 18314, 18331, 18342, 18471, 18536, 18651, 18667, 18900, 19030, 19160, 19186, 19358, 19380, 19485, 19491, 19680, 19681, 19727, 19801, 19873, 19939 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(404, result.number);
            Assert.AreEqual(2190355, result.newNumber);
        }


        [TestMethod]
        public void TestMethod213()
        {
            int[] numbers = new int[] { 42, 109, 293, 310, 451, 484, 580, 583, 618, 647, 686, 729, 907, 922, 1026, 1179, 1181, 1195, 1211, 1216, 1258, 1268, 1272, 1539, 1540, 2025, 2048, 2254, 2266, 2457, 2461, 2511, 2548, 2559, 2639, 2731, 2946, 2983, 3132, 3150, 3200, 3361, 3395, 3495, 3514, 3581, 3761, 3812, 3856, 3957, 4023, 4093, 4200, 4222, 4264, 4281, 4312, 4346, 4370, 4380, 4460, 4649, 4701, 4727, 4748, 4830, 4871, 4892, 4910, 4922, 5120, 5262, 5272, 5280, 5285, 5294, 5320, 5334, 5627, 5695, 5713, 5830, 5838, 5918, 6047, 6125, 6136, 6212, 6548, 6565, 6602, 6798, 6948, 7285, 7305, 7545, 7577, 7707, 7811, 7877, 7894, 7985, 8190, 8216, 8485, 8549, 8578, 8624, 8683, 8703, 8744, 8886, 8919, 9055, 9067, 9261, 9264, 9289, 9303, 9305, 9436, 9451, 9455, 9497, 9603, 9706, 9750, 9924, 10041, 10077, 10086, 10128, 10142, 10217, 10245, 10263, 10288, 10321, 10455, 10490, 10566, 10677, 10787, 10870, 10934, 11143, 11162, 11171, 11433, 11475, 11603, 11752, 11798, 11800, 11860, 11896, 11899, 11909, 12055, 12327, 12467, 12470, 12503, 12552, 12594, 12726, 12836, 12982, 13011, 13077, 13087, 13149, 13166, 13168, 13172, 13174, 13191, 13232, 13276, 13285, 13318, 13411, 13426, 13435, 13445, 13538, 13615, 13744, 13758, 13771, 13852, 13888, 13912, 13914, 13916, 13935, 13937, 14012, 14072, 14212, 14241, 14246, 14338, 14436, 14523, 14525, 14589, 14602, 14621, 14665, 14670, 14774, 15019, 15030, 15104, 15206, 15355, 15361, 15420, 15439, 15450, 15452, 15459, 15462, 15517, 15538, 15623, 15691, 15735, 15836, 15844, 15855, 16016, 16195, 16205, 16211, 16416, 16424, 16478, 16515, 16549, 16585, 16728, 16848, 16870, 16874, 17041, 17043, 17044, 17115, 17146, 17215, 17222, 17388, 17403, 17505, 17656, 17675, 17717, 17911, 17938, 18000, 18004, 18191, 18228, 18234, 18326, 18397, 18932, 18978, 19117, 19150, 19211, 19292, 19314, 19340, 19359, 19664, 19828, 19860, 19980, 19981, 19990 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(109, result.number);
            Assert.AreEqual(2904935, result.newNumber);
        }


        [TestMethod]
        public void TestMethod214()
        {
            int[] numbers = new int[] { 106, 136, 188, 574, 603, 770, 1173, 1226, 1350, 1403, 1630, 1727, 1776, 1845, 2005, 2183, 2190, 2453, 2493, 2531, 2549, 2595, 2629, 2985, 3075, 3130, 3165, 3198, 3271, 3585, 3637, 3655, 3666, 3778, 3794, 3846, 3866, 3948, 3956, 4043, 4115, 4316, 4522, 4707, 4785, 4906, 4908, 5335, 5472, 5525, 5574, 5677, 5680, 5688, 5733, 5759, 5916, 5940, 5946, 5947, 6035, 6118, 6167, 6466, 6498, 6569, 6576, 6625, 6638, 6664, 6680, 6874, 7080, 7089, 7234, 7301, 7697, 7710, 7796, 7810, 7867, 7903, 8245, 8266, 8267, 8372, 8410, 8429, 8444, 8506, 8547, 8910, 8950, 9066, 9109, 9194, 9204, 9352, 9354, 9481, 9503, 9541, 9761, 9799, 9836, 9905, 9905, 9919, 9935, 10049, 10123, 10139, 10239, 10327, 10594, 10611, 10664, 10852, 11000, 11026, 11052, 11130, 11250, 11270, 11564, 11577, 11641, 11703, 11765, 11821, 11827, 12003, 12090, 12222, 12338, 12361, 12495, 12496, 12558, 12694, 12694, 12744, 12829, 12846, 12911, 13026, 13034, 13090, 13331, 13384, 13427, 13492, 13507, 13584, 13655, 13717, 13746, 13830, 14124, 14126, 14148, 14213, 14266, 14270, 14455, 14856, 14916, 14926, 14949, 14954, 15052, 15186, 15282, 15439, 15460, 15472, 15481, 15493, 15529, 15556, 15598, 15682, 15702, 15736, 15778, 15790, 16045, 16066, 16088, 16505, 16547, 16567, 16623, 16655, 16762, 16813, 17026, 17152, 17214, 17282, 17296, 17433, 17494, 17530, 17614, 17802, 17832, 18103, 18169, 18203, 18291, 18494, 18531, 18559, 18785, 18812, 18997, 19068, 19132, 19242, 19340, 19422, 19858, 19970, 19981 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(188, result.number);
            Assert.AreEqual(2310797, result.newNumber);
        }


        [TestMethod]
        public void TestMethod215()
        {
            int[] numbers = new int[] { 31, 188, 283, 366, 477, 533, 619, 684, 702, 788, 857, 1056, 1089, 1131, 1145, 1178, 1209, 1221, 1269, 1288, 1412, 1557, 1564, 1688, 1701, 1799, 1805, 1831, 1833, 1842, 1867, 1972, 1987, 2074, 2185, 2283, 2400, 2458, 2470, 2551, 2556, 2683, 2726, 2910, 2919, 2921, 3160, 3164, 3474, 3632, 3735, 3767, 3822, 3887, 3956, 3996, 4007, 4090, 4145, 4255, 4283, 4290, 4318, 4349, 4394, 4397, 4440, 4470, 4477, 4816, 4850, 4974, 5000, 5063, 5305, 5369, 5409, 5495, 5528, 5617, 5673, 5801, 5903, 5936, 5985, 6263, 6365, 6545, 6581, 6663, 6955, 7364, 7439, 7566, 7692, 7753, 7756, 7760, 7784, 7788, 7876, 7911, 8014, 8052, 8081, 8253, 8326, 8355, 8447, 8544, 8647, 8679, 8733, 8914, 8980, 9009, 9205, 9239, 9265, 9389, 9570, 9584, 9663, 9817, 9859, 10166, 10213, 10236, 10335, 10641, 10642, 10680, 10932, 11072, 11082, 11085, 11191, 11315, 11372, 11418, 11425, 11493, 11549, 11558, 11566, 11727, 11784, 11818, 11836, 11848, 11887, 11980, 12037, 12074, 12091, 12335, 12762, 12792, 12795, 12850, 12891, 12914, 12951, 13039, 13044, 13338, 13474, 13506, 13514, 13531, 13535, 13539, 13636, 13681, 13772, 13790, 13820, 13892, 13918, 14027, 14092, 14263, 14334, 14420, 14486, 14521, 14531, 14615, 14622, 14626, 14871, 14969, 15041, 15094, 15136, 15199, 15227, 15278, 15327, 15372, 15460, 15521, 15589, 15740, 15808, 15873, 16042, 16050, 16205, 16236, 16286, 16303, 16424, 16495, 16517, 16596, 16698, 16705, 16797, 16819, 17138, 17153, 17223, 17325, 17404, 17454, 17456, 17493, 17611, 17726, 17780, 17888, 17924, 17928, 17940, 18055, 18077, 18226, 18234, 18256, 18305, 18413, 18517, 18593, 18597, 18666, 18672, 18820, 19073, 19091, 19094, 19115, 19149, 19195, 19286, 19337, 19344, 19420, 19612, 19655, 19872, 19903, 19956 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(188, result.number);
            Assert.AreEqual(2664222, result.newNumber);
        }


        [TestMethod]
        public void TestMethod216()
        {
            int[] numbers = new int[] { 387, 429, 669, 806, 929, 969, 985, 1039, 1202, 1211, 1288, 1395, 1552, 1948, 2031, 2042, 2168, 2288, 2387, 2517, 2551, 3357, 3444, 3559, 3591, 3660, 3761, 3945, 3946, 3993, 4122, 4144, 4161, 4414, 4469, 4522, 4650, 4703, 4854, 4901, 4914, 4968, 4988, 5344, 5363, 5380, 5437, 5579, 5588, 5673, 5952, 6346, 6451, 6576, 6668, 6689, 6892, 7021, 7090, 7118, 7219, 7252, 7364, 7532, 7879, 7926, 7950, 7954, 8027, 8064, 8105, 8219, 8234, 8635, 9073, 9121, 9147, 9151, 9167, 9423, 9550, 9581, 9823, 9920, 10105, 10111, 10137, 10350, 10641, 10669, 10946, 11096, 11115, 11308, 11328, 11502, 11714, 11868, 11918, 12182, 12236, 12339, 12366, 12410, 12414, 12446, 12734, 12921, 13106, 13258, 13338, 13342, 13406, 13649, 13784, 14069, 14136, 14170, 14236, 14294, 14394, 14539, 14616, 14820, 14872, 15630, 15666, 15837, 16018, 16172, 16229, 16234, 16243, 16366, 16520, 16586, 17023, 17092, 17308, 17413, 18006, 18081, 18318, 18376, 18424, 18579, 18581, 18728, 18751, 18760, 18953, 19054, 19109, 19453, 19599, 19651, 19714 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(806, result.number);
            Assert.AreEqual(1509549, result.newNumber);
        }


        [TestMethod]
        public void TestMethod217()
        {
            int[] numbers = new int[] { 1002, 1021, 1084, 1439, 1651, 1959, 2174, 2335, 2338, 2377, 2521, 2859, 2906, 3103, 3589, 3806, 3985, 4266, 4296, 4297, 4610, 5059, 5346, 5881, 5970, 6048, 6479, 6951, 7448, 7729, 7868, 8205, 8355, 8425, 8797, 9242, 9354, 9641, 10057, 10191, 10587, 10755, 10997, 11158, 11212, 11268, 11452, 11624, 11721, 11849, 11932, 12186, 12422, 12541, 13015, 13126, 13332, 13440, 13453, 13565, 13617, 14195, 14236, 14522, 14536, 14601, 15061, 15326, 15413, 15543, 16738, 16754, 16915, 17029, 17218, 17739, 17897, 18015, 18219, 18515, 18531, 18865, 19017, 19301, 19309, 19534, 19644, 19719 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1021, result.number);
            Assert.AreEqual(911341, result.newNumber);
        }


        [TestMethod]
        public void TestMethod218()
        {
            int[] numbers = new int[] { 161, 218, 236, 460, 939, 1096, 1126, 1172, 1491, 1562, 1614, 1653, 2253, 2927, 3153, 3283, 3462, 3493, 4233, 4255, 4462, 4660, 5611, 5671, 6128, 6895, 6925, 7409, 7582, 7783, 7955, 8014, 8017, 8046, 8050, 8066, 8393, 8483, 9507, 9835, 9973, 10008, 10302, 10325, 11098, 11169, 11228, 11240, 11431, 11655, 11675, 11820, 11994, 12164, 12304, 12666, 13011, 13079, 13220, 13437, 13516, 14880, 15369, 15390, 15424, 15445, 15626, 15679, 15689, 15911, 16004, 16104, 16403, 16537, 16753, 16881, 16947, 16983, 17033, 17656, 17756, 18002, 18085, 18101, 18108, 18152, 18153, 18332, 18595, 18611, 18621, 18668, 19363, 19644, 19650 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(218, result.number);
            Assert.AreEqual(1012818, result.newNumber);
        }


        [TestMethod]
        public void TestMethod219()
        {
            int[] numbers = new int[] { 199, 254, 574, 593, 704, 765, 795, 832, 899, 976, 983, 1086, 1149, 1154, 1382, 1580, 1754, 2004, 2282, 2521, 3159, 3417, 3496, 3551, 3736, 4226, 4269, 4273, 4371, 4386, 4457, 5756, 5945, 6203, 6440, 6635, 6767, 6906, 7035, 7058, 7103, 7397, 7593, 7645, 7700, 7759, 7799, 7822, 7892, 7950, 8152, 8193, 8202, 8265, 8477, 8551, 8585, 8603, 8688, 8794, 8963, 8998, 9004, 9033, 9119, 9147, 9585, 9612, 9654, 9822, 9841, 9940, 10026, 10209, 10382, 10401, 10474, 10519, 10614, 10740, 10880, 11130, 11135, 11184, 11238, 11279, 11332, 11363, 11534, 11597, 11797, 11812, 11862, 11894, 12010, 12111, 12259, 12391, 12421, 12453, 12641, 12830, 13098, 13149, 13251, 13262, 13608, 13737, 14362, 14731, 14813, 14954, 15430, 15584, 15749, 15795, 15869, 15911, 15984, 16104, 16183, 16237, 16314, 16409, 16477, 16484, 16684, 16700, 16740, 16880, 16914, 17056, 17081, 17154, 17211, 17235, 17260, 17434, 17673, 17759, 17939, 18247, 18701, 18989, 19085, 19228, 19303, 19307, 19457, 19505, 19552, 19556, 19693, 19768, 19801, 19821, 19913, 19949 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(254, result.number);
            Assert.AreEqual(1688424, result.newNumber);
        }


        [TestMethod]
        public void TestMethod220()
        {
            int[] numbers = new int[] { 837, 3320, 5252, 7635, 7949, 8001, 9235, 9649, 11385, 11508, 14561, 15222, 16946, 18489, 18651, 18682, 19271 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(9649, result.number);
            Assert.AreEqual(120584, result.newNumber);
        }


        [TestMethod]
        public void TestMethod221()
        {
            int[] numbers = new int[] { 177, 362, 397, 471, 546, 659, 774, 775, 780, 971, 1013, 1054, 1148, 1272, 1307, 1657, 1672, 1717, 1855, 1883, 1922, 2017, 2115, 2236, 2332, 2341, 2813, 2864, 2901, 2909, 2963, 3289, 3332, 3339, 3340, 3421, 3630, 3823, 3945, 4079, 4149, 4339, 4412, 4419, 4472, 4541, 4631, 4640, 4678, 4721, 4787, 4850, 5267, 5299, 5405, 5545, 5814, 5816, 5906, 5968, 6110, 6152, 6171, 6272, 6326, 6495, 6497, 6590, 6627, 6694, 6946, 6951, 6967, 6986, 7123, 7128, 7482, 7563, 7648, 7654, 7711, 7751, 7760, 8083, 8198, 8382, 8679, 8683, 8693, 8824, 8981, 9045, 9189, 9285, 9413, 9483, 9484, 9590, 9633, 9699, 9860, 9931, 9988, 10176, 10307, 10516, 10599, 10604, 10642, 10649, 10741, 10841, 10975, 11111, 11183, 11244, 11276, 11324, 11507, 11530, 11762, 12001, 12024, 12182, 12269, 12305, 12310, 12312, 12359, 12371, 12381, 12421, 12472, 12486, 12528, 12663, 12665, 12780, 12915, 13123, 13301, 13314, 13400, 13459, 13488, 13574, 13674, 13679, 13832, 13973, 14008, 14032, 14204, 14242, 14461, 14580, 14586, 14651, 14657, 14983, 14988, 15217, 15267, 15391, 15578, 15811, 15858, 15991, 16081, 16568, 16732, 16856, 16968, 17137, 17235, 17251, 17344, 17434, 17503, 17548, 17593, 17874, 18013, 18197, 18543, 18569, 18624, 18684, 18764, 18866, 18867, 18911, 18951, 18974, 18999, 19088, 19146, 19281, 19282, 19324, 19372, 19600, 19891, 19918, 19959 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(177, result.number);
            Assert.AreEqual(2034965, result.newNumber);
        }


        [TestMethod]
        public void TestMethod222()
        {
            int[] numbers = new int[] { 35, 153, 275, 444, 857, 992, 1079, 1186, 1231, 1560, 1583, 1648, 1743, 1749, 1814, 2003, 2153, 2307, 2389, 2416, 2749, 2792, 3284, 3453, 3563, 3800, 3886, 3917, 4000, 4031, 4319, 4363, 4475, 4847, 5010, 5090, 5270, 5292, 5561, 5651, 6050, 6283, 6315, 6383, 6447, 6459, 6726, 6735, 6821, 6861, 7001, 7034, 7398, 7476, 7629, 7665, 7940, 7957, 7993, 8027, 8235, 8593, 8646, 8657, 8789, 9018, 9156, 9243, 9322, 9467, 9597, 9698, 9743, 9843, 9947, 9955, 10200, 10243, 10289, 10302, 10312, 10356, 10407, 10613, 10623, 10740, 10765, 10791, 11145, 11316, 11342, 11438, 11530, 11577, 11612, 11834, 11881, 12033, 12302, 12325, 12352, 12540, 12608, 12748, 12905, 12977, 13011, 13299, 13464, 13539, 13561, 13821, 14053, 14089, 14102, 14306, 14557, 14665, 14677, 14719, 14787, 14848, 14968, 14998, 15098, 15214, 15248, 15304, 15444, 15468, 15523, 15548, 15748, 16091, 16243, 16659, 16823, 16880, 16886, 16904, 17000, 17106, 17187, 17258, 17415, 17495, 17864, 18015, 18041, 18329, 18355, 18434, 18621, 18646, 18852, 18921, 19048, 19062, 19500, 19729, 19746, 19811, 19880, 19913, 19947 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(35, result.number);
            Assert.AreEqual(1714498, result.newNumber);
        }


        [TestMethod]
        public void TestMethod223()
        {
            int[] numbers = new int[] { 214, 320, 465, 721, 842, 895, 964, 999, 1007, 1053, 1126, 1313, 1496, 1527, 1537, 1541, 1617, 1810, 1867, 1884, 1906, 1981, 2245, 2283, 2307, 2437, 2527, 2968, 3036, 3058, 3258, 3396, 3476, 3705, 3796, 3918, 4034, 4244, 4281, 4482, 4546, 4638, 4654, 4789, 4845, 5015, 5133, 5179, 5202, 5355, 5386, 5518, 5544, 5556, 5603, 5828, 6120, 6223, 6304, 6562, 6588, 6681, 6718, 6766, 6785, 6812, 6896, 7133, 7237, 7358, 7446, 7450, 7466, 7636, 7644, 7654, 7711, 7730, 7868, 7928, 8027, 8180, 8229, 8426, 8436, 8492, 8554, 8610, 8691, 8756, 8801, 8859, 8875, 9011, 9026, 9043, 9295, 9305, 9394, 9527, 9870, 10022, 10036, 10085, 10221, 10423, 10501, 10504, 10573, 10806, 11095, 11212, 11300, 11359, 11422, 11465, 11741, 12104, 12273, 12362, 12731, 13082, 13127, 13294, 13351, 13487, 13578, 13672, 13696, 13766, 13908, 14058, 14089, 14094, 14111, 14157, 14165, 14274, 14298, 14775, 14808, 15013, 15029, 15100, 15100, 15146, 15163, 15209, 15217, 15287, 15459, 15607, 15674, 15702, 15927, 15994, 16045, 16055, 16122, 16180, 16263, 16263, 16316, 16518, 16529, 16609, 16795, 16937, 17119, 17268, 17453, 17491, 17511, 17592, 17599, 17599, 17684, 17794, 17865, 17889, 17893, 18027, 18055, 18078, 18117, 18157, 18240, 18294, 18333, 18339, 18359, 18454, 18571, 18660, 18934, 19044, 19054, 19100, 19157, 19404, 19529, 19570, 19623, 19653, 19675, 19722, 19895, 19942 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(214, result.number);
            Assert.AreEqual(2187621, result.newNumber);
        }


        [TestMethod]
        public void TestMethod224()
        {
            int[] numbers = new int[] { 48, 219, 543, 574, 647, 805, 808, 900, 1004, 1185, 1747, 2146, 2505, 2576, 2643, 3362, 3419, 3620, 3822, 3826, 3845, 4093, 4158, 4198, 4405, 4500, 4519, 4633, 5008, 5051, 5119, 5170, 5175, 5235, 5373, 5545, 6115, 6162, 6207, 6303, 6870, 6916, 6964, 7015, 7384, 7589, 7644, 7654, 7843, 7851, 7880, 8017, 8272, 8452, 8461, 8563, 8593, 8769, 8989, 9056, 9429, 9518, 9805, 9807, 10060, 10101, 10657, 10885, 10903, 11107, 11236, 11352, 11422, 11494, 11504, 11519, 11732, 11786, 12140, 12151, 12337, 12568, 12582, 12589, 12590, 12636, 12660, 13066, 13157, 13164, 13307, 13442, 13479, 13564, 13630, 13639, 13647, 13900, 14024, 14137, 14233, 14425, 14559, 14815, 14865, 14923, 15053, 15229, 15233, 15296, 15462, 15612, 15630, 15765, 15876, 15993, 16010, 16236, 16420, 16603, 16650, 16685, 16898, 17285, 17654, 17710, 17872, 18311, 18365, 18553, 18683, 18749, 18795, 18919, 19134, 19157, 19264, 19389, 19565, 19623, 19982 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(647, result.number);
            Assert.AreEqual(1469502, result.newNumber);
        }


        [TestMethod]
        public void TestMethod225()
        {
            int[] numbers = new int[] { 46, 832, 842, 1051, 1221, 1788, 3139, 3898, 3970, 4094, 4356, 4415, 6029, 6563, 6585, 7394, 7932, 8317, 8707, 8801, 8832, 9087, 9534, 9730, 10844, 10986, 11001, 11455, 11635, 11741, 12040, 12510, 12687, 13197, 13501, 13794, 14250, 14393, 14723, 14897, 15367, 16462, 17465, 17612, 17709, 17794, 18303, 18762, 19167, 19202, 19397, 19462, 19711 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1221, result.number);
            Assert.AreEqual(551481, result.newNumber);
        }


        [TestMethod]
        public void TestMethod226()
        {
            int[] numbers = new int[] { 75, 97, 170, 248, 259, 367, 554, 595, 813, 822, 921, 935, 975, 1035, 1194, 1269, 1334, 1408, 1543, 1732, 1741, 1758, 1781, 2047, 2104, 2200, 2207, 2364, 2591, 2743, 2745, 2938, 3124, 3140, 3240, 3323, 3570, 3628, 3714, 3804, 3839, 3964, 4029, 4302, 4377, 4416, 4524, 4560, 4705, 4791, 4994, 5084, 5147, 5187, 5228, 5247, 5344, 5400, 5458, 5503, 5564, 5869, 5878, 5997, 6108, 6250, 6475, 6637, 6769, 6898, 6977, 7023, 7235, 7356, 7431, 7540, 7633, 7672, 7800, 7900, 7972, 8216, 8271, 8540, 8544, 8663, 8860, 9066, 9128, 9166, 9249, 9370, 9392, 9483, 9931, 10019, 10021, 10034, 10070, 10100, 10328, 10377, 10628, 10682, 10802, 11005, 11205, 11209, 11290, 11391, 11407, 11492, 11644, 11719, 11785, 11829, 12010, 12027, 12117, 12230, 12311, 12376, 12438, 12606, 12760, 12804, 13030, 13174, 13339, 13340, 13439, 13595, 13837, 13898, 14041, 14091, 14134, 14147, 14165, 14231, 14303, 14488, 14527, 14605, 14619, 14694, 14730, 14789, 14825, 14917, 15230, 15320, 15349, 15522, 15584, 15889, 16460, 16510, 16601, 16640, 16642, 16936, 16953, 17021, 17241, 17285, 17334, 17479, 17563, 17651, 17674, 17755, 17826, 17856, 17864, 17977, 18096, 18316, 18358, 18541, 18590, 18611, 18657, 18689, 18763, 18813, 18896, 18927, 18968, 19031, 19174, 19174, 19204, 19423, 19436, 19579, 19624, 19698, 19714, 19797, 19810, 19941 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(259, result.number);
            Assert.AreEqual(2061786, result.newNumber);
        }


        [TestMethod]
        public void TestMethod227()
        {
            int[] numbers = new int[] { 343, 803, 915, 1231, 1340, 1345, 1675, 1868, 1912, 2018, 2248, 2518, 2741, 3328, 3361, 3410, 3529, 3548, 3600, 3660, 3969, 4138, 4266, 4366, 4595, 4617, 4713, 4737, 4847, 4849, 5253, 5369, 5458, 5540, 5815, 5960, 6272, 6555, 6596, 6838, 6875, 6927, 7099, 7382, 7423, 7442, 7647, 7717, 7720, 7945, 7982, 8021, 8706, 8739, 8747, 8871, 9174, 9321, 9529, 9819, 9824, 10165, 10222, 10263, 10461, 10783, 11008, 11009, 11090, 11238, 11316, 11415, 11686, 11724, 11910, 11932, 12064, 12127, 12207, 12286, 12287, 12387, 12439, 12695, 12783, 13162, 13459, 13508, 13606, 13853, 14122, 14205, 14221, 14690, 14858, 14976, 15329, 15489, 15613, 16086, 16116, 16261, 16888, 16904, 16961, 16976, 17411, 18094, 18104, 18145, 18158, 18207, 18433, 18963, 19316, 19364, 19437, 19880 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(343, result.number);
            Assert.AreEqual(1132992, result.newNumber);
        }


        [TestMethod]
        public void TestMethod228()
        {
            int[] numbers = new int[] { 4035, 4048, 4636, 4656, 4738, 5549, 6159, 6183, 7825, 8270, 11229, 11280, 11648, 12096, 12594, 13627, 13786, 13793, 15684, 15890, 16696, 16750, 16846 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(4656, result.number);
            Assert.AreEqual(188273, result.newNumber);
        }


        [TestMethod]
        public void TestMethod229()
        {
            int[] numbers = new int[] { 14, 94, 168, 329, 329, 337, 347, 496, 713, 865, 879, 1238, 1287, 1448, 1557, 1678, 1694, 1773, 1779, 1790, 2042, 2097, 2166, 2218, 2482, 2566, 2583, 2692, 2704, 2738, 2831, 2866, 2924, 2946, 3062, 3084, 3137, 3273, 3349, 3429, 3483, 3552, 3709, 3984, 4062, 4096, 4120, 4278, 4470, 4570, 4583, 4642, 4659, 4669, 4726, 4770, 4798, 4829, 4838, 4865, 4967, 5067, 5135, 5325, 5362, 5404, 5407, 5441, 5471, 5642, 5674, 5780, 5788, 5918, 5967, 5970, 6078, 6112, 6128, 6164, 6183, 6198, 6404, 6425, 6501, 6608, 6732, 6766, 6854, 6864, 6894, 6906, 7022, 7023, 7055, 7104, 7126, 7139, 7182, 7272, 7377, 7409, 7438, 7444, 7564, 7630, 7769, 7790, 7813, 7828, 7940, 7982, 8061, 8127, 8326, 8936, 8943, 8994, 8996, 9028, 9188, 9216, 9259, 9283, 9307, 9385, 9424, 9429, 9579, 9602, 9695, 9749, 9758, 9765, 9781, 9918, 9925, 10029, 10102, 10245, 10249, 10251, 10272, 10281, 10384, 10398, 10541, 10589, 10668, 10687, 10804, 10836, 10938, 10946, 11372, 11535, 11556, 11628, 11641, 11741, 11783, 11793, 11808, 11886, 12102, 12170, 12174, 12187, 12232, 12268, 12290, 12349, 12379, 12383, 12428, 12443, 12473, 12514, 12527, 12548, 12678, 12762, 13195, 13197, 13229, 13281, 13379, 13486, 13506, 13532, 13540, 13676, 13779, 13787, 13908, 14021, 14084, 14130, 14319, 14399, 14577, 14755, 14767, 14799, 14967, 15040, 15043, 15146, 15250, 15259, 15294, 15328, 15331, 15367, 15394, 15489, 15507, 15592, 15670, 15670, 15684, 15688, 15688, 15723, 15738, 15778, 15883, 15976, 15976, 16284, 16333, 16363, 16410, 16505, 16524, 16613, 16708, 16712, 16721, 16787, 16805, 16812, 16846, 16992, 16993, 17121, 17145, 17223, 17288, 17309, 17474, 17506, 17509, 17542, 17593, 17610, 17863, 17875, 17950, 17955, 17977, 17985, 18012, 18103, 18229, 18287, 18350, 18362, 18376, 18470, 18489, 18573, 18666, 18670, 18678, 18780, 18993, 19011, 19094, 19112, 19141, 19244, 19313, 19471, 19655, 19709, 19766, 19871, 19876, 19977 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(329, result.number);
            Assert.AreEqual(3038906, result.newNumber);
        }


        [TestMethod]
        public void TestMethod230()
        {
            int[] numbers = new int[] { 384, 420, 575, 814, 858, 904, 1310, 1412, 1444, 1543, 1580, 1601, 1856, 1966, 2009, 2258, 2316, 2471, 2613, 2620, 2763, 2905, 3032, 3093, 3094, 3204, 3230, 3238, 3355, 3408, 3560, 3726, 3783, 3811, 3814, 3820, 3862, 3870, 3959, 4124, 4195, 4212, 4300, 4400, 4785, 4793, 4809, 4878, 4935, 4935, 4993, 5015, 5139, 5290, 5402, 5500, 5586, 5601, 5774, 5812, 5817, 5932, 5996, 6180, 6207, 6486, 6536, 6656, 6666, 6669, 6988, 6990, 7140, 7217, 7317, 7388, 7418, 7538, 7580, 7744, 7777, 8001, 8026, 8163, 8286, 8504, 8529, 8909, 8975, 9032, 9059, 9140, 9311, 9335, 9502, 9518, 9642, 9859, 9948, 10027, 10147, 10724, 10741, 10755, 10783, 10859, 10956, 11136, 11284, 11376, 11464, 11755, 11827, 11849, 12000, 12114, 12155, 12162, 12178, 12200, 12358, 12378, 12762, 12788, 12935, 13051, 13101, 13336, 13431, 13439, 13443, 13485, 13647, 13669, 13730, 13776, 13899, 14010, 14311, 14354, 14459, 14627, 14717, 14824, 14925, 15040, 15146, 15159, 15547, 15562, 15736, 15765, 16018, 16083, 16156, 16217, 16367, 16389, 16450, 16558, 17034, 17087, 17147, 17336, 17379, 17413, 17444, 17527, 17546, 17552, 17572, 17622, 17636, 17677, 17697, 17742, 17985, 17994, 18019, 18100, 18145, 18151, 18182, 18216, 18340, 18362, 18393, 18424, 18478, 18922, 18986, 18998, 19103, 19169, 19213, 19428, 19449, 19587, 19861 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(384, result.number);
            Assert.AreEqual(2028211, result.newNumber);
        }


        [TestMethod]
        public void TestMethod231()
        {
            int[] numbers = new int[] { 94, 142, 326, 664, 756, 825, 982, 1095, 1259, 1350, 1408, 1486, 1698, 1735, 1738, 1843, 1980, 2031, 2230, 2853, 2868, 2879, 3059, 3427, 3463, 3537, 3608, 3951, 4210, 4849, 4856, 4907, 4990, 5013, 5075, 5305, 5640, 5663, 5721, 5774, 6150, 6280, 6393, 6404, 6534, 6615, 6617, 6683, 6722, 6818, 6873, 6882, 6935, 7005, 7085, 7196, 7257, 7417, 7477, 7483, 7743, 7749, 7830, 7974, 8118, 8360, 8536, 8578, 8591, 8880, 8969, 9003, 9351, 9363, 9580, 9705, 9870, 10097, 10131, 10173, 10184, 10215, 10236, 10414, 10501, 10515, 10529, 10624, 10874, 11039, 11161, 11939, 12069, 12124, 12220, 12289, 12324, 12342, 12446, 12495, 12591, 12606, 12824, 12896, 13044, 13107, 13471, 13562, 13573, 13580, 13672, 13700, 13820, 13933, 13962, 14033, 14099, 14155, 14343, 14445, 14502, 14509, 14554, 14574, 14600, 14694, 14820, 14947, 15049, 15143, 15399, 15454, 15478, 15490, 15496, 15596, 15610, 15676, 15826, 15913, 16180, 16212, 16364, 16370, 16453, 16459, 16498, 16569, 16834, 16874, 16904, 17323, 17602, 17668, 17710, 17740, 17789, 17879, 18006, 18071, 18071, 18146, 18665, 18934, 18952, 19007, 19134, 19165, 19330, 19477, 19487, 19642, 19733, 19777, 19917, 19985 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(94, result.number);
            Assert.AreEqual(1876651, result.newNumber);
        }


        [TestMethod]
        public void TestMethod232()
        {
            int[] numbers = new int[] { 159, 206, 247, 512, 672, 836, 858, 918, 1132, 1261, 1262, 1291, 1451, 1508, 1748, 1818, 1907, 1924, 1946, 2260, 2389, 2507, 2585, 2618, 2680, 2685, 2924, 3067, 3587, 4005, 4071, 4110, 4117, 4137, 4156, 4168, 4184, 4185, 4210, 4363, 4519, 4713, 4723, 4785, 4872, 4875, 5074, 5075, 5101, 5132, 5147, 5361, 5495, 5559, 5560, 5609, 5805, 5974, 6081, 6124, 6127, 6138, 6272, 6300, 6364, 6441, 6467, 6704, 6913, 7112, 7138, 7141, 7158, 7187, 7329, 7352, 7361, 7429, 7453, 7474, 7536, 7802, 7872, 7890, 7927, 8175, 8286, 8315, 8323, 8654, 8940, 9051, 9086, 9381, 9588, 9725, 9789, 9919, 10304, 10366, 10381, 10470, 10603, 10643, 10652, 10880, 10982, 11166, 11259, 11477, 11538, 11806, 12294, 12321, 12365, 12469, 12735, 12765, 12795, 12856, 13253, 13323, 13342, 13381, 13454, 13559, 13637, 13801, 13815, 13924, 13974, 14148, 14190, 14242, 14264, 14345, 14391, 14548, 14586, 14618, 14704, 14761, 15010, 15150, 15307, 15477, 15620, 15689, 16131, 16201, 16461, 16579, 16585, 16739, 16944, 16972, 16987, 17102, 17220, 17233, 17235, 17605, 17614, 18078, 18086, 18088, 18146, 18319, 18460, 18511, 18587, 18624, 18845, 18882, 18901, 18997, 18997, 19138, 19206, 19269, 19355, 19410, 19516, 19660, 19824, 19847, 19886, 19977, 19979 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(159, result.number);
            Assert.AreEqual(1892539, result.newNumber);
        }


        [TestMethod]
        public void TestMethod233()
        {
            int[] numbers = new int[] { 169, 293, 437, 467, 510, 542, 637, 775, 791, 793, 801, 802, 930, 979, 982, 999, 1041, 1147, 1345, 1439, 1475, 1486, 1580, 1609, 1697, 1782, 1836, 2017, 2178, 2214, 2404, 2455, 2551, 2611, 2634, 2641, 2646, 2738, 2799, 2852, 2859, 2861, 2918, 2930, 3006, 3147, 3187, 3248, 3296, 3348, 3522, 3633, 3648, 3720, 3774, 3848, 3881, 4012, 4051, 4150, 4181, 4206, 4226, 4255, 4275, 4299, 4395, 4420, 4433, 4546, 4615, 4621, 4650, 4950, 5082, 5140, 5350, 5397, 5412, 5419, 5448, 5471, 5570, 5585, 5644, 5761, 5817, 5817, 5824, 5843, 5848, 5862, 5982, 6013, 6015, 6130, 6141, 6162, 6231, 6290, 6315, 6321, 6418, 6440, 6463, 6506, 6610, 6739, 6771, 6849, 6926, 7034, 7119, 7145, 7192, 7224, 7244, 7280, 7361, 7385, 7615, 7742, 8024, 8033, 8155, 8218, 8262, 8268, 8297, 8471, 8497, 8502, 8522, 8635, 8708, 8731, 8765, 8843, 8903, 8940, 8965, 9000, 9013, 9157, 9165, 9297, 9359, 9432, 9496, 9611, 9699, 9709, 9712, 9729, 9735, 9801, 9852, 9883, 9984, 10050, 10115, 10130, 10209, 10306, 10457, 10476, 10506, 10548, 10727, 10739, 10819, 10918, 10957, 11020, 11067, 11194, 11213, 11239, 11251, 11277, 11412, 11452, 11506, 11516, 11626, 11764, 11815, 12152, 12170, 12239, 12257, 12332, 12362, 12417, 12494, 12495, 12504, 12566, 12714, 12729, 12763, 12780, 12855, 12936, 13106, 13136, 13139, 13201, 13207, 13220, 13230, 13284, 13287, 13312, 13477, 13724, 13785, 13845, 13917, 14034, 14146, 14204, 14233, 14357, 14371, 14475, 14600, 14669, 14693, 14719, 14793, 14880, 14881, 15066, 15330, 15411, 15529, 15539, 15546, 15726, 15732, 15846, 15914, 15953, 16027, 16047, 16139, 16212, 16275, 16342, 16348, 16534, 16577, 16628, 16661, 16848, 16865, 16903, 16914, 16949, 17029, 17088, 17151, 17242, 17243, 17288, 17324, 17490, 17499, 17509, 17630, 17697, 17740, 17792, 17836, 17853, 18191, 18290, 18302, 18345, 18359, 18381, 18489, 18586, 18587, 18755, 18957, 19061, 19079, 19149, 19180, 19206, 19271, 19315, 19548, 19814, 19820, 19981, 19994 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(293, result.number);
            Assert.AreEqual(2898811, result.newNumber);
        }


        [TestMethod]
        public void TestMethod234()
        {
            int[] numbers = new int[] { 147, 927, 1011, 1759, 1806, 1821, 2053, 2099, 2368, 2494, 2521, 2683, 2845, 3492, 3694, 4027, 4301, 4624, 4666, 4902, 4915, 5176, 5222, 5231, 5494, 5627, 5679, 5870, 6221, 6553, 6636, 6847, 6957, 6962, 7186, 7395, 8136, 8231, 8631, 8924, 9863, 9987, 10001, 10057, 10065, 10204, 10600, 10656, 11207, 11403, 11538, 11585, 11668, 11720, 12082, 12462, 12797, 12808, 12856, 12965, 13317, 13508, 13588, 13823, 14165, 14214, 14262, 14299, 14358, 14385, 14658, 15090, 15518, 15571, 15871, 16053, 16069, 16199, 16434, 16578, 16673, 16995, 17020, 17065, 17143, 17329, 17399, 17457, 17653, 18031, 18039, 18217, 18535, 18537, 18826, 18844, 18931, 19411, 19605, 19621, 19692, 19797, 19849 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(147, result.number);
            Assert.AreEqual(1120316, result.newNumber);
        }


        [TestMethod]
        public void TestMethod235()
        {
            int[] numbers = new int[] { 432, 1653, 1936, 2104, 2173, 2381, 3499, 3611, 3766, 3923, 4178, 4593, 4850, 5247, 5434, 5500, 5852, 6048, 6082, 6356, 6559, 6689, 6943, 6963, 7334, 7607, 8025, 8219, 9181, 9398, 9423, 9989, 10087, 10277, 10324, 10626, 11895, 11993, 12339, 12561, 12580, 12662, 12902, 13319, 13385, 13635, 13684, 14622, 14679, 14994, 15838, 16153, 16305, 16371, 16430, 16527, 17005, 17826, 17894, 17916, 18136, 18304, 18513, 19352, 19379, 19457, 19914, 19915 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(432, result.number);
            Assert.AreEqual(707034, result.newNumber);
        }


        [TestMethod]
        public void TestMethod236()
        {
            int[] numbers = new int[] { 168, 189, 268, 318, 374, 401, 617, 710, 745, 746, 780, 846, 889, 948, 1082, 1148, 1218, 1351, 1371, 1399, 1420, 1458, 1554, 1568, 1663, 1716, 1772, 1782, 1836, 1875, 1921, 1939, 1993, 2181, 2208, 2228, 2277, 2546, 2735, 2753, 2786, 2810, 2844, 3102, 3109, 3191, 3390, 3397, 3444, 3486, 3734, 3817, 3862, 3941, 3983, 4017, 4119, 4197, 4208, 4208, 4297, 4320, 4324, 4369, 4370, 4414, 4461, 4489, 4535, 4698, 4943, 5197, 5207, 5237, 5245, 5440, 5451, 5648, 5675, 5706, 5919, 5924, 5939, 5955, 6023, 6097, 6211, 6255, 6302, 6308, 6405, 6421, 6427, 6484, 6548, 6556, 6736, 6742, 6775, 6912, 6947, 7153, 7277, 7330, 7423, 7465, 7599, 7626, 7631, 7650, 7659, 7675, 7701, 7740, 7744, 7805, 7914, 7955, 8006, 8039, 8163, 8210, 8230, 8256, 8431, 8681, 8687, 8697, 8791, 8826, 8832, 8995, 9069, 9146, 9266, 9309, 9427, 9483, 9495, 9513, 9657, 9869, 9959, 10032, 10052, 10102, 10141, 10154, 10169, 10290, 10358, 10522, 10542, 10663, 10711, 10943, 11016, 11112, 11126, 11453, 11610, 11627, 11673, 11740, 12023, 12135, 12153, 12185, 12213, 12414, 12947, 12991, 13030, 13050, 13191, 13253, 13418, 13846, 13881, 13925, 13926, 13998, 14016, 14075, 14145, 14261, 14340, 14430, 14525, 14747, 14752, 14837, 15002, 15303, 15344, 15413, 15519, 15573, 15593, 15810, 15868, 15887, 16013, 16208, 16407, 16422, 16455, 16476, 16536, 16558, 16727, 16801, 17249, 17290, 17479, 17496, 17525, 17532, 17677, 17707, 17867, 17963, 17974, 18059, 18062, 18068, 18078, 18103, 18157, 18294, 18339, 18422, 18458, 18561, 18584, 18642, 18680, 18730, 18820, 18853, 18856, 18871, 18893, 18907, 18924, 19073, 19285, 19318, 19320, 19368, 19381, 19707, 19826, 19839, 19848, 19948, 19967 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(168, result.number);
            Assert.AreEqual(2469449, result.newNumber);
        }


        [TestMethod]
        public void TestMethod237()
        {
            int[] numbers = new int[] { 1738, 7018, 15021, 17047, 17563, 18109 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1738, result.number);
            Assert.AreEqual(1, result.newNumber);
        }


        [TestMethod]
        public void TestMethod238()
        {
            int[] numbers = new int[] { 392, 498, 639, 649, 700, 743, 825, 893, 912, 971, 1123, 1143, 1241, 1249, 1255, 1257, 1378, 1392, 1462, 1463, 1474, 1550, 1798, 1963, 2046, 2283, 2334, 2521, 2752, 2771, 2798, 2836, 2941, 3004, 3068, 3076, 3174, 3217, 3525, 3539, 3577, 3605, 3636, 3701, 3708, 3789, 3944, 4034, 4077, 4180, 4183, 4198, 4218, 4304, 4315, 4332, 4368, 4422, 4588, 4670, 4683, 4726, 4753, 4756, 4787, 4833, 4850, 4911, 4962, 4967, 5007, 5013, 5016, 5097, 5126, 5172, 5224, 5246, 5284, 5361, 5531, 5661, 5796, 5841, 5887, 5924, 5931, 5996, 6050, 6083, 6090, 6222, 6328, 6451, 6484, 6844, 6864, 6899, 6926, 6967, 7002, 7098, 7136, 7264, 7314, 7390, 7438, 7473, 7540, 7639, 7775, 7804, 7866, 7907, 7924, 7993, 8020, 8124, 8160, 8236, 8250, 8299, 8426, 8449, 8547, 8566, 8639, 8715, 8800, 8890, 8906, 8907, 9250, 9266, 9310, 9351, 9380, 9422, 9607, 9608, 9633, 9872, 9884, 10042, 10060, 10141, 10214, 10226, 10437, 10653, 10684, 11002, 11115, 11137, 11137, 11190, 11197, 11287, 11514, 11528, 11600, 11655, 11656, 11759, 11763, 11840, 11874, 11932, 12108, 12111, 12143, 12267, 12405, 12413, 12415, 12540, 12662, 12687, 12704, 12745, 12899, 13028, 13061, 13216, 13257, 13259, 13347, 13396, 13500, 13576, 13641, 13990, 14005, 14042, 14081, 14139, 14154, 14155, 14213, 14230, 14403, 14427, 14516, 14563, 14590, 14648, 14676, 14777, 14828, 15099, 15118, 15247, 15267, 15347, 15409, 15449, 15467, 15505, 15638, 15652, 15780, 15788, 15799, 15940, 16150, 16240, 16487, 16539, 16631, 16658, 16680, 16681, 16695, 16708, 16745, 16878, 16925, 16983, 17012, 17147, 17181, 17323, 17351, 17367, 17506, 17573, 17949, 18002, 18101, 18109, 18134, 18163, 18188, 18199, 18373, 18383, 18694, 18779, 18912, 19166, 19196, 19286, 19326, 19357, 19500, 19513, 19607, 19749, 19784, 19847, 19865, 19904, 19915, 19922 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(498, result.number);
            Assert.AreEqual(2703976, result.newNumber);
        }


        [TestMethod]
        public void TestMethod239()
        {
            int[] numbers = new int[] { 43, 70, 1107, 1868, 2520, 2571, 2811, 3651, 3751, 3841, 4207, 5035, 5604, 5944, 6092, 6635, 7108, 7335, 7585, 8001, 8016, 8311, 8371, 8681, 8741, 8776, 9538, 9555, 9555, 10019, 10350, 11365, 12273, 12339, 12782, 12795, 12975, 13256, 13607, 14138, 14386, 14522, 14697, 14797, 15040, 15191, 15453, 15748, 16064, 16111, 18258, 19448, 19973 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(70, result.number);
            Assert.AreEqual(495265, result.newNumber);
        }


        [TestMethod]
        public void TestMethod240()
        {
            int[] numbers = new int[] { 6, 34, 68, 109, 164, 181, 240, 259, 716, 786, 813, 824, 995, 1131, 1212, 1231, 1277, 1296, 1336, 1573, 1597, 1709, 1820, 2027, 2492, 2672, 2921, 3254, 3350, 3563, 3650, 4259, 4312, 4665, 4802, 4846, 4926, 5005, 5051, 5212, 5234, 5365, 5856, 5893, 6076, 6123, 6138, 6230, 6311, 6369, 6435, 6727, 6918, 7029, 7039, 7066, 7140, 7214, 7224, 7377, 7585, 7646, 7814, 8119, 8126, 8180, 8235, 8269, 8290, 8431, 8437, 8459, 8567, 8646, 8999, 9045, 9145, 9163, 9218, 9218, 9247, 9392, 9443, 9623, 9806, 9856, 9939, 10172, 10240, 10284, 10288, 10353, 10848, 10968, 11189, 11234, 11278, 11379, 11428, 11520, 11583, 11651, 11769, 11787, 11875, 11940, 11950, 12267, 12313, 12325, 12477, 12564, 12663, 12691, 12736, 13162, 13167, 13171, 13217, 13323, 13343, 13457, 13515, 13564, 13582, 13671, 13812, 14307, 14358, 14544, 14583, 14602, 14987, 15043, 15175, 15447, 15484, 15546, 15573, 15576, 15647, 15680, 15682, 15703, 15832, 16079, 16430, 16611, 16729, 16786, 17081, 17479, 17531, 17675, 17789, 17823, 17987, 18130, 18189, 18402, 18458, 18586, 18654, 18737, 18929, 18950, 18962, 19118, 19247, 19252, 19339, 19477, 19535, 19567, 19634, 19683, 19775, 19806, 19941 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(6, result.number);
            Assert.AreEqual(1836650, result.newNumber);
        }


        [TestMethod]
        public void TestMethod241()
        {
            int[] numbers = new int[] { 5, 337, 409, 449, 455, 495, 531, 598, 613, 678, 770, 836, 882, 996, 1131, 1264, 1578, 1651, 1811, 1816, 1865, 1873, 2108, 2134, 2139, 2271, 2369, 2638, 2669, 3152, 3152, 3205, 3213, 3290, 3358, 3576, 3812, 3834, 3836, 3909, 4155, 4166, 4207, 4261, 4290, 4328, 4462, 4541, 4627, 4654, 4705, 4739, 4898, 5140, 5151, 5187, 5203, 5399, 5429, 5511, 5540, 5545, 5629, 5793, 5920, 5959, 5977, 6041, 6257, 6327, 6448, 6487, 6544, 6606, 6834, 7179, 7226, 7521, 7685, 7757, 7846, 8082, 8156, 8160, 8166, 8315, 8355, 8490, 8626, 8780, 8816, 8976, 8996, 9080, 9096, 9282, 9414, 9428, 9647, 9795, 9972, 10002, 10453, 10472, 10502, 10507, 10523, 10752, 10985, 11083, 11115, 11189, 11213, 11419, 11469, 11582, 11669, 11987, 12388, 12437, 12446, 12461, 12572, 12583, 12696, 12786, 12798, 12905, 12945, 12949, 12969, 13069, 13288, 13502, 13721, 13784, 14037, 14173, 14375, 14425, 14579, 14715, 14787, 14793, 14879, 15097, 15144, 15328, 15344, 15370, 15655, 15742, 15827, 15829, 15926, 16147, 16175, 16235, 16272, 16328, 16545, 16759, 16794, 16844, 16951, 17046, 17300, 17364, 17462, 17798, 17968, 18291, 18365, 18377, 18403, 18597, 18714, 18728, 18982, 19028, 19169, 19392, 19485, 19660, 19757 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(337, result.number);
            Assert.AreEqual(1723257, result.newNumber);
        }


        [TestMethod]
        public void TestMethod242()
        {
            int[] numbers = new int[] { 213, 645, 730, 853, 1117, 1251, 1588, 1628, 1654, 1751, 1952, 2046, 2163, 2351, 2534, 2566, 2729, 2730, 2854, 2867, 3172, 3179, 3294, 3479, 3712, 3931, 4088, 4209, 4391, 4466, 4579, 4687, 4807, 4854, 5268, 5813, 5815, 5906, 5990, 7029, 7120, 7350, 7638, 7707, 7982, 7985, 8073, 8161, 8416, 8601, 8659, 8761, 9248, 9250, 9333, 9618, 9840, 10070, 10358, 10490, 10510, 11054, 11305, 11518, 11597, 11726, 12190, 12310, 12371, 12709, 12911, 13178, 13253, 13499, 13596, 13926, 13937, 14049, 14266, 14363, 14927, 15215, 15451, 15677, 15791, 16146, 16462, 16644, 16683, 17029, 17337, 17366, 17560, 17905, 18617, 18682, 18695, 18779, 18905, 19209, 19315, 19390, 19400, 19433, 19466, 19607, 19822 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(645, result.number);
            Assert.AreEqual(1030232, result.newNumber);
        }


        [TestMethod]
        public void TestMethod243()
        {
            int[] numbers = new int[] { 169, 453, 461, 464, 536, 555, 918, 1381, 1549, 1713, 1797, 1913, 2038, 2041, 2131, 2214, 2237, 2292, 2303, 2338, 2565, 2617, 3100, 3166, 3177, 3218, 3256, 3303, 3374, 3543, 3552, 3571, 3591, 3608, 3617, 4163, 4654, 4944, 4945, 5168, 5175, 5183, 5223, 5667, 5701, 5992, 5997, 6194, 6261, 6282, 6364, 6383, 6503, 6624, 6659, 6736, 6877, 6946, 6960, 7218, 7411, 7708, 7773, 7870, 7871, 7957, 7997, 8031, 8154, 8181, 8198, 8262, 8308, 8416, 8574, 8773, 8872, 8957, 9034, 9041, 9126, 9165, 9221, 9260, 9317, 9450, 9562, 9587, 9591, 9661, 9857, 10718, 10934, 10938, 11003, 11018, 11205, 11256, 11339, 11361, 11370, 11389, 11401, 11846, 11879, 11900, 11905, 11913, 12199, 12584, 13204, 13387, 13441, 13451, 13583, 13776, 13853, 14195, 14261, 14301, 14305, 14365, 14684, 14694, 14920, 15126, 15204, 15241, 15553, 15611, 15697, 15922, 15999, 16024, 16097, 16195, 16218, 16245, 16298, 16642, 16656, 16749, 16840, 16991, 17068, 17102, 17242, 17304, 17358, 17364, 17426, 17591, 17607, 18060, 18172, 18221, 18433, 18443, 18470, 18562, 18661, 18824, 19277, 19582, 19607, 19640, 19907, 19917, 19980 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(169, result.number);
            Assert.AreEqual(1685850, result.newNumber);
        }


        [TestMethod]
        public void TestMethod244()
        {
            int[] numbers = new int[] { 260, 286, 518, 643, 988, 1084, 1107, 1546, 1778, 2000, 2530, 2753, 2757, 2939, 3190, 3227, 3349, 3628, 3788, 3913, 3946, 4021, 4029, 4243, 4251, 4460, 4937, 5040, 5349, 5571, 5993, 6372, 6404, 6558, 6831, 7021, 7112, 7212, 7402, 7478, 7581, 7596, 7715, 7877, 7939, 8404, 8513, 8787, 8806, 9428, 9665, 10158, 10603, 10694, 10772, 11730, 11822, 12182, 12182, 12335, 12652, 13166, 13420, 13759, 13971, 14504, 14913, 14973, 15171, 15219, 15378, 15704, 16007, 16136, 16206, 16346, 16365, 16396, 16864, 17246, 17412, 17525, 18322, 18701, 18726, 18977, 19243, 19276, 19284, 19802 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(286, result.number);
            Assert.AreEqual(835939, result.newNumber);
        }


        [TestMethod]
        public void TestMethod245()
        {
            int[] numbers = new int[] { 252, 388, 790, 1192, 1244, 1434, 1533, 1709, 1979, 2505, 3197, 3754, 4379, 4530, 4590, 4752, 5667, 6120, 6309, 6443, 6504, 6669, 6923, 6996, 7686, 7990, 8804, 8912, 9288, 10026, 10396, 10630, 10795, 11096, 11393, 12350, 12651, 12667, 12690, 13003, 13158, 13256, 13315, 14243, 14271, 14475, 14715, 15395, 15649, 16398, 17086, 17190, 17229, 17778, 18216, 18848, 19079, 19595, 19653 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(388, result.number);
            Assert.AreEqual(558805, result.newNumber);
        }


        [TestMethod]
        public void TestMethod246()
        {
            int[] numbers = new int[] { 276, 601, 836, 1378, 1555, 2230, 2408, 4423, 4677, 5596, 6737, 6783, 7356, 7916, 8151, 8676, 9102, 9213, 9222, 9684, 10336, 11105, 11174, 12245, 12864, 13350, 13583, 14739, 14912, 15646, 15688, 15921, 16710, 16802, 16869, 17627, 17763, 17860, 18746, 19013 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(836, result.number);
            Assert.AreEqual(389179, result.newNumber);
        }


        [TestMethod]
        public void TestMethod247()
        {
            int[] numbers = new int[] { 116, 262, 376, 377, 516, 548, 635, 729, 964, 974, 1023, 1063, 1120, 1182, 1309, 1329, 1500, 1545, 1571, 1663, 1668, 1697, 1799, 1823, 1824, 1892, 1981, 2004, 2095, 2138, 2189, 2246, 2257, 2276, 2366, 2415, 2458, 2549, 2559, 2571, 2573, 2688, 2689, 2698, 2761, 2809, 2977, 3054, 3264, 3277, 3309, 3310, 3453, 3584, 3683, 3728, 3780, 3933, 3976, 4041, 4074, 4233, 4238, 4258, 4263, 4277, 4382, 4457, 4534, 4549, 4647, 4654, 4655, 4689, 4897, 5038, 5136, 5212, 5221, 5268, 5309, 5337, 5341, 5409, 5462, 5549, 5628, 5676, 5710, 5865, 5867, 5874, 6015, 6044, 6237, 6280, 6297, 6310, 6338, 6824, 6994, 7216, 7246, 7523, 7595, 7764, 7822, 7824, 7867, 7915, 7944, 8161, 8196, 8309, 8376, 8445, 8811, 8846, 8918, 8918, 8956, 8999, 9197, 9265, 9408, 9440, 9481, 9492, 9605, 9611, 9684, 9702, 9743, 9744, 9754, 9811, 10107, 10200, 10210, 10231, 10323, 10391, 10578, 10676, 10727, 10804, 10906, 10920, 11201, 11218, 11274, 11302, 11318, 11369, 11370, 11392, 11411, 11745, 11754, 11848, 12105, 12145, 12155, 12227, 12559, 12562, 12574, 13083, 13149, 13216, 13238, 13270, 13282, 13299, 13364, 13416, 13480, 13692, 13758, 13817, 13965, 13991, 14068, 14118, 14205, 14432, 14533, 14627, 14648, 14716, 14832, 14854, 14874, 14949, 14965, 14974, 15040, 15138, 15190, 15261, 15287, 15380, 15510, 15553, 15615, 15674, 15780, 16018, 16061, 16116, 16182, 16269, 16293, 16442, 16482, 16506, 16571, 16663, 16753, 16767, 16815, 16816, 16924, 16981, 17016, 17149, 17179, 17250, 17437, 17438, 17527, 17592, 17827, 17882, 17951, 17994, 18018, 18043, 18303, 18525, 18576, 18644, 18709, 18746, 18768, 18817, 18833, 18929, 19081, 19113, 19238, 19274, 19282, 19294, 19353, 19365, 19419, 19564, 19593, 19749, 19820, 19869, 19926 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(116, result.number);
            Assert.AreEqual(2578471, result.newNumber);
        }


        [TestMethod]
        public void TestMethod248()
        {
            int[] numbers = new int[] { 25, 133, 195, 197, 208, 295, 299, 300, 342, 488, 586, 779, 792, 878, 988, 1135, 1374, 1431, 1496, 1563, 1669, 1722, 1915, 1962, 2335, 2358, 2361, 2453, 2529, 2557, 2616, 2631, 2739, 2783, 2812, 2823, 2838, 2862, 2913, 3001, 3109, 3120, 3239, 3270, 3366, 3477, 3494, 3537, 3587, 3591, 3684, 3723, 3800, 3808, 4113, 4171, 4334, 4480, 4487, 4493, 4556, 4587, 4722, 4813, 4991, 5066, 5110, 5122, 5132, 5157, 5165, 5233, 5293, 5296, 5368, 5374, 5529, 5798, 5908, 5954, 6104, 6258, 6277, 6368, 6429, 6445, 6595, 6692, 6760, 6767, 6917, 6975, 7110, 7167, 7200, 7333, 7604, 7716, 7740, 7767, 7994, 8017, 8046, 8145, 8283, 8308, 8424, 8612, 8751, 8761, 8828, 8852, 8868, 9025, 9042, 9289, 9324, 9356, 9396, 9444, 9444, 9493, 9623, 9652, 9688, 9779, 9958, 10097, 10177, 10278, 10312, 10348, 10416, 10428, 10530, 10587, 10898, 10918, 10920, 11010, 11133, 11220, 11463, 11583, 11739, 12059, 12085, 12100, 12125, 12138, 12551, 12670, 12698, 12762, 12915, 12940, 12971, 12983, 12984, 13008, 13021, 13033, 13140, 13273, 13273, 13297, 13342, 13514, 13656, 13710, 13857, 13904, 13910, 13953, 14028, 14044, 14191, 14244, 14295, 14306, 14448, 14519, 14619, 14656, 14677, 14835, 14904, 14961, 15049, 15059, 15172, 15215, 15247, 15339, 15469, 15486, 15732, 15848, 16172, 16266, 16353, 16463, 16537, 16618, 16660, 16778, 16818, 16834, 16958, 17089, 17296, 17346, 17364, 17403, 17461, 17503, 17529, 17860, 17880, 17907, 18223, 18285, 18448, 18737, 18740, 18904, 19059, 19077, 19102, 19142, 19178, 19192, 19284, 19306, 19325, 19337, 19348, 19361, 19522, 19625, 19665, 19668, 19770, 19777, 19802, 19825, 19858, 19956 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(133, result.number);
            Assert.AreEqual(2464648, result.newNumber);
        }


        [TestMethod]
        public void TestMethod249()
        {
            int[] numbers = new int[] { 15, 108, 116, 156, 217, 242, 314, 329, 381, 465, 490, 499, 505, 684, 713, 754, 923, 943, 961, 992, 1078, 1149, 1173, 1186, 1245, 1335, 1388, 1428, 1431, 1437, 1537, 1538, 1563, 1610, 1625, 1703, 1777, 1873, 1932, 2033, 2056, 2134, 2573, 2840, 2950, 3282, 3363, 3434, 3461, 3469, 3759, 3880, 3948, 3956, 4049, 4146, 4468, 4537, 4836, 5186, 5191, 5205, 5271, 5283, 5316, 5362, 5392, 5564, 5692, 5724, 5803, 5873, 6005, 6334, 6506, 6535, 6586, 6649, 6671, 6732, 6808, 6882, 6889, 6991, 6999, 7079, 7080, 7182, 7213, 7260, 7282, 7329, 7411, 7457, 7468, 7483, 7486, 7574, 7679, 7738, 7863, 8008, 8081, 8098, 8111, 8285, 8298, 8345, 8458, 8491, 8570, 8680, 8817, 8963, 9100, 9135, 9216, 9358, 9377, 9434, 9462, 9560, 9565, 9740, 9812, 9898, 9905, 9916, 10003, 10021, 10021, 10233, 10242, 10314, 10544, 10549, 10573, 10657, 10672, 10707, 10748, 10940, 10972, 11164, 11237, 11300, 11366, 11373, 11494, 11548, 11868, 11970, 11993, 12116, 12197, 12296, 12309, 12518, 12677, 12749, 12756, 12924, 13014, 13016, 13139, 13243, 13252, 13384, 13976, 13989, 14044, 14068, 14145, 14170, 14547, 14583, 14591, 14592, 14620, 14635, 14716, 14763, 14937, 14963, 14967, 15081, 15219, 15420, 15498, 15606, 15867, 15917, 15975, 15996, 16023, 16272, 16301, 16312, 16355, 16369, 16447, 16511, 16550, 16603, 16638, 16680, 16703, 16946, 17035, 17070, 17195, 17285, 17326, 17350, 17449, 17611, 17726, 17872, 17909, 18033, 18048, 18241, 18280, 18368, 18523, 18523, 18526, 18666, 18801, 18819, 19074, 19322, 19398, 19479, 19546, 19638, 19671, 19721, 19855, 19863, 19872, 19906, 19908, 19911 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(15, result.number);
            Assert.AreEqual(2376198, result.newNumber);
        }


        [TestMethod]
        public void TestMethod250()
        {
            int[] numbers = new int[] { 319, 648, 857, 1349, 5157, 6160, 6296, 6828, 7310, 8373, 8429, 9390, 9434, 9603, 9807, 10883, 11257, 12686, 13214, 17944, 18504, 18738, 19897, 19934 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(319, result.number);
            Assert.AreEqual(199231, result.newNumber);
        }


        [TestMethod]
        public void TestMethod251()
        {
            int[] numbers = new int[] { 29, 434, 656, 713, 745, 854, 1256, 1344, 1382, 1663, 1756, 1822, 1848, 1879, 1897, 2152, 2159, 2249, 2263, 2468, 2518, 3221, 3457, 3596, 3619, 4041, 4160, 4310, 4361, 4552, 4676, 5113, 5469, 5743, 5822, 5896, 6066, 6535, 6721, 7019, 7122, 7278, 7282, 7428, 7511, 7541, 7612, 7863, 8160, 8191, 8217, 8312, 8346, 8404, 8469, 8701, 8796, 8840, 9059, 9062, 9073, 9090, 9199, 9244, 9275, 9277, 9295, 9303, 9695, 9875, 9922, 9933, 9977, 10047, 10052, 10055, 10059, 10150, 10311, 10396, 10513, 10559, 10569, 10653, 10685, 10741, 11469, 11479, 11615, 11616, 11710, 11797, 11832, 12197, 12359, 12577, 12629, 12686, 12915, 13050, 13153, 13362, 13487, 13509, 13517, 13605, 13673, 13674, 13721, 13788, 13960, 14042, 14046, 14095, 14144, 14155, 14382, 14400, 14583, 14596, 15001, 15169, 15416, 15521, 15958, 16087, 16207, 16271, 16340, 16596, 16653, 16663, 16673, 17032, 17785, 18099, 18254, 18368, 18486, 18581, 18622, 18747, 18900, 18944, 19043, 19140, 19574, 19746, 19844, 19867, 19948, 19968 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(713, result.number);
            Assert.AreEqual(1556647, result.newNumber);
        }


        [TestMethod]
        public void TestMethod252()
        {
            int[] numbers = new int[] { 787, 905, 2034, 2230, 2636, 3357, 4907, 5104, 5180, 5234, 6183, 6573, 6956, 7357, 7804, 7878, 7996, 8493, 8884, 10377, 10876, 11289, 12330, 12371, 12466, 12580, 12916, 13645, 13680, 13944, 14105, 14115, 14795, 15389, 15504, 15844, 16240, 16453, 17721, 17816, 18299, 18787, 19486 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(787, result.number);
            Assert.AreEqual(427963, result.newNumber);
        }


        [TestMethod]
        public void TestMethod253()
        {
            int[] numbers = new int[] { 298, 324, 382, 602, 607, 826, 897, 1174, 1248, 1400, 1703, 1878, 2253, 2285, 2471, 2517, 2535, 2609, 2667, 2880, 2952, 2976, 3111, 3122, 3206, 3462, 3567, 3582, 3588, 3815, 3847, 3877, 3934, 4179, 4334, 4386, 4480, 4486, 4611, 4738, 5074, 5086, 5371, 5511, 5533, 5719, 5844, 6155, 6167, 6242, 6283, 6412, 6748, 7122, 7320, 7600, 7615, 7761, 7800, 7835, 7968, 8062, 8140, 8142, 8175, 8291, 8305, 8362, 8362, 8452, 8585, 8633, 8869, 8972, 9023, 9590, 9603, 9639, 9648, 9776, 9937, 9972, 10130, 10209, 10272, 10311, 10447, 10572, 10658, 10766, 10810, 10946, 10947, 10984, 11225, 11257, 11293, 11301, 11485, 11585, 11589, 11646, 11772, 11936, 12013, 12049, 12467, 12597, 12604, 12666, 12757, 12776, 12882, 12893, 12910, 12910, 12927, 13262, 13274, 13281, 13353, 13447, 13791, 13818, 13850, 13908, 13926, 13932, 14311, 14329, 14347, 14415, 14475, 14525, 14538, 14635, 14717, 14761, 14773, 14882, 14893, 15010, 15172, 15295, 15306, 15352, 15363, 15506, 15522, 15524, 15577, 15971, 16253, 16340, 16344, 16724, 16742, 17051, 17057, 17136, 17219, 17286, 17298, 17318, 17421, 17450, 17535, 17968, 18102, 18187, 18347, 18440, 18446, 18456, 18495, 18519, 18537, 18872, 18897, 18921, 19107, 19498, 19764, 19910 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(298, result.number);
            Assert.AreEqual(1916048, result.newNumber);
        }


        [TestMethod]
        public void TestMethod254()
        {
            int[] numbers = new int[] { 5, 25, 58, 94, 211, 487, 654, 712, 979, 993, 1145, 1265, 1440, 1588, 1633, 1647, 1674, 1766, 1826, 1857, 1879, 1999, 2156, 2206, 2387, 2435, 2457, 2552, 2822, 2831, 3103, 3356, 3384, 3390, 3450, 3500, 3521, 3601, 3710, 4040, 4205, 4251, 4374, 4377, 4386, 4399, 4658, 4694, 4761, 4779, 4935, 4960, 5088, 5095, 5155, 5189, 5225, 5237, 5296, 5433, 5562, 5652, 5780, 5989, 6274, 6393, 6420, 6469, 6530, 6568, 6689, 6862, 6955, 6966, 7145, 7184, 7198, 7340, 7367, 7495, 7554, 7558, 7563, 7588, 7820, 7827, 8055, 8134, 8157, 8642, 8682, 8717, 8791, 8895, 9077, 9249, 9276, 9340, 9353, 9374, 9393, 9448, 9473, 9473, 9549, 9802, 9960, 10115, 10140, 10220, 10260, 10277, 10304, 10560, 10818, 10903, 10966, 11129, 11233, 11244, 11255, 11267, 11278, 11517, 11766, 11819, 11848, 11927, 12021, 12030, 12038, 12039, 12064, 12163, 12175, 12237, 12424, 12672, 12707, 12782, 12802, 12811, 12827, 12950, 13073, 13115, 13119, 13158, 13250, 13490, 13535, 13629, 13706, 13849, 13887, 13911, 13974, 14044, 14164, 14210, 14279, 14371, 14402, 14414, 14508, 14595, 14658, 14693, 14810, 14839, 14851, 14879, 14896, 14936, 15290, 15382, 15493, 15558, 15606, 15685, 15720, 15776, 15861, 15993, 16115, 16272, 16471, 16478, 16595, 16621, 16924, 17127, 17140, 17185, 17433, 17512, 17552, 17596, 17600, 17861, 17870, 17896, 17930, 18090, 18093, 18111, 18152, 18207, 18246, 18396, 18694, 18938, 19064, 19215, 19219, 19243, 19273, 19279, 19281, 19305, 19448, 19471, 19503, 19661, 19702, 19723, 19761, 19819, 19857, 19930 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(58, result.number);
            Assert.AreEqual(2393863, result.newNumber);
        }


        [TestMethod]
        public void TestMethod255()
        {
            int[] numbers = new int[] { 17, 35, 53, 339, 542, 586, 647, 649, 692, 837, 842, 976, 1061, 1094, 1120, 1149, 1277, 1413, 1492, 1530, 1683, 1732, 2036, 2046, 2057, 2103, 2452, 2790, 2806, 2851, 3002, 3144, 3446, 3539, 3554, 3703, 3811, 3814, 4080, 4091, 4143, 4144, 4150, 4273, 4351, 4421, 4502, 4534, 4535, 4581, 4635, 4676, 4917, 5054, 5067, 5069, 5097, 5128, 5296, 5308, 5344, 5411, 5567, 5803, 5804, 5820, 6030, 6049, 6179, 6254, 6330, 6347, 6446, 6476, 6492, 6572, 6601, 6634, 6678, 6831, 6907, 6925, 7029, 7044, 7123, 7164, 7186, 7332, 7354, 7380, 7442, 7493, 7580, 7625, 7840, 8036, 8071, 8101, 8162, 8237, 8396, 8526, 8596, 8625, 8644, 8759, 8776, 8779, 8816, 8964, 9126, 9174, 9186, 9236, 9254, 9378, 9475, 9741, 9770, 9854, 9877, 10194, 10206, 10263, 10271, 10305, 10393, 10406, 10413, 10526, 10598, 10834, 10835, 10841, 10919, 10960, 10994, 11643, 11700, 11848, 11894, 12113, 12125, 12170, 12316, 12381, 12562, 12582, 12740, 12768, 12777, 13275, 13415, 13444, 13525, 13599, 13618, 13679, 13707, 13739, 13741, 13816, 13860, 14252, 14303, 14357, 14437, 14545, 14628, 14676, 14942, 14951, 15313, 15371, 15427, 15688, 15804, 15987, 16007, 16041, 16375, 16400, 16402, 16425, 16448, 16499, 16512, 16587, 16705, 16855, 16888, 16995, 17053, 17230, 17233, 17256, 17278, 17312, 17428, 17748, 17861, 17957, 17958, 18200, 18204, 18477, 18487, 18511, 18537, 18966, 18992, 19064, 19079, 19089, 19134, 19169, 19554, 19571, 19739, 19761, 19857 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(53, result.number);
            Assert.AreEqual(2126212, result.newNumber);
        }


        [TestMethod]
        public void TestMethod256()
        {
            int[] numbers = new int[] { 137, 321, 391, 675, 728, 794, 804, 853, 1116, 1310, 1477, 1554, 1559, 1609, 1619, 1708, 1902, 2200, 2228, 2435, 2521, 2597, 2601, 2732, 2773, 3056, 3165, 3183, 3315, 3466, 3591, 3726, 3819, 3865, 4047, 4192, 4216, 4238, 4250, 4335, 4374, 4449, 4531, 4680, 4753, 4795, 4837, 4840, 4873, 5072, 5156, 5198, 5210, 5247, 5344, 5351, 5502, 5503, 5565, 5607, 5644, 5691, 5886, 6238, 6393, 6410, 6426, 6485, 6605, 6726, 6795, 6828, 6836, 6844, 6910, 7419, 7615, 7618, 7639, 7694, 7810, 7839, 7988, 8062, 8097, 8135, 8262, 8330, 8348, 8371, 8422, 8494, 8586, 8654, 8785, 8943, 8957, 8960, 9047, 9095, 9163, 9167, 9298, 9391, 9459, 9579, 9595, 9618, 9663, 9738, 9744, 9765, 9823, 9935, 10005, 10281, 10322, 10326, 10632, 10706, 11108, 11166, 11178, 11226, 11255, 11302, 11360, 11371, 11387, 11415, 11458, 11559, 11591, 11697, 11712, 11803, 11831, 11897, 11953, 12162, 12353, 12357, 12395, 12432, 12438, 12597, 12733, 12881, 13010, 13034, 13119, 13143, 13145, 13196, 13229, 13246, 13453, 13469, 13513, 13598, 13665, 13733, 13764, 13848, 13870, 14006, 14011, 14057, 14102, 14167, 14203, 14323, 14630, 14831, 14907, 14934, 15005, 15117, 15121, 15133, 15552, 15605, 15697, 15814, 15825, 15843, 15886, 15908, 16004, 16026, 16098, 16145, 16174, 16238, 16679, 16753, 16822, 16928, 17028, 17061, 17093, 17107, 17235, 17235, 17260, 17312, 17399, 17465, 17582, 17645, 17703, 17811, 17960, 17963, 18023, 18071, 18164, 18239, 18253, 18402, 18447, 18524, 18553, 18657, 18669, 18683, 18685, 18703, 18747, 18899, 19037, 19178, 19205, 19248, 19392, 19587, 19668, 19693, 19720, 19789, 19987 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(321, result.number);
            Assert.AreEqual(2548371, result.newNumber);
        }


        [TestMethod]
        public void TestMethod257()
        {
            int[] numbers = new int[] { 169, 598, 703, 781, 1034, 1127, 1326, 1462, 1821, 2013, 2037, 2045, 2262, 2402, 2995, 3289, 3417, 3682, 3859, 3946, 4084, 4214, 4225, 4306, 4397, 4496, 4909, 4941, 4989, 5084, 5093, 5180, 5229, 5328, 5526, 5605, 5774, 5858, 5935, 6118, 6418, 6475, 6601, 6839, 6912, 6988, 6998, 7015, 7165, 7634, 7927, 8251, 8792, 8883, 9180, 9235, 9401, 9427, 9445, 9647, 9651, 10046, 10077, 10123, 10500, 10723, 10758, 10762, 10790, 10971, 11081, 11130, 11254, 11271, 11279, 11298, 11382, 11539, 11785, 11924, 11940, 12054, 12065, 12335, 12339, 12422, 12643, 12825, 12970, 13134, 13155, 13391, 13453, 13552, 13570, 13597, 13770, 13905, 14031, 14130, 14396, 14566, 14567, 14809, 14986, 15185, 15211, 15284, 15302, 15330, 15505, 15699, 15781, 16057, 16070, 16081, 16147, 16398, 17446, 17461, 17640, 17812, 17854, 18062, 18257, 18491, 18774, 18867, 19065, 19200, 19205, 19383, 19399, 19439, 19467, 19504 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(169, result.number);
            Assert.AreEqual(1386681, result.newNumber);
        }


        [TestMethod]
        public void TestMethod258()
        {
            int[] numbers = new int[] { 91, 191, 338, 424, 440, 448, 457, 545, 624, 636, 892, 1063, 1207, 1314, 1327, 1345, 1580, 1715, 1784, 1875, 2001, 2015, 2077, 2169, 2312, 2314, 2360, 2387, 2591, 2619, 2632, 2827, 2831, 2843, 2847, 2937, 2950, 3070, 3080, 3106, 3135, 3287, 3423, 3547, 3559, 3597, 3717, 3723, 3742, 3747, 3772, 4126, 4189, 4357, 4358, 4402, 4510, 4603, 4725, 4777, 4812, 4835, 4875, 4917, 4925, 5014, 5052, 5055, 5065, 5149, 5261, 5275, 5291, 5294, 5372, 5639, 5697, 5730, 5780, 5873, 5880, 6035, 6051, 6131, 6449, 6599, 6718, 6784, 6979, 6989, 7101, 7212, 7256, 7356, 7448, 7612, 7635, 7722, 7846, 7856, 7865, 7873, 7890, 7973, 8098, 8129, 8155, 8219, 8230, 8240, 8334, 8335, 8346, 8385, 8395, 8473, 8559, 8584, 8596, 8623, 8737, 8747, 8799, 8903, 8958, 8960, 9218, 9243, 9251, 9308, 9395, 9401, 9405, 9410, 9442, 9560, 9570, 9573, 9581, 9736, 9779, 9799, 9864, 10067, 10124, 10163, 10196, 10206, 10294, 10323, 10356, 10391, 10497, 10668, 10684, 10690, 10796, 10883, 10910, 10972, 10998, 11223, 11243, 11286, 11309, 11502, 11586, 11620, 11865, 11869, 11877, 12376, 12430, 12475, 12549, 12635, 12640, 12895, 13054, 13068, 13073, 13143, 13459, 13585, 13640, 13695, 13806, 13814, 13896, 13970, 13980, 14305, 14341, 14383, 14420, 14496, 14496, 14557, 14663, 14668, 14744, 14783, 14800, 14875, 14877, 14913, 15104, 15204, 15214, 15283, 15366, 15438, 15445, 15584, 15802, 15846, 15848, 15994, 16091, 16095, 16099, 16181, 16329, 16485, 16526, 16551, 16641, 16689, 16738, 16750, 16782, 16832, 16859, 17025, 17145, 17165, 17242, 17318, 17352, 17357, 17431, 17650, 17775, 18060, 18245, 18253, 18273, 18408, 18436, 18534, 18587, 18690, 18704, 18710, 18803, 18805, 18847, 18896, 18921, 18921, 19076, 19257, 19286, 19358, 19376, 19599, 19707, 19718, 19749, 19795, 19866 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(191, result.number);
            Assert.AreEqual(2697755, result.newNumber);
        }


        [TestMethod]
        public void TestMethod259()
        {
            int[] numbers = new int[] { 11, 47, 131, 151, 200, 399, 417, 599, 856, 880, 904, 919, 966, 1000, 1186, 1219, 1320, 1555, 1699, 2248, 2428, 2710, 2804, 2896, 2901, 3023, 3082, 3096, 3976, 3987, 3990, 4001, 4283, 4738, 4817, 4994, 5385, 5442, 5547, 5676, 5911, 5963, 6061, 6158, 6234, 6620, 6956, 6968, 7053, 7055, 7500, 7607, 7636, 7915, 8074, 8330, 8360, 8757, 8764, 8787, 8872, 8888, 8914, 9098, 9159, 9235, 9371, 9378, 10071, 10158, 10253, 10281, 10636, 10774, 10885, 11119, 11208, 11476, 11602, 11713, 11821, 11952, 11984, 12056, 12190, 12200, 12331, 12772, 12871, 12909, 12950, 13113, 13181, 13364, 13385, 13589, 13940, 13957, 13998, 14122, 14142, 14197, 14741, 14945, 14975, 15145, 15199, 15227, 15512, 15591, 15605, 15626, 15682, 15725, 15848, 15940, 15967, 16009, 16010, 16598, 16606, 16777, 16812, 16937, 17111, 17292, 17522, 17589, 17631, 17675, 17685, 17689, 17928, 17986, 18014, 18014, 18258, 18448, 18455, 18488, 18649, 18910, 18921, 19048, 19105, 19167, 19334, 19448, 19598, 19903, 19971 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(200, result.number);
            Assert.AreEqual(1576694, result.newNumber);
        }


        [TestMethod]
        public void TestMethod260()
        {
            int[] numbers = new int[] { 80, 211, 366, 672, 680, 855, 898, 1259, 1265, 1319, 1489, 1533, 1566, 1586, 1791, 1844, 1884, 1914, 2036, 2205, 2209, 2302, 2479, 2606, 2646, 2765, 2812, 2876, 2941, 2972, 3753, 3827, 3867, 4039, 4053, 4069, 4104, 4260, 4929, 5000, 5215, 5259, 5337, 5377, 5445, 5556, 5940, 5953, 6040, 6059, 6134, 6151, 6293, 6657, 6718, 6957, 6959, 7018, 7048, 7075, 7481, 7568, 7747, 7793, 7917, 8065, 8358, 8746, 8906, 9237, 9268, 9372, 9520, 9834, 10325, 10332, 10412, 10681, 10724, 10813, 10815, 10854, 10938, 11117, 11151, 11537, 11552, 11843, 11892, 12073, 12118, 12348, 12367, 12415, 12450, 12512, 12513, 12532, 12941, 12999, 13052, 13062, 13138, 13146, 13194, 13236, 13429, 13674, 13678, 13993, 14026, 14294, 14316, 14403, 14488, 14765, 14838, 14863, 14883, 14988, 15101, 15407, 15511, 15593, 15703, 15794, 15940, 15982, 16232, 16420, 16519, 16538, 16554, 16802, 16920, 16964, 17087, 17095, 17210, 17383, 17477, 17629, 17650, 17780, 17876, 18182, 18195, 18301, 18346, 18389, 18439, 18598, 18659, 18677, 18805, 18866, 19009, 19072, 19201, 19219, 19688, 19918 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(366, result.number);
            Assert.AreEqual(1649216, result.newNumber);
        }


        [TestMethod]
        public void TestMethod261()
        {
            int[] numbers = new int[] { 18, 40, 68, 236, 268, 284, 348, 425, 575, 623, 715, 772, 932, 934, 953, 1055, 1129, 1133, 1303, 1370, 1389, 1533, 1694, 1743, 1831, 1866, 1926, 1984, 2079, 2148, 2155, 2347, 2384, 2587, 2797, 2920, 2923, 2954, 3167, 3335, 3345, 3460, 3689, 3728, 3771, 3942, 3975, 3985, 4196, 4323, 4333, 4369, 4441, 4655, 4691, 4693, 4707, 4745, 4762, 4820, 4878, 4987, 4989, 5003, 5062, 5271, 5305, 5338, 5449, 5802, 5971, 6059, 6154, 6501, 6661, 6677, 6712, 6750, 6817, 7084, 7433, 7524, 7603, 7664, 7683, 7786, 7791, 7846, 7874, 7913, 7944, 7961, 8151, 8271, 8292, 8712, 8867, 8867, 8920, 8981, 9016, 9162, 9185, 9267, 9355, 9764, 9809, 9946, 9992, 10046, 10086, 10424, 10688, 10735, 10802, 10877, 11109, 11120, 11121, 11165, 11197, 11360, 11390, 11456, 11632, 11664, 11690, 11721, 11756, 11783, 11952, 11971, 12031, 12057, 12105, 12121, 12218, 12339, 12373, 12440, 12599, 12822, 12959, 13111, 13215, 13219, 13294, 13393, 13443, 13471, 13498, 13587, 13654, 13725, 13988, 14074, 14112, 14208, 14228, 14247, 14270, 14309, 14315, 14370, 14419, 14593, 14613, 15024, 15070, 15088, 15121, 15134, 15273, 15324, 15328, 15485, 15607, 15621, 15629, 15635, 15692, 16067, 16136, 16335, 16383, 16396, 16438, 16440, 16464, 16490, 16729, 16730, 16795, 16811, 16931, 16934, 17058, 17080, 17381, 17452, 17537, 17634, 17648, 17673, 17735, 17773, 17792, 17859, 17883, 17989, 18057, 18098, 18193, 18206, 18282, 18519, 18640, 18689, 18725, 18786, 18859, 18903, 18981, 18986, 19215, 19231, 19295, 19491, 19644, 19652, 19654, 19708, 19734, 19912, 19953 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(68, result.number);
            Assert.AreEqual(2419400, result.newNumber);
        }


        [TestMethod]
        public void TestMethod262()
        {
            int[] numbers = new int[] { 113, 213, 319, 332, 374, 400, 442, 482, 593, 755, 829, 845, 867, 1055, 1077, 1249, 1347, 1407, 1428, 1615, 1691, 1694, 1788, 1906, 1994, 2029, 2066, 2092, 2119, 2190, 2299, 2434, 2475, 2541, 2551, 2594, 2615, 2656, 2659, 2698, 2730, 2928, 3103, 3124, 3244, 3286, 3351, 3374, 3515, 3587, 3718, 3719, 3831, 3977, 3997, 4027, 4098, 4105, 4183, 4233, 4339, 4458, 4873, 4997, 5030, 5035, 5037, 5056, 5118, 5233, 5239, 5245, 5357, 5399, 5451, 5529, 5533, 5554, 5594, 5612, 5623, 5797, 5820, 5832, 5848, 5886, 5988, 6083, 6244, 6268, 6441, 6517, 6544, 6547, 6565, 6609, 6674, 6720, 6760, 6828, 7019, 7134, 7150, 7239, 7392, 7404, 7474, 7498, 7578, 7614, 7720, 7746, 7834, 7886, 8037, 8297, 8430, 8532, 8764, 8980, 9092, 9156, 9229, 9268, 9280, 9335, 9401, 9443, 9498, 9508, 9509, 9694, 9695, 9785, 9991, 10091, 10140, 10370, 10388, 10413, 10527, 10649, 10787, 10791, 10863, 10928, 11070, 11098, 11132, 11243, 11399, 11443, 11525, 11646, 11742, 11811, 11821, 11850, 11938, 12009, 12134, 12150, 12253, 12295, 12326, 12370, 12433, 12465, 12474, 12797, 12855, 13119, 13122, 13189, 13278, 13353, 13418, 13426, 13492, 13659, 13750, 13866, 13914, 14017, 14099, 14163, 14300, 14302, 14308, 14394, 14430, 14495, 14506, 14519, 14583, 14626, 14752, 14795, 15027, 15031, 15092, 15500, 15530, 15540, 15608, 15619, 15620, 15633, 15660, 15782, 15884, 15887, 15909, 16035, 16095, 16125, 16182, 16277, 16296, 16555, 16614, 16642, 16976, 17052, 17091, 17163, 17171, 17329, 17341, 17366, 17414, 17422, 17665, 17683, 17745, 17863, 17958, 17997, 18116, 18123, 18158, 18226, 18320, 18376, 18384, 18437, 18694, 18940, 18942, 18949, 18952, 18956, 18958, 19013, 19067, 19182, 19244, 19370, 19385, 19413, 19605, 19701, 19736, 19849, 19883, 19896, 19969, 19978 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(113, result.number);
            Assert.AreEqual(2680800, result.newNumber);
        }


        [TestMethod]
        public void TestMethod263()
        {
            int[] numbers = new int[] { 1160, 1771, 2956, 3460, 4492, 4879, 5383, 5504, 5728, 5928, 6473, 6593, 6607, 7014, 7121, 7703, 7804, 8414, 8639, 8707, 9176, 9249, 9372, 9633, 9988, 10568, 10578, 10742, 11200, 11458, 11675, 11867, 12181, 12722, 12787, 12871, 12940, 13205, 13318, 13448, 13459, 14514, 14886, 15152, 15409, 16971, 16997, 17341, 17869, 17940, 17991, 18437, 19317, 19471 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1160, result.number);
            Assert.AreEqual(554243, result.newNumber);
        }


        [TestMethod]
        public void TestMethod264()
        {
            int[] numbers = new int[] { 145, 210, 506, 529, 1147, 1198, 1941, 2004, 2347, 2522, 2614, 2624, 2881, 2969, 3275, 3363, 3538, 3582, 4087, 4670, 5074, 5080, 5238, 5265, 5471, 5602, 5730, 5898, 5912, 6061, 6160, 6242, 6534, 6699, 6797, 6888, 6944, 7197, 7197, 7199, 7821, 8031, 8054, 8673, 8703, 8911, 9231, 9586, 9621, 9653, 9838, 9891, 10620, 10734, 10784, 10796, 10864, 11045, 11048, 11257, 11306, 11321, 11470, 11615, 11761, 11924, 12091, 12166, 12622, 12768, 13291, 13853, 13966, 13968, 14008, 14999, 15300, 15425, 15678, 15682, 15812, 15858, 16783, 17247, 17306, 17537, 17858, 18046, 18175, 18242, 18412, 19054, 19469 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(210, result.number);
            Assert.AreEqual(851507, result.newNumber);
        }


        [TestMethod]
        public void TestMethod265()
        {
            int[] numbers = new int[] { 157, 163, 168, 404, 542, 1138, 1274, 1370, 1388, 1410, 1519, 1566, 1703, 1816, 1883, 2060, 2338, 2377, 2642, 2854, 2880, 2888, 3168, 3597, 3598, 3730, 3896, 3950, 4326, 4640, 5014, 5091, 5095, 5108, 5124, 5210, 5298, 5328, 5369, 5383, 5469, 5511, 5541, 5557, 5925, 5997, 6028, 6066, 6148, 6315, 6493, 6871, 6951, 7107, 7146, 7189, 7685, 7733, 7875, 7926, 8055, 8060, 8195, 8391, 8494, 8631, 8655, 8656, 8707, 9209, 9304, 9378, 9891, 10042, 10119, 10122, 10342, 10447, 10539, 10691, 10703, 10710, 10900, 10974, 11154, 11477, 11502, 11719, 11965, 12025, 12122, 12241, 12321, 12349, 12381, 12524, 12677, 12785, 12901, 12998, 13320, 13351, 13503, 13673, 13798, 13872, 13877, 13905, 13939, 13992, 14150, 14287, 14293, 14588, 14853, 14975, 15065, 15222, 15268, 15302, 15327, 15386, 15613, 16079, 16319, 16526, 16842, 16880, 16884, 17047, 17441, 17450, 17530, 17534, 17785, 17789, 18222, 18443, 18993, 19123, 19544, 19632, 19695, 19792, 19804, 19897, 19912 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(542, result.number);
            Assert.AreEqual(1436027, result.newNumber);
        }


        [TestMethod]
        public void TestMethod266()
        {
            int[] numbers = new int[] { 75, 489, 780, 1537, 1685, 1721, 2406, 3188, 5462, 5614, 6120, 6156, 6172, 7559, 7978, 8078, 8089, 8137, 8531, 8680, 9767, 9944, 10176, 10422, 10424, 10569, 10865, 11218, 11618, 11633, 11885, 13403, 13663, 13971, 14000, 14187, 14548, 14554, 14819, 15932, 17000, 17636, 18006, 18561, 18738, 19178 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1685, result.number);
            Assert.AreEqual(437088, result.newNumber);
        }


        [TestMethod]
        public void TestMethod267()
        {
            int[] numbers = new int[] { 501, 2119, 2937, 3432, 3767, 5335, 7172, 7566, 7768, 8386, 9553, 9729, 10471, 10475, 10729, 10794, 10895, 11665, 11783, 11957, 11996, 15038, 16175, 17442, 17667, 18019, 18932, 19095, 19231 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(501, result.number);
            Assert.AreEqual(273418, result.newNumber);
        }


        [TestMethod]
        public void TestMethod268()
        {
            int[] numbers = new int[] { 203, 216, 369, 1190, 1432, 1939, 3003, 3755, 4212, 4612, 5018, 5136, 6189, 6297, 6647, 7632, 8706, 8957, 9632, 9989, 10589, 10741, 10948, 11529, 12293, 12726, 13614, 14319, 15254, 15888, 16120, 16235, 16303, 17951, 18346, 19557, 19953 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1432, result.number);
            Assert.AreEqual(330694, result.newNumber);
        }


        [TestMethod]
        public void TestMethod269()
        {
            int[] numbers = new int[] { 167, 255, 267, 318, 358, 416, 451, 544, 659, 887, 981, 1027, 1117, 1195, 1211, 1273, 1404, 1489, 1641, 1962, 1968, 2023, 2042, 2094, 2318, 2851, 2897, 2900, 2917, 2971, 3008, 3096, 3330, 3372, 3394, 3400, 3417, 3423, 3475, 3567, 3599, 3685, 3944, 4095, 4359, 4577, 4586, 4819, 4839, 5001, 5011, 5058, 5075, 5101, 5329, 5570, 5617, 5898, 5988, 6089, 6258, 6282, 6381, 6543, 6602, 6669, 6777, 6799, 6905, 7015, 7042, 7109, 7160, 7280, 7384, 7583, 7586, 7712, 7827, 7856, 7967, 7975, 8092, 8203, 8306, 8405, 8565, 8892, 8901, 8941, 9162, 9222, 9307, 9380, 9551, 9592, 9654, 9999, 10268, 10302, 10355, 10358, 10496, 10583, 10626, 10781, 10862, 10933, 11005, 11174, 11187, 11226, 11262, 11295, 11362, 11562, 11875, 12222, 12449, 12467, 12483, 12518, 12548, 12548, 12551, 12590, 13025, 13104, 13665, 13755, 13918, 14042, 14106, 14175, 14202, 14421, 14684, 14746, 14801, 14817, 14866, 14872, 14883, 15029, 15077, 15084, 15181, 15313, 15350, 15419, 15543, 15800, 15856, 15876, 15880, 15928, 15960, 15963, 16105, 16137, 16197, 16285, 16389, 16475, 16931, 17016, 17077, 17187, 17282, 17368, 17455, 17483, 17650, 17716, 17842, 17928, 17985, 18000, 18113, 18163, 18181, 18480, 18619, 18675, 18778, 18828, 18829, 18951, 19022, 19029, 19071, 19083, 19086, 19374, 19422 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(167, result.number);
            Assert.AreEqual(1930235, result.newNumber);
        }


        [TestMethod]
        public void TestMethod270()
        {
            int[] numbers = new int[] { 51, 115, 405, 406, 761, 893, 912, 984, 1804, 1843, 1888, 1938, 1952, 1977, 2009, 2318, 2441, 2648, 2716, 2887, 3095, 3106, 3283, 3344, 3375, 3596, 3764, 3857, 4228, 4493, 4512, 4640, 4650, 4652, 4673, 4788, 4821, 4888, 4979, 5149, 5212, 5217, 5249, 5549, 5784, 5892, 6022, 6065, 6447, 6453, 6854, 7185, 7208, 7284, 7329, 7331, 7356, 7359, 7442, 7470, 7544, 7686, 7707, 7858, 8029, 8031, 8156, 8294, 8322, 8379, 8387, 9163, 9397, 9636, 9661, 9872, 10200, 10337, 10408, 10466, 10722, 10827, 10917, 11105, 11137, 11335, 11372, 11751, 11792, 11821, 12050, 12198, 12242, 12250, 12312, 12427, 12547, 12611, 12893, 13019, 14011, 14248, 14311, 14572, 14702, 14736, 15015, 15042, 15447, 15448, 15656, 15717, 15894, 15987, 16091, 16136, 16243, 16261, 16271, 16350, 16542, 17324, 17428, 17575, 17665, 18050, 18196, 18258, 18336, 18693, 18738, 18866, 19084, 19130, 19490, 19603, 19700, 19757, 19935, 19971 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(51, result.number);
            Assert.AreEqual(1336094, result.newNumber);
        }


        [TestMethod]
        public void TestMethod271()
        {
            int[] numbers = new int[] { 1097, 3098, 4754, 5243, 5729, 6378, 7405, 8342, 8727, 9926, 10186, 10533, 11106, 12975, 13035, 13119, 15086, 16172, 17622, 17818, 18809, 19700, 19866 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(3098, result.number);
            Assert.AreEqual(204492, result.newNumber);
        }


        [TestMethod]
        public void TestMethod272()
        {
            int[] numbers = new int[] { 69, 246, 260, 354, 380, 535, 672, 759, 909, 1070, 1191, 1319, 1412, 1541, 1661, 1673, 1917, 1999, 2142, 2156, 2191, 2198, 2302, 2303, 2579, 2655, 2685, 2698, 3235, 3271, 3385, 3434, 3553, 3686, 3726, 3781, 3813, 3949, 3955, 3980, 3981, 4308, 4408, 4442, 4620, 4660, 4850, 5139, 5214, 5330, 5336, 5352, 5526, 5528, 5704, 5737, 5777, 5779, 6007, 6046, 6070, 6098, 6162, 6188, 6425, 6450, 6537, 6606, 6960, 7051, 7093, 7140, 7355, 7379, 7573, 7584, 7634, 7883, 8008, 8164, 8186, 8217, 8231, 8267, 8316, 8349, 8696, 8711, 8813, 8859, 8927, 8988, 9107, 9146, 9152, 9167, 9437, 9549, 9562, 9694, 9743, 9819, 9907, 9916, 9933, 9940, 10179, 10500, 10516, 10631, 10708, 10724, 10851, 11031, 11041, 11297, 11479, 11492, 11514, 11552, 11606, 11716, 11818, 11864, 12066, 12155, 12197, 12288, 12391, 12400, 12773, 12839, 12841, 12848, 13030, 13048, 13227, 13349, 13419, 13428, 13481, 13685, 13688, 13750, 13835, 13869, 14029, 14072, 14171, 14211, 14224, 14382, 14416, 14498, 14702, 14705, 14809, 14939, 15003, 15018, 15021, 15110, 15199, 15635, 15661, 15692, 15717, 15850, 15878, 15890, 15963, 16061, 16255, 16326, 16435, 16443, 16815, 16860, 16913, 17129, 17169, 17261, 17567, 17623, 17677, 17691, 17757, 17826, 18203, 18327, 18431, 18641, 18652, 18766, 18789, 18877, 19008, 19062, 19069, 19075, 19085, 19089, 19094, 19123, 19212, 19219, 19258, 19284, 19305, 19337, 19428, 19539, 19615, 19652, 19671 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(354, result.number);
            Assert.AreEqual(2229756, result.newNumber);
        }


        [TestMethod]
        public void TestMethod273()
        {
            int[] numbers = new int[] { 6, 20, 51, 94, 104, 121, 164, 250, 284, 343, 378, 384, 556, 607, 768, 771, 914, 916, 975, 987, 1013, 1069, 1195, 1246, 1265, 1519, 1564, 1710, 1745, 1758, 1798, 1824, 1828, 1838, 1926, 1961, 1985, 1999, 2076, 2093, 2144, 2211, 2245, 2277, 2345, 2492, 2622, 2727, 2922, 3022, 3048, 3093, 3224, 3231, 3303, 3423, 3524, 3535, 3905, 4055, 4243, 4274, 4299, 4311, 4397, 4400, 4627, 4669, 4684, 4877, 4907, 4948, 5162, 5163, 5166, 5250, 5288, 5324, 5327, 5339, 5616, 5643, 5668, 5709, 5765, 5818, 5883, 6075, 6086, 6116, 6262, 6316, 6357, 6379, 6392, 6442, 6443, 6488, 6620, 6745, 6919, 6964, 7049, 7079, 7088, 7103, 7113, 7210, 7348, 7445, 7461, 7488, 7569, 7639, 7666, 7733, 7753, 7990, 8144, 8159, 8160, 8161, 8222, 8254, 8482, 8573, 8606, 8649, 8707, 8749, 8829, 8932, 8990, 9000, 9121, 9205, 9270, 9274, 9276, 9375, 9555, 9581, 9735, 10005, 10012, 10194, 10335, 10384, 10655, 10720, 10743, 10758, 10799, 11047, 11103, 11208, 11431, 11497, 11510, 11585, 11619, 11861, 11965, 12088, 12185, 12200, 12264, 12515, 12527, 12628, 12675, 12774, 12880, 12980, 12992, 13003, 13101, 13116, 13249, 13405, 13617, 13628, 13696, 13830, 13859, 13871, 13973, 13992, 14009, 14045, 14099, 14160, 14186, 14254, 14263, 14521, 14527, 14607, 14619, 14888, 14903, 14905, 14952, 14961, 15260, 15316, 15373, 15442, 15480, 15517, 15597, 15648, 15842, 15878, 16120, 16149, 16226, 16304, 16310, 16401, 16404, 16414, 16446, 16484, 16513, 16632, 16759, 16951, 17114, 17172, 17308, 17526, 17608, 17818, 17895, 18056, 18124, 18146, 18204, 18271, 18354, 18364, 18369, 18452, 18456, 18474, 18575, 18849, 19051, 19147, 19147, 19287, 19407, 19554, 19572, 19595, 19709, 19839, 19852, 19967, 19972 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(94, result.number);
            Assert.AreEqual(2453184, result.newNumber);
        }


        [TestMethod]
        public void TestMethod274()
        {
            int[] numbers = new int[] { 126, 1022, 1229, 1744, 2423, 2459, 2755, 2809, 3423, 3497, 3703, 3708, 5260, 6286, 7107, 7158, 7177, 7814, 7890, 8287, 8423, 8803, 9013, 9838, 9963, 10219, 11558, 11862, 12363, 12419, 12744, 13138, 13656, 14310, 14985, 15156, 15668, 16258, 17415, 18725, 18764, 19402, 19492 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(126, result.number);
            Assert.AreEqual(383717, result.newNumber);
        }


        [TestMethod]
        public void TestMethod275()
        {
            int[] numbers = new int[] { 23, 84, 114, 125, 186, 319, 415, 813, 817, 818, 877, 949, 1005, 1066, 1074, 1127, 1246, 1284, 1377, 1380, 1530, 1561, 1655, 2065, 2079, 2117, 2176, 2213, 2328, 2364, 2398, 2434, 2452, 2515, 2597, 2682, 2792, 2994, 3003, 3124, 3183, 3330, 3428, 3494, 3522, 3568, 3661, 3678, 3850, 3995, 4005, 4042, 4114, 4123, 4216, 4238, 4333, 4368, 4403, 4562, 4778, 4781, 4834, 4850, 4855, 4938, 4987, 5092, 5150, 5211, 5282, 5407, 5575, 5828, 5837, 5857, 5886, 5899, 5927, 6193, 6433, 6497, 6514, 6622, 6663, 7026, 7076, 7077, 7166, 7206, 7234, 7251, 7372, 7545, 7564, 7608, 7711, 7740, 7845, 8171, 8346, 8418, 8425, 8506, 8557, 8810, 8876, 8882, 9048, 9139, 9221, 9284, 9462, 9481, 9565, 9688, 9756, 9758, 9763, 9879, 10073, 10124, 10175, 10187, 10249, 10502, 10540, 10787, 10830, 11314, 11324, 11511, 11514, 11556, 11618, 11679, 11734, 11752, 11951, 12128, 12154, 12192, 12213, 12252, 12260, 12308, 12316, 12316, 12452, 12570, 12619, 12731, 12758, 12771, 12788, 12887, 12887, 12984, 13056, 13126, 13183, 13245, 13273, 13281, 13461, 13488, 13540, 13573, 13600, 13764, 13793, 13815, 13979, 14056, 14090, 14157, 14198, 14318, 14347, 14406, 14620, 14657, 14885, 15038, 15111, 15187, 15217, 15225, 15227, 15245, 15457, 15584, 15606, 15664, 15716, 15784, 15842, 15872, 16094, 16216, 16287, 16296, 16343, 16418, 16512, 16666, 16837, 16941, 16978, 16981, 17088, 17225, 17287, 17468, 17665, 17696, 17723, 17814, 17906, 17992, 18020, 18051, 18052, 18114, 18240, 18248, 18323, 18332, 18366, 18433, 18551, 18560, 18640, 18657, 18665, 18668, 18757, 18809, 19023, 19130, 19272, 19342, 19369, 19370, 19418, 19420, 19420, 19517, 19650, 19724, 19739, 19750, 19853, 19880 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(125, result.number);
            Assert.AreEqual(2615447, result.newNumber);
        }


        [TestMethod]
        public void TestMethod276()
        {
            int[] numbers = new int[] { 71, 78, 599, 704, 749, 772, 821, 843, 1031, 1083, 1142, 1370, 1471, 1629, 1755, 1784, 1863, 1972, 2084, 2365, 2387, 2448, 2596, 2999, 3009, 3041, 3074, 3090, 3224, 3550, 3588, 3606, 3606, 3680, 3711, 3796, 3820, 3927, 4020, 4274, 4442, 4651, 4979, 5133, 5256, 5360, 5568, 5690, 5698, 5748, 5820, 5954, 5985, 6121, 6888, 6911, 7155, 7380, 7832, 7847, 7909, 8074, 8370, 8416, 8485, 8503, 8545, 8776, 8905, 8941, 8993, 9076, 9081, 9152, 9207, 9499, 9501, 9639, 9761, 9779, 10047, 10239, 10242, 10558, 10678, 10818, 10931, 10979, 11035, 11039, 11129, 11869, 12150, 12213, 12236, 12454, 12494, 12585, 12607, 12697, 12770, 13103, 13118, 13377, 13589, 13599, 13620, 13720, 13838, 13848, 13889, 14048, 14081, 14171, 14634, 14698, 14760, 14999, 15020, 15134, 15217, 15754, 15775, 15986, 16052, 16263, 16337, 16838, 16840, 16921, 17215, 17373, 17440, 17451, 17515, 17785, 18111, 18130, 18136, 18166, 18190, 18349, 18572, 18800, 18814, 18860, 18865, 18987, 19537, 19656, 19740, 19753, 19868 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(71, result.number);
            Assert.AreEqual(1483373, result.newNumber);
        }


        [TestMethod]
        public void TestMethod277()
        {
            int[] numbers = new int[] { 417, 2680, 4317, 5994, 7603, 9949, 10333, 15036, 15348, 15945, 16155, 17404, 19077 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(4317, result.number);
            Assert.AreEqual(4742, result.newNumber);
        }


        [TestMethod]
        public void TestMethod278()
        {
            int[] numbers = new int[] { 51, 199, 219, 262, 382, 809, 1119, 1135, 1447, 1745, 2004, 2036, 2217, 2267, 2513, 2544, 3183, 3219, 3259, 3304, 3348, 3364, 3530, 3539, 3742, 4087, 4228, 4345, 4503, 4831, 4969, 5020, 5107, 5120, 5197, 5213, 5302, 5546, 5718, 5732, 5745, 5971, 6105, 6333, 6435, 6553, 6720, 7281, 7290, 7733, 8189, 8386, 8468, 8468, 8600, 8649, 8797, 8851, 8955, 9525, 9531, 9573, 9623, 9646, 9965, 9994, 10080, 10296, 10326, 10347, 10669, 10851, 10870, 10916, 10919, 10943, 11075, 11092, 11236, 11367, 11447, 11488, 11499, 11647, 11718, 11916, 11948, 12074, 12127, 12332, 12419, 12431, 12456, 12533, 12582, 12843, 12946, 12954, 12979, 13113, 13185, 13592, 14540, 14605, 14670, 14902, 15050, 15892, 16168, 16236, 16245, 16269, 16333, 16548, 16563, 16602, 16810, 17042, 17047, 17250, 17785, 18011, 18250, 18547, 19052, 19251, 19305, 19627, 19667, 19885 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(199, result.number);
            Assert.AreEqual(1234739, result.newNumber);
        }


        [TestMethod]
        public void TestMethod279()
        {
            int[] numbers = new int[] { 18, 167, 368, 424, 440, 548, 584, 669, 822, 869, 923, 935, 955, 1027, 1237, 1270, 1574, 1849, 1963, 2070, 2108, 2195, 2426, 2560, 2608, 2746, 3005, 3453, 3626, 3669, 3787, 3834, 3879, 3993, 4001, 4040, 4095, 4187, 4263, 4269, 4427, 4451, 4577, 5072, 5420, 5495, 6035, 6186, 6310, 6397, 6411, 6521, 6583, 6658, 6660, 6970, 7010, 7048, 7179, 7296, 7378, 7457, 7669, 7766, 7859, 7970, 8357, 8437, 8569, 8587, 8644, 8658, 8711, 8778, 8840, 9040, 9349, 9524, 9631, 10048, 10051, 10066, 10126, 10170, 10613, 10759, 10982, 11086, 11173, 11178, 11263, 11422, 11438, 11474, 11585, 11713, 11757, 11962, 12157, 12539, 12611, 12710, 12987, 13045, 13447, 13484, 13535, 13565, 13617, 13625, 13655, 13678, 13926, 14136, 14203, 14210, 14458, 14638, 14890, 15082, 15213, 15657, 15673, 15694, 15748, 15825, 16249, 16267, 16280, 16344, 16360, 16921, 17073, 17294, 17381, 17693, 17751, 18023, 18137, 18439, 18559, 18606, 18652, 18734, 18735, 18756, 18957, 19094, 19443, 19899 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(368, result.number);
            Assert.AreEqual(1401498, result.newNumber);
        }


        [TestMethod]
        public void TestMethod280()
        {
            int[] numbers = new int[] { 658, 688, 908, 1110, 1209, 1311, 1737, 2086, 2671, 2779, 2795, 2889, 3483, 3486, 3733, 3985, 4289, 4516, 5162, 5170, 5680, 5880, 7276, 7317, 7363, 7712, 9525, 10152, 10226, 10688, 11018, 11124, 11679, 11731, 11986, 12360, 12583, 12819, 13087, 13892, 13950, 14300, 14537, 14737, 15206, 15356, 16158, 16233, 17038, 17074, 17229, 17326, 17625, 17626, 18352, 19206, 19376, 19524, 19890 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(908, result.number);
            Assert.AreEqual(567792, result.newNumber);
        }


        [TestMethod]
        public void TestMethod281()
        {
            int[] numbers = new int[] { 30, 60, 65, 66, 109, 171, 242, 275, 328, 518, 568, 660, 689, 692, 703, 754, 938, 976, 1020, 1022, 1037, 1053, 1085, 1105, 1107, 1140, 1227, 1326, 1380, 1495, 1509, 1572, 1583, 1628, 1637, 1759, 1797, 1921, 1964, 2071, 2120, 2162, 2188, 2194, 2201, 2213, 2289, 2514, 2582, 2660, 2767, 2788, 2854, 3087, 3119, 3176, 3291, 3458, 3599, 3728, 3827, 3834, 3922, 3976, 4008, 4036, 4345, 4363, 4442, 4457, 4490, 4555, 4569, 4705, 5009, 5091, 5099, 5133, 5160, 5162, 5211, 5278, 5421, 5512, 5620, 5621, 5659, 5852, 6010, 6137, 6221, 6229, 6422, 6433, 6480, 6654, 6711, 6793, 6817, 6856, 6860, 7027, 7101, 7133, 7202, 7203, 7304, 7481, 7710, 7794, 7983, 7985, 8122, 8294, 8359, 8395, 8504, 8670, 8881, 8932, 8949, 8983, 9078, 9124, 9348, 9364, 9390, 9397, 9418, 9448, 9538, 9569, 9675, 9745, 9758, 9888, 10001, 10015, 10066, 10136, 10138, 10164, 10212, 10248, 10369, 10417, 10443, 10488, 10662, 10723, 10730, 10781, 10959, 11150, 11190, 11234, 11501, 11706, 11777, 11858, 12159, 12213, 12375, 12566, 12611, 12623, 12640, 12670, 12718, 12851, 12896, 12910, 12959, 12995, 13127, 13141, 13226, 13237, 13312, 13384, 13519, 13579, 13643, 13662, 13721, 13918, 13965, 13993, 14015, 14038, 14162, 14314, 14453, 14615, 14695, 14727, 14771, 14793, 15028, 15068, 15074, 15097, 15233, 15262, 15287, 15353, 15364, 15376, 15393, 15419, 15484, 15496, 15667, 15805, 15825, 16054, 16082, 16159, 16280, 16352, 16368, 16645, 16818, 16874, 16931, 17049, 17185, 17262, 17276, 17377, 17575, 17604, 17692, 17756, 17787, 17822, 17842, 17914, 17986, 18232, 18289, 18305, 18337, 18379, 18421, 18460, 18482, 18542, 18728, 18728, 18755, 18868, 18952, 19198, 19260, 19270, 19377, 19477, 19489, 19587, 19708, 19872 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(65, result.number);
            Assert.AreEqual(2487979, result.newNumber);
        }


        [TestMethod]
        public void TestMethod282()
        {
            int[] numbers = new int[] { 7, 325, 382, 422, 451, 492, 683, 814, 861, 945, 1037, 1037, 1199, 1329, 1944, 1951, 2332, 2408, 2570, 2586, 2714, 2833, 2844, 2896, 2952, 2954, 2988, 3231, 3243, 3264, 3333, 3363, 3445, 3451, 3625, 3634, 3787, 4015, 4056, 4162, 4317, 4537, 4545, 4725, 4897, 4909, 4981, 5006, 5015, 5361, 5409, 5429, 5766, 5795, 5842, 5896, 6206, 6216, 6304, 6336, 6525, 6641, 6731, 6802, 6947, 7078, 7108, 7123, 7166, 7199, 7652, 7806, 7821, 7901, 7906, 7933, 7945, 8152, 8170, 8476, 8552, 8666, 8738, 8846, 8884, 8948, 8955, 9207, 9344, 9429, 9462, 9663, 9765, 9881, 9956, 9986, 10021, 10159, 10318, 10397, 10461, 10533, 10569, 10983, 11020, 11073, 11081, 11174, 11338, 11540, 11627, 11805, 11914, 11923, 11943, 12101, 12236, 12560, 12633, 12642, 12902, 12902, 12955, 12982, 13025, 13111, 13125, 13374, 13404, 13436, 13443, 13518, 13561, 13762, 14005, 14118, 14189, 14237, 14600, 14662, 14681, 14688, 14700, 14796, 14903, 14998, 15154, 15186, 15273, 15432, 15568, 15645, 15699, 15785, 15838, 15962, 15981, 16023, 16044, 16056, 16088, 16574, 16638, 16699, 16705, 16885, 16992, 17081, 17239, 17269, 17408, 17449, 17484, 17569, 17742, 17861, 17897, 18075, 18133, 18214, 18388, 18470, 18518, 18539, 18764, 18825, 18956, 19000, 19009, 19207, 19462, 19623, 19946, 19963 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(422, result.number);
            Assert.AreEqual(1956831, result.newNumber);
        }


        [TestMethod]
        public void TestMethod283()
        {
            int[] numbers = new int[] { 33, 169, 250, 255, 267, 465, 569, 592, 658, 662, 711, 773, 816, 871, 912, 995, 1006, 1035, 1091, 1193, 1230, 1365, 1439, 1446, 1555, 1669, 1686, 1701, 1725, 1902, 2199, 2236, 2426, 2530, 2561, 3299, 3335, 3502, 3582, 3733, 3771, 3834, 3840, 3864, 3903, 3929, 3958, 4000, 4047, 4220, 4418, 4464, 4487, 4564, 4613, 4638, 4661, 4671, 4706, 4870, 4964, 5035, 5155, 5182, 5480, 5724, 5747, 5909, 6083, 6179, 6207, 6220, 6268, 6270, 6302, 6320, 6321, 6363, 6391, 6425, 6585, 6622, 6644, 6675, 6718, 6873, 6909, 7002, 7355, 7430, 7493, 7524, 7535, 7699, 7728, 7873, 7889, 7931, 7978, 7999, 8061, 8143, 8197, 8231, 8293, 8337, 8427, 8454, 8702, 9040, 9053, 9097, 9098, 9191, 9253, 9274, 9331, 9360, 9572, 9761, 9865, 9889, 9916, 9930, 9976, 10119, 10205, 10340, 10344, 10375, 10455, 10593, 10632, 10686, 10719, 10756, 10825, 10930, 11011, 11070, 11230, 11232, 11266, 11308, 11353, 11400, 11533, 11565, 11591, 11763, 11766, 12086, 12193, 12198, 12223, 12238, 12383, 12420, 12430, 12725, 12735, 12902, 12975, 13027, 13051, 13087, 13091, 13127, 13137, 13251, 13304, 13317, 13580, 13785, 13787, 13803, 13943, 14042, 14044, 14088, 14209, 14226, 14245, 14370, 14372, 14375, 14408, 14442, 14537, 14556, 14643, 14671, 14851, 14889, 14953, 15055, 15305, 15319, 15365, 15475, 15567, 15677, 15975, 15989, 16192, 16276, 16983, 17009, 17021, 17044, 17058, 17137, 17173, 17223, 17249, 17277, 17428, 17578, 17655, 17710, 17768, 17769, 17824, 17961, 17977, 18247, 18268, 18280, 18399, 18401, 18406, 18459, 18650, 18657, 18818, 18851, 18870, 18879, 18968, 19188, 19292, 19399, 19524, 19535, 19624, 19674, 19753, 19779, 19907 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(169, result.number);
            Assert.AreEqual(2474193, result.newNumber);
        }


        [TestMethod]
        public void TestMethod284()
        {
            int[] numbers = new int[] { 4, 35, 64, 175, 337, 473, 508, 579, 591, 634, 746, 790, 1088, 1176, 1306, 1308, 1312, 1375, 1408, 1433, 1458, 1549, 1572, 1831, 1899, 1905, 2085, 2124, 2153, 2179, 2212, 2314, 2341, 2368, 2528, 2565, 2691, 2743, 2844, 3023, 3119, 3253, 3305, 3345, 3399, 3400, 3470, 3475, 3540, 3583, 3709, 3740, 3761, 3769, 3776, 3805, 3810, 3888, 3970, 4009, 4066, 4107, 4161, 4175, 4291, 4481, 4490, 4515, 4793, 4989, 5112, 5214, 5257, 5442, 5465, 5569, 5620, 5668, 5780, 5804, 5872, 5970, 6126, 6130, 6501, 6538, 6583, 6632, 6661, 6662, 6677, 6911, 7098, 7193, 7268, 7280, 7305, 7454, 7521, 7565, 7752, 7872, 7884, 7888, 7937, 8104, 8213, 8227, 8318, 8336, 8362, 8435, 8510, 8785, 8922, 8973, 9098, 9339, 9472, 9484, 9519, 9553, 9557, 9653, 9702, 9746, 9905, 10130, 10337, 10345, 10361, 10370, 10404, 10548, 10567, 10573, 10601, 10602, 10698, 10759, 10853, 10966, 11037, 11086, 11121, 11152, 11289, 11328, 11331, 11512, 11551, 11706, 11712, 11807, 11832, 11846, 11965, 11995, 12009, 12093, 12095, 12155, 12362, 12474, 12657, 12716, 12824, 12827, 12897, 12940, 12978, 13154, 13441, 13549, 13574, 13714, 13815, 13885, 13913, 13921, 13974, 14021, 14065, 14237, 14379, 14487, 14550, 14656, 14675, 15085, 15092, 15235, 15241, 15252, 15276, 15461, 15569, 15575, 15784, 15819, 16058, 16170, 16277, 16326, 16360, 16363, 16378, 16498, 16676, 16785, 16861, 16898, 16920, 16993, 17057, 17090, 17184, 17445, 17482, 17484, 17504, 17586, 17611, 17633, 17673, 17779, 17789, 17813, 17820, 17932, 17935, 17995, 18074, 18089, 18097, 18165, 18194, 18195, 18212, 18346, 18432, 18649, 18830, 18861, 19053, 19119, 19246, 19259, 19313, 19335, 19403, 19435, 19601, 19665, 19870, 19880, 19946, 19960, 19992 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(35, result.number);
            Assert.AreEqual(2591069, result.newNumber);
        }


        [TestMethod]
        public void TestMethod285()
        {
            int[] numbers = new int[] { 49, 287, 441, 713, 916, 938, 947, 1065, 1214, 1229, 1602, 1678, 1806, 1906, 2107, 2191, 2548, 2753, 3055, 3102, 3115, 3176, 3695, 3707, 3803, 3880, 3957, 3961, 4312, 4325, 4469, 4639, 4700, 4763, 4907, 4982, 5058, 5076, 5232, 5315, 5338, 5400, 5406, 5551, 6021, 6087, 6163, 6227, 6322, 6341, 6447, 6450, 7069, 7677, 7726, 7820, 7880, 8178, 8447, 8592, 8816, 8890, 9022, 9217, 9348, 9838, 9926, 10412, 10642, 10760, 10774, 11002, 11979, 12490, 12776, 13312, 13341, 13519, 14042, 14203, 14266, 14435, 14886, 14938, 15121, 15341, 15388, 15403, 15676, 15802, 15985, 16000, 16540, 16574, 16723, 16738, 17304, 17468, 17530, 17623, 17634, 17949, 17971, 18132, 18143, 18162, 18176, 18343, 18563, 18678, 18759, 18848, 18913, 19313, 19362, 19372, 19625, 19966, 19986, 19987, 19996 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(49, result.number);
            Assert.AreEqual(1188072, result.newNumber);
        }


        [TestMethod]
        public void TestMethod286()
        {
            int[] numbers = new int[] { 152, 239, 240, 296, 426, 440, 640, 750, 781, 870, 918, 1019, 1175, 1208, 1392, 1392, 1476, 1539, 1809, 1887, 2047, 2144, 2177, 2291, 2303, 2466, 2575, 2636, 2734, 2865, 2878, 3094, 3104, 3121, 3129, 3130, 3193, 3224, 3269, 3300, 3324, 3332, 3389, 3535, 3550, 3753, 3869, 3871, 3884, 4001, 4034, 4160, 4166, 4439, 4630, 4764, 4783, 4870, 4939, 5296, 5341, 5364, 5559, 5659, 5678, 5781, 5799, 5806, 5864, 5927, 5958, 6168, 6191, 6234, 6641, 6703, 6729, 6773, 6835, 6889, 7070, 7092, 7171, 7225, 7329, 7481, 7583, 7605, 7716, 7720, 7729, 7845, 7921, 7926, 8031, 8179, 8323, 8356, 8371, 8472, 8660, 8745, 8767, 8874, 8916, 9336, 9341, 9502, 9546, 9624, 9698, 9753, 9755, 9802, 9805, 9910, 9936, 9938, 10080, 10214, 10217, 10223, 10223, 10292, 10308, 10324, 10345, 10352, 10358, 10432, 10524, 10588, 10589, 10741, 10819, 10830, 11052, 11055, 11137, 11172, 11177, 11184, 11227, 11250, 11294, 11295, 11313, 11398, 11459, 11473, 11562, 11586, 11688, 11688, 11751, 11835, 11896, 11949, 11962, 12072, 12096, 12340, 12369, 12394, 12459, 12463, 12731, 12854, 13068, 13194, 13298, 13474, 13523, 13538, 13597, 13618, 13733, 13742, 13752, 13772, 13808, 13851, 14082, 14181, 14215, 14286, 14626, 14700, 14765, 15014, 15054, 15085, 15200, 15349, 15388, 15434, 15539, 15625, 15678, 15693, 15829, 15883, 15922, 15983, 15985, 15994, 16021, 16140, 16148, 16333, 16388, 16402, 16411, 16501, 16620, 16627, 16670, 16747, 16769, 16855, 16870, 16897, 17074, 17141, 17234, 17283, 17473, 17519, 17686, 17852, 17856, 17870, 17878, 18014, 18224, 18439, 18572, 18588, 18695, 18818, 19011, 19328, 19607, 19660, 19719, 19760, 19898 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(240, result.number);
            Assert.AreEqual(2442929, result.newNumber);
        }


        [TestMethod]
        public void TestMethod287()
        {
            int[] numbers = new int[] { 12, 414, 423, 518, 656, 673, 703, 890, 1154, 1161, 1190, 1383, 1546, 1640, 1839, 1864, 1936, 2034, 2155, 2254, 2355, 2369, 2978, 3076, 3138, 3211, 3318, 3342, 3525, 3528, 3673, 3722, 3766, 3773, 3853, 4060, 4142, 4191, 4283, 4498, 5187, 5363, 5382, 5418, 5432, 5580, 5742, 5767, 5785, 5866, 5931, 6065, 6156, 6160, 6215, 6233, 6262, 6370, 6373, 6418, 6741, 6778, 6921, 7016, 7298, 7606, 7660, 7696, 7717, 7884, 8026, 8058, 8214, 8472, 8638, 8679, 8845, 8896, 8943, 9004, 9034, 9154, 9196, 9228, 9381, 9398, 9565, 9597, 9608, 9661, 9665, 9734, 9767, 9814, 9925, 9989, 10083, 10193, 10208, 10322, 10402, 10421, 10426, 10750, 10840, 11022, 11048, 11102, 11362, 11775, 11827, 11849, 11849, 11861, 11872, 11902, 11914, 11950, 12167, 12365, 12430, 12434, 12476, 12538, 12915, 13003, 13154, 13178, 13321, 13412, 13616, 13752, 13906, 13972, 13976, 14181, 14294, 14545, 14787, 14913, 14928, 15060, 15117, 15127, 15351, 15377, 15586, 15601, 15614, 15627, 15690, 15784, 15868, 16103, 16217, 16230, 16319, 16322, 16555, 16761, 16807, 16833, 16853, 16934, 16996, 17168, 17200, 17209, 17296, 17319, 17647, 17700, 17757, 17792, 18018, 18045, 18051, 18058, 18095, 18320, 18534, 18633, 18649, 18754, 18945, 19150, 19159, 19257, 19369, 19548, 19643, 19854 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(12, result.number);
            Assert.AreEqual(1956410, result.newNumber);
        }


        [TestMethod]
        public void TestMethod288()
        {
            int[] numbers = new int[] { 13, 33, 42, 123, 132, 208, 266, 333, 364, 419, 659, 680, 795, 971, 1104, 1365, 1405, 1485, 1511, 1530, 1632, 1730, 1776, 1819, 1821, 1834, 1882, 1998, 2014, 2026, 2030, 2072, 2123, 2134, 2154, 2444, 2700, 2712, 2828, 2889, 3092, 3137, 3137, 3169, 3255, 3435, 3473, 3553, 3853, 3865, 3962, 3969, 4061, 4198, 4267, 4303, 4327, 4439, 4450, 4627, 4682, 4710, 4727, 4750, 4804, 4889, 4897, 4931, 4951, 5101, 5178, 5218, 5286, 5323, 5587, 5640, 5661, 5667, 5707, 5767, 5879, 5879, 5921, 5955, 6140, 6166, 6267, 6305, 6403, 6583, 6587, 6614, 6707, 6769, 6782, 6854, 6930, 7047, 7138, 7290, 7325, 7412, 7620, 7650, 7679, 7742, 7785, 7818, 7915, 7951, 7953, 7956, 7958, 7976, 8047, 8059, 8106, 8185, 8186, 8260, 8416, 8429, 8511, 8529, 8587, 8614, 8648, 8652, 8694, 8795, 8807, 9012, 9047, 9109, 9146, 9189, 9243, 9301, 9309, 9352, 9414, 9438, 9664, 9709, 9830, 9853, 9876, 9920, 10025, 10095, 10113, 10163, 10201, 10387, 10424, 10444, 10507, 10651, 10824, 10856, 10933, 11032, 11124, 11130, 11141, 11168, 11202, 11305, 11315, 11328, 11349, 11374, 11386, 11529, 11592, 11621, 11727, 11738, 11748, 11808, 11847, 11883, 11913, 11917, 12118, 12138, 12206, 12258, 12307, 12311, 12347, 12520, 12550, 12563, 12609, 12745, 12769, 12790, 12942, 13266, 13283, 13301, 13315, 13437, 13449, 13568, 13729, 13745, 13756, 13805, 13837, 13876, 13877, 13950, 14013, 14047, 14095, 14237, 14302, 14474, 14535, 14539, 14592, 14602, 14662, 14665, 14840, 14912, 15010, 15064, 15167, 15199, 15201, 15204, 15352, 15395, 15406, 15469, 15630, 15741, 15759, 15969, 16092, 16145, 16154, 16176, 16322, 16391, 16465, 16481, 16533, 16569, 16669, 16721, 16789, 16847, 16998, 17213, 17299, 17301, 17308, 17360, 17543, 17786, 17836, 17902, 17970, 18245, 18354, 18463, 18550, 18668, 18722, 18723, 18809, 18830, 18843, 18913, 18941, 18981, 19032, 19041, 19093, 19103, 19115, 19267, 19302, 19336, 19368, 19669 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(123, result.number);
            Assert.AreEqual(2845672, result.newNumber);
        }


        [TestMethod]
        public void TestMethod289()
        {
            int[] numbers = new int[] { 118, 240, 471, 938, 1055, 1256, 1448, 1465, 1615, 2162, 2301, 2330, 2459, 2543, 2546, 2623, 2680, 2990, 3691, 3725, 3955, 4297, 4364, 4525, 4544, 4803, 4838, 5449, 5499, 5533, 5917, 5991, 7021, 7150, 7289, 7707, 7794, 8296, 8412, 8829, 9133, 9144, 9217, 9377, 9414, 9600, 9629, 10023, 11215, 12054, 12110, 12553, 12625, 12666, 12784, 12792, 12830, 12865, 12934, 13159, 13653, 13793, 13857, 14095, 14355, 14655, 15049, 15138, 15194, 15504, 15839, 16561, 16579, 16836, 17434, 17607, 17662, 17841, 17932, 17969, 19127, 19295, 19394, 19493, 19533, 19641, 19685 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(240, result.number);
            Assert.AreEqual(834146, result.newNumber);
        }


        [TestMethod]
        public void TestMethod290()
        {
            int[] numbers = new int[] { 125, 128, 156, 180, 181, 880, 1192, 1269, 1444, 1493, 2149, 2750, 3111, 3251, 3277, 3366, 3456, 3568, 3733, 3839, 4382, 4527, 4649, 4685, 4975, 5073, 5287, 5415, 5657, 5722, 5761, 5828, 5868, 5888, 5934, 5953, 6333, 6384, 6498, 6565, 6597, 6612, 6708, 7024, 7070, 7164, 7369, 7598, 7777, 7785, 7843, 7941, 8010, 8267, 8607, 9050, 9079, 9450, 9521, 9587, 9608, 9945, 10282, 10518, 10862, 10916, 11106, 11281, 11286, 11365, 11515, 11523, 11973, 12000, 12124, 12189, 12218, 12247, 12247, 12478, 12551, 12649, 12773, 12864, 12949, 13039, 13242, 13296, 13407, 13410, 14120, 14133, 14251, 14325, 14356, 14392, 14487, 14546, 14562, 14583, 14681, 14701, 14778, 14800, 14907, 14928, 15264, 15318, 15389, 15424, 15760, 15763, 15934, 16034, 16047, 16128, 16202, 16247, 16423, 16432, 16502, 16678, 16711, 17143, 17260, 17422, 17429, 18086, 18763, 18811, 18883, 19156, 19159, 19269, 19327, 19330, 19397, 19490, 19655, 19668, 19696, 19768, 19771, 19900, 19930 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(181, result.number);
            Assert.AreEqual(1585027, result.newNumber);
        }


        [TestMethod]
        public void TestMethod291()
        {
            int[] numbers = new int[] { 11, 59, 78, 124, 340, 471, 584, 619, 661, 781, 811, 819, 966, 1002, 1047, 1109, 1167, 1182, 1260, 1295, 1313, 1347, 1819, 1937, 1956, 1956, 1963, 2021, 2083, 2090, 2262, 2403, 2496, 2574, 2596, 2668, 2765, 2807, 2829, 2903, 2979, 3100, 3106, 3133, 3194, 3266, 3383, 3392, 3405, 3428, 3473, 3490, 3575, 3581, 3635, 3670, 3686, 3774, 3797, 3944, 4049, 4088, 4288, 4365, 4525, 4534, 4981, 5052, 5148, 5196, 5210, 5338, 5365, 5399, 5409, 5412, 5642, 5667, 5681, 5752, 5821, 5963, 5986, 6003, 6036, 6161, 6166, 6206, 6260, 6399, 6531, 6557, 6637, 6698, 6764, 6774, 6818, 6825, 6829, 6905, 6936, 6971, 6988, 7100, 7263, 7355, 7596, 7629, 7717, 7768, 7825, 7876, 8048, 8114, 8157, 8195, 8217, 8246, 8353, 8478, 8525, 8664, 9064, 9331, 9441, 9478, 9524, 9573, 9858, 9861, 9981, 10036, 10087, 10154, 10157, 10187, 10328, 10333, 10473, 10498, 10517, 10621, 10622, 10678, 10824, 11047, 11178, 11210, 11285, 11303, 11365, 11443, 11460, 11489, 11494, 11525, 11749, 11788, 11808, 11965, 12074, 12076, 12122, 12258, 12283, 12289, 12430, 12443, 12593, 12603, 12691, 12694, 12704, 12711, 12837, 12885, 12902, 12916, 13088, 13104, 13106, 13197, 13303, 13333, 13349, 13426, 13427, 13556, 13566, 13570, 13592, 13629, 13882, 13921, 13974, 14033, 14082, 14374, 14379, 14407, 14421, 14495, 14643, 14649, 14868, 15000, 15083, 15191, 15295, 15382, 15485, 15503, 15537, 15575, 15650, 15743, 15789, 15817, 15841, 15853, 15879, 15924, 16030, 16125, 16243, 16260, 16282, 16372, 16435, 16440, 16503, 16584, 16617, 16619, 16629, 16663, 16670, 16728, 16733, 16752, 16835, 16905, 16954, 17082, 17181, 17206, 17208, 17328, 17458, 17522, 17590, 17660, 17752, 17797, 17869, 17874, 17876, 17877, 17938, 18035, 18127, 18145, 18158, 18348, 18350, 18360, 18371, 18436, 18465, 18484, 18521, 18685, 18751, 18815, 18856, 18885, 19003, 19033, 19046, 19170, 19312, 19349, 19377, 19412, 19447, 19450, 19535, 19587, 19592, 19642, 19664, 19671, 19688, 19731, 19785, 19861, 19923, 19982 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(78, result.number);
            Assert.AreEqual(3166667, result.newNumber);
        }


        [TestMethod]
        public void TestMethod292()
        {
            int[] numbers = new int[] { 363, 418, 512, 1218, 1251, 1254, 2079, 2241, 2341, 2678, 2704, 2727, 2744, 3368, 3491, 3780, 3960, 4169, 4249, 4252, 4371, 4587, 4664, 5124, 5374, 6122, 6179, 6489, 6502, 7013, 7044, 7320, 7702, 8013, 8176, 8209, 8461, 8501, 8515, 8596, 8757, 8883, 8914, 9029, 9048, 9392, 9888, 9893, 10003, 10267, 10425, 10646, 11494, 11661, 11688, 11703, 11761, 13008, 13102, 13697, 13766, 13782, 13900, 14141, 14203, 14228, 14455, 14502, 14678, 14987, 15088, 15107, 15120, 15129, 15431, 15672, 15806, 16271, 16310, 16872, 16879, 16971, 17188, 17327, 17931, 18093, 18772, 18802, 19023, 19504, 19980 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(363, result.number);
            Assert.AreEqual(891389, result.newNumber);
        }


        [TestMethod]
        public void TestMethod293()
        {
            int[] numbers = new int[] { 39, 325, 642, 820, 848, 858, 987, 1091, 1166, 1338, 1368, 1440, 1523, 1734, 1750, 1834, 1969, 1989, 2046, 2152, 2249, 2301, 2361, 2422, 2437, 2564, 2596, 2602, 2665, 2857, 2954, 2957, 2960, 2969, 3103, 3115, 3200, 3285, 3350, 3391, 3429, 3478, 3667, 3674, 3683, 3958, 4069, 4072, 4079, 4086, 4098, 4163, 4202, 4279, 4312, 4366, 4381, 4504, 4548, 4591, 4625, 4659, 4687, 4704, 4797, 4799, 4848, 4954, 5138, 5226, 5273, 5340, 5397, 5501, 5596, 5613, 5779, 5872, 6155, 6295, 6331, 6431, 6466, 6512, 6513, 6520, 6590, 6630, 6994, 7030, 7049, 7149, 7254, 7410, 7414, 7480, 7498, 7505, 7515, 7623, 7627, 8018, 8031, 8121, 8225, 8356, 8365, 8420, 8482, 8660, 8710, 8877, 8917, 9300, 9349, 9471, 9547, 9582, 9595, 9607, 9616, 9875, 10079, 10207, 10250, 10343, 10422, 10713, 10769, 10899, 11450, 11499, 11577, 11764, 11856, 11860, 11948, 11976, 12074, 12212, 12361, 12469, 12768, 12789, 12808, 12842, 12889, 13189, 13239, 13246, 13248, 13336, 13389, 13406, 13527, 13716, 13728, 13822, 13878, 13923, 14151, 14477, 14537, 14617, 14653, 14655, 14686, 14769, 14823, 14855, 14882, 14927, 14990, 15013, 15030, 15130, 15291, 15432, 15487, 15487, 15522, 15621, 15683, 15696, 15863, 15877, 15877, 16160, 16185, 16335, 16559, 16673, 16813, 16934, 17036, 17094, 17200, 17344, 17468, 17576, 17677, 17677, 17718, 17744, 17859, 18010, 18097, 18106, 18124, 18137, 18256, 18301, 18374, 18436, 18548, 18602, 18661, 18731, 18831, 18845, 18882, 18935, 18980, 19127, 19327, 19454, 19475, 19592, 19605, 19681, 19707, 19766, 19786, 19794, 19804, 19926, 19993 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(39, result.number);
            Assert.AreEqual(2389969, result.newNumber);
        }


        [TestMethod]
        public void TestMethod294()
        {
            int[] numbers = new int[] { 107, 195, 458, 778, 875, 966, 967, 1088, 1313, 1411, 1625, 1884, 1885, 2255, 2351, 2536, 2939, 3076, 3107, 3130, 3147, 3475, 3572, 3582, 3616, 3895, 4202, 4267, 4315, 4732, 4737, 5295, 5412, 5903, 6130, 6268, 6296, 6296, 6325, 6340, 6402, 6703, 6991, 7160, 7234, 7357, 7433, 7449, 7551, 7581, 7660, 7789, 7808, 7831, 8027, 8087, 8160, 8253, 8425, 8687, 8745, 8813, 8951, 9027, 9052, 9426, 9464, 9497, 9653, 9779, 9780, 9834, 10172, 10175, 10220, 10236, 10355, 10643, 10663, 10730, 11002, 11094, 11141, 11167, 11381, 11657, 11731, 11866, 12544, 12567, 12758, 12886, 13016, 13143, 13217, 13797, 13834, 13859, 13977, 14094, 14152, 14438, 14641, 14814, 14996, 15286, 15329, 15489, 15490, 15533, 15552, 15627, 15657, 16043, 16113, 16370, 16373, 16406, 16456, 16540, 16545, 16569, 16617, 16772, 16904, 17103, 17235, 17423, 17568, 17576, 17626, 17804, 18072, 18207, 18345, 18353, 18367, 18392, 18405, 18450, 18736, 18863, 18964, 19189, 19432, 19449, 19513, 19520, 19629, 19692, 19937, 19943 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(107, result.number);
            Assert.AreEqual(1621029, result.newNumber);
        }


        [TestMethod]
        public void TestMethod295()
        {
            int[] numbers = new int[] { 103, 166, 191, 194, 286, 293, 310, 352, 430, 464, 527, 571, 837, 947, 1052, 1190, 1203, 1370, 1632, 1708, 1720, 1820, 1821, 1826, 1842, 1946, 2014, 2032, 2034, 2150, 2254, 2342, 2365, 2429, 2598, 2692, 2704, 2927, 3182, 3278, 3319, 3406, 3421, 3431, 3515, 3562, 3623, 3679, 3680, 3809, 3939, 3979, 3979, 4031, 4052, 4103, 4114, 4122, 4138, 4148, 4179, 4207, 4312, 4342, 4370, 4562, 4624, 4723, 5036, 5165, 5185, 5193, 5400, 5430, 5890, 5942, 5972, 6029, 6307, 6343, 6364, 6382, 6382, 6396, 6419, 6425, 6431, 6521, 6603, 6620, 6639, 6754, 6806, 6856, 6857, 6909, 7065, 7118, 7143, 7324, 7329, 7464, 7500, 7522, 7582, 7637, 7753, 7777, 7825, 7832, 7870, 7899, 8050, 8179, 8253, 8302, 8415, 8493, 8517, 8551, 8561, 8857, 8886, 9011, 9207, 9220, 9235, 9358, 9498, 9523, 9679, 9743, 9782, 9804, 9819, 10019, 10181, 10200, 10247, 10269, 10350, 10391, 10428, 10432, 10465, 10537, 10611, 10660, 10747, 10906, 10944, 10946, 11198, 11230, 11232, 11582, 11598, 11617, 11623, 11660, 11670, 11691, 11713, 11743, 11774, 11816, 11919, 11953, 11974, 12004, 12110, 12247, 12305, 12396, 12401, 12403, 12576, 12613, 12722, 12741, 12813, 12994, 12999, 13019, 13148, 13179, 13203, 13249, 13390, 13452, 13529, 13563, 13569, 13685, 13690, 13701, 13727, 13812, 13832, 13909, 13942, 14147, 14242, 14327, 14372, 14435, 14441, 14442, 14511, 14568, 14571, 14574, 14635, 14650, 14687, 14711, 14742, 14753, 14834, 14860, 14924, 15016, 15046, 15100, 15145, 15164, 15353, 15465, 15469, 15502, 15513, 15568, 15613, 15671, 15727, 15809, 15993, 16030, 16054, 16147, 16167, 16228, 16244, 16336, 16345, 16420, 16497, 16516, 16651, 16679, 16710, 16980, 17023, 17250, 17282, 17418, 17434, 17679, 17745, 17760, 17765, 17863, 18005, 18041, 18083, 18252, 18263, 18374, 18386, 18470, 18491, 18541, 18556, 18643, 18712, 18825, 18947, 19196, 19201, 19307, 19649, 19785 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(166, result.number);
            Assert.AreEqual(2799305, result.newNumber);
        }


        [TestMethod]
        public void TestMethod296()
        {
            int[] numbers = new int[] { 77, 313, 440, 566, 591, 694, 752, 993, 1260, 1266, 1377, 1442, 1451, 1611, 1669, 1745, 2317, 2788, 2906, 3130, 3151, 3310, 3342, 3731, 3848, 3956, 4111, 4147, 4422, 4491, 5080, 5138, 5173, 5357, 5416, 5519, 5628, 5999, 6257, 6312, 6419, 6465, 6639, 6770, 6956, 7250, 7525, 7935, 8090, 8091, 8123, 8315, 8377, 8401, 8557, 8610, 8697, 9129, 9129, 9185, 9427, 9475, 9536, 9841, 10007, 10222, 10384, 10388, 10592, 10810, 10858, 10992, 11059, 11215, 11556, 11728, 11786, 12002, 12079, 12093, 12351, 12377, 12481, 12501, 12525, 12577, 12762, 12770, 12960, 12981, 13058, 13175, 13536, 13698, 13725, 13750, 13780, 13867, 13894, 14301, 14354, 14554, 14617, 14686, 14962, 15041, 15170, 15949, 16005, 16018, 16026, 16373, 16516, 16603, 16635, 16849, 16957, 17070, 17278, 17279, 17325, 17478, 17762, 17791, 17948, 17983, 18145, 18222, 18326, 18464, 18603, 18829, 19134, 19333, 19428, 19617, 19810, 19814 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(77, result.number);
            Assert.AreEqual(1408447, result.newNumber);
        }


        [TestMethod]
        public void TestMethod297()
        {
            int[] numbers = new int[] { 27, 232, 292, 443, 578, 628, 702, 778, 791, 824, 883, 1137, 1138, 1222, 1432, 1439, 1443, 1563, 1608, 1648, 1692, 1730, 1769, 1855, 2019, 2056, 2104, 2161, 2162, 2228, 2273, 2327, 2333, 2363, 2420, 2431, 2472, 2595, 2889, 3160, 3194, 3514, 3533, 3606, 3650, 3734, 3837, 3869, 3913, 3985, 4074, 4089, 4389, 4416, 4447, 4451, 4502, 4651, 4708, 4742, 5045, 5082, 5293, 5376, 5379, 5592, 5806, 5882, 5914, 5985, 6119, 6164, 6292, 6358, 6420, 6422, 6625, 6714, 6758, 6946, 6965, 7027, 7260, 7496, 7539, 7960, 8013, 8169, 8348, 8357, 8365, 8384, 8385, 8394, 8470, 8745, 8883, 8898, 9105, 9188, 9406, 9572, 9592, 9612, 9840, 9943, 9955, 9972, 10251, 10276, 10351, 10413, 10414, 10421, 10607, 10623, 10690, 10762, 10773, 10784, 10994, 11022, 11043, 11127, 11174, 11209, 11245, 11250, 11477, 11641, 11732, 11740, 11782, 11875, 11918, 11976, 12033, 12036, 12057, 12104, 12156, 12170, 12567, 12590, 12753, 12910, 12954, 13022, 13036, 13122, 13209, 13423, 13458, 13510, 13686, 13885, 13907, 13914, 13924, 14056, 14315, 14343, 14463, 14548, 14599, 14609, 14758, 14935, 14962, 15119, 15175, 15208, 15220, 15240, 15247, 15435, 15628, 15771, 15812, 15822, 15868, 15884, 15929, 16021, 16064, 16114, 16506, 16528, 16576, 16652, 16769, 16848, 16929, 16956, 17016, 17127, 17130, 17208, 17302, 17332, 17336, 17349, 17352, 17391, 17535, 17594, 17747, 17783, 17832, 17875, 17901, 17902, 17949, 17998, 18183, 18290, 18336, 18660, 18750, 18935, 19113, 19260, 19285, 19515, 19534, 19543, 19565, 19584, 19595, 19793, 19891, 19938 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(27, result.number);
            Assert.AreEqual(2353712, result.newNumber);
        }


        [TestMethod]
        public void TestMethod298()
        {
            int[] numbers = new int[] { 289, 816, 1333, 1656, 1790, 2127, 2525, 2786, 3204, 3301, 3767, 4038, 4298, 4433, 4688, 4981, 5335, 5422, 5626, 5887, 6108, 6160, 6190, 7258, 7508, 8538, 8639, 8779, 8824, 8865, 9009, 9164, 9509, 9667, 9808, 10011, 10227, 10255, 10530, 10606, 10695, 11034, 11516, 11587, 11940, 12082, 12320, 12459, 12713, 12977, 13534, 13790, 13993, 14334, 14783, 14929, 15331, 15499, 15580, 15712, 15823, 16005, 16016, 16688, 16728, 17124, 17770, 17918, 18135, 18272, 18291, 18881, 18886, 19033, 19179, 19248, 19475, 19504, 19713 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(816, result.number);
            Assert.AreEqual(840066, result.newNumber);
        }


        [TestMethod]
        public void TestMethod299()
        {
            int[] numbers = new int[] { 99, 151, 277, 315, 430, 470, 492, 651, 784, 784, 795, 814, 893, 977, 1042, 1050, 1143, 1186, 1315, 1344, 1416, 1438, 1548, 1620, 1764, 1850, 1863, 1881, 2138, 2159, 2307, 2350, 2362, 2388, 2560, 2720, 2808, 2810, 2836, 3101, 3153, 3246, 3250, 3270, 3279, 3304, 3647, 3669, 3680, 3701, 3770, 3842, 3862, 3983, 4225, 4490, 4553, 4796, 4983, 5084, 5160, 5274, 5285, 5549, 5732, 5913, 5944, 6133, 6287, 6499, 6509, 7060, 7245, 7328, 7446, 7478, 7492, 7512, 7533, 7703, 7746, 8093, 8175, 8221, 8384, 8440, 8517, 8630, 8647, 8714, 8824, 8845, 9218, 9235, 9277, 9439, 9491, 9530, 9862, 10060, 10065, 10216, 10270, 10301, 10651, 10711, 10884, 11180, 11350, 11362, 11445, 11537, 11582, 11606, 11855, 12052, 12169, 12250, 12631, 12663, 12688, 12825, 12923, 12937, 13035, 13080, 13271, 13508, 13615, 13656, 14378, 14426, 14446, 14550, 14815, 14823, 14862, 15206, 15276, 15524, 15573, 15761, 15767, 16036, 16147, 16205, 16259, 16390, 16410, 16857, 16994, 17279, 17377, 17456, 17491, 17538, 17805, 17814, 17823, 17868, 17879, 17962, 18508, 18512, 18549, 18598, 18645, 18854, 18982, 19223, 19632, 19735, 19764 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(151, result.number);
            Assert.AreEqual(1531312, result.newNumber);
        }


        [TestMethod]
        public void TestMethod300()
        {
            int[] numbers = new int[] { 94, 958, 1305, 2136, 2435, 2700, 2765, 4299, 4546, 5108, 6558, 7025, 9661, 9909, 10470, 11519, 12568, 12896, 13587, 16139, 16534, 18000, 18212, 19249 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1305, result.number);
            Assert.AreEqual(183576, result.newNumber);
        }


        [TestMethod]
        public void TestMethod301()
        {
            int[] numbers = new int[] { 80, 229, 239, 241, 296, 308, 399, 464, 503, 527, 539, 554, 606, 1005, 1072, 1186, 1198, 1238, 1244, 1245, 1248, 1258, 1279, 1326, 1374, 1549, 1587, 1591, 1905, 1907, 1961, 1989, 2042, 2075, 2160, 2305, 2527, 2568, 2570, 2621, 2622, 2805, 2862, 2903, 3104, 3184, 3233, 3370, 3421, 3502, 3655, 3658, 3686, 3719, 3856, 3955, 3960, 4044, 4157, 4495, 4690, 4729, 4746, 4967, 5141, 5153, 5307, 5326, 5334, 5393, 5472, 5473, 5665, 5776, 6130, 6135, 6228, 6352, 6354, 6358, 6417, 6592, 6632, 6681, 6737, 6832, 6882, 6961, 6972, 7016, 7116, 7262, 7355, 7384, 7530, 7550, 7630, 7791, 7808, 7832, 7890, 7908, 7996, 8055, 8132, 8147, 8203, 8247, 8386, 8398, 8447, 8455, 8507, 8548, 8729, 8774, 8835, 8869, 9164, 9176, 9208, 9211, 9416, 9476, 9497, 9531, 9574, 9661, 9681, 9691, 9854, 9870, 9965, 10123, 10154, 10293, 10423, 10456, 10675, 10690, 10753, 10762, 10773, 10916, 10990, 11046, 11232, 11300, 11302, 11365, 11382, 11594, 11620, 11636, 11670, 11758, 11781, 11781, 11786, 11957, 12036, 12049, 12257, 12343, 12402, 12447, 12543, 12748, 12758, 12862, 13023, 13031, 13101, 13184, 13439, 13629, 13660, 13736, 13742, 13956, 14016, 14094, 14111, 14113, 14165, 14221, 14242, 14291, 14424, 14463, 14539, 14560, 14606, 14682, 14954, 15106, 15143, 15236, 15414, 15466, 15536, 15592, 15631, 15642, 15646, 15685, 15810, 15813, 15864, 15951, 16180, 16222, 16243, 16324, 16471, 16474, 16635, 16641, 16772, 16807, 16814, 16839, 16864, 16910, 16954, 17161, 17250, 17274, 17287, 17302, 17343, 17391, 17416, 17423, 17429, 17517, 17583, 17652, 17687, 17781, 18070, 18322, 18334, 18388, 18390, 18503, 18565, 18598, 18757, 18858, 18878, 18914, 18946, 19043, 19126, 19151, 19191, 19236, 19311, 19384, 19587, 19621, 19699, 19719, 19838 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(229, result.number);
            Assert.AreEqual(2659919, result.newNumber);
        }


        [TestMethod]
        public void TestMethod302()
        {
            int[] numbers = new int[] { 14, 56, 148, 207, 250, 302, 343, 370, 592, 730, 825, 878, 894, 1117, 1328, 1333, 1351, 1404, 1467, 1751, 2169, 2289, 2315, 2421, 2619, 2670, 2682, 2757, 2830, 2926, 2938, 2983, 3066, 3102, 3132, 3142, 3166, 3263, 3271, 3404, 3451, 3712, 3750, 3750, 3844, 3916, 3976, 4053, 4140, 4140, 4249, 4257, 4390, 4393, 4444, 4507, 4854, 5020, 5107, 5148, 5181, 5375, 5522, 5552, 5751, 5774, 5784, 5833, 6076, 6116, 6120, 6271, 6320, 6388, 6474, 6566, 6646, 6666, 6695, 7192, 7247, 7267, 7372, 7429, 7531, 7545, 7763, 7884, 7977, 8190, 8233, 8667, 8776, 8830, 8846, 8936, 9133, 9173, 9229, 9379, 9598, 9624, 9651, 9750, 9915, 10088, 10223, 10401, 10664, 10894, 11074, 11101, 11196, 11388, 11426, 11507, 11604, 11670, 11696, 11780, 11816, 11864, 11948, 11997, 12124, 12191, 12195, 12232, 12298, 12374, 12416, 12422, 12456, 12662, 12742, 12816, 12882, 13021, 13278, 13288, 13289, 13503, 13696, 13716, 13772, 14028, 14065, 14067, 14192, 14219, 14263, 14305, 14319, 14404, 14541, 14590, 14645, 14802, 14813, 14910, 14989, 15028, 15056, 15292, 15322, 15343, 15557, 15582, 15606, 15671, 15709, 15854, 15862, 15973, 16112, 16223, 16244, 16249, 16285, 16373, 16375, 16476, 16558, 16565, 16577, 16580, 16603, 16623, 16842, 16918, 17211, 17252, 17459, 17462, 17580, 17748, 17759, 17953, 18038, 18082, 18250, 18372, 18393, 18443, 18475, 18536, 18642, 18727, 18840, 18944, 19100, 19143, 19216, 19231, 19307, 19315, 19366, 19421, 19452, 19630, 19654, 19764, 19787, 19888 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(302, result.number);
            Assert.AreEqual(2307077, result.newNumber);
        }


        [TestMethod]
        public void TestMethod303()
        {
            int[] numbers = new int[] { 245, 382, 640, 729, 781, 997, 1135, 1206, 1242, 1466, 1587, 1657, 1829, 2034, 2287, 2362, 2400, 2466, 2484, 2766, 2787, 2812, 3004, 3136, 3249, 3275, 3406, 3434, 3933, 4145, 4260, 4490, 4552, 4745, 4785, 4953, 4960, 5069, 5203, 5283, 5320, 5479, 5490, 5612, 5758, 5761, 6138, 6579, 7329, 7399, 7448, 7647, 7678, 7766, 7774, 8045, 8059, 8199, 8215, 8474, 8486, 8648, 8654, 8674, 8923, 9044, 9183, 9232, 9352, 9525, 9588, 9722, 9724, 9729, 9770, 9848, 10166, 10399, 10718, 10818, 10838, 10904, 11004, 11090, 11427, 11460, 11852, 12508, 12593, 12632, 12797, 12970, 13036, 13103, 13333, 13542, 13680, 13759, 13779, 14136, 14226, 14243, 14321, 14325, 14327, 14656, 14672, 14800, 15067, 15144, 15337, 15397, 15436, 15607, 15666, 15673, 16526, 16582, 16708, 17330, 17370, 17504, 17600, 17652, 17791, 17836, 17874, 18190, 18223, 18301, 18614, 18654, 18884, 18916, 18987, 19107, 19129, 19198, 19478, 19558, 19561, 19671, 19723, 19724, 19763, 19794, 19916 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(245, result.number);
            Assert.AreEqual(1500827, result.newNumber);
        }


        [TestMethod]
        public void TestMethod304()
        {
            int[] numbers = new int[] { 189, 677, 801, 862, 1180, 1182, 1338, 1434, 1706, 1942, 2059, 2544, 2615, 2997, 3152, 3746, 4139, 4268, 4832, 4907, 5218, 5603, 6042, 6215, 6568, 6631, 6718, 6756, 6764, 6858, 7010, 7367, 7447, 8064, 8160, 8184, 8354, 8455, 8613, 8830, 8851, 9034, 9370, 9565, 9875, 9914, 9973, 10109, 10161, 10247, 10317, 10426, 10692, 10730, 11052, 11161, 11161, 11441, 11575, 11679, 12100, 12697, 12867, 13072, 13227, 13273, 13334, 13577, 13667, 13907, 14014, 14158, 14249, 14374, 14610, 14738, 14892, 15127, 15512, 15556, 15602, 15720, 15757, 15783, 15883, 15980, 16068, 16243, 16250, 16359, 16638, 16669, 16671, 16849, 16983, 17105, 17153, 17266, 17357, 17415, 18067, 18106, 18398, 18537, 18794, 18872, 18941, 18944, 19016, 19061, 19253, 19299, 19404, 19547, 19928, 19993 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(189, result.number);
            Assert.AreEqual(1303045, result.newNumber);
        }


        [TestMethod]
        public void TestMethod305()
        {
            int[] numbers = new int[] { 594, 869, 1353, 1407, 1746, 2002, 2004, 2159, 2435, 2641, 2720, 2745, 2877, 2968, 3069, 3233, 3943, 4221, 4392, 5868, 5932, 6575, 6819, 6822, 6941, 7419, 7650, 8051, 8697, 8805, 8831, 9342, 9515, 9966, 9979, 9982, 10260, 10558, 10788, 10860, 11291, 11381, 11820, 11854, 11856, 12176, 12353, 12427, 12659, 12830, 13022, 14360, 14402, 14431, 14927, 15071, 15095, 16340, 16393, 16499, 16695, 16717, 16957, 17684, 17708, 17991, 18972, 19212, 19220, 19363, 19480 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(594, result.number);
            Assert.AreEqual(686565, result.newNumber);
        }


        [TestMethod]
        public void TestMethod306()
        {
            int[] numbers = new int[] { 78, 94, 110, 513, 673, 702, 795, 831, 1202, 1210, 1285, 1495, 1591, 1669, 1778, 1799, 1848, 1881, 1921, 2214, 2330, 2533, 2674, 2901, 3129, 3240, 3421, 3441, 3650, 3720, 3741, 3825, 3826, 3934, 3993, 4141, 4285, 4416, 4757, 4864, 4918, 4958, 5168, 5289, 5303, 5332, 5490, 5659, 5821, 5835, 5863, 5971, 5997, 6071, 6374, 6374, 6456, 6517, 6563, 6985, 7088, 7095, 7189, 7190, 7287, 7548, 7567, 7672, 7767, 7792, 7848, 7857, 8235, 8239, 8239, 8276, 8344, 8384, 8788, 8897, 8961, 9057, 9093, 9134, 9154, 9286, 9369, 9501, 9561, 10064, 10074, 10198, 10449, 10457, 10465, 10610, 10773, 10891, 11097, 11548, 11559, 11587, 11605, 11939, 11947, 12056, 12282, 12288, 12310, 12379, 12401, 12821, 12827, 13083, 13194, 13280, 13357, 13358, 13361, 13378, 13433, 13618, 13733, 13978, 14081, 14232, 14264, 14268, 14415, 14468, 14481, 14605, 14669, 14693, 14768, 14814, 15427, 15464, 15528, 15562, 15729, 15756, 15772, 15881, 15882, 16033, 16111, 16149, 16374, 16445, 16509, 16637, 16981, 17091, 17109, 17135, 17251, 17441, 17544, 17606, 17721, 17819, 17935, 17951, 17969, 18219, 18244, 18424, 18518, 18571, 18576, 18699, 18848, 18926, 19277, 19310, 19313, 19348, 19423, 19461, 19537, 19591, 19679, 19760, 19799, 19847, 19855 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(78, result.number);
            Assert.AreEqual(1950653, result.newNumber);
        }


        [TestMethod]
        public void TestMethod307()
        {
            int[] numbers = new int[] { 253, 337, 733, 973, 1116, 1307, 1413, 1478, 1571, 2006, 2051, 2152, 2365, 2556, 2648, 2769, 2891, 2918, 3167, 3171, 3548, 3693, 3815, 4569, 5205, 5239, 5276, 5692, 5889, 6164, 6180, 6204, 6254, 6631, 6914, 6939, 7446, 7579, 8263, 8610, 9260, 9647, 10071, 10441, 10470, 10548, 10992, 11479, 11499, 11580, 11854, 12232, 12295, 12651, 13065, 13356, 13363, 14248, 14270, 15321, 15701, 15925, 16151, 16194, 16281, 16453, 16674, 16718, 16826, 16866, 16911, 17202, 17383, 17932, 18286, 18329, 18869, 19107, 19171, 19315 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(253, result.number);
            Assert.AreEqual(735541, result.newNumber);
        }


        [TestMethod]
        public void TestMethod308()
        {
            int[] numbers = new int[] { 35, 157, 344, 374, 429, 574, 806, 982, 1356, 1633, 1766, 1962, 1968, 2106, 2163, 2179, 2306, 2322, 2357, 2404, 2571, 2879, 3098, 3121, 3318, 3484, 3984, 4006, 4079, 4095, 4103, 4234, 4446, 4480, 4632, 4653, 4790, 4819, 5121, 5132, 5166, 5556, 5930, 6250, 6379, 6431, 6643, 6759, 6867, 6878, 7111, 7113, 7204, 7216, 7268, 7334, 7412, 7862, 8174, 8372, 8557, 8713, 8846, 8974, 9032, 9078, 9084, 9162, 9888, 10064, 10335, 10638, 10693, 10693, 11180, 11290, 11295, 11491, 11513, 11657, 11875, 11891, 11924, 12010, 12184, 12419, 12530, 12779, 12830, 13035, 13464, 13475, 13524, 13898, 13910, 14188, 14486, 14771, 14931, 15101, 15211, 15501, 15676, 15712, 15760, 15795, 15972, 16027, 16036, 16190, 16221, 16249, 16306, 16367, 16522, 17156, 17284, 17389, 17558, 17603, 17649, 17663, 17683, 17718, 17794, 17927, 18007, 18058, 18162, 18179, 18234, 18236, 18254, 18611, 18876, 18877, 19050, 19164, 19209, 19250, 19250, 19499, 19525, 19532, 19660, 19665, 19767, 19827, 19895 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(35, result.number);
            Assert.AreEqual(1580328, result.newNumber);
        }


        [TestMethod]
        public void TestMethod309()
        {
            int[] numbers = new int[] { 24, 105, 162, 225, 282, 306, 486, 510, 558, 569, 608, 818, 825, 843, 925, 974, 998, 1029, 1078, 1100, 1146, 1230, 1284, 1321, 1367, 1425, 1425, 1522, 1550, 1559, 1884, 1885, 1889, 1894, 1934, 2073, 2109, 2170, 2223, 2277, 2284, 2326, 2480, 2483, 2539, 2548, 2582, 2679, 2700, 2770, 2781, 2786, 2790, 2828, 2943, 2999, 3151, 3214, 3433, 3452, 3523, 3577, 3744, 3768, 3816, 3820, 3925, 3981, 4026, 4027, 4140, 4180, 4262, 4291, 4348, 4362, 4364, 4501, 4690, 4713, 4745, 4776, 4800, 4806, 4925, 4973, 5008, 5068, 5080, 5208, 5208, 5241, 5285, 5423, 5466, 5537, 5564, 5605, 5664, 5803, 6024, 6035, 6039, 6051, 6122, 6232, 6356, 6517, 6564, 6633, 6690, 6892, 6912, 7073, 7076, 7219, 7402, 7406, 7573, 7777, 7808, 7878, 7905, 8209, 8292, 8305, 8322, 8336, 8399, 8495, 8506, 8567, 8582, 8705, 8707, 8714, 8787, 8819, 9003, 9063, 9144, 9191, 9265, 9274, 9335, 9382, 9425, 9441, 9644, 9778, 9789, 9832, 9926, 9933, 10007, 10036, 10080, 10115, 10168, 10179, 10189, 10262, 10326, 10361, 10395, 10633, 10668, 10743, 10750, 10829, 10937, 10947, 11027, 11106, 11210, 11363, 11393, 11542, 11689, 11708, 11951, 12015, 12035, 12219, 12269, 12310, 12326, 12362, 12372, 12521, 12531, 12533, 12576, 12601, 12657, 12680, 12928, 12980, 13084, 13112, 13502, 13588, 13590, 13789, 13848, 13900, 13965, 14144, 14153, 14345, 14356, 14433, 14467, 14476, 14536, 14545, 14673, 14691, 14925, 14962, 14999, 15039, 15248, 15317, 15342, 15390, 15656, 15668, 15722, 15734, 15759, 15785, 15818, 15823, 15923, 16030, 16042, 16197, 16213, 16316, 16383, 16390, 16483, 16483, 16501, 16531, 16600, 16618, 16668, 16778, 16780, 16814, 16957, 17008, 17241, 17286, 17348, 17399, 17399, 17477, 17728, 17788, 17938, 17951, 18145, 18184, 18191, 18493, 18498, 18799, 18996, 19075, 19085, 19205, 19214, 19255, 19281, 19301, 19307, 19348, 19472, 19550, 19606, 19648, 19846, 19917 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(24, result.number);
            Assert.AreEqual(2680650, result.newNumber);
        }


        [TestMethod]
        public void TestMethod310()
        {
            int[] numbers = new int[] { 222, 355, 718, 1658, 1752, 1874, 2220, 2349, 2351, 2933, 2943, 3423, 3683, 4143, 4911, 4976, 4980, 5042, 5198, 5282, 5434, 5573, 5865, 6231, 6403, 6679, 6771, 6797, 7268, 7731, 7750, 8138, 8207, 8353, 8414, 8641, 9034, 9156, 9799, 10736, 10760, 10913, 10946, 10980, 11272, 11412, 12425, 13308, 13459, 14025, 14158, 14280, 14358, 14409, 14680, 14959, 14965, 15076, 15665, 15766, 15868, 16359, 16479, 16769, 16998, 17084, 17406, 18015, 18016, 18147, 18576, 18579, 18681, 19345 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(222, result.number);
            Assert.AreEqual(716908, result.newNumber);
        }


        [TestMethod]
        public void TestMethod311()
        {
            int[] numbers = new int[] { 315, 363, 429, 723, 1097, 1295, 1672, 1939, 2159, 2203, 2208, 2981, 3061, 3106, 3317, 3682, 3829, 3887, 4314, 4334, 4464, 4704, 4840, 4923, 5214, 5524, 5754, 5937, 5975, 6523, 6539, 6663, 6748, 6797, 6837, 7385, 7482, 7730, 7913, 7950, 8998, 8998, 9064, 9101, 9105, 9189, 9408, 9441, 9908, 9917, 9932, 10286, 10495, 10840, 10859, 10955, 11475, 11555, 11725, 11871, 11949, 12115, 13304, 13458, 13821, 13853, 13908, 13996, 13999, 14721, 14747, 14840, 14882, 15068, 15129, 15365, 15589, 15932, 16335, 16603, 17067, 17794, 17852, 18014, 18541, 18697, 18771, 19061, 19308, 19390, 19827 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(723, result.number);
            Assert.AreEqual(861933, result.newNumber);
        }


        [TestMethod]
        public void TestMethod312()
        {
            int[] numbers = new int[] { 88, 140, 162, 220, 237, 285, 502, 559, 690, 698, 961, 1010, 1014, 1363, 1426, 1470, 1614, 1631, 1633, 1908, 2089, 2451, 2526, 2628, 2637, 2693, 2776, 2885, 3031, 3041, 3102, 3115, 3143, 3284, 3308, 3343, 3410, 3469, 3711, 3997, 4398, 4421, 4432, 4544, 4579, 4688, 4749, 4757, 4836, 5084, 5088, 5105, 5347, 5451, 5636, 5732, 6151, 6211, 6271, 6408, 6604, 6613, 6617, 6726, 6734, 6854, 6877, 6923, 6999, 7011, 7017, 7044, 7045, 7330, 7443, 7661, 7773, 7886, 7892, 8008, 8519, 8714, 9313, 9681, 9820, 9851, 9861, 9938, 10059, 10066, 10140, 10279, 10300, 10385, 10431, 10444, 10946, 10976, 11248, 11361, 11362, 11502, 11528, 11554, 11561, 11614, 11909, 12027, 12238, 12278, 12290, 12487, 12631, 12638, 12704, 12775, 12897, 12900, 13012, 13035, 13102, 13159, 13281, 13335, 13343, 13396, 13475, 13517, 13680, 13795, 14008, 14097, 14107, 14113, 14442, 14452, 14485, 14505, 14576, 14822, 15053, 15251, 15391, 15402, 15498, 15836, 15926, 16297, 16359, 16363, 16526, 16546, 16586, 16624, 16740, 16791, 16825, 16897, 16905, 16985, 17016, 17209, 17235, 17588, 17700, 17833, 18136, 18146, 18185, 18247, 18348, 18528, 18786, 18810, 18843, 19022, 19240, 19399, 19422, 19565, 19669, 19790, 19802 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(140, result.number);
            Assert.AreEqual(1799339, result.newNumber);
        }


        [TestMethod]
        public void TestMethod313()
        {
            int[] numbers = new int[] { 46, 99, 195, 307, 365, 402, 500, 536, 552, 683, 715, 789, 862, 931, 934, 1036, 1105, 1191, 1255, 1298, 1626, 1702, 1712, 1744, 1892, 1897, 2078, 2157, 2163, 2229, 2335, 2391, 2405, 2446, 2556, 2665, 2680, 2783, 2943, 2984, 2985, 3019, 3156, 3223, 3233, 3484, 3722, 3739, 3838, 3931, 4045, 4131, 4143, 4269, 4497, 4519, 4602, 4609, 4699, 4760, 4795, 5044, 5104, 5255, 5620, 5689, 5744, 5761, 5828, 5831, 5871, 5918, 6034, 6111, 6122, 6207, 6210, 6230, 6237, 6308, 6381, 6549, 6884, 6917, 6959, 7125, 7141, 7141, 7162, 7280, 7624, 7718, 7809, 7914, 8020, 8147, 8150, 8284, 8398, 8471, 8523, 8549, 8589, 8767, 8871, 9103, 9179, 9180, 9243, 9361, 9368, 9401, 9448, 9481, 9482, 9527, 9619, 9641, 9748, 9781, 9856, 9865, 9924, 9968, 9969, 10044, 10139, 10187, 10221, 10316, 10412, 10553, 10557, 10595, 10780, 10796, 10849, 10948, 11073, 11150, 11352, 11449, 11462, 11485, 11491, 11497, 11509, 11517, 11723, 11775, 11852, 11926, 11943, 11977, 12253, 12275, 12378, 12410, 12566, 12599, 12624, 12648, 12704, 13024, 13097, 13238, 13260, 13282, 13304, 13333, 13373, 13583, 13619, 13639, 13811, 13831, 13851, 13983, 14174, 14295, 14353, 14408, 14533, 14539, 14768, 14797, 14879, 15149, 15169, 15455, 15570, 15871, 15971, 16086, 16139, 16161, 16265, 16294, 16554, 16574, 16588, 16955, 16959, 16964, 16989, 17077, 17107, 17154, 17182, 17246, 17347, 17478, 17497, 17522, 17554, 17686, 17705, 17793, 17846, 17860, 18176, 18427, 18546, 18584, 18603, 18653, 18733, 18786, 18849, 18926, 19087, 19104, 19366, 19495, 19497, 19559, 19640, 19749, 19920 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(46, result.number);
            Assert.AreEqual(2318806, result.newNumber);
        }


        [TestMethod]
        public void TestMethod314()
        {
            int[] numbers = new int[] { 4, 26, 374, 535, 578, 878, 886, 1061, 1062, 1251, 1323, 1377, 1420, 1785, 1886, 1981, 2023, 2137, 2374, 2396, 2440, 2481, 2575, 2596, 2608, 2635, 2729, 2787, 3205, 3304, 3343, 3602, 3642, 3849, 3881, 4179, 4225, 4232, 4343, 4806, 4917, 4966, 5395, 5474, 5634, 5685, 5699, 5716, 5856, 5957, 5997, 6013, 6378, 6457, 6663, 6711, 6782, 6891, 6942, 7047, 7314, 7328, 7510, 7592, 7695, 7952, 8048, 8073, 8105, 8173, 8448, 8451, 8462, 8522, 8796, 8823, 8847, 9095, 9372, 9390, 9922, 9977, 10002, 10034, 10053, 10227, 10771, 10918, 10984, 11195, 11455, 11571, 11712, 11829, 11833, 12427, 12572, 12676, 12693, 12782, 13067, 13311, 13803, 13992, 14305, 14312, 14806, 14855, 14950, 15048, 15108, 15429, 15463, 15497, 15562, 15663, 15789, 15939, 15962, 16590, 17170, 17185, 17405, 17449, 17523, 17612, 17659, 17785, 18216, 18503, 18522, 18592, 18596, 18978, 19250, 19340, 19365, 19380, 19618, 19654, 19839, 19848, 19899, 19939 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(26, result.number);
            Assert.AreEqual(1348510, result.newNumber);
        }


        [TestMethod]
        public void TestMethod315()
        {
            int[] numbers = new int[] { 118, 175, 589, 605, 894, 947, 1059, 1553, 2359, 2382, 2617, 2705, 2756, 2808, 2841, 2857, 2871, 2917, 2935, 2947, 2974, 3080, 3117, 3807, 4332, 4553, 4641, 4669, 4955, 5060, 5399, 6273, 6499, 6500, 7258, 7388, 7392, 7539, 7727, 7764, 8067, 8122, 8176, 8249, 8640, 9195, 9906, 10347, 10351, 10640, 11018, 11039, 11533, 11651, 11960, 12751, 12763, 13107, 13280, 13355, 13422, 13440, 13666, 13809, 13933, 13948, 14692, 14913, 15266, 15304, 15461, 16113, 16272, 16289, 16463, 16868, 16879, 16901, 17094, 17535, 17802, 17806, 17842, 18206, 18667, 18761, 19074, 19211, 19332, 19647, 19687, 19723, 19732 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(118, result.number);
            Assert.AreEqual(912033, result.newNumber);
        }


        [TestMethod]
        public void TestMethod316()
        {
            int[] numbers = new int[] { 219, 242, 288, 369, 403, 580, 679, 880, 883, 909, 1060, 1258, 1270, 1284, 1318, 1319, 1552, 1645, 1718, 1756, 1797, 1812, 1819, 1941, 2026, 2184, 2195, 2358, 2470, 2489, 2536, 2549, 2553, 2731, 2789, 2968, 3014, 3122, 3188, 3245, 3382, 3400, 3405, 3424, 3451, 3503, 3537, 3560, 3581, 3765, 3794, 3806, 3885, 3961, 3978, 3981, 4061, 4116, 4152, 4167, 4268, 4313, 4324, 4416, 4443, 4500, 4562, 4635, 4669, 4680, 4999, 5052, 5056, 5060, 5253, 5330, 5392, 5462, 5688, 5748, 5838, 5960, 5968, 6025, 6091, 6148, 6201, 6216, 6273, 6292, 6375, 6448, 6496, 6507, 6569, 6747, 6761, 6778, 6931, 7050, 7079, 7082, 7107, 7168, 7297, 7339, 7354, 7365, 7440, 7518, 7572, 7695, 7699, 7989, 8199, 8214, 8356, 8432, 8560, 8621, 8657, 8678, 8679, 8879, 9139, 9278, 9348, 9371, 9435, 9559, 9563, 9605, 9745, 9859, 9898, 9952, 9984, 10128, 10153, 10235, 10311, 10366, 10382, 10391, 10394, 10446, 10476, 10514, 10628, 10640, 10682, 10685, 10694, 10743, 10844, 10901, 10908, 10917, 10924, 10974, 10992, 11004, 11138, 11157, 11315, 11519, 11545, 11625, 11654, 11748, 11772, 12039, 12107, 12256, 12285, 12439, 12475, 12501, 12542, 12588, 12660, 13346, 13383, 13641, 13723, 13860, 13890, 13978, 14074, 14130, 14189, 14190, 14277, 14370, 14439, 14459, 14462, 14543, 14704, 14836, 14852, 14960, 14991, 15097, 15179, 15180, 15417, 15692, 15826, 15899, 15911, 15969, 16217, 16302, 16320, 16378, 16479, 16518, 16604, 16700, 16807, 16850, 16881, 16931, 16941, 16959, 16982, 17034, 17123, 17138, 17432, 17480, 17499, 17552, 17583, 17602, 17665, 17867, 17939, 17953, 17968, 18026, 18083, 18261, 18322, 18373, 18386, 18545, 18619, 18759, 18792, 18904, 18907, 19017, 19021, 19042, 19097, 19153, 19194, 19267, 19446, 19599, 19623, 19742, 19783, 19806, 19878, 19896, 19937, 19942 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(219, result.number);
            Assert.AreEqual(2675801, result.newNumber);
        }


        [TestMethod]
        public void TestMethod317()
        {
            int[] numbers = new int[] { 30, 81, 105, 129, 142, 163, 212, 315, 334, 496, 501, 695, 761, 842, 859, 981, 1005, 1055, 1110, 1143, 1224, 1230, 1291, 1363, 1422, 1663, 1682, 1701, 1935, 1942, 1989, 2015, 2059, 2108, 2169, 2174, 2234, 2241, 2268, 2344, 2441, 2460, 2580, 2793, 2818, 2819, 3031, 3072, 3134, 3163, 3196, 3313, 3453, 3606, 3659, 3873, 3963, 4128, 4299, 4405, 4438, 4755, 4877, 4903, 4918, 4923, 5011, 5164, 5252, 5255, 5429, 5447, 5464, 5567, 5660, 5997, 6042, 6151, 6263, 6370, 6469, 6510, 6540, 6566, 6578, 6704, 6850, 6865, 6901, 6966, 7019, 7222, 7311, 7461, 7679, 7700, 7704, 8086, 8333, 8475, 8654, 8673, 8705, 8718, 8777, 8802, 8896, 8921, 9037, 9149, 9153, 9234, 9235, 9318, 9500, 9529, 9534, 9624, 9668, 9831, 10019, 10041, 10138, 10143, 10191, 10225, 10227, 10248, 10360, 10429, 10610, 10656, 10719, 10751, 10778, 10830, 10832, 10891, 11226, 11231, 11287, 11333, 11339, 11392, 11395, 11448, 11763, 11926, 11999, 12001, 12006, 12042, 12060, 12064, 12109, 12116, 12208, 12317, 12345, 12382, 12397, 12411, 12422, 12459, 12497, 12551, 12708, 12855, 12895, 12913, 12922, 13059, 13175, 13213, 13280, 13296, 13383, 13565, 13635, 13907, 13923, 13935, 13948, 13972, 14064, 14086, 14161, 14230, 14254, 14284, 14291, 14299, 14311, 14331, 14359, 14398, 14403, 14403, 14504, 14600, 14619, 14715, 14727, 14859, 14924, 14935, 15057, 15149, 15212, 15310, 15497, 15643, 15835, 15842, 15915, 15916, 15971, 15976, 16022, 16082, 16180, 16198, 16209, 16262, 16337, 16338, 16339, 16341, 16432, 16541, 16552, 16593, 16628, 16741, 16913, 16978, 17011, 17104, 17133, 17136, 17246, 17274, 17303, 17312, 17345, 17392, 17393, 17448, 17455, 17487, 17515, 17607, 17608, 17657, 17697, 17709, 17731, 17787, 17856, 17883, 17921, 18004, 18089, 18139, 18198, 18448, 18478, 18585, 18677, 18780, 18886, 18947, 19103, 19207, 19300, 19432, 19438, 19470, 19486, 19524, 19535, 19538, 19553, 19574, 19608, 19619, 19715, 19786, 19786, 19789, 19972 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(81, result.number);
            Assert.AreEqual(3124061, result.newNumber);
        }


        [TestMethod]
        public void TestMethod318()
        {
            int[] numbers = new int[] { 2641, 4594, 12658, 18032, 19403 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(2641, result.number);
            Assert.AreEqual(1, result.newNumber);
        }


        [TestMethod]
        public void TestMethod319()
        {
            int[] numbers = new int[] { 34, 115, 243, 244, 262, 377, 564, 565, 604, 621, 638, 651, 652, 686, 720, 868, 1290, 1834, 1928, 2086, 2146, 2327, 2342, 2553, 2667, 2800, 2819, 2968, 3127, 3241, 3276, 3463, 3475, 3498, 3663, 3819, 3835, 4125, 4242, 4250, 4261, 4363, 4570, 4668, 4725, 4740, 4819, 4828, 4932, 4980, 5007, 5199, 5233, 5290, 5298, 5417, 5489, 5582, 5627, 5666, 5728, 5870, 5928, 6003, 6076, 6084, 6091, 6176, 6244, 6304, 6346, 6413, 6413, 6903, 6924, 6986, 7369, 7372, 7390, 7428, 7462, 7483, 7488, 7498, 7535, 7825, 7842, 7920, 7931, 8069, 8100, 8161, 8227, 8276, 8332, 8430, 8476, 8482, 8492, 8496, 8497, 8577, 8587, 8624, 8843, 9151, 9228, 9287, 9459, 9540, 9623, 9739, 9756, 9854, 9911, 10078, 10086, 10191, 10517, 10808, 10823, 11160, 11262, 11384, 11399, 11435, 11440, 11532, 11638, 11714, 11915, 12031, 12122, 12217, 12551, 12600, 12788, 12840, 12843, 12912, 13016, 13299, 13452, 13475, 13499, 13539, 13553, 13555, 13609, 13641, 13875, 14163, 14260, 14370, 14394, 14505, 14509, 14528, 14627, 14712, 14830, 14944, 15077, 15219, 15402, 15474, 15487, 15697, 15698, 15896, 15930, 16015, 16054, 16117, 16244, 16378, 16494, 17055, 17089, 17120, 17175, 17219, 17230, 17275, 17409, 17634, 17658, 17709, 18015, 18027, 18038, 18083, 18110, 18213, 18215, 18230, 18274, 18313, 18889, 18895, 18929, 18945, 19095, 19142, 19188, 19188, 19336, 19383, 19505, 19578, 19610, 19712, 19905 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(377, result.number);
            Assert.AreEqual(2104758, result.newNumber);
        }


        [TestMethod]
        public void TestMethod320()
        {
            int[] numbers = new int[] { 130, 209, 569, 1888, 2166, 2166, 2665, 2730, 2829, 3390, 4019, 4184, 4449, 4633, 4645, 4684, 4917, 4974, 5643, 5832, 6083, 6372, 7088, 7153, 7295, 7528, 7972, 8260, 8274, 8300, 8936, 9102, 10185, 10364, 10979, 11009, 11012, 11333, 12326, 12591, 12643, 13011, 13177, 13236, 13330, 13365, 13480, 13485, 14336, 14637, 14980, 15024, 15252, 15281, 15301, 15819, 15850, 15884, 15948, 15982, 16841, 16931, 17290, 17377, 17521, 17831, 17860, 18048, 18055, 18138, 18486, 18940, 19093, 19775, 19886 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(2166, result.number);
            Assert.AreEqual(797167, result.newNumber);
        }


        [TestMethod]
        public void TestMethod321()
        {
            int[] numbers = new int[] { 366, 372, 647, 743, 969, 1013, 1134, 1375, 1620, 1913, 1926, 2051, 2141, 2161, 2404, 2507, 2781, 2951, 2980, 3185, 3361, 3444, 3659, 3805, 3870, 4111, 4277, 4317, 4348, 4373, 4477, 4641, 4715, 4758, 5063, 5097, 5244, 5391, 5423, 5456, 5651, 5678, 5723, 5781, 5813, 5867, 6282, 6353, 6867, 7001, 7079, 7105, 7394, 7791, 7822, 8072, 8076, 8344, 8446, 8761, 9209, 9218, 9278, 9303, 9320, 9543, 9553, 9611, 9740, 9892, 10161, 10321, 10345, 10449, 10698, 10746, 11039, 11039, 11067, 11076, 11201, 11228, 11357, 11541, 12015, 12079, 12284, 12430, 12763, 12868, 12874, 12952, 13423, 13570, 13650, 13706, 14047, 14243, 14258, 14455, 14693, 14830, 15010, 15438, 15490, 15496, 15516, 15633, 15688, 15714, 15943, 16066, 16094, 16218, 16358, 16371, 16445, 16629, 16654, 16742, 16819, 17651, 17665, 17868, 17906, 18520, 18769, 18891, 18992, 19309, 19321, 19507, 19513, 19725, 19812, 19861, 19935, 19955, 19966 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(366, result.number);
            Assert.AreEqual(1394324, result.newNumber);
        }


        [TestMethod]
        public void TestMethod322()
        {
            int[] numbers = new int[] { 277, 379, 431, 995, 1386, 1579, 1657, 2585, 2727, 2873, 2940, 4240, 4687, 5669, 5701, 5779, 5782, 6401, 6980, 6991, 7153, 7170, 7379, 7438, 7630, 7728, 7874, 8113, 8548, 8569, 8938, 9061, 9488, 9878, 9979, 10019, 10553, 10570, 11178, 11408, 11483, 11900, 12079, 12482, 13571, 13701, 13902, 13966, 14131, 14385, 14677, 15840, 15912, 16077, 16183, 16212, 16850, 16999, 17058, 17335, 18169, 18472, 18525, 18797, 19086, 19430, 19735, 19773 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(277, result.number);
            Assert.AreEqual(684718, result.newNumber);
        }


        [TestMethod]
        public void TestMethod323()
        {
            int[] numbers = new int[] { 492, 4920, 7876, 7913, 9097, 10022, 10972, 11747, 14709, 16512, 16826 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(4920, result.number);
            Assert.AreEqual(1, result.newNumber);
        }


        [TestMethod]
        public void TestMethod324()
        {
            int[] numbers = new int[] { 107, 177, 230, 327, 373, 392, 411, 542, 559, 600, 606, 673, 692, 739, 927, 1065, 1122, 1131, 1239, 1245, 1307, 1399, 1457, 1468, 1636, 1646, 1655, 1657, 1915, 2105, 2114, 2196, 2213, 2584, 2628, 2722, 2888, 2971, 3426, 3631, 3919, 4133, 4136, 4197, 4640, 4653, 4675, 4720, 5053, 5262, 5306, 5495, 5842, 5844, 5878, 5998, 6174, 6311, 6786, 6803, 6807, 6846, 7081, 7103, 7197, 7261, 7284, 7410, 7626, 7809, 7978, 8142, 8275, 8640, 8643, 8661, 8766, 8814, 8861, 9116, 9125, 9128, 9202, 9267, 9316, 9552, 9901, 10040, 10139, 10169, 10200, 10276, 10421, 10622, 10670, 10817, 11000, 11135, 11422, 11447, 11493, 11506, 11591, 11930, 11935, 12107, 12364, 12429, 12596, 12701, 12775, 12783, 12790, 12830, 12931, 12974, 13048, 13436, 13693, 13964, 14010, 14049, 14337, 14505, 14553, 14656, 14664, 14819, 14967, 15086, 15121, 15225, 15243, 15245, 15355, 15367, 15438, 15590, 15620, 15685, 15691, 15738, 15755, 15846, 16145, 16454, 16582, 16598, 16639, 16901, 16926, 16937, 16988, 17000, 17043, 17609, 17632, 17806, 18075, 18113, 18182, 18740, 18751, 18766, 18821, 19008, 19092, 19156, 19241, 19294, 19313, 19524, 19545, 19610, 19889, 19941 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(177, result.number);
            Assert.AreEqual(1717658, result.newNumber);
        }


        [TestMethod]
        public void TestMethod325()
        {
            int[] numbers = new int[] { 11, 106, 335, 722, 812, 859, 860, 1310, 1352, 1457, 1557, 1604, 1640, 1656, 1753, 1925, 1959, 2044, 2054, 2185, 2509, 2731, 2927, 3092, 3224, 3333, 3450, 3583, 3641, 3663, 3680, 3694, 3830, 3904, 4001, 4294, 4345, 4379, 4482, 4652, 4816, 4987, 5011, 5068, 5091, 5101, 5114, 5149, 5333, 5401, 5704, 5705, 5738, 5968, 6025, 6035, 6417, 6458, 6712, 6968, 6976, 7113, 7178, 7203, 7212, 7267, 7278, 7324, 7836, 7900, 7926, 7948, 8211, 8213, 8220, 8524, 8541, 8720, 9006, 9039, 9054, 9210, 9269, 9458, 9750, 10271, 10402, 10739, 10850, 10863, 10979, 11699, 11867, 11873, 11889, 12050, 12337, 12486, 12491, 12588, 12600, 12724, 12835, 12932, 12975, 13001, 13074, 13098, 13519, 13538, 13691, 13789, 13826, 13932, 13943, 14089, 14093, 14182, 14305, 14536, 14558, 14759, 14870, 14965, 14986, 15098, 15300, 15360, 15981, 16043, 16327, 16340, 16509, 16521, 16524, 16564, 16589, 16668, 16766, 17036, 17179, 17263, 17320, 17361, 17482, 17506, 17578, 17679, 17791, 17962, 18163, 18301, 18507, 18807, 18930, 19041, 19090, 19202, 19222, 19258, 19263, 19319, 19367, 19375, 19549, 19667, 19750, 19759, 19821, 19829, 19991 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(11, result.number);
            Assert.AreEqual(1753653, result.newNumber);
        }


        [TestMethod]
        public void TestMethod326()
        {
            int[] numbers = new int[] { 28, 64, 124, 134, 231, 269, 270, 302, 351, 379, 504, 606, 805, 829, 959, 994, 1135, 1190, 1648, 1703, 1772, 1813, 1880, 1961, 2040, 2055, 2061, 2118, 2161, 2164, 2191, 2421, 2592, 2649, 2722, 2783, 2783, 2820, 2866, 2887, 3036, 3495, 3920, 3983, 4055, 4133, 4411, 4489, 4884, 4934, 5155, 5286, 5374, 5385, 5578, 5655, 5657, 5657, 5697, 5741, 5856, 5890, 6066, 6083, 6100, 6461, 6528, 6550, 6636, 6788, 7031, 7150, 7158, 7217, 7256, 7256, 7309, 7597, 7656, 7684, 7742, 7818, 7821, 7836, 7852, 7925, 7967, 8068, 8336, 8337, 8384, 8447, 8488, 8498, 8565, 8711, 8749, 8846, 8996, 9326, 9393, 9654, 9664, 10161, 10307, 10310, 10351, 10487, 10650, 10701, 10712, 10932, 10949, 11096, 11216, 11275, 11671, 11797, 11812, 11813, 11857, 12032, 12312, 12380, 12446, 12501, 12592, 12699, 12872, 12922, 12969, 13094, 13352, 13353, 13432, 13580, 13643, 13678, 13703, 13703, 13759, 13800, 13903, 14064, 14104, 14145, 14189, 14207, 14262, 14311, 14361, 14369, 14406, 14469, 14503, 14602, 15094, 15097, 15136, 15184, 15222, 15253, 15271, 15352, 15368, 15420, 15699, 15709, 15961, 15968, 16101, 16177, 16181, 16184, 16408, 16480, 16603, 16719, 16728, 16771, 16784, 16796, 16811, 16982, 16997, 17009, 17175, 17184, 17286, 17402, 17485, 17710, 17737, 17841, 18039, 18204, 18247, 18363, 18389, 18468, 18474, 18547, 18649, 18712, 18724, 18773, 18832, 18914, 18942, 18943, 19140, 19147, 19236, 19242, 19366, 19497, 19554, 19757, 19918 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(28, result.number);
            Assert.AreEqual(2252655, result.newNumber);
        }


        [TestMethod]
        public void TestMethod327()
        {
            int[] numbers = new int[] { 358, 1415, 2011, 2573, 3034, 3970, 4400, 5047, 5695, 6650, 7258, 7602, 8300, 9084, 9958, 11270, 11648, 12548, 13024, 13594, 14277, 15335, 16391, 16655, 16658, 17092, 17347, 17646, 17952, 18183, 18216, 18828, 19774 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1415, result.number);
            Assert.AreEqual(333099, result.newNumber);
        }


        [TestMethod]
        public void TestMethod328()
        {
            int[] numbers = new int[] { 52, 76, 200, 265, 456, 506, 568, 628, 793, 802, 830, 833, 842, 908, 1159, 1230, 1347, 1495, 1639, 1644, 1803, 1980, 2109, 2116, 2252, 2301, 2325, 2452, 2515, 2712, 2990, 3012, 3104, 3492, 3685, 3745, 3835, 3871, 4076, 4156, 4305, 4364, 4431, 4488, 4536, 4605, 4709, 4828, 5066, 5158, 5172, 5187, 5293, 5472, 5714, 5740, 5989, 6358, 6592, 6756, 6836, 6914, 7376, 7409, 7587, 7673, 7749, 7784, 7803, 7971, 8505, 8673, 8678, 8790, 8914, 9192, 9235, 9296, 9324, 9612, 9675, 9686, 9816, 9902, 9942, 10050, 10076, 10498, 10498, 10698, 10711, 10717, 10752, 10857, 10860, 11177, 11221, 11243, 11330, 11382, 11396, 11441, 11462, 11471, 11674, 11964, 11976, 12002, 12023, 12038, 12052, 12129, 12169, 12332, 12407, 12489, 12764, 12782, 12844, 12927, 13020, 13219, 13323, 13471, 13571, 13666, 13852, 13893, 14039, 14079, 14171, 14581, 14760, 15045, 15270, 15343, 15419, 15490, 15545, 15677, 15718, 15741, 15781, 15952, 15987, 16151, 16197, 16313, 16443, 16457, 16540, 16616, 16689, 16733, 16762, 16888, 16933, 17160, 17160, 17215, 17244, 17270, 17273, 17296, 17523, 17653, 17836, 17946, 18028, 18091, 18295, 18467, 18580, 18635, 18752, 19009, 19034, 19091, 19139, 19177, 19264, 19364, 19436, 19625, 19625, 19873 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(265, result.number);
            Assert.AreEqual(1894315, result.newNumber);
        }


        [TestMethod]
        public void TestMethod329()
        {
            int[] numbers = new int[] { 159, 178, 203, 233, 260, 638, 673, 801, 869, 915, 972, 1096, 1335, 1384, 1513, 1702, 1974, 2557, 2610, 2817, 2929, 3135, 3457, 3550, 3550, 3567, 3623, 3624, 3776, 3822, 3845, 3960, 3964, 4109, 4151, 4318, 4342, 4392, 4481, 4483, 4509, 4532, 4785, 4785, 4825, 4877, 4902, 5005, 5078, 5122, 5156, 5490, 5542, 5579, 5604, 5744, 5796, 5817, 6022, 6140, 6155, 6199, 6469, 6825, 6854, 6938, 6963, 7002, 7003, 7130, 7137, 7317, 7420, 7476, 7623, 7752, 7774, 7847, 7961, 7978, 8003, 8023, 8146, 8155, 8164, 8218, 8220, 8236, 8268, 8334, 8337, 8397, 8536, 8631, 8664, 8712, 8771, 8854, 9009, 9016, 9038, 9078, 9137, 9242, 9316, 9319, 9385, 9393, 9529, 9590, 9664, 9881, 9903, 9940, 9968, 10057, 10342, 10465, 10554, 10587, 10769, 10844, 10889, 11112, 11668, 11764, 11826, 11826, 11867, 11892, 11967, 12084, 12258, 12265, 12404, 12423, 12430, 12491, 12536, 12642, 12865, 12867, 13112, 13112, 13162, 13166, 13257, 13321, 13329, 13503, 13519, 13557, 13566, 13808, 13816, 13826, 14230, 14254, 14273, 14320, 14421, 14475, 14477, 14579, 14639, 14685, 14822, 14903, 14944, 15131, 15170, 15205, 15239, 15464, 15469, 15539, 15539, 15668, 15669, 15699, 15745, 15762, 15817, 16018, 16282, 16298, 16453, 16477, 16795, 16998, 17014, 17069, 17260, 17287, 17477, 17489, 17622, 17680, 17731, 17735, 17790, 17872, 17889, 18024, 18418, 18448, 18456, 18469, 18635, 18828, 18940, 18951, 19030, 19162, 19386, 19402, 19447, 19498, 19515, 19543, 19588, 19589, 19628, 19777, 19806, 19808, 19832, 19923, 19955 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(178, result.number);
            Assert.AreEqual(2410673, result.newNumber);
        }


        [TestMethod]
        public void TestMethod330()
        {
            int[] numbers = new int[] { 31, 154, 201, 456, 1034, 1066, 1462, 1476, 1918, 2136, 2239, 2342, 2389, 2398, 2401, 2439, 2508, 3144, 3596, 3759, 3988, 4165, 4503, 4539, 4660, 5914, 6061, 6636, 6693, 7337, 7447, 7758, 7762, 7943, 7949, 7975, 8334, 9001, 9012, 9256, 10363, 10389, 10518, 10854, 11032, 11520, 11781, 11795, 11899, 11974, 12015, 12139, 12720, 13155, 13309, 13457, 13581, 13710, 13801, 14114, 14614, 14826, 15108, 15119, 15283, 15290, 15508, 15735, 15792, 15959, 16122, 16235, 16490, 16560, 16653, 17894, 18369, 18612, 18936, 19262, 19346, 19944 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(154, result.number);
            Assert.AreEqual(780103, result.newNumber);
        }


        [TestMethod]
        public void TestMethod331()
        {
            int[] numbers = new int[] { 163, 179, 477, 685, 754, 784, 862, 940, 1021, 1054, 1087, 1102, 1133, 1150, 1168, 1231, 1299, 1419, 1519, 1564, 1653, 1789, 1833, 1958, 1967, 1990, 2109, 2154, 2246, 2263, 2279, 2318, 2355, 2484, 2531, 2547, 2650, 2652, 2857, 3167, 3171, 3242, 3271, 3283, 3311, 3351, 3377, 3395, 3441, 3498, 3514, 3522, 3538, 3539, 3735, 3829, 3955, 3970, 4041, 4093, 4179, 4215, 4257, 4303, 4314, 4404, 4445, 4510, 4546, 4563, 4567, 4738, 4820, 5056, 5208, 5238, 5324, 5350, 5465, 5541, 5577, 5609, 5629, 5644, 5678, 5758, 5816, 5847, 6031, 6047, 6186, 6368, 6638, 6676, 6691, 6749, 6971, 7065, 7176, 7215, 7415, 7599, 7831, 7840, 7851, 7852, 7859, 7913, 7963, 8010, 8079, 8306, 8543, 8594, 8628, 8644, 8675, 8819, 8819, 8857, 8929, 8931, 9018, 9042, 9059, 9099, 9168, 9208, 9357, 9398, 9575, 9701, 9863, 9917, 9999, 10006, 10188, 10290, 10295, 10437, 10468, 10510, 10553, 10646, 10688, 10732, 10748, 10795, 10814, 10855, 10858, 10921, 10964, 10986, 10988, 11053, 11185, 11225, 11229, 11368, 11444, 11516, 11543, 11697, 11709, 11765, 11775, 11951, 12125, 12256, 12415, 12478, 12498, 12552, 12672, 12746, 12788, 12889, 12940, 12941, 13092, 13214, 13267, 13276, 13277, 13324, 13484, 13561, 13571, 13653, 13731, 13739, 13911, 13930, 14125, 14339, 14351, 14501, 14554, 14556, 14592, 14681, 14694, 14718, 14903, 15235, 15241, 15338, 15453, 15614, 15619, 15744, 15792, 15806, 15878, 15896, 16003, 16054, 16077, 16226, 16323, 16333, 16380, 16433, 16898, 16937, 17024, 17113, 17116, 17270, 17415, 17606, 17676, 17692, 17695, 17836, 17976, 18032, 18044, 18053, 18096, 18133, 18137, 18535, 18559, 18635, 18657, 18672, 18693, 18715, 18735, 18922, 18980, 19077, 19100, 19117, 19210, 19220, 19388, 19499, 19534, 19572, 19592, 19688, 19712, 19713, 19837, 19894, 19942 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(477, result.number);
            Assert.AreEqual(2655759, result.newNumber);
        }


        [TestMethod]
        public void TestMethod332()
        {
            int[] numbers = new int[] { 120, 146, 183, 444, 569, 583, 646, 677, 725, 915, 1007, 1156, 1192, 1233, 1268, 1407, 1443, 1518, 1530, 1591, 1608, 1635, 1658, 1843, 1952, 2036, 2077, 2154, 2182, 2205, 2250, 2275, 2323, 2486, 2492, 2568, 2640, 2794, 2889, 2927, 3169, 3229, 3433, 3482, 3564, 3596, 3746, 3808, 3836, 3880, 3889, 3908, 3910, 3961, 4065, 4143, 4280, 4315, 4364, 4401, 4607, 4799, 4870, 4890, 4952, 4991, 5075, 5120, 5131, 5134, 5179, 5223, 5230, 5435, 5607, 5740, 5984, 5997, 6012, 6047, 6093, 6215, 6399, 6497, 6601, 6627, 6629, 6655, 6690, 6775, 6788, 6807, 6823, 6855, 7106, 7391, 7462, 7465, 7516, 7574, 7591, 7798, 7883, 7974, 8070, 8157, 8484, 8570, 8664, 8772, 8796, 8878, 8911, 9004, 9060, 9109, 9125, 9129, 9212, 9229, 9280, 9287, 9385, 9444, 9520, 9529, 9564, 9580, 9587, 9643, 9678, 9684, 9749, 9754, 9933, 10144, 10170, 10290, 10435, 10446, 10518, 10619, 10634, 10797, 10854, 10857, 10902, 10997, 11062, 11085, 11127, 11179, 11248, 11262, 11269, 11309, 11333, 11351, 11432, 11472, 11672, 11792, 11814, 12133, 12287, 12340, 12371, 12392, 12488, 12567, 12641, 12707, 12920, 12979, 13119, 13149, 13236, 13324, 13423, 13423, 13469, 13600, 13615, 13697, 13746, 13747, 13759, 13856, 13869, 13939, 14017, 14028, 14137, 14256, 14297, 14325, 14360, 14402, 14609, 14696, 14699, 14765, 14807, 14858, 15108, 15138, 15227, 15250, 15391, 15427, 15534, 15571, 15577, 15689, 15841, 15888, 16023, 16036, 16121, 16146, 16214, 16215, 16226, 16272, 16327, 16412, 16412, 16532, 16672, 16701, 16732, 16954, 16960, 16970, 17014, 17050, 17062, 17064, 17126, 17262, 17304, 17308, 17332, 17402, 17441, 17487, 17709, 17747, 17885, 17911, 17977, 17999, 18047, 18121, 18129, 18153, 18350, 18369, 18385, 18532, 18540, 18627, 18701, 18726, 18858, 18889, 18921, 19104, 19148, 19164, 19307, 19357, 19431, 19609, 19902 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(183, result.number);
            Assert.AreEqual(2789915, result.newNumber);
        }


        [TestMethod]
        public void TestMethod333()
        {
            int[] numbers = new int[] { 33, 322, 400, 543, 555, 556, 689, 815, 863, 876, 1141, 1252, 1382, 1530, 1562, 1662, 1843, 2120, 2397, 2951, 3086, 3157, 3249, 3265, 3645, 3684, 3703, 3782, 3832, 4044, 4129, 4157, 4514, 5045, 5069, 5199, 5291, 5909, 6015, 6173, 6280, 6406, 6666, 6784, 6829, 7091, 7094, 7410, 7566, 7904, 7924, 7925, 7925, 7953, 8090, 8123, 8138, 8245, 8247, 8481, 9053, 9107, 9418, 9460, 9486, 9642, 9648, 9823, 9906, 10658, 10695, 10839, 10901, 10990, 11490, 11627, 11637, 11667, 11756, 11775, 11871, 12685, 12724, 12802, 12888, 13204, 13462, 13462, 13473, 13577, 13599, 13756, 13861, 14009, 14379, 14402, 14651, 14700, 14716, 15064, 15105, 15118, 15121, 15633, 15674, 15983, 16224, 16398, 16954, 17018, 17021, 17087, 17308, 17713, 17819, 17958, 18044, 18416, 18507, 18535, 18761, 18801, 18906, 18976, 19415, 19437, 19779, 19993 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(33, result.number);
            Assert.AreEqual(1232820, result.newNumber);
        }


        [TestMethod]
        public void TestMethod334()
        {
            int[] numbers = new int[] { 204, 266, 322, 409, 468, 473, 675, 707, 1182, 1190, 1247, 1277, 1297, 1352, 1473, 1490, 1674, 1708, 1753, 1782, 1920, 1940, 1954, 1956, 1988, 2157, 2390, 2408, 2615, 2639, 2841, 2998, 3080, 3124, 3139, 3395, 3403, 3428, 3461, 3785, 3789, 3805, 3811, 4113, 4363, 4469, 4833, 4836, 5134, 5198, 5278, 5286, 5477, 5490, 5774, 5995, 6437, 6476, 6507, 6672, 6697, 6788, 6875, 6905, 6937, 6965, 6967, 7326, 7417, 7516, 7619, 7625, 7702, 7836, 7882, 8050, 8189, 8425, 8488, 8781, 8813, 8895, 8916, 8918, 9066, 9345, 9695, 9712, 9763, 9816, 9869, 9901, 10031, 10072, 10234, 10853, 11049, 11084, 11361, 11430, 11725, 11846, 11858, 11885, 12770, 13039, 13162, 13396, 13419, 13475, 13683, 13685, 13805, 13858, 13892, 14114, 14183, 14230, 14305, 14687, 14787, 14862, 14886, 14889, 14953, 15008, 15011, 15503, 15507, 15638, 15768, 15780, 15954, 15956, 16114, 16176, 16326, 16637, 16660, 16707, 16828, 16983, 17028, 17426, 17685, 17690, 17833, 17924, 17925, 17930, 17951, 17954, 18101, 18187, 18360, 18524, 18540, 18727, 18818, 19149, 19348, 19359, 19570, 19765 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(266, result.number);
            Assert.AreEqual(1543616, result.newNumber);
        }


        [TestMethod]
        public void TestMethod335()
        {
            int[] numbers = new int[] { 103, 127, 332, 489, 649, 689, 810, 828, 1059, 1298, 1422, 1455, 2212, 2317, 2494, 2648, 2967, 3112, 3783, 4005, 4387, 4477, 4598, 4695, 4838, 5416, 5605, 5875, 6621, 6776, 6858, 6945, 7622, 8111, 8313, 8795, 9814, 10171, 10400, 10783, 11035, 11662, 12211, 12876, 12935, 13490, 13740, 13873, 14003, 14352, 14533, 14600, 14703, 14709, 14800, 14813, 15040, 15417, 15456, 15598, 15989, 16161, 16537, 17295, 17442, 17820, 17997, 18979, 19173, 19292, 19932 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(103, result.number);
            Assert.AreEqual(646049, result.newNumber);
        }


        [TestMethod]
        public void TestMethod336()
        {
            int[] numbers = new int[] { 58, 1879, 2542, 2706, 2755, 3514, 3569, 3594, 3789, 4119, 4564, 5562, 5642, 5664, 6718, 7220, 7721, 7877, 7951, 8243, 8469, 9026, 9038, 9238, 9325, 9824, 10002, 10325, 10410, 10954, 11422, 11634, 11667, 12176, 12416, 12419, 12503, 13269, 13968, 16034, 16221, 16526, 17488, 17840, 18877, 19598, 19732 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(58, result.number);
            Assert.AreEqual(426332, result.newNumber);
        }


        [TestMethod]
        public void TestMethod337()
        {
            int[] numbers = new int[] { 268, 492, 596, 712, 734, 804, 868, 881, 1034, 1062, 1177, 1672, 1839, 1939, 2056, 2106, 2155, 2196, 2326, 2379, 2386, 2538, 3015, 3046, 3177, 3600, 3786, 3850, 3876, 4199, 4587, 4637, 4639, 4644, 4945, 5071, 5336, 5682, 5873, 5896, 6408, 6540, 6577, 6665, 6665, 6868, 6940, 7046, 7187, 7218, 7575, 7674, 7780, 7925, 7948, 8084, 8249, 8687, 8730, 8820, 9138, 9260, 9318, 9330, 9532, 9592, 9701, 9711, 10058, 10225, 10336, 10408, 10495, 10497, 10578, 10654, 10702, 10874, 11505, 11549, 11577, 11613, 11616, 11659, 11883, 11996, 12001, 12436, 12662, 12682, 12721, 12794, 12980, 12988, 13193, 13516, 13613, 13650, 13883, 13969, 14148, 14228, 14229, 14461, 14529, 14616, 14626, 14662, 14696, 14749, 14762, 14962, 15263, 15574, 15954, 16005, 16087, 16285, 16320, 16350, 16611, 16638, 16696, 16880, 16891, 16905, 16953, 17519, 17929, 17951, 18004, 18138, 18413, 18641, 18726, 18760, 18798, 18997, 19005, 19356, 19530, 19920 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(268, result.number);
            Assert.AreEqual(1413716, result.newNumber);
        }


        [TestMethod]
        public void TestMethod338()
        {
            int[] numbers = new int[] { 1, 23, 60, 119, 142, 274, 408, 477, 514, 677, 693, 693, 864, 1132, 1238, 1254, 1612, 1629, 1781, 1822, 1822, 1885, 1938, 1976, 2140, 2301, 2401, 2543, 2759, 2912, 3001, 3011, 3037, 3041, 3111, 3440, 3484, 3601, 3786, 3875, 4040, 4279, 4551, 4618, 4838, 5038, 5046, 5221, 5289, 5295, 5354, 5501, 5576, 5728, 5756, 5784, 6093, 6637, 6648, 7112, 7150, 7158, 7310, 7315, 7433, 7495, 7622, 7668, 7677, 7826, 8064, 8543, 8549, 8608, 9117, 9175, 9318, 9391, 9629, 9648, 9674, 9768, 9828, 9891, 10003, 10036, 10087, 10106, 10164, 10278, 10325, 10333, 10373, 10414, 10610, 10632, 10748, 10762, 10883, 10905, 11037, 11078, 11237, 11255, 11256, 11346, 11502, 11576, 11577, 11580, 11698, 11738, 11889, 11967, 12002, 12136, 12694, 12706, 12706, 12778, 13070, 13107, 13120, 13140, 13267, 13397, 13518, 13584, 13621, 13715, 13874, 13895, 13962, 14507, 14780, 14963, 15147, 15376, 15441, 15484, 15530, 15853, 16079, 16429, 16622, 17329, 17351, 17401, 17803, 17815, 17828, 17860, 17912, 18006, 18233, 18318, 18389, 18424, 18474, 18571, 18591, 18611, 18760, 19015, 19223, 19273, 19622, 19966, 19987, 19987, 19991 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(23, result.number);
            Assert.AreEqual(1629031, result.newNumber);
        }


        [TestMethod]
        public void TestMethod339()
        {
            int[] numbers = new int[] { 180, 387, 394, 429, 446, 465, 483, 509, 570, 586, 700, 986, 1085, 1129, 1364, 1411, 1460, 1463, 1492, 1511, 1663, 1684, 1780, 1850, 2069, 2118, 2318, 2369, 2391, 2432, 2502, 2533, 2552, 2703, 2896, 2923, 2927, 2996, 3062, 3326, 3732, 3756, 3830, 3886, 4040, 4216, 4223, 4319, 4331, 4454, 4504, 5024, 5053, 5128, 5244, 5447, 5519, 5563, 5704, 5895, 5950, 6031, 6121, 6187, 6219, 6541, 6568, 6689, 7150, 7207, 7376, 7746, 7749, 7750, 7904, 7955, 8052, 8371, 8387, 8431, 8708, 8791, 8839, 9087, 9270, 9384, 9578, 9666, 9698, 9814, 9853, 9917, 10385, 10486, 10623, 10767, 10833, 10937, 11016, 11055, 11181, 11190, 11397, 11555, 11633, 11646, 11683, 11752, 11977, 12052, 12127, 12130, 12200, 12268, 12295, 12354, 12376, 12413, 12423, 12448, 12464, 12487, 12719, 12750, 12804, 12821, 13369, 13885, 13895, 14029, 14241, 14379, 14392, 14401, 14478, 14537, 14795, 14823, 14871, 14879, 14973, 15107, 15192, 15249, 15261, 15266, 15379, 15565, 15676, 15852, 15862, 15994, 16062, 16069, 16656, 16659, 16785, 16805, 16811, 16824, 17046, 17079, 17127, 17253, 17303, 17378, 17584, 17697, 17744, 18037, 18047, 18186, 18199, 18251, 18359, 18443, 18641, 19135, 19436, 19585 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(394, result.number);
            Assert.AreEqual(1695289, result.newNumber);
        }


        [TestMethod]
        public void TestMethod340()
        {
            int[] numbers = new int[] { 37, 45, 137, 206, 209, 374, 399, 474, 475, 500, 505, 811, 820, 892, 978, 1200, 1320, 1324, 1328, 1396, 1440, 1674, 1803, 1822, 1904, 1929, 1966, 2032, 2038, 2171, 2349, 2374, 2395, 2778, 3017, 3083, 3108, 3544, 3630, 3665, 3709, 3732, 4003, 4186, 4239, 4327, 4355, 4480, 4491, 4606, 4777, 4839, 4854, 4859, 4891, 4900, 4928, 5201, 5232, 5282, 5310, 5348, 5490, 5702, 5744, 5835, 5853, 5854, 5963, 5989, 6111, 6112, 6167, 6415, 6489, 6629, 6835, 6909, 7068, 7158, 7260, 7312, 7316, 7441, 7526, 7539, 7548, 7576, 7674, 7785, 7993, 7999, 8015, 8055, 8060, 8084, 8187, 8254, 8287, 8368, 8438, 8528, 8541, 8581, 9056, 9204, 9506, 9600, 9608, 9637, 9672, 9711, 9734, 9793, 9861, 9938, 9946, 10059, 10092, 10156, 10245, 10259, 10276, 10479, 10575, 10586, 10618, 10762, 10801, 10833, 10931, 11086, 11271, 11306, 11543, 11558, 11836, 11879, 12033, 12044, 12107, 12190, 12255, 12267, 12272, 12290, 12388, 12415, 12459, 12481, 12526, 12543, 12831, 12895, 12897, 12982, 13081, 13216, 13221, 13422, 13455, 13536, 13537, 13651, 13684, 13706, 13774, 14059, 14240, 14319, 14339, 14614, 14661, 14879, 14879, 15088, 15123, 15201, 15259, 15277, 15324, 15337, 15386, 15459, 15475, 15491, 15695, 15697, 15814, 16042, 16269, 16320, 16405, 16605, 16705, 16743, 17014, 17122, 17186, 17234, 17249, 17253, 17275, 17380, 17553, 17571, 17579, 17743, 17768, 17784, 17840, 18089, 18101, 18141, 18217, 18384, 18387, 18392, 18467, 18537, 18542, 18584, 18646, 18681, 18788, 18792, 18846, 18886, 18953, 18983, 19036, 19185, 19192, 19256, 19355, 19546, 19674, 19741, 19766, 19797, 19829, 19919, 19928, 19935 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(137, result.number);
            Assert.AreEqual(2525508, result.newNumber);
        }


        [TestMethod]
        public void TestMethod341()
        {
            int[] numbers = new int[] { 15, 118, 132, 204, 245, 259, 549, 648, 694, 738, 927, 952, 955, 1002, 1021, 1471, 1774, 1955, 2096, 2119, 2290, 2401, 2480, 2495, 2495, 2580, 2744, 2759, 2821, 2918, 2935, 3044, 3102, 3174, 3296, 3307, 3320, 3414, 3428, 3654, 3694, 3708, 3784, 3846, 3892, 3964, 4135, 4202, 4240, 4265, 4292, 4310, 4311, 4348, 4382, 4389, 4396, 4428, 4460, 4513, 4703, 4796, 4900, 4958, 5086, 5254, 5269, 5432, 5469, 5480, 5643, 5721, 5745, 5756, 5774, 5776, 5782, 5817, 5844, 5852, 5957, 6004, 6307, 6343, 6433, 6623, 6692, 6781, 6877, 6914, 6950, 7010, 7059, 7124, 7161, 7307, 7320, 7499, 7526, 7529, 7563, 7621, 7667, 7744, 7777, 7843, 7863, 7900, 8047, 8117, 8224, 8284, 8361, 8374, 8437, 8486, 8515, 8603, 8639, 8694, 8748, 8758, 8827, 8855, 8931, 8954, 9025, 9211, 9228, 9244, 9383, 9615, 9854, 9859, 9938, 10046, 10051, 10115, 10189, 10387, 10593, 10767, 10892, 10932, 11019, 11123, 11305, 11343, 11358, 11410, 11468, 11500, 11507, 11559, 11567, 11704, 11723, 11740, 12025, 12134, 12204, 12260, 12274, 12469, 12482, 12691, 12723, 12765, 12822, 12844, 12867, 12886, 12946, 12960, 12972, 13102, 13174, 13469, 13648, 13682, 13747, 13925, 14001, 14062, 14089, 14177, 14196, 14204, 14322, 14366, 14456, 14498, 14539, 14776, 14776, 14831, 14972, 15001, 15081, 15153, 15198, 15269, 15320, 15360, 15439, 15576, 15620, 15775, 15783, 15786, 15790, 16186, 16197, 16257, 16279, 16482, 16602, 16719, 16755, 16760, 16804, 16896, 16969, 17164, 17213, 17356, 17401, 17404, 17513, 17532, 17586, 17615, 17634, 17657, 17703, 17786, 17837, 17858, 17978, 17991, 18001, 18145, 18238, 18298, 18325, 18430, 18457, 18467, 18501, 18504, 18518, 18577, 18622, 18681, 18704, 18734, 18825, 18837, 18846, 18969, 19093, 19290, 19368, 19479, 19588, 19679, 19701, 19824, 19953 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(118, result.number);
            Assert.AreEqual(2746190, result.newNumber);
        }


        [TestMethod]
        public void TestMethod342()
        {
            int[] numbers = new int[] { 63, 114, 466, 522, 744, 1018, 1115, 1253, 1338, 2042, 2083, 2236, 2286, 2347, 2368, 2785, 3911, 3967, 4265, 4487, 4533, 4761, 4809, 4925, 4954, 4984, 5295, 5400, 5406, 5519, 5967, 5994, 6163, 6291, 6880, 7044, 7077, 7109, 7167, 7525, 7685, 7742, 7880, 7921, 7970, 8574, 8862, 9110, 9386, 9867, 9885, 9899, 10025, 10338, 10438, 11020, 11327, 11356, 11577, 11847, 11937, 11959, 11973, 12420, 12437, 12439, 12493, 12665, 12991, 13054, 13413, 13440, 13612, 13679, 13694, 13912, 14083, 14382, 14502, 14829, 14947, 15441, 16185, 16190, 16333, 16373, 17318, 17899, 17934, 18038, 18131, 18238, 18251, 18348, 18455, 18958, 19007, 19252, 19366, 19396, 19465, 19841, 19909 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(522, result.number);
            Assert.AreEqual(1021661, result.newNumber);
        }


        [TestMethod]
        public void TestMethod343()
        {
            int[] numbers = new int[] { 159, 919, 947, 956, 1385, 1532, 1758, 1875, 2139, 2153, 2619, 2623, 3055, 3076, 3278, 3395, 3546, 3898, 4121, 4124, 4140, 4349, 4439, 4541, 4670, 4695, 4893, 4921, 4945, 5009, 5470, 5761, 5863, 5906, 6193, 6902, 7416, 7425, 7614, 7939, 8000, 8089, 8092, 8579, 9045, 9416, 9433, 9443, 9462, 10212, 10355, 10856, 10919, 11182, 11627, 11753, 12073, 12487, 12626, 12775, 12776, 12959, 13158, 13359, 13669, 14680, 14834, 15060, 15339, 15393, 15461, 15798, 15851, 15852, 16185, 16247, 16344, 16607, 16686, 16765, 16831, 16833, 17282, 17529, 17609, 18193, 18478, 18608, 18808, 18947, 19553, 19724 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(919, result.number);
            Assert.AreEqual(879678, result.newNumber);
        }


        [TestMethod]
        public void TestMethod344()
        {
            int[] numbers = new int[] { 64, 200, 382, 398, 476, 493, 684, 792, 944, 958, 995, 1041, 1061, 1188, 1218, 1525, 1626, 1672, 1731, 1847, 1971, 2121, 2515, 2584, 2607, 2756, 2835, 2879, 2903, 3035, 3091, 3211, 3227, 3315, 3467, 3547, 3586, 3755, 3756, 3760, 3775, 3827, 3928, 4191, 4346, 4389, 4409, 4430, 4504, 4539, 4547, 4756, 4780, 4834, 4855, 5074, 5162, 5190, 5386, 5399, 5440, 5453, 5486, 5495, 5577, 5638, 5686, 5730, 5746, 5875, 6039, 6090, 6200, 6206, 6211, 6256, 6351, 6504, 6537, 6698, 6733, 7119, 7138, 7547, 7553, 7609, 7665, 7717, 7797, 7798, 7803, 7877, 7950, 8132, 8153, 8308, 8479, 8485, 8527, 8586, 8611, 8804, 8940, 9131, 9347, 9394, 9450, 9529, 9724, 9726, 9753, 9828, 9939, 9953, 10072, 10158, 10272, 10332, 10493, 10611, 10775, 10785, 10820, 11020, 11133, 11178, 11186, 11268, 11410, 11629, 11768, 11894, 12000, 12018, 12040, 12058, 12137, 12137, 12194, 12238, 12267, 12269, 12387, 12429, 12556, 12563, 12630, 12645, 12698, 12844, 12898, 12956, 13019, 13122, 13333, 13343, 13356, 13519, 13795, 13820, 13902, 14025, 14098, 14460, 14507, 14597, 14677, 14723, 14869, 14935, 15059, 15144, 15165, 15179, 15251, 15434, 15602, 15638, 15675, 15734, 15792, 15893, 16010, 16037, 16037, 16184, 16195, 16245, 16313, 16499, 16524, 16673, 16909, 16980, 16994, 17010, 17052, 17123, 17183, 17286, 17340, 17616, 17718, 17758, 17766, 17784, 17885, 18271, 18433, 18450, 18565, 18918, 18951, 19069, 19255, 19286, 19287, 19288, 19489, 19712, 19861 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(200, result.number);
            Assert.AreEqual(2150377, result.newNumber);
        }


        [TestMethod]
        public void TestMethod345()
        {
            int[] numbers = new int[] { 181, 676, 1028, 1072, 1277, 1606, 1787, 1807, 1816, 1848, 1974, 2664, 2827, 3006, 3093, 3361, 3858, 4695, 5287, 5409, 5664, 5769, 6468, 6795, 7042, 7729, 7814, 8086, 8517, 8517, 8731, 9008, 9086, 9129, 9169, 9231, 10157, 10253, 10600, 10897, 10944, 11870, 11877, 12159, 12172, 12347, 12360, 12488, 12553, 13214, 13731, 13933, 14334, 14835, 15220, 15505, 15529, 15593, 15868, 16159, 16721, 16959, 17129, 17803, 18226, 18670, 19213, 19370, 19401, 19618 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(181, result.number);
            Assert.AreEqual(665027, result.newNumber);
        }


        [TestMethod]
        public void TestMethod346()
        {
            int[] numbers = new int[] { 44, 231, 369, 402, 445, 472, 490, 546, 625, 764, 871, 887, 1016, 1058, 1060, 1343, 1557, 1560, 1693, 1726, 1760, 1772, 1865, 1868, 1936, 1937, 1966, 1979, 2049, 2111, 2273, 2275, 2317, 2347, 2409, 2461, 2614, 2616, 2619, 2721, 2774, 2887, 2908, 2951, 3007, 3091, 3095, 3111, 3165, 3181, 3267, 3436, 3445, 3464, 3527, 3578, 3608, 3748, 3981, 4055, 4056, 4097, 4143, 4252, 4484, 4537, 4589, 4649, 4712, 4733, 4743, 4820, 4851, 4952, 5200, 5202, 5214, 5228, 5229, 5275, 5388, 5478, 5505, 5530, 5572, 5740, 5781, 5903, 5906, 5955, 5961, 5977, 6046, 6176, 6179, 6183, 6259, 6270, 6412, 6606, 6662, 6683, 6970, 7159, 7194, 7501, 7531, 7939, 8052, 8122, 8206, 8225, 8243, 8303, 8325, 8420, 8459, 8519, 8522, 8535, 8574, 8658, 8684, 8704, 8817, 8889, 8899, 8929, 9039, 9044, 9088, 9117, 9194, 9266, 9299, 9382, 9419, 9476, 9500, 9518, 9561, 9633, 9663, 9714, 9726, 9793, 9847, 9875, 9883, 9899, 9989, 10179, 10183, 10211, 10380, 10437, 10445, 10476, 10478, 10520, 10549, 10580, 10623, 10750, 10782, 10828, 10840, 10844, 10845, 10926, 10943, 11399, 11428, 11430, 11435, 11562, 11787, 11788, 11820, 11834, 11987, 12025, 12038, 12261, 12405, 12405, 12438, 12496, 12771, 12824, 12846, 12861, 12888, 12895, 13076, 13080, 13311, 13427, 13513, 13619, 13637, 13658, 13696, 13720, 13730, 13773, 13813, 13820, 13917, 13946, 14070, 14076, 14094, 14204, 14240, 14285, 14298, 14317, 14371, 14432, 14567, 14585, 14620, 14713, 14743, 14834, 14882, 15114, 15366, 15745, 15753, 15812, 16078, 16117, 16147, 16188, 16264, 16273, 16283, 16370, 16403, 16436, 16492, 16523, 16545, 16705, 16746, 16843, 16858, 16911, 16995, 17029, 17088, 17308, 17341, 17354, 17442, 17477, 17481, 17695, 17742, 17753, 17812, 17820, 17837, 18067, 18158, 18163, 18259, 18296, 18324, 18428, 18458, 18637, 18755, 18783, 18827, 18856, 18893, 19010, 19011, 19012, 19344, 19378, 19387, 19513, 19596, 19599, 19672, 19706, 19750 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(44, result.number);
            Assert.AreEqual(2868082, result.newNumber);
        }


        [TestMethod]
        public void TestMethod347()
        {
            int[] numbers = new int[] { 54, 92, 242, 300, 406, 728, 751, 791, 794, 835, 940, 954, 977, 1176, 1298, 1442, 1443, 1537, 1606, 1641, 1651, 1691, 1989, 2076, 2165, 2224, 2338, 2420, 2447, 2450, 2619, 2644, 2724, 2755, 2839, 2926, 3053, 3091, 3103, 3290, 3313, 3344, 3409, 3651, 3669, 3756, 3824, 3891, 3916, 3956, 3961, 4008, 4147, 4251, 4262, 4302, 4324, 4362, 4576, 4644, 4786, 4792, 4796, 4843, 4853, 4874, 4892, 4919, 4966, 4981, 4989, 5155, 5304, 5441, 5470, 5483, 5709, 6138, 6229, 6250, 6309, 6315, 6474, 6500, 6633, 6847, 7097, 7136, 7181, 7185, 7202, 7590, 7646, 7833, 7874, 7950, 7956, 8091, 8140, 8177, 8188, 8432, 8598, 8738, 8744, 8765, 8801, 8855, 8995, 9060, 9107, 9154, 9248, 9283, 9392, 9486, 9747, 9768, 9915, 10068, 10084, 10213, 10239, 10243, 10283, 10292, 10511, 10515, 10540, 10889, 11002, 11123, 11345, 11374, 11470, 11509, 11556, 11568, 11666, 11789, 11797, 12011, 12018, 12061, 12082, 12122, 12127, 12127, 12287, 12306, 12381, 12393, 12536, 12569, 12637, 12750, 12916, 12957, 12984, 13056, 13225, 13321, 13387, 13408, 13415, 13574, 13592, 13606, 13659, 13846, 13855, 13863, 13900, 13930, 13984, 14213, 14329, 14338, 14368, 14435, 14501, 14559, 14661, 14747, 14806, 14858, 15038, 15096, 15167, 15251, 15304, 15311, 15335, 15380, 15419, 15439, 15445, 15447, 15483, 15545, 15695, 15757, 15996, 16047, 16187, 16235, 16416, 16471, 16553, 16683, 16725, 16778, 16918, 17222, 17330, 17363, 17380, 17645, 17697, 17802, 17804, 17896, 17949, 18122, 18125, 18381, 18399, 18432, 18805, 18878, 19099, 19296, 19315, 19329, 19424, 19434, 19535, 19614, 19651, 19655, 19728, 19747 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(54, result.number);
            Assert.AreEqual(2375609, result.newNumber);
        }


        [TestMethod]
        public void TestMethod348()
        {
            int[] numbers = new int[] { 349, 545, 739, 776, 809, 855, 951, 1028, 1311, 1394, 1406, 1629, 1659, 1662, 1838, 2163, 2208, 2477, 2535, 2555, 2643, 2947, 3014, 3123, 3141, 3372, 3422, 3515, 3688, 3848, 3866, 3905, 4046, 4057, 4111, 4320, 4322, 4344, 4551, 4732, 4791, 4856, 4910, 5011, 5069, 5105, 5127, 5165, 5517, 5570, 5584, 5596, 5678, 5719, 5777, 5800, 5936, 6136, 6494, 6771, 6804, 7053, 7073, 7291, 7597, 7627, 7745, 7754, 7808, 7828, 7985, 8303, 8332, 8498, 8605, 8655, 8810, 8824, 8847, 8891, 9048, 9233, 9464, 9572, 10092, 10265, 10429, 10504, 10506, 10510, 10979, 11353, 11479, 11515, 11581, 11882, 12064, 12120, 12334, 12377, 12392, 12515, 12646, 12712, 12771, 12924, 12984, 13063, 13215, 13251, 13362, 13601, 13676, 13820, 13881, 13925, 14102, 14113, 14460, 14595, 14601, 14641, 14690, 14780, 15061, 15120, 15227, 15319, 15494, 15636, 15728, 15863, 15872, 16026, 16034, 16038, 16224, 16299, 16359, 16685, 16722, 16814, 16876, 16988, 17078, 17287, 17400, 17538, 17657, 17950, 17999, 18105, 18176, 18208, 18225, 18238, 18294, 18798, 18868, 18893, 19058, 19194, 19285, 19328, 19457, 19481, 19607, 19747, 19761, 19977 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(349, result.number);
            Assert.AreEqual(1717677, result.newNumber);
        }


        [TestMethod]
        public void TestMethod349()
        {
            int[] numbers = new int[] { 7, 69, 105, 157, 158, 200, 407, 415, 777, 907, 945, 967, 970, 1029, 1187, 1234, 1324, 1350, 1386, 1426, 1488, 1592, 1644, 1659, 1851, 2081, 2252, 2325, 2343, 2356, 2412, 2423, 2482, 2604, 2611, 2612, 2715, 2727, 2821, 2954, 2966, 2967, 2970, 2989, 3041, 3114, 3138, 3168, 3353, 3467, 3469, 3510, 3549, 3549, 3579, 3616, 3700, 3731, 3751, 3815, 3870, 3909, 3957, 4098, 4105, 4114, 4180, 4184, 4188, 4279, 4286, 4334, 4347, 4524, 4585, 4717, 4718, 4739, 4776, 4810, 4860, 4948, 5071, 5128, 5146, 5191, 5256, 5267, 5281, 5357, 5535, 5555, 5594, 5618, 5731, 5781, 5821, 5880, 5949, 6189, 6220, 6263, 6276, 6466, 6470, 6487, 6635, 6790, 6828, 6979, 7060, 7135, 7145, 7180, 7234, 7271, 7351, 7488, 7567, 7696, 7734, 7759, 7783, 7789, 7808, 7836, 7848, 8052, 8214, 8226, 8405, 8668, 8788, 8833, 8888, 8926, 8931, 9032, 9063, 9133, 9206, 9230, 9433, 9453, 9471, 9508, 9571, 9653, 9669, 9690, 9771, 9889, 9926, 9976, 10124, 10127, 10317, 10339, 10373, 10449, 10729, 10748, 10752, 10890, 10907, 11054, 11061, 11092, 11261, 11276, 11329, 11381, 11392, 11398, 11954, 12044, 12076, 12209, 12218, 12233, 12346, 12472, 12479, 12545, 12649, 12655, 12690, 12837, 12869, 12914, 13122, 13124, 13323, 13356, 13479, 13657, 13666, 13671, 13844, 13882, 13904, 14074, 14122, 14135, 14156, 14189, 14312, 14320, 14334, 14405, 14446, 14898, 15060, 15085, 15146, 15231, 15241, 15258, 15313, 15349, 15350, 15435, 15455, 15605, 15659, 15673, 15741, 15743, 15743, 15873, 16009, 16096, 16122, 16241, 16572, 16736, 16738, 16767, 16799, 16820, 16850, 16988, 17113, 17383, 17391, 17397, 17419, 17483, 17496, 17497, 17535, 17613, 17734, 17907, 18061, 18179, 18226, 18347, 18389, 18463, 18546, 18600, 18680, 18768, 18779, 18886, 18904, 18908, 19007, 19051, 19056, 19187, 19190, 19398, 19408, 19414, 19437, 19462, 19484, 19490, 19499, 19542, 19557, 19567, 19627, 19643, 19682, 19713, 19730, 19782, 19785, 19793, 19816, 19846, 19852, 19856, 19894 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(157, result.number);
            Assert.AreEqual(2999322, result.newNumber);
        }


        [TestMethod]
        public void TestMethod350()
        {
            int[] numbers = new int[] { 11, 34, 71, 100, 211, 218, 542, 678, 680, 688, 767, 830, 863, 1312, 1374, 1514, 1865, 1989, 2010, 2028, 2041, 2213, 2235, 2276, 2297, 2444, 2499, 2550, 2646, 2730, 3137, 3282, 3400, 3490, 3524, 3609, 3862, 4443, 4456, 4485, 4518, 4930, 4963, 4964, 5015, 5037, 5155, 5182, 5219, 5341, 5542, 5544, 5616, 5716, 5799, 5843, 5861, 5907, 6130, 6406, 6470, 6575, 6884, 6886, 6970, 7002, 7097, 7327, 7438, 7457, 7509, 7663, 7718, 7791, 7808, 7894, 7918, 8042, 8092, 8191, 8218, 8232, 8291, 8371, 8436, 8441, 8488, 8567, 8578, 8654, 8988, 9005, 9048, 9067, 9200, 9565, 9578, 9721, 9729, 9750, 10270, 10632, 10666, 10676, 10928, 10944, 10950, 10951, 11073, 11409, 11437, 11710, 11852, 11897, 11999, 12190, 12447, 13032, 13256, 13294, 13318, 13385, 13840, 13880, 14030, 14108, 14355, 14358, 14409, 14480, 14693, 14771, 14958, 15109, 15209, 15352, 15543, 15767, 15792, 15811, 15878, 15883, 16085, 16097, 16115, 16179, 16578, 16646, 16857, 17135, 17482, 17483, 17511, 17521, 17549, 17560, 17779, 17941, 17982, 17987, 17992, 17993, 18124, 18216, 18229, 18355, 18633, 18667, 18741, 18802, 19176, 19184, 19218, 19280, 19372, 19376, 19387, 19410, 19628, 19802, 19986 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(100, result.number);
            Assert.AreEqual(1776004, result.newNumber);
        }


        [TestMethod]
        public void TestMethod351()
        {
            int[] numbers = new int[] { 273, 307, 384, 400, 602, 679, 852, 953, 1151, 1244, 1450, 1656, 2012, 2069, 2109, 2111, 2299, 2355, 2392, 2567, 2764, 2852, 3084, 3228, 3466, 3513, 3516, 3658, 3690, 3788, 3790, 3805, 3933, 4043, 4062, 4131, 4216, 4606, 4854, 4922, 4975, 5000, 5060, 5092, 5172, 5191, 5583, 5802, 5899, 5907, 6012, 6236, 6238, 6243, 6332, 6397, 6404, 6549, 6635, 6711, 6862, 7067, 7135, 7594, 7792, 7832, 7885, 8004, 8081, 8116, 8327, 8394, 8445, 8569, 8635, 8660, 8805, 9107, 9168, 9322, 9612, 9661, 9782, 9871, 9892, 9903, 9998, 10012, 10031, 10165, 10193, 10199, 10214, 10274, 10276, 10458, 10474, 10761, 10801, 10904, 11213, 11340, 11397, 11504, 11546, 11607, 11740, 11792, 11798, 11869, 11883, 11893, 11981, 12051, 12111, 12366, 12426, 12520, 12683, 13110, 13254, 13464, 13659, 13665, 13726, 13855, 13902, 13961, 14022, 14029, 14054, 14190, 14247, 14260, 14282, 14289, 14339, 14466, 14496, 14654, 14661, 14775, 14863, 14947, 15091, 15167, 15220, 15256, 15396, 15398, 15431, 15478, 15595, 15728, 15810, 15915, 15933, 15942, 15967, 15987, 16128, 16170, 16212, 16361, 16440, 16588, 16615, 16813, 16856, 16874, 16891, 16980, 17159, 17238, 17259, 17437, 17551, 17562, 17643, 17692, 17698, 17899, 18049, 18069, 18118, 18123, 18208, 18305, 18497, 18562, 18757, 18785, 18842, 19135, 19265, 19305, 19536, 19539, 19539, 19607, 19657, 19939, 19976 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(307, result.number);
            Assert.AreEqual(2184228, result.newNumber);
        }


        [TestMethod]
        public void TestMethod352()
        {
            int[] numbers = new int[] { 441, 1339, 5153, 5999, 6398, 9648, 10499, 14804, 19151 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(441, result.number);
            Assert.AreEqual(1, result.newNumber);
        }


        [TestMethod]
        public void TestMethod353()
        {
            int[] numbers = new int[] { 47, 105, 179, 183, 353, 380, 404, 413, 692, 754, 810, 828, 854, 866, 1004, 1184, 1196, 1367, 1380, 1403, 1623, 1633, 1645, 1662, 1718, 1889, 1945, 2007, 2012, 2014, 2023, 2181, 2347, 2545, 2545, 2628, 2671, 2697, 2708, 2727, 2770, 2926, 2948, 3383, 3518, 3547, 3652, 3706, 3757, 3775, 3784, 3909, 3976, 4000, 4176, 4219, 4388, 4481, 4526, 4642, 4655, 4661, 4683, 4750, 4949, 4950, 4987, 4987, 5210, 5326, 5436, 5632, 5666, 5682, 5701, 5765, 5794, 5847, 5880, 5885, 6091, 6189, 6581, 6690, 6799, 6851, 6852, 6884, 6890, 6916, 7058, 7068, 7087, 7155, 7227, 7282, 7286, 7312, 7326, 7533, 7952, 7976, 8028, 8159, 8217, 8284, 8389, 8416, 8459, 8662, 8773, 8817, 8819, 8862, 8893, 8897, 8914, 8963, 9034, 9164, 9278, 9306, 9424, 9440, 9456, 9502, 9628, 9732, 9873, 9923, 9928, 9969, 10074, 10098, 10182, 10478, 10537, 10630, 10658, 10688, 10719, 10751, 10802, 10841, 10953, 11032, 11165, 11187, 11249, 11290, 11459, 11515, 11518, 11584, 11593, 11731, 11800, 12232, 12242, 12411, 12450, 12608, 12671, 12700, 12710, 12795, 12804, 12909, 12977, 13159, 13241, 13304, 13524, 13652, 13745, 13845, 14008, 14069, 14142, 14145, 14165, 14344, 14512, 14554, 14700, 14881, 14955, 14971, 14972, 15046, 15318, 15398, 15406, 15412, 15446, 15714, 15791, 15882, 15930, 15979, 15998, 16115, 16155, 16176, 16241, 16260, 16324, 16357, 16396, 16411, 16439, 16568, 16634, 16652, 16656, 16725, 16823, 16908, 16939, 16984, 16990, 16995, 17079, 17213, 17317, 17318, 17363, 17370, 17487, 17682, 17800, 17831, 17891, 17980, 18004, 18006, 18099, 18114, 18148, 18204, 18209, 18217, 18314, 18343, 18355, 18393, 18441, 18759, 18896, 18940, 18990, 19191, 19209, 19386, 19603, 19635, 19742, 19801 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(183, result.number);
            Assert.AreEqual(2567920, result.newNumber);
        }


        [TestMethod]
        public void TestMethod354()
        {
            int[] numbers = new int[] { 17, 1136, 1234, 1620, 1808, 1909, 3093, 3463, 3971, 4095, 4130, 4532, 4664, 4891, 4983, 5211, 5667, 5669, 5771, 6692, 6974, 7034, 7055, 7407, 7596, 7926, 8009, 8077, 8476, 8536, 8682, 8717, 8976, 10067, 10156, 10251, 10254, 10345, 10983, 11201, 11847, 12025, 12523, 12781, 12944, 13550, 13639, 13887, 13923, 13968, 15145, 15296, 15699, 15824, 16596, 16742, 16770, 17974, 18472, 18613, 18671, 18687, 18798, 19042, 19199, 19529, 19599 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(17, result.number);
            Assert.AreEqual(668327, result.newNumber);
        }


        [TestMethod]
        public void TestMethod355()
        {
            int[] numbers = new int[] { 59, 219, 262, 673, 984, 1205, 1282, 1331, 1336, 1381, 1562, 1856, 1900, 1947, 2436, 2482, 2741, 2930, 3071, 3403, 3572, 3573, 3585, 3791, 3847, 3985, 4203, 4218, 4372, 4503, 5116, 5357, 5437, 5491, 5545, 5963, 6015, 6424, 6426, 6450, 6520, 6694, 6827, 7009, 7175, 7415, 7512, 7791, 8002, 8187, 8428, 8908, 9027, 9127, 9166, 9166, 9601, 9693, 9820, 9838, 9916, 9939, 10023, 10070, 10196, 10346, 10405, 10537, 11024, 11366, 11706, 11707, 11745, 11780, 11946, 12009, 12330, 12425, 12437, 12709, 12728, 12818, 12827, 12940, 13027, 13427, 13578, 13598, 13642, 13702, 14564, 14685, 14870, 14929, 15132, 15655, 15688, 16201, 16393, 16419, 16421, 16437, 16615, 16768, 16769, 16976, 17129, 17143, 17249, 17353, 17433, 17767, 17799, 18073, 18159, 18429, 18438, 18509, 18978, 19083, 19199, 19292, 19368, 19513, 19625, 19853, 19907 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(262, result.number);
            Assert.AreEqual(1291310, result.newNumber);
        }


        [TestMethod]
        public void TestMethod356()
        {
            int[] numbers = new int[] { 72, 79, 129, 173, 314, 442, 585, 669, 731, 935, 1014, 1237, 1372, 1458, 1548, 1611, 1921, 1934, 2320, 2505, 2592, 2771, 2837, 2862, 2865, 2889, 2894, 2940, 2944, 2998, 3220, 3293, 3322, 3481, 3538, 3561, 3602, 3752, 3757, 3798, 3837, 4051, 4062, 4102, 4218, 4638, 4675, 4845, 4969, 4992, 5185, 5279, 5458, 5498, 5507, 5570, 5665, 5686, 5699, 5883, 6084, 6205, 6212, 6215, 6236, 6361, 6410, 6610, 6818, 6917, 6979, 7060, 7110, 7170, 7359, 7400, 7605, 7684, 7742, 7827, 7919, 7925, 8031, 8129, 8447, 8808, 8884, 9051, 9150, 9211, 9232, 9279, 9287, 9378, 9585, 9586, 9676, 9786, 9835, 10157, 10242, 10247, 10376, 10408, 10436, 10583, 10633, 10648, 10709, 10715, 10741, 10799, 10817, 11002, 11067, 11105, 11139, 11255, 11286, 11295, 11312, 11564, 11574, 11692, 11707, 11844, 11904, 11935, 11964, 12118, 12427, 12469, 12632, 12789, 13116, 13300, 13375, 13557, 13635, 13636, 13686, 13714, 13886, 13941, 14000, 14202, 14298, 14374, 14443, 14816, 14875, 14999, 15093, 15324, 15336, 15460, 15483, 15498, 15521, 15535, 15576, 15655, 15679, 15804, 15821, 15866, 15961, 16152, 16170, 16268, 16291, 16308, 16480, 16522, 16623, 16643, 16684, 16708, 17018, 17110, 17307, 17319, 17322, 17408, 17425, 17561, 17600, 17765, 17927, 17976, 18052, 18117, 18156, 18360, 18469, 18473, 18513, 18528, 18786, 18878, 18953, 18959, 19027, 19135, 19136, 19222, 19251, 19378 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(79, result.number);
            Assert.AreEqual(2098606, result.newNumber);
        }


        [TestMethod]
        public void TestMethod357()
        {
            int[] numbers = new int[] { 55, 112, 317, 449, 460, 817, 1083, 1277, 1408, 1520, 1762, 1797, 2195, 2220, 2543, 2548, 2612, 2926, 3008, 3251, 3729, 4791, 4920, 5185, 5186, 5253, 5278, 5293, 5607, 5873, 5918, 5934, 6181, 6185, 6327, 6376, 6486, 7047, 7443, 7560, 7872, 8260, 8284, 8321, 8526, 8572, 8665, 8858, 9647, 9791, 10014, 10060, 10082, 10298, 10611, 10785, 10932, 11619, 11791, 11795, 12119, 12173, 12257, 12466, 12650, 13028, 13402, 13676, 13710, 14438, 14776, 14887, 15091, 15100, 15724, 15823, 16241, 16285, 16827, 16839, 16949, 17034, 17256, 17356, 17364, 17656, 17756, 18059, 18264, 18435, 18779, 18809, 18810, 18827, 18828, 19611, 19626, 19783 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(460, result.number);
            Assert.AreEqual(955562, result.newNumber);
        }


        [TestMethod]
        public void TestMethod358()
        {
            int[] numbers = new int[] { 8, 68, 131, 135, 146, 189, 193, 382, 441, 563, 579, 639, 650, 668, 672, 740, 743, 787, 827, 1145, 1210, 1288, 1352, 1554, 1609, 1983, 1994, 2013, 2139, 2148, 2186, 2225, 2307, 2327, 2348, 2364, 2637, 2653, 2707, 2979, 3004, 3051, 3055, 3066, 3094, 3114, 3128, 3147, 3196, 3399, 3474, 3573, 3583, 3651, 3704, 3716, 3767, 3841, 3843, 3908, 3971, 3988, 4041, 4453, 4669, 4814, 4859, 5043, 5169, 5193, 5209, 5241, 5425, 5768, 5790, 5967, 6292, 6294, 6425, 6433, 6483, 6488, 6494, 6546, 6715, 6729, 6842, 6881, 6896, 6908, 7212, 7316, 7336, 7353, 7355, 7584, 7676, 7865, 7955, 7975, 8254, 8269, 8306, 8342, 8416, 8427, 8430, 8436, 8453, 8462, 8722, 8761, 8808, 8843, 8870, 9043, 9088, 9110, 9192, 9262, 9285, 9295, 9358, 9427, 9457, 9639, 9717, 9858, 9874, 10029, 10059, 10100, 10104, 10131, 10158, 10175, 10284, 10423, 10447, 10452, 10539, 10599, 10632, 10646, 10683, 10705, 10745, 10805, 10867, 10907, 10937, 11090, 11095, 11102, 11145, 11298, 11381, 11382, 11488, 11491, 11846, 11876, 11941, 11965, 11966, 11976, 12055, 12065, 12122, 12134, 12136, 12223, 12255, 12290, 12307, 12470, 12515, 12592, 12712, 12730, 12739, 13111, 13123, 13126, 13133, 13153, 13222, 13357, 13551, 13551, 13701, 13760, 13999, 14017, 14058, 14162, 14219, 14226, 14256, 14361, 14365, 14431, 14599, 14659, 14678, 14799, 14808, 14822, 14903, 15098, 15265, 15316, 15484, 15618, 15713, 15810, 15952, 15982, 16146, 16226, 16266, 16364, 16369, 16423, 16603, 16640, 16702, 16938, 16984, 16988, 17042, 17060, 17138, 17194, 17397, 17412, 17533, 17647, 17672, 17727, 17797, 17906, 18086, 18152, 18213, 18315, 18463, 18489, 18548, 18554, 18565, 18674, 18733, 18748, 18833, 18837, 18838, 18857, 18920, 18974, 18976, 19006, 19108, 19276, 19342, 19347, 19656, 19722, 19723, 19734, 19761, 19767, 19781, 19837, 19838, 19889, 19946, 19965, 19973 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(189, result.number);
            Assert.AreEqual(2862905, result.newNumber);
        }


        [TestMethod]
        public void TestMethod359()
        {
            int[] numbers = new int[] { 91, 184, 268, 367, 372, 372, 415, 567, 613, 703, 858, 870, 881, 894, 906, 942, 996, 1037, 1139, 1142, 1159, 1170, 1233, 1242, 1289, 1307, 1333, 1334, 1370, 1402, 1419, 1569, 1631, 1665, 1806, 1986, 2036, 2064, 2102, 2259, 2308, 2351, 2361, 2418, 2509, 2550, 2613, 2698, 2806, 3011, 3033, 3054, 3164, 3226, 3277, 3283, 3338, 3357, 3393, 3417, 3456, 3538, 3578, 3617, 3633, 3638, 3737, 3786, 3858, 3876, 3988, 3989, 4240, 4508, 4585, 4590, 4598, 4809, 4828, 4841, 4971, 5036, 5202, 5228, 5276, 5299, 5340, 5402, 5467, 5550, 5732, 5763, 5785, 5859, 6217, 6239, 6269, 6532, 6538, 6571, 6674, 6732, 6752, 6756, 6799, 6873, 6938, 6981, 7083, 7150, 7159, 7186, 7277, 7285, 7306, 7354, 7622, 7657, 7662, 7832, 7901, 8026, 8117, 8145, 8287, 8767, 8909, 8915, 8925, 8974, 9026, 9139, 9189, 9322, 9413, 9679, 9681, 9709, 9752, 9814, 9817, 9863, 9866, 9889, 9966, 9983, 10052, 10180, 10270, 10311, 10331, 10349, 10365, 10446, 10709, 10858, 10976, 11006, 11058, 11148, 11153, 11169, 11265, 11276, 11482, 11535, 11663, 11798, 11883, 11911, 11997, 12001, 12072, 12102, 12227, 12285, 12301, 12307, 12311, 12340, 12449, 12543, 12578, 12613, 12695, 12750, 12802, 12878, 12949, 13155, 13164, 13164, 13172, 13248, 13547, 13606, 13641, 13670, 13996, 14021, 14294, 14306, 14307, 14321, 14356, 14373, 14396, 14412, 14465, 14519, 14595, 14632, 14659, 14707, 15040, 15095, 15384, 15397, 15565, 15567, 15642, 15648, 15674, 15679, 15734, 16408, 16446, 16541, 16769, 16825, 16983, 17007, 17151, 17170, 17409, 17569, 17706, 17741, 17744, 18106, 18237, 18241, 18303, 18612, 18814, 18910, 18927, 18953, 18959, 18959, 18982, 19010, 19033, 19036, 19041, 19104, 19305, 19618, 19779, 19849 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(372, result.number);
            Assert.AreEqual(2337043, result.newNumber);
        }


        [TestMethod]
        public void TestMethod360()
        {
            int[] numbers = new int[] { 45, 149, 321, 463, 476, 515, 562, 592, 600, 646, 695, 733, 775, 789, 791, 944, 1001, 1064, 1141, 1245, 1337, 1383, 1473, 1639, 1652, 1766, 1783, 1806, 1806, 2244, 2244, 2483, 2545, 2549, 2564, 2584, 2693, 2696, 2755, 2765, 2898, 3076, 3077, 3126, 3199, 3333, 3436, 3476, 3592, 3720, 4020, 4076, 4245, 4349, 4579, 4632, 4635, 4725, 4845, 4933, 4934, 4964, 4985, 4991, 5264, 5271, 5396, 5425, 5447, 5481, 5492, 5496, 5589, 5648, 5662, 5674, 5722, 5785, 5843, 5862, 5878, 6010, 6043, 6048, 6137, 6259, 6310, 6396, 6403, 6454, 6583, 6686, 6699, 6735, 6741, 6745, 6851, 6914, 6918, 6943, 6979, 7054, 7342, 7405, 7421, 7435, 7437, 7459, 7495, 7538, 7541, 7579, 7866, 7868, 8048, 8081, 8105, 8135, 8293, 8342, 8459, 8512, 8660, 8700, 8706, 8714, 8802, 8829, 8855, 8906, 8919, 9008, 9080, 9186, 9189, 9277, 9466, 9521, 9578, 9590, 9597, 9629, 9650, 9839, 9918, 9928, 9963, 10040, 10118, 10352, 10467, 10506, 10524, 10559, 10635, 10653, 10667, 10709, 10752, 10781, 10814, 11063, 11198, 11425, 11430, 11613, 11660, 11678, 11883, 11927, 11980, 12090, 12101, 12221, 12302, 12308, 12313, 12330, 12422, 12431, 12446, 12473, 12502, 12512, 12618, 12647, 12673, 12766, 12805, 12949, 13013, 13019, 13094, 13505, 13522, 13549, 13566, 13583, 13593, 13910, 13932, 14084, 14109, 14150, 14264, 14432, 14465, 14490, 14598, 14629, 14630, 14647, 14877, 14878, 15134, 15141, 15192, 15194, 15197, 15258, 15269, 15316, 15491, 15531, 15646, 15663, 15664, 15805, 15837, 15996, 15997, 16078, 16133, 16156, 16213, 16216, 16237, 16390, 16401, 16410, 16521, 16549, 16567, 16597, 16700, 16712, 16733, 16749, 16753, 16772, 16827, 17081, 17087, 17104, 17115, 17138, 17209, 17259, 17568, 17665, 17668, 17677, 17905, 17917, 17947, 18021, 18090, 18107, 18112, 18251, 18398, 18574, 18688, 18760, 18772, 18874, 18943, 19075, 19147, 19230, 19238, 19259, 19459, 19465, 19478, 19717, 19804, 19853, 19879, 19942, 19987 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(45, result.number);
            Assert.AreEqual(2942147, result.newNumber);
        }


        [TestMethod]
        public void TestMethod361()
        {
            int[] numbers = new int[] { 334, 582, 613, 636, 637, 672, 704, 705, 736, 789, 1080, 1100, 1218, 1285, 1326, 1338, 1343, 1589, 1658, 1772, 1828, 1858, 1914, 2005, 2051, 2198, 2231, 2254, 2312, 2399, 2504, 2689, 2741, 2747, 3221, 3284, 3348, 3382, 3613, 3841, 3906, 4137, 4160, 4282, 4333, 4401, 4592, 4641, 4708, 4870, 4974, 5008, 5099, 5104, 5441, 5452, 5510, 5596, 5636, 5643, 5723, 6068, 6088, 6296, 6299, 6462, 6498, 6852, 6900, 7011, 7110, 7196, 7380, 7524, 7587, 7601, 7644, 7821, 8118, 8144, 8371, 8382, 8525, 8735, 8809, 8967, 9025, 9131, 9142, 9279, 9403, 9682, 9873, 10040, 10204, 10356, 10477, 10657, 10694, 10727, 11178, 11233, 11372, 11472, 11492, 11517, 11602, 11764, 11976, 12355, 12390, 12407, 12692, 12810, 12972, 13324, 13496, 13547, 13612, 13638, 13906, 13909, 14090, 14116, 14486, 14497, 14603, 14673, 14839, 14971, 15103, 15282, 15331, 15415, 15422, 15460, 15641, 15683, 15704, 15755, 15761, 15919, 16069, 16205, 16309, 16757, 16762, 16791, 16802, 17466, 17563, 17569, 17992, 18072, 18188, 18391, 18491, 18769, 18906, 19049, 19142, 19194, 19426, 19442, 19761, 19800, 19804 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(334, result.number);
            Assert.AreEqual(1527082, result.newNumber);
        }


        [TestMethod]
        public void TestMethod362()
        {
            int[] numbers = new int[] { 146, 366, 726, 847, 1306, 1582, 2238, 2336, 2377, 3040, 4308, 4530, 4922, 5033, 5460, 5533, 5591, 5591, 5879, 5931, 6187, 6298, 6896, 7102, 7139, 7154, 7217, 7264, 7641, 7839, 8317, 8675, 8675, 9043, 9103, 9275, 9631, 9877, 10264, 10535, 10848, 11649, 11734, 11940, 12296, 12490, 12794, 12982, 13633, 13832, 14596, 14624, 14975, 15045, 15629, 16267, 16402, 16624, 16887, 16905, 17773, 17949, 17965, 18069, 18268, 18336, 18436, 18743, 18990, 19475 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(847, result.number);
            Assert.AreEqual(687132, result.newNumber);
        }


        [TestMethod]
        public void TestMethod363()
        {
            int[] numbers = new int[] { 55, 104, 109, 148, 200, 304, 351, 502, 588, 736, 789, 793, 940, 1014, 1052, 1057, 1082, 1197, 1207, 1248, 1395, 1608, 1730, 1742, 1890, 2089, 2117, 2148, 2203, 2456, 2456, 2491, 2500, 2856, 2857, 2925, 2988, 3080, 3108, 3364, 3432, 3478, 3629, 3788, 3928, 3960, 4312, 4351, 4392, 4466, 4567, 4596, 4648, 4651, 4668, 4717, 4735, 4789, 4878, 4914, 4966, 5110, 5139, 5231, 5251, 5363, 5558, 5987, 6013, 6044, 6051, 6137, 6141, 6188, 6192, 6258, 6451, 6833, 6850, 6869, 6978, 7058, 7134, 7189, 7239, 7251, 7416, 7494, 7602, 7623, 7653, 7724, 7770, 7906, 8029, 8100, 8121, 8369, 8460, 8471, 8557, 8574, 8585, 8991, 9113, 9196, 9439, 9495, 9542, 9570, 9728, 9740, 9973, 10177, 10237, 10251, 10311, 10350, 10373, 10477, 10653, 10700, 10762, 10937, 11202, 11325, 11509, 11570, 11622, 11631, 11771, 11773, 11918, 11981, 12090, 12144, 12153, 12218, 12250, 12273, 12406, 12465, 12580, 12599, 12601, 12629, 12692, 12705, 12763, 12951, 13104, 13166, 13282, 13303, 13557, 13712, 13732, 13908, 13958, 13996, 14060, 14212, 14346, 14385, 14420, 14458, 14601, 14679, 14749, 14774, 15063, 15155, 15218, 15225, 15288, 15358, 15391, 15413, 15567, 15632, 15642, 15646, 15661, 15710, 15714, 15735, 15807, 15858, 15884, 15959, 15992, 15996, 16110, 16168, 16408, 16656, 16686, 16702, 16714, 16760, 16802, 16870, 16912, 16974, 17002, 17046, 17135, 17195, 17225, 17346, 17430, 17462, 17631, 17660, 17739, 17768, 17960, 17999, 18144, 18299, 18494, 18498, 18597, 18611, 18681, 18751, 18940, 19068, 19114, 19159, 19360, 19417, 19502, 19740, 19752, 19753, 19869, 19910, 19925 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(104, result.number);
            Assert.AreEqual(2439767, result.newNumber);
        }


        [TestMethod]
        public void TestMethod364()
        {
            int[] numbers = new int[] { 242, 681, 1962, 5098, 5184, 6178, 6420, 7237, 7313, 7498, 7798, 8132, 8731, 9707, 10898, 10978, 12380, 12690, 12723, 12761, 16365, 16764, 16894, 18221, 18506, 18512, 18632, 19199 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(242, result.number);
            Assert.AreEqual(261513, result.newNumber);
        }


        [TestMethod]
        public void TestMethod365()
        {
            int[] numbers = new int[] { 328, 572, 713, 817, 911, 1203, 1374, 1380, 1542, 1705, 1731, 1745, 1837, 1910, 1920, 2000, 2149, 2196, 2703, 2802, 2803, 2912, 2993, 3107, 3339, 3409, 3411, 3549, 3596, 3849, 3974, 3989, 4119, 4209, 4526, 4595, 4821, 4832, 4916, 4919, 5084, 5313, 5624, 5662, 5735, 5745, 6012, 6028, 6087, 6094, 6224, 6297, 6448, 6451, 6712, 6912, 7128, 7296, 7410, 7496, 7499, 7534, 7645, 7671, 7937, 7954, 8224, 8296, 8303, 8320, 8352, 8370, 8512, 8881, 8936, 9121, 9161, 9167, 9462, 9501, 9912, 9917, 9997, 10192, 10492, 10520, 10613, 11121, 11166, 11344, 11921, 12022, 12218, 12258, 12405, 12448, 12513, 12586, 12895, 13330, 13585, 13635, 13738, 13808, 13897, 13956, 13964, 13969, 14047, 14257, 14368, 14403, 14452, 14530, 14638, 14836, 15115, 15169, 15333, 15385, 15545, 15815, 15830, 16020, 16062, 16213, 16232, 16271, 16799, 17081, 17170, 17363, 17375, 17511, 17557, 17870, 17876, 17974, 17977, 18170, 18474, 18584, 18597, 18749, 18791, 19028, 19099, 19118, 19412, 19762 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(572, result.number);
            Assert.AreEqual(1443301, result.newNumber);
        }


        [TestMethod]
        public void TestMethod366()
        {
            int[] numbers = new int[] { 92, 110, 145, 410, 425, 440, 457, 820, 1000, 1111, 1174, 1290, 1374, 1485, 1558, 1791, 1820, 1991, 2147, 2193, 2310, 2316, 2327, 2496, 2838, 3110, 3497, 3587, 3599, 3716, 3856, 3919, 3953, 4085, 4198, 4443, 5044, 5131, 5755, 5935, 6038, 6159, 6181, 6193, 6285, 6305, 6358, 6415, 6500, 6561, 6573, 6835, 6887, 7025, 7038, 7086, 7169, 7186, 7278, 7305, 7324, 7478, 7727, 7731, 7894, 7959, 8154, 8255, 8303, 8306, 8767, 9024, 9077, 9104, 9321, 9335, 9551, 9596, 9672, 9672, 9768, 9771, 9801, 9875, 10116, 10298, 10624, 10682, 10773, 10972, 11000, 11042, 11076, 11105, 11396, 11519, 12007, 12629, 12805, 12810, 13062, 13148, 13471, 13546, 13612, 13720, 13753, 13963, 14044, 14290, 14342, 14429, 14485, 14626, 14977, 15003, 15054, 15342, 15606, 15637, 15966, 16065, 16129, 16503, 16560, 16597, 16906, 17150, 17382, 17572, 17758, 17759, 17793, 17930, 18027, 18029, 18275, 18345, 18492, 18614, 18767, 18833, 18847, 18886, 18979, 19047, 19103, 19293, 19321, 19446, 19475, 19524, 19648, 19682, 19797, 19983 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(92, result.number);
            Assert.AreEqual(1563218, result.newNumber);
        }


        [TestMethod]
        public void TestMethod367()
        {
            int[] numbers = new int[] { 20, 130, 237, 306, 318, 465, 567, 715, 930, 1100, 1101, 1302, 1343, 1369, 1383, 1405, 1513, 1881, 1941, 2011, 2257, 2298, 2360, 2390, 2515, 2740, 2792, 3037, 3106, 3113, 3141, 3159, 3202, 3306, 3355, 3371, 3433, 3523, 3538, 3591, 3657, 3844, 3993, 4227, 4229, 4282, 4300, 4436, 4460, 4501, 4519, 4589, 4608, 4625, 4671, 4764, 4781, 4788, 4931, 5046, 5067, 5156, 5226, 5332, 5681, 5822, 5924, 6163, 6171, 6200, 6264, 6369, 6631, 6650, 6675, 7142, 7284, 7352, 7613, 7662, 7781, 7902, 7902, 8071, 8107, 8357, 8379, 8424, 8581, 8625, 8724, 8748, 8756, 8848, 9048, 9128, 9236, 9248, 9267, 9270, 9396, 9457, 9489, 9522, 9591, 9651, 9697, 9732, 9771, 9886, 10097, 10141, 10217, 10235, 10349, 10428, 10493, 10932, 11011, 11070, 11135, 11200, 11271, 11605, 11929, 11986, 12057, 12294, 12469, 12613, 12680, 12704, 12723, 12731, 12871, 12881, 12891, 12997, 13027, 13040, 13119, 13133, 13227, 13308, 13334, 13366, 13400, 13456, 13469, 13584, 13716, 13884, 13893, 13934, 14072, 14084, 14152, 14165, 14375, 14402, 14553, 14594, 14901, 14956, 14970, 15009, 15011, 15163, 15164, 15216, 15249, 15299, 15388, 15403, 15450, 15612, 15647, 15874, 16140, 16339, 16377, 16490, 16519, 16536, 16599, 16599, 16656, 16769, 16775, 16850, 17380, 17565, 17621, 17626, 17661, 17682, 17851, 17897, 18090, 18200, 18324, 18413, 18423, 18525, 18577, 18592, 18627, 18649, 18668, 18751, 18766, 18773, 18779, 18994, 19029, 19141, 19156, 19161, 19237, 19240, 19289, 19365, 19421, 19431, 19459, 19597, 19749, 19769, 19782 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(237, result.number);
            Assert.AreEqual(2389525, result.newNumber);
        }


        [TestMethod]
        public void TestMethod368()
        {
            int[] numbers = new int[] { 398, 737, 756, 827, 961, 974, 1014, 1088, 1181, 1221, 1269, 1354, 1398, 1566, 1567, 1608, 1650, 1788, 1885, 1945, 2148, 2268, 2342, 2532, 2598, 2831, 3010, 3040, 3091, 3108, 3149, 3175, 3272, 3368, 3722, 3836, 3846, 3851, 3932, 4177, 4245, 4529, 4558, 4577, 4828, 4838, 4935, 5189, 5224, 5261, 5290, 5294, 5395, 5439, 5462, 5488, 5491, 5537, 5543, 5578, 5692, 5714, 5892, 5894, 5932, 5966, 5981, 6056, 6056, 6098, 6136, 6150, 6191, 6193, 6215, 6498, 6501, 6559, 6663, 6688, 6715, 7004, 7026, 7030, 7042, 7053, 7207, 7231, 7400, 7424, 7576, 7603, 7653, 7768, 7954, 8055, 8129, 8426, 8586, 8640, 8679, 8724, 8826, 8844, 8928, 9015, 9112, 9114, 9216, 9222, 9262, 9391, 9456, 9601, 9614, 9686, 9739, 9811, 9863, 9889, 9957, 10082, 10095, 10103, 10167, 10182, 10558, 10920, 10987, 11031, 11043, 11056, 11327, 11373, 11592, 11616, 11725, 11820, 11871, 11874, 11880, 12091, 12101, 12199, 12199, 12377, 12386, 12427, 12486, 12578, 12644, 12718, 12749, 12804, 13061, 13223, 13224, 13226, 13419, 13604, 13764, 13806, 13875, 14204, 14204, 14218, 14222, 14251, 14272, 14563, 14573, 14644, 14693, 14971, 15104, 15177, 15249, 15381, 15409, 15435, 15457, 15576, 15732, 15819, 15828, 15856, 15930, 15953, 15954, 15987, 16006, 16066, 16209, 16268, 16375, 16402, 16594, 16666, 16677, 16809, 16820, 16864, 16984, 17098, 17135, 17212, 17503, 17606, 17607, 17628, 17657, 17950, 18014, 18028, 18066, 18156, 18237, 18336, 18413, 18575, 18585, 18840, 18939, 18983, 19110, 19123, 19388, 19577, 19578, 19603, 19779, 19814, 19841, 19971, 19980, 19989 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(398, result.number);
            Assert.AreEqual(2398533, result.newNumber);
        }


        [TestMethod]
        public void TestMethod369()
        {
            int[] numbers = new int[] { 1455, 1870, 2173, 3304, 3590, 4897, 5206, 5900, 6563, 6881, 7163, 7730, 8141, 8386, 9059, 9855, 9969, 10014, 10476, 11602, 11838, 12605, 12909, 13280, 13445, 13573, 14157, 15002, 15604, 16012, 17310, 17439, 18249, 18490, 19009, 19320, 19772 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1455, result.number);
            Assert.AreEqual(371053, result.newNumber);
        }


        [TestMethod]
        public void TestMethod370()
        {
            int[] numbers = new int[] { 780, 897, 1664, 1676, 1707, 1764, 1803, 1806, 2003, 2637, 3103, 3384, 3443, 3530, 4218, 4295, 5099, 5527, 5711, 6017, 6297, 6866, 7385, 7463, 7493, 7785, 7918, 7957, 8844, 8958, 9102, 9123, 9542, 10231, 10570, 10959, 11167, 11713, 12114, 13197, 13483, 13634, 14056, 14209, 14389, 14555, 14825, 15158, 15323, 15480, 15915, 16272, 16569, 16585, 16688, 16706, 16748, 16993, 17181, 17215, 17283, 17634, 18114, 18161, 19309, 19670 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(780, result.number);
            Assert.AreEqual(655982, result.newNumber);
        }


        [TestMethod]
        public void TestMethod371()
        {
            int[] numbers = new int[] { 757, 859, 899, 928, 1053, 1370, 1723, 2525, 2785, 2793, 3215, 3238, 3288, 3297, 3325, 3488, 4145, 4368, 4630, 5363, 5622, 5738, 5740, 5969, 6043, 6109, 6352, 6432, 6882, 7262, 7414, 7762, 8033, 8284, 8651, 8814, 8836, 8978, 9196, 9326, 10689, 10864, 10940, 11572, 12607, 12793, 13156, 13188, 13282, 13297, 13410, 13416, 13480, 13532, 13660, 13955, 14201, 14428, 15127, 15378, 15770, 15779, 16491, 17260, 17368, 17541, 17677, 17690, 17722, 18158, 18415, 19458, 19469, 19911, 19974 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(757, result.number);
            Assert.AreEqual(722665, result.newNumber);
        }


        [TestMethod]
        public void TestMethod372()
        {
            int[] numbers = new int[] { 148, 149, 217, 361, 376, 422, 463, 517, 521, 527, 617, 713, 725, 787, 926, 933, 1038, 1157, 1171, 1173, 1250, 1273, 1287, 1304, 1306, 1615, 1873, 1973, 1983, 2057, 2310, 2353, 2408, 2430, 2455, 2483, 2511, 2529, 2577, 2711, 2715, 2718, 2721, 2779, 2980, 3044, 3082, 3136, 3194, 3213, 3241, 3283, 3310, 3540, 3541, 3604, 3610, 3699, 3817, 3889, 3982, 4039, 4098, 4157, 4519, 4671, 4886, 5058, 5262, 5418, 5426, 5584, 5587, 5920, 6053, 6160, 6254, 6321, 6549, 6771, 6980, 7226, 7287, 7365, 7591, 7675, 7729, 7746, 7964, 7982, 8015, 8038, 8079, 8087, 8188, 8207, 8258, 8297, 8335, 8620, 8989, 9139, 9155, 9225, 9451, 9470, 9503, 9586, 9702, 10035, 10075, 10081, 10197, 10274, 10339, 10492, 10630, 10719, 10733, 10933, 11074, 11109, 11222, 11291, 11345, 11498, 11736, 11787, 11978, 12016, 12059, 12132, 12133, 12152, 12206, 12244, 12311, 12361, 12478, 12489, 12529, 12650, 12708, 12952, 13009, 13018, 13235, 13377, 13450, 13524, 13536, 13822, 13911, 13963, 13970, 13973, 14163, 14293, 14504, 14542, 14626, 14807, 14838, 15159, 15170, 15229, 15259, 15339, 15553, 15592, 15692, 15746, 15809, 15839, 15944, 15996, 16016, 16062, 16126, 16210, 16380, 16390, 16528, 16564, 16638, 16678, 16695, 16870, 16872, 17054, 17230, 17245, 17268, 17328, 17366, 17415, 17431, 17445, 17565, 17582, 17740, 18146, 18156, 18326, 18332, 18352, 18372, 18417, 18462, 18508, 18588, 18681, 18740, 18755, 19191, 19313, 19443, 19468, 19501, 19531, 19650, 19713, 19763, 19861, 19911, 19968 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(148, result.number);
            Assert.AreEqual(2233261, result.newNumber);
        }


        [TestMethod]
        public void TestMethod373()
        {
            int[] numbers = new int[] { 807, 1222, 2241, 2480, 2499, 3185, 3532, 3825, 3873, 4349, 4387, 4931, 5088, 5185, 5608, 5698, 5983, 6042, 6346, 6963, 7057, 7176, 7180, 7272, 8670, 9260, 9367, 9694, 10513, 10808, 11547, 11983, 12164, 12391, 12568, 12696, 13090, 13093, 13166, 13441, 13526, 13609, 13756, 13862, 14399, 14496, 14529, 14560, 14579, 14979, 14989, 15205, 15679, 15915, 16059, 16365, 16637, 16675, 17108, 17172, 17178, 17233, 17310, 17487, 17634, 18557, 18923, 19487 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1222, result.number);
            Assert.AreEqual(726795, result.newNumber);
        }


        [TestMethod]
        public void TestMethod374()
        {
            int[] numbers = new int[] { 98, 168, 331, 428, 562, 586, 613, 703, 746, 791, 888, 1073, 1077, 1102, 1248, 1289, 1314, 1511, 1746, 1777, 1924, 2226, 2453, 2530, 2776, 2825, 2849, 2959, 2962, 2990, 3016, 3048, 3298, 3363, 3410, 3619, 3950, 4121, 4134, 4337, 4646, 4664, 4766, 4817, 4938, 5107, 5121, 5249, 5378, 5587, 5643, 5712, 5887, 6079, 6178, 6361, 6421, 6647, 6653, 6789, 6845, 6940, 6969, 6998, 7051, 7154, 7381, 7392, 7401, 7439, 7698, 7741, 8010, 8078, 8174, 8519, 8639, 9060, 9217, 9407, 9465, 9677, 9743, 9785, 9836, 9845, 9984, 10281, 10370, 10428, 10739, 10952, 11026, 11141, 11353, 11440, 11453, 11464, 11528, 11764, 11879, 12087, 12465, 12500, 12501, 12516, 12557, 12584, 12766, 13056, 13122, 13310, 13346, 13404, 13427, 13457, 13484, 13557, 13560, 13579, 13607, 13651, 14067, 14075, 14102, 14129, 14173, 14353, 14385, 14432, 14476, 14525, 14533, 14874, 15088, 15091, 15144, 15293, 15438, 15564, 15798, 15806, 15819, 16059, 16166, 16316, 16540, 16936, 17125, 17139, 17207, 17317, 17373, 17465, 17542, 17583, 17642, 17678, 18043, 18140, 18242, 18519, 18809, 18834, 19007, 19075, 19170, 19370, 19394, 19432, 19483, 19596, 19684, 19775, 19902 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(331, result.number);
            Assert.AreEqual(1737297, result.newNumber);
        }


        [TestMethod]
        public void TestMethod375()
        {
            int[] numbers = new int[] { 20, 39, 45, 176, 214, 319, 373, 385, 569, 648, 688, 743, 807, 1017, 1077, 1079, 1097, 1098, 1292, 1473, 1512, 1675, 1901, 2050, 2451, 2598, 2625, 2801, 2814, 2886, 3011, 3067, 3264, 3284, 3405, 3493, 3533, 3711, 3776, 3861, 3903, 3921, 4250, 4365, 4391, 4399, 4421, 4519, 4571, 4579, 4630, 4764, 4805, 4968, 4969, 5003, 5019, 5038, 5056, 5057, 5102, 5400, 5537, 5688, 5726, 6044, 6155, 6194, 6218, 6266, 6316, 6329, 6427, 6442, 6459, 6496, 6967, 6996, 7197, 7203, 7218, 7253, 7334, 7444, 7467, 7545, 7575, 7597, 7609, 7623, 7786, 7913, 7987, 8013, 8135, 8235, 8374, 8386, 8522, 8538, 8589, 8673, 8683, 8771, 8788, 8793, 8878, 9071, 9238, 9256, 9276, 9314, 9446, 9514, 9597, 9659, 9720, 9947, 9998, 10113, 10293, 10407, 10498, 10639, 10806, 10839, 10909, 10948, 10964, 10979, 11212, 11317, 11385, 11447, 11465, 11504, 11526, 11574, 11669, 11889, 11956, 11988, 12366, 12369, 12513, 12718, 12832, 12898, 12938, 13281, 13317, 13520, 13659, 13829, 13914, 14057, 14060, 14069, 14089, 14114, 14149, 14153, 14183, 14215, 14224, 14278, 14478, 14498, 14585, 14698, 14739, 14751, 14827, 15161, 15229, 15362, 15725, 15727, 15892, 16066, 16117, 16187, 16328, 16330, 16402, 16439, 16497, 16566, 16578, 16596, 16714, 16781, 16800, 16917, 16954, 16993, 17284, 17326, 17500, 17539, 17726, 17732, 17736, 17737, 17918, 18017, 18091, 18177, 18181, 18219, 18259, 18391, 18407, 18615, 18760, 18897, 18908, 18942, 19058, 19215, 19401, 19465, 19527, 19651, 19761 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(20, result.number);
            Assert.AreEqual(2212527, result.newNumber);
        }


        [TestMethod]
        public void TestMethod376()
        {
            int[] numbers = new int[] { 28, 309, 312, 451, 620, 999, 1326, 1625, 1833, 2137, 2422, 2861, 4178, 4214, 4327, 4631, 4858, 4894, 4937, 5215, 5271, 6278, 6880, 7158, 7887, 8102, 8112, 8281, 8487, 8868, 9138, 9587, 9698, 10320, 10677, 11254, 11676, 11885, 12008, 12027, 12128, 13161, 13194, 13205, 13214, 13325, 13752, 13932, 14019, 14194, 14262, 14400, 14487, 14748, 14912, 15112, 15195, 15467, 15748, 15943, 16217, 16252, 16909, 17147, 17298, 17524, 18183, 18311, 18314, 18596, 18608, 18794, 19140, 19282, 19390, 19483, 19987 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(620, result.number);
            Assert.AreEqual(822579, result.newNumber);
        }


        [TestMethod]
        public void TestMethod377()
        {
            int[] numbers = new int[] { 226, 1232, 1543, 1703, 1848, 1918, 2253, 2422, 2537, 2543, 2777, 3309, 3627, 3987, 4274, 5332, 5574, 5779, 6039, 6459, 7005, 7021, 7225, 7255, 7440, 7482, 8844, 8863, 8963, 8996, 8997, 9444, 10222, 10277, 10356, 10741, 11090, 11303, 11321, 11651, 11827, 12066, 12814, 12830, 12861, 12925, 13830, 14522, 14604, 15315, 16007, 16276, 16884, 17042, 17559, 18551, 18605, 18812, 18942, 19112, 19273, 19362, 19374, 19643, 19719, 19772 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(226, result.number);
            Assert.AreEqual(666025, result.newNumber);
        }


        [TestMethod]
        public void TestMethod378()
        {
            int[] numbers = new int[] { 35, 99, 159, 331, 349, 357, 361, 514, 820, 920, 1114, 1246, 1360, 1411, 1415, 1481, 1698, 1790, 1793, 1924, 2051, 2118, 2264, 2265, 2302, 2441, 2484, 2571, 2635, 2682, 2793, 2809, 3088, 3142, 3146, 3234, 3423, 3474, 3540, 3573, 3879, 4213, 4345, 4673, 4780, 4805, 4828, 4961, 4981, 5043, 5140, 5144, 5239, 5242, 5374, 5382, 5438, 5528, 5540, 5567, 5580, 5627, 5747, 5776, 5918, 5930, 5952, 6014, 6071, 6100, 6148, 6233, 6554, 6613, 6854, 6911, 6970, 7259, 7268, 7301, 7400, 7797, 7994, 8122, 8254, 8489, 8550, 8605, 8683, 8712, 8834, 8907, 8941, 9107, 9179, 9188, 9342, 9361, 9539, 9701, 9795, 9874, 9881, 9936, 9961, 9978, 10093, 10116, 10144, 10183, 10217, 10252, 10266, 10369, 10419, 10494, 10546, 10562, 10660, 10812, 10869, 10913, 11107, 11233, 11371, 11462, 11491, 11621, 11720, 11739, 11969, 11986, 12110, 12228, 12228, 12284, 12353, 12381, 12441, 12472, 12484, 12539, 12744, 12759, 12847, 12953, 12978, 13015, 13378, 13385, 13437, 13532, 13573, 13577, 14003, 14042, 14067, 14131, 14244, 14294, 14453, 14607, 15036, 15122, 15193, 15448, 15559, 15623, 15924, 16144, 16250, 16303, 16434, 16475, 16483, 16503, 16533, 16728, 16795, 16901, 17008, 17038, 17084, 17160, 17161, 17314, 17403, 17493, 17678, 17753, 17755, 18084, 18147, 18234, 18378, 18431, 18455, 18463, 18530, 18541, 18553, 18572, 18724, 18811, 18949, 18973, 19167, 19267, 19380, 19431, 19449, 19566, 19575, 19709, 19806, 19903 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(99, result.number);
            Assert.AreEqual(2165394, result.newNumber);
        }


        [TestMethod]
        public void TestMethod379()
        {
            int[] numbers = new int[] { 183, 252, 252, 294, 775, 780, 828, 859, 1817, 1866, 1893, 2096, 2193, 2873, 3124, 3173, 3185, 3327, 3375, 3696, 3723, 4389, 4646, 4770, 5069, 5628, 5708, 5828, 6276, 6558, 6672, 6677, 6770, 6843, 7147, 7455, 7943, 8021, 8592, 9034, 9056, 10312, 10314, 10399, 10767, 11493, 11556, 11660, 12058, 12329, 12383, 12568, 12632, 12901, 13015, 13283, 13332, 13942, 14003, 14289, 14663, 15005, 15022, 16025, 16402, 16501, 16795, 17557, 17895, 17936, 18090, 18098, 18392, 18503, 18726, 18753, 18937, 18957, 19008, 19174, 19394, 19407, 19533, 19652, 19717 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(252, result.number);
            Assert.AreEqual(850085, result.newNumber);
        }


        [TestMethod]
        public void TestMethod380()
        {
            int[] numbers = new int[] { 49, 128, 166, 451, 720, 939, 992, 1177, 1318, 1374, 1485, 1678, 1728, 1908, 1961, 2019, 2121, 2169, 2174, 2243, 2351, 2353, 2418, 2600, 2662, 3109, 3268, 3319, 3595, 3740, 3799, 3838, 3974, 3993, 4060, 4203, 4227, 4283, 4288, 4541, 4667, 4732, 4993, 5172, 5230, 5240, 5260, 5272, 5297, 5305, 5321, 5373, 5522, 5543, 5632, 5831, 5903, 6157, 6214, 6235, 6239, 6256, 6338, 6339, 6425, 6457, 6760, 6868, 6886, 6996, 7021, 7158, 7194, 7276, 7364, 7453, 7484, 7531, 7860, 7887, 8041, 8054, 8153, 8253, 8298, 8433, 8578, 8589, 9120, 9170, 9201, 9414, 9418, 9437, 9546, 9716, 9961, 10103, 10196, 10317, 10521, 10560, 10593, 10631, 10840, 10935, 10972, 11330, 11379, 11426, 11505, 11507, 11528, 11558, 11599, 11622, 11711, 11772, 11790, 11829, 11842, 12281, 12457, 12481, 12515, 12839, 12941, 12997, 13076, 13228, 13229, 13288, 13363, 13381, 13557, 13613, 13732, 13919, 14021, 14219, 14282, 14441, 14534, 14624, 14665, 14831, 14912, 15118, 15342, 15357, 15469, 15488, 15489, 15850, 15936, 16548, 16557, 16601, 16752, 16785, 16800, 16841, 17063, 17449, 17549, 17579, 17642, 17724, 17760, 17764, 18278, 18469, 18603, 18640, 18809, 18920, 19156, 19334, 19402, 19456, 19718, 19771, 19801, 19920, 19921 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(166, result.number);
            Assert.AreEqual(1784852, result.newNumber);
        }


        [TestMethod]
        public void TestMethod381()
        {
            int[] numbers = new int[] { 335, 755, 871, 883, 1040, 1207, 1260, 1297, 1568, 1700, 1917, 2832, 3292, 3525, 3551, 3644, 4037, 4309, 4332, 4385, 4421, 4604, 4963, 5131, 5415, 5570, 5767, 5974, 6161, 6852, 7056, 7375, 7976, 8493, 9057, 9398, 9421, 9456, 9603, 9616, 9807, 9897, 10532, 10937, 11184, 11274, 11411, 11436, 11963, 12220, 12281, 12307, 12449, 12671, 13097, 13286, 13479, 14241, 14448, 14472, 14587, 14778, 14813, 14824, 14939, 15238, 15598, 15709, 15745, 16317, 16353, 16383, 16444, 16875, 17249, 17261, 17653, 17758, 18184, 18362, 18496, 18639, 18765, 19259, 19441, 19509, 19560, 19607, 19641, 19929 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1040, result.number);
            Assert.AreEqual(942150, result.newNumber);
        }


        [TestMethod]
        public void TestMethod382()
        {
            int[] numbers = new int[] { 112, 271, 325, 557, 929, 954, 967, 1088, 1331, 1505, 1707, 1822, 1942, 1998, 2093, 2183, 2189, 2529, 2551, 2587, 2652, 2723, 2837, 2854, 3009, 3106, 3236, 3443, 3494, 3503, 3505, 3516, 3531, 3600, 3670, 3797, 3870, 3964, 3969, 4040, 4096, 4294, 4320, 4434, 4520, 4588, 4591, 4655, 4818, 4987, 5025, 5074, 5144, 5165, 5209, 5246, 5375, 5401, 5449, 5544, 5588, 5608, 5610, 5963, 5974, 5994, 6054, 6056, 6101, 6143, 6239, 6279, 6354, 6379, 6548, 7314, 7357, 7434, 7479, 7544, 7731, 7770, 7824, 8043, 8049, 8068, 8084, 8183, 8324, 8447, 8548, 8590, 8892, 8908, 9298, 9693, 9778, 9800, 10085, 10144, 10398, 10411, 10601, 10672, 10683, 10735, 10808, 10937, 10941, 11070, 11098, 11157, 11392, 11396, 11426, 11488, 11613, 11846, 11851, 11902, 11917, 12108, 12138, 12373, 12503, 12624, 12643, 12660, 12792, 13250, 13483, 13495, 13614, 13747, 13749, 13926, 13996, 14016, 14175, 14281, 14342, 14431, 14567, 14582, 14934, 14950, 15293, 15353, 15424, 15434, 15439, 15496, 15672, 15703, 15737, 15815, 15826, 15901, 15942, 16044, 16300, 16404, 16482, 16615, 16752, 16868, 16934, 16996, 17124, 17283, 17319, 17458, 17516, 17679, 17687, 17769, 17876, 18023, 18227, 18250, 18297, 18466, 18480, 18528, 18534, 18594, 18643, 18767, 18930, 19098, 19166, 19328, 19409, 19500, 19520, 19561, 19730, 19798, 19865 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(271, result.number);
            Assert.AreEqual(1993787, result.newNumber);
        }


        [TestMethod]
        public void TestMethod383()
        {
            int[] numbers = new int[] { 183, 220, 311, 795, 867, 904, 1086, 1089, 1412, 1549, 1550, 1628, 1632, 1774, 1925, 1934, 2078, 2102, 2231, 2269, 2356, 2475, 2522, 2575, 2643, 2662, 2711, 2952, 3008, 3158, 3288, 3356, 3513, 3540, 3704, 3772, 3826, 3951, 4124, 4171, 4313, 4761, 4785, 4833, 4931, 5026, 5072, 5256, 5362, 5400, 5429, 5465, 5629, 5772, 5828, 6050, 6259, 6382, 6517, 6576, 6681, 6973, 7059, 7168, 7200, 7258, 7305, 7310, 7433, 7634, 7667, 7710, 7793, 7859, 7874, 7986, 8042, 8043, 8104, 8518, 8651, 8917, 8923, 9548, 9816, 9920, 9930, 10079, 10185, 10753, 10805, 10888, 11077, 11147, 11233, 11478, 11480, 11670, 11670, 11838, 11840, 11917, 12073, 12227, 12366, 12517, 12626, 12645, 12894, 12928, 12951, 12999, 13037, 13523, 13685, 13774, 13939, 14247, 14327, 14354, 14432, 14734, 14821, 14839, 15077, 15162, 15201, 15721, 16161, 16175, 16549, 16555, 16603, 16626, 16675, 16776, 16819, 17233, 17349, 17404, 17494, 17847, 17952, 18085, 18119, 18178, 18180, 18238, 18304, 18361, 18472, 18548, 18567, 18728, 18869, 18869, 18870, 18877, 19043, 19130, 19144, 19404, 19458, 19471, 19577, 19612, 19664, 19965 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(220, result.number);
            Assert.AreEqual(1665508, result.newNumber);
        }


        [TestMethod]
        public void TestMethod384()
        {
            int[] numbers = new int[] { 29, 148, 260, 336, 342, 366, 672, 781, 835, 1014, 1045, 1074, 1250, 1472, 1486, 1530, 1649, 1671, 1823, 1894, 2006, 2094, 2276, 2578, 2684, 3095, 3107, 3302, 3385, 3486, 3565, 3750, 3863, 3885, 3970, 4069, 4364, 4479, 4774, 5125, 5181, 5212, 5250, 5841, 5905, 5952, 5993, 6082, 6208, 6419, 6522, 6545, 6567, 6599, 6821, 6823, 6951, 7004, 7217, 7265, 7293, 7412, 7460, 7614, 7725, 7884, 7901, 7992, 8350, 8606, 8710, 8779, 8862, 8920, 9138, 9237, 9319, 9377, 9507, 9842, 9957, 10469, 10541, 10623, 10701, 10935, 10945, 10958, 10958, 11530, 11654, 11694, 11885, 11897, 12118, 12389, 12402, 12473, 12594, 12812, 12848, 12905, 12906, 12955, 13324, 13647, 13700, 13724, 13919, 13938, 13979, 14063, 14150, 14211, 14216, 14285, 14394, 14444, 14447, 14624, 14702, 14830, 14832, 14851, 14875, 15069, 15128, 15254, 15261, 15456, 15546, 15554, 15727, 15783, 15998, 16012, 16072, 16315, 16319, 16330, 16334, 16371, 16471, 16590, 16655, 16782, 16840, 16881, 17085, 17254, 17259, 17449, 17478, 17601, 17753, 18035, 18105, 18555, 18653, 18986, 19238, 19267, 19362, 19590, 19595, 19765 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(260, result.number);
            Assert.AreEqual(1663167, result.newNumber);
        }


        [TestMethod]
        public void TestMethod385()
        {
            int[] numbers = new int[] { 313, 617, 1062, 1822, 1836, 1910, 2027, 2053, 2485, 2994, 3048, 4044, 4300, 5147, 6316, 7212, 7551, 7734, 8114, 8637, 9364, 9499, 11536, 11667, 11833, 12004, 12584, 13421, 13514, 13940, 14097, 14134, 14236, 14461, 15042, 15063, 15447, 15460, 15763, 15835, 15911, 15924, 15978, 16477, 16709, 16929, 17776, 17925, 18195, 18227, 18464, 18769, 19086, 19217, 19453, 19477 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1062, result.number);
            Assert.AreEqual(619398, result.newNumber);
        }


        [TestMethod]
        public void TestMethod386()
        {
            int[] numbers = new int[] { 643, 803, 1341, 1423, 1777, 3589, 3684, 3706, 3723, 4251, 4329, 4352, 4516, 4784, 4893, 4903, 5711, 5984, 6258, 6395, 6584, 6799, 6863, 7284, 7311, 7492, 7915, 8731, 8776, 9441, 9700, 10092, 10677, 10734, 11243, 11393, 11692, 11741, 12357, 12413, 12526, 12893, 13494, 13680, 13857, 14652, 14804, 15593, 15744, 16143, 16766, 17440, 17585, 18333, 18781, 18868, 18978, 19249, 19309, 19619, 19636, 19975 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1423, result.number);
            Assert.AreEqual(618281, result.newNumber);
        }


        [TestMethod]
        public void TestMethod387()
        {
            int[] numbers = new int[] { 176, 378, 722, 738, 769, 898, 901, 991, 999, 1012, 1103, 1196, 1198, 1284, 1324, 1538, 1738, 1782, 1789, 1951, 2047, 2097, 2248, 2295, 2373, 2464, 2680, 3069, 3266, 3478, 3530, 3598, 3707, 4120, 4172, 4204, 4429, 4465, 4677, 4851, 4923, 4959, 5002, 5027, 5058, 5129, 5139, 5223, 5364, 5394, 5398, 5431, 5453, 5594, 5695, 5724, 5753, 5796, 5826, 5976, 6024, 6282, 6351, 6422, 6543, 6618, 6755, 6792, 6825, 6873, 7146, 7147, 7192, 7226, 7260, 7357, 7930, 8049, 8120, 8271, 8459, 8500, 8522, 8852, 8907, 8946, 9066, 9238, 9394, 9408, 9702, 9792, 9838, 9892, 9908, 9909, 9912, 9983, 9996, 10137, 10316, 10371, 10393, 10583, 10631, 10701, 11100, 11140, 11157, 11202, 11464, 11522, 11840, 11882, 11891, 11933, 12220, 12320, 12365, 12435, 12545, 12630, 12732, 12844, 13038, 13057, 13106, 13176, 13566, 13814, 13814, 13912, 13989, 14004, 14133, 14237, 14407, 14742, 14867, 14960, 15006, 15193, 15228, 15347, 15416, 15589, 15593, 15765, 15849, 15939, 16126, 16186, 16516, 16524, 16618, 16693, 16900, 17080, 17117, 17326, 17348, 17433, 17456, 17525, 17571, 17592, 17613, 17705, 17908, 17958, 18096, 18224, 18367, 18471, 18668, 18817, 18890, 19262, 19289, 19376, 19386, 19502, 19734 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(176, result.number);
            Assert.AreEqual(1769009, result.newNumber);
        }


        [TestMethod]
        public void TestMethod388()
        {
            int[] numbers = new int[] { 170, 231, 356, 495, 627, 844, 890, 935, 972, 1107, 1183, 1234, 1249, 1281, 1316, 1487, 1512, 1524, 1773, 1874, 2065, 2119, 2281, 2408, 2428, 2586, 2912, 2968, 2989, 3037, 3272, 3679, 3869, 3877, 4024, 4039, 4044, 4071, 4094, 4097, 4277, 4387, 4463, 4671, 4890, 4980, 5068, 5177, 5327, 5352, 5363, 5381, 5485, 5563, 5612, 5648, 6039, 6379, 6473, 6492, 6644, 6687, 6825, 6856, 6927, 7099, 7204, 7221, 7234, 7264, 7322, 7347, 7392, 7410, 7578, 7698, 7929, 8123, 8135, 8200, 8617, 8974, 9164, 9221, 9248, 9291, 9483, 9529, 9576, 9691, 9738, 9862, 10497, 10604, 10725, 11062, 11230, 11486, 11528, 11560, 11650, 11798, 11898, 12018, 12257, 12329, 12365, 12369, 12559, 12572, 12658, 12836, 12883, 13005, 13057, 13117, 13199, 13276, 13429, 13541, 13614, 13834, 13927, 13973, 14029, 14265, 14788, 15212, 15274, 15329, 15411, 15586, 15598, 15641, 15746, 15764, 15954, 16102, 16217, 16425, 16445, 16533, 16874, 17055, 17179, 17345, 17404, 17547, 18197, 18209, 18335, 18347, 18468, 18601, 18902, 19078, 19231, 19445, 19467, 19523, 19608, 19649, 19661, 19688, 19786, 19806 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(170, result.number);
            Assert.AreEqual(1573298, result.newNumber);
        }


        [TestMethod]
        public void TestMethod389()
        {
            int[] numbers = new int[] { 14, 43, 51, 295, 518, 528, 586, 715, 876, 938, 1048, 1467, 1469, 1596, 1912, 2316, 2438, 2452, 2559, 2744, 2891, 3005, 3020, 3104, 3124, 3141, 3330, 3362, 3473, 3562, 3716, 3884, 4043, 4209, 4218, 4750, 4882, 5012, 5025, 5033, 5058, 5470, 5728, 5766, 5826, 6012, 6043, 6117, 6769, 6885, 7101, 7197, 7386, 7418, 7470, 7477, 7511, 7833, 8065, 8100, 8135, 8201, 8436, 8653, 8765, 8957, 9166, 9298, 9446, 9500, 9709, 9766, 9797, 9922, 10527, 10721, 10723, 10788, 10908, 10996, 11044, 11101, 11112, 11144, 11204, 11309, 11420, 11512, 11920, 11952, 12080, 12169, 12303, 12931, 12946, 13247, 13277, 13608, 13677, 13776, 13928, 13981, 13999, 14049, 14399, 14487, 14509, 14531, 14857, 15077, 15096, 15210, 15505, 15517, 15635, 15663, 15664, 15842, 15935, 15951, 15961, 16077, 16120, 16154, 16212, 16350, 16414, 16565, 16602, 16927, 16946, 16974, 17068, 17092, 17178, 17323, 17377, 17419, 17454, 17681, 17720, 17749, 17970, 17971, 18317, 18457, 18622, 18992, 18997, 19144, 19318, 19555, 19650, 19867 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(295, result.number);
            Assert.AreEqual(1568202, result.newNumber);
        }


        [TestMethod]
        public void TestMethod390()
        {
            int[] numbers = new int[] { 1128, 1264, 2013, 2140, 2321, 2488, 3766, 4289, 6901, 7029, 7145, 7272, 7410, 7926, 8296, 9650, 9790, 10206, 10993, 13427, 14755, 14834, 15627, 15680, 16116, 16395, 16661, 16694, 17091, 17723, 18733, 19243, 19480, 19674, 19825 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(2013, result.number);
            Assert.AreEqual(356426, result.newNumber);
        }


        [TestMethod]
        public void TestMethod391()
        {
            int[] numbers = new int[] { 271, 302, 356, 385, 426, 734, 776, 828, 909, 1080, 1220, 1390, 1467, 1470, 1851, 1860, 1898, 1934, 1962, 1996, 1999, 2103, 2165, 2320, 2427, 2550, 2621, 2760, 2921, 2922, 3306, 3563, 3677, 3847, 4228, 4368, 4369, 4498, 4888, 5223, 5437, 5442, 5463, 5754, 5968, 6276, 6300, 6303, 6484, 6616, 6728, 6829, 6847, 6936, 6951, 7070, 7077, 7129, 7356, 7567, 7653, 7674, 7924, 7952, 8221, 8223, 8226, 8412, 8413, 8431, 8468, 8642, 8845, 8853, 8894, 9004, 9039, 9066, 9309, 9461, 9687, 9821, 9999, 10136, 10347, 10506, 10528, 10750, 10922, 10938, 11074, 11257, 11284, 11571, 11755, 11780, 11783, 12802, 12999, 13223, 13370, 13375, 13584, 13629, 13845, 13892, 14016, 14023, 14079, 14566, 14751, 15063, 15123, 15226, 15432, 15471, 15821, 15955, 16125, 16147, 16247, 16423, 16512, 16615, 16941, 16981, 16983, 17260, 17698, 17874, 17891, 17892, 18056, 18072, 18099, 18120, 18354, 18366, 18411, 18423, 18510, 19065, 19094, 19305, 19325, 19453, 19539, 19574, 19590, 19599, 19680, 19700, 19892 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(302, result.number);
            Assert.AreEqual(1507771, result.newNumber);
        }


        [TestMethod]
        public void TestMethod392()
        {
            int[] numbers = new int[] { 3080, 6144, 8413, 10855, 13652 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(3080, result.number);
            Assert.AreEqual(1, result.newNumber);
        }


        [TestMethod]
        public void TestMethod393()
        {
            int[] numbers = new int[] { 1775, 2378, 2582, 2617, 2991, 3113, 3993, 4431, 5356, 5918, 6097, 6348, 6587, 7135, 8539, 9577, 12704, 13776, 13918, 14244, 15264, 19979 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(2617, result.number);
            Assert.AreEqual(140624, result.newNumber);
        }


        [TestMethod]
        public void TestMethod394()
        {
            int[] numbers = new int[] { 178, 204, 272, 484, 627, 923, 1290, 1293, 1421, 1608, 1616, 1820, 1870, 2078, 2134, 2350, 2584, 2591, 2841, 2900, 3245, 3449, 3509, 3663, 3673, 3813, 4099, 4307, 4439, 4508, 4530, 5268, 5390, 5483, 5764, 5793, 5797, 6351, 6499, 6635, 6888, 7099, 7390, 7776, 7851, 8074, 8147, 8376, 9006, 9024, 9037, 9207, 9288, 10212, 10304, 10759, 11186, 11433, 11657, 12048, 12226, 12455, 12483, 12537, 13231, 13672, 13703, 14132, 14303, 14857, 14949, 15451, 15711, 16042, 16187, 16350, 16740, 16743, 16922, 16983, 17061, 17630, 18320, 18530, 18970, 19294, 19501 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(272, result.number);
            Assert.AreEqual(732213, result.newNumber);
        }


        [TestMethod]
        public void TestMethod395()
        {
            int[] numbers = new int[] { 28, 78, 260, 391, 464, 490, 539, 632, 1030, 1368, 1586, 1727, 1794, 1886, 2065, 2089, 2237, 2696, 2922, 3443, 3649, 3847, 4010, 4056, 4304, 4651, 5838, 5873, 6018, 6355, 6448, 6463, 6658, 6843, 6890, 7129, 7227, 7388, 7853, 7880, 7930, 8055, 8219, 8282, 8291, 8552, 8626, 8820, 8868, 8883, 8960, 9215, 9769, 9968, 10961, 11000, 11142, 11443, 11615, 11856, 12050, 12105, 12110, 12741, 12808, 12863, 12914, 13325, 13846, 13928, 13974, 14117, 14398, 14788, 14807, 14972, 15055, 15099, 15474, 15502, 15552, 15640, 15782, 15793, 15850, 15951, 16085, 16259, 16343, 16579, 16641, 16847, 16883, 16985, 17047, 17096, 17201, 17729, 17954, 18106, 18161, 18344, 18421, 18465, 18492, 18910, 18911, 18995, 19096, 19571, 19757, 19787 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(260, result.number);
            Assert.AreEqual(1170580, result.newNumber);
        }


        [TestMethod]
        public void TestMethod396()
        {
            int[] numbers = new int[] { 47, 175, 179, 416, 483, 495, 680, 878, 1063, 1066, 1243, 1319, 1400, 1407, 1408, 1529, 1628, 1677, 1937, 1944, 2027, 2117, 2202, 2239, 2247, 2363, 2380, 2437, 2473, 2482, 2625, 2662, 2669, 2685, 2870, 2918, 3008, 3059, 3225, 3372, 3574, 3631, 3666, 3772, 3777, 3874, 3966, 4016, 4019, 4143, 4683, 4705, 4712, 4815, 4881, 5071, 5196, 5214, 5242, 5275, 5341, 5388, 5422, 5480, 5543, 5607, 5639, 5741, 5893, 6089, 6119, 6207, 6352, 6358, 6393, 6396, 6397, 6598, 6677, 6883, 7036, 7146, 7163, 7184, 7189, 7297, 7298, 7302, 7304, 7318, 7351, 7381, 7436, 7438, 7522, 7626, 7731, 7809, 7939, 8024, 8040, 8091, 8106, 8201, 8284, 8417, 8546, 8593, 8757, 8854, 8926, 8961, 8976, 9037, 9149, 9165, 9251, 9372, 9405, 9863, 9873, 9970, 9978, 10030, 10035, 10117, 10155, 10206, 10224, 10259, 10273, 10304, 10307, 10349, 10452, 10479, 10525, 10745, 11026, 11047, 11154, 11165, 11180, 11285, 11389, 11722, 11766, 11817, 11875, 12201, 12232, 12247, 12317, 12371, 12417, 12498, 12800, 12852, 12861, 12959, 12990, 12994, 13002, 13066, 13179, 13345, 13387, 13401, 13407, 13519, 13545, 13673, 13819, 13827, 14002, 14133, 14260, 14344, 14372, 14466, 14564, 14568, 14614, 14627, 14640, 14705, 14726, 14753, 14763, 14793, 14795, 14824, 14884, 14889, 14917, 15235, 15513, 15764, 15820, 15867, 15933, 16550, 16929, 16976, 16995, 17122, 17158, 17260, 17282, 17498, 17663, 17665, 17666, 17750, 17871, 18081, 18084, 18233, 18405, 18407, 18582, 18587, 18652, 18729, 18889, 18892, 18927, 19047, 19175, 19239, 19245, 19374, 19375, 19377, 19455, 19557, 19621, 19649, 19731, 19734, 19734, 19790, 19806, 19809, 19854, 19885 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(47, result.number);
            Assert.AreEqual(2475198, result.newNumber);
        }


        [TestMethod]
        public void TestMethod397()
        {
            int[] numbers = new int[] { 101, 204, 416, 601, 783, 808, 972, 1265, 1271, 1486, 1558, 1731, 1970, 1974, 2327, 2343, 2568, 2588, 3114, 3244, 3285, 3289, 3557, 3577, 3628, 3945, 4062, 4266, 4301, 4337, 4487, 4591, 4687, 4748, 4799, 4842, 4935, 5233, 5239, 5468, 5659, 5670, 5967, 6512, 6645, 6668, 6798, 6964, 7228, 7281, 7374, 7500, 7578, 7584, 7613, 7708, 7747, 7789, 7854, 7879, 7940, 7973, 7992, 8130, 8515, 8562, 8566, 9052, 9099, 9254, 9355, 9390, 9734, 9811, 9907, 9974, 10029, 10068, 10330, 10335, 10391, 10429, 10473, 10672, 10844, 10929, 10968, 11072, 11083, 11086, 11301, 11359, 11374, 11849, 11941, 12069, 12276, 12704, 12859, 12951, 13057, 13092, 13172, 13393, 13410, 13504, 14064, 14326, 14327, 14345, 14521, 14576, 14669, 14995, 15031, 15131, 15313, 15340, 15623, 15774, 16046, 16156, 16185, 17021, 17023, 17038, 17443, 17571, 17633, 17949, 18579, 18593, 18718, 18774, 18959, 18994, 19051, 19722, 19742, 19758, 19982 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(416, result.number);
            Assert.AreEqual(1336782, result.newNumber);
        }


        [TestMethod]
        public void TestMethod398()
        {
            int[] numbers = new int[] { 100, 116, 147, 185, 264, 284, 313, 410, 430, 440, 822, 868, 891, 907, 933, 937, 951, 1191, 1220, 1281, 1343, 1387, 1441, 1443, 1523, 1534, 1544, 1566, 1587, 1617, 1684, 1716, 1788, 1870, 1883, 1968, 1975, 2056, 2105, 2176, 2177, 2209, 2299, 2337, 2346, 2412, 2653, 2747, 2779, 2869, 2883, 3195, 3249, 3285, 3395, 3417, 3436, 3622, 3698, 3779, 3921, 3925, 3973, 4060, 4182, 4614, 4663, 4811, 4915, 4945, 4981, 4993, 5043, 5050, 5072, 5075, 5092, 5096, 5120, 5146, 5151, 5154, 5347, 5503, 5508, 5537, 5544, 5581, 5616, 5644, 6190, 6196, 6221, 6319, 6450, 6524, 6572, 6606, 6628, 6666, 6862, 6862, 6896, 6933, 7067, 7175, 7205, 7211, 7356, 7367, 7415, 7461, 7561, 7601, 7612, 7648, 7684, 7781, 7792, 7794, 7856, 7895, 7952, 7971, 8111, 8189, 8263, 8319, 8338, 8359, 8400, 8423, 8614, 8615, 8706, 8788, 8836, 8953, 8964, 9124, 9161, 9234, 9340, 9414, 9418, 9440, 9474, 9491, 9547, 9918, 10133, 10244, 10247, 10417, 10470, 10513, 10539, 10589, 10641, 10656, 10695, 10700, 10740, 10996, 11024, 11029, 11050, 11228, 11233, 11261, 11463, 11496, 11531, 11602, 11744, 11817, 12057, 12273, 12398, 12506, 12756, 12869, 12914, 12939, 13043, 13045, 13067, 13098, 13155, 13158, 13292, 13370, 13475, 13553, 13637, 13758, 13847, 13913, 13984, 14021, 14116, 14122, 14154, 14198, 14280, 14291, 14297, 14302, 14339, 14382, 14393, 14418, 14526, 14560, 14743, 14902, 14925, 15038, 15065, 15090, 15134, 15137, 15206, 15320, 15396, 15506, 15720, 15733, 15740, 15848, 15861, 15862, 15864, 15887, 15971, 16022, 16071, 16173, 16256, 16335, 16501, 16613, 16619, 16721, 16755, 16807, 16895, 16902, 16920, 16953, 16967, 17075, 17263, 17384, 17412, 17522, 17536, 17561, 17566, 17704, 17720, 17800, 17819, 17837, 18312, 18315, 18339, 18438, 18454, 18475, 18647, 18783, 18827, 18945, 18987, 19103, 19134, 19206, 19244, 19318, 19335, 19416, 19492, 19631, 19648, 19649, 19659, 19672, 19688, 19697, 19752, 19879, 19960 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(264, result.number);
            Assert.AreEqual(2902360, result.newNumber);
        }


        [TestMethod]
        public void TestMethod399()
        {
            int[] numbers = new int[] { 27, 30, 30, 59, 74, 313, 716, 756, 804, 976, 1042, 1074, 1090, 1091, 1136, 1147, 1148, 1221, 1352, 1367, 1400, 1614, 1641, 1786, 1866, 1970, 2002, 2333, 2358, 2375, 2460, 2765, 2790, 3045, 3053, 3056, 3073, 3077, 3267, 3288, 3300, 3438, 3492, 3507, 3853, 3983, 3988, 3998, 4050, 4248, 4360, 4374, 4397, 4456, 4477, 4522, 4552, 4568, 4605, 4606, 4625, 4636, 4680, 4847, 4929, 4959, 4967, 5005, 5007, 5044, 5258, 5309, 5416, 5491, 5709, 5854, 5856, 6020, 6056, 6166, 6242, 6254, 6408, 6508, 6518, 6526, 6553, 6553, 6584, 6674, 6812, 6832, 6875, 6904, 6928, 7122, 7141, 7218, 7307, 7412, 7503, 7556, 7651, 7665, 7669, 7748, 7792, 7799, 7880, 7919, 7931, 8005, 8036, 8036, 8047, 8143, 8301, 8315, 8386, 8423, 8451, 8505, 8506, 8785, 8840, 8930, 9000, 9073, 9150, 9157, 9249, 9289, 9293, 9349, 9593, 9594, 9633, 9955, 9959, 10056, 10379, 10464, 10532, 10712, 10754, 10759, 10772, 10876, 10910, 11198, 11203, 11259, 11353, 11602, 11607, 11634, 11794, 11824, 12065, 12078, 12238, 12255, 12365, 12369, 12489, 12512, 12598, 12614, 12616, 12691, 12711, 12720, 12799, 12835, 12928, 13098, 13136, 13350, 13596, 13600, 13604, 13609, 13649, 13705, 13707, 13739, 13876, 13908, 13910, 14050, 14092, 14142, 14250, 14255, 14283, 14397, 14410, 14439, 14519, 14568, 14580, 14583, 14594, 14691, 14736, 14754, 14848, 14873, 15256, 15261, 15302, 15308, 15369, 15450, 15546, 15583, 16081, 16120, 16188, 16345, 16477, 16596, 16614, 16814, 16856, 16859, 16961, 17029, 17051, 17053, 17084, 17125, 17170, 17344, 17450, 17564, 17598, 17658, 17667, 17738, 17756, 18140, 18288, 18325, 18471, 18567, 18641, 18642, 18801, 18814, 18855, 18947, 18973, 19048, 19095, 19105, 19134, 19200, 19433, 19472, 19532, 19598, 19613, 19714, 19720, 19799, 19902 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(30, result.number);
            Assert.AreEqual(2652513, result.newNumber);
        }


        [TestMethod]
        public void TestMethod400()
        {
            int[] numbers = new int[] { 4, 606, 668, 1021, 1146, 1327, 1343, 1576, 1810, 2046, 2081, 2607, 2748, 3430, 3436, 3608, 3736, 3927, 4328, 4443, 4507, 5035, 5178, 5236, 5737, 5773, 5857, 6122, 6142, 6213, 6605, 6707, 7328, 7740, 7807, 7906, 8304, 8352, 8502, 8596, 8710, 8726, 8963, 9100, 9201, 9436, 9662, 9808, 9818, 9852, 9943, 10195, 10315, 10357, 10408, 10772, 10910, 10988, 11239, 11386, 11483, 11508, 11683, 12102, 12135, 12502, 12693, 12866, 12944, 13108, 13155, 13247, 13505, 13700, 14128, 14205, 14209, 14333, 14524, 14672, 14709, 14915, 14929, 15041, 15084, 15104, 15201, 15386, 15419, 15479, 15535, 15638, 15642, 15716, 16118, 16160, 16344, 16407, 16421, 16657, 16786, 16967, 17030, 17122, 17129, 17262, 17306, 17713, 17839, 18842, 18981, 18993, 19027, 19081, 19345, 19857 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(4, result.number);
            Assert.AreEqual(1235396, result.newNumber);
        }


        [TestMethod]
        public void TestMethod401()
        {
            int[] numbers = new int[] { 233, 597, 857, 891, 1229, 2014, 2230, 2825, 3019, 3347, 4096, 4310, 6308, 6655, 6677, 6892, 7854, 8038, 8070, 9206, 9305, 9578, 10512, 10521, 11249, 11789, 12942, 13221, 14557, 14643, 14863, 15457, 16405, 16917, 17807, 18642, 18849, 19241, 19886, 19958 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(857, result.number);
            Assert.AreEqual(366482, result.newNumber);
        }


        [TestMethod]
        public void TestMethod402()
        {
            int[] numbers = new int[] { 111, 122, 176, 367, 390, 595, 652, 1042, 1078, 1441, 1497, 1973, 2156, 2650, 2864, 3317, 3516, 3700, 4066, 4086, 4189, 4204, 4212, 4284, 4420, 4593, 4763, 5286, 5318, 5443, 5462, 5815, 5837, 5840, 5931, 6296, 6328, 6366, 6566, 7515, 7806, 8151, 8507, 8703, 8982, 9286, 9293, 9438, 9574, 9625, 9810, 9817, 9964, 10026, 10069, 10224, 10237, 10664, 10777, 10859, 11307, 11566, 11790, 11964, 11966, 12148, 12239, 12517, 12801, 12890, 13375, 13413, 13742, 14121, 14273, 14284, 14300, 14344, 14512, 14681, 14843, 15297, 15521, 15774, 16042, 16156, 16425, 16442, 16546, 16976, 17408, 17477, 17502, 17601, 17914, 18144, 18240, 18351, 18822, 18848, 19214, 19812 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(652, result.number);
            Assert.AreEqual(973847, result.newNumber);
        }


        [TestMethod]
        public void TestMethod403()
        {
            int[] numbers = new int[] { 203, 252, 285, 366, 733, 865, 1052, 1211, 1246, 1425, 1519, 1571, 1712, 1795, 1873, 1999, 2141, 2232, 2324, 2349, 2420, 2629, 2920, 3123, 3204, 3232, 3279, 3397, 3689, 3696, 4079, 4092, 4314, 4395, 4547, 4587, 4592, 4627, 4963, 4986, 4993, 5004, 5124, 5391, 5524, 5594, 5726, 6039, 6461, 6635, 6684, 6798, 6799, 7091, 7209, 7217, 7361, 7370, 7622, 7665, 7908, 7962, 7981, 8006, 8099, 8108, 8116, 8150, 8248, 8310, 8310, 8365, 8437, 8459, 8478, 8559, 8634, 8701, 8706, 8944, 8987, 9012, 9071, 9121, 9557, 9636, 9935, 10002, 10014, 10182, 10277, 10298, 10368, 10422, 10427, 10696, 11268, 11531, 11603, 11666, 11737, 11866, 11937, 12065, 12109, 12329, 12353, 12446, 12547, 12633, 12721, 12741, 12776, 12854, 13063, 13161, 13246, 13276, 13332, 13582, 13586, 13689, 13974, 14036, 14051, 14065, 14118, 14154, 14169, 14297, 14341, 14597, 14882, 14919, 14936, 14978, 15003, 15033, 15069, 15373, 15481, 15584, 15617, 15632, 15797, 15887, 15968, 15998, 16188, 16656, 16670, 16707, 16714, 16809, 16833, 16862, 16982, 17376, 17397, 17582, 17682, 17872, 18110, 18283, 18325, 18517, 18525, 18652, 18691, 18720, 18895, 19107, 19159, 19243, 19248, 19361, 19542, 19546, 19621, 19656, 19891 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(203, result.number);
            Assert.AreEqual(1865721, result.newNumber);
        }


        [TestMethod]
        public void TestMethod404()
        {
            int[] numbers = new int[] { 2, 101, 322, 385, 565, 582, 633, 696, 734, 748, 817, 855, 883, 887, 1055, 1104, 1264, 1500, 1528, 1544, 1580, 1650, 1665, 1667, 1707, 1768, 1794, 1904, 2010, 2043, 2251, 2331, 2360, 2430, 2473, 2479, 2707, 2791, 2834, 2914, 3059, 3086, 3244, 3252, 3288, 3293, 3336, 3417, 3587, 3695, 3718, 3793, 3807, 4018, 4152, 4266, 4303, 4351, 4416, 4522, 4625, 4679, 4810, 4940, 4963, 5143, 5204, 5415, 5417, 5679, 5697, 5782, 5845, 5947, 6140, 6542, 6562, 6723, 6738, 6893, 6947, 7144, 7180, 7425, 7458, 7472, 7552, 7709, 7929, 8011, 8171, 8208, 8228, 8279, 8316, 8371, 8373, 8502, 8526, 8688, 8689, 8705, 8830, 8937, 8989, 9135, 9240, 9260, 9261, 9360, 9386, 9388, 9420, 9442, 9487, 9573, 9815, 9915, 9973, 10001, 10023, 10098, 10185, 10186, 10186, 10187, 10206, 10226, 10457, 10527, 10544, 10677, 10721, 10929, 10972, 11185, 11224, 11254, 11359, 11478, 11609, 11692, 11731, 11808, 12148, 12166, 12192, 12258, 12388, 12534, 12608, 12618, 12778, 12910, 13102, 13107, 13109, 13112, 13261, 13297, 13352, 13383, 13401, 13438, 13472, 13835, 13880, 13924, 13925, 13981, 14075, 14113, 14142, 14205, 14240, 14382, 14475, 14607, 14610, 14748, 14775, 14806, 14977, 15072, 15119, 15154, 15167, 15274, 15609, 15710, 15732, 15848, 16034, 16157, 16181, 16285, 16376, 16448, 16459, 16476, 16590, 16634, 16670, 16714, 16748, 16845, 16915, 17129, 17139, 17188, 17297, 17302, 17341, 17388, 17457, 17518, 17530, 17747, 17768, 17770, 17821, 17865, 17887, 17986, 18015, 18102, 18125, 18233, 18260, 18521, 18523, 18541, 18576, 18627, 18846, 18878, 19139, 19300, 19310, 19317, 19387, 19397, 19401, 19481, 19541, 19620, 19771, 19919 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(101, result.number);
            Assert.AreEqual(2517939, result.newNumber);
        }


        [TestMethod]
        public void TestMethod405()
        {
            int[] numbers = new int[] { 262, 394, 641, 737, 830, 2061, 2176, 2243, 2635, 2655, 2707, 3268, 3453, 3565, 3571, 3593, 3623, 4678, 4796, 5879, 5989, 6330, 6819, 6921, 7153, 7270, 7708, 7818, 8147, 8701, 8968, 9087, 9204, 9318, 9438, 9490, 9548, 9878, 9901, 9904, 10020, 10314, 11525, 11951, 11952, 12065, 12952, 13224, 13913, 14191, 14485, 14515, 14633, 14774, 15192, 15591, 15780, 15910, 15959, 17194, 17739, 18056, 18171, 18788, 19226, 19608, 19658, 19685, 19981 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(262, result.number);
            Assert.AreEqual(658990, result.newNumber);
        }


        [TestMethod]
        public void TestMethod406()
        {
            int[] numbers = new int[] { 20, 33, 387, 448, 476, 548, 634, 683, 834, 1141, 1246, 1470, 1646, 1685, 2033, 2065, 2223, 2461, 2589, 2593, 2647, 2668, 2702, 2723, 2848, 2866, 3101, 3110, 3230, 3275, 3609, 3700, 4002, 4012, 4095, 4165, 4247, 4435, 4499, 4571, 4612, 4623, 4678, 5192, 5235, 5247, 5247, 5312, 5727, 5744, 5832, 5853, 5946, 6307, 6387, 6405, 6532, 6726, 7005, 7275, 7325, 7444, 7527, 7915, 8383, 8485, 8621, 8635, 8896, 8920, 8926, 9141, 9314, 9342, 9392, 9506, 9547, 9632, 10041, 10053, 10140, 10292, 10358, 10582, 10612, 10621, 10638, 10686, 10891, 11049, 11204, 11280, 11428, 11484, 11635, 11907, 11960, 12010, 12014, 12067, 12123, 12521, 12590, 12718, 12826, 13197, 13297, 13302, 13339, 13668, 13727, 13747, 13764, 13813, 13960, 14096, 14228, 14408, 14432, 14452, 14971, 15086, 15103, 15122, 15130, 15369, 15497, 15503, 15516, 15535, 15586, 15697, 15884, 15906, 15959, 16306, 16718, 16867, 16883, 16886, 16990, 17019, 17110, 17127, 17154, 17285, 17836, 17897, 17928, 17955, 18342, 18459, 18489, 18561, 18596, 18794, 18805, 18807, 18936, 18977, 18998, 19477, 19583, 19734, 19769, 19944, 19984 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(33, result.number);
            Assert.AreEqual(1692830, result.newNumber);
        }


        [TestMethod]
        public void TestMethod407()
        {
            int[] numbers = new int[] { 168, 229, 238, 249, 313, 388, 399, 417, 431, 433, 446, 475, 476, 650, 699, 759, 945, 958, 1013, 1019, 1169, 1187, 1208, 1210, 1315, 1409, 1549, 1599, 1637, 1737, 1779, 1851, 2017, 2024, 2174, 2285, 2292, 2411, 2475, 2624, 2751, 2863, 2874, 2949, 3162, 3221, 3337, 3355, 3459, 3577, 3704, 3786, 3869, 3914, 3927, 3952, 3965, 4054, 4124, 4184, 4242, 4260, 4355, 4423, 4424, 4438, 4442, 4465, 4491, 4571, 4680, 4701, 4710, 4892, 5050, 5125, 5163, 5180, 5193, 5295, 5384, 5425, 5498, 5504, 5541, 5557, 5610, 5763, 5884, 5972, 6101, 6217, 6227, 6258, 6308, 6355, 6486, 6593, 6615, 6673, 6733, 6755, 6767, 6789, 6899, 6903, 6908, 6929, 6982, 7064, 7256, 7276, 7404, 7407, 7585, 7665, 7716, 7739, 7859, 7919, 7926, 8131, 8147, 8164, 8164, 8171, 8205, 8286, 8500, 8535, 8558, 8666, 8683, 8687, 8719, 8961, 9005, 9233, 9299, 9336, 9515, 9640, 9744, 9816, 9849, 9899, 9908, 9952, 10027, 10180, 10203, 10207, 10248, 10255, 10262, 10361, 10375, 10390, 10582, 10603, 10723, 10740, 10744, 10848, 11009, 11160, 11224, 11396, 11484, 11529, 11547, 11630, 11673, 11722, 11762, 11850, 11902, 11917, 11929, 11984, 12177, 12230, 12248, 12405, 12556, 12586, 12880, 12909, 12917, 12951, 13090, 13117, 13239, 13432, 13476, 13505, 13519, 13623, 13666, 13717, 13719, 13751, 13789, 13869, 13936, 13997, 14015, 14121, 14217, 14253, 14262, 14316, 14321, 14371, 14472, 14483, 14533, 14566, 14704, 14751, 14794, 14862, 14870, 14919, 14974, 14998, 15028, 15180, 15194, 15227, 15248, 15266, 15281, 15290, 15324, 15347, 15376, 15418, 15455, 15477, 15529, 15572, 15597, 15606, 15742, 15764, 15822, 15851, 15947, 15975, 16115, 16343, 16349, 16505, 16596, 16868, 16889, 17433, 17436, 17454, 17564, 17667, 17678, 17831, 17837, 17920, 17946, 17956, 18017, 18088, 18143, 18188, 18304, 18308, 18492, 18560, 18618, 18732, 18832, 18880, 18902, 18913, 19084, 19243, 19304, 19355, 19406, 19417, 19480, 19518, 19581, 19615, 19678, 19750, 19835, 19871, 19879 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(168, result.number);
            Assert.AreEqual(2944996, result.newNumber);
        }


        [TestMethod]
        public void TestMethod408()
        {
            int[] numbers = new int[] { 262, 281, 411, 456, 650, 896, 1530, 1842, 2124, 2232, 2291, 2730, 3023, 3434, 3489, 3548, 3700, 3761, 3926, 3994, 4216, 4232, 4323, 4446, 4517, 4797, 4987, 5240, 5269, 5331, 5341, 5775, 6055, 6128, 6157, 6169, 6717, 6922, 7189, 7304, 7334, 7520, 7562, 7612, 7830, 8069, 8216, 8389, 8444, 9192, 9741, 9815, 9962, 10386, 10583, 10726, 10760, 11008, 11045, 11081, 11116, 11820, 11879, 12045, 12122, 12406, 12448, 12645, 12759, 13085, 13237, 13368, 13851, 14046, 14179, 14214, 14361, 14933, 15388, 15657, 15723, 15925, 16142, 16320, 16543, 16655, 16725, 16733, 16816, 16825, 16909, 17102, 18141, 18317, 18491, 18658, 19451, 19620, 19689, 19774 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(411, result.number);
            Assert.AreEqual(949918, result.newNumber);
        }


        [TestMethod]
        public void TestMethod409()
        {
            int[] numbers = new int[] { 49, 131, 194, 207, 268, 357, 386, 431, 442, 485, 525, 526, 593, 664, 675, 830, 833, 954, 1031, 1121, 1124, 1257, 1266, 1309, 1411, 1489, 1506, 1565, 1601, 1659, 1667, 1698, 1867, 1996, 2083, 2138, 2265, 2308, 2347, 2417, 2448, 2487, 2520, 2576, 2619, 2631, 2750, 2858, 2876, 2892, 2899, 2899, 2900, 2921, 3033, 3083, 3165, 3166, 3191, 3245, 3287, 3449, 3478, 3579, 3597, 3675, 3776, 3786, 3847, 3887, 3995, 4025, 4041, 4057, 4159, 4343, 4440, 4483, 4499, 4558, 4590, 4611, 4612, 4705, 4766, 4945, 5079, 5545, 5703, 5705, 5842, 5903, 5997, 6039, 6044, 6063, 6091, 6115, 6122, 6332, 6366, 6377, 6397, 6435, 6438, 6461, 6467, 6504, 6786, 6898, 6912, 7130, 7171, 7186, 7191, 7207, 7210, 7363, 7397, 7399, 7403, 7407, 7509, 7874, 7877, 7899, 7925, 8040, 8182, 8321, 8379, 8587, 8587, 8605, 8774, 8883, 9077, 9205, 9391, 9474, 9589, 9896, 9931, 10026, 10038, 10110, 10198, 10277, 10370, 10396, 10635, 10768, 10799, 11063, 11129, 11132, 11143, 11232, 11287, 11490, 11597, 11597, 11643, 11733, 11769, 11840, 11888, 11919, 11953, 11969, 12243, 12257, 12298, 12528, 12595, 12599, 12794, 12956, 12986, 13053, 13121, 13149, 13152, 13276, 13337, 13370, 13370, 13734, 13738, 13998, 14018, 14224, 14295, 14472, 14594, 14671, 14699, 14740, 14890, 14969, 14976, 15042, 15083, 15128, 15176, 15417, 15486, 15498, 15672, 15728, 15876, 16001, 16019, 16118, 16141, 16265, 16268, 16327, 16492, 16776, 16871, 16877, 17165, 17217, 17221, 17276, 17367, 17456, 17518, 17571, 17578, 17743, 17980, 18057, 18214, 18221, 18316, 18355, 18525, 18561, 18632, 18637, 18767, 18961, 18973, 19007, 19074, 19122, 19257, 19364, 19436, 19448, 19450, 19571, 19672, 19776, 19813, 19859, 19937, 19954 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(207, result.number);
            Assert.AreEqual(2387716, result.newNumber);
        }


        [TestMethod]
        public void TestMethod410()
        {
            int[] numbers = new int[] { 166, 247, 248, 498, 576, 619, 718, 899, 922, 977, 1207, 1355, 1420, 1479, 1484, 1528, 1574, 1745, 1763, 1934, 1990, 1997, 2047, 2069, 2260, 2494, 2542, 2554, 2642, 2755, 2798, 2880, 3045, 3129, 3293, 3347, 3378, 3484, 3526, 3611, 3770, 3821, 3853, 3960, 3979, 4338, 4405, 4479, 4517, 4627, 4666, 4999, 5047, 5078, 5091, 5142, 5655, 5668, 5713, 5720, 5727, 5830, 5951, 5983, 6005, 6047, 6088, 6329, 6487, 6793, 6973, 7022, 7094, 7233, 7366, 7429, 7527, 7622, 7637, 7684, 7691, 7756, 7773, 7853, 7905, 7923, 7939, 7963, 8331, 8331, 8402, 8493, 8688, 8789, 8932, 9474, 9487, 9599, 9664, 9815, 9843, 9980, 10083, 10116, 10175, 10284, 10366, 10619, 10811, 10866, 10954, 11179, 11322, 11611, 11690, 11750, 11860, 11865, 12022, 12048, 12052, 12117, 12161, 12667, 12683, 12983, 13010, 13112, 13229, 13320, 13367, 13388, 13450, 13537, 13661, 13679, 13727, 13765, 13777, 13915, 14112, 14151, 14163, 14262, 14323, 14396, 14561, 14681, 14694, 14746, 14851, 14926, 15102, 15173, 15300, 15423, 15570, 15604, 15646, 15685, 15937, 16165, 16294, 16338, 16392, 16547, 16835, 16894, 16915, 16973, 16998, 17042, 17156, 17215, 17270, 17368, 17451, 17606, 17765, 17986, 18056, 18123, 18139, 18351, 18384, 18393, 18430, 18506, 18677, 18875, 18960, 19030, 19080, 19195, 19418, 19556, 19639, 19708, 19759, 19771, 19940 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(247, result.number);
            Assert.AreEqual(1991724, result.newNumber);
        }


        [TestMethod]
        public void TestMethod411()
        {
            int[] numbers = new int[] { 40, 102, 109, 149, 718, 952, 1377, 1472, 1641, 2749, 3264, 4027, 4155, 4241, 4370, 4512, 4858, 5344, 5361, 5706, 5808, 6029, 6037, 6380, 6479, 6500, 6587, 7097, 7327, 7440, 7817, 7970, 8445, 8512, 8662, 8993, 9073, 9194, 9601, 9651, 9945, 9957, 10164, 10171, 10221, 10486, 10566, 10639, 10754, 10887, 10975, 11002, 11253, 11277, 11595, 11619, 11679, 11838, 11873, 11875, 11985, 12152, 12397, 12457, 12524, 12559, 12644, 12684, 12865, 12917, 12942, 13085, 13183, 13406, 13473, 13678, 13840, 14292, 14425, 14681, 14683, 14783, 14799, 14996, 15663, 15720, 15761, 15846, 15988, 16072, 16346, 16431, 16601, 16690, 16712, 16751, 16900, 17400, 17776, 17799, 17902, 17994, 18005, 18098, 18357, 18616, 18650, 18795, 18801, 18922, 18981, 19049, 19058, 19193, 19245, 19265, 19356, 19467, 19616, 19897 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(149, result.number);
            Assert.AreEqual(1383863, result.newNumber);
        }


        [TestMethod]
        public void TestMethod412()
        {
            int[] numbers = new int[] { 277, 312, 434, 598, 812, 976, 987, 1008, 1164, 1172, 1238, 1471, 1559, 1650, 1984, 2081, 2113, 2338, 2368, 2370, 2439, 2455, 2463, 2537, 2585, 2651, 2836, 3109, 3172, 3509, 3560, 3750, 3863, 3910, 3987, 4113, 4239, 4289, 4339, 4344, 4394, 4406, 4538, 4692, 4757, 4880, 4894, 4907, 5016, 5312, 5325, 5527, 5570, 5616, 5648, 5676, 5824, 5931, 5952, 6024, 6191, 6199, 6280, 6319, 6486, 6724, 6743, 6822, 6836, 6870, 6883, 6913, 6980, 6987, 7098, 7177, 7244, 7549, 7561, 7649, 8032, 8279, 8337, 8593, 8604, 8705, 8762, 9299, 9307, 9360, 9533, 9611, 9672, 9767, 9876, 9928, 10009, 10428, 10437, 10451, 11309, 11555, 11562, 11646, 11699, 11732, 11746, 11892, 12200, 12254, 12367, 12512, 12813, 12883, 12983, 13074, 13125, 13284, 13306, 13367, 13378, 13423, 13451, 13487, 13609, 13801, 13987, 14173, 14251, 14367, 14399, 14410, 14411, 14667, 14747, 14751, 14989, 15016, 15024, 15296, 15351, 15607, 15987, 16203, 16271, 16286, 16324, 16349, 16354, 16627, 16819, 16823, 16861, 17009, 17058, 17089, 17220, 17468, 17487, 17631, 17878, 18089, 18131, 18230, 18804, 18805, 18947, 19290, 19463, 19621, 19625, 19719, 19810, 19836 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(434, result.number);
            Assert.AreEqual(1651853, result.newNumber);
        }


        [TestMethod]
        public void TestMethod413()
        {
            int[] numbers = new int[] { 72, 129, 152, 153, 203, 255, 298, 499, 710, 798, 1087, 1313, 1415, 1723, 1763, 1841, 2053, 2096, 2121, 2258, 2460, 2541, 2580, 2640, 2771, 2775, 3020, 3104, 3367, 3560, 3703, 3838, 4005, 4190, 4547, 4624, 4763, 4778, 4817, 5090, 5195, 5840, 5900, 6020, 6105, 6263, 6334, 6447, 6556, 6657, 6750, 6770, 6962, 6974, 7091, 7389, 7752, 7775, 7865, 7977, 8051, 8115, 8266, 8305, 8340, 8500, 8515, 8659, 8753, 9052, 9236, 9390, 9498, 9555, 9659, 9685, 9762, 9822, 9847, 9904, 10019, 10329, 10330, 10517, 11011, 11036, 11074, 11227, 11284, 11319, 11451, 11483, 11564, 11847, 12055, 12133, 12774, 12825, 13062, 13096, 13146, 13198, 13277, 13335, 13684, 13781, 13824, 13990, 14232, 14415, 14816, 14958, 14964, 14997, 15026, 15030, 15094, 15273, 15488, 15647, 15689, 15757, 15838, 15952, 16001, 16005, 16116, 16693, 16868, 17332, 17464, 17530, 17824, 18049, 18067, 18220, 18292, 18330, 18363, 18417, 18446, 18542, 18635, 18718, 18982, 19116, 19243, 19253, 19436, 19536, 19789, 19863, 19923, 19990 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(298, result.number);
            Assert.AreEqual(1538744, result.newNumber);
        }


        [TestMethod]
        public void TestMethod414()
        {
            int[] numbers = new int[] { 53, 266, 343, 541, 709, 881, 920, 1103, 1172, 1277, 1516, 1954, 1956, 2016, 2072, 2134, 2200, 2378, 2665, 2735, 2741, 2773, 2826, 2888, 3005, 3113, 3271, 3393, 3523, 3558, 3662, 3843, 3968, 4092, 4118, 4181, 4638, 4645, 5076, 5187, 5254, 5411, 5520, 5622, 5623, 5678, 5833, 5907, 6047, 6245, 6424, 6450, 6495, 6830, 6833, 6865, 7037, 7255, 7330, 7392, 7881, 7940, 7948, 7990, 8155, 8312, 8313, 8353, 8434, 8532, 8567, 8657, 8816, 8978, 8983, 8984, 9107, 9197, 9486, 9723, 9831, 9927, 9999, 10280, 10325, 10556, 10567, 10569, 10748, 10750, 10754, 10837, 11081, 11341, 11429, 11475, 11504, 11517, 11546, 11566, 11584, 11637, 11831, 12030, 12192, 12244, 12269, 12348, 12458, 12500, 12525, 12551, 12558, 12727, 12754, 12861, 12991, 13063, 13075, 13126, 13182, 13291, 13333, 13380, 13663, 14024, 14045, 14101, 14219, 14707, 14842, 15087, 15348, 15508, 15508, 15902, 15910, 15964, 16061, 16200, 16211, 16274, 16334, 16704, 16796, 16908, 17103, 18097, 18353, 18396, 18414, 18470, 18689, 18735, 18902, 18914, 19023, 19173, 19182, 19213, 19391, 19574, 19575, 19577, 19691, 19693, 19810, 19933, 19937, 19939, 19997 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(53, result.number);
            Assert.AreEqual(1734662, result.newNumber);
        }


        [TestMethod]
        public void TestMethod415()
        {
            int[] numbers = new int[] { 72, 1011, 1262, 2529, 2559, 2687, 3675, 4251, 4435, 4612, 4961, 5600, 6562, 6784, 6862, 6865, 7162, 7234, 7294, 7358, 7741, 7913, 8673, 8711, 9063, 9141, 9366, 10094, 10319, 10333, 10531, 10748, 12093, 12280, 12487, 12552, 13405, 14458, 14471, 14680, 14693, 15029, 16446, 16795, 16879, 17134, 17475, 17512, 18227, 18229, 18250, 18565, 19046, 19113, 19833, 19861 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(72, result.number);
            Assert.AreEqual(576382, result.newNumber);
        }


        [TestMethod]
        public void TestMethod416()
        {
            int[] numbers = new int[] { 3, 120, 127, 148, 199, 217, 292, 349, 374, 402, 459, 534, 538, 549, 643, 724, 773, 1031, 1088, 1116, 1118, 1331, 1360, 1433, 1581, 1617, 1626, 1810, 1926, 1983, 2066, 2142, 2199, 2345, 2485, 2487, 2501, 2607, 2683, 2918, 2926, 3104, 3105, 3181, 3220, 3296, 3348, 3352, 3394, 3509, 3573, 3588, 3688, 3727, 3889, 3943, 3990, 4019, 4131, 4152, 4682, 4947, 4984, 5164, 5171, 5174, 5254, 5497, 5512, 5709, 5843, 5871, 5881, 5889, 5903, 5956, 5988, 5996, 6077, 6115, 6257, 6397, 6411, 6492, 6507, 6528, 6583, 6692, 6693, 6808, 6904, 7029, 7128, 7183, 7224, 7227, 7252, 7283, 7355, 7374, 7611, 7695, 7792, 7849, 7867, 7990, 8029, 8070, 8244, 8248, 8265, 8423, 8626, 8829, 8991, 9004, 9117, 9167, 9194, 9237, 9291, 9313, 9342, 9365, 9411, 9475, 9523, 9578, 9665, 9688, 9753, 9755, 9774, 10027, 10042, 10059, 10210, 10314, 10324, 10616, 10639, 10702, 10709, 10908, 10923, 11059, 11194, 11400, 11581, 11642, 11642, 11657, 11678, 11714, 11868, 12023, 12026, 12216, 12287, 12296, 12406, 12484, 12521, 12739, 13135, 13138, 13867, 13969, 14054, 14128, 14165, 14232, 14232, 14238, 14280, 14310, 14324, 14331, 14378, 14430, 14434, 14501, 14538, 14633, 14667, 14671, 14768, 14916, 14984, 15035, 15184, 15197, 15264, 15267, 15314, 15400, 15424, 15481, 15575, 15762, 15999, 16064, 16087, 16111, 16149, 16200, 16241, 16459, 16472, 16524, 16545, 16551, 16590, 16709, 16738, 16751, 16757, 16771, 16895, 17042, 17126, 17183, 17217, 17272, 17288, 17288, 17376, 17389, 17448, 17574, 17641, 17702, 17714, 17811, 17844, 17876, 18012, 18015, 18081, 18089, 18141, 18206, 18362, 18393, 18404, 18482, 18507, 18617, 18771, 18803, 18885, 18896, 18914, 19030, 19177, 19265, 19315, 19328, 19428, 19563, 19589, 19728, 19807, 19907, 19918 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(3, result.number);
            Assert.AreEqual(2696315, result.newNumber);
        }


        [TestMethod]
        public void TestMethod417()
        {
            int[] numbers = new int[] { 28, 219, 231, 284, 329, 381, 414, 555, 614, 647, 782, 847, 922, 965, 1007, 1015, 1108, 1125, 1135, 1153, 1243, 1259, 1371, 1542, 1613, 1843, 1880, 1896, 1960, 1964, 2052, 2068, 2185, 2237, 2301, 2308, 2378, 2425, 2505, 2514, 2607, 2702, 2813, 3010, 3084, 3111, 3137, 3177, 3251, 3261, 3371, 3386, 3430, 3455, 3561, 3578, 3780, 3804, 3823, 3948, 3988, 3990, 4192, 4313, 4494, 4544, 4653, 4762, 4865, 4890, 4911, 5062, 5092, 5107, 5126, 5326, 5411, 5477, 5477, 5630, 5753, 5843, 5918, 6206, 6275, 6278, 6478, 6571, 6581, 6618, 6636, 6708, 6727, 6832, 6842, 6953, 6977, 6985, 6988, 7113, 7186, 7410, 7455, 7520, 7526, 7658, 7989, 8201, 8257, 8264, 8306, 8364, 8460, 8546, 8644, 8692, 8736, 8792, 8931, 8983, 9061, 9103, 9208, 9245, 9257, 9297, 9359, 9414, 9471, 9476, 9480, 9481, 9554, 9560, 9583, 9692, 9748, 9790, 9967, 10027, 10034, 10128, 10137, 10217, 10257, 10265, 10309, 10420, 10423, 10423, 10566, 10650, 10662, 10688, 10695, 10751, 10793, 10802, 11028, 11040, 11077, 11331, 11408, 11411, 11438, 11498, 11565, 11612, 11679, 11682, 12074, 12099, 12277, 12302, 12378, 12439, 12630, 12811, 12866, 12919, 12942, 13008, 13035, 13068, 13199, 13230, 13344, 13363, 13397, 13635, 13638, 13672, 13761, 13779, 13814, 13888, 13904, 14000, 14014, 14073, 14120, 14164, 14217, 14247, 14276, 14358, 14386, 14387, 14414, 14437, 14442, 14459, 14742, 14759, 14986, 15084, 15215, 15228, 15308, 15324, 15471, 15538, 15619, 15625, 15658, 15741, 15747, 15756, 15809, 15843, 15843, 16004, 16024, 16075, 16075, 16128, 16199, 16408, 16428, 16533, 16692, 16760, 16858, 16913, 16944, 16946, 17014, 17017, 17033, 17103, 17176, 17258, 17397, 17414, 17566, 17777, 17785, 17833, 17834, 17861, 17922, 17970, 18020, 18028, 18039, 18044, 18045, 18159, 18175, 18197, 18464, 18543, 18681, 18906, 18921, 18965, 19041, 19057, 19158, 19198, 19288, 19386, 19514, 19534, 19621, 19627, 19685, 19714, 19879, 19894 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(219, result.number);
            Assert.AreEqual(2942642, result.newNumber);
        }


        [TestMethod]
        public void TestMethod418()
        {
            int[] numbers = new int[] { 98, 126, 310, 331, 372, 460, 479, 670, 688, 820, 870, 999, 1013, 1133, 1262, 1323, 1338, 1435, 1439, 1558, 1593, 1593, 1634, 1880, 2052, 2198, 2568, 2937, 3173, 3224, 3394, 3504, 3517, 3542, 3667, 3829, 4066, 4413, 4498, 4976, 5066, 5086, 5096, 5395, 5471, 5699, 5939, 6073, 6122, 6199, 6347, 6521, 6572, 6584, 6626, 6658, 6697, 6846, 6870, 6968, 7086, 7134, 7157, 7254, 7653, 7789, 7931, 7939, 8045, 8051, 8108, 8167, 8188, 8316, 8338, 8374, 8485, 8495, 8879, 8922, 9017, 9333, 9486, 9495, 9532, 9614, 9679, 9745, 9874, 9876, 9955, 10067, 10086, 10181, 10401, 10426, 10453, 10679, 10683, 10831, 10833, 10847, 10869, 11009, 11018, 11182, 11264, 11319, 11365, 11539, 11681, 11708, 11997, 12292, 12311, 12683, 12753, 12884, 12930, 13102, 13195, 13238, 13437, 13439, 13606, 13630, 13653, 13653, 13784, 13845, 13918, 13942, 14173, 14454, 14563, 14813, 15032, 15111, 15225, 15273, 15329, 15453, 15480, 15499, 15654, 15749, 15757, 15821, 15879, 15918, 16036, 16053, 16067, 16284, 16369, 16549, 16782, 16796, 16848, 16995, 17169, 17203, 17313, 17671, 17999, 18137, 18243, 18286, 18368, 18549, 18620, 18717, 18800, 19193, 19271, 19451, 19496, 19502, 19568, 19621, 19857, 19988 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(310, result.number);
            Assert.AreEqual(1809064, result.newNumber);
        }


        [TestMethod]
        public void TestMethod419()
        {
            int[] numbers = new int[] { 138, 153, 709, 882, 919, 1173, 1234, 1321, 1336, 1404, 1498, 1516, 1605, 1647, 1747, 1868, 2043, 2057, 2132, 2604, 2647, 2843, 2874, 2948, 3059, 3194, 3194, 3382, 3461, 3561, 3639, 3772, 3819, 4001, 4476, 4491, 4872, 4875, 4931, 4981, 5115, 5210, 5223, 5231, 5237, 5240, 5251, 5259, 5453, 5456, 5556, 5984, 6054, 6062, 6272, 6282, 6286, 6510, 6612, 6755, 6820, 6874, 7002, 7007, 7163, 7319, 7484, 7862, 8105, 8105, 8200, 8238, 8257, 8327, 8359, 8592, 8631, 8813, 8896, 9096, 9117, 9294, 9374, 9457, 9644, 10392, 10414, 10423, 10458, 10477, 10488, 10505, 10513, 10643, 10646, 10709, 10971, 11086, 11224, 11320, 11605, 11669, 11826, 11952, 12106, 12177, 12211, 12489, 12620, 13166, 13260, 13279, 13303, 13341, 13660, 13702, 14163, 14222, 14309, 14707, 14751, 14866, 14897, 15049, 15106, 15363, 15493, 15569, 15877, 16244, 16415, 16460, 16601, 16798, 16845, 16865, 16914, 17064, 17155, 17296, 17400, 17507, 17711, 17738, 17769, 17951, 18043, 18106, 18134, 18154, 18471, 18490, 18630, 18871, 18941, 19388, 19770, 19851, 19910, 19980, 19981 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(138, result.number);
            Assert.AreEqual(1552000, result.newNumber);
        }


        [TestMethod]
        public void TestMethod420()
        {
            int[] numbers = new int[] { 3338, 5154, 10934, 15125, 19524 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(3338, result.number);
            Assert.AreEqual(1, result.newNumber);
        }


        [TestMethod]
        public void TestMethod421()
        {
            int[] numbers = new int[] { 195, 234, 285, 319, 343, 367, 385, 518, 536, 625, 682, 1104, 1209, 1219, 1228, 1231, 1362, 1370, 1372, 1391, 1576, 1654, 1699, 1719, 1758, 1992, 2069, 2427, 2470, 2531, 2623, 2684, 2857, 2879, 2939, 2981, 3050, 3231, 3249, 3271, 3349, 3452, 3488, 3559, 3636, 3771, 3782, 3963, 4122, 4167, 4285, 4305, 4322, 4330, 4340, 4458, 4463, 4464, 4521, 4539, 4608, 4638, 4691, 4692, 4843, 4897, 4900, 4902, 4961, 5051, 5246, 5422, 5431, 5441, 5601, 5945, 6114, 6170, 6196, 6255, 6288, 6360, 6419, 6452, 6566, 6625, 6746, 6746, 6749, 6835, 6876, 7053, 7207, 7231, 7310, 7331, 7419, 7422, 7472, 7561, 7617, 7685, 7955, 8069, 8105, 8232, 8239, 8589, 8682, 8704, 8805, 8847, 8959, 9013, 9091, 9114, 9154, 9345, 9385, 9422, 9477, 9524, 9673, 9677, 9814, 9879, 9890, 9944, 9952, 10017, 10085, 10169, 10312, 10340, 10369, 10469, 10502, 10507, 10543, 10545, 10684, 10742, 10803, 10807, 10871, 10895, 10949, 11095, 11172, 11212, 11289, 11312, 11385, 11596, 11690, 11712, 11728, 11796, 11960, 12099, 12112, 12135, 12236, 12402, 12409, 12594, 12660, 12862, 12871, 13092, 13106, 13140, 13151, 13186, 13225, 13227, 13398, 13449, 13477, 13509, 13530, 13541, 13598, 13613, 13641, 13676, 13731, 13754, 13779, 13780, 13783, 13788, 13789, 13846, 13870, 13893, 13959, 14059, 14131, 14206, 14467, 14469, 14669, 14787, 14953, 14965, 15052, 15114, 15293, 15437, 15493, 15499, 15551, 15581, 15665, 15693, 15840, 15926, 16010, 16035, 16058, 16145, 16215, 16277, 16377, 16415, 16471, 16511, 16741, 16862, 16910, 16914, 16931, 16970, 17013, 17030, 17037, 17109, 17135, 17182, 17218, 17278, 17342, 17389, 17495, 17599, 17736, 17918, 18172, 18178, 18196, 18274, 18286, 18496, 18515, 18532, 18629, 18734, 18758, 18815, 18862, 18974, 19136, 19310, 19316, 19399, 19470, 19493, 19766, 19885 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(367, result.number);
            Assert.AreEqual(2720139, result.newNumber);
        }


        [TestMethod]
        public void TestMethod422()
        {
            int[] numbers = new int[] { 191, 210, 548, 643, 667, 725, 910, 915, 1108, 1332, 1528, 1778, 1871, 2017, 2116, 2306, 2395, 3619, 3800, 3856, 4196, 4920, 5081, 5156, 5544, 5841, 5900, 5906, 5940, 6029, 6507, 7475, 7779, 7835, 8175, 8839, 9060, 9158, 9367, 9508, 9556, 10055, 10398, 11128, 11689, 11846, 12746, 12964, 13038, 13234, 13238, 13379, 13910, 14251, 15407, 15459, 15607, 16079, 16488, 16614, 16634, 16721, 16879, 17357, 18278, 18361, 18639, 18724, 19749 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(210, result.number);
            Assert.AreEqual(594607, result.newNumber);
        }


        [TestMethod]
        public void TestMethod423()
        {
            int[] numbers = new int[] { 91, 107, 237, 269, 367, 423, 554, 585, 710, 863, 889, 1059, 1217, 2036, 2041, 2103, 2510, 2595, 2858, 2924, 2982, 3013, 3024, 3172, 3275, 3402, 3427, 3509, 3548, 3817, 3825, 3880, 3924, 3951, 4022, 4133, 4190, 4478, 4612, 4619, 4849, 5204, 5304, 5469, 5481, 5522, 5528, 5577, 5612, 5699, 5832, 5941, 6338, 6580, 6630, 6688, 6758, 6831, 6902, 7248, 7310, 7315, 7326, 7357, 7392, 7475, 7509, 7581, 7584, 7685, 7722, 7780, 7905, 8079, 8276, 8365, 8382, 8492, 8845, 9044, 9100, 9110, 9140, 9283, 9312, 9402, 9494, 9733, 9778, 9866, 9958, 10031, 10201, 10283, 10383, 10456, 10463, 10480, 10497, 10593, 10627, 10650, 10682, 10772, 10837, 11031, 11146, 11269, 11542, 11614, 11714, 11779, 11860, 11877, 12055, 12160, 12174, 12478, 12497, 12556, 12608, 12695, 12715, 12737, 12742, 12783, 12877, 12895, 12919, 12921, 12950, 13037, 13143, 13173, 13190, 13387, 13390, 13400, 13452, 13460, 13891, 13957, 14157, 14210, 14243, 14437, 14579, 14710, 14754, 14857, 14953, 14954, 14983, 14995, 15071, 15189, 15231, 15388, 15526, 15586, 15703, 15810, 15858, 15937, 15971, 16104, 16107, 16139, 16244, 16290, 16447, 16538, 16791, 16797, 16884, 17247, 17273, 17312, 17347, 17547, 17594, 17646, 17845, 18625, 18879, 18900, 19012, 19016, 19123, 19507, 19527, 19536, 19567, 19603, 19802, 19821, 19933 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(367, result.number);
            Assert.AreEqual(2013468, result.newNumber);
        }


        [TestMethod]
        public void TestMethod424()
        {
            int[] numbers = new int[] { 57, 117, 160, 187, 203, 260, 272, 319, 376, 386, 740, 748, 780, 793, 950, 1028, 1129, 1365, 1539, 1665, 1781, 1878, 1903, 1937, 2027, 2248, 2341, 2407, 2410, 2451, 2471, 2513, 2519, 2599, 2676, 2679, 2763, 2877, 2899, 3156, 3177, 3182, 3218, 3236, 3318, 3326, 3338, 3357, 3719, 3896, 3962, 4191, 4287, 4346, 4429, 4476, 4493, 4741, 4814, 4928, 4967, 4972, 4979, 5210, 5217, 5352, 5374, 5386, 5508, 5551, 5598, 5668, 5789, 5855, 5875, 6027, 6033, 6149, 6226, 6247, 6277, 6377, 6417, 6499, 6508, 6640, 6741, 7076, 7114, 7263, 7322, 7344, 7447, 7521, 7595, 7673, 7689, 7716, 7728, 7752, 7806, 7995, 8107, 8137, 8160, 8201, 8253, 8351, 8486, 8502, 8509, 8652, 8954, 9135, 9148, 9150, 9294, 9423, 9446, 9585, 9657, 9667, 9686, 9710, 9851, 9862, 9932, 9939, 9984, 10126, 10143, 10173, 10247, 10353, 10394, 10461, 10501, 10588, 10610, 10617, 10619, 10659, 10808, 10872, 10909, 10966, 10987, 10992, 11094, 11182, 11421, 11430, 11506, 11537, 11771, 11797, 11916, 11975, 12323, 12390, 12454, 12466, 12525, 12594, 12619, 12624, 12694, 12747, 12756, 12838, 12923, 12927, 12935, 13033, 13111, 13148, 13335, 13384, 13437, 13550, 13614, 13682, 13872, 13899, 13903, 13987, 14001, 14056, 14240, 14255, 14415, 14504, 14561, 14562, 14622, 14762, 14799, 14822, 14919, 14992, 15094, 15096, 15118, 15165, 15224, 15224, 15253, 15268, 15411, 15530, 15612, 15638, 15694, 15737, 15768, 15992, 16012, 16121, 16249, 16464, 16610, 16621, 16647, 16654, 16657, 16668, 16673, 16711, 16724, 16726, 16910, 16983, 17045, 17053, 17055, 17106, 17109, 17121, 17131, 17185, 17194, 17333, 17359, 17402, 17413, 17596, 17638, 17711, 17806, 17822, 17901, 17914, 17948, 17949, 18061, 18114, 18207, 18229, 18336, 18350, 18383, 18416, 18429, 18797, 18801, 18804, 18818, 18844, 18983, 18987, 19051, 19118, 19147, 19203, 19205, 19255, 19343, 19355, 19486, 19566, 19576, 19588, 19861, 19872, 19900, 19913, 19920, 19968 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(57, result.number);
            Assert.AreEqual(3084792, result.newNumber);
        }


        [TestMethod]
        public void TestMethod425()
        {
            int[] numbers = new int[] { 124, 242, 383, 385, 471, 500, 661, 701, 765, 772, 1169, 1210, 1559, 1999, 2278, 2333, 2368, 2372, 2760, 2821, 2839, 2998, 3011, 3014, 3045, 3151, 3679, 3722, 3753, 3837, 3918, 4118, 4126, 4171, 4367, 4464, 4587, 5192, 5528, 5667, 5677, 5955, 6008, 6367, 6389, 6456, 6511, 6657, 6717, 7251, 7411, 7466, 7570, 7952, 8109, 8119, 8678, 8706, 8793, 8810, 8881, 8894, 8939, 9070, 9193, 9390, 9545, 9557, 9725, 9726, 9782, 9827, 10142, 10616, 10719, 10739, 10926, 11072, 11115, 11196, 11196, 11258, 11311, 11438, 11484, 11563, 11685, 11759, 11890, 11908, 12007, 12074, 12185, 12209, 12597, 12629, 12752, 12795, 12869, 13079, 13242, 14117, 14132, 14166, 14794, 14823, 14951, 14999, 15087, 15325, 15529, 15669, 15759, 15762, 16261, 16304, 16346, 16383, 16730, 16762, 16793, 16935, 17142, 17250, 17318, 17323, 17583, 17642, 17680, 17684, 17718, 17847, 17861, 17873, 17901, 17912, 17957, 17986, 17995, 18403, 18458, 18519, 18535, 18660, 18965, 19305, 19321, 19574, 19613, 19627, 19673, 19810, 19988 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(385, result.number);
            Assert.AreEqual(1597104, result.newNumber);
        }


        [TestMethod]
        public void TestMethod426()
        {
            int[] numbers = new int[] { 2921, 15559, 16903, 17991, 18730 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(2921, result.number);
            Assert.AreEqual(1, result.newNumber);
        }


        [TestMethod]
        public void TestMethod427()
        {
            int[] numbers = new int[] { 345, 450, 572, 736, 794, 954, 1018, 1129, 1275, 1299, 1485, 1718, 1864, 2099, 2171, 2258, 2408, 2587, 2803, 3450, 3861, 4094, 4190, 4255, 4604, 4661, 4662, 4723, 5187, 5230, 5239, 5318, 5339, 5402, 5974, 6003, 7057, 7369, 7494, 7659, 7977, 8228, 8426, 8785, 8979, 9186, 9311, 9354, 9952, 10235, 10497, 10623, 10952, 11125, 11386, 11400, 11534, 11969, 12273, 12487, 12543, 12568, 12753, 13118, 13225, 13369, 13458, 13653, 13690, 14439, 14541, 14575, 14773, 14789, 14851, 15173, 15380, 15476, 15628, 16020, 16257, 16323, 16404, 16797, 16933, 16969, 16993, 17230, 17403, 17621, 18329, 18945, 19020, 19265, 19785, 19834, 19855 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(345, result.number);
            Assert.AreEqual(926985, result.newNumber);
        }


        [TestMethod]
        public void TestMethod428()
        {
            int[] numbers = new int[] { 298, 452, 883, 1212, 1679, 1772, 1802, 1996, 2165, 2327, 2379, 2537, 2556, 2872, 2933, 2998, 3101, 3382, 3483, 3580, 3952, 4233, 4343, 4779, 4827, 5200, 5422, 5705, 5761, 5782, 5811, 5962, 6254, 6313, 6422, 6528, 8770, 9026, 9029, 9372, 9711, 9982, 9982, 10007, 10205, 10222, 11883, 12232, 12574, 12825, 13695, 13715, 14346, 14438, 14808, 15691, 15739, 15979, 16245, 16764, 16940, 17037, 17114, 17127, 17187, 17819, 18024, 18641, 18719, 18771, 18850, 19104 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(452, result.number);
            Assert.AreEqual(635518, result.newNumber);
        }


        [TestMethod]
        public void TestMethod429()
        {
            int[] numbers = new int[] { 18, 82, 149, 281, 463, 677, 931, 1023, 1029, 1067, 1196, 1303, 1318, 1399, 1424, 1452, 1699, 1781, 1881, 1902, 2111, 2156, 2169, 2295, 2438, 2446, 2642, 2743, 2903, 2940, 2990, 3039, 3082, 3258, 3262, 3265, 3268, 3410, 3579, 3594, 3785, 3799, 3830, 3859, 3950, 4018, 4034, 4094, 4163, 4239, 4281, 4395, 4446, 4483, 4524, 4586, 4800, 4990, 5153, 5251, 5252, 5289, 5352, 5510, 5676, 6152, 6175, 6258, 6323, 6538, 6650, 6686, 6770, 6949, 7149, 7181, 7209, 7215, 7300, 7434, 7515, 7896, 7954, 7974, 8062, 8143, 8340, 8389, 8411, 8501, 8610, 8620, 8706, 8759, 8905, 9104, 9126, 9142, 9149, 9400, 9456, 9546, 9605, 9795, 10067, 10104, 10180, 10228, 10413, 10472, 10648, 10703, 10864, 10882, 11006, 11042, 11144, 11226, 11342, 11379, 11997, 12039, 12136, 12186, 12229, 12273, 12399, 12467, 12711, 12848, 12943, 12970, 13015, 13052, 13097, 13329, 13463, 13904, 14027, 14134, 14208, 14241, 14248, 14252, 14286, 14654, 14846, 14877, 14928, 14991, 15044, 15329, 15570, 15619, 15642, 15721, 15891, 16015, 16253, 16488, 16503, 16528, 16580, 16584, 16672, 16753, 17128, 17215, 17304, 17334, 17351, 17636, 17651, 17705, 17744, 18030, 18057, 18071, 18109, 18226, 18472, 18809, 18927, 18961, 19033, 19034, 19086, 19137, 19147, 19241, 19340, 19810, 19912, 19946, 19992 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(149, result.number);
            Assert.AreEqual(1868572, result.newNumber);
        }


        [TestMethod]
        public void TestMethod430()
        {
            int[] numbers = new int[] { 250, 481, 1178, 1206, 1242, 1342, 2055, 3119, 3436, 3466, 3630, 3900, 4362, 4383, 4565, 4594, 4646, 4704, 4858, 5271, 5385, 5393, 6517, 6649, 6737, 6766, 6790, 6830, 7286, 7480, 7736, 8187, 8280, 8578, 8664, 8850, 9167, 9171, 9523, 9841, 9853, 9886, 9903, 9989, 10346, 10821, 10900, 11091, 11383, 11454, 11748, 11825, 12096, 12268, 12724, 13249, 13438, 13540, 13727, 14471, 14646, 14682, 14865, 14968, 15069, 15114, 15226, 15382, 15680, 15910, 16531, 16568, 16863, 17571, 18118, 18208, 18457, 18690, 18802, 18996, 19186, 19532, 19577, 19728, 19964 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(250, result.number);
            Assert.AreEqual(868284, result.newNumber);
        }


        [TestMethod]
        public void TestMethod431()
        {
            int[] numbers = new int[] { 2, 30, 53, 99, 116, 123, 171, 252, 375, 507, 523, 536, 810, 883, 982, 1102, 1337, 1417, 1446, 1612, 1909, 1991, 2001, 2077, 2168, 2220, 2226, 2269, 2274, 2368, 2401, 2513, 2661, 2690, 2703, 2794, 2811, 2894, 2916, 3021, 3044, 3101, 3217, 3351, 3396, 3414, 3589, 3595, 3615, 3636, 3737, 3805, 3815, 3989, 4018, 4315, 4363, 4425, 4461, 4464, 4478, 4554, 4583, 4619, 4719, 4742, 4962, 4962, 5174, 5229, 5346, 5364, 5370, 5434, 5434, 5548, 5682, 5741, 5772, 5798, 5868, 5888, 5901, 6019, 6029, 6080, 6279, 6281, 6328, 6338, 6390, 6468, 6571, 6660, 6692, 6702, 6751, 6766, 6792, 6808, 6878, 6940, 6940, 6985, 7010, 7082, 7504, 7793, 7831, 7892, 7909, 8138, 8268, 8292, 8327, 8329, 8395, 8449, 8522, 8645, 8742, 8980, 9062, 9079, 9095, 9106, 9196, 9349, 9356, 9477, 9511, 9537, 9735, 9804, 9917, 9939, 10028, 10061, 10098, 10155, 10298, 10359, 10502, 10504, 10592, 10606, 10616, 10635, 10734, 10782, 10830, 10864, 10999, 11010, 11020, 11023, 11086, 11257, 11515, 11576, 11638, 11771, 11799, 11901, 11922, 11935, 12052, 12160, 12449, 12569, 12630, 12912, 13034, 13192, 13218, 13299, 13376, 13402, 13496, 13531, 13672, 13747, 13776, 13835, 13982, 14014, 14204, 14232, 14298, 14433, 14439, 14522, 14577, 14604, 14621, 14657, 14693, 14699, 14832, 14850, 14865, 15043, 15045, 15072, 15093, 15106, 15112, 15124, 15146, 15211, 15269, 15417, 15485, 15736, 15750, 15751, 15828, 15945, 16003, 16060, 16063, 16156, 16170, 16332, 16386, 16412, 16427, 16512, 16518, 16570, 16610, 16697, 16746, 17136, 17166, 17213, 17285, 17292, 17336, 17417, 17445, 17447, 17461, 17476, 17523, 17532, 17832, 17846, 17975, 17996, 18016, 18022, 18074, 18138, 18140, 18185, 18332, 18333, 18403, 18462, 18523, 18554, 18635, 18704, 18900, 18973, 19196, 19272, 19287, 19295, 19362, 19410, 19415, 19638, 19691, 19849, 19886, 19970 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(123, result.number);
            Assert.AreEqual(2816942, result.newNumber);
        }


        [TestMethod]
        public void TestMethod432()
        {
            int[] numbers = new int[] { 4, 79, 83, 295, 365, 422, 813, 1057, 1239, 1279, 1353, 1447, 1548, 2167, 2174, 2191, 2336, 2363, 2518, 2581, 2619, 2719, 2758, 2894, 3059, 3076, 3093, 3346, 3365, 3571, 3738, 3801, 3809, 3957, 4224, 4342, 4453, 4466, 4477, 4685, 4893, 4957, 5037, 5161, 5223, 5377, 5454, 5520, 5632, 5722, 5780, 5792, 5941, 6235, 6247, 6248, 6294, 6418, 6611, 6648, 6707, 6793, 7033, 7259, 7350, 7427, 7496, 7530, 7658, 7669, 7788, 7966, 8031, 8059, 8336, 8402, 8456, 8513, 8515, 8563, 8606, 8636, 8665, 8810, 8878, 8889, 8953, 8993, 9253, 9341, 9465, 9510, 9544, 9672, 9717, 10179, 10214, 10234, 10339, 10346, 10347, 10350, 10471, 10583, 10651, 10694, 10747, 10959, 10985, 11077, 11079, 11302, 11470, 11564, 11648, 11906, 11926, 12062, 12193, 12298, 12351, 12613, 12631, 12708, 12742, 12748, 12794, 12858, 12874, 12898, 12905, 12950, 13086, 13139, 13381, 13388, 13562, 13568, 13603, 13621, 13812, 13918, 13988, 14369, 14465, 14516, 14686, 14753, 14893, 14937, 15183, 15250, 15372, 15525, 15577, 15610, 15751, 15801, 16007, 16021, 16026, 16112, 16119, 16186, 16238, 16421, 16589, 16606, 16622, 16838, 16851, 16852, 16936, 17014, 17202, 17212, 17270, 17304, 17305, 17335, 17461, 17788, 17858, 17900, 17942, 18019, 18102, 18105, 18259, 18262, 18265, 18266, 18330, 18421, 18432, 18628, 18688, 18765, 18906, 18925, 19026, 19448, 19533, 19583, 19602, 19609, 19820, 19921 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(4, result.number);
            Assert.AreEqual(2196712, result.newNumber);
        }


        [TestMethod]
        public void TestMethod433()
        {
            int[] numbers = new int[] { 394, 490, 533, 661, 675, 735, 800, 849, 1048, 1090, 1158, 1207, 1217, 1283, 1317, 1364, 1416, 1419, 1541, 1565, 1577, 1692, 1859, 1948, 1998, 2050, 2092, 2222, 2395, 2614, 2758, 2793, 2796, 2880, 2899, 3063, 3142, 3219, 3244, 3283, 3621, 3644, 3678, 3811, 3953, 3963, 4090, 4251, 4301, 4353, 4406, 4474, 4494, 4498, 4600, 4626, 4737, 4862, 4887, 5103, 5334, 5352, 5352, 5492, 5520, 5562, 5606, 5966, 6163, 6257, 6364, 6474, 6851, 7457, 7729, 7767, 7944, 7993, 8001, 8295, 8329, 8483, 8565, 8817, 9175, 9185, 9230, 9286, 9329, 9431, 9658, 9661, 9699, 9735, 9778, 9858, 9925, 10130, 10174, 10174, 10212, 10256, 10263, 10339, 10424, 10518, 10583, 10681, 11022, 11104, 11219, 11366, 11412, 11438, 11440, 11475, 11632, 11880, 12010, 12034, 12069, 12171, 12283, 12340, 12569, 12618, 12666, 12768, 12893, 12897, 12931, 12993, 12994, 13037, 13092, 13102, 13123, 13142, 13145, 13306, 13385, 13547, 13548, 13564, 13683, 13768, 13911, 13923, 13949, 13954, 14067, 14260, 14343, 14346, 14371, 14512, 14783, 14998, 15128, 15289, 15328, 15341, 15363, 15480, 15726, 15735, 15757, 15790, 15792, 16100, 16233, 16261, 16335, 16376, 16536, 16744, 16792, 16930, 16975, 17073, 17085, 17224, 17406, 17535, 17595, 17795, 17864, 18067, 18129, 18172, 18193, 18254, 18272, 18301, 18562, 18585, 18658, 18659, 18821, 18847, 19071, 19137, 19154, 19234, 19240, 19246, 19256, 19349, 19386, 19395, 19489, 19642, 19654, 19709, 19812, 19988 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(394, result.number);
            Assert.AreEqual(2230383, result.newNumber);
        }


        [TestMethod]
        public void TestMethod434()
        {
            int[] numbers = new int[] { 29, 37, 138, 232, 547, 1230, 1243, 1250, 1385, 1411, 1446, 1486, 1587, 1683, 1724, 2128, 2246, 2339, 2352, 2428, 2490, 2556, 2596, 2696, 2722, 2768, 2931, 2933, 2939, 3020, 3308, 3321, 3328, 3447, 3476, 3507, 3520, 3581, 3682, 3727, 3771, 3829, 4189, 4388, 4412, 4449, 4551, 4823, 4842, 4861, 4861, 4960, 4968, 4979, 5092, 5225, 5310, 5552, 5721, 5769, 5806, 5852, 6125, 6265, 6523, 6564, 6702, 6802, 6853, 6893, 6901, 6921, 6930, 7012, 7190, 7230, 7262, 7293, 7395, 7467, 7480, 7614, 7700, 7760, 7896, 7991, 8027, 8164, 8313, 8369, 8534, 8541, 8597, 8727, 8821, 8825, 8961, 8999, 9068, 9102, 9105, 9112, 9112, 9199, 9207, 9467, 9478, 9556, 9770, 9847, 9925, 9993, 10099, 10133, 10261, 10284, 10434, 10501, 10582, 10779, 10811, 10874, 11375, 11434, 11747, 11988, 11998, 12037, 12175, 12178, 12312, 12683, 12708, 12727, 12862, 12990, 12997, 13030, 13221, 13246, 13329, 13384, 13452, 13474, 13593, 13607, 13746, 14060, 14171, 14298, 14303, 14394, 14401, 14402, 14515, 14521, 14526, 14555, 14581, 14724, 14750, 14901, 14908, 14950, 14995, 15004, 15300, 15471, 15475, 15504, 15579, 15634, 15728, 15732, 15739, 15761, 15763, 16024, 16033, 16389, 16451, 16567, 16569, 16659, 16853, 17024, 17034, 17155, 17218, 17356, 17414, 17541, 17880, 18228, 18298, 18375, 18383, 18434, 18549, 18666, 18696, 18699, 18775, 18846, 18907, 19139, 19154, 19245, 19271, 19597, 19644, 19720, 19756 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(232, result.number);
            Assert.AreEqual(2119576, result.newNumber);
        }


        [TestMethod]
        public void TestMethod435()
        {
            int[] numbers = new int[] { 159, 183, 220, 296, 306, 385, 453, 749, 1036, 1056, 1062, 1134, 1203, 1340, 1447, 1548, 1595, 1615, 1732, 1757, 1818, 1845, 1926, 1939, 1941, 2374, 2571, 2634, 2735, 2805, 2831, 2857, 2872, 2879, 2948, 3039, 3098, 3482, 3663, 3691, 3754, 3847, 3911, 3958, 4012, 4013, 4045, 4050, 4223, 4270, 4323, 4412, 4514, 4655, 4852, 4857, 4907, 4918, 4921, 4958, 5048, 5048, 5059, 5399, 5505, 5618, 5670, 5873, 5967, 5994, 6021, 6286, 6360, 6381, 6401, 6428, 6440, 6496, 6542, 6544, 6564, 6898, 7058, 7083, 7098, 7102, 7250, 7282, 7283, 7436, 7520, 7615, 7665, 7725, 7797, 7811, 7814, 7997, 8159, 8261, 8481, 8557, 8688, 8704, 8768, 8777, 8864, 9028, 9035, 9072, 9082, 9139, 9297, 9327, 9398, 9410, 9517, 9609, 9634, 9653, 9669, 9717, 9870, 10096, 10176, 10300, 10350, 10454, 10478, 10533, 10563, 10567, 10670, 10690, 10815, 10924, 11052, 11081, 11131, 11142, 11144, 11161, 11169, 11201, 11265, 11268, 11521, 11637, 11865, 11886, 11932, 11942, 11948, 12004, 12008, 12159, 12262, 12317, 12332, 12354, 12453, 12483, 12688, 12693, 12796, 12929, 12968, 13025, 13105, 13153, 13161, 13284, 13460, 13616, 13681, 13714, 13786, 13793, 13796, 13852, 14180, 14334, 14404, 14419, 14465, 14538, 14617, 14673, 14690, 14724, 14747, 14852, 14914, 14984, 15047, 15106, 15313, 15347, 15378, 15454, 15524, 15578, 15814, 15823, 15942, 16042, 16088, 16304, 16307, 16628, 16845, 17130, 17231, 17325, 17373, 17410, 17573, 17587, 17664, 17816, 17848, 17882, 17883, 18014, 18092, 18094, 18182, 18234, 18414, 18467, 18477, 18729, 18896, 18910, 19250, 19381, 19427, 19461, 19493, 19504, 19513, 19665 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(296, result.number);
            Assert.AreEqual(2360724, result.newNumber);
        }


        [TestMethod]
        public void TestMethod436()
        {
            int[] numbers = new int[] { 220, 307, 444, 463, 654, 1160, 1797, 1816, 2061, 2183, 2191, 2316, 2411, 2579, 3006, 3289, 3430, 3497, 3803, 3911, 4130, 4243, 4593, 4782, 4821, 5209, 5279, 5440, 5488, 5652, 5740, 5771, 5827, 5942, 6028, 6033, 6226, 6357, 6417, 6660, 6673, 6706, 6815, 6929, 6947, 7066, 7108, 7118, 7204, 7271, 7351, 7520, 7557, 7768, 8019, 8022, 8024, 8579, 8667, 8918, 9386, 9448, 9489, 9587, 9815, 9950, 10005, 10206, 10214, 10424, 10495, 10509, 10618, 10657, 10815, 10867, 10917, 11059, 11158, 11237, 11505, 11539, 11662, 11674, 11773, 11941, 12060, 12111, 12301, 12310, 12446, 12453, 12484, 12533, 12997, 13058, 13240, 13273, 13464, 13509, 13948, 13964, 14058, 14359, 14535, 14718, 15006, 15156, 15375, 15422, 15469, 15471, 15526, 15613, 15789, 15803, 15822, 16041, 16106, 16223, 16628, 16981, 17086, 17102, 17273, 17405, 17594, 17649, 17672, 17714, 17725, 17927, 18005, 18148, 18250, 18368, 18558, 18647, 18709, 18749, 18771, 19336, 19810 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(220, result.number);
            Assert.AreEqual(1469272, result.newNumber);
        }


        [TestMethod]
        public void TestMethod437()
        {
            int[] numbers = new int[] { 109, 145, 166, 173, 209, 254, 277, 305, 317, 322, 355, 372, 394, 570, 610, 661, 692, 746, 768, 1126, 1310, 1310, 1334, 1352, 1389, 1468, 1750, 1767, 1878, 2014, 2037, 2169, 2250, 2261, 2270, 2565, 2670, 2778, 2807, 2810, 2829, 2896, 3040, 3099, 3149, 3357, 3374, 3381, 3402, 3403, 3457, 3461, 3488, 3848, 3868, 3869, 4053, 4059, 4097, 4141, 4181, 4186, 4208, 4244, 4284, 4333, 4381, 4421, 4517, 4566, 4570, 4579, 4601, 4616, 4672, 4691, 4694, 4705, 4823, 4835, 5111, 5235, 5252, 5346, 5467, 5475, 5607, 5817, 5877, 6145, 6305, 6392, 6579, 6644, 6782, 6830, 6843, 6854, 6875, 6882, 6883, 6934, 6982, 7151, 7154, 7190, 7227, 7365, 7394, 7418, 7451, 7504, 7557, 7562, 7857, 7883, 7913, 7982, 8012, 8081, 8131, 8162, 8298, 8402, 8516, 8593, 8658, 9013, 9104, 9135, 9229, 9276, 9495, 9660, 9661, 9788, 9813, 9848, 9946, 10044, 10448, 10905, 10967, 11051, 11123, 11184, 11258, 11284, 11302, 11535, 11621, 11758, 11786, 11805, 11914, 11928, 12278, 12298, 12349, 12482, 12497, 12509, 12614, 12690, 12700, 12747, 12761, 12868, 13007, 13028, 13069, 13510, 13543, 13608, 13635, 13731, 13767, 13827, 13938, 13985, 14421, 14480, 14634, 14730, 14885, 15002, 15085, 15110, 15172, 15342, 15387, 15468, 15666, 15678, 15700, 15731, 15849, 15905, 15973, 16012, 16075, 16094, 16137, 16285, 16352, 16638, 16687, 16735, 16786, 16841, 16935, 17053, 17090, 17099, 17387, 17469, 17592, 17599, 17757, 17850, 17869, 17877, 18116, 18190, 18316, 18345, 18529, 18885, 19046, 19251, 19341, 19353, 19432, 19500, 19645, 19667, 19688, 19730, 19871, 19949, 19959, 19963 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(145, result.number);
            Assert.AreEqual(2223290, result.newNumber);
        }


        [TestMethod]
        public void TestMethod438()
        {
            int[] numbers = new int[] { 9, 177, 248, 297, 371, 516, 524, 560, 599, 769, 900, 906, 1224, 1238, 1289, 1296, 1323, 1585, 1599, 1609, 1655, 1879, 1910, 2005, 2037, 2086, 2107, 2185, 2207, 2241, 2261, 2299, 2359, 2449, 2481, 2485, 2576, 2603, 2605, 2678, 2788, 2853, 2901, 2910, 3084, 3128, 3221, 3222, 3434, 3696, 3798, 3879, 3891, 3963, 3974, 4228, 4262, 4389, 4415, 4751, 4753, 5258, 5273, 5282, 5297, 5350, 5421, 5608, 5739, 5811, 5832, 5845, 5970, 6032, 6043, 6203, 6249, 6277, 6278, 6294, 6300, 6355, 6469, 6481, 6632, 6736, 6773, 7054, 7100, 7285, 7346, 7349, 7463, 7470, 7626, 7698, 7861, 7952, 7960, 7962, 8103, 8139, 8152, 8280, 8325, 8341, 8376, 8410, 8467, 8528, 8535, 8675, 8831, 8903, 8944, 8958, 8964, 9006, 9051, 9123, 9321, 9369, 9474, 9564, 9607, 9721, 9875, 9956, 10046, 10151, 10249, 10414, 10420, 10644, 10678, 10686, 11133, 11350, 11394, 11537, 11708, 11799, 11981, 12222, 12282, 12335, 12386, 12436, 12581, 12828, 12865, 12909, 12938, 13032, 13213, 13254, 13293, 13428, 13539, 13586, 13645, 13654, 13678, 13711, 13764, 13807, 13814, 14012, 14088, 14161, 14179, 14260, 14374, 14569, 14606, 14862, 15287, 15338, 15418, 15660, 15751, 15758, 15789, 15789, 15810, 15879, 15890, 16075, 16113, 16252, 16356, 16420, 16430, 16664, 16722, 16743, 16771, 16791, 16815, 16981, 16992, 17038, 17298, 17337, 17371, 17548, 17624, 17652, 17655, 17705, 17762, 17831, 17856, 17916, 18079, 18084, 18133, 18148, 18153, 18218, 18223, 18286, 18463, 18524, 18711, 18915, 18936, 18938, 19110, 19122, 19144, 19145, 19186, 19223, 19399, 19443, 19645, 19661, 19738, 19927 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(9, result.number);
            Assert.AreEqual(2372626, result.newNumber);
        }


        [TestMethod]
        public void TestMethod439()
        {
            int[] numbers = new int[] { 50, 66, 190, 191, 192, 221, 447, 456, 457, 564, 600, 660, 785, 796, 800, 801, 819, 826, 840, 915, 948, 958, 961, 1043, 1075, 1164, 1233, 1276, 1683, 1706, 1787, 1842, 1916, 2006, 2068, 2078, 2129, 2157, 2194, 2198, 2215, 2237, 2311, 2394, 2543, 2553, 2617, 2776, 2918, 2921, 3013, 3021, 3025, 3033, 3081, 3144, 3160, 3222, 3247, 3378, 3417, 3427, 3469, 3613, 3618, 3681, 3690, 3816, 3874, 3909, 4076, 4140, 4223, 4332, 4598, 4638, 4653, 4744, 4744, 4772, 4877, 4903, 4952, 4965, 4965, 5123, 5126, 5134, 5286, 5347, 5404, 5477, 5506, 5578, 5579, 5614, 5782, 6068, 6229, 6242, 6348, 6421, 6618, 6692, 6894, 6901, 7153, 7164, 7166, 7182, 7221, 7293, 7301, 7318, 7451, 7537, 7539, 7601, 7632, 7705, 7783, 7823, 7832, 7971, 7986, 8026, 8101, 8146, 8237, 8540, 8652, 8711, 8778, 8924, 9015, 9019, 9040, 9041, 9236, 9378, 9465, 9613, 9711, 9734, 9777, 9797, 9837, 9838, 9896, 9999, 10043, 10191, 10267, 10368, 10408, 10459, 10477, 10481, 10637, 10765, 10767, 10770, 10906, 10985, 11047, 11229, 11230, 11332, 11347, 11378, 11484, 11513, 11593, 11649, 11728, 11786, 11791, 11798, 11915, 11932, 12074, 12079, 12126, 12241, 12286, 12354, 12402, 12506, 12530, 12596, 12950, 13031, 13114, 13123, 13129, 13137, 13248, 13299, 13306, 13374, 13426, 13446, 13488, 13782, 13886, 14045, 14075, 14195, 14283, 14302, 14395, 14492, 14511, 14512, 14785, 14833, 14833, 14885, 14904, 15018, 15056, 15095, 15232, 15453, 15553, 15566, 15580, 15611, 15618, 15658, 15684, 15780, 15820, 15948, 15978, 16055, 16123, 16191, 16221, 16418, 16492, 16541, 16597, 16663, 16720, 16742, 16799, 16820, 16863, 16905, 16933, 16988, 17185, 17233, 17316, 17332, 17348, 17446, 17577, 17737, 17790, 17855, 17992, 18058, 18075, 18096, 18148, 18220, 18238, 18252, 18315, 18434, 18483, 18485, 18555, 18661, 18777, 18805, 18864, 18960, 18988, 19045, 19119, 19158, 19278, 19389, 19399, 19488, 19491, 19518, 19585, 19841, 19871, 19996 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(191, result.number);
            Assert.AreEqual(2866694, result.newNumber);
        }


        [TestMethod]
        public void TestMethod440()
        {
            int[] numbers = new int[] { 422, 476, 482, 692, 755, 925, 1047, 1083, 1124, 1151, 1154, 1336, 1469, 1552, 1556, 1744, 1785, 1829, 1848, 1949, 1989, 1995, 2098, 2170, 2202, 2351, 2459, 2635, 2700, 2772, 3073, 3332, 3333, 3438, 3644, 3811, 3823, 3925, 4107, 4156, 4164, 4204, 4240, 4525, 4555, 4579, 4649, 4731, 4732, 4751, 5011, 5300, 5340, 5379, 5384, 5505, 5559, 5575, 5598, 5638, 5638, 5666, 5855, 5949, 6037, 6074, 6253, 6290, 6308, 6898, 6930, 7005, 7021, 7063, 7083, 7103, 7188, 7297, 7362, 7686, 7750, 8106, 8306, 8346, 8379, 8422, 8502, 8509, 8557, 8850, 9052, 9054, 9131, 9202, 9216, 9240, 9256, 9264, 9324, 9390, 9586, 9779, 9842, 9934, 9981, 10298, 10389, 10565, 10591, 10758, 10924, 10990, 11001, 11069, 11118, 11192, 11381, 11635, 11702, 11720, 11889, 11904, 12006, 12057, 12078, 12140, 12158, 12269, 12455, 12463, 12546, 12548, 12585, 12815, 12822, 12871, 12954, 13012, 13155, 13233, 13416, 13483, 13559, 13637, 13651, 13740, 13915, 13943, 14111, 14116, 14251, 14712, 14840, 14951, 14968, 15162, 15234, 15363, 15528, 15619, 15681, 15925, 15958, 15984, 16221, 16227, 16327, 16369, 16401, 16652, 16881, 16949, 17001, 17339, 17741, 17742, 17883, 18223, 18272, 18488, 18564, 18665, 18903, 18983, 18985, 18990, 19110, 19190, 19271, 19437, 19460, 19659, 19672, 19721, 19810, 19830, 19908 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(422, result.number);
            Assert.AreEqual(1906765, result.newNumber);
        }


        [TestMethod]
        public void TestMethod441()
        {
            int[] numbers = new int[] { 81, 100, 317, 364, 506, 540, 553, 809, 918, 920, 1011, 1063, 1212, 1236, 1271, 1446, 1478, 1724, 1859, 1895, 1982, 2309, 2432, 2616, 2693, 2797, 2870, 3047, 3299, 3356, 3453, 3477, 3754, 3761, 4333, 4345, 4539, 4569, 4622, 4662, 4690, 4889, 4922, 4967, 5019, 5238, 5311, 5316, 5456, 5510, 5727, 5884, 5968, 6431, 6672, 6781, 6782, 6915, 7163, 7236, 7237, 7247, 7300, 7408, 7538, 7581, 7646, 7814, 7901, 7981, 8204, 8375, 8622, 8666, 8677, 8679, 8865, 8933, 8954, 9034, 9104, 9232, 9299, 9306, 9587, 9610, 9877, 9951, 10255, 10280, 10301, 10399, 10412, 10657, 10728, 10899, 10956, 10990, 11213, 11312, 11481, 11835, 12004, 12134, 12367, 12382, 12422, 12436, 12543, 12570, 12719, 13009, 13052, 13138, 13348, 13438, 13571, 13724, 14026, 14172, 14259, 14288, 14356, 14450, 14579, 14665, 14725, 14744, 14763, 15016, 15069, 15073, 15076, 15268, 15316, 15390, 15811, 15957, 15996, 16078, 16349, 16421, 16579, 16591, 16840, 16921, 17172, 17194, 17271, 17308, 17341, 17442, 17669, 17735, 17851, 17873, 18104, 18123, 18371, 18508, 18742, 18951, 19051, 19281, 19370, 19433, 19456, 19758, 19789, 19899 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(317, result.number);
            Assert.AreEqual(1668095, result.newNumber);
        }


        [TestMethod]
        public void TestMethod442()
        {
            int[] numbers = new int[] { 85, 364, 516, 809, 868, 1419, 1534, 1684, 2228, 2239, 2369, 2378, 2483, 2850, 3042, 3078, 3275, 3487, 3657, 3702, 4329, 4364, 4560, 4580, 4627, 4738, 5062, 5228, 5385, 5635, 5793, 5902, 5957, 6191, 6197, 6254, 6551, 6707, 7291, 7332, 7379, 7654, 7738, 7862, 7908, 8057, 8066, 8096, 8137, 8415, 8495, 8500, 8676, 9063, 10155, 10548, 10918, 11035, 11137, 11176, 11263, 11544, 11743, 11799, 11988, 12092, 12236, 13165, 13476, 13505, 13764, 13921, 13998, 14031, 14161, 14227, 14311, 14428, 14559, 14649, 14872, 14906, 14931, 15127, 15283, 15340, 15366, 15479, 15563, 15746, 15750, 15757, 15794, 16153, 16259, 16340, 16552, 16561, 16613, 16756, 16796, 16815, 17097, 17305, 17354, 17407, 17572, 17593, 17700, 17726, 18215, 18890, 19066, 19412, 19440, 19478, 19623, 19687, 19753, 19915 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(809, result.number);
            Assert.AreEqual(1273511, result.newNumber);
        }


        [TestMethod]
        public void TestMethod443()
        {
            int[] numbers = new int[] { 345, 517, 812, 897, 968, 1106, 1128, 1149, 1215, 1515, 1593, 1716, 1895, 2439, 3094, 3156, 3358, 3521, 3708, 3982, 4075, 4565, 4606, 4617, 4693, 5167, 5278, 5370, 5516, 5931, 6065, 6347, 6378, 6506, 6592, 6594, 6603, 6655, 6723, 7131, 7428, 7464, 7690, 7709, 7828, 7835, 8258, 8274, 8487, 8878, 8992, 9086, 9207, 9751, 9830, 10128, 10310, 10388, 10537, 10582, 10668, 10805, 10826, 11255, 11399, 11516, 11549, 11632, 11778, 12710, 12966, 13229, 13351, 13996, 14086, 14152, 14163, 14245, 14506, 14552, 14557, 14609, 15416, 15685, 16073, 16900, 16926, 16967, 17056, 17171, 17720, 17882, 17948, 18054, 18073, 18138, 18204, 18236, 18400, 18495, 18528, 18666, 18682, 18685, 18693, 18829, 18886, 19076, 19173, 19216, 19296, 19389, 19590, 19921, 19954 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(897, result.number);
            Assert.AreEqual(1208186, result.newNumber);
        }


        [TestMethod]
        public void TestMethod444()
        {
            int[] numbers = new int[] { 85, 270, 539, 561, 588, 990, 1088, 1664, 2515, 3152, 3478, 3574, 3663, 3739, 3952, 4019, 4491, 4797, 4871, 5019, 5110, 5635, 5764, 6214, 6862, 7203, 7490, 7494, 7593, 7668, 7840, 7949, 9556, 9690, 9699, 10107, 10392, 11001, 11138, 11304, 11334, 11695, 12054, 12404, 12565, 13048, 13218, 13318, 13376, 13659, 13787, 14038, 14420, 14668, 14692, 15326, 16352, 16641, 16938, 17367, 17420, 17447, 18025, 18315, 19576, 19821 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(85, result.number);
            Assert.AreEqual(602494, result.newNumber);
        }


        [TestMethod]
        public void TestMethod445()
        {
            int[] numbers = new int[] { 27, 32, 160, 183, 314, 358, 473, 606, 715, 840, 857, 900, 1011, 1155, 1328, 1346, 1362, 1389, 1420, 1440, 1486, 1566, 1572, 1582, 1600, 1667, 1674, 1679, 1814, 1856, 1924, 1981, 2127, 2271, 2322, 2411, 2422, 2446, 2484, 2649, 2674, 2698, 2753, 2851, 2914, 2956, 3062, 3145, 3210, 3224, 3323, 3453, 3509, 3526, 3540, 3547, 3800, 3819, 3892, 3893, 3966, 4263, 4312, 4349, 4376, 4377, 4500, 4517, 4874, 4898, 4940, 4963, 4972, 5061, 5104, 5185, 5238, 5242, 5305, 5367, 5562, 5596, 5724, 5885, 5931, 5983, 6003, 6121, 6404, 6424, 6450, 6555, 6590, 6760, 6780, 6819, 6865, 7042, 7180, 7225, 7369, 7423, 7549, 7598, 7600, 7834, 7900, 8024, 8163, 8288, 8353, 8355, 8383, 8479, 8518, 8535, 8565, 8577, 8615, 8680, 9001, 9200, 9514, 9550, 9585, 9713, 9774, 9898, 9997, 10026, 10043, 10050, 10194, 10260, 10279, 10490, 10548, 10559, 10560, 10648, 11090, 11095, 11118, 11307, 11341, 11383, 11497, 11500, 11647, 11656, 11706, 11709, 11725, 11744, 11794, 11851, 11877, 11976, 11990, 12186, 12331, 12344, 12395, 12454, 12591, 12747, 12781, 12902, 13137, 13227, 13440, 13499, 13958, 14110, 14210, 14305, 14306, 14349, 14496, 14727, 14780, 15059, 15106, 15108, 15172, 15364, 15523, 15572, 15763, 15790, 15937, 16102, 16162, 16232, 16254, 16332, 16363, 16365, 16520, 16569, 16588, 16592, 16641, 16689, 16950, 17028, 17035, 17038, 17049, 17223, 17259, 17268, 17336, 17426, 17476, 17511, 17599, 17674, 17689, 17719, 18002, 18014, 18016, 18046, 18168, 18350, 18391, 18574, 18635, 18866, 18901, 19103, 19221, 19269, 19328, 19346, 19471, 19503, 19543, 19559, 19584, 19671, 19702, 19756, 19817, 19982 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(27, result.number);
            Assert.AreEqual(2361123, result.newNumber);
        }


        [TestMethod]
        public void TestMethod446()
        {
            int[] numbers = new int[] { 60, 281, 281, 515, 547, 776, 804, 858, 1351, 1506, 1597, 1627, 1786, 1804, 1842, 2001, 2132, 2245, 2413, 2545, 2607, 2946, 2984, 3088, 3180, 3246, 3556, 3638, 3702, 3821, 3847, 4052, 4424, 4611, 4656, 4899, 4995, 5123, 5208, 5256, 5275, 5443, 5642, 5764, 5854, 5910, 6157, 6212, 6240, 6310, 6556, 6685, 6891, 7296, 7608, 7661, 7708, 7974, 8075, 8104, 8202, 8256, 8322, 8496, 8863, 9054, 9213, 9311, 9411, 9430, 9547, 9556, 9628, 9632, 9900, 9930, 10008, 10273, 10567, 10577, 10962, 11132, 11152, 11357, 11493, 11528, 11920, 12218, 12248, 12456, 12474, 12754, 12867, 12955, 13060, 13237, 13299, 13695, 13776, 14157, 14531, 14547, 14638, 14736, 14851, 14972, 15332, 15499, 15650, 15712, 15725, 15742, 15863, 16141, 16273, 16708, 16714, 16743, 16973, 17026, 17062, 17204, 17266, 17335, 17385, 17484, 17508, 17690, 17707, 17747, 17768, 18009, 18248, 18395, 18522, 18895, 19065, 19202, 19385, 19487, 19525, 19559, 19717, 19776, 19874 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(281, result.number);
            Assert.AreEqual(1447061, result.newNumber);
        }


        [TestMethod]
        public void TestMethod447()
        {
            int[] numbers = new int[] { 225, 308, 321, 481, 653, 665, 832, 1098, 1243, 1315, 1318, 1320, 1370, 1412, 1716, 1733, 1762, 1823, 1825, 1978, 1991, 2106, 2142, 2166, 2197, 2202, 2243, 2330, 2452, 2455, 2464, 2566, 2658, 2887, 3078, 3150, 3166, 3240, 3265, 3324, 3420, 3645, 3786, 3798, 3990, 4019, 4066, 4071, 4196, 4204, 4233, 4234, 4258, 4373, 4429, 4476, 4883, 4963, 5174, 5313, 5386, 5410, 5884, 5903, 5937, 5995, 6098, 6223, 6425, 6460, 6582, 6900, 6908, 6910, 7066, 7086, 7232, 7342, 7437, 7572, 7637, 7972, 8053, 8102, 8283, 8389, 8596, 8648, 8754, 8784, 8816, 8874, 8980, 9019, 9030, 9078, 9407, 9520, 9524, 9633, 9809, 9845, 9890, 9956, 10194, 10242, 10258, 10437, 10478, 10492, 10553, 10625, 10645, 10695, 10838, 10871, 10899, 10982, 11056, 11119, 11192, 11298, 11383, 11459, 11626, 11645, 11727, 11847, 11853, 11932, 12048, 12074, 12158, 12198, 12304, 12351, 12365, 12382, 12466, 12501, 12530, 12617, 12701, 12774, 12898, 12962, 13037, 13078, 13182, 13235, 13439, 13475, 13850, 14079, 14106, 14189, 14369, 14391, 14406, 14533, 14765, 14793, 14847, 15021, 15045, 15176, 15203, 15207, 15236, 15241, 15367, 15564, 15856, 15859, 15872, 15948, 16189, 16303, 16512, 16528, 16709, 16891, 17022, 17243, 17252, 17255, 17565, 17672, 17791, 17951, 17960, 17996, 18002, 18036, 18179, 18344, 18379, 18500, 18557, 18617, 18624, 18829, 18841, 18896, 18942, 18998, 19034, 19056, 19112, 19139, 19166, 19172, 19236, 19244, 19262, 19282, 19357, 19700, 19733, 19903, 19940, 19987 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(481, result.number);
            Assert.AreEqual(2271473, result.newNumber);
        }


        [TestMethod]
        public void TestMethod448()
        {
            int[] numbers = new int[] { 2, 10, 22, 84, 311, 345, 422, 575, 635, 743, 859, 866, 908, 955, 1016, 1053, 1113, 1141, 1525, 1638, 1850, 1900, 1909, 1937, 2111, 2130, 2166, 2220, 2232, 2315, 2342, 2343, 2362, 2368, 2395, 2415, 2424, 2497, 2591, 2753, 2801, 2902, 3090, 3146, 3156, 3384, 3496, 3562, 3582, 3594, 3952, 3955, 3997, 4007, 4150, 4300, 4386, 4441, 4451, 4574, 4672, 4743, 4971, 5062, 5112, 5136, 5173, 5372, 5603, 5654, 5784, 5957, 6093, 6177, 6187, 6337, 6345, 6367, 6376, 6521, 6599, 6664, 6691, 6807, 6821, 6825, 6834, 6909, 6913, 6985, 7003, 7012, 7041, 7134, 7299, 7323, 7404, 7405, 7411, 7510, 7602, 7762, 7864, 7967, 8030, 8060, 8107, 8151, 8226, 8306, 8404, 8430, 8459, 8475, 8476, 8505, 8557, 8708, 8921, 8929, 8950, 8954, 8994, 9072, 9096, 9159, 9169, 9201, 9336, 9512, 9745, 9803, 9871, 9950, 9988, 9997, 10051, 10115, 10157, 10189, 10462, 10472, 10482, 10541, 10587, 10634, 10822, 10831, 10904, 10998, 11043, 11055, 11077, 11188, 11276, 11299, 11305, 11346, 11414, 11485, 11523, 11592, 11736, 11788, 11813, 11903, 11978, 12110, 12148, 12150, 12177, 12191, 12266, 12348, 12381, 12470, 12471, 12591, 12637, 12642, 12719, 12820, 12830, 12877, 12911, 12929, 12949, 12955, 13007, 13390, 13400, 13541, 13545, 13597, 13765, 13827, 13831, 13847, 13984, 14181, 14183, 14249, 14257, 14285, 14396, 14413, 14628, 14671, 14696, 14716, 14728, 14755, 14784, 14785, 14883, 14885, 14900, 14910, 15039, 15039, 15046, 15069, 15115, 15177, 15198, 15203, 15203, 15292, 15305, 15330, 15428, 15592, 15645, 15832, 15860, 15988, 16116, 16143, 16241, 16243, 16335, 16352, 16451, 16524, 16579, 16610, 16676, 16755, 16778, 16855, 16986, 17065, 17158, 17185, 17230, 17416, 17479, 17504, 17564, 17742, 17757, 17772, 17894, 17918, 17926, 17957, 18047, 18175, 18216, 18348, 18354, 18469, 18490, 18512, 18600, 18605, 18648, 18662, 18807, 18978, 19022, 19109, 19236, 19260, 19425, 19471, 19530, 19584, 19589, 19745, 19747, 19770, 19804, 19815, 19846, 19998 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(22, result.number);
            Assert.AreEqual(3096034, result.newNumber);
        }


        [TestMethod]
        public void TestMethod449()
        {
            int[] numbers = new int[] { 66, 533, 758, 828, 944, 1076, 1096, 1182, 1228, 1416, 1558, 1747, 2067, 2552, 2557, 2994, 3063, 3187, 3445, 3446, 3461, 3631, 3846, 4182, 4287, 4397, 4432, 4436, 4675, 4689, 4745, 4747, 4828, 4852, 4880, 4881, 4929, 4964, 5711, 5741, 5757, 5791, 5853, 5916, 5928, 5993, 6151, 6302, 6460, 6624, 6830, 7015, 7096, 7138, 7191, 7336, 7369, 7608, 7612, 7694, 7860, 8179, 8341, 8465, 8481, 8506, 8705, 8896, 9046, 9061, 9142, 9173, 9264, 9309, 9324, 9413, 9420, 9423, 9548, 9572, 9623, 9774, 9895, 10255, 10346, 10361, 10365, 10738, 10812, 10984, 11253, 11256, 11318, 11386, 11452, 11463, 11511, 11525, 11553, 11623, 11637, 11922, 12167, 12370, 12474, 12602, 12605, 12796, 13588, 13750, 14349, 14491, 14504, 14505, 14528, 14656, 14831, 14980, 15020, 15133, 15319, 15356, 15664, 15672, 15679, 15726, 15767, 15772, 15798, 16076, 16297, 16299, 16390, 16405, 16430, 16453, 16571, 16834, 16959, 17029, 17064, 17210, 17252, 17441, 17535, 17549, 17619, 17662, 17866, 17965, 17968, 18212, 18285, 18543, 18592, 18598, 18631, 18707, 18765, 18866, 18991, 19013, 19107, 19331, 19446, 19472, 19701, 19728, 19863, 19901 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1096, result.number);
            Assert.AreEqual(1802626, result.newNumber);
        }


        [TestMethod]
        public void TestMethod450()
        {
            int[] numbers = new int[] { 344, 422, 1159, 1210, 1347, 1360, 1408, 1598, 1774, 1792, 2032, 2135, 2258, 2379, 2665, 2795, 2857, 2939, 3047, 3136, 3236, 3793, 3836, 3906, 4032, 4103, 4174, 4324, 4398, 4473, 4499, 4559, 4817, 4857, 4901, 4981, 5023, 5105, 5153, 5247, 5521, 5579, 5816, 5966, 6000, 6215, 6260, 6355, 6741, 6898, 7020, 7050, 7125, 7147, 7200, 7230, 7508, 7597, 7629, 7833, 7914, 7962, 8277, 8358, 8459, 8500, 8699, 8794, 9134, 9145, 9181, 9264, 9343, 9877, 10165, 10654, 10926, 11277, 11398, 11422, 11510, 11739, 11770, 11789, 11814, 11939, 11965, 12025, 12083, 12187, 12284, 12403, 12404, 12483, 12630, 12734, 12750, 12781, 12926, 13046, 13078, 13149, 13291, 13522, 13562, 13732, 13843, 14027, 14327, 14536, 14724, 14728, 14758, 14807, 14858, 14869, 14980, 15040, 15169, 15183, 15208, 15536, 15835, 15972, 16319, 16328, 16385, 16645, 16771, 16961, 17073, 17089, 17318, 17551, 17761, 17789, 17822, 17854, 17904, 18059, 18240, 18369, 18397, 18432, 18532, 18538, 18562, 19064, 19135, 19365, 19394, 19504, 19714, 19741 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(344, result.number);
            Assert.AreEqual(1579092, result.newNumber);
        }


        [TestMethod]
        public void TestMethod451()
        {
            int[] numbers = new int[] { 440, 519, 910, 1060, 1397, 1650, 1712, 1748, 1858, 1999, 2086, 2331, 2646, 2941, 3348, 3425, 3432, 3502, 4139, 4239, 4441, 4739, 4983, 5070, 5102, 5198, 5501, 5512, 5689, 5763, 6202, 6224, 6412, 6771, 6893, 6934, 6935, 6954, 7434, 7503, 7721, 8017, 8165, 8420, 8420, 8429, 8490, 8630, 9015, 9058, 9646, 10245, 10377, 10488, 11118, 11168, 11213, 11519, 11708, 11845, 12363, 12459, 12571, 12689, 12940, 13571, 13657, 14237, 14283, 14715, 14715, 14867, 14936, 15190, 15266, 15443, 15606, 15745, 15906, 16031, 16411, 16516, 16561, 17056, 17303, 17498, 17505, 17874, 17938, 18088, 18330, 18429, 19136, 19214, 19258 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(519, result.number);
            Assert.AreEqual(905087, result.newNumber);
        }


        [TestMethod]
        public void TestMethod452()
        {
            int[] numbers = new int[] { 37, 74, 433, 806, 1048, 1117, 2285, 2966, 3239, 3872, 4151, 5065, 5069, 6238, 6528, 7064, 9028, 9169, 9420, 9588, 9677, 9727, 10153, 10366, 10447, 10481, 10579, 10720, 11275, 11452, 11477, 11489, 13361, 13914, 14074, 14150, 14771, 15457, 15473, 15692, 16497, 16554, 16643, 17276, 17861, 18183, 18290, 18430, 18493, 18917, 19051, 19470, 19837, 19846 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(37, result.number);
            Assert.AreEqual(574738, result.newNumber);
        }


        [TestMethod]
        public void TestMethod453()
        {
            int[] numbers = new int[] { 135, 217, 630, 729, 754, 827, 1087, 1244, 1363, 1371, 1737, 1798, 1827, 1993, 2023, 2086, 2123, 2143, 2181, 2269, 2313, 2364, 2430, 2554, 2811, 2875, 2974, 3199, 3237, 3340, 3393, 3462, 3545, 3713, 3917, 4004, 4067, 4092, 4096, 4153, 4226, 4408, 4622, 4705, 4870, 5807, 5911, 5932, 5992, 6015, 6349, 6459, 6459, 7016, 7116, 7124, 7230, 7238, 7329, 7428, 7528, 7549, 7566, 7579, 7904, 7992, 8032, 8163, 8174, 8223, 8361, 8457, 8457, 8679, 8774, 8917, 9133, 9174, 9219, 9384, 9460, 9527, 9859, 9950, 9999, 10084, 10133, 10403, 10604, 10705, 10757, 11103, 11460, 11553, 11808, 12105, 12179, 12706, 12736, 12953, 13170, 13225, 13559, 13731, 13880, 14000, 14121, 14150, 14480, 14621, 14766, 14950, 14985, 15005, 15007, 15008, 15027, 15065, 15233, 15563, 15570, 15644, 15653, 15680, 15714, 15808, 15981, 16074, 16419, 16425, 16438, 16526, 16807, 17025, 17437, 17578, 17596, 18015, 18064, 18074, 18085, 18159, 18166, 18217, 18327, 18366, 18766, 19221, 19430, 19574, 19778, 19832 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(217, result.number);
            Assert.AreEqual(1448041, result.newNumber);
        }


        [TestMethod]
        public void TestMethod454()
        {
            int[] numbers = new int[] { 305, 368, 417, 442, 482, 538, 706, 727, 847, 907, 1000, 1169, 1226, 1282, 1297, 1315, 1410, 1425, 1463, 1530, 1568, 1604, 1790, 1943, 1969, 2116, 2165, 2215, 2307, 2322, 2342, 2398, 2466, 2500, 2512, 2597, 2690, 2895, 2953, 3135, 3161, 3169, 3277, 3330, 3390, 3415, 3511, 3532, 3537, 3551, 3600, 3604, 3677, 3702, 3781, 3784, 3809, 3851, 3910, 3931, 4022, 4095, 4118, 4136, 4154, 4184, 4197, 4239, 4341, 4398, 4655, 4740, 4950, 4954, 4975, 4976, 4993, 5000, 5015, 5032, 5088, 5104, 5263, 5338, 5464, 5514, 5542, 5625, 5836, 5847, 5876, 5925, 5968, 6078, 6198, 6209, 6229, 6247, 6248, 6248, 6265, 6271, 6454, 6463, 6502, 6534, 6571, 6623, 6750, 6810, 6821, 6826, 6878, 6953, 6956, 7066, 7120, 7383, 7476, 7559, 7853, 8200, 8217, 8257, 8346, 8413, 8417, 8584, 8937, 9155, 9378, 9492, 9554, 9571, 9600, 9644, 9661, 9768, 9843, 9914, 10028, 10053, 10059, 10080, 10134, 10176, 10188, 10269, 10330, 10345, 10384, 10581, 10759, 10877, 11032, 11067, 11071, 11162, 11281, 11412, 11604, 11709, 11792, 11808, 11836, 11875, 11896, 11991, 12056, 12071, 12168, 12250, 12263, 12331, 12331, 12429, 12571, 12607, 12640, 12656, 12663, 12691, 12787, 12837, 12864, 12925, 12930, 13036, 13080, 13106, 13200, 13227, 13362, 13373, 13386, 13395, 13450, 13589, 13800, 13842, 13886, 14050, 14098, 14131, 14150, 14243, 14289, 14507, 14552, 14618, 14764, 14914, 14987, 15022, 15272, 15592, 15608, 15701, 15721, 15790, 15862, 15965, 15999, 16088, 16119, 16257, 16295, 16404, 16424, 16608, 16692, 16710, 16776, 16886, 16969, 16996, 17030, 17064, 17072, 17205, 17227, 17297, 17299, 17353, 17387, 17410, 17464, 17520, 17530, 17565, 17619, 17642, 17751, 17840, 18067, 18146, 18307, 18336, 18510, 18545, 18561, 18752, 18815, 18937, 18955, 18971, 19128, 19383, 19639, 19655, 19668, 19703, 19734, 19788, 19792, 19944 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(305, result.number);
            Assert.AreEqual(2666960, result.newNumber);
        }


        [TestMethod]
        public void TestMethod455()
        {
            int[] numbers = new int[] { 49, 128, 349, 361, 384, 433, 462, 546, 667, 680, 705, 744, 749, 857, 876, 941, 962, 1043, 1129, 1147, 1174, 1237, 1320, 1552, 1669, 1751, 1836, 2131, 2314, 2449, 2656, 2673, 2674, 2723, 2766, 2768, 2776, 2858, 2934, 2975, 3045, 3082, 3158, 3211, 3336, 3546, 3595, 3616, 3669, 3686, 3780, 3996, 4086, 4158, 4319, 4456, 4607, 4716, 4734, 4819, 4993, 5008, 5026, 5044, 5120, 5147, 5171, 5293, 5311, 5405, 5517, 5590, 5609, 5696, 5773, 5937, 5977, 6059, 6091, 6111, 6219, 6389, 6552, 6666, 7013, 7165, 7210, 7343, 7432, 7525, 7557, 7588, 7670, 7693, 7704, 7719, 7763, 7790, 7901, 7903, 7908, 8081, 8081, 8417, 8492, 8611, 8668, 8671, 8699, 8706, 8851, 8936, 9066, 9128, 9168, 9296, 9373, 9432, 9493, 9504, 9512, 9526, 9653, 9700, 9760, 9800, 9854, 9959, 9979, 10011, 10045, 10155, 10204, 10280, 10310, 10458, 10525, 10566, 10680, 10751, 10756, 10772, 10939, 11246, 11271, 11326, 11382, 11394, 11548, 11619, 11656, 11688, 11696, 11708, 11847, 12024, 12157, 12331, 12518, 12531, 12624, 12724, 12789, 12793, 12874, 12953, 12979, 13040, 13137, 13305, 13313, 13707, 13730, 13784, 13804, 13877, 13898, 13902, 13978, 14108, 14168, 14320, 14413, 14416, 14525, 14645, 14713, 14853, 15047, 15062, 15145, 15251, 15300, 15360, 15363, 15505, 15614, 15736, 15917, 16044, 16060, 16147, 16266, 16335, 16345, 16471, 16480, 16545, 16710, 16742, 16775, 16781, 16786, 16831, 16840, 16975, 17158, 17225, 17228, 17256, 17352, 17385, 17386, 17483, 17593, 17608, 17622, 17623, 17784, 17819, 17903, 17947, 18019, 18022, 18025, 18104, 18149, 18235, 18297, 18305, 18320, 18371, 18564, 18682, 18687, 18699, 18834, 18851, 19020, 19172, 19447, 19462, 19539, 19572, 19581, 19878, 19879, 19950 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(49, result.number);
            Assert.AreEqual(2605478, result.newNumber);
        }


        [TestMethod]
        public void TestMethod456()
        {
            int[] numbers = new int[] { 22, 57, 298, 327, 379, 387, 451, 453, 545, 668, 777, 808, 810, 811, 931, 991, 1090, 1102, 1120, 1142, 1238, 1314, 1413, 1515, 1555, 1695, 1770, 1787, 1806, 1854, 1865, 1869, 1895, 1914, 1938, 1981, 1985, 2237, 2239, 2244, 2396, 2630, 2662, 2672, 2826, 2868, 2927, 3010, 3020, 3106, 3170, 3206, 3306, 3380, 3419, 3478, 3483, 3544, 3550, 3818, 3830, 4037, 4091, 4104, 4204, 4271, 4367, 4528, 4565, 4619, 4641, 4647, 4721, 4777, 4788, 4834, 5135, 5170, 5178, 5227, 5296, 5382, 5658, 5675, 5680, 5803, 5816, 5819, 5847, 5886, 5924, 6040, 6103, 6141, 6236, 6325, 6556, 6610, 6939, 6960, 7222, 7253, 7447, 7453, 7506, 7534, 7616, 7762, 7777, 7777, 7893, 8009, 8180, 8222, 8270, 8305, 8538, 8971, 9053, 9057, 9129, 9152, 9367, 9419, 9482, 9570, 9614, 9656, 9676, 9676, 9756, 9984, 10022, 10098, 10115, 10140, 10282, 10317, 10332, 10416, 10469, 10521, 10541, 10548, 10644, 10655, 10684, 10730, 10892, 10981, 11012, 11276, 11400, 11425, 11467, 11473, 11551, 11629, 11698, 11700, 11722, 11782, 11803, 12008, 12143, 12182, 12362, 12498, 12576, 12607, 12649, 12812, 12814, 12953, 13025, 13094, 13161, 13196, 13289, 13295, 13399, 13528, 13606, 13609, 13796, 14065, 14188, 14244, 14286, 14321, 14426, 14437, 14565, 14615, 14616, 14703, 14728, 14761, 14966, 14984, 15140, 15200, 15249, 15388, 15643, 15701, 15724, 15726, 15769, 15878, 15953, 16007, 16037, 16096, 16130, 16162, 16198, 16239, 16243, 16301, 16399, 16433, 16457, 16602, 16605, 16618, 16846, 16886, 16903, 16911, 17019, 17123, 17150, 17167, 17252, 17458, 17490, 17523, 17532, 17658, 17719, 17872, 18119, 18159, 18349, 18363, 18405, 18424, 18432, 18481, 18506, 18511, 18588, 18610, 18615, 18619, 18680, 18862, 18862, 18933, 18952, 19000, 19040, 19183, 19443, 19476, 19719, 19796, 19825, 19895, 19932, 19959 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(57, result.number);
            Assert.AreEqual(2697680, result.newNumber);
        }


        [TestMethod]
        public void TestMethod457()
        {
            int[] numbers = new int[] { 141, 1290, 1522, 2508, 2801, 4070, 4638, 5142, 5377, 6022, 6328, 7057, 7559, 7718, 8748, 9024, 9368, 9460, 9500, 9800, 9963, 9997, 10021, 10127, 10695, 11205, 11243, 11970, 12009, 12590, 13055, 13146, 13582, 13831, 13877, 13924, 14858, 15433, 15653, 15987, 16009, 16252, 16444, 17586, 17809, 17818, 18721, 18944, 18983, 19499, 19832 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(141, result.number);
            Assert.AreEqual(546033, result.newNumber);
        }


        [TestMethod]
        public void TestMethod458()
        {
            int[] numbers = new int[] { 328, 2729, 2952, 3064, 3349, 3864, 3911, 4148, 5084, 5221, 5239, 5552, 5636, 5956, 6452, 6600, 6659, 6958, 7740, 8041, 8292, 8395, 8429, 8451, 9191, 9717, 9909, 10119, 10238, 10677, 10719, 11196, 11534, 11854, 12341, 13706, 14056, 14422, 14638, 14962, 15737, 16073, 16201, 16380, 16521, 16894, 16992, 17156, 17320, 18319, 18914 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(328, result.number);
            Assert.AreEqual(487053, result.newNumber);
        }


        [TestMethod]
        public void TestMethod459()
        {
            int[] numbers = new int[] { 4, 44, 59, 179, 220, 242, 261, 345, 380, 387, 451, 529, 605, 627, 810, 845, 868, 918, 933, 951, 1051, 1337, 1363, 1734, 1742, 1793, 1867, 1999, 2073, 2112, 2258, 2293, 2303, 2348, 2386, 2432, 2457, 2481, 2597, 2613, 2677, 2926, 2929, 2936, 3058, 3158, 3162, 3231, 3236, 3254, 3412, 3457, 3541, 3713, 3784, 3825, 3866, 3935, 4024, 4086, 4115, 4164, 4417, 4425, 4569, 4602, 4693, 4788, 4820, 4867, 4892, 4934, 5017, 5131, 5155, 5160, 5221, 5472, 5492, 5538, 5619, 5791, 5864, 5908, 6027, 6389, 6539, 6715, 6926, 6936, 7030, 7091, 7152, 7204, 7381, 7562, 7563, 7582, 7643, 7746, 7895, 7951, 8030, 8092, 8126, 8131, 8135, 8525, 8654, 8655, 8728, 8775, 8812, 8832, 8842, 8926, 8935, 8975, 9044, 9050, 9333, 9380, 9465, 9470, 9603, 10364, 10365, 10405, 10480, 10533, 10573, 10583, 10709, 10726, 10761, 10766, 10792, 10826, 10885, 10993, 11109, 11118, 11217, 11268, 11401, 11435, 11489, 11529, 11620, 11741, 11898, 11924, 11951, 12009, 12109, 12166, 12221, 12243, 12245, 12447, 12496, 12667, 12917, 12947, 12983, 13230, 13345, 13419, 13504, 13746, 13851, 13876, 13979, 14147, 14203, 14305, 14359, 14418, 14429, 14606, 14642, 14804, 14823, 14863, 14918, 15139, 15149, 15186, 15290, 15317, 15478, 15495, 15510, 15583, 15596, 15702, 15758, 15819, 15845, 15874, 15874, 16025, 16212, 16247, 16339, 16384, 16395, 16407, 16408, 16508, 16520, 16671, 16777, 16872, 16872, 16915, 17132, 17184, 17192, 17197, 17226, 17256, 17477, 17564, 17619, 17700, 17796, 17854, 17863, 17896, 18098, 18271, 18277, 18297, 18324, 18382, 18451, 18508, 18701, 18708, 18842, 18870, 18943, 18997, 19051, 19158, 19181, 19273, 19321, 19328, 19396, 19520, 19540, 19633, 19812, 19895, 19933 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(59, result.number);
            Assert.AreEqual(2566856, result.newNumber);
        }


        [TestMethod]
        public void TestMethod460()
        {
            int[] numbers = new int[] { 247, 7707, 9373, 11279, 12384, 16441, 17324, 18008 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(247, result.number);
            Assert.AreEqual(1, result.newNumber);
        }


        [TestMethod]
        public void TestMethod461()
        {
            int[] numbers = new int[] { 428, 502, 809, 848, 859, 882, 892, 1021, 1266, 1452, 1624, 2015, 2071, 2217, 2581, 2700, 2939, 3018, 3631, 3654, 3776, 3813, 3868, 4064, 4206, 4551, 4570, 5082, 5394, 5600, 5607, 5873, 5896, 6388, 6600, 6697, 6718, 6778, 6788, 6914, 7117, 7395, 7443, 7611, 7734, 7773, 7922, 7942, 8086, 8130, 8200, 8260, 8306, 8323, 8669, 8754, 8769, 8834, 9034, 9047, 9066, 9261, 9382, 9388, 9546, 9735, 9759, 9827, 9937, 9959, 10349, 10402, 10446, 11024, 11157, 11442, 11521, 11576, 12190, 12388, 12487, 12586, 12599, 12660, 12665, 12752, 13048, 13058, 13161, 13281, 13344, 13405, 13468, 13548, 13592, 13713, 14041, 14069, 14091, 14666, 15299, 15421, 15710, 15726, 15849, 15954, 16211, 16282, 16725, 16847, 16874, 17075, 17150, 17160, 17331, 17548, 17570, 17637, 17753, 17766, 17945, 17983, 18157, 18161, 18958, 19075, 19156, 19193, 19195, 19428, 19977 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(859, result.number);
            Assert.AreEqual(1317177, result.newNumber);
        }


        [TestMethod]
        public void TestMethod462()
        {
            int[] numbers = new int[] { 309, 1008, 1065, 1137, 1181, 1259, 1347, 1442, 1444, 1497, 1617, 1837, 1997, 2363, 2909, 2950, 3637, 4281, 4311, 4397, 4592, 4752, 4856, 5267, 5596, 5725, 5780, 5885, 6060, 6194, 6989, 7142, 7501, 7734, 7760, 7829, 8524, 8821, 9314, 9783, 10372, 10771, 10994, 11134, 11146, 11217, 11232, 11256, 11388, 11422, 11701, 11870, 11909, 12714, 13021, 13033, 13186, 13250, 13259, 13459, 13883, 13965, 14040, 14620, 14824, 15008, 15272, 15310, 15484, 15835, 16012, 16596, 16667, 16689, 17095, 17290, 17313, 17327, 17432, 17570, 18338, 18673, 19140, 19834 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1008, result.number);
            Assert.AreEqual(803091, result.newNumber);
        }


        [TestMethod]
        public void TestMethod463()
        {
            int[] numbers = new int[] { 140, 209, 299, 543, 577, 633, 638, 638, 717, 731, 1057, 1191, 1215, 1308, 1460, 1495, 1570, 1600, 1603, 1812, 1863, 1948, 1978, 2038, 2225, 2304, 2489, 2525, 2703, 2709, 2862, 3029, 3037, 3464, 3569, 4110, 4124, 4206, 4301, 4872, 5380, 5545, 5853, 5898, 5909, 5999, 6055, 6239, 6348, 6450, 6459, 6474, 6568, 6662, 6961, 6970, 7035, 7102, 7479, 7604, 7661, 7749, 8197, 8225, 8325, 8331, 8777, 8800, 8849, 9099, 9440, 9473, 9563, 9678, 9719, 9927, 10037, 10087, 10416, 10563, 10701, 11124, 11163, 11177, 11452, 11775, 11788, 12293, 12422, 12459, 12659, 13017, 14095, 14132, 14164, 14452, 14652, 14718, 14746, 14848, 14884, 14987, 15153, 15560, 15582, 15852, 15906, 15935, 16111, 16276, 16380, 16640, 16652, 17277, 17351, 17461, 17574, 18412, 18770, 19107, 19274, 19631, 19720, 19985 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(140, result.number);
            Assert.AreEqual(1056540, result.newNumber);
        }


        [TestMethod]
        public void TestMethod464()
        {
            int[] numbers = new int[] { 76, 103, 126, 147, 227, 241, 312, 323, 685, 708, 755, 771, 894, 1046, 1222, 1297, 1380, 1415, 1468, 1510, 1578, 1630, 1689, 1703, 1727, 1930, 1984, 2016, 2179, 2191, 2319, 2321, 2368, 2403, 2586, 2628, 2771, 2849, 2851, 3010, 3186, 3190, 3258, 3334, 3344, 3482, 3569, 3684, 3701, 3716, 3910, 3946, 3967, 3972, 4091, 4114, 4203, 4268, 4409, 4685, 4708, 4831, 4908, 4997, 5059, 5064, 5110, 5211, 5230, 5357, 5407, 5446, 5458, 5607, 5621, 5677, 5782, 5833, 6128, 6214, 6289, 6335, 6391, 6486, 6591, 6600, 6650, 6693, 6729, 6816, 6926, 6932, 6993, 7019, 7029, 7079, 7312, 7521, 7545, 7554, 7708, 7740, 7867, 7927, 7996, 8059, 8080, 8162, 8165, 8186, 8210, 8249, 8316, 8324, 8378, 8615, 8647, 8655, 8670, 8719, 8723, 8741, 8761, 8767, 8796, 8843, 8906, 8910, 9178, 9216, 9249, 9312, 9369, 9378, 9597, 9650, 9731, 9739, 9811, 9826, 9830, 9852, 9860, 10050, 10153, 10438, 10464, 10613, 10803, 10907, 10951, 11421, 11492, 11628, 11645, 11748, 11842, 11855, 11895, 12015, 12129, 12130, 12136, 12149, 12164, 12187, 12258, 12290, 12379, 12380, 12413, 12419, 12554, 12675, 12977, 13031, 13159, 13163, 13261, 13299, 13302, 13359, 13416, 13468, 13605, 13716, 13811, 13836, 13859, 13954, 13965, 14032, 14058, 14085, 14233, 14335, 14394, 14421, 14471, 14528, 14604, 14610, 14746, 14756, 14848, 14946, 15016, 15178, 15190, 15219, 15331, 15364, 15379, 15598, 15667, 15913, 15984, 15993, 16075, 16157, 16163, 16201, 16260, 16536, 16540, 16557, 16684, 16742, 16830, 16869, 16882, 16895, 16895, 16971, 17029, 17069, 17095, 17123, 17139, 17301, 17324, 17593, 17598, 17609, 17692, 17722, 17859, 17969, 18028, 18043, 18121, 18185, 18348, 18766, 18903, 19042, 19086, 19382, 19402, 19531, 19691, 19691, 19772, 19790, 19944, 19951 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(76, result.number);
            Assert.AreEqual(2605118, result.newNumber);
        }


        [TestMethod]
        public void TestMethod465()
        {
            int[] numbers = new int[] { 134, 498, 558, 586, 670, 740, 798, 1267, 1521, 2218, 2349, 2658, 2754, 3128, 3218, 3310, 3327, 3764, 4566, 5010, 5136, 5676, 5828, 6241, 6503, 6795, 7243, 7591, 8218, 8581, 8727, 8893, 9049, 9455, 9671, 9923, 9952, 10063, 10229, 10272, 11179, 12728, 12763, 12815, 13021, 13170, 13227, 13662, 14337, 14644, 14647, 14724, 14944, 15282, 15358, 15387, 15718, 16076, 16079, 16369, 16893, 17040, 17211, 17259, 17500, 17662, 17684, 17756, 17899, 18484, 18495, 18732, 18874, 19055, 19093, 19290, 19386 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(558, result.number);
            Assert.AreEqual(795246, result.newNumber);
        }


        [TestMethod]
        public void TestMethod466()
        {
            int[] numbers = new int[] { 7, 23, 63, 97, 355, 372, 854, 1021, 1212, 1257, 1353, 1413, 1435, 1467, 1475, 1533, 1682, 1704, 1873, 2063, 2204, 2613, 2647, 3113, 3423, 3469, 3637, 3792, 3893, 4144, 4570, 4795, 4833, 5042, 5136, 5150, 5392, 5617, 5717, 6036, 6099, 6195, 6207, 6448, 6514, 6615, 7154, 7586, 7946, 8152, 8464, 8677, 8845, 8861, 9164, 9629, 9702, 9752, 10051, 10057, 10447, 10574, 11056, 11502, 11757, 12057, 12071, 12125, 12197, 12408, 12629, 13002, 13130, 13899, 13990, 13994, 14345, 14347, 14539, 14565, 14753, 14775, 14961, 15052, 15072, 15078, 15406, 15449, 15460, 15612, 15813, 15928, 16228, 16594, 16642, 16855, 16864, 16887, 16915, 17020, 17238, 17645, 17804, 17962, 18031, 18043, 18427, 18657, 18918, 19085, 19144, 19349, 19441, 19676, 19724, 19785 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(23, result.number);
            Assert.AreEqual(1137011, result.newNumber);
        }


        [TestMethod]
        public void TestMethod467()
        {
            int[] numbers = new int[] { 86, 101, 339, 396, 420, 423, 507, 575, 733, 762, 769, 806, 1023, 1501, 1664, 1666, 1707, 1718, 2139, 2248, 2270, 2361, 2469, 2570, 2592, 2641, 2736, 2739, 2755, 2962, 3059, 3265, 3335, 3497, 3504, 3847, 3849, 3975, 4016, 4079, 4094, 4195, 4325, 4503, 4667, 4705, 4775, 4952, 5182, 5257, 5494, 5510, 5517, 5629, 5692, 5798, 5812, 5858, 5906, 5972, 5987, 6176, 6385, 6426, 6435, 6570, 6629, 6643, 6704, 6726, 6901, 6952, 6993, 7108, 7581, 7665, 7707, 7935, 8001, 8037, 8236, 8580, 8857, 9024, 9041, 9346, 9366, 9369, 9457, 9509, 9688, 9711, 10007, 10656, 10710, 10719, 10825, 11115, 11197, 11209, 11356, 11364, 11517, 11542, 12006, 12198, 12219, 12295, 12826, 13097, 13630, 13808, 14011, 14170, 14393, 14603, 14800, 14807, 15228, 15232, 15241, 15300, 15341, 15353, 15467, 15485, 15574, 15582, 15666, 16074, 16225, 16266, 16387, 16531, 16548, 17379, 17540, 17776, 17801, 17864, 17999, 18036, 18047, 18223, 18266, 18272, 18375, 18386, 18436, 18477, 18489, 18690, 18801, 18847, 18932, 19072, 19308, 19889 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(339, result.number);
            Assert.AreEqual(1444737, result.newNumber);
        }


        [TestMethod]
        public void TestMethod468()
        {
            int[] numbers = new int[] { 260, 500, 999, 1296, 1713, 2397, 2594, 2770, 2937, 3227, 3570, 3713, 3970, 4255, 4464, 5090, 6604, 6692, 6769, 7284, 7330, 7805, 8187, 8524, 9083, 9242, 9412, 9606, 9711, 9837, 10097, 10174, 10337, 10582, 10710, 11329, 11563, 11774, 11837, 11932, 12132, 12173, 12175, 12249, 12412, 12827, 12966, 13646, 14407, 14565, 14982, 15112, 15231, 15410, 15799, 16124, 16727, 16744, 16764, 16936, 17619, 18638, 18880, 19281, 19596, 19774 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(260, result.number);
            Assert.AreEqual(660002, result.newNumber);
        }


        [TestMethod]
        public void TestMethod469()
        {
            int[] numbers = new int[] { 42, 79, 103, 332, 374, 385, 719, 889, 952, 1020, 1138, 1209, 1226, 1341, 1528, 1546, 1557, 1562, 1603, 1684, 1701, 1859, 1862, 1894, 1967, 2186, 2252, 2282, 2336, 2393, 2396, 2397, 2622, 2780, 2820, 2862, 3079, 3111, 3182, 3187, 3238, 3240, 3280, 3402, 3473, 3747, 3963, 4154, 4181, 4255, 4258, 4325, 4359, 4462, 4481, 4571, 4674, 4852, 4933, 4962, 5026, 5041, 5175, 5183, 5204, 5225, 5271, 5325, 5358, 5447, 5476, 5482, 5598, 5608, 5646, 5662, 5789, 5857, 5863, 5912, 5977, 6025, 6048, 6053, 6167, 6197, 6202, 6300, 6348, 6351, 6374, 6391, 6467, 6566, 6720, 6840, 6990, 7066, 7106, 7334, 7375, 7488, 7513, 7587, 7605, 7737, 7741, 7748, 7875, 7903, 8264, 8345, 8524, 8641, 8696, 8748, 8756, 8764, 8767, 8769, 9032, 9400, 9421, 9442, 9468, 9616, 9842, 9866, 9957, 9967, 10026, 10077, 10341, 10386, 10417, 10582, 10741, 10761, 10837, 10845, 10886, 10936, 10959, 10964, 11045, 11138, 11146, 11214, 11291, 11377, 11460, 11467, 11618, 11622, 11652, 11830, 11842, 11873, 11948, 12066, 12078, 12406, 12588, 12883, 12954, 12968, 13101, 13113, 13122, 13149, 13157, 13167, 13204, 13246, 13371, 13387, 13494, 13545, 13648, 13808, 13814, 13837, 13976, 14224, 14238, 14292, 14293, 14333, 14381, 14569, 14580, 14592, 14770, 14869, 15030, 15187, 15280, 15398, 15515, 15521, 15610, 15632, 15652, 15716, 15772, 15888, 15906, 15926, 15947, 16097, 16097, 16120, 16177, 16192, 16199, 16325, 16523, 16638, 16666, 16681, 16768, 17004, 17195, 17391, 17397, 17446, 17571, 17579, 17761, 17820, 17883, 18084, 18189, 18262, 18299, 18321, 18364, 18546, 18772, 18775, 18877, 18964, 19005, 19009, 19090, 19150, 19194, 19294, 19327, 19369, 19396, 19457, 19511, 19578, 19605, 19619, 19705, 19901 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(374, result.number);
            Assert.AreEqual(2562023, result.newNumber);
        }


        [TestMethod]
        public void TestMethod470()
        {
            int[] numbers = new int[] { 846, 851, 895, 1096, 1171, 1451, 1512, 1636, 2004, 2115, 2172, 2548, 2857, 3196, 3588, 4133, 4255, 4577, 4983, 5472, 5512, 5583, 5583, 5804, 5853, 6108, 6153, 6263, 6354, 6364, 6946, 7162, 7196, 7258, 7737, 7992, 7992, 8108, 8400, 8413, 8797, 8838, 8854, 8876, 9295, 9424, 9544, 9559, 9710, 9766, 9952, 9998, 10114, 10890, 11114, 11281, 11329, 11336, 11509, 11527, 11984, 12076, 12182, 12481, 12501, 12604, 12635, 12931, 12955, 13635, 13775, 13795, 13934, 14380, 14545, 15701, 15889, 15909, 16467, 16612, 17561, 18091, 18387, 18510, 18632, 18656, 18717, 18834, 18899, 18988, 19087, 19108 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(851, result.number);
            Assert.AreEqual(880848, result.newNumber);
        }


        [TestMethod]
        public void TestMethod471()
        {
            int[] numbers = new int[] { 211, 698, 824, 886, 944, 1206, 1355, 1472, 1625, 1795, 1829, 2012, 2053, 2426, 2437, 2653, 2730, 2747, 2985, 3071, 3714, 3734, 3831, 3835, 3876, 4101, 4118, 4519, 4672, 4721, 4827, 4896, 4928, 5743, 5896, 5980, 6256, 7055, 7233, 7237, 7329, 7365, 8124, 8337, 8544, 8600, 8626, 8689, 8771, 8881, 8929, 9576, 9577, 9895, 10231, 10279, 10400, 10521, 10540, 10811, 10908, 10967, 11203, 11248, 11404, 11525, 11668, 12257, 12334, 12454, 12876, 13284, 13311, 13593, 13744, 13776, 14104, 14114, 14279, 14581, 14693, 14824, 14919, 15014, 15088, 15455, 15691, 15818, 15833, 15928, 16667, 16880, 17134, 17156, 17291, 17395, 17620, 17664, 17694, 18158, 18232, 18347, 18518, 18826, 19005, 19033, 19053, 19190, 19194, 19903, 19973 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(698, result.number);
            Assert.AreEqual(1103924, result.newNumber);
        }


        [TestMethod]
        public void TestMethod472()
        {
            int[] numbers = new int[] { 139, 342, 611, 825, 982, 1070, 1390, 1404, 1543, 1877, 1948, 2058, 2097, 2099, 2421, 2425, 2438, 2541, 2788, 2981, 3017, 3048, 3188, 3402, 3715, 3763, 3835, 3900, 3917, 3956, 4339, 4544, 4731, 4744, 4877, 4942, 5473, 5663, 5678, 5701, 5730, 6101, 6224, 6379, 6522, 6624, 6943, 6947, 7122, 7152, 7355, 7367, 7491, 7735, 8226, 8380, 8383, 8477, 8743, 8844, 8856, 8919, 9216, 9349, 9924, 10119, 10335, 10996, 11320, 11686, 11863, 11902, 11946, 12283, 12506, 13202, 13219, 13232, 13527, 13703, 13784, 13892, 14023, 14546, 14748, 14975, 15035, 15115, 15536, 15899, 16146, 16152, 16239, 16406, 16684, 16957, 17460, 17692, 17775, 17929, 18692, 18736, 18999, 19104, 19133, 19182, 19560, 19636, 19890 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(139, result.number);
            Assert.AreEqual(979413, result.newNumber);
        }


        [TestMethod]
        public void TestMethod473()
        {
            int[] numbers = new int[] { 1009, 3825, 4227, 9158, 11341, 11976, 13032, 14780, 17008, 18098, 18514, 18641, 19232 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(3825, result.number);
            Assert.AreEqual(153, result.newNumber);
        }


        [TestMethod]
        public void TestMethod474()
        {
            int[] numbers = new int[] { 1, 94, 138, 505, 541, 545, 560, 645, 660, 728, 762, 919, 1091, 1175, 1269, 1805, 1891, 2057, 2459, 2621, 2685, 2720, 2755, 2781, 2925, 3050, 3120, 3277, 3318, 3540, 3609, 3803, 3817, 3904, 4060, 4066, 4253, 4254, 4370, 4427, 4696, 4736, 4776, 4900, 5135, 5192, 5297, 5331, 5376, 5505, 5536, 5565, 5869, 5901, 5951, 5990, 6057, 6137, 6138, 6260, 6472, 6688, 6714, 6720, 6819, 6961, 7118, 7139, 7162, 7254, 7264, 7280, 7329, 7430, 7496, 7497, 7544, 7549, 7741, 7758, 8215, 8228, 8245, 8447, 8649, 8670, 8701, 8703, 8762, 8797, 8831, 8841, 9088, 9183, 9184, 9316, 9379, 9629, 9676, 9890, 10032, 10229, 10240, 10280, 10818, 10862, 10869, 10925, 10958, 11104, 11158, 11291, 11334, 11626, 11692, 11838, 11878, 12095, 12108, 12387, 12511, 12956, 13031, 13387, 13482, 13581, 13675, 13740, 13823, 13837, 13878, 13879, 14018, 14036, 14607, 14619, 14625, 14821, 14924, 14974, 15067, 15161, 15184, 15279, 15322, 15338, 15343, 15412, 15436, 15465, 15516, 15529, 15573, 15593, 15844, 15845, 15855, 15995, 16089, 16132, 16183, 16199, 16249, 16453, 16466, 16926, 16928, 17017, 17022, 17156, 17190, 17273, 17281, 17286, 17353, 17383, 17451, 17486, 17564, 17666, 17883, 17978, 17987, 18005, 18052, 18076, 18137, 18232, 18237, 18460, 18779, 18830, 18847, 18951, 19049, 19185, 19206, 19691, 19882 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(138, result.number);
            Assert.AreEqual(2028796, result.newNumber);
        }


        [TestMethod]
        public void TestMethod475()
        {
            int[] numbers = new int[] { 20, 23, 92, 175, 437, 498, 555, 574, 723, 749, 784, 804, 811, 916, 942, 959, 991, 1063, 1137, 1149, 1273, 1300, 1625, 1669, 1868, 1870, 1939, 1960, 2056, 2080, 2107, 2169, 2242, 2402, 2670, 2698, 2900, 3006, 3316, 3372, 3444, 3603, 3627, 3715, 3738, 3871, 3943, 3984, 4013, 4261, 4270, 4427, 4543, 4628, 4644, 4653, 4691, 5218, 5245, 5319, 5328, 5467, 5740, 5795, 5808, 5975, 6210, 6216, 6274, 6322, 6352, 6445, 6484, 6507, 6577, 6761, 6917, 7233, 7240, 7247, 7300, 7326, 7332, 7335, 7358, 7364, 7382, 7524, 7636, 7755, 7808, 7854, 7934, 8008, 8048, 8063, 8114, 8250, 8333, 8426, 8535, 8540, 8562, 8745, 8807, 8879, 9009, 9143, 9241, 9278, 9322, 9341, 9347, 9456, 9568, 9585, 9677, 9680, 9691, 9694, 9777, 9783, 9794, 9873, 9909, 10053, 10108, 10164, 10202, 10273, 10305, 10361, 10405, 10564, 10571, 10664, 10667, 10701, 10729, 10816, 10865, 10919, 10985, 10993, 11004, 11164, 11181, 11290, 11344, 11354, 11539, 11750, 11921, 11951, 12005, 12140, 12255, 12315, 12567, 12615, 12615, 12638, 12749, 12795, 12838, 13026, 13124, 13252, 13305, 13498, 13499, 13600, 13612, 13628, 13635, 13639, 13648, 13689, 13709, 13741, 13875, 13964, 14036, 14325, 14361, 14435, 14462, 14554, 14558, 14671, 14805, 14845, 14877, 14938, 15094, 15108, 15302, 15302, 15310, 15335, 15350, 15549, 15584, 15607, 15631, 15780, 15816, 15901, 15991, 16000, 16014, 16077, 16081, 16101, 16192, 16226, 16382, 16542, 16625, 16801, 16940, 17006, 17008, 17061, 17078, 17247, 17256, 17355, 17369, 17535, 17565, 17626, 17860, 17893, 17948, 18027, 18122, 18158, 18220, 18431, 18770, 18938, 18979, 19183, 19215, 19292, 19394, 19433, 19449, 19473, 19572, 19586, 19600, 19679, 19708, 19769, 19770, 19861, 19886, 19890 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(20, result.number);
            Assert.AreEqual(2668006, result.newNumber);
        }


        [TestMethod]
        public void TestMethod476()
        {
            int[] numbers = new int[] { 24, 86, 342, 985, 1491, 2614, 2734, 2745, 2918, 2975, 3028, 3087, 3124, 3205, 3418, 3557, 3830, 4225, 4715, 4716, 5321, 5413, 5731, 5829, 5853, 5991, 6132, 6152, 6264, 6314, 6810, 6999, 7232, 7394, 7482, 7882, 7967, 8127, 8435, 8862, 9203, 9242, 9763, 10031, 10085, 10792, 11017, 11105, 11113, 11852, 12552, 12680, 13747, 13863, 14154, 14434, 14690, 14708, 14783, 15027, 15077, 15246, 16113, 16255, 16269, 16661, 16945, 17157, 17701, 17923, 18019, 18540, 18932, 19429 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(342, result.number);
            Assert.AreEqual(665468, result.newNumber);
        }


        [TestMethod]
        public void TestMethod477()
        {
            int[] numbers = new int[] { 1, 139, 140, 156, 186, 301, 398, 701, 704, 770, 807, 857, 1026, 1026, 1085, 1111, 1114, 1249, 1259, 1382, 1641, 1814, 1975, 1994, 2016, 2029, 2117, 2141, 2238, 2365, 2435, 2508, 2677, 2715, 2730, 2777, 2795, 2850, 2914, 3130, 3144, 3400, 3438, 3535, 3642, 3667, 3860, 3991, 4111, 4114, 4155, 4159, 4224, 4265, 4329, 4345, 4367, 4450, 4561, 4591, 4592, 4790, 4812, 5001, 5204, 5248, 5286, 5332, 5438, 5483, 5494, 5639, 5758, 5795, 6000, 6095, 6180, 6269, 6334, 6403, 6443, 6531, 6616, 6717, 6786, 6799, 6840, 6856, 7006, 7185, 7337, 7364, 7499, 7638, 7643, 7643, 7899, 8054, 8093, 8187, 8271, 8323, 8417, 8472, 8480, 8636, 8787, 8988, 9054, 9149, 9183, 9400, 9407, 9410, 9510, 9557, 9906, 9915, 10185, 10261, 10264, 10329, 10334, 10490, 10536, 10597, 10628, 10719, 10743, 10748, 10784, 10787, 10892, 10963, 11061, 11070, 11137, 11223, 11249, 11365, 11557, 11617, 11650, 11843, 12135, 12170, 12179, 12286, 12363, 12413, 12477, 12551, 12585, 13043, 13056, 13173, 13186, 13433, 13454, 13586, 13652, 13751, 13797, 13928, 13942, 13977, 14028, 14065, 14066, 14069, 14176, 14386, 14426, 14526, 14548, 14748, 14992, 14992, 15006, 15094, 15154, 15219, 15324, 15401, 15507, 15662, 15738, 15780, 15806, 15837, 15894, 15994, 16018, 16067, 16117, 16132, 16358, 16400, 16419, 16445, 16779, 16950, 17041, 17060, 17122, 17375, 17381, 17439, 17439, 17454, 17744, 17820, 17857, 17907, 17917, 17936, 17997, 18056, 18126, 18149, 18159, 18311, 18341, 18370, 18385, 18454, 18657, 18732, 18757, 18790, 18883, 19071, 19299, 19398, 19519, 19589, 19935, 19973 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1, result.number);
            Assert.AreEqual(2342865, result.newNumber);
        }


        [TestMethod]
        public void TestMethod478()
        {
            int[] numbers = new int[] { 62, 82, 287, 315, 387, 435, 442, 471, 525, 554, 634, 779, 794, 989, 1013, 1022, 1094, 1112, 1140, 1415, 1715, 1741, 1804, 1862, 1920, 1986, 2004, 2083, 2084, 2100, 2123, 2141, 2162, 2216, 2268, 2455, 2490, 2516, 2546, 2561, 2676, 2688, 2773, 2813, 2954, 3111, 3156, 3162, 3218, 3274, 3276, 3346, 3486, 3747, 3771, 3788, 3877, 3898, 3923, 3933, 4082, 4172, 4254, 4330, 4428, 4476, 4483, 4522, 4523, 4542, 4944, 4947, 5141, 5165, 5267, 5272, 5350, 5407, 5434, 5471, 5658, 5660, 5718, 5730, 5842, 5845, 5848, 5892, 5935, 5953, 5958, 5985, 6130, 6257, 6321, 6329, 6338, 6341, 6367, 6418, 6488, 6663, 6703, 6819, 6880, 6941, 7119, 7169, 7181, 7213, 7259, 7318, 7330, 7450, 7567, 7677, 7685, 7706, 7853, 7880, 8004, 8132, 8201, 8243, 8263, 8286, 8349, 8463, 8466, 8467, 8525, 8728, 8745, 8780, 8825, 8888, 9043, 9072, 9153, 9184, 9335, 9396, 9403, 9417, 9470, 9489, 9652, 9722, 9740, 9787, 9811, 9818, 9824, 9862, 10021, 10145, 10206, 10209, 10369, 10722, 10723, 10756, 10809, 10951, 10971, 11218, 11369, 11501, 11502, 11525, 11563, 11592, 11757, 12031, 12117, 12179, 12355, 12357, 12362, 12422, 12515, 12551, 12573, 12601, 12664, 12674, 12730, 12794, 12864, 12905, 12938, 12944, 12946, 12949, 12952, 12958, 13099, 13107, 13179, 13187, 13235, 13302, 13469, 13512, 13524, 13608, 13871, 14300, 14301, 14305, 14331, 14356, 14397, 14724, 14748, 14767, 14927, 15035, 15056, 15067, 15078, 15086, 15102, 15117, 15125, 15129, 15279, 15455, 15481, 15496, 15502, 15604, 15606, 15801, 16024, 16096, 16211, 16234, 16520, 16567, 16602, 16682, 16769, 16916, 16967, 17039, 17153, 17175, 17305, 17346, 17357, 17613, 17641, 17815, 17829, 17844, 18072, 18136, 18148, 18164, 18271, 18283, 18339, 18432, 18447, 18466, 18527, 18585, 18625, 18864, 18910, 19011, 19016, 19093, 19158, 19264, 19278, 19422, 19428, 19445, 19462, 19535, 19539, 19642, 19646, 19695, 19699, 19836, 19886, 19909 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(315, result.number);
            Assert.AreEqual(2859913, result.newNumber);
        }


        [TestMethod]
        public void TestMethod479()
        {
            int[] numbers = new int[] { 66, 143, 284, 351, 430, 521, 552, 574, 600, 722, 736, 808, 818, 846, 874, 883, 902, 1235, 1379, 1418, 1466, 1610, 1634, 2021, 2153, 2207, 2216, 2300, 2315, 2412, 2511, 2662, 2772, 2858, 2923, 3035, 3076, 3152, 3314, 3357, 3518, 3680, 3732, 3869, 3898, 3936, 3958, 3967, 3968, 3970, 4028, 4111, 4487, 4616, 4630, 4807, 4993, 5055, 5085, 5133, 5176, 5387, 5419, 5513, 5552, 5615, 5722, 5780, 5785, 6072, 6207, 6276, 6385, 6447, 6501, 6567, 6640, 6749, 6831, 6884, 7024, 7182, 7213, 7278, 7328, 7337, 7605, 7687, 7716, 7817, 7865, 7889, 7925, 8033, 8115, 8522, 8536, 8565, 8571, 8654, 8688, 8691, 8692, 8734, 8792, 8873, 8998, 9054, 9279, 9357, 9376, 9392, 9437, 9505, 9532, 9569, 9592, 9626, 9652, 9662, 9803, 9898, 9914, 9924, 9963, 9975, 10021, 10272, 10537, 10634, 10642, 10676, 10701, 10764, 10772, 10787, 10887, 10960, 11025, 11050, 11079, 11081, 11126, 11261, 11303, 11313, 11428, 11465, 11600, 11694, 11741, 11772, 12010, 12148, 12358, 12367, 12541, 12727, 12846, 12948, 13036, 13240, 13419, 13466, 13577, 13735, 13817, 13836, 13909, 13975, 14106, 14174, 14233, 14392, 14460, 14518, 14535, 14654, 14778, 14889, 14993, 14993, 15008, 15057, 15078, 15136, 15365, 15520, 15558, 15599, 15668, 15713, 15715, 15987, 16108, 16126, 16210, 16260, 16355, 16450, 16467, 16608, 16620, 16678, 16807, 16863, 17041, 17207, 17352, 17425, 17607, 17741, 17805, 17847, 17868, 17927, 17966, 17999, 18037, 18133, 18183, 18223, 18273, 18282, 18387, 18456, 18531, 18605, 18674, 18842, 18891, 19165, 19165, 19173, 19335, 19341, 19347, 19372, 19480, 19530, 19631, 19726, 19759, 19765, 19841 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(66, result.number);
            Assert.AreEqual(2474017, result.newNumber);
        }


        [TestMethod]
        public void TestMethod480()
        {
            int[] numbers = new int[] { 20, 77, 98, 413, 446, 904, 945, 971, 998, 1099, 1105, 1198, 1443, 1453, 1650, 1896, 1991, 2131, 2303, 2370, 2627, 2707, 2893, 3107, 3115, 3274, 3315, 3507, 3512, 3513, 3735, 3764, 3827, 3924, 3942, 4153, 4180, 4200, 4200, 4233, 4486, 4511, 4634, 4790, 4837, 4869, 4937, 4958, 4985, 5001, 5028, 5128, 5197, 5263, 5343, 5350, 5418, 5578, 5669, 5795, 5834, 6041, 6292, 6312, 6369, 6506, 6614, 6627, 6633, 6709, 6755, 7272, 7486, 7590, 7707, 7733, 7752, 7809, 7819, 8307, 8322, 8385, 8686, 8747, 8796, 8857, 8924, 9009, 9084, 9375, 9549, 9579, 9687, 9803, 9902, 10053, 10126, 10247, 10293, 10462, 10651, 10795, 10809, 10825, 10918, 11001, 11002, 11385, 11578, 11583, 11648, 11730, 11782, 11799, 12004, 12040, 12044, 12180, 12193, 12256, 12468, 12608, 12668, 12766, 12893, 12912, 12919, 12939, 12940, 12940, 12946, 13055, 13082, 13313, 13316, 13379, 13797, 13873, 13918, 14205, 14210, 14286, 14476, 14622, 14672, 14709, 14787, 14812, 14839, 14902, 15161, 15380, 15532, 15537, 15567, 15616, 15775, 15847, 15854, 15871, 15873, 15929, 15934, 16062, 16075, 16285, 16452, 16606, 16633, 16660, 16728, 16752, 16768, 16777, 16976, 17139, 17181, 17272, 17293, 17445, 17516, 17562, 17581, 17604, 17702, 18195, 18271, 18381, 18532, 18559, 18633, 18673, 18889, 19079, 19147, 19248, 19268, 19555, 19678, 19786, 19859, 19879 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(446, result.number);
            Assert.AreEqual(2062031, result.newNumber);
        }


        [TestMethod]
        public void TestMethod481()
        {
            int[] numbers = new int[] { 135, 276, 463, 1172, 1993, 2014, 3123, 3794, 4572, 4726, 4834, 4994, 5371, 5888, 6023, 7866, 8041, 8072, 8531, 8657, 8797, 9777, 9793, 9864, 9960, 10628, 10916, 11882, 12503, 12703, 13244, 13813, 14185, 14832, 14926, 15078, 15292, 15517, 15869, 15883, 15950, 16216, 16317, 17968, 18499, 18888, 18993 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(135, result.number);
            Assert.AreEqual(451437, result.newNumber);
        }


        [TestMethod]
        public void TestMethod482()
        {
            int[] numbers = new int[] { 162, 479, 501, 634, 652, 685, 710, 817, 862, 945, 1013, 1094, 1121, 1184, 1285, 1694, 1751, 1951, 2288, 2444, 2529, 2640, 2650, 2803, 2864, 3025, 3104, 3131, 3233, 3286, 3655, 3848, 3938, 3967, 4030, 4049, 4288, 4405, 4483, 4782, 5003, 5238, 5453, 5646, 5903, 5989, 6202, 6366, 6757, 6991, 7225, 7392, 8045, 8271, 8276, 8449, 8569, 8599, 8645, 8721, 8888, 9038, 9094, 9134, 9285, 9381, 9382, 9433, 9438, 9493, 9559, 9634, 9685, 9693, 9918, 9946, 9995, 10355, 10806, 10817, 10876, 10896, 10957, 10967, 11048, 11230, 11425, 11738, 11768, 11902, 11954, 12079, 12300, 12318, 12564, 12584, 12598, 12857, 12890, 13030, 13073, 13359, 13538, 13687, 13698, 13745, 13877, 14206, 14272, 14478, 14608, 14699, 15110, 15172, 15203, 15215, 15300, 15407, 15499, 15685, 15870, 15898, 15908, 15925, 15932, 16354, 16627, 16746, 16805, 16806, 16839, 17150, 17179, 17318, 17411, 17858, 18072, 18288, 18363, 18381, 18647, 18657, 18664, 18879, 18933, 19015, 19150, 19210, 19274, 19509, 19759, 19784 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(162, result.number);
            Assert.AreEqual(1521228, result.newNumber);
        }


        [TestMethod]
        public void TestMethod483()
        {
            int[] numbers = new int[] { 424, 491, 523, 642, 774, 791, 848, 868, 998, 1051, 1339, 1379, 1491, 1550, 2094, 2149, 2247, 3035, 3133, 3433, 3474, 3488, 3801, 3900, 3948, 4137, 4623, 4951, 5443, 5810, 6053, 6222, 6384, 6695, 6853, 6894, 7047, 7274, 7334, 7372, 7532, 8258, 8477, 8653, 8708, 8846, 8989, 9911, 10170, 10331, 10588, 10848, 11280, 11793, 12157, 12157, 12208, 12397, 12703, 12775, 13151, 13223, 13386, 13401, 13548, 13646, 14065, 14189, 14275, 14412, 14503, 14722, 14855, 15136, 15147, 15221, 15495, 16186, 16259, 16380, 16536, 16648, 16770, 17050, 17231, 17863, 17915, 18052, 18344, 18642, 18883, 18898, 18956, 19304, 19432, 19537, 19556, 19881 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(491, result.number);
            Assert.AreEqual(965826, result.newNumber);
        }


        [TestMethod]
        public void TestMethod484()
        {
            int[] numbers = new int[] { 124, 186, 236, 264, 278, 292, 361, 709, 945, 1067, 1149, 1247, 1253, 1359, 1380, 1523, 1762, 1765, 1872, 1887, 1992, 2008, 2053, 2066, 2098, 2271, 2459, 2689, 2695, 2875, 2912, 2938, 3045, 3511, 3539, 3598, 3648, 3680, 3735, 3864, 3989, 4105, 4147, 4174, 4278, 4358, 4568, 4656, 4708, 4794, 4943, 5145, 5223, 5253, 5407, 5446, 5563, 5601, 5777, 5801, 5943, 6038, 6147, 6154, 6326, 6350, 6410, 6422, 6458, 6556, 6613, 6700, 6760, 6833, 7159, 7232, 7284, 7289, 7351, 7843, 7983, 8083, 8246, 8317, 8362, 8391, 8842, 8873, 8934, 9035, 9043, 9074, 9077, 9334, 9646, 9712, 9799, 9933, 9960, 9981, 9998, 9999, 10026, 10040, 10143, 10151, 10166, 10203, 10398, 10467, 10524, 10557, 10671, 10678, 10702, 11143, 11186, 11352, 11451, 11487, 11563, 11597, 11629, 11672, 11763, 11790, 11847, 11909, 11959, 11968, 11981, 12028, 12071, 12230, 12240, 12240, 12323, 12363, 12381, 12581, 12627, 12755, 12760, 12907, 12936, 13030, 13224, 13352, 13633, 13661, 13784, 13833, 13858, 13907, 14110, 14144, 14148, 14187, 14218, 14252, 14556, 14593, 14615, 14760, 14762, 14820, 14836, 14906, 15101, 15101, 15234, 15794, 16084, 16162, 16272, 16345, 16410, 16596, 16720, 16768, 17063, 17073, 17190, 17348, 17374, 17483, 17510, 17538, 17710, 17760, 17849, 17990, 18007, 18071, 18081, 18086, 18134, 18166, 18318, 18382, 18384, 18669, 18777, 18841, 18905, 19081, 19105, 19125, 19388, 19442, 19525, 19587, 19593, 19644, 19778, 19789, 19884 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(236, result.number);
            Assert.AreEqual(2203024, result.newNumber);
        }


        [TestMethod]
        public void TestMethod485()
        {
            int[] numbers = new int[] { 478, 856, 927, 1007, 1065, 1523, 1882, 1921, 1970, 2016, 2020, 2090, 2616, 2619, 2699, 2945, 3020, 3317, 3322, 3328, 3346, 3376, 3382, 3420, 3971, 3979, 4085, 4105, 4139, 4598, 4609, 4724, 4793, 4826, 5206, 5539, 5765, 6011, 6047, 6349, 6461, 6582, 6763, 7085, 7199, 7735, 7943, 8127, 8321, 8403, 8637, 8958, 9108, 9564, 9568, 9665, 9783, 9851, 9989, 10311, 10312, 10489, 10577, 11035, 11054, 11063, 11224, 11248, 11771, 11888, 11963, 12145, 12452, 12486, 12487, 12618, 12891, 13660, 13730, 13753, 13838, 14294, 14313, 14382, 14439, 14498, 14795, 14874, 15236, 15272, 15909, 16014, 16207, 16461, 16763, 16799, 16898, 17273, 17411, 17412, 17618, 17823, 17927, 18091, 18191, 18262, 18707, 18796, 18835, 19068, 19400, 19412, 19419, 19513, 19553 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(478, result.number);
            Assert.AreEqual(1128475, result.newNumber);
        }


        [TestMethod]
        public void TestMethod486()
        {
            int[] numbers = new int[] { 254, 621, 656, 940, 1110, 1272, 1363, 1398, 1587, 1710, 1859, 2478, 2505, 2701, 3533, 3675, 3738, 3765, 3808, 3817, 4036, 4212, 4326, 5008, 5053, 5570, 5598, 5993, 7279, 7302, 7457, 7502, 8023, 8387, 8505, 8577, 8659, 8901, 8916, 9154, 9323, 9667, 9729, 10265, 10580, 10650, 10753, 10954, 11164, 11200, 11493, 11525, 11698, 12015, 12126, 12308, 12483, 12751, 12767, 13031, 13038, 13397, 13471, 13824, 13941, 14193, 14551, 14939, 14984, 15018, 15234, 15245, 15292, 15316, 15406, 15509, 15547, 15640, 15735, 15834, 15905, 16049, 16217, 16578, 17373, 17469, 17631, 17782, 17978, 18364, 18501, 19586, 19641, 19676, 19746, 19783, 19947 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(656, result.number);
            Assert.AreEqual(1004833, result.newNumber);
        }


        [TestMethod]
        public void TestMethod487()
        {
            int[] numbers = new int[] { 22, 34, 134, 196, 200, 264, 381, 448, 501, 514, 538, 571, 677, 724, 763, 818, 876, 1031, 1092, 1165, 1280, 1343, 1345, 1446, 1480, 1583, 1600, 1657, 1667, 1755, 1857, 1877, 1890, 2037, 2165, 2305, 2314, 2324, 2371, 2377, 2537, 2572, 2707, 2736, 2765, 3003, 3044, 3192, 3229, 3397, 3473, 3504, 3510, 3563, 3818, 4029, 4056, 4193, 4339, 4488, 4564, 4596, 4643, 4773, 4815, 4840, 4851, 4872, 4998, 5039, 5040, 5047, 5173, 5443, 5461, 5497, 5601, 5768, 5804, 5864, 6010, 6016, 6250, 6302, 6308, 6309, 6366, 6433, 6739, 6963, 7132, 7140, 7172, 7257, 7258, 7305, 7379, 7391, 7424, 7432, 7477, 7479, 7637, 7749, 7770, 7782, 8065, 8127, 8154, 8218, 8225, 8347, 8365, 8374, 8382, 8384, 8485, 8536, 8666, 8838, 9030, 9075, 9145, 9192, 9210, 9261, 9261, 9496, 9501, 9581, 9595, 9647, 9656, 9674, 9691, 9794, 9808, 9852, 9951, 9973, 9994, 10023, 10196, 10258, 10392, 10405, 10458, 10535, 10772, 10919, 10937, 11039, 11149, 11268, 11293, 11342, 11372, 11536, 11555, 11559, 11675, 11715, 11962, 11971, 12220, 12343, 12344, 12347, 12356, 12424, 12471, 12494, 12504, 12534, 12574, 12638, 12676, 12758, 12769, 12775, 12794, 12924, 12938, 12942, 12990, 13062, 13145, 13182, 13201, 13579, 13593, 13633, 13862, 13908, 13934, 13963, 13984, 14235, 14280, 14316, 14428, 14487, 14561, 14584, 14594, 14783, 14802, 14849, 14864, 14890, 14893, 14957, 15032, 15057, 15311, 15320, 15541, 15552, 15577, 15656, 16397, 16826, 16977, 17015, 17050, 17090, 17156, 17250, 17289, 17306, 17550, 17586, 17603, 17648, 17728, 17772, 17864, 17866, 17883, 17928, 18328, 18614, 18628, 18642, 18664, 18730, 18878, 18923, 18960, 18998, 19002, 19030, 19081, 19237, 19242, 19431, 19516, 19625, 19645, 19732, 19794, 19823, 19873, 19918, 19921, 19929, 19996 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(134, result.number);
            Assert.AreEqual(2610032, result.newNumber);
        }


        [TestMethod]
        public void TestMethod488()
        {
            int[] numbers = new int[] { 41, 196, 578, 612, 1114, 1278, 1666, 2309, 2472, 2660, 2829, 3141, 3187, 3684, 3862, 4057, 4429, 4968, 5196, 5300, 5358, 5737, 5740, 6210, 6217, 6244, 7894, 7963, 8089, 8184, 9149, 9387, 9674, 10001, 10331, 10430, 10435, 10840, 11387, 11461, 11528, 12720, 12821, 13016, 13472, 13592, 13732, 13772, 13797, 14082, 14901, 14937, 15243, 15349, 15939, 16003, 16271, 16632, 16657, 17785, 17951, 18305, 18370, 19077, 19305, 19805, 19819, 19860 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(196, result.number);
            Assert.AreEqual(660791, result.newNumber);
        }


        [TestMethod]
        public void TestMethod489()
        {
            int[] numbers = new int[] { 413, 468, 703, 880, 936, 952, 1272, 1509, 1818, 1941, 2231, 2279, 2445, 3268, 3320, 3327, 3580, 3837, 4009, 4033, 4479, 4595, 4639, 4730, 4903, 4964, 5394, 5409, 5606, 6089, 6242, 6581, 6826, 6847, 6911, 7344, 7621, 7661, 7691, 7703, 7736, 8022, 8085, 8564, 8571, 8734, 8746, 8917, 9234, 9291, 9601, 9601, 9691, 9905, 9936, 10037, 10275, 10467, 10629, 11052, 11246, 11255, 11308, 11613, 11626, 12125, 12294, 12814, 13023, 13103, 13220, 13300, 13623, 13630, 14435, 14502, 14602, 14903, 15117, 15127, 15182, 15646, 15726, 15736, 15915, 16067, 16203, 16297, 16388, 16443, 16508, 16640, 16675, 17108, 17928, 18019, 18101, 18219, 18346, 18447, 18514, 18713, 18718, 18799, 18813, 19229, 19669, 19785, 19835, 19918, 19919, 19992 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(413, result.number);
            Assert.AreEqual(1174923, result.newNumber);
        }


        [TestMethod]
        public void TestMethod490()
        {
            int[] numbers = new int[] { 109, 144, 426, 474, 548, 668, 709, 738, 863, 937, 1000, 1033, 1144, 1206, 1543, 1565, 1658, 1698, 1747, 1780, 1813, 1815, 1843, 1930, 1991, 2000, 2060, 2113, 2139, 2224, 2392, 2475, 2485, 2624, 2761, 2856, 2930, 3204, 3244, 3512, 3803, 3948, 3951, 3972, 3998, 4007, 4152, 4279, 4280, 4400, 4453, 4524, 4549, 4602, 4641, 4696, 4750, 4973, 5232, 5239, 5300, 5475, 5487, 5762, 5850, 5909, 6020, 6064, 6095, 6167, 6248, 6311, 6414, 6425, 6515, 6552, 6563, 7046, 7051, 7163, 7325, 7463, 7519, 7663, 7869, 7886, 7992, 8201, 8230, 8242, 8256, 8277, 8398, 8434, 8482, 8590, 8618, 8659, 8733, 8749, 8861, 8976, 9271, 9455, 9590, 9722, 9766, 10011, 10062, 10101, 10102, 10131, 10294, 10371, 10452, 10629, 10680, 10725, 10817, 10888, 10943, 10966, 11031, 11038, 11084, 11086, 11284, 11387, 11588, 11592, 11689, 11819, 11863, 11974, 12116, 12174, 12212, 12301, 12312, 12358, 12372, 12426, 12432, 12432, 12517, 12773, 12834, 12903, 12926, 13080, 13084, 13085, 13221, 13304, 13339, 13381, 13544, 13556, 13566, 13857, 13947, 14054, 14069, 14083, 14121, 14147, 14180, 14218, 14226, 14464, 14495, 14552, 14564, 14595, 14688, 14691, 14807, 14841, 15115, 15183, 15259, 15262, 15272, 15600, 15695, 15814, 15880, 15894, 15895, 16029, 16039, 16058, 16159, 16204, 16306, 16313, 16453, 16569, 16594, 16648, 16848, 16871, 16946, 16947, 17099, 17292, 17454, 17492, 17516, 17531, 17592, 17620, 17697, 17725, 17726, 17780, 17818, 17855, 17870, 17891, 17900, 17936, 17938, 18013, 18042, 18082, 18145, 18237, 18301, 18363, 18505, 18523, 18743, 18750, 18894, 18900, 18965, 18969, 18970, 18985, 19159, 19310, 19378, 19458, 19539, 19579, 19637, 19692, 19776, 19802, 19818, 19825, 19863 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(144, result.number);
            Assert.AreEqual(2718724, result.newNumber);
        }


        [TestMethod]
        public void TestMethod491()
        {
            int[] numbers = new int[] { 74, 414, 465, 513, 1204, 1452, 1857, 2034, 3338, 3674, 3848, 4531, 4669, 4938, 4965, 5179, 5220, 5583, 5653, 5876, 6496, 6496, 6545, 6937, 6974, 7048, 7290, 7346, 7461, 7689, 7970, 8047, 8294, 8625, 8866, 8932, 8960, 9363, 9470, 9606, 9664, 10136, 10566, 10588, 11746, 11940, 12141, 12420, 12853, 13758, 13809, 13845, 14025, 14241, 14869, 14917, 15008, 16495, 16758, 16767, 17467, 17754, 18090, 18436, 19806 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(74, result.number);
            Assert.AreEqual(570994, result.newNumber);
        }


        [TestMethod]
        public void TestMethod492()
        {
            int[] numbers = new int[] { 254, 879, 896, 1017, 1098, 1193, 1434, 1450, 1550, 1581, 1625, 1759, 1772, 1799, 1845, 1915, 1996, 2011, 2050, 2077, 2222, 2263, 2268, 2302, 2324, 2327, 2479, 2510, 2523, 2582, 2592, 2710, 2847, 2868, 2874, 2899, 3345, 3375, 3525, 3573, 3585, 3617, 3840, 4249, 4262, 4360, 4485, 4551, 4568, 4592, 4737, 5014, 5188, 5319, 5357, 5360, 5501, 5611, 5750, 5854, 5866, 5933, 6086, 6244, 6265, 6410, 6459, 6553, 6806, 6848, 6973, 7024, 7745, 7751, 7878, 7908, 8036, 8128, 8366, 8510, 8514, 8776, 8829, 8899, 8973, 9010, 9118, 9152, 9232, 9289, 9868, 10094, 10177, 10249, 10263, 10407, 10493, 10514, 10769, 10839, 11113, 11194, 11195, 11313, 11347, 11543, 11557, 11678, 11823, 11845, 12043, 12340, 12428, 12470, 12706, 12771, 12835, 12863, 12889, 12987, 13163, 13235, 13248, 13599, 13666, 13754, 13810, 14005, 14053, 14134, 14152, 14390, 14714, 14722, 14786, 14858, 15064, 15146, 15399, 15487, 15494, 15621, 15625, 15685, 15704, 15709, 15710, 15779, 15850, 16189, 16282, 16306, 16354, 16373, 16413, 16460, 16689, 16723, 16732, 16760, 17029, 17430, 17524, 17821, 18059, 18118, 18130, 18181, 18335, 18605, 18758, 18883, 18976, 18978, 19087, 19160, 19247, 19343, 19345, 19461, 19572, 19635, 19719, 19787 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(254, result.number);
            Assert.AreEqual(1807866, result.newNumber);
        }


        [TestMethod]
        public void TestMethod493()
        {
            int[] numbers = new int[] { 196, 443, 753, 879, 1067, 1302, 1620, 1820, 1977, 2007, 2097, 3110, 3217, 3456, 3741, 3905, 4331, 4400, 4466, 4592, 4784, 5036, 5386, 5476, 6221, 6407, 6413, 6609, 6954, 7015, 7379, 8071, 8257, 8451, 8594, 8937, 9182, 9526, 9799, 9895, 10156, 10350, 10679, 10735, 10924, 10959, 11173, 11487, 11590, 11608, 11650, 11724, 12158, 12306, 12723, 13750, 14648, 14648, 15191, 15287, 15545, 15627, 15859, 16116, 16302, 16329, 16457, 16477, 16482, 16501, 16644, 16867, 16932, 17127, 17543, 17864, 17900, 17977, 17997, 18163, 18677, 18955, 19383, 19555, 19633, 19806, 19816, 19974 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(1067, result.number);
            Assert.AreEqual(925339, result.newNumber);
        }


        [TestMethod]
        public void TestMethod494()
        {
            int[] numbers = new int[] { 3040, 3689, 4584, 4763, 6444, 6683, 8618, 15489, 17234, 17973, 18646 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(3040, result.number);
            Assert.AreEqual(3, result.newNumber);
        }


        [TestMethod]
        public void TestMethod495()
        {
            int[] numbers = new int[] { 111, 141, 294, 296, 326, 349, 485, 596, 665, 695, 720, 841, 856, 890, 898, 905, 929, 943, 982, 995, 1032, 1077, 1084, 1213, 1292, 1333, 1353, 1402, 1433, 1497, 1643, 1924, 1928, 1968, 2049, 2256, 2264, 2361, 2473, 2494, 2539, 2572, 2832, 2891, 2963, 3083, 3087, 3156, 3202, 3271, 3292, 3319, 3322, 3352, 3362, 3376, 3706, 3795, 3865, 3906, 3927, 3932, 4058, 4398, 4475, 4479, 4564, 4649, 4779, 4848, 4920, 4989, 5061, 5251, 5271, 5295, 5378, 5424, 5499, 5509, 5577, 5612, 5763, 5824, 5843, 5850, 6256, 6265, 6286, 6305, 6359, 6426, 6466, 6475, 6654, 6695, 6969, 6973, 7008, 7288, 7392, 7418, 7624, 7692, 7727, 7775, 7926, 8200, 8408, 8578, 8614, 8799, 8826, 8854, 8996, 9134, 9256, 9266, 9308, 9445, 9578, 9605, 9609, 9728, 9842, 10067, 10074, 10361, 10377, 10401, 10459, 10575, 10589, 10606, 10622, 10686, 10740, 10862, 10956, 11060, 11090, 11138, 11301, 11443, 11699, 11728, 11838, 11905, 11965, 12088, 12126, 12165, 12223, 12266, 12315, 12412, 12507, 12683, 12876, 12883, 13006, 13116, 13197, 13220, 13358, 13367, 13421, 13653, 13688, 13731, 13772, 13793, 13924, 13936, 14015, 14056, 14492, 14520, 14525, 14621, 14633, 14845, 14850, 14920, 15005, 15083, 15098, 15211, 15250, 15379, 15433, 15450, 15489, 15664, 15671, 15710, 15781, 15793, 15795, 15811, 15826, 15888, 15917, 15924, 15924, 15942, 15998, 16034, 16123, 16130, 16168, 16216, 16378, 16383, 16753, 16758, 16954, 17013, 17093, 17120, 17153, 17236, 17244, 17272, 17424, 17555, 17569, 17793, 17863, 17974, 18008, 18115, 18135, 18166, 18234, 18350, 18404, 18435, 18703, 18707, 18715, 18727, 18838, 18921, 18933, 18971, 19010, 19067, 19085, 19224, 19398, 19527, 19546, 19688, 19739, 19845 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(141, result.number);
            Assert.AreEqual(2524658, result.newNumber);
        }


        [TestMethod]
        public void TestMethod496()
        {
            int[] numbers = new int[] { 158, 560, 669, 698, 761, 804, 849, 1004, 1458, 1582, 1689, 1703, 2066, 2210, 2395, 2450, 2471, 2543, 2546, 2827, 2844, 2854, 2866, 3067, 3137, 3150, 3199, 3255, 3413, 3849, 3908, 3935, 4053, 4410, 4606, 4981, 5082, 5558, 5638, 5958, 5967, 5984, 6021, 6058, 6246, 6598, 6880, 6919, 6989, 7343, 7969, 7994, 8103, 8222, 8603, 8978, 8985, 9016, 9145, 9153, 9334, 9369, 9402, 9728, 10147, 10505, 10538, 10646, 10668, 11065, 11223, 11409, 11826, 11843, 12248, 12300, 12895, 13008, 13125, 13211, 13586, 13711, 13930, 13953, 14002, 14477, 14510, 14660, 14668, 15286, 15366, 15691, 15827, 15834, 15834, 15859, 15917, 15945, 16099, 16150, 16633, 17080, 17196, 17208, 17289, 17417, 17499, 17586, 17827, 17876, 17884, 18090, 18141, 18169, 18335, 18630, 18737, 18948, 19040, 19077, 19092, 19328, 19645, 19766, 19871, 19914, 19997 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(158, result.number);
            Assert.AreEqual(1279181, result.newNumber);
        }


        [TestMethod]
        public void TestMethod497()
        {
            int[] numbers = new int[] { 9, 198, 626, 640, 697, 729, 762, 775, 950, 1078, 1266, 1277, 1339, 1791, 1843, 1844, 1878, 2038, 2163, 2647, 2914, 3262, 3382, 3420, 3524, 3681, 3841, 4252, 4690, 5176, 5361, 6344, 6431, 6530, 6615, 6681, 6966, 8068, 8320, 8406, 8803, 8904, 9290, 9356, 9849, 10205, 10474, 10569, 10745, 10831, 10936, 11621, 11692, 11822, 12118, 12275, 12316, 12360, 12373, 12571, 12686, 12746, 12833, 13275, 13362, 13516, 14313, 14793, 14923, 15378, 15819, 15878, 16188, 16517, 16615, 17092, 17250, 17455, 17489, 17609, 18218, 18459, 18462, 18544, 18545, 18733, 19240, 19361, 19390, 19541, 19664, 19674, 19739, 19811, 19839, 19876, 19912, 19921, 19986 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(198, result.number);
            Assert.AreEqual(1020184, result.newNumber);
        }


        [TestMethod]
        public void TestMethod498()
        {
            int[] numbers = new int[] { 21, 116, 292, 317, 400, 407, 418, 582, 625, 723, 728, 847, 877, 980, 1026, 1279, 1414, 1619, 1632, 1652, 1685, 1717, 1801, 1900, 1918, 2108, 2112, 2224, 2493, 2555, 2557, 2656, 2761, 2967, 3018, 3193, 3453, 3517, 3677, 3939, 3992, 4091, 4175, 4236, 4341, 4519, 4525, 4534, 4613, 4633, 4670, 4729, 4859, 4988, 5049, 5049, 5189, 5294, 5521, 5529, 5595, 5712, 5834, 5873, 6234, 6374, 6451, 6587, 6624, 6648, 6720, 6736, 6860, 6926, 7004, 7011, 7129, 7292, 7320, 7325, 7356, 7539, 7869, 7890, 7977, 7999, 8072, 8142, 8268, 8284, 8305, 8665, 8667, 8694, 8829, 8974, 8992, 9003, 9018, 9148, 9167, 9195, 9251, 9289, 9325, 9381, 9551, 9599, 9890, 10029, 10232, 10295, 10398, 10548, 10581, 10643, 10687, 10718, 10826, 10846, 11023, 11143, 11213, 11255, 11269, 11282, 11416, 11440, 11576, 11681, 11690, 11711, 12030, 12049, 12114, 12360, 12434, 12540, 12768, 12858, 12953, 12996, 13012, 13084, 13094, 13233, 13268, 13325, 13496, 13583, 13734, 13834, 13875, 13955, 13970, 14095, 14297, 14523, 14652, 14755, 14976, 15101, 15312, 15350, 15392, 15396, 15441, 15481, 15483, 15622, 15724, 15735, 15814, 15899, 15916, 15990, 16195, 16241, 16402, 16460, 16590, 16663, 16807, 16868, 17018, 17038, 17043, 17096, 17191, 17193, 17195, 17211, 17245, 17316, 17423, 17428, 17470, 17608, 17633, 17740, 17841, 17866, 17898, 17995, 18182, 18344, 18435, 18499, 18507, 18607, 18618, 18620, 18623, 18691, 18699, 18717, 18887, 18935, 18979, 19006, 19007, 19056, 19325, 19447, 19561, 19577, 19620, 19764 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(116, result.number);
            Assert.AreEqual(2353958, result.newNumber);
        }


        [TestMethod]
        public void TestMethod499()
        {
            int[] numbers = new int[] { 40, 488, 849, 1145, 1394, 1424, 1455, 1527, 1648, 1662, 1767, 1799, 2137, 2178, 2460, 2592, 2864, 3043, 3157, 3366, 3535, 3552, 3763, 3813, 4289, 4636, 4670, 4709, 4923, 5337, 5458, 5890, 6058, 6354, 6401, 6543, 6570, 6592, 6995, 7147, 7499, 7717, 7824, 8229, 8371, 8487, 8672, 8706, 8707, 8724, 8773, 9149, 9365, 9598, 9636, 9765, 10038, 10285, 10776, 11071, 11216, 11266, 11299, 11488, 11582, 11609, 11628, 12133, 12200, 12423, 12491, 12670, 12778, 13002, 13094, 13135, 13403, 13727, 13836, 13984, 14097, 14327, 14503, 14796, 14847, 14865, 15037, 15365, 15597, 15740, 15860, 15866, 16022, 16112, 16572, 16629, 16666, 17025, 17060, 17078, 17370, 17464, 17508, 17792, 17835, 18148, 18156, 18683, 18753, 18788, 18826, 18902, 18943, 18966, 19088, 19124, 19158, 19425, 19465, 19482, 19488, 19498 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(488, result.number);
            Assert.AreEqual(1293025, result.newNumber);
        }


        [TestMethod]
        public void TestMethod500()
        {
            int[] numbers = new int[] { 33, 51, 95, 331, 414, 724, 731, 821, 849, 1188, 1257, 1290, 1347, 1368, 1393, 1459, 1598, 1736, 1801, 1840, 1846, 1882, 2018, 2061, 2073, 2097, 2318, 2388, 2402, 2404, 2459, 2493, 2557, 2560, 2597, 2689, 2741, 2793, 2911, 3014, 3056, 3129, 3139, 3224, 3249, 3253, 3267, 3328, 3348, 3364, 3381, 3394, 3397, 3466, 3494, 3544, 3602, 3624, 3646, 3652, 3729, 3820, 4000, 4079, 4090, 4164, 4177, 4254, 4399, 4406, 4491, 4571, 4582, 4612, 4694, 4717, 4755, 4849, 4925, 4999, 5046, 5125, 5155, 5218, 5267, 5336, 5455, 5478, 5570, 5674, 5682, 5785, 5813, 5818, 5928, 6020, 6103, 6127, 6231, 6316, 6362, 6387, 6496, 6498, 6505, 6543, 6751, 6773, 6950, 7055, 7234, 7318, 7459, 7465, 7470, 7526, 7626, 7658, 7758, 7874, 7884, 7898, 7968, 7981, 8076, 8155, 8358, 8394, 8456, 8459, 8692, 8712, 8837, 8842, 9064, 9069, 9112, 9406, 9445, 9460, 9468, 9543, 9568, 9631, 9660, 9693, 9727, 9729, 9737, 9753, 9764, 9797, 9865, 9963, 9976, 10012, 10078, 10082, 10098, 10279, 10303, 10403, 10418, 10455, 10633, 10851, 10953, 11124, 11219, 11344, 11469, 11556, 11796, 11886, 11981, 12090, 12138, 12286, 12315, 12364, 12414, 12420, 12493, 12499, 12514, 12623, 12626, 12832, 12833, 12861, 12898, 13058, 13148, 13187, 13261, 13356, 13383, 13402, 13594, 13629, 13633, 13701, 13704, 13710, 13827, 14240, 14280, 14310, 14338, 14401, 14454, 14467, 14511, 14567, 14587, 14612, 14645, 14670, 14776, 14826, 14846, 15064, 15295, 15339, 15359, 15439, 15486, 15642, 15679, 15698, 15717, 15759, 15879, 15923, 15945, 16037, 16188, 16306, 16405, 16570, 16685, 16974, 17025, 17048, 17080, 17171, 17328, 17328, 17347, 17352, 17366, 17436, 17453, 17526, 17581, 17701, 17746, 17776, 17812, 17956, 17975, 17992, 18006, 18057, 18234, 18395, 18508, 18531, 18558, 18582, 18809, 18876, 18888, 19065, 19310, 19352, 19404, 19433, 19481, 19575, 19652, 19652, 19657, 19681, 19723, 19754, 19843, 19934, 19963 };

            var result = Program.Solve(numbers);
            Assert.AreEqual(33, result.number);
            Assert.AreEqual(2833441, result.newNumber);
        }
    }
}
