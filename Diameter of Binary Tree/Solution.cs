/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode() {}
 *     TreeNode(int val) { this.val = val; }
 *     TreeNode(int val, TreeNode left, TreeNode right) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
class Solution {
    private int diameter = 0;
    public int diameterOfBinaryTree(TreeNode root) {
        getHeight(root);
        return diameter;
    }
    private int getHeight(TreeNode rooter) {
        if (rooter == null) {
            return 0;
        }

        int leftHeight = getHeight(rooter.left);
        int rightHeight = getHeight(rooter.right);

        diameter = Math.max(leftHeight + rightHeight, diameter);
        return Math.max(leftHeight, rightHeight) + 1;
    }
}
