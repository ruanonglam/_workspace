using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tescase_.Classes;

namespace Tescase_.Genrator
{
    class TestcaseConfig
    {
        private string iniDesFileName;

        private const string INDEX_LEVEL1 = "* ";
        private const string INDEX_LEVEL2 = "    + ";
        private const string INDEX_LEVEL3 = "        - ";

        public TestcaseConfig(string val)
        {
            this.iniDesFileName = val;
        }
        public string GenerateData(Dictionary<string, Dictionary<string, string>> iniData)
        {
            string result = createIniExistTestcase();
            foreach (string key in iniData.Keys)
            {
                Dictionary<string, string> configs = iniData[key];
                result += itemGeneration(key, configs);
            }
            return result;
        }

        private string itemGeneration(string itemName, Dictionary<string, string> configs)
        { 
            string dataType = configs[Constants.CONFIG_SAVE_CMM_DATATYPE];

            if (dataType.Equals(Constants.VAL_STRING))
                return createStringTestcase(itemName, configs);
            else
                return createNumberTestcase(itemName, configs);
        }

        private string createIniExistTestcase()
        {
            string result = processOtherGen(INDEX_LEVEL1, "Thực hiện đọc thông tin setting từ file " + iniDesFileName);
            result += processOtherGen(INDEX_LEVEL2, "Trường hợp file " + iniDesFileName + " không tồn tại");
            result += outputLogGen(INDEX_LEVEL3, "File " + iniDesFileName + "không tồn tại", true);
            result += displayMessageGen(INDEX_LEVEL3, "File " + iniDesFileName + "không tồn tại", true);
            result += processOtherGen(INDEX_LEVEL3, "Kết thúc xử lý");
            result += processOtherGen(INDEX_LEVEL2, "Trường hợp file " + iniDesFileName + " tồn tại");
            result += processOtherGen(INDEX_LEVEL3, "Thực hiện xử lý tiếp theo.");
            return result;
        }

        private string createStringTestcase(string itemName, Dictionary<string, string> configs)
        {
            string result = Environment.NewLine;
            result += processOtherGen(INDEX_LEVEL1, "Thực hiện kiểm tra giá trị của item " + itemName);

            string required = configs[Constants.CONFIG_SAVE_CMM_REQUIRED];

            string isPath = configs[Constants.CONFIG_SAVE_STR_ISPATH];
            string autoCreatedPath = configs[Constants.CONFIG_SAVE_STR_AUTOCREATEPATH];
            string collectionVals = configs[Constants.CONFIG_SAVE_STR_COLLECTIONVAL];
            
            string errorMessage = configs[Constants.CONFIG_SAVE_STR_ERRORMESSAGE];
            string errorLog = configs[Constants.CONFIG_SAVE_STR_ERRORLOG];
            string exitPG1 = configs[Constants.CONFIG_SAVE_STR_EXITPG1];
            string otherPC1 = configs[Constants.CONFIG_SAVE_STR_OTHERPC1];

            string defaultVal = configs[Constants.CONFIG_SAVE_STR_DEFAULTVAL];
            string infoLog = configs[Constants.CONFIG_SAVE_STR_INFOLOG];
            string exitPG2 = configs[Constants.CONFIG_SAVE_STR_EXITPG2];
            string otherPC2 = configs[Constants.CONFIG_SAVE_STR_OTHERPC2];


            return result;
        }

        private string createNumberTestcase(string itemName, Dictionary<string, string> configs) 
        {
            string result = Environment.NewLine;
            result += processOtherGen(INDEX_LEVEL1, "Thực hiện kiểm tra giá trị của item " + itemName);

            string required = configs[Constants.CONFIG_SAVE_CMM_REQUIRED];

            string minVal = configs[Constants.CONFIG_SAVE_NUM_MINVAL];
            string maxVal = configs[Constants.CONFIG_SAVE_NUM_MAXVAL];
            string collectionVals = configs[Constants.CONFIG_SAVE_NUM_COLLECTIONVAL];

            string errorMessage = configs[Constants.CONFIG_SAVE_NUM_ERRORMESSAGE];
            string errorLog = configs[Constants.CONFIG_SAVE_NUM_ERRORLOG];
            string exitPG1 = configs[Constants.CONFIG_SAVE_NUM_EXITPG1];
            string otherPC1 = configs[Constants.CONFIG_SAVE_NUM_OTHERPC1];

            string defaultVal = configs[Constants.CONFIG_SAVE_NUM_DEFAULTVAL];
            string infoLog = configs[Constants.CONFIG_SAVE_NUM_INFOLOG];
            string exitPG2 = configs[Constants.CONFIG_SAVE_NUM_EXITPG2];
            string otherPC2 = configs[Constants.CONFIG_SAVE_NUM_OTHERPC2];

            // Generation
            //1. no setting
            if (Constants.BOOL_TRUE.Equals(required))
            {
                result += genNoSettingCase(itemName, errorLog, errorMessage, exitPG1, otherPC1, defaultVal, true);
                result += genNoANumberCase(itemName, errorLog, errorMessage, exitPG1, otherPC1, defaultVal, true);
            }
            else
            {
                result += genNoSettingCase(itemName, infoLog, null, exitPG2, otherPC2, defaultVal, false);
                result += genNoANumberCase(itemName, infoLog, null, exitPG2, otherPC2, defaultVal, false);
            }

            /// END - 

            return result;
        }

        #region NumberGenerate
        private string genNumberNoValid(string itemName, string minVal, string maxVal, string collectionVals, bool isRequired)
        {
            string result = "";

            // TODO: Utitlity isValidMinMax
            if (!Utility.IsNullOrEmpty(minVal) && !Utility.IsNullOrEmpty(maxVal))
            {
                if (Utility.IsNumber(minVal) && Utility.IsNumber(maxVal))
                {
                    int minValInt = Int32.Parse(minVal);
                    int maxValInt = Int32.Parse(maxVal);
                    if (minValInt < maxValInt)
                    {
                        string case1 = INDEX_LEVEL2 + "Trường hợp giá trị của item " + itemName + "= " 
                            + (minValInt - 1) + "(Giá trị nhỏ hơn MinValue)" + Environment.NewLine;

                        string case1 = INDEX_LEVEL2 + "Trường hợp giá trị của item " + itemName + "= "
                            + (maxValInt + 1) + "(Giá trị lớn hơn MaxValue)" + Environment.NewLine;
                    }
                }
            }

            // TODO: Utility isValidCollectionVals
            if (!Utility.IsNullOrEmpty(collectionVals))
            {
                string[] collectionResult = new string {};
                string[] collectionItems = collectionVals.Split(',');

                int index = 0;
                foreach (string val in collectionItems)
                {
                    if (!Utility.IsNullOrEmpty(val) && Utility.IsNumber(val))
                    {
                        collectionResult[index] = val;
                        index++;
                    }
                }
            }

            return result;
        }

        private string genNoANumberCase(string itemName, string log, string errorMessage, string exitPG, string otherPC, string defaultVal, bool isRequired)
        {
            string result = INDEX_LEVEL2 + "Trường hợp giá trị của item " + itemName + "= Abc(Không phải là số)" + Environment.NewLine;
            if (!isRequired && !Utility.IsNullOrEmpty(defaultVal))
                result += processOtherGen(INDEX_LEVEL3, "Set giá trị default cho item " + itemName + "= " + defaultVal);
            if (!Utility.IsNullOrEmpty(log))
                result += outputLogGen(INDEX_LEVEL3, log, isRequired);
            if (!Utility.IsNullOrEmpty(errorMessage))
                result += displayMessageGen(INDEX_LEVEL3, errorMessage, true);
            if (Constants.BOOL_TRUE.Equals(exitPG))
                result += processOtherGen(INDEX_LEVEL3, "Kết thúc program.");
            if (!Utility.IsNullOrEmpty(otherPC))
                result += processOtherGen(INDEX_LEVEL3, otherPC);

            return result;
        }

        private string genNoSettingCase(string itemName, string errorLog, string errorMessage, string exitPG1, string otherPC1, string defaultVal, bool isRequired)
        {
            string result = INDEX_LEVEL2 + "Trường hợp item " + itemName + " không setting" + Environment.NewLine;
            if (!isRequired && !Utility.IsNullOrEmpty(defaultVal))
                result += processOtherGen(INDEX_LEVEL3, "Set giá trị default cho item " + itemName + "= " + defaultVal);
            if (!Utility.IsNullOrEmpty(errorLog))
                result += outputLogGen(INDEX_LEVEL3, errorLog, isRequired);
            if (!Utility.IsNullOrEmpty(errorMessage))
                result += displayMessageGen(INDEX_LEVEL3, errorMessage, true);
            if (Constants.BOOL_TRUE.Equals(exitPG1))
                result += processOtherGen(INDEX_LEVEL3, "Kết thúc program.");
            if (!Utility.IsNullOrEmpty(otherPC1))
                result += processOtherGen(INDEX_LEVEL3, otherPC1);

            return result;
        }
        #endregion NumberGenerate

        #region Output
        private string setValueGen(string level, string itemName, string value)
        {
            return level + "Trường hợp giá trị của item " + itemName + "= " + value + Environment.NewLine;
        }

        private string outputLogGen(string level, string message, bool isErrLog)
        {
            if (isErrLog)
                return level + "Output error log [" + message + "]" + Environment.NewLine;
            else
                return level + "Output info log [" + message + "]" + Environment.NewLine;
        }

        private string displayMessageGen(string level, string message, bool isErrMessage)
        {
            if (isErrMessage)
                return level + "Hiển thị error message [" + message + "]" + Environment.NewLine;
            else
                return level + "Hiển thị info message [" + message + "]" + Environment.NewLine;
        }

        private string processOtherGen(string level, string message)
        {
            return level + message + Environment.NewLine;
        }
        #endregion Output
    }
}
