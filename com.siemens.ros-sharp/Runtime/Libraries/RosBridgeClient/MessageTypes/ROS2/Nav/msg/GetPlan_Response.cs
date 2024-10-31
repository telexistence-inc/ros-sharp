/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.Nav
{
    public class GetPlan_Response : Message
    {
        public const string RosMessageName = "nav_msgs/msg/GetPlan_Response";

        //  Array of poses from start to goal if one was successfully found.
        public Path plan { get; set; }

        public GetPlan_Response()
        {
            this.plan = new Path();
        }

        public GetPlan_Response(Path plan)
        {
            this.plan = plan;
        }
    }
}
#endif