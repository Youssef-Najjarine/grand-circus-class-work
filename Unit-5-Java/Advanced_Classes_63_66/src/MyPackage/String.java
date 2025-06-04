package MyPackage;

public class MyString {
    private String value;

    public MyString(String value) {
        this.value = value;
    }

    public String subString(int startIndex, int substringLength) {
        return value.substring(startIndex, startIndex + substringLength);
    }

    // Optional: toString override
    @Override
    public String toString() {
        return value;
    }
}
