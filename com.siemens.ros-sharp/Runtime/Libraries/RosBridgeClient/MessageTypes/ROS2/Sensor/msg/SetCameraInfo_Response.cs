/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.Sensor
{
    public class SetCameraInfo_Response : Message
    {
        public const string RosMessageName = "sensor_msgs/msg/SetCameraInfo_Response";

        public bool success { get; set; }
        //  True if the call succeeded
        public string status_message { get; set; }
        //  Used to give details about success

        public SetCameraInfo_Response()
        {
            this.success = false;
            this.status_message = "";
        }

        public SetCameraInfo_Response(bool success, string status_message)
        {
            this.success = success;
            this.status_message = status_message;
        }
    }
}
#endif
