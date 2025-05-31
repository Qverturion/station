namespace Content.Shared._Pirate.Aiming.Events;

// Raised when the aiming gun shoots at anything
public sealed class OnAimerShootingEvent : EntityEventArgs
{
    public readonly EntityUid Gun;
    public readonly EntityUid User;
    public OnAimerShootingEvent(EntityUid gun, EntityUid user)
    {
        Gun = gun;
        User = user;
    }
}
