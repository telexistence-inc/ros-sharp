/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.Rosapi
{
    public class SetParam_Request : Message
    {
        public const string RosMessageName = "rosapi_msgs/msg/SetParam_Request";

        public string name { get; set; }
        public string value { get; set; }

        public SetParam_Request()
        {
            this.name = "";
            this.value = "";
        }

        public SetParam_Request(string name, string value)
        {
            this.name = name;
            this.value = value;
        }
    }
}
#endif
