/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if !ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.Rosapi
{
    public class ServiceHostResponse : Message
    {
        public const string RosMessageName = "rosapi/ServiceHost";

        public string host { get; set; }

        public ServiceHostResponse()
        {
            this.host = "";
        }

        public ServiceHostResponse(string host)
        {
            this.host = host;
        }
    }
}
#endif
