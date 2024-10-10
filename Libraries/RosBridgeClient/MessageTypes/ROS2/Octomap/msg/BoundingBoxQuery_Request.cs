/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

using RosSharp.RosBridgeClient.MessageTypes.Geometry;

namespace RosSharp.RosBridgeClient.MessageTypes.Octomap
{
    public class BoundingBoxQuery_Request : Message
    {
        public const string RosMessageName = "octomap_msgs/msg/BoundingBoxQuery_Request";

        //  Clear a region specified by a global axis-aligned bounding box in stored OctoMap
        //  minimum corner point of axis-aligned bounding box in global frame
        public Point min { get; set; }
        //  maximum corner point of axis-aligned bounding box in global frame
        public Point max { get; set; }

        public BoundingBoxQuery_Request()
        {
            this.min = new Point();
            this.max = new Point();
        }

        public BoundingBoxQuery_Request(Point min, Point max)
        {
            this.min = min;
            this.max = max;
        }
    }
}
#endif
