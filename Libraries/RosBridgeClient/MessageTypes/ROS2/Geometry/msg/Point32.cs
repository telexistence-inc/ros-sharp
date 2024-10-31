/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.Geometry
{
    public class Point32 : Message
    {
        public const string RosMessageName = "geometry_msgs/msg/Point32";

        //  This contains the position of a point in free space(with 32 bits of precision).
        //  It is recommended to use Point wherever possible instead of Point32.
        // 
        //  This recommendation is to promote interoperability.
        // 
        //  This message is designed to take up less space when sending
        //  lots of points at once, as in the case of a PointCloud.
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }

        public Point32()
        {
            this.x = 0.0f;
            this.y = 0.0f;
            this.z = 0.0f;
        }

        public Point32(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
#endif