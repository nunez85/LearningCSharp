namespace LanguageFeatures;

public class OrderProcessor {
    public delegate void OrderInitialized();
    public delegate void ProcessCompleted();

    public OrderInitialized OnOrderInitialized { get; set; }

    private void Initialize(Order order) {
        ArgumentNullException.ThrowIfNull(order);

        // You could just call the delegate like OnOrderInitialized() but it would throw
        // an error because it is null. Instead, Invoke safely invokes your delegate.
        OnOrderInitialized?.Invoke();
    }

    public void ProcessOrder(Order order, ProcessCompleted onCompleted = default) {
        Initialize(order);
        onCompleted?.Invoke();
    }
}