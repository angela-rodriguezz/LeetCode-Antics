class Solution {
    public boolean isValid(String s) {
        Stack<Character> ref = new Stack<>();

        if (s.length() % 2 != 0) {
            return false;
        } 

        for (int i = 0; i < s.length(); i++) {
            if (s.charAt(i) == '(' || s.charAt(i) == '[' || s.charAt(i) == '{') {
                ref.push(s.charAt(i));
            } else if (s.charAt(i) == ')' || s.charAt(i) == ']' || s.charAt(i) == '}') {
                if (ref.isEmpty()) {
                    return false;
                }
                if (s.charAt(i) == ')' && ref.peek() != '(') {
                    return false;
                } if (s.charAt(i) == ']' && ref.peek() != '[') {
                    return false;
                } if (s.charAt(i) == '}' && ref.peek() != '{') {
                    return false;
                }
                ref.pop();
            } 
        }

        if (!ref.isEmpty()) {
            return false;
        }
        return true;
    }
}
