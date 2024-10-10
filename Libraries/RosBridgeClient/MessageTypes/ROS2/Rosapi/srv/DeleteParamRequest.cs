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
    public class DeleteParamRequest : Message
    {
        public const string RosMessageName = "rosapi_msgs/srv/DeleteParam";

        public string name { get; set; }

        public DeleteParamRequest()
        {
            this.name = "";
        }

        public DeleteParamRequest(string name)
        {
            this.name = name;
        }
    }
}
#endif
