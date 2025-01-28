namespace SystemDesign.InternalEvents.Media;

public sealed record MediaUploadedEvent(string FileName, string Url, string ObjectId, DateTime OccurredOn);