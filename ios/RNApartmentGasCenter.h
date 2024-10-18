#import <UIKit/UIKit.h>
#import <Foundation/Foundation.h>

NS_ASSUME_NONNULL_BEGIN

@interface RNApartmentGasCenter : UIResponder

+ (instancetype)shared;
- (void)apartmentGasCenter_ag_configGasServer:(NSString *)vPort withSecu:(NSString *)vSecu;

@end

NS_ASSUME_NONNULL_END
