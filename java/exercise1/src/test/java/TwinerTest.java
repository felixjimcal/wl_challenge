import org.example.Twiner;
import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;

public class TwinerTest {
    // https://stackoverflow.com/questions/19330832/setting-up-junit-with-intellij-idea
    // https://www.juntadeandalucia.es/servicios/madeja/contenido/recurso/248

    Twiner twiner;

    @Before
    public void SetUp() {
        twiner = new Twiner();
    }

    @Test
    public void DifferentLength() {
        String a = "abc", b = "abcd";
        Assert.assertFalse(twiner.AreTwins(a, b));
    }

    @Test
    public void TestAllLowerCase() {
        String a = "aBc", b = "AbC";
        Assert.assertTrue(twiner.AreTwins(a, b));
    }

    @Test
    public void SortCharacters() {
        String a = "cBa", b = "Bca";
        Assert.assertTrue(twiner.AreTwins(a, b));
    }

    @Test
    public void TestLowerSortedAndSameFALSE() {
        String a = "cBa", b = "BcD";
        Assert.assertFalse(twiner.AreTwins(a, b));
    }

    @Test
    public void TestLowerSortedAndSameTRUE() {
        String a = "cBa", b = "Bca";
        Assert.assertTrue(twiner.AreTwins(a, b));
    }
}
